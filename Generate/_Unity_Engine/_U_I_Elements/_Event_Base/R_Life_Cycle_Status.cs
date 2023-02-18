
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class REventBase
{
	
	/// <summary>
	/// UnityEngine.UIElements.EventBase+LifeCycleStatus
	/// </summary>
    public partial class RLifeCycleStatus : RMember //
    {

		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
					r_Fvalue__.SetBelong(this.GetValue());
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventBase+LifeCycleStatus None
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus r_FNone;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus RFNone
		{
			get
			{
				if(r_FNone == null)
				{
					r_FNone = new( ReflectionUtils.GetType("UnityEngine.UIElements.EventBase+LifeCycleStatus"), "None");
					r_FNone.SetBelong(null);
				}
				return r_FNone;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventBase+LifeCycleStatus PropagationStopped
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus r_FPropagationStopped;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus RFPropagationStopped
		{
			get
			{
				if(r_FPropagationStopped == null)
				{
					r_FPropagationStopped = new( ReflectionUtils.GetType("UnityEngine.UIElements.EventBase+LifeCycleStatus"), "PropagationStopped");
					r_FPropagationStopped.SetBelong(null);
				}
				return r_FPropagationStopped;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventBase+LifeCycleStatus ImmediatePropagationStopped
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus r_FImmediatePropagationStopped;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus RFImmediatePropagationStopped
		{
			get
			{
				if(r_FImmediatePropagationStopped == null)
				{
					r_FImmediatePropagationStopped = new( ReflectionUtils.GetType("UnityEngine.UIElements.EventBase+LifeCycleStatus"), "ImmediatePropagationStopped");
					r_FImmediatePropagationStopped.SetBelong(null);
				}
				return r_FImmediatePropagationStopped;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventBase+LifeCycleStatus DefaultPrevented
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus r_FDefaultPrevented;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus RFDefaultPrevented
		{
			get
			{
				if(r_FDefaultPrevented == null)
				{
					r_FDefaultPrevented = new( ReflectionUtils.GetType("UnityEngine.UIElements.EventBase+LifeCycleStatus"), "DefaultPrevented");
					r_FDefaultPrevented.SetBelong(null);
				}
				return r_FDefaultPrevented;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventBase+LifeCycleStatus Dispatching
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus r_FDispatching;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus RFDispatching
		{
			get
			{
				if(r_FDispatching == null)
				{
					r_FDispatching = new( ReflectionUtils.GetType("UnityEngine.UIElements.EventBase+LifeCycleStatus"), "Dispatching");
					r_FDispatching.SetBelong(null);
				}
				return r_FDispatching;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventBase+LifeCycleStatus Pooled
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus r_FPooled;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus RFPooled
		{
			get
			{
				if(r_FPooled == null)
				{
					r_FPooled = new( ReflectionUtils.GetType("UnityEngine.UIElements.EventBase+LifeCycleStatus"), "Pooled");
					r_FPooled.SetBelong(null);
				}
				return r_FPooled;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventBase+LifeCycleStatus IMGUIEventIsValid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus r_FIMGUIEventIsValid;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus RFIMGUIEventIsValid
		{
			get
			{
				if(r_FIMGUIEventIsValid == null)
				{
					r_FIMGUIEventIsValid = new( ReflectionUtils.GetType("UnityEngine.UIElements.EventBase+LifeCycleStatus"), "IMGUIEventIsValid");
					r_FIMGUIEventIsValid.SetBelong(null);
				}
				return r_FIMGUIEventIsValid;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventBase+LifeCycleStatus StopDispatch
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus r_FStopDispatch;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus RFStopDispatch
		{
			get
			{
				if(r_FStopDispatch == null)
				{
					r_FStopDispatch = new( ReflectionUtils.GetType("UnityEngine.UIElements.EventBase+LifeCycleStatus"), "StopDispatch");
					r_FStopDispatch.SetBelong(null);
				}
				return r_FStopDispatch;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventBase+LifeCycleStatus PropagateToIMGUI
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus r_FPropagateToIMGUI;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus RFPropagateToIMGUI
		{
			get
			{
				if(r_FPropagateToIMGUI == null)
				{
					r_FPropagateToIMGUI = new( ReflectionUtils.GetType("UnityEngine.UIElements.EventBase+LifeCycleStatus"), "PropagateToIMGUI");
					r_FPropagateToIMGUI.SetBelong(null);
				}
				return r_FPropagateToIMGUI;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventBase+LifeCycleStatus Dispatched
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus r_FDispatched;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus RFDispatched
		{
			get
			{
				if(r_FDispatched == null)
				{
					r_FDispatched = new( ReflectionUtils.GetType("UnityEngine.UIElements.EventBase+LifeCycleStatus"), "Dispatched");
					r_FDispatched.SetBelong(null);
				}
				return r_FDispatched;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventBase+LifeCycleStatus Processed
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus r_FProcessed;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus RFProcessed
		{
			get
			{
				if(r_FProcessed == null)
				{
					r_FProcessed = new( ReflectionUtils.GetType("UnityEngine.UIElements.EventBase+LifeCycleStatus"), "Processed");
					r_FProcessed.SetBelong(null);
				}
				return r_FProcessed;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventBase+LifeCycleStatus ProcessedByFocusController
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus r_FProcessedByFocusController;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase.RLifeCycleStatus RFProcessedByFocusController
		{
			get
			{
				if(r_FProcessedByFocusController == null)
				{
					r_FProcessedByFocusController = new( ReflectionUtils.GetType("UnityEngine.UIElements.EventBase+LifeCycleStatus"), "ProcessedByFocusController");
					r_FProcessedByFocusController.SetBelong(null);
				}
				return r_FProcessedByFocusController;
			}
		}

		/// <summary>
		/// System.Object GetValue()
		/// </summary>
		protected RMethod r_MGetValue;
		public virtual RMethod RMGetValue
		{
			get
			{
				if(r_MGetValue == null)
				{
					r_MGetValue = new(this, "GetValue", 0);
					r_MGetValue.SetBelong(this.GetValue());
				}
				return r_MGetValue;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
				}
				return r_MGetHashCode;
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
			}
		}

		/// <summary>
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_String_IFormatProvider;
		public virtual RMethod RMToString_String_IFormatProvider
		{
			get
			{
				if(r_MToString_String_IFormatProvider == null)
				{
					r_MToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_MToString_String_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
					r_MCompareTo_Object.SetBelong(this.GetValue());
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_MToString_String;
		public virtual RMethod RMToString_String
		{
			get
			{
				if(r_MToString_String == null)
				{
					r_MToString_String = new(this, "ToString", 0, typeof(System.String));
					r_MToString_String.SetBelong(this.GetValue());
				}
				return r_MToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_IFormatProvider;
		public virtual RMethod RMToString_IFormatProvider
		{
			get
			{
				if(r_MToString_IFormatProvider == null)
				{
					r_MToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
					r_MToString_IFormatProvider.SetBelong(this.GetValue());
				}
				return r_MToString_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean HasFlag(System.Enum)
		/// </summary>
		protected RMethod r_MHasFlag_Enum;
		public virtual RMethod RMHasFlag_Enum
		{
			get
			{
				if(r_MHasFlag_Enum == null)
				{
					r_MHasFlag_Enum = new(this, "HasFlag", 0, typeof(System.Enum));
					r_MHasFlag_Enum.SetBelong(this.GetValue());
				}
				return r_MHasFlag_Enum;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_MGetTypeCode;
		public virtual RMethod RMGetTypeCode
		{
			get
			{
				if(r_MGetTypeCode == null)
				{
					r_MGetTypeCode = new(this, "GetTypeCode", 0);
					r_MGetTypeCode.SetBelong(this.GetValue());
				}
				return r_MGetTypeCode;
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
					r_MFinalize.SetBelong(this.GetValue());
				}
				return r_MFinalize;
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
			}
		}


        public RLifeCycleStatus() : base("UnityEngine.UIElements.EventBase+LifeCycleStatus")
        {
        }

        public RLifeCycleStatus(System.Object instance) : base("UnityEngine.UIElements.EventBase+LifeCycleStatus")
		{
            SetInstance(instance);
		}

        public RLifeCycleStatus(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLifeCycleStatus(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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
}