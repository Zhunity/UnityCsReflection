using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.RenderTexture
	/// </summary>
    public partial class RRenderTexture : RMember //
    {

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
		/// Boolean useMipMap
		/// </summary>
		protected RProperty r_useMipMap;
		public virtual RProperty RuseMipMap
		{
			get
			{
				if(r_useMipMap == null)
				{
					r_useMipMap = new(this, "useMipMap", -1);
					r_useMipMap.SetBelong(this.instance);
				}
				return r_useMipMap;
			}
		}

		/// <summary>
		/// Boolean sRGB
		/// </summary>
		protected RProperty r_sRGB;
		public virtual RProperty RsRGB
		{
			get
			{
				if(r_sRGB == null)
				{
					r_sRGB = new(this, "sRGB", -1);
					r_sRGB.SetBelong(this.instance);
				}
				return r_sRGB;
			}
		}

		/// <summary>
		/// UnityEngine.VRTextureUsage vrUsage
		/// </summary>
		protected RProperty r_vrUsage;
		public virtual RProperty RvrUsage
		{
			get
			{
				if(r_vrUsage == null)
				{
					r_vrUsage = new(this, "vrUsage", -1);
					r_vrUsage.SetBelong(this.instance);
				}
				return r_vrUsage;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTextureMemoryless memorylessMode
		/// </summary>
		protected RProperty r_memorylessMode;
		public virtual RProperty RmemorylessMode
		{
			get
			{
				if(r_memorylessMode == null)
				{
					r_memorylessMode = new(this, "memorylessMode", -1);
					r_memorylessMode.SetBelong(this.instance);
				}
				return r_memorylessMode;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTextureFormat format
		/// </summary>
		protected RProperty r_format;
		public virtual RProperty Rformat
		{
			get
			{
				if(r_format == null)
				{
					r_format = new(this, "format", -1);
					r_format.SetBelong(this.instance);
				}
				return r_format;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat stencilFormat
		/// </summary>
		protected RProperty r_stencilFormat;
		public virtual RProperty RstencilFormat
		{
			get
			{
				if(r_stencilFormat == null)
				{
					r_stencilFormat = new(this, "stencilFormat", -1);
					r_stencilFormat.SetBelong(this.instance);
				}
				return r_stencilFormat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat
		/// </summary>
		protected RProperty r_depthStencilFormat;
		public virtual RProperty RdepthStencilFormat
		{
			get
			{
				if(r_depthStencilFormat == null)
				{
					r_depthStencilFormat = new(this, "depthStencilFormat", -1);
					r_depthStencilFormat.SetBelong(this.instance);
				}
				return r_depthStencilFormat;
			}
		}

		/// <summary>
		/// Boolean autoGenerateMips
		/// </summary>
		protected RProperty r_autoGenerateMips;
		public virtual RProperty RautoGenerateMips
		{
			get
			{
				if(r_autoGenerateMips == null)
				{
					r_autoGenerateMips = new(this, "autoGenerateMips", -1);
					r_autoGenerateMips.SetBelong(this.instance);
				}
				return r_autoGenerateMips;
			}
		}

		/// <summary>
		/// Int32 volumeDepth
		/// </summary>
		protected RProperty r_volumeDepth;
		public virtual RProperty RvolumeDepth
		{
			get
			{
				if(r_volumeDepth == null)
				{
					r_volumeDepth = new(this, "volumeDepth", -1);
					r_volumeDepth.SetBelong(this.instance);
				}
				return r_volumeDepth;
			}
		}

		/// <summary>
		/// Int32 antiAliasing
		/// </summary>
		protected RProperty r_antiAliasing;
		public virtual RProperty RantiAliasing
		{
			get
			{
				if(r_antiAliasing == null)
				{
					r_antiAliasing = new(this, "antiAliasing", -1);
					r_antiAliasing.SetBelong(this.instance);
				}
				return r_antiAliasing;
			}
		}

		/// <summary>
		/// Boolean bindTextureMS
		/// </summary>
		protected RProperty r_bindTextureMS;
		public virtual RProperty RbindTextureMS
		{
			get
			{
				if(r_bindTextureMS == null)
				{
					r_bindTextureMS = new(this, "bindTextureMS", -1);
					r_bindTextureMS.SetBelong(this.instance);
				}
				return r_bindTextureMS;
			}
		}

		/// <summary>
		/// Boolean enableRandomWrite
		/// </summary>
		protected RProperty r_enableRandomWrite;
		public virtual RProperty RenableRandomWrite
		{
			get
			{
				if(r_enableRandomWrite == null)
				{
					r_enableRandomWrite = new(this, "enableRandomWrite", -1);
					r_enableRandomWrite.SetBelong(this.instance);
				}
				return r_enableRandomWrite;
			}
		}

		/// <summary>
		/// Boolean useDynamicScale
		/// </summary>
		protected RProperty r_useDynamicScale;
		public virtual RProperty RuseDynamicScale
		{
			get
			{
				if(r_useDynamicScale == null)
				{
					r_useDynamicScale = new(this, "useDynamicScale", -1);
					r_useDynamicScale.SetBelong(this.instance);
				}
				return r_useDynamicScale;
			}
		}

		/// <summary>
		/// Boolean isPowerOfTwo
		/// </summary>
		protected RProperty r_isPowerOfTwo;
		public virtual RProperty RisPowerOfTwo
		{
			get
			{
				if(r_isPowerOfTwo == null)
				{
					r_isPowerOfTwo = new(this, "isPowerOfTwo", -1);
					r_isPowerOfTwo.SetBelong(this.instance);
				}
				return r_isPowerOfTwo;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture active
		/// </summary>
		protected static RUnityEngine.RRenderTexture r_active;
		public static RUnityEngine.RRenderTexture Ractive
		{
			get
			{
				if(r_active == null)
				{
					r_active = new(typeof(UnityEngine.RenderTexture), "active", -1);
					r_active.SetBelong(null);
				}
				return r_active;
			}
		}

		/// <summary>
		/// UnityEngine.RenderBuffer colorBuffer
		/// </summary>
		protected RUnityEngine.RRenderBuffer r_colorBuffer;
		public virtual RUnityEngine.RRenderBuffer RcolorBuffer
		{
			get
			{
				if(r_colorBuffer == null)
				{
					r_colorBuffer = new(this, "colorBuffer", -1);
					r_colorBuffer.SetBelong(this.instance);
				}
				return r_colorBuffer;
			}
		}

		/// <summary>
		/// UnityEngine.RenderBuffer depthBuffer
		/// </summary>
		protected RUnityEngine.RRenderBuffer r_depthBuffer;
		public virtual RUnityEngine.RRenderBuffer RdepthBuffer
		{
			get
			{
				if(r_depthBuffer == null)
				{
					r_depthBuffer = new(this, "depthBuffer", -1);
					r_depthBuffer.SetBelong(this.instance);
				}
				return r_depthBuffer;
			}
		}

		/// <summary>
		/// Int32 depth
		/// </summary>
		protected RProperty r_depth;
		public virtual RProperty Rdepth
		{
			get
			{
				if(r_depth == null)
				{
					r_depth = new(this, "depth", -1);
					r_depth.SetBelong(this.instance);
				}
				return r_depth;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTextureDescriptor descriptor
		/// </summary>
		protected RUnityEngine.RRenderTextureDescriptor r_descriptor;
		public virtual RUnityEngine.RRenderTextureDescriptor Rdescriptor
		{
			get
			{
				if(r_descriptor == null)
				{
					r_descriptor = new(this, "descriptor", -1);
					r_descriptor.SetBelong(this.instance);
				}
				return r_descriptor;
			}
		}

		/// <summary>
		/// Boolean generateMips
		/// </summary>
		protected RProperty r_generateMips;
		public virtual RProperty RgenerateMips
		{
			get
			{
				if(r_generateMips == null)
				{
					r_generateMips = new(this, "generateMips", -1);
					r_generateMips.SetBelong(this.instance);
				}
				return r_generateMips;
			}
		}

		/// <summary>
		/// Boolean isCubemap
		/// </summary>
		protected RProperty r_isCubemap;
		public virtual RProperty RisCubemap
		{
			get
			{
				if(r_isCubemap == null)
				{
					r_isCubemap = new(this, "isCubemap", -1);
					r_isCubemap.SetBelong(this.instance);
				}
				return r_isCubemap;
			}
		}

		/// <summary>
		/// Boolean isVolume
		/// </summary>
		protected RProperty r_isVolume;
		public virtual RProperty RisVolume
		{
			get
			{
				if(r_isVolume == null)
				{
					r_isVolume = new(this, "isVolume", -1);
					r_isVolume.SetBelong(this.instance);
				}
				return r_isVolume;
			}
		}

		/// <summary>
		/// Boolean enabled
		/// </summary>
		protected static RProperty r_enabled;
		public static RProperty Renabled
		{
			get
			{
				if(r_enabled == null)
				{
					r_enabled = new(typeof(UnityEngine.RenderTexture), "enabled", -1);
					r_enabled.SetBelong(null);
				}
				return r_enabled;
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
		/// UnityEngine.Experimental.Rendering.GraphicsFormat GetColorFormat(Boolean)
		/// </summary>
		protected RMethod r_GetColorFormat_Boolean;
		public virtual RMethod RGetColorFormat_Boolean
		{
			get
			{
				if(r_GetColorFormat_Boolean == null)
				{
					r_GetColorFormat_Boolean = new(this, "GetColorFormat", 0, typeof(System.Boolean));
					r_GetColorFormat_Boolean.SetBelong(this.instance);
				}
				return r_GetColorFormat_Boolean;
			}
		}

		/// <summary>
		/// Void SetColorFormat(UnityEngine.Experimental.Rendering.GraphicsFormat)
		/// </summary>
		protected RMethod r_SetColorFormat_GraphicsFormat;
		public virtual RMethod RSetColorFormat_GraphicsFormat
		{
			get
			{
				if(r_SetColorFormat_GraphicsFormat == null)
				{
					r_SetColorFormat_GraphicsFormat = new(this, "SetColorFormat", 0, typeof(UnityEngine.Experimental.Rendering.GraphicsFormat));
					r_SetColorFormat_GraphicsFormat.SetBelong(this.instance);
				}
				return r_SetColorFormat_GraphicsFormat;
			}
		}

		/// <summary>
		/// Boolean GetIsPowerOfTwo()
		/// </summary>
		protected RMethod r_GetIsPowerOfTwo;
		public virtual RMethod RGetIsPowerOfTwo
		{
			get
			{
				if(r_GetIsPowerOfTwo == null)
				{
					r_GetIsPowerOfTwo = new(this, "GetIsPowerOfTwo", 0);
					r_GetIsPowerOfTwo.SetBelong(this.instance);
				}
				return r_GetIsPowerOfTwo;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetActive()
		/// </summary>
		protected static RMethod r_GetActive;
		public static RMethod RGetActive
		{
			get
			{
				if(r_GetActive == null)
				{
					r_GetActive = new(typeof(UnityEngine.RenderTexture), "GetActive", 0);
					r_GetActive.SetBelong(null);
				}
				return r_GetActive;
			}
		}

		/// <summary>
		/// Void SetActive(UnityEngine.RenderTexture)
		/// </summary>
		protected static RMethod r_SetActive_RenderTexture;
		public static RMethod RSetActive_RenderTexture
		{
			get
			{
				if(r_SetActive_RenderTexture == null)
				{
					r_SetActive_RenderTexture = new(typeof(UnityEngine.RenderTexture), "SetActive", 0, typeof(UnityEngine.RenderTexture));
					r_SetActive_RenderTexture.SetBelong(null);
				}
				return r_SetActive_RenderTexture;
			}
		}

		/// <summary>
		/// UnityEngine.RenderBuffer GetColorBuffer()
		/// </summary>
		protected RMethod r_GetColorBuffer;
		public virtual RMethod RGetColorBuffer
		{
			get
			{
				if(r_GetColorBuffer == null)
				{
					r_GetColorBuffer = new(this, "GetColorBuffer", 0);
					r_GetColorBuffer.SetBelong(this.instance);
				}
				return r_GetColorBuffer;
			}
		}

		/// <summary>
		/// UnityEngine.RenderBuffer GetDepthBuffer()
		/// </summary>
		protected RMethod r_GetDepthBuffer;
		public virtual RMethod RGetDepthBuffer
		{
			get
			{
				if(r_GetDepthBuffer == null)
				{
					r_GetDepthBuffer = new(this, "GetDepthBuffer", 0);
					r_GetDepthBuffer.SetBelong(this.instance);
				}
				return r_GetDepthBuffer;
			}
		}

		/// <summary>
		/// Void SetMipMapCount(Int32)
		/// </summary>
		protected RMethod r_SetMipMapCount_Int32;
		public virtual RMethod RSetMipMapCount_Int32
		{
			get
			{
				if(r_SetMipMapCount_Int32 == null)
				{
					r_SetMipMapCount_Int32 = new(this, "SetMipMapCount", 0, typeof(System.Int32));
					r_SetMipMapCount_Int32.SetBelong(this.instance);
				}
				return r_SetMipMapCount_Int32;
			}
		}

		/// <summary>
		/// Void SetShadowSamplingMode(UnityEngine.Rendering.ShadowSamplingMode)
		/// </summary>
		protected RMethod r_SetShadowSamplingMode_ShadowSamplingMode;
		public virtual RMethod RSetShadowSamplingMode_ShadowSamplingMode
		{
			get
			{
				if(r_SetShadowSamplingMode_ShadowSamplingMode == null)
				{
					r_SetShadowSamplingMode_ShadowSamplingMode = new(this, "SetShadowSamplingMode", 0, typeof(UnityEngine.Rendering.ShadowSamplingMode));
					r_SetShadowSamplingMode_ShadowSamplingMode.SetBelong(this.instance);
				}
				return r_SetShadowSamplingMode_ShadowSamplingMode;
			}
		}

		/// <summary>
		/// IntPtr GetNativeDepthBufferPtr()
		/// </summary>
		protected RMethod r_GetNativeDepthBufferPtr;
		public virtual RMethod RGetNativeDepthBufferPtr
		{
			get
			{
				if(r_GetNativeDepthBufferPtr == null)
				{
					r_GetNativeDepthBufferPtr = new(this, "GetNativeDepthBufferPtr", 0);
					r_GetNativeDepthBufferPtr.SetBelong(this.instance);
				}
				return r_GetNativeDepthBufferPtr;
			}
		}

		/// <summary>
		/// Void DiscardContents(Boolean, Boolean)
		/// </summary>
		protected RMethod r_DiscardContents_Boolean_Boolean;
		public virtual RMethod RDiscardContents_Boolean_Boolean
		{
			get
			{
				if(r_DiscardContents_Boolean_Boolean == null)
				{
					r_DiscardContents_Boolean_Boolean = new(this, "DiscardContents", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_DiscardContents_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_DiscardContents_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void MarkRestoreExpected()
		/// </summary>
		protected RMethod r_MarkRestoreExpected;
		public virtual RMethod RMarkRestoreExpected
		{
			get
			{
				if(r_MarkRestoreExpected == null)
				{
					r_MarkRestoreExpected = new(this, "MarkRestoreExpected", 0);
					r_MarkRestoreExpected.SetBelong(this.instance);
				}
				return r_MarkRestoreExpected;
			}
		}

		/// <summary>
		/// Void DiscardContents()
		/// </summary>
		protected RMethod r_DiscardContents;
		public virtual RMethod RDiscardContents
		{
			get
			{
				if(r_DiscardContents == null)
				{
					r_DiscardContents = new(this, "DiscardContents", 0);
					r_DiscardContents.SetBelong(this.instance);
				}
				return r_DiscardContents;
			}
		}

		/// <summary>
		/// Void ResolveAA()
		/// </summary>
		protected RMethod r_ResolveAA;
		public virtual RMethod RResolveAA
		{
			get
			{
				if(r_ResolveAA == null)
				{
					r_ResolveAA = new(this, "ResolveAA", 0);
					r_ResolveAA.SetBelong(this.instance);
				}
				return r_ResolveAA;
			}
		}

		/// <summary>
		/// Void ResolveAATo(UnityEngine.RenderTexture)
		/// </summary>
		protected RMethod r_ResolveAATo_RenderTexture;
		public virtual RMethod RResolveAATo_RenderTexture
		{
			get
			{
				if(r_ResolveAATo_RenderTexture == null)
				{
					r_ResolveAATo_RenderTexture = new(this, "ResolveAATo", 0, typeof(UnityEngine.RenderTexture));
					r_ResolveAATo_RenderTexture.SetBelong(this.instance);
				}
				return r_ResolveAATo_RenderTexture;
			}
		}

		/// <summary>
		/// Void ResolveAntiAliasedSurface()
		/// </summary>
		protected RMethod r_ResolveAntiAliasedSurface;
		public virtual RMethod RResolveAntiAliasedSurface
		{
			get
			{
				if(r_ResolveAntiAliasedSurface == null)
				{
					r_ResolveAntiAliasedSurface = new(this, "ResolveAntiAliasedSurface", 0);
					r_ResolveAntiAliasedSurface.SetBelong(this.instance);
				}
				return r_ResolveAntiAliasedSurface;
			}
		}

		/// <summary>
		/// Void ResolveAntiAliasedSurface(UnityEngine.RenderTexture)
		/// </summary>
		protected RMethod r_ResolveAntiAliasedSurface_RenderTexture;
		public virtual RMethod RResolveAntiAliasedSurface_RenderTexture
		{
			get
			{
				if(r_ResolveAntiAliasedSurface_RenderTexture == null)
				{
					r_ResolveAntiAliasedSurface_RenderTexture = new(this, "ResolveAntiAliasedSurface", 0, typeof(UnityEngine.RenderTexture));
					r_ResolveAntiAliasedSurface_RenderTexture.SetBelong(this.instance);
				}
				return r_ResolveAntiAliasedSurface_RenderTexture;
			}
		}

		/// <summary>
		/// Void SetGlobalShaderProperty(System.String)
		/// </summary>
		protected RMethod r_SetGlobalShaderProperty_String;
		public virtual RMethod RSetGlobalShaderProperty_String
		{
			get
			{
				if(r_SetGlobalShaderProperty_String == null)
				{
					r_SetGlobalShaderProperty_String = new(this, "SetGlobalShaderProperty", 0, typeof(System.String));
					r_SetGlobalShaderProperty_String.SetBelong(this.instance);
				}
				return r_SetGlobalShaderProperty_String;
			}
		}

		/// <summary>
		/// Boolean Create()
		/// </summary>
		protected RMethod r_Create;
		public virtual RMethod RCreate
		{
			get
			{
				if(r_Create == null)
				{
					r_Create = new(this, "Create", 0);
					r_Create.SetBelong(this.instance);
				}
				return r_Create;
			}
		}

		/// <summary>
		/// Void Release()
		/// </summary>
		protected RMethod r_Release;
		public virtual RMethod RRelease
		{
			get
			{
				if(r_Release == null)
				{
					r_Release = new(this, "Release", 0);
					r_Release.SetBelong(this.instance);
				}
				return r_Release;
			}
		}

		/// <summary>
		/// Boolean IsCreated()
		/// </summary>
		protected RMethod r_IsCreated;
		public virtual RMethod RIsCreated
		{
			get
			{
				if(r_IsCreated == null)
				{
					r_IsCreated = new(this, "IsCreated", 0);
					r_IsCreated.SetBelong(this.instance);
				}
				return r_IsCreated;
			}
		}

		/// <summary>
		/// Void GenerateMips()
		/// </summary>
		protected RMethod r_GenerateMips;
		public virtual RMethod RGenerateMips
		{
			get
			{
				if(r_GenerateMips == null)
				{
					r_GenerateMips = new(this, "GenerateMips", 0);
					r_GenerateMips.SetBelong(this.instance);
				}
				return r_GenerateMips;
			}
		}

		/// <summary>
		/// Void ConvertToEquirect(UnityEngine.RenderTexture, MonoOrStereoscopicEye)
		/// </summary>
		protected RMethod r_ConvertToEquirect_RenderTexture_MonoOrStereoscopicEye;
		public virtual RMethod RConvertToEquirect_RenderTexture_MonoOrStereoscopicEye
		{
			get
			{
				if(r_ConvertToEquirect_RenderTexture_MonoOrStereoscopicEye == null)
				{
					r_ConvertToEquirect_RenderTexture_MonoOrStereoscopicEye = new(this, "ConvertToEquirect", 0, typeof(UnityEngine.RenderTexture),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"));
					r_ConvertToEquirect_RenderTexture_MonoOrStereoscopicEye.SetBelong(this.instance);
				}
				return r_ConvertToEquirect_RenderTexture_MonoOrStereoscopicEye;
			}
		}

		/// <summary>
		/// Void SetSRGBReadWrite(Boolean)
		/// </summary>
		protected RMethod r_SetSRGBReadWrite_Boolean;
		public virtual RMethod RSetSRGBReadWrite_Boolean
		{
			get
			{
				if(r_SetSRGBReadWrite_Boolean == null)
				{
					r_SetSRGBReadWrite_Boolean = new(this, "SetSRGBReadWrite", 0, typeof(System.Boolean));
					r_SetSRGBReadWrite_Boolean.SetBelong(this.instance);
				}
				return r_SetSRGBReadWrite_Boolean;
			}
		}

		/// <summary>
		/// Void Internal_Create(UnityEngine.RenderTexture)
		/// </summary>
		protected static RMethod r_Internal_Create_RenderTexture;
		public static RMethod RInternal_Create_RenderTexture
		{
			get
			{
				if(r_Internal_Create_RenderTexture == null)
				{
					r_Internal_Create_RenderTexture = new(typeof(UnityEngine.RenderTexture), "Internal_Create", 0, typeof(UnityEngine.RenderTexture));
					r_Internal_Create_RenderTexture.SetBelong(null);
				}
				return r_Internal_Create_RenderTexture;
			}
		}

		/// <summary>
		/// Boolean SupportsStencil(UnityEngine.RenderTexture)
		/// </summary>
		protected static RMethod r_SupportsStencil_RenderTexture;
		public static RMethod RSupportsStencil_RenderTexture
		{
			get
			{
				if(r_SupportsStencil_RenderTexture == null)
				{
					r_SupportsStencil_RenderTexture = new(typeof(UnityEngine.RenderTexture), "SupportsStencil", 0, typeof(UnityEngine.RenderTexture));
					r_SupportsStencil_RenderTexture.SetBelong(null);
				}
				return r_SupportsStencil_RenderTexture;
			}
		}

		/// <summary>
		/// Void SetRenderTextureDescriptor(UnityEngine.RenderTextureDescriptor)
		/// </summary>
		protected RMethod r_SetRenderTextureDescriptor_RenderTextureDescriptor;
		public virtual RMethod RSetRenderTextureDescriptor_RenderTextureDescriptor
		{
			get
			{
				if(r_SetRenderTextureDescriptor_RenderTextureDescriptor == null)
				{
					r_SetRenderTextureDescriptor_RenderTextureDescriptor = new(this, "SetRenderTextureDescriptor", 0, typeof(UnityEngine.RenderTextureDescriptor));
					r_SetRenderTextureDescriptor_RenderTextureDescriptor.SetBelong(this.instance);
				}
				return r_SetRenderTextureDescriptor_RenderTextureDescriptor;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTextureDescriptor GetDescriptor()
		/// </summary>
		protected RMethod r_GetDescriptor;
		public virtual RMethod RGetDescriptor
		{
			get
			{
				if(r_GetDescriptor == null)
				{
					r_GetDescriptor = new(this, "GetDescriptor", 0);
					r_GetDescriptor.SetBelong(this.instance);
				}
				return r_GetDescriptor;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary_Internal(UnityEngine.RenderTextureDescriptor)
		/// </summary>
		protected static RMethod r_GetTemporary_Internal_RenderTextureDescriptor;
		public static RMethod RGetTemporary_Internal_RenderTextureDescriptor
		{
			get
			{
				if(r_GetTemporary_Internal_RenderTextureDescriptor == null)
				{
					r_GetTemporary_Internal_RenderTextureDescriptor = new(typeof(UnityEngine.RenderTexture), "GetTemporary_Internal", 0, typeof(UnityEngine.RenderTextureDescriptor));
					r_GetTemporary_Internal_RenderTextureDescriptor.SetBelong(null);
				}
				return r_GetTemporary_Internal_RenderTextureDescriptor;
			}
		}

		/// <summary>
		/// Void ReleaseTemporary(UnityEngine.RenderTexture)
		/// </summary>
		protected static RMethod r_ReleaseTemporary_RenderTexture;
		public static RMethod RReleaseTemporary_RenderTexture
		{
			get
			{
				if(r_ReleaseTemporary_RenderTexture == null)
				{
					r_ReleaseTemporary_RenderTexture = new(typeof(UnityEngine.RenderTexture), "ReleaseTemporary", 0, typeof(UnityEngine.RenderTexture));
					r_ReleaseTemporary_RenderTexture.SetBelong(null);
				}
				return r_ReleaseTemporary_RenderTexture;
			}
		}

		/// <summary>
		/// Void Initialize(Int32, Int32, Int32, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, Int32)
		/// </summary>
		protected RMethod r_Initialize_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32;
		public virtual RMethod RInitialize_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32
		{
			get
			{
				if(r_Initialize_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32 == null)
				{
					r_Initialize_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32 = new(this, "Initialize", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32));
					r_Initialize_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32.SetBelong(this.instance);
				}
				return r_Initialize_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(Int32, UnityEngine.Experimental.Rendering.GraphicsFormat)
		/// </summary>
		protected static RMethod r_GetDepthStencilFormatLegacy_Int32_GraphicsFormat;
		public static RMethod RGetDepthStencilFormatLegacy_Int32_GraphicsFormat
		{
			get
			{
				if(r_GetDepthStencilFormatLegacy_Int32_GraphicsFormat == null)
				{
					r_GetDepthStencilFormatLegacy_Int32_GraphicsFormat = new(typeof(UnityEngine.RenderTexture), "GetDepthStencilFormatLegacy", 0, typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat));
					r_GetDepthStencilFormatLegacy_Int32_GraphicsFormat.SetBelong(null);
				}
				return r_GetDepthStencilFormatLegacy_Int32_GraphicsFormat;
			}
		}

		/// <summary>
		/// Void ValidateRenderTextureDesc(UnityEngine.RenderTextureDescriptor)
		/// </summary>
		protected static RMethod r_ValidateRenderTextureDesc_RenderTextureDescriptor;
		public static RMethod RValidateRenderTextureDesc_RenderTextureDescriptor
		{
			get
			{
				if(r_ValidateRenderTextureDesc_RenderTextureDescriptor == null)
				{
					r_ValidateRenderTextureDesc_RenderTextureDescriptor = new(typeof(UnityEngine.RenderTexture), "ValidateRenderTextureDesc", 0, typeof(UnityEngine.RenderTextureDescriptor));
					r_ValidateRenderTextureDesc_RenderTextureDescriptor.SetBelong(null);
				}
				return r_ValidateRenderTextureDesc_RenderTextureDescriptor;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite)
		/// </summary>
		protected static RMethod r_GetCompatibleFormat_RenderTextureFormat_RenderTextureReadWrite;
		public static RMethod RGetCompatibleFormat_RenderTextureFormat_RenderTextureReadWrite
		{
			get
			{
				if(r_GetCompatibleFormat_RenderTextureFormat_RenderTextureReadWrite == null)
				{
					r_GetCompatibleFormat_RenderTextureFormat_RenderTextureReadWrite = new(typeof(UnityEngine.RenderTexture), "GetCompatibleFormat", 0, typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite));
					r_GetCompatibleFormat_RenderTextureFormat_RenderTextureReadWrite.SetBelong(null);
				}
				return r_GetCompatibleFormat_RenderTextureFormat_RenderTextureReadWrite;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(UnityEngine.RenderTextureDescriptor)
		/// </summary>
		protected static RMethod r_GetTemporary_RenderTextureDescriptor;
		public static RMethod RGetTemporary_RenderTextureDescriptor
		{
			get
			{
				if(r_GetTemporary_RenderTextureDescriptor == null)
				{
					r_GetTemporary_RenderTextureDescriptor = new(typeof(UnityEngine.RenderTexture), "GetTemporary", 0, typeof(UnityEngine.RenderTextureDescriptor));
					r_GetTemporary_RenderTextureDescriptor.SetBelong(null);
				}
				return r_GetTemporary_RenderTextureDescriptor;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporaryImpl(Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32, UnityEngine.RenderTextureMemoryless, UnityEngine.VRTextureUsage, Boolean)
		/// </summary>
		protected static RMethod r_GetTemporaryImpl_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean;
		public static RMethod RGetTemporaryImpl_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean
		{
			get
			{
				if(r_GetTemporaryImpl_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean == null)
				{
					r_GetTemporaryImpl_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean = new(typeof(UnityEngine.RenderTexture), "GetTemporaryImpl", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32), typeof(UnityEngine.RenderTextureMemoryless), typeof(UnityEngine.VRTextureUsage), typeof(System.Boolean));
					r_GetTemporaryImpl_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean.SetBelong(null);
				}
				return r_GetTemporaryImpl_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32, UnityEngine.RenderTextureMemoryless, UnityEngine.VRTextureUsage, Boolean)
		/// </summary>
		protected static RMethod r_GetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean;
		public static RMethod RGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean
		{
			get
			{
				if(r_GetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean == null)
				{
					r_GetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean = new(typeof(UnityEngine.RenderTexture), "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32), typeof(UnityEngine.RenderTextureMemoryless), typeof(UnityEngine.VRTextureUsage), typeof(System.Boolean));
					r_GetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean.SetBelong(null);
				}
				return r_GetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32, UnityEngine.RenderTextureMemoryless, UnityEngine.VRTextureUsage)
		/// </summary>
		protected static RMethod r_GetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage;
		public static RMethod RGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage
		{
			get
			{
				if(r_GetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage == null)
				{
					r_GetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage = new(typeof(UnityEngine.RenderTexture), "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32), typeof(UnityEngine.RenderTextureMemoryless), typeof(UnityEngine.VRTextureUsage));
					r_GetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage.SetBelong(null);
				}
				return r_GetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32, UnityEngine.RenderTextureMemoryless)
		/// </summary>
		protected static RMethod r_GetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless;
		public static RMethod RGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless
		{
			get
			{
				if(r_GetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless == null)
				{
					r_GetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless = new(typeof(UnityEngine.RenderTexture), "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32), typeof(UnityEngine.RenderTextureMemoryless));
					r_GetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless.SetBelong(null);
				}
				return r_GetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32)
		/// </summary>
		protected static RMethod r_GetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32;
		public static RMethod RGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32
		{
			get
			{
				if(r_GetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32 == null)
				{
					r_GetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32 = new(typeof(UnityEngine.RenderTexture), "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32));
					r_GetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32.SetBelong(null);
				}
				return r_GetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat)
		/// </summary>
		protected static RMethod r_GetTemporary_Int32_Int32_Int32_GraphicsFormat;
		public static RMethod RGetTemporary_Int32_Int32_Int32_GraphicsFormat
		{
			get
			{
				if(r_GetTemporary_Int32_Int32_Int32_GraphicsFormat == null)
				{
					r_GetTemporary_Int32_Int32_Int32_GraphicsFormat = new(typeof(UnityEngine.RenderTexture), "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat));
					r_GetTemporary_Int32_Int32_Int32_GraphicsFormat.SetBelong(null);
				}
				return r_GetTemporary_Int32_Int32_Int32_GraphicsFormat;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, Int32, UnityEngine.RenderTextureMemoryless, UnityEngine.VRTextureUsage, Boolean)
		/// </summary>
		protected static RMethod r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean;
		public static RMethod RGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean
		{
			get
			{
				if(r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean == null)
				{
					r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean = new(typeof(UnityEngine.RenderTexture), "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32), typeof(UnityEngine.RenderTextureMemoryless), typeof(UnityEngine.VRTextureUsage), typeof(System.Boolean));
					r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean.SetBelong(null);
				}
				return r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, Int32, UnityEngine.RenderTextureMemoryless, UnityEngine.VRTextureUsage)
		/// </summary>
		protected static RMethod r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage;
		public static RMethod RGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage
		{
			get
			{
				if(r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage == null)
				{
					r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage = new(typeof(UnityEngine.RenderTexture), "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32), typeof(UnityEngine.RenderTextureMemoryless), typeof(UnityEngine.VRTextureUsage));
					r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage.SetBelong(null);
				}
				return r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, Int32, UnityEngine.RenderTextureMemoryless)
		/// </summary>
		protected static RMethod r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless;
		public static RMethod RGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless
		{
			get
			{
				if(r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless == null)
				{
					r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless = new(typeof(UnityEngine.RenderTexture), "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32), typeof(UnityEngine.RenderTextureMemoryless));
					r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless.SetBelong(null);
				}
				return r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, Int32)
		/// </summary>
		protected static RMethod r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32;
		public static RMethod RGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32
		{
			get
			{
				if(r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32 == null)
				{
					r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32 = new(typeof(UnityEngine.RenderTexture), "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32));
					r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32.SetBelong(null);
				}
				return r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite)
		/// </summary>
		protected static RMethod r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite;
		public static RMethod RGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite
		{
			get
			{
				if(r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite == null)
				{
					r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite = new(typeof(UnityEngine.RenderTexture), "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite));
					r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite.SetBelong(null);
				}
				return r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32, UnityEngine.RenderTextureFormat)
		/// </summary>
		protected static RMethod r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat;
		public static RMethod RGetTemporary_Int32_Int32_Int32_RenderTextureFormat
		{
			get
			{
				if(r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat == null)
				{
					r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat = new(typeof(UnityEngine.RenderTexture), "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.RenderTextureFormat));
					r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat.SetBelong(null);
				}
				return r_GetTemporary_Int32_Int32_Int32_RenderTextureFormat;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_GetTemporary_Int32_Int32_Int32;
		public static RMethod RGetTemporary_Int32_Int32_Int32
		{
			get
			{
				if(r_GetTemporary_Int32_Int32_Int32 == null)
				{
					r_GetTemporary_Int32_Int32_Int32 = new(typeof(UnityEngine.RenderTexture), "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_GetTemporary_Int32_Int32_Int32.SetBelong(null);
				}
				return r_GetTemporary_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32)
		/// </summary>
		protected static RMethod r_GetTemporary_Int32_Int32;
		public static RMethod RGetTemporary_Int32_Int32
		{
			get
			{
				if(r_GetTemporary_Int32_Int32 == null)
				{
					r_GetTemporary_Int32_Int32 = new(typeof(UnityEngine.RenderTexture), "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32));
					r_GetTemporary_Int32_Int32.SetBelong(null);
				}
				return r_GetTemporary_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetBorderColor(UnityEngine.Color)
		/// </summary>
		protected RMethod r_SetBorderColor_Color;
		public virtual RMethod RSetBorderColor_Color
		{
			get
			{
				if(r_SetBorderColor_Color == null)
				{
					r_SetBorderColor_Color = new(this, "SetBorderColor", 0, typeof(UnityEngine.Color));
					r_SetBorderColor_Color.SetBelong(this.instance);
				}
				return r_SetBorderColor_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetTexelOffset()
		/// </summary>
		protected RMethod r_GetTexelOffset;
		public virtual RMethod RGetTexelOffset
		{
			get
			{
				if(r_GetTexelOffset == null)
				{
					r_GetTexelOffset = new(this, "GetTexelOffset", 0);
					r_GetTexelOffset.SetBelong(this.instance);
				}
				return r_GetTexelOffset;
			}
		}

		/// <summary>
		/// Void GetColorBuffer_Injected(UnityEngine.RenderBuffer ByRef)
		/// </summary>
		protected RMethod r_GetColorBuffer_Injected_Out_RenderBuffer;
		public virtual RMethod RGetColorBuffer_Injected_Out_RenderBuffer
		{
			get
			{
				if(r_GetColorBuffer_Injected_Out_RenderBuffer == null)
				{
					r_GetColorBuffer_Injected_Out_RenderBuffer = new(this, "GetColorBuffer_Injected", 0, typeof(UnityEngine.RenderBuffer).MakeByRefType());
					r_GetColorBuffer_Injected_Out_RenderBuffer.SetBelong(this.instance);
				}
				return r_GetColorBuffer_Injected_Out_RenderBuffer;
			}
		}

		/// <summary>
		/// Void GetDepthBuffer_Injected(UnityEngine.RenderBuffer ByRef)
		/// </summary>
		protected RMethod r_GetDepthBuffer_Injected_Out_RenderBuffer;
		public virtual RMethod RGetDepthBuffer_Injected_Out_RenderBuffer
		{
			get
			{
				if(r_GetDepthBuffer_Injected_Out_RenderBuffer == null)
				{
					r_GetDepthBuffer_Injected_Out_RenderBuffer = new(this, "GetDepthBuffer_Injected", 0, typeof(UnityEngine.RenderBuffer).MakeByRefType());
					r_GetDepthBuffer_Injected_Out_RenderBuffer.SetBelong(this.instance);
				}
				return r_GetDepthBuffer_Injected_Out_RenderBuffer;
			}
		}

		/// <summary>
		/// Void SetRenderTextureDescriptor_Injected(UnityEngine.RenderTextureDescriptor ByRef)
		/// </summary>
		protected RMethod r_SetRenderTextureDescriptor_Injected_Ref_RenderTextureDescriptor;
		public virtual RMethod RSetRenderTextureDescriptor_Injected_Ref_RenderTextureDescriptor
		{
			get
			{
				if(r_SetRenderTextureDescriptor_Injected_Ref_RenderTextureDescriptor == null)
				{
					r_SetRenderTextureDescriptor_Injected_Ref_RenderTextureDescriptor = new(this, "SetRenderTextureDescriptor_Injected", 0, typeof(UnityEngine.RenderTextureDescriptor).MakeByRefType());
					r_SetRenderTextureDescriptor_Injected_Ref_RenderTextureDescriptor.SetBelong(this.instance);
				}
				return r_SetRenderTextureDescriptor_Injected_Ref_RenderTextureDescriptor;
			}
		}

		/// <summary>
		/// Void GetDescriptor_Injected(UnityEngine.RenderTextureDescriptor ByRef)
		/// </summary>
		protected RMethod r_GetDescriptor_Injected_Out_RenderTextureDescriptor;
		public virtual RMethod RGetDescriptor_Injected_Out_RenderTextureDescriptor
		{
			get
			{
				if(r_GetDescriptor_Injected_Out_RenderTextureDescriptor == null)
				{
					r_GetDescriptor_Injected_Out_RenderTextureDescriptor = new(this, "GetDescriptor_Injected", 0, typeof(UnityEngine.RenderTextureDescriptor).MakeByRefType());
					r_GetDescriptor_Injected_Out_RenderTextureDescriptor.SetBelong(this.instance);
				}
				return r_GetDescriptor_Injected_Out_RenderTextureDescriptor;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary_Internal_Injected(UnityEngine.RenderTextureDescriptor ByRef)
		/// </summary>
		protected static RMethod r_GetTemporary_Internal_Injected_Ref_RenderTextureDescriptor;
		public static RMethod RGetTemporary_Internal_Injected_Ref_RenderTextureDescriptor
		{
			get
			{
				if(r_GetTemporary_Internal_Injected_Ref_RenderTextureDescriptor == null)
				{
					r_GetTemporary_Internal_Injected_Ref_RenderTextureDescriptor = new(typeof(UnityEngine.RenderTexture), "GetTemporary_Internal_Injected", 0, typeof(UnityEngine.RenderTextureDescriptor).MakeByRefType());
					r_GetTemporary_Internal_Injected_Ref_RenderTextureDescriptor.SetBelong(null);
				}
				return r_GetTemporary_Internal_Injected_Ref_RenderTextureDescriptor;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat()
		/// </summary>
		protected RMethod r_get_graphicsFormat;
		public virtual RMethod Rget_graphicsFormat
		{
			get
			{
				if(r_get_graphicsFormat == null)
				{
					r_get_graphicsFormat = new(this, "get_graphicsFormat", 0);
					r_get_graphicsFormat.SetBelong(this.instance);
				}
				return r_get_graphicsFormat;
			}
		}

		/// <summary>
		/// IntPtr GetNativeTexturePtr()
		/// </summary>
		protected RMethod r_GetNativeTexturePtr;
		public virtual RMethod RGetNativeTexturePtr
		{
			get
			{
				if(r_GetNativeTexturePtr == null)
				{
					r_GetNativeTexturePtr = new(this, "GetNativeTexturePtr", 0);
					r_GetNativeTexturePtr.SetBelong(this.instance);
				}
				return r_GetNativeTexturePtr;
			}
		}

		/// <summary>
		/// Int32 GetNativeTextureID()
		/// </summary>
		protected RMethod r_GetNativeTextureID;
		public virtual RMethod RGetNativeTextureID
		{
			get
			{
				if(r_GetNativeTextureID == null)
				{
					r_GetNativeTextureID = new(this, "GetNativeTextureID", 0);
					r_GetNativeTextureID.SetBelong(this.instance);
				}
				return r_GetNativeTextureID;
			}
		}

		/// <summary>
		/// Void IncrementUpdateCount()
		/// </summary>
		protected RMethod r_IncrementUpdateCount;
		public virtual RMethod RIncrementUpdateCount
		{
			get
			{
				if(r_IncrementUpdateCount == null)
				{
					r_IncrementUpdateCount = new(this, "IncrementUpdateCount", 0);
					r_IncrementUpdateCount.SetBelong(this.instance);
				}
				return r_IncrementUpdateCount;
			}
		}

		/// <summary>
		/// UInt64 GetPixelDataSize(Int32, Int32)
		/// </summary>
		protected RMethod r_GetPixelDataSize_Int32_Int32;
		public virtual RMethod RGetPixelDataSize_Int32_Int32
		{
			get
			{
				if(r_GetPixelDataSize_Int32_Int32 == null)
				{
					r_GetPixelDataSize_Int32_Int32 = new(this, "GetPixelDataSize", 0, typeof(System.Int32), typeof(System.Int32));
					r_GetPixelDataSize_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetPixelDataSize_Int32_Int32;
			}
		}

		/// <summary>
		/// UInt64 GetPixelDataOffset(Int32, Int32)
		/// </summary>
		protected RMethod r_GetPixelDataOffset_Int32_Int32;
		public virtual RMethod RGetPixelDataOffset_Int32_Int32
		{
			get
			{
				if(r_GetPixelDataOffset_Int32_Int32 == null)
				{
					r_GetPixelDataOffset_Int32_Int32 = new(this, "GetPixelDataOffset", 0, typeof(System.Int32), typeof(System.Int32));
					r_GetPixelDataOffset_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetPixelDataOffset_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean ValidateFormat(UnityEngine.RenderTextureFormat)
		/// </summary>
		protected RMethod r_ValidateFormat_RenderTextureFormat;
		public virtual RMethod RValidateFormat_RenderTextureFormat
		{
			get
			{
				if(r_ValidateFormat_RenderTextureFormat == null)
				{
					r_ValidateFormat_RenderTextureFormat = new(this, "ValidateFormat", 0, typeof(UnityEngine.RenderTextureFormat));
					r_ValidateFormat_RenderTextureFormat.SetBelong(this.instance);
				}
				return r_ValidateFormat_RenderTextureFormat;
			}
		}

		/// <summary>
		/// Boolean ValidateFormat(UnityEngine.TextureFormat)
		/// </summary>
		protected RMethod r_ValidateFormat_TextureFormat;
		public virtual RMethod RValidateFormat_TextureFormat
		{
			get
			{
				if(r_ValidateFormat_TextureFormat == null)
				{
					r_ValidateFormat_TextureFormat = new(this, "ValidateFormat", 0, typeof(UnityEngine.TextureFormat));
					r_ValidateFormat_TextureFormat.SetBelong(this.instance);
				}
				return r_ValidateFormat_TextureFormat;
			}
		}

		/// <summary>
		/// Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat, UnityEngine.Experimental.Rendering.FormatUsage)
		/// </summary>
		protected RMethod r_ValidateFormat_GraphicsFormat_FormatUsage;
		public virtual RMethod RValidateFormat_GraphicsFormat_FormatUsage
		{
			get
			{
				if(r_ValidateFormat_GraphicsFormat_FormatUsage == null)
				{
					r_ValidateFormat_GraphicsFormat_FormatUsage = new(this, "ValidateFormat", 0, typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(UnityEngine.Experimental.Rendering.FormatUsage));
					r_ValidateFormat_GraphicsFormat_FormatUsage.SetBelong(this.instance);
				}
				return r_ValidateFormat_GraphicsFormat_FormatUsage;
			}
		}

		/// <summary>
		/// UnityEngine.UnityException CreateNonReadableException(UnityEngine.Texture)
		/// </summary>
		protected RMethod r_CreateNonReadableException_Texture;
		public virtual RMethod RCreateNonReadableException_Texture
		{
			get
			{
				if(r_CreateNonReadableException_Texture == null)
				{
					r_CreateNonReadableException_Texture = new(this, "CreateNonReadableException", 0, typeof(UnityEngine.Texture));
					r_CreateNonReadableException_Texture.SetBelong(this.instance);
				}
				return r_CreateNonReadableException_Texture;
			}
		}

		/// <summary>
		/// UnityEngine.UnityException CreateNativeArrayLengthOverflowException()
		/// </summary>
		protected RMethod r_CreateNativeArrayLengthOverflowException;
		public virtual RMethod RCreateNativeArrayLengthOverflowException
		{
			get
			{
				if(r_CreateNativeArrayLengthOverflowException == null)
				{
					r_CreateNativeArrayLengthOverflowException = new(this, "CreateNativeArrayLengthOverflowException", 0);
					r_CreateNativeArrayLengthOverflowException.SetBelong(this.instance);
				}
				return r_CreateNativeArrayLengthOverflowException;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_GetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_GetInstanceID == null)
				{
					r_GetInstanceID = new(this, "GetInstanceID", 0);
					r_GetInstanceID.SetBelong(this.instance);
				}
				return r_GetInstanceID;
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


        public RRenderTexture() : base("UnityEngine.RenderTexture")
        {
        }

        public RRenderTexture(System.Object instance) : base("UnityEngine.RenderTexture")
		{
            SetInstance(instance);
		}

        public RRenderTexture(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRenderTexture(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual UnityEngine.Experimental.Rendering.GraphicsFormat GetColorFormat(System.Boolean  @suppressWarnings)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@suppressWarnings};
            var ___result = RGetColorFormat_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Experimental.Rendering.GraphicsFormat)___result;
        }


        public virtual void SetColorFormat(UnityEngine.Experimental.Rendering.GraphicsFormat  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RSetColorFormat_GraphicsFormat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetIsPowerOfTwo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetIsPowerOfTwo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.RenderTexture GetActive()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetActive.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RenderTexture)___result;
        }


        public static void SetActive(UnityEngine.RenderTexture  @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt};
            var ___result = RSetActive_RenderTexture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.RenderBuffer GetColorBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetColorBuffer.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RenderBuffer)___result;
        }


        public virtual UnityEngine.RenderBuffer GetDepthBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDepthBuffer.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RenderBuffer)___result;
        }


        public virtual void SetMipMapCount(System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@count};
            var ___result = RSetMipMapCount_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetShadowSamplingMode(UnityEngine.Rendering.ShadowSamplingMode  @samplingMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@samplingMode};
            var ___result = RSetShadowSamplingMode_ShadowSamplingMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IntPtr GetNativeDepthBufferPtr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNativeDepthBufferPtr.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual void DiscardContents(System.Boolean  @discardColor, System.Boolean  @discardDepth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@discardColor, @discardDepth};
            var ___result = RDiscardContents_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkRestoreExpected()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMarkRestoreExpected.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DiscardContents()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDiscardContents.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResolveAA()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResolveAA.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResolveAATo(UnityEngine.RenderTexture  @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt};
            var ___result = RResolveAATo_RenderTexture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResolveAntiAliasedSurface()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResolveAntiAliasedSurface.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResolveAntiAliasedSurface(UnityEngine.RenderTexture  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RResolveAntiAliasedSurface_RenderTexture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalShaderProperty(System.String  @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName};
            var ___result = RSetGlobalShaderProperty_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Create()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRelease.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsCreated()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsCreated.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void GenerateMips()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGenerateMips.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ConvertToEquirect(UnityEngine.RenderTexture  @equirect, RType  @eye)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@equirect, @eye.Value};
            var ___result = RConvertToEquirect_RenderTexture_MonoOrStereoscopicEye.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSRGBReadWrite(System.Boolean  @srgb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@srgb};
            var ___result = RSetSRGBReadWrite_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_Create(UnityEngine.RenderTexture  @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt};
            var ___result = RInternal_Create_RenderTexture.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean SupportsStencil(UnityEngine.RenderTexture  @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt};
            var ___result = RSupportsStencil_RenderTexture.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetRenderTextureDescriptor(UnityEngine.RenderTextureDescriptor  @desc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc};
            var ___result = RSetRenderTextureDescriptor_RenderTextureDescriptor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.RenderTextureDescriptor GetDescriptor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDescriptor.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RenderTextureDescriptor)___result;
        }


        public static UnityEngine.RenderTexture GetTemporary_Internal(UnityEngine.RenderTextureDescriptor  @desc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc};
            var ___result = RGetTemporary_Internal_RenderTextureDescriptor.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RenderTexture)___result;
        }


        public static void ReleaseTemporary(UnityEngine.RenderTexture  @temp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@temp};
            var ___result = RReleaseTemporary_RenderTexture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initialize(System.Int32  @width, System.Int32  @height, System.Int32  @depth, UnityEngine.RenderTextureFormat  @format, UnityEngine.RenderTextureReadWrite  @readWrite, System.Int32  @mipCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depth, @format, @readWrite, @mipCount};
            var ___result = RInitialize_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(System.Int32  @depthBits, UnityEngine.Experimental.Rendering.GraphicsFormat  @colorFormat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@depthBits, @colorFormat};
            var ___result = RGetDepthStencilFormatLegacy_Int32_GraphicsFormat.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Experimental.Rendering.GraphicsFormat)___result;
        }


        public static void ValidateRenderTextureDesc(UnityEngine.RenderTextureDescriptor  @desc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc};
            var ___result = RValidateRenderTextureDesc_RenderTextureDescriptor.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.RenderTextureFormat  @renderTextureFormat, UnityEngine.RenderTextureReadWrite  @readWrite)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderTextureFormat, @readWrite};
            var ___result = RGetCompatibleFormat_RenderTextureFormat_RenderTextureReadWrite.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Experimental.Rendering.GraphicsFormat)___result;
        }


        public static UnityEngine.RenderTexture GetTemporary(UnityEngine.RenderTextureDescriptor  @desc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc};
            var ___result = RGetTemporary_RenderTextureDescriptor.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RenderTexture)___result;
        }


        public static UnityEngine.RenderTexture GetTemporaryImpl(System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat  @colorFormat, System.Int32  @antiAliasing, UnityEngine.RenderTextureMemoryless  @memorylessMode, UnityEngine.VRTextureUsage  @vrUsage, System.Boolean  @useDynamicScale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @colorFormat, @antiAliasing, @memorylessMode, @vrUsage, @useDynamicScale};
            var ___result = RGetTemporaryImpl_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RenderTexture)___result;
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat  @format, System.Int32  @antiAliasing, UnityEngine.RenderTextureMemoryless  @memorylessMode, UnityEngine.VRTextureUsage  @vrUsage, System.Boolean  @useDynamicScale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @format, @antiAliasing, @memorylessMode, @vrUsage, @useDynamicScale};
            var ___result = RGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RenderTexture)___result;
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat  @format, System.Int32  @antiAliasing, UnityEngine.RenderTextureMemoryless  @memorylessMode, UnityEngine.VRTextureUsage  @vrUsage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @format, @antiAliasing, @memorylessMode, @vrUsage};
            var ___result = RGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RenderTexture)___result;
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat  @format, System.Int32  @antiAliasing, UnityEngine.RenderTextureMemoryless  @memorylessMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @format, @antiAliasing, @memorylessMode};
            var ___result = RGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RenderTexture)___result;
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat  @format, System.Int32  @antiAliasing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @format, @antiAliasing};
            var ___result = RGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RenderTexture)___result;
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @format};
            var ___result = RGetTemporary_Int32_Int32_Int32_GraphicsFormat.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RenderTexture)___result;
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.RenderTextureFormat  @format, UnityEngine.RenderTextureReadWrite  @readWrite, System.Int32  @antiAliasing, UnityEngine.RenderTextureMemoryless  @memorylessMode, UnityEngine.VRTextureUsage  @vrUsage, System.Boolean  @useDynamicScale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @format, @readWrite, @antiAliasing, @memorylessMode, @vrUsage, @useDynamicScale};
            var ___result = RGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RenderTexture)___result;
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.RenderTextureFormat  @format, UnityEngine.RenderTextureReadWrite  @readWrite, System.Int32  @antiAliasing, UnityEngine.RenderTextureMemoryless  @memorylessMode, UnityEngine.VRTextureUsage  @vrUsage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @format, @readWrite, @antiAliasing, @memorylessMode, @vrUsage};
            var ___result = RGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RenderTexture)___result;
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.RenderTextureFormat  @format, UnityEngine.RenderTextureReadWrite  @readWrite, System.Int32  @antiAliasing, UnityEngine.RenderTextureMemoryless  @memorylessMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @format, @readWrite, @antiAliasing, @memorylessMode};
            var ___result = RGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RenderTexture)___result;
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.RenderTextureFormat  @format, UnityEngine.RenderTextureReadWrite  @readWrite, System.Int32  @antiAliasing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @format, @readWrite, @antiAliasing};
            var ___result = RGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RenderTexture)___result;
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.RenderTextureFormat  @format, UnityEngine.RenderTextureReadWrite  @readWrite)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @format, @readWrite};
            var ___result = RGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RenderTexture)___result;
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer, UnityEngine.RenderTextureFormat  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @format};
            var ___result = RGetTemporary_Int32_Int32_Int32_RenderTextureFormat.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RenderTexture)___result;
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32  @width, System.Int32  @height, System.Int32  @depthBuffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer};
            var ___result = RGetTemporary_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RenderTexture)___result;
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32  @width, System.Int32  @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height};
            var ___result = RGetTemporary_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RenderTexture)___result;
        }


        public virtual void SetBorderColor(UnityEngine.Color  @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color};
            var ___result = RSetBorderColor_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 GetTexelOffset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTexelOffset.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void GetColorBuffer_Injected(out UnityEngine.RenderBuffer  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetColorBuffer_Injected_Out_RenderBuffer.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.RenderBuffer)___parameters[0];

            
        }


        public virtual void GetDepthBuffer_Injected(out UnityEngine.RenderBuffer  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetDepthBuffer_Injected_Out_RenderBuffer.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.RenderBuffer)___parameters[0];

            
        }


        public virtual void SetRenderTextureDescriptor_Injected(ref UnityEngine.RenderTextureDescriptor  @desc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc};
            var ___result = RSetRenderTextureDescriptor_Injected_Ref_RenderTextureDescriptor.Invoke(___genericsType, ___parameters);
			desc = (UnityEngine.RenderTextureDescriptor)___parameters[0];

            
        }


        public virtual void GetDescriptor_Injected(out UnityEngine.RenderTextureDescriptor  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetDescriptor_Injected_Out_RenderTextureDescriptor.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.RenderTextureDescriptor)___parameters[0];

            
        }


        public static UnityEngine.RenderTexture GetTemporary_Internal_Injected(ref UnityEngine.RenderTextureDescriptor  @desc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc};
            var ___result = RGetTemporary_Internal_Injected_Ref_RenderTextureDescriptor.Invoke(___genericsType, ___parameters);
			desc = (UnityEngine.RenderTextureDescriptor)___parameters[0];

            return (UnityEngine.RenderTexture)___result;
        }


        public virtual UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rget_graphicsFormat.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Experimental.Rendering.GraphicsFormat)___result;
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
