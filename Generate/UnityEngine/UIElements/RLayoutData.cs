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
		protected RField r_alignContent;
		public virtual RField RalignContent
		{
			get
			{
				if(r_alignContent == null)
				{
					r_alignContent = new(this, "alignContent");
					r_alignContent.SetBelong(this.instance);
				}
				return r_alignContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Align alignItems
		/// </summary>
		protected RField r_alignItems;
		public virtual RField RalignItems
		{
			get
			{
				if(r_alignItems == null)
				{
					r_alignItems = new(this, "alignItems");
					r_alignItems.SetBelong(this.instance);
				}
				return r_alignItems;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Align alignSelf
		/// </summary>
		protected RField r_alignSelf;
		public virtual RField RalignSelf
		{
			get
			{
				if(r_alignSelf == null)
				{
					r_alignSelf = new(this, "alignSelf");
					r_alignSelf.SetBelong(this.instance);
				}
				return r_alignSelf;
			}
		}

		/// <summary>
		/// System.Single borderBottomWidth
		/// </summary>
		protected RField r_borderBottomWidth;
		public virtual RField RborderBottomWidth
		{
			get
			{
				if(r_borderBottomWidth == null)
				{
					r_borderBottomWidth = new(this, "borderBottomWidth");
					r_borderBottomWidth.SetBelong(this.instance);
				}
				return r_borderBottomWidth;
			}
		}

		/// <summary>
		/// System.Single borderLeftWidth
		/// </summary>
		protected RField r_borderLeftWidth;
		public virtual RField RborderLeftWidth
		{
			get
			{
				if(r_borderLeftWidth == null)
				{
					r_borderLeftWidth = new(this, "borderLeftWidth");
					r_borderLeftWidth.SetBelong(this.instance);
				}
				return r_borderLeftWidth;
			}
		}

		/// <summary>
		/// System.Single borderRightWidth
		/// </summary>
		protected RField r_borderRightWidth;
		public virtual RField RborderRightWidth
		{
			get
			{
				if(r_borderRightWidth == null)
				{
					r_borderRightWidth = new(this, "borderRightWidth");
					r_borderRightWidth.SetBelong(this.instance);
				}
				return r_borderRightWidth;
			}
		}

		/// <summary>
		/// System.Single borderTopWidth
		/// </summary>
		protected RField r_borderTopWidth;
		public virtual RField RborderTopWidth
		{
			get
			{
				if(r_borderTopWidth == null)
				{
					r_borderTopWidth = new(this, "borderTopWidth");
					r_borderTopWidth.SetBelong(this.instance);
				}
				return r_borderTopWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length bottom
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_bottom;
		public virtual RUnityEngine.RUIElements.RLength Rbottom
		{
			get
			{
				if(r_bottom == null)
				{
					r_bottom = new(this, "bottom");
					r_bottom.SetBelong(this.instance);
				}
				return r_bottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DisplayStyle display
		/// </summary>
		protected RField r_display;
		public virtual RField Rdisplay
		{
			get
			{
				if(r_display == null)
				{
					r_display = new(this, "display");
					r_display.SetBelong(this.instance);
				}
				return r_display;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length flexBasis
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_flexBasis;
		public virtual RUnityEngine.RUIElements.RLength RflexBasis
		{
			get
			{
				if(r_flexBasis == null)
				{
					r_flexBasis = new(this, "flexBasis");
					r_flexBasis.SetBelong(this.instance);
				}
				return r_flexBasis;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FlexDirection flexDirection
		/// </summary>
		protected RField r_flexDirection;
		public virtual RField RflexDirection
		{
			get
			{
				if(r_flexDirection == null)
				{
					r_flexDirection = new(this, "flexDirection");
					r_flexDirection.SetBelong(this.instance);
				}
				return r_flexDirection;
			}
		}

		/// <summary>
		/// System.Single flexGrow
		/// </summary>
		protected RField r_flexGrow;
		public virtual RField RflexGrow
		{
			get
			{
				if(r_flexGrow == null)
				{
					r_flexGrow = new(this, "flexGrow");
					r_flexGrow.SetBelong(this.instance);
				}
				return r_flexGrow;
			}
		}

		/// <summary>
		/// System.Single flexShrink
		/// </summary>
		protected RField r_flexShrink;
		public virtual RField RflexShrink
		{
			get
			{
				if(r_flexShrink == null)
				{
					r_flexShrink = new(this, "flexShrink");
					r_flexShrink.SetBelong(this.instance);
				}
				return r_flexShrink;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Wrap flexWrap
		/// </summary>
		protected RField r_flexWrap;
		public virtual RField RflexWrap
		{
			get
			{
				if(r_flexWrap == null)
				{
					r_flexWrap = new(this, "flexWrap");
					r_flexWrap.SetBelong(this.instance);
				}
				return r_flexWrap;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length height
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_height;
		public virtual RUnityEngine.RUIElements.RLength Rheight
		{
			get
			{
				if(r_height == null)
				{
					r_height = new(this, "height");
					r_height.SetBelong(this.instance);
				}
				return r_height;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Justify justifyContent
		/// </summary>
		protected RField r_justifyContent;
		public virtual RField RjustifyContent
		{
			get
			{
				if(r_justifyContent == null)
				{
					r_justifyContent = new(this, "justifyContent");
					r_justifyContent.SetBelong(this.instance);
				}
				return r_justifyContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length left
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_left;
		public virtual RUnityEngine.RUIElements.RLength Rleft
		{
			get
			{
				if(r_left == null)
				{
					r_left = new(this, "left");
					r_left.SetBelong(this.instance);
				}
				return r_left;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length marginBottom
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_marginBottom;
		public virtual RUnityEngine.RUIElements.RLength RmarginBottom
		{
			get
			{
				if(r_marginBottom == null)
				{
					r_marginBottom = new(this, "marginBottom");
					r_marginBottom.SetBelong(this.instance);
				}
				return r_marginBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length marginLeft
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_marginLeft;
		public virtual RUnityEngine.RUIElements.RLength RmarginLeft
		{
			get
			{
				if(r_marginLeft == null)
				{
					r_marginLeft = new(this, "marginLeft");
					r_marginLeft.SetBelong(this.instance);
				}
				return r_marginLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length marginRight
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_marginRight;
		public virtual RUnityEngine.RUIElements.RLength RmarginRight
		{
			get
			{
				if(r_marginRight == null)
				{
					r_marginRight = new(this, "marginRight");
					r_marginRight.SetBelong(this.instance);
				}
				return r_marginRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length marginTop
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_marginTop;
		public virtual RUnityEngine.RUIElements.RLength RmarginTop
		{
			get
			{
				if(r_marginTop == null)
				{
					r_marginTop = new(this, "marginTop");
					r_marginTop.SetBelong(this.instance);
				}
				return r_marginTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length maxHeight
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_maxHeight;
		public virtual RUnityEngine.RUIElements.RLength RmaxHeight
		{
			get
			{
				if(r_maxHeight == null)
				{
					r_maxHeight = new(this, "maxHeight");
					r_maxHeight.SetBelong(this.instance);
				}
				return r_maxHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length maxWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_maxWidth;
		public virtual RUnityEngine.RUIElements.RLength RmaxWidth
		{
			get
			{
				if(r_maxWidth == null)
				{
					r_maxWidth = new(this, "maxWidth");
					r_maxWidth.SetBelong(this.instance);
				}
				return r_maxWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length minHeight
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_minHeight;
		public virtual RUnityEngine.RUIElements.RLength RminHeight
		{
			get
			{
				if(r_minHeight == null)
				{
					r_minHeight = new(this, "minHeight");
					r_minHeight.SetBelong(this.instance);
				}
				return r_minHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length minWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_minWidth;
		public virtual RUnityEngine.RUIElements.RLength RminWidth
		{
			get
			{
				if(r_minWidth == null)
				{
					r_minWidth = new(this, "minWidth");
					r_minWidth.SetBelong(this.instance);
				}
				return r_minWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length paddingBottom
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_paddingBottom;
		public virtual RUnityEngine.RUIElements.RLength RpaddingBottom
		{
			get
			{
				if(r_paddingBottom == null)
				{
					r_paddingBottom = new(this, "paddingBottom");
					r_paddingBottom.SetBelong(this.instance);
				}
				return r_paddingBottom;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length paddingLeft
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_paddingLeft;
		public virtual RUnityEngine.RUIElements.RLength RpaddingLeft
		{
			get
			{
				if(r_paddingLeft == null)
				{
					r_paddingLeft = new(this, "paddingLeft");
					r_paddingLeft.SetBelong(this.instance);
				}
				return r_paddingLeft;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length paddingRight
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_paddingRight;
		public virtual RUnityEngine.RUIElements.RLength RpaddingRight
		{
			get
			{
				if(r_paddingRight == null)
				{
					r_paddingRight = new(this, "paddingRight");
					r_paddingRight.SetBelong(this.instance);
				}
				return r_paddingRight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length paddingTop
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_paddingTop;
		public virtual RUnityEngine.RUIElements.RLength RpaddingTop
		{
			get
			{
				if(r_paddingTop == null)
				{
					r_paddingTop = new(this, "paddingTop");
					r_paddingTop.SetBelong(this.instance);
				}
				return r_paddingTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Position position
		/// </summary>
		protected RField r_position;
		public virtual RField Rposition
		{
			get
			{
				if(r_position == null)
				{
					r_position = new(this, "position");
					r_position.SetBelong(this.instance);
				}
				return r_position;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length right
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_right;
		public virtual RUnityEngine.RUIElements.RLength Rright
		{
			get
			{
				if(r_right == null)
				{
					r_right = new(this, "right");
					r_right.SetBelong(this.instance);
				}
				return r_right;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length top
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_top;
		public virtual RUnityEngine.RUIElements.RLength Rtop
		{
			get
			{
				if(r_top == null)
				{
					r_top = new(this, "top");
					r_top.SetBelong(this.instance);
				}
				return r_top;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length width
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_width;
		public virtual RUnityEngine.RUIElements.RLength Rwidth
		{
			get
			{
				if(r_width == null)
				{
					r_width = new(this, "width");
					r_width.SetBelong(this.instance);
				}
				return r_width;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.LayoutData Copy()
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
		/// Void CopyFrom(UnityEngine.UIElements.LayoutData ByRef)
		/// </summary>
		protected RMethod r_RCopyFrom_Ref_LayoutData;
		public virtual RMethod RCopyFrom_Ref_LayoutData
		{
			get
			{
				if(r_RCopyFrom_Ref_LayoutData == null)
				{
					r_RCopyFrom_Ref_LayoutData = new(this, "CopyFrom", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.LayoutData").MakeByRefType());
					r_RCopyFrom_Ref_LayoutData.SetBelong(this.instance);
				}
				return r_RCopyFrom_Ref_LayoutData;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.LayoutData, UnityEngine.UIElements.LayoutData)
		/// </summary>
		protected static RMethod r_Rop_Equality_LayoutData_LayoutData;
		public static RMethod Rop_Equality_LayoutData_LayoutData
		{
			get
			{
				if(r_Rop_Equality_LayoutData_LayoutData == null)
				{
					r_Rop_Equality_LayoutData_LayoutData = new( ReleactionUtils.GetType("UnityEngine.UIElements.LayoutData"), "op_Equality", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.LayoutData"),  ReleactionUtils.GetType("UnityEngine.UIElements.LayoutData"));
					r_Rop_Equality_LayoutData_LayoutData.SetBelong(null);
				}
				return r_Rop_Equality_LayoutData_LayoutData;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.LayoutData, UnityEngine.UIElements.LayoutData)
		/// </summary>
		protected static RMethod r_Rop_Inequality_LayoutData_LayoutData;
		public static RMethod Rop_Inequality_LayoutData_LayoutData
		{
			get
			{
				if(r_Rop_Inequality_LayoutData_LayoutData == null)
				{
					r_Rop_Inequality_LayoutData_LayoutData = new( ReleactionUtils.GetType("UnityEngine.UIElements.LayoutData"), "op_Inequality", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.LayoutData"),  ReleactionUtils.GetType("UnityEngine.UIElements.LayoutData"));
					r_Rop_Inequality_LayoutData_LayoutData.SetBelong(null);
				}
				return r_Rop_Inequality_LayoutData_LayoutData;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.LayoutData)
		/// </summary>
		protected RMethod r_REquals_LayoutData;
		public virtual RMethod REquals_LayoutData
		{
			get
			{
				if(r_REquals_LayoutData == null)
				{
					r_REquals_LayoutData = new(this, "Equals", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.LayoutData"));
					r_REquals_LayoutData.SetBelong(this.instance);
				}
				return r_REquals_LayoutData;
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
