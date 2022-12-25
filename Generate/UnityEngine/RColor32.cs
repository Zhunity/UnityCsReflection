using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Color32
	/// </summary>
    public partial class RColor32 : RMember //
    {

		/// <summary>
		/// System.Int32 rgba
		/// </summary>
		protected RField r_rgba;
		public virtual RField Rrgba
		{
			get
			{
				if(r_rgba == null)
				{
					r_rgba = new(this, "rgba");
					r_rgba.SetBelong(this.instance);
				}
				return r_rgba;
			}
		}

		/// <summary>
		/// System.Byte r
		/// </summary>
		protected RField r_r;
		public virtual RField Rr
		{
			get
			{
				if(r_r == null)
				{
					r_r = new(this, "r");
					r_r.SetBelong(this.instance);
				}
				return r_r;
			}
		}

		/// <summary>
		/// System.Byte g
		/// </summary>
		protected RField r_g;
		public virtual RField Rg
		{
			get
			{
				if(r_g == null)
				{
					r_g = new(this, "g");
					r_g.SetBelong(this.instance);
				}
				return r_g;
			}
		}

		/// <summary>
		/// System.Byte b
		/// </summary>
		protected RField r_b;
		public virtual RField Rb
		{
			get
			{
				if(r_b == null)
				{
					r_b = new(this, "b");
					r_b.SetBelong(this.instance);
				}
				return r_b;
			}
		}

		/// <summary>
		/// System.Byte a
		/// </summary>
		protected RField r_a;
		public virtual RField Ra
		{
			get
			{
				if(r_a == null)
				{
					r_a = new(this, "a");
					r_a.SetBelong(this.instance);
				}
				return r_a;
			}
		}

		/// <summary>
		/// Byte Item [Int32]
		/// </summary>
		protected RProperty r_Item_Int32;
		public virtual RProperty RItem_Int32
		{
			get
			{
				if(r_Item_Int32 == null)
				{
					r_Item_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_Item_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 op_Implicit(UnityEngine.Color)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Color;
		public static RMethod Rop_Implicit_Color
		{
			get
			{
				if(r_Rop_Implicit_Color == null)
				{
					r_Rop_Implicit_Color = new(typeof(UnityEngine.Color32), "op_Implicit", 0, typeof(UnityEngine.Color));
					r_Rop_Implicit_Color.SetBelong(null);
				}
				return r_Rop_Implicit_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Color op_Implicit(UnityEngine.Color32)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Color32;
		public static RMethod Rop_Implicit_Color32
		{
			get
			{
				if(r_Rop_Implicit_Color32 == null)
				{
					r_Rop_Implicit_Color32 = new(typeof(UnityEngine.Color32), "op_Implicit", 0, typeof(UnityEngine.Color32));
					r_Rop_Implicit_Color32.SetBelong(null);
				}
				return r_Rop_Implicit_Color32;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 Lerp(UnityEngine.Color32, UnityEngine.Color32, Single)
		/// </summary>
		protected static RMethod r_RLerp_Color32_Color32_Single;
		public static RMethod RLerp_Color32_Color32_Single
		{
			get
			{
				if(r_RLerp_Color32_Color32_Single == null)
				{
					r_RLerp_Color32_Color32_Single = new(typeof(UnityEngine.Color32), "Lerp", 0, typeof(UnityEngine.Color32), typeof(UnityEngine.Color32), typeof(System.Single));
					r_RLerp_Color32_Color32_Single.SetBelong(null);
				}
				return r_RLerp_Color32_Color32_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 LerpUnclamped(UnityEngine.Color32, UnityEngine.Color32, Single)
		/// </summary>
		protected static RMethod r_RLerpUnclamped_Color32_Color32_Single;
		public static RMethod RLerpUnclamped_Color32_Color32_Single
		{
			get
			{
				if(r_RLerpUnclamped_Color32_Color32_Single == null)
				{
					r_RLerpUnclamped_Color32_Color32_Single = new(typeof(UnityEngine.Color32), "LerpUnclamped", 0, typeof(UnityEngine.Color32), typeof(UnityEngine.Color32), typeof(System.Single));
					r_RLerpUnclamped_Color32_Color32_Single.SetBelong(null);
				}
				return r_RLerpUnclamped_Color32_Color32_Single;
			}
		}

		/// <summary>
		/// Boolean InternalEquals(UnityEngine.Color32)
		/// </summary>
		protected RMethod r_RInternalEquals_Color32;
		public virtual RMethod RInternalEquals_Color32
		{
			get
			{
				if(r_RInternalEquals_Color32 == null)
				{
					r_RInternalEquals_Color32 = new(this, "InternalEquals", 0, typeof(UnityEngine.Color32));
					r_RInternalEquals_Color32.SetBelong(this.instance);
				}
				return r_RInternalEquals_Color32;
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
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_RToString_String;
		public virtual RMethod RToString_String
		{
			get
			{
				if(r_RToString_String == null)
				{
					r_RToString_String = new(this, "ToString", 0, typeof(System.String));
					r_RToString_String.SetBelong(this.instance);
				}
				return r_RToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_RToString_String_IFormatProvider;
		public virtual RMethod RToString_String_IFormatProvider
		{
			get
			{
				if(r_RToString_String_IFormatProvider == null)
				{
					r_RToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
					r_RToString_String_IFormatProvider.SetBelong(this.instance);
				}
				return r_RToString_String_IFormatProvider;
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

        public static UnityEngine.Color32 op_Implicit(UnityEngine.Color  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = Rop_Implicit_Color.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color32)___result;
        }


        public static UnityEngine.Color op_Implicit(UnityEngine.Color32  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = Rop_Implicit_Color32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public static UnityEngine.Color32 Lerp(UnityEngine.Color32  @a, UnityEngine.Color32  @b, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RLerp_Color32_Color32_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color32)___result;
        }


        public static UnityEngine.Color32 LerpUnclamped(UnityEngine.Color32  @a, UnityEngine.Color32  @b, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @t};
            var ___result = RLerpUnclamped_Color32_Color32_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color32)___result;
        }


        public virtual System.Boolean InternalEquals(UnityEngine.Color32  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RInternalEquals_Color32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String  @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.String  @format, System.IFormatProvider  @formatProvider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @formatProvider};
            var ___result = RToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
