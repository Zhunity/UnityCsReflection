using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax
{
	/// <summary>
	/// UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier
	/// </summary>
    public partial class RExpressionMultiplier : RMember //
    {

		/// <summary>
		/// System.Int32 Infinity
		/// </summary>
		protected static RField r_Infinity;
		public static RField RInfinity
		{
			get
			{
				if(r_Infinity == null)
				{
					r_Infinity = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier"), "Infinity");
					r_Infinity.SetBelong(null);
				}
				return r_Infinity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType m_Type
		/// </summary>
		protected RField r_m_Type;
		public virtual RField Rm_Type
		{
			get
			{
				if(r_m_Type == null)
				{
					r_m_Type = new(this, "m_Type");
					r_m_Type.SetBelong(this.instance);
				}
				return r_m_Type;
			}
		}

		/// <summary>
		/// System.Int32 min
		/// </summary>
		protected RField r_min;
		public virtual RField Rmin
		{
			get
			{
				if(r_min == null)
				{
					r_min = new(this, "min");
					r_min.SetBelong(this.instance);
				}
				return r_min;
			}
		}

		/// <summary>
		/// System.Int32 max
		/// </summary>
		protected RField r_max;
		public virtual RField Rmax
		{
			get
			{
				if(r_max == null)
				{
					r_max = new(this, "max");
					r_max.SetBelong(this.instance);
				}
				return r_max;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType type
		/// </summary>
		protected RProperty r_type;
		public virtual RProperty Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type", -1);
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// Void SetType(UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType)
		/// </summary>
		protected RMethod r_SetType_ExpressionMultiplierType;
		public virtual RMethod RSetType_ExpressionMultiplierType
		{
			get
			{
				if(r_SetType_ExpressionMultiplierType == null)
				{
					r_SetType_ExpressionMultiplierType = new(this, "SetType", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType"));
					r_SetType_ExpressionMultiplierType.SetBelong(this.instance);
				}
				return r_SetType_ExpressionMultiplierType;
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


        public RExpressionMultiplier() : base("UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier")
        {
        }

        public RExpressionMultiplier(System.Object instance) : base("UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier")
		{
            SetInstance(instance);
		}

        public RExpressionMultiplier(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RExpressionMultiplier(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetType(RType @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RSetType_ExpressionMultiplierType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
