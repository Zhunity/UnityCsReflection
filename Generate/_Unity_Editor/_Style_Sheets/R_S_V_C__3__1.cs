
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets
{
	/// <summary>
	/// UnityEditor.StyleSheets.SVC`1
	/// </summary>
    public partial class RSVC<T> : RMember //
    {

		/// <summary>
		/// T m_Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RField r_Fm_Value;
		public virtual Hvak.Editor.Refleaction.RField RFm_Value
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
		/// System.Int32 m_Key
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Key;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Key
		{
			get
			{
				if(r_Fm_Key == null)
				{
					r_Fm_Key = new(this, "m_Key");
				}
				return r_Fm_Key;
			}
		}

		/// <summary>
		/// System.Int32 m_Prop
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Prop;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Prop
		{
			get
			{
				if(r_Fm_Prop == null)
				{
					r_Fm_Prop = new(this, "m_Prop");
				}
				return r_Fm_Prop;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState[] m_States
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState> r_Fm_States;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState> RFm_States
		{
			get
			{
				if(r_Fm_States == null)
				{
					r_Fm_States = new(this, "m_States");
				}
				return r_Fm_States;
			}
		}

		/// <summary>
		/// System.Boolean m_Initialized
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_Initialized;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_Initialized
		{
			get
			{
				if(r_Fm_Initialized == null)
				{
					r_Fm_Initialized = new(this, "m_Initialized");
				}
				return r_Fm_Initialized;
			}
		}

		/// <summary>
		/// System.Func`1[T] m_LateInitHandler
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RField> r_Fm_LateInitHandler;
		public virtual Hvak.Editor.Refleaction.RSystem.RFunc<Hvak.Editor.Refleaction.RField> RFm_LateInitHandler
		{
			get
			{
				if(r_Fm_LateInitHandler == null)
				{
					r_Fm_LateInitHandler = new(this, "m_LateInitHandler");
				}
				return r_Fm_LateInitHandler;
			}
		}

		/// <summary>
		/// T value
		/// </summary>
		protected Hvak.Editor.Refleaction.RProperty r_Pvalue;
		public virtual Hvak.Editor.Refleaction.RProperty RPvalue
		{
			get
			{
				if(r_Pvalue == null)
				{
					r_Pvalue = new(this, "value", -1);
				}
				return r_Pvalue;
			}
		}

		/// <summary>
		/// T op_Implicit(UnityEditor.StyleSheets.SVC`1[T])
		/// </summary>
		protected static RMethod r_Mop_Implicit_SVC_d_T_p_;
		public static RMethod RMop_Implicit_SVC_d_T_p_
		{
			get
			{
				if(r_Mop_Implicit_SVC_d_T_p_ == null)
				{
					r_Mop_Implicit_SVC_d_T_p_ = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.SVC`1"), "op_Implicit", 0,  ReflectionUtils.GetType("UnityEditor.StyleSheets.SVC`1"));
				}
				return r_Mop_Implicit_SVC_d_T_p_;
			}
		}

		/// <summary>
		/// T ReadValue(T)
		/// </summary>
		protected RMethod r_MReadValue_T;
		public virtual RMethod RMReadValue_T
		{
			get
			{
				if(r_MReadValue_T == null)
				{
					r_MReadValue_T = new(this, "ReadValue", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MReadValue_T;
			}
		}

		/// <summary>
		/// T <.ctor>b__6_0()
		/// </summary>
		protected RMethod r_M__0____2__ctor__1__b__6_0;
		public virtual RMethod RM__0____2__ctor__1__b__6_0
		{
			get
			{
				if(r_M__0____2__ctor__1__b__6_0 == null)
				{
					r_M__0____2__ctor__1__b__6_0 = new(this, "<.ctor>b__6_0", 0);
				}
				return r_M__0____2__ctor__1__b__6_0;
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


        public RSVC() : base("UnityEditor.StyleSheets.SVC`1")
        {
        }

        public RSVC(System.Object instance) : base("UnityEditor.StyleSheets.SVC`1")
		{
            SetInstance(instance);
		}

        public RSVC(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSVC(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static T op_Implicit(Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RSVC<Hvak.Editor.Refleaction.RType> @sc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sc.Value};
            var ___result = RMop_Implicit_SVC_d_T_p_.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T ReadValue(T @defaultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@defaultValue};
            var ___result = RMReadValue_T.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T __0____2__ctor__1__b__6_0()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RM__0____2__ctor__1__b__6_0.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
