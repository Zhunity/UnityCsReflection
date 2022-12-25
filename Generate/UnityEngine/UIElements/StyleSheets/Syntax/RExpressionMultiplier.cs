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
					r_Infinity = new( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier"), "Infinity");
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
		protected RMethod r_RSetType_ExpressionMultiplierType;
		public virtual RMethod RSetType_ExpressionMultiplierType
		{
			get
			{
				if(r_RSetType_ExpressionMultiplierType == null)
				{
					r_RSetType_ExpressionMultiplierType = new(this, "SetType", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType"));
					r_RSetType_ExpressionMultiplierType.SetBelong(this.instance);
				}
				return r_RSetType_ExpressionMultiplierType;
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
