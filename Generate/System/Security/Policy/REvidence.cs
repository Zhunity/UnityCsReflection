using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RPolicy
{
	/// <summary>
	/// System.Security.Policy.Evidence
	/// </summary>
    public partial class REvidence : RMember //
    {

		/// <summary>
		/// System.Boolean _locked
		/// </summary>
		protected RField r__locked;
		public virtual RField R_locked
		{
			get
			{
				if(r__locked == null)
				{
					r__locked = new(this, "_locked");
					r__locked.SetBelong(this.instance);
				}
				return r__locked;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList hostEvidenceList
		/// </summary>
		protected RSystem.RCollections.RArrayList r_hostEvidenceList;
		public virtual RSystem.RCollections.RArrayList RhostEvidenceList
		{
			get
			{
				if(r_hostEvidenceList == null)
				{
					r_hostEvidenceList = new(this, "hostEvidenceList");
					r_hostEvidenceList.SetBelong(this.instance);
				}
				return r_hostEvidenceList;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList assemblyEvidenceList
		/// </summary>
		protected RSystem.RCollections.RArrayList r_assemblyEvidenceList;
		public virtual RSystem.RCollections.RArrayList RassemblyEvidenceList
		{
			get
			{
				if(r_assemblyEvidenceList == null)
				{
					r_assemblyEvidenceList = new(this, "assemblyEvidenceList");
					r_assemblyEvidenceList.SetBelong(this.instance);
				}
				return r_assemblyEvidenceList;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected RProperty r_Count;
		public virtual RProperty RCount
		{
			get
			{
				if(r_Count == null)
				{
					r_Count = new(this, "Count", -1);
					r_Count.SetBelong(this.instance);
				}
				return r_Count;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected RProperty r_IsReadOnly;
		public virtual RProperty RIsReadOnly
		{
			get
			{
				if(r_IsReadOnly == null)
				{
					r_IsReadOnly = new(this, "IsReadOnly", -1);
					r_IsReadOnly.SetBelong(this.instance);
				}
				return r_IsReadOnly;
			}
		}

		/// <summary>
		/// Boolean IsSynchronized
		/// </summary>
		protected RProperty r_IsSynchronized;
		public virtual RProperty RIsSynchronized
		{
			get
			{
				if(r_IsSynchronized == null)
				{
					r_IsSynchronized = new(this, "IsSynchronized", -1);
					r_IsSynchronized.SetBelong(this.instance);
				}
				return r_IsSynchronized;
			}
		}

		/// <summary>
		/// Boolean Locked
		/// </summary>
		protected RProperty r_Locked;
		public virtual RProperty RLocked
		{
			get
			{
				if(r_Locked == null)
				{
					r_Locked = new(this, "Locked", -1);
					r_Locked.SetBelong(this.instance);
				}
				return r_Locked;
			}
		}

		/// <summary>
		/// System.Object SyncRoot
		/// </summary>
		protected RSystem.RObject r_SyncRoot;
		public virtual RSystem.RObject RSyncRoot
		{
			get
			{
				if(r_SyncRoot == null)
				{
					r_SyncRoot = new(this, "SyncRoot", -1);
					r_SyncRoot.SetBelong(this.instance);
				}
				return r_SyncRoot;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList HostEvidenceList
		/// </summary>
		protected RSystem.RCollections.RArrayList r_HostEvidenceList;
		public virtual RSystem.RCollections.RArrayList RHostEvidenceList
		{
			get
			{
				if(r_HostEvidenceList == null)
				{
					r_HostEvidenceList = new(this, "HostEvidenceList", -1);
					r_HostEvidenceList.SetBelong(this.instance);
				}
				return r_HostEvidenceList;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList AssemblyEvidenceList
		/// </summary>
		protected RSystem.RCollections.RArrayList r_AssemblyEvidenceList;
		public virtual RSystem.RCollections.RArrayList RAssemblyEvidenceList
		{
			get
			{
				if(r_AssemblyEvidenceList == null)
				{
					r_AssemblyEvidenceList = new(this, "AssemblyEvidenceList", -1);
					r_AssemblyEvidenceList.SetBelong(this.instance);
				}
				return r_AssemblyEvidenceList;
			}
		}

		/// <summary>
		/// Void AddAssembly(System.Object)
		/// </summary>
		protected RMethod r_RAddAssembly_Object;
		public virtual RMethod RAddAssembly_Object
		{
			get
			{
				if(r_RAddAssembly_Object == null)
				{
					r_RAddAssembly_Object = new(this, "AddAssembly", 0, typeof(System.Object));
					r_RAddAssembly_Object.SetBelong(this.instance);
				}
				return r_RAddAssembly_Object;
			}
		}

		/// <summary>
		/// Void AddHost(System.Object)
		/// </summary>
		protected RMethod r_RAddHost_Object;
		public virtual RMethod RAddHost_Object
		{
			get
			{
				if(r_RAddHost_Object == null)
				{
					r_RAddHost_Object = new(this, "AddHost", 0, typeof(System.Object));
					r_RAddHost_Object.SetBelong(this.instance);
				}
				return r_RAddHost_Object;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
			}
		}

		/// <summary>
		/// System.Security.Policy.Evidence Clone()
		/// </summary>
		protected RMethod r_RClone;
		public virtual RMethod RClone
		{
			get
			{
				if(r_RClone == null)
				{
					r_RClone = new(this, "Clone", 0);
					r_RClone.SetBelong(this.instance);
				}
				return r_RClone;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Array, Int32)
		/// </summary>
		protected RMethod r_RCopyTo_Array_Int32;
		public virtual RMethod RCopyTo_Array_Int32
		{
			get
			{
				if(r_RCopyTo_Array_Int32 == null)
				{
					r_RCopyTo_Array_Int32 = new(this, "CopyTo", 0, typeof(System.Array), typeof(System.Int32));
					r_RCopyTo_Array_Int32.SetBelong(this.instance);
				}
				return r_RCopyTo_Array_Int32;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_RGetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_RGetEnumerator == null)
				{
					r_RGetEnumerator = new(this, "GetEnumerator", 0);
					r_RGetEnumerator.SetBelong(this.instance);
				}
				return r_RGetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetAssemblyEnumerator()
		/// </summary>
		protected RMethod r_RGetAssemblyEnumerator;
		public virtual RMethod RGetAssemblyEnumerator
		{
			get
			{
				if(r_RGetAssemblyEnumerator == null)
				{
					r_RGetAssemblyEnumerator = new(this, "GetAssemblyEnumerator", 0);
					r_RGetAssemblyEnumerator.SetBelong(this.instance);
				}
				return r_RGetAssemblyEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetHostEnumerator()
		/// </summary>
		protected RMethod r_RGetHostEnumerator;
		public virtual RMethod RGetHostEnumerator
		{
			get
			{
				if(r_RGetHostEnumerator == null)
				{
					r_RGetHostEnumerator = new(this, "GetHostEnumerator", 0);
					r_RGetHostEnumerator.SetBelong(this.instance);
				}
				return r_RGetHostEnumerator;
			}
		}

		/// <summary>
		/// Void Merge(System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_RMerge_Evidence;
		public virtual RMethod RMerge_Evidence
		{
			get
			{
				if(r_RMerge_Evidence == null)
				{
					r_RMerge_Evidence = new(this, "Merge", 0, typeof(System.Security.Policy.Evidence));
					r_RMerge_Evidence.SetBelong(this.instance);
				}
				return r_RMerge_Evidence;
			}
		}

		/// <summary>
		/// Void RemoveType(System.Type)
		/// </summary>
		protected RMethod r_RRemoveType_Type;
		public virtual RMethod RRemoveType_Type
		{
			get
			{
				if(r_RRemoveType_Type == null)
				{
					r_RRemoveType_Type = new(this, "RemoveType", 0, typeof(System.Type));
					r_RRemoveType_Type.SetBelong(this.instance);
				}
				return r_RRemoveType_Type;
			}
		}

		/// <summary>
		/// Boolean IsAuthenticodePresent(System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_RIsAuthenticodePresent_Assembly;
		public static RMethod RIsAuthenticodePresent_Assembly
		{
			get
			{
				if(r_RIsAuthenticodePresent_Assembly == null)
				{
					r_RIsAuthenticodePresent_Assembly = new(typeof(System.Security.Policy.Evidence), "IsAuthenticodePresent", 0, typeof(System.Reflection.Assembly));
					r_RIsAuthenticodePresent_Assembly.SetBelong(null);
				}
				return r_RIsAuthenticodePresent_Assembly;
			}
		}

		/// <summary>
		/// System.Security.Policy.Evidence GetDefaultHostEvidence(System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_RGetDefaultHostEvidence_Assembly;
		public static RMethod RGetDefaultHostEvidence_Assembly
		{
			get
			{
				if(r_RGetDefaultHostEvidence_Assembly == null)
				{
					r_RGetDefaultHostEvidence_Assembly = new(typeof(System.Security.Policy.Evidence), "GetDefaultHostEvidence", 0, typeof(System.Reflection.Assembly));
					r_RGetDefaultHostEvidence_Assembly.SetBelong(null);
				}
				return r_RGetDefaultHostEvidence_Assembly;
			}
		}

		/// <summary>
		/// Void AddAssemblyEvidence[T](T)
		/// </summary>
		protected RMethod r_RAddAssemblyEvidence_GT_T;
		public virtual RMethod RAddAssemblyEvidence_GT_T
		{
			get
			{
				if(r_RAddAssemblyEvidence_GT_T == null)
				{
					r_RAddAssemblyEvidence_GT_T = new(this, "AddAssemblyEvidence", 1, Type.MakeGenericMethodParameter(0));
					r_RAddAssemblyEvidence_GT_T.SetBelong(this.instance);
				}
				return r_RAddAssemblyEvidence_GT_T;
			}
		}

		/// <summary>
		/// Void AddHostEvidence[T](T)
		/// </summary>
		protected RMethod r_RAddHostEvidence_GT_T;
		public virtual RMethod RAddHostEvidence_GT_T
		{
			get
			{
				if(r_RAddHostEvidence_GT_T == null)
				{
					r_RAddHostEvidence_GT_T = new(this, "AddHostEvidence", 1, Type.MakeGenericMethodParameter(0));
					r_RAddHostEvidence_GT_T.SetBelong(this.instance);
				}
				return r_RAddHostEvidence_GT_T;
			}
		}

		/// <summary>
		/// T GetAssemblyEvidence[T]()
		/// </summary>
		protected RMethod r_RGetAssemblyEvidence_GT;
		public virtual RMethod RGetAssemblyEvidence_GT
		{
			get
			{
				if(r_RGetAssemblyEvidence_GT == null)
				{
					r_RGetAssemblyEvidence_GT = new(this, "GetAssemblyEvidence", 1);
					r_RGetAssemblyEvidence_GT.SetBelong(this.instance);
				}
				return r_RGetAssemblyEvidence_GT;
			}
		}

		/// <summary>
		/// T GetHostEvidence[T]()
		/// </summary>
		protected RMethod r_RGetHostEvidence_GT;
		public virtual RMethod RGetHostEvidence_GT
		{
			get
			{
				if(r_RGetHostEvidence_GT == null)
				{
					r_RGetHostEvidence_GT = new(this, "GetHostEvidence", 1);
					r_RGetHostEvidence_GT.SetBelong(this.instance);
				}
				return r_RGetHostEvidence_GT;
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


        public REvidence() : base("System.Security.Policy.Evidence")
        {
        }

        public REvidence(System.Object instance) : base("System.Security.Policy.Evidence")
		{
            SetInstance(instance);
		}

        public REvidence(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REvidence(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AddAssembly(System.Object  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RAddAssembly_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddHost(System.Object  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RAddHost_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.Policy.Evidence Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.Evidence)___result;
        }


        public virtual void CopyTo(System.Array  @array, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Collections.IEnumerator GetAssemblyEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAssemblyEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Collections.IEnumerator GetHostEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHostEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void Merge(System.Security.Policy.Evidence  @evidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evidence};
            var ___result = RMerge_Evidence.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveType(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RRemoveType_Type.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsAuthenticodePresent(System.Reflection.Assembly  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RIsAuthenticodePresent_Assembly.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Security.Policy.Evidence GetDefaultHostEvidence(System.Reflection.Assembly  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RGetDefaultHostEvidence_Assembly.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.Evidence)___result;
        }


        public virtual void AddAssemblyEvidence<T>(T  @evidence)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@evidence};
            var ___result = RAddAssemblyEvidence_GT_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddHostEvidence<T>(T  @evidence)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@evidence};
            var ___result = RAddHostEvidence_GT_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T GetAssemblyEvidence<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetAssemblyEvidence_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetHostEvidence<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetHostEvidence_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
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
