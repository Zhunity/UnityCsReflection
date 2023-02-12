
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
		protected SMFrame.Editor.Refleaction.RSystem.RIntPtr r_Fm_Ptr;
		public virtual SMFrame.Editor.Refleaction.RSystem.RIntPtr RFm_Ptr
		{
			get
			{
				if(r_Fm_Ptr == null)
				{
					r_Fm_Ptr = new(this, "m_Ptr");
					r_Fm_Ptr.SetBelong(this.instance);
				}
				return r_Fm_Ptr;
			}
		}

		/// <summary>
		/// UnityEngine.Event s_Current
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.REvent r_Fs_Current;
		public static SMFrame.Editor.Refleaction.RUnityEngine.REvent RFs_Current
		{
			get
			{
				if(r_Fs_Current == null)
				{
					r_Fs_Current = new(typeof(UnityEngine.Event), "s_Current");
					r_Fs_Current.SetBelong(null);
				}
				return r_Fs_Current;
			}
		}

		/// <summary>
		/// UnityEngine.Event s_MasterEvent
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.REvent r_Fs_MasterEvent;
		public static SMFrame.Editor.Refleaction.RUnityEngine.REvent RFs_MasterEvent
		{
			get
			{
				if(r_Fs_MasterEvent == null)
				{
					r_Fs_MasterEvent = new(typeof(UnityEngine.Event), "s_MasterEvent");
					r_Fs_MasterEvent.SetBelong(null);
				}
				return r_Fs_MasterEvent;
			}
		}

		/// <summary>
		/// UnityEngine.EventType rawType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.REventType r_PrawType;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.REventType RPrawType
		{
			get
			{
				if(r_PrawType == null)
				{
					r_PrawType = new(this, "rawType", -1);
					r_PrawType.SetBelong(this.instance);
				}
				return r_PrawType;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 mousePosition
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector2 r_PmousePosition;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector2 RPmousePosition
		{
			get
			{
				if(r_PmousePosition == null)
				{
					r_PmousePosition = new(this, "mousePosition", -1);
					r_PmousePosition.SetBelong(this.instance);
				}
				return r_PmousePosition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 delta
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector2 r_Pdelta;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector2 RPdelta
		{
			get
			{
				if(r_Pdelta == null)
				{
					r_Pdelta = new(this, "delta", -1);
					r_Pdelta.SetBelong(this.instance);
				}
				return r_Pdelta;
			}
		}

		/// <summary>
		/// UnityEngine.PointerType pointerType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RPointerType r_PpointerType;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RPointerType RPpointerType
		{
			get
			{
				if(r_PpointerType == null)
				{
					r_PpointerType = new(this, "pointerType", -1);
					r_PpointerType.SetBelong(this.instance);
				}
				return r_PpointerType;
			}
		}

		/// <summary>
		/// Int32 button
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Pbutton;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPbutton
		{
			get
			{
				if(r_Pbutton == null)
				{
					r_Pbutton = new(this, "button", -1);
					r_Pbutton.SetBelong(this.instance);
				}
				return r_Pbutton;
			}
		}

		/// <summary>
		/// UnityEngine.EventModifiers modifiers
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.REventModifiers r_Pmodifiers;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.REventModifiers RPmodifiers
		{
			get
			{
				if(r_Pmodifiers == null)
				{
					r_Pmodifiers = new(this, "modifiers", -1);
					r_Pmodifiers.SetBelong(this.instance);
				}
				return r_Pmodifiers;
			}
		}

		/// <summary>
		/// Single pressure
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_Ppressure;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RPpressure
		{
			get
			{
				if(r_Ppressure == null)
				{
					r_Ppressure = new(this, "pressure", -1);
					r_Ppressure.SetBelong(this.instance);
				}
				return r_Ppressure;
			}
		}

		/// <summary>
		/// Single twist
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_Ptwist;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RPtwist
		{
			get
			{
				if(r_Ptwist == null)
				{
					r_Ptwist = new(this, "twist", -1);
					r_Ptwist.SetBelong(this.instance);
				}
				return r_Ptwist;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 tilt
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector2 r_Ptilt;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector2 RPtilt
		{
			get
			{
				if(r_Ptilt == null)
				{
					r_Ptilt = new(this, "tilt", -1);
					r_Ptilt.SetBelong(this.instance);
				}
				return r_Ptilt;
			}
		}

		/// <summary>
		/// UnityEngine.PenStatus penStatus
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RPenStatus r_PpenStatus;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RPenStatus RPpenStatus
		{
			get
			{
				if(r_PpenStatus == null)
				{
					r_PpenStatus = new(this, "penStatus", -1);
					r_PpenStatus.SetBelong(this.instance);
				}
				return r_PpenStatus;
			}
		}

		/// <summary>
		/// Int32 clickCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PclickCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPclickCount
		{
			get
			{
				if(r_PclickCount == null)
				{
					r_PclickCount = new(this, "clickCount", -1);
					r_PclickCount.SetBelong(this.instance);
				}
				return r_PclickCount;
			}
		}

		/// <summary>
		/// Char character
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RChar r_Pcharacter;
		public virtual SMFrame.Editor.Refleaction.RSystem.RChar RPcharacter
		{
			get
			{
				if(r_Pcharacter == null)
				{
					r_Pcharacter = new(this, "character", -1);
					r_Pcharacter.SetBelong(this.instance);
				}
				return r_Pcharacter;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode keyCode
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RKeyCode r_PkeyCode;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RKeyCode RPkeyCode
		{
			get
			{
				if(r_PkeyCode == null)
				{
					r_PkeyCode = new(this, "keyCode", -1);
					r_PkeyCode.SetBelong(this.instance);
				}
				return r_PkeyCode;
			}
		}

		/// <summary>
		/// Int32 displayIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PdisplayIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPdisplayIndex
		{
			get
			{
				if(r_PdisplayIndex == null)
				{
					r_PdisplayIndex = new(this, "displayIndex", -1);
					r_PdisplayIndex.SetBelong(this.instance);
				}
				return r_PdisplayIndex;
			}
		}

		/// <summary>
		/// UnityEngine.EventType type
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.REventType r_Ptype;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.REventType RPtype
		{
			get
			{
				if(r_Ptype == null)
				{
					r_Ptype = new(this, "type", -1);
					r_Ptype.SetBelong(this.instance);
				}
				return r_Ptype;
			}
		}

		/// <summary>
		/// System.String commandName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PcommandName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPcommandName
		{
			get
			{
				if(r_PcommandName == null)
				{
					r_PcommandName = new(this, "commandName", -1);
					r_PcommandName.SetBelong(this.instance);
				}
				return r_PcommandName;
			}
		}

		/// <summary>
		/// UnityEngine.Ray mouseRay
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RRay r_PmouseRay;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RRay RPmouseRay
		{
			get
			{
				if(r_PmouseRay == null)
				{
					r_PmouseRay = new(this, "mouseRay", -1);
					r_PmouseRay.SetBelong(this.instance);
				}
				return r_PmouseRay;
			}
		}

		/// <summary>
		/// Boolean shift
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Pshift;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPshift
		{
			get
			{
				if(r_Pshift == null)
				{
					r_Pshift = new(this, "shift", -1);
					r_Pshift.SetBelong(this.instance);
				}
				return r_Pshift;
			}
		}

		/// <summary>
		/// Boolean control
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Pcontrol;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPcontrol
		{
			get
			{
				if(r_Pcontrol == null)
				{
					r_Pcontrol = new(this, "control", -1);
					r_Pcontrol.SetBelong(this.instance);
				}
				return r_Pcontrol;
			}
		}

		/// <summary>
		/// Boolean alt
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Palt;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPalt
		{
			get
			{
				if(r_Palt == null)
				{
					r_Palt = new(this, "alt", -1);
					r_Palt.SetBelong(this.instance);
				}
				return r_Palt;
			}
		}

		/// <summary>
		/// Boolean command
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Pcommand;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPcommand
		{
			get
			{
				if(r_Pcommand == null)
				{
					r_Pcommand = new(this, "command", -1);
					r_Pcommand.SetBelong(this.instance);
				}
				return r_Pcommand;
			}
		}

		/// <summary>
		/// Boolean capsLock
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PcapsLock;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPcapsLock
		{
			get
			{
				if(r_PcapsLock == null)
				{
					r_PcapsLock = new(this, "capsLock", -1);
					r_PcapsLock.SetBelong(this.instance);
				}
				return r_PcapsLock;
			}
		}

		/// <summary>
		/// Boolean numeric
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Pnumeric;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPnumeric
		{
			get
			{
				if(r_Pnumeric == null)
				{
					r_Pnumeric = new(this, "numeric", -1);
					r_Pnumeric.SetBelong(this.instance);
				}
				return r_Pnumeric;
			}
		}

		/// <summary>
		/// Boolean functionKey
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PfunctionKey;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPfunctionKey
		{
			get
			{
				if(r_PfunctionKey == null)
				{
					r_PfunctionKey = new(this, "functionKey", -1);
					r_PfunctionKey.SetBelong(this.instance);
				}
				return r_PfunctionKey;
			}
		}

		/// <summary>
		/// UnityEngine.Event current
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.REvent r_Pcurrent;
		public static SMFrame.Editor.Refleaction.RUnityEngine.REvent RPcurrent
		{
			get
			{
				if(r_Pcurrent == null)
				{
					r_Pcurrent = new(typeof(UnityEngine.Event), "current", -1);
					r_Pcurrent.SetBelong(null);
				}
				return r_Pcurrent;
			}
		}

		/// <summary>
		/// Boolean isKey
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisKey;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisKey
		{
			get
			{
				if(r_PisKey == null)
				{
					r_PisKey = new(this, "isKey", -1);
					r_PisKey.SetBelong(this.instance);
				}
				return r_PisKey;
			}
		}

		/// <summary>
		/// Boolean isMouse
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisMouse;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisMouse
		{
			get
			{
				if(r_PisMouse == null)
				{
					r_PisMouse = new(this, "isMouse", -1);
					r_PisMouse.SetBelong(this.instance);
				}
				return r_PisMouse;
			}
		}

		/// <summary>
		/// Boolean isScrollWheel
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisScrollWheel;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisScrollWheel
		{
			get
			{
				if(r_PisScrollWheel == null)
				{
					r_PisScrollWheel = new(this, "isScrollWheel", -1);
					r_PisScrollWheel.SetBelong(this.instance);
				}
				return r_PisScrollWheel;
			}
		}

		/// <summary>
		/// Boolean isDirectManipulationDevice
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisDirectManipulationDevice;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisDirectManipulationDevice
		{
			get
			{
				if(r_PisDirectManipulationDevice == null)
				{
					r_PisDirectManipulationDevice = new(this, "isDirectManipulationDevice", -1);
					r_PisDirectManipulationDevice.SetBelong(this.instance);
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
					r_MInternal_Use.SetBelong(this.instance);
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
					r_MInternal_Create_Int32 = new(typeof(UnityEngine.Event), "Internal_Create", 0, typeof(System.Int32));
					r_MInternal_Create_Int32.SetBelong(null);
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
					r_MInternal_Destroy_IntPtr = new(typeof(UnityEngine.Event), "Internal_Destroy", 0, typeof(System.IntPtr));
					r_MInternal_Destroy_IntPtr.SetBelong(null);
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
					r_MInternal_Copy_IntPtr = new(typeof(UnityEngine.Event), "Internal_Copy", 0, typeof(System.IntPtr));
					r_MInternal_Copy_IntPtr.SetBelong(null);
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
					r_MGetTypeForControl_Int32.SetBelong(this.instance);
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
					r_MCopyFromPtr_IntPtr.SetBelong(this.instance);
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
					r_MPopEvent_Event = new(typeof(UnityEngine.Event), "PopEvent", 0, typeof(UnityEngine.Event));
					r_MPopEvent_Event.SetBelong(null);
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
					r_MGetEventCount = new(typeof(UnityEngine.Event), "GetEventCount", 0);
					r_MGetEventCount.SetBelong(null);
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
					r_MInternal_SetNativeEvent_IntPtr = new(typeof(UnityEngine.Event), "Internal_SetNativeEvent", 0, typeof(System.IntPtr));
					r_MInternal_SetNativeEvent_IntPtr.SetBelong(null);
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
					r_MInternal_MakeMasterEventCurrent_Int32 = new(typeof(UnityEngine.Event), "Internal_MakeMasterEventCurrent", 0, typeof(System.Int32));
					r_MInternal_MakeMasterEventCurrent_Int32.SetBelong(null);
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
					r_MGetDoubleClickTime = new(typeof(UnityEngine.Event), "GetDoubleClickTime", 0);
					r_MGetDoubleClickTime.SetBelong(null);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MCleanupRoots = new(typeof(UnityEngine.Event), "CleanupRoots", 0);
					r_MCleanupRoots.SetBelong(null);
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
					r_MCopyFrom_Event.SetBelong(this.instance);
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
					r_MKeyboardEvent_String = new(typeof(UnityEngine.Event), "KeyboardEvent", 0, typeof(System.String));
					r_MKeyboardEvent_String.SetBelong(null);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
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
					r_MUse.SetBelong(this.instance);
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
					r_Mget_mousePosition_Injected_Out_Vector2.SetBelong(this.instance);
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
					r_Mset_mousePosition_Injected_Ref_Vector2.SetBelong(this.instance);
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
					r_Mget_delta_Injected_Out_Vector2.SetBelong(this.instance);
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
					r_Mset_delta_Injected_Ref_Vector2.SetBelong(this.instance);
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
					r_Mget_tilt_Injected_Out_Vector2.SetBelong(this.instance);
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
					r_Mset_tilt_Injected_Ref_Vector2.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
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
            var ___result = RMInternal_Use.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr Internal_Create(System.Int32 @displayIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayIndex};
            var ___result = RMInternal_Create_Int32.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
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

            return (System.IntPtr)___result;
        }


        public virtual UnityEngine.EventType GetTypeForControl(System.Int32 @controlID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@controlID};
            var ___result = RMGetTypeForControl_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.EventType)___result;
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

            return (System.Boolean)___result;
        }


        public static System.Int32 GetEventCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEventCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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

            return (System.Int32)___result;
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

            return (UnityEngine.Event)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
			@ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void set_mousePosition_Injected(ref UnityEngine.Vector2 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_mousePosition_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void get_delta_Injected(out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_delta_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void set_delta_Injected(ref UnityEngine.Vector2 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_delta_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void get_tilt_Injected(out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_tilt_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void set_tilt_Injected(ref UnityEngine.Vector2 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_tilt_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}