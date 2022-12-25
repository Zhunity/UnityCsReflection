using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText
{
	/// <summary>
	/// System.Text.StringBuilder
	/// </summary>
    public partial class RStringBuilder : RMember //
    {

		/// <summary>
		/// System.Char[] m_ChunkChars
		/// </summary>
		protected RFieldArray<RField> r_m_ChunkChars;
		public virtual RFieldArray<RField> Rm_ChunkChars
		{
			get
			{
				if(r_m_ChunkChars == null)
				{
					r_m_ChunkChars = new(this, "m_ChunkChars");
					r_m_ChunkChars.SetBelong(this.instance);
				}
				return r_m_ChunkChars;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder m_ChunkPrevious
		/// </summary>
		protected RSystem.RText.RStringBuilder r_m_ChunkPrevious;
		public virtual RSystem.RText.RStringBuilder Rm_ChunkPrevious
		{
			get
			{
				if(r_m_ChunkPrevious == null)
				{
					r_m_ChunkPrevious = new(this, "m_ChunkPrevious");
					r_m_ChunkPrevious.SetBelong(this.instance);
				}
				return r_m_ChunkPrevious;
			}
		}

		/// <summary>
		/// System.Int32 m_ChunkLength
		/// </summary>
		protected RField r_m_ChunkLength;
		public virtual RField Rm_ChunkLength
		{
			get
			{
				if(r_m_ChunkLength == null)
				{
					r_m_ChunkLength = new(this, "m_ChunkLength");
					r_m_ChunkLength.SetBelong(this.instance);
				}
				return r_m_ChunkLength;
			}
		}

		/// <summary>
		/// System.Int32 m_ChunkOffset
		/// </summary>
		protected RField r_m_ChunkOffset;
		public virtual RField Rm_ChunkOffset
		{
			get
			{
				if(r_m_ChunkOffset == null)
				{
					r_m_ChunkOffset = new(this, "m_ChunkOffset");
					r_m_ChunkOffset.SetBelong(this.instance);
				}
				return r_m_ChunkOffset;
			}
		}

		/// <summary>
		/// System.Int32 m_MaxCapacity
		/// </summary>
		protected RField r_m_MaxCapacity;
		public virtual RField Rm_MaxCapacity
		{
			get
			{
				if(r_m_MaxCapacity == null)
				{
					r_m_MaxCapacity = new(this, "m_MaxCapacity");
					r_m_MaxCapacity.SetBelong(this.instance);
				}
				return r_m_MaxCapacity;
			}
		}

		/// <summary>
		/// System.Int32 DefaultCapacity
		/// </summary>
		protected static RField r_DefaultCapacity;
		public static RField RDefaultCapacity
		{
			get
			{
				if(r_DefaultCapacity == null)
				{
					r_DefaultCapacity = new(typeof(System.Text.StringBuilder), "DefaultCapacity");
					r_DefaultCapacity.SetBelong(null);
				}
				return r_DefaultCapacity;
			}
		}

		/// <summary>
		/// System.String CapacityField
		/// </summary>
		protected static RField r_CapacityField;
		public static RField RCapacityField
		{
			get
			{
				if(r_CapacityField == null)
				{
					r_CapacityField = new(typeof(System.Text.StringBuilder), "CapacityField");
					r_CapacityField.SetBelong(null);
				}
				return r_CapacityField;
			}
		}

		/// <summary>
		/// System.String MaxCapacityField
		/// </summary>
		protected static RField r_MaxCapacityField;
		public static RField RMaxCapacityField
		{
			get
			{
				if(r_MaxCapacityField == null)
				{
					r_MaxCapacityField = new(typeof(System.Text.StringBuilder), "MaxCapacityField");
					r_MaxCapacityField.SetBelong(null);
				}
				return r_MaxCapacityField;
			}
		}

		/// <summary>
		/// System.String StringValueField
		/// </summary>
		protected static RField r_StringValueField;
		public static RField RStringValueField
		{
			get
			{
				if(r_StringValueField == null)
				{
					r_StringValueField = new(typeof(System.Text.StringBuilder), "StringValueField");
					r_StringValueField.SetBelong(null);
				}
				return r_StringValueField;
			}
		}

		/// <summary>
		/// System.String ThreadIDField
		/// </summary>
		protected static RField r_ThreadIDField;
		public static RField RThreadIDField
		{
			get
			{
				if(r_ThreadIDField == null)
				{
					r_ThreadIDField = new(typeof(System.Text.StringBuilder), "ThreadIDField");
					r_ThreadIDField.SetBelong(null);
				}
				return r_ThreadIDField;
			}
		}

		/// <summary>
		/// System.Int32 MaxChunkSize
		/// </summary>
		protected static RField r_MaxChunkSize;
		public static RField RMaxChunkSize
		{
			get
			{
				if(r_MaxChunkSize == null)
				{
					r_MaxChunkSize = new(typeof(System.Text.StringBuilder), "MaxChunkSize");
					r_MaxChunkSize.SetBelong(null);
				}
				return r_MaxChunkSize;
			}
		}

		/// <summary>
		/// System.Int32 IndexLimit
		/// </summary>
		protected static RField r_IndexLimit;
		public static RField RIndexLimit
		{
			get
			{
				if(r_IndexLimit == null)
				{
					r_IndexLimit = new(typeof(System.Text.StringBuilder), "IndexLimit");
					r_IndexLimit.SetBelong(null);
				}
				return r_IndexLimit;
			}
		}

		/// <summary>
		/// System.Int32 WidthLimit
		/// </summary>
		protected static RField r_WidthLimit;
		public static RField RWidthLimit
		{
			get
			{
				if(r_WidthLimit == null)
				{
					r_WidthLimit = new(typeof(System.Text.StringBuilder), "WidthLimit");
					r_WidthLimit.SetBelong(null);
				}
				return r_WidthLimit;
			}
		}

		/// <summary>
		/// Int32 Capacity
		/// </summary>
		protected RProperty r_Capacity;
		public virtual RProperty RCapacity
		{
			get
			{
				if(r_Capacity == null)
				{
					r_Capacity = new(this, "Capacity", -1);
					r_Capacity.SetBelong(this.instance);
				}
				return r_Capacity;
			}
		}

		/// <summary>
		/// Int32 MaxCapacity
		/// </summary>
		protected RProperty r_MaxCapacity;
		public virtual RProperty RMaxCapacity
		{
			get
			{
				if(r_MaxCapacity == null)
				{
					r_MaxCapacity = new(this, "MaxCapacity", -1);
					r_MaxCapacity.SetBelong(this.instance);
				}
				return r_MaxCapacity;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected RProperty r_Length;
		public virtual RProperty RLength
		{
			get
			{
				if(r_Length == null)
				{
					r_Length = new(this, "Length", -1);
					r_Length.SetBelong(this.instance);
				}
				return r_Length;
			}
		}

		/// <summary>
		/// Char Chars [Int32]
		/// </summary>
		protected RProperty r_Chars_Int32;
		public virtual RProperty RChars_Int32
		{
			get
			{
				if(r_Chars_Int32 == null)
				{
					r_Chars_Int32 = new(this, "Chars", -1, typeof(System.Int32));
					r_Chars_Int32.SetBelong(this.instance);
				}
				return r_Chars_Int32;
			}
		}

		/// <summary>
		/// System.Span`1[System.Char] RemainingCurrentChunk
		/// </summary>
		protected RSystem.RSpan<RProperty> r_RemainingCurrentChunk;
		public virtual RSystem.RSpan<RProperty> RemainingCurrentChunk
		{
			get
			{
				if(r_RemainingCurrentChunk == null)
				{
					r_RemainingCurrentChunk = new(this, "RemainingCurrentChunk", -1);
					r_RemainingCurrentChunk.SetBelong(this.instance);
				}
				return r_RemainingCurrentChunk;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext = new(this, "System.Runtime.Serialization.ISerializable.GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Void AssertInvariants()
		/// </summary>
		protected RMethod r_RAssertInvariants;
		public virtual RMethod RAssertInvariants
		{
			get
			{
				if(r_RAssertInvariants == null)
				{
					r_RAssertInvariants = new(this, "AssertInvariants", 0);
					r_RAssertInvariants.SetBelong(this.instance);
				}
				return r_RAssertInvariants;
			}
		}

		/// <summary>
		/// Int32 EnsureCapacity(Int32)
		/// </summary>
		protected RMethod r_REnsureCapacity_Int32;
		public virtual RMethod REnsureCapacity_Int32
		{
			get
			{
				if(r_REnsureCapacity_Int32 == null)
				{
					r_REnsureCapacity_Int32 = new(this, "EnsureCapacity", 0, typeof(System.Int32));
					r_REnsureCapacity_Int32.SetBelong(this.instance);
				}
				return r_REnsureCapacity_Int32;
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
		/// System.String ToString(Int32, Int32)
		/// </summary>
		protected RMethod r_RToString_Int32_Int32;
		public virtual RMethod RToString_Int32_Int32
		{
			get
			{
				if(r_RToString_Int32_Int32 == null)
				{
					r_RToString_Int32_Int32 = new(this, "ToString", 0, typeof(System.Int32), typeof(System.Int32));
					r_RToString_Int32_Int32.SetBelong(this.instance);
				}
				return r_RToString_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Char, Int32)
		/// </summary>
		protected RMethod r_RAppend_Char_Int32;
		public virtual RMethod RAppend_Char_Int32
		{
			get
			{
				if(r_RAppend_Char_Int32 == null)
				{
					r_RAppend_Char_Int32 = new(this, "Append", 0, typeof(System.Char), typeof(System.Int32));
					r_RAppend_Char_Int32.SetBelong(this.instance);
				}
				return r_RAppend_Char_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RAppend_CharArray_Int32_Int32;
		public virtual RMethod RAppend_CharArray_Int32_Int32
		{
			get
			{
				if(r_RAppend_CharArray_Int32_Int32 == null)
				{
					r_RAppend_CharArray_Int32_Int32 = new(this, "Append", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RAppend_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RAppend_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(System.String)
		/// </summary>
		protected RMethod r_RAppend_String;
		public virtual RMethod RAppend_String
		{
			get
			{
				if(r_RAppend_String == null)
				{
					r_RAppend_String = new(this, "Append", 0, typeof(System.String));
					r_RAppend_String.SetBelong(this.instance);
				}
				return r_RAppend_String;
			}
		}

		/// <summary>
		/// Void AppendHelper(System.String)
		/// </summary>
		protected RMethod r_RAppendHelper_String;
		public virtual RMethod RAppendHelper_String
		{
			get
			{
				if(r_RAppendHelper_String == null)
				{
					r_RAppendHelper_String = new(this, "AppendHelper", 0, typeof(System.String));
					r_RAppendHelper_String.SetBelong(this.instance);
				}
				return r_RAppendHelper_String;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_RAppend_String_Int32_Int32;
		public virtual RMethod RAppend_String_Int32_Int32
		{
			get
			{
				if(r_RAppend_String_Int32_Int32 == null)
				{
					r_RAppend_String_Int32_Int32 = new(this, "Append", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RAppend_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_RAppend_String_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_RAppend_StringBuilder;
		public virtual RMethod RAppend_StringBuilder
		{
			get
			{
				if(r_RAppend_StringBuilder == null)
				{
					r_RAppend_StringBuilder = new(this, "Append", 0, typeof(System.Text.StringBuilder));
					r_RAppend_StringBuilder.SetBelong(this.instance);
				}
				return r_RAppend_StringBuilder;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(System.Text.StringBuilder, Int32, Int32)
		/// </summary>
		protected RMethod r_RAppend_StringBuilder_Int32_Int32;
		public virtual RMethod RAppend_StringBuilder_Int32_Int32
		{
			get
			{
				if(r_RAppend_StringBuilder_Int32_Int32 == null)
				{
					r_RAppend_StringBuilder_Int32_Int32 = new(this, "Append", 0, typeof(System.Text.StringBuilder), typeof(System.Int32), typeof(System.Int32));
					r_RAppend_StringBuilder_Int32_Int32.SetBelong(this.instance);
				}
				return r_RAppend_StringBuilder_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendCore(System.Text.StringBuilder, Int32, Int32)
		/// </summary>
		protected RMethod r_RAppendCore_StringBuilder_Int32_Int32;
		public virtual RMethod RAppendCore_StringBuilder_Int32_Int32
		{
			get
			{
				if(r_RAppendCore_StringBuilder_Int32_Int32 == null)
				{
					r_RAppendCore_StringBuilder_Int32_Int32 = new(this, "AppendCore", 0, typeof(System.Text.StringBuilder), typeof(System.Int32), typeof(System.Int32));
					r_RAppendCore_StringBuilder_Int32_Int32.SetBelong(this.instance);
				}
				return r_RAppendCore_StringBuilder_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendLine()
		/// </summary>
		protected RMethod r_RAppendLine;
		public virtual RMethod RAppendLine
		{
			get
			{
				if(r_RAppendLine == null)
				{
					r_RAppendLine = new(this, "AppendLine", 0);
					r_RAppendLine.SetBelong(this.instance);
				}
				return r_RAppendLine;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendLine(System.String)
		/// </summary>
		protected RMethod r_RAppendLine_String;
		public virtual RMethod RAppendLine_String
		{
			get
			{
				if(r_RAppendLine_String == null)
				{
					r_RAppendLine_String = new(this, "AppendLine", 0, typeof(System.String));
					r_RAppendLine_String.SetBelong(this.instance);
				}
				return r_RAppendLine_String;
			}
		}

		/// <summary>
		/// Void CopyTo(Int32, Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RCopyTo_Int32_CharArray_Int32_Int32;
		public virtual RMethod RCopyTo_Int32_CharArray_Int32_Int32
		{
			get
			{
				if(r_RCopyTo_Int32_CharArray_Int32_Int32 == null)
				{
					r_RCopyTo_Int32_CharArray_Int32_Int32 = new(this, "CopyTo", 0, typeof(System.Int32), typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RCopyTo_Int32_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RCopyTo_Int32_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopyTo(Int32, System.Span`1[System.Char], Int32)
		/// </summary>
		protected RMethod r_RCopyTo_Int32_Span_d_Char_p__Int32;
		public virtual RMethod RCopyTo_Int32_Span_d_Char_p__Int32
		{
			get
			{
				if(r_RCopyTo_Int32_Span_d_Char_p__Int32 == null)
				{
					r_RCopyTo_Int32_Span_d_Char_p__Int32 = new(this, "CopyTo", 0, typeof(System.Int32), typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32));
					r_RCopyTo_Int32_Span_d_Char_p__Int32.SetBelong(this.instance);
				}
				return r_RCopyTo_Int32_Span_d_Char_p__Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, System.String, Int32)
		/// </summary>
		protected RMethod r_RInsert_Int32_String_Int32;
		public virtual RMethod RInsert_Int32_String_Int32
		{
			get
			{
				if(r_RInsert_Int32_String_Int32 == null)
				{
					r_RInsert_Int32_String_Int32 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.String), typeof(System.Int32));
					r_RInsert_Int32_String_Int32.SetBelong(this.instance);
				}
				return r_RInsert_Int32_String_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Remove(Int32, Int32)
		/// </summary>
		protected RMethod r_RRemove_Int32_Int32;
		public virtual RMethod RRemove_Int32_Int32
		{
			get
			{
				if(r_RRemove_Int32_Int32 == null)
				{
					r_RRemove_Int32_Int32 = new(this, "Remove", 0, typeof(System.Int32), typeof(System.Int32));
					r_RRemove_Int32_Int32.SetBelong(this.instance);
				}
				return r_RRemove_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Boolean)
		/// </summary>
		protected RMethod r_RAppend_Boolean;
		public virtual RMethod RAppend_Boolean
		{
			get
			{
				if(r_RAppend_Boolean == null)
				{
					r_RAppend_Boolean = new(this, "Append", 0, typeof(System.Boolean));
					r_RAppend_Boolean.SetBelong(this.instance);
				}
				return r_RAppend_Boolean;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Char)
		/// </summary>
		protected RMethod r_RAppend_Char;
		public virtual RMethod RAppend_Char
		{
			get
			{
				if(r_RAppend_Char == null)
				{
					r_RAppend_Char = new(this, "Append", 0, typeof(System.Char));
					r_RAppend_Char.SetBelong(this.instance);
				}
				return r_RAppend_Char;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(SByte)
		/// </summary>
		protected RMethod r_RAppend_SByte;
		public virtual RMethod RAppend_SByte
		{
			get
			{
				if(r_RAppend_SByte == null)
				{
					r_RAppend_SByte = new(this, "Append", 0, typeof(System.SByte));
					r_RAppend_SByte.SetBelong(this.instance);
				}
				return r_RAppend_SByte;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Byte)
		/// </summary>
		protected RMethod r_RAppend_Byte;
		public virtual RMethod RAppend_Byte
		{
			get
			{
				if(r_RAppend_Byte == null)
				{
					r_RAppend_Byte = new(this, "Append", 0, typeof(System.Byte));
					r_RAppend_Byte.SetBelong(this.instance);
				}
				return r_RAppend_Byte;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Int16)
		/// </summary>
		protected RMethod r_RAppend_Int16;
		public virtual RMethod RAppend_Int16
		{
			get
			{
				if(r_RAppend_Int16 == null)
				{
					r_RAppend_Int16 = new(this, "Append", 0, typeof(System.Int16));
					r_RAppend_Int16.SetBelong(this.instance);
				}
				return r_RAppend_Int16;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Int32)
		/// </summary>
		protected RMethod r_RAppend_Int32;
		public virtual RMethod RAppend_Int32
		{
			get
			{
				if(r_RAppend_Int32 == null)
				{
					r_RAppend_Int32 = new(this, "Append", 0, typeof(System.Int32));
					r_RAppend_Int32.SetBelong(this.instance);
				}
				return r_RAppend_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Int64)
		/// </summary>
		protected RMethod r_RAppend_Int64;
		public virtual RMethod RAppend_Int64
		{
			get
			{
				if(r_RAppend_Int64 == null)
				{
					r_RAppend_Int64 = new(this, "Append", 0, typeof(System.Int64));
					r_RAppend_Int64.SetBelong(this.instance);
				}
				return r_RAppend_Int64;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Single)
		/// </summary>
		protected RMethod r_RAppend_Single;
		public virtual RMethod RAppend_Single
		{
			get
			{
				if(r_RAppend_Single == null)
				{
					r_RAppend_Single = new(this, "Append", 0, typeof(System.Single));
					r_RAppend_Single.SetBelong(this.instance);
				}
				return r_RAppend_Single;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Double)
		/// </summary>
		protected RMethod r_RAppend_Double;
		public virtual RMethod RAppend_Double
		{
			get
			{
				if(r_RAppend_Double == null)
				{
					r_RAppend_Double = new(this, "Append", 0, typeof(System.Double));
					r_RAppend_Double.SetBelong(this.instance);
				}
				return r_RAppend_Double;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(System.Decimal)
		/// </summary>
		protected RMethod r_RAppend_Decimal;
		public virtual RMethod RAppend_Decimal
		{
			get
			{
				if(r_RAppend_Decimal == null)
				{
					r_RAppend_Decimal = new(this, "Append", 0, typeof(System.Decimal));
					r_RAppend_Decimal.SetBelong(this.instance);
				}
				return r_RAppend_Decimal;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(UInt16)
		/// </summary>
		protected RMethod r_RAppend_UInt16;
		public virtual RMethod RAppend_UInt16
		{
			get
			{
				if(r_RAppend_UInt16 == null)
				{
					r_RAppend_UInt16 = new(this, "Append", 0, typeof(System.UInt16));
					r_RAppend_UInt16.SetBelong(this.instance);
				}
				return r_RAppend_UInt16;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(UInt32)
		/// </summary>
		protected RMethod r_RAppend_UInt32;
		public virtual RMethod RAppend_UInt32
		{
			get
			{
				if(r_RAppend_UInt32 == null)
				{
					r_RAppend_UInt32 = new(this, "Append", 0, typeof(System.UInt32));
					r_RAppend_UInt32.SetBelong(this.instance);
				}
				return r_RAppend_UInt32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(UInt64)
		/// </summary>
		protected RMethod r_RAppend_UInt64;
		public virtual RMethod RAppend_UInt64
		{
			get
			{
				if(r_RAppend_UInt64 == null)
				{
					r_RAppend_UInt64 = new(this, "Append", 0, typeof(System.UInt64));
					r_RAppend_UInt64.SetBelong(this.instance);
				}
				return r_RAppend_UInt64;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendSpanFormattable[T](T)
		/// </summary>
		protected RMethod r_RAppendSpanFormattable_GT_T;
		public virtual RMethod RAppendSpanFormattable_GT_T
		{
			get
			{
				if(r_RAppendSpanFormattable_GT_T == null)
				{
					r_RAppendSpanFormattable_GT_T = new(this, "AppendSpanFormattable", 1, Type.MakeGenericMethodParameter(0));
					r_RAppendSpanFormattable_GT_T.SetBelong(this.instance);
				}
				return r_RAppendSpanFormattable_GT_T;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(System.Object)
		/// </summary>
		protected RMethod r_RAppend_Object;
		public virtual RMethod RAppend_Object
		{
			get
			{
				if(r_RAppend_Object == null)
				{
					r_RAppend_Object = new(this, "Append", 0, typeof(System.Object));
					r_RAppend_Object.SetBelong(this.instance);
				}
				return r_RAppend_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Char[])
		/// </summary>
		protected RMethod r_RAppend_CharArray;
		public virtual RMethod RAppend_CharArray
		{
			get
			{
				if(r_RAppend_CharArray == null)
				{
					r_RAppend_CharArray = new(this, "Append", 0, typeof(System.Char).MakeArrayType());
					r_RAppend_CharArray.SetBelong(this.instance);
				}
				return r_RAppend_CharArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_RAppend_ReadOnlySpan_d_Char_p_;
		public virtual RMethod RAppend_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_RAppend_ReadOnlySpan_d_Char_p_ == null)
				{
					r_RAppend_ReadOnlySpan_d_Char_p_ = new(this, "Append", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_RAppend_ReadOnlySpan_d_Char_p_.SetBelong(this.instance);
				}
				return r_RAppend_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoin(System.String, System.Object[])
		/// </summary>
		protected RMethod r_RAppendJoin_String_ObjectArray;
		public virtual RMethod RAppendJoin_String_ObjectArray
		{
			get
			{
				if(r_RAppendJoin_String_ObjectArray == null)
				{
					r_RAppendJoin_String_ObjectArray = new(this, "AppendJoin", 0, typeof(System.String), typeof(System.Object).MakeArrayType());
					r_RAppendJoin_String_ObjectArray.SetBelong(this.instance);
				}
				return r_RAppendJoin_String_ObjectArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoin[T](System.String, System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RAppendJoin_GT_String_IEnumerable_d_T_p_;
		public virtual RMethod RAppendJoin_GT_String_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RAppendJoin_GT_String_IEnumerable_d_T_p_ == null)
				{
					r_RAppendJoin_GT_String_IEnumerable_d_T_p_ = new(this, "AppendJoin", 1, typeof(System.String), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RAppendJoin_GT_String_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RAppendJoin_GT_String_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoin(System.String, System.String[])
		/// </summary>
		protected RMethod r_RAppendJoin_String_StringArray;
		public virtual RMethod RAppendJoin_String_StringArray
		{
			get
			{
				if(r_RAppendJoin_String_StringArray == null)
				{
					r_RAppendJoin_String_StringArray = new(this, "AppendJoin", 0, typeof(System.String), typeof(System.String).MakeArrayType());
					r_RAppendJoin_String_StringArray.SetBelong(this.instance);
				}
				return r_RAppendJoin_String_StringArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoin(Char, System.Object[])
		/// </summary>
		protected RMethod r_RAppendJoin_Char_ObjectArray;
		public virtual RMethod RAppendJoin_Char_ObjectArray
		{
			get
			{
				if(r_RAppendJoin_Char_ObjectArray == null)
				{
					r_RAppendJoin_Char_ObjectArray = new(this, "AppendJoin", 0, typeof(System.Char), typeof(System.Object).MakeArrayType());
					r_RAppendJoin_Char_ObjectArray.SetBelong(this.instance);
				}
				return r_RAppendJoin_Char_ObjectArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoin[T](Char, System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RAppendJoin_GT_Char_IEnumerable_d_T_p_;
		public virtual RMethod RAppendJoin_GT_Char_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RAppendJoin_GT_Char_IEnumerable_d_T_p_ == null)
				{
					r_RAppendJoin_GT_Char_IEnumerable_d_T_p_ = new(this, "AppendJoin", 1, typeof(System.Char), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RAppendJoin_GT_Char_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RAppendJoin_GT_Char_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoin(Char, System.String[])
		/// </summary>
		protected RMethod r_RAppendJoin_Char_StringArray;
		public virtual RMethod RAppendJoin_Char_StringArray
		{
			get
			{
				if(r_RAppendJoin_Char_StringArray == null)
				{
					r_RAppendJoin_Char_StringArray = new(this, "AppendJoin", 0, typeof(System.Char), typeof(System.String).MakeArrayType());
					r_RAppendJoin_Char_StringArray.SetBelong(this.instance);
				}
				return r_RAppendJoin_Char_StringArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoinCore[T](Char*, Int32, System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_RAppendJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_;
		public virtual RMethod RAppendJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_
		{
			get
			{
				if(r_RAppendJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_ == null)
				{
					r_RAppendJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_ = new(this, "AppendJoinCore", 1, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RAppendJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_RAppendJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoinCore[T](Char*, Int32, T[])
		/// </summary>
		protected RMethod r_RAppendJoinCore_GT_CharPointer_Int32_TArray;
		public virtual RMethod RAppendJoinCore_GT_CharPointer_Int32_TArray
		{
			get
			{
				if(r_RAppendJoinCore_GT_CharPointer_Int32_TArray == null)
				{
					r_RAppendJoinCore_GT_CharPointer_Int32_TArray = new(this, "AppendJoinCore", 1, typeof(System.Char).MakePointerType(), typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_RAppendJoinCore_GT_CharPointer_Int32_TArray.SetBelong(this.instance);
				}
				return r_RAppendJoinCore_GT_CharPointer_Int32_TArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, System.String)
		/// </summary>
		protected RMethod r_RInsert_Int32_String;
		public virtual RMethod RInsert_Int32_String
		{
			get
			{
				if(r_RInsert_Int32_String == null)
				{
					r_RInsert_Int32_String = new(this, "Insert", 0, typeof(System.Int32), typeof(System.String));
					r_RInsert_Int32_String.SetBelong(this.instance);
				}
				return r_RInsert_Int32_String;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Boolean)
		/// </summary>
		protected RMethod r_RInsert_Int32_Boolean;
		public virtual RMethod RInsert_Int32_Boolean
		{
			get
			{
				if(r_RInsert_Int32_Boolean == null)
				{
					r_RInsert_Int32_Boolean = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Boolean));
					r_RInsert_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RInsert_Int32_Boolean;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, SByte)
		/// </summary>
		protected RMethod r_RInsert_Int32_SByte;
		public virtual RMethod RInsert_Int32_SByte
		{
			get
			{
				if(r_RInsert_Int32_SByte == null)
				{
					r_RInsert_Int32_SByte = new(this, "Insert", 0, typeof(System.Int32), typeof(System.SByte));
					r_RInsert_Int32_SByte.SetBelong(this.instance);
				}
				return r_RInsert_Int32_SByte;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Byte)
		/// </summary>
		protected RMethod r_RInsert_Int32_Byte;
		public virtual RMethod RInsert_Int32_Byte
		{
			get
			{
				if(r_RInsert_Int32_Byte == null)
				{
					r_RInsert_Int32_Byte = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Byte));
					r_RInsert_Int32_Byte.SetBelong(this.instance);
				}
				return r_RInsert_Int32_Byte;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Int16)
		/// </summary>
		protected RMethod r_RInsert_Int32_Int16;
		public virtual RMethod RInsert_Int32_Int16
		{
			get
			{
				if(r_RInsert_Int32_Int16 == null)
				{
					r_RInsert_Int32_Int16 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Int16));
					r_RInsert_Int32_Int16.SetBelong(this.instance);
				}
				return r_RInsert_Int32_Int16;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Char)
		/// </summary>
		protected RMethod r_RInsert_Int32_Char;
		public virtual RMethod RInsert_Int32_Char
		{
			get
			{
				if(r_RInsert_Int32_Char == null)
				{
					r_RInsert_Int32_Char = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Char));
					r_RInsert_Int32_Char.SetBelong(this.instance);
				}
				return r_RInsert_Int32_Char;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Char[])
		/// </summary>
		protected RMethod r_RInsert_Int32_CharArray;
		public virtual RMethod RInsert_Int32_CharArray
		{
			get
			{
				if(r_RInsert_Int32_CharArray == null)
				{
					r_RInsert_Int32_CharArray = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Char).MakeArrayType());
					r_RInsert_Int32_CharArray.SetBelong(this.instance);
				}
				return r_RInsert_Int32_CharArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RInsert_Int32_CharArray_Int32_Int32;
		public virtual RMethod RInsert_Int32_CharArray_Int32_Int32
		{
			get
			{
				if(r_RInsert_Int32_CharArray_Int32_Int32 == null)
				{
					r_RInsert_Int32_CharArray_Int32_Int32 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RInsert_Int32_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RInsert_Int32_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Int32)
		/// </summary>
		protected RMethod r_RInsert_Int32_Int32;
		public virtual RMethod RInsert_Int32_Int32
		{
			get
			{
				if(r_RInsert_Int32_Int32 == null)
				{
					r_RInsert_Int32_Int32 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Int32));
					r_RInsert_Int32_Int32.SetBelong(this.instance);
				}
				return r_RInsert_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Int64)
		/// </summary>
		protected RMethod r_RInsert_Int32_Int64;
		public virtual RMethod RInsert_Int32_Int64
		{
			get
			{
				if(r_RInsert_Int32_Int64 == null)
				{
					r_RInsert_Int32_Int64 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Int64));
					r_RInsert_Int32_Int64.SetBelong(this.instance);
				}
				return r_RInsert_Int32_Int64;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Single)
		/// </summary>
		protected RMethod r_RInsert_Int32_Single;
		public virtual RMethod RInsert_Int32_Single
		{
			get
			{
				if(r_RInsert_Int32_Single == null)
				{
					r_RInsert_Int32_Single = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Single));
					r_RInsert_Int32_Single.SetBelong(this.instance);
				}
				return r_RInsert_Int32_Single;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Double)
		/// </summary>
		protected RMethod r_RInsert_Int32_Double;
		public virtual RMethod RInsert_Int32_Double
		{
			get
			{
				if(r_RInsert_Int32_Double == null)
				{
					r_RInsert_Int32_Double = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Double));
					r_RInsert_Int32_Double.SetBelong(this.instance);
				}
				return r_RInsert_Int32_Double;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, System.Decimal)
		/// </summary>
		protected RMethod r_RInsert_Int32_Decimal;
		public virtual RMethod RInsert_Int32_Decimal
		{
			get
			{
				if(r_RInsert_Int32_Decimal == null)
				{
					r_RInsert_Int32_Decimal = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Decimal));
					r_RInsert_Int32_Decimal.SetBelong(this.instance);
				}
				return r_RInsert_Int32_Decimal;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, UInt16)
		/// </summary>
		protected RMethod r_RInsert_Int32_UInt16;
		public virtual RMethod RInsert_Int32_UInt16
		{
			get
			{
				if(r_RInsert_Int32_UInt16 == null)
				{
					r_RInsert_Int32_UInt16 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.UInt16));
					r_RInsert_Int32_UInt16.SetBelong(this.instance);
				}
				return r_RInsert_Int32_UInt16;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, UInt32)
		/// </summary>
		protected RMethod r_RInsert_Int32_UInt32;
		public virtual RMethod RInsert_Int32_UInt32
		{
			get
			{
				if(r_RInsert_Int32_UInt32 == null)
				{
					r_RInsert_Int32_UInt32 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.UInt32));
					r_RInsert_Int32_UInt32.SetBelong(this.instance);
				}
				return r_RInsert_Int32_UInt32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, UInt64)
		/// </summary>
		protected RMethod r_RInsert_Int32_UInt64;
		public virtual RMethod RInsert_Int32_UInt64
		{
			get
			{
				if(r_RInsert_Int32_UInt64 == null)
				{
					r_RInsert_Int32_UInt64 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.UInt64));
					r_RInsert_Int32_UInt64.SetBelong(this.instance);
				}
				return r_RInsert_Int32_UInt64;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, System.Object)
		/// </summary>
		protected RMethod r_RInsert_Int32_Object;
		public virtual RMethod RInsert_Int32_Object
		{
			get
			{
				if(r_RInsert_Int32_Object == null)
				{
					r_RInsert_Int32_Object = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Object));
					r_RInsert_Int32_Object.SetBelong(this.instance);
				}
				return r_RInsert_Int32_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_RInsert_Int32_ReadOnlySpan_d_Char_p_;
		public virtual RMethod RInsert_Int32_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_RInsert_Int32_ReadOnlySpan_d_Char_p_ == null)
				{
					r_RInsert_Int32_ReadOnlySpan_d_Char_p_ = new(this, "Insert", 0, typeof(System.Int32), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_RInsert_Int32_ReadOnlySpan_d_Char_p_.SetBelong(this.instance);
				}
				return r_RInsert_Int32_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.String, System.Object)
		/// </summary>
		protected RMethod r_RAppendFormat_String_Object;
		public virtual RMethod RAppendFormat_String_Object
		{
			get
			{
				if(r_RAppendFormat_String_Object == null)
				{
					r_RAppendFormat_String_Object = new(this, "AppendFormat", 0, typeof(System.String), typeof(System.Object));
					r_RAppendFormat_String_Object.SetBelong(this.instance);
				}
				return r_RAppendFormat_String_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.String, System.Object, System.Object)
		/// </summary>
		protected RMethod r_RAppendFormat_String_Object_Object;
		public virtual RMethod RAppendFormat_String_Object_Object
		{
			get
			{
				if(r_RAppendFormat_String_Object_Object == null)
				{
					r_RAppendFormat_String_Object_Object = new(this, "AppendFormat", 0, typeof(System.String), typeof(System.Object), typeof(System.Object));
					r_RAppendFormat_String_Object_Object.SetBelong(this.instance);
				}
				return r_RAppendFormat_String_Object_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.String, System.Object, System.Object, System.Object)
		/// </summary>
		protected RMethod r_RAppendFormat_String_Object_Object_Object;
		public virtual RMethod RAppendFormat_String_Object_Object_Object
		{
			get
			{
				if(r_RAppendFormat_String_Object_Object_Object == null)
				{
					r_RAppendFormat_String_Object_Object_Object = new(this, "AppendFormat", 0, typeof(System.String), typeof(System.Object), typeof(System.Object), typeof(System.Object));
					r_RAppendFormat_String_Object_Object_Object.SetBelong(this.instance);
				}
				return r_RAppendFormat_String_Object_Object_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.String, System.Object[])
		/// </summary>
		protected RMethod r_RAppendFormat_String_ObjectArray;
		public virtual RMethod RAppendFormat_String_ObjectArray
		{
			get
			{
				if(r_RAppendFormat_String_ObjectArray == null)
				{
					r_RAppendFormat_String_ObjectArray = new(this, "AppendFormat", 0, typeof(System.String), typeof(System.Object).MakeArrayType());
					r_RAppendFormat_String_ObjectArray.SetBelong(this.instance);
				}
				return r_RAppendFormat_String_ObjectArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.IFormatProvider, System.String, System.Object)
		/// </summary>
		protected RMethod r_RAppendFormat_IFormatProvider_String_Object;
		public virtual RMethod RAppendFormat_IFormatProvider_String_Object
		{
			get
			{
				if(r_RAppendFormat_IFormatProvider_String_Object == null)
				{
					r_RAppendFormat_IFormatProvider_String_Object = new(this, "AppendFormat", 0, typeof(System.IFormatProvider), typeof(System.String), typeof(System.Object));
					r_RAppendFormat_IFormatProvider_String_Object.SetBelong(this.instance);
				}
				return r_RAppendFormat_IFormatProvider_String_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.IFormatProvider, System.String, System.Object, System.Object)
		/// </summary>
		protected RMethod r_RAppendFormat_IFormatProvider_String_Object_Object;
		public virtual RMethod RAppendFormat_IFormatProvider_String_Object_Object
		{
			get
			{
				if(r_RAppendFormat_IFormatProvider_String_Object_Object == null)
				{
					r_RAppendFormat_IFormatProvider_String_Object_Object = new(this, "AppendFormat", 0, typeof(System.IFormatProvider), typeof(System.String), typeof(System.Object), typeof(System.Object));
					r_RAppendFormat_IFormatProvider_String_Object_Object.SetBelong(this.instance);
				}
				return r_RAppendFormat_IFormatProvider_String_Object_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.IFormatProvider, System.String, System.Object, System.Object, System.Object)
		/// </summary>
		protected RMethod r_RAppendFormat_IFormatProvider_String_Object_Object_Object;
		public virtual RMethod RAppendFormat_IFormatProvider_String_Object_Object_Object
		{
			get
			{
				if(r_RAppendFormat_IFormatProvider_String_Object_Object_Object == null)
				{
					r_RAppendFormat_IFormatProvider_String_Object_Object_Object = new(this, "AppendFormat", 0, typeof(System.IFormatProvider), typeof(System.String), typeof(System.Object), typeof(System.Object), typeof(System.Object));
					r_RAppendFormat_IFormatProvider_String_Object_Object_Object.SetBelong(this.instance);
				}
				return r_RAppendFormat_IFormatProvider_String_Object_Object_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.IFormatProvider, System.String, System.Object[])
		/// </summary>
		protected RMethod r_RAppendFormat_IFormatProvider_String_ObjectArray;
		public virtual RMethod RAppendFormat_IFormatProvider_String_ObjectArray
		{
			get
			{
				if(r_RAppendFormat_IFormatProvider_String_ObjectArray == null)
				{
					r_RAppendFormat_IFormatProvider_String_ObjectArray = new(this, "AppendFormat", 0, typeof(System.IFormatProvider), typeof(System.String), typeof(System.Object).MakeArrayType());
					r_RAppendFormat_IFormatProvider_String_ObjectArray.SetBelong(this.instance);
				}
				return r_RAppendFormat_IFormatProvider_String_ObjectArray;
			}
		}

		/// <summary>
		/// Void FormatError()
		/// </summary>
		protected static RMethod r_RFormatError;
		public static RMethod RFormatError
		{
			get
			{
				if(r_RFormatError == null)
				{
					r_RFormatError = new(typeof(System.Text.StringBuilder), "FormatError", 0);
					r_RFormatError.SetBelong(null);
				}
				return r_RFormatError;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
		/// </summary>
		protected RMethod r_RAppendFormatHelper_IFormatProvider_String_ParamsArray;
		public virtual RMethod RAppendFormatHelper_IFormatProvider_String_ParamsArray
		{
			get
			{
				if(r_RAppendFormatHelper_IFormatProvider_String_ParamsArray == null)
				{
					r_RAppendFormatHelper_IFormatProvider_String_ParamsArray = new(this, "AppendFormatHelper", 0, typeof(System.IFormatProvider), typeof(System.String),  ReleactionUtils.GetType("System.ParamsArray"));
					r_RAppendFormatHelper_IFormatProvider_String_ParamsArray.SetBelong(this.instance);
				}
				return r_RAppendFormatHelper_IFormatProvider_String_ParamsArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Replace(System.String, System.String)
		/// </summary>
		protected RMethod r_RReplace_String_String;
		public virtual RMethod RReplace_String_String
		{
			get
			{
				if(r_RReplace_String_String == null)
				{
					r_RReplace_String_String = new(this, "Replace", 0, typeof(System.String), typeof(System.String));
					r_RReplace_String_String.SetBelong(this.instance);
				}
				return r_RReplace_String_String;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_REquals_StringBuilder;
		public virtual RMethod REquals_StringBuilder
		{
			get
			{
				if(r_REquals_StringBuilder == null)
				{
					r_REquals_StringBuilder = new(this, "Equals", 0, typeof(System.Text.StringBuilder));
					r_REquals_StringBuilder.SetBelong(this.instance);
				}
				return r_REquals_StringBuilder;
			}
		}

		/// <summary>
		/// Boolean Equals(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_REquals_ReadOnlySpan_d_Char_p_;
		public virtual RMethod REquals_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_REquals_ReadOnlySpan_d_Char_p_ == null)
				{
					r_REquals_ReadOnlySpan_d_Char_p_ = new(this, "Equals", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_REquals_ReadOnlySpan_d_Char_p_.SetBelong(this.instance);
				}
				return r_REquals_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Replace(System.String, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_RReplace_String_String_Int32_Int32;
		public virtual RMethod RReplace_String_String_Int32_Int32
		{
			get
			{
				if(r_RReplace_String_String_Int32_Int32 == null)
				{
					r_RReplace_String_String_Int32_Int32 = new(this, "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RReplace_String_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReplace_String_String_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Replace(Char, Char)
		/// </summary>
		protected RMethod r_RReplace_Char_Char;
		public virtual RMethod RReplace_Char_Char
		{
			get
			{
				if(r_RReplace_Char_Char == null)
				{
					r_RReplace_Char_Char = new(this, "Replace", 0, typeof(System.Char), typeof(System.Char));
					r_RReplace_Char_Char.SetBelong(this.instance);
				}
				return r_RReplace_Char_Char;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Replace(Char, Char, Int32, Int32)
		/// </summary>
		protected RMethod r_RReplace_Char_Char_Int32_Int32;
		public virtual RMethod RReplace_Char_Char_Int32_Int32
		{
			get
			{
				if(r_RReplace_Char_Char_Int32_Int32 == null)
				{
					r_RReplace_Char_Char_Int32_Int32 = new(this, "Replace", 0, typeof(System.Char), typeof(System.Char), typeof(System.Int32), typeof(System.Int32));
					r_RReplace_Char_Char_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReplace_Char_Char_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Char*, Int32)
		/// </summary>
		protected RMethod r_RAppend_CharPointer_Int32;
		public virtual RMethod RAppend_CharPointer_Int32
		{
			get
			{
				if(r_RAppend_CharPointer_Int32 == null)
				{
					r_RAppend_CharPointer_Int32 = new(this, "Append", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_RAppend_CharPointer_Int32.SetBelong(this.instance);
				}
				return r_RAppend_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Void Insert(Int32, Char*, Int32)
		/// </summary>
		protected RMethod r_RInsert_Int32_CharPointer_Int32;
		public virtual RMethod RInsert_Int32_CharPointer_Int32
		{
			get
			{
				if(r_RInsert_Int32_CharPointer_Int32 == null)
				{
					r_RInsert_Int32_CharPointer_Int32 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_RInsert_Int32_CharPointer_Int32.SetBelong(this.instance);
				}
				return r_RInsert_Int32_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Void ReplaceAllInChunk(Int32[], Int32, System.Text.StringBuilder, Int32, System.String)
		/// </summary>
		protected RMethod r_RReplaceAllInChunk_Int32Array_Int32_StringBuilder_Int32_String;
		public virtual RMethod RReplaceAllInChunk_Int32Array_Int32_StringBuilder_Int32_String
		{
			get
			{
				if(r_RReplaceAllInChunk_Int32Array_Int32_StringBuilder_Int32_String == null)
				{
					r_RReplaceAllInChunk_Int32Array_Int32_StringBuilder_Int32_String = new(this, "ReplaceAllInChunk", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32), typeof(System.Text.StringBuilder), typeof(System.Int32), typeof(System.String));
					r_RReplaceAllInChunk_Int32Array_Int32_StringBuilder_Int32_String.SetBelong(this.instance);
				}
				return r_RReplaceAllInChunk_Int32Array_Int32_StringBuilder_Int32_String;
			}
		}

		/// <summary>
		/// Boolean StartsWith(System.Text.StringBuilder, Int32, Int32, System.String)
		/// </summary>
		protected RMethod r_RStartsWith_StringBuilder_Int32_Int32_String;
		public virtual RMethod RStartsWith_StringBuilder_Int32_Int32_String
		{
			get
			{
				if(r_RStartsWith_StringBuilder_Int32_Int32_String == null)
				{
					r_RStartsWith_StringBuilder_Int32_Int32_String = new(this, "StartsWith", 0, typeof(System.Text.StringBuilder), typeof(System.Int32), typeof(System.Int32), typeof(System.String));
					r_RStartsWith_StringBuilder_Int32_Int32_String.SetBelong(this.instance);
				}
				return r_RStartsWith_StringBuilder_Int32_Int32_String;
			}
		}

		/// <summary>
		/// Void ReplaceInPlaceAtChunk(System.Text.StringBuilder ByRef, Int32 ByRef, Char*, Int32)
		/// </summary>
		protected RMethod r_RReplaceInPlaceAtChunk_Ref_StringBuilder_Ref_Int32_CharPointer_Int32;
		public virtual RMethod RReplaceInPlaceAtChunk_Ref_StringBuilder_Ref_Int32_CharPointer_Int32
		{
			get
			{
				if(r_RReplaceInPlaceAtChunk_Ref_StringBuilder_Ref_Int32_CharPointer_Int32 == null)
				{
					r_RReplaceInPlaceAtChunk_Ref_StringBuilder_Ref_Int32_CharPointer_Int32 = new(this, "ReplaceInPlaceAtChunk", 0, typeof(System.Text.StringBuilder).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_RReplaceInPlaceAtChunk_Ref_StringBuilder_Ref_Int32_CharPointer_Int32.SetBelong(this.instance);
				}
				return r_RReplaceInPlaceAtChunk_Ref_StringBuilder_Ref_Int32_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Void ThreadSafeCopy(Char*, Char[], Int32, Int32)
		/// </summary>
		protected static RMethod r_RThreadSafeCopy_CharPointer_CharArray_Int32_Int32;
		public static RMethod RThreadSafeCopy_CharPointer_CharArray_Int32_Int32
		{
			get
			{
				if(r_RThreadSafeCopy_CharPointer_CharArray_Int32_Int32 == null)
				{
					r_RThreadSafeCopy_CharPointer_CharArray_Int32_Int32 = new(typeof(System.Text.StringBuilder), "ThreadSafeCopy", 0, typeof(System.Char).MakePointerType(), typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RThreadSafeCopy_CharPointer_CharArray_Int32_Int32.SetBelong(null);
				}
				return r_RThreadSafeCopy_CharPointer_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ThreadSafeCopy(Char[], Int32, System.Span`1[System.Char], Int32, Int32)
		/// </summary>
		protected static RMethod r_RThreadSafeCopy_CharArray_Int32_Span_d_Char_p__Int32_Int32;
		public static RMethod RThreadSafeCopy_CharArray_Int32_Span_d_Char_p__Int32_Int32
		{
			get
			{
				if(r_RThreadSafeCopy_CharArray_Int32_Span_d_Char_p__Int32_Int32 == null)
				{
					r_RThreadSafeCopy_CharArray_Int32_Span_d_Char_p__Int32_Int32 = new(typeof(System.Text.StringBuilder), "ThreadSafeCopy", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32), typeof(System.Int32));
					r_RThreadSafeCopy_CharArray_Int32_Span_d_Char_p__Int32_Int32.SetBelong(null);
				}
				return r_RThreadSafeCopy_CharArray_Int32_Span_d_Char_p__Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder FindChunkForIndex(Int32)
		/// </summary>
		protected RMethod r_RFindChunkForIndex_Int32;
		public virtual RMethod RFindChunkForIndex_Int32
		{
			get
			{
				if(r_RFindChunkForIndex_Int32 == null)
				{
					r_RFindChunkForIndex_Int32 = new(this, "FindChunkForIndex", 0, typeof(System.Int32));
					r_RFindChunkForIndex_Int32.SetBelong(this.instance);
				}
				return r_RFindChunkForIndex_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder FindChunkForByte(Int32)
		/// </summary>
		protected RMethod r_RFindChunkForByte_Int32;
		public virtual RMethod RFindChunkForByte_Int32
		{
			get
			{
				if(r_RFindChunkForByte_Int32 == null)
				{
					r_RFindChunkForByte_Int32 = new(this, "FindChunkForByte", 0, typeof(System.Int32));
					r_RFindChunkForByte_Int32.SetBelong(this.instance);
				}
				return r_RFindChunkForByte_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Next(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_RNext_StringBuilder;
		public virtual RMethod RNext_StringBuilder
		{
			get
			{
				if(r_RNext_StringBuilder == null)
				{
					r_RNext_StringBuilder = new(this, "Next", 0, typeof(System.Text.StringBuilder));
					r_RNext_StringBuilder.SetBelong(this.instance);
				}
				return r_RNext_StringBuilder;
			}
		}

		/// <summary>
		/// Void ExpandByABlock(Int32)
		/// </summary>
		protected RMethod r_RExpandByABlock_Int32;
		public virtual RMethod RExpandByABlock_Int32
		{
			get
			{
				if(r_RExpandByABlock_Int32 == null)
				{
					r_RExpandByABlock_Int32 = new(this, "ExpandByABlock", 0, typeof(System.Int32));
					r_RExpandByABlock_Int32.SetBelong(this.instance);
				}
				return r_RExpandByABlock_Int32;
			}
		}

		/// <summary>
		/// Void MakeRoom(Int32, Int32, System.Text.StringBuilder ByRef, Int32 ByRef, Boolean)
		/// </summary>
		protected RMethod r_RMakeRoom_Int32_Int32_Out_StringBuilder_Out_Int32_Boolean;
		public virtual RMethod RMakeRoom_Int32_Int32_Out_StringBuilder_Out_Int32_Boolean
		{
			get
			{
				if(r_RMakeRoom_Int32_Int32_Out_StringBuilder_Out_Int32_Boolean == null)
				{
					r_RMakeRoom_Int32_Int32_Out_StringBuilder_Out_Int32_Boolean = new(this, "MakeRoom", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Text.StringBuilder).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
					r_RMakeRoom_Int32_Int32_Out_StringBuilder_Out_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RMakeRoom_Int32_Int32_Out_StringBuilder_Out_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void Remove(Int32, Int32, System.Text.StringBuilder ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_RRemove_Int32_Int32_Out_StringBuilder_Out_Int32;
		public virtual RMethod RRemove_Int32_Int32_Out_StringBuilder_Out_Int32
		{
			get
			{
				if(r_RRemove_Int32_Int32_Out_StringBuilder_Out_Int32 == null)
				{
					r_RRemove_Int32_Int32_Out_StringBuilder_Out_Int32 = new(this, "Remove", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Text.StringBuilder).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_RRemove_Int32_Int32_Out_StringBuilder_Out_Int32.SetBelong(this.instance);
				}
				return r_RRemove_Int32_Int32_Out_StringBuilder_Out_Int32;
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


        public RStringBuilder() : base("System.Text.StringBuilder")
        {
        }

        public RStringBuilder(System.Object instance) : base("System.Text.StringBuilder")
		{
            SetInstance(instance);
		}

        public RStringBuilder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStringBuilder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void System__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AssertInvariants()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAssertInvariants.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 EnsureCapacity(System.Int32  @capacity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@capacity};
            var ___result = REnsureCapacity_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.Int32  @startIndex, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @length};
            var ___result = RToString_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Text.StringBuilder Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Char  @value, System.Int32  @repeatCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @repeatCount};
            var ___result = RAppend_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Char[]  @value, System.Int32  @startIndex, System.Int32  @charCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @charCount};
            var ___result = RAppend_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_String.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual void AppendHelper(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppendHelper_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Text.StringBuilder Append(System.String  @value, System.Int32  @startIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RAppend_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Text.StringBuilder  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Text.StringBuilder  @value, System.Int32  @startIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RAppend_StringBuilder_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendCore(System.Text.StringBuilder  @value, System.Int32  @startIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RAppendCore_StringBuilder_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendLine()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAppendLine.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendLine(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppendLine_String.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual void CopyTo(System.Int32  @sourceIndex, System.Char[]  @destination, System.Int32  @destinationIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceIndex, @destination, @destinationIndex, @count};
            var ___result = RCopyTo_Int32_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Text.StringBuilder Insert(System.Int32  @index, System.String  @value, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value, @count};
            var ___result = RInsert_Int32_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Remove(System.Int32  @startIndex, System.Int32  @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @length};
            var ___result = RRemove_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Char  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_Char.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.SByte  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_SByte.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Byte  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_Byte.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Int16  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_Int16.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Int64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_Int64.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_Single.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Double  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_Double.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.UInt16  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_UInt16.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.UInt32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.UInt64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_UInt64.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendSpanFormattable<T>(T  @value) where T : System.IFormattable
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@value};
            var ___result = RAppendSpanFormattable_GT_T.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Char[]  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_CharArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }



        public virtual System.Text.StringBuilder AppendJoin(System.String  @separator, System.Object[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RAppendJoin_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendJoin<T>(System.String  @separator, System.Collections.Generic.IEnumerable<T>  @values)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RAppendJoin_GT_String_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendJoin(System.String  @separator, System.String[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RAppendJoin_String_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendJoin(System.Char  @separator, System.Object[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RAppendJoin_Char_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendJoin<T>(System.Char  @separator, System.Collections.Generic.IEnumerable<T>  @values)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RAppendJoin_GT_Char_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendJoin(System.Char  @separator, System.String[]  @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RAppendJoin_Char_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }




        public virtual System.Text.StringBuilder Insert(System.Int32  @index, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_String.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32  @index, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32  @index, System.SByte  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_SByte.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32  @index, System.Byte  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_Byte.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32  @index, System.Int16  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_Int16.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32  @index, System.Char  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_Char.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32  @index, System.Char[]  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_CharArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32  @index, System.Char[]  @value, System.Int32  @startIndex, System.Int32  @charCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value, @startIndex, @charCount};
            var ___result = RInsert_Int32_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32  @index, System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32  @index, System.Int64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_Int64.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32  @index, System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_Single.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32  @index, System.Double  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_Double.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32  @index, System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32  @index, System.UInt16  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_UInt16.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32  @index, System.UInt32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32  @index, System.UInt64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_UInt64.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32  @index, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }



        public virtual System.Text.StringBuilder AppendFormat(System.String  @format, System.Object  @arg0)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg0};
            var ___result = RAppendFormat_String_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.String  @format, System.Object  @arg0, System.Object  @arg1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg0, @arg1};
            var ___result = RAppendFormat_String_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.String  @format, System.Object  @arg0, System.Object  @arg1, System.Object  @arg2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg0, @arg1, @arg2};
            var ___result = RAppendFormat_String_Object_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.String  @format, System.Object[]  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @args};
            var ___result = RAppendFormat_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.IFormatProvider  @provider, System.String  @format, System.Object  @arg0)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @arg0};
            var ___result = RAppendFormat_IFormatProvider_String_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.IFormatProvider  @provider, System.String  @format, System.Object  @arg0, System.Object  @arg1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @arg0, @arg1};
            var ___result = RAppendFormat_IFormatProvider_String_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.IFormatProvider  @provider, System.String  @format, System.Object  @arg0, System.Object  @arg1, System.Object  @arg2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @arg0, @arg1, @arg2};
            var ___result = RAppendFormat_IFormatProvider_String_Object_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.IFormatProvider  @provider, System.String  @format, System.Object[]  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @args};
            var ___result = RAppendFormat_IFormatProvider_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public static void FormatError()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFormatError.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Text.StringBuilder Replace(System.String  @oldValue, System.String  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = RReplace_String_String.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Boolean Equals(System.Text.StringBuilder  @sb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sb};
            var ___result = REquals_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual System.Text.StringBuilder Replace(System.String  @oldValue, System.String  @newValue, System.Int32  @startIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue, @startIndex, @count};
            var ___result = RReplace_String_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Replace(System.Char  @oldChar, System.Char  @newChar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldChar, @newChar};
            var ___result = RReplace_Char_Char.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Replace(System.Char  @oldChar, System.Char  @newChar, System.Int32  @startIndex, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldChar, @newChar, @startIndex, @count};
            var ___result = RReplace_Char_Char_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }




        public virtual void ReplaceAllInChunk(System.Int32[]  @replacements, System.Int32  @replacementsCount, System.Text.StringBuilder  @sourceChunk, System.Int32  @removeCount, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@replacements, @replacementsCount, @sourceChunk, @removeCount, @value};
            var ___result = RReplaceAllInChunk_Int32Array_Int32_StringBuilder_Int32_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean StartsWith(System.Text.StringBuilder  @chunk, System.Int32  @indexInChunk, System.Int32  @count, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chunk, @indexInChunk, @count, @value};
            var ___result = RStartsWith_StringBuilder_Int32_Int32_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }





        public virtual System.Text.StringBuilder FindChunkForIndex(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RFindChunkForIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder FindChunkForByte(System.Int32  @byteIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@byteIndex};
            var ___result = RFindChunkForByte_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Next(System.Text.StringBuilder  @chunk)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chunk};
            var ___result = RNext_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual void ExpandByABlock(System.Int32  @minBlockCharCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@minBlockCharCount};
            var ___result = RExpandByABlock_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MakeRoom(System.Int32  @index, System.Int32  @count, out System.Text.StringBuilder  @chunk, out System.Int32  @indexInChunk, System.Boolean  @doNotMoveFollowingChars)
        {
			chunk = default;
			indexInChunk = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count, @chunk, @indexInChunk, @doNotMoveFollowingChars};
            var ___result = RMakeRoom_Int32_Int32_Out_StringBuilder_Out_Int32_Boolean.Invoke(___genericsType, ___parameters);
			chunk = (System.Text.StringBuilder)___parameters[2];
			indexInChunk = (System.Int32)___parameters[3];

            
        }


        public virtual void Remove(System.Int32  @startIndex, System.Int32  @count, out System.Text.StringBuilder  @chunk, out System.Int32  @indexInChunk)
        {
			chunk = default;
			indexInChunk = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @count, @chunk, @indexInChunk};
            var ___result = RRemove_Int32_Int32_Out_StringBuilder_Out_Int32.Invoke(___genericsType, ___parameters);
			chunk = (System.Text.StringBuilder)___parameters[2];
			indexInChunk = (System.Int32)___parameters[3];

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
