
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore
{
	/// <summary>
	/// UnityEngine.TextCore.Glyph
	/// </summary>
    public partial class RGlyph : RMember //
    {

		/// <summary>
		/// System.UInt32 m_Index
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fm_Index;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFm_Index
		{
			get
			{
				if(r_Fm_Index == null)
				{
					r_Fm_Index = new(this, "m_Index");
					r_Fm_Index.SetBelong(this.instance);
				}
				return r_Fm_Index;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.GlyphMetrics m_Metrics
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphMetrics r_Fm_Metrics;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphMetrics RFm_Metrics
		{
			get
			{
				if(r_Fm_Metrics == null)
				{
					r_Fm_Metrics = new(this, "m_Metrics");
					r_Fm_Metrics.SetBelong(this.instance);
				}
				return r_Fm_Metrics;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.GlyphRect m_GlyphRect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphRect r_Fm_GlyphRect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphRect RFm_GlyphRect
		{
			get
			{
				if(r_Fm_GlyphRect == null)
				{
					r_Fm_GlyphRect = new(this, "m_GlyphRect");
					r_Fm_GlyphRect.SetBelong(this.instance);
				}
				return r_Fm_GlyphRect;
			}
		}

		/// <summary>
		/// System.Single m_Scale
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Scale;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Scale
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
		/// System.Int32 m_AtlasIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_AtlasIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_AtlasIndex
		{
			get
			{
				if(r_Fm_AtlasIndex == null)
				{
					r_Fm_AtlasIndex = new(this, "m_AtlasIndex");
					r_Fm_AtlasIndex.SetBelong(this.instance);
				}
				return r_Fm_AtlasIndex;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.GlyphClassDefinitionType m_ClassDefinitionType
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphClassDefinitionType r_Fm_ClassDefinitionType;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphClassDefinitionType RFm_ClassDefinitionType
		{
			get
			{
				if(r_Fm_ClassDefinitionType == null)
				{
					r_Fm_ClassDefinitionType = new(this, "m_ClassDefinitionType");
					r_Fm_ClassDefinitionType.SetBelong(this.instance);
				}
				return r_Fm_ClassDefinitionType;
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
					r_Pindex.SetBelong(this.instance);
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
					r_Pmetrics.SetBelong(this.instance);
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
					r_PglyphRect.SetBelong(this.instance);
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
					r_Pscale.SetBelong(this.instance);
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
					r_PatlasIndex.SetBelong(this.instance);
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
					r_PclassDefinitionType.SetBelong(this.instance);
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
					r_MCompare_Glyph.SetBelong(this.instance);
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


        public RGlyph() : base("UnityEngine.TextCore.Glyph")
        {
        }

        public RGlyph(System.Object instance) : base("UnityEngine.TextCore.Glyph")
		{
            SetInstance(instance);
		}

        public RGlyph(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGlyph(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
