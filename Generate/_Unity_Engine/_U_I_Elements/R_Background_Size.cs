
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.BackgroundSize
	/// </summary>
    public partial class RBackgroundSize : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.BackgroundSizeType m_SizeType
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundSizeType r_Fm_SizeType;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundSizeType RFm_SizeType
		{
			get
			{
				if(r_Fm_SizeType == null)
				{
					r_Fm_SizeType = new(this, "m_SizeType");
				}
				return r_Fm_SizeType;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length m_X
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Fm_X;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFm_X
		{
			get
			{
				if(r_Fm_X == null)
				{
					r_Fm_X = new(this, "m_X");
				}
				return r_Fm_X;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length m_Y
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Fm_Y;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RFm_Y
		{
			get
			{
				if(r_Fm_Y == null)
				{
					r_Fm_Y = new(this, "m_Y");
				}
				return r_Fm_Y;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundSizeType sizeType
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundSizeType r_PsizeType;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundSizeType RPsizeType
		{
			get
			{
				if(r_PsizeType == null)
				{
					r_PsizeType = new(this, "sizeType", -1);
				}
				return r_PsizeType;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length x
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Px;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPx
		{
			get
			{
				if(r_Px == null)
				{
					r_Px = new(this, "x", -1);
				}
				return r_Px;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Length y
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength r_Py;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLength RPy
		{
			get
			{
				if(r_Py == null)
				{
					r_Py = new(this, "y", -1);
				}
				return r_Py;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundSize Initial()
		/// </summary>
		protected static RMethod r_MInitial;
		public static RMethod RMInitial
		{
			get
			{
				if(r_MInitial == null)
				{
					r_MInitial = new(typeof(UnityEngine.UIElements.BackgroundSize), "Initial", 0);
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
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.UIElements.BackgroundSize)
		/// </summary>
		protected RMethod r_MEquals_BackgroundSize;
		public virtual RMethod RMEquals_BackgroundSize
		{
			get
			{
				if(r_MEquals_BackgroundSize == null)
				{
					r_MEquals_BackgroundSize = new(this, "Equals", 0, typeof(UnityEngine.UIElements.BackgroundSize));
				}
				return r_MEquals_BackgroundSize;
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
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.UIElements.BackgroundSize, UnityEngine.UIElements.BackgroundSize)
		/// </summary>
		protected static RMethod r_Mop_Equality_BackgroundSize_BackgroundSize;
		public static RMethod RMop_Equality_BackgroundSize_BackgroundSize
		{
			get
			{
				if(r_Mop_Equality_BackgroundSize_BackgroundSize == null)
				{
					r_Mop_Equality_BackgroundSize_BackgroundSize = new(typeof(UnityEngine.UIElements.BackgroundSize), "op_Equality", 0, typeof(UnityEngine.UIElements.BackgroundSize), typeof(UnityEngine.UIElements.BackgroundSize));
				}
				return r_Mop_Equality_BackgroundSize_BackgroundSize;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.BackgroundSize, UnityEngine.UIElements.BackgroundSize)
		/// </summary>
		protected static RMethod r_Mop_Inequality_BackgroundSize_BackgroundSize;
		public static RMethod RMop_Inequality_BackgroundSize_BackgroundSize
		{
			get
			{
				if(r_Mop_Inequality_BackgroundSize_BackgroundSize == null)
				{
					r_Mop_Inequality_BackgroundSize_BackgroundSize = new(typeof(UnityEngine.UIElements.BackgroundSize), "op_Inequality", 0, typeof(UnityEngine.UIElements.BackgroundSize), typeof(UnityEngine.UIElements.BackgroundSize));
				}
				return r_Mop_Inequality_BackgroundSize_BackgroundSize;
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
				}
				return r_MMemberwiseClone;
			}
		}


        public RBackgroundSize() : base("UnityEngine.UIElements.BackgroundSize")
        {
        }

        public RBackgroundSize(System.Object instance) : base("UnityEngine.UIElements.BackgroundSize")
		{
            SetInstance(instance);
		}

        public RBackgroundSize(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBackgroundSize(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.UIElements.BackgroundSize Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.BackgroundSize)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.BackgroundSize @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_BackgroundSize.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.BackgroundSize @style1, UnityEngine.UIElements.BackgroundSize @style2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style1, @style2};
            var ___result = RMop_Equality_BackgroundSize_BackgroundSize.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.BackgroundSize @style1, UnityEngine.UIElements.BackgroundSize @style2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style1, @style2};
            var ___result = RMop_Inequality_BackgroundSize_BackgroundSize.Invoke(___genericsType, ___parameters);

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
