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
		protected RField r_keyword;
		public virtual RField Rkeyword
		{
			get
			{
				if(r_keyword == null)
				{
					r_keyword = new(this, "keyword");
					r_keyword.SetBelong(this.instance);
				}
				return r_keyword;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length offset
		/// </summary>
		protected RUnityEngine.RUIElements.RLength r_offset;
		public virtual RUnityEngine.RUIElements.RLength Roffset
		{
			get
			{
				if(r_offset == null)
				{
					r_offset = new(this, "offset");
					r_offset.SetBelong(this.instance);
				}
				return r_offset;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition Initial()
		/// </summary>
		protected static RMethod r_Initial;
		public static RMethod RInitial
		{
			get
			{
				if(r_Initial == null)
				{
					r_Initial = new(typeof(UnityEngine.UIElements.BackgroundPosition), "Initial", 0);
					r_Initial.SetBelong(null);
				}
				return r_Initial;
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
		/// Boolean Equals(UnityEngine.UIElements.BackgroundPosition)
		/// </summary>
		protected RMethod r_Equals_BackgroundPosition;
		public virtual RMethod REquals_BackgroundPosition
		{
			get
			{
				if(r_Equals_BackgroundPosition == null)
				{
					r_Equals_BackgroundPosition = new(this, "Equals", 0, typeof(UnityEngine.UIElements.BackgroundPosition));
					r_Equals_BackgroundPosition.SetBelong(this.instance);
				}
				return r_Equals_BackgroundPosition;
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
		/// Boolean op_Equality(UnityEngine.UIElements.BackgroundPosition, UnityEngine.UIElements.BackgroundPosition)
		/// </summary>
		protected static RMethod r_op_Equality_BackgroundPosition_BackgroundPosition;
		public static RMethod Rop_Equality_BackgroundPosition_BackgroundPosition
		{
			get
			{
				if(r_op_Equality_BackgroundPosition_BackgroundPosition == null)
				{
					r_op_Equality_BackgroundPosition_BackgroundPosition = new(typeof(UnityEngine.UIElements.BackgroundPosition), "op_Equality", 0, typeof(UnityEngine.UIElements.BackgroundPosition), typeof(UnityEngine.UIElements.BackgroundPosition));
					r_op_Equality_BackgroundPosition_BackgroundPosition.SetBelong(null);
				}
				return r_op_Equality_BackgroundPosition_BackgroundPosition;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.BackgroundPosition, UnityEngine.UIElements.BackgroundPosition)
		/// </summary>
		protected static RMethod r_op_Inequality_BackgroundPosition_BackgroundPosition;
		public static RMethod Rop_Inequality_BackgroundPosition_BackgroundPosition
		{
			get
			{
				if(r_op_Inequality_BackgroundPosition_BackgroundPosition == null)
				{
					r_op_Inequality_BackgroundPosition_BackgroundPosition = new(typeof(UnityEngine.UIElements.BackgroundPosition), "op_Inequality", 0, typeof(UnityEngine.UIElements.BackgroundPosition), typeof(UnityEngine.UIElements.BackgroundPosition));
					r_op_Inequality_BackgroundPosition_BackgroundPosition.SetBelong(null);
				}
				return r_op_Inequality_BackgroundPosition_BackgroundPosition;
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
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundPosition)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.BackgroundPosition @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_BackgroundPosition.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.BackgroundPosition @style1, UnityEngine.UIElements.BackgroundPosition @style2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style1, @style2};
            var ___result = Rop_Equality_BackgroundPosition_BackgroundPosition.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.BackgroundPosition @style1, UnityEngine.UIElements.BackgroundPosition @style2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style1, @style2};
            var ___result = Rop_Inequality_BackgroundPosition_BackgroundPosition.Invoke(___genericsType, ___parameters);

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
