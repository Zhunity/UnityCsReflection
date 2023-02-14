
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.VisualData
	/// </summary>
    public partial class RVisualData : RMember //
    {

		/// <summary>
		/// UnityEngine.Color backgroundColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_FbackgroundColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFbackgroundColor
		{
			get
			{
				if(r_FbackgroundColor == null)
				{
					r_FbackgroundColor = new(this, "backgroundColor");
					r_FbackgroundColor.SetBelong(this.instance);
				}
				return r_FbackgroundColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Background backgroundImage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackground r_FbackgroundImage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackground RFbackgroundImage
		{
			get
			{
				if(r_FbackgroundImage == null)
				{
					r_FbackgroundImage = new(this, "backgroundImage");
					r_FbackgroundImage.SetBelong(this.instance);
				}
				return r_FbackgroundImage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition backgroundPositionX
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundPosition r_FbackgroundPositionX;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundPosition RFbackgroundPositionX
		{
			get
			{
				if(r_FbackgroundPositionX == null)
				{
					r_FbackgroundPositionX = new(this, "backgroundPositionX");
					r_FbackgroundPositionX.SetBelong(this.instance);
				}
				return r_FbackgroundPositionX;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition backgroundPositionY
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundPosition r_FbackgroundPositionY;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundPosition RFbackgroundPositionY
		{
			get
			{
				if(r_FbackgroundPositionY == null)
				{
					r_FbackgroundPositionY = new(this, "backgroundPositionY");
					r_FbackgroundPositionY.SetBelong(this.instance);
				}
				return r_FbackgroundPositionY;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundRepeat backgroundRepeat
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundRepeat r_FbackgroundRepeat;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundRepeat RFbackgroundRepeat
		{
			get
			{
				if(r_FbackgroundRepeat == null)
				{
					r_FbackgroundRepeat = new(this, "backgroundRepeat");
					r_FbackgroundRepeat.SetBelong(this.instance);
				}
				return r_FbackgroundRepeat;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundSize backgroundSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundSize r_FbackgroundSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundSize RFbackgroundSize
		{
			get
			{
				if(r_FbackgroundSize == null)
				{
					r_FbackgroundSize = new(this, "backgroundSize");
					r_FbackgroundSize.SetBelong(this.instance);
				}
				return r_FbackgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.Color borderBottomColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_FborderBottomColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFborderBottomColor
		{
			get
			{
				if(r_FborderBottomColor == null)
				{
					r_FborderBottomColor = new(this, "borderBottomColor");
					r_FborderBottomColor.SetBelong(this.instance);
				}
				return r_FborderBottomColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length borderBottomLeftRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FborderBottomLeftRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFborderBottomLeftRadius
		{
			get
			{
				if(r_FborderBottomLeftRadius == null)
				{
					r_FborderBottomLeftRadius = new(this, "borderBottomLeftRadius");
					r_FborderBottomLeftRadius.SetBelong(this.instance);
				}
				return r_FborderBottomLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length borderBottomRightRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FborderBottomRightRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFborderBottomRightRadius
		{
			get
			{
				if(r_FborderBottomRightRadius == null)
				{
					r_FborderBottomRightRadius = new(this, "borderBottomRightRadius");
					r_FborderBottomRightRadius.SetBelong(this.instance);
				}
				return r_FborderBottomRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Color borderLeftColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_FborderLeftColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFborderLeftColor
		{
			get
			{
				if(r_FborderLeftColor == null)
				{
					r_FborderLeftColor = new(this, "borderLeftColor");
					r_FborderLeftColor.SetBelong(this.instance);
				}
				return r_FborderLeftColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color borderRightColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_FborderRightColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFborderRightColor
		{
			get
			{
				if(r_FborderRightColor == null)
				{
					r_FborderRightColor = new(this, "borderRightColor");
					r_FborderRightColor.SetBelong(this.instance);
				}
				return r_FborderRightColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color borderTopColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_FborderTopColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RFborderTopColor
		{
			get
			{
				if(r_FborderTopColor == null)
				{
					r_FborderTopColor = new(this, "borderTopColor");
					r_FborderTopColor.SetBelong(this.instance);
				}
				return r_FborderTopColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length borderTopLeftRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FborderTopLeftRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFborderTopLeftRadius
		{
			get
			{
				if(r_FborderTopLeftRadius == null)
				{
					r_FborderTopLeftRadius = new(this, "borderTopLeftRadius");
					r_FborderTopLeftRadius.SetBelong(this.instance);
				}
				return r_FborderTopLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length borderTopRightRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_FborderTopRightRadius;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFborderTopRightRadius
		{
			get
			{
				if(r_FborderTopRightRadius == null)
				{
					r_FborderTopRightRadius = new(this, "borderTopRightRadius");
					r_FborderTopRightRadius.SetBelong(this.instance);
				}
				return r_FborderTopRightRadius;
			}
		}

		/// <summary>
		/// System.Single opacity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fopacity;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFopacity
		{
			get
			{
				if(r_Fopacity == null)
				{
					r_Fopacity = new(this, "opacity");
					r_Fopacity.SetBelong(this.instance);
				}
				return r_Fopacity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.OverflowInternal overflow
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.ROverflowInternal r_Foverflow;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.ROverflowInternal RFoverflow
		{
			get
			{
				if(r_Foverflow == null)
				{
					r_Foverflow = new(this, "overflow");
					r_Foverflow.SetBelong(this.instance);
				}
				return r_Foverflow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualData Copy()
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
		/// Void CopyFrom(UnityEngine.UIElements.VisualData ByRef)
		/// </summary>
		protected RMethod r_MCopyFrom_Ref_VisualData;
		public virtual RMethod RMCopyFrom_Ref_VisualData
		{
			get
			{
				if(r_MCopyFrom_Ref_VisualData == null)
				{
					r_MCopyFrom_Ref_VisualData = new(this, "CopyFrom", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualData").MakeByRefType());
					r_MCopyFrom_Ref_VisualData.SetBelong(this.instance);
				}
				return r_MCopyFrom_Ref_VisualData;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.VisualData, UnityEngine.UIElements.VisualData)
		/// </summary>
		protected static RMethod r_Mop_Equality_VisualData_VisualData;
		public static RMethod RMop_Equality_VisualData_VisualData
		{
			get
			{
				if(r_Mop_Equality_VisualData_VisualData == null)
				{
					r_Mop_Equality_VisualData_VisualData = new( ReflectionUtils.GetType("UnityEngine.UIElements.VisualData"), "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualData"),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualData"));
					r_Mop_Equality_VisualData_VisualData.SetBelong(null);
				}
				return r_Mop_Equality_VisualData_VisualData;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.VisualData, UnityEngine.UIElements.VisualData)
		/// </summary>
		protected static RMethod r_Mop_Inequality_VisualData_VisualData;
		public static RMethod RMop_Inequality_VisualData_VisualData
		{
			get
			{
				if(r_Mop_Inequality_VisualData_VisualData == null)
				{
					r_Mop_Inequality_VisualData_VisualData = new( ReflectionUtils.GetType("UnityEngine.UIElements.VisualData"), "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualData"),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualData"));
					r_Mop_Inequality_VisualData_VisualData.SetBelong(null);
				}
				return r_Mop_Inequality_VisualData_VisualData;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.VisualData)
		/// </summary>
		protected RMethod r_MEquals_VisualData;
		public virtual RMethod RMEquals_VisualData
		{
			get
			{
				if(r_MEquals_VisualData == null)
				{
					r_MEquals_VisualData = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualData"));
					r_MEquals_VisualData.SetBelong(this.instance);
				}
				return r_MEquals_VisualData;
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


        public RVisualData() : base("UnityEngine.UIElements.VisualData")
        {
        }

        public RVisualData(System.Object instance) : base("UnityEngine.UIElements.VisualData")
		{
            SetInstance(instance);
		}

        public RVisualData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVisualData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualData Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualData(___result);
        }


        public virtual void CopyFrom(ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualData @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMCopyFrom_Ref_VisualData.Invoke(___genericsType, ___parameters);
			@other = new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualData(___parameters[0]);

            
        }


        public static System.Boolean op_Equality(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualData @lhs, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualData @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Equality_VisualData_VisualData.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualData @lhs, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualData @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Inequality_VisualData_VisualData.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualData @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_VisualData.Invoke(___genericsType, ___parameters);

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
