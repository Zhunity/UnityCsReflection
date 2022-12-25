using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Vector3Int
	/// </summary>
    public partial class RVector3Int : RMember //
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
		/// System.Int32 m_Z
		/// </summary>
		protected RField r_m_Z;
		public virtual RField Rm_Z
		{
			get
			{
				if(r_m_Z == null)
				{
					r_m_Z = new(this, "m_Z");
					r_m_Z.SetBelong(this.instance);
				}
				return r_m_Z;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int s_Zero
		/// </summary>
		protected static RUnityEngine.RVector3Int r_s_Zero;
		public static RUnityEngine.RVector3Int Rs_Zero
		{
			get
			{
				if(r_s_Zero == null)
				{
					r_s_Zero = new(typeof(UnityEngine.Vector3Int), "s_Zero");
					r_s_Zero.SetBelong(null);
				}
				return r_s_Zero;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int s_One
		/// </summary>
		protected static RUnityEngine.RVector3Int r_s_One;
		public static RUnityEngine.RVector3Int Rs_One
		{
			get
			{
				if(r_s_One == null)
				{
					r_s_One = new(typeof(UnityEngine.Vector3Int), "s_One");
					r_s_One.SetBelong(null);
				}
				return r_s_One;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int s_Up
		/// </summary>
		protected static RUnityEngine.RVector3Int r_s_Up;
		public static RUnityEngine.RVector3Int Rs_Up
		{
			get
			{
				if(r_s_Up == null)
				{
					r_s_Up = new(typeof(UnityEngine.Vector3Int), "s_Up");
					r_s_Up.SetBelong(null);
				}
				return r_s_Up;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int s_Down
		/// </summary>
		protected static RUnityEngine.RVector3Int r_s_Down;
		public static RUnityEngine.RVector3Int Rs_Down
		{
			get
			{
				if(r_s_Down == null)
				{
					r_s_Down = new(typeof(UnityEngine.Vector3Int), "s_Down");
					r_s_Down.SetBelong(null);
				}
				return r_s_Down;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int s_Left
		/// </summary>
		protected static RUnityEngine.RVector3Int r_s_Left;
		public static RUnityEngine.RVector3Int Rs_Left
		{
			get
			{
				if(r_s_Left == null)
				{
					r_s_Left = new(typeof(UnityEngine.Vector3Int), "s_Left");
					r_s_Left.SetBelong(null);
				}
				return r_s_Left;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int s_Right
		/// </summary>
		protected static RUnityEngine.RVector3Int r_s_Right;
		public static RUnityEngine.RVector3Int Rs_Right
		{
			get
			{
				if(r_s_Right == null)
				{
					r_s_Right = new(typeof(UnityEngine.Vector3Int), "s_Right");
					r_s_Right.SetBelong(null);
				}
				return r_s_Right;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int s_Forward
		/// </summary>
		protected static RUnityEngine.RVector3Int r_s_Forward;
		public static RUnityEngine.RVector3Int Rs_Forward
		{
			get
			{
				if(r_s_Forward == null)
				{
					r_s_Forward = new(typeof(UnityEngine.Vector3Int), "s_Forward");
					r_s_Forward.SetBelong(null);
				}
				return r_s_Forward;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int s_Back
		/// </summary>
		protected static RUnityEngine.RVector3Int r_s_Back;
		public static RUnityEngine.RVector3Int Rs_Back
		{
			get
			{
				if(r_s_Back == null)
				{
					r_s_Back = new(typeof(UnityEngine.Vector3Int), "s_Back");
					r_s_Back.SetBelong(null);
				}
				return r_s_Back;
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
		/// Int32 z
		/// </summary>
		protected RProperty r_z;
		public virtual RProperty Rz
		{
			get
			{
				if(r_z == null)
				{
					r_z = new(this, "z", -1);
					r_z.SetBelong(this.instance);
				}
				return r_z;
			}
		}

		/// <summary>
		/// Int32 Item [Int32]
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
		/// Single magnitude
		/// </summary>
		protected RProperty r_magnitude;
		public virtual RProperty Rmagnitude
		{
			get
			{
				if(r_magnitude == null)
				{
					r_magnitude = new(this, "magnitude", -1);
					r_magnitude.SetBelong(this.instance);
				}
				return r_magnitude;
			}
		}

		/// <summary>
		/// Int32 sqrMagnitude
		/// </summary>
		protected RProperty r_sqrMagnitude;
		public virtual RProperty RsqrMagnitude
		{
			get
			{
				if(r_sqrMagnitude == null)
				{
					r_sqrMagnitude = new(this, "sqrMagnitude", -1);
					r_sqrMagnitude.SetBelong(this.instance);
				}
				return r_sqrMagnitude;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int zero
		/// </summary>
		protected static RUnityEngine.RVector3Int r_zero;
		public static RUnityEngine.RVector3Int Rzero
		{
			get
			{
				if(r_zero == null)
				{
					r_zero = new(typeof(UnityEngine.Vector3Int), "zero", -1);
					r_zero.SetBelong(null);
				}
				return r_zero;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int one
		/// </summary>
		protected static RUnityEngine.RVector3Int r_one;
		public static RUnityEngine.RVector3Int Rone
		{
			get
			{
				if(r_one == null)
				{
					r_one = new(typeof(UnityEngine.Vector3Int), "one", -1);
					r_one.SetBelong(null);
				}
				return r_one;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int up
		/// </summary>
		protected static RUnityEngine.RVector3Int r_up;
		public static RUnityEngine.RVector3Int Rup
		{
			get
			{
				if(r_up == null)
				{
					r_up = new(typeof(UnityEngine.Vector3Int), "up", -1);
					r_up.SetBelong(null);
				}
				return r_up;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int down
		/// </summary>
		protected static RUnityEngine.RVector3Int r_down;
		public static RUnityEngine.RVector3Int Rdown
		{
			get
			{
				if(r_down == null)
				{
					r_down = new(typeof(UnityEngine.Vector3Int), "down", -1);
					r_down.SetBelong(null);
				}
				return r_down;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int left
		/// </summary>
		protected static RUnityEngine.RVector3Int r_left;
		public static RUnityEngine.RVector3Int Rleft
		{
			get
			{
				if(r_left == null)
				{
					r_left = new(typeof(UnityEngine.Vector3Int), "left", -1);
					r_left.SetBelong(null);
				}
				return r_left;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int right
		/// </summary>
		protected static RUnityEngine.RVector3Int r_right;
		public static RUnityEngine.RVector3Int Rright
		{
			get
			{
				if(r_right == null)
				{
					r_right = new(typeof(UnityEngine.Vector3Int), "right", -1);
					r_right.SetBelong(null);
				}
				return r_right;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int forward
		/// </summary>
		protected static RUnityEngine.RVector3Int r_forward;
		public static RUnityEngine.RVector3Int Rforward
		{
			get
			{
				if(r_forward == null)
				{
					r_forward = new(typeof(UnityEngine.Vector3Int), "forward", -1);
					r_forward.SetBelong(null);
				}
				return r_forward;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int back
		/// </summary>
		protected static RUnityEngine.RVector3Int r_back;
		public static RUnityEngine.RVector3Int Rback
		{
			get
			{
				if(r_back == null)
				{
					r_back = new(typeof(UnityEngine.Vector3Int), "back", -1);
					r_back.SetBelong(null);
				}
				return r_back;
			}
		}

		/// <summary>
		/// Void Set(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RSet_Int32_Int32_Int32;
		public virtual RMethod RSet_Int32_Int32_Int32
		{
			get
			{
				if(r_RSet_Int32_Int32_Int32 == null)
				{
					r_RSet_Int32_Int32_Int32 = new(this, "Set", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RSet_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSet_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Single Distance(UnityEngine.Vector3Int, UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_RDistance_Vector3Int_Vector3Int;
		public static RMethod RDistance_Vector3Int_Vector3Int
		{
			get
			{
				if(r_RDistance_Vector3Int_Vector3Int == null)
				{
					r_RDistance_Vector3Int_Vector3Int = new(typeof(UnityEngine.Vector3Int), "Distance", 0, typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int));
					r_RDistance_Vector3Int_Vector3Int.SetBelong(null);
				}
				return r_RDistance_Vector3Int_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int Min(UnityEngine.Vector3Int, UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_RMin_Vector3Int_Vector3Int;
		public static RMethod RMin_Vector3Int_Vector3Int
		{
			get
			{
				if(r_RMin_Vector3Int_Vector3Int == null)
				{
					r_RMin_Vector3Int_Vector3Int = new(typeof(UnityEngine.Vector3Int), "Min", 0, typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int));
					r_RMin_Vector3Int_Vector3Int.SetBelong(null);
				}
				return r_RMin_Vector3Int_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int Max(UnityEngine.Vector3Int, UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_RMax_Vector3Int_Vector3Int;
		public static RMethod RMax_Vector3Int_Vector3Int
		{
			get
			{
				if(r_RMax_Vector3Int_Vector3Int == null)
				{
					r_RMax_Vector3Int_Vector3Int = new(typeof(UnityEngine.Vector3Int), "Max", 0, typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int));
					r_RMax_Vector3Int_Vector3Int.SetBelong(null);
				}
				return r_RMax_Vector3Int_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int Scale(UnityEngine.Vector3Int, UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_RScale_Vector3Int_Vector3Int;
		public static RMethod RScale_Vector3Int_Vector3Int
		{
			get
			{
				if(r_RScale_Vector3Int_Vector3Int == null)
				{
					r_RScale_Vector3Int_Vector3Int = new(typeof(UnityEngine.Vector3Int), "Scale", 0, typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int));
					r_RScale_Vector3Int_Vector3Int.SetBelong(null);
				}
				return r_RScale_Vector3Int_Vector3Int;
			}
		}

		/// <summary>
		/// Void Scale(UnityEngine.Vector3Int)
		/// </summary>
		protected RMethod r_RScale_Vector3Int;
		public virtual RMethod RScale_Vector3Int
		{
			get
			{
				if(r_RScale_Vector3Int == null)
				{
					r_RScale_Vector3Int = new(this, "Scale", 0, typeof(UnityEngine.Vector3Int));
					r_RScale_Vector3Int.SetBelong(this.instance);
				}
				return r_RScale_Vector3Int;
			}
		}

		/// <summary>
		/// Void Clamp(UnityEngine.Vector3Int, UnityEngine.Vector3Int)
		/// </summary>
		protected RMethod r_RClamp_Vector3Int_Vector3Int;
		public virtual RMethod RClamp_Vector3Int_Vector3Int
		{
			get
			{
				if(r_RClamp_Vector3Int_Vector3Int == null)
				{
					r_RClamp_Vector3Int_Vector3Int = new(this, "Clamp", 0, typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int));
					r_RClamp_Vector3Int_Vector3Int.SetBelong(this.instance);
				}
				return r_RClamp_Vector3Int_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 op_Implicit(UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Vector3Int;
		public static RMethod Rop_Implicit_Vector3Int
		{
			get
			{
				if(r_Rop_Implicit_Vector3Int == null)
				{
					r_Rop_Implicit_Vector3Int = new(typeof(UnityEngine.Vector3Int), "op_Implicit", 0, typeof(UnityEngine.Vector3Int));
					r_Rop_Implicit_Vector3Int.SetBelong(null);
				}
				return r_Rop_Implicit_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int op_Explicit(UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_Rop_Explicit_Vector3Int;
		public static RMethod Rop_Explicit_Vector3Int
		{
			get
			{
				if(r_Rop_Explicit_Vector3Int == null)
				{
					r_Rop_Explicit_Vector3Int = new(typeof(UnityEngine.Vector3Int), "op_Explicit", 0, typeof(UnityEngine.Vector3Int));
					r_Rop_Explicit_Vector3Int.SetBelong(null);
				}
				return r_Rop_Explicit_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int FloorToInt(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RFloorToInt_Vector3;
		public static RMethod RFloorToInt_Vector3
		{
			get
			{
				if(r_RFloorToInt_Vector3 == null)
				{
					r_RFloorToInt_Vector3 = new(typeof(UnityEngine.Vector3Int), "FloorToInt", 0, typeof(UnityEngine.Vector3));
					r_RFloorToInt_Vector3.SetBelong(null);
				}
				return r_RFloorToInt_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int CeilToInt(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RCeilToInt_Vector3;
		public static RMethod RCeilToInt_Vector3
		{
			get
			{
				if(r_RCeilToInt_Vector3 == null)
				{
					r_RCeilToInt_Vector3 = new(typeof(UnityEngine.Vector3Int), "CeilToInt", 0, typeof(UnityEngine.Vector3));
					r_RCeilToInt_Vector3.SetBelong(null);
				}
				return r_RCeilToInt_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int RoundToInt(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RRoundToInt_Vector3;
		public static RMethod RRoundToInt_Vector3
		{
			get
			{
				if(r_RRoundToInt_Vector3 == null)
				{
					r_RRoundToInt_Vector3 = new(typeof(UnityEngine.Vector3Int), "RoundToInt", 0, typeof(UnityEngine.Vector3));
					r_RRoundToInt_Vector3.SetBelong(null);
				}
				return r_RRoundToInt_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int op_Addition(UnityEngine.Vector3Int, UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_Rop_Addition_Vector3Int_Vector3Int;
		public static RMethod Rop_Addition_Vector3Int_Vector3Int
		{
			get
			{
				if(r_Rop_Addition_Vector3Int_Vector3Int == null)
				{
					r_Rop_Addition_Vector3Int_Vector3Int = new(typeof(UnityEngine.Vector3Int), "op_Addition", 0, typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int));
					r_Rop_Addition_Vector3Int_Vector3Int.SetBelong(null);
				}
				return r_Rop_Addition_Vector3Int_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int op_Subtraction(UnityEngine.Vector3Int, UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_Rop_Subtraction_Vector3Int_Vector3Int;
		public static RMethod Rop_Subtraction_Vector3Int_Vector3Int
		{
			get
			{
				if(r_Rop_Subtraction_Vector3Int_Vector3Int == null)
				{
					r_Rop_Subtraction_Vector3Int_Vector3Int = new(typeof(UnityEngine.Vector3Int), "op_Subtraction", 0, typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int));
					r_Rop_Subtraction_Vector3Int_Vector3Int.SetBelong(null);
				}
				return r_Rop_Subtraction_Vector3Int_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int op_Multiply(UnityEngine.Vector3Int, UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_Rop_Multiply_Vector3Int_Vector3Int;
		public static RMethod Rop_Multiply_Vector3Int_Vector3Int
		{
			get
			{
				if(r_Rop_Multiply_Vector3Int_Vector3Int == null)
				{
					r_Rop_Multiply_Vector3Int_Vector3Int = new(typeof(UnityEngine.Vector3Int), "op_Multiply", 0, typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int));
					r_Rop_Multiply_Vector3Int_Vector3Int.SetBelong(null);
				}
				return r_Rop_Multiply_Vector3Int_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int op_UnaryNegation(UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_Rop_UnaryNegation_Vector3Int;
		public static RMethod Rop_UnaryNegation_Vector3Int
		{
			get
			{
				if(r_Rop_UnaryNegation_Vector3Int == null)
				{
					r_Rop_UnaryNegation_Vector3Int = new(typeof(UnityEngine.Vector3Int), "op_UnaryNegation", 0, typeof(UnityEngine.Vector3Int));
					r_Rop_UnaryNegation_Vector3Int.SetBelong(null);
				}
				return r_Rop_UnaryNegation_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int op_Multiply(UnityEngine.Vector3Int, Int32)
		/// </summary>
		protected static RMethod r_Rop_Multiply_Vector3Int_Int32;
		public static RMethod Rop_Multiply_Vector3Int_Int32
		{
			get
			{
				if(r_Rop_Multiply_Vector3Int_Int32 == null)
				{
					r_Rop_Multiply_Vector3Int_Int32 = new(typeof(UnityEngine.Vector3Int), "op_Multiply", 0, typeof(UnityEngine.Vector3Int), typeof(System.Int32));
					r_Rop_Multiply_Vector3Int_Int32.SetBelong(null);
				}
				return r_Rop_Multiply_Vector3Int_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int op_Multiply(Int32, UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_Rop_Multiply_Int32_Vector3Int;
		public static RMethod Rop_Multiply_Int32_Vector3Int
		{
			get
			{
				if(r_Rop_Multiply_Int32_Vector3Int == null)
				{
					r_Rop_Multiply_Int32_Vector3Int = new(typeof(UnityEngine.Vector3Int), "op_Multiply", 0, typeof(System.Int32), typeof(UnityEngine.Vector3Int));
					r_Rop_Multiply_Int32_Vector3Int.SetBelong(null);
				}
				return r_Rop_Multiply_Int32_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int op_Division(UnityEngine.Vector3Int, Int32)
		/// </summary>
		protected static RMethod r_Rop_Division_Vector3Int_Int32;
		public static RMethod Rop_Division_Vector3Int_Int32
		{
			get
			{
				if(r_Rop_Division_Vector3Int_Int32 == null)
				{
					r_Rop_Division_Vector3Int_Int32 = new(typeof(UnityEngine.Vector3Int), "op_Division", 0, typeof(UnityEngine.Vector3Int), typeof(System.Int32));
					r_Rop_Division_Vector3Int_Int32.SetBelong(null);
				}
				return r_Rop_Division_Vector3Int_Int32;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Vector3Int, UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_Rop_Equality_Vector3Int_Vector3Int;
		public static RMethod Rop_Equality_Vector3Int_Vector3Int
		{
			get
			{
				if(r_Rop_Equality_Vector3Int_Vector3Int == null)
				{
					r_Rop_Equality_Vector3Int_Vector3Int = new(typeof(UnityEngine.Vector3Int), "op_Equality", 0, typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int));
					r_Rop_Equality_Vector3Int_Vector3Int.SetBelong(null);
				}
				return r_Rop_Equality_Vector3Int_Vector3Int;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Vector3Int, UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_Rop_Inequality_Vector3Int_Vector3Int;
		public static RMethod Rop_Inequality_Vector3Int_Vector3Int
		{
			get
			{
				if(r_Rop_Inequality_Vector3Int_Vector3Int == null)
				{
					r_Rop_Inequality_Vector3Int_Vector3Int = new(typeof(UnityEngine.Vector3Int), "op_Inequality", 0, typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int));
					r_Rop_Inequality_Vector3Int_Vector3Int.SetBelong(null);
				}
				return r_Rop_Inequality_Vector3Int_Vector3Int;
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
		/// Boolean Equals(UnityEngine.Vector3Int)
		/// </summary>
		protected RMethod r_REquals_Vector3Int;
		public virtual RMethod REquals_Vector3Int
		{
			get
			{
				if(r_REquals_Vector3Int == null)
				{
					r_REquals_Vector3Int = new(this, "Equals", 0, typeof(UnityEngine.Vector3Int));
					r_REquals_Vector3Int.SetBelong(this.instance);
				}
				return r_REquals_Vector3Int;
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


        public RVector3Int() : base("UnityEngine.Vector3Int")
        {
        }

        public RVector3Int(System.Object instance) : base("UnityEngine.Vector3Int")
		{
            SetInstance(instance);
		}

        public RVector3Int(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVector3Int(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Set(System.Int32  @x, System.Int32  @y, System.Int32  @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RSet_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Single Distance(UnityEngine.Vector3Int  @a, UnityEngine.Vector3Int  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RDistance_Vector3Int_Vector3Int.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector3Int Min(UnityEngine.Vector3Int  @lhs, UnityEngine.Vector3Int  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMin_Vector3Int_Vector3Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector3Int Max(UnityEngine.Vector3Int  @lhs, UnityEngine.Vector3Int  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMax_Vector3Int_Vector3Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector3Int Scale(UnityEngine.Vector3Int  @a, UnityEngine.Vector3Int  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RScale_Vector3Int_Vector3Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public virtual void Scale(UnityEngine.Vector3Int  @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scale};
            var ___result = RScale_Vector3Int.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clamp(UnityEngine.Vector3Int  @min, UnityEngine.Vector3Int  @max)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@min, @max};
            var ___result = RClamp_Vector3Int_Vector3Int.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Vector3 op_Implicit(UnityEngine.Vector3Int  @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = Rop_Implicit_Vector3Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector2Int op_Explicit(UnityEngine.Vector3Int  @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = Rop_Explicit_Vector3Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector3Int FloorToInt(UnityEngine.Vector3  @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RFloorToInt_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector3Int CeilToInt(UnityEngine.Vector3  @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RCeilToInt_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector3Int RoundToInt(UnityEngine.Vector3  @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RRoundToInt_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector3Int op_Addition(UnityEngine.Vector3Int  @a, UnityEngine.Vector3Int  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Addition_Vector3Int_Vector3Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector3Int op_Subtraction(UnityEngine.Vector3Int  @a, UnityEngine.Vector3Int  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Subtraction_Vector3Int_Vector3Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector3Int op_Multiply(UnityEngine.Vector3Int  @a, UnityEngine.Vector3Int  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Multiply_Vector3Int_Vector3Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector3Int op_UnaryNegation(UnityEngine.Vector3Int  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = Rop_UnaryNegation_Vector3Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector3Int op_Multiply(UnityEngine.Vector3Int  @a, System.Int32  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Multiply_Vector3Int_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector3Int op_Multiply(System.Int32  @a, UnityEngine.Vector3Int  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Multiply_Int32_Vector3Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector3Int op_Division(UnityEngine.Vector3Int  @a, System.Int32  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Division_Vector3Int_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Vector3Int  @lhs, UnityEngine.Vector3Int  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Equality_Vector3Int_Vector3Int.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Vector3Int  @lhs, UnityEngine.Vector3Int  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = Rop_Inequality_Vector3Int_Vector3Int.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Vector3Int  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Vector3Int.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
