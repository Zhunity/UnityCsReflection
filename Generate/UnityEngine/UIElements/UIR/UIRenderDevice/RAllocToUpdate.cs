using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{public partial class RUIRenderDevice
{
	
	/// <summary>
	/// UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate
	/// </summary>
    public partial class RAllocToUpdate : RMember //
    {

		/// <summary>
		/// System.UInt32 id
		/// </summary>
		protected RField r_id;
		public virtual RField Rid
		{
			get
			{
				if(r_id == null)
				{
					r_id = new(this, "id");
					r_id.SetBelong(this.instance);
				}
				return r_id;
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
		/// UnityEngine.UIElements.UIR.MeshHandle meshHandle
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RMeshHandle r_meshHandle;
		public virtual RUnityEngine.RUIElements.RUIR.RMeshHandle RmeshHandle
		{
			get
			{
				if(r_meshHandle == null)
				{
					r_meshHandle = new(this, "meshHandle");
					r_meshHandle.SetBelong(this.instance);
				}
				return r_meshHandle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Alloc permAllocVerts
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RAlloc r_permAllocVerts;
		public virtual RUnityEngine.RUIElements.RUIR.RAlloc RpermAllocVerts
		{
			get
			{
				if(r_permAllocVerts == null)
				{
					r_permAllocVerts = new(this, "permAllocVerts");
					r_permAllocVerts.SetBelong(this.instance);
				}
				return r_permAllocVerts;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Alloc permAllocIndices
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RAlloc r_permAllocIndices;
		public virtual RUnityEngine.RUIElements.RUIR.RAlloc RpermAllocIndices
		{
			get
			{
				if(r_permAllocIndices == null)
				{
					r_permAllocIndices = new(this, "permAllocIndices");
					r_permAllocIndices.SetBelong(this.instance);
				}
				return r_permAllocIndices;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Page permPage
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RPage r_permPage;
		public virtual RUnityEngine.RUIElements.RUIR.RPage RpermPage
		{
			get
			{
				if(r_permPage == null)
				{
					r_permPage = new(this, "permPage");
					r_permPage.SetBelong(this.instance);
				}
				return r_permPage;
			}
		}

		/// <summary>
		/// System.Boolean copyBackIndices
		/// </summary>
		protected RField r_copyBackIndices;
		public virtual RField RcopyBackIndices
		{
			get
			{
				if(r_copyBackIndices == null)
				{
					r_copyBackIndices = new(this, "copyBackIndices");
					r_copyBackIndices.SetBelong(this.instance);
				}
				return r_copyBackIndices;
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


        public RAllocToUpdate() : base("UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate")
        {
        }

        public RAllocToUpdate(System.Object instance) : base("UnityEngine.UIElements.UIR.UIRenderDevice+AllocToUpdate")
		{
            SetInstance(instance);
		}

        public RAllocToUpdate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAllocToUpdate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object @obj)
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
}