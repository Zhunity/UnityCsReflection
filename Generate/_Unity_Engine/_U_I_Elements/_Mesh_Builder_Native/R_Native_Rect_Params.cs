
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class RMeshBuilderNative
{
	
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.MeshBuilderNative+NativeRectParams
	/// </summary>
    public partial class RNativeRectParams : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.MeshBuilderNative+NativeRectParams");
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


		/// <summary>
		/// UnityEngine.Rect rect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Frect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFrect
		{
			get
			{
				if(r_Frect == null)
				{
					r_Frect = new(this, "rect");
				}
				return r_Frect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect subRect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_FsubRect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFsubRect
		{
			get
			{
				if(r_FsubRect == null)
				{
					r_FsubRect = new(this, "subRect");
				}
				return r_FsubRect;
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
		/// UnityEngine.Rect uvRegion
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_FuvRegion;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFuvRegion
		{
			get
			{
				if(r_FuvRegion == null)
				{
					r_FuvRegion = new(this, "uvRegion");
				}
				return r_FuvRegion;
			}
		}

		/// <summary>
		/// UnityEngine.Color color
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_Fcolor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFcolor
		{
			get
			{
				if(r_Fcolor == null)
				{
					r_Fcolor = new(this, "color");
				}
				return r_Fcolor;
			}
		}

		/// <summary>
		/// UnityEngine.ScaleMode scaleMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RScaleMode r_FscaleMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RScaleMode RFscaleMode
		{
			get
			{
				if(r_FscaleMode == null)
				{
					r_FscaleMode = new(this, "scaleMode");
				}
				return r_FscaleMode;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 topLeftRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FtopLeftRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFtopLeftRadius
		{
			get
			{
				if(r_FtopLeftRadius == null)
				{
					r_FtopLeftRadius = new(this, "topLeftRadius");
				}
				return r_FtopLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 topRightRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FtopRightRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFtopRightRadius
		{
			get
			{
				if(r_FtopRightRadius == null)
				{
					r_FtopRightRadius = new(this, "topRightRadius");
				}
				return r_FtopRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 bottomRightRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FbottomRightRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFbottomRightRadius
		{
			get
			{
				if(r_FbottomRightRadius == null)
				{
					r_FbottomRightRadius = new(this, "bottomRightRadius");
				}
				return r_FbottomRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 bottomLeftRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FbottomLeftRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFbottomLeftRadius
		{
			get
			{
				if(r_FbottomLeftRadius == null)
				{
					r_FbottomLeftRadius = new(this, "bottomLeftRadius");
				}
				return r_FbottomLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 contentSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FcontentSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFcontentSize
		{
			get
			{
				if(r_FcontentSize == null)
				{
					r_FcontentSize = new(this, "contentSize");
				}
				return r_FcontentSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 textureSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_FtextureSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RFtextureSize
		{
			get
			{
				if(r_FtextureSize == null)
				{
					r_FtextureSize = new(this, "textureSize");
				}
				return r_FtextureSize;
			}
		}

		/// <summary>
		/// System.Single texturePixelsPerPoint
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FtexturePixelsPerPoint;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFtexturePixelsPerPoint
		{
			get
			{
				if(r_FtexturePixelsPerPoint == null)
				{
					r_FtexturePixelsPerPoint = new(this, "texturePixelsPerPoint");
				}
				return r_FtexturePixelsPerPoint;
			}
		}

		/// <summary>
		/// System.Int32 leftSlice
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FleftSlice;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFleftSlice
		{
			get
			{
				if(r_FleftSlice == null)
				{
					r_FleftSlice = new(this, "leftSlice");
				}
				return r_FleftSlice;
			}
		}

		/// <summary>
		/// System.Int32 topSlice
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FtopSlice;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFtopSlice
		{
			get
			{
				if(r_FtopSlice == null)
				{
					r_FtopSlice = new(this, "topSlice");
				}
				return r_FtopSlice;
			}
		}

		/// <summary>
		/// System.Int32 rightSlice
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FrightSlice;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFrightSlice
		{
			get
			{
				if(r_FrightSlice == null)
				{
					r_FrightSlice = new(this, "rightSlice");
				}
				return r_FrightSlice;
			}
		}

		/// <summary>
		/// System.Int32 bottomSlice
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FbottomSlice;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFbottomSlice
		{
			get
			{
				if(r_FbottomSlice == null)
				{
					r_FbottomSlice = new(this, "bottomSlice");
				}
				return r_FbottomSlice;
			}
		}

		/// <summary>
		/// System.Single sliceScale
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FsliceScale;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFsliceScale
		{
			get
			{
				if(r_FsliceScale == null)
				{
					r_FsliceScale = new(this, "sliceScale");
				}
				return r_FsliceScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshBuilderNative+NativeColorPage colorPage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage r_FcolorPage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshBuilderNative.RNativeColorPage RFcolorPage
		{
			get
			{
				if(r_FcolorPage == null)
				{
					r_FcolorPage = new(this, "colorPage");
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
}