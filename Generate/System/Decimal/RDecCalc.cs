using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{public partial class RDecimal
{
	
	/// <summary>
	/// System.Decimal+DecCalc
	/// </summary>
    public partial class RDecCalc : RMember //
    {

		/// <summary>
		/// System.UInt32 uflags
		/// </summary>
		protected RField r_uflags;
		public virtual RField Ruflags
		{
			get
			{
				if(r_uflags == null)
				{
					r_uflags = new(this, "uflags");
					r_uflags.SetBelong(this.instance);
				}
				return r_uflags;
			}
		}

		/// <summary>
		/// System.UInt32 uhi
		/// </summary>
		protected RField r_uhi;
		public virtual RField Ruhi
		{
			get
			{
				if(r_uhi == null)
				{
					r_uhi = new(this, "uhi");
					r_uhi.SetBelong(this.instance);
				}
				return r_uhi;
			}
		}

		/// <summary>
		/// System.UInt32 ulo
		/// </summary>
		protected RField r_ulo;
		public virtual RField Rulo
		{
			get
			{
				if(r_ulo == null)
				{
					r_ulo = new(this, "ulo");
					r_ulo.SetBelong(this.instance);
				}
				return r_ulo;
			}
		}

		/// <summary>
		/// System.UInt32 umid
		/// </summary>
		protected RField r_umid;
		public virtual RField Rumid
		{
			get
			{
				if(r_umid == null)
				{
					r_umid = new(this, "umid");
					r_umid.SetBelong(this.instance);
				}
				return r_umid;
			}
		}

		/// <summary>
		/// System.UInt64 ulomidLE
		/// </summary>
		protected RField r_ulomidLE;
		public virtual RField RulomidLE
		{
			get
			{
				if(r_ulomidLE == null)
				{
					r_ulomidLE = new(this, "ulomidLE");
					r_ulomidLE.SetBelong(this.instance);
				}
				return r_ulomidLE;
			}
		}

		/// <summary>
		/// System.UInt32 SignMask
		/// </summary>
		protected static RField r_SignMask;
		public static RField RSignMask
		{
			get
			{
				if(r_SignMask == null)
				{
					r_SignMask = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "SignMask");
					r_SignMask.SetBelong(null);
				}
				return r_SignMask;
			}
		}

		/// <summary>
		/// System.UInt32 ScaleMask
		/// </summary>
		protected static RField r_ScaleMask;
		public static RField RScaleMask
		{
			get
			{
				if(r_ScaleMask == null)
				{
					r_ScaleMask = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "ScaleMask");
					r_ScaleMask.SetBelong(null);
				}
				return r_ScaleMask;
			}
		}

		/// <summary>
		/// System.Int32 DEC_SCALE_MAX
		/// </summary>
		protected static RField r_DEC_SCALE_MAX;
		public static RField RDEC_SCALE_MAX
		{
			get
			{
				if(r_DEC_SCALE_MAX == null)
				{
					r_DEC_SCALE_MAX = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "DEC_SCALE_MAX");
					r_DEC_SCALE_MAX.SetBelong(null);
				}
				return r_DEC_SCALE_MAX;
			}
		}

		/// <summary>
		/// System.UInt32 TenToPowerNine
		/// </summary>
		protected static RField r_TenToPowerNine;
		public static RField RTenToPowerNine
		{
			get
			{
				if(r_TenToPowerNine == null)
				{
					r_TenToPowerNine = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "TenToPowerNine");
					r_TenToPowerNine.SetBelong(null);
				}
				return r_TenToPowerNine;
			}
		}

		/// <summary>
		/// System.UInt64 TenToPowerEighteen
		/// </summary>
		protected static RField r_TenToPowerEighteen;
		public static RField RTenToPowerEighteen
		{
			get
			{
				if(r_TenToPowerEighteen == null)
				{
					r_TenToPowerEighteen = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "TenToPowerEighteen");
					r_TenToPowerEighteen.SetBelong(null);
				}
				return r_TenToPowerEighteen;
			}
		}

		/// <summary>
		/// System.Int32 MaxInt32Scale
		/// </summary>
		protected static RField r_MaxInt32Scale;
		public static RField RMaxInt32Scale
		{
			get
			{
				if(r_MaxInt32Scale == null)
				{
					r_MaxInt32Scale = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "MaxInt32Scale");
					r_MaxInt32Scale.SetBelong(null);
				}
				return r_MaxInt32Scale;
			}
		}

		/// <summary>
		/// System.Int32 MaxInt64Scale
		/// </summary>
		protected static RField r_MaxInt64Scale;
		public static RField RMaxInt64Scale
		{
			get
			{
				if(r_MaxInt64Scale == null)
				{
					r_MaxInt64Scale = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "MaxInt64Scale");
					r_MaxInt64Scale.SetBelong(null);
				}
				return r_MaxInt64Scale;
			}
		}

		/// <summary>
		/// System.UInt32[] s_powers10
		/// </summary>
		protected static RFieldArray<RField> r_s_powers10;
		public static RFieldArray<RField> Rs_powers10
		{
			get
			{
				if(r_s_powers10 == null)
				{
					r_s_powers10 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "s_powers10");
					r_s_powers10.SetBelong(null);
				}
				return r_s_powers10;
			}
		}

		/// <summary>
		/// System.UInt64[] s_ulongPowers10
		/// </summary>
		protected static RFieldArray<RField> r_s_ulongPowers10;
		public static RFieldArray<RField> Rs_ulongPowers10
		{
			get
			{
				if(r_s_ulongPowers10 == null)
				{
					r_s_ulongPowers10 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "s_ulongPowers10");
					r_s_ulongPowers10.SetBelong(null);
				}
				return r_s_ulongPowers10;
			}
		}

		/// <summary>
		/// System.Double[] s_doublePowers10
		/// </summary>
		protected static RFieldArray<RField> r_s_doublePowers10;
		public static RFieldArray<RField> Rs_doublePowers10
		{
			get
			{
				if(r_s_doublePowers10 == null)
				{
					r_s_doublePowers10 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "s_doublePowers10");
					r_s_doublePowers10.SetBelong(null);
				}
				return r_s_doublePowers10;
			}
		}

		/// <summary>
		/// System.Decimal+DecCalc+PowerOvfl[] PowerOvflValues
		/// </summary>
		protected static RFieldArray<RSystem.RDecimal.RDecCalc.RPowerOvfl> r_PowerOvflValues;
		public static RFieldArray<RSystem.RDecimal.RDecCalc.RPowerOvfl> RPowerOvflValues
		{
			get
			{
				if(r_PowerOvflValues == null)
				{
					r_PowerOvflValues = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "PowerOvflValues");
					r_PowerOvflValues.SetBelong(null);
				}
				return r_PowerOvflValues;
			}
		}

		/// <summary>
		/// UInt32 High
		/// </summary>
		protected RProperty r_High;
		public virtual RProperty RHigh
		{
			get
			{
				if(r_High == null)
				{
					r_High = new(this, "High", -1);
					r_High.SetBelong(this.instance);
				}
				return r_High;
			}
		}

		/// <summary>
		/// UInt32 Low
		/// </summary>
		protected RProperty r_Low;
		public virtual RProperty RLow
		{
			get
			{
				if(r_Low == null)
				{
					r_Low = new(this, "Low", -1);
					r_Low.SetBelong(this.instance);
				}
				return r_Low;
			}
		}

		/// <summary>
		/// UInt32 Mid
		/// </summary>
		protected RProperty r_Mid;
		public virtual RProperty RMid
		{
			get
			{
				if(r_Mid == null)
				{
					r_Mid = new(this, "Mid", -1);
					r_Mid.SetBelong(this.instance);
				}
				return r_Mid;
			}
		}

		/// <summary>
		/// Boolean IsNegative
		/// </summary>
		protected RProperty r_IsNegative;
		public virtual RProperty RIsNegative
		{
			get
			{
				if(r_IsNegative == null)
				{
					r_IsNegative = new(this, "IsNegative", -1);
					r_IsNegative.SetBelong(this.instance);
				}
				return r_IsNegative;
			}
		}

		/// <summary>
		/// Int32 Scale
		/// </summary>
		protected RProperty r_Scale;
		public virtual RProperty RScale
		{
			get
			{
				if(r_Scale == null)
				{
					r_Scale = new(this, "Scale", -1);
					r_Scale.SetBelong(this.instance);
				}
				return r_Scale;
			}
		}

		/// <summary>
		/// UInt64 Low64
		/// </summary>
		protected RProperty r_Low64;
		public virtual RProperty RLow64
		{
			get
			{
				if(r_Low64 == null)
				{
					r_Low64 = new(this, "Low64", -1);
					r_Low64.SetBelong(this.instance);
				}
				return r_Low64;
			}
		}

		/// <summary>
		/// UInt32 GetExponent(Single)
		/// </summary>
		protected static RMethod r_GetExponent_Single;
		public static RMethod RGetExponent_Single
		{
			get
			{
				if(r_GetExponent_Single == null)
				{
					r_GetExponent_Single = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "GetExponent", 0, typeof(System.Single));
					r_GetExponent_Single.SetBelong(null);
				}
				return r_GetExponent_Single;
			}
		}

		/// <summary>
		/// UInt32 GetExponent(Double)
		/// </summary>
		protected static RMethod r_GetExponent_Double;
		public static RMethod RGetExponent_Double
		{
			get
			{
				if(r_GetExponent_Double == null)
				{
					r_GetExponent_Double = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "GetExponent", 0, typeof(System.Double));
					r_GetExponent_Double.SetBelong(null);
				}
				return r_GetExponent_Double;
			}
		}

		/// <summary>
		/// UInt64 UInt32x32To64(UInt32, UInt32)
		/// </summary>
		protected static RMethod r_UInt32x32To64_UInt32_UInt32;
		public static RMethod RUInt32x32To64_UInt32_UInt32
		{
			get
			{
				if(r_UInt32x32To64_UInt32_UInt32 == null)
				{
					r_UInt32x32To64_UInt32_UInt32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "UInt32x32To64", 0, typeof(System.UInt32), typeof(System.UInt32));
					r_UInt32x32To64_UInt32_UInt32.SetBelong(null);
				}
				return r_UInt32x32To64_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void UInt64x64To128(UInt64, UInt64, DecCalc ByRef)
		/// </summary>
		protected static RMethod r_UInt64x64To128_UInt64_UInt64_Ref_DecCalc;
		public static RMethod RUInt64x64To128_UInt64_UInt64_Ref_DecCalc
		{
			get
			{
				if(r_UInt64x64To128_UInt64_UInt64_Ref_DecCalc == null)
				{
					r_UInt64x64To128_UInt64_UInt64_Ref_DecCalc = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "UInt64x64To128", 0, typeof(System.UInt64), typeof(System.UInt64),  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
					r_UInt64x64To128_UInt64_UInt64_Ref_DecCalc.SetBelong(null);
				}
				return r_UInt64x64To128_UInt64_UInt64_Ref_DecCalc;
			}
		}

		/// <summary>
		/// UInt32 Div96By32(Buf12 ByRef, UInt32)
		/// </summary>
		protected static RMethod r_Div96By32_Ref_Buf12_UInt32;
		public static RMethod RDiv96By32_Ref_Buf12_UInt32
		{
			get
			{
				if(r_Div96By32_Ref_Buf12_UInt32 == null)
				{
					r_Div96By32_Ref_Buf12_UInt32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "Div96By32", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType(), typeof(System.UInt32));
					r_Div96By32_Ref_Buf12_UInt32.SetBelong(null);
				}
				return r_Div96By32_Ref_Buf12_UInt32;
			}
		}

		/// <summary>
		/// Boolean Div96ByConst(UInt64 ByRef, UInt32 ByRef, UInt32)
		/// </summary>
		protected static RMethod r_Div96ByConst_Ref_UInt64_Ref_UInt32_UInt32;
		public static RMethod RDiv96ByConst_Ref_UInt64_Ref_UInt32_UInt32
		{
			get
			{
				if(r_Div96ByConst_Ref_UInt64_Ref_UInt32_UInt32 == null)
				{
					r_Div96ByConst_Ref_UInt64_Ref_UInt32_UInt32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "Div96ByConst", 0, typeof(System.UInt64).MakeByRefType(), typeof(System.UInt32).MakeByRefType(), typeof(System.UInt32));
					r_Div96ByConst_Ref_UInt64_Ref_UInt32_UInt32.SetBelong(null);
				}
				return r_Div96ByConst_Ref_UInt64_Ref_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void Unscale(UInt32 ByRef, UInt64 ByRef, Int32 ByRef)
		/// </summary>
		protected static RMethod r_Unscale_Ref_UInt32_Ref_UInt64_Ref_Int32;
		public static RMethod RUnscale_Ref_UInt32_Ref_UInt64_Ref_Int32
		{
			get
			{
				if(r_Unscale_Ref_UInt32_Ref_UInt64_Ref_Int32 == null)
				{
					r_Unscale_Ref_UInt32_Ref_UInt64_Ref_Int32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "Unscale", 0, typeof(System.UInt32).MakeByRefType(), typeof(System.UInt64).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_Unscale_Ref_UInt32_Ref_UInt64_Ref_Int32.SetBelong(null);
				}
				return r_Unscale_Ref_UInt32_Ref_UInt64_Ref_Int32;
			}
		}

		/// <summary>
		/// UInt32 Div96By64(Buf12 ByRef, UInt64)
		/// </summary>
		protected static RMethod r_Div96By64_Ref_Buf12_UInt64;
		public static RMethod RDiv96By64_Ref_Buf12_UInt64
		{
			get
			{
				if(r_Div96By64_Ref_Buf12_UInt64 == null)
				{
					r_Div96By64_Ref_Buf12_UInt64 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "Div96By64", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType(), typeof(System.UInt64));
					r_Div96By64_Ref_Buf12_UInt64.SetBelong(null);
				}
				return r_Div96By64_Ref_Buf12_UInt64;
			}
		}

		/// <summary>
		/// UInt32 Div128By96(Buf16 ByRef, Buf12 ByRef)
		/// </summary>
		protected static RMethod r_Div128By96_Ref_Buf16_Ref_Buf12;
		public static RMethod RDiv128By96_Ref_Buf16_Ref_Buf12
		{
			get
			{
				if(r_Div128By96_Ref_Buf16_Ref_Buf12 == null)
				{
					r_Div128By96_Ref_Buf16_Ref_Buf12 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "Div128By96", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc+Buf16").MakeByRefType(),  ReflectionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType());
					r_Div128By96_Ref_Buf16_Ref_Buf12.SetBelong(null);
				}
				return r_Div128By96_Ref_Buf16_Ref_Buf12;
			}
		}

		/// <summary>
		/// UInt32 IncreaseScale(Buf12 ByRef, UInt32)
		/// </summary>
		protected static RMethod r_IncreaseScale_Ref_Buf12_UInt32;
		public static RMethod RIncreaseScale_Ref_Buf12_UInt32
		{
			get
			{
				if(r_IncreaseScale_Ref_Buf12_UInt32 == null)
				{
					r_IncreaseScale_Ref_Buf12_UInt32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "IncreaseScale", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType(), typeof(System.UInt32));
					r_IncreaseScale_Ref_Buf12_UInt32.SetBelong(null);
				}
				return r_IncreaseScale_Ref_Buf12_UInt32;
			}
		}

		/// <summary>
		/// Void IncreaseScale64(Buf12 ByRef, UInt32)
		/// </summary>
		protected static RMethod r_IncreaseScale64_Ref_Buf12_UInt32;
		public static RMethod RIncreaseScale64_Ref_Buf12_UInt32
		{
			get
			{
				if(r_IncreaseScale64_Ref_Buf12_UInt32 == null)
				{
					r_IncreaseScale64_Ref_Buf12_UInt32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "IncreaseScale64", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType(), typeof(System.UInt32));
					r_IncreaseScale64_Ref_Buf12_UInt32.SetBelong(null);
				}
				return r_IncreaseScale64_Ref_Buf12_UInt32;
			}
		}

		/// <summary>
		/// Int32 ScaleResult(Buf24*, UInt32, Int32)
		/// </summary>
		protected static RMethod r_ScaleResult_Buf24Pointer_UInt32_Int32;
		public static RMethod RScaleResult_Buf24Pointer_UInt32_Int32
		{
			get
			{
				if(r_ScaleResult_Buf24Pointer_UInt32_Int32 == null)
				{
					r_ScaleResult_Buf24Pointer_UInt32_Int32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "ScaleResult", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc+Buf24").MakePointerType(), typeof(System.UInt32), typeof(System.Int32));
					r_ScaleResult_Buf24Pointer_UInt32_Int32.SetBelong(null);
				}
				return r_ScaleResult_Buf24Pointer_UInt32_Int32;
			}
		}

		/// <summary>
		/// UInt32 DivByConst(UInt32*, UInt32, UInt32 ByRef, UInt32 ByRef, UInt32)
		/// </summary>
		protected static RMethod r_DivByConst_UInt32Pointer_UInt32_Out_UInt32_Out_UInt32_UInt32;
		public static RMethod RDivByConst_UInt32Pointer_UInt32_Out_UInt32_Out_UInt32_UInt32
		{
			get
			{
				if(r_DivByConst_UInt32Pointer_UInt32_Out_UInt32_Out_UInt32_UInt32 == null)
				{
					r_DivByConst_UInt32Pointer_UInt32_Out_UInt32_Out_UInt32_UInt32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "DivByConst", 0, typeof(System.UInt32).MakePointerType(), typeof(System.UInt32), typeof(System.UInt32).MakeByRefType(), typeof(System.UInt32).MakeByRefType(), typeof(System.UInt32));
					r_DivByConst_UInt32Pointer_UInt32_Out_UInt32_Out_UInt32_UInt32.SetBelong(null);
				}
				return r_DivByConst_UInt32Pointer_UInt32_Out_UInt32_Out_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Int32 LeadingZeroCount(UInt32)
		/// </summary>
		protected static RMethod r_LeadingZeroCount_UInt32;
		public static RMethod RLeadingZeroCount_UInt32
		{
			get
			{
				if(r_LeadingZeroCount_UInt32 == null)
				{
					r_LeadingZeroCount_UInt32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "LeadingZeroCount", 0, typeof(System.UInt32));
					r_LeadingZeroCount_UInt32.SetBelong(null);
				}
				return r_LeadingZeroCount_UInt32;
			}
		}

		/// <summary>
		/// Int32 OverflowUnscale(Buf12 ByRef, Int32, Boolean)
		/// </summary>
		protected static RMethod r_OverflowUnscale_Ref_Buf12_Int32_Boolean;
		public static RMethod ROverflowUnscale_Ref_Buf12_Int32_Boolean
		{
			get
			{
				if(r_OverflowUnscale_Ref_Buf12_Int32_Boolean == null)
				{
					r_OverflowUnscale_Ref_Buf12_Int32_Boolean = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "OverflowUnscale", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType(), typeof(System.Int32), typeof(System.Boolean));
					r_OverflowUnscale_Ref_Buf12_Int32_Boolean.SetBelong(null);
				}
				return r_OverflowUnscale_Ref_Buf12_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 SearchScale(Buf12 ByRef, Int32)
		/// </summary>
		protected static RMethod r_SearchScale_Ref_Buf12_Int32;
		public static RMethod RSearchScale_Ref_Buf12_Int32
		{
			get
			{
				if(r_SearchScale_Ref_Buf12_Int32 == null)
				{
					r_SearchScale_Ref_Buf12_Int32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "SearchScale", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType(), typeof(System.Int32));
					r_SearchScale_Ref_Buf12_Int32.SetBelong(null);
				}
				return r_SearchScale_Ref_Buf12_Int32;
			}
		}

		/// <summary>
		/// Boolean Add32To96(Buf12 ByRef, UInt32)
		/// </summary>
		protected static RMethod r_Add32To96_Ref_Buf12_UInt32;
		public static RMethod RAdd32To96_Ref_Buf12_UInt32
		{
			get
			{
				if(r_Add32To96_Ref_Buf12_UInt32 == null)
				{
					r_Add32To96_Ref_Buf12_UInt32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "Add32To96", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType(), typeof(System.UInt32));
					r_Add32To96_Ref_Buf12_UInt32.SetBelong(null);
				}
				return r_Add32To96_Ref_Buf12_UInt32;
			}
		}

		/// <summary>
		/// Void DecAddSub(DecCalc ByRef, DecCalc ByRef, Boolean)
		/// </summary>
		protected static RMethod r_DecAddSub_Ref_DecCalc_Ref_DecCalc_Boolean;
		public static RMethod RDecAddSub_Ref_DecCalc_Ref_DecCalc_Boolean
		{
			get
			{
				if(r_DecAddSub_Ref_DecCalc_Ref_DecCalc_Boolean == null)
				{
					r_DecAddSub_Ref_DecCalc_Ref_DecCalc_Boolean = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "DecAddSub", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(),  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(), typeof(System.Boolean));
					r_DecAddSub_Ref_DecCalc_Ref_DecCalc_Boolean.SetBelong(null);
				}
				return r_DecAddSub_Ref_DecCalc_Ref_DecCalc_Boolean;
			}
		}

		/// <summary>
		/// Int64 VarCyFromDec(DecCalc ByRef)
		/// </summary>
		protected static RMethod r_VarCyFromDec_Ref_DecCalc;
		public static RMethod RVarCyFromDec_Ref_DecCalc
		{
			get
			{
				if(r_VarCyFromDec_Ref_DecCalc == null)
				{
					r_VarCyFromDec_Ref_DecCalc = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "VarCyFromDec", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
					r_VarCyFromDec_Ref_DecCalc.SetBelong(null);
				}
				return r_VarCyFromDec_Ref_DecCalc;
			}
		}

		/// <summary>
		/// Int32 VarDecCmp(System.Decimal ByRef, System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_VarDecCmp_In_Decimal_In_Decimal;
		public static RMethod RVarDecCmp_In_Decimal_In_Decimal
		{
			get
			{
				if(r_VarDecCmp_In_Decimal_In_Decimal == null)
				{
					r_VarDecCmp_In_Decimal_In_Decimal = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "VarDecCmp", 0, typeof(System.Decimal).MakeByRefType(), typeof(System.Decimal).MakeByRefType());
					r_VarDecCmp_In_Decimal_In_Decimal.SetBelong(null);
				}
				return r_VarDecCmp_In_Decimal_In_Decimal;
			}
		}

		/// <summary>
		/// Int32 VarDecCmpSub(System.Decimal ByRef, System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_VarDecCmpSub_In_Decimal_In_Decimal;
		public static RMethod RVarDecCmpSub_In_Decimal_In_Decimal
		{
			get
			{
				if(r_VarDecCmpSub_In_Decimal_In_Decimal == null)
				{
					r_VarDecCmpSub_In_Decimal_In_Decimal = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "VarDecCmpSub", 0, typeof(System.Decimal).MakeByRefType(), typeof(System.Decimal).MakeByRefType());
					r_VarDecCmpSub_In_Decimal_In_Decimal.SetBelong(null);
				}
				return r_VarDecCmpSub_In_Decimal_In_Decimal;
			}
		}

		/// <summary>
		/// Void VarDecMul(DecCalc ByRef, DecCalc ByRef)
		/// </summary>
		protected static RMethod r_VarDecMul_Ref_DecCalc_Ref_DecCalc;
		public static RMethod RVarDecMul_Ref_DecCalc_Ref_DecCalc
		{
			get
			{
				if(r_VarDecMul_Ref_DecCalc_Ref_DecCalc == null)
				{
					r_VarDecMul_Ref_DecCalc_Ref_DecCalc = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "VarDecMul", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(),  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
					r_VarDecMul_Ref_DecCalc_Ref_DecCalc.SetBelong(null);
				}
				return r_VarDecMul_Ref_DecCalc_Ref_DecCalc;
			}
		}

		/// <summary>
		/// Void VarDecFromR4(Single, DecCalc ByRef)
		/// </summary>
		protected static RMethod r_VarDecFromR4_Single_Out_DecCalc;
		public static RMethod RVarDecFromR4_Single_Out_DecCalc
		{
			get
			{
				if(r_VarDecFromR4_Single_Out_DecCalc == null)
				{
					r_VarDecFromR4_Single_Out_DecCalc = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "VarDecFromR4", 0, typeof(System.Single),  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
					r_VarDecFromR4_Single_Out_DecCalc.SetBelong(null);
				}
				return r_VarDecFromR4_Single_Out_DecCalc;
			}
		}

		/// <summary>
		/// Void VarDecFromR8(Double, DecCalc ByRef)
		/// </summary>
		protected static RMethod r_VarDecFromR8_Double_Out_DecCalc;
		public static RMethod RVarDecFromR8_Double_Out_DecCalc
		{
			get
			{
				if(r_VarDecFromR8_Double_Out_DecCalc == null)
				{
					r_VarDecFromR8_Double_Out_DecCalc = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "VarDecFromR8", 0, typeof(System.Double),  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
					r_VarDecFromR8_Double_Out_DecCalc.SetBelong(null);
				}
				return r_VarDecFromR8_Double_Out_DecCalc;
			}
		}

		/// <summary>
		/// Single VarR4FromDec(System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_VarR4FromDec_In_Decimal;
		public static RMethod RVarR4FromDec_In_Decimal
		{
			get
			{
				if(r_VarR4FromDec_In_Decimal == null)
				{
					r_VarR4FromDec_In_Decimal = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "VarR4FromDec", 0, typeof(System.Decimal).MakeByRefType());
					r_VarR4FromDec_In_Decimal.SetBelong(null);
				}
				return r_VarR4FromDec_In_Decimal;
			}
		}

		/// <summary>
		/// Double VarR8FromDec(System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_VarR8FromDec_In_Decimal;
		public static RMethod RVarR8FromDec_In_Decimal
		{
			get
			{
				if(r_VarR8FromDec_In_Decimal == null)
				{
					r_VarR8FromDec_In_Decimal = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "VarR8FromDec", 0, typeof(System.Decimal).MakeByRefType());
					r_VarR8FromDec_In_Decimal.SetBelong(null);
				}
				return r_VarR8FromDec_In_Decimal;
			}
		}

		/// <summary>
		/// Int32 GetHashCode(System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_GetHashCode_In_Decimal;
		public static RMethod RGetHashCode_In_Decimal
		{
			get
			{
				if(r_GetHashCode_In_Decimal == null)
				{
					r_GetHashCode_In_Decimal = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "GetHashCode", 0, typeof(System.Decimal).MakeByRefType());
					r_GetHashCode_In_Decimal.SetBelong(null);
				}
				return r_GetHashCode_In_Decimal;
			}
		}

		/// <summary>
		/// Void VarDecDiv(DecCalc ByRef, DecCalc ByRef)
		/// </summary>
		protected static RMethod r_VarDecDiv_Ref_DecCalc_Ref_DecCalc;
		public static RMethod RVarDecDiv_Ref_DecCalc_Ref_DecCalc
		{
			get
			{
				if(r_VarDecDiv_Ref_DecCalc_Ref_DecCalc == null)
				{
					r_VarDecDiv_Ref_DecCalc_Ref_DecCalc = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "VarDecDiv", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(),  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
					r_VarDecDiv_Ref_DecCalc_Ref_DecCalc.SetBelong(null);
				}
				return r_VarDecDiv_Ref_DecCalc_Ref_DecCalc;
			}
		}

		/// <summary>
		/// Void VarDecMod(DecCalc ByRef, DecCalc ByRef)
		/// </summary>
		protected static RMethod r_VarDecMod_Ref_DecCalc_Ref_DecCalc;
		public static RMethod RVarDecMod_Ref_DecCalc_Ref_DecCalc
		{
			get
			{
				if(r_VarDecMod_Ref_DecCalc_Ref_DecCalc == null)
				{
					r_VarDecMod_Ref_DecCalc_Ref_DecCalc = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "VarDecMod", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(),  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
					r_VarDecMod_Ref_DecCalc_Ref_DecCalc.SetBelong(null);
				}
				return r_VarDecMod_Ref_DecCalc_Ref_DecCalc;
			}
		}

		/// <summary>
		/// Void VarDecModFull(DecCalc ByRef, DecCalc ByRef, Int32)
		/// </summary>
		protected static RMethod r_VarDecModFull_Ref_DecCalc_Ref_DecCalc_Int32;
		public static RMethod RVarDecModFull_Ref_DecCalc_Ref_DecCalc_Int32
		{
			get
			{
				if(r_VarDecModFull_Ref_DecCalc_Ref_DecCalc_Int32 == null)
				{
					r_VarDecModFull_Ref_DecCalc_Ref_DecCalc_Int32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "VarDecModFull", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(),  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(), typeof(System.Int32));
					r_VarDecModFull_Ref_DecCalc_Ref_DecCalc_Int32.SetBelong(null);
				}
				return r_VarDecModFull_Ref_DecCalc_Ref_DecCalc_Int32;
			}
		}

		/// <summary>
		/// Void InternalRound(DecCalc ByRef, UInt32, RoundingMode)
		/// </summary>
		protected static RMethod r_InternalRound_Ref_DecCalc_UInt32_RoundingMode;
		public static RMethod RInternalRound_Ref_DecCalc_UInt32_RoundingMode
		{
			get
			{
				if(r_InternalRound_Ref_DecCalc_UInt32_RoundingMode == null)
				{
					r_InternalRound_Ref_DecCalc_UInt32_RoundingMode = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "InternalRound", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(), typeof(System.UInt32),  ReflectionUtils.GetType("System.Decimal+DecCalc+RoundingMode"));
					r_InternalRound_Ref_DecCalc_UInt32_RoundingMode.SetBelong(null);
				}
				return r_InternalRound_Ref_DecCalc_UInt32_RoundingMode;
			}
		}

		/// <summary>
		/// UInt32 DecDivMod1E9(DecCalc ByRef)
		/// </summary>
		protected static RMethod r_DecDivMod1E9_Ref_DecCalc;
		public static RMethod RDecDivMod1E9_Ref_DecCalc
		{
			get
			{
				if(r_DecDivMod1E9_Ref_DecCalc == null)
				{
					r_DecDivMod1E9_Ref_DecCalc = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "DecDivMod1E9", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
					r_DecDivMod1E9_Ref_DecCalc.SetBelong(null);
				}
				return r_DecDivMod1E9_Ref_DecCalc;
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


        public RDecCalc() : base("System.Decimal+DecCalc")
        {
        }

        public RDecCalc(System.Object instance) : base("System.Decimal+DecCalc")
		{
            SetInstance(instance);
		}

        public RDecCalc(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDecCalc(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.UInt32 GetExponent(System.Single  @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RGetExponent_Single.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static System.UInt32 GetExponent(System.Double  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RGetExponent_Double.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static System.UInt64 UInt32x32To64(System.UInt32  @a, System.UInt32  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RUInt32x32To64_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public static void UInt64x64To128(System.UInt64  @a, System.UInt64  @b, ref RSystem.RDecimal.RDecCalc  @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @result.Value};
            var ___result = RUInt64x64To128_UInt64_UInt64_Ref_DecCalc.Invoke(___genericsType, ___parameters);

            
        }


        public static System.UInt32 Div96By32(ref RSystem.RDecimal.RDecCalc.RBuf12  @bufNum, System.UInt32  @den)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bufNum.Value, @den};
            var ___result = RDiv96By32_Ref_Buf12_UInt32.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static System.Boolean Div96ByConst(ref System.UInt64  @high64, ref System.UInt32  @low, System.UInt32  @pow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@high64, @low, @pow};
            var ___result = RDiv96ByConst_Ref_UInt64_Ref_UInt32_UInt32.Invoke(___genericsType, ___parameters);
			high64 = (System.UInt64)___parameters[0];
			low = (System.UInt32)___parameters[1];

            return (System.Boolean)___result;
        }


        public static void Unscale(ref System.UInt32  @low, ref System.UInt64  @high64, ref System.Int32  @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@low, @high64, @scale};
            var ___result = RUnscale_Ref_UInt32_Ref_UInt64_Ref_Int32.Invoke(___genericsType, ___parameters);
			low = (System.UInt32)___parameters[0];
			high64 = (System.UInt64)___parameters[1];
			scale = (System.Int32)___parameters[2];

            
        }


        public static System.UInt32 Div96By64(ref RSystem.RDecimal.RDecCalc.RBuf12  @bufNum, System.UInt64  @den)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bufNum.Value, @den};
            var ___result = RDiv96By64_Ref_Buf12_UInt64.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static System.UInt32 Div128By96(ref RSystem.RDecimal.RDecCalc.RBuf16  @bufNum, ref RSystem.RDecimal.RDecCalc.RBuf12  @bufDen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bufNum.Value, @bufDen.Value};
            var ___result = RDiv128By96_Ref_Buf16_Ref_Buf12.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static System.UInt32 IncreaseScale(ref RSystem.RDecimal.RDecCalc.RBuf12  @bufNum, System.UInt32  @power)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bufNum.Value, @power};
            var ___result = RIncreaseScale_Ref_Buf12_UInt32.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static void IncreaseScale64(ref RSystem.RDecimal.RDecCalc.RBuf12  @bufNum, System.UInt32  @power)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bufNum.Value, @power};
            var ___result = RIncreaseScale64_Ref_Buf12_UInt32.Invoke(___genericsType, ___parameters);

            
        }




        public static System.Int32 LeadingZeroCount(System.UInt32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RLeadingZeroCount_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 OverflowUnscale(ref RSystem.RDecimal.RDecCalc.RBuf12  @bufQuo, System.Int32  @scale, System.Boolean  @sticky)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bufQuo.Value, @scale, @sticky};
            var ___result = ROverflowUnscale_Ref_Buf12_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 SearchScale(ref RSystem.RDecimal.RDecCalc.RBuf12  @bufQuo, System.Int32  @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bufQuo.Value, @scale};
            var ___result = RSearchScale_Ref_Buf12_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean Add32To96(ref RSystem.RDecimal.RDecCalc.RBuf12  @bufNum, System.UInt32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bufNum.Value, @value};
            var ___result = RAdd32To96_Ref_Buf12_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void DecAddSub(ref RSystem.RDecimal.RDecCalc  @d1, ref RSystem.RDecimal.RDecCalc  @d2, System.Boolean  @sign)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1.Value, @d2.Value, @sign};
            var ___result = RDecAddSub_Ref_DecCalc_Ref_DecCalc_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int64 VarCyFromDec(ref RSystem.RDecimal.RDecCalc  @pdecIn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pdecIn.Value};
            var ___result = RVarCyFromDec_Ref_DecCalc.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public static System.Int32 VarDecCmp(in System.Decimal  @d1, in System.Decimal  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RVarDecCmp_In_Decimal_In_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 VarDecCmpSub(in System.Decimal  @d1, in System.Decimal  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RVarDecCmpSub_In_Decimal_In_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void VarDecMul(ref RSystem.RDecimal.RDecCalc  @d1, ref RSystem.RDecimal.RDecCalc  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1.Value, @d2.Value};
            var ___result = RVarDecMul_Ref_DecCalc_Ref_DecCalc.Invoke(___genericsType, ___parameters);

            
        }


        public static void VarDecFromR4(System.Single  @input, out RSystem.RDecimal.RDecCalc  @result)
        {
			result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @result.Value};
            var ___result = RVarDecFromR4_Single_Out_DecCalc.Invoke(___genericsType, ___parameters);

            
        }


        public static void VarDecFromR8(System.Double  @input, out RSystem.RDecimal.RDecCalc  @result)
        {
			result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @result.Value};
            var ___result = RVarDecFromR8_Double_Out_DecCalc.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Single VarR4FromDec(in System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RVarR4FromDec_In_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Double VarR8FromDec(in System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RVarR8FromDec_In_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Int32 GetHashCode(in System.Decimal  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RGetHashCode_In_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void VarDecDiv(ref RSystem.RDecimal.RDecCalc  @d1, ref RSystem.RDecimal.RDecCalc  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1.Value, @d2.Value};
            var ___result = RVarDecDiv_Ref_DecCalc_Ref_DecCalc.Invoke(___genericsType, ___parameters);

            
        }


        public static void VarDecMod(ref RSystem.RDecimal.RDecCalc  @d1, ref RSystem.RDecimal.RDecCalc  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1.Value, @d2.Value};
            var ___result = RVarDecMod_Ref_DecCalc_Ref_DecCalc.Invoke(___genericsType, ___parameters);

            
        }


        public static void VarDecModFull(ref RSystem.RDecimal.RDecCalc  @d1, ref RSystem.RDecimal.RDecCalc  @d2, System.Int32  @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1.Value, @d2.Value, @scale};
            var ___result = RVarDecModFull_Ref_DecCalc_Ref_DecCalc_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void InternalRound(ref RSystem.RDecimal.RDecCalc  @d, System.UInt32  @scale, RType  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d.Value, @scale, @mode.Value};
            var ___result = RInternalRound_Ref_DecCalc_UInt32_RoundingMode.Invoke(___genericsType, ___parameters);

            
        }


        public static System.UInt32 DecDivMod1E9(ref RSystem.RDecimal.RDecCalc  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RDecDivMod1E9_Ref_DecCalc.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

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
}