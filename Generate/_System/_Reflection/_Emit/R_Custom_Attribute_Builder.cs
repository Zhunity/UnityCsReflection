
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Reflection.Emit.CustomAttributeBuilder
	/// </summary>
    public partial class RCustomAttributeBuilder : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Reflection.Emit.CustomAttributeBuilder);
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


		/// <summary>
		/// System.Reflection.ConstructorInfo ctor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RConstructorInfo r_Fctor;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RConstructorInfo RFctor
		{
			get
			{
				if(r_Fctor == null)
				{
					r_Fctor = new(this, "ctor");
				}
				return r_Fctor;
			}
		}

		/// <summary>
		/// System.Byte[] data
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> r_Fdata;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RByte> RFdata
		{
			get
			{
				if(r_Fdata == null)
				{
					r_Fdata = new(this, "data");
				}
				return r_Fdata;
			}
		}

		/// <summary>
		/// System.Object[] args
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> r_Fargs;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> RFargs
		{
			get
			{
				if(r_Fargs == null)
				{
					r_Fargs = new(this, "args");
				}
				return r_Fargs;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo[] namedProperties
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.RPropertyInfo> r_FnamedProperties;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.RPropertyInfo> RFnamedProperties
		{
			get
			{
				if(r_FnamedProperties == null)
				{
					r_FnamedProperties = new(this, "namedProperties");
				}
				return r_FnamedProperties;
			}
		}

		/// <summary>
		/// System.Object[] propertyValues
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> r_FpropertyValues;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> RFpropertyValues
		{
			get
			{
				if(r_FpropertyValues == null)
				{
					r_FpropertyValues = new(this, "propertyValues");
				}
				return r_FpropertyValues;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo[] namedFields
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.RFieldInfo> r_FnamedFields;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.RFieldInfo> RFnamedFields
		{
			get
			{
				if(r_FnamedFields == null)
				{
					r_FnamedFields = new(this, "namedFields");
				}
				return r_FnamedFields;
			}
		}

		/// <summary>
		/// System.Object[] fieldValues
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> r_FfieldValues;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RObject> RFfieldValues
		{
			get
			{
				if(r_FfieldValues == null)
				{
					r_FfieldValues = new(this, "fieldValues");
				}
				return r_FfieldValues;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo Ctor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RConstructorInfo r_PCtor;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RConstructorInfo RPCtor
		{
			get
			{
				if(r_PCtor == null)
				{
					r_PCtor = new(this, "Ctor", -1);
				}
				return r_PCtor;
			}
		}

		/// <summary>
		/// Byte[] Data
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> r_PData;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RByte> RPData
		{
			get
			{
				if(r_PData == null)
				{
					r_PData = new(this, "Data", -1);
				}
				return r_PData;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._CustomAttributeBuilder.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._CustomAttributeBuilder.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._CustomAttributeBuilder.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._CustomAttributeBuilder.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._CustomAttributeBuilder.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._CustomAttributeBuilder.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._CustomAttributeBuilder.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._CustomAttributeBuilder.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Byte[] GetBlob(System.Reflection.Assembly, System.Reflection.ConstructorInfo, System.Object[], System.Reflection.PropertyInfo[], System.Object[], System.Reflection.FieldInfo[], System.Object[])
		/// </summary>
		protected static RMethod r_MGetBlob_Assembly_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray;
		public static RMethod RMGetBlob_Assembly_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray
		{
			get
			{
				if(r_MGetBlob_Assembly_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray == null)
				{
					r_MGetBlob_Assembly_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray = new(Type, "GetBlob", 0, typeof(System.Reflection.Assembly), typeof(System.Reflection.ConstructorInfo), typeof(System.Object).MakeArrayType(), typeof(System.Reflection.PropertyInfo).MakeArrayType(), typeof(System.Object).MakeArrayType(), typeof(System.Reflection.FieldInfo).MakeArrayType(), typeof(System.Object).MakeArrayType());
				}
				return r_MGetBlob_Assembly_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object Invoke()
		/// </summary>
		protected RMethod r_MInvoke;
		public virtual RMethod RMInvoke
		{
			get
			{
				if(r_MInvoke == null)
				{
					r_MInvoke = new(this, "Invoke", 0);
				}
				return r_MInvoke;
			}
		}

		/// <summary>
		/// Boolean IsValidType(System.Type)
		/// </summary>
		protected RMethod r_MIsValidType_Type;
		public virtual RMethod RMIsValidType_Type
		{
			get
			{
				if(r_MIsValidType_Type == null)
				{
					r_MIsValidType_Type = new(this, "IsValidType", 0, typeof(System.Type));
				}
				return r_MIsValidType_Type;
			}
		}

		/// <summary>
		/// Boolean IsValidParam(System.Object, System.Type)
		/// </summary>
		protected RMethod r_MIsValidParam_Object_Type;
		public virtual RMethod RMIsValidParam_Object_Type
		{
			get
			{
				if(r_MIsValidParam_Object_Type == null)
				{
					r_MIsValidParam_Object_Type = new(this, "IsValidParam", 0, typeof(System.Object), typeof(System.Type));
				}
				return r_MIsValidParam_Object_Type;
			}
		}

		/// <summary>
		/// Boolean IsValidValue(System.Type, System.Object)
		/// </summary>
		protected static RMethod r_MIsValidValue_Type_Object;
		public static RMethod RMIsValidValue_Type_Object
		{
			get
			{
				if(r_MIsValidValue_Type_Object == null)
				{
					r_MIsValidValue_Type_Object = new(Type, "IsValidValue", 0, typeof(System.Type), typeof(System.Object));
				}
				return r_MIsValidValue_Type_Object;
			}
		}

		/// <summary>
		/// Void Initialize(System.Reflection.ConstructorInfo, System.Object[], System.Reflection.PropertyInfo[], System.Object[], System.Reflection.FieldInfo[], System.Object[])
		/// </summary>
		protected RMethod r_MInitialize_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray;
		public virtual RMethod RMInitialize_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray
		{
			get
			{
				if(r_MInitialize_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray == null)
				{
					r_MInitialize_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray = new(this, "Initialize", 0, typeof(System.Reflection.ConstructorInfo), typeof(System.Object).MakeArrayType(), typeof(System.Reflection.PropertyInfo).MakeArrayType(), typeof(System.Object).MakeArrayType(), typeof(System.Reflection.FieldInfo).MakeArrayType(), typeof(System.Object).MakeArrayType());
				}
				return r_MInitialize_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray;
			}
		}

		/// <summary>
		/// Int32 decode_len(Byte[], Int32, Int32 ByRef)
		/// </summary>
		protected static RMethod r_Mdecode_len_ByteArray_Int32_Out_Int32;
		public static RMethod RMdecode_len_ByteArray_Int32_Out_Int32
		{
			get
			{
				if(r_Mdecode_len_ByteArray_Int32_Out_Int32 == null)
				{
					r_Mdecode_len_ByteArray_Int32_Out_Int32 = new(Type, "decode_len", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
				}
				return r_Mdecode_len_ByteArray_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// System.String string_from_bytes(Byte[], Int32, Int32)
		/// </summary>
		protected static RMethod r_Mstring_from_bytes_ByteArray_Int32_Int32;
		public static RMethod RMstring_from_bytes_ByteArray_Int32_Int32
		{
			get
			{
				if(r_Mstring_from_bytes_ByteArray_Int32_Int32 == null)
				{
					r_Mstring_from_bytes_ByteArray_Int32_Int32 = new(Type, "string_from_bytes", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
				}
				return r_Mstring_from_bytes_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String decode_string(Byte[], Int32, Int32 ByRef)
		/// </summary>
		protected static RMethod r_Mdecode_string_ByteArray_Int32_Out_Int32;
		public static RMethod RMdecode_string_ByteArray_Int32_Out_Int32
		{
			get
			{
				if(r_Mdecode_string_ByteArray_Int32_Out_Int32 == null)
				{
					r_Mdecode_string_ByteArray_Int32_Out_Int32 = new(Type, "decode_string", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
				}
				return r_Mdecode_string_ByteArray_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// System.String string_arg()
		/// </summary>
		protected RMethod r_Mstring_arg;
		public virtual RMethod RMstring_arg
		{
			get
			{
				if(r_Mstring_arg == null)
				{
					r_Mstring_arg = new(this, "string_arg", 0);
				}
				return r_Mstring_arg;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.UnmanagedMarshal get_umarshal(System.Reflection.Emit.CustomAttributeBuilder, Boolean)
		/// </summary>
		protected static RMethod r_Mget_umarshal_CustomAttributeBuilder_Boolean;
		public static RMethod RMget_umarshal_CustomAttributeBuilder_Boolean
		{
			get
			{
				if(r_Mget_umarshal_CustomAttributeBuilder_Boolean == null)
				{
					r_Mget_umarshal_CustomAttributeBuilder_Boolean = new(Type, "get_umarshal", 0, typeof(System.Reflection.Emit.CustomAttributeBuilder), typeof(System.Boolean));
				}
				return r_Mget_umarshal_CustomAttributeBuilder_Boolean;
			}
		}

		/// <summary>
		/// System.Type elementTypeToType(Int32)
		/// </summary>
		protected static RMethod r_MelementTypeToType_Int32;
		public static RMethod RMelementTypeToType_Int32
		{
			get
			{
				if(r_MelementTypeToType_Int32 == null)
				{
					r_MelementTypeToType_Int32 = new(Type, "elementTypeToType", 0, typeof(System.Int32));
				}
				return r_MelementTypeToType_Int32;
			}
		}

		/// <summary>
		/// System.Object decode_cattr_value(System.Type, Byte[], Int32, Int32 ByRef)
		/// </summary>
		protected static RMethod r_Mdecode_cattr_value_Type_ByteArray_Int32_Out_Int32;
		public static RMethod RMdecode_cattr_value_Type_ByteArray_Int32_Out_Int32
		{
			get
			{
				if(r_Mdecode_cattr_value_Type_ByteArray_Int32_Out_Int32 == null)
				{
					r_Mdecode_cattr_value_Type_ByteArray_Int32_Out_Int32 = new(Type, "decode_cattr_value", 0, typeof(System.Type), typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
				}
				return r_Mdecode_cattr_value_Type_ByteArray_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// CustomAttributeInfo decode_cattr(System.Reflection.Emit.CustomAttributeBuilder)
		/// </summary>
		protected static RMethod r_Mdecode_cattr_CustomAttributeBuilder;
		public static RMethod RMdecode_cattr_CustomAttributeBuilder
		{
			get
			{
				if(r_Mdecode_cattr_CustomAttributeBuilder == null)
				{
					r_Mdecode_cattr_CustomAttributeBuilder = new(Type, "decode_cattr", 0, typeof(System.Reflection.Emit.CustomAttributeBuilder));
				}
				return r_Mdecode_cattr_CustomAttributeBuilder;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterInfo[] GetParameters(System.Reflection.ConstructorInfo)
		/// </summary>
		protected static RMethod r_MGetParameters_ConstructorInfo;
		public static RMethod RMGetParameters_ConstructorInfo
		{
			get
			{
				if(r_MGetParameters_ConstructorInfo == null)
				{
					r_MGetParameters_ConstructorInfo = new(Type, "GetParameters", 0, typeof(System.Reflection.ConstructorInfo));
				}
				return r_MGetParameters_ConstructorInfo;
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


        public virtual void System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = ReflectionUtils.Convert<System.UInt32>(___parameters[0]);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___CustomAttributeBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Byte[] GetBlob(System.Reflection.Assembly @asmb, System.Reflection.ConstructorInfo @con, System.Object[] @constructorArgs, System.Reflection.PropertyInfo[] @namedProperties, System.Object[] @propertyValues, System.Reflection.FieldInfo[] @namedFields, System.Object[] @fieldValues)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asmb, @con, @constructorArgs, @namedProperties, @propertyValues, @namedFields, @fieldValues};
            var ___result = RMGetBlob_Assembly_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Byte[]>(___result);
        }


        public virtual System.Object Invoke()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInvoke.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Boolean IsValidType(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMIsValidType_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean IsValidParam(System.Object @o, System.Type @paramType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o, @paramType};
            var ___result = RMIsValidParam_Object_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean IsValidValue(System.Type @type, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @value};
            var ___result = RMIsValidValue_Type_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Initialize(System.Reflection.ConstructorInfo @con, System.Object[] @constructorArgs, System.Reflection.PropertyInfo[] @namedProperties, System.Object[] @propertyValues, System.Reflection.FieldInfo[] @namedFields, System.Object[] @fieldValues)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@con, @constructorArgs, @namedProperties, @propertyValues, @namedFields, @fieldValues};
            var ___result = RMInitialize_ConstructorInfo_ObjectArray_PropertyInfoArray_ObjectArray_FieldInfoArray_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 decode_len(System.Byte[] @data, System.Int32 @pos, out System.Int32 @rpos)
        {
			@rpos = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @pos, @rpos};
            var ___result = RMdecode_len_ByteArray_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			@rpos = ReflectionUtils.Convert<System.Int32>(___parameters[2]);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.String string_from_bytes(System.Byte[] @data, System.Int32 @pos, System.Int32 @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @pos, @len};
            var ___result = RMstring_from_bytes_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.String decode_string(System.Byte[] @data, System.Int32 @pos, out System.Int32 @rpos)
        {
			@rpos = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @pos, @rpos};
            var ___result = RMdecode_string_ByteArray_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			@rpos = ReflectionUtils.Convert<System.Int32>(___parameters[2]);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String string_arg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMstring_arg.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.Reflection.Emit.UnmanagedMarshal get_umarshal(System.Reflection.Emit.CustomAttributeBuilder @customBuilder, System.Boolean @is_field)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@customBuilder, @is_field};
            var ___result = RMget_umarshal_CustomAttributeBuilder_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.UnmanagedMarshal>(___result);
        }


        public static System.Type elementTypeToType(System.Int32 @elementType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementType};
            var ___result = RMelementTypeToType_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public static System.Object decode_cattr_value(System.Type @t, System.Byte[] @data, System.Int32 @pos, out System.Int32 @rpos)
        {
			@rpos = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @data, @pos, @rpos};
            var ___result = RMdecode_cattr_value_Type_ByteArray_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			@rpos = ReflectionUtils.Convert<System.Int32>(___parameters[3]);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RCustomAttributeBuilder.RCustomAttributeInfo decode_cattr(System.Reflection.Emit.CustomAttributeBuilder @customBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@customBuilder};
            var ___result = RMdecode_cattr_CustomAttributeBuilder.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RCustomAttributeBuilder.RCustomAttributeInfo>(___result);
        }


        public static System.Reflection.ParameterInfo[] GetParameters(System.Reflection.ConstructorInfo @ctor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctor};
            var ___result = RMGetParameters_ConstructorInfo.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.ParameterInfo[]>(___result);
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
