
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.RuntimeMethodInfo
	/// </summary>
    public partial class RRuntimeMethodInfo : RMember //
    {

		/// <summary>
		/// System.IntPtr mhandle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fmhandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFmhandle
		{
			get
			{
				if(r_Fmhandle == null)
				{
					r_Fmhandle = new(this, "mhandle");
					r_Fmhandle.SetBelong(this.GetValue());
				}
				return r_Fmhandle;
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
					r_Fname.SetBelong(this.GetValue());
				}
				return r_Fname;
			}
		}

		/// <summary>
		/// System.Type reftype
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_Freftype;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RFreftype
		{
			get
			{
				if(r_Freftype == null)
				{
					r_Freftype = new(this, "reftype");
					r_Freftype.SetBelong(this.GetValue());
				}
				return r_Freftype;
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
					r_PBindingFlags.SetBelong(this.GetValue());
				}
				return r_PBindingFlags;
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
					r_PModule.SetBelong(this.GetValue());
				}
				return r_PModule;
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
					r_PReflectedTypeInternal.SetBelong(this.GetValue());
				}
				return r_PReflectedTypeInternal;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterInfo ReturnParameter
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RParameterInfo r_PReturnParameter;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RParameterInfo RPReturnParameter
		{
			get
			{
				if(r_PReturnParameter == null)
				{
					r_PReturnParameter = new(this, "ReturnParameter", -1);
					r_PReturnParameter.SetBelong(this.GetValue());
				}
				return r_PReturnParameter;
			}
		}

		/// <summary>
		/// System.Type ReturnType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_PReturnType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RPReturnType
		{
			get
			{
				if(r_PReturnType == null)
				{
					r_PReturnType = new(this, "ReturnType", -1);
					r_PReturnType.SetBelong(this.GetValue());
				}
				return r_PReturnType;
			}
		}

		/// <summary>
		/// System.Reflection.ICustomAttributeProvider ReturnTypeCustomAttributes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RICustomAttributeProvider r_PReturnTypeCustomAttributes;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RICustomAttributeProvider RPReturnTypeCustomAttributes
		{
			get
			{
				if(r_PReturnTypeCustomAttributes == null)
				{
					r_PReturnTypeCustomAttributes = new(this, "ReturnTypeCustomAttributes", -1);
					r_PReturnTypeCustomAttributes.SetBelong(this.GetValue());
				}
				return r_PReturnTypeCustomAttributes;
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
					r_PMetadataToken.SetBelong(this.GetValue());
				}
				return r_PMetadataToken;
			}
		}

		/// <summary>
		/// System.RuntimeMethodHandle MethodHandle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntimeMethodHandle r_PMethodHandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntimeMethodHandle RPMethodHandle
		{
			get
			{
				if(r_PMethodHandle == null)
				{
					r_PMethodHandle = new(this, "MethodHandle", -1);
					r_PMethodHandle.SetBelong(this.GetValue());
				}
				return r_PMethodHandle;
			}
		}

		/// <summary>
		/// System.Reflection.MethodAttributes Attributes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_PAttributes;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RPAttributes
		{
			get
			{
				if(r_PAttributes == null)
				{
					r_PAttributes = new(this, "Attributes", -1);
					r_PAttributes.SetBelong(this.GetValue());
				}
				return r_PAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.CallingConventions CallingConvention
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RCallingConventions r_PCallingConvention;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RCallingConventions RPCallingConvention
		{
			get
			{
				if(r_PCallingConvention == null)
				{
					r_PCallingConvention = new(this, "CallingConvention", -1);
					r_PCallingConvention.SetBelong(this.GetValue());
				}
				return r_PCallingConvention;
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
					r_PReflectedType.SetBelong(this.GetValue());
				}
				return r_PReflectedType;
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
					r_PDeclaringType.SetBelong(this.GetValue());
				}
				return r_PDeclaringType;
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
					r_PName.SetBelong(this.GetValue());
				}
				return r_PName;
			}
		}

		/// <summary>
		/// Boolean IsGenericMethodDefinition
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsGenericMethodDefinition;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsGenericMethodDefinition
		{
			get
			{
				if(r_PIsGenericMethodDefinition == null)
				{
					r_PIsGenericMethodDefinition = new(this, "IsGenericMethodDefinition", -1);
					r_PIsGenericMethodDefinition.SetBelong(this.GetValue());
				}
				return r_PIsGenericMethodDefinition;
			}
		}

		/// <summary>
		/// Boolean IsGenericMethod
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsGenericMethod;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsGenericMethod
		{
			get
			{
				if(r_PIsGenericMethod == null)
				{
					r_PIsGenericMethod = new(this, "IsGenericMethod", -1);
					r_PIsGenericMethod.SetBelong(this.GetValue());
				}
				return r_PIsGenericMethod;
			}
		}

		/// <summary>
		/// Boolean ContainsGenericParameters
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PContainsGenericParameters;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPContainsGenericParameters
		{
			get
			{
				if(r_PContainsGenericParameters == null)
				{
					r_PContainsGenericParameters = new(this, "ContainsGenericParameters", -1);
					r_PContainsGenericParameters.SetBelong(this.GetValue());
				}
				return r_PContainsGenericParameters;
			}
		}

		/// <summary>
		/// Boolean IsSecurityTransparent
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSecurityTransparent;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSecurityTransparent
		{
			get
			{
				if(r_PIsSecurityTransparent == null)
				{
					r_PIsSecurityTransparent = new(this, "IsSecurityTransparent", -1);
					r_PIsSecurityTransparent.SetBelong(this.GetValue());
				}
				return r_PIsSecurityTransparent;
			}
		}

		/// <summary>
		/// Boolean IsSecurityCritical
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSecurityCritical;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSecurityCritical
		{
			get
			{
				if(r_PIsSecurityCritical == null)
				{
					r_PIsSecurityCritical = new(this, "IsSecurityCritical", -1);
					r_PIsSecurityCritical.SetBelong(this.GetValue());
				}
				return r_PIsSecurityCritical;
			}
		}

		/// <summary>
		/// Boolean IsSecuritySafeCritical
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSecuritySafeCritical;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSecuritySafeCritical
		{
			get
			{
				if(r_PIsSecuritySafeCritical == null)
				{
					r_PIsSecuritySafeCritical = new(this, "IsSecuritySafeCritical", -1);
					r_PIsSecuritySafeCritical.SetBelong(this.GetValue());
				}
				return r_PIsSecuritySafeCritical;
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
					r_PMemberType.SetBelong(this.GetValue());
				}
				return r_PMemberType;
			}
		}

		/// <summary>
		/// Int32 GenericParameterCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PGenericParameterCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPGenericParameterCount
		{
			get
			{
				if(r_PGenericParameterCount == null)
				{
					r_PGenericParameterCount = new(this, "GenericParameterCount", -1);
					r_PGenericParameterCount.SetBelong(this.GetValue());
				}
				return r_PGenericParameterCount;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes MethodImplementationFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes r_PMethodImplementationFlags;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes RPMethodImplementationFlags
		{
			get
			{
				if(r_PMethodImplementationFlags == null)
				{
					r_PMethodImplementationFlags = new(this, "MethodImplementationFlags", -1);
					r_PMethodImplementationFlags.SetBelong(this.GetValue());
				}
				return r_PMethodImplementationFlags;
			}
		}

		/// <summary>
		/// Boolean IsAbstract
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsAbstract;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsAbstract
		{
			get
			{
				if(r_PIsAbstract == null)
				{
					r_PIsAbstract = new(this, "IsAbstract", -1);
					r_PIsAbstract.SetBelong(this.GetValue());
				}
				return r_PIsAbstract;
			}
		}

		/// <summary>
		/// Boolean IsConstructor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsConstructor;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsConstructor
		{
			get
			{
				if(r_PIsConstructor == null)
				{
					r_PIsConstructor = new(this, "IsConstructor", -1);
					r_PIsConstructor.SetBelong(this.GetValue());
				}
				return r_PIsConstructor;
			}
		}

		/// <summary>
		/// Boolean IsFinal
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsFinal;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsFinal
		{
			get
			{
				if(r_PIsFinal == null)
				{
					r_PIsFinal = new(this, "IsFinal", -1);
					r_PIsFinal.SetBelong(this.GetValue());
				}
				return r_PIsFinal;
			}
		}

		/// <summary>
		/// Boolean IsHideBySig
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsHideBySig;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsHideBySig
		{
			get
			{
				if(r_PIsHideBySig == null)
				{
					r_PIsHideBySig = new(this, "IsHideBySig", -1);
					r_PIsHideBySig.SetBelong(this.GetValue());
				}
				return r_PIsHideBySig;
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
					r_PIsSpecialName.SetBelong(this.GetValue());
				}
				return r_PIsSpecialName;
			}
		}

		/// <summary>
		/// Boolean IsStatic
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsStatic;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsStatic
		{
			get
			{
				if(r_PIsStatic == null)
				{
					r_PIsStatic = new(this, "IsStatic", -1);
					r_PIsStatic.SetBelong(this.GetValue());
				}
				return r_PIsStatic;
			}
		}

		/// <summary>
		/// Boolean IsVirtual
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsVirtual;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsVirtual
		{
			get
			{
				if(r_PIsVirtual == null)
				{
					r_PIsVirtual = new(this, "IsVirtual", -1);
					r_PIsVirtual.SetBelong(this.GetValue());
				}
				return r_PIsVirtual;
			}
		}

		/// <summary>
		/// Boolean IsAssembly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsAssembly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsAssembly
		{
			get
			{
				if(r_PIsAssembly == null)
				{
					r_PIsAssembly = new(this, "IsAssembly", -1);
					r_PIsAssembly.SetBelong(this.GetValue());
				}
				return r_PIsAssembly;
			}
		}

		/// <summary>
		/// Boolean IsFamily
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsFamily;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsFamily
		{
			get
			{
				if(r_PIsFamily == null)
				{
					r_PIsFamily = new(this, "IsFamily", -1);
					r_PIsFamily.SetBelong(this.GetValue());
				}
				return r_PIsFamily;
			}
		}

		/// <summary>
		/// Boolean IsFamilyAndAssembly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsFamilyAndAssembly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsFamilyAndAssembly
		{
			get
			{
				if(r_PIsFamilyAndAssembly == null)
				{
					r_PIsFamilyAndAssembly = new(this, "IsFamilyAndAssembly", -1);
					r_PIsFamilyAndAssembly.SetBelong(this.GetValue());
				}
				return r_PIsFamilyAndAssembly;
			}
		}

		/// <summary>
		/// Boolean IsFamilyOrAssembly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsFamilyOrAssembly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsFamilyOrAssembly
		{
			get
			{
				if(r_PIsFamilyOrAssembly == null)
				{
					r_PIsFamilyOrAssembly = new(this, "IsFamilyOrAssembly", -1);
					r_PIsFamilyOrAssembly.SetBelong(this.GetValue());
				}
				return r_PIsFamilyOrAssembly;
			}
		}

		/// <summary>
		/// Boolean IsPrivate
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsPrivate;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsPrivate
		{
			get
			{
				if(r_PIsPrivate == null)
				{
					r_PIsPrivate = new(this, "IsPrivate", -1);
					r_PIsPrivate.SetBelong(this.GetValue());
				}
				return r_PIsPrivate;
			}
		}

		/// <summary>
		/// Boolean IsPublic
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsPublic;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsPublic
		{
			get
			{
				if(r_PIsPublic == null)
				{
					r_PIsPublic = new(this, "IsPublic", -1);
					r_PIsPublic.SetBelong(this.GetValue());
				}
				return r_PIsPublic;
			}
		}

		/// <summary>
		/// Boolean IsConstructedGenericMethod
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsConstructedGenericMethod;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsConstructedGenericMethod
		{
			get
			{
				if(r_PIsConstructedGenericMethod == null)
				{
					r_PIsConstructedGenericMethod = new(this, "IsConstructedGenericMethod", -1);
					r_PIsConstructedGenericMethod.SetBelong(this.GetValue());
				}
				return r_PIsConstructedGenericMethod;
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
					r_PCustomAttributes.SetBelong(this.GetValue());
				}
				return r_PCustomAttributes;
			}
		}

		/// <summary>
		/// System.String FormatNameAndSig(Boolean)
		/// </summary>
		protected RMethod r_MFormatNameAndSig_Boolean;
		public virtual RMethod RMFormatNameAndSig_Boolean
		{
			get
			{
				if(r_MFormatNameAndSig_Boolean == null)
				{
					r_MFormatNameAndSig_Boolean = new(this, "FormatNameAndSig", 0, typeof(System.Boolean));
					r_MFormatNameAndSig_Boolean.SetBelong(this.GetValue());
				}
				return r_MFormatNameAndSig_Boolean;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type)
		/// </summary>
		protected RMethod r_MCreateDelegate_Type;
		public virtual RMethod RMCreateDelegate_Type
		{
			get
			{
				if(r_MCreateDelegate_Type == null)
				{
					r_MCreateDelegate_Type = new(this, "CreateDelegate", 0, typeof(System.Type));
					r_MCreateDelegate_Type.SetBelong(this.GetValue());
				}
				return r_MCreateDelegate_Type;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Object)
		/// </summary>
		protected RMethod r_MCreateDelegate_Type_Object;
		public virtual RMethod RMCreateDelegate_Type_Object
		{
			get
			{
				if(r_MCreateDelegate_Type_Object == null)
				{
					r_MCreateDelegate_Type_Object = new(this, "CreateDelegate", 0, typeof(System.Type), typeof(System.Object));
					r_MCreateDelegate_Type_Object.SetBelong(this.GetValue());
				}
				return r_MCreateDelegate_Type_Object;
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
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
					r_MGetRuntimeModule.SetBelong(this.GetValue());
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
					r_MGetObjectData_SerializationInfo_StreamingContext.SetBelong(this.GetValue());
				}
				return r_MGetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// System.String SerializationToString()
		/// </summary>
		protected RMethod r_MSerializationToString;
		public virtual RMethod RMSerializationToString
		{
			get
			{
				if(r_MSerializationToString == null)
				{
					r_MSerializationToString = new(this, "SerializationToString", 0);
					r_MSerializationToString.SetBelong(this.GetValue());
				}
				return r_MSerializationToString;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase GetMethodFromHandleNoGenericCheck(System.RuntimeMethodHandle)
		/// </summary>
		protected static RMethod r_MGetMethodFromHandleNoGenericCheck_RuntimeMethodHandle;
		public static RMethod RMGetMethodFromHandleNoGenericCheck_RuntimeMethodHandle
		{
			get
			{
				if(r_MGetMethodFromHandleNoGenericCheck_RuntimeMethodHandle == null)
				{
					r_MGetMethodFromHandleNoGenericCheck_RuntimeMethodHandle = new( ReflectionUtils.GetType("System.Reflection.RuntimeMethodInfo"), "GetMethodFromHandleNoGenericCheck", 0, typeof(System.RuntimeMethodHandle));
					r_MGetMethodFromHandleNoGenericCheck_RuntimeMethodHandle.SetBelong(null);
				}
				return r_MGetMethodFromHandleNoGenericCheck_RuntimeMethodHandle;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase GetMethodFromHandleNoGenericCheck(System.RuntimeMethodHandle, System.RuntimeTypeHandle)
		/// </summary>
		protected static RMethod r_MGetMethodFromHandleNoGenericCheck_RuntimeMethodHandle_RuntimeTypeHandle;
		public static RMethod RMGetMethodFromHandleNoGenericCheck_RuntimeMethodHandle_RuntimeTypeHandle
		{
			get
			{
				if(r_MGetMethodFromHandleNoGenericCheck_RuntimeMethodHandle_RuntimeTypeHandle == null)
				{
					r_MGetMethodFromHandleNoGenericCheck_RuntimeMethodHandle_RuntimeTypeHandle = new( ReflectionUtils.GetType("System.Reflection.RuntimeMethodInfo"), "GetMethodFromHandleNoGenericCheck", 0, typeof(System.RuntimeMethodHandle), typeof(System.RuntimeTypeHandle));
					r_MGetMethodFromHandleNoGenericCheck_RuntimeMethodHandle_RuntimeTypeHandle.SetBelong(null);
				}
				return r_MGetMethodFromHandleNoGenericCheck_RuntimeMethodHandle_RuntimeTypeHandle;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBody GetMethodBodyInternal(IntPtr)
		/// </summary>
		protected static RMethod r_MGetMethodBodyInternal_IntPtr;
		public static RMethod RMGetMethodBodyInternal_IntPtr
		{
			get
			{
				if(r_MGetMethodBodyInternal_IntPtr == null)
				{
					r_MGetMethodBodyInternal_IntPtr = new( ReflectionUtils.GetType("System.Reflection.RuntimeMethodInfo"), "GetMethodBodyInternal", 0, typeof(System.IntPtr));
					r_MGetMethodBodyInternal_IntPtr.SetBelong(null);
				}
				return r_MGetMethodBodyInternal_IntPtr;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBody GetMethodBody(IntPtr)
		/// </summary>
		protected static RMethod r_MGetMethodBody_IntPtr;
		public static RMethod RMGetMethodBody_IntPtr
		{
			get
			{
				if(r_MGetMethodBody_IntPtr == null)
				{
					r_MGetMethodBody_IntPtr = new( ReflectionUtils.GetType("System.Reflection.RuntimeMethodInfo"), "GetMethodBody", 0, typeof(System.IntPtr));
					r_MGetMethodBody_IntPtr.SetBelong(null);
				}
				return r_MGetMethodBody_IntPtr;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase GetMethodFromHandleInternalType(IntPtr, IntPtr)
		/// </summary>
		protected static RMethod r_MGetMethodFromHandleInternalType_IntPtr_IntPtr;
		public static RMethod RMGetMethodFromHandleInternalType_IntPtr_IntPtr
		{
			get
			{
				if(r_MGetMethodFromHandleInternalType_IntPtr_IntPtr == null)
				{
					r_MGetMethodFromHandleInternalType_IntPtr_IntPtr = new( ReflectionUtils.GetType("System.Reflection.RuntimeMethodInfo"), "GetMethodFromHandleInternalType", 0, typeof(System.IntPtr), typeof(System.IntPtr));
					r_MGetMethodFromHandleInternalType_IntPtr_IntPtr.SetBelong(null);
				}
				return r_MGetMethodFromHandleInternalType_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase GetMethodFromHandleInternalType_native(IntPtr, IntPtr, Boolean)
		/// </summary>
		protected static RMethod r_MGetMethodFromHandleInternalType_native_IntPtr_IntPtr_Boolean;
		public static RMethod RMGetMethodFromHandleInternalType_native_IntPtr_IntPtr_Boolean
		{
			get
			{
				if(r_MGetMethodFromHandleInternalType_native_IntPtr_IntPtr_Boolean == null)
				{
					r_MGetMethodFromHandleInternalType_native_IntPtr_IntPtr_Boolean = new( ReflectionUtils.GetType("System.Reflection.RuntimeMethodInfo"), "GetMethodFromHandleInternalType_native", 0, typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.Boolean));
					r_MGetMethodFromHandleInternalType_native_IntPtr_IntPtr_Boolean.SetBelong(null);
				}
				return r_MGetMethodFromHandleInternalType_native_IntPtr_IntPtr_Boolean;
			}
		}

		/// <summary>
		/// System.String get_name(System.Reflection.MethodBase)
		/// </summary>
		protected static RMethod r_Mget_name_MethodBase;
		public static RMethod RMget_name_MethodBase
		{
			get
			{
				if(r_Mget_name_MethodBase == null)
				{
					r_Mget_name_MethodBase = new( ReflectionUtils.GetType("System.Reflection.RuntimeMethodInfo"), "get_name", 0, typeof(System.Reflection.MethodBase));
					r_Mget_name_MethodBase.SetBelong(null);
				}
				return r_Mget_name_MethodBase;
			}
		}

		/// <summary>
		/// System.Reflection.RuntimeMethodInfo get_base_method(System.Reflection.RuntimeMethodInfo, Boolean)
		/// </summary>
		protected static RMethod r_Mget_base_method_RuntimeMethodInfo_Boolean;
		public static RMethod RMget_base_method_RuntimeMethodInfo_Boolean
		{
			get
			{
				if(r_Mget_base_method_RuntimeMethodInfo_Boolean == null)
				{
					r_Mget_base_method_RuntimeMethodInfo_Boolean = new( ReflectionUtils.GetType("System.Reflection.RuntimeMethodInfo"), "get_base_method", 0,  ReflectionUtils.GetType("System.Reflection.RuntimeMethodInfo"), typeof(System.Boolean));
					r_Mget_base_method_RuntimeMethodInfo_Boolean.SetBelong(null);
				}
				return r_Mget_base_method_RuntimeMethodInfo_Boolean;
			}
		}

		/// <summary>
		/// Int32 get_metadata_token(System.Reflection.RuntimeMethodInfo)
		/// </summary>
		protected static RMethod r_Mget_metadata_token_RuntimeMethodInfo;
		public static RMethod RMget_metadata_token_RuntimeMethodInfo
		{
			get
			{
				if(r_Mget_metadata_token_RuntimeMethodInfo == null)
				{
					r_Mget_metadata_token_RuntimeMethodInfo = new( ReflectionUtils.GetType("System.Reflection.RuntimeMethodInfo"), "get_metadata_token", 0,  ReflectionUtils.GetType("System.Reflection.RuntimeMethodInfo"));
					r_Mget_metadata_token_RuntimeMethodInfo.SetBelong(null);
				}
				return r_Mget_metadata_token_RuntimeMethodInfo;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetBaseDefinition()
		/// </summary>
		protected RMethod r_MGetBaseDefinition;
		public virtual RMethod RMGetBaseDefinition
		{
			get
			{
				if(r_MGetBaseDefinition == null)
				{
					r_MGetBaseDefinition = new(this, "GetBaseDefinition", 0);
					r_MGetBaseDefinition.SetBelong(this.GetValue());
				}
				return r_MGetBaseDefinition;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetBaseMethod()
		/// </summary>
		protected RMethod r_MGetBaseMethod;
		public virtual RMethod RMGetBaseMethod
		{
			get
			{
				if(r_MGetBaseMethod == null)
				{
					r_MGetBaseMethod = new(this, "GetBaseMethod", 0);
					r_MGetBaseMethod.SetBelong(this.GetValue());
				}
				return r_MGetBaseMethod;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes GetMethodImplementationFlags()
		/// </summary>
		protected RMethod r_MGetMethodImplementationFlags;
		public virtual RMethod RMGetMethodImplementationFlags
		{
			get
			{
				if(r_MGetMethodImplementationFlags == null)
				{
					r_MGetMethodImplementationFlags = new(this, "GetMethodImplementationFlags", 0);
					r_MGetMethodImplementationFlags.SetBelong(this.GetValue());
				}
				return r_MGetMethodImplementationFlags;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterInfo[] GetParameters()
		/// </summary>
		protected RMethod r_MGetParameters;
		public virtual RMethod RMGetParameters
		{
			get
			{
				if(r_MGetParameters == null)
				{
					r_MGetParameters = new(this, "GetParameters", 0);
					r_MGetParameters.SetBelong(this.GetValue());
				}
				return r_MGetParameters;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterInfo[] GetParametersInternal()
		/// </summary>
		protected RMethod r_MGetParametersInternal;
		public virtual RMethod RMGetParametersInternal
		{
			get
			{
				if(r_MGetParametersInternal == null)
				{
					r_MGetParametersInternal = new(this, "GetParametersInternal", 0);
					r_MGetParametersInternal.SetBelong(this.GetValue());
				}
				return r_MGetParametersInternal;
			}
		}

		/// <summary>
		/// Int32 GetParametersCount()
		/// </summary>
		protected RMethod r_MGetParametersCount;
		public virtual RMethod RMGetParametersCount
		{
			get
			{
				if(r_MGetParametersCount == null)
				{
					r_MGetParametersCount = new(this, "GetParametersCount", 0);
					r_MGetParametersCount.SetBelong(this.GetValue());
				}
				return r_MGetParametersCount;
			}
		}

		/// <summary>
		/// System.Object InternalInvoke(System.Object, System.Object[], System.Exception ByRef)
		/// </summary>
		protected RMethod r_MInternalInvoke_Object_ObjectArray_Out_Exception;
		public virtual RMethod RMInternalInvoke_Object_ObjectArray_Out_Exception
		{
			get
			{
				if(r_MInternalInvoke_Object_ObjectArray_Out_Exception == null)
				{
					r_MInternalInvoke_Object_ObjectArray_Out_Exception = new(this, "InternalInvoke", 0, typeof(System.Object), typeof(System.Object).MakeArrayType(), typeof(System.Exception).MakeByRefType());
					r_MInternalInvoke_Object_ObjectArray_Out_Exception.SetBelong(this.GetValue());
				}
				return r_MInternalInvoke_Object_ObjectArray_Out_Exception;
			}
		}

		/// <summary>
		/// System.Object Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
		public virtual RMethod RMInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo
		{
			get
			{
				if(r_MInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo == null)
				{
					r_MInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo = new(this, "Invoke", 0, typeof(System.Object), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
					r_MInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo.SetBelong(this.GetValue());
				}
				return r_MInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
			}
		}

		/// <summary>
		/// Void ConvertValues(System.Reflection.Binder, System.Object[], System.Reflection.ParameterInfo[], System.Globalization.CultureInfo, System.Reflection.BindingFlags)
		/// </summary>
		protected static RMethod r_MConvertValues_Binder_ObjectArray_ParameterInfoArray_CultureInfo_BindingFlags;
		public static RMethod RMConvertValues_Binder_ObjectArray_ParameterInfoArray_CultureInfo_BindingFlags
		{
			get
			{
				if(r_MConvertValues_Binder_ObjectArray_ParameterInfoArray_CultureInfo_BindingFlags == null)
				{
					r_MConvertValues_Binder_ObjectArray_ParameterInfoArray_CultureInfo_BindingFlags = new( ReflectionUtils.GetType("System.Reflection.RuntimeMethodInfo"), "ConvertValues", 0, typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Reflection.ParameterInfo).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.Reflection.BindingFlags));
					r_MConvertValues_Binder_ObjectArray_ParameterInfoArray_CultureInfo_BindingFlags.SetBelong(null);
				}
				return r_MConvertValues_Binder_ObjectArray_ParameterInfoArray_CultureInfo_BindingFlags;
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
					r_MIsDefined_Type_Boolean.SetBelong(this.GetValue());
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
					r_MGetCustomAttributes_Boolean.SetBelong(this.GetValue());
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
					r_MGetCustomAttributes_Type_Boolean.SetBelong(this.GetValue());
				}
				return r_MGetCustomAttributes_Type_Boolean;
			}
		}

		/// <summary>
		/// Void GetPInvoke(System.Reflection.PInvokeAttributes ByRef, System.String ByRef, System.String ByRef)
		/// </summary>
		protected RMethod r_MGetPInvoke_Out_PInvokeAttributes_Out_String_Out_String;
		public virtual RMethod RMGetPInvoke_Out_PInvokeAttributes_Out_String_Out_String
		{
			get
			{
				if(r_MGetPInvoke_Out_PInvokeAttributes_Out_String_Out_String == null)
				{
					r_MGetPInvoke_Out_PInvokeAttributes_Out_String_Out_String = new(this, "GetPInvoke", 0,  ReflectionUtils.GetType("System.Reflection.PInvokeAttributes").MakeByRefType(), typeof(System.String).MakeByRefType(), typeof(System.String).MakeByRefType());
					r_MGetPInvoke_Out_PInvokeAttributes_Out_String_Out_String.SetBelong(this.GetValue());
				}
				return r_MGetPInvoke_Out_PInvokeAttributes_Out_String_Out_String;
			}
		}

		/// <summary>
		/// System.Object[] GetPseudoCustomAttributes()
		/// </summary>
		protected RMethod r_MGetPseudoCustomAttributes;
		public virtual RMethod RMGetPseudoCustomAttributes
		{
			get
			{
				if(r_MGetPseudoCustomAttributes == null)
				{
					r_MGetPseudoCustomAttributes = new(this, "GetPseudoCustomAttributes", 0);
					r_MGetPseudoCustomAttributes.SetBelong(this.GetValue());
				}
				return r_MGetPseudoCustomAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.CustomAttributeData[] GetPseudoCustomAttributesData()
		/// </summary>
		protected RMethod r_MGetPseudoCustomAttributesData;
		public virtual RMethod RMGetPseudoCustomAttributesData
		{
			get
			{
				if(r_MGetPseudoCustomAttributesData == null)
				{
					r_MGetPseudoCustomAttributesData = new(this, "GetPseudoCustomAttributesData", 0);
					r_MGetPseudoCustomAttributesData.SetBelong(this.GetValue());
				}
				return r_MGetPseudoCustomAttributesData;
			}
		}

		/// <summary>
		/// System.Reflection.CustomAttributeData GetDllImportAttributeData()
		/// </summary>
		protected RMethod r_MGetDllImportAttributeData;
		public virtual RMethod RMGetDllImportAttributeData
		{
			get
			{
				if(r_MGetDllImportAttributeData == null)
				{
					r_MGetDllImportAttributeData = new(this, "GetDllImportAttributeData", 0);
					r_MGetDllImportAttributeData.SetBelong(this.GetValue());
				}
				return r_MGetDllImportAttributeData;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo MakeGenericMethod(System.Type[])
		/// </summary>
		protected RMethod r_MMakeGenericMethod_TypeArray;
		public virtual RMethod RMMakeGenericMethod_TypeArray
		{
			get
			{
				if(r_MMakeGenericMethod_TypeArray == null)
				{
					r_MMakeGenericMethod_TypeArray = new(this, "MakeGenericMethod", 0, typeof(System.Type).MakeArrayType());
					r_MMakeGenericMethod_TypeArray.SetBelong(this.GetValue());
				}
				return r_MMakeGenericMethod_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo MakeGenericMethod_impl(System.Type[])
		/// </summary>
		protected RMethod r_MMakeGenericMethod_impl_TypeArray;
		public virtual RMethod RMMakeGenericMethod_impl_TypeArray
		{
			get
			{
				if(r_MMakeGenericMethod_impl_TypeArray == null)
				{
					r_MMakeGenericMethod_impl_TypeArray = new(this, "MakeGenericMethod_impl", 0, typeof(System.Type).MakeArrayType());
					r_MMakeGenericMethod_impl_TypeArray.SetBelong(this.GetValue());
				}
				return r_MMakeGenericMethod_impl_TypeArray;
			}
		}

		/// <summary>
		/// System.Type[] GetGenericArguments()
		/// </summary>
		protected RMethod r_MGetGenericArguments;
		public virtual RMethod RMGetGenericArguments
		{
			get
			{
				if(r_MGetGenericArguments == null)
				{
					r_MGetGenericArguments = new(this, "GetGenericArguments", 0);
					r_MGetGenericArguments.SetBelong(this.GetValue());
				}
				return r_MGetGenericArguments;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetGenericMethodDefinition_impl()
		/// </summary>
		protected RMethod r_MGetGenericMethodDefinition_impl;
		public virtual RMethod RMGetGenericMethodDefinition_impl
		{
			get
			{
				if(r_MGetGenericMethodDefinition_impl == null)
				{
					r_MGetGenericMethodDefinition_impl = new(this, "GetGenericMethodDefinition_impl", 0);
					r_MGetGenericMethodDefinition_impl.SetBelong(this.GetValue());
				}
				return r_MGetGenericMethodDefinition_impl;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetGenericMethodDefinition()
		/// </summary>
		protected RMethod r_MGetGenericMethodDefinition;
		public virtual RMethod RMGetGenericMethodDefinition
		{
			get
			{
				if(r_MGetGenericMethodDefinition == null)
				{
					r_MGetGenericMethodDefinition = new(this, "GetGenericMethodDefinition", 0);
					r_MGetGenericMethodDefinition.SetBelong(this.GetValue());
				}
				return r_MGetGenericMethodDefinition;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBody GetMethodBody()
		/// </summary>
		protected RMethod r_MGetMethodBody;
		public virtual RMethod RMGetMethodBody
		{
			get
			{
				if(r_MGetMethodBody == null)
				{
					r_MGetMethodBody = new(this, "GetMethodBody", 0);
					r_MGetMethodBody.SetBelong(this.GetValue());
				}
				return r_MGetMethodBody;
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
					r_MGetCustomAttributesData.SetBelong(this.GetValue());
				}
				return r_MGetCustomAttributesData;
			}
		}

		/// <summary>
		/// Int32 get_core_clr_security_level()
		/// </summary>
		protected RMethod r_Mget_core_clr_security_level;
		public virtual RMethod RMget_core_clr_security_level
		{
			get
			{
				if(r_Mget_core_clr_security_level == null)
				{
					r_Mget_core_clr_security_level = new(this, "get_core_clr_security_level", 0);
					r_Mget_core_clr_security_level.SetBelong(this.GetValue());
				}
				return r_Mget_core_clr_security_level;
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
					r_MHasSameMetadataDefinitionAs_MemberInfo.SetBelong(this.GetValue());
				}
				return r_MHasSameMetadataDefinitionAs_MemberInfo;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
				}
				return r_MGetHashCode;
			}
		}

		/// <summary>
		/// System.Object Invoke(System.Object, System.Object[])
		/// </summary>
		protected RMethod r_MInvoke_Object_ObjectArray;
		public virtual RMethod RMInvoke_Object_ObjectArray
		{
			get
			{
				if(r_MInvoke_Object_ObjectArray == null)
				{
					r_MInvoke_Object_ObjectArray = new(this, "Invoke", 0, typeof(System.Object), typeof(System.Object).MakeArrayType());
					r_MInvoke_Object_ObjectArray.SetBelong(this.GetValue());
				}
				return r_MInvoke_Object_ObjectArray;
			}
		}

		/// <summary>
		/// System.Type GetParameterType(Int32)
		/// </summary>
		protected RMethod r_MGetParameterType_Int32;
		public virtual RMethod RMGetParameterType_Int32
		{
			get
			{
				if(r_MGetParameterType_Int32 == null)
				{
					r_MGetParameterType_Int32 = new(this, "GetParameterType", 0, typeof(System.Int32));
					r_MGetParameterType_Int32.SetBelong(this.GetValue());
				}
				return r_MGetParameterType_Int32;
			}
		}

		/// <summary>
		/// Int32 get_next_table_index(System.Object, Int32, Int32)
		/// </summary>
		protected RMethod r_Mget_next_table_index_Object_Int32_Int32;
		public virtual RMethod RMget_next_table_index_Object_Int32_Int32
		{
			get
			{
				if(r_Mget_next_table_index_Object_Int32_Int32 == null)
				{
					r_Mget_next_table_index_Object_Int32_Int32 = new(this, "get_next_table_index", 0, typeof(System.Object), typeof(System.Int32), typeof(System.Int32));
					r_Mget_next_table_index_Object_Int32_Int32.SetBelong(this.GetValue());
				}
				return r_Mget_next_table_index_Object_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Type[] GetParameterTypes()
		/// </summary>
		protected RMethod r_MGetParameterTypes;
		public virtual RMethod RMGetParameterTypes
		{
			get
			{
				if(r_MGetParameterTypes == null)
				{
					r_MGetParameterTypes = new(this, "GetParameterTypes", 0);
					r_MGetParameterTypes.SetBelong(this.GetValue());
				}
				return r_MGetParameterTypes;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterInfo[] GetParametersNoCopy()
		/// </summary>
		protected RMethod r_MGetParametersNoCopy;
		public virtual RMethod RMGetParametersNoCopy
		{
			get
			{
				if(r_MGetParametersNoCopy == null)
				{
					r_MGetParametersNoCopy = new(this, "GetParametersNoCopy", 0);
					r_MGetParametersNoCopy.SetBelong(this.GetValue());
				}
				return r_MGetParametersNoCopy;
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
					r_MCacheEquals_Object.SetBelong(this.GetValue());
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
					r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
				}
				return r_MMemberwiseClone;
			}
		}


        public RRuntimeMethodInfo() : base("System.Reflection.RuntimeMethodInfo")
        {
        }

        public RRuntimeMethodInfo(System.Object instance) : base("System.Reflection.RuntimeMethodInfo")
		{
            SetInstance(instance);
		}

        public RRuntimeMethodInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRuntimeMethodInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String FormatNameAndSig(System.Boolean @serialization)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serialization};
            var ___result = RMFormatNameAndSig_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Delegate CreateDelegate(System.Type @delegateType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delegateType};
            var ___result = RMCreateDelegate_Type.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public virtual System.Delegate CreateDelegate(System.Type @delegateType, System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delegateType, @target};
            var ___result = RMCreateDelegate_Type_Object.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


        public virtual System.String SerializationToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSerializationToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Reflection.MethodBase GetMethodFromHandleNoGenericCheck(System.RuntimeMethodHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetMethodFromHandleNoGenericCheck_RuntimeMethodHandle.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public static System.Reflection.MethodBase GetMethodFromHandleNoGenericCheck(System.RuntimeMethodHandle @handle, System.RuntimeTypeHandle @reflectedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle, @reflectedType};
            var ___result = RMGetMethodFromHandleNoGenericCheck_RuntimeMethodHandle_RuntimeTypeHandle.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public static System.Reflection.MethodBody GetMethodBodyInternal(System.IntPtr @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetMethodBodyInternal_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBody)___result;
        }


        public static System.Reflection.MethodBody GetMethodBody(System.IntPtr @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetMethodBody_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBody)___result;
        }


        public static System.Reflection.MethodBase GetMethodFromHandleInternalType(System.IntPtr @method_handle, System.IntPtr @type_handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method_handle, @type_handle};
            var ___result = RMGetMethodFromHandleInternalType_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public static System.Reflection.MethodBase GetMethodFromHandleInternalType_native(System.IntPtr @method_handle, System.IntPtr @type_handle, System.Boolean @genericCheck)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method_handle, @type_handle, @genericCheck};
            var ___result = RMGetMethodFromHandleInternalType_native_IntPtr_IntPtr_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public static System.String get_name(System.Reflection.MethodBase @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method};
            var ___result = RMget_name_MethodBase.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeMethodInfo get_base_method(Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeMethodInfo @method, System.Boolean @definition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method.Value, @definition};
            var ___result = RMget_base_method_RuntimeMethodInfo_Boolean.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeMethodInfo(___result);
        }


        public static System.Int32 get_metadata_token(Hvak.Editor.Refleaction.RSystem.RReflection.RRuntimeMethodInfo @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method.Value};
            var ___result = RMget_metadata_token_RuntimeMethodInfo.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Reflection.MethodInfo GetBaseDefinition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetBaseDefinition.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetBaseMethod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetBaseMethod.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodImplAttributes GetMethodImplementationFlags()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMethodImplementationFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodImplAttributes)___result;
        }


        public virtual System.Reflection.ParameterInfo[] GetParameters()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetParameters.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ParameterInfo[])___result;
        }


        public virtual System.Reflection.ParameterInfo[] GetParametersInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetParametersInternal.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ParameterInfo[])___result;
        }


        public virtual System.Int32 GetParametersCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetParametersCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Object InternalInvoke(System.Object @obj, System.Object[] @parameters, out System.Exception @exc)
        {
			@exc = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @parameters, @exc};
            var ___result = RMInternalInvoke_Object_ObjectArray_Out_Exception.Invoke(___genericsType, ___parameters);
			@exc = (System.Exception)___parameters[2];

            return (System.Object)___result;
        }


        public virtual System.Object Invoke(System.Object @obj, System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Object[] @parameters, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @invokeAttr, @binder, @parameters, @culture};
            var ___result = RMInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static void ConvertValues(System.Reflection.Binder @binder, System.Object[] @args, System.Reflection.ParameterInfo[] @pinfo, System.Globalization.CultureInfo @culture, System.Reflection.BindingFlags @invokeAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@binder, @args, @pinfo, @culture, @invokeAttr};
            var ___result = RMConvertValues_Binder_ObjectArray_ParameterInfoArray_CultureInfo_BindingFlags.Invoke(___genericsType, ___parameters);

            
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


        public virtual void GetPInvoke(out Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes @flags, out System.String @entryPoint, out System.String @dllName)
        {
			@flags = default;
			@entryPoint = default;
			@dllName = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flags.Value, @entryPoint, @dllName};
            var ___result = RMGetPInvoke_Out_PInvokeAttributes_Out_String_Out_String.Invoke(___genericsType, ___parameters);
			@flags = new Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes(___parameters[0]);
			@entryPoint = (System.String)___parameters[1];
			@dllName = (System.String)___parameters[2];

            
        }


        public virtual System.Object[] GetPseudoCustomAttributes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPseudoCustomAttributes.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual System.Reflection.CustomAttributeData[] GetPseudoCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPseudoCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Reflection.CustomAttributeData[])___result;
        }


        public virtual System.Reflection.CustomAttributeData GetDllImportAttributeData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDllImportAttributeData.Invoke(___genericsType, ___parameters);

            return (System.Reflection.CustomAttributeData)___result;
        }


        public virtual System.Reflection.MethodInfo MakeGenericMethod(System.Type[] @methodInstantiation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodInstantiation};
            var ___result = RMMakeGenericMethod_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo MakeGenericMethod_impl(System.Type[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@types};
            var ___result = RMMakeGenericMethod_impl_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Type[] GetGenericArguments()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGenericArguments.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.MethodInfo GetGenericMethodDefinition_impl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGenericMethodDefinition_impl.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetGenericMethodDefinition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGenericMethodDefinition.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodBody GetMethodBody()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMethodBody.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBody)___result;
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual System.Int32 get_core_clr_security_level()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMget_core_clr_security_level.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMHasSameMetadataDefinitionAs_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.Object Invoke(System.Object @obj, System.Object[] @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @parameters};
            var ___result = RMInvoke_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Type GetParameterType(System.Int32 @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RMGetParameterType_Int32.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Int32 get_next_table_index(System.Object @obj, System.Int32 @table, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @table, @count};
            var ___result = RMget_next_table_index_Object_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Type[] GetParameterTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetParameterTypes.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.ParameterInfo[] GetParametersNoCopy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetParametersNoCopy.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ParameterInfo[])___result;
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
