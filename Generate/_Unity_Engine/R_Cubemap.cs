
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Cubemap
	/// </summary>
    public partial class RCubemap : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Cubemap);
            }
        }

        public RCubemap() : base("UnityEngine.Cubemap")
        {
        }

        public RCubemap(System.Object instance) : base("UnityEngine.Cubemap")
		{
            SetInstance(instance);
		}

        public RCubemap(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCubemap(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
				}
				return r_Pformat;
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
				}
				return r_PrequestedMipmapLevel;
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
				}
				return r_PloadAllMips;
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
				}
				return r_PloadedMipmapLevel;
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
		/// Boolean Internal_CreateImpl(UnityEngine.Cubemap, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, UnityEngine.Experimental.Rendering.TextureCreationFlags, IntPtr)
		/// </summary>
		protected static RMethod r_MInternal_CreateImpl_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr;
		public static RMethod RMInternal_CreateImpl_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr
		{
			get
			{
				if(r_MInternal_CreateImpl_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr == null)
				{
					r_MInternal_CreateImpl_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr = new(typeof(UnityEngine.Cubemap), "Internal_CreateImpl", 0, typeof(UnityEngine.Cubemap), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(UnityEngine.Experimental.Rendering.TextureCreationFlags), typeof(System.IntPtr));
				}
				return r_MInternal_CreateImpl_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr;
			}
		}

		/// <summary>
		/// Void Internal_Create(UnityEngine.Cubemap, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, UnityEngine.Experimental.Rendering.TextureCreationFlags, IntPtr)
		/// </summary>
		protected static RMethod r_MInternal_Create_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr;
		public static RMethod RMInternal_Create_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr
		{
			get
			{
				if(r_MInternal_Create_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr == null)
				{
					r_MInternal_Create_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr = new(typeof(UnityEngine.Cubemap), "Internal_Create", 0, typeof(UnityEngine.Cubemap), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(UnityEngine.Experimental.Rendering.TextureCreationFlags), typeof(System.IntPtr));
				}
				return r_MInternal_Create_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr;
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
				}
				return r_MApplyImpl_Boolean_Boolean;
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
				}
				return r_MUpdateExternalTexture_IntPtr;
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
				}
				return r_MGetPixelImpl_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SmoothEdges(Int32)
		/// </summary>
		protected RMethod r_MSmoothEdges_Int32;
		public virtual RMethod RMSmoothEdges_Int32
		{
			get
			{
				if(r_MSmoothEdges_Int32 == null)
				{
					r_MSmoothEdges_Int32 = new(this, "SmoothEdges", 0, typeof(System.Int32));
				}
				return r_MSmoothEdges_Int32;
			}
		}

		/// <summary>
		/// Void SmoothEdges()
		/// </summary>
		protected RMethod r_MSmoothEdges;
		public virtual RMethod RMSmoothEdges
		{
			get
			{
				if(r_MSmoothEdges == null)
				{
					r_MSmoothEdges = new(this, "SmoothEdges", 0);
				}
				return r_MSmoothEdges;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] GetPixels(UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_MGetPixels_CubemapFace_Int32;
		public virtual RMethod RMGetPixels_CubemapFace_Int32
		{
			get
			{
				if(r_MGetPixels_CubemapFace_Int32 == null)
				{
					r_MGetPixels_CubemapFace_Int32 = new(this, "GetPixels", 0, typeof(UnityEngine.CubemapFace), typeof(System.Int32));
				}
				return r_MGetPixels_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] GetPixels(UnityEngine.CubemapFace)
		/// </summary>
		protected RMethod r_MGetPixels_CubemapFace;
		public virtual RMethod RMGetPixels_CubemapFace
		{
			get
			{
				if(r_MGetPixels_CubemapFace == null)
				{
					r_MGetPixels_CubemapFace = new(this, "GetPixels", 0, typeof(UnityEngine.CubemapFace));
				}
				return r_MGetPixels_CubemapFace;
			}
		}

		/// <summary>
		/// Void SetPixels(UnityEngine.Color[], UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_MSetPixels_ColorArray_CubemapFace_Int32;
		public virtual RMethod RMSetPixels_ColorArray_CubemapFace_Int32
		{
			get
			{
				if(r_MSetPixels_ColorArray_CubemapFace_Int32 == null)
				{
					r_MSetPixels_ColorArray_CubemapFace_Int32 = new(this, "SetPixels", 0, typeof(UnityEngine.Color).MakeArrayType(), typeof(UnityEngine.CubemapFace), typeof(System.Int32));
				}
				return r_MSetPixels_ColorArray_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// Boolean SetPixelDataImplArray(System.Array, Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetPixelDataImplArray_Array_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RMSetPixelDataImplArray_Array_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MSetPixelDataImplArray_Array_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_MSetPixelDataImplArray_Array_Int32_Int32_Int32_Int32_Int32 = new(this, "SetPixelDataImplArray", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetPixelDataImplArray_Array_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean SetPixelDataImpl(IntPtr, Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RMSetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MSetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_MSetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32_Int32 = new(this, "SetPixelDataImpl", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetPixels(UnityEngine.Color[], UnityEngine.CubemapFace)
		/// </summary>
		protected RMethod r_MSetPixels_ColorArray_CubemapFace;
		public virtual RMethod RMSetPixels_ColorArray_CubemapFace
		{
			get
			{
				if(r_MSetPixels_ColorArray_CubemapFace == null)
				{
					r_MSetPixels_ColorArray_CubemapFace = new(this, "SetPixels", 0, typeof(UnityEngine.Color).MakeArrayType(), typeof(UnityEngine.CubemapFace));
				}
				return r_MSetPixels_ColorArray_CubemapFace;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetSafetyHandleForSlice(Int32, Int32)
		/// </summary>
		protected RMethod r_MGetSafetyHandleForSlice_Int32_Int32;
		public virtual RMethod RMGetSafetyHandleForSlice_Int32_Int32
		{
			get
			{
				if(r_MGetSafetyHandleForSlice_Int32_Int32 == null)
				{
					r_MGetSafetyHandleForSlice_Int32_Int32 = new(this, "GetSafetyHandleForSlice", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetSafetyHandleForSlice_Int32_Int32;
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
				}
				return r_MGetWritableImageData_Int32;
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
				}
				return r_MIsRequestedMipmapLevelLoaded;
			}
		}

		/// <summary>
		/// Boolean ValidateFormat(UnityEngine.TextureFormat, Int32)
		/// </summary>
		protected RMethod r_MValidateFormat_TextureFormat_Int32;
		public virtual RMethod RMValidateFormat_TextureFormat_Int32
		{
			get
			{
				if(r_MValidateFormat_TextureFormat_Int32 == null)
				{
					r_MValidateFormat_TextureFormat_Int32 = new(this, "ValidateFormat", 0, typeof(UnityEngine.TextureFormat), typeof(System.Int32));
				}
				return r_MValidateFormat_TextureFormat_Int32;
			}
		}

		/// <summary>
		/// Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat, Int32)
		/// </summary>
		protected RMethod r_MValidateFormat_GraphicsFormat_Int32;
		public virtual RMethod RMValidateFormat_GraphicsFormat_Int32
		{
			get
			{
				if(r_MValidateFormat_GraphicsFormat_Int32 == null)
				{
					r_MValidateFormat_GraphicsFormat_Int32 = new(this, "ValidateFormat", 0, typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32));
				}
				return r_MValidateFormat_GraphicsFormat_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Cubemap CreateExternalTexture(Int32, UnityEngine.TextureFormat, Boolean, IntPtr)
		/// </summary>
		protected static RMethod r_MCreateExternalTexture_Int32_TextureFormat_Boolean_IntPtr;
		public static RMethod RMCreateExternalTexture_Int32_TextureFormat_Boolean_IntPtr
		{
			get
			{
				if(r_MCreateExternalTexture_Int32_TextureFormat_Boolean_IntPtr == null)
				{
					r_MCreateExternalTexture_Int32_TextureFormat_Boolean_IntPtr = new(typeof(UnityEngine.Cubemap), "CreateExternalTexture", 0, typeof(System.Int32), typeof(UnityEngine.TextureFormat), typeof(System.Boolean), typeof(System.IntPtr));
				}
				return r_MCreateExternalTexture_Int32_TextureFormat_Boolean_IntPtr;
			}
		}

		/// <summary>
		/// Void SetPixelData[T](T[], Int32, UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_MSetPixelData_GT_TArray_Int32_CubemapFace_Int32;
		public virtual RMethod RMSetPixelData_GT_TArray_Int32_CubemapFace_Int32
		{
			get
			{
				if(r_MSetPixelData_GT_TArray_Int32_CubemapFace_Int32 == null)
				{
					r_MSetPixelData_GT_TArray_Int32_CubemapFace_Int32 = new(this, "SetPixelData", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32));
				}
				return r_MSetPixelData_GT_TArray_Int32_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// Void SetPixelData[T](Unity.Collections.NativeArray`1[T], Int32, UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_MSetPixelData_GT_NativeArray_d_T_p__Int32_CubemapFace_Int32;
		public virtual RMethod RMSetPixelData_GT_NativeArray_d_T_p__Int32_CubemapFace_Int32
		{
			get
			{
				if(r_MSetPixelData_GT_NativeArray_d_T_p__Int32_CubemapFace_Int32 == null)
				{
					r_MSetPixelData_GT_NativeArray_d_T_p__Int32_CubemapFace_Int32 = new(this, "SetPixelData", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32));
				}
				return r_MSetPixelData_GT_NativeArray_d_T_p__Int32_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[T] GetPixelData[T](Int32, UnityEngine.CubemapFace)
		/// </summary>
		protected RMethod r_MGetPixelData_GT_Int32_CubemapFace;
		public virtual RMethod RMGetPixelData_GT_Int32_CubemapFace
		{
			get
			{
				if(r_MGetPixelData_GT_Int32_CubemapFace == null)
				{
					r_MGetPixelData_GT_Int32_CubemapFace = new(this, "GetPixelData", 1, typeof(System.Int32), typeof(UnityEngine.CubemapFace));
				}
				return r_MGetPixelData_GT_Int32_CubemapFace;
			}
		}

		/// <summary>
		/// Void SetPixel(UnityEngine.CubemapFace, Int32, Int32, UnityEngine.Color)
		/// </summary>
		protected RMethod r_MSetPixel_CubemapFace_Int32_Int32_Color;
		public virtual RMethod RMSetPixel_CubemapFace_Int32_Int32_Color
		{
			get
			{
				if(r_MSetPixel_CubemapFace_Int32_Int32_Color == null)
				{
					r_MSetPixel_CubemapFace_Int32_Int32_Color = new(this, "SetPixel", 0, typeof(UnityEngine.CubemapFace), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color));
				}
				return r_MSetPixel_CubemapFace_Int32_Int32_Color;
			}
		}

		/// <summary>
		/// Void SetPixel(UnityEngine.CubemapFace, Int32, Int32, UnityEngine.Color, Int32)
		/// </summary>
		protected RMethod r_MSetPixel_CubemapFace_Int32_Int32_Color_Int32;
		public virtual RMethod RMSetPixel_CubemapFace_Int32_Int32_Color_Int32
		{
			get
			{
				if(r_MSetPixel_CubemapFace_Int32_Int32_Color_Int32 == null)
				{
					r_MSetPixel_CubemapFace_Int32_Int32_Color_Int32 = new(this, "SetPixel", 0, typeof(UnityEngine.CubemapFace), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color), typeof(System.Int32));
				}
				return r_MSetPixel_CubemapFace_Int32_Int32_Color_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetPixel(UnityEngine.CubemapFace, Int32, Int32)
		/// </summary>
		protected RMethod r_MGetPixel_CubemapFace_Int32_Int32;
		public virtual RMethod RMGetPixel_CubemapFace_Int32_Int32
		{
			get
			{
				if(r_MGetPixel_CubemapFace_Int32_Int32 == null)
				{
					r_MGetPixel_CubemapFace_Int32_Int32 = new(this, "GetPixel", 0, typeof(UnityEngine.CubemapFace), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetPixel_CubemapFace_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetPixel(UnityEngine.CubemapFace, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MGetPixel_CubemapFace_Int32_Int32_Int32;
		public virtual RMethod RMGetPixel_CubemapFace_Int32_Int32_Int32
		{
			get
			{
				if(r_MGetPixel_CubemapFace_Int32_Int32_Int32 == null)
				{
					r_MGetPixel_CubemapFace_Int32_Int32_Int32 = new(this, "GetPixel", 0, typeof(UnityEngine.CubemapFace), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MGetPixel_CubemapFace_Int32_Int32_Int32;
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
				}
				return r_MApply;
			}
		}

		/// <summary>
		/// Void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags)
		/// </summary>
		protected static RMethod r_MValidateIsNotCrunched_TextureCreationFlags;
		public static RMethod RMValidateIsNotCrunched_TextureCreationFlags
		{
			get
			{
				if(r_MValidateIsNotCrunched_TextureCreationFlags == null)
				{
					r_MValidateIsNotCrunched_TextureCreationFlags = new(typeof(UnityEngine.Cubemap), "ValidateIsNotCrunched", 0, typeof(UnityEngine.Experimental.Rendering.TextureCreationFlags));
				}
				return r_MValidateIsNotCrunched_TextureCreationFlags;
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
				}
				return r_MGetPixelImpl_Injected_Int32_Int32_Int32_Int32_Out_Color;
			}
		}

		/// <summary>
		/// Void GetSafetyHandleForSlice_Injected(Int32, Int32, Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected RMethod r_MGetSafetyHandleForSlice_Injected_Int32_Int32_Out_AtomicSafetyHandle;
		public virtual RMethod RMGetSafetyHandleForSlice_Injected_Int32_Int32_Out_AtomicSafetyHandle
		{
			get
			{
				if(r_MGetSafetyHandleForSlice_Injected_Int32_Int32_Out_AtomicSafetyHandle == null)
				{
					r_MGetSafetyHandleForSlice_Injected_Int32_Int32_Out_AtomicSafetyHandle = new(this, "GetSafetyHandleForSlice_Injected", 0, typeof(System.Int32), typeof(System.Int32), typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
				}
				return r_MGetSafetyHandleForSlice_Injected_Int32_Int32_Out_AtomicSafetyHandle;
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


        public static System.Boolean Internal_CreateImpl(UnityEngine.Cubemap @mono, System.Int32 @ext, System.Int32 @mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat @format, UnityEngine.Experimental.Rendering.TextureCreationFlags @flags, System.IntPtr @nativeTex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mono, @ext, @mipCount, @format, @flags, @nativeTex};
            var ___result = RMInternal_CreateImpl_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void Internal_Create(UnityEngine.Cubemap @mono, System.Int32 @ext, System.Int32 @mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat @format, UnityEngine.Experimental.Rendering.TextureCreationFlags @flags, System.IntPtr @nativeTex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mono, @ext, @mipCount, @format, @flags, @nativeTex};
            var ___result = RMInternal_Create_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyImpl(System.Boolean @updateMipmaps, System.Boolean @makeNoLongerReadable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updateMipmaps, @makeNoLongerReadable};
            var ___result = RMApplyImpl_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateExternalTexture(System.IntPtr @nativeTexture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nativeTexture};
            var ___result = RMUpdateExternalTexture_IntPtr.Invoke(___genericsType, ___parameters);

            
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


        public virtual void SmoothEdges(System.Int32 @smoothRegionWidthInPixels)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@smoothRegionWidthInPixels};
            var ___result = RMSmoothEdges_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SmoothEdges()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSmoothEdges.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Color[] GetPixels(UnityEngine.CubemapFace @face, System.Int32 @miplevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@face, @miplevel};
            var ___result = RMGetPixels_CubemapFace_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color[])___result;
        }


        public virtual UnityEngine.Color[] GetPixels(UnityEngine.CubemapFace @face)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@face};
            var ___result = RMGetPixels_CubemapFace.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color[])___result;
        }


        public virtual void SetPixels(UnityEngine.Color[] @colors, UnityEngine.CubemapFace @face, System.Int32 @miplevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors, @face, @miplevel};
            var ___result = RMSetPixels_ColorArray_CubemapFace_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetPixelDataImplArray(System.Array @data, System.Int32 @mipLevel, System.Int32 @face, System.Int32 @elementSize, System.Int32 @dataArraySize, System.Int32 @sourceDataStartIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @mipLevel, @face, @elementSize, @dataArraySize, @sourceDataStartIndex};
            var ___result = RMSetPixelDataImplArray_Array_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SetPixelDataImpl(System.IntPtr @data, System.Int32 @mipLevel, System.Int32 @face, System.Int32 @elementSize, System.Int32 @dataArraySize, System.Int32 @sourceDataStartIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @mipLevel, @face, @elementSize, @dataArraySize, @sourceDataStartIndex};
            var ___result = RMSetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetPixels(UnityEngine.Color[] @colors, UnityEngine.CubemapFace @face)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors, @face};
            var ___result = RMSetPixels_ColorArray_CubemapFace.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetSafetyHandleForSlice(System.Int32 @mipLevel, System.Int32 @face)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mipLevel, @face};
            var ___result = RMGetSafetyHandleForSlice_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___result;
        }


        public virtual System.IntPtr GetWritableImageData(System.Int32 @frame)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@frame};
            var ___result = RMGetWritableImageData_Int32.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
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


        public virtual System.Boolean ValidateFormat(UnityEngine.TextureFormat @format, System.Int32 @width)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @width};
            var ___result = RMValidateFormat_TextureFormat_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat @format, System.Int32 @width)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @width};
            var ___result = RMValidateFormat_GraphicsFormat_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Cubemap CreateExternalTexture(System.Int32 @width, UnityEngine.TextureFormat @format, System.Boolean @mipmap, System.IntPtr @nativeTex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @format, @mipmap, @nativeTex};
            var ___result = RMCreateExternalTexture_Int32_TextureFormat_Boolean_IntPtr.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Cubemap)___result;
        }


        public virtual void SetPixelData<T>(T[] @data, System.Int32 @mipLevel, UnityEngine.CubemapFace @face, System.Int32 @sourceDataStartIndex)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data, @mipLevel, @face, @sourceDataStartIndex};
            var ___result = RMSetPixelData_GT_TArray_Int32_CubemapFace_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixelData<T>(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> @data, System.Int32 @mipLevel, UnityEngine.CubemapFace @face, System.Int32 @sourceDataStartIndex) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data.Value, @mipLevel, @face, @sourceDataStartIndex};
            var ___result = RMSetPixelData_GT_NativeArray_d_T_p__Int32_CubemapFace_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType> GetPixelData<T>(System.Int32 @mipLevel, UnityEngine.CubemapFace @face) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@mipLevel, @face};
            var ___result = RMGetPixelData_GT_Int32_CubemapFace.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RType>(___result);
        }


        public virtual void SetPixel(UnityEngine.CubemapFace @face, System.Int32 @x, System.Int32 @y, UnityEngine.Color @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@face, @x, @y, @color};
            var ___result = RMSetPixel_CubemapFace_Int32_Int32_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixel(UnityEngine.CubemapFace @face, System.Int32 @x, System.Int32 @y, UnityEngine.Color @color, System.Int32 @mip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@face, @x, @y, @color, @mip};
            var ___result = RMSetPixel_CubemapFace_Int32_Int32_Color_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Color GetPixel(UnityEngine.CubemapFace @face, System.Int32 @x, System.Int32 @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@face, @x, @y};
            var ___result = RMGetPixel_CubemapFace_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual UnityEngine.Color GetPixel(UnityEngine.CubemapFace @face, System.Int32 @x, System.Int32 @y, System.Int32 @mip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@face, @x, @y, @mip};
            var ___result = RMGetPixel_CubemapFace_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
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


        public static void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RMValidateIsNotCrunched_TextureCreationFlags.Invoke(___genericsType, ___parameters);

            
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


        public virtual void GetSafetyHandleForSlice_Injected(System.Int32 @mipLevel, System.Int32 @face, out Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle @ret)
        {
			@ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mipLevel, @face, @ret};
            var ___result = RMGetSafetyHandleForSlice_Injected_Int32_Int32_Out_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			@ret = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[2];

            
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
