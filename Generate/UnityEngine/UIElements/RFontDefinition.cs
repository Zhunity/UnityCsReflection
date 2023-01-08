using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.FontDefinition
	/// </summary>
    public partial class RFontDefinition : RMember //
    {

		/// <summary>
		/// UnityEngine.Font m_Font
		/// </summary>
		protected RUnityEngine.RFont r_m_Font;
		public virtual RUnityEngine.RFont Rm_Font
		{
			get
			{
				if(r_m_Font == null)
				{
					r_m_Font = new(this, "m_Font");
					r_m_Font.SetBelong(this.instance);
				}
				return r_m_Font;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset m_FontAsset
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RFontAsset r_m_FontAsset;
		public virtual RUnityEngine.RTextCore.RText.RFontAsset Rm_FontAsset
		{
			get
			{
				if(r_m_FontAsset == null)
				{
					r_m_FontAsset = new(this, "m_FontAsset");
					r_m_FontAsset.SetBelong(this.instance);
				}
				return r_m_FontAsset;
			}
		}

		/// <summary>
		/// UnityEngine.Font font
		/// </summary>
		protected RUnityEngine.RFont r_font;
		public virtual RUnityEngine.RFont Rfont
		{
			get
			{
				if(r_font == null)
				{
					r_font = new(this, "font", -1);
					r_font.SetBelong(this.instance);
				}
				return r_font;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.FontAsset fontAsset
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RFontAsset r_fontAsset;
		public virtual RUnityEngine.RTextCore.RText.RFontAsset RfontAsset
		{
			get
			{
				if(r_fontAsset == null)
				{
					r_fontAsset = new(this, "fontAsset", -1);
					r_fontAsset.SetBelong(this.instance);
				}
				return r_fontAsset;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] allowedAssetTypes
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RType> r_allowedAssetTypes;
		public static RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RType> RallowedAssetTypes
		{
			get
			{
				if(r_allowedAssetTypes == null)
				{
					r_allowedAssetTypes = new(typeof(UnityEngine.UIElements.FontDefinition), "allowedAssetTypes", -1);
					r_allowedAssetTypes.SetBelong(null);
				}
				return r_allowedAssetTypes;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FontDefinition FromFont(UnityEngine.Font)
		/// </summary>
		protected static RMethod r_FromFont_Font;
		public static RMethod RFromFont_Font
		{
			get
			{
				if(r_FromFont_Font == null)
				{
					r_FromFont_Font = new(typeof(UnityEngine.UIElements.FontDefinition), "FromFont", 0, typeof(UnityEngine.Font));
					r_FromFont_Font.SetBelong(null);
				}
				return r_FromFont_Font;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FontDefinition FromSDFFont(UnityEngine.TextCore.Text.FontAsset)
		/// </summary>
		protected static RMethod r_FromSDFFont_FontAsset;
		public static RMethod RFromSDFFont_FontAsset
		{
			get
			{
				if(r_FromSDFFont_FontAsset == null)
				{
					r_FromSDFFont_FontAsset = new(typeof(UnityEngine.UIElements.FontDefinition), "FromSDFFont", 0, typeof(UnityEngine.TextCore.Text.FontAsset));
					r_FromSDFFont_FontAsset.SetBelong(null);
				}
				return r_FromSDFFont_FontAsset;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FontDefinition FromObject(System.Object)
		/// </summary>
		protected static RMethod r_FromObject_Object;
		public static RMethod RFromObject_Object
		{
			get
			{
				if(r_FromObject_Object == null)
				{
					r_FromObject_Object = new(typeof(UnityEngine.UIElements.FontDefinition), "FromObject", 0, typeof(System.Object));
					r_FromObject_Object.SetBelong(null);
				}
				return r_FromObject_Object;
			}
		}

		/// <summary>
		/// Boolean IsEmpty()
		/// </summary>
		protected RMethod r_IsEmpty;
		public virtual RMethod RIsEmpty
		{
			get
			{
				if(r_IsEmpty == null)
				{
					r_IsEmpty = new(this, "IsEmpty", 0);
					r_IsEmpty.SetBelong(this.instance);
				}
				return r_IsEmpty;
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
		/// Boolean Equals(UnityEngine.UIElements.FontDefinition)
		/// </summary>
		protected RMethod r_Equals_FontDefinition;
		public virtual RMethod REquals_FontDefinition
		{
			get
			{
				if(r_Equals_FontDefinition == null)
				{
					r_Equals_FontDefinition = new(this, "Equals", 0, typeof(UnityEngine.UIElements.FontDefinition));
					r_Equals_FontDefinition.SetBelong(this.instance);
				}
				return r_Equals_FontDefinition;
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
		/// Boolean op_Equality(UnityEngine.UIElements.FontDefinition, UnityEngine.UIElements.FontDefinition)
		/// </summary>
		protected static RMethod r_op_Equality_FontDefinition_FontDefinition;
		public static RMethod Rop_Equality_FontDefinition_FontDefinition
		{
			get
			{
				if(r_op_Equality_FontDefinition_FontDefinition == null)
				{
					r_op_Equality_FontDefinition_FontDefinition = new(typeof(UnityEngine.UIElements.FontDefinition), "op_Equality", 0, typeof(UnityEngine.UIElements.FontDefinition), typeof(UnityEngine.UIElements.FontDefinition));
					r_op_Equality_FontDefinition_FontDefinition.SetBelong(null);
				}
				return r_op_Equality_FontDefinition_FontDefinition;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.FontDefinition, UnityEngine.UIElements.FontDefinition)
		/// </summary>
		protected static RMethod r_op_Inequality_FontDefinition_FontDefinition;
		public static RMethod Rop_Inequality_FontDefinition_FontDefinition
		{
			get
			{
				if(r_op_Inequality_FontDefinition_FontDefinition == null)
				{
					r_op_Inequality_FontDefinition_FontDefinition = new(typeof(UnityEngine.UIElements.FontDefinition), "op_Inequality", 0, typeof(UnityEngine.UIElements.FontDefinition), typeof(UnityEngine.UIElements.FontDefinition));
					r_op_Inequality_FontDefinition_FontDefinition.SetBelong(null);
				}
				return r_op_Inequality_FontDefinition_FontDefinition;
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

        public static UnityEngine.UIElements.FontDefinition FromFont(UnityEngine.Font  @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RFromFont_Font.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.FontDefinition)___result;
        }


        public static UnityEngine.UIElements.FontDefinition FromSDFFont(UnityEngine.TextCore.Text.FontAsset  @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RFromSDFFont_FontAsset.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.FontDefinition)___result;
        }


        public static UnityEngine.UIElements.FontDefinition FromObject(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RFromObject_Object.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.FontDefinition)___result;
        }


        public virtual System.Boolean IsEmpty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsEmpty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.FontDefinition  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_FontDefinition.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public static System.Boolean op_Equality(UnityEngine.UIElements.FontDefinition  @left, UnityEngine.UIElements.FontDefinition  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_FontDefinition_FontDefinition.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.FontDefinition  @left, UnityEngine.UIElements.FontDefinition  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_FontDefinition_FontDefinition.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
