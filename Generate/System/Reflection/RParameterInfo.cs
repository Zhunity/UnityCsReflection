using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.ParameterInfo
	/// </summary>
    public partial class RParameterInfo : RMember //
    {

		/// <summary>
		/// System.Reflection.ParameterAttributes AttrsImpl
		/// </summary>
		protected RField r_AttrsImpl;
		public virtual RField RAttrsImpl
		{
			get
			{
				if(r_AttrsImpl == null)
				{
					r_AttrsImpl = new(this, "AttrsImpl");
					r_AttrsImpl.SetBelong(this.instance);
				}
				return r_AttrsImpl;
			}
		}

		/// <summary>
		/// System.Type ClassImpl
		/// </summary>
		protected RSystem.RType r_ClassImpl;
		public virtual RSystem.RType RClassImpl
		{
			get
			{
				if(r_ClassImpl == null)
				{
					r_ClassImpl = new(this, "ClassImpl");
					r_ClassImpl.SetBelong(this.instance);
				}
				return r_ClassImpl;
			}
		}

		/// <summary>
		/// System.Object DefaultValueImpl
		/// </summary>
		protected RSystem.RObject r_DefaultValueImpl;
		public virtual RSystem.RObject RDefaultValueImpl
		{
			get
			{
				if(r_DefaultValueImpl == null)
				{
					r_DefaultValueImpl = new(this, "DefaultValueImpl");
					r_DefaultValueImpl.SetBelong(this.instance);
				}
				return r_DefaultValueImpl;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo MemberImpl
		/// </summary>
		protected RSystem.RReflection.RMemberInfo r_MemberImpl;
		public virtual RSystem.RReflection.RMemberInfo RMemberImpl
		{
			get
			{
				if(r_MemberImpl == null)
				{
					r_MemberImpl = new(this, "MemberImpl");
					r_MemberImpl.SetBelong(this.instance);
				}
				return r_MemberImpl;
			}
		}

		/// <summary>
		/// System.String NameImpl
		/// </summary>
		protected RField r_NameImpl;
		public virtual RField RNameImpl
		{
			get
			{
				if(r_NameImpl == null)
				{
					r_NameImpl = new(this, "NameImpl");
					r_NameImpl.SetBelong(this.instance);
				}
				return r_NameImpl;
			}
		}

		/// <summary>
		/// System.Int32 PositionImpl
		/// </summary>
		protected RField r_PositionImpl;
		public virtual RField RPositionImpl
		{
			get
			{
				if(r_PositionImpl == null)
				{
					r_PositionImpl = new(this, "PositionImpl");
					r_PositionImpl.SetBelong(this.instance);
				}
				return r_PositionImpl;
			}
		}

		/// <summary>
		/// System.Int32 MetadataToken_ParamDef
		/// </summary>
		protected static RField r_MetadataToken_ParamDef;
		public static RField RMetadataToken_ParamDef
		{
			get
			{
				if(r_MetadataToken_ParamDef == null)
				{
					r_MetadataToken_ParamDef = new(typeof(System.Reflection.ParameterInfo), "MetadataToken_ParamDef");
					r_MetadataToken_ParamDef.SetBelong(null);
				}
				return r_MetadataToken_ParamDef;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterAttributes Attributes
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
		/// System.Reflection.MemberInfo Member
		/// </summary>
		protected RSystem.RReflection.RMemberInfo r_Member;
		public virtual RSystem.RReflection.RMemberInfo RMember
		{
			get
			{
				if(r_Member == null)
				{
					r_Member = new(this, "Member", -1);
					r_Member.SetBelong(this.instance);
				}
				return r_Member;
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
		/// System.Type ParameterType
		/// </summary>
		protected RSystem.RType r_ParameterType;
		public virtual RSystem.RType RParameterType
		{
			get
			{
				if(r_ParameterType == null)
				{
					r_ParameterType = new(this, "ParameterType", -1);
					r_ParameterType.SetBelong(this.instance);
				}
				return r_ParameterType;
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
		/// Boolean IsLcid
		/// </summary>
		protected RProperty r_IsLcid;
		public virtual RProperty RIsLcid
		{
			get
			{
				if(r_IsLcid == null)
				{
					r_IsLcid = new(this, "IsLcid", -1);
					r_IsLcid.SetBelong(this.instance);
				}
				return r_IsLcid;
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
		/// Boolean IsRetval
		/// </summary>
		protected RProperty r_IsRetval;
		public virtual RProperty RIsRetval
		{
			get
			{
				if(r_IsRetval == null)
				{
					r_IsRetval = new(this, "IsRetval", -1);
					r_IsRetval.SetBelong(this.instance);
				}
				return r_IsRetval;
			}
		}

		/// <summary>
		/// System.Object DefaultValue
		/// </summary>
		protected RSystem.RObject r_DefaultValue;
		public virtual RSystem.RObject RDefaultValue
		{
			get
			{
				if(r_DefaultValue == null)
				{
					r_DefaultValue = new(this, "DefaultValue", -1);
					r_DefaultValue.SetBelong(this.instance);
				}
				return r_DefaultValue;
			}
		}

		/// <summary>
		/// System.Object RawDefaultValue
		/// </summary>
		protected RSystem.RObject r_RawDefaultValue;
		public virtual RSystem.RObject RawDefaultValue
		{
			get
			{
				if(r_RawDefaultValue == null)
				{
					r_RawDefaultValue = new(this, "RawDefaultValue", -1);
					r_RawDefaultValue.SetBelong(this.instance);
				}
				return r_RawDefaultValue;
			}
		}

		/// <summary>
		/// Boolean HasDefaultValue
		/// </summary>
		protected RProperty r_HasDefaultValue;
		public virtual RProperty RHasDefaultValue
		{
			get
			{
				if(r_HasDefaultValue == null)
				{
					r_HasDefaultValue = new(this, "HasDefaultValue", -1);
					r_HasDefaultValue.SetBelong(this.instance);
				}
				return r_HasDefaultValue;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.CustomAttributeData] CustomAttributes
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RCustomAttributeData> r_CustomAttributes;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RCustomAttributeData> RCustomAttributes
		{
			get
			{
				if(r_CustomAttributes == null)
				{
					r_CustomAttributes = new(this, "CustomAttributes", -1);
					r_CustomAttributes.SetBelong(this.instance);
				}
				return r_CustomAttributes;
			}
		}

		/// <summary>
		/// Int32 MetadataToken
		/// </summary>
		protected RProperty r_MetadataToken;
		public virtual RProperty RMetadataToken
		{
			get
			{
				if(r_MetadataToken == null)
				{
					r_MetadataToken = new(this, "MetadataToken", -1);
					r_MetadataToken.SetBelong(this.instance);
				}
				return r_MetadataToken;
			}
		}

		/// <summary>
		/// Boolean IsDefined(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RIsDefined_Type_Boolean;
		public virtual RMethod RIsDefined_Type_Boolean
		{
			get
			{
				if(r_RIsDefined_Type_Boolean == null)
				{
					r_RIsDefined_Type_Boolean = new(this, "IsDefined", 0, typeof(System.Type), typeof(System.Boolean));
					r_RIsDefined_Type_Boolean.SetBelong(this.instance);
				}
				return r_RIsDefined_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributesData()
		/// </summary>
		protected RMethod r_RGetCustomAttributesData;
		public virtual RMethod RGetCustomAttributesData
		{
			get
			{
				if(r_RGetCustomAttributesData == null)
				{
					r_RGetCustomAttributesData = new(this, "GetCustomAttributesData", 0);
					r_RGetCustomAttributesData.SetBelong(this.instance);
				}
				return r_RGetCustomAttributesData;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(Boolean)
		/// </summary>
		protected RMethod r_RGetCustomAttributes_Boolean;
		public virtual RMethod RGetCustomAttributes_Boolean
		{
			get
			{
				if(r_RGetCustomAttributes_Boolean == null)
				{
					r_RGetCustomAttributes_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Boolean));
					r_RGetCustomAttributes_Boolean.SetBelong(this.instance);
				}
				return r_RGetCustomAttributes_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RGetCustomAttributes_Type_Boolean;
		public virtual RMethod RGetCustomAttributes_Type_Boolean
		{
			get
			{
				if(r_RGetCustomAttributes_Type_Boolean == null)
				{
					r_RGetCustomAttributes_Type_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Type), typeof(System.Boolean));
					r_RGetCustomAttributes_Type_Boolean.SetBelong(this.instance);
				}
				return r_RGetCustomAttributes_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Type[] GetOptionalCustomModifiers()
		/// </summary>
		protected RMethod r_RGetOptionalCustomModifiers;
		public virtual RMethod RGetOptionalCustomModifiers
		{
			get
			{
				if(r_RGetOptionalCustomModifiers == null)
				{
					r_RGetOptionalCustomModifiers = new(this, "GetOptionalCustomModifiers", 0);
					r_RGetOptionalCustomModifiers.SetBelong(this.instance);
				}
				return r_RGetOptionalCustomModifiers;
			}
		}

		/// <summary>
		/// System.Type[] GetRequiredCustomModifiers()
		/// </summary>
		protected RMethod r_RGetRequiredCustomModifiers;
		public virtual RMethod RGetRequiredCustomModifiers
		{
			get
			{
				if(r_RGetRequiredCustomModifiers == null)
				{
					r_RGetRequiredCustomModifiers = new(this, "GetRequiredCustomModifiers", 0);
					r_RGetRequiredCustomModifiers.SetBelong(this.instance);
				}
				return r_RGetRequiredCustomModifiers;
			}
		}

		/// <summary>
		/// System.Object GetRealObject(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RGetRealObject_StreamingContext;
		public virtual RMethod RGetRealObject_StreamingContext
		{
			get
			{
				if(r_RGetRealObject_StreamingContext == null)
				{
					r_RGetRealObject_StreamingContext = new(this, "GetRealObject", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_RGetRealObject_StreamingContext.SetBelong(this.instance);
				}
				return r_RGetRealObject_StreamingContext;
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
		/// Void System.Runtime.InteropServices._ParameterInfo.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ParameterInfo.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ParameterInfo.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ParameterInfo.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ParameterInfo.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._ParameterInfo.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ParameterInfo.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._ParameterInfo.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
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


        public RParameterInfo() : base("System.Reflection.ParameterInfo")
        {
        }

        public RParameterInfo(System.Object instance) : base("System.Reflection.ParameterInfo")
		{
            SetInstance(instance);
		}

        public RParameterInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RParameterInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean IsDefined(System.Type  @attributeType, System.Boolean  @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Boolean  @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inherit};
            var ___result = RGetCustomAttributes_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Type  @attributeType, System.Boolean  @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RGetCustomAttributes_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Type[] GetOptionalCustomModifiers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetOptionalCustomModifiers.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type[] GetRequiredCustomModifiers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRequiredCustomModifiers.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Object GetRealObject(System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context};
            var ___result = RGetRealObject_StreamingContext.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void System__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetIDsOfNames(in System.Guid  @riid, System.IntPtr  @rgszNames, System.UInt32  @cNames, System.UInt32  @lcid, System.IntPtr  @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetTypeInfo(System.UInt32  @iTInfo, System.UInt32  @lcid, System.IntPtr  @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetTypeInfoCount(out System.UInt32  @pcTInfo)
        {
			pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__0__Runtime__0__InteropServices__0___ParameterInfo__0__Invoke(System.UInt32  @dispIdMember, in System.Guid  @riid, System.UInt32  @lcid, System.Int16  @wFlags, System.IntPtr  @pDispParams, System.IntPtr  @pVarResult, System.IntPtr  @pExcepInfo, System.IntPtr  @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___ParameterInfo__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
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
