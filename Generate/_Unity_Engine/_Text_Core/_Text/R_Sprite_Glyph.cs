
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.SpriteGlyph
	/// </summary>
    public partial class RSpriteGlyph : RMember //
    {

		/// <summary>
		/// UnityEngine.Sprite sprite
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RSprite r_Fsprite;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RSprite RFsprite
		{
			get
			{
				if(r_Fsprite == null)
				{
					r_Fsprite = new(this, "sprite");
				}
				return r_Fsprite;
			}
		}

		/// <summary>
		/// UInt32 index
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Pindex;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPindex
		{
			get
			{
				if(r_Pindex == null)
				{
					r_Pindex = new(this, "index", -1);
				}
				return r_Pindex;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.GlyphMetrics metrics
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphMetrics r_Pmetrics;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphMetrics RPmetrics
		{
			get
			{
				if(r_Pmetrics == null)
				{
					r_Pmetrics = new(this, "metrics", -1);
				}
				return r_Pmetrics;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.GlyphRect glyphRect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphRect r_PglyphRect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphRect RPglyphRect
		{
			get
			{
				if(r_PglyphRect == null)
				{
					r_PglyphRect = new(this, "glyphRect", -1);
				}
				return r_PglyphRect;
			}
		}

		/// <summary>
		/// Single scale
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pscale;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPscale
		{
			get
			{
				if(r_Pscale == null)
				{
					r_Pscale = new(this, "scale", -1);
				}
				return r_Pscale;
			}
		}

		/// <summary>
		/// Int32 atlasIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PatlasIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPatlasIndex
		{
			get
			{
				if(r_PatlasIndex == null)
				{
					r_PatlasIndex = new(this, "atlasIndex", -1);
				}
				return r_PatlasIndex;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.GlyphClassDefinitionType classDefinitionType
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphClassDefinitionType r_PclassDefinitionType;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphClassDefinitionType RPclassDefinitionType
		{
			get
			{
				if(r_PclassDefinitionType == null)
				{
					r_PclassDefinitionType = new(this, "classDefinitionType", -1);
				}
				return r_PclassDefinitionType;
			}
		}

		/// <summary>
		/// Boolean Compare(UnityEngine.TextCore.Glyph)
		/// </summary>
		protected RMethod r_MCompare_Glyph;
		public virtual RMethod RMCompare_Glyph
		{
			get
			{
				if(r_MCompare_Glyph == null)
				{
					r_MCompare_Glyph = new(this, "Compare", 0, typeof(UnityEngine.TextCore.Glyph));
				}
				return r_MCompare_Glyph;
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
            var ___result = RMCompare_Glyph.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
