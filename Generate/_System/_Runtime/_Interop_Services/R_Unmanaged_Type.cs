
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices
{
	/// <summary>
	/// System.Runtime.InteropServices.UnmanagedType
	/// </summary>
    public partial class RUnmanagedType : RMember //
    {

		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
					r_Fvalue__.SetBelong(this.instance);
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType Bool
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FBool;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFBool
		{
			get
			{
				if(r_FBool == null)
				{
					r_FBool = new(typeof(System.Runtime.InteropServices.UnmanagedType), "Bool");
					r_FBool.SetBelong(null);
				}
				return r_FBool;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType I1
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FI1;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFI1
		{
			get
			{
				if(r_FI1 == null)
				{
					r_FI1 = new(typeof(System.Runtime.InteropServices.UnmanagedType), "I1");
					r_FI1.SetBelong(null);
				}
				return r_FI1;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType U1
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FU1;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFU1
		{
			get
			{
				if(r_FU1 == null)
				{
					r_FU1 = new(typeof(System.Runtime.InteropServices.UnmanagedType), "U1");
					r_FU1.SetBelong(null);
				}
				return r_FU1;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType I2
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FI2;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFI2
		{
			get
			{
				if(r_FI2 == null)
				{
					r_FI2 = new(typeof(System.Runtime.InteropServices.UnmanagedType), "I2");
					r_FI2.SetBelong(null);
				}
				return r_FI2;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType U2
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FU2;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFU2
		{
			get
			{
				if(r_FU2 == null)
				{
					r_FU2 = new(typeof(System.Runtime.InteropServices.UnmanagedType), "U2");
					r_FU2.SetBelong(null);
				}
				return r_FU2;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType I4
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FI4;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFI4
		{
			get
			{
				if(r_FI4 == null)
				{
					r_FI4 = new(typeof(System.Runtime.InteropServices.UnmanagedType), "I4");
					r_FI4.SetBelong(null);
				}
				return r_FI4;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType U4
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FU4;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFU4
		{
			get
			{
				if(r_FU4 == null)
				{
					r_FU4 = new(typeof(System.Runtime.InteropServices.UnmanagedType), "U4");
					r_FU4.SetBelong(null);
				}
				return r_FU4;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType I8
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FI8;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFI8
		{
			get
			{
				if(r_FI8 == null)
				{
					r_FI8 = new(typeof(System.Runtime.InteropServices.UnmanagedType), "I8");
					r_FI8.SetBelong(null);
				}
				return r_FI8;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType U8
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FU8;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFU8
		{
			get
			{
				if(r_FU8 == null)
				{
					r_FU8 = new(typeof(System.Runtime.InteropServices.UnmanagedType), "U8");
					r_FU8.SetBelong(null);
				}
				return r_FU8;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType R4
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FR4;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFR4
		{
			get
			{
				if(r_FR4 == null)
				{
					r_FR4 = new(typeof(System.Runtime.InteropServices.UnmanagedType), "R4");
					r_FR4.SetBelong(null);
				}
				return r_FR4;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType R8
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FR8;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFR8
		{
			get
			{
				if(r_FR8 == null)
				{
					r_FR8 = new(typeof(System.Runtime.InteropServices.UnmanagedType), "R8");
					r_FR8.SetBelong(null);
				}
				return r_FR8;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType Currency
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FCurrency;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFCurrency
		{
			get
			{
				if(r_FCurrency == null)
				{
					r_FCurrency = new(typeof(System.Runtime.InteropServices.UnmanagedType), "Currency");
					r_FCurrency.SetBelong(null);
				}
				return r_FCurrency;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType BStr
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FBStr;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFBStr
		{
			get
			{
				if(r_FBStr == null)
				{
					r_FBStr = new(typeof(System.Runtime.InteropServices.UnmanagedType), "BStr");
					r_FBStr.SetBelong(null);
				}
				return r_FBStr;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType LPStr
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FLPStr;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFLPStr
		{
			get
			{
				if(r_FLPStr == null)
				{
					r_FLPStr = new(typeof(System.Runtime.InteropServices.UnmanagedType), "LPStr");
					r_FLPStr.SetBelong(null);
				}
				return r_FLPStr;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType LPWStr
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FLPWStr;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFLPWStr
		{
			get
			{
				if(r_FLPWStr == null)
				{
					r_FLPWStr = new(typeof(System.Runtime.InteropServices.UnmanagedType), "LPWStr");
					r_FLPWStr.SetBelong(null);
				}
				return r_FLPWStr;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType LPTStr
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FLPTStr;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFLPTStr
		{
			get
			{
				if(r_FLPTStr == null)
				{
					r_FLPTStr = new(typeof(System.Runtime.InteropServices.UnmanagedType), "LPTStr");
					r_FLPTStr.SetBelong(null);
				}
				return r_FLPTStr;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType ByValTStr
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FByValTStr;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFByValTStr
		{
			get
			{
				if(r_FByValTStr == null)
				{
					r_FByValTStr = new(typeof(System.Runtime.InteropServices.UnmanagedType), "ByValTStr");
					r_FByValTStr.SetBelong(null);
				}
				return r_FByValTStr;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType IUnknown
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FIUnknown;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFIUnknown
		{
			get
			{
				if(r_FIUnknown == null)
				{
					r_FIUnknown = new(typeof(System.Runtime.InteropServices.UnmanagedType), "IUnknown");
					r_FIUnknown.SetBelong(null);
				}
				return r_FIUnknown;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType IDispatch
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FIDispatch;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFIDispatch
		{
			get
			{
				if(r_FIDispatch == null)
				{
					r_FIDispatch = new(typeof(System.Runtime.InteropServices.UnmanagedType), "IDispatch");
					r_FIDispatch.SetBelong(null);
				}
				return r_FIDispatch;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType Struct
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FStruct;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFStruct
		{
			get
			{
				if(r_FStruct == null)
				{
					r_FStruct = new(typeof(System.Runtime.InteropServices.UnmanagedType), "Struct");
					r_FStruct.SetBelong(null);
				}
				return r_FStruct;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType Interface
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FInterface;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFInterface
		{
			get
			{
				if(r_FInterface == null)
				{
					r_FInterface = new(typeof(System.Runtime.InteropServices.UnmanagedType), "Interface");
					r_FInterface.SetBelong(null);
				}
				return r_FInterface;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType SafeArray
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FSafeArray;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFSafeArray
		{
			get
			{
				if(r_FSafeArray == null)
				{
					r_FSafeArray = new(typeof(System.Runtime.InteropServices.UnmanagedType), "SafeArray");
					r_FSafeArray.SetBelong(null);
				}
				return r_FSafeArray;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType ByValArray
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FByValArray;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFByValArray
		{
			get
			{
				if(r_FByValArray == null)
				{
					r_FByValArray = new(typeof(System.Runtime.InteropServices.UnmanagedType), "ByValArray");
					r_FByValArray.SetBelong(null);
				}
				return r_FByValArray;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType SysInt
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FSysInt;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFSysInt
		{
			get
			{
				if(r_FSysInt == null)
				{
					r_FSysInt = new(typeof(System.Runtime.InteropServices.UnmanagedType), "SysInt");
					r_FSysInt.SetBelong(null);
				}
				return r_FSysInt;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType SysUInt
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FSysUInt;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFSysUInt
		{
			get
			{
				if(r_FSysUInt == null)
				{
					r_FSysUInt = new(typeof(System.Runtime.InteropServices.UnmanagedType), "SysUInt");
					r_FSysUInt.SetBelong(null);
				}
				return r_FSysUInt;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType VBByRefStr
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FVBByRefStr;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFVBByRefStr
		{
			get
			{
				if(r_FVBByRefStr == null)
				{
					r_FVBByRefStr = new(typeof(System.Runtime.InteropServices.UnmanagedType), "VBByRefStr");
					r_FVBByRefStr.SetBelong(null);
				}
				return r_FVBByRefStr;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType AnsiBStr
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FAnsiBStr;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFAnsiBStr
		{
			get
			{
				if(r_FAnsiBStr == null)
				{
					r_FAnsiBStr = new(typeof(System.Runtime.InteropServices.UnmanagedType), "AnsiBStr");
					r_FAnsiBStr.SetBelong(null);
				}
				return r_FAnsiBStr;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType TBStr
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FTBStr;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFTBStr
		{
			get
			{
				if(r_FTBStr == null)
				{
					r_FTBStr = new(typeof(System.Runtime.InteropServices.UnmanagedType), "TBStr");
					r_FTBStr.SetBelong(null);
				}
				return r_FTBStr;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType VariantBool
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FVariantBool;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFVariantBool
		{
			get
			{
				if(r_FVariantBool == null)
				{
					r_FVariantBool = new(typeof(System.Runtime.InteropServices.UnmanagedType), "VariantBool");
					r_FVariantBool.SetBelong(null);
				}
				return r_FVariantBool;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType FunctionPtr
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FFunctionPtr;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFFunctionPtr
		{
			get
			{
				if(r_FFunctionPtr == null)
				{
					r_FFunctionPtr = new(typeof(System.Runtime.InteropServices.UnmanagedType), "FunctionPtr");
					r_FFunctionPtr.SetBelong(null);
				}
				return r_FFunctionPtr;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType AsAny
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FAsAny;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFAsAny
		{
			get
			{
				if(r_FAsAny == null)
				{
					r_FAsAny = new(typeof(System.Runtime.InteropServices.UnmanagedType), "AsAny");
					r_FAsAny.SetBelong(null);
				}
				return r_FAsAny;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType LPArray
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FLPArray;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFLPArray
		{
			get
			{
				if(r_FLPArray == null)
				{
					r_FLPArray = new(typeof(System.Runtime.InteropServices.UnmanagedType), "LPArray");
					r_FLPArray.SetBelong(null);
				}
				return r_FLPArray;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType LPStruct
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FLPStruct;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFLPStruct
		{
			get
			{
				if(r_FLPStruct == null)
				{
					r_FLPStruct = new(typeof(System.Runtime.InteropServices.UnmanagedType), "LPStruct");
					r_FLPStruct.SetBelong(null);
				}
				return r_FLPStruct;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType CustomMarshaler
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FCustomMarshaler;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFCustomMarshaler
		{
			get
			{
				if(r_FCustomMarshaler == null)
				{
					r_FCustomMarshaler = new(typeof(System.Runtime.InteropServices.UnmanagedType), "CustomMarshaler");
					r_FCustomMarshaler.SetBelong(null);
				}
				return r_FCustomMarshaler;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType Error
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FError;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFError
		{
			get
			{
				if(r_FError == null)
				{
					r_FError = new(typeof(System.Runtime.InteropServices.UnmanagedType), "Error");
					r_FError.SetBelong(null);
				}
				return r_FError;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType IInspectable
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FIInspectable;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFIInspectable
		{
			get
			{
				if(r_FIInspectable == null)
				{
					r_FIInspectable = new(typeof(System.Runtime.InteropServices.UnmanagedType), "IInspectable");
					r_FIInspectable.SetBelong(null);
				}
				return r_FIInspectable;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType HString
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FHString;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFHString
		{
			get
			{
				if(r_FHString == null)
				{
					r_FHString = new(typeof(System.Runtime.InteropServices.UnmanagedType), "HString");
					r_FHString.SetBelong(null);
				}
				return r_FHString;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType LPUTF8Str
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FLPUTF8Str;
		public static SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFLPUTF8Str
		{
			get
			{
				if(r_FLPUTF8Str == null)
				{
					r_FLPUTF8Str = new(typeof(System.Runtime.InteropServices.UnmanagedType), "LPUTF8Str");
					r_FLPUTF8Str.SetBelong(null);
				}
				return r_FLPUTF8Str;
			}
		}

		/// <summary>
		/// System.Object GetValue()
		/// </summary>
		protected RMethod r_MGetValue;
		public virtual RMethod RMGetValue
		{
			get
			{
				if(r_MGetValue == null)
				{
					r_MGetValue = new(this, "GetValue", 0);
					r_MGetValue.SetBelong(this.instance);
				}
				return r_MGetValue;
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
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
					r_MCompareTo_Object.SetBelong(this.instance);
				}
				return r_MCompareTo_Object;
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
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_IFormatProvider;
		public virtual RMethod RMToString_IFormatProvider
		{
			get
			{
				if(r_MToString_IFormatProvider == null)
				{
					r_MToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
					r_MToString_IFormatProvider.SetBelong(this.instance);
				}
				return r_MToString_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean HasFlag(System.Enum)
		/// </summary>
		protected RMethod r_MHasFlag_Enum;
		public virtual RMethod RMHasFlag_Enum
		{
			get
			{
				if(r_MHasFlag_Enum == null)
				{
					r_MHasFlag_Enum = new(this, "HasFlag", 0, typeof(System.Enum));
					r_MHasFlag_Enum.SetBelong(this.instance);
				}
				return r_MHasFlag_Enum;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_MGetTypeCode;
		public virtual RMethod RMGetTypeCode
		{
			get
			{
				if(r_MGetTypeCode == null)
				{
					r_MGetTypeCode = new(this, "GetTypeCode", 0);
					r_MGetTypeCode.SetBelong(this.instance);
				}
				return r_MGetTypeCode;
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


        public RUnmanagedType() : base("System.Runtime.InteropServices.UnmanagedType")
        {
        }

        public RUnmanagedType(System.Object instance) : base("System.Runtime.InteropServices.UnmanagedType")
		{
            SetInstance(instance);
		}

        public RUnmanagedType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUnmanagedType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
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
