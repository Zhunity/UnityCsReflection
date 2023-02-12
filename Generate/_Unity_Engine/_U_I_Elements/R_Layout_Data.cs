
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.LayoutData
	/// </summary>
    public partial class RLayoutData : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.Align alignContent
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RAlign r_FalignContent;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RAlign RFalignContent
		{
			get
			{
				if(r_FalignContent == null)
				{
					r_FalignContent = new(this, "alignContent");
					r_FalignContent.SetBelong(this.instance);
				}
				return r_FalignContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Align alignItems
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RAlign r_FalignItems;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RAlign RFalignItems
		{
			get
			{
				if(r_FalignItems == null)
				{
					r_FalignItems = new(this, "alignItems");
					r_FalignItems.SetBelong(this.instance);
				}
				return r_FalignItems;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Align alignSelf
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RAlign r_FalignSelf;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RAlign RFalignSelf
		{
			get
			{
				if(r_FalignSelf == null)
				{
					r_FalignSelf = new(this, "alignSelf");
					r_FalignSelf.SetBelong(this.instance);
				}
				return r_FalignSelf;
			}
		}

		/// <summary>
		/// System.Single borderBottomWidth
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FborderBottomWidth;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFborderBottomWidth
		{
			get
			{
				if(r_FborderBottomWidth == null)
				{
					r_FborderBottomWidth = new(this, "borderBottomWidth");
					r_FborderBottomWidth.SetBelong(this.instance);
				}
				return r_FborderBottomWidth;
			}
		}

		/// <summary>
		/// System.Single borderLeftWidth
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FborderLeftWidth;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFborderLeftWidth
		{
			get
			{
				if(r_FborderLeftWidth == null)
				{
					r_FborderLeftWidth = new(this, "borderLeftWidth");
					r_FborderLeftWidth.SetBelong(this.instance);
				}
				return r_FborderLeftWidth;
			}
		}

		/// <summary>
		/// System.Single borderRightWidth
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FborderRightWidth;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFborderRightWidth
		{
			get
			{
				if(r_FborderRightWidth == null)
				{
					r_FborderRightWidth = new(this, "borderRightWidth");
					r_FborderRightWidth.SetBelong(this.instance);
				}
				return r_FborderRightWidth;
			}
		}

		/// <summary>
		/// System.Single borderTopWidth
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FborderTopWidth;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFborderTopWidth
		{
			get
			{
				if(r_FborderTopWidth == null)
				{
					r_FborderTopWidth = new(this, "borderTopWidth");
					r_FborderTopWidth.SetBelong(this.instance);
				}
				return r_FborderTopWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length bottom
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Fbottom;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFbottom
		{
			get
			{
				if(r_Fbottom == null)
				{
					r_Fbottom = new(this, "bottom");
					r_Fbottom.SetBelong(this.instance);
				}
				return r_Fbottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DisplayStyle display
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RDisplayStyle r_Fdisplay;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RDisplayStyle RFdisplay
		{
			get
			{
				if(r_Fdisplay == null)
				{
					r_Fdisplay = new(this, "display");
					r_Fdisplay.SetBelong(this.instance);
				}
				return r_Fdisplay;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length flexBasis
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FflexBasis;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFflexBasis
		{
			get
			{
				if(r_FflexBasis == null)
				{
					r_FflexBasis = new(this, "flexBasis");
					r_FflexBasis.SetBelong(this.instance);
				}
				return r_FflexBasis;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FlexDirection flexDirection
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RFlexDirection r_FflexDirection;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RFlexDirection RFflexDirection
		{
			get
			{
				if(r_FflexDirection == null)
				{
					r_FflexDirection = new(this, "flexDirection");
					r_FflexDirection.SetBelong(this.instance);
				}
				return r_FflexDirection;
			}
		}

		/// <summary>
		/// System.Single flexGrow
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FflexGrow;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFflexGrow
		{
			get
			{
				if(r_FflexGrow == null)
				{
					r_FflexGrow = new(this, "flexGrow");
					r_FflexGrow.SetBelong(this.instance);
				}
				return r_FflexGrow;
			}
		}

		/// <summary>
		/// System.Single flexShrink
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FflexShrink;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFflexShrink
		{
			get
			{
				if(r_FflexShrink == null)
				{
					r_FflexShrink = new(this, "flexShrink");
					r_FflexShrink.SetBelong(this.instance);
				}
				return r_FflexShrink;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Wrap flexWrap
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RWrap r_FflexWrap;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RWrap RFflexWrap
		{
			get
			{
				if(r_FflexWrap == null)
				{
					r_FflexWrap = new(this, "flexWrap");
					r_FflexWrap.SetBelong(this.instance);
				}
				return r_FflexWrap;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length height
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Fheight;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFheight
		{
			get
			{
				if(r_Fheight == null)
				{
					r_Fheight = new(this, "height");
					r_Fheight.SetBelong(this.instance);
				}
				return r_Fheight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Justify justifyContent
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RJustify r_FjustifyContent;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RJustify RFjustifyContent
		{
			get
			{
				if(r_FjustifyContent == null)
				{
					r_FjustifyContent = new(this, "justifyContent");
					r_FjustifyContent.SetBelong(this.instance);
				}
				return r_FjustifyContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length left
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Fleft;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFleft
		{
			get
			{
				if(r_Fleft == null)
				{
					r_Fleft = new(this, "left");
					r_Fleft.SetBelong(this.instance);
				}
				return r_Fleft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length marginBottom
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FmarginBottom;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFmarginBottom
		{
			get
			{
				if(r_FmarginBottom == null)
				{
					r_FmarginBottom = new(this, "marginBottom");
					r_FmarginBottom.SetBelong(this.instance);
				}
				return r_FmarginBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length marginLeft
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FmarginLeft;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFmarginLeft
		{
			get
			{
				if(r_FmarginLeft == null)
				{
					r_FmarginLeft = new(this, "marginLeft");
					r_FmarginLeft.SetBelong(this.instance);
				}
				return r_FmarginLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length marginRight
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FmarginRight;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFmarginRight
		{
			get
			{
				if(r_FmarginRight == null)
				{
					r_FmarginRight = new(this, "marginRight");
					r_FmarginRight.SetBelong(this.instance);
				}
				return r_FmarginRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length marginTop
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FmarginTop;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFmarginTop
		{
			get
			{
				if(r_FmarginTop == null)
				{
					r_FmarginTop = new(this, "marginTop");
					r_FmarginTop.SetBelong(this.instance);
				}
				return r_FmarginTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length maxHeight
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FmaxHeight;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFmaxHeight
		{
			get
			{
				if(r_FmaxHeight == null)
				{
					r_FmaxHeight = new(this, "maxHeight");
					r_FmaxHeight.SetBelong(this.instance);
				}
				return r_FmaxHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length maxWidth
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FmaxWidth;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFmaxWidth
		{
			get
			{
				if(r_FmaxWidth == null)
				{
					r_FmaxWidth = new(this, "maxWidth");
					r_FmaxWidth.SetBelong(this.instance);
				}
				return r_FmaxWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length minHeight
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FminHeight;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFminHeight
		{
			get
			{
				if(r_FminHeight == null)
				{
					r_FminHeight = new(this, "minHeight");
					r_FminHeight.SetBelong(this.instance);
				}
				return r_FminHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length minWidth
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FminWidth;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFminWidth
		{
			get
			{
				if(r_FminWidth == null)
				{
					r_FminWidth = new(this, "minWidth");
					r_FminWidth.SetBelong(this.instance);
				}
				return r_FminWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length paddingBottom
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FpaddingBottom;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFpaddingBottom
		{
			get
			{
				if(r_FpaddingBottom == null)
				{
					r_FpaddingBottom = new(this, "paddingBottom");
					r_FpaddingBottom.SetBelong(this.instance);
				}
				return r_FpaddingBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length paddingLeft
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FpaddingLeft;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFpaddingLeft
		{
			get
			{
				if(r_FpaddingLeft == null)
				{
					r_FpaddingLeft = new(this, "paddingLeft");
					r_FpaddingLeft.SetBelong(this.instance);
				}
				return r_FpaddingLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length paddingRight
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FpaddingRight;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFpaddingRight
		{
			get
			{
				if(r_FpaddingRight == null)
				{
					r_FpaddingRight = new(this, "paddingRight");
					r_FpaddingRight.SetBelong(this.instance);
				}
				return r_FpaddingRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length paddingTop
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FpaddingTop;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFpaddingTop
		{
			get
			{
				if(r_FpaddingTop == null)
				{
					r_FpaddingTop = new(this, "paddingTop");
					r_FpaddingTop.SetBelong(this.instance);
				}
				return r_FpaddingTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Position position
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RPosition r_Fposition;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RPosition RFposition
		{
			get
			{
				if(r_Fposition == null)
				{
					r_Fposition = new(this, "position");
					r_Fposition.SetBelong(this.instance);
				}
				return r_Fposition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length right
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Fright;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFright
		{
			get
			{
				if(r_Fright == null)
				{
					r_Fright = new(this, "right");
					r_Fright.SetBelong(this.instance);
				}
				return r_Fright;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length top
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Ftop;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFtop
		{
			get
			{
				if(r_Ftop == null)
				{
					r_Ftop = new(this, "top");
					r_Ftop.SetBelong(this.instance);
				}
				return r_Ftop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length width
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Fwidth;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFwidth
		{
			get
			{
				if(r_Fwidth == null)
				{
					r_Fwidth = new(this, "width");
					r_Fwidth.SetBelong(this.instance);
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
					r_MCopy.SetBelong(this.instance);
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
					r_MCopyFrom_Ref_LayoutData.SetBelong(this.instance);
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
					r_Mop_Equality_LayoutData_LayoutData = new( ReflectionUtils.GetType("UnityEngine.UIElements.LayoutData"), "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.LayoutData"),  ReflectionUtils.GetType("UnityEngine.UIElements.LayoutData"));
					r_Mop_Equality_LayoutData_LayoutData.SetBelong(null);
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
					r_Mop_Inequality_LayoutData_LayoutData = new( ReflectionUtils.GetType("UnityEngine.UIElements.LayoutData"), "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.LayoutData"),  ReflectionUtils.GetType("UnityEngine.UIElements.LayoutData"));
					r_Mop_Inequality_LayoutData_LayoutData.SetBelong(null);
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
					r_MEquals_LayoutData.SetBelong(this.instance);
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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

        public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLayoutData Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLayoutData(___result);
        }


        public virtual void CopyFrom(ref SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLayoutData @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMCopyFrom_Ref_LayoutData.Invoke(___genericsType, ___parameters);
			@other = new SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLayoutData(___parameters[0]);

            
        }


        public static System.Boolean op_Equality(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLayoutData @lhs, SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLayoutData @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Equality_LayoutData_LayoutData.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLayoutData @lhs, SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLayoutData @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Inequality_LayoutData_LayoutData.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RLayoutData @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_LayoutData.Invoke(___genericsType, ___parameters);

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
