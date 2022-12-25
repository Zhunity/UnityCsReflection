using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity.RAccessControl
{
	/// <summary>
	/// System.Security.AccessControl.EventWaitHandleSecurity
	/// </summary>
    public partial class REventWaitHandleSecurity : RMember //
    {

		/// <summary>
		/// System.Security.AccessControl.CommonSecurityDescriptor descriptor
		/// </summary>
		protected RSystem.RSecurity.RAccessControl.RCommonSecurityDescriptor r_descriptor;
		public virtual RSystem.RSecurity.RAccessControl.RCommonSecurityDescriptor Rdescriptor
		{
			get
			{
				if(r_descriptor == null)
				{
					r_descriptor = new(this, "descriptor");
					r_descriptor.SetBelong(this.instance);
				}
				return r_descriptor;
			}
		}

		/// <summary>
		/// System.Type AccessRightType
		/// </summary>
		protected RSystem.RType r_AccessRightType;
		public virtual RSystem.RType RAccessRightType
		{
			get
			{
				if(r_AccessRightType == null)
				{
					r_AccessRightType = new(this, "AccessRightType", -1);
					r_AccessRightType.SetBelong(this.instance);
				}
				return r_AccessRightType;
			}
		}

		/// <summary>
		/// System.Type AccessRuleType
		/// </summary>
		protected RSystem.RType r_AccessRuleType;
		public virtual RSystem.RType RAccessRuleType
		{
			get
			{
				if(r_AccessRuleType == null)
				{
					r_AccessRuleType = new(this, "AccessRuleType", -1);
					r_AccessRuleType.SetBelong(this.instance);
				}
				return r_AccessRuleType;
			}
		}

		/// <summary>
		/// System.Type AuditRuleType
		/// </summary>
		protected RSystem.RType r_AuditRuleType;
		public virtual RSystem.RType RAuditRuleType
		{
			get
			{
				if(r_AuditRuleType == null)
				{
					r_AuditRuleType = new(this, "AuditRuleType", -1);
					r_AuditRuleType.SetBelong(this.instance);
				}
				return r_AuditRuleType;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.ResourceType ResourceType
		/// </summary>
		protected RProperty r_ResourceType;
		public virtual RProperty ResourceType
		{
			get
			{
				if(r_ResourceType == null)
				{
					r_ResourceType = new(this, "ResourceType", -1);
					r_ResourceType.SetBelong(this.instance);
				}
				return r_ResourceType;
			}
		}

		/// <summary>
		/// Boolean AreAccessRulesCanonical
		/// </summary>
		protected RProperty r_AreAccessRulesCanonical;
		public virtual RProperty RAreAccessRulesCanonical
		{
			get
			{
				if(r_AreAccessRulesCanonical == null)
				{
					r_AreAccessRulesCanonical = new(this, "AreAccessRulesCanonical", -1);
					r_AreAccessRulesCanonical.SetBelong(this.instance);
				}
				return r_AreAccessRulesCanonical;
			}
		}

		/// <summary>
		/// Boolean AreAccessRulesProtected
		/// </summary>
		protected RProperty r_AreAccessRulesProtected;
		public virtual RProperty RAreAccessRulesProtected
		{
			get
			{
				if(r_AreAccessRulesProtected == null)
				{
					r_AreAccessRulesProtected = new(this, "AreAccessRulesProtected", -1);
					r_AreAccessRulesProtected.SetBelong(this.instance);
				}
				return r_AreAccessRulesProtected;
			}
		}

		/// <summary>
		/// Boolean AreAuditRulesCanonical
		/// </summary>
		protected RProperty r_AreAuditRulesCanonical;
		public virtual RProperty RAreAuditRulesCanonical
		{
			get
			{
				if(r_AreAuditRulesCanonical == null)
				{
					r_AreAuditRulesCanonical = new(this, "AreAuditRulesCanonical", -1);
					r_AreAuditRulesCanonical.SetBelong(this.instance);
				}
				return r_AreAuditRulesCanonical;
			}
		}

		/// <summary>
		/// Boolean AreAuditRulesProtected
		/// </summary>
		protected RProperty r_AreAuditRulesProtected;
		public virtual RProperty RAreAuditRulesProtected
		{
			get
			{
				if(r_AreAuditRulesProtected == null)
				{
					r_AreAuditRulesProtected = new(this, "AreAuditRulesProtected", -1);
					r_AreAuditRulesProtected.SetBelong(this.instance);
				}
				return r_AreAuditRulesProtected;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AccessControlSections AccessControlSectionsModified
		/// </summary>
		protected RProperty r_AccessControlSectionsModified;
		public virtual RProperty RAccessControlSectionsModified
		{
			get
			{
				if(r_AccessControlSectionsModified == null)
				{
					r_AccessControlSectionsModified = new(this, "AccessControlSectionsModified", -1);
					r_AccessControlSectionsModified.SetBelong(this.instance);
				}
				return r_AccessControlSectionsModified;
			}
		}

		/// <summary>
		/// Boolean AccessRulesModified
		/// </summary>
		protected RProperty r_AccessRulesModified;
		public virtual RProperty RAccessRulesModified
		{
			get
			{
				if(r_AccessRulesModified == null)
				{
					r_AccessRulesModified = new(this, "AccessRulesModified", -1);
					r_AccessRulesModified.SetBelong(this.instance);
				}
				return r_AccessRulesModified;
			}
		}

		/// <summary>
		/// Boolean AuditRulesModified
		/// </summary>
		protected RProperty r_AuditRulesModified;
		public virtual RProperty RAuditRulesModified
		{
			get
			{
				if(r_AuditRulesModified == null)
				{
					r_AuditRulesModified = new(this, "AuditRulesModified", -1);
					r_AuditRulesModified.SetBelong(this.instance);
				}
				return r_AuditRulesModified;
			}
		}

		/// <summary>
		/// Boolean GroupModified
		/// </summary>
		protected RProperty r_GroupModified;
		public virtual RProperty RGroupModified
		{
			get
			{
				if(r_GroupModified == null)
				{
					r_GroupModified = new(this, "GroupModified", -1);
					r_GroupModified.SetBelong(this.instance);
				}
				return r_GroupModified;
			}
		}

		/// <summary>
		/// Boolean IsContainer
		/// </summary>
		protected RProperty r_IsContainer;
		public virtual RProperty RIsContainer
		{
			get
			{
				if(r_IsContainer == null)
				{
					r_IsContainer = new(this, "IsContainer", -1);
					r_IsContainer.SetBelong(this.instance);
				}
				return r_IsContainer;
			}
		}

		/// <summary>
		/// Boolean IsDS
		/// </summary>
		protected RProperty r_IsDS;
		public virtual RProperty RIsDS
		{
			get
			{
				if(r_IsDS == null)
				{
					r_IsDS = new(this, "IsDS", -1);
					r_IsDS.SetBelong(this.instance);
				}
				return r_IsDS;
			}
		}

		/// <summary>
		/// Boolean OwnerModified
		/// </summary>
		protected RProperty r_OwnerModified;
		public virtual RProperty ROwnerModified
		{
			get
			{
				if(r_OwnerModified == null)
				{
					r_OwnerModified = new(this, "OwnerModified", -1);
					r_OwnerModified.SetBelong(this.instance);
				}
				return r_OwnerModified;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference, Int32, Boolean, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AccessControlType)
		/// </summary>
		protected RMethod r_RAccessRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AccessControlType;
		public virtual RMethod RAccessRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AccessControlType
		{
			get
			{
				if(r_RAccessRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AccessControlType == null)
				{
					r_RAccessRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AccessControlType = new(this, "AccessRuleFactory", 0, typeof(System.Security.Principal.IdentityReference), typeof(System.Int32), typeof(System.Boolean), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AccessControlType));
					r_RAccessRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AccessControlType.SetBelong(this.instance);
				}
				return r_RAccessRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AccessControlType;
			}
		}

		/// <summary>
		/// Void AddAccessRule(System.Security.AccessControl.EventWaitHandleAccessRule)
		/// </summary>
		protected RMethod r_RAddAccessRule_EventWaitHandleAccessRule;
		public virtual RMethod RAddAccessRule_EventWaitHandleAccessRule
		{
			get
			{
				if(r_RAddAccessRule_EventWaitHandleAccessRule == null)
				{
					r_RAddAccessRule_EventWaitHandleAccessRule = new(this, "AddAccessRule", 0, typeof(System.Security.AccessControl.EventWaitHandleAccessRule));
					r_RAddAccessRule_EventWaitHandleAccessRule.SetBelong(this.instance);
				}
				return r_RAddAccessRule_EventWaitHandleAccessRule;
			}
		}

		/// <summary>
		/// Boolean RemoveAccessRule(System.Security.AccessControl.EventWaitHandleAccessRule)
		/// </summary>
		protected RMethod r_RRemoveAccessRule_EventWaitHandleAccessRule;
		public virtual RMethod RRemoveAccessRule_EventWaitHandleAccessRule
		{
			get
			{
				if(r_RRemoveAccessRule_EventWaitHandleAccessRule == null)
				{
					r_RRemoveAccessRule_EventWaitHandleAccessRule = new(this, "RemoveAccessRule", 0, typeof(System.Security.AccessControl.EventWaitHandleAccessRule));
					r_RRemoveAccessRule_EventWaitHandleAccessRule.SetBelong(this.instance);
				}
				return r_RRemoveAccessRule_EventWaitHandleAccessRule;
			}
		}

		/// <summary>
		/// Void RemoveAccessRuleAll(System.Security.AccessControl.EventWaitHandleAccessRule)
		/// </summary>
		protected RMethod r_RRemoveAccessRuleAll_EventWaitHandleAccessRule;
		public virtual RMethod RRemoveAccessRuleAll_EventWaitHandleAccessRule
		{
			get
			{
				if(r_RRemoveAccessRuleAll_EventWaitHandleAccessRule == null)
				{
					r_RRemoveAccessRuleAll_EventWaitHandleAccessRule = new(this, "RemoveAccessRuleAll", 0, typeof(System.Security.AccessControl.EventWaitHandleAccessRule));
					r_RRemoveAccessRuleAll_EventWaitHandleAccessRule.SetBelong(this.instance);
				}
				return r_RRemoveAccessRuleAll_EventWaitHandleAccessRule;
			}
		}

		/// <summary>
		/// Void RemoveAccessRuleSpecific(System.Security.AccessControl.EventWaitHandleAccessRule)
		/// </summary>
		protected RMethod r_RRemoveAccessRuleSpecific_EventWaitHandleAccessRule;
		public virtual RMethod RRemoveAccessRuleSpecific_EventWaitHandleAccessRule
		{
			get
			{
				if(r_RRemoveAccessRuleSpecific_EventWaitHandleAccessRule == null)
				{
					r_RRemoveAccessRuleSpecific_EventWaitHandleAccessRule = new(this, "RemoveAccessRuleSpecific", 0, typeof(System.Security.AccessControl.EventWaitHandleAccessRule));
					r_RRemoveAccessRuleSpecific_EventWaitHandleAccessRule.SetBelong(this.instance);
				}
				return r_RRemoveAccessRuleSpecific_EventWaitHandleAccessRule;
			}
		}

		/// <summary>
		/// Void ResetAccessRule(System.Security.AccessControl.EventWaitHandleAccessRule)
		/// </summary>
		protected RMethod r_RResetAccessRule_EventWaitHandleAccessRule;
		public virtual RMethod RResetAccessRule_EventWaitHandleAccessRule
		{
			get
			{
				if(r_RResetAccessRule_EventWaitHandleAccessRule == null)
				{
					r_RResetAccessRule_EventWaitHandleAccessRule = new(this, "ResetAccessRule", 0, typeof(System.Security.AccessControl.EventWaitHandleAccessRule));
					r_RResetAccessRule_EventWaitHandleAccessRule.SetBelong(this.instance);
				}
				return r_RResetAccessRule_EventWaitHandleAccessRule;
			}
		}

		/// <summary>
		/// Void SetAccessRule(System.Security.AccessControl.EventWaitHandleAccessRule)
		/// </summary>
		protected RMethod r_RSetAccessRule_EventWaitHandleAccessRule;
		public virtual RMethod RSetAccessRule_EventWaitHandleAccessRule
		{
			get
			{
				if(r_RSetAccessRule_EventWaitHandleAccessRule == null)
				{
					r_RSetAccessRule_EventWaitHandleAccessRule = new(this, "SetAccessRule", 0, typeof(System.Security.AccessControl.EventWaitHandleAccessRule));
					r_RSetAccessRule_EventWaitHandleAccessRule.SetBelong(this.instance);
				}
				return r_RSetAccessRule_EventWaitHandleAccessRule;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference, Int32, Boolean, System.Security.AccessControl.InheritanceFlags, System.Security.AccessControl.PropagationFlags, System.Security.AccessControl.AuditFlags)
		/// </summary>
		protected RMethod r_RAuditRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AuditFlags;
		public virtual RMethod RAuditRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AuditFlags
		{
			get
			{
				if(r_RAuditRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AuditFlags == null)
				{
					r_RAuditRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AuditFlags = new(this, "AuditRuleFactory", 0, typeof(System.Security.Principal.IdentityReference), typeof(System.Int32), typeof(System.Boolean), typeof(System.Security.AccessControl.InheritanceFlags), typeof(System.Security.AccessControl.PropagationFlags), typeof(System.Security.AccessControl.AuditFlags));
					r_RAuditRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AuditFlags.SetBelong(this.instance);
				}
				return r_RAuditRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AuditFlags;
			}
		}

		/// <summary>
		/// Void AddAuditRule(System.Security.AccessControl.EventWaitHandleAuditRule)
		/// </summary>
		protected RMethod r_RAddAuditRule_EventWaitHandleAuditRule;
		public virtual RMethod RAddAuditRule_EventWaitHandleAuditRule
		{
			get
			{
				if(r_RAddAuditRule_EventWaitHandleAuditRule == null)
				{
					r_RAddAuditRule_EventWaitHandleAuditRule = new(this, "AddAuditRule", 0, typeof(System.Security.AccessControl.EventWaitHandleAuditRule));
					r_RAddAuditRule_EventWaitHandleAuditRule.SetBelong(this.instance);
				}
				return r_RAddAuditRule_EventWaitHandleAuditRule;
			}
		}

		/// <summary>
		/// Boolean RemoveAuditRule(System.Security.AccessControl.EventWaitHandleAuditRule)
		/// </summary>
		protected RMethod r_RRemoveAuditRule_EventWaitHandleAuditRule;
		public virtual RMethod RRemoveAuditRule_EventWaitHandleAuditRule
		{
			get
			{
				if(r_RRemoveAuditRule_EventWaitHandleAuditRule == null)
				{
					r_RRemoveAuditRule_EventWaitHandleAuditRule = new(this, "RemoveAuditRule", 0, typeof(System.Security.AccessControl.EventWaitHandleAuditRule));
					r_RRemoveAuditRule_EventWaitHandleAuditRule.SetBelong(this.instance);
				}
				return r_RRemoveAuditRule_EventWaitHandleAuditRule;
			}
		}

		/// <summary>
		/// Void RemoveAuditRuleAll(System.Security.AccessControl.EventWaitHandleAuditRule)
		/// </summary>
		protected RMethod r_RRemoveAuditRuleAll_EventWaitHandleAuditRule;
		public virtual RMethod RRemoveAuditRuleAll_EventWaitHandleAuditRule
		{
			get
			{
				if(r_RRemoveAuditRuleAll_EventWaitHandleAuditRule == null)
				{
					r_RRemoveAuditRuleAll_EventWaitHandleAuditRule = new(this, "RemoveAuditRuleAll", 0, typeof(System.Security.AccessControl.EventWaitHandleAuditRule));
					r_RRemoveAuditRuleAll_EventWaitHandleAuditRule.SetBelong(this.instance);
				}
				return r_RRemoveAuditRuleAll_EventWaitHandleAuditRule;
			}
		}

		/// <summary>
		/// Void RemoveAuditRuleSpecific(System.Security.AccessControl.EventWaitHandleAuditRule)
		/// </summary>
		protected RMethod r_RRemoveAuditRuleSpecific_EventWaitHandleAuditRule;
		public virtual RMethod RRemoveAuditRuleSpecific_EventWaitHandleAuditRule
		{
			get
			{
				if(r_RRemoveAuditRuleSpecific_EventWaitHandleAuditRule == null)
				{
					r_RRemoveAuditRuleSpecific_EventWaitHandleAuditRule = new(this, "RemoveAuditRuleSpecific", 0, typeof(System.Security.AccessControl.EventWaitHandleAuditRule));
					r_RRemoveAuditRuleSpecific_EventWaitHandleAuditRule.SetBelong(this.instance);
				}
				return r_RRemoveAuditRuleSpecific_EventWaitHandleAuditRule;
			}
		}

		/// <summary>
		/// Void SetAuditRule(System.Security.AccessControl.EventWaitHandleAuditRule)
		/// </summary>
		protected RMethod r_RSetAuditRule_EventWaitHandleAuditRule;
		public virtual RMethod RSetAuditRule_EventWaitHandleAuditRule
		{
			get
			{
				if(r_RSetAuditRule_EventWaitHandleAuditRule == null)
				{
					r_RSetAuditRule_EventWaitHandleAuditRule = new(this, "SetAuditRule", 0, typeof(System.Security.AccessControl.EventWaitHandleAuditRule));
					r_RSetAuditRule_EventWaitHandleAuditRule.SetBelong(this.instance);
				}
				return r_RSetAuditRule_EventWaitHandleAuditRule;
			}
		}

		/// <summary>
		/// Void Persist(System.Runtime.InteropServices.SafeHandle)
		/// </summary>
		protected RMethod r_RPersist_SafeHandle;
		public virtual RMethod RPersist_SafeHandle
		{
			get
			{
				if(r_RPersist_SafeHandle == null)
				{
					r_RPersist_SafeHandle = new(this, "Persist", 0, typeof(System.Runtime.InteropServices.SafeHandle));
					r_RPersist_SafeHandle.SetBelong(this.instance);
				}
				return r_RPersist_SafeHandle;
			}
		}

		/// <summary>
		/// Void Persist(System.Runtime.InteropServices.SafeHandle, System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_RPersist_SafeHandle_AccessControlSections;
		public virtual RMethod RPersist_SafeHandle_AccessControlSections
		{
			get
			{
				if(r_RPersist_SafeHandle_AccessControlSections == null)
				{
					r_RPersist_SafeHandle_AccessControlSections = new(this, "Persist", 0, typeof(System.Runtime.InteropServices.SafeHandle), typeof(System.Security.AccessControl.AccessControlSections));
					r_RPersist_SafeHandle_AccessControlSections.SetBelong(this.instance);
				}
				return r_RPersist_SafeHandle_AccessControlSections;
			}
		}

		/// <summary>
		/// Void Persist(System.String, System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_RPersist_String_AccessControlSections;
		public virtual RMethod RPersist_String_AccessControlSections
		{
			get
			{
				if(r_RPersist_String_AccessControlSections == null)
				{
					r_RPersist_String_AccessControlSections = new(this, "Persist", 0, typeof(System.String), typeof(System.Security.AccessControl.AccessControlSections));
					r_RPersist_String_AccessControlSections.SetBelong(this.instance);
				}
				return r_RPersist_String_AccessControlSections;
			}
		}

		/// <summary>
		/// Void PersistModifications(System.Runtime.InteropServices.SafeHandle)
		/// </summary>
		protected RMethod r_RPersistModifications_SafeHandle;
		public virtual RMethod RPersistModifications_SafeHandle
		{
			get
			{
				if(r_RPersistModifications_SafeHandle == null)
				{
					r_RPersistModifications_SafeHandle = new(this, "PersistModifications", 0, typeof(System.Runtime.InteropServices.SafeHandle));
					r_RPersistModifications_SafeHandle.SetBelong(this.instance);
				}
				return r_RPersistModifications_SafeHandle;
			}
		}

		/// <summary>
		/// Void Persist(System.Runtime.InteropServices.SafeHandle, System.Security.AccessControl.AccessControlSections, System.Object)
		/// </summary>
		protected RMethod r_RPersist_SafeHandle_AccessControlSections_Object;
		public virtual RMethod RPersist_SafeHandle_AccessControlSections_Object
		{
			get
			{
				if(r_RPersist_SafeHandle_AccessControlSections_Object == null)
				{
					r_RPersist_SafeHandle_AccessControlSections_Object = new(this, "Persist", 0, typeof(System.Runtime.InteropServices.SafeHandle), typeof(System.Security.AccessControl.AccessControlSections), typeof(System.Object));
					r_RPersist_SafeHandle_AccessControlSections_Object.SetBelong(this.instance);
				}
				return r_RPersist_SafeHandle_AccessControlSections_Object;
			}
		}

		/// <summary>
		/// Void PersistModifications(System.String)
		/// </summary>
		protected RMethod r_RPersistModifications_String;
		public virtual RMethod RPersistModifications_String
		{
			get
			{
				if(r_RPersistModifications_String == null)
				{
					r_RPersistModifications_String = new(this, "PersistModifications", 0, typeof(System.String));
					r_RPersistModifications_String.SetBelong(this.instance);
				}
				return r_RPersistModifications_String;
			}
		}

		/// <summary>
		/// Void Persist(System.String, System.Security.AccessControl.AccessControlSections, System.Object)
		/// </summary>
		protected RMethod r_RPersist_String_AccessControlSections_Object;
		public virtual RMethod RPersist_String_AccessControlSections_Object
		{
			get
			{
				if(r_RPersist_String_AccessControlSections_Object == null)
				{
					r_RPersist_String_AccessControlSections_Object = new(this, "Persist", 0, typeof(System.String), typeof(System.Security.AccessControl.AccessControlSections), typeof(System.Object));
					r_RPersist_String_AccessControlSections_Object.SetBelong(this.instance);
				}
				return r_RPersist_String_AccessControlSections_Object;
			}
		}

		/// <summary>
		/// Int32 InternalGet(System.Runtime.InteropServices.SafeHandle, System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_RInternalGet_SafeHandle_AccessControlSections;
		public virtual RMethod RInternalGet_SafeHandle_AccessControlSections
		{
			get
			{
				if(r_RInternalGet_SafeHandle_AccessControlSections == null)
				{
					r_RInternalGet_SafeHandle_AccessControlSections = new(this, "InternalGet", 0, typeof(System.Runtime.InteropServices.SafeHandle), typeof(System.Security.AccessControl.AccessControlSections));
					r_RInternalGet_SafeHandle_AccessControlSections.SetBelong(this.instance);
				}
				return r_RInternalGet_SafeHandle_AccessControlSections;
			}
		}

		/// <summary>
		/// Int32 InternalGet(System.String, System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_RInternalGet_String_AccessControlSections;
		public virtual RMethod RInternalGet_String_AccessControlSections
		{
			get
			{
				if(r_RInternalGet_String_AccessControlSections == null)
				{
					r_RInternalGet_String_AccessControlSections = new(this, "InternalGet", 0, typeof(System.String), typeof(System.Security.AccessControl.AccessControlSections));
					r_RInternalGet_String_AccessControlSections.SetBelong(this.instance);
				}
				return r_RInternalGet_String_AccessControlSections;
			}
		}

		/// <summary>
		/// Int32 InternalSet(System.Runtime.InteropServices.SafeHandle, System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_RInternalSet_SafeHandle_AccessControlSections;
		public virtual RMethod RInternalSet_SafeHandle_AccessControlSections
		{
			get
			{
				if(r_RInternalSet_SafeHandle_AccessControlSections == null)
				{
					r_RInternalSet_SafeHandle_AccessControlSections = new(this, "InternalSet", 0, typeof(System.Runtime.InteropServices.SafeHandle), typeof(System.Security.AccessControl.AccessControlSections));
					r_RInternalSet_SafeHandle_AccessControlSections.SetBelong(this.instance);
				}
				return r_RInternalSet_SafeHandle_AccessControlSections;
			}
		}

		/// <summary>
		/// Int32 InternalSet(System.String, System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_RInternalSet_String_AccessControlSections;
		public virtual RMethod RInternalSet_String_AccessControlSections
		{
			get
			{
				if(r_RInternalSet_String_AccessControlSections == null)
				{
					r_RInternalSet_String_AccessControlSections = new(this, "InternalSet", 0, typeof(System.String), typeof(System.Security.AccessControl.AccessControlSections));
					r_RInternalSet_String_AccessControlSections.SetBelong(this.instance);
				}
				return r_RInternalSet_String_AccessControlSections;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AuthorizationRuleCollection GetAccessRules(Boolean, Boolean, System.Type)
		/// </summary>
		protected RMethod r_RGetAccessRules_Boolean_Boolean_Type;
		public virtual RMethod RGetAccessRules_Boolean_Boolean_Type
		{
			get
			{
				if(r_RGetAccessRules_Boolean_Boolean_Type == null)
				{
					r_RGetAccessRules_Boolean_Boolean_Type = new(this, "GetAccessRules", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Type));
					r_RGetAccessRules_Boolean_Boolean_Type.SetBelong(this.instance);
				}
				return r_RGetAccessRules_Boolean_Boolean_Type;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AuthorizationRuleCollection GetAuditRules(Boolean, Boolean, System.Type)
		/// </summary>
		protected RMethod r_RGetAuditRules_Boolean_Boolean_Type;
		public virtual RMethod RGetAuditRules_Boolean_Boolean_Type
		{
			get
			{
				if(r_RGetAuditRules_Boolean_Boolean_Type == null)
				{
					r_RGetAuditRules_Boolean_Boolean_Type = new(this, "GetAuditRules", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Type));
					r_RGetAuditRules_Boolean_Boolean_Type.SetBelong(this.instance);
				}
				return r_RGetAuditRules_Boolean_Boolean_Type;
			}
		}

		/// <summary>
		/// Void AddAccessRule(System.Security.AccessControl.AccessRule)
		/// </summary>
		protected RMethod r_RAddAccessRule_AccessRule;
		public virtual RMethod RAddAccessRule_AccessRule
		{
			get
			{
				if(r_RAddAccessRule_AccessRule == null)
				{
					r_RAddAccessRule_AccessRule = new(this, "AddAccessRule", 0, typeof(System.Security.AccessControl.AccessRule));
					r_RAddAccessRule_AccessRule.SetBelong(this.instance);
				}
				return r_RAddAccessRule_AccessRule;
			}
		}

		/// <summary>
		/// Boolean RemoveAccessRule(System.Security.AccessControl.AccessRule)
		/// </summary>
		protected RMethod r_RRemoveAccessRule_AccessRule;
		public virtual RMethod RRemoveAccessRule_AccessRule
		{
			get
			{
				if(r_RRemoveAccessRule_AccessRule == null)
				{
					r_RRemoveAccessRule_AccessRule = new(this, "RemoveAccessRule", 0, typeof(System.Security.AccessControl.AccessRule));
					r_RRemoveAccessRule_AccessRule.SetBelong(this.instance);
				}
				return r_RRemoveAccessRule_AccessRule;
			}
		}

		/// <summary>
		/// Void RemoveAccessRuleAll(System.Security.AccessControl.AccessRule)
		/// </summary>
		protected RMethod r_RRemoveAccessRuleAll_AccessRule;
		public virtual RMethod RRemoveAccessRuleAll_AccessRule
		{
			get
			{
				if(r_RRemoveAccessRuleAll_AccessRule == null)
				{
					r_RRemoveAccessRuleAll_AccessRule = new(this, "RemoveAccessRuleAll", 0, typeof(System.Security.AccessControl.AccessRule));
					r_RRemoveAccessRuleAll_AccessRule.SetBelong(this.instance);
				}
				return r_RRemoveAccessRuleAll_AccessRule;
			}
		}

		/// <summary>
		/// Void RemoveAccessRuleSpecific(System.Security.AccessControl.AccessRule)
		/// </summary>
		protected RMethod r_RRemoveAccessRuleSpecific_AccessRule;
		public virtual RMethod RRemoveAccessRuleSpecific_AccessRule
		{
			get
			{
				if(r_RRemoveAccessRuleSpecific_AccessRule == null)
				{
					r_RRemoveAccessRuleSpecific_AccessRule = new(this, "RemoveAccessRuleSpecific", 0, typeof(System.Security.AccessControl.AccessRule));
					r_RRemoveAccessRuleSpecific_AccessRule.SetBelong(this.instance);
				}
				return r_RRemoveAccessRuleSpecific_AccessRule;
			}
		}

		/// <summary>
		/// Void ResetAccessRule(System.Security.AccessControl.AccessRule)
		/// </summary>
		protected RMethod r_RResetAccessRule_AccessRule;
		public virtual RMethod RResetAccessRule_AccessRule
		{
			get
			{
				if(r_RResetAccessRule_AccessRule == null)
				{
					r_RResetAccessRule_AccessRule = new(this, "ResetAccessRule", 0, typeof(System.Security.AccessControl.AccessRule));
					r_RResetAccessRule_AccessRule.SetBelong(this.instance);
				}
				return r_RResetAccessRule_AccessRule;
			}
		}

		/// <summary>
		/// Void SetAccessRule(System.Security.AccessControl.AccessRule)
		/// </summary>
		protected RMethod r_RSetAccessRule_AccessRule;
		public virtual RMethod RSetAccessRule_AccessRule
		{
			get
			{
				if(r_RSetAccessRule_AccessRule == null)
				{
					r_RSetAccessRule_AccessRule = new(this, "SetAccessRule", 0, typeof(System.Security.AccessControl.AccessRule));
					r_RSetAccessRule_AccessRule.SetBelong(this.instance);
				}
				return r_RSetAccessRule_AccessRule;
			}
		}

		/// <summary>
		/// Boolean ModifyAccess(System.Security.AccessControl.AccessControlModification, System.Security.AccessControl.AccessRule, Boolean ByRef)
		/// </summary>
		protected RMethod r_RModifyAccess_AccessControlModification_AccessRule_Out_Boolean;
		public virtual RMethod RModifyAccess_AccessControlModification_AccessRule_Out_Boolean
		{
			get
			{
				if(r_RModifyAccess_AccessControlModification_AccessRule_Out_Boolean == null)
				{
					r_RModifyAccess_AccessControlModification_AccessRule_Out_Boolean = new(this, "ModifyAccess", 0, typeof(System.Security.AccessControl.AccessControlModification), typeof(System.Security.AccessControl.AccessRule), typeof(System.Boolean).MakeByRefType());
					r_RModifyAccess_AccessControlModification_AccessRule_Out_Boolean.SetBelong(this.instance);
				}
				return r_RModifyAccess_AccessControlModification_AccessRule_Out_Boolean;
			}
		}

		/// <summary>
		/// Void AddAuditRule(System.Security.AccessControl.AuditRule)
		/// </summary>
		protected RMethod r_RAddAuditRule_AuditRule;
		public virtual RMethod RAddAuditRule_AuditRule
		{
			get
			{
				if(r_RAddAuditRule_AuditRule == null)
				{
					r_RAddAuditRule_AuditRule = new(this, "AddAuditRule", 0, typeof(System.Security.AccessControl.AuditRule));
					r_RAddAuditRule_AuditRule.SetBelong(this.instance);
				}
				return r_RAddAuditRule_AuditRule;
			}
		}

		/// <summary>
		/// Boolean RemoveAuditRule(System.Security.AccessControl.AuditRule)
		/// </summary>
		protected RMethod r_RRemoveAuditRule_AuditRule;
		public virtual RMethod RRemoveAuditRule_AuditRule
		{
			get
			{
				if(r_RRemoveAuditRule_AuditRule == null)
				{
					r_RRemoveAuditRule_AuditRule = new(this, "RemoveAuditRule", 0, typeof(System.Security.AccessControl.AuditRule));
					r_RRemoveAuditRule_AuditRule.SetBelong(this.instance);
				}
				return r_RRemoveAuditRule_AuditRule;
			}
		}

		/// <summary>
		/// Void RemoveAuditRuleAll(System.Security.AccessControl.AuditRule)
		/// </summary>
		protected RMethod r_RRemoveAuditRuleAll_AuditRule;
		public virtual RMethod RRemoveAuditRuleAll_AuditRule
		{
			get
			{
				if(r_RRemoveAuditRuleAll_AuditRule == null)
				{
					r_RRemoveAuditRuleAll_AuditRule = new(this, "RemoveAuditRuleAll", 0, typeof(System.Security.AccessControl.AuditRule));
					r_RRemoveAuditRuleAll_AuditRule.SetBelong(this.instance);
				}
				return r_RRemoveAuditRuleAll_AuditRule;
			}
		}

		/// <summary>
		/// Void RemoveAuditRuleSpecific(System.Security.AccessControl.AuditRule)
		/// </summary>
		protected RMethod r_RRemoveAuditRuleSpecific_AuditRule;
		public virtual RMethod RRemoveAuditRuleSpecific_AuditRule
		{
			get
			{
				if(r_RRemoveAuditRuleSpecific_AuditRule == null)
				{
					r_RRemoveAuditRuleSpecific_AuditRule = new(this, "RemoveAuditRuleSpecific", 0, typeof(System.Security.AccessControl.AuditRule));
					r_RRemoveAuditRuleSpecific_AuditRule.SetBelong(this.instance);
				}
				return r_RRemoveAuditRuleSpecific_AuditRule;
			}
		}

		/// <summary>
		/// Void SetAuditRule(System.Security.AccessControl.AuditRule)
		/// </summary>
		protected RMethod r_RSetAuditRule_AuditRule;
		public virtual RMethod RSetAuditRule_AuditRule
		{
			get
			{
				if(r_RSetAuditRule_AuditRule == null)
				{
					r_RSetAuditRule_AuditRule = new(this, "SetAuditRule", 0, typeof(System.Security.AccessControl.AuditRule));
					r_RSetAuditRule_AuditRule.SetBelong(this.instance);
				}
				return r_RSetAuditRule_AuditRule;
			}
		}

		/// <summary>
		/// Boolean ModifyAudit(System.Security.AccessControl.AccessControlModification, System.Security.AccessControl.AuditRule, Boolean ByRef)
		/// </summary>
		protected RMethod r_RModifyAudit_AccessControlModification_AuditRule_Out_Boolean;
		public virtual RMethod RModifyAudit_AccessControlModification_AuditRule_Out_Boolean
		{
			get
			{
				if(r_RModifyAudit_AccessControlModification_AuditRule_Out_Boolean == null)
				{
					r_RModifyAudit_AccessControlModification_AuditRule_Out_Boolean = new(this, "ModifyAudit", 0, typeof(System.Security.AccessControl.AccessControlModification), typeof(System.Security.AccessControl.AuditRule), typeof(System.Boolean).MakeByRefType());
					r_RModifyAudit_AccessControlModification_AuditRule_Out_Boolean.SetBelong(this.instance);
				}
				return r_RModifyAudit_AccessControlModification_AuditRule_Out_Boolean;
			}
		}

		/// <summary>
		/// System.Security.Principal.IdentityReference GetGroup(System.Type)
		/// </summary>
		protected RMethod r_RGetGroup_Type;
		public virtual RMethod RGetGroup_Type
		{
			get
			{
				if(r_RGetGroup_Type == null)
				{
					r_RGetGroup_Type = new(this, "GetGroup", 0, typeof(System.Type));
					r_RGetGroup_Type.SetBelong(this.instance);
				}
				return r_RGetGroup_Type;
			}
		}

		/// <summary>
		/// System.Security.Principal.IdentityReference GetOwner(System.Type)
		/// </summary>
		protected RMethod r_RGetOwner_Type;
		public virtual RMethod RGetOwner_Type
		{
			get
			{
				if(r_RGetOwner_Type == null)
				{
					r_RGetOwner_Type = new(this, "GetOwner", 0, typeof(System.Type));
					r_RGetOwner_Type.SetBelong(this.instance);
				}
				return r_RGetOwner_Type;
			}
		}

		/// <summary>
		/// Byte[] GetSecurityDescriptorBinaryForm()
		/// </summary>
		protected RMethod r_RGetSecurityDescriptorBinaryForm;
		public virtual RMethod RGetSecurityDescriptorBinaryForm
		{
			get
			{
				if(r_RGetSecurityDescriptorBinaryForm == null)
				{
					r_RGetSecurityDescriptorBinaryForm = new(this, "GetSecurityDescriptorBinaryForm", 0);
					r_RGetSecurityDescriptorBinaryForm.SetBelong(this.instance);
				}
				return r_RGetSecurityDescriptorBinaryForm;
			}
		}

		/// <summary>
		/// System.String GetSecurityDescriptorSddlForm(System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_RGetSecurityDescriptorSddlForm_AccessControlSections;
		public virtual RMethod RGetSecurityDescriptorSddlForm_AccessControlSections
		{
			get
			{
				if(r_RGetSecurityDescriptorSddlForm_AccessControlSections == null)
				{
					r_RGetSecurityDescriptorSddlForm_AccessControlSections = new(this, "GetSecurityDescriptorSddlForm", 0, typeof(System.Security.AccessControl.AccessControlSections));
					r_RGetSecurityDescriptorSddlForm_AccessControlSections.SetBelong(this.instance);
				}
				return r_RGetSecurityDescriptorSddlForm_AccessControlSections;
			}
		}

		/// <summary>
		/// Boolean ModifyAccessRule(System.Security.AccessControl.AccessControlModification, System.Security.AccessControl.AccessRule, Boolean ByRef)
		/// </summary>
		protected RMethod r_RModifyAccessRule_AccessControlModification_AccessRule_Out_Boolean;
		public virtual RMethod RModifyAccessRule_AccessControlModification_AccessRule_Out_Boolean
		{
			get
			{
				if(r_RModifyAccessRule_AccessControlModification_AccessRule_Out_Boolean == null)
				{
					r_RModifyAccessRule_AccessControlModification_AccessRule_Out_Boolean = new(this, "ModifyAccessRule", 0, typeof(System.Security.AccessControl.AccessControlModification), typeof(System.Security.AccessControl.AccessRule), typeof(System.Boolean).MakeByRefType());
					r_RModifyAccessRule_AccessControlModification_AccessRule_Out_Boolean.SetBelong(this.instance);
				}
				return r_RModifyAccessRule_AccessControlModification_AccessRule_Out_Boolean;
			}
		}

		/// <summary>
		/// Boolean ModifyAuditRule(System.Security.AccessControl.AccessControlModification, System.Security.AccessControl.AuditRule, Boolean ByRef)
		/// </summary>
		protected RMethod r_RModifyAuditRule_AccessControlModification_AuditRule_Out_Boolean;
		public virtual RMethod RModifyAuditRule_AccessControlModification_AuditRule_Out_Boolean
		{
			get
			{
				if(r_RModifyAuditRule_AccessControlModification_AuditRule_Out_Boolean == null)
				{
					r_RModifyAuditRule_AccessControlModification_AuditRule_Out_Boolean = new(this, "ModifyAuditRule", 0, typeof(System.Security.AccessControl.AccessControlModification), typeof(System.Security.AccessControl.AuditRule), typeof(System.Boolean).MakeByRefType());
					r_RModifyAuditRule_AccessControlModification_AuditRule_Out_Boolean.SetBelong(this.instance);
				}
				return r_RModifyAuditRule_AccessControlModification_AuditRule_Out_Boolean;
			}
		}

		/// <summary>
		/// Void PurgeAccessRules(System.Security.Principal.IdentityReference)
		/// </summary>
		protected RMethod r_RPurgeAccessRules_IdentityReference;
		public virtual RMethod RPurgeAccessRules_IdentityReference
		{
			get
			{
				if(r_RPurgeAccessRules_IdentityReference == null)
				{
					r_RPurgeAccessRules_IdentityReference = new(this, "PurgeAccessRules", 0, typeof(System.Security.Principal.IdentityReference));
					r_RPurgeAccessRules_IdentityReference.SetBelong(this.instance);
				}
				return r_RPurgeAccessRules_IdentityReference;
			}
		}

		/// <summary>
		/// Void PurgeAuditRules(System.Security.Principal.IdentityReference)
		/// </summary>
		protected RMethod r_RPurgeAuditRules_IdentityReference;
		public virtual RMethod RPurgeAuditRules_IdentityReference
		{
			get
			{
				if(r_RPurgeAuditRules_IdentityReference == null)
				{
					r_RPurgeAuditRules_IdentityReference = new(this, "PurgeAuditRules", 0, typeof(System.Security.Principal.IdentityReference));
					r_RPurgeAuditRules_IdentityReference.SetBelong(this.instance);
				}
				return r_RPurgeAuditRules_IdentityReference;
			}
		}

		/// <summary>
		/// Void SetAccessRuleProtection(Boolean, Boolean)
		/// </summary>
		protected RMethod r_RSetAccessRuleProtection_Boolean_Boolean;
		public virtual RMethod RSetAccessRuleProtection_Boolean_Boolean
		{
			get
			{
				if(r_RSetAccessRuleProtection_Boolean_Boolean == null)
				{
					r_RSetAccessRuleProtection_Boolean_Boolean = new(this, "SetAccessRuleProtection", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_RSetAccessRuleProtection_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RSetAccessRuleProtection_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void SetAuditRuleProtection(Boolean, Boolean)
		/// </summary>
		protected RMethod r_RSetAuditRuleProtection_Boolean_Boolean;
		public virtual RMethod RSetAuditRuleProtection_Boolean_Boolean
		{
			get
			{
				if(r_RSetAuditRuleProtection_Boolean_Boolean == null)
				{
					r_RSetAuditRuleProtection_Boolean_Boolean = new(this, "SetAuditRuleProtection", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_RSetAuditRuleProtection_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RSetAuditRuleProtection_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void SetGroup(System.Security.Principal.IdentityReference)
		/// </summary>
		protected RMethod r_RSetGroup_IdentityReference;
		public virtual RMethod RSetGroup_IdentityReference
		{
			get
			{
				if(r_RSetGroup_IdentityReference == null)
				{
					r_RSetGroup_IdentityReference = new(this, "SetGroup", 0, typeof(System.Security.Principal.IdentityReference));
					r_RSetGroup_IdentityReference.SetBelong(this.instance);
				}
				return r_RSetGroup_IdentityReference;
			}
		}

		/// <summary>
		/// Void SetOwner(System.Security.Principal.IdentityReference)
		/// </summary>
		protected RMethod r_RSetOwner_IdentityReference;
		public virtual RMethod RSetOwner_IdentityReference
		{
			get
			{
				if(r_RSetOwner_IdentityReference == null)
				{
					r_RSetOwner_IdentityReference = new(this, "SetOwner", 0, typeof(System.Security.Principal.IdentityReference));
					r_RSetOwner_IdentityReference.SetBelong(this.instance);
				}
				return r_RSetOwner_IdentityReference;
			}
		}

		/// <summary>
		/// Void SetSecurityDescriptorBinaryForm(Byte[])
		/// </summary>
		protected RMethod r_RSetSecurityDescriptorBinaryForm_ByteArray;
		public virtual RMethod RSetSecurityDescriptorBinaryForm_ByteArray
		{
			get
			{
				if(r_RSetSecurityDescriptorBinaryForm_ByteArray == null)
				{
					r_RSetSecurityDescriptorBinaryForm_ByteArray = new(this, "SetSecurityDescriptorBinaryForm", 0, typeof(System.Byte).MakeArrayType());
					r_RSetSecurityDescriptorBinaryForm_ByteArray.SetBelong(this.instance);
				}
				return r_RSetSecurityDescriptorBinaryForm_ByteArray;
			}
		}

		/// <summary>
		/// Void SetSecurityDescriptorBinaryForm(Byte[], System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_RSetSecurityDescriptorBinaryForm_ByteArray_AccessControlSections;
		public virtual RMethod RSetSecurityDescriptorBinaryForm_ByteArray_AccessControlSections
		{
			get
			{
				if(r_RSetSecurityDescriptorBinaryForm_ByteArray_AccessControlSections == null)
				{
					r_RSetSecurityDescriptorBinaryForm_ByteArray_AccessControlSections = new(this, "SetSecurityDescriptorBinaryForm", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Security.AccessControl.AccessControlSections));
					r_RSetSecurityDescriptorBinaryForm_ByteArray_AccessControlSections.SetBelong(this.instance);
				}
				return r_RSetSecurityDescriptorBinaryForm_ByteArray_AccessControlSections;
			}
		}

		/// <summary>
		/// Void SetSecurityDescriptorSddlForm(System.String)
		/// </summary>
		protected RMethod r_RSetSecurityDescriptorSddlForm_String;
		public virtual RMethod RSetSecurityDescriptorSddlForm_String
		{
			get
			{
				if(r_RSetSecurityDescriptorSddlForm_String == null)
				{
					r_RSetSecurityDescriptorSddlForm_String = new(this, "SetSecurityDescriptorSddlForm", 0, typeof(System.String));
					r_RSetSecurityDescriptorSddlForm_String.SetBelong(this.instance);
				}
				return r_RSetSecurityDescriptorSddlForm_String;
			}
		}

		/// <summary>
		/// Void SetSecurityDescriptorSddlForm(System.String, System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_RSetSecurityDescriptorSddlForm_String_AccessControlSections;
		public virtual RMethod RSetSecurityDescriptorSddlForm_String_AccessControlSections
		{
			get
			{
				if(r_RSetSecurityDescriptorSddlForm_String_AccessControlSections == null)
				{
					r_RSetSecurityDescriptorSddlForm_String_AccessControlSections = new(this, "SetSecurityDescriptorSddlForm", 0, typeof(System.String), typeof(System.Security.AccessControl.AccessControlSections));
					r_RSetSecurityDescriptorSddlForm_String_AccessControlSections.SetBelong(this.instance);
				}
				return r_RSetSecurityDescriptorSddlForm_String_AccessControlSections;
			}
		}

		/// <summary>
		/// Void Persist(Boolean, System.String, System.Security.AccessControl.AccessControlSections)
		/// </summary>
		protected RMethod r_RPersist_Boolean_String_AccessControlSections;
		public virtual RMethod RPersist_Boolean_String_AccessControlSections
		{
			get
			{
				if(r_RPersist_Boolean_String_AccessControlSections == null)
				{
					r_RPersist_Boolean_String_AccessControlSections = new(this, "Persist", 0, typeof(System.Boolean), typeof(System.String), typeof(System.Security.AccessControl.AccessControlSections));
					r_RPersist_Boolean_String_AccessControlSections.SetBelong(this.instance);
				}
				return r_RPersist_Boolean_String_AccessControlSections;
			}
		}

		/// <summary>
		/// Void ReadLock()
		/// </summary>
		protected RMethod r_RReadLock;
		public virtual RMethod RReadLock
		{
			get
			{
				if(r_RReadLock == null)
				{
					r_RReadLock = new(this, "ReadLock", 0);
					r_RReadLock.SetBelong(this.instance);
				}
				return r_RReadLock;
			}
		}

		/// <summary>
		/// Void ReadUnlock()
		/// </summary>
		protected RMethod r_RReadUnlock;
		public virtual RMethod RReadUnlock
		{
			get
			{
				if(r_RReadUnlock == null)
				{
					r_RReadUnlock = new(this, "ReadUnlock", 0);
					r_RReadUnlock.SetBelong(this.instance);
				}
				return r_RReadUnlock;
			}
		}

		/// <summary>
		/// Void WriteLock()
		/// </summary>
		protected RMethod r_RWriteLock;
		public virtual RMethod RWriteLock
		{
			get
			{
				if(r_RWriteLock == null)
				{
					r_RWriteLock = new(this, "WriteLock", 0);
					r_RWriteLock.SetBelong(this.instance);
				}
				return r_RWriteLock;
			}
		}

		/// <summary>
		/// Void WriteUnlock()
		/// </summary>
		protected RMethod r_RWriteUnlock;
		public virtual RMethod RWriteUnlock
		{
			get
			{
				if(r_RWriteUnlock == null)
				{
					r_RWriteUnlock = new(this, "WriteUnlock", 0);
					r_RWriteUnlock.SetBelong(this.instance);
				}
				return r_RWriteUnlock;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AuthorizationRuleCollection InternalGetAccessRules(Boolean, Boolean, System.Type)
		/// </summary>
		protected RMethod r_RInternalGetAccessRules_Boolean_Boolean_Type;
		public virtual RMethod RInternalGetAccessRules_Boolean_Boolean_Type
		{
			get
			{
				if(r_RInternalGetAccessRules_Boolean_Boolean_Type == null)
				{
					r_RInternalGetAccessRules_Boolean_Boolean_Type = new(this, "InternalGetAccessRules", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Type));
					r_RInternalGetAccessRules_Boolean_Boolean_Type.SetBelong(this.instance);
				}
				return r_RInternalGetAccessRules_Boolean_Boolean_Type;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AccessRule InternalAccessRuleFactory(System.Security.AccessControl.QualifiedAce, System.Type, System.Security.AccessControl.AccessControlType)
		/// </summary>
		protected RMethod r_RInternalAccessRuleFactory_QualifiedAce_Type_AccessControlType;
		public virtual RMethod RInternalAccessRuleFactory_QualifiedAce_Type_AccessControlType
		{
			get
			{
				if(r_RInternalAccessRuleFactory_QualifiedAce_Type_AccessControlType == null)
				{
					r_RInternalAccessRuleFactory_QualifiedAce_Type_AccessControlType = new(this, "InternalAccessRuleFactory", 0, typeof(System.Security.AccessControl.QualifiedAce), typeof(System.Type), typeof(System.Security.AccessControl.AccessControlType));
					r_RInternalAccessRuleFactory_QualifiedAce_Type_AccessControlType.SetBelong(this.instance);
				}
				return r_RInternalAccessRuleFactory_QualifiedAce_Type_AccessControlType;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AuthorizationRuleCollection InternalGetAuditRules(Boolean, Boolean, System.Type)
		/// </summary>
		protected RMethod r_RInternalGetAuditRules_Boolean_Boolean_Type;
		public virtual RMethod RInternalGetAuditRules_Boolean_Boolean_Type
		{
			get
			{
				if(r_RInternalGetAuditRules_Boolean_Boolean_Type == null)
				{
					r_RInternalGetAuditRules_Boolean_Boolean_Type = new(this, "InternalGetAuditRules", 0, typeof(System.Boolean), typeof(System.Boolean), typeof(System.Type));
					r_RInternalGetAuditRules_Boolean_Boolean_Type.SetBelong(this.instance);
				}
				return r_RInternalGetAuditRules_Boolean_Boolean_Type;
			}
		}

		/// <summary>
		/// System.Security.AccessControl.AuditRule InternalAuditRuleFactory(System.Security.AccessControl.QualifiedAce, System.Type)
		/// </summary>
		protected RMethod r_RInternalAuditRuleFactory_QualifiedAce_Type;
		public virtual RMethod RInternalAuditRuleFactory_QualifiedAce_Type
		{
			get
			{
				if(r_RInternalAuditRuleFactory_QualifiedAce_Type == null)
				{
					r_RInternalAuditRuleFactory_QualifiedAce_Type = new(this, "InternalAuditRuleFactory", 0, typeof(System.Security.AccessControl.QualifiedAce), typeof(System.Type));
					r_RInternalAuditRuleFactory_QualifiedAce_Type.SetBelong(this.instance);
				}
				return r_RInternalAuditRuleFactory_QualifiedAce_Type;
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


        public REventWaitHandleSecurity() : base("System.Security.AccessControl.EventWaitHandleSecurity")
        {
        }

        public REventWaitHandleSecurity(System.Object instance) : base("System.Security.AccessControl.EventWaitHandleSecurity")
		{
            SetInstance(instance);
		}

        public REventWaitHandleSecurity(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REventWaitHandleSecurity(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Security.AccessControl.AccessRule AccessRuleFactory(System.Security.Principal.IdentityReference  @identityReference, System.Int32  @accessMask, System.Boolean  @isInherited, System.Security.AccessControl.InheritanceFlags  @inheritanceFlags, System.Security.AccessControl.PropagationFlags  @propagationFlags, System.Security.AccessControl.AccessControlType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@identityReference, @accessMask, @isInherited, @inheritanceFlags, @propagationFlags, @type};
            var ___result = RAccessRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AccessControlType.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AccessRule)___result;
        }


        public virtual void AddAccessRule(System.Security.AccessControl.EventWaitHandleAccessRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RAddAccessRule_EventWaitHandleAccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean RemoveAccessRule(System.Security.AccessControl.EventWaitHandleAccessRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RRemoveAccessRule_EventWaitHandleAccessRule.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RemoveAccessRuleAll(System.Security.AccessControl.EventWaitHandleAccessRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RRemoveAccessRuleAll_EventWaitHandleAccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAccessRuleSpecific(System.Security.AccessControl.EventWaitHandleAccessRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RRemoveAccessRuleSpecific_EventWaitHandleAccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetAccessRule(System.Security.AccessControl.EventWaitHandleAccessRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RResetAccessRule_EventWaitHandleAccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAccessRule(System.Security.AccessControl.EventWaitHandleAccessRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RSetAccessRule_EventWaitHandleAccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.AccessControl.AuditRule AuditRuleFactory(System.Security.Principal.IdentityReference  @identityReference, System.Int32  @accessMask, System.Boolean  @isInherited, System.Security.AccessControl.InheritanceFlags  @inheritanceFlags, System.Security.AccessControl.PropagationFlags  @propagationFlags, System.Security.AccessControl.AuditFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@identityReference, @accessMask, @isInherited, @inheritanceFlags, @propagationFlags, @flags};
            var ___result = RAuditRuleFactory_IdentityReference_Int32_Boolean_InheritanceFlags_PropagationFlags_AuditFlags.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AuditRule)___result;
        }


        public virtual void AddAuditRule(System.Security.AccessControl.EventWaitHandleAuditRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RAddAuditRule_EventWaitHandleAuditRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean RemoveAuditRule(System.Security.AccessControl.EventWaitHandleAuditRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RRemoveAuditRule_EventWaitHandleAuditRule.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RemoveAuditRuleAll(System.Security.AccessControl.EventWaitHandleAuditRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RRemoveAuditRuleAll_EventWaitHandleAuditRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAuditRuleSpecific(System.Security.AccessControl.EventWaitHandleAuditRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RRemoveAuditRuleSpecific_EventWaitHandleAuditRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAuditRule(System.Security.AccessControl.EventWaitHandleAuditRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RSetAuditRule_EventWaitHandleAuditRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Persist(System.Runtime.InteropServices.SafeHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RPersist_SafeHandle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Persist(System.Runtime.InteropServices.SafeHandle  @handle, System.Security.AccessControl.AccessControlSections  @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @includeSections};
            var ___result = RPersist_SafeHandle_AccessControlSections.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Persist(System.String  @name, System.Security.AccessControl.AccessControlSections  @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @includeSections};
            var ___result = RPersist_String_AccessControlSections.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PersistModifications(System.Runtime.InteropServices.SafeHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RPersistModifications_SafeHandle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Persist(System.Runtime.InteropServices.SafeHandle  @handle, System.Security.AccessControl.AccessControlSections  @includeSections, System.Object  @exceptionContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @includeSections, @exceptionContext};
            var ___result = RPersist_SafeHandle_AccessControlSections_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PersistModifications(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RPersistModifications_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Persist(System.String  @name, System.Security.AccessControl.AccessControlSections  @includeSections, System.Object  @exceptionContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @includeSections, @exceptionContext};
            var ___result = RPersist_String_AccessControlSections_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 InternalGet(System.Runtime.InteropServices.SafeHandle  @handle, System.Security.AccessControl.AccessControlSections  @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @includeSections};
            var ___result = RInternalGet_SafeHandle_AccessControlSections.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 InternalGet(System.String  @name, System.Security.AccessControl.AccessControlSections  @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @includeSections};
            var ___result = RInternalGet_String_AccessControlSections.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 InternalSet(System.Runtime.InteropServices.SafeHandle  @handle, System.Security.AccessControl.AccessControlSections  @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @includeSections};
            var ___result = RInternalSet_SafeHandle_AccessControlSections.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 InternalSet(System.String  @name, System.Security.AccessControl.AccessControlSections  @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @includeSections};
            var ___result = RInternalSet_String_AccessControlSections.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Security.AccessControl.AuthorizationRuleCollection GetAccessRules(System.Boolean  @includeExplicit, System.Boolean  @includeInherited, System.Type  @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includeExplicit, @includeInherited, @targetType};
            var ___result = RGetAccessRules_Boolean_Boolean_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AuthorizationRuleCollection)___result;
        }


        public virtual System.Security.AccessControl.AuthorizationRuleCollection GetAuditRules(System.Boolean  @includeExplicit, System.Boolean  @includeInherited, System.Type  @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includeExplicit, @includeInherited, @targetType};
            var ___result = RGetAuditRules_Boolean_Boolean_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AuthorizationRuleCollection)___result;
        }


        public virtual void AddAccessRule(System.Security.AccessControl.AccessRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RAddAccessRule_AccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean RemoveAccessRule(System.Security.AccessControl.AccessRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RRemoveAccessRule_AccessRule.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RemoveAccessRuleAll(System.Security.AccessControl.AccessRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RRemoveAccessRuleAll_AccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAccessRuleSpecific(System.Security.AccessControl.AccessRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RRemoveAccessRuleSpecific_AccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetAccessRule(System.Security.AccessControl.AccessRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RResetAccessRule_AccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAccessRule(System.Security.AccessControl.AccessRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RSetAccessRule_AccessRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ModifyAccess(System.Security.AccessControl.AccessControlModification  @modification, System.Security.AccessControl.AccessRule  @rule, out System.Boolean  @modified)
        {
			modified = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@modification, @rule, @modified};
            var ___result = RModifyAccess_AccessControlModification_AccessRule_Out_Boolean.Invoke(___genericsType, ___parameters);
			modified = (System.Boolean)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual void AddAuditRule(System.Security.AccessControl.AuditRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RAddAuditRule_AuditRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean RemoveAuditRule(System.Security.AccessControl.AuditRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RRemoveAuditRule_AuditRule.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RemoveAuditRuleAll(System.Security.AccessControl.AuditRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RRemoveAuditRuleAll_AuditRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAuditRuleSpecific(System.Security.AccessControl.AuditRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RRemoveAuditRuleSpecific_AuditRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAuditRule(System.Security.AccessControl.AuditRule  @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rule};
            var ___result = RSetAuditRule_AuditRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ModifyAudit(System.Security.AccessControl.AccessControlModification  @modification, System.Security.AccessControl.AuditRule  @rule, out System.Boolean  @modified)
        {
			modified = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@modification, @rule, @modified};
            var ___result = RModifyAudit_AccessControlModification_AuditRule_Out_Boolean.Invoke(___genericsType, ___parameters);
			modified = (System.Boolean)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual System.Security.Principal.IdentityReference GetGroup(System.Type  @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetType};
            var ___result = RGetGroup_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.Principal.IdentityReference)___result;
        }


        public virtual System.Security.Principal.IdentityReference GetOwner(System.Type  @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetType};
            var ___result = RGetOwner_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.Principal.IdentityReference)___result;
        }


        public virtual System.Byte[] GetSecurityDescriptorBinaryForm()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSecurityDescriptorBinaryForm.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.String GetSecurityDescriptorSddlForm(System.Security.AccessControl.AccessControlSections  @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includeSections};
            var ___result = RGetSecurityDescriptorSddlForm_AccessControlSections.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean ModifyAccessRule(System.Security.AccessControl.AccessControlModification  @modification, System.Security.AccessControl.AccessRule  @rule, out System.Boolean  @modified)
        {
			modified = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@modification, @rule, @modified};
            var ___result = RModifyAccessRule_AccessControlModification_AccessRule_Out_Boolean.Invoke(___genericsType, ___parameters);
			modified = (System.Boolean)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ModifyAuditRule(System.Security.AccessControl.AccessControlModification  @modification, System.Security.AccessControl.AuditRule  @rule, out System.Boolean  @modified)
        {
			modified = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@modification, @rule, @modified};
            var ___result = RModifyAuditRule_AccessControlModification_AuditRule_Out_Boolean.Invoke(___genericsType, ___parameters);
			modified = (System.Boolean)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual void PurgeAccessRules(System.Security.Principal.IdentityReference  @identity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@identity};
            var ___result = RPurgeAccessRules_IdentityReference.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PurgeAuditRules(System.Security.Principal.IdentityReference  @identity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@identity};
            var ___result = RPurgeAuditRules_IdentityReference.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAccessRuleProtection(System.Boolean  @isProtected, System.Boolean  @preserveInheritance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isProtected, @preserveInheritance};
            var ___result = RSetAccessRuleProtection_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAuditRuleProtection(System.Boolean  @isProtected, System.Boolean  @preserveInheritance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isProtected, @preserveInheritance};
            var ___result = RSetAuditRuleProtection_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGroup(System.Security.Principal.IdentityReference  @identity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@identity};
            var ___result = RSetGroup_IdentityReference.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetOwner(System.Security.Principal.IdentityReference  @identity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@identity};
            var ___result = RSetOwner_IdentityReference.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSecurityDescriptorBinaryForm(System.Byte[]  @binaryForm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binaryForm};
            var ___result = RSetSecurityDescriptorBinaryForm_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSecurityDescriptorBinaryForm(System.Byte[]  @binaryForm, System.Security.AccessControl.AccessControlSections  @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binaryForm, @includeSections};
            var ___result = RSetSecurityDescriptorBinaryForm_ByteArray_AccessControlSections.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSecurityDescriptorSddlForm(System.String  @sddlForm)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sddlForm};
            var ___result = RSetSecurityDescriptorSddlForm_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSecurityDescriptorSddlForm(System.String  @sddlForm, System.Security.AccessControl.AccessControlSections  @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sddlForm, @includeSections};
            var ___result = RSetSecurityDescriptorSddlForm_String_AccessControlSections.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Persist(System.Boolean  @enableOwnershipPrivilege, System.String  @name, System.Security.AccessControl.AccessControlSections  @includeSections)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enableOwnershipPrivilege, @name, @includeSections};
            var ___result = RPersist_Boolean_String_AccessControlSections.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadLock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadLock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadUnlock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadUnlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteLock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWriteLock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteUnlock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWriteUnlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.AccessControl.AuthorizationRuleCollection InternalGetAccessRules(System.Boolean  @includeExplicit, System.Boolean  @includeInherited, System.Type  @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includeExplicit, @includeInherited, @targetType};
            var ___result = RInternalGetAccessRules_Boolean_Boolean_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AuthorizationRuleCollection)___result;
        }


        public virtual System.Security.AccessControl.AccessRule InternalAccessRuleFactory(System.Security.AccessControl.QualifiedAce  @ace, System.Type  @targetType, System.Security.AccessControl.AccessControlType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ace, @targetType, @type};
            var ___result = RInternalAccessRuleFactory_QualifiedAce_Type_AccessControlType.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AccessRule)___result;
        }


        public virtual System.Security.AccessControl.AuthorizationRuleCollection InternalGetAuditRules(System.Boolean  @includeExplicit, System.Boolean  @includeInherited, System.Type  @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@includeExplicit, @includeInherited, @targetType};
            var ___result = RInternalGetAuditRules_Boolean_Boolean_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AuthorizationRuleCollection)___result;
        }


        public virtual System.Security.AccessControl.AuditRule InternalAuditRuleFactory(System.Security.AccessControl.QualifiedAce  @ace, System.Type  @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ace, @targetType};
            var ___result = RInternalAuditRuleFactory_QualifiedAce_Type.Invoke(___genericsType, ___parameters);

            return (System.Security.AccessControl.AuditRule)___result;
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
