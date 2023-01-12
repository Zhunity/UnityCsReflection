using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RPolicy
{
	/// <summary>
	/// System.Security.Policy.PolicyLevel
	/// </summary>
    public partial class RPolicyLevel : RMember //
    {

		/// <summary>
		/// System.String label
		/// </summary>
		protected RSystem.RString r_Flabel;
		public virtual RSystem.RString RFlabel
		{
			get
			{
				if(r_Flabel == null)
				{
					r_Flabel = new(this, "label");
					r_Flabel.SetBelong(this.instance);
				}
				return r_Flabel;
			}
		}

		/// <summary>
		/// System.Security.Policy.CodeGroup root_code_group
		/// </summary>
		protected RSystem.RSecurity.RPolicy.RCodeGroup r_Froot_code_group;
		public virtual RSystem.RSecurity.RPolicy.RCodeGroup RFroot_code_group
		{
			get
			{
				if(r_Froot_code_group == null)
				{
					r_Froot_code_group = new(this, "root_code_group");
					r_Froot_code_group.SetBelong(this.instance);
				}
				return r_Froot_code_group;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList full_trust_assemblies
		/// </summary>
		protected RSystem.RCollections.RArrayList r_Ffull_trust_assemblies;
		public virtual RSystem.RCollections.RArrayList RFfull_trust_assemblies
		{
			get
			{
				if(r_Ffull_trust_assemblies == null)
				{
					r_Ffull_trust_assemblies = new(this, "full_trust_assemblies");
					r_Ffull_trust_assemblies.SetBelong(this.instance);
				}
				return r_Ffull_trust_assemblies;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList named_permission_sets
		/// </summary>
		protected RSystem.RCollections.RArrayList r_Fnamed_permission_sets;
		public virtual RSystem.RCollections.RArrayList RFnamed_permission_sets
		{
			get
			{
				if(r_Fnamed_permission_sets == null)
				{
					r_Fnamed_permission_sets = new(this, "named_permission_sets");
					r_Fnamed_permission_sets.SetBelong(this.instance);
				}
				return r_Fnamed_permission_sets;
			}
		}

		/// <summary>
		/// System.String _location
		/// </summary>
		protected RSystem.RString r_F_location;
		public virtual RSystem.RString RF_location
		{
			get
			{
				if(r_F_location == null)
				{
					r_F_location = new(this, "_location");
					r_F_location.SetBelong(this.instance);
				}
				return r_F_location;
			}
		}

		/// <summary>
		/// System.Security.PolicyLevelType _type
		/// </summary>
		protected RSystem.RSecurity.RPolicyLevelType r_F_type;
		public virtual RSystem.RSecurity.RPolicyLevelType RF_type
		{
			get
			{
				if(r_F_type == null)
				{
					r_F_type = new(this, "_type");
					r_F_type.SetBelong(this.instance);
				}
				return r_F_type;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable fullNames
		/// </summary>
		protected RSystem.RCollections.RHashtable r_FfullNames;
		public virtual RSystem.RCollections.RHashtable RFfullNames
		{
			get
			{
				if(r_FfullNames == null)
				{
					r_FfullNames = new(this, "fullNames");
					r_FfullNames.SetBelong(this.instance);
				}
				return r_FfullNames;
			}
		}

		/// <summary>
		/// System.Security.SecurityElement xml
		/// </summary>
		protected RSystem.RSecurity.RSecurityElement r_Fxml;
		public virtual RSystem.RSecurity.RSecurityElement RFxml
		{
			get
			{
				if(r_Fxml == null)
				{
					r_Fxml = new(this, "xml");
					r_Fxml.SetBelong(this.instance);
				}
				return r_Fxml;
			}
		}

		/// <summary>
		/// System.Collections.IList FullTrustAssemblies
		/// </summary>
		protected RSystem.RCollections.RIList r_PFullTrustAssemblies;
		public virtual RSystem.RCollections.RIList RPFullTrustAssemblies
		{
			get
			{
				if(r_PFullTrustAssemblies == null)
				{
					r_PFullTrustAssemblies = new(this, "FullTrustAssemblies", -1);
					r_PFullTrustAssemblies.SetBelong(this.instance);
				}
				return r_PFullTrustAssemblies;
			}
		}

		/// <summary>
		/// System.String Label
		/// </summary>
		protected RSystem.RString r_PLabel;
		public virtual RSystem.RString RPLabel
		{
			get
			{
				if(r_PLabel == null)
				{
					r_PLabel = new(this, "Label", -1);
					r_PLabel.SetBelong(this.instance);
				}
				return r_PLabel;
			}
		}

		/// <summary>
		/// System.Collections.IList NamedPermissionSets
		/// </summary>
		protected RSystem.RCollections.RIList r_PNamedPermissionSets;
		public virtual RSystem.RCollections.RIList RPNamedPermissionSets
		{
			get
			{
				if(r_PNamedPermissionSets == null)
				{
					r_PNamedPermissionSets = new(this, "NamedPermissionSets", -1);
					r_PNamedPermissionSets.SetBelong(this.instance);
				}
				return r_PNamedPermissionSets;
			}
		}

		/// <summary>
		/// System.Security.Policy.CodeGroup RootCodeGroup
		/// </summary>
		protected RSystem.RSecurity.RPolicy.RCodeGroup r_PRootCodeGroup;
		public virtual RSystem.RSecurity.RPolicy.RCodeGroup RPRootCodeGroup
		{
			get
			{
				if(r_PRootCodeGroup == null)
				{
					r_PRootCodeGroup = new(this, "RootCodeGroup", -1);
					r_PRootCodeGroup.SetBelong(this.instance);
				}
				return r_PRootCodeGroup;
			}
		}

		/// <summary>
		/// System.String StoreLocation
		/// </summary>
		protected RSystem.RString r_PStoreLocation;
		public virtual RSystem.RString RPStoreLocation
		{
			get
			{
				if(r_PStoreLocation == null)
				{
					r_PStoreLocation = new(this, "StoreLocation", -1);
					r_PStoreLocation.SetBelong(this.instance);
				}
				return r_PStoreLocation;
			}
		}

		/// <summary>
		/// System.Security.PolicyLevelType Type
		/// </summary>
		protected RSystem.RSecurity.RPolicyLevelType r_PType;
		public virtual RSystem.RSecurity.RPolicyLevelType RPType
		{
			get
			{
				if(r_PType == null)
				{
					r_PType = new(this, "Type", -1);
					r_PType.SetBelong(this.instance);
				}
				return r_PType;
			}
		}

		/// <summary>
		/// Void LoadFromFile(System.String)
		/// </summary>
		protected RMethod r_MLoadFromFile_String;
		public virtual RMethod RMLoadFromFile_String
		{
			get
			{
				if(r_MLoadFromFile_String == null)
				{
					r_MLoadFromFile_String = new(this, "LoadFromFile", 0, typeof(System.String));
					r_MLoadFromFile_String.SetBelong(this.instance);
				}
				return r_MLoadFromFile_String;
			}
		}

		/// <summary>
		/// Void LoadFromString(System.String)
		/// </summary>
		protected RMethod r_MLoadFromString_String;
		public virtual RMethod RMLoadFromString_String
		{
			get
			{
				if(r_MLoadFromString_String == null)
				{
					r_MLoadFromString_String = new(this, "LoadFromString", 0, typeof(System.String));
					r_MLoadFromString_String.SetBelong(this.instance);
				}
				return r_MLoadFromString_String;
			}
		}

		/// <summary>
		/// System.Security.SecurityElement FromString(System.String)
		/// </summary>
		protected RMethod r_MFromString_String;
		public virtual RMethod RMFromString_String
		{
			get
			{
				if(r_MFromString_String == null)
				{
					r_MFromString_String = new(this, "FromString", 0, typeof(System.String));
					r_MFromString_String.SetBelong(this.instance);
				}
				return r_MFromString_String;
			}
		}

		/// <summary>
		/// Void AddFullTrustAssembly(System.Security.Policy.StrongName)
		/// </summary>
		protected RMethod r_MAddFullTrustAssembly_StrongName;
		public virtual RMethod RMAddFullTrustAssembly_StrongName
		{
			get
			{
				if(r_MAddFullTrustAssembly_StrongName == null)
				{
					r_MAddFullTrustAssembly_StrongName = new(this, "AddFullTrustAssembly", 0, typeof(System.Security.Policy.StrongName));
					r_MAddFullTrustAssembly_StrongName.SetBelong(this.instance);
				}
				return r_MAddFullTrustAssembly_StrongName;
			}
		}

		/// <summary>
		/// Void AddFullTrustAssembly(System.Security.Policy.StrongNameMembershipCondition)
		/// </summary>
		protected RMethod r_MAddFullTrustAssembly_StrongNameMembershipCondition;
		public virtual RMethod RMAddFullTrustAssembly_StrongNameMembershipCondition
		{
			get
			{
				if(r_MAddFullTrustAssembly_StrongNameMembershipCondition == null)
				{
					r_MAddFullTrustAssembly_StrongNameMembershipCondition = new(this, "AddFullTrustAssembly", 0, typeof(System.Security.Policy.StrongNameMembershipCondition));
					r_MAddFullTrustAssembly_StrongNameMembershipCondition.SetBelong(this.instance);
				}
				return r_MAddFullTrustAssembly_StrongNameMembershipCondition;
			}
		}

		/// <summary>
		/// Void AddNamedPermissionSet(System.Security.NamedPermissionSet)
		/// </summary>
		protected RMethod r_MAddNamedPermissionSet_NamedPermissionSet;
		public virtual RMethod RMAddNamedPermissionSet_NamedPermissionSet
		{
			get
			{
				if(r_MAddNamedPermissionSet_NamedPermissionSet == null)
				{
					r_MAddNamedPermissionSet_NamedPermissionSet = new(this, "AddNamedPermissionSet", 0, typeof(System.Security.NamedPermissionSet));
					r_MAddNamedPermissionSet_NamedPermissionSet.SetBelong(this.instance);
				}
				return r_MAddNamedPermissionSet_NamedPermissionSet;
			}
		}

		/// <summary>
		/// System.Security.NamedPermissionSet ChangeNamedPermissionSet(System.String, System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_MChangeNamedPermissionSet_String_PermissionSet;
		public virtual RMethod RMChangeNamedPermissionSet_String_PermissionSet
		{
			get
			{
				if(r_MChangeNamedPermissionSet_String_PermissionSet == null)
				{
					r_MChangeNamedPermissionSet_String_PermissionSet = new(this, "ChangeNamedPermissionSet", 0, typeof(System.String), typeof(System.Security.PermissionSet));
					r_MChangeNamedPermissionSet_String_PermissionSet.SetBelong(this.instance);
				}
				return r_MChangeNamedPermissionSet_String_PermissionSet;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyLevel CreateAppDomainLevel()
		/// </summary>
		protected static RMethod r_MCreateAppDomainLevel;
		public static RMethod RMCreateAppDomainLevel
		{
			get
			{
				if(r_MCreateAppDomainLevel == null)
				{
					r_MCreateAppDomainLevel = new(typeof(System.Security.Policy.PolicyLevel), "CreateAppDomainLevel", 0);
					r_MCreateAppDomainLevel.SetBelong(null);
				}
				return r_MCreateAppDomainLevel;
			}
		}

		/// <summary>
		/// Void FromXml(System.Security.SecurityElement)
		/// </summary>
		protected RMethod r_MFromXml_SecurityElement;
		public virtual RMethod RMFromXml_SecurityElement
		{
			get
			{
				if(r_MFromXml_SecurityElement == null)
				{
					r_MFromXml_SecurityElement = new(this, "FromXml", 0, typeof(System.Security.SecurityElement));
					r_MFromXml_SecurityElement.SetBelong(this.instance);
				}
				return r_MFromXml_SecurityElement;
			}
		}

		/// <summary>
		/// System.Security.NamedPermissionSet GetNamedPermissionSet(System.String)
		/// </summary>
		protected RMethod r_MGetNamedPermissionSet_String;
		public virtual RMethod RMGetNamedPermissionSet_String
		{
			get
			{
				if(r_MGetNamedPermissionSet_String == null)
				{
					r_MGetNamedPermissionSet_String = new(this, "GetNamedPermissionSet", 0, typeof(System.String));
					r_MGetNamedPermissionSet_String.SetBelong(this.instance);
				}
				return r_MGetNamedPermissionSet_String;
			}
		}

		/// <summary>
		/// Void Recover()
		/// </summary>
		protected RMethod r_MRecover;
		public virtual RMethod RMRecover
		{
			get
			{
				if(r_MRecover == null)
				{
					r_MRecover = new(this, "Recover", 0);
					r_MRecover.SetBelong(this.instance);
				}
				return r_MRecover;
			}
		}

		/// <summary>
		/// Void RemoveFullTrustAssembly(System.Security.Policy.StrongName)
		/// </summary>
		protected RMethod r_MRemoveFullTrustAssembly_StrongName;
		public virtual RMethod RMRemoveFullTrustAssembly_StrongName
		{
			get
			{
				if(r_MRemoveFullTrustAssembly_StrongName == null)
				{
					r_MRemoveFullTrustAssembly_StrongName = new(this, "RemoveFullTrustAssembly", 0, typeof(System.Security.Policy.StrongName));
					r_MRemoveFullTrustAssembly_StrongName.SetBelong(this.instance);
				}
				return r_MRemoveFullTrustAssembly_StrongName;
			}
		}

		/// <summary>
		/// Void RemoveFullTrustAssembly(System.Security.Policy.StrongNameMembershipCondition)
		/// </summary>
		protected RMethod r_MRemoveFullTrustAssembly_StrongNameMembershipCondition;
		public virtual RMethod RMRemoveFullTrustAssembly_StrongNameMembershipCondition
		{
			get
			{
				if(r_MRemoveFullTrustAssembly_StrongNameMembershipCondition == null)
				{
					r_MRemoveFullTrustAssembly_StrongNameMembershipCondition = new(this, "RemoveFullTrustAssembly", 0, typeof(System.Security.Policy.StrongNameMembershipCondition));
					r_MRemoveFullTrustAssembly_StrongNameMembershipCondition.SetBelong(this.instance);
				}
				return r_MRemoveFullTrustAssembly_StrongNameMembershipCondition;
			}
		}

		/// <summary>
		/// System.Security.NamedPermissionSet RemoveNamedPermissionSet(System.Security.NamedPermissionSet)
		/// </summary>
		protected RMethod r_MRemoveNamedPermissionSet_NamedPermissionSet;
		public virtual RMethod RMRemoveNamedPermissionSet_NamedPermissionSet
		{
			get
			{
				if(r_MRemoveNamedPermissionSet_NamedPermissionSet == null)
				{
					r_MRemoveNamedPermissionSet_NamedPermissionSet = new(this, "RemoveNamedPermissionSet", 0, typeof(System.Security.NamedPermissionSet));
					r_MRemoveNamedPermissionSet_NamedPermissionSet.SetBelong(this.instance);
				}
				return r_MRemoveNamedPermissionSet_NamedPermissionSet;
			}
		}

		/// <summary>
		/// System.Security.NamedPermissionSet RemoveNamedPermissionSet(System.String)
		/// </summary>
		protected RMethod r_MRemoveNamedPermissionSet_String;
		public virtual RMethod RMRemoveNamedPermissionSet_String
		{
			get
			{
				if(r_MRemoveNamedPermissionSet_String == null)
				{
					r_MRemoveNamedPermissionSet_String = new(this, "RemoveNamedPermissionSet", 0, typeof(System.String));
					r_MRemoveNamedPermissionSet_String.SetBelong(this.instance);
				}
				return r_MRemoveNamedPermissionSet_String;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
					r_MReset.SetBelong(this.instance);
				}
				return r_MReset;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_MResolve_Evidence;
		public virtual RMethod RMResolve_Evidence
		{
			get
			{
				if(r_MResolve_Evidence == null)
				{
					r_MResolve_Evidence = new(this, "Resolve", 0, typeof(System.Security.Policy.Evidence));
					r_MResolve_Evidence.SetBelong(this.instance);
				}
				return r_MResolve_Evidence;
			}
		}

		/// <summary>
		/// System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_MResolveMatchingCodeGroups_Evidence;
		public virtual RMethod RMResolveMatchingCodeGroups_Evidence
		{
			get
			{
				if(r_MResolveMatchingCodeGroups_Evidence == null)
				{
					r_MResolveMatchingCodeGroups_Evidence = new(this, "ResolveMatchingCodeGroups", 0, typeof(System.Security.Policy.Evidence));
					r_MResolveMatchingCodeGroups_Evidence.SetBelong(this.instance);
				}
				return r_MResolveMatchingCodeGroups_Evidence;
			}
		}

		/// <summary>
		/// System.Security.SecurityElement ToXml()
		/// </summary>
		protected RMethod r_MToXml;
		public virtual RMethod RMToXml
		{
			get
			{
				if(r_MToXml == null)
				{
					r_MToXml = new(this, "ToXml", 0);
					r_MToXml.SetBelong(this.instance);
				}
				return r_MToXml;
			}
		}

		/// <summary>
		/// Void Save()
		/// </summary>
		protected RMethod r_MSave;
		public virtual RMethod RMSave
		{
			get
			{
				if(r_MSave == null)
				{
					r_MSave = new(this, "Save", 0);
					r_MSave.SetBelong(this.instance);
				}
				return r_MSave;
			}
		}

		/// <summary>
		/// Void CreateDefaultLevel(System.Security.PolicyLevelType)
		/// </summary>
		protected RMethod r_MCreateDefaultLevel_PolicyLevelType;
		public virtual RMethod RMCreateDefaultLevel_PolicyLevelType
		{
			get
			{
				if(r_MCreateDefaultLevel_PolicyLevelType == null)
				{
					r_MCreateDefaultLevel_PolicyLevelType = new(this, "CreateDefaultLevel", 0, typeof(System.Security.PolicyLevelType));
					r_MCreateDefaultLevel_PolicyLevelType.SetBelong(this.instance);
				}
				return r_MCreateDefaultLevel_PolicyLevelType;
			}
		}

		/// <summary>
		/// Void CreateDefaultFullTrustAssemblies()
		/// </summary>
		protected RMethod r_MCreateDefaultFullTrustAssemblies;
		public virtual RMethod RMCreateDefaultFullTrustAssemblies
		{
			get
			{
				if(r_MCreateDefaultFullTrustAssemblies == null)
				{
					r_MCreateDefaultFullTrustAssemblies = new(this, "CreateDefaultFullTrustAssemblies", 0);
					r_MCreateDefaultFullTrustAssemblies.SetBelong(this.instance);
				}
				return r_MCreateDefaultFullTrustAssemblies;
			}
		}

		/// <summary>
		/// Void CreateDefaultNamedPermissionSets()
		/// </summary>
		protected RMethod r_MCreateDefaultNamedPermissionSets;
		public virtual RMethod RMCreateDefaultNamedPermissionSets
		{
			get
			{
				if(r_MCreateDefaultNamedPermissionSets == null)
				{
					r_MCreateDefaultNamedPermissionSets = new(this, "CreateDefaultNamedPermissionSets", 0);
					r_MCreateDefaultNamedPermissionSets.SetBelong(this.instance);
				}
				return r_MCreateDefaultNamedPermissionSets;
			}
		}

		/// <summary>
		/// System.String ResolveClassName(System.String)
		/// </summary>
		protected RMethod r_MResolveClassName_String;
		public virtual RMethod RMResolveClassName_String
		{
			get
			{
				if(r_MResolveClassName_String == null)
				{
					r_MResolveClassName_String = new(this, "ResolveClassName", 0, typeof(System.String));
					r_MResolveClassName_String.SetBelong(this.instance);
				}
				return r_MResolveClassName_String;
			}
		}

		/// <summary>
		/// Boolean IsFullTrustAssembly(System.Reflection.Assembly)
		/// </summary>
		protected RMethod r_MIsFullTrustAssembly_Assembly;
		public virtual RMethod RMIsFullTrustAssembly_Assembly
		{
			get
			{
				if(r_MIsFullTrustAssembly_Assembly == null)
				{
					r_MIsFullTrustAssembly_Assembly = new(this, "IsFullTrustAssembly", 0, typeof(System.Reflection.Assembly));
					r_MIsFullTrustAssembly_Assembly.SetBelong(this.instance);
				}
				return r_MIsFullTrustAssembly_Assembly;
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


        public RPolicyLevel() : base("System.Security.Policy.PolicyLevel")
        {
        }

        public RPolicyLevel(System.Object instance) : base("System.Security.Policy.PolicyLevel")
		{
            SetInstance(instance);
		}

        public RPolicyLevel(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPolicyLevel(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void LoadFromFile(System.String @filename)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filename};
            var ___result = RMLoadFromFile_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadFromString(System.String @xml)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xml};
            var ___result = RMLoadFromString_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.SecurityElement FromString(System.String @xml)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xml};
            var ___result = RMFromString_String.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
        }


        public virtual void AddFullTrustAssembly(System.Security.Policy.StrongName @sn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sn};
            var ___result = RMAddFullTrustAssembly_StrongName.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddFullTrustAssembly(System.Security.Policy.StrongNameMembershipCondition @snMC)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@snMC};
            var ___result = RMAddFullTrustAssembly_StrongNameMembershipCondition.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddNamedPermissionSet(System.Security.NamedPermissionSet @permSet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permSet};
            var ___result = RMAddNamedPermissionSet_NamedPermissionSet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.NamedPermissionSet ChangeNamedPermissionSet(System.String @name, System.Security.PermissionSet @pSet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @pSet};
            var ___result = RMChangeNamedPermissionSet_String_PermissionSet.Invoke(___genericsType, ___parameters);

            return (System.Security.NamedPermissionSet)___result;
        }


        public static System.Security.Policy.PolicyLevel CreateAppDomainLevel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateAppDomainLevel.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.PolicyLevel)___result;
        }


        public virtual void FromXml(System.Security.SecurityElement @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMFromXml_SecurityElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.NamedPermissionSet GetNamedPermissionSet(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetNamedPermissionSet_String.Invoke(___genericsType, ___parameters);

            return (System.Security.NamedPermissionSet)___result;
        }


        public virtual void Recover()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRecover.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFullTrustAssembly(System.Security.Policy.StrongName @sn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sn};
            var ___result = RMRemoveFullTrustAssembly_StrongName.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFullTrustAssembly(System.Security.Policy.StrongNameMembershipCondition @snMC)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@snMC};
            var ___result = RMRemoveFullTrustAssembly_StrongNameMembershipCondition.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.NamedPermissionSet RemoveNamedPermissionSet(System.Security.NamedPermissionSet @permSet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permSet};
            var ___result = RMRemoveNamedPermissionSet_NamedPermissionSet.Invoke(___genericsType, ___parameters);

            return (System.Security.NamedPermissionSet)___result;
        }


        public virtual System.Security.NamedPermissionSet RemoveNamedPermissionSet(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMRemoveNamedPermissionSet_String.Invoke(___genericsType, ___parameters);

            return (System.Security.NamedPermissionSet)___result;
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence @evidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evidence};
            var ___result = RMResolve_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.PolicyStatement)___result;
        }


        public virtual System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence @evidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evidence};
            var ___result = RMResolveMatchingCodeGroups_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.CodeGroup)___result;
        }


        public virtual System.Security.SecurityElement ToXml()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToXml.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
        }


        public virtual void Save()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSave.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CreateDefaultLevel(System.Security.PolicyLevelType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMCreateDefaultLevel_PolicyLevelType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CreateDefaultFullTrustAssemblies()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateDefaultFullTrustAssemblies.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CreateDefaultNamedPermissionSets()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCreateDefaultNamedPermissionSets.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ResolveClassName(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RMResolveClassName_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean IsFullTrustAssembly(System.Reflection.Assembly @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMIsFullTrustAssembly_Assembly.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
