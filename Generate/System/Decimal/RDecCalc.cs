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
					r_SignMask = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "SignMask");
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
					r_ScaleMask = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "ScaleMask");
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
					r_DEC_SCALE_MAX = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "DEC_SCALE_MAX");
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
					r_TenToPowerNine = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "TenToPowerNine");
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
					r_TenToPowerEighteen = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "TenToPowerEighteen");
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
					r_MaxInt32Scale = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "MaxInt32Scale");
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
					r_MaxInt64Scale = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "MaxInt64Scale");
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
					r_s_powers10 = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "s_powers10");
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
					r_s_ulongPowers10 = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "s_ulongPowers10");
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
					r_s_doublePowers10 = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "s_doublePowers10");
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
					r_PowerOvflValues = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "PowerOvflValues");
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
		protected static RMethod r_RGetExponent_Single;
		public static RMethod RGetExponent_Single
		{
			get
			{
				if(r_RGetExponent_Single == null)
				{
					r_RGetExponent_Single = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "GetExponent", 0, typeof(System.Single));
					r_RGetExponent_Single.SetBelong(null);
				}
				return r_RGetExponent_Single;
			}
		}

		/// <summary>
		/// UInt32 GetExponent(Double)
		/// </summary>
		protected static RMethod r_RGetExponent_Double;
		public static RMethod RGetExponent_Double
		{
			get
			{
				if(r_RGetExponent_Double == null)
				{
					r_RGetExponent_Double = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "GetExponent", 0, typeof(System.Double));
					r_RGetExponent_Double.SetBelong(null);
				}
				return r_RGetExponent_Double;
			}
		}

		/// <summary>
		/// UInt64 UInt32x32To64(UInt32, UInt32)
		/// </summary>
		protected static RMethod r_RUInt32x32To64_UInt32_UInt32;
		public static RMethod RUInt32x32To64_UInt32_UInt32
		{
			get
			{
				if(r_RUInt32x32To64_UInt32_UInt32 == null)
				{
					r_RUInt32x32To64_UInt32_UInt32 = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "UInt32x32To64", 0, typeof(System.UInt32), typeof(System.UInt32));
					r_RUInt32x32To64_UInt32_UInt32.SetBelong(null);
				}
				return r_RUInt32x32To64_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void UInt64x64To128(UInt64, UInt64, DecCalc ByRef)
		/// </summary>
		protected static RMethod r_RUInt64x64To128_UInt64_UInt64_Ref_DecCalc;
		public static RMethod RUInt64x64To128_UInt64_UInt64_Ref_DecCalc
		{
			get
			{
				if(r_RUInt64x64To128_UInt64_UInt64_Ref_DecCalc == null)
				{
					r_RUInt64x64To128_UInt64_UInt64_Ref_DecCalc = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "UInt64x64To128", 0, typeof(System.UInt64), typeof(System.UInt64),  ReleactionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
					r_RUInt64x64To128_UInt64_UInt64_Ref_DecCalc.SetBelong(null);
				}
				return r_RUInt64x64To128_UInt64_UInt64_Ref_DecCalc;
			}
		}

		/// <summary>
		/// UInt32 Div96By32(Buf12 ByRef, UInt32)
		/// </summary>
		protected static RMethod r_RDiv96By32_Ref_Buf12_UInt32;
		public static RMethod RDiv96By32_Ref_Buf12_UInt32
		{
			get
			{
				if(r_RDiv96By32_Ref_Buf12_UInt32 == null)
				{
					r_RDiv96By32_Ref_Buf12_UInt32 = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "Div96By32", 0,  ReleactionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType(), typeof(System.UInt32));
					r_RDiv96By32_Ref_Buf12_UInt32.SetBelong(null);
				}
				return r_RDiv96By32_Ref_Buf12_UInt32;
			}
		}

		/// <summary>
		/// Boolean Div96ByConst(UInt64 ByRef, UInt32 ByRef, UInt32)
		/// </summary>
		protected static RMethod r_RDiv96ByConst_Ref_UInt64_Ref_UInt32_UInt32;
		public static RMethod RDiv96ByConst_Ref_UInt64_Ref_UInt32_UInt32
		{
			get
			{
				if(r_RDiv96ByConst_Ref_UInt64_Ref_UInt32_UInt32 == null)
				{
					r_RDiv96ByConst_Ref_UInt64_Ref_UInt32_UInt32 = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "Div96ByConst", 0, typeof(System.UInt64).MakeByRefType(), typeof(System.UInt32).MakeByRefType(), typeof(System.UInt32));
					r_RDiv96ByConst_Ref_UInt64_Ref_UInt32_UInt32.SetBelong(null);
				}
				return r_RDiv96ByConst_Ref_UInt64_Ref_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void Unscale(UInt32 ByRef, UInt64 ByRef, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RUnscale_Ref_UInt32_Ref_UInt64_Ref_Int32;
		public static RMethod RUnscale_Ref_UInt32_Ref_UInt64_Ref_Int32
		{
			get
			{
				if(r_RUnscale_Ref_UInt32_Ref_UInt64_Ref_Int32 == null)
				{
					r_RUnscale_Ref_UInt32_Ref_UInt64_Ref_Int32 = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "Unscale", 0, typeof(System.UInt32).MakeByRefType(), typeof(System.UInt64).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_RUnscale_Ref_UInt32_Ref_UInt64_Ref_Int32.SetBelong(null);
				}
				return r_RUnscale_Ref_UInt32_Ref_UInt64_Ref_Int32;
			}
		}

		/// <summary>
		/// UInt32 Div96By64(Buf12 ByRef, UInt64)
		/// </summary>
		protected static RMethod r_RDiv96By64_Ref_Buf12_UInt64;
		public static RMethod RDiv96By64_Ref_Buf12_UInt64
		{
			get
			{
				if(r_RDiv96By64_Ref_Buf12_UInt64 == null)
				{
					r_RDiv96By64_Ref_Buf12_UInt64 = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "Div96By64", 0,  ReleactionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType(), typeof(System.UInt64));
					r_RDiv96By64_Ref_Buf12_UInt64.SetBelong(null);
				}
				return r_RDiv96By64_Ref_Buf12_UInt64;
			}
		}

		/// <summary>
		/// UInt32 Div128By96(Buf16 ByRef, Buf12 ByRef)
		/// </summary>
		protected static RMethod r_RDiv128By96_Ref_Buf16_Ref_Buf12;
		public static RMethod RDiv128By96_Ref_Buf16_Ref_Buf12
		{
			get
			{
				if(r_RDiv128By96_Ref_Buf16_Ref_Buf12 == null)
				{
					r_RDiv128By96_Ref_Buf16_Ref_Buf12 = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "Div128By96", 0,  ReleactionUtils.GetType("System.Decimal+DecCalc+Buf16").MakeByRefType(),  ReleactionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType());
					r_RDiv128By96_Ref_Buf16_Ref_Buf12.SetBelong(null);
				}
				return r_RDiv128By96_Ref_Buf16_Ref_Buf12;
			}
		}

		/// <summary>
		/// UInt32 IncreaseScale(Buf12 ByRef, UInt32)
		/// </summary>
		protected static RMethod r_RIncreaseScale_Ref_Buf12_UInt32;
		public static RMethod RIncreaseScale_Ref_Buf12_UInt32
		{
			get
			{
				if(r_RIncreaseScale_Ref_Buf12_UInt32 == null)
				{
					r_RIncreaseScale_Ref_Buf12_UInt32 = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "IncreaseScale", 0,  ReleactionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType(), typeof(System.UInt32));
					r_RIncreaseScale_Ref_Buf12_UInt32.SetBelong(null);
				}
				return r_RIncreaseScale_Ref_Buf12_UInt32;
			}
		}

		/// <summary>
		/// Void IncreaseScale64(Buf12 ByRef, UInt32)
		/// </summary>
		protected static RMethod r_RIncreaseScale64_Ref_Buf12_UInt32;
		public static RMethod RIncreaseScale64_Ref_Buf12_UInt32
		{
			get
			{
				if(r_RIncreaseScale64_Ref_Buf12_UInt32 == null)
				{
					r_RIncreaseScale64_Ref_Buf12_UInt32 = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "IncreaseScale64", 0,  ReleactionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType(), typeof(System.UInt32));
					r_RIncreaseScale64_Ref_Buf12_UInt32.SetBelong(null);
				}
				return r_RIncreaseScale64_Ref_Buf12_UInt32;
			}
		}

		/// <summary>
		/// Int32 ScaleResult(Buf24*, UInt32, Int32)
		/// </summary>
		protected static RMethod r_RScaleResult_Buf24Pointer_UInt32_Int32;
		public static RMethod RScaleResult_Buf24Pointer_UInt32_Int32
		{
			get
			{
				if(r_RScaleResult_Buf24Pointer_UInt32_Int32 == null)
				{
					r_RScaleResult_Buf24Pointer_UInt32_Int32 = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "ScaleResult", 0,  ReleactionUtils.GetType("System.Decimal+DecCalc+Buf24").MakePointerType(), typeof(System.UInt32), typeof(System.Int32));
					r_RScaleResult_Buf24Pointer_UInt32_Int32.SetBelong(null);
				}
				return r_RScaleResult_Buf24Pointer_UInt32_Int32;
			}
		}

		/// <summary>
		/// UInt32 DivByConst(UInt32*, UInt32, UInt32 ByRef, UInt32 ByRef, UInt32)
		/// </summary>
		protected static RMethod r_RDivByConst_UInt32Pointer_UInt32_Out_UInt32_Out_UInt32_UInt32;
		public static RMethod RDivByConst_UInt32Pointer_UInt32_Out_UInt32_Out_UInt32_UInt32
		{
			get
			{
				if(r_RDivByConst_UInt32Pointer_UInt32_Out_UInt32_Out_UInt32_UInt32 == null)
				{
					r_RDivByConst_UInt32Pointer_UInt32_Out_UInt32_Out_UInt32_UInt32 = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "DivByConst", 0, typeof(System.UInt32).MakePointerType(), typeof(System.UInt32), typeof(System.UInt32).MakeByRefType(), typeof(System.UInt32).MakeByRefType(), typeof(System.UInt32));
					r_RDivByConst_UInt32Pointer_UInt32_Out_UInt32_Out_UInt32_UInt32.SetBelong(null);
				}
				return r_RDivByConst_UInt32Pointer_UInt32_Out_UInt32_Out_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Int32 LeadingZeroCount(UInt32)
		/// </summary>
		protected static RMethod r_RLeadingZeroCount_UInt32;
		public static RMethod RLeadingZeroCount_UInt32
		{
			get
			{
				if(r_RLeadingZeroCount_UInt32 == null)
				{
					r_RLeadingZeroCount_UInt32 = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "LeadingZeroCount", 0, typeof(System.UInt32));
					r_RLeadingZeroCount_UInt32.SetBelong(null);
				}
				return r_RLeadingZeroCount_UInt32;
			}
		}

		/// <summary>
		/// Int32 OverflowUnscale(Buf12 ByRef, Int32, Boolean)
		/// </summary>
		protected static RMethod r_ROverflowUnscale_Ref_Buf12_Int32_Boolean;
		public static RMethod ROverflowUnscale_Ref_Buf12_Int32_Boolean
		{
			get
			{
				if(r_ROverflowUnscale_Ref_Buf12_Int32_Boolean == null)
				{
					r_ROverflowUnscale_Ref_Buf12_Int32_Boolean = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "OverflowUnscale", 0,  ReleactionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType(), typeof(System.Int32), typeof(System.Boolean));
					r_ROverflowUnscale_Ref_Buf12_Int32_Boolean.SetBelong(null);
				}
				return r_ROverflowUnscale_Ref_Buf12_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 SearchScale(Buf12 ByRef, Int32)
		/// </summary>
		protected static RMethod r_RSearchScale_Ref_Buf12_Int32;
		public static RMethod RSearchScale_Ref_Buf12_Int32
		{
			get
			{
				if(r_RSearchScale_Ref_Buf12_Int32 == null)
				{
					r_RSearchScale_Ref_Buf12_Int32 = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "SearchScale", 0,  ReleactionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType(), typeof(System.Int32));
					r_RSearchScale_Ref_Buf12_Int32.SetBelong(null);
				}
				return r_RSearchScale_Ref_Buf12_Int32;
			}
		}

		/// <summary>
		/// Boolean Add32To96(Buf12 ByRef, UInt32)
		/// </summary>
		protected static RMethod r_RAdd32To96_Ref_Buf12_UInt32;
		public static RMethod RAdd32To96_Ref_Buf12_UInt32
		{
			get
			{
				if(r_RAdd32To96_Ref_Buf12_UInt32 == null)
				{
					r_RAdd32To96_Ref_Buf12_UInt32 = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "Add32To96", 0,  ReleactionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType(), typeof(System.UInt32));
					r_RAdd32To96_Ref_Buf12_UInt32.SetBelong(null);
				}
				return r_RAdd32To96_Ref_Buf12_UInt32;
			}
		}

		/// <summary>
		/// Void DecAddSub(DecCalc ByRef, DecCalc ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RDecAddSub_Ref_DecCalc_Ref_DecCalc_Boolean;
		public static RMethod RDecAddSub_Ref_DecCalc_Ref_DecCalc_Boolean
		{
			get
			{
				if(r_RDecAddSub_Ref_DecCalc_Ref_DecCalc_Boolean == null)
				{
					r_RDecAddSub_Ref_DecCalc_Ref_DecCalc_Boolean = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "DecAddSub", 0,  ReleactionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(),  ReleactionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(), typeof(System.Boolean));
					r_RDecAddSub_Ref_DecCalc_Ref_DecCalc_Boolean.SetBelong(null);
				}
				return r_RDecAddSub_Ref_DecCalc_Ref_DecCalc_Boolean;
			}
		}

		/// <summary>
		/// Int64 VarCyFromDec(DecCalc ByRef)
		/// </summary>
		protected static RMethod r_RVarCyFromDec_Ref_DecCalc;
		public static RMethod RVarCyFromDec_Ref_DecCalc
		{
			get
			{
				if(r_RVarCyFromDec_Ref_DecCalc == null)
				{
					r_RVarCyFromDec_Ref_DecCalc = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "VarCyFromDec", 0,  ReleactionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
					r_RVarCyFromDec_Ref_DecCalc.SetBelong(null);
				}
				return r_RVarCyFromDec_Ref_DecCalc;
			}
		}

		/// <summary>
		/// Int32 VarDecCmp(System.Decimal ByRef, System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_RVarDecCmp_In_Decimal_In_Decimal;
		public static RMethod RVarDecCmp_In_Decimal_In_Decimal
		{
			get
			{
				if(r_RVarDecCmp_In_Decimal_In_Decimal == null)
				{
					r_RVarDecCmp_In_Decimal_In_Decimal = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "VarDecCmp", 0, typeof(System.Decimal).MakeByRefType(), typeof(System.Decimal).MakeByRefType());
					r_RVarDecCmp_In_Decimal_In_Decimal.SetBelong(null);
				}
				return r_RVarDecCmp_In_Decimal_In_Decimal;
			}
		}

		/// <summary>
		/// Int32 VarDecCmpSub(System.Decimal ByRef, System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_RVarDecCmpSub_In_Decimal_In_Decimal;
		public static RMethod RVarDecCmpSub_In_Decimal_In_Decimal
		{
			get
			{
				if(r_RVarDecCmpSub_In_Decimal_In_Decimal == null)
				{
					r_RVarDecCmpSub_In_Decimal_In_Decimal = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "VarDecCmpSub", 0, typeof(System.Decimal).MakeByRefType(), typeof(System.Decimal).MakeByRefType());
					r_RVarDecCmpSub_In_Decimal_In_Decimal.SetBelong(null);
				}
				return r_RVarDecCmpSub_In_Decimal_In_Decimal;
			}
		}

		/// <summary>
		/// Void VarDecMul(DecCalc ByRef, DecCalc ByRef)
		/// </summary>
		protected static RMethod r_RVarDecMul_Ref_DecCalc_Ref_DecCalc;
		public static RMethod RVarDecMul_Ref_DecCalc_Ref_DecCalc
		{
			get
			{
				if(r_RVarDecMul_Ref_DecCalc_Ref_DecCalc == null)
				{
					r_RVarDecMul_Ref_DecCalc_Ref_DecCalc = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "VarDecMul", 0,  ReleactionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(),  ReleactionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
					r_RVarDecMul_Ref_DecCalc_Ref_DecCalc.SetBelong(null);
				}
				return r_RVarDecMul_Ref_DecCalc_Ref_DecCalc;
			}
		}

		/// <summary>
		/// Void VarDecFromR4(Single, DecCalc ByRef)
		/// </summary>
		protected static RMethod r_RVarDecFromR4_Single_Out_DecCalc;
		public static RMethod RVarDecFromR4_Single_Out_DecCalc
		{
			get
			{
				if(r_RVarDecFromR4_Single_Out_DecCalc == null)
				{
					r_RVarDecFromR4_Single_Out_DecCalc = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "VarDecFromR4", 0, typeof(System.Single),  ReleactionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
					r_RVarDecFromR4_Single_Out_DecCalc.SetBelong(null);
				}
				return r_RVarDecFromR4_Single_Out_DecCalc;
			}
		}

		/// <summary>
		/// Void VarDecFromR8(Double, DecCalc ByRef)
		/// </summary>
		protected static RMethod r_RVarDecFromR8_Double_Out_DecCalc;
		public static RMethod RVarDecFromR8_Double_Out_DecCalc
		{
			get
			{
				if(r_RVarDecFromR8_Double_Out_DecCalc == null)
				{
					r_RVarDecFromR8_Double_Out_DecCalc = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "VarDecFromR8", 0, typeof(System.Double),  ReleactionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
					r_RVarDecFromR8_Double_Out_DecCalc.SetBelong(null);
				}
				return r_RVarDecFromR8_Double_Out_DecCalc;
			}
		}

		/// <summary>
		/// Single VarR4FromDec(System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_RVarR4FromDec_In_Decimal;
		public static RMethod RVarR4FromDec_In_Decimal
		{
			get
			{
				if(r_RVarR4FromDec_In_Decimal == null)
				{
					r_RVarR4FromDec_In_Decimal = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "VarR4FromDec", 0, typeof(System.Decimal).MakeByRefType());
					r_RVarR4FromDec_In_Decimal.SetBelong(null);
				}
				return r_RVarR4FromDec_In_Decimal;
			}
		}

		/// <summary>
		/// Double VarR8FromDec(System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_RVarR8FromDec_In_Decimal;
		public static RMethod RVarR8FromDec_In_Decimal
		{
			get
			{
				if(r_RVarR8FromDec_In_Decimal == null)
				{
					r_RVarR8FromDec_In_Decimal = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "VarR8FromDec", 0, typeof(System.Decimal).MakeByRefType());
					r_RVarR8FromDec_In_Decimal.SetBelong(null);
				}
				return r_RVarR8FromDec_In_Decimal;
			}
		}

		/// <summary>
		/// Int32 GetHashCode(System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_RGetHashCode_In_Decimal;
		public static RMethod RGetHashCode_In_Decimal
		{
			get
			{
				if(r_RGetHashCode_In_Decimal == null)
				{
					r_RGetHashCode_In_Decimal = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "GetHashCode", 0, typeof(System.Decimal).MakeByRefType());
					r_RGetHashCode_In_Decimal.SetBelong(null);
				}
				return r_RGetHashCode_In_Decimal;
			}
		}

		/// <summary>
		/// Void VarDecDiv(DecCalc ByRef, DecCalc ByRef)
		/// </summary>
		protected static RMethod r_RVarDecDiv_Ref_DecCalc_Ref_DecCalc;
		public static RMethod RVarDecDiv_Ref_DecCalc_Ref_DecCalc
		{
			get
			{
				if(r_RVarDecDiv_Ref_DecCalc_Ref_DecCalc == null)
				{
					r_RVarDecDiv_Ref_DecCalc_Ref_DecCalc = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "VarDecDiv", 0,  ReleactionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(),  ReleactionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
					r_RVarDecDiv_Ref_DecCalc_Ref_DecCalc.SetBelong(null);
				}
				return r_RVarDecDiv_Ref_DecCalc_Ref_DecCalc;
			}
		}

		/// <summary>
		/// Void VarDecMod(DecCalc ByRef, DecCalc ByRef)
		/// </summary>
		protected static RMethod r_RVarDecMod_Ref_DecCalc_Ref_DecCalc;
		public static RMethod RVarDecMod_Ref_DecCalc_Ref_DecCalc
		{
			get
			{
				if(r_RVarDecMod_Ref_DecCalc_Ref_DecCalc == null)
				{
					r_RVarDecMod_Ref_DecCalc_Ref_DecCalc = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "VarDecMod", 0,  ReleactionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(),  ReleactionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
					r_RVarDecMod_Ref_DecCalc_Ref_DecCalc.SetBelong(null);
				}
				return r_RVarDecMod_Ref_DecCalc_Ref_DecCalc;
			}
		}

		/// <summary>
		/// Void VarDecModFull(DecCalc ByRef, DecCalc ByRef, Int32)
		/// </summary>
		protected static RMethod r_RVarDecModFull_Ref_DecCalc_Ref_DecCalc_Int32;
		public static RMethod RVarDecModFull_Ref_DecCalc_Ref_DecCalc_Int32
		{
			get
			{
				if(r_RVarDecModFull_Ref_DecCalc_Ref_DecCalc_Int32 == null)
				{
					r_RVarDecModFull_Ref_DecCalc_Ref_DecCalc_Int32 = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "VarDecModFull", 0,  ReleactionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(),  ReleactionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(), typeof(System.Int32));
					r_RVarDecModFull_Ref_DecCalc_Ref_DecCalc_Int32.SetBelong(null);
				}
				return r_RVarDecModFull_Ref_DecCalc_Ref_DecCalc_Int32;
			}
		}

		/// <summary>
		/// Void InternalRound(DecCalc ByRef, UInt32, RoundingMode)
		/// </summary>
		protected static RMethod r_RInternalRound_Ref_DecCalc_UInt32_RoundingMode;
		public static RMethod RInternalRound_Ref_DecCalc_UInt32_RoundingMode
		{
			get
			{
				if(r_RInternalRound_Ref_DecCalc_UInt32_RoundingMode == null)
				{
					r_RInternalRound_Ref_DecCalc_UInt32_RoundingMode = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "InternalRound", 0,  ReleactionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(), typeof(System.UInt32),  ReleactionUtils.GetType("System.Decimal+DecCalc+RoundingMode"));
					r_RInternalRound_Ref_DecCalc_UInt32_RoundingMode.SetBelong(null);
				}
				return r_RInternalRound_Ref_DecCalc_UInt32_RoundingMode;
			}
		}

		/// <summary>
		/// UInt32 DecDivMod1E9(DecCalc ByRef)
		/// </summary>
		protected static RMethod r_RDecDivMod1E9_Ref_DecCalc;
		public static RMethod RDecDivMod1E9_Ref_DecCalc
		{
			get
			{
				if(r_RDecDivMod1E9_Ref_DecCalc == null)
				{
					r_RDecDivMod1E9_Ref_DecCalc = new( ReleactionUtils.GetType("System.Decimal+DecCalc"), "DecDivMod1E9", 0,  ReleactionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
					r_RDecDivMod1E9_Ref_DecCalc.SetBelong(null);
				}
				return r_RDecDivMod1E9_Ref_DecCalc;
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








        public static System.Int32 LeadingZeroCount(System.UInt32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RLeadingZeroCount_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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