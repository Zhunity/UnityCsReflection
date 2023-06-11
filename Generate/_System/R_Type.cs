
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.Type
	/// </summary>
    public partial class RType : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Type);
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


		/// <summary>
		/// System.Reflection.Binder s_defaultBinder
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBinder r_Fs_defaultBinder;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBinder RFs_defaultBinder
		{
			get
			{
				if(r_Fs_defaultBinder == null)
				{
					r_Fs_defaultBinder = new(typeof(System.Type), "s_defaultBinder");
				}
				return r_Fs_defaultBinder;
			}
		}

		/// <summary>
		/// System.Char Delimiter
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RChar r_FDelimiter;
		public static Hvak.Editor.Refleaction.RSystem.RChar RFDelimiter
		{
			get
			{
				if(r_FDelimiter == null)
				{
					r_FDelimiter = new(typeof(System.Type), "Delimiter");
				}
				return r_FDelimiter;
			}
		}

		/// <summary>
		/// System.Type[] EmptyTypes
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType> r_FEmptyTypes;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType> RFEmptyTypes
		{
			get
			{
				if(r_FEmptyTypes == null)
				{
					r_FEmptyTypes = new(typeof(System.Type), "EmptyTypes");
				}
				return r_FEmptyTypes;
			}
		}

		/// <summary>
		/// System.Object Missing
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RObject r_FMissing;
		public static Hvak.Editor.Refleaction.RSystem.RObject RFMissing
		{
			get
			{
				if(r_FMissing == null)
				{
					r_FMissing = new(typeof(System.Type), "Missing");
				}
				return r_FMissing;
			}
		}

		/// <summary>
		/// System.Reflection.MemberFilter FilterAttribute
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMemberFilter r_FFilterAttribute;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMemberFilter RFFilterAttribute
		{
			get
			{
				if(r_FFilterAttribute == null)
				{
					r_FFilterAttribute = new(typeof(System.Type), "FilterAttribute");
				}
				return r_FFilterAttribute;
			}
		}

		/// <summary>
		/// System.Reflection.MemberFilter FilterName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMemberFilter r_FFilterName;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMemberFilter RFFilterName
		{
			get
			{
				if(r_FFilterName == null)
				{
					r_FFilterName = new(typeof(System.Type), "FilterName");
				}
				return r_FFilterName;
			}
		}

		/// <summary>
		/// System.Reflection.MemberFilter FilterNameIgnoreCase
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMemberFilter r_FFilterNameIgnoreCase;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMemberFilter RFFilterNameIgnoreCase
		{
			get
			{
				if(r_FFilterNameIgnoreCase == null)
				{
					r_FFilterNameIgnoreCase = new(typeof(System.Type), "FilterNameIgnoreCase");
				}
				return r_FFilterNameIgnoreCase;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags DefaultLookup
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags r_FDefaultLookup;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBindingFlags RFDefaultLookup
		{
			get
			{
				if(r_FDefaultLookup == null)
				{
					r_FDefaultLookup = new(typeof(System.Type), "DefaultLookup");
				}
				return r_FDefaultLookup;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle _impl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntimeTypeHandle r_F_impl;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntimeTypeHandle RF_impl
		{
			get
			{
				if(r_F_impl == null)
				{
					r_F_impl = new(this, "_impl");
				}
				return r_F_impl;
			}
		}

		/// <summary>
		/// System.String DefaultTypeNameWhenMissingMetadata
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FDefaultTypeNameWhenMissingMetadata;
		public static Hvak.Editor.Refleaction.RSystem.RString RFDefaultTypeNameWhenMissingMetadata
		{
			get
			{
				if(r_FDefaultTypeNameWhenMissingMetadata == null)
				{
					r_FDefaultTypeNameWhenMissingMetadata = new(typeof(System.Type), "DefaultTypeNameWhenMissingMetadata");
				}
				return r_FDefaultTypeNameWhenMissingMetadata;
			}
		}

		/// <summary>
		/// Boolean IsSerializable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSerializable;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSerializable
		{
			get
			{
				if(r_PIsSerializable == null)
				{
					r_PIsSerializable = new(this, "IsSerializable", -1);
				}
				return r_PIsSerializable;
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
				}
				return r_PContainsGenericParameters;
			}
		}

		/// <summary>
		/// Boolean IsVisible
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsVisible;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsVisible
		{
			get
			{
				if(r_PIsVisible == null)
				{
					r_PIsVisible = new(this, "IsVisible", -1);
				}
				return r_PIsVisible;
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
		/// System.String Namespace
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PNamespace;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPNamespace
		{
			get
			{
				if(r_PNamespace == null)
				{
					r_PNamespace = new(this, "Namespace", -1);
				}
				return r_PNamespace;
			}
		}

		/// <summary>
		/// System.String AssemblyQualifiedName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PAssemblyQualifiedName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPAssemblyQualifiedName
		{
			get
			{
				if(r_PAssemblyQualifiedName == null)
				{
					r_PAssemblyQualifiedName = new(this, "AssemblyQualifiedName", -1);
				}
				return r_PAssemblyQualifiedName;
			}
		}

		/// <summary>
		/// System.String FullName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PFullName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPFullName
		{
			get
			{
				if(r_PFullName == null)
				{
					r_PFullName = new(this, "FullName", -1);
				}
				return r_PFullName;
			}
		}

		/// <summary>
		/// System.Reflection.Assembly Assembly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RAssembly r_PAssembly;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RAssembly RPAssembly
		{
			get
			{
				if(r_PAssembly == null)
				{
					r_PAssembly = new(this, "Assembly", -1);
				}
				return r_PAssembly;
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
		/// Boolean IsNested
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsNested;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsNested
		{
			get
			{
				if(r_PIsNested == null)
				{
					r_PIsNested = new(this, "IsNested", -1);
				}
				return r_PIsNested;
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
		/// System.Reflection.MethodBase DeclaringMethod
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMethodBase r_PDeclaringMethod;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMethodBase RPDeclaringMethod
		{
			get
			{
				if(r_PDeclaringMethod == null)
				{
					r_PDeclaringMethod = new(this, "DeclaringMethod", -1);
				}
				return r_PDeclaringMethod;
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
		/// System.Type UnderlyingSystemType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_PUnderlyingSystemType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RPUnderlyingSystemType
		{
			get
			{
				if(r_PUnderlyingSystemType == null)
				{
					r_PUnderlyingSystemType = new(this, "UnderlyingSystemType", -1);
				}
				return r_PUnderlyingSystemType;
			}
		}

		/// <summary>
		/// Boolean IsTypeDefinition
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsTypeDefinition;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsTypeDefinition
		{
			get
			{
				if(r_PIsTypeDefinition == null)
				{
					r_PIsTypeDefinition = new(this, "IsTypeDefinition", -1);
				}
				return r_PIsTypeDefinition;
			}
		}

		/// <summary>
		/// Boolean IsArray
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsArray;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsArray
		{
			get
			{
				if(r_PIsArray == null)
				{
					r_PIsArray = new(this, "IsArray", -1);
				}
				return r_PIsArray;
			}
		}

		/// <summary>
		/// Boolean IsByRef
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsByRef;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsByRef
		{
			get
			{
				if(r_PIsByRef == null)
				{
					r_PIsByRef = new(this, "IsByRef", -1);
				}
				return r_PIsByRef;
			}
		}

		/// <summary>
		/// Boolean IsPointer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsPointer;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsPointer
		{
			get
			{
				if(r_PIsPointer == null)
				{
					r_PIsPointer = new(this, "IsPointer", -1);
				}
				return r_PIsPointer;
			}
		}

		/// <summary>
		/// Boolean IsConstructedGenericType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsConstructedGenericType;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsConstructedGenericType
		{
			get
			{
				if(r_PIsConstructedGenericType == null)
				{
					r_PIsConstructedGenericType = new(this, "IsConstructedGenericType", -1);
				}
				return r_PIsConstructedGenericType;
			}
		}

		/// <summary>
		/// Boolean IsGenericParameter
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsGenericParameter;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsGenericParameter
		{
			get
			{
				if(r_PIsGenericParameter == null)
				{
					r_PIsGenericParameter = new(this, "IsGenericParameter", -1);
				}
				return r_PIsGenericParameter;
			}
		}

		/// <summary>
		/// Boolean IsGenericTypeParameter
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsGenericTypeParameter;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsGenericTypeParameter
		{
			get
			{
				if(r_PIsGenericTypeParameter == null)
				{
					r_PIsGenericTypeParameter = new(this, "IsGenericTypeParameter", -1);
				}
				return r_PIsGenericTypeParameter;
			}
		}

		/// <summary>
		/// Boolean IsGenericMethodParameter
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsGenericMethodParameter;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsGenericMethodParameter
		{
			get
			{
				if(r_PIsGenericMethodParameter == null)
				{
					r_PIsGenericMethodParameter = new(this, "IsGenericMethodParameter", -1);
				}
				return r_PIsGenericMethodParameter;
			}
		}

		/// <summary>
		/// Boolean IsGenericType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsGenericType;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsGenericType
		{
			get
			{
				if(r_PIsGenericType == null)
				{
					r_PIsGenericType = new(this, "IsGenericType", -1);
				}
				return r_PIsGenericType;
			}
		}

		/// <summary>
		/// Boolean IsGenericTypeDefinition
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsGenericTypeDefinition;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsGenericTypeDefinition
		{
			get
			{
				if(r_PIsGenericTypeDefinition == null)
				{
					r_PIsGenericTypeDefinition = new(this, "IsGenericTypeDefinition", -1);
				}
				return r_PIsGenericTypeDefinition;
			}
		}

		/// <summary>
		/// Boolean IsSZArray
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSZArray;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSZArray
		{
			get
			{
				if(r_PIsSZArray == null)
				{
					r_PIsSZArray = new(this, "IsSZArray", -1);
				}
				return r_PIsSZArray;
			}
		}

		/// <summary>
		/// Boolean IsVariableBoundArray
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsVariableBoundArray;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsVariableBoundArray
		{
			get
			{
				if(r_PIsVariableBoundArray == null)
				{
					r_PIsVariableBoundArray = new(this, "IsVariableBoundArray", -1);
				}
				return r_PIsVariableBoundArray;
			}
		}

		/// <summary>
		/// Boolean IsByRefLike
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsByRefLike;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsByRefLike
		{
			get
			{
				if(r_PIsByRefLike == null)
				{
					r_PIsByRefLike = new(this, "IsByRefLike", -1);
				}
				return r_PIsByRefLike;
			}
		}

		/// <summary>
		/// Boolean HasElementType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PHasElementType;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPHasElementType
		{
			get
			{
				if(r_PHasElementType == null)
				{
					r_PHasElementType = new(this, "HasElementType", -1);
				}
				return r_PHasElementType;
			}
		}

		/// <summary>
		/// System.Type[] GenericTypeArguments
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RType> r_PGenericTypeArguments;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RSystem.RType> RPGenericTypeArguments
		{
			get
			{
				if(r_PGenericTypeArguments == null)
				{
					r_PGenericTypeArguments = new(this, "GenericTypeArguments", -1);
				}
				return r_PGenericTypeArguments;
			}
		}

		/// <summary>
		/// Int32 GenericParameterPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PGenericParameterPosition;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPGenericParameterPosition
		{
			get
			{
				if(r_PGenericParameterPosition == null)
				{
					r_PGenericParameterPosition = new(this, "GenericParameterPosition", -1);
				}
				return r_PGenericParameterPosition;
			}
		}

		/// <summary>
		/// System.Reflection.GenericParameterAttributes GenericParameterAttributes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RGenericParameterAttributes r_PGenericParameterAttributes;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RGenericParameterAttributes RPGenericParameterAttributes
		{
			get
			{
				if(r_PGenericParameterAttributes == null)
				{
					r_PGenericParameterAttributes = new(this, "GenericParameterAttributes", -1);
				}
				return r_PGenericParameterAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes Attributes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_PAttributes;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RPAttributes
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
				}
				return r_PIsAbstract;
			}
		}

		/// <summary>
		/// Boolean IsImport
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsImport;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsImport
		{
			get
			{
				if(r_PIsImport == null)
				{
					r_PIsImport = new(this, "IsImport", -1);
				}
				return r_PIsImport;
			}
		}

		/// <summary>
		/// Boolean IsSealed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSealed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSealed
		{
			get
			{
				if(r_PIsSealed == null)
				{
					r_PIsSealed = new(this, "IsSealed", -1);
				}
				return r_PIsSealed;
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
		/// Boolean IsClass
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsClass;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsClass
		{
			get
			{
				if(r_PIsClass == null)
				{
					r_PIsClass = new(this, "IsClass", -1);
				}
				return r_PIsClass;
			}
		}

		/// <summary>
		/// Boolean IsNestedAssembly
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsNestedAssembly;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsNestedAssembly
		{
			get
			{
				if(r_PIsNestedAssembly == null)
				{
					r_PIsNestedAssembly = new(this, "IsNestedAssembly", -1);
				}
				return r_PIsNestedAssembly;
			}
		}

		/// <summary>
		/// Boolean IsNestedFamANDAssem
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsNestedFamANDAssem;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsNestedFamANDAssem
		{
			get
			{
				if(r_PIsNestedFamANDAssem == null)
				{
					r_PIsNestedFamANDAssem = new(this, "IsNestedFamANDAssem", -1);
				}
				return r_PIsNestedFamANDAssem;
			}
		}

		/// <summary>
		/// Boolean IsNestedFamily
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsNestedFamily;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsNestedFamily
		{
			get
			{
				if(r_PIsNestedFamily == null)
				{
					r_PIsNestedFamily = new(this, "IsNestedFamily", -1);
				}
				return r_PIsNestedFamily;
			}
		}

		/// <summary>
		/// Boolean IsNestedFamORAssem
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsNestedFamORAssem;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsNestedFamORAssem
		{
			get
			{
				if(r_PIsNestedFamORAssem == null)
				{
					r_PIsNestedFamORAssem = new(this, "IsNestedFamORAssem", -1);
				}
				return r_PIsNestedFamORAssem;
			}
		}

		/// <summary>
		/// Boolean IsNestedPrivate
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsNestedPrivate;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsNestedPrivate
		{
			get
			{
				if(r_PIsNestedPrivate == null)
				{
					r_PIsNestedPrivate = new(this, "IsNestedPrivate", -1);
				}
				return r_PIsNestedPrivate;
			}
		}

		/// <summary>
		/// Boolean IsNestedPublic
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsNestedPublic;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsNestedPublic
		{
			get
			{
				if(r_PIsNestedPublic == null)
				{
					r_PIsNestedPublic = new(this, "IsNestedPublic", -1);
				}
				return r_PIsNestedPublic;
			}
		}

		/// <summary>
		/// Boolean IsNotPublic
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsNotPublic;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsNotPublic
		{
			get
			{
				if(r_PIsNotPublic == null)
				{
					r_PIsNotPublic = new(this, "IsNotPublic", -1);
				}
				return r_PIsNotPublic;
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
				}
				return r_PIsPublic;
			}
		}

		/// <summary>
		/// Boolean IsAutoLayout
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsAutoLayout;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsAutoLayout
		{
			get
			{
				if(r_PIsAutoLayout == null)
				{
					r_PIsAutoLayout = new(this, "IsAutoLayout", -1);
				}
				return r_PIsAutoLayout;
			}
		}

		/// <summary>
		/// Boolean IsExplicitLayout
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsExplicitLayout;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsExplicitLayout
		{
			get
			{
				if(r_PIsExplicitLayout == null)
				{
					r_PIsExplicitLayout = new(this, "IsExplicitLayout", -1);
				}
				return r_PIsExplicitLayout;
			}
		}

		/// <summary>
		/// Boolean IsLayoutSequential
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsLayoutSequential;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsLayoutSequential
		{
			get
			{
				if(r_PIsLayoutSequential == null)
				{
					r_PIsLayoutSequential = new(this, "IsLayoutSequential", -1);
				}
				return r_PIsLayoutSequential;
			}
		}

		/// <summary>
		/// Boolean IsAnsiClass
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsAnsiClass;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsAnsiClass
		{
			get
			{
				if(r_PIsAnsiClass == null)
				{
					r_PIsAnsiClass = new(this, "IsAnsiClass", -1);
				}
				return r_PIsAnsiClass;
			}
		}

		/// <summary>
		/// Boolean IsAutoClass
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsAutoClass;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsAutoClass
		{
			get
			{
				if(r_PIsAutoClass == null)
				{
					r_PIsAutoClass = new(this, "IsAutoClass", -1);
				}
				return r_PIsAutoClass;
			}
		}

		/// <summary>
		/// Boolean IsUnicodeClass
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsUnicodeClass;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsUnicodeClass
		{
			get
			{
				if(r_PIsUnicodeClass == null)
				{
					r_PIsUnicodeClass = new(this, "IsUnicodeClass", -1);
				}
				return r_PIsUnicodeClass;
			}
		}

		/// <summary>
		/// Boolean IsCOMObject
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsCOMObject;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsCOMObject
		{
			get
			{
				if(r_PIsCOMObject == null)
				{
					r_PIsCOMObject = new(this, "IsCOMObject", -1);
				}
				return r_PIsCOMObject;
			}
		}

		/// <summary>
		/// Boolean IsContextful
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsContextful;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsContextful
		{
			get
			{
				if(r_PIsContextful == null)
				{
					r_PIsContextful = new(this, "IsContextful", -1);
				}
				return r_PIsContextful;
			}
		}

		/// <summary>
		/// Boolean IsCollectible
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsCollectible;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsCollectible
		{
			get
			{
				if(r_PIsCollectible == null)
				{
					r_PIsCollectible = new(this, "IsCollectible", -1);
				}
				return r_PIsCollectible;
			}
		}

		/// <summary>
		/// Boolean IsEnum
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsEnum;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsEnum
		{
			get
			{
				if(r_PIsEnum == null)
				{
					r_PIsEnum = new(this, "IsEnum", -1);
				}
				return r_PIsEnum;
			}
		}

		/// <summary>
		/// Boolean IsMarshalByRef
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsMarshalByRef;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsMarshalByRef
		{
			get
			{
				if(r_PIsMarshalByRef == null)
				{
					r_PIsMarshalByRef = new(this, "IsMarshalByRef", -1);
				}
				return r_PIsMarshalByRef;
			}
		}

		/// <summary>
		/// Boolean IsPrimitive
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsPrimitive;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsPrimitive
		{
			get
			{
				if(r_PIsPrimitive == null)
				{
					r_PIsPrimitive = new(this, "IsPrimitive", -1);
				}
				return r_PIsPrimitive;
			}
		}

		/// <summary>
		/// Boolean IsValueType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsValueType;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsValueType
		{
			get
			{
				if(r_PIsValueType == null)
				{
					r_PIsValueType = new(this, "IsValueType", -1);
				}
				return r_PIsValueType;
			}
		}

		/// <summary>
		/// Boolean IsSignatureType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSignatureType;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSignatureType
		{
			get
			{
				if(r_PIsSignatureType == null)
				{
					r_PIsSignatureType = new(this, "IsSignatureType", -1);
				}
				return r_PIsSignatureType;
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
				}
				return r_PIsSecuritySafeCritical;
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
				}
				return r_PIsSecurityTransparent;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.StructLayoutAttribute StructLayoutAttribute
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RStructLayoutAttribute r_PStructLayoutAttribute;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RStructLayoutAttribute RPStructLayoutAttribute
		{
			get
			{
				if(r_PStructLayoutAttribute == null)
				{
					r_PStructLayoutAttribute = new(this, "StructLayoutAttribute", -1);
				}
				return r_PStructLayoutAttribute;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo TypeInitializer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RConstructorInfo r_PTypeInitializer;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RConstructorInfo RPTypeInitializer
		{
			get
			{
				if(r_PTypeInitializer == null)
				{
					r_PTypeInitializer = new(this, "TypeInitializer", -1);
				}
				return r_PTypeInitializer;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle TypeHandle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntimeTypeHandle r_PTypeHandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntimeTypeHandle RPTypeHandle
		{
			get
			{
				if(r_PTypeHandle == null)
				{
					r_PTypeHandle = new(this, "TypeHandle", -1);
				}
				return r_PTypeHandle;
			}
		}

		/// <summary>
		/// System.Guid GUID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RGuid r_PGUID;
		public virtual Hvak.Editor.Refleaction.RSystem.RGuid RPGUID
		{
			get
			{
				if(r_PGUID == null)
				{
					r_PGUID = new(this, "GUID", -1);
				}
				return r_PGUID;
			}
		}

		/// <summary>
		/// System.Type BaseType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_PBaseType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RPBaseType
		{
			get
			{
				if(r_PBaseType == null)
				{
					r_PBaseType = new(this, "BaseType", -1);
				}
				return r_PBaseType;
			}
		}

		/// <summary>
		/// System.Reflection.Binder DefaultBinder
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RBinder r_PDefaultBinder;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RBinder RPDefaultBinder
		{
			get
			{
				if(r_PDefaultBinder == null)
				{
					r_PDefaultBinder = new(typeof(System.Type), "DefaultBinder", -1);
				}
				return r_PDefaultBinder;
			}
		}

		/// <summary>
		/// Boolean IsUserType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsUserType;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsUserType
		{
			get
			{
				if(r_PIsUserType == null)
				{
					r_PIsUserType = new(this, "IsUserType", -1);
				}
				return r_PIsUserType;
			}
		}

		/// <summary>
		/// Boolean IsWindowsRuntimeObject
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsWindowsRuntimeObject;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsWindowsRuntimeObject
		{
			get
			{
				if(r_PIsWindowsRuntimeObject == null)
				{
					r_PIsWindowsRuntimeObject = new(this, "IsWindowsRuntimeObject", -1);
				}
				return r_PIsWindowsRuntimeObject;
			}
		}

		/// <summary>
		/// Boolean IsExportedToWindowsRuntime
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsExportedToWindowsRuntime;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsExportedToWindowsRuntime
		{
			get
			{
				if(r_PIsExportedToWindowsRuntime == null)
				{
					r_PIsExportedToWindowsRuntime = new(this, "IsExportedToWindowsRuntime", -1);
				}
				return r_PIsExportedToWindowsRuntime;
			}
		}

		/// <summary>
		/// Boolean IsSzArray
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsSzArray;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsSzArray
		{
			get
			{
				if(r_PIsSzArray == null)
				{
					r_PIsSzArray = new(this, "IsSzArray", -1);
				}
				return r_PIsSzArray;
			}
		}

		/// <summary>
		/// Boolean IsInterface
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsInterface;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsInterface
		{
			get
			{
				if(r_PIsInterface == null)
				{
					r_PIsInterface = new(this, "IsInterface", -1);
				}
				return r_PIsInterface;
			}
		}

		/// <summary>
		/// System.String FullNameOrDefault
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PFullNameOrDefault;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPFullNameOrDefault
		{
			get
			{
				if(r_PFullNameOrDefault == null)
				{
					r_PFullNameOrDefault = new(this, "FullNameOrDefault", -1);
				}
				return r_PFullNameOrDefault;
			}
		}

		/// <summary>
		/// System.String InternalNameIfAvailable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PInternalNameIfAvailable;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPInternalNameIfAvailable
		{
			get
			{
				if(r_PInternalNameIfAvailable == null)
				{
					r_PInternalNameIfAvailable = new(this, "InternalNameIfAvailable", -1);
				}
				return r_PInternalNameIfAvailable;
			}
		}

		/// <summary>
		/// System.String NameOrDefault
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PNameOrDefault;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPNameOrDefault
		{
			get
			{
				if(r_PNameOrDefault == null)
				{
					r_PNameOrDefault = new(this, "NameOrDefault", -1);
				}
				return r_PNameOrDefault;
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
		/// Boolean IsEnumDefined(System.Object)
		/// </summary>
		protected RMethod r_MIsEnumDefined_Object;
		public virtual RMethod RMIsEnumDefined_Object
		{
			get
			{
				if(r_MIsEnumDefined_Object == null)
				{
					r_MIsEnumDefined_Object = new(this, "IsEnumDefined", 0, typeof(System.Object));
				}
				return r_MIsEnumDefined_Object;
			}
		}

		/// <summary>
		/// System.String GetEnumName(System.Object)
		/// </summary>
		protected RMethod r_MGetEnumName_Object;
		public virtual RMethod RMGetEnumName_Object
		{
			get
			{
				if(r_MGetEnumName_Object == null)
				{
					r_MGetEnumName_Object = new(this, "GetEnumName", 0, typeof(System.Object));
				}
				return r_MGetEnumName_Object;
			}
		}

		/// <summary>
		/// System.String[] GetEnumNames()
		/// </summary>
		protected RMethod r_MGetEnumNames;
		public virtual RMethod RMGetEnumNames
		{
			get
			{
				if(r_MGetEnumNames == null)
				{
					r_MGetEnumNames = new(this, "GetEnumNames", 0);
				}
				return r_MGetEnumNames;
			}
		}

		/// <summary>
		/// System.Array GetEnumRawConstantValues()
		/// </summary>
		protected RMethod r_MGetEnumRawConstantValues;
		public virtual RMethod RMGetEnumRawConstantValues
		{
			get
			{
				if(r_MGetEnumRawConstantValues == null)
				{
					r_MGetEnumRawConstantValues = new(this, "GetEnumRawConstantValues", 0);
				}
				return r_MGetEnumRawConstantValues;
			}
		}

		/// <summary>
		/// Void GetEnumData(System.String[] ByRef, System.Array ByRef)
		/// </summary>
		protected RMethod r_MGetEnumData_Out_StringArray_Out_Array;
		public virtual RMethod RMGetEnumData_Out_StringArray_Out_Array
		{
			get
			{
				if(r_MGetEnumData_Out_StringArray_Out_Array == null)
				{
					r_MGetEnumData_Out_StringArray_Out_Array = new(this, "GetEnumData", 0, typeof(System.String).MakeArrayType().MakeByRefType(), typeof(System.Array).MakeByRefType());
				}
				return r_MGetEnumData_Out_StringArray_Out_Array;
			}
		}

		/// <summary>
		/// Int32 BinarySearch(System.Array, System.Object)
		/// </summary>
		protected static RMethod r_MBinarySearch_Array_Object;
		public static RMethod RMBinarySearch_Array_Object
		{
			get
			{
				if(r_MBinarySearch_Array_Object == null)
				{
					r_MBinarySearch_Array_Object = new(typeof(System.Type), "BinarySearch", 0, typeof(System.Array), typeof(System.Object));
				}
				return r_MBinarySearch_Array_Object;
			}
		}

		/// <summary>
		/// Boolean IsIntegerType(System.Type)
		/// </summary>
		protected static RMethod r_MIsIntegerType_Type;
		public static RMethod RMIsIntegerType_Type
		{
			get
			{
				if(r_MIsIntegerType_Type == null)
				{
					r_MIsIntegerType_Type = new(typeof(System.Type), "IsIntegerType", 0, typeof(System.Type));
				}
				return r_MIsIntegerType_Type;
			}
		}

		/// <summary>
		/// System.Type GetRootElementType()
		/// </summary>
		protected RMethod r_MGetRootElementType;
		public virtual RMethod RMGetRootElementType
		{
			get
			{
				if(r_MGetRootElementType == null)
				{
					r_MGetRootElementType = new(this, "GetRootElementType", 0);
				}
				return r_MGetRootElementType;
			}
		}

		/// <summary>
		/// System.Type[] FindInterfaces(System.Reflection.TypeFilter, System.Object)
		/// </summary>
		protected RMethod r_MFindInterfaces_TypeFilter_Object;
		public virtual RMethod RMFindInterfaces_TypeFilter_Object
		{
			get
			{
				if(r_MFindInterfaces_TypeFilter_Object == null)
				{
					r_MFindInterfaces_TypeFilter_Object = new(this, "FindInterfaces", 0, typeof(System.Reflection.TypeFilter), typeof(System.Object));
				}
				return r_MFindInterfaces_TypeFilter_Object;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] FindMembers(System.Reflection.MemberTypes, System.Reflection.BindingFlags, System.Reflection.MemberFilter, System.Object)
		/// </summary>
		protected RMethod r_MFindMembers_MemberTypes_BindingFlags_MemberFilter_Object;
		public virtual RMethod RMFindMembers_MemberTypes_BindingFlags_MemberFilter_Object
		{
			get
			{
				if(r_MFindMembers_MemberTypes_BindingFlags_MemberFilter_Object == null)
				{
					r_MFindMembers_MemberTypes_BindingFlags_MemberFilter_Object = new(this, "FindMembers", 0, typeof(System.Reflection.MemberTypes), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.MemberFilter), typeof(System.Object));
				}
				return r_MFindMembers_MemberTypes_BindingFlags_MemberFilter_Object;
			}
		}

		/// <summary>
		/// Boolean IsSubclassOf(System.Type)
		/// </summary>
		protected RMethod r_MIsSubclassOf_Type;
		public virtual RMethod RMIsSubclassOf_Type
		{
			get
			{
				if(r_MIsSubclassOf_Type == null)
				{
					r_MIsSubclassOf_Type = new(this, "IsSubclassOf", 0, typeof(System.Type));
				}
				return r_MIsSubclassOf_Type;
			}
		}

		/// <summary>
		/// Boolean IsAssignableFrom(System.Type)
		/// </summary>
		protected RMethod r_MIsAssignableFrom_Type;
		public virtual RMethod RMIsAssignableFrom_Type
		{
			get
			{
				if(r_MIsAssignableFrom_Type == null)
				{
					r_MIsAssignableFrom_Type = new(this, "IsAssignableFrom", 0, typeof(System.Type));
				}
				return r_MIsAssignableFrom_Type;
			}
		}

		/// <summary>
		/// Boolean ImplementInterface(System.Type)
		/// </summary>
		protected RMethod r_MImplementInterface_Type;
		public virtual RMethod RMImplementInterface_Type
		{
			get
			{
				if(r_MImplementInterface_Type == null)
				{
					r_MImplementInterface_Type = new(this, "ImplementInterface", 0, typeof(System.Type));
				}
				return r_MImplementInterface_Type;
			}
		}

		/// <summary>
		/// Boolean FilterAttributeImpl(System.Reflection.MemberInfo, System.Object)
		/// </summary>
		protected static RMethod r_MFilterAttributeImpl_MemberInfo_Object;
		public static RMethod RMFilterAttributeImpl_MemberInfo_Object
		{
			get
			{
				if(r_MFilterAttributeImpl_MemberInfo_Object == null)
				{
					r_MFilterAttributeImpl_MemberInfo_Object = new(typeof(System.Type), "FilterAttributeImpl", 0, typeof(System.Reflection.MemberInfo), typeof(System.Object));
				}
				return r_MFilterAttributeImpl_MemberInfo_Object;
			}
		}

		/// <summary>
		/// Boolean FilterNameImpl(System.Reflection.MemberInfo, System.Object)
		/// </summary>
		protected static RMethod r_MFilterNameImpl_MemberInfo_Object;
		public static RMethod RMFilterNameImpl_MemberInfo_Object
		{
			get
			{
				if(r_MFilterNameImpl_MemberInfo_Object == null)
				{
					r_MFilterNameImpl_MemberInfo_Object = new(typeof(System.Type), "FilterNameImpl", 0, typeof(System.Reflection.MemberInfo), typeof(System.Object));
				}
				return r_MFilterNameImpl_MemberInfo_Object;
			}
		}

		/// <summary>
		/// Boolean FilterNameIgnoreCaseImpl(System.Reflection.MemberInfo, System.Object)
		/// </summary>
		protected static RMethod r_MFilterNameIgnoreCaseImpl_MemberInfo_Object;
		public static RMethod RMFilterNameIgnoreCaseImpl_MemberInfo_Object
		{
			get
			{
				if(r_MFilterNameIgnoreCaseImpl_MemberInfo_Object == null)
				{
					r_MFilterNameIgnoreCaseImpl_MemberInfo_Object = new(typeof(System.Type), "FilterNameIgnoreCaseImpl", 0, typeof(System.Reflection.MemberInfo), typeof(System.Object));
				}
				return r_MFilterNameIgnoreCaseImpl_MemberInfo_Object;
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
		/// Boolean IsArrayImpl()
		/// </summary>
		protected RMethod r_MIsArrayImpl;
		public virtual RMethod RMIsArrayImpl
		{
			get
			{
				if(r_MIsArrayImpl == null)
				{
					r_MIsArrayImpl = new(this, "IsArrayImpl", 0);
				}
				return r_MIsArrayImpl;
			}
		}

		/// <summary>
		/// Boolean IsByRefImpl()
		/// </summary>
		protected RMethod r_MIsByRefImpl;
		public virtual RMethod RMIsByRefImpl
		{
			get
			{
				if(r_MIsByRefImpl == null)
				{
					r_MIsByRefImpl = new(this, "IsByRefImpl", 0);
				}
				return r_MIsByRefImpl;
			}
		}

		/// <summary>
		/// Boolean IsPointerImpl()
		/// </summary>
		protected RMethod r_MIsPointerImpl;
		public virtual RMethod RMIsPointerImpl
		{
			get
			{
				if(r_MIsPointerImpl == null)
				{
					r_MIsPointerImpl = new(this, "IsPointerImpl", 0);
				}
				return r_MIsPointerImpl;
			}
		}

		/// <summary>
		/// Boolean HasElementTypeImpl()
		/// </summary>
		protected RMethod r_MHasElementTypeImpl;
		public virtual RMethod RMHasElementTypeImpl
		{
			get
			{
				if(r_MHasElementTypeImpl == null)
				{
					r_MHasElementTypeImpl = new(this, "HasElementTypeImpl", 0);
				}
				return r_MHasElementTypeImpl;
			}
		}

		/// <summary>
		/// System.Type GetElementType()
		/// </summary>
		protected RMethod r_MGetElementType;
		public virtual RMethod RMGetElementType
		{
			get
			{
				if(r_MGetElementType == null)
				{
					r_MGetElementType = new(this, "GetElementType", 0);
				}
				return r_MGetElementType;
			}
		}

		/// <summary>
		/// Int32 GetArrayRank()
		/// </summary>
		protected RMethod r_MGetArrayRank;
		public virtual RMethod RMGetArrayRank
		{
			get
			{
				if(r_MGetArrayRank == null)
				{
					r_MGetArrayRank = new(this, "GetArrayRank", 0);
				}
				return r_MGetArrayRank;
			}
		}

		/// <summary>
		/// System.Type GetGenericTypeDefinition()
		/// </summary>
		protected RMethod r_MGetGenericTypeDefinition;
		public virtual RMethod RMGetGenericTypeDefinition
		{
			get
			{
				if(r_MGetGenericTypeDefinition == null)
				{
					r_MGetGenericTypeDefinition = new(this, "GetGenericTypeDefinition", 0);
				}
				return r_MGetGenericTypeDefinition;
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
				}
				return r_MGetGenericArguments;
			}
		}

		/// <summary>
		/// System.Type[] GetGenericParameterConstraints()
		/// </summary>
		protected RMethod r_MGetGenericParameterConstraints;
		public virtual RMethod RMGetGenericParameterConstraints
		{
			get
			{
				if(r_MGetGenericParameterConstraints == null)
				{
					r_MGetGenericParameterConstraints = new(this, "GetGenericParameterConstraints", 0);
				}
				return r_MGetGenericParameterConstraints;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes GetAttributeFlagsImpl()
		/// </summary>
		protected RMethod r_MGetAttributeFlagsImpl;
		public virtual RMethod RMGetAttributeFlagsImpl
		{
			get
			{
				if(r_MGetAttributeFlagsImpl == null)
				{
					r_MGetAttributeFlagsImpl = new(this, "GetAttributeFlagsImpl", 0);
				}
				return r_MGetAttributeFlagsImpl;
			}
		}

		/// <summary>
		/// Boolean IsCOMObjectImpl()
		/// </summary>
		protected RMethod r_MIsCOMObjectImpl;
		public virtual RMethod RMIsCOMObjectImpl
		{
			get
			{
				if(r_MIsCOMObjectImpl == null)
				{
					r_MIsCOMObjectImpl = new(this, "IsCOMObjectImpl", 0);
				}
				return r_MIsCOMObjectImpl;
			}
		}

		/// <summary>
		/// Boolean IsContextfulImpl()
		/// </summary>
		protected RMethod r_MIsContextfulImpl;
		public virtual RMethod RMIsContextfulImpl
		{
			get
			{
				if(r_MIsContextfulImpl == null)
				{
					r_MIsContextfulImpl = new(this, "IsContextfulImpl", 0);
				}
				return r_MIsContextfulImpl;
			}
		}

		/// <summary>
		/// Boolean IsMarshalByRefImpl()
		/// </summary>
		protected RMethod r_MIsMarshalByRefImpl;
		public virtual RMethod RMIsMarshalByRefImpl
		{
			get
			{
				if(r_MIsMarshalByRefImpl == null)
				{
					r_MIsMarshalByRefImpl = new(this, "IsMarshalByRefImpl", 0);
				}
				return r_MIsMarshalByRefImpl;
			}
		}

		/// <summary>
		/// Boolean IsPrimitiveImpl()
		/// </summary>
		protected RMethod r_MIsPrimitiveImpl;
		public virtual RMethod RMIsPrimitiveImpl
		{
			get
			{
				if(r_MIsPrimitiveImpl == null)
				{
					r_MIsPrimitiveImpl = new(this, "IsPrimitiveImpl", 0);
				}
				return r_MIsPrimitiveImpl;
			}
		}

		/// <summary>
		/// Boolean IsValueTypeImpl()
		/// </summary>
		protected RMethod r_MIsValueTypeImpl;
		public virtual RMethod RMIsValueTypeImpl
		{
			get
			{
				if(r_MIsValueTypeImpl == null)
				{
					r_MIsValueTypeImpl = new(this, "IsValueTypeImpl", 0);
				}
				return r_MIsValueTypeImpl;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructor(System.Type[])
		/// </summary>
		protected RMethod r_MGetConstructor_TypeArray;
		public virtual RMethod RMGetConstructor_TypeArray
		{
			get
			{
				if(r_MGetConstructor_TypeArray == null)
				{
					r_MGetConstructor_TypeArray = new(this, "GetConstructor", 0, typeof(System.Type).MakeArrayType());
				}
				return r_MGetConstructor_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags, System.Reflection.Binder, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray == null)
				{
					r_MGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray = new(this, "GetConstructor", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
				}
				return r_MGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_MGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetConstructor", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
				}
				return r_MGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_MGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetConstructorImpl", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
				}
				return r_MGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo[] GetConstructors()
		/// </summary>
		protected RMethod r_MGetConstructors;
		public virtual RMethod RMGetConstructors
		{
			get
			{
				if(r_MGetConstructors == null)
				{
					r_MGetConstructors = new(this, "GetConstructors", 0);
				}
				return r_MGetConstructors;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetConstructors_BindingFlags;
		public virtual RMethod RMGetConstructors_BindingFlags
		{
			get
			{
				if(r_MGetConstructors_BindingFlags == null)
				{
					r_MGetConstructors_BindingFlags = new(this, "GetConstructors", 0, typeof(System.Reflection.BindingFlags));
				}
				return r_MGetConstructors_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo GetEvent(System.String)
		/// </summary>
		protected RMethod r_MGetEvent_String;
		public virtual RMethod RMGetEvent_String
		{
			get
			{
				if(r_MGetEvent_String == null)
				{
					r_MGetEvent_String = new(this, "GetEvent", 0, typeof(System.String));
				}
				return r_MGetEvent_String;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo GetEvent(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetEvent_String_BindingFlags;
		public virtual RMethod RMGetEvent_String_BindingFlags
		{
			get
			{
				if(r_MGetEvent_String_BindingFlags == null)
				{
					r_MGetEvent_String_BindingFlags = new(this, "GetEvent", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
				}
				return r_MGetEvent_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo[] GetEvents()
		/// </summary>
		protected RMethod r_MGetEvents;
		public virtual RMethod RMGetEvents
		{
			get
			{
				if(r_MGetEvents == null)
				{
					r_MGetEvents = new(this, "GetEvents", 0);
				}
				return r_MGetEvents;
			}
		}

		/// <summary>
		/// System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetEvents_BindingFlags;
		public virtual RMethod RMGetEvents_BindingFlags
		{
			get
			{
				if(r_MGetEvents_BindingFlags == null)
				{
					r_MGetEvents_BindingFlags = new(this, "GetEvents", 0, typeof(System.Reflection.BindingFlags));
				}
				return r_MGetEvents_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetField(System.String)
		/// </summary>
		protected RMethod r_MGetField_String;
		public virtual RMethod RMGetField_String
		{
			get
			{
				if(r_MGetField_String == null)
				{
					r_MGetField_String = new(this, "GetField", 0, typeof(System.String));
				}
				return r_MGetField_String;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetField(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetField_String_BindingFlags;
		public virtual RMethod RMGetField_String_BindingFlags
		{
			get
			{
				if(r_MGetField_String_BindingFlags == null)
				{
					r_MGetField_String_BindingFlags = new(this, "GetField", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
				}
				return r_MGetField_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo[] GetFields()
		/// </summary>
		protected RMethod r_MGetFields;
		public virtual RMethod RMGetFields
		{
			get
			{
				if(r_MGetFields == null)
				{
					r_MGetFields = new(this, "GetFields", 0);
				}
				return r_MGetFields;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetFields_BindingFlags;
		public virtual RMethod RMGetFields_BindingFlags
		{
			get
			{
				if(r_MGetFields_BindingFlags == null)
				{
					r_MGetFields_BindingFlags = new(this, "GetFields", 0, typeof(System.Reflection.BindingFlags));
				}
				return r_MGetFields_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMember(System.String)
		/// </summary>
		protected RMethod r_MGetMember_String;
		public virtual RMethod RMGetMember_String
		{
			get
			{
				if(r_MGetMember_String == null)
				{
					r_MGetMember_String = new(this, "GetMember", 0, typeof(System.String));
				}
				return r_MGetMember_String;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMember(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetMember_String_BindingFlags;
		public virtual RMethod RMGetMember_String_BindingFlags
		{
			get
			{
				if(r_MGetMember_String_BindingFlags == null)
				{
					r_MGetMember_String_BindingFlags = new(this, "GetMember", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
				}
				return r_MGetMember_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMember(System.String, System.Reflection.MemberTypes, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetMember_String_MemberTypes_BindingFlags;
		public virtual RMethod RMGetMember_String_MemberTypes_BindingFlags
		{
			get
			{
				if(r_MGetMember_String_MemberTypes_BindingFlags == null)
				{
					r_MGetMember_String_MemberTypes_BindingFlags = new(this, "GetMember", 0, typeof(System.String), typeof(System.Reflection.MemberTypes), typeof(System.Reflection.BindingFlags));
				}
				return r_MGetMember_String_MemberTypes_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMembers()
		/// </summary>
		protected RMethod r_MGetMembers;
		public virtual RMethod RMGetMembers
		{
			get
			{
				if(r_MGetMembers == null)
				{
					r_MGetMembers = new(this, "GetMembers", 0);
				}
				return r_MGetMembers;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetMembers_BindingFlags;
		public virtual RMethod RMGetMembers_BindingFlags
		{
			get
			{
				if(r_MGetMembers_BindingFlags == null)
				{
					r_MGetMembers_BindingFlags = new(this, "GetMembers", 0, typeof(System.Reflection.BindingFlags));
				}
				return r_MGetMembers_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String)
		/// </summary>
		protected RMethod r_MGetMethod_String;
		public virtual RMethod RMGetMethod_String
		{
			get
			{
				if(r_MGetMethod_String == null)
				{
					r_MGetMethod_String = new(this, "GetMethod", 0, typeof(System.String));
				}
				return r_MGetMethod_String;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetMethod_String_BindingFlags;
		public virtual RMethod RMGetMethod_String_BindingFlags
		{
			get
			{
				if(r_MGetMethod_String_BindingFlags == null)
				{
					r_MGetMethod_String_BindingFlags = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
				}
				return r_MGetMethod_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Type[])
		/// </summary>
		protected RMethod r_MGetMethod_String_TypeArray;
		public virtual RMethod RMGetMethod_String_TypeArray
		{
			get
			{
				if(r_MGetMethod_String_TypeArray == null)
				{
					r_MGetMethod_String_TypeArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Type).MakeArrayType());
				}
				return r_MGetMethod_String_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetMethod_String_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetMethod_String_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetMethod_String_TypeArray_ParameterModifierArray == null)
				{
					r_MGetMethod_String_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
				}
				return r_MGetMethod_String_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray == null)
				{
					r_MGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
				}
				return r_MGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_MGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
				}
				return r_MGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethodImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_MGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethodImpl", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
				}
				return r_MGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, Int32, System.Type[])
		/// </summary>
		protected RMethod r_MGetMethod_String_Int32_TypeArray;
		public virtual RMethod RMGetMethod_String_Int32_TypeArray
		{
			get
			{
				if(r_MGetMethod_String_Int32_TypeArray == null)
				{
					r_MGetMethod_String_Int32_TypeArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Int32), typeof(System.Type).MakeArrayType());
				}
				return r_MGetMethod_String_Int32_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, Int32, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetMethod_String_Int32_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetMethod_String_Int32_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetMethod_String_Int32_TypeArray_ParameterModifierArray == null)
				{
					r_MGetMethod_String_Int32_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Int32), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
				}
				return r_MGetMethod_String_Int32_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray == null)
				{
					r_MGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
				}
				return r_MGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_MGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethod", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
				}
				return r_MGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethodImpl(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray == null)
				{
					r_MGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray = new(this, "GetMethodImpl", 0, typeof(System.String), typeof(System.Int32), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Reflection.CallingConventions), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
				}
				return r_MGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetMethods()
		/// </summary>
		protected RMethod r_MGetMethods;
		public virtual RMethod RMGetMethods
		{
			get
			{
				if(r_MGetMethods == null)
				{
					r_MGetMethods = new(this, "GetMethods", 0);
				}
				return r_MGetMethods;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetMethods_BindingFlags;
		public virtual RMethod RMGetMethods_BindingFlags
		{
			get
			{
				if(r_MGetMethods_BindingFlags == null)
				{
					r_MGetMethods_BindingFlags = new(this, "GetMethods", 0, typeof(System.Reflection.BindingFlags));
				}
				return r_MGetMethods_BindingFlags;
			}
		}

		/// <summary>
		/// System.Type GetNestedType(System.String)
		/// </summary>
		protected RMethod r_MGetNestedType_String;
		public virtual RMethod RMGetNestedType_String
		{
			get
			{
				if(r_MGetNestedType_String == null)
				{
					r_MGetNestedType_String = new(this, "GetNestedType", 0, typeof(System.String));
				}
				return r_MGetNestedType_String;
			}
		}

		/// <summary>
		/// System.Type GetNestedType(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetNestedType_String_BindingFlags;
		public virtual RMethod RMGetNestedType_String_BindingFlags
		{
			get
			{
				if(r_MGetNestedType_String_BindingFlags == null)
				{
					r_MGetNestedType_String_BindingFlags = new(this, "GetNestedType", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
				}
				return r_MGetNestedType_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Type[] GetNestedTypes()
		/// </summary>
		protected RMethod r_MGetNestedTypes;
		public virtual RMethod RMGetNestedTypes
		{
			get
			{
				if(r_MGetNestedTypes == null)
				{
					r_MGetNestedTypes = new(this, "GetNestedTypes", 0);
				}
				return r_MGetNestedTypes;
			}
		}

		/// <summary>
		/// System.Type[] GetNestedTypes(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetNestedTypes_BindingFlags;
		public virtual RMethod RMGetNestedTypes_BindingFlags
		{
			get
			{
				if(r_MGetNestedTypes_BindingFlags == null)
				{
					r_MGetNestedTypes_BindingFlags = new(this, "GetNestedTypes", 0, typeof(System.Reflection.BindingFlags));
				}
				return r_MGetNestedTypes_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String)
		/// </summary>
		protected RMethod r_MGetProperty_String;
		public virtual RMethod RMGetProperty_String
		{
			get
			{
				if(r_MGetProperty_String == null)
				{
					r_MGetProperty_String = new(this, "GetProperty", 0, typeof(System.String));
				}
				return r_MGetProperty_String;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetProperty_String_BindingFlags;
		public virtual RMethod RMGetProperty_String_BindingFlags
		{
			get
			{
				if(r_MGetProperty_String_BindingFlags == null)
				{
					r_MGetProperty_String_BindingFlags = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Reflection.BindingFlags));
				}
				return r_MGetProperty_String_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type)
		/// </summary>
		protected RMethod r_MGetProperty_String_Type;
		public virtual RMethod RMGetProperty_String_Type
		{
			get
			{
				if(r_MGetProperty_String_Type == null)
				{
					r_MGetProperty_String_Type = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Type));
				}
				return r_MGetProperty_String_Type;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type[])
		/// </summary>
		protected RMethod r_MGetProperty_String_TypeArray;
		public virtual RMethod RMGetProperty_String_TypeArray
		{
			get
			{
				if(r_MGetProperty_String_TypeArray == null)
				{
					r_MGetProperty_String_TypeArray = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Type).MakeArrayType());
				}
				return r_MGetProperty_String_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_MGetProperty_String_Type_TypeArray;
		public virtual RMethod RMGetProperty_String_Type_TypeArray
		{
			get
			{
				if(r_MGetProperty_String_Type_TypeArray == null)
				{
					r_MGetProperty_String_Type_TypeArray = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Type), typeof(System.Type).MakeArrayType());
				}
				return r_MGetProperty_String_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Type, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetProperty_String_Type_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetProperty_String_Type_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetProperty_String_Type_TypeArray_ParameterModifierArray == null)
				{
					r_MGetProperty_String_Type_TypeArray_ParameterModifierArray = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
				}
				return r_MGetProperty_String_Type_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetProperty(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray == null)
				{
					r_MGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray = new(this, "GetProperty", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
				}
				return r_MGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo GetPropertyImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])
		/// </summary>
		protected RMethod r_MGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray;
		public virtual RMethod RMGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray
		{
			get
			{
				if(r_MGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray == null)
				{
					r_MGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray = new(this, "GetPropertyImpl", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType());
				}
				return r_MGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo[] GetProperties()
		/// </summary>
		protected RMethod r_MGetProperties;
		public virtual RMethod RMGetProperties
		{
			get
			{
				if(r_MGetProperties == null)
				{
					r_MGetProperties = new(this, "GetProperties", 0);
				}
				return r_MGetProperties;
			}
		}

		/// <summary>
		/// System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags)
		/// </summary>
		protected RMethod r_MGetProperties_BindingFlags;
		public virtual RMethod RMGetProperties_BindingFlags
		{
			get
			{
				if(r_MGetProperties_BindingFlags == null)
				{
					r_MGetProperties_BindingFlags = new(this, "GetProperties", 0, typeof(System.Reflection.BindingFlags));
				}
				return r_MGetProperties_BindingFlags;
			}
		}

		/// <summary>
		/// System.Reflection.MemberInfo[] GetDefaultMembers()
		/// </summary>
		protected RMethod r_MGetDefaultMembers;
		public virtual RMethod RMGetDefaultMembers
		{
			get
			{
				if(r_MGetDefaultMembers == null)
				{
					r_MGetDefaultMembers = new(this, "GetDefaultMembers", 0);
				}
				return r_MGetDefaultMembers;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle GetTypeHandle(System.Object)
		/// </summary>
		protected static RMethod r_MGetTypeHandle_Object;
		public static RMethod RMGetTypeHandle_Object
		{
			get
			{
				if(r_MGetTypeHandle_Object == null)
				{
					r_MGetTypeHandle_Object = new(typeof(System.Type), "GetTypeHandle", 0, typeof(System.Object));
				}
				return r_MGetTypeHandle_Object;
			}
		}

		/// <summary>
		/// System.Type[] GetTypeArray(System.Object[])
		/// </summary>
		protected static RMethod r_MGetTypeArray_ObjectArray;
		public static RMethod RMGetTypeArray_ObjectArray
		{
			get
			{
				if(r_MGetTypeArray_ObjectArray == null)
				{
					r_MGetTypeArray_ObjectArray = new(typeof(System.Type), "GetTypeArray", 0, typeof(System.Object).MakeArrayType());
				}
				return r_MGetTypeArray_ObjectArray;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode(System.Type)
		/// </summary>
		protected static RMethod r_MGetTypeCode_Type;
		public static RMethod RMGetTypeCode_Type
		{
			get
			{
				if(r_MGetTypeCode_Type == null)
				{
					r_MGetTypeCode_Type = new(typeof(System.Type), "GetTypeCode", 0, typeof(System.Type));
				}
				return r_MGetTypeCode_Type;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCodeImpl()
		/// </summary>
		protected RMethod r_MGetTypeCodeImpl;
		public virtual RMethod RMGetTypeCodeImpl
		{
			get
			{
				if(r_MGetTypeCodeImpl == null)
				{
					r_MGetTypeCodeImpl = new(this, "GetTypeCodeImpl", 0);
				}
				return r_MGetTypeCodeImpl;
			}
		}

		/// <summary>
		/// System.Type GetTypeFromCLSID(System.Guid)
		/// </summary>
		protected static RMethod r_MGetTypeFromCLSID_Guid;
		public static RMethod RMGetTypeFromCLSID_Guid
		{
			get
			{
				if(r_MGetTypeFromCLSID_Guid == null)
				{
					r_MGetTypeFromCLSID_Guid = new(typeof(System.Type), "GetTypeFromCLSID", 0, typeof(System.Guid));
				}
				return r_MGetTypeFromCLSID_Guid;
			}
		}

		/// <summary>
		/// System.Type GetTypeFromCLSID(System.Guid, Boolean)
		/// </summary>
		protected static RMethod r_MGetTypeFromCLSID_Guid_Boolean;
		public static RMethod RMGetTypeFromCLSID_Guid_Boolean
		{
			get
			{
				if(r_MGetTypeFromCLSID_Guid_Boolean == null)
				{
					r_MGetTypeFromCLSID_Guid_Boolean = new(typeof(System.Type), "GetTypeFromCLSID", 0, typeof(System.Guid), typeof(System.Boolean));
				}
				return r_MGetTypeFromCLSID_Guid_Boolean;
			}
		}

		/// <summary>
		/// System.Type GetTypeFromCLSID(System.Guid, System.String)
		/// </summary>
		protected static RMethod r_MGetTypeFromCLSID_Guid_String;
		public static RMethod RMGetTypeFromCLSID_Guid_String
		{
			get
			{
				if(r_MGetTypeFromCLSID_Guid_String == null)
				{
					r_MGetTypeFromCLSID_Guid_String = new(typeof(System.Type), "GetTypeFromCLSID", 0, typeof(System.Guid), typeof(System.String));
				}
				return r_MGetTypeFromCLSID_Guid_String;
			}
		}

		/// <summary>
		/// System.Type GetTypeFromProgID(System.String)
		/// </summary>
		protected static RMethod r_MGetTypeFromProgID_String;
		public static RMethod RMGetTypeFromProgID_String
		{
			get
			{
				if(r_MGetTypeFromProgID_String == null)
				{
					r_MGetTypeFromProgID_String = new(typeof(System.Type), "GetTypeFromProgID", 0, typeof(System.String));
				}
				return r_MGetTypeFromProgID_String;
			}
		}

		/// <summary>
		/// System.Type GetTypeFromProgID(System.String, Boolean)
		/// </summary>
		protected static RMethod r_MGetTypeFromProgID_String_Boolean;
		public static RMethod RMGetTypeFromProgID_String_Boolean
		{
			get
			{
				if(r_MGetTypeFromProgID_String_Boolean == null)
				{
					r_MGetTypeFromProgID_String_Boolean = new(typeof(System.Type), "GetTypeFromProgID", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MGetTypeFromProgID_String_Boolean;
			}
		}

		/// <summary>
		/// System.Type GetTypeFromProgID(System.String, System.String)
		/// </summary>
		protected static RMethod r_MGetTypeFromProgID_String_String;
		public static RMethod RMGetTypeFromProgID_String_String
		{
			get
			{
				if(r_MGetTypeFromProgID_String_String == null)
				{
					r_MGetTypeFromProgID_String_String = new(typeof(System.Type), "GetTypeFromProgID", 0, typeof(System.String), typeof(System.String));
				}
				return r_MGetTypeFromProgID_String_String;
			}
		}

		/// <summary>
		/// System.Object InvokeMember(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Object[])
		/// </summary>
		protected RMethod r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray;
		public virtual RMethod RMInvokeMember_String_BindingFlags_Binder_Object_ObjectArray
		{
			get
			{
				if(r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray == null)
				{
					r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray = new(this, "InvokeMember", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object), typeof(System.Object).MakeArrayType());
				}
				return r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object InvokeMember(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo;
		public virtual RMethod RMInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo
		{
			get
			{
				if(r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo == null)
				{
					r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo = new(this, "InvokeMember", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
				}
				return r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo;
			}
		}

		/// <summary>
		/// System.Object InvokeMember(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Object[], System.Reflection.ParameterModifier[], System.Globalization.CultureInfo, System.String[])
		/// </summary>
		protected RMethod r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray;
		public virtual RMethod RMInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray
		{
			get
			{
				if(r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray == null)
				{
					r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray = new(this, "InvokeMember", 0, typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object), typeof(System.Object).MakeArrayType(), typeof(System.Reflection.ParameterModifier).MakeArrayType(), typeof(System.Globalization.CultureInfo), typeof(System.String).MakeArrayType());
				}
				return r_MInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray;
			}
		}

		/// <summary>
		/// System.Type GetInterface(System.String)
		/// </summary>
		protected RMethod r_MGetInterface_String;
		public virtual RMethod RMGetInterface_String
		{
			get
			{
				if(r_MGetInterface_String == null)
				{
					r_MGetInterface_String = new(this, "GetInterface", 0, typeof(System.String));
				}
				return r_MGetInterface_String;
			}
		}

		/// <summary>
		/// System.Type GetInterface(System.String, Boolean)
		/// </summary>
		protected RMethod r_MGetInterface_String_Boolean;
		public virtual RMethod RMGetInterface_String_Boolean
		{
			get
			{
				if(r_MGetInterface_String_Boolean == null)
				{
					r_MGetInterface_String_Boolean = new(this, "GetInterface", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MGetInterface_String_Boolean;
			}
		}

		/// <summary>
		/// System.Type[] GetInterfaces()
		/// </summary>
		protected RMethod r_MGetInterfaces;
		public virtual RMethod RMGetInterfaces
		{
			get
			{
				if(r_MGetInterfaces == null)
				{
					r_MGetInterfaces = new(this, "GetInterfaces", 0);
				}
				return r_MGetInterfaces;
			}
		}

		/// <summary>
		/// System.Reflection.InterfaceMapping GetInterfaceMap(System.Type)
		/// </summary>
		protected RMethod r_MGetInterfaceMap_Type;
		public virtual RMethod RMGetInterfaceMap_Type
		{
			get
			{
				if(r_MGetInterfaceMap_Type == null)
				{
					r_MGetInterfaceMap_Type = new(this, "GetInterfaceMap", 0, typeof(System.Type));
				}
				return r_MGetInterfaceMap_Type;
			}
		}

		/// <summary>
		/// Boolean IsInstanceOfType(System.Object)
		/// </summary>
		protected RMethod r_MIsInstanceOfType_Object;
		public virtual RMethod RMIsInstanceOfType_Object
		{
			get
			{
				if(r_MIsInstanceOfType_Object == null)
				{
					r_MIsInstanceOfType_Object = new(this, "IsInstanceOfType", 0, typeof(System.Object));
				}
				return r_MIsInstanceOfType_Object;
			}
		}

		/// <summary>
		/// Boolean IsEquivalentTo(System.Type)
		/// </summary>
		protected RMethod r_MIsEquivalentTo_Type;
		public virtual RMethod RMIsEquivalentTo_Type
		{
			get
			{
				if(r_MIsEquivalentTo_Type == null)
				{
					r_MIsEquivalentTo_Type = new(this, "IsEquivalentTo", 0, typeof(System.Type));
				}
				return r_MIsEquivalentTo_Type;
			}
		}

		/// <summary>
		/// System.Type GetEnumUnderlyingType()
		/// </summary>
		protected RMethod r_MGetEnumUnderlyingType;
		public virtual RMethod RMGetEnumUnderlyingType
		{
			get
			{
				if(r_MGetEnumUnderlyingType == null)
				{
					r_MGetEnumUnderlyingType = new(this, "GetEnumUnderlyingType", 0);
				}
				return r_MGetEnumUnderlyingType;
			}
		}

		/// <summary>
		/// System.Array GetEnumValues()
		/// </summary>
		protected RMethod r_MGetEnumValues;
		public virtual RMethod RMGetEnumValues
		{
			get
			{
				if(r_MGetEnumValues == null)
				{
					r_MGetEnumValues = new(this, "GetEnumValues", 0);
				}
				return r_MGetEnumValues;
			}
		}

		/// <summary>
		/// System.Type MakeArrayType()
		/// </summary>
		protected RMethod r_MMakeArrayType;
		public virtual RMethod RMMakeArrayType
		{
			get
			{
				if(r_MMakeArrayType == null)
				{
					r_MMakeArrayType = new(this, "MakeArrayType", 0);
				}
				return r_MMakeArrayType;
			}
		}

		/// <summary>
		/// System.Type MakeArrayType(Int32)
		/// </summary>
		protected RMethod r_MMakeArrayType_Int32;
		public virtual RMethod RMMakeArrayType_Int32
		{
			get
			{
				if(r_MMakeArrayType_Int32 == null)
				{
					r_MMakeArrayType_Int32 = new(this, "MakeArrayType", 0, typeof(System.Int32));
				}
				return r_MMakeArrayType_Int32;
			}
		}

		/// <summary>
		/// System.Type MakeByRefType()
		/// </summary>
		protected RMethod r_MMakeByRefType;
		public virtual RMethod RMMakeByRefType
		{
			get
			{
				if(r_MMakeByRefType == null)
				{
					r_MMakeByRefType = new(this, "MakeByRefType", 0);
				}
				return r_MMakeByRefType;
			}
		}

		/// <summary>
		/// System.Type MakeGenericType(System.Type[])
		/// </summary>
		protected RMethod r_MMakeGenericType_TypeArray;
		public virtual RMethod RMMakeGenericType_TypeArray
		{
			get
			{
				if(r_MMakeGenericType_TypeArray == null)
				{
					r_MMakeGenericType_TypeArray = new(this, "MakeGenericType", 0, typeof(System.Type).MakeArrayType());
				}
				return r_MMakeGenericType_TypeArray;
			}
		}

		/// <summary>
		/// System.Type MakePointerType()
		/// </summary>
		protected RMethod r_MMakePointerType;
		public virtual RMethod RMMakePointerType
		{
			get
			{
				if(r_MMakePointerType == null)
				{
					r_MMakePointerType = new(this, "MakePointerType", 0);
				}
				return r_MMakePointerType;
			}
		}

		/// <summary>
		/// System.Type MakeGenericSignatureType(System.Type, System.Type[])
		/// </summary>
		protected static RMethod r_MMakeGenericSignatureType_Type_TypeArray;
		public static RMethod RMMakeGenericSignatureType_Type_TypeArray
		{
			get
			{
				if(r_MMakeGenericSignatureType_Type_TypeArray == null)
				{
					r_MMakeGenericSignatureType_Type_TypeArray = new(typeof(System.Type), "MakeGenericSignatureType", 0, typeof(System.Type), typeof(System.Type).MakeArrayType());
				}
				return r_MMakeGenericSignatureType_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Type MakeGenericMethodParameter(Int32)
		/// </summary>
		protected static RMethod r_MMakeGenericMethodParameter_Int32;
		public static RMethod RMMakeGenericMethodParameter_Int32
		{
			get
			{
				if(r_MMakeGenericMethodParameter_Int32 == null)
				{
					r_MMakeGenericMethodParameter_Int32 = new(typeof(System.Type), "MakeGenericMethodParameter", 0, typeof(System.Int32));
				}
				return r_MMakeGenericMethodParameter_Int32;
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
		/// Boolean Equals(System.Type)
		/// </summary>
		protected RMethod r_MEquals_Type;
		public virtual RMethod RMEquals_Type
		{
			get
			{
				if(r_MEquals_Type == null)
				{
					r_MEquals_Type = new(this, "Equals", 0, typeof(System.Type));
				}
				return r_MEquals_Type;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Type.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___Type__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___Type__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___Type__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___Type__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._Type.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___Type__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Type.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._Type.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Type.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._Type.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._Type.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___Type__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___Type__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___Type__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___Type__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._Type.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___Type__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// System.Type InternalResolve()
		/// </summary>
		protected RMethod r_MInternalResolve;
		public virtual RMethod RMInternalResolve
		{
			get
			{
				if(r_MInternalResolve == null)
				{
					r_MInternalResolve = new(this, "InternalResolve", 0);
				}
				return r_MInternalResolve;
			}
		}

		/// <summary>
		/// System.Type RuntimeResolve()
		/// </summary>
		protected RMethod r_MRuntimeResolve;
		public virtual RMethod RMRuntimeResolve
		{
			get
			{
				if(r_MRuntimeResolve == null)
				{
					r_MRuntimeResolve = new(this, "RuntimeResolve", 0);
				}
				return r_MRuntimeResolve;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetMethod(System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_MGetMethod_MethodInfo;
		public virtual RMethod RMGetMethod_MethodInfo
		{
			get
			{
				if(r_MGetMethod_MethodInfo == null)
				{
					r_MGetMethod_MethodInfo = new(this, "GetMethod", 0, typeof(System.Reflection.MethodInfo));
				}
				return r_MGetMethod_MethodInfo;
			}
		}

		/// <summary>
		/// System.Reflection.ConstructorInfo GetConstructor(System.Reflection.ConstructorInfo)
		/// </summary>
		protected RMethod r_MGetConstructor_ConstructorInfo;
		public virtual RMethod RMGetConstructor_ConstructorInfo
		{
			get
			{
				if(r_MGetConstructor_ConstructorInfo == null)
				{
					r_MGetConstructor_ConstructorInfo = new(this, "GetConstructor", 0, typeof(System.Reflection.ConstructorInfo));
				}
				return r_MGetConstructor_ConstructorInfo;
			}
		}

		/// <summary>
		/// System.Reflection.FieldInfo GetField(System.Reflection.FieldInfo)
		/// </summary>
		protected RMethod r_MGetField_FieldInfo;
		public virtual RMethod RMGetField_FieldInfo
		{
			get
			{
				if(r_MGetField_FieldInfo == null)
				{
					r_MGetField_FieldInfo = new(this, "GetField", 0, typeof(System.Reflection.FieldInfo));
				}
				return r_MGetField_FieldInfo;
			}
		}

		/// <summary>
		/// System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
		/// </summary>
		protected static RMethod r_MGetTypeFromHandle_RuntimeTypeHandle;
		public static RMethod RMGetTypeFromHandle_RuntimeTypeHandle
		{
			get
			{
				if(r_MGetTypeFromHandle_RuntimeTypeHandle == null)
				{
					r_MGetTypeFromHandle_RuntimeTypeHandle = new(typeof(System.Type), "GetTypeFromHandle", 0, typeof(System.RuntimeTypeHandle));
				}
				return r_MGetTypeFromHandle_RuntimeTypeHandle;
			}
		}

		/// <summary>
		/// System.Type internal_from_handle(IntPtr)
		/// </summary>
		protected static RMethod r_Minternal_from_handle_IntPtr;
		public static RMethod RMinternal_from_handle_IntPtr
		{
			get
			{
				if(r_Minternal_from_handle_IntPtr == null)
				{
					r_Minternal_from_handle_IntPtr = new(typeof(System.Type), "internal_from_handle", 0, typeof(System.IntPtr));
				}
				return r_Minternal_from_handle_IntPtr;
			}
		}

		/// <summary>
		/// System.RuntimeTypeHandle GetTypeHandleInternal()
		/// </summary>
		protected RMethod r_MGetTypeHandleInternal;
		public virtual RMethod RMGetTypeHandleInternal
		{
			get
			{
				if(r_MGetTypeHandleInternal == null)
				{
					r_MGetTypeHandleInternal = new(this, "GetTypeHandleInternal", 0);
				}
				return r_MGetTypeHandleInternal;
			}
		}

		/// <summary>
		/// Boolean IsWindowsRuntimeObjectImpl()
		/// </summary>
		protected RMethod r_MIsWindowsRuntimeObjectImpl;
		public virtual RMethod RMIsWindowsRuntimeObjectImpl
		{
			get
			{
				if(r_MIsWindowsRuntimeObjectImpl == null)
				{
					r_MIsWindowsRuntimeObjectImpl = new(this, "IsWindowsRuntimeObjectImpl", 0);
				}
				return r_MIsWindowsRuntimeObjectImpl;
			}
		}

		/// <summary>
		/// Boolean IsExportedToWindowsRuntimeImpl()
		/// </summary>
		protected RMethod r_MIsExportedToWindowsRuntimeImpl;
		public virtual RMethod RMIsExportedToWindowsRuntimeImpl
		{
			get
			{
				if(r_MIsExportedToWindowsRuntimeImpl == null)
				{
					r_MIsExportedToWindowsRuntimeImpl = new(this, "IsExportedToWindowsRuntimeImpl", 0);
				}
				return r_MIsExportedToWindowsRuntimeImpl;
			}
		}

		/// <summary>
		/// Boolean HasProxyAttributeImpl()
		/// </summary>
		protected RMethod r_MHasProxyAttributeImpl;
		public virtual RMethod RMHasProxyAttributeImpl
		{
			get
			{
				if(r_MHasProxyAttributeImpl == null)
				{
					r_MHasProxyAttributeImpl = new(this, "HasProxyAttributeImpl", 0);
				}
				return r_MHasProxyAttributeImpl;
			}
		}

		/// <summary>
		/// System.String FormatTypeName()
		/// </summary>
		protected RMethod r_MFormatTypeName;
		public virtual RMethod RMFormatTypeName
		{
			get
			{
				if(r_MFormatTypeName == null)
				{
					r_MFormatTypeName = new(this, "FormatTypeName", 0);
				}
				return r_MFormatTypeName;
			}
		}

		/// <summary>
		/// System.String FormatTypeName(Boolean)
		/// </summary>
		protected RMethod r_MFormatTypeName_Boolean;
		public virtual RMethod RMFormatTypeName_Boolean
		{
			get
			{
				if(r_MFormatTypeName_Boolean == null)
				{
					r_MFormatTypeName_Boolean = new(this, "FormatTypeName", 0, typeof(System.Boolean));
				}
				return r_MFormatTypeName_Boolean;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_MGetType_String_Boolean_Boolean;
		public static RMethod RMGetType_String_Boolean_Boolean
		{
			get
			{
				if(r_MGetType_String_Boolean_Boolean == null)
				{
					r_MGetType_String_Boolean_Boolean = new(typeof(System.Type), "GetType", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MGetType_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String, Boolean)
		/// </summary>
		protected static RMethod r_MGetType_String_Boolean;
		public static RMethod RMGetType_String_Boolean
		{
			get
			{
				if(r_MGetType_String_Boolean == null)
				{
					r_MGetType_String_Boolean = new(typeof(System.Type), "GetType", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MGetType_String_Boolean;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String)
		/// </summary>
		protected static RMethod r_MGetType_String;
		public static RMethod RMGetType_String
		{
			get
			{
				if(r_MGetType_String == null)
				{
					r_MGetType_String = new(typeof(System.Type), "GetType", 0, typeof(System.String));
				}
				return r_MGetType_String;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String, System.Func`2[System.Reflection.AssemblyName,System.Reflection.Assembly], System.Func`4[System.Reflection.Assembly,System.String,System.Boolean,System.Type])
		/// </summary>
		protected static RMethod r_MGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p_;
		public static RMethod RMGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p_
		{
			get
			{
				if(r_MGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p_ == null)
				{
					r_MGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p_ = new(typeof(System.Type), "GetType", 0, typeof(System.String),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Assembly)),  ReflectionUtils.GetType("System.Func`4").MakeGenericType(typeof(System.Reflection.Assembly), typeof(System.String), typeof(System.Boolean), typeof(System.Type)));
				}
				return r_MGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p_;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String, System.Func`2[System.Reflection.AssemblyName,System.Reflection.Assembly], System.Func`4[System.Reflection.Assembly,System.String,System.Boolean,System.Type], Boolean)
		/// </summary>
		protected static RMethod r_MGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean;
		public static RMethod RMGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean
		{
			get
			{
				if(r_MGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean == null)
				{
					r_MGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean = new(typeof(System.Type), "GetType", 0, typeof(System.String),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Assembly)),  ReflectionUtils.GetType("System.Func`4").MakeGenericType(typeof(System.Reflection.Assembly), typeof(System.String), typeof(System.Boolean), typeof(System.Type)), typeof(System.Boolean));
				}
				return r_MGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean;
			}
		}

		/// <summary>
		/// System.Type GetType(System.String, System.Func`2[System.Reflection.AssemblyName,System.Reflection.Assembly], System.Func`4[System.Reflection.Assembly,System.String,System.Boolean,System.Type], Boolean, Boolean)
		/// </summary>
		protected static RMethod r_MGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean_Boolean;
		public static RMethod RMGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean_Boolean
		{
			get
			{
				if(r_MGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean_Boolean == null)
				{
					r_MGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean_Boolean = new(typeof(System.Type), "GetType", 0, typeof(System.String),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Reflection.AssemblyName), typeof(System.Reflection.Assembly)),  ReflectionUtils.GetType("System.Func`4").MakeGenericType(typeof(System.Reflection.Assembly), typeof(System.String), typeof(System.Boolean), typeof(System.Type)), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean_Boolean;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Type, System.Type)
		/// </summary>
		protected static RMethod r_Mop_Equality_Type_Type;
		public static RMethod RMop_Equality_Type_Type
		{
			get
			{
				if(r_Mop_Equality_Type_Type == null)
				{
					r_Mop_Equality_Type_Type = new(typeof(System.Type), "op_Equality", 0, typeof(System.Type), typeof(System.Type));
				}
				return r_Mop_Equality_Type_Type;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Type, System.Type)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Type_Type;
		public static RMethod RMop_Inequality_Type_Type
		{
			get
			{
				if(r_Mop_Inequality_Type_Type == null)
				{
					r_Mop_Inequality_Type_Type = new(typeof(System.Type), "op_Inequality", 0, typeof(System.Type), typeof(System.Type));
				}
				return r_Mop_Inequality_Type_Type;
			}
		}

		/// <summary>
		/// System.Type ReflectionOnlyGetType(System.String, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_MReflectionOnlyGetType_String_Boolean_Boolean;
		public static RMethod RMReflectionOnlyGetType_String_Boolean_Boolean
		{
			get
			{
				if(r_MReflectionOnlyGetType_String_Boolean_Boolean == null)
				{
					r_MReflectionOnlyGetType_String_Boolean_Boolean = new(typeof(System.Type), "ReflectionOnlyGetType", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
				}
				return r_MReflectionOnlyGetType_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Type GetTypeFromCLSID(System.Guid, System.String, Boolean)
		/// </summary>
		protected static RMethod r_MGetTypeFromCLSID_Guid_String_Boolean;
		public static RMethod RMGetTypeFromCLSID_Guid_String_Boolean
		{
			get
			{
				if(r_MGetTypeFromCLSID_Guid_String_Boolean == null)
				{
					r_MGetTypeFromCLSID_Guid_String_Boolean = new(typeof(System.Type), "GetTypeFromCLSID", 0, typeof(System.Guid), typeof(System.String), typeof(System.Boolean));
				}
				return r_MGetTypeFromCLSID_Guid_String_Boolean;
			}
		}

		/// <summary>
		/// System.Type GetTypeFromProgID(System.String, System.String, Boolean)
		/// </summary>
		protected static RMethod r_MGetTypeFromProgID_String_String_Boolean;
		public static RMethod RMGetTypeFromProgID_String_String_Boolean
		{
			get
			{
				if(r_MGetTypeFromProgID_String_String_Boolean == null)
				{
					r_MGetTypeFromProgID_String_String_Boolean = new(typeof(System.Type), "GetTypeFromProgID", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean));
				}
				return r_MGetTypeFromProgID_String_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsRuntimeImplemented()
		/// </summary>
		protected RMethod r_MIsRuntimeImplemented;
		public virtual RMethod RMIsRuntimeImplemented
		{
			get
			{
				if(r_MIsRuntimeImplemented == null)
				{
					r_MIsRuntimeImplemented = new(this, "IsRuntimeImplemented", 0);
				}
				return r_MIsRuntimeImplemented;
			}
		}

		/// <summary>
		/// System.String InternalGetNameIfAvailable(System.Type ByRef)
		/// </summary>
		protected RMethod r_MInternalGetNameIfAvailable_Ref_Type;
		public virtual RMethod RMInternalGetNameIfAvailable_Ref_Type
		{
			get
			{
				if(r_MInternalGetNameIfAvailable_Ref_Type == null)
				{
					r_MInternalGetNameIfAvailable_Ref_Type = new(this, "InternalGetNameIfAvailable", 0, typeof(System.Type).MakeByRefType());
				}
				return r_MInternalGetNameIfAvailable_Ref_Type;
			}
		}

		/// <summary>
		/// System.Reflection.Module get_Module()
		/// </summary>
		protected RMethod r_Mget_Module;
		public virtual RMethod RMget_Module
		{
			get
			{
				if(r_Mget_Module == null)
				{
					r_Mget_Module = new(this, "get_Module", 0);
				}
				return r_Mget_Module;
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


        public virtual System.Boolean IsEnumDefined(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMIsEnumDefined_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetEnumName(System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMGetEnumName_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String[] GetEnumNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }


        public virtual System.Array GetEnumRawConstantValues()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumRawConstantValues.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public virtual void GetEnumData(out System.String[] @enumNames, out System.Array @enumValues)
        {
			@enumNames = default;
			@enumValues = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enumNames, @enumValues};
            var ___result = RMGetEnumData_Out_StringArray_Out_Array.Invoke(___genericsType, ___parameters);
			@enumNames = (System.String[])___parameters[0];
			@enumValues = (System.Array)___parameters[1];

            
        }


        public static System.Int32 BinarySearch(System.Array @array, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @value};
            var ___result = RMBinarySearch_Array_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean IsIntegerType(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMIsIntegerType_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Type GetRootElementType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRootElementType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type[] FindInterfaces(System.Reflection.TypeFilter @filter, System.Object @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@filter, @filterCriteria};
            var ___result = RMFindInterfaces_TypeFilter_Object.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.MemberInfo[] FindMembers(System.Reflection.MemberTypes @memberType, System.Reflection.BindingFlags @bindingAttr, System.Reflection.MemberFilter @filter, System.Object @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@memberType, @bindingAttr, @filter, @filterCriteria};
            var ___result = RMFindMembers_MemberTypes_BindingFlags_MemberFilter_Object.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Boolean IsSubclassOf(System.Type @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMIsSubclassOf_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsAssignableFrom(System.Type @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RMIsAssignableFrom_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ImplementInterface(System.Type @ifaceType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ifaceType};
            var ___result = RMImplementInterface_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean FilterAttributeImpl(System.Reflection.MemberInfo @m, System.Object @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m, @filterCriteria};
            var ___result = RMFilterAttributeImpl_MemberInfo_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean FilterNameImpl(System.Reflection.MemberInfo @m, System.Object @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m, @filterCriteria};
            var ___result = RMFilterNameImpl_MemberInfo_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean FilterNameIgnoreCaseImpl(System.Reflection.MemberInfo @m, System.Object @filterCriteria)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m, @filterCriteria};
            var ___result = RMFilterNameIgnoreCaseImpl_MemberInfo_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Boolean IsArrayImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsArrayImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsByRefImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsByRefImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsPointerImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsPointerImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasElementTypeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasElementTypeImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Type GetElementType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetElementType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Int32 GetArrayRank()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetArrayRank.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Type GetGenericTypeDefinition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGenericTypeDefinition.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type[] GetGenericArguments()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGenericArguments.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type[] GetGenericParameterConstraints()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGenericParameterConstraints.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.TypeAttributes GetAttributeFlagsImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAttributeFlagsImpl.Invoke(___genericsType, ___parameters);

            return (System.Reflection.TypeAttributes)___result;
        }


        public virtual System.Boolean IsCOMObjectImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsCOMObjectImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsContextfulImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsContextfulImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsMarshalByRefImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsMarshalByRefImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsPrimitiveImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsPrimitiveImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsValueTypeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsValueTypeImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Reflection.ConstructorInfo GetConstructor(System.Type[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@types};
            var ___result = RMGetConstructor_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public virtual System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @binder, @types, @modifiers};
            var ___result = RMGetConstructor_BindingFlags_Binder_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public virtual System.Reflection.ConstructorInfo GetConstructor(System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RMGetConstructor_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public virtual System.Reflection.ConstructorInfo GetConstructorImpl(System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RMGetConstructorImpl_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public virtual System.Reflection.ConstructorInfo[] GetConstructors()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetConstructors.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo[])___result;
        }


        public virtual System.Reflection.ConstructorInfo[] GetConstructors(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RMGetConstructors_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo[])___result;
        }


        public virtual System.Reflection.EventInfo GetEvent(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetEvent_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo)___result;
        }


        public virtual System.Reflection.EventInfo GetEvent(System.String @name, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RMGetEvent_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo)___result;
        }


        public virtual System.Reflection.EventInfo[] GetEvents()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEvents.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo[])___result;
        }


        public virtual System.Reflection.EventInfo[] GetEvents(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RMGetEvents_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.EventInfo[])___result;
        }


        public virtual System.Reflection.FieldInfo GetField(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetField_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.FieldInfo GetField(System.String @name, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RMGetField_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public virtual System.Reflection.FieldInfo[] GetFields()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetFields.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo[])___result;
        }


        public virtual System.Reflection.FieldInfo[] GetFields(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RMGetFields_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetMember(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetMember_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetMember(System.String @name, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RMGetMember_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetMember(System.String @name, System.Reflection.MemberTypes @type, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @type, @bindingAttr};
            var ___result = RMGetMember_String_MemberTypes_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetMembers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMembers.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetMembers(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RMGetMembers_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetMethod_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RMGetMethod_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Type[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @types};
            var ___result = RMGetMethod_String_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @types, @modifiers};
            var ___result = RMGetMethod_String_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @types, @modifiers};
            var ___result = RMGetMethod_String_BindingFlags_Binder_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RMGetMethod_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethodImpl(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RMGetMethodImpl_String_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Int32 @genericParameterCount, System.Type[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @genericParameterCount, @types};
            var ___result = RMGetMethod_String_Int32_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Int32 @genericParameterCount, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @genericParameterCount, @types, @modifiers};
            var ___result = RMGetMethod_String_Int32_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Int32 @genericParameterCount, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @genericParameterCount, @bindingAttr, @binder, @types, @modifiers};
            var ___result = RMGetMethod_String_Int32_BindingFlags_Binder_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.String @name, System.Int32 @genericParameterCount, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @genericParameterCount, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RMGetMethod_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethodImpl(System.String @name, System.Int32 @genericParameterCount, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Reflection.CallingConventions @callConvention, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @genericParameterCount, @bindingAttr, @binder, @callConvention, @types, @modifiers};
            var ___result = RMGetMethodImpl_String_Int32_BindingFlags_Binder_CallingConventions_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo[] GetMethods()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMethods.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Reflection.MethodInfo[] GetMethods(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RMGetMethods_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo[])___result;
        }


        public virtual System.Type GetNestedType(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetNestedType_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type GetNestedType(System.String @name, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RMGetNestedType_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type[] GetNestedTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNestedTypes.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Type[] GetNestedTypes(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RMGetNestedTypes_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetProperty_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String @name, System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr};
            var ___result = RMGetProperty_String_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String @name, System.Type @returnType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @returnType};
            var ___result = RMGetProperty_String_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String @name, System.Type[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @types};
            var ___result = RMGetProperty_String_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String @name, System.Type @returnType, System.Type[] @types)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @returnType, @types};
            var ___result = RMGetProperty_String_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String @name, System.Type @returnType, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @returnType, @types, @modifiers};
            var ___result = RMGetProperty_String_Type_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetProperty(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Type @returnType, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @returnType, @types, @modifiers};
            var ___result = RMGetProperty_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo GetPropertyImpl(System.String @name, System.Reflection.BindingFlags @bindingAttr, System.Reflection.Binder @binder, System.Type @returnType, System.Type[] @types, System.Reflection.ParameterModifier[] @modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @bindingAttr, @binder, @returnType, @types, @modifiers};
            var ___result = RMGetPropertyImpl_String_BindingFlags_Binder_Type_TypeArray_ParameterModifierArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo)___result;
        }


        public virtual System.Reflection.PropertyInfo[] GetProperties()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetProperties.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo[])___result;
        }


        public virtual System.Reflection.PropertyInfo[] GetProperties(System.Reflection.BindingFlags @bindingAttr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bindingAttr};
            var ___result = RMGetProperties_BindingFlags.Invoke(___genericsType, ___parameters);

            return (System.Reflection.PropertyInfo[])___result;
        }


        public virtual System.Reflection.MemberInfo[] GetDefaultMembers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetDefaultMembers.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MemberInfo[])___result;
        }


        public static System.RuntimeTypeHandle GetTypeHandle(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMGetTypeHandle_Object.Invoke(___genericsType, ___parameters);

            return (System.RuntimeTypeHandle)___result;
        }


        public static System.Type[] GetTypeArray(System.Object[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RMGetTypeArray_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public static System.TypeCode GetTypeCode(System.Type @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RMGetTypeCode_Type.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
        }


        public virtual System.TypeCode GetTypeCodeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCodeImpl.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
        }


        public static System.Type GetTypeFromCLSID(System.Guid @clsid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clsid};
            var ___result = RMGetTypeFromCLSID_Guid.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetTypeFromCLSID(System.Guid @clsid, System.Boolean @throwOnError)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clsid, @throwOnError};
            var ___result = RMGetTypeFromCLSID_Guid_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetTypeFromCLSID(System.Guid @clsid, System.String @server)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clsid, @server};
            var ___result = RMGetTypeFromCLSID_Guid_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetTypeFromProgID(System.String @progID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@progID};
            var ___result = RMGetTypeFromProgID_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetTypeFromProgID(System.String @progID, System.Boolean @throwOnError)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@progID, @throwOnError};
            var ___result = RMGetTypeFromProgID_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetTypeFromProgID(System.String @progID, System.String @server)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@progID, @server};
            var ___result = RMGetTypeFromProgID_String_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object InvokeMember(System.String @name, System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Object @target, System.Object[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @invokeAttr, @binder, @target, @args};
            var ___result = RMInvokeMember_String_BindingFlags_Binder_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object InvokeMember(System.String @name, System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Object @target, System.Object[] @args, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @invokeAttr, @binder, @target, @args, @culture};
            var ___result = RMInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object InvokeMember(System.String @name, System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Object @target, System.Object[] @args, System.Reflection.ParameterModifier[] @modifiers, System.Globalization.CultureInfo @culture, System.String[] @namedParameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @invokeAttr, @binder, @target, @args, @modifiers, @culture, @namedParameters};
            var ___result = RMInvokeMember_String_BindingFlags_Binder_Object_ObjectArray_ParameterModifierArray_CultureInfo_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Type GetInterface(System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMGetInterface_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type GetInterface(System.String @name, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ignoreCase};
            var ___result = RMGetInterface_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type[] GetInterfaces()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInterfaces.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.InterfaceMapping GetInterfaceMap(System.Type @interfaceType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@interfaceType};
            var ___result = RMGetInterfaceMap_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.InterfaceMapping)___result;
        }


        public virtual System.Boolean IsInstanceOfType(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMIsInstanceOfType_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsEquivalentTo(System.Type @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMIsEquivalentTo_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Type GetEnumUnderlyingType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumUnderlyingType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Array GetEnumValues()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetEnumValues.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
        }


        public virtual System.Type MakeArrayType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMakeArrayType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type MakeArrayType(System.Int32 @rank)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rank};
            var ___result = RMMakeArrayType_Int32.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type MakeByRefType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMakeByRefType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type MakeGenericType(System.Type[] @typeArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeArguments};
            var ___result = RMMakeGenericType_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type MakePointerType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMakePointerType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type MakeGenericSignatureType(System.Type @genericTypeDefinition, System.Type[] @typeArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@genericTypeDefinition, @typeArguments};
            var ___result = RMMakeGenericSignatureType_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type MakeGenericMethodParameter(System.Int32 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RMMakeGenericMethodParameter_Int32.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
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


        public virtual System.Boolean Equals(System.Type @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMEquals_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void System__2__Runtime__2__InteropServices__2___Type__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___Type__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___Type__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___Type__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___Type__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type InternalResolve()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalResolve.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Type RuntimeResolve()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRuntimeResolve.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Reflection.MethodInfo GetMethod(System.Reflection.MethodInfo @fromNoninstanciated)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromNoninstanciated};
            var ___result = RMGetMethod_MethodInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.ConstructorInfo GetConstructor(System.Reflection.ConstructorInfo @fromNoninstanciated)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromNoninstanciated};
            var ___result = RMGetConstructor_ConstructorInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.ConstructorInfo)___result;
        }


        public virtual System.Reflection.FieldInfo GetField(System.Reflection.FieldInfo @fromNoninstanciated)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromNoninstanciated};
            var ___result = RMGetField_FieldInfo.Invoke(___genericsType, ___parameters);

            return (System.Reflection.FieldInfo)___result;
        }


        public static System.Type GetTypeFromHandle(System.RuntimeTypeHandle @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMGetTypeFromHandle_RuntimeTypeHandle.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type internal_from_handle(System.IntPtr @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RMinternal_from_handle_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.RuntimeTypeHandle GetTypeHandleInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeHandleInternal.Invoke(___genericsType, ___parameters);

            return (System.RuntimeTypeHandle)___result;
        }


        public virtual System.Boolean IsWindowsRuntimeObjectImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsWindowsRuntimeObjectImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsExportedToWindowsRuntimeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsExportedToWindowsRuntimeImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasProxyAttributeImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasProxyAttributeImpl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String FormatTypeName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFormatTypeName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String FormatTypeName(System.Boolean @serialization)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serialization};
            var ___result = RMFormatTypeName_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Type GetType(System.String @typeName, System.Boolean @throwOnError, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @throwOnError, @ignoreCase};
            var ___result = RMGetType_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetType(System.String @typeName, System.Boolean @throwOnError)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @throwOnError};
            var ___result = RMGetType_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetType(System.String @typeName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName};
            var ___result = RMGetType_String.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetType(System.String @typeName, System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly> @assemblyResolver, System.Func<System.Reflection.Assembly, System.String, System.Boolean, System.Type> @typeResolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @assemblyResolver, @typeResolver};
            var ___result = RMGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p_.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetType(System.String @typeName, System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly> @assemblyResolver, System.Func<System.Reflection.Assembly, System.String, System.Boolean, System.Type> @typeResolver, System.Boolean @throwOnError)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @assemblyResolver, @typeResolver, @throwOnError};
            var ___result = RMGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetType(System.String @typeName, System.Func<System.Reflection.AssemblyName, System.Reflection.Assembly> @assemblyResolver, System.Func<System.Reflection.Assembly, System.String, System.Boolean, System.Type> @typeResolver, System.Boolean @throwOnError, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @assemblyResolver, @typeResolver, @throwOnError, @ignoreCase};
            var ___result = RMGetType_String_Func_d_AssemblyName_Assembly_p__Func_d_Assembly_String_Boolean_Type_p__Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Boolean op_Equality(System.Type @left, System.Type @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_Type_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Type @left, System.Type @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_Type_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Type ReflectionOnlyGetType(System.String @typeName, System.Boolean @throwIfNotFound, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeName, @throwIfNotFound, @ignoreCase};
            var ___result = RMReflectionOnlyGetType_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetTypeFromCLSID(System.Guid @clsid, System.String @server, System.Boolean @throwOnError)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clsid, @server, @throwOnError};
            var ___result = RMGetTypeFromCLSID_Guid_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Type GetTypeFromProgID(System.String @progID, System.String @server, System.Boolean @throwOnError)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@progID, @server, @throwOnError};
            var ___result = RMGetTypeFromProgID_String_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Boolean IsRuntimeImplemented()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsRuntimeImplemented.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String InternalGetNameIfAvailable(ref System.Type @rootCauseForFailure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rootCauseForFailure};
            var ___result = RMInternalGetNameIfAvailable_Ref_Type.Invoke(___genericsType, ___parameters);
			@rootCauseForFailure = (System.Type)___parameters[0];

            return (System.String)___result;
        }


        public virtual System.Reflection.Module get_Module()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMget_Module.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module)___result;
        }


        public virtual System.Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMHasSameMetadataDefinitionAs_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
