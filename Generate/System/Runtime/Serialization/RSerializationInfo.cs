using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RSerialization
{
	/// <summary>
	/// System.Runtime.Serialization.SerializationInfo
	/// </summary>
    public partial class RSerializationInfo : RMember //
    {

		/// <summary>
		/// System.Int32 defaultSize
		/// </summary>
		protected static RField r_defaultSize;
		public static RField RdefaultSize
		{
			get
			{
				if(r_defaultSize == null)
				{
					r_defaultSize = new(typeof(System.Runtime.Serialization.SerializationInfo), "defaultSize");
					r_defaultSize.SetBelong(null);
				}
				return r_defaultSize;
			}
		}

		/// <summary>
		/// System.String s_mscorlibAssemblySimpleName
		/// </summary>
		protected static RField r_s_mscorlibAssemblySimpleName;
		public static RField Rs_mscorlibAssemblySimpleName
		{
			get
			{
				if(r_s_mscorlibAssemblySimpleName == null)
				{
					r_s_mscorlibAssemblySimpleName = new(typeof(System.Runtime.Serialization.SerializationInfo), "s_mscorlibAssemblySimpleName");
					r_s_mscorlibAssemblySimpleName.SetBelong(null);
				}
				return r_s_mscorlibAssemblySimpleName;
			}
		}

		/// <summary>
		/// System.String s_mscorlibFileName
		/// </summary>
		protected static RField r_s_mscorlibFileName;
		public static RField Rs_mscorlibFileName
		{
			get
			{
				if(r_s_mscorlibFileName == null)
				{
					r_s_mscorlibFileName = new(typeof(System.Runtime.Serialization.SerializationInfo), "s_mscorlibFileName");
					r_s_mscorlibFileName.SetBelong(null);
				}
				return r_s_mscorlibFileName;
			}
		}

		/// <summary>
		/// System.String[] m_members
		/// </summary>
		protected RFieldArray<RField> r_m_members;
		public virtual RFieldArray<RField> Rm_members
		{
			get
			{
				if(r_m_members == null)
				{
					r_m_members = new(this, "m_members");
					r_m_members.SetBelong(this.instance);
				}
				return r_m_members;
			}
		}

		/// <summary>
		/// System.Object[] m_data
		/// </summary>
		protected RFieldArray<RSystem.RObject> r_m_data;
		public virtual RFieldArray<RSystem.RObject> Rm_data
		{
			get
			{
				if(r_m_data == null)
				{
					r_m_data = new(this, "m_data");
					r_m_data.SetBelong(this.instance);
				}
				return r_m_data;
			}
		}

		/// <summary>
		/// System.Type[] m_types
		/// </summary>
		protected RFieldArray<RSystem.RType> r_m_types;
		public virtual RFieldArray<RSystem.RType> Rm_types
		{
			get
			{
				if(r_m_types == null)
				{
					r_m_types = new(this, "m_types");
					r_m_types.SetBelong(this.instance);
				}
				return r_m_types;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] m_nameToIndex
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r_m_nameToIndex;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> Rm_nameToIndex
		{
			get
			{
				if(r_m_nameToIndex == null)
				{
					r_m_nameToIndex = new(this, "m_nameToIndex");
					r_m_nameToIndex.SetBelong(this.instance);
				}
				return r_m_nameToIndex;
			}
		}

		/// <summary>
		/// System.Int32 m_currMember
		/// </summary>
		protected RField r_m_currMember;
		public virtual RField Rm_currMember
		{
			get
			{
				if(r_m_currMember == null)
				{
					r_m_currMember = new(this, "m_currMember");
					r_m_currMember.SetBelong(this.instance);
				}
				return r_m_currMember;
			}
		}

		/// <summary>
		/// System.Runtime.Serialization.IFormatterConverter m_converter
		/// </summary>
		protected RSystem.RRuntime.RSerialization.RIFormatterConverter r_m_converter;
		public virtual RSystem.RRuntime.RSerialization.RIFormatterConverter Rm_converter
		{
			get
			{
				if(r_m_converter == null)
				{
					r_m_converter = new(this, "m_converter");
					r_m_converter.SetBelong(this.instance);
				}
				return r_m_converter;
			}
		}

		/// <summary>
		/// System.String m_fullTypeName
		/// </summary>
		protected RField r_m_fullTypeName;
		public virtual RField Rm_fullTypeName
		{
			get
			{
				if(r_m_fullTypeName == null)
				{
					r_m_fullTypeName = new(this, "m_fullTypeName");
					r_m_fullTypeName.SetBelong(this.instance);
				}
				return r_m_fullTypeName;
			}
		}

		/// <summary>
		/// System.String m_assemName
		/// </summary>
		protected RField r_m_assemName;
		public virtual RField Rm_assemName
		{
			get
			{
				if(r_m_assemName == null)
				{
					r_m_assemName = new(this, "m_assemName");
					r_m_assemName.SetBelong(this.instance);
				}
				return r_m_assemName;
			}
		}

		/// <summary>
		/// System.Type objectType
		/// </summary>
		protected RSystem.RType r_objectType;
		public virtual RSystem.RType RobjectType
		{
			get
			{
				if(r_objectType == null)
				{
					r_objectType = new(this, "objectType");
					r_objectType.SetBelong(this.instance);
				}
				return r_objectType;
			}
		}

		/// <summary>
		/// System.Boolean isFullTypeNameSetExplicit
		/// </summary>
		protected RField r_isFullTypeNameSetExplicit;
		public virtual RField RisFullTypeNameSetExplicit
		{
			get
			{
				if(r_isFullTypeNameSetExplicit == null)
				{
					r_isFullTypeNameSetExplicit = new(this, "isFullTypeNameSetExplicit");
					r_isFullTypeNameSetExplicit.SetBelong(this.instance);
				}
				return r_isFullTypeNameSetExplicit;
			}
		}

		/// <summary>
		/// System.Boolean isAssemblyNameSetExplicit
		/// </summary>
		protected RField r_isAssemblyNameSetExplicit;
		public virtual RField RisAssemblyNameSetExplicit
		{
			get
			{
				if(r_isAssemblyNameSetExplicit == null)
				{
					r_isAssemblyNameSetExplicit = new(this, "isAssemblyNameSetExplicit");
					r_isAssemblyNameSetExplicit.SetBelong(this.instance);
				}
				return r_isAssemblyNameSetExplicit;
			}
		}

		/// <summary>
		/// System.Boolean requireSameTokenInPartialTrust
		/// </summary>
		protected RField r_requireSameTokenInPartialTrust;
		public virtual RField RrequireSameTokenInPartialTrust
		{
			get
			{
				if(r_requireSameTokenInPartialTrust == null)
				{
					r_requireSameTokenInPartialTrust = new(this, "requireSameTokenInPartialTrust");
					r_requireSameTokenInPartialTrust.SetBelong(this.instance);
				}
				return r_requireSameTokenInPartialTrust;
			}
		}

		/// <summary>
		/// System.String FullTypeName
		/// </summary>
		protected RProperty r_FullTypeName;
		public virtual RProperty RFullTypeName
		{
			get
			{
				if(r_FullTypeName == null)
				{
					r_FullTypeName = new(this, "FullTypeName", -1);
					r_FullTypeName.SetBelong(this.instance);
				}
				return r_FullTypeName;
			}
		}

		/// <summary>
		/// System.String AssemblyName
		/// </summary>
		protected RProperty r_AssemblyName;
		public virtual RProperty RAssemblyName
		{
			get
			{
				if(r_AssemblyName == null)
				{
					r_AssemblyName = new(this, "AssemblyName", -1);
					r_AssemblyName.SetBelong(this.instance);
				}
				return r_AssemblyName;
			}
		}

		/// <summary>
		/// Int32 MemberCount
		/// </summary>
		protected RProperty r_MemberCount;
		public virtual RProperty RMemberCount
		{
			get
			{
				if(r_MemberCount == null)
				{
					r_MemberCount = new(this, "MemberCount", -1);
					r_MemberCount.SetBelong(this.instance);
				}
				return r_MemberCount;
			}
		}

		/// <summary>
		/// System.Type ObjectType
		/// </summary>
		protected RSystem.RType r_ObjectType;
		public virtual RSystem.RType RObjectType
		{
			get
			{
				if(r_ObjectType == null)
				{
					r_ObjectType = new(this, "ObjectType", -1);
					r_ObjectType.SetBelong(this.instance);
				}
				return r_ObjectType;
			}
		}

		/// <summary>
		/// Boolean IsFullTypeNameSetExplicit
		/// </summary>
		protected RProperty r_IsFullTypeNameSetExplicit;
		public virtual RProperty RIsFullTypeNameSetExplicit
		{
			get
			{
				if(r_IsFullTypeNameSetExplicit == null)
				{
					r_IsFullTypeNameSetExplicit = new(this, "IsFullTypeNameSetExplicit", -1);
					r_IsFullTypeNameSetExplicit.SetBelong(this.instance);
				}
				return r_IsFullTypeNameSetExplicit;
			}
		}

		/// <summary>
		/// Boolean IsAssemblyNameSetExplicit
		/// </summary>
		protected RProperty r_IsAssemblyNameSetExplicit;
		public virtual RProperty RIsAssemblyNameSetExplicit
		{
			get
			{
				if(r_IsAssemblyNameSetExplicit == null)
				{
					r_IsAssemblyNameSetExplicit = new(this, "IsAssemblyNameSetExplicit", -1);
					r_IsAssemblyNameSetExplicit.SetBelong(this.instance);
				}
				return r_IsAssemblyNameSetExplicit;
			}
		}

		/// <summary>
		/// System.String[] MemberNames
		/// </summary>
		protected RPropertyArray<RProperty> r_MemberNames;
		public virtual RPropertyArray<RProperty> RMemberNames
		{
			get
			{
				if(r_MemberNames == null)
				{
					r_MemberNames = new(this, "MemberNames", -1);
					r_MemberNames.SetBelong(this.instance);
				}
				return r_MemberNames;
			}
		}

		/// <summary>
		/// System.Object[] MemberValues
		/// </summary>
		protected RPropertyArray<RSystem.RObject> r_MemberValues;
		public virtual RPropertyArray<RSystem.RObject> RMemberValues
		{
			get
			{
				if(r_MemberValues == null)
				{
					r_MemberValues = new(this, "MemberValues", -1);
					r_MemberValues.SetBelong(this.instance);
				}
				return r_MemberValues;
			}
		}

		/// <summary>
		/// Void SetType(System.Type)
		/// </summary>
		protected RMethod r_SetType_Type;
		public virtual RMethod RSetType_Type
		{
			get
			{
				if(r_SetType_Type == null)
				{
					r_SetType_Type = new(this, "SetType", 0, typeof(System.Type));
					r_SetType_Type.SetBelong(this.instance);
				}
				return r_SetType_Type;
			}
		}

		/// <summary>
		/// Boolean Compare(Byte[], Byte[])
		/// </summary>
		protected static RMethod r_Compare_ByteArray_ByteArray;
		public static RMethod RCompare_ByteArray_ByteArray
		{
			get
			{
				if(r_Compare_ByteArray_ByteArray == null)
				{
					r_Compare_ByteArray_ByteArray = new(typeof(System.Runtime.Serialization.SerializationInfo), "Compare", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType());
					r_Compare_ByteArray_ByteArray.SetBelong(null);
				}
				return r_Compare_ByteArray_ByteArray;
			}
		}

		/// <summary>
		/// Void DemandForUnsafeAssemblyNameAssignments(System.String, System.String)
		/// </summary>
		protected static RMethod r_DemandForUnsafeAssemblyNameAssignments_String_String;
		public static RMethod RDemandForUnsafeAssemblyNameAssignments_String_String
		{
			get
			{
				if(r_DemandForUnsafeAssemblyNameAssignments_String_String == null)
				{
					r_DemandForUnsafeAssemblyNameAssignments_String_String = new(typeof(System.Runtime.Serialization.SerializationInfo), "DemandForUnsafeAssemblyNameAssignments", 0, typeof(System.String), typeof(System.String));
					r_DemandForUnsafeAssemblyNameAssignments_String_String.SetBelong(null);
				}
				return r_DemandForUnsafeAssemblyNameAssignments_String_String;
			}
		}

		/// <summary>
		/// Boolean IsAssemblyNameAssignmentSafe(System.String, System.String)
		/// </summary>
		protected static RMethod r_IsAssemblyNameAssignmentSafe_String_String;
		public static RMethod RIsAssemblyNameAssignmentSafe_String_String
		{
			get
			{
				if(r_IsAssemblyNameAssignmentSafe_String_String == null)
				{
					r_IsAssemblyNameAssignmentSafe_String_String = new(typeof(System.Runtime.Serialization.SerializationInfo), "IsAssemblyNameAssignmentSafe", 0, typeof(System.String), typeof(System.String));
					r_IsAssemblyNameAssignmentSafe_String_String.SetBelong(null);
				}
				return r_IsAssemblyNameAssignmentSafe_String_String;
			}
		}

		/// <summary>
		/// System.Runtime.Serialization.SerializationInfoEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_GetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_GetEnumerator == null)
				{
					r_GetEnumerator = new(this, "GetEnumerator", 0);
					r_GetEnumerator.SetBelong(this.instance);
				}
				return r_GetEnumerator;
			}
		}

		/// <summary>
		/// Void ExpandArrays()
		/// </summary>
		protected RMethod r_ExpandArrays;
		public virtual RMethod RExpandArrays
		{
			get
			{
				if(r_ExpandArrays == null)
				{
					r_ExpandArrays = new(this, "ExpandArrays", 0);
					r_ExpandArrays.SetBelong(this.instance);
				}
				return r_ExpandArrays;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, System.Object, System.Type)
		/// </summary>
		protected RMethod r_AddValue_String_Object_Type;
		public virtual RMethod RAddValue_String_Object_Type
		{
			get
			{
				if(r_AddValue_String_Object_Type == null)
				{
					r_AddValue_String_Object_Type = new(this, "AddValue", 0, typeof(System.String), typeof(System.Object), typeof(System.Type));
					r_AddValue_String_Object_Type.SetBelong(this.instance);
				}
				return r_AddValue_String_Object_Type;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, System.Object)
		/// </summary>
		protected RMethod r_AddValue_String_Object;
		public virtual RMethod RAddValue_String_Object
		{
			get
			{
				if(r_AddValue_String_Object == null)
				{
					r_AddValue_String_Object = new(this, "AddValue", 0, typeof(System.String), typeof(System.Object));
					r_AddValue_String_Object.SetBelong(this.instance);
				}
				return r_AddValue_String_Object;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, Boolean)
		/// </summary>
		protected RMethod r_AddValue_String_Boolean;
		public virtual RMethod RAddValue_String_Boolean
		{
			get
			{
				if(r_AddValue_String_Boolean == null)
				{
					r_AddValue_String_Boolean = new(this, "AddValue", 0, typeof(System.String), typeof(System.Boolean));
					r_AddValue_String_Boolean.SetBelong(this.instance);
				}
				return r_AddValue_String_Boolean;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, Char)
		/// </summary>
		protected RMethod r_AddValue_String_Char;
		public virtual RMethod RAddValue_String_Char
		{
			get
			{
				if(r_AddValue_String_Char == null)
				{
					r_AddValue_String_Char = new(this, "AddValue", 0, typeof(System.String), typeof(System.Char));
					r_AddValue_String_Char.SetBelong(this.instance);
				}
				return r_AddValue_String_Char;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, SByte)
		/// </summary>
		protected RMethod r_AddValue_String_SByte;
		public virtual RMethod RAddValue_String_SByte
		{
			get
			{
				if(r_AddValue_String_SByte == null)
				{
					r_AddValue_String_SByte = new(this, "AddValue", 0, typeof(System.String), typeof(System.SByte));
					r_AddValue_String_SByte.SetBelong(this.instance);
				}
				return r_AddValue_String_SByte;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, Byte)
		/// </summary>
		protected RMethod r_AddValue_String_Byte;
		public virtual RMethod RAddValue_String_Byte
		{
			get
			{
				if(r_AddValue_String_Byte == null)
				{
					r_AddValue_String_Byte = new(this, "AddValue", 0, typeof(System.String), typeof(System.Byte));
					r_AddValue_String_Byte.SetBelong(this.instance);
				}
				return r_AddValue_String_Byte;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, Int16)
		/// </summary>
		protected RMethod r_AddValue_String_Int16;
		public virtual RMethod RAddValue_String_Int16
		{
			get
			{
				if(r_AddValue_String_Int16 == null)
				{
					r_AddValue_String_Int16 = new(this, "AddValue", 0, typeof(System.String), typeof(System.Int16));
					r_AddValue_String_Int16.SetBelong(this.instance);
				}
				return r_AddValue_String_Int16;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, UInt16)
		/// </summary>
		protected RMethod r_AddValue_String_UInt16;
		public virtual RMethod RAddValue_String_UInt16
		{
			get
			{
				if(r_AddValue_String_UInt16 == null)
				{
					r_AddValue_String_UInt16 = new(this, "AddValue", 0, typeof(System.String), typeof(System.UInt16));
					r_AddValue_String_UInt16.SetBelong(this.instance);
				}
				return r_AddValue_String_UInt16;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, Int32)
		/// </summary>
		protected RMethod r_AddValue_String_Int32;
		public virtual RMethod RAddValue_String_Int32
		{
			get
			{
				if(r_AddValue_String_Int32 == null)
				{
					r_AddValue_String_Int32 = new(this, "AddValue", 0, typeof(System.String), typeof(System.Int32));
					r_AddValue_String_Int32.SetBelong(this.instance);
				}
				return r_AddValue_String_Int32;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, UInt32)
		/// </summary>
		protected RMethod r_AddValue_String_UInt32;
		public virtual RMethod RAddValue_String_UInt32
		{
			get
			{
				if(r_AddValue_String_UInt32 == null)
				{
					r_AddValue_String_UInt32 = new(this, "AddValue", 0, typeof(System.String), typeof(System.UInt32));
					r_AddValue_String_UInt32.SetBelong(this.instance);
				}
				return r_AddValue_String_UInt32;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, Int64)
		/// </summary>
		protected RMethod r_AddValue_String_Int64;
		public virtual RMethod RAddValue_String_Int64
		{
			get
			{
				if(r_AddValue_String_Int64 == null)
				{
					r_AddValue_String_Int64 = new(this, "AddValue", 0, typeof(System.String), typeof(System.Int64));
					r_AddValue_String_Int64.SetBelong(this.instance);
				}
				return r_AddValue_String_Int64;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, UInt64)
		/// </summary>
		protected RMethod r_AddValue_String_UInt64;
		public virtual RMethod RAddValue_String_UInt64
		{
			get
			{
				if(r_AddValue_String_UInt64 == null)
				{
					r_AddValue_String_UInt64 = new(this, "AddValue", 0, typeof(System.String), typeof(System.UInt64));
					r_AddValue_String_UInt64.SetBelong(this.instance);
				}
				return r_AddValue_String_UInt64;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, Single)
		/// </summary>
		protected RMethod r_AddValue_String_Single;
		public virtual RMethod RAddValue_String_Single
		{
			get
			{
				if(r_AddValue_String_Single == null)
				{
					r_AddValue_String_Single = new(this, "AddValue", 0, typeof(System.String), typeof(System.Single));
					r_AddValue_String_Single.SetBelong(this.instance);
				}
				return r_AddValue_String_Single;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, Double)
		/// </summary>
		protected RMethod r_AddValue_String_Double;
		public virtual RMethod RAddValue_String_Double
		{
			get
			{
				if(r_AddValue_String_Double == null)
				{
					r_AddValue_String_Double = new(this, "AddValue", 0, typeof(System.String), typeof(System.Double));
					r_AddValue_String_Double.SetBelong(this.instance);
				}
				return r_AddValue_String_Double;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, System.Decimal)
		/// </summary>
		protected RMethod r_AddValue_String_Decimal;
		public virtual RMethod RAddValue_String_Decimal
		{
			get
			{
				if(r_AddValue_String_Decimal == null)
				{
					r_AddValue_String_Decimal = new(this, "AddValue", 0, typeof(System.String), typeof(System.Decimal));
					r_AddValue_String_Decimal.SetBelong(this.instance);
				}
				return r_AddValue_String_Decimal;
			}
		}

		/// <summary>
		/// Void AddValue(System.String, System.DateTime)
		/// </summary>
		protected RMethod r_AddValue_String_DateTime;
		public virtual RMethod RAddValue_String_DateTime
		{
			get
			{
				if(r_AddValue_String_DateTime == null)
				{
					r_AddValue_String_DateTime = new(this, "AddValue", 0, typeof(System.String), typeof(System.DateTime));
					r_AddValue_String_DateTime.SetBelong(this.instance);
				}
				return r_AddValue_String_DateTime;
			}
		}

		/// <summary>
		/// Void AddValueInternal(System.String, System.Object, System.Type)
		/// </summary>
		protected RMethod r_AddValueInternal_String_Object_Type;
		public virtual RMethod RAddValueInternal_String_Object_Type
		{
			get
			{
				if(r_AddValueInternal_String_Object_Type == null)
				{
					r_AddValueInternal_String_Object_Type = new(this, "AddValueInternal", 0, typeof(System.String), typeof(System.Object), typeof(System.Type));
					r_AddValueInternal_String_Object_Type.SetBelong(this.instance);
				}
				return r_AddValueInternal_String_Object_Type;
			}
		}

		/// <summary>
		/// Void UpdateValue(System.String, System.Object, System.Type)
		/// </summary>
		protected RMethod r_UpdateValue_String_Object_Type;
		public virtual RMethod RUpdateValue_String_Object_Type
		{
			get
			{
				if(r_UpdateValue_String_Object_Type == null)
				{
					r_UpdateValue_String_Object_Type = new(this, "UpdateValue", 0, typeof(System.String), typeof(System.Object), typeof(System.Type));
					r_UpdateValue_String_Object_Type.SetBelong(this.instance);
				}
				return r_UpdateValue_String_Object_Type;
			}
		}

		/// <summary>
		/// Int32 FindElement(System.String)
		/// </summary>
		protected RMethod r_FindElement_String;
		public virtual RMethod RFindElement_String
		{
			get
			{
				if(r_FindElement_String == null)
				{
					r_FindElement_String = new(this, "FindElement", 0, typeof(System.String));
					r_FindElement_String.SetBelong(this.instance);
				}
				return r_FindElement_String;
			}
		}

		/// <summary>
		/// System.Object GetElement(System.String, System.Type ByRef)
		/// </summary>
		protected RMethod r_GetElement_String_Out_Type;
		public virtual RMethod RGetElement_String_Out_Type
		{
			get
			{
				if(r_GetElement_String_Out_Type == null)
				{
					r_GetElement_String_Out_Type = new(this, "GetElement", 0, typeof(System.String), typeof(System.Type).MakeByRefType());
					r_GetElement_String_Out_Type.SetBelong(this.instance);
				}
				return r_GetElement_String_Out_Type;
			}
		}

		/// <summary>
		/// System.Object GetElementNoThrow(System.String, System.Type ByRef)
		/// </summary>
		protected RMethod r_GetElementNoThrow_String_Out_Type;
		public virtual RMethod RGetElementNoThrow_String_Out_Type
		{
			get
			{
				if(r_GetElementNoThrow_String_Out_Type == null)
				{
					r_GetElementNoThrow_String_Out_Type = new(this, "GetElementNoThrow", 0, typeof(System.String), typeof(System.Type).MakeByRefType());
					r_GetElementNoThrow_String_Out_Type.SetBelong(this.instance);
				}
				return r_GetElementNoThrow_String_Out_Type;
			}
		}

		/// <summary>
		/// System.Object GetValue(System.String, System.Type)
		/// </summary>
		protected RMethod r_GetValue_String_Type;
		public virtual RMethod RGetValue_String_Type
		{
			get
			{
				if(r_GetValue_String_Type == null)
				{
					r_GetValue_String_Type = new(this, "GetValue", 0, typeof(System.String), typeof(System.Type));
					r_GetValue_String_Type.SetBelong(this.instance);
				}
				return r_GetValue_String_Type;
			}
		}

		/// <summary>
		/// System.Object GetValueNoThrow(System.String, System.Type)
		/// </summary>
		protected RMethod r_GetValueNoThrow_String_Type;
		public virtual RMethod RGetValueNoThrow_String_Type
		{
			get
			{
				if(r_GetValueNoThrow_String_Type == null)
				{
					r_GetValueNoThrow_String_Type = new(this, "GetValueNoThrow", 0, typeof(System.String), typeof(System.Type));
					r_GetValueNoThrow_String_Type.SetBelong(this.instance);
				}
				return r_GetValueNoThrow_String_Type;
			}
		}

		/// <summary>
		/// Boolean GetBoolean(System.String)
		/// </summary>
		protected RMethod r_GetBoolean_String;
		public virtual RMethod RGetBoolean_String
		{
			get
			{
				if(r_GetBoolean_String == null)
				{
					r_GetBoolean_String = new(this, "GetBoolean", 0, typeof(System.String));
					r_GetBoolean_String.SetBelong(this.instance);
				}
				return r_GetBoolean_String;
			}
		}

		/// <summary>
		/// Char GetChar(System.String)
		/// </summary>
		protected RMethod r_GetChar_String;
		public virtual RMethod RGetChar_String
		{
			get
			{
				if(r_GetChar_String == null)
				{
					r_GetChar_String = new(this, "GetChar", 0, typeof(System.String));
					r_GetChar_String.SetBelong(this.instance);
				}
				return r_GetChar_String;
			}
		}

		/// <summary>
		/// SByte GetSByte(System.String)
		/// </summary>
		protected RMethod r_GetSByte_String;
		public virtual RMethod RGetSByte_String
		{
			get
			{
				if(r_GetSByte_String == null)
				{
					r_GetSByte_String = new(this, "GetSByte", 0, typeof(System.String));
					r_GetSByte_String.SetBelong(this.instance);
				}
				return r_GetSByte_String;
			}
		}

		/// <summary>
		/// Byte GetByte(System.String)
		/// </summary>
		protected RMethod r_GetByte_String;
		public virtual RMethod RGetByte_String
		{
			get
			{
				if(r_GetByte_String == null)
				{
					r_GetByte_String = new(this, "GetByte", 0, typeof(System.String));
					r_GetByte_String.SetBelong(this.instance);
				}
				return r_GetByte_String;
			}
		}

		/// <summary>
		/// Int16 GetInt16(System.String)
		/// </summary>
		protected RMethod r_GetInt16_String;
		public virtual RMethod RGetInt16_String
		{
			get
			{
				if(r_GetInt16_String == null)
				{
					r_GetInt16_String = new(this, "GetInt16", 0, typeof(System.String));
					r_GetInt16_String.SetBelong(this.instance);
				}
				return r_GetInt16_String;
			}
		}

		/// <summary>
		/// UInt16 GetUInt16(System.String)
		/// </summary>
		protected RMethod r_GetUInt16_String;
		public virtual RMethod RGetUInt16_String
		{
			get
			{
				if(r_GetUInt16_String == null)
				{
					r_GetUInt16_String = new(this, "GetUInt16", 0, typeof(System.String));
					r_GetUInt16_String.SetBelong(this.instance);
				}
				return r_GetUInt16_String;
			}
		}

		/// <summary>
		/// Int32 GetInt32(System.String)
		/// </summary>
		protected RMethod r_GetInt32_String;
		public virtual RMethod RGetInt32_String
		{
			get
			{
				if(r_GetInt32_String == null)
				{
					r_GetInt32_String = new(this, "GetInt32", 0, typeof(System.String));
					r_GetInt32_String.SetBelong(this.instance);
				}
				return r_GetInt32_String;
			}
		}

		/// <summary>
		/// UInt32 GetUInt32(System.String)
		/// </summary>
		protected RMethod r_GetUInt32_String;
		public virtual RMethod RGetUInt32_String
		{
			get
			{
				if(r_GetUInt32_String == null)
				{
					r_GetUInt32_String = new(this, "GetUInt32", 0, typeof(System.String));
					r_GetUInt32_String.SetBelong(this.instance);
				}
				return r_GetUInt32_String;
			}
		}

		/// <summary>
		/// Int64 GetInt64(System.String)
		/// </summary>
		protected RMethod r_GetInt64_String;
		public virtual RMethod RGetInt64_String
		{
			get
			{
				if(r_GetInt64_String == null)
				{
					r_GetInt64_String = new(this, "GetInt64", 0, typeof(System.String));
					r_GetInt64_String.SetBelong(this.instance);
				}
				return r_GetInt64_String;
			}
		}

		/// <summary>
		/// UInt64 GetUInt64(System.String)
		/// </summary>
		protected RMethod r_GetUInt64_String;
		public virtual RMethod RGetUInt64_String
		{
			get
			{
				if(r_GetUInt64_String == null)
				{
					r_GetUInt64_String = new(this, "GetUInt64", 0, typeof(System.String));
					r_GetUInt64_String.SetBelong(this.instance);
				}
				return r_GetUInt64_String;
			}
		}

		/// <summary>
		/// Single GetSingle(System.String)
		/// </summary>
		protected RMethod r_GetSingle_String;
		public virtual RMethod RGetSingle_String
		{
			get
			{
				if(r_GetSingle_String == null)
				{
					r_GetSingle_String = new(this, "GetSingle", 0, typeof(System.String));
					r_GetSingle_String.SetBelong(this.instance);
				}
				return r_GetSingle_String;
			}
		}

		/// <summary>
		/// Double GetDouble(System.String)
		/// </summary>
		protected RMethod r_GetDouble_String;
		public virtual RMethod RGetDouble_String
		{
			get
			{
				if(r_GetDouble_String == null)
				{
					r_GetDouble_String = new(this, "GetDouble", 0, typeof(System.String));
					r_GetDouble_String.SetBelong(this.instance);
				}
				return r_GetDouble_String;
			}
		}

		/// <summary>
		/// System.Decimal GetDecimal(System.String)
		/// </summary>
		protected RMethod r_GetDecimal_String;
		public virtual RMethod RGetDecimal_String
		{
			get
			{
				if(r_GetDecimal_String == null)
				{
					r_GetDecimal_String = new(this, "GetDecimal", 0, typeof(System.String));
					r_GetDecimal_String.SetBelong(this.instance);
				}
				return r_GetDecimal_String;
			}
		}

		/// <summary>
		/// System.DateTime GetDateTime(System.String)
		/// </summary>
		protected RMethod r_GetDateTime_String;
		public virtual RMethod RGetDateTime_String
		{
			get
			{
				if(r_GetDateTime_String == null)
				{
					r_GetDateTime_String = new(this, "GetDateTime", 0, typeof(System.String));
					r_GetDateTime_String.SetBelong(this.instance);
				}
				return r_GetDateTime_String;
			}
		}

		/// <summary>
		/// System.String GetString(System.String)
		/// </summary>
		protected RMethod r_GetString_String;
		public virtual RMethod RGetString_String
		{
			get
			{
				if(r_GetString_String == null)
				{
					r_GetString_String = new(this, "GetString", 0, typeof(System.String));
					r_GetString_String.SetBelong(this.instance);
				}
				return r_GetString_String;
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

        public virtual void SetType(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RSetType_Type.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean Compare(System.Byte[]  @a, System.Byte[]  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RCompare_ByteArray_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void DemandForUnsafeAssemblyNameAssignments(System.String  @originalAssemblyName, System.String  @newAssemblyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@originalAssemblyName, @newAssemblyName};
            var ___result = RDemandForUnsafeAssemblyNameAssignments_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsAssemblyNameAssignmentSafe(System.String  @originalAssemblyName, System.String  @newAssemblyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@originalAssemblyName, @newAssemblyName};
            var ___result = RIsAssemblyNameAssignmentSafe_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Runtime.Serialization.SerializationInfoEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Serialization.SerializationInfoEnumerator)___result;
        }


        public virtual void ExpandArrays()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RExpandArrays.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String  @name, System.Object  @value, System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @type};
            var ___result = RAddValue_String_Object_Type.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String  @name, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddValue_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String  @name, System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddValue_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String  @name, System.Char  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddValue_String_Char.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String  @name, System.SByte  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddValue_String_SByte.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String  @name, System.Byte  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddValue_String_Byte.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String  @name, System.Int16  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddValue_String_Int16.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String  @name, System.UInt16  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddValue_String_UInt16.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String  @name, System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddValue_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String  @name, System.UInt32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddValue_String_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String  @name, System.Int64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddValue_String_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String  @name, System.UInt64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddValue_String_UInt64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String  @name, System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddValue_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String  @name, System.Double  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddValue_String_Double.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String  @name, System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddValue_String_Decimal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValue(System.String  @name, System.DateTime  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value};
            var ___result = RAddValue_String_DateTime.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddValueInternal(System.String  @name, System.Object  @value, System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @type};
            var ___result = RAddValueInternal_String_Object_Type.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateValue(System.String  @name, System.Object  @value, System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @value, @type};
            var ___result = RUpdateValue_String_Object_Type.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 FindElement(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RFindElement_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Object GetElement(System.String  @name, out System.Type  @foundType)
        {
			foundType = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @foundType};
            var ___result = RGetElement_String_Out_Type.Invoke(___genericsType, ___parameters);
			foundType = (System.Type)___parameters[1];

            return (System.Object)___result;
        }


        public virtual System.Object GetElementNoThrow(System.String  @name, out System.Type  @foundType)
        {
			foundType = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @foundType};
            var ___result = RGetElementNoThrow_String_Out_Type.Invoke(___genericsType, ___parameters);
			foundType = (System.Type)___parameters[1];

            return (System.Object)___result;
        }


        public virtual System.Object GetValue(System.String  @name, System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @type};
            var ___result = RGetValue_String_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetValueNoThrow(System.String  @name, System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @type};
            var ___result = RGetValueNoThrow_String_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean GetBoolean(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetBoolean_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Char GetChar(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetChar_String.Invoke(___genericsType, ___parameters);

            return (System.Char)___result;
        }


        public virtual System.SByte GetSByte(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetSByte_String.Invoke(___genericsType, ___parameters);

            return (System.SByte)___result;
        }


        public virtual System.Byte GetByte(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetByte_String.Invoke(___genericsType, ___parameters);

            return (System.Byte)___result;
        }


        public virtual System.Int16 GetInt16(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetInt16_String.Invoke(___genericsType, ___parameters);

            return (System.Int16)___result;
        }


        public virtual System.UInt16 GetUInt16(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetUInt16_String.Invoke(___genericsType, ___parameters);

            return (System.UInt16)___result;
        }


        public virtual System.Int32 GetInt32(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetInt32_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.UInt32 GetUInt32(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetUInt32_String.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual System.Int64 GetInt64(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetInt64_String.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.UInt64 GetUInt64(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetUInt64_String.Invoke(___genericsType, ___parameters);

            return (System.UInt64)___result;
        }


        public virtual System.Single GetSingle(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetSingle_String.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Double GetDouble(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetDouble_String.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Decimal GetDecimal(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetDecimal_String.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.DateTime GetDateTime(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetDateTime_String.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.String GetString(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
