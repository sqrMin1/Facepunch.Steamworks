﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	/// <summary>
	/// Functions for clients to access matchmaking services, favorites, and to operate on game lobbies
	/// </summary>
	public static class SteamMatchmaking
	{
		/// <summary>
		/// Maximum number of characters a lobby metadata key can be
		/// </summary>
		internal static int MaxLobbyKeyLength => 255;


		static ISteamMatchmaking _internal;

		internal static ISteamMatchmaking Internal
		{
			get
			{
				if ( _internal == null )
				{
					_internal = new ISteamMatchmaking();
					_internal.Init();
				}

				return _internal;
			}
		}

		internal static void Shutdown()
		{
			_internal = null;
		}

		internal static void InstallEvents()
		{
			LobbyInvite_t.Install( x => OnLobbyInvite?.Invoke( new Friend( x.SteamIDUser ), new Lobby( x.SteamIDLobby ) ) );

			LobbyEnter_t.Install( x => OnLobbyEntered?.Invoke( new Lobby( x.SteamIDLobby ) ) );

			LobbyCreated_t.Install( x => OnLobbyCreated?.Invoke( x.Result, new Lobby( x.SteamIDLobby ) ) );

			LobbyGameCreated_t.Install( x => OnLobbyGameCreated?.Invoke( new Lobby( x.SteamIDLobby ), x.IP, x.Port, x.SteamIDGameServer ) );

			LobbyDataUpdate_t.Install( x =>
			{
				if ( x.Success == 0 ) return;

				if ( x.SteamIDLobby == x.SteamIDMember )
					OnLobbyDataChanged?.Invoke( new Lobby( x.SteamIDLobby ) );
				else
					OnLobbyMemberDataChanged?.Invoke( new Lobby( x.SteamIDLobby ), new Friend( x.SteamIDMember ) );
			} );

			LobbyChatUpdate_t.Install( x =>
			{
				if ( (x.GfChatMemberStateChange & (int)ChatMemberStateChange.Entered) != 0 )
					OnLobbyMemberJoined?.Invoke( new Lobby( x.SteamIDLobby ), new Friend( x.SteamIDUserChanged ) );

				if ( (x.GfChatMemberStateChange & (int)ChatMemberStateChange.Left) != 0 )
					OnLobbyMemberLeave?.Invoke( new Lobby( x.SteamIDLobby ), new Friend( x.SteamIDUserChanged ) );

				if ( (x.GfChatMemberStateChange & (int)ChatMemberStateChange.Disconnected) != 0 )
					OnLobbyMemberDisconnected?.Invoke( new Lobby( x.SteamIDLobby ), new Friend( x.SteamIDUserChanged ) );

				if ( (x.GfChatMemberStateChange & (int)ChatMemberStateChange.Kicked) != 0 )
					OnLobbyMemberKicked?.Invoke( new Lobby( x.SteamIDLobby ), new Friend( x.SteamIDUserChanged ), new Friend( x.SteamIDMakingChange ) );

				if ( (x.GfChatMemberStateChange & (int)ChatMemberStateChange.Banned) != 0 )
					OnLobbyMemberBanned?.Invoke( new Lobby( x.SteamIDLobby ), new Friend( x.SteamIDUserChanged ), new Friend( x.SteamIDMakingChange ) );
			} );

			LobbyChatMsg_t.Install( OnLobbyChatMessageRecievedAPI );
		}

		static private unsafe void OnLobbyChatMessageRecievedAPI( LobbyChatMsg_t callback )
		{
			SteamId steamid = default;
			ChatEntryType chatEntryType = default;
			var buffer = Helpers.TakeBuffer( 1024 * 4 );

			fixed ( byte* p = buffer )
			{
				var readData = Internal.GetLobbyChatEntry( callback.SteamIDLobby, (int)callback.ChatID, ref steamid, (IntPtr)p, buffer.Length, ref chatEntryType );

				if ( readData > 0 )
				{
					OnChatMessage?.Invoke( new Lobby( callback.SteamIDLobby ), new Friend( steamid ), Encoding.UTF8.GetString( buffer, 0, readData ) );
				}
			}
		}

		/// <summary>
		/// Someone invited you to a lobby
		/// </summary>
		public static event Action<Friend, Lobby> OnLobbyInvite;

		/// <summary>
		/// You joined a lobby
		/// </summary>
		public static event Action<Lobby> OnLobbyEntered;

		/// <summary>
		/// You created a lobby
		/// </summary>
		public static event Action<Result, Lobby> OnLobbyCreated;

		/// <summary>
		/// A game server has been associated with the lobby
		/// </summary>
		public static event Action<Lobby, uint, ushort, SteamId> OnLobbyGameCreated;

		/// <summary>
		/// The lobby metadata has changed
		/// </summary>
		public static event Action<Lobby> OnLobbyDataChanged;

		/// <summary>
		/// The lobby member metadata has changed
		/// </summary>
		public static event Action<Lobby, Friend> OnLobbyMemberDataChanged;

		/// <summary>
		/// The lobby member joined
		/// </summary>
		public static event Action<Lobby, Friend> OnLobbyMemberJoined;

		/// <summary>
		/// The lobby member left the room
		/// </summary>
		public static event Action<Lobby, Friend> OnLobbyMemberLeave;

		/// <summary>
		/// The lobby member left the room
		/// </summary>
		public static event Action<Lobby, Friend> OnLobbyMemberDisconnected;

		/// <summary>
		/// The lobby member was kicked. The 3rd param is the user that kicked them.
		/// </summary>
		public static event Action<Lobby, Friend, Friend> OnLobbyMemberKicked;

		/// <summary>
		/// The lobby member was banned. The 3rd param is the user that banned them.
		/// </summary>
		public static event Action<Lobby, Friend, Friend> OnLobbyMemberBanned;

		/// <summary>
		/// A chat message was recieved from a member of a lobby
		/// </summary>
		public static event Action<Lobby, Friend, string> OnChatMessage;

		public static LobbyQuery LobbyList => new LobbyQuery();

		/// <summary>
		/// Creates a new invisible lobby. Call lobby.SetPublic to take it online.
		/// </summary>
		public static async Task<Lobby?> CreateLobbyAsync( int maxMembers = 100 )
		{
			var lobby = await Internal.CreateLobby( LobbyType.Invisible, maxMembers );
			if ( !lobby.HasValue || lobby.Value.Result != Result.OK ) return null;

			return new Lobby { Id = lobby.Value.SteamIDLobby };
		}

		/// <summmary>
		/// Attempts to directly join the specified lobby
		/// </summmary>
		public static async Task<Lobby?> JoinLobbyAsync( SteamId lobbyId )
		{
			var lobby = await Internal.JoinLobby( lobbyId );
			if ( !lobby.HasValue ) return null;

			return new Lobby { Id = lobby.Value.SteamIDLobby };
		}

		/// <summary>
		/// Get a list of servers that are on your favorites list
		/// </summary>
		public static IEnumerable<ServerInfo> GetFavoriteServers()
		{
			var count = Internal.GetFavoriteGameCount();

			for( int i=0; i<count; i++ )
			{
				uint timeplayed = 0;
				uint flags = 0;
				ushort qport = 0;
				ushort cport = 0;
				uint ip = 0;
				AppId appid = default;

				if ( Internal.GetFavoriteGame( i, ref appid, ref ip, ref cport, ref qport, ref flags, ref timeplayed ) )
				{
					if ( (flags & ServerInfo.k_unFavoriteFlagFavorite) == 0 ) continue;
					yield return new ServerInfo( ip, cport, qport, timeplayed );
				}
			}
		}

		/// <summary>
		/// Get a list of servers that you have added to your play history
		/// </summary>
		public static IEnumerable<ServerInfo> GetHistoryServers()
		{
			var count = Internal.GetFavoriteGameCount();

			for ( int i = 0; i < count; i++ )
			{
				uint timeplayed = 0;
				uint flags = 0;
				ushort qport = 0;
				ushort cport = 0;
				uint ip = 0;
				AppId appid = default;

				if ( Internal.GetFavoriteGame( i, ref appid, ref ip, ref cport, ref qport, ref flags, ref timeplayed ) )
				{
					if ( (flags & ServerInfo.k_unFavoriteFlagHistory) == 0 ) continue;
					yield return new ServerInfo( ip, cport, qport, timeplayed );
				}
			}
		}

	}
}