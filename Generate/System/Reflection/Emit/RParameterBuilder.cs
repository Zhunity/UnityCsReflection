using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.ParameterBuilder
	/// </summary>
    public partial class RParameterBuilder : RMember //
    {

		/// <summary>
		/// System.Reflection.MethodBase methodb
		/// </summary>
		protected RSystem.RReflection.RMethodBase r_methodb;
		public virtual RSystem.RReflection.RMethodBase Rmethodb
		{
			get
			{
				if(r_methodb == null)
				{
					r_methodb = new(this, "methodb");
					r_methodb.SetBelong(this.instance);
				}
				return r_methodb;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RField r_name;
		public virtual RField Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name");
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.CustomAttributeBuilder[] cattrs
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RCustomAttributeBuilder> r_cattrs;
		public virtual RFieldArray<RSystem.RReflection.REmit.RCustomAttributeBuilder> Rcattrs
		{
			get
			{
				if(r_cattrs == null)
				{
					r_cattrs = new(this, "cattrs");
					r_cattrs.SetBelong(this.instance);
				}
				return r_cattrs;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.UnmanagedMarshal marshal_info
		/// </summary>
		protected RSystem.RReflection.REmit.RUnmanagedMarshal r_marshal_info;
		public virtual RSystem.RReflection.REmit.RUnmanagedMarshal Rmarshal_info
		{
			get
			{
				if(r_marshal_info == null)
				{
					r_marshal_info = new(this, "marshal_info");
					r_marshal_info.SetBelong(this.instance);
				}
				return r_marshal_info;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterAttributes attrs
		/// </summary>
		protected RField r_attrs;
		public virtual RField Rattrs
		{
			get
			{
				if(r_attrs == null)
				{
					r_attrs = new(this, "attrs");
					r_attrs.SetBelong(this.instance);
				}
				return r_attrs;
			}
		}

		/// <summary>
		/// System.Int32 position
		/// </summary>
		protected RField r_position;
		public virtual RField Rposition
		{
			get
			{
				if(r_position == null)
				{
					r_position = new(this, "position");
					r_position.SetBelong(this.instance);
				}
				return r_position;
			}
		}

		/// <summary>
		/// System.Int32 table_idx
		/// </summary>
		protected RField r_table_idx;
		public virtual RField Rtable_idx
		{
			get
			{
				if(r_table_idx == null)
				{
					r_table_idx = new(this, "table_idx");
					r_table_idx.SetBelong(this.instance);
				}
				return r_table_idx;
			}
		}

		/// <summary>
		/// System.Object def_value
		/// </summary>
		protected RSystem.RObject r_def_value;
		public virtual RSystem.RObject Rdef_value
		{
			get
			{
				if(r_def_value == null)
				{
					r_def_value = new(this, "def_value");
					r_def_value.SetBelong(this.instance);
				}
				return r_def_value;
			}
		}

		/// <summary>
		/// Int32 Attributes
		/// </summary>
		protected RProperty r_Attributes;
		public virtual RProperty RAttributes
		{
			get
			{
				if(r_Attributes == null)
				{
					r_Attributes = new(this, "Attributes", -1);
					r_Attributes.SetBelong(this.instance);
				}
				return r_Attributes;
			}
		}

		/// <summary>
		/// Boolean IsIn
		/// </summary>
		protected RProperty r_IsIn;
		public virtual RProperty RIsIn
		{
			get
			{
				if(r_IsIn == null)
				{
					r_IsIn = new(this, "IsIn", -1);
					r_IsIn.SetBelong(this.instance);
				}
				return r_IsIn;
			}
		}

		/// <summary>
		/// Boolean IsOut
		/// </summary>
		protected RProperty r_IsOut;
		public virtual RProperty RIsOut
		{
			get
			{
				if(r_IsOut == null)
				{
					r_IsOut = new(this, "IsOut", -1);
					r_IsOut.SetBelong(this.instance);
				}
				return r_IsOut;
			}
		}

		/// <summary>
		/// Boolean IsOptional
		/// </summary>
		protected RProperty r_IsOptional;
		public virtual RProperty RIsOptional
		{
			get
			{
				if(r_IsOptional == null)
				{
					r_IsOptional = new(this, "IsOptional", -1);
					r_IsOptional.SetBelong(this.instance);
				}
				return r_IsOptional;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
			}
		}

		/// <summary>
		/// Int32 Position
		/// </summary>
		protected RProperty r_Position;
		public virtual RProperty RPosition
		{
			get
			{
				if(r_Position == null)
				{
					r_Position = new(this, "Position", -1);
					r_Position.SetBelong(this.instance);
				}
				return r_Position;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ParameterBuilder.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ParameterBuilder.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ParameterBuilder.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ParameterBuilder.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ParameterBuilder.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._ParameterBuilder.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ParameterBuilder.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._ParameterBuilder.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ParameterToken GetToken()
		/// </summary>
		protected RMethod r_RGetToken;
		public virtual RMethod RGetToken
		{
			get
			{
				if(r_RGetToken == null)
				{
					r_RGetToken = new(this, "GetToken", 0);
					r_RGetToken.SetBelong(this.instance);
				}
				return r_RGetToken;
			}
		}

		/// <summary>
		/// Void SetConstant(System.Object)
		/// </summary>
		protected RMethod r_RSetConstant_Object;
		public virtual RMethod RSetConstant_Object
		{
			get
			{
				if(r_RSetConstant_Object == null)
				{
					r_RSetConstant_Object = new(this, "SetConstant", 0, typeof(System.Object));
					r_RSetConstant_Object.SetBelong(this.instance);
				}
				return r_RSetConstant_Object;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder)
		/// </summary>
		protected RMethod r_RSetCustomAttribute_CustomAttributeBuilder;
		public virtual RMethod RSetCustomAttribute_CustomAttributeBuilder
		{
			get
			{
				if(r_RSetCustomAttribute_CustomAttributeBuilder == null)
				{
					r_RSetCustomAttribute_CustomAttributeBuilder = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.Emit.CustomAttributeBuilder));
					r_RSetCustomAttribute_CustomAttributeBuilder.SetBelong(this.instance);
				}
				return r_RSetCustomAttribute_CustomAttributeBuilder;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.ConstructorInfo, Byte[])
		/// </summary>
		protected RMethod r_RSetCustomAttribute_ConstructorInfo_ByteArray;
		public virtual RMethod RSetCustomAttribute_ConstructorInfo_ByteArray
		{
			get
			{
				if(r_RSetCustomAttribute_ConstructorInfo_ByteArray == null)
				{
					r_RSetCustomAttribute_ConstructorInfo_ByteArray = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.ConstructorInfo), typeof(System.Byte).MakeArrayType());
					r_RSetCustomAttribute_ConstructorInfo_ByteArray.SetBelong(this.instance);
				}
				return r_RSetCustomAttribute_ConstructorInfo_ByteArray;
			}
		}

		/// <summary>
		/// Void SetMarshal(System.Reflection.Emit.UnmanagedMarshal)
		/// </summary>
		protected RMethod r_RSetMarshal_UnmanagedMarshal;
		public virtual RMethod RSetMarshal_UnmanagedMarshal
		{
			get
			{
				if(r_RSetMarshal_UnmanagedMarshal == null)
				{
					r_RSetMarshal_UnmanagedMarshal = new(this, "SetMarshal", 0, typeof(System.Reflection.Emit.UnmanagedMarshal));
					r_RSetMarshal_UnmanagedMarshal.SetBelong(this.instance);
				}
				return r_RSetMarshal_UnmanagedMarshal;
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


        public RParameterBuilder() : base("System.Reflection.Emit.ParameterBuilder")
        {
        }

        public RParameterBuilder(System.Object instance) : base("System.Reflection.Emit.ParameterBuilder")
		{
            SetInstance(instance);
		}

        public RParameterBuilder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RParameterBuilder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void System__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetIDsOfNames(in System.Guid  @riid, System.IntPtr  @rgszNames, System.UInt32  @cNames, System.UInt32  @lcid, System.IntPtr  @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetTypeInfo(System.UInt32  @iTInfo, System.UInt32  @lcid, System.IntPtr  @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetTypeInfoCount(out System.UInt32  @pcTInfo)
        {
			pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__0__Runtime__0__InteropServices__0___ParameterBuilder__0__Invoke(System.UInt32  @dispIdMember, in System.Guid  @riid, System.UInt32  @lcid, System.Int16  @wFlags, System.IntPtr  @pDispParams, System.IntPtr  @pVarResult, System.IntPtr  @pExcepInfo, System.IntPtr  @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___ParameterBuilder__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.ParameterToken GetToken()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetToken.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.ParameterToken)___result;
        }


        public virtual void SetConstant(System.Object  @defaultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@defaultValue};
            var ___result = RSetConstant_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder  @customBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@customBuilder};
            var ___result = RSetCustomAttribute_CustomAttributeBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCustomAttribute(System.Reflection.ConstructorInfo  @con, System.Byte[]  @binaryAttribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@con, @binaryAttribute};
            var ___result = RSetCustomAttribute_ConstructorInfo_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMarshal(System.Reflection.Emit.UnmanagedMarshal  @unmanagedMarshal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unmanagedMarshal};
            var ___result = RSetMarshal_UnmanagedMarshal.Invoke(___genericsType, ___parameters);

            
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
