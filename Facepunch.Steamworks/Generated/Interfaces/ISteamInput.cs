using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Steamworks.Data;


namespace Steamworks
{
	internal class ISteamInput : SteamInterface
	{
		public override string InterfaceName => "SteamInput001";
		
		public override void InitInternals()
		{
			_DoInit = Marshal.GetDelegateForFunctionPointer<FDoInit>( Marshal.ReadIntPtr( VTable, 0) );
			_DoShutdown = Marshal.GetDelegateForFunctionPointer<FDoShutdown>( Marshal.ReadIntPtr( VTable, 8) );
			_RunFrame = Marshal.GetDelegateForFunctionPointer<FRunFrame>( Marshal.ReadIntPtr( VTable, 16) );
			_GetConnectedControllers = Marshal.GetDelegateForFunctionPointer<FGetConnectedControllers>( Marshal.ReadIntPtr( VTable, 24) );
			_GetActionSetHandle = Marshal.GetDelegateForFunctionPointer<FGetActionSetHandle>( Marshal.ReadIntPtr( VTable, 32) );
			_ActivateActionSet = Marshal.GetDelegateForFunctionPointer<FActivateActionSet>( Marshal.ReadIntPtr( VTable, 40) );
			_GetCurrentActionSet = Marshal.GetDelegateForFunctionPointer<FGetCurrentActionSet>( Marshal.ReadIntPtr( VTable, 48) );
			_ActivateActionSetLayer = Marshal.GetDelegateForFunctionPointer<FActivateActionSetLayer>( Marshal.ReadIntPtr( VTable, 56) );
			_DeactivateActionSetLayer = Marshal.GetDelegateForFunctionPointer<FDeactivateActionSetLayer>( Marshal.ReadIntPtr( VTable, 64) );
			_DeactivateAllActionSetLayers = Marshal.GetDelegateForFunctionPointer<FDeactivateAllActionSetLayers>( Marshal.ReadIntPtr( VTable, 72) );
			_GetActiveActionSetLayers = Marshal.GetDelegateForFunctionPointer<FGetActiveActionSetLayers>( Marshal.ReadIntPtr( VTable, 80) );
			_GetDigitalActionHandle = Marshal.GetDelegateForFunctionPointer<FGetDigitalActionHandle>( Marshal.ReadIntPtr( VTable, 88) );
			_GetDigitalActionData = Marshal.GetDelegateForFunctionPointer<FGetDigitalActionData>( Marshal.ReadIntPtr( VTable, 96) );
			_GetDigitalActionData_Windows = Marshal.GetDelegateForFunctionPointer<FGetDigitalActionData_Windows>( Marshal.ReadIntPtr( VTable, 96) );
			_GetDigitalActionOrigins = Marshal.GetDelegateForFunctionPointer<FGetDigitalActionOrigins>( Marshal.ReadIntPtr( VTable, 104) );
			_GetAnalogActionHandle = Marshal.GetDelegateForFunctionPointer<FGetAnalogActionHandle>( Marshal.ReadIntPtr( VTable, 112) );
			_GetAnalogActionData = Marshal.GetDelegateForFunctionPointer<FGetAnalogActionData>( Marshal.ReadIntPtr( VTable, 120) );
			_GetAnalogActionData_Windows = Marshal.GetDelegateForFunctionPointer<FGetAnalogActionData_Windows>( Marshal.ReadIntPtr( VTable, 120) );
			_GetAnalogActionOrigins = Marshal.GetDelegateForFunctionPointer<FGetAnalogActionOrigins>( Marshal.ReadIntPtr( VTable, 128) );
			_GetGlyphForActionOrigin = Marshal.GetDelegateForFunctionPointer<FGetGlyphForActionOrigin>( Marshal.ReadIntPtr( VTable, 136) );
			_GetStringForActionOrigin = Marshal.GetDelegateForFunctionPointer<FGetStringForActionOrigin>( Marshal.ReadIntPtr( VTable, 144) );
			_StopAnalogActionMomentum = Marshal.GetDelegateForFunctionPointer<FStopAnalogActionMomentum>( Marshal.ReadIntPtr( VTable, 152) );
			_GetMotionData = Marshal.GetDelegateForFunctionPointer<FGetMotionData>( Marshal.ReadIntPtr( VTable, 160) );
			_GetMotionData_Windows = Marshal.GetDelegateForFunctionPointer<FGetMotionData_Windows>( Marshal.ReadIntPtr( VTable, 160) );
			_TriggerVibration = Marshal.GetDelegateForFunctionPointer<FTriggerVibration>( Marshal.ReadIntPtr( VTable, 168) );
			_SetLEDColor = Marshal.GetDelegateForFunctionPointer<FSetLEDColor>( Marshal.ReadIntPtr( VTable, 176) );
			_TriggerHapticPulse = Marshal.GetDelegateForFunctionPointer<FTriggerHapticPulse>( Marshal.ReadIntPtr( VTable, 184) );
			_TriggerRepeatedHapticPulse = Marshal.GetDelegateForFunctionPointer<FTriggerRepeatedHapticPulse>( Marshal.ReadIntPtr( VTable, 192) );
			_ShowBindingPanel = Marshal.GetDelegateForFunctionPointer<FShowBindingPanel>( Marshal.ReadIntPtr( VTable, 200) );
			_GetInputTypeForHandle = Marshal.GetDelegateForFunctionPointer<FGetInputTypeForHandle>( Marshal.ReadIntPtr( VTable, 208) );
			_GetControllerForGamepadIndex = Marshal.GetDelegateForFunctionPointer<FGetControllerForGamepadIndex>( Marshal.ReadIntPtr( VTable, 216) );
			_GetGamepadIndexForController = Marshal.GetDelegateForFunctionPointer<FGetGamepadIndexForController>( Marshal.ReadIntPtr( VTable, 224) );
			_GetStringForXboxOrigin = Marshal.GetDelegateForFunctionPointer<FGetStringForXboxOrigin>( Marshal.ReadIntPtr( VTable, 232) );
			_GetGlyphForXboxOrigin = Marshal.GetDelegateForFunctionPointer<FGetGlyphForXboxOrigin>( Marshal.ReadIntPtr( VTable, 240) );
			_GetActionOriginFromXboxOrigin = Marshal.GetDelegateForFunctionPointer<FGetActionOriginFromXboxOrigin>( Marshal.ReadIntPtr( VTable, 248) );
			_TranslateActionOrigin = Marshal.GetDelegateForFunctionPointer<FTranslateActionOrigin>( Marshal.ReadIntPtr( VTable, 256) );
		}
		internal override void Shutdown()
		{
			base.Shutdown();
			
			_DoInit = null;
			_DoShutdown = null;
			_RunFrame = null;
			_GetConnectedControllers = null;
			_GetActionSetHandle = null;
			_ActivateActionSet = null;
			_GetCurrentActionSet = null;
			_ActivateActionSetLayer = null;
			_DeactivateActionSetLayer = null;
			_DeactivateAllActionSetLayers = null;
			_GetActiveActionSetLayers = null;
			_GetDigitalActionHandle = null;
			_GetDigitalActionData = null;
			_GetDigitalActionData_Windows = null;
			_GetDigitalActionOrigins = null;
			_GetAnalogActionHandle = null;
			_GetAnalogActionData = null;
			_GetAnalogActionData_Windows = null;
			_GetAnalogActionOrigins = null;
			_GetGlyphForActionOrigin = null;
			_GetStringForActionOrigin = null;
			_StopAnalogActionMomentum = null;
			_GetMotionData = null;
			_GetMotionData_Windows = null;
			_TriggerVibration = null;
			_SetLEDColor = null;
			_TriggerHapticPulse = null;
			_TriggerRepeatedHapticPulse = null;
			_ShowBindingPanel = null;
			_GetInputTypeForHandle = null;
			_GetControllerForGamepadIndex = null;
			_GetGamepadIndexForController = null;
			_GetStringForXboxOrigin = null;
			_GetGlyphForXboxOrigin = null;
			_GetActionOriginFromXboxOrigin = null;
			_TranslateActionOrigin = null;
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FDoInit( IntPtr self );
		private FDoInit _DoInit;
		
		#endregion
		internal bool DoInit()
		{
			return _DoInit( Self );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FDoShutdown( IntPtr self );
		private FDoShutdown _DoShutdown;
		
		#endregion
		internal bool DoShutdown()
		{
			return _DoShutdown( Self );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate void FRunFrame( IntPtr self );
		private FRunFrame _RunFrame;
		
		#endregion
		internal void RunFrame()
		{
			_RunFrame( Self );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate int FGetConnectedControllers( IntPtr self, [In,Out] InputHandle_t[]  handlesOut );
		private FGetConnectedControllers _GetConnectedControllers;
		
		#endregion
		internal int GetConnectedControllers( [In,Out] InputHandle_t[]  handlesOut )
		{
			return _GetConnectedControllers( Self, handlesOut );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate InputActionSetHandle_t FGetActionSetHandle( IntPtr self, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pszActionSetName );
		private FGetActionSetHandle _GetActionSetHandle;
		
		#endregion
		internal InputActionSetHandle_t GetActionSetHandle( [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pszActionSetName )
		{
			return _GetActionSetHandle( Self, pszActionSetName );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate void FActivateActionSet( IntPtr self, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle );
		private FActivateActionSet _ActivateActionSet;
		
		#endregion
		internal void ActivateActionSet( InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle )
		{
			_ActivateActionSet( Self, inputHandle, actionSetHandle );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate InputActionSetHandle_t FGetCurrentActionSet( IntPtr self, InputHandle_t inputHandle );
		private FGetCurrentActionSet _GetCurrentActionSet;
		
		#endregion
		internal InputActionSetHandle_t GetCurrentActionSet( InputHandle_t inputHandle )
		{
			return _GetCurrentActionSet( Self, inputHandle );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate void FActivateActionSetLayer( IntPtr self, InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle );
		private FActivateActionSetLayer _ActivateActionSetLayer;
		
		#endregion
		internal void ActivateActionSetLayer( InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle )
		{
			_ActivateActionSetLayer( Self, inputHandle, actionSetLayerHandle );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate void FDeactivateActionSetLayer( IntPtr self, InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle );
		private FDeactivateActionSetLayer _DeactivateActionSetLayer;
		
		#endregion
		internal void DeactivateActionSetLayer( InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle )
		{
			_DeactivateActionSetLayer( Self, inputHandle, actionSetLayerHandle );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate void FDeactivateAllActionSetLayers( IntPtr self, InputHandle_t inputHandle );
		private FDeactivateAllActionSetLayers _DeactivateAllActionSetLayers;
		
		#endregion
		internal void DeactivateAllActionSetLayers( InputHandle_t inputHandle )
		{
			_DeactivateAllActionSetLayers( Self, inputHandle );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate int FGetActiveActionSetLayers( IntPtr self, InputHandle_t inputHandle, [In,Out] InputActionSetHandle_t[]  handlesOut );
		private FGetActiveActionSetLayers _GetActiveActionSetLayers;
		
		#endregion
		internal int GetActiveActionSetLayers( InputHandle_t inputHandle, [In,Out] InputActionSetHandle_t[]  handlesOut )
		{
			return _GetActiveActionSetLayers( Self, inputHandle, handlesOut );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate InputDigitalActionHandle_t FGetDigitalActionHandle( IntPtr self, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pszActionName );
		private FGetDigitalActionHandle _GetDigitalActionHandle;
		
		#endregion
		internal InputDigitalActionHandle_t GetDigitalActionHandle( [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pszActionName )
		{
			return _GetDigitalActionHandle( Self, pszActionName );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate DigitalState FGetDigitalActionData( IntPtr self, InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle );
		private FGetDigitalActionData _GetDigitalActionData;
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate void FGetDigitalActionData_Windows( IntPtr self, ref DigitalState retVal, InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle );
		private FGetDigitalActionData_Windows _GetDigitalActionData_Windows;
		
		#endregion
		internal DigitalState GetDigitalActionData( InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle )
		{
			if ( Config.Os == OsType.Windows )
			{
				var retVal = default( DigitalState );
				_GetDigitalActionData_Windows( Self, ref retVal, inputHandle, digitalActionHandle );
				return retVal;
			}
			
			return _GetDigitalActionData( Self, inputHandle, digitalActionHandle );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate int FGetDigitalActionOrigins( IntPtr self, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, ref InputActionOrigin[] originsOut );
		private FGetDigitalActionOrigins _GetDigitalActionOrigins;
		
		#endregion
		internal int GetDigitalActionOrigins( InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, ref InputActionOrigin[] originsOut )
		{
			return _GetDigitalActionOrigins( Self, inputHandle, actionSetHandle, digitalActionHandle, ref originsOut );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate InputAnalogActionHandle_t FGetAnalogActionHandle( IntPtr self, [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pszActionName );
		private FGetAnalogActionHandle _GetAnalogActionHandle;
		
		#endregion
		internal InputAnalogActionHandle_t GetAnalogActionHandle( [MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringToNative ) )] string pszActionName )
		{
			return _GetAnalogActionHandle( Self, pszActionName );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate AnalogState FGetAnalogActionData( IntPtr self, InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle );
		private FGetAnalogActionData _GetAnalogActionData;
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate void FGetAnalogActionData_Windows( IntPtr self, ref AnalogState retVal, InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle );
		private FGetAnalogActionData_Windows _GetAnalogActionData_Windows;
		
		#endregion
		internal AnalogState GetAnalogActionData( InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle )
		{
			if ( Config.Os == OsType.Windows )
			{
				var retVal = default( AnalogState );
				_GetAnalogActionData_Windows( Self, ref retVal, inputHandle, analogActionHandle );
				return retVal;
			}
			
			return _GetAnalogActionData( Self, inputHandle, analogActionHandle );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate int FGetAnalogActionOrigins( IntPtr self, InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, ref InputActionOrigin originsOut );
		private FGetAnalogActionOrigins _GetAnalogActionOrigins;
		
		#endregion
		internal int GetAnalogActionOrigins( InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, ref InputActionOrigin originsOut )
		{
			return _GetAnalogActionOrigins( Self, inputHandle, actionSetHandle, analogActionHandle, ref originsOut );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		[return: MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringFromNative ) )]
		private delegate string FGetGlyphForActionOrigin( IntPtr self, InputActionOrigin eOrigin );
		private FGetGlyphForActionOrigin _GetGlyphForActionOrigin;
		
		#endregion
		internal string GetGlyphForActionOrigin( InputActionOrigin eOrigin )
		{
			return _GetGlyphForActionOrigin( Self, eOrigin );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		[return: MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringFromNative ) )]
		private delegate string FGetStringForActionOrigin( IntPtr self, InputActionOrigin eOrigin );
		private FGetStringForActionOrigin _GetStringForActionOrigin;
		
		#endregion
		internal string GetStringForActionOrigin( InputActionOrigin eOrigin )
		{
			return _GetStringForActionOrigin( Self, eOrigin );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate void FStopAnalogActionMomentum( IntPtr self, InputHandle_t inputHandle, InputAnalogActionHandle_t eAction );
		private FStopAnalogActionMomentum _StopAnalogActionMomentum;
		
		#endregion
		internal void StopAnalogActionMomentum( InputHandle_t inputHandle, InputAnalogActionHandle_t eAction )
		{
			_StopAnalogActionMomentum( Self, inputHandle, eAction );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate MotionState FGetMotionData( IntPtr self, InputHandle_t inputHandle );
		private FGetMotionData _GetMotionData;
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate void FGetMotionData_Windows( IntPtr self, ref MotionState retVal, InputHandle_t inputHandle );
		private FGetMotionData_Windows _GetMotionData_Windows;
		
		#endregion
		internal MotionState GetMotionData( InputHandle_t inputHandle )
		{
			if ( Config.Os == OsType.Windows )
			{
				var retVal = default( MotionState );
				_GetMotionData_Windows( Self, ref retVal, inputHandle );
				return retVal;
			}
			
			return _GetMotionData( Self, inputHandle );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate void FTriggerVibration( IntPtr self, InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed );
		private FTriggerVibration _TriggerVibration;
		
		#endregion
		internal void TriggerVibration( InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed )
		{
			_TriggerVibration( Self, inputHandle, usLeftSpeed, usRightSpeed );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate void FSetLEDColor( IntPtr self, InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags );
		private FSetLEDColor _SetLEDColor;
		
		#endregion
		internal void SetLEDColor( InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags )
		{
			_SetLEDColor( Self, inputHandle, nColorR, nColorG, nColorB, nFlags );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate void FTriggerHapticPulse( IntPtr self, InputHandle_t inputHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec );
		private FTriggerHapticPulse _TriggerHapticPulse;
		
		#endregion
		internal void TriggerHapticPulse( InputHandle_t inputHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec )
		{
			_TriggerHapticPulse( Self, inputHandle, eTargetPad, usDurationMicroSec );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate void FTriggerRepeatedHapticPulse( IntPtr self, InputHandle_t inputHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags );
		private FTriggerRepeatedHapticPulse _TriggerRepeatedHapticPulse;
		
		#endregion
		internal void TriggerRepeatedHapticPulse( InputHandle_t inputHandle, SteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags )
		{
			_TriggerRepeatedHapticPulse( Self, inputHandle, eTargetPad, usDurationMicroSec, usOffMicroSec, unRepeat, nFlags );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		[return: MarshalAs( UnmanagedType.I1 )]
		private delegate bool FShowBindingPanel( IntPtr self, InputHandle_t inputHandle );
		private FShowBindingPanel _ShowBindingPanel;
		
		#endregion
		internal bool ShowBindingPanel( InputHandle_t inputHandle )
		{
			return _ShowBindingPanel( Self, inputHandle );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate InputType FGetInputTypeForHandle( IntPtr self, InputHandle_t inputHandle );
		private FGetInputTypeForHandle _GetInputTypeForHandle;
		
		#endregion
		internal InputType GetInputTypeForHandle( InputHandle_t inputHandle )
		{
			return _GetInputTypeForHandle( Self, inputHandle );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate InputHandle_t FGetControllerForGamepadIndex( IntPtr self, int nIndex );
		private FGetControllerForGamepadIndex _GetControllerForGamepadIndex;
		
		#endregion
		internal InputHandle_t GetControllerForGamepadIndex( int nIndex )
		{
			return _GetControllerForGamepadIndex( Self, nIndex );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate int FGetGamepadIndexForController( IntPtr self, InputHandle_t ulinputHandle );
		private FGetGamepadIndexForController _GetGamepadIndexForController;
		
		#endregion
		internal int GetGamepadIndexForController( InputHandle_t ulinputHandle )
		{
			return _GetGamepadIndexForController( Self, ulinputHandle );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		[return: MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringFromNative ) )]
		private delegate string FGetStringForXboxOrigin( IntPtr self, XboxOrigin eOrigin );
		private FGetStringForXboxOrigin _GetStringForXboxOrigin;
		
		#endregion
		internal string GetStringForXboxOrigin( XboxOrigin eOrigin )
		{
			return _GetStringForXboxOrigin( Self, eOrigin );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		[return: MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( Utf8StringFromNative ) )]
		private delegate string FGetGlyphForXboxOrigin( IntPtr self, XboxOrigin eOrigin );
		private FGetGlyphForXboxOrigin _GetGlyphForXboxOrigin;
		
		#endregion
		internal string GetGlyphForXboxOrigin( XboxOrigin eOrigin )
		{
			return _GetGlyphForXboxOrigin( Self, eOrigin );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate InputActionOrigin FGetActionOriginFromXboxOrigin( IntPtr self, InputHandle_t inputHandle, XboxOrigin eOrigin );
		private FGetActionOriginFromXboxOrigin _GetActionOriginFromXboxOrigin;
		
		#endregion
		internal InputActionOrigin GetActionOriginFromXboxOrigin( InputHandle_t inputHandle, XboxOrigin eOrigin )
		{
			return _GetActionOriginFromXboxOrigin( Self, inputHandle, eOrigin );
		}
		
		#region FunctionMeta
		[UnmanagedFunctionPointer( CallingConvention.ThisCall )]
		private delegate InputActionOrigin FTranslateActionOrigin( IntPtr self, InputType eDestinationInputType, InputActionOrigin eSourceOrigin );
		private FTranslateActionOrigin _TranslateActionOrigin;
		
		#endregion
		internal InputActionOrigin TranslateActionOrigin( InputType eDestinationInputType, InputActionOrigin eSourceOrigin )
		{
			return _TranslateActionOrigin( Self, eDestinationInputType, eSourceOrigin );
		}
		
	}
}
