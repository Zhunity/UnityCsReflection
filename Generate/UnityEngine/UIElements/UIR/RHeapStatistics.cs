using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.HeapStatistics
	/// </summary>
    public partial class RHeapStatistics : RMember //
    {

		/// <summary>
		/// System.UInt32 numAllocs
		/// </summary>
		protected RField r_numAllocs;
		public virtual RField RnumAllocs
		{
			get
			{
				if(r_numAllocs == null)
				{
					r_numAllocs = new(this, "numAllocs");
					r_numAllocs.SetBelong(this.instance);
				}
				return r_numAllocs;
			}
		}

		/// <summary>
		/// System.UInt32 totalSize
		/// </summary>
		protected RField r_totalSize;
		public virtual RField RtotalSize
		{
			get
			{
				if(r_totalSize == null)
				{
					r_totalSize = new(this, "totalSize");
					r_totalSize.SetBelong(this.instance);
				}
				return r_totalSize;
			}
		}

		/// <summary>
		/// System.UInt32 allocatedSize
		/// </summary>
		protected RField r_allocatedSize;
		public virtual RField RallocatedSize
		{
			get
			{
				if(r_allocatedSize == null)
				{
					r_allocatedSize = new(this, "allocatedSize");
					r_allocatedSize.SetBelong(this.instance);
				}
				return r_allocatedSize;
			}
		}

		/// <summary>
		/// System.UInt32 freeSize
		/// </summary>
		protected RField r_freeSize;
		public virtual RField RfreeSize
		{
			get
			{
				if(r_freeSize == null)
				{
					r_freeSize = new(this, "freeSize");
					r_freeSize.SetBelong(this.instance);
				}
				return r_freeSize;
			}
		}

		/// <summary>
		/// System.UInt32 largestAvailableBlock
		/// </summary>
		protected RField r_largestAvailableBlock;
		public virtual RField RlargestAvailableBlock
		{
			get
			{
				if(r_largestAvailableBlock == null)
				{
					r_largestAvailableBlock = new(this, "largestAvailableBlock");
					r_largestAvailableBlock.SetBelong(this.instance);
				}
				return r_largestAvailableBlock;
			}
		}

		/// <summary>
		/// System.UInt32 availableBlocksCount
		/// </summary>
		protected RField r_availableBlocksCount;
		public virtual RField RavailableBlocksCount
		{
			get
			{
				if(r_availableBlocksCount == null)
				{
					r_availableBlocksCount = new(this, "availableBlocksCount");
					r_availableBlocksCount.SetBelong(this.instance);
				}
				return r_availableBlocksCount;
			}
		}

		/// <summary>
		/// System.UInt32 blockCount
		/// </summary>
		protected RField r_blockCount;
		public virtual RField RblockCount
		{
			get
			{
				if(r_blockCount == null)
				{
					r_blockCount = new(this, "blockCount");
					r_blockCount.SetBelong(this.instance);
				}
				return r_blockCount;
			}
		}

		/// <summary>
		/// System.UInt32 highWatermark
		/// </summary>
		protected RField r_highWatermark;
		public virtual RField RhighWatermark
		{
			get
			{
				if(r_highWatermark == null)
				{
					r_highWatermark = new(this, "highWatermark");
					r_highWatermark.SetBelong(this.instance);
				}
				return r_highWatermark;
			}
		}

		/// <summary>
		/// System.Single fragmentation
		/// </summary>
		protected RField r_fragmentation;
		public virtual RField Rfragmentation
		{
			get
			{
				if(r_fragmentation == null)
				{
					r_fragmentation = new(this, "fragmentation");
					r_fragmentation.SetBelong(this.instance);
				}
				return r_fragmentation;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.HeapStatistics[] subAllocators
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RUIR.RHeapStatistics> r_subAllocators;
		public virtual RFieldArray<RUnityEngine.RUIElements.RUIR.RHeapStatistics> RsubAllocators
		{
			get
			{
				if(r_subAllocators == null)
				{
					r_subAllocators = new(this, "subAllocators");
					r_subAllocators.SetBelong(this.instance);
				}
				return r_subAllocators;
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


        public RHeapStatistics() : base("UnityEngine.UIElements.UIR.HeapStatistics")
        {
        }

        public RHeapStatistics(System.Object instance) : base("UnityEngine.UIElements.UIR.HeapStatistics")
		{
            SetInstance(instance);
		}

        public RHeapStatistics(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RHeapStatistics(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
