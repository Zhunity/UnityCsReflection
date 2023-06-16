
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{public partial class RSplitView
{
	
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEditor.SplitView+ViewEdge
	/// </summary>
    public partial class RViewEdge : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.SplitView+ViewEdge");
            }
        }

        public RViewEdge() : base("UnityEditor.SplitView+ViewEdge")
        {
        }

        public RViewEdge(System.Object instance) : base("UnityEditor.SplitView+ViewEdge")
		{
            SetInstance(instance);
		}

        public RViewEdge(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RViewEdge(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// UnityEditor.SplitView+ViewEdge None
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge r_FNone;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge RFNone
		{
			get
			{
				if(r_FNone == null)
				{
					r_FNone = new(Type, "None");
				}
				return r_FNone;
			}
		}

		/// <summary>
		/// UnityEditor.SplitView+ViewEdge Left
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge r_FLeft;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge RFLeft
		{
			get
			{
				if(r_FLeft == null)
				{
					r_FLeft = new(Type, "Left");
				}
				return r_FLeft;
			}
		}

		/// <summary>
		/// UnityEditor.SplitView+ViewEdge Bottom
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge r_FBottom;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge RFBottom
		{
			get
			{
				if(r_FBottom == null)
				{
					r_FBottom = new(Type, "Bottom");
				}
				return r_FBottom;
			}
		}

		/// <summary>
		/// UnityEditor.SplitView+ViewEdge Top
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge r_FTop;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge RFTop
		{
			get
			{
				if(r_FTop == null)
				{
					r_FTop = new(Type, "Top");
				}
				return r_FTop;
			}
		}

		/// <summary>
		/// UnityEditor.SplitView+ViewEdge Right
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge r_FRight;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge RFRight
		{
			get
			{
				if(r_FRight == null)
				{
					r_FRight = new(Type, "Right");
				}
				return r_FRight;
			}
		}

		/// <summary>
		/// UnityEditor.SplitView+ViewEdge BottomLeft
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge r_FBottomLeft;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge RFBottomLeft
		{
			get
			{
				if(r_FBottomLeft == null)
				{
					r_FBottomLeft = new(Type, "BottomLeft");
				}
				return r_FBottomLeft;
			}
		}

		/// <summary>
		/// UnityEditor.SplitView+ViewEdge BottomRight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge r_FBottomRight;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge RFBottomRight
		{
			get
			{
				if(r_FBottomRight == null)
				{
					r_FBottomRight = new(Type, "BottomRight");
				}
				return r_FBottomRight;
			}
		}

		/// <summary>
		/// UnityEditor.SplitView+ViewEdge TopLeft
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge r_FTopLeft;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge RFTopLeft
		{
			get
			{
				if(r_FTopLeft == null)
				{
					r_FTopLeft = new(Type, "TopLeft");
				}
				return r_FTopLeft;
			}
		}

		/// <summary>
		/// UnityEditor.SplitView+ViewEdge TopRight
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge r_FTopRight;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge RFTopRight
		{
			get
			{
				if(r_FTopRight == null)
				{
					r_FTopRight = new(Type, "TopRight");
				}
				return r_FTopRight;
			}
		}

		/// <summary>
		/// UnityEditor.SplitView+ViewEdge FitsVertical
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge r_FFitsVertical;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge RFFitsVertical
		{
			get
			{
				if(r_FFitsVertical == null)
				{
					r_FFitsVertical = new(Type, "FitsVertical");
				}
				return r_FFitsVertical;
			}
		}

		/// <summary>
		/// UnityEditor.SplitView+ViewEdge FitsHorizontal
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge r_FFitsHorizontal;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge RFFitsHorizontal
		{
			get
			{
				if(r_FFitsHorizontal == null)
				{
					r_FFitsHorizontal = new(Type, "FitsHorizontal");
				}
				return r_FFitsHorizontal;
			}
		}

		/// <summary>
		/// UnityEditor.SplitView+ViewEdge Before
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge r_FBefore;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge RFBefore
		{
			get
			{
				if(r_FBefore == null)
				{
					r_FBefore = new(Type, "Before");
				}
				return r_FBefore;
			}
		}

		/// <summary>
		/// UnityEditor.SplitView+ViewEdge After
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge r_FAfter;
		public static Hvak.Editor.Refleaction.RUnityEditor.RSplitView.RViewEdge RFAfter
		{
			get
			{
				if(r_FAfter == null)
				{
					r_FAfter = new(Type, "After");
				}
				return r_FAfter;
			}
		}

		/// <summary>
		/// System.Object GetValue()
		/// </summary>
		protected RMethod r_MGetValue;
		public virtual RMethod RMGetValue
		{
			get
			{
				if(r_MGetValue == null)
				{
					r_MGetValue = new(this, "GetValue", 0);
				}
				return r_MGetValue;
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
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_String_IFormatProvider;
		public virtual RMethod RMToString_String_IFormatProvider
		{
			get
			{
				if(r_MToString_String_IFormatProvider == null)
				{
					r_MToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
				}
				return r_MToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_MToString_String;
		public virtual RMethod RMToString_String
		{
			get
			{
				if(r_MToString_String == null)
				{
					r_MToString_String = new(this, "ToString", 0, typeof(System.String));
				}
				return r_MToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_IFormatProvider;
		public virtual RMethod RMToString_IFormatProvider
		{
			get
			{
				if(r_MToString_IFormatProvider == null)
				{
					r_MToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
				}
				return r_MToString_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean HasFlag(System.Enum)
		/// </summary>
		protected RMethod r_MHasFlag_Enum;
		public virtual RMethod RMHasFlag_Enum
		{
			get
			{
				if(r_MHasFlag_Enum == null)
				{
					r_MHasFlag_Enum = new(this, "HasFlag", 0, typeof(System.Enum));
				}
				return r_MHasFlag_Enum;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_MGetTypeCode;
		public virtual RMethod RMGetTypeCode
		{
			get
			{
				if(r_MGetTypeCode == null)
				{
					r_MGetTypeCode = new(this, "GetTypeCode", 0);
				}
				return r_MGetTypeCode;
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


        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
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


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.TypeCode>(___result);
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
}