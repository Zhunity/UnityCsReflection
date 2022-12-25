using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.SpriteCharacter
	/// </summary>
    public partial class RSpriteCharacter : RMember //
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
		/// UnityEngine.TextCore.Text.TextElementType m_ElementType
		/// </summary>
		protected RField r_m_ElementType;
		public virtual RField Rm_ElementType
		{
			get
			{
				if(r_m_ElementType == null)
				{
					r_m_ElementType = new(this, "m_ElementType");
					r_m_ElementType.SetBelong(this.instance);
				}
				return r_m_ElementType;
			}
		}

		/// <summary>
		/// System.UInt32 m_Unicode
		/// </summary>
		protected RField r_m_Unicode;
		public virtual RField Rm_Unicode
		{
			get
			{
				if(r_m_Unicode == null)
				{
					r_m_Unicode = new(this, "m_Unicode");
					r_m_Unicode.SetBelong(this.instance);
				}
				return r_m_Unicode;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAsset m_TextAsset
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextAsset r_m_TextAsset;
		public virtual RUnityEngine.RTextCore.RText.RTextAsset Rm_TextAsset
		{
			get
			{
				if(r_m_TextAsset == null)
				{
					r_m_TextAsset = new(this, "m_TextAsset");
					r_m_TextAsset.SetBelong(this.instance);
				}
				return r_m_TextAsset;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Glyph m_Glyph
		/// </summary>
		protected RUnityEngine.RTextCore.RGlyph r_m_Glyph;
		public virtual RUnityEngine.RTextCore.RGlyph Rm_Glyph
		{
			get
			{
				if(r_m_Glyph == null)
				{
					r_m_Glyph = new(this, "m_Glyph");
					r_m_Glyph.SetBelong(this.instance);
				}
				return r_m_Glyph;
			}
		}

		/// <summary>
		/// System.UInt32 m_GlyphIndex
		/// </summary>
		protected RField r_m_GlyphIndex;
		public virtual RField Rm_GlyphIndex
		{
			get
			{
				if(r_m_GlyphIndex == null)
				{
					r_m_GlyphIndex = new(this, "m_GlyphIndex");
					r_m_GlyphIndex.SetBelong(this.instance);
				}
				return r_m_GlyphIndex;
			}
		}

		/// <summary>
		/// System.Single m_Scale
		/// </summary>
		protected RField r_m_Scale;
		public virtual RField Rm_Scale
		{
			get
			{
				if(r_m_Scale == null)
				{
					r_m_Scale = new(this, "m_Scale");
					r_m_Scale.SetBelong(this.instance);
				}
				return r_m_Scale;
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
		/// UnityEngine.TextCore.Text.TextElementType elementType
		/// </summary>
		protected RProperty r_elementType;
		public virtual RProperty RelementType
		{
			get
			{
				if(r_elementType == null)
				{
					r_elementType = new(this, "elementType", -1);
					r_elementType.SetBelong(this.instance);
				}
				return r_elementType;
			}
		}

		/// <summary>
		/// UInt32 unicode
		/// </summary>
		protected RProperty r_unicode;
		public virtual RProperty Runicode
		{
			get
			{
				if(r_unicode == null)
				{
					r_unicode = new(this, "unicode", -1);
					r_unicode.SetBelong(this.instance);
				}
				return r_unicode;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAsset textAsset
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextAsset r_textAsset;
		public virtual RUnityEngine.RTextCore.RText.RTextAsset RtextAsset
		{
			get
			{
				if(r_textAsset == null)
				{
					r_textAsset = new(this, "textAsset", -1);
					r_textAsset.SetBelong(this.instance);
				}
				return r_textAsset;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Glyph glyph
		/// </summary>
		protected RUnityEngine.RTextCore.RGlyph r_glyph;
		public virtual RUnityEngine.RTextCore.RGlyph Rglyph
		{
			get
			{
				if(r_glyph == null)
				{
					r_glyph = new(this, "glyph", -1);
					r_glyph.SetBelong(this.instance);
				}
				return r_glyph;
			}
		}

		/// <summary>
		/// UInt32 glyphIndex
		/// </summary>
		protected RProperty r_glyphIndex;
		public virtual RProperty RglyphIndex
		{
			get
			{
				if(r_glyphIndex == null)
				{
					r_glyphIndex = new(this, "glyphIndex", -1);
					r_glyphIndex.SetBelong(this.instance);
				}
				return r_glyphIndex;
			}
		}

		/// <summary>
		/// Single scale
		/// </summary>
		protected RProperty r_scale;
		public virtual RProperty Rscale
		{
			get
			{
				if(r_scale == null)
				{
					r_scale = new(this, "scale", -1);
					r_scale.SetBelong(this.instance);
				}
				return r_scale;
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


        public RSpriteCharacter() : base("UnityEngine.TextCore.Text.SpriteCharacter")
        {
        }

        public RSpriteCharacter(System.Object instance) : base("UnityEngine.TextCore.Text.SpriteCharacter")
		{
            SetInstance(instance);
		}

        public RSpriteCharacter(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSpriteCharacter(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
