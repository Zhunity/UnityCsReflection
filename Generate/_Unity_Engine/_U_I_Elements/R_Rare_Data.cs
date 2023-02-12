
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
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RCursor r_Fcursor;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RCursor RFcursor
		{
			get
			{
				if(r_Fcursor == null)
				{
					r_Fcursor = new(this, "cursor");
					r_Fcursor.SetBelong(this.instance);
				}
				return r_Fcursor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextOverflow textOverflow
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflow r_FtextOverflow;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflow RFtextOverflow
		{
			get
			{
				if(r_FtextOverflow == null)
				{
					r_FtextOverflow = new(this, "textOverflow");
					r_FtextOverflow.SetBelong(this.instance);
				}
				return r_FtextOverflow;
			}
		}

		/// <summary>
		/// UnityEngine.Color unityBackgroundImageTintColor
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RColor r_FunityBackgroundImageTintColor;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RColor RFunityBackgroundImageTintColor
		{
			get
			{
				if(r_FunityBackgroundImageTintColor == null)
				{
					r_FunityBackgroundImageTintColor = new(this, "unityBackgroundImageTintColor");
					r_FunityBackgroundImageTintColor.SetBelong(this.instance);
				}
				return r_FunityBackgroundImageTintColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.OverflowClipBox unityOverflowClipBox
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.ROverflowClipBox r_FunityOverflowClipBox;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.ROverflowClipBox RFunityOverflowClipBox
		{
			get
			{
				if(r_FunityOverflowClipBox == null)
				{
					r_FunityOverflowClipBox = new(this, "unityOverflowClipBox");
					r_FunityOverflowClipBox.SetBelong(this.instance);
				}
				return r_FunityOverflowClipBox;
			}
		}

		/// <summary>
		/// System.Int32 unitySliceBottom
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FunitySliceBottom;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFunitySliceBottom
		{
			get
			{
				if(r_FunitySliceBottom == null)
				{
					r_FunitySliceBottom = new(this, "unitySliceBottom");
					r_FunitySliceBottom.SetBelong(this.instance);
				}
				return r_FunitySliceBottom;
			}
		}

		/// <summary>
		/// System.Int32 unitySliceLeft
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FunitySliceLeft;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFunitySliceLeft
		{
			get
			{
				if(r_FunitySliceLeft == null)
				{
					r_FunitySliceLeft = new(this, "unitySliceLeft");
					r_FunitySliceLeft.SetBelong(this.instance);
				}
				return r_FunitySliceLeft;
			}
		}

		/// <summary>
		/// System.Int32 unitySliceRight
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FunitySliceRight;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFunitySliceRight
		{
			get
			{
				if(r_FunitySliceRight == null)
				{
					r_FunitySliceRight = new(this, "unitySliceRight");
					r_FunitySliceRight.SetBelong(this.instance);
				}
				return r_FunitySliceRight;
			}
		}

		/// <summary>
		/// System.Single unitySliceScale
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FunitySliceScale;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFunitySliceScale
		{
			get
			{
				if(r_FunitySliceScale == null)
				{
					r_FunitySliceScale = new(this, "unitySliceScale");
					r_FunitySliceScale.SetBelong(this.instance);
				}
				return r_FunitySliceScale;
			}
		}

		/// <summary>
		/// System.Int32 unitySliceTop
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FunitySliceTop;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFunitySliceTop
		{
			get
			{
				if(r_FunitySliceTop == null)
				{
					r_FunitySliceTop = new(this, "unitySliceTop");
					r_FunitySliceTop.SetBelong(this.instance);
				}
				return r_FunitySliceTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextOverflowPosition unityTextOverflowPosition
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflowPosition r_FunityTextOverflowPosition;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflowPosition RFunityTextOverflowPosition
		{
			get
			{
				if(r_FunityTextOverflowPosition == null)
				{
					r_FunityTextOverflowPosition = new(this, "unityTextOverflowPosition");
					r_FunityTextOverflowPosition.SetBelong(this.instance);
				}
				return r_FunityTextOverflowPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.RareData Copy()
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
		/// Void CopyFrom(UnityEngine.UIElements.RareData ByRef)
		/// </summary>
		protected RMethod r_MCopyFrom_Ref_RareData;
		public virtual RMethod RMCopyFrom_Ref_RareData
		{
			get
			{
				if(r_MCopyFrom_Ref_RareData == null)
				{
					r_MCopyFrom_Ref_RareData = new(this, "CopyFrom", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.RareData").MakeByRefType());
					r_MCopyFrom_Ref_RareData.SetBelong(this.instance);
				}
				return r_MCopyFrom_Ref_RareData;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.RareData, UnityEngine.UIElements.RareData)
		/// </summary>
		protected static RMethod r_Mop_Equality_RareData_RareData;
		public static RMethod RMop_Equality_RareData_RareData
		{
			get
			{
				if(r_Mop_Equality_RareData_RareData == null)
				{
					r_Mop_Equality_RareData_RareData = new( ReflectionUtils.GetType("UnityEngine.UIElements.RareData"), "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.RareData"),  ReflectionUtils.GetType("UnityEngine.UIElements.RareData"));
					r_Mop_Equality_RareData_RareData.SetBelong(null);
				}
				return r_Mop_Equality_RareData_RareData;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.RareData, UnityEngine.UIElements.RareData)
		/// </summary>
		protected static RMethod r_Mop_Inequality_RareData_RareData;
		public static RMethod RMop_Inequality_RareData_RareData
		{
			get
			{
				if(r_Mop_Inequality_RareData_RareData == null)
				{
					r_Mop_Inequality_RareData_RareData = new( ReflectionUtils.GetType("UnityEngine.UIElements.RareData"), "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.RareData"),  ReflectionUtils.GetType("UnityEngine.UIElements.RareData"));
					r_Mop_Inequality_RareData_RareData.SetBelong(null);
				}
				return r_Mop_Inequality_RareData_RareData;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.RareData)
		/// </summary>
		protected RMethod r_MEquals_RareData;
		public virtual RMethod RMEquals_RareData
		{
			get
			{
				if(r_MEquals_RareData == null)
				{
					r_MEquals_RareData = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.RareData"));
					r_MEquals_RareData.SetBelong(this.instance);
				}
				return r_MEquals_RareData;
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

        public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RRareData Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return new SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RRareData(___result);
        }


        public virtual void CopyFrom(ref SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RRareData @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMCopyFrom_Ref_RareData.Invoke(___genericsType, ___parameters);
			@other = new SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RRareData(___parameters[0]);

            
        }


        public static System.Boolean op_Equality(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RRareData @lhs, SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RRareData @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Equality_RareData_RareData.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RRareData @lhs, SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RRareData @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Inequality_RareData_RareData.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RRareData @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_RareData.Invoke(___genericsType, ___parameters);

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