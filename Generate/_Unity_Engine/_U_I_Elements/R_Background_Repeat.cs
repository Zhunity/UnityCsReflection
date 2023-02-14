
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.BackgroundRepeat
	/// </summary>
    public partial class RBackgroundRepeat : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.Repeat x
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRepeat r_Fx;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRepeat RFx
		{
			get
			{
				if(r_Fx == null)
				{
					r_Fx = new(this, "x");
					r_Fx.SetBelong(this.instance);
				}
				return r_Fx;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Repeat y
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRepeat r_Fy;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRepeat RFy
		{
			get
			{
				if(r_Fy == null)
				{
					r_Fy = new(this, "y");
					r_Fy.SetBelong(this.instance);
				}
				return r_Fy;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundRepeat Initial()
		/// </summary>
		protected static RMethod r_MInitial;
		public static RMethod RMInitial
		{
			get
			{
				if(r_MInitial == null)
				{
					r_MInitial = new(typeof(UnityEngine.UIElements.BackgroundRepeat), "Initial", 0);
					r_MInitial.SetBelong(null);
				}
				return r_MInitial;
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
		/// Boolean Equals(UnityEngine.UIElements.BackgroundRepeat)
		/// </summary>
		protected RMethod r_MEquals_BackgroundRepeat;
		public virtual RMethod RMEquals_BackgroundRepeat
		{
			get
			{
				if(r_MEquals_BackgroundRepeat == null)
				{
					r_MEquals_BackgroundRepeat = new(this, "Equals", 0, typeof(UnityEngine.UIElements.BackgroundRepeat));
					r_MEquals_BackgroundRepeat.SetBelong(this.instance);
				}
				return r_MEquals_BackgroundRepeat;
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
		/// Boolean op_Equality(UnityEngine.UIElements.BackgroundRepeat, UnityEngine.UIElements.BackgroundRepeat)
		/// </summary>
		protected static RMethod r_Mop_Equality_BackgroundRepeat_BackgroundRepeat;
		public static RMethod RMop_Equality_BackgroundRepeat_BackgroundRepeat
		{
			get
			{
				if(r_Mop_Equality_BackgroundRepeat_BackgroundRepeat == null)
				{
					r_Mop_Equality_BackgroundRepeat_BackgroundRepeat = new(typeof(UnityEngine.UIElements.BackgroundRepeat), "op_Equality", 0, typeof(UnityEngine.UIElements.BackgroundRepeat), typeof(UnityEngine.UIElements.BackgroundRepeat));
					r_Mop_Equality_BackgroundRepeat_BackgroundRepeat.SetBelong(null);
				}
				return r_Mop_Equality_BackgroundRepeat_BackgroundRepeat;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.BackgroundRepeat, UnityEngine.UIElements.BackgroundRepeat)
		/// </summary>
		protected static RMethod r_Mop_Inequality_BackgroundRepeat_BackgroundRepeat;
		public static RMethod RMop_Inequality_BackgroundRepeat_BackgroundRepeat
		{
			get
			{
				if(r_Mop_Inequality_BackgroundRepeat_BackgroundRepeat == null)
				{
					r_Mop_Inequality_BackgroundRepeat_BackgroundRepeat = new(typeof(UnityEngine.UIElements.BackgroundRepeat), "op_Inequality", 0, typeof(UnityEngine.UIElements.BackgroundRepeat), typeof(UnityEngine.UIElements.BackgroundRepeat));
					r_Mop_Inequality_BackgroundRepeat_BackgroundRepeat.SetBelong(null);
				}
				return r_Mop_Inequality_BackgroundRepeat_BackgroundRepeat;
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


        public RBackgroundRepeat() : base("UnityEngine.UIElements.BackgroundRepeat")
        {
        }

        public RBackgroundRepeat(System.Object instance) : base("UnityEngine.UIElements.BackgroundRepeat")
		{
            SetInstance(instance);
		}

        public RBackgroundRepeat(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBackgroundRepeat(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.UIElements.BackgroundRepeat Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundRepeat)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.BackgroundRepeat @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_BackgroundRepeat.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.BackgroundRepeat @style1, UnityEngine.UIElements.BackgroundRepeat @style2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style1, @style2};
            var ___result = RMop_Equality_BackgroundRepeat_BackgroundRepeat.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.BackgroundRepeat @style1, UnityEngine.UIElements.BackgroundRepeat @style2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style1, @style2};
            var ___result = RMop_Inequality_BackgroundRepeat_BackgroundRepeat.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
