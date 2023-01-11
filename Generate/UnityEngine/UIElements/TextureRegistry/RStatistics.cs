using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class RTextureRegistry
{
	
	/// <summary>
	/// UnityEngine.UIElements.TextureRegistry+Statistics
	/// </summary>
    public partial class RStatistics : RMember //
    {

		/// <summary>
		/// System.Int32 freeIdsCount
		/// </summary>
		protected RSystem.RInt32 r_freeIdsCount;
		public virtual RSystem.RInt32 RfreeIdsCount
		{
			get
			{
				if(r_freeIdsCount == null)
				{
					r_freeIdsCount = new(this, "freeIdsCount");
					r_freeIdsCount.SetBelong(this.instance);
				}
				return r_freeIdsCount;
			}
		}

		/// <summary>
		/// System.Int32 createdIdsCount
		/// </summary>
		protected RSystem.RInt32 r_createdIdsCount;
		public virtual RSystem.RInt32 RcreatedIdsCount
		{
			get
			{
				if(r_createdIdsCount == null)
				{
					r_createdIdsCount = new(this, "createdIdsCount");
					r_createdIdsCount.SetBelong(this.instance);
				}
				return r_createdIdsCount;
			}
		}

		/// <summary>
		/// System.Int32 allocatedIdsTotalCount
		/// </summary>
		protected RSystem.RInt32 r_allocatedIdsTotalCount;
		public virtual RSystem.RInt32 RallocatedIdsTotalCount
		{
			get
			{
				if(r_allocatedIdsTotalCount == null)
				{
					r_allocatedIdsTotalCount = new(this, "allocatedIdsTotalCount");
					r_allocatedIdsTotalCount.SetBelong(this.instance);
				}
				return r_allocatedIdsTotalCount;
			}
		}

		/// <summary>
		/// System.Int32 allocatedIdsDynamicCount
		/// </summary>
		protected RSystem.RInt32 r_allocatedIdsDynamicCount;
		public virtual RSystem.RInt32 RallocatedIdsDynamicCount
		{
			get
			{
				if(r_allocatedIdsDynamicCount == null)
				{
					r_allocatedIdsDynamicCount = new(this, "allocatedIdsDynamicCount");
					r_allocatedIdsDynamicCount.SetBelong(this.instance);
				}
				return r_allocatedIdsDynamicCount;
			}
		}

		/// <summary>
		/// System.Int32 allocatedIdsStaticCount
		/// </summary>
		protected RSystem.RInt32 r_allocatedIdsStaticCount;
		public virtual RSystem.RInt32 RallocatedIdsStaticCount
		{
			get
			{
				if(r_allocatedIdsStaticCount == null)
				{
					r_allocatedIdsStaticCount = new(this, "allocatedIdsStaticCount");
					r_allocatedIdsStaticCount.SetBelong(this.instance);
				}
				return r_allocatedIdsStaticCount;
			}
		}

		/// <summary>
		/// System.Int32 availableIdsCount
		/// </summary>
		protected RSystem.RInt32 r_availableIdsCount;
		public virtual RSystem.RInt32 RavailableIdsCount
		{
			get
			{
				if(r_availableIdsCount == null)
				{
					r_availableIdsCount = new(this, "availableIdsCount");
					r_availableIdsCount.SetBelong(this.instance);
				}
				return r_availableIdsCount;
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


        public RStatistics() : base("UnityEngine.UIElements.TextureRegistry+Statistics")
        {
        }

        public RStatistics(System.Object instance) : base("UnityEngine.UIElements.TextureRegistry+Statistics")
		{
            SetInstance(instance);
		}

        public RStatistics(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStatistics(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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