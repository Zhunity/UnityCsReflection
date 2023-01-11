using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.BestFitAllocator
	/// </summary>
    public partial class RBestFitAllocator : RMember //
    {

		/// <summary>
		/// System.UInt32 <totalSize>k__BackingField
		/// </summary>
		protected RSystem.RUInt32 r___0__totalSize__1__k__BackingField;
		public virtual RSystem.RUInt32 R__0__totalSize__1__k__BackingField
		{
			get
			{
				if(r___0__totalSize__1__k__BackingField == null)
				{
					r___0__totalSize__1__k__BackingField = new(this, "<totalSize>k__BackingField");
					r___0__totalSize__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__totalSize__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator+Block m_FirstBlock
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock r_m_FirstBlock;
		public virtual RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock Rm_FirstBlock
		{
			get
			{
				if(r_m_FirstBlock == null)
				{
					r_m_FirstBlock = new(this, "m_FirstBlock");
					r_m_FirstBlock.SetBelong(this.instance);
				}
				return r_m_FirstBlock;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator+Block m_FirstAvailableBlock
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock r_m_FirstAvailableBlock;
		public virtual RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock Rm_FirstAvailableBlock
		{
			get
			{
				if(r_m_FirstAvailableBlock == null)
				{
					r_m_FirstAvailableBlock = new(this, "m_FirstAvailableBlock");
					r_m_FirstAvailableBlock.SetBelong(this.instance);
				}
				return r_m_FirstAvailableBlock;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator+BlockPool m_BlockPool
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlockPool r_m_BlockPool;
		public virtual RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlockPool Rm_BlockPool
		{
			get
			{
				if(r_m_BlockPool == null)
				{
					r_m_BlockPool = new(this, "m_BlockPool");
					r_m_BlockPool.SetBelong(this.instance);
				}
				return r_m_BlockPool;
			}
		}

		/// <summary>
		/// System.UInt32 m_HighWatermark
		/// </summary>
		protected RSystem.RUInt32 r_m_HighWatermark;
		public virtual RSystem.RUInt32 Rm_HighWatermark
		{
			get
			{
				if(r_m_HighWatermark == null)
				{
					r_m_HighWatermark = new(this, "m_HighWatermark");
					r_m_HighWatermark.SetBelong(this.instance);
				}
				return r_m_HighWatermark;
			}
		}

		/// <summary>
		/// UInt32 totalSize
		/// </summary>
		protected RSystem.RUInt32 r_totalSize;
		public virtual RSystem.RUInt32 RtotalSize
		{
			get
			{
				if(r_totalSize == null)
				{
					r_totalSize = new(this, "totalSize", -1);
					r_totalSize.SetBelong(this.instance);
				}
				return r_totalSize;
			}
		}

		/// <summary>
		/// UInt32 highWatermark
		/// </summary>
		protected RSystem.RUInt32 r_highWatermark;
		public virtual RSystem.RUInt32 RhighWatermark
		{
			get
			{
				if(r_highWatermark == null)
				{
					r_highWatermark = new(this, "highWatermark", -1);
					r_highWatermark.SetBelong(this.instance);
				}
				return r_highWatermark;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Alloc Allocate(UInt32)
		/// </summary>
		protected RMethod r_Allocate_UInt32;
		public virtual RMethod RAllocate_UInt32
		{
			get
			{
				if(r_Allocate_UInt32 == null)
				{
					r_Allocate_UInt32 = new(this, "Allocate", 0, typeof(System.UInt32));
					r_Allocate_UInt32.SetBelong(this.instance);
				}
				return r_Allocate_UInt32;
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
		/// Block CoalesceBlockWithPrevious(Block)
		/// </summary>
		protected RMethod r_CoalesceBlockWithPrevious_Block;
		public virtual RMethod RCoalesceBlockWithPrevious_Block
		{
			get
			{
				if(r_CoalesceBlockWithPrevious_Block == null)
				{
					r_CoalesceBlockWithPrevious_Block = new(this, "CoalesceBlockWithPrevious", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BestFitAllocator+Block"));
					r_CoalesceBlockWithPrevious_Block.SetBelong(this.instance);
				}
				return r_CoalesceBlockWithPrevious_Block;
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
		/// Block BestFitFindAvailableBlock(UInt32)
		/// </summary>
		protected RMethod r_BestFitFindAvailableBlock_UInt32;
		public virtual RMethod RBestFitFindAvailableBlock_UInt32
		{
			get
			{
				if(r_BestFitFindAvailableBlock_UInt32 == null)
				{
					r_BestFitFindAvailableBlock_UInt32 = new(this, "BestFitFindAvailableBlock", 0, typeof(System.UInt32));
					r_BestFitFindAvailableBlock_UInt32.SetBelong(this.instance);
				}
				return r_BestFitFindAvailableBlock_UInt32;
			}
		}

		/// <summary>
		/// Void SplitBlock(Block, UInt32)
		/// </summary>
		protected RMethod r_SplitBlock_Block_UInt32;
		public virtual RMethod RSplitBlock_Block_UInt32
		{
			get
			{
				if(r_SplitBlock_Block_UInt32 == null)
				{
					r_SplitBlock_Block_UInt32 = new(this, "SplitBlock", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BestFitAllocator+Block"), typeof(System.UInt32));
					r_SplitBlock_Block_UInt32.SetBelong(this.instance);
				}
				return r_SplitBlock_Block_UInt32;
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


        public RBestFitAllocator() : base("UnityEngine.UIElements.UIR.BestFitAllocator")
        {
        }

        public RBestFitAllocator(System.Object instance) : base("UnityEngine.UIElements.UIR.BestFitAllocator")
		{
            SetInstance(instance);
		}

        public RBestFitAllocator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBestFitAllocator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual RUnityEngine.RUIElements.RUIR.RAlloc Allocate(System.UInt32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size};
            var ___result = RAllocate_UInt32.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RUIR.RAlloc(___result);
        }


        public virtual void Free(RUnityEngine.RUIElements.RUIR.RAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RFree_Alloc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock CoalesceBlockWithPrevious(RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock @block)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@block.Value};
            var ___result = RCoalesceBlockWithPrevious_Block.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock(___result);
        }


        public virtual RUnityEngine.RUIElements.RUIR.RHeapStatistics GatherStatistics()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGatherStatistics.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RUIR.RHeapStatistics(___result);
        }


        public virtual RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock BestFitFindAvailableBlock(System.UInt32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size};
            var ___result = RBestFitFindAvailableBlock_UInt32.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock(___result);
        }


        public virtual void SplitBlock(RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock @block, System.UInt32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@block.Value, @size};
            var ___result = RSplitBlock_Block_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
