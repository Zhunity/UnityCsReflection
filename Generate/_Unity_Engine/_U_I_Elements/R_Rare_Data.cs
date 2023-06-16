
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.RareData
	/// </summary>
    public partial class RRareData : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.RareData");
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


		/// <summary>
		/// UnityEngine.UIElements.Cursor cursor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RCursor r_Fcursor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RCursor RFcursor
		{
			get
			{
				if(r_Fcursor == null)
				{
					r_Fcursor = new(this, "cursor");
				}
				return r_Fcursor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextOverflow textOverflow
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflow r_FtextOverflow;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflow RFtextOverflow
		{
			get
			{
				if(r_FtextOverflow == null)
				{
					r_FtextOverflow = new(this, "textOverflow");
				}
				return r_FtextOverflow;
			}
		}

		/// <summary>
		/// UnityEngine.Color unityBackgroundImageTintColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_FunityBackgroundImageTintColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFunityBackgroundImageTintColor
		{
			get
			{
				if(r_FunityBackgroundImageTintColor == null)
				{
					r_FunityBackgroundImageTintColor = new(this, "unityBackgroundImageTintColor");
				}
				return r_FunityBackgroundImageTintColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.OverflowClipBox unityOverflowClipBox
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.ROverflowClipBox r_FunityOverflowClipBox;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.ROverflowClipBox RFunityOverflowClipBox
		{
			get
			{
				if(r_FunityOverflowClipBox == null)
				{
					r_FunityOverflowClipBox = new(this, "unityOverflowClipBox");
				}
				return r_FunityOverflowClipBox;
			}
		}

		/// <summary>
		/// System.Int32 unitySliceBottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FunitySliceBottom;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFunitySliceBottom
		{
			get
			{
				if(r_FunitySliceBottom == null)
				{
					r_FunitySliceBottom = new(this, "unitySliceBottom");
				}
				return r_FunitySliceBottom;
			}
		}

		/// <summary>
		/// System.Int32 unitySliceLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FunitySliceLeft;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFunitySliceLeft
		{
			get
			{
				if(r_FunitySliceLeft == null)
				{
					r_FunitySliceLeft = new(this, "unitySliceLeft");
				}
				return r_FunitySliceLeft;
			}
		}

		/// <summary>
		/// System.Int32 unitySliceRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FunitySliceRight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFunitySliceRight
		{
			get
			{
				if(r_FunitySliceRight == null)
				{
					r_FunitySliceRight = new(this, "unitySliceRight");
				}
				return r_FunitySliceRight;
			}
		}

		/// <summary>
		/// System.Single unitySliceScale
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FunitySliceScale;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFunitySliceScale
		{
			get
			{
				if(r_FunitySliceScale == null)
				{
					r_FunitySliceScale = new(this, "unitySliceScale");
				}
				return r_FunitySliceScale;
			}
		}

		/// <summary>
		/// System.Int32 unitySliceTop
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FunitySliceTop;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFunitySliceTop
		{
			get
			{
				if(r_FunitySliceTop == null)
				{
					r_FunitySliceTop = new(this, "unitySliceTop");
				}
				return r_FunitySliceTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextOverflowPosition unityTextOverflowPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflowPosition r_FunityTextOverflowPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflowPosition RFunityTextOverflowPosition
		{
			get
			{
				if(r_FunityTextOverflowPosition == null)
				{
					r_FunityTextOverflowPosition = new(this, "unityTextOverflowPosition");
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
					r_Mop_Equality_RareData_RareData = new(Type, "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.RareData"),  ReflectionUtils.GetType("UnityEngine.UIElements.RareData"));
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
					r_Mop_Inequality_RareData_RareData = new(Type, "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.RareData"),  ReflectionUtils.GetType("UnityEngine.UIElements.RareData"));
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


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRareData Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRareData>(___result);
        }


        public virtual void CopyFrom(ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRareData @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMCopyFrom_Ref_RareData.Invoke(___genericsType, ___parameters);
			@other = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRareData>(___parameters[0]);

            
        }


        public static System.Boolean op_Equality(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRareData @lhs, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRareData @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Equality_RareData_RareData.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRareData @lhs, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRareData @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Inequality_RareData_RareData.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRareData @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_RareData.Invoke(___genericsType, ___parameters);

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
