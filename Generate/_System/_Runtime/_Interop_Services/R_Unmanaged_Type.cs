
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Runtime.InteropServices.UnmanagedType
	/// </summary>
    public partial class RUnmanagedType : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Runtime.InteropServices.UnmanagedType);
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


		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType Bool
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FBool;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFBool
		{
			get
			{
				if(r_FBool == null)
				{
					r_FBool = new(Type, "Bool");
				}
				return r_FBool;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType I1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FI1;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFI1
		{
			get
			{
				if(r_FI1 == null)
				{
					r_FI1 = new(Type, "I1");
				}
				return r_FI1;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType U1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FU1;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFU1
		{
			get
			{
				if(r_FU1 == null)
				{
					r_FU1 = new(Type, "U1");
				}
				return r_FU1;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType I2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FI2;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFI2
		{
			get
			{
				if(r_FI2 == null)
				{
					r_FI2 = new(Type, "I2");
				}
				return r_FI2;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType U2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FU2;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFU2
		{
			get
			{
				if(r_FU2 == null)
				{
					r_FU2 = new(Type, "U2");
				}
				return r_FU2;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType I4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FI4;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFI4
		{
			get
			{
				if(r_FI4 == null)
				{
					r_FI4 = new(Type, "I4");
				}
				return r_FI4;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType U4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FU4;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFU4
		{
			get
			{
				if(r_FU4 == null)
				{
					r_FU4 = new(Type, "U4");
				}
				return r_FU4;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType I8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FI8;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFI8
		{
			get
			{
				if(r_FI8 == null)
				{
					r_FI8 = new(Type, "I8");
				}
				return r_FI8;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType U8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FU8;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFU8
		{
			get
			{
				if(r_FU8 == null)
				{
					r_FU8 = new(Type, "U8");
				}
				return r_FU8;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType R4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FR4;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFR4
		{
			get
			{
				if(r_FR4 == null)
				{
					r_FR4 = new(Type, "R4");
				}
				return r_FR4;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType R8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FR8;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFR8
		{
			get
			{
				if(r_FR8 == null)
				{
					r_FR8 = new(Type, "R8");
				}
				return r_FR8;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType Currency
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FCurrency;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFCurrency
		{
			get
			{
				if(r_FCurrency == null)
				{
					r_FCurrency = new(Type, "Currency");
				}
				return r_FCurrency;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType BStr
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FBStr;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFBStr
		{
			get
			{
				if(r_FBStr == null)
				{
					r_FBStr = new(Type, "BStr");
				}
				return r_FBStr;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType LPStr
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FLPStr;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFLPStr
		{
			get
			{
				if(r_FLPStr == null)
				{
					r_FLPStr = new(Type, "LPStr");
				}
				return r_FLPStr;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType LPWStr
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FLPWStr;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFLPWStr
		{
			get
			{
				if(r_FLPWStr == null)
				{
					r_FLPWStr = new(Type, "LPWStr");
				}
				return r_FLPWStr;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType LPTStr
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FLPTStr;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFLPTStr
		{
			get
			{
				if(r_FLPTStr == null)
				{
					r_FLPTStr = new(Type, "LPTStr");
				}
				return r_FLPTStr;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType ByValTStr
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FByValTStr;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFByValTStr
		{
			get
			{
				if(r_FByValTStr == null)
				{
					r_FByValTStr = new(Type, "ByValTStr");
				}
				return r_FByValTStr;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType IUnknown
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FIUnknown;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFIUnknown
		{
			get
			{
				if(r_FIUnknown == null)
				{
					r_FIUnknown = new(Type, "IUnknown");
				}
				return r_FIUnknown;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType IDispatch
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FIDispatch;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFIDispatch
		{
			get
			{
				if(r_FIDispatch == null)
				{
					r_FIDispatch = new(Type, "IDispatch");
				}
				return r_FIDispatch;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType Struct
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FStruct;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFStruct
		{
			get
			{
				if(r_FStruct == null)
				{
					r_FStruct = new(Type, "Struct");
				}
				return r_FStruct;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType Interface
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FInterface;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFInterface
		{
			get
			{
				if(r_FInterface == null)
				{
					r_FInterface = new(Type, "Interface");
				}
				return r_FInterface;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType SafeArray
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FSafeArray;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFSafeArray
		{
			get
			{
				if(r_FSafeArray == null)
				{
					r_FSafeArray = new(Type, "SafeArray");
				}
				return r_FSafeArray;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType ByValArray
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FByValArray;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFByValArray
		{
			get
			{
				if(r_FByValArray == null)
				{
					r_FByValArray = new(Type, "ByValArray");
				}
				return r_FByValArray;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType SysInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FSysInt;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFSysInt
		{
			get
			{
				if(r_FSysInt == null)
				{
					r_FSysInt = new(Type, "SysInt");
				}
				return r_FSysInt;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType SysUInt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FSysUInt;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFSysUInt
		{
			get
			{
				if(r_FSysUInt == null)
				{
					r_FSysUInt = new(Type, "SysUInt");
				}
				return r_FSysUInt;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType VBByRefStr
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FVBByRefStr;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFVBByRefStr
		{
			get
			{
				if(r_FVBByRefStr == null)
				{
					r_FVBByRefStr = new(Type, "VBByRefStr");
				}
				return r_FVBByRefStr;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType AnsiBStr
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FAnsiBStr;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFAnsiBStr
		{
			get
			{
				if(r_FAnsiBStr == null)
				{
					r_FAnsiBStr = new(Type, "AnsiBStr");
				}
				return r_FAnsiBStr;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType TBStr
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FTBStr;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFTBStr
		{
			get
			{
				if(r_FTBStr == null)
				{
					r_FTBStr = new(Type, "TBStr");
				}
				return r_FTBStr;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType VariantBool
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FVariantBool;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFVariantBool
		{
			get
			{
				if(r_FVariantBool == null)
				{
					r_FVariantBool = new(Type, "VariantBool");
				}
				return r_FVariantBool;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType FunctionPtr
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FFunctionPtr;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFFunctionPtr
		{
			get
			{
				if(r_FFunctionPtr == null)
				{
					r_FFunctionPtr = new(Type, "FunctionPtr");
				}
				return r_FFunctionPtr;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType AsAny
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FAsAny;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFAsAny
		{
			get
			{
				if(r_FAsAny == null)
				{
					r_FAsAny = new(Type, "AsAny");
				}
				return r_FAsAny;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType LPArray
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FLPArray;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFLPArray
		{
			get
			{
				if(r_FLPArray == null)
				{
					r_FLPArray = new(Type, "LPArray");
				}
				return r_FLPArray;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType LPStruct
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FLPStruct;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFLPStruct
		{
			get
			{
				if(r_FLPStruct == null)
				{
					r_FLPStruct = new(Type, "LPStruct");
				}
				return r_FLPStruct;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType CustomMarshaler
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FCustomMarshaler;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFCustomMarshaler
		{
			get
			{
				if(r_FCustomMarshaler == null)
				{
					r_FCustomMarshaler = new(Type, "CustomMarshaler");
				}
				return r_FCustomMarshaler;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType Error
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FError;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFError
		{
			get
			{
				if(r_FError == null)
				{
					r_FError = new(Type, "Error");
				}
				return r_FError;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType IInspectable
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FIInspectable;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFIInspectable
		{
			get
			{
				if(r_FIInspectable == null)
				{
					r_FIInspectable = new(Type, "IInspectable");
				}
				return r_FIInspectable;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType HString
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FHString;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFHString
		{
			get
			{
				if(r_FHString == null)
				{
					r_FHString = new(Type, "HString");
				}
				return r_FHString;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.UnmanagedType LPUTF8Str
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType r_FLPUTF8Str;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RUnmanagedType RFLPUTF8Str
		{
			get
			{
				if(r_FLPUTF8Str == null)
				{
					r_FLPUTF8Str = new(Type, "LPUTF8Str");
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


        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.TypeCode>(___result);
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
