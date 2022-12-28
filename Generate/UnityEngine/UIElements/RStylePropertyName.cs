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
		protected RField r___1__id__2__k__BackingField;
		public virtual RField R__1__id__2__k__BackingField
		{
			get
			{
				if(r___1__id__2__k__BackingField == null)
				{
					r___1__id__2__k__BackingField = new(this, "<id>k__BackingField");
					r___1__id__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__id__2__k__BackingField;
			}
		}

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
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId StylePropertyIdFromString(System.String)
		/// </summary>
		protected static RMethod r_RStylePropertyIdFromString_String;
		public static RMethod RStylePropertyIdFromString_String
		{
			get
			{
				if(r_RStylePropertyIdFromString_String == null)
				{
					r_RStylePropertyIdFromString_String = new(typeof(UnityEngine.UIElements.StylePropertyName), "StylePropertyIdFromString", 0, typeof(System.String));
					r_RStylePropertyIdFromString_String.SetBelong(null);
				}
				return r_RStylePropertyIdFromString_String;
			}
		}

		/// <summary>
		/// Boolean IsNullOrEmpty(UnityEngine.UIElements.StylePropertyName)
		/// </summary>
		protected static RMethod r_RIsNullOrEmpty_StylePropertyName;
		public static RMethod RIsNullOrEmpty_StylePropertyName
		{
			get
			{
				if(r_RIsNullOrEmpty_StylePropertyName == null)
				{
					r_RIsNullOrEmpty_StylePropertyName = new(typeof(UnityEngine.UIElements.StylePropertyName), "IsNullOrEmpty", 0, typeof(UnityEngine.UIElements.StylePropertyName));
					r_RIsNullOrEmpty_StylePropertyName.SetBelong(null);
				}
				return r_RIsNullOrEmpty_StylePropertyName;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.StylePropertyName, UnityEngine.UIElements.StylePropertyName)
		/// </summary>
		protected static RMethod r_Rop_Equality_StylePropertyName_StylePropertyName;
		public static RMethod Rop_Equality_StylePropertyName_StylePropertyName
		{
			get
			{
				if(r_Rop_Equality_StylePropertyName_StylePropertyName == null)
				{
					r_Rop_Equality_StylePropertyName_StylePropertyName = new(typeof(UnityEngine.UIElements.StylePropertyName), "op_Equality", 0, typeof(UnityEngine.UIElements.StylePropertyName), typeof(UnityEngine.UIElements.StylePropertyName));
					r_Rop_Equality_StylePropertyName_StylePropertyName.SetBelong(null);
				}
				return r_Rop_Equality_StylePropertyName_StylePropertyName;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.StylePropertyName, UnityEngine.UIElements.StylePropertyName)
		/// </summary>
		protected static RMethod r_Rop_Inequality_StylePropertyName_StylePropertyName;
		public static RMethod Rop_Inequality_StylePropertyName_StylePropertyName
		{
			get
			{
				if(r_Rop_Inequality_StylePropertyName_StylePropertyName == null)
				{
					r_Rop_Inequality_StylePropertyName_StylePropertyName = new(typeof(UnityEngine.UIElements.StylePropertyName), "op_Inequality", 0, typeof(UnityEngine.UIElements.StylePropertyName), typeof(UnityEngine.UIElements.StylePropertyName));
					r_Rop_Inequality_StylePropertyName_StylePropertyName.SetBelong(null);
				}
				return r_Rop_Inequality_StylePropertyName_StylePropertyName;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StylePropertyName op_Implicit(System.String)
		/// </summary>
		protected static RMethod r_Rop_Implicit_String;
		public static RMethod Rop_Implicit_String
		{
			get
			{
				if(r_Rop_Implicit_String == null)
				{
					r_Rop_Implicit_String = new(typeof(UnityEngine.UIElements.StylePropertyName), "op_Implicit", 0, typeof(System.String));
					r_Rop_Implicit_String.SetBelong(null);
				}
				return r_Rop_Implicit_String;
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
		/// Boolean Equals(UnityEngine.UIElements.StylePropertyName)
		/// </summary>
		protected RMethod r_REquals_StylePropertyName;
		public virtual RMethod REquals_StylePropertyName
		{
			get
			{
				if(r_REquals_StylePropertyName == null)
				{
					r_REquals_StylePropertyName = new(this, "Equals", 0, typeof(UnityEngine.UIElements.StylePropertyName));
					r_REquals_StylePropertyName.SetBelong(this.instance);
				}
				return r_REquals_StylePropertyName;
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

        public static System.Object StylePropertyIdFromString(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RStylePropertyIdFromString_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Boolean IsNullOrEmpty(UnityEngine.UIElements.StylePropertyName  @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName};
            var ___result = RIsNullOrEmpty_StylePropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.StylePropertyName  @lhs, UnityEngine.UIElements.StylePropertyName  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_StylePropertyName_StylePropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.StylePropertyName  @lhs, UnityEngine.UIElements.StylePropertyName  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_StylePropertyName_StylePropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.UIElements.StylePropertyName op_Implicit(System.String  @name)
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


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.StylePropertyName  @other)
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