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
		protected static RSystem.RInt32 r_InitialSlotTableSize;
		public static RSystem.RInt32 RInitialSlotTableSize
		{
			get
			{
				if(r_InitialSlotTableSize == null)
				{
					r_InitialSlotTableSize = new( ReflectionUtils.GetType("System.LocalDataStoreMgr"), "InitialSlotTableSize");
					r_InitialSlotTableSize.SetBelong(null);
				}
				return r_InitialSlotTableSize;
			}
		}

		/// <summary>
		/// System.Int32 SlotTableDoubleThreshold
		/// </summary>
		protected static RSystem.RInt32 r_SlotTableDoubleThreshold;
		public static RSystem.RInt32 RSlotTableDoubleThreshold
		{
			get
			{
				if(r_SlotTableDoubleThreshold == null)
				{
					r_SlotTableDoubleThreshold = new( ReflectionUtils.GetType("System.LocalDataStoreMgr"), "SlotTableDoubleThreshold");
					r_SlotTableDoubleThreshold.SetBelong(null);
				}
				return r_SlotTableDoubleThreshold;
			}
		}

		/// <summary>
		/// System.Int32 LargeSlotTableSizeIncrease
		/// </summary>
		protected static RSystem.RInt32 r_LargeSlotTableSizeIncrease;
		public static RSystem.RInt32 RLargeSlotTableSizeIncrease
		{
			get
			{
				if(r_LargeSlotTableSizeIncrease == null)
				{
					r_LargeSlotTableSizeIncrease = new( ReflectionUtils.GetType("System.LocalDataStoreMgr"), "LargeSlotTableSizeIncrease");
					r_LargeSlotTableSizeIncrease.SetBelong(null);
				}
				return r_LargeSlotTableSizeIncrease;
			}
		}

		/// <summary>
		/// System.Boolean[] m_SlotInfoTable
		/// </summary>
		protected RFieldArray<RSystem.RBoolean> r_m_SlotInfoTable;
		public virtual RFieldArray<RSystem.RBoolean> Rm_SlotInfoTable
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
		protected RSystem.RInt32 r_m_FirstAvailableSlot;
		public virtual RSystem.RInt32 Rm_FirstAvailableSlot
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
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RString, RSystem.RLocalDataStoreSlot> r_m_KeyToSlotMap;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RString, RSystem.RLocalDataStoreSlot> Rm_KeyToSlotMap
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
		protected RSystem.RInt64 r_m_CookieGenerator;
		public virtual RSystem.RInt64 Rm_CookieGenerator
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
		protected RMethod r_CreateLocalDataStore;
		public virtual RMethod RCreateLocalDataStore
		{
			get
			{
				if(r_CreateLocalDataStore == null)
				{
					r_CreateLocalDataStore = new(this, "CreateLocalDataStore", 0);
					r_CreateLocalDataStore.SetBelong(this.instance);
				}
				return r_CreateLocalDataStore;
			}
		}

		/// <summary>
		/// Void DeleteLocalDataStore(System.LocalDataStore)
		/// </summary>
		protected RMethod r_DeleteLocalDataStore_LocalDataStore;
		public virtual RMethod RDeleteLocalDataStore_LocalDataStore
		{
			get
			{
				if(r_DeleteLocalDataStore_LocalDataStore == null)
				{
					r_DeleteLocalDataStore_LocalDataStore = new(this, "DeleteLocalDataStore", 0,  ReflectionUtils.GetType("System.LocalDataStore"));
					r_DeleteLocalDataStore_LocalDataStore.SetBelong(this.instance);
				}
				return r_DeleteLocalDataStore_LocalDataStore;
			}
		}

		/// <summary>
		/// System.LocalDataStoreSlot AllocateDataSlot()
		/// </summary>
		protected RMethod r_AllocateDataSlot;
		public virtual RMethod RAllocateDataSlot
		{
			get
			{
				if(r_AllocateDataSlot == null)
				{
					r_AllocateDataSlot = new(this, "AllocateDataSlot", 0);
					r_AllocateDataSlot.SetBelong(this.instance);
				}
				return r_AllocateDataSlot;
			}
		}

		/// <summary>
		/// System.LocalDataStoreSlot AllocateNamedDataSlot(System.String)
		/// </summary>
		protected RMethod r_AllocateNamedDataSlot_String;
		public virtual RMethod RAllocateNamedDataSlot_String
		{
			get
			{
				if(r_AllocateNamedDataSlot_String == null)
				{
					r_AllocateNamedDataSlot_String = new(this, "AllocateNamedDataSlot", 0, typeof(System.String));
					r_AllocateNamedDataSlot_String.SetBelong(this.instance);
				}
				return r_AllocateNamedDataSlot_String;
			}
		}

		/// <summary>
		/// System.LocalDataStoreSlot GetNamedDataSlot(System.String)
		/// </summary>
		protected RMethod r_GetNamedDataSlot_String;
		public virtual RMethod RGetNamedDataSlot_String
		{
			get
			{
				if(r_GetNamedDataSlot_String == null)
				{
					r_GetNamedDataSlot_String = new(this, "GetNamedDataSlot", 0, typeof(System.String));
					r_GetNamedDataSlot_String.SetBelong(this.instance);
				}
				return r_GetNamedDataSlot_String;
			}
		}

		/// <summary>
		/// Void FreeNamedDataSlot(System.String)
		/// </summary>
		protected RMethod r_FreeNamedDataSlot_String;
		public virtual RMethod RFreeNamedDataSlot_String
		{
			get
			{
				if(r_FreeNamedDataSlot_String == null)
				{
					r_FreeNamedDataSlot_String = new(this, "FreeNamedDataSlot", 0, typeof(System.String));
					r_FreeNamedDataSlot_String.SetBelong(this.instance);
				}
				return r_FreeNamedDataSlot_String;
			}
		}

		/// <summary>
		/// Void FreeDataSlot(Int32, Int64)
		/// </summary>
		protected RMethod r_FreeDataSlot_Int32_Int64;
		public virtual RMethod RFreeDataSlot_Int32_Int64
		{
			get
			{
				if(r_FreeDataSlot_Int32_Int64 == null)
				{
					r_FreeDataSlot_Int32_Int64 = new(this, "FreeDataSlot", 0, typeof(System.Int32), typeof(System.Int64));
					r_FreeDataSlot_Int32_Int64.SetBelong(this.instance);
				}
				return r_FreeDataSlot_Int32_Int64;
			}
		}

		/// <summary>
		/// Void ValidateSlot(System.LocalDataStoreSlot)
		/// </summary>
		protected RMethod r_ValidateSlot_LocalDataStoreSlot;
		public virtual RMethod RValidateSlot_LocalDataStoreSlot
		{
			get
			{
				if(r_ValidateSlot_LocalDataStoreSlot == null)
				{
					r_ValidateSlot_LocalDataStoreSlot = new(this, "ValidateSlot", 0, typeof(System.LocalDataStoreSlot));
					r_ValidateSlot_LocalDataStoreSlot.SetBelong(this.instance);
				}
				return r_ValidateSlot_LocalDataStoreSlot;
			}
		}

		/// <summary>
		/// Int32 GetSlotTableLength()
		/// </summary>
		protected RMethod r_GetSlotTableLength;
		public virtual RMethod RGetSlotTableLength
		{
			get
			{
				if(r_GetSlotTableLength == null)
				{
					r_GetSlotTableLength = new(this, "GetSlotTableLength", 0);
					r_GetSlotTableLength.SetBelong(this.instance);
				}
				return r_GetSlotTableLength;
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

        public virtual RSystem.RLocalDataStoreHolder CreateLocalDataStore()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateLocalDataStore.Invoke(___genericsType, ___parameters);

            return new RSystem.RLocalDataStoreHolder(___result);
        }


        public virtual void DeleteLocalDataStore(RSystem.RLocalDataStore @store)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@store.Value};
            var ___result = RDeleteLocalDataStore_LocalDataStore.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.LocalDataStoreSlot AllocateDataSlot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAllocateDataSlot.Invoke(___genericsType, ___parameters);

            return (System.LocalDataStoreSlot)___result;
        }


        public virtual System.LocalDataStoreSlot AllocateNamedDataSlot(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RAllocateNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            return (System.LocalDataStoreSlot)___result;
        }


        public virtual System.LocalDataStoreSlot GetNamedDataSlot(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            return (System.LocalDataStoreSlot)___result;
        }


        public virtual void FreeNamedDataSlot(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RFreeNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FreeDataSlot(System.Int32 @slot, System.Int64 @cookie)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slot, @cookie};
            var ___result = RFreeDataSlot_Int32_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ValidateSlot(System.LocalDataStoreSlot @slot)
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


        public virtual System.Boolean Equals(System.Object @obj)
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
