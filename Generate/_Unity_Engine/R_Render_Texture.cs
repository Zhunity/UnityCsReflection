
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.RenderTexture
	/// </summary>
    public partial class RRenderTexture : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.RenderTexture);
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


		/// <summary>
		/// Int32 width
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pwidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPwidth
		{
			get
			{
				if(r_Pwidth == null)
				{
					r_Pwidth = new(this, "width", -1);
				}
				return r_Pwidth;
			}
		}

		/// <summary>
		/// Int32 height
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pheight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPheight
		{
			get
			{
				if(r_Pheight == null)
				{
					r_Pheight = new(this, "height", -1);
				}
				return r_Pheight;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.TextureDimension dimension
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RTextureDimension r_Pdimension;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RTextureDimension RPdimension
		{
			get
			{
				if(r_Pdimension == null)
				{
					r_Pdimension = new(this, "dimension", -1);
				}
				return r_Pdimension;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_PgraphicsFormat;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RPgraphicsFormat
		{
			get
			{
				if(r_PgraphicsFormat == null)
				{
					r_PgraphicsFormat = new(this, "graphicsFormat", -1);
				}
				return r_PgraphicsFormat;
			}
		}

		/// <summary>
		/// Boolean useMipMap
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PuseMipMap;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPuseMipMap
		{
			get
			{
				if(r_PuseMipMap == null)
				{
					r_PuseMipMap = new(this, "useMipMap", -1);
				}
				return r_PuseMipMap;
			}
		}

		/// <summary>
		/// Boolean sRGB
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PsRGB;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPsRGB
		{
			get
			{
				if(r_PsRGB == null)
				{
					r_PsRGB = new(this, "sRGB", -1);
				}
				return r_PsRGB;
			}
		}

		/// <summary>
		/// UnityEngine.VRTextureUsage vrUsage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVRTextureUsage r_PvrUsage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVRTextureUsage RPvrUsage
		{
			get
			{
				if(r_PvrUsage == null)
				{
					r_PvrUsage = new(this, "vrUsage", -1);
				}
				return r_PvrUsage;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTextureMemoryless memorylessMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureMemoryless r_PmemorylessMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureMemoryless RPmemorylessMode
		{
			get
			{
				if(r_PmemorylessMode == null)
				{
					r_PmemorylessMode = new(this, "memorylessMode", -1);
				}
				return r_PmemorylessMode;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTextureFormat format
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureFormat r_Pformat;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureFormat RPformat
		{
			get
			{
				if(r_Pformat == null)
				{
					r_Pformat = new(this, "format", -1);
				}
				return r_Pformat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat stencilFormat
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_PstencilFormat;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RPstencilFormat
		{
			get
			{
				if(r_PstencilFormat == null)
				{
					r_PstencilFormat = new(this, "stencilFormat", -1);
				}
				return r_PstencilFormat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat r_PdepthStencilFormat;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RExperimental.RRendering.RGraphicsFormat RPdepthStencilFormat
		{
			get
			{
				if(r_PdepthStencilFormat == null)
				{
					r_PdepthStencilFormat = new(this, "depthStencilFormat", -1);
				}
				return r_PdepthStencilFormat;
			}
		}

		/// <summary>
		/// Boolean autoGenerateMips
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PautoGenerateMips;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPautoGenerateMips
		{
			get
			{
				if(r_PautoGenerateMips == null)
				{
					r_PautoGenerateMips = new(this, "autoGenerateMips", -1);
				}
				return r_PautoGenerateMips;
			}
		}

		/// <summary>
		/// Int32 volumeDepth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PvolumeDepth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPvolumeDepth
		{
			get
			{
				if(r_PvolumeDepth == null)
				{
					r_PvolumeDepth = new(this, "volumeDepth", -1);
				}
				return r_PvolumeDepth;
			}
		}

		/// <summary>
		/// Int32 antiAliasing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PantiAliasing;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPantiAliasing
		{
			get
			{
				if(r_PantiAliasing == null)
				{
					r_PantiAliasing = new(this, "antiAliasing", -1);
				}
				return r_PantiAliasing;
			}
		}

		/// <summary>
		/// Boolean bindTextureMS
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PbindTextureMS;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPbindTextureMS
		{
			get
			{
				if(r_PbindTextureMS == null)
				{
					r_PbindTextureMS = new(this, "bindTextureMS", -1);
				}
				return r_PbindTextureMS;
			}
		}

		/// <summary>
		/// Boolean enableRandomWrite
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PenableRandomWrite;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPenableRandomWrite
		{
			get
			{
				if(r_PenableRandomWrite == null)
				{
					r_PenableRandomWrite = new(this, "enableRandomWrite", -1);
				}
				return r_PenableRandomWrite;
			}
		}

		/// <summary>
		/// Boolean useDynamicScale
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PuseDynamicScale;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPuseDynamicScale
		{
			get
			{
				if(r_PuseDynamicScale == null)
				{
					r_PuseDynamicScale = new(this, "useDynamicScale", -1);
				}
				return r_PuseDynamicScale;
			}
		}

		/// <summary>
		/// Boolean isPowerOfTwo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisPowerOfTwo;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisPowerOfTwo
		{
			get
			{
				if(r_PisPowerOfTwo == null)
				{
					r_PisPowerOfTwo = new(this, "isPowerOfTwo", -1);
				}
				return r_PisPowerOfTwo;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture active
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture r_Pactive;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture RPactive
		{
			get
			{
				if(r_Pactive == null)
				{
					r_Pactive = new(Type, "active", -1);
				}
				return r_Pactive;
			}
		}

		/// <summary>
		/// UnityEngine.RenderBuffer colorBuffer
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRenderBuffer r_PcolorBuffer;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRenderBuffer RPcolorBuffer
		{
			get
			{
				if(r_PcolorBuffer == null)
				{
					r_PcolorBuffer = new(this, "colorBuffer", -1);
				}
				return r_PcolorBuffer;
			}
		}

		/// <summary>
		/// UnityEngine.RenderBuffer depthBuffer
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRenderBuffer r_PdepthBuffer;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRenderBuffer RPdepthBuffer
		{
			get
			{
				if(r_PdepthBuffer == null)
				{
					r_PdepthBuffer = new(this, "depthBuffer", -1);
				}
				return r_PdepthBuffer;
			}
		}

		/// <summary>
		/// Int32 depth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pdepth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPdepth
		{
			get
			{
				if(r_Pdepth == null)
				{
					r_Pdepth = new(this, "depth", -1);
				}
				return r_Pdepth;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTextureDescriptor descriptor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureDescriptor r_Pdescriptor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRenderTextureDescriptor RPdescriptor
		{
			get
			{
				if(r_Pdescriptor == null)
				{
					r_Pdescriptor = new(this, "descriptor", -1);
				}
				return r_Pdescriptor;
			}
		}

		/// <summary>
		/// Boolean generateMips
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PgenerateMips;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPgenerateMips
		{
			get
			{
				if(r_PgenerateMips == null)
				{
					r_PgenerateMips = new(this, "generateMips", -1);
				}
				return r_PgenerateMips;
			}
		}

		/// <summary>
		/// Boolean isCubemap
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisCubemap;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisCubemap
		{
			get
			{
				if(r_PisCubemap == null)
				{
					r_PisCubemap = new(this, "isCubemap", -1);
				}
				return r_PisCubemap;
			}
		}

		/// <summary>
		/// Boolean isVolume
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisVolume;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisVolume
		{
			get
			{
				if(r_PisVolume == null)
				{
					r_PisVolume = new(this, "isVolume", -1);
				}
				return r_PisVolume;
			}
		}

		/// <summary>
		/// Boolean enabled
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_Penabled;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RPenabled
		{
			get
			{
				if(r_Penabled == null)
				{
					r_Penabled = new(Type, "enabled", -1);
				}
				return r_Penabled;
			}
		}

		/// <summary>
		/// Int32 mipmapCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PmipmapCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPmipmapCount
		{
			get
			{
				if(r_PmipmapCount == null)
				{
					r_PmipmapCount = new(this, "mipmapCount", -1);
				}
				return r_PmipmapCount;
			}
		}

		/// <summary>
		/// Boolean isReadable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisReadable;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisReadable
		{
			get
			{
				if(r_PisReadable == null)
				{
					r_PisReadable = new(this, "isReadable", -1);
				}
				return r_PisReadable;
			}
		}

		/// <summary>
		/// UnityEngine.TextureWrapMode wrapMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextureWrapMode r_PwrapMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextureWrapMode RPwrapMode
		{
			get
			{
				if(r_PwrapMode == null)
				{
					r_PwrapMode = new(this, "wrapMode", -1);
				}
				return r_PwrapMode;
			}
		}

		/// <summary>
		/// UnityEngine.TextureWrapMode wrapModeU
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextureWrapMode r_PwrapModeU;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextureWrapMode RPwrapModeU
		{
			get
			{
				if(r_PwrapModeU == null)
				{
					r_PwrapModeU = new(this, "wrapModeU", -1);
				}
				return r_PwrapModeU;
			}
		}

		/// <summary>
		/// UnityEngine.TextureWrapMode wrapModeV
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextureWrapMode r_PwrapModeV;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextureWrapMode RPwrapModeV
		{
			get
			{
				if(r_PwrapModeV == null)
				{
					r_PwrapModeV = new(this, "wrapModeV", -1);
				}
				return r_PwrapModeV;
			}
		}

		/// <summary>
		/// UnityEngine.TextureWrapMode wrapModeW
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextureWrapMode r_PwrapModeW;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextureWrapMode RPwrapModeW
		{
			get
			{
				if(r_PwrapModeW == null)
				{
					r_PwrapModeW = new(this, "wrapModeW", -1);
				}
				return r_PwrapModeW;
			}
		}

		/// <summary>
		/// UnityEngine.FilterMode filterMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RFilterMode r_PfilterMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RFilterMode RPfilterMode
		{
			get
			{
				if(r_PfilterMode == null)
				{
					r_PfilterMode = new(this, "filterMode", -1);
				}
				return r_PfilterMode;
			}
		}

		/// <summary>
		/// Int32 anisoLevel
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PanisoLevel;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPanisoLevel
		{
			get
			{
				if(r_PanisoLevel == null)
				{
					r_PanisoLevel = new(this, "anisoLevel", -1);
				}
				return r_PanisoLevel;
			}
		}

		/// <summary>
		/// Single mipMapBias
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PmipMapBias;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPmipMapBias
		{
			get
			{
				if(r_PmipMapBias == null)
				{
					r_PmipMapBias = new(this, "mipMapBias", -1);
				}
				return r_PmipMapBias;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 texelSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PtexelSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPtexelSize
		{
			get
			{
				if(r_PtexelSize == null)
				{
					r_PtexelSize = new(this, "texelSize", -1);
				}
				return r_PtexelSize;
			}
		}

		/// <summary>
		/// UInt32 updateCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_PupdateCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPupdateCount
		{
			get
			{
				if(r_PupdateCount == null)
				{
					r_PupdateCount = new(this, "updateCount", -1);
				}
				return r_PupdateCount;
			}
		}

		/// <summary>
		/// UnityEngine.ColorSpace activeTextureColorSpace
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColorSpace r_PactiveTextureColorSpace;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColorSpace RPactiveTextureColorSpace
		{
			get
			{
				if(r_PactiveTextureColorSpace == null)
				{
					r_PactiveTextureColorSpace = new(this, "activeTextureColorSpace", -1);
				}
				return r_PactiveTextureColorSpace;
			}
		}

		/// <summary>
		/// Boolean isDataSRGB
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisDataSRGB;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisDataSRGB
		{
			get
			{
				if(r_PisDataSRGB == null)
				{
					r_PisDataSRGB = new(this, "isDataSRGB", -1);
				}
				return r_PisDataSRGB;
			}
		}

		/// <summary>
		/// UnityEngine.Hash128 imageContentsHash
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RHash128 r_PimageContentsHash;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RHash128 RPimageContentsHash
		{
			get
			{
				if(r_PimageContentsHash == null)
				{
					r_PimageContentsHash = new(this, "imageContentsHash", -1);
				}
				return r_PimageContentsHash;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RHideFlags r_PhideFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RHideFlags RPhideFlags
		{
			get
			{
				if(r_PhideFlags == null)
				{
					r_PhideFlags = new(this, "hideFlags", -1);
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat GetColorFormat(Boolean)
		/// </summary>
		protected RMethod r_MGetColorFormat_Boolean;
		public virtual RMethod RMGetColorFormat_Boolean
		{
			get
			{
				if(r_MGetColorFormat_Boolean == null)
				{
					r_MGetColorFormat_Boolean = new(this, "GetColorFormat", 0, typeof(System.Boolean));
				}
				return r_MGetColorFormat_Boolean;
			}
		}

		/// <summary>
		/// Void SetColorFormat(UnityEngine.Experimental.Rendering.GraphicsFormat)
		/// </summary>
		protected RMethod r_MSetColorFormat_GraphicsFormat;
		public virtual RMethod RMSetColorFormat_GraphicsFormat
		{
			get
			{
				if(r_MSetColorFormat_GraphicsFormat == null)
				{
					r_MSetColorFormat_GraphicsFormat = new(this, "SetColorFormat", 0, typeof(UnityEngine.Experimental.Rendering.GraphicsFormat));
				}
				return r_MSetColorFormat_GraphicsFormat;
			}
		}

		/// <summary>
		/// Boolean GetIsPowerOfTwo()
		/// </summary>
		protected RMethod r_MGetIsPowerOfTwo;
		public virtual RMethod RMGetIsPowerOfTwo
		{
			get
			{
				if(r_MGetIsPowerOfTwo == null)
				{
					r_MGetIsPowerOfTwo = new(this, "GetIsPowerOfTwo", 0);
				}
				return r_MGetIsPowerOfTwo;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetActive()
		/// </summary>
		protected static RMethod r_MGetActive;
		public static RMethod RMGetActive
		{
			get
			{
				if(r_MGetActive == null)
				{
					r_MGetActive = new(Type, "GetActive", 0);
				}
				return r_MGetActive;
			}
		}

		/// <summary>
		/// Void SetActive(UnityEngine.RenderTexture)
		/// </summary>
		protected static RMethod r_MSetActive_RenderTexture;
		public static RMethod RMSetActive_RenderTexture
		{
			get
			{
				if(r_MSetActive_RenderTexture == null)
				{
					r_MSetActive_RenderTexture = new(Type, "SetActive", 0, typeof(UnityEngine.RenderTexture));
				}
				return r_MSetActive_RenderTexture;
			}
		}

		/// <summary>
		/// UnityEngine.RenderBuffer GetColorBuffer()
		/// </summary>
		protected RMethod r_MGetColorBuffer;
		public virtual RMethod RMGetColorBuffer
		{
			get
			{
				if(r_MGetColorBuffer == null)
				{
					r_MGetColorBuffer = new(this, "GetColorBuffer", 0);
				}
				return r_MGetColorBuffer;
			}
		}

		/// <summary>
		/// UnityEngine.RenderBuffer GetDepthBuffer()
		/// </summary>
		protected RMethod r_MGetDepthBuffer;
		public virtual RMethod RMGetDepthBuffer
		{
			get
			{
				if(r_MGetDepthBuffer == null)
				{
					r_MGetDepthBuffer = new(this, "GetDepthBuffer", 0);
				}
				return r_MGetDepthBuffer;
			}
		}

		/// <summary>
		/// Void SetMipMapCount(Int32)
		/// </summary>
		protected RMethod r_MSetMipMapCount_Int32;
		public virtual RMethod RMSetMipMapCount_Int32
		{
			get
			{
				if(r_MSetMipMapCount_Int32 == null)
				{
					r_MSetMipMapCount_Int32 = new(this, "SetMipMapCount", 0, typeof(System.Int32));
				}
				return r_MSetMipMapCount_Int32;
			}
		}

		/// <summary>
		/// Void SetShadowSamplingMode(UnityEngine.Rendering.ShadowSamplingMode)
		/// </summary>
		protected RMethod r_MSetShadowSamplingMode_ShadowSamplingMode;
		public virtual RMethod RMSetShadowSamplingMode_ShadowSamplingMode
		{
			get
			{
				if(r_MSetShadowSamplingMode_ShadowSamplingMode == null)
				{
					r_MSetShadowSamplingMode_ShadowSamplingMode = new(this, "SetShadowSamplingMode", 0, typeof(UnityEngine.Rendering.ShadowSamplingMode));
				}
				return r_MSetShadowSamplingMode_ShadowSamplingMode;
			}
		}

		/// <summary>
		/// IntPtr GetNativeDepthBufferPtr()
		/// </summary>
		protected RMethod r_MGetNativeDepthBufferPtr;
		public virtual RMethod RMGetNativeDepthBufferPtr
		{
			get
			{
				if(r_MGetNativeDepthBufferPtr == null)
				{
					r_MGetNativeDepthBufferPtr = new(this, "GetNativeDepthBufferPtr", 0);
				}
				return r_MGetNativeDepthBufferPtr;
			}
		}

		/// <summary>
		/// Void DiscardContents(Boolean, Boolean)
		/// </summary>
		protected RMethod r_MDiscardContents_Boolean_Boolean;
		public virtual RMethod RMDiscardContents_Boolean_Boolean
		{
			get
			{
				if(r_MDiscardContents_Boolean_Boolean == null)
				{
					r_MDiscardContents_Boolean_Boolean = new(this, "DiscardContents", 0, typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MDiscardContents_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void MarkRestoreExpected()
		/// </summary>
		protected RMethod r_MMarkRestoreExpected;
		public virtual RMethod RMMarkRestoreExpected
		{
			get
			{
				if(r_MMarkRestoreExpected == null)
				{
					r_MMarkRestoreExpected = new(this, "MarkRestoreExpected", 0);
				}
				return r_MMarkRestoreExpected;
			}
		}

		/// <summary>
		/// Void DiscardContents()
		/// </summary>
		protected RMethod r_MDiscardContents;
		public virtual RMethod RMDiscardContents
		{
			get
			{
				if(r_MDiscardContents == null)
				{
					r_MDiscardContents = new(this, "DiscardContents", 0);
				}
				return r_MDiscardContents;
			}
		}

		/// <summary>
		/// Void ResolveAA()
		/// </summary>
		protected RMethod r_MResolveAA;
		public virtual RMethod RMResolveAA
		{
			get
			{
				if(r_MResolveAA == null)
				{
					r_MResolveAA = new(this, "ResolveAA", 0);
				}
				return r_MResolveAA;
			}
		}

		/// <summary>
		/// Void ResolveAATo(UnityEngine.RenderTexture)
		/// </summary>
		protected RMethod r_MResolveAATo_RenderTexture;
		public virtual RMethod RMResolveAATo_RenderTexture
		{
			get
			{
				if(r_MResolveAATo_RenderTexture == null)
				{
					r_MResolveAATo_RenderTexture = new(this, "ResolveAATo", 0, typeof(UnityEngine.RenderTexture));
				}
				return r_MResolveAATo_RenderTexture;
			}
		}

		/// <summary>
		/// Void ResolveAntiAliasedSurface()
		/// </summary>
		protected RMethod r_MResolveAntiAliasedSurface;
		public virtual RMethod RMResolveAntiAliasedSurface
		{
			get
			{
				if(r_MResolveAntiAliasedSurface == null)
				{
					r_MResolveAntiAliasedSurface = new(this, "ResolveAntiAliasedSurface", 0);
				}
				return r_MResolveAntiAliasedSurface;
			}
		}

		/// <summary>
		/// Void ResolveAntiAliasedSurface(UnityEngine.RenderTexture)
		/// </summary>
		protected RMethod r_MResolveAntiAliasedSurface_RenderTexture;
		public virtual RMethod RMResolveAntiAliasedSurface_RenderTexture
		{
			get
			{
				if(r_MResolveAntiAliasedSurface_RenderTexture == null)
				{
					r_MResolveAntiAliasedSurface_RenderTexture = new(this, "ResolveAntiAliasedSurface", 0, typeof(UnityEngine.RenderTexture));
				}
				return r_MResolveAntiAliasedSurface_RenderTexture;
			}
		}

		/// <summary>
		/// Void SetGlobalShaderProperty(System.String)
		/// </summary>
		protected RMethod r_MSetGlobalShaderProperty_String;
		public virtual RMethod RMSetGlobalShaderProperty_String
		{
			get
			{
				if(r_MSetGlobalShaderProperty_String == null)
				{
					r_MSetGlobalShaderProperty_String = new(this, "SetGlobalShaderProperty", 0, typeof(System.String));
				}
				return r_MSetGlobalShaderProperty_String;
			}
		}

		/// <summary>
		/// Boolean Create()
		/// </summary>
		protected RMethod r_MCreate;
		public virtual RMethod RMCreate
		{
			get
			{
				if(r_MCreate == null)
				{
					r_MCreate = new(this, "Create", 0);
				}
				return r_MCreate;
			}
		}

		/// <summary>
		/// Void Release()
		/// </summary>
		protected RMethod r_MRelease;
		public virtual RMethod RMRelease
		{
			get
			{
				if(r_MRelease == null)
				{
					r_MRelease = new(this, "Release", 0);
				}
				return r_MRelease;
			}
		}

		/// <summary>
		/// Boolean IsCreated()
		/// </summary>
		protected RMethod r_MIsCreated;
		public virtual RMethod RMIsCreated
		{
			get
			{
				if(r_MIsCreated == null)
				{
					r_MIsCreated = new(this, "IsCreated", 0);
				}
				return r_MIsCreated;
			}
		}

		/// <summary>
		/// Void GenerateMips()
		/// </summary>
		protected RMethod r_MGenerateMips;
		public virtual RMethod RMGenerateMips
		{
			get
			{
				if(r_MGenerateMips == null)
				{
					r_MGenerateMips = new(this, "GenerateMips", 0);
				}
				return r_MGenerateMips;
			}
		}

		/// <summary>
		/// Void ConvertToEquirect(UnityEngine.RenderTexture, MonoOrStereoscopicEye)
		/// </summary>
		protected RMethod r_MConvertToEquirect_RenderTexture_MonoOrStereoscopicEye;
		public virtual RMethod RMConvertToEquirect_RenderTexture_MonoOrStereoscopicEye
		{
			get
			{
				if(r_MConvertToEquirect_RenderTexture_MonoOrStereoscopicEye == null)
				{
					r_MConvertToEquirect_RenderTexture_MonoOrStereoscopicEye = new(this, "ConvertToEquirect", 0, typeof(UnityEngine.RenderTexture),  ReflectionUtils.GetType("UnityEngine.Camera+MonoOrStereoscopicEye"));
				}
				return r_MConvertToEquirect_RenderTexture_MonoOrStereoscopicEye;
			}
		}

		/// <summary>
		/// Void SetSRGBReadWrite(Boolean)
		/// </summary>
		protected RMethod r_MSetSRGBReadWrite_Boolean;
		public virtual RMethod RMSetSRGBReadWrite_Boolean
		{
			get
			{
				if(r_MSetSRGBReadWrite_Boolean == null)
				{
					r_MSetSRGBReadWrite_Boolean = new(this, "SetSRGBReadWrite", 0, typeof(System.Boolean));
				}
				return r_MSetSRGBReadWrite_Boolean;
			}
		}

		/// <summary>
		/// Void Internal_Create(UnityEngine.RenderTexture)
		/// </summary>
		protected static RMethod r_MInternal_Create_RenderTexture;
		public static RMethod RMInternal_Create_RenderTexture
		{
			get
			{
				if(r_MInternal_Create_RenderTexture == null)
				{
					r_MInternal_Create_RenderTexture = new(Type, "Internal_Create", 0, typeof(UnityEngine.RenderTexture));
				}
				return r_MInternal_Create_RenderTexture;
			}
		}

		/// <summary>
		/// Boolean SupportsStencil(UnityEngine.RenderTexture)
		/// </summary>
		protected static RMethod r_MSupportsStencil_RenderTexture;
		public static RMethod RMSupportsStencil_RenderTexture
		{
			get
			{
				if(r_MSupportsStencil_RenderTexture == null)
				{
					r_MSupportsStencil_RenderTexture = new(Type, "SupportsStencil", 0, typeof(UnityEngine.RenderTexture));
				}
				return r_MSupportsStencil_RenderTexture;
			}
		}

		/// <summary>
		/// Void SetRenderTextureDescriptor(UnityEngine.RenderTextureDescriptor)
		/// </summary>
		protected RMethod r_MSetRenderTextureDescriptor_RenderTextureDescriptor;
		public virtual RMethod RMSetRenderTextureDescriptor_RenderTextureDescriptor
		{
			get
			{
				if(r_MSetRenderTextureDescriptor_RenderTextureDescriptor == null)
				{
					r_MSetRenderTextureDescriptor_RenderTextureDescriptor = new(this, "SetRenderTextureDescriptor", 0, typeof(UnityEngine.RenderTextureDescriptor));
				}
				return r_MSetRenderTextureDescriptor_RenderTextureDescriptor;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTextureDescriptor GetDescriptor()
		/// </summary>
		protected RMethod r_MGetDescriptor;
		public virtual RMethod RMGetDescriptor
		{
			get
			{
				if(r_MGetDescriptor == null)
				{
					r_MGetDescriptor = new(this, "GetDescriptor", 0);
				}
				return r_MGetDescriptor;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary_Internal(UnityEngine.RenderTextureDescriptor)
		/// </summary>
		protected static RMethod r_MGetTemporary_Internal_RenderTextureDescriptor;
		public static RMethod RMGetTemporary_Internal_RenderTextureDescriptor
		{
			get
			{
				if(r_MGetTemporary_Internal_RenderTextureDescriptor == null)
				{
					r_MGetTemporary_Internal_RenderTextureDescriptor = new(Type, "GetTemporary_Internal", 0, typeof(UnityEngine.RenderTextureDescriptor));
				}
				return r_MGetTemporary_Internal_RenderTextureDescriptor;
			}
		}

		/// <summary>
		/// Void ReleaseTemporary(UnityEngine.RenderTexture)
		/// </summary>
		protected static RMethod r_MReleaseTemporary_RenderTexture;
		public static RMethod RMReleaseTemporary_RenderTexture
		{
			get
			{
				if(r_MReleaseTemporary_RenderTexture == null)
				{
					r_MReleaseTemporary_RenderTexture = new(Type, "ReleaseTemporary", 0, typeof(UnityEngine.RenderTexture));
				}
				return r_MReleaseTemporary_RenderTexture;
			}
		}

		/// <summary>
		/// Void Initialize(Int32, Int32, Int32, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, Int32)
		/// </summary>
		protected RMethod r_MInitialize_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32;
		public virtual RMethod RMInitialize_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32
		{
			get
			{
				if(r_MInitialize_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32 == null)
				{
					r_MInitialize_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32 = new(this, "Initialize", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32));
				}
				return r_MInitialize_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(Int32, UnityEngine.Experimental.Rendering.GraphicsFormat)
		/// </summary>
		protected static RMethod r_MGetDepthStencilFormatLegacy_Int32_GraphicsFormat;
		public static RMethod RMGetDepthStencilFormatLegacy_Int32_GraphicsFormat
		{
			get
			{
				if(r_MGetDepthStencilFormatLegacy_Int32_GraphicsFormat == null)
				{
					r_MGetDepthStencilFormatLegacy_Int32_GraphicsFormat = new(Type, "GetDepthStencilFormatLegacy", 0, typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat));
				}
				return r_MGetDepthStencilFormatLegacy_Int32_GraphicsFormat;
			}
		}

		/// <summary>
		/// Void ValidateRenderTextureDesc(UnityEngine.RenderTextureDescriptor)
		/// </summary>
		protected static RMethod r_MValidateRenderTextureDesc_RenderTextureDescriptor;
		public static RMethod RMValidateRenderTextureDesc_RenderTextureDescriptor
		{
			get
			{
				if(r_MValidateRenderTextureDesc_RenderTextureDescriptor == null)
				{
					r_MValidateRenderTextureDesc_RenderTextureDescriptor = new(Type, "ValidateRenderTextureDesc", 0, typeof(UnityEngine.RenderTextureDescriptor));
				}
				return r_MValidateRenderTextureDesc_RenderTextureDescriptor;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite)
		/// </summary>
		protected static RMethod r_MGetCompatibleFormat_RenderTextureFormat_RenderTextureReadWrite;
		public static RMethod RMGetCompatibleFormat_RenderTextureFormat_RenderTextureReadWrite
		{
			get
			{
				if(r_MGetCompatibleFormat_RenderTextureFormat_RenderTextureReadWrite == null)
				{
					r_MGetCompatibleFormat_RenderTextureFormat_RenderTextureReadWrite = new(Type, "GetCompatibleFormat", 0, typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite));
				}
				return r_MGetCompatibleFormat_RenderTextureFormat_RenderTextureReadWrite;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(UnityEngine.RenderTextureDescriptor)
		/// </summary>
		protected static RMethod r_MGetTemporary_RenderTextureDescriptor;
		public static RMethod RMGetTemporary_RenderTextureDescriptor
		{
			get
			{
				if(r_MGetTemporary_RenderTextureDescriptor == null)
				{
					r_MGetTemporary_RenderTextureDescriptor = new(Type, "GetTemporary", 0, typeof(UnityEngine.RenderTextureDescriptor));
				}
				return r_MGetTemporary_RenderTextureDescriptor;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporaryImpl(Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32, UnityEngine.RenderTextureMemoryless, UnityEngine.VRTextureUsage, Boolean)
		/// </summary>
		protected static RMethod r_MGetTemporaryImpl_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean;
		public static RMethod RMGetTemporaryImpl_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean
		{
			get
			{
				if(r_MGetTemporaryImpl_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean == null)
				{
					r_MGetTemporaryImpl_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean = new(Type, "GetTemporaryImpl", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32), typeof(UnityEngine.RenderTextureMemoryless), typeof(UnityEngine.VRTextureUsage), typeof(System.Boolean));
				}
				return r_MGetTemporaryImpl_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32, UnityEngine.RenderTextureMemoryless, UnityEngine.VRTextureUsage, Boolean)
		/// </summary>
		protected static RMethod r_MGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean;
		public static RMethod RMGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean
		{
			get
			{
				if(r_MGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean == null)
				{
					r_MGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean = new(Type, "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32), typeof(UnityEngine.RenderTextureMemoryless), typeof(UnityEngine.VRTextureUsage), typeof(System.Boolean));
				}
				return r_MGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32, UnityEngine.RenderTextureMemoryless, UnityEngine.VRTextureUsage)
		/// </summary>
		protected static RMethod r_MGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage;
		public static RMethod RMGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage
		{
			get
			{
				if(r_MGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage == null)
				{
					r_MGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage = new(Type, "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32), typeof(UnityEngine.RenderTextureMemoryless), typeof(UnityEngine.VRTextureUsage));
				}
				return r_MGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32, UnityEngine.RenderTextureMemoryless)
		/// </summary>
		protected static RMethod r_MGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless;
		public static RMethod RMGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless
		{
			get
			{
				if(r_MGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless == null)
				{
					r_MGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless = new(Type, "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32), typeof(UnityEngine.RenderTextureMemoryless));
				}
				return r_MGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, Int32)
		/// </summary>
		protected static RMethod r_MGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32;
		public static RMethod RMGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32
		{
			get
			{
				if(r_MGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32 == null)
				{
					r_MGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32 = new(Type, "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32));
				}
				return r_MGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat)
		/// </summary>
		protected static RMethod r_MGetTemporary_Int32_Int32_Int32_GraphicsFormat;
		public static RMethod RMGetTemporary_Int32_Int32_Int32_GraphicsFormat
		{
			get
			{
				if(r_MGetTemporary_Int32_Int32_Int32_GraphicsFormat == null)
				{
					r_MGetTemporary_Int32_Int32_Int32_GraphicsFormat = new(Type, "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat));
				}
				return r_MGetTemporary_Int32_Int32_Int32_GraphicsFormat;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, Int32, UnityEngine.RenderTextureMemoryless, UnityEngine.VRTextureUsage, Boolean)
		/// </summary>
		protected static RMethod r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean;
		public static RMethod RMGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean
		{
			get
			{
				if(r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean == null)
				{
					r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean = new(Type, "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32), typeof(UnityEngine.RenderTextureMemoryless), typeof(UnityEngine.VRTextureUsage), typeof(System.Boolean));
				}
				return r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, Int32, UnityEngine.RenderTextureMemoryless, UnityEngine.VRTextureUsage)
		/// </summary>
		protected static RMethod r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage;
		public static RMethod RMGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage
		{
			get
			{
				if(r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage == null)
				{
					r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage = new(Type, "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32), typeof(UnityEngine.RenderTextureMemoryless), typeof(UnityEngine.VRTextureUsage));
				}
				return r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, Int32, UnityEngine.RenderTextureMemoryless)
		/// </summary>
		protected static RMethod r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless;
		public static RMethod RMGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless
		{
			get
			{
				if(r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless == null)
				{
					r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless = new(Type, "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32), typeof(UnityEngine.RenderTextureMemoryless));
				}
				return r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, Int32)
		/// </summary>
		protected static RMethod r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32;
		public static RMethod RMGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32
		{
			get
			{
				if(r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32 == null)
				{
					r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32 = new(Type, "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite), typeof(System.Int32));
				}
				return r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite)
		/// </summary>
		protected static RMethod r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite;
		public static RMethod RMGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite
		{
			get
			{
				if(r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite == null)
				{
					r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite = new(Type, "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.RenderTextureFormat), typeof(UnityEngine.RenderTextureReadWrite));
				}
				return r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32, UnityEngine.RenderTextureFormat)
		/// </summary>
		protected static RMethod r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat;
		public static RMethod RMGetTemporary_Int32_Int32_Int32_RenderTextureFormat
		{
			get
			{
				if(r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat == null)
				{
					r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat = new(Type, "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.RenderTextureFormat));
				}
				return r_MGetTemporary_Int32_Int32_Int32_RenderTextureFormat;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_MGetTemporary_Int32_Int32_Int32;
		public static RMethod RMGetTemporary_Int32_Int32_Int32
		{
			get
			{
				if(r_MGetTemporary_Int32_Int32_Int32 == null)
				{
					r_MGetTemporary_Int32_Int32_Int32 = new(Type, "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetTemporary_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary(Int32, Int32)
		/// </summary>
		protected static RMethod r_MGetTemporary_Int32_Int32;
		public static RMethod RMGetTemporary_Int32_Int32
		{
			get
			{
				if(r_MGetTemporary_Int32_Int32 == null)
				{
					r_MGetTemporary_Int32_Int32 = new(Type, "GetTemporary", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetTemporary_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetBorderColor(UnityEngine.Color)
		/// </summary>
		protected RMethod r_MSetBorderColor_Color;
		public virtual RMethod RMSetBorderColor_Color
		{
			get
			{
				if(r_MSetBorderColor_Color == null)
				{
					r_MSetBorderColor_Color = new(this, "SetBorderColor", 0, typeof(UnityEngine.Color));
				}
				return r_MSetBorderColor_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetTexelOffset()
		/// </summary>
		protected RMethod r_MGetTexelOffset;
		public virtual RMethod RMGetTexelOffset
		{
			get
			{
				if(r_MGetTexelOffset == null)
				{
					r_MGetTexelOffset = new(this, "GetTexelOffset", 0);
				}
				return r_MGetTexelOffset;
			}
		}

		/// <summary>
		/// Void GetColorBuffer_Injected(UnityEngine.RenderBuffer ByRef)
		/// </summary>
		protected RMethod r_MGetColorBuffer_Injected_Out_RenderBuffer;
		public virtual RMethod RMGetColorBuffer_Injected_Out_RenderBuffer
		{
			get
			{
				if(r_MGetColorBuffer_Injected_Out_RenderBuffer == null)
				{
					r_MGetColorBuffer_Injected_Out_RenderBuffer = new(this, "GetColorBuffer_Injected", 0, typeof(UnityEngine.RenderBuffer).MakeByRefType());
				}
				return r_MGetColorBuffer_Injected_Out_RenderBuffer;
			}
		}

		/// <summary>
		/// Void GetDepthBuffer_Injected(UnityEngine.RenderBuffer ByRef)
		/// </summary>
		protected RMethod r_MGetDepthBuffer_Injected_Out_RenderBuffer;
		public virtual RMethod RMGetDepthBuffer_Injected_Out_RenderBuffer
		{
			get
			{
				if(r_MGetDepthBuffer_Injected_Out_RenderBuffer == null)
				{
					r_MGetDepthBuffer_Injected_Out_RenderBuffer = new(this, "GetDepthBuffer_Injected", 0, typeof(UnityEngine.RenderBuffer).MakeByRefType());
				}
				return r_MGetDepthBuffer_Injected_Out_RenderBuffer;
			}
		}

		/// <summary>
		/// Void SetRenderTextureDescriptor_Injected(UnityEngine.RenderTextureDescriptor ByRef)
		/// </summary>
		protected RMethod r_MSetRenderTextureDescriptor_Injected_Ref_RenderTextureDescriptor;
		public virtual RMethod RMSetRenderTextureDescriptor_Injected_Ref_RenderTextureDescriptor
		{
			get
			{
				if(r_MSetRenderTextureDescriptor_Injected_Ref_RenderTextureDescriptor == null)
				{
					r_MSetRenderTextureDescriptor_Injected_Ref_RenderTextureDescriptor = new(this, "SetRenderTextureDescriptor_Injected", 0, typeof(UnityEngine.RenderTextureDescriptor).MakeByRefType());
				}
				return r_MSetRenderTextureDescriptor_Injected_Ref_RenderTextureDescriptor;
			}
		}

		/// <summary>
		/// Void GetDescriptor_Injected(UnityEngine.RenderTextureDescriptor ByRef)
		/// </summary>
		protected RMethod r_MGetDescriptor_Injected_Out_RenderTextureDescriptor;
		public virtual RMethod RMGetDescriptor_Injected_Out_RenderTextureDescriptor
		{
			get
			{
				if(r_MGetDescriptor_Injected_Out_RenderTextureDescriptor == null)
				{
					r_MGetDescriptor_Injected_Out_RenderTextureDescriptor = new(this, "GetDescriptor_Injected", 0, typeof(UnityEngine.RenderTextureDescriptor).MakeByRefType());
				}
				return r_MGetDescriptor_Injected_Out_RenderTextureDescriptor;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture GetTemporary_Internal_Injected(UnityEngine.RenderTextureDescriptor ByRef)
		/// </summary>
		protected static RMethod r_MGetTemporary_Internal_Injected_Ref_RenderTextureDescriptor;
		public static RMethod RMGetTemporary_Internal_Injected_Ref_RenderTextureDescriptor
		{
			get
			{
				if(r_MGetTemporary_Internal_Injected_Ref_RenderTextureDescriptor == null)
				{
					r_MGetTemporary_Internal_Injected_Ref_RenderTextureDescriptor = new(Type, "GetTemporary_Internal_Injected", 0, typeof(UnityEngine.RenderTextureDescriptor).MakeByRefType());
				}
				return r_MGetTemporary_Internal_Injected_Ref_RenderTextureDescriptor;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat()
		/// </summary>
		protected RMethod r_Mget_graphicsFormat;
		public virtual RMethod RMget_graphicsFormat
		{
			get
			{
				if(r_Mget_graphicsFormat == null)
				{
					r_Mget_graphicsFormat = new(this, "get_graphicsFormat", 0);
				}
				return r_Mget_graphicsFormat;
			}
		}

		/// <summary>
		/// IntPtr GetNativeTexturePtr()
		/// </summary>
		protected RMethod r_MGetNativeTexturePtr;
		public virtual RMethod RMGetNativeTexturePtr
		{
			get
			{
				if(r_MGetNativeTexturePtr == null)
				{
					r_MGetNativeTexturePtr = new(this, "GetNativeTexturePtr", 0);
				}
				return r_MGetNativeTexturePtr;
			}
		}

		/// <summary>
		/// Int32 GetNativeTextureID()
		/// </summary>
		protected RMethod r_MGetNativeTextureID;
		public virtual RMethod RMGetNativeTextureID
		{
			get
			{
				if(r_MGetNativeTextureID == null)
				{
					r_MGetNativeTextureID = new(this, "GetNativeTextureID", 0);
				}
				return r_MGetNativeTextureID;
			}
		}

		/// <summary>
		/// Void IncrementUpdateCount()
		/// </summary>
		protected RMethod r_MIncrementUpdateCount;
		public virtual RMethod RMIncrementUpdateCount
		{
			get
			{
				if(r_MIncrementUpdateCount == null)
				{
					r_MIncrementUpdateCount = new(this, "IncrementUpdateCount", 0);
				}
				return r_MIncrementUpdateCount;
			}
		}

		/// <summary>
		/// UInt64 GetPixelDataSize(Int32, Int32)
		/// </summary>
		protected RMethod r_MGetPixelDataSize_Int32_Int32;
		public virtual RMethod RMGetPixelDataSize_Int32_Int32
		{
			get
			{
				if(r_MGetPixelDataSize_Int32_Int32 == null)
				{
					r_MGetPixelDataSize_Int32_Int32 = new(this, "GetPixelDataSize", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetPixelDataSize_Int32_Int32;
			}
		}

		/// <summary>
		/// UInt64 GetPixelDataOffset(Int32, Int32)
		/// </summary>
		protected RMethod r_MGetPixelDataOffset_Int32_Int32;
		public virtual RMethod RMGetPixelDataOffset_Int32_Int32
		{
			get
			{
				if(r_MGetPixelDataOffset_Int32_Int32 == null)
				{
					r_MGetPixelDataOffset_Int32_Int32 = new(this, "GetPixelDataOffset", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetPixelDataOffset_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean ValidateFormat(UnityEngine.RenderTextureFormat)
		/// </summary>
		protected RMethod r_MValidateFormat_RenderTextureFormat;
		public virtual RMethod RMValidateFormat_RenderTextureFormat
		{
			get
			{
				if(r_MValidateFormat_RenderTextureFormat == null)
				{
					r_MValidateFormat_RenderTextureFormat = new(this, "ValidateFormat", 0, typeof(UnityEngine.RenderTextureFormat));
				}
				return r_MValidateFormat_RenderTextureFormat;
			}
		}

		/// <summary>
		/// Boolean ValidateFormat(UnityEngine.TextureFormat)
		/// </summary>
		protected RMethod r_MValidateFormat_TextureFormat;
		public virtual RMethod RMValidateFormat_TextureFormat
		{
			get
			{
				if(r_MValidateFormat_TextureFormat == null)
				{
					r_MValidateFormat_TextureFormat = new(this, "ValidateFormat", 0, typeof(UnityEngine.TextureFormat));
				}
				return r_MValidateFormat_TextureFormat;
			}
		}

		/// <summary>
		/// Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat, UnityEngine.Experimental.Rendering.FormatUsage)
		/// </summary>
		protected RMethod r_MValidateFormat_GraphicsFormat_FormatUsage;
		public virtual RMethod RMValidateFormat_GraphicsFormat_FormatUsage
		{
			get
			{
				if(r_MValidateFormat_GraphicsFormat_FormatUsage == null)
				{
					r_MValidateFormat_GraphicsFormat_FormatUsage = new(this, "ValidateFormat", 0, typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(UnityEngine.Experimental.Rendering.FormatUsage));
				}
				return r_MValidateFormat_GraphicsFormat_FormatUsage;
			}
		}

		/// <summary>
		/// UnityEngine.UnityException CreateNonReadableException(UnityEngine.Texture)
		/// </summary>
		protected RMethod r_MCreateNonReadableException_Texture;
		public virtual RMethod RMCreateNonReadableException_Texture
		{
			get
			{
				if(r_MCreateNonReadableException_Texture == null)
				{
					r_MCreateNonReadableException_Texture = new(this, "CreateNonReadableException", 0, typeof(UnityEngine.Texture));
				}
				return r_MCreateNonReadableException_Texture;
			}
		}

		/// <summary>
		/// UnityEngine.UnityException CreateNativeArrayLengthOverflowException()
		/// </summary>
		protected RMethod r_MCreateNativeArrayLengthOverflowException;
		public virtual RMethod RMCreateNativeArrayLengthOverflowException
		{
			get
			{
				if(r_MCreateNativeArrayLengthOverflowException == null)
				{
					r_MCreateNativeArrayLengthOverflowException = new(this, "CreateNativeArrayLengthOverflowException", 0);
				}
				return r_MCreateNativeArrayLengthOverflowException;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_MGetInstanceID;
		public virtual RMethod RMGetInstanceID
		{
			get
			{
				if(r_MGetInstanceID == null)
				{
					r_MGetInstanceID = new(this, "GetInstanceID", 0);
				}
				return r_MGetInstanceID;
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


        public virtual UnityEngine.Experimental.Rendering.GraphicsFormat GetColorFormat(System.Boolean @suppressWarnings)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@suppressWarnings};
            var ___result = RMGetColorFormat_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Experimental.Rendering.GraphicsFormat>(___result);
        }


        public virtual void SetColorFormat(UnityEngine.Experimental.Rendering.GraphicsFormat @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMSetColorFormat_GraphicsFormat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetIsPowerOfTwo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetIsPowerOfTwo.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static UnityEngine.RenderTexture GetActive()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetActive.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.RenderTexture>(___result);
        }


        public static void SetActive(UnityEngine.RenderTexture @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt};
            var ___result = RMSetActive_RenderTexture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.RenderBuffer GetColorBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetColorBuffer.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.RenderBuffer>(___result);
        }


        public virtual UnityEngine.RenderBuffer GetDepthBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDepthBuffer.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.RenderBuffer>(___result);
        }


        public virtual void SetMipMapCount(System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@count};
            var ___result = RMSetMipMapCount_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetShadowSamplingMode(UnityEngine.Rendering.ShadowSamplingMode @samplingMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@samplingMode};
            var ___result = RMSetShadowSamplingMode_ShadowSamplingMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IntPtr GetNativeDepthBufferPtr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNativeDepthBufferPtr.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public virtual void DiscardContents(System.Boolean @discardColor, System.Boolean @discardDepth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@discardColor, @discardDepth};
            var ___result = RMDiscardContents_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkRestoreExpected()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkRestoreExpected.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DiscardContents()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDiscardContents.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResolveAA()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResolveAA.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResolveAATo(UnityEngine.RenderTexture @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt};
            var ___result = RMResolveAATo_RenderTexture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResolveAntiAliasedSurface()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResolveAntiAliasedSurface.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResolveAntiAliasedSurface(UnityEngine.RenderTexture @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMResolveAntiAliasedSurface_RenderTexture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGlobalShaderProperty(System.String @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName};
            var ___result = RMSetGlobalShaderProperty_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Create()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreate.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRelease.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsCreated()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsCreated.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void GenerateMips()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGenerateMips.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ConvertToEquirect(UnityEngine.RenderTexture @equirect, Hvak.Editor.Refleaction.RUnityEngine.RCamera.RMonoOrStereoscopicEye @eye)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@equirect, @eye.Value};
            var ___result = RMConvertToEquirect_RenderTexture_MonoOrStereoscopicEye.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSRGBReadWrite(System.Boolean @srgb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@srgb};
            var ___result = RMSetSRGBReadWrite_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_Create(UnityEngine.RenderTexture @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt};
            var ___result = RMInternal_Create_RenderTexture.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean SupportsStencil(UnityEngine.RenderTexture @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rt};
            var ___result = RMSupportsStencil_RenderTexture.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void SetRenderTextureDescriptor(UnityEngine.RenderTextureDescriptor @desc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc};
            var ___result = RMSetRenderTextureDescriptor_RenderTextureDescriptor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.RenderTextureDescriptor GetDescriptor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDescriptor.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.RenderTextureDescriptor>(___result);
        }


        public static UnityEngine.RenderTexture GetTemporary_Internal(UnityEngine.RenderTextureDescriptor @desc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc};
            var ___result = RMGetTemporary_Internal_RenderTextureDescriptor.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.RenderTexture>(___result);
        }


        public static void ReleaseTemporary(UnityEngine.RenderTexture @temp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@temp};
            var ___result = RMReleaseTemporary_RenderTexture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initialize(System.Int32 @width, System.Int32 @height, System.Int32 @depth, UnityEngine.RenderTextureFormat @format, UnityEngine.RenderTextureReadWrite @readWrite, System.Int32 @mipCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depth, @format, @readWrite, @mipCount};
            var ___result = RMInitialize_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(System.Int32 @depthBits, UnityEngine.Experimental.Rendering.GraphicsFormat @colorFormat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@depthBits, @colorFormat};
            var ___result = RMGetDepthStencilFormatLegacy_Int32_GraphicsFormat.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Experimental.Rendering.GraphicsFormat>(___result);
        }


        public static void ValidateRenderTextureDesc(UnityEngine.RenderTextureDescriptor @desc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc};
            var ___result = RMValidateRenderTextureDesc_RenderTextureDescriptor.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.RenderTextureFormat @renderTextureFormat, UnityEngine.RenderTextureReadWrite @readWrite)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderTextureFormat, @readWrite};
            var ___result = RMGetCompatibleFormat_RenderTextureFormat_RenderTextureReadWrite.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Experimental.Rendering.GraphicsFormat>(___result);
        }


        public static UnityEngine.RenderTexture GetTemporary(UnityEngine.RenderTextureDescriptor @desc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc};
            var ___result = RMGetTemporary_RenderTextureDescriptor.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.RenderTexture>(___result);
        }


        public static UnityEngine.RenderTexture GetTemporaryImpl(System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat @colorFormat, System.Int32 @antiAliasing, UnityEngine.RenderTextureMemoryless @memorylessMode, UnityEngine.VRTextureUsage @vrUsage, System.Boolean @useDynamicScale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @colorFormat, @antiAliasing, @memorylessMode, @vrUsage, @useDynamicScale};
            var ___result = RMGetTemporaryImpl_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.RenderTexture>(___result);
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat @format, System.Int32 @antiAliasing, UnityEngine.RenderTextureMemoryless @memorylessMode, UnityEngine.VRTextureUsage @vrUsage, System.Boolean @useDynamicScale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @format, @antiAliasing, @memorylessMode, @vrUsage, @useDynamicScale};
            var ___result = RMGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.RenderTexture>(___result);
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat @format, System.Int32 @antiAliasing, UnityEngine.RenderTextureMemoryless @memorylessMode, UnityEngine.VRTextureUsage @vrUsage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @format, @antiAliasing, @memorylessMode, @vrUsage};
            var ___result = RMGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless_VRTextureUsage.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.RenderTexture>(___result);
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat @format, System.Int32 @antiAliasing, UnityEngine.RenderTextureMemoryless @memorylessMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @format, @antiAliasing, @memorylessMode};
            var ___result = RMGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32_RenderTextureMemoryless.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.RenderTexture>(___result);
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat @format, System.Int32 @antiAliasing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @format, @antiAliasing};
            var ___result = RMGetTemporary_Int32_Int32_Int32_GraphicsFormat_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.RenderTexture>(___result);
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @format};
            var ___result = RMGetTemporary_Int32_Int32_Int32_GraphicsFormat.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.RenderTexture>(___result);
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.RenderTextureFormat @format, UnityEngine.RenderTextureReadWrite @readWrite, System.Int32 @antiAliasing, UnityEngine.RenderTextureMemoryless @memorylessMode, UnityEngine.VRTextureUsage @vrUsage, System.Boolean @useDynamicScale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @format, @readWrite, @antiAliasing, @memorylessMode, @vrUsage, @useDynamicScale};
            var ___result = RMGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.RenderTexture>(___result);
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.RenderTextureFormat @format, UnityEngine.RenderTextureReadWrite @readWrite, System.Int32 @antiAliasing, UnityEngine.RenderTextureMemoryless @memorylessMode, UnityEngine.VRTextureUsage @vrUsage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @format, @readWrite, @antiAliasing, @memorylessMode, @vrUsage};
            var ___result = RMGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless_VRTextureUsage.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.RenderTexture>(___result);
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.RenderTextureFormat @format, UnityEngine.RenderTextureReadWrite @readWrite, System.Int32 @antiAliasing, UnityEngine.RenderTextureMemoryless @memorylessMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @format, @readWrite, @antiAliasing, @memorylessMode};
            var ___result = RMGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32_RenderTextureMemoryless.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.RenderTexture>(___result);
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.RenderTextureFormat @format, UnityEngine.RenderTextureReadWrite @readWrite, System.Int32 @antiAliasing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @format, @readWrite, @antiAliasing};
            var ___result = RMGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.RenderTexture>(___result);
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.RenderTextureFormat @format, UnityEngine.RenderTextureReadWrite @readWrite)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @format, @readWrite};
            var ___result = RMGetTemporary_Int32_Int32_Int32_RenderTextureFormat_RenderTextureReadWrite.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.RenderTexture>(___result);
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer, UnityEngine.RenderTextureFormat @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer, @format};
            var ___result = RMGetTemporary_Int32_Int32_Int32_RenderTextureFormat.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.RenderTexture>(___result);
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32 @width, System.Int32 @height, System.Int32 @depthBuffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @depthBuffer};
            var ___result = RMGetTemporary_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.RenderTexture>(___result);
        }


        public static UnityEngine.RenderTexture GetTemporary(System.Int32 @width, System.Int32 @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height};
            var ___result = RMGetTemporary_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.RenderTexture>(___result);
        }


        public virtual void SetBorderColor(UnityEngine.Color @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color};
            var ___result = RMSetBorderColor_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 GetTexelOffset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTexelOffset.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector2>(___result);
        }


        public virtual void GetColorBuffer_Injected(out UnityEngine.RenderBuffer @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetColorBuffer_Injected_Out_RenderBuffer.Invoke(___genericsType, ___parameters);
			@ret = ReflectionUtils.Convert<UnityEngine.RenderBuffer>(___parameters[0]);

            
        }


        public virtual void GetDepthBuffer_Injected(out UnityEngine.RenderBuffer @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetDepthBuffer_Injected_Out_RenderBuffer.Invoke(___genericsType, ___parameters);
			@ret = ReflectionUtils.Convert<UnityEngine.RenderBuffer>(___parameters[0]);

            
        }


        public virtual void SetRenderTextureDescriptor_Injected(ref UnityEngine.RenderTextureDescriptor @desc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc};
            var ___result = RMSetRenderTextureDescriptor_Injected_Ref_RenderTextureDescriptor.Invoke(___genericsType, ___parameters);
			@desc = ReflectionUtils.Convert<UnityEngine.RenderTextureDescriptor>(___parameters[0]);

            
        }


        public virtual void GetDescriptor_Injected(out UnityEngine.RenderTextureDescriptor @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMGetDescriptor_Injected_Out_RenderTextureDescriptor.Invoke(___genericsType, ___parameters);
			@ret = ReflectionUtils.Convert<UnityEngine.RenderTextureDescriptor>(___parameters[0]);

            
        }


        public static UnityEngine.RenderTexture GetTemporary_Internal_Injected(ref UnityEngine.RenderTextureDescriptor @desc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desc};
            var ___result = RMGetTemporary_Internal_Injected_Ref_RenderTextureDescriptor.Invoke(___genericsType, ___parameters);
			@desc = ReflectionUtils.Convert<UnityEngine.RenderTextureDescriptor>(___parameters[0]);

            return ReflectionUtils.Convert<UnityEngine.RenderTexture>(___result);
        }


        public virtual UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMget_graphicsFormat.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Experimental.Rendering.GraphicsFormat>(___result);
        }


        public virtual System.IntPtr GetNativeTexturePtr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNativeTexturePtr.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public virtual System.Int32 GetNativeTextureID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNativeTextureID.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void IncrementUpdateCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIncrementUpdateCount.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.UInt64 GetPixelDataSize(System.Int32 @mipLevel, System.Int32 @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mipLevel, @element};
            var ___result = RMGetPixelDataSize_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt64>(___result);
        }


        public virtual System.UInt64 GetPixelDataOffset(System.Int32 @mipLevel, System.Int32 @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mipLevel, @element};
            var ___result = RMGetPixelDataOffset_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt64>(___result);
        }


        public virtual System.Boolean ValidateFormat(UnityEngine.RenderTextureFormat @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMValidateFormat_RenderTextureFormat.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean ValidateFormat(UnityEngine.TextureFormat @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMValidateFormat_TextureFormat.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat @format, UnityEngine.Experimental.Rendering.FormatUsage @usage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @usage};
            var ___result = RMValidateFormat_GraphicsFormat_FormatUsage.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual UnityEngine.UnityException CreateNonReadableException(UnityEngine.Texture @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMCreateNonReadableException_Texture.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UnityException>(___result);
        }


        public virtual UnityEngine.UnityException CreateNativeArrayLengthOverflowException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateNativeArrayLengthOverflowException.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UnityException>(___result);
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInstanceID.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
