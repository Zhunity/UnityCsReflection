
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.InheritedData
	/// </summary>
    public partial class RInheritedData : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.InheritedData");
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


		/// <summary>
		/// UnityEngine.Color color
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_Fcolor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFcolor
		{
			get
			{
				if(r_Fcolor == null)
				{
					r_Fcolor = new(this, "color");
				}
				return r_Fcolor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length fontSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FfontSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFfontSize
		{
			get
			{
				if(r_FfontSize == null)
				{
					r_FfontSize = new(this, "fontSize");
				}
				return r_FfontSize;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length letterSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FletterSpacing;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFletterSpacing
		{
			get
			{
				if(r_FletterSpacing == null)
				{
					r_FletterSpacing = new(this, "letterSpacing");
				}
				return r_FletterSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextShadow textShadow
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextShadow r_FtextShadow;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextShadow RFtextShadow
		{
			get
			{
				if(r_FtextShadow == null)
				{
					r_FtextShadow = new(this, "textShadow");
				}
				return r_FtextShadow;
			}
		}

		/// <summary>
		/// UnityEngine.Font unityFont
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RFont r_FunityFont;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RFont RFunityFont
		{
			get
			{
				if(r_FunityFont == null)
				{
					r_FunityFont = new(this, "unityFont");
				}
				return r_FunityFont;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FontDefinition unityFontDefinition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFontDefinition r_FunityFontDefinition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFontDefinition RFunityFontDefinition
		{
			get
			{
				if(r_FunityFontDefinition == null)
				{
					r_FunityFontDefinition = new(this, "unityFontDefinition");
				}
				return r_FunityFontDefinition;
			}
		}

		/// <summary>
		/// UnityEngine.FontStyle unityFontStyleAndWeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RFontStyle r_FunityFontStyleAndWeight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RFontStyle RFunityFontStyleAndWeight
		{
			get
			{
				if(r_FunityFontStyleAndWeight == null)
				{
					r_FunityFontStyleAndWeight = new(this, "unityFontStyleAndWeight");
				}
				return r_FunityFontStyleAndWeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length unityParagraphSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FunityParagraphSpacing;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFunityParagraphSpacing
		{
			get
			{
				if(r_FunityParagraphSpacing == null)
				{
					r_FunityParagraphSpacing = new(this, "unityParagraphSpacing");
				}
				return r_FunityParagraphSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.TextAnchor unityTextAlign
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextAnchor r_FunityTextAlign;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextAnchor RFunityTextAlign
		{
			get
			{
				if(r_FunityTextAlign == null)
				{
					r_FunityTextAlign = new(this, "unityTextAlign");
				}
				return r_FunityTextAlign;
			}
		}

		/// <summary>
		/// UnityEngine.Color unityTextOutlineColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_FunityTextOutlineColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFunityTextOutlineColor
		{
			get
			{
				if(r_FunityTextOutlineColor == null)
				{
					r_FunityTextOutlineColor = new(this, "unityTextOutlineColor");
				}
				return r_FunityTextOutlineColor;
			}
		}

		/// <summary>
		/// System.Single unityTextOutlineWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FunityTextOutlineWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFunityTextOutlineWidth
		{
			get
			{
				if(r_FunityTextOutlineWidth == null)
				{
					r_FunityTextOutlineWidth = new(this, "unityTextOutlineWidth");
				}
				return r_FunityTextOutlineWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Visibility visibility
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisibility r_Fvisibility;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisibility RFvisibility
		{
			get
			{
				if(r_Fvisibility == null)
				{
					r_Fvisibility = new(this, "visibility");
				}
				return r_Fvisibility;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.WhiteSpace whiteSpace
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RWhiteSpace r_FwhiteSpace;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RWhiteSpace RFwhiteSpace
		{
			get
			{
				if(r_FwhiteSpace == null)
				{
					r_FwhiteSpace = new(this, "whiteSpace");
				}
				return r_FwhiteSpace;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length wordSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FwordSpacing;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFwordSpacing
		{
			get
			{
				if(r_FwordSpacing == null)
				{
					r_FwordSpacing = new(this, "wordSpacing");
				}
				return r_FwordSpacing;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.InheritedData Copy()
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
		/// Void CopyFrom(UnityEngine.UIElements.InheritedData ByRef)
		/// </summary>
		protected RMethod r_MCopyFrom_Ref_InheritedData;
		public virtual RMethod RMCopyFrom_Ref_InheritedData
		{
			get
			{
				if(r_MCopyFrom_Ref_InheritedData == null)
				{
					r_MCopyFrom_Ref_InheritedData = new(this, "CopyFrom", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.InheritedData").MakeByRefType());
				}
				return r_MCopyFrom_Ref_InheritedData;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.InheritedData, UnityEngine.UIElements.InheritedData)
		/// </summary>
		protected static RMethod r_Mop_Equality_InheritedData_InheritedData;
		public static RMethod RMop_Equality_InheritedData_InheritedData
		{
			get
			{
				if(r_Mop_Equality_InheritedData_InheritedData == null)
				{
					r_Mop_Equality_InheritedData_InheritedData = new( ReflectionUtils.GetType("UnityEngine.UIElements.InheritedData"), "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.InheritedData"),  ReflectionUtils.GetType("UnityEngine.UIElements.InheritedData"));
				}
				return r_Mop_Equality_InheritedData_InheritedData;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.InheritedData, UnityEngine.UIElements.InheritedData)
		/// </summary>
		protected static RMethod r_Mop_Inequality_InheritedData_InheritedData;
		public static RMethod RMop_Inequality_InheritedData_InheritedData
		{
			get
			{
				if(r_Mop_Inequality_InheritedData_InheritedData == null)
				{
					r_Mop_Inequality_InheritedData_InheritedData = new( ReflectionUtils.GetType("UnityEngine.UIElements.InheritedData"), "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.InheritedData"),  ReflectionUtils.GetType("UnityEngine.UIElements.InheritedData"));
				}
				return r_Mop_Inequality_InheritedData_InheritedData;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.InheritedData)
		/// </summary>
		protected RMethod r_MEquals_InheritedData;
		public virtual RMethod RMEquals_InheritedData
		{
			get
			{
				if(r_MEquals_InheritedData == null)
				{
					r_MEquals_InheritedData = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.InheritedData"));
				}
				return r_MEquals_InheritedData;
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


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInheritedData Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInheritedData(___result);
        }


        public virtual void CopyFrom(ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInheritedData @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMCopyFrom_Ref_InheritedData.Invoke(___genericsType, ___parameters);
			@other = new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInheritedData(___parameters[0]);

            
        }


        public static System.Boolean op_Equality(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInheritedData @lhs, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInheritedData @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Equality_InheritedData_InheritedData.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInheritedData @lhs, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInheritedData @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Inequality_InheritedData_InheritedData.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInheritedData @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_InheritedData.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


    }
}
