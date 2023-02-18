
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager
{
	/// <summary>
	/// UnityEditor.PackageManager.PackageRegistrationEventArgs
	/// </summary>
    public partial class RPackageRegistrationEventArgs : RMember //
    {

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[UnityEditor.PackageManager.PackageInfo] <added>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> r_F__0__added__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> RF__0__added__1__k__BackingField
		{
			get
			{
				if(r_F__0__added__1__k__BackingField == null)
				{
					r_F__0__added__1__k__BackingField = new(this, "<added>k__BackingField");
					r_F__0__added__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__added__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[UnityEditor.PackageManager.PackageInfo] <removed>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> r_F__0__removed__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> RF__0__removed__1__k__BackingField
		{
			get
			{
				if(r_F__0__removed__1__k__BackingField == null)
				{
					r_F__0__removed__1__k__BackingField = new(this, "<removed>k__BackingField");
					r_F__0__removed__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__removed__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[UnityEditor.PackageManager.PackageInfo] <changedFrom>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> r_F__0__changedFrom__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> RF__0__changedFrom__1__k__BackingField
		{
			get
			{
				if(r_F__0__changedFrom__1__k__BackingField == null)
				{
					r_F__0__changedFrom__1__k__BackingField = new(this, "<changedFrom>k__BackingField");
					r_F__0__changedFrom__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__changedFrom__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[UnityEditor.PackageManager.PackageInfo] <changedTo>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> r_F__0__changedTo__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> RF__0__changedTo__1__k__BackingField
		{
			get
			{
				if(r_F__0__changedTo__1__k__BackingField == null)
				{
					r_F__0__changedTo__1__k__BackingField = new(this, "<changedTo>k__BackingField");
					r_F__0__changedTo__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__changedTo__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[UnityEditor.PackageManager.PackageInfo] added
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> r_Padded;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> RPadded
		{
			get
			{
				if(r_Padded == null)
				{
					r_Padded = new(this, "added", -1);
					r_Padded.SetBelong(this.GetValue());
				}
				return r_Padded;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[UnityEditor.PackageManager.PackageInfo] removed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> r_Premoved;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> RPremoved
		{
			get
			{
				if(r_Premoved == null)
				{
					r_Premoved = new(this, "removed", -1);
					r_Premoved.SetBelong(this.GetValue());
				}
				return r_Premoved;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[UnityEditor.PackageManager.PackageInfo] changedFrom
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> r_PchangedFrom;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> RPchangedFrom
		{
			get
			{
				if(r_PchangedFrom == null)
				{
					r_PchangedFrom = new(this, "changedFrom", -1);
					r_PchangedFrom.SetBelong(this.GetValue());
				}
				return r_PchangedFrom;
			}
		}

		/// <summary>
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[UnityEditor.PackageManager.PackageInfo] changedTo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> r_PchangedTo;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RPackageInfo> RPchangedTo
		{
			get
			{
				if(r_PchangedTo == null)
				{
					r_PchangedTo = new(this, "changedTo", -1);
					r_PchangedTo.SetBelong(this.GetValue());
				}
				return r_PchangedTo;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageInfo[] Internal_GetAddedPackages(IntPtr)
		/// </summary>
		protected static RMethod r_MInternal_GetAddedPackages_IntPtr;
		public static RMethod RMInternal_GetAddedPackages_IntPtr
		{
			get
			{
				if(r_MInternal_GetAddedPackages_IntPtr == null)
				{
					r_MInternal_GetAddedPackages_IntPtr = new(typeof(UnityEditor.PackageManager.PackageRegistrationEventArgs), "Internal_GetAddedPackages", 0, typeof(System.IntPtr));
					r_MInternal_GetAddedPackages_IntPtr.SetBelong(null);
				}
				return r_MInternal_GetAddedPackages_IntPtr;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageInfo[] Internal_GetRemovedPackages(IntPtr)
		/// </summary>
		protected static RMethod r_MInternal_GetRemovedPackages_IntPtr;
		public static RMethod RMInternal_GetRemovedPackages_IntPtr
		{
			get
			{
				if(r_MInternal_GetRemovedPackages_IntPtr == null)
				{
					r_MInternal_GetRemovedPackages_IntPtr = new(typeof(UnityEditor.PackageManager.PackageRegistrationEventArgs), "Internal_GetRemovedPackages", 0, typeof(System.IntPtr));
					r_MInternal_GetRemovedPackages_IntPtr.SetBelong(null);
				}
				return r_MInternal_GetRemovedPackages_IntPtr;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageInfo[] Internal_GetChangedFromPackages(IntPtr)
		/// </summary>
		protected static RMethod r_MInternal_GetChangedFromPackages_IntPtr;
		public static RMethod RMInternal_GetChangedFromPackages_IntPtr
		{
			get
			{
				if(r_MInternal_GetChangedFromPackages_IntPtr == null)
				{
					r_MInternal_GetChangedFromPackages_IntPtr = new(typeof(UnityEditor.PackageManager.PackageRegistrationEventArgs), "Internal_GetChangedFromPackages", 0, typeof(System.IntPtr));
					r_MInternal_GetChangedFromPackages_IntPtr.SetBelong(null);
				}
				return r_MInternal_GetChangedFromPackages_IntPtr;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageInfo[] Internal_GetChangedToPackages(IntPtr)
		/// </summary>
		protected static RMethod r_MInternal_GetChangedToPackages_IntPtr;
		public static RMethod RMInternal_GetChangedToPackages_IntPtr
		{
			get
			{
				if(r_MInternal_GetChangedToPackages_IntPtr == null)
				{
					r_MInternal_GetChangedToPackages_IntPtr = new(typeof(UnityEditor.PackageManager.PackageRegistrationEventArgs), "Internal_GetChangedToPackages", 0, typeof(System.IntPtr));
					r_MInternal_GetChangedToPackages_IntPtr.SetBelong(null);
				}
				return r_MInternal_GetChangedToPackages_IntPtr;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.PackageRegistrationEventArgs InstantiateFromNative(IntPtr)
		/// </summary>
		protected static RMethod r_MInstantiateFromNative_IntPtr;
		public static RMethod RMInstantiateFromNative_IntPtr
		{
			get
			{
				if(r_MInstantiateFromNative_IntPtr == null)
				{
					r_MInstantiateFromNative_IntPtr = new(typeof(UnityEditor.PackageManager.PackageRegistrationEventArgs), "InstantiateFromNative", 0, typeof(System.IntPtr));
					r_MInstantiateFromNative_IntPtr.SetBelong(null);
				}
				return r_MInstantiateFromNative_IntPtr;
			}
		}

		/// <summary>
		/// Void PopulateFromNative(IntPtr)
		/// </summary>
		protected RMethod r_MPopulateFromNative_IntPtr;
		public virtual RMethod RMPopulateFromNative_IntPtr
		{
			get
			{
				if(r_MPopulateFromNative_IntPtr == null)
				{
					r_MPopulateFromNative_IntPtr = new(this, "PopulateFromNative", 0, typeof(System.IntPtr));
					r_MPopulateFromNative_IntPtr.SetBelong(this.GetValue());
				}
				return r_MPopulateFromNative_IntPtr;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
			}
		}


        public RPackageRegistrationEventArgs() : base("UnityEditor.PackageManager.PackageRegistrationEventArgs")
        {
        }

        public RPackageRegistrationEventArgs(System.Object instance) : base("UnityEditor.PackageManager.PackageRegistrationEventArgs")
		{
            SetInstance(instance);
		}

        public RPackageRegistrationEventArgs(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPackageRegistrationEventArgs(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEditor.PackageManager.PackageInfo[] Internal_GetAddedPackages(System.IntPtr @nativeHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nativeHandle};
            var ___result = RMInternal_GetAddedPackages_IntPtr.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageManager.PackageInfo[])___result;
        }


        public static UnityEditor.PackageManager.PackageInfo[] Internal_GetRemovedPackages(System.IntPtr @nativeHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nativeHandle};
            var ___result = RMInternal_GetRemovedPackages_IntPtr.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageManager.PackageInfo[])___result;
        }


        public static UnityEditor.PackageManager.PackageInfo[] Internal_GetChangedFromPackages(System.IntPtr @nativeHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nativeHandle};
            var ___result = RMInternal_GetChangedFromPackages_IntPtr.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageManager.PackageInfo[])___result;
        }


        public static UnityEditor.PackageManager.PackageInfo[] Internal_GetChangedToPackages(System.IntPtr @nativeHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nativeHandle};
            var ___result = RMInternal_GetChangedToPackages_IntPtr.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageManager.PackageInfo[])___result;
        }


        public static UnityEditor.PackageManager.PackageRegistrationEventArgs InstantiateFromNative(System.IntPtr @nativeHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nativeHandle};
            var ___result = RMInstantiateFromNative_IntPtr.Invoke(___genericsType, ___parameters);

            return (UnityEditor.PackageManager.PackageRegistrationEventArgs)___result;
        }


        public virtual void PopulateFromNative(System.IntPtr @nativeHandle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nativeHandle};
            var ___result = RMPopulateFromNative_IntPtr.Invoke(___genericsType, ___parameters);

            
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
