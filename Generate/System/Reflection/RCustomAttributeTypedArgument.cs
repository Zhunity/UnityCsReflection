using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.CustomAttributeTypedArgument
	/// </summary>
    public partial class RCustomAttributeTypedArgument : RMember //
    {

		/// <summary>
		/// System.Type <ArgumentType>k__BackingField
		/// </summary>
		protected RSystem.RType r___1__ArgumentType__2__k__BackingField;
		public virtual RSystem.RType R__1__ArgumentType__2__k__BackingField
		{
			get
			{
				if(r___1__ArgumentType__2__k__BackingField == null)
				{
					r___1__ArgumentType__2__k__BackingField = new(this, "<ArgumentType>k__BackingField");
					r___1__ArgumentType__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__ArgumentType__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Object <Value>k__BackingField
		/// </summary>
		protected RSystem.RObject r___1__Value__2__k__BackingField;
		public virtual RSystem.RObject R__1__Value__2__k__BackingField
		{
			get
			{
				if(r___1__Value__2__k__BackingField == null)
				{
					r___1__Value__2__k__BackingField = new(this, "<Value>k__BackingField");
					r___1__Value__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__Value__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Type ArgumentType
		/// </summary>
		protected RSystem.RType r_ArgumentType;
		public virtual RSystem.RType RArgumentType
		{
			get
			{
				if(r_ArgumentType == null)
				{
					r_ArgumentType = new(this, "ArgumentType", -1);
					r_ArgumentType.SetBelong(this.instance);
				}
				return r_ArgumentType;
			}
		}

		/// <summary>
		/// System.Object Value
		/// </summary>
		protected RSystem.RObject r_Value;
		public virtual RSystem.RObject RValue
		{
			get
			{
				if(r_Value == null)
				{
					r_Value = new(this, "Value", -1);
					r_Value.SetBelong(this.instance);
				}
				return r_Value;
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
		/// Boolean op_Equality(System.Reflection.CustomAttributeTypedArgument, System.Reflection.CustomAttributeTypedArgument)
		/// </summary>
		protected static RMethod r_Rop_Equality_CustomAttributeTypedArgument_CustomAttributeTypedArgument;
		public static RMethod Rop_Equality_CustomAttributeTypedArgument_CustomAttributeTypedArgument
		{
			get
			{
				if(r_Rop_Equality_CustomAttributeTypedArgument_CustomAttributeTypedArgument == null)
				{
					r_Rop_Equality_CustomAttributeTypedArgument_CustomAttributeTypedArgument = new(typeof(System.Reflection.CustomAttributeTypedArgument), "op_Equality", 0, typeof(System.Reflection.CustomAttributeTypedArgument), typeof(System.Reflection.CustomAttributeTypedArgument));
					r_Rop_Equality_CustomAttributeTypedArgument_CustomAttributeTypedArgument.SetBelong(null);
				}
				return r_Rop_Equality_CustomAttributeTypedArgument_CustomAttributeTypedArgument;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.CustomAttributeTypedArgument, System.Reflection.CustomAttributeTypedArgument)
		/// </summary>
		protected static RMethod r_Rop_Inequality_CustomAttributeTypedArgument_CustomAttributeTypedArgument;
		public static RMethod Rop_Inequality_CustomAttributeTypedArgument_CustomAttributeTypedArgument
		{
			get
			{
				if(r_Rop_Inequality_CustomAttributeTypedArgument_CustomAttributeTypedArgument == null)
				{
					r_Rop_Inequality_CustomAttributeTypedArgument_CustomAttributeTypedArgument = new(typeof(System.Reflection.CustomAttributeTypedArgument), "op_Inequality", 0, typeof(System.Reflection.CustomAttributeTypedArgument), typeof(System.Reflection.CustomAttributeTypedArgument));
					r_Rop_Inequality_CustomAttributeTypedArgument_CustomAttributeTypedArgument.SetBelong(null);
				}
				return r_Rop_Inequality_CustomAttributeTypedArgument_CustomAttributeTypedArgument;
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
		/// System.String ToString(Boolean)
		/// </summary>
		protected RMethod r_RToString_Boolean;
		public virtual RMethod RToString_Boolean
		{
			get
			{
				if(r_RToString_Boolean == null)
				{
					r_RToString_Boolean = new(this, "ToString", 0, typeof(System.Boolean));
					r_RToString_Boolean.SetBelong(this.instance);
				}
				return r_RToString_Boolean;
			}
		}

		/// <summary>
		/// System.Object CanonicalizeValue(System.Object)
		/// </summary>
		protected static RMethod r_RCanonicalizeValue_Object;
		public static RMethod RCanonicalizeValue_Object
		{
			get
			{
				if(r_RCanonicalizeValue_Object == null)
				{
					r_RCanonicalizeValue_Object = new(typeof(System.Reflection.CustomAttributeTypedArgument), "CanonicalizeValue", 0, typeof(System.Object));
					r_RCanonicalizeValue_Object.SetBelong(null);
				}
				return r_RCanonicalizeValue_Object;
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


        public RCustomAttributeTypedArgument() : base("System.Reflection.CustomAttributeTypedArgument")
        {
        }

        public RCustomAttributeTypedArgument(System.Object instance) : base("System.Reflection.CustomAttributeTypedArgument")
		{
            SetInstance(instance);
		}

        public RCustomAttributeTypedArgument(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCustomAttributeTypedArgument(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(System.Reflection.CustomAttributeTypedArgument  @left, System.Reflection.CustomAttributeTypedArgument  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_CustomAttributeTypedArgument_CustomAttributeTypedArgument.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Reflection.CustomAttributeTypedArgument  @left, System.Reflection.CustomAttributeTypedArgument  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_CustomAttributeTypedArgument_CustomAttributeTypedArgument.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.Boolean  @typed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typed};
            var ___result = RToString_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Object CanonicalizeValue(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RCanonicalizeValue_Object.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
