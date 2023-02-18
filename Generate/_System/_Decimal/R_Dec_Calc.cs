
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
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
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fuflags;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFuflags
		{
			get
			{
				if(r_Fuflags == null)
				{
					r_Fuflags = new(this, "uflags");
				}
				return r_Fuflags;
			}
		}

		/// <summary>
		/// System.UInt32 uhi
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fuhi;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFuhi
		{
			get
			{
				if(r_Fuhi == null)
				{
					r_Fuhi = new(this, "uhi");
				}
				return r_Fuhi;
			}
		}

		/// <summary>
		/// System.UInt32 ulo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fulo;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFulo
		{
			get
			{
				if(r_Fulo == null)
				{
					r_Fulo = new(this, "ulo");
				}
				return r_Fulo;
			}
		}

		/// <summary>
		/// System.UInt32 umid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fumid;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFumid
		{
			get
			{
				if(r_Fumid == null)
				{
					r_Fumid = new(this, "umid");
				}
				return r_Fumid;
			}
		}

		/// <summary>
		/// System.UInt64 ulomidLE
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt64 r_FulomidLE;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt64 RFulomidLE
		{
			get
			{
				if(r_FulomidLE == null)
				{
					r_FulomidLE = new(this, "ulomidLE");
				}
				return r_FulomidLE;
			}
		}

		/// <summary>
		/// System.UInt32 SignMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt32 r_FSignMask;
		public static Hvak.Editor.Refleaction.RSystem.RUInt32 RFSignMask
		{
			get
			{
				if(r_FSignMask == null)
				{
					r_FSignMask = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "SignMask");
				}
				return r_FSignMask;
			}
		}

		/// <summary>
		/// System.UInt32 ScaleMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt32 r_FScaleMask;
		public static Hvak.Editor.Refleaction.RSystem.RUInt32 RFScaleMask
		{
			get
			{
				if(r_FScaleMask == null)
				{
					r_FScaleMask = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "ScaleMask");
				}
				return r_FScaleMask;
			}
		}

		/// <summary>
		/// System.Int32 DEC_SCALE_MAX
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDEC_SCALE_MAX;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDEC_SCALE_MAX
		{
			get
			{
				if(r_FDEC_SCALE_MAX == null)
				{
					r_FDEC_SCALE_MAX = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "DEC_SCALE_MAX");
				}
				return r_FDEC_SCALE_MAX;
			}
		}

		/// <summary>
		/// System.UInt32 TenToPowerNine
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt32 r_FTenToPowerNine;
		public static Hvak.Editor.Refleaction.RSystem.RUInt32 RFTenToPowerNine
		{
			get
			{
				if(r_FTenToPowerNine == null)
				{
					r_FTenToPowerNine = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "TenToPowerNine");
				}
				return r_FTenToPowerNine;
			}
		}

		/// <summary>
		/// System.UInt64 TenToPowerEighteen
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt64 r_FTenToPowerEighteen;
		public static Hvak.Editor.Refleaction.RSystem.RUInt64 RFTenToPowerEighteen
		{
			get
			{
				if(r_FTenToPowerEighteen == null)
				{
					r_FTenToPowerEighteen = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "TenToPowerEighteen");
				}
				return r_FTenToPowerEighteen;
			}
		}

		/// <summary>
		/// System.Int32 MaxInt32Scale
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMaxInt32Scale;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMaxInt32Scale
		{
			get
			{
				if(r_FMaxInt32Scale == null)
				{
					r_FMaxInt32Scale = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "MaxInt32Scale");
				}
				return r_FMaxInt32Scale;
			}
		}

		/// <summary>
		/// System.Int32 MaxInt64Scale
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMaxInt64Scale;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMaxInt64Scale
		{
			get
			{
				if(r_FMaxInt64Scale == null)
				{
					r_FMaxInt64Scale = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "MaxInt64Scale");
				}
				return r_FMaxInt64Scale;
			}
		}

		/// <summary>
		/// System.UInt32[] s_powers10
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RUInt32> r_Fs_powers10;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RUInt32> RFs_powers10
		{
			get
			{
				if(r_Fs_powers10 == null)
				{
					r_Fs_powers10 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "s_powers10");
				}
				return r_Fs_powers10;
			}
		}

		/// <summary>
		/// System.UInt64[] s_ulongPowers10
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RUInt64> r_Fs_ulongPowers10;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RUInt64> RFs_ulongPowers10
		{
			get
			{
				if(r_Fs_ulongPowers10 == null)
				{
					r_Fs_ulongPowers10 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "s_ulongPowers10");
				}
				return r_Fs_ulongPowers10;
			}
		}

		/// <summary>
		/// System.Double[] s_doublePowers10
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RDouble> r_Fs_doublePowers10;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RDouble> RFs_doublePowers10
		{
			get
			{
				if(r_Fs_doublePowers10 == null)
				{
					r_Fs_doublePowers10 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "s_doublePowers10");
				}
				return r_Fs_doublePowers10;
			}
		}

		/// <summary>
		/// System.Decimal+DecCalc+PowerOvfl[] PowerOvflValues
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc.RPowerOvfl> r_FPowerOvflValues;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc.RPowerOvfl> RFPowerOvflValues
		{
			get
			{
				if(r_FPowerOvflValues == null)
				{
					r_FPowerOvflValues = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "PowerOvflValues");
				}
				return r_FPowerOvflValues;
			}
		}

		/// <summary>
		/// UInt32 High
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_PHigh;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPHigh
		{
			get
			{
				if(r_PHigh == null)
				{
					r_PHigh = new(this, "High", -1);
				}
				return r_PHigh;
			}
		}

		/// <summary>
		/// UInt32 Low
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_PLow;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPLow
		{
			get
			{
				if(r_PLow == null)
				{
					r_PLow = new(this, "Low", -1);
				}
				return r_PLow;
			}
		}

		/// <summary>
		/// UInt32 Mid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_PMid;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPMid
		{
			get
			{
				if(r_PMid == null)
				{
					r_PMid = new(this, "Mid", -1);
				}
				return r_PMid;
			}
		}

		/// <summary>
		/// Boolean IsNegative
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsNegative;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsNegative
		{
			get
			{
				if(r_PIsNegative == null)
				{
					r_PIsNegative = new(this, "IsNegative", -1);
				}
				return r_PIsNegative;
			}
		}

		/// <summary>
		/// Int32 Scale
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PScale;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPScale
		{
			get
			{
				if(r_PScale == null)
				{
					r_PScale = new(this, "Scale", -1);
				}
				return r_PScale;
			}
		}

		/// <summary>
		/// UInt64 Low64
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt64 r_PLow64;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt64 RPLow64
		{
			get
			{
				if(r_PLow64 == null)
				{
					r_PLow64 = new(this, "Low64", -1);
				}
				return r_PLow64;
			}
		}

		/// <summary>
		/// UInt32 GetExponent(Single)
		/// </summary>
		protected static RMethod r_MGetExponent_Single;
		public static RMethod RMGetExponent_Single
		{
			get
			{
				if(r_MGetExponent_Single == null)
				{
					r_MGetExponent_Single = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "GetExponent", 0, typeof(System.Single));
				}
				return r_MGetExponent_Single;
			}
		}

		/// <summary>
		/// UInt32 GetExponent(Double)
		/// </summary>
		protected static RMethod r_MGetExponent_Double;
		public static RMethod RMGetExponent_Double
		{
			get
			{
				if(r_MGetExponent_Double == null)
				{
					r_MGetExponent_Double = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "GetExponent", 0, typeof(System.Double));
				}
				return r_MGetExponent_Double;
			}
		}

		/// <summary>
		/// UInt64 UInt32x32To64(UInt32, UInt32)
		/// </summary>
		protected static RMethod r_MUInt32x32To64_UInt32_UInt32;
		public static RMethod RMUInt32x32To64_UInt32_UInt32
		{
			get
			{
				if(r_MUInt32x32To64_UInt32_UInt32 == null)
				{
					r_MUInt32x32To64_UInt32_UInt32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "UInt32x32To64", 0, typeof(System.UInt32), typeof(System.UInt32));
				}
				return r_MUInt32x32To64_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void UInt64x64To128(UInt64, UInt64, DecCalc ByRef)
		/// </summary>
		protected static RMethod r_MUInt64x64To128_UInt64_UInt64_Ref_DecCalc;
		public static RMethod RMUInt64x64To128_UInt64_UInt64_Ref_DecCalc
		{
			get
			{
				if(r_MUInt64x64To128_UInt64_UInt64_Ref_DecCalc == null)
				{
					r_MUInt64x64To128_UInt64_UInt64_Ref_DecCalc = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "UInt64x64To128", 0, typeof(System.UInt64), typeof(System.UInt64),  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
				}
				return r_MUInt64x64To128_UInt64_UInt64_Ref_DecCalc;
			}
		}

		/// <summary>
		/// UInt32 Div96By32(Buf12 ByRef, UInt32)
		/// </summary>
		protected static RMethod r_MDiv96By32_Ref_Buf12_UInt32;
		public static RMethod RMDiv96By32_Ref_Buf12_UInt32
		{
			get
			{
				if(r_MDiv96By32_Ref_Buf12_UInt32 == null)
				{
					r_MDiv96By32_Ref_Buf12_UInt32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "Div96By32", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType(), typeof(System.UInt32));
				}
				return r_MDiv96By32_Ref_Buf12_UInt32;
			}
		}

		/// <summary>
		/// Boolean Div96ByConst(UInt64 ByRef, UInt32 ByRef, UInt32)
		/// </summary>
		protected static RMethod r_MDiv96ByConst_Ref_UInt64_Ref_UInt32_UInt32;
		public static RMethod RMDiv96ByConst_Ref_UInt64_Ref_UInt32_UInt32
		{
			get
			{
				if(r_MDiv96ByConst_Ref_UInt64_Ref_UInt32_UInt32 == null)
				{
					r_MDiv96ByConst_Ref_UInt64_Ref_UInt32_UInt32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "Div96ByConst", 0, typeof(System.UInt64).MakeByRefType(), typeof(System.UInt32).MakeByRefType(), typeof(System.UInt32));
				}
				return r_MDiv96ByConst_Ref_UInt64_Ref_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Void Unscale(UInt32 ByRef, UInt64 ByRef, Int32 ByRef)
		/// </summary>
		protected static RMethod r_MUnscale_Ref_UInt32_Ref_UInt64_Ref_Int32;
		public static RMethod RMUnscale_Ref_UInt32_Ref_UInt64_Ref_Int32
		{
			get
			{
				if(r_MUnscale_Ref_UInt32_Ref_UInt64_Ref_Int32 == null)
				{
					r_MUnscale_Ref_UInt32_Ref_UInt64_Ref_Int32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "Unscale", 0, typeof(System.UInt32).MakeByRefType(), typeof(System.UInt64).MakeByRefType(), typeof(System.Int32).MakeByRefType());
				}
				return r_MUnscale_Ref_UInt32_Ref_UInt64_Ref_Int32;
			}
		}

		/// <summary>
		/// UInt32 Div96By64(Buf12 ByRef, UInt64)
		/// </summary>
		protected static RMethod r_MDiv96By64_Ref_Buf12_UInt64;
		public static RMethod RMDiv96By64_Ref_Buf12_UInt64
		{
			get
			{
				if(r_MDiv96By64_Ref_Buf12_UInt64 == null)
				{
					r_MDiv96By64_Ref_Buf12_UInt64 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "Div96By64", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType(), typeof(System.UInt64));
				}
				return r_MDiv96By64_Ref_Buf12_UInt64;
			}
		}

		/// <summary>
		/// UInt32 Div128By96(Buf16 ByRef, Buf12 ByRef)
		/// </summary>
		protected static RMethod r_MDiv128By96_Ref_Buf16_Ref_Buf12;
		public static RMethod RMDiv128By96_Ref_Buf16_Ref_Buf12
		{
			get
			{
				if(r_MDiv128By96_Ref_Buf16_Ref_Buf12 == null)
				{
					r_MDiv128By96_Ref_Buf16_Ref_Buf12 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "Div128By96", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc+Buf16").MakeByRefType(),  ReflectionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType());
				}
				return r_MDiv128By96_Ref_Buf16_Ref_Buf12;
			}
		}

		/// <summary>
		/// UInt32 IncreaseScale(Buf12 ByRef, UInt32)
		/// </summary>
		protected static RMethod r_MIncreaseScale_Ref_Buf12_UInt32;
		public static RMethod RMIncreaseScale_Ref_Buf12_UInt32
		{
			get
			{
				if(r_MIncreaseScale_Ref_Buf12_UInt32 == null)
				{
					r_MIncreaseScale_Ref_Buf12_UInt32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "IncreaseScale", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType(), typeof(System.UInt32));
				}
				return r_MIncreaseScale_Ref_Buf12_UInt32;
			}
		}

		/// <summary>
		/// Void IncreaseScale64(Buf12 ByRef, UInt32)
		/// </summary>
		protected static RMethod r_MIncreaseScale64_Ref_Buf12_UInt32;
		public static RMethod RMIncreaseScale64_Ref_Buf12_UInt32
		{
			get
			{
				if(r_MIncreaseScale64_Ref_Buf12_UInt32 == null)
				{
					r_MIncreaseScale64_Ref_Buf12_UInt32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "IncreaseScale64", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType(), typeof(System.UInt32));
				}
				return r_MIncreaseScale64_Ref_Buf12_UInt32;
			}
		}

		/// <summary>
		/// Int32 ScaleResult(Buf24*, UInt32, Int32)
		/// </summary>
		protected static RMethod r_MScaleResult_Buf24Pointer_UInt32_Int32;
		public static RMethod RMScaleResult_Buf24Pointer_UInt32_Int32
		{
			get
			{
				if(r_MScaleResult_Buf24Pointer_UInt32_Int32 == null)
				{
					r_MScaleResult_Buf24Pointer_UInt32_Int32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "ScaleResult", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc+Buf24").MakePointerType(), typeof(System.UInt32), typeof(System.Int32));
				}
				return r_MScaleResult_Buf24Pointer_UInt32_Int32;
			}
		}

		/// <summary>
		/// UInt32 DivByConst(UInt32*, UInt32, UInt32 ByRef, UInt32 ByRef, UInt32)
		/// </summary>
		protected static RMethod r_MDivByConst_UInt32Pointer_UInt32_Out_UInt32_Out_UInt32_UInt32;
		public static RMethod RMDivByConst_UInt32Pointer_UInt32_Out_UInt32_Out_UInt32_UInt32
		{
			get
			{
				if(r_MDivByConst_UInt32Pointer_UInt32_Out_UInt32_Out_UInt32_UInt32 == null)
				{
					r_MDivByConst_UInt32Pointer_UInt32_Out_UInt32_Out_UInt32_UInt32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "DivByConst", 0, typeof(System.UInt32).MakePointerType(), typeof(System.UInt32), typeof(System.UInt32).MakeByRefType(), typeof(System.UInt32).MakeByRefType(), typeof(System.UInt32));
				}
				return r_MDivByConst_UInt32Pointer_UInt32_Out_UInt32_Out_UInt32_UInt32;
			}
		}

		/// <summary>
		/// Int32 LeadingZeroCount(UInt32)
		/// </summary>
		protected static RMethod r_MLeadingZeroCount_UInt32;
		public static RMethod RMLeadingZeroCount_UInt32
		{
			get
			{
				if(r_MLeadingZeroCount_UInt32 == null)
				{
					r_MLeadingZeroCount_UInt32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "LeadingZeroCount", 0, typeof(System.UInt32));
				}
				return r_MLeadingZeroCount_UInt32;
			}
		}

		/// <summary>
		/// Int32 OverflowUnscale(Buf12 ByRef, Int32, Boolean)
		/// </summary>
		protected static RMethod r_MOverflowUnscale_Ref_Buf12_Int32_Boolean;
		public static RMethod RMOverflowUnscale_Ref_Buf12_Int32_Boolean
		{
			get
			{
				if(r_MOverflowUnscale_Ref_Buf12_Int32_Boolean == null)
				{
					r_MOverflowUnscale_Ref_Buf12_Int32_Boolean = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "OverflowUnscale", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType(), typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MOverflowUnscale_Ref_Buf12_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 SearchScale(Buf12 ByRef, Int32)
		/// </summary>
		protected static RMethod r_MSearchScale_Ref_Buf12_Int32;
		public static RMethod RMSearchScale_Ref_Buf12_Int32
		{
			get
			{
				if(r_MSearchScale_Ref_Buf12_Int32 == null)
				{
					r_MSearchScale_Ref_Buf12_Int32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "SearchScale", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType(), typeof(System.Int32));
				}
				return r_MSearchScale_Ref_Buf12_Int32;
			}
		}

		/// <summary>
		/// Boolean Add32To96(Buf12 ByRef, UInt32)
		/// </summary>
		protected static RMethod r_MAdd32To96_Ref_Buf12_UInt32;
		public static RMethod RMAdd32To96_Ref_Buf12_UInt32
		{
			get
			{
				if(r_MAdd32To96_Ref_Buf12_UInt32 == null)
				{
					r_MAdd32To96_Ref_Buf12_UInt32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "Add32To96", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc+Buf12").MakeByRefType(), typeof(System.UInt32));
				}
				return r_MAdd32To96_Ref_Buf12_UInt32;
			}
		}

		/// <summary>
		/// Void DecAddSub(DecCalc ByRef, DecCalc ByRef, Boolean)
		/// </summary>
		protected static RMethod r_MDecAddSub_Ref_DecCalc_Ref_DecCalc_Boolean;
		public static RMethod RMDecAddSub_Ref_DecCalc_Ref_DecCalc_Boolean
		{
			get
			{
				if(r_MDecAddSub_Ref_DecCalc_Ref_DecCalc_Boolean == null)
				{
					r_MDecAddSub_Ref_DecCalc_Ref_DecCalc_Boolean = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "DecAddSub", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(),  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(), typeof(System.Boolean));
				}
				return r_MDecAddSub_Ref_DecCalc_Ref_DecCalc_Boolean;
			}
		}

		/// <summary>
		/// Int64 VarCyFromDec(DecCalc ByRef)
		/// </summary>
		protected static RMethod r_MVarCyFromDec_Ref_DecCalc;
		public static RMethod RMVarCyFromDec_Ref_DecCalc
		{
			get
			{
				if(r_MVarCyFromDec_Ref_DecCalc == null)
				{
					r_MVarCyFromDec_Ref_DecCalc = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "VarCyFromDec", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
				}
				return r_MVarCyFromDec_Ref_DecCalc;
			}
		}

		/// <summary>
		/// Int32 VarDecCmp(System.Decimal ByRef, System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_MVarDecCmp_In_Decimal_In_Decimal;
		public static RMethod RMVarDecCmp_In_Decimal_In_Decimal
		{
			get
			{
				if(r_MVarDecCmp_In_Decimal_In_Decimal == null)
				{
					r_MVarDecCmp_In_Decimal_In_Decimal = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "VarDecCmp", 0, typeof(System.Decimal).MakeByRefType(), typeof(System.Decimal).MakeByRefType());
				}
				return r_MVarDecCmp_In_Decimal_In_Decimal;
			}
		}

		/// <summary>
		/// Int32 VarDecCmpSub(System.Decimal ByRef, System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_MVarDecCmpSub_In_Decimal_In_Decimal;
		public static RMethod RMVarDecCmpSub_In_Decimal_In_Decimal
		{
			get
			{
				if(r_MVarDecCmpSub_In_Decimal_In_Decimal == null)
				{
					r_MVarDecCmpSub_In_Decimal_In_Decimal = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "VarDecCmpSub", 0, typeof(System.Decimal).MakeByRefType(), typeof(System.Decimal).MakeByRefType());
				}
				return r_MVarDecCmpSub_In_Decimal_In_Decimal;
			}
		}

		/// <summary>
		/// Void VarDecMul(DecCalc ByRef, DecCalc ByRef)
		/// </summary>
		protected static RMethod r_MVarDecMul_Ref_DecCalc_Ref_DecCalc;
		public static RMethod RMVarDecMul_Ref_DecCalc_Ref_DecCalc
		{
			get
			{
				if(r_MVarDecMul_Ref_DecCalc_Ref_DecCalc == null)
				{
					r_MVarDecMul_Ref_DecCalc_Ref_DecCalc = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "VarDecMul", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(),  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
				}
				return r_MVarDecMul_Ref_DecCalc_Ref_DecCalc;
			}
		}

		/// <summary>
		/// Void VarDecFromR4(Single, DecCalc ByRef)
		/// </summary>
		protected static RMethod r_MVarDecFromR4_Single_Out_DecCalc;
		public static RMethod RMVarDecFromR4_Single_Out_DecCalc
		{
			get
			{
				if(r_MVarDecFromR4_Single_Out_DecCalc == null)
				{
					r_MVarDecFromR4_Single_Out_DecCalc = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "VarDecFromR4", 0, typeof(System.Single),  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
				}
				return r_MVarDecFromR4_Single_Out_DecCalc;
			}
		}

		/// <summary>
		/// Void VarDecFromR8(Double, DecCalc ByRef)
		/// </summary>
		protected static RMethod r_MVarDecFromR8_Double_Out_DecCalc;
		public static RMethod RMVarDecFromR8_Double_Out_DecCalc
		{
			get
			{
				if(r_MVarDecFromR8_Double_Out_DecCalc == null)
				{
					r_MVarDecFromR8_Double_Out_DecCalc = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "VarDecFromR8", 0, typeof(System.Double),  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
				}
				return r_MVarDecFromR8_Double_Out_DecCalc;
			}
		}

		/// <summary>
		/// Single VarR4FromDec(System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_MVarR4FromDec_In_Decimal;
		public static RMethod RMVarR4FromDec_In_Decimal
		{
			get
			{
				if(r_MVarR4FromDec_In_Decimal == null)
				{
					r_MVarR4FromDec_In_Decimal = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "VarR4FromDec", 0, typeof(System.Decimal).MakeByRefType());
				}
				return r_MVarR4FromDec_In_Decimal;
			}
		}

		/// <summary>
		/// Double VarR8FromDec(System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_MVarR8FromDec_In_Decimal;
		public static RMethod RMVarR8FromDec_In_Decimal
		{
			get
			{
				if(r_MVarR8FromDec_In_Decimal == null)
				{
					r_MVarR8FromDec_In_Decimal = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "VarR8FromDec", 0, typeof(System.Decimal).MakeByRefType());
				}
				return r_MVarR8FromDec_In_Decimal;
			}
		}

		/// <summary>
		/// Int32 GetHashCode(System.Decimal ByRef)
		/// </summary>
		protected static RMethod r_MGetHashCode_In_Decimal;
		public static RMethod RMGetHashCode_In_Decimal
		{
			get
			{
				if(r_MGetHashCode_In_Decimal == null)
				{
					r_MGetHashCode_In_Decimal = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "GetHashCode", 0, typeof(System.Decimal).MakeByRefType());
				}
				return r_MGetHashCode_In_Decimal;
			}
		}

		/// <summary>
		/// Void VarDecDiv(DecCalc ByRef, DecCalc ByRef)
		/// </summary>
		protected static RMethod r_MVarDecDiv_Ref_DecCalc_Ref_DecCalc;
		public static RMethod RMVarDecDiv_Ref_DecCalc_Ref_DecCalc
		{
			get
			{
				if(r_MVarDecDiv_Ref_DecCalc_Ref_DecCalc == null)
				{
					r_MVarDecDiv_Ref_DecCalc_Ref_DecCalc = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "VarDecDiv", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(),  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
				}
				return r_MVarDecDiv_Ref_DecCalc_Ref_DecCalc;
			}
		}

		/// <summary>
		/// Void VarDecMod(DecCalc ByRef, DecCalc ByRef)
		/// </summary>
		protected static RMethod r_MVarDecMod_Ref_DecCalc_Ref_DecCalc;
		public static RMethod RMVarDecMod_Ref_DecCalc_Ref_DecCalc
		{
			get
			{
				if(r_MVarDecMod_Ref_DecCalc_Ref_DecCalc == null)
				{
					r_MVarDecMod_Ref_DecCalc_Ref_DecCalc = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "VarDecMod", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(),  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
				}
				return r_MVarDecMod_Ref_DecCalc_Ref_DecCalc;
			}
		}

		/// <summary>
		/// Void VarDecModFull(DecCalc ByRef, DecCalc ByRef, Int32)
		/// </summary>
		protected static RMethod r_MVarDecModFull_Ref_DecCalc_Ref_DecCalc_Int32;
		public static RMethod RMVarDecModFull_Ref_DecCalc_Ref_DecCalc_Int32
		{
			get
			{
				if(r_MVarDecModFull_Ref_DecCalc_Ref_DecCalc_Int32 == null)
				{
					r_MVarDecModFull_Ref_DecCalc_Ref_DecCalc_Int32 = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "VarDecModFull", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(),  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(), typeof(System.Int32));
				}
				return r_MVarDecModFull_Ref_DecCalc_Ref_DecCalc_Int32;
			}
		}

		/// <summary>
		/// Void InternalRound(DecCalc ByRef, UInt32, RoundingMode)
		/// </summary>
		protected static RMethod r_MInternalRound_Ref_DecCalc_UInt32_RoundingMode;
		public static RMethod RMInternalRound_Ref_DecCalc_UInt32_RoundingMode
		{
			get
			{
				if(r_MInternalRound_Ref_DecCalc_UInt32_RoundingMode == null)
				{
					r_MInternalRound_Ref_DecCalc_UInt32_RoundingMode = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "InternalRound", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType(), typeof(System.UInt32),  ReflectionUtils.GetType("System.Decimal+DecCalc+RoundingMode"));
				}
				return r_MInternalRound_Ref_DecCalc_UInt32_RoundingMode;
			}
		}

		/// <summary>
		/// UInt32 DecDivMod1E9(DecCalc ByRef)
		/// </summary>
		protected static RMethod r_MDecDivMod1E9_Ref_DecCalc;
		public static RMethod RMDecDivMod1E9_Ref_DecCalc
		{
			get
			{
				if(r_MDecDivMod1E9_Ref_DecCalc == null)
				{
					r_MDecDivMod1E9_Ref_DecCalc = new( ReflectionUtils.GetType("System.Decimal+DecCalc"), "DecDivMod1E9", 0,  ReflectionUtils.GetType("System.Decimal+DecCalc").MakeByRefType());
				}
				return r_MDecDivMod1E9_Ref_DecCalc;
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

        public static System.UInt32 GetExponent(System.Single @f)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@f};
            var ___result = RMGetExponent_Single.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static System.UInt32 GetExponent(System.Double @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMGetExponent_Double.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public static System.UInt64 UInt32x32To64(System.UInt32 @a, System.UInt32 @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMUInt32x32To64_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public static void UInt64x64To128(System.UInt64 @a, System.UInt64 @b, ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @result.Value};
            var ___result = RMUInt64x64To128_UInt64_UInt64_Ref_DecCalc.Invoke(___genericsType, ___parameters);
			@result = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc(___parameters[2]);

            
        }


        public static System.UInt32 Div96By32(ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc.RBuf12 @bufNum, System.UInt32 @den)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bufNum.Value, @den};
            var ___result = RMDiv96By32_Ref_Buf12_UInt32.Invoke(___genericsType, ___parameters);
			@bufNum = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc.RBuf12(___parameters[0]);

            return (System.UInt32)___result;
        }


        public static System.Boolean Div96ByConst(ref System.UInt64 @high64, ref System.UInt32 @low, System.UInt32 @pow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@high64, @low, @pow};
            var ___result = RMDiv96ByConst_Ref_UInt64_Ref_UInt32_UInt32.Invoke(___genericsType, ___parameters);
			@high64 = (System.UInt64)___parameters[0];
			@low = (System.UInt32)___parameters[1];

            return (System.Boolean)___result;
        }


        public static void Unscale(ref System.UInt32 @low, ref System.UInt64 @high64, ref System.Int32 @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@low, @high64, @scale};
            var ___result = RMUnscale_Ref_UInt32_Ref_UInt64_Ref_Int32.Invoke(___genericsType, ___parameters);
			@low = (System.UInt32)___parameters[0];
			@high64 = (System.UInt64)___parameters[1];
			@scale = (System.Int32)___parameters[2];

            
        }


        public static System.UInt32 Div96By64(ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc.RBuf12 @bufNum, System.UInt64 @den)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bufNum.Value, @den};
            var ___result = RMDiv96By64_Ref_Buf12_UInt64.Invoke(___genericsType, ___parameters);
			@bufNum = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc.RBuf12(___parameters[0]);

            return (System.UInt32)___result;
        }


        public static System.UInt32 Div128By96(ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc.RBuf16 @bufNum, ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc.RBuf12 @bufDen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bufNum.Value, @bufDen.Value};
            var ___result = RMDiv128By96_Ref_Buf16_Ref_Buf12.Invoke(___genericsType, ___parameters);
			@bufNum = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc.RBuf16(___parameters[0]);
			@bufDen = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc.RBuf12(___parameters[1]);

            return (System.UInt32)___result;
        }


        public static System.UInt32 IncreaseScale(ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc.RBuf12 @bufNum, System.UInt32 @power)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bufNum.Value, @power};
            var ___result = RMIncreaseScale_Ref_Buf12_UInt32.Invoke(___genericsType, ___parameters);
			@bufNum = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc.RBuf12(___parameters[0]);

            return (System.UInt32)___result;
        }


        public static void IncreaseScale64(ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc.RBuf12 @bufNum, System.UInt32 @power)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bufNum.Value, @power};
            var ___result = RMIncreaseScale64_Ref_Buf12_UInt32.Invoke(___genericsType, ___parameters);
			@bufNum = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc.RBuf12(___parameters[0]);

            
        }


        public unsafe static System.Int32 ScaleResult(Hvak.Editor.Refleaction.RTypePointer<Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc.RBuf24> @bufRes, System.UInt32 @hiRes, System.Int32 @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bufRes.Value, @hiRes, @scale};
            var ___result = RMScaleResult_Buf24Pointer_UInt32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public unsafe static System.UInt32 DivByConst(System.UInt32* @result, System.UInt32 @hiRes, out System.UInt32 @quotient, out System.UInt32 @remainder, System.UInt32 @power)
        {
			@quotient = default;
			@remainder = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@result, typeof(System.UInt32)), @hiRes, @quotient, @remainder, @power};
            var ___result = RMDivByConst_UInt32Pointer_UInt32_Out_UInt32_Out_UInt32_UInt32.Invoke(___genericsType, ___parameters);
			@quotient = (System.UInt32)___parameters[2];
			@remainder = (System.UInt32)___parameters[3];

            return (System.UInt32)___result;
        }


        public static System.Int32 LeadingZeroCount(System.UInt32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMLeadingZeroCount_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 OverflowUnscale(ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc.RBuf12 @bufQuo, System.Int32 @scale, System.Boolean @sticky)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bufQuo.Value, @scale, @sticky};
            var ___result = RMOverflowUnscale_Ref_Buf12_Int32_Boolean.Invoke(___genericsType, ___parameters);
			@bufQuo = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc.RBuf12(___parameters[0]);

            return (System.Int32)___result;
        }


        public static System.Int32 SearchScale(ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc.RBuf12 @bufQuo, System.Int32 @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bufQuo.Value, @scale};
            var ___result = RMSearchScale_Ref_Buf12_Int32.Invoke(___genericsType, ___parameters);
			@bufQuo = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc.RBuf12(___parameters[0]);

            return (System.Int32)___result;
        }


        public static System.Boolean Add32To96(ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc.RBuf12 @bufNum, System.UInt32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bufNum.Value, @value};
            var ___result = RMAdd32To96_Ref_Buf12_UInt32.Invoke(___genericsType, ___parameters);
			@bufNum = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc.RBuf12(___parameters[0]);

            return (System.Boolean)___result;
        }


        public static void DecAddSub(ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc @d1, ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc @d2, System.Boolean @sign)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1.Value, @d2.Value, @sign};
            var ___result = RMDecAddSub_Ref_DecCalc_Ref_DecCalc_Boolean.Invoke(___genericsType, ___parameters);
			@d1 = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc(___parameters[0]);
			@d2 = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc(___parameters[1]);

            
        }


        public static System.Int64 VarCyFromDec(ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc @pdecIn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pdecIn.Value};
            var ___result = RMVarCyFromDec_Ref_DecCalc.Invoke(___genericsType, ___parameters);
			@pdecIn = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc(___parameters[0]);

            return (System.Int64)___result;
        }


        public static System.Int32 VarDecCmp(in System.Decimal @d1, in System.Decimal @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMVarDecCmp_In_Decimal_In_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 VarDecCmpSub(in System.Decimal @d1, in System.Decimal @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMVarDecCmpSub_In_Decimal_In_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void VarDecMul(ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc @d1, ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1.Value, @d2.Value};
            var ___result = RMVarDecMul_Ref_DecCalc_Ref_DecCalc.Invoke(___genericsType, ___parameters);
			@d1 = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc(___parameters[0]);
			@d2 = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc(___parameters[1]);

            
        }


        public static void VarDecFromR4(System.Single @input, out Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @result.Value};
            var ___result = RMVarDecFromR4_Single_Out_DecCalc.Invoke(___genericsType, ___parameters);
			@result = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc(___parameters[1]);

            
        }


        public static void VarDecFromR8(System.Double @input, out Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @result.Value};
            var ___result = RMVarDecFromR8_Double_Out_DecCalc.Invoke(___genericsType, ___parameters);
			@result = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc(___parameters[1]);

            
        }


        public static System.Single VarR4FromDec(in System.Decimal @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMVarR4FromDec_In_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Double VarR8FromDec(in System.Decimal @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMVarR8FromDec_In_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public static System.Int32 GetHashCode(in System.Decimal @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMGetHashCode_In_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void VarDecDiv(ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc @d1, ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1.Value, @d2.Value};
            var ___result = RMVarDecDiv_Ref_DecCalc_Ref_DecCalc.Invoke(___genericsType, ___parameters);
			@d1 = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc(___parameters[0]);
			@d2 = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc(___parameters[1]);

            
        }


        public static void VarDecMod(ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc @d1, ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1.Value, @d2.Value};
            var ___result = RMVarDecMod_Ref_DecCalc_Ref_DecCalc.Invoke(___genericsType, ___parameters);
			@d1 = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc(___parameters[0]);
			@d2 = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc(___parameters[1]);

            
        }


        public static void VarDecModFull(ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc @d1, ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc @d2, System.Int32 @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1.Value, @d2.Value, @scale};
            var ___result = RMVarDecModFull_Ref_DecCalc_Ref_DecCalc_Int32.Invoke(___genericsType, ___parameters);
			@d1 = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc(___parameters[0]);
			@d2 = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc(___parameters[1]);

            
        }


        public static void InternalRound(ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc @d, System.UInt32 @scale, Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc.RRoundingMode @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d.Value, @scale, @mode.Value};
            var ___result = RMInternalRound_Ref_DecCalc_UInt32_RoundingMode.Invoke(___genericsType, ___parameters);
			@d = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc(___parameters[0]);

            
        }


        public static System.UInt32 DecDivMod1E9(ref Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RMDecDivMod1E9_Ref_DecCalc.Invoke(___genericsType, ___parameters);
			@value = new Hvak.Editor.Refleaction.RSystem.RDecimal.RDecCalc(___parameters[0]);

            return (System.UInt32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

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
}