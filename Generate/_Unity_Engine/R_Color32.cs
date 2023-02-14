
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Color32
	/// </summary>
    public partial class RColor32 : RMember //
    {

		/// <summary>
		/// System.Int32 rgba
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Frgba;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFrgba
		{
			get
			{
				if(r_Frgba == null)
				{
					r_Frgba = new(this, "rgba");
					r_Frgba.SetBelong(this.instance);
				}
				return r_Frgba;
			}
		}

		/// <summary>
		/// System.Byte r
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_Fr;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RFr
		{
			get
			{
				if(r_Fr == null)
				{
					r_Fr = new(this, "r");
					r_Fr.SetBelong(this.instance);
				}
				return r_Fr;
			}
		}

		/// <summary>
		/// System.Byte g
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_Fg;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RFg
		{
			get
			{
				if(r_Fg == null)
				{
					r_Fg = new(this, "g");
					r_Fg.SetBelong(this.instance);
				}
				return r_Fg;
			}
		}

		/// <summary>
		/// System.Byte b
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_Fb;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RFb
		{
			get
			{
				if(r_Fb == null)
				{
					r_Fb = new(this, "b");
					r_Fb.SetBelong(this.instance);
				}
				return r_Fb;
			}
		}

		/// <summary>
		/// System.Byte a
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_Fa;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RFa
		{
			get
			{
				if(r_Fa == null)
				{
					r_Fa = new(this, "a");
					r_Fa.SetBelong(this.instance);
				}
				return r_Fa;
			}
		}

		/// <summary>
		/// Byte Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_PItem_Int32;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RPItem_Int32
		{
			get
			{
				if(r_PItem_Int32 == null)
				{
					r_PItem_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_PItem_Int32.SetBelong(this.instance);
				}
				return r_PItem_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 op_Implicit(UnityEngine.Color)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Color;
		public static RMethod RMop_Implicit_Color
		{
			get
			{
				if(r_Mop_Implicit_Color == null)
				{
					r_Mop_Implicit_Color = new(typeof(UnityEngine.Color32), "op_Implicit", 0, typeof(UnityEngine.Color));
					r_Mop_Implicit_Color.SetBelong(null);
				}
				return r_Mop_Implicit_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Color op_Implicit(UnityEngine.Color32)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Color32;
		public static RMethod RMop_Implicit_Color32
		{
			get
			{
				if(r_Mop_Implicit_Color32 == null)
				{
					r_Mop_Implicit_Color32 = new(typeof(UnityEngine.Color32), "op_Implicit", 0, typeof(UnityEngine.Color32));
					r_Mop_Implicit_Color32.SetBelong(null);
				}
				return r_Mop_Implicit_Color32;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 Lerp(UnityEngine.Color32, UnityEngine.Color32, Single)
		/// </summary>
		protected static RMethod r_MLerp_Color32_Color32_Single;
		public static RMethod RMLerp_Color32_Color32_Single
		{
			get
			{
				if(r_MLerp_Color32_Color32_Single == null)
				{
					r_MLerp_Color32_Color32_Single = new(typeof(UnityEngine.Color32), "Lerp", 0, typeof(UnityEngine.Color32), typeof(UnityEngine.Color32), typeof(System.Single));
					r_MLerp_Color32_Color32_Single.SetBelong(null);
				}
				return r_MLerp_Color32_Color32_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 LerpUnclamped(UnityEngine.Color32, UnityEngine.Color32, Single)
		/// </summary>
		protected static RMethod r_MLerpUnclamped_Color32_Color32_Single;
		public static RMethod RMLerpUnclamped_Color32_Color32_Single
		{
			get
			{
				if(r_MLerpUnclamped_Color32_Color32_Single == null)
				{
					r_MLerpUnclamped_Color32_Color32_Single = new(typeof(UnityEngine.Color32), "LerpUnclamped", 0, typeof(UnityEngine.Color32), typeof(UnityEngine.Color32), typeof(System.Single));
					r_MLerpUnclamped_Color32_Color32_Single.SetBelong(null);
				}
				return r_MLerpUnclamped_Color32_Color32_Single;
			}
		}

		/// <summary>
		/// Boolean InternalEquals(UnityEngine.Color32)
		/// </summary>
		protected RMethod r_MInternalEquals_Color32;
		public virtual RMethod RMInternalEquals_Color32
		{
			get
			{
				if(r_MInternalEquals_Color32 == null)
				{
					r_MInternalEquals_Color32 = new(this, "InternalEquals", 0, typeof(UnityEngine.Color32));
					r_MInternalEquals_Color32.SetBelong(this.instance);
				}
				return r_MInternalEquals_Color32;
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
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_MToString_String;
		public virtual RMethod RMToString_String
		{
			get
			{
				if(r_MToString_String == null)
				{
					r_MToString_String = new(this, "ToString", 0, typeof(System.String));
					r_MToString_String.SetBelong(this.instance);
				}
				return r_MToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_String_IFormatProvider;
		public virtual RMethod RMToString_String_IFormatProvider
		{
			get
			{
				if(r_MToString_String_IFormatProvider == null)
				{
					r_MToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_MToString_String_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToString_String_IFormatProvider;
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


        public RColor32() : base("UnityEngine.Color32")
        {
        }

        public RColor32(System.Object instance) : base("UnityEngine.Color32")
		{
            SetInstance(instance);
		}

        public RColor32(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RColor32(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.Color32 op_Implicit(UnityEngine.Color @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMop_Implicit_Color.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color32)___result;
        }


        public static UnityEngine.Color op_Implicit(UnityEngine.Color32 @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMop_Implicit_Color32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public static UnityEngine.Color32 Lerp(UnityEngine.Color32 @a, UnityEngine.Color32 @b, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RMLerp_Color32_Color32_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color32)___result;
        }


        public static UnityEngine.Color32 LerpUnclamped(UnityEngine.Color32 @a, UnityEngine.Color32 @b, System.Single @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RMLerpUnclamped_Color32_Color32_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color32)___result;
        }


        public virtual System.Boolean InternalEquals(UnityEngine.Color32 @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMInternalEquals_Color32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @formatProvider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
