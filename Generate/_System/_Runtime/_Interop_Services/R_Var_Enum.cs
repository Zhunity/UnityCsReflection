
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Runtime.InteropServices.VarEnum
	/// </summary>
    public partial class RVarEnum : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Runtime.InteropServices.VarEnum);
            }
        }

        public RVarEnum() : base("System.Runtime.InteropServices.VarEnum")
        {
        }

        public RVarEnum(System.Object instance) : base("System.Runtime.InteropServices.VarEnum")
		{
            SetInstance(instance);
		}

        public RVarEnum(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVarEnum(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// System.Runtime.InteropServices.VarEnum VT_EMPTY
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_EMPTY;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_EMPTY
		{
			get
			{
				if(r_FVT_EMPTY == null)
				{
					r_FVT_EMPTY = new(Type, "VT_EMPTY");
				}
				return r_FVT_EMPTY;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_NULL
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_NULL;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_NULL
		{
			get
			{
				if(r_FVT_NULL == null)
				{
					r_FVT_NULL = new(Type, "VT_NULL");
				}
				return r_FVT_NULL;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_I2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_I2;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_I2
		{
			get
			{
				if(r_FVT_I2 == null)
				{
					r_FVT_I2 = new(Type, "VT_I2");
				}
				return r_FVT_I2;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_I4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_I4;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_I4
		{
			get
			{
				if(r_FVT_I4 == null)
				{
					r_FVT_I4 = new(Type, "VT_I4");
				}
				return r_FVT_I4;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_R4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_R4;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_R4
		{
			get
			{
				if(r_FVT_R4 == null)
				{
					r_FVT_R4 = new(Type, "VT_R4");
				}
				return r_FVT_R4;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_R8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_R8;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_R8
		{
			get
			{
				if(r_FVT_R8 == null)
				{
					r_FVT_R8 = new(Type, "VT_R8");
				}
				return r_FVT_R8;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_CY
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_CY;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_CY
		{
			get
			{
				if(r_FVT_CY == null)
				{
					r_FVT_CY = new(Type, "VT_CY");
				}
				return r_FVT_CY;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_DATE
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_DATE;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_DATE
		{
			get
			{
				if(r_FVT_DATE == null)
				{
					r_FVT_DATE = new(Type, "VT_DATE");
				}
				return r_FVT_DATE;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_BSTR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_BSTR;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_BSTR
		{
			get
			{
				if(r_FVT_BSTR == null)
				{
					r_FVT_BSTR = new(Type, "VT_BSTR");
				}
				return r_FVT_BSTR;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_DISPATCH
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_DISPATCH;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_DISPATCH
		{
			get
			{
				if(r_FVT_DISPATCH == null)
				{
					r_FVT_DISPATCH = new(Type, "VT_DISPATCH");
				}
				return r_FVT_DISPATCH;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_ERROR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_ERROR;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_ERROR
		{
			get
			{
				if(r_FVT_ERROR == null)
				{
					r_FVT_ERROR = new(Type, "VT_ERROR");
				}
				return r_FVT_ERROR;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_BOOL
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_BOOL;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_BOOL
		{
			get
			{
				if(r_FVT_BOOL == null)
				{
					r_FVT_BOOL = new(Type, "VT_BOOL");
				}
				return r_FVT_BOOL;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_VARIANT
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_VARIANT;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_VARIANT
		{
			get
			{
				if(r_FVT_VARIANT == null)
				{
					r_FVT_VARIANT = new(Type, "VT_VARIANT");
				}
				return r_FVT_VARIANT;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_UNKNOWN
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_UNKNOWN;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_UNKNOWN
		{
			get
			{
				if(r_FVT_UNKNOWN == null)
				{
					r_FVT_UNKNOWN = new(Type, "VT_UNKNOWN");
				}
				return r_FVT_UNKNOWN;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_DECIMAL
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_DECIMAL;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_DECIMAL
		{
			get
			{
				if(r_FVT_DECIMAL == null)
				{
					r_FVT_DECIMAL = new(Type, "VT_DECIMAL");
				}
				return r_FVT_DECIMAL;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_I1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_I1;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_I1
		{
			get
			{
				if(r_FVT_I1 == null)
				{
					r_FVT_I1 = new(Type, "VT_I1");
				}
				return r_FVT_I1;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_UI1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_UI1;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_UI1
		{
			get
			{
				if(r_FVT_UI1 == null)
				{
					r_FVT_UI1 = new(Type, "VT_UI1");
				}
				return r_FVT_UI1;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_UI2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_UI2;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_UI2
		{
			get
			{
				if(r_FVT_UI2 == null)
				{
					r_FVT_UI2 = new(Type, "VT_UI2");
				}
				return r_FVT_UI2;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_UI4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_UI4;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_UI4
		{
			get
			{
				if(r_FVT_UI4 == null)
				{
					r_FVT_UI4 = new(Type, "VT_UI4");
				}
				return r_FVT_UI4;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_I8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_I8;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_I8
		{
			get
			{
				if(r_FVT_I8 == null)
				{
					r_FVT_I8 = new(Type, "VT_I8");
				}
				return r_FVT_I8;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_UI8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_UI8;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_UI8
		{
			get
			{
				if(r_FVT_UI8 == null)
				{
					r_FVT_UI8 = new(Type, "VT_UI8");
				}
				return r_FVT_UI8;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_INT
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_INT;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_INT
		{
			get
			{
				if(r_FVT_INT == null)
				{
					r_FVT_INT = new(Type, "VT_INT");
				}
				return r_FVT_INT;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_UINT
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_UINT;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_UINT
		{
			get
			{
				if(r_FVT_UINT == null)
				{
					r_FVT_UINT = new(Type, "VT_UINT");
				}
				return r_FVT_UINT;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_VOID
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_VOID;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_VOID
		{
			get
			{
				if(r_FVT_VOID == null)
				{
					r_FVT_VOID = new(Type, "VT_VOID");
				}
				return r_FVT_VOID;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_HRESULT
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_HRESULT;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_HRESULT
		{
			get
			{
				if(r_FVT_HRESULT == null)
				{
					r_FVT_HRESULT = new(Type, "VT_HRESULT");
				}
				return r_FVT_HRESULT;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_PTR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_PTR;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_PTR
		{
			get
			{
				if(r_FVT_PTR == null)
				{
					r_FVT_PTR = new(Type, "VT_PTR");
				}
				return r_FVT_PTR;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_SAFEARRAY
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_SAFEARRAY;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_SAFEARRAY
		{
			get
			{
				if(r_FVT_SAFEARRAY == null)
				{
					r_FVT_SAFEARRAY = new(Type, "VT_SAFEARRAY");
				}
				return r_FVT_SAFEARRAY;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_CARRAY
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_CARRAY;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_CARRAY
		{
			get
			{
				if(r_FVT_CARRAY == null)
				{
					r_FVT_CARRAY = new(Type, "VT_CARRAY");
				}
				return r_FVT_CARRAY;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_USERDEFINED
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_USERDEFINED;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_USERDEFINED
		{
			get
			{
				if(r_FVT_USERDEFINED == null)
				{
					r_FVT_USERDEFINED = new(Type, "VT_USERDEFINED");
				}
				return r_FVT_USERDEFINED;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_LPSTR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_LPSTR;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_LPSTR
		{
			get
			{
				if(r_FVT_LPSTR == null)
				{
					r_FVT_LPSTR = new(Type, "VT_LPSTR");
				}
				return r_FVT_LPSTR;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_LPWSTR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_LPWSTR;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_LPWSTR
		{
			get
			{
				if(r_FVT_LPWSTR == null)
				{
					r_FVT_LPWSTR = new(Type, "VT_LPWSTR");
				}
				return r_FVT_LPWSTR;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_RECORD
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_RECORD;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_RECORD
		{
			get
			{
				if(r_FVT_RECORD == null)
				{
					r_FVT_RECORD = new(Type, "VT_RECORD");
				}
				return r_FVT_RECORD;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_FILETIME
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_FILETIME;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_FILETIME
		{
			get
			{
				if(r_FVT_FILETIME == null)
				{
					r_FVT_FILETIME = new(Type, "VT_FILETIME");
				}
				return r_FVT_FILETIME;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_BLOB
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_BLOB;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_BLOB
		{
			get
			{
				if(r_FVT_BLOB == null)
				{
					r_FVT_BLOB = new(Type, "VT_BLOB");
				}
				return r_FVT_BLOB;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_STREAM
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_STREAM;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_STREAM
		{
			get
			{
				if(r_FVT_STREAM == null)
				{
					r_FVT_STREAM = new(Type, "VT_STREAM");
				}
				return r_FVT_STREAM;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_STORAGE
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_STORAGE;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_STORAGE
		{
			get
			{
				if(r_FVT_STORAGE == null)
				{
					r_FVT_STORAGE = new(Type, "VT_STORAGE");
				}
				return r_FVT_STORAGE;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_STREAMED_OBJECT
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_STREAMED_OBJECT;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_STREAMED_OBJECT
		{
			get
			{
				if(r_FVT_STREAMED_OBJECT == null)
				{
					r_FVT_STREAMED_OBJECT = new(Type, "VT_STREAMED_OBJECT");
				}
				return r_FVT_STREAMED_OBJECT;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_STORED_OBJECT
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_STORED_OBJECT;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_STORED_OBJECT
		{
			get
			{
				if(r_FVT_STORED_OBJECT == null)
				{
					r_FVT_STORED_OBJECT = new(Type, "VT_STORED_OBJECT");
				}
				return r_FVT_STORED_OBJECT;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_BLOB_OBJECT
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_BLOB_OBJECT;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_BLOB_OBJECT
		{
			get
			{
				if(r_FVT_BLOB_OBJECT == null)
				{
					r_FVT_BLOB_OBJECT = new(Type, "VT_BLOB_OBJECT");
				}
				return r_FVT_BLOB_OBJECT;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_CF
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_CF;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_CF
		{
			get
			{
				if(r_FVT_CF == null)
				{
					r_FVT_CF = new(Type, "VT_CF");
				}
				return r_FVT_CF;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_CLSID
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_CLSID;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_CLSID
		{
			get
			{
				if(r_FVT_CLSID == null)
				{
					r_FVT_CLSID = new(Type, "VT_CLSID");
				}
				return r_FVT_CLSID;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_VECTOR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_VECTOR;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_VECTOR
		{
			get
			{
				if(r_FVT_VECTOR == null)
				{
					r_FVT_VECTOR = new(Type, "VT_VECTOR");
				}
				return r_FVT_VECTOR;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_ARRAY
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_ARRAY;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_ARRAY
		{
			get
			{
				if(r_FVT_ARRAY == null)
				{
					r_FVT_ARRAY = new(Type, "VT_ARRAY");
				}
				return r_FVT_ARRAY;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.VarEnum VT_BYREF
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum r_FVT_BYREF;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RVarEnum RFVT_BYREF
		{
			get
			{
				if(r_FVT_BYREF == null)
				{
					r_FVT_BYREF = new(Type, "VT_BYREF");
				}
				return r_FVT_BYREF;
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
