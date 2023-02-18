
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.RuntimeEventInfo
	/// </summary>
    public partial class RRuntimeEventInfo : RMember //
    {

		/// <summary>
		/// System.IntPtr klass
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fklass;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFklass
		{
			get
			{
				if(r_Fklass == null)
				{
					r_Fklass = new(this, "klass");
				}
				return r_Fklass;
			}
		}

		/// <summary>
		/// System.IntPtr handle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fhandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFhandle
		{
			get
			{
				if(r_Fhandle == null)
				{
					r_Fhandle = new(this, "handle");
				}
				return r_Fhandle;
			}
		}

		/// <summary>
		/// System.Reflection.Module Module
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RModule r_PModule;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RModule RPModule
		{
			get
			{
				if(r_PModule == null)
				{
					r_PModule = new(this, "Module", -1);
				}
				return r_PModule;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags BindingFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_PBindingFlags;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RPBindingFlags
		{
			get
			{
				if(r_PBindingFlags == null)
				{
					r_PBindingFlags = new(this, "BindingFlags", -1);
				}
				return r_PBindingFlags;
			}
		}

		/// <summary>
		/// System.RuntimeType ReflectedTypeInternal
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntimeType r_PReflectedTypeInternal;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntimeType RPReflectedTypeInternal
		{
			get
			{
				if(r_PReflectedTypeInternal == null)
				{
					r_PReflectedTypeInternal = new(this, "ReflectedTypeInternal", -1);
				}
				return r_PReflectedTypeInternal;
			}
		}

		/// <summary>
		/// System.Reflection.EventAttributes Attributes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.REventAttributes r_PAttributes;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.REventAttributes RPAttributes
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
		/// System.Type DeclaringType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_PDeclaringType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RPDeclaringType
		{
			get
			{
				if(r_PDeclaringType == null)
				{
					r_PDeclaringType = new(this, "DeclaringType", -1);
				}
				return r_PDeclaringType;
			}
		}

		/// <summary>
		/// System.Type ReflectedType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_PReflectedType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RPReflectedType
		{
			get
			{
				if(r_PReflectedType == null)
				{
					r_PReflectedType = new(this, "ReflectedType", -1);
				}
				return r_PReflectedType;
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
		/// Int32 MetadataToken
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PMetadataToken;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPMetadataToken
		{
			get
			{
				if(r_PMetadataToken == null)
				{
					r_PMetadataToken = new(this, "MetadataToken", -1);
				}
				return r_PMetadataToken;
			}
		}

		/// <summary>
		/// System.Reflection.MemberTypes MemberType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMemberTypes r_PMemberType;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMemberTypes RPMemberType
		{
			get
			{
				if(r_PMemberType == null)
				{
					r_PMemberType = new(this, "MemberType", -1);
				}
				return r_PMemberType;
			}
		}

		/// <summary>
		/// Boolean IsSpecialName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSpecialName;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSpecialName
		{
			get
			{
				if(r_PIsSpecialName == null)
				{
					r_PIsSpecialName = new(this, "IsSpecialName", -1);
				}
				return r_PIsSpecialName;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo AddMethod
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo r_PAddMethod;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo RPAddMethod
		{
			get
			{
				if(r_PAddMethod == null)
				{
					r_PAddMethod = new(this, "AddMethod", -1);
				}
				return r_PAddMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo RemoveMethod
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo r_PRemoveMethod;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo RPRemoveMethod
		{
			get
			{
				if(r_PRemoveMethod == null)
				{
					r_PRemoveMethod = new(this, "RemoveMethod", -1);
				}
				return r_PRemoveMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo RaiseMethod
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo r_PRaiseMethod;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo RPRaiseMethod
		{
			get
			{
				if(r_PRaiseMethod == null)
				{
					r_PRaiseMethod = new(this, "RaiseMethod", -1);
				}
				return r_PRaiseMethod;
			}
		}

		/// <summary>
		/// Boolean IsMulticast
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsMulticast;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsMulticast
		{
			get
			{
				if(r_PIsMulticast == null)
				{
					r_PIsMulticast = new(this, "IsMulticast", -1);
				}
				return r_PIsMulticast;
			}
		}

		/// <summary>
		/// System.Type EventHandlerType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_PEventHandlerType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RPEventHandlerType
		{
			get
			{
				if(r_PEventHandlerType == null)
				{
					r_PEventHandlerType = new(this, "EventHandlerType", -1);
				}
				return r_PEventHandlerType;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.CustomAttributeData] CustomAttributes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.RCustomAttributeData> r_PCustomAttributes;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RSystem.RReflection.RCustomAttributeData> RPCustomAttributes
		{
			get
			{
				if(r_PCustomAttributes == null)
				{
					r_PCustomAttributes = new(this, "CustomAttributes", -1);
				}
				return r_PCustomAttributes;
			}
		}

		/// <summary>
		/// Void get_event_info(System.Reflection.RuntimeEventInfo, System.Reflection.MonoEventInfo ByRef)
		/// </summary>
		protected static RMethod r_Mget_event_info_RuntimeEventInfo_Out_MonoEventInfo;
		public static RMethod RMget_event_info_RuntimeEventInfo_Out_MonoEventInfo
		{
			get
			{
				if(r_Mget_event_info_RuntimeEventInfo_Out_MonoEventInfo == null)
				{
					r_Mget_event_info_RuntimeEventInfo_Out_MonoEventInfo = new( ReflectionUtils.GetType("System.Reflection.RuntimeEventInfo"), "get_event_info", 0,  ReflectionUtils.GetType("System.Reflection.RuntimeEventInfo"),  ReflectionUtils.GetType("System.Reflection.MonoEventInfo").MakeByRefType());
				}
				return r_Mget_event_info_RuntimeEventInfo_Out_MonoEventInfo;
			}
		}

		/// <summary>
		/// System.Reflection.MonoEventInfo GetEventInfo(System.Reflection.RuntimeEventInfo)
		/// </summary>
		protected static RMethod r_MGetEventInfo_RuntimeEventInfo;
		public static RMethod RMGetEventInfo_RuntimeEventInfo
		{
			get
			{
				if(r_MGetEventInfo_RuntimeEventInfo == null)
				{
					r_MGetEventInfo_RuntimeEventInfo = new( ReflectionUtils.GetType("System.Reflection.RuntimeEventInfo"), "GetEventInfo", 0,  ReflectionUtils.GetType("System.Reflection.RuntimeEventInfo"));
				}
				return r_MGetEventInfo_RuntimeEventInfo;
			}
		}

		/// <summary>
		/// System.RuntimeType GetDeclaringTypeInternal()
		/// </summary>
		protected RMethod r_MGetDeclaringTypeInternal;
		public virtual RMethod RMGetDeclaringTypeInternal
		{
			get
			{
				if(r_MGetDeclaringTypeInternal == null)
				{
					r_MGetDeclaringTypeInternal = new(this, "GetDeclaringTypeInternal", 0);
				}
				return r_MGetDeclaringTypeInternal;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeModule GetRuntimeModule()
		/// </summary>
		protected RMethod r_MGetRuntimeModule;
		public virtual RMethod RMGetRuntimeModule
		{
			get
			{
				if(r_MGetRuntimeModule == null)
				{
					r_MGetRuntimeModule = new(this, "GetRuntimeModule", 0);
				}
				return r_MGetRuntimeModule;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MGetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RMGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_MGetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_MGetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
				}
				return r_MGetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags GetBindingFlags()
		/// </summary>
		protected RMethod r_MGetBindingFlags;
		public virtual RMethod RMGetBindingFlags
		{
			get
			{
				if(r_MGetBindingFlags == null)
				{
					r_MGetBindingFlags = new(this, "GetBindingFlags", 0);
				}
				return r_MGetBindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetAddMethod(Boolean)
		/// </summary>
		protected RMethod r_MGetAddMethod_Boolean;
		public virtual RMethod RMGetAddMethod_Boolean
		{
			get
			{
				if(r_MGetAddMethod_Boolean == null)
				{
					r_MGetAddMethod_Boolean = new(this, "GetAddMethod", 0, typeof(System.Boolean));
				}
				return r_MGetAddMethod_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetRaiseMethod(Boolean)
		/// </summary>
		protected RMethod r_MGetRaiseMethod_Boolean;
		public virtual RMethod RMGetRaiseMethod_Boolean
		{
			get
			{
				if(r_MGetRaiseMethod_Boolean == null)
				{
					r_MGetRaiseMethod_Boolean = new(this, "GetRaiseMethod", 0, typeof(System.Boolean));
				}
				return r_MGetRaiseMethod_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetRemoveMethod(Boolean)
		/// </summary>
		protected RMethod r_MGetRemoveMethod_Boolean;
		public virtual RMethod RMGetRemoveMethod_Boolean
		{
			get
			{
				if(r_MGetRemoveMethod_Boolean == null)
				{
					r_MGetRemoveMethod_Boolean = new(this, "GetRemoveMethod", 0, typeof(System.Boolean));
				}
				return r_MGetRemoveMethod_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetOtherMethods(Boolean)
		/// </summary>
		protected RMethod r_MGetOtherMethods_Boolean;
		public virtual RMethod RMGetOtherMethods_Boolean
		{
			get
			{
				if(r_MGetOtherMethods_Boolean == null)
				{
					r_MGetOtherMethods_Boolean = new(this, "GetOtherMethods", 0, typeof(System.Boolean));
				}
				return r_MGetOtherMethods_Boolean;
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
				}
				return r_MIsDefined_Type_Boolean;
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
				}
				return r_MGetCustomAttributes_Type_Boolean;
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
				}
				return r_MGetCustomAttributesData;
			}
		}

		/// <summary>
		/// Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_MHasSameMetadataDefinitionAs_MemberInfo;
		public virtual RMethod RMHasSameMetadataDefinitionAs_MemberInfo
		{
			get
			{
				if(r_MHasSameMetadataDefinitionAs_MemberInfo == null)
				{
					r_MHasSameMetadataDefinitionAs_MemberInfo = new(this, "HasSameMetadataDefinitionAs", 0, typeof(System.Reflection.MemberInfo));
				}
				return r_MHasSameMetadataDefinitionAs_MemberInfo;
			}
		}

		/// <summary>
		/// Int32 get_metadata_token(System.Reflection.RuntimeEventInfo)
		/// </summary>
		protected static RMethod r_Mget_metadata_token_RuntimeEventInfo;
		public static RMethod RMget_metadata_token_RuntimeEventInfo
		{
			get
			{
				if(r_Mget_metadata_token_RuntimeEventInfo == null)
				{
					r_Mget_metadata_token_RuntimeEventInfo = new( ReflectionUtils.GetType("System.Reflection.RuntimeEventInfo"), "get_metadata_token", 0,  ReflectionUtils.GetType("System.Reflection.RuntimeEventInfo"));
				}
				return r_Mget_metadata_token_RuntimeEventInfo;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetOtherMethods()
		/// </summary>
		protected RMethod r_MGetOtherMethods;
		public virtual RMethod RMGetOtherMethods
		{
			get
			{
				if(r_MGetOtherMethods == null)
				{
					r_MGetOtherMethods = new(this, "GetOtherMethods", 0);
				}
				return r_MGetOtherMethods;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetAddMethod()
		/// </summary>
		protected RMethod r_MGetAddMethod;
		public virtual RMethod RMGetAddMethod
		{
			get
			{
				if(r_MGetAddMethod == null)
				{
					r_MGetAddMethod = new(this, "GetAddMethod", 0);
				}
				return r_MGetAddMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetRemoveMethod()
		/// </summary>
		protected RMethod r_MGetRemoveMethod;
		public virtual RMethod RMGetRemoveMethod
		{
			get
			{
				if(r_MGetRemoveMethod == null)
				{
					r_MGetRemoveMethod = new(this, "GetRemoveMethod", 0);
				}
				return r_MGetRemoveMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetRaiseMethod()
		/// </summary>
		protected RMethod r_MGetRaiseMethod;
		public virtual RMethod RMGetRaiseMethod
		{
			get
			{
				if(r_MGetRaiseMethod == null)
				{
					r_MGetRaiseMethod = new(this, "GetRaiseMethod", 0);
				}
				return r_MGetRaiseMethod;
			}
		}

		/// <summary>
		/// Void RemoveEventHandler(System.Object, System.Delegate)
		/// </summary>
		protected RMethod r_MRemoveEventHandler_Object_Delegate;
		public virtual RMethod RMRemoveEventHandler_Object_Delegate
		{
			get
			{
				if(r_MRemoveEventHandler_Object_Delegate == null)
				{
					r_MRemoveEventHandler_Object_Delegate = new(this, "RemoveEventHandler", 0, typeof(System.Object), typeof(System.Delegate));
				}
				return r_MRemoveEventHandler_Object_Delegate;
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
		/// Void AddEventHandler(System.Object, System.Delegate)
		/// </summary>
		protected RMethod r_MAddEventHandler_Object_Delegate;
		public virtual RMethod RMAddEventHandler_Object_Delegate
		{
			get
			{
				if(r_MAddEventHandler_Object_Delegate == null)
				{
					r_MAddEventHandler_Object_Delegate = new(this, "AddEventHandler", 0, typeof(System.Object), typeof(System.Delegate));
				}
				return r_MAddEventHandler_Object_Delegate;
			}
		}

		/// <summary>
		/// Boolean CacheEquals(System.Object)
		/// </summary>
		protected RMethod r_MCacheEquals_Object;
		public virtual RMethod RMCacheEquals_Object
		{
			get
			{
				if(r_MCacheEquals_Object == null)
				{
					r_MCacheEquals_Object = new(this, "CacheEquals", 0, typeof(System.Object));
				}
				return r_MCacheEquals_Object;
			}
		}

		/// <summary>
		/// Boolean HasSameMetadataDefinitionAsCore[TOther](System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo;
		public virtual RMethod RMHasSameMetadataDefinitionAsCore_GTOther_MemberInfo
		{
			get
			{
				if(r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo == null)
				{
					r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo = new(this, "HasSameMetadataDefinitionAsCore", 1, typeof(System.Reflection.MemberInfo));
				}
				return r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo;
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


        public RRuntimeEventInfo() : base("System.Reflection.RuntimeEventInfo")
        {
        }

        public RRuntimeEventInfo(System.Object instance) : base("System.Reflection.RuntimeEventInfo")
		{
            SetInstance(instance);
		}

        public RRuntimeEventInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRuntimeEventInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void get_event_info(Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeEventInfo @ev, out Hvak.Editor.Refleaction.RSystem.RReflection.RMonoEventInfo @info)
        {
			@info = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ev.Value, @info.Value};
            var ___result = RMget_event_info_RuntimeEventInfo_Out_MonoEventInfo.Invoke(___genericsType, ___parameters);
			@info = new Hvak.Editor.Refleaction.RSystem.RReflection.RMonoEventInfo(___parameters[1]);

            
        }


        public static Hvak.Editor.Refleaction.RSystem.RReflection.RMonoEventInfo GetEventInfo(Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeEventInfo @ev)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ev.Value};
            var ___result = RMGetEventInfo_RuntimeEventInfo.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RReflection.RMonoEventInfo(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RRuntimeType GetDeclaringTypeInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDeclaringTypeInternal.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RRuntimeType(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeModule GetRuntimeModule()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRuntimeModule.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeModule(___result);
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.BindingFlags GetBindingFlags()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetBindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.BindingFlags)___result;
        }


        public virtual System.Reflection.MethodInfo GetAddMethod(System.Boolean @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RMGetAddMethod_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetRaiseMethod(System.Boolean @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RMGetRaiseMethod_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetRemoveMethod(System.Boolean @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RMGetRemoveMethod_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo[] GetOtherMethods(System.Boolean @nonPublic)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nonPublic};
            var ___result = RMGetOtherMethods_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean IsDefined(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual System.Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMHasSameMetadataDefinitionAs_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 get_metadata_token(Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeEventInfo @monoEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@monoEvent.Value};
            var ___result = RMget_metadata_token_RuntimeEventInfo.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Reflection.MethodInfo[] GetOtherMethods()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetOtherMethods.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo GetAddMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAddMethod.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetRemoveMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRemoveMethod.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetRaiseMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRaiseMethod.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual void RemoveEventHandler(System.Object @target, System.Delegate @handler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @handler};
            var ___result = RMRemoveEventHandler_Object_Delegate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void AddEventHandler(System.Object @target, System.Delegate @handler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @handler};
            var ___result = RMAddEventHandler_Object_Delegate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CacheEquals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMCacheEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasSameMetadataDefinitionAsCore<TOther>(System.Reflection.MemberInfo @other) where TOther : System.Reflection.MemberInfo
        {

            var ___genericsType = new Type[] {typeof(TOther)};
            var ___parameters = new object[]{@other};
            var ___result = RMHasSameMetadataDefinitionAsCore_GTOther_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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
