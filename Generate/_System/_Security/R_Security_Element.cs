
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RSecurity
{
	/// <summary>
	/// System.Security.SecurityElement
	/// </summary>
    public partial class RSecurityElement : RMember //
    {

		/// <summary>
		/// System.String text
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ftext;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFtext
		{
			get
			{
				if(r_Ftext == null)
				{
					r_Ftext = new(this, "text");
				}
				return r_Ftext;
			}
		}

		/// <summary>
		/// System.String tag
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ftag;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFtag
		{
			get
			{
				if(r_Ftag == null)
				{
					r_Ftag = new(this, "tag");
				}
				return r_Ftag;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList attributes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList r_Fattributes;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList RFattributes
		{
			get
			{
				if(r_Fattributes == null)
				{
					r_Fattributes = new(this, "attributes");
				}
				return r_Fattributes;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList children
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList r_Fchildren;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList RFchildren
		{
			get
			{
				if(r_Fchildren == null)
				{
					r_Fchildren = new(this, "children");
				}
				return r_Fchildren;
			}
		}

		/// <summary>
		/// System.Char[] invalid_tag_chars
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RChar> r_Finvalid_tag_chars;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RChar> RFinvalid_tag_chars
		{
			get
			{
				if(r_Finvalid_tag_chars == null)
				{
					r_Finvalid_tag_chars = new(typeof(System.Security.SecurityElement), "invalid_tag_chars");
				}
				return r_Finvalid_tag_chars;
			}
		}

		/// <summary>
		/// System.Char[] invalid_text_chars
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RChar> r_Finvalid_text_chars;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RChar> RFinvalid_text_chars
		{
			get
			{
				if(r_Finvalid_text_chars == null)
				{
					r_Finvalid_text_chars = new(typeof(System.Security.SecurityElement), "invalid_text_chars");
				}
				return r_Finvalid_text_chars;
			}
		}

		/// <summary>
		/// System.Char[] invalid_attr_name_chars
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RChar> r_Finvalid_attr_name_chars;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RChar> RFinvalid_attr_name_chars
		{
			get
			{
				if(r_Finvalid_attr_name_chars == null)
				{
					r_Finvalid_attr_name_chars = new(typeof(System.Security.SecurityElement), "invalid_attr_name_chars");
				}
				return r_Finvalid_attr_name_chars;
			}
		}

		/// <summary>
		/// System.Char[] invalid_attr_value_chars
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RChar> r_Finvalid_attr_value_chars;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RChar> RFinvalid_attr_value_chars
		{
			get
			{
				if(r_Finvalid_attr_value_chars == null)
				{
					r_Finvalid_attr_value_chars = new(typeof(System.Security.SecurityElement), "invalid_attr_value_chars");
				}
				return r_Finvalid_attr_value_chars;
			}
		}

		/// <summary>
		/// System.Char[] invalid_chars
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RChar> r_Finvalid_chars;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RChar> RFinvalid_chars
		{
			get
			{
				if(r_Finvalid_chars == null)
				{
					r_Finvalid_chars = new(typeof(System.Security.SecurityElement), "invalid_chars");
				}
				return r_Finvalid_chars;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable Attributes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable r_PAttributes;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RHashtable RPAttributes
		{
			get
			{
				if(r_PAttributes == null)
				{
					r_PAttributes = new(this, "Attributes", -1);
				}
				return r_PAttributes;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList Children
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList r_PChildren;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList RPChildren
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
		/// System.String Tag
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PTag;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPTag
		{
			get
			{
				if(r_PTag == null)
				{
					r_PTag = new(this, "Tag", -1);
				}
				return r_PTag;
			}
		}

		/// <summary>
		/// System.String Text
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PText;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPText
		{
			get
			{
				if(r_PText == null)
				{
					r_PText = new(this, "Text", -1);
				}
				return r_PText;
			}
		}

		/// <summary>
		/// System.String m_strTag
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pm_strTag;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPm_strTag
		{
			get
			{
				if(r_Pm_strTag == null)
				{
					r_Pm_strTag = new(this, "m_strTag", -1);
				}
				return r_Pm_strTag;
			}
		}

		/// <summary>
		/// System.String m_strText
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pm_strText;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPm_strText
		{
			get
			{
				if(r_Pm_strText == null)
				{
					r_Pm_strText = new(this, "m_strText", -1);
				}
				return r_Pm_strText;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList m_lAttributes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList r_Pm_lAttributes;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList RPm_lAttributes
		{
			get
			{
				if(r_Pm_lAttributes == null)
				{
					r_Pm_lAttributes = new(this, "m_lAttributes", -1);
				}
				return r_Pm_lAttributes;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList InternalChildren
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList r_PInternalChildren;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RArrayList RPInternalChildren
		{
			get
			{
				if(r_PInternalChildren == null)
				{
					r_PInternalChildren = new(this, "InternalChildren", -1);
				}
				return r_PInternalChildren;
			}
		}

		/// <summary>
		/// Void AddAttribute(System.String, System.String)
		/// </summary>
		protected RMethod r_MAddAttribute_String_String;
		public virtual RMethod RMAddAttribute_String_String
		{
			get
			{
				if(r_MAddAttribute_String_String == null)
				{
					r_MAddAttribute_String_String = new(this, "AddAttribute", 0, typeof(System.String), typeof(System.String));
				}
				return r_MAddAttribute_String_String;
			}
		}

		/// <summary>
		/// Void AddChild(System.Security.SecurityElement)
		/// </summary>
		protected RMethod r_MAddChild_SecurityElement;
		public virtual RMethod RMAddChild_SecurityElement
		{
			get
			{
				if(r_MAddChild_SecurityElement == null)
				{
					r_MAddChild_SecurityElement = new(this, "AddChild", 0, typeof(System.Security.SecurityElement));
				}
				return r_MAddChild_SecurityElement;
			}
		}

		/// <summary>
		/// System.String Attribute(System.String)
		/// </summary>
		protected RMethod r_MAttribute_String;
		public virtual RMethod RMAttribute_String
		{
			get
			{
				if(r_MAttribute_String == null)
				{
					r_MAttribute_String = new(this, "Attribute", 0, typeof(System.String));
				}
				return r_MAttribute_String;
			}
		}

		/// <summary>
		/// System.Security.SecurityElement Copy()
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
		/// Boolean Equal(System.Security.SecurityElement)
		/// </summary>
		protected RMethod r_MEqual_SecurityElement;
		public virtual RMethod RMEqual_SecurityElement
		{
			get
			{
				if(r_MEqual_SecurityElement == null)
				{
					r_MEqual_SecurityElement = new(this, "Equal", 0, typeof(System.Security.SecurityElement));
				}
				return r_MEqual_SecurityElement;
			}
		}

		/// <summary>
		/// System.String Escape(System.String)
		/// </summary>
		protected static RMethod r_MEscape_String;
		public static RMethod RMEscape_String
		{
			get
			{
				if(r_MEscape_String == null)
				{
					r_MEscape_String = new(typeof(System.Security.SecurityElement), "Escape", 0, typeof(System.String));
				}
				return r_MEscape_String;
			}
		}

		/// <summary>
		/// System.String Unescape(System.String)
		/// </summary>
		protected static RMethod r_MUnescape_String;
		public static RMethod RMUnescape_String
		{
			get
			{
				if(r_MUnescape_String == null)
				{
					r_MUnescape_String = new(typeof(System.Security.SecurityElement), "Unescape", 0, typeof(System.String));
				}
				return r_MUnescape_String;
			}
		}

		/// <summary>
		/// System.Security.SecurityElement FromString(System.String)
		/// </summary>
		protected static RMethod r_MFromString_String;
		public static RMethod RMFromString_String
		{
			get
			{
				if(r_MFromString_String == null)
				{
					r_MFromString_String = new(typeof(System.Security.SecurityElement), "FromString", 0, typeof(System.String));
				}
				return r_MFromString_String;
			}
		}

		/// <summary>
		/// Boolean IsValidAttributeName(System.String)
		/// </summary>
		protected static RMethod r_MIsValidAttributeName_String;
		public static RMethod RMIsValidAttributeName_String
		{
			get
			{
				if(r_MIsValidAttributeName_String == null)
				{
					r_MIsValidAttributeName_String = new(typeof(System.Security.SecurityElement), "IsValidAttributeName", 0, typeof(System.String));
				}
				return r_MIsValidAttributeName_String;
			}
		}

		/// <summary>
		/// Boolean IsValidAttributeValue(System.String)
		/// </summary>
		protected static RMethod r_MIsValidAttributeValue_String;
		public static RMethod RMIsValidAttributeValue_String
		{
			get
			{
				if(r_MIsValidAttributeValue_String == null)
				{
					r_MIsValidAttributeValue_String = new(typeof(System.Security.SecurityElement), "IsValidAttributeValue", 0, typeof(System.String));
				}
				return r_MIsValidAttributeValue_String;
			}
		}

		/// <summary>
		/// Boolean IsValidTag(System.String)
		/// </summary>
		protected static RMethod r_MIsValidTag_String;
		public static RMethod RMIsValidTag_String
		{
			get
			{
				if(r_MIsValidTag_String == null)
				{
					r_MIsValidTag_String = new(typeof(System.Security.SecurityElement), "IsValidTag", 0, typeof(System.String));
				}
				return r_MIsValidTag_String;
			}
		}

		/// <summary>
		/// Boolean IsValidText(System.String)
		/// </summary>
		protected static RMethod r_MIsValidText_String;
		public static RMethod RMIsValidText_String
		{
			get
			{
				if(r_MIsValidText_String == null)
				{
					r_MIsValidText_String = new(typeof(System.Security.SecurityElement), "IsValidText", 0, typeof(System.String));
				}
				return r_MIsValidText_String;
			}
		}

		/// <summary>
		/// System.Security.SecurityElement SearchForChildByTag(System.String)
		/// </summary>
		protected RMethod r_MSearchForChildByTag_String;
		public virtual RMethod RMSearchForChildByTag_String
		{
			get
			{
				if(r_MSearchForChildByTag_String == null)
				{
					r_MSearchForChildByTag_String = new(this, "SearchForChildByTag", 0, typeof(System.String));
				}
				return r_MSearchForChildByTag_String;
			}
		}

		/// <summary>
		/// System.String SearchForTextOfTag(System.String)
		/// </summary>
		protected RMethod r_MSearchForTextOfTag_String;
		public virtual RMethod RMSearchForTextOfTag_String
		{
			get
			{
				if(r_MSearchForTextOfTag_String == null)
				{
					r_MSearchForTextOfTag_String = new(this, "SearchForTextOfTag", 0, typeof(System.String));
				}
				return r_MSearchForTextOfTag_String;
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

		/// <summary>
		/// Void ToXml(System.Text.StringBuilder ByRef, Int32)
		/// </summary>
		protected RMethod r_MToXml_Ref_StringBuilder_Int32;
		public virtual RMethod RMToXml_Ref_StringBuilder_Int32
		{
			get
			{
				if(r_MToXml_Ref_StringBuilder_Int32 == null)
				{
					r_MToXml_Ref_StringBuilder_Int32 = new(this, "ToXml", 0, typeof(System.Text.StringBuilder).MakeByRefType(), typeof(System.Int32));
				}
				return r_MToXml_Ref_StringBuilder_Int32;
			}
		}

		/// <summary>
		/// SecurityAttribute GetAttribute(System.String)
		/// </summary>
		protected RMethod r_MGetAttribute_String;
		public virtual RMethod RMGetAttribute_String
		{
			get
			{
				if(r_MGetAttribute_String == null)
				{
					r_MGetAttribute_String = new(this, "GetAttribute", 0, typeof(System.String));
				}
				return r_MGetAttribute_String;
			}
		}

		/// <summary>
		/// System.String SearchForTextOfLocalName(System.String)
		/// </summary>
		protected RMethod r_MSearchForTextOfLocalName_String;
		public virtual RMethod RMSearchForTextOfLocalName_String
		{
			get
			{
				if(r_MSearchForTextOfLocalName_String == null)
				{
					r_MSearchForTextOfLocalName_String = new(this, "SearchForTextOfLocalName", 0, typeof(System.String));
				}
				return r_MSearchForTextOfLocalName_String;
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

        public virtual void AddAttribute(System.String @name, System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddAttribute_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddChild(System.Security.SecurityElement @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RMAddChild_SecurityElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String Attribute(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMAttribute_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Security.SecurityElement Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
        }


        public virtual System.Boolean Equal(System.Security.SecurityElement @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEqual_SecurityElement.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String Escape(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMEscape_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String Unescape(System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RMUnescape_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Security.SecurityElement FromString(System.String @xml)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xml};
            var ___result = RMFromString_String.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
        }


        public static System.Boolean IsValidAttributeName(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMIsValidAttributeName_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsValidAttributeValue(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMIsValidAttributeValue_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsValidTag(System.String @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RMIsValidTag_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsValidText(System.String @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RMIsValidText_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Security.SecurityElement SearchForChildByTag(System.String @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RMSearchForChildByTag_String.Invoke(___genericsType, ___parameters);

            return (System.Security.SecurityElement)___result;
        }


        public virtual System.String SearchForTextOfTag(System.String @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RMSearchForTextOfTag_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void ToXml(ref System.Text.StringBuilder @s, System.Int32 @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @level};
            var ___result = RMToXml_Ref_StringBuilder_Int32.Invoke(___genericsType, ___parameters);
			@s = (System.Text.StringBuilder)___parameters[0];

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RSecurityElement.RSecurityAttribute GetAttribute(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetAttribute_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RSecurity.RSecurityElement.RSecurityAttribute(___result);
        }


        public virtual System.String SearchForTextOfLocalName(System.String @strLocalName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@strLocalName};
            var ___result = RMSearchForTextOfLocalName_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


    }
}
