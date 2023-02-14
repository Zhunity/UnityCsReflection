
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.LocalDataStore
	/// </summary>
    public partial class RLocalDataStore : RMember //
    {

		/// <summary>
		/// System.LocalDataStoreElement[] m_DataTable
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RLocalDataStoreElement> r_Fm_DataTable;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RLocalDataStoreElement> RFm_DataTable
		{
			get
			{
				if(r_Fm_DataTable == null)
				{
					r_Fm_DataTable = new(this, "m_DataTable");
					r_Fm_DataTable.SetBelong(this.instance);
				}
				return r_Fm_DataTable;
			}
		}

		/// <summary>
		/// System.LocalDataStoreMgr m_Manager
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RLocalDataStoreMgr r_Fm_Manager;
		public virtual Hvak.Editor.Refleaction.RSystem.RLocalDataStoreMgr RFm_Manager
		{
			get
			{
				if(r_Fm_Manager == null)
				{
					r_Fm_Manager = new(this, "m_Manager");
					r_Fm_Manager.SetBelong(this.instance);
				}
				return r_Fm_Manager;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
					r_MDispose.SetBelong(this.instance);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// System.Object GetData(System.LocalDataStoreSlot)
		/// </summary>
		protected RMethod r_MGetData_LocalDataStoreSlot;
		public virtual RMethod RMGetData_LocalDataStoreSlot
		{
			get
			{
				if(r_MGetData_LocalDataStoreSlot == null)
				{
					r_MGetData_LocalDataStoreSlot = new(this, "GetData", 0, typeof(System.LocalDataStoreSlot));
					r_MGetData_LocalDataStoreSlot.SetBelong(this.instance);
				}
				return r_MGetData_LocalDataStoreSlot;
			}
		}

		/// <summary>
		/// Void SetData(System.LocalDataStoreSlot, System.Object)
		/// </summary>
		protected RMethod r_MSetData_LocalDataStoreSlot_Object;
		public virtual RMethod RMSetData_LocalDataStoreSlot_Object
		{
			get
			{
				if(r_MSetData_LocalDataStoreSlot_Object == null)
				{
					r_MSetData_LocalDataStoreSlot_Object = new(this, "SetData", 0, typeof(System.LocalDataStoreSlot), typeof(System.Object));
					r_MSetData_LocalDataStoreSlot_Object.SetBelong(this.instance);
				}
				return r_MSetData_LocalDataStoreSlot_Object;
			}
		}

		/// <summary>
		/// Void FreeData(Int32, Int64)
		/// </summary>
		protected RMethod r_MFreeData_Int32_Int64;
		public virtual RMethod RMFreeData_Int32_Int64
		{
			get
			{
				if(r_MFreeData_Int32_Int64 == null)
				{
					r_MFreeData_Int32_Int64 = new(this, "FreeData", 0, typeof(System.Int32), typeof(System.Int64));
					r_MFreeData_Int32_Int64.SetBelong(this.instance);
				}
				return r_MFreeData_Int32_Int64;
			}
		}

		/// <summary>
		/// System.LocalDataStoreElement PopulateElement(System.LocalDataStoreSlot)
		/// </summary>
		protected RMethod r_MPopulateElement_LocalDataStoreSlot;
		public virtual RMethod RMPopulateElement_LocalDataStoreSlot
		{
			get
			{
				if(r_MPopulateElement_LocalDataStoreSlot == null)
				{
					r_MPopulateElement_LocalDataStoreSlot = new(this, "PopulateElement", 0, typeof(System.LocalDataStoreSlot));
					r_MPopulateElement_LocalDataStoreSlot.SetBelong(this.instance);
				}
				return r_MPopulateElement_LocalDataStoreSlot;
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
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetData(System.LocalDataStoreSlot @slot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slot};
            var ___result = RMGetData_LocalDataStoreSlot.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetData(System.LocalDataStoreSlot @slot, System.Object @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slot, @data};
            var ___result = RMSetData_LocalDataStoreSlot_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FreeData(System.Int32 @slot, System.Int64 @cookie)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slot, @cookie};
            var ___result = RMFreeData_Int32_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RLocalDataStoreElement PopulateElement(System.LocalDataStoreSlot @slot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slot};
            var ___result = RMPopulateElement_LocalDataStoreSlot.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RLocalDataStoreElement(___result);
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
