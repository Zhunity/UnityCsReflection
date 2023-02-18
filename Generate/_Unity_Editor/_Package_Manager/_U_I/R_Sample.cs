
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Sample
	/// </summary>
    public partial class RSample : RMember //
    {

		/// <summary>
		/// System.String k_CopySamplesFilesTitle
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_CopySamplesFilesTitle;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_CopySamplesFilesTitle
		{
			get
			{
				if(r_Fk_CopySamplesFilesTitle == null)
				{
					r_Fk_CopySamplesFilesTitle = new(typeof(UnityEditor.PackageManager.UI.Sample), "k_CopySamplesFilesTitle");
					r_Fk_CopySamplesFilesTitle.SetBelong(null);
				}
				return r_Fk_CopySamplesFilesTitle;
			}
		}

		/// <summary>
		/// System.String <displayName>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__displayName__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__displayName__1__k__BackingField
		{
			get
			{
				if(r_F__0__displayName__1__k__BackingField == null)
				{
					r_F__0__displayName__1__k__BackingField = new(this, "<displayName>k__BackingField");
					r_F__0__displayName__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__displayName__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <description>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__description__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__description__1__k__BackingField
		{
			get
			{
				if(r_F__0__description__1__k__BackingField == null)
				{
					r_F__0__description__1__k__BackingField = new(this, "<description>k__BackingField");
					r_F__0__description__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__description__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <resolvedPath>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__resolvedPath__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__resolvedPath__1__k__BackingField
		{
			get
			{
				if(r_F__0__resolvedPath__1__k__BackingField == null)
				{
					r_F__0__resolvedPath__1__k__BackingField = new(this, "<resolvedPath>k__BackingField");
					r_F__0__resolvedPath__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__resolvedPath__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <importPath>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_F__0__importPath__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RF__0__importPath__1__k__BackingField
		{
			get
			{
				if(r_F__0__importPath__1__k__BackingField == null)
				{
					r_F__0__importPath__1__k__BackingField = new(this, "<importPath>k__BackingField");
					r_F__0__importPath__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__importPath__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <interactiveImport>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__interactiveImport__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__interactiveImport__1__k__BackingField
		{
			get
			{
				if(r_F__0__interactiveImport__1__k__BackingField == null)
				{
					r_F__0__interactiveImport__1__k__BackingField = new(this, "<interactiveImport>k__BackingField");
					r_F__0__interactiveImport__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__interactiveImport__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.IOProxy m_IOProxy
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOProxy r_Fm_IOProxy;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOProxy RFm_IOProxy
		{
			get
			{
				if(r_Fm_IOProxy == null)
				{
					r_Fm_IOProxy = new(this, "m_IOProxy");
					r_Fm_IOProxy.SetBelong(this.GetValue());
				}
				return r_Fm_IOProxy;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.AssetDatabaseProxy m_AssetDatabase
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetDatabaseProxy r_Fm_AssetDatabase;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetDatabaseProxy RFm_AssetDatabase
		{
			get
			{
				if(r_Fm_AssetDatabase == null)
				{
					r_Fm_AssetDatabase = new(this, "m_AssetDatabase");
					r_Fm_AssetDatabase.SetBelong(this.GetValue());
				}
				return r_Fm_AssetDatabase;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_PreviousImports
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_PreviousImports;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RFm_PreviousImports
		{
			get
			{
				if(r_Fm_PreviousImports == null)
				{
					r_Fm_PreviousImports = new(this, "m_PreviousImports");
					r_Fm_PreviousImports.SetBelong(this.GetValue());
				}
				return r_Fm_PreviousImports;
			}
		}

		/// <summary>
		/// System.String m_Size
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Size;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Size
		{
			get
			{
				if(r_Fm_Size == null)
				{
					r_Fm_Size = new(this, "m_Size");
					r_Fm_Size.SetBelong(this.GetValue());
				}
				return r_Fm_Size;
			}
		}

		/// <summary>
		/// System.String displayName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PdisplayName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPdisplayName
		{
			get
			{
				if(r_PdisplayName == null)
				{
					r_PdisplayName = new(this, "displayName", -1);
					r_PdisplayName.SetBelong(this.GetValue());
				}
				return r_PdisplayName;
			}
		}

		/// <summary>
		/// System.String description
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pdescription;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPdescription
		{
			get
			{
				if(r_Pdescription == null)
				{
					r_Pdescription = new(this, "description", -1);
					r_Pdescription.SetBelong(this.GetValue());
				}
				return r_Pdescription;
			}
		}

		/// <summary>
		/// System.String resolvedPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PresolvedPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPresolvedPath
		{
			get
			{
				if(r_PresolvedPath == null)
				{
					r_PresolvedPath = new(this, "resolvedPath", -1);
					r_PresolvedPath.SetBelong(this.GetValue());
				}
				return r_PresolvedPath;
			}
		}

		/// <summary>
		/// System.String importPath
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PimportPath;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPimportPath
		{
			get
			{
				if(r_PimportPath == null)
				{
					r_PimportPath = new(this, "importPath", -1);
					r_PimportPath.SetBelong(this.GetValue());
				}
				return r_PimportPath;
			}
		}

		/// <summary>
		/// Boolean interactiveImport
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PinteractiveImport;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPinteractiveImport
		{
			get
			{
				if(r_PinteractiveImport == null)
				{
					r_PinteractiveImport = new(this, "interactiveImport", -1);
					r_PinteractiveImport.SetBelong(this.GetValue());
				}
				return r_PinteractiveImport;
			}
		}

		/// <summary>
		/// Boolean isImported
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisImported;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisImported
		{
			get
			{
				if(r_PisImported == null)
				{
					r_PisImported = new(this, "isImported", -1);
					r_PisImported.SetBelong(this.GetValue());
				}
				return r_PisImported;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] previousImports
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_PpreviousImports;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RPpreviousImports
		{
			get
			{
				if(r_PpreviousImports == null)
				{
					r_PpreviousImports = new(this, "previousImports", -1);
					r_PpreviousImports.SetBelong(this.GetValue());
				}
				return r_PpreviousImports;
			}
		}

		/// <summary>
		/// System.String size
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Psize;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPsize
		{
			get
			{
				if(r_Psize == null)
				{
					r_Psize = new(this, "size", -1);
					r_Psize.SetBelong(this.GetValue());
				}
				return r_Psize;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Sample] FindByPackage(UnityEditor.PackageManager.PackageInfo, UnityEditor.PackageManager.UI.Internal.UpmCache, UnityEditor.PackageManager.UI.Internal.IOProxy, UnityEditor.PackageManager.UI.Internal.AssetDatabaseProxy)
		/// </summary>
		protected static RMethod r_MFindByPackage_PackageInfo_UpmCache_IOProxy_AssetDatabaseProxy;
		public static RMethod RMFindByPackage_PackageInfo_UpmCache_IOProxy_AssetDatabaseProxy
		{
			get
			{
				if(r_MFindByPackage_PackageInfo_UpmCache_IOProxy_AssetDatabaseProxy == null)
				{
					r_MFindByPackage_PackageInfo_UpmCache_IOProxy_AssetDatabaseProxy = new(typeof(UnityEditor.PackageManager.UI.Sample), "FindByPackage", 0, typeof(UnityEditor.PackageManager.PackageInfo),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.UpmCache"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.IOProxy"),  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetDatabaseProxy"));
					r_MFindByPackage_PackageInfo_UpmCache_IOProxy_AssetDatabaseProxy.SetBelong(null);
				}
				return r_MFindByPackage_PackageInfo_UpmCache_IOProxy_AssetDatabaseProxy;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEditor.PackageManager.UI.Sample] FindByPackage(System.String, System.String)
		/// </summary>
		protected static RMethod r_MFindByPackage_String_String;
		public static RMethod RMFindByPackage_String_String
		{
			get
			{
				if(r_MFindByPackage_String_String == null)
				{
					r_MFindByPackage_String_String = new(typeof(UnityEditor.PackageManager.UI.Sample), "FindByPackage", 0, typeof(System.String), typeof(System.String));
					r_MFindByPackage_String_String.SetBelong(null);
				}
				return r_MFindByPackage_String_String;
			}
		}

		/// <summary>
		/// Boolean Import(ImportOptions)
		/// </summary>
		protected RMethod r_MImport_ImportOptions;
		public virtual RMethod RMImport_ImportOptions
		{
			get
			{
				if(r_MImport_ImportOptions == null)
				{
					r_MImport_ImportOptions = new(this, "Import", 0,  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Sample+ImportOptions"));
					r_MImport_ImportOptions.SetBelong(this.GetValue());
				}
				return r_MImport_ImportOptions;
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


        public RSample() : base("UnityEditor.PackageManager.UI.Sample")
        {
        }

        public RSample(System.Object instance) : base("UnityEditor.PackageManager.UI.Sample")
		{
            SetInstance(instance);
		}

        public RSample(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSample(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Collections.Generic.IEnumerable<UnityEditor.PackageManager.UI.Sample> FindByPackage(UnityEditor.PackageManager.PackageInfo @package, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RUpmCache @upmCache, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RIOProxy @ioProxy, Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RAssetDatabaseProxy @assetDatabaseProxy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@package, @upmCache.Value, @ioProxy.Value, @assetDatabaseProxy.Value};
            var ___result = RMFindByPackage_PackageInfo_UpmCache_IOProxy_AssetDatabaseProxy.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<UnityEditor.PackageManager.UI.Sample>)___result;
        }


        public static System.Collections.Generic.IEnumerable<UnityEditor.PackageManager.UI.Sample> FindByPackage(System.String @packageName, System.String @packageVersion)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packageName, @packageVersion};
            var ___result = RMFindByPackage_String_String.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<UnityEditor.PackageManager.UI.Sample>)___result;
        }


        public virtual System.Boolean Import(Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RSample.RImportOptions @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@options.Value};
            var ___result = RMImport_ImportOptions.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
