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
		protected RFieldArray<RSystem.RChar> r_m_ChunkChars;
		public virtual RFieldArray<RSystem.RChar> Rm_ChunkChars
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
		protected RSystem.RInt32 r_m_ChunkLength;
		public virtual RSystem.RInt32 Rm_ChunkLength
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
		protected RSystem.RInt32 r_m_ChunkOffset;
		public virtual RSystem.RInt32 Rm_ChunkOffset
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
		protected RSystem.RInt32 r_m_MaxCapacity;
		public virtual RSystem.RInt32 Rm_MaxCapacity
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
		protected static RSystem.RInt32 r_DefaultCapacity;
		public static RSystem.RInt32 RDefaultCapacity
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
		protected static RSystem.RString r_CapacityField;
		public static RSystem.RString RCapacityField
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
		protected static RSystem.RString r_MaxCapacityField;
		public static RSystem.RString RMaxCapacityField
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
		protected static RSystem.RString r_StringValueField;
		public static RSystem.RString RStringValueField
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
		protected static RSystem.RString r_ThreadIDField;
		public static RSystem.RString RThreadIDField
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
		protected static RSystem.RInt32 r_MaxChunkSize;
		public static RSystem.RInt32 RMaxChunkSize
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
		protected static RSystem.RInt32 r_IndexLimit;
		public static RSystem.RInt32 RIndexLimit
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
		protected static RSystem.RInt32 r_WidthLimit;
		public static RSystem.RInt32 RWidthLimit
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
		protected RSystem.RInt32 r_Capacity;
		public virtual RSystem.RInt32 RCapacity
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
		protected RSystem.RInt32 r_MaxCapacity;
		public virtual RSystem.RInt32 RMaxCapacity
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
		protected RSystem.RInt32 r_Length;
		public virtual RSystem.RInt32 RLength
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
		protected RSystem.RChar r_Chars_Int32;
		public virtual RSystem.RChar RChars_Int32
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
		protected RSystem.RSpan<RSystem.RChar> r_RemainingCurrentChunk;
		public virtual RSystem.RSpan<RSystem.RChar> RRemainingCurrentChunk
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
		protected RMethod r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext = new(this, "System.Runtime.Serialization.ISerializable.GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Void AssertInvariants()
		/// </summary>
		protected RMethod r_AssertInvariants;
		public virtual RMethod RAssertInvariants
		{
			get
			{
				if(r_AssertInvariants == null)
				{
					r_AssertInvariants = new(this, "AssertInvariants", 0);
					r_AssertInvariants.SetBelong(this.instance);
				}
				return r_AssertInvariants;
			}
		}

		/// <summary>
		/// Int32 EnsureCapacity(Int32)
		/// </summary>
		protected RMethod r_EnsureCapacity_Int32;
		public virtual RMethod REnsureCapacity_Int32
		{
			get
			{
				if(r_EnsureCapacity_Int32 == null)
				{
					r_EnsureCapacity_Int32 = new(this, "EnsureCapacity", 0, typeof(System.Int32));
					r_EnsureCapacity_Int32.SetBelong(this.instance);
				}
				return r_EnsureCapacity_Int32;
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
		/// System.String ToString(Int32, Int32)
		/// </summary>
		protected RMethod r_ToString_Int32_Int32;
		public virtual RMethod RToString_Int32_Int32
		{
			get
			{
				if(r_ToString_Int32_Int32 == null)
				{
					r_ToString_Int32_Int32 = new(this, "ToString", 0, typeof(System.Int32), typeof(System.Int32));
					r_ToString_Int32_Int32.SetBelong(this.instance);
				}
				return r_ToString_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Clear()
		/// </summary>
		protected RMethod r_Clear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_Clear == null)
				{
					r_Clear = new(this, "Clear", 0);
					r_Clear.SetBelong(this.instance);
				}
				return r_Clear;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Char, Int32)
		/// </summary>
		protected RMethod r_Append_Char_Int32;
		public virtual RMethod RAppend_Char_Int32
		{
			get
			{
				if(r_Append_Char_Int32 == null)
				{
					r_Append_Char_Int32 = new(this, "Append", 0, typeof(System.Char), typeof(System.Int32));
					r_Append_Char_Int32.SetBelong(this.instance);
				}
				return r_Append_Char_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_Append_CharArray_Int32_Int32;
		public virtual RMethod RAppend_CharArray_Int32_Int32
		{
			get
			{
				if(r_Append_CharArray_Int32_Int32 == null)
				{
					r_Append_CharArray_Int32_Int32 = new(this, "Append", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_Append_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_Append_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(System.String)
		/// </summary>
		protected RMethod r_Append_String;
		public virtual RMethod RAppend_String
		{
			get
			{
				if(r_Append_String == null)
				{
					r_Append_String = new(this, "Append", 0, typeof(System.String));
					r_Append_String.SetBelong(this.instance);
				}
				return r_Append_String;
			}
		}

		/// <summary>
		/// Void AppendHelper(System.String)
		/// </summary>
		protected RMethod r_AppendHelper_String;
		public virtual RMethod RAppendHelper_String
		{
			get
			{
				if(r_AppendHelper_String == null)
				{
					r_AppendHelper_String = new(this, "AppendHelper", 0, typeof(System.String));
					r_AppendHelper_String.SetBelong(this.instance);
				}
				return r_AppendHelper_String;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_Append_String_Int32_Int32;
		public virtual RMethod RAppend_String_Int32_Int32
		{
			get
			{
				if(r_Append_String_Int32_Int32 == null)
				{
					r_Append_String_Int32_Int32 = new(this, "Append", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_Append_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_Append_String_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_Append_StringBuilder;
		public virtual RMethod RAppend_StringBuilder
		{
			get
			{
				if(r_Append_StringBuilder == null)
				{
					r_Append_StringBuilder = new(this, "Append", 0, typeof(System.Text.StringBuilder));
					r_Append_StringBuilder.SetBelong(this.instance);
				}
				return r_Append_StringBuilder;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(System.Text.StringBuilder, Int32, Int32)
		/// </summary>
		protected RMethod r_Append_StringBuilder_Int32_Int32;
		public virtual RMethod RAppend_StringBuilder_Int32_Int32
		{
			get
			{
				if(r_Append_StringBuilder_Int32_Int32 == null)
				{
					r_Append_StringBuilder_Int32_Int32 = new(this, "Append", 0, typeof(System.Text.StringBuilder), typeof(System.Int32), typeof(System.Int32));
					r_Append_StringBuilder_Int32_Int32.SetBelong(this.instance);
				}
				return r_Append_StringBuilder_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendCore(System.Text.StringBuilder, Int32, Int32)
		/// </summary>
		protected RMethod r_AppendCore_StringBuilder_Int32_Int32;
		public virtual RMethod RAppendCore_StringBuilder_Int32_Int32
		{
			get
			{
				if(r_AppendCore_StringBuilder_Int32_Int32 == null)
				{
					r_AppendCore_StringBuilder_Int32_Int32 = new(this, "AppendCore", 0, typeof(System.Text.StringBuilder), typeof(System.Int32), typeof(System.Int32));
					r_AppendCore_StringBuilder_Int32_Int32.SetBelong(this.instance);
				}
				return r_AppendCore_StringBuilder_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendLine()
		/// </summary>
		protected RMethod r_AppendLine;
		public virtual RMethod RAppendLine
		{
			get
			{
				if(r_AppendLine == null)
				{
					r_AppendLine = new(this, "AppendLine", 0);
					r_AppendLine.SetBelong(this.instance);
				}
				return r_AppendLine;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendLine(System.String)
		/// </summary>
		protected RMethod r_AppendLine_String;
		public virtual RMethod RAppendLine_String
		{
			get
			{
				if(r_AppendLine_String == null)
				{
					r_AppendLine_String = new(this, "AppendLine", 0, typeof(System.String));
					r_AppendLine_String.SetBelong(this.instance);
				}
				return r_AppendLine_String;
			}
		}

		/// <summary>
		/// Void CopyTo(Int32, Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_CopyTo_Int32_CharArray_Int32_Int32;
		public virtual RMethod RCopyTo_Int32_CharArray_Int32_Int32
		{
			get
			{
				if(r_CopyTo_Int32_CharArray_Int32_Int32 == null)
				{
					r_CopyTo_Int32_CharArray_Int32_Int32 = new(this, "CopyTo", 0, typeof(System.Int32), typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_CopyTo_Int32_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_CopyTo_Int32_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopyTo(Int32, System.Span`1[System.Char], Int32)
		/// </summary>
		protected RMethod r_CopyTo_Int32_Span_d_Char_p__Int32;
		public virtual RMethod RCopyTo_Int32_Span_d_Char_p__Int32
		{
			get
			{
				if(r_CopyTo_Int32_Span_d_Char_p__Int32 == null)
				{
					r_CopyTo_Int32_Span_d_Char_p__Int32 = new(this, "CopyTo", 0, typeof(System.Int32), typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32));
					r_CopyTo_Int32_Span_d_Char_p__Int32.SetBelong(this.instance);
				}
				return r_CopyTo_Int32_Span_d_Char_p__Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, System.String, Int32)
		/// </summary>
		protected RMethod r_Insert_Int32_String_Int32;
		public virtual RMethod RInsert_Int32_String_Int32
		{
			get
			{
				if(r_Insert_Int32_String_Int32 == null)
				{
					r_Insert_Int32_String_Int32 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.String), typeof(System.Int32));
					r_Insert_Int32_String_Int32.SetBelong(this.instance);
				}
				return r_Insert_Int32_String_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Remove(Int32, Int32)
		/// </summary>
		protected RMethod r_Remove_Int32_Int32;
		public virtual RMethod RRemove_Int32_Int32
		{
			get
			{
				if(r_Remove_Int32_Int32 == null)
				{
					r_Remove_Int32_Int32 = new(this, "Remove", 0, typeof(System.Int32), typeof(System.Int32));
					r_Remove_Int32_Int32.SetBelong(this.instance);
				}
				return r_Remove_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Boolean)
		/// </summary>
		protected RMethod r_Append_Boolean;
		public virtual RMethod RAppend_Boolean
		{
			get
			{
				if(r_Append_Boolean == null)
				{
					r_Append_Boolean = new(this, "Append", 0, typeof(System.Boolean));
					r_Append_Boolean.SetBelong(this.instance);
				}
				return r_Append_Boolean;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Char)
		/// </summary>
		protected RMethod r_Append_Char;
		public virtual RMethod RAppend_Char
		{
			get
			{
				if(r_Append_Char == null)
				{
					r_Append_Char = new(this, "Append", 0, typeof(System.Char));
					r_Append_Char.SetBelong(this.instance);
				}
				return r_Append_Char;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(SByte)
		/// </summary>
		protected RMethod r_Append_SByte;
		public virtual RMethod RAppend_SByte
		{
			get
			{
				if(r_Append_SByte == null)
				{
					r_Append_SByte = new(this, "Append", 0, typeof(System.SByte));
					r_Append_SByte.SetBelong(this.instance);
				}
				return r_Append_SByte;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Byte)
		/// </summary>
		protected RMethod r_Append_Byte;
		public virtual RMethod RAppend_Byte
		{
			get
			{
				if(r_Append_Byte == null)
				{
					r_Append_Byte = new(this, "Append", 0, typeof(System.Byte));
					r_Append_Byte.SetBelong(this.instance);
				}
				return r_Append_Byte;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Int16)
		/// </summary>
		protected RMethod r_Append_Int16;
		public virtual RMethod RAppend_Int16
		{
			get
			{
				if(r_Append_Int16 == null)
				{
					r_Append_Int16 = new(this, "Append", 0, typeof(System.Int16));
					r_Append_Int16.SetBelong(this.instance);
				}
				return r_Append_Int16;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Int32)
		/// </summary>
		protected RMethod r_Append_Int32;
		public virtual RMethod RAppend_Int32
		{
			get
			{
				if(r_Append_Int32 == null)
				{
					r_Append_Int32 = new(this, "Append", 0, typeof(System.Int32));
					r_Append_Int32.SetBelong(this.instance);
				}
				return r_Append_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Int64)
		/// </summary>
		protected RMethod r_Append_Int64;
		public virtual RMethod RAppend_Int64
		{
			get
			{
				if(r_Append_Int64 == null)
				{
					r_Append_Int64 = new(this, "Append", 0, typeof(System.Int64));
					r_Append_Int64.SetBelong(this.instance);
				}
				return r_Append_Int64;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Single)
		/// </summary>
		protected RMethod r_Append_Single;
		public virtual RMethod RAppend_Single
		{
			get
			{
				if(r_Append_Single == null)
				{
					r_Append_Single = new(this, "Append", 0, typeof(System.Single));
					r_Append_Single.SetBelong(this.instance);
				}
				return r_Append_Single;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Double)
		/// </summary>
		protected RMethod r_Append_Double;
		public virtual RMethod RAppend_Double
		{
			get
			{
				if(r_Append_Double == null)
				{
					r_Append_Double = new(this, "Append", 0, typeof(System.Double));
					r_Append_Double.SetBelong(this.instance);
				}
				return r_Append_Double;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(System.Decimal)
		/// </summary>
		protected RMethod r_Append_Decimal;
		public virtual RMethod RAppend_Decimal
		{
			get
			{
				if(r_Append_Decimal == null)
				{
					r_Append_Decimal = new(this, "Append", 0, typeof(System.Decimal));
					r_Append_Decimal.SetBelong(this.instance);
				}
				return r_Append_Decimal;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(UInt16)
		/// </summary>
		protected RMethod r_Append_UInt16;
		public virtual RMethod RAppend_UInt16
		{
			get
			{
				if(r_Append_UInt16 == null)
				{
					r_Append_UInt16 = new(this, "Append", 0, typeof(System.UInt16));
					r_Append_UInt16.SetBelong(this.instance);
				}
				return r_Append_UInt16;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(UInt32)
		/// </summary>
		protected RMethod r_Append_UInt32;
		public virtual RMethod RAppend_UInt32
		{
			get
			{
				if(r_Append_UInt32 == null)
				{
					r_Append_UInt32 = new(this, "Append", 0, typeof(System.UInt32));
					r_Append_UInt32.SetBelong(this.instance);
				}
				return r_Append_UInt32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(UInt64)
		/// </summary>
		protected RMethod r_Append_UInt64;
		public virtual RMethod RAppend_UInt64
		{
			get
			{
				if(r_Append_UInt64 == null)
				{
					r_Append_UInt64 = new(this, "Append", 0, typeof(System.UInt64));
					r_Append_UInt64.SetBelong(this.instance);
				}
				return r_Append_UInt64;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendSpanFormattable[T](T)
		/// </summary>
		protected RMethod r_AppendSpanFormattable_GT_T;
		public virtual RMethod RAppendSpanFormattable_GT_T
		{
			get
			{
				if(r_AppendSpanFormattable_GT_T == null)
				{
					r_AppendSpanFormattable_GT_T = new(this, "AppendSpanFormattable", 1, Type.MakeGenericMethodParameter(0));
					r_AppendSpanFormattable_GT_T.SetBelong(this.instance);
				}
				return r_AppendSpanFormattable_GT_T;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(System.Object)
		/// </summary>
		protected RMethod r_Append_Object;
		public virtual RMethod RAppend_Object
		{
			get
			{
				if(r_Append_Object == null)
				{
					r_Append_Object = new(this, "Append", 0, typeof(System.Object));
					r_Append_Object.SetBelong(this.instance);
				}
				return r_Append_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Char[])
		/// </summary>
		protected RMethod r_Append_CharArray;
		public virtual RMethod RAppend_CharArray
		{
			get
			{
				if(r_Append_CharArray == null)
				{
					r_Append_CharArray = new(this, "Append", 0, typeof(System.Char).MakeArrayType());
					r_Append_CharArray.SetBelong(this.instance);
				}
				return r_Append_CharArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_Append_ReadOnlySpan_d_Char_p_;
		public virtual RMethod RAppend_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_Append_ReadOnlySpan_d_Char_p_ == null)
				{
					r_Append_ReadOnlySpan_d_Char_p_ = new(this, "Append", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_Append_ReadOnlySpan_d_Char_p_.SetBelong(this.instance);
				}
				return r_Append_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoin(System.String, System.Object[])
		/// </summary>
		protected RMethod r_AppendJoin_String_ObjectArray;
		public virtual RMethod RAppendJoin_String_ObjectArray
		{
			get
			{
				if(r_AppendJoin_String_ObjectArray == null)
				{
					r_AppendJoin_String_ObjectArray = new(this, "AppendJoin", 0, typeof(System.String), typeof(System.Object).MakeArrayType());
					r_AppendJoin_String_ObjectArray.SetBelong(this.instance);
				}
				return r_AppendJoin_String_ObjectArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoin[T](System.String, System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_AppendJoin_GT_String_IEnumerable_d_T_p_;
		public virtual RMethod RAppendJoin_GT_String_IEnumerable_d_T_p_
		{
			get
			{
				if(r_AppendJoin_GT_String_IEnumerable_d_T_p_ == null)
				{
					r_AppendJoin_GT_String_IEnumerable_d_T_p_ = new(this, "AppendJoin", 1, typeof(System.String), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_AppendJoin_GT_String_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_AppendJoin_GT_String_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoin(System.String, System.String[])
		/// </summary>
		protected RMethod r_AppendJoin_String_StringArray;
		public virtual RMethod RAppendJoin_String_StringArray
		{
			get
			{
				if(r_AppendJoin_String_StringArray == null)
				{
					r_AppendJoin_String_StringArray = new(this, "AppendJoin", 0, typeof(System.String), typeof(System.String).MakeArrayType());
					r_AppendJoin_String_StringArray.SetBelong(this.instance);
				}
				return r_AppendJoin_String_StringArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoin(Char, System.Object[])
		/// </summary>
		protected RMethod r_AppendJoin_Char_ObjectArray;
		public virtual RMethod RAppendJoin_Char_ObjectArray
		{
			get
			{
				if(r_AppendJoin_Char_ObjectArray == null)
				{
					r_AppendJoin_Char_ObjectArray = new(this, "AppendJoin", 0, typeof(System.Char), typeof(System.Object).MakeArrayType());
					r_AppendJoin_Char_ObjectArray.SetBelong(this.instance);
				}
				return r_AppendJoin_Char_ObjectArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoin[T](Char, System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_AppendJoin_GT_Char_IEnumerable_d_T_p_;
		public virtual RMethod RAppendJoin_GT_Char_IEnumerable_d_T_p_
		{
			get
			{
				if(r_AppendJoin_GT_Char_IEnumerable_d_T_p_ == null)
				{
					r_AppendJoin_GT_Char_IEnumerable_d_T_p_ = new(this, "AppendJoin", 1, typeof(System.Char), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_AppendJoin_GT_Char_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_AppendJoin_GT_Char_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoin(Char, System.String[])
		/// </summary>
		protected RMethod r_AppendJoin_Char_StringArray;
		public virtual RMethod RAppendJoin_Char_StringArray
		{
			get
			{
				if(r_AppendJoin_Char_StringArray == null)
				{
					r_AppendJoin_Char_StringArray = new(this, "AppendJoin", 0, typeof(System.Char), typeof(System.String).MakeArrayType());
					r_AppendJoin_Char_StringArray.SetBelong(this.instance);
				}
				return r_AppendJoin_Char_StringArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoinCore[T](Char*, Int32, System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_AppendJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_;
		public virtual RMethod RAppendJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_
		{
			get
			{
				if(r_AppendJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_ == null)
				{
					r_AppendJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_ = new(this, "AppendJoinCore", 1, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_AppendJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_.SetBelong(this.instance);
				}
				return r_AppendJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoinCore[T](Char*, Int32, T[])
		/// </summary>
		protected RMethod r_AppendJoinCore_GT_CharPointer_Int32_TArray;
		public virtual RMethod RAppendJoinCore_GT_CharPointer_Int32_TArray
		{
			get
			{
				if(r_AppendJoinCore_GT_CharPointer_Int32_TArray == null)
				{
					r_AppendJoinCore_GT_CharPointer_Int32_TArray = new(this, "AppendJoinCore", 1, typeof(System.Char).MakePointerType(), typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeArrayType());
					r_AppendJoinCore_GT_CharPointer_Int32_TArray.SetBelong(this.instance);
				}
				return r_AppendJoinCore_GT_CharPointer_Int32_TArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, System.String)
		/// </summary>
		protected RMethod r_Insert_Int32_String;
		public virtual RMethod RInsert_Int32_String
		{
			get
			{
				if(r_Insert_Int32_String == null)
				{
					r_Insert_Int32_String = new(this, "Insert", 0, typeof(System.Int32), typeof(System.String));
					r_Insert_Int32_String.SetBelong(this.instance);
				}
				return r_Insert_Int32_String;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Boolean)
		/// </summary>
		protected RMethod r_Insert_Int32_Boolean;
		public virtual RMethod RInsert_Int32_Boolean
		{
			get
			{
				if(r_Insert_Int32_Boolean == null)
				{
					r_Insert_Int32_Boolean = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Boolean));
					r_Insert_Int32_Boolean.SetBelong(this.instance);
				}
				return r_Insert_Int32_Boolean;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, SByte)
		/// </summary>
		protected RMethod r_Insert_Int32_SByte;
		public virtual RMethod RInsert_Int32_SByte
		{
			get
			{
				if(r_Insert_Int32_SByte == null)
				{
					r_Insert_Int32_SByte = new(this, "Insert", 0, typeof(System.Int32), typeof(System.SByte));
					r_Insert_Int32_SByte.SetBelong(this.instance);
				}
				return r_Insert_Int32_SByte;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Byte)
		/// </summary>
		protected RMethod r_Insert_Int32_Byte;
		public virtual RMethod RInsert_Int32_Byte
		{
			get
			{
				if(r_Insert_Int32_Byte == null)
				{
					r_Insert_Int32_Byte = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Byte));
					r_Insert_Int32_Byte.SetBelong(this.instance);
				}
				return r_Insert_Int32_Byte;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Int16)
		/// </summary>
		protected RMethod r_Insert_Int32_Int16;
		public virtual RMethod RInsert_Int32_Int16
		{
			get
			{
				if(r_Insert_Int32_Int16 == null)
				{
					r_Insert_Int32_Int16 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Int16));
					r_Insert_Int32_Int16.SetBelong(this.instance);
				}
				return r_Insert_Int32_Int16;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Char)
		/// </summary>
		protected RMethod r_Insert_Int32_Char;
		public virtual RMethod RInsert_Int32_Char
		{
			get
			{
				if(r_Insert_Int32_Char == null)
				{
					r_Insert_Int32_Char = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Char));
					r_Insert_Int32_Char.SetBelong(this.instance);
				}
				return r_Insert_Int32_Char;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Char[])
		/// </summary>
		protected RMethod r_Insert_Int32_CharArray;
		public virtual RMethod RInsert_Int32_CharArray
		{
			get
			{
				if(r_Insert_Int32_CharArray == null)
				{
					r_Insert_Int32_CharArray = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Char).MakeArrayType());
					r_Insert_Int32_CharArray.SetBelong(this.instance);
				}
				return r_Insert_Int32_CharArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_Insert_Int32_CharArray_Int32_Int32;
		public virtual RMethod RInsert_Int32_CharArray_Int32_Int32
		{
			get
			{
				if(r_Insert_Int32_CharArray_Int32_Int32 == null)
				{
					r_Insert_Int32_CharArray_Int32_Int32 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_Insert_Int32_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_Insert_Int32_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Int32)
		/// </summary>
		protected RMethod r_Insert_Int32_Int32;
		public virtual RMethod RInsert_Int32_Int32
		{
			get
			{
				if(r_Insert_Int32_Int32 == null)
				{
					r_Insert_Int32_Int32 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Int32));
					r_Insert_Int32_Int32.SetBelong(this.instance);
				}
				return r_Insert_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Int64)
		/// </summary>
		protected RMethod r_Insert_Int32_Int64;
		public virtual RMethod RInsert_Int32_Int64
		{
			get
			{
				if(r_Insert_Int32_Int64 == null)
				{
					r_Insert_Int32_Int64 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Int64));
					r_Insert_Int32_Int64.SetBelong(this.instance);
				}
				return r_Insert_Int32_Int64;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Single)
		/// </summary>
		protected RMethod r_Insert_Int32_Single;
		public virtual RMethod RInsert_Int32_Single
		{
			get
			{
				if(r_Insert_Int32_Single == null)
				{
					r_Insert_Int32_Single = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Single));
					r_Insert_Int32_Single.SetBelong(this.instance);
				}
				return r_Insert_Int32_Single;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Double)
		/// </summary>
		protected RMethod r_Insert_Int32_Double;
		public virtual RMethod RInsert_Int32_Double
		{
			get
			{
				if(r_Insert_Int32_Double == null)
				{
					r_Insert_Int32_Double = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Double));
					r_Insert_Int32_Double.SetBelong(this.instance);
				}
				return r_Insert_Int32_Double;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, System.Decimal)
		/// </summary>
		protected RMethod r_Insert_Int32_Decimal;
		public virtual RMethod RInsert_Int32_Decimal
		{
			get
			{
				if(r_Insert_Int32_Decimal == null)
				{
					r_Insert_Int32_Decimal = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Decimal));
					r_Insert_Int32_Decimal.SetBelong(this.instance);
				}
				return r_Insert_Int32_Decimal;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, UInt16)
		/// </summary>
		protected RMethod r_Insert_Int32_UInt16;
		public virtual RMethod RInsert_Int32_UInt16
		{
			get
			{
				if(r_Insert_Int32_UInt16 == null)
				{
					r_Insert_Int32_UInt16 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.UInt16));
					r_Insert_Int32_UInt16.SetBelong(this.instance);
				}
				return r_Insert_Int32_UInt16;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, UInt32)
		/// </summary>
		protected RMethod r_Insert_Int32_UInt32;
		public virtual RMethod RInsert_Int32_UInt32
		{
			get
			{
				if(r_Insert_Int32_UInt32 == null)
				{
					r_Insert_Int32_UInt32 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.UInt32));
					r_Insert_Int32_UInt32.SetBelong(this.instance);
				}
				return r_Insert_Int32_UInt32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, UInt64)
		/// </summary>
		protected RMethod r_Insert_Int32_UInt64;
		public virtual RMethod RInsert_Int32_UInt64
		{
			get
			{
				if(r_Insert_Int32_UInt64 == null)
				{
					r_Insert_Int32_UInt64 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.UInt64));
					r_Insert_Int32_UInt64.SetBelong(this.instance);
				}
				return r_Insert_Int32_UInt64;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, System.Object)
		/// </summary>
		protected RMethod r_Insert_Int32_Object;
		public virtual RMethod RInsert_Int32_Object
		{
			get
			{
				if(r_Insert_Int32_Object == null)
				{
					r_Insert_Int32_Object = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Object));
					r_Insert_Int32_Object.SetBelong(this.instance);
				}
				return r_Insert_Int32_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_Insert_Int32_ReadOnlySpan_d_Char_p_;
		public virtual RMethod RInsert_Int32_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_Insert_Int32_ReadOnlySpan_d_Char_p_ == null)
				{
					r_Insert_Int32_ReadOnlySpan_d_Char_p_ = new(this, "Insert", 0, typeof(System.Int32), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_Insert_Int32_ReadOnlySpan_d_Char_p_.SetBelong(this.instance);
				}
				return r_Insert_Int32_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.String, System.Object)
		/// </summary>
		protected RMethod r_AppendFormat_String_Object;
		public virtual RMethod RAppendFormat_String_Object
		{
			get
			{
				if(r_AppendFormat_String_Object == null)
				{
					r_AppendFormat_String_Object = new(this, "AppendFormat", 0, typeof(System.String), typeof(System.Object));
					r_AppendFormat_String_Object.SetBelong(this.instance);
				}
				return r_AppendFormat_String_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.String, System.Object, System.Object)
		/// </summary>
		protected RMethod r_AppendFormat_String_Object_Object;
		public virtual RMethod RAppendFormat_String_Object_Object
		{
			get
			{
				if(r_AppendFormat_String_Object_Object == null)
				{
					r_AppendFormat_String_Object_Object = new(this, "AppendFormat", 0, typeof(System.String), typeof(System.Object), typeof(System.Object));
					r_AppendFormat_String_Object_Object.SetBelong(this.instance);
				}
				return r_AppendFormat_String_Object_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.String, System.Object, System.Object, System.Object)
		/// </summary>
		protected RMethod r_AppendFormat_String_Object_Object_Object;
		public virtual RMethod RAppendFormat_String_Object_Object_Object
		{
			get
			{
				if(r_AppendFormat_String_Object_Object_Object == null)
				{
					r_AppendFormat_String_Object_Object_Object = new(this, "AppendFormat", 0, typeof(System.String), typeof(System.Object), typeof(System.Object), typeof(System.Object));
					r_AppendFormat_String_Object_Object_Object.SetBelong(this.instance);
				}
				return r_AppendFormat_String_Object_Object_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.String, System.Object[])
		/// </summary>
		protected RMethod r_AppendFormat_String_ObjectArray;
		public virtual RMethod RAppendFormat_String_ObjectArray
		{
			get
			{
				if(r_AppendFormat_String_ObjectArray == null)
				{
					r_AppendFormat_String_ObjectArray = new(this, "AppendFormat", 0, typeof(System.String), typeof(System.Object).MakeArrayType());
					r_AppendFormat_String_ObjectArray.SetBelong(this.instance);
				}
				return r_AppendFormat_String_ObjectArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.IFormatProvider, System.String, System.Object)
		/// </summary>
		protected RMethod r_AppendFormat_IFormatProvider_String_Object;
		public virtual RMethod RAppendFormat_IFormatProvider_String_Object
		{
			get
			{
				if(r_AppendFormat_IFormatProvider_String_Object == null)
				{
					r_AppendFormat_IFormatProvider_String_Object = new(this, "AppendFormat", 0, typeof(System.IFormatProvider), typeof(System.String), typeof(System.Object));
					r_AppendFormat_IFormatProvider_String_Object.SetBelong(this.instance);
				}
				return r_AppendFormat_IFormatProvider_String_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.IFormatProvider, System.String, System.Object, System.Object)
		/// </summary>
		protected RMethod r_AppendFormat_IFormatProvider_String_Object_Object;
		public virtual RMethod RAppendFormat_IFormatProvider_String_Object_Object
		{
			get
			{
				if(r_AppendFormat_IFormatProvider_String_Object_Object == null)
				{
					r_AppendFormat_IFormatProvider_String_Object_Object = new(this, "AppendFormat", 0, typeof(System.IFormatProvider), typeof(System.String), typeof(System.Object), typeof(System.Object));
					r_AppendFormat_IFormatProvider_String_Object_Object.SetBelong(this.instance);
				}
				return r_AppendFormat_IFormatProvider_String_Object_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.IFormatProvider, System.String, System.Object, System.Object, System.Object)
		/// </summary>
		protected RMethod r_AppendFormat_IFormatProvider_String_Object_Object_Object;
		public virtual RMethod RAppendFormat_IFormatProvider_String_Object_Object_Object
		{
			get
			{
				if(r_AppendFormat_IFormatProvider_String_Object_Object_Object == null)
				{
					r_AppendFormat_IFormatProvider_String_Object_Object_Object = new(this, "AppendFormat", 0, typeof(System.IFormatProvider), typeof(System.String), typeof(System.Object), typeof(System.Object), typeof(System.Object));
					r_AppendFormat_IFormatProvider_String_Object_Object_Object.SetBelong(this.instance);
				}
				return r_AppendFormat_IFormatProvider_String_Object_Object_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.IFormatProvider, System.String, System.Object[])
		/// </summary>
		protected RMethod r_AppendFormat_IFormatProvider_String_ObjectArray;
		public virtual RMethod RAppendFormat_IFormatProvider_String_ObjectArray
		{
			get
			{
				if(r_AppendFormat_IFormatProvider_String_ObjectArray == null)
				{
					r_AppendFormat_IFormatProvider_String_ObjectArray = new(this, "AppendFormat", 0, typeof(System.IFormatProvider), typeof(System.String), typeof(System.Object).MakeArrayType());
					r_AppendFormat_IFormatProvider_String_ObjectArray.SetBelong(this.instance);
				}
				return r_AppendFormat_IFormatProvider_String_ObjectArray;
			}
		}

		/// <summary>
		/// Void FormatError()
		/// </summary>
		protected static RMethod r_FormatError;
		public static RMethod RFormatError
		{
			get
			{
				if(r_FormatError == null)
				{
					r_FormatError = new(typeof(System.Text.StringBuilder), "FormatError", 0);
					r_FormatError.SetBelong(null);
				}
				return r_FormatError;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
		/// </summary>
		protected RMethod r_AppendFormatHelper_IFormatProvider_String_ParamsArray;
		public virtual RMethod RAppendFormatHelper_IFormatProvider_String_ParamsArray
		{
			get
			{
				if(r_AppendFormatHelper_IFormatProvider_String_ParamsArray == null)
				{
					r_AppendFormatHelper_IFormatProvider_String_ParamsArray = new(this, "AppendFormatHelper", 0, typeof(System.IFormatProvider), typeof(System.String),  ReflectionUtils.GetType("System.ParamsArray"));
					r_AppendFormatHelper_IFormatProvider_String_ParamsArray.SetBelong(this.instance);
				}
				return r_AppendFormatHelper_IFormatProvider_String_ParamsArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Replace(System.String, System.String)
		/// </summary>
		protected RMethod r_Replace_String_String;
		public virtual RMethod RReplace_String_String
		{
			get
			{
				if(r_Replace_String_String == null)
				{
					r_Replace_String_String = new(this, "Replace", 0, typeof(System.String), typeof(System.String));
					r_Replace_String_String.SetBelong(this.instance);
				}
				return r_Replace_String_String;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_Equals_StringBuilder;
		public virtual RMethod REquals_StringBuilder
		{
			get
			{
				if(r_Equals_StringBuilder == null)
				{
					r_Equals_StringBuilder = new(this, "Equals", 0, typeof(System.Text.StringBuilder));
					r_Equals_StringBuilder.SetBelong(this.instance);
				}
				return r_Equals_StringBuilder;
			}
		}

		/// <summary>
		/// Boolean Equals(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_Equals_ReadOnlySpan_d_Char_p_;
		public virtual RMethod REquals_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_Equals_ReadOnlySpan_d_Char_p_ == null)
				{
					r_Equals_ReadOnlySpan_d_Char_p_ = new(this, "Equals", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_Equals_ReadOnlySpan_d_Char_p_.SetBelong(this.instance);
				}
				return r_Equals_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Replace(System.String, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_Replace_String_String_Int32_Int32;
		public virtual RMethod RReplace_String_String_Int32_Int32
		{
			get
			{
				if(r_Replace_String_String_Int32_Int32 == null)
				{
					r_Replace_String_String_Int32_Int32 = new(this, "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_Replace_String_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_Replace_String_String_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Replace(Char, Char)
		/// </summary>
		protected RMethod r_Replace_Char_Char;
		public virtual RMethod RReplace_Char_Char
		{
			get
			{
				if(r_Replace_Char_Char == null)
				{
					r_Replace_Char_Char = new(this, "Replace", 0, typeof(System.Char), typeof(System.Char));
					r_Replace_Char_Char.SetBelong(this.instance);
				}
				return r_Replace_Char_Char;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Replace(Char, Char, Int32, Int32)
		/// </summary>
		protected RMethod r_Replace_Char_Char_Int32_Int32;
		public virtual RMethod RReplace_Char_Char_Int32_Int32
		{
			get
			{
				if(r_Replace_Char_Char_Int32_Int32 == null)
				{
					r_Replace_Char_Char_Int32_Int32 = new(this, "Replace", 0, typeof(System.Char), typeof(System.Char), typeof(System.Int32), typeof(System.Int32));
					r_Replace_Char_Char_Int32_Int32.SetBelong(this.instance);
				}
				return r_Replace_Char_Char_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Char*, Int32)
		/// </summary>
		protected RMethod r_Append_CharPointer_Int32;
		public virtual RMethod RAppend_CharPointer_Int32
		{
			get
			{
				if(r_Append_CharPointer_Int32 == null)
				{
					r_Append_CharPointer_Int32 = new(this, "Append", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_Append_CharPointer_Int32.SetBelong(this.instance);
				}
				return r_Append_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Void Insert(Int32, Char*, Int32)
		/// </summary>
		protected RMethod r_Insert_Int32_CharPointer_Int32;
		public virtual RMethod RInsert_Int32_CharPointer_Int32
		{
			get
			{
				if(r_Insert_Int32_CharPointer_Int32 == null)
				{
					r_Insert_Int32_CharPointer_Int32 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_Insert_Int32_CharPointer_Int32.SetBelong(this.instance);
				}
				return r_Insert_Int32_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Void ReplaceAllInChunk(Int32[], Int32, System.Text.StringBuilder, Int32, System.String)
		/// </summary>
		protected RMethod r_ReplaceAllInChunk_Int32Array_Int32_StringBuilder_Int32_String;
		public virtual RMethod RReplaceAllInChunk_Int32Array_Int32_StringBuilder_Int32_String
		{
			get
			{
				if(r_ReplaceAllInChunk_Int32Array_Int32_StringBuilder_Int32_String == null)
				{
					r_ReplaceAllInChunk_Int32Array_Int32_StringBuilder_Int32_String = new(this, "ReplaceAllInChunk", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32), typeof(System.Text.StringBuilder), typeof(System.Int32), typeof(System.String));
					r_ReplaceAllInChunk_Int32Array_Int32_StringBuilder_Int32_String.SetBelong(this.instance);
				}
				return r_ReplaceAllInChunk_Int32Array_Int32_StringBuilder_Int32_String;
			}
		}

		/// <summary>
		/// Boolean StartsWith(System.Text.StringBuilder, Int32, Int32, System.String)
		/// </summary>
		protected RMethod r_StartsWith_StringBuilder_Int32_Int32_String;
		public virtual RMethod RStartsWith_StringBuilder_Int32_Int32_String
		{
			get
			{
				if(r_StartsWith_StringBuilder_Int32_Int32_String == null)
				{
					r_StartsWith_StringBuilder_Int32_Int32_String = new(this, "StartsWith", 0, typeof(System.Text.StringBuilder), typeof(System.Int32), typeof(System.Int32), typeof(System.String));
					r_StartsWith_StringBuilder_Int32_Int32_String.SetBelong(this.instance);
				}
				return r_StartsWith_StringBuilder_Int32_Int32_String;
			}
		}

		/// <summary>
		/// Void ReplaceInPlaceAtChunk(System.Text.StringBuilder ByRef, Int32 ByRef, Char*, Int32)
		/// </summary>
		protected RMethod r_ReplaceInPlaceAtChunk_Ref_StringBuilder_Ref_Int32_CharPointer_Int32;
		public virtual RMethod RReplaceInPlaceAtChunk_Ref_StringBuilder_Ref_Int32_CharPointer_Int32
		{
			get
			{
				if(r_ReplaceInPlaceAtChunk_Ref_StringBuilder_Ref_Int32_CharPointer_Int32 == null)
				{
					r_ReplaceInPlaceAtChunk_Ref_StringBuilder_Ref_Int32_CharPointer_Int32 = new(this, "ReplaceInPlaceAtChunk", 0, typeof(System.Text.StringBuilder).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_ReplaceInPlaceAtChunk_Ref_StringBuilder_Ref_Int32_CharPointer_Int32.SetBelong(this.instance);
				}
				return r_ReplaceInPlaceAtChunk_Ref_StringBuilder_Ref_Int32_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Void ThreadSafeCopy(Char*, Char[], Int32, Int32)
		/// </summary>
		protected static RMethod r_ThreadSafeCopy_CharPointer_CharArray_Int32_Int32;
		public static RMethod RThreadSafeCopy_CharPointer_CharArray_Int32_Int32
		{
			get
			{
				if(r_ThreadSafeCopy_CharPointer_CharArray_Int32_Int32 == null)
				{
					r_ThreadSafeCopy_CharPointer_CharArray_Int32_Int32 = new(typeof(System.Text.StringBuilder), "ThreadSafeCopy", 0, typeof(System.Char).MakePointerType(), typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_ThreadSafeCopy_CharPointer_CharArray_Int32_Int32.SetBelong(null);
				}
				return r_ThreadSafeCopy_CharPointer_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ThreadSafeCopy(Char[], Int32, System.Span`1[System.Char], Int32, Int32)
		/// </summary>
		protected static RMethod r_ThreadSafeCopy_CharArray_Int32_Span_d_Char_p__Int32_Int32;
		public static RMethod RThreadSafeCopy_CharArray_Int32_Span_d_Char_p__Int32_Int32
		{
			get
			{
				if(r_ThreadSafeCopy_CharArray_Int32_Span_d_Char_p__Int32_Int32 == null)
				{
					r_ThreadSafeCopy_CharArray_Int32_Span_d_Char_p__Int32_Int32 = new(typeof(System.Text.StringBuilder), "ThreadSafeCopy", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32), typeof(System.Int32));
					r_ThreadSafeCopy_CharArray_Int32_Span_d_Char_p__Int32_Int32.SetBelong(null);
				}
				return r_ThreadSafeCopy_CharArray_Int32_Span_d_Char_p__Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder FindChunkForIndex(Int32)
		/// </summary>
		protected RMethod r_FindChunkForIndex_Int32;
		public virtual RMethod RFindChunkForIndex_Int32
		{
			get
			{
				if(r_FindChunkForIndex_Int32 == null)
				{
					r_FindChunkForIndex_Int32 = new(this, "FindChunkForIndex", 0, typeof(System.Int32));
					r_FindChunkForIndex_Int32.SetBelong(this.instance);
				}
				return r_FindChunkForIndex_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder FindChunkForByte(Int32)
		/// </summary>
		protected RMethod r_FindChunkForByte_Int32;
		public virtual RMethod RFindChunkForByte_Int32
		{
			get
			{
				if(r_FindChunkForByte_Int32 == null)
				{
					r_FindChunkForByte_Int32 = new(this, "FindChunkForByte", 0, typeof(System.Int32));
					r_FindChunkForByte_Int32.SetBelong(this.instance);
				}
				return r_FindChunkForByte_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Next(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_Next_StringBuilder;
		public virtual RMethod RNext_StringBuilder
		{
			get
			{
				if(r_Next_StringBuilder == null)
				{
					r_Next_StringBuilder = new(this, "Next", 0, typeof(System.Text.StringBuilder));
					r_Next_StringBuilder.SetBelong(this.instance);
				}
				return r_Next_StringBuilder;
			}
		}

		/// <summary>
		/// Void ExpandByABlock(Int32)
		/// </summary>
		protected RMethod r_ExpandByABlock_Int32;
		public virtual RMethod RExpandByABlock_Int32
		{
			get
			{
				if(r_ExpandByABlock_Int32 == null)
				{
					r_ExpandByABlock_Int32 = new(this, "ExpandByABlock", 0, typeof(System.Int32));
					r_ExpandByABlock_Int32.SetBelong(this.instance);
				}
				return r_ExpandByABlock_Int32;
			}
		}

		/// <summary>
		/// Void MakeRoom(Int32, Int32, System.Text.StringBuilder ByRef, Int32 ByRef, Boolean)
		/// </summary>
		protected RMethod r_MakeRoom_Int32_Int32_Out_StringBuilder_Out_Int32_Boolean;
		public virtual RMethod RMakeRoom_Int32_Int32_Out_StringBuilder_Out_Int32_Boolean
		{
			get
			{
				if(r_MakeRoom_Int32_Int32_Out_StringBuilder_Out_Int32_Boolean == null)
				{
					r_MakeRoom_Int32_Int32_Out_StringBuilder_Out_Int32_Boolean = new(this, "MakeRoom", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Text.StringBuilder).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
					r_MakeRoom_Int32_Int32_Out_StringBuilder_Out_Int32_Boolean.SetBelong(this.instance);
				}
				return r_MakeRoom_Int32_Int32_Out_StringBuilder_Out_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void Remove(Int32, Int32, System.Text.StringBuilder ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_Remove_Int32_Int32_Out_StringBuilder_Out_Int32;
		public virtual RMethod RRemove_Int32_Int32_Out_StringBuilder_Out_Int32
		{
			get
			{
				if(r_Remove_Int32_Int32_Out_StringBuilder_Out_Int32 == null)
				{
					r_Remove_Int32_Int32_Out_StringBuilder_Out_Int32 = new(this, "Remove", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Text.StringBuilder).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_Remove_Int32_Int32_Out_StringBuilder_Out_Int32.SetBelong(this.instance);
				}
				return r_Remove_Int32_Int32_Out_StringBuilder_Out_Int32;
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

        public virtual void System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AssertInvariants()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAssertInvariants.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 EnsureCapacity(System.Int32 @capacity)
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


        public virtual System.String ToString(System.Int32 @startIndex, System.Int32 @length)
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


        public virtual System.Text.StringBuilder Append(System.Char @value, System.Int32 @repeatCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @repeatCount};
            var ___result = RAppend_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Char[] @value, System.Int32 @startIndex, System.Int32 @charCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @charCount};
            var ___result = RAppend_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_String.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual void AppendHelper(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppendHelper_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Text.StringBuilder Append(System.String @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RAppend_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Text.StringBuilder @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Text.StringBuilder @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RAppend_StringBuilder_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendCore(System.Text.StringBuilder @value, System.Int32 @startIndex, System.Int32 @count)
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


        public virtual System.Text.StringBuilder AppendLine(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppendLine_String.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual void CopyTo(System.Int32 @sourceIndex, System.Char[] @destination, System.Int32 @destinationIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceIndex, @destination, @destinationIndex, @count};
            var ___result = RCopyTo_Int32_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Int32 @sourceIndex, RSystem.RSpan<RSystem.RChar> @destination, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceIndex, @destination.Value, @count};
            var ___result = RCopyTo_Int32_Span_d_Char_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.String @value, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value, @count};
            var ___result = RInsert_Int32_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Remove(System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @length};
            var ___result = RRemove_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_Char.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.SByte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_SByte.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Byte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_Byte.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Int16 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_Int16.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Int64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_Int64.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_Single.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_Double.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Decimal @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.UInt16 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_UInt16.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.UInt32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.UInt64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_UInt64.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendSpanFormattable<T>(T @value) where T : System.IFormattable
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@value};
            var ___result = RAppendSpanFormattable_GT_T.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Char[] @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAppend_CharArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(RSystem.RReadOnlySpan<RSystem.RChar> @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RAppend_ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendJoin(System.String @separator, System.Object[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RAppendJoin_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendJoin<T>(System.String @separator, System.Collections.Generic.IEnumerable<T> @values)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RAppendJoin_GT_String_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendJoin(System.String @separator, System.String[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RAppendJoin_String_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendJoin(System.Char @separator, System.Object[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RAppendJoin_Char_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendJoin<T>(System.Char @separator, System.Collections.Generic.IEnumerable<T> @values)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RAppendJoin_GT_Char_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendJoin(System.Char @separator, System.String[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RAppendJoin_Char_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public unsafe virtual System.Text.StringBuilder AppendJoinCore<T>(System.Char* @separator, System.Int32 @separatorLength, System.Collections.Generic.IEnumerable<T> @values)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{Pointer.Box(@separator, typeof(System.Char)), @separatorLength, @values};
            var ___result = RAppendJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public unsafe virtual System.Text.StringBuilder AppendJoinCore<T>(System.Char* @separator, System.Int32 @separatorLength, T[] @values)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{Pointer.Box(@separator, typeof(System.Char)), @separatorLength, @values};
            var ___result = RAppendJoinCore_GT_CharPointer_Int32_TArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_String.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.SByte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_SByte.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Byte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_Byte.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Int16 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_Int16.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_Char.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Char[] @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_CharArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Char[] @value, System.Int32 @startIndex, System.Int32 @charCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value, @startIndex, @charCount};
            var ___result = RInsert_Int32_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Int64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_Int64.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_Single.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_Double.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Decimal @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.UInt16 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_UInt16.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.UInt32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.UInt64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_UInt64.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RInsert_Int32_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, RSystem.RReadOnlySpan<RSystem.RChar> @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value.Value};
            var ___result = RInsert_Int32_ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.String @format, System.Object @arg0)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg0};
            var ___result = RAppendFormat_String_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.String @format, System.Object @arg0, System.Object @arg1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg0, @arg1};
            var ___result = RAppendFormat_String_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.String @format, System.Object @arg0, System.Object @arg1, System.Object @arg2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg0, @arg1, @arg2};
            var ___result = RAppendFormat_String_Object_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.String @format, System.Object[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @args};
            var ___result = RAppendFormat_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.IFormatProvider @provider, System.String @format, System.Object @arg0)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @arg0};
            var ___result = RAppendFormat_IFormatProvider_String_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.IFormatProvider @provider, System.String @format, System.Object @arg0, System.Object @arg1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @arg0, @arg1};
            var ___result = RAppendFormat_IFormatProvider_String_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.IFormatProvider @provider, System.String @format, System.Object @arg0, System.Object @arg1, System.Object @arg2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @arg0, @arg1, @arg2};
            var ___result = RAppendFormat_IFormatProvider_String_Object_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.IFormatProvider @provider, System.String @format, System.Object[] @args)
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


        public virtual System.Text.StringBuilder AppendFormatHelper(System.IFormatProvider @provider, System.String @format, RSystem.RParamsArray @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @args.Value};
            var ___result = RAppendFormatHelper_IFormatProvider_String_ParamsArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Replace(System.String @oldValue, System.String @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = RReplace_String_String.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Boolean Equals(System.Text.StringBuilder @sb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sb};
            var ___result = REquals_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(RSystem.RReadOnlySpan<RSystem.RChar> @span)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@span.Value};
            var ___result = REquals_ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Text.StringBuilder Replace(System.String @oldValue, System.String @newValue, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue, @startIndex, @count};
            var ___result = RReplace_String_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Replace(System.Char @oldChar, System.Char @newChar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldChar, @newChar};
            var ___result = RReplace_Char_Char.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Replace(System.Char @oldChar, System.Char @newChar, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldChar, @newChar, @startIndex, @count};
            var ___result = RReplace_Char_Char_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public unsafe virtual System.Text.StringBuilder Append(System.Char* @value, System.Int32 @valueCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(System.Char)), @valueCount};
            var ___result = RAppend_CharPointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public unsafe virtual void Insert(System.Int32 @index, System.Char* @value, System.Int32 @valueCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, Pointer.Box(@value, typeof(System.Char)), @valueCount};
            var ___result = RInsert_Int32_CharPointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReplaceAllInChunk(System.Int32[] @replacements, System.Int32 @replacementsCount, System.Text.StringBuilder @sourceChunk, System.Int32 @removeCount, System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@replacements, @replacementsCount, @sourceChunk, @removeCount, @value};
            var ___result = RReplaceAllInChunk_Int32Array_Int32_StringBuilder_Int32_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean StartsWith(System.Text.StringBuilder @chunk, System.Int32 @indexInChunk, System.Int32 @count, System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chunk, @indexInChunk, @count, @value};
            var ___result = RStartsWith_StringBuilder_Int32_Int32_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public unsafe virtual void ReplaceInPlaceAtChunk(ref System.Text.StringBuilder @chunk, ref System.Int32 @indexInChunk, System.Char* @value, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chunk, @indexInChunk, Pointer.Box(@value, typeof(System.Char)), @count};
            var ___result = RReplaceInPlaceAtChunk_Ref_StringBuilder_Ref_Int32_CharPointer_Int32.Invoke(___genericsType, ___parameters);
			@chunk = (System.Text.StringBuilder)___parameters[0];
			@indexInChunk = (System.Int32)___parameters[1];

            
        }


        public unsafe static void ThreadSafeCopy(System.Char* @sourcePtr, System.Char[] @destination, System.Int32 @destinationIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@sourcePtr, typeof(System.Char)), @destination, @destinationIndex, @count};
            var ___result = RThreadSafeCopy_CharPointer_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void ThreadSafeCopy(System.Char[] @source, System.Int32 @sourceIndex, RSystem.RSpan<RSystem.RChar> @destination, System.Int32 @destinationIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @sourceIndex, @destination.Value, @destinationIndex, @count};
            var ___result = RThreadSafeCopy_CharArray_Int32_Span_d_Char_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Text.StringBuilder FindChunkForIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RFindChunkForIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder FindChunkForByte(System.Int32 @byteIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@byteIndex};
            var ___result = RFindChunkForByte_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Next(System.Text.StringBuilder @chunk)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chunk};
            var ___result = RNext_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual void ExpandByABlock(System.Int32 @minBlockCharCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@minBlockCharCount};
            var ___result = RExpandByABlock_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MakeRoom(System.Int32 @index, System.Int32 @count, out System.Text.StringBuilder @chunk, out System.Int32 @indexInChunk, System.Boolean @doNotMoveFollowingChars)
        {
			@chunk = default;
			@indexInChunk = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count, @chunk, @indexInChunk, @doNotMoveFollowingChars};
            var ___result = RMakeRoom_Int32_Int32_Out_StringBuilder_Out_Int32_Boolean.Invoke(___genericsType, ___parameters);
			@chunk = (System.Text.StringBuilder)___parameters[2];
			@indexInChunk = (System.Int32)___parameters[3];

            
        }


        public virtual void Remove(System.Int32 @startIndex, System.Int32 @count, out System.Text.StringBuilder @chunk, out System.Int32 @indexInChunk)
        {
			@chunk = default;
			@indexInChunk = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @count, @chunk, @indexInChunk};
            var ___result = RRemove_Int32_Int32_Out_StringBuilder_Out_Int32.Invoke(___genericsType, ___parameters);
			@chunk = (System.Text.StringBuilder)___parameters[2];
			@indexInChunk = (System.Int32)___parameters[3];

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
