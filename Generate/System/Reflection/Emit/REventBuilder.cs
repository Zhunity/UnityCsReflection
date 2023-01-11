using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.EventBuilder
	/// </summary>
    public partial class REventBuilder : RMember //
    {

		/// <summary>
		/// System.String name
		/// </summary>
		protected RSystem.RString r_name;
		public virtual RSystem.RString Rname
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
		/// System.Type type
		/// </summary>
		protected RSystem.RType r_type;
		public virtual RSystem.RType Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type");
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder typeb
		/// </summary>
		protected RSystem.RReflection.REmit.RTypeBuilder r_typeb;
		public virtual RSystem.RReflection.REmit.RTypeBuilder Rtypeb
		{
			get
			{
				if(r_typeb == null)
				{
					r_typeb = new(this, "typeb");
					r_typeb.SetBelong(this.instance);
				}
				return r_typeb;
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
		/// System.Reflection.Emit.MethodBuilder add_method
		/// </summary>
		protected RSystem.RReflection.REmit.RMethodBuilder r_add_method;
		public virtual RSystem.RReflection.REmit.RMethodBuilder Radd_method
		{
			get
			{
				if(r_add_method == null)
				{
					r_add_method = new(this, "add_method");
					r_add_method.SetBelong(this.instance);
				}
				return r_add_method;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder remove_method
		/// </summary>
		protected RSystem.RReflection.REmit.RMethodBuilder r_remove_method;
		public virtual RSystem.RReflection.REmit.RMethodBuilder Rremove_method
		{
			get
			{
				if(r_remove_method == null)
				{
					r_remove_method = new(this, "remove_method");
					r_remove_method.SetBelong(this.instance);
				}
				return r_remove_method;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder raise_method
		/// </summary>
		protected RSystem.RReflection.REmit.RMethodBuilder r_raise_method;
		public virtual RSystem.RReflection.REmit.RMethodBuilder Rraise_method
		{
			get
			{
				if(r_raise_method == null)
				{
					r_raise_method = new(this, "raise_method");
					r_raise_method.SetBelong(this.instance);
				}
				return r_raise_method;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder[] other_methods
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RMethodBuilder> r_other_methods;
		public virtual RFieldArray<RSystem.RReflection.REmit.RMethodBuilder> Rother_methods
		{
			get
			{
				if(r_other_methods == null)
				{
					r_other_methods = new(this, "other_methods");
					r_other_methods.SetBelong(this.instance);
				}
				return r_other_methods;
			}
		}

		/// <summary>
		/// System.Reflection.EventAttributes attrs
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
		/// System.Int32 table_idx
		/// </summary>
		protected RSystem.RInt32 r_table_idx;
		public virtual RSystem.RInt32 Rtable_idx
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
		/// Void System.Runtime.InteropServices._EventBuilder.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___EventBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___EventBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___EventBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___EventBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._EventBuilder.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___EventBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___EventBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._EventBuilder.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___EventBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___EventBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___EventBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___EventBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._EventBuilder.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___EventBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___EventBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._EventBuilder.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___EventBuilder__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___EventBuilder__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___EventBuilder__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_System__2__Runtime__2__InteropServices__2___EventBuilder__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._EventBuilder.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_System__2__Runtime__2__InteropServices__2___EventBuilder__2__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___EventBuilder__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._EventBuilder.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___EventBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___EventBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___EventBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___EventBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._EventBuilder.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___EventBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___EventBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Int32 get_next_table_index(System.Object, Int32, Int32)
		/// </summary>
		protected RMethod r_get_next_table_index_Object_Int32_Int32;
		public virtual RMethod Rget_next_table_index_Object_Int32_Int32
		{
			get
			{
				if(r_get_next_table_index_Object_Int32_Int32 == null)
				{
					r_get_next_table_index_Object_Int32_Int32 = new(this, "get_next_table_index", 0, typeof(System.Object), typeof(System.Int32), typeof(System.Int32));
					r_get_next_table_index_Object_Int32_Int32.SetBelong(this.instance);
				}
				return r_get_next_table_index_Object_Int32_Int32;
			}
		}

		/// <summary>
		/// Void AddOtherMethod(System.Reflection.Emit.MethodBuilder)
		/// </summary>
		protected RMethod r_AddOtherMethod_MethodBuilder;
		public virtual RMethod RAddOtherMethod_MethodBuilder
		{
			get
			{
				if(r_AddOtherMethod_MethodBuilder == null)
				{
					r_AddOtherMethod_MethodBuilder = new(this, "AddOtherMethod", 0, typeof(System.Reflection.Emit.MethodBuilder));
					r_AddOtherMethod_MethodBuilder.SetBelong(this.instance);
				}
				return r_AddOtherMethod_MethodBuilder;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.EventToken GetEventToken()
		/// </summary>
		protected RMethod r_GetEventToken;
		public virtual RMethod RGetEventToken
		{
			get
			{
				if(r_GetEventToken == null)
				{
					r_GetEventToken = new(this, "GetEventToken", 0);
					r_GetEventToken.SetBelong(this.instance);
				}
				return r_GetEventToken;
			}
		}

		/// <summary>
		/// Void SetAddOnMethod(System.Reflection.Emit.MethodBuilder)
		/// </summary>
		protected RMethod r_SetAddOnMethod_MethodBuilder;
		public virtual RMethod RSetAddOnMethod_MethodBuilder
		{
			get
			{
				if(r_SetAddOnMethod_MethodBuilder == null)
				{
					r_SetAddOnMethod_MethodBuilder = new(this, "SetAddOnMethod", 0, typeof(System.Reflection.Emit.MethodBuilder));
					r_SetAddOnMethod_MethodBuilder.SetBelong(this.instance);
				}
				return r_SetAddOnMethod_MethodBuilder;
			}
		}

		/// <summary>
		/// Void SetRaiseMethod(System.Reflection.Emit.MethodBuilder)
		/// </summary>
		protected RMethod r_SetRaiseMethod_MethodBuilder;
		public virtual RMethod RSetRaiseMethod_MethodBuilder
		{
			get
			{
				if(r_SetRaiseMethod_MethodBuilder == null)
				{
					r_SetRaiseMethod_MethodBuilder = new(this, "SetRaiseMethod", 0, typeof(System.Reflection.Emit.MethodBuilder));
					r_SetRaiseMethod_MethodBuilder.SetBelong(this.instance);
				}
				return r_SetRaiseMethod_MethodBuilder;
			}
		}

		/// <summary>
		/// Void SetRemoveOnMethod(System.Reflection.Emit.MethodBuilder)
		/// </summary>
		protected RMethod r_SetRemoveOnMethod_MethodBuilder;
		public virtual RMethod RSetRemoveOnMethod_MethodBuilder
		{
			get
			{
				if(r_SetRemoveOnMethod_MethodBuilder == null)
				{
					r_SetRemoveOnMethod_MethodBuilder = new(this, "SetRemoveOnMethod", 0, typeof(System.Reflection.Emit.MethodBuilder));
					r_SetRemoveOnMethod_MethodBuilder.SetBelong(this.instance);
				}
				return r_SetRemoveOnMethod_MethodBuilder;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder)
		/// </summary>
		protected RMethod r_SetCustomAttribute_CustomAttributeBuilder;
		public virtual RMethod RSetCustomAttribute_CustomAttributeBuilder
		{
			get
			{
				if(r_SetCustomAttribute_CustomAttributeBuilder == null)
				{
					r_SetCustomAttribute_CustomAttributeBuilder = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.Emit.CustomAttributeBuilder));
					r_SetCustomAttribute_CustomAttributeBuilder.SetBelong(this.instance);
				}
				return r_SetCustomAttribute_CustomAttributeBuilder;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.ConstructorInfo, Byte[])
		/// </summary>
		protected RMethod r_SetCustomAttribute_ConstructorInfo_ByteArray;
		public virtual RMethod RSetCustomAttribute_ConstructorInfo_ByteArray
		{
			get
			{
				if(r_SetCustomAttribute_ConstructorInfo_ByteArray == null)
				{
					r_SetCustomAttribute_ConstructorInfo_ByteArray = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.ConstructorInfo), typeof(System.Byte).MakeArrayType());
					r_SetCustomAttribute_ConstructorInfo_ByteArray.SetBelong(this.instance);
				}
				return r_SetCustomAttribute_ConstructorInfo_ByteArray;
			}
		}

		/// <summary>
		/// Void RejectIfCreated()
		/// </summary>
		protected RMethod r_RejectIfCreated;
		public virtual RMethod RRejectIfCreated
		{
			get
			{
				if(r_RejectIfCreated == null)
				{
					r_RejectIfCreated = new(this, "RejectIfCreated", 0);
					r_RejectIfCreated.SetBelong(this.instance);
				}
				return r_RejectIfCreated;
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


        public REventBuilder() : base("System.Reflection.Emit.EventBuilder")
        {
        }

        public REventBuilder(System.Object instance) : base("System.Reflection.Emit.EventBuilder")
		{
            SetInstance(instance);
		}

        public REventBuilder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REventBuilder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void System__2__Runtime__2__InteropServices__2___EventBuilder__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___EventBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___EventBuilder__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___EventBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___EventBuilder__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___EventBuilder__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___EventBuilder__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___EventBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 get_next_table_index(System.Object @obj, System.Int32 @table, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @table, @count};
            var ___result = Rget_next_table_index_Object_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void AddOtherMethod(System.Reflection.Emit.MethodBuilder @mdBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mdBuilder};
            var ___result = RAddOtherMethod_MethodBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.EventToken GetEventToken()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEventToken.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.EventToken)___result;
        }


        public virtual void SetAddOnMethod(System.Reflection.Emit.MethodBuilder @mdBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mdBuilder};
            var ___result = RSetAddOnMethod_MethodBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRaiseMethod(System.Reflection.Emit.MethodBuilder @mdBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mdBuilder};
            var ___result = RSetRaiseMethod_MethodBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetRemoveOnMethod(System.Reflection.Emit.MethodBuilder @mdBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mdBuilder};
            var ___result = RSetRemoveOnMethod_MethodBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder @customBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@customBuilder};
            var ___result = RSetCustomAttribute_CustomAttributeBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCustomAttribute(System.Reflection.ConstructorInfo @con, System.Byte[] @binaryAttribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@con, @binaryAttribute};
            var ___result = RSetCustomAttribute_ConstructorInfo_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RejectIfCreated()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRejectIfCreated.Invoke(___genericsType, ___parameters);

            
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
