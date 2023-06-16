
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.Rendering.SphericalHarmonicsL2
	/// </summary>
    public partial class RSphericalHarmonicsL2 : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Rendering.SphericalHarmonicsL2);
            }
        }

        public RSphericalHarmonicsL2() : base("UnityEngine.Rendering.SphericalHarmonicsL2")
        {
        }

        public RSphericalHarmonicsL2(System.Object instance) : base("UnityEngine.Rendering.SphericalHarmonicsL2")
		{
            SetInstance(instance);
		}

        public RSphericalHarmonicsL2(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSphericalHarmonicsL2(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Single shr0
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshr0;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshr0
		{
			get
			{
				if(r_Fshr0 == null)
				{
					r_Fshr0 = new(this, "shr0");
				}
				return r_Fshr0;
			}
		}

		/// <summary>
		/// System.Single shr1
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshr1;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshr1
		{
			get
			{
				if(r_Fshr1 == null)
				{
					r_Fshr1 = new(this, "shr1");
				}
				return r_Fshr1;
			}
		}

		/// <summary>
		/// System.Single shr2
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshr2;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshr2
		{
			get
			{
				if(r_Fshr2 == null)
				{
					r_Fshr2 = new(this, "shr2");
				}
				return r_Fshr2;
			}
		}

		/// <summary>
		/// System.Single shr3
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshr3;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshr3
		{
			get
			{
				if(r_Fshr3 == null)
				{
					r_Fshr3 = new(this, "shr3");
				}
				return r_Fshr3;
			}
		}

		/// <summary>
		/// System.Single shr4
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshr4;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshr4
		{
			get
			{
				if(r_Fshr4 == null)
				{
					r_Fshr4 = new(this, "shr4");
				}
				return r_Fshr4;
			}
		}

		/// <summary>
		/// System.Single shr5
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshr5;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshr5
		{
			get
			{
				if(r_Fshr5 == null)
				{
					r_Fshr5 = new(this, "shr5");
				}
				return r_Fshr5;
			}
		}

		/// <summary>
		/// System.Single shr6
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshr6;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshr6
		{
			get
			{
				if(r_Fshr6 == null)
				{
					r_Fshr6 = new(this, "shr6");
				}
				return r_Fshr6;
			}
		}

		/// <summary>
		/// System.Single shr7
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshr7;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshr7
		{
			get
			{
				if(r_Fshr7 == null)
				{
					r_Fshr7 = new(this, "shr7");
				}
				return r_Fshr7;
			}
		}

		/// <summary>
		/// System.Single shr8
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshr8;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshr8
		{
			get
			{
				if(r_Fshr8 == null)
				{
					r_Fshr8 = new(this, "shr8");
				}
				return r_Fshr8;
			}
		}

		/// <summary>
		/// System.Single shg0
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshg0;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshg0
		{
			get
			{
				if(r_Fshg0 == null)
				{
					r_Fshg0 = new(this, "shg0");
				}
				return r_Fshg0;
			}
		}

		/// <summary>
		/// System.Single shg1
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshg1;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshg1
		{
			get
			{
				if(r_Fshg1 == null)
				{
					r_Fshg1 = new(this, "shg1");
				}
				return r_Fshg1;
			}
		}

		/// <summary>
		/// System.Single shg2
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshg2;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshg2
		{
			get
			{
				if(r_Fshg2 == null)
				{
					r_Fshg2 = new(this, "shg2");
				}
				return r_Fshg2;
			}
		}

		/// <summary>
		/// System.Single shg3
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshg3;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshg3
		{
			get
			{
				if(r_Fshg3 == null)
				{
					r_Fshg3 = new(this, "shg3");
				}
				return r_Fshg3;
			}
		}

		/// <summary>
		/// System.Single shg4
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshg4;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshg4
		{
			get
			{
				if(r_Fshg4 == null)
				{
					r_Fshg4 = new(this, "shg4");
				}
				return r_Fshg4;
			}
		}

		/// <summary>
		/// System.Single shg5
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshg5;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshg5
		{
			get
			{
				if(r_Fshg5 == null)
				{
					r_Fshg5 = new(this, "shg5");
				}
				return r_Fshg5;
			}
		}

		/// <summary>
		/// System.Single shg6
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshg6;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshg6
		{
			get
			{
				if(r_Fshg6 == null)
				{
					r_Fshg6 = new(this, "shg6");
				}
				return r_Fshg6;
			}
		}

		/// <summary>
		/// System.Single shg7
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshg7;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshg7
		{
			get
			{
				if(r_Fshg7 == null)
				{
					r_Fshg7 = new(this, "shg7");
				}
				return r_Fshg7;
			}
		}

		/// <summary>
		/// System.Single shg8
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshg8;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshg8
		{
			get
			{
				if(r_Fshg8 == null)
				{
					r_Fshg8 = new(this, "shg8");
				}
				return r_Fshg8;
			}
		}

		/// <summary>
		/// System.Single shb0
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshb0;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshb0
		{
			get
			{
				if(r_Fshb0 == null)
				{
					r_Fshb0 = new(this, "shb0");
				}
				return r_Fshb0;
			}
		}

		/// <summary>
		/// System.Single shb1
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshb1;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshb1
		{
			get
			{
				if(r_Fshb1 == null)
				{
					r_Fshb1 = new(this, "shb1");
				}
				return r_Fshb1;
			}
		}

		/// <summary>
		/// System.Single shb2
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshb2;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshb2
		{
			get
			{
				if(r_Fshb2 == null)
				{
					r_Fshb2 = new(this, "shb2");
				}
				return r_Fshb2;
			}
		}

		/// <summary>
		/// System.Single shb3
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshb3;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshb3
		{
			get
			{
				if(r_Fshb3 == null)
				{
					r_Fshb3 = new(this, "shb3");
				}
				return r_Fshb3;
			}
		}

		/// <summary>
		/// System.Single shb4
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshb4;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshb4
		{
			get
			{
				if(r_Fshb4 == null)
				{
					r_Fshb4 = new(this, "shb4");
				}
				return r_Fshb4;
			}
		}

		/// <summary>
		/// System.Single shb5
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshb5;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshb5
		{
			get
			{
				if(r_Fshb5 == null)
				{
					r_Fshb5 = new(this, "shb5");
				}
				return r_Fshb5;
			}
		}

		/// <summary>
		/// System.Single shb6
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshb6;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshb6
		{
			get
			{
				if(r_Fshb6 == null)
				{
					r_Fshb6 = new(this, "shb6");
				}
				return r_Fshb6;
			}
		}

		/// <summary>
		/// System.Single shb7
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshb7;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshb7
		{
			get
			{
				if(r_Fshb7 == null)
				{
					r_Fshb7 = new(this, "shb7");
				}
				return r_Fshb7;
			}
		}

		/// <summary>
		/// System.Single shb8
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fshb8;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFshb8
		{
			get
			{
				if(r_Fshb8 == null)
				{
					r_Fshb8 = new(this, "shb8");
				}
				return r_Fshb8;
			}
		}

		/// <summary>
		/// Single Item [Int32, Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PItem_Int32_Int32;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPItem_Int32_Int32
		{
			get
			{
				if(r_PItem_Int32_Int32 == null)
				{
					r_PItem_Int32_Int32 = new(this, "Item", -1, typeof(System.Int32), typeof(System.Int32));
				}
				return r_PItem_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_MClear;
		public virtual RMethod RMClear
		{
			get
			{
				if(r_MClear == null)
				{
					r_MClear = new(this, "Clear", 0);
				}
				return r_MClear;
			}
		}

		/// <summary>
		/// Void SetZero()
		/// </summary>
		protected RMethod r_MSetZero;
		public virtual RMethod RMSetZero
		{
			get
			{
				if(r_MSetZero == null)
				{
					r_MSetZero = new(this, "SetZero", 0);
				}
				return r_MSetZero;
			}
		}

		/// <summary>
		/// Void AddAmbientLight(UnityEngine.Color)
		/// </summary>
		protected RMethod r_MAddAmbientLight_Color;
		public virtual RMethod RMAddAmbientLight_Color
		{
			get
			{
				if(r_MAddAmbientLight_Color == null)
				{
					r_MAddAmbientLight_Color = new(this, "AddAmbientLight", 0, typeof(UnityEngine.Color));
				}
				return r_MAddAmbientLight_Color;
			}
		}

		/// <summary>
		/// Void AddDirectionalLight(UnityEngine.Vector3, UnityEngine.Color, Single)
		/// </summary>
		protected RMethod r_MAddDirectionalLight_Vector3_Color_Single;
		public virtual RMethod RMAddDirectionalLight_Vector3_Color_Single
		{
			get
			{
				if(r_MAddDirectionalLight_Vector3_Color_Single == null)
				{
					r_MAddDirectionalLight_Vector3_Color_Single = new(this, "AddDirectionalLight", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Color), typeof(System.Single));
				}
				return r_MAddDirectionalLight_Vector3_Color_Single;
			}
		}

		/// <summary>
		/// Void AddDirectionalLightInternal(UnityEngine.Rendering.SphericalHarmonicsL2 ByRef, UnityEngine.Vector3, UnityEngine.Color)
		/// </summary>
		protected static RMethod r_MAddDirectionalLightInternal_Ref_SphericalHarmonicsL2_Vector3_Color;
		public static RMethod RMAddDirectionalLightInternal_Ref_SphericalHarmonicsL2_Vector3_Color
		{
			get
			{
				if(r_MAddDirectionalLightInternal_Ref_SphericalHarmonicsL2_Vector3_Color == null)
				{
					r_MAddDirectionalLightInternal_Ref_SphericalHarmonicsL2_Vector3_Color = new(Type, "AddDirectionalLightInternal", 0, typeof(UnityEngine.Rendering.SphericalHarmonicsL2).MakeByRefType(), typeof(UnityEngine.Vector3), typeof(UnityEngine.Color));
				}
				return r_MAddDirectionalLightInternal_Ref_SphericalHarmonicsL2_Vector3_Color;
			}
		}

		/// <summary>
		/// Void Evaluate(UnityEngine.Vector3[], UnityEngine.Color[])
		/// </summary>
		protected RMethod r_MEvaluate_Vector3Array_ColorArray;
		public virtual RMethod RMEvaluate_Vector3Array_ColorArray
		{
			get
			{
				if(r_MEvaluate_Vector3Array_ColorArray == null)
				{
					r_MEvaluate_Vector3Array_ColorArray = new(this, "Evaluate", 0, typeof(UnityEngine.Vector3).MakeArrayType(), typeof(UnityEngine.Color).MakeArrayType());
				}
				return r_MEvaluate_Vector3Array_ColorArray;
			}
		}

		/// <summary>
		/// Void EvaluateInternal(UnityEngine.Rendering.SphericalHarmonicsL2 ByRef, UnityEngine.Vector3[], UnityEngine.Color[])
		/// </summary>
		protected static RMethod r_MEvaluateInternal_Ref_SphericalHarmonicsL2_Vector3Array_ColorArray;
		public static RMethod RMEvaluateInternal_Ref_SphericalHarmonicsL2_Vector3Array_ColorArray
		{
			get
			{
				if(r_MEvaluateInternal_Ref_SphericalHarmonicsL2_Vector3Array_ColorArray == null)
				{
					r_MEvaluateInternal_Ref_SphericalHarmonicsL2_Vector3Array_ColorArray = new(Type, "EvaluateInternal", 0, typeof(UnityEngine.Rendering.SphericalHarmonicsL2).MakeByRefType(), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(UnityEngine.Color).MakeArrayType());
				}
				return r_MEvaluateInternal_Ref_SphericalHarmonicsL2_Vector3Array_ColorArray;
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
		/// Boolean Equals(UnityEngine.Rendering.SphericalHarmonicsL2)
		/// </summary>
		protected RMethod r_MEquals_SphericalHarmonicsL2;
		public virtual RMethod RMEquals_SphericalHarmonicsL2
		{
			get
			{
				if(r_MEquals_SphericalHarmonicsL2 == null)
				{
					r_MEquals_SphericalHarmonicsL2 = new(this, "Equals", 0, typeof(UnityEngine.Rendering.SphericalHarmonicsL2));
				}
				return r_MEquals_SphericalHarmonicsL2;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.SphericalHarmonicsL2 op_Multiply(UnityEngine.Rendering.SphericalHarmonicsL2, Single)
		/// </summary>
		protected static RMethod r_Mop_Multiply_SphericalHarmonicsL2_Single;
		public static RMethod RMop_Multiply_SphericalHarmonicsL2_Single
		{
			get
			{
				if(r_Mop_Multiply_SphericalHarmonicsL2_Single == null)
				{
					r_Mop_Multiply_SphericalHarmonicsL2_Single = new(Type, "op_Multiply", 0, typeof(UnityEngine.Rendering.SphericalHarmonicsL2), typeof(System.Single));
				}
				return r_Mop_Multiply_SphericalHarmonicsL2_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.SphericalHarmonicsL2 op_Multiply(Single, UnityEngine.Rendering.SphericalHarmonicsL2)
		/// </summary>
		protected static RMethod r_Mop_Multiply_Single_SphericalHarmonicsL2;
		public static RMethod RMop_Multiply_Single_SphericalHarmonicsL2
		{
			get
			{
				if(r_Mop_Multiply_Single_SphericalHarmonicsL2 == null)
				{
					r_Mop_Multiply_Single_SphericalHarmonicsL2 = new(Type, "op_Multiply", 0, typeof(System.Single), typeof(UnityEngine.Rendering.SphericalHarmonicsL2));
				}
				return r_Mop_Multiply_Single_SphericalHarmonicsL2;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.SphericalHarmonicsL2 op_Addition(UnityEngine.Rendering.SphericalHarmonicsL2, UnityEngine.Rendering.SphericalHarmonicsL2)
		/// </summary>
		protected static RMethod r_Mop_Addition_SphericalHarmonicsL2_SphericalHarmonicsL2;
		public static RMethod RMop_Addition_SphericalHarmonicsL2_SphericalHarmonicsL2
		{
			get
			{
				if(r_Mop_Addition_SphericalHarmonicsL2_SphericalHarmonicsL2 == null)
				{
					r_Mop_Addition_SphericalHarmonicsL2_SphericalHarmonicsL2 = new(Type, "op_Addition", 0, typeof(UnityEngine.Rendering.SphericalHarmonicsL2), typeof(UnityEngine.Rendering.SphericalHarmonicsL2));
				}
				return r_Mop_Addition_SphericalHarmonicsL2_SphericalHarmonicsL2;
			}
		}

		/// <summary>
		/// Boolean op_Equality(UnityEngine.Rendering.SphericalHarmonicsL2, UnityEngine.Rendering.SphericalHarmonicsL2)
		/// </summary>
		protected static RMethod r_Mop_Equality_SphericalHarmonicsL2_SphericalHarmonicsL2;
		public static RMethod RMop_Equality_SphericalHarmonicsL2_SphericalHarmonicsL2
		{
			get
			{
				if(r_Mop_Equality_SphericalHarmonicsL2_SphericalHarmonicsL2 == null)
				{
					r_Mop_Equality_SphericalHarmonicsL2_SphericalHarmonicsL2 = new(Type, "op_Equality", 0, typeof(UnityEngine.Rendering.SphericalHarmonicsL2), typeof(UnityEngine.Rendering.SphericalHarmonicsL2));
				}
				return r_Mop_Equality_SphericalHarmonicsL2_SphericalHarmonicsL2;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rendering.SphericalHarmonicsL2, UnityEngine.Rendering.SphericalHarmonicsL2)
		/// </summary>
		protected static RMethod r_Mop_Inequality_SphericalHarmonicsL2_SphericalHarmonicsL2;
		public static RMethod RMop_Inequality_SphericalHarmonicsL2_SphericalHarmonicsL2
		{
			get
			{
				if(r_Mop_Inequality_SphericalHarmonicsL2_SphericalHarmonicsL2 == null)
				{
					r_Mop_Inequality_SphericalHarmonicsL2_SphericalHarmonicsL2 = new(Type, "op_Inequality", 0, typeof(UnityEngine.Rendering.SphericalHarmonicsL2), typeof(UnityEngine.Rendering.SphericalHarmonicsL2));
				}
				return r_Mop_Inequality_SphericalHarmonicsL2_SphericalHarmonicsL2;
			}
		}

		/// <summary>
		/// Void SetZero_Injected(UnityEngine.Rendering.SphericalHarmonicsL2 ByRef)
		/// </summary>
		protected static RMethod r_MSetZero_Injected_Ref_SphericalHarmonicsL2;
		public static RMethod RMSetZero_Injected_Ref_SphericalHarmonicsL2
		{
			get
			{
				if(r_MSetZero_Injected_Ref_SphericalHarmonicsL2 == null)
				{
					r_MSetZero_Injected_Ref_SphericalHarmonicsL2 = new(Type, "SetZero_Injected", 0, typeof(UnityEngine.Rendering.SphericalHarmonicsL2).MakeByRefType());
				}
				return r_MSetZero_Injected_Ref_SphericalHarmonicsL2;
			}
		}

		/// <summary>
		/// Void AddAmbientLight_Injected(UnityEngine.Rendering.SphericalHarmonicsL2 ByRef, UnityEngine.Color ByRef)
		/// </summary>
		protected static RMethod r_MAddAmbientLight_Injected_Ref_SphericalHarmonicsL2_Ref_Color;
		public static RMethod RMAddAmbientLight_Injected_Ref_SphericalHarmonicsL2_Ref_Color
		{
			get
			{
				if(r_MAddAmbientLight_Injected_Ref_SphericalHarmonicsL2_Ref_Color == null)
				{
					r_MAddAmbientLight_Injected_Ref_SphericalHarmonicsL2_Ref_Color = new(Type, "AddAmbientLight_Injected", 0, typeof(UnityEngine.Rendering.SphericalHarmonicsL2).MakeByRefType(), typeof(UnityEngine.Color).MakeByRefType());
				}
				return r_MAddAmbientLight_Injected_Ref_SphericalHarmonicsL2_Ref_Color;
			}
		}

		/// <summary>
		/// Void AddDirectionalLightInternal_Injected(UnityEngine.Rendering.SphericalHarmonicsL2 ByRef, UnityEngine.Vector3 ByRef, UnityEngine.Color ByRef)
		/// </summary>
		protected static RMethod r_MAddDirectionalLightInternal_Injected_Ref_SphericalHarmonicsL2_Ref_Vector3_Ref_Color;
		public static RMethod RMAddDirectionalLightInternal_Injected_Ref_SphericalHarmonicsL2_Ref_Vector3_Ref_Color
		{
			get
			{
				if(r_MAddDirectionalLightInternal_Injected_Ref_SphericalHarmonicsL2_Ref_Vector3_Ref_Color == null)
				{
					r_MAddDirectionalLightInternal_Injected_Ref_SphericalHarmonicsL2_Ref_Vector3_Ref_Color = new(Type, "AddDirectionalLightInternal_Injected", 0, typeof(UnityEngine.Rendering.SphericalHarmonicsL2).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Color).MakeByRefType());
				}
				return r_MAddDirectionalLightInternal_Injected_Ref_SphericalHarmonicsL2_Ref_Vector3_Ref_Color;
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


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetZero()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetZero.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddAmbientLight(UnityEngine.Color @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color};
            var ___result = RMAddAmbientLight_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddDirectionalLight(UnityEngine.Vector3 @direction, UnityEngine.Color @color, System.Single @intensity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@direction, @color, @intensity};
            var ___result = RMAddDirectionalLight_Vector3_Color_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static void AddDirectionalLightInternal(ref UnityEngine.Rendering.SphericalHarmonicsL2 @sh, UnityEngine.Vector3 @direction, UnityEngine.Color @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sh, @direction, @color};
            var ___result = RMAddDirectionalLightInternal_Ref_SphericalHarmonicsL2_Vector3_Color.Invoke(___genericsType, ___parameters);
			@sh = ReflectionUtils.Convert<UnityEngine.Rendering.SphericalHarmonicsL2>(___parameters[0]);

            
        }


        public virtual void Evaluate(UnityEngine.Vector3[] @directions, UnityEngine.Color[] @results)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@directions, @results};
            var ___result = RMEvaluate_Vector3Array_ColorArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void EvaluateInternal(ref UnityEngine.Rendering.SphericalHarmonicsL2 @sh, UnityEngine.Vector3[] @directions, UnityEngine.Color[] @results)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sh, @directions, @results};
            var ___result = RMEvaluateInternal_Ref_SphericalHarmonicsL2_Vector3Array_ColorArray.Invoke(___genericsType, ___parameters);
			@sh = ReflectionUtils.Convert<UnityEngine.Rendering.SphericalHarmonicsL2>(___parameters[0]);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(UnityEngine.Rendering.SphericalHarmonicsL2 @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_SphericalHarmonicsL2.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static UnityEngine.Rendering.SphericalHarmonicsL2 op_Multiply(UnityEngine.Rendering.SphericalHarmonicsL2 @lhs, System.Single @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Multiply_SphericalHarmonicsL2_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rendering.SphericalHarmonicsL2>(___result);
        }


        public static UnityEngine.Rendering.SphericalHarmonicsL2 op_Multiply(System.Single @lhs, UnityEngine.Rendering.SphericalHarmonicsL2 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Multiply_Single_SphericalHarmonicsL2.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rendering.SphericalHarmonicsL2>(___result);
        }


        public static UnityEngine.Rendering.SphericalHarmonicsL2 op_Addition(UnityEngine.Rendering.SphericalHarmonicsL2 @lhs, UnityEngine.Rendering.SphericalHarmonicsL2 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Addition_SphericalHarmonicsL2_SphericalHarmonicsL2.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rendering.SphericalHarmonicsL2>(___result);
        }


        public static System.Boolean op_Equality(UnityEngine.Rendering.SphericalHarmonicsL2 @lhs, UnityEngine.Rendering.SphericalHarmonicsL2 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Equality_SphericalHarmonicsL2_SphericalHarmonicsL2.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(UnityEngine.Rendering.SphericalHarmonicsL2 @lhs, UnityEngine.Rendering.SphericalHarmonicsL2 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMop_Inequality_SphericalHarmonicsL2_SphericalHarmonicsL2.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static void SetZero_Injected(ref UnityEngine.Rendering.SphericalHarmonicsL2 @_unity_self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self};
            var ___result = RMSetZero_Injected_Ref_SphericalHarmonicsL2.Invoke(___genericsType, ___parameters);
			@_unity_self = ReflectionUtils.Convert<UnityEngine.Rendering.SphericalHarmonicsL2>(___parameters[0]);

            
        }


        public static void AddAmbientLight_Injected(ref UnityEngine.Rendering.SphericalHarmonicsL2 @_unity_self, ref UnityEngine.Color @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_unity_self, @color};
            var ___result = RMAddAmbientLight_Injected_Ref_SphericalHarmonicsL2_Ref_Color.Invoke(___genericsType, ___parameters);
			@_unity_self = ReflectionUtils.Convert<UnityEngine.Rendering.SphericalHarmonicsL2>(___parameters[0]);
			@color = ReflectionUtils.Convert<UnityEngine.Color>(___parameters[1]);

            
        }


        public static void AddDirectionalLightInternal_Injected(ref UnityEngine.Rendering.SphericalHarmonicsL2 @sh, ref UnityEngine.Vector3 @direction, ref UnityEngine.Color @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sh, @direction, @color};
            var ___result = RMAddDirectionalLightInternal_Injected_Ref_SphericalHarmonicsL2_Ref_Vector3_Ref_Color.Invoke(___genericsType, ___parameters);
			@sh = ReflectionUtils.Convert<UnityEngine.Rendering.SphericalHarmonicsL2>(___parameters[0]);
			@direction = ReflectionUtils.Convert<UnityEngine.Vector3>(___parameters[1]);
			@color = ReflectionUtils.Convert<UnityEngine.Color>(___parameters[2]);

            
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
