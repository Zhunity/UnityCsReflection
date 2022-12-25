using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{public partial class RUtility
{
	
	/// <summary>
	/// UnityEngine.UIElements.UIR.Utility+GPUBuffer`1
	/// </summary>
    public partial class RGPUBuffer<T> : RMember // where T : struct
    {

		/// <summary>
		/// System.IntPtr buffer
		/// </summary>
		protected RField r_buffer;
		public virtual RField Rbuffer
		{
			get
			{
				if(r_buffer == null)
				{
					r_buffer = new(this, "buffer");
					r_buffer.SetBelong(this.instance);
				}
				return r_buffer;
			}
		}

		/// <summary>
		/// System.Int32 elemCount
		/// </summary>
		protected RField r_elemCount;
		public virtual RField RelemCount
		{
			get
			{
				if(r_elemCount == null)
				{
					r_elemCount = new(this, "elemCount");
					r_elemCount.SetBelong(this.instance);
				}
				return r_elemCount;
			}
		}

		/// <summary>
		/// System.Int32 elemStride
		/// </summary>
		protected RField r_elemStride;
		public virtual RField RelemStride
		{
			get
			{
				if(r_elemStride == null)
				{
					r_elemStride = new(this, "elemStride");
					r_elemStride.SetBelong(this.instance);
				}
				return r_elemStride;
			}
		}

		/// <summary>
		/// Int32 ElementStride
		/// </summary>
		protected RProperty r_ElementStride;
		public virtual RProperty RElementStride
		{
			get
			{
				if(r_ElementStride == null)
				{
					r_ElementStride = new(this, "ElementStride", -1);
					r_ElementStride.SetBelong(this.instance);
				}
				return r_ElementStride;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected RProperty r_Count;
		public virtual RProperty RCount
		{
			get
			{
				if(r_Count == null)
				{
					r_Count = new(this, "Count", -1);
					r_Count.SetBelong(this.instance);
				}
				return r_Count;
			}
		}

		/// <summary>
		/// IntPtr BufferPointer
		/// </summary>
		protected RProperty r_BufferPointer;
		public virtual RProperty RBufferPointer
		{
			get
			{
				if(r_BufferPointer == null)
				{
					r_BufferPointer = new(this, "BufferPointer", -1);
					r_BufferPointer.SetBelong(this.instance);
				}
				return r_BufferPointer;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void UpdateRanges(Unity.Collections.NativeSlice`1[UnityEngine.UIElements.UIR.GfxUpdateBufferRange], Int32, Int32)
		/// </summary>
		protected RMethod r_RUpdateRanges_NativeSlice_d_GfxUpdateBufferRange_p__Int32_Int32;
		public virtual RMethod RUpdateRanges_NativeSlice_d_GfxUpdateBufferRange_p__Int32_Int32
		{
			get
			{
				if(r_RUpdateRanges_NativeSlice_d_GfxUpdateBufferRange_p__Int32_Int32 == null)
				{
					r_RUpdateRanges_NativeSlice_d_GfxUpdateBufferRange_p__Int32_Int32 = new(this, "UpdateRanges", 0, typeof(Unity.Collections.NativeSlice<>).MakeGenericType( ReleactionUtils.GetType("UnityEngine.UIElements.UIR.GfxUpdateBufferRange")), typeof(System.Int32), typeof(System.Int32));
					r_RUpdateRanges_NativeSlice_d_GfxUpdateBufferRange_p__Int32_Int32.SetBelong(this.instance);
				}
				return r_RUpdateRanges_NativeSlice_d_GfxUpdateBufferRange_p__Int32_Int32;
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


        public RGPUBuffer() : base("UnityEngine.UIElements.UIR.Utility+GPUBuffer`1")
        {
        }

        public RGPUBuffer(System.Object instance) : base("UnityEngine.UIElements.UIR.Utility+GPUBuffer`1")
		{
            SetInstance(instance);
		}

        public RGPUBuffer(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGPUBuffer(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
}