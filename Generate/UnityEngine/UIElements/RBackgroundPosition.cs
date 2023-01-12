using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.BackgroundPosition
	/// </summary>
    public partial class RBackgroundPosition : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPositionKeyword keyword
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundPositionKeyword r_Fkeyword;
		public virtual RUnityEngine.RUIElements.RBackgroundPositionKeyword RFkeyword
		{
			get
			{
				if(r_Fkeyword == null)
				{
					r_Fkeyword = new(this, "keyword");
					r_Fkeyword.SetBelong(this.instance);
				}
				return r_Fkeyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length offset
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_Foffset;
		public virtual RUnityEngine.RUIElements.RLength RFoffset
		{
			get
			{
				if(r_Foffset == null)
				{
					r_Foffset = new(this, "offset");
					r_Foffset.SetBelong(this.instance);
				}
				return r_Foffset;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition Initial()
		/// </summary>
		protected static RMethod r_MInitial;
		public static RMethod RMInitial
		{
			get
			{
				if(r_MInitial == null)
				{
					r_MInitial = new(typeof(UnityEngine.UIElements.BackgroundPosition), "Initial", 0);
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
		/// Boolean Equals(UnityEngine.UIElements.BackgroundPosition)
		/// </summary>
		protected RMethod r_MEquals_BackgroundPosition;
		public virtual RMethod RMEquals_BackgroundPosition
		{
			get
			{
				if(r_MEquals_BackgroundPosition == null)
				{
					r_MEquals_BackgroundPosition = new(this, "Equals", 0, typeof(UnityEngine.UIElements.BackgroundPosition));
					r_MEquals_BackgroundPosition.SetBelong(this.instance);
				}
				return r_MEquals_BackgroundPosition;
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
		/// Boolean op_Equality(UnityEngine.UIElements.BackgroundPosition, UnityEngine.UIElements.BackgroundPosition)
		/// </summary>
		protected static RMethod r_Mop_Equality_BackgroundPosition_BackgroundPosition;
		public static RMethod RMop_Equality_BackgroundPosition_BackgroundPosition
		{
			get
			{
				if(r_Mop_Equality_BackgroundPosition_BackgroundPosition == null)
				{
					r_Mop_Equality_BackgroundPosition_BackgroundPosition = new(typeof(UnityEngine.UIElements.BackgroundPosition), "op_Equality", 0, typeof(UnityEngine.UIElements.BackgroundPosition), typeof(UnityEngine.UIElements.BackgroundPosition));
					r_Mop_Equality_BackgroundPosition_BackgroundPosition.SetBelong(null);
				}
				return r_Mop_Equality_BackgroundPosition_BackgroundPosition;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.BackgroundPosition, UnityEngine.UIElements.BackgroundPosition)
		/// </summary>
		protected static RMethod r_Mop_Inequality_BackgroundPosition_BackgroundPosition;
		public static RMethod RMop_Inequality_BackgroundPosition_BackgroundPosition
		{
			get
			{
				if(r_Mop_Inequality_BackgroundPosition_BackgroundPosition == null)
				{
					r_Mop_Inequality_BackgroundPosition_BackgroundPosition = new(typeof(UnityEngine.UIElements.BackgroundPosition), "op_Inequality", 0, typeof(UnityEngine.UIElements.BackgroundPosition), typeof(UnityEngine.UIElements.BackgroundPosition));
					r_Mop_Inequality_BackgroundPosition_BackgroundPosition.SetBelong(null);
				}
				return r_Mop_Inequality_BackgroundPosition_BackgroundPosition;
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


        public RBackgroundPosition() : base("UnityEngine.UIElements.BackgroundPosition")
        {
        }

        public RBackgroundPosition(System.Object instance) : base("UnityEngine.UIElements.BackgroundPosition")
		{
            SetInstance(instance);
		}

        public RBackgroundPosition(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBackgroundPosition(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.UIElements.BackgroundPosition Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundPosition)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.BackgroundPosition @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_BackgroundPosition.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.BackgroundPosition @style1, UnityEngine.UIElements.BackgroundPosition @style2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style1, @style2};
            var ___result = RMop_Equality_BackgroundPosition_BackgroundPosition.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.BackgroundPosition @style1, UnityEngine.UIElements.BackgroundPosition @style2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style1, @style2};
            var ___result = RMop_Inequality_BackgroundPosition_BackgroundPosition.Invoke(___genericsType, ___parameters);

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
