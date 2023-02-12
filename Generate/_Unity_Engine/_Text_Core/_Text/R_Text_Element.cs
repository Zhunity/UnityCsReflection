
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.TextElement
	/// </summary>
    public partial class RTextElement : RMember //
    {

		/// <summary>
		/// UnityEngine.TextCore.Text.TextElementType m_ElementType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextElementType r_Fm_ElementType;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextElementType RFm_ElementType
		{
			get
			{
				if(r_Fm_ElementType == null)
				{
					r_Fm_ElementType = new(this, "m_ElementType");
					r_Fm_ElementType.SetBelong(this.instance);
				}
				return r_Fm_ElementType;
			}
		}

		/// <summary>
		/// System.UInt32 m_Unicode
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_Fm_Unicode;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFm_Unicode
		{
			get
			{
				if(r_Fm_Unicode == null)
				{
					r_Fm_Unicode = new(this, "m_Unicode");
					r_Fm_Unicode.SetBelong(this.instance);
				}
				return r_Fm_Unicode;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAsset m_TextAsset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAsset r_Fm_TextAsset;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAsset RFm_TextAsset
		{
			get
			{
				if(r_Fm_TextAsset == null)
				{
					r_Fm_TextAsset = new(this, "m_TextAsset");
					r_Fm_TextAsset.SetBelong(this.instance);
				}
				return r_Fm_TextAsset;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Glyph m_Glyph
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RGlyph r_Fm_Glyph;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RGlyph RFm_Glyph
		{
			get
			{
				if(r_Fm_Glyph == null)
				{
					r_Fm_Glyph = new(this, "m_Glyph");
					r_Fm_Glyph.SetBelong(this.instance);
				}
				return r_Fm_Glyph;
			}
		}

		/// <summary>
		/// System.UInt32 m_GlyphIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_Fm_GlyphIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFm_GlyphIndex
		{
			get
			{
				if(r_Fm_GlyphIndex == null)
				{
					r_Fm_GlyphIndex = new(this, "m_GlyphIndex");
					r_Fm_GlyphIndex.SetBelong(this.instance);
				}
				return r_Fm_GlyphIndex;
			}
		}

		/// <summary>
		/// System.Single m_Scale
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_Fm_Scale;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFm_Scale
		{
			get
			{
				if(r_Fm_Scale == null)
				{
					r_Fm_Scale = new(this, "m_Scale");
					r_Fm_Scale.SetBelong(this.instance);
				}
				return r_Fm_Scale;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextElementType elementType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextElementType r_PelementType;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextElementType RPelementType
		{
			get
			{
				if(r_PelementType == null)
				{
					r_PelementType = new(this, "elementType", -1);
					r_PelementType.SetBelong(this.instance);
				}
				return r_PelementType;
			}
		}

		/// <summary>
		/// UInt32 unicode
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_Punicode;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RPunicode
		{
			get
			{
				if(r_Punicode == null)
				{
					r_Punicode = new(this, "unicode", -1);
					r_Punicode.SetBelong(this.instance);
				}
				return r_Punicode;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextAsset textAsset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAsset r_PtextAsset;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextAsset RPtextAsset
		{
			get
			{
				if(r_PtextAsset == null)
				{
					r_PtextAsset = new(this, "textAsset", -1);
					r_PtextAsset.SetBelong(this.instance);
				}
				return r_PtextAsset;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Glyph glyph
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RGlyph r_Pglyph;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RGlyph RPglyph
		{
			get
			{
				if(r_Pglyph == null)
				{
					r_Pglyph = new(this, "glyph", -1);
					r_Pglyph.SetBelong(this.instance);
				}
				return r_Pglyph;
			}
		}

		/// <summary>
		/// UInt32 glyphIndex
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_PglyphIndex;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RPglyphIndex
		{
			get
			{
				if(r_PglyphIndex == null)
				{
					r_PglyphIndex = new(this, "glyphIndex", -1);
					r_PglyphIndex.SetBelong(this.instance);
				}
				return r_PglyphIndex;
			}
		}

		/// <summary>
		/// Single scale
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_Pscale;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RPscale
		{
			get
			{
				if(r_Pscale == null)
				{
					r_Pscale = new(this, "scale", -1);
					r_Pscale.SetBelong(this.instance);
				}
				return r_Pscale;
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


        public RTextElement() : base("UnityEngine.TextCore.Text.TextElement")
        {
        }

        public RTextElement(System.Object instance) : base("UnityEngine.TextCore.Text.TextElement")
		{
            SetInstance(instance);
		}

        public RTextElement(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextElement(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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