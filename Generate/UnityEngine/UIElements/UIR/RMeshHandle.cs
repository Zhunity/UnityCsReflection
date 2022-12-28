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
		protected RUnityEngine.RUIElements.RUIR.RAlloc r_allocVerts;
		public virtual RUnityEngine.RUIElements.RUIR.RAlloc RallocVerts
		{
			get
			{
				if(r_allocVerts == null)
				{
					r_allocVerts = new(this, "allocVerts");
					r_allocVerts.SetBelong(this.instance);
				}
				return r_allocVerts;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Alloc allocIndices
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RAlloc r_allocIndices;
		public virtual RUnityEngine.RUIElements.RUIR.RAlloc RallocIndices
		{
			get
			{
				if(r_allocIndices == null)
				{
					r_allocIndices = new(this, "allocIndices");
					r_allocIndices.SetBelong(this.instance);
				}
				return r_allocIndices;
			}
		}

		/// <summary>
		/// System.UInt32 triangleCount
		/// </summary>
		protected RField r_triangleCount;
		public virtual RField RtriangleCount
		{
			get
			{
				if(r_triangleCount == null)
				{
					r_triangleCount = new(this, "triangleCount");
					r_triangleCount.SetBelong(this.instance);
				}
				return r_triangleCount;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Page allocPage
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RPage r_allocPage;
		public virtual RUnityEngine.RUIElements.RUIR.RPage RallocPage
		{
			get
			{
				if(r_allocPage == null)
				{
					r_allocPage = new(this, "allocPage");
					r_allocPage.SetBelong(this.instance);
				}
				return r_allocPage;
			}
		}

		/// <summary>
		/// System.UInt32 allocTime
		/// </summary>
		protected RField r_allocTime;
		public virtual RField RallocTime
		{
			get
			{
				if(r_allocTime == null)
				{
					r_allocTime = new(this, "allocTime");
					r_allocTime.SetBelong(this.instance);
				}
				return r_allocTime;
			}
		}

		/// <summary>
		/// System.UInt32 updateAllocID
		/// </summary>
		protected RField r_updateAllocID;
		public virtual RField RupdateAllocID
		{
			get
			{
				if(r_updateAllocID == null)
				{
					r_updateAllocID = new(this, "updateAllocID");
					r_updateAllocID.SetBelong(this.instance);
				}
				return r_updateAllocID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.MeshHandle poolNext
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RMeshHandle r_poolNext;
		public virtual RUnityEngine.RUIElements.RUIR.RMeshHandle RpoolNext
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