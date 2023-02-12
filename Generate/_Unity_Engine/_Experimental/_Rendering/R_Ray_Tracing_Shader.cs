
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
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_PmaxRecursionDepth;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RPmaxRecursionDepth
		{
			get
			{
				if(r_PmaxRecursionDepth == null)
				{
					r_PmaxRecursionDepth = new(this, "maxRecursionDepth", -1);
					r_PmaxRecursionDepth.SetBelong(this.instance);
				}
				return r_PmaxRecursionDepth;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
					r_Pname.SetBelong(this.instance);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RHideFlags r_PhideFlags;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RHideFlags RPhideFlags
		{
			get
			{
				if(r_PhideFlags == null)
				{
					r_PhideFlags = new(this, "hideFlags", -1);
					r_PhideFlags.SetBelong(this.instance);
				}
				return r_PhideFlags;
			}
		}

		/// <summary>
		/// Void SetFloat(Int32, Single)
		/// </summary>
		protected RMethod r_MSetFloat_Int32_Single;
		public virtual RMethod RMSetFloat_Int32_Single
		{
			get
			{
				if(r_MSetFloat_Int32_Single == null)
				{
					r_MSetFloat_Int32_Single = new(this, "SetFloat", 0, typeof(System.Int32), typeof(System.Single));
					r_MSetFloat_Int32_Single.SetBelong(this.instance);
				}
				return r_MSetFloat_Int32_Single;
			}
		}

		/// <summary>
		/// Void SetInt(Int32, Int32)
		/// </summary>
		protected RMethod r_MSetInt_Int32_Int32;
		public virtual RMethod RMSetInt_Int32_Int32
		{
			get
			{
				if(r_MSetInt_Int32_Int32 == null)
				{
					r_MSetInt_Int32_Int32 = new(this, "SetInt", 0, typeof(System.Int32), typeof(System.Int32));
					r_MSetInt_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetInt_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetVector(Int32, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_MSetVector_Int32_Vector4;
		public virtual RMethod RMSetVector_Int32_Vector4
		{
			get
			{
				if(r_MSetVector_Int32_Vector4 == null)
				{
					r_MSetVector_Int32_Vector4 = new(this, "SetVector", 0, typeof(System.Int32), typeof(UnityEngine.Vector4));
					r_MSetVector_Int32_Vector4.SetBelong(this.instance);
				}
				return r_MSetVector_Int32_Vector4;
			}
		}

		/// <summary>
		/// Void SetMatrix(Int32, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MSetMatrix_Int32_Matrix4x4;
		public virtual RMethod RMSetMatrix_Int32_Matrix4x4
		{
			get
			{
				if(r_MSetMatrix_Int32_Matrix4x4 == null)
				{
					r_MSetMatrix_Int32_Matrix4x4 = new(this, "SetMatrix", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4));
					r_MSetMatrix_Int32_Matrix4x4.SetBelong(this.instance);
				}
				return r_MSetMatrix_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetFloatArray(Int32, Single[])
		/// </summary>
		protected RMethod r_MSetFloatArray_Int32_SingleArray;
		public virtual RMethod RMSetFloatArray_Int32_SingleArray
		{
			get
			{
				if(r_MSetFloatArray_Int32_SingleArray == null)
				{
					r_MSetFloatArray_Int32_SingleArray = new(this, "SetFloatArray", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType());
					r_MSetFloatArray_Int32_SingleArray.SetBelong(this.instance);
				}
				return r_MSetFloatArray_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void SetIntArray(Int32, Int32[])
		/// </summary>
		protected RMethod r_MSetIntArray_Int32_Int32Array;
		public virtual RMethod RMSetIntArray_Int32_Int32Array
		{
			get
			{
				if(r_MSetIntArray_Int32_Int32Array == null)
				{
					r_MSetIntArray_Int32_Int32Array = new(this, "SetIntArray", 0, typeof(System.Int32), typeof(System.Int32).MakeArrayType());
					r_MSetIntArray_Int32_Int32Array.SetBelong(this.instance);
				}
				return r_MSetIntArray_Int32_Int32Array;
			}
		}

		/// <summary>
		/// Void SetVectorArray(Int32, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_MSetVectorArray_Int32_Vector4Array;
		public virtual RMethod RMSetVectorArray_Int32_Vector4Array
		{
			get
			{
				if(r_MSetVectorArray_Int32_Vector4Array == null)
				{
					r_MSetVectorArray_Int32_Vector4Array = new(this, "SetVectorArray", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType());
					r_MSetVectorArray_Int32_Vector4Array.SetBelong(this.instance);
				}
				return r_MSetVectorArray_Int32_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetMatrixArray(Int32, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_MSetMatrixArray_Int32_Matrix4x4Array;
		public virtual RMethod RMSetMatrixArray_Int32_Matrix4x4Array
		{
			get
			{
				if(r_MSetMatrixArray_Int32_Matrix4x4Array == null)
				{
					r_MSetMatrixArray_Int32_Matrix4x4Array = new(this, "SetMatrixArray", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_MSetMatrixArray_Int32_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_MSetMatrixArray_Int32_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void SetTexture(Int32, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_MSetTexture_Int32_Texture;
		public virtual RMethod RMSetTexture_Int32_Texture
		{
			get
			{
				if(r_MSetTexture_Int32_Texture == null)
				{
					r_MSetTexture_Int32_Texture = new(this, "SetTexture", 0, typeof(System.Int32), typeof(UnityEngine.Texture));
					r_MSetTexture_Int32_Texture.SetBelong(this.instance);
				}
				return r_MSetTexture_Int32_Texture;
			}
		}

		/// <summary>
		/// Void SetBuffer(Int32, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_MSetBuffer_Int32_ComputeBuffer;
		public virtual RMethod RMSetBuffer_Int32_ComputeBuffer
		{
			get
			{
				if(r_MSetBuffer_Int32_ComputeBuffer == null)
				{
					r_MSetBuffer_Int32_ComputeBuffer = new(this, "SetBuffer", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer));
					r_MSetBuffer_Int32_ComputeBuffer.SetBelong(this.instance);
				}
				return r_MSetBuffer_Int32_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetGraphicsBuffer(Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_MSetGraphicsBuffer_Int32_GraphicsBuffer;
		public virtual RMethod RMSetGraphicsBuffer_Int32_GraphicsBuffer
		{
			get
			{
				if(r_MSetGraphicsBuffer_Int32_GraphicsBuffer == null)
				{
					r_MSetGraphicsBuffer_Int32_GraphicsBuffer = new(this, "SetGraphicsBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_MSetGraphicsBuffer_Int32_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_MSetGraphicsBuffer_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetConstantComputeBuffer(Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32;
		public virtual RMethod RMSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_MSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32 = new(this, "SetConstantComputeBuffer", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_MSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetConstantGraphicsBuffer(Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RMSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_MSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32 = new(this, "SetConstantGraphicsBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_MSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetAccelerationStructure(Int32, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)
		/// </summary>
		protected RMethod r_MSetAccelerationStructure_Int32_RayTracingAccelerationStructure;
		public virtual RMethod RMSetAccelerationStructure_Int32_RayTracingAccelerationStructure
		{
			get
			{
				if(r_MSetAccelerationStructure_Int32_RayTracingAccelerationStructure == null)
				{
					r_MSetAccelerationStructure_Int32_RayTracingAccelerationStructure = new(this, "SetAccelerationStructure", 0, typeof(System.Int32), typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure));
					r_MSetAccelerationStructure_Int32_RayTracingAccelerationStructure.SetBelong(this.instance);
				}
				return r_MSetAccelerationStructure_Int32_RayTracingAccelerationStructure;
			}
		}

		/// <summary>
		/// Void SetShaderPass(System.String)
		/// </summary>
		protected RMethod r_MSetShaderPass_String;
		public virtual RMethod RMSetShaderPass_String
		{
			get
			{
				if(r_MSetShaderPass_String == null)
				{
					r_MSetShaderPass_String = new(this, "SetShaderPass", 0, typeof(System.String));
					r_MSetShaderPass_String.SetBelong(this.instance);
				}
				return r_MSetShaderPass_String;
			}
		}

		/// <summary>
		/// Void SetTextureFromGlobal(Int32, Int32)
		/// </summary>
		protected RMethod r_MSetTextureFromGlobal_Int32_Int32;
		public virtual RMethod RMSetTextureFromGlobal_Int32_Int32
		{
			get
			{
				if(r_MSetTextureFromGlobal_Int32_Int32 == null)
				{
					r_MSetTextureFromGlobal_Int32_Int32 = new(this, "SetTextureFromGlobal", 0, typeof(System.Int32), typeof(System.Int32));
					r_MSetTextureFromGlobal_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetTextureFromGlobal_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Dispatch(System.String, Int32, Int32, Int32, UnityEngine.Camera)
		/// </summary>
		protected RMethod r_MDispatch_String_Int32_Int32_Int32_Camera;
		public virtual RMethod RMDispatch_String_Int32_Int32_Int32_Camera
		{
			get
			{
				if(r_MDispatch_String_Int32_Int32_Int32_Camera == null)
				{
					r_MDispatch_String_Int32_Int32_Int32_Camera = new(this, "Dispatch", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Camera));
					r_MDispatch_String_Int32_Int32_Int32_Camera.SetBelong(this.instance);
				}
				return r_MDispatch_String_Int32_Int32_Int32_Camera;
			}
		}

		/// <summary>
		/// Void SetBuffer(Int32, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_MSetBuffer_Int32_GraphicsBuffer;
		public virtual RMethod RMSetBuffer_Int32_GraphicsBuffer
		{
			get
			{
				if(r_MSetBuffer_Int32_GraphicsBuffer == null)
				{
					r_MSetBuffer_Int32_GraphicsBuffer = new(this, "SetBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer));
					r_MSetBuffer_Int32_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_MSetBuffer_Int32_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetFloat(System.String, Single)
		/// </summary>
		protected RMethod r_MSetFloat_String_Single;
		public virtual RMethod RMSetFloat_String_Single
		{
			get
			{
				if(r_MSetFloat_String_Single == null)
				{
					r_MSetFloat_String_Single = new(this, "SetFloat", 0, typeof(System.String), typeof(System.Single));
					r_MSetFloat_String_Single.SetBelong(this.instance);
				}
				return r_MSetFloat_String_Single;
			}
		}

		/// <summary>
		/// Void SetInt(System.String, Int32)
		/// </summary>
		protected RMethod r_MSetInt_String_Int32;
		public virtual RMethod RMSetInt_String_Int32
		{
			get
			{
				if(r_MSetInt_String_Int32 == null)
				{
					r_MSetInt_String_Int32 = new(this, "SetInt", 0, typeof(System.String), typeof(System.Int32));
					r_MSetInt_String_Int32.SetBelong(this.instance);
				}
				return r_MSetInt_String_Int32;
			}
		}

		/// <summary>
		/// Void SetVector(System.String, UnityEngine.Vector4)
		/// </summary>
		protected RMethod r_MSetVector_String_Vector4;
		public virtual RMethod RMSetVector_String_Vector4
		{
			get
			{
				if(r_MSetVector_String_Vector4 == null)
				{
					r_MSetVector_String_Vector4 = new(this, "SetVector", 0, typeof(System.String), typeof(UnityEngine.Vector4));
					r_MSetVector_String_Vector4.SetBelong(this.instance);
				}
				return r_MSetVector_String_Vector4;
			}
		}

		/// <summary>
		/// Void SetMatrix(System.String, UnityEngine.Matrix4x4)
		/// </summary>
		protected RMethod r_MSetMatrix_String_Matrix4x4;
		public virtual RMethod RMSetMatrix_String_Matrix4x4
		{
			get
			{
				if(r_MSetMatrix_String_Matrix4x4 == null)
				{
					r_MSetMatrix_String_Matrix4x4 = new(this, "SetMatrix", 0, typeof(System.String), typeof(UnityEngine.Matrix4x4));
					r_MSetMatrix_String_Matrix4x4.SetBelong(this.instance);
				}
				return r_MSetMatrix_String_Matrix4x4;
			}
		}

		/// <summary>
		/// Void SetVectorArray(System.String, UnityEngine.Vector4[])
		/// </summary>
		protected RMethod r_MSetVectorArray_String_Vector4Array;
		public virtual RMethod RMSetVectorArray_String_Vector4Array
		{
			get
			{
				if(r_MSetVectorArray_String_Vector4Array == null)
				{
					r_MSetVectorArray_String_Vector4Array = new(this, "SetVectorArray", 0, typeof(System.String), typeof(UnityEngine.Vector4).MakeArrayType());
					r_MSetVectorArray_String_Vector4Array.SetBelong(this.instance);
				}
				return r_MSetVectorArray_String_Vector4Array;
			}
		}

		/// <summary>
		/// Void SetMatrixArray(System.String, UnityEngine.Matrix4x4[])
		/// </summary>
		protected RMethod r_MSetMatrixArray_String_Matrix4x4Array;
		public virtual RMethod RMSetMatrixArray_String_Matrix4x4Array
		{
			get
			{
				if(r_MSetMatrixArray_String_Matrix4x4Array == null)
				{
					r_MSetMatrixArray_String_Matrix4x4Array = new(this, "SetMatrixArray", 0, typeof(System.String), typeof(UnityEngine.Matrix4x4).MakeArrayType());
					r_MSetMatrixArray_String_Matrix4x4Array.SetBelong(this.instance);
				}
				return r_MSetMatrixArray_String_Matrix4x4Array;
			}
		}

		/// <summary>
		/// Void SetFloats(System.String, Single[])
		/// </summary>
		protected RMethod r_MSetFloats_String_SingleArray;
		public virtual RMethod RMSetFloats_String_SingleArray
		{
			get
			{
				if(r_MSetFloats_String_SingleArray == null)
				{
					r_MSetFloats_String_SingleArray = new(this, "SetFloats", 0, typeof(System.String), typeof(System.Single).MakeArrayType());
					r_MSetFloats_String_SingleArray.SetBelong(this.instance);
				}
				return r_MSetFloats_String_SingleArray;
			}
		}

		/// <summary>
		/// Void SetFloats(Int32, Single[])
		/// </summary>
		protected RMethod r_MSetFloats_Int32_SingleArray;
		public virtual RMethod RMSetFloats_Int32_SingleArray
		{
			get
			{
				if(r_MSetFloats_Int32_SingleArray == null)
				{
					r_MSetFloats_Int32_SingleArray = new(this, "SetFloats", 0, typeof(System.Int32), typeof(System.Single).MakeArrayType());
					r_MSetFloats_Int32_SingleArray.SetBelong(this.instance);
				}
				return r_MSetFloats_Int32_SingleArray;
			}
		}

		/// <summary>
		/// Void SetInts(System.String, Int32[])
		/// </summary>
		protected RMethod r_MSetInts_String_Int32Array;
		public virtual RMethod RMSetInts_String_Int32Array
		{
			get
			{
				if(r_MSetInts_String_Int32Array == null)
				{
					r_MSetInts_String_Int32Array = new(this, "SetInts", 0, typeof(System.String), typeof(System.Int32).MakeArrayType());
					r_MSetInts_String_Int32Array.SetBelong(this.instance);
				}
				return r_MSetInts_String_Int32Array;
			}
		}

		/// <summary>
		/// Void SetInts(Int32, Int32[])
		/// </summary>
		protected RMethod r_MSetInts_Int32_Int32Array;
		public virtual RMethod RMSetInts_Int32_Int32Array
		{
			get
			{
				if(r_MSetInts_Int32_Int32Array == null)
				{
					r_MSetInts_Int32_Int32Array = new(this, "SetInts", 0, typeof(System.Int32), typeof(System.Int32).MakeArrayType());
					r_MSetInts_Int32_Int32Array.SetBelong(this.instance);
				}
				return r_MSetInts_Int32_Int32Array;
			}
		}

		/// <summary>
		/// Void SetBool(System.String, Boolean)
		/// </summary>
		protected RMethod r_MSetBool_String_Boolean;
		public virtual RMethod RMSetBool_String_Boolean
		{
			get
			{
				if(r_MSetBool_String_Boolean == null)
				{
					r_MSetBool_String_Boolean = new(this, "SetBool", 0, typeof(System.String), typeof(System.Boolean));
					r_MSetBool_String_Boolean.SetBelong(this.instance);
				}
				return r_MSetBool_String_Boolean;
			}
		}

		/// <summary>
		/// Void SetBool(Int32, Boolean)
		/// </summary>
		protected RMethod r_MSetBool_Int32_Boolean;
		public virtual RMethod RMSetBool_Int32_Boolean
		{
			get
			{
				if(r_MSetBool_Int32_Boolean == null)
				{
					r_MSetBool_Int32_Boolean = new(this, "SetBool", 0, typeof(System.Int32), typeof(System.Boolean));
					r_MSetBool_Int32_Boolean.SetBelong(this.instance);
				}
				return r_MSetBool_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetTexture(System.String, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_MSetTexture_String_Texture;
		public virtual RMethod RMSetTexture_String_Texture
		{
			get
			{
				if(r_MSetTexture_String_Texture == null)
				{
					r_MSetTexture_String_Texture = new(this, "SetTexture", 0, typeof(System.String), typeof(UnityEngine.Texture));
					r_MSetTexture_String_Texture.SetBelong(this.instance);
				}
				return r_MSetTexture_String_Texture;
			}
		}

		/// <summary>
		/// Void SetBuffer(System.String, UnityEngine.ComputeBuffer)
		/// </summary>
		protected RMethod r_MSetBuffer_String_ComputeBuffer;
		public virtual RMethod RMSetBuffer_String_ComputeBuffer
		{
			get
			{
				if(r_MSetBuffer_String_ComputeBuffer == null)
				{
					r_MSetBuffer_String_ComputeBuffer = new(this, "SetBuffer", 0, typeof(System.String), typeof(UnityEngine.ComputeBuffer));
					r_MSetBuffer_String_ComputeBuffer.SetBelong(this.instance);
				}
				return r_MSetBuffer_String_ComputeBuffer;
			}
		}

		/// <summary>
		/// Void SetBuffer(System.String, UnityEngine.GraphicsBuffer)
		/// </summary>
		protected RMethod r_MSetBuffer_String_GraphicsBuffer;
		public virtual RMethod RMSetBuffer_String_GraphicsBuffer
		{
			get
			{
				if(r_MSetBuffer_String_GraphicsBuffer == null)
				{
					r_MSetBuffer_String_GraphicsBuffer = new(this, "SetBuffer", 0, typeof(System.String), typeof(UnityEngine.GraphicsBuffer));
					r_MSetBuffer_String_GraphicsBuffer.SetBelong(this.instance);
				}
				return r_MSetBuffer_String_GraphicsBuffer;
			}
		}

		/// <summary>
		/// Void SetConstantBuffer(Int32, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32;
		public virtual RMethod RMSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32 == null)
				{
					r_MSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32 = new(this, "SetConstantBuffer", 0, typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_MSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetConstantBuffer(System.String, UnityEngine.ComputeBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetConstantBuffer_String_ComputeBuffer_Int32_Int32;
		public virtual RMethod RMSetConstantBuffer_String_ComputeBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetConstantBuffer_String_ComputeBuffer_Int32_Int32 == null)
				{
					r_MSetConstantBuffer_String_ComputeBuffer_Int32_Int32 = new(this, "SetConstantBuffer", 0, typeof(System.String), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32));
					r_MSetConstantBuffer_String_ComputeBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetConstantBuffer_String_ComputeBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetConstantBuffer(Int32, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RMSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32 == null)
				{
					r_MSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32 = new(this, "SetConstantBuffer", 0, typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_MSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetConstantBuffer(System.String, UnityEngine.GraphicsBuffer, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetConstantBuffer_String_GraphicsBuffer_Int32_Int32;
		public virtual RMethod RMSetConstantBuffer_String_GraphicsBuffer_Int32_Int32
		{
			get
			{
				if(r_MSetConstantBuffer_String_GraphicsBuffer_Int32_Int32 == null)
				{
					r_MSetConstantBuffer_String_GraphicsBuffer_Int32_Int32 = new(this, "SetConstantBuffer", 0, typeof(System.String), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32));
					r_MSetConstantBuffer_String_GraphicsBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetConstantBuffer_String_GraphicsBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetAccelerationStructure(System.String, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure)
		/// </summary>
		protected RMethod r_MSetAccelerationStructure_String_RayTracingAccelerationStructure;
		public virtual RMethod RMSetAccelerationStructure_String_RayTracingAccelerationStructure
		{
			get
			{
				if(r_MSetAccelerationStructure_String_RayTracingAccelerationStructure == null)
				{
					r_MSetAccelerationStructure_String_RayTracingAccelerationStructure = new(this, "SetAccelerationStructure", 0, typeof(System.String), typeof(UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure));
					r_MSetAccelerationStructure_String_RayTracingAccelerationStructure.SetBelong(this.instance);
				}
				return r_MSetAccelerationStructure_String_RayTracingAccelerationStructure;
			}
		}

		/// <summary>
		/// Void SetTextureFromGlobal(System.String, System.String)
		/// </summary>
		protected RMethod r_MSetTextureFromGlobal_String_String;
		public virtual RMethod RMSetTextureFromGlobal_String_String
		{
			get
			{
				if(r_MSetTextureFromGlobal_String_String == null)
				{
					r_MSetTextureFromGlobal_String_String = new(this, "SetTextureFromGlobal", 0, typeof(System.String), typeof(System.String));
					r_MSetTextureFromGlobal_String_String.SetBelong(this.instance);
				}
				return r_MSetTextureFromGlobal_String_String;
			}
		}

		/// <summary>
		/// Void SetVector_Injected(Int32, UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_MSetVector_Injected_Int32_Ref_Vector4;
		public virtual RMethod RMSetVector_Injected_Int32_Ref_Vector4
		{
			get
			{
				if(r_MSetVector_Injected_Int32_Ref_Vector4 == null)
				{
					r_MSetVector_Injected_Int32_Ref_Vector4 = new(this, "SetVector_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeByRefType());
					r_MSetVector_Injected_Int32_Ref_Vector4.SetBelong(this.instance);
				}
				return r_MSetVector_Injected_Int32_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void SetMatrix_Injected(Int32, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_MSetMatrix_Injected_Int32_Ref_Matrix4x4;
		public virtual RMethod RMSetMatrix_Injected_Int32_Ref_Matrix4x4
		{
			get
			{
				if(r_MSetMatrix_Injected_Int32_Ref_Matrix4x4 == null)
				{
					r_MSetMatrix_Injected_Int32_Ref_Matrix4x4 = new(this, "SetMatrix_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_MSetMatrix_Injected_Int32_Ref_Matrix4x4.SetBelong(this.instance);
				}
				return r_MSetMatrix_Injected_Int32_Ref_Matrix4x4;
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
					r_MGetInstanceID.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MEquals_Object.SetBelong(this.instance);
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

        public virtual void SetFloat(System.Int32 @nameID, System.Single @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RMSetFloat_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInt(System.Int32 @nameID, System.Int32 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RMSetInt_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVector(System.Int32 @nameID, UnityEngine.Vector4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RMSetVector_Int32_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrix(System.Int32 @nameID, UnityEngine.Matrix4x4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RMSetMatrix_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloatArray(System.Int32 @nameID, System.Single[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetFloatArray_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetIntArray(System.Int32 @nameID, System.Int32[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetIntArray_Int32_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVectorArray(System.Int32 @nameID, UnityEngine.Vector4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetVectorArray_Int32_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrixArray(System.Int32 @nameID, UnityEngine.Matrix4x4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetMatrixArray_Int32_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.Int32 @nameID, UnityEngine.Texture @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @texture};
            var ___result = RMSetTexture_Int32_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.Int32 @nameID, UnityEngine.ComputeBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @buffer};
            var ___result = RMSetBuffer_Int32_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGraphicsBuffer(System.Int32 @nameID, UnityEngine.GraphicsBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @buffer};
            var ___result = RMSetGraphicsBuffer_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantComputeBuffer(System.Int32 @nameID, UnityEngine.ComputeBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @buffer, @offset, @size};
            var ___result = RMSetConstantComputeBuffer_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantGraphicsBuffer(System.Int32 @nameID, UnityEngine.GraphicsBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @buffer, @offset, @size};
            var ___result = RMSetConstantGraphicsBuffer_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAccelerationStructure(System.Int32 @nameID, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure @accelerationStructure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @accelerationStructure};
            var ___result = RMSetAccelerationStructure_Int32_RayTracingAccelerationStructure.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetShaderPass(System.String @passName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@passName};
            var ___result = RMSetShaderPass_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTextureFromGlobal(System.Int32 @nameID, System.Int32 @globalTextureNameID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @globalTextureNameID};
            var ___result = RMSetTextureFromGlobal_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispatch(System.String @rayGenFunctionName, System.Int32 @width, System.Int32 @height, System.Int32 @depth, UnityEngine.Camera @camera)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rayGenFunctionName, @width, @height, @depth, @camera};
            var ___result = RMDispatch_String_Int32_Int32_Int32_Camera.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.Int32 @nameID, UnityEngine.GraphicsBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @buffer};
            var ___result = RMSetBuffer_Int32_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloat(System.String @name, System.Single @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RMSetFloat_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInt(System.String @name, System.Int32 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RMSetInt_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVector(System.String @name, UnityEngine.Vector4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RMSetVector_String_Vector4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrix(System.String @name, UnityEngine.Matrix4x4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RMSetMatrix_String_Matrix4x4.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVectorArray(System.String @name, UnityEngine.Vector4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMSetVectorArray_String_Vector4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMatrixArray(System.String @name, UnityEngine.Matrix4x4[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMSetMatrixArray_String_Matrix4x4Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloats(System.String @name, System.Single[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMSetFloats_String_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFloats(System.Int32 @nameID, System.Single[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetFloats_Int32_SingleArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInts(System.String @name, System.Int32[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @values};
            var ___result = RMSetInts_String_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInts(System.Int32 @nameID, System.Int32[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @values};
            var ___result = RMSetInts_Int32_Int32Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBool(System.String @name, System.Boolean @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @val};
            var ___result = RMSetBool_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBool(System.Int32 @nameID, System.Boolean @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RMSetBool_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTexture(System.String @name, UnityEngine.Texture @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @texture};
            var ___result = RMSetTexture_String_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.String @name, UnityEngine.ComputeBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @buffer};
            var ___result = RMSetBuffer_String_ComputeBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.String @name, UnityEngine.GraphicsBuffer @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @buffer};
            var ___result = RMSetBuffer_String_GraphicsBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.Int32 @nameID, UnityEngine.ComputeBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @buffer, @offset, @size};
            var ___result = RMSetConstantBuffer_Int32_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.String @name, UnityEngine.ComputeBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @buffer, @offset, @size};
            var ___result = RMSetConstantBuffer_String_ComputeBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.Int32 @nameID, UnityEngine.GraphicsBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @buffer, @offset, @size};
            var ___result = RMSetConstantBuffer_Int32_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConstantBuffer(System.String @name, UnityEngine.GraphicsBuffer @buffer, System.Int32 @offset, System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @buffer, @offset, @size};
            var ___result = RMSetConstantBuffer_String_GraphicsBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAccelerationStructure(System.String @name, UnityEngine.Experimental.Rendering.RayTracingAccelerationStructure @accelerationStructure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @accelerationStructure};
            var ___result = RMSetAccelerationStructure_String_RayTracingAccelerationStructure.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTextureFromGlobal(System.String @name, System.String @globalTextureName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @globalTextureName};
            var ___result = RMSetTextureFromGlobal_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVector_Injected(System.Int32 @nameID, ref UnityEngine.Vector4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RMSetVector_Injected_Int32_Ref_Vector4.Invoke(___genericsType, ___parameters);
			@val = (UnityEngine.Vector4)___parameters[1];

            
        }


        public virtual void SetMatrix_Injected(System.Int32 @nameID, ref UnityEngine.Matrix4x4 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameID, @val};
            var ___result = RMSetMatrix_Injected_Int32_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			@val = (UnityEngine.Matrix4x4)___parameters[1];

            
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
