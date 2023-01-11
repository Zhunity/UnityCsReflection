using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore
{
	/// <summary>
	/// UnityEngine.TextCore.GlyphMetrics
	/// </summary>
    public partial class RGlyphMetrics : RMember //
    {

		/// <summary>
		/// System.Single m_Width
		/// </summary>
		protected RSystem.RSingle r_m_Width;
		public virtual RSystem.RSingle Rm_Width
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
		/// System.Single m_Height
		/// </summary>
		protected RSystem.RSingle r_m_Height;
		public virtual RSystem.RSingle Rm_Height
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
		/// System.Single m_HorizontalBearingX
		/// </summary>
		protected RSystem.RSingle r_m_HorizontalBearingX;
		public virtual RSystem.RSingle Rm_HorizontalBearingX
		{
			get
			{
				if(r_m_HorizontalBearingX == null)
				{
					r_m_HorizontalBearingX = new(this, "m_HorizontalBearingX");
					r_m_HorizontalBearingX.SetBelong(this.instance);
				}
				return r_m_HorizontalBearingX;
			}
		}

		/// <summary>
		/// System.Single m_HorizontalBearingY
		/// </summary>
		protected RSystem.RSingle r_m_HorizontalBearingY;
		public virtual RSystem.RSingle Rm_HorizontalBearingY
		{
			get
			{
				if(r_m_HorizontalBearingY == null)
				{
					r_m_HorizontalBearingY = new(this, "m_HorizontalBearingY");
					r_m_HorizontalBearingY.SetBelong(this.instance);
				}
				return r_m_HorizontalBearingY;
			}
		}

		/// <summary>
		/// System.Single m_HorizontalAdvance
		/// </summary>
		protected RSystem.RSingle r_m_HorizontalAdvance;
		public virtual RSystem.RSingle Rm_HorizontalAdvance
		{
			get
			{
				if(r_m_HorizontalAdvance == null)
				{
					r_m_HorizontalAdvance = new(this, "m_HorizontalAdvance");
					r_m_HorizontalAdvance.SetBelong(this.instance);
				}
				return r_m_HorizontalAdvance;
			}
		}

		/// <summary>
		/// Single width
		/// </summary>
		protected RSystem.RSingle r_width;
		public virtual RSystem.RSingle Rwidth
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
		/// Single height
		/// </summary>
		protected RSystem.RSingle r_height;
		public virtual RSystem.RSingle Rheight
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
		/// Single horizontalBearingX
		/// </summary>
		protected RSystem.RSingle r_horizontalBearingX;
		public virtual RSystem.RSingle RhorizontalBearingX
		{
			get
			{
				if(r_horizontalBearingX == null)
				{
					r_horizontalBearingX = new(this, "horizontalBearingX", -1);
					r_horizontalBearingX.SetBelong(this.instance);
				}
				return r_horizontalBearingX;
			}
		}

		/// <summary>
		/// Single horizontalBearingY
		/// </summary>
		protected RSystem.RSingle r_horizontalBearingY;
		public virtual RSystem.RSingle RhorizontalBearingY
		{
			get
			{
				if(r_horizontalBearingY == null)
				{
					r_horizontalBearingY = new(this, "horizontalBearingY", -1);
					r_horizontalBearingY.SetBelong(this.instance);
				}
				return r_horizontalBearingY;
			}
		}

		/// <summary>
		/// Single horizontalAdvance
		/// </summary>
		protected RSystem.RSingle r_horizontalAdvance;
		public virtual RSystem.RSingle RhorizontalAdvance
		{
			get
			{
				if(r_horizontalAdvance == null)
				{
					r_horizontalAdvance = new(this, "horizontalAdvance", -1);
					r_horizontalAdvance.SetBelong(this.instance);
				}
				return r_horizontalAdvance;
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
		/// Boolean Equals(UnityEngine.TextCore.GlyphMetrics)
		/// </summary>
		protected RMethod r_Equals_GlyphMetrics;
		public virtual RMethod REquals_GlyphMetrics
		{
			get
			{
				if(r_Equals_GlyphMetrics == null)
				{
					r_Equals_GlyphMetrics = new(this, "Equals", 0, typeof(UnityEngine.TextCore.GlyphMetrics));
					r_Equals_GlyphMetrics.SetBelong(this.instance);
				}
				return r_Equals_GlyphMetrics;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.TextCore.GlyphMetrics, UnityEngine.TextCore.GlyphMetrics)
		/// </summary>
		protected static RMethod r_op_Equality_GlyphMetrics_GlyphMetrics;
		public static RMethod Rop_Equality_GlyphMetrics_GlyphMetrics
		{
			get
			{
				if(r_op_Equality_GlyphMetrics_GlyphMetrics == null)
				{
					r_op_Equality_GlyphMetrics_GlyphMetrics = new(typeof(UnityEngine.TextCore.GlyphMetrics), "op_Equality", 0, typeof(UnityEngine.TextCore.GlyphMetrics), typeof(UnityEngine.TextCore.GlyphMetrics));
					r_op_Equality_GlyphMetrics_GlyphMetrics.SetBelong(null);
				}
				return r_op_Equality_GlyphMetrics_GlyphMetrics;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.TextCore.GlyphMetrics, UnityEngine.TextCore.GlyphMetrics)
		/// </summary>
		protected static RMethod r_op_Inequality_GlyphMetrics_GlyphMetrics;
		public static RMethod Rop_Inequality_GlyphMetrics_GlyphMetrics
		{
			get
			{
				if(r_op_Inequality_GlyphMetrics_GlyphMetrics == null)
				{
					r_op_Inequality_GlyphMetrics_GlyphMetrics = new(typeof(UnityEngine.TextCore.GlyphMetrics), "op_Inequality", 0, typeof(UnityEngine.TextCore.GlyphMetrics), typeof(UnityEngine.TextCore.GlyphMetrics));
					r_op_Inequality_GlyphMetrics_GlyphMetrics.SetBelong(null);
				}
				return r_op_Inequality_GlyphMetrics_GlyphMetrics;
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


        public RGlyphMetrics() : base("UnityEngine.TextCore.GlyphMetrics")
        {
        }

        public RGlyphMetrics(System.Object instance) : base("UnityEngine.TextCore.GlyphMetrics")
		{
            SetInstance(instance);
		}

        public RGlyphMetrics(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGlyphMetrics(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.TextCore.GlyphMetrics @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_GlyphMetrics.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.TextCore.GlyphMetrics @lhs, UnityEngine.TextCore.GlyphMetrics @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_GlyphMetrics_GlyphMetrics.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.TextCore.GlyphMetrics @lhs, UnityEngine.TextCore.GlyphMetrics @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_GlyphMetrics_GlyphMetrics.Invoke(___genericsType, ___parameters);

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
