
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class RTextureRegistry
{
	
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.TextureRegistry+Statistics
	/// </summary>
    public partial class RStatistics : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.TextureRegistry+Statistics");
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


		/// <summary>
		/// System.Int32 freeIdsCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FfreeIdsCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFfreeIdsCount
		{
			get
			{
				if(r_FfreeIdsCount == null)
				{
					r_FfreeIdsCount = new(this, "freeIdsCount");
				}
				return r_FfreeIdsCount;
			}
		}

		/// <summary>
		/// System.Int32 createdIdsCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FcreatedIdsCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFcreatedIdsCount
		{
			get
			{
				if(r_FcreatedIdsCount == null)
				{
					r_FcreatedIdsCount = new(this, "createdIdsCount");
				}
				return r_FcreatedIdsCount;
			}
		}

		/// <summary>
		/// System.Int32 allocatedIdsTotalCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FallocatedIdsTotalCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFallocatedIdsTotalCount
		{
			get
			{
				if(r_FallocatedIdsTotalCount == null)
				{
					r_FallocatedIdsTotalCount = new(this, "allocatedIdsTotalCount");
				}
				return r_FallocatedIdsTotalCount;
			}
		}

		/// <summary>
		/// System.Int32 allocatedIdsDynamicCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FallocatedIdsDynamicCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFallocatedIdsDynamicCount
		{
			get
			{
				if(r_FallocatedIdsDynamicCount == null)
				{
					r_FallocatedIdsDynamicCount = new(this, "allocatedIdsDynamicCount");
				}
				return r_FallocatedIdsDynamicCount;
			}
		}

		/// <summary>
		/// System.Int32 allocatedIdsStaticCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FallocatedIdsStaticCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFallocatedIdsStaticCount
		{
			get
			{
				if(r_FallocatedIdsStaticCount == null)
				{
					r_FallocatedIdsStaticCount = new(this, "allocatedIdsStaticCount");
				}
				return r_FallocatedIdsStaticCount;
			}
		}

		/// <summary>
		/// System.Int32 availableIdsCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FavailableIdsCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFavailableIdsCount
		{
			get
			{
				if(r_FavailableIdsCount == null)
				{
					r_FavailableIdsCount = new(this, "availableIdsCount");
				}
				return r_FavailableIdsCount;
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
}