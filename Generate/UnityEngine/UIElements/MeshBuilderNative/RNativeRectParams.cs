using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class RMeshBuilderNative
{
	
	/// <summary>
	/// UnityEngine.UIElements.MeshBuilderNative+NativeRectParams
	/// </summary>
    public partial class RNativeRectParams : RMember //
    {

		/// <summary>
		/// UnityEngine.Rect rect
		/// </summary>
		protected RUnityEngine.RRect r_rect;
		public virtual RUnityEngine.RRect Rrect
		{
			get
			{
				if(r_rect == null)
				{
					r_rect = new(this, "rect");
					r_rect.SetBelong(this.instance);
				}
				return r_rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect subRect
		/// </summary>
		protected RUnityEngine.RRect r_subRect;
		public virtual RUnityEngine.RRect RsubRect
		{
			get
			{
				if(r_subRect == null)
				{
					r_subRect = new(this, "subRect");
					r_subRect.SetBelong(this.instance);
				}
				return r_subRect;
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
		/// UnityEngine.Rect uvRegion
		/// </summary>
		protected RUnityEngine.RRect r_uvRegion;
		public virtual RUnityEngine.RRect RuvRegion
		{
			get
			{
				if(r_uvRegion == null)
				{
					r_uvRegion = new(this, "uvRegion");
					r_uvRegion.SetBelong(this.instance);
				}
				return r_uvRegion;
			}
		}

		/// <summary>
		/// UnityEngine.Color color
		/// </summary>
		protected RUnityEngine.RColor r_color;
		public virtual RUnityEngine.RColor Rcolor
		{
			get
			{
				if(r_color == null)
				{
					r_color = new(this, "color");
					r_color.SetBelong(this.instance);
				}
				return r_color;
			}
		}

		/// <summary>
		/// UnityEngine.ScaleMode scaleMode
		/// </summary>
		protected RField r_scaleMode;
		public virtual RField RscaleMode
		{
			get
			{
				if(r_scaleMode == null)
				{
					r_scaleMode = new(this, "scaleMode");
					r_scaleMode.SetBelong(this.instance);
				}
				return r_scaleMode;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 topLeftRadius
		/// </summary>
		protected RUnityEngine.RVector2 r_topLeftRadius;
		public virtual RUnityEngine.RVector2 RtopLeftRadius
		{
			get
			{
				if(r_topLeftRadius == null)
				{
					r_topLeftRadius = new(this, "topLeftRadius");
					r_topLeftRadius.SetBelong(this.instance);
				}
				return r_topLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 topRightRadius
		/// </summary>
		protected RUnityEngine.RVector2 r_topRightRadius;
		public virtual RUnityEngine.RVector2 RtopRightRadius
		{
			get
			{
				if(r_topRightRadius == null)
				{
					r_topRightRadius = new(this, "topRightRadius");
					r_topRightRadius.SetBelong(this.instance);
				}
				return r_topRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 bottomRightRadius
		/// </summary>
		protected RUnityEngine.RVector2 r_bottomRightRadius;
		public virtual RUnityEngine.RVector2 RbottomRightRadius
		{
			get
			{
				if(r_bottomRightRadius == null)
				{
					r_bottomRightRadius = new(this, "bottomRightRadius");
					r_bottomRightRadius.SetBelong(this.instance);
				}
				return r_bottomRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 bottomLeftRadius
		/// </summary>
		protected RUnityEngine.RVector2 r_bottomLeftRadius;
		public virtual RUnityEngine.RVector2 RbottomLeftRadius
		{
			get
			{
				if(r_bottomLeftRadius == null)
				{
					r_bottomLeftRadius = new(this, "bottomLeftRadius");
					r_bottomLeftRadius.SetBelong(this.instance);
				}
				return r_bottomLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 contentSize
		/// </summary>
		protected RUnityEngine.RVector2 r_contentSize;
		public virtual RUnityEngine.RVector2 RcontentSize
		{
			get
			{
				if(r_contentSize == null)
				{
					r_contentSize = new(this, "contentSize");
					r_contentSize.SetBelong(this.instance);
				}
				return r_contentSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 textureSize
		/// </summary>
		protected RUnityEngine.RVector2 r_textureSize;
		public virtual RUnityEngine.RVector2 RtextureSize
		{
			get
			{
				if(r_textureSize == null)
				{
					r_textureSize = new(this, "textureSize");
					r_textureSize.SetBelong(this.instance);
				}
				return r_textureSize;
			}
		}

		/// <summary>
		/// System.Single texturePixelsPerPoint
		/// </summary>
		protected RField r_texturePixelsPerPoint;
		public virtual RField RtexturePixelsPerPoint
		{
			get
			{
				if(r_texturePixelsPerPoint == null)
				{
					r_texturePixelsPerPoint = new(this, "texturePixelsPerPoint");
					r_texturePixelsPerPoint.SetBelong(this.instance);
				}
				return r_texturePixelsPerPoint;
			}
		}

		/// <summary>
		/// System.Int32 leftSlice
		/// </summary>
		protected RField r_leftSlice;
		public virtual RField RleftSlice
		{
			get
			{
				if(r_leftSlice == null)
				{
					r_leftSlice = new(this, "leftSlice");
					r_leftSlice.SetBelong(this.instance);
				}
				return r_leftSlice;
			}
		}

		/// <summary>
		/// System.Int32 topSlice
		/// </summary>
		protected RField r_topSlice;
		public virtual RField RtopSlice
		{
			get
			{
				if(r_topSlice == null)
				{
					r_topSlice = new(this, "topSlice");
					r_topSlice.SetBelong(this.instance);
				}
				return r_topSlice;
			}
		}

		/// <summary>
		/// System.Int32 rightSlice
		/// </summary>
		protected RField r_rightSlice;
		public virtual RField RrightSlice
		{
			get
			{
				if(r_rightSlice == null)
				{
					r_rightSlice = new(this, "rightSlice");
					r_rightSlice.SetBelong(this.instance);
				}
				return r_rightSlice;
			}
		}

		/// <summary>
		/// System.Int32 bottomSlice
		/// </summary>
		protected RField r_bottomSlice;
		public virtual RField RbottomSlice
		{
			get
			{
				if(r_bottomSlice == null)
				{
					r_bottomSlice = new(this, "bottomSlice");
					r_bottomSlice.SetBelong(this.instance);
				}
				return r_bottomSlice;
			}
		}

		/// <summary>
		/// System.Single sliceScale
		/// </summary>
		protected RField r_sliceScale;
		public virtual RField RsliceScale
		{
			get
			{
				if(r_sliceScale == null)
				{
					r_sliceScale = new(this, "sliceScale");
					r_sliceScale.SetBelong(this.instance);
				}
				return r_sliceScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshBuilderNative+NativeColorPage colorPage
		/// </summary>
		protected RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage r_colorPage;
		public virtual RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage RcolorPage
		{
			get
			{
				if(r_colorPage == null)
				{
					r_colorPage = new(this, "colorPage");
					r_colorPage.SetBelong(this.instance);
				}
				return r_colorPage;
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


        public RNativeRectParams() : base("UnityEngine.UIElements.MeshBuilderNative+NativeRectParams")
        {
        }

        public RNativeRectParams(System.Object instance) : base("UnityEngine.UIElements.MeshBuilderNative+NativeRectParams")
		{
            SetInstance(instance);
		}

        public RNativeRectParams(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNativeRectParams(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
}