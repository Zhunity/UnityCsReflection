using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RText
{
	/// <summary>
	/// UnityEngine.TextCore.Text.Offset
	/// </summary>
    public partial class ROffset : RMember //
    {

		/// <summary>
		/// System.Single m_Left
		/// </summary>
		protected RField r_m_Left;
		public virtual RField Rm_Left
		{
			get
			{
				if(r_m_Left == null)
				{
					r_m_Left = new(this, "m_Left");
					r_m_Left.SetBelong(this.instance);
				}
				return r_m_Left;
			}
		}

		/// <summary>
		/// System.Single m_Right
		/// </summary>
		protected RField r_m_Right;
		public virtual RField Rm_Right
		{
			get
			{
				if(r_m_Right == null)
				{
					r_m_Right = new(this, "m_Right");
					r_m_Right.SetBelong(this.instance);
				}
				return r_m_Right;
			}
		}

		/// <summary>
		/// System.Single m_Top
		/// </summary>
		protected RField r_m_Top;
		public virtual RField Rm_Top
		{
			get
			{
				if(r_m_Top == null)
				{
					r_m_Top = new(this, "m_Top");
					r_m_Top.SetBelong(this.instance);
				}
				return r_m_Top;
			}
		}

		/// <summary>
		/// System.Single m_Bottom
		/// </summary>
		protected RField r_m_Bottom;
		public virtual RField Rm_Bottom
		{
			get
			{
				if(r_m_Bottom == null)
				{
					r_m_Bottom = new(this, "m_Bottom");
					r_m_Bottom.SetBelong(this.instance);
				}
				return r_m_Bottom;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.Offset k_ZeroOffset
		/// </summary>
		protected static RUnityEngine.RTextCore.RText.ROffset r_k_ZeroOffset;
		public static RUnityEngine.RTextCore.RText.ROffset Rk_ZeroOffset
		{
			get
			{
				if(r_k_ZeroOffset == null)
				{
					r_k_ZeroOffset = new( ReleactionUtils.GetType("UnityEngine.TextCore.Text.Offset"), "k_ZeroOffset");
					r_k_ZeroOffset.SetBelong(null);
				}
				return r_k_ZeroOffset;
			}
		}

		/// <summary>
		/// Single left
		/// </summary>
		protected RProperty r_left;
		public virtual RProperty Rleft
		{
			get
			{
				if(r_left == null)
				{
					r_left = new(this, "left", -1);
					r_left.SetBelong(this.instance);
				}
				return r_left;
			}
		}

		/// <summary>
		/// Single right
		/// </summary>
		protected RProperty r_right;
		public virtual RProperty Rright
		{
			get
			{
				if(r_right == null)
				{
					r_right = new(this, "right", -1);
					r_right.SetBelong(this.instance);
				}
				return r_right;
			}
		}

		/// <summary>
		/// Single top
		/// </summary>
		protected RProperty r_top;
		public virtual RProperty Rtop
		{
			get
			{
				if(r_top == null)
				{
					r_top = new(this, "top", -1);
					r_top.SetBelong(this.instance);
				}
				return r_top;
			}
		}

		/// <summary>
		/// Single bottom
		/// </summary>
		protected RProperty r_bottom;
		public virtual RProperty Rbottom
		{
			get
			{
				if(r_bottom == null)
				{
					r_bottom = new(this, "bottom", -1);
					r_bottom.SetBelong(this.instance);
				}
				return r_bottom;
			}
		}

		/// <summary>
		/// Single horizontal
		/// </summary>
		protected RProperty r_horizontal;
		public virtual RProperty Rhorizontal
		{
			get
			{
				if(r_horizontal == null)
				{
					r_horizontal = new(this, "horizontal", -1);
					r_horizontal.SetBelong(this.instance);
				}
				return r_horizontal;
			}
		}

		/// <summary>
		/// Single vertical
		/// </summary>
		protected RProperty r_vertical;
		public virtual RProperty Rvertical
		{
			get
			{
				if(r_vertical == null)
				{
					r_vertical = new(this, "vertical", -1);
					r_vertical.SetBelong(this.instance);
				}
				return r_vertical;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.Offset zero
		/// </summary>
		protected static RUnityEngine.RTextCore.RText.ROffset r_zero;
		public static RUnityEngine.RTextCore.RText.ROffset Rzero
		{
			get
			{
				if(r_zero == null)
				{
					r_zero = new( ReleactionUtils.GetType("UnityEngine.TextCore.Text.Offset"), "zero", -1);
					r_zero.SetBelong(null);
				}
				return r_zero;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.TextCore.Text.Offset, UnityEngine.TextCore.Text.Offset)
		/// </summary>
		protected static RMethod r_Rop_Equality_Offset_Offset;
		public static RMethod Rop_Equality_Offset_Offset
		{
			get
			{
				if(r_Rop_Equality_Offset_Offset == null)
				{
					r_Rop_Equality_Offset_Offset = new( ReleactionUtils.GetType("UnityEngine.TextCore.Text.Offset"), "op_Equality", 0,  ReleactionUtils.GetType("UnityEngine.TextCore.Text.Offset"),  ReleactionUtils.GetType("UnityEngine.TextCore.Text.Offset"));
					r_Rop_Equality_Offset_Offset.SetBelong(null);
				}
				return r_Rop_Equality_Offset_Offset;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.TextCore.Text.Offset, UnityEngine.TextCore.Text.Offset)
		/// </summary>
		protected static RMethod r_Rop_Inequality_Offset_Offset;
		public static RMethod Rop_Inequality_Offset_Offset
		{
			get
			{
				if(r_Rop_Inequality_Offset_Offset == null)
				{
					r_Rop_Inequality_Offset_Offset = new( ReleactionUtils.GetType("UnityEngine.TextCore.Text.Offset"), "op_Inequality", 0,  ReleactionUtils.GetType("UnityEngine.TextCore.Text.Offset"),  ReleactionUtils.GetType("UnityEngine.TextCore.Text.Offset"));
					r_Rop_Inequality_Offset_Offset.SetBelong(null);
				}
				return r_Rop_Inequality_Offset_Offset;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.Offset op_Multiply(UnityEngine.TextCore.Text.Offset, Single)
		/// </summary>
		protected static RMethod r_Rop_Multiply_Offset_Single;
		public static RMethod Rop_Multiply_Offset_Single
		{
			get
			{
				if(r_Rop_Multiply_Offset_Single == null)
				{
					r_Rop_Multiply_Offset_Single = new( ReleactionUtils.GetType("UnityEngine.TextCore.Text.Offset"), "op_Multiply", 0,  ReleactionUtils.GetType("UnityEngine.TextCore.Text.Offset"), typeof(System.Single));
					r_Rop_Multiply_Offset_Single.SetBelong(null);
				}
				return r_Rop_Multiply_Offset_Single;
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
		/// Boolean Equals(UnityEngine.TextCore.Text.Offset)
		/// </summary>
		protected RMethod r_REquals_Offset;
		public virtual RMethod REquals_Offset
		{
			get
			{
				if(r_REquals_Offset == null)
				{
					r_REquals_Offset = new(this, "Equals", 0,  ReleactionUtils.GetType("UnityEngine.TextCore.Text.Offset"));
					r_REquals_Offset.SetBelong(this.instance);
				}
				return r_REquals_Offset;
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
