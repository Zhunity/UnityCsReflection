
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
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
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fbuffer;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFbuffer
		{
			get
			{
				if(r_Fbuffer == null)
				{
					r_Fbuffer = new(this, "buffer");
				}
				return r_Fbuffer;
			}
		}

		/// <summary>
		/// System.Int32 elemCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FelemCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFelemCount
		{
			get
			{
				if(r_FelemCount == null)
				{
					r_FelemCount = new(this, "elemCount");
				}
				return r_FelemCount;
			}
		}

		/// <summary>
		/// System.Int32 elemStride
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FelemStride;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFelemStride
		{
			get
			{
				if(r_FelemStride == null)
				{
					r_FelemStride = new(this, "elemStride");
				}
				return r_FelemStride;
			}
		}

		/// <summary>
		/// Int32 ElementStride
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PElementStride;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPElementStride
		{
			get
			{
				if(r_PElementStride == null)
				{
					r_PElementStride = new(this, "ElementStride", -1);
				}
				return r_PElementStride;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPCount
		{
			get
			{
				if(r_PCount == null)
				{
					r_PCount = new(this, "Count", -1);
				}
				return r_PCount;
			}
		}

		/// <summary>
		/// IntPtr BufferPointer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_PBufferPointer;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RPBufferPointer
		{
			get
			{
				if(r_PBufferPointer == null)
				{
					r_PBufferPointer = new(this, "BufferPointer", -1);
				}
				return r_PBufferPointer;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void UpdateRanges(Unity.Collections.NativeSlice`1[UnityEngine.UIElements.UIR.GfxUpdateBufferRange], Int32, Int32)
		/// </summary>
		protected RMethod r_MUpdateRanges_NativeSlice_d_GfxUpdateBufferRange_p__Int32_Int32;
		public virtual RMethod RMUpdateRanges_NativeSlice_d_GfxUpdateBufferRange_p__Int32_Int32
		{
			get
			{
				if(r_MUpdateRanges_NativeSlice_d_GfxUpdateBufferRange_p__Int32_Int32 == null)
				{
					r_MUpdateRanges_NativeSlice_d_GfxUpdateBufferRange_p__Int32_Int32 = new(this, "UpdateRanges", 0, typeof(Unity.Collections.NativeSlice<>).MakeGenericType( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.GfxUpdateBufferRange")), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MUpdateRanges_NativeSlice_d_GfxUpdateBufferRange_p__Int32_Int32;
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
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateRanges(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RGfxUpdateBufferRange> @ranges, System.Int32 @rangesMin, System.Int32 @rangesMax)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ranges.Value, @rangesMin, @rangesMax};
            var ___result = RMUpdateRanges_NativeSlice_d_GfxUpdateBufferRange_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
}