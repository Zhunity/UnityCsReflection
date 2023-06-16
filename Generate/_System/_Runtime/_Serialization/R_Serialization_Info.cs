
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Runtime.Serialization.SerializationInfo
	/// </summary>
    public partial class RSerializationInfo : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Runtime.Serialization.SerializationInfo);
            }
        }

        public RSerializationInfo() : base("System.Runtime.Serialization.SerializationInfo")
        {
        }

        public RSerializationInfo(System.Object instance) : base("System.Runtime.Serialization.SerializationInfo")
		{
            SetInstance(instance);
		}

        public RSerializationInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSerializationInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 defaultSize
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RInt32 r_FdefaultSize;
		public static Hvak.Editor.Refleaction.RSystem.RInt32 RFdefaultSize
		{
			get
			{
				if(r_FdefaultSize == null)
				{
					r_FdefaultSize = new(Type, "defaultSize");
				}
				return r_FdefaultSize;
			}
		}

		/// <summary>
		/// System.String s_mscorlibAssemblySimpleName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fs_mscorlibAssemblySimpleName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFs_mscorlibAssemblySimpleName
		{
			get
			{
				if(r_Fs_mscorlibAssemblySimpleName == null)
				{
					r_Fs_mscorlibAssemblySimpleName = new(Type, "s_mscorlibAssemblySimpleName");
				}
				return r_Fs_mscorlibAssemblySimpleName;
			}
		}

		/// <summary>
		/// System.String s_mscorlibFileName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fs_mscorlibFileName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFs_mscorlibFileName
		{
			get
			{
				if(r_Fs_mscorlibFileName == null)
				{
					r_Fs_mscorlibFileName = new(Type, "s_mscorlibFileName");
				}
				return r_Fs_mscorlibFileName;
			}
		}

		/// <summary>
		/// System.String[] m_members
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_members;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RString> RFm_members
		{
			get
			{
				if(r_Fm_members == null)
				{
					r_Fm_members = new(this, "m_members");
				}
				return r_Fm_members;
			}
		}

		/// <summary>
		/// System.Object[] m_data
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> r_Fm_data;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> RFm_data
		{
			get
			{
				if(r_Fm_data == null)
				{
					r_Fm_data = new(this, "m_data");
				}
				return r_Fm_data;
			}
		}

		/// <summary>
		/// System.Type[] m_types
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType> r_Fm_types;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType> RFm_types
		{
			get
			{
				if(r_Fm_types == null)
				{
					r_Fm_types = new(this, "m_types");
				}
				return r_Fm_types;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] m_nameToIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RInt32> r_Fm_nameToIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RString, Hvak.Editor.Refleaction.RSystem.RInt32> RFm_nameToIndex
		{
			get
			{
				if(r_Fm_nameToIndex == null)
				{
					r_Fm_nameToIndex = new(this, "m_nameToIndex");
				}
				return r_Fm_nameToIndex;
			}
		}

		/// <summary>
		/// System.Int32 m_currMember
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_currMember;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_currMember
		{
			get
			{
				if(r_Fm_currMember == null)
				{
					r_Fm_currMember = new(this, "m_currMember");
				}
				return r_Fm_currMember;
			}
		}

		/// <summary>
		/// System.Runtime.Serialization.IFormatterConverter m_converter
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RIFormatterConverter r_Fm_converter;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RIFormatterConverter RFm_converter
		{
			get
			{
				if(r_Fm_converter == null)
				{
					r_Fm_converter = new(this, "m_converter");
				}
				return r_Fm_converter;
			}
		}

		/// <summary>
		/// System.String m_fullTypeName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_fullTypeName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_fullTypeName
		{
			get
			{
				if(r_Fm_fullTypeName == null)
				{
					r_Fm_fullTypeName = new(this, "m_fullTypeName");
				}
				return r_Fm_fullTypeName;
			}
		}

		/// <summary>
		/// System.String m_assemName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_assemName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_assemName
		{
			get
			{
				if(r_Fm_assemName == null)
				{
					r_Fm_assemName = new(this, "m_assemName");
				}
				return r_Fm_assemName;
			}
		}

		/// <summary>
		/// System.Type objectType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_FobjectType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RFobjectType
		{
			get
			{
				if(r_FobjectType == null)
				{
					r_FobjectType = new(this, "objectType");
				}
				return r_FobjectType;
			}
		}

		/// <summary>
		/// System.Boolean isFullTypeNameSetExplicit
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisFullTypeNameSetExplicit;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisFullTypeNameSetExplicit
		{
			get
			{
				if(r_FisFullTypeNameSetExplicit == null)
				{
					r_FisFullTypeNameSetExplicit = new(this, "isFullTypeNameSetExplicit");
				}
				return r_FisFullTypeNameSetExplicit;
			}
		}

		/// <summary>
		/// System.Boolean isAssemblyNameSetExplicit
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisAssemblyNameSetExplicit;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisAssemblyNameSetExplicit
		{
			get
			{
				if(r_FisAssemblyNameSetExplicit == null)
				{
					r_FisAssemblyNameSetExplicit = new(this, "isAssemblyNameSetExplicit");
				}
				return r_FisAssemblyNameSetExplicit;
			}
		}

		/// <summary>
		/// System.Boolean requireSameTokenInPartialTrust
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FrequireSameTokenInPartialTrust;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFrequireSameTokenInPartialTrust
		{
			get
			{
				if(r_FrequireSameTokenInPartialTrust == null)
				{
					r_FrequireSameTokenInPartialTrust = new(this, "requireSameTokenInPartialTrust");
				}
				return r_FrequireSameTokenInPartialTrust;
			}
		}

		/// <summary>
		/// System.String FullTypeName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PFullTypeName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPFullTypeName
		{
			get
			{
				if(r_PFullTypeName == null)
				{
					r_PFullTypeName = new(this, "FullTypeName", -1);
				}
				return r_PFullTypeName;
			}
		}

		/// <summary>
		/// System.String AssemblyName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PAssemblyName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPAssemblyName
		{
			get
			{
				if(r_PAssemblyName == null)
				{
					r_PAssemblyName = new(this, "AssemblyName", -1);
				}
				return r_PAssemblyName;
			}
		}

		/// <summary>
		/// Int32 MemberCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PMemberCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPMemberCount
		{
			get
			{
				if(r_PMemberCount == null)
				{
					r_PMemberCount = new(this, "MemberCount", -1);
				}
				return r_PMemberCount;
			}
		}

		/// <summary>
		/// System.Type ObjectType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_PObjectType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RPObjectType
		{
			get
			{
				if(r_PObjectType == null)
				{
					r_PObjectType = new(this, "ObjectType", -1);
				}
				return r_PObjectType;
			}
		}

		/// <summary>
		/// Boolean IsFullTypeNameSetExplicit
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsFullTypeNameSetExplicit;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsFullTypeNameSetExplicit
		{
			get
			{
				if(r_PIsFullTypeNameSetExplicit == null)
				{
					r_PIsFullTypeNameSetExplicit = new(this, "IsFullTypeNameSetExplicit", -1);
				}
				return r_PIsFullTypeNameSetExplicit;
			}
		}

		/// <summary>
		/// Boolean IsAssemblyNameSetExplicit
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsAssemblyNameSetExplicit;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsAssemblyNameSetExplicit
		{
			get
			{
				if(r_PIsAssemblyNameSetExplicit == null)
				{
					r_PIsAssemblyNameSetExplicit = new(this, "IsAssemblyNameSetExplicit", -1);
				}
				return r_PIsAssemblyNameSetExplicit;
			}
		}

		/// <summary>
		/// System.String[] MemberNames
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> r_PMemberNames;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RString> RPMemberNames
		{
			get
			{
				if(r_PMemberNames == null)
				{
					r_PMemberNames = new(this, "MemberNames", -1);
				}
				return r_PMemberNames;
			}
		}

		/// <summary>
		/// System.Object[] MemberValues
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RObject> r_PMemberValues;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RObject> RPMemberValues
		{
			get
			{
				if(r_PMemberValues == null)
				{
					r_PMemberValues = new(this, "MemberValues", -1);
				}
				return r_PMemberValues;
			}
		}

		/// <summary>
		/// Void SetType(System.Type)
		/// </summary>
		protected RMethod r_MSetType_Type;
		public virtual RMethod RMSetType_Type
		{
			get
			{
				if(r_MSetType_Type == null)
				{
					r_MSetType_Type = new(this, "SetType", 0, typeof(System.Type));
				}
				return r_MSetType_Type;
			}
		}

		/// <summary>
		/// Boolean Compare(Byte[], Byte[])
		/// </summary>
		protected static RMethod r_MCompare_ByteArray_ByteArray;
		public static RMethod RMCompare_ByteArray_ByteArray
		{
			get
			{
				if(r_MCompare_ByteArray_ByteArray == null)
				{
					r_MCompare_ByteArray_ByteArray = new(Type, "Compare", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType());
				}
				return r_MCompare_ByteArray_ByteArray;
			}
		}

		/// <summary>
		/// Void DemandForUnsafeAssemblyNameAssignments(System.String, System.String)
		/// </summary>
		protected static RMethod r_MDemandForUnsafeAssemblyNameAssignments_String_String;
		public static RMethod RMDemandForUnsafeAssemblyNameAssignments_String_String
		{
			get
			{
				if(r_MDemandForUnsafeAssemblyNameAssignments_String_String == null)
				{
					r_MDemandForUnsafeAssemblyNameAssignments_String_String = new(Type, "DemandForUnsafeAssemblyNameAssignments", 0, typeof(System.String), typeof(System.String));
				}
				return r_MDemandForUnsafeAssemblyNameAssignments_String_String;
			}
		}

		/// <summary>
		/// Boolean IsAssemblyNameAssignmentSafe(System.String, System.String)
		/// </summary>
		protected static RMethod r_MIsAssemblyNameAssignmentSafe_String_String;
		public static RMethod RMIsAssemblyNameAssignmentSafe_String_String
		{
			get
			{
				if(r_MIsAssemblyNameAssignmentSafe_String_String == null)
				{
					r_MIsAssemblyNameAssignmentSafe_String_String = new(Type, "IsAssemblyNameAssignmentSafe", 0, typeof(System.String), typeof(System.String));
				}
				return r_MIsAssemblyNameAssignmentSafe_String_String;
			}
		}

		/// <summary>
		/// System.Runtime.Serialization.SerializationInfoEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_MGetEnumerator;
		public virtual RMethod RMGetEnumerator
		{
			get
			{
				if(r_MGetEnumerator == null)
				{
					r_MGetEnumerator = new(this, "GetEnumerator", 0);
				}
				return r_MGetEnumerator;
			}
		}

		/// <summary>
		/// Void ExpandArrays()
		/// </summary>
		protected RMethod r_MExpandArrays;
		public virtual RMethod RMExpandArrays
		{
			get
			{
				if(r_MExpandArrays == null)
				{
					r_MExpandArrays = new(this, "ExpandArrays", 0);
				}
				return r_MExpandArrays;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, System.Object, System.Type)
		/// </summary>
		protected RMethod r_MAddValue_String_Object_Type;
		public virtual RMethod RMAddValue_String_Object_Type
		{
			get
			{
				if(r_MAddValue_String_Object_Type == null)
				{
					r_MAddValue_String_Object_Type = new(this, "AddValue", 0, typeof(System.String), typeof(System.Object), typeof(System.Type));
				}
				return r_MAddValue_String_Object_Type;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, System.Object)
		/// </summary>
		protected RMethod r_MAddValue_String_Object;
		public virtual RMethod RMAddValue_String_Object
		{
			get
			{
				if(r_MAddValue_String_Object == null)
				{
					r_MAddValue_String_Object = new(this, "AddValue", 0, typeof(System.String), typeof(System.Object));
				}
				return r_MAddValue_String_Object;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, Boolean)
		/// </summary>
		protected RMethod r_MAddValue_String_Boolean;
		public virtual RMethod RMAddValue_String_Boolean
		{
			get
			{
				if(r_MAddValue_String_Boolean == null)
				{
					r_MAddValue_String_Boolean = new(this, "AddValue", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MAddValue_String_Boolean;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, Char)
		/// </summary>
		protected RMethod r_MAddValue_String_Char;
		public virtual RMethod RMAddValue_String_Char
		{
			get
			{
				if(r_MAddValue_String_Char == null)
				{
					r_MAddValue_String_Char = new(this, "AddValue", 0, typeof(System.String), typeof(System.Char));
				}
				return r_MAddValue_String_Char;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, SByte)
		/// </summary>
		protected RMethod r_MAddValue_String_SByte;
		public virtual RMethod RMAddValue_String_SByte
		{
			get
			{
				if(r_MAddValue_String_SByte == null)
				{
					r_MAddValue_String_SByte = new(this, "AddValue", 0, typeof(System.String), typeof(System.SByte));
				}
				return r_MAddValue_String_SByte;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, Byte)
		/// </summary>
		protected RMethod r_MAddValue_String_Byte;
		public virtual RMethod RMAddValue_String_Byte
		{
			get
			{
				if(r_MAddValue_String_Byte == null)
				{
					r_MAddValue_String_Byte = new(this, "AddValue", 0, typeof(System.String), typeof(System.Byte));
				}
				return r_MAddValue_String_Byte;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, Int16)
		/// </summary>
		protected RMethod r_MAddValue_String_Int16;
		public virtual RMethod RMAddValue_String_Int16
		{
			get
			{
				if(r_MAddValue_String_Int16 == null)
				{
					r_MAddValue_String_Int16 = new(this, "AddValue", 0, typeof(System.String), typeof(System.Int16));
				}
				return r_MAddValue_String_Int16;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, UInt16)
		/// </summary>
		protected RMethod r_MAddValue_String_UInt16;
		public virtual RMethod RMAddValue_String_UInt16
		{
			get
			{
				if(r_MAddValue_String_UInt16 == null)
				{
					r_MAddValue_String_UInt16 = new(this, "AddValue", 0, typeof(System.String), typeof(System.UInt16));
				}
				return r_MAddValue_String_UInt16;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, Int32)
		/// </summary>
		protected RMethod r_MAddValue_String_Int32;
		public virtual RMethod RMAddValue_String_Int32
		{
			get
			{
				if(r_MAddValue_String_Int32 == null)
				{
					r_MAddValue_String_Int32 = new(this, "AddValue", 0, typeof(System.String), typeof(System.Int32));
				}
				return r_MAddValue_String_Int32;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, UInt32)
		/// </summary>
		protected RMethod r_MAddValue_String_UInt32;
		public virtual RMethod RMAddValue_String_UInt32
		{
			get
			{
				if(r_MAddValue_String_UInt32 == null)
				{
					r_MAddValue_String_UInt32 = new(this, "AddValue", 0, typeof(System.String), typeof(System.UInt32));
				}
				return r_MAddValue_String_UInt32;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, Int64)
		/// </summary>
		protected RMethod r_MAddValue_String_Int64;
		public virtual RMethod RMAddValue_String_Int64
		{
			get
			{
				if(r_MAddValue_String_Int64 == null)
				{
					r_MAddValue_String_Int64 = new(this, "AddValue", 0, typeof(System.String), typeof(System.Int64));
				}
				return r_MAddValue_String_Int64;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, UInt64)
		/// </summary>
		protected RMethod r_MAddValue_String_UInt64;
		public virtual RMethod RMAddValue_String_UInt64
		{
			get
			{
				if(r_MAddValue_String_UInt64 == null)
				{
					r_MAddValue_String_UInt64 = new(this, "AddValue", 0, typeof(System.String), typeof(System.UInt64));
				}
				return r_MAddValue_String_UInt64;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, Single)
		/// </summary>
		protected RMethod r_MAddValue_String_Single;
		public virtual RMethod RMAddValue_String_Single
		{
			get
			{
				if(r_MAddValue_String_Single == null)
				{
					r_MAddValue_String_Single = new(this, "AddValue", 0, typeof(System.String), typeof(System.Single));
				}
				return r_MAddValue_String_Single;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, Double)
		/// </summary>
		protected RMethod r_MAddValue_String_Double;
		public virtual RMethod RMAddValue_String_Double
		{
			get
			{
				if(r_MAddValue_String_Double == null)
				{
					r_MAddValue_String_Double = new(this, "AddValue", 0, typeof(System.String), typeof(System.Double));
				}
				return r_MAddValue_String_Double;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, System.Decimal)
		/// </summary>
		protected RMethod r_MAddValue_String_Decimal;
		public virtual RMethod RMAddValue_String_Decimal
		{
			get
			{
				if(r_MAddValue_String_Decimal == null)
				{
					r_MAddValue_String_Decimal = new(this, "AddValue", 0, typeof(System.String), typeof(System.Decimal));
				}
				return r_MAddValue_String_Decimal;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, System.DateTime)
		/// </summary>
		protected RMethod r_MAddValue_String_DateTime;
		public virtual RMethod RMAddValue_String_DateTime
		{
			get
			{
				if(r_MAddValue_String_DateTime == null)
				{
					r_MAddValue_String_DateTime = new(this, "AddValue", 0, typeof(System.String), typeof(System.DateTime));
				}
				return r_MAddValue_String_DateTime;
			}
		}

		/// <summary>
		/// Void AddValueInternal(System.String, System.Object, System.Type)
		/// </summary>
		protected RMethod r_MAddValueInternal_String_Object_Type;
		public virtual RMethod RMAddValueInternal_String_Object_Type
		{
			get
			{
				if(r_MAddValueInternal_String_Object_Type == null)
				{
					r_MAddValueInternal_String_Object_Type = new(this, "AddValueInternal", 0, typeof(System.String), typeof(System.Object), typeof(System.Type));
				}
				return r_MAddValueInternal_String_Object_Type;
			}
		}

		/// <summary>
		/// Void UpdateValue(System.String, System.Object, System.Type)
		/// </summary>
		protected RMethod r_MUpdateValue_String_Object_Type;
		public virtual RMethod RMUpdateValue_String_Object_Type
		{
			get
			{
				if(r_MUpdateValue_String_Object_Type == null)
				{
					r_MUpdateValue_String_Object_Type = new(this, "UpdateValue", 0, typeof(System.String), typeof(System.Object), typeof(System.Type));
				}
				return r_MUpdateValue_String_Object_Type;
			}
		}

		/// <summary>
		/// Int32 FindElement(System.String)
		/// </summary>
		protected RMethod r_MFindElement_String;
		public virtual RMethod RMFindElement_String
		{
			get
			{
				if(r_MFindElement_String == null)
				{
					r_MFindElement_String = new(this, "FindElement", 0, typeof(System.String));
				}
				return r_MFindElement_String;
			}
		}

		/// <summary>
		/// System.Object GetElement(System.String, System.Type ByRef)
		/// </summary>
		protected RMethod r_MGetElement_String_Out_Type;
		public virtual RMethod RMGetElement_String_Out_Type
		{
			get
			{
				if(r_MGetElement_String_Out_Type == null)
				{
					r_MGetElement_String_Out_Type = new(this, "GetElement", 0, typeof(System.String), typeof(System.Type).MakeByRefType());
				}
				return r_MGetElement_String_Out_Type;
			}
		}

		/// <summary>
		/// System.Object GetElementNoThrow(System.String, System.Type ByRef)
		/// </summary>
		protected RMethod r_MGetElementNoThrow_String_Out_Type;
		public virtual RMethod RMGetElementNoThrow_String_Out_Type
		{
			get
			{
				if(r_MGetElementNoThrow_String_Out_Type == null)
				{
					r_MGetElementNoThrow_String_Out_Type = new(this, "GetElementNoThrow", 0, typeof(System.String), typeof(System.Type).MakeByRefType());
				}
				return r_MGetElementNoThrow_String_Out_Type;
			}
		}

		/// <summary>
		/// System.Object GetValue(System.String, System.Type)
		/// </summary>
		protected RMethod r_MGetValue_String_Type;
		public virtual RMethod RMGetValue_String_Type
		{
			get
			{
				if(r_MGetValue_String_Type == null)
				{
					r_MGetValue_String_Type = new(this, "GetValue", 0, typeof(System.String), typeof(System.Type));
				}
				return r_MGetValue_String_Type;
			}
		}

		/// <summary>
		/// System.Object GetValueNoThrow(System.String, System.Type)
		/// </summary>
		protected RMethod r_MGetValueNoThrow_String_Type;
		public virtual RMethod RMGetValueNoThrow_String_Type
		{
			get
			{
				if(r_MGetValueNoThrow_String_Type == null)
				{
					r_MGetValueNoThrow_String_Type = new(this, "GetValueNoThrow", 0, typeof(System.String), typeof(System.Type));
				}
				return r_MGetValueNoThrow_String_Type;
			}
		}

		/// <summary>
		/// Boolean GetBoolean(System.String)
		/// </summary>
		protected RMethod r_MGetBoolean_String;
		public virtual RMethod RMGetBoolean_String
		{
			get
			{
				if(r_MGetBoolean_String == null)
				{
					r_MGetBoolean_String = new(this, "GetBoolean", 0, typeof(System.String));
				}
				return r_MGetBoolean_String;
			}
		}

		/// <summary>
		/// Char GetChar(System.String)
		/// </summary>
		protected RMethod r_MGetChar_String;
		public virtual RMethod RMGetChar_String
		{
			get
			{
				if(r_MGetChar_String == null)
				{
					r_MGetChar_String = new(this, "GetChar", 0, typeof(System.String));
				}
				return r_MGetChar_String;
			}
		}

		/// <summary>
		/// SByte GetSByte(System.String)
		/// </summary>
		protected RMethod r_MGetSByte_String;
		public virtual RMethod RMGetSByte_String
		{
			get
			{
				if(r_MGetSByte_String == null)
				{
					r_MGetSByte_String = new(this, "GetSByte", 0, typeof(System.String));
				}
				return r_MGetSByte_String;
			}
		}

		/// <summary>
		/// Byte GetByte(System.String)
		/// </summary>
		protected RMethod r_MGetByte_String;
		public virtual RMethod RMGetByte_String
		{
			get
			{
				if(r_MGetByte_String == null)
				{
					r_MGetByte_String = new(this, "GetByte", 0, typeof(System.String));
				}
				return r_MGetByte_String;
			}
		}

		/// <summary>
		/// Int16 GetInt16(System.String)
		/// </summary>
		protected RMethod r_MGetInt16_String;
		public virtual RMethod RMGetInt16_String
		{
			get
			{
				if(r_MGetInt16_String == null)
				{
					r_MGetInt16_String = new(this, "GetInt16", 0, typeof(System.String));
				}
				return r_MGetInt16_String;
			}
		}

		/// <summary>
		/// UInt16 GetUInt16(System.String)
		/// </summary>
		protected RMethod r_MGetUInt16_String;
		public virtual RMethod RMGetUInt16_String
		{
			get
			{
				if(r_MGetUInt16_String == null)
				{
					r_MGetUInt16_String = new(this, "GetUInt16", 0, typeof(System.String));
				}
				return r_MGetUInt16_String;
			}
		}

		/// <summary>
		/// Int32 GetInt32(System.String)
		/// </summary>
		protected RMethod r_MGetInt32_String;
		public virtual RMethod RMGetInt32_String
		{
			get
			{
				if(r_MGetInt32_String == null)
				{
					r_MGetInt32_String = new(this, "GetInt32", 0, typeof(System.String));
				}
				return r_MGetInt32_String;
			}
		}

		/// <summary>
		/// UInt32 GetUInt32(System.String)
		/// </summary>
		protected RMethod r_MGetUInt32_String;
		public virtual RMethod RMGetUInt32_String
		{
			get
			{
				if(r_MGetUInt32_String == null)
				{
					r_MGetUInt32_String = new(this, "GetUInt32", 0, typeof(System.String));
				}
				return r_MGetUInt32_String;
			}
		}

		/// <summary>
		/// Int64 GetInt64(System.String)
		/// </summary>
		protected RMethod r_MGetInt64_String;
		public virtual RMethod RMGetInt64_String
		{
			get
			{
				if(r_MGetInt64_String == null)
				{
					r_MGetInt64_String = new(this, "GetInt64", 0, typeof(System.String));
				}
				return r_MGetInt64_String;
			}
		}

		/// <summary>
		/// UInt64 GetUInt64(System.String)
		/// </summary>
		protected RMethod r_MGetUInt64_String;
		public virtual RMethod RMGetUInt64_String
		{
			get
			{
				if(r_MGetUInt64_String == null)
				{
					r_MGetUInt64_String = new(this, "GetUInt64", 0, typeof(System.String));
				}
				return r_MGetUInt64_String;
			}
		}

		/// <summary>
		/// Single GetSingle(System.String)
		/// </summary>
		protected RMethod r_MGetSingle_String;
		public virtual RMethod RMGetSingle_String
		{
			get
			{
				if(r_MGetSingle_String == null)
				{
					r_MGetSingle_String = new(this, "GetSingle", 0, typeof(System.String));
				}
				return r_MGetSingle_String;
			}
		}

		/// <summary>
		/// Double GetDouble(System.String)
		/// </summary>
		protected RMethod r_MGetDouble_String;
		public virtual RMethod RMGetDouble_String
		{
			get
			{
				if(r_MGetDouble_String == null)
				{
					r_MGetDouble_String = new(this, "GetDouble", 0, typeof(System.String));
				}
				return r_MGetDouble_String;
			}
		}

		/// <summary>
		/// System.Decimal GetDecimal(System.String)
		/// </summary>
		protected RMethod r_MGetDecimal_String;
		public virtual RMethod RMGetDecimal_String
		{
			get
			{
				if(r_MGetDecimal_String == null)
				{
					r_MGetDecimal_String = new(this, "GetDecimal", 0, typeof(System.String));
				}
				return r_MGetDecimal_String;
			}
		}

		/// <summary>
		/// System.DateTime GetDateTime(System.String)
		/// </summary>
		protected RMethod r_MGetDateTime_String;
		public virtual RMethod RMGetDateTime_String
		{
			get
			{
				if(r_MGetDateTime_String == null)
				{
					r_MGetDateTime_String = new(this, "GetDateTime", 0, typeof(System.String));
				}
				return r_MGetDateTime_String;
			}
		}

		/// <summary>
		/// System.String GetString(System.String)
		/// </summary>
		protected RMethod r_MGetString_String;
		public virtual RMethod RMGetString_String
		{
			get
			{
				if(r_MGetString_String == null)
				{
					r_MGetString_String = new(this, "GetString", 0, typeof(System.String));
				}
				return r_MGetString_String;
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


        public virtual void SetType(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMSetType_Type.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean Compare(System.Byte[] @a, System.Byte[] @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMCompare_ByteArray_ByteArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static void DemandForUnsafeAssemblyNameAssignments(System.String @originalAssemblyName, System.String @newAssemblyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@originalAssemblyName, @newAssemblyName};
            var ___result = RMDemandForUnsafeAssemblyNameAssignments_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsAssemblyNameAssignmentSafe(System.String @originalAssemblyName, System.String @newAssemblyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@originalAssemblyName, @newAssemblyName};
            var ___result = RMIsAssemblyNameAssignmentSafe_String_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Runtime.Serialization.SerializationInfoEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumerator.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Serialization.SerializationInfoEnumerator>(___result);
        }


        public virtual void ExpandArrays()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMExpandArrays.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String @name, System.Object @value, System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @type};
            var ___result = RMAddValue_String_Object_Type.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String @name, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddValue_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String @name, System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddValue_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String @name, System.Char @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddValue_String_Char.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String @name, System.SByte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddValue_String_SByte.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String @name, System.Byte @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddValue_String_Byte.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String @name, System.Int16 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddValue_String_Int16.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String @name, System.UInt16 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddValue_String_UInt16.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String @name, System.Int32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddValue_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String @name, System.UInt32 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddValue_String_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String @name, System.Int64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddValue_String_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String @name, System.UInt64 @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddValue_String_UInt64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String @name, System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddValue_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String @name, System.Double @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddValue_String_Double.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String @name, System.Decimal @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddValue_String_Decimal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String @name, System.DateTime @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RMAddValue_String_DateTime.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValueInternal(System.String @name, System.Object @value, System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @type};
            var ___result = RMAddValueInternal_String_Object_Type.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateValue(System.String @name, System.Object @value, System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @type};
            var ___result = RMUpdateValue_String_Object_Type.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 FindElement(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMFindElement_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Object GetElement(System.String @name, out System.Type @foundType)
        {
			@foundType = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @foundType};
            var ___result = RMGetElement_String_Out_Type.Invoke(___genericsType, ___parameters);
			@foundType = ReflectionUtils.Convert<System.Type>(___parameters[1]);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Object GetElementNoThrow(System.String @name, out System.Type @foundType)
        {
			@foundType = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @foundType};
            var ___result = RMGetElementNoThrow_String_Out_Type.Invoke(___genericsType, ___parameters);
			@foundType = ReflectionUtils.Convert<System.Type>(___parameters[1]);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Object GetValue(System.String @name, System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @type};
            var ___result = RMGetValue_String_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Object GetValueNoThrow(System.String @name, System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @type};
            var ___result = RMGetValueNoThrow_String_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Boolean GetBoolean(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetBoolean_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Char GetChar(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetChar_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Char>(___result);
        }


        public virtual System.SByte GetSByte(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetSByte_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.SByte>(___result);
        }


        public virtual System.Byte GetByte(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetByte_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte>(___result);
        }


        public virtual System.Int16 GetInt16(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetInt16_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int16>(___result);
        }


        public virtual System.UInt16 GetUInt16(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetUInt16_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt16>(___result);
        }


        public virtual System.Int32 GetInt32(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetInt32_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.UInt32 GetUInt32(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetUInt32_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt32>(___result);
        }


        public virtual System.Int64 GetInt64(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetInt64_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int64>(___result);
        }


        public virtual System.UInt64 GetUInt64(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetUInt64_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.UInt64>(___result);
        }


        public virtual System.Single GetSingle(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetSingle_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual System.Double GetDouble(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetDouble_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Double>(___result);
        }


        public virtual System.Decimal GetDecimal(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetDecimal_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Decimal>(___result);
        }


        public virtual System.DateTime GetDateTime(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetDateTime_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.DateTime>(___result);
        }


        public virtual System.String GetString(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
