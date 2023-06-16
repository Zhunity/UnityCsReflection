
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.LayoutData
	/// </summary>
    public partial class RLayoutData : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.LayoutData");
            }
        }

        public RLayoutData() : base("UnityEngine.UIElements.LayoutData")
        {
        }

        public RLayoutData(System.Object instance) : base("UnityEngine.UIElements.LayoutData")
		{
            SetInstance(instance);
		}

        public RLayoutData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLayoutData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.UIElements.Align alignContent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign r_FalignContent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign RFalignContent
		{
			get
			{
				if(r_FalignContent == null)
				{
					r_FalignContent = new(this, "alignContent");
				}
				return r_FalignContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Align alignItems
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign r_FalignItems;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign RFalignItems
		{
			get
			{
				if(r_FalignItems == null)
				{
					r_FalignItems = new(this, "alignItems");
				}
				return r_FalignItems;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Align alignSelf
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign r_FalignSelf;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign RFalignSelf
		{
			get
			{
				if(r_FalignSelf == null)
				{
					r_FalignSelf = new(this, "alignSelf");
				}
				return r_FalignSelf;
			}
		}

		/// <summary>
		/// System.Single borderBottomWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FborderBottomWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFborderBottomWidth
		{
			get
			{
				if(r_FborderBottomWidth == null)
				{
					r_FborderBottomWidth = new(this, "borderBottomWidth");
				}
				return r_FborderBottomWidth;
			}
		}

		/// <summary>
		/// System.Single borderLeftWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FborderLeftWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFborderLeftWidth
		{
			get
			{
				if(r_FborderLeftWidth == null)
				{
					r_FborderLeftWidth = new(this, "borderLeftWidth");
				}
				return r_FborderLeftWidth;
			}
		}

		/// <summary>
		/// System.Single borderRightWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FborderRightWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFborderRightWidth
		{
			get
			{
				if(r_FborderRightWidth == null)
				{
					r_FborderRightWidth = new(this, "borderRightWidth");
				}
				return r_FborderRightWidth;
			}
		}

		/// <summary>
		/// System.Single borderTopWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FborderTopWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFborderTopWidth
		{
			get
			{
				if(r_FborderTopWidth == null)
				{
					r_FborderTopWidth = new(this, "borderTopWidth");
				}
				return r_FborderTopWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length bottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Fbottom;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFbottom
		{
			get
			{
				if(r_Fbottom == null)
				{
					r_Fbottom = new(this, "bottom");
				}
				return r_Fbottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DisplayStyle display
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDisplayStyle r_Fdisplay;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDisplayStyle RFdisplay
		{
			get
			{
				if(r_Fdisplay == null)
				{
					r_Fdisplay = new(this, "display");
				}
				return r_Fdisplay;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length flexBasis
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FflexBasis;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFflexBasis
		{
			get
			{
				if(r_FflexBasis == null)
				{
					r_FflexBasis = new(this, "flexBasis");
				}
				return r_FflexBasis;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FlexDirection flexDirection
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFlexDirection r_FflexDirection;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFlexDirection RFflexDirection
		{
			get
			{
				if(r_FflexDirection == null)
				{
					r_FflexDirection = new(this, "flexDirection");
				}
				return r_FflexDirection;
			}
		}

		/// <summary>
		/// System.Single flexGrow
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FflexGrow;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFflexGrow
		{
			get
			{
				if(r_FflexGrow == null)
				{
					r_FflexGrow = new(this, "flexGrow");
				}
				return r_FflexGrow;
			}
		}

		/// <summary>
		/// System.Single flexShrink
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FflexShrink;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFflexShrink
		{
			get
			{
				if(r_FflexShrink == null)
				{
					r_FflexShrink = new(this, "flexShrink");
				}
				return r_FflexShrink;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Wrap flexWrap
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RWrap r_FflexWrap;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RWrap RFflexWrap
		{
			get
			{
				if(r_FflexWrap == null)
				{
					r_FflexWrap = new(this, "flexWrap");
				}
				return r_FflexWrap;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length height
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Fheight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFheight
		{
			get
			{
				if(r_Fheight == null)
				{
					r_Fheight = new(this, "height");
				}
				return r_Fheight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Justify justifyContent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RJustify r_FjustifyContent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RJustify RFjustifyContent
		{
			get
			{
				if(r_FjustifyContent == null)
				{
					r_FjustifyContent = new(this, "justifyContent");
				}
				return r_FjustifyContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length left
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Fleft;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFleft
		{
			get
			{
				if(r_Fleft == null)
				{
					r_Fleft = new(this, "left");
				}
				return r_Fleft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length marginBottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FmarginBottom;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFmarginBottom
		{
			get
			{
				if(r_FmarginBottom == null)
				{
					r_FmarginBottom = new(this, "marginBottom");
				}
				return r_FmarginBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length marginLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FmarginLeft;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFmarginLeft
		{
			get
			{
				if(r_FmarginLeft == null)
				{
					r_FmarginLeft = new(this, "marginLeft");
				}
				return r_FmarginLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length marginRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FmarginRight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFmarginRight
		{
			get
			{
				if(r_FmarginRight == null)
				{
					r_FmarginRight = new(this, "marginRight");
				}
				return r_FmarginRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length marginTop
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FmarginTop;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFmarginTop
		{
			get
			{
				if(r_FmarginTop == null)
				{
					r_FmarginTop = new(this, "marginTop");
				}
				return r_FmarginTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length maxHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FmaxHeight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFmaxHeight
		{
			get
			{
				if(r_FmaxHeight == null)
				{
					r_FmaxHeight = new(this, "maxHeight");
				}
				return r_FmaxHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length maxWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FmaxWidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFmaxWidth
		{
			get
			{
				if(r_FmaxWidth == null)
				{
					r_FmaxWidth = new(this, "maxWidth");
				}
				return r_FmaxWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length minHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FminHeight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFminHeight
		{
			get
			{
				if(r_FminHeight == null)
				{
					r_FminHeight = new(this, "minHeight");
				}
				return r_FminHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length minWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FminWidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFminWidth
		{
			get
			{
				if(r_FminWidth == null)
				{
					r_FminWidth = new(this, "minWidth");
				}
				return r_FminWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length paddingBottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FpaddingBottom;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFpaddingBottom
		{
			get
			{
				if(r_FpaddingBottom == null)
				{
					r_FpaddingBottom = new(this, "paddingBottom");
				}
				return r_FpaddingBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length paddingLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FpaddingLeft;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFpaddingLeft
		{
			get
			{
				if(r_FpaddingLeft == null)
				{
					r_FpaddingLeft = new(this, "paddingLeft");
				}
				return r_FpaddingLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length paddingRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FpaddingRight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFpaddingRight
		{
			get
			{
				if(r_FpaddingRight == null)
				{
					r_FpaddingRight = new(this, "paddingRight");
				}
				return r_FpaddingRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length paddingTop
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FpaddingTop;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFpaddingTop
		{
			get
			{
				if(r_FpaddingTop == null)
				{
					r_FpaddingTop = new(this, "paddingTop");
				}
				return r_FpaddingTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Position position
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPosition r_Fposition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPosition RFposition
		{
			get
			{
				if(r_Fposition == null)
				{
					r_Fposition = new(this, "position");
				}
				return r_Fposition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length right
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Fright;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFright
		{
			get
			{
				if(r_Fright == null)
				{
					r_Fright = new(this, "right");
				}
				return r_Fright;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length top
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Ftop;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFtop
		{
			get
			{
				if(r_Ftop == null)
				{
					r_Ftop = new(this, "top");
				}
				return r_Ftop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length width
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Fwidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFwidth
		{
			get
			{
				if(r_Fwidth == null)
				{
					r_Fwidth = new(this, "width");
				}
				return r_Fwidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.LayoutData Copy()
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
		/// Void CopyFrom(UnityEngine.UIElements.LayoutData ByRef)
		/// </summary>
		protected RMethod r_MCopyFrom_Ref_LayoutData;
		public virtual RMethod RMCopyFrom_Ref_LayoutData
		{
			get
			{
				if(r_MCopyFrom_Ref_LayoutData == null)
				{
					r_MCopyFrom_Ref_LayoutData = new(this, "CopyFrom", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.LayoutData").MakeByRefType());
				}
				return r_MCopyFrom_Ref_LayoutData;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.LayoutData, UnityEngine.UIElements.LayoutData)
		/// </summary>
		protected static RMethod r_Mop_Equality_LayoutData_LayoutData;
		public static RMethod RMop_Equality_LayoutData_LayoutData
		{
			get
			{
				if(r_Mop_Equality_LayoutData_LayoutData == null)
				{
					r_Mop_Equality_LayoutData_LayoutData = new(Type, "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.LayoutData"),  ReflectionUtils.GetType("UnityEngine.UIElements.LayoutData"));
				}
				return r_Mop_Equality_LayoutData_LayoutData;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.LayoutData, UnityEngine.UIElements.LayoutData)
		/// </summary>
		protected static RMethod r_Mop_Inequality_LayoutData_LayoutData;
		public static RMethod RMop_Inequality_LayoutData_LayoutData
		{
			get
			{
				if(r_Mop_Inequality_LayoutData_LayoutData == null)
				{
					r_Mop_Inequality_LayoutData_LayoutData = new(Type, "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.LayoutData"),  ReflectionUtils.GetType("UnityEngine.UIElements.LayoutData"));
				}
				return r_Mop_Inequality_LayoutData_LayoutData;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.LayoutData)
		/// </summary>
		protected RMethod r_MEquals_LayoutData;
		public virtual RMethod RMEquals_LayoutData
		{
			get
			{
				if(r_MEquals_LayoutData == null)
				{
					r_MEquals_LayoutData = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.LayoutData"));
				}
				return r_MEquals_LayoutData;
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


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLayoutData Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLayoutData>(___result);
        }


        public virtual void CopyFrom(ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLayoutData @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMCopyFrom_Ref_LayoutData.Invoke(___genericsType, ___parameters);
			@other = new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLayoutData(___parameters[0]);

            
        }


        public static System.Boolean op_Equality(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLayoutData @lhs, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLayoutData @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Equality_LayoutData_LayoutData.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLayoutData @lhs, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLayoutData @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Inequality_LayoutData_LayoutData.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLayoutData @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_LayoutData.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
