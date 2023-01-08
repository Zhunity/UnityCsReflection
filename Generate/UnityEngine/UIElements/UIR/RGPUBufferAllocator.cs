using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.GPUBufferAllocator
	/// </summary>
    public partial class RGPUBufferAllocator : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator m_Low
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBestFitAllocator r_m_Low;
		public virtual RUnityEngine.RUIElements.RUIR.RBestFitAllocator Rm_Low
		{
			get
			{
				if(r_m_Low == null)
				{
					r_m_Low = new(this, "m_Low");
					r_m_Low.SetBelong(this.instance);
				}
				return r_m_Low;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator m_High
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBestFitAllocator r_m_High;
		public virtual RUnityEngine.RUIElements.RUIR.RBestFitAllocator Rm_High
		{
			get
			{
				if(r_m_High == null)
				{
					r_m_High = new(this, "m_High");
					r_m_High.SetBelong(this.instance);
				}
				return r_m_High;
			}
		}

		/// <summary>
		/// Boolean isEmpty
		/// </summary>
		protected RProperty r_isEmpty;
		public virtual RProperty RisEmpty
		{
			get
			{
				if(r_isEmpty == null)
				{
					r_isEmpty = new(this, "isEmpty", -1);
					r_isEmpty.SetBelong(this.instance);
				}
				return r_isEmpty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Alloc Allocate(UInt32, Boolean)
		/// </summary>
		protected RMethod r_Allocate_UInt32_Boolean;
		public virtual RMethod RAllocate_UInt32_Boolean
		{
			get
			{
				if(r_Allocate_UInt32_Boolean == null)
				{
					r_Allocate_UInt32_Boolean = new(this, "Allocate", 0, typeof(System.UInt32), typeof(System.Boolean));
					r_Allocate_UInt32_Boolean.SetBelong(this.instance);
				}
				return r_Allocate_UInt32_Boolean;
			}
		}

		/// <summary>
		/// Void Free(UnityEngine.UIElements.UIR.Alloc)
		/// </summary>
		protected RMethod r_Free_Alloc;
		public virtual RMethod RFree_Alloc
		{
			get
			{
				if(r_Free_Alloc == null)
				{
					r_Free_Alloc = new(this, "Free", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.Alloc"));
					r_Free_Alloc.SetBelong(this.instance);
				}
				return r_Free_Alloc;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.HeapStatistics GatherStatistics()
		/// </summary>
		protected RMethod r_GatherStatistics;
		public virtual RMethod RGatherStatistics
		{
			get
			{
				if(r_GatherStatistics == null)
				{
					r_GatherStatistics = new(this, "GatherStatistics", 0);
					r_GatherStatistics.SetBelong(this.instance);
				}
				return r_GatherStatistics;
			}
		}

		/// <summary>
		/// Boolean HighLowCollide()
		/// </summary>
		protected RMethod r_HighLowCollide;
		public virtual RMethod RHighLowCollide
		{
			get
			{
				if(r_HighLowCollide == null)
				{
					r_HighLowCollide = new(this, "HighLowCollide", 0);
					r_HighLowCollide.SetBelong(this.instance);
				}
				return r_HighLowCollide;
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


        public RGPUBufferAllocator() : base("UnityEngine.UIElements.UIR.GPUBufferAllocator")
        {
        }

        public RGPUBufferAllocator(System.Object instance) : base("UnityEngine.UIElements.UIR.GPUBufferAllocator")
		{
            SetInstance(instance);
		}

        public RGPUBufferAllocator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGPUBufferAllocator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object Allocate(System.UInt32  @size, System.Boolean  @shortLived)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size, @shortLived};
            var ___result = RAllocate_UInt32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Free(RUnityEngine.RUIElements.RUIR.RAlloc  @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RFree_Alloc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GatherStatistics()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGatherStatistics.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean HighLowCollide()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHighLowCollide.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
