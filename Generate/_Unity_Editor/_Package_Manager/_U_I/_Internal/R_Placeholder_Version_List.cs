
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.Internal.PlaceholderVersionList
	/// </summary>
    public partial class RPlaceholderVersionList : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PlaceholderVersionList");
            }
        }

        public RPlaceholderVersionList() : base("UnityEditor.PackageManager.UI.Internal.PlaceholderVersionList")
        {
        }

        public RPlaceholderVersionList(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.PlaceholderVersionList")
		{
            SetInstance(instance);
		}

        public RPlaceholderVersionList(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPlaceholderVersionList(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PlaceholderPackageVersion[] m_Versions
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPlaceholderPackageVersion> r_Fm_Versions;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPlaceholderPackageVersion> RFm_Versions
		{
			get
			{
				if(r_Fm_Versions == null)
				{
					r_Fm_Versions = new(this, "m_Versions");
				}
				return r_Fm_Versions;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Internal.IPackageVersion] key
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> r_Pkey;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> RPkey
		{
			get
			{
				if(r_Pkey == null)
				{
					r_Pkey = new(this, "key", -1);
				}
				return r_Pkey;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion installed
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_Pinstalled;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPinstalled
		{
			get
			{
				if(r_Pinstalled == null)
				{
					r_Pinstalled = new(this, "installed", -1);
				}
				return r_Pinstalled;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion latest
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_Platest;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPlatest
		{
			get
			{
				if(r_Platest == null)
				{
					r_Platest = new(this, "latest", -1);
				}
				return r_Platest;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion latestPatch
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_PlatestPatch;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPlatestPatch
		{
			get
			{
				if(r_PlatestPatch == null)
				{
					r_PlatestPatch = new(this, "latestPatch", -1);
				}
				return r_PlatestPatch;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion importAvailable
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_PimportAvailable;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPimportAvailable
		{
			get
			{
				if(r_PimportAvailable == null)
				{
					r_PimportAvailable = new(this, "importAvailable", -1);
				}
				return r_PimportAvailable;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion recommended
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_Precommended;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPrecommended
		{
			get
			{
				if(r_Precommended == null)
				{
					r_Precommended = new(this, "recommended", -1);
				}
				return r_Precommended;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion primary
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_Pprimary;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPprimary
		{
			get
			{
				if(r_Pprimary == null)
				{
					r_Pprimary = new(this, "primary", -1);
				}
				return r_Pprimary;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion lifecycleVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion r_PlifecycleVersion;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion RPlifecycleVersion
		{
			get
			{
				if(r_PlifecycleVersion == null)
				{
					r_PlifecycleVersion = new(this, "lifecycleVersion", -1);
				}
				return r_PlifecycleVersion;
			}
		}

		/// <summary>
		/// Boolean isNonLifecycleVersionInstalled
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisNonLifecycleVersionInstalled;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisNonLifecycleVersionInstalled
		{
			get
			{
				if(r_PisNonLifecycleVersionInstalled == null)
				{
					r_PisNonLifecycleVersionInstalled = new(this, "isNonLifecycleVersionInstalled", -1);
				}
				return r_PisNonLifecycleVersionInstalled;
			}
		}

		/// <summary>
		/// Boolean hasLifecycleVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasLifecycleVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasLifecycleVersion
		{
			get
			{
				if(r_PhasLifecycleVersion == null)
				{
					r_PhasLifecycleVersion = new(this, "hasLifecycleVersion", -1);
				}
				return r_PhasLifecycleVersion;
			}
		}

		/// <summary>
		/// Int32 numUnloadedVersions
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PnumUnloadedVersions;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPnumUnloadedVersions
		{
			get
			{
				if(r_PnumUnloadedVersions == null)
				{
					r_PnumUnloadedVersions = new(this, "numUnloadedVersions", -1);
				}
				return r_PnumUnloadedVersions;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IPackageVersion GetUpdateTarget(UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MGetUpdateTarget_IPackageVersion;
		public virtual RMethod RMGetUpdateTarget_IPackageVersion
		{
			get
			{
				if(r_MGetUpdateTarget_IPackageVersion == null)
				{
					r_MGetUpdateTarget_IPackageVersion = new(this, "GetUpdateTarget", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MGetUpdateTarget_IPackageVersion;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerator`1[UnityEditor.PackageManager.UI.Internal.IPackageVersion] GetEnumerator()
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
		/// System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		/// </summary>
		protected RMethod r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator;
		public virtual RMethod RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator
		{
			get
			{
				if(r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator == null)
				{
					r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator = new(this, "System.Collections.IEnumerable.GetEnumerator", 0);
				}
				return r_MSystem__2__Collections__2__IEnumerable__2__GetEnumerator;
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


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion GetUpdateTarget(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value};
            var ___result = RMGetUpdateTarget_IPackageVersion.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerator<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion> GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerator<Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion>>(___result);
        }


        public virtual System.Collections.IEnumerator System__2__Collections__2__IEnumerable__2__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSystem__2__Collections__2__IEnumerable__2__GetEnumerator.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.IEnumerator>(___result);
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
