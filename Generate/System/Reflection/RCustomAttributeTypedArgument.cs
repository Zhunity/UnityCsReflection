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
		protected RSystem.RType r_F__0__ArgumentType__1__k__BackingField;
		public virtual RSystem.RType RF__0__ArgumentType__1__k__BackingField
		{
			get
			{
				if(r_F__0__ArgumentType__1__k__BackingField == null)
				{
					r_F__0__ArgumentType__1__k__BackingField = new(this, "<ArgumentType>k__BackingField");
					r_F__0__ArgumentType__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__ArgumentType__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Object <Value>k__BackingField
		/// </summary>
		protected RSystem.RObject r_F__0__Value__1__k__BackingField;
		public virtual RSystem.RObject RF__0__Value__1__k__BackingField
		{
			get
			{
				if(r_F__0__Value__1__k__BackingField == null)
				{
					r_F__0__Value__1__k__BackingField = new(this, "<Value>k__BackingField");
					r_F__0__Value__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__Value__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Type ArgumentType
		/// </summary>
		protected RSystem.RType r_PArgumentType;
		public virtual RSystem.RType RPArgumentType
		{
			get
			{
				if(r_PArgumentType == null)
				{
					r_PArgumentType = new(this, "ArgumentType", -1);
					r_PArgumentType.SetBelong(this.instance);
				}
				return r_PArgumentType;
			}
		}

		/// <summary>
		/// System.Object Value
		/// </summary>
		protected RSystem.RObject r_PValue;
		public virtual RSystem.RObject RPValue
		{
			get
			{
				if(r_PValue == null)
				{
					r_PValue = new(this, "Value", -1);
					r_PValue.SetBelong(this.instance);
				}
				return r_PValue;
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
		/// Boolean op_Equality(System.Reflection.CustomAttributeTypedArgument, System.Reflection.CustomAttributeTypedArgument)
		/// </summary>
		protected static RMethod r_Mop_Equality_CustomAttributeTypedArgument_CustomAttributeTypedArgument;
		public static RMethod RMop_Equality_CustomAttributeTypedArgument_CustomAttributeTypedArgument
		{
			get
			{
				if(r_Mop_Equality_CustomAttributeTypedArgument_CustomAttributeTypedArgument == null)
				{
					r_Mop_Equality_CustomAttributeTypedArgument_CustomAttributeTypedArgument = new(typeof(System.Reflection.CustomAttributeTypedArgument), "op_Equality", 0, typeof(System.Reflection.CustomAttributeTypedArgument), typeof(System.Reflection.CustomAttributeTypedArgument));
					r_Mop_Equality_CustomAttributeTypedArgument_CustomAttributeTypedArgument.SetBelong(null);
				}
				return r_Mop_Equality_CustomAttributeTypedArgument_CustomAttributeTypedArgument;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.CustomAttributeTypedArgument, System.Reflection.CustomAttributeTypedArgument)
		/// </summary>
		protected static RMethod r_Mop_Inequality_CustomAttributeTypedArgument_CustomAttributeTypedArgument;
		public static RMethod RMop_Inequality_CustomAttributeTypedArgument_CustomAttributeTypedArgument
		{
			get
			{
				if(r_Mop_Inequality_CustomAttributeTypedArgument_CustomAttributeTypedArgument == null)
				{
					r_Mop_Inequality_CustomAttributeTypedArgument_CustomAttributeTypedArgument = new(typeof(System.Reflection.CustomAttributeTypedArgument), "op_Inequality", 0, typeof(System.Reflection.CustomAttributeTypedArgument), typeof(System.Reflection.CustomAttributeTypedArgument));
					r_Mop_Inequality_CustomAttributeTypedArgument_CustomAttributeTypedArgument.SetBelong(null);
				}
				return r_Mop_Inequality_CustomAttributeTypedArgument_CustomAttributeTypedArgument;
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
		/// System.String ToString(Boolean)
		/// </summary>
		protected RMethod r_MToString_Boolean;
		public virtual RMethod RMToString_Boolean
		{
			get
			{
				if(r_MToString_Boolean == null)
				{
					r_MToString_Boolean = new(this, "ToString", 0, typeof(System.Boolean));
					r_MToString_Boolean.SetBelong(this.instance);
				}
				return r_MToString_Boolean;
			}
		}

		/// <summary>
		/// System.Object CanonicalizeValue(System.Object)
		/// </summary>
		protected static RMethod r_MCanonicalizeValue_Object;
		public static RMethod RMCanonicalizeValue_Object
		{
			get
			{
				if(r_MCanonicalizeValue_Object == null)
				{
					r_MCanonicalizeValue_Object = new(typeof(System.Reflection.CustomAttributeTypedArgument), "CanonicalizeValue", 0, typeof(System.Object));
					r_MCanonicalizeValue_Object.SetBelong(null);
				}
				return r_MCanonicalizeValue_Object;
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


        public static System.Boolean op_Equality(System.Reflection.CustomAttributeTypedArgument @left, System.Reflection.CustomAttributeTypedArgument @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_CustomAttributeTypedArgument_CustomAttributeTypedArgument.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Reflection.CustomAttributeTypedArgument @left, System.Reflection.CustomAttributeTypedArgument @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_CustomAttributeTypedArgument_CustomAttributeTypedArgument.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.Boolean @typed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typed};
            var ___result = RMToString_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Object CanonicalizeValue(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMCanonicalizeValue_Object.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
