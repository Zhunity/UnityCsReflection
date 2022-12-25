using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator
	/// </summary>
    public partial class RUIRVEShaderInfoAllocator : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.UIR.BaseShaderInfoStorage m_Storage
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBaseShaderInfoStorage r_m_Storage;
		public virtual RUnityEngine.RUIElements.RUIR.RBaseShaderInfoStorage Rm_Storage
		{
			get
			{
				if(r_m_Storage == null)
				{
					r_m_Storage = new(this, "m_Storage");
					r_m_Storage.SetBelong(this.instance);
				}
				return r_m_Storage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BitmapAllocator32 m_TransformAllocator
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 r_m_TransformAllocator;
		public virtual RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 Rm_TransformAllocator
		{
			get
			{
				if(r_m_TransformAllocator == null)
				{
					r_m_TransformAllocator = new(this, "m_TransformAllocator");
					r_m_TransformAllocator.SetBelong(this.instance);
				}
				return r_m_TransformAllocator;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BitmapAllocator32 m_ClipRectAllocator
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 r_m_ClipRectAllocator;
		public virtual RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 Rm_ClipRectAllocator
		{
			get
			{
				if(r_m_ClipRectAllocator == null)
				{
					r_m_ClipRectAllocator = new(this, "m_ClipRectAllocator");
					r_m_ClipRectAllocator.SetBelong(this.instance);
				}
				return r_m_ClipRectAllocator;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BitmapAllocator32 m_OpacityAllocator
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 r_m_OpacityAllocator;
		public virtual RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 Rm_OpacityAllocator
		{
			get
			{
				if(r_m_OpacityAllocator == null)
				{
					r_m_OpacityAllocator = new(this, "m_OpacityAllocator");
					r_m_OpacityAllocator.SetBelong(this.instance);
				}
				return r_m_OpacityAllocator;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BitmapAllocator32 m_ColorAllocator
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 r_m_ColorAllocator;
		public virtual RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 Rm_ColorAllocator
		{
			get
			{
				if(r_m_ColorAllocator == null)
				{
					r_m_ColorAllocator = new(this, "m_ColorAllocator");
					r_m_ColorAllocator.SetBelong(this.instance);
				}
				return r_m_ColorAllocator;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BitmapAllocator32 m_TextSettingsAllocator
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 r_m_TextSettingsAllocator;
		public virtual RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 Rm_TextSettingsAllocator
		{
			get
			{
				if(r_m_TextSettingsAllocator == null)
				{
					r_m_TextSettingsAllocator = new(this, "m_TextSettingsAllocator");
					r_m_TextSettingsAllocator.SetBelong(this.instance);
				}
				return r_m_TextSettingsAllocator;
			}
		}

		/// <summary>
		/// System.Boolean m_StorageReallyCreated
		/// </summary>
		protected RField r_m_StorageReallyCreated;
		public virtual RField Rm_StorageReallyCreated
		{
			get
			{
				if(r_m_StorageReallyCreated == null)
				{
					r_m_StorageReallyCreated = new(this, "m_StorageReallyCreated");
					r_m_StorageReallyCreated.SetBelong(this.instance);
				}
				return r_m_StorageReallyCreated;
			}
		}

		/// <summary>
		/// System.Boolean m_VertexTexturingEnabled
		/// </summary>
		protected RField r_m_VertexTexturingEnabled;
		public virtual RField Rm_VertexTexturingEnabled
		{
			get
			{
				if(r_m_VertexTexturingEnabled == null)
				{
					r_m_VertexTexturingEnabled = new(this, "m_VertexTexturingEnabled");
					r_m_VertexTexturingEnabled.SetBelong(this.instance);
				}
				return r_m_VertexTexturingEnabled;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[UnityEngine.UIElements.UIR.Transform3x4] m_Transforms
		/// </summary>
		protected RField r_m_Transforms;
		public virtual RField Rm_Transforms
		{
			get
			{
				if(r_m_Transforms == null)
				{
					r_m_Transforms = new(this, "m_Transforms");
					r_m_Transforms.SetBelong(this.instance);
				}
				return r_m_Transforms;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[UnityEngine.Vector4] m_ClipRects
		/// </summary>
		protected RField r_m_ClipRects;
		public virtual RField Rm_ClipRects
		{
			get
			{
				if(r_m_ClipRects == null)
				{
					r_m_ClipRects = new(this, "m_ClipRects");
					r_m_ClipRects.SetBelong(this.instance);
				}
				return r_m_ClipRects;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int identityTransformTexel
		/// </summary>
		protected static RUnityEngine.RVector2Int r_identityTransformTexel;
		public static RUnityEngine.RVector2Int RidentityTransformTexel
		{
			get
			{
				if(r_identityTransformTexel == null)
				{
					r_identityTransformTexel = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "identityTransformTexel");
					r_identityTransformTexel.SetBelong(null);
				}
				return r_identityTransformTexel;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int infiniteClipRectTexel
		/// </summary>
		protected static RUnityEngine.RVector2Int r_infiniteClipRectTexel;
		public static RUnityEngine.RVector2Int RinfiniteClipRectTexel
		{
			get
			{
				if(r_infiniteClipRectTexel == null)
				{
					r_infiniteClipRectTexel = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "infiniteClipRectTexel");
					r_infiniteClipRectTexel.SetBelong(null);
				}
				return r_infiniteClipRectTexel;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int fullOpacityTexel
		/// </summary>
		protected static RUnityEngine.RVector2Int r_fullOpacityTexel;
		public static RUnityEngine.RVector2Int RfullOpacityTexel
		{
			get
			{
				if(r_fullOpacityTexel == null)
				{
					r_fullOpacityTexel = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "fullOpacityTexel");
					r_fullOpacityTexel.SetBelong(null);
				}
				return r_fullOpacityTexel;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int clearColorTexel
		/// </summary>
		protected static RUnityEngine.RVector2Int r_clearColorTexel;
		public static RUnityEngine.RVector2Int RclearColorTexel
		{
			get
			{
				if(r_clearColorTexel == null)
				{
					r_clearColorTexel = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "clearColorTexel");
					r_clearColorTexel.SetBelong(null);
				}
				return r_clearColorTexel;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int defaultTextCoreSettingsTexel
		/// </summary>
		protected static RUnityEngine.RVector2Int r_defaultTextCoreSettingsTexel;
		public static RUnityEngine.RVector2Int RdefaultTextCoreSettingsTexel
		{
			get
			{
				if(r_defaultTextCoreSettingsTexel == null)
				{
					r_defaultTextCoreSettingsTexel = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "defaultTextCoreSettingsTexel");
					r_defaultTextCoreSettingsTexel.SetBelong(null);
				}
				return r_defaultTextCoreSettingsTexel;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 identityTransformValue
		/// </summary>
		protected static RUnityEngine.RMatrix4x4 r_identityTransformValue;
		public static RUnityEngine.RMatrix4x4 RidentityTransformValue
		{
			get
			{
				if(r_identityTransformValue == null)
				{
					r_identityTransformValue = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "identityTransformValue");
					r_identityTransformValue.SetBelong(null);
				}
				return r_identityTransformValue;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 identityTransformRow0Value
		/// </summary>
		protected static RUnityEngine.RVector4 r_identityTransformRow0Value;
		public static RUnityEngine.RVector4 RidentityTransformRow0Value
		{
			get
			{
				if(r_identityTransformRow0Value == null)
				{
					r_identityTransformRow0Value = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "identityTransformRow0Value");
					r_identityTransformRow0Value.SetBelong(null);
				}
				return r_identityTransformRow0Value;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 identityTransformRow1Value
		/// </summary>
		protected static RUnityEngine.RVector4 r_identityTransformRow1Value;
		public static RUnityEngine.RVector4 RidentityTransformRow1Value
		{
			get
			{
				if(r_identityTransformRow1Value == null)
				{
					r_identityTransformRow1Value = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "identityTransformRow1Value");
					r_identityTransformRow1Value.SetBelong(null);
				}
				return r_identityTransformRow1Value;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 identityTransformRow2Value
		/// </summary>
		protected static RUnityEngine.RVector4 r_identityTransformRow2Value;
		public static RUnityEngine.RVector4 RidentityTransformRow2Value
		{
			get
			{
				if(r_identityTransformRow2Value == null)
				{
					r_identityTransformRow2Value = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "identityTransformRow2Value");
					r_identityTransformRow2Value.SetBelong(null);
				}
				return r_identityTransformRow2Value;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 infiniteClipRectValue
		/// </summary>
		protected static RUnityEngine.RVector4 r_infiniteClipRectValue;
		public static RUnityEngine.RVector4 RinfiniteClipRectValue
		{
			get
			{
				if(r_infiniteClipRectValue == null)
				{
					r_infiniteClipRectValue = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "infiniteClipRectValue");
					r_infiniteClipRectValue.SetBelong(null);
				}
				return r_infiniteClipRectValue;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 fullOpacityValue
		/// </summary>
		protected static RUnityEngine.RVector4 r_fullOpacityValue;
		public static RUnityEngine.RVector4 RfullOpacityValue
		{
			get
			{
				if(r_fullOpacityValue == null)
				{
					r_fullOpacityValue = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "fullOpacityValue");
					r_fullOpacityValue.SetBelong(null);
				}
				return r_fullOpacityValue;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 clearColorValue
		/// </summary>
		protected static RUnityEngine.RVector4 r_clearColorValue;
		public static RUnityEngine.RVector4 RclearColorValue
		{
			get
			{
				if(r_clearColorValue == null)
				{
					r_clearColorValue = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "clearColorValue");
					r_clearColorValue.SetBelong(null);
				}
				return r_clearColorValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.TextCoreSettings defaultTextCoreSettingsValue
		/// </summary>
		protected static RUnityEngine.RUIElements.RUIR.RTextCoreSettings r_defaultTextCoreSettingsValue;
		public static RUnityEngine.RUIElements.RUIR.RTextCoreSettings RdefaultTextCoreSettingsValue
		{
			get
			{
				if(r_defaultTextCoreSettingsValue == null)
				{
					r_defaultTextCoreSettingsValue = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "defaultTextCoreSettingsValue");
					r_defaultTextCoreSettingsValue.SetBelong(null);
				}
				return r_defaultTextCoreSettingsValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc identityTransform
		/// </summary>
		protected static RUnityEngine.RUIElements.RUIR.RBMPAlloc r_identityTransform;
		public static RUnityEngine.RUIElements.RUIR.RBMPAlloc RidentityTransform
		{
			get
			{
				if(r_identityTransform == null)
				{
					r_identityTransform = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "identityTransform");
					r_identityTransform.SetBelong(null);
				}
				return r_identityTransform;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc infiniteClipRect
		/// </summary>
		protected static RUnityEngine.RUIElements.RUIR.RBMPAlloc r_infiniteClipRect;
		public static RUnityEngine.RUIElements.RUIR.RBMPAlloc RinfiniteClipRect
		{
			get
			{
				if(r_infiniteClipRect == null)
				{
					r_infiniteClipRect = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "infiniteClipRect");
					r_infiniteClipRect.SetBelong(null);
				}
				return r_infiniteClipRect;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc fullOpacity
		/// </summary>
		protected static RUnityEngine.RUIElements.RUIR.RBMPAlloc r_fullOpacity;
		public static RUnityEngine.RUIElements.RUIR.RBMPAlloc RfullOpacity
		{
			get
			{
				if(r_fullOpacity == null)
				{
					r_fullOpacity = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "fullOpacity");
					r_fullOpacity.SetBelong(null);
				}
				return r_fullOpacity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc clearColor
		/// </summary>
		protected static RUnityEngine.RUIElements.RUIR.RBMPAlloc r_clearColor;
		public static RUnityEngine.RUIElements.RUIR.RBMPAlloc RclearColor
		{
			get
			{
				if(r_clearColor == null)
				{
					r_clearColor = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "clearColor");
					r_clearColor.SetBelong(null);
				}
				return r_clearColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc defaultTextCoreSettings
		/// </summary>
		protected static RUnityEngine.RUIElements.RUIR.RBMPAlloc r_defaultTextCoreSettings;
		public static RUnityEngine.RUIElements.RUIR.RBMPAlloc RdefaultTextCoreSettings
		{
			get
			{
				if(r_defaultTextCoreSettings == null)
				{
					r_defaultTextCoreSettings = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "defaultTextCoreSettings");
					r_defaultTextCoreSettings.SetBelong(null);
				}
				return r_defaultTextCoreSettings;
			}
		}

		/// <summary>
		/// Int32 pageWidth
		/// </summary>
		protected static RProperty r_pageWidth;
		public static RProperty RpageWidth
		{
			get
			{
				if(r_pageWidth == null)
				{
					r_pageWidth = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "pageWidth", -1);
					r_pageWidth.SetBelong(null);
				}
				return r_pageWidth;
			}
		}

		/// <summary>
		/// Int32 pageHeight
		/// </summary>
		protected static RProperty r_pageHeight;
		public static RProperty RpageHeight
		{
			get
			{
				if(r_pageHeight == null)
				{
					r_pageHeight = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "pageHeight", -1);
					r_pageHeight.SetBelong(null);
				}
				return r_pageHeight;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[UnityEngine.UIElements.UIR.Transform3x4] transformConstants
		/// </summary>
		protected RProperty r_transformConstants;
		public virtual RProperty RtransformConstants
		{
			get
			{
				if(r_transformConstants == null)
				{
					r_transformConstants = new(this, "transformConstants", -1);
					r_transformConstants.SetBelong(this.instance);
				}
				return r_transformConstants;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[UnityEngine.Vector4] clipRectConstants
		/// </summary>
		protected RProperty r_clipRectConstants;
		public virtual RProperty RclipRectConstants
		{
			get
			{
				if(r_clipRectConstants == null)
				{
					r_clipRectConstants = new(this, "clipRectConstants", -1);
					r_clipRectConstants.SetBelong(this.instance);
				}
				return r_clipRectConstants;
			}
		}

		/// <summary>
		/// UnityEngine.Texture atlas
		/// </summary>
		protected RUnityEngine.RTexture r_atlas;
		public virtual RUnityEngine.RTexture Ratlas
		{
			get
			{
				if(r_atlas == null)
				{
					r_atlas = new(this, "atlas", -1);
					r_atlas.SetBelong(this.instance);
				}
				return r_atlas;
			}
		}

		/// <summary>
		/// Boolean internalAtlasCreated
		/// </summary>
		protected RProperty r_internalAtlasCreated;
		public virtual RProperty RinternalAtlasCreated
		{
			get
			{
				if(r_internalAtlasCreated == null)
				{
					r_internalAtlasCreated = new(this, "internalAtlasCreated", -1);
					r_internalAtlasCreated.SetBelong(this.instance);
				}
				return r_internalAtlasCreated;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int AllocToTexelCoord(UnityEngine.UIElements.UIR.BitmapAllocator32 ByRef, UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected static RMethod r_RAllocToTexelCoord_Ref_BitmapAllocator32_BMPAlloc;
		public static RMethod RAllocToTexelCoord_Ref_BitmapAllocator32_BMPAlloc
		{
			get
			{
				if(r_RAllocToTexelCoord_Ref_BitmapAllocator32_BMPAlloc == null)
				{
					r_RAllocToTexelCoord_Ref_BitmapAllocator32_BMPAlloc = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "AllocToTexelCoord", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BitmapAllocator32").MakeByRefType(),  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_RAllocToTexelCoord_Ref_BitmapAllocator32_BMPAlloc.SetBelong(null);
				}
				return r_RAllocToTexelCoord_Ref_BitmapAllocator32_BMPAlloc;
			}
		}

		/// <summary>
		/// Int32 AllocToConstantBufferIndex(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected static RMethod r_RAllocToConstantBufferIndex_BMPAlloc;
		public static RMethod RAllocToConstantBufferIndex_BMPAlloc
		{
			get
			{
				if(r_RAllocToConstantBufferIndex_BMPAlloc == null)
				{
					r_RAllocToConstantBufferIndex_BMPAlloc = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "AllocToConstantBufferIndex", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_RAllocToConstantBufferIndex_BMPAlloc.SetBelong(null);
				}
				return r_RAllocToConstantBufferIndex_BMPAlloc;
			}
		}

		/// <summary>
		/// Boolean AtlasRectMatchesPage(UnityEngine.UIElements.UIR.BitmapAllocator32 ByRef, UnityEngine.UIElements.UIR.BMPAlloc, UnityEngine.RectInt)
		/// </summary>
		protected static RMethod r_RAtlasRectMatchesPage_Ref_BitmapAllocator32_BMPAlloc_RectInt;
		public static RMethod RAtlasRectMatchesPage_Ref_BitmapAllocator32_BMPAlloc_RectInt
		{
			get
			{
				if(r_RAtlasRectMatchesPage_Ref_BitmapAllocator32_BMPAlloc_RectInt == null)
				{
					r_RAtlasRectMatchesPage_Ref_BitmapAllocator32_BMPAlloc_RectInt = new( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "AtlasRectMatchesPage", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BitmapAllocator32").MakeByRefType(),  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"), typeof(UnityEngine.RectInt));
					r_RAtlasRectMatchesPage_Ref_BitmapAllocator32_BMPAlloc_RectInt.SetBelong(null);
				}
				return r_RAtlasRectMatchesPage_Ref_BitmapAllocator32_BMPAlloc_RectInt;
			}
		}

		/// <summary>
		/// Void Construct()
		/// </summary>
		protected RMethod r_RConstruct;
		public virtual RMethod RConstruct
		{
			get
			{
				if(r_RConstruct == null)
				{
					r_RConstruct = new(this, "Construct", 0);
					r_RConstruct.SetBelong(this.instance);
				}
				return r_RConstruct;
			}
		}

		/// <summary>
		/// Void ReallyCreateStorage()
		/// </summary>
		protected RMethod r_RReallyCreateStorage;
		public virtual RMethod RReallyCreateStorage
		{
			get
			{
				if(r_RReallyCreateStorage == null)
				{
					r_RReallyCreateStorage = new(this, "ReallyCreateStorage", 0);
					r_RReallyCreateStorage.SetBelong(this.instance);
				}
				return r_RReallyCreateStorage;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void IssuePendingStorageChanges()
		/// </summary>
		protected RMethod r_RIssuePendingStorageChanges;
		public virtual RMethod RIssuePendingStorageChanges
		{
			get
			{
				if(r_RIssuePendingStorageChanges == null)
				{
					r_RIssuePendingStorageChanges = new(this, "IssuePendingStorageChanges", 0);
					r_RIssuePendingStorageChanges.SetBelong(this.instance);
				}
				return r_RIssuePendingStorageChanges;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc AllocTransform()
		/// </summary>
		protected RMethod r_RAllocTransform;
		public virtual RMethod RAllocTransform
		{
			get
			{
				if(r_RAllocTransform == null)
				{
					r_RAllocTransform = new(this, "AllocTransform", 0);
					r_RAllocTransform.SetBelong(this.instance);
				}
				return r_RAllocTransform;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc AllocClipRect()
		/// </summary>
		protected RMethod r_RAllocClipRect;
		public virtual RMethod RAllocClipRect
		{
			get
			{
				if(r_RAllocClipRect == null)
				{
					r_RAllocClipRect = new(this, "AllocClipRect", 0);
					r_RAllocClipRect.SetBelong(this.instance);
				}
				return r_RAllocClipRect;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc AllocOpacity()
		/// </summary>
		protected RMethod r_RAllocOpacity;
		public virtual RMethod RAllocOpacity
		{
			get
			{
				if(r_RAllocOpacity == null)
				{
					r_RAllocOpacity = new(this, "AllocOpacity", 0);
					r_RAllocOpacity.SetBelong(this.instance);
				}
				return r_RAllocOpacity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc AllocColor()
		/// </summary>
		protected RMethod r_RAllocColor;
		public virtual RMethod RAllocColor
		{
			get
			{
				if(r_RAllocColor == null)
				{
					r_RAllocColor = new(this, "AllocColor", 0);
					r_RAllocColor.SetBelong(this.instance);
				}
				return r_RAllocColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc AllocTextCoreSettings(UnityEngine.UIElements.UIR.TextCoreSettings)
		/// </summary>
		protected RMethod r_RAllocTextCoreSettings_TextCoreSettings;
		public virtual RMethod RAllocTextCoreSettings_TextCoreSettings
		{
			get
			{
				if(r_RAllocTextCoreSettings_TextCoreSettings == null)
				{
					r_RAllocTextCoreSettings_TextCoreSettings = new(this, "AllocTextCoreSettings", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.TextCoreSettings"));
					r_RAllocTextCoreSettings_TextCoreSettings.SetBelong(this.instance);
				}
				return r_RAllocTextCoreSettings_TextCoreSettings;
			}
		}

		/// <summary>
		/// Void SetTransformValue(UnityEngine.UIElements.UIR.BMPAlloc, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_RSetTransformValue_BMPAlloc_Matrix4x4;
		public virtual RMethod RSetTransformValue_BMPAlloc_Matrix4x4
		{
			get
			{
				if(r_RSetTransformValue_BMPAlloc_Matrix4x4 == null)
				{
					r_RSetTransformValue_BMPAlloc_Matrix4x4 = new(this, "SetTransformValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"), typeof(UnityEngine.Matrix4x4));
					r_RSetTransformValue_BMPAlloc_Matrix4x4.SetBelong(this.instance);
				}
				return r_RSetTransformValue_BMPAlloc_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetClipRectValue(UnityEngine.UIElements.UIR.BMPAlloc, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_RSetClipRectValue_BMPAlloc_Vector4;
		public virtual RMethod RSetClipRectValue_BMPAlloc_Vector4
		{
			get
			{
				if(r_RSetClipRectValue_BMPAlloc_Vector4 == null)
				{
					r_RSetClipRectValue_BMPAlloc_Vector4 = new(this, "SetClipRectValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"), typeof(UnityEngine.Vector4));
					r_RSetClipRectValue_BMPAlloc_Vector4.SetBelong(this.instance);
				}
				return r_RSetClipRectValue_BMPAlloc_Vector4;
			}
		}

		/// <summary>
		/// Void SetOpacityValue(UnityEngine.UIElements.UIR.BMPAlloc, Single)
		/// </summary>
		protected RMethod r_RSetOpacityValue_BMPAlloc_Single;
		public virtual RMethod RSetOpacityValue_BMPAlloc_Single
		{
			get
			{
				if(r_RSetOpacityValue_BMPAlloc_Single == null)
				{
					r_RSetOpacityValue_BMPAlloc_Single = new(this, "SetOpacityValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"), typeof(System.Single));
					r_RSetOpacityValue_BMPAlloc_Single.SetBelong(this.instance);
				}
				return r_RSetOpacityValue_BMPAlloc_Single;
			}
		}

		/// <summary>
		/// Void SetColorValue(UnityEngine.UIElements.UIR.BMPAlloc, UnityEngine.Color)
		/// </summary>
		protected RMethod r_RSetColorValue_BMPAlloc_Color;
		public virtual RMethod RSetColorValue_BMPAlloc_Color
		{
			get
			{
				if(r_RSetColorValue_BMPAlloc_Color == null)
				{
					r_RSetColorValue_BMPAlloc_Color = new(this, "SetColorValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"), typeof(UnityEngine.Color));
					r_RSetColorValue_BMPAlloc_Color.SetBelong(this.instance);
				}
				return r_RSetColorValue_BMPAlloc_Color;
			}
		}

		/// <summary>
		/// Void SetTextCoreSettingValue(UnityEngine.UIElements.UIR.BMPAlloc, UnityEngine.UIElements.UIR.TextCoreSettings)
		/// </summary>
		protected RMethod r_RSetTextCoreSettingValue_BMPAlloc_TextCoreSettings;
		public virtual RMethod RSetTextCoreSettingValue_BMPAlloc_TextCoreSettings
		{
			get
			{
				if(r_RSetTextCoreSettingValue_BMPAlloc_TextCoreSettings == null)
				{
					r_RSetTextCoreSettingValue_BMPAlloc_TextCoreSettings = new(this, "SetTextCoreSettingValue", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"),  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.TextCoreSettings"));
					r_RSetTextCoreSettingValue_BMPAlloc_TextCoreSettings.SetBelong(this.instance);
				}
				return r_RSetTextCoreSettingValue_BMPAlloc_TextCoreSettings;
			}
		}

		/// <summary>
		/// Void FreeTransform(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_RFreeTransform_BMPAlloc;
		public virtual RMethod RFreeTransform_BMPAlloc
		{
			get
			{
				if(r_RFreeTransform_BMPAlloc == null)
				{
					r_RFreeTransform_BMPAlloc = new(this, "FreeTransform", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_RFreeTransform_BMPAlloc.SetBelong(this.instance);
				}
				return r_RFreeTransform_BMPAlloc;
			}
		}

		/// <summary>
		/// Void FreeClipRect(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_RFreeClipRect_BMPAlloc;
		public virtual RMethod RFreeClipRect_BMPAlloc
		{
			get
			{
				if(r_RFreeClipRect_BMPAlloc == null)
				{
					r_RFreeClipRect_BMPAlloc = new(this, "FreeClipRect", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_RFreeClipRect_BMPAlloc.SetBelong(this.instance);
				}
				return r_RFreeClipRect_BMPAlloc;
			}
		}

		/// <summary>
		/// Void FreeOpacity(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_RFreeOpacity_BMPAlloc;
		public virtual RMethod RFreeOpacity_BMPAlloc
		{
			get
			{
				if(r_RFreeOpacity_BMPAlloc == null)
				{
					r_RFreeOpacity_BMPAlloc = new(this, "FreeOpacity", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_RFreeOpacity_BMPAlloc.SetBelong(this.instance);
				}
				return r_RFreeOpacity_BMPAlloc;
			}
		}

		/// <summary>
		/// Void FreeColor(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_RFreeColor_BMPAlloc;
		public virtual RMethod RFreeColor_BMPAlloc
		{
			get
			{
				if(r_RFreeColor_BMPAlloc == null)
				{
					r_RFreeColor_BMPAlloc = new(this, "FreeColor", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_RFreeColor_BMPAlloc.SetBelong(this.instance);
				}
				return r_RFreeColor_BMPAlloc;
			}
		}

		/// <summary>
		/// Void FreeTextCoreSettings(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_RFreeTextCoreSettings_BMPAlloc;
		public virtual RMethod RFreeTextCoreSettings_BMPAlloc
		{
			get
			{
				if(r_RFreeTextCoreSettings_BMPAlloc == null)
				{
					r_RFreeTextCoreSettings_BMPAlloc = new(this, "FreeTextCoreSettings", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_RFreeTextCoreSettings_BMPAlloc.SetBelong(this.instance);
				}
				return r_RFreeTextCoreSettings_BMPAlloc;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 TransformAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_RTransformAllocToVertexData_BMPAlloc;
		public virtual RMethod RTransformAllocToVertexData_BMPAlloc
		{
			get
			{
				if(r_RTransformAllocToVertexData_BMPAlloc == null)
				{
					r_RTransformAllocToVertexData_BMPAlloc = new(this, "TransformAllocToVertexData", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_RTransformAllocToVertexData_BMPAlloc.SetBelong(this.instance);
				}
				return r_RTransformAllocToVertexData_BMPAlloc;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 ClipRectAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_RClipRectAllocToVertexData_BMPAlloc;
		public virtual RMethod RClipRectAllocToVertexData_BMPAlloc
		{
			get
			{
				if(r_RClipRectAllocToVertexData_BMPAlloc == null)
				{
					r_RClipRectAllocToVertexData_BMPAlloc = new(this, "ClipRectAllocToVertexData", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_RClipRectAllocToVertexData_BMPAlloc.SetBelong(this.instance);
				}
				return r_RClipRectAllocToVertexData_BMPAlloc;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 OpacityAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_ROpacityAllocToVertexData_BMPAlloc;
		public virtual RMethod ROpacityAllocToVertexData_BMPAlloc
		{
			get
			{
				if(r_ROpacityAllocToVertexData_BMPAlloc == null)
				{
					r_ROpacityAllocToVertexData_BMPAlloc = new(this, "OpacityAllocToVertexData", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_ROpacityAllocToVertexData_BMPAlloc.SetBelong(this.instance);
				}
				return r_ROpacityAllocToVertexData_BMPAlloc;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 ColorAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_RColorAllocToVertexData_BMPAlloc;
		public virtual RMethod RColorAllocToVertexData_BMPAlloc
		{
			get
			{
				if(r_RColorAllocToVertexData_BMPAlloc == null)
				{
					r_RColorAllocToVertexData_BMPAlloc = new(this, "ColorAllocToVertexData", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_RColorAllocToVertexData_BMPAlloc.SetBelong(this.instance);
				}
				return r_RColorAllocToVertexData_BMPAlloc;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 TextCoreSettingsToVertexData(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_RTextCoreSettingsToVertexData_BMPAlloc;
		public virtual RMethod RTextCoreSettingsToVertexData_BMPAlloc
		{
			get
			{
				if(r_RTextCoreSettingsToVertexData_BMPAlloc == null)
				{
					r_RTextCoreSettingsToVertexData_BMPAlloc = new(this, "TextCoreSettingsToVertexData", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_RTextCoreSettingsToVertexData_BMPAlloc.SetBelong(this.instance);
				}
				return r_RTextCoreSettingsToVertexData_BMPAlloc;
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


        public RUIRVEShaderInfoAllocator() : base("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator")
        {
        }

        public RUIRVEShaderInfoAllocator(System.Object instance) : base("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator")
		{
            SetInstance(instance);
		}

        public RUIRVEShaderInfoAllocator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUIRVEShaderInfoAllocator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }




        public virtual void Construct()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RConstruct.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReallyCreateStorage()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReallyCreateStorage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IssuePendingStorageChanges()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIssuePendingStorageChanges.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object AllocTransform()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAllocTransform.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object AllocClipRect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAllocClipRect.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object AllocOpacity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAllocOpacity.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object AllocColor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAllocColor.Invoke(___genericsType, ___parameters);

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
