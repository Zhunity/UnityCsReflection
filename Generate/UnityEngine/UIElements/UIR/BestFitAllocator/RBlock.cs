using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{public partial class RBestFitAllocator
{
	
	/// <summary>
	/// UnityEngine.UIElements.UIR.BestFitAllocator+Block
	/// </summary>
    public partial class RBlock : RMember //
    {

		/// <summary>
		/// System.UInt32 start
		/// </summary>
		protected RField r_start;
		public virtual RField Rstart
		{
			get
			{
				if(r_start == null)
				{
					r_start = new(this, "start");
					r_start.SetBelong(this.instance);
				}
				return r_start;
			}
		}

		/// <summary>
		/// System.UInt32 end
		/// </summary>
		protected RField r_end;
		public virtual RField Rend
		{
			get
			{
				if(r_end == null)
				{
					r_end = new(this, "end");
					r_end.SetBelong(this.instance);
				}
				return r_end;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator+Block prev
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock r_prev;
		public virtual RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock Rprev
		{
			get
			{
				if(r_prev == null)
				{
					r_prev = new(this, "prev");
					r_prev.SetBelong(this.instance);
				}
				return r_prev;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator+Block next
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock r_next;
		public virtual RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock Rnext
		{
			get
			{
				if(r_next == null)
				{
					r_next = new(this, "next");
					r_next.SetBelong(this.instance);
				}
				return r_next;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator+Block prevAvailable
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock r_prevAvailable;
		public virtual RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock RprevAvailable
		{
			get
			{
				if(r_prevAvailable == null)
				{
					r_prevAvailable = new(this, "prevAvailable");
					r_prevAvailable.SetBelong(this.instance);
				}
				return r_prevAvailable;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator+Block nextAvailable
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock r_nextAvailable;
		public virtual RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock RnextAvailable
		{
			get
			{
				if(r_nextAvailable == null)
				{
					r_nextAvailable = new(this, "nextAvailable");
					r_nextAvailable.SetBelong(this.instance);
				}
				return r_nextAvailable;
			}
		}

		/// <summary>
		/// System.Boolean allocated
		/// </summary>
		protected RField r_allocated;
		public virtual RField Rallocated
		{
			get
			{
				if(r_allocated == null)
				{
					r_allocated = new(this, "allocated");
					r_allocated.SetBelong(this.instance);
				}
				return r_allocated;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BestFitAllocator+Block poolNext
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock r_poolNext;
		public virtual RUnityEngine.RUIElements.RUIR.RBestFitAllocator.RBlock RpoolNext
		{
			get
			{
				if(r_poolNext == null)
				{
					r_poolNext = new(this, "poolNext");
					r_poolNext.SetBelong(this.instance);
				}
				return r_poolNext;
			}
		}

		/// <summary>
		/// UInt32 size
		/// </summary>
		protected RProperty r_size;
		public virtual RProperty Rsize
		{
			get
			{
				if(r_size == null)
				{
					r_size = new(this, "size", -1);
					r_size.SetBelong(this.instance);
				}
				return r_size;
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
}