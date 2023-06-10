
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy
{
	/// <summary>
	/// System.Security.Policy.CodeGroup
	/// </summary>
    public partial class RCodeGroup : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Security.Policy.CodeGroup);
            }
        }

        public RCodeGroup() : base("System.Security.Policy.CodeGroup")
        {
        }

        public RCodeGroup(System.Object instance) : base("System.Security.Policy.CodeGroup")
		{
            SetInstance(instance);
		}

        public RCodeGroup(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCodeGroup(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Security.Policy.PolicyStatement m_policy
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RPolicyStatement r_Fm_policy;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RPolicyStatement RFm_policy
		{
			get
			{
				if(r_Fm_policy == null)
				{
					r_Fm_policy = new(this, "m_policy");
				}
				return r_Fm_policy;
			}
		}

		/// <summary>
		/// System.Security.Policy.IMembershipCondition m_membershipCondition
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RIMembershipCondition r_Fm_membershipCondition;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RIMembershipCondition RFm_membershipCondition
		{
			get
			{
				if(r_Fm_membershipCondition == null)
				{
					r_Fm_membershipCondition = new(this, "m_membershipCondition");
				}
				return r_Fm_membershipCondition;
			}
		}

		/// <summary>
		/// System.String m_description
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_description;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_description
		{
			get
			{
				if(r_Fm_description == null)
				{
					r_Fm_description = new(this, "m_description");
				}
				return r_Fm_description;
			}
		}

		/// <summary>
		/// System.String m_name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_name;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_name
		{
			get
			{
				if(r_Fm_name == null)
				{
					r_Fm_name = new(this, "m_name");
				}
				return r_Fm_name;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList m_children
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList r_Fm_children;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList RFm_children
		{
			get
			{
				if(r_Fm_children == null)
				{
					r_Fm_children = new(this, "m_children");
				}
				return r_Fm_children;
			}
		}

		/// <summary>
		/// System.String MergeLogic
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PMergeLogic;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPMergeLogic
		{
			get
			{
				if(r_PMergeLogic == null)
				{
					r_PMergeLogic = new(this, "MergeLogic", -1);
				}
				return r_PMergeLogic;
			}
		}

		/// <summary>
		/// System.Security.Policy.PolicyStatement PolicyStatement
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RPolicyStatement r_PPolicyStatement;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RPolicyStatement RPPolicyStatement
		{
			get
			{
				if(r_PPolicyStatement == null)
				{
					r_PPolicyStatement = new(this, "PolicyStatement", -1);
				}
				return r_PPolicyStatement;
			}
		}

		/// <summary>
		/// System.String Description
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PDescription;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPDescription
		{
			get
			{
				if(r_PDescription == null)
				{
					r_PDescription = new(this, "Description", -1);
				}
				return r_PDescription;
			}
		}

		/// <summary>
		/// System.Security.Policy.IMembershipCondition MembershipCondition
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RIMembershipCondition r_PMembershipCondition;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPolicy.RIMembershipCondition RPMembershipCondition
		{
			get
			{
				if(r_PMembershipCondition == null)
				{
					r_PMembershipCondition = new(this, "MembershipCondition", -1);
				}
				return r_PMembershipCondition;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// System.Collections.IList Children
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RIList r_PChildren;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RIList RPChildren
		{
			get
			{
				if(r_PChildren == null)
				{
					r_PChildren = new(this, "Children", -1);
				}
				return r_PChildren;
			}
		}

		/// <summary>
		/// System.String AttributeString
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PAttributeString;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPAttributeString
		{
			get
			{
				if(r_PAttributeString == null)
				{
					r_PAttributeString = new(this, "AttributeString", -1);
				}
				return r_PAttributeString;
			}
		}

		/// <summary>
		/// System.String PermissionSetName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PPermissionSetName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPPermissionSetName
		{
			get
			{
				if(r_PPermissionSetName == null)
				{
					r_PPermissionSetName = new(this, "PermissionSetName", -1);
				}
				return r_PPermissionSetName;
			}
		}

		/// <summary>
		/// System.Security.Policy.CodeGroup Copy()
		/// </summary>
		protected RMethod r_MCopy;
		public virtual RMethod RMCopy
		{
			get
			{
				if(r_MCopy == null)
				{
					r_MCopy = new(this, "Copy", 0);
				}
				return r_MCopy;
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
				}
				return r_MResolveMatchingCodeGroups_Evidence;
			}
		}

		/// <summary>
		/// Void AddChild(System.Security.Policy.CodeGroup)
		/// </summary>
		protected RMethod r_MAddChild_CodeGroup;
		public virtual RMethod RMAddChild_CodeGroup
		{
			get
			{
				if(r_MAddChild_CodeGroup == null)
				{
					r_MAddChild_CodeGroup = new(this, "AddChild", 0, typeof(System.Security.Policy.CodeGroup));
				}
				return r_MAddChild_CodeGroup;
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
		/// Boolean Equals(System.Security.Policy.CodeGroup, Boolean)
		/// </summary>
		protected RMethod r_MEquals_CodeGroup_Boolean;
		public virtual RMethod RMEquals_CodeGroup_Boolean
		{
			get
			{
				if(r_MEquals_CodeGroup_Boolean == null)
				{
					r_MEquals_CodeGroup_Boolean = new(this, "Equals", 0, typeof(System.Security.Policy.CodeGroup), typeof(System.Boolean));
				}
				return r_MEquals_CodeGroup_Boolean;
			}
		}

		/// <summary>
		/// Void RemoveChild(System.Security.Policy.CodeGroup)
		/// </summary>
		protected RMethod r_MRemoveChild_CodeGroup;
		public virtual RMethod RMRemoveChild_CodeGroup
		{
			get
			{
				if(r_MRemoveChild_CodeGroup == null)
				{
					r_MRemoveChild_CodeGroup = new(this, "RemoveChild", 0, typeof(System.Security.Policy.CodeGroup));
				}
				return r_MRemoveChild_CodeGroup;
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
				}
				return r_MFromXml_SecurityElement;
			}
		}

		/// <summary>
		/// Void FromXml(System.Security.SecurityElement, System.Security.Policy.PolicyLevel)
		/// </summary>
		protected RMethod r_MFromXml_SecurityElement_PolicyLevel;
		public virtual RMethod RMFromXml_SecurityElement_PolicyLevel
		{
			get
			{
				if(r_MFromXml_SecurityElement_PolicyLevel == null)
				{
					r_MFromXml_SecurityElement_PolicyLevel = new(this, "FromXml", 0, typeof(System.Security.SecurityElement), typeof(System.Security.Policy.PolicyLevel));
				}
				return r_MFromXml_SecurityElement_PolicyLevel;
			}
		}

		/// <summary>
		/// Void ParseXml(System.Security.SecurityElement, System.Security.Policy.PolicyLevel)
		/// </summary>
		protected RMethod r_MParseXml_SecurityElement_PolicyLevel;
		public virtual RMethod RMParseXml_SecurityElement_PolicyLevel
		{
			get
			{
				if(r_MParseXml_SecurityElement_PolicyLevel == null)
				{
					r_MParseXml_SecurityElement_PolicyLevel = new(this, "ParseXml", 0, typeof(System.Security.SecurityElement), typeof(System.Security.Policy.PolicyLevel));
				}
				return r_MParseXml_SecurityElement_PolicyLevel;
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
				}
				return r_MToXml;
			}
		}

		/// <summary>
		/// System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel)
		/// </summary>
		protected RMethod r_MToXml_PolicyLevel;
		public virtual RMethod RMToXml_PolicyLevel
		{
			get
			{
				if(r_MToXml_PolicyLevel == null)
				{
					r_MToXml_PolicyLevel = new(this, "ToXml", 0, typeof(System.Security.Policy.PolicyLevel));
				}
				return r_MToXml_PolicyLevel;
			}
		}

		/// <summary>
		/// Void CreateXml(System.Security.SecurityElement, System.Security.Policy.PolicyLevel)
		/// </summary>
		protected RMethod r_MCreateXml_SecurityElement_PolicyLevel;
		public virtual RMethod RMCreateXml_SecurityElement_PolicyLevel
		{
			get
			{
				if(r_MCreateXml_SecurityElement_PolicyLevel == null)
				{
					r_MCreateXml_SecurityElement_PolicyLevel = new(this, "CreateXml", 0, typeof(System.Security.SecurityElement), typeof(System.Security.Policy.PolicyLevel));
				}
				return r_MCreateXml_SecurityElement_PolicyLevel;
			}
		}

		/// <summary>
		/// System.Security.Policy.CodeGroup CreateFromXml(System.Security.SecurityElement, System.Security.Policy.PolicyLevel)
		/// </summary>
		protected static RMethod r_MCreateFromXml_SecurityElement_PolicyLevel;
		public static RMethod RMCreateFromXml_SecurityElement_PolicyLevel
		{
			get
			{
				if(r_MCreateFromXml_SecurityElement_PolicyLevel == null)
				{
					r_MCreateFromXml_SecurityElement_PolicyLevel = new(typeof(System.Security.Policy.CodeGroup), "CreateFromXml", 0, typeof(System.Security.SecurityElement), typeof(System.Security.Policy.PolicyLevel));
				}
				return r_MCreateFromXml_SecurityElement_PolicyLevel;
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


        public virtual System.Security.Policy.CodeGroup Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.CodeGroup)___result;
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


        public virtual void AddChild(System.Security.Policy.CodeGroup @group)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@group};
            var ___result = RMAddChild_CodeGroup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Security.Policy.CodeGroup @cg, System.Boolean @compareChildren)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cg, @compareChildren};
            var ___result = RMEquals_CodeGroup_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RemoveChild(System.Security.Policy.CodeGroup @group)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@group};
            var ___result = RMRemoveChild_CodeGroup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void FromXml(System.Security.SecurityElement @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMFromXml_SecurityElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FromXml(System.Security.SecurityElement @e, System.Security.Policy.PolicyLevel @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @level};
            var ___result = RMFromXml_SecurityElement_PolicyLevel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ParseXml(System.Security.SecurityElement @e, System.Security.Policy.PolicyLevel @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @level};
            var ___result = RMParseXml_SecurityElement_PolicyLevel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Security.SecurityElement ToXml()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToXml.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
        }


        public virtual System.Security.SecurityElement ToXml(System.Security.Policy.PolicyLevel @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = RMToXml_PolicyLevel.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
        }


        public virtual void CreateXml(System.Security.SecurityElement @element, System.Security.Policy.PolicyLevel @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @level};
            var ___result = RMCreateXml_SecurityElement_PolicyLevel.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Security.Policy.CodeGroup CreateFromXml(System.Security.SecurityElement @se, System.Security.Policy.PolicyLevel @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@se, @level};
            var ___result = RMCreateFromXml_SecurityElement_PolicyLevel.Invoke(___genericsType, ___parameters);

            return (System.Security.Policy.CodeGroup)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
