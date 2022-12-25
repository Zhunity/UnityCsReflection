using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class RMeshGenerationContextUtils
{
	
	/// <summary>
	/// UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams
	/// </summary>
    public partial class RRectangleParams : RMember //
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
		/// UnityEngine.UIElements.BackgroundPosition backgroundPositionX
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundPosition r_backgroundPositionX;
		public virtual RUnityEngine.RUIElements.RBackgroundPosition RbackgroundPositionX
		{
			get
			{
				if(r_backgroundPositionX == null)
				{
					r_backgroundPositionX = new(this, "backgroundPositionX");
					r_backgroundPositionX.SetBelong(this.instance);
				}
				return r_backgroundPositionX;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition backgroundPositionY
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundPosition r_backgroundPositionY;
		public virtual RUnityEngine.RUIElements.RBackgroundPosition RbackgroundPositionY
		{
			get
			{
				if(r_backgroundPositionY == null)
				{
					r_backgroundPositionY = new(this, "backgroundPositionY");
					r_backgroundPositionY.SetBelong(this.instance);
				}
				return r_backgroundPositionY;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundRepeat backgroundRepeat
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundRepeat r_backgroundRepeat;
		public virtual RUnityEngine.RUIElements.RBackgroundRepeat RbackgroundRepeat
		{
			get
			{
				if(r_backgroundRepeat == null)
				{
					r_backgroundRepeat = new(this, "backgroundRepeat");
					r_backgroundRepeat.SetBelong(this.instance);
				}
				return r_backgroundRepeat;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundSize backgroundSize
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundSize r_backgroundSize;
		public virtual RUnityEngine.RUIElements.RBackgroundSize RbackgroundSize
		{
			get
			{
				if(r_backgroundSize == null)
				{
					r_backgroundSize = new(this, "backgroundSize");
					r_backgroundSize.SetBelong(this.instance);
				}
				return r_backgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.Texture texture
		/// </summary>
		protected RUnityEngine.RTexture r_texture;
		public virtual RUnityEngine.RTexture Rtexture
		{
			get
			{
				if(r_texture == null)
				{
					r_texture = new(this, "texture");
					r_texture.SetBelong(this.instance);
				}
				return r_texture;
			}
		}

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
		/// UnityEngine.UIElements.VectorImage vectorImage
		/// </summary>
		protected RUnityEngine.RUIElements.RVectorImage r_vectorImage;
		public virtual RUnityEngine.RUIElements.RVectorImage RvectorImage
		{
			get
			{
				if(r_vectorImage == null)
				{
					r_vectorImage = new(this, "vectorImage");
					r_vectorImage.SetBelong(this.instance);
				}
				return r_vectorImage;
			}
		}

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected RUnityEngine.RMaterial r_material;
		public virtual RUnityEngine.RMaterial Rmaterial
		{
			get
			{
				if(r_material == null)
				{
					r_material = new(this, "material");
					r_material.SetBelong(this.instance);
				}
				return r_material;
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
		/// UnityEngine.Color playmodeTintColor
		/// </summary>
		protected RUnityEngine.RColor r_playmodeTintColor;
		public virtual RUnityEngine.RColor RplaymodeTintColor
		{
			get
			{
				if(r_playmodeTintColor == null)
				{
					r_playmodeTintColor = new(this, "playmodeTintColor");
					r_playmodeTintColor.SetBelong(this.instance);
				}
				return r_playmodeTintColor;
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
		/// UnityEngine.Rect spriteGeomRect
		/// </summary>
		protected RUnityEngine.RRect r_spriteGeomRect;
		public virtual RUnityEngine.RRect RspriteGeomRect
		{
			get
			{
				if(r_spriteGeomRect == null)
				{
					r_spriteGeomRect = new(this, "spriteGeomRect");
					r_spriteGeomRect.SetBelong(this.instance);
				}
				return r_spriteGeomRect;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ColorPage colorPage
		/// </summary>
		protected RUnityEngine.RUIElements.RColorPage r_colorPage;
		public virtual RUnityEngine.RUIElements.RColorPage RcolorPage
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
		/// UnityEngine.UIElements.MeshGenerationContext+MeshFlags meshFlags
		/// </summary>
		protected RField r_meshFlags;
		public virtual RField RmeshFlags
		{
			get
			{
				if(r_meshFlags == null)
				{
					r_meshFlags = new(this, "meshFlags");
					r_meshFlags.SetBelong(this.instance);
				}
				return r_meshFlags;
			}
		}

		/// <summary>
		/// RectangleParams MakeSolid(UnityEngine.Rect, UnityEngine.Color, UnityEngine.UIElements.ContextType)
		/// </summary>
		protected static RMethod r_RMakeSolid_Rect_Color_ContextType;
		public static RMethod RMakeSolid_Rect_Color_ContextType
		{
			get
			{
				if(r_RMakeSolid_Rect_Color_ContextType == null)
				{
					r_RMakeSolid_Rect_Color_ContextType = new( ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), "MakeSolid", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Color), typeof(UnityEngine.UIElements.ContextType));
					r_RMakeSolid_Rect_Color_ContextType.SetBelong(null);
				}
				return r_RMakeSolid_Rect_Color_ContextType;
			}
		}

		/// <summary>
		/// Void AdjustUVsForScaleMode(UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Texture, UnityEngine.ScaleMode, UnityEngine.Rect ByRef, UnityEngine.Rect ByRef)
		/// </summary>
		protected static RMethod r_RAdjustUVsForScaleMode_Rect_Rect_Texture_ScaleMode_Out_Rect_Out_Rect;
		public static RMethod RAdjustUVsForScaleMode_Rect_Rect_Texture_ScaleMode_Out_Rect_Out_Rect
		{
			get
			{
				if(r_RAdjustUVsForScaleMode_Rect_Rect_Texture_ScaleMode_Out_Rect_Out_Rect == null)
				{
					r_RAdjustUVsForScaleMode_Rect_Rect_Texture_ScaleMode_Out_Rect_Out_Rect = new( ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), "AdjustUVsForScaleMode", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(UnityEngine.ScaleMode), typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.Rect).MakeByRefType());
					r_RAdjustUVsForScaleMode_Rect_Rect_Texture_ScaleMode_Out_Rect_Out_Rect.SetBelong(null);
				}
				return r_RAdjustUVsForScaleMode_Rect_Rect_Texture_ScaleMode_Out_Rect_Out_Rect;
			}
		}

		/// <summary>
		/// Void AdjustSpriteUVsForScaleMode(UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Texture, UnityEngine.Sprite, UnityEngine.ScaleMode, UnityEngine.Rect ByRef, UnityEngine.Rect ByRef)
		/// </summary>
		protected static RMethod r_RAdjustSpriteUVsForScaleMode_Rect_Rect_Rect_Texture_Sprite_ScaleMode_Out_Rect_Out_Rect;
		public static RMethod RAdjustSpriteUVsForScaleMode_Rect_Rect_Rect_Texture_Sprite_ScaleMode_Out_Rect_Out_Rect
		{
			get
			{
				if(r_RAdjustSpriteUVsForScaleMode_Rect_Rect_Rect_Texture_Sprite_ScaleMode_Out_Rect_Out_Rect == null)
				{
					r_RAdjustSpriteUVsForScaleMode_Rect_Rect_Rect_Texture_Sprite_ScaleMode_Out_Rect_Out_Rect = new( ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), "AdjustSpriteUVsForScaleMode", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(UnityEngine.Sprite), typeof(UnityEngine.ScaleMode), typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.Rect).MakeByRefType());
					r_RAdjustSpriteUVsForScaleMode_Rect_Rect_Rect_Texture_Sprite_ScaleMode_Out_Rect_Out_Rect.SetBelong(null);
				}
				return r_RAdjustSpriteUVsForScaleMode_Rect_Rect_Rect_Texture_Sprite_ScaleMode_Out_Rect_Out_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect RectIntersection(UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_RRectIntersection_Rect_Rect;
		public static RMethod RRectIntersection_Rect_Rect
		{
			get
			{
				if(r_RRectIntersection_Rect_Rect == null)
				{
					r_RRectIntersection_Rect_Rect = new( ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), "RectIntersection", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
					r_RRectIntersection_Rect_Rect.SetBelong(null);
				}
				return r_RRectIntersection_Rect_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect ComputeGeomRect(UnityEngine.Sprite)
		/// </summary>
		protected static RMethod r_RComputeGeomRect_Sprite;
		public static RMethod RComputeGeomRect_Sprite
		{
			get
			{
				if(r_RComputeGeomRect_Sprite == null)
				{
					r_RComputeGeomRect_Sprite = new( ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), "ComputeGeomRect", 0, typeof(UnityEngine.Sprite));
					r_RComputeGeomRect_Sprite.SetBelong(null);
				}
				return r_RComputeGeomRect_Sprite;
			}
		}

		/// <summary>
		/// UnityEngine.Rect ComputeUVRect(UnityEngine.Sprite)
		/// </summary>
		protected static RMethod r_RComputeUVRect_Sprite;
		public static RMethod RComputeUVRect_Sprite
		{
			get
			{
				if(r_RComputeUVRect_Sprite == null)
				{
					r_RComputeUVRect_Sprite = new( ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), "ComputeUVRect", 0, typeof(UnityEngine.Sprite));
					r_RComputeUVRect_Sprite.SetBelong(null);
				}
				return r_RComputeUVRect_Sprite;
			}
		}

		/// <summary>
		/// UnityEngine.Rect ApplyPackingRotation(UnityEngine.Rect, UnityEngine.SpritePackingRotation)
		/// </summary>
		protected static RMethod r_RApplyPackingRotation_Rect_SpritePackingRotation;
		public static RMethod RApplyPackingRotation_Rect_SpritePackingRotation
		{
			get
			{
				if(r_RApplyPackingRotation_Rect_SpritePackingRotation == null)
				{
					r_RApplyPackingRotation_Rect_SpritePackingRotation = new( ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), "ApplyPackingRotation", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.SpritePackingRotation));
					r_RApplyPackingRotation_Rect_SpritePackingRotation.SetBelong(null);
				}
				return r_RApplyPackingRotation_Rect_SpritePackingRotation;
			}
		}

		/// <summary>
		/// RectangleParams MakeTextured(UnityEngine.Rect, UnityEngine.Rect, UnityEngine.Texture, UnityEngine.ScaleMode, UnityEngine.UIElements.ContextType)
		/// </summary>
		protected static RMethod r_RMakeTextured_Rect_Rect_Texture_ScaleMode_ContextType;
		public static RMethod RMakeTextured_Rect_Rect_Texture_ScaleMode_ContextType
		{
			get
			{
				if(r_RMakeTextured_Rect_Rect_Texture_ScaleMode_ContextType == null)
				{
					r_RMakeTextured_Rect_Rect_Texture_ScaleMode_ContextType = new( ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), "MakeTextured", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(UnityEngine.ScaleMode), typeof(UnityEngine.UIElements.ContextType));
					r_RMakeTextured_Rect_Rect_Texture_ScaleMode_ContextType.SetBelong(null);
				}
				return r_RMakeTextured_Rect_Rect_Texture_ScaleMode_ContextType;
			}
		}

		/// <summary>
		/// RectangleParams MakeSprite(UnityEngine.Rect, UnityEngine.Sprite, UnityEngine.ScaleMode, UnityEngine.UIElements.ContextType, Boolean, UnityEngine.Vector4 ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RMakeSprite_Rect_Sprite_ScaleMode_ContextType_Boolean_Ref_Vector4_Boolean;
		public static RMethod RMakeSprite_Rect_Sprite_ScaleMode_ContextType_Boolean_Ref_Vector4_Boolean
		{
			get
			{
				if(r_RMakeSprite_Rect_Sprite_ScaleMode_ContextType_Boolean_Ref_Vector4_Boolean == null)
				{
					r_RMakeSprite_Rect_Sprite_ScaleMode_ContextType_Boolean_Ref_Vector4_Boolean = new( ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), "MakeSprite", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Sprite), typeof(UnityEngine.ScaleMode), typeof(UnityEngine.UIElements.ContextType), typeof(System.Boolean), typeof(UnityEngine.Vector4).MakeByRefType(), typeof(System.Boolean));
					r_RMakeSprite_Rect_Sprite_ScaleMode_ContextType_Boolean_Ref_Vector4_Boolean.SetBelong(null);
				}
				return r_RMakeSprite_Rect_Sprite_ScaleMode_ContextType_Boolean_Ref_Vector4_Boolean;
			}
		}

		/// <summary>
		/// RectangleParams MakeVectorTextured(UnityEngine.Rect, UnityEngine.Rect, UnityEngine.UIElements.VectorImage, UnityEngine.ScaleMode, UnityEngine.UIElements.ContextType)
		/// </summary>
		protected static RMethod r_RMakeVectorTextured_Rect_Rect_VectorImage_ScaleMode_ContextType;
		public static RMethod RMakeVectorTextured_Rect_Rect_VectorImage_ScaleMode_ContextType
		{
			get
			{
				if(r_RMakeVectorTextured_Rect_Rect_VectorImage_ScaleMode_ContextType == null)
				{
					r_RMakeVectorTextured_Rect_Rect_VectorImage_ScaleMode_ContextType = new( ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), "MakeVectorTextured", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(UnityEngine.UIElements.VectorImage), typeof(UnityEngine.ScaleMode), typeof(UnityEngine.UIElements.ContextType));
					r_RMakeVectorTextured_Rect_Rect_VectorImage_ScaleMode_ContextType.SetBelong(null);
				}
				return r_RMakeVectorTextured_Rect_Rect_VectorImage_ScaleMode_ContextType;
			}
		}

		/// <summary>
		/// Boolean HasRadius(Single)
		/// </summary>
		protected RMethod r_RHasRadius_Single;
		public virtual RMethod RHasRadius_Single
		{
			get
			{
				if(r_RHasRadius_Single == null)
				{
					r_RHasRadius_Single = new(this, "HasRadius", 0, typeof(System.Single));
					r_RHasRadius_Single.SetBelong(this.instance);
				}
				return r_RHasRadius_Single;
			}
		}

		/// <summary>
		/// Boolean HasSlices(Single)
		/// </summary>
		protected RMethod r_RHasSlices_Single;
		public virtual RMethod RHasSlices_Single
		{
			get
			{
				if(r_RHasSlices_Single == null)
				{
					r_RHasSlices_Single = new(this, "HasSlices", 0, typeof(System.Single));
					r_RHasSlices_Single.SetBelong(this.instance);
				}
				return r_RHasSlices_Single;
			}
		}

		/// <summary>
		/// NativeRectParams ToNativeParams(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RToNativeParams_Rect;
		public virtual RMethod RToNativeParams_Rect
		{
			get
			{
				if(r_RToNativeParams_Rect == null)
				{
					r_RToNativeParams_Rect = new(this, "ToNativeParams", 0, typeof(UnityEngine.Rect));
					r_RToNativeParams_Rect.SetBelong(this.instance);
				}
				return r_RToNativeParams_Rect;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
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

        public static System.Object MakeSolid(UnityEngine.Rect  @rect, UnityEngine.Color  @color, UnityEngine.UIElements.ContextType  @panelContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @color, @panelContext};
            var ___result = RMakeSolid_Rect_Color_ContextType.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static void AdjustUVsForScaleMode(UnityEngine.Rect  @rect, UnityEngine.Rect  @uv, UnityEngine.Texture  @texture, UnityEngine.ScaleMode  @scaleMode, out UnityEngine.Rect  @rectOut, out UnityEngine.Rect  @uvOut)
        {
			rectOut = default;
			uvOut = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @uv, @texture, @scaleMode, @rectOut, @uvOut};
            var ___result = RAdjustUVsForScaleMode_Rect_Rect_Texture_ScaleMode_Out_Rect_Out_Rect.Invoke(___genericsType, ___parameters);
			rectOut = (UnityEngine.Rect)___parameters[4];
			uvOut = (UnityEngine.Rect)___parameters[5];

            
        }


        public static void AdjustSpriteUVsForScaleMode(UnityEngine.Rect  @rect, UnityEngine.Rect  @uv, UnityEngine.Rect  @geomRect, UnityEngine.Texture  @texture, UnityEngine.Sprite  @sprite, UnityEngine.ScaleMode  @scaleMode, out UnityEngine.Rect  @rectOut, out UnityEngine.Rect  @uvOut)
        {
			rectOut = default;
			uvOut = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @uv, @geomRect, @texture, @sprite, @scaleMode, @rectOut, @uvOut};
            var ___result = RAdjustSpriteUVsForScaleMode_Rect_Rect_Rect_Texture_Sprite_ScaleMode_Out_Rect_Out_Rect.Invoke(___genericsType, ___parameters);
			rectOut = (UnityEngine.Rect)___parameters[6];
			uvOut = (UnityEngine.Rect)___parameters[7];

            
        }


        public static UnityEngine.Rect RectIntersection(UnityEngine.Rect  @a, UnityEngine.Rect  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RRectIntersection_Rect_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public static UnityEngine.Rect ComputeGeomRect(UnityEngine.Sprite  @sprite)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sprite};
            var ___result = RComputeGeomRect_Sprite.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public static UnityEngine.Rect ComputeUVRect(UnityEngine.Sprite  @sprite)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sprite};
            var ___result = RComputeUVRect_Sprite.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public static UnityEngine.Rect ApplyPackingRotation(UnityEngine.Rect  @uv, UnityEngine.SpritePackingRotation  @rotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uv, @rotation};
            var ___result = RApplyPackingRotation_Rect_SpritePackingRotation.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public static System.Object MakeTextured(UnityEngine.Rect  @rect, UnityEngine.Rect  @uv, UnityEngine.Texture  @texture, UnityEngine.ScaleMode  @scaleMode, UnityEngine.UIElements.ContextType  @panelContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @uv, @texture, @scaleMode, @panelContext};
            var ___result = RMakeTextured_Rect_Rect_Texture_ScaleMode_ContextType.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object MakeSprite(UnityEngine.Rect  @rect, UnityEngine.Sprite  @sprite, UnityEngine.ScaleMode  @scaleMode, UnityEngine.UIElements.ContextType  @panelContext, System.Boolean  @hasRadius, ref UnityEngine.Vector4  @slices, System.Boolean  @useForRepeat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @sprite, @scaleMode, @panelContext, @hasRadius, @slices, @useForRepeat};
            var ___result = RMakeSprite_Rect_Sprite_ScaleMode_ContextType_Boolean_Ref_Vector4_Boolean.Invoke(___genericsType, ___parameters);
			slices = (UnityEngine.Vector4)___parameters[5];

            return (System.Object)___result;
        }


        public static System.Object MakeVectorTextured(UnityEngine.Rect  @rect, UnityEngine.Rect  @uv, UnityEngine.UIElements.VectorImage  @vectorImage, UnityEngine.ScaleMode  @scaleMode, UnityEngine.UIElements.ContextType  @panelContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @uv, @vectorImage, @scaleMode, @panelContext};
            var ___result = RMakeVectorTextured_Rect_Rect_VectorImage_ScaleMode_ContextType.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean HasRadius(System.Single  @epsilon)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@epsilon};
            var ___result = RHasRadius_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasSlices(System.Single  @epsilon)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@epsilon};
            var ___result = RHasSlices_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object ToNativeParams(UnityEngine.Rect  @uvRegion)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uvRegion};
            var ___result = RToNativeParams_Rect.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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