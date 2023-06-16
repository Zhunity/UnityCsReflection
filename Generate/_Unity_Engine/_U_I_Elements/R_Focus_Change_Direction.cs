
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.FocusChangeDirection
	/// </summary>
    public partial class RFocusChangeDirection : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.FocusChangeDirection);
            }
        }

        public RFocusChangeDirection() : base("UnityEngine.UIElements.FocusChangeDirection")
        {
        }

        public RFocusChangeDirection(System.Object instance) : base("UnityEngine.UIElements.FocusChangeDirection")
		{
            SetInstance(instance);
		}

        public RFocusChangeDirection(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFocusChangeDirection(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.UIElements.FocusChangeDirection <unspecified>k__BackingField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusChangeDirection r_F__0__unspecified__1__k__BackingField;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusChangeDirection RF__0__unspecified__1__k__BackingField
		{
			get
			{
				if(r_F__0__unspecified__1__k__BackingField == null)
				{
					r_F__0__unspecified__1__k__BackingField = new(Type, "<unspecified>k__BackingField");
				}
				return r_F__0__unspecified__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FocusChangeDirection <none>k__BackingField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusChangeDirection r_F__0__none__1__k__BackingField;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusChangeDirection RF__0__none__1__k__BackingField
		{
			get
			{
				if(r_F__0__none__1__k__BackingField == null)
				{
					r_F__0__none__1__k__BackingField = new(Type, "<none>k__BackingField");
				}
				return r_F__0__none__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FocusChangeDirection <lastValue>k__BackingField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusChangeDirection r_F__0__lastValue__1__k__BackingField;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusChangeDirection RF__0__lastValue__1__k__BackingField
		{
			get
			{
				if(r_F__0__lastValue__1__k__BackingField == null)
				{
					r_F__0__lastValue__1__k__BackingField = new(Type, "<lastValue>k__BackingField");
				}
				return r_F__0__lastValue__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 m_Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Value;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Value
		{
			get
			{
				if(r_Fm_Value == null)
				{
					r_Fm_Value = new(this, "m_Value");
				}
				return r_Fm_Value;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FocusChangeDirection unspecified
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusChangeDirection r_Punspecified;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusChangeDirection RPunspecified
		{
			get
			{
				if(r_Punspecified == null)
				{
					r_Punspecified = new(Type, "unspecified", -1);
				}
				return r_Punspecified;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FocusChangeDirection none
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusChangeDirection r_Pnone;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusChangeDirection RPnone
		{
			get
			{
				if(r_Pnone == null)
				{
					r_Pnone = new(Type, "none", -1);
				}
				return r_Pnone;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FocusChangeDirection lastValue
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusChangeDirection r_PlastValue;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusChangeDirection RPlastValue
		{
			get
			{
				if(r_PlastValue == null)
				{
					r_PlastValue = new(Type, "lastValue", -1);
				}
				return r_PlastValue;
			}
		}

		/// <summary>
		/// Int32 op_Implicit(UnityEngine.UIElements.FocusChangeDirection)
		/// </summary>
		protected static RMethod r_Mop_Implicit_FocusChangeDirection;
		public static RMethod RMop_Implicit_FocusChangeDirection
		{
			get
			{
				if(r_Mop_Implicit_FocusChangeDirection == null)
				{
					r_Mop_Implicit_FocusChangeDirection = new(Type, "op_Implicit", 0, typeof(UnityEngine.UIElements.FocusChangeDirection));
				}
				return r_Mop_Implicit_FocusChangeDirection;
			}
		}

		/// <summary>
		/// Void System.IDisposable.Dispose()
		/// </summary>
		protected RMethod r_MSystem__2__IDisposable__2__Dispose;
		public virtual RMethod RMSystem__2__IDisposable__2__Dispose
		{
			get
			{
				if(r_MSystem__2__IDisposable__2__Dispose == null)
				{
					r_MSystem__2__IDisposable__2__Dispose = new(this, "System.IDisposable.Dispose", 0);
				}
				return r_MSystem__2__IDisposable__2__Dispose;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void ApplyTo(UnityEngine.UIElements.FocusController, UnityEngine.UIElements.Focusable)
		/// </summary>
		protected RMethod r_MApplyTo_FocusController_Focusable;
		public virtual RMethod RMApplyTo_FocusController_Focusable
		{
			get
			{
				if(r_MApplyTo_FocusController_Focusable == null)
				{
					r_MApplyTo_FocusController_Focusable = new(this, "ApplyTo", 0, typeof(UnityEngine.UIElements.FocusController), typeof(UnityEngine.UIElements.Focusable));
				}
				return r_MApplyTo_FocusController_Focusable;
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


        public static System.Int32 op_Implicit(UnityEngine.UIElements.FocusChangeDirection @fcd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fcd};
            var ___result = RMop_Implicit_FocusChangeDirection.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void System__2__IDisposable__2__Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__IDisposable__2__Dispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyTo(UnityEngine.UIElements.FocusController @focusController, UnityEngine.UIElements.Focusable @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@focusController, @f};
            var ___result = RMApplyTo_FocusController_Focusable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
