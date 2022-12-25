using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.LocalDataStore
	/// </summary>
    public partial class RLocalDataStore : RMember //
    {

		/// <summary>
		/// System.LocalDataStoreElement[] m_DataTable
		/// </summary>
		protected RFieldArray<RSystem.RLocalDataStoreElement> r_m_DataTable;
		public virtual RFieldArray<RSystem.RLocalDataStoreElement> Rm_DataTable
		{
			get
			{
				if(r_m_DataTable == null)
				{
					r_m_DataTable = new(this, "m_DataTable");
					r_m_DataTable.SetBelong(this.instance);
				}
				return r_m_DataTable;
			}
		}

		/// <summary>
		/// System.LocalDataStoreMgr m_Manager
		/// </summary>
		protected RSystem.RLocalDataStoreMgr r_m_Manager;
		public virtual RSystem.RLocalDataStoreMgr Rm_Manager
		{
			get
			{
				if(r_m_Manager == null)
				{
					r_m_Manager = new(this, "m_Manager");
					r_m_Manager.SetBelong(this.instance);
				}
				return r_m_Manager;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// System.Object GetData(System.LocalDataStoreSlot)
		/// </summary>
		protected RMethod r_RGetData_LocalDataStoreSlot;
		public virtual RMethod RGetData_LocalDataStoreSlot
		{
			get
			{
				if(r_RGetData_LocalDataStoreSlot == null)
				{
					r_RGetData_LocalDataStoreSlot = new(this, "GetData", 0, typeof(System.LocalDataStoreSlot));
					r_RGetData_LocalDataStoreSlot.SetBelong(this.instance);
				}
				return r_RGetData_LocalDataStoreSlot;
			}
		}

		/// <summary>
		/// Void SetData(System.LocalDataStoreSlot, System.Object)
		/// </summary>
		protected RMethod r_RSetData_LocalDataStoreSlot_Object;
		public virtual RMethod RSetData_LocalDataStoreSlot_Object
		{
			get
			{
				if(r_RSetData_LocalDataStoreSlot_Object == null)
				{
					r_RSetData_LocalDataStoreSlot_Object = new(this, "SetData", 0, typeof(System.LocalDataStoreSlot), typeof(System.Object));
					r_RSetData_LocalDataStoreSlot_Object.SetBelong(this.instance);
				}
				return r_RSetData_LocalDataStoreSlot_Object;
			}
		}

		/// <summary>
		/// Void FreeData(Int32, Int64)
		/// </summary>
		protected RMethod r_RFreeData_Int32_Int64;
		public virtual RMethod RFreeData_Int32_Int64
		{
			get
			{
				if(r_RFreeData_Int32_Int64 == null)
				{
					r_RFreeData_Int32_Int64 = new(this, "FreeData", 0, typeof(System.Int32), typeof(System.Int64));
					r_RFreeData_Int32_Int64.SetBelong(this.instance);
				}
				return r_RFreeData_Int32_Int64;
			}
		}

		/// <summary>
		/// System.LocalDataStoreElement PopulateElement(System.LocalDataStoreSlot)
		/// </summary>
		protected RMethod r_RPopulateElement_LocalDataStoreSlot;
		public virtual RMethod RPopulateElement_LocalDataStoreSlot
		{
			get
			{
				if(r_RPopulateElement_LocalDataStoreSlot == null)
				{
					r_RPopulateElement_LocalDataStoreSlot = new(this, "PopulateElement", 0, typeof(System.LocalDataStoreSlot));
					r_RPopulateElement_LocalDataStoreSlot.SetBelong(this.instance);
				}
				return r_RPopulateElement_LocalDataStoreSlot;
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


        public RLocalDataStore() : base("System.LocalDataStore")
        {
        }

        public RLocalDataStore(System.Object instance) : base("System.LocalDataStore")
		{
            SetInstance(instance);
		}

        public RLocalDataStore(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLocalDataStore(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetData(System.LocalDataStoreSlot  @slot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slot};
            var ___result = RGetData_LocalDataStoreSlot.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetData(System.LocalDataStoreSlot  @slot, System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slot, @data};
            var ___result = RSetData_LocalDataStoreSlot_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FreeData(System.Int32  @slot, System.Int64  @cookie)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slot, @cookie};
            var ___result = RFreeData_Int32_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object PopulateElement(System.LocalDataStoreSlot  @slot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slot};
            var ___result = RPopulateElement_LocalDataStoreSlot.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
