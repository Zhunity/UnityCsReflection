
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.TouchScreenKeyboard
	/// </summary>
    public partial class RTouchScreenKeyboard : RMember //
    {

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
					r_Fm_Ptr.SetBelong(this.instance);
				}
				return r_Fm_Ptr;
			}
		}

		/// <summary>
		/// System.Boolean <disableInPlaceEditing>k__BackingField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__disableInPlaceEditing__1__k__BackingField;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__disableInPlaceEditing__1__k__BackingField
		{
			get
			{
				if(r_F__0__disableInPlaceEditing__1__k__BackingField == null)
				{
					r_F__0__disableInPlaceEditing__1__k__BackingField = new(typeof(UnityEngine.TouchScreenKeyboard), "<disableInPlaceEditing>k__BackingField");
					r_F__0__disableInPlaceEditing__1__k__BackingField.SetBelong(null);
				}
				return r_F__0__disableInPlaceEditing__1__k__BackingField;
			}
		}

		/// <summary>
		/// Boolean isSupported
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_PisSupported;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RPisSupported
		{
			get
			{
				if(r_PisSupported == null)
				{
					r_PisSupported = new(typeof(UnityEngine.TouchScreenKeyboard), "isSupported", -1);
					r_PisSupported.SetBelong(null);
				}
				return r_PisSupported;
			}
		}

		/// <summary>
		/// Boolean disableInPlaceEditing
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_PdisableInPlaceEditing;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RPdisableInPlaceEditing
		{
			get
			{
				if(r_PdisableInPlaceEditing == null)
				{
					r_PdisableInPlaceEditing = new(typeof(UnityEngine.TouchScreenKeyboard), "disableInPlaceEditing", -1);
					r_PdisableInPlaceEditing.SetBelong(null);
				}
				return r_PdisableInPlaceEditing;
			}
		}

		/// <summary>
		/// Boolean isInPlaceEditingAllowed
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_PisInPlaceEditingAllowed;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RPisInPlaceEditingAllowed
		{
			get
			{
				if(r_PisInPlaceEditingAllowed == null)
				{
					r_PisInPlaceEditingAllowed = new(typeof(UnityEngine.TouchScreenKeyboard), "isInPlaceEditingAllowed", -1);
					r_PisInPlaceEditingAllowed.SetBelong(null);
				}
				return r_PisInPlaceEditingAllowed;
			}
		}

		/// <summary>
		/// Boolean isRequiredToForceOpen
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_PisRequiredToForceOpen;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RPisRequiredToForceOpen
		{
			get
			{
				if(r_PisRequiredToForceOpen == null)
				{
					r_PisRequiredToForceOpen = new(typeof(UnityEngine.TouchScreenKeyboard), "isRequiredToForceOpen", -1);
					r_PisRequiredToForceOpen.SetBelong(null);
				}
				return r_PisRequiredToForceOpen;
			}
		}

		/// <summary>
		/// System.String text
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ptext;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtext
		{
			get
			{
				if(r_Ptext == null)
				{
					r_Ptext = new(this, "text", -1);
					r_Ptext.SetBelong(this.instance);
				}
				return r_Ptext;
			}
		}

		/// <summary>
		/// Boolean hideInput
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_PhideInput;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RPhideInput
		{
			get
			{
				if(r_PhideInput == null)
				{
					r_PhideInput = new(typeof(UnityEngine.TouchScreenKeyboard), "hideInput", -1);
					r_PhideInput.SetBelong(null);
				}
				return r_PhideInput;
			}
		}

		/// <summary>
		/// Boolean active
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pactive;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPactive
		{
			get
			{
				if(r_Pactive == null)
				{
					r_Pactive = new(this, "active", -1);
					r_Pactive.SetBelong(this.instance);
				}
				return r_Pactive;
			}
		}

		/// <summary>
		/// Boolean done
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pdone;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdone
		{
			get
			{
				if(r_Pdone == null)
				{
					r_Pdone = new(this, "done", -1);
					r_Pdone.SetBelong(this.instance);
				}
				return r_Pdone;
			}
		}

		/// <summary>
		/// Boolean wasCanceled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PwasCanceled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPwasCanceled
		{
			get
			{
				if(r_PwasCanceled == null)
				{
					r_PwasCanceled = new(this, "wasCanceled", -1);
					r_PwasCanceled.SetBelong(this.instance);
				}
				return r_PwasCanceled;
			}
		}

		/// <summary>
		/// Status status
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboard.RStatus r_Pstatus;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboard.RStatus RPstatus
		{
			get
			{
				if(r_Pstatus == null)
				{
					r_Pstatus = new(this, "status", -1);
					r_Pstatus.SetBelong(this.instance);
				}
				return r_Pstatus;
			}
		}

		/// <summary>
		/// Int32 characterLimit
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PcharacterLimit;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPcharacterLimit
		{
			get
			{
				if(r_PcharacterLimit == null)
				{
					r_PcharacterLimit = new(this, "characterLimit", -1);
					r_PcharacterLimit.SetBelong(this.instance);
				}
				return r_PcharacterLimit;
			}
		}

		/// <summary>
		/// Boolean canGetSelection
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PcanGetSelection;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPcanGetSelection
		{
			get
			{
				if(r_PcanGetSelection == null)
				{
					r_PcanGetSelection = new(this, "canGetSelection", -1);
					r_PcanGetSelection.SetBelong(this.instance);
				}
				return r_PcanGetSelection;
			}
		}

		/// <summary>
		/// Boolean canSetSelection
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PcanSetSelection;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPcanSetSelection
		{
			get
			{
				if(r_PcanSetSelection == null)
				{
					r_PcanSetSelection = new(this, "canSetSelection", -1);
					r_PcanSetSelection.SetBelong(this.instance);
				}
				return r_PcanSetSelection;
			}
		}

		/// <summary>
		/// UnityEngine.RangeInt selection
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRangeInt r_Pselection;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRangeInt RPselection
		{
			get
			{
				if(r_Pselection == null)
				{
					r_Pselection = new(this, "selection", -1);
					r_Pselection.SetBelong(this.instance);
				}
				return r_Pselection;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboardType type
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType r_Ptype;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboardType RPtype
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
		/// Int32 targetDisplay
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PtargetDisplay;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPtargetDisplay
		{
			get
			{
				if(r_PtargetDisplay == null)
				{
					r_PtargetDisplay = new(this, "targetDisplay", -1);
					r_PtargetDisplay.SetBelong(this.instance);
				}
				return r_PtargetDisplay;
			}
		}

		/// <summary>
		/// UnityEngine.Rect area
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRect r_Parea;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRect RParea
		{
			get
			{
				if(r_Parea == null)
				{
					r_Parea = new(typeof(UnityEngine.TouchScreenKeyboard), "area", -1);
					r_Parea.SetBelong(null);
				}
				return r_Parea;
			}
		}

		/// <summary>
		/// Boolean visible
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_Pvisible;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RPvisible
		{
			get
			{
				if(r_Pvisible == null)
				{
					r_Pvisible = new(typeof(UnityEngine.TouchScreenKeyboard), "visible", -1);
					r_Pvisible.SetBelong(null);
				}
				return r_Pvisible;
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
					r_MInternal_Destroy_IntPtr = new(typeof(UnityEngine.TouchScreenKeyboard), "Internal_Destroy", 0, typeof(System.IntPtr));
					r_MInternal_Destroy_IntPtr.SetBelong(null);
				}
				return r_MInternal_Destroy_IntPtr;
			}
		}

		/// <summary>
		/// Void Destroy()
		/// </summary>
		protected RMethod r_MDestroy;
		public virtual RMethod RMDestroy
		{
			get
			{
				if(r_MDestroy == null)
				{
					r_MDestroy = new(this, "Destroy", 0);
					r_MDestroy.SetBelong(this.instance);
				}
				return r_MDestroy;
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
		/// IntPtr TouchScreenKeyboard_InternalConstructorHelper(UnityEngine.TouchScreenKeyboard_InternalConstructorHelperArguments ByRef, System.String, System.String)
		/// </summary>
		protected static RMethod r_MTouchScreenKeyboard_InternalConstructorHelper_Ref_TouchScreenKeyboard_InternalConstructorHelperArguments_String_String;
		public static RMethod RMTouchScreenKeyboard_InternalConstructorHelper_Ref_TouchScreenKeyboard_InternalConstructorHelperArguments_String_String
		{
			get
			{
				if(r_MTouchScreenKeyboard_InternalConstructorHelper_Ref_TouchScreenKeyboard_InternalConstructorHelperArguments_String_String == null)
				{
					r_MTouchScreenKeyboard_InternalConstructorHelper_Ref_TouchScreenKeyboard_InternalConstructorHelperArguments_String_String = new(typeof(UnityEngine.TouchScreenKeyboard), "TouchScreenKeyboard_InternalConstructorHelper", 0,  ReflectionUtils.GetType("UnityEngine.TouchScreenKeyboard_InternalConstructorHelperArguments").MakeByRefType(), typeof(System.String), typeof(System.String));
					r_MTouchScreenKeyboard_InternalConstructorHelper_Ref_TouchScreenKeyboard_InternalConstructorHelperArguments_String_String.SetBelong(null);
				}
				return r_MTouchScreenKeyboard_InternalConstructorHelper_Ref_TouchScreenKeyboard_InternalConstructorHelperArguments_String_String;
			}
		}

		/// <summary>
		/// Boolean IsRequiredToForceOpen()
		/// </summary>
		protected static RMethod r_MIsRequiredToForceOpen;
		public static RMethod RMIsRequiredToForceOpen
		{
			get
			{
				if(r_MIsRequiredToForceOpen == null)
				{
					r_MIsRequiredToForceOpen = new(typeof(UnityEngine.TouchScreenKeyboard), "IsRequiredToForceOpen", 0);
					r_MIsRequiredToForceOpen.SetBelong(null);
				}
				return r_MIsRequiredToForceOpen;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboard Open(System.String, UnityEngine.TouchScreenKeyboardType, Boolean, Boolean, Boolean, Boolean, System.String, Int32)
		/// </summary>
		protected static RMethod r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32;
		public static RMethod RMOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32
		{
			get
			{
				if(r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32 == null)
				{
					r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32 = new(typeof(UnityEngine.TouchScreenKeyboard), "Open", 0, typeof(System.String), typeof(UnityEngine.TouchScreenKeyboardType), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.String), typeof(System.Int32));
					r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32.SetBelong(null);
				}
				return r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboard Open(System.String, UnityEngine.TouchScreenKeyboardType, Boolean, Boolean, Boolean, Boolean, System.String)
		/// </summary>
		protected static RMethod r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String;
		public static RMethod RMOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String
		{
			get
			{
				if(r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String == null)
				{
					r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String = new(typeof(UnityEngine.TouchScreenKeyboard), "Open", 0, typeof(System.String), typeof(UnityEngine.TouchScreenKeyboardType), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.String));
					r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String.SetBelong(null);
				}
				return r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboard Open(System.String, UnityEngine.TouchScreenKeyboardType, Boolean, Boolean, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean;
		public static RMethod RMOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean == null)
				{
					r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean = new(typeof(UnityEngine.TouchScreenKeyboard), "Open", 0, typeof(System.String), typeof(UnityEngine.TouchScreenKeyboardType), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean.SetBelong(null);
				}
				return r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboard Open(System.String, UnityEngine.TouchScreenKeyboardType, Boolean, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean;
		public static RMethod RMOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean
		{
			get
			{
				if(r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean == null)
				{
					r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean = new(typeof(UnityEngine.TouchScreenKeyboard), "Open", 0, typeof(System.String), typeof(UnityEngine.TouchScreenKeyboardType), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean));
					r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean.SetBelong(null);
				}
				return r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboard Open(System.String, UnityEngine.TouchScreenKeyboardType, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean;
		public static RMethod RMOpen_String_TouchScreenKeyboardType_Boolean_Boolean
		{
			get
			{
				if(r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean == null)
				{
					r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean = new(typeof(UnityEngine.TouchScreenKeyboard), "Open", 0, typeof(System.String), typeof(UnityEngine.TouchScreenKeyboardType), typeof(System.Boolean), typeof(System.Boolean));
					r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean.SetBelong(null);
				}
				return r_MOpen_String_TouchScreenKeyboardType_Boolean_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboard Open(System.String, UnityEngine.TouchScreenKeyboardType, Boolean)
		/// </summary>
		protected static RMethod r_MOpen_String_TouchScreenKeyboardType_Boolean;
		public static RMethod RMOpen_String_TouchScreenKeyboardType_Boolean
		{
			get
			{
				if(r_MOpen_String_TouchScreenKeyboardType_Boolean == null)
				{
					r_MOpen_String_TouchScreenKeyboardType_Boolean = new(typeof(UnityEngine.TouchScreenKeyboard), "Open", 0, typeof(System.String), typeof(UnityEngine.TouchScreenKeyboardType), typeof(System.Boolean));
					r_MOpen_String_TouchScreenKeyboardType_Boolean.SetBelong(null);
				}
				return r_MOpen_String_TouchScreenKeyboardType_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboard Open(System.String, UnityEngine.TouchScreenKeyboardType)
		/// </summary>
		protected static RMethod r_MOpen_String_TouchScreenKeyboardType;
		public static RMethod RMOpen_String_TouchScreenKeyboardType
		{
			get
			{
				if(r_MOpen_String_TouchScreenKeyboardType == null)
				{
					r_MOpen_String_TouchScreenKeyboardType = new(typeof(UnityEngine.TouchScreenKeyboard), "Open", 0, typeof(System.String), typeof(UnityEngine.TouchScreenKeyboardType));
					r_MOpen_String_TouchScreenKeyboardType.SetBelong(null);
				}
				return r_MOpen_String_TouchScreenKeyboardType;
			}
		}

		/// <summary>
		/// UnityEngine.TouchScreenKeyboard Open(System.String)
		/// </summary>
		protected static RMethod r_MOpen_String;
		public static RMethod RMOpen_String
		{
			get
			{
				if(r_MOpen_String == null)
				{
					r_MOpen_String = new(typeof(UnityEngine.TouchScreenKeyboard), "Open", 0, typeof(System.String));
					r_MOpen_String.SetBelong(null);
				}
				return r_MOpen_String;
			}
		}

		/// <summary>
		/// Boolean GetDone(IntPtr)
		/// </summary>
		protected static RMethod r_MGetDone_IntPtr;
		public static RMethod RMGetDone_IntPtr
		{
			get
			{
				if(r_MGetDone_IntPtr == null)
				{
					r_MGetDone_IntPtr = new(typeof(UnityEngine.TouchScreenKeyboard), "GetDone", 0, typeof(System.IntPtr));
					r_MGetDone_IntPtr.SetBelong(null);
				}
				return r_MGetDone_IntPtr;
			}
		}

		/// <summary>
		/// Boolean GetWasCanceled(IntPtr)
		/// </summary>
		protected static RMethod r_MGetWasCanceled_IntPtr;
		public static RMethod RMGetWasCanceled_IntPtr
		{
			get
			{
				if(r_MGetWasCanceled_IntPtr == null)
				{
					r_MGetWasCanceled_IntPtr = new(typeof(UnityEngine.TouchScreenKeyboard), "GetWasCanceled", 0, typeof(System.IntPtr));
					r_MGetWasCanceled_IntPtr.SetBelong(null);
				}
				return r_MGetWasCanceled_IntPtr;
			}
		}

		/// <summary>
		/// Void GetSelection(Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected static RMethod r_MGetSelection_Out_Int32_Out_Int32;
		public static RMethod RMGetSelection_Out_Int32_Out_Int32
		{
			get
			{
				if(r_MGetSelection_Out_Int32_Out_Int32 == null)
				{
					r_MGetSelection_Out_Int32_Out_Int32 = new(typeof(UnityEngine.TouchScreenKeyboard), "GetSelection", 0, typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_MGetSelection_Out_Int32_Out_Int32.SetBelong(null);
				}
				return r_MGetSelection_Out_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Void SetSelection(Int32, Int32)
		/// </summary>
		protected static RMethod r_MSetSelection_Int32_Int32;
		public static RMethod RMSetSelection_Int32_Int32
		{
			get
			{
				if(r_MSetSelection_Int32_Int32 == null)
				{
					r_MSetSelection_Int32_Int32 = new(typeof(UnityEngine.TouchScreenKeyboard), "SetSelection", 0, typeof(System.Int32), typeof(System.Int32));
					r_MSetSelection_Int32_Int32.SetBelong(null);
				}
				return r_MSetSelection_Int32_Int32;
			}
		}

		/// <summary>
		/// Void get_area_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected static RMethod r_Mget_area_Injected_Out_Rect;
		public static RMethod RMget_area_Injected_Out_Rect
		{
			get
			{
				if(r_Mget_area_Injected_Out_Rect == null)
				{
					r_Mget_area_Injected_Out_Rect = new(typeof(UnityEngine.TouchScreenKeyboard), "get_area_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_Mget_area_Injected_Out_Rect.SetBelong(null);
				}
				return r_Mget_area_Injected_Out_Rect;
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


        public RTouchScreenKeyboard() : base("UnityEngine.TouchScreenKeyboard")
        {
        }

        public RTouchScreenKeyboard(System.Object instance) : base("UnityEngine.TouchScreenKeyboard")
		{
            SetInstance(instance);
		}

        public RTouchScreenKeyboard(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTouchScreenKeyboard(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void Internal_Destroy(System.IntPtr @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ptr};
            var ___result = RMInternal_Destroy_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Destroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDestroy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboard_InternalConstructorHelperArguments @arguments, System.String @text, System.String @textPlaceholder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arguments.Value, @text, @textPlaceholder};
            var ___result = RMTouchScreenKeyboard_InternalConstructorHelper_Ref_TouchScreenKeyboard_InternalConstructorHelperArguments_String_String.Invoke(___genericsType, ___parameters);
			@arguments = new Hvak.Editor.Refleaction.RUnityEngine.RTouchScreenKeyboard_InternalConstructorHelperArguments(___parameters[0]);

            return (System.IntPtr)___result;
        }


        public static System.Boolean IsRequiredToForceOpen()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsRequiredToForceOpen.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.TouchScreenKeyboard Open(System.String @text, UnityEngine.TouchScreenKeyboardType @keyboardType, System.Boolean @autocorrection, System.Boolean @multiline, System.Boolean @secure, System.Boolean @alert, System.String @textPlaceholder, System.Int32 @characterLimit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @keyboardType, @autocorrection, @multiline, @secure, @alert, @textPlaceholder, @characterLimit};
            var ___result = RMOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TouchScreenKeyboard)___result;
        }


        public static UnityEngine.TouchScreenKeyboard Open(System.String @text, UnityEngine.TouchScreenKeyboardType @keyboardType, System.Boolean @autocorrection, System.Boolean @multiline, System.Boolean @secure, System.Boolean @alert, System.String @textPlaceholder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @keyboardType, @autocorrection, @multiline, @secure, @alert, @textPlaceholder};
            var ___result = RMOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TouchScreenKeyboard)___result;
        }


        public static UnityEngine.TouchScreenKeyboard Open(System.String @text, UnityEngine.TouchScreenKeyboardType @keyboardType, System.Boolean @autocorrection, System.Boolean @multiline, System.Boolean @secure, System.Boolean @alert)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @keyboardType, @autocorrection, @multiline, @secure, @alert};
            var ___result = RMOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TouchScreenKeyboard)___result;
        }


        public static UnityEngine.TouchScreenKeyboard Open(System.String @text, UnityEngine.TouchScreenKeyboardType @keyboardType, System.Boolean @autocorrection, System.Boolean @multiline, System.Boolean @secure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @keyboardType, @autocorrection, @multiline, @secure};
            var ___result = RMOpen_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TouchScreenKeyboard)___result;
        }


        public static UnityEngine.TouchScreenKeyboard Open(System.String @text, UnityEngine.TouchScreenKeyboardType @keyboardType, System.Boolean @autocorrection, System.Boolean @multiline)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @keyboardType, @autocorrection, @multiline};
            var ___result = RMOpen_String_TouchScreenKeyboardType_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TouchScreenKeyboard)___result;
        }


        public static UnityEngine.TouchScreenKeyboard Open(System.String @text, UnityEngine.TouchScreenKeyboardType @keyboardType, System.Boolean @autocorrection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @keyboardType, @autocorrection};
            var ___result = RMOpen_String_TouchScreenKeyboardType_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TouchScreenKeyboard)___result;
        }


        public static UnityEngine.TouchScreenKeyboard Open(System.String @text, UnityEngine.TouchScreenKeyboardType @keyboardType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @keyboardType};
            var ___result = RMOpen_String_TouchScreenKeyboardType.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TouchScreenKeyboard)___result;
        }


        public static UnityEngine.TouchScreenKeyboard Open(System.String @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RMOpen_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.TouchScreenKeyboard)___result;
        }


        public static System.Boolean GetDone(System.IntPtr @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ptr};
            var ___result = RMGetDone_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean GetWasCanceled(System.IntPtr @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ptr};
            var ___result = RMGetWasCanceled_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void GetSelection(out System.Int32 @start, out System.Int32 @length)
        {
			@start = default;
			@length = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @length};
            var ___result = RMGetSelection_Out_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			@start = (System.Int32)___parameters[0];
			@length = (System.Int32)___parameters[1];

            
        }


        public static void SetSelection(System.Int32 @start, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@start, @length};
            var ___result = RMSetSelection_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void get_area_Injected(out UnityEngine.Rect @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_area_Injected_Out_Rect.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
