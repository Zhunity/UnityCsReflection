using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.GenericTypeParameterBuilder
	/// </summary>
    public partial class RGenericTypeParameterBuilder : RMember //
    {

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder tbuilder
		/// </summary>
		protected RSystem.RReflection.REmit.RTypeBuilder r_tbuilder;
		public virtual RSystem.RReflection.REmit.RTypeBuilder Rtbuilder
		{
			get
			{
				if(r_tbuilder == null)
				{
					r_tbuilder = new(this, "tbuilder");
					r_tbuilder.SetBelong(this.instance);
				}
				return r_tbuilder;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodBuilder mbuilder
		/// </summary>
		protected RSystem.RReflection.REmit.RMethodBuilder r_mbuilder;
		public virtual RSystem.RReflection.REmit.RMethodBuilder Rmbuilder
		{
			get
			{
				if(r_mbuilder == null)
				{
					r_mbuilder = new(this, "mbuilder");
					r_mbuilder.SetBelong(this.instance);
				}
				return r_mbuilder;
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
		/// System.Int32 index
		/// </summary>
		protected RField r_index;
		public virtual RField Rindex
		{
			get
			{
				if(r_index == null)
				{
					r_index = new(this, "index");
					r_index.SetBelong(this.instance);
				}
				return r_index;
			}
		}

		/// <summary>
		/// System.Type base_type
		/// </summary>
		protected RSystem.RType r_base_type;
		public virtual RSystem.RType Rbase_type
		{
			get
			{
				if(r_base_type == null)
				{
					r_base_type = new(this, "base_type");
					r_base_type.SetBelong(this.instance);
				}
				return r_base_type;
			}
		}

		/// <summary>
		/// System.Type[] iface_constraints
		/// </summary>
		protected RFieldArray<RSystem.RType> r_iface_constraints;
		public virtual RFieldArray<RSystem.RType> Riface_constraints
		{
			get
			{
				if(r_iface_constraints == null)
				{
					r_iface_constraints = new(this, "iface_constraints");
					r_iface_constraints.SetBelong(this.instance);
				}
				return r_iface_constraints;
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
		/// System.Reflection.GenericParameterAttributes attrs
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
		/// System.Type ReflectedType
		/// </summary>
		protected RSystem.RType r_ReflectedType;
		public virtual RSystem.RType ReflectedType
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
		/// System.Type[] GenericTypeParameters
		/// </summary>
		protected RPropertyArray<RSystem.RType> r_GenericTypeParameters;
		public virtual RPropertyArray<RSystem.RType> RGenericTypeParameters
		{
			get
			{
				if(r_GenericTypeParameters == null)
				{
					r_GenericTypeParameters = new(this, "GenericTypeParameters", -1);
					r_GenericTypeParameters.SetBelong(this.instance);
				}
				return r_GenericTypeParameters;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.ConstructorInfo] DeclaredConstructors
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RConstructorInfo> r_DeclaredConstructors;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RConstructorInfo> RDeclaredConstructors
		{
			get
			{
				if(r_DeclaredConstructors == null)
				{
					r_DeclaredConstructors = new(this, "DeclaredConstructors", -1);
					r_DeclaredConstructors.SetBelong(this.instance);
				}
				return r_DeclaredConstructors;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.EventInfo] DeclaredEvents
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.REventInfo> r_DeclaredEvents;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.REventInfo> RDeclaredEvents
		{
			get
			{
				if(r_DeclaredEvents == null)
				{
					r_DeclaredEvents = new(this, "DeclaredEvents", -1);
					r_DeclaredEvents.SetBelong(this.instance);
				}
				return r_DeclaredEvents;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.FieldInfo] DeclaredFields
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RFieldInfo> r_DeclaredFields;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RFieldInfo> RDeclaredFields
		{
			get
			{
				if(r_DeclaredFields == null)
				{
					r_DeclaredFields = new(this, "DeclaredFields", -1);
					r_DeclaredFields.SetBelong(this.instance);
				}
				return r_DeclaredFields;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.MemberInfo] DeclaredMembers
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RMemberInfo> r_DeclaredMembers;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RMemberInfo> RDeclaredMembers
		{
			get
			{
				if(r_DeclaredMembers == null)
				{
					r_DeclaredMembers = new(this, "DeclaredMembers", -1);
					r_DeclaredMembers.SetBelong(this.instance);
				}
				return r_DeclaredMembers;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.MethodInfo] DeclaredMethods
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RMethodInfo> r_DeclaredMethods;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RMethodInfo> RDeclaredMethods
		{
			get
			{
				if(r_DeclaredMethods == null)
				{
					r_DeclaredMethods = new(this, "DeclaredMethods", -1);
					r_DeclaredMethods.SetBelong(this.instance);
				}
				return r_DeclaredMethods;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.TypeInfo] DeclaredNestedTypes
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RTypeInfo> r_DeclaredNestedTypes;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RTypeInfo> RDeclaredNestedTypes
		{
			get
			{
				if(r_DeclaredNestedTypes == null)
				{
					r_DeclaredNestedTypes = new(this, "DeclaredNestedTypes", -1);
					r_DeclaredNestedTypes.SetBelong(this.instance);
				}
				return r_DeclaredNestedTypes;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.PropertyInfo] DeclaredProperties
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RPropertyInfo> r_DeclaredProperties;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RReflection.RPropertyInfo> RDeclaredProperties
		{
			get
			{
				if(r_DeclaredProperties == null)
				{
					r_DeclaredProperties = new(this, "DeclaredProperties", -1);
					r_DeclaredProperties.SetBelong(this.instance);
				}
				return r_DeclaredProperties;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Type] ImplementedInterfaces
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RType> r_ImplementedInterfaces;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RSystem.RType> RImplementedInterfaces
		{
			get
			{
				if(r_ImplementedInterfaces == null)
				{
					r_ImplementedInterfaces = new(this, "ImplementedInterfaces", -1);
					r_ImplementedInterfaces.SetBelong(this.instance);
				}
				return r_ImplementedInterfaces;
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
		/// Void SetBaseTypeConstraint(System.Type)
		/// </summary>
		protected RMethod r_RSetBaseTypeConstraint_Type;
		public virtual RMethod RSetBaseTypeConstraint_Type
		{
			get
			{
				if(r_RSetBaseTypeConstraint_Type == null)
				{
					r_RSetBaseTypeConstraint_Type = new(this, "SetBaseTypeConstraint", 0, typeof(System.Type));
					r_RSetBaseTypeConstraint_Type.SetBelong(this.instance);
				}
				return r_RSetBaseTypeConstraint_Type;
			}
		}

		/// <summary>
		/// Void SetInterfaceConstraints(System.Type[])
		/// </summary>
		protected RMethod r_RSetInterfaceConstraints_TypeArray;
		public virtual RMethod RSetInterfaceConstraints_TypeArray
		{
			get
			{
				if(r_RSetInterfaceConstraints_TypeArray == null)
				{
					r_RSetInterfaceConstraints_TypeArray = new(this, "SetInterfaceConstraints", 0, typeof(System.Type).MakeArrayType());
					r_RSetInterfaceConstraints_TypeArray.SetBelong(this.instance);
				}
				return r_RSetInterfaceConstraints_TypeArray;
			}
		}

		/// <summary>
		/// Void SetGenericParameterAttributes(System.Reflection.GenericParameterAttributes)
		/// </summary>
		protected RMethod r_RSetGenericParameterAttributes_GenericParameterAttributes;
		public virtual RMethod RSetGenericParameterAttributes_GenericParameterAttributes
		{
			get
			{
				if(r_RSetGenericParameterAttributes_GenericParameterAttributes == null)
				{
					r_RSetGenericParameterAttributes_GenericParameterAttributes = new(this, "SetGenericParameterAttributes", 0, typeof(System.Reflection.GenericParameterAttributes));
					r_RSetGenericParameterAttributes_GenericParameterAttributes.SetBelong(this.instance);
				}
				return r_RSetGenericParameterAttributes_GenericParameterAttributes;
			}
		}

		/// <summary>
		/// System.Type InternalResolve()
		/// </summary>
		protected RMethod r_RInternalResolve;
		public virtual RMethod RInternalResolve
		{
			get
			{
				if(r_RInternalResolve == null)
				{
					r_RInternalResolve = new(this, "InternalResolve", 0);
					r_RInternalResolve.SetBelong(this.instance);
				}
				return r_RInternalResolve;
			}
		}

		/// <summary>
		/// System.Type RuntimeResolve()
		/// </summary>
		protected RMethod r_RRuntimeResolve;
		public virtual RMethod RRuntimeResolve
		{
			get
			{
				if(r_RRuntimeResolve == null)
				{
					r_RRuntimeResolve = new(this, "RuntimeResolve", 0);
					r_RRuntimeResolve.SetBelong(this.instance);
				}
				return r_RRuntimeResolve;
			}
		}

		/// <summary>
		/// Boolean IsSubclassOf(System.Type)
		/// </summary>
		protected RMethod r_RIsSubclassOf_Type;
		public virtual RMethod RIsSubclassOf_Type
		{
			get
			{
				if(r_RIsSubclassOf_Type == null)
				{
					r_RIsSubclassOf_Type = new(this, "IsSubclassOf", 0, typeof(System.Type));
					r_RIsSubclassOf_Type.SetBelong(this.instance);
				}
				return r_RIsSubclassOf_Type;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes GetAttributeFlagsImpl()
		/// </summary>
		protected RMethod r_RGetAttributeFlagsImpl;
		public virtual RMethod RGetAttributeFlagsImpl
		{
			get
			{
				if(r_RGetAttributeFlagsImpl == null)
				{
					r_RGetAttributeFlagsImpl = new(this, "GetAttributeFlagsImpl", 0);
					r_RGetAttributeFlagsImpl.SetBelong(this.instance);
				}
				return r_RGetAttributeFlagsImpl;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_RGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_RGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_RGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetConstructorImpl", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_RGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_RGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_RGetConstructors_BindingFlags;
		public virtual RMethod RGetConstructors_BindingFlags
		{
			get
			{
				if(r_RGetConstructors_BindingFlags == null)
				{
					r_RGetConstructors_BindingFlags = new(this, "GetConstructors", 0, typeof(System.Reflection.BindingFlags));
					r_RGetConstructors_BindingFlags.SetBelong(this.instance);
				}
				return r_RGetConstructors_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo GetEvent(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_RGetEvent_String_BindingFlags;
		public virtual RMethod RGetEvent_String_BindingFlags
		{
			get
			{
				if(r_RGetEvent_String_BindingFlags == null)
				{
					r_RGetEvent_String_BindingFlags = new(this, "GetEvent", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_RGetEvent_String_BindingFlags.SetBelong(this.instance);
				}
				return r_RGetEvent_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo[] GetEvents()
		/// </summary>
		protected RMethod r_RGetEvents;
		public virtual RMethod RGetEvents
		{
			get
			{
				if(r_RGetEvents == null)
				{
					r_RGetEvents = new(this, "GetEvents", 0);
					r_RGetEvents.SetBelong(this.instance);
				}
				return r_RGetEvents;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_RGetEvents_BindingFlags;
		public virtual RMethod RGetEvents_BindingFlags
		{
			get
			{
				if(r_RGetEvents_BindingFlags == null)
				{
					r_RGetEvents_BindingFlags = new(this, "GetEvents", 0, typeof(System.Reflection.BindingFlags));
					r_RGetEvents_BindingFlags.SetBelong(this.instance);
				}
				return r_RGetEvents_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetField(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_RGetField_String_BindingFlags;
		public virtual RMethod RGetField_String_BindingFlags
		{
			get
			{
				if(r_RGetField_String_BindingFlags == null)
				{
					r_RGetField_String_BindingFlags = new(this, "GetField", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_RGetField_String_BindingFlags.SetBelong(this.instance);
				}
				return r_RGetField_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_RGetFields_BindingFlags;
		public virtual RMethod RGetFields_BindingFlags
		{
			get
			{
				if(r_RGetFields_BindingFlags == null)
				{
					r_RGetFields_BindingFlags = new(this, "GetFields", 0, typeof(System.Reflection.BindingFlags));
					r_RGetFields_BindingFlags.SetBelong(this.instance);
				}
				return r_RGetFields_BindingFlags;
			}
		}

		/// <summary>
		/// System.Type GetInterface(System.String, Boolean)
		/// </summary>
		protected RMethod r_RGetInterface_String_Boolean;
		public virtual RMethod RGetInterface_String_Boolean
		{
			get
			{
				if(r_RGetInterface_String_Boolean == null)
				{
					r_RGetInterface_String_Boolean = new(this, "GetInterface", 0, typeof(System.String), typeof(System.Boolean));
					r_RGetInterface_String_Boolean.SetBelong(this.instance);
				}
				return r_RGetInterface_String_Boolean;
			}
		}

		/// <summary>
		/// System.Type[] GetInterfaces()
		/// </summary>
		protected RMethod r_RGetInterfaces;
		public virtual RMethod RGetInterfaces
		{
			get
			{
				if(r_RGetInterfaces == null)
				{
					r_RGetInterfaces = new(this, "GetInterfaces", 0);
					r_RGetInterfaces.SetBelong(this.instance);
				}
				return r_RGetInterfaces;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_RGetMembers_BindingFlags;
		public virtual RMethod RGetMembers_BindingFlags
		{
			get
			{
				if(r_RGetMembers_BindingFlags == null)
				{
					r_RGetMembers_BindingFlags = new(this, "GetMembers", 0, typeof(System.Reflection.BindingFlags));
					r_RGetMembers_BindingFlags.SetBelong(this.instance);
				}
				return r_RGetMembers_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMember(System.String, System.Reflection.MemberTypes, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_RGetMember_String_MemberTypes_BindingFlags;
		public virtual RMethod RGetMember_String_MemberTypes_BindingFlags
		{
			get
			{
				if(r_RGetMember_String_MemberTypes_BindingFlags == null)
				{
					r_RGetMember_String_MemberTypes_BindingFlags = new(this, "GetMember", 0, typeof(System.String), typeof(System.Reflection.MemberTypes), typeof(System.Reflection.BindingFlags));
					r_RGetMember_String_MemberTypes_BindingFlags.SetBelong(this.instance);
				}
				return r_RGetMember_String_MemberTypes_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_RGetMethods_BindingFlags;
		public virtual RMethod RGetMethods_BindingFlags
		{
			get
			{
				if(r_RGetMethods_BindingFlags == null)
				{
					r_RGetMethods_BindingFlags = new(this, "GetMethods", 0, typeof(System.Reflection.BindingFlags));
					r_RGetMethods_BindingFlags.SetBelong(this.instance);
				}
				return r_RGetMethods_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethodImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_RGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_RGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_RGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethodImpl", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_RGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_RGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Type GetNestedType(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_RGetNestedType_String_BindingFlags;
		public virtual RMethod RGetNestedType_String_BindingFlags
		{
			get
			{
				if(r_RGetNestedType_String_BindingFlags == null)
				{
					r_RGetNestedType_String_BindingFlags = new(this, "GetNestedType", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_RGetNestedType_String_BindingFlags.SetBelong(this.instance);
				}
				return r_RGetNestedType_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Type[] GetNestedTypes(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_RGetNestedTypes_BindingFlags;
		public virtual RMethod RGetNestedTypes_BindingFlags
		{
			get
			{
				if(r_RGetNestedTypes_BindingFlags == null)
				{
					r_RGetNestedTypes_BindingFlags = new(this, "GetNestedTypes", 0, typeof(System.Reflection.BindingFlags));
					r_RGetNestedTypes_BindingFlags.SetBelong(this.instance);
				}
				return r_RGetNestedTypes_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_RGetProperties_BindingFlags;
		public virtual RMethod RGetProperties_BindingFlags
		{
			get
			{
				if(r_RGetProperties_BindingFlags == null)
				{
					r_RGetProperties_BindingFlags = new(this, "GetProperties", 0, typeof(System.Reflection.BindingFlags));
					r_RGetProperties_BindingFlags.SetBelong(this.instance);
				}
				return r_RGetProperties_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetPropertyImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_RGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_RGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray == null)
				{
					r_RGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray = new(this, "GetPropertyImpl", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_RGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_RGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// Boolean HasElementTypeImpl()
		/// </summary>
		protected RMethod r_RHasElementTypeImpl;
		public virtual RMethod RHasElementTypeImpl
		{
			get
			{
				if(r_RHasElementTypeImpl == null)
				{
					r_RHasElementTypeImpl = new(this, "HasElementTypeImpl", 0);
					r_RHasElementTypeImpl.SetBelong(this.instance);
				}
				return r_RHasElementTypeImpl;
			}
		}

		/// <summary>
		/// Boolean IsAssignableFrom(System.Type)
		/// </summary>
		protected RMethod r_RIsAssignableFrom_Type;
		public virtual RMethod RIsAssignableFrom_Type
		{
			get
			{
				if(r_RIsAssignableFrom_Type == null)
				{
					r_RIsAssignableFrom_Type = new(this, "IsAssignableFrom", 0, typeof(System.Type));
					r_RIsAssignableFrom_Type.SetBelong(this.instance);
				}
				return r_RIsAssignableFrom_Type;
			}
		}

		/// <summary>
		/// Boolean IsAssignableFrom(System.Reflection.TypeInfo)
		/// </summary>
		protected RMethod r_RIsAssignableFrom_TypeInfo;
		public virtual RMethod RIsAssignableFrom_TypeInfo
		{
			get
			{
				if(r_RIsAssignableFrom_TypeInfo == null)
				{
					r_RIsAssignableFrom_TypeInfo = new(this, "IsAssignableFrom", 0, typeof(System.Reflection.TypeInfo));
					r_RIsAssignableFrom_TypeInfo.SetBelong(this.instance);
				}
				return r_RIsAssignableFrom_TypeInfo;
			}
		}

		/// <summary>
		/// Boolean IsInstanceOfType(System.Object)
		/// </summary>
		protected RMethod r_RIsInstanceOfType_Object;
		public virtual RMethod RIsInstanceOfType_Object
		{
			get
			{
				if(r_RIsInstanceOfType_Object == null)
				{
					r_RIsInstanceOfType_Object = new(this, "IsInstanceOfType", 0, typeof(System.Object));
					r_RIsInstanceOfType_Object.SetBelong(this.instance);
				}
				return r_RIsInstanceOfType_Object;
			}
		}

		/// <summary>
		/// Boolean IsArrayImpl()
		/// </summary>
		protected RMethod r_RIsArrayImpl;
		public virtual RMethod RIsArrayImpl
		{
			get
			{
				if(r_RIsArrayImpl == null)
				{
					r_RIsArrayImpl = new(this, "IsArrayImpl", 0);
					r_RIsArrayImpl.SetBelong(this.instance);
				}
				return r_RIsArrayImpl;
			}
		}

		/// <summary>
		/// Boolean IsByRefImpl()
		/// </summary>
		protected RMethod r_RIsByRefImpl;
		public virtual RMethod RIsByRefImpl
		{
			get
			{
				if(r_RIsByRefImpl == null)
				{
					r_RIsByRefImpl = new(this, "IsByRefImpl", 0);
					r_RIsByRefImpl.SetBelong(this.instance);
				}
				return r_RIsByRefImpl;
			}
		}

		/// <summary>
		/// Boolean IsCOMObjectImpl()
		/// </summary>
		protected RMethod r_RIsCOMObjectImpl;
		public virtual RMethod RIsCOMObjectImpl
		{
			get
			{
				if(r_RIsCOMObjectImpl == null)
				{
					r_RIsCOMObjectImpl = new(this, "IsCOMObjectImpl", 0);
					r_RIsCOMObjectImpl.SetBelong(this.instance);
				}
				return r_RIsCOMObjectImpl;
			}
		}

		/// <summary>
		/// Boolean IsPointerImpl()
		/// </summary>
		protected RMethod r_RIsPointerImpl;
		public virtual RMethod RIsPointerImpl
		{
			get
			{
				if(r_RIsPointerImpl == null)
				{
					r_RIsPointerImpl = new(this, "IsPointerImpl", 0);
					r_RIsPointerImpl.SetBelong(this.instance);
				}
				return r_RIsPointerImpl;
			}
		}

		/// <summary>
		/// Boolean IsPrimitiveImpl()
		/// </summary>
		protected RMethod r_RIsPrimitiveImpl;
		public virtual RMethod RIsPrimitiveImpl
		{
			get
			{
				if(r_RIsPrimitiveImpl == null)
				{
					r_RIsPrimitiveImpl = new(this, "IsPrimitiveImpl", 0);
					r_RIsPrimitiveImpl.SetBelong(this.instance);
				}
				return r_RIsPrimitiveImpl;
			}
		}

		/// <summary>
		/// Boolean IsValueTypeImpl()
		/// </summary>
		protected RMethod r_RIsValueTypeImpl;
		public virtual RMethod RIsValueTypeImpl
		{
			get
			{
				if(r_RIsValueTypeImpl == null)
				{
					r_RIsValueTypeImpl = new(this, "IsValueTypeImpl", 0);
					r_RIsValueTypeImpl.SetBelong(this.instance);
				}
				return r_RIsValueTypeImpl;
			}
		}

		/// <summary>
		/// System.Object InvokeMember(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Object[], System.Reflection.ParameterModifier[], System.Globalization.CultureInfo, System.String[])
		/// </summary>
		protected RMethod r_RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray;
		public virtual RMethod RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray
		{
			get
			{
				if(r_RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray == null)
				{
					r_RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray = new(this, "InvokeMember", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object), typeof(System.Object).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.String).MakeArrayType());
					r_RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray.SetBelong(this.instance);
				}
				return r_RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray;
			}
		}

		/// <summary>
		/// System.Type GetElementType()
		/// </summary>
		protected RMethod r_RGetElementType;
		public virtual RMethod RGetElementType
		{
			get
			{
				if(r_RGetElementType == null)
				{
					r_RGetElementType = new(this, "GetElementType", 0);
					r_RGetElementType.SetBelong(this.instance);
				}
				return r_RGetElementType;
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
		/// System.Reflection.InterfaceMapping GetInterfaceMap(System.Type)
		/// </summary>
		protected RMethod r_RGetInterfaceMap_Type;
		public virtual RMethod RGetInterfaceMap_Type
		{
			get
			{
				if(r_RGetInterfaceMap_Type == null)
				{
					r_RGetInterfaceMap_Type = new(this, "GetInterfaceMap", 0, typeof(System.Type));
					r_RGetInterfaceMap_Type.SetBelong(this.instance);
				}
				return r_RGetInterfaceMap_Type;
			}
		}

		/// <summary>
		/// System.Type[] GetGenericArguments()
		/// </summary>
		protected RMethod r_RGetGenericArguments;
		public virtual RMethod RGetGenericArguments
		{
			get
			{
				if(r_RGetGenericArguments == null)
				{
					r_RGetGenericArguments = new(this, "GetGenericArguments", 0);
					r_RGetGenericArguments.SetBelong(this.instance);
				}
				return r_RGetGenericArguments;
			}
		}

		/// <summary>
		/// System.Type GetGenericTypeDefinition()
		/// </summary>
		protected RMethod r_RGetGenericTypeDefinition;
		public virtual RMethod RGetGenericTypeDefinition
		{
			get
			{
				if(r_RGetGenericTypeDefinition == null)
				{
					r_RGetGenericTypeDefinition = new(this, "GetGenericTypeDefinition", 0);
					r_RGetGenericTypeDefinition.SetBelong(this.instance);
				}
				return r_RGetGenericTypeDefinition;
			}
		}

		/// <summary>
		/// System.Type[] GetGenericParameterConstraints()
		/// </summary>
		protected RMethod r_RGetGenericParameterConstraints;
		public virtual RMethod RGetGenericParameterConstraints
		{
			get
			{
				if(r_RGetGenericParameterConstraints == null)
				{
					r_RGetGenericParameterConstraints = new(this, "GetGenericParameterConstraints", 0);
					r_RGetGenericParameterConstraints.SetBelong(this.instance);
				}
				return r_RGetGenericParameterConstraints;
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
		/// System.Exception not_supported()
		/// </summary>
		protected RMethod r_Rnot_supported;
		public virtual RMethod Rnot_supported
		{
			get
			{
				if(r_Rnot_supported == null)
				{
					r_Rnot_supported = new(this, "not_supported", 0);
					r_Rnot_supported.SetBelong(this.instance);
				}
				return r_Rnot_supported;
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
		/// System.Type MakeArrayType()
		/// </summary>
		protected RMethod r_RMakeArrayType;
		public virtual RMethod RMakeArrayType
		{
			get
			{
				if(r_RMakeArrayType == null)
				{
					r_RMakeArrayType = new(this, "MakeArrayType", 0);
					r_RMakeArrayType.SetBelong(this.instance);
				}
				return r_RMakeArrayType;
			}
		}

		/// <summary>
		/// System.Type MakeArrayType(Int32)
		/// </summary>
		protected RMethod r_RMakeArrayType_Int32;
		public virtual RMethod RMakeArrayType_Int32
		{
			get
			{
				if(r_RMakeArrayType_Int32 == null)
				{
					r_RMakeArrayType_Int32 = new(this, "MakeArrayType", 0, typeof(System.Int32));
					r_RMakeArrayType_Int32.SetBelong(this.instance);
				}
				return r_RMakeArrayType_Int32;
			}
		}

		/// <summary>
		/// System.Type MakeByRefType()
		/// </summary>
		protected RMethod r_RMakeByRefType;
		public virtual RMethod RMakeByRefType
		{
			get
			{
				if(r_RMakeByRefType == null)
				{
					r_RMakeByRefType = new(this, "MakeByRefType", 0);
					r_RMakeByRefType.SetBelong(this.instance);
				}
				return r_RMakeByRefType;
			}
		}

		/// <summary>
		/// System.Type MakeGenericType(System.Type[])
		/// </summary>
		protected RMethod r_RMakeGenericType_TypeArray;
		public virtual RMethod RMakeGenericType_TypeArray
		{
			get
			{
				if(r_RMakeGenericType_TypeArray == null)
				{
					r_RMakeGenericType_TypeArray = new(this, "MakeGenericType", 0, typeof(System.Type).MakeArrayType());
					r_RMakeGenericType_TypeArray.SetBelong(this.instance);
				}
				return r_RMakeGenericType_TypeArray;
			}
		}

		/// <summary>
		/// System.Type MakePointerType()
		/// </summary>
		protected RMethod r_RMakePointerType;
		public virtual RMethod RMakePointerType
		{
			get
			{
				if(r_RMakePointerType == null)
				{
					r_RMakePointerType = new(this, "MakePointerType", 0);
					r_RMakePointerType.SetBelong(this.instance);
				}
				return r_RMakePointerType;
			}
		}

		/// <summary>
		/// System.Type AsType()
		/// </summary>
		protected RMethod r_RAsType;
		public virtual RMethod RAsType
		{
			get
			{
				if(r_RAsType == null)
				{
					r_RAsType = new(this, "AsType", 0);
					r_RAsType.SetBelong(this.instance);
				}
				return r_RAsType;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo GetDeclaredEvent(System.String)
		/// </summary>
		protected RMethod r_RGetDeclaredEvent_String;
		public virtual RMethod RGetDeclaredEvent_String
		{
			get
			{
				if(r_RGetDeclaredEvent_String == null)
				{
					r_RGetDeclaredEvent_String = new(this, "GetDeclaredEvent", 0, typeof(System.String));
					r_RGetDeclaredEvent_String.SetBelong(this.instance);
				}
				return r_RGetDeclaredEvent_String;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetDeclaredField(System.String)
		/// </summary>
		protected RMethod r_RGetDeclaredField_String;
		public virtual RMethod RGetDeclaredField_String
		{
			get
			{
				if(r_RGetDeclaredField_String == null)
				{
					r_RGetDeclaredField_String = new(this, "GetDeclaredField", 0, typeof(System.String));
					r_RGetDeclaredField_String.SetBelong(this.instance);
				}
				return r_RGetDeclaredField_String;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetDeclaredMethod(System.String)
		/// </summary>
		protected RMethod r_RGetDeclaredMethod_String;
		public virtual RMethod RGetDeclaredMethod_String
		{
			get
			{
				if(r_RGetDeclaredMethod_String == null)
				{
					r_RGetDeclaredMethod_String = new(this, "GetDeclaredMethod", 0, typeof(System.String));
					r_RGetDeclaredMethod_String.SetBelong(this.instance);
				}
				return r_RGetDeclaredMethod_String;
			}
		}

		/// <summary>
		/// System.Reflection.TypeInfo GetDeclaredNestedType(System.String)
		/// </summary>
		protected RMethod r_RGetDeclaredNestedType_String;
		public virtual RMethod RGetDeclaredNestedType_String
		{
			get
			{
				if(r_RGetDeclaredNestedType_String == null)
				{
					r_RGetDeclaredNestedType_String = new(this, "GetDeclaredNestedType", 0, typeof(System.String));
					r_RGetDeclaredNestedType_String.SetBelong(this.instance);
				}
				return r_RGetDeclaredNestedType_String;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetDeclaredProperty(System.String)
		/// </summary>
		protected RMethod r_RGetDeclaredProperty_String;
		public virtual RMethod RGetDeclaredProperty_String
		{
			get
			{
				if(r_RGetDeclaredProperty_String == null)
				{
					r_RGetDeclaredProperty_String = new(this, "GetDeclaredProperty", 0, typeof(System.String));
					r_RGetDeclaredProperty_String.SetBelong(this.instance);
				}
				return r_RGetDeclaredProperty_String;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.Reflection.MethodInfo] GetDeclaredMethods(System.String)
		/// </summary>
		protected RMethod r_RGetDeclaredMethods_String;
		public virtual RMethod RGetDeclaredMethods_String
		{
			get
			{
				if(r_RGetDeclaredMethods_String == null)
				{
					r_RGetDeclaredMethods_String = new(this, "GetDeclaredMethods", 0, typeof(System.String));
					r_RGetDeclaredMethods_String.SetBelong(this.instance);
				}
				return r_RGetDeclaredMethods_String;
			}
		}

		/// <summary>
		/// Boolean IsEnumDefined(System.Object)
		/// </summary>
		protected RMethod r_RIsEnumDefined_Object;
		public virtual RMethod RIsEnumDefined_Object
		{
			get
			{
				if(r_RIsEnumDefined_Object == null)
				{
					r_RIsEnumDefined_Object = new(this, "IsEnumDefined", 0, typeof(System.Object));
					r_RIsEnumDefined_Object.SetBelong(this.instance);
				}
				return r_RIsEnumDefined_Object;
			}
		}

		/// <summary>
		/// System.String GetEnumName(System.Object)
		/// </summary>
		protected RMethod r_RGetEnumName_Object;
		public virtual RMethod RGetEnumName_Object
		{
			get
			{
				if(r_RGetEnumName_Object == null)
				{
					r_RGetEnumName_Object = new(this, "GetEnumName", 0, typeof(System.Object));
					r_RGetEnumName_Object.SetBelong(this.instance);
				}
				return r_RGetEnumName_Object;
			}
		}

		/// <summary>
		/// System.String[] GetEnumNames()
		/// </summary>
		protected RMethod r_RGetEnumNames;
		public virtual RMethod RGetEnumNames
		{
			get
			{
				if(r_RGetEnumNames == null)
				{
					r_RGetEnumNames = new(this, "GetEnumNames", 0);
					r_RGetEnumNames.SetBelong(this.instance);
				}
				return r_RGetEnumNames;
			}
		}

		/// <summary>
		/// System.Type GetRootElementType()
		/// </summary>
		protected RMethod r_RGetRootElementType;
		public virtual RMethod RGetRootElementType
		{
			get
			{
				if(r_RGetRootElementType == null)
				{
					r_RGetRootElementType = new(this, "GetRootElementType", 0);
					r_RGetRootElementType.SetBelong(this.instance);
				}
				return r_RGetRootElementType;
			}
		}

		/// <summary>
		/// System.Type[] FindInterfaces(System.Reflection.TypeFilter, System.Object)
		/// </summary>
		protected RMethod r_RFindInterfaces_TypeFilter_Object;
		public virtual RMethod RFindInterfaces_TypeFilter_Object
		{
			get
			{
				if(r_RFindInterfaces_TypeFilter_Object == null)
				{
					r_RFindInterfaces_TypeFilter_Object = new(this, "FindInterfaces", 0, typeof(System.Reflection.TypeFilter), typeof(System.Object));
					r_RFindInterfaces_TypeFilter_Object.SetBelong(this.instance);
				}
				return r_RFindInterfaces_TypeFilter_Object;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] FindMembers(System.Reflection.MemberTypes, System.Reflection.BindingFlags, System.Reflection.MemberFilter, System.Object)
		/// </summary>
		protected RMethod r_RFindMembers_MemberTypes_BindingFlags_MemberFilter_Object;
		public virtual RMethod RFindMembers_MemberTypes_BindingFlags_MemberFilter_Object
		{
			get
			{
				if(r_RFindMembers_MemberTypes_BindingFlags_MemberFilter_Object == null)
				{
					r_RFindMembers_MemberTypes_BindingFlags_MemberFilter_Object = new(this, "FindMembers", 0, typeof(System.Reflection.MemberTypes), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.MemberFilter), typeof(System.Object));
					r_RFindMembers_MemberTypes_BindingFlags_MemberFilter_Object.SetBelong(this.instance);
				}
				return r_RFindMembers_MemberTypes_BindingFlags_MemberFilter_Object;
			}
		}

		/// <summary>
		/// Boolean ImplementInterface(System.Type)
		/// </summary>
		protected RMethod r_RImplementInterface_Type;
		public virtual RMethod RImplementInterface_Type
		{
			get
			{
				if(r_RImplementInterface_Type == null)
				{
					r_RImplementInterface_Type = new(this, "ImplementInterface", 0, typeof(System.Type));
					r_RImplementInterface_Type.SetBelong(this.instance);
				}
				return r_RImplementInterface_Type;
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
		/// Int32 GetArrayRank()
		/// </summary>
		protected RMethod r_RGetArrayRank;
		public virtual RMethod RGetArrayRank
		{
			get
			{
				if(r_RGetArrayRank == null)
				{
					r_RGetArrayRank = new(this, "GetArrayRank", 0);
					r_RGetArrayRank.SetBelong(this.instance);
				}
				return r_RGetArrayRank;
			}
		}

		/// <summary>
		/// Boolean IsContextfulImpl()
		/// </summary>
		protected RMethod r_RIsContextfulImpl;
		public virtual RMethod RIsContextfulImpl
		{
			get
			{
				if(r_RIsContextfulImpl == null)
				{
					r_RIsContextfulImpl = new(this, "IsContextfulImpl", 0);
					r_RIsContextfulImpl.SetBelong(this.instance);
				}
				return r_RIsContextfulImpl;
			}
		}

		/// <summary>
		/// Boolean IsMarshalByRefImpl()
		/// </summary>
		protected RMethod r_RIsMarshalByRefImpl;
		public virtual RMethod RIsMarshalByRefImpl
		{
			get
			{
				if(r_RIsMarshalByRefImpl == null)
				{
					r_RIsMarshalByRefImpl = new(this, "IsMarshalByRefImpl", 0);
					r_RIsMarshalByRefImpl.SetBelong(this.instance);
				}
				return r_RIsMarshalByRefImpl;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructor(System.Type[])
		/// </summary>
		protected RMethod r_RGetConstructor_TypeArray;
		public virtual RMethod RGetConstructor_TypeArray
		{
			get
			{
				if(r_RGetConstructor_TypeArray == null)
				{
					r_RGetConstructor_TypeArray = new(this, "GetConstructor", 0, typeof(System.Type).MakeArrayType());
					r_RGetConstructor_TypeArray.SetBelong(this.instance);
				}
				return r_RGetConstructor_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags, System.Reflection.Binder, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_RGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_RGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray == null)
				{
					r_RGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray = new(this, "GetConstructor", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_RGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_RGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_RGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_RGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_RGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetConstructor", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_RGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_RGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo[] GetConstructors()
		/// </summary>
		protected RMethod r_RGetConstructors;
		public virtual RMethod RGetConstructors
		{
			get
			{
				if(r_RGetConstructors == null)
				{
					r_RGetConstructors = new(this, "GetConstructors", 0);
					r_RGetConstructors.SetBelong(this.instance);
				}
				return r_RGetConstructors;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo GetEvent(System.String)
		/// </summary>
		protected RMethod r_RGetEvent_String;
		public virtual RMethod RGetEvent_String
		{
			get
			{
				if(r_RGetEvent_String == null)
				{
					r_RGetEvent_String = new(this, "GetEvent", 0, typeof(System.String));
					r_RGetEvent_String.SetBelong(this.instance);
				}
				return r_RGetEvent_String;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetField(System.String)
		/// </summary>
		protected RMethod r_RGetField_String;
		public virtual RMethod RGetField_String
		{
			get
			{
				if(r_RGetField_String == null)
				{
					r_RGetField_String = new(this, "GetField", 0, typeof(System.String));
					r_RGetField_String.SetBelong(this.instance);
				}
				return r_RGetField_String;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo[] GetFields()
		/// </summary>
		protected RMethod r_RGetFields;
		public virtual RMethod RGetFields
		{
			get
			{
				if(r_RGetFields == null)
				{
					r_RGetFields = new(this, "GetFields", 0);
					r_RGetFields.SetBelong(this.instance);
				}
				return r_RGetFields;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMember(System.String)
		/// </summary>
		protected RMethod r_RGetMember_String;
		public virtual RMethod RGetMember_String
		{
			get
			{
				if(r_RGetMember_String == null)
				{
					r_RGetMember_String = new(this, "GetMember", 0, typeof(System.String));
					r_RGetMember_String.SetBelong(this.instance);
				}
				return r_RGetMember_String;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMember(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_RGetMember_String_BindingFlags;
		public virtual RMethod RGetMember_String_BindingFlags
		{
			get
			{
				if(r_RGetMember_String_BindingFlags == null)
				{
					r_RGetMember_String_BindingFlags = new(this, "GetMember", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_RGetMember_String_BindingFlags.SetBelong(this.instance);
				}
				return r_RGetMember_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMembers()
		/// </summary>
		protected RMethod r_RGetMembers;
		public virtual RMethod RGetMembers
		{
			get
			{
				if(r_RGetMembers == null)
				{
					r_RGetMembers = new(this, "GetMembers", 0);
					r_RGetMembers.SetBelong(this.instance);
				}
				return r_RGetMembers;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String)
		/// </summary>
		protected RMethod r_RGetMethod_String;
		public virtual RMethod RGetMethod_String
		{
			get
			{
				if(r_RGetMethod_String == null)
				{
					r_RGetMethod_String = new(this, "GetMethod", 0, typeof(System.String));
					r_RGetMethod_String.SetBelong(this.instance);
				}
				return r_RGetMethod_String;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_RGetMethod_String_BindingFlags;
		public virtual RMethod RGetMethod_String_BindingFlags
		{
			get
			{
				if(r_RGetMethod_String_BindingFlags == null)
				{
					r_RGetMethod_String_BindingFlags = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_RGetMethod_String_BindingFlags.SetBelong(this.instance);
				}
				return r_RGetMethod_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Type[])
		/// </summary>
		protected RMethod r_RGetMethod_String_TypeArray;
		public virtual RMethod RGetMethod_String_TypeArray
		{
			get
			{
				if(r_RGetMethod_String_TypeArray == null)
				{
					r_RGetMethod_String_TypeArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Type).MakeArrayType());
					r_RGetMethod_String_TypeArray.SetBelong(this.instance);
				}
				return r_RGetMethod_String_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_RGetMethod_String_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethod_String_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_RGetMethod_String_TypeArray_ParameterModifierArray == null)
				{
					r_RGetMethod_String_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_RGetMethod_String_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_RGetMethod_String_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_RGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_RGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray == null)
				{
					r_RGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_RGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_RGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_RGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_RGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_RGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_RGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_RGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, Int32, System.Type[])
		/// </summary>
		protected RMethod r_RGetMethod_String_Int32_TypeArray;
		public virtual RMethod RGetMethod_String_Int32_TypeArray
		{
			get
			{
				if(r_RGetMethod_String_Int32_TypeArray == null)
				{
					r_RGetMethod_String_Int32_TypeArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Int32), typeof(System.Type).MakeArrayType());
					r_RGetMethod_String_Int32_TypeArray.SetBelong(this.instance);
				}
				return r_RGetMethod_String_Int32_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, Int32, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_RGetMethod_String_Int32_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethod_String_Int32_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_RGetMethod_String_Int32_TypeArray_ParameterModifierArray == null)
				{
					r_RGetMethod_String_Int32_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_RGetMethod_String_Int32_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_RGetMethod_String_Int32_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_RGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_RGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray == null)
				{
					r_RGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_RGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_RGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_RGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_RGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_RGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_RGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_RGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethodImpl(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_RGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_RGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_RGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethodImpl", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_RGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_RGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetMethods()
		/// </summary>
		protected RMethod r_RGetMethods;
		public virtual RMethod RGetMethods
		{
			get
			{
				if(r_RGetMethods == null)
				{
					r_RGetMethods = new(this, "GetMethods", 0);
					r_RGetMethods.SetBelong(this.instance);
				}
				return r_RGetMethods;
			}
		}

		/// <summary>
		/// System.Type GetNestedType(System.String)
		/// </summary>
		protected RMethod r_RGetNestedType_String;
		public virtual RMethod RGetNestedType_String
		{
			get
			{
				if(r_RGetNestedType_String == null)
				{
					r_RGetNestedType_String = new(this, "GetNestedType", 0, typeof(System.String));
					r_RGetNestedType_String.SetBelong(this.instance);
				}
				return r_RGetNestedType_String;
			}
		}

		/// <summary>
		/// System.Type[] GetNestedTypes()
		/// </summary>
		protected RMethod r_RGetNestedTypes;
		public virtual RMethod RGetNestedTypes
		{
			get
			{
				if(r_RGetNestedTypes == null)
				{
					r_RGetNestedTypes = new(this, "GetNestedTypes", 0);
					r_RGetNestedTypes.SetBelong(this.instance);
				}
				return r_RGetNestedTypes;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String)
		/// </summary>
		protected RMethod r_RGetProperty_String;
		public virtual RMethod RGetProperty_String
		{
			get
			{
				if(r_RGetProperty_String == null)
				{
					r_RGetProperty_String = new(this, "GetProperty", 0, typeof(System.String));
					r_RGetProperty_String.SetBelong(this.instance);
				}
				return r_RGetProperty_String;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_RGetProperty_String_BindingFlags;
		public virtual RMethod RGetProperty_String_BindingFlags
		{
			get
			{
				if(r_RGetProperty_String_BindingFlags == null)
				{
					r_RGetProperty_String_BindingFlags = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
					r_RGetProperty_String_BindingFlags.SetBelong(this.instance);
				}
				return r_RGetProperty_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type)
		/// </summary>
		protected RMethod r_RGetProperty_String_Type;
		public virtual RMethod RGetProperty_String_Type
		{
			get
			{
				if(r_RGetProperty_String_Type == null)
				{
					r_RGetProperty_String_Type = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Type));
					r_RGetProperty_String_Type.SetBelong(this.instance);
				}
				return r_RGetProperty_String_Type;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type[])
		/// </summary>
		protected RMethod r_RGetProperty_String_TypeArray;
		public virtual RMethod RGetProperty_String_TypeArray
		{
			get
			{
				if(r_RGetProperty_String_TypeArray == null)
				{
					r_RGetProperty_String_TypeArray = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Type).MakeArrayType());
					r_RGetProperty_String_TypeArray.SetBelong(this.instance);
				}
				return r_RGetProperty_String_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_RGetProperty_String_Type_TypeArray;
		public virtual RMethod RGetProperty_String_Type_TypeArray
		{
			get
			{
				if(r_RGetProperty_String_Type_TypeArray == null)
				{
					r_RGetProperty_String_Type_TypeArray = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_RGetProperty_String_Type_TypeArray.SetBelong(this.instance);
				}
				return r_RGetProperty_String_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_RGetProperty_String_Type_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetProperty_String_Type_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_RGetProperty_String_Type_TypeArray_ParameterModifierArray == null)
				{
					r_RGetProperty_String_Type_TypeArray_ParameterModifierArray = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_RGetProperty_String_Type_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_RGetProperty_String_Type_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_RGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray;
		public virtual RMethod RGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_RGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray == null)
				{
					r_RGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
					r_RGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray.SetBelong(this.instance);
				}
				return r_RGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo[] GetProperties()
		/// </summary>
		protected RMethod r_RGetProperties;
		public virtual RMethod RGetProperties
		{
			get
			{
				if(r_RGetProperties == null)
				{
					r_RGetProperties = new(this, "GetProperties", 0);
					r_RGetProperties.SetBelong(this.instance);
				}
				return r_RGetProperties;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetDefaultMembers()
		/// </summary>
		protected RMethod r_RGetDefaultMembers;
		public virtual RMethod RGetDefaultMembers
		{
			get
			{
				if(r_RGetDefaultMembers == null)
				{
					r_RGetDefaultMembers = new(this, "GetDefaultMembers", 0);
					r_RGetDefaultMembers.SetBelong(this.instance);
				}
				return r_RGetDefaultMembers;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCodeImpl()
		/// </summary>
		protected RMethod r_RGetTypeCodeImpl;
		public virtual RMethod RGetTypeCodeImpl
		{
			get
			{
				if(r_RGetTypeCodeImpl == null)
				{
					r_RGetTypeCodeImpl = new(this, "GetTypeCodeImpl", 0);
					r_RGetTypeCodeImpl.SetBelong(this.instance);
				}
				return r_RGetTypeCodeImpl;
			}
		}

		/// <summary>
		/// System.Object InvokeMember(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Object[])
		/// </summary>
		protected RMethod r_RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray;
		public virtual RMethod RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray
		{
			get
			{
				if(r_RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray == null)
				{
					r_RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray = new(this, "InvokeMember", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object), typeof(System.Object).MakeArrayType());
					r_RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray.SetBelong(this.instance);
				}
				return r_RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object InvokeMember(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo;
		public virtual RMethod RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo
		{
			get
			{
				if(r_RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo == null)
				{
					r_RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo = new(this, "InvokeMember", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
					r_RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo.SetBelong(this.instance);
				}
				return r_RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo;
			}
		}

		/// <summary>
		/// System.Type GetInterface(System.String)
		/// </summary>
		protected RMethod r_RGetInterface_String;
		public virtual RMethod RGetInterface_String
		{
			get
			{
				if(r_RGetInterface_String == null)
				{
					r_RGetInterface_String = new(this, "GetInterface", 0, typeof(System.String));
					r_RGetInterface_String.SetBelong(this.instance);
				}
				return r_RGetInterface_String;
			}
		}

		/// <summary>
		/// Boolean IsEquivalentTo(System.Type)
		/// </summary>
		protected RMethod r_RIsEquivalentTo_Type;
		public virtual RMethod RIsEquivalentTo_Type
		{
			get
			{
				if(r_RIsEquivalentTo_Type == null)
				{
					r_RIsEquivalentTo_Type = new(this, "IsEquivalentTo", 0, typeof(System.Type));
					r_RIsEquivalentTo_Type.SetBelong(this.instance);
				}
				return r_RIsEquivalentTo_Type;
			}
		}

		/// <summary>
		/// System.Type GetEnumUnderlyingType()
		/// </summary>
		protected RMethod r_RGetEnumUnderlyingType;
		public virtual RMethod RGetEnumUnderlyingType
		{
			get
			{
				if(r_RGetEnumUnderlyingType == null)
				{
					r_RGetEnumUnderlyingType = new(this, "GetEnumUnderlyingType", 0);
					r_RGetEnumUnderlyingType.SetBelong(this.instance);
				}
				return r_RGetEnumUnderlyingType;
			}
		}

		/// <summary>
		/// System.Array GetEnumValues()
		/// </summary>
		protected RMethod r_RGetEnumValues;
		public virtual RMethod RGetEnumValues
		{
			get
			{
				if(r_RGetEnumValues == null)
				{
					r_RGetEnumValues = new(this, "GetEnumValues", 0);
					r_RGetEnumValues.SetBelong(this.instance);
				}
				return r_RGetEnumValues;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Type)
		/// </summary>
		protected RMethod r_REquals_Type;
		public virtual RMethod REquals_Type
		{
			get
			{
				if(r_REquals_Type == null)
				{
					r_REquals_Type = new(this, "Equals", 0, typeof(System.Type));
					r_REquals_Type.SetBelong(this.instance);
				}
				return r_REquals_Type;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_RGetMethod_MethodInfo;
		public virtual RMethod RGetMethod_MethodInfo
		{
			get
			{
				if(r_RGetMethod_MethodInfo == null)
				{
					r_RGetMethod_MethodInfo = new(this, "GetMethod", 0, typeof(System.Reflection.MethodInfo));
					r_RGetMethod_MethodInfo.SetBelong(this.instance);
				}
				return r_RGetMethod_MethodInfo;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructor(System.Reflection.ConstructorInfo)
		/// </summary>
		protected RMethod r_RGetConstructor_ConstructorInfo;
		public virtual RMethod RGetConstructor_ConstructorInfo
		{
			get
			{
				if(r_RGetConstructor_ConstructorInfo == null)
				{
					r_RGetConstructor_ConstructorInfo = new(this, "GetConstructor", 0, typeof(System.Reflection.ConstructorInfo));
					r_RGetConstructor_ConstructorInfo.SetBelong(this.instance);
				}
				return r_RGetConstructor_ConstructorInfo;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetField(System.Reflection.FieldInfo)
		/// </summary>
		protected RMethod r_RGetField_FieldInfo;
		public virtual RMethod RGetField_FieldInfo
		{
			get
			{
				if(r_RGetField_FieldInfo == null)
				{
					r_RGetField_FieldInfo = new(this, "GetField", 0, typeof(System.Reflection.FieldInfo));
					r_RGetField_FieldInfo.SetBelong(this.instance);
				}
				return r_RGetField_FieldInfo;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle GetTypeHandleInternal()
		/// </summary>
		protected RMethod r_RGetTypeHandleInternal;
		public virtual RMethod RGetTypeHandleInternal
		{
			get
			{
				if(r_RGetTypeHandleInternal == null)
				{
					r_RGetTypeHandleInternal = new(this, "GetTypeHandleInternal", 0);
					r_RGetTypeHandleInternal.SetBelong(this.instance);
				}
				return r_RGetTypeHandleInternal;
			}
		}

		/// <summary>
		/// Boolean IsWindowsRuntimeObjectImpl()
		/// </summary>
		protected RMethod r_RIsWindowsRuntimeObjectImpl;
		public virtual RMethod RIsWindowsRuntimeObjectImpl
		{
			get
			{
				if(r_RIsWindowsRuntimeObjectImpl == null)
				{
					r_RIsWindowsRuntimeObjectImpl = new(this, "IsWindowsRuntimeObjectImpl", 0);
					r_RIsWindowsRuntimeObjectImpl.SetBelong(this.instance);
				}
				return r_RIsWindowsRuntimeObjectImpl;
			}
		}

		/// <summary>
		/// Boolean IsExportedToWindowsRuntimeImpl()
		/// </summary>
		protected RMethod r_RIsExportedToWindowsRuntimeImpl;
		public virtual RMethod RIsExportedToWindowsRuntimeImpl
		{
			get
			{
				if(r_RIsExportedToWindowsRuntimeImpl == null)
				{
					r_RIsExportedToWindowsRuntimeImpl = new(this, "IsExportedToWindowsRuntimeImpl", 0);
					r_RIsExportedToWindowsRuntimeImpl.SetBelong(this.instance);
				}
				return r_RIsExportedToWindowsRuntimeImpl;
			}
		}

		/// <summary>
		/// Boolean HasProxyAttributeImpl()
		/// </summary>
		protected RMethod r_RHasProxyAttributeImpl;
		public virtual RMethod RHasProxyAttributeImpl
		{
			get
			{
				if(r_RHasProxyAttributeImpl == null)
				{
					r_RHasProxyAttributeImpl = new(this, "HasProxyAttributeImpl", 0);
					r_RHasProxyAttributeImpl.SetBelong(this.instance);
				}
				return r_RHasProxyAttributeImpl;
			}
		}

		/// <summary>
		/// System.String FormatTypeName()
		/// </summary>
		protected RMethod r_RFormatTypeName;
		public virtual RMethod RFormatTypeName
		{
			get
			{
				if(r_RFormatTypeName == null)
				{
					r_RFormatTypeName = new(this, "FormatTypeName", 0);
					r_RFormatTypeName.SetBelong(this.instance);
				}
				return r_RFormatTypeName;
			}
		}

		/// <summary>
		/// System.String FormatTypeName(Boolean)
		/// </summary>
		protected RMethod r_RFormatTypeName_Boolean;
		public virtual RMethod RFormatTypeName_Boolean
		{
			get
			{
				if(r_RFormatTypeName_Boolean == null)
				{
					r_RFormatTypeName_Boolean = new(this, "FormatTypeName", 0, typeof(System.Boolean));
					r_RFormatTypeName_Boolean.SetBelong(this.instance);
				}
				return r_RFormatTypeName_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsRuntimeImplemented()
		/// </summary>
		protected RMethod r_RIsRuntimeImplemented;
		public virtual RMethod RIsRuntimeImplemented
		{
			get
			{
				if(r_RIsRuntimeImplemented == null)
				{
					r_RIsRuntimeImplemented = new(this, "IsRuntimeImplemented", 0);
					r_RIsRuntimeImplemented.SetBelong(this.instance);
				}
				return r_RIsRuntimeImplemented;
			}
		}

		/// <summary>
		/// System.String InternalGetNameIfAvailable(System.Type ByRef)
		/// </summary>
		protected RMethod r_RInternalGetNameIfAvailable_Ref_Type;
		public virtual RMethod RInternalGetNameIfAvailable_Ref_Type
		{
			get
			{
				if(r_RInternalGetNameIfAvailable_Ref_Type == null)
				{
					r_RInternalGetNameIfAvailable_Ref_Type = new(this, "InternalGetNameIfAvailable", 0, typeof(System.Type).MakeByRefType());
					r_RInternalGetNameIfAvailable_Ref_Type.SetBelong(this.instance);
				}
				return r_RInternalGetNameIfAvailable_Ref_Type;
			}
		}

		/// <summary>
		/// System.Reflection.Module get_Module()
		/// </summary>
		protected RMethod r_Rget_Module;
		public virtual RMethod Rget_Module
		{
			get
			{
				if(r_Rget_Module == null)
				{
					r_Rget_Module = new(this, "get_Module", 0);
					r_Rget_Module.SetBelong(this.instance);
				}
				return r_Rget_Module;
			}
		}

		/// <summary>
		/// Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_RHasSameMetadataDefinitionAs_MemberInfo;
		public virtual RMethod RHasSameMetadataDefinitionAs_MemberInfo
		{
			get
			{
				if(r_RHasSameMetadataDefinitionAs_MemberInfo == null)
				{
					r_RHasSameMetadataDefinitionAs_MemberInfo = new(this, "HasSameMetadataDefinitionAs", 0, typeof(System.Reflection.MemberInfo));
					r_RHasSameMetadataDefinitionAs_MemberInfo.SetBelong(this.instance);
				}
				return r_RHasSameMetadataDefinitionAs_MemberInfo;
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
		/// Boolean CacheEquals(System.Object)
		/// </summary>
		protected RMethod r_RCacheEquals_Object;
		public virtual RMethod RCacheEquals_Object
		{
			get
			{
				if(r_RCacheEquals_Object == null)
				{
					r_RCacheEquals_Object = new(this, "CacheEquals", 0, typeof(System.Object));
					r_RCacheEquals_Object.SetBelong(this.instance);
				}
				return r_RCacheEquals_Object;
			}
		}

		/// <summary>
		/// Boolean HasSameMetadataDefinitionAsCore[TOther](System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo;
		public virtual RMethod RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo
		{
			get
			{
				if(r_RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo == null)
				{
					r_RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo = new(this, "HasSameMetadataDefinitionAsCore", 1, typeof(System.Reflection.MemberInfo));
					r_RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo.SetBelong(this.instance);
				}
				return r_RHasSameMetadataDefinitionAsCore_GTOther_MemberInfo;
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


        public RGenericTypeParameterBuilder() : base("System.Reflection.Emit.GenericTypeParameterBuilder")
        {
        }

        public RGenericTypeParameterBuilder(System.Object instance) : base("System.Reflection.Emit.GenericTypeParameterBuilder")
		{
            SetInstance(instance);
		}

        public RGenericTypeParameterBuilder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGenericTypeParameterBuilder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetBaseTypeConstraint(System.Type  @baseTypeConstraint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseTypeConstraint};
            var ___result = RSetBaseTypeConstraint_Type.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInterfaceConstraints(System.Type[]  @interfaceConstraints)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@interfaceConstraints};
            var ___result = RSetInterfaceConstraints_TypeArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetGenericParameterAttributes(System.Reflection.GenericParameterAttributes  @genericParameterAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@genericParameterAttributes};
            var ___result = RSetGenericParameterAttributes_GenericParameterAttributes.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Boolean IsSubclassOf(System.Type  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsSubclassOf_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Reflection.TypeAttributes GetAttributeFlagsImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAttributeFlagsImpl.Invoke(___genericsType, ___parameters);

            return (System.Reflection.TypeAttributes)___result;
        }


        public virtual System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Reflection.CallingConventions  @callConvention, System.Type[]  @types, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public virtual System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RGetConstructors_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo[])___result;
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


        public virtual System.Reflection.FieldInfo GetField(System.String  @name, System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RGetField_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RGetFields_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo[])___result;
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


        public virtual System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RGetMembers_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetMember(System.String  @name, System.Reflection.MemberTypes  @type, System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @type, @bindingAttr};
            var ___result = RGetMember_String_MemberTypes_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RGetMethods_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo GetMethodImpl(System.String  @name, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Reflection.CallingConventions  @callConvention, System.Type[]  @types, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Type GetNestedType(System.String  @name, System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RGetNestedType_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type[] GetNestedTypes(System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RGetNestedTypes_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags  @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RGetProperties_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo[])___result;
        }


        public virtual System.Reflection.PropertyInfo GetPropertyImpl(System.String  @name, System.Reflection.BindingFlags  @bindingAttr, System.Reflection.Binder  @binder, System.Type  @returnType, System.Type[]  @types, System.Reflection.ParameterModifier[]  @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @returnType, @types, @modifiers};
            var ___result = RGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Boolean HasElementTypeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasElementTypeImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsAssignableFrom(System.Type  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RIsAssignableFrom_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsAssignableFrom(System.Reflection.TypeInfo  @typeInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeInfo};
            var ___result = RIsAssignableFrom_TypeInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsInstanceOfType(System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RIsInstanceOfType_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.Boolean IsCOMObjectImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsCOMObjectImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsPointerImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsPointerImpl.Invoke(___genericsType, ___parameters);

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


        public virtual System.Object InvokeMember(System.String  @name, System.Reflection.BindingFlags  @invokeAttr, System.Reflection.Binder  @binder, System.Object  @target, System.Object[]  @args, System.Reflection.ParameterModifier[]  @modifiers, System.Globalization.CultureInfo  @culture, System.String[]  @namedParameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @invokeAttr, @binder, @target, @args, @modifiers, @culture, @namedParameters};
            var ___result = RInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Type GetElementType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetElementType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
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


        public virtual System.Reflection.InterfaceMapping GetInterfaceMap(System.Type  @interfaceType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@interfaceType};
            var ___result = RGetInterfaceMap_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.InterfaceMapping)___result;
        }


        public virtual System.Type[] GetGenericArguments()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGenericArguments.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type GetGenericTypeDefinition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGenericTypeDefinition.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type[] GetGenericParameterConstraints()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetGenericParameterConstraints.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
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


        public virtual System.Exception not_supported()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rnot_supported.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
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


        public virtual System.Type AsType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAsType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Reflection.EventInfo GetDeclaredEvent(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetDeclaredEvent_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo)___result;
        }


        public virtual System.Reflection.FieldInfo GetDeclaredField(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetDeclaredField_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetDeclaredMethod(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetDeclaredMethod_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.TypeInfo GetDeclaredNestedType(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetDeclaredNestedType_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.TypeInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetDeclaredProperty(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetDeclaredProperty_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetDeclaredMethods(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetDeclaredMethods_String.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>)___result;
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


        public virtual System.Boolean ImplementInterface(System.Type  @ifaceType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ifaceType};
            var ___result = RImplementInterface_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Int32 GetArrayRank()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetArrayRank.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.Reflection.ConstructorInfo[] GetConstructors()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetConstructors.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo[])___result;
        }


        public virtual System.Reflection.EventInfo GetEvent(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetEvent_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo)___result;
        }


        public virtual System.Reflection.FieldInfo GetField(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetField_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.FieldInfo[] GetFields()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetFields.Invoke(___genericsType, ___parameters);

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


        public virtual System.Reflection.MemberInfo[] GetMembers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMembers.Invoke(___genericsType, ___parameters);

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


        public virtual System.Type GetNestedType(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetNestedType_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type[] GetNestedTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNestedTypes.Invoke(___genericsType, ___parameters);

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


        public virtual System.Reflection.PropertyInfo[] GetProperties()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetProperties.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetDefaultMembers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDefaultMembers.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.TypeCode GetTypeCodeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTypeCodeImpl.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
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


        public virtual System.Type GetInterface(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetInterface_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
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


        public virtual System.Boolean Equals(System.Type  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = REquals_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
