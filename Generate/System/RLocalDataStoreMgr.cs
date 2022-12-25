using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.LocalDataStoreMgr
	/// </summary>
    public partial class RLocalDataStoreMgr : RMember //
    {

		/// <summary>
		/// System.Int32 InitialSlotTableSize
		/// </summary>
		protected static RField r_InitialSlotTableSize;
		public static RField RInitialSlotTableSize
		{
			get
			{
				if(r_InitialSlotTableSize == null)
				{
					r_InitialSlotTableSize = new( ReleactionUtils.GetType("System.LocalDataStoreMgr"), "InitialSlotTableSize");
					r_InitialSlotTableSize.SetBelong(null);
				}
				return r_InitialSlotTableSize;
			}
		}

		/// <summary>
		/// System.Int32 SlotTableDoubleThreshold
		/// </summary>
		protected static RField r_SlotTableDoubleThreshold;
		public static RField RSlotTableDoubleThreshold
		{
			get
			{
				if(r_SlotTableDoubleThreshold == null)
				{
					r_SlotTableDoubleThreshold = new( ReleactionUtils.GetType("System.LocalDataStoreMgr"), "SlotTableDoubleThreshold");
					r_SlotTableDoubleThreshold.SetBelong(null);
				}
				return r_SlotTableDoubleThreshold;
			}
		}

		/// <summary>
		/// System.Int32 LargeSlotTableSizeIncrease
		/// </summary>
		protected static RField r_LargeSlotTableSizeIncrease;
		public static RField RLargeSlotTableSizeIncrease
		{
			get
			{
				if(r_LargeSlotTableSizeIncrease == null)
				{
					r_LargeSlotTableSizeIncrease = new( ReleactionUtils.GetType("System.LocalDataStoreMgr"), "LargeSlotTableSizeIncrease");
					r_LargeSlotTableSizeIncrease.SetBelong(null);
				}
				return r_LargeSlotTableSizeIncrease;
			}
		}

		/// <summary>
		/// System.Boolean[] m_SlotInfoTable
		/// </summary>
		protected RFieldArray<RField> r_m_SlotInfoTable;
		public virtual RFieldArray<RField> Rm_SlotInfoTable
		{
			get
			{
				if(r_m_SlotInfoTable == null)
				{
					r_m_SlotInfoTable = new(this, "m_SlotInfoTable");
					r_m_SlotInfoTable.SetBelong(this.instance);
				}
				return r_m_SlotInfoTable;
			}
		}

		/// <summary>
		/// System.Int32 m_FirstAvailableSlot
		/// </summary>
		protected RField r_m_FirstAvailableSlot;
		public virtual RField Rm_FirstAvailableSlot
		{
			get
			{
				if(r_m_FirstAvailableSlot == null)
				{
					r_m_FirstAvailableSlot = new(this, "m_FirstAvailableSlot");
					r_m_FirstAvailableSlot.SetBelong(this.instance);
				}
				return r_m_FirstAvailableSlot;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.LocalDataStore] m_ManagedLocalDataStores
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RLocalDataStore> r_m_ManagedLocalDataStores;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RLocalDataStore> Rm_ManagedLocalDataStores
		{
			get
			{
				if(r_m_ManagedLocalDataStores == null)
				{
					r_m_ManagedLocalDataStores = new(this, "m_ManagedLocalDataStores");
					r_m_ManagedLocalDataStores.SetBelong(this.instance);
				}
				return r_m_ManagedLocalDataStores;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.LocalDataStoreSlot] m_KeyToSlotMap
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RLocalDataStoreSlot> r_m_KeyToSlotMap;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RLocalDataStoreSlot> Rm_KeyToSlotMap
		{
			get
			{
				if(r_m_KeyToSlotMap == null)
				{
					r_m_KeyToSlotMap = new(this, "m_KeyToSlotMap");
					r_m_KeyToSlotMap.SetBelong(this.instance);
				}
				return r_m_KeyToSlotMap;
			}
		}

		/// <summary>
		/// System.Int64 m_CookieGenerator
		/// </summary>
		protected RField r_m_CookieGenerator;
		public virtual RField Rm_CookieGenerator
		{
			get
			{
				if(r_m_CookieGenerator == null)
				{
					r_m_CookieGenerator = new(this, "m_CookieGenerator");
					r_m_CookieGenerator.SetBelong(this.instance);
				}
				return r_m_CookieGenerator;
			}
		}

		/// <summary>
		/// System.LocalDataStoreHolder CreateLocalDataStore()
		/// </summary>
		protected RMethod r_RCreateLocalDataStore;
		public virtual RMethod RCreateLocalDataStore
		{
			get
			{
				if(r_RCreateLocalDataStore == null)
				{
					r_RCreateLocalDataStore = new(this, "CreateLocalDataStore", 0);
					r_RCreateLocalDataStore.SetBelong(this.instance);
				}
				return r_RCreateLocalDataStore;
			}
		}

		/// <summary>
		/// Void DeleteLocalDataStore(System.LocalDataStore)
		/// </summary>
		protected RMethod r_RDeleteLocalDataStore_LocalDataStore;
		public virtual RMethod RDeleteLocalDataStore_LocalDataStore
		{
			get
			{
				if(r_RDeleteLocalDataStore_LocalDataStore == null)
				{
					r_RDeleteLocalDataStore_LocalDataStore = new(this, "DeleteLocalDataStore", 0,  ReleactionUtils.GetType("System.LocalDataStore"));
					r_RDeleteLocalDataStore_LocalDataStore.SetBelong(this.instance);
				}
				return r_RDeleteLocalDataStore_LocalDataStore;
			}
		}

		/// <summary>
		/// System.LocalDataStoreSlot AllocateDataSlot()
		/// </summary>
		protected RMethod r_RAllocateDataSlot;
		public virtual RMethod RAllocateDataSlot
		{
			get
			{
				if(r_RAllocateDataSlot == null)
				{
					r_RAllocateDataSlot = new(this, "AllocateDataSlot", 0);
					r_RAllocateDataSlot.SetBelong(this.instance);
				}
				return r_RAllocateDataSlot;
			}
		}

		/// <summary>
		/// System.LocalDataStoreSlot AllocateNamedDataSlot(System.String)
		/// </summary>
		protected RMethod r_RAllocateNamedDataSlot_String;
		public virtual RMethod RAllocateNamedDataSlot_String
		{
			get
			{
				if(r_RAllocateNamedDataSlot_String == null)
				{
					r_RAllocateNamedDataSlot_String = new(this, "AllocateNamedDataSlot", 0, typeof(System.String));
					r_RAllocateNamedDataSlot_String.SetBelong(this.instance);
				}
				return r_RAllocateNamedDataSlot_String;
			}
		}

		/// <summary>
		/// System.LocalDataStoreSlot GetNamedDataSlot(System.String)
		/// </summary>
		protected RMethod r_RGetNamedDataSlot_String;
		public virtual RMethod RGetNamedDataSlot_String
		{
			get
			{
				if(r_RGetNamedDataSlot_String == null)
				{
					r_RGetNamedDataSlot_String = new(this, "GetNamedDataSlot", 0, typeof(System.String));
					r_RGetNamedDataSlot_String.SetBelong(this.instance);
				}
				return r_RGetNamedDataSlot_String;
			}
		}

		/// <summary>
		/// Void FreeNamedDataSlot(System.String)
		/// </summary>
		protected RMethod r_RFreeNamedDataSlot_String;
		public virtual RMethod RFreeNamedDataSlot_String
		{
			get
			{
				if(r_RFreeNamedDataSlot_String == null)
				{
					r_RFreeNamedDataSlot_String = new(this, "FreeNamedDataSlot", 0, typeof(System.String));
					r_RFreeNamedDataSlot_String.SetBelong(this.instance);
				}
				return r_RFreeNamedDataSlot_String;
			}
		}

		/// <summary>
		/// Void FreeDataSlot(Int32, Int64)
		/// </summary>
		protected RMethod r_RFreeDataSlot_Int32_Int64;
		public virtual RMethod RFreeDataSlot_Int32_Int64
		{
			get
			{
				if(r_RFreeDataSlot_Int32_Int64 == null)
				{
					r_RFreeDataSlot_Int32_Int64 = new(this, "FreeDataSlot", 0, typeof(System.Int32), typeof(System.Int64));
					r_RFreeDataSlot_Int32_Int64.SetBelong(this.instance);
				}
				return r_RFreeDataSlot_Int32_Int64;
			}
		}

		/// <summary>
		/// Void ValidateSlot(System.LocalDataStoreSlot)
		/// </summary>
		protected RMethod r_RValidateSlot_LocalDataStoreSlot;
		public virtual RMethod RValidateSlot_LocalDataStoreSlot
		{
			get
			{
				if(r_RValidateSlot_LocalDataStoreSlot == null)
				{
					r_RValidateSlot_LocalDataStoreSlot = new(this, "ValidateSlot", 0, typeof(System.LocalDataStoreSlot));
					r_RValidateSlot_LocalDataStoreSlot.SetBelong(this.instance);
				}
				return r_RValidateSlot_LocalDataStoreSlot;
			}
		}

		/// <summary>
		/// Int32 GetSlotTableLength()
		/// </summary>
		protected RMethod r_RGetSlotTableLength;
		public virtual RMethod RGetSlotTableLength
		{
			get
			{
				if(r_RGetSlotTableLength == null)
				{
					r_RGetSlotTableLength = new(this, "GetSlotTableLength", 0);
					r_RGetSlotTableLength.SetBelong(this.instance);
				}
				return r_RGetSlotTableLength;
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


        public RLocalDataStoreMgr() : base("System.LocalDataStoreMgr")
        {
        }

        public RLocalDataStoreMgr(System.Object instance) : base("System.LocalDataStoreMgr")
		{
            SetInstance(instance);
		}

        public RLocalDataStoreMgr(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLocalDataStoreMgr(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object CreateLocalDataStore()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateLocalDataStore.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual System.LocalDataStoreSlot AllocateDataSlot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAllocateDataSlot.Invoke(___genericsType, ___parameters);

            return (System.LocalDataStoreSlot)___result;
        }


        public virtual System.LocalDataStoreSlot AllocateNamedDataSlot(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RAllocateNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            return (System.LocalDataStoreSlot)___result;
        }


        public virtual System.LocalDataStoreSlot GetNamedDataSlot(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            return (System.LocalDataStoreSlot)___result;
        }


        public virtual void FreeNamedDataSlot(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RFreeNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FreeDataSlot(System.Int32  @slot, System.Int64  @cookie)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slot, @cookie};
            var ___result = RFreeDataSlot_Int32_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ValidateSlot(System.LocalDataStoreSlot  @slot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slot};
            var ___result = RValidateSlot_LocalDataStoreSlot.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetSlotTableLength()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSlotTableLength.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
