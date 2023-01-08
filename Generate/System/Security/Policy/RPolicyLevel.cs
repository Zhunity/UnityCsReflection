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
		protected RField r_label;
		public virtual RField Rlabel
		{
			get
			{
				if(r_label == null)
				{
					r_label = new(this, "label");
					r_label.SetBelong(this.instance);
				}
				return r_label;
			}
		}

		/// <summary>
		/// System.Security.Policy.CodeGroup root_code_group
		/// </summary>
		protected RSystem.RSecurity.RPolicy.RCodeGroup r_root_code_group;
		public virtual RSystem.RSecurity.RPolicy.RCodeGroup Rroot_code_group
		{
			get
			{
				if(r_root_code_group == null)
				{
					r_root_code_group = new(this, "root_code_group");
					r_root_code_group.SetBelong(this.instance);
				}
				return r_root_code_group;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList full_trust_assemblies
		/// </summary>
		protected RSystem.RCollections.RArrayList r_full_trust_assemblies;
		public virtual RSystem.RCollections.RArrayList Rfull_trust_assemblies
		{
			get
			{
				if(r_full_trust_assemblies == null)
				{
					r_full_trust_assemblies = new(this, "full_trust_assemblies");
					r_full_trust_assemblies.SetBelong(this.instance);
				}
				return r_full_trust_assemblies;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList named_permission_sets
		/// </summary>
		protected RSystem.RCollections.RArrayList r_named_permission_sets;
		public virtual RSystem.RCollections.RArrayList Rnamed_permission_sets
		{
			get
			{
				if(r_named_permission_sets == null)
				{
					r_named_permission_sets = new(this, "named_permission_sets");
					r_named_permission_sets.SetBelong(this.instance);
				}
				return r_named_permission_sets;
			}
		}

		/// <summary>
		/// System.String _location
		/// </summary>
		protected RField r__location;
		public virtual RField R_location
		{
			get
			{
				if(r__location == null)
				{
					r__location = new(this, "_location");
					r__location.SetBelong(this.instance);
				}
				return r__location;
			}
		}

		/// <summary>
		/// System.Security.PolicyLevelType _type
		/// </summary>
		protected RField r__type;
		public virtual RField R_type
		{
			get
			{
				if(r__type == null)
				{
					r__type = new(this, "_type");
					r__type.SetBelong(this.instance);
				}
				return r__type;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable fullNames
		/// </summary>
		protected RSystem.RCollections.RHashtable r_fullNames;
		public virtual RSystem.RCollections.RHashtable RfullNames
		{
			get
			{
				if(r_fullNames == null)
				{
					r_fullNames = new(this, "fullNames");
					r_fullNames.SetBelong(this.instance);
				}
				return r_fullNames;
			}
		}

		/// <summary>
		/// System.Security.SecurityElement xml
		/// </summary>
		protected RSystem.RSecurity.RSecurityElement r_xml;
		public virtual RSystem.RSecurity.RSecurityElement Rxml
		{
			get
			{
				if(r_xml == null)
				{
					r_xml = new(this, "xml");
					r_xml.SetBelong(this.instance);
				}
				return r_xml;
			}
		}

		/// <summary>
		/// System.Collections.IList FullTrustAssemblies
		/// </summary>
		protected RSystem.RCollections.RIList r_FullTrustAssemblies;
		public virtual RSystem.RCollections.RIList RFullTrustAssemblies
		{
			get
			{
				if(r_FullTrustAssemblies == null)
				{
					r_FullTrustAssemblies = new(this, "FullTrustAssemblies", -1);
					r_FullTrustAssemblies.SetBelong(this.instance);
				}
				return r_FullTrustAssemblies;
			}
		}

		/// <summary>
		/// System.String Label
		/// </summary>
		protected RProperty r_Label;
		public virtual RProperty RLabel
		{
			get
			{
				if(r_Label == null)
				{
					r_Label = new(this, "Label", -1);
					r_Label.SetBelong(this.instance);
				}
				return r_Label;
			}
		}

		/// <summary>
		/// System.Collections.IList NamedPermissionSets
		/// </summary>
		protected RSystem.RCollections.RIList r_NamedPermissionSets;
		public virtual RSystem.RCollections.RIList RNamedPermissionSets
		{
			get
			{
				if(r_NamedPermissionSets == null)
				{
					r_NamedPermissionSets = new(this, "NamedPermissionSets", -1);
					r_NamedPermissionSets.SetBelong(this.instance);
				}
				return r_NamedPermissionSets;
			}
		}

		/// <summary>
		/// System.Security.Policy.CodeGroup RootCodeGroup
		/// </summary>
		protected RSystem.RSecurity.RPolicy.RCodeGroup r_RootCodeGroup;
		public virtual RSystem.RSecurity.RPolicy.RCodeGroup RRootCodeGroup
		{
			get
			{
				if(r_RootCodeGroup == null)
				{
					r_RootCodeGroup = new(this, "RootCodeGroup", -1);
					r_RootCodeGroup.SetBelong(this.instance);
				}
				return r_RootCodeGroup;
			}
		}

		/// <summary>
		/// System.String StoreLocation
		/// </summary>
		protected RProperty r_StoreLocation;
		public virtual RProperty RStoreLocation
		{
			get
			{
				if(r_StoreLocation == null)
				{
					r_StoreLocation = new(this, "StoreLocation", -1);
					r_StoreLocation.SetBelong(this.instance);
				}
				return r_StoreLocation;
			}
		}

		/// <summary>
		/// System.Security.PolicyLevelType Type
		/// </summary>
		protected RProperty r_Type;
		public virtual RProperty RType
		{
			get
			{
				if(r_Type == null)
				{
					r_Type = new(this, "Type", -1);
					r_Type.SetBelong(this.instance);
				}
				return r_Type;
			}
		}

		/// <summary>
		/// Void LoadFromFile(System.String)
		/// </summary>
		protected RMethod r_LoadFromFile_String;
		public virtual RMethod RLoadFromFile_String
		{
			get
			{
				if(r_LoadFromFile_String == null)
				{
					r_LoadFromFile_String = new(this, "LoadFromFile", 0, typeof(System.String));
					r_LoadFromFile_String.SetBelong(this.instance);
				}
				return r_LoadFromFile_String;
			}
		}

		/// <summary>
		/// Void LoadFromString(System.String)
		/// </summary>
		protected RMethod r_LoadFromString_String;
		public virtual RMethod RLoadFromString_String
		{
			get
			{
				if(r_LoadFromString_String == null)
				{
					r_LoadFromString_String = new(this, "LoadFromString", 0, typeof(System.String));
					r_LoadFromString_String.SetBelong(this.instance);
				}
				return r_LoadFromString_String;
			}
		}

		/// <summary>
		/// System.Security.SecurityElement FromString(System.String)
		/// </summary>
		protected RMethod r_FromString_String;
		public virtual RMethod RFromString_String
		{
			get
			{
				if(r_FromString_String == null)
				{
					r_FromString_String = new(this, "FromString", 0, typeof(System.String));
					r_FromString_String.SetBelong(this.instance);
				}
				return r_FromString_String;
			}
		}

		/// <summary>
		/// Void AddFullTrustAssembly(System.Security.Policy.StrongName)
		/// </summary>
		protected RMethod r_AddFullTrustAssembly_StrongName;
		public virtual RMethod RAddFullTrustAssembly_StrongName
		{
			get
			{
				if(r_AddFullTrustAssembly_StrongName == null)
				{
					r_AddFullTrustAssembly_StrongName = new(this, "AddFullTrustAssembly", 0, typeof(System.Security.Policy.StrongName));
					r_AddFullTrustAssembly_StrongName.SetBelong(this.instance);
				}
				return r_AddFullTrustAssembly_StrongName;
			}
		}

		/// <summary>
		/// Void AddFullTrustAssembly(System.Security.Policy.StrongNameMembershipCondition)
		/// </summary>
		protected RMethod r_AddFullTrustAssembly_StrongNameMembershipCondition;
		public virtual RMethod RAddFullTrustAssembly_StrongNameMembershipCondition
		{
			get
			{
				if(r_AddFullTrustAssembly_StrongNameMembershipCondition == null)
				{
					r_AddFullTrustAssembly_StrongNameMembershipCondition = new(this, "AddFullTrustAssembly", 0, typeof(System.Security.Policy.StrongNameMembershipCondition));
					r_AddFullTrustAssembly_StrongNameMembershipCondition.SetBelong(this.instance);
				}
				return r_AddFullTrustAssembly_StrongNameMembershipCondition;
			}
		}

		/// <summary>
		/// Void AddNamedPermissionSet(System.Security.NamedPermissionSet)
		/// </summary>
		protected RMethod r_AddNamedPermissionSet_NamedPermissionSet;
		public virtual RMethod RAddNamedPermissionSet_NamedPermissionSet
		{
			get
			{
				if(r_AddNamedPermissionSet_NamedPermissionSet == null)
				{
					r_AddNamedPermissionSet_NamedPermissionSet = new(this, "AddNamedPermissionSet", 0, typeof(System.Security.NamedPermissionSet));
					r_AddNamedPermissionSet_NamedPermissionSet.SetBelong(this.instance);
				}
				return r_AddNamedPermissionSet_NamedPermissionSet;
			}
		}

		/// <summary>
		/// System.Security.NamedPermissionSet ChangeNamedPermissionSet(System.String, System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_ChangeNamedPermissionSet_String_PermissionSet;
		public virtual RMethod RChangeNamedPermissionSet_String_PermissionSet
		{
			get
			{
				if(r_ChangeNamedPermissionSet_String_PermissionSet == null)
				{
					r_ChangeNamedPermissionSet_String_PermissionSet = new(this, "ChangeNamedPermissionSet", 0, typeof(System.String), typeof(System.Security.PermissionSet));
					r_ChangeNamedPermissionSet_String_PermissionSet.SetBelong(this.instance);
				}
				return r_ChangeNamedPermissionSet_String_PermissionSet;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyLevel CreateAppDomainLevel()
		/// </summary>
		protected static RMethod r_CreateAppDomainLevel;
		public static RMethod RCreateAppDomainLevel
		{
			get
			{
				if(r_CreateAppDomainLevel == null)
				{
					r_CreateAppDomainLevel = new(typeof(System.Security.Policy.PolicyLevel), "CreateAppDomainLevel", 0);
					r_CreateAppDomainLevel.SetBelong(null);
				}
				return r_CreateAppDomainLevel;
			}
		}

		/// <summary>
		/// Void FromXml(System.Security.SecurityElement)
		/// </summary>
		protected RMethod r_FromXml_SecurityElement;
		public virtual RMethod RFromXml_SecurityElement
		{
			get
			{
				if(r_FromXml_SecurityElement == null)
				{
					r_FromXml_SecurityElement = new(this, "FromXml", 0, typeof(System.Security.SecurityElement));
					r_FromXml_SecurityElement.SetBelong(this.instance);
				}
				return r_FromXml_SecurityElement;
			}
		}

		/// <summary>
		/// System.Security.NamedPermissionSet GetNamedPermissionSet(System.String)
		/// </summary>
		protected RMethod r_GetNamedPermissionSet_String;
		public virtual RMethod RGetNamedPermissionSet_String
		{
			get
			{
				if(r_GetNamedPermissionSet_String == null)
				{
					r_GetNamedPermissionSet_String = new(this, "GetNamedPermissionSet", 0, typeof(System.String));
					r_GetNamedPermissionSet_String.SetBelong(this.instance);
				}
				return r_GetNamedPermissionSet_String;
			}
		}

		/// <summary>
		/// Void Recover()
		/// </summary>
		protected RMethod r_Recover;
		public virtual RMethod RRecover
		{
			get
			{
				if(r_Recover == null)
				{
					r_Recover = new(this, "Recover", 0);
					r_Recover.SetBelong(this.instance);
				}
				return r_Recover;
			}
		}

		/// <summary>
		/// Void RemoveFullTrustAssembly(System.Security.Policy.StrongName)
		/// </summary>
		protected RMethod r_RemoveFullTrustAssembly_StrongName;
		public virtual RMethod RRemoveFullTrustAssembly_StrongName
		{
			get
			{
				if(r_RemoveFullTrustAssembly_StrongName == null)
				{
					r_RemoveFullTrustAssembly_StrongName = new(this, "RemoveFullTrustAssembly", 0, typeof(System.Security.Policy.StrongName));
					r_RemoveFullTrustAssembly_StrongName.SetBelong(this.instance);
				}
				return r_RemoveFullTrustAssembly_StrongName;
			}
		}

		/// <summary>
		/// Void RemoveFullTrustAssembly(System.Security.Policy.StrongNameMembershipCondition)
		/// </summary>
		protected RMethod r_RemoveFullTrustAssembly_StrongNameMembershipCondition;
		public virtual RMethod RRemoveFullTrustAssembly_StrongNameMembershipCondition
		{
			get
			{
				if(r_RemoveFullTrustAssembly_StrongNameMembershipCondition == null)
				{
					r_RemoveFullTrustAssembly_StrongNameMembershipCondition = new(this, "RemoveFullTrustAssembly", 0, typeof(System.Security.Policy.StrongNameMembershipCondition));
					r_RemoveFullTrustAssembly_StrongNameMembershipCondition.SetBelong(this.instance);
				}
				return r_RemoveFullTrustAssembly_StrongNameMembershipCondition;
			}
		}

		/// <summary>
		/// System.Security.NamedPermissionSet RemoveNamedPermissionSet(System.Security.NamedPermissionSet)
		/// </summary>
		protected RMethod r_RemoveNamedPermissionSet_NamedPermissionSet;
		public virtual RMethod RRemoveNamedPermissionSet_NamedPermissionSet
		{
			get
			{
				if(r_RemoveNamedPermissionSet_NamedPermissionSet == null)
				{
					r_RemoveNamedPermissionSet_NamedPermissionSet = new(this, "RemoveNamedPermissionSet", 0, typeof(System.Security.NamedPermissionSet));
					r_RemoveNamedPermissionSet_NamedPermissionSet.SetBelong(this.instance);
				}
				return r_RemoveNamedPermissionSet_NamedPermissionSet;
			}
		}

		/// <summary>
		/// System.Security.NamedPermissionSet RemoveNamedPermissionSet(System.String)
		/// </summary>
		protected RMethod r_RemoveNamedPermissionSet_String;
		public virtual RMethod RRemoveNamedPermissionSet_String
		{
			get
			{
				if(r_RemoveNamedPermissionSet_String == null)
				{
					r_RemoveNamedPermissionSet_String = new(this, "RemoveNamedPermissionSet", 0, typeof(System.String));
					r_RemoveNamedPermissionSet_String.SetBelong(this.instance);
				}
				return r_RemoveNamedPermissionSet_String;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_Reset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_Reset == null)
				{
					r_Reset = new(this, "Reset", 0);
					r_Reset.SetBelong(this.instance);
				}
				return r_Reset;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_Resolve_Evidence;
		public virtual RMethod RResolve_Evidence
		{
			get
			{
				if(r_Resolve_Evidence == null)
				{
					r_Resolve_Evidence = new(this, "Resolve", 0, typeof(System.Security.Policy.Evidence));
					r_Resolve_Evidence.SetBelong(this.instance);
				}
				return r_Resolve_Evidence;
			}
		}

		/// <summary>
		/// System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence)
		/// </summary>
		protected RMethod r_ResolveMatchingCodeGroups_Evidence;
		public virtual RMethod RResolveMatchingCodeGroups_Evidence
		{
			get
			{
				if(r_ResolveMatchingCodeGroups_Evidence == null)
				{
					r_ResolveMatchingCodeGroups_Evidence = new(this, "ResolveMatchingCodeGroups", 0, typeof(System.Security.Policy.Evidence));
					r_ResolveMatchingCodeGroups_Evidence.SetBelong(this.instance);
				}
				return r_ResolveMatchingCodeGroups_Evidence;
			}
		}

		/// <summary>
		/// System.Security.SecurityElement ToXml()
		/// </summary>
		protected RMethod r_ToXml;
		public virtual RMethod RToXml
		{
			get
			{
				if(r_ToXml == null)
				{
					r_ToXml = new(this, "ToXml", 0);
					r_ToXml.SetBelong(this.instance);
				}
				return r_ToXml;
			}
		}

		/// <summary>
		/// Void Save()
		/// </summary>
		protected RMethod r_Save;
		public virtual RMethod RSave
		{
			get
			{
				if(r_Save == null)
				{
					r_Save = new(this, "Save", 0);
					r_Save.SetBelong(this.instance);
				}
				return r_Save;
			}
		}

		/// <summary>
		/// Void CreateDefaultLevel(System.Security.PolicyLevelType)
		/// </summary>
		protected RMethod r_CreateDefaultLevel_PolicyLevelType;
		public virtual RMethod RCreateDefaultLevel_PolicyLevelType
		{
			get
			{
				if(r_CreateDefaultLevel_PolicyLevelType == null)
				{
					r_CreateDefaultLevel_PolicyLevelType = new(this, "CreateDefaultLevel", 0, typeof(System.Security.PolicyLevelType));
					r_CreateDefaultLevel_PolicyLevelType.SetBelong(this.instance);
				}
				return r_CreateDefaultLevel_PolicyLevelType;
			}
		}

		/// <summary>
		/// Void CreateDefaultFullTrustAssemblies()
		/// </summary>
		protected RMethod r_CreateDefaultFullTrustAssemblies;
		public virtual RMethod RCreateDefaultFullTrustAssemblies
		{
			get
			{
				if(r_CreateDefaultFullTrustAssemblies == null)
				{
					r_CreateDefaultFullTrustAssemblies = new(this, "CreateDefaultFullTrustAssemblies", 0);
					r_CreateDefaultFullTrustAssemblies.SetBelong(this.instance);
				}
				return r_CreateDefaultFullTrustAssemblies;
			}
		}

		/// <summary>
		/// Void CreateDefaultNamedPermissionSets()
		/// </summary>
		protected RMethod r_CreateDefaultNamedPermissionSets;
		public virtual RMethod RCreateDefaultNamedPermissionSets
		{
			get
			{
				if(r_CreateDefaultNamedPermissionSets == null)
				{
					r_CreateDefaultNamedPermissionSets = new(this, "CreateDefaultNamedPermissionSets", 0);
					r_CreateDefaultNamedPermissionSets.SetBelong(this.instance);
				}
				return r_CreateDefaultNamedPermissionSets;
			}
		}

		/// <summary>
		/// System.String ResolveClassName(System.String)
		/// </summary>
		protected RMethod r_ResolveClassName_String;
		public virtual RMethod RResolveClassName_String
		{
			get
			{
				if(r_ResolveClassName_String == null)
				{
					r_ResolveClassName_String = new(this, "ResolveClassName", 0, typeof(System.String));
					r_ResolveClassName_String.SetBelong(this.instance);
				}
				return r_ResolveClassName_String;
			}
		}

		/// <summary>
		/// Boolean IsFullTrustAssembly(System.Reflection.Assembly)
		/// </summary>
		protected RMethod r_IsFullTrustAssembly_Assembly;
		public virtual RMethod RIsFullTrustAssembly_Assembly
		{
			get
			{
				if(r_IsFullTrustAssembly_Assembly == null)
				{
					r_IsFullTrustAssembly_Assembly = new(this, "IsFullTrustAssembly", 0, typeof(System.Reflection.Assembly));
					r_IsFullTrustAssembly_Assembly.SetBelong(this.instance);
				}
				return r_IsFullTrustAssembly_Assembly;
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

        public virtual void LoadFromFile(System.String  @filename)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filename};
            var ___result = RLoadFromFile_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadFromString(System.String  @xml)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xml};
            var ___result = RLoadFromString_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.SecurityElement FromString(System.String  @xml)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xml};
            var ___result = RFromString_String.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
        }


        public virtual void AddFullTrustAssembly(System.Security.Policy.StrongName  @sn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sn};
            var ___result = RAddFullTrustAssembly_StrongName.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddFullTrustAssembly(System.Security.Policy.StrongNameMembershipCondition  @snMC)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@snMC};
            var ___result = RAddFullTrustAssembly_StrongNameMembershipCondition.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddNamedPermissionSet(System.Security.NamedPermissionSet  @permSet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permSet};
            var ___result = RAddNamedPermissionSet_NamedPermissionSet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.NamedPermissionSet ChangeNamedPermissionSet(System.String  @name, System.Security.PermissionSet  @pSet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @pSet};
            var ___result = RChangeNamedPermissionSet_String_PermissionSet.Invoke(___genericsType, ___parameters);

            return (System.Security.NamedPermissionSet)___result;
        }


        public static System.Security.Policy.PolicyLevel CreateAppDomainLevel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateAppDomainLevel.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.PolicyLevel)___result;
        }


        public virtual void FromXml(System.Security.SecurityElement  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RFromXml_SecurityElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.NamedPermissionSet GetNamedPermissionSet(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetNamedPermissionSet_String.Invoke(___genericsType, ___parameters);

            return (System.Security.NamedPermissionSet)___result;
        }


        public virtual void Recover()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRecover.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFullTrustAssembly(System.Security.Policy.StrongName  @sn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sn};
            var ___result = RRemoveFullTrustAssembly_StrongName.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFullTrustAssembly(System.Security.Policy.StrongNameMembershipCondition  @snMC)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@snMC};
            var ___result = RRemoveFullTrustAssembly_StrongNameMembershipCondition.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.NamedPermissionSet RemoveNamedPermissionSet(System.Security.NamedPermissionSet  @permSet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@permSet};
            var ___result = RRemoveNamedPermissionSet_NamedPermissionSet.Invoke(___genericsType, ___parameters);

            return (System.Security.NamedPermissionSet)___result;
        }


        public virtual System.Security.NamedPermissionSet RemoveNamedPermissionSet(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RRemoveNamedPermissionSet_String.Invoke(___genericsType, ___parameters);

            return (System.Security.NamedPermissionSet)___result;
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.Policy.PolicyStatement Resolve(System.Security.Policy.Evidence  @evidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evidence};
            var ___result = RResolve_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.PolicyStatement)___result;
        }


        public virtual System.Security.Policy.CodeGroup ResolveMatchingCodeGroups(System.Security.Policy.Evidence  @evidence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evidence};
            var ___result = RResolveMatchingCodeGroups_Evidence.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.CodeGroup)___result;
        }


        public virtual System.Security.SecurityElement ToXml()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToXml.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
        }


        public virtual void Save()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSave.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CreateDefaultLevel(System.Security.PolicyLevelType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RCreateDefaultLevel_PolicyLevelType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CreateDefaultFullTrustAssemblies()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateDefaultFullTrustAssemblies.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CreateDefaultNamedPermissionSets()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateDefaultNamedPermissionSets.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ResolveClassName(System.String  @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RResolveClassName_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean IsFullTrustAssembly(System.Reflection.Assembly  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RIsFullTrustAssembly_Assembly.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
