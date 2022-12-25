using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Texture2D
	/// </summary>
    public partial class RTexture2D : RMember //
    {

		/// <summary>
		/// System.Int32 streamingMipmapsPriorityMin
		/// </summary>
		protected static RField r_streamingMipmapsPriorityMin;
		public static RField RstreamingMipmapsPriorityMin
		{
			get
			{
				if(r_streamingMipmapsPriorityMin == null)
				{
					r_streamingMipmapsPriorityMin = new(typeof(UnityEngine.Texture2D), "streamingMipmapsPriorityMin");
					r_streamingMipmapsPriorityMin.SetBelong(null);
				}
				return r_streamingMipmapsPriorityMin;
			}
		}

		/// <summary>
		/// System.Int32 streamingMipmapsPriorityMax
		/// </summary>
		protected static RField r_streamingMipmapsPriorityMax;
		public static RField RstreamingMipmapsPriorityMax
		{
			get
			{
				if(r_streamingMipmapsPriorityMax == null)
				{
					r_streamingMipmapsPriorityMax = new(typeof(UnityEngine.Texture2D), "streamingMipmapsPriorityMax");
					r_streamingMipmapsPriorityMax.SetBelong(null);
				}
				return r_streamingMipmapsPriorityMax;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat format
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
		/// Boolean ignoreMipmapLimit
		/// </summary>
		protected RProperty r_ignoreMipmapLimit;
		public virtual RProperty RignoreMipmapLimit
		{
			get
			{
				if(r_ignoreMipmapLimit == null)
				{
					r_ignoreMipmapLimit = new(this, "ignoreMipmapLimit", -1);
					r_ignoreMipmapLimit.SetBelong(this.instance);
				}
				return r_ignoreMipmapLimit;
			}
		}

		/// <summary>
		/// System.String mipmapLimitGroup
		/// </summary>
		protected RProperty r_mipmapLimitGroup;
		public virtual RProperty RmipmapLimitGroup
		{
			get
			{
				if(r_mipmapLimitGroup == null)
				{
					r_mipmapLimitGroup = new(this, "mipmapLimitGroup", -1);
					r_mipmapLimitGroup.SetBelong(this.instance);
				}
				return r_mipmapLimitGroup;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D whiteTexture
		/// </summary>
		protected static RUnityEngine.RTexture2D r_whiteTexture;
		public static RUnityEngine.RTexture2D RwhiteTexture
		{
			get
			{
				if(r_whiteTexture == null)
				{
					r_whiteTexture = new(typeof(UnityEngine.Texture2D), "whiteTexture", -1);
					r_whiteTexture.SetBelong(null);
				}
				return r_whiteTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D blackTexture
		/// </summary>
		protected static RUnityEngine.RTexture2D r_blackTexture;
		public static RUnityEngine.RTexture2D RblackTexture
		{
			get
			{
				if(r_blackTexture == null)
				{
					r_blackTexture = new(typeof(UnityEngine.Texture2D), "blackTexture", -1);
					r_blackTexture.SetBelong(null);
				}
				return r_blackTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D redTexture
		/// </summary>
		protected static RUnityEngine.RTexture2D r_redTexture;
		public static RUnityEngine.RTexture2D RredTexture
		{
			get
			{
				if(r_redTexture == null)
				{
					r_redTexture = new(typeof(UnityEngine.Texture2D), "redTexture", -1);
					r_redTexture.SetBelong(null);
				}
				return r_redTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D grayTexture
		/// </summary>
		protected static RUnityEngine.RTexture2D r_grayTexture;
		public static RUnityEngine.RTexture2D RgrayTexture
		{
			get
			{
				if(r_grayTexture == null)
				{
					r_grayTexture = new(typeof(UnityEngine.Texture2D), "grayTexture", -1);
					r_grayTexture.SetBelong(null);
				}
				return r_grayTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D linearGrayTexture
		/// </summary>
		protected static RUnityEngine.RTexture2D r_linearGrayTexture;
		public static RUnityEngine.RTexture2D RlinearGrayTexture
		{
			get
			{
				if(r_linearGrayTexture == null)
				{
					r_linearGrayTexture = new(typeof(UnityEngine.Texture2D), "linearGrayTexture", -1);
					r_linearGrayTexture.SetBelong(null);
				}
				return r_linearGrayTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D normalTexture
		/// </summary>
		protected static RUnityEngine.RTexture2D r_normalTexture;
		public static RUnityEngine.RTexture2D RnormalTexture
		{
			get
			{
				if(r_normalTexture == null)
				{
					r_normalTexture = new(typeof(UnityEngine.Texture2D), "normalTexture", -1);
					r_normalTexture.SetBelong(null);
				}
				return r_normalTexture;
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
		/// Boolean vtOnly
		/// </summary>
		protected RProperty r_vtOnly;
		public virtual RProperty RvtOnly
		{
			get
			{
				if(r_vtOnly == null)
				{
					r_vtOnly = new(this, "vtOnly", -1);
					r_vtOnly.SetBelong(this.instance);
				}
				return r_vtOnly;
			}
		}

		/// <summary>
		/// Boolean isPreProcessed
		/// </summary>
		protected RProperty r_isPreProcessed;
		public virtual RProperty RisPreProcessed
		{
			get
			{
				if(r_isPreProcessed == null)
				{
					r_isPreProcessed = new(this, "isPreProcessed", -1);
					r_isPreProcessed.SetBelong(this.instance);
				}
				return r_isPreProcessed;
			}
		}

		/// <summary>
		/// Boolean streamingMipmaps
		/// </summary>
		protected RProperty r_streamingMipmaps;
		public virtual RProperty RstreamingMipmaps
		{
			get
			{
				if(r_streamingMipmaps == null)
				{
					r_streamingMipmaps = new(this, "streamingMipmaps", -1);
					r_streamingMipmaps.SetBelong(this.instance);
				}
				return r_streamingMipmaps;
			}
		}

		/// <summary>
		/// Int32 streamingMipmapsPriority
		/// </summary>
		protected RProperty r_streamingMipmapsPriority;
		public virtual RProperty RstreamingMipmapsPriority
		{
			get
			{
				if(r_streamingMipmapsPriority == null)
				{
					r_streamingMipmapsPriority = new(this, "streamingMipmapsPriority", -1);
					r_streamingMipmapsPriority.SetBelong(this.instance);
				}
				return r_streamingMipmapsPriority;
			}
		}

		/// <summary>
		/// Int32 requestedMipmapLevel
		/// </summary>
		protected RProperty r_requestedMipmapLevel;
		public virtual RProperty RrequestedMipmapLevel
		{
			get
			{
				if(r_requestedMipmapLevel == null)
				{
					r_requestedMipmapLevel = new(this, "requestedMipmapLevel", -1);
					r_requestedMipmapLevel.SetBelong(this.instance);
				}
				return r_requestedMipmapLevel;
			}
		}

		/// <summary>
		/// Int32 minimumMipmapLevel
		/// </summary>
		protected RProperty r_minimumMipmapLevel;
		public virtual RProperty RminimumMipmapLevel
		{
			get
			{
				if(r_minimumMipmapLevel == null)
				{
					r_minimumMipmapLevel = new(this, "minimumMipmapLevel", -1);
					r_minimumMipmapLevel.SetBelong(this.instance);
				}
				return r_minimumMipmapLevel;
			}
		}

		/// <summary>
		/// Boolean loadAllMips
		/// </summary>
		protected RProperty r_loadAllMips;
		public virtual RProperty RloadAllMips
		{
			get
			{
				if(r_loadAllMips == null)
				{
					r_loadAllMips = new(this, "loadAllMips", -1);
					r_loadAllMips.SetBelong(this.instance);
				}
				return r_loadAllMips;
			}
		}

		/// <summary>
		/// Int32 calculatedMipmapLevel
		/// </summary>
		protected RProperty r_calculatedMipmapLevel;
		public virtual RProperty RcalculatedMipmapLevel
		{
			get
			{
				if(r_calculatedMipmapLevel == null)
				{
					r_calculatedMipmapLevel = new(this, "calculatedMipmapLevel", -1);
					r_calculatedMipmapLevel.SetBelong(this.instance);
				}
				return r_calculatedMipmapLevel;
			}
		}

		/// <summary>
		/// Int32 desiredMipmapLevel
		/// </summary>
		protected RProperty r_desiredMipmapLevel;
		public virtual RProperty RdesiredMipmapLevel
		{
			get
			{
				if(r_desiredMipmapLevel == null)
				{
					r_desiredMipmapLevel = new(this, "desiredMipmapLevel", -1);
					r_desiredMipmapLevel.SetBelong(this.instance);
				}
				return r_desiredMipmapLevel;
			}
		}

		/// <summary>
		/// Int32 loadingMipmapLevel
		/// </summary>
		protected RProperty r_loadingMipmapLevel;
		public virtual RProperty RloadingMipmapLevel
		{
			get
			{
				if(r_loadingMipmapLevel == null)
				{
					r_loadingMipmapLevel = new(this, "loadingMipmapLevel", -1);
					r_loadingMipmapLevel.SetBelong(this.instance);
				}
				return r_loadingMipmapLevel;
			}
		}

		/// <summary>
		/// Int32 loadedMipmapLevel
		/// </summary>
		protected RProperty r_loadedMipmapLevel;
		public virtual RProperty RloadedMipmapLevel
		{
			get
			{
				if(r_loadedMipmapLevel == null)
				{
					r_loadedMipmapLevel = new(this, "loadedMipmapLevel", -1);
					r_loadedMipmapLevel.SetBelong(this.instance);
				}
				return r_loadedMipmapLevel;
			}
		}

		/// <summary>
		/// Boolean alphaIsTransparency
		/// </summary>
		protected RProperty r_alphaIsTransparency;
		public virtual RProperty RalphaIsTransparency
		{
			get
			{
				if(r_alphaIsTransparency == null)
				{
					r_alphaIsTransparency = new(this, "alphaIsTransparency", -1);
					r_alphaIsTransparency.SetBelong(this.instance);
				}
				return r_alphaIsTransparency;
			}
		}

		/// <summary>
		/// Single pixelsPerPoint
		/// </summary>
		protected RProperty r_pixelsPerPoint;
		public virtual RProperty RpixelsPerPoint
		{
			get
			{
				if(r_pixelsPerPoint == null)
				{
					r_pixelsPerPoint = new(this, "pixelsPerPoint", -1);
					r_pixelsPerPoint.SetBelong(this.instance);
				}
				return r_pixelsPerPoint;
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
		/// Void Compress(Boolean)
		/// </summary>
		protected RMethod r_RCompress_Boolean;
		public virtual RMethod RCompress_Boolean
		{
			get
			{
				if(r_RCompress_Boolean == null)
				{
					r_RCompress_Boolean = new(this, "Compress", 0, typeof(System.Boolean));
					r_RCompress_Boolean.SetBelong(this.instance);
				}
				return r_RCompress_Boolean;
			}
		}

		/// <summary>
		/// Boolean Internal_CreateImpl(UnityEngine.Texture2D, Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, UnityEngine.Experimental.Rendering.TextureCreationFlags, IntPtr, System.String)
		/// </summary>
		protected static RMethod r_RInternal_CreateImpl_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String;
		public static RMethod RInternal_CreateImpl_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String
		{
			get
			{
				if(r_RInternal_CreateImpl_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String == null)
				{
					r_RInternal_CreateImpl_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String = new(typeof(UnityEngine.Texture2D), "Internal_CreateImpl", 0, typeof(UnityEngine.Texture2D), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(UnityEngine.Experimental.Rendering.TextureCreationFlags), typeof(System.IntPtr), typeof(System.String));
					r_RInternal_CreateImpl_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String.SetBelong(null);
				}
				return r_RInternal_CreateImpl_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String;
			}
		}

		/// <summary>
		/// Void Internal_Create(UnityEngine.Texture2D, Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, UnityEngine.Experimental.Rendering.TextureCreationFlags, IntPtr, System.String)
		/// </summary>
		protected static RMethod r_RInternal_Create_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String;
		public static RMethod RInternal_Create_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String
		{
			get
			{
				if(r_RInternal_Create_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String == null)
				{
					r_RInternal_Create_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String = new(typeof(UnityEngine.Texture2D), "Internal_Create", 0, typeof(UnityEngine.Texture2D), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(UnityEngine.Experimental.Rendering.TextureCreationFlags), typeof(System.IntPtr), typeof(System.String));
					r_RInternal_Create_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String.SetBelong(null);
				}
				return r_RInternal_Create_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String;
			}
		}

		/// <summary>
		/// Void ApplyImpl(Boolean, Boolean)
		/// </summary>
		protected RMethod r_RApplyImpl_Boolean_Boolean;
		public virtual RMethod RApplyImpl_Boolean_Boolean
		{
			get
			{
				if(r_RApplyImpl_Boolean_Boolean == null)
				{
					r_RApplyImpl_Boolean_Boolean = new(this, "ApplyImpl", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_RApplyImpl_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RApplyImpl_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Boolean ReinitializeImpl(Int32, Int32)
		/// </summary>
		protected RMethod r_RReinitializeImpl_Int32_Int32;
		public virtual RMethod RReinitializeImpl_Int32_Int32
		{
			get
			{
				if(r_RReinitializeImpl_Int32_Int32 == null)
				{
					r_RReinitializeImpl_Int32_Int32 = new(this, "ReinitializeImpl", 0, typeof(System.Int32), typeof(System.Int32));
					r_RReinitializeImpl_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReinitializeImpl_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetPixelImpl(Int32, Int32, Int32, Int32, UnityEngine.Color)
		/// </summary>
		protected RMethod r_RSetPixelImpl_Int32_Int32_Int32_Int32_Color;
		public virtual RMethod RSetPixelImpl_Int32_Int32_Int32_Int32_Color
		{
			get
			{
				if(r_RSetPixelImpl_Int32_Int32_Int32_Int32_Color == null)
				{
					r_RSetPixelImpl_Int32_Int32_Int32_Int32_Color = new(this, "SetPixelImpl", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color));
					r_RSetPixelImpl_Int32_Int32_Int32_Int32_Color.SetBelong(this.instance);
				}
				return r_RSetPixelImpl_Int32_Int32_Int32_Int32_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetPixelImpl(Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RGetPixelImpl_Int32_Int32_Int32_Int32;
		public virtual RMethod RGetPixelImpl_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RGetPixelImpl_Int32_Int32_Int32_Int32 == null)
				{
					r_RGetPixelImpl_Int32_Int32_Int32_Int32 = new(this, "GetPixelImpl", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RGetPixelImpl_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetPixelImpl_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetPixelBilinearImpl(Int32, Int32, Single, Single)
		/// </summary>
		protected RMethod r_RGetPixelBilinearImpl_Int32_Int32_Single_Single;
		public virtual RMethod RGetPixelBilinearImpl_Int32_Int32_Single_Single
		{
			get
			{
				if(r_RGetPixelBilinearImpl_Int32_Int32_Single_Single == null)
				{
					r_RGetPixelBilinearImpl_Int32_Int32_Single_Single = new(this, "GetPixelBilinearImpl", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Single), typeof(System.Single));
					r_RGetPixelBilinearImpl_Int32_Int32_Single_Single.SetBelong(this.instance);
				}
				return r_RGetPixelBilinearImpl_Int32_Int32_Single_Single;
			}
		}

		/// <summary>
		/// Boolean ReinitializeWithFormatImpl(Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, Boolean)
		/// </summary>
		protected RMethod r_RReinitializeWithFormatImpl_Int32_Int32_GraphicsFormat_Boolean;
		public virtual RMethod RReinitializeWithFormatImpl_Int32_Int32_GraphicsFormat_Boolean
		{
			get
			{
				if(r_RReinitializeWithFormatImpl_Int32_Int32_GraphicsFormat_Boolean == null)
				{
					r_RReinitializeWithFormatImpl_Int32_Int32_GraphicsFormat_Boolean = new(this, "ReinitializeWithFormatImpl", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Boolean));
					r_RReinitializeWithFormatImpl_Int32_Int32_GraphicsFormat_Boolean.SetBelong(this.instance);
				}
				return r_RReinitializeWithFormatImpl_Int32_Int32_GraphicsFormat_Boolean;
			}
		}

		/// <summary>
		/// Boolean ReinitializeWithTextureFormatImpl(Int32, Int32, UnityEngine.TextureFormat, Boolean)
		/// </summary>
		protected RMethod r_RReinitializeWithTextureFormatImpl_Int32_Int32_TextureFormat_Boolean;
		public virtual RMethod RReinitializeWithTextureFormatImpl_Int32_Int32_TextureFormat_Boolean
		{
			get
			{
				if(r_RReinitializeWithTextureFormatImpl_Int32_Int32_TextureFormat_Boolean == null)
				{
					r_RReinitializeWithTextureFormatImpl_Int32_Int32_TextureFormat_Boolean = new(this, "ReinitializeWithTextureFormatImpl", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextureFormat), typeof(System.Boolean));
					r_RReinitializeWithTextureFormatImpl_Int32_Int32_TextureFormat_Boolean.SetBelong(this.instance);
				}
				return r_RReinitializeWithTextureFormatImpl_Int32_Int32_TextureFormat_Boolean;
			}
		}

		/// <summary>
		/// Void ReadPixelsImpl(UnityEngine.Rect, Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_RReadPixelsImpl_Rect_Int32_Int32_Boolean;
		public virtual RMethod RReadPixelsImpl_Rect_Int32_Int32_Boolean
		{
			get
			{
				if(r_RReadPixelsImpl_Rect_Int32_Int32_Boolean == null)
				{
					r_RReadPixelsImpl_Rect_Int32_Int32_Boolean = new(this, "ReadPixelsImpl", 0, typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_RReadPixelsImpl_Rect_Int32_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RReadPixelsImpl_Rect_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetPixelsImpl(Int32, Int32, Int32, Int32, UnityEngine.Color[], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetPixelsImpl_Int32_Int32_Int32_Int32_ColorArray_Int32_Int32;
		public virtual RMethod RSetPixelsImpl_Int32_Int32_Int32_Int32_ColorArray_Int32_Int32
		{
			get
			{
				if(r_RSetPixelsImpl_Int32_Int32_Int32_Int32_ColorArray_Int32_Int32 == null)
				{
					r_RSetPixelsImpl_Int32_Int32_Int32_Int32_ColorArray_Int32_Int32 = new(this, "SetPixelsImpl", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RSetPixelsImpl_Int32_Int32_Int32_Int32_ColorArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetPixelsImpl_Int32_Int32_Int32_Int32_ColorArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean LoadRawTextureDataImpl(IntPtr, UInt64)
		/// </summary>
		protected RMethod r_RLoadRawTextureDataImpl_IntPtr_UInt64;
		public virtual RMethod RLoadRawTextureDataImpl_IntPtr_UInt64
		{
			get
			{
				if(r_RLoadRawTextureDataImpl_IntPtr_UInt64 == null)
				{
					r_RLoadRawTextureDataImpl_IntPtr_UInt64 = new(this, "LoadRawTextureDataImpl", 0, typeof(System.IntPtr), typeof(System.UInt64));
					r_RLoadRawTextureDataImpl_IntPtr_UInt64.SetBelong(this.instance);
				}
				return r_RLoadRawTextureDataImpl_IntPtr_UInt64;
			}
		}

		/// <summary>
		/// Boolean LoadRawTextureDataImplArray(Byte[])
		/// </summary>
		protected RMethod r_RLoadRawTextureDataImplArray_ByteArray;
		public virtual RMethod RLoadRawTextureDataImplArray_ByteArray
		{
			get
			{
				if(r_RLoadRawTextureDataImplArray_ByteArray == null)
				{
					r_RLoadRawTextureDataImplArray_ByteArray = new(this, "LoadRawTextureDataImplArray", 0, typeof(System.Byte).MakeArrayType());
					r_RLoadRawTextureDataImplArray_ByteArray.SetBelong(this.instance);
				}
				return r_RLoadRawTextureDataImplArray_ByteArray;
			}
		}

		/// <summary>
		/// Boolean SetPixelDataImplArray(System.Array, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetPixelDataImplArray_Array_Int32_Int32_Int32_Int32;
		public virtual RMethod RSetPixelDataImplArray_Array_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RSetPixelDataImplArray_Array_Int32_Int32_Int32_Int32 == null)
				{
					r_RSetPixelDataImplArray_Array_Int32_Int32_Int32_Int32 = new(this, "SetPixelDataImplArray", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RSetPixelDataImplArray_Array_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetPixelDataImplArray_Array_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean SetPixelDataImpl(IntPtr, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32;
		public virtual RMethod RSetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RSetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32 == null)
				{
					r_RSetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32 = new(this, "SetPixelDataImpl", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RSetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// IntPtr GetWritableImageData(Int32)
		/// </summary>
		protected RMethod r_RGetWritableImageData_Int32;
		public virtual RMethod RGetWritableImageData_Int32
		{
			get
			{
				if(r_RGetWritableImageData_Int32 == null)
				{
					r_RGetWritableImageData_Int32 = new(this, "GetWritableImageData", 0, typeof(System.Int32));
					r_RGetWritableImageData_Int32.SetBelong(this.instance);
				}
				return r_RGetWritableImageData_Int32;
			}
		}

		/// <summary>
		/// UInt64 GetRawImageDataSize()
		/// </summary>
		protected RMethod r_RGetRawImageDataSize;
		public virtual RMethod RGetRawImageDataSize
		{
			get
			{
				if(r_RGetRawImageDataSize == null)
				{
					r_RGetRawImageDataSize = new(this, "GetRawImageDataSize", 0);
					r_RGetRawImageDataSize.SetBelong(this.instance);
				}
				return r_RGetRawImageDataSize;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetSafetyHandle(UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_RGetSafetyHandle_Texture2D;
		public static RMethod RGetSafetyHandle_Texture2D
		{
			get
			{
				if(r_RGetSafetyHandle_Texture2D == null)
				{
					r_RGetSafetyHandle_Texture2D = new(typeof(UnityEngine.Texture2D), "GetSafetyHandle", 0, typeof(UnityEngine.Texture2D));
					r_RGetSafetyHandle_Texture2D.SetBelong(null);
				}
				return r_RGetSafetyHandle_Texture2D;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetSafetyHandleForSlice(Int32)
		/// </summary>
		protected RMethod r_RGetSafetyHandleForSlice_Int32;
		public virtual RMethod RGetSafetyHandleForSlice_Int32
		{
			get
			{
				if(r_RGetSafetyHandleForSlice_Int32 == null)
				{
					r_RGetSafetyHandleForSlice_Int32 = new(this, "GetSafetyHandleForSlice", 0, typeof(System.Int32));
					r_RGetSafetyHandleForSlice_Int32.SetBelong(this.instance);
				}
				return r_RGetSafetyHandleForSlice_Int32;
			}
		}

		/// <summary>
		/// Void GenerateAtlasImpl(UnityEngine.Vector2[], Int32, Int32, UnityEngine.Rect[])
		/// </summary>
		protected static RMethod r_RGenerateAtlasImpl_Vector2Array_Int32_Int32_RectArray;
		public static RMethod RGenerateAtlasImpl_Vector2Array_Int32_Int32_RectArray
		{
			get
			{
				if(r_RGenerateAtlasImpl_Vector2Array_Int32_Int32_RectArray == null)
				{
					r_RGenerateAtlasImpl_Vector2Array_Int32_Int32_RectArray = new(typeof(UnityEngine.Texture2D), "GenerateAtlasImpl", 0, typeof(UnityEngine.Vector2).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rect).MakeArrayType());
					r_RGenerateAtlasImpl_Vector2Array_Int32_Int32_RectArray.SetBelong(null);
				}
				return r_RGenerateAtlasImpl_Vector2Array_Int32_Int32_RectArray;
			}
		}

		/// <summary>
		/// Void ClearRequestedMipmapLevel()
		/// </summary>
		protected RMethod r_RClearRequestedMipmapLevel;
		public virtual RMethod RClearRequestedMipmapLevel
		{
			get
			{
				if(r_RClearRequestedMipmapLevel == null)
				{
					r_RClearRequestedMipmapLevel = new(this, "ClearRequestedMipmapLevel", 0);
					r_RClearRequestedMipmapLevel.SetBelong(this.instance);
				}
				return r_RClearRequestedMipmapLevel;
			}
		}

		/// <summary>
		/// Boolean IsRequestedMipmapLevelLoaded()
		/// </summary>
		protected RMethod r_RIsRequestedMipmapLevelLoaded;
		public virtual RMethod RIsRequestedMipmapLevelLoaded
		{
			get
			{
				if(r_RIsRequestedMipmapLevelLoaded == null)
				{
					r_RIsRequestedMipmapLevelLoaded = new(this, "IsRequestedMipmapLevelLoaded", 0);
					r_RIsRequestedMipmapLevelLoaded.SetBelong(this.instance);
				}
				return r_RIsRequestedMipmapLevelLoaded;
			}
		}

		/// <summary>
		/// Void ClearMinimumMipmapLevel()
		/// </summary>
		protected RMethod r_RClearMinimumMipmapLevel;
		public virtual RMethod RClearMinimumMipmapLevel
		{
			get
			{
				if(r_RClearMinimumMipmapLevel == null)
				{
					r_RClearMinimumMipmapLevel = new(this, "ClearMinimumMipmapLevel", 0);
					r_RClearMinimumMipmapLevel.SetBelong(this.instance);
				}
				return r_RClearMinimumMipmapLevel;
			}
		}

		/// <summary>
		/// Void UpdateExternalTexture(IntPtr)
		/// </summary>
		protected RMethod r_RUpdateExternalTexture_IntPtr;
		public virtual RMethod RUpdateExternalTexture_IntPtr
		{
			get
			{
				if(r_RUpdateExternalTexture_IntPtr == null)
				{
					r_RUpdateExternalTexture_IntPtr = new(this, "UpdateExternalTexture", 0, typeof(System.IntPtr));
					r_RUpdateExternalTexture_IntPtr.SetBelong(this.instance);
				}
				return r_RUpdateExternalTexture_IntPtr;
			}
		}

		/// <summary>
		/// Void SetAllPixels32(UnityEngine.Color32[], Int32)
		/// </summary>
		protected RMethod r_RSetAllPixels32_Color32Array_Int32;
		public virtual RMethod RSetAllPixels32_Color32Array_Int32
		{
			get
			{
				if(r_RSetAllPixels32_Color32Array_Int32 == null)
				{
					r_RSetAllPixels32_Color32Array_Int32 = new(this, "SetAllPixels32", 0, typeof(UnityEngine.Color32).MakeArrayType(), typeof(System.Int32));
					r_RSetAllPixels32_Color32Array_Int32.SetBelong(this.instance);
				}
				return r_RSetAllPixels32_Color32Array_Int32;
			}
		}

		/// <summary>
		/// Void SetBlockOfPixels32(Int32, Int32, Int32, Int32, UnityEngine.Color32[], Int32)
		/// </summary>
		protected RMethod r_RSetBlockOfPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32;
		public virtual RMethod RSetBlockOfPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32
		{
			get
			{
				if(r_RSetBlockOfPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32 == null)
				{
					r_RSetBlockOfPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32 = new(this, "SetBlockOfPixels32", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color32).MakeArrayType(), typeof(System.Int32));
					r_RSetBlockOfPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32.SetBelong(this.instance);
				}
				return r_RSetBlockOfPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32;
			}
		}

		/// <summary>
		/// Byte[] GetRawTextureData()
		/// </summary>
		protected RMethod r_RGetRawTextureData;
		public virtual RMethod RGetRawTextureData
		{
			get
			{
				if(r_RGetRawTextureData == null)
				{
					r_RGetRawTextureData = new(this, "GetRawTextureData", 0);
					r_RGetRawTextureData.SetBelong(this.instance);
				}
				return r_RGetRawTextureData;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] GetPixels(Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RGetPixels_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RGetPixels_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RGetPixels_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_RGetPixels_Int32_Int32_Int32_Int32_Int32 = new(this, "GetPixels", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RGetPixels_Int32_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetPixels_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] GetPixels(Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RGetPixels_Int32_Int32_Int32_Int32;
		public virtual RMethod RGetPixels_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RGetPixels_Int32_Int32_Int32_Int32 == null)
				{
					r_RGetPixels_Int32_Int32_Int32_Int32 = new(this, "GetPixels", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RGetPixels_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetPixels_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color32[] GetPixels32(Int32)
		/// </summary>
		protected RMethod r_RGetPixels32_Int32;
		public virtual RMethod RGetPixels32_Int32
		{
			get
			{
				if(r_RGetPixels32_Int32 == null)
				{
					r_RGetPixels32_Int32 = new(this, "GetPixels32", 0, typeof(System.Int32));
					r_RGetPixels32_Int32.SetBelong(this.instance);
				}
				return r_RGetPixels32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color32[] GetPixels32()
		/// </summary>
		protected RMethod r_RGetPixels32;
		public virtual RMethod RGetPixels32
		{
			get
			{
				if(r_RGetPixels32 == null)
				{
					r_RGetPixels32 = new(this, "GetPixels32", 0);
					r_RGetPixels32.SetBelong(this.instance);
				}
				return r_RGetPixels32;
			}
		}

		/// <summary>
		/// UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[], Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_RPackTextures_Texture2DArray_Int32_Int32_Boolean;
		public virtual RMethod RPackTextures_Texture2DArray_Int32_Int32_Boolean
		{
			get
			{
				if(r_RPackTextures_Texture2DArray_Int32_Int32_Boolean == null)
				{
					r_RPackTextures_Texture2DArray_Int32_Int32_Boolean = new(this, "PackTextures", 0, typeof(UnityEngine.Texture2D).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_RPackTextures_Texture2DArray_Int32_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RPackTextures_Texture2DArray_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[], Int32, Int32)
		/// </summary>
		protected RMethod r_RPackTextures_Texture2DArray_Int32_Int32;
		public virtual RMethod RPackTextures_Texture2DArray_Int32_Int32
		{
			get
			{
				if(r_RPackTextures_Texture2DArray_Int32_Int32 == null)
				{
					r_RPackTextures_Texture2DArray_Int32_Int32 = new(this, "PackTextures", 0, typeof(UnityEngine.Texture2D).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RPackTextures_Texture2DArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RPackTextures_Texture2DArray_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[], Int32)
		/// </summary>
		protected RMethod r_RPackTextures_Texture2DArray_Int32;
		public virtual RMethod RPackTextures_Texture2DArray_Int32
		{
			get
			{
				if(r_RPackTextures_Texture2DArray_Int32 == null)
				{
					r_RPackTextures_Texture2DArray_Int32 = new(this, "PackTextures", 0, typeof(UnityEngine.Texture2D).MakeArrayType(), typeof(System.Int32));
					r_RPackTextures_Texture2DArray_Int32.SetBelong(this.instance);
				}
				return r_RPackTextures_Texture2DArray_Int32;
			}
		}

		/// <summary>
		/// Boolean ValidateFormat(UnityEngine.TextureFormat, Int32, Int32)
		/// </summary>
		protected RMethod r_RValidateFormat_TextureFormat_Int32_Int32;
		public virtual RMethod RValidateFormat_TextureFormat_Int32_Int32
		{
			get
			{
				if(r_RValidateFormat_TextureFormat_Int32_Int32 == null)
				{
					r_RValidateFormat_TextureFormat_Int32_Int32 = new(this, "ValidateFormat", 0, typeof(UnityEngine.TextureFormat), typeof(System.Int32), typeof(System.Int32));
					r_RValidateFormat_TextureFormat_Int32_Int32.SetBelong(this.instance);
				}
				return r_RValidateFormat_TextureFormat_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat, Int32, Int32)
		/// </summary>
		protected RMethod r_RValidateFormat_GraphicsFormat_Int32_Int32;
		public virtual RMethod RValidateFormat_GraphicsFormat_Int32_Int32
		{
			get
			{
				if(r_RValidateFormat_GraphicsFormat_Int32_Int32 == null)
				{
					r_RValidateFormat_GraphicsFormat_Int32_Int32 = new(this, "ValidateFormat", 0, typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32), typeof(System.Int32));
					r_RValidateFormat_GraphicsFormat_Int32_Int32.SetBelong(this.instance);
				}
				return r_RValidateFormat_GraphicsFormat_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D CreateExternalTexture(Int32, Int32, UnityEngine.TextureFormat, Boolean, Boolean, IntPtr)
		/// </summary>
		protected static RMethod r_RCreateExternalTexture_Int32_Int32_TextureFormat_Boolean_Boolean_IntPtr;
		public static RMethod RCreateExternalTexture_Int32_Int32_TextureFormat_Boolean_Boolean_IntPtr
		{
			get
			{
				if(r_RCreateExternalTexture_Int32_Int32_TextureFormat_Boolean_Boolean_IntPtr == null)
				{
					r_RCreateExternalTexture_Int32_Int32_TextureFormat_Boolean_Boolean_IntPtr = new(typeof(UnityEngine.Texture2D), "CreateExternalTexture", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextureFormat), typeof(System.Boolean), typeof(System.Boolean), typeof(System.IntPtr));
					r_RCreateExternalTexture_Int32_Int32_TextureFormat_Boolean_Boolean_IntPtr.SetBelong(null);
				}
				return r_RCreateExternalTexture_Int32_Int32_TextureFormat_Boolean_Boolean_IntPtr;
			}
		}

		/// <summary>
		/// Void SetPixel(Int32, Int32, UnityEngine.Color)
		/// </summary>
		protected RMethod r_RSetPixel_Int32_Int32_Color;
		public virtual RMethod RSetPixel_Int32_Int32_Color
		{
			get
			{
				if(r_RSetPixel_Int32_Int32_Color == null)
				{
					r_RSetPixel_Int32_Int32_Color = new(this, "SetPixel", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color));
					r_RSetPixel_Int32_Int32_Color.SetBelong(this.instance);
				}
				return r_RSetPixel_Int32_Int32_Color;
			}
		}

		/// <summary>
		/// Void SetPixel(Int32, Int32, UnityEngine.Color, Int32)
		/// </summary>
		protected RMethod r_RSetPixel_Int32_Int32_Color_Int32;
		public virtual RMethod RSetPixel_Int32_Int32_Color_Int32
		{
			get
			{
				if(r_RSetPixel_Int32_Int32_Color_Int32 == null)
				{
					r_RSetPixel_Int32_Int32_Color_Int32 = new(this, "SetPixel", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color), typeof(System.Int32));
					r_RSetPixel_Int32_Int32_Color_Int32.SetBelong(this.instance);
				}
				return r_RSetPixel_Int32_Int32_Color_Int32;
			}
		}

		/// <summary>
		/// Void SetPixels(Int32, Int32, Int32, Int32, UnityEngine.Color[], Int32)
		/// </summary>
		protected RMethod r_RSetPixels_Int32_Int32_Int32_Int32_ColorArray_Int32;
		public virtual RMethod RSetPixels_Int32_Int32_Int32_Int32_ColorArray_Int32
		{
			get
			{
				if(r_RSetPixels_Int32_Int32_Int32_Int32_ColorArray_Int32 == null)
				{
					r_RSetPixels_Int32_Int32_Int32_Int32_ColorArray_Int32 = new(this, "SetPixels", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color).MakeArrayType(), typeof(System.Int32));
					r_RSetPixels_Int32_Int32_Int32_Int32_ColorArray_Int32.SetBelong(this.instance);
				}
				return r_RSetPixels_Int32_Int32_Int32_Int32_ColorArray_Int32;
			}
		}

		/// <summary>
		/// Void SetPixels(Int32, Int32, Int32, Int32, UnityEngine.Color[])
		/// </summary>
		protected RMethod r_RSetPixels_Int32_Int32_Int32_Int32_ColorArray;
		public virtual RMethod RSetPixels_Int32_Int32_Int32_Int32_ColorArray
		{
			get
			{
				if(r_RSetPixels_Int32_Int32_Int32_Int32_ColorArray == null)
				{
					r_RSetPixels_Int32_Int32_Int32_Int32_ColorArray = new(this, "SetPixels", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color).MakeArrayType());
					r_RSetPixels_Int32_Int32_Int32_Int32_ColorArray.SetBelong(this.instance);
				}
				return r_RSetPixels_Int32_Int32_Int32_Int32_ColorArray;
			}
		}

		/// <summary>
		/// Void SetPixels(UnityEngine.Color[], Int32)
		/// </summary>
		protected RMethod r_RSetPixels_ColorArray_Int32;
		public virtual RMethod RSetPixels_ColorArray_Int32
		{
			get
			{
				if(r_RSetPixels_ColorArray_Int32 == null)
				{
					r_RSetPixels_ColorArray_Int32 = new(this, "SetPixels", 0, typeof(UnityEngine.Color).MakeArrayType(), typeof(System.Int32));
					r_RSetPixels_ColorArray_Int32.SetBelong(this.instance);
				}
				return r_RSetPixels_ColorArray_Int32;
			}
		}

		/// <summary>
		/// Void SetPixels(UnityEngine.Color[])
		/// </summary>
		protected RMethod r_RSetPixels_ColorArray;
		public virtual RMethod RSetPixels_ColorArray
		{
			get
			{
				if(r_RSetPixels_ColorArray == null)
				{
					r_RSetPixels_ColorArray = new(this, "SetPixels", 0, typeof(UnityEngine.Color).MakeArrayType());
					r_RSetPixels_ColorArray.SetBelong(this.instance);
				}
				return r_RSetPixels_ColorArray;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetPixel(Int32, Int32)
		/// </summary>
		protected RMethod r_RGetPixel_Int32_Int32;
		public virtual RMethod RGetPixel_Int32_Int32
		{
			get
			{
				if(r_RGetPixel_Int32_Int32 == null)
				{
					r_RGetPixel_Int32_Int32 = new(this, "GetPixel", 0, typeof(System.Int32), typeof(System.Int32));
					r_RGetPixel_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetPixel_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetPixel(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RGetPixel_Int32_Int32_Int32;
		public virtual RMethod RGetPixel_Int32_Int32_Int32
		{
			get
			{
				if(r_RGetPixel_Int32_Int32_Int32 == null)
				{
					r_RGetPixel_Int32_Int32_Int32 = new(this, "GetPixel", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RGetPixel_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetPixel_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetPixelBilinear(Single, Single)
		/// </summary>
		protected RMethod r_RGetPixelBilinear_Single_Single;
		public virtual RMethod RGetPixelBilinear_Single_Single
		{
			get
			{
				if(r_RGetPixelBilinear_Single_Single == null)
				{
					r_RGetPixelBilinear_Single_Single = new(this, "GetPixelBilinear", 0, typeof(System.Single), typeof(System.Single));
					r_RGetPixelBilinear_Single_Single.SetBelong(this.instance);
				}
				return r_RGetPixelBilinear_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetPixelBilinear(Single, Single, Int32)
		/// </summary>
		protected RMethod r_RGetPixelBilinear_Single_Single_Int32;
		public virtual RMethod RGetPixelBilinear_Single_Single_Int32
		{
			get
			{
				if(r_RGetPixelBilinear_Single_Single_Int32 == null)
				{
					r_RGetPixelBilinear_Single_Single_Int32 = new(this, "GetPixelBilinear", 0, typeof(System.Single), typeof(System.Single), typeof(System.Int32));
					r_RGetPixelBilinear_Single_Single_Int32.SetBelong(this.instance);
				}
				return r_RGetPixelBilinear_Single_Single_Int32;
			}
		}

		/// <summary>
		/// Void LoadRawTextureData(IntPtr, Int32)
		/// </summary>
		protected RMethod r_RLoadRawTextureData_IntPtr_Int32;
		public virtual RMethod RLoadRawTextureData_IntPtr_Int32
		{
			get
			{
				if(r_RLoadRawTextureData_IntPtr_Int32 == null)
				{
					r_RLoadRawTextureData_IntPtr_Int32 = new(this, "LoadRawTextureData", 0, typeof(System.IntPtr), typeof(System.Int32));
					r_RLoadRawTextureData_IntPtr_Int32.SetBelong(this.instance);
				}
				return r_RLoadRawTextureData_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Void LoadRawTextureData(Byte[])
		/// </summary>
		protected RMethod r_RLoadRawTextureData_ByteArray;
		public virtual RMethod RLoadRawTextureData_ByteArray
		{
			get
			{
				if(r_RLoadRawTextureData_ByteArray == null)
				{
					r_RLoadRawTextureData_ByteArray = new(this, "LoadRawTextureData", 0, typeof(System.Byte).MakeArrayType());
					r_RLoadRawTextureData_ByteArray.SetBelong(this.instance);
				}
				return r_RLoadRawTextureData_ByteArray;
			}
		}

		/// <summary>
		/// Void LoadRawTextureData[T](Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_RLoadRawTextureData_GT_NativeArray_d_T_p_;
		public virtual RMethod RLoadRawTextureData_GT_NativeArray_d_T_p_
		{
			get
			{
				if(r_RLoadRawTextureData_GT_NativeArray_d_T_p_ == null)
				{
					r_RLoadRawTextureData_GT_NativeArray_d_T_p_ = new(this, "LoadRawTextureData", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RLoadRawTextureData_GT_NativeArray_d_T_p_.SetBelong(this.instance);
				}
				return r_RLoadRawTextureData_GT_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetPixelData[T](T[], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetPixelData_GT_TArray_Int32_Int32;
		public virtual RMethod RSetPixelData_GT_TArray_Int32_Int32
		{
			get
			{
				if(r_RSetPixelData_GT_TArray_Int32_Int32 == null)
				{
					r_RSetPixelData_GT_TArray_Int32_Int32 = new(this, "SetPixelData", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RSetPixelData_GT_TArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetPixelData_GT_TArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetPixelData[T](Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetPixelData_GT_NativeArray_d_T_p__Int32_Int32;
		public virtual RMethod RSetPixelData_GT_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_RSetPixelData_GT_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_RSetPixelData_GT_NativeArray_d_T_p__Int32_Int32 = new(this, "SetPixelData", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
					r_RSetPixelData_GT_NativeArray_d_T_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetPixelData_GT_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[T] GetPixelData[T](Int32)
		/// </summary>
		protected RMethod r_RGetPixelData_GT_Int32;
		public virtual RMethod RGetPixelData_GT_Int32
		{
			get
			{
				if(r_RGetPixelData_GT_Int32 == null)
				{
					r_RGetPixelData_GT_Int32 = new(this, "GetPixelData", 1, typeof(System.Int32));
					r_RGetPixelData_GT_Int32.SetBelong(this.instance);
				}
				return r_RGetPixelData_GT_Int32;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[T] GetRawTextureData[T]()
		/// </summary>
		protected RMethod r_RGetRawTextureData_GT;
		public virtual RMethod RGetRawTextureData_GT
		{
			get
			{
				if(r_RGetRawTextureData_GT == null)
				{
					r_RGetRawTextureData_GT = new(this, "GetRawTextureData", 1);
					r_RGetRawTextureData_GT.SetBelong(this.instance);
				}
				return r_RGetRawTextureData_GT;
			}
		}

		/// <summary>
		/// Void Apply(Boolean, Boolean)
		/// </summary>
		protected RMethod r_RApply_Boolean_Boolean;
		public virtual RMethod RApply_Boolean_Boolean
		{
			get
			{
				if(r_RApply_Boolean_Boolean == null)
				{
					r_RApply_Boolean_Boolean = new(this, "Apply", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_RApply_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RApply_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void Apply(Boolean)
		/// </summary>
		protected RMethod r_RApply_Boolean;
		public virtual RMethod RApply_Boolean
		{
			get
			{
				if(r_RApply_Boolean == null)
				{
					r_RApply_Boolean = new(this, "Apply", 0, typeof(System.Boolean));
					r_RApply_Boolean.SetBelong(this.instance);
				}
				return r_RApply_Boolean;
			}
		}

		/// <summary>
		/// Void Apply()
		/// </summary>
		protected RMethod r_RApply;
		public virtual RMethod RApply
		{
			get
			{
				if(r_RApply == null)
				{
					r_RApply = new(this, "Apply", 0);
					r_RApply.SetBelong(this.instance);
				}
				return r_RApply;
			}
		}

		/// <summary>
		/// Boolean Reinitialize(Int32, Int32)
		/// </summary>
		protected RMethod r_RReinitialize_Int32_Int32;
		public virtual RMethod RReinitialize_Int32_Int32
		{
			get
			{
				if(r_RReinitialize_Int32_Int32 == null)
				{
					r_RReinitialize_Int32_Int32 = new(this, "Reinitialize", 0, typeof(System.Int32), typeof(System.Int32));
					r_RReinitialize_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReinitialize_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean Reinitialize(Int32, Int32, UnityEngine.TextureFormat, Boolean)
		/// </summary>
		protected RMethod r_RReinitialize_Int32_Int32_TextureFormat_Boolean;
		public virtual RMethod RReinitialize_Int32_Int32_TextureFormat_Boolean
		{
			get
			{
				if(r_RReinitialize_Int32_Int32_TextureFormat_Boolean == null)
				{
					r_RReinitialize_Int32_Int32_TextureFormat_Boolean = new(this, "Reinitialize", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextureFormat), typeof(System.Boolean));
					r_RReinitialize_Int32_Int32_TextureFormat_Boolean.SetBelong(this.instance);
				}
				return r_RReinitialize_Int32_Int32_TextureFormat_Boolean;
			}
		}

		/// <summary>
		/// Boolean Reinitialize(Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, Boolean)
		/// </summary>
		protected RMethod r_RReinitialize_Int32_Int32_GraphicsFormat_Boolean;
		public virtual RMethod RReinitialize_Int32_Int32_GraphicsFormat_Boolean
		{
			get
			{
				if(r_RReinitialize_Int32_Int32_GraphicsFormat_Boolean == null)
				{
					r_RReinitialize_Int32_Int32_GraphicsFormat_Boolean = new(this, "Reinitialize", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Boolean));
					r_RReinitialize_Int32_Int32_GraphicsFormat_Boolean.SetBelong(this.instance);
				}
				return r_RReinitialize_Int32_Int32_GraphicsFormat_Boolean;
			}
		}

		/// <summary>
		/// Boolean Resize(Int32, Int32)
		/// </summary>
		protected RMethod r_RResize_Int32_Int32;
		public virtual RMethod RResize_Int32_Int32
		{
			get
			{
				if(r_RResize_Int32_Int32 == null)
				{
					r_RResize_Int32_Int32 = new(this, "Resize", 0, typeof(System.Int32), typeof(System.Int32));
					r_RResize_Int32_Int32.SetBelong(this.instance);
				}
				return r_RResize_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean Resize(Int32, Int32, UnityEngine.TextureFormat, Boolean)
		/// </summary>
		protected RMethod r_RResize_Int32_Int32_TextureFormat_Boolean;
		public virtual RMethod RResize_Int32_Int32_TextureFormat_Boolean
		{
			get
			{
				if(r_RResize_Int32_Int32_TextureFormat_Boolean == null)
				{
					r_RResize_Int32_Int32_TextureFormat_Boolean = new(this, "Resize", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextureFormat), typeof(System.Boolean));
					r_RResize_Int32_Int32_TextureFormat_Boolean.SetBelong(this.instance);
				}
				return r_RResize_Int32_Int32_TextureFormat_Boolean;
			}
		}

		/// <summary>
		/// Boolean Resize(Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, Boolean)
		/// </summary>
		protected RMethod r_RResize_Int32_Int32_GraphicsFormat_Boolean;
		public virtual RMethod RResize_Int32_Int32_GraphicsFormat_Boolean
		{
			get
			{
				if(r_RResize_Int32_Int32_GraphicsFormat_Boolean == null)
				{
					r_RResize_Int32_Int32_GraphicsFormat_Boolean = new(this, "Resize", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Boolean));
					r_RResize_Int32_Int32_GraphicsFormat_Boolean.SetBelong(this.instance);
				}
				return r_RResize_Int32_Int32_GraphicsFormat_Boolean;
			}
		}

		/// <summary>
		/// Void ReadPixels(UnityEngine.Rect, Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_RReadPixels_Rect_Int32_Int32_Boolean;
		public virtual RMethod RReadPixels_Rect_Int32_Int32_Boolean
		{
			get
			{
				if(r_RReadPixels_Rect_Int32_Int32_Boolean == null)
				{
					r_RReadPixels_Rect_Int32_Int32_Boolean = new(this, "ReadPixels", 0, typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_RReadPixels_Rect_Int32_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RReadPixels_Rect_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void ReadPixels(UnityEngine.Rect, Int32, Int32)
		/// </summary>
		protected RMethod r_RReadPixels_Rect_Int32_Int32;
		public virtual RMethod RReadPixels_Rect_Int32_Int32
		{
			get
			{
				if(r_RReadPixels_Rect_Int32_Int32 == null)
				{
					r_RReadPixels_Rect_Int32_Int32 = new(this, "ReadPixels", 0, typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Int32));
					r_RReadPixels_Rect_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadPixels_Rect_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean GenerateAtlas(UnityEngine.Vector2[], Int32, Int32, System.Collections.Generic.List`1[UnityEngine.Rect])
		/// </summary>
		protected static RMethod r_RGenerateAtlas_Vector2Array_Int32_Int32_List_d_Rect_p_;
		public static RMethod RGenerateAtlas_Vector2Array_Int32_Int32_List_d_Rect_p_
		{
			get
			{
				if(r_RGenerateAtlas_Vector2Array_Int32_Int32_List_d_Rect_p_ == null)
				{
					r_RGenerateAtlas_Vector2Array_Int32_Int32_List_d_Rect_p_ = new(typeof(UnityEngine.Texture2D), "GenerateAtlas", 0, typeof(UnityEngine.Vector2).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Rect)));
					r_RGenerateAtlas_Vector2Array_Int32_Int32_List_d_Rect_p_.SetBelong(null);
				}
				return r_RGenerateAtlas_Vector2Array_Int32_Int32_List_d_Rect_p_;
			}
		}

		/// <summary>
		/// Void SetPixels32(UnityEngine.Color32[], Int32)
		/// </summary>
		protected RMethod r_RSetPixels32_Color32Array_Int32;
		public virtual RMethod RSetPixels32_Color32Array_Int32
		{
			get
			{
				if(r_RSetPixels32_Color32Array_Int32 == null)
				{
					r_RSetPixels32_Color32Array_Int32 = new(this, "SetPixels32", 0, typeof(UnityEngine.Color32).MakeArrayType(), typeof(System.Int32));
					r_RSetPixels32_Color32Array_Int32.SetBelong(this.instance);
				}
				return r_RSetPixels32_Color32Array_Int32;
			}
		}

		/// <summary>
		/// Void SetPixels32(UnityEngine.Color32[])
		/// </summary>
		protected RMethod r_RSetPixels32_Color32Array;
		public virtual RMethod RSetPixels32_Color32Array
		{
			get
			{
				if(r_RSetPixels32_Color32Array == null)
				{
					r_RSetPixels32_Color32Array = new(this, "SetPixels32", 0, typeof(UnityEngine.Color32).MakeArrayType());
					r_RSetPixels32_Color32Array.SetBelong(this.instance);
				}
				return r_RSetPixels32_Color32Array;
			}
		}

		/// <summary>
		/// Void SetPixels32(Int32, Int32, Int32, Int32, UnityEngine.Color32[], Int32)
		/// </summary>
		protected RMethod r_RSetPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32;
		public virtual RMethod RSetPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32
		{
			get
			{
				if(r_RSetPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32 == null)
				{
					r_RSetPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32 = new(this, "SetPixels32", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color32).MakeArrayType(), typeof(System.Int32));
					r_RSetPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32.SetBelong(this.instance);
				}
				return r_RSetPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32;
			}
		}

		/// <summary>
		/// Void SetPixels32(Int32, Int32, Int32, Int32, UnityEngine.Color32[])
		/// </summary>
		protected RMethod r_RSetPixels32_Int32_Int32_Int32_Int32_Color32Array;
		public virtual RMethod RSetPixels32_Int32_Int32_Int32_Int32_Color32Array
		{
			get
			{
				if(r_RSetPixels32_Int32_Int32_Int32_Int32_Color32Array == null)
				{
					r_RSetPixels32_Int32_Int32_Int32_Int32_Color32Array = new(this, "SetPixels32", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color32).MakeArrayType());
					r_RSetPixels32_Int32_Int32_Int32_Int32_Color32Array.SetBelong(this.instance);
				}
				return r_RSetPixels32_Int32_Int32_Int32_Int32_Color32Array;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] GetPixels(Int32)
		/// </summary>
		protected RMethod r_RGetPixels_Int32;
		public virtual RMethod RGetPixels_Int32
		{
			get
			{
				if(r_RGetPixels_Int32 == null)
				{
					r_RGetPixels_Int32 = new(this, "GetPixels", 0, typeof(System.Int32));
					r_RGetPixels_Int32.SetBelong(this.instance);
				}
				return r_RGetPixels_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] GetPixels()
		/// </summary>
		protected RMethod r_RGetPixels;
		public virtual RMethod RGetPixels
		{
			get
			{
				if(r_RGetPixels == null)
				{
					r_RGetPixels = new(this, "GetPixels", 0);
					r_RGetPixels.SetBelong(this.instance);
				}
				return r_RGetPixels;
			}
		}

		/// <summary>
		/// Void SetPixelImpl_Injected(Int32, Int32, Int32, Int32, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_RSetPixelImpl_Injected_Int32_Int32_Int32_Int32_Ref_Color;
		public virtual RMethod RSetPixelImpl_Injected_Int32_Int32_Int32_Int32_Ref_Color
		{
			get
			{
				if(r_RSetPixelImpl_Injected_Int32_Int32_Int32_Int32_Ref_Color == null)
				{
					r_RSetPixelImpl_Injected_Int32_Int32_Int32_Int32_Ref_Color = new(this, "SetPixelImpl_Injected", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color).MakeByRefType());
					r_RSetPixelImpl_Injected_Int32_Int32_Int32_Int32_Ref_Color.SetBelong(this.instance);
				}
				return r_RSetPixelImpl_Injected_Int32_Int32_Int32_Int32_Ref_Color;
			}
		}

		/// <summary>
		/// Void GetPixelImpl_Injected(Int32, Int32, Int32, Int32, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_RGetPixelImpl_Injected_Int32_Int32_Int32_Int32_Out_Color;
		public virtual RMethod RGetPixelImpl_Injected_Int32_Int32_Int32_Int32_Out_Color
		{
			get
			{
				if(r_RGetPixelImpl_Injected_Int32_Int32_Int32_Int32_Out_Color == null)
				{
					r_RGetPixelImpl_Injected_Int32_Int32_Int32_Int32_Out_Color = new(this, "GetPixelImpl_Injected", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color).MakeByRefType());
					r_RGetPixelImpl_Injected_Int32_Int32_Int32_Int32_Out_Color.SetBelong(this.instance);
				}
				return r_RGetPixelImpl_Injected_Int32_Int32_Int32_Int32_Out_Color;
			}
		}

		/// <summary>
		/// Void GetPixelBilinearImpl_Injected(Int32, Int32, Single, Single, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_RGetPixelBilinearImpl_Injected_Int32_Int32_Single_Single_Out_Color;
		public virtual RMethod RGetPixelBilinearImpl_Injected_Int32_Int32_Single_Single_Out_Color
		{
			get
			{
				if(r_RGetPixelBilinearImpl_Injected_Int32_Int32_Single_Single_Out_Color == null)
				{
					r_RGetPixelBilinearImpl_Injected_Int32_Int32_Single_Single_Out_Color = new(this, "GetPixelBilinearImpl_Injected", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Color).MakeByRefType());
					r_RGetPixelBilinearImpl_Injected_Int32_Int32_Single_Single_Out_Color.SetBelong(this.instance);
				}
				return r_RGetPixelBilinearImpl_Injected_Int32_Int32_Single_Single_Out_Color;
			}
		}

		/// <summary>
		/// Void ReadPixelsImpl_Injected(UnityEngine.Rect ByRef, Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_RReadPixelsImpl_Injected_Ref_Rect_Int32_Int32_Boolean;
		public virtual RMethod RReadPixelsImpl_Injected_Ref_Rect_Int32_Int32_Boolean
		{
			get
			{
				if(r_RReadPixelsImpl_Injected_Ref_Rect_Int32_Int32_Boolean == null)
				{
					r_RReadPixelsImpl_Injected_Ref_Rect_Int32_Int32_Boolean = new(this, "ReadPixelsImpl_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_RReadPixelsImpl_Injected_Ref_Rect_Int32_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RReadPixelsImpl_Injected_Ref_Rect_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetSafetyHandle_Injected(UnityEngine.Texture2D, Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_RGetSafetyHandle_Injected_Texture2D_Out_AtomicSafetyHandle;
		public static RMethod RGetSafetyHandle_Injected_Texture2D_Out_AtomicSafetyHandle
		{
			get
			{
				if(r_RGetSafetyHandle_Injected_Texture2D_Out_AtomicSafetyHandle == null)
				{
					r_RGetSafetyHandle_Injected_Texture2D_Out_AtomicSafetyHandle = new(typeof(UnityEngine.Texture2D), "GetSafetyHandle_Injected", 0, typeof(UnityEngine.Texture2D), typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RGetSafetyHandle_Injected_Texture2D_Out_AtomicSafetyHandle.SetBelong(null);
				}
				return r_RGetSafetyHandle_Injected_Texture2D_Out_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void GetSafetyHandleForSlice_Injected(Int32, Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected RMethod r_RGetSafetyHandleForSlice_Injected_Int32_Out_AtomicSafetyHandle;
		public virtual RMethod RGetSafetyHandleForSlice_Injected_Int32_Out_AtomicSafetyHandle
		{
			get
			{
				if(r_RGetSafetyHandleForSlice_Injected_Int32_Out_AtomicSafetyHandle == null)
				{
					r_RGetSafetyHandleForSlice_Injected_Int32_Out_AtomicSafetyHandle = new(this, "GetSafetyHandleForSlice_Injected", 0, typeof(System.Int32), typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_RGetSafetyHandleForSlice_Injected_Int32_Out_AtomicSafetyHandle.SetBelong(this.instance);
				}
				return r_RGetSafetyHandleForSlice_Injected_Int32_Out_AtomicSafetyHandle;
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


        public RTexture2D() : base("UnityEngine.Texture2D")
        {
        }

        public RTexture2D(System.Object instance) : base("UnityEngine.Texture2D")
		{
            SetInstance(instance);
		}

        public RTexture2D(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTexture2D(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Compress(System.Boolean  @highQuality)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@highQuality};
            var ___result = RCompress_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean Internal_CreateImpl(UnityEngine.Texture2D  @mono, System.Int32  @w, System.Int32  @h, System.Int32  @mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat  @format, UnityEngine.Experimental.Rendering.TextureCreationFlags  @flags, System.IntPtr  @nativeTex, System.String  @mipmapLimitGroupName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mono, @w, @h, @mipCount, @format, @flags, @nativeTex, @mipmapLimitGroupName};
            var ___result = RInternal_CreateImpl_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void Internal_Create(UnityEngine.Texture2D  @mono, System.Int32  @w, System.Int32  @h, System.Int32  @mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat  @format, UnityEngine.Experimental.Rendering.TextureCreationFlags  @flags, System.IntPtr  @nativeTex, System.String  @mipmapLimitGroupName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mono, @w, @h, @mipCount, @format, @flags, @nativeTex, @mipmapLimitGroupName};
            var ___result = RInternal_Create_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyImpl(System.Boolean  @updateMipmaps, System.Boolean  @makeNoLongerReadable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updateMipmaps, @makeNoLongerReadable};
            var ___result = RApplyImpl_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ReinitializeImpl(System.Int32  @width, System.Int32  @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height};
            var ___result = RReinitializeImpl_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetPixelImpl(System.Int32  @image, System.Int32  @mip, System.Int32  @x, System.Int32  @y, UnityEngine.Color  @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@image, @mip, @x, @y, @color};
            var ___result = RSetPixelImpl_Int32_Int32_Int32_Int32_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Color GetPixelImpl(System.Int32  @image, System.Int32  @mip, System.Int32  @x, System.Int32  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@image, @mip, @x, @y};
            var ___result = RGetPixelImpl_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual UnityEngine.Color GetPixelBilinearImpl(System.Int32  @image, System.Int32  @mip, System.Single  @u, System.Single  @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@image, @mip, @u, @v};
            var ___result = RGetPixelBilinearImpl_Int32_Int32_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual System.Boolean ReinitializeWithFormatImpl(System.Int32  @width, System.Int32  @height, UnityEngine.Experimental.Rendering.GraphicsFormat  @format, System.Boolean  @hasMipMap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @format, @hasMipMap};
            var ___result = RReinitializeWithFormatImpl_Int32_Int32_GraphicsFormat_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ReinitializeWithTextureFormatImpl(System.Int32  @width, System.Int32  @height, UnityEngine.TextureFormat  @textureFormat, System.Boolean  @hasMipMap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @textureFormat, @hasMipMap};
            var ___result = RReinitializeWithTextureFormatImpl_Int32_Int32_TextureFormat_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ReadPixelsImpl(UnityEngine.Rect  @source, System.Int32  @destX, System.Int32  @destY, System.Boolean  @recalculateMipMaps)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @destX, @destY, @recalculateMipMaps};
            var ___result = RReadPixelsImpl_Rect_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixelsImpl(System.Int32  @x, System.Int32  @y, System.Int32  @w, System.Int32  @h, UnityEngine.Color[]  @pixel, System.Int32  @miplevel, System.Int32  @frame)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @w, @h, @pixel, @miplevel, @frame};
            var ___result = RSetPixelsImpl_Int32_Int32_Int32_Int32_ColorArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean LoadRawTextureDataImpl(System.IntPtr  @data, System.UInt64  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @size};
            var ___result = RLoadRawTextureDataImpl_IntPtr_UInt64.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean LoadRawTextureDataImplArray(System.Byte[]  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RLoadRawTextureDataImplArray_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SetPixelDataImplArray(System.Array  @data, System.Int32  @mipLevel, System.Int32  @elementSize, System.Int32  @dataArraySize, System.Int32  @sourceDataStartIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @mipLevel, @elementSize, @dataArraySize, @sourceDataStartIndex};
            var ___result = RSetPixelDataImplArray_Array_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SetPixelDataImpl(System.IntPtr  @data, System.Int32  @mipLevel, System.Int32  @elementSize, System.Int32  @dataArraySize, System.Int32  @sourceDataStartIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @mipLevel, @elementSize, @dataArraySize, @sourceDataStartIndex};
            var ___result = RSetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.IntPtr GetWritableImageData(System.Int32  @frame)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@frame};
            var ___result = RGetWritableImageData_Int32.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.UInt64 GetRawImageDataSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRawImageDataSize.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public static Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetSafetyHandle(UnityEngine.Texture2D  @tex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tex};
            var ___result = RGetSafetyHandle_Texture2D.Invoke(___genericsType, ___parameters);

            return (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___result;
        }


        public virtual Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetSafetyHandleForSlice(System.Int32  @mipLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mipLevel};
            var ___result = RGetSafetyHandleForSlice_Int32.Invoke(___genericsType, ___parameters);

            return (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___result;
        }


        public static void GenerateAtlasImpl(UnityEngine.Vector2[]  @sizes, System.Int32  @padding, System.Int32  @atlasSize, UnityEngine.Rect[]  @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sizes, @padding, @atlasSize, @rect};
            var ___result = RGenerateAtlasImpl_Vector2Array_Int32_Int32_RectArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearRequestedMipmapLevel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearRequestedMipmapLevel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsRequestedMipmapLevelLoaded()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsRequestedMipmapLevelLoaded.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ClearMinimumMipmapLevel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearMinimumMipmapLevel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateExternalTexture(System.IntPtr  @nativeTex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nativeTex};
            var ___result = RUpdateExternalTexture_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAllPixels32(UnityEngine.Color32[]  @colors, System.Int32  @miplevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors, @miplevel};
            var ___result = RSetAllPixels32_Color32Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBlockOfPixels32(System.Int32  @x, System.Int32  @y, System.Int32  @blockWidth, System.Int32  @blockHeight, UnityEngine.Color32[]  @colors, System.Int32  @miplevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @blockWidth, @blockHeight, @colors, @miplevel};
            var ___result = RSetBlockOfPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Byte[] GetRawTextureData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRawTextureData.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual UnityEngine.Color[] GetPixels(System.Int32  @x, System.Int32  @y, System.Int32  @blockWidth, System.Int32  @blockHeight, System.Int32  @miplevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @blockWidth, @blockHeight, @miplevel};
            var ___result = RGetPixels_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color[])___result;
        }


        public virtual UnityEngine.Color[] GetPixels(System.Int32  @x, System.Int32  @y, System.Int32  @blockWidth, System.Int32  @blockHeight)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @blockWidth, @blockHeight};
            var ___result = RGetPixels_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color[])___result;
        }


        public virtual UnityEngine.Color32[] GetPixels32(System.Int32  @miplevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@miplevel};
            var ___result = RGetPixels32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color32[])___result;
        }


        public virtual UnityEngine.Color32[] GetPixels32()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPixels32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color32[])___result;
        }


        public virtual UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[]  @textures, System.Int32  @padding, System.Int32  @maximumAtlasSize, System.Boolean  @makeNoLongerReadable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textures, @padding, @maximumAtlasSize, @makeNoLongerReadable};
            var ___result = RPackTextures_Texture2DArray_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect[])___result;
        }


        public virtual UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[]  @textures, System.Int32  @padding, System.Int32  @maximumAtlasSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textures, @padding, @maximumAtlasSize};
            var ___result = RPackTextures_Texture2DArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect[])___result;
        }


        public virtual UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[]  @textures, System.Int32  @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textures, @padding};
            var ___result = RPackTextures_Texture2DArray_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect[])___result;
        }


        public virtual System.Boolean ValidateFormat(UnityEngine.TextureFormat  @format, System.Int32  @width, System.Int32  @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @width, @height};
            var ___result = RValidateFormat_TextureFormat_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat  @format, System.Int32  @width, System.Int32  @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @width, @height};
            var ___result = RValidateFormat_GraphicsFormat_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Texture2D CreateExternalTexture(System.Int32  @width, System.Int32  @height, UnityEngine.TextureFormat  @format, System.Boolean  @mipChain, System.Boolean  @linear, System.IntPtr  @nativeTex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @format, @mipChain, @linear, @nativeTex};
            var ___result = RCreateExternalTexture_Int32_Int32_TextureFormat_Boolean_Boolean_IntPtr.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture2D)___result;
        }


        public virtual void SetPixel(System.Int32  @x, System.Int32  @y, UnityEngine.Color  @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @color};
            var ___result = RSetPixel_Int32_Int32_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixel(System.Int32  @x, System.Int32  @y, UnityEngine.Color  @color, System.Int32  @mipLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @color, @mipLevel};
            var ___result = RSetPixel_Int32_Int32_Color_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixels(System.Int32  @x, System.Int32  @y, System.Int32  @blockWidth, System.Int32  @blockHeight, UnityEngine.Color[]  @colors, System.Int32  @miplevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @blockWidth, @blockHeight, @colors, @miplevel};
            var ___result = RSetPixels_Int32_Int32_Int32_Int32_ColorArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixels(System.Int32  @x, System.Int32  @y, System.Int32  @blockWidth, System.Int32  @blockHeight, UnityEngine.Color[]  @colors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @blockWidth, @blockHeight, @colors};
            var ___result = RSetPixels_Int32_Int32_Int32_Int32_ColorArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixels(UnityEngine.Color[]  @colors, System.Int32  @miplevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors, @miplevel};
            var ___result = RSetPixels_ColorArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixels(UnityEngine.Color[]  @colors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors};
            var ___result = RSetPixels_ColorArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Color GetPixel(System.Int32  @x, System.Int32  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RGetPixel_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual UnityEngine.Color GetPixel(System.Int32  @x, System.Int32  @y, System.Int32  @mipLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @mipLevel};
            var ___result = RGetPixel_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual UnityEngine.Color GetPixelBilinear(System.Single  @u, System.Single  @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@u, @v};
            var ___result = RGetPixelBilinear_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual UnityEngine.Color GetPixelBilinear(System.Single  @u, System.Single  @v, System.Int32  @mipLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@u, @v, @mipLevel};
            var ___result = RGetPixelBilinear_Single_Single_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual void LoadRawTextureData(System.IntPtr  @data, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @size};
            var ___result = RLoadRawTextureData_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadRawTextureData(System.Byte[]  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RLoadRawTextureData_ByteArray.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SetPixelData<T>(T[]  @data, System.Int32  @mipLevel, System.Int32  @sourceDataStartIndex)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data, @mipLevel, @sourceDataStartIndex};
            var ___result = RSetPixelData_GT_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Object GetPixelData<T>(System.Int32  @mipLevel) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@mipLevel};
            var ___result = RGetPixelData_GT_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetRawTextureData<T>() where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetRawTextureData_GT.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Apply(System.Boolean  @updateMipmaps, System.Boolean  @makeNoLongerReadable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updateMipmaps, @makeNoLongerReadable};
            var ___result = RApply_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Apply(System.Boolean  @updateMipmaps)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updateMipmaps};
            var ___result = RApply_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Apply()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RApply.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Reinitialize(System.Int32  @width, System.Int32  @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height};
            var ___result = RReinitialize_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Reinitialize(System.Int32  @width, System.Int32  @height, UnityEngine.TextureFormat  @format, System.Boolean  @hasMipMap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @format, @hasMipMap};
            var ___result = RReinitialize_Int32_Int32_TextureFormat_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Reinitialize(System.Int32  @width, System.Int32  @height, UnityEngine.Experimental.Rendering.GraphicsFormat  @format, System.Boolean  @hasMipMap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @format, @hasMipMap};
            var ___result = RReinitialize_Int32_Int32_GraphicsFormat_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Resize(System.Int32  @width, System.Int32  @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height};
            var ___result = RResize_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Resize(System.Int32  @width, System.Int32  @height, UnityEngine.TextureFormat  @format, System.Boolean  @hasMipMap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @format, @hasMipMap};
            var ___result = RResize_Int32_Int32_TextureFormat_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Resize(System.Int32  @width, System.Int32  @height, UnityEngine.Experimental.Rendering.GraphicsFormat  @format, System.Boolean  @hasMipMap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @format, @hasMipMap};
            var ___result = RResize_Int32_Int32_GraphicsFormat_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ReadPixels(UnityEngine.Rect  @source, System.Int32  @destX, System.Int32  @destY, System.Boolean  @recalculateMipMaps)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @destX, @destY, @recalculateMipMaps};
            var ___result = RReadPixels_Rect_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadPixels(UnityEngine.Rect  @source, System.Int32  @destX, System.Int32  @destY)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @destX, @destY};
            var ___result = RReadPixels_Rect_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean GenerateAtlas(UnityEngine.Vector2[]  @sizes, System.Int32  @padding, System.Int32  @atlasSize, System.Collections.Generic.List<UnityEngine.Rect>  @results)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sizes, @padding, @atlasSize, @results};
            var ___result = RGenerateAtlas_Vector2Array_Int32_Int32_List_d_Rect_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetPixels32(UnityEngine.Color32[]  @colors, System.Int32  @miplevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors, @miplevel};
            var ___result = RSetPixels32_Color32Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixels32(UnityEngine.Color32[]  @colors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors};
            var ___result = RSetPixels32_Color32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixels32(System.Int32  @x, System.Int32  @y, System.Int32  @blockWidth, System.Int32  @blockHeight, UnityEngine.Color32[]  @colors, System.Int32  @miplevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @blockWidth, @blockHeight, @colors, @miplevel};
            var ___result = RSetPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixels32(System.Int32  @x, System.Int32  @y, System.Int32  @blockWidth, System.Int32  @blockHeight, UnityEngine.Color32[]  @colors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @blockWidth, @blockHeight, @colors};
            var ___result = RSetPixels32_Int32_Int32_Int32_Int32_Color32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Color[] GetPixels(System.Int32  @miplevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@miplevel};
            var ___result = RGetPixels_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color[])___result;
        }


        public virtual UnityEngine.Color[] GetPixels()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPixels.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color[])___result;
        }


        public virtual void SetPixelImpl_Injected(System.Int32  @image, System.Int32  @mip, System.Int32  @x, System.Int32  @y, ref UnityEngine.Color  @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@image, @mip, @x, @y, @color};
            var ___result = RSetPixelImpl_Injected_Int32_Int32_Int32_Int32_Ref_Color.Invoke(___genericsType, ___parameters);
			color = (UnityEngine.Color)___parameters[4];

            
        }


        public virtual void GetPixelImpl_Injected(System.Int32  @image, System.Int32  @mip, System.Int32  @x, System.Int32  @y, out UnityEngine.Color  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@image, @mip, @x, @y, @ret};
            var ___result = RGetPixelImpl_Injected_Int32_Int32_Int32_Int32_Out_Color.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Color)___parameters[4];

            
        }


        public virtual void GetPixelBilinearImpl_Injected(System.Int32  @image, System.Int32  @mip, System.Single  @u, System.Single  @v, out UnityEngine.Color  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@image, @mip, @u, @v, @ret};
            var ___result = RGetPixelBilinearImpl_Injected_Int32_Int32_Single_Single_Out_Color.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Color)___parameters[4];

            
        }


        public virtual void ReadPixelsImpl_Injected(ref UnityEngine.Rect  @source, System.Int32  @destX, System.Int32  @destY, System.Boolean  @recalculateMipMaps)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @destX, @destY, @recalculateMipMaps};
            var ___result = RReadPixelsImpl_Injected_Ref_Rect_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);
			source = (UnityEngine.Rect)___parameters[0];

            
        }


        public static void GetSafetyHandle_Injected(UnityEngine.Texture2D  @tex, out Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tex, @ret};
            var ___result = RGetSafetyHandle_Injected_Texture2D_Out_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			ret = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[1];

            
        }


        public virtual void GetSafetyHandleForSlice_Injected(System.Int32  @mipLevel, out Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mipLevel, @ret};
            var ___result = RGetSafetyHandleForSlice_Injected_Int32_Out_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			ret = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[1];

            
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
