using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.RareData
	/// </summary>
    public partial class RRareData : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.Cursor cursor
		/// </summary>
		protected RUnityEngine.RUIElements.RCursor r_cursor;
		public virtual RUnityEngine.RUIElements.RCursor Rcursor
		{
			get
			{
				if(r_cursor == null)
				{
					r_cursor = new(this, "cursor");
					r_cursor.SetBelong(this.instance);
				}
				return r_cursor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextOverflow textOverflow
		/// </summary>
		protected RField r_textOverflow;
		public virtual RField RtextOverflow
		{
			get
			{
				if(r_textOverflow == null)
				{
					r_textOverflow = new(this, "textOverflow");
					r_textOverflow.SetBelong(this.instance);
				}
				return r_textOverflow;
			}
		}

		/// <summary>
		/// UnityEngine.Color unityBackgroundImageTintColor
		/// </summary>
		protected RUnityEngine.RColor r_unityBackgroundImageTintColor;
		public virtual RUnityEngine.RColor RunityBackgroundImageTintColor
		{
			get
			{
				if(r_unityBackgroundImageTintColor == null)
				{
					r_unityBackgroundImageTintColor = new(this, "unityBackgroundImageTintColor");
					r_unityBackgroundImageTintColor.SetBelong(this.instance);
				}
				return r_unityBackgroundImageTintColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.OverflowClipBox unityOverflowClipBox
		/// </summary>
		protected RField r_unityOverflowClipBox;
		public virtual RField RunityOverflowClipBox
		{
			get
			{
				if(r_unityOverflowClipBox == null)
				{
					r_unityOverflowClipBox = new(this, "unityOverflowClipBox");
					r_unityOverflowClipBox.SetBelong(this.instance);
				}
				return r_unityOverflowClipBox;
			}
		}

		/// <summary>
		/// System.Int32 unitySliceBottom
		/// </summary>
		protected RField r_unitySliceBottom;
		public virtual RField RunitySliceBottom
		{
			get
			{
				if(r_unitySliceBottom == null)
				{
					r_unitySliceBottom = new(this, "unitySliceBottom");
					r_unitySliceBottom.SetBelong(this.instance);
				}
				return r_unitySliceBottom;
			}
		}

		/// <summary>
		/// System.Int32 unitySliceLeft
		/// </summary>
		protected RField r_unitySliceLeft;
		public virtual RField RunitySliceLeft
		{
			get
			{
				if(r_unitySliceLeft == null)
				{
					r_unitySliceLeft = new(this, "unitySliceLeft");
					r_unitySliceLeft.SetBelong(this.instance);
				}
				return r_unitySliceLeft;
			}
		}

		/// <summary>
		/// System.Int32 unitySliceRight
		/// </summary>
		protected RField r_unitySliceRight;
		public virtual RField RunitySliceRight
		{
			get
			{
				if(r_unitySliceRight == null)
				{
					r_unitySliceRight = new(this, "unitySliceRight");
					r_unitySliceRight.SetBelong(this.instance);
				}
				return r_unitySliceRight;
			}
		}

		/// <summary>
		/// System.Single unitySliceScale
		/// </summary>
		protected RField r_unitySliceScale;
		public virtual RField RunitySliceScale
		{
			get
			{
				if(r_unitySliceScale == null)
				{
					r_unitySliceScale = new(this, "unitySliceScale");
					r_unitySliceScale.SetBelong(this.instance);
				}
				return r_unitySliceScale;
			}
		}

		/// <summary>
		/// System.Int32 unitySliceTop
		/// </summary>
		protected RField r_unitySliceTop;
		public virtual RField RunitySliceTop
		{
			get
			{
				if(r_unitySliceTop == null)
				{
					r_unitySliceTop = new(this, "unitySliceTop");
					r_unitySliceTop.SetBelong(this.instance);
				}
				return r_unitySliceTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextOverflowPosition unityTextOverflowPosition
		/// </summary>
		protected RField r_unityTextOverflowPosition;
		public virtual RField RunityTextOverflowPosition
		{
			get
			{
				if(r_unityTextOverflowPosition == null)
				{
					r_unityTextOverflowPosition = new(this, "unityTextOverflowPosition");
					r_unityTextOverflowPosition.SetBelong(this.instance);
				}
				return r_unityTextOverflowPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.RareData Copy()
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
		/// Void CopyFrom(UnityEngine.UIElements.RareData ByRef)
		/// </summary>
		protected RMethod r_RCopyFrom_Ref_RareData;
		public virtual RMethod RCopyFrom_Ref_RareData
		{
			get
			{
				if(r_RCopyFrom_Ref_RareData == null)
				{
					r_RCopyFrom_Ref_RareData = new(this, "CopyFrom", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.RareData").MakeByRefType());
					r_RCopyFrom_Ref_RareData.SetBelong(this.instance);
				}
				return r_RCopyFrom_Ref_RareData;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.RareData, UnityEngine.UIElements.RareData)
		/// </summary>
		protected static RMethod r_Rop_Equality_RareData_RareData;
		public static RMethod Rop_Equality_RareData_RareData
		{
			get
			{
				if(r_Rop_Equality_RareData_RareData == null)
				{
					r_Rop_Equality_RareData_RareData = new( ReleactionUtils.GetType("UnityEngine.UIElements.RareData"), "op_Equality", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.RareData"),  ReleactionUtils.GetType("UnityEngine.UIElements.RareData"));
					r_Rop_Equality_RareData_RareData.SetBelong(null);
				}
				return r_Rop_Equality_RareData_RareData;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.RareData, UnityEngine.UIElements.RareData)
		/// </summary>
		protected static RMethod r_Rop_Inequality_RareData_RareData;
		public static RMethod Rop_Inequality_RareData_RareData
		{
			get
			{
				if(r_Rop_Inequality_RareData_RareData == null)
				{
					r_Rop_Inequality_RareData_RareData = new( ReleactionUtils.GetType("UnityEngine.UIElements.RareData"), "op_Inequality", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.RareData"),  ReleactionUtils.GetType("UnityEngine.UIElements.RareData"));
					r_Rop_Inequality_RareData_RareData.SetBelong(null);
				}
				return r_Rop_Inequality_RareData_RareData;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.RareData)
		/// </summary>
		protected RMethod r_REquals_RareData;
		public virtual RMethod REquals_RareData
		{
			get
			{
				if(r_REquals_RareData == null)
				{
					r_REquals_RareData = new(this, "Equals", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.RareData"));
					r_REquals_RareData.SetBelong(this.instance);
				}
				return r_REquals_RareData;
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


        public RRareData() : base("UnityEngine.UIElements.RareData")
        {
        }

        public RRareData(System.Object instance) : base("UnityEngine.UIElements.RareData")
		{
            SetInstance(instance);
		}

        public RRareData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRareData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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