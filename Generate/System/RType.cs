using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.Type
	/// </summary>
    public partial class RType : RMember //
    {

		/// <summary>
		/// System.Reflection.Binder s_defaultBinder
		/// </summary>
		protected static RSystem.RReflection.RBinder r_s_defaultBinder;
		public static RSystem.RReflection.RBinder Rs_defaultBinder
		{
			get
			{
				if(r_s_defaultBinder == null)
				{
					r_s_defaultBinder = new(typeof(System.Type), "s_defaultBinder");
					r_s_defaultBinder.SetBelong(null);
				}
				return r_s_defaultBinder;
			}
		}

		/// <summary>
		/// System.Char Delimiter
		/// </summary>
		protected static RField r_Delimiter;
		public static RField RDelimiter
		{
			get
			{
				if(r_Delimiter == null)
				{
					r_Delimiter = new(typeof(System.Type), "Delimiter");
					r_Delimiter.SetBelong(null);
				}
				return r_Delimiter;
			}
		}

		/// <summary>
		/// System.Type[] EmptyTypes
		/// </summary>
		protected static RFieldArray<RSystem.RType> r_EmptyTypes;
		public static RFieldArray<RSystem.RType> REmptyTypes
		{
			get
			{
				if(r_EmptyTypes == null)
				{
					r_EmptyTypes = new(typeof(System.Type), "EmptyTypes");
					r_EmptyTypes.SetBelong(null);
				}
				return r_EmptyTypes;
			}
		}

		/// <summary>
		/// System.Object Missing
		/// </summary>
		protected static RSystem.RObject r_Missing;
		public static RSystem.RObject RMissing
		{
			get
			{
				if(r_Missing == null)
				{
					r_Missing = new(typeof(System.Type), "Missing");
					r_Missing.SetBelong(null);
				}
				return r_Missing;
			}
		}

		/// <summary>
		/// System.Reflection.MemberFilter FilterAttribute
		/// </summary>
		protected static RSystem.RReflection.RMemberFilter r_FilterAttribute;
		public static RSystem.RReflection.RMemberFilter RFilterAttribute
		{
			get
			{
				if(r_FilterAttribute == null)
				{
					r_FilterAttribute = new(typeof(System.Type), "FilterAttribute");
					r_FilterAttribute.SetBelong(null);
				}
				return r_FilterAttribute;
			}
		}

		/// <summary>
		/// System.Reflection.MemberFilter FilterName
		/// </summary>
		protected static RSystem.RReflection.RMemberFilter r_FilterName;
		public static RSystem.RReflection.RMemberFilter RFilterName
		{
			get
			{
				if(r_FilterName == null)
				{
					r_FilterName = new(typeof(System.Type), "FilterName");
					r_FilterName.SetBelong(null);
				}
				return r_FilterName;
			}
		}

		/// <summary>
		/// System.Reflection.MemberFilter FilterNameIgnoreCase
		/// </summary>
		protected static RSystem.RReflection.RMemberFilter r_FilterNameIgnoreCase;
		public static RSystem.RReflection.RMemberFilter RFilterNameIgnoreCase
		{
			get
			{
				if(r_FilterNameIgnoreCase == null)
				{
					r_FilterNameIgnoreCase = new(typeof(System.Type), "FilterNameIgnoreCase");
					r_FilterNameIgnoreCase.SetBelong(null);
				}
				return r_FilterNameIgnoreCase;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags DefaultLookup
		/// </summary>
		protected static RField r_DefaultLookup;
		public static RField RDefaultLookup
		{
			get
			{
				if(r_DefaultLookup == null)
				{
					r_DefaultLookup = new(typeof(System.Type), "DefaultLookup");
					r_DefaultLookup.SetBelong(null);
				}
				return r_DefaultLookup;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle _impl
		/// </summary>
		protected RSystem.RRuntimeTypeHandle r__impl;
		public virtual RSystem.RRuntimeTypeHandle R_impl
		{
			get
			{
				if(r__impl == null)
				{
					r__impl = new(this, "_impl");
					r__impl.SetBelong(this.instance);
				}
				return r__impl;
			}
		}

		/// <summary>
		/// System.String DefaultTypeNameWhenMissingMetadata
		/// </summary>
		protected static RField r_DefaultTypeNameWhenMissingMetadata;
		public static RField RDefaultTypeNameWhenMissingMetadata
		{
			get
			{
				if(r_DefaultTypeNameWhenMissingMetadata == null)
				{
					r_DefaultTypeNameWhenMissingMetadata = new(typeof(System.Type), "DefaultTypeNameWhenMissingMetadata");
					r_DefaultTypeNameWhenMissingMetadata.SetBelong(null);
				}
				return r_DefaultTypeNameWhenMissingMetadata;
			}
		}

		/// <summary>
		/// Boolean IsSerializable
		/// </summary>
		protected RProperty r_IsSerializable;
		public virtual RProperty RIsSerializable
		{
			get
			{
				if(r_IsSerializable == null)
				{
					r_IsSerializable = new(this, "IsSerializable", -1);
					r_IsSerializable.SetBelong(this.instance);
				}
				return r_IsSerializable;
			}
		}

		/// <summary>
		/// Boolean ContainsGenericParameters
		/// </summary>
		protected RProperty r_ContainsGenericParameters;
		public virtual RProperty RContainsGenericParameters
		{
			get
			{
				if(r_ContainsGenericParameters == null)
				{
					r_ContainsGenericParameters = new(this, "ContainsGenericParameters", -1);
					r_ContainsGenericParameters.SetBelong(this.instance);
				}
				return r_ContainsGenericParameters;
			}
		}

		/// <summary>
		/// Boolean IsVisible
		/// </summary>
		protected RProperty r_IsVisible;
		public virtual RProperty RIsVisible
		{
			get
			{
				if(r_IsVisible == null)
				{
					r_IsVisible = new(this, "IsVisible", -1);
					r_IsVisible.SetBelong(this.instance);
				}
				return r_IsVisible;
			}
		}

		/// <summary>
		/// System.Reflection.MemberTypes MemberType
		/// </summary>
		protected RProperty r_MemberType;
		public virtual RProperty RMemberType
		{
			get
			{
				if(r_MemberType == null)
				{
					r_MemberType = new(this, "MemberType", -1);
					r_MemberType.SetBelong(this.instance);
				}
				return r_MemberType;
			}
		}

		/// <summary>
		/// System.String Namespace
		/// </summary>
		protected RProperty r_Namespace;
		public virtual RProperty RNamespace
		{
			get
			{
				if(r_Namespace == null)
				{
					r_Namespace = new(this, "Namespace", -1);
					r_Namespace.SetBelong(this.instance);
				}
				return r_Namespace;
			}
		}

		/// <summary>
		/// System.String AssemblyQualifiedName
		/// </summary>
		protected RProperty r_AssemblyQualifiedName;
		public virtual RProperty RAssemblyQualifiedName
		{
			get
			{
				if(r_AssemblyQualifiedName == null)
				{
					r_AssemblyQualifiedName = new(this, "AssemblyQualifiedName", -1);
					r_AssemblyQualifiedName.SetBelong(this.instance);
				}
				return r_AssemblyQualifiedName;
			}
		}

		/// <summary>
		/// System.String FullName
		/// </summary>
		protected RProperty r_FullName;
		public virtual RProperty RFullName
		{
			get
			{
				if(r_FullName == null)
				{
					r_FullName = new(this, "FullName", -1);
					r_FullName.SetBelong(this.instance);
				}
				return r_FullName;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Assembly
		/// </summary>
		protected RSystem.RReflection.RAssembly r_Assembly;
		public virtual RSystem.RReflection.RAssembly RAssembly
		{
			get
			{
				if(r_Assembly == null)
				{
					r_Assembly = new(this, "Assembly", -1);
					r_Assembly.SetBelong(this.instance);
				}
				return r_Assembly;
			}
		}

		/// <summary>
		/// System.Reflection.Module Module
		/// </summary>
		protected RSystem.RReflection.RModule r_Module;
		public virtual RSystem.RReflection.RModule RModule
		{
			get
			{
				if(r_Module == null)
				{
					r_Module = new(this, "Module", -1);
					r_Module.SetBelong(this.instance);
				}
				return r_Module;
			}
		}

		/// <summary>
		/// Boolean IsNested
		/// </summary>
		protected RProperty r_IsNested;
		public virtual RProperty RIsNested
		{
			get
			{
				if(r_IsNested == null)
				{
					r_IsNested = new(this, "IsNested", -1);
					r_IsNested.SetBelong(this.instance);
				}
				return r_IsNested;
			}
		}

		/// <summary>
		/// System.Type DeclaringType
		/// </summary>
		protected RSystem.RType r_DeclaringType;
		public virtual RSystem.RType RDeclaringType
		{
			get
			{
				if(r_DeclaringType == null)
				{
					r_DeclaringType = new(this, "DeclaringType", -1);
					r_DeclaringType.SetBelong(this.instance);
				}
				return r_DeclaringType;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase DeclaringMethod
		/// </summary>
		protected RSystem.RReflection.RMethodBase r_DeclaringMethod;
		public virtual RSystem.RReflection.RMethodBase RDeclaringMethod
		{
			get
			{
				if(r_DeclaringMethod == null)
				{
					r_DeclaringMethod = new(this, "DeclaringMethod", -1);
					r_DeclaringMethod.SetBelong(this.instance);
				}
				return r_DeclaringMethod;
			}
		}

		/// <summary>
		/// System.Type ReflectedType
		/// </summary>
		protected RSystem.RType r_ReflectedType;
		public virtual RSystem.RType RReflectedType
		{
			get
			{
				if(r_ReflectedType == null)
				{
					r_ReflectedType = new(this, "ReflectedType", -1);
					r_ReflectedType.SetBelong(this.instance);
				}
				return r_ReflectedType;
			}
		}

		/// <summary>
		/// System.Type UnderlyingSystemType
		/// </summary>
		protected RSystem.RType r_UnderlyingSystemType;
		public virtual RSystem.RType RUnderlyingSystemType
		{
			get
			{
				if(r_UnderlyingSystemType == null)
				{
					r_UnderlyingSystemType = new(this, "UnderlyingSystemType", -1);
					r_UnderlyingSystemType.SetBelong(this.instance);
				}
				return r_UnderlyingSystemType;
			}
		}

		/// <summary>
		/// Boolean IsTypeDefinition
		/// </summary>
		protected RProperty r_IsTypeDefinition;
		public virtual RProperty RIsTypeDefinition
		{
			get
			{
				if(r_IsTypeDefinition == null)
				{
					r_IsTypeDefinition = new(this, "IsTypeDefinition", -1);
					r_IsTypeDefinition.SetBelong(this.instance);
				}
				return r_IsTypeDefinition;
			}
		}

		/// <summary>
		/// Boolean IsArray
		/// </summary>
		protected RProperty r_IsArray;
		public virtual RProperty RIsArray
		{
			get
			{
				if(r_IsArray == null)
				{
					r_IsArray = new(this, "IsArray", -1);
					r_IsArray.SetBelong(this.instance);
				}
				return r_IsArray;
			}
		}

		/// <summary>
		/// Boolean IsByRef
		/// </summary>
		protected RProperty r_IsByRef;
		public virtual RProperty RIsByRef
		{
			get
			{
				if(r_IsByRef == null)
				{
					r_IsByRef = new(this, "IsByRef", -1);
					r_IsByRef.SetBelong(this.instance);
				}
				return r_IsByRef;
			}
		}

		/// <summary>
		/// Boolean IsPointer
		/// </summary>
		protected RProperty r_IsPointer;
		public virtual RProperty RIsPointer
		{
			get
			{
				if(r_IsPointer == null)
				{
					r_IsPointer = new(this, "IsPointer", -1);
					r_IsPointer.SetBelong(this.instance);
				}
				return r_IsPointer;
			}
		}

		/// <summary>
		/// Boolean IsConstructedGenericType
		/// </summary>
		protected RProperty r_IsConstructedGenericType;
		public virtual RProperty RIsConstructedGenericType
		{
			get
			{
				if(r_IsConstructedGenericType == null)
				{
					r_IsConstructedGenericType = new(this, "IsConstructedGenericType", -1);
					r_IsConstructedGenericType.SetBelong(this.instance);
				}
				return r_IsConstructedGenericType;
			}
		}

		/// <summary>
		/// Boolean IsGenericParameter
		/// </summary>
		protected RProperty r_IsGenericParameter;
		public virtual RProperty RIsGenericParameter
		{
			get
			{
				if(r_IsGenericParameter == null)
				{
					r_IsGenericParameter = new(this, "IsGenericParameter", -1);
					r_IsGenericParameter.SetBelong(this.instance);
				}
				return r_IsGenericParameter;
			}
		}

		/// <summary>
		/// Boolean IsGenericTypeParameter
		/// </summary>
		protected RProperty r_IsGenericTypeParameter;
		public virtual RProperty RIsGenericTypeParameter
		{
			get
			{
				if(r_IsGenericTypeParameter == null)
				{
					r_IsGenericTypeParameter = new(this, "IsGenericTypeParameter", -1);
					r_IsGenericTypeParameter.SetBelong(this.instance);
				}
				return r_IsGenericTypeParameter;
			}
		}

		/// <summary>
		/// Boolean IsGenericMethodParameter
		/// </summary>
		protected RProperty r_IsGenericMethodParameter;
		public virtual RProperty RIsGenericMethodParameter
		{
			get
			{
				if(r_IsGenericMethodParameter == null)
				{
					r_IsGenericMethodParameter = new(this, "IsGenericMethodParameter", -1);
					r_IsGenericMethodParameter.SetBelong(this.instance);
				}
				return r_IsGenericMethodParameter;
			}
		}

		/// <summary>
		/// Boolean IsGenericType
		/// </summary>
		protected RProperty r_IsGenericType;
		public virtual RProperty RIsGenericType
		{
			get
			{
				if(r_IsGenericType == null)
				{
					r_IsGenericType = new(this, "IsGenericType", -1);
					r_IsGenericType.SetBelong(this.instance);
				}
				return r_IsGenericType;
			}
		}

		/// <summary>
		/// Boolean IsGenericTypeDefinition
		/// </summary>
		protected RProperty r_IsGenericTypeDefinition;
		public virtual RProperty RIsGenericTypeDefinition
		{
			get
			{
				if(r_IsGenericTypeDefinition == null)
				{
					r_IsGenericTypeDefinition = new(this, "IsGenericTypeDefinition", -1);
					r_IsGenericTypeDefinition.SetBelong(this.instance);
				}
				return r_IsGenericTypeDefinition;
			}
		}

		/// <summary>
		/// Boolean IsSZArray
		/// </summary>
		protected RProperty r_IsSZArray;
		public virtual RProperty RIsSZArray
		{
			get
			{
				if(r_IsSZArray == null)
				{
					r_IsSZArray = new(this, "IsSZArray", -1);
					r_IsSZArray.SetBelong(this.instance);
				}
				return r_IsSZArray;
			}
		}

		/// <summary>
		/// Boolean IsVariableBoundArray
		/// </summary>
		protected RProperty r_IsVariableBoundArray;
		public virtual RProperty RIsVariableBoundArray
		{
			get
			{
				if(r_IsVariableBoundArray == null)
				{
					r_IsVariableBoundArray = new(this, "IsVariableBoundArray", -1);
					r_IsVariableBoundArray.SetBelong(this.instance);
				}
				return r_IsVariableBoundArray;
			}
		}

		/// <summary>
		/// Boolean IsByRefLike
		/// </summary>
		protected RProperty r_IsByRefLike;
		public virtual RProperty RIsByRefLike
		{
			get
			{
				if(r_IsByRefLike == null)
				{
					r_IsByRefLike = new(this, "IsByRefLike", -1);
					r_IsByRefLike.SetBelong(this.instance);
				}
				return r_IsByRefLike;
			}
		}

		/// <summary>
		/// Boolean HasElementType
		/// </summary>
		protected RProperty r_HasElementType;
		public virtual RProperty RHasElementType
		{
			get
			{
				if(r_HasElementType == null)
				{
					r_HasElementType = new(this, "HasElementType", -1);
					r_HasElementType.SetBelong(this.instance);
				}
				return r_HasElementType;
			}
		}

		/// <summary>
		/// System.Type[] GenericTypeArguments
		/// </summary>
		protected RPropertyArray<RSystem.RType> r_GenericTypeArguments;
		public virtual RPropertyArray<RSystem.RType> RGenericTypeArguments
		{
			get
			{
				if(r_GenericTypeArguments == null)
				{
					r_GenericTypeArguments = new(this, "GenericTypeArguments", -1);
					r_GenericTypeArguments.SetBelong(this.instance);
				}
				return r_GenericTypeArguments;
			}
		}

		/// <summary>
		/// Int32 GenericParameterPosition
		/// </summary>
		protected RProperty r_GenericParameterPosition;
		public virtual RProperty RGenericParameterPosition
		{
			get
			{
				if(r_GenericParameterPosition == null)
				{
					r_GenericParameterPosition = new(this, "GenericParameterPosition", -1);
					r_GenericParameterPosition.SetBelong(this.instance);
				}
				return r_GenericParameterPosition;
			}
		}

		/// <summary>
		/// System.Reflection.GenericParameterAttributes GenericParameterAttributes
		/// </summary>
		protected RProperty r_GenericParameterAttributes;
		public virtual RProperty RGenericParameterAttributes
		{
			get
			{
				if(r_GenericParameterAttributes == null)
				{
					r_GenericParameterAttributes = new(this, "GenericParameterAttributes", -1);
					r_GenericParameterAttributes.SetBelong(this.instance);
				}
				return r_GenericParameterAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes Attributes
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
		/// Boolean IsAbstract
		/// </summary>
		protected RProperty r_IsAbstract;
		public virtual RProperty RIsAbstract
		{
			get
			{
				if(r_IsAbstract == null)
				{
					r_IsAbstract = new(this, "IsAbstract", -1);
					r_IsAbstract.SetBelong(this.instance);
				}
				return r_IsAbstract;
			}
		}

		/// <summary>
		/// Boolean IsImport
		/// </summary>
		protected RProperty r_IsImport;
		public virtual RProperty RIsImport
		{
			get
			{
				if(r_IsImport == null)
				{
					r_IsImport = new(this, "IsImport", -1);
					r_IsImport.SetBelong(this.instance);
				}
				return r_IsImport;
			}
		}

		/// <summary>
		/// Boolean IsSealed
		/// </summary>
		protected RProperty r_IsSealed;
		public virtual RProperty RIsSealed
		{
			get
			{
				if(r_IsSealed == null)
				{
					r_IsSealed = new(this, "IsSealed", -1);
					r_IsSealed.SetBelong(this.instance);
				}
				return r_IsSealed;
			}
		}

		/// <summary>
		/// Boolean IsSpecialName
		/// </summary>
		protected RProperty r_IsSpecialName;
		public virtual RProperty RIsSpecialName
		{
			get
			{
				if(r_IsSpecialName == null)
				{
					r_IsSpecialName = new(this, "IsSpecialName", -1);
					r_IsSpecialName.SetBelong(this.instance);
				}
				return r_IsSpecialName;
			}
		}

		/// <summary>
		/// Boolean IsClass
		/// </summary>
		protected RProperty r_IsClass;
		public virtual RProperty RIsClass
		{
			get
			{
				if(r_IsClass == null)
				{
					r_IsClass = new(this, "IsClass", -1);
					r_IsClass.SetBelong(this.instance);
				}
				return r_IsClass;
			}
		}

		/// <summary>
		/// Boolean IsNestedAssembly
		/// </summary>
		protected RProperty r_IsNestedAssembly;
		public virtual RProperty RIsNestedAssembly
		{
			get
			{
				if(r_IsNestedAssembly == null)
				{
					r_IsNestedAssembly = new(this, "IsNestedAssembly", -1);
					r_IsNestedAssembly.SetBelong(this.instance);
				}
				return r_IsNestedAssembly;
			}
		}

		/// <summary>
		/// Boolean IsNestedFamANDAssem
		/// </summary>
		protected RProperty r_IsNestedFamANDAssem;
		public virtual RProperty RIsNestedFamANDAssem
		{
			get
			{
				if(r_IsNestedFamANDAssem == null)
				{
					r_IsNestedFamANDAssem = new(this, "IsNestedFamANDAssem", -1);
					r_IsNestedFamANDAssem.SetBelong(this.instance);
				}
				return r_IsNestedFamANDAssem;
			}
		}

		/// <summary>
		/// Boolean IsNestedFamily
		/// </summary>
		protected RProperty r_IsNestedFamily;
		public virtual RProperty RIsNestedFamily
		{
			get
			{
				if(r_IsNestedFamily == null)
				{
					r_IsNestedFamily = new(this, "IsNestedFamily", -1);
					r_IsNestedFamily.SetBelong(this.instance);
				}
				return r_IsNestedFamily;
			}
		}

		/// <summary>
		/// Boolean IsNestedFamORAssem
		/// </summary>
		protected RProperty r_IsNestedFamORAssem;
		public virtual RProperty RIsNestedFamORAssem
		{
			get
			{
				if(r_IsNestedFamORAssem == null)
				{
					r_IsNestedFamORAssem = new(this, "IsNestedFamORAssem", -1);
					r_IsNestedFamORAssem.SetBelong(this.instance);
				}
				return r_IsNestedFamORAssem;
			}
		}

		/// <summary>
		/// Boolean IsNestedPrivate
		/// </summary>
		protected RProperty r_IsNestedPrivate;
		public virtual RProperty RIsNestedPrivate
		{
			get
			{
				if(r_IsNestedPrivate == null)
				{
					r_IsNestedPrivate = new(this, "IsNestedPrivate", -1);
					r_IsNestedPrivate.SetBelong(this.instance);
				}
				return r_IsNestedPrivate;
			}
		}

		/// <summary>
		/// Boolean IsNestedPublic
		/// </summary>
		protected RProperty r_IsNestedPublic;
		public virtual RProperty RIsNestedPublic
		{
			get
			{
				if(r_IsNestedPublic == null)
				{
					r_IsNestedPublic = new(this, "IsNestedPublic", -1);
					r_IsNestedPublic.SetBelong(this.instance);
				}
				return r_IsNestedPublic;
			}
		}

		/// <summary>
		/// Boolean IsNotPublic
		/// </summary>
		protected RProperty r_IsNotPublic;
		public virtual RProperty RIsNotPublic
		{
			get
			{
				if(r_IsNotPublic == null)
				{
					r_IsNotPublic = new(this, "IsNotPublic", -1);
					r_IsNotPublic.SetBelong(this.instance);
				}
				return r_IsNotPublic;
			}
		}

		/// <summary>
		/// Boolean IsPublic
		/// </summary>
		protected RProperty r_IsPublic;
		public virtual RProperty RIsPublic
		{
			get
			{
				if(r_IsPublic == null)
				{
					r_IsPublic = new(this, "IsPublic", -1);
					r_IsPublic.SetBelong(this.instance);
				}
				return r_IsPublic;
			}
		}

		/// <summary>
		/// Boolean IsAutoLayout
		/// </summary>
		protected RProperty r_IsAutoLayout;
		public virtual RProperty RIsAutoLayout
		{
			get
			{
				if(r_IsAutoLayout == null)
				{
					r_IsAutoLayout = new(this, "IsAutoLayout", -1);
					r_IsAutoLayout.SetBelong(this.instance);
				}
				return r_IsAutoLayout;
			}
		}

		/// <summary>
		/// Boolean IsExplicitLayout
		/// </summary>
		protected RProperty r_IsExplicitLayout;
		public virtual RProperty RIsExplicitLayout
		{
			get
			{
				if(r_IsExplicitLayout == null)
				{
					r_IsExplicitLayout = new(this, "IsExplicitLayout", -1);
					r_IsExplicitLayout.SetBelong(this.instance);
				}
				return r_IsExplicitLayout;
			}
		}

		/// <summary>
		/// Boolean IsLayoutSequential
		/// </summary>
		protected RProperty r_IsLayoutSequential;
		public virtual RProperty RIsLayoutSequential
		{
			get
			{
				if(r_IsLayoutSequential == null)
				{
					r_IsLayoutSequential = new(this, "IsLayoutSequential", -1);
					r_IsLayoutSequential.SetBelong(this.instance);
				}
				return r_IsLayoutSequential;
			}
		}

		/// <summary>
		/// Boolean IsAnsiClass
		/// </summary>
		protected RProperty r_IsAnsiClass;
		public virtual RProperty RIsAnsiClass
		{
			get
			{
				if(r_IsAnsiClass == null)
				{
					r_IsAnsiClass = new(this, "IsAnsiClass", -1);
					r_IsAnsiClass.SetBelong(this.instance);
				}
				return r_IsAnsiClass;
			}
		}

		/// <summary>
		/// Boolean IsAutoClass
		/// </summary>
		protected RProperty r_IsAutoClass;
		public virtual RProperty RIsAutoClass
		{
			get
			{
				if(r_IsAutoClass == null)
				{
					r_IsAutoClass = new(this, "IsAutoClass", -1);
					r_IsAutoClass.SetBelong(this.instance);
				}
				return r_IsAutoClass;
			}
		}

		/// <summary>
		/// Boolean IsUnicodeClass
		/// </summary>
		protected RProperty r_IsUnicodeClass;
		public virtual RProperty RIsUnicodeClass
		{
			get
			{
				if(r_IsUnicodeClass == null)
				{
					r_IsUnicodeClass = new(this, "IsUnicodeClass", -1);
					r_IsUnicodeClass.SetBelong(this.instance);
				}
				return r_IsUnicodeClass;
			}
		}

		/// <summary>
		/// Boolean IsCOMObject
		/// </summary>
		protected RProperty r_IsCOMObject;
		public virtual RProperty RIsCOMObject
		{
			get
			{
				if(r_IsCOMObject == null)
				{
					r_IsCOMObject = new(this, "IsCOMObject", -1);
					r_IsCOMObject.SetBelong(this.instance);
				}
				return r_IsCOMObject;
			}
		}

		/// <summary>
		/// Boolean IsContextful
		/// </summary>
		protected RProperty r_IsContextful;
		public virtual RProperty RIsContextful
		{
			get
			{
				if(r_IsContextful == null)
				{
					r_IsContextful = new(this, "IsContextful", -1);
					r_IsContextful.SetBelong(this.instance);
				}
				return r_IsContextful;
			}
		}

		/// <summary>
		/// Boolean IsCollectible
		/// </summary>
		protected RProperty r_IsCollectible;
		public virtual RProperty RIsCollectible
		{
			get
			{
				if(r_IsCollectible == null)
				{
					r_IsCollectible = new(this, "IsCollectible", -1);
					r_IsCollectible.SetBelong(this.instance);
				}
				return r_IsCollectible;
			}
		}

		/// <summary>
		/// Boolean IsEnum
		/// </summary>
		protected RProperty r_IsEnum;
		public virtual RProperty RIsEnum
		{
			get
			{
				if(r_IsEnum == null)
				{
					r_IsEnum = new(this, "IsEnum", -1);
					r_IsEnum.SetBelong(this.instance);
				}
				return r_IsEnum;
			}
		}

		/// <summary>
		/// Boolean IsMarshalByRef
		/// </summary>
		protected RProperty r_IsMarshalByRef;
		public virtual RProperty RIsMarshalByRef
		{
			get
			{
				if(r_IsMarshalByRef == null)
				{
					r_IsMarshalByRef = new(this, "IsMarshalByRef", -1);
					r_IsMarshalByRef.SetBelong(this.instance);
				}
				return r_IsMarshalByRef;
			}
		}

		/// <summary>
		/// Boolean IsPrimitive
		/// </summary>
		protected RProperty r_IsPrimitive;
		public virtual RProperty RIsPrimitive
		{
			get
			{
				if(r_IsPrimitive == null)
				{
					r_IsPrimitive = new(this, "IsPrimitive", -1);
					r_IsPrimitive.SetBelong(this.instance);
				}
				return r_IsPrimitive;
			}
		}

		/// <summary>
		/// Boolean IsValueType
		/// </summary>
		protected RProperty r_IsValueType;
		public virtual RProperty RIsValueType
		{
			get
			{
				if(r_IsValueType == null)
				{
					r_IsValueType = new(this, "IsValueType", -1);
					r_IsValueType.SetBelong(this.instance);
				}
				return r_IsValueType;
			}
		}

		/// <summary>
		/// Boolean IsSignatureType
		/// </summary>
		protected RProperty r_IsSignatureType;
		public virtual RProperty RIsSignatureType
		{
			get
			{
				if(r_IsSignatureType == null)
				{
					r_IsSignatureType = new(this, "IsSignatureType", -1);
					r_IsSignatureType.SetBelong(this.instance);
				}
				return r_IsSignatureType;
			}
		}

		/// <summary>
		/// Boolean IsSecurityCritical
		/// </summary>
		protected RProperty r_IsSecurityCritical;
		public virtual RProperty RIsSecurityCritical
		{
			get
			{
				if(r_IsSecurityCritical == null)
				{
					r_IsSecurityCritical = new(this, "IsSecurityCritical", -1);
					r_IsSecurityCritical.SetBelong(this.instance);
				}
				return r_IsSecurityCritical;
			}
		}

		/// <summary>
		/// Boolean IsSecuritySafeCritical
		/// </summary>
		protected RProperty r_IsSecuritySafeCritical;
		public virtual RProperty RIsSecuritySafeCritical
		{
			get
			{
				if(r_IsSecuritySafeCritical == null)
				{
					r_IsSecuritySafeCritical = new(this, "IsSecuritySafeCritical", -1);
					r_IsSecuritySafeCritical.SetBelong(this.instance);
				}
				return r_IsSecuritySafeCritical;
			}
		}

		/// <summary>
		/// Boolean IsSecurityTransparent
		/// </summary>
		protected RProperty r_IsSecurityTransparent;
		public virtual RProperty RIsSecurityTransparent
		{
			get
			{
				if(r_IsSecurityTransparent == null)
				{
					r_IsSecurityTransparent = new(this, "IsSecurityTransparent", -1);
					r_IsSecurityTransparent.SetBelong(this.instance);
				}
				return r_IsSecurityTransparent;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.StructLayoutAttribute StructLayoutAttribute
		/// </summary>
		protected RSystem.RRuntime.RInteropServices.RStructLayoutAttribute r_StructLayoutAttribute;
		public virtual RSystem.RRuntime.RInteropServices.RStructLayoutAttribute RStructLayoutAttribute
		{
			get
			{
				if(r_StructLayoutAttribute == null)
				{
					r_StructLayoutAttribute = new(this, "StructLayoutAttribute", -1);
					r_StructLayoutAttribute.SetBelong(this.instance);
				}
				return r_StructLayoutAttribute;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo TypeInitializer
		/// </summary>
		protected RSystem.RReflection.RConstructorInfo r_TypeInitializer;
		public virtual RSystem.RReflection.RConstructorInfo RTypeInitializer
		{
			get
			{
				if(r_TypeInitializer == null)
				{
					r_TypeInitializer = new(this, "TypeInitializer", -1);
					r_TypeInitializer.SetBelong(this.instance);
				}
				return r_TypeInitializer;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle TypeHandle
		/// </summary>
		protected RSystem.RRuntimeTypeHandle r_TypeHandle;
		public virtual RSystem.RRuntimeTypeHandle RTypeHandle
		{
			get
			{
				if(r_TypeHandle == null)
				{
					r_TypeHandle = new(this, "TypeHandle", -1);
					r_TypeHandle.SetBelong(this.instance);
				}
				return r_TypeHandle;
			}
		}

		/// <summary>
		/// System.Guid GUID
		/// </summary>
		protected RSystem.RGuid r_GUID;
		public virtual RSystem.RGuid RGUID
		{
			get
			{
				if(r_GUID == null)
				{
					r_GUID = new(this, "GUID", -1);
					r_GUID.SetBelong(this.instance);
				}
				return r_GUID;
			}
		}

		/// <summary>
		/// System.Type BaseType
		/// </summary>
		protected RSystem.RType r_BaseType;
		public virtual RSystem.RType RBaseType
		{
			get
			{
				if(r_BaseType == null)
				{
					r_BaseType = new(this, "BaseType", -1);
					r_BaseType.SetBelong(this.instance);
				}
				return r_BaseType;
			}
		}

		/// <summary>
		/// System.Reflection.Binder DefaultBinder
		/// </summary>
		protected static RSystem.RReflection.RBinder r_DefaultBinder;
		public static RSystem.RReflection.RBinder RDefaultBinder
		{
			get
			{
				if(r_DefaultBinder == null)
				{
					r_DefaultBinder = new(typeof(System.Type), "DefaultBinder", -1);
					r_DefaultBinder.SetBelong(null);
				}
				return r_DefaultBinder;
			}
		}

		/// <summary>
		/// Boolean IsUserType
		/// </summary>
		protected RProperty r_IsUserType;
		public virtual RProperty RIsUserType
		{
			get
			{
				if(r_IsUserType == null)
				{
					r_IsUserType = new(this, "IsUserType", -1);
					r_IsUserType.SetBelong(this.instance);
				}
				return r_IsUserType;
			}
		}

		/// <summary>
		/// Boolean IsWindowsRuntimeObject
		/// </summary>
		protected RProperty r_IsWindowsRuntimeObject;
		public virtual RProperty RIsWindowsRuntimeObject
		{
			get
			{
				if(r_IsWindowsRuntimeObject == null)
				{
					r_IsWindowsRuntimeObject = new(this, "IsWindowsRuntimeObject", -1);
					r_IsWindowsRuntimeObject.SetBelong(this.instance);
				}
				return r_IsWindowsRuntimeObject;
			}
		}

		/// <summary>
		/// Boolean IsExportedToWindowsRuntime
		/// </summary>
		protected RProperty r_IsExportedToWindowsRuntime;
		public virtual RProperty RIsExportedToWindowsRuntime
		{
			get
			{
				if(r_IsExportedToWindowsRuntime == null)
				{
					r_IsExportedToWindowsRuntime = new(this, "IsExportedToWindowsRuntime", -1);
					r_IsExportedToWindowsRuntime.SetBelong(this.instance);
				}
				return r_IsExportedToWindowsRuntime;
			}
		}

		/// <summary>
		/// Boolean IsSzArray
		/// </summary>
		protected RProperty r_IsSzArray;
		public virtual RProperty RIsSzArray
		{
			get
			{
				if(r_IsSzArray == null)
				{
					r_IsSzArray = new(this, "IsSzArray", -1);
					r_IsSzArray.SetBelong(this.instance);
				}
				return r_IsSzArray;
			}
		}

		/// <summary>
		/// Boolean IsInterface
		/// </summary>
		protected RProperty r_IsInterface;
		public virtual RProperty RIsInterface
		{
			get
			{
				if(r_IsInterface == null)
				{
					r_IsInterface = new(this, "IsInterface", -1);
					r_IsInterface.SetBelong(this.instance);
				}
				return r_IsInterface;
			}
		}

		/// <summary>
		/// System.String FullNameOrDefault
		/// </summary>
		protected RProperty r_FullNameOrDefault;
		public virtual RProperty RFullNameOrDefault
		{
			get
			{
				if(r_FullNameOrDefault == null)
				{
					r_FullNameOrDefault = new(this, "FullNameOrDefault", -1);
					r_FullNameOrDefault.SetBelong(this.instance);
				}
				return r_FullNameOrDefault;
			}
		}

		/// <summary>
		/// System.String InternalNameIfAvailable
		/// </summary>
		protected RProperty r_InternalNameIfAvailable;
		public virtual RProperty RInternalNameIfAvailable
		{
			get
			{
				if(r_InternalNameIfAvailable == null)
				{
					r_InternalNameIfAvailable = new(this, "InternalNameIfAvailable", -1);
					r_InternalNameIfAvailable.SetBelong(this.instance);
				}
				return r_InternalNameIfAvailable;
			}
		}

		/// <summary>
		/// System.String NameOrDefault
		/// </summary>
		protected RProperty r_NameOrDefault;
		public virtual RProperty RNameOrDefault
		{
			get
			{
				if(r_NameOrDefault == null)
				{
					r_NameOrDefault = new(this, "NameOrDefault", -1);
					r_NameOrDefault.SetBelong(this.instance);
				}
				return r_NameOrDefault;
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
		/// Boolean IsEnumDefined(System.Object)
		/// </summary>
		protected RMethod r_IsEnumDefined_Object;
		public virtual RMethod RIsEnumDefined_Object
		{
			get
			{
				if(r_IsEnumDefined_Object == null)
				{
					r_IsEnumDefined_Object = new(this, "IsEnumDefined", 0, typeof(System.Object));
					r_IsEnumDefined_Object.SetBelong(this.instance);
				}
				return r_IsEnumDefined_Object;
			}
		}

		/// <summary>
		/// System.String GetEnumName(System.Object)
		/// </summary>
		protected RMethod r_GetEnumName_Object;
		public virtual RMethod RGetEnumName_Object
		{
			get
			{
				if(r_GetEnumName_Object == null)
				{
					r_GetEnumName_Object = new(this, "GetEnumName", 0, typeof(System.Object));
					r_GetEnumName_Object.SetBelong(this.instance);
				}
				return r_GetEnumName_Object;
			}
		}

		/// <summary>
		/// System.String[] GetEnumNames()
		/// </summary>
		protected RMethod r_GetEnumNames;
		public virtual RMethod RGetEnumNames
		{
			get
			{
				if(r_GetEnumNames == null)
				{
					r_GetEnumNames = new(this, "GetEnumNames", 0);
					r_GetEnumNames.SetBelong(this.instance);
				}
				return r_GetEnumNames;
			}
		}

		/// <summary>
		/// System.Array GetEnumRawConstantValues()
		/// </summary>
		protected RMethod r_GetEnumRawConstantValues;
		public virtual RMethod RGetEnumRawConstantValues
		{
			get
			{
				if(r_GetEnumRawConstantValues == null)
				{
					r_GetEnumRawConstantValues = new(this, "GetEnumRawConstantValues", 0);
					r_GetEnumRawConstantValues.SetBelong(this.instance);
				}
				return r_GetEnumRawConstantValues;
			}
		}

		/// <summary>
		/// Void GetEnumData(System.String[] ByRef, System.Array ByRef)
		/// </summary>
		protected RMethod r_GetEnumData_Out_StringArray_Out_Array;
		public virtual RMethod RGetEnumData_Out_StringArray_Out_Array
		{
			get
			{
				if(r_GetEnumData_Out_StringArray_Out_Array == null)
				{
					r_GetEnumData_Out_StringArray_Out_Array = new(this, "GetEnumData", 0, typeof(System.String).MakeArrayType().MakeByRefType(), typeof(System.Array).MakeByRefType());
					r_GetEnumData_Out_StringArray_Out_Array.SetBelong(this.instance);
				}
				return r_GetEnumData_Out_StringArray_Out_Array;
			}
		}

		/// <summary>
		/// Int32 BinarySearch(System.Array, System.Object)
		/// </summary>
		protected static RMethod r_BinarySearch_Array_Object;
		public static RMethod RBinarySearch_Array_Object
		{
			get
			{
				if(r_BinarySearch_Array_Object == null)
				{
					r_BinarySearch_Array_Object = new(typeof(System.Type), "BinarySearch", 0, typeof(System.Array), typeof(System.Object));
					r_BinarySearch_Array_Object.SetBelong(null);
				}
				return r_BinarySearch_Array_Object;
			}
		}

		/// <summary>
		/// Boolean IsIntegerType(System.Type)
		/// </summary>
		protected static RMethod r_IsIntegerType_Type;
		public static RMethod RIsIntegerType_Type
		{
			get
			{
				if(r_IsIntegerType_Type == null)
				{
					r_IsIntegerType_Type = new(typeof(System.Type), "IsIntegerType", 0, typeof(System.Type));
					r_IsIntegerType_Type.SetBelong(null);
				}
				return r_IsIntegerType_Type;
			}
		}

		/// <summary>
		/// System.Type GetRootElementType()
		/// </summary>
		protected RMethod r_GetRootElementType;
		public virtual RMethod RGetRootElementType
		{
			get
			{
				if(r_GetRootElementType == null)
				{
					r_GetRootElementType = new(this, "GetRootElementType", 0);
					r_GetRootElementType.SetBelong(this.instance);
				}
				return r_GetRootElementType;
			}
		}

		/// <summary>
		/// System.Type[] FindInterfaces(System.Reflection.TypeFilter, System.Object)
		/// </summary>
		protected RMethod r_FindInterfaces_TypeFilter_Object;
		public virtual RMethod RFindInterfaces_TypeFilter_Object
		{
			get
			{
				if(r_FindInterfaces_TypeFilter_Object == null)
				{
					r_FindInterfaces_TypeFilter_Object = new(this, "FindInterfaces", 0, typeof(System.Reflection.TypeFilter), typeof(System.Object));
					r_FindInterfaces_TypeFilter_Object.SetBelong(this.instance);
				}
				return r_FindInterfaces_TypeFilter_Object;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] FindMembers(System.Reflection.MemberTypes, System.Reflection.BindingFlags, System.Reflection.MemberFilter, System.Object)
		/// </summary>
		protected RMethod r_FindMembers_MemberTypes_BindingFlags_MemberFilter_Object;
		public virtual RMethod RFindMembers_MemberTypes_BindingFlags_MemberFilter_Object
		{
			get
			{
				if(r_FindMembers_MemberTypes_BindingFlags_MemberFilter_Object == null)
				{
					r_FindMembers_MemberTypes_BindingFlags_MemberFilter_Object = new(this, "FindMembers", 0, typeof(System.Reflection.MemberTypes), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.MemberFilter), typeof(System.Object));
					r_FindMembers_MemberTypes_BindingFlags_MemberFilter_Object.SetBelong(this.instance);
				}
				return r_FindMembers_MemberTypes_BindingFlags_MemberFilter_Object;
			}
		}

		/// <summary>
		/// Boolean IsSubclassOf(System.Type)
		/// </summary>
		protected RMethod r_IsSubclassOf_Type;
		public virtual RMethod RIsSubclassOf_Type
		{
			get
			{
				if(r_IsSubclassOf_Type == null)
				{
					r_IsSubclassOf_Type = new(this, "IsSubclassOf", 0, typeof(System.Type));
					r_IsSubclassOf_Type.SetBelong(this.instance);
				}
				return r_IsSubclassOf_Type;
			}
		}

		/// <summary>
		/// Boolean IsAssignableFrom(System.Type)
		/// </summary>
		protected RMethod r_IsAssignableFrom_Type;
		public virtual RMethod RIsAssignableFrom_Type
		{
			get
			{
				if(r_IsAssignableFrom_Type == null)
				{
					r_IsAssignableFrom_Type = new(this, "IsAssignableFrom", 0, typeof(System.Type));
					r_IsAssignableFrom_Type.SetBelong(this.instance);
				}
				return r_IsAssignableFrom_Type;
			}
		}

		/// <summary>
		/// Boolean ImplementInterface(System.Type)
		/// </summary>
		protected RMethod r_ImplementInterface_Type;
		public virtual RMethod RImplementInterface_Type
		{
			get
			{
				if(r_ImplementInterface_Type == null)
				{
					r_ImplementInterface_Type = new(this, "ImplementInterface", 0, typeof(System.Type));
					r_ImplementInterface_Type.SetBelong(this.instance);
				}
				return r_ImplementInterface_Type;
			}
		}

		/// <summary>
		/// Boolean FilterAttributeImpl(System.Reflection.MemberInfo, System.Object)
		/// </summary>
		protected static RMethod r_FilterAttributeImpl_MemberInfo_Object;
		public static RMethod RFilterAttributeImpl_MemberInfo_Object
		{
			get
			{
				if(r_FilterAttributeImpl_MemberInfo_Object == null)
				{
					r_FilterAttributeImpl_MemberInfo_Object = new(typeof(System.Type), "FilterAttributeImpl", 0, typeof(System.Reflection.MemberInfo), typeof(System.Object));
					r_FilterAttributeImpl_MemberInfo_Object.SetBelong(null);
				}
				return r_FilterAttributeImpl_MemberInfo_Object;
			}
		}

		/// <summary>
		/// Boolean FilterNameImpl(System.Reflection.MemberInfo, System.Object)
		/// </summary>
		protected static RMethod r_FilterNameImpl_MemberInfo_Object;
		public static RMethod RFilterNameImpl_MemberInfo_Object
		{
			get
			{
				if(r_FilterNameImpl_MemberInfo_Object == null)
				{
					r_FilterNameImpl_MemberInfo_Object = new(typeof(System.Type), "FilterNameImpl", 0, typeof(System.Reflection.MemberInfo), typeof(System.Object));
					r_FilterNameImpl_MemberInfo_Object.SetBelong(null);
				}
				return r_FilterNameImpl_MemberInfo_Object;
			}
		}

		/// <summary>
		/// Boolean FilterNameIgnoreCaseImpl(System.Reflection.MemberInfo, System.Object)
		/// </summary>
		protected static RMethod r_FilterNameIgnoreCaseImpl_MemberInfo_Object;
		public static RMethod RFilterNameIgnoreCaseImpl_MemberInfo_Object
		{
			get
			{
				if(r_FilterNameIgnoreCaseImpl_MemberInfo_Object == null)
				{
					r_FilterNameIgnoreCaseImpl_MemberInfo_Object = new(typeof(System.Type), "FilterNameIgnoreCaseImpl", 0, typeof(System.Reflection.MemberInfo), typeof(System.Object));
					r_FilterNameIgnoreCaseImpl_MemberInfo_Object.SetBelong(null);
				}
				return r_FilterNameIgnoreCaseImpl_MemberInfo_Object;
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
		/// Boolean IsArrayImpl()
		/// </summary>
		protected RMethod r_IsArrayImpl;
		public virtual RMethod RIsArrayImpl
		{
			get
			{
				if(r_IsArrayImpl == null)
				{
					r_IsArrayImpl = new(this, "IsArrayImpl", 0);
					r_IsArrayImpl.SetBelong(this.instance);
				}
				return r_IsArrayImpl;
			}
		}

		/// <summary>
		/// Boolean IsByRefImpl()
		/// </summary>
		protected RMethod r_IsByRefImpl;
		public virtual RMethod RIsByRefImpl
		{
			get
			{
				if(r_IsByRefImpl == null)
				{
					r_IsByRefImpl = new(this, "IsByRefImpl", 0);
					r_IsByRefImpl.SetBelong(this.instance);
				}
				return r_IsByRefImpl;
			}
		}

		/// <summary>
		/// Boolean IsPointerImpl()
		/// </summary>
		protected RMethod r_IsPointerImpl;
		public virtual RMethod RIsPointerImpl
		{
			get
			{
				if(r_IsPointerImpl == null)
				{
					r_IsPointerImpl = new(this, "IsPointerImpl", 0);
					r_IsPointerImpl.SetBelong(this.instance);
				}
				return r_IsPointerImpl;
			}
		}

		/// <summary>
		/// Boolean HasElementTypeImpl()
		/// </summary>
		protected RMethod r_HasElementTypeImpl;
		public virtual RMethod RHasElementTypeImpl
		{
			get
			{
				if(r_HasElementTypeImpl == null)
				{
					r_HasElementTypeImpl = new(this, "HasElementTypeImpl", 0);
					r_HasElementTypeImpl.SetBelong(this.instance);
				}
				return r_HasElementTypeImpl;
			}
		}

		/// <summary>
		/// System.Type GetElementType()
		/// </summary>
		protected RMethod r_GetElementType;
		public virtual RMethod RGetElementType
		{
			get
			{
				if(r_GetElementType == null)
				{
					r_GetElementType = new(this, "GetElementType", 0);
					r_GetElementType.SetBelong(this.instance);
				}
				return r_GetElementType;
			}
		}

		/// <summary>
		/// Int32 GetArrayRank()
		/// </summary>
		protected RMethod r_GetArrayRank;
		public virtual RMethod RGetArrayRank
		{
			get
			{
				if(r_GetArrayRank == null)
				{
					r_GetArrayRank = new(this, "GetArrayRank", 0);
					r_GetArrayRank.SetBelong(this.instance);
				}
				return r_GetArrayRank;
			}
		}

		/// <summary>
		/// System.Type GetGenericTypeDefinition()
		/// </summary>
		protected RMethod r_GetGenericTypeDefinition;
		public virtual RMethod RGetGenericTypeDefinition
		{
			get
			{
				if(r_GetGenericTypeDefinition == null)
				{
					r_GetGenericTypeDefinition = new(this, "GetGenericTypeDefinition", 0);
					r_GetGenericTypeDefinition.SetBelong(this.instance);
				}
				return r_GetGenericTypeDefinition;
			}
		}

		/// <summary>
		/// System.Type[] GetGenericArguments()
		/// </summary>
		protected RMethod r_GetGenericArguments;
		public virtual RMethod RGetGenericArguments
		{
			get
			{
				if(r_GetGenericArguments == null)
				{
					r_GetGenericArguments = new(this, "GetGenericArguments", 0);
					r_GetGenericArguments.SetBelong(this.instance);
				}
				return r_GetGenericArguments;
			}
		}

		/// <summary>
		/// System.Type[] GetGenericParameterConstraints()
		/// </summary>
		protected RMethod r_GetGenericParameterConstraints;
		public virtual RMethod RGetGenericParameterConstraints
		{
			get
			{
				if(r_GetGenericParameterConstraints == null)
				{
					r_GetGenericParameterConstraints = new(this, "GetGenericParameterConstraints", 0);
					r_GetGenericParameterConstraints.SetBelong(this.instance);
				}
				return r_GetGenericParameterConstraints;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes GetAttributeFlagsImpl()
		/// </summary>
		protected RMethod r_GetAttributeFlagsImpl;
		public virtual RMethod RGetAttributeFlagsImpl
		{
			get
			{
				if(r_GetAttributeFlagsImpl == null)
				{
					r_GetAttributeFlagsImpl = new(this, "GetAttributeFlagsImpl", 0);
					r_GetAttributeFlagsImpl.SetBelong(this.instance);
				}
				return r_GetAttributeFlagsImpl;
			}
		}

		/// <summary>
		/// Boolean IsCOMObjectImpl()
		/// </summary>
		protected RMethod r_IsCOMObjectImpl;
		public virtual RMethod RIsCOMObjectImpl
		{
			get
			{
				if(r_IsCOMObjectImpl == null)
				{
					r_IsCOMObjectImpl = new(this, "IsCOMObjectImpl", 0);
					r_IsCOMObjectImpl.SetBelong(this.instance);
				}
				return r_IsCOMObjectImpl;
			}
		}

		/// <summary>
		/// Boolean IsContextfulImpl()
		/// </summary>
		protected RMethod r_IsContextfulImpl;
		public virtual RMethod RIsContextfulImpl
		{
			get
			{
				if(r_IsContextfulImpl == null)
				{
					r_IsContextfulImpl = new(this, "IsContextfulImpl", 0);
					r_IsContextfulImpl.SetBelong(this.instance);
				}
				return r_IsContextfulImpl;
			}
		}

		/// <summary>
		/// Boolean IsMarshalByRefImpl()
		/// </summary>
		protected RMethod r_IsMarshalByRefImpl;
		public virtual RMethod RIsMarshalByRefImpl
		{
			get
			{
				if(r_IsMarshalByRefImpl == null)
				{
					r_IsMarshalByRefImpl = new(this, "IsMarshalByRefImpl", 0);
					r_IsMarshalByRefImpl.SetBelong(this.instance);
				}
				return r_IsMarshalByRefImpl;
			}
		}

		/// <summary>
		/// Boolean IsPrimitiveImpl()
		/// </summary>
		protected RMethod r_IsPrimitiveImpl;
		public virtual RMethod RIsPrimitiveImpl
		{
			get
			{
				if(r_IsPrimitiveImpl == null)
				{
					r_IsPrimitiveImpl = new(this, "IsPrimitiveImpl", 0);
					r_IsPrimitiveImpl.SetBelong(this.instance);
				}
				return r_IsPrimitiveImpl;
			}
		}

		/// <summary>
		/// Boolean IsValueTypeImpl()
		/// </summary>
		protected RMethod r_IsValueTypeImpl;
		public virtual RMethod RIsValueTypeImpl
		{
			get
			{
				if(r_IsValueTypeImpl == null)
				{
					r_IsValueTypeImpl = new(this, "IsValueTypeImpl", 0);
					r_IsValueTypeImpl.SetBelong(this.instance);
				}
				return r_IsValueTypeImpl;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructor(System.Type[])
		/// </summary>
		protected RMethod r_GetConstructor_TypeArray;
		public virtual RMethod RGetConstructor_TypeArray
		{
			get
			{
				if(r_GetConstructor_TypeArray == null)
				{
					r_GetConstructor_TypeArray = new(this, "GetConstructor", 0, typeof(System.Type).MakeArrayType());
					r_GetConstructor_TypeArray.SetBelong(this.instance);
				}
				return r_GetConstructor_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags, System.Reflection.Binder, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray == null)
				{
					r_GetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray = new(this, "GetConstructor", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_GetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetConstructor", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_GetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetConstructorImpl", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo[] GetConstructors()
		/// </summary>
		protected RMethod r_GetConstructors;
		public virtual RMethod RGetConstructors
		{
			get
			{
				if(r_GetConstructors == null)
				{
					r_GetConstructors = new(this, "GetConstructors", 0);
					r_GetConstructors.SetBelong(this.instance);
				}
				return r_GetConstructors;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetConstructors_BindingFlags;
		public virtual RMethod RGetConstructors_BindingFlags
		{
			get
			{
				if(r_GetConstructors_BindingFlags == null)
				{
					r_GetConstructors_BindingFlags = new(this, "GetConstructors", 0, typeof(System.Reflection.BindingFlags));
					r_GetConstructors_BindingFlags.SetBelong(this.instance);
				}
				return r_GetConstructors_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo GetEvent(System.String)
		/// </summary>
		protected RMethod r_GetEvent_String;
		public virtual RMethod RGetEvent_String
		{
			get
			{
				if(r_GetEvent_String == null)
				{
					r_GetEvent_String = new(this, "GetEvent", 0, typeof(System.String));
					r_GetEvent_String.SetBelong(this.instance);
				}
				return r_GetEvent_String;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo GetEvent(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetEvent_String_BindingFlags;
		public virtual RMethod RGetEvent_String_BindingFlags
		{
			get
			{
				if(r_GetEvent_String_BindingFlags == null)
				{
					r_GetEvent_String_BindingFlags = new(this, "GetEvent", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_GetEvent_String_BindingFlags.SetBelong(this.instance);
				}
				return r_GetEvent_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo[] GetEvents()
		/// </summary>
		protected RMethod r_GetEvents;
		public virtual RMethod RGetEvents
		{
			get
			{
				if(r_GetEvents == null)
				{
					r_GetEvents = new(this, "GetEvents", 0);
					r_GetEvents.SetBelong(this.instance);
				}
				return r_GetEvents;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetEvents_BindingFlags;
		public virtual RMethod RGetEvents_BindingFlags
		{
			get
			{
				if(r_GetEvents_BindingFlags == null)
				{
					r_GetEvents_BindingFlags = new(this, "GetEvents", 0, typeof(System.Reflection.BindingFlags));
					r_GetEvents_BindingFlags.SetBelong(this.instance);
				}
				return r_GetEvents_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetField(System.String)
		/// </summary>
		protected RMethod r_GetField_String;
		public virtual RMethod RGetField_String
		{
			get
			{
				if(r_GetField_String == null)
				{
					r_GetField_String = new(this, "GetField", 0, typeof(System.String));
					r_GetField_String.SetBelong(this.instance);
				}
				return r_GetField_String;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetField(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetField_String_BindingFlags;
		public virtual RMethod RGetField_String_BindingFlags
		{
			get
			{
				if(r_GetField_String_BindingFlags == null)
				{
					r_GetField_String_BindingFlags = new(this, "GetField", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_GetField_String_BindingFlags.SetBelong(this.instance);
				}
				return r_GetField_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo[] GetFields()
		/// </summary>
		protected RMethod r_GetFields;
		public virtual RMethod RGetFields
		{
			get
			{
				if(r_GetFields == null)
				{
					r_GetFields = new(this, "GetFields", 0);
					r_GetFields.SetBelong(this.instance);
				}
				return r_GetFields;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetFields_BindingFlags;
		public virtual RMethod RGetFields_BindingFlags
		{
			get
			{
				if(r_GetFields_BindingFlags == null)
				{
					r_GetFields_BindingFlags = new(this, "GetFields", 0, typeof(System.Reflection.BindingFlags));
					r_GetFields_BindingFlags.SetBelong(this.instance);
				}
				return r_GetFields_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMember(System.String)
		/// </summary>
		protected RMethod r_GetMember_String;
		public virtual RMethod RGetMember_String
		{
			get
			{
				if(r_GetMember_String == null)
				{
					r_GetMember_String = new(this, "GetMember", 0, typeof(System.String));
					r_GetMember_String.SetBelong(this.instance);
				}
				return r_GetMember_String;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMember(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetMember_String_BindingFlags;
		public virtual RMethod RGetMember_String_BindingFlags
		{
			get
			{
				if(r_GetMember_String_BindingFlags == null)
				{
					r_GetMember_String_BindingFlags = new(this, "GetMember", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_GetMember_String_BindingFlags.SetBelong(this.instance);
				}
				return r_GetMember_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMember(System.String, System.Reflection.MemberTypes, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetMember_String_MemberTypes_BindingFlags;
		public virtual RMethod RGetMember_String_MemberTypes_BindingFlags
		{
			get
			{
				if(r_GetMember_String_MemberTypes_BindingFlags == null)
				{
					r_GetMember_String_MemberTypes_BindingFlags = new(this, "GetMember", 0, typeof(System.String), typeof(System.Reflection.MemberTypes), typeof(System.Reflection.BindingFlags));
					r_GetMember_String_MemberTypes_BindingFlags.SetBelong(this.instance);
				}
				return r_GetMember_String_MemberTypes_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMembers()
		/// </summary>
		protected RMethod r_GetMembers;
		public virtual RMethod RGetMembers
		{
			get
			{
				if(r_GetMembers == null)
				{
					r_GetMembers = new(this, "GetMembers", 0);
					r_GetMembers.SetBelong(this.instance);
				}
				return r_GetMembers;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetMembers_BindingFlags;
		public virtual RMethod RGetMembers_BindingFlags
		{
			get
			{
				if(r_GetMembers_BindingFlags == null)
				{
					r_GetMembers_BindingFlags = new(this, "GetMembers", 0, typeof(System.Reflection.BindingFlags));
					r_GetMembers_BindingFlags.SetBelong(this.instance);
				}
				return r_GetMembers_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String)
		/// </summary>
		protected RMethod r_GetMethod_String;
		public virtual RMethod RGetMethod_String
		{
			get
			{
				if(r_GetMethod_String == null)
				{
					r_GetMethod_String = new(this, "GetMethod", 0, typeof(System.String));
					r_GetMethod_String.SetBelong(this.instance);
				}
				return r_GetMethod_String;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetMethod_String_BindingFlags;
		public virtual RMethod RGetMethod_String_BindingFlags
		{
			get
			{
				if(r_GetMethod_String_BindingFlags == null)
				{
					r_GetMethod_String_BindingFlags = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_GetMethod_String_BindingFlags.SetBelong(this.instance);
				}
				return r_GetMethod_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Type[])
		/// </summary>
		protected RMethod r_GetMethod_String_TypeArray;
		public virtual RMethod RGetMethod_String_TypeArray
		{
			get
			{
				if(r_GetMethod_String_TypeArray == null)
				{
					r_GetMethod_String_TypeArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Type).MakeArrayType());
					r_GetMethod_String_TypeArray.SetBelong(this.instance);
				}
				return r_GetMethod_String_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetMethod_String_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethod_String_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetMethod_String_TypeArray_ParameterModifierArray == null)
				{
					r_GetMethod_String_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetMethod_String_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetMethod_String_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray == null)
				{
					r_GetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_GetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethodImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_GetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethodImpl", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, Int32, System.Type[])
		/// </summary>
		protected RMethod r_GetMethod_String_Int32_TypeArray;
		public virtual RMethod RGetMethod_String_Int32_TypeArray
		{
			get
			{
				if(r_GetMethod_String_Int32_TypeArray == null)
				{
					r_GetMethod_String_Int32_TypeArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Int32), typeof(System.Type).MakeArrayType());
					r_GetMethod_String_Int32_TypeArray.SetBelong(this.instance);
				}
				return r_GetMethod_String_Int32_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, Int32, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetMethod_String_Int32_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethod_String_Int32_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetMethod_String_Int32_TypeArray_ParameterModifierArray == null)
				{
					r_GetMethod_String_Int32_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetMethod_String_Int32_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetMethod_String_Int32_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray == null)
				{
					r_GetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_GetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethodImpl(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_GetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethodImpl", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetMethods()
		/// </summary>
		protected RMethod r_GetMethods;
		public virtual RMethod RGetMethods
		{
			get
			{
				if(r_GetMethods == null)
				{
					r_GetMethods = new(this, "GetMethods", 0);
					r_GetMethods.SetBelong(this.instance);
				}
				return r_GetMethods;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetMethods_BindingFlags;
		public virtual RMethod RGetMethods_BindingFlags
		{
			get
			{
				if(r_GetMethods_BindingFlags == null)
				{
					r_GetMethods_BindingFlags = new(this, "GetMethods", 0, typeof(System.Reflection.BindingFlags));
					r_GetMethods_BindingFlags.SetBelong(this.instance);
				}
				return r_GetMethods_BindingFlags;
			}
		}

		/// <summary>
		/// System.Type GetNestedType(System.String)
		/// </summary>
		protected RMethod r_GetNestedType_String;
		public virtual RMethod RGetNestedType_String
		{
			get
			{
				if(r_GetNestedType_String == null)
				{
					r_GetNestedType_String = new(this, "GetNestedType", 0, typeof(System.String));
					r_GetNestedType_String.SetBelong(this.instance);
				}
				return r_GetNestedType_String;
			}
		}

		/// <summary>
		/// System.Type GetNestedType(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetNestedType_String_BindingFlags;
		public virtual RMethod RGetNestedType_String_BindingFlags
		{
			get
			{
				if(r_GetNestedType_String_BindingFlags == null)
				{
					r_GetNestedType_String_BindingFlags = new(this, "GetNestedType", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_GetNestedType_String_BindingFlags.SetBelong(this.instance);
				}
				return r_GetNestedType_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Type[] GetNestedTypes()
		/// </summary>
		protected RMethod r_GetNestedTypes;
		public virtual RMethod RGetNestedTypes
		{
			get
			{
				if(r_GetNestedTypes == null)
				{
					r_GetNestedTypes = new(this, "GetNestedTypes", 0);
					r_GetNestedTypes.SetBelong(this.instance);
				}
				return r_GetNestedTypes;
			}
		}

		/// <summary>
		/// System.Type[] GetNestedTypes(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetNestedTypes_BindingFlags;
		public virtual RMethod RGetNestedTypes_BindingFlags
		{
			get
			{
				if(r_GetNestedTypes_BindingFlags == null)
				{
					r_GetNestedTypes_BindingFlags = new(this, "GetNestedTypes", 0, typeof(System.Reflection.BindingFlags));
					r_GetNestedTypes_BindingFlags.SetBelong(this.instance);
				}
				return r_GetNestedTypes_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String)
		/// </summary>
		protected RMethod r_GetProperty_String;
		public virtual RMethod RGetProperty_String
		{
			get
			{
				if(r_GetProperty_String == null)
				{
					r_GetProperty_String = new(this, "GetProperty", 0, typeof(System.String));
					r_GetProperty_String.SetBelong(this.instance);
				}
				return r_GetProperty_String;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetProperty_String_BindingFlags;
		public virtual RMethod RGetProperty_String_BindingFlags
		{
			get
			{
				if(r_GetProperty_String_BindingFlags == null)
				{
					r_GetProperty_String_BindingFlags = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_GetProperty_String_BindingFlags.SetBelong(this.instance);
				}
				return r_GetProperty_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type)
		/// </summary>
		protected RMethod r_GetProperty_String_Type;
		public virtual RMethod RGetProperty_String_Type
		{
			get
			{
				if(r_GetProperty_String_Type == null)
				{
					r_GetProperty_String_Type = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Type));
					r_GetProperty_String_Type.SetBelong(this.instance);
				}
				return r_GetProperty_String_Type;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type[])
		/// </summary>
		protected RMethod r_GetProperty_String_TypeArray;
		public virtual RMethod RGetProperty_String_TypeArray
		{
			get
			{
				if(r_GetProperty_String_TypeArray == null)
				{
					r_GetProperty_String_TypeArray = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Type).MakeArrayType());
					r_GetProperty_String_TypeArray.SetBelong(this.instance);
				}
				return r_GetProperty_String_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_GetProperty_String_Type_TypeArray;
		public virtual RMethod RGetProperty_String_Type_TypeArray
		{
			get
			{
				if(r_GetProperty_String_Type_TypeArray == null)
				{
					r_GetProperty_String_Type_TypeArray = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_GetProperty_String_Type_TypeArray.SetBelong(this.instance);
				}
				return r_GetProperty_String_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetProperty_String_Type_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetProperty_String_Type_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetProperty_String_Type_TypeArray_ParameterModifierArray == null)
				{
					r_GetProperty_String_Type_TypeArray_ParameterModifierArray = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetProperty_String_Type_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetProperty_String_Type_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray == null)
				{
					r_GetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetPropertyImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_GetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_GetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray == null)
				{
					r_GetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray = new(this, "GetPropertyImpl", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_GetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_GetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo[] GetProperties()
		/// </summary>
		protected RMethod r_GetProperties;
		public virtual RMethod RGetProperties
		{
			get
			{
				if(r_GetProperties == null)
				{
					r_GetProperties = new(this, "GetProperties", 0);
					r_GetProperties.SetBelong(this.instance);
				}
				return r_GetProperties;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_GetProperties_BindingFlags;
		public virtual RMethod RGetProperties_BindingFlags
		{
			get
			{
				if(r_GetProperties_BindingFlags == null)
				{
					r_GetProperties_BindingFlags = new(this, "GetProperties", 0, typeof(System.Reflection.BindingFlags));
					r_GetProperties_BindingFlags.SetBelong(this.instance);
				}
				return r_GetProperties_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetDefaultMembers()
		/// </summary>
		protected RMethod r_GetDefaultMembers;
		public virtual RMethod RGetDefaultMembers
		{
			get
			{
				if(r_GetDefaultMembers == null)
				{
					r_GetDefaultMembers = new(this, "GetDefaultMembers", 0);
					r_GetDefaultMembers.SetBelong(this.instance);
				}
				return r_GetDefaultMembers;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle GetTypeHandle(System.Object)
		/// </summary>
		protected static RMethod r_GetTypeHandle_Object;
		public static RMethod RGetTypeHandle_Object
		{
			get
			{
				if(r_GetTypeHandle_Object == null)
				{
					r_GetTypeHandle_Object = new(typeof(System.Type), "GetTypeHandle", 0, typeof(System.Object));
					r_GetTypeHandle_Object.SetBelong(null);
				}
				return r_GetTypeHandle_Object;
			}
		}

		/// <summary>
		/// System.Type[] GetTypeArray(System.Object[])
		/// </summary>
		protected static RMethod r_GetTypeArray_ObjectArray;
		public static RMethod RGetTypeArray_ObjectArray
		{
			get
			{
				if(r_GetTypeArray_ObjectArray == null)
				{
					r_GetTypeArray_ObjectArray = new(typeof(System.Type), "GetTypeArray", 0, typeof(System.Object).MakeArrayType());
					r_GetTypeArray_ObjectArray.SetBelong(null);
				}
				return r_GetTypeArray_ObjectArray;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode(System.Type)
		/// </summary>
		protected static RMethod r_GetTypeCode_Type;
		public static RMethod RGetTypeCode_Type
		{
			get
			{
				if(r_GetTypeCode_Type == null)
				{
					r_GetTypeCode_Type = new(typeof(System.Type), "GetTypeCode", 0, typeof(System.Type));
					r_GetTypeCode_Type.SetBelong(null);
				}
				return r_GetTypeCode_Type;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCodeImpl()
		/// </summary>
		protected RMethod r_GetTypeCodeImpl;
		public virtual RMethod RGetTypeCodeImpl
		{
			get
			{
				if(r_GetTypeCodeImpl == null)
				{
					r_GetTypeCodeImpl = new(this, "GetTypeCodeImpl", 0);
					r_GetTypeCodeImpl.SetBelong(this.instance);
				}
				return r_GetTypeCodeImpl;
			}
		}

		/// <summary>
		/// System.Type GetTypeFromCLSID(System.Guid)
		/// </summary>
		protected static RMethod r_GetTypeFromCLSID_Guid;
		public static RMethod RGetTypeFromCLSID_Guid
		{
			get
			{
				if(r_GetTypeFromCLSID_Guid == null)
				{
					r_GetTypeFromCLSID_Guid = new(typeof(System.Type), "GetTypeFromCLSID", 0, typeof(System.Guid));
					r_GetTypeFromCLSID_Guid.SetBelong(null);
				}
				return r_GetTypeFromCLSID_Guid;
			}
		}

		/// <summary>
		/// System.Type GetTypeFromCLSID(System.Guid, Boolean)
		/// </summary>
		protected static RMethod r_GetTypeFromCLSID_Guid_Boolean;
		public static RMethod RGetTypeFromCLSID_Guid_Boolean
		{
			get
			{
				if(r_GetTypeFromCLSID_Guid_Boolean == null)
				{
					r_GetTypeFromCLSID_Guid_Boolean = new(typeof(System.Type), "GetTypeFromCLSID", 0, typeof(System.Guid), typeof(System.Boolean));
					r_GetTypeFromCLSID_Guid_Boolean.SetBelong(null);
				}
				return r_GetTypeFromCLSID_Guid_Boolean;
			}
		}

		/// <summary>
		/// System.Type GetTypeFromCLSID(System.Guid, System.String)
		/// </summary>
		protected static RMethod r_GetTypeFromCLSID_Guid_String;
		public static RMethod RGetTypeFromCLSID_Guid_String
		{
			get
			{
				if(r_GetTypeFromCLSID_Guid_String == null)
				{
					r_GetTypeFromCLSID_Guid_String = new(typeof(System.Type), "GetTypeFromCLSID", 0, typeof(System.Guid), typeof(System.String));
					r_GetTypeFromCLSID_Guid_String.SetBelong(null);
				}
				return r_GetTypeFromCLSID_Guid_String;
			}
		}

		/// <summary>
		/// System.Type GetTypeFromProgID(System.String)
		/// </summary>
		protected static RMethod r_GetTypeFromProgID_String;
		public static RMethod RGetTypeFromProgID_String
		{
			get
			{
				if(r_GetTypeFromProgID_String == null)
				{
					r_GetTypeFromProgID_String = new(typeof(System.Type), "GetTypeFromProgID", 0, typeof(System.String));
					r_GetTypeFromProgID_String.SetBelong(null);
				}
				return r_GetTypeFromProgID_String;
			}
		}

		/// <summary>
		/// System.Type GetTypeFromProgID(System.String, Boolean)
		/// </summary>
		protected static RMethod r_GetTypeFromProgID_String_Boolean;
		public static RMethod RGetTypeFromProgID_String_Boolean
		{
			get
			{
				if(r_GetTypeFromProgID_String_Boolean == null)
				{
					r_GetTypeFromProgID_String_Boolean = new(typeof(System.Type), "GetTypeFromProgID", 0, typeof(System.String), typeof(System.Boolean));
					r_GetTypeFromProgID_String_Boolean.SetBelong(null);
				}
				return r_GetTypeFromProgID_String_Boolean;
			}
		}

		/// <summary>
		/// System.Type GetTypeFromProgID(System.String, System.String)
		/// </summary>
		protected static RMethod r_GetTypeFromProgID_String_String;
		public static RMethod RGetTypeFromProgID_String_String
		{
			get
			{
				if(r_GetTypeFromProgID_String_String == null)
				{
					r_GetTypeFromProgID_String_String = new(typeof(System.Type), "GetTypeFromProgID", 0, typeof(System.String), typeof(System.String));
					r_GetTypeFromProgID_String_String.SetBelong(null);
				}
				return r_GetTypeFromProgID_String_String;
			}
		}

		/// <summary>
		/// System.Object InvokeMember(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Object[])
		/// </summary>
		protected RMethod r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray;
		public virtual RMethod RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray
		{
			get
			{
				if(r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray == null)
				{
					r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray = new(this, "InvokeMember", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object), typeof(System.Object).MakeArrayType());
					r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray.SetBelong(this.instance);
				}
				return r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object InvokeMember(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo;
		public virtual RMethod RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo
		{
			get
			{
				if(r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo == null)
				{
					r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo = new(this, "InvokeMember", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
					r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo.SetBelong(this.instance);
				}
				return r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo;
			}
		}

		/// <summary>
		/// System.Object InvokeMember(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Object[], System.Reflection.ParameterModifier[], System.Globalization.CultureInfo, System.String[])
		/// </summary>
		protected RMethod r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray;
		public virtual RMethod RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray
		{
			get
			{
				if(r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray == null)
				{
					r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray = new(this, "InvokeMember", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object), typeof(System.Object).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.String).MakeArrayType());
					r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray.SetBelong(this.instance);
				}
				return r_InvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray;
			}
		}

		/// <summary>
		/// System.Type GetInterface(System.String)
		/// </summary>
		protected RMethod r_GetInterface_String;
		public virtual RMethod RGetInterface_String
		{
			get
			{
				if(r_GetInterface_String == null)
				{
					r_GetInterface_String = new(this, "GetInterface", 0, typeof(System.String));
					r_GetInterface_String.SetBelong(this.instance);
				}
				return r_GetInterface_String;
			}
		}

		/// <summary>
		/// System.Type GetInterface(System.String, Boolean)
		/// </summary>
		protected RMethod r_GetInterface_String_Boolean;
		public virtual RMethod RGetInterface_String_Boolean
		{
			get
			{
				if(r_GetInterface_String_Boolean == null)
				{
					r_GetInterface_String_Boolean = new(this, "GetInterface", 0, typeof(System.String), typeof(System.Boolean));
					r_GetInterface_String_Boolean.SetBelong(this.instance);
				}
				return r_GetInterface_String_Boolean;
			}
		}

		/// <summary>
		/// System.Type[] GetInterfaces()
		/// </summary>
		protected RMethod r_GetInterfaces;
		public virtual RMethod RGetInterfaces
		{
			get
			{
				if(r_GetInterfaces == null)
				{
					r_GetInterfaces = new(this, "GetInterfaces", 0);
					r_GetInterfaces.SetBelong(this.instance);
				}
				return r_GetInterfaces;
			}
		}

		/// <summary>
		/// System.Reflection.InterfaceMapping GetInterfaceMap(System.Type)
		/// </summary>
		protected RMethod r_GetInterfaceMap_Type;
		public virtual RMethod RGetInterfaceMap_Type
		{
			get
			{
				if(r_GetInterfaceMap_Type == null)
				{
					r_GetInterfaceMap_Type = new(this, "GetInterfaceMap", 0, typeof(System.Type));
					r_GetInterfaceMap_Type.SetBelong(this.instance);
				}
				return r_GetInterfaceMap_Type;
			}
		}

		/// <summary>
		/// Boolean IsInstanceOfType(System.Object)
		/// </summary>
		protected RMethod r_IsInstanceOfType_Object;
		public virtual RMethod RIsInstanceOfType_Object
		{
			get
			{
				if(r_IsInstanceOfType_Object == null)
				{
					r_IsInstanceOfType_Object = new(this, "IsInstanceOfType", 0, typeof(System.Object));
					r_IsInstanceOfType_Object.SetBelong(this.instance);
				}
				return r_IsInstanceOfType_Object;
			}
		}

		/// <summary>
		/// Boolean IsEquivalentTo(System.Type)
		/// </summary>
		protected RMethod r_IsEquivalentTo_Type;
		public virtual RMethod RIsEquivalentTo_Type
		{
			get
			{
				if(r_IsEquivalentTo_Type == null)
				{
					r_IsEquivalentTo_Type = new(this, "IsEquivalentTo", 0, typeof(System.Type));
					r_IsEquivalentTo_Type.SetBelong(this.instance);
				}
				return r_IsEquivalentTo_Type;
			}
		}

		/// <summary>
		/// System.Type GetEnumUnderlyingType()
		/// </summary>
		protected RMethod r_GetEnumUnderlyingType;
		public virtual RMethod RGetEnumUnderlyingType
		{
			get
			{
				if(r_GetEnumUnderlyingType == null)
				{
					r_GetEnumUnderlyingType = new(this, "GetEnumUnderlyingType", 0);
					r_GetEnumUnderlyingType.SetBelong(this.instance);
				}
				return r_GetEnumUnderlyingType;
			}
		}

		/// <summary>
		/// System.Array GetEnumValues()
		/// </summary>
		protected RMethod r_GetEnumValues;
		public virtual RMethod RGetEnumValues
		{
			get
			{
				if(r_GetEnumValues == null)
				{
					r_GetEnumValues = new(this, "GetEnumValues", 0);
					r_GetEnumValues.SetBelong(this.instance);
				}
				return r_GetEnumValues;
			}
		}

		/// <summary>
		/// System.Type MakeArrayType()
		/// </summary>
		protected RMethod r_MakeArrayType;
		public virtual RMethod RMakeArrayType
		{
			get
			{
				if(r_MakeArrayType == null)
				{
					r_MakeArrayType = new(this, "MakeArrayType", 0);
					r_MakeArrayType.SetBelong(this.instance);
				}
				return r_MakeArrayType;
			}
		}

		/// <summary>
		/// System.Type MakeArrayType(Int32)
		/// </summary>
		protected RMethod r_MakeArrayType_Int32;
		public virtual RMethod RMakeArrayType_Int32
		{
			get
			{
				if(r_MakeArrayType_Int32 == null)
				{
					r_MakeArrayType_Int32 = new(this, "MakeArrayType", 0, typeof(System.Int32));
					r_MakeArrayType_Int32.SetBelong(this.instance);
				}
				return r_MakeArrayType_Int32;
			}
		}

		/// <summary>
		/// System.Type MakeByRefType()
		/// </summary>
		protected RMethod r_MakeByRefType;
		public virtual RMethod RMakeByRefType
		{
			get
			{
				if(r_MakeByRefType == null)
				{
					r_MakeByRefType = new(this, "MakeByRefType", 0);
					r_MakeByRefType.SetBelong(this.instance);
				}
				return r_MakeByRefType;
			}
		}

		/// <summary>
		/// System.Type MakeGenericType(System.Type[])
		/// </summary>
		protected RMethod r_MakeGenericType_TypeArray;
		public virtual RMethod RMakeGenericType_TypeArray
		{
			get
			{
				if(r_MakeGenericType_TypeArray == null)
				{
					r_MakeGenericType_TypeArray = new(this, "MakeGenericType", 0, typeof(System.Type).MakeArrayType());
					r_MakeGenericType_TypeArray.SetBelong(this.instance);
				}
				return r_MakeGenericType_TypeArray;
			}
		}

		/// <summary>
		/// System.Type MakePointerType()
		/// </summary>
		protected RMethod r_MakePointerType;
		public virtual RMethod RMakePointerType
		{
			get
			{
				if(r_MakePointerType == null)
				{
					r_MakePointerType = new(this, "MakePointerType", 0);
					r_MakePointerType.SetBelong(this.instance);
				}
				return r_MakePointerType;
			}
		}

		/// <summary>
		/// System.Type MakeGenericSignatureType(System.Type, System.Type[])
		/// </summary>
		protected static RMethod r_MakeGenericSignatureType_Type_TypeArray;
		public static RMethod RMakeGenericSignatureType_Type_TypeArray
		{
			get
			{
				if(r_MakeGenericSignatureType_Type_TypeArray == null)
				{
					r_MakeGenericSignatureType_Type_TypeArray = new(typeof(System.Type), "MakeGenericSignatureType", 0, typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_MakeGenericSignatureType_Type_TypeArray.SetBelong(null);
				}
				return r_MakeGenericSignatureType_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Type MakeGenericMethodParameter(Int32)
		/// </summary>
		protected static RMethod r_MakeGenericMethodParameter_Int32;
		public static RMethod RMakeGenericMethodParameter_Int32
		{
			get
			{
				if(r_MakeGenericMethodParameter_Int32 == null)
				{
					r_MakeGenericMethodParameter_Int32 = new(typeof(System.Type), "MakeGenericMethodParameter", 0, typeof(System.Int32));
					r_MakeGenericMethodParameter_Int32.SetBelong(null);
				}
				return r_MakeGenericMethodParameter_Int32;
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
		/// Boolean Equals(System.Type)
		/// </summary>
		protected RMethod r_Equals_Type;
		public virtual RMethod REquals_Type
		{
			get
			{
				if(r_Equals_Type == null)
				{
					r_Equals_Type = new(this, "Equals", 0, typeof(System.Type));
					r_Equals_Type.SetBelong(this.instance);
				}
				return r_Equals_Type;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Type.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___Type__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___Type__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___Type__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___Type__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._Type.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___Type__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___Type__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Type.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._Type.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Type.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_System__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._Type.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_System__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Type.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___Type__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___Type__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___Type__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___Type__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._Type.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___Type__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___Type__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// System.Type InternalResolve()
		/// </summary>
		protected RMethod r_InternalResolve;
		public virtual RMethod RInternalResolve
		{
			get
			{
				if(r_InternalResolve == null)
				{
					r_InternalResolve = new(this, "InternalResolve", 0);
					r_InternalResolve.SetBelong(this.instance);
				}
				return r_InternalResolve;
			}
		}

		/// <summary>
		/// System.Type RuntimeResolve()
		/// </summary>
		protected RMethod r_RuntimeResolve;
		public virtual RMethod RRuntimeResolve
		{
			get
			{
				if(r_RuntimeResolve == null)
				{
					r_RuntimeResolve = new(this, "RuntimeResolve", 0);
					r_RuntimeResolve.SetBelong(this.instance);
				}
				return r_RuntimeResolve;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_GetMethod_MethodInfo;
		public virtual RMethod RGetMethod_MethodInfo
		{
			get
			{
				if(r_GetMethod_MethodInfo == null)
				{
					r_GetMethod_MethodInfo = new(this, "GetMethod", 0, typeof(System.Reflection.MethodInfo));
					r_GetMethod_MethodInfo.SetBelong(this.instance);
				}
				return r_GetMethod_MethodInfo;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructor(System.Reflection.ConstructorInfo)
		/// </summary>
		protected RMethod r_GetConstructor_ConstructorInfo;
		public virtual RMethod RGetConstructor_ConstructorInfo
		{
			get
			{
				if(r_GetConstructor_ConstructorInfo == null)
				{
					r_GetConstructor_ConstructorInfo = new(this, "GetConstructor", 0, typeof(System.Reflection.ConstructorInfo));
					r_GetConstructor_ConstructorInfo.SetBelong(this.instance);
				}
				return r_GetConstructor_ConstructorInfo;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetField(System.Reflection.FieldInfo)
		/// </summary>
		protected RMethod r_GetField_FieldInfo;
		public virtual RMethod RGetField_FieldInfo
		{
			get
			{
				if(r_GetField_FieldInfo == null)
				{
					r_GetField_FieldInfo = new(this, "GetField", 0, typeof(System.Reflection.FieldInfo));
					r_GetField_FieldInfo.SetBelong(this.instance);
				}
				return r_GetField_FieldInfo;
			}
		}

		/// <summary>
		/// System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
		/// </summary>
		protected static RMethod r_GetTypeFromHandle_RuntimeTypeHandle;
		public static RMethod RGetTypeFromHandle_RuntimeTypeHandle
		{
			get
			{
				if(r_GetTypeFromHandle_RuntimeTypeHandle == null)
				{
					r_GetTypeFromHandle_RuntimeTypeHandle = new(typeof(System.Type), "GetTypeFromHandle", 0, typeof(System.RuntimeTypeHandle));
					r_GetTypeFromHandle_RuntimeTypeHandle.SetBelong(null);
				}
				return r_GetTypeFromHandle_RuntimeTypeHandle;
			}
		}

		/// <summary>
		/// System.Type internal_from_handle(IntPtr)
		/// </summary>
		protected static RMethod r_internal_from_handle_IntPtr;
		public static RMethod Rinternal_from_handle_IntPtr
		{
			get
			{
				if(r_internal_from_handle_IntPtr == null)
				{
					r_internal_from_handle_IntPtr = new(typeof(System.Type), "internal_from_handle", 0, typeof(System.IntPtr));
					r_internal_from_handle_IntPtr.SetBelong(null);
				}
				return r_internal_from_handle_IntPtr;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle GetTypeHandleInternal()
		/// </summary>
		protected RMethod r_GetTypeHandleInternal;
		public virtual RMethod RGetTypeHandleInternal
		{
			get
			{
				if(r_GetTypeHandleInternal == null)
				{
					r_GetTypeHandleInternal = new(this, "GetTypeHandleInternal", 0);
					r_GetTypeHandleInternal.SetBelong(this.instance);
				}
				return r_GetTypeHandleInternal;
			}
		}

		/// <summary>
		/// Boolean IsWindowsRuntimeObjectImpl()
		/// </summary>
		protected RMethod r_IsWindowsRuntimeObjectImpl;
		public virtual RMethod RIsWindowsRuntimeObjectImpl
		{
			get
			{
				if(r_IsWindowsRuntimeObjectImpl == null)
				{
					r_IsWindowsRuntimeObjectImpl = new(this, "IsWindowsRuntimeObjectImpl", 0);
					r_IsWindowsRuntimeObjectImpl.SetBelong(this.instance);
				}
				return r_IsWindowsRuntimeObjectImpl;
			}
		}

		/// <summary>
		/// Boolean IsExportedToWindowsRuntimeImpl()
		/// </summary>
		protected RMethod r_IsExportedToWindowsRuntimeImpl;
		public virtual RMethod RIsExportedToWindowsRuntimeImpl
		{
			get
			{
				if(r_IsExportedToWindowsRuntimeImpl == null)
				{
					r_IsExportedToWindowsRuntimeImpl = new(this, "IsExportedToWindowsRuntimeImpl", 0);
					r_IsExportedToWindowsRuntimeImpl.SetBelong(this.instance);
				}
				return r_IsExportedToWindowsRuntimeImpl;
			}
		}

		/// <summary>
		/// Boolean HasProxyAttributeImpl()
		/// </summary>
		protected RMethod r_HasProxyAttributeImpl;
		public virtual RMethod RHasProxyAttributeImpl
		{
			get
			{
				if(r_HasProxyAttributeImpl == null)
				{
					r_HasProxyAttributeImpl = new(this, "HasProxyAttributeImpl", 0);
					r_HasProxyAttributeImpl.SetBelong(this.instance);
				}
				return r_HasProxyAttributeImpl;
			}
		}

		/// <summary>
		/// System.String FormatTypeName()
		/// </summary>
		protected RMethod r_FormatTypeName;
		public virtual RMethod RFormatTypeName
		{
			get
			{
				if(r_FormatTypeName == null)
				{
					r_FormatTypeName = new(this, "FormatTypeName", 0);
					r_FormatTypeName.SetBelong(this.instance);
				}
				return r_FormatTypeName;
			}
		}

		/// <summary>
		/// System.String FormatTypeName(Boolean)
		/// </summary>
		protected RMethod r_FormatTypeName_Boolean;
		public virtual RMethod RFormatTypeName_Boolean
		{
			get
			{
				if(r_FormatTypeName_Boolean == null)
				{
					r_FormatTypeName_Boolean = new(this, "FormatTypeName", 0, typeof(System.Boolean));
					r_FormatTypeName_Boolean.SetBelong(this.instance);
				}
				return r_FormatTypeName_Boolean;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_GetType_String_Boolean_Boolean;
		public static RMethod RGetType_String_Boolean_Boolean
		{
			get
			{
				if(r_GetType_String_Boolean_Boolean == null)
				{
					r_GetType_String_Boolean_Boolean = new(typeof(System.Type), "GetType", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
					r_GetType_String_Boolean_Boolean.SetBelong(null);
				}
				return r_GetType_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String, Boolean)
		/// </summary>
		protected static RMethod r_GetType_String_Boolean;
		public static RMethod RGetType_String_Boolean
		{
			get
			{
				if(r_GetType_String_Boolean == null)
				{
					r_GetType_String_Boolean = new(typeof(System.Type), "GetType", 0, typeof(System.String), typeof(System.Boolean));
					r_GetType_String_Boolean.SetBelong(null);
				}
				return r_GetType_String_Boolean;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String)
		/// </summary>
		protected static RMethod r_GetType_String;
		public static RMethod RGetType_String
		{
			get
			{
				if(r_GetType_String == null)
				{
					r_GetType_String = new(typeof(System.Type), "GetType", 0, typeof(System.String));
					r_GetType_String.SetBelong(null);
				}
				return r_GetType_String;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String, System.Func`2[System.Reflection.AssemblyName,System.Reflection.Assembly], System.Func`4[System.Reflection.Assembly,System.String,System.Boolean,System.Type])
		/// </summary>
		protected static RMethod r_GetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p_;
		public static RMethod RGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p_
		{
			get
			{
				if(r_GetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p_ == null)
				{
					r_GetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p_ = new(typeof(System.Type), "GetType", 0, typeof(System.String), typeof(System.Func<, >).MakeGenericType(typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Assembly)), typeof(System.Func<, , , >).MakeGenericType(typeof(System.Reflection.Assembly), typeof(System.String), typeof(System.Boolean), typeof(System.Type)));
					r_GetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p_.SetBelong(null);
				}
				return r_GetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p_;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String, System.Func`2[System.Reflection.AssemblyName,System.Reflection.Assembly], System.Func`4[System.Reflection.Assembly,System.String,System.Boolean,System.Type], Boolean)
		/// </summary>
		protected static RMethod r_GetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean;
		public static RMethod RGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean
		{
			get
			{
				if(r_GetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean == null)
				{
					r_GetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean = new(typeof(System.Type), "GetType", 0, typeof(System.String), typeof(System.Func<, >).MakeGenericType(typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Assembly)), typeof(System.Func<, , , >).MakeGenericType(typeof(System.Reflection.Assembly), typeof(System.String), typeof(System.Boolean), typeof(System.Type)), typeof(System.Boolean));
					r_GetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean.SetBelong(null);
				}
				return r_GetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String, System.Func`2[System.Reflection.AssemblyName,System.Reflection.Assembly], System.Func`4[System.Reflection.Assembly,System.String,System.Boolean,System.Type], Boolean, Boolean)
		/// </summary>
		protected static RMethod r_GetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean_Boolean;
		public static RMethod RGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean_Boolean
		{
			get
			{
				if(r_GetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean_Boolean == null)
				{
					r_GetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean_Boolean = new(typeof(System.Type), "GetType", 0, typeof(System.String), typeof(System.Func<, >).MakeGenericType(typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Assembly)), typeof(System.Func<, , , >).MakeGenericType(typeof(System.Reflection.Assembly), typeof(System.String), typeof(System.Boolean), typeof(System.Type)), typeof(System.Boolean), typeof(System.Boolean));
					r_GetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean_Boolean.SetBelong(null);
				}
				return r_GetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean_Boolean;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Type, System.Type)
		/// </summary>
		protected static RMethod r_op_Equality_Type_Type;
		public static RMethod Rop_Equality_Type_Type
		{
			get
			{
				if(r_op_Equality_Type_Type == null)
				{
					r_op_Equality_Type_Type = new(typeof(System.Type), "op_Equality", 0, typeof(System.Type), typeof(System.Type));
					r_op_Equality_Type_Type.SetBelong(null);
				}
				return r_op_Equality_Type_Type;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Type, System.Type)
		/// </summary>
		protected static RMethod r_op_Inequality_Type_Type;
		public static RMethod Rop_Inequality_Type_Type
		{
			get
			{
				if(r_op_Inequality_Type_Type == null)
				{
					r_op_Inequality_Type_Type = new(typeof(System.Type), "op_Inequality", 0, typeof(System.Type), typeof(System.Type));
					r_op_Inequality_Type_Type.SetBelong(null);
				}
				return r_op_Inequality_Type_Type;
			}
		}

		/// <summary>
		/// System.Type ReflectionOnlyGetType(System.String, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_ReflectionOnlyGetType_String_Boolean_Boolean;
		public static RMethod RReflectionOnlyGetType_String_Boolean_Boolean
		{
			get
			{
				if(r_ReflectionOnlyGetType_String_Boolean_Boolean == null)
				{
					r_ReflectionOnlyGetType_String_Boolean_Boolean = new(typeof(System.Type), "ReflectionOnlyGetType", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
					r_ReflectionOnlyGetType_String_Boolean_Boolean.SetBelong(null);
				}
				return r_ReflectionOnlyGetType_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Type GetTypeFromCLSID(System.Guid, System.String, Boolean)
		/// </summary>
		protected static RMethod r_GetTypeFromCLSID_Guid_String_Boolean;
		public static RMethod RGetTypeFromCLSID_Guid_String_Boolean
		{
			get
			{
				if(r_GetTypeFromCLSID_Guid_String_Boolean == null)
				{
					r_GetTypeFromCLSID_Guid_String_Boolean = new(typeof(System.Type), "GetTypeFromCLSID", 0, typeof(System.Guid), typeof(System.String), typeof(System.Boolean));
					r_GetTypeFromCLSID_Guid_String_Boolean.SetBelong(null);
				}
				return r_GetTypeFromCLSID_Guid_String_Boolean;
			}
		}

		/// <summary>
		/// System.Type GetTypeFromProgID(System.String, System.String, Boolean)
		/// </summary>
		protected static RMethod r_GetTypeFromProgID_String_String_Boolean;
		public static RMethod RGetTypeFromProgID_String_String_Boolean
		{
			get
			{
				if(r_GetTypeFromProgID_String_String_Boolean == null)
				{
					r_GetTypeFromProgID_String_String_Boolean = new(typeof(System.Type), "GetTypeFromProgID", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean));
					r_GetTypeFromProgID_String_String_Boolean.SetBelong(null);
				}
				return r_GetTypeFromProgID_String_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsRuntimeImplemented()
		/// </summary>
		protected RMethod r_IsRuntimeImplemented;
		public virtual RMethod RIsRuntimeImplemented
		{
			get
			{
				if(r_IsRuntimeImplemented == null)
				{
					r_IsRuntimeImplemented = new(this, "IsRuntimeImplemented", 0);
					r_IsRuntimeImplemented.SetBelong(this.instance);
				}
				return r_IsRuntimeImplemented;
			}
		}

		/// <summary>
		/// System.String InternalGetNameIfAvailable(System.Type ByRef)
		/// </summary>
		protected RMethod r_InternalGetNameIfAvailable_Ref_Type;
		public virtual RMethod RInternalGetNameIfAvailable_Ref_Type
		{
			get
			{
				if(r_InternalGetNameIfAvailable_Ref_Type == null)
				{
					r_InternalGetNameIfAvailable_Ref_Type = new(this, "InternalGetNameIfAvailable", 0, typeof(System.Type).MakeByRefType());
					r_InternalGetNameIfAvailable_Ref_Type.SetBelong(this.instance);
				}
				return r_InternalGetNameIfAvailable_Ref_Type;
			}
		}

		/// <summary>
		/// System.Reflection.Module get_Module()
		/// </summary>
		protected RMethod r_get_Module;
		public virtual RMethod Rget_Module
		{
			get
			{
				if(r_get_Module == null)
				{
					r_get_Module = new(this, "get_Module", 0);
					r_get_Module.SetBelong(this.instance);
				}
				return r_get_Module;
			}
		}

		/// <summary>
		/// Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_HasSameMetadataDefinitionAs_MemberInfo;
		public virtual RMethod RHasSameMetadataDefinitionAs_MemberInfo
		{
			get
			{
				if(r_HasSameMetadataDefinitionAs_MemberInfo == null)
				{
					r_HasSameMetadataDefinitionAs_MemberInfo = new(this, "HasSameMetadataDefinitionAs", 0, typeof(System.Reflection.MemberInfo));
					r_HasSameMetadataDefinitionAs_MemberInfo.SetBelong(this.instance);
				}
				return r_HasSameMetadataDefinitionAs_MemberInfo;
			}
		}

		/// <summary>
		/// Boolean IsDefined(System.Type, Boolean)
		/// </summary>
		protected RMethod r_IsDefined_Type_Boolean;
		public virtual RMethod RIsDefined_Type_Boolean
		{
			get
			{
				if(r_IsDefined_Type_Boolean == null)
				{
					r_IsDefined_Type_Boolean = new(this, "IsDefined", 0, typeof(System.Type), typeof(System.Boolean));
					r_IsDefined_Type_Boolean.SetBelong(this.instance);
				}
				return r_IsDefined_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(Boolean)
		/// </summary>
		protected RMethod r_GetCustomAttributes_Boolean;
		public virtual RMethod RGetCustomAttributes_Boolean
		{
			get
			{
				if(r_GetCustomAttributes_Boolean == null)
				{
					r_GetCustomAttributes_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Boolean));
					r_GetCustomAttributes_Boolean.SetBelong(this.instance);
				}
				return r_GetCustomAttributes_Boolean;
			}
		}

		/// <summary>
		/// System.Object[] GetCustomAttributes(System.Type, Boolean)
		/// </summary>
		protected RMethod r_GetCustomAttributes_Type_Boolean;
		public virtual RMethod RGetCustomAttributes_Type_Boolean
		{
			get
			{
				if(r_GetCustomAttributes_Type_Boolean == null)
				{
					r_GetCustomAttributes_Type_Boolean = new(this, "GetCustomAttributes", 0, typeof(System.Type), typeof(System.Boolean));
					r_GetCustomAttributes_Type_Boolean.SetBelong(this.instance);
				}
				return r_GetCustomAttributes_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Reflection.CustomAttributeData] GetCustomAttributesData()
		/// </summary>
		protected RMethod r_GetCustomAttributesData;
		public virtual RMethod RGetCustomAttributesData
		{
			get
			{
				if(r_GetCustomAttributesData == null)
				{
					r_GetCustomAttributesData = new(this, "GetCustomAttributesData", 0);
					r_GetCustomAttributesData.SetBelong(this.instance);
				}
				return r_GetCustomAttributesData;
			}
		}

		/// <summary>
		/// Boolean CacheEquals(System.Object)
		/// </summary>
		protected RMethod r_CacheEquals_Object;
		public virtual RMethod RCacheEquals_Object
		{
			get
			{
				if(r_CacheEquals_Object == null)
				{
					r_CacheEquals_Object = new(this, "CacheEquals", 0, typeof(System.Object));
					r_CacheEquals_Object.SetBelong(this.instance);
				}
				return r_CacheEquals_Object;
			}
		}

		/// <summary>
		/// Boolean HasSameMetadataDefinitionAsCore[TOther](System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_HasSameMetadataDefinitionAsCore_GTOther_MemberInfo;
		public virtual RMethod RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo
		{
			get
			{
				if(r_HasSameMetadataDefinitionAsCore_GTOther_MemberInfo == null)
				{
					r_HasSameMetadataDefinitionAsCore_GTOther_MemberInfo = new(this, "HasSameMetadataDefinitionAsCore", 1, typeof(System.Reflection.MemberInfo));
					r_HasSameMetadataDefinitionAsCore_GTOther_MemberInfo.SetBelong(this.instance);
				}
				return r_HasSameMetadataDefinitionAsCore_GTOther_MemberInfo;
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


        public RType() : base("System.Type")
        {
        }

        public RType(System.Object instance) : base("System.Type")
		{
            SetInstance(instance);
		}

        public RType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean IsEnumDefined(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RIsEnumDefined_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetEnumName(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RGetEnumName_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String[] GetEnumNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.Array GetEnumRawConstantValues()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumRawConstantValues.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public virtual void GetEnumData(out System.String[]  @enumNames, out System.Array  @enumValues)
        {
			enumNames = default;
			enumValues = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumNames, @enumValues};
            var ___result = RGetEnumData_Out_StringArray_Out_Array.Invoke(___genericsType, ___parameters);
			enumNames = (System.String[])___parameters[0];
			enumValues = (System.Array)___parameters[1];

            
        }


        public static System.Int32 BinarySearch(System.Array  @array, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @value};
            var ___result = RBinarySearch_Array_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean IsIntegerType(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RIsIntegerType_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Type GetRootElementType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRootElementType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type[] FindInterfaces(System.Reflection.TypeFilter  @filter, System.Object  @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filter, @filterCriteria};
            var ___result = RFindInterfaces_TypeFilter_Object.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.MemberInfo[] FindMembers(System.Reflection.MemberTypes  @memberType, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.MemberFilter  @filter, System.Object  @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@memberType, @bindingAttr, @filter, @filterCriteria};
            var ___result = RFindMembers_MemberTypes_BindingFlags_MemberFilter_Object.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Boolean IsSubclassOf(System.Type  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsSubclassOf_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsAssignableFrom(System.Type  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsAssignableFrom_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ImplementInterface(System.Type  @ifaceType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ifaceType};
            var ___result = RImplementInterface_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean FilterAttributeImpl(System.Reflection.MemberInfo  @m, System.Object  @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m, @filterCriteria};
            var ___result = RFilterAttributeImpl_MemberInfo_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean FilterNameImpl(System.Reflection.MemberInfo  @m, System.Object  @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m, @filterCriteria};
            var ___result = RFilterNameImpl_MemberInfo_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean FilterNameIgnoreCaseImpl(System.Reflection.MemberInfo  @m, System.Object  @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m, @filterCriteria};
            var ___result = RFilterNameIgnoreCaseImpl_MemberInfo_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Boolean IsArrayImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsArrayImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsByRefImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsByRefImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsPointerImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsPointerImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasElementTypeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasElementTypeImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Type GetElementType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetElementType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Int32 GetArrayRank()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetArrayRank.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Type GetGenericTypeDefinition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGenericTypeDefinition.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type[] GetGenericArguments()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGenericArguments.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type[] GetGenericParameterConstraints()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGenericParameterConstraints.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.TypeAttributes GetAttributeFlagsImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAttributeFlagsImpl.Invoke(___genericsType, ___parameters);

            return (System.Reflection.TypeAttributes)___result;
        }


        public virtual System.Boolean IsCOMObjectImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsCOMObjectImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsContextfulImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsContextfulImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsMarshalByRefImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsMarshalByRefImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsPrimitiveImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsPrimitiveImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsValueTypeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsValueTypeImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Reflection.ConstructorInfo GetConstructor(System.Type[]  @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@types};
            var ___result = RGetConstructor_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public virtual System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Type[]  @types, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @binder, @types, @modifiers};
            var ___result = RGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public virtual System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Reflection.CallingConventions  @callConvention, System.Type[]  @types, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public virtual System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Reflection.CallingConventions  @callConvention, System.Type[]  @types, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public virtual System.Reflection.ConstructorInfo[] GetConstructors()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetConstructors.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo[])___result;
        }


        public virtual System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RGetConstructors_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo[])___result;
        }


        public virtual System.Reflection.EventInfo GetEvent(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetEvent_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo)___result;
        }


        public virtual System.Reflection.EventInfo GetEvent(System.String  @name, System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RGetEvent_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo)___result;
        }


        public virtual System.Reflection.EventInfo[] GetEvents()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEvents.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo[])___result;
        }


        public virtual System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RGetEvents_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo[])___result;
        }


        public virtual System.Reflection.FieldInfo GetField(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetField_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.FieldInfo GetField(System.String  @name, System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RGetField_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.FieldInfo[] GetFields()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetFields.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo[])___result;
        }


        public virtual System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RGetFields_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetMember(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetMember_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetMember(System.String  @name, System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RGetMember_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetMember(System.String  @name, System.Reflection.MemberTypes  @type, System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @type, @bindingAttr};
            var ___result = RGetMember_String_MemberTypes_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetMembers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMembers.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RGetMembers_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetMethod_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String  @name, System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RGetMethod_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String  @name, System.Type[]  @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @types};
            var ___result = RGetMethod_String_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String  @name, System.Type[]  @types, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @types, @modifiers};
            var ___result = RGetMethod_String_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String  @name, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Type[]  @types, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @types, @modifiers};
            var ___result = RGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String  @name, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Reflection.CallingConventions  @callConvention, System.Type[]  @types, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethodImpl(System.String  @name, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Reflection.CallingConventions  @callConvention, System.Type[]  @types, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String  @name, System.Int32  @genericParameterCount, System.Type[]  @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @genericParameterCount, @types};
            var ___result = RGetMethod_String_Int32_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String  @name, System.Int32  @genericParameterCount, System.Type[]  @types, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @genericParameterCount, @types, @modifiers};
            var ___result = RGetMethod_String_Int32_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String  @name, System.Int32  @genericParameterCount, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Type[]  @types, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @genericParameterCount, @bindingAttr, @binder, @types, @modifiers};
            var ___result = RGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String  @name, System.Int32  @genericParameterCount, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Reflection.CallingConventions  @callConvention, System.Type[]  @types, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @genericParameterCount, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethodImpl(System.String  @name, System.Int32  @genericParameterCount, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Reflection.CallingConventions  @callConvention, System.Type[]  @types, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @genericParameterCount, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo[] GetMethods()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMethods.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RGetMethods_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Type GetNestedType(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetNestedType_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type GetNestedType(System.String  @name, System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RGetNestedType_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type[] GetNestedTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNestedTypes.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type[] GetNestedTypes(System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RGetNestedTypes_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetProperty_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String  @name, System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RGetProperty_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String  @name, System.Type  @returnType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @returnType};
            var ___result = RGetProperty_String_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String  @name, System.Type[]  @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @types};
            var ___result = RGetProperty_String_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String  @name, System.Type  @returnType, System.Type[]  @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @returnType, @types};
            var ___result = RGetProperty_String_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String  @name, System.Type  @returnType, System.Type[]  @types, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @returnType, @types, @modifiers};
            var ___result = RGetProperty_String_Type_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String  @name, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Type  @returnType, System.Type[]  @types, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @returnType, @types, @modifiers};
            var ___result = RGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetPropertyImpl(System.String  @name, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Type  @returnType, System.Type[]  @types, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @returnType, @types, @modifiers};
            var ___result = RGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo[] GetProperties()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetProperties.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo[])___result;
        }


        public virtual System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RGetProperties_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetDefaultMembers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDefaultMembers.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public static System.RuntimeTypeHandle GetTypeHandle(System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RGetTypeHandle_Object.Invoke(___genericsType, ___parameters);

            return (System.RuntimeTypeHandle)___result;
        }


        public static System.Type[] GetTypeArray(System.Object[]  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RGetTypeArray_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public static System.TypeCode GetTypeCode(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetTypeCode_Type.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
        }


        public virtual System.TypeCode GetTypeCodeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTypeCodeImpl.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
        }


        public static System.Type GetTypeFromCLSID(System.Guid  @clsid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clsid};
            var ___result = RGetTypeFromCLSID_Guid.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetTypeFromCLSID(System.Guid  @clsid, System.Boolean  @throwOnError)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clsid, @throwOnError};
            var ___result = RGetTypeFromCLSID_Guid_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetTypeFromCLSID(System.Guid  @clsid, System.String  @server)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clsid, @server};
            var ___result = RGetTypeFromCLSID_Guid_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetTypeFromProgID(System.String  @progID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@progID};
            var ___result = RGetTypeFromProgID_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetTypeFromProgID(System.String  @progID, System.Boolean  @throwOnError)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@progID, @throwOnError};
            var ___result = RGetTypeFromProgID_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetTypeFromProgID(System.String  @progID, System.String  @server)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@progID, @server};
            var ___result = RGetTypeFromProgID_String_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object InvokeMember(System.String  @name, System.Reflection.BindingFlags  @invokeAttr, System.Reflection.Binder  @binder, System.Object  @target, System.Object[]  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @invokeAttr, @binder, @target, @args};
            var ___result = RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object InvokeMember(System.String  @name, System.Reflection.BindingFlags  @invokeAttr, System.Reflection.Binder  @binder, System.Object  @target, System.Object[]  @args, System.Globalization.CultureInfo  @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @invokeAttr, @binder, @target, @args, @culture};
            var ___result = RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object InvokeMember(System.String  @name, System.Reflection.BindingFlags  @invokeAttr, System.Reflection.Binder  @binder, System.Object  @target, System.Object[]  @args, System.Reflection.ParameterModifier[]  @modifiers, System.Globalization.CultureInfo  @culture, System.String[]  @namedParameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @invokeAttr, @binder, @target, @args, @modifiers, @culture, @namedParameters};
            var ___result = RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Type GetInterface(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetInterface_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type GetInterface(System.String  @name, System.Boolean  @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ignoreCase};
            var ___result = RGetInterface_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type[] GetInterfaces()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInterfaces.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.InterfaceMapping GetInterfaceMap(System.Type  @interfaceType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@interfaceType};
            var ___result = RGetInterfaceMap_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.InterfaceMapping)___result;
        }


        public virtual System.Boolean IsInstanceOfType(System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RIsInstanceOfType_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsEquivalentTo(System.Type  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RIsEquivalentTo_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Type GetEnumUnderlyingType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumUnderlyingType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Array GetEnumValues()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumValues.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public virtual System.Type MakeArrayType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMakeArrayType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type MakeArrayType(System.Int32  @rank)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rank};
            var ___result = RMakeArrayType_Int32.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type MakeByRefType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMakeByRefType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type MakeGenericType(System.Type[]  @typeArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeArguments};
            var ___result = RMakeGenericType_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type MakePointerType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMakePointerType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type MakeGenericSignatureType(System.Type  @genericTypeDefinition, System.Type[]  @typeArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@genericTypeDefinition, @typeArguments};
            var ___result = RMakeGenericSignatureType_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type MakeGenericMethodParameter(System.Int32  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RMakeGenericMethodParameter_Int32.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Type  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = REquals_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void System__2__Runtime__2__InteropServices__2___Type__2__GetIDsOfNames(in System.Guid  @riid, System.IntPtr  @rgszNames, System.UInt32  @cNames, System.UInt32  @lcid, System.IntPtr  @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___Type__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfo(System.UInt32  @iTInfo, System.UInt32  @lcid, System.IntPtr  @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfoCount(out System.UInt32  @pcTInfo)
        {
			pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___Type__2__Invoke(System.UInt32  @dispIdMember, in System.Guid  @riid, System.UInt32  @lcid, System.Int16  @wFlags, System.IntPtr  @pDispParams, System.IntPtr  @pVarResult, System.IntPtr  @pExcepInfo, System.IntPtr  @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___Type__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type InternalResolve()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalResolve.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type RuntimeResolve()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRuntimeResolve.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.Reflection.MethodInfo  @fromNoninstanciated)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromNoninstanciated};
            var ___result = RGetMethod_MethodInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.ConstructorInfo GetConstructor(System.Reflection.ConstructorInfo  @fromNoninstanciated)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromNoninstanciated};
            var ___result = RGetConstructor_ConstructorInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public virtual System.Reflection.FieldInfo GetField(System.Reflection.FieldInfo  @fromNoninstanciated)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromNoninstanciated};
            var ___result = RGetField_FieldInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public static System.Type GetTypeFromHandle(System.RuntimeTypeHandle  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RGetTypeFromHandle_RuntimeTypeHandle.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type internal_from_handle(System.IntPtr  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = Rinternal_from_handle_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.RuntimeTypeHandle GetTypeHandleInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTypeHandleInternal.Invoke(___genericsType, ___parameters);

            return (System.RuntimeTypeHandle)___result;
        }


        public virtual System.Boolean IsWindowsRuntimeObjectImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsWindowsRuntimeObjectImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsExportedToWindowsRuntimeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsExportedToWindowsRuntimeImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasProxyAttributeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasProxyAttributeImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String FormatTypeName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFormatTypeName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String FormatTypeName(System.Boolean  @serialization)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serialization};
            var ___result = RFormatTypeName_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Type GetType(System.String  @typeName, System.Boolean  @throwOnError, System.Boolean  @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @throwOnError, @ignoreCase};
            var ___result = RGetType_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetType(System.String  @typeName, System.Boolean  @throwOnError)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @throwOnError};
            var ___result = RGetType_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetType(System.String  @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName};
            var ___result = RGetType_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetType(System.String  @typeName, System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly>  @assemblyResolver, System.Func<System.Reflection.Assembly, System.String, System.Boolean, System.Type>  @typeResolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @assemblyResolver, @typeResolver};
            var ___result = RGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p_.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetType(System.String  @typeName, System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly>  @assemblyResolver, System.Func<System.Reflection.Assembly, System.String, System.Boolean, System.Type>  @typeResolver, System.Boolean  @throwOnError)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @assemblyResolver, @typeResolver, @throwOnError};
            var ___result = RGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetType(System.String  @typeName, System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly>  @assemblyResolver, System.Func<System.Reflection.Assembly, System.String, System.Boolean, System.Type>  @typeResolver, System.Boolean  @throwOnError, System.Boolean  @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @assemblyResolver, @typeResolver, @throwOnError, @ignoreCase};
            var ___result = RGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Boolean op_Equality(System.Type  @left, System.Type  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_Type_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Type  @left, System.Type  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_Type_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Type ReflectionOnlyGetType(System.String  @typeName, System.Boolean  @throwIfNotFound, System.Boolean  @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @throwIfNotFound, @ignoreCase};
            var ___result = RReflectionOnlyGetType_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetTypeFromCLSID(System.Guid  @clsid, System.String  @server, System.Boolean  @throwOnError)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clsid, @server, @throwOnError};
            var ___result = RGetTypeFromCLSID_Guid_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetTypeFromProgID(System.String  @progID, System.String  @server, System.Boolean  @throwOnError)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@progID, @server, @throwOnError};
            var ___result = RGetTypeFromProgID_String_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Boolean IsRuntimeImplemented()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsRuntimeImplemented.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String InternalGetNameIfAvailable(ref System.Type  @rootCauseForFailure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rootCauseForFailure};
            var ___result = RInternalGetNameIfAvailable_Ref_Type.Invoke(___genericsType, ___parameters);
			rootCauseForFailure = (System.Type)___parameters[0];

            return (System.String)___result;
        }


        public virtual System.Reflection.Module get_Module()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rget_Module.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module)___result;
        }


        public virtual System.Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RHasSameMetadataDefinitionAs_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsDefined(System.Type  @attributeType, System.Boolean  @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IList<System.Reflection.CustomAttributeData>)___result;
        }


        public virtual System.Boolean CacheEquals(System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RCacheEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasSameMetadataDefinitionAsCore<TOther>(System.Reflection.MemberInfo  @other) where TOther : System.Reflection.MemberInfo
        {

            var ___genericsType = new Type[] {typeof(TOther)};
            var ___parameters = new object[]{@other};
            var ___result = RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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
