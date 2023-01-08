using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.VisualData
	/// </summary>
    public partial class RVisualData : RMember //
    {

		/// <summary>
		/// UnityEngine.Color backgroundColor
		/// </summary>
		protected RUnityEngine.RColor r_backgroundColor;
		public virtual RUnityEngine.RColor RbackgroundColor
		{
			get
			{
				if(r_backgroundColor == null)
				{
					r_backgroundColor = new(this, "backgroundColor");
					r_backgroundColor.SetBelong(this.instance);
				}
				return r_backgroundColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Background backgroundImage
		/// </summary>
		protected RUnityEngine.RUIElements.RBackground r_backgroundImage;
		public virtual RUnityEngine.RUIElements.RBackground RbackgroundImage
		{
			get
			{
				if(r_backgroundImage == null)
				{
					r_backgroundImage = new(this, "backgroundImage");
					r_backgroundImage.SetBelong(this.instance);
				}
				return r_backgroundImage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition backgroundPositionX
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundPosition r_backgroundPositionX;
		public virtual RUnityEngine.RUIElements.RBackgroundPosition RbackgroundPositionX
		{
			get
			{
				if(r_backgroundPositionX == null)
				{
					r_backgroundPositionX = new(this, "backgroundPositionX");
					r_backgroundPositionX.SetBelong(this.instance);
				}
				return r_backgroundPositionX;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition backgroundPositionY
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundPosition r_backgroundPositionY;
		public virtual RUnityEngine.RUIElements.RBackgroundPosition RbackgroundPositionY
		{
			get
			{
				if(r_backgroundPositionY == null)
				{
					r_backgroundPositionY = new(this, "backgroundPositionY");
					r_backgroundPositionY.SetBelong(this.instance);
				}
				return r_backgroundPositionY;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundRepeat backgroundRepeat
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundRepeat r_backgroundRepeat;
		public virtual RUnityEngine.RUIElements.RBackgroundRepeat RbackgroundRepeat
		{
			get
			{
				if(r_backgroundRepeat == null)
				{
					r_backgroundRepeat = new(this, "backgroundRepeat");
					r_backgroundRepeat.SetBelong(this.instance);
				}
				return r_backgroundRepeat;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundSize backgroundSize
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundSize r_backgroundSize;
		public virtual RUnityEngine.RUIElements.RBackgroundSize RbackgroundSize
		{
			get
			{
				if(r_backgroundSize == null)
				{
					r_backgroundSize = new(this, "backgroundSize");
					r_backgroundSize.SetBelong(this.instance);
				}
				return r_backgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.Color borderBottomColor
		/// </summary>
		protected RUnityEngine.RColor r_borderBottomColor;
		public virtual RUnityEngine.RColor RborderBottomColor
		{
			get
			{
				if(r_borderBottomColor == null)
				{
					r_borderBottomColor = new(this, "borderBottomColor");
					r_borderBottomColor.SetBelong(this.instance);
				}
				return r_borderBottomColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length borderBottomLeftRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_borderBottomLeftRadius;
		public virtual RUnityEngine.RUIElements.RLength RborderBottomLeftRadius
		{
			get
			{
				if(r_borderBottomLeftRadius == null)
				{
					r_borderBottomLeftRadius = new(this, "borderBottomLeftRadius");
					r_borderBottomLeftRadius.SetBelong(this.instance);
				}
				return r_borderBottomLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length borderBottomRightRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_borderBottomRightRadius;
		public virtual RUnityEngine.RUIElements.RLength RborderBottomRightRadius
		{
			get
			{
				if(r_borderBottomRightRadius == null)
				{
					r_borderBottomRightRadius = new(this, "borderBottomRightRadius");
					r_borderBottomRightRadius.SetBelong(this.instance);
				}
				return r_borderBottomRightRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Color borderLeftColor
		/// </summary>
		protected RUnityEngine.RColor r_borderLeftColor;
		public virtual RUnityEngine.RColor RborderLeftColor
		{
			get
			{
				if(r_borderLeftColor == null)
				{
					r_borderLeftColor = new(this, "borderLeftColor");
					r_borderLeftColor.SetBelong(this.instance);
				}
				return r_borderLeftColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color borderRightColor
		/// </summary>
		protected RUnityEngine.RColor r_borderRightColor;
		public virtual RUnityEngine.RColor RborderRightColor
		{
			get
			{
				if(r_borderRightColor == null)
				{
					r_borderRightColor = new(this, "borderRightColor");
					r_borderRightColor.SetBelong(this.instance);
				}
				return r_borderRightColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color borderTopColor
		/// </summary>
		protected RUnityEngine.RColor r_borderTopColor;
		public virtual RUnityEngine.RColor RborderTopColor
		{
			get
			{
				if(r_borderTopColor == null)
				{
					r_borderTopColor = new(this, "borderTopColor");
					r_borderTopColor.SetBelong(this.instance);
				}
				return r_borderTopColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length borderTopLeftRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_borderTopLeftRadius;
		public virtual RUnityEngine.RUIElements.RLength RborderTopLeftRadius
		{
			get
			{
				if(r_borderTopLeftRadius == null)
				{
					r_borderTopLeftRadius = new(this, "borderTopLeftRadius");
					r_borderTopLeftRadius.SetBelong(this.instance);
				}
				return r_borderTopLeftRadius;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length borderTopRightRadius
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_borderTopRightRadius;
		public virtual RUnityEngine.RUIElements.RLength RborderTopRightRadius
		{
			get
			{
				if(r_borderTopRightRadius == null)
				{
					r_borderTopRightRadius = new(this, "borderTopRightRadius");
					r_borderTopRightRadius.SetBelong(this.instance);
				}
				return r_borderTopRightRadius;
			}
		}

		/// <summary>
		/// System.Single opacity
		/// </summary>
		protected RField r_opacity;
		public virtual RField Ropacity
		{
			get
			{
				if(r_opacity == null)
				{
					r_opacity = new(this, "opacity");
					r_opacity.SetBelong(this.instance);
				}
				return r_opacity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.OverflowInternal overflow
		/// </summary>
		protected RField r_overflow;
		public virtual RField Roverflow
		{
			get
			{
				if(r_overflow == null)
				{
					r_overflow = new(this, "overflow");
					r_overflow.SetBelong(this.instance);
				}
				return r_overflow;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualData Copy()
		/// </summary>
		protected RMethod r_Copy;
		public virtual RMethod RCopy
		{
			get
			{
				if(r_Copy == null)
				{
					r_Copy = new(this, "Copy", 0);
					r_Copy.SetBelong(this.instance);
				}
				return r_Copy;
			}
		}

		/// <summary>
		/// Void CopyFrom(UnityEngine.UIElements.VisualData ByRef)
		/// </summary>
		protected RMethod r_CopyFrom_Ref_VisualData;
		public virtual RMethod RCopyFrom_Ref_VisualData
		{
			get
			{
				if(r_CopyFrom_Ref_VisualData == null)
				{
					r_CopyFrom_Ref_VisualData = new(this, "CopyFrom", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualData").MakeByRefType());
					r_CopyFrom_Ref_VisualData.SetBelong(this.instance);
				}
				return r_CopyFrom_Ref_VisualData;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.VisualData, UnityEngine.UIElements.VisualData)
		/// </summary>
		protected static RMethod r_op_Equality_VisualData_VisualData;
		public static RMethod Rop_Equality_VisualData_VisualData
		{
			get
			{
				if(r_op_Equality_VisualData_VisualData == null)
				{
					r_op_Equality_VisualData_VisualData = new( ReflectionUtils.GetType("UnityEngine.UIElements.VisualData"), "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualData"),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualData"));
					r_op_Equality_VisualData_VisualData.SetBelong(null);
				}
				return r_op_Equality_VisualData_VisualData;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.VisualData, UnityEngine.UIElements.VisualData)
		/// </summary>
		protected static RMethod r_op_Inequality_VisualData_VisualData;
		public static RMethod Rop_Inequality_VisualData_VisualData
		{
			get
			{
				if(r_op_Inequality_VisualData_VisualData == null)
				{
					r_op_Inequality_VisualData_VisualData = new( ReflectionUtils.GetType("UnityEngine.UIElements.VisualData"), "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualData"),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualData"));
					r_op_Inequality_VisualData_VisualData.SetBelong(null);
				}
				return r_op_Inequality_VisualData_VisualData;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.VisualData)
		/// </summary>
		protected RMethod r_Equals_VisualData;
		public virtual RMethod REquals_VisualData
		{
			get
			{
				if(r_Equals_VisualData == null)
				{
					r_Equals_VisualData = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualData"));
					r_Equals_VisualData.SetBelong(this.instance);
				}
				return r_Equals_VisualData;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
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
