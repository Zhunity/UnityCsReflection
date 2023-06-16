
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Reflection.CustomAttributeNamedArgument
	/// </summary>
    public partial class RCustomAttributeNamedArgument : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Reflection.CustomAttributeNamedArgument);
            }
        }

        public RCustomAttributeNamedArgument() : base("System.Reflection.CustomAttributeNamedArgument")
        {
        }

        public RCustomAttributeNamedArgument(System.Object instance) : base("System.Reflection.CustomAttributeNamedArgument")
		{
            SetInstance(instance);
		}

        public RCustomAttributeNamedArgument(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCustomAttributeNamedArgument(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Reflection.CustomAttributeTypedArgument <TypedValue>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RCustomAttributeTypedArgument r_F__0__TypedValue__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RCustomAttributeTypedArgument RF__0__TypedValue__1__k__BackingField
		{
			get
			{
				if(r_F__0__TypedValue__1__k__BackingField == null)
				{
					r_F__0__TypedValue__1__k__BackingField = new(this, "<TypedValue>k__BackingField");
				}
				return r_F__0__TypedValue__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <IsField>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__IsField__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__IsField__1__k__BackingField
		{
			get
			{
				if(r_F__0__IsField__1__k__BackingField == null)
				{
					r_F__0__IsField__1__k__BackingField = new(this, "<IsField>k__BackingField");
				}
				return r_F__0__IsField__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <MemberName>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__MemberName__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__MemberName__1__k__BackingField
		{
			get
			{
				if(r_F__0__MemberName__1__k__BackingField == null)
				{
					r_F__0__MemberName__1__k__BackingField = new(this, "<MemberName>k__BackingField");
				}
				return r_F__0__MemberName__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Type _attributeType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_F_attributeType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RF_attributeType
		{
			get
			{
				if(r_F_attributeType == null)
				{
					r_F_attributeType = new(this, "_attributeType");
				}
				return r_F_attributeType;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo _lazyMemberInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMemberInfo r_F_lazyMemberInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMemberInfo RF_lazyMemberInfo
		{
			get
			{
				if(r_F_lazyMemberInfo == null)
				{
					r_F_lazyMemberInfo = new(this, "_lazyMemberInfo");
				}
				return r_F_lazyMemberInfo;
			}
		}

		/// <summary>
		/// System.Reflection.CustomAttributeTypedArgument TypedValue
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RCustomAttributeTypedArgument r_PTypedValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RCustomAttributeTypedArgument RPTypedValue
		{
			get
			{
				if(r_PTypedValue == null)
				{
					r_PTypedValue = new(this, "TypedValue", -1);
				}
				return r_PTypedValue;
			}
		}

		/// <summary>
		/// Boolean IsField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsField
		{
			get
			{
				if(r_PIsField == null)
				{
					r_PIsField = new(this, "IsField", -1);
				}
				return r_PIsField;
			}
		}

		/// <summary>
		/// System.String MemberName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PMemberName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPMemberName
		{
			get
			{
				if(r_PMemberName == null)
				{
					r_PMemberName = new(this, "MemberName", -1);
				}
				return r_PMemberName;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo MemberInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMemberInfo r_PMemberInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMemberInfo RPMemberInfo
		{
			get
			{
				if(r_PMemberInfo == null)
				{
					r_PMemberInfo = new(this, "MemberInfo", -1);
				}
				return r_PMemberInfo;
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
		/// Boolean op_Equality(System.Reflection.CustomAttributeNamedArgument, System.Reflection.CustomAttributeNamedArgument)
		/// </summary>
		protected static RMethod r_Mop_Equality_CustomAttributeNamedArgument_CustomAttributeNamedArgument;
		public static RMethod RMop_Equality_CustomAttributeNamedArgument_CustomAttributeNamedArgument
		{
			get
			{
				if(r_Mop_Equality_CustomAttributeNamedArgument_CustomAttributeNamedArgument == null)
				{
					r_Mop_Equality_CustomAttributeNamedArgument_CustomAttributeNamedArgument = new(Type, "op_Equality", 0, typeof(System.Reflection.CustomAttributeNamedArgument), typeof(System.Reflection.CustomAttributeNamedArgument));
				}
				return r_Mop_Equality_CustomAttributeNamedArgument_CustomAttributeNamedArgument;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.CustomAttributeNamedArgument, System.Reflection.CustomAttributeNamedArgument)
		/// </summary>
		protected static RMethod r_Mop_Inequality_CustomAttributeNamedArgument_CustomAttributeNamedArgument;
		public static RMethod RMop_Inequality_CustomAttributeNamedArgument_CustomAttributeNamedArgument
		{
			get
			{
				if(r_Mop_Inequality_CustomAttributeNamedArgument_CustomAttributeNamedArgument == null)
				{
					r_Mop_Inequality_CustomAttributeNamedArgument_CustomAttributeNamedArgument = new(Type, "op_Inequality", 0, typeof(System.Reflection.CustomAttributeNamedArgument), typeof(System.Reflection.CustomAttributeNamedArgument));
				}
				return r_Mop_Inequality_CustomAttributeNamedArgument_CustomAttributeNamedArgument;
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Boolean op_Equality(System.Reflection.CustomAttributeNamedArgument @left, System.Reflection.CustomAttributeNamedArgument @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_CustomAttributeNamedArgument_CustomAttributeNamedArgument.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(System.Reflection.CustomAttributeNamedArgument @left, System.Reflection.CustomAttributeNamedArgument @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_CustomAttributeNamedArgument_CustomAttributeNamedArgument.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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
