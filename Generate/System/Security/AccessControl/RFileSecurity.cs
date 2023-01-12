using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.FileSecurity
	/// </summary>
    public partial class RFileSecurity : RMember //
    {

		/// <summary>
		/// System.Security.AccessControl.CommonSecurityDescriptor descriptor
		/// </summary>
		protected RSystem.RSecurity.RAccessControl.RCommonSecurityDescriptor r_Fdescriptor;
		public virtual RSystem.RSecurity.RAccessControl.RCommonSecurityDescriptor RFdescriptor
		{
			get
			{
				if(r_Fdescriptor == null)
				{
					r_Fdescriptor = new(this, "descriptor");
					r_Fdescriptor.SetBelong(this.instance);
				}
				return r_Fdescriptor;
			}
		}

		/// <summary>
		/// System.Type AccessRightType
		/// </summary>
		protected RSystem.RType r_PAccessRightType;
		public virtual RSystem.RType RPAccessRightType
		{
			get
			{
				if(r_PAccessRightType == null)
				{
					r_PAccessRightType = new(this, "AccessRightType", -1);
					r_PAccessRightType.SetBelong(this.instance);
				}
				return r_PAccessRightType;
			}
		}

		/// <summary>
		/// System.Type AccessRuleType
		/// </summary>
		protected RSystem.RType r_PAccessRuleType;
		public virtual RSystem.RType RPAccessRuleType
		{
			get
			{
				if(r_PAccessRuleType == null)
				{
					r_PAccessRuleType = new(this, "AccessRuleType", -1);
					r_PAccessRuleType.SetBelong(this.instance);
				}
				return r_PAccessRuleType;
			}
		}

		/// <summary>
		/// System.Type AuditRuleType
		/// </summary>
		protected RSystem.RType r_PAuditRuleType;
		public virtual RSystem.RType RPAuditRuleType
		{
			get
			{
				if(r_PAuditRuleType == null)
				{
					r_PAuditRuleType = new(this, "AuditRuleType", -1);
					r_PAuditRuleType.SetBelong(this.instance);
				}
				return r_PAuditRuleType;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ResourceType ResourceType
		/// </summary>
		protected RSystem.RSecurity.RAccessControl.RResourceType r_PResourceType;
		public virtual RSystem.RSecurity.RAccessControl.RResourceType RPResourceType
		{
			get
			{
				if(r_PResourceType == null)
				{
					r_PResourceType = new(this, "ResourceType", -1);
					r_PResourceType.SetBelong(this.instance);
				}
				return r_PResourceType;
			}
		}

		/// <summary>
		/// Boolean AreAccessRulesCanonical
		/// </summary>
		protected RSystem.RBoolean r_PAreAccessRulesCanonical;
		public virtual RSystem.RBoolean RPAreAccessRulesCanonical
		{
			get
			{
				if(r_PAreAccessRulesCanonical == null)
				{
					r_PAreAccessRulesCanonical = new(this, "AreAccessRulesCanonical", -1);
					r_PAreAccessRulesCanonical.SetBelong(this.instance);
				}
				return r_PAreAccessRulesCanonical;
			}
		}

		/// <summary>
		/// Boolean AreAccessRulesProtected
		/// </summary>
		protected RSystem.RBoolean r_PAreAccessRulesProtected;
		public virtual RSystem.RBoolean RPAreAccessRulesProtected
		{
			get
			{
				if(r_PAreAccessRulesProtected == null)
				{
					r_PAreAccessRulesProtected = new(this, "AreAccessRulesProtected", -1);
					r_PAreAccessRulesProtected.SetBelong(this.instance);
				}
				return r_PAreAccessRulesProtected;
			}
		}

		/// <summary>
		/// Boolean AreAuditRulesCanonical
		/// </summary>
		protected RSystem.RBoolean r_PAreAuditRulesCanonical;
		public virtual RSystem.RBoolean RPAreAuditRulesCanonical
		{
			get
			{
				if(r_PAreAuditRulesCanonical == null)
				{
					r_PAreAuditRulesCanonical = new(this, "AreAuditRulesCanonical", -1);
					r_PAreAuditRulesCanonical.SetBelong(this.instance);
				}
				return r_PAreAuditRulesCanonical;
			}
		}

		/// <summary>
		/// Boolean AreAuditRulesProtected
		/// </summary>
		protected RSystem.RBoolean r_PAreAuditRulesProtected;
		public virtual RSystem.RBoolean RPAreAuditRulesProtected
		{
			get
			{
				if(r_PAreAuditRulesProtected == null)
				{
					r_PAreAuditRulesProtected = new(this, "AreAuditRulesProtected", -1);
					r_PAreAuditRulesProtected.SetBelong(this.instance);
				}
				return r_PAreAuditRulesProtected;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AccessControlSections AccessControlSectionsModified
		/// </summary>
		protected RSystem.RSecurity.RAccessControl.RAccessControlSections r_PAccessControlSectionsModified;
		public virtual RSystem.RSecurity.RAccessControl.RAccessControlSections RPAccessControlSectionsModified
		{
			get
			{
				if(r_PAccessControlSectionsModified == null)
				{
					r_PAccessControlSectionsModified = new(this, "AccessControlSectionsModified", -1);
					r_PAccessControlSectionsModified.SetBelong(this.instance);
				}
				return r_PAccessControlSectionsModified;
			}
		}

		/// <summary>
		/// Boolean AccessRulesModified
		/// </summary>
		protected RSystem.RBoolean r_PAccessRulesModified;
		public virtual RSystem.RBoolean RPAccessRulesModified
		{
			get
			{
				if(r_PAccessRulesModified == null)
				{
					r_PAccessRulesModified = new(this, "AccessRulesModified", -1);
					r_PAccessRulesModified.SetBelong(this.instance);
				}
				return r_PAccessRulesModified;
			}
		}

		/// <summary>
		/// Boolean AuditRulesModified
		/// </summary>
		protected RSystem.RBoolean r_PAuditRulesModified;
		public virtual RSystem.RBoolean RPAuditRulesModified
		{
			get
			{
				if(r_PAuditRulesModified == null)
				{
					r_PAuditRulesModified = new(this, "AuditRulesModified", -1);
					r_PAuditRulesModified.SetBelong(this.instance);
				}
				return r_PAuditRulesModified;
			}
		}

		/// <summary>
		/// Boolean GroupModified
		/// </summary>
		protected RSystem.RBoolean r_PGroupModified;
		public virtual RSystem.RBoolean RPGroupModified
		{
			get
			{
				if(r_PGroupModified == null)
				{
					r_PGroupModified = new(this, "GroupModified", -1);
					r_PGroupModified.SetBelong(this.instance);
				}
				return r_PGroupModified;
			}
		}

		/// <summary>
		/// Boolean IsContainer
		/// </summary>
		protected RSystem.RBoolean r_PIsContainer;
		public virtual RSystem.RBoolean RPIsContainer
		{
			get
			{
				if(r_PIsContainer == null)
				{
					r_PIsContainer = new(this, "IsContainer", -1);
					r_PIsContainer.SetBelong(this.instance);
				}
				return r_PIsContainer;
			}
		}

		/// <summary>
		/// Boolean IsDS
		/// </summary>
		protected RSystem.RBoolean r_PIsDS;
		public virtual RSystem.RBoolean RPIsDS
		{
			get
			{
				if(r_PIsDS == null)
				{
					r_PIsDS = new(this, "IsDS", -1);
					r_PIsDS.SetBelong(this.instance);
				}
				return r_PIsDS;
			}
		}

		/// <summary>
		/// Boolean OwnerModified
		/// </summary>
		protected RSystem.RBoolean r_POwnerModified;
		public virtual RSystem.RBoolean RPOwnerModified
		{
			get
			{
				if(r_POwnerModified == null)
				{
					r_POwnerModified = new(this, "OwnerModified", -1);
					r_POwnerModified.SetBelong(this.instance);
				}
				return r_POwnerModified;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference, Int32, Boolean, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AccessControlType)
		/// </summary>
		protected RMethod r_MAccessRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AccessControlType;
		public virtual RMethod RMAccessRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AccessControlType
		{
			get
			{
				if(r_MAccessRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AccessControlType == null)
				{
					r_MAccessRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AccessControlType = new(this, "AccessRuleFactory", 0, typeof(System.Security.Principal.IdentityReference), typeof(System.Int32), typeof(System.Boolean), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AccessControlType));
					r_MAccessRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AccessControlType.SetBelong(this.instance);
				}
				return r_MAccessRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AccessControlType;
			}
		}

		/// <summary>
		/// Void AddAccessRule(System.Security.AccessControl.FileSystemAccessRule)
		/// </summary>
		protected RMethod r_MAddAccessRule_FileSystemAccessRule;
		public virtual RMethod RMAddAccessRule_FileSystemAccessRule
		{
			get
			{
				if(r_MAddAccessRule_FileSystemAccessRule == null)
				{
					r_MAddAccessRule_FileSystemAccessRule = new(this, "AddAccessRule", 0, typeof(System.Security.AccessControl.FileSystemAccessRule));
					r_MAddAccessRule_FileSystemAccessRule.SetBelong(this.instance);
				}
				return r_MAddAccessRule_FileSystemAccessRule;
			}
		}

		/// <summary>
		/// Boolean RemoveAccessRule(System.Security.AccessControl.FileSystemAccessRule)
		/// </summary>
		protected RMethod r_MRemoveAccessRule_FileSystemAccessRule;
		public virtual RMethod RMRemoveAccessRule_FileSystemAccessRule
		{
			get
			{
				if(r_MRemoveAccessRule_FileSystemAccessRule == null)
				{
					r_MRemoveAccessRule_FileSystemAccessRule = new(this, "RemoveAccessRule", 0, typeof(System.Security.AccessControl.FileSystemAccessRule));
					r_MRemoveAccessRule_FileSystemAccessRule.SetBelong(this.instance);
				}
				return r_MRemoveAccessRule_FileSystemAccessRule;
			}
		}

		/// <summary>
		/// Void RemoveAccessRuleAll(System.Security.AccessControl.FileSystemAccessRule)
		/// </summary>
		protected RMethod r_MRemoveAccessRuleAll_FileSystemAccessRule;
		public virtual RMethod RMRemoveAccessRuleAll_FileSystemAccessRule
		{
			get
			{
				if(r_MRemoveAccessRuleAll_FileSystemAccessRule == null)
				{
					r_MRemoveAccessRuleAll_FileSystemAccessRule = new(this, "RemoveAccessRuleAll", 0, typeof(System.Security.AccessControl.FileSystemAccessRule));
					r_MRemoveAccessRuleAll_FileSystemAccessRule.SetBelong(this.instance);
				}
				return r_MRemoveAccessRuleAll_FileSystemAccessRule;
			}
		}

		/// <summary>
		/// Void RemoveAccessRuleSpecific(System.Security.AccessControl.FileSystemAccessRule)
		/// </summary>
		protected RMethod r_MRemoveAccessRuleSpecific_FileSystemAccessRule;
		public virtual RMethod RMRemoveAccessRuleSpecific_FileSystemAccessRule
		{
			get
			{
				if(r_MRemoveAccessRuleSpecific_FileSystemAccessRule == null)
				{
					r_MRemoveAccessRuleSpecific_FileSystemAccessRule = new(this, "RemoveAccessRuleSpecific", 0, typeof(System.Security.AccessControl.FileSystemAccessRule));
					r_MRemoveAccessRuleSpecific_FileSystemAccessRule.SetBelong(this.instance);
				}
				return r_MRemoveAccessRuleSpecific_FileSystemAccessRule;
			}
		}

		/// <summary>
		/// Void ResetAccessRule(System.Security.AccessControl.FileSystemAccessRule)
		/// </summary>
		protected RMethod r_MResetAccessRule_FileSystemAccessRule;
		public virtual RMethod RMResetAccessRule_FileSystemAccessRule
		{
			get
			{
				if(r_MResetAccessRule_FileSystemAccessRule == null)
				{
					r_MResetAccessRule_FileSystemAccessRule = new(this, "ResetAccessRule", 0, typeof(System.Security.AccessControl.FileSystemAccessRule));
					r_MResetAccessRule_FileSystemAccessRule.SetBelong(this.instance);
				}
				return r_MResetAccessRule_FileSystemAccessRule;
			}
		}

		/// <summary>
		/// Void SetAccessRule(System.Security.AccessControl.FileSystemAccessRule)
		/// </summary>
		protected RMethod r_MSetAccessRule_FileSystemAccessRule;
		public virtual RMethod RMSetAccessRule_FileSystemAccessRule
		{
			get
			{
				if(r_MSetAccessRule_FileSystemAccessRule == null)
				{
					r_MSetAccessRule_FileSystemAccessRule = new(this, "SetAccessRule", 0, typeof(System.Security.AccessControl.FileSystemAccessRule));
					r_MSetAccessRule_FileSystemAccessRule.SetBelong(this.instance);
				}
				return r_MSetAccessRule_FileSystemAccessRule;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference, Int32, Boolean, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags)
		/// </summary>
		protected RMethod r_MAuditRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AuditFlags;
		public virtual RMethod RMAuditRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AuditFlags
		{
			get
			{
				if(r_MAuditRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AuditFlags == null)
				{
					r_MAuditRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AuditFlags = new(this, "AuditRuleFactory", 0, typeof(System.Security.Principal.IdentityReference), typeof(System.Int32), typeof(System.Boolean), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags));
					r_MAuditRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AuditFlags.SetBelong(this.instance);
				}
				return r_MAuditRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AuditFlags;
			}
		}

		/// <summary>
		/// Void AddAuditRule(System.Security.AccessControl.FileSystemAuditRule)
		/// </summary>
		protected RMethod r_MAddAuditRule_FileSystemAuditRule;
		public virtual RMethod RMAddAuditRule_FileSystemAuditRule
		{
			get
			{
				if(r_MAddAuditRule_FileSystemAuditRule == null)
				{
					r_MAddAuditRule_FileSystemAuditRule = new(this, "AddAuditRule", 0, typeof(System.Security.AccessControl.FileSystemAuditRule));
					r_MAddAuditRule_FileSystemAuditRule.SetBelong(this.instance);
				}
				return r_MAddAuditRule_FileSystemAuditRule;
			}
		}

		/// <summary>
		/// Boolean RemoveAuditRule(System.Security.AccessControl.FileSystemAuditRule)
		/// </summary>
		protected RMethod r_MRemoveAuditRule_FileSystemAuditRule;
		public virtual RMethod RMRemoveAuditRule_FileSystemAuditRule
		{
			get
			{
				if(r_MRemoveAuditRule_FileSystemAuditRule == null)
				{
					r_MRemoveAuditRule_FileSystemAuditRule = new(this, "RemoveAuditRule", 0, typeof(System.Security.AccessControl.FileSystemAuditRule));
					r_MRemoveAuditRule_FileSystemAuditRule.SetBelong(this.instance);
				}
				return r_MRemoveAuditRule_FileSystemAuditRule;
			}
		}

		/// <summary>
		/// Void RemoveAuditRuleAll(System.Security.AccessControl.FileSystemAuditRule)
		/// </summary>
		protected RMethod r_MRemoveAuditRuleAll_FileSystemAuditRule;
		public virtual RMethod RMRemoveAuditRuleAll_FileSystemAuditRule
		{
			get
			{
				if(r_MRemoveAuditRuleAll_FileSystemAuditRule == null)
				{
					r_MRemoveAuditRuleAll_FileSystemAuditRule = new(this, "RemoveAuditRuleAll", 0, typeof(System.Security.AccessControl.FileSystemAuditRule));
					r_MRemoveAuditRuleAll_FileSystemAuditRule.SetBelong(this.instance);
				}
				return r_MRemoveAuditRuleAll_FileSystemAuditRule;
			}
		}

		/// <summary>
		/// Void RemoveAuditRuleSpecific(System.Security.AccessControl.FileSystemAuditRule)
		/// </summary>
		protected RMethod r_MRemoveAuditRuleSpecific_FileSystemAuditRule;
		public virtual RMethod RMRemoveAuditRuleSpecific_FileSystemAuditRule
		{
			get
			{
				if(r_MRemoveAuditRuleSpecific_FileSystemAuditRule == null)
				{
					r_MRemoveAuditRuleSpecific_FileSystemAuditRule = new(this, "RemoveAuditRuleSpecific", 0, typeof(System.Security.AccessControl.FileSystemAuditRule));
					r_MRemoveAuditRuleSpecific_FileSystemAuditRule.SetBelong(this.instance);
				}
				return r_MRemoveAuditRuleSpecific_FileSystemAuditRule;
			}
		}

		/// <summary>
		/// Void SetAuditRule(System.Security.AccessControl.FileSystemAuditRule)
		/// </summary>
		protected RMethod r_MSetAuditRule_FileSystemAuditRule;
		public virtual RMethod RMSetAuditRule_FileSystemAuditRule
		{
			get
			{
				if(r_MSetAuditRule_FileSystemAuditRule == null)
				{
					r_MSetAuditRule_FileSystemAuditRule = new(this, "SetAuditRule", 0, typeof(System.Security.AccessControl.FileSystemAuditRule));
					r_MSetAuditRule_FileSystemAuditRule.SetBelong(this.instance);
				}
				return r_MSetAuditRule_FileSystemAuditRule;
			}
		}

		/// <summary>
		/// Void Persist(System.Runtime.InteropServices.SafeHandle, System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_MPersist_SafeHandle_AccessControlSections;
		public virtual RMethod RMPersist_SafeHandle_AccessControlSections
		{
			get
			{
				if(r_MPersist_SafeHandle_AccessControlSections == null)
				{
					r_MPersist_SafeHandle_AccessControlSections = new(this, "Persist", 0, typeof(System.Runtime.InteropServices.SafeHandle), typeof(System.Security.AccessControl.AccessControlSections));
					r_MPersist_SafeHandle_AccessControlSections.SetBelong(this.instance);
				}
				return r_MPersist_SafeHandle_AccessControlSections;
			}
		}

		/// <summary>
		/// Void Persist(System.String, System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_MPersist_String_AccessControlSections;
		public virtual RMethod RMPersist_String_AccessControlSections
		{
			get
			{
				if(r_MPersist_String_AccessControlSections == null)
				{
					r_MPersist_String_AccessControlSections = new(this, "Persist", 0, typeof(System.String), typeof(System.Security.AccessControl.AccessControlSections));
					r_MPersist_String_AccessControlSections.SetBelong(this.instance);
				}
				return r_MPersist_String_AccessControlSections;
			}
		}

		/// <summary>
		/// Void PersistModifications(System.Runtime.InteropServices.SafeHandle)
		/// </summary>
		protected RMethod r_MPersistModifications_SafeHandle;
		public virtual RMethod RMPersistModifications_SafeHandle
		{
			get
			{
				if(r_MPersistModifications_SafeHandle == null)
				{
					r_MPersistModifications_SafeHandle = new(this, "PersistModifications", 0, typeof(System.Runtime.InteropServices.SafeHandle));
					r_MPersistModifications_SafeHandle.SetBelong(this.instance);
				}
				return r_MPersistModifications_SafeHandle;
			}
		}

		/// <summary>
		/// Void Persist(System.Runtime.InteropServices.SafeHandle, System.Security.AccessControl.AccessControlSections, System.Object)
		/// </summary>
		protected RMethod r_MPersist_SafeHandle_AccessControlSections_Object;
		public virtual RMethod RMPersist_SafeHandle_AccessControlSections_Object
		{
			get
			{
				if(r_MPersist_SafeHandle_AccessControlSections_Object == null)
				{
					r_MPersist_SafeHandle_AccessControlSections_Object = new(this, "Persist", 0, typeof(System.Runtime.InteropServices.SafeHandle), typeof(System.Security.AccessControl.AccessControlSections), typeof(System.Object));
					r_MPersist_SafeHandle_AccessControlSections_Object.SetBelong(this.instance);
				}
				return r_MPersist_SafeHandle_AccessControlSections_Object;
			}
		}

		/// <summary>
		/// Void PersistModifications(System.String)
		/// </summary>
		protected RMethod r_MPersistModifications_String;
		public virtual RMethod RMPersistModifications_String
		{
			get
			{
				if(r_MPersistModifications_String == null)
				{
					r_MPersistModifications_String = new(this, "PersistModifications", 0, typeof(System.String));
					r_MPersistModifications_String.SetBelong(this.instance);
				}
				return r_MPersistModifications_String;
			}
		}

		/// <summary>
		/// Void Persist(System.String, System.Security.AccessControl.AccessControlSections, System.Object)
		/// </summary>
		protected RMethod r_MPersist_String_AccessControlSections_Object;
		public virtual RMethod RMPersist_String_AccessControlSections_Object
		{
			get
			{
				if(r_MPersist_String_AccessControlSections_Object == null)
				{
					r_MPersist_String_AccessControlSections_Object = new(this, "Persist", 0, typeof(System.String), typeof(System.Security.AccessControl.AccessControlSections), typeof(System.Object));
					r_MPersist_String_AccessControlSections_Object.SetBelong(this.instance);
				}
				return r_MPersist_String_AccessControlSections_Object;
			}
		}

		/// <summary>
		/// Int32 InternalGet(System.Runtime.InteropServices.SafeHandle, System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_MInternalGet_SafeHandle_AccessControlSections;
		public virtual RMethod RMInternalGet_SafeHandle_AccessControlSections
		{
			get
			{
				if(r_MInternalGet_SafeHandle_AccessControlSections == null)
				{
					r_MInternalGet_SafeHandle_AccessControlSections = new(this, "InternalGet", 0, typeof(System.Runtime.InteropServices.SafeHandle), typeof(System.Security.AccessControl.AccessControlSections));
					r_MInternalGet_SafeHandle_AccessControlSections.SetBelong(this.instance);
				}
				return r_MInternalGet_SafeHandle_AccessControlSections;
			}
		}

		/// <summary>
		/// Int32 InternalGet(System.String, System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_MInternalGet_String_AccessControlSections;
		public virtual RMethod RMInternalGet_String_AccessControlSections
		{
			get
			{
				if(r_MInternalGet_String_AccessControlSections == null)
				{
					r_MInternalGet_String_AccessControlSections = new(this, "InternalGet", 0, typeof(System.String), typeof(System.Security.AccessControl.AccessControlSections));
					r_MInternalGet_String_AccessControlSections.SetBelong(this.instance);
				}
				return r_MInternalGet_String_AccessControlSections;
			}
		}

		/// <summary>
		/// Int32 InternalSet(System.Runtime.InteropServices.SafeHandle, System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_MInternalSet_SafeHandle_AccessControlSections;
		public virtual RMethod RMInternalSet_SafeHandle_AccessControlSections
		{
			get
			{
				if(r_MInternalSet_SafeHandle_AccessControlSections == null)
				{
					r_MInternalSet_SafeHandle_AccessControlSections = new(this, "InternalSet", 0, typeof(System.Runtime.InteropServices.SafeHandle), typeof(System.Security.AccessControl.AccessControlSections));
					r_MInternalSet_SafeHandle_AccessControlSections.SetBelong(this.instance);
				}
				return r_MInternalSet_SafeHandle_AccessControlSections;
			}
		}

		/// <summary>
		/// Int32 InternalSet(System.String, System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_MInternalSet_String_AccessControlSections;
		public virtual RMethod RMInternalSet_String_AccessControlSections
		{
			get
			{
				if(r_MInternalSet_String_AccessControlSections == null)
				{
					r_MInternalSet_String_AccessControlSections = new(this, "InternalSet", 0, typeof(System.String), typeof(System.Security.AccessControl.AccessControlSections));
					r_MInternalSet_String_AccessControlSections.SetBelong(this.instance);
				}
				return r_MInternalSet_String_AccessControlSections;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AuthorizationRuleCollection GetAccessRules(Boolean, Boolean, System.Type)
		/// </summary>
		protected RMethod r_MGetAccessRules_Boolean_Boolean_Type;
		public virtual RMethod RMGetAccessRules_Boolean_Boolean_Type
		{
			get
			{
				if(r_MGetAccessRules_Boolean_Boolean_Type == null)
				{
					r_MGetAccessRules_Boolean_Boolean_Type = new(this, "GetAccessRules", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Type));
					r_MGetAccessRules_Boolean_Boolean_Type.SetBelong(this.instance);
				}
				return r_MGetAccessRules_Boolean_Boolean_Type;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AuthorizationRuleCollection GetAuditRules(Boolean, Boolean, System.Type)
		/// </summary>
		protected RMethod r_MGetAuditRules_Boolean_Boolean_Type;
		public virtual RMethod RMGetAuditRules_Boolean_Boolean_Type
		{
			get
			{
				if(r_MGetAuditRules_Boolean_Boolean_Type == null)
				{
					r_MGetAuditRules_Boolean_Boolean_Type = new(this, "GetAuditRules", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Type));
					r_MGetAuditRules_Boolean_Boolean_Type.SetBelong(this.instance);
				}
				return r_MGetAuditRules_Boolean_Boolean_Type;
			}
		}

		/// <summary>
		/// Void AddAccessRule(System.Security.AccessControl.AccessRule)
		/// </summary>
		protected RMethod r_MAddAccessRule_AccessRule;
		public virtual RMethod RMAddAccessRule_AccessRule
		{
			get
			{
				if(r_MAddAccessRule_AccessRule == null)
				{
					r_MAddAccessRule_AccessRule = new(this, "AddAccessRule", 0, typeof(System.Security.AccessControl.AccessRule));
					r_MAddAccessRule_AccessRule.SetBelong(this.instance);
				}
				return r_MAddAccessRule_AccessRule;
			}
		}

		/// <summary>
		/// Boolean RemoveAccessRule(System.Security.AccessControl.AccessRule)
		/// </summary>
		protected RMethod r_MRemoveAccessRule_AccessRule;
		public virtual RMethod RMRemoveAccessRule_AccessRule
		{
			get
			{
				if(r_MRemoveAccessRule_AccessRule == null)
				{
					r_MRemoveAccessRule_AccessRule = new(this, "RemoveAccessRule", 0, typeof(System.Security.AccessControl.AccessRule));
					r_MRemoveAccessRule_AccessRule.SetBelong(this.instance);
				}
				return r_MRemoveAccessRule_AccessRule;
			}
		}

		/// <summary>
		/// Void RemoveAccessRuleAll(System.Security.AccessControl.AccessRule)
		/// </summary>
		protected RMethod r_MRemoveAccessRuleAll_AccessRule;
		public virtual RMethod RMRemoveAccessRuleAll_AccessRule
		{
			get
			{
				if(r_MRemoveAccessRuleAll_AccessRule == null)
				{
					r_MRemoveAccessRuleAll_AccessRule = new(this, "RemoveAccessRuleAll", 0, typeof(System.Security.AccessControl.AccessRule));
					r_MRemoveAccessRuleAll_AccessRule.SetBelong(this.instance);
				}
				return r_MRemoveAccessRuleAll_AccessRule;
			}
		}

		/// <summary>
		/// Void RemoveAccessRuleSpecific(System.Security.AccessControl.AccessRule)
		/// </summary>
		protected RMethod r_MRemoveAccessRuleSpecific_AccessRule;
		public virtual RMethod RMRemoveAccessRuleSpecific_AccessRule
		{
			get
			{
				if(r_MRemoveAccessRuleSpecific_AccessRule == null)
				{
					r_MRemoveAccessRuleSpecific_AccessRule = new(this, "RemoveAccessRuleSpecific", 0, typeof(System.Security.AccessControl.AccessRule));
					r_MRemoveAccessRuleSpecific_AccessRule.SetBelong(this.instance);
				}
				return r_MRemoveAccessRuleSpecific_AccessRule;
			}
		}

		/// <summary>
		/// Void ResetAccessRule(System.Security.AccessControl.AccessRule)
		/// </summary>
		protected RMethod r_MResetAccessRule_AccessRule;
		public virtual RMethod RMResetAccessRule_AccessRule
		{
			get
			{
				if(r_MResetAccessRule_AccessRule == null)
				{
					r_MResetAccessRule_AccessRule = new(this, "ResetAccessRule", 0, typeof(System.Security.AccessControl.AccessRule));
					r_MResetAccessRule_AccessRule.SetBelong(this.instance);
				}
				return r_MResetAccessRule_AccessRule;
			}
		}

		/// <summary>
		/// Void SetAccessRule(System.Security.AccessControl.AccessRule)
		/// </summary>
		protected RMethod r_MSetAccessRule_AccessRule;
		public virtual RMethod RMSetAccessRule_AccessRule
		{
			get
			{
				if(r_MSetAccessRule_AccessRule == null)
				{
					r_MSetAccessRule_AccessRule = new(this, "SetAccessRule", 0, typeof(System.Security.AccessControl.AccessRule));
					r_MSetAccessRule_AccessRule.SetBelong(this.instance);
				}
				return r_MSetAccessRule_AccessRule;
			}
		}

		/// <summary>
		/// Boolean ModifyAccess(System.Security.AccessControl.AccessControlModification, System.Security.AccessControl.AccessRule, Boolean ByRef)
		/// </summary>
		protected RMethod r_MModifyAccess_AccessControlModification_AccessRule_Out_Boolean;
		public virtual RMethod RMModifyAccess_AccessControlModification_AccessRule_Out_Boolean
		{
			get
			{
				if(r_MModifyAccess_AccessControlModification_AccessRule_Out_Boolean == null)
				{
					r_MModifyAccess_AccessControlModification_AccessRule_Out_Boolean = new(this, "ModifyAccess", 0, typeof(System.Security.AccessControl.AccessControlModification), typeof(System.Security.AccessControl.AccessRule), typeof(System.Boolean).MakeByRefType());
					r_MModifyAccess_AccessControlModification_AccessRule_Out_Boolean.SetBelong(this.instance);
				}
				return r_MModifyAccess_AccessControlModification_AccessRule_Out_Boolean;
			}
		}

		/// <summary>
		/// Void AddAuditRule(System.Security.AccessControl.AuditRule)
		/// </summary>
		protected RMethod r_MAddAuditRule_AuditRule;
		public virtual RMethod RMAddAuditRule_AuditRule
		{
			get
			{
				if(r_MAddAuditRule_AuditRule == null)
				{
					r_MAddAuditRule_AuditRule = new(this, "AddAuditRule", 0, typeof(System.Security.AccessControl.AuditRule));
					r_MAddAuditRule_AuditRule.SetBelong(this.instance);
				}
				return r_MAddAuditRule_AuditRule;
			}
		}

		/// <summary>
		/// Boolean RemoveAuditRule(System.Security.AccessControl.AuditRule)
		/// </summary>
		protected RMethod r_MRemoveAuditRule_AuditRule;
		public virtual RMethod RMRemoveAuditRule_AuditRule
		{
			get
			{
				if(r_MRemoveAuditRule_AuditRule == null)
				{
					r_MRemoveAuditRule_AuditRule = new(this, "RemoveAuditRule", 0, typeof(System.Security.AccessControl.AuditRule));
					r_MRemoveAuditRule_AuditRule.SetBelong(this.instance);
				}
				return r_MRemoveAuditRule_AuditRule;
			}
		}

		/// <summary>
		/// Void RemoveAuditRuleAll(System.Security.AccessControl.AuditRule)
		/// </summary>
		protected RMethod r_MRemoveAuditRuleAll_AuditRule;
		public virtual RMethod RMRemoveAuditRuleAll_AuditRule
		{
			get
			{
				if(r_MRemoveAuditRuleAll_AuditRule == null)
				{
					r_MRemoveAuditRuleAll_AuditRule = new(this, "RemoveAuditRuleAll", 0, typeof(System.Security.AccessControl.AuditRule));
					r_MRemoveAuditRuleAll_AuditRule.SetBelong(this.instance);
				}
				return r_MRemoveAuditRuleAll_AuditRule;
			}
		}

		/// <summary>
		/// Void RemoveAuditRuleSpecific(System.Security.AccessControl.AuditRule)
		/// </summary>
		protected RMethod r_MRemoveAuditRuleSpecific_AuditRule;
		public virtual RMethod RMRemoveAuditRuleSpecific_AuditRule
		{
			get
			{
				if(r_MRemoveAuditRuleSpecific_AuditRule == null)
				{
					r_MRemoveAuditRuleSpecific_AuditRule = new(this, "RemoveAuditRuleSpecific", 0, typeof(System.Security.AccessControl.AuditRule));
					r_MRemoveAuditRuleSpecific_AuditRule.SetBelong(this.instance);
				}
				return r_MRemoveAuditRuleSpecific_AuditRule;
			}
		}

		/// <summary>
		/// Void SetAuditRule(System.Security.AccessControl.AuditRule)
		/// </summary>
		protected RMethod r_MSetAuditRule_AuditRule;
		public virtual RMethod RMSetAuditRule_AuditRule
		{
			get
			{
				if(r_MSetAuditRule_AuditRule == null)
				{
					r_MSetAuditRule_AuditRule = new(this, "SetAuditRule", 0, typeof(System.Security.AccessControl.AuditRule));
					r_MSetAuditRule_AuditRule.SetBelong(this.instance);
				}
				return r_MSetAuditRule_AuditRule;
			}
		}

		/// <summary>
		/// Boolean ModifyAudit(System.Security.AccessControl.AccessControlModification, System.Security.AccessControl.AuditRule, Boolean ByRef)
		/// </summary>
		protected RMethod r_MModifyAudit_AccessControlModification_AuditRule_Out_Boolean;
		public virtual RMethod RMModifyAudit_AccessControlModification_AuditRule_Out_Boolean
		{
			get
			{
				if(r_MModifyAudit_AccessControlModification_AuditRule_Out_Boolean == null)
				{
					r_MModifyAudit_AccessControlModification_AuditRule_Out_Boolean = new(this, "ModifyAudit", 0, typeof(System.Security.AccessControl.AccessControlModification), typeof(System.Security.AccessControl.AuditRule), typeof(System.Boolean).MakeByRefType());
					r_MModifyAudit_AccessControlModification_AuditRule_Out_Boolean.SetBelong(this.instance);
				}
				return r_MModifyAudit_AccessControlModification_AuditRule_Out_Boolean;
			}
		}

		/// <summary>
		/// System.Security.Principal.IdentityReference GetGroup(System.Type)
		/// </summary>
		protected RMethod r_MGetGroup_Type;
		public virtual RMethod RMGetGroup_Type
		{
			get
			{
				if(r_MGetGroup_Type == null)
				{
					r_MGetGroup_Type = new(this, "GetGroup", 0, typeof(System.Type));
					r_MGetGroup_Type.SetBelong(this.instance);
				}
				return r_MGetGroup_Type;
			}
		}

		/// <summary>
		/// System.Security.Principal.IdentityReference GetOwner(System.Type)
		/// </summary>
		protected RMethod r_MGetOwner_Type;
		public virtual RMethod RMGetOwner_Type
		{
			get
			{
				if(r_MGetOwner_Type == null)
				{
					r_MGetOwner_Type = new(this, "GetOwner", 0, typeof(System.Type));
					r_MGetOwner_Type.SetBelong(this.instance);
				}
				return r_MGetOwner_Type;
			}
		}

		/// <summary>
		/// Byte[] GetSecurityDescriptorBinaryForm()
		/// </summary>
		protected RMethod r_MGetSecurityDescriptorBinaryForm;
		public virtual RMethod RMGetSecurityDescriptorBinaryForm
		{
			get
			{
				if(r_MGetSecurityDescriptorBinaryForm == null)
				{
					r_MGetSecurityDescriptorBinaryForm = new(this, "GetSecurityDescriptorBinaryForm", 0);
					r_MGetSecurityDescriptorBinaryForm.SetBelong(this.instance);
				}
				return r_MGetSecurityDescriptorBinaryForm;
			}
		}

		/// <summary>
		/// System.String GetSecurityDescriptorSddlForm(System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_MGetSecurityDescriptorSddlForm_AccessControlSections;
		public virtual RMethod RMGetSecurityDescriptorSddlForm_AccessControlSections
		{
			get
			{
				if(r_MGetSecurityDescriptorSddlForm_AccessControlSections == null)
				{
					r_MGetSecurityDescriptorSddlForm_AccessControlSections = new(this, "GetSecurityDescriptorSddlForm", 0, typeof(System.Security.AccessControl.AccessControlSections));
					r_MGetSecurityDescriptorSddlForm_AccessControlSections.SetBelong(this.instance);
				}
				return r_MGetSecurityDescriptorSddlForm_AccessControlSections;
			}
		}

		/// <summary>
		/// Boolean ModifyAccessRule(System.Security.AccessControl.AccessControlModification, System.Security.AccessControl.AccessRule, Boolean ByRef)
		/// </summary>
		protected RMethod r_MModifyAccessRule_AccessControlModification_AccessRule_Out_Boolean;
		public virtual RMethod RMModifyAccessRule_AccessControlModification_AccessRule_Out_Boolean
		{
			get
			{
				if(r_MModifyAccessRule_AccessControlModification_AccessRule_Out_Boolean == null)
				{
					r_MModifyAccessRule_AccessControlModification_AccessRule_Out_Boolean = new(this, "ModifyAccessRule", 0, typeof(System.Security.AccessControl.AccessControlModification), typeof(System.Security.AccessControl.AccessRule), typeof(System.Boolean).MakeByRefType());
					r_MModifyAccessRule_AccessControlModification_AccessRule_Out_Boolean.SetBelong(this.instance);
				}
				return r_MModifyAccessRule_AccessControlModification_AccessRule_Out_Boolean;
			}
		}

		/// <summary>
		/// Boolean ModifyAuditRule(System.Security.AccessControl.AccessControlModification, System.Security.AccessControl.AuditRule, Boolean ByRef)
		/// </summary>
		protected RMethod r_MModifyAuditRule_AccessControlModification_AuditRule_Out_Boolean;
		public virtual RMethod RMModifyAuditRule_AccessControlModification_AuditRule_Out_Boolean
		{
			get
			{
				if(r_MModifyAuditRule_AccessControlModification_AuditRule_Out_Boolean == null)
				{
					r_MModifyAuditRule_AccessControlModification_AuditRule_Out_Boolean = new(this, "ModifyAuditRule", 0, typeof(System.Security.AccessControl.AccessControlModification), typeof(System.Security.AccessControl.AuditRule), typeof(System.Boolean).MakeByRefType());
					r_MModifyAuditRule_AccessControlModification_AuditRule_Out_Boolean.SetBelong(this.instance);
				}
				return r_MModifyAuditRule_AccessControlModification_AuditRule_Out_Boolean;
			}
		}

		/// <summary>
		/// Void PurgeAccessRules(System.Security.Principal.IdentityReference)
		/// </summary>
		protected RMethod r_MPurgeAccessRules_IdentityReference;
		public virtual RMethod RMPurgeAccessRules_IdentityReference
		{
			get
			{
				if(r_MPurgeAccessRules_IdentityReference == null)
				{
					r_MPurgeAccessRules_IdentityReference = new(this, "PurgeAccessRules", 0, typeof(System.Security.Principal.IdentityReference));
					r_MPurgeAccessRules_IdentityReference.SetBelong(this.instance);
				}
				return r_MPurgeAccessRules_IdentityReference;
			}
		}

		/// <summary>
		/// Void PurgeAuditRules(System.Security.Principal.IdentityReference)
		/// </summary>
		protected RMethod r_MPurgeAuditRules_IdentityReference;
		public virtual RMethod RMPurgeAuditRules_IdentityReference
		{
			get
			{
				if(r_MPurgeAuditRules_IdentityReference == null)
				{
					r_MPurgeAuditRules_IdentityReference = new(this, "PurgeAuditRules", 0, typeof(System.Security.Principal.IdentityReference));
					r_MPurgeAuditRules_IdentityReference.SetBelong(this.instance);
				}
				return r_MPurgeAuditRules_IdentityReference;
			}
		}

		/// <summary>
		/// Void SetAccessRuleProtection(Boolean, Boolean)
		/// </summary>
		protected RMethod r_MSetAccessRuleProtection_Boolean_Boolean;
		public virtual RMethod RMSetAccessRuleProtection_Boolean_Boolean
		{
			get
			{
				if(r_MSetAccessRuleProtection_Boolean_Boolean == null)
				{
					r_MSetAccessRuleProtection_Boolean_Boolean = new(this, "SetAccessRuleProtection", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_MSetAccessRuleProtection_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MSetAccessRuleProtection_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void SetAuditRuleProtection(Boolean, Boolean)
		/// </summary>
		protected RMethod r_MSetAuditRuleProtection_Boolean_Boolean;
		public virtual RMethod RMSetAuditRuleProtection_Boolean_Boolean
		{
			get
			{
				if(r_MSetAuditRuleProtection_Boolean_Boolean == null)
				{
					r_MSetAuditRuleProtection_Boolean_Boolean = new(this, "SetAuditRuleProtection", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_MSetAuditRuleProtection_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MSetAuditRuleProtection_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void SetGroup(System.Security.Principal.IdentityReference)
		/// </summary>
		protected RMethod r_MSetGroup_IdentityReference;
		public virtual RMethod RMSetGroup_IdentityReference
		{
			get
			{
				if(r_MSetGroup_IdentityReference == null)
				{
					r_MSetGroup_IdentityReference = new(this, "SetGroup", 0, typeof(System.Security.Principal.IdentityReference));
					r_MSetGroup_IdentityReference.SetBelong(this.instance);
				}
				return r_MSetGroup_IdentityReference;
			}
		}

		/// <summary>
		/// Void SetOwner(System.Security.Principal.IdentityReference)
		/// </summary>
		protected RMethod r_MSetOwner_IdentityReference;
		public virtual RMethod RMSetOwner_IdentityReference
		{
			get
			{
				if(r_MSetOwner_IdentityReference == null)
				{
					r_MSetOwner_IdentityReference = new(this, "SetOwner", 0, typeof(System.Security.Principal.IdentityReference));
					r_MSetOwner_IdentityReference.SetBelong(this.instance);
				}
				return r_MSetOwner_IdentityReference;
			}
		}

		/// <summary>
		/// Void SetSecurityDescriptorBinaryForm(Byte[])
		/// </summary>
		protected RMethod r_MSetSecurityDescriptorBinaryForm_ByteArray;
		public virtual RMethod RMSetSecurityDescriptorBinaryForm_ByteArray
		{
			get
			{
				if(r_MSetSecurityDescriptorBinaryForm_ByteArray == null)
				{
					r_MSetSecurityDescriptorBinaryForm_ByteArray = new(this, "SetSecurityDescriptorBinaryForm", 0, typeof(System.Byte).MakeArrayType());
					r_MSetSecurityDescriptorBinaryForm_ByteArray.SetBelong(this.instance);
				}
				return r_MSetSecurityDescriptorBinaryForm_ByteArray;
			}
		}

		/// <summary>
		/// Void SetSecurityDescriptorBinaryForm(Byte[], System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_MSetSecurityDescriptorBinaryForm_ByteArray_AccessControlSections;
		public virtual RMethod RMSetSecurityDescriptorBinaryForm_ByteArray_AccessControlSections
		{
			get
			{
				if(r_MSetSecurityDescriptorBinaryForm_ByteArray_AccessControlSections == null)
				{
					r_MSetSecurityDescriptorBinaryForm_ByteArray_AccessControlSections = new(this, "SetSecurityDescriptorBinaryForm", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Security.AccessControl.AccessControlSections));
					r_MSetSecurityDescriptorBinaryForm_ByteArray_AccessControlSections.SetBelong(this.instance);
				}
				return r_MSetSecurityDescriptorBinaryForm_ByteArray_AccessControlSections;
			}
		}

		/// <summary>
		/// Void SetSecurityDescriptorSddlForm(System.String)
		/// </summary>
		protected RMethod r_MSetSecurityDescriptorSddlForm_String;
		public virtual RMethod RMSetSecurityDescriptorSddlForm_String
		{
			get
			{
				if(r_MSetSecurityDescriptorSddlForm_String == null)
				{
					r_MSetSecurityDescriptorSddlForm_String = new(this, "SetSecurityDescriptorSddlForm", 0, typeof(System.String));
					r_MSetSecurityDescriptorSddlForm_String.SetBelong(this.instance);
				}
				return r_MSetSecurityDescriptorSddlForm_String;
			}
		}

		/// <summary>
		/// Void SetSecurityDescriptorSddlForm(System.String, System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_MSetSecurityDescriptorSddlForm_String_AccessControlSections;
		public virtual RMethod RMSetSecurityDescriptorSddlForm_String_AccessControlSections
		{
			get
			{
				if(r_MSetSecurityDescriptorSddlForm_String_AccessControlSections == null)
				{
					r_MSetSecurityDescriptorSddlForm_String_AccessControlSections = new(this, "SetSecurityDescriptorSddlForm", 0, typeof(System.String), typeof(System.Security.AccessControl.AccessControlSections));
					r_MSetSecurityDescriptorSddlForm_String_AccessControlSections.SetBelong(this.instance);
				}
				return r_MSetSecurityDescriptorSddlForm_String_AccessControlSections;
			}
		}

		/// <summary>
		/// Void Persist(Boolean, System.String, System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_MPersist_Boolean_String_AccessControlSections;
		public virtual RMethod RMPersist_Boolean_String_AccessControlSections
		{
			get
			{
				if(r_MPersist_Boolean_String_AccessControlSections == null)
				{
					r_MPersist_Boolean_String_AccessControlSections = new(this, "Persist", 0, typeof(System.Boolean), typeof(System.String), typeof(System.Security.AccessControl.AccessControlSections));
					r_MPersist_Boolean_String_AccessControlSections.SetBelong(this.instance);
				}
				return r_MPersist_Boolean_String_AccessControlSections;
			}
		}

		/// <summary>
		/// Void ReadLock()
		/// </summary>
		protected RMethod r_MReadLock;
		public virtual RMethod RMReadLock
		{
			get
			{
				if(r_MReadLock == null)
				{
					r_MReadLock = new(this, "ReadLock", 0);
					r_MReadLock.SetBelong(this.instance);
				}
				return r_MReadLock;
			}
		}

		/// <summary>
		/// Void ReadUnlock()
		/// </summary>
		protected RMethod r_MReadUnlock;
		public virtual RMethod RMReadUnlock
		{
			get
			{
				if(r_MReadUnlock == null)
				{
					r_MReadUnlock = new(this, "ReadUnlock", 0);
					r_MReadUnlock.SetBelong(this.instance);
				}
				return r_MReadUnlock;
			}
		}

		/// <summary>
		/// Void WriteLock()
		/// </summary>
		protected RMethod r_MWriteLock;
		public virtual RMethod RMWriteLock
		{
			get
			{
				if(r_MWriteLock == null)
				{
					r_MWriteLock = new(this, "WriteLock", 0);
					r_MWriteLock.SetBelong(this.instance);
				}
				return r_MWriteLock;
			}
		}

		/// <summary>
		/// Void WriteUnlock()
		/// </summary>
		protected RMethod r_MWriteUnlock;
		public virtual RMethod RMWriteUnlock
		{
			get
			{
				if(r_MWriteUnlock == null)
				{
					r_MWriteUnlock = new(this, "WriteUnlock", 0);
					r_MWriteUnlock.SetBelong(this.instance);
				}
				return r_MWriteUnlock;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AuthorizationRuleCollection InternalGetAccessRules(Boolean, Boolean, System.Type)
		/// </summary>
		protected RMethod r_MInternalGetAccessRules_Boolean_Boolean_Type;
		public virtual RMethod RMInternalGetAccessRules_Boolean_Boolean_Type
		{
			get
			{
				if(r_MInternalGetAccessRules_Boolean_Boolean_Type == null)
				{
					r_MInternalGetAccessRules_Boolean_Boolean_Type = new(this, "InternalGetAccessRules", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Type));
					r_MInternalGetAccessRules_Boolean_Boolean_Type.SetBelong(this.instance);
				}
				return r_MInternalGetAccessRules_Boolean_Boolean_Type;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AccessRule InternalAccessRuleFactory(System.Security.AccessControl.QualifiedAce, System.Type, System.Security.AccessControl.AccessControlType)
		/// </summary>
		protected RMethod r_MInternalAccessRuleFactory_QualifiedAce_Type_AccessControlType;
		public virtual RMethod RMInternalAccessRuleFactory_QualifiedAce_Type_AccessControlType
		{
			get
			{
				if(r_MInternalAccessRuleFactory_QualifiedAce_Type_AccessControlType == null)
				{
					r_MInternalAccessRuleFactory_QualifiedAce_Type_AccessControlType = new(this, "InternalAccessRuleFactory", 0, typeof(System.Security.AccessControl.QualifiedAce), typeof(System.Type), typeof(System.Security.AccessControl.AccessControlType));
					r_MInternalAccessRuleFactory_QualifiedAce_Type_AccessControlType.SetBelong(this.instance);
				}
				return r_MInternalAccessRuleFactory_QualifiedAce_Type_AccessControlType;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AuthorizationRuleCollection InternalGetAuditRules(Boolean, Boolean, System.Type)
		/// </summary>
		protected RMethod r_MInternalGetAuditRules_Boolean_Boolean_Type;
		public virtual RMethod RMInternalGetAuditRules_Boolean_Boolean_Type
		{
			get
			{
				if(r_MInternalGetAuditRules_Boolean_Boolean_Type == null)
				{
					r_MInternalGetAuditRules_Boolean_Boolean_Type = new(this, "InternalGetAuditRules", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Type));
					r_MInternalGetAuditRules_Boolean_Boolean_Type.SetBelong(this.instance);
				}
				return r_MInternalGetAuditRules_Boolean_Boolean_Type;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AuditRule InternalAuditRuleFactory(System.Security.AccessControl.QualifiedAce, System.Type)
		/// </summary>
		protected RMethod r_MInternalAuditRuleFactory_QualifiedAce_Type;
		public virtual RMethod RMInternalAuditRuleFactory_QualifiedAce_Type
		{
			get
			{
				if(r_MInternalAuditRuleFactory_QualifiedAce_Type == null)
				{
					r_MInternalAuditRuleFactory_QualifiedAce_Type = new(this, "InternalAuditRuleFactory", 0, typeof(System.Security.AccessControl.QualifiedAce), typeof(System.Type));
					r_MInternalAuditRuleFactory_QualifiedAce_Type.SetBelong(this.instance);
				}
				return r_MInternalAuditRuleFactory_QualifiedAce_Type;
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


        public RFileSecurity() : base("System.Security.AccessControl.FileSecurity")
        {
        }

        public RFileSecurity(System.Object instance) : base("System.Security.AccessControl.FileSecurity")
		{
            SetInstance(instance);
		}

        public RFileSecurity(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFileSecurity(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference @identityReference, System.Int32 @accessMask, System.Boolean @isInherited, System.Security.AccessControl.InheritanceFlags @inheritanceFlags, System.Security.AccessControl.PropagationFlags @propagationFlags, System.Security.AccessControl.AccessControlType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@identityReference, @accessMask, @isInherited, @inheritanceFlags, @propagationFlags, @type};
            var ___result = RMAccessRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AccessControlType.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AccessRule)___result;
        }


        public virtual void AddAccessRule(System.Security.AccessControl.FileSystemAccessRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMAddAccessRule_FileSystemAccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean RemoveAccessRule(System.Security.AccessControl.FileSystemAccessRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMRemoveAccessRule_FileSystemAccessRule.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RemoveAccessRuleAll(System.Security.AccessControl.FileSystemAccessRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMRemoveAccessRuleAll_FileSystemAccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAccessRuleSpecific(System.Security.AccessControl.FileSystemAccessRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMRemoveAccessRuleSpecific_FileSystemAccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetAccessRule(System.Security.AccessControl.FileSystemAccessRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMResetAccessRule_FileSystemAccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAccessRule(System.Security.AccessControl.FileSystemAccessRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMSetAccessRule_FileSystemAccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference @identityReference, System.Int32 @accessMask, System.Boolean @isInherited, System.Security.AccessControl.InheritanceFlags @inheritanceFlags, System.Security.AccessControl.PropagationFlags @propagationFlags, System.Security.AccessControl.AuditFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@identityReference, @accessMask, @isInherited, @inheritanceFlags, @propagationFlags, @flags};
            var ___result = RMAuditRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AuditFlags.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AuditRule)___result;
        }


        public virtual void AddAuditRule(System.Security.AccessControl.FileSystemAuditRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMAddAuditRule_FileSystemAuditRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean RemoveAuditRule(System.Security.AccessControl.FileSystemAuditRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMRemoveAuditRule_FileSystemAuditRule.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RemoveAuditRuleAll(System.Security.AccessControl.FileSystemAuditRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMRemoveAuditRuleAll_FileSystemAuditRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAuditRuleSpecific(System.Security.AccessControl.FileSystemAuditRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMRemoveAuditRuleSpecific_FileSystemAuditRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAuditRule(System.Security.AccessControl.FileSystemAuditRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMSetAuditRule_FileSystemAuditRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Persist(System.Runtime.InteropServices.SafeHandle @handle, System.Security.AccessControl.AccessControlSections @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @includeSections};
            var ___result = RMPersist_SafeHandle_AccessControlSections.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Persist(System.String @name, System.Security.AccessControl.AccessControlSections @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @includeSections};
            var ___result = RMPersist_String_AccessControlSections.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PersistModifications(System.Runtime.InteropServices.SafeHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMPersistModifications_SafeHandle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Persist(System.Runtime.InteropServices.SafeHandle @handle, System.Security.AccessControl.AccessControlSections @includeSections, System.Object @exceptionContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @includeSections, @exceptionContext};
            var ___result = RMPersist_SafeHandle_AccessControlSections_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PersistModifications(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMPersistModifications_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Persist(System.String @name, System.Security.AccessControl.AccessControlSections @includeSections, System.Object @exceptionContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @includeSections, @exceptionContext};
            var ___result = RMPersist_String_AccessControlSections_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 InternalGet(System.Runtime.InteropServices.SafeHandle @handle, System.Security.AccessControl.AccessControlSections @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @includeSections};
            var ___result = RMInternalGet_SafeHandle_AccessControlSections.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 InternalGet(System.String @name, System.Security.AccessControl.AccessControlSections @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @includeSections};
            var ___result = RMInternalGet_String_AccessControlSections.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 InternalSet(System.Runtime.InteropServices.SafeHandle @handle, System.Security.AccessControl.AccessControlSections @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @includeSections};
            var ___result = RMInternalSet_SafeHandle_AccessControlSections.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 InternalSet(System.String @name, System.Security.AccessControl.AccessControlSections @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @includeSections};
            var ___result = RMInternalSet_String_AccessControlSections.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Security.AccessControl.AuthorizationRuleCollection GetAccessRules(System.Boolean @includeExplicit, System.Boolean @includeInherited, System.Type @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includeExplicit, @includeInherited, @targetType};
            var ___result = RMGetAccessRules_Boolean_Boolean_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AuthorizationRuleCollection)___result;
        }


        public virtual System.Security.AccessControl.AuthorizationRuleCollection GetAuditRules(System.Boolean @includeExplicit, System.Boolean @includeInherited, System.Type @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includeExplicit, @includeInherited, @targetType};
            var ___result = RMGetAuditRules_Boolean_Boolean_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AuthorizationRuleCollection)___result;
        }


        public virtual void AddAccessRule(System.Security.AccessControl.AccessRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMAddAccessRule_AccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean RemoveAccessRule(System.Security.AccessControl.AccessRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMRemoveAccessRule_AccessRule.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RemoveAccessRuleAll(System.Security.AccessControl.AccessRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMRemoveAccessRuleAll_AccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAccessRuleSpecific(System.Security.AccessControl.AccessRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMRemoveAccessRuleSpecific_AccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetAccessRule(System.Security.AccessControl.AccessRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMResetAccessRule_AccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAccessRule(System.Security.AccessControl.AccessRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMSetAccessRule_AccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ModifyAccess(System.Security.AccessControl.AccessControlModification @modification, System.Security.AccessControl.AccessRule @rule, out System.Boolean @modified)
        {
			@modified = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@modification, @rule, @modified};
            var ___result = RMModifyAccess_AccessControlModification_AccessRule_Out_Boolean.Invoke(___genericsType, ___parameters);
			@modified = (System.Boolean)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual void AddAuditRule(System.Security.AccessControl.AuditRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMAddAuditRule_AuditRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean RemoveAuditRule(System.Security.AccessControl.AuditRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMRemoveAuditRule_AuditRule.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RemoveAuditRuleAll(System.Security.AccessControl.AuditRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMRemoveAuditRuleAll_AuditRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAuditRuleSpecific(System.Security.AccessControl.AuditRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMRemoveAuditRuleSpecific_AuditRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAuditRule(System.Security.AccessControl.AuditRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RMSetAuditRule_AuditRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ModifyAudit(System.Security.AccessControl.AccessControlModification @modification, System.Security.AccessControl.AuditRule @rule, out System.Boolean @modified)
        {
			@modified = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@modification, @rule, @modified};
            var ___result = RMModifyAudit_AccessControlModification_AuditRule_Out_Boolean.Invoke(___genericsType, ___parameters);
			@modified = (System.Boolean)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual System.Security.Principal.IdentityReference GetGroup(System.Type @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetType};
            var ___result = RMGetGroup_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.Principal.IdentityReference)___result;
        }


        public virtual System.Security.Principal.IdentityReference GetOwner(System.Type @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetType};
            var ___result = RMGetOwner_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.Principal.IdentityReference)___result;
        }


        public virtual System.Byte[] GetSecurityDescriptorBinaryForm()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSecurityDescriptorBinaryForm.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.String GetSecurityDescriptorSddlForm(System.Security.AccessControl.AccessControlSections @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includeSections};
            var ___result = RMGetSecurityDescriptorSddlForm_AccessControlSections.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean ModifyAccessRule(System.Security.AccessControl.AccessControlModification @modification, System.Security.AccessControl.AccessRule @rule, out System.Boolean @modified)
        {
			@modified = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@modification, @rule, @modified};
            var ___result = RMModifyAccessRule_AccessControlModification_AccessRule_Out_Boolean.Invoke(___genericsType, ___parameters);
			@modified = (System.Boolean)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ModifyAuditRule(System.Security.AccessControl.AccessControlModification @modification, System.Security.AccessControl.AuditRule @rule, out System.Boolean @modified)
        {
			@modified = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@modification, @rule, @modified};
            var ___result = RMModifyAuditRule_AccessControlModification_AuditRule_Out_Boolean.Invoke(___genericsType, ___parameters);
			@modified = (System.Boolean)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual void PurgeAccessRules(System.Security.Principal.IdentityReference @identity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@identity};
            var ___result = RMPurgeAccessRules_IdentityReference.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PurgeAuditRules(System.Security.Principal.IdentityReference @identity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@identity};
            var ___result = RMPurgeAuditRules_IdentityReference.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAccessRuleProtection(System.Boolean @isProtected, System.Boolean @preserveInheritance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isProtected, @preserveInheritance};
            var ___result = RMSetAccessRuleProtection_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAuditRuleProtection(System.Boolean @isProtected, System.Boolean @preserveInheritance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isProtected, @preserveInheritance};
            var ___result = RMSetAuditRuleProtection_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGroup(System.Security.Principal.IdentityReference @identity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@identity};
            var ___result = RMSetGroup_IdentityReference.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetOwner(System.Security.Principal.IdentityReference @identity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@identity};
            var ___result = RMSetOwner_IdentityReference.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSecurityDescriptorBinaryForm(System.Byte[] @binaryForm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binaryForm};
            var ___result = RMSetSecurityDescriptorBinaryForm_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSecurityDescriptorBinaryForm(System.Byte[] @binaryForm, System.Security.AccessControl.AccessControlSections @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binaryForm, @includeSections};
            var ___result = RMSetSecurityDescriptorBinaryForm_ByteArray_AccessControlSections.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSecurityDescriptorSddlForm(System.String @sddlForm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sddlForm};
            var ___result = RMSetSecurityDescriptorSddlForm_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSecurityDescriptorSddlForm(System.String @sddlForm, System.Security.AccessControl.AccessControlSections @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sddlForm, @includeSections};
            var ___result = RMSetSecurityDescriptorSddlForm_String_AccessControlSections.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Persist(System.Boolean @enableOwnershipPrivilege, System.String @name, System.Security.AccessControl.AccessControlSections @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enableOwnershipPrivilege, @name, @includeSections};
            var ___result = RMPersist_Boolean_String_AccessControlSections.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadLock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReadLock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadUnlock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReadUnlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteLock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMWriteLock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteUnlock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMWriteUnlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.AccessControl.AuthorizationRuleCollection InternalGetAccessRules(System.Boolean @includeExplicit, System.Boolean @includeInherited, System.Type @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includeExplicit, @includeInherited, @targetType};
            var ___result = RMInternalGetAccessRules_Boolean_Boolean_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AuthorizationRuleCollection)___result;
        }


        public virtual System.Security.AccessControl.AccessRule InternalAccessRuleFactory(System.Security.AccessControl.QualifiedAce @ace, System.Type @targetType, System.Security.AccessControl.AccessControlType @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ace, @targetType, @type};
            var ___result = RMInternalAccessRuleFactory_QualifiedAce_Type_AccessControlType.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AccessRule)___result;
        }


        public virtual System.Security.AccessControl.AuthorizationRuleCollection InternalGetAuditRules(System.Boolean @includeExplicit, System.Boolean @includeInherited, System.Type @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includeExplicit, @includeInherited, @targetType};
            var ___result = RMInternalGetAuditRules_Boolean_Boolean_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AuthorizationRuleCollection)___result;
        }


        public virtual System.Security.AccessControl.AuditRule InternalAuditRuleFactory(System.Security.AccessControl.QualifiedAce @ace, System.Type @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ace, @targetType};
            var ___result = RMInternalAuditRuleFactory_QualifiedAce_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AuditRule)___result;
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
