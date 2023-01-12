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
		protected RUnityEngine.RRect r_Frect;
		public virtual RUnityEngine.RRect RFrect
		{
			get
			{
				if(r_Frect == null)
				{
					r_Frect = new(this, "rect");
					r_Frect.SetBelong(this.instance);
				}
				return r_Frect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect subRect
		/// </summary>
		protected RUnityEngine.RRect r_FsubRect;
		public virtual RUnityEngine.RRect RFsubRect
		{
			get
			{
				if(r_FsubRect == null)
				{
					r_FsubRect = new(this, "subRect");
					r_FsubRect.SetBelong(this.instance);
				}
				return r_FsubRect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect uv
		/// </summary>
		protected RUnityEngine.RRect r_Fuv;
		public virtual RUnityEngine.RRect RFuv
		{
			get
			{
				if(r_Fuv == null)
				{
					r_Fuv = new(this, "uv");
					r_Fuv.SetBelong(this.instance);
				}
				return r_Fuv;
			}
		}

		/// <summary>
		/// UnityEngine.Rect uvRegion
		/// </summary>
		protected RUnityEngine.RRect r_FuvRegion;
		public virtual RUnityEngine.RRect RFuvRegion
		{
			get
			{
				if(r_FuvRegion == null)
				{
					r_FuvRegion = new(this, "uvRegion");
					r_FuvRegion.SetBelong(this.instance);
				}
				return r_FuvRegion;
			}
		}

		/// <summary>
		/// UnityEngine.Color color
		/// </summary>
		protected RUnityEngine.RColor r_Fcolor;
		public virtual RUnityEngine.RColor RFcolor
		{
			get
			{
				if(r_Fcolor == null)
				{
					r_Fcolor = new(this, "color");
					r_Fcolor.SetBelong(this.instance);
				}
				return r_Fcolor;
			}
		}

		/// <summary>
		/// UnityEngine.ScaleMode scaleMode
		/// </summary>
		protected RUnityEngine.RScaleMode r_FscaleMode;
		public virtual RUnityEngine.RScaleMode RFscaleMode
		{
			get
			{
				if(r_FscaleMode == null)
				{
					r_FscaleMode = new(this, "scaleMode");
					r_FscaleMode.SetBelong(this.instance);
				}
				return r_FscaleMode;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 topLeftRadius
		/// </summary>
		protected RUnityEngine.RVector2 r_FtopLeftRadius;
		public virtual RUnityEngine.RVector2 RFtopLeftRadius
		{
			get
			{
				if(r_FtopLeftRadius == null)
				{
					r_FtopLeftRadius = new(this, "topLeftRadius");
					r_FtopLeftRadius.SetBelong(this.instance);
				}
				return r_FtopLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 topRightRadius
		/// </summary>
		protected RUnityEngine.RVector2 r_FtopRightRadius;
		public virtual RUnityEngine.RVector2 RFtopRightRadius
		{
			get
			{
				if(r_FtopRightRadius == null)
				{
					r_FtopRightRadius = new(this, "topRightRadius");
					r_FtopRightRadius.SetBelong(this.instance);
				}
				return r_FtopRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 bottomRightRadius
		/// </summary>
		protected RUnityEngine.RVector2 r_FbottomRightRadius;
		public virtual RUnityEngine.RVector2 RFbottomRightRadius
		{
			get
			{
				if(r_FbottomRightRadius == null)
				{
					r_FbottomRightRadius = new(this, "bottomRightRadius");
					r_FbottomRightRadius.SetBelong(this.instance);
				}
				return r_FbottomRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 bottomLeftRadius
		/// </summary>
		protected RUnityEngine.RVector2 r_FbottomLeftRadius;
		public virtual RUnityEngine.RVector2 RFbottomLeftRadius
		{
			get
			{
				if(r_FbottomLeftRadius == null)
				{
					r_FbottomLeftRadius = new(this, "bottomLeftRadius");
					r_FbottomLeftRadius.SetBelong(this.instance);
				}
				return r_FbottomLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 contentSize
		/// </summary>
		protected RUnityEngine.RVector2 r_FcontentSize;
		public virtual RUnityEngine.RVector2 RFcontentSize
		{
			get
			{
				if(r_FcontentSize == null)
				{
					r_FcontentSize = new(this, "contentSize");
					r_FcontentSize.SetBelong(this.instance);
				}
				return r_FcontentSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 textureSize
		/// </summary>
		protected RUnityEngine.RVector2 r_FtextureSize;
		public virtual RUnityEngine.RVector2 RFtextureSize
		{
			get
			{
				if(r_FtextureSize == null)
				{
					r_FtextureSize = new(this, "textureSize");
					r_FtextureSize.SetBelong(this.instance);
				}
				return r_FtextureSize;
			}
		}

		/// <summary>
		/// System.Single texturePixelsPerPoint
		/// </summary>
		protected RSystem.RSingle r_FtexturePixelsPerPoint;
		public virtual RSystem.RSingle RFtexturePixelsPerPoint
		{
			get
			{
				if(r_FtexturePixelsPerPoint == null)
				{
					r_FtexturePixelsPerPoint = new(this, "texturePixelsPerPoint");
					r_FtexturePixelsPerPoint.SetBelong(this.instance);
				}
				return r_FtexturePixelsPerPoint;
			}
		}

		/// <summary>
		/// System.Int32 leftSlice
		/// </summary>
		protected RSystem.RInt32 r_FleftSlice;
		public virtual RSystem.RInt32 RFleftSlice
		{
			get
			{
				if(r_FleftSlice == null)
				{
					r_FleftSlice = new(this, "leftSlice");
					r_FleftSlice.SetBelong(this.instance);
				}
				return r_FleftSlice;
			}
		}

		/// <summary>
		/// System.Int32 topSlice
		/// </summary>
		protected RSystem.RInt32 r_FtopSlice;
		public virtual RSystem.RInt32 RFtopSlice
		{
			get
			{
				if(r_FtopSlice == null)
				{
					r_FtopSlice = new(this, "topSlice");
					r_FtopSlice.SetBelong(this.instance);
				}
				return r_FtopSlice;
			}
		}

		/// <summary>
		/// System.Int32 rightSlice
		/// </summary>
		protected RSystem.RInt32 r_FrightSlice;
		public virtual RSystem.RInt32 RFrightSlice
		{
			get
			{
				if(r_FrightSlice == null)
				{
					r_FrightSlice = new(this, "rightSlice");
					r_FrightSlice.SetBelong(this.instance);
				}
				return r_FrightSlice;
			}
		}

		/// <summary>
		/// System.Int32 bottomSlice
		/// </summary>
		protected RSystem.RInt32 r_FbottomSlice;
		public virtual RSystem.RInt32 RFbottomSlice
		{
			get
			{
				if(r_FbottomSlice == null)
				{
					r_FbottomSlice = new(this, "bottomSlice");
					r_FbottomSlice.SetBelong(this.instance);
				}
				return r_FbottomSlice;
			}
		}

		/// <summary>
		/// System.Single sliceScale
		/// </summary>
		protected RSystem.RSingle r_FsliceScale;
		public virtual RSystem.RSingle RFsliceScale
		{
			get
			{
				if(r_FsliceScale == null)
				{
					r_FsliceScale = new(this, "sliceScale");
					r_FsliceScale.SetBelong(this.instance);
				}
				return r_FsliceScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshBuilderNative+NativeColorPage colorPage
		/// </summary>
		protected RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage r_FcolorPage;
		public virtual RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage RFcolorPage
		{
			get
			{
				if(r_FcolorPage == null)
				{
					r_FcolorPage = new(this, "colorPage");
					r_FcolorPage.SetBelong(this.instance);
				}
				return r_FcolorPage;
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
}