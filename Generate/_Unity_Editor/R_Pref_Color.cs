
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
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fm_Name;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFm_Name
		{
			get
			{
				if(r_Fm_Name == null)
				{
					r_Fm_Name = new(this, "m_Name");
					r_Fm_Name.SetBelong(this.instance);
				}
				return r_Fm_Name;
			}
		}

		/// <summary>
		/// UnityEngine.Color m_Color
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RColor r_Fm_Color;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RColor RFm_Color
		{
			get
			{
				if(r_Fm_Color == null)
				{
					r_Fm_Color = new(this, "m_Color");
					r_Fm_Color.SetBelong(this.instance);
				}
				return r_Fm_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Color m_DefaultColor
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RColor r_Fm_DefaultColor;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RColor RFm_DefaultColor
		{
			get
			{
				if(r_Fm_DefaultColor == null)
				{
					r_Fm_DefaultColor = new(this, "m_DefaultColor");
					r_Fm_DefaultColor.SetBelong(this.instance);
				}
				return r_Fm_DefaultColor;
			}
		}

		/// <summary>
		/// System.Boolean m_SeparateColors
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_SeparateColors;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_SeparateColors
		{
			get
			{
				if(r_Fm_SeparateColors == null)
				{
					r_Fm_SeparateColors = new(this, "m_SeparateColors");
					r_Fm_SeparateColors.SetBelong(this.instance);
				}
				return r_Fm_SeparateColors;
			}
		}

		/// <summary>
		/// UnityEngine.Color m_OptionalDarkColor
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RColor r_Fm_OptionalDarkColor;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RColor RFm_OptionalDarkColor
		{
			get
			{
				if(r_Fm_OptionalDarkColor == null)
				{
					r_Fm_OptionalDarkColor = new(this, "m_OptionalDarkColor");
					r_Fm_OptionalDarkColor.SetBelong(this.instance);
				}
				return r_Fm_OptionalDarkColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color m_OptionalDarkDefaultColor
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RColor r_Fm_OptionalDarkDefaultColor;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RColor RFm_OptionalDarkDefaultColor
		{
			get
			{
				if(r_Fm_OptionalDarkDefaultColor == null)
				{
					r_Fm_OptionalDarkDefaultColor = new(this, "m_OptionalDarkDefaultColor");
					r_Fm_OptionalDarkDefaultColor.SetBelong(this.instance);
				}
				return r_Fm_OptionalDarkDefaultColor;
			}
		}

		/// <summary>
		/// System.Boolean m_Loaded
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_Loaded;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_Loaded
		{
			get
			{
				if(r_Fm_Loaded == null)
				{
					r_Fm_Loaded = new(this, "m_Loaded");
					r_Fm_Loaded.SetBelong(this.instance);
				}
				return r_Fm_Loaded;
			}
		}

		/// <summary>
		/// UnityEngine.Color Color
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RColor r_PColor;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RColor RPColor
		{
			get
			{
				if(r_PColor == null)
				{
					r_PColor = new(this, "Color", -1);
					r_PColor.SetBelong(this.instance);
				}
				return r_PColor;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
					r_PName.SetBelong(this.instance);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// Void Load()
		/// </summary>
		protected RMethod r_MLoad;
		public virtual RMethod RMLoad
		{
			get
			{
				if(r_MLoad == null)
				{
					r_MLoad = new(this, "Load", 0);
					r_MLoad.SetBelong(this.instance);
				}
				return r_MLoad;
			}
		}

		/// <summary>
		/// UnityEngine.Color op_Implicit(UnityEditor.PrefColor)
		/// </summary>
		protected static RMethod r_Mop_Implicit_PrefColor;
		public static RMethod RMop_Implicit_PrefColor
		{
			get
			{
				if(r_Mop_Implicit_PrefColor == null)
				{
					r_Mop_Implicit_PrefColor = new( ReflectionUtils.GetType("UnityEditor.PrefColor"), "op_Implicit", 0,  ReflectionUtils.GetType("UnityEditor.PrefColor"));
					r_Mop_Implicit_PrefColor.SetBelong(null);
				}
				return r_Mop_Implicit_PrefColor;
			}
		}

		/// <summary>
		/// System.String ToUniqueString()
		/// </summary>
		protected RMethod r_MToUniqueString;
		public virtual RMethod RMToUniqueString
		{
			get
			{
				if(r_MToUniqueString == null)
				{
					r_MToUniqueString = new(this, "ToUniqueString", 0);
					r_MToUniqueString.SetBelong(this.instance);
				}
				return r_MToUniqueString;
			}
		}

		/// <summary>
		/// Void FromUniqueString(System.String)
		/// </summary>
		protected RMethod r_MFromUniqueString_String;
		public virtual RMethod RMFromUniqueString_String
		{
			get
			{
				if(r_MFromUniqueString_String == null)
				{
					r_MFromUniqueString_String = new(this, "FromUniqueString", 0, typeof(System.String));
					r_MFromUniqueString_String.SetBelong(this.instance);
				}
				return r_MFromUniqueString_String;
			}
		}

		/// <summary>
		/// Void ResetToDefault()
		/// </summary>
		protected RMethod r_MResetToDefault;
		public virtual RMethod RMResetToDefault
		{
			get
			{
				if(r_MResetToDefault == null)
				{
					r_MResetToDefault = new(this, "ResetToDefault", 0);
					r_MResetToDefault.SetBelong(this.instance);
				}
				return r_MResetToDefault;
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
            var ___result = RMLoad.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Color op_Implicit(SMFrame.Editor.Refleaction.RUnityEditor.RPrefColor @pcolor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcolor.Value};
            var ___result = RMop_Implicit_PrefColor.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual System.String ToUniqueString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToUniqueString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void FromUniqueString(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RMFromUniqueString_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetToDefault()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetToDefault.Invoke(___genericsType, ___parameters);

            
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
