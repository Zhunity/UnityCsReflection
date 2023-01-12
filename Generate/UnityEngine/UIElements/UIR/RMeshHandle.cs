using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.MeshHandle
	/// </summary>
    public partial class RMeshHandle : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.UIR.Alloc allocVerts
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RAlloc r_FallocVerts;
		public virtual RUnityEngine.RUIElements.RUIR.RAlloc RFallocVerts
		{
			get
			{
				if(r_FallocVerts == null)
				{
					r_FallocVerts = new(this, "allocVerts");
					r_FallocVerts.SetBelong(this.instance);
				}
				return r_FallocVerts;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Alloc allocIndices
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RAlloc r_FallocIndices;
		public virtual RUnityEngine.RUIElements.RUIR.RAlloc RFallocIndices
		{
			get
			{
				if(r_FallocIndices == null)
				{
					r_FallocIndices = new(this, "allocIndices");
					r_FallocIndices.SetBelong(this.instance);
				}
				return r_FallocIndices;
			}
		}

		/// <summary>
		/// System.UInt32 triangleCount
		/// </summary>
		protected RSystem.RUInt32 r_FtriangleCount;
		public virtual RSystem.RUInt32 RFtriangleCount
		{
			get
			{
				if(r_FtriangleCount == null)
				{
					r_FtriangleCount = new(this, "triangleCount");
					r_FtriangleCount.SetBelong(this.instance);
				}
				return r_FtriangleCount;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Page allocPage
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RPage r_FallocPage;
		public virtual RUnityEngine.RUIElements.RUIR.RPage RFallocPage
		{
			get
			{
				if(r_FallocPage == null)
				{
					r_FallocPage = new(this, "allocPage");
					r_FallocPage.SetBelong(this.instance);
				}
				return r_FallocPage;
			}
		}

		/// <summary>
		/// System.UInt32 allocTime
		/// </summary>
		protected RSystem.RUInt32 r_FallocTime;
		public virtual RSystem.RUInt32 RFallocTime
		{
			get
			{
				if(r_FallocTime == null)
				{
					r_FallocTime = new(this, "allocTime");
					r_FallocTime.SetBelong(this.instance);
				}
				return r_FallocTime;
			}
		}

		/// <summary>
		/// System.UInt32 updateAllocID
		/// </summary>
		protected RSystem.RUInt32 r_FupdateAllocID;
		public virtual RSystem.RUInt32 RFupdateAllocID
		{
			get
			{
				if(r_FupdateAllocID == null)
				{
					r_FupdateAllocID = new(this, "updateAllocID");
					r_FupdateAllocID.SetBelong(this.instance);
				}
				return r_FupdateAllocID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.MeshHandle poolNext
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RMeshHandle r_FpoolNext;
		public virtual RUnityEngine.RUIElements.RUIR.RMeshHandle RFpoolNext
		{
			get
			{
				if(r_FpoolNext == null)
				{
					r_FpoolNext = new(this, "poolNext");
					r_FpoolNext.SetBelong(this.instance);
				}
				return r_FpoolNext;
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


        public RMeshHandle() : base("UnityEngine.UIElements.UIR.MeshHandle")
        {
        }

        public RMeshHandle(System.Object instance) : base("UnityEngine.UIElements.UIR.MeshHandle")
		{
            SetInstance(instance);
		}

        public RMeshHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMeshHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
