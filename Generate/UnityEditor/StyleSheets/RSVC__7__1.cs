using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RStyleSheets
{
	/// <summary>
	/// UnityEditor.StyleSheets.SVC`1
	/// </summary>
    public partial class RSVC<T> : RMember //
    {

		/// <summary>
		/// T m_Value
		/// </summary>
		protected RField r_m_Value;
		public virtual RField Rm_Value
		{
			get
			{
				if(r_m_Value == null)
				{
					r_m_Value = new(this, "m_Value");
					r_m_Value.SetBelong(this.instance);
				}
				return r_m_Value;
			}
		}

		/// <summary>
		/// System.Int32 m_Key
		/// </summary>
		protected RField r_m_Key;
		public virtual RField Rm_Key
		{
			get
			{
				if(r_m_Key == null)
				{
					r_m_Key = new(this, "m_Key");
					r_m_Key.SetBelong(this.instance);
				}
				return r_m_Key;
			}
		}

		/// <summary>
		/// System.Int32 m_Prop
		/// </summary>
		protected RField r_m_Prop;
		public virtual RField Rm_Prop
		{
			get
			{
				if(r_m_Prop == null)
				{
					r_m_Prop = new(this, "m_Prop");
					r_m_Prop.SetBelong(this.instance);
				}
				return r_m_Prop;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState[] m_States
		/// </summary>
		protected RFieldArray<RField> r_m_States;
		public virtual RFieldArray<RField> Rm_States
		{
			get
			{
				if(r_m_States == null)
				{
					r_m_States = new(this, "m_States");
					r_m_States.SetBelong(this.instance);
				}
				return r_m_States;
			}
		}

		/// <summary>
		/// System.Boolean m_Initialized
		/// </summary>
		protected RField r_m_Initialized;
		public virtual RField Rm_Initialized
		{
			get
			{
				if(r_m_Initialized == null)
				{
					r_m_Initialized = new(this, "m_Initialized");
					r_m_Initialized.SetBelong(this.instance);
				}
				return r_m_Initialized;
			}
		}

		/// <summary>
		/// System.Func`1[T] m_LateInitHandler
		/// </summary>
		protected RSystem.RFunc<RField> r_m_LateInitHandler;
		public virtual RSystem.RFunc<RField> Rm_LateInitHandler
		{
			get
			{
				if(r_m_LateInitHandler == null)
				{
					r_m_LateInitHandler = new(this, "m_LateInitHandler");
					r_m_LateInitHandler.SetBelong(this.instance);
				}
				return r_m_LateInitHandler;
			}
		}

		/// <summary>
		/// T value
		/// </summary>
		protected RProperty r_value;
		public virtual RProperty Rvalue
		{
			get
			{
				if(r_value == null)
				{
					r_value = new(this, "value", -1);
					r_value.SetBelong(this.instance);
				}
				return r_value;
			}
		}

		/// <summary>
		/// T op_Implicit(UnityEditor.StyleSheets.SVC`1[T])
		/// </summary>
		protected static RMethod r_Rop_Implicit_SVC_d_T_p_;
		public static RMethod Rop_Implicit_SVC_d_T_p_
		{
			get
			{
				if(r_Rop_Implicit_SVC_d_T_p_ == null)
				{
					r_Rop_Implicit_SVC_d_T_p_ = new( ReleactionUtils.GetType("UnityEditor.StyleSheets.SVC`1"), "op_Implicit", 0,  ReleactionUtils.GetType("UnityEditor.StyleSheets.SVC`1"));
					r_Rop_Implicit_SVC_d_T_p_.SetBelong(null);
				}
				return r_Rop_Implicit_SVC_d_T_p_;
			}
		}

		/// <summary>
		/// T ReadValue(T)
		/// </summary>
		protected RMethod r_RReadValue_T;
		public virtual RMethod RReadValue_T
		{
			get
			{
				if(r_RReadValue_T == null)
				{
					r_RReadValue_T = new(this, "ReadValue", 0, Type.MakeGenericMethodParameter(0));
					r_RReadValue_T.SetBelong(this.instance);
				}
				return r_RReadValue_T;
			}
		}

		/// <summary>
		/// T <.ctor>b__6_0()
		/// </summary>
		protected RMethod r_R__1____0__ctor__2__b__6_0;
		public virtual RMethod R__1____0__ctor__2__b__6_0
		{
			get
			{
				if(r_R__1____0__ctor__2__b__6_0 == null)
				{
					r_R__1____0__ctor__2__b__6_0 = new(this, "<.ctor>b__6_0", 0);
					r_R__1____0__ctor__2__b__6_0.SetBelong(this.instance);
				}
				return r_R__1____0__ctor__2__b__6_0;
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


        public virtual T ReadValue(T  @defaultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@defaultValue};
            var ___result = RReadValue_T.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T __1____0__ctor__2__b__6_0()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__1____0__ctor__2__b__6_0.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
