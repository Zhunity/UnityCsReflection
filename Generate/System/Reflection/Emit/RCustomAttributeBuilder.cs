using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.CustomAttributeBuilder
	/// </summary>
    public partial class RCustomAttributeBuilder : RMember //
    {

		/// <summary>
		/// System.Reflection.ConstructorInfo ctor
		/// </summary>
		protected RSystem.RReflection.RConstructorInfo r_ctor;
		public virtual RSystem.RReflection.RConstructorInfo Rctor
		{
			get
			{
				if(r_ctor == null)
				{
					r_ctor = new(this, "ctor");
					r_ctor.SetBelong(this.instance);
				}
				return r_ctor;
			}
		}

		/// <summary>
		/// System.Byte[] data
		/// </summary>
		protected RFieldArray<RField> r_data;
		public virtual RFieldArray<RField> Rdata
		{
			get
			{
				if(r_data == null)
				{
					r_data = new(this, "data");
					r_data.SetBelong(this.instance);
				}
				return r_data;
			}
		}

		/// <summary>
		/// System.Object[] args
		/// </summary>
		protected RFieldArray<RSystem.RObject> r_args;
		public virtual RFieldArray<RSystem.RObject> Rargs
		{
			get
			{
				if(r_args == null)
				{
					r_args = new(this, "args");
					r_args.SetBelong(this.instance);
				}
				return r_args;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo[] namedProperties
		/// </summary>
		protected RFieldArray<RSystem.RReflection.RPropertyInfo> r_namedProperties;
		public virtual RFieldArray<RSystem.RReflection.RPropertyInfo> RnamedProperties
		{
			get
			{
				if(r_namedProperties == null)
				{
					r_namedProperties = new(this, "namedProperties");
					r_namedProperties.SetBelong(this.instance);
				}
				return r_namedProperties;
			}
		}

		/// <summary>
		/// System.Object[] propertyValues
		/// </summary>
		protected RFieldArray<RSystem.RObject> r_propertyValues;
		public virtual RFieldArray<RSystem.RObject> RpropertyValues
		{
			get
			{
				if(r_propertyValues == null)
				{
					r_propertyValues = new(this, "propertyValues");
					r_propertyValues.SetBelong(this.instance);
				}
				return r_propertyValues;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo[] namedFields
		/// </summary>
		protected RFieldArray<RSystem.RReflection.RFieldInfo> r_namedFields;
		public virtual RFieldArray<RSystem.RReflection.RFieldInfo> RnamedFields
		{
			get
			{
				if(r_namedFields == null)
				{
					r_namedFields = new(this, "namedFields");
					r_namedFields.SetBelong(this.instance);
				}
				return r_namedFields;
			}
		}

		/// <summary>
		/// System.Object[] fieldValues
		/// </summary>
		protected RFieldArray<RSystem.RObject> r_fieldValues;
		public virtual RFieldArray<RSystem.RObject> RfieldValues
		{
			get
			{
				if(r_fieldValues == null)
				{
					r_fieldValues = new(this, "fieldValues");
					r_fieldValues.SetBelong(this.instance);
				}
				return r_fieldValues;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo Ctor
		/// </summary>
		protected RSystem.RReflection.RConstructorInfo r_Ctor;
		public virtual RSystem.RReflection.RConstructorInfo RCtor
		{
			get
			{
				if(r_Ctor == null)
				{
					r_Ctor = new(this, "Ctor", -1);
					r_Ctor.SetBelong(this.instance);
				}
				return r_Ctor;
			}
		}

		/// <summary>
		/// Byte[] Data
		/// </summary>
		protected RPropertyArray<RProperty> r_Data;
		public virtual RPropertyArray<RProperty> RData
		{
			get
			{
				if(r_Data == null)
				{
					r_Data = new(this, "Data", -1);
					r_Data.SetBelong(this.instance);
				}
				return r_Data;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._CustomAttributeBuilder.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._CustomAttributeBuilder.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._CustomAttributeBuilder.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._CustomAttributeBuilder.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._CustomAttributeBuilder.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._CustomAttributeBuilder.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._CustomAttributeBuilder.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._CustomAttributeBuilder.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Byte[] GetBlob(System.Reflection.Assembly, System.Reflection.ConstructorInfo, System.Object[], System.Reflection.PropertyInfo[], System.Object[], System.Reflection.FieldInfo[], System.Object[])
		/// </summary>
		protected static RMethod r_GetBlob_Assembly_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray;
		public static RMethod RGetBlob_Assembly_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray
		{
			get
			{
				if(r_GetBlob_Assembly_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray == null)
				{
					r_GetBlob_Assembly_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray = new(typeof(System.Reflection.Emit.CustomAttributeBuilder), "GetBlob", 0, typeof(System.Reflection.Assembly), typeof(System.Reflection.ConstructorInfo), typeof(System.Object).MakeArrayType(), typeof(System.Reflection.PropertyInfo).MakeArrayType(), typeof(System.Object).MakeArrayType(), typeof(System.Reflection.FieldInfo).MakeArrayType(), typeof(System.Object).MakeArrayType());
					r_GetBlob_Assembly_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray.SetBelong(null);
				}
				return r_GetBlob_Assembly_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object Invoke()
		/// </summary>
		protected RMethod r_Invoke;
		public virtual RMethod RInvoke
		{
			get
			{
				if(r_Invoke == null)
				{
					r_Invoke = new(this, "Invoke", 0);
					r_Invoke.SetBelong(this.instance);
				}
				return r_Invoke;
			}
		}

		/// <summary>
		/// Boolean IsValidType(System.Type)
		/// </summary>
		protected RMethod r_IsValidType_Type;
		public virtual RMethod RIsValidType_Type
		{
			get
			{
				if(r_IsValidType_Type == null)
				{
					r_IsValidType_Type = new(this, "IsValidType", 0, typeof(System.Type));
					r_IsValidType_Type.SetBelong(this.instance);
				}
				return r_IsValidType_Type;
			}
		}

		/// <summary>
		/// Boolean IsValidParam(System.Object, System.Type)
		/// </summary>
		protected RMethod r_IsValidParam_Object_Type;
		public virtual RMethod RIsValidParam_Object_Type
		{
			get
			{
				if(r_IsValidParam_Object_Type == null)
				{
					r_IsValidParam_Object_Type = new(this, "IsValidParam", 0, typeof(System.Object), typeof(System.Type));
					r_IsValidParam_Object_Type.SetBelong(this.instance);
				}
				return r_IsValidParam_Object_Type;
			}
		}

		/// <summary>
		/// Boolean IsValidValue(System.Type, System.Object)
		/// </summary>
		protected static RMethod r_IsValidValue_Type_Object;
		public static RMethod RIsValidValue_Type_Object
		{
			get
			{
				if(r_IsValidValue_Type_Object == null)
				{
					r_IsValidValue_Type_Object = new(typeof(System.Reflection.Emit.CustomAttributeBuilder), "IsValidValue", 0, typeof(System.Type), typeof(System.Object));
					r_IsValidValue_Type_Object.SetBelong(null);
				}
				return r_IsValidValue_Type_Object;
			}
		}

		/// <summary>
		/// Void Initialize(System.Reflection.ConstructorInfo, System.Object[], System.Reflection.PropertyInfo[], System.Object[], System.Reflection.FieldInfo[], System.Object[])
		/// </summary>
		protected RMethod r_Initialize_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray;
		public virtual RMethod RInitialize_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray
		{
			get
			{
				if(r_Initialize_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray == null)
				{
					r_Initialize_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray = new(this, "Initialize", 0, typeof(System.Reflection.ConstructorInfo), typeof(System.Object).MakeArrayType(), typeof(System.Reflection.PropertyInfo).MakeArrayType(), typeof(System.Object).MakeArrayType(), typeof(System.Reflection.FieldInfo).MakeArrayType(), typeof(System.Object).MakeArrayType());
					r_Initialize_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray.SetBelong(this.instance);
				}
				return r_Initialize_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray;
			}
		}

		/// <summary>
		/// Int32 decode_len(Byte[], Int32, Int32 ByRef)
		/// </summary>
		protected static RMethod r_decode_len_ByteArray_Int32_Out_Int32;
		public static RMethod Rdecode_len_ByteArray_Int32_Out_Int32
		{
			get
			{
				if(r_decode_len_ByteArray_Int32_Out_Int32 == null)
				{
					r_decode_len_ByteArray_Int32_Out_Int32 = new(typeof(System.Reflection.Emit.CustomAttributeBuilder), "decode_len", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
					r_decode_len_ByteArray_Int32_Out_Int32.SetBelong(null);
				}
				return r_decode_len_ByteArray_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// System.String string_from_bytes(Byte[], Int32, Int32)
		/// </summary>
		protected static RMethod r_string_from_bytes_ByteArray_Int32_Int32;
		public static RMethod Rstring_from_bytes_ByteArray_Int32_Int32
		{
			get
			{
				if(r_string_from_bytes_ByteArray_Int32_Int32 == null)
				{
					r_string_from_bytes_ByteArray_Int32_Int32 = new(typeof(System.Reflection.Emit.CustomAttributeBuilder), "string_from_bytes", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_string_from_bytes_ByteArray_Int32_Int32.SetBelong(null);
				}
				return r_string_from_bytes_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String decode_string(Byte[], Int32, Int32 ByRef)
		/// </summary>
		protected static RMethod r_decode_string_ByteArray_Int32_Out_Int32;
		public static RMethod Rdecode_string_ByteArray_Int32_Out_Int32
		{
			get
			{
				if(r_decode_string_ByteArray_Int32_Out_Int32 == null)
				{
					r_decode_string_ByteArray_Int32_Out_Int32 = new(typeof(System.Reflection.Emit.CustomAttributeBuilder), "decode_string", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
					r_decode_string_ByteArray_Int32_Out_Int32.SetBelong(null);
				}
				return r_decode_string_ByteArray_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// System.String string_arg()
		/// </summary>
		protected RMethod r_string_arg;
		public virtual RMethod Rstring_arg
		{
			get
			{
				if(r_string_arg == null)
				{
					r_string_arg = new(this, "string_arg", 0);
					r_string_arg.SetBelong(this.instance);
				}
				return r_string_arg;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.UnmanagedMarshal get_umarshal(System.Reflection.Emit.CustomAttributeBuilder, Boolean)
		/// </summary>
		protected static RMethod r_get_umarshal_CustomAttributeBuilder_Boolean;
		public static RMethod Rget_umarshal_CustomAttributeBuilder_Boolean
		{
			get
			{
				if(r_get_umarshal_CustomAttributeBuilder_Boolean == null)
				{
					r_get_umarshal_CustomAttributeBuilder_Boolean = new(typeof(System.Reflection.Emit.CustomAttributeBuilder), "get_umarshal", 0, typeof(System.Reflection.Emit.CustomAttributeBuilder), typeof(System.Boolean));
					r_get_umarshal_CustomAttributeBuilder_Boolean.SetBelong(null);
				}
				return r_get_umarshal_CustomAttributeBuilder_Boolean;
			}
		}

		/// <summary>
		/// System.Type elementTypeToType(Int32)
		/// </summary>
		protected static RMethod r_elementTypeToType_Int32;
		public static RMethod RelementTypeToType_Int32
		{
			get
			{
				if(r_elementTypeToType_Int32 == null)
				{
					r_elementTypeToType_Int32 = new(typeof(System.Reflection.Emit.CustomAttributeBuilder), "elementTypeToType", 0, typeof(System.Int32));
					r_elementTypeToType_Int32.SetBelong(null);
				}
				return r_elementTypeToType_Int32;
			}
		}

		/// <summary>
		/// System.Object decode_cattr_value(System.Type, Byte[], Int32, Int32 ByRef)
		/// </summary>
		protected static RMethod r_decode_cattr_value_Type_ByteArray_Int32_Out_Int32;
		public static RMethod Rdecode_cattr_value_Type_ByteArray_Int32_Out_Int32
		{
			get
			{
				if(r_decode_cattr_value_Type_ByteArray_Int32_Out_Int32 == null)
				{
					r_decode_cattr_value_Type_ByteArray_Int32_Out_Int32 = new(typeof(System.Reflection.Emit.CustomAttributeBuilder), "decode_cattr_value", 0, typeof(System.Type), typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
					r_decode_cattr_value_Type_ByteArray_Int32_Out_Int32.SetBelong(null);
				}
				return r_decode_cattr_value_Type_ByteArray_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// CustomAttributeInfo decode_cattr(System.Reflection.Emit.CustomAttributeBuilder)
		/// </summary>
		protected static RMethod r_decode_cattr_CustomAttributeBuilder;
		public static RMethod Rdecode_cattr_CustomAttributeBuilder
		{
			get
			{
				if(r_decode_cattr_CustomAttributeBuilder == null)
				{
					r_decode_cattr_CustomAttributeBuilder = new(typeof(System.Reflection.Emit.CustomAttributeBuilder), "decode_cattr", 0, typeof(System.Reflection.Emit.CustomAttributeBuilder));
					r_decode_cattr_CustomAttributeBuilder.SetBelong(null);
				}
				return r_decode_cattr_CustomAttributeBuilder;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterInfo[] GetParameters(System.Reflection.ConstructorInfo)
		/// </summary>
		protected static RMethod r_GetParameters_ConstructorInfo;
		public static RMethod RGetParameters_ConstructorInfo
		{
			get
			{
				if(r_GetParameters_ConstructorInfo == null)
				{
					r_GetParameters_ConstructorInfo = new(typeof(System.Reflection.Emit.CustomAttributeBuilder), "GetParameters", 0, typeof(System.Reflection.ConstructorInfo));
					r_GetParameters_ConstructorInfo.SetBelong(null);
				}
				return r_GetParameters_ConstructorInfo;
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


        public RCustomAttributeBuilder() : base("System.Reflection.Emit.CustomAttributeBuilder")
        {
        }

        public RCustomAttributeBuilder(System.Object instance) : base("System.Reflection.Emit.CustomAttributeBuilder")
		{
            SetInstance(instance);
		}

        public RCustomAttributeBuilder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCustomAttributeBuilder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Byte[] GetBlob(System.Reflection.Assembly @asmb, System.Reflection.ConstructorInfo @con, System.Object[] @constructorArgs, System.Reflection.PropertyInfo[] @namedProperties, System.Object[] @propertyValues, System.Reflection.FieldInfo[] @namedFields, System.Object[] @fieldValues)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asmb, @con, @constructorArgs, @namedProperties, @propertyValues, @namedFields, @fieldValues};
            var ___result = RGetBlob_Assembly_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Object Invoke()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInvoke.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean IsValidType(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RIsValidType_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsValidParam(System.Object @o, System.Type @paramType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o, @paramType};
            var ___result = RIsValidParam_Object_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsValidValue(System.Type @type, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @value};
            var ___result = RIsValidValue_Type_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Initialize(System.Reflection.ConstructorInfo @con, System.Object[] @constructorArgs, System.Reflection.PropertyInfo[] @namedProperties, System.Object[] @propertyValues, System.Reflection.FieldInfo[] @namedFields, System.Object[] @fieldValues)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@con, @constructorArgs, @namedProperties, @propertyValues, @namedFields, @fieldValues};
            var ___result = RInitialize_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 decode_len(System.Byte[] @data, System.Int32 @pos, out System.Int32 @rpos)
        {
			@rpos = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @pos, @rpos};
            var ___result = Rdecode_len_ByteArray_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			@rpos = (System.Int32)___parameters[2];

            return (System.Int32)___result;
        }


        public static System.String string_from_bytes(System.Byte[] @data, System.Int32 @pos, System.Int32 @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @pos, @len};
            var ___result = Rstring_from_bytes_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String decode_string(System.Byte[] @data, System.Int32 @pos, out System.Int32 @rpos)
        {
			@rpos = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @pos, @rpos};
            var ___result = Rdecode_string_ByteArray_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			@rpos = (System.Int32)___parameters[2];

            return (System.String)___result;
        }


        public virtual System.String string_arg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rstring_arg.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Reflection.Emit.UnmanagedMarshal get_umarshal(System.Reflection.Emit.CustomAttributeBuilder @customBuilder, System.Boolean @is_field)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@customBuilder, @is_field};
            var ___result = Rget_umarshal_CustomAttributeBuilder_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.UnmanagedMarshal)___result;
        }


        public static System.Type elementTypeToType(System.Int32 @elementType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementType};
            var ___result = RelementTypeToType_Int32.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Object decode_cattr_value(System.Type @t, System.Byte[] @data, System.Int32 @pos, out System.Int32 @rpos)
        {
			@rpos = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @data, @pos, @rpos};
            var ___result = Rdecode_cattr_value_Type_ByteArray_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			@rpos = (System.Int32)___parameters[3];

            return (System.Object)___result;
        }


        public static RSystem.RReflection.REmit.RCustomAttributeBuilder.RCustomAttributeInfo decode_cattr(System.Reflection.Emit.CustomAttributeBuilder @customBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@customBuilder};
            var ___result = Rdecode_cattr_CustomAttributeBuilder.Invoke(___genericsType, ___parameters);

            return new RSystem.RReflection.REmit.RCustomAttributeBuilder.RCustomAttributeInfo(___result);
        }


        public static System.Reflection.ParameterInfo[] GetParameters(System.Reflection.ConstructorInfo @ctor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctor};
            var ___result = RGetParameters_ConstructorInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ParameterInfo[])___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
