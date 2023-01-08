using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.PrefColor
	/// </summary>
    public partial class RPrefColor : RMember //
    {

		/// <summary>
		/// System.String m_Name
		/// </summary>
		protected RField r_m_Name;
		public virtual RField Rm_Name
		{
			get
			{
				if(r_m_Name == null)
				{
					r_m_Name = new(this, "m_Name");
					r_m_Name.SetBelong(this.instance);
				}
				return r_m_Name;
			}
		}

		/// <summary>
		/// UnityEngine.Color m_Color
		/// </summary>
		protected RUnityEngine.RColor r_m_Color;
		public virtual RUnityEngine.RColor Rm_Color
		{
			get
			{
				if(r_m_Color == null)
				{
					r_m_Color = new(this, "m_Color");
					r_m_Color.SetBelong(this.instance);
				}
				return r_m_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Color m_DefaultColor
		/// </summary>
		protected RUnityEngine.RColor r_m_DefaultColor;
		public virtual RUnityEngine.RColor Rm_DefaultColor
		{
			get
			{
				if(r_m_DefaultColor == null)
				{
					r_m_DefaultColor = new(this, "m_DefaultColor");
					r_m_DefaultColor.SetBelong(this.instance);
				}
				return r_m_DefaultColor;
			}
		}

		/// <summary>
		/// System.Boolean m_SeparateColors
		/// </summary>
		protected RField r_m_SeparateColors;
		public virtual RField Rm_SeparateColors
		{
			get
			{
				if(r_m_SeparateColors == null)
				{
					r_m_SeparateColors = new(this, "m_SeparateColors");
					r_m_SeparateColors.SetBelong(this.instance);
				}
				return r_m_SeparateColors;
			}
		}

		/// <summary>
		/// UnityEngine.Color m_OptionalDarkColor
		/// </summary>
		protected RUnityEngine.RColor r_m_OptionalDarkColor;
		public virtual RUnityEngine.RColor Rm_OptionalDarkColor
		{
			get
			{
				if(r_m_OptionalDarkColor == null)
				{
					r_m_OptionalDarkColor = new(this, "m_OptionalDarkColor");
					r_m_OptionalDarkColor.SetBelong(this.instance);
				}
				return r_m_OptionalDarkColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color m_OptionalDarkDefaultColor
		/// </summary>
		protected RUnityEngine.RColor r_m_OptionalDarkDefaultColor;
		public virtual RUnityEngine.RColor Rm_OptionalDarkDefaultColor
		{
			get
			{
				if(r_m_OptionalDarkDefaultColor == null)
				{
					r_m_OptionalDarkDefaultColor = new(this, "m_OptionalDarkDefaultColor");
					r_m_OptionalDarkDefaultColor.SetBelong(this.instance);
				}
				return r_m_OptionalDarkDefaultColor;
			}
		}

		/// <summary>
		/// System.Boolean m_Loaded
		/// </summary>
		protected RField r_m_Loaded;
		public virtual RField Rm_Loaded
		{
			get
			{
				if(r_m_Loaded == null)
				{
					r_m_Loaded = new(this, "m_Loaded");
					r_m_Loaded.SetBelong(this.instance);
				}
				return r_m_Loaded;
			}
		}

		/// <summary>
		/// UnityEngine.Color Color
		/// </summary>
		protected RUnityEngine.RColor r_Color;
		public virtual RUnityEngine.RColor RColor
		{
			get
			{
				if(r_Color == null)
				{
					r_Color = new(this, "Color", -1);
					r_Color.SetBelong(this.instance);
				}
				return r_Color;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
			}
		}

		/// <summary>
		/// Void Load()
		/// </summary>
		protected RMethod r_Load;
		public virtual RMethod RLoad
		{
			get
			{
				if(r_Load == null)
				{
					r_Load = new(this, "Load", 0);
					r_Load.SetBelong(this.instance);
				}
				return r_Load;
			}
		}

		/// <summary>
		/// UnityEngine.Color op_Implicit(UnityEditor.PrefColor)
		/// </summary>
		protected static RMethod r_op_Implicit_PrefColor;
		public static RMethod Rop_Implicit_PrefColor
		{
			get
			{
				if(r_op_Implicit_PrefColor == null)
				{
					r_op_Implicit_PrefColor = new( ReflectionUtils.GetType("UnityEditor.PrefColor"), "op_Implicit", 0,  ReflectionUtils.GetType("UnityEditor.PrefColor"));
					r_op_Implicit_PrefColor.SetBelong(null);
				}
				return r_op_Implicit_PrefColor;
			}
		}

		/// <summary>
		/// System.String ToUniqueString()
		/// </summary>
		protected RMethod r_ToUniqueString;
		public virtual RMethod RToUniqueString
		{
			get
			{
				if(r_ToUniqueString == null)
				{
					r_ToUniqueString = new(this, "ToUniqueString", 0);
					r_ToUniqueString.SetBelong(this.instance);
				}
				return r_ToUniqueString;
			}
		}

		/// <summary>
		/// Void FromUniqueString(System.String)
		/// </summary>
		protected RMethod r_FromUniqueString_String;
		public virtual RMethod RFromUniqueString_String
		{
			get
			{
				if(r_FromUniqueString_String == null)
				{
					r_FromUniqueString_String = new(this, "FromUniqueString", 0, typeof(System.String));
					r_FromUniqueString_String.SetBelong(this.instance);
				}
				return r_FromUniqueString_String;
			}
		}

		/// <summary>
		/// Void ResetToDefault()
		/// </summary>
		protected RMethod r_ResetToDefault;
		public virtual RMethod RResetToDefault
		{
			get
			{
				if(r_ResetToDefault == null)
				{
					r_ResetToDefault = new(this, "ResetToDefault", 0);
					r_ResetToDefault.SetBelong(this.instance);
				}
				return r_ResetToDefault;
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


        public RPrefColor() : base("UnityEditor.PrefColor")
        {
        }

        public RPrefColor(System.Object instance) : base("UnityEditor.PrefColor")
		{
            SetInstance(instance);
		}

        public RPrefColor(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPrefColor(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Load()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLoad.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.String ToUniqueString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToUniqueString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void FromUniqueString(System.String  @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RFromUniqueString_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetToDefault()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetToDefault.Invoke(___genericsType, ___parameters);

            
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
