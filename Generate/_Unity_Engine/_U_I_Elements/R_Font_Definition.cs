
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.FontDefinition
	/// </summary>
    public partial class RFontDefinition : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.FontDefinition);
            }
        }

        public RFontDefinition() : base("UnityEngine.UIElements.FontDefinition")
        {
        }

        public RFontDefinition(System.Object instance) : base("UnityEngine.UIElements.FontDefinition")
		{
            SetInstance(instance);
		}

        public RFontDefinition(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFontDefinition(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.Font m_Font
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RFont r_Fm_Font;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RFont RFm_Font
		{
			get
			{
				if(r_Fm_Font == null)
				{
					r_Fm_Font = new(this, "m_Font");
				}
				return r_Fm_Font;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset m_FontAsset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset r_Fm_FontAsset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset RFm_FontAsset
		{
			get
			{
				if(r_Fm_FontAsset == null)
				{
					r_Fm_FontAsset = new(this, "m_FontAsset");
				}
				return r_Fm_FontAsset;
			}
		}

		/// <summary>
		/// UnityEngine.Font font
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RFont r_Pfont;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RFont RPfont
		{
			get
			{
				if(r_Pfont == null)
				{
					r_Pfont = new(this, "font", -1);
				}
				return r_Pfont;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset fontAsset
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset r_PfontAsset;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RFontAsset RPfontAsset
		{
			get
			{
				if(r_PfontAsset == null)
				{
					r_PfontAsset = new(this, "fontAsset", -1);
				}
				return r_PfontAsset;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] allowedAssetTypes
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RType> r_PallowedAssetTypes;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RType> RPallowedAssetTypes
		{
			get
			{
				if(r_PallowedAssetTypes == null)
				{
					r_PallowedAssetTypes = new(Type, "allowedAssetTypes", -1);
				}
				return r_PallowedAssetTypes;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FontDefinition FromFont(UnityEngine.Font)
		/// </summary>
		protected static RMethod r_MFromFont_Font;
		public static RMethod RMFromFont_Font
		{
			get
			{
				if(r_MFromFont_Font == null)
				{
					r_MFromFont_Font = new(Type, "FromFont", 0, typeof(UnityEngine.Font));
				}
				return r_MFromFont_Font;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FontDefinition FromSDFFont(UnityEngine.TextCore.Text.FontAsset)
		/// </summary>
		protected static RMethod r_MFromSDFFont_FontAsset;
		public static RMethod RMFromSDFFont_FontAsset
		{
			get
			{
				if(r_MFromSDFFont_FontAsset == null)
				{
					r_MFromSDFFont_FontAsset = new(Type, "FromSDFFont", 0, typeof(UnityEngine.TextCore.Text.FontAsset));
				}
				return r_MFromSDFFont_FontAsset;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FontDefinition FromObject(System.Object)
		/// </summary>
		protected static RMethod r_MFromObject_Object;
		public static RMethod RMFromObject_Object
		{
			get
			{
				if(r_MFromObject_Object == null)
				{
					r_MFromObject_Object = new(Type, "FromObject", 0, typeof(System.Object));
				}
				return r_MFromObject_Object;
			}
		}

		/// <summary>
		/// Boolean IsEmpty()
		/// </summary>
		protected RMethod r_MIsEmpty;
		public virtual RMethod RMIsEmpty
		{
			get
			{
				if(r_MIsEmpty == null)
				{
					r_MIsEmpty = new(this, "IsEmpty", 0);
				}
				return r_MIsEmpty;
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
		/// Boolean Equals(UnityEngine.UIElements.FontDefinition)
		/// </summary>
		protected RMethod r_MEquals_FontDefinition;
		public virtual RMethod RMEquals_FontDefinition
		{
			get
			{
				if(r_MEquals_FontDefinition == null)
				{
					r_MEquals_FontDefinition = new(this, "Equals", 0, typeof(UnityEngine.UIElements.FontDefinition));
				}
				return r_MEquals_FontDefinition;
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
		/// Boolean op_Equality(UnityEngine.UIElements.FontDefinition, UnityEngine.UIElements.FontDefinition)
		/// </summary>
		protected static RMethod r_Mop_Equality_FontDefinition_FontDefinition;
		public static RMethod RMop_Equality_FontDefinition_FontDefinition
		{
			get
			{
				if(r_Mop_Equality_FontDefinition_FontDefinition == null)
				{
					r_Mop_Equality_FontDefinition_FontDefinition = new(Type, "op_Equality", 0, typeof(UnityEngine.UIElements.FontDefinition), typeof(UnityEngine.UIElements.FontDefinition));
				}
				return r_Mop_Equality_FontDefinition_FontDefinition;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.FontDefinition, UnityEngine.UIElements.FontDefinition)
		/// </summary>
		protected static RMethod r_Mop_Inequality_FontDefinition_FontDefinition;
		public static RMethod RMop_Inequality_FontDefinition_FontDefinition
		{
			get
			{
				if(r_Mop_Inequality_FontDefinition_FontDefinition == null)
				{
					r_Mop_Inequality_FontDefinition_FontDefinition = new(Type, "op_Inequality", 0, typeof(UnityEngine.UIElements.FontDefinition), typeof(UnityEngine.UIElements.FontDefinition));
				}
				return r_Mop_Inequality_FontDefinition_FontDefinition;
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


        public static UnityEngine.UIElements.FontDefinition FromFont(UnityEngine.Font @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RMFromFont_Font.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.FontDefinition>(___result);
        }


        public static UnityEngine.UIElements.FontDefinition FromSDFFont(UnityEngine.TextCore.Text.FontAsset @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RMFromSDFFont_FontAsset.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.FontDefinition>(___result);
        }


        public static UnityEngine.UIElements.FontDefinition FromObject(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMFromObject_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.FontDefinition>(___result);
        }


        public virtual System.Boolean IsEmpty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsEmpty.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.FontDefinition @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_FontDefinition.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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


        public static System.Boolean op_Equality(UnityEngine.UIElements.FontDefinition @left, UnityEngine.UIElements.FontDefinition @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_FontDefinition_FontDefinition.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.FontDefinition @left, UnityEngine.UIElements.FontDefinition @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_FontDefinition_FontDefinition.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
