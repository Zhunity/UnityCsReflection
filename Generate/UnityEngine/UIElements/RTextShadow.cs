using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.TextShadow
	/// </summary>
    public partial class RTextShadow : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector2 offset
		/// </summary>
		protected RUnityEngine.RVector2 r_offset;
		public virtual RUnityEngine.RVector2 Roffset
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
		/// System.Single blurRadius
		/// </summary>
		protected RField r_blurRadius;
		public virtual RField RblurRadius
		{
			get
			{
				if(r_blurRadius == null)
				{
					r_blurRadius = new(this, "blurRadius");
					r_blurRadius.SetBelong(this.instance);
				}
				return r_blurRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Color color
		/// </summary>
		protected RUnityEngine.RColor r_color;
		public virtual RUnityEngine.RColor Rcolor
		{
			get
			{
				if(r_color == null)
				{
					r_color = new(this, "color");
					r_color.SetBelong(this.instance);
				}
				return r_color;
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
		/// Boolean Equals(UnityEngine.UIElements.TextShadow)
		/// </summary>
		protected RMethod r_REquals_TextShadow;
		public virtual RMethod REquals_TextShadow
		{
			get
			{
				if(r_REquals_TextShadow == null)
				{
					r_REquals_TextShadow = new(this, "Equals", 0, typeof(UnityEngine.UIElements.TextShadow));
					r_REquals_TextShadow.SetBelong(this.instance);
				}
				return r_REquals_TextShadow;
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
		/// Boolean op_Equality(UnityEngine.UIElements.TextShadow, UnityEngine.UIElements.TextShadow)
		/// </summary>
		protected static RMethod r_Rop_Equality_TextShadow_TextShadow;
		public static RMethod Rop_Equality_TextShadow_TextShadow
		{
			get
			{
				if(r_Rop_Equality_TextShadow_TextShadow == null)
				{
					r_Rop_Equality_TextShadow_TextShadow = new(typeof(UnityEngine.UIElements.TextShadow), "op_Equality", 0, typeof(UnityEngine.UIElements.TextShadow), typeof(UnityEngine.UIElements.TextShadow));
					r_Rop_Equality_TextShadow_TextShadow.SetBelong(null);
				}
				return r_Rop_Equality_TextShadow_TextShadow;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.TextShadow, UnityEngine.UIElements.TextShadow)
		/// </summary>
		protected static RMethod r_Rop_Inequality_TextShadow_TextShadow;
		public static RMethod Rop_Inequality_TextShadow_TextShadow
		{
			get
			{
				if(r_Rop_Inequality_TextShadow_TextShadow == null)
				{
					r_Rop_Inequality_TextShadow_TextShadow = new(typeof(UnityEngine.UIElements.TextShadow), "op_Inequality", 0, typeof(UnityEngine.UIElements.TextShadow), typeof(UnityEngine.UIElements.TextShadow));
					r_Rop_Inequality_TextShadow_TextShadow.SetBelong(null);
				}
				return r_Rop_Inequality_TextShadow_TextShadow;
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
		/// UnityEngine.UIElements.TextShadow LerpUnclamped(UnityEngine.UIElements.TextShadow, UnityEngine.UIElements.TextShadow, Single)
		/// </summary>
		protected static RMethod r_RLerpUnclamped_TextShadow_TextShadow_Single;
		public static RMethod RLerpUnclamped_TextShadow_TextShadow_Single
		{
			get
			{
				if(r_RLerpUnclamped_TextShadow_TextShadow_Single == null)
				{
					r_RLerpUnclamped_TextShadow_TextShadow_Single = new(typeof(UnityEngine.UIElements.TextShadow), "LerpUnclamped", 0, typeof(UnityEngine.UIElements.TextShadow), typeof(UnityEngine.UIElements.TextShadow), typeof(System.Single));
					r_RLerpUnclamped_TextShadow_TextShadow_Single.SetBelong(null);
				}
				return r_RLerpUnclamped_TextShadow_TextShadow_Single;
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


        public RTextShadow() : base("UnityEngine.UIElements.TextShadow")
        {
        }

        public RTextShadow(System.Object instance) : base("UnityEngine.UIElements.TextShadow")
		{
            SetInstance(instance);
		}

        public RTextShadow(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextShadow(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.TextShadow  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_TextShadow.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.TextShadow  @style1, UnityEngine.UIElements.TextShadow  @style2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style1, @style2};
            var ___result = Rop_Equality_TextShadow_TextShadow.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.TextShadow  @style1, UnityEngine.UIElements.TextShadow  @style2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style1, @style2};
            var ___result = Rop_Inequality_TextShadow_TextShadow.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static UnityEngine.UIElements.TextShadow LerpUnclamped(UnityEngine.UIElements.TextShadow  @a, UnityEngine.UIElements.TextShadow  @b, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RLerpUnclamped_TextShadow_TextShadow_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TextShadow)___result;
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
