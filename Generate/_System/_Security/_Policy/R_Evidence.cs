
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Security.Policy.Evidence
	/// </summary>
    public partial class REvidence : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Security.Policy.Evidence);
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


		/// <summary>
		/// System.Boolean _locked
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_locked;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_locked
		{
			get
			{
				if(r_F_locked == null)
				{
					r_F_locked = new(this, "_locked");
				}
				return r_F_locked;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList hostEvidenceList
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList r_FhostEvidenceList;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList RFhostEvidenceList
		{
			get
			{
				if(r_FhostEvidenceList == null)
				{
					r_FhostEvidenceList = new(this, "hostEvidenceList");
				}
				return r_FhostEvidenceList;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList assemblyEvidenceList
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList r_FassemblyEvidenceList;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList RFassemblyEvidenceList
		{
			get
			{
				if(r_FassemblyEvidenceList == null)
				{
					r_FassemblyEvidenceList = new(this, "assemblyEvidenceList");
				}
				return r_FassemblyEvidenceList;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPCount
		{
			get
			{
				if(r_PCount == null)
				{
					r_PCount = new(this, "Count", -1);
				}
				return r_PCount;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsReadOnly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsReadOnly
		{
			get
			{
				if(r_PIsReadOnly == null)
				{
					r_PIsReadOnly = new(this, "IsReadOnly", -1);
				}
				return r_PIsReadOnly;
			}
		}

		/// <summary>
		/// Boolean IsSynchronized
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSynchronized;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSynchronized
		{
			get
			{
				if(r_PIsSynchronized == null)
				{
					r_PIsSynchronized = new(this, "IsSynchronized", -1);
				}
				return r_PIsSynchronized;
			}
		}

		/// <summary>
		/// Boolean Locked
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PLocked;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPLocked
		{
			get
			{
				if(r_PLocked == null)
				{
					r_PLocked = new(this, "Locked", -1);
				}
				return r_PLocked;
			}
		}

		/// <summary>
		/// System.Object SyncRoot
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PSyncRoot;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPSyncRoot
		{
			get
			{
				if(r_PSyncRoot == null)
				{
					r_PSyncRoot = new(this, "SyncRoot", -1);
				}
				return r_PSyncRoot;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList HostEvidenceList
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList r_PHostEvidenceList;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList RPHostEvidenceList
		{
			get
			{
				if(r_PHostEvidenceList == null)
				{
					r_PHostEvidenceList = new(this, "HostEvidenceList", -1);
				}
				return r_PHostEvidenceList;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList AssemblyEvidenceList
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList r_PAssemblyEvidenceList;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList RPAssemblyEvidenceList
		{
			get
			{
				if(r_PAssemblyEvidenceList == null)
				{
					r_PAssemblyEvidenceList = new(this, "AssemblyEvidenceList", -1);
				}
				return r_PAssemblyEvidenceList;
			}
		}

		/// <summary>
		/// Void AddAssembly(System.Object)
		/// </summary>
		protected RMethod r_MAddAssembly_Object;
		public virtual RMethod RMAddAssembly_Object
		{
			get
			{
				if(r_MAddAssembly_Object == null)
				{
					r_MAddAssembly_Object = new(this, "AddAssembly", 0, typeof(System.Object));
				}
				return r_MAddAssembly_Object;
			}
		}

		/// <summary>
		/// Void AddHost(System.Object)
		/// </summary>
		protected RMethod r_MAddHost_Object;
		public virtual RMethod RMAddHost_Object
		{
			get
			{
				if(r_MAddHost_Object == null)
				{
					r_MAddHost_Object = new(this, "AddHost", 0, typeof(System.Object));
				}
				return r_MAddHost_Object;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_MClear;
		public virtual RMethod RMClear
		{
			get
			{
				if(r_MClear == null)
				{
					r_MClear = new(this, "Clear", 0);
				}
				return r_MClear;
			}
		}

		/// <summary>
		/// System.Security.Policy.Evidence Clone()
		/// </summary>
		protected RMethod r_MClone;
		public virtual RMethod RMClone
		{
			get
			{
				if(r_MClone == null)
				{
					r_MClone = new(this, "Clone", 0);
				}
				return r_MClone;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Array, Int32)
		/// </summary>
		protected RMethod r_MCopyTo_Array_Int32;
		public virtual RMethod RMCopyTo_Array_Int32
		{
			get
			{
				if(r_MCopyTo_Array_Int32 == null)
				{
					r_MCopyTo_Array_Int32 = new(this, "CopyTo", 0, typeof(System.Array), typeof(System.Int32));
				}
				return r_MCopyTo_Array_Int32;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_MGetEnumerator;
		public virtual RMethod RMGetEnumerator
		{
			get
			{
				if(r_MGetEnumerator == null)
				{
					r_MGetEnumerator = new(this, "GetEnumerator", 0);
				}
				return r_MGetEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetAssemblyEnumerator()
		/// </summary>
		protected RMethod r_MGetAssemblyEnumerator;
		public virtual RMethod RMGetAssemblyEnumerator
		{
			get
			{
				if(r_MGetAssemblyEnumerator == null)
				{
					r_MGetAssemblyEnumerator = new(this, "GetAssemblyEnumerator", 0);
				}
				return r_MGetAssemblyEnumerator;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetHostEnumerator()
		/// </summary>
		protected RMethod r_MGetHostEnumerator;
		public virtual RMethod RMGetHostEnumerator
		{
			get
			{
				if(r_MGetHostEnumerator == null)
				{
					r_MGetHostEnumerator = new(this, "GetHostEnumerator", 0);
				}
				return r_MGetHostEnumerator;
			}
		}

		/// <summary>
		/// Void Merge(System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_MMerge_Evidence;
		public virtual RMethod RMMerge_Evidence
		{
			get
			{
				if(r_MMerge_Evidence == null)
				{
					r_MMerge_Evidence = new(this, "Merge", 0, typeof(System.Security.Policy.Evidence));
				}
				return r_MMerge_Evidence;
			}
		}

		/// <summary>
		/// Void RemoveType(System.Type)
		/// </summary>
		protected RMethod r_MRemoveType_Type;
		public virtual RMethod RMRemoveType_Type
		{
			get
			{
				if(r_MRemoveType_Type == null)
				{
					r_MRemoveType_Type = new(this, "RemoveType", 0, typeof(System.Type));
				}
				return r_MRemoveType_Type;
			}
		}

		/// <summary>
		/// Boolean IsAuthenticodePresent(System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_MIsAuthenticodePresent_Assembly;
		public static RMethod RMIsAuthenticodePresent_Assembly
		{
			get
			{
				if(r_MIsAuthenticodePresent_Assembly == null)
				{
					r_MIsAuthenticodePresent_Assembly = new(Type, "IsAuthenticodePresent", 0, typeof(System.Reflection.Assembly));
				}
				return r_MIsAuthenticodePresent_Assembly;
			}
		}

		/// <summary>
		/// System.Security.Policy.Evidence GetDefaultHostEvidence(System.Reflection.Assembly)
		/// </summary>
		protected static RMethod r_MGetDefaultHostEvidence_Assembly;
		public static RMethod RMGetDefaultHostEvidence_Assembly
		{
			get
			{
				if(r_MGetDefaultHostEvidence_Assembly == null)
				{
					r_MGetDefaultHostEvidence_Assembly = new(Type, "GetDefaultHostEvidence", 0, typeof(System.Reflection.Assembly));
				}
				return r_MGetDefaultHostEvidence_Assembly;
			}
		}

		/// <summary>
		/// Void AddAssemblyEvidence[T](T)
		/// </summary>
		protected RMethod r_MAddAssemblyEvidence_GT_T;
		public virtual RMethod RMAddAssemblyEvidence_GT_T
		{
			get
			{
				if(r_MAddAssemblyEvidence_GT_T == null)
				{
					r_MAddAssemblyEvidence_GT_T = new(this, "AddAssemblyEvidence", 1, Type.MakeGenericMethodParameter(0));
				}
				return r_MAddAssemblyEvidence_GT_T;
			}
		}

		/// <summary>
		/// Void AddHostEvidence[T](T)
		/// </summary>
		protected RMethod r_MAddHostEvidence_GT_T;
		public virtual RMethod RMAddHostEvidence_GT_T
		{
			get
			{
				if(r_MAddHostEvidence_GT_T == null)
				{
					r_MAddHostEvidence_GT_T = new(this, "AddHostEvidence", 1, Type.MakeGenericMethodParameter(0));
				}
				return r_MAddHostEvidence_GT_T;
			}
		}

		/// <summary>
		/// T GetAssemblyEvidence[T]()
		/// </summary>
		protected RMethod r_MGetAssemblyEvidence_GT;
		public virtual RMethod RMGetAssemblyEvidence_GT
		{
			get
			{
				if(r_MGetAssemblyEvidence_GT == null)
				{
					r_MGetAssemblyEvidence_GT = new(this, "GetAssemblyEvidence", 1);
				}
				return r_MGetAssemblyEvidence_GT;
			}
		}

		/// <summary>
		/// T GetHostEvidence[T]()
		/// </summary>
		protected RMethod r_MGetHostEvidence_GT;
		public virtual RMethod RMGetHostEvidence_GT
		{
			get
			{
				if(r_MGetHostEvidence_GT == null)
				{
					r_MGetHostEvidence_GT = new(this, "GetHostEvidence", 1);
				}
				return r_MGetHostEvidence_GT;
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


        public virtual void AddAssembly(System.Object @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RMAddAssembly_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddHost(System.Object @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RMAddHost_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.Policy.Evidence Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Security.Policy.Evidence>(___result);
        }


        public virtual void CopyTo(System.Array @array, System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RMCopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.IEnumerator>(___result);
        }


        public virtual System.Collections.IEnumerator GetAssemblyEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAssemblyEnumerator.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.IEnumerator>(___result);
        }


        public virtual System.Collections.IEnumerator GetHostEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHostEnumerator.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.IEnumerator>(___result);
        }


        public virtual void Merge(System.Security.Policy.Evidence @evidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evidence};
            var ___result = RMMerge_Evidence.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveType(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMRemoveType_Type.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsAuthenticodePresent(System.Reflection.Assembly @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMIsAuthenticodePresent_Assembly.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Security.Policy.Evidence GetDefaultHostEvidence(System.Reflection.Assembly @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMGetDefaultHostEvidence_Assembly.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Security.Policy.Evidence>(___result);
        }


        public virtual void AddAssemblyEvidence<T>(T @evidence)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@evidence};
            var ___result = RMAddAssemblyEvidence_GT_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddHostEvidence<T>(T @evidence)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@evidence};
            var ___result = RMAddHostEvidence_GT_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T GetAssemblyEvidence<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetAssemblyEvidence_GT.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual T GetHostEvidence<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetHostEvidence_GT.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
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
