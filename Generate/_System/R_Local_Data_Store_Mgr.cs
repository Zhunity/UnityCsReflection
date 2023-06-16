
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.LocalDataStoreMgr
	/// </summary>
    public partial class RLocalDataStoreMgr : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.LocalDataStoreMgr");
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


		/// <summary>
		/// System.Int32 InitialSlotTableSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FInitialSlotTableSize;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFInitialSlotTableSize
		{
			get
			{
				if(r_FInitialSlotTableSize == null)
				{
					r_FInitialSlotTableSize = new(Type, "InitialSlotTableSize");
				}
				return r_FInitialSlotTableSize;
			}
		}

		/// <summary>
		/// System.Int32 SlotTableDoubleThreshold
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FSlotTableDoubleThreshold;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFSlotTableDoubleThreshold
		{
			get
			{
				if(r_FSlotTableDoubleThreshold == null)
				{
					r_FSlotTableDoubleThreshold = new(Type, "SlotTableDoubleThreshold");
				}
				return r_FSlotTableDoubleThreshold;
			}
		}

		/// <summary>
		/// System.Int32 LargeSlotTableSizeIncrease
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FLargeSlotTableSizeIncrease;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFLargeSlotTableSizeIncrease
		{
			get
			{
				if(r_FLargeSlotTableSizeIncrease == null)
				{
					r_FLargeSlotTableSizeIncrease = new(Type, "LargeSlotTableSizeIncrease");
				}
				return r_FLargeSlotTableSizeIncrease;
			}
		}

		/// <summary>
		/// System.Boolean[] m_SlotInfoTable
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RBoolean> r_Fm_SlotInfoTable;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RBoolean> RFm_SlotInfoTable
		{
			get
			{
				if(r_Fm_SlotInfoTable == null)
				{
					r_Fm_SlotInfoTable = new(this, "m_SlotInfoTable");
				}
				return r_Fm_SlotInfoTable;
			}
		}

		/// <summary>
		/// System.Int32 m_FirstAvailableSlot
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_FirstAvailableSlot;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_FirstAvailableSlot
		{
			get
			{
				if(r_Fm_FirstAvailableSlot == null)
				{
					r_Fm_FirstAvailableSlot = new(this, "m_FirstAvailableSlot");
				}
				return r_Fm_FirstAvailableSlot;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.LocalDataStore] m_ManagedLocalDataStores
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RLocalDataStore> r_Fm_ManagedLocalDataStores;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RLocalDataStore> RFm_ManagedLocalDataStores
		{
			get
			{
				if(r_Fm_ManagedLocalDataStores == null)
				{
					r_Fm_ManagedLocalDataStores = new(this, "m_ManagedLocalDataStores");
				}
				return r_Fm_ManagedLocalDataStores;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.LocalDataStoreSlot] m_KeyToSlotMap
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RLocalDataStoreSlot> r_Fm_KeyToSlotMap;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RLocalDataStoreSlot> RFm_KeyToSlotMap
		{
			get
			{
				if(r_Fm_KeyToSlotMap == null)
				{
					r_Fm_KeyToSlotMap = new(this, "m_KeyToSlotMap");
				}
				return r_Fm_KeyToSlotMap;
			}
		}

		/// <summary>
		/// System.Int64 m_CookieGenerator
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Fm_CookieGenerator;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFm_CookieGenerator
		{
			get
			{
				if(r_Fm_CookieGenerator == null)
				{
					r_Fm_CookieGenerator = new(this, "m_CookieGenerator");
				}
				return r_Fm_CookieGenerator;
			}
		}

		/// <summary>
		/// System.LocalDataStoreHolder CreateLocalDataStore()
		/// </summary>
		protected RMethod r_MCreateLocalDataStore;
		public virtual RMethod RMCreateLocalDataStore
		{
			get
			{
				if(r_MCreateLocalDataStore == null)
				{
					r_MCreateLocalDataStore = new(this, "CreateLocalDataStore", 0);
				}
				return r_MCreateLocalDataStore;
			}
		}

		/// <summary>
		/// Void DeleteLocalDataStore(System.LocalDataStore)
		/// </summary>
		protected RMethod r_MDeleteLocalDataStore_LocalDataStore;
		public virtual RMethod RMDeleteLocalDataStore_LocalDataStore
		{
			get
			{
				if(r_MDeleteLocalDataStore_LocalDataStore == null)
				{
					r_MDeleteLocalDataStore_LocalDataStore = new(this, "DeleteLocalDataStore", 0,  ReflectionUtils.GetType("System.LocalDataStore"));
				}
				return r_MDeleteLocalDataStore_LocalDataStore;
			}
		}

		/// <summary>
		/// System.LocalDataStoreSlot AllocateDataSlot()
		/// </summary>
		protected RMethod r_MAllocateDataSlot;
		public virtual RMethod RMAllocateDataSlot
		{
			get
			{
				if(r_MAllocateDataSlot == null)
				{
					r_MAllocateDataSlot = new(this, "AllocateDataSlot", 0);
				}
				return r_MAllocateDataSlot;
			}
		}

		/// <summary>
		/// System.LocalDataStoreSlot AllocateNamedDataSlot(System.String)
		/// </summary>
		protected RMethod r_MAllocateNamedDataSlot_String;
		public virtual RMethod RMAllocateNamedDataSlot_String
		{
			get
			{
				if(r_MAllocateNamedDataSlot_String == null)
				{
					r_MAllocateNamedDataSlot_String = new(this, "AllocateNamedDataSlot", 0, typeof(System.String));
				}
				return r_MAllocateNamedDataSlot_String;
			}
		}

		/// <summary>
		/// System.LocalDataStoreSlot GetNamedDataSlot(System.String)
		/// </summary>
		protected RMethod r_MGetNamedDataSlot_String;
		public virtual RMethod RMGetNamedDataSlot_String
		{
			get
			{
				if(r_MGetNamedDataSlot_String == null)
				{
					r_MGetNamedDataSlot_String = new(this, "GetNamedDataSlot", 0, typeof(System.String));
				}
				return r_MGetNamedDataSlot_String;
			}
		}

		/// <summary>
		/// Void FreeNamedDataSlot(System.String)
		/// </summary>
		protected RMethod r_MFreeNamedDataSlot_String;
		public virtual RMethod RMFreeNamedDataSlot_String
		{
			get
			{
				if(r_MFreeNamedDataSlot_String == null)
				{
					r_MFreeNamedDataSlot_String = new(this, "FreeNamedDataSlot", 0, typeof(System.String));
				}
				return r_MFreeNamedDataSlot_String;
			}
		}

		/// <summary>
		/// Void FreeDataSlot(Int32, Int64)
		/// </summary>
		protected RMethod r_MFreeDataSlot_Int32_Int64;
		public virtual RMethod RMFreeDataSlot_Int32_Int64
		{
			get
			{
				if(r_MFreeDataSlot_Int32_Int64 == null)
				{
					r_MFreeDataSlot_Int32_Int64 = new(this, "FreeDataSlot", 0, typeof(System.Int32), typeof(System.Int64));
				}
				return r_MFreeDataSlot_Int32_Int64;
			}
		}

		/// <summary>
		/// Void ValidateSlot(System.LocalDataStoreSlot)
		/// </summary>
		protected RMethod r_MValidateSlot_LocalDataStoreSlot;
		public virtual RMethod RMValidateSlot_LocalDataStoreSlot
		{
			get
			{
				if(r_MValidateSlot_LocalDataStoreSlot == null)
				{
					r_MValidateSlot_LocalDataStoreSlot = new(this, "ValidateSlot", 0, typeof(System.LocalDataStoreSlot));
				}
				return r_MValidateSlot_LocalDataStoreSlot;
			}
		}

		/// <summary>
		/// Int32 GetSlotTableLength()
		/// </summary>
		protected RMethod r_MGetSlotTableLength;
		public virtual RMethod RMGetSlotTableLength
		{
			get
			{
				if(r_MGetSlotTableLength == null)
				{
					r_MGetSlotTableLength = new(this, "GetSlotTableLength", 0);
				}
				return r_MGetSlotTableLength;
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


        public virtual Hvak.Editor.Refleaction.RSystem.RLocalDataStoreHolder CreateLocalDataStore()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateLocalDataStore.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RLocalDataStoreHolder>(___result);
        }


        public virtual void DeleteLocalDataStore(Hvak.Editor.Refleaction.RSystem.RLocalDataStore @store)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@store.Value};
            var ___result = RMDeleteLocalDataStore_LocalDataStore.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.LocalDataStoreSlot AllocateDataSlot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAllocateDataSlot.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.LocalDataStoreSlot>(___result);
        }


        public virtual System.LocalDataStoreSlot AllocateNamedDataSlot(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMAllocateNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.LocalDataStoreSlot>(___result);
        }


        public virtual System.LocalDataStoreSlot GetNamedDataSlot(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.LocalDataStoreSlot>(___result);
        }


        public virtual void FreeNamedDataSlot(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMFreeNamedDataSlot_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FreeDataSlot(System.Int32 @slot, System.Int64 @cookie)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slot, @cookie};
            var ___result = RMFreeDataSlot_Int32_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ValidateSlot(System.LocalDataStoreSlot @slot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slot};
            var ___result = RMValidateSlot_LocalDataStoreSlot.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetSlotTableLength()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSlotTableLength.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
