using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.InheritedData
	/// </summary>
    public partial class RInheritedData : RMember //
    {

		/// <summary>
		/// UnityEngine.Color color
		/// </summary>
		protected RUnityEngine.RColor r_color;
		public virtual RUnityEngine.RColor Rcolor
		{
			get
			{
				if(r_color == null)
				{
					r_color = new(this, "color");
					r_color.SetBelong(this.instance);
				}
				return r_color;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length fontSize
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_fontSize;
		public virtual RUnityEngine.RUIElements.RLength RfontSize
		{
			get
			{
				if(r_fontSize == null)
				{
					r_fontSize = new(this, "fontSize");
					r_fontSize.SetBelong(this.instance);
				}
				return r_fontSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length letterSpacing
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_letterSpacing;
		public virtual RUnityEngine.RUIElements.RLength RletterSpacing
		{
			get
			{
				if(r_letterSpacing == null)
				{
					r_letterSpacing = new(this, "letterSpacing");
					r_letterSpacing.SetBelong(this.instance);
				}
				return r_letterSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextShadow textShadow
		/// </summary>
		protected RUnityEngine.RUIElements.RTextShadow r_textShadow;
		public virtual RUnityEngine.RUIElements.RTextShadow RtextShadow
		{
			get
			{
				if(r_textShadow == null)
				{
					r_textShadow = new(this, "textShadow");
					r_textShadow.SetBelong(this.instance);
				}
				return r_textShadow;
			}
		}

		/// <summary>
		/// UnityEngine.Font unityFont
		/// </summary>
		protected RUnityEngine.RFont r_unityFont;
		public virtual RUnityEngine.RFont RunityFont
		{
			get
			{
				if(r_unityFont == null)
				{
					r_unityFont = new(this, "unityFont");
					r_unityFont.SetBelong(this.instance);
				}
				return r_unityFont;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FontDefinition unityFontDefinition
		/// </summary>
		protected RUnityEngine.RUIElements.RFontDefinition r_unityFontDefinition;
		public virtual RUnityEngine.RUIElements.RFontDefinition RunityFontDefinition
		{
			get
			{
				if(r_unityFontDefinition == null)
				{
					r_unityFontDefinition = new(this, "unityFontDefinition");
					r_unityFontDefinition.SetBelong(this.instance);
				}
				return r_unityFontDefinition;
			}
		}

		/// <summary>
		/// UnityEngine.FontStyle unityFontStyleAndWeight
		/// </summary>
		protected RField r_unityFontStyleAndWeight;
		public virtual RField RunityFontStyleAndWeight
		{
			get
			{
				if(r_unityFontStyleAndWeight == null)
				{
					r_unityFontStyleAndWeight = new(this, "unityFontStyleAndWeight");
					r_unityFontStyleAndWeight.SetBelong(this.instance);
				}
				return r_unityFontStyleAndWeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length unityParagraphSpacing
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_unityParagraphSpacing;
		public virtual RUnityEngine.RUIElements.RLength RunityParagraphSpacing
		{
			get
			{
				if(r_unityParagraphSpacing == null)
				{
					r_unityParagraphSpacing = new(this, "unityParagraphSpacing");
					r_unityParagraphSpacing.SetBelong(this.instance);
				}
				return r_unityParagraphSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.TextAnchor unityTextAlign
		/// </summary>
		protected RField r_unityTextAlign;
		public virtual RField RunityTextAlign
		{
			get
			{
				if(r_unityTextAlign == null)
				{
					r_unityTextAlign = new(this, "unityTextAlign");
					r_unityTextAlign.SetBelong(this.instance);
				}
				return r_unityTextAlign;
			}
		}

		/// <summary>
		/// UnityEngine.Color unityTextOutlineColor
		/// </summary>
		protected RUnityEngine.RColor r_unityTextOutlineColor;
		public virtual RUnityEngine.RColor RunityTextOutlineColor
		{
			get
			{
				if(r_unityTextOutlineColor == null)
				{
					r_unityTextOutlineColor = new(this, "unityTextOutlineColor");
					r_unityTextOutlineColor.SetBelong(this.instance);
				}
				return r_unityTextOutlineColor;
			}
		}

		/// <summary>
		/// System.Single unityTextOutlineWidth
		/// </summary>
		protected RField r_unityTextOutlineWidth;
		public virtual RField RunityTextOutlineWidth
		{
			get
			{
				if(r_unityTextOutlineWidth == null)
				{
					r_unityTextOutlineWidth = new(this, "unityTextOutlineWidth");
					r_unityTextOutlineWidth.SetBelong(this.instance);
				}
				return r_unityTextOutlineWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Visibility visibility
		/// </summary>
		protected RField r_visibility;
		public virtual RField Rvisibility
		{
			get
			{
				if(r_visibility == null)
				{
					r_visibility = new(this, "visibility");
					r_visibility.SetBelong(this.instance);
				}
				return r_visibility;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.WhiteSpace whiteSpace
		/// </summary>
		protected RField r_whiteSpace;
		public virtual RField RwhiteSpace
		{
			get
			{
				if(r_whiteSpace == null)
				{
					r_whiteSpace = new(this, "whiteSpace");
					r_whiteSpace.SetBelong(this.instance);
				}
				return r_whiteSpace;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length wordSpacing
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_wordSpacing;
		public virtual RUnityEngine.RUIElements.RLength RwordSpacing
		{
			get
			{
				if(r_wordSpacing == null)
				{
					r_wordSpacing = new(this, "wordSpacing");
					r_wordSpacing.SetBelong(this.instance);
				}
				return r_wordSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.InheritedData Copy()
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
		/// Void CopyFrom(UnityEngine.UIElements.InheritedData ByRef)
		/// </summary>
		protected RMethod r_RCopyFrom_Ref_InheritedData;
		public virtual RMethod RCopyFrom_Ref_InheritedData
		{
			get
			{
				if(r_RCopyFrom_Ref_InheritedData == null)
				{
					r_RCopyFrom_Ref_InheritedData = new(this, "CopyFrom", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.InheritedData").MakeByRefType());
					r_RCopyFrom_Ref_InheritedData.SetBelong(this.instance);
				}
				return r_RCopyFrom_Ref_InheritedData;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.InheritedData, UnityEngine.UIElements.InheritedData)
		/// </summary>
		protected static RMethod r_Rop_Equality_InheritedData_InheritedData;
		public static RMethod Rop_Equality_InheritedData_InheritedData
		{
			get
			{
				if(r_Rop_Equality_InheritedData_InheritedData == null)
				{
					r_Rop_Equality_InheritedData_InheritedData = new( ReleactionUtils.GetType("UnityEngine.UIElements.InheritedData"), "op_Equality", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.InheritedData"),  ReleactionUtils.GetType("UnityEngine.UIElements.InheritedData"));
					r_Rop_Equality_InheritedData_InheritedData.SetBelong(null);
				}
				return r_Rop_Equality_InheritedData_InheritedData;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.InheritedData, UnityEngine.UIElements.InheritedData)
		/// </summary>
		protected static RMethod r_Rop_Inequality_InheritedData_InheritedData;
		public static RMethod Rop_Inequality_InheritedData_InheritedData
		{
			get
			{
				if(r_Rop_Inequality_InheritedData_InheritedData == null)
				{
					r_Rop_Inequality_InheritedData_InheritedData = new( ReleactionUtils.GetType("UnityEngine.UIElements.InheritedData"), "op_Inequality", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.InheritedData"),  ReleactionUtils.GetType("UnityEngine.UIElements.InheritedData"));
					r_Rop_Inequality_InheritedData_InheritedData.SetBelong(null);
				}
				return r_Rop_Inequality_InheritedData_InheritedData;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.InheritedData)
		/// </summary>
		protected RMethod r_REquals_InheritedData;
		public virtual RMethod REquals_InheritedData
		{
			get
			{
				if(r_REquals_InheritedData == null)
				{
					r_REquals_InheritedData = new(this, "Equals", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.InheritedData"));
					r_REquals_InheritedData.SetBelong(this.instance);
				}
				return r_REquals_InheritedData;
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


        public RInheritedData() : base("UnityEngine.UIElements.InheritedData")
        {
        }

        public RInheritedData(System.Object instance) : base("UnityEngine.UIElements.InheritedData")
		{
            SetInstance(instance);
		}

        public RInheritedData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RInheritedData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCopy.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }






        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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
