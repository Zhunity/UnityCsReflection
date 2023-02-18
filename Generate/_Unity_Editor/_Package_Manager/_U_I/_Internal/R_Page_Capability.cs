
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.PageCapability
	/// </summary>
    public partial class RPageCapability : RMember //
    {

		/// <summary>
		/// System.Boolean requireUserLoggedIn
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FrequireUserLoggedIn;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFrequireUserLoggedIn
		{
			get
			{
				if(r_FrequireUserLoggedIn == null)
				{
					r_FrequireUserLoggedIn = new(this, "requireUserLoggedIn");
				}
				return r_FrequireUserLoggedIn;
			}
		}

		/// <summary>
		/// System.Boolean requireNetwork
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FrequireNetwork;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFrequireNetwork
		{
			get
			{
				if(r_FrequireNetwork == null)
				{
					r_FrequireNetwork = new(this, "requireNetwork");
				}
				return r_FrequireNetwork;
			}
		}

		/// <summary>
		/// System.Boolean supportFilters
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FsupportFilters;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFsupportFilters
		{
			get
			{
				if(r_FsupportFilters == null)
				{
					r_FsupportFilters = new(this, "supportFilters");
				}
				return r_FsupportFilters;
			}
		}

		/// <summary>
		/// System.Boolean supportLocalReordering
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FsupportLocalReordering;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFsupportLocalReordering
		{
			get
			{
				if(r_FsupportLocalReordering == null)
				{
					r_FsupportLocalReordering = new(this, "supportLocalReordering");
				}
				return r_FsupportLocalReordering;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PageCapability+Ordering[] orderingValues
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageCapability.ROrdering> r_ForderingValues;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPageCapability.ROrdering> RForderingValues
		{
			get
			{
				if(r_ForderingValues == null)
				{
					r_ForderingValues = new(this, "orderingValues");
				}
				return r_ForderingValues;
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


        public RPageCapability() : base("UnityEditor.PackageManager.UI.Internal.PageCapability")
        {
        }

        public RPageCapability(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.PageCapability")
		{
            SetInstance(instance);
		}

        public RPageCapability(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPageCapability(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


    }
}
