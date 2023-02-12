
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
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_FnumAllocs;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFnumAllocs
		{
			get
			{
				if(r_FnumAllocs == null)
				{
					r_FnumAllocs = new(this, "numAllocs");
					r_FnumAllocs.SetBelong(this.instance);
				}
				return r_FnumAllocs;
			}
		}

		/// <summary>
		/// System.UInt32 totalSize
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_FtotalSize;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFtotalSize
		{
			get
			{
				if(r_FtotalSize == null)
				{
					r_FtotalSize = new(this, "totalSize");
					r_FtotalSize.SetBelong(this.instance);
				}
				return r_FtotalSize;
			}
		}

		/// <summary>
		/// System.UInt32 allocatedSize
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_FallocatedSize;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFallocatedSize
		{
			get
			{
				if(r_FallocatedSize == null)
				{
					r_FallocatedSize = new(this, "allocatedSize");
					r_FallocatedSize.SetBelong(this.instance);
				}
				return r_FallocatedSize;
			}
		}

		/// <summary>
		/// System.UInt32 freeSize
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_FfreeSize;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFfreeSize
		{
			get
			{
				if(r_FfreeSize == null)
				{
					r_FfreeSize = new(this, "freeSize");
					r_FfreeSize.SetBelong(this.instance);
				}
				return r_FfreeSize;
			}
		}

		/// <summary>
		/// System.UInt32 largestAvailableBlock
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_FlargestAvailableBlock;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFlargestAvailableBlock
		{
			get
			{
				if(r_FlargestAvailableBlock == null)
				{
					r_FlargestAvailableBlock = new(this, "largestAvailableBlock");
					r_FlargestAvailableBlock.SetBelong(this.instance);
				}
				return r_FlargestAvailableBlock;
			}
		}

		/// <summary>
		/// System.UInt32 availableBlocksCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_FavailableBlocksCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFavailableBlocksCount
		{
			get
			{
				if(r_FavailableBlocksCount == null)
				{
					r_FavailableBlocksCount = new(this, "availableBlocksCount");
					r_FavailableBlocksCount.SetBelong(this.instance);
				}
				return r_FavailableBlocksCount;
			}
		}

		/// <summary>
		/// System.UInt32 blockCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_FblockCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFblockCount
		{
			get
			{
				if(r_FblockCount == null)
				{
					r_FblockCount = new(this, "blockCount");
					r_FblockCount.SetBelong(this.instance);
				}
				return r_FblockCount;
			}
		}

		/// <summary>
		/// System.UInt32 highWatermark
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_FhighWatermark;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFhighWatermark
		{
			get
			{
				if(r_FhighWatermark == null)
				{
					r_FhighWatermark = new(this, "highWatermark");
					r_FhighWatermark.SetBelong(this.instance);
				}
				return r_FhighWatermark;
			}
		}

		/// <summary>
		/// System.Single fragmentation
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_Ffragmentation;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFfragmentation
		{
			get
			{
				if(r_Ffragmentation == null)
				{
					r_Ffragmentation = new(this, "fragmentation");
					r_Ffragmentation.SetBelong(this.instance);
				}
				return r_Ffragmentation;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.HeapStatistics[] subAllocators
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RHeapStatistics> r_FsubAllocators;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RHeapStatistics> RFsubAllocators
		{
			get
			{
				if(r_FsubAllocators == null)
				{
					r_FsubAllocators = new(this, "subAllocators");
					r_FsubAllocators.SetBelong(this.instance);
				}
				return r_FsubAllocators;
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

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
