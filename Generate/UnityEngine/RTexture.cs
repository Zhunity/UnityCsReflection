using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Texture
	/// </summary>
    public partial class RTexture : RMember //
    {

		/// <summary>
		/// System.Int32 GenerateAllMips
		/// </summary>
		protected static RField r_GenerateAllMips;
		public static RField RGenerateAllMips
		{
			get
			{
				if(r_GenerateAllMips == null)
				{
					r_GenerateAllMips = new(typeof(UnityEngine.Texture), "GenerateAllMips");
					r_GenerateAllMips.SetBelong(null);
				}
				return r_GenerateAllMips;
			}
		}

		/// <summary>
		/// Int32 masterTextureLimit
		/// </summary>
		protected static RProperty r_masterTextureLimit;
		public static RProperty RmasterTextureLimit
		{
			get
			{
				if(r_masterTextureLimit == null)
				{
					r_masterTextureLimit = new(typeof(UnityEngine.Texture), "masterTextureLimit", -1);
					r_masterTextureLimit.SetBelong(null);
				}
				return r_masterTextureLimit;
			}
		}

		/// <summary>
		/// Int32 globalMipmapLimit
		/// </summary>
		protected static RProperty r_globalMipmapLimit;
		public static RProperty RglobalMipmapLimit
		{
			get
			{
				if(r_globalMipmapLimit == null)
				{
					r_globalMipmapLimit = new(typeof(UnityEngine.Texture), "globalMipmapLimit", -1);
					r_globalMipmapLimit.SetBelong(null);
				}
				return r_globalMipmapLimit;
			}
		}

		/// <summary>
		/// Int32 mipmapCount
		/// </summary>
		protected RProperty r_mipmapCount;
		public virtual RProperty RmipmapCount
		{
			get
			{
				if(r_mipmapCount == null)
				{
					r_mipmapCount = new(this, "mipmapCount", -1);
					r_mipmapCount.SetBelong(this.instance);
				}
				return r_mipmapCount;
			}
		}

		/// <summary>
		/// UnityEngine.AnisotropicFiltering anisotropicFiltering
		/// </summary>
		protected static RProperty r_anisotropicFiltering;
		public static RProperty RanisotropicFiltering
		{
			get
			{
				if(r_anisotropicFiltering == null)
				{
					r_anisotropicFiltering = new(typeof(UnityEngine.Texture), "anisotropicFiltering", -1);
					r_anisotropicFiltering.SetBelong(null);
				}
				return r_anisotropicFiltering;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat
		/// </summary>
		protected RProperty r_graphicsFormat;
		public virtual RProperty RgraphicsFormat
		{
			get
			{
				if(r_graphicsFormat == null)
				{
					r_graphicsFormat = new(this, "graphicsFormat", -1);
					r_graphicsFormat.SetBelong(this.instance);
				}
				return r_graphicsFormat;
			}
		}

		/// <summary>
		/// Int32 width
		/// </summary>
		protected RProperty r_width;
		public virtual RProperty Rwidth
		{
			get
			{
				if(r_width == null)
				{
					r_width = new(this, "width", -1);
					r_width.SetBelong(this.instance);
				}
				return r_width;
			}
		}

		/// <summary>
		/// Int32 height
		/// </summary>
		protected RProperty r_height;
		public virtual RProperty Rheight
		{
			get
			{
				if(r_height == null)
				{
					r_height = new(this, "height", -1);
					r_height.SetBelong(this.instance);
				}
				return r_height;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.TextureDimension dimension
		/// </summary>
		protected RProperty r_dimension;
		public virtual RProperty Rdimension
		{
			get
			{
				if(r_dimension == null)
				{
					r_dimension = new(this, "dimension", -1);
					r_dimension.SetBelong(this.instance);
				}
				return r_dimension;
			}
		}

		/// <summary>
		/// Boolean isReadable
		/// </summary>
		protected RProperty r_isReadable;
		public virtual RProperty RisReadable
		{
			get
			{
				if(r_isReadable == null)
				{
					r_isReadable = new(this, "isReadable", -1);
					r_isReadable.SetBelong(this.instance);
				}
				return r_isReadable;
			}
		}

		/// <summary>
		/// UnityEngine.TextureWrapMode wrapMode
		/// </summary>
		protected RProperty r_wrapMode;
		public virtual RProperty RwrapMode
		{
			get
			{
				if(r_wrapMode == null)
				{
					r_wrapMode = new(this, "wrapMode", -1);
					r_wrapMode.SetBelong(this.instance);
				}
				return r_wrapMode;
			}
		}

		/// <summary>
		/// UnityEngine.TextureWrapMode wrapModeU
		/// </summary>
		protected RProperty r_wrapModeU;
		public virtual RProperty RwrapModeU
		{
			get
			{
				if(r_wrapModeU == null)
				{
					r_wrapModeU = new(this, "wrapModeU", -1);
					r_wrapModeU.SetBelong(this.instance);
				}
				return r_wrapModeU;
			}
		}

		/// <summary>
		/// UnityEngine.TextureWrapMode wrapModeV
		/// </summary>
		protected RProperty r_wrapModeV;
		public virtual RProperty RwrapModeV
		{
			get
			{
				if(r_wrapModeV == null)
				{
					r_wrapModeV = new(this, "wrapModeV", -1);
					r_wrapModeV.SetBelong(this.instance);
				}
				return r_wrapModeV;
			}
		}

		/// <summary>
		/// UnityEngine.TextureWrapMode wrapModeW
		/// </summary>
		protected RProperty r_wrapModeW;
		public virtual RProperty RwrapModeW
		{
			get
			{
				if(r_wrapModeW == null)
				{
					r_wrapModeW = new(this, "wrapModeW", -1);
					r_wrapModeW.SetBelong(this.instance);
				}
				return r_wrapModeW;
			}
		}

		/// <summary>
		/// UnityEngine.FilterMode filterMode
		/// </summary>
		protected RProperty r_filterMode;
		public virtual RProperty RfilterMode
		{
			get
			{
				if(r_filterMode == null)
				{
					r_filterMode = new(this, "filterMode", -1);
					r_filterMode.SetBelong(this.instance);
				}
				return r_filterMode;
			}
		}

		/// <summary>
		/// Int32 anisoLevel
		/// </summary>
		protected RProperty r_anisoLevel;
		public virtual RProperty RanisoLevel
		{
			get
			{
				if(r_anisoLevel == null)
				{
					r_anisoLevel = new(this, "anisoLevel", -1);
					r_anisoLevel.SetBelong(this.instance);
				}
				return r_anisoLevel;
			}
		}

		/// <summary>
		/// Single mipMapBias
		/// </summary>
		protected RProperty r_mipMapBias;
		public virtual RProperty RmipMapBias
		{
			get
			{
				if(r_mipMapBias == null)
				{
					r_mipMapBias = new(this, "mipMapBias", -1);
					r_mipMapBias.SetBelong(this.instance);
				}
				return r_mipMapBias;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 texelSize
		/// </summary>
		protected RUnityEngine.RVector2 r_texelSize;
		public virtual RUnityEngine.RVector2 RtexelSize
		{
			get
			{
				if(r_texelSize == null)
				{
					r_texelSize = new(this, "texelSize", -1);
					r_texelSize.SetBelong(this.instance);
				}
				return r_texelSize;
			}
		}

		/// <summary>
		/// UInt32 updateCount
		/// </summary>
		protected RProperty r_updateCount;
		public virtual RProperty RupdateCount
		{
			get
			{
				if(r_updateCount == null)
				{
					r_updateCount = new(this, "updateCount", -1);
					r_updateCount.SetBelong(this.instance);
				}
				return r_updateCount;
			}
		}

		/// <summary>
		/// UnityEngine.ColorSpace activeTextureColorSpace
		/// </summary>
		protected RProperty r_activeTextureColorSpace;
		public virtual RProperty RactiveTextureColorSpace
		{
			get
			{
				if(r_activeTextureColorSpace == null)
				{
					r_activeTextureColorSpace = new(this, "activeTextureColorSpace", -1);
					r_activeTextureColorSpace.SetBelong(this.instance);
				}
				return r_activeTextureColorSpace;
			}
		}

		/// <summary>
		/// Boolean isDataSRGB
		/// </summary>
		protected RProperty r_isDataSRGB;
		public virtual RProperty RisDataSRGB
		{
			get
			{
				if(r_isDataSRGB == null)
				{
					r_isDataSRGB = new(this, "isDataSRGB", -1);
					r_isDataSRGB.SetBelong(this.instance);
				}
				return r_isDataSRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 imageContentsHash
		/// </summary>
		protected RUnityEngine.RHash128 r_imageContentsHash;
		public virtual RUnityEngine.RHash128 RimageContentsHash
		{
			get
			{
				if(r_imageContentsHash == null)
				{
					r_imageContentsHash = new(this, "imageContentsHash", -1);
					r_imageContentsHash.SetBelong(this.instance);
				}
				return r_imageContentsHash;
			}
		}

		/// <summary>
		/// UInt64 totalTextureMemory
		/// </summary>
		protected static RProperty r_totalTextureMemory;
		public static RProperty RtotalTextureMemory
		{
			get
			{
				if(r_totalTextureMemory == null)
				{
					r_totalTextureMemory = new(typeof(UnityEngine.Texture), "totalTextureMemory", -1);
					r_totalTextureMemory.SetBelong(null);
				}
				return r_totalTextureMemory;
			}
		}

		/// <summary>
		/// UInt64 desiredTextureMemory
		/// </summary>
		protected static RProperty r_desiredTextureMemory;
		public static RProperty RdesiredTextureMemory
		{
			get
			{
				if(r_desiredTextureMemory == null)
				{
					r_desiredTextureMemory = new(typeof(UnityEngine.Texture), "desiredTextureMemory", -1);
					r_desiredTextureMemory.SetBelong(null);
				}
				return r_desiredTextureMemory;
			}
		}

		/// <summary>
		/// UInt64 targetTextureMemory
		/// </summary>
		protected static RProperty r_targetTextureMemory;
		public static RProperty RtargetTextureMemory
		{
			get
			{
				if(r_targetTextureMemory == null)
				{
					r_targetTextureMemory = new(typeof(UnityEngine.Texture), "targetTextureMemory", -1);
					r_targetTextureMemory.SetBelong(null);
				}
				return r_targetTextureMemory;
			}
		}

		/// <summary>
		/// UInt64 currentTextureMemory
		/// </summary>
		protected static RProperty r_currentTextureMemory;
		public static RProperty RcurrentTextureMemory
		{
			get
			{
				if(r_currentTextureMemory == null)
				{
					r_currentTextureMemory = new(typeof(UnityEngine.Texture), "currentTextureMemory", -1);
					r_currentTextureMemory.SetBelong(null);
				}
				return r_currentTextureMemory;
			}
		}

		/// <summary>
		/// UInt64 nonStreamingTextureMemory
		/// </summary>
		protected static RProperty r_nonStreamingTextureMemory;
		public static RProperty RnonStreamingTextureMemory
		{
			get
			{
				if(r_nonStreamingTextureMemory == null)
				{
					r_nonStreamingTextureMemory = new(typeof(UnityEngine.Texture), "nonStreamingTextureMemory", -1);
					r_nonStreamingTextureMemory.SetBelong(null);
				}
				return r_nonStreamingTextureMemory;
			}
		}

		/// <summary>
		/// UInt64 streamingMipmapUploadCount
		/// </summary>
		protected static RProperty r_streamingMipmapUploadCount;
		public static RProperty RstreamingMipmapUploadCount
		{
			get
			{
				if(r_streamingMipmapUploadCount == null)
				{
					r_streamingMipmapUploadCount = new(typeof(UnityEngine.Texture), "streamingMipmapUploadCount", -1);
					r_streamingMipmapUploadCount.SetBelong(null);
				}
				return r_streamingMipmapUploadCount;
			}
		}

		/// <summary>
		/// UInt64 streamingRendererCount
		/// </summary>
		protected static RProperty r_streamingRendererCount;
		public static RProperty RstreamingRendererCount
		{
			get
			{
				if(r_streamingRendererCount == null)
				{
					r_streamingRendererCount = new(typeof(UnityEngine.Texture), "streamingRendererCount", -1);
					r_streamingRendererCount.SetBelong(null);
				}
				return r_streamingRendererCount;
			}
		}

		/// <summary>
		/// UInt64 streamingTextureCount
		/// </summary>
		protected static RProperty r_streamingTextureCount;
		public static RProperty RstreamingTextureCount
		{
			get
			{
				if(r_streamingTextureCount == null)
				{
					r_streamingTextureCount = new(typeof(UnityEngine.Texture), "streamingTextureCount", -1);
					r_streamingTextureCount.SetBelong(null);
				}
				return r_streamingTextureCount;
			}
		}

		/// <summary>
		/// UInt64 nonStreamingTextureCount
		/// </summary>
		protected static RProperty r_nonStreamingTextureCount;
		public static RProperty RnonStreamingTextureCount
		{
			get
			{
				if(r_nonStreamingTextureCount == null)
				{
					r_nonStreamingTextureCount = new(typeof(UnityEngine.Texture), "nonStreamingTextureCount", -1);
					r_nonStreamingTextureCount.SetBelong(null);
				}
				return r_nonStreamingTextureCount;
			}
		}

		/// <summary>
		/// UInt64 streamingTexturePendingLoadCount
		/// </summary>
		protected static RProperty r_streamingTexturePendingLoadCount;
		public static RProperty RstreamingTexturePendingLoadCount
		{
			get
			{
				if(r_streamingTexturePendingLoadCount == null)
				{
					r_streamingTexturePendingLoadCount = new(typeof(UnityEngine.Texture), "streamingTexturePendingLoadCount", -1);
					r_streamingTexturePendingLoadCount.SetBelong(null);
				}
				return r_streamingTexturePendingLoadCount;
			}
		}

		/// <summary>
		/// UInt64 streamingTextureLoadingCount
		/// </summary>
		protected static RProperty r_streamingTextureLoadingCount;
		public static RProperty RstreamingTextureLoadingCount
		{
			get
			{
				if(r_streamingTextureLoadingCount == null)
				{
					r_streamingTextureLoadingCount = new(typeof(UnityEngine.Texture), "streamingTextureLoadingCount", -1);
					r_streamingTextureLoadingCount.SetBelong(null);
				}
				return r_streamingTextureLoadingCount;
			}
		}

		/// <summary>
		/// Boolean streamingTextureForceLoadAll
		/// </summary>
		protected static RProperty r_streamingTextureForceLoadAll;
		public static RProperty RstreamingTextureForceLoadAll
		{
			get
			{
				if(r_streamingTextureForceLoadAll == null)
				{
					r_streamingTextureForceLoadAll = new(typeof(UnityEngine.Texture), "streamingTextureForceLoadAll", -1);
					r_streamingTextureForceLoadAll.SetBelong(null);
				}
				return r_streamingTextureForceLoadAll;
			}
		}

		/// <summary>
		/// Boolean streamingTextureDiscardUnusedMips
		/// </summary>
		protected static RProperty r_streamingTextureDiscardUnusedMips;
		public static RProperty RstreamingTextureDiscardUnusedMips
		{
			get
			{
				if(r_streamingTextureDiscardUnusedMips == null)
				{
					r_streamingTextureDiscardUnusedMips = new(typeof(UnityEngine.Texture), "streamingTextureDiscardUnusedMips", -1);
					r_streamingTextureDiscardUnusedMips.SetBelong(null);
				}
				return r_streamingTextureDiscardUnusedMips;
			}
		}

		/// <summary>
		/// Boolean allowThreadedTextureCreation
		/// </summary>
		protected static RProperty r_allowThreadedTextureCreation;
		public static RProperty RallowThreadedTextureCreation
		{
			get
			{
				if(r_allowThreadedTextureCreation == null)
				{
					r_allowThreadedTextureCreation = new(typeof(UnityEngine.Texture), "allowThreadedTextureCreation", -1);
					r_allowThreadedTextureCreation.SetBelong(null);
				}
				return r_allowThreadedTextureCreation;
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
		/// Void SetGlobalAnisotropicFilteringLimits(Int32, Int32)
		/// </summary>
		protected static RMethod r_RSetGlobalAnisotropicFilteringLimits_Int32_Int32;
		public static RMethod RSetGlobalAnisotropicFilteringLimits_Int32_Int32
		{
			get
			{
				if(r_RSetGlobalAnisotropicFilteringLimits_Int32_Int32 == null)
				{
					r_RSetGlobalAnisotropicFilteringLimits_Int32_Int32 = new(typeof(UnityEngine.Texture), "SetGlobalAnisotropicFilteringLimits", 0, typeof(System.Int32), typeof(System.Int32));
					r_RSetGlobalAnisotropicFilteringLimits_Int32_Int32.SetBelong(null);
				}
				return r_RSetGlobalAnisotropicFilteringLimits_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetDataWidth()
		/// </summary>
		protected RMethod r_RGetDataWidth;
		public virtual RMethod RGetDataWidth
		{
			get
			{
				if(r_RGetDataWidth == null)
				{
					r_RGetDataWidth = new(this, "GetDataWidth", 0);
					r_RGetDataWidth.SetBelong(this.instance);
				}
				return r_RGetDataWidth;
			}
		}

		/// <summary>
		/// Int32 GetDataHeight()
		/// </summary>
		protected RMethod r_RGetDataHeight;
		public virtual RMethod RGetDataHeight
		{
			get
			{
				if(r_RGetDataHeight == null)
				{
					r_RGetDataHeight = new(this, "GetDataHeight", 0);
					r_RGetDataHeight.SetBelong(this.instance);
				}
				return r_RGetDataHeight;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.TextureDimension GetDimension()
		/// </summary>
		protected RMethod r_RGetDimension;
		public virtual RMethod RGetDimension
		{
			get
			{
				if(r_RGetDimension == null)
				{
					r_RGetDimension = new(this, "GetDimension", 0);
					r_RGetDimension.SetBelong(this.instance);
				}
				return r_RGetDimension;
			}
		}

		/// <summary>
		/// IntPtr GetNativeTexturePtr()
		/// </summary>
		protected RMethod r_RGetNativeTexturePtr;
		public virtual RMethod RGetNativeTexturePtr
		{
			get
			{
				if(r_RGetNativeTexturePtr == null)
				{
					r_RGetNativeTexturePtr = new(this, "GetNativeTexturePtr", 0);
					r_RGetNativeTexturePtr.SetBelong(this.instance);
				}
				return r_RGetNativeTexturePtr;
			}
		}

		/// <summary>
		/// Int32 GetNativeTextureID()
		/// </summary>
		protected RMethod r_RGetNativeTextureID;
		public virtual RMethod RGetNativeTextureID
		{
			get
			{
				if(r_RGetNativeTextureID == null)
				{
					r_RGetNativeTextureID = new(this, "GetNativeTextureID", 0);
					r_RGetNativeTextureID.SetBelong(this.instance);
				}
				return r_RGetNativeTextureID;
			}
		}

		/// <summary>
		/// Void IncrementUpdateCount()
		/// </summary>
		protected RMethod r_RIncrementUpdateCount;
		public virtual RMethod RIncrementUpdateCount
		{
			get
			{
				if(r_RIncrementUpdateCount == null)
				{
					r_RIncrementUpdateCount = new(this, "IncrementUpdateCount", 0);
					r_RIncrementUpdateCount.SetBelong(this.instance);
				}
				return r_RIncrementUpdateCount;
			}
		}

		/// <summary>
		/// Int32 Internal_GetActiveTextureColorSpace()
		/// </summary>
		protected RMethod r_RInternal_GetActiveTextureColorSpace;
		public virtual RMethod RInternal_GetActiveTextureColorSpace
		{
			get
			{
				if(r_RInternal_GetActiveTextureColorSpace == null)
				{
					r_RInternal_GetActiveTextureColorSpace = new(this, "Internal_GetActiveTextureColorSpace", 0);
					r_RInternal_GetActiveTextureColorSpace.SetBelong(this.instance);
				}
				return r_RInternal_GetActiveTextureColorSpace;
			}
		}

		/// <summary>
		/// UnityEngine.TextureColorSpace Internal_GetStoredColorSpace()
		/// </summary>
		protected RMethod r_RInternal_GetStoredColorSpace;
		public virtual RMethod RInternal_GetStoredColorSpace
		{
			get
			{
				if(r_RInternal_GetStoredColorSpace == null)
				{
					r_RInternal_GetStoredColorSpace = new(this, "Internal_GetStoredColorSpace", 0);
					r_RInternal_GetStoredColorSpace.SetBelong(this.instance);
				}
				return r_RInternal_GetStoredColorSpace;
			}
		}

		/// <summary>
		/// Void SetStreamingTextureMaterialDebugProperties()
		/// </summary>
		protected static RMethod r_RSetStreamingTextureMaterialDebugProperties;
		public static RMethod RSetStreamingTextureMaterialDebugProperties
		{
			get
			{
				if(r_RSetStreamingTextureMaterialDebugProperties == null)
				{
					r_RSetStreamingTextureMaterialDebugProperties = new(typeof(UnityEngine.Texture), "SetStreamingTextureMaterialDebugProperties", 0);
					r_RSetStreamingTextureMaterialDebugProperties.SetBelong(null);
				}
				return r_RSetStreamingTextureMaterialDebugProperties;
			}
		}

		/// <summary>
		/// UInt64 GetPixelDataSize(Int32, Int32)
		/// </summary>
		protected RMethod r_RGetPixelDataSize_Int32_Int32;
		public virtual RMethod RGetPixelDataSize_Int32_Int32
		{
			get
			{
				if(r_RGetPixelDataSize_Int32_Int32 == null)
				{
					r_RGetPixelDataSize_Int32_Int32 = new(this, "GetPixelDataSize", 0, typeof(System.Int32), typeof(System.Int32));
					r_RGetPixelDataSize_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetPixelDataSize_Int32_Int32;
			}
		}

		/// <summary>
		/// UInt64 GetPixelDataOffset(Int32, Int32)
		/// </summary>
		protected RMethod r_RGetPixelDataOffset_Int32_Int32;
		public virtual RMethod RGetPixelDataOffset_Int32_Int32
		{
			get
			{
				if(r_RGetPixelDataOffset_Int32_Int32 == null)
				{
					r_RGetPixelDataOffset_Int32_Int32 = new(this, "GetPixelDataOffset", 0, typeof(System.Int32), typeof(System.Int32));
					r_RGetPixelDataOffset_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetPixelDataOffset_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean ValidateFormat(UnityEngine.RenderTextureFormat)
		/// </summary>
		protected RMethod r_RValidateFormat_RenderTextureFormat;
		public virtual RMethod RValidateFormat_RenderTextureFormat
		{
			get
			{
				if(r_RValidateFormat_RenderTextureFormat == null)
				{
					r_RValidateFormat_RenderTextureFormat = new(this, "ValidateFormat", 0, typeof(UnityEngine.RenderTextureFormat));
					r_RValidateFormat_RenderTextureFormat.SetBelong(this.instance);
				}
				return r_RValidateFormat_RenderTextureFormat;
			}
		}

		/// <summary>
		/// Boolean ValidateFormat(UnityEngine.TextureFormat)
		/// </summary>
		protected RMethod r_RValidateFormat_TextureFormat;
		public virtual RMethod RValidateFormat_TextureFormat
		{
			get
			{
				if(r_RValidateFormat_TextureFormat == null)
				{
					r_RValidateFormat_TextureFormat = new(this, "ValidateFormat", 0, typeof(UnityEngine.TextureFormat));
					r_RValidateFormat_TextureFormat.SetBelong(this.instance);
				}
				return r_RValidateFormat_TextureFormat;
			}
		}

		/// <summary>
		/// Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat, UnityEngine.Experimental.Rendering.FormatUsage)
		/// </summary>
		protected RMethod r_RValidateFormat_GraphicsFormat_FormatUsage;
		public virtual RMethod RValidateFormat_GraphicsFormat_FormatUsage
		{
			get
			{
				if(r_RValidateFormat_GraphicsFormat_FormatUsage == null)
				{
					r_RValidateFormat_GraphicsFormat_FormatUsage = new(this, "ValidateFormat", 0, typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(UnityEngine.Experimental.Rendering.FormatUsage));
					r_RValidateFormat_GraphicsFormat_FormatUsage.SetBelong(this.instance);
				}
				return r_RValidateFormat_GraphicsFormat_FormatUsage;
			}
		}

		/// <summary>
		/// UnityEngine.UnityException CreateNonReadableException(UnityEngine.Texture)
		/// </summary>
		protected RMethod r_RCreateNonReadableException_Texture;
		public virtual RMethod RCreateNonReadableException_Texture
		{
			get
			{
				if(r_RCreateNonReadableException_Texture == null)
				{
					r_RCreateNonReadableException_Texture = new(this, "CreateNonReadableException", 0, typeof(UnityEngine.Texture));
					r_RCreateNonReadableException_Texture.SetBelong(this.instance);
				}
				return r_RCreateNonReadableException_Texture;
			}
		}

		/// <summary>
		/// UnityEngine.UnityException CreateNativeArrayLengthOverflowException()
		/// </summary>
		protected RMethod r_RCreateNativeArrayLengthOverflowException;
		public virtual RMethod RCreateNativeArrayLengthOverflowException
		{
			get
			{
				if(r_RCreateNativeArrayLengthOverflowException == null)
				{
					r_RCreateNativeArrayLengthOverflowException = new(this, "CreateNativeArrayLengthOverflowException", 0);
					r_RCreateNativeArrayLengthOverflowException.SetBelong(this.instance);
				}
				return r_RCreateNativeArrayLengthOverflowException;
			}
		}

		/// <summary>
		/// Void get_texelSize_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Rget_texelSize_Injected_Out_Vector2;
		public virtual RMethod Rget_texelSize_Injected_Out_Vector2
		{
			get
			{
				if(r_Rget_texelSize_Injected_Out_Vector2 == null)
				{
					r_Rget_texelSize_Injected_Out_Vector2 = new(this, "get_texelSize_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Rget_texelSize_Injected_Out_Vector2.SetBelong(this.instance);
				}
				return r_Rget_texelSize_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void get_imageContentsHash_Injected(UnityEngine.Hash128 ByRef)
		/// </summary>
		protected RMethod r_Rget_imageContentsHash_Injected_Out_Hash128;
		public virtual RMethod Rget_imageContentsHash_Injected_Out_Hash128
		{
			get
			{
				if(r_Rget_imageContentsHash_Injected_Out_Hash128 == null)
				{
					r_Rget_imageContentsHash_Injected_Out_Hash128 = new(this, "get_imageContentsHash_Injected", 0, typeof(UnityEngine.Hash128).MakeByRefType());
					r_Rget_imageContentsHash_Injected_Out_Hash128.SetBelong(this.instance);
				}
				return r_Rget_imageContentsHash_Injected_Out_Hash128;
			}
		}

		/// <summary>
		/// Void set_imageContentsHash_Injected(UnityEngine.Hash128 ByRef)
		/// </summary>
		protected RMethod r_Rset_imageContentsHash_Injected_Ref_Hash128;
		public virtual RMethod Rset_imageContentsHash_Injected_Ref_Hash128
		{
			get
			{
				if(r_Rset_imageContentsHash_Injected_Ref_Hash128 == null)
				{
					r_Rset_imageContentsHash_Injected_Ref_Hash128 = new(this, "set_imageContentsHash_Injected", 0, typeof(UnityEngine.Hash128).MakeByRefType());
					r_Rset_imageContentsHash_Injected_Ref_Hash128.SetBelong(this.instance);
				}
				return r_Rset_imageContentsHash_Injected_Ref_Hash128;
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


        public RTexture() : base("UnityEngine.Texture")
        {
        }

        public RTexture(System.Object instance) : base("UnityEngine.Texture")
		{
            SetInstance(instance);
		}

        public RTexture(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTexture(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void SetGlobalAnisotropicFilteringLimits(System.Int32  @forcedMin, System.Int32  @globalMax)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@forcedMin, @globalMax};
            var ___result = RSetGlobalAnisotropicFilteringLimits_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetDataWidth()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDataWidth.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetDataHeight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDataHeight.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Rendering.TextureDimension GetDimension()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDimension.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.TextureDimension)___result;
        }


        public virtual System.IntPtr GetNativeTexturePtr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNativeTexturePtr.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.Int32 GetNativeTextureID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNativeTextureID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void IncrementUpdateCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIncrementUpdateCount.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 Internal_GetActiveTextureColorSpace()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternal_GetActiveTextureColorSpace.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Object Internal_GetStoredColorSpace()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternal_GetStoredColorSpace.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static void SetStreamingTextureMaterialDebugProperties()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetStreamingTextureMaterialDebugProperties.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.UInt64 GetPixelDataSize(System.Int32  @mipLevel, System.Int32  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mipLevel, @element};
            var ___result = RGetPixelDataSize_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual System.UInt64 GetPixelDataOffset(System.Int32  @mipLevel, System.Int32  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mipLevel, @element};
            var ___result = RGetPixelDataOffset_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual System.Boolean ValidateFormat(UnityEngine.RenderTextureFormat  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RValidateFormat_RenderTextureFormat.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValidateFormat(UnityEngine.TextureFormat  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RValidateFormat_TextureFormat.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat  @format, UnityEngine.Experimental.Rendering.FormatUsage  @usage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @usage};
            var ___result = RValidateFormat_GraphicsFormat_FormatUsage.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.UnityException CreateNonReadableException(UnityEngine.Texture  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RCreateNonReadableException_Texture.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UnityException)___result;
        }


        public virtual UnityEngine.UnityException CreateNativeArrayLengthOverflowException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateNativeArrayLengthOverflowException.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UnityException)___result;
        }


        public virtual void get_texelSize_Injected(out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_texelSize_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void get_imageContentsHash_Injected(out UnityEngine.Hash128  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_imageContentsHash_Injected_Out_Hash128.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Hash128)___parameters[0];

            
        }


        public virtual void set_imageContentsHash_Injected(ref UnityEngine.Hash128  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_imageContentsHash_Injected_Ref_Hash128.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Hash128)___parameters[0];

            
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
