using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.CharacterInfo
	/// </summary>
    public partial class RCharacterInfo : RMember //
    {

		/// <summary>
		/// System.Int32 index
		/// </summary>
		protected RSystem.RInt32 r_index;
		public virtual RSystem.RInt32 Rindex
		{
			get
			{
				if(r_index == null)
				{
					r_index = new(this, "index");
					r_index.SetBelong(this.instance);
				}
				return r_index;
			}
		}

		/// <summary>
		/// UnityEngine.Rect uv
		/// </summary>
		protected RUnityEngine.RRect r_uv;
		public virtual RUnityEngine.RRect Ruv
		{
			get
			{
				if(r_uv == null)
				{
					r_uv = new(this, "uv");
					r_uv.SetBelong(this.instance);
				}
				return r_uv;
			}
		}

		/// <summary>
		/// UnityEngine.Rect vert
		/// </summary>
		protected RUnityEngine.RRect r_vert;
		public virtual RUnityEngine.RRect Rvert
		{
			get
			{
				if(r_vert == null)
				{
					r_vert = new(this, "vert");
					r_vert.SetBelong(this.instance);
				}
				return r_vert;
			}
		}

		/// <summary>
		/// System.Single width
		/// </summary>
		protected RSystem.RSingle r_width;
		public virtual RSystem.RSingle Rwidth
		{
			get
			{
				if(r_width == null)
				{
					r_width = new(this, "width");
					r_width.SetBelong(this.instance);
				}
				return r_width;
			}
		}

		/// <summary>
		/// System.Int32 size
		/// </summary>
		protected RSystem.RInt32 r_size;
		public virtual RSystem.RInt32 Rsize
		{
			get
			{
				if(r_size == null)
				{
					r_size = new(this, "size");
					r_size.SetBelong(this.instance);
				}
				return r_size;
			}
		}

		/// <summary>
		/// UnityEngine.FontStyle style
		/// </summary>
		protected RField r_style;
		public virtual RField Rstyle
		{
			get
			{
				if(r_style == null)
				{
					r_style = new(this, "style");
					r_style.SetBelong(this.instance);
				}
				return r_style;
			}
		}

		/// <summary>
		/// System.Boolean flipped
		/// </summary>
		protected RSystem.RBoolean r_flipped;
		public virtual RSystem.RBoolean Rflipped
		{
			get
			{
				if(r_flipped == null)
				{
					r_flipped = new(this, "flipped");
					r_flipped.SetBelong(this.instance);
				}
				return r_flipped;
			}
		}

		/// <summary>
		/// Int32 advance
		/// </summary>
		protected RSystem.RInt32 r_advance;
		public virtual RSystem.RInt32 Radvance
		{
			get
			{
				if(r_advance == null)
				{
					r_advance = new(this, "advance", -1);
					r_advance.SetBelong(this.instance);
				}
				return r_advance;
			}
		}

		/// <summary>
		/// Int32 glyphWidth
		/// </summary>
		protected RSystem.RInt32 r_glyphWidth;
		public virtual RSystem.RInt32 RglyphWidth
		{
			get
			{
				if(r_glyphWidth == null)
				{
					r_glyphWidth = new(this, "glyphWidth", -1);
					r_glyphWidth.SetBelong(this.instance);
				}
				return r_glyphWidth;
			}
		}

		/// <summary>
		/// Int32 glyphHeight
		/// </summary>
		protected RSystem.RInt32 r_glyphHeight;
		public virtual RSystem.RInt32 RglyphHeight
		{
			get
			{
				if(r_glyphHeight == null)
				{
					r_glyphHeight = new(this, "glyphHeight", -1);
					r_glyphHeight.SetBelong(this.instance);
				}
				return r_glyphHeight;
			}
		}

		/// <summary>
		/// Int32 bearing
		/// </summary>
		protected RSystem.RInt32 r_bearing;
		public virtual RSystem.RInt32 Rbearing
		{
			get
			{
				if(r_bearing == null)
				{
					r_bearing = new(this, "bearing", -1);
					r_bearing.SetBelong(this.instance);
				}
				return r_bearing;
			}
		}

		/// <summary>
		/// Int32 minY
		/// </summary>
		protected RSystem.RInt32 r_minY;
		public virtual RSystem.RInt32 RminY
		{
			get
			{
				if(r_minY == null)
				{
					r_minY = new(this, "minY", -1);
					r_minY.SetBelong(this.instance);
				}
				return r_minY;
			}
		}

		/// <summary>
		/// Int32 maxY
		/// </summary>
		protected RSystem.RInt32 r_maxY;
		public virtual RSystem.RInt32 RmaxY
		{
			get
			{
				if(r_maxY == null)
				{
					r_maxY = new(this, "maxY", -1);
					r_maxY.SetBelong(this.instance);
				}
				return r_maxY;
			}
		}

		/// <summary>
		/// Int32 minX
		/// </summary>
		protected RSystem.RInt32 r_minX;
		public virtual RSystem.RInt32 RminX
		{
			get
			{
				if(r_minX == null)
				{
					r_minX = new(this, "minX", -1);
					r_minX.SetBelong(this.instance);
				}
				return r_minX;
			}
		}

		/// <summary>
		/// Int32 maxX
		/// </summary>
		protected RSystem.RInt32 r_maxX;
		public virtual RSystem.RInt32 RmaxX
		{
			get
			{
				if(r_maxX == null)
				{
					r_maxX = new(this, "maxX", -1);
					r_maxX.SetBelong(this.instance);
				}
				return r_maxX;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 uvBottomLeftUnFlipped
		/// </summary>
		protected RUnityEngine.RVector2 r_uvBottomLeftUnFlipped;
		public virtual RUnityEngine.RVector2 RuvBottomLeftUnFlipped
		{
			get
			{
				if(r_uvBottomLeftUnFlipped == null)
				{
					r_uvBottomLeftUnFlipped = new(this, "uvBottomLeftUnFlipped", -1);
					r_uvBottomLeftUnFlipped.SetBelong(this.instance);
				}
				return r_uvBottomLeftUnFlipped;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 uvBottomRightUnFlipped
		/// </summary>
		protected RUnityEngine.RVector2 r_uvBottomRightUnFlipped;
		public virtual RUnityEngine.RVector2 RuvBottomRightUnFlipped
		{
			get
			{
				if(r_uvBottomRightUnFlipped == null)
				{
					r_uvBottomRightUnFlipped = new(this, "uvBottomRightUnFlipped", -1);
					r_uvBottomRightUnFlipped.SetBelong(this.instance);
				}
				return r_uvBottomRightUnFlipped;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 uvTopRightUnFlipped
		/// </summary>
		protected RUnityEngine.RVector2 r_uvTopRightUnFlipped;
		public virtual RUnityEngine.RVector2 RuvTopRightUnFlipped
		{
			get
			{
				if(r_uvTopRightUnFlipped == null)
				{
					r_uvTopRightUnFlipped = new(this, "uvTopRightUnFlipped", -1);
					r_uvTopRightUnFlipped.SetBelong(this.instance);
				}
				return r_uvTopRightUnFlipped;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 uvTopLeftUnFlipped
		/// </summary>
		protected RUnityEngine.RVector2 r_uvTopLeftUnFlipped;
		public virtual RUnityEngine.RVector2 RuvTopLeftUnFlipped
		{
			get
			{
				if(r_uvTopLeftUnFlipped == null)
				{
					r_uvTopLeftUnFlipped = new(this, "uvTopLeftUnFlipped", -1);
					r_uvTopLeftUnFlipped.SetBelong(this.instance);
				}
				return r_uvTopLeftUnFlipped;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 uvBottomLeft
		/// </summary>
		protected RUnityEngine.RVector2 r_uvBottomLeft;
		public virtual RUnityEngine.RVector2 RuvBottomLeft
		{
			get
			{
				if(r_uvBottomLeft == null)
				{
					r_uvBottomLeft = new(this, "uvBottomLeft", -1);
					r_uvBottomLeft.SetBelong(this.instance);
				}
				return r_uvBottomLeft;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 uvBottomRight
		/// </summary>
		protected RUnityEngine.RVector2 r_uvBottomRight;
		public virtual RUnityEngine.RVector2 RuvBottomRight
		{
			get
			{
				if(r_uvBottomRight == null)
				{
					r_uvBottomRight = new(this, "uvBottomRight", -1);
					r_uvBottomRight.SetBelong(this.instance);
				}
				return r_uvBottomRight;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 uvTopRight
		/// </summary>
		protected RUnityEngine.RVector2 r_uvTopRight;
		public virtual RUnityEngine.RVector2 RuvTopRight
		{
			get
			{
				if(r_uvTopRight == null)
				{
					r_uvTopRight = new(this, "uvTopRight", -1);
					r_uvTopRight.SetBelong(this.instance);
				}
				return r_uvTopRight;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 uvTopLeft
		/// </summary>
		protected RUnityEngine.RVector2 r_uvTopLeft;
		public virtual RUnityEngine.RVector2 RuvTopLeft
		{
			get
			{
				if(r_uvTopLeft == null)
				{
					r_uvTopLeft = new(this, "uvTopLeft", -1);
					r_uvTopLeft.SetBelong(this.instance);
				}
				return r_uvTopLeft;
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

        public virtual System.Boolean Equals(System.Object @obj)
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
