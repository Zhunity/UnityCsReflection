
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
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RParameterAttributes r_FAttrsImpl;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RParameterAttributes RFAttrsImpl
		{
			get
			{
				if(r_FAttrsImpl == null)
				{
					r_FAttrsImpl = new(this, "AttrsImpl");
					r_FAttrsImpl.SetBelong(this.instance);
				}
				return r_FAttrsImpl;
			}
		}

		/// <summary>
		/// System.Type ClassImpl
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_FClassImpl;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RFClassImpl
		{
			get
			{
				if(r_FClassImpl == null)
				{
					r_FClassImpl = new(this, "ClassImpl");
					r_FClassImpl.SetBelong(this.instance);
				}
				return r_FClassImpl;
			}
		}

		/// <summary>
		/// System.Object DefaultValueImpl
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RObject r_FDefaultValueImpl;
		public virtual SMFrame.Editor.Refleaction.RSystem.RObject RFDefaultValueImpl
		{
			get
			{
				if(r_FDefaultValueImpl == null)
				{
					r_FDefaultValueImpl = new(this, "DefaultValueImpl");
					r_FDefaultValueImpl.SetBelong(this.instance);
				}
				return r_FDefaultValueImpl;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo MemberImpl
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RMemberInfo r_FMemberImpl;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RMemberInfo RFMemberImpl
		{
			get
			{
				if(r_FMemberImpl == null)
				{
					r_FMemberImpl = new(this, "MemberImpl");
					r_FMemberImpl.SetBelong(this.instance);
				}
				return r_FMemberImpl;
			}
		}

		/// <summary>
		/// System.String NameImpl
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_FNameImpl;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFNameImpl
		{
			get
			{
				if(r_FNameImpl == null)
				{
					r_FNameImpl = new(this, "NameImpl");
					r_FNameImpl.SetBelong(this.instance);
				}
				return r_FNameImpl;
			}
		}

		/// <summary>
		/// System.Int32 PositionImpl
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_FPositionImpl;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFPositionImpl
		{
			get
			{
				if(r_FPositionImpl == null)
				{
					r_FPositionImpl = new(this, "PositionImpl");
					r_FPositionImpl.SetBelong(this.instance);
				}
				return r_FPositionImpl;
			}
		}

		/// <summary>
		/// System.Int32 MetadataToken_ParamDef
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RInt32 r_FMetadataToken_ParamDef;
		public static SMFrame.Editor.Refleaction.RSystem.RInt32 RFMetadataToken_ParamDef
		{
			get
			{
				if(r_FMetadataToken_ParamDef == null)
				{
					r_FMetadataToken_ParamDef = new(typeof(System.Reflection.ParameterInfo), "MetadataToken_ParamDef");
					r_FMetadataToken_ParamDef.SetBelong(null);
				}
				return r_FMetadataToken_ParamDef;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterAttributes Attributes
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RParameterAttributes r_PAttributes;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RParameterAttributes RPAttributes
		{
			get
			{
				if(r_PAttributes == null)
				{
					r_PAttributes = new(this, "Attributes", -1);
					r_PAttributes.SetBelong(this.instance);
				}
				return r_PAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo Member
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RMemberInfo r_PMember;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RMemberInfo RPMember
		{
			get
			{
				if(r_PMember == null)
				{
					r_PMember = new(this, "Member", -1);
					r_PMember.SetBelong(this.instance);
				}
				return r_PMember;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
					r_PName.SetBelong(this.instance);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// System.Type ParameterType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_PParameterType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RPParameterType
		{
			get
			{
				if(r_PParameterType == null)
				{
					r_PParameterType = new(this, "ParameterType", -1);
					r_PParameterType.SetBelong(this.instance);
				}
				return r_PParameterType;
			}
		}

		/// <summary>
		/// Int32 Position
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PPosition;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPPosition
		{
			get
			{
				if(r_PPosition == null)
				{
					r_PPosition = new(this, "Position", -1);
					r_PPosition.SetBelong(this.instance);
				}
				return r_PPosition;
			}
		}

		/// <summary>
		/// Boolean IsIn
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsIn;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsIn
		{
			get
			{
				if(r_PIsIn == null)
				{
					r_PIsIn = new(this, "IsIn", -1);
					r_PIsIn.SetBelong(this.instance);
				}
				return r_PIsIn;
			}
		}

		/// <summary>
		/// Boolean IsLcid
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsLcid;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsLcid
		{
			get
			{
				if(r_PIsLcid == null)
				{
					r_PIsLcid = new(this, "IsLcid", -1);
					r_PIsLcid.SetBelong(this.instance);
				}
				return r_PIsLcid;
			}
		}

		/// <summary>
		/// Boolean IsOptional
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsOptional;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsOptional
		{
			get
			{
				if(r_PIsOptional == null)
				{
					r_PIsOptional = new(this, "IsOptional", -1);
					r_PIsOptional.SetBelong(this.instance);
				}
				return r_PIsOptional;
			}
		}

		/// <summary>
		/// Boolean IsOut
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsOut;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsOut
		{
			get
			{
				if(r_PIsOut == null)
				{
					r_PIsOut = new(this, "IsOut", -1);
					r_PIsOut.SetBelong(this.instance);
				}
				return r_PIsOut;
			}
		}

		/// <summary>
		/// Boolean IsRetval
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsRetval;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsRetval
		{
			get
			{
				if(r_PIsRetval == null)
				{
					r_PIsRetval = new(this, "IsRetval", -1);
					r_PIsRetval.SetBelong(this.instance);
				}
				return r_PIsRetval;
			}
		}

		/// <summary>
		/// System.Object DefaultValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RObject r_PDefaultValue;
		public virtual SMFrame.Editor.Refleaction.RSystem.RObject RPDefaultValue
		{
			get
			{
				if(r_PDefaultValue == null)
				{
					r_PDefaultValue = new(this, "DefaultValue", -1);
					r_PDefaultValue.SetBelong(this.instance);
				}
				return r_PDefaultValue;
			}
		}

		/// <summary>
		/// System.Object RawDefaultValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RObject r_PRawDefaultValue;
		public virtual SMFrame.Editor.Refleaction.RSystem.RObject RPRawDefaultValue
		{
			get
			{
				if(r_PRawDefaultValue == null)
				{
					r_PRawDefaultValue = new(this, "RawDefaultValue", -1);
					r_PRawDefaultValue.SetBelong(this.instance);
				}
				return r_PRawDefaultValue;
			}
		}

		/// <summary>
		/// Boolean HasDefaultValue
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PHasDefaultValue;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPHasDefaultValue
		{
			get
			{
				if(r_PHasDefaultValue == null)
				{
					r_PHasDefaultValue = new(this, "HasDefaultValue", -1);
					r_PHasDefaultValue.SetBelong(this.instance);
				}
				return r_PHasDefaultValue;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.CustomAttributeData] CustomAttributes
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RSystem.RReflection.RCustomAttributeData> r_PCustomAttributes;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RSystem.RReflection.RCustomAttributeData> RPCustomAttributes
		{
			get
			{
				if(r_PCustomAttributes == null)
				{
					r_PCustomAttributes = new(this, "CustomAttributes", -1);
					r_PCustomAttributes.SetBelong(this.instance);
				}
				return r_PCustomAttributes;
			}
		}

		/// <summary>
		/// Int32 MetadataToken
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PMetadataToken;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPMetadataToken
		{
			get
			{
				if(r_PMetadataToken == null)
				{
					r_PMetadataToken = new(this, "MetadataToken", -1);
					r_PMetadataToken.SetBelong(this.instance);
				}
				return r_PMetadataToken;
			}
		}

		/// <summary>
		/// Boolean IsDefined(System.Type, Boolean)
		/// </summary>
		protected RMethod r_MIsDefined_Type_Boolean;
		public virtual RMethod RMIsDefined_Type_Boolean
		{
			get
			{
				if(r_MIsDefined_Type_Boolean == null)
				{
					r_MIsDefined_Type_Boolean = new(this, "IsDefined", 0, typeof(System.Type), typeof(System.Boolean));
					r_MIsDefined_Type_Boolean.SetBelong(this.instance);
				}
				return r_MIsDefined_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributesData()
		/// </summary>
		protected RMethod r_MGetCustomAttributesData;
		public virtual RMethod RMGetCustomAttributesData
		{
			get
			{
				if(r_MGetCustomAttributesData == null)
				{
					r_MGetCustomAttributesData = new(this, "GetCustomAttributesData", 0);
					r_MGetCustomAttributesData.SetBelong(this.instance);
				}
				return r_MGetCustomAttributesData;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(Boolean)
		/// </summary>
		protected RMethod r_MGetCustomAttributes_Boolean;
		public virtual RMethod RMGetCustomAttributes_Boolean
		{
			get
			{
				if(r_MGetCustomAttributes_Boolean == null)
				{
					r_MGetCustomAttributes_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Boolean));
					r_MGetCustomAttributes_Boolean.SetBelong(this.instance);
				}
				return r_MGetCustomAttributes_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(System.Type, Boolean)
		/// </summary>
		protected RMethod r_MGetCustomAttributes_Type_Boolean;
		public virtual RMethod RMGetCustomAttributes_Type_Boolean
		{
			get
			{
				if(r_MGetCustomAttributes_Type_Boolean == null)
				{
					r_MGetCustomAttributes_Type_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Type), typeof(System.Boolean));
					r_MGetCustomAttributes_Type_Boolean.SetBelong(this.instance);
				}
				return r_MGetCustomAttributes_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Type[] GetOptionalCustomModifiers()
		/// </summary>
		protected RMethod r_MGetOptionalCustomModifiers;
		public virtual RMethod RMGetOptionalCustomModifiers
		{
			get
			{
				if(r_MGetOptionalCustomModifiers == null)
				{
					r_MGetOptionalCustomModifiers = new(this, "GetOptionalCustomModifiers", 0);
					r_MGetOptionalCustomModifiers.SetBelong(this.instance);
				}
				return r_MGetOptionalCustomModifiers;
			}
		}

		/// <summary>
		/// System.Type[] GetRequiredCustomModifiers()
		/// </summary>
		protected RMethod r_MGetRequiredCustomModifiers;
		public virtual RMethod RMGetRequiredCustomModifiers
		{
			get
			{
				if(r_MGetRequiredCustomModifiers == null)
				{
					r_MGetRequiredCustomModifiers = new(this, "GetRequiredCustomModifiers", 0);
					r_MGetRequiredCustomModifiers.SetBelong(this.instance);
				}
				return r_MGetRequiredCustomModifiers;
			}
		}

		/// <summary>
		/// System.Object GetRealObject(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MGetRealObject_StreamingContext;
		public virtual RMethod RMGetRealObject_StreamingContext
		{
			get
			{
				if(r_MGetRealObject_StreamingContext == null)
				{
					r_MGetRealObject_StreamingContext = new(this, "GetRealObject", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_MGetRealObject_StreamingContext.SetBelong(this.instance);
				}
				return r_MGetRealObject_StreamingContext;
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ParameterInfo.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ParameterInfo.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ParameterInfo.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ParameterInfo.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ParameterInfo.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._ParameterInfo.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_MSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ParameterInfo.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._ParameterInfo.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
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

        public virtual System.Boolean IsDefined(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inherit};
            var ___result = RMGetCustomAttributes_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Object[] GetCustomAttributes(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMGetCustomAttributes_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Type[] GetOptionalCustomModifiers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetOptionalCustomModifiers.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type[] GetRequiredCustomModifiers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRequiredCustomModifiers.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Object GetRealObject(System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context};
            var ___result = RMGetRealObject_StreamingContext.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ParameterInfo__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ParameterInfo__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
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
