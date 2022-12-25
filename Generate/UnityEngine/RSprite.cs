using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Sprite
	/// </summary>
    public partial class RSprite : RMember //
    {

		/// <summary>
		/// UnityEngine.Bounds bounds
		/// </summary>
		protected RUnityEngine.RBounds r_bounds;
		public virtual RUnityEngine.RBounds Rbounds
		{
			get
			{
				if(r_bounds == null)
				{
					r_bounds = new(this, "bounds", -1);
					r_bounds.SetBelong(this.instance);
				}
				return r_bounds;
			}
		}

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
					r_rect = new(this, "rect", -1);
					r_rect.SetBelong(this.instance);
				}
				return r_rect;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 border
		/// </summary>
		protected RUnityEngine.RVector4 r_border;
		public virtual RUnityEngine.RVector4 Rborder
		{
			get
			{
				if(r_border == null)
				{
					r_border = new(this, "border", -1);
					r_border.SetBelong(this.instance);
				}
				return r_border;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D texture
		/// </summary>
		protected RUnityEngine.RTexture2D r_texture;
		public virtual RUnityEngine.RTexture2D Rtexture
		{
			get
			{
				if(r_texture == null)
				{
					r_texture = new(this, "texture", -1);
					r_texture.SetBelong(this.instance);
				}
				return r_texture;
			}
		}

		/// <summary>
		/// Single pixelsPerUnit
		/// </summary>
		protected RProperty r_pixelsPerUnit;
		public virtual RProperty RpixelsPerUnit
		{
			get
			{
				if(r_pixelsPerUnit == null)
				{
					r_pixelsPerUnit = new(this, "pixelsPerUnit", -1);
					r_pixelsPerUnit.SetBelong(this.instance);
				}
				return r_pixelsPerUnit;
			}
		}

		/// <summary>
		/// Single spriteAtlasTextureScale
		/// </summary>
		protected RProperty r_spriteAtlasTextureScale;
		public virtual RProperty RspriteAtlasTextureScale
		{
			get
			{
				if(r_spriteAtlasTextureScale == null)
				{
					r_spriteAtlasTextureScale = new(this, "spriteAtlasTextureScale", -1);
					r_spriteAtlasTextureScale.SetBelong(this.instance);
				}
				return r_spriteAtlasTextureScale;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D associatedAlphaSplitTexture
		/// </summary>
		protected RUnityEngine.RTexture2D r_associatedAlphaSplitTexture;
		public virtual RUnityEngine.RTexture2D RassociatedAlphaSplitTexture
		{
			get
			{
				if(r_associatedAlphaSplitTexture == null)
				{
					r_associatedAlphaSplitTexture = new(this, "associatedAlphaSplitTexture", -1);
					r_associatedAlphaSplitTexture.SetBelong(this.instance);
				}
				return r_associatedAlphaSplitTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 pivot
		/// </summary>
		protected RUnityEngine.RVector2 r_pivot;
		public virtual RUnityEngine.RVector2 Rpivot
		{
			get
			{
				if(r_pivot == null)
				{
					r_pivot = new(this, "pivot", -1);
					r_pivot.SetBelong(this.instance);
				}
				return r_pivot;
			}
		}

		/// <summary>
		/// Boolean packed
		/// </summary>
		protected RProperty r_packed;
		public virtual RProperty Rpacked
		{
			get
			{
				if(r_packed == null)
				{
					r_packed = new(this, "packed", -1);
					r_packed.SetBelong(this.instance);
				}
				return r_packed;
			}
		}

		/// <summary>
		/// UnityEngine.SpritePackingMode packingMode
		/// </summary>
		protected RProperty r_packingMode;
		public virtual RProperty RpackingMode
		{
			get
			{
				if(r_packingMode == null)
				{
					r_packingMode = new(this, "packingMode", -1);
					r_packingMode.SetBelong(this.instance);
				}
				return r_packingMode;
			}
		}

		/// <summary>
		/// UnityEngine.SpritePackingRotation packingRotation
		/// </summary>
		protected RProperty r_packingRotation;
		public virtual RProperty RpackingRotation
		{
			get
			{
				if(r_packingRotation == null)
				{
					r_packingRotation = new(this, "packingRotation", -1);
					r_packingRotation.SetBelong(this.instance);
				}
				return r_packingRotation;
			}
		}

		/// <summary>
		/// UnityEngine.Rect textureRect
		/// </summary>
		protected RUnityEngine.RRect r_textureRect;
		public virtual RUnityEngine.RRect RtextureRect
		{
			get
			{
				if(r_textureRect == null)
				{
					r_textureRect = new(this, "textureRect", -1);
					r_textureRect.SetBelong(this.instance);
				}
				return r_textureRect;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 textureRectOffset
		/// </summary>
		protected RUnityEngine.RVector2 r_textureRectOffset;
		public virtual RUnityEngine.RVector2 RtextureRectOffset
		{
			get
			{
				if(r_textureRectOffset == null)
				{
					r_textureRectOffset = new(this, "textureRectOffset", -1);
					r_textureRectOffset.SetBelong(this.instance);
				}
				return r_textureRectOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] vertices
		/// </summary>
		protected RPropertyArray<RUnityEngine.RVector2> r_vertices;
		public virtual RPropertyArray<RUnityEngine.RVector2> Rvertices
		{
			get
			{
				if(r_vertices == null)
				{
					r_vertices = new(this, "vertices", -1);
					r_vertices.SetBelong(this.instance);
				}
				return r_vertices;
			}
		}

		/// <summary>
		/// UInt16[] triangles
		/// </summary>
		protected RPropertyArray<RProperty> r_triangles;
		public virtual RPropertyArray<RProperty> Rtriangles
		{
			get
			{
				if(r_triangles == null)
				{
					r_triangles = new(this, "triangles", -1);
					r_triangles.SetBelong(this.instance);
				}
				return r_triangles;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] uv
		/// </summary>
		protected RPropertyArray<RUnityEngine.RVector2> r_uv;
		public virtual RPropertyArray<RUnityEngine.RVector2> Ruv
		{
			get
			{
				if(r_uv == null)
				{
					r_uv = new(this, "uv", -1);
					r_uv.SetBelong(this.instance);
				}
				return r_uv;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RProperty r_hideFlags;
		public virtual RProperty RhideFlags
		{
			get
			{
				if(r_hideFlags == null)
				{
					r_hideFlags = new(this, "hideFlags", -1);
					r_hideFlags.SetBelong(this.instance);
				}
				return r_hideFlags;
			}
		}

		/// <summary>
		/// Int32 GetPackingMode()
		/// </summary>
		protected RMethod r_RGetPackingMode;
		public virtual RMethod RGetPackingMode
		{
			get
			{
				if(r_RGetPackingMode == null)
				{
					r_RGetPackingMode = new(this, "GetPackingMode", 0);
					r_RGetPackingMode.SetBelong(this.instance);
				}
				return r_RGetPackingMode;
			}
		}

		/// <summary>
		/// Int32 GetPackingRotation()
		/// </summary>
		protected RMethod r_RGetPackingRotation;
		public virtual RMethod RGetPackingRotation
		{
			get
			{
				if(r_RGetPackingRotation == null)
				{
					r_RGetPackingRotation = new(this, "GetPackingRotation", 0);
					r_RGetPackingRotation.SetBelong(this.instance);
				}
				return r_RGetPackingRotation;
			}
		}

		/// <summary>
		/// Int32 GetPacked()
		/// </summary>
		protected RMethod r_RGetPacked;
		public virtual RMethod RGetPacked
		{
			get
			{
				if(r_RGetPacked == null)
				{
					r_RGetPacked = new(this, "GetPacked", 0);
					r_RGetPacked.SetBelong(this.instance);
				}
				return r_RGetPacked;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetTextureRect()
		/// </summary>
		protected RMethod r_RGetTextureRect;
		public virtual RMethod RGetTextureRect
		{
			get
			{
				if(r_RGetTextureRect == null)
				{
					r_RGetTextureRect = new(this, "GetTextureRect", 0);
					r_RGetTextureRect.SetBelong(this.instance);
				}
				return r_RGetTextureRect;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetTextureRectOffset()
		/// </summary>
		protected RMethod r_RGetTextureRectOffset;
		public virtual RMethod RGetTextureRectOffset
		{
			get
			{
				if(r_RGetTextureRectOffset == null)
				{
					r_RGetTextureRectOffset = new(this, "GetTextureRectOffset", 0);
					r_RGetTextureRectOffset.SetBelong(this.instance);
				}
				return r_RGetTextureRectOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetInnerUVs()
		/// </summary>
		protected RMethod r_RGetInnerUVs;
		public virtual RMethod RGetInnerUVs
		{
			get
			{
				if(r_RGetInnerUVs == null)
				{
					r_RGetInnerUVs = new(this, "GetInnerUVs", 0);
					r_RGetInnerUVs.SetBelong(this.instance);
				}
				return r_RGetInnerUVs;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetOuterUVs()
		/// </summary>
		protected RMethod r_RGetOuterUVs;
		public virtual RMethod RGetOuterUVs
		{
			get
			{
				if(r_RGetOuterUVs == null)
				{
					r_RGetOuterUVs = new(this, "GetOuterUVs", 0);
					r_RGetOuterUVs.SetBelong(this.instance);
				}
				return r_RGetOuterUVs;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 GetPadding()
		/// </summary>
		protected RMethod r_RGetPadding;
		public virtual RMethod RGetPadding
		{
			get
			{
				if(r_RGetPadding == null)
				{
					r_RGetPadding = new(this, "GetPadding", 0);
					r_RGetPadding.SetBelong(this.instance);
				}
				return r_RGetPadding;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite CreateSpriteWithoutTextureScripting(UnityEngine.Rect, UnityEngine.Vector2, Single, UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_RCreateSpriteWithoutTextureScripting_Rect_Vector2_Single_Texture2D;
		public static RMethod RCreateSpriteWithoutTextureScripting_Rect_Vector2_Single_Texture2D
		{
			get
			{
				if(r_RCreateSpriteWithoutTextureScripting_Rect_Vector2_Single_Texture2D == null)
				{
					r_RCreateSpriteWithoutTextureScripting_Rect_Vector2_Single_Texture2D = new(typeof(UnityEngine.Sprite), "CreateSpriteWithoutTextureScripting", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Texture2D));
					r_RCreateSpriteWithoutTextureScripting_Rect_Vector2_Single_Texture2D.SetBelong(null);
				}
				return r_RCreateSpriteWithoutTextureScripting_Rect_Vector2_Single_Texture2D;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite CreateSprite(UnityEngine.Texture2D, UnityEngine.Rect, UnityEngine.Vector2, Single, UInt32, UnityEngine.SpriteMeshType, UnityEngine.Vector4, Boolean, UnityEngine.SecondarySpriteTexture[])
		/// </summary>
		protected static RMethod r_RCreateSprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray;
		public static RMethod RCreateSprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray
		{
			get
			{
				if(r_RCreateSprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray == null)
				{
					r_RCreateSprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray = new(typeof(UnityEngine.Sprite), "CreateSprite", 0, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.UInt32), typeof(UnityEngine.SpriteMeshType), typeof(UnityEngine.Vector4), typeof(System.Boolean), typeof(UnityEngine.SecondarySpriteTexture).MakeArrayType());
					r_RCreateSprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray.SetBelong(null);
				}
				return r_RCreateSprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D GetSecondaryTexture(Int32)
		/// </summary>
		protected RMethod r_RGetSecondaryTexture_Int32;
		public virtual RMethod RGetSecondaryTexture_Int32
		{
			get
			{
				if(r_RGetSecondaryTexture_Int32 == null)
				{
					r_RGetSecondaryTexture_Int32 = new(this, "GetSecondaryTexture", 0, typeof(System.Int32));
					r_RGetSecondaryTexture_Int32.SetBelong(this.instance);
				}
				return r_RGetSecondaryTexture_Int32;
			}
		}

		/// <summary>
		/// Int32 GetSecondaryTextureCount()
		/// </summary>
		protected RMethod r_RGetSecondaryTextureCount;
		public virtual RMethod RGetSecondaryTextureCount
		{
			get
			{
				if(r_RGetSecondaryTextureCount == null)
				{
					r_RGetSecondaryTextureCount = new(this, "GetSecondaryTextureCount", 0);
					r_RGetSecondaryTextureCount.SetBelong(this.instance);
				}
				return r_RGetSecondaryTextureCount;
			}
		}

		/// <summary>
		/// Int32 GetSecondaryTextures(UnityEngine.SecondarySpriteTexture[])
		/// </summary>
		protected RMethod r_RGetSecondaryTextures_SecondarySpriteTextureArray;
		public virtual RMethod RGetSecondaryTextures_SecondarySpriteTextureArray
		{
			get
			{
				if(r_RGetSecondaryTextures_SecondarySpriteTextureArray == null)
				{
					r_RGetSecondaryTextures_SecondarySpriteTextureArray = new(this, "GetSecondaryTextures", 0, typeof(UnityEngine.SecondarySpriteTexture).MakeArrayType());
					r_RGetSecondaryTextures_SecondarySpriteTextureArray.SetBelong(this.instance);
				}
				return r_RGetSecondaryTextures_SecondarySpriteTextureArray;
			}
		}

		/// <summary>
		/// Int32 GetPhysicsShapeCount()
		/// </summary>
		protected RMethod r_RGetPhysicsShapeCount;
		public virtual RMethod RGetPhysicsShapeCount
		{
			get
			{
				if(r_RGetPhysicsShapeCount == null)
				{
					r_RGetPhysicsShapeCount = new(this, "GetPhysicsShapeCount", 0);
					r_RGetPhysicsShapeCount.SetBelong(this.instance);
				}
				return r_RGetPhysicsShapeCount;
			}
		}

		/// <summary>
		/// Int32 GetPhysicsShapePointCount(Int32)
		/// </summary>
		protected RMethod r_RGetPhysicsShapePointCount_Int32;
		public virtual RMethod RGetPhysicsShapePointCount_Int32
		{
			get
			{
				if(r_RGetPhysicsShapePointCount_Int32 == null)
				{
					r_RGetPhysicsShapePointCount_Int32 = new(this, "GetPhysicsShapePointCount", 0, typeof(System.Int32));
					r_RGetPhysicsShapePointCount_Int32.SetBelong(this.instance);
				}
				return r_RGetPhysicsShapePointCount_Int32;
			}
		}

		/// <summary>
		/// Int32 Internal_GetPhysicsShapePointCount(Int32)
		/// </summary>
		protected RMethod r_RInternal_GetPhysicsShapePointCount_Int32;
		public virtual RMethod RInternal_GetPhysicsShapePointCount_Int32
		{
			get
			{
				if(r_RInternal_GetPhysicsShapePointCount_Int32 == null)
				{
					r_RInternal_GetPhysicsShapePointCount_Int32 = new(this, "Internal_GetPhysicsShapePointCount", 0, typeof(System.Int32));
					r_RInternal_GetPhysicsShapePointCount_Int32.SetBelong(this.instance);
				}
				return r_RInternal_GetPhysicsShapePointCount_Int32;
			}
		}

		/// <summary>
		/// Int32 GetPhysicsShape(Int32, System.Collections.Generic.List`1[UnityEngine.Vector2])
		/// </summary>
		protected RMethod r_RGetPhysicsShape_Int32_List_d_Vector2_p_;
		public virtual RMethod RGetPhysicsShape_Int32_List_d_Vector2_p_
		{
			get
			{
				if(r_RGetPhysicsShape_Int32_List_d_Vector2_p_ == null)
				{
					r_RGetPhysicsShape_Int32_List_d_Vector2_p_ = new(this, "GetPhysicsShape", 0, typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector2)));
					r_RGetPhysicsShape_Int32_List_d_Vector2_p_.SetBelong(this.instance);
				}
				return r_RGetPhysicsShape_Int32_List_d_Vector2_p_;
			}
		}

		/// <summary>
		/// Void GetPhysicsShapeImpl(UnityEngine.Sprite, Int32, System.Collections.Generic.List`1[UnityEngine.Vector2])
		/// </summary>
		protected static RMethod r_RGetPhysicsShapeImpl_Sprite_Int32_List_d_Vector2_p_;
		public static RMethod RGetPhysicsShapeImpl_Sprite_Int32_List_d_Vector2_p_
		{
			get
			{
				if(r_RGetPhysicsShapeImpl_Sprite_Int32_List_d_Vector2_p_ == null)
				{
					r_RGetPhysicsShapeImpl_Sprite_Int32_List_d_Vector2_p_ = new(typeof(UnityEngine.Sprite), "GetPhysicsShapeImpl", 0, typeof(UnityEngine.Sprite), typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Vector2)));
					r_RGetPhysicsShapeImpl_Sprite_Int32_List_d_Vector2_p_.SetBelong(null);
				}
				return r_RGetPhysicsShapeImpl_Sprite_Int32_List_d_Vector2_p_;
			}
		}

		/// <summary>
		/// Void OverridePhysicsShape(System.Collections.Generic.IList`1[UnityEngine.Vector2[]])
		/// </summary>
		protected RMethod r_ROverridePhysicsShape_IList_d_Vector2Array_p_;
		public virtual RMethod ROverridePhysicsShape_IList_d_Vector2Array_p_
		{
			get
			{
				if(r_ROverridePhysicsShape_IList_d_Vector2Array_p_ == null)
				{
					r_ROverridePhysicsShape_IList_d_Vector2Array_p_ = new(this, "OverridePhysicsShape", 0, typeof(System.Collections.Generic.IList<>).MakeGenericType(typeof(UnityEngine.Vector2).MakeArrayType()));
					r_ROverridePhysicsShape_IList_d_Vector2Array_p_.SetBelong(this.instance);
				}
				return r_ROverridePhysicsShape_IList_d_Vector2Array_p_;
			}
		}

		/// <summary>
		/// Void OverridePhysicsShapeCount(UnityEngine.Sprite, Int32)
		/// </summary>
		protected static RMethod r_ROverridePhysicsShapeCount_Sprite_Int32;
		public static RMethod ROverridePhysicsShapeCount_Sprite_Int32
		{
			get
			{
				if(r_ROverridePhysicsShapeCount_Sprite_Int32 == null)
				{
					r_ROverridePhysicsShapeCount_Sprite_Int32 = new(typeof(UnityEngine.Sprite), "OverridePhysicsShapeCount", 0, typeof(UnityEngine.Sprite), typeof(System.Int32));
					r_ROverridePhysicsShapeCount_Sprite_Int32.SetBelong(null);
				}
				return r_ROverridePhysicsShapeCount_Sprite_Int32;
			}
		}

		/// <summary>
		/// Void OverridePhysicsShape(UnityEngine.Sprite, UnityEngine.Vector2[], Int32)
		/// </summary>
		protected static RMethod r_ROverridePhysicsShape_Sprite_Vector2Array_Int32;
		public static RMethod ROverridePhysicsShape_Sprite_Vector2Array_Int32
		{
			get
			{
				if(r_ROverridePhysicsShape_Sprite_Vector2Array_Int32 == null)
				{
					r_ROverridePhysicsShape_Sprite_Vector2Array_Int32 = new(typeof(UnityEngine.Sprite), "OverridePhysicsShape", 0, typeof(UnityEngine.Sprite), typeof(UnityEngine.Vector2).MakeArrayType(), typeof(System.Int32));
					r_ROverridePhysicsShape_Sprite_Vector2Array_Int32.SetBelong(null);
				}
				return r_ROverridePhysicsShape_Sprite_Vector2Array_Int32;
			}
		}

		/// <summary>
		/// Void OverrideGeometry(UnityEngine.Vector2[], UInt16[])
		/// </summary>
		protected RMethod r_ROverrideGeometry_Vector2Array_UInt16Array;
		public virtual RMethod ROverrideGeometry_Vector2Array_UInt16Array
		{
			get
			{
				if(r_ROverrideGeometry_Vector2Array_UInt16Array == null)
				{
					r_ROverrideGeometry_Vector2Array_UInt16Array = new(this, "OverrideGeometry", 0, typeof(UnityEngine.Vector2).MakeArrayType(), typeof(System.UInt16).MakeArrayType());
					r_ROverrideGeometry_Vector2Array_UInt16Array.SetBelong(this.instance);
				}
				return r_ROverrideGeometry_Vector2Array_UInt16Array;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite Create(UnityEngine.Rect, UnityEngine.Vector2, Single, UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_RCreate_Rect_Vector2_Single_Texture2D;
		public static RMethod RCreate_Rect_Vector2_Single_Texture2D
		{
			get
			{
				if(r_RCreate_Rect_Vector2_Single_Texture2D == null)
				{
					r_RCreate_Rect_Vector2_Single_Texture2D = new(typeof(UnityEngine.Sprite), "Create", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Texture2D));
					r_RCreate_Rect_Vector2_Single_Texture2D.SetBelong(null);
				}
				return r_RCreate_Rect_Vector2_Single_Texture2D;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite Create(UnityEngine.Rect, UnityEngine.Vector2, Single)
		/// </summary>
		protected static RMethod r_RCreate_Rect_Vector2_Single;
		public static RMethod RCreate_Rect_Vector2_Single
		{
			get
			{
				if(r_RCreate_Rect_Vector2_Single == null)
				{
					r_RCreate_Rect_Vector2_Single = new(typeof(UnityEngine.Sprite), "Create", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(System.Single));
					r_RCreate_Rect_Vector2_Single.SetBelong(null);
				}
				return r_RCreate_Rect_Vector2_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite Create(UnityEngine.Texture2D, UnityEngine.Rect, UnityEngine.Vector2, Single, UInt32, UnityEngine.SpriteMeshType, UnityEngine.Vector4, Boolean)
		/// </summary>
		protected static RMethod r_RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean;
		public static RMethod RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean
		{
			get
			{
				if(r_RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean == null)
				{
					r_RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean = new(typeof(UnityEngine.Sprite), "Create", 0, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.UInt32), typeof(UnityEngine.SpriteMeshType), typeof(UnityEngine.Vector4), typeof(System.Boolean));
					r_RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean.SetBelong(null);
				}
				return r_RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite Create(UnityEngine.Texture2D, UnityEngine.Rect, UnityEngine.Vector2, Single, UInt32, UnityEngine.SpriteMeshType, UnityEngine.Vector4, Boolean, UnityEngine.SecondarySpriteTexture[])
		/// </summary>
		protected static RMethod r_RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray;
		public static RMethod RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray
		{
			get
			{
				if(r_RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray == null)
				{
					r_RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray = new(typeof(UnityEngine.Sprite), "Create", 0, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.UInt32), typeof(UnityEngine.SpriteMeshType), typeof(UnityEngine.Vector4), typeof(System.Boolean), typeof(UnityEngine.SecondarySpriteTexture).MakeArrayType());
					r_RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray.SetBelong(null);
				}
				return r_RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite Create(UnityEngine.Texture2D, UnityEngine.Rect, UnityEngine.Vector2, Single, UInt32, UnityEngine.SpriteMeshType, UnityEngine.Vector4)
		/// </summary>
		protected static RMethod r_RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4;
		public static RMethod RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4
		{
			get
			{
				if(r_RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4 == null)
				{
					r_RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4 = new(typeof(UnityEngine.Sprite), "Create", 0, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.UInt32), typeof(UnityEngine.SpriteMeshType), typeof(UnityEngine.Vector4));
					r_RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4.SetBelong(null);
				}
				return r_RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite Create(UnityEngine.Texture2D, UnityEngine.Rect, UnityEngine.Vector2, Single, UInt32, UnityEngine.SpriteMeshType)
		/// </summary>
		protected static RMethod r_RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType;
		public static RMethod RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType
		{
			get
			{
				if(r_RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType == null)
				{
					r_RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType = new(typeof(UnityEngine.Sprite), "Create", 0, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.UInt32), typeof(UnityEngine.SpriteMeshType));
					r_RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType.SetBelong(null);
				}
				return r_RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite Create(UnityEngine.Texture2D, UnityEngine.Rect, UnityEngine.Vector2, Single, UInt32)
		/// </summary>
		protected static RMethod r_RCreate_Texture2D_Rect_Vector2_Single_UInt32;
		public static RMethod RCreate_Texture2D_Rect_Vector2_Single_UInt32
		{
			get
			{
				if(r_RCreate_Texture2D_Rect_Vector2_Single_UInt32 == null)
				{
					r_RCreate_Texture2D_Rect_Vector2_Single_UInt32 = new(typeof(UnityEngine.Sprite), "Create", 0, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.UInt32));
					r_RCreate_Texture2D_Rect_Vector2_Single_UInt32.SetBelong(null);
				}
				return r_RCreate_Texture2D_Rect_Vector2_Single_UInt32;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite Create(UnityEngine.Texture2D, UnityEngine.Rect, UnityEngine.Vector2, Single)
		/// </summary>
		protected static RMethod r_RCreate_Texture2D_Rect_Vector2_Single;
		public static RMethod RCreate_Texture2D_Rect_Vector2_Single
		{
			get
			{
				if(r_RCreate_Texture2D_Rect_Vector2_Single == null)
				{
					r_RCreate_Texture2D_Rect_Vector2_Single = new(typeof(UnityEngine.Sprite), "Create", 0, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2), typeof(System.Single));
					r_RCreate_Texture2D_Rect_Vector2_Single.SetBelong(null);
				}
				return r_RCreate_Texture2D_Rect_Vector2_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite Create(UnityEngine.Texture2D, UnityEngine.Rect, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_RCreate_Texture2D_Rect_Vector2;
		public static RMethod RCreate_Texture2D_Rect_Vector2
		{
			get
			{
				if(r_RCreate_Texture2D_Rect_Vector2 == null)
				{
					r_RCreate_Texture2D_Rect_Vector2 = new(typeof(UnityEngine.Sprite), "Create", 0, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Rect), typeof(UnityEngine.Vector2));
					r_RCreate_Texture2D_Rect_Vector2.SetBelong(null);
				}
				return r_RCreate_Texture2D_Rect_Vector2;
			}
		}

		/// <summary>
		/// Void GetTextureRect_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_RGetTextureRect_Injected_Out_Rect;
		public virtual RMethod RGetTextureRect_Injected_Out_Rect
		{
			get
			{
				if(r_RGetTextureRect_Injected_Out_Rect == null)
				{
					r_RGetTextureRect_Injected_Out_Rect = new(this, "GetTextureRect_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_RGetTextureRect_Injected_Out_Rect.SetBelong(this.instance);
				}
				return r_RGetTextureRect_Injected_Out_Rect;
			}
		}

		/// <summary>
		/// Void GetTextureRectOffset_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_RGetTextureRectOffset_Injected_Out_Vector2;
		public virtual RMethod RGetTextureRectOffset_Injected_Out_Vector2
		{
			get
			{
				if(r_RGetTextureRectOffset_Injected_Out_Vector2 == null)
				{
					r_RGetTextureRectOffset_Injected_Out_Vector2 = new(this, "GetTextureRectOffset_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_RGetTextureRectOffset_Injected_Out_Vector2.SetBelong(this.instance);
				}
				return r_RGetTextureRectOffset_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void GetInnerUVs_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_RGetInnerUVs_Injected_Out_Vector4;
		public virtual RMethod RGetInnerUVs_Injected_Out_Vector4
		{
			get
			{
				if(r_RGetInnerUVs_Injected_Out_Vector4 == null)
				{
					r_RGetInnerUVs_Injected_Out_Vector4 = new(this, "GetInnerUVs_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_RGetInnerUVs_Injected_Out_Vector4.SetBelong(this.instance);
				}
				return r_RGetInnerUVs_Injected_Out_Vector4;
			}
		}

		/// <summary>
		/// Void GetOuterUVs_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_RGetOuterUVs_Injected_Out_Vector4;
		public virtual RMethod RGetOuterUVs_Injected_Out_Vector4
		{
			get
			{
				if(r_RGetOuterUVs_Injected_Out_Vector4 == null)
				{
					r_RGetOuterUVs_Injected_Out_Vector4 = new(this, "GetOuterUVs_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_RGetOuterUVs_Injected_Out_Vector4.SetBelong(this.instance);
				}
				return r_RGetOuterUVs_Injected_Out_Vector4;
			}
		}

		/// <summary>
		/// Void GetPadding_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_RGetPadding_Injected_Out_Vector4;
		public virtual RMethod RGetPadding_Injected_Out_Vector4
		{
			get
			{
				if(r_RGetPadding_Injected_Out_Vector4 == null)
				{
					r_RGetPadding_Injected_Out_Vector4 = new(this, "GetPadding_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_RGetPadding_Injected_Out_Vector4.SetBelong(this.instance);
				}
				return r_RGetPadding_Injected_Out_Vector4;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite CreateSpriteWithoutTextureScripting_Injected(UnityEngine.Rect ByRef, UnityEngine.Vector2 ByRef, Single, UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_RCreateSpriteWithoutTextureScripting_Injected_Ref_Rect_Ref_Vector2_Single_Texture2D;
		public static RMethod RCreateSpriteWithoutTextureScripting_Injected_Ref_Rect_Ref_Vector2_Single_Texture2D
		{
			get
			{
				if(r_RCreateSpriteWithoutTextureScripting_Injected_Ref_Rect_Ref_Vector2_Single_Texture2D == null)
				{
					r_RCreateSpriteWithoutTextureScripting_Injected_Ref_Rect_Ref_Vector2_Single_Texture2D = new(typeof(UnityEngine.Sprite), "CreateSpriteWithoutTextureScripting_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.Texture2D));
					r_RCreateSpriteWithoutTextureScripting_Injected_Ref_Rect_Ref_Vector2_Single_Texture2D.SetBelong(null);
				}
				return r_RCreateSpriteWithoutTextureScripting_Injected_Ref_Rect_Ref_Vector2_Single_Texture2D;
			}
		}

		/// <summary>
		/// UnityEngine.Sprite CreateSprite_Injected(UnityEngine.Texture2D, UnityEngine.Rect ByRef, UnityEngine.Vector2 ByRef, Single, UInt32, UnityEngine.SpriteMeshType, UnityEngine.Vector4 ByRef, Boolean, UnityEngine.SecondarySpriteTexture[])
		/// </summary>
		protected static RMethod r_RCreateSprite_Injected_Texture2D_Ref_Rect_Ref_Vector2_Single_UInt32_SpriteMeshType_Ref_Vector4_Boolean_SecondarySpriteTextureArray;
		public static RMethod RCreateSprite_Injected_Texture2D_Ref_Rect_Ref_Vector2_Single_UInt32_SpriteMeshType_Ref_Vector4_Boolean_SecondarySpriteTextureArray
		{
			get
			{
				if(r_RCreateSprite_Injected_Texture2D_Ref_Rect_Ref_Vector2_Single_UInt32_SpriteMeshType_Ref_Vector4_Boolean_SecondarySpriteTextureArray == null)
				{
					r_RCreateSprite_Injected_Texture2D_Ref_Rect_Ref_Vector2_Single_UInt32_SpriteMeshType_Ref_Vector4_Boolean_SecondarySpriteTextureArray = new(typeof(UnityEngine.Sprite), "CreateSprite_Injected", 0, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Rect).MakeByRefType(), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(System.Single), typeof(System.UInt32), typeof(UnityEngine.SpriteMeshType), typeof(UnityEngine.Vector4).MakeByRefType(), typeof(System.Boolean), typeof(UnityEngine.SecondarySpriteTexture).MakeArrayType());
					r_RCreateSprite_Injected_Texture2D_Ref_Rect_Ref_Vector2_Single_UInt32_SpriteMeshType_Ref_Vector4_Boolean_SecondarySpriteTextureArray.SetBelong(null);
				}
				return r_RCreateSprite_Injected_Texture2D_Ref_Rect_Ref_Vector2_Single_UInt32_SpriteMeshType_Ref_Vector4_Boolean_SecondarySpriteTextureArray;
			}
		}

		/// <summary>
		/// Void get_bounds_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_Rget_bounds_Injected_Out_Bounds;
		public virtual RMethod Rget_bounds_Injected_Out_Bounds
		{
			get
			{
				if(r_Rget_bounds_Injected_Out_Bounds == null)
				{
					r_Rget_bounds_Injected_Out_Bounds = new(this, "get_bounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_Rget_bounds_Injected_Out_Bounds.SetBelong(this.instance);
				}
				return r_Rget_bounds_Injected_Out_Bounds;
			}
		}

		/// <summary>
		/// Void get_rect_Injected(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_Rget_rect_Injected_Out_Rect;
		public virtual RMethod Rget_rect_Injected_Out_Rect
		{
			get
			{
				if(r_Rget_rect_Injected_Out_Rect == null)
				{
					r_Rget_rect_Injected_Out_Rect = new(this, "get_rect_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_Rget_rect_Injected_Out_Rect.SetBelong(this.instance);
				}
				return r_Rget_rect_Injected_Out_Rect;
			}
		}

		/// <summary>
		/// Void get_border_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_Rget_border_Injected_Out_Vector4;
		public virtual RMethod Rget_border_Injected_Out_Vector4
		{
			get
			{
				if(r_Rget_border_Injected_Out_Vector4 == null)
				{
					r_Rget_border_Injected_Out_Vector4 = new(this, "get_border_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_Rget_border_Injected_Out_Vector4.SetBelong(this.instance);
				}
				return r_Rget_border_Injected_Out_Vector4;
			}
		}

		/// <summary>
		/// Void get_pivot_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Rget_pivot_Injected_Out_Vector2;
		public virtual RMethod Rget_pivot_Injected_Out_Vector2
		{
			get
			{
				if(r_Rget_pivot_Injected_Out_Vector2 == null)
				{
					r_Rget_pivot_Injected_Out_Vector2 = new(this, "get_pivot_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Rget_pivot_Injected_Out_Vector2.SetBelong(this.instance);
				}
				return r_Rget_pivot_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_RGetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_RGetInstanceID == null)
				{
					r_RGetInstanceID = new(this, "GetInstanceID", 0);
					r_RGetInstanceID.SetBelong(this.instance);
				}
				return r_RGetInstanceID;
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


        public RSprite() : base("UnityEngine.Sprite")
        {
        }

        public RSprite(System.Object instance) : base("UnityEngine.Sprite")
		{
            SetInstance(instance);
		}

        public RSprite(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSprite(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 GetPackingMode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPackingMode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetPackingRotation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPackingRotation.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetPacked()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPacked.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Rect GetTextureRect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTextureRect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual UnityEngine.Vector2 GetTextureRectOffset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTextureRectOffset.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual UnityEngine.Vector4 GetInnerUVs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInnerUVs.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual UnityEngine.Vector4 GetOuterUVs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetOuterUVs.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public virtual UnityEngine.Vector4 GetPadding()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPadding.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector4)___result;
        }


        public static UnityEngine.Sprite CreateSpriteWithoutTextureScripting(UnityEngine.Rect  @rect, UnityEngine.Vector2  @pivot, System.Single  @pixelsToUnits, UnityEngine.Texture2D  @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @pivot, @pixelsToUnits, @texture};
            var ___result = RCreateSpriteWithoutTextureScripting_Rect_Vector2_Single_Texture2D.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Sprite)___result;
        }


        public static UnityEngine.Sprite CreateSprite(UnityEngine.Texture2D  @texture, UnityEngine.Rect  @rect, UnityEngine.Vector2  @pivot, System.Single  @pixelsPerUnit, System.UInt32  @extrude, UnityEngine.SpriteMeshType  @meshType, UnityEngine.Vector4  @border, System.Boolean  @generateFallbackPhysicsShape, UnityEngine.SecondarySpriteTexture[]  @secondaryTexture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @rect, @pivot, @pixelsPerUnit, @extrude, @meshType, @border, @generateFallbackPhysicsShape, @secondaryTexture};
            var ___result = RCreateSprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Sprite)___result;
        }


        public virtual UnityEngine.Texture2D GetSecondaryTexture(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetSecondaryTexture_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture2D)___result;
        }


        public virtual System.Int32 GetSecondaryTextureCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSecondaryTextureCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetSecondaryTextures(UnityEngine.SecondarySpriteTexture[]  @secondaryTexture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@secondaryTexture};
            var ___result = RGetSecondaryTextures_SecondarySpriteTextureArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetPhysicsShapeCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPhysicsShapeCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetPhysicsShapePointCount(System.Int32  @shapeIdx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shapeIdx};
            var ___result = RGetPhysicsShapePointCount_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Internal_GetPhysicsShapePointCount(System.Int32  @shapeIdx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shapeIdx};
            var ___result = RInternal_GetPhysicsShapePointCount_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetPhysicsShape(System.Int32  @shapeIdx, System.Collections.Generic.List<UnityEngine.Vector2>  @physicsShape)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shapeIdx, @physicsShape};
            var ___result = RGetPhysicsShape_Int32_List_d_Vector2_p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void GetPhysicsShapeImpl(UnityEngine.Sprite  @sprite, System.Int32  @shapeIdx, System.Collections.Generic.List<UnityEngine.Vector2>  @physicsShape)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sprite, @shapeIdx, @physicsShape};
            var ___result = RGetPhysicsShapeImpl_Sprite_Int32_List_d_Vector2_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OverridePhysicsShape(System.Collections.Generic.IList<UnityEngine.Vector2[]>  @physicsShapes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@physicsShapes};
            var ___result = ROverridePhysicsShape_IList_d_Vector2Array_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void OverridePhysicsShapeCount(UnityEngine.Sprite  @sprite, System.Int32  @physicsShapeCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sprite, @physicsShapeCount};
            var ___result = ROverridePhysicsShapeCount_Sprite_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void OverridePhysicsShape(UnityEngine.Sprite  @sprite, UnityEngine.Vector2[]  @physicsShape, System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sprite, @physicsShape, @idx};
            var ___result = ROverridePhysicsShape_Sprite_Vector2Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OverrideGeometry(UnityEngine.Vector2[]  @vertices, System.UInt16[]  @triangles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertices, @triangles};
            var ___result = ROverrideGeometry_Vector2Array_UInt16Array.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Sprite Create(UnityEngine.Rect  @rect, UnityEngine.Vector2  @pivot, System.Single  @pixelsToUnits, UnityEngine.Texture2D  @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @pivot, @pixelsToUnits, @texture};
            var ___result = RCreate_Rect_Vector2_Single_Texture2D.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Sprite)___result;
        }


        public static UnityEngine.Sprite Create(UnityEngine.Rect  @rect, UnityEngine.Vector2  @pivot, System.Single  @pixelsToUnits)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @pivot, @pixelsToUnits};
            var ___result = RCreate_Rect_Vector2_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Sprite)___result;
        }


        public static UnityEngine.Sprite Create(UnityEngine.Texture2D  @texture, UnityEngine.Rect  @rect, UnityEngine.Vector2  @pivot, System.Single  @pixelsPerUnit, System.UInt32  @extrude, UnityEngine.SpriteMeshType  @meshType, UnityEngine.Vector4  @border, System.Boolean  @generateFallbackPhysicsShape)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @rect, @pivot, @pixelsPerUnit, @extrude, @meshType, @border, @generateFallbackPhysicsShape};
            var ___result = RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Sprite)___result;
        }


        public static UnityEngine.Sprite Create(UnityEngine.Texture2D  @texture, UnityEngine.Rect  @rect, UnityEngine.Vector2  @pivot, System.Single  @pixelsPerUnit, System.UInt32  @extrude, UnityEngine.SpriteMeshType  @meshType, UnityEngine.Vector4  @border, System.Boolean  @generateFallbackPhysicsShape, UnityEngine.SecondarySpriteTexture[]  @secondaryTextures)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @rect, @pivot, @pixelsPerUnit, @extrude, @meshType, @border, @generateFallbackPhysicsShape, @secondaryTextures};
            var ___result = RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_SecondarySpriteTextureArray.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Sprite)___result;
        }


        public static UnityEngine.Sprite Create(UnityEngine.Texture2D  @texture, UnityEngine.Rect  @rect, UnityEngine.Vector2  @pivot, System.Single  @pixelsPerUnit, System.UInt32  @extrude, UnityEngine.SpriteMeshType  @meshType, UnityEngine.Vector4  @border)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @rect, @pivot, @pixelsPerUnit, @extrude, @meshType, @border};
            var ___result = RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Sprite)___result;
        }


        public static UnityEngine.Sprite Create(UnityEngine.Texture2D  @texture, UnityEngine.Rect  @rect, UnityEngine.Vector2  @pivot, System.Single  @pixelsPerUnit, System.UInt32  @extrude, UnityEngine.SpriteMeshType  @meshType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @rect, @pivot, @pixelsPerUnit, @extrude, @meshType};
            var ___result = RCreate_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Sprite)___result;
        }


        public static UnityEngine.Sprite Create(UnityEngine.Texture2D  @texture, UnityEngine.Rect  @rect, UnityEngine.Vector2  @pivot, System.Single  @pixelsPerUnit, System.UInt32  @extrude)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @rect, @pivot, @pixelsPerUnit, @extrude};
            var ___result = RCreate_Texture2D_Rect_Vector2_Single_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Sprite)___result;
        }


        public static UnityEngine.Sprite Create(UnityEngine.Texture2D  @texture, UnityEngine.Rect  @rect, UnityEngine.Vector2  @pivot, System.Single  @pixelsPerUnit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @rect, @pivot, @pixelsPerUnit};
            var ___result = RCreate_Texture2D_Rect_Vector2_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Sprite)___result;
        }


        public static UnityEngine.Sprite Create(UnityEngine.Texture2D  @texture, UnityEngine.Rect  @rect, UnityEngine.Vector2  @pivot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @rect, @pivot};
            var ___result = RCreate_Texture2D_Rect_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Sprite)___result;
        }


        public virtual void GetTextureRect_Injected(out UnityEngine.Rect  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetTextureRect_Injected_Out_Rect.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void GetTextureRectOffset_Injected(out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetTextureRectOffset_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void GetInnerUVs_Injected(out UnityEngine.Vector4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetInnerUVs_Injected_Out_Vector4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void GetOuterUVs_Injected(out UnityEngine.Vector4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetOuterUVs_Injected_Out_Vector4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void GetPadding_Injected(out UnityEngine.Vector4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetPadding_Injected_Out_Vector4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector4)___parameters[0];

            
        }


        public static UnityEngine.Sprite CreateSpriteWithoutTextureScripting_Injected(ref UnityEngine.Rect  @rect, ref UnityEngine.Vector2  @pivot, System.Single  @pixelsToUnits, UnityEngine.Texture2D  @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @pivot, @pixelsToUnits, @texture};
            var ___result = RCreateSpriteWithoutTextureScripting_Injected_Ref_Rect_Ref_Vector2_Single_Texture2D.Invoke(___genericsType, ___parameters);
			rect = (UnityEngine.Rect)___parameters[0];
			pivot = (UnityEngine.Vector2)___parameters[1];

            return (UnityEngine.Sprite)___result;
        }


        public static UnityEngine.Sprite CreateSprite_Injected(UnityEngine.Texture2D  @texture, ref UnityEngine.Rect  @rect, ref UnityEngine.Vector2  @pivot, System.Single  @pixelsPerUnit, System.UInt32  @extrude, UnityEngine.SpriteMeshType  @meshType, ref UnityEngine.Vector4  @border, System.Boolean  @generateFallbackPhysicsShape, UnityEngine.SecondarySpriteTexture[]  @secondaryTexture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @rect, @pivot, @pixelsPerUnit, @extrude, @meshType, @border, @generateFallbackPhysicsShape, @secondaryTexture};
            var ___result = RCreateSprite_Injected_Texture2D_Ref_Rect_Ref_Vector2_Single_UInt32_SpriteMeshType_Ref_Vector4_Boolean_SecondarySpriteTextureArray.Invoke(___genericsType, ___parameters);
			rect = (UnityEngine.Rect)___parameters[1];
			pivot = (UnityEngine.Vector2)___parameters[2];
			border = (UnityEngine.Vector4)___parameters[6];

            return (UnityEngine.Sprite)___result;
        }


        public virtual void get_bounds_Injected(out UnityEngine.Bounds  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_bounds_Injected_Out_Bounds.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Bounds)___parameters[0];

            
        }


        public virtual void get_rect_Injected(out UnityEngine.Rect  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_rect_Injected_Out_Rect.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Rect)___parameters[0];

            
        }


        public virtual void get_border_Injected(out UnityEngine.Vector4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_border_Injected_Out_Vector4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void get_pivot_Injected(out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_pivot_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
