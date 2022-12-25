using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RExperimental.RRendering
{
	/// <summary>
	/// UnityEngine.Experimental.Rendering.RayTracingShader
	/// </summary>
    public partial class RRayTracingShader : RMember //
    {

		/// <summary>
		/// Single maxRecursionDepth
		/// </summary>
		protected RProperty r_maxRecursionDepth;
		public virtual RProperty RmaxRecursionDepth
		{
			get
			{
				if(r_maxRecursionDepth == null)
				{
					r_maxRecursionDepth = new(this, "maxRecursionDepth", -1);
					r_maxRecursionDepth.SetBelong(this.instance);
				}
				return r_maxRecursionDepth;
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
		/// Void SetFloat(Int32, Single)
		/// </summary>
		protected RMethod r_RSetFloat_Int32_Single;
		public virtual RMethod RSetFloat_Int32_Single
		{
			get
			{
				if(r_RSetFloat_Int32_Single == null)
				{
					r_RSetFloat_Int32_Single = new(this, "SetFloat", 0, typeof(System.Int32), typeof(System.Single));
					r_RSetFloat_Int32_Single.SetBelong(this.instance);
				}
				return r_RSetFloat_Int32_Single;
			}
		}

		/// <summary>
		/// Void SetInt(Int32, Int32)
		/// </summary>
		protected RMethod r_RSetInt_Int32_Int32;
		public virtual RMethod RSetInt_Int32_Int32
		{
			get
			{
				if(r_RSetInt_Int32_Int32 == null)
				{
					r_RSetInt_Int32_Int32 = new(this, "SetInt", 0, typeof(System.Int32), typeof(System.Int32));
					r_RSetInt_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetInt_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetVector(Int32, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_RSetVector_Int32_Vector4;
		public virtual RMethod RSetVector_Int32_Vector4
		{
			get
			{
				if(r_RSetVector_Int32_Vector4 == null)
				{
					r_RSetVector_Int32_Vector4 = new(this, "SetVector", 0, typeof(System.Int32), typeof(UnityEngine.Vector4));
					r_RSetVector_Int32_Vector4.SetBelong(this.instance);
				}
				return r_RSetVector_Int32_Vector4;
			}
		}

		/// <summary>
		/// Void SetMatrix(Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_RSetMatrix_Int32_Matrix4x4;
		public virtual RMethod RSetMatrix_Int32_Matrix4x4
		{
			get
			{
				if(r_RSetMatrix_Int32_Matrix4x4 == null)
				{
					r_RSetMatrix_Int32_Matrix4x4 = new(this, "SetMatrix", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
					r_RSetMatrix_Int32_Matrix4x4.SetBelong(this.instance);
				}
				return r_RSetMatrix_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetFloatArray(Int32, Single[])
		/// </summary>
		protected RMethod r_RSetFloatArray_Int32_SingleArray;
		public virtual RMethod RSetFloatArray_Int32_SingleArray
		{
			get
			{
				if(r_RSetFloatArray_Int32_SingleArray == null)
				{
					r_RSetFloatArray_Int32_SingleArray = new(this, "SetFloatArray", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType());
					r_RSetFloatArray_Int32_SingleArray.SetBelong(this.instance);
				}
				return r_RSetFloatArray_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void SetIntArray(Int32, Int32[])
		/// </summary>
		protected RMethod r_RSetIntArray_Int32_Int32Array;
		public virtual RMethod RSetIntArray_Int32_Int32Array
		{
			get
			{
				if(r_RSetIntArray_Int32_Int32Array == null)
				{
					r_RSetIntArray_Int32_Int32Array = new(this, "SetIntArray", 0, typeof(System.Int32), typeof(System.Int32).MakeArrayType());
					r_RSetIntArray_Int32_Int32Array.SetBelong(this.instance);
				}
				return r_RSetIntArray_Int32_Int32Array;
			}
		}

		/// <summary>
		/// Void SetVectorArray(Int32, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_RSetVectorArray_Int32_Vector4Array;
		public virtual RMethod RSetVectorArray_Int32_Vector4Array
		{
			get
			{
				if(r_RSetVectorArray_Int32_Vector4Array == null)
				{
					r_RSetVectorArray_Int32_Vector4Array = new(this, "SetVectorArray", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
					r_RSetVectorArray_Int32_Vector4Array.SetBelong(this.instance);
				}
				return r_RSetVectorArray_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetMatrixArray(Int32, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_RSetMatrixArray_Int32_Matrix4x4Array;
		public virtual RMethod RSetMatrixArray_Int32_Matrix4x4Array
		{
			get
			{
				if(r_RSetMatrixArray_Int32_Matrix4x4Array == null)
				{
					r_RSetMatrixArray_Int32_Matrix4x4Array = new(this, "SetMatrixArray", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_RSetMatrixArray_Int32_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_RSetMatrixArray_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void SetTexture(Int32, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_RSetTexture_Int32_Texture;
		public virtual RMethod RSetTexture_Int32_Texture
		{
			get
			{
				if(r_RSetTexture_Int32_Texture == null)
				{
					r_RSetTexture_Int32_Texture = new(this, "SetTexture", 0, typeof(System.Int32), typeof(UnityEngine.Texture));
					r_RSetTexture_Int32_Texture.SetBelong(this.instance);
				}
				return r_RSetTexture_Int32_Texture;
			}
		}

		/// <summary>
		/// Void SetBuffer(Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_RSetBuffer_Int32_ComputeBuffer;
		public virtual RMethod RSetBuffer_Int32_ComputeBuffer
		{
			get
			{
				if(r_RSetBuffer_Int32_ComputeBuffer == null)
				{
					r_RSetBuffer_Int32_ComputeBuffer = new(this, "SetBuffer", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_RSetBuffer_Int32_ComputeBuffer.SetBelong(this.instance);
				}
				return r_RSetBuffer_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetGraphicsBuffer(Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_RSetGraphicsBuffer_Int32_GraphicsBuffer;
		public virtual RMethod RSetGraphicsBuffer_Int32_GraphicsBuffer
		{
			get
			{
				if(r_RSetGraphicsBuffer_Int32_GraphicsBuffer == null)
				{
					r_RSetGraphicsBuffer_Int32_GraphicsBuffer = new(this, "SetGraphicsBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_RSetGraphicsBuffer_Int32_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_RSetGraphicsBuffer_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetConstantComputeBuffer(Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32;
		public virtual RMethod RSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_RSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_RSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32 = new(this, "SetConstantComputeBuffer", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetConstantGraphicsBuffer(Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_RSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_RSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32 = new(this, "SetConstantGraphicsBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetAccelerationStructure(Int32, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)
		/// </summary>
		protected RMethod r_RSetAccelerationStructure_Int32_RayTracingAccelerationStructure;
		public virtual RMethod RSetAccelerationStructure_Int32_RayTracingAccelerationStructure
		{
			get
			{
				if(r_RSetAccelerationStructure_Int32_RayTracingAccelerationStructure == null)
				{
					r_RSetAccelerationStructure_Int32_RayTracingAccelerationStructure = new(this, "SetAccelerationStructure", 0, typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure));
					r_RSetAccelerationStructure_Int32_RayTracingAccelerationStructure.SetBelong(this.instance);
				}
				return r_RSetAccelerationStructure_Int32_RayTracingAccelerationStructure;
			}
		}

		/// <summary>
		/// Void SetShaderPass(System.String)
		/// </summary>
		protected RMethod r_RSetShaderPass_String;
		public virtual RMethod RSetShaderPass_String
		{
			get
			{
				if(r_RSetShaderPass_String == null)
				{
					r_RSetShaderPass_String = new(this, "SetShaderPass", 0, typeof(System.String));
					r_RSetShaderPass_String.SetBelong(this.instance);
				}
				return r_RSetShaderPass_String;
			}
		}

		/// <summary>
		/// Void SetTextureFromGlobal(Int32, Int32)
		/// </summary>
		protected RMethod r_RSetTextureFromGlobal_Int32_Int32;
		public virtual RMethod RSetTextureFromGlobal_Int32_Int32
		{
			get
			{
				if(r_RSetTextureFromGlobal_Int32_Int32 == null)
				{
					r_RSetTextureFromGlobal_Int32_Int32 = new(this, "SetTextureFromGlobal", 0, typeof(System.Int32), typeof(System.Int32));
					r_RSetTextureFromGlobal_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetTextureFromGlobal_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Dispatch(System.String, Int32, Int32, Int32, UnityEngine.Camera)
		/// </summary>
		protected RMethod r_RDispatch_String_Int32_Int32_Int32_Camera;
		public virtual RMethod RDispatch_String_Int32_Int32_Int32_Camera
		{
			get
			{
				if(r_RDispatch_String_Int32_Int32_Int32_Camera == null)
				{
					r_RDispatch_String_Int32_Int32_Int32_Camera = new(this, "Dispatch", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Camera));
					r_RDispatch_String_Int32_Int32_Int32_Camera.SetBelong(this.instance);
				}
				return r_RDispatch_String_Int32_Int32_Int32_Camera;
			}
		}

		/// <summary>
		/// Void SetBuffer(Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_RSetBuffer_Int32_GraphicsBuffer;
		public virtual RMethod RSetBuffer_Int32_GraphicsBuffer
		{
			get
			{
				if(r_RSetBuffer_Int32_GraphicsBuffer == null)
				{
					r_RSetBuffer_Int32_GraphicsBuffer = new(this, "SetBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_RSetBuffer_Int32_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_RSetBuffer_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetFloat(System.String, Single)
		/// </summary>
		protected RMethod r_RSetFloat_String_Single;
		public virtual RMethod RSetFloat_String_Single
		{
			get
			{
				if(r_RSetFloat_String_Single == null)
				{
					r_RSetFloat_String_Single = new(this, "SetFloat", 0, typeof(System.String), typeof(System.Single));
					r_RSetFloat_String_Single.SetBelong(this.instance);
				}
				return r_RSetFloat_String_Single;
			}
		}

		/// <summary>
		/// Void SetInt(System.String, Int32)
		/// </summary>
		protected RMethod r_RSetInt_String_Int32;
		public virtual RMethod RSetInt_String_Int32
		{
			get
			{
				if(r_RSetInt_String_Int32 == null)
				{
					r_RSetInt_String_Int32 = new(this, "SetInt", 0, typeof(System.String), typeof(System.Int32));
					r_RSetInt_String_Int32.SetBelong(this.instance);
				}
				return r_RSetInt_String_Int32;
			}
		}

		/// <summary>
		/// Void SetVector(System.String, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_RSetVector_String_Vector4;
		public virtual RMethod RSetVector_String_Vector4
		{
			get
			{
				if(r_RSetVector_String_Vector4 == null)
				{
					r_RSetVector_String_Vector4 = new(this, "SetVector", 0, typeof(System.String), typeof(UnityEngine.Vector4));
					r_RSetVector_String_Vector4.SetBelong(this.instance);
				}
				return r_RSetVector_String_Vector4;
			}
		}

		/// <summary>
		/// Void SetMatrix(System.String, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_RSetMatrix_String_Matrix4x4;
		public virtual RMethod RSetMatrix_String_Matrix4x4
		{
			get
			{
				if(r_RSetMatrix_String_Matrix4x4 == null)
				{
					r_RSetMatrix_String_Matrix4x4 = new(this, "SetMatrix", 0, typeof(System.String), typeof(UnityEngine.Matrix4x4));
					r_RSetMatrix_String_Matrix4x4.SetBelong(this.instance);
				}
				return r_RSetMatrix_String_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetVectorArray(System.String, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_RSetVectorArray_String_Vector4Array;
		public virtual RMethod RSetVectorArray_String_Vector4Array
		{
			get
			{
				if(r_RSetVectorArray_String_Vector4Array == null)
				{
					r_RSetVectorArray_String_Vector4Array = new(this, "SetVectorArray", 0, typeof(System.String), typeof(UnityEngine.Vector4).MakeArrayType());
					r_RSetVectorArray_String_Vector4Array.SetBelong(this.instance);
				}
				return r_RSetVectorArray_String_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetMatrixArray(System.String, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_RSetMatrixArray_String_Matrix4x4Array;
		public virtual RMethod RSetMatrixArray_String_Matrix4x4Array
		{
			get
			{
				if(r_RSetMatrixArray_String_Matrix4x4Array == null)
				{
					r_RSetMatrixArray_String_Matrix4x4Array = new(this, "SetMatrixArray", 0, typeof(System.String), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_RSetMatrixArray_String_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_RSetMatrixArray_String_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void SetFloats(System.String, Single[])
		/// </summary>
		protected RMethod r_RSetFloats_String_SingleArray;
		public virtual RMethod RSetFloats_String_SingleArray
		{
			get
			{
				if(r_RSetFloats_String_SingleArray == null)
				{
					r_RSetFloats_String_SingleArray = new(this, "SetFloats", 0, typeof(System.String), typeof(System.Single).MakeArrayType());
					r_RSetFloats_String_SingleArray.SetBelong(this.instance);
				}
				return r_RSetFloats_String_SingleArray;
			}
		}

		/// <summary>
		/// Void SetFloats(Int32, Single[])
		/// </summary>
		protected RMethod r_RSetFloats_Int32_SingleArray;
		public virtual RMethod RSetFloats_Int32_SingleArray
		{
			get
			{
				if(r_RSetFloats_Int32_SingleArray == null)
				{
					r_RSetFloats_Int32_SingleArray = new(this, "SetFloats", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType());
					r_RSetFloats_Int32_SingleArray.SetBelong(this.instance);
				}
				return r_RSetFloats_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void SetInts(System.String, Int32[])
		/// </summary>
		protected RMethod r_RSetInts_String_Int32Array;
		public virtual RMethod RSetInts_String_Int32Array
		{
			get
			{
				if(r_RSetInts_String_Int32Array == null)
				{
					r_RSetInts_String_Int32Array = new(this, "SetInts", 0, typeof(System.String), typeof(System.Int32).MakeArrayType());
					r_RSetInts_String_Int32Array.SetBelong(this.instance);
				}
				return r_RSetInts_String_Int32Array;
			}
		}

		/// <summary>
		/// Void SetInts(Int32, Int32[])
		/// </summary>
		protected RMethod r_RSetInts_Int32_Int32Array;
		public virtual RMethod RSetInts_Int32_Int32Array
		{
			get
			{
				if(r_RSetInts_Int32_Int32Array == null)
				{
					r_RSetInts_Int32_Int32Array = new(this, "SetInts", 0, typeof(System.Int32), typeof(System.Int32).MakeArrayType());
					r_RSetInts_Int32_Int32Array.SetBelong(this.instance);
				}
				return r_RSetInts_Int32_Int32Array;
			}
		}

		/// <summary>
		/// Void SetBool(System.String, Boolean)
		/// </summary>
		protected RMethod r_RSetBool_String_Boolean;
		public virtual RMethod RSetBool_String_Boolean
		{
			get
			{
				if(r_RSetBool_String_Boolean == null)
				{
					r_RSetBool_String_Boolean = new(this, "SetBool", 0, typeof(System.String), typeof(System.Boolean));
					r_RSetBool_String_Boolean.SetBelong(this.instance);
				}
				return r_RSetBool_String_Boolean;
			}
		}

		/// <summary>
		/// Void SetBool(Int32, Boolean)
		/// </summary>
		protected RMethod r_RSetBool_Int32_Boolean;
		public virtual RMethod RSetBool_Int32_Boolean
		{
			get
			{
				if(r_RSetBool_Int32_Boolean == null)
				{
					r_RSetBool_Int32_Boolean = new(this, "SetBool", 0, typeof(System.Int32), typeof(System.Boolean));
					r_RSetBool_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RSetBool_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetTexture(System.String, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_RSetTexture_String_Texture;
		public virtual RMethod RSetTexture_String_Texture
		{
			get
			{
				if(r_RSetTexture_String_Texture == null)
				{
					r_RSetTexture_String_Texture = new(this, "SetTexture", 0, typeof(System.String), typeof(UnityEngine.Texture));
					r_RSetTexture_String_Texture.SetBelong(this.instance);
				}
				return r_RSetTexture_String_Texture;
			}
		}

		/// <summary>
		/// Void SetBuffer(System.String, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_RSetBuffer_String_ComputeBuffer;
		public virtual RMethod RSetBuffer_String_ComputeBuffer
		{
			get
			{
				if(r_RSetBuffer_String_ComputeBuffer == null)
				{
					r_RSetBuffer_String_ComputeBuffer = new(this, "SetBuffer", 0, typeof(System.String), typeof(UnityEngine.ComputeBuffer));
					r_RSetBuffer_String_ComputeBuffer.SetBelong(this.instance);
				}
				return r_RSetBuffer_String_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetBuffer(System.String, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_RSetBuffer_String_GraphicsBuffer;
		public virtual RMethod RSetBuffer_String_GraphicsBuffer
		{
			get
			{
				if(r_RSetBuffer_String_GraphicsBuffer == null)
				{
					r_RSetBuffer_String_GraphicsBuffer = new(this, "SetBuffer", 0, typeof(System.String), typeof(UnityEngine.GraphicsBuffer));
					r_RSetBuffer_String_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_RSetBuffer_String_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetConstantBuffer(Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32;
		public virtual RMethod RSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_RSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_RSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32 = new(this, "SetConstantBuffer", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetConstantBuffer(System.String, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetConstantBuffer_String_ComputeBuffer_Int32_Int32;
		public virtual RMethod RSetConstantBuffer_String_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_RSetConstantBuffer_String_ComputeBuffer_Int32_Int32 == null)
				{
					r_RSetConstantBuffer_String_ComputeBuffer_Int32_Int32 = new(this, "SetConstantBuffer", 0, typeof(System.String), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RSetConstantBuffer_String_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetConstantBuffer_String_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetConstantBuffer(Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_RSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_RSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32 = new(this, "SetConstantBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetConstantBuffer(System.String, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_RSetConstantBuffer_String_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RSetConstantBuffer_String_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_RSetConstantBuffer_String_GraphicsBuffer_Int32_Int32 == null)
				{
					r_RSetConstantBuffer_String_GraphicsBuffer_Int32_Int32 = new(this, "SetConstantBuffer", 0, typeof(System.String), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_RSetConstantBuffer_String_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetConstantBuffer_String_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetAccelerationStructure(System.String, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)
		/// </summary>
		protected RMethod r_RSetAccelerationStructure_String_RayTracingAccelerationStructure;
		public virtual RMethod RSetAccelerationStructure_String_RayTracingAccelerationStructure
		{
			get
			{
				if(r_RSetAccelerationStructure_String_RayTracingAccelerationStructure == null)
				{
					r_RSetAccelerationStructure_String_RayTracingAccelerationStructure = new(this, "SetAccelerationStructure", 0, typeof(System.String), typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure));
					r_RSetAccelerationStructure_String_RayTracingAccelerationStructure.SetBelong(this.instance);
				}
				return r_RSetAccelerationStructure_String_RayTracingAccelerationStructure;
			}
		}

		/// <summary>
		/// Void SetTextureFromGlobal(System.String, System.String)
		/// </summary>
		protected RMethod r_RSetTextureFromGlobal_String_String;
		public virtual RMethod RSetTextureFromGlobal_String_String
		{
			get
			{
				if(r_RSetTextureFromGlobal_String_String == null)
				{
					r_RSetTextureFromGlobal_String_String = new(this, "SetTextureFromGlobal", 0, typeof(System.String), typeof(System.String));
					r_RSetTextureFromGlobal_String_String.SetBelong(this.instance);
				}
				return r_RSetTextureFromGlobal_String_String;
			}
		}

		/// <summary>
		/// Void SetVector_Injected(Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_RSetVector_Injected_Int32_Ref_Vector4;
		public virtual RMethod RSetVector_Injected_Int32_Ref_Vector4
		{
			get
			{
				if(r_RSetVector_Injected_Int32_Ref_Vector4 == null)
				{
					r_RSetVector_Injected_Int32_Ref_Vector4 = new(this, "SetVector_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
					r_RSetVector_Injected_Int32_Ref_Vector4.SetBelong(this.instance);
				}
				return r_RSetVector_Injected_Int32_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void SetMatrix_Injected(Int32, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_RSetMatrix_Injected_Int32_Ref_Matrix4x4;
		public virtual RMethod RSetMatrix_Injected_Int32_Ref_Matrix4x4
		{
			get
			{
				if(r_RSetMatrix_Injected_Int32_Ref_Matrix4x4 == null)
				{
					r_RSetMatrix_Injected_Int32_Ref_Matrix4x4 = new(this, "SetMatrix_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_RSetMatrix_Injected_Int32_Ref_Matrix4x4.SetBelong(this.instance);
				}
				return r_RSetMatrix_Injected_Int32_Ref_Matrix4x4;
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


        public RRayTracingShader() : base("UnityEngine.Experimental.Rendering.RayTracingShader")
        {
        }

        public RRayTracingShader(System.Object instance) : base("UnityEngine.Experimental.Rendering.RayTracingShader")
		{
            SetInstance(instance);
		}

        public RRayTracingShader(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRayTracingShader(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetFloat(System.Int32  @nameID, System.Single  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RSetFloat_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInt(System.Int32  @nameID, System.Int32  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RSetInt_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVector(System.Int32  @nameID, UnityEngine.Vector4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RSetVector_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrix(System.Int32  @nameID, UnityEngine.Matrix4x4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RSetMatrix_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloatArray(System.Int32  @nameID, System.Single[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetFloatArray_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIntArray(System.Int32  @nameID, System.Int32[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetIntArray_Int32_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVectorArray(System.Int32  @nameID, UnityEngine.Vector4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetVectorArray_Int32_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrixArray(System.Int32  @nameID, UnityEngine.Matrix4x4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetMatrixArray_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.Int32  @nameID, UnityEngine.Texture  @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @texture};
            var ___result = RSetTexture_Int32_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.Int32  @nameID, UnityEngine.ComputeBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @buffer};
            var ___result = RSetBuffer_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGraphicsBuffer(System.Int32  @nameID, UnityEngine.GraphicsBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @buffer};
            var ___result = RSetGraphicsBuffer_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantComputeBuffer(System.Int32  @nameID, UnityEngine.ComputeBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @buffer, @offset, @size};
            var ___result = RSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantGraphicsBuffer(System.Int32  @nameID, UnityEngine.GraphicsBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @buffer, @offset, @size};
            var ___result = RSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAccelerationStructure(System.Int32  @nameID, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure  @accelerationStructure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @accelerationStructure};
            var ___result = RSetAccelerationStructure_Int32_RayTracingAccelerationStructure.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetShaderPass(System.String  @passName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@passName};
            var ___result = RSetShaderPass_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTextureFromGlobal(System.Int32  @nameID, System.Int32  @globalTextureNameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @globalTextureNameID};
            var ___result = RSetTextureFromGlobal_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispatch(System.String  @rayGenFunctionName, System.Int32  @width, System.Int32  @height, System.Int32  @depth, UnityEngine.Camera  @camera)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayGenFunctionName, @width, @height, @depth, @camera};
            var ___result = RDispatch_String_Int32_Int32_Int32_Camera.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.Int32  @nameID, UnityEngine.GraphicsBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @buffer};
            var ___result = RSetBuffer_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloat(System.String  @name, System.Single  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RSetFloat_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInt(System.String  @name, System.Int32  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RSetInt_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVector(System.String  @name, UnityEngine.Vector4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RSetVector_String_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrix(System.String  @name, UnityEngine.Matrix4x4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RSetMatrix_String_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVectorArray(System.String  @name, UnityEngine.Vector4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RSetVectorArray_String_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrixArray(System.String  @name, UnityEngine.Matrix4x4[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RSetMatrixArray_String_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloats(System.String  @name, System.Single[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RSetFloats_String_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloats(System.Int32  @nameID, System.Single[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetFloats_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInts(System.String  @name, System.Int32[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RSetInts_String_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInts(System.Int32  @nameID, System.Int32[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RSetInts_Int32_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBool(System.String  @name, System.Boolean  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RSetBool_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBool(System.Int32  @nameID, System.Boolean  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RSetBool_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.String  @name, UnityEngine.Texture  @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @texture};
            var ___result = RSetTexture_String_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.String  @name, UnityEngine.ComputeBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @buffer};
            var ___result = RSetBuffer_String_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.String  @name, UnityEngine.GraphicsBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @buffer};
            var ___result = RSetBuffer_String_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.Int32  @nameID, UnityEngine.ComputeBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @buffer, @offset, @size};
            var ___result = RSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.String  @name, UnityEngine.ComputeBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @buffer, @offset, @size};
            var ___result = RSetConstantBuffer_String_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.Int32  @nameID, UnityEngine.GraphicsBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @buffer, @offset, @size};
            var ___result = RSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.String  @name, UnityEngine.GraphicsBuffer  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @buffer, @offset, @size};
            var ___result = RSetConstantBuffer_String_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAccelerationStructure(System.String  @name, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure  @accelerationStructure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @accelerationStructure};
            var ___result = RSetAccelerationStructure_String_RayTracingAccelerationStructure.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTextureFromGlobal(System.String  @name, System.String  @globalTextureName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @globalTextureName};
            var ___result = RSetTextureFromGlobal_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVector_Injected(System.Int32  @nameID, ref UnityEngine.Vector4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RSetVector_Injected_Int32_Ref_Vector4.Invoke(___genericsType, ___parameters);
			val = (UnityEngine.Vector4)___parameters[1];

            
        }


        public virtual void SetMatrix_Injected(System.Int32  @nameID, ref UnityEngine.Matrix4x4  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RSetMatrix_Injected_Int32_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			val = (UnityEngine.Matrix4x4)___parameters[1];

            
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
