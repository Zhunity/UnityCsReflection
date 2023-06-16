
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.TextCore.GlyphMetrics
	/// </summary>
    public partial class RGlyphMetrics : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.TextCore.GlyphMetrics);
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


		/// <summary>
		/// System.Single m_Width
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Width;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Width
		{
			get
			{
				if(r_Fm_Width == null)
				{
					r_Fm_Width = new(this, "m_Width");
				}
				return r_Fm_Width;
			}
		}

		/// <summary>
		/// System.Single m_Height
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Height;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Height
		{
			get
			{
				if(r_Fm_Height == null)
				{
					r_Fm_Height = new(this, "m_Height");
				}
				return r_Fm_Height;
			}
		}

		/// <summary>
		/// System.Single m_HorizontalBearingX
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_HorizontalBearingX;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_HorizontalBearingX
		{
			get
			{
				if(r_Fm_HorizontalBearingX == null)
				{
					r_Fm_HorizontalBearingX = new(this, "m_HorizontalBearingX");
				}
				return r_Fm_HorizontalBearingX;
			}
		}

		/// <summary>
		/// System.Single m_HorizontalBearingY
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_HorizontalBearingY;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_HorizontalBearingY
		{
			get
			{
				if(r_Fm_HorizontalBearingY == null)
				{
					r_Fm_HorizontalBearingY = new(this, "m_HorizontalBearingY");
				}
				return r_Fm_HorizontalBearingY;
			}
		}

		/// <summary>
		/// System.Single m_HorizontalAdvance
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_HorizontalAdvance;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_HorizontalAdvance
		{
			get
			{
				if(r_Fm_HorizontalAdvance == null)
				{
					r_Fm_HorizontalAdvance = new(this, "m_HorizontalAdvance");
				}
				return r_Fm_HorizontalAdvance;
			}
		}

		/// <summary>
		/// Single width
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pwidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPwidth
		{
			get
			{
				if(r_Pwidth == null)
				{
					r_Pwidth = new(this, "width", -1);
				}
				return r_Pwidth;
			}
		}

		/// <summary>
		/// Single height
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pheight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPheight
		{
			get
			{
				if(r_Pheight == null)
				{
					r_Pheight = new(this, "height", -1);
				}
				return r_Pheight;
			}
		}

		/// <summary>
		/// Single horizontalBearingX
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PhorizontalBearingX;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPhorizontalBearingX
		{
			get
			{
				if(r_PhorizontalBearingX == null)
				{
					r_PhorizontalBearingX = new(this, "horizontalBearingX", -1);
				}
				return r_PhorizontalBearingX;
			}
		}

		/// <summary>
		/// Single horizontalBearingY
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PhorizontalBearingY;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPhorizontalBearingY
		{
			get
			{
				if(r_PhorizontalBearingY == null)
				{
					r_PhorizontalBearingY = new(this, "horizontalBearingY", -1);
				}
				return r_PhorizontalBearingY;
			}
		}

		/// <summary>
		/// Single horizontalAdvance
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PhorizontalAdvance;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPhorizontalAdvance
		{
			get
			{
				if(r_PhorizontalAdvance == null)
				{
					r_PhorizontalAdvance = new(this, "horizontalAdvance", -1);
				}
				return r_PhorizontalAdvance;
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
		/// Boolean Equals(UnityEngine.TextCore.GlyphMetrics)
		/// </summary>
		protected RMethod r_MEquals_GlyphMetrics;
		public virtual RMethod RMEquals_GlyphMetrics
		{
			get
			{
				if(r_MEquals_GlyphMetrics == null)
				{
					r_MEquals_GlyphMetrics = new(this, "Equals", 0, typeof(UnityEngine.TextCore.GlyphMetrics));
				}
				return r_MEquals_GlyphMetrics;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.TextCore.GlyphMetrics, UnityEngine.TextCore.GlyphMetrics)
		/// </summary>
		protected static RMethod r_Mop_Equality_GlyphMetrics_GlyphMetrics;
		public static RMethod RMop_Equality_GlyphMetrics_GlyphMetrics
		{
			get
			{
				if(r_Mop_Equality_GlyphMetrics_GlyphMetrics == null)
				{
					r_Mop_Equality_GlyphMetrics_GlyphMetrics = new(Type, "op_Equality", 0, typeof(UnityEngine.TextCore.GlyphMetrics), typeof(UnityEngine.TextCore.GlyphMetrics));
				}
				return r_Mop_Equality_GlyphMetrics_GlyphMetrics;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.TextCore.GlyphMetrics, UnityEngine.TextCore.GlyphMetrics)
		/// </summary>
		protected static RMethod r_Mop_Inequality_GlyphMetrics_GlyphMetrics;
		public static RMethod RMop_Inequality_GlyphMetrics_GlyphMetrics
		{
			get
			{
				if(r_Mop_Inequality_GlyphMetrics_GlyphMetrics == null)
				{
					r_Mop_Inequality_GlyphMetrics_GlyphMetrics = new(Type, "op_Inequality", 0, typeof(UnityEngine.TextCore.GlyphMetrics), typeof(UnityEngine.TextCore.GlyphMetrics));
				}
				return r_Mop_Inequality_GlyphMetrics_GlyphMetrics;
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


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(UnityEngine.TextCore.GlyphMetrics @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_GlyphMetrics.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Equality(UnityEngine.TextCore.GlyphMetrics @lhs, UnityEngine.TextCore.GlyphMetrics @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_GlyphMetrics_GlyphMetrics.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(UnityEngine.TextCore.GlyphMetrics @lhs, UnityEngine.TextCore.GlyphMetrics @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_GlyphMetrics_GlyphMetrics.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
