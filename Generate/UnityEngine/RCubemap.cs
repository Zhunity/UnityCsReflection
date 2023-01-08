using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Cubemap
	/// </summary>
    public partial class RCubemap : RMember //
    {

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
		/// Boolean Internal_CreateImpl(UnityEngine.Cubemap, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, UnityEngine.Experimental.Rendering.TextureCreationFlags, IntPtr)
		/// </summary>
		protected static RMethod r_Internal_CreateImpl_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr;
		public static RMethod RInternal_CreateImpl_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr
		{
			get
			{
				if(r_Internal_CreateImpl_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr == null)
				{
					r_Internal_CreateImpl_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr = new(typeof(UnityEngine.Cubemap), "Internal_CreateImpl", 0, typeof(UnityEngine.Cubemap), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(UnityEngine.Experimental.Rendering.TextureCreationFlags), typeof(System.IntPtr));
					r_Internal_CreateImpl_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr.SetBelong(null);
				}
				return r_Internal_CreateImpl_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr;
			}
		}

		/// <summary>
		/// Void Internal_Create(UnityEngine.Cubemap, Int32, Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, UnityEngine.Experimental.Rendering.TextureCreationFlags, IntPtr)
		/// </summary>
		protected static RMethod r_Internal_Create_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr;
		public static RMethod RInternal_Create_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr
		{
			get
			{
				if(r_Internal_Create_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr == null)
				{
					r_Internal_Create_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr = new(typeof(UnityEngine.Cubemap), "Internal_Create", 0, typeof(UnityEngine.Cubemap), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(UnityEngine.Experimental.Rendering.TextureCreationFlags), typeof(System.IntPtr));
					r_Internal_Create_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr.SetBelong(null);
				}
				return r_Internal_Create_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr;
			}
		}

		/// <summary>
		/// Void ApplyImpl(Boolean, Boolean)
		/// </summary>
		protected RMethod r_ApplyImpl_Boolean_Boolean;
		public virtual RMethod RApplyImpl_Boolean_Boolean
		{
			get
			{
				if(r_ApplyImpl_Boolean_Boolean == null)
				{
					r_ApplyImpl_Boolean_Boolean = new(this, "ApplyImpl", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_ApplyImpl_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_ApplyImpl_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void UpdateExternalTexture(IntPtr)
		/// </summary>
		protected RMethod r_UpdateExternalTexture_IntPtr;
		public virtual RMethod RUpdateExternalTexture_IntPtr
		{
			get
			{
				if(r_UpdateExternalTexture_IntPtr == null)
				{
					r_UpdateExternalTexture_IntPtr = new(this, "UpdateExternalTexture", 0, typeof(System.IntPtr));
					r_UpdateExternalTexture_IntPtr.SetBelong(this.instance);
				}
				return r_UpdateExternalTexture_IntPtr;
			}
		}

		/// <summary>
		/// Void SetPixelImpl(Int32, Int32, Int32, Int32, UnityEngine.Color)
		/// </summary>
		protected RMethod r_SetPixelImpl_Int32_Int32_Int32_Int32_Color;
		public virtual RMethod RSetPixelImpl_Int32_Int32_Int32_Int32_Color
		{
			get
			{
				if(r_SetPixelImpl_Int32_Int32_Int32_Int32_Color == null)
				{
					r_SetPixelImpl_Int32_Int32_Int32_Int32_Color = new(this, "SetPixelImpl", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color));
					r_SetPixelImpl_Int32_Int32_Int32_Int32_Color.SetBelong(this.instance);
				}
				return r_SetPixelImpl_Int32_Int32_Int32_Int32_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetPixelImpl(Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_GetPixelImpl_Int32_Int32_Int32_Int32;
		public virtual RMethod RGetPixelImpl_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_GetPixelImpl_Int32_Int32_Int32_Int32 == null)
				{
					r_GetPixelImpl_Int32_Int32_Int32_Int32 = new(this, "GetPixelImpl", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_GetPixelImpl_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetPixelImpl_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SmoothEdges(Int32)
		/// </summary>
		protected RMethod r_SmoothEdges_Int32;
		public virtual RMethod RSmoothEdges_Int32
		{
			get
			{
				if(r_SmoothEdges_Int32 == null)
				{
					r_SmoothEdges_Int32 = new(this, "SmoothEdges", 0, typeof(System.Int32));
					r_SmoothEdges_Int32.SetBelong(this.instance);
				}
				return r_SmoothEdges_Int32;
			}
		}

		/// <summary>
		/// Void SmoothEdges()
		/// </summary>
		protected RMethod r_SmoothEdges;
		public virtual RMethod RSmoothEdges
		{
			get
			{
				if(r_SmoothEdges == null)
				{
					r_SmoothEdges = new(this, "SmoothEdges", 0);
					r_SmoothEdges.SetBelong(this.instance);
				}
				return r_SmoothEdges;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] GetPixels(UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_GetPixels_CubemapFace_Int32;
		public virtual RMethod RGetPixels_CubemapFace_Int32
		{
			get
			{
				if(r_GetPixels_CubemapFace_Int32 == null)
				{
					r_GetPixels_CubemapFace_Int32 = new(this, "GetPixels", 0, typeof(UnityEngine.CubemapFace), typeof(System.Int32));
					r_GetPixels_CubemapFace_Int32.SetBelong(this.instance);
				}
				return r_GetPixels_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] GetPixels(UnityEngine.CubemapFace)
		/// </summary>
		protected RMethod r_GetPixels_CubemapFace;
		public virtual RMethod RGetPixels_CubemapFace
		{
			get
			{
				if(r_GetPixels_CubemapFace == null)
				{
					r_GetPixels_CubemapFace = new(this, "GetPixels", 0, typeof(UnityEngine.CubemapFace));
					r_GetPixels_CubemapFace.SetBelong(this.instance);
				}
				return r_GetPixels_CubemapFace;
			}
		}

		/// <summary>
		/// Void SetPixels(UnityEngine.Color[], UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_SetPixels_ColorArray_CubemapFace_Int32;
		public virtual RMethod RSetPixels_ColorArray_CubemapFace_Int32
		{
			get
			{
				if(r_SetPixels_ColorArray_CubemapFace_Int32 == null)
				{
					r_SetPixels_ColorArray_CubemapFace_Int32 = new(this, "SetPixels", 0, typeof(UnityEngine.Color).MakeArrayType(), typeof(UnityEngine.CubemapFace), typeof(System.Int32));
					r_SetPixels_ColorArray_CubemapFace_Int32.SetBelong(this.instance);
				}
				return r_SetPixels_ColorArray_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// Boolean SetPixelDataImplArray(System.Array, Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_SetPixelDataImplArray_Array_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RSetPixelDataImplArray_Array_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_SetPixelDataImplArray_Array_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_SetPixelDataImplArray_Array_Int32_Int32_Int32_Int32_Int32 = new(this, "SetPixelDataImplArray", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_SetPixelDataImplArray_Array_Int32_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetPixelDataImplArray_Array_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean SetPixelDataImpl(IntPtr, Int32, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_SetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32_Int32;
		public virtual RMethod RSetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_SetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32_Int32 == null)
				{
					r_SetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32_Int32 = new(this, "SetPixelDataImpl", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_SetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetPixels(UnityEngine.Color[], UnityEngine.CubemapFace)
		/// </summary>
		protected RMethod r_SetPixels_ColorArray_CubemapFace;
		public virtual RMethod RSetPixels_ColorArray_CubemapFace
		{
			get
			{
				if(r_SetPixels_ColorArray_CubemapFace == null)
				{
					r_SetPixels_ColorArray_CubemapFace = new(this, "SetPixels", 0, typeof(UnityEngine.Color).MakeArrayType(), typeof(UnityEngine.CubemapFace));
					r_SetPixels_ColorArray_CubemapFace.SetBelong(this.instance);
				}
				return r_SetPixels_ColorArray_CubemapFace;
			}
		}

		/// <summary>
		/// Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetSafetyHandleForSlice(Int32, Int32)
		/// </summary>
		protected RMethod r_GetSafetyHandleForSlice_Int32_Int32;
		public virtual RMethod RGetSafetyHandleForSlice_Int32_Int32
		{
			get
			{
				if(r_GetSafetyHandleForSlice_Int32_Int32 == null)
				{
					r_GetSafetyHandleForSlice_Int32_Int32 = new(this, "GetSafetyHandleForSlice", 0, typeof(System.Int32), typeof(System.Int32));
					r_GetSafetyHandleForSlice_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetSafetyHandleForSlice_Int32_Int32;
			}
		}

		/// <summary>
		/// IntPtr GetWritableImageData(Int32)
		/// </summary>
		protected RMethod r_GetWritableImageData_Int32;
		public virtual RMethod RGetWritableImageData_Int32
		{
			get
			{
				if(r_GetWritableImageData_Int32 == null)
				{
					r_GetWritableImageData_Int32 = new(this, "GetWritableImageData", 0, typeof(System.Int32));
					r_GetWritableImageData_Int32.SetBelong(this.instance);
				}
				return r_GetWritableImageData_Int32;
			}
		}

		/// <summary>
		/// Void ClearRequestedMipmapLevel()
		/// </summary>
		protected RMethod r_ClearRequestedMipmapLevel;
		public virtual RMethod RClearRequestedMipmapLevel
		{
			get
			{
				if(r_ClearRequestedMipmapLevel == null)
				{
					r_ClearRequestedMipmapLevel = new(this, "ClearRequestedMipmapLevel", 0);
					r_ClearRequestedMipmapLevel.SetBelong(this.instance);
				}
				return r_ClearRequestedMipmapLevel;
			}
		}

		/// <summary>
		/// Boolean IsRequestedMipmapLevelLoaded()
		/// </summary>
		protected RMethod r_IsRequestedMipmapLevelLoaded;
		public virtual RMethod RIsRequestedMipmapLevelLoaded
		{
			get
			{
				if(r_IsRequestedMipmapLevelLoaded == null)
				{
					r_IsRequestedMipmapLevelLoaded = new(this, "IsRequestedMipmapLevelLoaded", 0);
					r_IsRequestedMipmapLevelLoaded.SetBelong(this.instance);
				}
				return r_IsRequestedMipmapLevelLoaded;
			}
		}

		/// <summary>
		/// Boolean ValidateFormat(UnityEngine.TextureFormat, Int32)
		/// </summary>
		protected RMethod r_ValidateFormat_TextureFormat_Int32;
		public virtual RMethod RValidateFormat_TextureFormat_Int32
		{
			get
			{
				if(r_ValidateFormat_TextureFormat_Int32 == null)
				{
					r_ValidateFormat_TextureFormat_Int32 = new(this, "ValidateFormat", 0, typeof(UnityEngine.TextureFormat), typeof(System.Int32));
					r_ValidateFormat_TextureFormat_Int32.SetBelong(this.instance);
				}
				return r_ValidateFormat_TextureFormat_Int32;
			}
		}

		/// <summary>
		/// Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat, Int32)
		/// </summary>
		protected RMethod r_ValidateFormat_GraphicsFormat_Int32;
		public virtual RMethod RValidateFormat_GraphicsFormat_Int32
		{
			get
			{
				if(r_ValidateFormat_GraphicsFormat_Int32 == null)
				{
					r_ValidateFormat_GraphicsFormat_Int32 = new(this, "ValidateFormat", 0, typeof(UnityEngine.Experimental.Rendering.GraphicsFormat), typeof(System.Int32));
					r_ValidateFormat_GraphicsFormat_Int32.SetBelong(this.instance);
				}
				return r_ValidateFormat_GraphicsFormat_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Cubemap CreateExternalTexture(Int32, UnityEngine.TextureFormat, Boolean, IntPtr)
		/// </summary>
		protected static RMethod r_CreateExternalTexture_Int32_TextureFormat_Boolean_IntPtr;
		public static RMethod RCreateExternalTexture_Int32_TextureFormat_Boolean_IntPtr
		{
			get
			{
				if(r_CreateExternalTexture_Int32_TextureFormat_Boolean_IntPtr == null)
				{
					r_CreateExternalTexture_Int32_TextureFormat_Boolean_IntPtr = new(typeof(UnityEngine.Cubemap), "CreateExternalTexture", 0, typeof(System.Int32), typeof(UnityEngine.TextureFormat), typeof(System.Boolean), typeof(System.IntPtr));
					r_CreateExternalTexture_Int32_TextureFormat_Boolean_IntPtr.SetBelong(null);
				}
				return r_CreateExternalTexture_Int32_TextureFormat_Boolean_IntPtr;
			}
		}

		/// <summary>
		/// Void SetPixelData[T](T[], Int32, UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_SetPixelData_GT_TArray_Int32_CubemapFace_Int32;
		public virtual RMethod RSetPixelData_GT_TArray_Int32_CubemapFace_Int32
		{
			get
			{
				if(r_SetPixelData_GT_TArray_Int32_CubemapFace_Int32 == null)
				{
					r_SetPixelData_GT_TArray_Int32_CubemapFace_Int32 = new(this, "SetPixelData", 1, Type.MakeGenericMethodParameter(0).MakeArrayType(), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32));
					r_SetPixelData_GT_TArray_Int32_CubemapFace_Int32.SetBelong(this.instance);
				}
				return r_SetPixelData_GT_TArray_Int32_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// Void SetPixelData[T](Unity.Collections.NativeArray`1[T], Int32, UnityEngine.CubemapFace, Int32)
		/// </summary>
		protected RMethod r_SetPixelData_GT_NativeArray_d_T_p__Int32_CubemapFace_Int32;
		public virtual RMethod RSetPixelData_GT_NativeArray_d_T_p__Int32_CubemapFace_Int32
		{
			get
			{
				if(r_SetPixelData_GT_NativeArray_d_T_p__Int32_CubemapFace_Int32 == null)
				{
					r_SetPixelData_GT_NativeArray_d_T_p__Int32_CubemapFace_Int32 = new(this, "SetPixelData", 1, typeof(Unity.Collections.NativeArray<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32));
					r_SetPixelData_GT_NativeArray_d_T_p__Int32_CubemapFace_Int32.SetBelong(this.instance);
				}
				return r_SetPixelData_GT_NativeArray_d_T_p__Int32_CubemapFace_Int32;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[T] GetPixelData[T](Int32, UnityEngine.CubemapFace)
		/// </summary>
		protected RMethod r_GetPixelData_GT_Int32_CubemapFace;
		public virtual RMethod RGetPixelData_GT_Int32_CubemapFace
		{
			get
			{
				if(r_GetPixelData_GT_Int32_CubemapFace == null)
				{
					r_GetPixelData_GT_Int32_CubemapFace = new(this, "GetPixelData", 1, typeof(System.Int32), typeof(UnityEngine.CubemapFace));
					r_GetPixelData_GT_Int32_CubemapFace.SetBelong(this.instance);
				}
				return r_GetPixelData_GT_Int32_CubemapFace;
			}
		}

		/// <summary>
		/// Void SetPixel(UnityEngine.CubemapFace, Int32, Int32, UnityEngine.Color)
		/// </summary>
		protected RMethod r_SetPixel_CubemapFace_Int32_Int32_Color;
		public virtual RMethod RSetPixel_CubemapFace_Int32_Int32_Color
		{
			get
			{
				if(r_SetPixel_CubemapFace_Int32_Int32_Color == null)
				{
					r_SetPixel_CubemapFace_Int32_Int32_Color = new(this, "SetPixel", 0, typeof(UnityEngine.CubemapFace), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color));
					r_SetPixel_CubemapFace_Int32_Int32_Color.SetBelong(this.instance);
				}
				return r_SetPixel_CubemapFace_Int32_Int32_Color;
			}
		}

		/// <summary>
		/// Void SetPixel(UnityEngine.CubemapFace, Int32, Int32, UnityEngine.Color, Int32)
		/// </summary>
		protected RMethod r_SetPixel_CubemapFace_Int32_Int32_Color_Int32;
		public virtual RMethod RSetPixel_CubemapFace_Int32_Int32_Color_Int32
		{
			get
			{
				if(r_SetPixel_CubemapFace_Int32_Int32_Color_Int32 == null)
				{
					r_SetPixel_CubemapFace_Int32_Int32_Color_Int32 = new(this, "SetPixel", 0, typeof(UnityEngine.CubemapFace), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color), typeof(System.Int32));
					r_SetPixel_CubemapFace_Int32_Int32_Color_Int32.SetBelong(this.instance);
				}
				return r_SetPixel_CubemapFace_Int32_Int32_Color_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetPixel(UnityEngine.CubemapFace, Int32, Int32)
		/// </summary>
		protected RMethod r_GetPixel_CubemapFace_Int32_Int32;
		public virtual RMethod RGetPixel_CubemapFace_Int32_Int32
		{
			get
			{
				if(r_GetPixel_CubemapFace_Int32_Int32 == null)
				{
					r_GetPixel_CubemapFace_Int32_Int32 = new(this, "GetPixel", 0, typeof(UnityEngine.CubemapFace), typeof(System.Int32), typeof(System.Int32));
					r_GetPixel_CubemapFace_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetPixel_CubemapFace_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetPixel(UnityEngine.CubemapFace, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_GetPixel_CubemapFace_Int32_Int32_Int32;
		public virtual RMethod RGetPixel_CubemapFace_Int32_Int32_Int32
		{
			get
			{
				if(r_GetPixel_CubemapFace_Int32_Int32_Int32 == null)
				{
					r_GetPixel_CubemapFace_Int32_Int32_Int32 = new(this, "GetPixel", 0, typeof(UnityEngine.CubemapFace), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_GetPixel_CubemapFace_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_GetPixel_CubemapFace_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Apply(Boolean, Boolean)
		/// </summary>
		protected RMethod r_Apply_Boolean_Boolean;
		public virtual RMethod RApply_Boolean_Boolean
		{
			get
			{
				if(r_Apply_Boolean_Boolean == null)
				{
					r_Apply_Boolean_Boolean = new(this, "Apply", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_Apply_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_Apply_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void Apply(Boolean)
		/// </summary>
		protected RMethod r_Apply_Boolean;
		public virtual RMethod RApply_Boolean
		{
			get
			{
				if(r_Apply_Boolean == null)
				{
					r_Apply_Boolean = new(this, "Apply", 0, typeof(System.Boolean));
					r_Apply_Boolean.SetBelong(this.instance);
				}
				return r_Apply_Boolean;
			}
		}

		/// <summary>
		/// Void Apply()
		/// </summary>
		protected RMethod r_Apply;
		public virtual RMethod RApply
		{
			get
			{
				if(r_Apply == null)
				{
					r_Apply = new(this, "Apply", 0);
					r_Apply.SetBelong(this.instance);
				}
				return r_Apply;
			}
		}

		/// <summary>
		/// Void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags)
		/// </summary>
		protected static RMethod r_ValidateIsNotCrunched_TextureCreationFlags;
		public static RMethod RValidateIsNotCrunched_TextureCreationFlags
		{
			get
			{
				if(r_ValidateIsNotCrunched_TextureCreationFlags == null)
				{
					r_ValidateIsNotCrunched_TextureCreationFlags = new(typeof(UnityEngine.Cubemap), "ValidateIsNotCrunched", 0, typeof(UnityEngine.Experimental.Rendering.TextureCreationFlags));
					r_ValidateIsNotCrunched_TextureCreationFlags.SetBelong(null);
				}
				return r_ValidateIsNotCrunched_TextureCreationFlags;
			}
		}

		/// <summary>
		/// Void SetPixelImpl_Injected(Int32, Int32, Int32, Int32, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_SetPixelImpl_Injected_Int32_Int32_Int32_Int32_Ref_Color;
		public virtual RMethod RSetPixelImpl_Injected_Int32_Int32_Int32_Int32_Ref_Color
		{
			get
			{
				if(r_SetPixelImpl_Injected_Int32_Int32_Int32_Int32_Ref_Color == null)
				{
					r_SetPixelImpl_Injected_Int32_Int32_Int32_Int32_Ref_Color = new(this, "SetPixelImpl_Injected", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color).MakeByRefType());
					r_SetPixelImpl_Injected_Int32_Int32_Int32_Int32_Ref_Color.SetBelong(this.instance);
				}
				return r_SetPixelImpl_Injected_Int32_Int32_Int32_Int32_Ref_Color;
			}
		}

		/// <summary>
		/// Void GetPixelImpl_Injected(Int32, Int32, Int32, Int32, UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_GetPixelImpl_Injected_Int32_Int32_Int32_Int32_Out_Color;
		public virtual RMethod RGetPixelImpl_Injected_Int32_Int32_Int32_Int32_Out_Color
		{
			get
			{
				if(r_GetPixelImpl_Injected_Int32_Int32_Int32_Int32_Out_Color == null)
				{
					r_GetPixelImpl_Injected_Int32_Int32_Int32_Int32_Out_Color = new(this, "GetPixelImpl_Injected", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color).MakeByRefType());
					r_GetPixelImpl_Injected_Int32_Int32_Int32_Int32_Out_Color.SetBelong(this.instance);
				}
				return r_GetPixelImpl_Injected_Int32_Int32_Int32_Int32_Out_Color;
			}
		}

		/// <summary>
		/// Void GetSafetyHandleForSlice_Injected(Int32, Int32, Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle ByRef)
		/// </summary>
		protected RMethod r_GetSafetyHandleForSlice_Injected_Int32_Int32_Out_AtomicSafetyHandle;
		public virtual RMethod RGetSafetyHandleForSlice_Injected_Int32_Int32_Out_AtomicSafetyHandle
		{
			get
			{
				if(r_GetSafetyHandleForSlice_Injected_Int32_Int32_Out_AtomicSafetyHandle == null)
				{
					r_GetSafetyHandleForSlice_Injected_Int32_Int32_Out_AtomicSafetyHandle = new(this, "GetSafetyHandleForSlice_Injected", 0, typeof(System.Int32), typeof(System.Int32), typeof(Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle).MakeByRefType());
					r_GetSafetyHandleForSlice_Injected_Int32_Int32_Out_AtomicSafetyHandle.SetBelong(this.instance);
				}
				return r_GetSafetyHandleForSlice_Injected_Int32_Int32_Out_AtomicSafetyHandle;
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

        public static System.Boolean Internal_CreateImpl(UnityEngine.Cubemap  @mono, System.Int32  @ext, System.Int32  @mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat  @format, UnityEngine.Experimental.Rendering.TextureCreationFlags  @flags, System.IntPtr  @nativeTex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mono, @ext, @mipCount, @format, @flags, @nativeTex};
            var ___result = RInternal_CreateImpl_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void Internal_Create(UnityEngine.Cubemap  @mono, System.Int32  @ext, System.Int32  @mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat  @format, UnityEngine.Experimental.Rendering.TextureCreationFlags  @flags, System.IntPtr  @nativeTex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mono, @ext, @mipCount, @format, @flags, @nativeTex};
            var ___result = RInternal_Create_Cubemap_Int32_Int32_GraphicsFormat_TextureCreationFlags_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyImpl(System.Boolean  @updateMipmaps, System.Boolean  @makeNoLongerReadable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updateMipmaps, @makeNoLongerReadable};
            var ___result = RApplyImpl_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateExternalTexture(System.IntPtr  @nativeTexture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nativeTexture};
            var ___result = RUpdateExternalTexture_IntPtr.Invoke(___genericsType, ___parameters);

            
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


        public virtual void SmoothEdges(System.Int32  @smoothRegionWidthInPixels)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@smoothRegionWidthInPixels};
            var ___result = RSmoothEdges_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SmoothEdges()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSmoothEdges.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Color[] GetPixels(UnityEngine.CubemapFace  @face, System.Int32  @miplevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@face, @miplevel};
            var ___result = RGetPixels_CubemapFace_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color[])___result;
        }


        public virtual UnityEngine.Color[] GetPixels(UnityEngine.CubemapFace  @face)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@face};
            var ___result = RGetPixels_CubemapFace.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color[])___result;
        }


        public virtual void SetPixels(UnityEngine.Color[]  @colors, UnityEngine.CubemapFace  @face, System.Int32  @miplevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors, @face, @miplevel};
            var ___result = RSetPixels_ColorArray_CubemapFace_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetPixelDataImplArray(System.Array  @data, System.Int32  @mipLevel, System.Int32  @face, System.Int32  @elementSize, System.Int32  @dataArraySize, System.Int32  @sourceDataStartIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @mipLevel, @face, @elementSize, @dataArraySize, @sourceDataStartIndex};
            var ___result = RSetPixelDataImplArray_Array_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SetPixelDataImpl(System.IntPtr  @data, System.Int32  @mipLevel, System.Int32  @face, System.Int32  @elementSize, System.Int32  @dataArraySize, System.Int32  @sourceDataStartIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @mipLevel, @face, @elementSize, @dataArraySize, @sourceDataStartIndex};
            var ___result = RSetPixelDataImpl_IntPtr_Int32_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetPixels(UnityEngine.Color[]  @colors, UnityEngine.CubemapFace  @face)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colors, @face};
            var ___result = RSetPixels_ColorArray_CubemapFace.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle GetSafetyHandleForSlice(System.Int32  @mipLevel, System.Int32  @face)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mipLevel, @face};
            var ___result = RGetSafetyHandleForSlice_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___result;
        }


        public virtual System.IntPtr GetWritableImageData(System.Int32  @frame)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@frame};
            var ___result = RGetWritableImageData_Int32.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
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


        public virtual System.Boolean ValidateFormat(UnityEngine.TextureFormat  @format, System.Int32  @width)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @width};
            var ___result = RValidateFormat_TextureFormat_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat  @format, System.Int32  @width)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @width};
            var ___result = RValidateFormat_GraphicsFormat_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Cubemap CreateExternalTexture(System.Int32  @width, UnityEngine.TextureFormat  @format, System.Boolean  @mipmap, System.IntPtr  @nativeTex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@width, @format, @mipmap, @nativeTex};
            var ___result = RCreateExternalTexture_Int32_TextureFormat_Boolean_IntPtr.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Cubemap)___result;
        }


        public virtual void SetPixelData<T>(T[]  @data, System.Int32  @mipLevel, UnityEngine.CubemapFace  @face, System.Int32  @sourceDataStartIndex)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@data, @mipLevel, @face, @sourceDataStartIndex};
            var ___result = RSetPixelData_GT_TArray_Int32_CubemapFace_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Object GetPixelData<T>(System.Int32  @mipLevel, UnityEngine.CubemapFace  @face) where T : struct
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@mipLevel, @face};
            var ___result = RGetPixelData_GT_Int32_CubemapFace.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetPixel(UnityEngine.CubemapFace  @face, System.Int32  @x, System.Int32  @y, UnityEngine.Color  @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@face, @x, @y, @color};
            var ___result = RSetPixel_CubemapFace_Int32_Int32_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPixel(UnityEngine.CubemapFace  @face, System.Int32  @x, System.Int32  @y, UnityEngine.Color  @color, System.Int32  @mip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@face, @x, @y, @color, @mip};
            var ___result = RSetPixel_CubemapFace_Int32_Int32_Color_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Color GetPixel(UnityEngine.CubemapFace  @face, System.Int32  @x, System.Int32  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@face, @x, @y};
            var ___result = RGetPixel_CubemapFace_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual UnityEngine.Color GetPixel(UnityEngine.CubemapFace  @face, System.Int32  @x, System.Int32  @y, System.Int32  @mip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@face, @x, @y, @mip};
            var ___result = RGetPixel_CubemapFace_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
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


        public static void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags};
            var ___result = RValidateIsNotCrunched_TextureCreationFlags.Invoke(___genericsType, ___parameters);

            
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


        public virtual void GetSafetyHandleForSlice_Injected(System.Int32  @mipLevel, System.Int32  @face, out Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mipLevel, @face, @ret};
            var ___result = RGetSafetyHandleForSlice_Injected_Int32_Int32_Out_AtomicSafetyHandle.Invoke(___genericsType, ___parameters);
			ret = (Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle)___parameters[2];

            
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
