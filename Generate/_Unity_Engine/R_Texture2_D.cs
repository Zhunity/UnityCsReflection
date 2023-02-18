
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Texture2D
	/// </summary>
    public partial class RTexture2D : RMember //
    {

		/// <summary>
		/// System.Int32 streamingMipmapsPriorityMin
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FstreamingMipmapsPriorityMin;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFstreamingMipmapsPriorityMin
		{
			get
			{
				if(r_FstreamingMipmapsPriorityMin == null)
				{
					r_FstreamingMipmapsPriorityMin = new(typeof(UnityEngine.Texture2D), "streamingMipmapsPriorityMin");
					r_FstreamingMipmapsPriorityMin.SetBelong(null);
				}
				return r_FstreamingMipmapsPriorityMin;
			}
		}

		/// <summary>
		/// System.Int32 streamingMipmapsPriorityMax
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FstreamingMipmapsPriorityMax;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFstreamingMipmapsPriorityMax
		{
			get
			{
				if(r_FstreamingMipmapsPriorityMax == null)
				{
					r_FstreamingMipmapsPriorityMax = new(typeof(UnityEngine.Texture2D), "streamingMipmapsPriorityMax");
					r_FstreamingMipmapsPriorityMax.SetBelong(null);
				}
				return r_FstreamingMipmapsPriorityMax;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat format
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextureFormat r_Pformat;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextureFormat RPformat
		{
			get
			{
				if(r_Pformat == null)
				{
					r_Pformat = new(this, "format", -1);
					r_Pformat.SetBelong(this.GetValue());
				}
				return r_Pformat;
			}
		}

		/// <summary>
		/// Boolean ignoreMipmapLimit
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PignoreMipmapLimit;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPignoreMipmapLimit
		{
			get
			{
				if(r_PignoreMipmapLimit == null)
				{
					r_PignoreMipmapLimit = new(this, "ignoreMipmapLimit", -1);
					r_PignoreMipmapLimit.SetBelong(this.GetValue());
				}
				return r_PignoreMipmapLimit;
			}
		}

		/// <summary>
		/// System.String mipmapLimitGroup
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PmipmapLimitGroup;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPmipmapLimitGroup
		{
			get
			{
				if(r_PmipmapLimitGroup == null)
				{
					r_PmipmapLimitGroup = new(this, "mipmapLimitGroup", -1);
					r_PmipmapLimitGroup.SetBelong(this.GetValue());
				}
				return r_PmipmapLimitGroup;
			}
		}

		/// <summary>
		/// Int32 activeMipmapLimit
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PactiveMipmapLimit;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPactiveMipmapLimit
		{
			get
			{
				if(r_PactiveMipmapLimit == null)
				{
					r_PactiveMipmapLimit = new(this, "activeMipmapLimit", -1);
					r_PactiveMipmapLimit.SetBelong(this.GetValue());
				}
				return r_PactiveMipmapLimit;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D whiteTexture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTexture2D r_PwhiteTexture;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTexture2D RPwhiteTexture
		{
			get
			{
				if(r_PwhiteTexture == null)
				{
					r_PwhiteTexture = new(typeof(UnityEngine.Texture2D), "whiteTexture", -1);
					r_PwhiteTexture.SetBelong(null);
				}
				return r_PwhiteTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D blackTexture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTexture2D r_PblackTexture;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTexture2D RPblackTexture
		{
			get
			{
				if(r_PblackTexture == null)
				{
					r_PblackTexture = new(typeof(UnityEngine.Texture2D), "blackTexture", -1);
					r_PblackTexture.SetBelong(null);
				}
				return r_PblackTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D redTexture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTexture2D r_PredTexture;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTexture2D RPredTexture
		{
			get
			{
				if(r_PredTexture == null)
				{
					r_PredTexture = new(typeof(UnityEngine.Texture2D), "redTexture", -1);
					r_PredTexture.SetBelong(null);
				}
				return r_PredTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D grayTexture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTexture2D r_PgrayTexture;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTexture2D RPgrayTexture
		{
			get
			{
				if(r_PgrayTexture == null)
				{
					r_PgrayTexture = new(typeof(UnityEngine.Texture2D), "grayTexture", -1);
					r_PgrayTexture.SetBelong(null);
				}
				return r_PgrayTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D linearGrayTexture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTexture2D r_PlinearGrayTexture;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTexture2D RPlinearGrayTexture
		{
			get
			{
				if(r_PlinearGrayTexture == null)
				{
					r_PlinearGrayTexture = new(typeof(UnityEngine.Texture2D), "linearGrayTexture", -1);
					r_PlinearGrayTexture.SetBelong(null);
				}
				return r_PlinearGrayTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D normalTexture
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTexture2D r_PnormalTexture;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTexture2D RPnormalTexture
		{
			get
			{
				if(r_PnormalTexture == null)
				{
					r_PnormalTexture = new(typeof(UnityEngine.Texture2D), "normalTexture", -1);
					r_PnormalTexture.SetBelong(null);
				}
				return r_PnormalTexture;
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
		/// Boolean vtOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PvtOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPvtOnly
		{
			get
			{
				if(r_PvtOnly == null)
				{
					r_PvtOnly = new(this, "vtOnly", -1);
					r_PvtOnly.SetBelong(this.GetValue());
				}
				return r_PvtOnly;
			}
		}

		/// <summary>
		/// Boolean isPreProcessed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisPreProcessed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisPreProcessed
		{
			get
			{
				if(r_PisPreProcessed == null)
				{
					r_PisPreProcessed = new(this, "isPreProcessed", -1);
					r_PisPreProcessed.SetBelong(this.GetValue());
				}
				return r_PisPreProcessed;
			}
		}

		/// <summary>
		/// Boolean streamingMipmaps
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PstreamingMipmaps;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPstreamingMipmaps
		{
			get
			{
				if(r_PstreamingMipmaps == null)
				{
					r_PstreamingMipmaps = new(this, "streamingMipmaps", -1);
					r_PstreamingMipmaps.SetBelong(this.GetValue());
				}
				return r_PstreamingMipmaps;
			}
		}

		/// <summary>
		/// Int32 streamingMipmapsPriority
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PstreamingMipmapsPriority;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPstreamingMipmapsPriority
		{
			get
			{
				if(r_PstreamingMipmapsPriority == null)
				{
					r_PstreamingMipmapsPriority = new(this, "streamingMipmapsPriority", -1);
					r_PstreamingMipmapsPriority.SetBelong(this.GetValue());
				}
				return r_PstreamingMipmapsPriority;
			}
		}

		/// <summary>
		/// Int32 requestedMipmapLevel
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PrequestedMipmapLevel;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPrequestedMipmapLevel
		{
			get
			{
				if(r_PrequestedMipmapLevel == null)
				{
					r_PrequestedMipmapLevel = new(this, "requestedMipmapLevel", -1);
					r_PrequestedMipmapLevel.SetBelong(this.GetValue());
				}
				return r_PrequestedMipmapLevel;
			}
		}

		/// <summary>
		/// Int32 minimumMipmapLevel
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PminimumMipmapLevel;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPminimumMipmapLevel
		{
			get
			{
				if(r_PminimumMipmapLevel == null)
				{
					r_PminimumMipmapLevel = new(this, "minimumMipmapLevel", -1);
					r_PminimumMipmapLevel.SetBelong(this.GetValue());
				}
				return r_PminimumMipmapLevel;
			}
		}

		/// <summary>
		/// Boolean loadAllMips
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PloadAllMips;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPloadAllMips
		{
			get
			{
				if(r_PloadAllMips == null)
				{
					r_PloadAllMips = new(this, "loadAllMips", -1);
					r_PloadAllMips.SetBelong(this.GetValue());
				}
				return r_PloadAllMips;
			}
		}

		/// <summary>
		/// Int32 calculatedMipmapLevel
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PcalculatedMipmapLevel;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPcalculatedMipmapLevel
		{
			get
			{
				if(r_PcalculatedMipmapLevel == null)
				{
					r_PcalculatedMipmapLevel = new(this, "calculatedMipmapLevel", -1);
					r_PcalculatedMipmapLevel.SetBelong(this.GetValue());
				}
				return r_PcalculatedMipmapLevel;
			}
		}

		/// <summary>
		/// Int32 desiredMipmapLevel
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PdesiredMipmapLevel;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPdesiredMipmapLevel
		{
			get
			{
				if(r_PdesiredMipmapLevel == null)
				{
					r_PdesiredMipmapLevel = new(this, "desiredMipmapLevel", -1);
					r_PdesiredMipmapLevel.SetBelong(this.GetValue());
				}
				return r_PdesiredMipmapLevel;
			}
		}

		/// <summary>
		/// Int32 loadingMipmapLevel
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PloadingMipmapLevel;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPloadingMipmapLevel
		{
			get
			{
				if(r_PloadingMipmapLevel == null)
				{
					r_PloadingMipmapLevel = new(this, "loadingMipmapLevel", -1);
					r_PloadingMipmapLevel.SetBelong(this.GetValue());
				}
				return r_PloadingMipmapLevel;
			}
		}

		/// <summary>
		/// Int32 loadedMipmapLevel
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PloadedMipmapLevel;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPloadedMipmapLevel
		{
			get
			{
				if(r_PloadedMipmapLevel == null)
				{
					r_PloadedMipmapLevel = new(this, "loadedMipmapLevel", -1);
					r_PloadedMipmapLevel.SetBelong(this.GetValue());
				}
				return r_PloadedMipmapLevel;
			}
		}

		/// <summary>
		/// Boolean alphaIsTransparency
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PalphaIsTransparency;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPalphaIsTransparency
		{
			get
			{
				if(r_PalphaIsTransparency == null)
				{
					r_PalphaIsTransparency = new(this, "alphaIsTransparency", -1);
					r_PalphaIsTransparency.SetBelong(this.GetValue());
				}
				return r_PalphaIsTransparency;
			}
		}

		/// <summary>
		/// Single pixelsPerPoint
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PpixelsPerPoint;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPpixelsPerPoint
		{
			get
			{
				if(r_PpixelsPerPoint == null)
				{
					r_PpixelsPerPoint = new(this, "pixelsPerPoint", -1);
					r_PpixelsPerPoint.SetBelong(this.GetValue());
				}
				return r_PpixelsPerPoint;
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
		/// Void Compress(Boolean)
		/// </summary>
		protected RMethod r_MCompress_Boolean;
		public virtual RMethod RMCompress_Boolean
		{
			get
			{
				if(r_MCompress_Boolean == null)
				{
					r_MCompress_Boolean = new(this, "Compress", 0, typeof(System.Boolean));
					r_MCompress_Boolean.SetBelong(this.GetValue());
				}
				return r_MCompress_Boolean;
			}
		}

		/// <summary>
		/// Boolean Internal_CreateImpl(UnityEngine.Texture2D, Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, UnityEngine.Experimental.Rendering.TextureCreationFlags, IntPtr, System.String)
		/// </summary>
		protected static RMethod r_MInternal_CreateImpl_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String;
		public static RMethod RMInternal_CreateImpl_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String
		{
			get
			{
				if(r_MInternal_CreateImpl_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String == null)
				{
					r_MInternal_CreateImpl_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String = new(typeof(UnityEngine.Texture2D), "Internal_CreateImpl", 0, typeof(UnityEngine.Texture2D), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(UnityEngine.Experimental.Rendering.TextureCreationFlags), typeof(System.IntPtr), typeof(System.String));
					r_MInternal_CreateImpl_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String.SetBelong(null);
				}
				return r_MInternal_CreateImpl_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String;
			}
		}

		/// <summary>
		/// Void Internal_Create(UnityEngine.Texture2D, Int32, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, UnityEngine.Experimental.Rendering.TextureCreationFlags, IntPtr, System.String)
		/// </summary>
		protected static RMethod r_MInternal_Create_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String;
		public static RMethod RMInternal_Create_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String
		{
			get
			{
				if(r_MInternal_Create_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String == null)
				{
					r_MInternal_Create_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String = new(typeof(UnityEngine.Texture2D), "Internal_Create", 0, typeof(UnityEngine.Texture2D), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(UnityEngine.Experimental.Rendering.TextureCreationFlags), typeof(System.IntPtr), typeof(System.String));
					r_MInternal_Create_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String.SetBelong(null);
				}
				return r_MInternal_Create_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String;
			}
		}

		/// <summary>
		/// Void ApplyImpl(Boolean, Boolean)
		/// </summary>
		protected RMethod r_MApplyImpl_Boolean_Boolean;
		public virtual RMethod RMApplyImpl_Boolean_Boolean
		{
			get
			{
				if(r_MApplyImpl_Boolean_Boolean == null)
				{
					r_MApplyImpl_Boolean_Boolean = new(this, "ApplyImpl", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_MApplyImpl_Boolean_Boolean.SetBelong(this.GetValue());
				}
				return r_MApplyImpl_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Boolean ReinitializeImpl(Int32, Int32)
		/// </summary>
		protected RMethod r_MReinitializeImpl_Int32_Int32;
		public virtual RMethod RMReinitializeImpl_Int32_Int32
		{
			get
			{
				if(r_MReinitializeImpl_Int32_Int32 == null)
				{
					r_MReinitializeImpl_Int32_Int32 = new(this, "ReinitializeImpl", 0, typeof(System.Int32), typeof(System.Int32));
					r_MReinitializeImpl_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MReinitializeImpl_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetPixelImpl(Int32, Int32, Int32, Int32, UnityEngine.Color)
		/// </summary>
		protected RMethod r_MSetPixelImpl_Int32_Int32_Int32_Int32_Color;
		public virtual RMethod RMSetPixelImpl_Int32_Int32_Int32_Int32_Color
		{
			get
			{
				if(r_MSetPixelImpl_Int32_Int32_Int32_Int32_Color == null)
				{
					r_MSetPixelImpl_Int32_Int32_Int32_Int32_Color = new(this, "SetPixelImpl", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color));
					r_MSetPixelImpl_Int32_Int32_Int32_Int32_Color.SetBelong(this.GetValue());
				}
				return r_MSetPixelImpl_Int32_Int32_Int32_Int32_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetPixelImpl(Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MGetPixelImpl_Int32_Int32_Int32_Int32;
		public virtual RMethod RMGetPixelImpl_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MGetPixelImpl_Int32_Int32_Int32_Int32 == null)
				{
					r_MGetPixelImpl_Int32_Int32_Int32_Int32 = new(this, "GetPixelImpl", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MGetPixelImpl_Int32_Int32_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MGetPixelImpl_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetPixelBilinearImpl(Int32, Int32, Single, Single)
		/// </summary>
		protected RMethod r_MGetPixelBilinearImpl_Int32_Int32_Single_Single;
		public virtual RMethod RMGetPixelBilinearImpl_Int32_Int32_Single_Single
		{
			get
			{
				if(r_MGetPixelBilinearImpl_Int32_Int32_Single_Single == null)
				{
					r_MGetPixelBilinearImpl_Int32_Int32_Single_Single = new(this, "GetPixelBilinearImpl", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Single), typeof(System.Single));
					r_MGetPixelBilinearImpl_Int32_Int32_Single_Single.SetBelong(this.GetValue());
				}
				return r_MGetPixelBilinearImpl_Int32_Int32_Single_Single;
			}
		}

		/// <summary>
		/// Boolean ReinitializeWithFormatImpl(Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, Boolean)
		/// </summary>
		protected RMethod r_MReinitializeWithFormatImpl_Int32_Int32_GraphicsFormat_Boolean;
		public virtual RMethod RMReinitializeWithFormatImpl_Int32_Int32_GraphicsFormat_Boolean
		{
			get
			{
				if(r_MReinitializeWithFormatImpl_Int32_Int32_GraphicsFormat_Boolean == null)
				{
					r_MReinitializeWithFormatImpl_Int32_Int32_GraphicsFormat_Boolean = new(this, "ReinitializeWithFormatImpl", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Boolean));
					r_MReinitializeWithFormatImpl_Int32_Int32_GraphicsFormat_Boolean.SetBelong(this.GetValue());
				}
				return r_MReinitializeWithFormatImpl_Int32_Int32_GraphicsFormat_Boolean;
			}
		}

		/// <summary>
		/// Boolean ReinitializeWithTextureFormatImpl(Int32, Int32, UnityEngine.TextureFormat, Boolean)
		/// </summary>
		protected RMethod r_MReinitializeWithTextureFormatImpl_Int32_Int32_TextureFormat_Boolean;
		public virtual RMethod RMReinitializeWithTextureFormatImpl_Int32_Int32_TextureFormat_Boolean
		{
			get
			{
				if(r_MReinitializeWithTextureFormatImpl_Int32_Int32_TextureFormat_Boolean == null)
				{
					r_MReinitializeWithTextureFormatImpl_Int32_Int32_TextureFormat_Boolean = new(this, "ReinitializeWithTextureFormatImpl", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextureFormat), typeof(System.Boolean));
					r_MReinitializeWithTextureFormatImpl_Int32_Int32_TextureFormat_Boolean.SetBelong(this.GetValue());
				}
				return r_MReinitializeWithTextureFormatImpl_Int32_Int32_TextureFormat_Boolean;
			}
		}

		/// <summary>
		/// Void ReadPixelsImpl(UnityEngine.Rect, Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_MReadPixelsImpl_Rect_Int32_Int32_Boolean;
		public virtual RMethod RMReadPixelsImpl_Rect_Int32_Int32_Boolean
		{
			get
			{
				if(r_MReadPixelsImpl_Rect_Int32_Int32_Boolean == null)
				{
					r_MReadPixelsImpl_Rect_Int32_Int32_Boolean = new(this, "ReadPixelsImpl", 0, typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_MReadPixelsImpl_Rect_Int32_Int32_Boolean.SetBelong(this.GetValue());
				}
				return r_MReadPixelsImpl_Rect_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetPixelsImpl(Int32, Int32, Int32, Int32, UnityEngine.Color[], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetPixelsImpl_Int32_Int32_Int32_Int32_ColorArray_Int32_Int32;
		public virtual RMethod RMSetPixelsImpl_Int32_Int32_Int32_Int32_ColorArray_Int32_Int32
		{
			get
			{
				if(r_MSetPixelsImpl_Int32_Int32_Int32_Int32_ColorArray_Int32_Int32 == null)
				{
					r_MSetPixelsImpl_Int32_Int32_Int32_Int32_ColorArray_Int32_Int32 = new(this, "SetPixelsImpl", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MSetPixelsImpl_Int32_Int32_Int32_Int32_ColorArray_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MSetPixelsImpl_Int32_Int32_Int32_Int32_ColorArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean LoadRawTextureDataImpl(IntPtr, UInt64)
		/// </summary>
		protected RMethod r_MLoadRawTextureDataImpl_IntPtr_UInt64;
		public virtual RMethod RMLoadRawTextureDataImpl_IntPtr_UInt64
		{
			get
			{
				if(r_MLoadRawTextureDataImpl_IntPtr_UInt64 == null)
				{
					r_MLoadRawTextureDataImpl_IntPtr_UInt64 = new(this, "LoadRawTextureDataImpl", 0, typeof(System.IntPtr), typeof(System.UInt64));
					r_MLoadRawTextureDataImpl_IntPtr_UInt64.SetBelong(this.GetValue());
				}
				return r_MLoadRawTextureDataImpl_IntPtr_UInt64;
			}
		}

		/// <summary>
		/// Boolean LoadRawTextureDataImplArray(Byte[])
		/// </summary>
		protected RMethod r_MLoadRawTextureDataImplArray_ByteArray;
		public virtual RMethod RMLoadRawTextureDataImplArray_ByteArray
		{
			get
			{
				if(r_MLoadRawTextureDataImplArray_ByteArray == null)
				{
					r_MLoadRawTextureDataImplArray_ByteArray = new(this, "LoadRawTextureDataImplArray", 0, typeof(System.Byte).MakeArrayType());
					r_MLoadRawTextureDataImplArray_ByteArray.SetBelong(this.GetValue());
				}
				return r_MLoadRawTextureDataImplArray_ByteArray;
			}
		}

		/// <summary>
		/// Boolean SetPixelDataImplArray(System.Array, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetPixelDataImplArray_Array_Int32_Int32_Int32_Int32;
		public virtual RMethod RMSetPixelDataImplArray_Array_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MSetPixelDataImplArray_Array_Int32_Int32_Int32_Int32 == null)
				{
					r_MSetPixelDataImplArray_Array_Int32_Int32_Int32_Int32 = new(this, "SetPixelDataImplArray", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MSetPixelDataImplArray_Array_Int32_Int32_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MSetPixelDataImplArray_Array_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean SetPixelDataImpl(IntPtr, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32;
		public virtual RMethod RMSetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MSetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32 == null)
				{
					r_MSetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32 = new(this, "SetPixelDataImpl", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MSetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MSetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// IntPtr GetWritableImageData(Int32)
		/// </summary>
		protected RMethod r_MGetWritableImageData_Int32;
		public virtual RMethod RMGetWritableImageData_Int32
		{
			get
			{
				if(r_MGetWritableImageData_Int32 == null)
				{
					r_MGetWritableImageData_Int32 = new(this, "GetWritableImageData", 0, typeof(System.Int32));
					r_MGetWritableImageData_Int32.SetBelong(this.GetValue());
				}
				return r_MGetWritableImageData_Int32;
			}
		}

		/// <summary>
		/// UInt64 GetRawImageDataSize()
		/// </summary>
		protected RMethod r_MGetRawImageDataSize;
		public virtual RMethod RMGetRawImageDataSize
		{
			get
			{
				if(r_MGetRawImageDataSize == null)
				{
					r_MGetRawImageDataSize = new(this, "GetRawImageDataSize", 0);
					r_MGetRawImageDataSize.SetBelong(this.GetValue());
				}
				return r_MGetRawImageDataSize;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetSafetyHandle(UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_MGetSafetyHandle_Texture2D;
		public static RMethod RMGetSafetyHandle_Texture2D
		{
			get
			{
				if(r_MGetSafetyHandle_Texture2D == null)
				{
					r_MGetSafetyHandle_Texture2D = new(typeof(UnityEngine.Texture2D), "GetSafetyHandle", 0, typeof(UnityEngine.Texture2D));
					r_MGetSafetyHandle_Texture2D.SetBelong(null);
				}
				return r_MGetSafetyHandle_Texture2D;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetSafetyHandleForSlice(Int32)
		/// </summary>
		protected RMethod r_MGetSafetyHandleForSlice_Int32;
		public virtual RMethod RMGetSafetyHandleForSlice_Int32
		{
			get
			{
				if(r_MGetSafetyHandleForSlice_Int32 == null)
				{
					r_MGetSafetyHandleForSlice_Int32 = new(this, "GetSafetyHandleForSlice", 0, typeof(System.Int32));
					r_MGetSafetyHandleForSlice_Int32.SetBelong(this.GetValue());
				}
				return r_MGetSafetyHandleForSlice_Int32;
			}
		}

		/// <summary>
		/// Void GenerateAtlasImpl(UnityEngine.Vector2[], Int32, Int32, UnityEngine.Rect[])
		/// </summary>
		protected static RMethod r_MGenerateAtlasImpl_Vector2Array_Int32_Int32_RectArray;
		public static RMethod RMGenerateAtlasImpl_Vector2Array_Int32_Int32_RectArray
		{
			get
			{
				if(r_MGenerateAtlasImpl_Vector2Array_Int32_Int32_RectArray == null)
				{
					r_MGenerateAtlasImpl_Vector2Array_Int32_Int32_RectArray = new(typeof(UnityEngine.Texture2D), "GenerateAtlasImpl", 0, typeof(UnityEngine.Vector2).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rect).MakeArrayType());
					r_MGenerateAtlasImpl_Vector2Array_Int32_Int32_RectArray.SetBelong(null);
				}
				return r_MGenerateAtlasImpl_Vector2Array_Int32_Int32_RectArray;
			}
		}

		/// <summary>
		/// Void ClearRequestedMipmapLevel()
		/// </summary>
		protected RMethod r_MClearRequestedMipmapLevel;
		public virtual RMethod RMClearRequestedMipmapLevel
		{
			get
			{
				if(r_MClearRequestedMipmapLevel == null)
				{
					r_MClearRequestedMipmapLevel = new(this, "ClearRequestedMipmapLevel", 0);
					r_MClearRequestedMipmapLevel.SetBelong(this.GetValue());
				}
				return r_MClearRequestedMipmapLevel;
			}
		}

		/// <summary>
		/// Boolean IsRequestedMipmapLevelLoaded()
		/// </summary>
		protected RMethod r_MIsRequestedMipmapLevelLoaded;
		public virtual RMethod RMIsRequestedMipmapLevelLoaded
		{
			get
			{
				if(r_MIsRequestedMipmapLevelLoaded == null)
				{
					r_MIsRequestedMipmapLevelLoaded = new(this, "IsRequestedMipmapLevelLoaded", 0);
					r_MIsRequestedMipmapLevelLoaded.SetBelong(this.GetValue());
				}
				return r_MIsRequestedMipmapLevelLoaded;
			}
		}

		/// <summary>
		/// Void ClearMinimumMipmapLevel()
		/// </summary>
		protected RMethod r_MClearMinimumMipmapLevel;
		public virtual RMethod RMClearMinimumMipmapLevel
		{
			get
			{
				if(r_MClearMinimumMipmapLevel == null)
				{
					r_MClearMinimumMipmapLevel = new(this, "ClearMinimumMipmapLevel", 0);
					r_MClearMinimumMipmapLevel.SetBelong(this.GetValue());
				}
				return r_MClearMinimumMipmapLevel;
			}
		}

		/// <summary>
		/// Void UpdateExternalTexture(IntPtr)
		/// </summary>
		protected RMethod r_MUpdateExternalTexture_IntPtr;
		public virtual RMethod RMUpdateExternalTexture_IntPtr
		{
			get
			{
				if(r_MUpdateExternalTexture_IntPtr == null)
				{
					r_MUpdateExternalTexture_IntPtr = new(this, "UpdateExternalTexture", 0, typeof(System.IntPtr));
					r_MUpdateExternalTexture_IntPtr.SetBelong(this.GetValue());
				}
				return r_MUpdateExternalTexture_IntPtr;
			}
		}

		/// <summary>
		/// Void SetAllPixels32(UnityEngine.Color32[], Int32)
		/// </summary>
		protected RMethod r_MSetAllPixels32_Color32Array_Int32;
		public virtual RMethod RMSetAllPixels32_Color32Array_Int32
		{
			get
			{
				if(r_MSetAllPixels32_Color32Array_Int32 == null)
				{
					r_MSetAllPixels32_Color32Array_Int32 = new(this, "SetAllPixels32", 0, typeof(UnityEngine.Color32).MakeArrayType(), typeof(System.Int32));
					r_MSetAllPixels32_Color32Array_Int32.SetBelong(this.GetValue());
				}
				return r_MSetAllPixels32_Color32Array_Int32;
			}
		}

		/// <summary>
		/// Void SetBlockOfPixels32(Int32, Int32, Int32, Int32, UnityEngine.Color32[], Int32)
		/// </summary>
		protected RMethod r_MSetBlockOfPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32;
		public virtual RMethod RMSetBlockOfPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32
		{
			get
			{
				if(r_MSetBlockOfPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32 == null)
				{
					r_MSetBlockOfPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32 = new(this, "SetBlockOfPixels32", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color32).MakeArrayType(), typeof(System.Int32));
					r_MSetBlockOfPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32.SetBelong(this.GetValue());
				}
				return r_MSetBlockOfPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32;
			}
		}

		/// <summary>
		/// Byte[] GetRawTextureData()
		/// </summary>
		protected RMethod r_MGetRawTextureData;
		public virtual RMethod RMGetRawTextureData
		{
			get
			{
				if(r_MGetRawTextureData == null)
				{
					r_MGetRawTextureData = new(this, "GetRawTextureData", 0);
					r_MGetRawTextureData.SetBelong(this.GetValue());
				}
				return r_MGetRawTextureData;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] GetPixels(Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MGetPixels_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RMGetPixels_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MGetPixels_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_MGetPixels_Int32_Int32_Int32_Int32_Int32 = new(this, "GetPixels", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MGetPixels_Int32_Int32_Int32_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MGetPixels_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] GetPixels(Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MGetPixels_Int32_Int32_Int32_Int32;
		public virtual RMethod RMGetPixels_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MGetPixels_Int32_Int32_Int32_Int32 == null)
				{
					r_MGetPixels_Int32_Int32_Int32_Int32 = new(this, "GetPixels", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MGetPixels_Int32_Int32_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MGetPixels_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color32[] GetPixels32(Int32)
		/// </summary>
		protected RMethod r_MGetPixels32_Int32;
		public virtual RMethod RMGetPixels32_Int32
		{
			get
			{
				if(r_MGetPixels32_Int32 == null)
				{
					r_MGetPixels32_Int32 = new(this, "GetPixels32", 0, typeof(System.Int32));
					r_MGetPixels32_Int32.SetBelong(this.GetValue());
				}
				return r_MGetPixels32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color32[] GetPixels32()
		/// </summary>
		protected RMethod r_MGetPixels32;
		public virtual RMethod RMGetPixels32
		{
			get
			{
				if(r_MGetPixels32 == null)
				{
					r_MGetPixels32 = new(this, "GetPixels32", 0);
					r_MGetPixels32.SetBelong(this.GetValue());
				}
				return r_MGetPixels32;
			}
		}

		/// <summary>
		/// UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[], Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_MPackTextures_Texture2DArray_Int32_Int32_Boolean;
		public virtual RMethod RMPackTextures_Texture2DArray_Int32_Int32_Boolean
		{
			get
			{
				if(r_MPackTextures_Texture2DArray_Int32_Int32_Boolean == null)
				{
					r_MPackTextures_Texture2DArray_Int32_Int32_Boolean = new(this, "PackTextures", 0, typeof(UnityEngine.Texture2D).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_MPackTextures_Texture2DArray_Int32_Int32_Boolean.SetBelong(this.GetValue());
				}
				return r_MPackTextures_Texture2DArray_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[], Int32, Int32)
		/// </summary>
		protected RMethod r_MPackTextures_Texture2DArray_Int32_Int32;
		public virtual RMethod RMPackTextures_Texture2DArray_Int32_Int32
		{
			get
			{
				if(r_MPackTextures_Texture2DArray_Int32_Int32 == null)
				{
					r_MPackTextures_Texture2DArray_Int32_Int32 = new(this, "PackTextures", 0, typeof(UnityEngine.Texture2D).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MPackTextures_Texture2DArray_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MPackTextures_Texture2DArray_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[], Int32)
		/// </summary>
		protected RMethod r_MPackTextures_Texture2DArray_Int32;
		public virtual RMethod RMPackTextures_Texture2DArray_Int32
		{
			get
			{
				if(r_MPackTextures_Texture2DArray_Int32 == null)
				{
					r_MPackTextures_Texture2DArray_Int32 = new(this, "PackTextures", 0, typeof(UnityEngine.Texture2D).MakeArrayType(), typeof(System.Int32));
					r_MPackTextures_Texture2DArray_Int32.SetBelong(this.GetValue());
				}
				return r_MPackTextures_Texture2DArray_Int32;
			}
		}

		/// <summary>
		/// Boolean ValidateFormat(UnityEngine.TextureFormat, Int32, Int32)
		/// </summary>
		protected RMethod r_MValidateFormat_TextureFormat_Int32_Int32;
		public virtual RMethod RMValidateFormat_TextureFormat_Int32_Int32
		{
			get
			{
				if(r_MValidateFormat_TextureFormat_Int32_Int32 == null)
				{
					r_MValidateFormat_TextureFormat_Int32_Int32 = new(this, "ValidateFormat", 0, typeof(UnityEngine.TextureFormat), typeof(System.Int32), typeof(System.Int32));
					r_MValidateFormat_TextureFormat_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MValidateFormat_TextureFormat_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat, Int32, Int32)
		/// </summary>
		protected RMethod r_MValidateFormat_GraphicsFormat_Int32_Int32;
		public virtual RMethod RMValidateFormat_GraphicsFormat_Int32_Int32
		{
			get
			{
				if(r_MValidateFormat_GraphicsFormat_Int32_Int32 == null)
				{
					r_MValidateFormat_GraphicsFormat_Int32_Int32 = new(this, "ValidateFormat", 0, typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32), typeof(System.Int32));
					r_MValidateFormat_GraphicsFormat_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MValidateFormat_GraphicsFormat_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D CreateExternalTexture(Int32, Int32, UnityEngine.TextureFormat, Boolean, Boolean, IntPtr)
		/// </summary>
		protected static RMethod r_MCreateExternalTexture_Int32_Int32_TextureFormat_Boolean_Boolean_IntPtr;
		public static RMethod RMCreateExternalTexture_Int32_Int32_TextureFormat_Boolean_Boolean_IntPtr
		{
			get
			{
				if(r_MCreateExternalTexture_Int32_Int32_TextureFormat_Boolean_Boolean_IntPtr == null)
				{
					r_MCreateExternalTexture_Int32_Int32_TextureFormat_Boolean_Boolean_IntPtr = new(typeof(UnityEngine.Texture2D), "CreateExternalTexture", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextureFormat), typeof(System.Boolean), typeof(System.Boolean), typeof(System.IntPtr));
					r_MCreateExternalTexture_Int32_Int32_TextureFormat_Boolean_Boolean_IntPtr.SetBelong(null);
				}
				return r_MCreateExternalTexture_Int32_Int32_TextureFormat_Boolean_Boolean_IntPtr;
			}
		}

		/// <summary>
		/// Void SetPixel(Int32, Int32, UnityEngine.Color)
		/// </summary>
		protected RMethod r_MSetPixel_Int32_Int32_Color;
		public virtual RMethod RMSetPixel_Int32_Int32_Color
		{
			get
			{
				if(r_MSetPixel_Int32_Int32_Color == null)
				{
					r_MSetPixel_Int32_Int32_Color = new(this, "SetPixel", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color));
					r_MSetPixel_Int32_Int32_Color.SetBelong(this.GetValue());
				}
				return r_MSetPixel_Int32_Int32_Color;
			}
		}

		/// <summary>
		/// Void SetPixel(Int32, Int32, UnityEngine.Color, Int32)
		/// </summary>
		protected RMethod r_MSetPixel_Int32_Int32_Color_Int32;
		public virtual RMethod RMSetPixel_Int32_Int32_Color_Int32
		{
			get
			{
				if(r_MSetPixel_Int32_Int32_Color_Int32 == null)
				{
					r_MSetPixel_Int32_Int32_Color_Int32 = new(this, "SetPixel", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color), typeof(System.Int32));
					r_MSetPixel_Int32_Int32_Color_Int32.SetBelong(this.GetValue());
				}
				return r_MSetPixel_Int32_Int32_Color_Int32;
			}
		}

		/// <summary>
		/// Void SetPixels(Int32, Int32, Int32, Int32, UnityEngine.Color[], Int32)
		/// </summary>
		protected RMethod r_MSetPixels_Int32_Int32_Int32_Int32_ColorArray_Int32;
		public virtual RMethod RMSetPixels_Int32_Int32_Int32_Int32_ColorArray_Int32
		{
			get
			{
				if(r_MSetPixels_Int32_Int32_Int32_Int32_ColorArray_Int32 == null)
				{
					r_MSetPixels_Int32_Int32_Int32_Int32_ColorArray_Int32 = new(this, "SetPixels", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color).MakeArrayType(), typeof(System.Int32));
					r_MSetPixels_Int32_Int32_Int32_Int32_ColorArray_Int32.SetBelong(this.GetValue());
				}
				return r_MSetPixels_Int32_Int32_Int32_Int32_ColorArray_Int32;
			}
		}

		/// <summary>
		/// Void SetPixels(Int32, Int32, Int32, Int32, UnityEngine.Color[])
		/// </summary>
		protected RMethod r_MSetPixels_Int32_Int32_Int32_Int32_ColorArray;
		public virtual RMethod RMSetPixels_Int32_Int32_Int32_Int32_ColorArray
		{
			get
			{
				if(r_MSetPixels_Int32_Int32_Int32_Int32_ColorArray == null)
				{
					r_MSetPixels_Int32_Int32_Int32_Int32_ColorArray = new(this, "SetPixels", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color).MakeArrayType());
					r_MSetPixels_Int32_Int32_Int32_Int32_ColorArray.SetBelong(this.GetValue());
				}
				return r_MSetPixels_Int32_Int32_Int32_Int32_ColorArray;
			}
		}

		/// <summary>
		/// Void SetPixels(UnityEngine.Color[], Int32)
		/// </summary>
		protected RMethod r_MSetPixels_ColorArray_Int32;
		public virtual RMethod RMSetPixels_ColorArray_Int32
		{
			get
			{
				if(r_MSetPixels_ColorArray_Int32 == null)
				{
					r_MSetPixels_ColorArray_Int32 = new(this, "SetPixels", 0, typeof(UnityEngine.Color).MakeArrayType(), typeof(System.Int32));
					r_MSetPixels_ColorArray_Int32.SetBelong(this.GetValue());
				}
				return r_MSetPixels_ColorArray_Int32;
			}
		}

		/// <summary>
		/// Void SetPixels(UnityEngine.Color[])
		/// </summary>
		protected RMethod r_MSetPixels_ColorArray;
		public virtual RMethod RMSetPixels_ColorArray
		{
			get
			{
				if(r_MSetPixels_ColorArray == null)
				{
					r_MSetPixels_ColorArray = new(this, "SetPixels", 0, typeof(UnityEngine.Color).MakeArrayType());
					r_MSetPixels_ColorArray.SetBelong(this.GetValue());
				}
				return r_MSetPixels_ColorArray;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetPixel(Int32, Int32)
		/// </summary>
		protected RMethod r_MGetPixel_Int32_Int32;
		public virtual RMethod RMGetPixel_Int32_Int32
		{
			get
			{
				if(r_MGetPixel_Int32_Int32 == null)
				{
					r_MGetPixel_Int32_Int32 = new(this, "GetPixel", 0, typeof(System.Int32), typeof(System.Int32));
					r_MGetPixel_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MGetPixel_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetPixel(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MGetPixel_Int32_Int32_Int32;
		public virtual RMethod RMGetPixel_Int32_Int32_Int32
		{
			get
			{
				if(r_MGetPixel_Int32_Int32_Int32 == null)
				{
					r_MGetPixel_Int32_Int32_Int32 = new(this, "GetPixel", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MGetPixel_Int32_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MGetPixel_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetPixelBilinear(Single, Single)
		/// </summary>
		protected RMethod r_MGetPixelBilinear_Single_Single;
		public virtual RMethod RMGetPixelBilinear_Single_Single
		{
			get
			{
				if(r_MGetPixelBilinear_Single_Single == null)
				{
					r_MGetPixelBilinear_Single_Single = new(this, "GetPixelBilinear", 0, typeof(System.Single), typeof(System.Single));
					r_MGetPixelBilinear_Single_Single.SetBelong(this.GetValue());
				}
				return r_MGetPixelBilinear_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetPixelBilinear(Single, Single, Int32)
		/// </summary>
		protected RMethod r_MGetPixelBilinear_Single_Single_Int32;
		public virtual RMethod RMGetPixelBilinear_Single_Single_Int32
		{
			get
			{
				if(r_MGetPixelBilinear_Single_Single_Int32 == null)
				{
					r_MGetPixelBilinear_Single_Single_Int32 = new(this, "GetPixelBilinear", 0, typeof(System.Single), typeof(System.Single), typeof(System.Int32));
					r_MGetPixelBilinear_Single_Single_Int32.SetBelong(this.GetValue());
				}
				return r_MGetPixelBilinear_Single_Single_Int32;
			}
		}

		/// <summary>
		/// Void LoadRawTextureData(IntPtr, Int32)
		/// </summary>
		protected RMethod r_MLoadRawTextureData_IntPtr_Int32;
		public virtual RMethod RMLoadRawTextureData_IntPtr_Int32
		{
			get
			{
				if(r_MLoadRawTextureData_IntPtr_Int32 == null)
				{
					r_MLoadRawTextureData_IntPtr_Int32 = new(this, "LoadRawTextureData", 0, typeof(System.IntPtr), typeof(System.Int32));
					r_MLoadRawTextureData_IntPtr_Int32.SetBelong(this.GetValue());
				}
				return r_MLoadRawTextureData_IntPtr_Int32;
			}
		}

		/// <summary>
		/// Void LoadRawTextureData(Byte[])
		/// </summary>
		protected RMethod r_MLoadRawTextureData_ByteArray;
		public virtual RMethod RMLoadRawTextureData_ByteArray
		{
			get
			{
				if(r_MLoadRawTextureData_ByteArray == null)
				{
					r_MLoadRawTextureData_ByteArray = new(this, "LoadRawTextureData", 0, typeof(System.Byte).MakeArrayType());
					r_MLoadRawTextureData_ByteArray.SetBelong(this.GetValue());
				}
				return r_MLoadRawTextureData_ByteArray;
			}
		}

		/// <summary>
		/// Void LoadRawTextureData[T](Unity.Collections.NativeArray`1[T])
		/// </summary>
		protected RMethod r_MLoadRawTextureData_GT_NativeArray_d_T_p_;
		public virtual RMethod RMLoadRawTextureData_GT_NativeArray_d_T_p_
		{
			get
			{
				if(r_MLoadRawTextureData_GT_NativeArray_d_T_p_ == null)
				{
					r_MLoadRawTextureData_GT_NativeArray_d_T_p_ = new(this, "LoadRawTextureData", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_MLoadRawTextureData_GT_NativeArray_d_T_p_.SetBelong(this.GetValue());
				}
				return r_MLoadRawTextureData_GT_NativeArray_d_T_p_;
			}
		}

		/// <summary>
		/// Void SetPixelData[T](T[], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetPixelData_GT_TArray_Int32_Int32;
		public virtual RMethod RMSetPixelData_GT_TArray_Int32_Int32
		{
			get
			{
				if(r_MSetPixelData_GT_TArray_Int32_Int32 == null)
				{
					r_MSetPixelData_GT_TArray_Int32_Int32 = new(this, "SetPixelData", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_MSetPixelData_GT_TArray_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MSetPixelData_GT_TArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetPixelData[T](Unity.Collections.NativeArray`1[T], Int32, Int32)
		/// </summary>
		protected RMethod r_MSetPixelData_GT_NativeArray_d_T_p__Int32_Int32;
		public virtual RMethod RMSetPixelData_GT_NativeArray_d_T_p__Int32_Int32
		{
			get
			{
				if(r_MSetPixelData_GT_NativeArray_d_T_p__Int32_Int32 == null)
				{
					r_MSetPixelData_GT_NativeArray_d_T_p__Int32_Int32 = new(this, "SetPixelData", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(System.Int32));
					r_MSetPixelData_GT_NativeArray_d_T_p__Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MSetPixelData_GT_NativeArray_d_T_p__Int32_Int32;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[T] GetPixelData[T](Int32)
		/// </summary>
		protected RMethod r_MGetPixelData_GT_Int32;
		public virtual RMethod RMGetPixelData_GT_Int32
		{
			get
			{
				if(r_MGetPixelData_GT_Int32 == null)
				{
					r_MGetPixelData_GT_Int32 = new(this, "GetPixelData", 1, typeof(System.Int32));
					r_MGetPixelData_GT_Int32.SetBelong(this.GetValue());
				}
				return r_MGetPixelData_GT_Int32;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[T] GetRawTextureData[T]()
		/// </summary>
		protected RMethod r_MGetRawTextureData_GT;
		public virtual RMethod RMGetRawTextureData_GT
		{
			get
			{
				if(r_MGetRawTextureData_GT == null)
				{
					r_MGetRawTextureData_GT = new(this, "GetRawTextureData", 1);
					r_MGetRawTextureData_GT.SetBelong(this.GetValue());
				}
				return r_MGetRawTextureData_GT;
			}
		}

		/// <summary>
		/// Void Apply(Boolean, Boolean)
		/// </summary>
		protected RMethod r_MApply_Boolean_Boolean;
		public virtual RMethod RMApply_Boolean_Boolean
		{
			get
			{
				if(r_MApply_Boolean_Boolean == null)
				{
					r_MApply_Boolean_Boolean = new(this, "Apply", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_MApply_Boolean_Boolean.SetBelong(this.GetValue());
				}
				return r_MApply_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void Apply(Boolean)
		/// </summary>
		protected RMethod r_MApply_Boolean;
		public virtual RMethod RMApply_Boolean
		{
			get
			{
				if(r_MApply_Boolean == null)
				{
					r_MApply_Boolean = new(this, "Apply", 0, typeof(System.Boolean));
					r_MApply_Boolean.SetBelong(this.GetValue());
				}
				return r_MApply_Boolean;
			}
		}

		/// <summary>
		/// Void Apply()
		/// </summary>
		protected RMethod r_MApply;
		public virtual RMethod RMApply
		{
			get
			{
				if(r_MApply == null)
				{
					r_MApply = new(this, "Apply", 0);
					r_MApply.SetBelong(this.GetValue());
				}
				return r_MApply;
			}
		}

		/// <summary>
		/// Boolean Reinitialize(Int32, Int32)
		/// </summary>
		protected RMethod r_MReinitialize_Int32_Int32;
		public virtual RMethod RMReinitialize_Int32_Int32
		{
			get
			{
				if(r_MReinitialize_Int32_Int32 == null)
				{
					r_MReinitialize_Int32_Int32 = new(this, "Reinitialize", 0, typeof(System.Int32), typeof(System.Int32));
					r_MReinitialize_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MReinitialize_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean Reinitialize(Int32, Int32, UnityEngine.TextureFormat, Boolean)
		/// </summary>
		protected RMethod r_MReinitialize_Int32_Int32_TextureFormat_Boolean;
		public virtual RMethod RMReinitialize_Int32_Int32_TextureFormat_Boolean
		{
			get
			{
				if(r_MReinitialize_Int32_Int32_TextureFormat_Boolean == null)
				{
					r_MReinitialize_Int32_Int32_TextureFormat_Boolean = new(this, "Reinitialize", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextureFormat), typeof(System.Boolean));
					r_MReinitialize_Int32_Int32_TextureFormat_Boolean.SetBelong(this.GetValue());
				}
				return r_MReinitialize_Int32_Int32_TextureFormat_Boolean;
			}
		}

		/// <summary>
		/// Boolean Reinitialize(Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, Boolean)
		/// </summary>
		protected RMethod r_MReinitialize_Int32_Int32_GraphicsFormat_Boolean;
		public virtual RMethod RMReinitialize_Int32_Int32_GraphicsFormat_Boolean
		{
			get
			{
				if(r_MReinitialize_Int32_Int32_GraphicsFormat_Boolean == null)
				{
					r_MReinitialize_Int32_Int32_GraphicsFormat_Boolean = new(this, "Reinitialize", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Boolean));
					r_MReinitialize_Int32_Int32_GraphicsFormat_Boolean.SetBelong(this.GetValue());
				}
				return r_MReinitialize_Int32_Int32_GraphicsFormat_Boolean;
			}
		}

		/// <summary>
		/// Boolean Resize(Int32, Int32)
		/// </summary>
		protected RMethod r_MResize_Int32_Int32;
		public virtual RMethod RMResize_Int32_Int32
		{
			get
			{
				if(r_MResize_Int32_Int32 == null)
				{
					r_MResize_Int32_Int32 = new(this, "Resize", 0, typeof(System.Int32), typeof(System.Int32));
					r_MResize_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MResize_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean Resize(Int32, Int32, UnityEngine.TextureFormat, Boolean)
		/// </summary>
		protected RMethod r_MResize_Int32_Int32_TextureFormat_Boolean;
		public virtual RMethod RMResize_Int32_Int32_TextureFormat_Boolean
		{
			get
			{
				if(r_MResize_Int32_Int32_TextureFormat_Boolean == null)
				{
					r_MResize_Int32_Int32_TextureFormat_Boolean = new(this, "Resize", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.TextureFormat), typeof(System.Boolean));
					r_MResize_Int32_Int32_TextureFormat_Boolean.SetBelong(this.GetValue());
				}
				return r_MResize_Int32_Int32_TextureFormat_Boolean;
			}
		}

		/// <summary>
		/// Boolean Resize(Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, Boolean)
		/// </summary>
		protected RMethod r_MResize_Int32_Int32_GraphicsFormat_Boolean;
		public virtual RMethod RMResize_Int32_Int32_GraphicsFormat_Boolean
		{
			get
			{
				if(r_MResize_Int32_Int32_GraphicsFormat_Boolean == null)
				{
					r_MResize_Int32_Int32_GraphicsFormat_Boolean = new(this, "Resize", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Boolean));
					r_MResize_Int32_Int32_GraphicsFormat_Boolean.SetBelong(this.GetValue());
				}
				return r_MResize_Int32_Int32_GraphicsFormat_Boolean;
			}
		}

		/// <summary>
		/// Void ReadPixels(UnityEngine.Rect, Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_MReadPixels_Rect_Int32_Int32_Boolean;
		public virtual RMethod RMReadPixels_Rect_Int32_Int32_Boolean
		{
			get
			{
				if(r_MReadPixels_Rect_Int32_Int32_Boolean == null)
				{
					r_MReadPixels_Rect_Int32_Int32_Boolean = new(this, "ReadPixels", 0, typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_MReadPixels_Rect_Int32_Int32_Boolean.SetBelong(this.GetValue());
				}
				return r_MReadPixels_Rect_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void ReadPixels(UnityEngine.Rect, Int32, Int32)
		/// </summary>
		protected RMethod r_MReadPixels_Rect_Int32_Int32;
		public virtual RMethod RMReadPixels_Rect_Int32_Int32
		{
			get
			{
				if(r_MReadPixels_Rect_Int32_Int32 == null)
				{
					r_MReadPixels_Rect_Int32_Int32 = new(this, "ReadPixels", 0, typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Int32));
					r_MReadPixels_Rect_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_MReadPixels_Rect_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean GenerateAtlas(UnityEngine.Vector2[], Int32, Int32, System.Collections.Generic.List`1[UnityEngine.Rect])
		/// </summary>
		protected static RMethod r_MGenerateAtlas_Vector2Array_Int32_Int32_List_d_Rect_p_;
		public static RMethod RMGenerateAtlas_Vector2Array_Int32_Int32_List_d_Rect_p_
		{
			get
			{
				if(r_MGenerateAtlas_Vector2Array_Int32_Int32_List_d_Rect_p_ == null)
				{
					r_MGenerateAtlas_Vector2Array_Int32_Int32_List_d_Rect_p_ = new(typeof(UnityEngine.Texture2D), "GenerateAtlas", 0, typeof(UnityEngine.Vector2).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Rect)));
					r_MGenerateAtlas_Vector2Array_Int32_Int32_List_d_Rect_p_.SetBelong(null);
				}
				return r_MGenerateAtlas_Vector2Array_Int32_Int32_List_d_Rect_p_;
			}
		}

		/// <summary>
		/// Void SetPixels32(UnityEngine.Color32[], Int32)
		/// </summary>
		protected RMethod r_MSetPixels32_Color32Array_Int32;
		public virtual RMethod RMSetPixels32_Color32Array_Int32
		{
			get
			{
				if(r_MSetPixels32_Color32Array_Int32 == null)
				{
					r_MSetPixels32_Color32Array_Int32 = new(this, "SetPixels32", 0, typeof(UnityEngine.Color32).MakeArrayType(), typeof(System.Int32));
					r_MSetPixels32_Color32Array_Int32.SetBelong(this.GetValue());
				}
				return r_MSetPixels32_Color32Array_Int32;
			}
		}

		/// <summary>
		/// Void SetPixels32(UnityEngine.Color32[])
		/// </summary>
		protected RMethod r_MSetPixels32_Color32Array;
		public virtual RMethod RMSetPixels32_Color32Array
		{
			get
			{
				if(r_MSetPixels32_Color32Array == null)
				{
					r_MSetPixels32_Color32Array = new(this, "SetPixels32", 0, typeof(UnityEngine.Color32).MakeArrayType());
					r_MSetPixels32_Color32Array.SetBelong(this.GetValue());
				}
				return r_MSetPixels32_Color32Array;
			}
		}

		/// <summary>
		/// Void SetPixels32(Int32, Int32, Int32, Int32, UnityEngine.Color32[], Int32)
		/// </summary>
		protected RMethod r_MSetPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32;
		public virtual RMethod RMSetPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32
		{
			get
			{
				if(r_MSetPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32 == null)
				{
					r_MSetPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32 = new(this, "SetPixels32", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color32).MakeArrayType(), typeof(System.Int32));
					r_MSetPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32.SetBelong(this.GetValue());
				}
				return r_MSetPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32;
			}
		}

		/// <summary>
		/// Void SetPixels32(Int32, Int32, Int32, Int32, UnityEngine.Color32[])
		/// </summary>
		protected RMethod r_MSetPixels32_Int32_Int32_Int32_Int32_Color32Array;
		public virtual RMethod RMSetPixels32_Int32_Int32_Int32_Int32_Color32Array
		{
			get
			{
				if(r_MSetPixels32_Int32_Int32_Int32_Int32_Color32Array == null)
				{
					r_MSetPixels32_Int32_Int32_Int32_Int32_Color32Array = new(this, "SetPixels32", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color32).MakeArrayType());
					r_MSetPixels32_Int32_Int32_Int32_Int32_Color32Array.SetBelong(this.GetValue());
				}
				return r_MSetPixels32_Int32_Int32_Int32_Int32_Color32Array;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] GetPixels(Int32)
		/// </summary>
		protected RMethod r_MGetPixels_Int32;
		public virtual RMethod RMGetPixels_Int32
		{
			get
			{
				if(r_MGetPixels_Int32 == null)
				{
					r_MGetPixels_Int32 = new(this, "GetPixels", 0, typeof(System.Int32));
					r_MGetPixels_Int32.SetBelong(this.GetValue());
				}
				return r_MGetPixels_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] GetPixels()
		/// </summary>
		protected RMethod r_MGetPixels;
		public virtual RMethod RMGetPixels
		{
			get
			{
				if(r_MGetPixels == null)
				{
					r_MGetPixels = new(this, "GetPixels", 0);
					r_MGetPixels.SetBelong(this.GetValue());
				}
				return r_MGetPixels;
			}
		}

		/// <summary>
		/// Void SetPixelImpl_Injected(Int32, Int32, Int32, Int32, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_MSetPixelImpl_Injected_Int32_Int32_Int32_Int32_Ref_Color;
		public virtual RMethod RMSetPixelImpl_Injected_Int32_Int32_Int32_Int32_Ref_Color
		{
			get
			{
				if(r_MSetPixelImpl_Injected_Int32_Int32_Int32_Int32_Ref_Color == null)
				{
					r_MSetPixelImpl_Injected_Int32_Int32_Int32_Int32_Ref_Color = new(this, "SetPixelImpl_Injected", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color).MakeByRefType());
					r_MSetPixelImpl_Injected_Int32_Int32_Int32_Int32_Ref_Color.SetBelong(this.GetValue());
				}
				return r_MSetPixelImpl_Injected_Int32_Int32_Int32_Int32_Ref_Color;
			}
		}

		/// <summary>
		/// Void GetPixelImpl_Injected(Int32, Int32, Int32, Int32, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_MGetPixelImpl_Injected_Int32_Int32_Int32_Int32_Out_Color;
		public virtual RMethod RMGetPixelImpl_Injected_Int32_Int32_Int32_Int32_Out_Color
		{
			get
			{
				if(r_MGetPixelImpl_Injected_Int32_Int32_Int32_Int32_Out_Color == null)
				{
					r_MGetPixelImpl_Injected_Int32_Int32_Int32_Int32_Out_Color = new(this, "GetPixelImpl_Injected", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color).MakeByRefType());
					r_MGetPixelImpl_Injected_Int32_Int32_Int32_Int32_Out_Color.SetBelong(this.GetValue());
				}
				return r_MGetPixelImpl_Injected_Int32_Int32_Int32_Int32_Out_Color;
			}
		}

		/// <summary>
		/// Void GetPixelBilinearImpl_Injected(Int32, Int32, Single, Single, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_MGetPixelBilinearImpl_Injected_Int32_Int32_Single_Single_Out_Color;
		public virtual RMethod RMGetPixelBilinearImpl_Injected_Int32_Int32_Single_Single_Out_Color
		{
			get
			{
				if(r_MGetPixelBilinearImpl_Injected_Int32_Int32_Single_Single_Out_Color == null)
				{
					r_MGetPixelBilinearImpl_Injected_Int32_Int32_Single_Single_Out_Color = new(this, "GetPixelBilinearImpl_Injected", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.Color).MakeByRefType());
					r_MGetPixelBilinearImpl_Injected_Int32_Int32_Single_Single_Out_Color.SetBelong(this.GetValue());
				}
				return r_MGetPixelBilinearImpl_Injected_Int32_Int32_Single_Single_Out_Color;
			}
		}

		/// <summary>
		/// Void ReadPixelsImpl_Injected(UnityEngine.Rect ByRef, Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_MReadPixelsImpl_Injected_Ref_Rect_Int32_Int32_Boolean;
		public virtual RMethod RMReadPixelsImpl_Injected_Ref_Rect_Int32_Int32_Boolean
		{
			get
			{
				if(r_MReadPixelsImpl_Injected_Ref_Rect_Int32_Int32_Boolean == null)
				{
					r_MReadPixelsImpl_Injected_Ref_Rect_Int32_Int32_Boolean = new(this, "ReadPixelsImpl_Injected", 0, typeof(UnityEngine.Rect).MakeByRefType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_MReadPixelsImpl_Injected_Ref_Rect_Int32_Int32_Boolean.SetBelong(this.GetValue());
				}
				return r_MReadPixelsImpl_Injected_Ref_Rect_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetSafetyHandle_Injected(UnityEngine.Texture2D, Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected static RMethod r_MGetSafetyHandle_Injected_Texture2D_Out_AtomicSafetyHandle;
		public static RMethod RMGetSafetyHandle_Injected_Texture2D_Out_AtomicSafetyHandle
		{
			get
			{
				if(r_MGetSafetyHandle_Injected_Texture2D_Out_AtomicSafetyHandle == null)
				{
					r_MGetSafetyHandle_Injected_Texture2D_Out_AtomicSafetyHandle = new(typeof(UnityEngine.Texture2D), "GetSafetyHandle_Injected", 0, typeof(UnityEngine.Texture2D), typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_MGetSafetyHandle_Injected_Texture2D_Out_AtomicSafetyHandle.SetBelong(null);
				}
				return r_MGetSafetyHandle_Injected_Texture2D_Out_AtomicSafetyHandle;
			}
		}

		/// <summary>
		/// Void GetSafetyHandleForSlice_Injected(Int32, Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected RMethod r_MGetSafetyHandleForSlice_Injected_Int32_Out_AtomicSafetyHandle;
		public virtual RMethod RMGetSafetyHandleForSlice_Injected_Int32_Out_AtomicSafetyHandle
		{
			get
			{
				if(r_MGetSafetyHandleForSlice_Injected_Int32_Out_AtomicSafetyHandle == null)
				{
					r_MGetSafetyHandleForSlice_Injected_Int32_Out_AtomicSafetyHandle = new(this, "GetSafetyHandleForSlice_Injected", 0, typeof(System.Int32), typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_MGetSafetyHandleForSlice_Injected_Int32_Out_AtomicSafetyHandle.SetBelong(this.GetValue());
				}
				return r_MGetSafetyHandleForSlice_Injected_Int32_Out_AtomicSafetyHandle;
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

        public virtual void Compress(System.Boolean @highQuality)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@highQuality};
            var ___result = RMCompress_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean Internal_CreateImpl(UnityEngine.Texture2D @mono, System.Int32 @w, System.Int32 @h, System.Int32 @mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat @format, UnityEngine.Experimental.Rendering.TextureCreationFlags @flags, System.IntPtr @nativeTex, System.String @mipmapLimitGroupName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mono, @w, @h, @mipCount, @format, @flags, @nativeTex, @mipmapLimitGroupName};
            var ___result = RMInternal_CreateImpl_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void Internal_Create(UnityEngine.Texture2D @mono, System.Int32 @w, System.Int32 @h, System.Int32 @mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat @format, UnityEngine.Experimental.Rendering.TextureCreationFlags @flags, System.IntPtr @nativeTex, System.String @mipmapLimitGroupName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mono, @w, @h, @mipCount, @format, @flags, @nativeTex, @mipmapLimitGroupName};
            var ___result = RMInternal_Create_Texture2D_Int32_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyImpl(System.Boolean @updateMipmaps, System.Boolean @makeNoLongerReadable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updateMipmaps, @makeNoLongerReadable};
            var ___result = RMApplyImpl_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ReinitializeImpl(System.Int32 @width, System.Int32 @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height};
            var ___result = RMReinitializeImpl_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetPixelImpl(System.Int32 @image, System.Int32 @mip, System.Int32 @x, System.Int32 @y, UnityEngine.Color @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@image, @mip, @x, @y, @color};
            var ___result = RMSetPixelImpl_Int32_Int32_Int32_Int32_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Color GetPixelImpl(System.Int32 @image, System.Int32 @mip, System.Int32 @x, System.Int32 @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@image, @mip, @x, @y};
            var ___result = RMGetPixelImpl_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual UnityEngine.Color GetPixelBilinearImpl(System.Int32 @image, System.Int32 @mip, System.Single @u, System.Single @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@image, @mip, @u, @v};
            var ___result = RMGetPixelBilinearImpl_Int32_Int32_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual System.Boolean ReinitializeWithFormatImpl(System.Int32 @width, System.Int32 @height, UnityEngine.Experimental.Rendering.GraphicsFormat @format, System.Boolean @hasMipMap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @format, @hasMipMap};
            var ___result = RMReinitializeWithFormatImpl_Int32_Int32_GraphicsFormat_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ReinitializeWithTextureFormatImpl(System.Int32 @width, System.Int32 @height, UnityEngine.TextureFormat @textureFormat, System.Boolean @hasMipMap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @textureFormat, @hasMipMap};
            var ___result = RMReinitializeWithTextureFormatImpl_Int32_Int32_TextureFormat_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ReadPixelsImpl(UnityEngine.Rect @source, System.Int32 @destX, System.Int32 @destY, System.Boolean @recalculateMipMaps)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @destX, @destY, @recalculateMipMaps};
            var ___result = RMReadPixelsImpl_Rect_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixelsImpl(System.Int32 @x, System.Int32 @y, System.Int32 @w, System.Int32 @h, UnityEngine.Color[] @pixel, System.Int32 @miplevel, System.Int32 @frame)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @w, @h, @pixel, @miplevel, @frame};
            var ___result = RMSetPixelsImpl_Int32_Int32_Int32_Int32_ColorArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean LoadRawTextureDataImpl(System.IntPtr @data, System.UInt64 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @size};
            var ___result = RMLoadRawTextureDataImpl_IntPtr_UInt64.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean LoadRawTextureDataImplArray(System.Byte[] @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RMLoadRawTextureDataImplArray_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SetPixelDataImplArray(System.Array @data, System.Int32 @mipLevel, System.Int32 @elementSize, System.Int32 @dataArraySize, System.Int32 @sourceDataStartIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @mipLevel, @elementSize, @dataArraySize, @sourceDataStartIndex};
            var ___result = RMSetPixelDataImplArray_Array_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SetPixelDataImpl(System.IntPtr @data, System.Int32 @mipLevel, System.Int32 @elementSize, System.Int32 @dataArraySize, System.Int32 @sourceDataStartIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @mipLevel, @elementSize, @dataArraySize, @sourceDataStartIndex};
            var ___result = RMSetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.IntPtr GetWritableImageData(System.Int32 @frame)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@frame};
            var ___result = RMGetWritableImageData_Int32.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.UInt64 GetRawImageDataSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRawImageDataSize.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public static Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetSafetyHandle(UnityEngine.Texture2D @tex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tex};
            var ___result = RMGetSafetyHandle_Texture2D.Invoke(___genericsType, ___parameters);

            return (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___result;
        }


        public virtual Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetSafetyHandleForSlice(System.Int32 @mipLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mipLevel};
            var ___result = RMGetSafetyHandleForSlice_Int32.Invoke(___genericsType, ___parameters);

            return (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___result;
        }


        public static void GenerateAtlasImpl(UnityEngine.Vector2[] @sizes, System.Int32 @padding, System.Int32 @atlasSize, UnityEngine.Rect[] @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sizes, @padding, @atlasSize, @rect};
            var ___result = RMGenerateAtlasImpl_Vector2Array_Int32_Int32_RectArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearRequestedMipmapLevel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearRequestedMipmapLevel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsRequestedMipmapLevelLoaded()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsRequestedMipmapLevelLoaded.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ClearMinimumMipmapLevel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearMinimumMipmapLevel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateExternalTexture(System.IntPtr @nativeTex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nativeTex};
            var ___result = RMUpdateExternalTexture_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAllPixels32(UnityEngine.Color32[] @colors, System.Int32 @miplevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors, @miplevel};
            var ___result = RMSetAllPixels32_Color32Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBlockOfPixels32(System.Int32 @x, System.Int32 @y, System.Int32 @blockWidth, System.Int32 @blockHeight, UnityEngine.Color32[] @colors, System.Int32 @miplevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @blockWidth, @blockHeight, @colors, @miplevel};
            var ___result = RMSetBlockOfPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Byte[] GetRawTextureData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRawTextureData.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual UnityEngine.Color[] GetPixels(System.Int32 @x, System.Int32 @y, System.Int32 @blockWidth, System.Int32 @blockHeight, System.Int32 @miplevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @blockWidth, @blockHeight, @miplevel};
            var ___result = RMGetPixels_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color[])___result;
        }


        public virtual UnityEngine.Color[] GetPixels(System.Int32 @x, System.Int32 @y, System.Int32 @blockWidth, System.Int32 @blockHeight)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @blockWidth, @blockHeight};
            var ___result = RMGetPixels_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color[])___result;
        }


        public virtual UnityEngine.Color32[] GetPixels32(System.Int32 @miplevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@miplevel};
            var ___result = RMGetPixels32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color32[])___result;
        }


        public virtual UnityEngine.Color32[] GetPixels32()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPixels32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color32[])___result;
        }


        public virtual UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] @textures, System.Int32 @padding, System.Int32 @maximumAtlasSize, System.Boolean @makeNoLongerReadable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textures, @padding, @maximumAtlasSize, @makeNoLongerReadable};
            var ___result = RMPackTextures_Texture2DArray_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect[])___result;
        }


        public virtual UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] @textures, System.Int32 @padding, System.Int32 @maximumAtlasSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textures, @padding, @maximumAtlasSize};
            var ___result = RMPackTextures_Texture2DArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect[])___result;
        }


        public virtual UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] @textures, System.Int32 @padding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textures, @padding};
            var ___result = RMPackTextures_Texture2DArray_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect[])___result;
        }


        public virtual System.Boolean ValidateFormat(UnityEngine.TextureFormat @format, System.Int32 @width, System.Int32 @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @width, @height};
            var ___result = RMValidateFormat_TextureFormat_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat @format, System.Int32 @width, System.Int32 @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @width, @height};
            var ___result = RMValidateFormat_GraphicsFormat_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Texture2D CreateExternalTexture(System.Int32 @width, System.Int32 @height, UnityEngine.TextureFormat @format, System.Boolean @mipChain, System.Boolean @linear, System.IntPtr @nativeTex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @format, @mipChain, @linear, @nativeTex};
            var ___result = RMCreateExternalTexture_Int32_Int32_TextureFormat_Boolean_Boolean_IntPtr.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture2D)___result;
        }


        public virtual void SetPixel(System.Int32 @x, System.Int32 @y, UnityEngine.Color @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @color};
            var ___result = RMSetPixel_Int32_Int32_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixel(System.Int32 @x, System.Int32 @y, UnityEngine.Color @color, System.Int32 @mipLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @color, @mipLevel};
            var ___result = RMSetPixel_Int32_Int32_Color_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixels(System.Int32 @x, System.Int32 @y, System.Int32 @blockWidth, System.Int32 @blockHeight, UnityEngine.Color[] @colors, System.Int32 @miplevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @blockWidth, @blockHeight, @colors, @miplevel};
            var ___result = RMSetPixels_Int32_Int32_Int32_Int32_ColorArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixels(System.Int32 @x, System.Int32 @y, System.Int32 @blockWidth, System.Int32 @blockHeight, UnityEngine.Color[] @colors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @blockWidth, @blockHeight, @colors};
            var ___result = RMSetPixels_Int32_Int32_Int32_Int32_ColorArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixels(UnityEngine.Color[] @colors, System.Int32 @miplevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors, @miplevel};
            var ___result = RMSetPixels_ColorArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixels(UnityEngine.Color[] @colors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors};
            var ___result = RMSetPixels_ColorArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Color GetPixel(System.Int32 @x, System.Int32 @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RMGetPixel_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual UnityEngine.Color GetPixel(System.Int32 @x, System.Int32 @y, System.Int32 @mipLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @mipLevel};
            var ___result = RMGetPixel_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual UnityEngine.Color GetPixelBilinear(System.Single @u, System.Single @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@u, @v};
            var ___result = RMGetPixelBilinear_Single_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual UnityEngine.Color GetPixelBilinear(System.Single @u, System.Single @v, System.Int32 @mipLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@u, @v, @mipLevel};
            var ___result = RMGetPixelBilinear_Single_Single_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual void LoadRawTextureData(System.IntPtr @data, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @size};
            var ___result = RMLoadRawTextureData_IntPtr_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadRawTextureData(System.Byte[] @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RMLoadRawTextureData_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadRawTextureData<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @data) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value};
            var ___result = RMLoadRawTextureData_GT_NativeArray_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixelData<T>(T[] @data, System.Int32 @mipLevel, System.Int32 @sourceDataStartIndex)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data, @mipLevel, @sourceDataStartIndex};
            var ___result = RMSetPixelData_GT_TArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixelData<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @data, System.Int32 @mipLevel, System.Int32 @sourceDataStartIndex) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value, @mipLevel, @sourceDataStartIndex};
            var ___result = RMSetPixelData_GT_NativeArray_d_T_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> GetPixelData<T>(System.Int32 @mipLevel) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@mipLevel};
            var ___result = RMGetPixelData_GT_Int32.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> GetRawTextureData<T>() where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetRawTextureData_GT.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual void Apply(System.Boolean @updateMipmaps, System.Boolean @makeNoLongerReadable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updateMipmaps, @makeNoLongerReadable};
            var ___result = RMApply_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Apply(System.Boolean @updateMipmaps)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updateMipmaps};
            var ___result = RMApply_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Apply()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMApply.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Reinitialize(System.Int32 @width, System.Int32 @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height};
            var ___result = RMReinitialize_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Reinitialize(System.Int32 @width, System.Int32 @height, UnityEngine.TextureFormat @format, System.Boolean @hasMipMap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @format, @hasMipMap};
            var ___result = RMReinitialize_Int32_Int32_TextureFormat_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Reinitialize(System.Int32 @width, System.Int32 @height, UnityEngine.Experimental.Rendering.GraphicsFormat @format, System.Boolean @hasMipMap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @format, @hasMipMap};
            var ___result = RMReinitialize_Int32_Int32_GraphicsFormat_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Resize(System.Int32 @width, System.Int32 @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height};
            var ___result = RMResize_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Resize(System.Int32 @width, System.Int32 @height, UnityEngine.TextureFormat @format, System.Boolean @hasMipMap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @format, @hasMipMap};
            var ___result = RMResize_Int32_Int32_TextureFormat_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Resize(System.Int32 @width, System.Int32 @height, UnityEngine.Experimental.Rendering.GraphicsFormat @format, System.Boolean @hasMipMap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @height, @format, @hasMipMap};
            var ___result = RMResize_Int32_Int32_GraphicsFormat_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ReadPixels(UnityEngine.Rect @source, System.Int32 @destX, System.Int32 @destY, System.Boolean @recalculateMipMaps)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @destX, @destY, @recalculateMipMaps};
            var ___result = RMReadPixels_Rect_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadPixels(UnityEngine.Rect @source, System.Int32 @destX, System.Int32 @destY)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @destX, @destY};
            var ___result = RMReadPixels_Rect_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean GenerateAtlas(UnityEngine.Vector2[] @sizes, System.Int32 @padding, System.Int32 @atlasSize, System.Collections.Generic.List<UnityEngine.Rect> @results)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sizes, @padding, @atlasSize, @results};
            var ___result = RMGenerateAtlas_Vector2Array_Int32_Int32_List_d_Rect_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetPixels32(UnityEngine.Color32[] @colors, System.Int32 @miplevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors, @miplevel};
            var ___result = RMSetPixels32_Color32Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixels32(UnityEngine.Color32[] @colors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors};
            var ___result = RMSetPixels32_Color32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixels32(System.Int32 @x, System.Int32 @y, System.Int32 @blockWidth, System.Int32 @blockHeight, UnityEngine.Color32[] @colors, System.Int32 @miplevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @blockWidth, @blockHeight, @colors, @miplevel};
            var ___result = RMSetPixels32_Int32_Int32_Int32_Int32_Color32Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixels32(System.Int32 @x, System.Int32 @y, System.Int32 @blockWidth, System.Int32 @blockHeight, UnityEngine.Color32[] @colors)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @blockWidth, @blockHeight, @colors};
            var ___result = RMSetPixels32_Int32_Int32_Int32_Int32_Color32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Color[] GetPixels(System.Int32 @miplevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@miplevel};
            var ___result = RMGetPixels_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color[])___result;
        }


        public virtual UnityEngine.Color[] GetPixels()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPixels.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color[])___result;
        }


        public virtual void SetPixelImpl_Injected(System.Int32 @image, System.Int32 @mip, System.Int32 @x, System.Int32 @y, ref UnityEngine.Color @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@image, @mip, @x, @y, @color};
            var ___result = RMSetPixelImpl_Injected_Int32_Int32_Int32_Int32_Ref_Color.Invoke(___genericsType, ___parameters);
			@color = (UnityEngine.Color)___parameters[4];

            
        }


        public virtual void GetPixelImpl_Injected(System.Int32 @image, System.Int32 @mip, System.Int32 @x, System.Int32 @y, out UnityEngine.Color @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@image, @mip, @x, @y, @ret};
            var ___result = RMGetPixelImpl_Injected_Int32_Int32_Int32_Int32_Out_Color.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Color)___parameters[4];

            
        }


        public virtual void GetPixelBilinearImpl_Injected(System.Int32 @image, System.Int32 @mip, System.Single @u, System.Single @v, out UnityEngine.Color @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@image, @mip, @u, @v, @ret};
            var ___result = RMGetPixelBilinearImpl_Injected_Int32_Int32_Single_Single_Out_Color.Invoke(___genericsType, ___parameters);
			@ret = (UnityEngine.Color)___parameters[4];

            
        }


        public virtual void ReadPixelsImpl_Injected(ref UnityEngine.Rect @source, System.Int32 @destX, System.Int32 @destY, System.Boolean @recalculateMipMaps)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @destX, @destY, @recalculateMipMaps};
            var ___result = RMReadPixelsImpl_Injected_Ref_Rect_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);
			@source = (UnityEngine.Rect)___parameters[0];

            
        }


        public static void GetSafetyHandle_Injected(UnityEngine.Texture2D @tex, out Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tex, @ret};
            var ___result = RMGetSafetyHandle_Injected_Texture2D_Out_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@ret = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[1];

            
        }


        public virtual void GetSafetyHandleForSlice_Injected(System.Int32 @mipLevel, out Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mipLevel, @ret};
            var ___result = RMGetSafetyHandleForSlice_Injected_Int32_Out_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@ret = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[1];

            
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
