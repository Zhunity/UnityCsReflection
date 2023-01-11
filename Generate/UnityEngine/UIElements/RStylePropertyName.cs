using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StylePropertyName
	/// </summary>
    public partial class RStylePropertyName : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId <id>k__BackingField
		/// </summary>
		protected RField r___0__id__1__k__BackingField;
		public virtual RField R__0__id__1__k__BackingField
		{
			get
			{
				if(r___0__id__1__k__BackingField == null)
				{
					r___0__id__1__k__BackingField = new(this, "<id>k__BackingField");
					r___0__id__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__id__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <name>k__BackingField
		/// </summary>
		protected RSystem.RString r___0__name__1__k__BackingField;
		public virtual RSystem.RString R__0__name__1__k__BackingField
		{
			get
			{
				if(r___0__name__1__k__BackingField == null)
				{
					r___0__name__1__k__BackingField = new(this, "<name>k__BackingField");
					r___0__name__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__name__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId id
		/// </summary>
		protected RProperty r_id;
		public virtual RProperty Rid
		{
			get
			{
				if(r_id == null)
				{
					r_id = new(this, "id", -1);
					r_id.SetBelong(this.instance);
				}
				return r_id;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RSystem.RString r_name;
		public virtual RSystem.RString Rname
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
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId StylePropertyIdFromString(System.String)
		/// </summary>
		protected static RMethod r_StylePropertyIdFromString_String;
		public static RMethod RStylePropertyIdFromString_String
		{
			get
			{
				if(r_StylePropertyIdFromString_String == null)
				{
					r_StylePropertyIdFromString_String = new(typeof(UnityEngine.UIElements.StylePropertyName), "StylePropertyIdFromString", 0, typeof(System.String));
					r_StylePropertyIdFromString_String.SetBelong(null);
				}
				return r_StylePropertyIdFromString_String;
			}
		}

		/// <summary>
		/// Boolean IsNullOrEmpty(UnityEngine.UIElements.StylePropertyName)
		/// </summary>
		protected static RMethod r_IsNullOrEmpty_StylePropertyName;
		public static RMethod RIsNullOrEmpty_StylePropertyName
		{
			get
			{
				if(r_IsNullOrEmpty_StylePropertyName == null)
				{
					r_IsNullOrEmpty_StylePropertyName = new(typeof(UnityEngine.UIElements.StylePropertyName), "IsNullOrEmpty", 0, typeof(UnityEngine.UIElements.StylePropertyName));
					r_IsNullOrEmpty_StylePropertyName.SetBelong(null);
				}
				return r_IsNullOrEmpty_StylePropertyName;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.StylePropertyName, UnityEngine.UIElements.StylePropertyName)
		/// </summary>
		protected static RMethod r_op_Equality_StylePropertyName_StylePropertyName;
		public static RMethod Rop_Equality_StylePropertyName_StylePropertyName
		{
			get
			{
				if(r_op_Equality_StylePropertyName_StylePropertyName == null)
				{
					r_op_Equality_StylePropertyName_StylePropertyName = new(typeof(UnityEngine.UIElements.StylePropertyName), "op_Equality", 0, typeof(UnityEngine.UIElements.StylePropertyName), typeof(UnityEngine.UIElements.StylePropertyName));
					r_op_Equality_StylePropertyName_StylePropertyName.SetBelong(null);
				}
				return r_op_Equality_StylePropertyName_StylePropertyName;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.StylePropertyName, UnityEngine.UIElements.StylePropertyName)
		/// </summary>
		protected static RMethod r_op_Inequality_StylePropertyName_StylePropertyName;
		public static RMethod Rop_Inequality_StylePropertyName_StylePropertyName
		{
			get
			{
				if(r_op_Inequality_StylePropertyName_StylePropertyName == null)
				{
					r_op_Inequality_StylePropertyName_StylePropertyName = new(typeof(UnityEngine.UIElements.StylePropertyName), "op_Inequality", 0, typeof(UnityEngine.UIElements.StylePropertyName), typeof(UnityEngine.UIElements.StylePropertyName));
					r_op_Inequality_StylePropertyName_StylePropertyName.SetBelong(null);
				}
				return r_op_Inequality_StylePropertyName_StylePropertyName;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StylePropertyName op_Implicit(System.String)
		/// </summary>
		protected static RMethod r_op_Implicit_String;
		public static RMethod Rop_Implicit_String
		{
			get
			{
				if(r_op_Implicit_String == null)
				{
					r_op_Implicit_String = new(typeof(UnityEngine.UIElements.StylePropertyName), "op_Implicit", 0, typeof(System.String));
					r_op_Implicit_String.SetBelong(null);
				}
				return r_op_Implicit_String;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.StylePropertyName)
		/// </summary>
		protected RMethod r_Equals_StylePropertyName;
		public virtual RMethod REquals_StylePropertyName
		{
			get
			{
				if(r_Equals_StylePropertyName == null)
				{
					r_Equals_StylePropertyName = new(this, "Equals", 0, typeof(UnityEngine.UIElements.StylePropertyName));
					r_Equals_StylePropertyName.SetBelong(this.instance);
				}
				return r_Equals_StylePropertyName;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
			}
		}


        public RStylePropertyName() : base("UnityEngine.UIElements.StylePropertyName")
        {
        }

        public RStylePropertyName(System.Object instance) : base("UnityEngine.UIElements.StylePropertyName")
		{
            SetInstance(instance);
		}

        public RStylePropertyName(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStylePropertyName(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static RType StylePropertyIdFromString(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RStylePropertyIdFromString_String.Invoke(___genericsType, ___parameters);

            return new RType(___result);
        }


        public static System.Boolean IsNullOrEmpty(UnityEngine.UIElements.StylePropertyName @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName};
            var ___result = RIsNullOrEmpty_StylePropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.StylePropertyName @lhs, UnityEngine.UIElements.StylePropertyName @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_StylePropertyName_StylePropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.StylePropertyName @lhs, UnityEngine.UIElements.StylePropertyName @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_StylePropertyName_StylePropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.UIElements.StylePropertyName op_Implicit(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = Rop_Implicit_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StylePropertyName)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.StylePropertyName @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_StylePropertyName.Invoke(___genericsType, ___parameters);

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
