
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.StylePropertyName
	/// </summary>
    public partial class RStylePropertyName : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId <id>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_F__0__id__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RF__0__id__1__k__BackingField
		{
			get
			{
				if(r_F__0__id__1__k__BackingField == null)
				{
					r_F__0__id__1__k__BackingField = new(this, "<id>k__BackingField");
					r_F__0__id__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__id__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <name>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__name__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__name__1__k__BackingField
		{
			get
			{
				if(r_F__0__name__1__k__BackingField == null)
				{
					r_F__0__name__1__k__BackingField = new(this, "<name>k__BackingField");
					r_F__0__name__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__name__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId id
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId r_Pid;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId RPid
		{
			get
			{
				if(r_Pid == null)
				{
					r_Pid = new(this, "id", -1);
					r_Pid.SetBelong(this.instance);
				}
				return r_Pid;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
					r_Pname.SetBelong(this.instance);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.StylePropertyId StylePropertyIdFromString(System.String)
		/// </summary>
		protected static RMethod r_MStylePropertyIdFromString_String;
		public static RMethod RMStylePropertyIdFromString_String
		{
			get
			{
				if(r_MStylePropertyIdFromString_String == null)
				{
					r_MStylePropertyIdFromString_String = new(typeof(UnityEngine.UIElements.StylePropertyName), "StylePropertyIdFromString", 0, typeof(System.String));
					r_MStylePropertyIdFromString_String.SetBelong(null);
				}
				return r_MStylePropertyIdFromString_String;
			}
		}

		/// <summary>
		/// Boolean IsNullOrEmpty(UnityEngine.UIElements.StylePropertyName)
		/// </summary>
		protected static RMethod r_MIsNullOrEmpty_StylePropertyName;
		public static RMethod RMIsNullOrEmpty_StylePropertyName
		{
			get
			{
				if(r_MIsNullOrEmpty_StylePropertyName == null)
				{
					r_MIsNullOrEmpty_StylePropertyName = new(typeof(UnityEngine.UIElements.StylePropertyName), "IsNullOrEmpty", 0, typeof(UnityEngine.UIElements.StylePropertyName));
					r_MIsNullOrEmpty_StylePropertyName.SetBelong(null);
				}
				return r_MIsNullOrEmpty_StylePropertyName;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.StylePropertyName, UnityEngine.UIElements.StylePropertyName)
		/// </summary>
		protected static RMethod r_Mop_Equality_StylePropertyName_StylePropertyName;
		public static RMethod RMop_Equality_StylePropertyName_StylePropertyName
		{
			get
			{
				if(r_Mop_Equality_StylePropertyName_StylePropertyName == null)
				{
					r_Mop_Equality_StylePropertyName_StylePropertyName = new(typeof(UnityEngine.UIElements.StylePropertyName), "op_Equality", 0, typeof(UnityEngine.UIElements.StylePropertyName), typeof(UnityEngine.UIElements.StylePropertyName));
					r_Mop_Equality_StylePropertyName_StylePropertyName.SetBelong(null);
				}
				return r_Mop_Equality_StylePropertyName_StylePropertyName;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.StylePropertyName, UnityEngine.UIElements.StylePropertyName)
		/// </summary>
		protected static RMethod r_Mop_Inequality_StylePropertyName_StylePropertyName;
		public static RMethod RMop_Inequality_StylePropertyName_StylePropertyName
		{
			get
			{
				if(r_Mop_Inequality_StylePropertyName_StylePropertyName == null)
				{
					r_Mop_Inequality_StylePropertyName_StylePropertyName = new(typeof(UnityEngine.UIElements.StylePropertyName), "op_Inequality", 0, typeof(UnityEngine.UIElements.StylePropertyName), typeof(UnityEngine.UIElements.StylePropertyName));
					r_Mop_Inequality_StylePropertyName_StylePropertyName.SetBelong(null);
				}
				return r_Mop_Inequality_StylePropertyName_StylePropertyName;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StylePropertyName op_Implicit(System.String)
		/// </summary>
		protected static RMethod r_Mop_Implicit_String;
		public static RMethod RMop_Implicit_String
		{
			get
			{
				if(r_Mop_Implicit_String == null)
				{
					r_Mop_Implicit_String = new(typeof(UnityEngine.UIElements.StylePropertyName), "op_Implicit", 0, typeof(System.String));
					r_Mop_Implicit_String.SetBelong(null);
				}
				return r_Mop_Implicit_String;
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
		/// Boolean Equals(UnityEngine.UIElements.StylePropertyName)
		/// </summary>
		protected RMethod r_MEquals_StylePropertyName;
		public virtual RMethod RMEquals_StylePropertyName
		{
			get
			{
				if(r_MEquals_StylePropertyName == null)
				{
					r_MEquals_StylePropertyName = new(this, "Equals", 0, typeof(UnityEngine.UIElements.StylePropertyName));
					r_MEquals_StylePropertyName.SetBelong(this.instance);
				}
				return r_MEquals_StylePropertyName;
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

        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId StylePropertyIdFromString(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMStylePropertyIdFromString_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId(___result);
        }


        public static System.Boolean IsNullOrEmpty(UnityEngine.UIElements.StylePropertyName @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName};
            var ___result = RMIsNullOrEmpty_StylePropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.StylePropertyName @lhs, UnityEngine.UIElements.StylePropertyName @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_StylePropertyName_StylePropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.StylePropertyName @lhs, UnityEngine.UIElements.StylePropertyName @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_StylePropertyName_StylePropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.UIElements.StylePropertyName op_Implicit(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMop_Implicit_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StylePropertyName)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.StylePropertyName @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_StylePropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
