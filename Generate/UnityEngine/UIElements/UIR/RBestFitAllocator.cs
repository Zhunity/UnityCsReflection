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
		protected RField r___1__totalSize__2__k__BackingField;
		public virtual RField R__1__totalSize__2__k__BackingField
		{
			get
			{
				if(r___1__totalSize__2__k__BackingField == null)
				{
					r___1__totalSize__2__k__BackingField = new(this, "<totalSize>k__BackingField");
					r___1__totalSize__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__totalSize__2__k__BackingField;
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
		protected RField r_m_HighWatermark;
		public virtual RField Rm_HighWatermark
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
		protected RProperty r_totalSize;
		public virtual RProperty RtotalSize
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
		protected RProperty r_highWatermark;
		public virtual RProperty RhighWatermark
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
		protected RMethod r_RAllocate_UInt32;
		public virtual RMethod RAllocate_UInt32
		{
			get
			{
				if(r_RAllocate_UInt32 == null)
				{
					r_RAllocate_UInt32 = new(this, "Allocate", 0, typeof(System.UInt32));
					r_RAllocate_UInt32.SetBelong(this.instance);
				}
				return r_RAllocate_UInt32;
			}
		}

		/// <summary>
		/// Void Free(UnityEngine.UIElements.UIR.Alloc)
		/// </summary>
		protected RMethod r_RFree_Alloc;
		public virtual RMethod RFree_Alloc
		{
			get
			{
				if(r_RFree_Alloc == null)
				{
					r_RFree_Alloc = new(this, "Free", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.Alloc"));
					r_RFree_Alloc.SetBelong(this.instance);
				}
				return r_RFree_Alloc;
			}
		}

		/// <summary>
		/// Block CoalesceBlockWithPrevious(Block)
		/// </summary>
		protected RMethod r_RCoalesceBlockWithPrevious_Block;
		public virtual RMethod RCoalesceBlockWithPrevious_Block
		{
			get
			{
				if(r_RCoalesceBlockWithPrevious_Block == null)
				{
					r_RCoalesceBlockWithPrevious_Block = new(this, "CoalesceBlockWithPrevious", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BestFitAllocator+Block"));
					r_RCoalesceBlockWithPrevious_Block.SetBelong(this.instance);
				}
				return r_RCoalesceBlockWithPrevious_Block;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.HeapStatistics GatherStatistics()
		/// </summary>
		protected RMethod r_RGatherStatistics;
		public virtual RMethod RGatherStatistics
		{
			get
			{
				if(r_RGatherStatistics == null)
				{
					r_RGatherStatistics = new(this, "GatherStatistics", 0);
					r_RGatherStatistics.SetBelong(this.instance);
				}
				return r_RGatherStatistics;
			}
		}

		/// <summary>
		/// Block BestFitFindAvailableBlock(UInt32)
		/// </summary>
		protected RMethod r_RBestFitFindAvailableBlock_UInt32;
		public virtual RMethod RBestFitFindAvailableBlock_UInt32
		{
			get
			{
				if(r_RBestFitFindAvailableBlock_UInt32 == null)
				{
					r_RBestFitFindAvailableBlock_UInt32 = new(this, "BestFitFindAvailableBlock", 0, typeof(System.UInt32));
					r_RBestFitFindAvailableBlock_UInt32.SetBelong(this.instance);
				}
				return r_RBestFitFindAvailableBlock_UInt32;
			}
		}

		/// <summary>
		/// Void SplitBlock(Block, UInt32)
		/// </summary>
		protected RMethod r_RSplitBlock_Block_UInt32;
		public virtual RMethod RSplitBlock_Block_UInt32
		{
			get
			{
				if(r_RSplitBlock_Block_UInt32 == null)
				{
					r_RSplitBlock_Block_UInt32 = new(this, "SplitBlock", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.BestFitAllocator+Block"), typeof(System.UInt32));
					r_RSplitBlock_Block_UInt32.SetBelong(this.instance);
				}
				return r_RSplitBlock_Block_UInt32;
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

        public virtual System.Object Allocate(System.UInt32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size};
            var ___result = RAllocate_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }




        public virtual System.Object GatherStatistics()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGatherStatistics.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object BestFitFindAvailableBlock(System.UInt32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size};
            var ___result = RBestFitFindAvailableBlock_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
