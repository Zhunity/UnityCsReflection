
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Vector3Int
	/// </summary>
    public partial class RVector3Int : RMember //
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
		/// System.Int32 m_Z
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Z;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Z
		{
			get
			{
				if(r_Fm_Z == null)
				{
					r_Fm_Z = new(this, "m_Z");
				}
				return r_Fm_Z;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int s_Zero
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int r_Fs_Zero;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int RFs_Zero
		{
			get
			{
				if(r_Fs_Zero == null)
				{
					r_Fs_Zero = new(typeof(UnityEngine.Vector3Int), "s_Zero");
				}
				return r_Fs_Zero;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int s_One
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int r_Fs_One;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int RFs_One
		{
			get
			{
				if(r_Fs_One == null)
				{
					r_Fs_One = new(typeof(UnityEngine.Vector3Int), "s_One");
				}
				return r_Fs_One;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int s_Up
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int r_Fs_Up;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int RFs_Up
		{
			get
			{
				if(r_Fs_Up == null)
				{
					r_Fs_Up = new(typeof(UnityEngine.Vector3Int), "s_Up");
				}
				return r_Fs_Up;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int s_Down
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int r_Fs_Down;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int RFs_Down
		{
			get
			{
				if(r_Fs_Down == null)
				{
					r_Fs_Down = new(typeof(UnityEngine.Vector3Int), "s_Down");
				}
				return r_Fs_Down;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int s_Left
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int r_Fs_Left;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int RFs_Left
		{
			get
			{
				if(r_Fs_Left == null)
				{
					r_Fs_Left = new(typeof(UnityEngine.Vector3Int), "s_Left");
				}
				return r_Fs_Left;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int s_Right
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int r_Fs_Right;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int RFs_Right
		{
			get
			{
				if(r_Fs_Right == null)
				{
					r_Fs_Right = new(typeof(UnityEngine.Vector3Int), "s_Right");
				}
				return r_Fs_Right;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int s_Forward
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int r_Fs_Forward;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int RFs_Forward
		{
			get
			{
				if(r_Fs_Forward == null)
				{
					r_Fs_Forward = new(typeof(UnityEngine.Vector3Int), "s_Forward");
				}
				return r_Fs_Forward;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int s_Back
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int r_Fs_Back;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int RFs_Back
		{
			get
			{
				if(r_Fs_Back == null)
				{
					r_Fs_Back = new(typeof(UnityEngine.Vector3Int), "s_Back");
				}
				return r_Fs_Back;
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
		/// Int32 z
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Pz;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPz
		{
			get
			{
				if(r_Pz == null)
				{
					r_Pz = new(this, "z", -1);
				}
				return r_Pz;
			}
		}

		/// <summary>
		/// Int32 Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PItem_Int32;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPItem_Int32
		{
			get
			{
				if(r_PItem_Int32 == null)
				{
					r_PItem_Int32 = new(this, "Item", -1, typeof(System.Int32));
				}
				return r_PItem_Int32;
			}
		}

		/// <summary>
		/// Single magnitude
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pmagnitude;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPmagnitude
		{
			get
			{
				if(r_Pmagnitude == null)
				{
					r_Pmagnitude = new(this, "magnitude", -1);
				}
				return r_Pmagnitude;
			}
		}

		/// <summary>
		/// Int32 sqrMagnitude
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PsqrMagnitude;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPsqrMagnitude
		{
			get
			{
				if(r_PsqrMagnitude == null)
				{
					r_PsqrMagnitude = new(this, "sqrMagnitude", -1);
				}
				return r_PsqrMagnitude;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int zero
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int r_Pzero;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int RPzero
		{
			get
			{
				if(r_Pzero == null)
				{
					r_Pzero = new(typeof(UnityEngine.Vector3Int), "zero", -1);
				}
				return r_Pzero;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int one
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int r_Pone;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int RPone
		{
			get
			{
				if(r_Pone == null)
				{
					r_Pone = new(typeof(UnityEngine.Vector3Int), "one", -1);
				}
				return r_Pone;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int up
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int r_Pup;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int RPup
		{
			get
			{
				if(r_Pup == null)
				{
					r_Pup = new(typeof(UnityEngine.Vector3Int), "up", -1);
				}
				return r_Pup;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int down
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int r_Pdown;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int RPdown
		{
			get
			{
				if(r_Pdown == null)
				{
					r_Pdown = new(typeof(UnityEngine.Vector3Int), "down", -1);
				}
				return r_Pdown;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int left
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int r_Pleft;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int RPleft
		{
			get
			{
				if(r_Pleft == null)
				{
					r_Pleft = new(typeof(UnityEngine.Vector3Int), "left", -1);
				}
				return r_Pleft;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int right
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int r_Pright;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int RPright
		{
			get
			{
				if(r_Pright == null)
				{
					r_Pright = new(typeof(UnityEngine.Vector3Int), "right", -1);
				}
				return r_Pright;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int forward
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int r_Pforward;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int RPforward
		{
			get
			{
				if(r_Pforward == null)
				{
					r_Pforward = new(typeof(UnityEngine.Vector3Int), "forward", -1);
				}
				return r_Pforward;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int back
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int r_Pback;
		public static Hvak.Editor.Refleaction.RUnityEngine.RVector3Int RPback
		{
			get
			{
				if(r_Pback == null)
				{
					r_Pback = new(typeof(UnityEngine.Vector3Int), "back", -1);
				}
				return r_Pback;
			}
		}

		/// <summary>
		/// Void Set(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MSet_Int32_Int32_Int32;
		public virtual RMethod RMSet_Int32_Int32_Int32
		{
			get
			{
				if(r_MSet_Int32_Int32_Int32 == null)
				{
					r_MSet_Int32_Int32_Int32 = new(this, "Set", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MSet_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Single Distance(UnityEngine.Vector3Int, UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_MDistance_Vector3Int_Vector3Int;
		public static RMethod RMDistance_Vector3Int_Vector3Int
		{
			get
			{
				if(r_MDistance_Vector3Int_Vector3Int == null)
				{
					r_MDistance_Vector3Int_Vector3Int = new(typeof(UnityEngine.Vector3Int), "Distance", 0, typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int));
				}
				return r_MDistance_Vector3Int_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int Min(UnityEngine.Vector3Int, UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_MMin_Vector3Int_Vector3Int;
		public static RMethod RMMin_Vector3Int_Vector3Int
		{
			get
			{
				if(r_MMin_Vector3Int_Vector3Int == null)
				{
					r_MMin_Vector3Int_Vector3Int = new(typeof(UnityEngine.Vector3Int), "Min", 0, typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int));
				}
				return r_MMin_Vector3Int_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int Max(UnityEngine.Vector3Int, UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_MMax_Vector3Int_Vector3Int;
		public static RMethod RMMax_Vector3Int_Vector3Int
		{
			get
			{
				if(r_MMax_Vector3Int_Vector3Int == null)
				{
					r_MMax_Vector3Int_Vector3Int = new(typeof(UnityEngine.Vector3Int), "Max", 0, typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int));
				}
				return r_MMax_Vector3Int_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int Scale(UnityEngine.Vector3Int, UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_MScale_Vector3Int_Vector3Int;
		public static RMethod RMScale_Vector3Int_Vector3Int
		{
			get
			{
				if(r_MScale_Vector3Int_Vector3Int == null)
				{
					r_MScale_Vector3Int_Vector3Int = new(typeof(UnityEngine.Vector3Int), "Scale", 0, typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int));
				}
				return r_MScale_Vector3Int_Vector3Int;
			}
		}

		/// <summary>
		/// Void Scale(UnityEngine.Vector3Int)
		/// </summary>
		protected RMethod r_MScale_Vector3Int;
		public virtual RMethod RMScale_Vector3Int
		{
			get
			{
				if(r_MScale_Vector3Int == null)
				{
					r_MScale_Vector3Int = new(this, "Scale", 0, typeof(UnityEngine.Vector3Int));
				}
				return r_MScale_Vector3Int;
			}
		}

		/// <summary>
		/// Void Clamp(UnityEngine.Vector3Int, UnityEngine.Vector3Int)
		/// </summary>
		protected RMethod r_MClamp_Vector3Int_Vector3Int;
		public virtual RMethod RMClamp_Vector3Int_Vector3Int
		{
			get
			{
				if(r_MClamp_Vector3Int_Vector3Int == null)
				{
					r_MClamp_Vector3Int_Vector3Int = new(this, "Clamp", 0, typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int));
				}
				return r_MClamp_Vector3Int_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 op_Implicit(UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_Mop_Implicit_Vector3Int;
		public static RMethod RMop_Implicit_Vector3Int
		{
			get
			{
				if(r_Mop_Implicit_Vector3Int == null)
				{
					r_Mop_Implicit_Vector3Int = new(typeof(UnityEngine.Vector3Int), "op_Implicit", 0, typeof(UnityEngine.Vector3Int));
				}
				return r_Mop_Implicit_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2Int op_Explicit(UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_Mop_Explicit_Vector3Int;
		public static RMethod RMop_Explicit_Vector3Int
		{
			get
			{
				if(r_Mop_Explicit_Vector3Int == null)
				{
					r_Mop_Explicit_Vector3Int = new(typeof(UnityEngine.Vector3Int), "op_Explicit", 0, typeof(UnityEngine.Vector3Int));
				}
				return r_Mop_Explicit_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int FloorToInt(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MFloorToInt_Vector3;
		public static RMethod RMFloorToInt_Vector3
		{
			get
			{
				if(r_MFloorToInt_Vector3 == null)
				{
					r_MFloorToInt_Vector3 = new(typeof(UnityEngine.Vector3Int), "FloorToInt", 0, typeof(UnityEngine.Vector3));
				}
				return r_MFloorToInt_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int CeilToInt(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MCeilToInt_Vector3;
		public static RMethod RMCeilToInt_Vector3
		{
			get
			{
				if(r_MCeilToInt_Vector3 == null)
				{
					r_MCeilToInt_Vector3 = new(typeof(UnityEngine.Vector3Int), "CeilToInt", 0, typeof(UnityEngine.Vector3));
				}
				return r_MCeilToInt_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int RoundToInt(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MRoundToInt_Vector3;
		public static RMethod RMRoundToInt_Vector3
		{
			get
			{
				if(r_MRoundToInt_Vector3 == null)
				{
					r_MRoundToInt_Vector3 = new(typeof(UnityEngine.Vector3Int), "RoundToInt", 0, typeof(UnityEngine.Vector3));
				}
				return r_MRoundToInt_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int op_Addition(UnityEngine.Vector3Int, UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_Mop_Addition_Vector3Int_Vector3Int;
		public static RMethod RMop_Addition_Vector3Int_Vector3Int
		{
			get
			{
				if(r_Mop_Addition_Vector3Int_Vector3Int == null)
				{
					r_Mop_Addition_Vector3Int_Vector3Int = new(typeof(UnityEngine.Vector3Int), "op_Addition", 0, typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int));
				}
				return r_Mop_Addition_Vector3Int_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int op_Subtraction(UnityEngine.Vector3Int, UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_Mop_Subtraction_Vector3Int_Vector3Int;
		public static RMethod RMop_Subtraction_Vector3Int_Vector3Int
		{
			get
			{
				if(r_Mop_Subtraction_Vector3Int_Vector3Int == null)
				{
					r_Mop_Subtraction_Vector3Int_Vector3Int = new(typeof(UnityEngine.Vector3Int), "op_Subtraction", 0, typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int));
				}
				return r_Mop_Subtraction_Vector3Int_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int op_Multiply(UnityEngine.Vector3Int, UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_Mop_Multiply_Vector3Int_Vector3Int;
		public static RMethod RMop_Multiply_Vector3Int_Vector3Int
		{
			get
			{
				if(r_Mop_Multiply_Vector3Int_Vector3Int == null)
				{
					r_Mop_Multiply_Vector3Int_Vector3Int = new(typeof(UnityEngine.Vector3Int), "op_Multiply", 0, typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int));
				}
				return r_Mop_Multiply_Vector3Int_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int op_UnaryNegation(UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_Mop_UnaryNegation_Vector3Int;
		public static RMethod RMop_UnaryNegation_Vector3Int
		{
			get
			{
				if(r_Mop_UnaryNegation_Vector3Int == null)
				{
					r_Mop_UnaryNegation_Vector3Int = new(typeof(UnityEngine.Vector3Int), "op_UnaryNegation", 0, typeof(UnityEngine.Vector3Int));
				}
				return r_Mop_UnaryNegation_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int op_Multiply(UnityEngine.Vector3Int, Int32)
		/// </summary>
		protected static RMethod r_Mop_Multiply_Vector3Int_Int32;
		public static RMethod RMop_Multiply_Vector3Int_Int32
		{
			get
			{
				if(r_Mop_Multiply_Vector3Int_Int32 == null)
				{
					r_Mop_Multiply_Vector3Int_Int32 = new(typeof(UnityEngine.Vector3Int), "op_Multiply", 0, typeof(UnityEngine.Vector3Int), typeof(System.Int32));
				}
				return r_Mop_Multiply_Vector3Int_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int op_Multiply(Int32, UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_Mop_Multiply_Int32_Vector3Int;
		public static RMethod RMop_Multiply_Int32_Vector3Int
		{
			get
			{
				if(r_Mop_Multiply_Int32_Vector3Int == null)
				{
					r_Mop_Multiply_Int32_Vector3Int = new(typeof(UnityEngine.Vector3Int), "op_Multiply", 0, typeof(System.Int32), typeof(UnityEngine.Vector3Int));
				}
				return r_Mop_Multiply_Int32_Vector3Int;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3Int op_Division(UnityEngine.Vector3Int, Int32)
		/// </summary>
		protected static RMethod r_Mop_Division_Vector3Int_Int32;
		public static RMethod RMop_Division_Vector3Int_Int32
		{
			get
			{
				if(r_Mop_Division_Vector3Int_Int32 == null)
				{
					r_Mop_Division_Vector3Int_Int32 = new(typeof(UnityEngine.Vector3Int), "op_Division", 0, typeof(UnityEngine.Vector3Int), typeof(System.Int32));
				}
				return r_Mop_Division_Vector3Int_Int32;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Vector3Int, UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_Mop_Equality_Vector3Int_Vector3Int;
		public static RMethod RMop_Equality_Vector3Int_Vector3Int
		{
			get
			{
				if(r_Mop_Equality_Vector3Int_Vector3Int == null)
				{
					r_Mop_Equality_Vector3Int_Vector3Int = new(typeof(UnityEngine.Vector3Int), "op_Equality", 0, typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int));
				}
				return r_Mop_Equality_Vector3Int_Vector3Int;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Vector3Int, UnityEngine.Vector3Int)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Vector3Int_Vector3Int;
		public static RMethod RMop_Inequality_Vector3Int_Vector3Int
		{
			get
			{
				if(r_Mop_Inequality_Vector3Int_Vector3Int == null)
				{
					r_Mop_Inequality_Vector3Int_Vector3Int = new(typeof(UnityEngine.Vector3Int), "op_Inequality", 0, typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int));
				}
				return r_Mop_Inequality_Vector3Int_Vector3Int;
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
		/// Boolean Equals(UnityEngine.Vector3Int)
		/// </summary>
		protected RMethod r_MEquals_Vector3Int;
		public virtual RMethod RMEquals_Vector3Int
		{
			get
			{
				if(r_MEquals_Vector3Int == null)
				{
					r_MEquals_Vector3Int = new(this, "Equals", 0, typeof(UnityEngine.Vector3Int));
				}
				return r_MEquals_Vector3Int;
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

        public virtual void Set(System.Int32 @x, System.Int32 @y, System.Int32 @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RMSet_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Single Distance(UnityEngine.Vector3Int @a, UnityEngine.Vector3Int @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMDistance_Vector3Int_Vector3Int.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector3Int Min(UnityEngine.Vector3Int @lhs, UnityEngine.Vector3Int @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMMin_Vector3Int_Vector3Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector3Int Max(UnityEngine.Vector3Int @lhs, UnityEngine.Vector3Int @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMMax_Vector3Int_Vector3Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector3Int Scale(UnityEngine.Vector3Int @a, UnityEngine.Vector3Int @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMScale_Vector3Int_Vector3Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public virtual void Scale(UnityEngine.Vector3Int @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scale};
            var ___result = RMScale_Vector3Int.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clamp(UnityEngine.Vector3Int @min, UnityEngine.Vector3Int @max)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@min, @max};
            var ___result = RMClamp_Vector3Int_Vector3Int.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Vector3 op_Implicit(UnityEngine.Vector3Int @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMop_Implicit_Vector3Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector2Int op_Explicit(UnityEngine.Vector3Int @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMop_Explicit_Vector3Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2Int)___result;
        }


        public static UnityEngine.Vector3Int FloorToInt(UnityEngine.Vector3 @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMFloorToInt_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector3Int CeilToInt(UnityEngine.Vector3 @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMCeilToInt_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector3Int RoundToInt(UnityEngine.Vector3 @v)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@v};
            var ___result = RMRoundToInt_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector3Int op_Addition(UnityEngine.Vector3Int @a, UnityEngine.Vector3Int @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Addition_Vector3Int_Vector3Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector3Int op_Subtraction(UnityEngine.Vector3Int @a, UnityEngine.Vector3Int @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Subtraction_Vector3Int_Vector3Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector3Int op_Multiply(UnityEngine.Vector3Int @a, UnityEngine.Vector3Int @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Multiply_Vector3Int_Vector3Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector3Int op_UnaryNegation(UnityEngine.Vector3Int @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RMop_UnaryNegation_Vector3Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector3Int op_Multiply(UnityEngine.Vector3Int @a, System.Int32 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Multiply_Vector3Int_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector3Int op_Multiply(System.Int32 @a, UnityEngine.Vector3Int @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Multiply_Int32_Vector3Int.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static UnityEngine.Vector3Int op_Division(UnityEngine.Vector3Int @a, System.Int32 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Division_Vector3Int_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3Int)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.Vector3Int @lhs, UnityEngine.Vector3Int @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_Vector3Int_Vector3Int.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Vector3Int @lhs, UnityEngine.Vector3Int @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_Vector3Int_Vector3Int.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.Vector3Int @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Vector3Int.Invoke(___genericsType, ___parameters);

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
