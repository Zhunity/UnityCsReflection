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
		protected RSystem.RBoolean r_m_StorageReallyCreated;
		public virtual RSystem.RBoolean Rm_StorageReallyCreated
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
		protected RSystem.RBoolean r_m_VertexTexturingEnabled;
		public virtual RSystem.RBoolean Rm_VertexTexturingEnabled
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
		protected RUnity.RCollections.RNativeArray<RUnityEngine.RUIElements.RUIR.RTransform3x4> r_m_Transforms;
		public virtual RUnity.RCollections.RNativeArray<RUnityEngine.RUIElements.RUIR.RTransform3x4> Rm_Transforms
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
		protected RUnity.RCollections.RNativeArray<RUnityEngine.RVector4> r_m_ClipRects;
		public virtual RUnity.RCollections.RNativeArray<RUnityEngine.RVector4> Rm_ClipRects
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
					r_identityTransformTexel = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "identityTransformTexel");
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
					r_infiniteClipRectTexel = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "infiniteClipRectTexel");
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
					r_fullOpacityTexel = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "fullOpacityTexel");
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
					r_clearColorTexel = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "clearColorTexel");
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
					r_defaultTextCoreSettingsTexel = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "defaultTextCoreSettingsTexel");
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
					r_identityTransformValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "identityTransformValue");
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
					r_identityTransformRow0Value = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "identityTransformRow0Value");
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
					r_identityTransformRow1Value = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "identityTransformRow1Value");
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
					r_identityTransformRow2Value = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "identityTransformRow2Value");
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
					r_infiniteClipRectValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "infiniteClipRectValue");
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
					r_fullOpacityValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "fullOpacityValue");
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
					r_clearColorValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "clearColorValue");
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
					r_defaultTextCoreSettingsValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "defaultTextCoreSettingsValue");
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
					r_identityTransform = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "identityTransform");
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
					r_infiniteClipRect = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "infiniteClipRect");
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
					r_fullOpacity = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "fullOpacity");
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
					r_clearColor = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "clearColor");
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
					r_defaultTextCoreSettings = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "defaultTextCoreSettings");
					r_defaultTextCoreSettings.SetBelong(null);
				}
				return r_defaultTextCoreSettings;
			}
		}

		/// <summary>
		/// Int32 pageWidth
		/// </summary>
		protected static RSystem.RInt32 r_pageWidth;
		public static RSystem.RInt32 RpageWidth
		{
			get
			{
				if(r_pageWidth == null)
				{
					r_pageWidth = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "pageWidth", -1);
					r_pageWidth.SetBelong(null);
				}
				return r_pageWidth;
			}
		}

		/// <summary>
		/// Int32 pageHeight
		/// </summary>
		protected static RSystem.RInt32 r_pageHeight;
		public static RSystem.RInt32 RpageHeight
		{
			get
			{
				if(r_pageHeight == null)
				{
					r_pageHeight = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "pageHeight", -1);
					r_pageHeight.SetBelong(null);
				}
				return r_pageHeight;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[UnityEngine.UIElements.UIR.Transform3x4] transformConstants
		/// </summary>
		protected RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RUIR.RTransform3x4> r_transformConstants;
		public virtual RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RUIR.RTransform3x4> RtransformConstants
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
		protected RUnity.RCollections.RNativeSlice<RUnityEngine.RVector4> r_clipRectConstants;
		public virtual RUnity.RCollections.RNativeSlice<RUnityEngine.RVector4> RclipRectConstants
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
		protected RSystem.RBoolean r_internalAtlasCreated;
		public virtual RSystem.RBoolean RinternalAtlasCreated
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
		protected static RMethod r_AllocToTexelCoord_Ref_BitmapAllocator32_BMPAlloc;
		public static RMethod RAllocToTexelCoord_Ref_BitmapAllocator32_BMPAlloc
		{
			get
			{
				if(r_AllocToTexelCoord_Ref_BitmapAllocator32_BMPAlloc == null)
				{
					r_AllocToTexelCoord_Ref_BitmapAllocator32_BMPAlloc = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "AllocToTexelCoord", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BitmapAllocator32").MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_AllocToTexelCoord_Ref_BitmapAllocator32_BMPAlloc.SetBelong(null);
				}
				return r_AllocToTexelCoord_Ref_BitmapAllocator32_BMPAlloc;
			}
		}

		/// <summary>
		/// Int32 AllocToConstantBufferIndex(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected static RMethod r_AllocToConstantBufferIndex_BMPAlloc;
		public static RMethod RAllocToConstantBufferIndex_BMPAlloc
		{
			get
			{
				if(r_AllocToConstantBufferIndex_BMPAlloc == null)
				{
					r_AllocToConstantBufferIndex_BMPAlloc = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "AllocToConstantBufferIndex", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_AllocToConstantBufferIndex_BMPAlloc.SetBelong(null);
				}
				return r_AllocToConstantBufferIndex_BMPAlloc;
			}
		}

		/// <summary>
		/// Boolean AtlasRectMatchesPage(UnityEngine.UIElements.UIR.BitmapAllocator32 ByRef, UnityEngine.UIElements.UIR.BMPAlloc, UnityEngine.RectInt)
		/// </summary>
		protected static RMethod r_AtlasRectMatchesPage_Ref_BitmapAllocator32_BMPAlloc_RectInt;
		public static RMethod RAtlasRectMatchesPage_Ref_BitmapAllocator32_BMPAlloc_RectInt
		{
			get
			{
				if(r_AtlasRectMatchesPage_Ref_BitmapAllocator32_BMPAlloc_RectInt == null)
				{
					r_AtlasRectMatchesPage_Ref_BitmapAllocator32_BMPAlloc_RectInt = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "AtlasRectMatchesPage", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BitmapAllocator32").MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"), typeof(UnityEngine.RectInt));
					r_AtlasRectMatchesPage_Ref_BitmapAllocator32_BMPAlloc_RectInt.SetBelong(null);
				}
				return r_AtlasRectMatchesPage_Ref_BitmapAllocator32_BMPAlloc_RectInt;
			}
		}

		/// <summary>
		/// Void Construct()
		/// </summary>
		protected RMethod r_Construct;
		public virtual RMethod RConstruct
		{
			get
			{
				if(r_Construct == null)
				{
					r_Construct = new(this, "Construct", 0);
					r_Construct.SetBelong(this.instance);
				}
				return r_Construct;
			}
		}

		/// <summary>
		/// Void ReallyCreateStorage()
		/// </summary>
		protected RMethod r_ReallyCreateStorage;
		public virtual RMethod RReallyCreateStorage
		{
			get
			{
				if(r_ReallyCreateStorage == null)
				{
					r_ReallyCreateStorage = new(this, "ReallyCreateStorage", 0);
					r_ReallyCreateStorage.SetBelong(this.instance);
				}
				return r_ReallyCreateStorage;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_Dispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_Dispose == null)
				{
					r_Dispose = new(this, "Dispose", 0);
					r_Dispose.SetBelong(this.instance);
				}
				return r_Dispose;
			}
		}

		/// <summary>
		/// Void IssuePendingStorageChanges()
		/// </summary>
		protected RMethod r_IssuePendingStorageChanges;
		public virtual RMethod RIssuePendingStorageChanges
		{
			get
			{
				if(r_IssuePendingStorageChanges == null)
				{
					r_IssuePendingStorageChanges = new(this, "IssuePendingStorageChanges", 0);
					r_IssuePendingStorageChanges.SetBelong(this.instance);
				}
				return r_IssuePendingStorageChanges;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc AllocTransform()
		/// </summary>
		protected RMethod r_AllocTransform;
		public virtual RMethod RAllocTransform
		{
			get
			{
				if(r_AllocTransform == null)
				{
					r_AllocTransform = new(this, "AllocTransform", 0);
					r_AllocTransform.SetBelong(this.instance);
				}
				return r_AllocTransform;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc AllocClipRect()
		/// </summary>
		protected RMethod r_AllocClipRect;
		public virtual RMethod RAllocClipRect
		{
			get
			{
				if(r_AllocClipRect == null)
				{
					r_AllocClipRect = new(this, "AllocClipRect", 0);
					r_AllocClipRect.SetBelong(this.instance);
				}
				return r_AllocClipRect;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc AllocOpacity()
		/// </summary>
		protected RMethod r_AllocOpacity;
		public virtual RMethod RAllocOpacity
		{
			get
			{
				if(r_AllocOpacity == null)
				{
					r_AllocOpacity = new(this, "AllocOpacity", 0);
					r_AllocOpacity.SetBelong(this.instance);
				}
				return r_AllocOpacity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc AllocColor()
		/// </summary>
		protected RMethod r_AllocColor;
		public virtual RMethod RAllocColor
		{
			get
			{
				if(r_AllocColor == null)
				{
					r_AllocColor = new(this, "AllocColor", 0);
					r_AllocColor.SetBelong(this.instance);
				}
				return r_AllocColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc AllocTextCoreSettings(UnityEngine.UIElements.UIR.TextCoreSettings)
		/// </summary>
		protected RMethod r_AllocTextCoreSettings_TextCoreSettings;
		public virtual RMethod RAllocTextCoreSettings_TextCoreSettings
		{
			get
			{
				if(r_AllocTextCoreSettings_TextCoreSettings == null)
				{
					r_AllocTextCoreSettings_TextCoreSettings = new(this, "AllocTextCoreSettings", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.TextCoreSettings"));
					r_AllocTextCoreSettings_TextCoreSettings.SetBelong(this.instance);
				}
				return r_AllocTextCoreSettings_TextCoreSettings;
			}
		}

		/// <summary>
		/// Void SetTransformValue(UnityEngine.UIElements.UIR.BMPAlloc, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_SetTransformValue_BMPAlloc_Matrix4x4;
		public virtual RMethod RSetTransformValue_BMPAlloc_Matrix4x4
		{
			get
			{
				if(r_SetTransformValue_BMPAlloc_Matrix4x4 == null)
				{
					r_SetTransformValue_BMPAlloc_Matrix4x4 = new(this, "SetTransformValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"), typeof(UnityEngine.Matrix4x4));
					r_SetTransformValue_BMPAlloc_Matrix4x4.SetBelong(this.instance);
				}
				return r_SetTransformValue_BMPAlloc_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetClipRectValue(UnityEngine.UIElements.UIR.BMPAlloc, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_SetClipRectValue_BMPAlloc_Vector4;
		public virtual RMethod RSetClipRectValue_BMPAlloc_Vector4
		{
			get
			{
				if(r_SetClipRectValue_BMPAlloc_Vector4 == null)
				{
					r_SetClipRectValue_BMPAlloc_Vector4 = new(this, "SetClipRectValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"), typeof(UnityEngine.Vector4));
					r_SetClipRectValue_BMPAlloc_Vector4.SetBelong(this.instance);
				}
				return r_SetClipRectValue_BMPAlloc_Vector4;
			}
		}

		/// <summary>
		/// Void SetOpacityValue(UnityEngine.UIElements.UIR.BMPAlloc, Single)
		/// </summary>
		protected RMethod r_SetOpacityValue_BMPAlloc_Single;
		public virtual RMethod RSetOpacityValue_BMPAlloc_Single
		{
			get
			{
				if(r_SetOpacityValue_BMPAlloc_Single == null)
				{
					r_SetOpacityValue_BMPAlloc_Single = new(this, "SetOpacityValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"), typeof(System.Single));
					r_SetOpacityValue_BMPAlloc_Single.SetBelong(this.instance);
				}
				return r_SetOpacityValue_BMPAlloc_Single;
			}
		}

		/// <summary>
		/// Void SetColorValue(UnityEngine.UIElements.UIR.BMPAlloc, UnityEngine.Color)
		/// </summary>
		protected RMethod r_SetColorValue_BMPAlloc_Color;
		public virtual RMethod RSetColorValue_BMPAlloc_Color
		{
			get
			{
				if(r_SetColorValue_BMPAlloc_Color == null)
				{
					r_SetColorValue_BMPAlloc_Color = new(this, "SetColorValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"), typeof(UnityEngine.Color));
					r_SetColorValue_BMPAlloc_Color.SetBelong(this.instance);
				}
				return r_SetColorValue_BMPAlloc_Color;
			}
		}

		/// <summary>
		/// Void SetTextCoreSettingValue(UnityEngine.UIElements.UIR.BMPAlloc, UnityEngine.UIElements.UIR.TextCoreSettings)
		/// </summary>
		protected RMethod r_SetTextCoreSettingValue_BMPAlloc_TextCoreSettings;
		public virtual RMethod RSetTextCoreSettingValue_BMPAlloc_TextCoreSettings
		{
			get
			{
				if(r_SetTextCoreSettingValue_BMPAlloc_TextCoreSettings == null)
				{
					r_SetTextCoreSettingValue_BMPAlloc_TextCoreSettings = new(this, "SetTextCoreSettingValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.TextCoreSettings"));
					r_SetTextCoreSettingValue_BMPAlloc_TextCoreSettings.SetBelong(this.instance);
				}
				return r_SetTextCoreSettingValue_BMPAlloc_TextCoreSettings;
			}
		}

		/// <summary>
		/// Void FreeTransform(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_FreeTransform_BMPAlloc;
		public virtual RMethod RFreeTransform_BMPAlloc
		{
			get
			{
				if(r_FreeTransform_BMPAlloc == null)
				{
					r_FreeTransform_BMPAlloc = new(this, "FreeTransform", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_FreeTransform_BMPAlloc.SetBelong(this.instance);
				}
				return r_FreeTransform_BMPAlloc;
			}
		}

		/// <summary>
		/// Void FreeClipRect(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_FreeClipRect_BMPAlloc;
		public virtual RMethod RFreeClipRect_BMPAlloc
		{
			get
			{
				if(r_FreeClipRect_BMPAlloc == null)
				{
					r_FreeClipRect_BMPAlloc = new(this, "FreeClipRect", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_FreeClipRect_BMPAlloc.SetBelong(this.instance);
				}
				return r_FreeClipRect_BMPAlloc;
			}
		}

		/// <summary>
		/// Void FreeOpacity(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_FreeOpacity_BMPAlloc;
		public virtual RMethod RFreeOpacity_BMPAlloc
		{
			get
			{
				if(r_FreeOpacity_BMPAlloc == null)
				{
					r_FreeOpacity_BMPAlloc = new(this, "FreeOpacity", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_FreeOpacity_BMPAlloc.SetBelong(this.instance);
				}
				return r_FreeOpacity_BMPAlloc;
			}
		}

		/// <summary>
		/// Void FreeColor(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_FreeColor_BMPAlloc;
		public virtual RMethod RFreeColor_BMPAlloc
		{
			get
			{
				if(r_FreeColor_BMPAlloc == null)
				{
					r_FreeColor_BMPAlloc = new(this, "FreeColor", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_FreeColor_BMPAlloc.SetBelong(this.instance);
				}
				return r_FreeColor_BMPAlloc;
			}
		}

		/// <summary>
		/// Void FreeTextCoreSettings(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_FreeTextCoreSettings_BMPAlloc;
		public virtual RMethod RFreeTextCoreSettings_BMPAlloc
		{
			get
			{
				if(r_FreeTextCoreSettings_BMPAlloc == null)
				{
					r_FreeTextCoreSettings_BMPAlloc = new(this, "FreeTextCoreSettings", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_FreeTextCoreSettings_BMPAlloc.SetBelong(this.instance);
				}
				return r_FreeTextCoreSettings_BMPAlloc;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 TransformAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_TransformAllocToVertexData_BMPAlloc;
		public virtual RMethod RTransformAllocToVertexData_BMPAlloc
		{
			get
			{
				if(r_TransformAllocToVertexData_BMPAlloc == null)
				{
					r_TransformAllocToVertexData_BMPAlloc = new(this, "TransformAllocToVertexData", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_TransformAllocToVertexData_BMPAlloc.SetBelong(this.instance);
				}
				return r_TransformAllocToVertexData_BMPAlloc;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 ClipRectAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_ClipRectAllocToVertexData_BMPAlloc;
		public virtual RMethod RClipRectAllocToVertexData_BMPAlloc
		{
			get
			{
				if(r_ClipRectAllocToVertexData_BMPAlloc == null)
				{
					r_ClipRectAllocToVertexData_BMPAlloc = new(this, "ClipRectAllocToVertexData", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_ClipRectAllocToVertexData_BMPAlloc.SetBelong(this.instance);
				}
				return r_ClipRectAllocToVertexData_BMPAlloc;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 OpacityAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_OpacityAllocToVertexData_BMPAlloc;
		public virtual RMethod ROpacityAllocToVertexData_BMPAlloc
		{
			get
			{
				if(r_OpacityAllocToVertexData_BMPAlloc == null)
				{
					r_OpacityAllocToVertexData_BMPAlloc = new(this, "OpacityAllocToVertexData", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_OpacityAllocToVertexData_BMPAlloc.SetBelong(this.instance);
				}
				return r_OpacityAllocToVertexData_BMPAlloc;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 ColorAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_ColorAllocToVertexData_BMPAlloc;
		public virtual RMethod RColorAllocToVertexData_BMPAlloc
		{
			get
			{
				if(r_ColorAllocToVertexData_BMPAlloc == null)
				{
					r_ColorAllocToVertexData_BMPAlloc = new(this, "ColorAllocToVertexData", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_ColorAllocToVertexData_BMPAlloc.SetBelong(this.instance);
				}
				return r_ColorAllocToVertexData_BMPAlloc;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 TextCoreSettingsToVertexData(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_TextCoreSettingsToVertexData_BMPAlloc;
		public virtual RMethod RTextCoreSettingsToVertexData_BMPAlloc
		{
			get
			{
				if(r_TextCoreSettingsToVertexData_BMPAlloc == null)
				{
					r_TextCoreSettingsToVertexData_BMPAlloc = new(this, "TextCoreSettingsToVertexData", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_TextCoreSettingsToVertexData_BMPAlloc.SetBelong(this.instance);
				}
				return r_TextCoreSettingsToVertexData_BMPAlloc;
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

        public static UnityEngine.Vector2Int AllocToTexelCoord(ref RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 @allocator, RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@allocator.Value, @alloc.Value};
            var ___result = RAllocToTexelCoord_Ref_BitmapAllocator32_BMPAlloc.Invoke(___genericsType, ___parameters);
			@allocator = new RUnityEngine.RUIElements.RUIR.RBitmapAllocator32(___parameters[0]);

            return (UnityEngine.Vector2Int)___result;
        }


        public static System.Int32 AllocToConstantBufferIndex(RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RAllocToConstantBufferIndex_BMPAlloc.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean AtlasRectMatchesPage(ref RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 @allocator, RUnityEngine.RUIElements.RUIR.RBMPAlloc @defAlloc, UnityEngine.RectInt @atlasRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@allocator.Value, @defAlloc.Value, @atlasRect};
            var ___result = RAtlasRectMatchesPage_Ref_BitmapAllocator32_BMPAlloc_RectInt.Invoke(___genericsType, ___parameters);
			@allocator = new RUnityEngine.RUIElements.RUIR.RBitmapAllocator32(___parameters[0]);

            return (System.Boolean)___result;
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


        public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc AllocTransform()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAllocTransform.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RUIR.RBMPAlloc(___result);
        }


        public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc AllocClipRect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAllocClipRect.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RUIR.RBMPAlloc(___result);
        }


        public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc AllocOpacity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAllocOpacity.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RUIR.RBMPAlloc(___result);
        }


        public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc AllocColor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAllocColor.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RUIR.RBMPAlloc(___result);
        }


        public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc AllocTextCoreSettings(RUnityEngine.RUIElements.RUIR.RTextCoreSettings @settings)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@settings.Value};
            var ___result = RAllocTextCoreSettings_TextCoreSettings.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RUIR.RBMPAlloc(___result);
        }


        public virtual void SetTransformValue(RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc, UnityEngine.Matrix4x4 @xform)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value, @xform};
            var ___result = RSetTransformValue_BMPAlloc_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetClipRectValue(RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc, UnityEngine.Vector4 @clipRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value, @clipRect};
            var ___result = RSetClipRectValue_BMPAlloc_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetOpacityValue(RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc, System.Single @opacity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value, @opacity};
            var ___result = RSetOpacityValue_BMPAlloc_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColorValue(RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc, UnityEngine.Color @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value, @color};
            var ___result = RSetColorValue_BMPAlloc_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTextCoreSettingValue(RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc, RUnityEngine.RUIElements.RUIR.RTextCoreSettings @settings)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value, @settings.Value};
            var ___result = RSetTextCoreSettingValue_BMPAlloc_TextCoreSettings.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FreeTransform(RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RFreeTransform_BMPAlloc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FreeClipRect(RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RFreeClipRect_BMPAlloc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FreeOpacity(RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RFreeOpacity_BMPAlloc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FreeColor(RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RFreeColor_BMPAlloc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FreeTextCoreSettings(RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RFreeTextCoreSettings_BMPAlloc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Color32 TransformAllocToVertexData(RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RTransformAllocToVertexData_BMPAlloc.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color32)___result;
        }


        public virtual UnityEngine.Color32 ClipRectAllocToVertexData(RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RClipRectAllocToVertexData_BMPAlloc.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color32)___result;
        }


        public virtual UnityEngine.Color32 OpacityAllocToVertexData(RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = ROpacityAllocToVertexData_BMPAlloc.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color32)___result;
        }


        public virtual UnityEngine.Color32 ColorAllocToVertexData(RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RColorAllocToVertexData_BMPAlloc.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color32)___result;
        }


        public virtual UnityEngine.Color32 TextCoreSettingsToVertexData(RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RTextCoreSettingsToVertexData_BMPAlloc.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color32)___result;
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
