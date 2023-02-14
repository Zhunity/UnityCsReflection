
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.BestFitAllocator
	/// </summary>
    public partial class RBestFitAllocator : RMember //
    {

		/// <summary>
		/// System.UInt32 <totalSize>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_F__0__totalSize__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RF__0__totalSize__1__k__BackingField
		{
			get
			{
				if(r_F__0__totalSize__1__k__BackingField == null)
				{
					r_F__0__totalSize__1__k__BackingField = new(this, "<totalSize>k__BackingField");
					r_F__0__totalSize__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__totalSize__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator+Block m_FirstBlock
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock r_Fm_FirstBlock;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock RFm_FirstBlock
		{
			get
			{
				if(r_Fm_FirstBlock == null)
				{
					r_Fm_FirstBlock = new(this, "m_FirstBlock");
					r_Fm_FirstBlock.SetBelong(this.instance);
				}
				return r_Fm_FirstBlock;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator+Block m_FirstAvailableBlock
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock r_Fm_FirstAvailableBlock;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock RFm_FirstAvailableBlock
		{
			get
			{
				if(r_Fm_FirstAvailableBlock == null)
				{
					r_Fm_FirstAvailableBlock = new(this, "m_FirstAvailableBlock");
					r_Fm_FirstAvailableBlock.SetBelong(this.instance);
				}
				return r_Fm_FirstAvailableBlock;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator+BlockPool m_BlockPool
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlockPool r_Fm_BlockPool;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlockPool RFm_BlockPool
		{
			get
			{
				if(r_Fm_BlockPool == null)
				{
					r_Fm_BlockPool = new(this, "m_BlockPool");
					r_Fm_BlockPool.SetBelong(this.instance);
				}
				return r_Fm_BlockPool;
			}
		}

		/// <summary>
		/// System.UInt32 m_HighWatermark
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fm_HighWatermark;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFm_HighWatermark
		{
			get
			{
				if(r_Fm_HighWatermark == null)
				{
					r_Fm_HighWatermark = new(this, "m_HighWatermark");
					r_Fm_HighWatermark.SetBelong(this.instance);
				}
				return r_Fm_HighWatermark;
			}
		}

		/// <summary>
		/// UInt32 totalSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_PtotalSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPtotalSize
		{
			get
			{
				if(r_PtotalSize == null)
				{
					r_PtotalSize = new(this, "totalSize", -1);
					r_PtotalSize.SetBelong(this.instance);
				}
				return r_PtotalSize;
			}
		}

		/// <summary>
		/// UInt32 highWatermark
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_PhighWatermark;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPhighWatermark
		{
			get
			{
				if(r_PhighWatermark == null)
				{
					r_PhighWatermark = new(this, "highWatermark", -1);
					r_PhighWatermark.SetBelong(this.instance);
				}
				return r_PhighWatermark;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Alloc Allocate(UInt32)
		/// </summary>
		protected RMethod r_MAllocate_UInt32;
		public virtual RMethod RMAllocate_UInt32
		{
			get
			{
				if(r_MAllocate_UInt32 == null)
				{
					r_MAllocate_UInt32 = new(this, "Allocate", 0, typeof(System.UInt32));
					r_MAllocate_UInt32.SetBelong(this.instance);
				}
				return r_MAllocate_UInt32;
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
					r_MFree_Alloc.SetBelong(this.instance);
				}
				return r_MFree_Alloc;
			}
		}

		/// <summary>
		/// Block CoalesceBlockWithPrevious(Block)
		/// </summary>
		protected RMethod r_MCoalesceBlockWithPrevious_Block;
		public virtual RMethod RMCoalesceBlockWithPrevious_Block
		{
			get
			{
				if(r_MCoalesceBlockWithPrevious_Block == null)
				{
					r_MCoalesceBlockWithPrevious_Block = new(this, "CoalesceBlockWithPrevious", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BestFitAllocator+Block"));
					r_MCoalesceBlockWithPrevious_Block.SetBelong(this.instance);
				}
				return r_MCoalesceBlockWithPrevious_Block;
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
					r_MGatherStatistics.SetBelong(this.instance);
				}
				return r_MGatherStatistics;
			}
		}

		/// <summary>
		/// Block BestFitFindAvailableBlock(UInt32)
		/// </summary>
		protected RMethod r_MBestFitFindAvailableBlock_UInt32;
		public virtual RMethod RMBestFitFindAvailableBlock_UInt32
		{
			get
			{
				if(r_MBestFitFindAvailableBlock_UInt32 == null)
				{
					r_MBestFitFindAvailableBlock_UInt32 = new(this, "BestFitFindAvailableBlock", 0, typeof(System.UInt32));
					r_MBestFitFindAvailableBlock_UInt32.SetBelong(this.instance);
				}
				return r_MBestFitFindAvailableBlock_UInt32;
			}
		}

		/// <summary>
		/// Void SplitBlock(Block, UInt32)
		/// </summary>
		protected RMethod r_MSplitBlock_Block_UInt32;
		public virtual RMethod RMSplitBlock_Block_UInt32
		{
			get
			{
				if(r_MSplitBlock_Block_UInt32 == null)
				{
					r_MSplitBlock_Block_UInt32 = new(this, "SplitBlock", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BestFitAllocator+Block"), typeof(System.UInt32));
					r_MSplitBlock_Block_UInt32.SetBelong(this.instance);
				}
				return r_MSplitBlock_Block_UInt32;
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

        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RAlloc Allocate(System.UInt32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size};
            var ___result = RMAllocate_UInt32.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RAlloc(___result);
        }


        public virtual void Free(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RMFree_Alloc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock CoalesceBlockWithPrevious(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock @block)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@block.Value};
            var ___result = RMCoalesceBlockWithPrevious_Block.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RHeapStatistics GatherStatistics()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGatherStatistics.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RHeapStatistics(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock BestFitFindAvailableBlock(System.UInt32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size};
            var ___result = RMBestFitFindAvailableBlock_UInt32.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock(___result);
        }


        public virtual void SplitBlock(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock @block, System.UInt32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@block.Value, @size};
            var ___result = RMSplitBlock_Block_UInt32.Invoke(___genericsType, ___parameters);

            
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
