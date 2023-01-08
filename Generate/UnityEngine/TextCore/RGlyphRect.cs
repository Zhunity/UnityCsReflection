using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore
{
	/// <summary>
	/// UnityEngine.TextCore.GlyphRect
	/// </summary>
    public partial class RGlyphRect : RMember //
    {

		/// <summary>
		/// System.Int32 m_X
		/// </summary>
		protected RField r_m_X;
		public virtual RField Rm_X
		{
			get
			{
				if(r_m_X == null)
				{
					r_m_X = new(this, "m_X");
					r_m_X.SetBelong(this.instance);
				}
				return r_m_X;
			}
		}

		/// <summary>
		/// System.Int32 m_Y
		/// </summary>
		protected RField r_m_Y;
		public virtual RField Rm_Y
		{
			get
			{
				if(r_m_Y == null)
				{
					r_m_Y = new(this, "m_Y");
					r_m_Y.SetBelong(this.instance);
				}
				return r_m_Y;
			}
		}

		/// <summary>
		/// System.Int32 m_Width
		/// </summary>
		protected RField r_m_Width;
		public virtual RField Rm_Width
		{
			get
			{
				if(r_m_Width == null)
				{
					r_m_Width = new(this, "m_Width");
					r_m_Width.SetBelong(this.instance);
				}
				return r_m_Width;
			}
		}

		/// <summary>
		/// System.Int32 m_Height
		/// </summary>
		protected RField r_m_Height;
		public virtual RField Rm_Height
		{
			get
			{
				if(r_m_Height == null)
				{
					r_m_Height = new(this, "m_Height");
					r_m_Height.SetBelong(this.instance);
				}
				return r_m_Height;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.GlyphRect s_ZeroGlyphRect
		/// </summary>
		protected static RUnityEngine.RTextCore.RGlyphRect r_s_ZeroGlyphRect;
		public static RUnityEngine.RTextCore.RGlyphRect Rs_ZeroGlyphRect
		{
			get
			{
				if(r_s_ZeroGlyphRect == null)
				{
					r_s_ZeroGlyphRect = new(typeof(UnityEngine.TextCore.GlyphRect), "s_ZeroGlyphRect");
					r_s_ZeroGlyphRect.SetBelong(null);
				}
				return r_s_ZeroGlyphRect;
			}
		}

		/// <summary>
		/// Int32 x
		/// </summary>
		protected RProperty r_x;
		public virtual RProperty Rx
		{
			get
			{
				if(r_x == null)
				{
					r_x = new(this, "x", -1);
					r_x.SetBelong(this.instance);
				}
				return r_x;
			}
		}

		/// <summary>
		/// Int32 y
		/// </summary>
		protected RProperty r_y;
		public virtual RProperty Ry
		{
			get
			{
				if(r_y == null)
				{
					r_y = new(this, "y", -1);
					r_y.SetBelong(this.instance);
				}
				return r_y;
			}
		}

		/// <summary>
		/// Int32 width
		/// </summary>
		protected RProperty r_width;
		public virtual RProperty Rwidth
		{
			get
			{
				if(r_width == null)
				{
					r_width = new(this, "width", -1);
					r_width.SetBelong(this.instance);
				}
				return r_width;
			}
		}

		/// <summary>
		/// Int32 height
		/// </summary>
		protected RProperty r_height;
		public virtual RProperty Rheight
		{
			get
			{
				if(r_height == null)
				{
					r_height = new(this, "height", -1);
					r_height.SetBelong(this.instance);
				}
				return r_height;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.GlyphRect zero
		/// </summary>
		protected static RUnityEngine.RTextCore.RGlyphRect r_zero;
		public static RUnityEngine.RTextCore.RGlyphRect Rzero
		{
			get
			{
				if(r_zero == null)
				{
					r_zero = new(typeof(UnityEngine.TextCore.GlyphRect), "zero", -1);
					r_zero.SetBelong(null);
				}
				return r_zero;
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
		/// Boolean Equals(UnityEngine.TextCore.GlyphRect)
		/// </summary>
		protected RMethod r_Equals_GlyphRect;
		public virtual RMethod REquals_GlyphRect
		{
			get
			{
				if(r_Equals_GlyphRect == null)
				{
					r_Equals_GlyphRect = new(this, "Equals", 0, typeof(UnityEngine.TextCore.GlyphRect));
					r_Equals_GlyphRect.SetBelong(this.instance);
				}
				return r_Equals_GlyphRect;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.TextCore.GlyphRect, UnityEngine.TextCore.GlyphRect)
		/// </summary>
		protected static RMethod r_op_Equality_GlyphRect_GlyphRect;
		public static RMethod Rop_Equality_GlyphRect_GlyphRect
		{
			get
			{
				if(r_op_Equality_GlyphRect_GlyphRect == null)
				{
					r_op_Equality_GlyphRect_GlyphRect = new(typeof(UnityEngine.TextCore.GlyphRect), "op_Equality", 0, typeof(UnityEngine.TextCore.GlyphRect), typeof(UnityEngine.TextCore.GlyphRect));
					r_op_Equality_GlyphRect_GlyphRect.SetBelong(null);
				}
				return r_op_Equality_GlyphRect_GlyphRect;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.TextCore.GlyphRect, UnityEngine.TextCore.GlyphRect)
		/// </summary>
		protected static RMethod r_op_Inequality_GlyphRect_GlyphRect;
		public static RMethod Rop_Inequality_GlyphRect_GlyphRect
		{
			get
			{
				if(r_op_Inequality_GlyphRect_GlyphRect == null)
				{
					r_op_Inequality_GlyphRect_GlyphRect = new(typeof(UnityEngine.TextCore.GlyphRect), "op_Inequality", 0, typeof(UnityEngine.TextCore.GlyphRect), typeof(UnityEngine.TextCore.GlyphRect));
					r_op_Inequality_GlyphRect_GlyphRect.SetBelong(null);
				}
				return r_op_Inequality_GlyphRect_GlyphRect;
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


        public RGlyphRect() : base("UnityEngine.TextCore.GlyphRect")
        {
        }

        public RGlyphRect(System.Object instance) : base("UnityEngine.TextCore.GlyphRect")
		{
            SetInstance(instance);
		}

        public RGlyphRect(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGlyphRect(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.TextCore.GlyphRect  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_GlyphRect.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.TextCore.GlyphRect  @lhs, UnityEngine.TextCore.GlyphRect  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_GlyphRect_GlyphRect.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.TextCore.GlyphRect  @lhs, UnityEngine.TextCore.GlyphRect  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_GlyphRect_GlyphRect.Invoke(___genericsType, ___parameters);

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
