
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax
{
	/// <summary>
	/// UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier
	/// </summary>
    public partial class RExpressionMultiplier : RMember //
    {

		/// <summary>
		/// System.Int32 Infinity
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FInfinity;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFInfinity
		{
			get
			{
				if(r_FInfinity == null)
				{
					r_FInfinity = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplier"), "Infinity");
					r_FInfinity.SetBelong(null);
				}
				return r_FInfinity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType m_Type
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpressionMultiplierType r_Fm_Type;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpressionMultiplierType RFm_Type
		{
			get
			{
				if(r_Fm_Type == null)
				{
					r_Fm_Type = new(this, "m_Type");
					r_Fm_Type.SetBelong(this.instance);
				}
				return r_Fm_Type;
			}
		}

		/// <summary>
		/// System.Int32 min
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fmin;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFmin
		{
			get
			{
				if(r_Fmin == null)
				{
					r_Fmin = new(this, "min");
					r_Fmin.SetBelong(this.instance);
				}
				return r_Fmin;
			}
		}

		/// <summary>
		/// System.Int32 max
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fmax;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFmax
		{
			get
			{
				if(r_Fmax == null)
				{
					r_Fmax = new(this, "max");
					r_Fmax.SetBelong(this.instance);
				}
				return r_Fmax;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType type
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpressionMultiplierType r_Ptype;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpressionMultiplierType RPtype
		{
			get
			{
				if(r_Ptype == null)
				{
					r_Ptype = new(this, "type", -1);
					r_Ptype.SetBelong(this.instance);
				}
				return r_Ptype;
			}
		}

		/// <summary>
		/// Void SetType(UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType)
		/// </summary>
		protected RMethod r_MSetType_ExpressionMultiplierType;
		public virtual RMethod RMSetType_ExpressionMultiplierType
		{
			get
			{
				if(r_MSetType_ExpressionMultiplierType == null)
				{
					r_MSetType_ExpressionMultiplierType = new(this, "SetType", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.Syntax.ExpressionMultiplierType"));
					r_MSetType_ExpressionMultiplierType.SetBelong(this.instance);
				}
				return r_MSetType_ExpressionMultiplierType;
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

        public virtual void SetType(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RSyntax.RExpressionMultiplierType @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RMSetType_ExpressionMultiplierType.Invoke(___genericsType, ___parameters);

            
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
