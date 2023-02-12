
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
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector2 r_Foffset;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector2 RFoffset
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
		/// System.Single blurRadius
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_FblurRadius;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RFblurRadius
		{
			get
			{
				if(r_FblurRadius == null)
				{
					r_FblurRadius = new(this, "blurRadius");
					r_FblurRadius.SetBelong(this.instance);
				}
				return r_FblurRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Color color
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RColor r_Fcolor;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RColor RFcolor
		{
			get
			{
				if(r_Fcolor == null)
				{
					r_Fcolor = new(this, "color");
					r_Fcolor.SetBelong(this.instance);
				}
				return r_Fcolor;
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
		/// Boolean Equals(UnityEngine.UIElements.TextShadow)
		/// </summary>
		protected RMethod r_MEquals_TextShadow;
		public virtual RMethod RMEquals_TextShadow
		{
			get
			{
				if(r_MEquals_TextShadow == null)
				{
					r_MEquals_TextShadow = new(this, "Equals", 0, typeof(UnityEngine.UIElements.TextShadow));
					r_MEquals_TextShadow.SetBelong(this.instance);
				}
				return r_MEquals_TextShadow;
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
		/// Boolean op_Equality(UnityEngine.UIElements.TextShadow, UnityEngine.UIElements.TextShadow)
		/// </summary>
		protected static RMethod r_Mop_Equality_TextShadow_TextShadow;
		public static RMethod RMop_Equality_TextShadow_TextShadow
		{
			get
			{
				if(r_Mop_Equality_TextShadow_TextShadow == null)
				{
					r_Mop_Equality_TextShadow_TextShadow = new(typeof(UnityEngine.UIElements.TextShadow), "op_Equality", 0, typeof(UnityEngine.UIElements.TextShadow), typeof(UnityEngine.UIElements.TextShadow));
					r_Mop_Equality_TextShadow_TextShadow.SetBelong(null);
				}
				return r_Mop_Equality_TextShadow_TextShadow;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.TextShadow, UnityEngine.UIElements.TextShadow)
		/// </summary>
		protected static RMethod r_Mop_Inequality_TextShadow_TextShadow;
		public static RMethod RMop_Inequality_TextShadow_TextShadow
		{
			get
			{
				if(r_Mop_Inequality_TextShadow_TextShadow == null)
				{
					r_Mop_Inequality_TextShadow_TextShadow = new(typeof(UnityEngine.UIElements.TextShadow), "op_Inequality", 0, typeof(UnityEngine.UIElements.TextShadow), typeof(UnityEngine.UIElements.TextShadow));
					r_Mop_Inequality_TextShadow_TextShadow.SetBelong(null);
				}
				return r_Mop_Inequality_TextShadow_TextShadow;
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
		/// UnityEngine.UIElements.TextShadow LerpUnclamped(UnityEngine.UIElements.TextShadow, UnityEngine.UIElements.TextShadow, Single)
		/// </summary>
		protected static RMethod r_MLerpUnclamped_TextShadow_TextShadow_Single;
		public static RMethod RMLerpUnclamped_TextShadow_TextShadow_Single
		{
			get
			{
				if(r_MLerpUnclamped_TextShadow_TextShadow_Single == null)
				{
					r_MLerpUnclamped_TextShadow_TextShadow_Single = new(typeof(UnityEngine.UIElements.TextShadow), "LerpUnclamped", 0, typeof(UnityEngine.UIElements.TextShadow), typeof(UnityEngine.UIElements.TextShadow), typeof(System.Single));
					r_MLerpUnclamped_TextShadow_TextShadow_Single.SetBelong(null);
				}
				return r_MLerpUnclamped_TextShadow_TextShadow_Single;
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

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.TextShadow @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_TextShadow.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.TextShadow @style1, UnityEngine.UIElements.TextShadow @style2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style1, @style2};
            var ___result = RMop_Equality_TextShadow_TextShadow.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.TextShadow @style1, UnityEngine.UIElements.TextShadow @style2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style1, @style2};
            var ___result = RMop_Inequality_TextShadow_TextShadow.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static UnityEngine.UIElements.TextShadow LerpUnclamped(UnityEngine.UIElements.TextShadow @a, UnityEngine.UIElements.TextShadow @b, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RMLerpUnclamped_TextShadow_TextShadow_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.TextShadow)___result;
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
