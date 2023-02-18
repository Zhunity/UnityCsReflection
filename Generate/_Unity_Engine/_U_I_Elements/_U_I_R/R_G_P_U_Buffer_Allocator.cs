
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.GPUBufferAllocator
	/// </summary>
    public partial class RGPUBufferAllocator : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator m_Low
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator r_Fm_Low;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator RFm_Low
		{
			get
			{
				if(r_Fm_Low == null)
				{
					r_Fm_Low = new(this, "m_Low");
					r_Fm_Low.SetBelong(this.GetValue());
				}
				return r_Fm_Low;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator m_High
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator r_Fm_High;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator RFm_High
		{
			get
			{
				if(r_Fm_High == null)
				{
					r_Fm_High = new(this, "m_High");
					r_Fm_High.SetBelong(this.GetValue());
				}
				return r_Fm_High;
			}
		}

		/// <summary>
		/// Boolean isEmpty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisEmpty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisEmpty
		{
			get
			{
				if(r_PisEmpty == null)
				{
					r_PisEmpty = new(this, "isEmpty", -1);
					r_PisEmpty.SetBelong(this.GetValue());
				}
				return r_PisEmpty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Alloc Allocate(UInt32, Boolean)
		/// </summary>
		protected RMethod r_MAllocate_UInt32_Boolean;
		public virtual RMethod RMAllocate_UInt32_Boolean
		{
			get
			{
				if(r_MAllocate_UInt32_Boolean == null)
				{
					r_MAllocate_UInt32_Boolean = new(this, "Allocate", 0, typeof(System.UInt32), typeof(System.Boolean));
					r_MAllocate_UInt32_Boolean.SetBelong(this.GetValue());
				}
				return r_MAllocate_UInt32_Boolean;
			}
		}

		/// <summary>
		/// Void Free(UnityEngine.UIElements.UIR.Alloc)
		/// </summary>
		protected RMethod r_MFree_Alloc;
		public virtual RMethod RMFree_Alloc
		{
			get
			{
				if(r_MFree_Alloc == null)
				{
					r_MFree_Alloc = new(this, "Free", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.Alloc"));
					r_MFree_Alloc.SetBelong(this.GetValue());
				}
				return r_MFree_Alloc;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.HeapStatistics GatherStatistics()
		/// </summary>
		protected RMethod r_MGatherStatistics;
		public virtual RMethod RMGatherStatistics
		{
			get
			{
				if(r_MGatherStatistics == null)
				{
					r_MGatherStatistics = new(this, "GatherStatistics", 0);
					r_MGatherStatistics.SetBelong(this.GetValue());
				}
				return r_MGatherStatistics;
			}
		}

		/// <summary>
		/// Boolean HighLowCollide()
		/// </summary>
		protected RMethod r_MHighLowCollide;
		public virtual RMethod RMHighLowCollide
		{
			get
			{
				if(r_MHighLowCollide == null)
				{
					r_MHighLowCollide = new(this, "HighLowCollide", 0);
					r_MHighLowCollide.SetBelong(this.GetValue());
				}
				return r_MHighLowCollide;
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

        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RAlloc Allocate(System.UInt32 @size, System.Boolean @shortLived)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size, @shortLived};
            var ___result = RMAllocate_UInt32_Boolean.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RAlloc(___result);
        }


        public virtual void Free(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RMFree_Alloc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RHeapStatistics GatherStatistics()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGatherStatistics.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RHeapStatistics(___result);
        }


        public virtual System.Boolean HighLowCollide()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHighLowCollide.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
