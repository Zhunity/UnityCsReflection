
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class RMeshGenerationContextUtils
{
	
	/// <summary>
	/// UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams
	/// </summary>
    public partial class RRectangleParams : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams");
            }
        }

        public RRectangleParams() : base("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams")
        {
        }

        public RRectangleParams(System.Object instance) : base("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams")
		{
            SetInstance(instance);
		}

        public RRectangleParams(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRectangleParams(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// UnityEngine.UIElements.BackgroundPosition backgroundPositionX
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundPosition r_FbackgroundPositionX;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundPosition RFbackgroundPositionX
		{
			get
			{
				if(r_FbackgroundPositionX == null)
				{
					r_FbackgroundPositionX = new(this, "backgroundPositionX");
				}
				return r_FbackgroundPositionX;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition backgroundPositionY
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundPosition r_FbackgroundPositionY;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundPosition RFbackgroundPositionY
		{
			get
			{
				if(r_FbackgroundPositionY == null)
				{
					r_FbackgroundPositionY = new(this, "backgroundPositionY");
				}
				return r_FbackgroundPositionY;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundRepeat backgroundRepeat
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundRepeat r_FbackgroundRepeat;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundRepeat RFbackgroundRepeat
		{
			get
			{
				if(r_FbackgroundRepeat == null)
				{
					r_FbackgroundRepeat = new(this, "backgroundRepeat");
				}
				return r_FbackgroundRepeat;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundSize backgroundSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundSize r_FbackgroundSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundSize RFbackgroundSize
		{
			get
			{
				if(r_FbackgroundSize == null)
				{
					r_FbackgroundSize = new(this, "backgroundSize");
				}
				return r_FbackgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.Texture texture
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture r_Ftexture;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture RFtexture
		{
			get
			{
				if(r_Ftexture == null)
				{
					r_Ftexture = new(this, "texture");
				}
				return r_Ftexture;
			}
		}

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
		/// UnityEngine.UIElements.VectorImage vectorImage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVectorImage r_FvectorImage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVectorImage RFvectorImage
		{
			get
			{
				if(r_FvectorImage == null)
				{
					r_FvectorImage = new(this, "vectorImage");
				}
				return r_FvectorImage;
			}
		}

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterial r_Fmaterial;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterial RFmaterial
		{
			get
			{
				if(r_Fmaterial == null)
				{
					r_Fmaterial = new(this, "material");
				}
				return r_Fmaterial;
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
		/// UnityEngine.Color playmodeTintColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_FplaymodeTintColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFplaymodeTintColor
		{
			get
			{
				if(r_FplaymodeTintColor == null)
				{
					r_FplaymodeTintColor = new(this, "playmodeTintColor");
				}
				return r_FplaymodeTintColor;
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
		/// UnityEngine.Rect spriteGeomRect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_FspriteGeomRect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFspriteGeomRect
		{
			get
			{
				if(r_FspriteGeomRect == null)
				{
					r_FspriteGeomRect = new(this, "spriteGeomRect");
				}
				return r_FspriteGeomRect;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ColorPage colorPage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RColorPage r_FcolorPage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RColorPage RFcolorPage
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
		/// UnityEngine.UIElements.MeshGenerationContext+MeshFlags meshFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext.RMeshFlags r_FmeshFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext.RMeshFlags RFmeshFlags
		{
			get
			{
				if(r_FmeshFlags == null)
				{
					r_FmeshFlags = new(this, "meshFlags");
				}
				return r_FmeshFlags;
			}
		}

		/// <summary>
		/// RectangleParams MakeSolid(UnityEngine.Rect, UnityEngine.Color, UnityEngine.UIElements.ContextType)
		/// </summary>
		protected static RMethod r_MMakeSolid_Rect_Color_ContextType;
		public static RMethod RMMakeSolid_Rect_Color_ContextType
		{
			get
			{
				if(r_MMakeSolid_Rect_Color_ContextType == null)
				{
					r_MMakeSolid_Rect_Color_ContextType = new( ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), "MakeSolid", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Color), typeof(UnityEngine.UIElements.ContextType));
				}
				return r_MMakeSolid_Rect_Color_ContextType;
			}
		}

		/// <summary>
		/// Void AdjustUVsForScaleMode(UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Texture, UnityEngine.ScaleMode, UnityEngine.Rect ByRef, UnityEngine.Rect ByRef)
		/// </summary>
		protected static RMethod r_MAdjustUVsForScaleMode_Rect_Rect_Texture_ScaleMode_Out_Rect_Out_Rect;
		public static RMethod RMAdjustUVsForScaleMode_Rect_Rect_Texture_ScaleMode_Out_Rect_Out_Rect
		{
			get
			{
				if(r_MAdjustUVsForScaleMode_Rect_Rect_Texture_ScaleMode_Out_Rect_Out_Rect == null)
				{
					r_MAdjustUVsForScaleMode_Rect_Rect_Texture_ScaleMode_Out_Rect_Out_Rect = new( ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), "AdjustUVsForScaleMode", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(UnityEngine.ScaleMode), typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.Rect).MakeByRefType());
				}
				return r_MAdjustUVsForScaleMode_Rect_Rect_Texture_ScaleMode_Out_Rect_Out_Rect;
			}
		}

		/// <summary>
		/// Void AdjustSpriteUVsForScaleMode(UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Sprite, UnityEngine.ScaleMode, UnityEngine.Rect ByRef, UnityEngine.Rect ByRef)
		/// </summary>
		protected static RMethod r_MAdjustSpriteUVsForScaleMode_Rect_Rect_Rect_Sprite_ScaleMode_Out_Rect_Out_Rect;
		public static RMethod RMAdjustSpriteUVsForScaleMode_Rect_Rect_Rect_Sprite_ScaleMode_Out_Rect_Out_Rect
		{
			get
			{
				if(r_MAdjustSpriteUVsForScaleMode_Rect_Rect_Rect_Sprite_ScaleMode_Out_Rect_Out_Rect == null)
				{
					r_MAdjustSpriteUVsForScaleMode_Rect_Rect_Rect_Sprite_ScaleMode_Out_Rect_Out_Rect = new( ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), "AdjustSpriteUVsForScaleMode", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Sprite), typeof(UnityEngine.ScaleMode), typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.Rect).MakeByRefType());
				}
				return r_MAdjustSpriteUVsForScaleMode_Rect_Rect_Rect_Sprite_ScaleMode_Out_Rect_Out_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect RectIntersection(UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_MRectIntersection_Rect_Rect;
		public static RMethod RMRectIntersection_Rect_Rect
		{
			get
			{
				if(r_MRectIntersection_Rect_Rect == null)
				{
					r_MRectIntersection_Rect_Rect = new( ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), "RectIntersection", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
				}
				return r_MRectIntersection_Rect_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect ComputeGeomRect(UnityEngine.Sprite)
		/// </summary>
		protected static RMethod r_MComputeGeomRect_Sprite;
		public static RMethod RMComputeGeomRect_Sprite
		{
			get
			{
				if(r_MComputeGeomRect_Sprite == null)
				{
					r_MComputeGeomRect_Sprite = new( ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), "ComputeGeomRect", 0, typeof(UnityEngine.Sprite));
				}
				return r_MComputeGeomRect_Sprite;
			}
		}

		/// <summary>
		/// UnityEngine.Rect ComputeUVRect(UnityEngine.Sprite)
		/// </summary>
		protected static RMethod r_MComputeUVRect_Sprite;
		public static RMethod RMComputeUVRect_Sprite
		{
			get
			{
				if(r_MComputeUVRect_Sprite == null)
				{
					r_MComputeUVRect_Sprite = new( ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), "ComputeUVRect", 0, typeof(UnityEngine.Sprite));
				}
				return r_MComputeUVRect_Sprite;
			}
		}

		/// <summary>
		/// UnityEngine.Rect ApplyPackingRotation(UnityEngine.Rect, UnityEngine.SpritePackingRotation)
		/// </summary>
		protected static RMethod r_MApplyPackingRotation_Rect_SpritePackingRotation;
		public static RMethod RMApplyPackingRotation_Rect_SpritePackingRotation
		{
			get
			{
				if(r_MApplyPackingRotation_Rect_SpritePackingRotation == null)
				{
					r_MApplyPackingRotation_Rect_SpritePackingRotation = new( ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), "ApplyPackingRotation", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.SpritePackingRotation));
				}
				return r_MApplyPackingRotation_Rect_SpritePackingRotation;
			}
		}

		/// <summary>
		/// RectangleParams MakeTextured(UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Texture, UnityEngine.ScaleMode, UnityEngine.UIElements.ContextType)
		/// </summary>
		protected static RMethod r_MMakeTextured_Rect_Rect_Texture_ScaleMode_ContextType;
		public static RMethod RMMakeTextured_Rect_Rect_Texture_ScaleMode_ContextType
		{
			get
			{
				if(r_MMakeTextured_Rect_Rect_Texture_ScaleMode_ContextType == null)
				{
					r_MMakeTextured_Rect_Rect_Texture_ScaleMode_ContextType = new( ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), "MakeTextured", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(UnityEngine.ScaleMode), typeof(UnityEngine.UIElements.ContextType));
				}
				return r_MMakeTextured_Rect_Rect_Texture_ScaleMode_ContextType;
			}
		}

		/// <summary>
		/// RectangleParams MakeSprite(UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Sprite, UnityEngine.ScaleMode, UnityEngine.UIElements.ContextType, Boolean, UnityEngine.Vector4 ByRef, Boolean)
		/// </summary>
		protected static RMethod r_MMakeSprite_Rect_Rect_Sprite_ScaleMode_ContextType_Boolean_Ref_Vector4_Boolean;
		public static RMethod RMMakeSprite_Rect_Rect_Sprite_ScaleMode_ContextType_Boolean_Ref_Vector4_Boolean
		{
			get
			{
				if(r_MMakeSprite_Rect_Rect_Sprite_ScaleMode_ContextType_Boolean_Ref_Vector4_Boolean == null)
				{
					r_MMakeSprite_Rect_Rect_Sprite_ScaleMode_ContextType_Boolean_Ref_Vector4_Boolean = new( ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), "MakeSprite", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Sprite), typeof(UnityEngine.ScaleMode), typeof(UnityEngine.UIElements.ContextType), typeof(System.Boolean), typeof(UnityEngine.Vector4).MakeByRefType(), typeof(System.Boolean));
				}
				return r_MMakeSprite_Rect_Rect_Sprite_ScaleMode_ContextType_Boolean_Ref_Vector4_Boolean;
			}
		}

		/// <summary>
		/// RectangleParams MakeVectorTextured(UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VectorImage, UnityEngine.ScaleMode, UnityEngine.UIElements.ContextType)
		/// </summary>
		protected static RMethod r_MMakeVectorTextured_Rect_Rect_VectorImage_ScaleMode_ContextType;
		public static RMethod RMMakeVectorTextured_Rect_Rect_VectorImage_ScaleMode_ContextType
		{
			get
			{
				if(r_MMakeVectorTextured_Rect_Rect_VectorImage_ScaleMode_ContextType == null)
				{
					r_MMakeVectorTextured_Rect_Rect_VectorImage_ScaleMode_ContextType = new( ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), "MakeVectorTextured", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.UIElements.VectorImage), typeof(UnityEngine.ScaleMode), typeof(UnityEngine.UIElements.ContextType));
				}
				return r_MMakeVectorTextured_Rect_Rect_VectorImage_ScaleMode_ContextType;
			}
		}

		/// <summary>
		/// Boolean HasRadius(Single)
		/// </summary>
		protected RMethod r_MHasRadius_Single;
		public virtual RMethod RMHasRadius_Single
		{
			get
			{
				if(r_MHasRadius_Single == null)
				{
					r_MHasRadius_Single = new(this, "HasRadius", 0, typeof(System.Single));
				}
				return r_MHasRadius_Single;
			}
		}

		/// <summary>
		/// Boolean HasSlices(Single)
		/// </summary>
		protected RMethod r_MHasSlices_Single;
		public virtual RMethod RMHasSlices_Single
		{
			get
			{
				if(r_MHasSlices_Single == null)
				{
					r_MHasSlices_Single = new(this, "HasSlices", 0, typeof(System.Single));
				}
				return r_MHasSlices_Single;
			}
		}

		/// <summary>
		/// NativeRectParams ToNativeParams(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MToNativeParams_Rect;
		public virtual RMethod RMToNativeParams_Rect
		{
			get
			{
				if(r_MToNativeParams_Rect == null)
				{
					r_MToNativeParams_Rect = new(this, "ToNativeParams", 0, typeof(UnityEngine.Rect));
				}
				return r_MToNativeParams_Rect;
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


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContextUtils.RRectangleParams MakeSolid(UnityEngine.Rect @rect, UnityEngine.Color @color, UnityEngine.UIElements.ContextType @panelContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @color, @panelContext};
            var ___result = RMMakeSolid_Rect_Color_ContextType.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContextUtils.RRectangleParams(___result);
        }


        public static void AdjustUVsForScaleMode(UnityEngine.Rect @rect, UnityEngine.Rect @uv, UnityEngine.Texture @texture, UnityEngine.ScaleMode @scaleMode, out UnityEngine.Rect @rectOut, out UnityEngine.Rect @uvOut)
        {
			@rectOut = default;
			@uvOut = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @uv, @texture, @scaleMode, @rectOut, @uvOut};
            var ___result = RMAdjustUVsForScaleMode_Rect_Rect_Texture_ScaleMode_Out_Rect_Out_Rect.Invoke(___genericsType, ___parameters);
			@rectOut = (UnityEngine.Rect)___parameters[4];
			@uvOut = (UnityEngine.Rect)___parameters[5];

            
        }


        public static void AdjustSpriteUVsForScaleMode(UnityEngine.Rect @containerRect, UnityEngine.Rect @srcRect, UnityEngine.Rect @spriteGeomRect, UnityEngine.Sprite @sprite, UnityEngine.ScaleMode @scaleMode, out UnityEngine.Rect @rectOut, out UnityEngine.Rect @uvOut)
        {
			@rectOut = default;
			@uvOut = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@containerRect, @srcRect, @spriteGeomRect, @sprite, @scaleMode, @rectOut, @uvOut};
            var ___result = RMAdjustSpriteUVsForScaleMode_Rect_Rect_Rect_Sprite_ScaleMode_Out_Rect_Out_Rect.Invoke(___genericsType, ___parameters);
			@rectOut = (UnityEngine.Rect)___parameters[5];
			@uvOut = (UnityEngine.Rect)___parameters[6];

            
        }


        public static UnityEngine.Rect RectIntersection(UnityEngine.Rect @a, UnityEngine.Rect @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMRectIntersection_Rect_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public static UnityEngine.Rect ComputeGeomRect(UnityEngine.Sprite @sprite)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sprite};
            var ___result = RMComputeGeomRect_Sprite.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public static UnityEngine.Rect ComputeUVRect(UnityEngine.Sprite @sprite)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sprite};
            var ___result = RMComputeUVRect_Sprite.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public static UnityEngine.Rect ApplyPackingRotation(UnityEngine.Rect @uv, UnityEngine.SpritePackingRotation @rotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uv, @rotation};
            var ___result = RMApplyPackingRotation_Rect_SpritePackingRotation.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContextUtils.RRectangleParams MakeTextured(UnityEngine.Rect @rect, UnityEngine.Rect @uv, UnityEngine.Texture @texture, UnityEngine.ScaleMode @scaleMode, UnityEngine.UIElements.ContextType @panelContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @uv, @texture, @scaleMode, @panelContext};
            var ___result = RMMakeTextured_Rect_Rect_Texture_ScaleMode_ContextType.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContextUtils.RRectangleParams(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContextUtils.RRectangleParams MakeSprite(UnityEngine.Rect @containerRect, UnityEngine.Rect @subRect, UnityEngine.Sprite @sprite, UnityEngine.ScaleMode @scaleMode, UnityEngine.UIElements.ContextType @panelContext, System.Boolean @hasRadius, ref UnityEngine.Vector4 @slices, System.Boolean @useForRepeat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@containerRect, @subRect, @sprite, @scaleMode, @panelContext, @hasRadius, @slices, @useForRepeat};
            var ___result = RMMakeSprite_Rect_Rect_Sprite_ScaleMode_ContextType_Boolean_Ref_Vector4_Boolean.Invoke(___genericsType, ___parameters);
			@slices = (UnityEngine.Vector4)___parameters[6];

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContextUtils.RRectangleParams(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContextUtils.RRectangleParams MakeVectorTextured(UnityEngine.Rect @rect, UnityEngine.Rect @uv, UnityEngine.UIElements.VectorImage @vectorImage, UnityEngine.ScaleMode @scaleMode, UnityEngine.UIElements.ContextType @panelContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @uv, @vectorImage, @scaleMode, @panelContext};
            var ___result = RMMakeVectorTextured_Rect_Rect_VectorImage_ScaleMode_ContextType.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContextUtils.RRectangleParams(___result);
        }


        public virtual System.Boolean HasRadius(System.Single @epsilon)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@epsilon};
            var ___result = RMHasRadius_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasSlices(System.Single @epsilon)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@epsilon};
            var ___result = RMHasSlices_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshBuilderNative.RNativeRectParams ToNativeParams(UnityEngine.Rect @uvRegion)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uvRegion};
            var ___result = RMToNativeParams_Rect.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshBuilderNative.RNativeRectParams(___result);
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