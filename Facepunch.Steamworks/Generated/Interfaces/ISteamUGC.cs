using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Steamworks.Data;


namespace Steamworks
{
	internal class ISteamUGC : SteamInterface
	{
		public override string InterfaceName => "STEAMUGC_INTERFACE_VERSION012";
		
		public override void InitInternals()
		{
			_CreateQueryUserUGCRequest = Marshal.GetDelegateForFunctionPointer<FCreateQueryUserUGCRequest>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 0 ) ) );
			_CreateQueryUGCDetailsRequest = Marshal.GetDelegateForFunctionPointer<FCreateQueryUGCDetailsRequest>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 24 ) ) );
			_SendQueryUGCRequest = Marshal.GetDelegateForFunctionPointer<FSendQueryUGCRequest>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 32 ) ) );
			_GetQueryUGCResult = Marshal.GetDelegateForFunctionPointer<FGetQueryUGCResult>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 40 ) ) );
			_GetQueryUGCPreviewURL = Marshal.GetDelegateForFunctionPointer<FGetQueryUGCPreviewURL>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 48 ) ) );
			_GetQueryUGCMetadata = Marshal.GetDelegateForFunctionPointer<FGetQueryUGCMetadata>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 56 ) ) );
			_GetQueryUGCChildren = Marshal.GetDelegateForFunctionPointer<FGetQueryUGCChildren>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 64 ) ) );
			_GetQueryUGCStatistic = Marshal.GetDelegateForFunctionPointer<FGetQueryUGCStatistic>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 72 ) ) );
			_GetQueryUGCNumAdditionalPreviews = Marshal.GetDelegateForFunctionPointer<FGetQueryUGCNumAdditionalPreviews>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 80 ) ) );
			_GetQueryUGCAdditionalPreview = Marshal.GetDelegateForFunctionPointer<FGetQueryUGCAdditionalPreview>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 88 ) ) );
			_GetQueryUGCNumKeyValueTags = Marshal.GetDelegateForFunctionPointer<FGetQueryUGCNumKeyValueTags>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 96 ) ) );
			_GetQueryUGCKeyValueTag = Marshal.GetDelegateForFunctionPointer<FGetQueryUGCKeyValueTag>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 104 ) ) );
			_ReleaseQueryUGCRequest = Marshal.GetDelegateForFunctionPointer<FReleaseQueryUGCRequest>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 112 ) ) );
			_AddRequiredTag = Marshal.GetDelegateForFunctionPointer<FAddRequiredTag>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 120 ) ) );
			_AddExcludedTag = Marshal.GetDelegateForFunctionPointer<FAddExcludedTag>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 128 ) ) );
			_SetReturnOnlyIDs = Marshal.GetDelegateForFunctionPointer<FSetReturnOnlyIDs>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 136 ) ) );
			_SetReturnKeyValueTags = Marshal.GetDelegateForFunctionPointer<FSetReturnKeyValueTags>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 144 ) ) );
			_SetReturnLongDescription = Marshal.GetDelegateForFunctionPointer<FSetReturnLongDescription>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 152 ) ) );
			_SetReturnMetadata = Marshal.GetDelegateForFunctionPointer<FSetReturnMetadata>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 160 ) ) );
			_SetReturnChildren = Marshal.GetDelegateForFunctionPointer<FSetReturnChildren>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 168 ) ) );
			_SetReturnAdditionalPreviews = Marshal.GetDelegateForFunctionPointer<FSetReturnAdditionalPreviews>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 176 ) ) );
			_SetReturnTotalOnly = Marshal.GetDelegateForFunctionPointer<FSetReturnTotalOnly>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 184 ) ) );
			_SetReturnPlaytimeStats = Marshal.GetDelegateForFunctionPointer<FSetReturnPlaytimeStats>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 192 ) ) );
			_SetLanguage = Marshal.GetDelegateForFunctionPointer<FSetLanguage>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 200 ) ) );
			_SetAllowCachedResponse = Marshal.GetDelegateForFunctionPointer<FSetAllowCachedResponse>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 208 ) ) );
			_SetCloudFileNameFilter = Marshal.GetDelegateForFunctionPointer<FSetCloudFileNameFilter>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 216 ) ) );
			_SetMatchAnyTag = Marshal.GetDelegateForFunctionPointer<FSetMatchAnyTag>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 224 ) ) );
			_SetSearchText = Marshal.GetDelegateForFunctionPointer<FSetSearchText>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 232 ) ) );
			_SetRankedByTrendDays = Marshal.GetDelegateForFunctionPointer<FSetRankedByTrendDays>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 240 ) ) );
			_AddRequiredKeyValueTag = Marshal.GetDelegateForFunctionPointer<FAddRequiredKeyValueTag>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 248 ) ) );
			_RequestUGCDetails = Marshal.GetDelegateForFunctionPointer<FRequestUGCDetails>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 256 ) ) );
			_CreateItem = Marshal.GetDelegateForFunctionPointer<FCreateItem>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 264 ) ) );
			_StartItemUpdate = Marshal.GetDelegateForFunctionPointer<FStartItemUpdate>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 272 ) ) );
			_SetItemTitle = Marshal.GetDelegateForFunctionPointer<FSetItemTitle>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 280 ) ) );
			_SetItemDescription = Marshal.GetDelegateForFunctionPointer<FSetItemDescription>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 288 ) ) );
			_SetItemUpdateLanguage = Marshal.GetDelegateForFunctionPointer<FSetItemUpdateLanguage>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 296 ) ) );
			_SetItemMetadata = Marshal.GetDelegateForFunctionPointer<FSetItemMetadata>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 304 ) ) );
			_SetItemVisibility = Marshal.GetDelegateForFunctionPointer<FSetItemVisibility>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 312 ) ) );
			_SetItemTags = Marshal.GetDelegateForFunctionPointer<FSetItemTags>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 320 ) ) );
			_SetItemContent = Marshal.GetDelegateForFunctionPointer<FSetItemContent>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 328 ) ) );
			_SetItemPreview = Marshal.GetDelegateForFunctionPointer<FSetItemPreview>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 336 ) ) );
			_SetAllowLegacyUpload = Marshal.GetDelegateForFunctionPointer<FSetAllowLegacyUpload>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 344 ) ) );
			_RemoveItemKeyValueTags = Marshal.GetDelegateForFunctionPointer<FRemoveItemKeyValueTags>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 352 ) ) );
			_AddItemKeyValueTag = Marshal.GetDelegateForFunctionPointer<FAddItemKeyValueTag>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 360 ) ) );
			_AddItemPreviewFile = Marshal.GetDelegateForFunctionPointer<FAddItemPreviewFile>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 368 ) ) );
			_AddItemPreviewVideo = Marshal.GetDelegateForFunctionPointer<FAddItemPreviewVideo>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 376 ) ) );
			_UpdateItemPreviewFile = Marshal.GetDelegateForFunctionPointer<FUpdateItemPreviewFile>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 384 ) ) );
			_UpdateItemPreviewVideo = Marshal.GetDelegateForFunctionPointer<FUpdateItemPreviewVideo>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 392 ) ) );
			_RemoveItemPreview = Marshal.GetDelegateForFunctionPointer<FRemoveItemPreview>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 400 ) ) );
			_SubmitItemUpdate = Marshal.GetDelegateForFunctionPointer<FSubmitItemUpdate>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 408 ) ) );
			_GetItemUpdateProgress = Marshal.GetDelegateForFunctionPointer<FGetItemUpdateProgress>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 416 ) ) );
			_SetUserItemVote = Marshal.GetDelegateForFunctionPointer<FSetUserItemVote>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 424 ) ) );
			_GetUserItemVote = Marshal.GetDelegateForFunctionPointer<FGetUserItemVote>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 432 ) ) );
			_AddItemToFavorites = Marshal.GetDelegateForFunctionPointer<FAddItemToFavorites>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 440 ) ) );
			_RemoveItemFromFavorites = Marshal.GetDelegateForFunctionPointer<FRemoveItemFromFavorites>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 448 ) ) );
			_SubscribeItem = Marshal.GetDelegateForFunctionPointer<FSubscribeItem>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 456 ) ) );
			_UnsubscribeItem = Marshal.GetDelegateForFunctionPointer<FUnsubscribeItem>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 464 ) ) );
			_GetNumSubscribedItems = Marshal.GetDelegateForFunctionPointer<FGetNumSubscribedItems>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 472 ) ) );
			_GetSubscribedItems = Marshal.GetDelegateForFunctionPointer<FGetSubscribedItems>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 480 ) ) );
			_GetItemState = Marshal.GetDelegateForFunctionPointer<FGetItemState>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 488 ) ) );
			_GetItemInstallInfo = Marshal.GetDelegateForFunctionPointer<FGetItemInstallInfo>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 496 ) ) );
			_GetItemDownloadInfo = Marshal.GetDelegateForFunctionPointer<FGetItemDownloadInfo>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 504 ) ) );
			_DownloadItem = Marshal.GetDelegateForFunctionPointer<FDownloadItem>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 512 ) ) );
			_BInitWorkshopForGameServer = Marshal.GetDelegateForFunctionPointer<FBInitWorkshopForGameServer>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 520 ) ) );
			_SuspendDownloads = Marshal.GetDelegateForFunctionPointer<FSuspendDownloads>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 528 ) ) );
			_StartPlaytimeTracking = Marshal.GetDelegateForFunctionPointer<FStartPlaytimeTracking>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 536 ) ) );
			_StopPlaytimeTracking = Marshal.GetDelegateForFunctionPointer<FStopPlaytimeTracking>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 544 ) ) );
			_StopPlaytimeTrackingForAllItems = Marshal.GetDelegateForFunctionPointer<FStopPlaytimeTrackingForAllItems>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 552 ) ) );
			_AddDependency = Marshal.GetDelegateForFunctionPointer<FAddDependency>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 560 ) ) );
			_RemoveDependency = Marshal.GetDelegateForFunctionPointer<FRemoveDependency>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 568 ) ) );
			_AddAppDependency = Marshal.GetDelegateForFunctionPointer<FAddAppDependency>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 576 ) ) );
			_RemoveAppDependency = Marshal.GetDelegateForFunctionPointer<FRemoveAppDependency>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 584 ) ) );
			_GetAppDependencies = Marshal.GetDelegateForFunctionPointer<FGetAppDependencies>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 592 ) ) );
			_DeleteItem = Marshal.GetDelegateForFunctionPointer<FDeleteItem>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 600 ) ) );
			
			#if PLATFORM_WIN
			_CreateQueryAllUGCRequest1 = Marshal.GetDelegateForFunctionPointer<FCreateQueryAllUGCRequest1>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 16 ) ) );
			_CreateQueryAllUGCRequest2 = Marshal.GetDelegateForFunctionPointer<FCreateQueryAllUGCRequest2>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 8 ) ) );
			#else
			_CreateQueryAllUGCRequest1 = Marshal.GetDelegateForFunctionPointer<FCreateQueryAllUGCRequest1>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 8 ) ) );
			_CreateQueryAllUGCRequest2 = Marshal.GetDelegateForFunctionPointer<FCreateQueryAllUGCRequest2>( Marshal.ReadIntPtr( VTable, Platform.MemoryOffset( 16 ) ) );
			#endif
		}
		internal override void Shutdown()
		{
			base.Shutdown();
			
			_CreateQueryUserUGCRequest = null;
			_CreateQueryAllUGCRequest1 = null;
			_CreateQueryAllUGCRequest2 = null;
			_CreateQueryUGCDetailsRequest = null;
			_SendQueryUGCRequest = null;
			_GetQueryUGCResult = null;
			_GetQueryUGCPreviewURL = null;
			_GetQueryUGCMetadata = null;
			_GetQueryUGCChildren = null;
			_GetQueryUGCStatistic = null;
			_GetQueryUGCNumAdditionalPreviews = null;
			_GetQueryUGCAdditionalPreview = null;
			_GetQueryUGCNumKeyValueTags = null;
			_GetQueryUGCKeyValueTag = null;
			_ReleaseQueryUGCRequest = null;
			_AddRequiredTag = null;
			_AddExcludedTag = null;
			_SetReturnOnlyIDs = null;
			_SetReturnKeyValueTags = null;
			_SetReturnLongDescription = null;
			_SetReturnMetadata = null;
			_SetReturnChildren = null;
			_SetReturnAdditionalPreviews = null;
			_SetReturnTotalOnly = null;
			_SetReturnPlaytimeStats = null;
			_SetLanguage = null;
			_SetAllowCachedResponse = null;
			_SetCloudFileNameFilter = null;
			_SetMatchAnyTag = null;
			_SetSearchText = null;
			_SetRankedByTrendDays = null;
			_AddRequiredKeyValueTag = null;
			_RequestUGCDetails = null;
			_CreateItem = null;
			_StartItemUpdate = null;
			_SetItemTitle = null;
			_SetItemDescription = null;
			_SetItemUpdateLanguage = null;
			_SetItemMetadata = null;
			_SetItemVisibility = null;
			_SetItemTags = null;
			_SetItemContent = null;
			_SetItemPreview = null;
			_SetAllowLegacyUpload = null;
			_RemoveItemKeyValueTags = null;
			_AddItemKeyValueTag = null;
			_AddItemPreviewFile = null;
			_AddItemPreviewVideo = null;
			_UpdateItemPreviewFile = null;
			_UpdateItemPreviewVideo = null;
			_RemoveItemPreview = null;
			_SubmitItemUpdate = null;
			_GetItemUpdateProgress = null;
			_SetUserItemVote = null;
			_GetUserItemVote = null;
			_AddItemToFavorites = null;
			_RemoveItemFromFavorites = null;
			_SubscribeItem = null;
			_UnsubscribeItem = null;
			_GetNumSubscribedItems = null;
			_GetSubscribedItems = null;
			_GetItemState = null;
			_GetItemInstallInfo = null;
			_GetItemDownloadInfo = null;
			_DownloadItem = null;
			_BInitWorkshopForGameServer = null;
			_SuspendDownloads = null;
			_StartPlaytimeTracking = null;
			_StopPlaytimeTracking = null;
			_StopPlaytimeTrackingForAllItems = null;
			_AddDependency = null;
			_RemoveDependency = null;
			_AddAppDependency = null;
			_RemoveAppDependency = null;
			_GetAppDependencies = null;
			_DeleteItem = null;
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate UGCQueryHandle_t FCreateQueryUserUGCRequest( IntPtr self, AccountID_t unAccountID, UserUGCList eListType, UgcType eMatchingUGCType, UserUGCListSortOrder eSortOrder, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage );
		private FCreateQueryUserUGCRequest _CreateQueryUserUGCRequest;
		
		#endregion
		internal UGCQueryHandle_t CreateQueryUserUGCRequest( AccountID_t unAccountID, UserUGCList eListType, UgcType eMatchingUGCType, UserUGCListSortOrder eSortOrder, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage )
		{
			return _CreateQueryUserUGCRequest( Self, unAccountID, eListType, eMatchingUGCType, eSortOrder, nCreatorAppID, nConsumerAppID, unPage );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate UGCQueryHandle_t FCreateQueryAllUGCRequest1( IntPtr self, UGCQuery eQueryType, UgcType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage );
		private FCreateQueryAllUGCRequest1 _CreateQueryAllUGCRequest1;
		
		#endregion
		internal UGCQueryHandle_t CreateQueryAllUGCRequest1( UGCQuery eQueryType, UgcType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage )
		{
			return _CreateQueryAllUGCRequest1( Self, eQueryType, eMatchingeMatchingUGCTypeFileType, nCreatorAppID, nConsumerAppID, unPage );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate UGCQueryHandle_t FCreateQueryAllUGCRequest2( IntPtr self, UGCQuery eQueryType, UgcType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchCursor );
		private FCreateQueryAllUGCRequest2 _CreateQueryAllUGCRequest2;
		
		#endregion
		internal UGCQueryHandle_t CreateQueryAllUGCRequest2( UGCQuery eQueryType, UgcType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchCursor )
		{
			return _CreateQueryAllUGCRequest2( Self, eQueryType, eMatchingeMatchingUGCTypeFileType, nCreatorAppID, nConsumerAppID, pchCursor );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate UGCQueryHandle_t FCreateQueryUGCDetailsRequest( IntPtr self, [In,Out] PublishedFileId[]  pvecPublishedFileID, uint unNumPublishedFileIDs );
		private FCreateQueryUGCDetailsRequest _CreateQueryUGCDetailsRequest;
		
		#endregion
		internal UGCQueryHandle_t CreateQueryUGCDetailsRequest( [In,Out] PublishedFileId[]  pvecPublishedFileID, uint unNumPublishedFileIDs )
		{
			return _CreateQueryUGCDetailsRequest( Self, pvecPublishedFileID, unNumPublishedFileIDs );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate SteamAPICall_t FSendQueryUGCRequest( IntPtr self, UGCQueryHandle_t handle );
		private FSendQueryUGCRequest _SendQueryUGCRequest;
		
		#endregion
		internal async Task<SteamUGCQueryCompleted_t?> SendQueryUGCRequest( UGCQueryHandle_t handle )
		{
			return await SteamUGCQueryCompleted_t.GetResultAsync( _SendQueryUGCRequest( Self, handle ) );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FGetQueryUGCResult( IntPtr self, UGCQueryHandle_t handle, uint index, ref SteamUGCDetails_t pDetails );
		private FGetQueryUGCResult _GetQueryUGCResult;
		
		#endregion
		internal bool GetQueryUGCResult( UGCQueryHandle_t handle, uint index, ref SteamUGCDetails_t pDetails )
		{
			return _GetQueryUGCResult( Self, handle, index, ref pDetails );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FGetQueryUGCPreviewURL( IntPtr self, UGCQueryHandle_t handle, uint index, StringBuilder pchURL, uint cchURLSize );
		private FGetQueryUGCPreviewURL _GetQueryUGCPreviewURL;
		
		#endregion
		internal bool GetQueryUGCPreviewURL( UGCQueryHandle_t handle, uint index, StringBuilder pchURL, uint cchURLSize )
		{
			return _GetQueryUGCPreviewURL( Self, handle, index, pchURL, cchURLSize );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FGetQueryUGCMetadata( IntPtr self, UGCQueryHandle_t handle, uint index, StringBuilder pchMetadata, uint cchMetadatasize );
		private FGetQueryUGCMetadata _GetQueryUGCMetadata;
		
		#endregion
		internal bool GetQueryUGCMetadata( UGCQueryHandle_t handle, uint index, StringBuilder pchMetadata, uint cchMetadatasize )
		{
			return _GetQueryUGCMetadata( Self, handle, index, pchMetadata, cchMetadatasize );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FGetQueryUGCChildren( IntPtr self, UGCQueryHandle_t handle, uint index, [In,Out] PublishedFileId[]  pvecPublishedFileID, uint cMaxEntries );
		private FGetQueryUGCChildren _GetQueryUGCChildren;
		
		#endregion
		internal bool GetQueryUGCChildren( UGCQueryHandle_t handle, uint index, [In,Out] PublishedFileId[]  pvecPublishedFileID, uint cMaxEntries )
		{
			return _GetQueryUGCChildren( Self, handle, index, pvecPublishedFileID, cMaxEntries );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FGetQueryUGCStatistic( IntPtr self, UGCQueryHandle_t handle, uint index, ItemStatistic eStatType, ref ulong pStatValue );
		private FGetQueryUGCStatistic _GetQueryUGCStatistic;
		
		#endregion
		internal bool GetQueryUGCStatistic( UGCQueryHandle_t handle, uint index, ItemStatistic eStatType, ref ulong pStatValue )
		{
			return _GetQueryUGCStatistic( Self, handle, index, eStatType, ref pStatValue );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate uint FGetQueryUGCNumAdditionalPreviews( IntPtr self, UGCQueryHandle_t handle, uint index );
		private FGetQueryUGCNumAdditionalPreviews _GetQueryUGCNumAdditionalPreviews;
		
		#endregion
		internal uint GetQueryUGCNumAdditionalPreviews( UGCQueryHandle_t handle, uint index )
		{
			return _GetQueryUGCNumAdditionalPreviews( Self, handle, index );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FGetQueryUGCAdditionalPreview( IntPtr self, UGCQueryHandle_t handle, uint index, uint previewIndex, StringBuilder pchURLOrVideoID, uint cchURLSize, StringBuilder pchOriginalFileName, uint cchOriginalFileNameSize, ref ItemPreviewType pPreviewType );
		private FGetQueryUGCAdditionalPreview _GetQueryUGCAdditionalPreview;
		
		#endregion
		internal bool GetQueryUGCAdditionalPreview( UGCQueryHandle_t handle, uint index, uint previewIndex, StringBuilder pchURLOrVideoID, uint cchURLSize, StringBuilder pchOriginalFileName, uint cchOriginalFileNameSize, ref ItemPreviewType pPreviewType )
		{
			return _GetQueryUGCAdditionalPreview( Self, handle, index, previewIndex, pchURLOrVideoID, cchURLSize, pchOriginalFileName, cchOriginalFileNameSize, ref pPreviewType );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate uint FGetQueryUGCNumKeyValueTags( IntPtr self, UGCQueryHandle_t handle, uint index );
		private FGetQueryUGCNumKeyValueTags _GetQueryUGCNumKeyValueTags;
		
		#endregion
		internal uint GetQueryUGCNumKeyValueTags( UGCQueryHandle_t handle, uint index )
		{
			return _GetQueryUGCNumKeyValueTags( Self, handle, index );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FGetQueryUGCKeyValueTag( IntPtr self, UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, StringBuilder pchKey, uint cchKeySize, StringBuilder pchValue, uint cchValueSize );
		private FGetQueryUGCKeyValueTag _GetQueryUGCKeyValueTag;
		
		#endregion
		internal bool GetQueryUGCKeyValueTag( UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, StringBuilder pchKey, uint cchKeySize, StringBuilder pchValue, uint cchValueSize )
		{
			return _GetQueryUGCKeyValueTag( Self, handle, index, keyValueTagIndex, pchKey, cchKeySize, pchValue, cchValueSize );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FReleaseQueryUGCRequest( IntPtr self, UGCQueryHandle_t handle );
		private FReleaseQueryUGCRequest _ReleaseQueryUGCRequest;
		
		#endregion
		internal bool ReleaseQueryUGCRequest( UGCQueryHandle_t handle )
		{
			return _ReleaseQueryUGCRequest( Self, handle );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FAddRequiredTag( IntPtr self, UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pTagName );
		private FAddRequiredTag _AddRequiredTag;
		
		#endregion
		internal bool AddRequiredTag( UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pTagName )
		{
			return _AddRequiredTag( Self, handle, pTagName );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FAddExcludedTag( IntPtr self, UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pTagName );
		private FAddExcludedTag _AddExcludedTag;
		
		#endregion
		internal bool AddExcludedTag( UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pTagName )
		{
			return _AddExcludedTag( Self, handle, pTagName );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetReturnOnlyIDs( IntPtr self, UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.U1 )] bool bReturnOnlyIDs );
		private FSetReturnOnlyIDs _SetReturnOnlyIDs;
		
		#endregion
		internal bool SetReturnOnlyIDs( UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.U1 )] bool bReturnOnlyIDs )
		{
			return _SetReturnOnlyIDs( Self, handle, bReturnOnlyIDs );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetReturnKeyValueTags( IntPtr self, UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.U1 )] bool bReturnKeyValueTags );
		private FSetReturnKeyValueTags _SetReturnKeyValueTags;
		
		#endregion
		internal bool SetReturnKeyValueTags( UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.U1 )] bool bReturnKeyValueTags )
		{
			return _SetReturnKeyValueTags( Self, handle, bReturnKeyValueTags );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetReturnLongDescription( IntPtr self, UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.U1 )] bool bReturnLongDescription );
		private FSetReturnLongDescription _SetReturnLongDescription;
		
		#endregion
		internal bool SetReturnLongDescription( UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.U1 )] bool bReturnLongDescription )
		{
			return _SetReturnLongDescription( Self, handle, bReturnLongDescription );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetReturnMetadata( IntPtr self, UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.U1 )] bool bReturnMetadata );
		private FSetReturnMetadata _SetReturnMetadata;
		
		#endregion
		internal bool SetReturnMetadata( UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.U1 )] bool bReturnMetadata )
		{
			return _SetReturnMetadata( Self, handle, bReturnMetadata );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetReturnChildren( IntPtr self, UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.U1 )] bool bReturnChildren );
		private FSetReturnChildren _SetReturnChildren;
		
		#endregion
		internal bool SetReturnChildren( UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.U1 )] bool bReturnChildren )
		{
			return _SetReturnChildren( Self, handle, bReturnChildren );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetReturnAdditionalPreviews( IntPtr self, UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.U1 )] bool bReturnAdditionalPreviews );
		private FSetReturnAdditionalPreviews _SetReturnAdditionalPreviews;
		
		#endregion
		internal bool SetReturnAdditionalPreviews( UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.U1 )] bool bReturnAdditionalPreviews )
		{
			return _SetReturnAdditionalPreviews( Self, handle, bReturnAdditionalPreviews );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetReturnTotalOnly( IntPtr self, UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.U1 )] bool bReturnTotalOnly );
		private FSetReturnTotalOnly _SetReturnTotalOnly;
		
		#endregion
		internal bool SetReturnTotalOnly( UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.U1 )] bool bReturnTotalOnly )
		{
			return _SetReturnTotalOnly( Self, handle, bReturnTotalOnly );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetReturnPlaytimeStats( IntPtr self, UGCQueryHandle_t handle, uint unDays );
		private FSetReturnPlaytimeStats _SetReturnPlaytimeStats;
		
		#endregion
		internal bool SetReturnPlaytimeStats( UGCQueryHandle_t handle, uint unDays )
		{
			return _SetReturnPlaytimeStats( Self, handle, unDays );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetLanguage( IntPtr self, UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchLanguage );
		private FSetLanguage _SetLanguage;
		
		#endregion
		internal bool SetLanguage( UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchLanguage )
		{
			return _SetLanguage( Self, handle, pchLanguage );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetAllowCachedResponse( IntPtr self, UGCQueryHandle_t handle, uint unMaxAgeSeconds );
		private FSetAllowCachedResponse _SetAllowCachedResponse;
		
		#endregion
		internal bool SetAllowCachedResponse( UGCQueryHandle_t handle, uint unMaxAgeSeconds )
		{
			return _SetAllowCachedResponse( Self, handle, unMaxAgeSeconds );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetCloudFileNameFilter( IntPtr self, UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pMatchCloudFileName );
		private FSetCloudFileNameFilter _SetCloudFileNameFilter;
		
		#endregion
		internal bool SetCloudFileNameFilter( UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pMatchCloudFileName )
		{
			return _SetCloudFileNameFilter( Self, handle, pMatchCloudFileName );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetMatchAnyTag( IntPtr self, UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.U1 )] bool bMatchAnyTag );
		private FSetMatchAnyTag _SetMatchAnyTag;
		
		#endregion
		internal bool SetMatchAnyTag( UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.U1 )] bool bMatchAnyTag )
		{
			return _SetMatchAnyTag( Self, handle, bMatchAnyTag );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetSearchText( IntPtr self, UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pSearchText );
		private FSetSearchText _SetSearchText;
		
		#endregion
		internal bool SetSearchText( UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pSearchText )
		{
			return _SetSearchText( Self, handle, pSearchText );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetRankedByTrendDays( IntPtr self, UGCQueryHandle_t handle, uint unDays );
		private FSetRankedByTrendDays _SetRankedByTrendDays;
		
		#endregion
		internal bool SetRankedByTrendDays( UGCQueryHandle_t handle, uint unDays )
		{
			return _SetRankedByTrendDays( Self, handle, unDays );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FAddRequiredKeyValueTag( IntPtr self, UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pKey, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pValue );
		private FAddRequiredKeyValueTag _AddRequiredKeyValueTag;
		
		#endregion
		internal bool AddRequiredKeyValueTag( UGCQueryHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pKey, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pValue )
		{
			return _AddRequiredKeyValueTag( Self, handle, pKey, pValue );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate SteamAPICall_t FRequestUGCDetails( IntPtr self, PublishedFileId nPublishedFileID, uint unMaxAgeSeconds );
		private FRequestUGCDetails _RequestUGCDetails;
		
		#endregion
		internal async Task<SteamUGCRequestUGCDetailsResult_t?> RequestUGCDetails( PublishedFileId nPublishedFileID, uint unMaxAgeSeconds )
		{
			return await SteamUGCRequestUGCDetailsResult_t.GetResultAsync( _RequestUGCDetails( Self, nPublishedFileID, unMaxAgeSeconds ) );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate SteamAPICall_t FCreateItem( IntPtr self, AppId nConsumerAppId, WorkshopFileType eFileType );
		private FCreateItem _CreateItem;
		
		#endregion
		internal async Task<CreateItemResult_t?> CreateItem( AppId nConsumerAppId, WorkshopFileType eFileType )
		{
			return await CreateItemResult_t.GetResultAsync( _CreateItem( Self, nConsumerAppId, eFileType ) );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate UGCUpdateHandle_t FStartItemUpdate( IntPtr self, AppId nConsumerAppId, PublishedFileId nPublishedFileID );
		private FStartItemUpdate _StartItemUpdate;
		
		#endregion
		internal UGCUpdateHandle_t StartItemUpdate( AppId nConsumerAppId, PublishedFileId nPublishedFileID )
		{
			return _StartItemUpdate( Self, nConsumerAppId, nPublishedFileID );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetItemTitle( IntPtr self, UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchTitle );
		private FSetItemTitle _SetItemTitle;
		
		#endregion
		internal bool SetItemTitle( UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchTitle )
		{
			return _SetItemTitle( Self, handle, pchTitle );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetItemDescription( IntPtr self, UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchDescription );
		private FSetItemDescription _SetItemDescription;
		
		#endregion
		internal bool SetItemDescription( UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchDescription )
		{
			return _SetItemDescription( Self, handle, pchDescription );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetItemUpdateLanguage( IntPtr self, UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchLanguage );
		private FSetItemUpdateLanguage _SetItemUpdateLanguage;
		
		#endregion
		internal bool SetItemUpdateLanguage( UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchLanguage )
		{
			return _SetItemUpdateLanguage( Self, handle, pchLanguage );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetItemMetadata( IntPtr self, UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchMetaData );
		private FSetItemMetadata _SetItemMetadata;
		
		#endregion
		internal bool SetItemMetadata( UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchMetaData )
		{
			return _SetItemMetadata( Self, handle, pchMetaData );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetItemVisibility( IntPtr self, UGCUpdateHandle_t handle, RemoteStoragePublishedFileVisibility eVisibility );
		private FSetItemVisibility _SetItemVisibility;
		
		#endregion
		internal bool SetItemVisibility( UGCUpdateHandle_t handle, RemoteStoragePublishedFileVisibility eVisibility )
		{
			return _SetItemVisibility( Self, handle, eVisibility );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetItemTags( IntPtr self, UGCUpdateHandle_t updateHandle, ref SteamParamStringArray_t pTags );
		private FSetItemTags _SetItemTags;
		
		#endregion
		internal bool SetItemTags( UGCUpdateHandle_t updateHandle, ref SteamParamStringArray_t pTags )
		{
			return _SetItemTags( Self, updateHandle, ref pTags );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetItemContent( IntPtr self, UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pszContentFolder );
		private FSetItemContent _SetItemContent;
		
		#endregion
		internal bool SetItemContent( UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pszContentFolder )
		{
			return _SetItemContent( Self, handle, pszContentFolder );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetItemPreview( IntPtr self, UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pszPreviewFile );
		private FSetItemPreview _SetItemPreview;
		
		#endregion
		internal bool SetItemPreview( UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pszPreviewFile )
		{
			return _SetItemPreview( Self, handle, pszPreviewFile );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FSetAllowLegacyUpload( IntPtr self, UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.U1 )] bool bAllowLegacyUpload );
		private FSetAllowLegacyUpload _SetAllowLegacyUpload;
		
		#endregion
		internal bool SetAllowLegacyUpload( UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.U1 )] bool bAllowLegacyUpload )
		{
			return _SetAllowLegacyUpload( Self, handle, bAllowLegacyUpload );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FRemoveItemKeyValueTags( IntPtr self, UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchKey );
		private FRemoveItemKeyValueTags _RemoveItemKeyValueTags;
		
		#endregion
		internal bool RemoveItemKeyValueTags( UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchKey )
		{
			return _RemoveItemKeyValueTags( Self, handle, pchKey );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FAddItemKeyValueTag( IntPtr self, UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchKey, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchValue );
		private FAddItemKeyValueTag _AddItemKeyValueTag;
		
		#endregion
		internal bool AddItemKeyValueTag( UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchKey, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchValue )
		{
			return _AddItemKeyValueTag( Self, handle, pchKey, pchValue );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FAddItemPreviewFile( IntPtr self, UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pszPreviewFile, ItemPreviewType type );
		private FAddItemPreviewFile _AddItemPreviewFile;
		
		#endregion
		internal bool AddItemPreviewFile( UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pszPreviewFile, ItemPreviewType type )
		{
			return _AddItemPreviewFile( Self, handle, pszPreviewFile, type );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FAddItemPreviewVideo( IntPtr self, UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pszVideoID );
		private FAddItemPreviewVideo _AddItemPreviewVideo;
		
		#endregion
		internal bool AddItemPreviewVideo( UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pszVideoID )
		{
			return _AddItemPreviewVideo( Self, handle, pszVideoID );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FUpdateItemPreviewFile( IntPtr self, UGCUpdateHandle_t handle, uint index, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pszPreviewFile );
		private FUpdateItemPreviewFile _UpdateItemPreviewFile;
		
		#endregion
		internal bool UpdateItemPreviewFile( UGCUpdateHandle_t handle, uint index, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pszPreviewFile )
		{
			return _UpdateItemPreviewFile( Self, handle, index, pszPreviewFile );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FUpdateItemPreviewVideo( IntPtr self, UGCUpdateHandle_t handle, uint index, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pszVideoID );
		private FUpdateItemPreviewVideo _UpdateItemPreviewVideo;
		
		#endregion
		internal bool UpdateItemPreviewVideo( UGCUpdateHandle_t handle, uint index, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pszVideoID )
		{
			return _UpdateItemPreviewVideo( Self, handle, index, pszVideoID );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FRemoveItemPreview( IntPtr self, UGCUpdateHandle_t handle, uint index );
		private FRemoveItemPreview _RemoveItemPreview;
		
		#endregion
		internal bool RemoveItemPreview( UGCUpdateHandle_t handle, uint index )
		{
			return _RemoveItemPreview( Self, handle, index );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate SteamAPICall_t FSubmitItemUpdate( IntPtr self, UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchChangeNote );
		private FSubmitItemUpdate _SubmitItemUpdate;
		
		#endregion
		internal async Task<SubmitItemUpdateResult_t?> SubmitItemUpdate( UGCUpdateHandle_t handle, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pchChangeNote )
		{
			return await SubmitItemUpdateResult_t.GetResultAsync( _SubmitItemUpdate( Self, handle, pchChangeNote ) );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate ItemUpdateStatus FGetItemUpdateProgress( IntPtr self, UGCUpdateHandle_t handle, ref ulong punBytesProcessed, ref ulong punBytesTotal );
		private FGetItemUpdateProgress _GetItemUpdateProgress;
		
		#endregion
		internal ItemUpdateStatus GetItemUpdateProgress( UGCUpdateHandle_t handle, ref ulong punBytesProcessed, ref ulong punBytesTotal )
		{
			return _GetItemUpdateProgress( Self, handle, ref punBytesProcessed, ref punBytesTotal );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate SteamAPICall_t FSetUserItemVote( IntPtr self, PublishedFileId nPublishedFileID, [MarshalAs( UnmanagedType.U1 )] bool bVoteUp );
		private FSetUserItemVote _SetUserItemVote;
		
		#endregion
		internal async Task<SetUserItemVoteResult_t?> SetUserItemVote( PublishedFileId nPublishedFileID, [MarshalAs( UnmanagedType.U1 )] bool bVoteUp )
		{
			return await SetUserItemVoteResult_t.GetResultAsync( _SetUserItemVote( Self, nPublishedFileID, bVoteUp ) );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate SteamAPICall_t FGetUserItemVote( IntPtr self, PublishedFileId nPublishedFileID );
		private FGetUserItemVote _GetUserItemVote;
		
		#endregion
		internal async Task<GetUserItemVoteResult_t?> GetUserItemVote( PublishedFileId nPublishedFileID )
		{
			return await GetUserItemVoteResult_t.GetResultAsync( _GetUserItemVote( Self, nPublishedFileID ) );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate SteamAPICall_t FAddItemToFavorites( IntPtr self, AppId nAppId, PublishedFileId nPublishedFileID );
		private FAddItemToFavorites _AddItemToFavorites;
		
		#endregion
		internal async Task<UserFavoriteItemsListChanged_t?> AddItemToFavorites( AppId nAppId, PublishedFileId nPublishedFileID )
		{
			return await UserFavoriteItemsListChanged_t.GetResultAsync( _AddItemToFavorites( Self, nAppId, nPublishedFileID ) );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate SteamAPICall_t FRemoveItemFromFavorites( IntPtr self, AppId nAppId, PublishedFileId nPublishedFileID );
		private FRemoveItemFromFavorites _RemoveItemFromFavorites;
		
		#endregion
		internal async Task<UserFavoriteItemsListChanged_t?> RemoveItemFromFavorites( AppId nAppId, PublishedFileId nPublishedFileID )
		{
			return await UserFavoriteItemsListChanged_t.GetResultAsync( _RemoveItemFromFavorites( Self, nAppId, nPublishedFileID ) );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate SteamAPICall_t FSubscribeItem( IntPtr self, PublishedFileId nPublishedFileID );
		private FSubscribeItem _SubscribeItem;
		
		#endregion
		internal async Task<RemoteStorageSubscribePublishedFileResult_t?> SubscribeItem( PublishedFileId nPublishedFileID )
		{
			return await RemoteStorageSubscribePublishedFileResult_t.GetResultAsync( _SubscribeItem( Self, nPublishedFileID ) );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate SteamAPICall_t FUnsubscribeItem( IntPtr self, PublishedFileId nPublishedFileID );
		private FUnsubscribeItem _UnsubscribeItem;
		
		#endregion
		internal async Task<RemoteStorageUnsubscribePublishedFileResult_t?> UnsubscribeItem( PublishedFileId nPublishedFileID )
		{
			return await RemoteStorageUnsubscribePublishedFileResult_t.GetResultAsync( _UnsubscribeItem( Self, nPublishedFileID ) );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate uint FGetNumSubscribedItems( IntPtr self );
		private FGetNumSubscribedItems _GetNumSubscribedItems;
		
		#endregion
		internal uint GetNumSubscribedItems()
		{
			return _GetNumSubscribedItems( Self );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate uint FGetSubscribedItems( IntPtr self, [In,Out] PublishedFileId[]  pvecPublishedFileID, uint cMaxEntries );
		private FGetSubscribedItems _GetSubscribedItems;
		
		#endregion
		internal uint GetSubscribedItems( [In,Out] PublishedFileId[]  pvecPublishedFileID, uint cMaxEntries )
		{
			return _GetSubscribedItems( Self, pvecPublishedFileID, cMaxEntries );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate uint FGetItemState( IntPtr self, PublishedFileId nPublishedFileID );
		private FGetItemState _GetItemState;
		
		#endregion
		internal uint GetItemState( PublishedFileId nPublishedFileID )
		{
			return _GetItemState( Self, nPublishedFileID );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FGetItemInstallInfo( IntPtr self, PublishedFileId nPublishedFileID, ref ulong punSizeOnDisk, StringBuilder pchFolder, uint cchFolderSize, ref uint punTimeStamp );
		private FGetItemInstallInfo _GetItemInstallInfo;
		
		#endregion
		internal bool GetItemInstallInfo( PublishedFileId nPublishedFileID, ref ulong punSizeOnDisk, StringBuilder pchFolder, uint cchFolderSize, ref uint punTimeStamp )
		{
			return _GetItemInstallInfo( Self, nPublishedFileID, ref punSizeOnDisk, pchFolder, cchFolderSize, ref punTimeStamp );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FGetItemDownloadInfo( IntPtr self, PublishedFileId nPublishedFileID, ref ulong punBytesDownloaded, ref ulong punBytesTotal );
		private FGetItemDownloadInfo _GetItemDownloadInfo;
		
		#endregion
		internal bool GetItemDownloadInfo( PublishedFileId nPublishedFileID, ref ulong punBytesDownloaded, ref ulong punBytesTotal )
		{
			return _GetItemDownloadInfo( Self, nPublishedFileID, ref punBytesDownloaded, ref punBytesTotal );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FDownloadItem( IntPtr self, PublishedFileId nPublishedFileID, [MarshalAs( UnmanagedType.U1 )] bool bHighPriority );
		private FDownloadItem _DownloadItem;
		
		#endregion
		internal bool DownloadItem( PublishedFileId nPublishedFileID, [MarshalAs( UnmanagedType.U1 )] bool bHighPriority )
		{
			return _DownloadItem( Self, nPublishedFileID, bHighPriority );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FBInitWorkshopForGameServer( IntPtr self, DepotId_t unWorkshopDepotID, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pszFolder );
		private FBInitWorkshopForGameServer _BInitWorkshopForGameServer;
		
		#endregion
		internal bool BInitWorkshopForGameServer( DepotId_t unWorkshopDepotID, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pszFolder )
		{
			return _BInitWorkshopForGameServer( Self, unWorkshopDepotID, pszFolder );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate void FSuspendDownloads( IntPtr self, [MarshalAs( UnmanagedType.U1 )] bool bSuspend );
		private FSuspendDownloads _SuspendDownloads;
		
		#endregion
		internal void SuspendDownloads( [MarshalAs( UnmanagedType.U1 )] bool bSuspend )
		{
			_SuspendDownloads( Self, bSuspend );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate SteamAPICall_t FStartPlaytimeTracking( IntPtr self, [In,Out] PublishedFileId[]  pvecPublishedFileID, uint unNumPublishedFileIDs );
		private FStartPlaytimeTracking _StartPlaytimeTracking;
		
		#endregion
		internal async Task<StartPlaytimeTrackingResult_t?> StartPlaytimeTracking( [In,Out] PublishedFileId[]  pvecPublishedFileID, uint unNumPublishedFileIDs )
		{
			return await StartPlaytimeTrackingResult_t.GetResultAsync( _StartPlaytimeTracking( Self, pvecPublishedFileID, unNumPublishedFileIDs ) );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate SteamAPICall_t FStopPlaytimeTracking( IntPtr self, [In,Out] PublishedFileId[]  pvecPublishedFileID, uint unNumPublishedFileIDs );
		private FStopPlaytimeTracking _StopPlaytimeTracking;
		
		#endregion
		internal async Task<StopPlaytimeTrackingResult_t?> StopPlaytimeTracking( [In,Out] PublishedFileId[]  pvecPublishedFileID, uint unNumPublishedFileIDs )
		{
			return await StopPlaytimeTrackingResult_t.GetResultAsync( _StopPlaytimeTracking( Self, pvecPublishedFileID, unNumPublishedFileIDs ) );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate SteamAPICall_t FStopPlaytimeTrackingForAllItems( IntPtr self );
		private FStopPlaytimeTrackingForAllItems _StopPlaytimeTrackingForAllItems;
		
		#endregion
		internal async Task<StopPlaytimeTrackingResult_t?> StopPlaytimeTrackingForAllItems()
		{
			return await StopPlaytimeTrackingResult_t.GetResultAsync( _StopPlaytimeTrackingForAllItems( Self ) );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate SteamAPICall_t FAddDependency( IntPtr self, PublishedFileId nParentPublishedFileID, PublishedFileId nChildPublishedFileID );
		private FAddDependency _AddDependency;
		
		#endregion
		internal async Task<AddUGCDependencyResult_t?> AddDependency( PublishedFileId nParentPublishedFileID, PublishedFileId nChildPublishedFileID )
		{
			return await AddUGCDependencyResult_t.GetResultAsync( _AddDependency( Self, nParentPublishedFileID, nChildPublishedFileID ) );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate SteamAPICall_t FRemoveDependency( IntPtr self, PublishedFileId nParentPublishedFileID, PublishedFileId nChildPublishedFileID );
		private FRemoveDependency _RemoveDependency;
		
		#endregion
		internal async Task<RemoveUGCDependencyResult_t?> RemoveDependency( PublishedFileId nParentPublishedFileID, PublishedFileId nChildPublishedFileID )
		{
			return await RemoveUGCDependencyResult_t.GetResultAsync( _RemoveDependency( Self, nParentPublishedFileID, nChildPublishedFileID ) );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate SteamAPICall_t FAddAppDependency( IntPtr self, PublishedFileId nPublishedFileID, AppId nAppID );
		private FAddAppDependency _AddAppDependency;
		
		#endregion
		internal async Task<AddAppDependencyResult_t?> AddAppDependency( PublishedFileId nPublishedFileID, AppId nAppID )
		{
			return await AddAppDependencyResult_t.GetResultAsync( _AddAppDependency( Self, nPublishedFileID, nAppID ) );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate SteamAPICall_t FRemoveAppDependency( IntPtr self, PublishedFileId nPublishedFileID, AppId nAppID );
		private FRemoveAppDependency _RemoveAppDependency;
		
		#endregion
		internal async Task<RemoveAppDependencyResult_t?> RemoveAppDependency( PublishedFileId nPublishedFileID, AppId nAppID )
		{
			return await RemoveAppDependencyResult_t.GetResultAsync( _RemoveAppDependency( Self, nPublishedFileID, nAppID ) );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate SteamAPICall_t FGetAppDependencies( IntPtr self, PublishedFileId nPublishedFileID );
		private FGetAppDependencies _GetAppDependencies;
		
		#endregion
		internal async Task<GetAppDependenciesResult_t?> GetAppDependencies( PublishedFileId nPublishedFileID )
		{
			return await GetAppDependenciesResult_t.GetResultAsync( _GetAppDependencies( Self, nPublishedFileID ) );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( Platform.MemberConvention )]
		private delegate SteamAPICall_t FDeleteItem( IntPtr self, PublishedFileId nPublishedFileID );
		private FDeleteItem _DeleteItem;
		
		#endregion
		internal async Task<DeleteItemResult_t?> DeleteItem( PublishedFileId nPublishedFileID )
		{
			return await DeleteItemResult_t.GetResultAsync( _DeleteItem( Self, nPublishedFileID ) );
		}
		
	}
}
