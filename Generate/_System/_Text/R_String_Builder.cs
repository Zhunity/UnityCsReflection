
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RText
{
	/// <summary>
	/// System.Text.StringBuilder
	/// </summary>
    public partial class RStringBuilder : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Text.StringBuilder);
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


		/// <summary>
		/// System.Char[] m_ChunkChars
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RChar> r_Fm_ChunkChars;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RChar> RFm_ChunkChars
		{
			get
			{
				if(r_Fm_ChunkChars == null)
				{
					r_Fm_ChunkChars = new(this, "m_ChunkChars");
				}
				return r_Fm_ChunkChars;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder m_ChunkPrevious
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RText.RStringBuilder r_Fm_ChunkPrevious;
		public virtual Hvak.Editor.Refleaction.RSystem.RText.RStringBuilder RFm_ChunkPrevious
		{
			get
			{
				if(r_Fm_ChunkPrevious == null)
				{
					r_Fm_ChunkPrevious = new(this, "m_ChunkPrevious");
				}
				return r_Fm_ChunkPrevious;
			}
		}

		/// <summary>
		/// System.Int32 m_ChunkLength
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_ChunkLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_ChunkLength
		{
			get
			{
				if(r_Fm_ChunkLength == null)
				{
					r_Fm_ChunkLength = new(this, "m_ChunkLength");
				}
				return r_Fm_ChunkLength;
			}
		}

		/// <summary>
		/// System.Int32 m_ChunkOffset
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_ChunkOffset;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_ChunkOffset
		{
			get
			{
				if(r_Fm_ChunkOffset == null)
				{
					r_Fm_ChunkOffset = new(this, "m_ChunkOffset");
				}
				return r_Fm_ChunkOffset;
			}
		}

		/// <summary>
		/// System.Int32 m_MaxCapacity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_MaxCapacity;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_MaxCapacity
		{
			get
			{
				if(r_Fm_MaxCapacity == null)
				{
					r_Fm_MaxCapacity = new(this, "m_MaxCapacity");
				}
				return r_Fm_MaxCapacity;
			}
		}

		/// <summary>
		/// System.Int32 DefaultCapacity
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FDefaultCapacity;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFDefaultCapacity
		{
			get
			{
				if(r_FDefaultCapacity == null)
				{
					r_FDefaultCapacity = new(typeof(System.Text.StringBuilder), "DefaultCapacity");
				}
				return r_FDefaultCapacity;
			}
		}

		/// <summary>
		/// System.String CapacityField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FCapacityField;
		public static Hvak.Editor.Refleaction.RSystem.RString RFCapacityField
		{
			get
			{
				if(r_FCapacityField == null)
				{
					r_FCapacityField = new(typeof(System.Text.StringBuilder), "CapacityField");
				}
				return r_FCapacityField;
			}
		}

		/// <summary>
		/// System.String MaxCapacityField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FMaxCapacityField;
		public static Hvak.Editor.Refleaction.RSystem.RString RFMaxCapacityField
		{
			get
			{
				if(r_FMaxCapacityField == null)
				{
					r_FMaxCapacityField = new(typeof(System.Text.StringBuilder), "MaxCapacityField");
				}
				return r_FMaxCapacityField;
			}
		}

		/// <summary>
		/// System.String StringValueField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FStringValueField;
		public static Hvak.Editor.Refleaction.RSystem.RString RFStringValueField
		{
			get
			{
				if(r_FStringValueField == null)
				{
					r_FStringValueField = new(typeof(System.Text.StringBuilder), "StringValueField");
				}
				return r_FStringValueField;
			}
		}

		/// <summary>
		/// System.String ThreadIDField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FThreadIDField;
		public static Hvak.Editor.Refleaction.RSystem.RString RFThreadIDField
		{
			get
			{
				if(r_FThreadIDField == null)
				{
					r_FThreadIDField = new(typeof(System.Text.StringBuilder), "ThreadIDField");
				}
				return r_FThreadIDField;
			}
		}

		/// <summary>
		/// System.Int32 MaxChunkSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FMaxChunkSize;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFMaxChunkSize
		{
			get
			{
				if(r_FMaxChunkSize == null)
				{
					r_FMaxChunkSize = new(typeof(System.Text.StringBuilder), "MaxChunkSize");
				}
				return r_FMaxChunkSize;
			}
		}

		/// <summary>
		/// System.Int32 IndexLimit
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FIndexLimit;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFIndexLimit
		{
			get
			{
				if(r_FIndexLimit == null)
				{
					r_FIndexLimit = new(typeof(System.Text.StringBuilder), "IndexLimit");
				}
				return r_FIndexLimit;
			}
		}

		/// <summary>
		/// System.Int32 WidthLimit
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FWidthLimit;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFWidthLimit
		{
			get
			{
				if(r_FWidthLimit == null)
				{
					r_FWidthLimit = new(typeof(System.Text.StringBuilder), "WidthLimit");
				}
				return r_FWidthLimit;
			}
		}

		/// <summary>
		/// Int32 Capacity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PCapacity;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPCapacity
		{
			get
			{
				if(r_PCapacity == null)
				{
					r_PCapacity = new(this, "Capacity", -1);
				}
				return r_PCapacity;
			}
		}

		/// <summary>
		/// Int32 MaxCapacity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PMaxCapacity;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPMaxCapacity
		{
			get
			{
				if(r_PMaxCapacity == null)
				{
					r_PMaxCapacity = new(this, "MaxCapacity", -1);
				}
				return r_PMaxCapacity;
			}
		}

		/// <summary>
		/// Int32 Length
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PLength;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPLength
		{
			get
			{
				if(r_PLength == null)
				{
					r_PLength = new(this, "Length", -1);
				}
				return r_PLength;
			}
		}

		/// <summary>
		/// Char Chars [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RChar r_PChars_Int32;
		public virtual Hvak.Editor.Refleaction.RSystem.RChar RPChars_Int32
		{
			get
			{
				if(r_PChars_Int32 == null)
				{
					r_PChars_Int32 = new(this, "Chars", -1, typeof(System.Int32));
				}
				return r_PChars_Int32;
			}
		}

		/// <summary>
		/// System.Span`1[System.Char] RemainingCurrentChunk
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RSystem.RChar> r_PRemainingCurrentChunk;
		public virtual Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RSystem.RChar> RPRemainingCurrentChunk
		{
			get
			{
				if(r_PRemainingCurrentChunk == null)
				{
					r_PRemainingCurrentChunk = new(this, "RemainingCurrentChunk", -1);
				}
				return r_PRemainingCurrentChunk;
			}
		}

		/// <summary>
		/// Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RMSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext = new(this, "System.Runtime.Serialization.ISerializable.GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
				}
				return r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Void AssertInvariants()
		/// </summary>
		protected RMethod r_MAssertInvariants;
		public virtual RMethod RMAssertInvariants
		{
			get
			{
				if(r_MAssertInvariants == null)
				{
					r_MAssertInvariants = new(this, "AssertInvariants", 0);
				}
				return r_MAssertInvariants;
			}
		}

		/// <summary>
		/// Int32 EnsureCapacity(Int32)
		/// </summary>
		protected RMethod r_MEnsureCapacity_Int32;
		public virtual RMethod RMEnsureCapacity_Int32
		{
			get
			{
				if(r_MEnsureCapacity_Int32 == null)
				{
					r_MEnsureCapacity_Int32 = new(this, "EnsureCapacity", 0, typeof(System.Int32));
				}
				return r_MEnsureCapacity_Int32;
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
		/// System.String ToString(Int32, Int32)
		/// </summary>
		protected RMethod r_MToString_Int32_Int32;
		public virtual RMethod RMToString_Int32_Int32
		{
			get
			{
				if(r_MToString_Int32_Int32 == null)
				{
					r_MToString_Int32_Int32 = new(this, "ToString", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MToString_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Clear()
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
		/// System.Text.StringBuilder Append(Char, Int32)
		/// </summary>
		protected RMethod r_MAppend_Char_Int32;
		public virtual RMethod RMAppend_Char_Int32
		{
			get
			{
				if(r_MAppend_Char_Int32 == null)
				{
					r_MAppend_Char_Int32 = new(this, "Append", 0, typeof(System.Char), typeof(System.Int32));
				}
				return r_MAppend_Char_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_MAppend_CharArray_Int32_Int32;
		public virtual RMethod RMAppend_CharArray_Int32_Int32
		{
			get
			{
				if(r_MAppend_CharArray_Int32_Int32 == null)
				{
					r_MAppend_CharArray_Int32_Int32 = new(this, "Append", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MAppend_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(System.String)
		/// </summary>
		protected RMethod r_MAppend_String;
		public virtual RMethod RMAppend_String
		{
			get
			{
				if(r_MAppend_String == null)
				{
					r_MAppend_String = new(this, "Append", 0, typeof(System.String));
				}
				return r_MAppend_String;
			}
		}

		/// <summary>
		/// Void AppendHelper(System.String)
		/// </summary>
		protected RMethod r_MAppendHelper_String;
		public virtual RMethod RMAppendHelper_String
		{
			get
			{
				if(r_MAppendHelper_String == null)
				{
					r_MAppendHelper_String = new(this, "AppendHelper", 0, typeof(System.String));
				}
				return r_MAppendHelper_String;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_MAppend_String_Int32_Int32;
		public virtual RMethod RMAppend_String_Int32_Int32
		{
			get
			{
				if(r_MAppend_String_Int32_Int32 == null)
				{
					r_MAppend_String_Int32_Int32 = new(this, "Append", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MAppend_String_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_MAppend_StringBuilder;
		public virtual RMethod RMAppend_StringBuilder
		{
			get
			{
				if(r_MAppend_StringBuilder == null)
				{
					r_MAppend_StringBuilder = new(this, "Append", 0, typeof(System.Text.StringBuilder));
				}
				return r_MAppend_StringBuilder;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(System.Text.StringBuilder, Int32, Int32)
		/// </summary>
		protected RMethod r_MAppend_StringBuilder_Int32_Int32;
		public virtual RMethod RMAppend_StringBuilder_Int32_Int32
		{
			get
			{
				if(r_MAppend_StringBuilder_Int32_Int32 == null)
				{
					r_MAppend_StringBuilder_Int32_Int32 = new(this, "Append", 0, typeof(System.Text.StringBuilder), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MAppend_StringBuilder_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendCore(System.Text.StringBuilder, Int32, Int32)
		/// </summary>
		protected RMethod r_MAppendCore_StringBuilder_Int32_Int32;
		public virtual RMethod RMAppendCore_StringBuilder_Int32_Int32
		{
			get
			{
				if(r_MAppendCore_StringBuilder_Int32_Int32 == null)
				{
					r_MAppendCore_StringBuilder_Int32_Int32 = new(this, "AppendCore", 0, typeof(System.Text.StringBuilder), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MAppendCore_StringBuilder_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendLine()
		/// </summary>
		protected RMethod r_MAppendLine;
		public virtual RMethod RMAppendLine
		{
			get
			{
				if(r_MAppendLine == null)
				{
					r_MAppendLine = new(this, "AppendLine", 0);
				}
				return r_MAppendLine;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendLine(System.String)
		/// </summary>
		protected RMethod r_MAppendLine_String;
		public virtual RMethod RMAppendLine_String
		{
			get
			{
				if(r_MAppendLine_String == null)
				{
					r_MAppendLine_String = new(this, "AppendLine", 0, typeof(System.String));
				}
				return r_MAppendLine_String;
			}
		}

		/// <summary>
		/// Void CopyTo(Int32, Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_MCopyTo_Int32_CharArray_Int32_Int32;
		public virtual RMethod RMCopyTo_Int32_CharArray_Int32_Int32
		{
			get
			{
				if(r_MCopyTo_Int32_CharArray_Int32_Int32 == null)
				{
					r_MCopyTo_Int32_CharArray_Int32_Int32 = new(this, "CopyTo", 0, typeof(System.Int32), typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MCopyTo_Int32_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopyTo(Int32, System.Span`1[System.Char], Int32)
		/// </summary>
		protected RMethod r_MCopyTo_Int32_Span_d_Char_p__Int32;
		public virtual RMethod RMCopyTo_Int32_Span_d_Char_p__Int32
		{
			get
			{
				if(r_MCopyTo_Int32_Span_d_Char_p__Int32 == null)
				{
					r_MCopyTo_Int32_Span_d_Char_p__Int32 = new(this, "CopyTo", 0, typeof(System.Int32), typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32));
				}
				return r_MCopyTo_Int32_Span_d_Char_p__Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, System.String, Int32)
		/// </summary>
		protected RMethod r_MInsert_Int32_String_Int32;
		public virtual RMethod RMInsert_Int32_String_Int32
		{
			get
			{
				if(r_MInsert_Int32_String_Int32 == null)
				{
					r_MInsert_Int32_String_Int32 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.String), typeof(System.Int32));
				}
				return r_MInsert_Int32_String_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Remove(Int32, Int32)
		/// </summary>
		protected RMethod r_MRemove_Int32_Int32;
		public virtual RMethod RMRemove_Int32_Int32
		{
			get
			{
				if(r_MRemove_Int32_Int32 == null)
				{
					r_MRemove_Int32_Int32 = new(this, "Remove", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MRemove_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Boolean)
		/// </summary>
		protected RMethod r_MAppend_Boolean;
		public virtual RMethod RMAppend_Boolean
		{
			get
			{
				if(r_MAppend_Boolean == null)
				{
					r_MAppend_Boolean = new(this, "Append", 0, typeof(System.Boolean));
				}
				return r_MAppend_Boolean;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Char)
		/// </summary>
		protected RMethod r_MAppend_Char;
		public virtual RMethod RMAppend_Char
		{
			get
			{
				if(r_MAppend_Char == null)
				{
					r_MAppend_Char = new(this, "Append", 0, typeof(System.Char));
				}
				return r_MAppend_Char;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(SByte)
		/// </summary>
		protected RMethod r_MAppend_SByte;
		public virtual RMethod RMAppend_SByte
		{
			get
			{
				if(r_MAppend_SByte == null)
				{
					r_MAppend_SByte = new(this, "Append", 0, typeof(System.SByte));
				}
				return r_MAppend_SByte;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Byte)
		/// </summary>
		protected RMethod r_MAppend_Byte;
		public virtual RMethod RMAppend_Byte
		{
			get
			{
				if(r_MAppend_Byte == null)
				{
					r_MAppend_Byte = new(this, "Append", 0, typeof(System.Byte));
				}
				return r_MAppend_Byte;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Int16)
		/// </summary>
		protected RMethod r_MAppend_Int16;
		public virtual RMethod RMAppend_Int16
		{
			get
			{
				if(r_MAppend_Int16 == null)
				{
					r_MAppend_Int16 = new(this, "Append", 0, typeof(System.Int16));
				}
				return r_MAppend_Int16;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Int32)
		/// </summary>
		protected RMethod r_MAppend_Int32;
		public virtual RMethod RMAppend_Int32
		{
			get
			{
				if(r_MAppend_Int32 == null)
				{
					r_MAppend_Int32 = new(this, "Append", 0, typeof(System.Int32));
				}
				return r_MAppend_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Int64)
		/// </summary>
		protected RMethod r_MAppend_Int64;
		public virtual RMethod RMAppend_Int64
		{
			get
			{
				if(r_MAppend_Int64 == null)
				{
					r_MAppend_Int64 = new(this, "Append", 0, typeof(System.Int64));
				}
				return r_MAppend_Int64;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Single)
		/// </summary>
		protected RMethod r_MAppend_Single;
		public virtual RMethod RMAppend_Single
		{
			get
			{
				if(r_MAppend_Single == null)
				{
					r_MAppend_Single = new(this, "Append", 0, typeof(System.Single));
				}
				return r_MAppend_Single;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Double)
		/// </summary>
		protected RMethod r_MAppend_Double;
		public virtual RMethod RMAppend_Double
		{
			get
			{
				if(r_MAppend_Double == null)
				{
					r_MAppend_Double = new(this, "Append", 0, typeof(System.Double));
				}
				return r_MAppend_Double;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(System.Decimal)
		/// </summary>
		protected RMethod r_MAppend_Decimal;
		public virtual RMethod RMAppend_Decimal
		{
			get
			{
				if(r_MAppend_Decimal == null)
				{
					r_MAppend_Decimal = new(this, "Append", 0, typeof(System.Decimal));
				}
				return r_MAppend_Decimal;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(UInt16)
		/// </summary>
		protected RMethod r_MAppend_UInt16;
		public virtual RMethod RMAppend_UInt16
		{
			get
			{
				if(r_MAppend_UInt16 == null)
				{
					r_MAppend_UInt16 = new(this, "Append", 0, typeof(System.UInt16));
				}
				return r_MAppend_UInt16;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(UInt32)
		/// </summary>
		protected RMethod r_MAppend_UInt32;
		public virtual RMethod RMAppend_UInt32
		{
			get
			{
				if(r_MAppend_UInt32 == null)
				{
					r_MAppend_UInt32 = new(this, "Append", 0, typeof(System.UInt32));
				}
				return r_MAppend_UInt32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(UInt64)
		/// </summary>
		protected RMethod r_MAppend_UInt64;
		public virtual RMethod RMAppend_UInt64
		{
			get
			{
				if(r_MAppend_UInt64 == null)
				{
					r_MAppend_UInt64 = new(this, "Append", 0, typeof(System.UInt64));
				}
				return r_MAppend_UInt64;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendSpanFormattable[T](T)
		/// </summary>
		protected RMethod r_MAppendSpanFormattable_GT_T;
		public virtual RMethod RMAppendSpanFormattable_GT_T
		{
			get
			{
				if(r_MAppendSpanFormattable_GT_T == null)
				{
					r_MAppendSpanFormattable_GT_T = new(this, "AppendSpanFormattable", 1, Type.MakeGenericMethodParameter(0));
				}
				return r_MAppendSpanFormattable_GT_T;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(System.Object)
		/// </summary>
		protected RMethod r_MAppend_Object;
		public virtual RMethod RMAppend_Object
		{
			get
			{
				if(r_MAppend_Object == null)
				{
					r_MAppend_Object = new(this, "Append", 0, typeof(System.Object));
				}
				return r_MAppend_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Char[])
		/// </summary>
		protected RMethod r_MAppend_CharArray;
		public virtual RMethod RMAppend_CharArray
		{
			get
			{
				if(r_MAppend_CharArray == null)
				{
					r_MAppend_CharArray = new(this, "Append", 0, typeof(System.Char).MakeArrayType());
				}
				return r_MAppend_CharArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_MAppend_ReadOnlySpan_d_Char_p_;
		public virtual RMethod RMAppend_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_MAppend_ReadOnlySpan_d_Char_p_ == null)
				{
					r_MAppend_ReadOnlySpan_d_Char_p_ = new(this, "Append", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
				}
				return r_MAppend_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoin(System.String, System.Object[])
		/// </summary>
		protected RMethod r_MAppendJoin_String_ObjectArray;
		public virtual RMethod RMAppendJoin_String_ObjectArray
		{
			get
			{
				if(r_MAppendJoin_String_ObjectArray == null)
				{
					r_MAppendJoin_String_ObjectArray = new(this, "AppendJoin", 0, typeof(System.String), typeof(System.Object).MakeArrayType());
				}
				return r_MAppendJoin_String_ObjectArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoin[T](System.String, System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_MAppendJoin_GT_String_IEnumerable_d_T_p_;
		public virtual RMethod RMAppendJoin_GT_String_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MAppendJoin_GT_String_IEnumerable_d_T_p_ == null)
				{
					r_MAppendJoin_GT_String_IEnumerable_d_T_p_ = new(this, "AppendJoin", 1, typeof(System.String), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MAppendJoin_GT_String_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoin(System.String, System.String[])
		/// </summary>
		protected RMethod r_MAppendJoin_String_StringArray;
		public virtual RMethod RMAppendJoin_String_StringArray
		{
			get
			{
				if(r_MAppendJoin_String_StringArray == null)
				{
					r_MAppendJoin_String_StringArray = new(this, "AppendJoin", 0, typeof(System.String), typeof(System.String).MakeArrayType());
				}
				return r_MAppendJoin_String_StringArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoin(Char, System.Object[])
		/// </summary>
		protected RMethod r_MAppendJoin_Char_ObjectArray;
		public virtual RMethod RMAppendJoin_Char_ObjectArray
		{
			get
			{
				if(r_MAppendJoin_Char_ObjectArray == null)
				{
					r_MAppendJoin_Char_ObjectArray = new(this, "AppendJoin", 0, typeof(System.Char), typeof(System.Object).MakeArrayType());
				}
				return r_MAppendJoin_Char_ObjectArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoin[T](Char, System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_MAppendJoin_GT_Char_IEnumerable_d_T_p_;
		public virtual RMethod RMAppendJoin_GT_Char_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MAppendJoin_GT_Char_IEnumerable_d_T_p_ == null)
				{
					r_MAppendJoin_GT_Char_IEnumerable_d_T_p_ = new(this, "AppendJoin", 1, typeof(System.Char), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MAppendJoin_GT_Char_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoin(Char, System.String[])
		/// </summary>
		protected RMethod r_MAppendJoin_Char_StringArray;
		public virtual RMethod RMAppendJoin_Char_StringArray
		{
			get
			{
				if(r_MAppendJoin_Char_StringArray == null)
				{
					r_MAppendJoin_Char_StringArray = new(this, "AppendJoin", 0, typeof(System.Char), typeof(System.String).MakeArrayType());
				}
				return r_MAppendJoin_Char_StringArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoinCore[T](Char*, Int32, System.Collections.Generic.IEnumerable`1[T])
		/// </summary>
		protected RMethod r_MAppendJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_;
		public virtual RMethod RMAppendJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_
		{
			get
			{
				if(r_MAppendJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_ == null)
				{
					r_MAppendJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_ = new(this, "AppendJoinCore", 1, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
				}
				return r_MAppendJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendJoinCore[T](Char*, Int32, T[])
		/// </summary>
		protected RMethod r_MAppendJoinCore_GT_CharPointer_Int32_TArray;
		public virtual RMethod RMAppendJoinCore_GT_CharPointer_Int32_TArray
		{
			get
			{
				if(r_MAppendJoinCore_GT_CharPointer_Int32_TArray == null)
				{
					r_MAppendJoinCore_GT_CharPointer_Int32_TArray = new(this, "AppendJoinCore", 1, typeof(System.Char).MakePointerType(), typeof(System.Int32), Type.MakeGenericMethodParameter(0).MakeArrayType());
				}
				return r_MAppendJoinCore_GT_CharPointer_Int32_TArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, System.String)
		/// </summary>
		protected RMethod r_MInsert_Int32_String;
		public virtual RMethod RMInsert_Int32_String
		{
			get
			{
				if(r_MInsert_Int32_String == null)
				{
					r_MInsert_Int32_String = new(this, "Insert", 0, typeof(System.Int32), typeof(System.String));
				}
				return r_MInsert_Int32_String;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Boolean)
		/// </summary>
		protected RMethod r_MInsert_Int32_Boolean;
		public virtual RMethod RMInsert_Int32_Boolean
		{
			get
			{
				if(r_MInsert_Int32_Boolean == null)
				{
					r_MInsert_Int32_Boolean = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Boolean));
				}
				return r_MInsert_Int32_Boolean;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, SByte)
		/// </summary>
		protected RMethod r_MInsert_Int32_SByte;
		public virtual RMethod RMInsert_Int32_SByte
		{
			get
			{
				if(r_MInsert_Int32_SByte == null)
				{
					r_MInsert_Int32_SByte = new(this, "Insert", 0, typeof(System.Int32), typeof(System.SByte));
				}
				return r_MInsert_Int32_SByte;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Byte)
		/// </summary>
		protected RMethod r_MInsert_Int32_Byte;
		public virtual RMethod RMInsert_Int32_Byte
		{
			get
			{
				if(r_MInsert_Int32_Byte == null)
				{
					r_MInsert_Int32_Byte = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Byte));
				}
				return r_MInsert_Int32_Byte;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Int16)
		/// </summary>
		protected RMethod r_MInsert_Int32_Int16;
		public virtual RMethod RMInsert_Int32_Int16
		{
			get
			{
				if(r_MInsert_Int32_Int16 == null)
				{
					r_MInsert_Int32_Int16 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Int16));
				}
				return r_MInsert_Int32_Int16;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Char)
		/// </summary>
		protected RMethod r_MInsert_Int32_Char;
		public virtual RMethod RMInsert_Int32_Char
		{
			get
			{
				if(r_MInsert_Int32_Char == null)
				{
					r_MInsert_Int32_Char = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Char));
				}
				return r_MInsert_Int32_Char;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Char[])
		/// </summary>
		protected RMethod r_MInsert_Int32_CharArray;
		public virtual RMethod RMInsert_Int32_CharArray
		{
			get
			{
				if(r_MInsert_Int32_CharArray == null)
				{
					r_MInsert_Int32_CharArray = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Char).MakeArrayType());
				}
				return r_MInsert_Int32_CharArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_MInsert_Int32_CharArray_Int32_Int32;
		public virtual RMethod RMInsert_Int32_CharArray_Int32_Int32
		{
			get
			{
				if(r_MInsert_Int32_CharArray_Int32_Int32 == null)
				{
					r_MInsert_Int32_CharArray_Int32_Int32 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInsert_Int32_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Int32)
		/// </summary>
		protected RMethod r_MInsert_Int32_Int32;
		public virtual RMethod RMInsert_Int32_Int32
		{
			get
			{
				if(r_MInsert_Int32_Int32 == null)
				{
					r_MInsert_Int32_Int32 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Int32));
				}
				return r_MInsert_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Int64)
		/// </summary>
		protected RMethod r_MInsert_Int32_Int64;
		public virtual RMethod RMInsert_Int32_Int64
		{
			get
			{
				if(r_MInsert_Int32_Int64 == null)
				{
					r_MInsert_Int32_Int64 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Int64));
				}
				return r_MInsert_Int32_Int64;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Single)
		/// </summary>
		protected RMethod r_MInsert_Int32_Single;
		public virtual RMethod RMInsert_Int32_Single
		{
			get
			{
				if(r_MInsert_Int32_Single == null)
				{
					r_MInsert_Int32_Single = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Single));
				}
				return r_MInsert_Int32_Single;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, Double)
		/// </summary>
		protected RMethod r_MInsert_Int32_Double;
		public virtual RMethod RMInsert_Int32_Double
		{
			get
			{
				if(r_MInsert_Int32_Double == null)
				{
					r_MInsert_Int32_Double = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Double));
				}
				return r_MInsert_Int32_Double;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, System.Decimal)
		/// </summary>
		protected RMethod r_MInsert_Int32_Decimal;
		public virtual RMethod RMInsert_Int32_Decimal
		{
			get
			{
				if(r_MInsert_Int32_Decimal == null)
				{
					r_MInsert_Int32_Decimal = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Decimal));
				}
				return r_MInsert_Int32_Decimal;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, UInt16)
		/// </summary>
		protected RMethod r_MInsert_Int32_UInt16;
		public virtual RMethod RMInsert_Int32_UInt16
		{
			get
			{
				if(r_MInsert_Int32_UInt16 == null)
				{
					r_MInsert_Int32_UInt16 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.UInt16));
				}
				return r_MInsert_Int32_UInt16;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, UInt32)
		/// </summary>
		protected RMethod r_MInsert_Int32_UInt32;
		public virtual RMethod RMInsert_Int32_UInt32
		{
			get
			{
				if(r_MInsert_Int32_UInt32 == null)
				{
					r_MInsert_Int32_UInt32 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.UInt32));
				}
				return r_MInsert_Int32_UInt32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, UInt64)
		/// </summary>
		protected RMethod r_MInsert_Int32_UInt64;
		public virtual RMethod RMInsert_Int32_UInt64
		{
			get
			{
				if(r_MInsert_Int32_UInt64 == null)
				{
					r_MInsert_Int32_UInt64 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.UInt64));
				}
				return r_MInsert_Int32_UInt64;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, System.Object)
		/// </summary>
		protected RMethod r_MInsert_Int32_Object;
		public virtual RMethod RMInsert_Int32_Object
		{
			get
			{
				if(r_MInsert_Int32_Object == null)
				{
					r_MInsert_Int32_Object = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Object));
				}
				return r_MInsert_Int32_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Insert(Int32, System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_MInsert_Int32_ReadOnlySpan_d_Char_p_;
		public virtual RMethod RMInsert_Int32_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_MInsert_Int32_ReadOnlySpan_d_Char_p_ == null)
				{
					r_MInsert_Int32_ReadOnlySpan_d_Char_p_ = new(this, "Insert", 0, typeof(System.Int32), typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
				}
				return r_MInsert_Int32_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.String, System.Object)
		/// </summary>
		protected RMethod r_MAppendFormat_String_Object;
		public virtual RMethod RMAppendFormat_String_Object
		{
			get
			{
				if(r_MAppendFormat_String_Object == null)
				{
					r_MAppendFormat_String_Object = new(this, "AppendFormat", 0, typeof(System.String), typeof(System.Object));
				}
				return r_MAppendFormat_String_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.String, System.Object, System.Object)
		/// </summary>
		protected RMethod r_MAppendFormat_String_Object_Object;
		public virtual RMethod RMAppendFormat_String_Object_Object
		{
			get
			{
				if(r_MAppendFormat_String_Object_Object == null)
				{
					r_MAppendFormat_String_Object_Object = new(this, "AppendFormat", 0, typeof(System.String), typeof(System.Object), typeof(System.Object));
				}
				return r_MAppendFormat_String_Object_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.String, System.Object, System.Object, System.Object)
		/// </summary>
		protected RMethod r_MAppendFormat_String_Object_Object_Object;
		public virtual RMethod RMAppendFormat_String_Object_Object_Object
		{
			get
			{
				if(r_MAppendFormat_String_Object_Object_Object == null)
				{
					r_MAppendFormat_String_Object_Object_Object = new(this, "AppendFormat", 0, typeof(System.String), typeof(System.Object), typeof(System.Object), typeof(System.Object));
				}
				return r_MAppendFormat_String_Object_Object_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.String, System.Object[])
		/// </summary>
		protected RMethod r_MAppendFormat_String_ObjectArray;
		public virtual RMethod RMAppendFormat_String_ObjectArray
		{
			get
			{
				if(r_MAppendFormat_String_ObjectArray == null)
				{
					r_MAppendFormat_String_ObjectArray = new(this, "AppendFormat", 0, typeof(System.String), typeof(System.Object).MakeArrayType());
				}
				return r_MAppendFormat_String_ObjectArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.IFormatProvider, System.String, System.Object)
		/// </summary>
		protected RMethod r_MAppendFormat_IFormatProvider_String_Object;
		public virtual RMethod RMAppendFormat_IFormatProvider_String_Object
		{
			get
			{
				if(r_MAppendFormat_IFormatProvider_String_Object == null)
				{
					r_MAppendFormat_IFormatProvider_String_Object = new(this, "AppendFormat", 0, typeof(System.IFormatProvider), typeof(System.String), typeof(System.Object));
				}
				return r_MAppendFormat_IFormatProvider_String_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.IFormatProvider, System.String, System.Object, System.Object)
		/// </summary>
		protected RMethod r_MAppendFormat_IFormatProvider_String_Object_Object;
		public virtual RMethod RMAppendFormat_IFormatProvider_String_Object_Object
		{
			get
			{
				if(r_MAppendFormat_IFormatProvider_String_Object_Object == null)
				{
					r_MAppendFormat_IFormatProvider_String_Object_Object = new(this, "AppendFormat", 0, typeof(System.IFormatProvider), typeof(System.String), typeof(System.Object), typeof(System.Object));
				}
				return r_MAppendFormat_IFormatProvider_String_Object_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.IFormatProvider, System.String, System.Object, System.Object, System.Object)
		/// </summary>
		protected RMethod r_MAppendFormat_IFormatProvider_String_Object_Object_Object;
		public virtual RMethod RMAppendFormat_IFormatProvider_String_Object_Object_Object
		{
			get
			{
				if(r_MAppendFormat_IFormatProvider_String_Object_Object_Object == null)
				{
					r_MAppendFormat_IFormatProvider_String_Object_Object_Object = new(this, "AppendFormat", 0, typeof(System.IFormatProvider), typeof(System.String), typeof(System.Object), typeof(System.Object), typeof(System.Object));
				}
				return r_MAppendFormat_IFormatProvider_String_Object_Object_Object;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormat(System.IFormatProvider, System.String, System.Object[])
		/// </summary>
		protected RMethod r_MAppendFormat_IFormatProvider_String_ObjectArray;
		public virtual RMethod RMAppendFormat_IFormatProvider_String_ObjectArray
		{
			get
			{
				if(r_MAppendFormat_IFormatProvider_String_ObjectArray == null)
				{
					r_MAppendFormat_IFormatProvider_String_ObjectArray = new(this, "AppendFormat", 0, typeof(System.IFormatProvider), typeof(System.String), typeof(System.Object).MakeArrayType());
				}
				return r_MAppendFormat_IFormatProvider_String_ObjectArray;
			}
		}

		/// <summary>
		/// Void FormatError()
		/// </summary>
		protected static RMethod r_MFormatError;
		public static RMethod RMFormatError
		{
			get
			{
				if(r_MFormatError == null)
				{
					r_MFormatError = new(typeof(System.Text.StringBuilder), "FormatError", 0);
				}
				return r_MFormatError;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder AppendFormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
		/// </summary>
		protected RMethod r_MAppendFormatHelper_IFormatProvider_String_ParamsArray;
		public virtual RMethod RMAppendFormatHelper_IFormatProvider_String_ParamsArray
		{
			get
			{
				if(r_MAppendFormatHelper_IFormatProvider_String_ParamsArray == null)
				{
					r_MAppendFormatHelper_IFormatProvider_String_ParamsArray = new(this, "AppendFormatHelper", 0, typeof(System.IFormatProvider), typeof(System.String),  ReflectionUtils.GetType("System.ParamsArray"));
				}
				return r_MAppendFormatHelper_IFormatProvider_String_ParamsArray;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Replace(System.String, System.String)
		/// </summary>
		protected RMethod r_MReplace_String_String;
		public virtual RMethod RMReplace_String_String
		{
			get
			{
				if(r_MReplace_String_String == null)
				{
					r_MReplace_String_String = new(this, "Replace", 0, typeof(System.String), typeof(System.String));
				}
				return r_MReplace_String_String;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_MEquals_StringBuilder;
		public virtual RMethod RMEquals_StringBuilder
		{
			get
			{
				if(r_MEquals_StringBuilder == null)
				{
					r_MEquals_StringBuilder = new(this, "Equals", 0, typeof(System.Text.StringBuilder));
				}
				return r_MEquals_StringBuilder;
			}
		}

		/// <summary>
		/// Boolean Equals(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_MEquals_ReadOnlySpan_d_Char_p_;
		public virtual RMethod RMEquals_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_MEquals_ReadOnlySpan_d_Char_p_ == null)
				{
					r_MEquals_ReadOnlySpan_d_Char_p_ = new(this, "Equals", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
				}
				return r_MEquals_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Replace(System.String, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_MReplace_String_String_Int32_Int32;
		public virtual RMethod RMReplace_String_String_Int32_Int32
		{
			get
			{
				if(r_MReplace_String_String_Int32_Int32 == null)
				{
					r_MReplace_String_String_Int32_Int32 = new(this, "Replace", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MReplace_String_String_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Replace(Char, Char)
		/// </summary>
		protected RMethod r_MReplace_Char_Char;
		public virtual RMethod RMReplace_Char_Char
		{
			get
			{
				if(r_MReplace_Char_Char == null)
				{
					r_MReplace_Char_Char = new(this, "Replace", 0, typeof(System.Char), typeof(System.Char));
				}
				return r_MReplace_Char_Char;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Replace(Char, Char, Int32, Int32)
		/// </summary>
		protected RMethod r_MReplace_Char_Char_Int32_Int32;
		public virtual RMethod RMReplace_Char_Char_Int32_Int32
		{
			get
			{
				if(r_MReplace_Char_Char_Int32_Int32 == null)
				{
					r_MReplace_Char_Char_Int32_Int32 = new(this, "Replace", 0, typeof(System.Char), typeof(System.Char), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MReplace_Char_Char_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Append(Char*, Int32)
		/// </summary>
		protected RMethod r_MAppend_CharPointer_Int32;
		public virtual RMethod RMAppend_CharPointer_Int32
		{
			get
			{
				if(r_MAppend_CharPointer_Int32 == null)
				{
					r_MAppend_CharPointer_Int32 = new(this, "Append", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32));
				}
				return r_MAppend_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Void Insert(Int32, Char*, Int32)
		/// </summary>
		protected RMethod r_MInsert_Int32_CharPointer_Int32;
		public virtual RMethod RMInsert_Int32_CharPointer_Int32
		{
			get
			{
				if(r_MInsert_Int32_CharPointer_Int32 == null)
				{
					r_MInsert_Int32_CharPointer_Int32 = new(this, "Insert", 0, typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32));
				}
				return r_MInsert_Int32_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Void ReplaceAllInChunk(Int32[], Int32, System.Text.StringBuilder, Int32, System.String)
		/// </summary>
		protected RMethod r_MReplaceAllInChunk_Int32Array_Int32_StringBuilder_Int32_String;
		public virtual RMethod RMReplaceAllInChunk_Int32Array_Int32_StringBuilder_Int32_String
		{
			get
			{
				if(r_MReplaceAllInChunk_Int32Array_Int32_StringBuilder_Int32_String == null)
				{
					r_MReplaceAllInChunk_Int32Array_Int32_StringBuilder_Int32_String = new(this, "ReplaceAllInChunk", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32), typeof(System.Text.StringBuilder), typeof(System.Int32), typeof(System.String));
				}
				return r_MReplaceAllInChunk_Int32Array_Int32_StringBuilder_Int32_String;
			}
		}

		/// <summary>
		/// Boolean StartsWith(System.Text.StringBuilder, Int32, Int32, System.String)
		/// </summary>
		protected RMethod r_MStartsWith_StringBuilder_Int32_Int32_String;
		public virtual RMethod RMStartsWith_StringBuilder_Int32_Int32_String
		{
			get
			{
				if(r_MStartsWith_StringBuilder_Int32_Int32_String == null)
				{
					r_MStartsWith_StringBuilder_Int32_Int32_String = new(this, "StartsWith", 0, typeof(System.Text.StringBuilder), typeof(System.Int32), typeof(System.Int32), typeof(System.String));
				}
				return r_MStartsWith_StringBuilder_Int32_Int32_String;
			}
		}

		/// <summary>
		/// Void ReplaceInPlaceAtChunk(System.Text.StringBuilder ByRef, Int32 ByRef, Char*, Int32)
		/// </summary>
		protected RMethod r_MReplaceInPlaceAtChunk_Ref_StringBuilder_Ref_Int32_CharPointer_Int32;
		public virtual RMethod RMReplaceInPlaceAtChunk_Ref_StringBuilder_Ref_Int32_CharPointer_Int32
		{
			get
			{
				if(r_MReplaceInPlaceAtChunk_Ref_StringBuilder_Ref_Int32_CharPointer_Int32 == null)
				{
					r_MReplaceInPlaceAtChunk_Ref_StringBuilder_Ref_Int32_CharPointer_Int32 = new(this, "ReplaceInPlaceAtChunk", 0, typeof(System.Text.StringBuilder).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Char).MakePointerType(), typeof(System.Int32));
				}
				return r_MReplaceInPlaceAtChunk_Ref_StringBuilder_Ref_Int32_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Void ThreadSafeCopy(Char*, Char[], Int32, Int32)
		/// </summary>
		protected static RMethod r_MThreadSafeCopy_CharPointer_CharArray_Int32_Int32;
		public static RMethod RMThreadSafeCopy_CharPointer_CharArray_Int32_Int32
		{
			get
			{
				if(r_MThreadSafeCopy_CharPointer_CharArray_Int32_Int32 == null)
				{
					r_MThreadSafeCopy_CharPointer_CharArray_Int32_Int32 = new(typeof(System.Text.StringBuilder), "ThreadSafeCopy", 0, typeof(System.Char).MakePointerType(), typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MThreadSafeCopy_CharPointer_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ThreadSafeCopy(Char[], Int32, System.Span`1[System.Char], Int32, Int32)
		/// </summary>
		protected static RMethod r_MThreadSafeCopy_CharArray_Int32_Span_d_Char_p__Int32_Int32;
		public static RMethod RMThreadSafeCopy_CharArray_Int32_Span_d_Char_p__Int32_Int32
		{
			get
			{
				if(r_MThreadSafeCopy_CharArray_Int32_Span_d_Char_p__Int32_Int32 == null)
				{
					r_MThreadSafeCopy_CharArray_Int32_Span_d_Char_p__Int32_Int32 = new(typeof(System.Text.StringBuilder), "ThreadSafeCopy", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32), typeof(System.Int32));
				}
				return r_MThreadSafeCopy_CharArray_Int32_Span_d_Char_p__Int32_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder FindChunkForIndex(Int32)
		/// </summary>
		protected RMethod r_MFindChunkForIndex_Int32;
		public virtual RMethod RMFindChunkForIndex_Int32
		{
			get
			{
				if(r_MFindChunkForIndex_Int32 == null)
				{
					r_MFindChunkForIndex_Int32 = new(this, "FindChunkForIndex", 0, typeof(System.Int32));
				}
				return r_MFindChunkForIndex_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder FindChunkForByte(Int32)
		/// </summary>
		protected RMethod r_MFindChunkForByte_Int32;
		public virtual RMethod RMFindChunkForByte_Int32
		{
			get
			{
				if(r_MFindChunkForByte_Int32 == null)
				{
					r_MFindChunkForByte_Int32 = new(this, "FindChunkForByte", 0, typeof(System.Int32));
				}
				return r_MFindChunkForByte_Int32;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder Next(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_MNext_StringBuilder;
		public virtual RMethod RMNext_StringBuilder
		{
			get
			{
				if(r_MNext_StringBuilder == null)
				{
					r_MNext_StringBuilder = new(this, "Next", 0, typeof(System.Text.StringBuilder));
				}
				return r_MNext_StringBuilder;
			}
		}

		/// <summary>
		/// Void ExpandByABlock(Int32)
		/// </summary>
		protected RMethod r_MExpandByABlock_Int32;
		public virtual RMethod RMExpandByABlock_Int32
		{
			get
			{
				if(r_MExpandByABlock_Int32 == null)
				{
					r_MExpandByABlock_Int32 = new(this, "ExpandByABlock", 0, typeof(System.Int32));
				}
				return r_MExpandByABlock_Int32;
			}
		}

		/// <summary>
		/// Void MakeRoom(Int32, Int32, System.Text.StringBuilder ByRef, Int32 ByRef, Boolean)
		/// </summary>
		protected RMethod r_MMakeRoom_Int32_Int32_Out_StringBuilder_Out_Int32_Boolean;
		public virtual RMethod RMMakeRoom_Int32_Int32_Out_StringBuilder_Out_Int32_Boolean
		{
			get
			{
				if(r_MMakeRoom_Int32_Int32_Out_StringBuilder_Out_Int32_Boolean == null)
				{
					r_MMakeRoom_Int32_Int32_Out_StringBuilder_Out_Int32_Boolean = new(this, "MakeRoom", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Text.StringBuilder).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
				}
				return r_MMakeRoom_Int32_Int32_Out_StringBuilder_Out_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void Remove(Int32, Int32, System.Text.StringBuilder ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_MRemove_Int32_Int32_Out_StringBuilder_Out_Int32;
		public virtual RMethod RMRemove_Int32_Int32_Out_StringBuilder_Out_Int32
		{
			get
			{
				if(r_MRemove_Int32_Int32_Out_StringBuilder_Out_Int32 == null)
				{
					r_MRemove_Int32_Int32_Out_StringBuilder_Out_Int32 = new(this, "Remove", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Text.StringBuilder).MakeByRefType(), typeof(System.Int32).MakeByRefType());
				}
				return r_MRemove_Int32_Int32_Out_StringBuilder_Out_Int32;
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


        public virtual void System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AssertInvariants()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAssertInvariants.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 EnsureCapacity(System.Int32 @capacity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@capacity};
            var ___result = RMEnsureCapacity_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @length};
            var ___result = RMToString_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Text.StringBuilder Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Char @value, System.Int32 @repeatCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @repeatCount};
            var ___result = RMAppend_Char_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Char[] @value, System.Int32 @startIndex, System.Int32 @charCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @charCount};
            var ___result = RMAppend_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAppend_String.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual void AppendHelper(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAppendHelper_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Text.StringBuilder Append(System.String @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RMAppend_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Text.StringBuilder @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAppend_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Text.StringBuilder @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RMAppend_StringBuilder_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendCore(System.Text.StringBuilder @value, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @startIndex, @count};
            var ___result = RMAppendCore_StringBuilder_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendLine()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAppendLine.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendLine(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAppendLine_String.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual void CopyTo(System.Int32 @sourceIndex, System.Char[] @destination, System.Int32 @destinationIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceIndex, @destination, @destinationIndex, @count};
            var ___result = RMCopyTo_Int32_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Int32 @sourceIndex, Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RSystem.RChar> @destination, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourceIndex, @destination.Value, @count};
            var ___result = RMCopyTo_Int32_Span_d_Char_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.String @value, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value, @count};
            var ___result = RMInsert_Int32_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Remove(System.Int32 @startIndex, System.Int32 @length)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @length};
            var ___result = RMRemove_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAppend_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAppend_Char.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.SByte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAppend_SByte.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Byte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAppend_Byte.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Int16 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAppend_Int16.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAppend_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Int64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAppend_Int64.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAppend_Single.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAppend_Double.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Decimal @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAppend_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.UInt16 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAppend_UInt16.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.UInt32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAppend_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.UInt64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAppend_UInt64.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendSpanFormattable<T>(T @value) where T : System.IFormattable
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@value};
            var ___result = RMAppendSpanFormattable_GT_T.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAppend_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(System.Char[] @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMAppend_CharArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Append(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value.Value};
            var ___result = RMAppend_ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendJoin(System.String @separator, System.Object[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RMAppendJoin_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendJoin<T>(System.String @separator, System.Collections.Generic.IEnumerable<T> @values)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RMAppendJoin_GT_String_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendJoin(System.String @separator, System.String[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RMAppendJoin_String_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendJoin(System.Char @separator, System.Object[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RMAppendJoin_Char_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendJoin<T>(System.Char @separator, System.Collections.Generic.IEnumerable<T> @values)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RMAppendJoin_GT_Char_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendJoin(System.Char @separator, System.String[] @values)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@separator, @values};
            var ___result = RMAppendJoin_Char_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public unsafe virtual System.Text.StringBuilder AppendJoinCore<T>(System.Char* @separator, System.Int32 @separatorLength, System.Collections.Generic.IEnumerable<T> @values)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{Pointer.Box(@separator, typeof(System.Char)), @separatorLength, @values};
            var ___result = RMAppendJoinCore_GT_CharPointer_Int32_IEnumerable_d_T_p_.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public unsafe virtual System.Text.StringBuilder AppendJoinCore<T>(System.Char* @separator, System.Int32 @separatorLength, T[] @values)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{Pointer.Box(@separator, typeof(System.Char)), @separatorLength, @values};
            var ___result = RMAppendJoinCore_GT_CharPointer_Int32_TArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RMInsert_Int32_String.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RMInsert_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.SByte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RMInsert_Int32_SByte.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Byte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RMInsert_Int32_Byte.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Int16 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RMInsert_Int32_Int16.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RMInsert_Int32_Char.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Char[] @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RMInsert_Int32_CharArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Char[] @value, System.Int32 @startIndex, System.Int32 @charCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value, @startIndex, @charCount};
            var ___result = RMInsert_Int32_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RMInsert_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Int64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RMInsert_Int32_Int64.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RMInsert_Int32_Single.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RMInsert_Int32_Double.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Decimal @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RMInsert_Int32_Decimal.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.UInt16 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RMInsert_Int32_UInt16.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.UInt32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RMInsert_Int32_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.UInt64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RMInsert_Int32_UInt64.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RMInsert_Int32_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Insert(System.Int32 @index, Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value.Value};
            var ___result = RMInsert_Int32_ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.String @format, System.Object @arg0)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg0};
            var ___result = RMAppendFormat_String_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.String @format, System.Object @arg0, System.Object @arg1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg0, @arg1};
            var ___result = RMAppendFormat_String_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.String @format, System.Object @arg0, System.Object @arg1, System.Object @arg2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg0, @arg1, @arg2};
            var ___result = RMAppendFormat_String_Object_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.String @format, System.Object[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @args};
            var ___result = RMAppendFormat_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.IFormatProvider @provider, System.String @format, System.Object @arg0)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @arg0};
            var ___result = RMAppendFormat_IFormatProvider_String_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.IFormatProvider @provider, System.String @format, System.Object @arg0, System.Object @arg1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @arg0, @arg1};
            var ___result = RMAppendFormat_IFormatProvider_String_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.IFormatProvider @provider, System.String @format, System.Object @arg0, System.Object @arg1, System.Object @arg2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @arg0, @arg1, @arg2};
            var ___result = RMAppendFormat_IFormatProvider_String_Object_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder AppendFormat(System.IFormatProvider @provider, System.String @format, System.Object[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @args};
            var ___result = RMAppendFormat_IFormatProvider_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public static void FormatError()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFormatError.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Text.StringBuilder AppendFormatHelper(System.IFormatProvider @provider, System.String @format, Hvak.Editor.Refleaction.RSystem.RParamsArray @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider, @format, @args.Value};
            var ___result = RMAppendFormatHelper_IFormatProvider_String_ParamsArray.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Replace(System.String @oldValue, System.String @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = RMReplace_String_String.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Boolean Equals(System.Text.StringBuilder @sb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sb};
            var ___result = RMEquals_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(Hvak.Editor.Refleaction.RSystem.RReadOnlySpan<Hvak.Editor.Refleaction.RSystem.RChar> @span)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@span.Value};
            var ___result = RMEquals_ReadOnlySpan_d_Char_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Text.StringBuilder Replace(System.String @oldValue, System.String @newValue, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue, @startIndex, @count};
            var ___result = RMReplace_String_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Replace(System.Char @oldChar, System.Char @newChar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldChar, @newChar};
            var ___result = RMReplace_Char_Char.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Replace(System.Char @oldChar, System.Char @newChar, System.Int32 @startIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldChar, @newChar, @startIndex, @count};
            var ___result = RMReplace_Char_Char_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public unsafe virtual System.Text.StringBuilder Append(System.Char* @value, System.Int32 @valueCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@value, typeof(System.Char)), @valueCount};
            var ___result = RMAppend_CharPointer_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public unsafe virtual void Insert(System.Int32 @index, System.Char* @value, System.Int32 @valueCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, Pointer.Box(@value, typeof(System.Char)), @valueCount};
            var ___result = RMInsert_Int32_CharPointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReplaceAllInChunk(System.Int32[] @replacements, System.Int32 @replacementsCount, System.Text.StringBuilder @sourceChunk, System.Int32 @removeCount, System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@replacements, @replacementsCount, @sourceChunk, @removeCount, @value};
            var ___result = RMReplaceAllInChunk_Int32Array_Int32_StringBuilder_Int32_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean StartsWith(System.Text.StringBuilder @chunk, System.Int32 @indexInChunk, System.Int32 @count, System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chunk, @indexInChunk, @count, @value};
            var ___result = RMStartsWith_StringBuilder_Int32_Int32_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public unsafe virtual void ReplaceInPlaceAtChunk(ref System.Text.StringBuilder @chunk, ref System.Int32 @indexInChunk, System.Char* @value, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chunk, @indexInChunk, Pointer.Box(@value, typeof(System.Char)), @count};
            var ___result = RMReplaceInPlaceAtChunk_Ref_StringBuilder_Ref_Int32_CharPointer_Int32.Invoke(___genericsType, ___parameters);
			@chunk = (System.Text.StringBuilder)___parameters[0];
			@indexInChunk = (System.Int32)___parameters[1];

            
        }


        public unsafe static void ThreadSafeCopy(System.Char* @sourcePtr, System.Char[] @destination, System.Int32 @destinationIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@sourcePtr, typeof(System.Char)), @destination, @destinationIndex, @count};
            var ___result = RMThreadSafeCopy_CharPointer_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void ThreadSafeCopy(System.Char[] @source, System.Int32 @sourceIndex, Hvak.Editor.Refleaction.RSystem.RSpan<Hvak.Editor.Refleaction.RSystem.RChar> @destination, System.Int32 @destinationIndex, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @sourceIndex, @destination.Value, @destinationIndex, @count};
            var ___result = RMThreadSafeCopy_CharArray_Int32_Span_d_Char_p__Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Text.StringBuilder FindChunkForIndex(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMFindChunkForIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder FindChunkForByte(System.Int32 @byteIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@byteIndex};
            var ___result = RMFindChunkForByte_Int32.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual System.Text.StringBuilder Next(System.Text.StringBuilder @chunk)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chunk};
            var ___result = RMNext_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Text.StringBuilder)___result;
        }


        public virtual void ExpandByABlock(System.Int32 @minBlockCharCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@minBlockCharCount};
            var ___result = RMExpandByABlock_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MakeRoom(System.Int32 @index, System.Int32 @count, out System.Text.StringBuilder @chunk, out System.Int32 @indexInChunk, System.Boolean @doNotMoveFollowingChars)
        {
			@chunk = default;
			@indexInChunk = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @count, @chunk, @indexInChunk, @doNotMoveFollowingChars};
            var ___result = RMMakeRoom_Int32_Int32_Out_StringBuilder_Out_Int32_Boolean.Invoke(___genericsType, ___parameters);
			@chunk = (System.Text.StringBuilder)___parameters[2];
			@indexInChunk = (System.Int32)___parameters[3];

            
        }


        public virtual void Remove(System.Int32 @startIndex, System.Int32 @count, out System.Text.StringBuilder @chunk, out System.Int32 @indexInChunk)
        {
			@chunk = default;
			@indexInChunk = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startIndex, @count, @chunk, @indexInChunk};
            var ___result = RMRemove_Int32_Int32_Out_StringBuilder_Out_Int32.Invoke(___genericsType, ___parameters);
			@chunk = (System.Text.StringBuilder)___parameters[2];
			@indexInChunk = (System.Int32)___parameters[3];

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
