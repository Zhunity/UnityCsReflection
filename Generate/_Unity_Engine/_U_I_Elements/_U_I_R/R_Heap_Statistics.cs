
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.UIR.HeapStatistics
	/// </summary>
    public partial class RHeapStatistics : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.HeapStatistics");
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


		/// <summary>
		/// System.UInt32 numAllocs
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FnumAllocs;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFnumAllocs
		{
			get
			{
				if(r_FnumAllocs == null)
				{
					r_FnumAllocs = new(this, "numAllocs");
				}
				return r_FnumAllocs;
			}
		}

		/// <summary>
		/// System.UInt32 totalSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FtotalSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFtotalSize
		{
			get
			{
				if(r_FtotalSize == null)
				{
					r_FtotalSize = new(this, "totalSize");
				}
				return r_FtotalSize;
			}
		}

		/// <summary>
		/// System.UInt32 allocatedSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FallocatedSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFallocatedSize
		{
			get
			{
				if(r_FallocatedSize == null)
				{
					r_FallocatedSize = new(this, "allocatedSize");
				}
				return r_FallocatedSize;
			}
		}

		/// <summary>
		/// System.UInt32 freeSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FfreeSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFfreeSize
		{
			get
			{
				if(r_FfreeSize == null)
				{
					r_FfreeSize = new(this, "freeSize");
				}
				return r_FfreeSize;
			}
		}

		/// <summary>
		/// System.UInt32 largestAvailableBlock
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FlargestAvailableBlock;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFlargestAvailableBlock
		{
			get
			{
				if(r_FlargestAvailableBlock == null)
				{
					r_FlargestAvailableBlock = new(this, "largestAvailableBlock");
				}
				return r_FlargestAvailableBlock;
			}
		}

		/// <summary>
		/// System.UInt32 availableBlocksCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FavailableBlocksCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFavailableBlocksCount
		{
			get
			{
				if(r_FavailableBlocksCount == null)
				{
					r_FavailableBlocksCount = new(this, "availableBlocksCount");
				}
				return r_FavailableBlocksCount;
			}
		}

		/// <summary>
		/// System.UInt32 blockCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FblockCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFblockCount
		{
			get
			{
				if(r_FblockCount == null)
				{
					r_FblockCount = new(this, "blockCount");
				}
				return r_FblockCount;
			}
		}

		/// <summary>
		/// System.UInt32 highWatermark
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_FhighWatermark;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFhighWatermark
		{
			get
			{
				if(r_FhighWatermark == null)
				{
					r_FhighWatermark = new(this, "highWatermark");
				}
				return r_FhighWatermark;
			}
		}

		/// <summary>
		/// System.Single fragmentation
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Ffragmentation;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFfragmentation
		{
			get
			{
				if(r_Ffragmentation == null)
				{
					r_Ffragmentation = new(this, "fragmentation");
				}
				return r_Ffragmentation;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.HeapStatistics[] subAllocators
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RHeapStatistics> r_FsubAllocators;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RHeapStatistics> RFsubAllocators
		{
			get
			{
				if(r_FsubAllocators == null)
				{
					r_FsubAllocators = new(this, "subAllocators");
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
