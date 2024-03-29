
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Reflection.Emit.ParameterBuilder
	/// </summary>
    public partial class RParameterBuilder : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Reflection.Emit.ParameterBuilder);
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


		/// <summary>
		/// System.Reflection.MethodBase methodb
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMethodBase r_Fmethodb;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMethodBase RFmethodb
		{
			get
			{
				if(r_Fmethodb == null)
				{
					r_Fmethodb = new(this, "methodb");
				}
				return r_Fmethodb;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFname
		{
			get
			{
				if(r_Fname == null)
				{
					r_Fname = new(this, "name");
				}
				return r_Fname;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.CustomAttributeBuilder[] cattrs
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RCustomAttributeBuilder> r_Fcattrs;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RCustomAttributeBuilder> RFcattrs
		{
			get
			{
				if(r_Fcattrs == null)
				{
					r_Fcattrs = new(this, "cattrs");
				}
				return r_Fcattrs;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.UnmanagedMarshal marshal_info
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RUnmanagedMarshal r_Fmarshal_info;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RUnmanagedMarshal RFmarshal_info
		{
			get
			{
				if(r_Fmarshal_info == null)
				{
					r_Fmarshal_info = new(this, "marshal_info");
				}
				return r_Fmarshal_info;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterAttributes attrs
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes r_Fattrs;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RParameterAttributes RFattrs
		{
			get
			{
				if(r_Fattrs == null)
				{
					r_Fattrs = new(this, "attrs");
				}
				return r_Fattrs;
			}
		}

		/// <summary>
		/// System.Int32 position
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fposition;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFposition
		{
			get
			{
				if(r_Fposition == null)
				{
					r_Fposition = new(this, "position");
				}
				return r_Fposition;
			}
		}

		/// <summary>
		/// System.Int32 table_idx
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Ftable_idx;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFtable_idx
		{
			get
			{
				if(r_Ftable_idx == null)
				{
					r_Ftable_idx = new(this, "table_idx");
				}
				return r_Ftable_idx;
			}
		}

		/// <summary>
		/// System.Object def_value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_Fdef_value;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFdef_value
		{
			get
			{
				if(r_Fdef_value == null)
				{
					r_Fdef_value = new(this, "def_value");
				}
				return r_Fdef_value;
			}
		}

		/// <summary>
		/// Int32 Attributes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PAttributes;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPAttributes
		{
			get
			{
				if(r_PAttributes == null)
				{
					r_PAttributes = new(this, "Attributes", -1);
				}
				return r_PAttributes;
			}
		}

		/// <summary>
		/// Boolean IsIn
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsIn;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsIn
		{
			get
			{
				if(r_PIsIn == null)
				{
					r_PIsIn = new(this, "IsIn", -1);
				}
				return r_PIsIn;
			}
		}

		/// <summary>
		/// Boolean IsOut
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsOut;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsOut
		{
			get
			{
				if(r_PIsOut == null)
				{
					r_PIsOut = new(this, "IsOut", -1);
				}
				return r_PIsOut;
			}
		}

		/// <summary>
		/// Boolean IsOptional
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsOptional;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsOptional
		{
			get
			{
				if(r_PIsOptional == null)
				{
					r_PIsOptional = new(this, "IsOptional", -1);
				}
				return r_PIsOptional;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// Int32 Position
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PPosition;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPPosition
		{
			get
			{
				if(r_PPosition == null)
				{
					r_PPosition = new(this, "Position", -1);
				}
				return r_PPosition;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ParameterBuilder.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ParameterBuilder.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ParameterBuilder.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ParameterBuilder.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ParameterBuilder.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._ParameterBuilder.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ParameterBuilder.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._ParameterBuilder.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ParameterToken GetToken()
		/// </summary>
		protected RMethod r_MGetToken;
		public virtual RMethod RMGetToken
		{
			get
			{
				if(r_MGetToken == null)
				{
					r_MGetToken = new(this, "GetToken", 0);
				}
				return r_MGetToken;
			}
		}

		/// <summary>
		/// Void SetConstant(System.Object)
		/// </summary>
		protected RMethod r_MSetConstant_Object;
		public virtual RMethod RMSetConstant_Object
		{
			get
			{
				if(r_MSetConstant_Object == null)
				{
					r_MSetConstant_Object = new(this, "SetConstant", 0, typeof(System.Object));
				}
				return r_MSetConstant_Object;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder)
		/// </summary>
		protected RMethod r_MSetCustomAttribute_CustomAttributeBuilder;
		public virtual RMethod RMSetCustomAttribute_CustomAttributeBuilder
		{
			get
			{
				if(r_MSetCustomAttribute_CustomAttributeBuilder == null)
				{
					r_MSetCustomAttribute_CustomAttributeBuilder = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.Emit.CustomAttributeBuilder));
				}
				return r_MSetCustomAttribute_CustomAttributeBuilder;
			}
		}

		/// <summary>
		/// Void SetCustomAttribute(System.Reflection.ConstructorInfo, Byte[])
		/// </summary>
		protected RMethod r_MSetCustomAttribute_ConstructorInfo_ByteArray;
		public virtual RMethod RMSetCustomAttribute_ConstructorInfo_ByteArray
		{
			get
			{
				if(r_MSetCustomAttribute_ConstructorInfo_ByteArray == null)
				{
					r_MSetCustomAttribute_ConstructorInfo_ByteArray = new(this, "SetCustomAttribute", 0, typeof(System.Reflection.ConstructorInfo), typeof(System.Byte).MakeArrayType());
				}
				return r_MSetCustomAttribute_ConstructorInfo_ByteArray;
			}
		}

		/// <summary>
		/// Void SetMarshal(System.Reflection.Emit.UnmanagedMarshal)
		/// </summary>
		protected RMethod r_MSetMarshal_UnmanagedMarshal;
		public virtual RMethod RMSetMarshal_UnmanagedMarshal
		{
			get
			{
				if(r_MSetMarshal_UnmanagedMarshal == null)
				{
					r_MSetMarshal_UnmanagedMarshal = new(this, "SetMarshal", 0, typeof(System.Reflection.Emit.UnmanagedMarshal));
				}
				return r_MSetMarshal_UnmanagedMarshal;
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


        public virtual void System__2__Runtime__2__InteropServices__2___ParameterBuilder__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ParameterBuilder__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ParameterBuilder__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = ReflectionUtils.Convert<System.UInt32>(___parameters[0]);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ParameterBuilder__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ParameterBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.ParameterToken GetToken()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetToken.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.ParameterToken>(___result);
        }


        public virtual void SetConstant(System.Object @defaultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@defaultValue};
            var ___result = RMSetConstant_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder @customBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@customBuilder};
            var ___result = RMSetCustomAttribute_CustomAttributeBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCustomAttribute(System.Reflection.ConstructorInfo @con, System.Byte[] @binaryAttribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@con, @binaryAttribute};
            var ___result = RMSetCustomAttribute_ConstructorInfo_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMarshal(System.Reflection.Emit.UnmanagedMarshal @unmanagedMarshal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unmanagedMarshal};
            var ___result = RMSetMarshal_UnmanagedMarshal.Invoke(___genericsType, ___parameters);

            
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
