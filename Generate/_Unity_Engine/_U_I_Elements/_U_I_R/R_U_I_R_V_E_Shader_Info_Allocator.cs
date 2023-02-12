
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
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBaseShaderInfoStorage r_Fm_Storage;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBaseShaderInfoStorage RFm_Storage
		{
			get
			{
				if(r_Fm_Storage == null)
				{
					r_Fm_Storage = new(this, "m_Storage");
					r_Fm_Storage.SetBelong(this.instance);
				}
				return r_Fm_Storage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BitmapAllocator32 m_TransformAllocator
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 r_Fm_TransformAllocator;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 RFm_TransformAllocator
		{
			get
			{
				if(r_Fm_TransformAllocator == null)
				{
					r_Fm_TransformAllocator = new(this, "m_TransformAllocator");
					r_Fm_TransformAllocator.SetBelong(this.instance);
				}
				return r_Fm_TransformAllocator;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BitmapAllocator32 m_ClipRectAllocator
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 r_Fm_ClipRectAllocator;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 RFm_ClipRectAllocator
		{
			get
			{
				if(r_Fm_ClipRectAllocator == null)
				{
					r_Fm_ClipRectAllocator = new(this, "m_ClipRectAllocator");
					r_Fm_ClipRectAllocator.SetBelong(this.instance);
				}
				return r_Fm_ClipRectAllocator;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BitmapAllocator32 m_OpacityAllocator
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 r_Fm_OpacityAllocator;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 RFm_OpacityAllocator
		{
			get
			{
				if(r_Fm_OpacityAllocator == null)
				{
					r_Fm_OpacityAllocator = new(this, "m_OpacityAllocator");
					r_Fm_OpacityAllocator.SetBelong(this.instance);
				}
				return r_Fm_OpacityAllocator;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BitmapAllocator32 m_ColorAllocator
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 r_Fm_ColorAllocator;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 RFm_ColorAllocator
		{
			get
			{
				if(r_Fm_ColorAllocator == null)
				{
					r_Fm_ColorAllocator = new(this, "m_ColorAllocator");
					r_Fm_ColorAllocator.SetBelong(this.instance);
				}
				return r_Fm_ColorAllocator;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BitmapAllocator32 m_TextSettingsAllocator
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 r_Fm_TextSettingsAllocator;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 RFm_TextSettingsAllocator
		{
			get
			{
				if(r_Fm_TextSettingsAllocator == null)
				{
					r_Fm_TextSettingsAllocator = new(this, "m_TextSettingsAllocator");
					r_Fm_TextSettingsAllocator.SetBelong(this.instance);
				}
				return r_Fm_TextSettingsAllocator;
			}
		}

		/// <summary>
		/// System.Boolean m_StorageReallyCreated
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_StorageReallyCreated;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_StorageReallyCreated
		{
			get
			{
				if(r_Fm_StorageReallyCreated == null)
				{
					r_Fm_StorageReallyCreated = new(this, "m_StorageReallyCreated");
					r_Fm_StorageReallyCreated.SetBelong(this.instance);
				}
				return r_Fm_StorageReallyCreated;
			}
		}

		/// <summary>
		/// System.Boolean m_VertexTexturingEnabled
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fm_VertexTexturingEnabled;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFm_VertexTexturingEnabled
		{
			get
			{
				if(r_Fm_VertexTexturingEnabled == null)
				{
					r_Fm_VertexTexturingEnabled = new(this, "m_VertexTexturingEnabled");
					r_Fm_VertexTexturingEnabled.SetBelong(this.instance);
				}
				return r_Fm_VertexTexturingEnabled;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[UnityEngine.UIElements.UIR.Transform3x4] m_Transforms
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeArray<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTransform3x4> r_Fm_Transforms;
		public virtual SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeArray<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTransform3x4> RFm_Transforms
		{
			get
			{
				if(r_Fm_Transforms == null)
				{
					r_Fm_Transforms = new(this, "m_Transforms");
					r_Fm_Transforms.SetBelong(this.instance);
				}
				return r_Fm_Transforms;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[UnityEngine.Vector4] m_ClipRects
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeArray<SMFrame.Editor.Refleaction.RUnityEngine.RVector4> r_Fm_ClipRects;
		public virtual SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeArray<SMFrame.Editor.Refleaction.RUnityEngine.RVector4> RFm_ClipRects
		{
			get
			{
				if(r_Fm_ClipRects == null)
				{
					r_Fm_ClipRects = new(this, "m_ClipRects");
					r_Fm_ClipRects.SetBelong(this.instance);
				}
				return r_Fm_ClipRects;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int identityTransformTexel
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_FidentityTransformTexel;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RFidentityTransformTexel
		{
			get
			{
				if(r_FidentityTransformTexel == null)
				{
					r_FidentityTransformTexel = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "identityTransformTexel");
					r_FidentityTransformTexel.SetBelong(null);
				}
				return r_FidentityTransformTexel;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int infiniteClipRectTexel
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_FinfiniteClipRectTexel;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RFinfiniteClipRectTexel
		{
			get
			{
				if(r_FinfiniteClipRectTexel == null)
				{
					r_FinfiniteClipRectTexel = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "infiniteClipRectTexel");
					r_FinfiniteClipRectTexel.SetBelong(null);
				}
				return r_FinfiniteClipRectTexel;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int fullOpacityTexel
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_FfullOpacityTexel;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RFfullOpacityTexel
		{
			get
			{
				if(r_FfullOpacityTexel == null)
				{
					r_FfullOpacityTexel = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "fullOpacityTexel");
					r_FfullOpacityTexel.SetBelong(null);
				}
				return r_FfullOpacityTexel;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int clearColorTexel
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_FclearColorTexel;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RFclearColorTexel
		{
			get
			{
				if(r_FclearColorTexel == null)
				{
					r_FclearColorTexel = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "clearColorTexel");
					r_FclearColorTexel.SetBelong(null);
				}
				return r_FclearColorTexel;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int defaultTextCoreSettingsTexel
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_FdefaultTextCoreSettingsTexel;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RFdefaultTextCoreSettingsTexel
		{
			get
			{
				if(r_FdefaultTextCoreSettingsTexel == null)
				{
					r_FdefaultTextCoreSettingsTexel = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "defaultTextCoreSettingsTexel");
					r_FdefaultTextCoreSettingsTexel.SetBelong(null);
				}
				return r_FdefaultTextCoreSettingsTexel;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 identityTransformValue
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_FidentityTransformValue;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RMatrix4x4 RFidentityTransformValue
		{
			get
			{
				if(r_FidentityTransformValue == null)
				{
					r_FidentityTransformValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "identityTransformValue");
					r_FidentityTransformValue.SetBelong(null);
				}
				return r_FidentityTransformValue;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 identityTransformRow0Value
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector4 r_FidentityTransformRow0Value;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector4 RFidentityTransformRow0Value
		{
			get
			{
				if(r_FidentityTransformRow0Value == null)
				{
					r_FidentityTransformRow0Value = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "identityTransformRow0Value");
					r_FidentityTransformRow0Value.SetBelong(null);
				}
				return r_FidentityTransformRow0Value;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 identityTransformRow1Value
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector4 r_FidentityTransformRow1Value;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector4 RFidentityTransformRow1Value
		{
			get
			{
				if(r_FidentityTransformRow1Value == null)
				{
					r_FidentityTransformRow1Value = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "identityTransformRow1Value");
					r_FidentityTransformRow1Value.SetBelong(null);
				}
				return r_FidentityTransformRow1Value;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 identityTransformRow2Value
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector4 r_FidentityTransformRow2Value;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector4 RFidentityTransformRow2Value
		{
			get
			{
				if(r_FidentityTransformRow2Value == null)
				{
					r_FidentityTransformRow2Value = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "identityTransformRow2Value");
					r_FidentityTransformRow2Value.SetBelong(null);
				}
				return r_FidentityTransformRow2Value;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 infiniteClipRectValue
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector4 r_FinfiniteClipRectValue;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector4 RFinfiniteClipRectValue
		{
			get
			{
				if(r_FinfiniteClipRectValue == null)
				{
					r_FinfiniteClipRectValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "infiniteClipRectValue");
					r_FinfiniteClipRectValue.SetBelong(null);
				}
				return r_FinfiniteClipRectValue;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 fullOpacityValue
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector4 r_FfullOpacityValue;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector4 RFfullOpacityValue
		{
			get
			{
				if(r_FfullOpacityValue == null)
				{
					r_FfullOpacityValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "fullOpacityValue");
					r_FfullOpacityValue.SetBelong(null);
				}
				return r_FfullOpacityValue;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 clearColorValue
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector4 r_FclearColorValue;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector4 RFclearColorValue
		{
			get
			{
				if(r_FclearColorValue == null)
				{
					r_FclearColorValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "clearColorValue");
					r_FclearColorValue.SetBelong(null);
				}
				return r_FclearColorValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.TextCoreSettings defaultTextCoreSettingsValue
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTextCoreSettings r_FdefaultTextCoreSettingsValue;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTextCoreSettings RFdefaultTextCoreSettingsValue
		{
			get
			{
				if(r_FdefaultTextCoreSettingsValue == null)
				{
					r_FdefaultTextCoreSettingsValue = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "defaultTextCoreSettingsValue");
					r_FdefaultTextCoreSettingsValue.SetBelong(null);
				}
				return r_FdefaultTextCoreSettingsValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc identityTransform
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc r_FidentityTransform;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc RFidentityTransform
		{
			get
			{
				if(r_FidentityTransform == null)
				{
					r_FidentityTransform = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "identityTransform");
					r_FidentityTransform.SetBelong(null);
				}
				return r_FidentityTransform;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc infiniteClipRect
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc r_FinfiniteClipRect;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc RFinfiniteClipRect
		{
			get
			{
				if(r_FinfiniteClipRect == null)
				{
					r_FinfiniteClipRect = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "infiniteClipRect");
					r_FinfiniteClipRect.SetBelong(null);
				}
				return r_FinfiniteClipRect;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc fullOpacity
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc r_FfullOpacity;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc RFfullOpacity
		{
			get
			{
				if(r_FfullOpacity == null)
				{
					r_FfullOpacity = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "fullOpacity");
					r_FfullOpacity.SetBelong(null);
				}
				return r_FfullOpacity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc clearColor
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc r_FclearColor;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc RFclearColor
		{
			get
			{
				if(r_FclearColor == null)
				{
					r_FclearColor = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "clearColor");
					r_FclearColor.SetBelong(null);
				}
				return r_FclearColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc defaultTextCoreSettings
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc r_FdefaultTextCoreSettings;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc RFdefaultTextCoreSettings
		{
			get
			{
				if(r_FdefaultTextCoreSettings == null)
				{
					r_FdefaultTextCoreSettings = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "defaultTextCoreSettings");
					r_FdefaultTextCoreSettings.SetBelong(null);
				}
				return r_FdefaultTextCoreSettings;
			}
		}

		/// <summary>
		/// Int32 pageWidth
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RInt32 r_PpageWidth;
		public static SMFrame.Editor.Refleaction.RSystem.RInt32 RPpageWidth
		{
			get
			{
				if(r_PpageWidth == null)
				{
					r_PpageWidth = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "pageWidth", -1);
					r_PpageWidth.SetBelong(null);
				}
				return r_PpageWidth;
			}
		}

		/// <summary>
		/// Int32 pageHeight
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RInt32 r_PpageHeight;
		public static SMFrame.Editor.Refleaction.RSystem.RInt32 RPpageHeight
		{
			get
			{
				if(r_PpageHeight == null)
				{
					r_PpageHeight = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "pageHeight", -1);
					r_PpageHeight.SetBelong(null);
				}
				return r_PpageHeight;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[UnityEngine.UIElements.UIR.Transform3x4] transformConstants
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeSlice<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTransform3x4> r_PtransformConstants;
		public virtual SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeSlice<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTransform3x4> RPtransformConstants
		{
			get
			{
				if(r_PtransformConstants == null)
				{
					r_PtransformConstants = new(this, "transformConstants", -1);
					r_PtransformConstants.SetBelong(this.instance);
				}
				return r_PtransformConstants;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[UnityEngine.Vector4] clipRectConstants
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeSlice<SMFrame.Editor.Refleaction.RUnityEngine.RVector4> r_PclipRectConstants;
		public virtual SMFrame.Editor.Refleaction.RUnity.RCollections.RNativeSlice<SMFrame.Editor.Refleaction.RUnityEngine.RVector4> RPclipRectConstants
		{
			get
			{
				if(r_PclipRectConstants == null)
				{
					r_PclipRectConstants = new(this, "clipRectConstants", -1);
					r_PclipRectConstants.SetBelong(this.instance);
				}
				return r_PclipRectConstants;
			}
		}

		/// <summary>
		/// UnityEngine.Texture atlas
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTexture r_Patlas;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTexture RPatlas
		{
			get
			{
				if(r_Patlas == null)
				{
					r_Patlas = new(this, "atlas", -1);
					r_Patlas.SetBelong(this.instance);
				}
				return r_Patlas;
			}
		}

		/// <summary>
		/// Boolean internalAtlasCreated
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PinternalAtlasCreated;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPinternalAtlasCreated
		{
			get
			{
				if(r_PinternalAtlasCreated == null)
				{
					r_PinternalAtlasCreated = new(this, "internalAtlasCreated", -1);
					r_PinternalAtlasCreated.SetBelong(this.instance);
				}
				return r_PinternalAtlasCreated;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int AllocToTexelCoord(UnityEngine.UIElements.UIR.BitmapAllocator32 ByRef, UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected static RMethod r_MAllocToTexelCoord_Ref_BitmapAllocator32_BMPAlloc;
		public static RMethod RMAllocToTexelCoord_Ref_BitmapAllocator32_BMPAlloc
		{
			get
			{
				if(r_MAllocToTexelCoord_Ref_BitmapAllocator32_BMPAlloc == null)
				{
					r_MAllocToTexelCoord_Ref_BitmapAllocator32_BMPAlloc = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "AllocToTexelCoord", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BitmapAllocator32").MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_MAllocToTexelCoord_Ref_BitmapAllocator32_BMPAlloc.SetBelong(null);
				}
				return r_MAllocToTexelCoord_Ref_BitmapAllocator32_BMPAlloc;
			}
		}

		/// <summary>
		/// Int32 AllocToConstantBufferIndex(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected static RMethod r_MAllocToConstantBufferIndex_BMPAlloc;
		public static RMethod RMAllocToConstantBufferIndex_BMPAlloc
		{
			get
			{
				if(r_MAllocToConstantBufferIndex_BMPAlloc == null)
				{
					r_MAllocToConstantBufferIndex_BMPAlloc = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "AllocToConstantBufferIndex", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_MAllocToConstantBufferIndex_BMPAlloc.SetBelong(null);
				}
				return r_MAllocToConstantBufferIndex_BMPAlloc;
			}
		}

		/// <summary>
		/// Boolean AtlasRectMatchesPage(UnityEngine.UIElements.UIR.BitmapAllocator32 ByRef, UnityEngine.UIElements.UIR.BMPAlloc, UnityEngine.RectInt)
		/// </summary>
		protected static RMethod r_MAtlasRectMatchesPage_Ref_BitmapAllocator32_BMPAlloc_RectInt;
		public static RMethod RMAtlasRectMatchesPage_Ref_BitmapAllocator32_BMPAlloc_RectInt
		{
			get
			{
				if(r_MAtlasRectMatchesPage_Ref_BitmapAllocator32_BMPAlloc_RectInt == null)
				{
					r_MAtlasRectMatchesPage_Ref_BitmapAllocator32_BMPAlloc_RectInt = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator"), "AtlasRectMatchesPage", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BitmapAllocator32").MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"), typeof(UnityEngine.RectInt));
					r_MAtlasRectMatchesPage_Ref_BitmapAllocator32_BMPAlloc_RectInt.SetBelong(null);
				}
				return r_MAtlasRectMatchesPage_Ref_BitmapAllocator32_BMPAlloc_RectInt;
			}
		}

		/// <summary>
		/// Void Construct()
		/// </summary>
		protected RMethod r_MConstruct;
		public virtual RMethod RMConstruct
		{
			get
			{
				if(r_MConstruct == null)
				{
					r_MConstruct = new(this, "Construct", 0);
					r_MConstruct.SetBelong(this.instance);
				}
				return r_MConstruct;
			}
		}

		/// <summary>
		/// Void ReallyCreateStorage()
		/// </summary>
		protected RMethod r_MReallyCreateStorage;
		public virtual RMethod RMReallyCreateStorage
		{
			get
			{
				if(r_MReallyCreateStorage == null)
				{
					r_MReallyCreateStorage = new(this, "ReallyCreateStorage", 0);
					r_MReallyCreateStorage.SetBelong(this.instance);
				}
				return r_MReallyCreateStorage;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
					r_MDispose.SetBelong(this.instance);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void IssuePendingStorageChanges()
		/// </summary>
		protected RMethod r_MIssuePendingStorageChanges;
		public virtual RMethod RMIssuePendingStorageChanges
		{
			get
			{
				if(r_MIssuePendingStorageChanges == null)
				{
					r_MIssuePendingStorageChanges = new(this, "IssuePendingStorageChanges", 0);
					r_MIssuePendingStorageChanges.SetBelong(this.instance);
				}
				return r_MIssuePendingStorageChanges;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc AllocTransform()
		/// </summary>
		protected RMethod r_MAllocTransform;
		public virtual RMethod RMAllocTransform
		{
			get
			{
				if(r_MAllocTransform == null)
				{
					r_MAllocTransform = new(this, "AllocTransform", 0);
					r_MAllocTransform.SetBelong(this.instance);
				}
				return r_MAllocTransform;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc AllocClipRect()
		/// </summary>
		protected RMethod r_MAllocClipRect;
		public virtual RMethod RMAllocClipRect
		{
			get
			{
				if(r_MAllocClipRect == null)
				{
					r_MAllocClipRect = new(this, "AllocClipRect", 0);
					r_MAllocClipRect.SetBelong(this.instance);
				}
				return r_MAllocClipRect;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc AllocOpacity()
		/// </summary>
		protected RMethod r_MAllocOpacity;
		public virtual RMethod RMAllocOpacity
		{
			get
			{
				if(r_MAllocOpacity == null)
				{
					r_MAllocOpacity = new(this, "AllocOpacity", 0);
					r_MAllocOpacity.SetBelong(this.instance);
				}
				return r_MAllocOpacity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc AllocColor()
		/// </summary>
		protected RMethod r_MAllocColor;
		public virtual RMethod RMAllocColor
		{
			get
			{
				if(r_MAllocColor == null)
				{
					r_MAllocColor = new(this, "AllocColor", 0);
					r_MAllocColor.SetBelong(this.instance);
				}
				return r_MAllocColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc AllocTextCoreSettings(UnityEngine.UIElements.UIR.TextCoreSettings)
		/// </summary>
		protected RMethod r_MAllocTextCoreSettings_TextCoreSettings;
		public virtual RMethod RMAllocTextCoreSettings_TextCoreSettings
		{
			get
			{
				if(r_MAllocTextCoreSettings_TextCoreSettings == null)
				{
					r_MAllocTextCoreSettings_TextCoreSettings = new(this, "AllocTextCoreSettings", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.TextCoreSettings"));
					r_MAllocTextCoreSettings_TextCoreSettings.SetBelong(this.instance);
				}
				return r_MAllocTextCoreSettings_TextCoreSettings;
			}
		}

		/// <summary>
		/// Void SetTransformValue(UnityEngine.UIElements.UIR.BMPAlloc, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MSetTransformValue_BMPAlloc_Matrix4x4;
		public virtual RMethod RMSetTransformValue_BMPAlloc_Matrix4x4
		{
			get
			{
				if(r_MSetTransformValue_BMPAlloc_Matrix4x4 == null)
				{
					r_MSetTransformValue_BMPAlloc_Matrix4x4 = new(this, "SetTransformValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"), typeof(UnityEngine.Matrix4x4));
					r_MSetTransformValue_BMPAlloc_Matrix4x4.SetBelong(this.instance);
				}
				return r_MSetTransformValue_BMPAlloc_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetClipRectValue(UnityEngine.UIElements.UIR.BMPAlloc, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_MSetClipRectValue_BMPAlloc_Vector4;
		public virtual RMethod RMSetClipRectValue_BMPAlloc_Vector4
		{
			get
			{
				if(r_MSetClipRectValue_BMPAlloc_Vector4 == null)
				{
					r_MSetClipRectValue_BMPAlloc_Vector4 = new(this, "SetClipRectValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"), typeof(UnityEngine.Vector4));
					r_MSetClipRectValue_BMPAlloc_Vector4.SetBelong(this.instance);
				}
				return r_MSetClipRectValue_BMPAlloc_Vector4;
			}
		}

		/// <summary>
		/// Void SetOpacityValue(UnityEngine.UIElements.UIR.BMPAlloc, Single)
		/// </summary>
		protected RMethod r_MSetOpacityValue_BMPAlloc_Single;
		public virtual RMethod RMSetOpacityValue_BMPAlloc_Single
		{
			get
			{
				if(r_MSetOpacityValue_BMPAlloc_Single == null)
				{
					r_MSetOpacityValue_BMPAlloc_Single = new(this, "SetOpacityValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"), typeof(System.Single));
					r_MSetOpacityValue_BMPAlloc_Single.SetBelong(this.instance);
				}
				return r_MSetOpacityValue_BMPAlloc_Single;
			}
		}

		/// <summary>
		/// Void SetColorValue(UnityEngine.UIElements.UIR.BMPAlloc, UnityEngine.Color)
		/// </summary>
		protected RMethod r_MSetColorValue_BMPAlloc_Color;
		public virtual RMethod RMSetColorValue_BMPAlloc_Color
		{
			get
			{
				if(r_MSetColorValue_BMPAlloc_Color == null)
				{
					r_MSetColorValue_BMPAlloc_Color = new(this, "SetColorValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"), typeof(UnityEngine.Color));
					r_MSetColorValue_BMPAlloc_Color.SetBelong(this.instance);
				}
				return r_MSetColorValue_BMPAlloc_Color;
			}
		}

		/// <summary>
		/// Void SetTextCoreSettingValue(UnityEngine.UIElements.UIR.BMPAlloc, UnityEngine.UIElements.UIR.TextCoreSettings)
		/// </summary>
		protected RMethod r_MSetTextCoreSettingValue_BMPAlloc_TextCoreSettings;
		public virtual RMethod RMSetTextCoreSettingValue_BMPAlloc_TextCoreSettings
		{
			get
			{
				if(r_MSetTextCoreSettingValue_BMPAlloc_TextCoreSettings == null)
				{
					r_MSetTextCoreSettingValue_BMPAlloc_TextCoreSettings = new(this, "SetTextCoreSettingValue", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.TextCoreSettings"));
					r_MSetTextCoreSettingValue_BMPAlloc_TextCoreSettings.SetBelong(this.instance);
				}
				return r_MSetTextCoreSettingValue_BMPAlloc_TextCoreSettings;
			}
		}

		/// <summary>
		/// Void FreeTransform(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_MFreeTransform_BMPAlloc;
		public virtual RMethod RMFreeTransform_BMPAlloc
		{
			get
			{
				if(r_MFreeTransform_BMPAlloc == null)
				{
					r_MFreeTransform_BMPAlloc = new(this, "FreeTransform", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_MFreeTransform_BMPAlloc.SetBelong(this.instance);
				}
				return r_MFreeTransform_BMPAlloc;
			}
		}

		/// <summary>
		/// Void FreeClipRect(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_MFreeClipRect_BMPAlloc;
		public virtual RMethod RMFreeClipRect_BMPAlloc
		{
			get
			{
				if(r_MFreeClipRect_BMPAlloc == null)
				{
					r_MFreeClipRect_BMPAlloc = new(this, "FreeClipRect", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_MFreeClipRect_BMPAlloc.SetBelong(this.instance);
				}
				return r_MFreeClipRect_BMPAlloc;
			}
		}

		/// <summary>
		/// Void FreeOpacity(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_MFreeOpacity_BMPAlloc;
		public virtual RMethod RMFreeOpacity_BMPAlloc
		{
			get
			{
				if(r_MFreeOpacity_BMPAlloc == null)
				{
					r_MFreeOpacity_BMPAlloc = new(this, "FreeOpacity", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_MFreeOpacity_BMPAlloc.SetBelong(this.instance);
				}
				return r_MFreeOpacity_BMPAlloc;
			}
		}

		/// <summary>
		/// Void FreeColor(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_MFreeColor_BMPAlloc;
		public virtual RMethod RMFreeColor_BMPAlloc
		{
			get
			{
				if(r_MFreeColor_BMPAlloc == null)
				{
					r_MFreeColor_BMPAlloc = new(this, "FreeColor", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_MFreeColor_BMPAlloc.SetBelong(this.instance);
				}
				return r_MFreeColor_BMPAlloc;
			}
		}

		/// <summary>
		/// Void FreeTextCoreSettings(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_MFreeTextCoreSettings_BMPAlloc;
		public virtual RMethod RMFreeTextCoreSettings_BMPAlloc
		{
			get
			{
				if(r_MFreeTextCoreSettings_BMPAlloc == null)
				{
					r_MFreeTextCoreSettings_BMPAlloc = new(this, "FreeTextCoreSettings", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_MFreeTextCoreSettings_BMPAlloc.SetBelong(this.instance);
				}
				return r_MFreeTextCoreSettings_BMPAlloc;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 TransformAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_MTransformAllocToVertexData_BMPAlloc;
		public virtual RMethod RMTransformAllocToVertexData_BMPAlloc
		{
			get
			{
				if(r_MTransformAllocToVertexData_BMPAlloc == null)
				{
					r_MTransformAllocToVertexData_BMPAlloc = new(this, "TransformAllocToVertexData", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_MTransformAllocToVertexData_BMPAlloc.SetBelong(this.instance);
				}
				return r_MTransformAllocToVertexData_BMPAlloc;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 ClipRectAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_MClipRectAllocToVertexData_BMPAlloc;
		public virtual RMethod RMClipRectAllocToVertexData_BMPAlloc
		{
			get
			{
				if(r_MClipRectAllocToVertexData_BMPAlloc == null)
				{
					r_MClipRectAllocToVertexData_BMPAlloc = new(this, "ClipRectAllocToVertexData", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_MClipRectAllocToVertexData_BMPAlloc.SetBelong(this.instance);
				}
				return r_MClipRectAllocToVertexData_BMPAlloc;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 OpacityAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_MOpacityAllocToVertexData_BMPAlloc;
		public virtual RMethod RMOpacityAllocToVertexData_BMPAlloc
		{
			get
			{
				if(r_MOpacityAllocToVertexData_BMPAlloc == null)
				{
					r_MOpacityAllocToVertexData_BMPAlloc = new(this, "OpacityAllocToVertexData", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_MOpacityAllocToVertexData_BMPAlloc.SetBelong(this.instance);
				}
				return r_MOpacityAllocToVertexData_BMPAlloc;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 ColorAllocToVertexData(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_MColorAllocToVertexData_BMPAlloc;
		public virtual RMethod RMColorAllocToVertexData_BMPAlloc
		{
			get
			{
				if(r_MColorAllocToVertexData_BMPAlloc == null)
				{
					r_MColorAllocToVertexData_BMPAlloc = new(this, "ColorAllocToVertexData", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_MColorAllocToVertexData_BMPAlloc.SetBelong(this.instance);
				}
				return r_MColorAllocToVertexData_BMPAlloc;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 TextCoreSettingsToVertexData(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected RMethod r_MTextCoreSettingsToVertexData_BMPAlloc;
		public virtual RMethod RMTextCoreSettingsToVertexData_BMPAlloc
		{
			get
			{
				if(r_MTextCoreSettingsToVertexData_BMPAlloc == null)
				{
					r_MTextCoreSettingsToVertexData_BMPAlloc = new(this, "TextCoreSettingsToVertexData", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_MTextCoreSettingsToVertexData_BMPAlloc.SetBelong(this.instance);
				}
				return r_MTextCoreSettingsToVertexData_BMPAlloc;
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

        public static UnityEngine.Vector2Int AllocToTexelCoord(ref SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 @allocator, SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@allocator.Value, @alloc.Value};
            var ___result = RMAllocToTexelCoord_Ref_BitmapAllocator32_BMPAlloc.Invoke(___genericsType, ___parameters);
			@allocator = new SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBitmapAllocator32(___parameters[0]);

            return (UnityEngine.Vector2Int)___result;
        }


        public static System.Int32 AllocToConstantBufferIndex(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RMAllocToConstantBufferIndex_BMPAlloc.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean AtlasRectMatchesPage(ref SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBitmapAllocator32 @allocator, SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc @defAlloc, UnityEngine.RectInt @atlasRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@allocator.Value, @defAlloc.Value, @atlasRect};
            var ___result = RMAtlasRectMatchesPage_Ref_BitmapAllocator32_BMPAlloc_RectInt.Invoke(___genericsType, ___parameters);
			@allocator = new SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBitmapAllocator32(___parameters[0]);

            return (System.Boolean)___result;
        }


        public virtual void Construct()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMConstruct.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReallyCreateStorage()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReallyCreateStorage.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IssuePendingStorageChanges()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIssuePendingStorageChanges.Invoke(___genericsType, ___parameters);

            
        }


        public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc AllocTransform()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAllocTransform.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc(___result);
        }


        public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc AllocClipRect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAllocClipRect.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc(___result);
        }


        public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc AllocOpacity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAllocOpacity.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc(___result);
        }


        public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc AllocColor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAllocColor.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc(___result);
        }


        public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc AllocTextCoreSettings(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTextCoreSettings @settings)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@settings.Value};
            var ___result = RMAllocTextCoreSettings_TextCoreSettings.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc(___result);
        }


        public virtual void SetTransformValue(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc, UnityEngine.Matrix4x4 @xform)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value, @xform};
            var ___result = RMSetTransformValue_BMPAlloc_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetClipRectValue(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc, UnityEngine.Vector4 @clipRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value, @clipRect};
            var ___result = RMSetClipRectValue_BMPAlloc_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetOpacityValue(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc, System.Single @opacity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value, @opacity};
            var ___result = RMSetOpacityValue_BMPAlloc_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColorValue(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc, UnityEngine.Color @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value, @color};
            var ___result = RMSetColorValue_BMPAlloc_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTextCoreSettingValue(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc, SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTextCoreSettings @settings)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value, @settings.Value};
            var ___result = RMSetTextCoreSettingValue_BMPAlloc_TextCoreSettings.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FreeTransform(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RMFreeTransform_BMPAlloc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FreeClipRect(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RMFreeClipRect_BMPAlloc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FreeOpacity(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RMFreeOpacity_BMPAlloc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FreeColor(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RMFreeColor_BMPAlloc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FreeTextCoreSettings(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RMFreeTextCoreSettings_BMPAlloc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Color32 TransformAllocToVertexData(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RMTransformAllocToVertexData_BMPAlloc.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color32)___result;
        }


        public virtual UnityEngine.Color32 ClipRectAllocToVertexData(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RMClipRectAllocToVertexData_BMPAlloc.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color32)___result;
        }


        public virtual UnityEngine.Color32 OpacityAllocToVertexData(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RMOpacityAllocToVertexData_BMPAlloc.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color32)___result;
        }


        public virtual UnityEngine.Color32 ColorAllocToVertexData(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RMColorAllocToVertexData_BMPAlloc.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color32)___result;
        }


        public virtual UnityEngine.Color32 TextCoreSettingsToVertexData(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RMTextCoreSettingsToVertexData_BMPAlloc.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color32)___result;
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
