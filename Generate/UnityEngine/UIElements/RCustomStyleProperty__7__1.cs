using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.CustomStyleProperty`1
	/// </summary>
    public partial class RCustomStyleProperty<T> : RMember //
    {

		/// <summary>
		/// System.String <name>k__BackingField
		/// </summary>
		protected RField r___1__name__2__k__BackingField;
		public virtual RField R__1__name__2__k__BackingField
		{
			get
			{
				if(r___1__name__2__k__BackingField == null)
				{
					r___1__name__2__k__BackingField = new(this, "<name>k__BackingField");
					r___1__name__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__name__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
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
		/// Boolean Equals(UnityEngine.UIElements.CustomStyleProperty`1[T])
		/// </summary>
		protected RMethod r_REquals_CustomStyleProperty_d_T_p_;
		public virtual RMethod REquals_CustomStyleProperty_d_T_p_
		{
			get
			{
				if(r_REquals_CustomStyleProperty_d_T_p_ == null)
				{
					r_REquals_CustomStyleProperty_d_T_p_ = new(this, "Equals", 0, typeof(UnityEngine.UIElements.CustomStyleProperty<>));
					r_REquals_CustomStyleProperty_d_T_p_.SetBelong(this.instance);
				}
				return r_REquals_CustomStyleProperty_d_T_p_;
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
		/// Boolean op_Equality(UnityEngine.UIElements.CustomStyleProperty`1[T], UnityEngine.UIElements.CustomStyleProperty`1[T])
		/// </summary>
		protected static RMethod r_Rop_Equality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_;
		public static RMethod Rop_Equality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_
		{
			get
			{
				if(r_Rop_Equality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_ == null)
				{
					r_Rop_Equality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_ = new(typeof(UnityEngine.UIElements.CustomStyleProperty<>), "op_Equality", 0, typeof(UnityEngine.UIElements.CustomStyleProperty<>), typeof(UnityEngine.UIElements.CustomStyleProperty<>));
					r_Rop_Equality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_.SetBelong(null);
				}
				return r_Rop_Equality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.CustomStyleProperty`1[T], UnityEngine.UIElements.CustomStyleProperty`1[T])
		/// </summary>
		protected static RMethod r_Rop_Inequality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_;
		public static RMethod Rop_Inequality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_
		{
			get
			{
				if(r_Rop_Inequality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_ == null)
				{
					r_Rop_Inequality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_ = new(typeof(UnityEngine.UIElements.CustomStyleProperty<>), "op_Inequality", 0, typeof(UnityEngine.UIElements.CustomStyleProperty<>), typeof(UnityEngine.UIElements.CustomStyleProperty<>));
					r_Rop_Inequality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_.SetBelong(null);
				}
				return r_Rop_Inequality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_;
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


        public RCustomStyleProperty() : base("UnityEngine.UIElements.CustomStyleProperty`1")
        {
        }

        public RCustomStyleProperty(System.Object instance) : base("UnityEngine.UIElements.CustomStyleProperty`1")
		{
            SetInstance(instance);
		}

        public RCustomStyleProperty(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCustomStyleProperty(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.CustomStyleProperty<T>  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_CustomStyleProperty_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.CustomStyleProperty<T>  @a, UnityEngine.UIElements.CustomStyleProperty<T>  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Equality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.CustomStyleProperty<T>  @a, UnityEngine.UIElements.CustomStyleProperty<T>  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Inequality_CustomStyleProperty_d_T_p__CustomStyleProperty_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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
