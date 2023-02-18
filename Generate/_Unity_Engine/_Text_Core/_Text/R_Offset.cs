
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.Offset
	/// </summary>
    public partial class ROffset : RMember //
    {

		/// <summary>
		/// System.Single m_Left
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Left;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Left
		{
			get
			{
				if(r_Fm_Left == null)
				{
					r_Fm_Left = new(this, "m_Left");
					r_Fm_Left.SetBelong(this.GetValue());
				}
				return r_Fm_Left;
			}
		}

		/// <summary>
		/// System.Single m_Right
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Right;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Right
		{
			get
			{
				if(r_Fm_Right == null)
				{
					r_Fm_Right = new(this, "m_Right");
					r_Fm_Right.SetBelong(this.GetValue());
				}
				return r_Fm_Right;
			}
		}

		/// <summary>
		/// System.Single m_Top
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Top;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Top
		{
			get
			{
				if(r_Fm_Top == null)
				{
					r_Fm_Top = new(this, "m_Top");
					r_Fm_Top.SetBelong(this.GetValue());
				}
				return r_Fm_Top;
			}
		}

		/// <summary>
		/// System.Single m_Bottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_Bottom;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_Bottom
		{
			get
			{
				if(r_Fm_Bottom == null)
				{
					r_Fm_Bottom = new(this, "m_Bottom");
					r_Fm_Bottom.SetBelong(this.GetValue());
				}
				return r_Fm_Bottom;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.Offset k_ZeroOffset
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.ROffset r_Fk_ZeroOffset;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.ROffset RFk_ZeroOffset
		{
			get
			{
				if(r_Fk_ZeroOffset == null)
				{
					r_Fk_ZeroOffset = new( ReflectionUtils.GetType("UnityEngine.TextCore.Text.Offset"), "k_ZeroOffset");
					r_Fk_ZeroOffset.SetBelong(null);
				}
				return r_Fk_ZeroOffset;
			}
		}

		/// <summary>
		/// Single left
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pleft;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPleft
		{
			get
			{
				if(r_Pleft == null)
				{
					r_Pleft = new(this, "left", -1);
					r_Pleft.SetBelong(this.GetValue());
				}
				return r_Pleft;
			}
		}

		/// <summary>
		/// Single right
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pright;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPright
		{
			get
			{
				if(r_Pright == null)
				{
					r_Pright = new(this, "right", -1);
					r_Pright.SetBelong(this.GetValue());
				}
				return r_Pright;
			}
		}

		/// <summary>
		/// Single top
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Ptop;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPtop
		{
			get
			{
				if(r_Ptop == null)
				{
					r_Ptop = new(this, "top", -1);
					r_Ptop.SetBelong(this.GetValue());
				}
				return r_Ptop;
			}
		}

		/// <summary>
		/// Single bottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pbottom;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPbottom
		{
			get
			{
				if(r_Pbottom == null)
				{
					r_Pbottom = new(this, "bottom", -1);
					r_Pbottom.SetBelong(this.GetValue());
				}
				return r_Pbottom;
			}
		}

		/// <summary>
		/// Single horizontal
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Phorizontal;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPhorizontal
		{
			get
			{
				if(r_Phorizontal == null)
				{
					r_Phorizontal = new(this, "horizontal", -1);
					r_Phorizontal.SetBelong(this.GetValue());
				}
				return r_Phorizontal;
			}
		}

		/// <summary>
		/// Single vertical
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pvertical;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPvertical
		{
			get
			{
				if(r_Pvertical == null)
				{
					r_Pvertical = new(this, "vertical", -1);
					r_Pvertical.SetBelong(this.GetValue());
				}
				return r_Pvertical;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.Offset zero
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.ROffset r_Pzero;
		public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.ROffset RPzero
		{
			get
			{
				if(r_Pzero == null)
				{
					r_Pzero = new( ReflectionUtils.GetType("UnityEngine.TextCore.Text.Offset"), "zero", -1);
					r_Pzero.SetBelong(null);
				}
				return r_Pzero;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.TextCore.Text.Offset, UnityEngine.TextCore.Text.Offset)
		/// </summary>
		protected static RMethod r_Mop_Equality_Offset_Offset;
		public static RMethod RMop_Equality_Offset_Offset
		{
			get
			{
				if(r_Mop_Equality_Offset_Offset == null)
				{
					r_Mop_Equality_Offset_Offset = new( ReflectionUtils.GetType("UnityEngine.TextCore.Text.Offset"), "op_Equality", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.Offset"),  ReflectionUtils.GetType("UnityEngine.TextCore.Text.Offset"));
					r_Mop_Equality_Offset_Offset.SetBelong(null);
				}
				return r_Mop_Equality_Offset_Offset;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.TextCore.Text.Offset, UnityEngine.TextCore.Text.Offset)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Offset_Offset;
		public static RMethod RMop_Inequality_Offset_Offset
		{
			get
			{
				if(r_Mop_Inequality_Offset_Offset == null)
				{
					r_Mop_Inequality_Offset_Offset = new( ReflectionUtils.GetType("UnityEngine.TextCore.Text.Offset"), "op_Inequality", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.Offset"),  ReflectionUtils.GetType("UnityEngine.TextCore.Text.Offset"));
					r_Mop_Inequality_Offset_Offset.SetBelong(null);
				}
				return r_Mop_Inequality_Offset_Offset;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.Offset op_Multiply(UnityEngine.TextCore.Text.Offset, Single)
		/// </summary>
		protected static RMethod r_Mop_Multiply_Offset_Single;
		public static RMethod RMop_Multiply_Offset_Single
		{
			get
			{
				if(r_Mop_Multiply_Offset_Single == null)
				{
					r_Mop_Multiply_Offset_Single = new( ReflectionUtils.GetType("UnityEngine.TextCore.Text.Offset"), "op_Multiply", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.Offset"), typeof(System.Single));
					r_Mop_Multiply_Offset_Single.SetBelong(null);
				}
				return r_Mop_Multiply_Offset_Single;
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MEquals_Object.SetBelong(this.GetValue());
				}
				return r_MEquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.TextCore.Text.Offset)
		/// </summary>
		protected RMethod r_MEquals_Offset;
		public virtual RMethod RMEquals_Offset
		{
			get
			{
				if(r_MEquals_Offset == null)
				{
					r_MEquals_Offset = new(this, "Equals", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.Offset"));
					r_MEquals_Offset.SetBelong(this.GetValue());
				}
				return r_MEquals_Offset;
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
					r_MToString.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
			}
		}


        public ROffset() : base("UnityEngine.TextCore.Text.Offset")
        {
        }

        public ROffset(System.Object instance) : base("UnityEngine.TextCore.Text.Offset")
		{
            SetInstance(instance);
		}

        public ROffset(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public ROffset(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean op_Equality(Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.ROffset @lhs, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.ROffset @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Equality_Offset_Offset.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.ROffset @lhs, Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.ROffset @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs.Value, @rhs.Value};
            var ___result = RMop_Inequality_Offset_Offset.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.ROffset op_Multiply(Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.ROffset @a, System.Single @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a.Value, @b};
            var ___result = RMop_Multiply_Offset_Single.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.ROffset(___result);
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


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.ROffset @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other.Value};
            var ___result = RMEquals_Offset.Invoke(___genericsType, ___parameters);

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
