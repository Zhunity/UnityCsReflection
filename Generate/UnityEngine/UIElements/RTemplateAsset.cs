using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.TemplateAsset
	/// </summary>
    public partial class RTemplateAsset : RMember //
    {

		/// <summary>
		/// System.String m_TemplateAlias
		/// </summary>
		protected RField r_m_TemplateAlias;
		public virtual RField Rm_TemplateAlias
		{
			get
			{
				if(r_m_TemplateAlias == null)
				{
					r_m_TemplateAlias = new(this, "m_TemplateAlias");
					r_m_TemplateAlias.SetBelong(this.instance);
				}
				return r_m_TemplateAlias;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TemplateAsset+AttributeOverride] m_AttributeOverrides
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTemplateAsset.RAttributeOverride> r_m_AttributeOverrides;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTemplateAsset.RAttributeOverride> Rm_AttributeOverrides
		{
			get
			{
				if(r_m_AttributeOverrides == null)
				{
					r_m_AttributeOverrides = new(this, "m_AttributeOverrides");
					r_m_AttributeOverrides.SetBelong(this.instance);
				}
				return r_m_AttributeOverrides;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualTreeAsset+SlotUsageEntry] m_SlotUsages
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualTreeAsset.RSlotUsageEntry> r_m_SlotUsages;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualTreeAsset.RSlotUsageEntry> Rm_SlotUsages
		{
			get
			{
				if(r_m_SlotUsages == null)
				{
					r_m_SlotUsages = new(this, "m_SlotUsages");
					r_m_SlotUsages.SetBelong(this.instance);
				}
				return r_m_SlotUsages;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_Properties
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_Properties;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_Properties
		{
			get
			{
				if(r_m_Properties == null)
				{
					r_m_Properties = new(this, "m_Properties");
					r_m_Properties.SetBelong(this.instance);
				}
				return r_m_Properties;
			}
		}

		/// <summary>
		/// System.String templateAlias
		/// </summary>
		protected RProperty r_templateAlias;
		public virtual RProperty RtemplateAlias
		{
			get
			{
				if(r_templateAlias == null)
				{
					r_templateAlias = new(this, "templateAlias", -1);
					r_templateAlias.SetBelong(this.instance);
				}
				return r_templateAlias;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.TemplateAsset+AttributeOverride] attributeOverrides
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTemplateAsset.RAttributeOverride> r_attributeOverrides;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RTemplateAsset.RAttributeOverride> RattributeOverrides
		{
			get
			{
				if(r_attributeOverrides == null)
				{
					r_attributeOverrides = new(this, "attributeOverrides", -1);
					r_attributeOverrides.SetBelong(this.instance);
				}
				return r_attributeOverrides;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualTreeAsset+SlotUsageEntry] slotUsages
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualTreeAsset.RSlotUsageEntry> r_slotUsages;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualTreeAsset.RSlotUsageEntry> RslotUsages
		{
			get
			{
				if(r_slotUsages == null)
				{
					r_slotUsages = new(this, "slotUsages", -1);
					r_slotUsages.SetBelong(this.instance);
				}
				return r_slotUsages;
			}
		}

		/// <summary>
		/// Int32 ruleIndex
		/// </summary>
		protected RProperty r_ruleIndex;
		public virtual RProperty RruleIndex
		{
			get
			{
				if(r_ruleIndex == null)
				{
					r_ruleIndex = new(this, "ruleIndex", -1);
					r_ruleIndex.SetBelong(this.instance);
				}
				return r_ruleIndex;
			}
		}

		/// <summary>
		/// System.String[] classes
		/// </summary>
		protected RPropertyArray<RProperty> r_classes;
		public virtual RPropertyArray<RProperty> Rclasses
		{
			get
			{
				if(r_classes == null)
				{
					r_classes = new(this, "classes", -1);
					r_classes.SetBelong(this.instance);
				}
				return r_classes;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] stylesheetPaths
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RProperty> r_stylesheetPaths;
		public virtual RSystem.RCollections.RGeneric.RList<RProperty> RstylesheetPaths
		{
			get
			{
				if(r_stylesheetPaths == null)
				{
					r_stylesheetPaths = new(this, "stylesheetPaths", -1);
					r_stylesheetPaths.SetBelong(this.instance);
				}
				return r_stylesheetPaths;
			}
		}

		/// <summary>
		/// Boolean hasStylesheetPaths
		/// </summary>
		protected RProperty r_hasStylesheetPaths;
		public virtual RProperty RhasStylesheetPaths
		{
			get
			{
				if(r_hasStylesheetPaths == null)
				{
					r_hasStylesheetPaths = new(this, "hasStylesheetPaths", -1);
					r_hasStylesheetPaths.SetBelong(this.instance);
				}
				return r_hasStylesheetPaths;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheet] stylesheets
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheet> r_stylesheets;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheet> Rstylesheets
		{
			get
			{
				if(r_stylesheets == null)
				{
					r_stylesheets = new(this, "stylesheets", -1);
					r_stylesheets.SetBelong(this.instance);
				}
				return r_stylesheets;
			}
		}

		/// <summary>
		/// Boolean hasStylesheets
		/// </summary>
		protected RProperty r_hasStylesheets;
		public virtual RProperty RhasStylesheets
		{
			get
			{
				if(r_hasStylesheets == null)
				{
					r_hasStylesheets = new(this, "hasStylesheets", -1);
					r_hasStylesheets.SetBelong(this.instance);
				}
				return r_hasStylesheets;
			}
		}

		/// <summary>
		/// System.String fullTypeName
		/// </summary>
		protected RProperty r_fullTypeName;
		public virtual RProperty RfullTypeName
		{
			get
			{
				if(r_fullTypeName == null)
				{
					r_fullTypeName = new(this, "fullTypeName", -1);
					r_fullTypeName.SetBelong(this.instance);
				}
				return r_fullTypeName;
			}
		}

		/// <summary>
		/// Int32 id
		/// </summary>
		protected RProperty r_id;
		public virtual RProperty Rid
		{
			get
			{
				if(r_id == null)
				{
					r_id = new(this, "id", -1);
					r_id.SetBelong(this.instance);
				}
				return r_id;
			}
		}

		/// <summary>
		/// Int32 orderInDocument
		/// </summary>
		protected RProperty r_orderInDocument;
		public virtual RProperty RorderInDocument
		{
			get
			{
				if(r_orderInDocument == null)
				{
					r_orderInDocument = new(this, "orderInDocument", -1);
					r_orderInDocument.SetBelong(this.instance);
				}
				return r_orderInDocument;
			}
		}

		/// <summary>
		/// Int32 parentId
		/// </summary>
		protected RProperty r_parentId;
		public virtual RProperty RparentId
		{
			get
			{
				if(r_parentId == null)
				{
					r_parentId = new(this, "parentId", -1);
					r_parentId.SetBelong(this.instance);
				}
				return r_parentId;
			}
		}

		/// <summary>
		/// Void AddSlotUsage(System.String, Int32)
		/// </summary>
		protected RMethod r_AddSlotUsage_String_Int32;
		public virtual RMethod RAddSlotUsage_String_Int32
		{
			get
			{
				if(r_AddSlotUsage_String_Int32 == null)
				{
					r_AddSlotUsage_String_Int32 = new(this, "AddSlotUsage", 0, typeof(System.String), typeof(System.Int32));
					r_AddSlotUsage_String_Int32.SetBelong(this.instance);
				}
				return r_AddSlotUsage_String_Int32;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_OnBeforeSerialize;
		public virtual RMethod ROnBeforeSerialize
		{
			get
			{
				if(r_OnBeforeSerialize == null)
				{
					r_OnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
					r_OnBeforeSerialize.SetBelong(this.instance);
				}
				return r_OnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_OnAfterDeserialize;
		public virtual RMethod ROnAfterDeserialize
		{
			get
			{
				if(r_OnAfterDeserialize == null)
				{
					r_OnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
					r_OnAfterDeserialize.SetBelong(this.instance);
				}
				return r_OnAfterDeserialize;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] GetProperties()
		/// </summary>
		protected RMethod r_GetProperties;
		public virtual RMethod RGetProperties
		{
			get
			{
				if(r_GetProperties == null)
				{
					r_GetProperties = new(this, "GetProperties", 0);
					r_GetProperties.SetBelong(this.instance);
				}
				return r_GetProperties;
			}
		}

		/// <summary>
		/// Boolean HasParent()
		/// </summary>
		protected RMethod r_HasParent;
		public virtual RMethod RHasParent
		{
			get
			{
				if(r_HasParent == null)
				{
					r_HasParent = new(this, "HasParent", 0);
					r_HasParent.SetBelong(this.instance);
				}
				return r_HasParent;
			}
		}

		/// <summary>
		/// Boolean HasAttribute(System.String)
		/// </summary>
		protected RMethod r_HasAttribute_String;
		public virtual RMethod RHasAttribute_String
		{
			get
			{
				if(r_HasAttribute_String == null)
				{
					r_HasAttribute_String = new(this, "HasAttribute", 0, typeof(System.String));
					r_HasAttribute_String.SetBelong(this.instance);
				}
				return r_HasAttribute_String;
			}
		}

		/// <summary>
		/// System.String GetAttributeValue(System.String)
		/// </summary>
		protected RMethod r_GetAttributeValue_String;
		public virtual RMethod RGetAttributeValue_String
		{
			get
			{
				if(r_GetAttributeValue_String == null)
				{
					r_GetAttributeValue_String = new(this, "GetAttributeValue", 0, typeof(System.String));
					r_GetAttributeValue_String.SetBelong(this.instance);
				}
				return r_GetAttributeValue_String;
			}
		}

		/// <summary>
		/// Boolean TryGetAttributeValue(System.String, System.String ByRef)
		/// </summary>
		protected RMethod r_TryGetAttributeValue_String_Out_String;
		public virtual RMethod RTryGetAttributeValue_String_Out_String
		{
			get
			{
				if(r_TryGetAttributeValue_String_Out_String == null)
				{
					r_TryGetAttributeValue_String_Out_String = new(this, "TryGetAttributeValue", 0, typeof(System.String), typeof(System.String).MakeByRefType());
					r_TryGetAttributeValue_String_Out_String.SetBelong(this.instance);
				}
				return r_TryGetAttributeValue_String_Out_String;
			}
		}

		/// <summary>
		/// Void SetAttribute(System.String, System.String)
		/// </summary>
		protected RMethod r_SetAttribute_String_String;
		public virtual RMethod RSetAttribute_String_String
		{
			get
			{
				if(r_SetAttribute_String_String == null)
				{
					r_SetAttribute_String_String = new(this, "SetAttribute", 0, typeof(System.String), typeof(System.String));
					r_SetAttribute_String_String.SetBelong(this.instance);
				}
				return r_SetAttribute_String_String;
			}
		}

		/// <summary>
		/// Void RemoveAttribute(System.String)
		/// </summary>
		protected RMethod r_RemoveAttribute_String;
		public virtual RMethod RRemoveAttribute_String
		{
			get
			{
				if(r_RemoveAttribute_String == null)
				{
					r_RemoveAttribute_String = new(this, "RemoveAttribute", 0, typeof(System.String));
					r_RemoveAttribute_String.SetBelong(this.instance);
				}
				return r_RemoveAttribute_String;
			}
		}

		/// <summary>
		/// Int32 GetPropertiesDirtyCount()
		/// </summary>
		protected RMethod r_GetPropertiesDirtyCount;
		public virtual RMethod RGetPropertiesDirtyCount
		{
			get
			{
				if(r_GetPropertiesDirtyCount == null)
				{
					r_GetPropertiesDirtyCount = new(this, "GetPropertiesDirtyCount", 0);
					r_GetPropertiesDirtyCount.SetBelong(this.instance);
				}
				return r_GetPropertiesDirtyCount;
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


        public RTemplateAsset() : base("UnityEngine.UIElements.TemplateAsset")
        {
        }

        public RTemplateAsset(System.Object instance) : base("UnityEngine.UIElements.TemplateAsset")
		{
            SetInstance(instance);
		}

        public RTemplateAsset(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTemplateAsset(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AddSlotUsage(System.String  @slotName, System.Int32  @resId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slotName, @resId};
            var ___result = RAddSlotUsage_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.List<System.String> GetProperties()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetProperties.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<System.String>)___result;
        }


        public virtual System.Boolean HasParent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasParent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasAttribute(System.String  @attributeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeName};
            var ___result = RHasAttribute_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetAttributeValue(System.String  @attributeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeName};
            var ___result = RGetAttributeValue_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean TryGetAttributeValue(System.String  @propertyName, out System.String  @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName, @value};
            var ___result = RTryGetAttributeValue_String_Out_String.Invoke(___genericsType, ___parameters);
			@value = (System.String)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual void SetAttribute(System.String  @name, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RSetAttribute_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAttribute(System.String  @attributeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeName};
            var ___result = RRemoveAttribute_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetPropertiesDirtyCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPropertiesDirtyCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
