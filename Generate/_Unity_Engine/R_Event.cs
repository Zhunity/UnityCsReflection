
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.Event
	/// </summary>
    public partial class REvent : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Event);
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


		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fm_Ptr;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFm_Ptr
		{
			get
			{
				if(r_Fm_Ptr == null)
				{
					r_Fm_Ptr = new(this, "m_Ptr");
				}
				return r_Fm_Ptr;
			}
		}

		/// <summary>
		/// UnityEngine.Event s_Current
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REvent r_Fs_Current;
		public static Hvak.Editor.Refleaction.RUnityEngine.REvent RFs_Current
		{
			get
			{
				if(r_Fs_Current == null)
				{
					r_Fs_Current = new(Type, "s_Current");
				}
				return r_Fs_Current;
			}
		}

		/// <summary>
		/// UnityEngine.Event s_MasterEvent
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REvent r_Fs_MasterEvent;
		public static Hvak.Editor.Refleaction.RUnityEngine.REvent RFs_MasterEvent
		{
			get
			{
				if(r_Fs_MasterEvent == null)
				{
					r_Fs_MasterEvent = new(Type, "s_MasterEvent");
				}
				return r_Fs_MasterEvent;
			}
		}

		/// <summary>
		/// UnityEngine.EventType rawType
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.REventType r_PrawType;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.REventType RPrawType
		{
			get
			{
				if(r_PrawType == null)
				{
					r_PrawType = new(this, "rawType", -1);
				}
				return r_PrawType;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 mousePosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PmousePosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPmousePosition
		{
			get
			{
				if(r_PmousePosition == null)
				{
					r_PmousePosition = new(this, "mousePosition", -1);
				}
				return r_PmousePosition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 delta
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Pdelta;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPdelta
		{
			get
			{
				if(r_Pdelta == null)
				{
					r_Pdelta = new(this, "delta", -1);
				}
				return r_Pdelta;
			}
		}

		/// <summary>
		/// UnityEngine.PointerType pointerType
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RPointerType r_PpointerType;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RPointerType RPpointerType
		{
			get
			{
				if(r_PpointerType == null)
				{
					r_PpointerType = new(this, "pointerType", -1);
				}
				return r_PpointerType;
			}
		}

		/// <summary>
		/// Int32 button
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pbutton;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPbutton
		{
			get
			{
				if(r_Pbutton == null)
				{
					r_Pbutton = new(this, "button", -1);
				}
				return r_Pbutton;
			}
		}

		/// <summary>
		/// UnityEngine.EventModifiers modifiers
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.REventModifiers r_Pmodifiers;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.REventModifiers RPmodifiers
		{
			get
			{
				if(r_Pmodifiers == null)
				{
					r_Pmodifiers = new(this, "modifiers", -1);
				}
				return r_Pmodifiers;
			}
		}

		/// <summary>
		/// Single pressure
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Ppressure;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPpressure
		{
			get
			{
				if(r_Ppressure == null)
				{
					r_Ppressure = new(this, "pressure", -1);
				}
				return r_Ppressure;
			}
		}

		/// <summary>
		/// Single twist
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Ptwist;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPtwist
		{
			get
			{
				if(r_Ptwist == null)
				{
					r_Ptwist = new(this, "twist", -1);
				}
				return r_Ptwist;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 tilt
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_Ptilt;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPtilt
		{
			get
			{
				if(r_Ptilt == null)
				{
					r_Ptilt = new(this, "tilt", -1);
				}
				return r_Ptilt;
			}
		}

		/// <summary>
		/// UnityEngine.PenStatus penStatus
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RPenStatus r_PpenStatus;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RPenStatus RPpenStatus
		{
			get
			{
				if(r_PpenStatus == null)
				{
					r_PpenStatus = new(this, "penStatus", -1);
				}
				return r_PpenStatus;
			}
		}

		/// <summary>
		/// Int32 clickCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PclickCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPclickCount
		{
			get
			{
				if(r_PclickCount == null)
				{
					r_PclickCount = new(this, "clickCount", -1);
				}
				return r_PclickCount;
			}
		}

		/// <summary>
		/// Char character
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RChar r_Pcharacter;
		public virtual Hvak.Editor.Refleaction.RSystem.RChar RPcharacter
		{
			get
			{
				if(r_Pcharacter == null)
				{
					r_Pcharacter = new(this, "character", -1);
				}
				return r_Pcharacter;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode keyCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_PkeyCode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RPkeyCode
		{
			get
			{
				if(r_PkeyCode == null)
				{
					r_PkeyCode = new(this, "keyCode", -1);
				}
				return r_PkeyCode;
			}
		}

		/// <summary>
		/// Int32 displayIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PdisplayIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPdisplayIndex
		{
			get
			{
				if(r_PdisplayIndex == null)
				{
					r_PdisplayIndex = new(this, "displayIndex", -1);
				}
				return r_PdisplayIndex;
			}
		}

		/// <summary>
		/// UnityEngine.EventType type
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.REventType r_Ptype;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.REventType RPtype
		{
			get
			{
				if(r_Ptype == null)
				{
					r_Ptype = new(this, "type", -1);
				}
				return r_Ptype;
			}
		}

		/// <summary>
		/// System.String commandName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PcommandName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPcommandName
		{
			get
			{
				if(r_PcommandName == null)
				{
					r_PcommandName = new(this, "commandName", -1);
				}
				return r_PcommandName;
			}
		}

		/// <summary>
		/// UnityEngine.Ray mouseRay
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRay r_PmouseRay;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRay RPmouseRay
		{
			get
			{
				if(r_PmouseRay == null)
				{
					r_PmouseRay = new(this, "mouseRay", -1);
				}
				return r_PmouseRay;
			}
		}

		/// <summary>
		/// Boolean shift
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pshift;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPshift
		{
			get
			{
				if(r_Pshift == null)
				{
					r_Pshift = new(this, "shift", -1);
				}
				return r_Pshift;
			}
		}

		/// <summary>
		/// Boolean control
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pcontrol;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPcontrol
		{
			get
			{
				if(r_Pcontrol == null)
				{
					r_Pcontrol = new(this, "control", -1);
				}
				return r_Pcontrol;
			}
		}

		/// <summary>
		/// Boolean alt
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Palt;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPalt
		{
			get
			{
				if(r_Palt == null)
				{
					r_Palt = new(this, "alt", -1);
				}
				return r_Palt;
			}
		}

		/// <summary>
		/// Boolean command
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pcommand;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPcommand
		{
			get
			{
				if(r_Pcommand == null)
				{
					r_Pcommand = new(this, "command", -1);
				}
				return r_Pcommand;
			}
		}

		/// <summary>
		/// Boolean capsLock
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PcapsLock;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPcapsLock
		{
			get
			{
				if(r_PcapsLock == null)
				{
					r_PcapsLock = new(this, "capsLock", -1);
				}
				return r_PcapsLock;
			}
		}

		/// <summary>
		/// Boolean numeric
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pnumeric;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPnumeric
		{
			get
			{
				if(r_Pnumeric == null)
				{
					r_Pnumeric = new(this, "numeric", -1);
				}
				return r_Pnumeric;
			}
		}

		/// <summary>
		/// Boolean functionKey
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PfunctionKey;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPfunctionKey
		{
			get
			{
				if(r_PfunctionKey == null)
				{
					r_PfunctionKey = new(this, "functionKey", -1);
				}
				return r_PfunctionKey;
			}
		}

		/// <summary>
		/// UnityEngine.Event current
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REvent r_Pcurrent;
		public static Hvak.Editor.Refleaction.RUnityEngine.REvent RPcurrent
		{
			get
			{
				if(r_Pcurrent == null)
				{
					r_Pcurrent = new(Type, "current", -1);
				}
				return r_Pcurrent;
			}
		}

		/// <summary>
		/// Boolean isKey
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisKey;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisKey
		{
			get
			{
				if(r_PisKey == null)
				{
					r_PisKey = new(this, "isKey", -1);
				}
				return r_PisKey;
			}
		}

		/// <summary>
		/// Boolean isMouse
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisMouse;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisMouse
		{
			get
			{
				if(r_PisMouse == null)
				{
					r_PisMouse = new(this, "isMouse", -1);
				}
				return r_PisMouse;
			}
		}

		/// <summary>
		/// Boolean isScrollWheel
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisScrollWheel;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisScrollWheel
		{
			get
			{
				if(r_PisScrollWheel == null)
				{
					r_PisScrollWheel = new(this, "isScrollWheel", -1);
				}
				return r_PisScrollWheel;
			}
		}

		/// <summary>
		/// Boolean isDirectManipulationDevice
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisDirectManipulationDevice;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisDirectManipulationDevice
		{
			get
			{
				if(r_PisDirectManipulationDevice == null)
				{
					r_PisDirectManipulationDevice = new(this, "isDirectManipulationDevice", -1);
				}
				return r_PisDirectManipulationDevice;
			}
		}

		/// <summary>
		/// Void Internal_Use()
		/// </summary>
		protected RMethod r_MInternal_Use;
		public virtual RMethod RMInternal_Use
		{
			get
			{
				if(r_MInternal_Use == null)
				{
					r_MInternal_Use = new(this, "Internal_Use", 0);
				}
				return r_MInternal_Use;
			}
		}

		/// <summary>
		/// IntPtr Internal_Create(Int32)
		/// </summary>
		protected static RMethod r_MInternal_Create_Int32;
		public static RMethod RMInternal_Create_Int32
		{
			get
			{
				if(r_MInternal_Create_Int32 == null)
				{
					r_MInternal_Create_Int32 = new(Type, "Internal_Create", 0, typeof(System.Int32));
				}
				return r_MInternal_Create_Int32;
			}
		}

		/// <summary>
		/// Void Internal_Destroy(IntPtr)
		/// </summary>
		protected static RMethod r_MInternal_Destroy_IntPtr;
		public static RMethod RMInternal_Destroy_IntPtr
		{
			get
			{
				if(r_MInternal_Destroy_IntPtr == null)
				{
					r_MInternal_Destroy_IntPtr = new(Type, "Internal_Destroy", 0, typeof(System.IntPtr));
				}
				return r_MInternal_Destroy_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr Internal_Copy(IntPtr)
		/// </summary>
		protected static RMethod r_MInternal_Copy_IntPtr;
		public static RMethod RMInternal_Copy_IntPtr
		{
			get
			{
				if(r_MInternal_Copy_IntPtr == null)
				{
					r_MInternal_Copy_IntPtr = new(Type, "Internal_Copy", 0, typeof(System.IntPtr));
				}
				return r_MInternal_Copy_IntPtr;
			}
		}

		/// <summary>
		/// UnityEngine.EventType GetTypeForControl(Int32)
		/// </summary>
		protected RMethod r_MGetTypeForControl_Int32;
		public virtual RMethod RMGetTypeForControl_Int32
		{
			get
			{
				if(r_MGetTypeForControl_Int32 == null)
				{
					r_MGetTypeForControl_Int32 = new(this, "GetTypeForControl", 0, typeof(System.Int32));
				}
				return r_MGetTypeForControl_Int32;
			}
		}

		/// <summary>
		/// Void CopyFromPtr(IntPtr)
		/// </summary>
		protected RMethod r_MCopyFromPtr_IntPtr;
		public virtual RMethod RMCopyFromPtr_IntPtr
		{
			get
			{
				if(r_MCopyFromPtr_IntPtr == null)
				{
					r_MCopyFromPtr_IntPtr = new(this, "CopyFromPtr", 0, typeof(System.IntPtr));
				}
				return r_MCopyFromPtr_IntPtr;
			}
		}

		/// <summary>
		/// Boolean PopEvent(UnityEngine.Event)
		/// </summary>
		protected static RMethod r_MPopEvent_Event;
		public static RMethod RMPopEvent_Event
		{
			get
			{
				if(r_MPopEvent_Event == null)
				{
					r_MPopEvent_Event = new(Type, "PopEvent", 0, typeof(UnityEngine.Event));
				}
				return r_MPopEvent_Event;
			}
		}

		/// <summary>
		/// Int32 GetEventCount()
		/// </summary>
		protected static RMethod r_MGetEventCount;
		public static RMethod RMGetEventCount
		{
			get
			{
				if(r_MGetEventCount == null)
				{
					r_MGetEventCount = new(Type, "GetEventCount", 0);
				}
				return r_MGetEventCount;
			}
		}

		/// <summary>
		/// Void Internal_SetNativeEvent(IntPtr)
		/// </summary>
		protected static RMethod r_MInternal_SetNativeEvent_IntPtr;
		public static RMethod RMInternal_SetNativeEvent_IntPtr
		{
			get
			{
				if(r_MInternal_SetNativeEvent_IntPtr == null)
				{
					r_MInternal_SetNativeEvent_IntPtr = new(Type, "Internal_SetNativeEvent", 0, typeof(System.IntPtr));
				}
				return r_MInternal_SetNativeEvent_IntPtr;
			}
		}

		/// <summary>
		/// Void Internal_MakeMasterEventCurrent(Int32)
		/// </summary>
		protected static RMethod r_MInternal_MakeMasterEventCurrent_Int32;
		public static RMethod RMInternal_MakeMasterEventCurrent_Int32
		{
			get
			{
				if(r_MInternal_MakeMasterEventCurrent_Int32 == null)
				{
					r_MInternal_MakeMasterEventCurrent_Int32 = new(Type, "Internal_MakeMasterEventCurrent", 0, typeof(System.Int32));
				}
				return r_MInternal_MakeMasterEventCurrent_Int32;
			}
		}

		/// <summary>
		/// Int32 GetDoubleClickTime()
		/// </summary>
		protected static RMethod r_MGetDoubleClickTime;
		public static RMethod RMGetDoubleClickTime
		{
			get
			{
				if(r_MGetDoubleClickTime == null)
				{
					r_MGetDoubleClickTime = new(Type, "GetDoubleClickTime", 0);
				}
				return r_MGetDoubleClickTime;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_MFinalize;
		public virtual RMethod RMFinalize
		{
			get
			{
				if(r_MFinalize == null)
				{
					r_MFinalize = new(this, "Finalize", 0);
				}
				return r_MFinalize;
			}
		}

		/// <summary>
		/// Void CleanupRoots()
		/// </summary>
		protected static RMethod r_MCleanupRoots;
		public static RMethod RMCleanupRoots
		{
			get
			{
				if(r_MCleanupRoots == null)
				{
					r_MCleanupRoots = new(Type, "CleanupRoots", 0);
				}
				return r_MCleanupRoots;
			}
		}

		/// <summary>
		/// Void CopyFrom(UnityEngine.Event)
		/// </summary>
		protected RMethod r_MCopyFrom_Event;
		public virtual RMethod RMCopyFrom_Event
		{
			get
			{
				if(r_MCopyFrom_Event == null)
				{
					r_MCopyFrom_Event = new(this, "CopyFrom", 0, typeof(UnityEngine.Event));
				}
				return r_MCopyFrom_Event;
			}
		}

		/// <summary>
		/// UnityEngine.Event KeyboardEvent(System.String)
		/// </summary>
		protected static RMethod r_MKeyboardEvent_String;
		public static RMethod RMKeyboardEvent_String
		{
			get
			{
				if(r_MKeyboardEvent_String == null)
				{
					r_MKeyboardEvent_String = new(Type, "KeyboardEvent", 0, typeof(System.String));
				}
				return r_MKeyboardEvent_String;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_MGetHashCode;
		public virtual RMethod RMGetHashCode
		{
			get
			{
				if(r_MGetHashCode == null)
				{
					r_MGetHashCode = new(this, "GetHashCode", 0);
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_MEquals_Object;
		public virtual RMethod RMEquals_Object
		{
			get
			{
				if(r_MEquals_Object == null)
				{
					r_MEquals_Object = new(this, "Equals", 0, typeof(System.Object));
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_MToString;
		public virtual RMethod RMToString
		{
			get
			{
				if(r_MToString == null)
				{
					r_MToString = new(this, "ToString", 0);
				}
				return r_MToString;
			}
		}

		/// <summary>
		/// Void Use()
		/// </summary>
		protected RMethod r_MUse;
		public virtual RMethod RMUse
		{
			get
			{
				if(r_MUse == null)
				{
					r_MUse = new(this, "Use", 0);
				}
				return r_MUse;
			}
		}

		/// <summary>
		/// Void get_mousePosition_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Mget_mousePosition_Injected_Out_Vector2;
		public virtual RMethod RMget_mousePosition_Injected_Out_Vector2
		{
			get
			{
				if(r_Mget_mousePosition_Injected_Out_Vector2 == null)
				{
					r_Mget_mousePosition_Injected_Out_Vector2 = new(this, "get_mousePosition_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_Mget_mousePosition_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void set_mousePosition_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Mset_mousePosition_Injected_Ref_Vector2;
		public virtual RMethod RMset_mousePosition_Injected_Ref_Vector2
		{
			get
			{
				if(r_Mset_mousePosition_Injected_Ref_Vector2 == null)
				{
					r_Mset_mousePosition_Injected_Ref_Vector2 = new(this, "set_mousePosition_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_Mset_mousePosition_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void get_delta_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Mget_delta_Injected_Out_Vector2;
		public virtual RMethod RMget_delta_Injected_Out_Vector2
		{
			get
			{
				if(r_Mget_delta_Injected_Out_Vector2 == null)
				{
					r_Mget_delta_Injected_Out_Vector2 = new(this, "get_delta_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_Mget_delta_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void set_delta_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Mset_delta_Injected_Ref_Vector2;
		public virtual RMethod RMset_delta_Injected_Ref_Vector2
		{
			get
			{
				if(r_Mset_delta_Injected_Ref_Vector2 == null)
				{
					r_Mset_delta_Injected_Ref_Vector2 = new(this, "set_delta_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_Mset_delta_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void get_tilt_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Mget_tilt_Injected_Out_Vector2;
		public virtual RMethod RMget_tilt_Injected_Out_Vector2
		{
			get
			{
				if(r_Mget_tilt_Injected_Out_Vector2 == null)
				{
					r_Mget_tilt_Injected_Out_Vector2 = new(this, "get_tilt_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_Mget_tilt_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void set_tilt_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Mset_tilt_Injected_Ref_Vector2;
		public virtual RMethod RMset_tilt_Injected_Ref_Vector2
		{
			get
			{
				if(r_Mset_tilt_Injected_Ref_Vector2 == null)
				{
					r_Mset_tilt_Injected_Ref_Vector2 = new(this, "set_tilt_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
				}
				return r_Mset_tilt_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_MGetType;
		public virtual RMethod RMGetType
		{
			get
			{
				if(r_MGetType == null)
				{
					r_MGetType = new(this, "GetType", 0);
				}
				return r_MGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MMemberwiseClone;
		public virtual RMethod RMMemberwiseClone
		{
			get
			{
				if(r_MMemberwiseClone == null)
				{
					r_MMemberwiseClone = new(this, "MemberwiseClone", 0);
				}
				return r_MMemberwiseClone;
			}
		}


        public virtual void Internal_Use()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternal_Use.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr Internal_Create(System.Int32 @displayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayIndex};
            var ___result = RMInternal_Create_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public static void Internal_Destroy(System.IntPtr @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ptr};
            var ___result = RMInternal_Destroy_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr Internal_Copy(System.IntPtr @otherPtr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@otherPtr};
            var ___result = RMInternal_Copy_IntPtr.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public virtual UnityEngine.EventType GetTypeForControl(System.Int32 @controlID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@controlID};
            var ___result = RMGetTypeForControl_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.EventType>(___result);
        }


        public virtual void CopyFromPtr(System.IntPtr @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ptr};
            var ___result = RMCopyFromPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean PopEvent(UnityEngine.Event @outEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outEvent};
            var ___result = RMPopEvent_Event.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Int32 GetEventCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEventCount.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static void Internal_SetNativeEvent(System.IntPtr @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ptr};
            var ___result = RMInternal_SetNativeEvent_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_MakeMasterEventCurrent(System.Int32 @displayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayIndex};
            var ___result = RMInternal_MakeMasterEventCurrent_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 GetDoubleClickTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDoubleClickTime.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public static void CleanupRoots()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCleanupRoots.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyFrom(UnityEngine.Event @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMCopyFrom_Event.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Event KeyboardEvent(System.String @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMKeyboardEvent_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Event>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual void Use()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUse.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void get_mousePosition_Injected(out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_mousePosition_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			@ret = ReflectionUtils.Convert<UnityEngine.Vector2>(___parameters[0]);

            
        }


        public virtual void set_mousePosition_Injected(ref UnityEngine.Vector2 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_mousePosition_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<UnityEngine.Vector2>(___parameters[0]);

            
        }


        public virtual void get_delta_Injected(out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_delta_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			@ret = ReflectionUtils.Convert<UnityEngine.Vector2>(___parameters[0]);

            
        }


        public virtual void set_delta_Injected(ref UnityEngine.Vector2 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_delta_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<UnityEngine.Vector2>(___parameters[0]);

            
        }


        public virtual void get_tilt_Injected(out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_tilt_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			@ret = ReflectionUtils.Convert<UnityEngine.Vector2>(___parameters[0]);

            
        }


        public virtual void set_tilt_Injected(ref UnityEngine.Vector2 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_tilt_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<UnityEngine.Vector2>(___parameters[0]);

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
