
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{public partial class RBestFitAllocator
{
	
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.UIR.BestFitAllocator+Block
	/// </summary>
    public partial class RBlock : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BestFitAllocator+Block");
            }
        }

        public RBlock() : base("UnityEngine.UIElements.UIR.BestFitAllocator+Block")
        {
        }

        public RBlock(System.Object instance) : base("UnityEngine.UIElements.UIR.BestFitAllocator+Block")
		{
            SetInstance(instance);
		}

        public RBlock(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBlock(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.UInt32 start
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fstart;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFstart
		{
			get
			{
				if(r_Fstart == null)
				{
					r_Fstart = new(this, "start");
				}
				return r_Fstart;
			}
		}

		/// <summary>
		/// System.UInt32 end
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fend;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFend
		{
			get
			{
				if(r_Fend == null)
				{
					r_Fend = new(this, "end");
				}
				return r_Fend;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator+Block prev
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock r_Fprev;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock RFprev
		{
			get
			{
				if(r_Fprev == null)
				{
					r_Fprev = new(this, "prev");
				}
				return r_Fprev;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator+Block next
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock r_Fnext;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock RFnext
		{
			get
			{
				if(r_Fnext == null)
				{
					r_Fnext = new(this, "next");
				}
				return r_Fnext;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator+Block prevAvailable
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock r_FprevAvailable;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock RFprevAvailable
		{
			get
			{
				if(r_FprevAvailable == null)
				{
					r_FprevAvailable = new(this, "prevAvailable");
				}
				return r_FprevAvailable;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator+Block nextAvailable
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock r_FnextAvailable;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock RFnextAvailable
		{
			get
			{
				if(r_FnextAvailable == null)
				{
					r_FnextAvailable = new(this, "nextAvailable");
				}
				return r_FnextAvailable;
			}
		}

		/// <summary>
		/// System.Boolean allocated
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fallocated;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFallocated
		{
			get
			{
				if(r_Fallocated == null)
				{
					r_Fallocated = new(this, "allocated");
				}
				return r_Fallocated;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator+Block poolNext
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock r_FpoolNext;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock RFpoolNext
		{
			get
			{
				if(r_FpoolNext == null)
				{
					r_FpoolNext = new(this, "poolNext");
				}
				return r_FpoolNext;
			}
		}

		/// <summary>
		/// UInt32 size
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Psize;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPsize
		{
			get
			{
				if(r_Psize == null)
				{
					r_Psize = new(this, "size", -1);
				}
				return r_Psize;
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
}