
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.CharacterInfo
	/// </summary>
    public partial class RCharacterInfo : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.CharacterInfo);
            }
        }

        public RCharacterInfo() : base("UnityEngine.CharacterInfo")
        {
        }

        public RCharacterInfo(System.Object instance) : base("UnityEngine.CharacterInfo")
		{
            SetInstance(instance);
		}

        public RCharacterInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCharacterInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 index
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Findex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFindex
		{
			get
			{
				if(r_Findex == null)
				{
					r_Findex = new(this, "index");
				}
				return r_Findex;
			}
		}

		/// <summary>
		/// UnityEngine.Rect uv
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Fuv;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFuv
		{
			get
			{
				if(r_Fuv == null)
				{
					r_Fuv = new(this, "uv");
				}
				return r_Fuv;
			}
		}

		/// <summary>
		/// UnityEngine.Rect vert
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Fvert;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFvert
		{
			get
			{
				if(r_Fvert == null)
				{
					r_Fvert = new(this, "vert");
				}
				return r_Fvert;
			}
		}

		/// <summary>
		/// System.Single width
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fwidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFwidth
		{
			get
			{
				if(r_Fwidth == null)
				{
					r_Fwidth = new(this, "width");
				}
				return r_Fwidth;
			}
		}

		/// <summary>
		/// System.Int32 size
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fsize;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFsize
		{
			get
			{
				if(r_Fsize == null)
				{
					r_Fsize = new(this, "size");
				}
				return r_Fsize;
			}
		}

		/// <summary>
		/// UnityEngine.FontStyle style
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RFontStyle r_Fstyle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RFontStyle RFstyle
		{
			get
			{
				if(r_Fstyle == null)
				{
					r_Fstyle = new(this, "style");
				}
				return r_Fstyle;
			}
		}

		/// <summary>
		/// System.Boolean flipped
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fflipped;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFflipped
		{
			get
			{
				if(r_Fflipped == null)
				{
					r_Fflipped = new(this, "flipped");
				}
				return r_Fflipped;
			}
		}

		/// <summary>
		/// Int32 advance
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Padvance;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPadvance
		{
			get
			{
				if(r_Padvance == null)
				{
					r_Padvance = new(this, "advance", -1);
				}
				return r_Padvance;
			}
		}

		/// <summary>
		/// Int32 glyphWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PglyphWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPglyphWidth
		{
			get
			{
				if(r_PglyphWidth == null)
				{
					r_PglyphWidth = new(this, "glyphWidth", -1);
				}
				return r_PglyphWidth;
			}
		}

		/// <summary>
		/// Int32 glyphHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PglyphHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPglyphHeight
		{
			get
			{
				if(r_PglyphHeight == null)
				{
					r_PglyphHeight = new(this, "glyphHeight", -1);
				}
				return r_PglyphHeight;
			}
		}

		/// <summary>
		/// Int32 bearing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pbearing;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPbearing
		{
			get
			{
				if(r_Pbearing == null)
				{
					r_Pbearing = new(this, "bearing", -1);
				}
				return r_Pbearing;
			}
		}

		/// <summary>
		/// Int32 minY
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PminY;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPminY
		{
			get
			{
				if(r_PminY == null)
				{
					r_PminY = new(this, "minY", -1);
				}
				return r_PminY;
			}
		}

		/// <summary>
		/// Int32 maxY
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PmaxY;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPmaxY
		{
			get
			{
				if(r_PmaxY == null)
				{
					r_PmaxY = new(this, "maxY", -1);
				}
				return r_PmaxY;
			}
		}

		/// <summary>
		/// Int32 minX
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PminX;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPminX
		{
			get
			{
				if(r_PminX == null)
				{
					r_PminX = new(this, "minX", -1);
				}
				return r_PminX;
			}
		}

		/// <summary>
		/// Int32 maxX
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PmaxX;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPmaxX
		{
			get
			{
				if(r_PmaxX == null)
				{
					r_PmaxX = new(this, "maxX", -1);
				}
				return r_PmaxX;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 uvBottomLeftUnFlipped
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PuvBottomLeftUnFlipped;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPuvBottomLeftUnFlipped
		{
			get
			{
				if(r_PuvBottomLeftUnFlipped == null)
				{
					r_PuvBottomLeftUnFlipped = new(this, "uvBottomLeftUnFlipped", -1);
				}
				return r_PuvBottomLeftUnFlipped;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 uvBottomRightUnFlipped
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PuvBottomRightUnFlipped;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPuvBottomRightUnFlipped
		{
			get
			{
				if(r_PuvBottomRightUnFlipped == null)
				{
					r_PuvBottomRightUnFlipped = new(this, "uvBottomRightUnFlipped", -1);
				}
				return r_PuvBottomRightUnFlipped;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 uvTopRightUnFlipped
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PuvTopRightUnFlipped;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPuvTopRightUnFlipped
		{
			get
			{
				if(r_PuvTopRightUnFlipped == null)
				{
					r_PuvTopRightUnFlipped = new(this, "uvTopRightUnFlipped", -1);
				}
				return r_PuvTopRightUnFlipped;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 uvTopLeftUnFlipped
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PuvTopLeftUnFlipped;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPuvTopLeftUnFlipped
		{
			get
			{
				if(r_PuvTopLeftUnFlipped == null)
				{
					r_PuvTopLeftUnFlipped = new(this, "uvTopLeftUnFlipped", -1);
				}
				return r_PuvTopLeftUnFlipped;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 uvBottomLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PuvBottomLeft;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPuvBottomLeft
		{
			get
			{
				if(r_PuvBottomLeft == null)
				{
					r_PuvBottomLeft = new(this, "uvBottomLeft", -1);
				}
				return r_PuvBottomLeft;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 uvBottomRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PuvBottomRight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPuvBottomRight
		{
			get
			{
				if(r_PuvBottomRight == null)
				{
					r_PuvBottomRight = new(this, "uvBottomRight", -1);
				}
				return r_PuvBottomRight;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 uvTopRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PuvTopRight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPuvTopRight
		{
			get
			{
				if(r_PuvTopRight == null)
				{
					r_PuvTopRight = new(this, "uvTopRight", -1);
				}
				return r_PuvTopRight;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 uvTopLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PuvTopLeft;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPuvTopLeft
		{
			get
			{
				if(r_PuvTopLeft == null)
				{
					r_PuvTopLeft = new(this, "uvTopLeft", -1);
				}
				return r_PuvTopLeft;
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
