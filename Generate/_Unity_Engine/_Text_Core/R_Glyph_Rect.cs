
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore
{
	/// <summary>
	/// UnityEngine.TextCore.GlyphRect
	/// </summary>
    public partial class RGlyphRect : RMember //
    {

		/// <summary>
		/// System.Int32 m_X
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_X;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_X
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
		/// System.Int32 m_Y
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Y;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Y
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
		/// System.Int32 m_Width
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Width;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Width
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
		/// System.Int32 m_Height
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Height;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Height
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
		/// UnityEngine.TextCore.GlyphRect s_ZeroGlyphRect
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphRect r_Fs_ZeroGlyphRect;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphRect RFs_ZeroGlyphRect
		{
			get
			{
				if(r_Fs_ZeroGlyphRect == null)
				{
					r_Fs_ZeroGlyphRect = new(typeof(UnityEngine.TextCore.GlyphRect), "s_ZeroGlyphRect");
				}
				return r_Fs_ZeroGlyphRect;
			}
		}

		/// <summary>
		/// Int32 x
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Px;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPx
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
		/// Int32 y
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Py;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPy
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
		/// Int32 width
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pwidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPwidth
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
		/// Int32 height
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pheight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPheight
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
		/// UnityEngine.TextCore.GlyphRect zero
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphRect r_Pzero;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RGlyphRect RPzero
		{
			get
			{
				if(r_Pzero == null)
				{
					r_Pzero = new(typeof(UnityEngine.TextCore.GlyphRect), "zero", -1);
				}
				return r_Pzero;
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
		/// Boolean Equals(UnityEngine.TextCore.GlyphRect)
		/// </summary>
		protected RMethod r_MEquals_GlyphRect;
		public virtual RMethod RMEquals_GlyphRect
		{
			get
			{
				if(r_MEquals_GlyphRect == null)
				{
					r_MEquals_GlyphRect = new(this, "Equals", 0, typeof(UnityEngine.TextCore.GlyphRect));
				}
				return r_MEquals_GlyphRect;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.TextCore.GlyphRect, UnityEngine.TextCore.GlyphRect)
		/// </summary>
		protected static RMethod r_Mop_Equality_GlyphRect_GlyphRect;
		public static RMethod RMop_Equality_GlyphRect_GlyphRect
		{
			get
			{
				if(r_Mop_Equality_GlyphRect_GlyphRect == null)
				{
					r_Mop_Equality_GlyphRect_GlyphRect = new(typeof(UnityEngine.TextCore.GlyphRect), "op_Equality", 0, typeof(UnityEngine.TextCore.GlyphRect), typeof(UnityEngine.TextCore.GlyphRect));
				}
				return r_Mop_Equality_GlyphRect_GlyphRect;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.TextCore.GlyphRect, UnityEngine.TextCore.GlyphRect)
		/// </summary>
		protected static RMethod r_Mop_Inequality_GlyphRect_GlyphRect;
		public static RMethod RMop_Inequality_GlyphRect_GlyphRect
		{
			get
			{
				if(r_Mop_Inequality_GlyphRect_GlyphRect == null)
				{
					r_Mop_Inequality_GlyphRect_GlyphRect = new(typeof(UnityEngine.TextCore.GlyphRect), "op_Inequality", 0, typeof(UnityEngine.TextCore.GlyphRect), typeof(UnityEngine.TextCore.GlyphRect));
				}
				return r_Mop_Inequality_GlyphRect_GlyphRect;
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
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.TextCore.GlyphRect @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_GlyphRect.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.TextCore.GlyphRect @lhs, UnityEngine.TextCore.GlyphRect @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_GlyphRect_GlyphRect.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.TextCore.GlyphRect @lhs, UnityEngine.TextCore.GlyphRect @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_GlyphRect_GlyphRect.Invoke(___genericsType, ___parameters);

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
