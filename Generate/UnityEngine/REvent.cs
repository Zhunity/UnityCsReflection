using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Event
	/// </summary>
    public partial class REvent : RMember //
    {

		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected RField r_m_Ptr;
		public virtual RField Rm_Ptr
		{
			get
			{
				if(r_m_Ptr == null)
				{
					r_m_Ptr = new(this, "m_Ptr");
					r_m_Ptr.SetBelong(this.instance);
				}
				return r_m_Ptr;
			}
		}

		/// <summary>
		/// UnityEngine.Event s_Current
		/// </summary>
		protected static RUnityEngine.REvent r_s_Current;
		public static RUnityEngine.REvent Rs_Current
		{
			get
			{
				if(r_s_Current == null)
				{
					r_s_Current = new(typeof(UnityEngine.Event), "s_Current");
					r_s_Current.SetBelong(null);
				}
				return r_s_Current;
			}
		}

		/// <summary>
		/// UnityEngine.Event s_MasterEvent
		/// </summary>
		protected static RUnityEngine.REvent r_s_MasterEvent;
		public static RUnityEngine.REvent Rs_MasterEvent
		{
			get
			{
				if(r_s_MasterEvent == null)
				{
					r_s_MasterEvent = new(typeof(UnityEngine.Event), "s_MasterEvent");
					r_s_MasterEvent.SetBelong(null);
				}
				return r_s_MasterEvent;
			}
		}

		/// <summary>
		/// UnityEngine.EventType rawType
		/// </summary>
		protected RProperty r_rawType;
		public virtual RProperty RrawType
		{
			get
			{
				if(r_rawType == null)
				{
					r_rawType = new(this, "rawType", -1);
					r_rawType.SetBelong(this.instance);
				}
				return r_rawType;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 mousePosition
		/// </summary>
		protected RUnityEngine.RVector2 r_mousePosition;
		public virtual RUnityEngine.RVector2 RmousePosition
		{
			get
			{
				if(r_mousePosition == null)
				{
					r_mousePosition = new(this, "mousePosition", -1);
					r_mousePosition.SetBelong(this.instance);
				}
				return r_mousePosition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 delta
		/// </summary>
		protected RUnityEngine.RVector2 r_delta;
		public virtual RUnityEngine.RVector2 Rdelta
		{
			get
			{
				if(r_delta == null)
				{
					r_delta = new(this, "delta", -1);
					r_delta.SetBelong(this.instance);
				}
				return r_delta;
			}
		}

		/// <summary>
		/// UnityEngine.PointerType pointerType
		/// </summary>
		protected RProperty r_pointerType;
		public virtual RProperty RpointerType
		{
			get
			{
				if(r_pointerType == null)
				{
					r_pointerType = new(this, "pointerType", -1);
					r_pointerType.SetBelong(this.instance);
				}
				return r_pointerType;
			}
		}

		/// <summary>
		/// Int32 button
		/// </summary>
		protected RProperty r_button;
		public virtual RProperty Rbutton
		{
			get
			{
				if(r_button == null)
				{
					r_button = new(this, "button", -1);
					r_button.SetBelong(this.instance);
				}
				return r_button;
			}
		}

		/// <summary>
		/// UnityEngine.EventModifiers modifiers
		/// </summary>
		protected RProperty r_modifiers;
		public virtual RProperty Rmodifiers
		{
			get
			{
				if(r_modifiers == null)
				{
					r_modifiers = new(this, "modifiers", -1);
					r_modifiers.SetBelong(this.instance);
				}
				return r_modifiers;
			}
		}

		/// <summary>
		/// Single pressure
		/// </summary>
		protected RProperty r_pressure;
		public virtual RProperty Rpressure
		{
			get
			{
				if(r_pressure == null)
				{
					r_pressure = new(this, "pressure", -1);
					r_pressure.SetBelong(this.instance);
				}
				return r_pressure;
			}
		}

		/// <summary>
		/// Single twist
		/// </summary>
		protected RProperty r_twist;
		public virtual RProperty Rtwist
		{
			get
			{
				if(r_twist == null)
				{
					r_twist = new(this, "twist", -1);
					r_twist.SetBelong(this.instance);
				}
				return r_twist;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 tilt
		/// </summary>
		protected RUnityEngine.RVector2 r_tilt;
		public virtual RUnityEngine.RVector2 Rtilt
		{
			get
			{
				if(r_tilt == null)
				{
					r_tilt = new(this, "tilt", -1);
					r_tilt.SetBelong(this.instance);
				}
				return r_tilt;
			}
		}

		/// <summary>
		/// UnityEngine.PenStatus penStatus
		/// </summary>
		protected RProperty r_penStatus;
		public virtual RProperty RpenStatus
		{
			get
			{
				if(r_penStatus == null)
				{
					r_penStatus = new(this, "penStatus", -1);
					r_penStatus.SetBelong(this.instance);
				}
				return r_penStatus;
			}
		}

		/// <summary>
		/// Int32 clickCount
		/// </summary>
		protected RProperty r_clickCount;
		public virtual RProperty RclickCount
		{
			get
			{
				if(r_clickCount == null)
				{
					r_clickCount = new(this, "clickCount", -1);
					r_clickCount.SetBelong(this.instance);
				}
				return r_clickCount;
			}
		}

		/// <summary>
		/// Char character
		/// </summary>
		protected RProperty r_character;
		public virtual RProperty Rcharacter
		{
			get
			{
				if(r_character == null)
				{
					r_character = new(this, "character", -1);
					r_character.SetBelong(this.instance);
				}
				return r_character;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode keyCode
		/// </summary>
		protected RProperty r_keyCode;
		public virtual RProperty RkeyCode
		{
			get
			{
				if(r_keyCode == null)
				{
					r_keyCode = new(this, "keyCode", -1);
					r_keyCode.SetBelong(this.instance);
				}
				return r_keyCode;
			}
		}

		/// <summary>
		/// Int32 displayIndex
		/// </summary>
		protected RProperty r_displayIndex;
		public virtual RProperty RdisplayIndex
		{
			get
			{
				if(r_displayIndex == null)
				{
					r_displayIndex = new(this, "displayIndex", -1);
					r_displayIndex.SetBelong(this.instance);
				}
				return r_displayIndex;
			}
		}

		/// <summary>
		/// UnityEngine.EventType type
		/// </summary>
		protected RProperty r_type;
		public virtual RProperty Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type", -1);
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// System.String commandName
		/// </summary>
		protected RProperty r_commandName;
		public virtual RProperty RcommandName
		{
			get
			{
				if(r_commandName == null)
				{
					r_commandName = new(this, "commandName", -1);
					r_commandName.SetBelong(this.instance);
				}
				return r_commandName;
			}
		}

		/// <summary>
		/// UnityEngine.Ray mouseRay
		/// </summary>
		protected RUnityEngine.RRay r_mouseRay;
		public virtual RUnityEngine.RRay RmouseRay
		{
			get
			{
				if(r_mouseRay == null)
				{
					r_mouseRay = new(this, "mouseRay", -1);
					r_mouseRay.SetBelong(this.instance);
				}
				return r_mouseRay;
			}
		}

		/// <summary>
		/// Boolean shift
		/// </summary>
		protected RProperty r_shift;
		public virtual RProperty Rshift
		{
			get
			{
				if(r_shift == null)
				{
					r_shift = new(this, "shift", -1);
					r_shift.SetBelong(this.instance);
				}
				return r_shift;
			}
		}

		/// <summary>
		/// Boolean control
		/// </summary>
		protected RProperty r_control;
		public virtual RProperty Rcontrol
		{
			get
			{
				if(r_control == null)
				{
					r_control = new(this, "control", -1);
					r_control.SetBelong(this.instance);
				}
				return r_control;
			}
		}

		/// <summary>
		/// Boolean alt
		/// </summary>
		protected RProperty r_alt;
		public virtual RProperty Ralt
		{
			get
			{
				if(r_alt == null)
				{
					r_alt = new(this, "alt", -1);
					r_alt.SetBelong(this.instance);
				}
				return r_alt;
			}
		}

		/// <summary>
		/// Boolean command
		/// </summary>
		protected RProperty r_command;
		public virtual RProperty Rcommand
		{
			get
			{
				if(r_command == null)
				{
					r_command = new(this, "command", -1);
					r_command.SetBelong(this.instance);
				}
				return r_command;
			}
		}

		/// <summary>
		/// Boolean capsLock
		/// </summary>
		protected RProperty r_capsLock;
		public virtual RProperty RcapsLock
		{
			get
			{
				if(r_capsLock == null)
				{
					r_capsLock = new(this, "capsLock", -1);
					r_capsLock.SetBelong(this.instance);
				}
				return r_capsLock;
			}
		}

		/// <summary>
		/// Boolean numeric
		/// </summary>
		protected RProperty r_numeric;
		public virtual RProperty Rnumeric
		{
			get
			{
				if(r_numeric == null)
				{
					r_numeric = new(this, "numeric", -1);
					r_numeric.SetBelong(this.instance);
				}
				return r_numeric;
			}
		}

		/// <summary>
		/// Boolean functionKey
		/// </summary>
		protected RProperty r_functionKey;
		public virtual RProperty RfunctionKey
		{
			get
			{
				if(r_functionKey == null)
				{
					r_functionKey = new(this, "functionKey", -1);
					r_functionKey.SetBelong(this.instance);
				}
				return r_functionKey;
			}
		}

		/// <summary>
		/// UnityEngine.Event current
		/// </summary>
		protected static RUnityEngine.REvent r_current;
		public static RUnityEngine.REvent Rcurrent
		{
			get
			{
				if(r_current == null)
				{
					r_current = new(typeof(UnityEngine.Event), "current", -1);
					r_current.SetBelong(null);
				}
				return r_current;
			}
		}

		/// <summary>
		/// Boolean isKey
		/// </summary>
		protected RProperty r_isKey;
		public virtual RProperty RisKey
		{
			get
			{
				if(r_isKey == null)
				{
					r_isKey = new(this, "isKey", -1);
					r_isKey.SetBelong(this.instance);
				}
				return r_isKey;
			}
		}

		/// <summary>
		/// Boolean isMouse
		/// </summary>
		protected RProperty r_isMouse;
		public virtual RProperty RisMouse
		{
			get
			{
				if(r_isMouse == null)
				{
					r_isMouse = new(this, "isMouse", -1);
					r_isMouse.SetBelong(this.instance);
				}
				return r_isMouse;
			}
		}

		/// <summary>
		/// Boolean isScrollWheel
		/// </summary>
		protected RProperty r_isScrollWheel;
		public virtual RProperty RisScrollWheel
		{
			get
			{
				if(r_isScrollWheel == null)
				{
					r_isScrollWheel = new(this, "isScrollWheel", -1);
					r_isScrollWheel.SetBelong(this.instance);
				}
				return r_isScrollWheel;
			}
		}

		/// <summary>
		/// Boolean isDirectManipulationDevice
		/// </summary>
		protected RProperty r_isDirectManipulationDevice;
		public virtual RProperty RisDirectManipulationDevice
		{
			get
			{
				if(r_isDirectManipulationDevice == null)
				{
					r_isDirectManipulationDevice = new(this, "isDirectManipulationDevice", -1);
					r_isDirectManipulationDevice.SetBelong(this.instance);
				}
				return r_isDirectManipulationDevice;
			}
		}

		/// <summary>
		/// Void Internal_Use()
		/// </summary>
		protected RMethod r_RInternal_Use;
		public virtual RMethod RInternal_Use
		{
			get
			{
				if(r_RInternal_Use == null)
				{
					r_RInternal_Use = new(this, "Internal_Use", 0);
					r_RInternal_Use.SetBelong(this.instance);
				}
				return r_RInternal_Use;
			}
		}

		/// <summary>
		/// IntPtr Internal_Create(Int32)
		/// </summary>
		protected static RMethod r_RInternal_Create_Int32;
		public static RMethod RInternal_Create_Int32
		{
			get
			{
				if(r_RInternal_Create_Int32 == null)
				{
					r_RInternal_Create_Int32 = new(typeof(UnityEngine.Event), "Internal_Create", 0, typeof(System.Int32));
					r_RInternal_Create_Int32.SetBelong(null);
				}
				return r_RInternal_Create_Int32;
			}
		}

		/// <summary>
		/// Void Internal_Destroy(IntPtr)
		/// </summary>
		protected static RMethod r_RInternal_Destroy_IntPtr;
		public static RMethod RInternal_Destroy_IntPtr
		{
			get
			{
				if(r_RInternal_Destroy_IntPtr == null)
				{
					r_RInternal_Destroy_IntPtr = new(typeof(UnityEngine.Event), "Internal_Destroy", 0, typeof(System.IntPtr));
					r_RInternal_Destroy_IntPtr.SetBelong(null);
				}
				return r_RInternal_Destroy_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr Internal_Copy(IntPtr)
		/// </summary>
		protected static RMethod r_RInternal_Copy_IntPtr;
		public static RMethod RInternal_Copy_IntPtr
		{
			get
			{
				if(r_RInternal_Copy_IntPtr == null)
				{
					r_RInternal_Copy_IntPtr = new(typeof(UnityEngine.Event), "Internal_Copy", 0, typeof(System.IntPtr));
					r_RInternal_Copy_IntPtr.SetBelong(null);
				}
				return r_RInternal_Copy_IntPtr;
			}
		}

		/// <summary>
		/// UnityEngine.EventType GetTypeForControl(Int32)
		/// </summary>
		protected RMethod r_RGetTypeForControl_Int32;
		public virtual RMethod RGetTypeForControl_Int32
		{
			get
			{
				if(r_RGetTypeForControl_Int32 == null)
				{
					r_RGetTypeForControl_Int32 = new(this, "GetTypeForControl", 0, typeof(System.Int32));
					r_RGetTypeForControl_Int32.SetBelong(this.instance);
				}
				return r_RGetTypeForControl_Int32;
			}
		}

		/// <summary>
		/// Void CopyFromPtr(IntPtr)
		/// </summary>
		protected RMethod r_RCopyFromPtr_IntPtr;
		public virtual RMethod RCopyFromPtr_IntPtr
		{
			get
			{
				if(r_RCopyFromPtr_IntPtr == null)
				{
					r_RCopyFromPtr_IntPtr = new(this, "CopyFromPtr", 0, typeof(System.IntPtr));
					r_RCopyFromPtr_IntPtr.SetBelong(this.instance);
				}
				return r_RCopyFromPtr_IntPtr;
			}
		}

		/// <summary>
		/// Boolean PopEvent(UnityEngine.Event)
		/// </summary>
		protected static RMethod r_RPopEvent_Event;
		public static RMethod RPopEvent_Event
		{
			get
			{
				if(r_RPopEvent_Event == null)
				{
					r_RPopEvent_Event = new(typeof(UnityEngine.Event), "PopEvent", 0, typeof(UnityEngine.Event));
					r_RPopEvent_Event.SetBelong(null);
				}
				return r_RPopEvent_Event;
			}
		}

		/// <summary>
		/// Int32 GetEventCount()
		/// </summary>
		protected static RMethod r_RGetEventCount;
		public static RMethod RGetEventCount
		{
			get
			{
				if(r_RGetEventCount == null)
				{
					r_RGetEventCount = new(typeof(UnityEngine.Event), "GetEventCount", 0);
					r_RGetEventCount.SetBelong(null);
				}
				return r_RGetEventCount;
			}
		}

		/// <summary>
		/// Void Internal_SetNativeEvent(IntPtr)
		/// </summary>
		protected static RMethod r_RInternal_SetNativeEvent_IntPtr;
		public static RMethod RInternal_SetNativeEvent_IntPtr
		{
			get
			{
				if(r_RInternal_SetNativeEvent_IntPtr == null)
				{
					r_RInternal_SetNativeEvent_IntPtr = new(typeof(UnityEngine.Event), "Internal_SetNativeEvent", 0, typeof(System.IntPtr));
					r_RInternal_SetNativeEvent_IntPtr.SetBelong(null);
				}
				return r_RInternal_SetNativeEvent_IntPtr;
			}
		}

		/// <summary>
		/// Void Internal_MakeMasterEventCurrent(Int32)
		/// </summary>
		protected static RMethod r_RInternal_MakeMasterEventCurrent_Int32;
		public static RMethod RInternal_MakeMasterEventCurrent_Int32
		{
			get
			{
				if(r_RInternal_MakeMasterEventCurrent_Int32 == null)
				{
					r_RInternal_MakeMasterEventCurrent_Int32 = new(typeof(UnityEngine.Event), "Internal_MakeMasterEventCurrent", 0, typeof(System.Int32));
					r_RInternal_MakeMasterEventCurrent_Int32.SetBelong(null);
				}
				return r_RInternal_MakeMasterEventCurrent_Int32;
			}
		}

		/// <summary>
		/// Int32 GetDoubleClickTime()
		/// </summary>
		protected static RMethod r_RGetDoubleClickTime;
		public static RMethod RGetDoubleClickTime
		{
			get
			{
				if(r_RGetDoubleClickTime == null)
				{
					r_RGetDoubleClickTime = new(typeof(UnityEngine.Event), "GetDoubleClickTime", 0);
					r_RGetDoubleClickTime.SetBelong(null);
				}
				return r_RGetDoubleClickTime;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// Void CleanupRoots()
		/// </summary>
		protected static RMethod r_RCleanupRoots;
		public static RMethod RCleanupRoots
		{
			get
			{
				if(r_RCleanupRoots == null)
				{
					r_RCleanupRoots = new(typeof(UnityEngine.Event), "CleanupRoots", 0);
					r_RCleanupRoots.SetBelong(null);
				}
				return r_RCleanupRoots;
			}
		}

		/// <summary>
		/// Void CopyFrom(UnityEngine.Event)
		/// </summary>
		protected RMethod r_RCopyFrom_Event;
		public virtual RMethod RCopyFrom_Event
		{
			get
			{
				if(r_RCopyFrom_Event == null)
				{
					r_RCopyFrom_Event = new(this, "CopyFrom", 0, typeof(UnityEngine.Event));
					r_RCopyFrom_Event.SetBelong(this.instance);
				}
				return r_RCopyFrom_Event;
			}
		}

		/// <summary>
		/// UnityEngine.Event KeyboardEvent(System.String)
		/// </summary>
		protected static RMethod r_RKeyboardEvent_String;
		public static RMethod RKeyboardEvent_String
		{
			get
			{
				if(r_RKeyboardEvent_String == null)
				{
					r_RKeyboardEvent_String = new(typeof(UnityEngine.Event), "KeyboardEvent", 0, typeof(System.String));
					r_RKeyboardEvent_String.SetBelong(null);
				}
				return r_RKeyboardEvent_String;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// Void Use()
		/// </summary>
		protected RMethod r_RUse;
		public virtual RMethod RUse
		{
			get
			{
				if(r_RUse == null)
				{
					r_RUse = new(this, "Use", 0);
					r_RUse.SetBelong(this.instance);
				}
				return r_RUse;
			}
		}

		/// <summary>
		/// Void get_mousePosition_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Rget_mousePosition_Injected_Out_Vector2;
		public virtual RMethod Rget_mousePosition_Injected_Out_Vector2
		{
			get
			{
				if(r_Rget_mousePosition_Injected_Out_Vector2 == null)
				{
					r_Rget_mousePosition_Injected_Out_Vector2 = new(this, "get_mousePosition_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Rget_mousePosition_Injected_Out_Vector2.SetBelong(this.instance);
				}
				return r_Rget_mousePosition_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void set_mousePosition_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Rset_mousePosition_Injected_Ref_Vector2;
		public virtual RMethod Rset_mousePosition_Injected_Ref_Vector2
		{
			get
			{
				if(r_Rset_mousePosition_Injected_Ref_Vector2 == null)
				{
					r_Rset_mousePosition_Injected_Ref_Vector2 = new(this, "set_mousePosition_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Rset_mousePosition_Injected_Ref_Vector2.SetBelong(this.instance);
				}
				return r_Rset_mousePosition_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void get_delta_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Rget_delta_Injected_Out_Vector2;
		public virtual RMethod Rget_delta_Injected_Out_Vector2
		{
			get
			{
				if(r_Rget_delta_Injected_Out_Vector2 == null)
				{
					r_Rget_delta_Injected_Out_Vector2 = new(this, "get_delta_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Rget_delta_Injected_Out_Vector2.SetBelong(this.instance);
				}
				return r_Rget_delta_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void set_delta_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Rset_delta_Injected_Ref_Vector2;
		public virtual RMethod Rset_delta_Injected_Ref_Vector2
		{
			get
			{
				if(r_Rset_delta_Injected_Ref_Vector2 == null)
				{
					r_Rset_delta_Injected_Ref_Vector2 = new(this, "set_delta_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Rset_delta_Injected_Ref_Vector2.SetBelong(this.instance);
				}
				return r_Rset_delta_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void get_tilt_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Rget_tilt_Injected_Out_Vector2;
		public virtual RMethod Rget_tilt_Injected_Out_Vector2
		{
			get
			{
				if(r_Rget_tilt_Injected_Out_Vector2 == null)
				{
					r_Rget_tilt_Injected_Out_Vector2 = new(this, "get_tilt_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Rget_tilt_Injected_Out_Vector2.SetBelong(this.instance);
				}
				return r_Rget_tilt_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void set_tilt_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Rset_tilt_Injected_Ref_Vector2;
		public virtual RMethod Rset_tilt_Injected_Ref_Vector2
		{
			get
			{
				if(r_Rset_tilt_Injected_Ref_Vector2 == null)
				{
					r_Rset_tilt_Injected_Ref_Vector2 = new(this, "set_tilt_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Rset_tilt_Injected_Ref_Vector2.SetBelong(this.instance);
				}
				return r_Rset_tilt_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}


        public REvent() : base("UnityEngine.Event")
        {
        }

        public REvent(System.Object instance) : base("UnityEngine.Event")
		{
            SetInstance(instance);
		}

        public REvent(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REvent(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Internal_Use()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternal_Use.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr Internal_Create(System.Int32  @displayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayIndex};
            var ___result = RInternal_Create_Int32.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static void Internal_Destroy(System.IntPtr  @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ptr};
            var ___result = RInternal_Destroy_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr Internal_Copy(System.IntPtr  @otherPtr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@otherPtr};
            var ___result = RInternal_Copy_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual UnityEngine.EventType GetTypeForControl(System.Int32  @controlID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@controlID};
            var ___result = RGetTypeForControl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.EventType)___result;
        }


        public virtual void CopyFromPtr(System.IntPtr  @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ptr};
            var ___result = RCopyFromPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean PopEvent(UnityEngine.Event  @outEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outEvent};
            var ___result = RPopEvent_Event.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 GetEventCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEventCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void Internal_SetNativeEvent(System.IntPtr  @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ptr};
            var ___result = RInternal_SetNativeEvent_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_MakeMasterEventCurrent(System.Int32  @displayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayIndex};
            var ___result = RInternal_MakeMasterEventCurrent_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 GetDoubleClickTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDoubleClickTime.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public static void CleanupRoots()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCleanupRoots.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyFrom(UnityEngine.Event  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RCopyFrom_Event.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Event KeyboardEvent(System.String  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RKeyboardEvent_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Event)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Use()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUse.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void get_mousePosition_Injected(out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_mousePosition_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void set_mousePosition_Injected(ref UnityEngine.Vector2  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_mousePosition_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void get_delta_Injected(out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_delta_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void set_delta_Injected(ref UnityEngine.Vector2  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_delta_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void get_tilt_Injected(out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_tilt_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void set_tilt_Injected(ref UnityEngine.Vector2  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_tilt_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
