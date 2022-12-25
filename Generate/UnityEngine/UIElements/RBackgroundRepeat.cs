using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.BackgroundRepeat
	/// </summary>
    public partial class RBackgroundRepeat : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.Repeat x
		/// </summary>
		protected RField r_x;
		public virtual RField Rx
		{
			get
			{
				if(r_x == null)
				{
					r_x = new(this, "x");
					r_x.SetBelong(this.instance);
				}
				return r_x;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Repeat y
		/// </summary>
		protected RField r_y;
		public virtual RField Ry
		{
			get
			{
				if(r_y == null)
				{
					r_y = new(this, "y");
					r_y.SetBelong(this.instance);
				}
				return r_y;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundRepeat Initial()
		/// </summary>
		protected static RMethod r_RInitial;
		public static RMethod RInitial
		{
			get
			{
				if(r_RInitial == null)
				{
					r_RInitial = new(typeof(UnityEngine.UIElements.BackgroundRepeat), "Initial", 0);
					r_RInitial.SetBelong(null);
				}
				return r_RInitial;
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
		/// Boolean Equals(UnityEngine.UIElements.BackgroundRepeat)
		/// </summary>
		protected RMethod r_REquals_BackgroundRepeat;
		public virtual RMethod REquals_BackgroundRepeat
		{
			get
			{
				if(r_REquals_BackgroundRepeat == null)
				{
					r_REquals_BackgroundRepeat = new(this, "Equals", 0, typeof(UnityEngine.UIElements.BackgroundRepeat));
					r_REquals_BackgroundRepeat.SetBelong(this.instance);
				}
				return r_REquals_BackgroundRepeat;
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
		/// Boolean op_Equality(UnityEngine.UIElements.BackgroundRepeat, UnityEngine.UIElements.BackgroundRepeat)
		/// </summary>
		protected static RMethod r_Rop_Equality_BackgroundRepeat_BackgroundRepeat;
		public static RMethod Rop_Equality_BackgroundRepeat_BackgroundRepeat
		{
			get
			{
				if(r_Rop_Equality_BackgroundRepeat_BackgroundRepeat == null)
				{
					r_Rop_Equality_BackgroundRepeat_BackgroundRepeat = new(typeof(UnityEngine.UIElements.BackgroundRepeat), "op_Equality", 0, typeof(UnityEngine.UIElements.BackgroundRepeat), typeof(UnityEngine.UIElements.BackgroundRepeat));
					r_Rop_Equality_BackgroundRepeat_BackgroundRepeat.SetBelong(null);
				}
				return r_Rop_Equality_BackgroundRepeat_BackgroundRepeat;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.BackgroundRepeat, UnityEngine.UIElements.BackgroundRepeat)
		/// </summary>
		protected static RMethod r_Rop_Inequality_BackgroundRepeat_BackgroundRepeat;
		public static RMethod Rop_Inequality_BackgroundRepeat_BackgroundRepeat
		{
			get
			{
				if(r_Rop_Inequality_BackgroundRepeat_BackgroundRepeat == null)
				{
					r_Rop_Inequality_BackgroundRepeat_BackgroundRepeat = new(typeof(UnityEngine.UIElements.BackgroundRepeat), "op_Inequality", 0, typeof(UnityEngine.UIElements.BackgroundRepeat), typeof(UnityEngine.UIElements.BackgroundRepeat));
					r_Rop_Inequality_BackgroundRepeat_BackgroundRepeat.SetBelong(null);
				}
				return r_Rop_Inequality_BackgroundRepeat_BackgroundRepeat;
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
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundRepeat)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.BackgroundRepeat  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_BackgroundRepeat.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.BackgroundRepeat  @style1, UnityEngine.UIElements.BackgroundRepeat  @style2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style1, @style2};
            var ___result = Rop_Equality_BackgroundRepeat_BackgroundRepeat.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.BackgroundRepeat  @style1, UnityEngine.UIElements.BackgroundRepeat  @style2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style1, @style2};
            var ___result = Rop_Inequality_BackgroundRepeat_BackgroundRepeat.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
