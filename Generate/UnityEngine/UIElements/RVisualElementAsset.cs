using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.VisualElementAsset
	/// </summary>
    public partial class RVisualElementAsset : RMember //
    {

		/// <summary>
		/// System.String m_Name
		/// </summary>
		protected RField r_m_Name;
		public virtual RField Rm_Name
		{
			get
			{
				if(r_m_Name == null)
				{
					r_m_Name = new(this, "m_Name");
					r_m_Name.SetBelong(this.instance);
				}
				return r_m_Name;
			}
		}

		/// <summary>
		/// System.Int32 m_RuleIndex
		/// </summary>
		protected RField r_m_RuleIndex;
		public virtual RField Rm_RuleIndex
		{
			get
			{
				if(r_m_RuleIndex == null)
				{
					r_m_RuleIndex = new(this, "m_RuleIndex");
					r_m_RuleIndex.SetBelong(this.instance);
				}
				return r_m_RuleIndex;
			}
		}

		/// <summary>
		/// System.String m_Text
		/// </summary>
		protected RField r_m_Text;
		public virtual RField Rm_Text
		{
			get
			{
				if(r_m_Text == null)
				{
					r_m_Text = new(this, "m_Text");
					r_m_Text.SetBelong(this.instance);
				}
				return r_m_Text;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PickingMode m_PickingMode
		/// </summary>
		protected RField r_m_PickingMode;
		public virtual RField Rm_PickingMode
		{
			get
			{
				if(r_m_PickingMode == null)
				{
					r_m_PickingMode = new(this, "m_PickingMode");
					r_m_PickingMode.SetBelong(this.instance);
				}
				return r_m_PickingMode;
			}
		}

		/// <summary>
		/// System.String[] m_Classes
		/// </summary>
		protected RFieldArray<RField> r_m_Classes;
		public virtual RFieldArray<RField> Rm_Classes
		{
			get
			{
				if(r_m_Classes == null)
				{
					r_m_Classes = new(this, "m_Classes");
					r_m_Classes.SetBelong(this.instance);
				}
				return r_m_Classes;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_StylesheetPaths
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_StylesheetPaths;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_StylesheetPaths
		{
			get
			{
				if(r_m_StylesheetPaths == null)
				{
					r_m_StylesheetPaths = new(this, "m_StylesheetPaths");
					r_m_StylesheetPaths.SetBelong(this.instance);
				}
				return r_m_StylesheetPaths;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheet] m_Stylesheets
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheet> r_m_Stylesheets;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheet> Rm_Stylesheets
		{
			get
			{
				if(r_m_Stylesheets == null)
				{
					r_m_Stylesheets = new(this, "m_Stylesheets");
					r_m_Stylesheets.SetBelong(this.instance);
				}
				return r_m_Stylesheets;
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
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_ROnBeforeSerialize;
		public virtual RMethod ROnBeforeSerialize
		{
			get
			{
				if(r_ROnBeforeSerialize == null)
				{
					r_ROnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
					r_ROnBeforeSerialize.SetBelong(this.instance);
				}
				return r_ROnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_ROnAfterDeserialize;
		public virtual RMethod ROnAfterDeserialize
		{
			get
			{
				if(r_ROnAfterDeserialize == null)
				{
					r_ROnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
					r_ROnAfterDeserialize.SetBelong(this.instance);
				}
				return r_ROnAfterDeserialize;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] GetProperties()
		/// </summary>
		protected RMethod r_RGetProperties;
		public virtual RMethod RGetProperties
		{
			get
			{
				if(r_RGetProperties == null)
				{
					r_RGetProperties = new(this, "GetProperties", 0);
					r_RGetProperties.SetBelong(this.instance);
				}
				return r_RGetProperties;
			}
		}

		/// <summary>
		/// Boolean HasParent()
		/// </summary>
		protected RMethod r_RHasParent;
		public virtual RMethod RHasParent
		{
			get
			{
				if(r_RHasParent == null)
				{
					r_RHasParent = new(this, "HasParent", 0);
					r_RHasParent.SetBelong(this.instance);
				}
				return r_RHasParent;
			}
		}

		/// <summary>
		/// Boolean HasAttribute(System.String)
		/// </summary>
		protected RMethod r_RHasAttribute_String;
		public virtual RMethod RHasAttribute_String
		{
			get
			{
				if(r_RHasAttribute_String == null)
				{
					r_RHasAttribute_String = new(this, "HasAttribute", 0, typeof(System.String));
					r_RHasAttribute_String.SetBelong(this.instance);
				}
				return r_RHasAttribute_String;
			}
		}

		/// <summary>
		/// System.String GetAttributeValue(System.String)
		/// </summary>
		protected RMethod r_RGetAttributeValue_String;
		public virtual RMethod RGetAttributeValue_String
		{
			get
			{
				if(r_RGetAttributeValue_String == null)
				{
					r_RGetAttributeValue_String = new(this, "GetAttributeValue", 0, typeof(System.String));
					r_RGetAttributeValue_String.SetBelong(this.instance);
				}
				return r_RGetAttributeValue_String;
			}
		}

		/// <summary>
		/// Boolean TryGetAttributeValue(System.String, System.String ByRef)
		/// </summary>
		protected RMethod r_RTryGetAttributeValue_String_Out_String;
		public virtual RMethod RTryGetAttributeValue_String_Out_String
		{
			get
			{
				if(r_RTryGetAttributeValue_String_Out_String == null)
				{
					r_RTryGetAttributeValue_String_Out_String = new(this, "TryGetAttributeValue", 0, typeof(System.String), typeof(System.String).MakeByRefType());
					r_RTryGetAttributeValue_String_Out_String.SetBelong(this.instance);
				}
				return r_RTryGetAttributeValue_String_Out_String;
			}
		}

		/// <summary>
		/// Void SetAttribute(System.String, System.String)
		/// </summary>
		protected RMethod r_RSetAttribute_String_String;
		public virtual RMethod RSetAttribute_String_String
		{
			get
			{
				if(r_RSetAttribute_String_String == null)
				{
					r_RSetAttribute_String_String = new(this, "SetAttribute", 0, typeof(System.String), typeof(System.String));
					r_RSetAttribute_String_String.SetBelong(this.instance);
				}
				return r_RSetAttribute_String_String;
			}
		}

		/// <summary>
		/// Void RemoveAttribute(System.String)
		/// </summary>
		protected RMethod r_RRemoveAttribute_String;
		public virtual RMethod RRemoveAttribute_String
		{
			get
			{
				if(r_RRemoveAttribute_String == null)
				{
					r_RRemoveAttribute_String = new(this, "RemoveAttribute", 0, typeof(System.String));
					r_RRemoveAttribute_String.SetBelong(this.instance);
				}
				return r_RRemoveAttribute_String;
			}
		}

		/// <summary>
		/// Int32 GetPropertiesDirtyCount()
		/// </summary>
		protected RMethod r_RGetPropertiesDirtyCount;
		public virtual RMethod RGetPropertiesDirtyCount
		{
			get
			{
				if(r_RGetPropertiesDirtyCount == null)
				{
					r_RGetPropertiesDirtyCount = new(this, "GetPropertiesDirtyCount", 0);
					r_RGetPropertiesDirtyCount.SetBelong(this.instance);
				}
				return r_RGetPropertiesDirtyCount;
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


        public RVisualElementAsset() : base("UnityEngine.UIElements.VisualElementAsset")
        {
        }

        public RVisualElementAsset(System.Object instance) : base("UnityEngine.UIElements.VisualElementAsset")
		{
            SetInstance(instance);
		}

        public RVisualElementAsset(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVisualElementAsset(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
			value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName, @value};
            var ___result = RTryGetAttributeValue_String_Out_String.Invoke(___genericsType, ___parameters);
			value = (System.String)___parameters[1];

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