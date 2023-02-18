
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.MultiSelectFoldoutGroup
	/// </summary>
    public partial class RMultiSelectFoldoutGroup : RMember //
    {

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.MultiSelectFoldout <mainFoldout>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RMultiSelectFoldout r_F__0__mainFoldout__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RMultiSelectFoldout RF__0__mainFoldout__1__k__BackingField
		{
			get
			{
				if(r_F__0__mainFoldout__1__k__BackingField == null)
				{
					r_F__0__mainFoldout__1__k__BackingField = new(this, "<mainFoldout>k__BackingField");
				}
				return r_F__0__mainFoldout__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.MultiSelectFoldout <inProgressFoldout>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RMultiSelectFoldout r_F__0__inProgressFoldout__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RMultiSelectFoldout RF__0__inProgressFoldout__1__k__BackingField
		{
			get
			{
				if(r_F__0__inProgressFoldout__1__k__BackingField == null)
				{
					r_F__0__inProgressFoldout__1__k__BackingField = new(this, "<inProgressFoldout>k__BackingField");
				}
				return r_F__0__inProgressFoldout__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.MultiSelectFoldout mainFoldout
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RMultiSelectFoldout r_PmainFoldout;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RMultiSelectFoldout RPmainFoldout
		{
			get
			{
				if(r_PmainFoldout == null)
				{
					r_PmainFoldout = new(this, "mainFoldout", -1);
				}
				return r_PmainFoldout;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.MultiSelectFoldout inProgressFoldout
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RMultiSelectFoldout r_PinProgressFoldout;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RMultiSelectFoldout RPinProgressFoldout
		{
			get
			{
				if(r_PinProgressFoldout == null)
				{
					r_PinProgressFoldout = new(this, "inProgressFoldout", -1);
				}
				return r_PinProgressFoldout;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageToolBarRegularButton mainButton
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageToolBarRegularButton r_PmainButton;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageToolBarRegularButton RPmainButton
		{
			get
			{
				if(r_PmainButton == null)
				{
					r_PmainButton = new(this, "mainButton", -1);
				}
				return r_PmainButton;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageToolBarRegularButton cancelButton
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageToolBarRegularButton r_PcancelButton;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageToolBarRegularButton RPcancelButton
		{
			get
			{
				if(r_PcancelButton == null)
				{
					r_PcancelButton = new(this, "cancelButton", -1);
				}
				return r_PcancelButton;
			}
		}

		/// <summary>
		/// Boolean AddPackageVersion(UnityEditor.PackageManager.UI.Internal.IPackageVersion)
		/// </summary>
		protected RMethod r_MAddPackageVersion_IPackageVersion;
		public virtual RMethod RMAddPackageVersion_IPackageVersion
		{
			get
			{
				if(r_MAddPackageVersion_IPackageVersion == null)
				{
					r_MAddPackageVersion_IPackageVersion = new(this, "AddPackageVersion", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IPackageVersion"));
				}
				return r_MAddPackageVersion_IPackageVersion;
			}
		}

		/// <summary>
		/// Void Refresh()
		/// </summary>
		protected RMethod r_MRefresh;
		public virtual RMethod RMRefresh
		{
			get
			{
				if(r_MRefresh == null)
				{
					r_MRefresh = new(this, "Refresh", 0);
				}
				return r_MRefresh;
			}
		}

		/// <summary>
		/// Void ClearVersions()
		/// </summary>
		protected RMethod r_MClearVersions;
		public virtual RMethod RMClearVersions
		{
			get
			{
				if(r_MClearVersions == null)
				{
					r_MClearVersions = new(this, "ClearVersions", 0);
				}
				return r_MClearVersions;
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


        public RMultiSelectFoldoutGroup() : base("UnityEditor.PackageManager.UI.Internal.MultiSelectFoldoutGroup")
        {
        }

        public RMultiSelectFoldoutGroup(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.MultiSelectFoldoutGroup")
		{
            SetInstance(instance);
		}

        public RMultiSelectFoldoutGroup(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMultiSelectFoldoutGroup(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean AddPackageVersion(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIPackageVersion @version)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@version.Value};
            var ___result = RMAddPackageVersion_IPackageVersion.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Refresh()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRefresh.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearVersions()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearVersions.Invoke(___genericsType, ___parameters);

            
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
