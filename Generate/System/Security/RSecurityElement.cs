using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RSecurity
{
	/// <summary>
	/// System.Security.SecurityElement
	/// </summary>
    public partial class RSecurityElement : RMember //
    {

		/// <summary>
		/// System.String text
		/// </summary>
		protected RField r_text;
		public virtual RField Rtext
		{
			get
			{
				if(r_text == null)
				{
					r_text = new(this, "text");
					r_text.SetBelong(this.instance);
				}
				return r_text;
			}
		}

		/// <summary>
		/// System.String tag
		/// </summary>
		protected RField r_tag;
		public virtual RField Rtag
		{
			get
			{
				if(r_tag == null)
				{
					r_tag = new(this, "tag");
					r_tag.SetBelong(this.instance);
				}
				return r_tag;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList attributes
		/// </summary>
		protected RSystem.RCollections.RArrayList r_attributes;
		public virtual RSystem.RCollections.RArrayList Rattributes
		{
			get
			{
				if(r_attributes == null)
				{
					r_attributes = new(this, "attributes");
					r_attributes.SetBelong(this.instance);
				}
				return r_attributes;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList children
		/// </summary>
		protected RSystem.RCollections.RArrayList r_children;
		public virtual RSystem.RCollections.RArrayList Rchildren
		{
			get
			{
				if(r_children == null)
				{
					r_children = new(this, "children");
					r_children.SetBelong(this.instance);
				}
				return r_children;
			}
		}

		/// <summary>
		/// System.Char[] invalid_tag_chars
		/// </summary>
		protected static RFieldArray<RField> r_invalid_tag_chars;
		public static RFieldArray<RField> Rinvalid_tag_chars
		{
			get
			{
				if(r_invalid_tag_chars == null)
				{
					r_invalid_tag_chars = new(typeof(System.Security.SecurityElement), "invalid_tag_chars");
					r_invalid_tag_chars.SetBelong(null);
				}
				return r_invalid_tag_chars;
			}
		}

		/// <summary>
		/// System.Char[] invalid_text_chars
		/// </summary>
		protected static RFieldArray<RField> r_invalid_text_chars;
		public static RFieldArray<RField> Rinvalid_text_chars
		{
			get
			{
				if(r_invalid_text_chars == null)
				{
					r_invalid_text_chars = new(typeof(System.Security.SecurityElement), "invalid_text_chars");
					r_invalid_text_chars.SetBelong(null);
				}
				return r_invalid_text_chars;
			}
		}

		/// <summary>
		/// System.Char[] invalid_attr_name_chars
		/// </summary>
		protected static RFieldArray<RField> r_invalid_attr_name_chars;
		public static RFieldArray<RField> Rinvalid_attr_name_chars
		{
			get
			{
				if(r_invalid_attr_name_chars == null)
				{
					r_invalid_attr_name_chars = new(typeof(System.Security.SecurityElement), "invalid_attr_name_chars");
					r_invalid_attr_name_chars.SetBelong(null);
				}
				return r_invalid_attr_name_chars;
			}
		}

		/// <summary>
		/// System.Char[] invalid_attr_value_chars
		/// </summary>
		protected static RFieldArray<RField> r_invalid_attr_value_chars;
		public static RFieldArray<RField> Rinvalid_attr_value_chars
		{
			get
			{
				if(r_invalid_attr_value_chars == null)
				{
					r_invalid_attr_value_chars = new(typeof(System.Security.SecurityElement), "invalid_attr_value_chars");
					r_invalid_attr_value_chars.SetBelong(null);
				}
				return r_invalid_attr_value_chars;
			}
		}

		/// <summary>
		/// System.Char[] invalid_chars
		/// </summary>
		protected static RFieldArray<RField> r_invalid_chars;
		public static RFieldArray<RField> Rinvalid_chars
		{
			get
			{
				if(r_invalid_chars == null)
				{
					r_invalid_chars = new(typeof(System.Security.SecurityElement), "invalid_chars");
					r_invalid_chars.SetBelong(null);
				}
				return r_invalid_chars;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable Attributes
		/// </summary>
		protected RSystem.RCollections.RHashtable r_Attributes;
		public virtual RSystem.RCollections.RHashtable RAttributes
		{
			get
			{
				if(r_Attributes == null)
				{
					r_Attributes = new(this, "Attributes", -1);
					r_Attributes.SetBelong(this.instance);
				}
				return r_Attributes;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList Children
		/// </summary>
		protected RSystem.RCollections.RArrayList r_Children;
		public virtual RSystem.RCollections.RArrayList RChildren
		{
			get
			{
				if(r_Children == null)
				{
					r_Children = new(this, "Children", -1);
					r_Children.SetBelong(this.instance);
				}
				return r_Children;
			}
		}

		/// <summary>
		/// System.String Tag
		/// </summary>
		protected RProperty r_Tag;
		public virtual RProperty RTag
		{
			get
			{
				if(r_Tag == null)
				{
					r_Tag = new(this, "Tag", -1);
					r_Tag.SetBelong(this.instance);
				}
				return r_Tag;
			}
		}

		/// <summary>
		/// System.String Text
		/// </summary>
		protected RProperty r_Text;
		public virtual RProperty RText
		{
			get
			{
				if(r_Text == null)
				{
					r_Text = new(this, "Text", -1);
					r_Text.SetBelong(this.instance);
				}
				return r_Text;
			}
		}

		/// <summary>
		/// System.String m_strTag
		/// </summary>
		protected RProperty r_m_strTag;
		public virtual RProperty Rm_strTag
		{
			get
			{
				if(r_m_strTag == null)
				{
					r_m_strTag = new(this, "m_strTag", -1);
					r_m_strTag.SetBelong(this.instance);
				}
				return r_m_strTag;
			}
		}

		/// <summary>
		/// System.String m_strText
		/// </summary>
		protected RProperty r_m_strText;
		public virtual RProperty Rm_strText
		{
			get
			{
				if(r_m_strText == null)
				{
					r_m_strText = new(this, "m_strText", -1);
					r_m_strText.SetBelong(this.instance);
				}
				return r_m_strText;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList m_lAttributes
		/// </summary>
		protected RSystem.RCollections.RArrayList r_m_lAttributes;
		public virtual RSystem.RCollections.RArrayList Rm_lAttributes
		{
			get
			{
				if(r_m_lAttributes == null)
				{
					r_m_lAttributes = new(this, "m_lAttributes", -1);
					r_m_lAttributes.SetBelong(this.instance);
				}
				return r_m_lAttributes;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList InternalChildren
		/// </summary>
		protected RSystem.RCollections.RArrayList r_InternalChildren;
		public virtual RSystem.RCollections.RArrayList RInternalChildren
		{
			get
			{
				if(r_InternalChildren == null)
				{
					r_InternalChildren = new(this, "InternalChildren", -1);
					r_InternalChildren.SetBelong(this.instance);
				}
				return r_InternalChildren;
			}
		}

		/// <summary>
		/// Void AddAttribute(System.String, System.String)
		/// </summary>
		protected RMethod r_RAddAttribute_String_String;
		public virtual RMethod RAddAttribute_String_String
		{
			get
			{
				if(r_RAddAttribute_String_String == null)
				{
					r_RAddAttribute_String_String = new(this, "AddAttribute", 0, typeof(System.String), typeof(System.String));
					r_RAddAttribute_String_String.SetBelong(this.instance);
				}
				return r_RAddAttribute_String_String;
			}
		}

		/// <summary>
		/// Void AddChild(System.Security.SecurityElement)
		/// </summary>
		protected RMethod r_RAddChild_SecurityElement;
		public virtual RMethod RAddChild_SecurityElement
		{
			get
			{
				if(r_RAddChild_SecurityElement == null)
				{
					r_RAddChild_SecurityElement = new(this, "AddChild", 0, typeof(System.Security.SecurityElement));
					r_RAddChild_SecurityElement.SetBelong(this.instance);
				}
				return r_RAddChild_SecurityElement;
			}
		}

		/// <summary>
		/// System.String Attribute(System.String)
		/// </summary>
		protected RMethod r_RAttribute_String;
		public virtual RMethod RAttribute_String
		{
			get
			{
				if(r_RAttribute_String == null)
				{
					r_RAttribute_String = new(this, "Attribute", 0, typeof(System.String));
					r_RAttribute_String.SetBelong(this.instance);
				}
				return r_RAttribute_String;
			}
		}

		/// <summary>
		/// System.Security.SecurityElement Copy()
		/// </summary>
		protected RMethod r_RCopy;
		public virtual RMethod RCopy
		{
			get
			{
				if(r_RCopy == null)
				{
					r_RCopy = new(this, "Copy", 0);
					r_RCopy.SetBelong(this.instance);
				}
				return r_RCopy;
			}
		}

		/// <summary>
		/// Boolean Equal(System.Security.SecurityElement)
		/// </summary>
		protected RMethod r_REqual_SecurityElement;
		public virtual RMethod REqual_SecurityElement
		{
			get
			{
				if(r_REqual_SecurityElement == null)
				{
					r_REqual_SecurityElement = new(this, "Equal", 0, typeof(System.Security.SecurityElement));
					r_REqual_SecurityElement.SetBelong(this.instance);
				}
				return r_REqual_SecurityElement;
			}
		}

		/// <summary>
		/// System.String Escape(System.String)
		/// </summary>
		protected static RMethod r_REscape_String;
		public static RMethod REscape_String
		{
			get
			{
				if(r_REscape_String == null)
				{
					r_REscape_String = new(typeof(System.Security.SecurityElement), "Escape", 0, typeof(System.String));
					r_REscape_String.SetBelong(null);
				}
				return r_REscape_String;
			}
		}

		/// <summary>
		/// System.String Unescape(System.String)
		/// </summary>
		protected static RMethod r_RUnescape_String;
		public static RMethod RUnescape_String
		{
			get
			{
				if(r_RUnescape_String == null)
				{
					r_RUnescape_String = new(typeof(System.Security.SecurityElement), "Unescape", 0, typeof(System.String));
					r_RUnescape_String.SetBelong(null);
				}
				return r_RUnescape_String;
			}
		}

		/// <summary>
		/// System.Security.SecurityElement FromString(System.String)
		/// </summary>
		protected static RMethod r_RFromString_String;
		public static RMethod RFromString_String
		{
			get
			{
				if(r_RFromString_String == null)
				{
					r_RFromString_String = new(typeof(System.Security.SecurityElement), "FromString", 0, typeof(System.String));
					r_RFromString_String.SetBelong(null);
				}
				return r_RFromString_String;
			}
		}

		/// <summary>
		/// Boolean IsValidAttributeName(System.String)
		/// </summary>
		protected static RMethod r_RIsValidAttributeName_String;
		public static RMethod RIsValidAttributeName_String
		{
			get
			{
				if(r_RIsValidAttributeName_String == null)
				{
					r_RIsValidAttributeName_String = new(typeof(System.Security.SecurityElement), "IsValidAttributeName", 0, typeof(System.String));
					r_RIsValidAttributeName_String.SetBelong(null);
				}
				return r_RIsValidAttributeName_String;
			}
		}

		/// <summary>
		/// Boolean IsValidAttributeValue(System.String)
		/// </summary>
		protected static RMethod r_RIsValidAttributeValue_String;
		public static RMethod RIsValidAttributeValue_String
		{
			get
			{
				if(r_RIsValidAttributeValue_String == null)
				{
					r_RIsValidAttributeValue_String = new(typeof(System.Security.SecurityElement), "IsValidAttributeValue", 0, typeof(System.String));
					r_RIsValidAttributeValue_String.SetBelong(null);
				}
				return r_RIsValidAttributeValue_String;
			}
		}

		/// <summary>
		/// Boolean IsValidTag(System.String)
		/// </summary>
		protected static RMethod r_RIsValidTag_String;
		public static RMethod RIsValidTag_String
		{
			get
			{
				if(r_RIsValidTag_String == null)
				{
					r_RIsValidTag_String = new(typeof(System.Security.SecurityElement), "IsValidTag", 0, typeof(System.String));
					r_RIsValidTag_String.SetBelong(null);
				}
				return r_RIsValidTag_String;
			}
		}

		/// <summary>
		/// Boolean IsValidText(System.String)
		/// </summary>
		protected static RMethod r_RIsValidText_String;
		public static RMethod RIsValidText_String
		{
			get
			{
				if(r_RIsValidText_String == null)
				{
					r_RIsValidText_String = new(typeof(System.Security.SecurityElement), "IsValidText", 0, typeof(System.String));
					r_RIsValidText_String.SetBelong(null);
				}
				return r_RIsValidText_String;
			}
		}

		/// <summary>
		/// System.Security.SecurityElement SearchForChildByTag(System.String)
		/// </summary>
		protected RMethod r_RSearchForChildByTag_String;
		public virtual RMethod RSearchForChildByTag_String
		{
			get
			{
				if(r_RSearchForChildByTag_String == null)
				{
					r_RSearchForChildByTag_String = new(this, "SearchForChildByTag", 0, typeof(System.String));
					r_RSearchForChildByTag_String.SetBelong(this.instance);
				}
				return r_RSearchForChildByTag_String;
			}
		}

		/// <summary>
		/// System.String SearchForTextOfTag(System.String)
		/// </summary>
		protected RMethod r_RSearchForTextOfTag_String;
		public virtual RMethod RSearchForTextOfTag_String
		{
			get
			{
				if(r_RSearchForTextOfTag_String == null)
				{
					r_RSearchForTextOfTag_String = new(this, "SearchForTextOfTag", 0, typeof(System.String));
					r_RSearchForTextOfTag_String.SetBelong(this.instance);
				}
				return r_RSearchForTextOfTag_String;
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

		/// <summary>
		/// Void ToXml(System.Text.StringBuilder ByRef, Int32)
		/// </summary>
		protected RMethod r_RToXml_Ref_StringBuilder_Int32;
		public virtual RMethod RToXml_Ref_StringBuilder_Int32
		{
			get
			{
				if(r_RToXml_Ref_StringBuilder_Int32 == null)
				{
					r_RToXml_Ref_StringBuilder_Int32 = new(this, "ToXml", 0, typeof(System.Text.StringBuilder).MakeByRefType(), typeof(System.Int32));
					r_RToXml_Ref_StringBuilder_Int32.SetBelong(this.instance);
				}
				return r_RToXml_Ref_StringBuilder_Int32;
			}
		}

		/// <summary>
		/// SecurityAttribute GetAttribute(System.String)
		/// </summary>
		protected RMethod r_RGetAttribute_String;
		public virtual RMethod RGetAttribute_String
		{
			get
			{
				if(r_RGetAttribute_String == null)
				{
					r_RGetAttribute_String = new(this, "GetAttribute", 0, typeof(System.String));
					r_RGetAttribute_String.SetBelong(this.instance);
				}
				return r_RGetAttribute_String;
			}
		}

		/// <summary>
		/// System.String SearchForTextOfLocalName(System.String)
		/// </summary>
		protected RMethod r_RSearchForTextOfLocalName_String;
		public virtual RMethod RSearchForTextOfLocalName_String
		{
			get
			{
				if(r_RSearchForTextOfLocalName_String == null)
				{
					r_RSearchForTextOfLocalName_String = new(this, "SearchForTextOfLocalName", 0, typeof(System.String));
					r_RSearchForTextOfLocalName_String.SetBelong(this.instance);
				}
				return r_RSearchForTextOfLocalName_String;
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


        public RSecurityElement() : base("System.Security.SecurityElement")
        {
        }

        public RSecurityElement(System.Object instance) : base("System.Security.SecurityElement")
		{
            SetInstance(instance);
		}

        public RSecurityElement(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSecurityElement(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AddAttribute(System.String  @name, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddAttribute_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddChild(System.Security.SecurityElement  @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RAddChild_SecurityElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String Attribute(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RAttribute_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Security.SecurityElement Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCopy.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
        }


        public virtual System.Boolean Equal(System.Security.SecurityElement  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REqual_SecurityElement.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String Escape(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = REscape_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Unescape(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RUnescape_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Security.SecurityElement FromString(System.String  @xml)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xml};
            var ___result = RFromString_String.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
        }


        public static System.Boolean IsValidAttributeName(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RIsValidAttributeName_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsValidAttributeValue(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RIsValidAttributeValue_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsValidTag(System.String  @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RIsValidTag_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsValidText(System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RIsValidText_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Security.SecurityElement SearchForChildByTag(System.String  @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RSearchForChildByTag_String.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
        }


        public virtual System.String SearchForTextOfTag(System.String  @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RSearchForTextOfTag_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void ToXml(ref System.Text.StringBuilder  @s, System.Int32  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @level};
            var ___result = RToXml_Ref_StringBuilder_Int32.Invoke(___genericsType, ___parameters);
			s = (System.Text.StringBuilder)___parameters[0];

            
        }


        public virtual System.Object GetAttribute(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetAttribute_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String SearchForTextOfLocalName(System.String  @strLocalName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strLocalName};
            var ___result = RSearchForTextOfLocalName_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


    }
}
