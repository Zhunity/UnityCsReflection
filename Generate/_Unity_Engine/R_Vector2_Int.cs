
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Vector2Int
	/// </summary>
    public partial class RVector2Int : RMember //
    {

		/// <summary>
		/// System.Int32 m_X
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_X;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_X
		{
			get
			{
				if(r_Fm_X == null)
				{
					r_Fm_X = new(this, "m_X");
					r_Fm_X.SetBelong(this.instance);
				}
				return r_Fm_X;
			}
		}

		/// <summary>
		/// System.Int32 m_Y
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_Y;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_Y
		{
			get
			{
				if(r_Fm_Y == null)
				{
					r_Fm_Y = new(this, "m_Y");
					r_Fm_Y.SetBelong(this.instance);
				}
				return r_Fm_Y;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int s_Zero
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_Fs_Zero;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RFs_Zero
		{
			get
			{
				if(r_Fs_Zero == null)
				{
					r_Fs_Zero = new(typeof(UnityEngine.Vector2Int), "s_Zero");
					r_Fs_Zero.SetBelong(null);
				}
				return r_Fs_Zero;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int s_One
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_Fs_One;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RFs_One
		{
			get
			{
				if(r_Fs_One == null)
				{
					r_Fs_One = new(typeof(UnityEngine.Vector2Int), "s_One");
					r_Fs_One.SetBelong(null);
				}
				return r_Fs_One;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int s_Up
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_Fs_Up;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RFs_Up
		{
			get
			{
				if(r_Fs_Up == null)
				{
					r_Fs_Up = new(typeof(UnityEngine.Vector2Int), "s_Up");
					r_Fs_Up.SetBelong(null);
				}
				return r_Fs_Up;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int s_Down
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_Fs_Down;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RFs_Down
		{
			get
			{
				if(r_Fs_Down == null)
				{
					r_Fs_Down = new(typeof(UnityEngine.Vector2Int), "s_Down");
					r_Fs_Down.SetBelong(null);
				}
				return r_Fs_Down;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int s_Left
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_Fs_Left;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RFs_Left
		{
			get
			{
				if(r_Fs_Left == null)
				{
					r_Fs_Left = new(typeof(UnityEngine.Vector2Int), "s_Left");
					r_Fs_Left.SetBelong(null);
				}
				return r_Fs_Left;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int s_Right
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_Fs_Right;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RFs_Right
		{
			get
			{
				if(r_Fs_Right == null)
				{
					r_Fs_Right = new(typeof(UnityEngine.Vector2Int), "s_Right");
					r_Fs_Right.SetBelong(null);
				}
				return r_Fs_Right;
			}
		}

		/// <summary>
		/// Int32 x
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Px;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPx
		{
			get
			{
				if(r_Px == null)
				{
					r_Px = new(this, "x", -1);
					r_Px.SetBelong(this.instance);
				}
				return r_Px;
			}
		}

		/// <summary>
		/// Int32 y
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Py;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPy
		{
			get
			{
				if(r_Py == null)
				{
					r_Py = new(this, "y", -1);
					r_Py.SetBelong(this.instance);
				}
				return r_Py;
			}
		}

		/// <summary>
		/// Int32 Item [Int32]
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PItem_Int32;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPItem_Int32
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
		/// Single magnitude
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_Pmagnitude;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RPmagnitude
		{
			get
			{
				if(r_Pmagnitude == null)
				{
					r_Pmagnitude = new(this, "magnitude", -1);
					r_Pmagnitude.SetBelong(this.instance);
				}
				return r_Pmagnitude;
			}
		}

		/// <summary>
		/// Int32 sqrMagnitude
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PsqrMagnitude;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPsqrMagnitude
		{
			get
			{
				if(r_PsqrMagnitude == null)
				{
					r_PsqrMagnitude = new(this, "sqrMagnitude", -1);
					r_PsqrMagnitude.SetBelong(this.instance);
				}
				return r_PsqrMagnitude;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int zero
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_Pzero;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RPzero
		{
			get
			{
				if(r_Pzero == null)
				{
					r_Pzero = new(typeof(UnityEngine.Vector2Int), "zero", -1);
					r_Pzero.SetBelong(null);
				}
				return r_Pzero;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int one
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_Pone;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RPone
		{
			get
			{
				if(r_Pone == null)
				{
					r_Pone = new(typeof(UnityEngine.Vector2Int), "one", -1);
					r_Pone.SetBelong(null);
				}
				return r_Pone;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int up
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_Pup;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RPup
		{
			get
			{
				if(r_Pup == null)
				{
					r_Pup = new(typeof(UnityEngine.Vector2Int), "up", -1);
					r_Pup.SetBelong(null);
				}
				return r_Pup;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int down
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_Pdown;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RPdown
		{
			get
			{
				if(r_Pdown == null)
				{
					r_Pdown = new(typeof(UnityEngine.Vector2Int), "down", -1);
					r_Pdown.SetBelong(null);
				}
				return r_Pdown;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int left
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_Pleft;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RPleft
		{
			get
			{
				if(r_Pleft == null)
				{
					r_Pleft = new(typeof(UnityEngine.Vector2Int), "left", -1);
					r_Pleft.SetBelong(null);
				}
				return r_Pleft;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int right
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int r_Pright;
		public static SMFrame.Editor.Refleaction.RUnityEngine.RVector2Int RPright
		{
			get
			{
				if(r_Pright == null)
				{
					r_Pright = new(typeof(UnityEngine.Vector2Int), "right", -1);
					r_Pright.SetBelong(null);
				}
				return r_Pright;
			}
		}

		/// <summary>
		/// Void Set(Int32, Int32)
		/// </summary>
		protected RMethod r_MSet_Int32_Int32;
		public virtual RMethod RMSet_Int32_Int32
		{
			get
			{
				if(r_MSet_Int32_Int32 == null)
				{
					r_MSet_Int32_Int32 = new(this, "Set", 0, typeof(System.Int32), typeof(System.Int32));
					r_MSet_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSet_Int32_Int32;
			}
		}

		/// <summary>
		/// Single Distance(UnityEngine.Vector2Int, UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_MDistance_Vector2Int_Vector2Int;
		public static RMethod RMDistance_Vector2Int_Vector2Int
		{
			get
			{
				if(r_MDistance_Vector2Int_Vector2Int == null)
				{
					r_MDistance_Vector2Int_Vector2Int = new(typeof(UnityEngine.Vector2Int), "Distance", 0, typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int));
					r_MDistance_Vector2Int_Vector2Int.SetBelong(null);
				}
				return r_MDistance_Vector2Int_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int Min(UnityEngine.Vector2Int, UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_MMin_Vector2Int_Vector2Int;
		public static RMethod RMMin_Vector2Int_Vector2Int
		{
			get
			{
				if(r_MMin_Vector2Int_Vector2Int == null)
				{
					r_MMin_Vector2Int_Vector2Int = new(typeof(UnityEngine.Vector2Int), "Min", 0, typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int));
					r_MMin_Vector2Int_Vector2Int.SetBelong(null);
				}
				return r_MMin_Vector2Int_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int Max(UnityEngine.Vector2Int, UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_MMax_Vector2Int_Vector2Int;
		public static RMethod RMMax_Vector2Int_Vector2Int
		{
			get
			{
				if(r_MMax_Vector2Int_Vector2Int == null)
				{
					r_MMax_Vector2Int_Vector2Int = new(typeof(UnityEngine.Vector2Int), "Max", 0, typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int));
					r_MMax_Vector2Int_Vector2Int.SetBelong(null);
				}
				return r_MMax_Vector2Int_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int Scale(UnityEngine.Vector2Int, UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_MScale_Vector2Int_Vector2Int;
		public static RMethod RMScale_Vector2Int_Vector2Int
		{
			get
			{
				if(r_MScale_Vector2Int_Vector2Int == null)
				{
					r_MScale_Vector2Int_Vector2Int = new(typeof(UnityEngine.Vector2Int), "Scale", 0, typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int));
					r_MScale_Vector2Int_Vector2Int.SetBelong(null);
				}
				return r_MScale_Vector2Int_Vector2Int;
			}
		}

		/// <summary>
		/// Void Scale(UnityEngine.Vector2Int)
		/// </summary>
		protected RMethod r_MScale_Vector2Int;
		public virtual RMethod RMScale_Vector2Int
		{
			get
			{
				if(r_MScale_Vector2Int == null)
				{
					r_MScale_Vector2Int = new(this, "Scale", 0, typeof(UnityEngine.Vector2Int));
					r_MScale_Vector2Int.SetBelong(this.instance);
				}
				return r_MScale_Vector2Int;
			}
		}

		/// <summary>
		/// Void Clamp(UnityEngine.Vector2Int, UnityEngine.Vector2Int)
		/// </summary>
		protected RMethod r_MClamp_Vector2Int_Vector2Int;
		public virtual RMethod RMClamp_Vector2Int_Vector2Int
		{
			get
			{
				if(r_MClamp_Vector2Int_Vector2Int == null)
				{
					r_MClamp_Vector2Int_Vector2Int = new(this, "Clamp", 0, typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int));
					r_MClamp_Vector2Int_Vector2Int.SetBelong(this.instance);
				}
				return r_MClamp_Vector2Int_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 op_Implicit(UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Vector2Int;
		public static RMethod RMop_Implicit_Vector2Int
		{
			get
			{
				if(r_Mop_Implicit_Vector2Int == null)
				{
					r_Mop_Implicit_Vector2Int = new(typeof(UnityEngine.Vector2Int), "op_Implicit", 0, typeof(UnityEngine.Vector2Int));
					r_Mop_Implicit_Vector2Int.SetBelong(null);
				}
				return r_Mop_Implicit_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int op_Explicit(UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_Mop_Explicit_Vector2Int;
		public static RMethod RMop_Explicit_Vector2Int
		{
			get
			{
				if(r_Mop_Explicit_Vector2Int == null)
				{
					r_Mop_Explicit_Vector2Int = new(typeof(UnityEngine.Vector2Int), "op_Explicit", 0, typeof(UnityEngine.Vector2Int));
					r_Mop_Explicit_Vector2Int.SetBelong(null);
				}
				return r_Mop_Explicit_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int FloorToInt(UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_MFloorToInt_Vector2;
		public static RMethod RMFloorToInt_Vector2
		{
			get
			{
				if(r_MFloorToInt_Vector2 == null)
				{
					r_MFloorToInt_Vector2 = new(typeof(UnityEngine.Vector2Int), "FloorToInt", 0, typeof(UnityEngine.Vector2));
					r_MFloorToInt_Vector2.SetBelong(null);
				}
				return r_MFloorToInt_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int CeilToInt(UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_MCeilToInt_Vector2;
		public static RMethod RMCeilToInt_Vector2
		{
			get
			{
				if(r_MCeilToInt_Vector2 == null)
				{
					r_MCeilToInt_Vector2 = new(typeof(UnityEngine.Vector2Int), "CeilToInt", 0, typeof(UnityEngine.Vector2));
					r_MCeilToInt_Vector2.SetBelong(null);
				}
				return r_MCeilToInt_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int RoundToInt(UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_MRoundToInt_Vector2;
		public static RMethod RMRoundToInt_Vector2
		{
			get
			{
				if(r_MRoundToInt_Vector2 == null)
				{
					r_MRoundToInt_Vector2 = new(typeof(UnityEngine.Vector2Int), "RoundToInt", 0, typeof(UnityEngine.Vector2));
					r_MRoundToInt_Vector2.SetBelong(null);
				}
				return r_MRoundToInt_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int op_UnaryNegation(UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_Mop_UnaryNegation_Vector2Int;
		public static RMethod RMop_UnaryNegation_Vector2Int
		{
			get
			{
				if(r_Mop_UnaryNegation_Vector2Int == null)
				{
					r_Mop_UnaryNegation_Vector2Int = new(typeof(UnityEngine.Vector2Int), "op_UnaryNegation", 0, typeof(UnityEngine.Vector2Int));
					r_Mop_UnaryNegation_Vector2Int.SetBelong(null);
				}
				return r_Mop_UnaryNegation_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int op_Addition(UnityEngine.Vector2Int, UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_Mop_Addition_Vector2Int_Vector2Int;
		public static RMethod RMop_Addition_Vector2Int_Vector2Int
		{
			get
			{
				if(r_Mop_Addition_Vector2Int_Vector2Int == null)
				{
					r_Mop_Addition_Vector2Int_Vector2Int = new(typeof(UnityEngine.Vector2Int), "op_Addition", 0, typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int));
					r_Mop_Addition_Vector2Int_Vector2Int.SetBelong(null);
				}
				return r_Mop_Addition_Vector2Int_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int op_Subtraction(UnityEngine.Vector2Int, UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_Mop_Subtraction_Vector2Int_Vector2Int;
		public static RMethod RMop_Subtraction_Vector2Int_Vector2Int
		{
			get
			{
				if(r_Mop_Subtraction_Vector2Int_Vector2Int == null)
				{
					r_Mop_Subtraction_Vector2Int_Vector2Int = new(typeof(UnityEngine.Vector2Int), "op_Subtraction", 0, typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int));
					r_Mop_Subtraction_Vector2Int_Vector2Int.SetBelong(null);
				}
				return r_Mop_Subtraction_Vector2Int_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int op_Multiply(UnityEngine.Vector2Int, UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_Mop_Multiply_Vector2Int_Vector2Int;
		public static RMethod RMop_Multiply_Vector2Int_Vector2Int
		{
			get
			{
				if(r_Mop_Multiply_Vector2Int_Vector2Int == null)
				{
					r_Mop_Multiply_Vector2Int_Vector2Int = new(typeof(UnityEngine.Vector2Int), "op_Multiply", 0, typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int));
					r_Mop_Multiply_Vector2Int_Vector2Int.SetBelong(null);
				}
				return r_Mop_Multiply_Vector2Int_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int op_Multiply(Int32, UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_Mop_Multiply_Int32_Vector2Int;
		public static RMethod RMop_Multiply_Int32_Vector2Int
		{
			get
			{
				if(r_Mop_Multiply_Int32_Vector2Int == null)
				{
					r_Mop_Multiply_Int32_Vector2Int = new(typeof(UnityEngine.Vector2Int), "op_Multiply", 0, typeof(System.Int32), typeof(UnityEngine.Vector2Int));
					r_Mop_Multiply_Int32_Vector2Int.SetBelong(null);
				}
				return r_Mop_Multiply_Int32_Vector2Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int op_Multiply(UnityEngine.Vector2Int, Int32)
		/// </summary>
		protected static RMethod r_Mop_Multiply_Vector2Int_Int32;
		public static RMethod RMop_Multiply_Vector2Int_Int32
		{
			get
			{
				if(r_Mop_Multiply_Vector2Int_Int32 == null)
				{
					r_Mop_Multiply_Vector2Int_Int32 = new(typeof(UnityEngine.Vector2Int), "op_Multiply", 0, typeof(UnityEngine.Vector2Int), typeof(System.Int32));
					r_Mop_Multiply_Vector2Int_Int32.SetBelong(null);
				}
				return r_Mop_Multiply_Vector2Int_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int op_Division(UnityEngine.Vector2Int, Int32)
		/// </summary>
		protected static RMethod r_Mop_Division_Vector2Int_Int32;
		public static RMethod RMop_Division_Vector2Int_Int32
		{
			get
			{
				if(r_Mop_Division_Vector2Int_Int32 == null)
				{
					r_Mop_Division_Vector2Int_Int32 = new(typeof(UnityEngine.Vector2Int), "op_Division", 0, typeof(UnityEngine.Vector2Int), typeof(System.Int32));
					r_Mop_Division_Vector2Int_Int32.SetBelong(null);
				}
				return r_Mop_Division_Vector2Int_Int32;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Vector2Int, UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_Mop_Equality_Vector2Int_Vector2Int;
		public static RMethod RMop_Equality_Vector2Int_Vector2Int
		{
			get
			{
				if(r_Mop_Equality_Vector2Int_Vector2Int == null)
				{
					r_Mop_Equality_Vector2Int_Vector2Int = new(typeof(UnityEngine.Vector2Int), "op_Equality", 0, typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int));
					r_Mop_Equality_Vector2Int_Vector2Int.SetBelong(null);
				}
				return r_Mop_Equality_Vector2Int_Vector2Int;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Vector2Int, UnityEngine.Vector2Int)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Vector2Int_Vector2Int;
		public static RMethod RMop_Inequality_Vector2Int_Vector2Int
		{
			get
			{
				if(r_Mop_Inequality_Vector2Int_Vector2Int == null)
				{
					r_Mop_Inequality_Vector2Int_Vector2Int = new(typeof(UnityEngine.Vector2Int), "op_Inequality", 0, typeof(UnityEngine.Vector2Int), typeof(UnityEngine.Vector2Int));
					r_Mop_Inequality_Vector2Int_Vector2Int.SetBelong(null);
				}
				return r_Mop_Inequality_Vector2Int_Vector2Int;
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
		/// Boolean Equals(UnityEngine.Vector2Int)
		/// </summary>
		protected RMethod r_MEquals_Vector2Int;
		public virtual RMethod RMEquals_Vector2Int
		{
			get
			{
				if(r_MEquals_Vector2Int == null)
				{
					r_MEquals_Vector2Int = new(this, "Equals", 0, typeof(UnityEngine.Vector2Int));
					r_MEquals_Vector2Int.SetBelong(this.instance);
				}
				return r_MEquals_Vector2Int;
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


        public RVector2Int() : base("UnityEngine.Vector2Int")
        {
        }

        public RVector2Int(System.Object instance) : base("UnityEngine.Vector2Int")
		{
            SetInstance(instance);
		}

        public RVector2Int(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVector2Int(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Set(System.Int32 @x, System.Int32 @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = RMSet_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Single Distance(UnityEngine.Vector2Int @a, UnityEngine.Vector2Int @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMDistance_Vector2Int_Vector2Int.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector2Int Min(UnityEngine.Vector2Int @lhs, UnityEngine.Vector2Int @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMMin_Vector2Int_Vector2Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector2Int Max(UnityEngine.Vector2Int @lhs, UnityEngine.Vector2Int @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMMax_Vector2Int_Vector2Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector2Int Scale(UnityEngine.Vector2Int @a, UnityEngine.Vector2Int @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMScale_Vector2Int_Vector2Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public virtual void Scale(UnityEngine.Vector2Int @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scale};
            var ___result = RMScale_Vector2Int.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clamp(UnityEngine.Vector2Int @min, UnityEngine.Vector2Int @max)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@min, @max};
            var ___result = RMClamp_Vector2Int_Vector2Int.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Vector2 op_Implicit(UnityEngine.Vector2Int @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMop_Implicit_Vector2Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector3Int op_Explicit(UnityEngine.Vector2Int @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMop_Explicit_Vector2Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector2Int FloorToInt(UnityEngine.Vector2 @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMFloorToInt_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector2Int CeilToInt(UnityEngine.Vector2 @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMCeilToInt_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector2Int RoundToInt(UnityEngine.Vector2 @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMRoundToInt_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector2Int op_UnaryNegation(UnityEngine.Vector2Int @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMop_UnaryNegation_Vector2Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector2Int op_Addition(UnityEngine.Vector2Int @a, UnityEngine.Vector2Int @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Addition_Vector2Int_Vector2Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector2Int op_Subtraction(UnityEngine.Vector2Int @a, UnityEngine.Vector2Int @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Subtraction_Vector2Int_Vector2Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector2Int op_Multiply(UnityEngine.Vector2Int @a, UnityEngine.Vector2Int @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Multiply_Vector2Int_Vector2Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector2Int op_Multiply(System.Int32 @a, UnityEngine.Vector2Int @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Multiply_Int32_Vector2Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector2Int op_Multiply(UnityEngine.Vector2Int @a, System.Int32 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Multiply_Vector2Int_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector2Int op_Division(UnityEngine.Vector2Int @a, System.Int32 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Division_Vector2Int_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Vector2Int @lhs, UnityEngine.Vector2Int @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_Vector2Int_Vector2Int.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Vector2Int @lhs, UnityEngine.Vector2Int @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_Vector2Int_Vector2Int.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Vector2Int @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Vector2Int.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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