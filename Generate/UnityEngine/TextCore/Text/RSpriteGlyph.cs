using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.SpriteGlyph
	/// </summary>
    public partial class RSpriteGlyph : RMember //
    {

		/// <summary>
		/// UnityEngine.Sprite sprite
		/// </summary>
		protected RUnityEngine.RSprite r_sprite;
		public virtual RUnityEngine.RSprite Rsprite
		{
			get
			{
				if(r_sprite == null)
				{
					r_sprite = new(this, "sprite");
					r_sprite.SetBelong(this.instance);
				}
				return r_sprite;
			}
		}

		/// <summary>
		/// UInt32 index
		/// </summary>
		protected RProperty r_index;
		public virtual RProperty Rindex
		{
			get
			{
				if(r_index == null)
				{
					r_index = new(this, "index", -1);
					r_index.SetBelong(this.instance);
				}
				return r_index;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.GlyphMetrics metrics
		/// </summary>
		protected RUnityEngine.RTextCore.RGlyphMetrics r_metrics;
		public virtual RUnityEngine.RTextCore.RGlyphMetrics Rmetrics
		{
			get
			{
				if(r_metrics == null)
				{
					r_metrics = new(this, "metrics", -1);
					r_metrics.SetBelong(this.instance);
				}
				return r_metrics;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.GlyphRect glyphRect
		/// </summary>
		protected RUnityEngine.RTextCore.RGlyphRect r_glyphRect;
		public virtual RUnityEngine.RTextCore.RGlyphRect RglyphRect
		{
			get
			{
				if(r_glyphRect == null)
				{
					r_glyphRect = new(this, "glyphRect", -1);
					r_glyphRect.SetBelong(this.instance);
				}
				return r_glyphRect;
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
		/// Int32 atlasIndex
		/// </summary>
		protected RProperty r_atlasIndex;
		public virtual RProperty RatlasIndex
		{
			get
			{
				if(r_atlasIndex == null)
				{
					r_atlasIndex = new(this, "atlasIndex", -1);
					r_atlasIndex.SetBelong(this.instance);
				}
				return r_atlasIndex;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.GlyphClassDefinitionType classDefinitionType
		/// </summary>
		protected RProperty r_classDefinitionType;
		public virtual RProperty RclassDefinitionType
		{
			get
			{
				if(r_classDefinitionType == null)
				{
					r_classDefinitionType = new(this, "classDefinitionType", -1);
					r_classDefinitionType.SetBelong(this.instance);
				}
				return r_classDefinitionType;
			}
		}

		/// <summary>
		/// Boolean Compare(UnityEngine.TextCore.Glyph)
		/// </summary>
		protected RMethod r_Compare_Glyph;
		public virtual RMethod RCompare_Glyph
		{
			get
			{
				if(r_Compare_Glyph == null)
				{
					r_Compare_Glyph = new(this, "Compare", 0, typeof(UnityEngine.TextCore.Glyph));
					r_Compare_Glyph.SetBelong(this.instance);
				}
				return r_Compare_Glyph;
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


        public RSpriteGlyph() : base("UnityEngine.TextCore.Text.SpriteGlyph")
        {
        }

        public RSpriteGlyph(System.Object instance) : base("UnityEngine.TextCore.Text.SpriteGlyph")
		{
            SetInstance(instance);
		}

        public RSpriteGlyph(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSpriteGlyph(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Compare(UnityEngine.TextCore.Glyph @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RCompare_Glyph.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
