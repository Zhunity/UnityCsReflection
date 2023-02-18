
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Texture
	/// </summary>
    public partial class RTexture : RMember //
    {

		/// <summary>
		/// System.Int32 GenerateAllMips
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FGenerateAllMips;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFGenerateAllMips
		{
			get
			{
				if(r_FGenerateAllMips == null)
				{
					r_FGenerateAllMips = new(typeof(UnityEngine.Texture), "GenerateAllMips");
					r_FGenerateAllMips.SetBelong(null);
				}
				return r_FGenerateAllMips;
			}
		}

		/// <summary>
		/// Int32 masterTextureLimit
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_PmasterTextureLimit;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RPmasterTextureLimit
		{
			get
			{
				if(r_PmasterTextureLimit == null)
				{
					r_PmasterTextureLimit = new(typeof(UnityEngine.Texture), "masterTextureLimit", -1);
					r_PmasterTextureLimit.SetBelong(null);
				}
				return r_PmasterTextureLimit;
			}
		}

		/// <summary>
		/// Int32 globalMipmapLimit
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_PglobalMipmapLimit;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RPglobalMipmapLimit
		{
			get
			{
				if(r_PglobalMipmapLimit == null)
				{
					r_PglobalMipmapLimit = new(typeof(UnityEngine.Texture), "globalMipmapLimit", -1);
					r_PglobalMipmapLimit.SetBelong(null);
				}
				return r_PglobalMipmapLimit;
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
					r_PmipmapCount.SetBelong(this.GetValue());
				}
				return r_PmipmapCount;
			}
		}

		/// <summary>
		/// UnityEngine.AnisotropicFiltering anisotropicFiltering
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RAnisotropicFiltering r_PanisotropicFiltering;
		public static Hvak.Editor.Refleaction.RUnityEngine.RAnisotropicFiltering RPanisotropicFiltering
		{
			get
			{
				if(r_PanisotropicFiltering == null)
				{
					r_PanisotropicFiltering = new(typeof(UnityEngine.Texture), "anisotropicFiltering", -1);
					r_PanisotropicFiltering.SetBelong(null);
				}
				return r_PanisotropicFiltering;
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
					r_PgraphicsFormat.SetBelong(this.GetValue());
				}
				return r_PgraphicsFormat;
			}
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
					r_Pwidth.SetBelong(this.GetValue());
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
					r_Pheight.SetBelong(this.GetValue());
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
					r_Pdimension.SetBelong(this.GetValue());
				}
				return r_Pdimension;
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
					r_PisReadable.SetBelong(this.GetValue());
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
					r_PwrapMode.SetBelong(this.GetValue());
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
					r_PwrapModeU.SetBelong(this.GetValue());
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
					r_PwrapModeV.SetBelong(this.GetValue());
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
					r_PwrapModeW.SetBelong(this.GetValue());
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
					r_PfilterMode.SetBelong(this.GetValue());
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
					r_PanisoLevel.SetBelong(this.GetValue());
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
					r_PmipMapBias.SetBelong(this.GetValue());
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
					r_PtexelSize.SetBelong(this.GetValue());
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
					r_PupdateCount.SetBelong(this.GetValue());
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
					r_PactiveTextureColorSpace.SetBelong(this.GetValue());
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
					r_PisDataSRGB.SetBelong(this.GetValue());
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
					r_PimageContentsHash.SetBelong(this.GetValue());
				}
				return r_PimageContentsHash;
			}
		}

		/// <summary>
		/// UInt64 totalTextureMemory
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt64 r_PtotalTextureMemory;
		public static Hvak.Editor.Refleaction.RSystem.RUInt64 RPtotalTextureMemory
		{
			get
			{
				if(r_PtotalTextureMemory == null)
				{
					r_PtotalTextureMemory = new(typeof(UnityEngine.Texture), "totalTextureMemory", -1);
					r_PtotalTextureMemory.SetBelong(null);
				}
				return r_PtotalTextureMemory;
			}
		}

		/// <summary>
		/// UInt64 desiredTextureMemory
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt64 r_PdesiredTextureMemory;
		public static Hvak.Editor.Refleaction.RSystem.RUInt64 RPdesiredTextureMemory
		{
			get
			{
				if(r_PdesiredTextureMemory == null)
				{
					r_PdesiredTextureMemory = new(typeof(UnityEngine.Texture), "desiredTextureMemory", -1);
					r_PdesiredTextureMemory.SetBelong(null);
				}
				return r_PdesiredTextureMemory;
			}
		}

		/// <summary>
		/// UInt64 targetTextureMemory
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt64 r_PtargetTextureMemory;
		public static Hvak.Editor.Refleaction.RSystem.RUInt64 RPtargetTextureMemory
		{
			get
			{
				if(r_PtargetTextureMemory == null)
				{
					r_PtargetTextureMemory = new(typeof(UnityEngine.Texture), "targetTextureMemory", -1);
					r_PtargetTextureMemory.SetBelong(null);
				}
				return r_PtargetTextureMemory;
			}
		}

		/// <summary>
		/// UInt64 currentTextureMemory
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt64 r_PcurrentTextureMemory;
		public static Hvak.Editor.Refleaction.RSystem.RUInt64 RPcurrentTextureMemory
		{
			get
			{
				if(r_PcurrentTextureMemory == null)
				{
					r_PcurrentTextureMemory = new(typeof(UnityEngine.Texture), "currentTextureMemory", -1);
					r_PcurrentTextureMemory.SetBelong(null);
				}
				return r_PcurrentTextureMemory;
			}
		}

		/// <summary>
		/// UInt64 nonStreamingTextureMemory
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt64 r_PnonStreamingTextureMemory;
		public static Hvak.Editor.Refleaction.RSystem.RUInt64 RPnonStreamingTextureMemory
		{
			get
			{
				if(r_PnonStreamingTextureMemory == null)
				{
					r_PnonStreamingTextureMemory = new(typeof(UnityEngine.Texture), "nonStreamingTextureMemory", -1);
					r_PnonStreamingTextureMemory.SetBelong(null);
				}
				return r_PnonStreamingTextureMemory;
			}
		}

		/// <summary>
		/// UInt64 streamingMipmapUploadCount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt64 r_PstreamingMipmapUploadCount;
		public static Hvak.Editor.Refleaction.RSystem.RUInt64 RPstreamingMipmapUploadCount
		{
			get
			{
				if(r_PstreamingMipmapUploadCount == null)
				{
					r_PstreamingMipmapUploadCount = new(typeof(UnityEngine.Texture), "streamingMipmapUploadCount", -1);
					r_PstreamingMipmapUploadCount.SetBelong(null);
				}
				return r_PstreamingMipmapUploadCount;
			}
		}

		/// <summary>
		/// UInt64 streamingRendererCount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt64 r_PstreamingRendererCount;
		public static Hvak.Editor.Refleaction.RSystem.RUInt64 RPstreamingRendererCount
		{
			get
			{
				if(r_PstreamingRendererCount == null)
				{
					r_PstreamingRendererCount = new(typeof(UnityEngine.Texture), "streamingRendererCount", -1);
					r_PstreamingRendererCount.SetBelong(null);
				}
				return r_PstreamingRendererCount;
			}
		}

		/// <summary>
		/// UInt64 streamingTextureCount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt64 r_PstreamingTextureCount;
		public static Hvak.Editor.Refleaction.RSystem.RUInt64 RPstreamingTextureCount
		{
			get
			{
				if(r_PstreamingTextureCount == null)
				{
					r_PstreamingTextureCount = new(typeof(UnityEngine.Texture), "streamingTextureCount", -1);
					r_PstreamingTextureCount.SetBelong(null);
				}
				return r_PstreamingTextureCount;
			}
		}

		/// <summary>
		/// UInt64 nonStreamingTextureCount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt64 r_PnonStreamingTextureCount;
		public static Hvak.Editor.Refleaction.RSystem.RUInt64 RPnonStreamingTextureCount
		{
			get
			{
				if(r_PnonStreamingTextureCount == null)
				{
					r_PnonStreamingTextureCount = new(typeof(UnityEngine.Texture), "nonStreamingTextureCount", -1);
					r_PnonStreamingTextureCount.SetBelong(null);
				}
				return r_PnonStreamingTextureCount;
			}
		}

		/// <summary>
		/// UInt64 streamingTexturePendingLoadCount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt64 r_PstreamingTexturePendingLoadCount;
		public static Hvak.Editor.Refleaction.RSystem.RUInt64 RPstreamingTexturePendingLoadCount
		{
			get
			{
				if(r_PstreamingTexturePendingLoadCount == null)
				{
					r_PstreamingTexturePendingLoadCount = new(typeof(UnityEngine.Texture), "streamingTexturePendingLoadCount", -1);
					r_PstreamingTexturePendingLoadCount.SetBelong(null);
				}
				return r_PstreamingTexturePendingLoadCount;
			}
		}

		/// <summary>
		/// UInt64 streamingTextureLoadingCount
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt64 r_PstreamingTextureLoadingCount;
		public static Hvak.Editor.Refleaction.RSystem.RUInt64 RPstreamingTextureLoadingCount
		{
			get
			{
				if(r_PstreamingTextureLoadingCount == null)
				{
					r_PstreamingTextureLoadingCount = new(typeof(UnityEngine.Texture), "streamingTextureLoadingCount", -1);
					r_PstreamingTextureLoadingCount.SetBelong(null);
				}
				return r_PstreamingTextureLoadingCount;
			}
		}

		/// <summary>
		/// Boolean streamingTextureForceLoadAll
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_PstreamingTextureForceLoadAll;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RPstreamingTextureForceLoadAll
		{
			get
			{
				if(r_PstreamingTextureForceLoadAll == null)
				{
					r_PstreamingTextureForceLoadAll = new(typeof(UnityEngine.Texture), "streamingTextureForceLoadAll", -1);
					r_PstreamingTextureForceLoadAll.SetBelong(null);
				}
				return r_PstreamingTextureForceLoadAll;
			}
		}

		/// <summary>
		/// Boolean streamingTextureDiscardUnusedMips
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_PstreamingTextureDiscardUnusedMips;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RPstreamingTextureDiscardUnusedMips
		{
			get
			{
				if(r_PstreamingTextureDiscardUnusedMips == null)
				{
					r_PstreamingTextureDiscardUnusedMips = new(typeof(UnityEngine.Texture), "streamingTextureDiscardUnusedMips", -1);
					r_PstreamingTextureDiscardUnusedMips.SetBelong(null);
				}
				return r_PstreamingTextureDiscardUnusedMips;
			}
		}

		/// <summary>
		/// Boolean allowThreadedTextureCreation
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RBoolean r_PallowThreadedTextureCreation;
		public static Hvak.Editor.Refleaction.RSystem.RBoolean RPallowThreadedTextureCreation
		{
			get
			{
				if(r_PallowThreadedTextureCreation == null)
				{
					r_PallowThreadedTextureCreation = new(typeof(UnityEngine.Texture), "allowThreadedTextureCreation", -1);
					r_PallowThreadedTextureCreation.SetBelong(null);
				}
				return r_PallowThreadedTextureCreation;
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
					r_Pname.SetBelong(this.GetValue());
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
					r_PhideFlags.SetBelong(this.GetValue());
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// Void SetGlobalAnisotropicFilteringLimits(Int32, Int32)
		/// </summary>
		protected static RMethod r_MSetGlobalAnisotropicFilteringLimits_Int32_Int32;
		public static RMethod RMSetGlobalAnisotropicFilteringLimits_Int32_Int32
		{
			get
			{
				if(r_MSetGlobalAnisotropicFilteringLimits_Int32_Int32 == null)
				{
					r_MSetGlobalAnisotropicFilteringLimits_Int32_Int32 = new(typeof(UnityEngine.Texture), "SetGlobalAnisotropicFilteringLimits", 0, typeof(System.Int32), typeof(System.Int32));
					r_MSetGlobalAnisotropicFilteringLimits_Int32_Int32.SetBelong(null);
				}
				return r_MSetGlobalAnisotropicFilteringLimits_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetDataWidth()
		/// </summary>
		protected RMethod r_MGetDataWidth;
		public virtual RMethod RMGetDataWidth
		{
			get
			{
				if(r_MGetDataWidth == null)
				{
					r_MGetDataWidth = new(this, "GetDataWidth", 0);
					r_MGetDataWidth.SetBelong(this.GetValue());
				}
				return r_MGetDataWidth;
			}
		}

		/// <summary>
		/// Int32 GetDataHeight()
		/// </summary>
		protected RMethod r_MGetDataHeight;
		public virtual RMethod RMGetDataHeight
		{
			get
			{
				if(r_MGetDataHeight == null)
				{
					r_MGetDataHeight = new(this, "GetDataHeight", 0);
					r_MGetDataHeight.SetBelong(this.GetValue());
				}
				return r_MGetDataHeight;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.TextureDimension GetDimension()
		/// </summary>
		protected RMethod r_MGetDimension;
		public virtual RMethod RMGetDimension
		{
			get
			{
				if(r_MGetDimension == null)
				{
					r_MGetDimension = new(this, "GetDimension", 0);
					r_MGetDimension.SetBelong(this.GetValue());
				}
				return r_MGetDimension;
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
					r_MGetNativeTexturePtr.SetBelong(this.GetValue());
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
					r_MGetNativeTextureID.SetBelong(this.GetValue());
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
					r_MIncrementUpdateCount.SetBelong(this.GetValue());
				}
				return r_MIncrementUpdateCount;
			}
		}

		/// <summary>
		/// Int32 Internal_GetActiveTextureColorSpace()
		/// </summary>
		protected RMethod r_MInternal_GetActiveTextureColorSpace;
		public virtual RMethod RMInternal_GetActiveTextureColorSpace
		{
			get
			{
				if(r_MInternal_GetActiveTextureColorSpace == null)
				{
					r_MInternal_GetActiveTextureColorSpace = new(this, "Internal_GetActiveTextureColorSpace", 0);
					r_MInternal_GetActiveTextureColorSpace.SetBelong(this.GetValue());
				}
				return r_MInternal_GetActiveTextureColorSpace;
			}
		}

		/// <summary>
		/// UnityEngine.TextureColorSpace Internal_GetStoredColorSpace()
		/// </summary>
		protected RMethod r_MInternal_GetStoredColorSpace;
		public virtual RMethod RMInternal_GetStoredColorSpace
		{
			get
			{
				if(r_MInternal_GetStoredColorSpace == null)
				{
					r_MInternal_GetStoredColorSpace = new(this, "Internal_GetStoredColorSpace", 0);
					r_MInternal_GetStoredColorSpace.SetBelong(this.GetValue());
				}
				return r_MInternal_GetStoredColorSpace;
			}
		}

		/// <summary>
		/// Void SetStreamingTextureMaterialDebugProperties()
		/// </summary>
		protected static RMethod r_MSetStreamingTextureMaterialDebugProperties;
		public static RMethod RMSetStreamingTextureMaterialDebugProperties
		{
			get
			{
				if(r_MSetStreamingTextureMaterialDebugProperties == null)
				{
					r_MSetStreamingTextureMaterialDebugProperties = new(typeof(UnityEngine.Texture), "SetStreamingTextureMaterialDebugProperties", 0);
					r_MSetStreamingTextureMaterialDebugProperties.SetBelong(null);
				}
				return r_MSetStreamingTextureMaterialDebugProperties;
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
					r_MGetPixelDataSize_Int32_Int32.SetBelong(this.GetValue());
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
					r_MGetPixelDataOffset_Int32_Int32.SetBelong(this.GetValue());
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
					r_MValidateFormat_RenderTextureFormat.SetBelong(this.GetValue());
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
					r_MValidateFormat_TextureFormat.SetBelong(this.GetValue());
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
					r_MValidateFormat_GraphicsFormat_FormatUsage.SetBelong(this.GetValue());
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
					r_MCreateNonReadableException_Texture.SetBelong(this.GetValue());
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
					r_MCreateNativeArrayLengthOverflowException.SetBelong(this.GetValue());
				}
				return r_MCreateNativeArrayLengthOverflowException;
			}
		}

		/// <summary>
		/// Void get_texelSize_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Mget_texelSize_Injected_Out_Vector2;
		public virtual RMethod RMget_texelSize_Injected_Out_Vector2
		{
			get
			{
				if(r_Mget_texelSize_Injected_Out_Vector2 == null)
				{
					r_Mget_texelSize_Injected_Out_Vector2 = new(this, "get_texelSize_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Mget_texelSize_Injected_Out_Vector2.SetBelong(this.GetValue());
				}
				return r_Mget_texelSize_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void get_imageContentsHash_Injected(UnityEngine.Hash128 ByRef)
		/// </summary>
		protected RMethod r_Mget_imageContentsHash_Injected_Out_Hash128;
		public virtual RMethod RMget_imageContentsHash_Injected_Out_Hash128
		{
			get
			{
				if(r_Mget_imageContentsHash_Injected_Out_Hash128 == null)
				{
					r_Mget_imageContentsHash_Injected_Out_Hash128 = new(this, "get_imageContentsHash_Injected", 0, typeof(UnityEngine.Hash128).MakeByRefType());
					r_Mget_imageContentsHash_Injected_Out_Hash128.SetBelong(this.GetValue());
				}
				return r_Mget_imageContentsHash_Injected_Out_Hash128;
			}
		}

		/// <summary>
		/// Void set_imageContentsHash_Injected(UnityEngine.Hash128 ByRef)
		/// </summary>
		protected RMethod r_Mset_imageContentsHash_Injected_Ref_Hash128;
		public virtual RMethod RMset_imageContentsHash_Injected_Ref_Hash128
		{
			get
			{
				if(r_Mset_imageContentsHash_Injected_Ref_Hash128 == null)
				{
					r_Mset_imageContentsHash_Injected_Ref_Hash128 = new(this, "set_imageContentsHash_Injected", 0, typeof(UnityEngine.Hash128).MakeByRefType());
					r_Mset_imageContentsHash_Injected_Ref_Hash128.SetBelong(this.GetValue());
				}
				return r_Mset_imageContentsHash_Injected_Ref_Hash128;
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
					r_MGetInstanceID.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
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

        public static void SetGlobalAnisotropicFilteringLimits(System.Int32 @forcedMin, System.Int32 @globalMax)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@forcedMin, @globalMax};
            var ___result = RMSetGlobalAnisotropicFilteringLimits_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetDataWidth()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDataWidth.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetDataHeight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDataHeight.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.Rendering.TextureDimension GetDimension()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDimension.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.TextureDimension)___result;
        }


        public virtual System.IntPtr GetNativeTexturePtr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNativeTexturePtr.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.Int32 GetNativeTextureID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNativeTextureID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void IncrementUpdateCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIncrementUpdateCount.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 Internal_GetActiveTextureColorSpace()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternal_GetActiveTextureColorSpace.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextureColorSpace Internal_GetStoredColorSpace()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternal_GetStoredColorSpace.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RTextureColorSpace(___result);
        }


        public static void SetStreamingTextureMaterialDebugProperties()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetStreamingTextureMaterialDebugProperties.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.UInt64 GetPixelDataSize(System.Int32 @mipLevel, System.Int32 @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mipLevel, @element};
            var ___result = RMGetPixelDataSize_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual System.UInt64 GetPixelDataOffset(System.Int32 @mipLevel, System.Int32 @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mipLevel, @element};
            var ___result = RMGetPixelDataOffset_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual System.Boolean ValidateFormat(UnityEngine.RenderTextureFormat @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMValidateFormat_RenderTextureFormat.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValidateFormat(UnityEngine.TextureFormat @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMValidateFormat_TextureFormat.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat @format, UnityEngine.Experimental.Rendering.FormatUsage @usage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @usage};
            var ___result = RMValidateFormat_GraphicsFormat_FormatUsage.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.UnityException CreateNonReadableException(UnityEngine.Texture @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMCreateNonReadableException_Texture.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UnityException)___result;
        }


        public virtual UnityEngine.UnityException CreateNativeArrayLengthOverflowException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateNativeArrayLengthOverflowException.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UnityException)___result;
        }


        public virtual void get_texelSize_Injected(out UnityEngine.Vector2 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_texelSize_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void get_imageContentsHash_Injected(out UnityEngine.Hash128 @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RMget_imageContentsHash_Injected_Out_Hash128.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Hash128)___parameters[0];

            
        }


        public virtual void set_imageContentsHash_Injected(ref UnityEngine.Hash128 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMset_imageContentsHash_Injected_Ref_Hash128.Invoke(___genericsType, ___parameters);
			@value = (UnityEngine.Hash128)___parameters[0];

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
