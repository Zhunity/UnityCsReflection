
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Reflection.Emit.ConstructorBuilder
	/// </summary>
    public partial class RConstructorBuilder : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Reflection.Emit.ConstructorBuilder);
            }
        }

        public RConstructorBuilder() : base("System.Reflection.Emit.ConstructorBuilder")
        {
        }

        public RConstructorBuilder(System.Object instance) : base("System.Reflection.Emit.ConstructorBuilder")
		{
            SetInstance(instance);
		}

        public RConstructorBuilder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RConstructorBuilder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.RuntimeMethodHandle mhandle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntimeMethodHandle r_Fmhandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntimeMethodHandle RFmhandle
		{
			get
			{
				if(r_Fmhandle == null)
				{
					r_Fmhandle = new(this, "mhandle");
				}
				return r_Fmhandle;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ILGenerator ilgen
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RILGenerator r_Filgen;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RILGenerator RFilgen
		{
			get
			{
				if(r_Filgen == null)
				{
					r_Filgen = new(this, "ilgen");
				}
				return r_Filgen;
			}
		}

		/// <summary>
		/// System.Type[] parameters
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType> r_Fparameters;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType> RFparameters
		{
			get
			{
				if(r_Fparameters == null)
				{
					r_Fparameters = new(this, "parameters");
				}
				return r_Fparameters;
			}
		}

		/// <summary>
		/// System.Reflection.MethodAttributes attrs
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_Fattrs;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFattrs
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
		/// System.Reflection.MethodImplAttributes iattrs
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes r_Fiattrs;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes RFiattrs
		{
			get
			{
				if(r_Fiattrs == null)
				{
					r_Fiattrs = new(this, "iattrs");
				}
				return r_Fiattrs;
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
		/// System.Reflection.CallingConventions call_conv
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RCallingConventions r_Fcall_conv;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RCallingConventions RFcall_conv
		{
			get
			{
				if(r_Fcall_conv == null)
				{
					r_Fcall_conv = new(this, "call_conv");
				}
				return r_Fcall_conv;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RTypeBuilder r_Ftype;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RTypeBuilder RFtype
		{
			get
			{
				if(r_Ftype == null)
				{
					r_Ftype = new(this, "type");
				}
				return r_Ftype;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ParameterBuilder[] pinfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RParameterBuilder> r_Fpinfo;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RParameterBuilder> RFpinfo
		{
			get
			{
				if(r_Fpinfo == null)
				{
					r_Fpinfo = new(this, "pinfo");
				}
				return r_Fpinfo;
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
		/// System.Boolean init_locals
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Finit_locals;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFinit_locals
		{
			get
			{
				if(r_Finit_locals == null)
				{
					r_Finit_locals = new(this, "init_locals");
				}
				return r_Finit_locals;
			}
		}

		/// <summary>
		/// System.Type[][] paramModReq
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType>> r_FparamModReq;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType>> RFparamModReq
		{
			get
			{
				if(r_FparamModReq == null)
				{
					r_FparamModReq = new(this, "paramModReq");
				}
				return r_FparamModReq;
			}
		}

		/// <summary>
		/// System.Type[][] paramModOpt
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType>> r_FparamModOpt;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType>> RFparamModOpt
		{
			get
			{
				if(r_FparamModOpt == null)
				{
					r_FparamModOpt = new(this, "paramModOpt");
				}
				return r_FparamModOpt;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.RefEmitPermissionSet[] permissions
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RRefEmitPermissionSet> r_Fpermissions;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RRefEmitPermissionSet> RFpermissions
		{
			get
			{
				if(r_Fpermissions == null)
				{
					r_Fpermissions = new(this, "permissions");
				}
				return r_Fpermissions;
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
				}
				return r_PCallingConvention;
			}
		}

		/// <summary>
		/// Boolean InitLocals
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PInitLocals;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPInitLocals
		{
			get
			{
				if(r_PInitLocals == null)
				{
					r_PInitLocals = new(this, "InitLocals", -1);
				}
				return r_PInitLocals;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder TypeBuilder
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RTypeBuilder r_PTypeBuilder;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RTypeBuilder RPTypeBuilder
		{
			get
			{
				if(r_PTypeBuilder == null)
				{
					r_PTypeBuilder = new(this, "TypeBuilder", -1);
				}
				return r_PTypeBuilder;
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
				}
				return r_PAttributes;
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
				}
				return r_PReturnType;
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
		/// System.String Signature
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PSignature;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPSignature
		{
			get
			{
				if(r_PSignature == null)
				{
					r_PSignature = new(this, "Signature", -1);
				}
				return r_PSignature;
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
				}
				return r_PIsConstructedGenericMethod;
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
				}
				return r_PIsGenericMethod;
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
				}
				return r_PIsGenericMethodDefinition;
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
		/// Void System.Runtime.InteropServices._ConstructorBuilder.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ConstructorBuilder.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ConstructorBuilder.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ConstructorBuilder.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ConstructorBuilder.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._ConstructorBuilder.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ConstructorBuilder.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._ConstructorBuilder.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
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
				}
				return r_MGetParametersCount;
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
				}
				return r_MGetParameterType_Int32;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase RuntimeResolve()
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
				}
				return r_MInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
			}
		}

		/// <summary>
		/// System.Object Invoke(System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
		/// </summary>
		protected RMethod r_MInvoke_BindingFlags_Binder_ObjectArray_CultureInfo;
		public virtual RMethod RMInvoke_BindingFlags_Binder_ObjectArray_CultureInfo
		{
			get
			{
				if(r_MInvoke_BindingFlags_Binder_ObjectArray_CultureInfo == null)
				{
					r_MInvoke_BindingFlags_Binder_ObjectArray_CultureInfo = new(this, "Invoke", 0, typeof(System.Reflection.BindingFlags), typeof(System.Reflection.Binder), typeof(System.Object).MakeArrayType(), typeof(System.Globalization.CultureInfo));
				}
				return r_MInvoke_BindingFlags_Binder_ObjectArray_CultureInfo;
			}
		}

		/// <summary>
		/// Void AddDeclarativeSecurity(System.Security.Permissions.SecurityAction, System.Security.PermissionSet)
		/// </summary>
		protected RMethod r_MAddDeclarativeSecurity_SecurityAction_PermissionSet;
		public virtual RMethod RMAddDeclarativeSecurity_SecurityAction_PermissionSet
		{
			get
			{
				if(r_MAddDeclarativeSecurity_SecurityAction_PermissionSet == null)
				{
					r_MAddDeclarativeSecurity_SecurityAction_PermissionSet = new(this, "AddDeclarativeSecurity", 0, typeof(System.Security.Permissions.SecurityAction), typeof(System.Security.PermissionSet));
				}
				return r_MAddDeclarativeSecurity_SecurityAction_PermissionSet;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ParameterBuilder DefineParameter(Int32, System.Reflection.ParameterAttributes, System.String)
		/// </summary>
		protected RMethod r_MDefineParameter_Int32_ParameterAttributes_String;
		public virtual RMethod RMDefineParameter_Int32_ParameterAttributes_String
		{
			get
			{
				if(r_MDefineParameter_Int32_ParameterAttributes_String == null)
				{
					r_MDefineParameter_Int32_ParameterAttributes_String = new(this, "DefineParameter", 0, typeof(System.Int32), typeof(System.Reflection.ParameterAttributes), typeof(System.String));
				}
				return r_MDefineParameter_Int32_ParameterAttributes_String;
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
		/// System.Reflection.Emit.ILGenerator GetILGenerator()
		/// </summary>
		protected RMethod r_MGetILGenerator;
		public virtual RMethod RMGetILGenerator
		{
			get
			{
				if(r_MGetILGenerator == null)
				{
					r_MGetILGenerator = new(this, "GetILGenerator", 0);
				}
				return r_MGetILGenerator;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ILGenerator GetILGenerator(Int32)
		/// </summary>
		protected RMethod r_MGetILGenerator_Int32;
		public virtual RMethod RMGetILGenerator_Int32
		{
			get
			{
				if(r_MGetILGenerator_Int32 == null)
				{
					r_MGetILGenerator_Int32 = new(this, "GetILGenerator", 0, typeof(System.Int32));
				}
				return r_MGetILGenerator_Int32;
			}
		}

		/// <summary>
		/// Void SetMethodBody(Byte[], Int32, Byte[], System.Collections.Generic.IEnumerable`1[System.Reflection.Emit.ExceptionHandler], System.Collections.Generic.IEnumerable`1[System.Int32])
		/// </summary>
		protected RMethod r_MSetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_;
		public virtual RMethod RMSetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_
		{
			get
			{
				if(r_MSetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_ == null)
				{
					r_MSetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_ = new(this, "SetMethodBody", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Byte).MakeArrayType(),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.Reflection.Emit.ExceptionHandler)),  ReflectionUtils.GetType("System.Collections.Generic.IEnumerable`1").MakeGenericType(typeof(System.Int32)));
				}
				return r_MSetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_;
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
		/// Void SetImplementationFlags(System.Reflection.MethodImplAttributes)
		/// </summary>
		protected RMethod r_MSetImplementationFlags_MethodImplAttributes;
		public virtual RMethod RMSetImplementationFlags_MethodImplAttributes
		{
			get
			{
				if(r_MSetImplementationFlags_MethodImplAttributes == null)
				{
					r_MSetImplementationFlags_MethodImplAttributes = new(this, "SetImplementationFlags", 0, typeof(System.Reflection.MethodImplAttributes));
				}
				return r_MSetImplementationFlags_MethodImplAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.Module GetModule()
		/// </summary>
		protected RMethod r_MGetModule;
		public virtual RMethod RMGetModule
		{
			get
			{
				if(r_MGetModule == null)
				{
					r_MGetModule = new(this, "GetModule", 0);
				}
				return r_MGetModule;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.MethodToken GetToken()
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
		/// Void SetSymCustomAttribute(System.String, Byte[])
		/// </summary>
		protected RMethod r_MSetSymCustomAttribute_String_ByteArray;
		public virtual RMethod RMSetSymCustomAttribute_String_ByteArray
		{
			get
			{
				if(r_MSetSymCustomAttribute_String_ByteArray == null)
				{
					r_MSetSymCustomAttribute_String_ByteArray = new(this, "SetSymCustomAttribute", 0, typeof(System.String), typeof(System.Byte).MakeArrayType());
				}
				return r_MSetSymCustomAttribute_String_ByteArray;
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
		/// Void fixup()
		/// </summary>
		protected RMethod r_Mfixup;
		public virtual RMethod RMfixup
		{
			get
			{
				if(r_Mfixup == null)
				{
					r_Mfixup = new(this, "fixup", 0);
				}
				return r_Mfixup;
			}
		}

		/// <summary>
		/// Void ResolveUserTypes()
		/// </summary>
		protected RMethod r_MResolveUserTypes;
		public virtual RMethod RMResolveUserTypes
		{
			get
			{
				if(r_MResolveUserTypes == null)
				{
					r_MResolveUserTypes = new(this, "ResolveUserTypes", 0);
				}
				return r_MResolveUserTypes;
			}
		}

		/// <summary>
		/// Void FixupTokens(System.Collections.Generic.Dictionary`2[System.Int32,System.Int32], System.Collections.Generic.Dictionary`2[System.Int32,System.Reflection.MemberInfo])
		/// </summary>
		protected RMethod r_MFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_;
		public virtual RMethod RMFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_
		{
			get
			{
				if(r_MFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_ == null)
				{
					r_MFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_ = new(this, "FixupTokens", 0,  ReflectionUtils.GetType("System.Collections.Generic.Dictionary`2").MakeGenericType(typeof(System.Int32), typeof(System.Int32)),  ReflectionUtils.GetType("System.Collections.Generic.Dictionary`2").MakeGenericType(typeof(System.Int32), typeof(System.Reflection.MemberInfo)));
				}
				return r_MFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_;
			}
		}

		/// <summary>
		/// Void GenerateDebugInfo(System.Diagnostics.SymbolStore.ISymbolWriter)
		/// </summary>
		protected RMethod r_MGenerateDebugInfo_ISymbolWriter;
		public virtual RMethod RMGenerateDebugInfo_ISymbolWriter
		{
			get
			{
				if(r_MGenerateDebugInfo_ISymbolWriter == null)
				{
					r_MGenerateDebugInfo_ISymbolWriter = new(this, "GenerateDebugInfo", 0, typeof(System.Diagnostics.SymbolStore.ISymbolWriter));
				}
				return r_MGenerateDebugInfo_ISymbolWriter;
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
				}
				return r_Mget_next_table_index_Object_Int32_Int32;
			}
		}

		/// <summary>
		/// Void RejectIfCreated()
		/// </summary>
		protected RMethod r_MRejectIfCreated;
		public virtual RMethod RMRejectIfCreated
		{
			get
			{
				if(r_MRejectIfCreated == null)
				{
					r_MRejectIfCreated = new(this, "RejectIfCreated", 0);
				}
				return r_MRejectIfCreated;
			}
		}

		/// <summary>
		/// System.Exception not_supported()
		/// </summary>
		protected RMethod r_Mnot_supported;
		public virtual RMethod RMnot_supported
		{
			get
			{
				if(r_Mnot_supported == null)
				{
					r_Mnot_supported = new(this, "not_supported", 0);
				}
				return r_Mnot_supported;
			}
		}

		/// <summary>
		/// System.Exception not_after_created()
		/// </summary>
		protected RMethod r_Mnot_after_created;
		public virtual RMethod RMnot_after_created
		{
			get
			{
				if(r_Mnot_after_created == null)
				{
					r_Mnot_after_created = new(this, "not_after_created", 0);
				}
				return r_Mnot_after_created;
			}
		}

		/// <summary>
		/// System.Exception not_created()
		/// </summary>
		protected RMethod r_Mnot_created;
		public virtual RMethod RMnot_created
		{
			get
			{
				if(r_Mnot_created == null)
				{
					r_Mnot_created = new(this, "not_created", 0);
				}
				return r_Mnot_created;
			}
		}

		/// <summary>
		/// System.Object Invoke(System.Object[])
		/// </summary>
		protected RMethod r_MInvoke_ObjectArray;
		public virtual RMethod RMInvoke_ObjectArray
		{
			get
			{
				if(r_MInvoke_ObjectArray == null)
				{
					r_MInvoke_ObjectArray = new(this, "Invoke", 0, typeof(System.Object).MakeArrayType());
				}
				return r_MInvoke_ObjectArray;
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
				}
				return r_MGetMethodBody;
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
				}
				return r_MInvoke_Object_ObjectArray;
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
				}
				return r_MFormatNameAndSig_Boolean;
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
				}
				return r_MGetParametersNoCopy;
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


        public virtual void System__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ConstructorBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.MethodImplAttributes GetMethodImplementationFlags()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMethodImplementationFlags.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.MethodImplAttributes>(___result);
        }


        public virtual System.Reflection.ParameterInfo[] GetParameters()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetParameters.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.ParameterInfo[]>(___result);
        }


        public virtual System.Reflection.ParameterInfo[] GetParametersInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetParametersInternal.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.ParameterInfo[]>(___result);
        }


        public virtual System.Int32 GetParametersCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetParametersCount.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetParameterType(System.Int32 @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RMGetParameterType_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Reflection.MethodBase RuntimeResolve()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRuntimeResolve.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.MethodBase>(___result);
        }


        public virtual System.Object Invoke(System.Object @obj, System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Object[] @parameters, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @invokeAttr, @binder, @parameters, @culture};
            var ___result = RMInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Object Invoke(System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Object[] @parameters, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@invokeAttr, @binder, @parameters, @culture};
            var ___result = RMInvoke_BindingFlags_Binder_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual void AddDeclarativeSecurity(System.Security.Permissions.SecurityAction @action, System.Security.PermissionSet @pset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action, @pset};
            var ___result = RMAddDeclarativeSecurity_SecurityAction_PermissionSet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.ParameterBuilder DefineParameter(System.Int32 @iSequence, System.Reflection.ParameterAttributes @attributes, System.String @strParamName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iSequence, @attributes, @strParamName};
            var ___result = RMDefineParameter_Int32_ParameterAttributes_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.ParameterBuilder>(___result);
        }


        public virtual System.Boolean IsDefined(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMIsDefined_Type_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Object[] GetCustomAttributes(System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inherit};
            var ___result = RMGetCustomAttributes_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object[]>(___result);
        }


        public virtual System.Object[] GetCustomAttributes(System.Type @attributeType, System.Boolean @inherit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributeType, @inherit};
            var ___result = RMGetCustomAttributes_Type_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object[]>(___result);
        }


        public virtual System.Reflection.Emit.ILGenerator GetILGenerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetILGenerator.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.ILGenerator>(___result);
        }


        public virtual System.Reflection.Emit.ILGenerator GetILGenerator(System.Int32 @streamSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@streamSize};
            var ___result = RMGetILGenerator_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.ILGenerator>(___result);
        }


        public virtual void SetMethodBody(System.Byte[] @il, System.Int32 @maxStack, System.Byte[] @localSignature, System.Collections.Generic.IEnumerable<System.Reflection.Emit.ExceptionHandler> @exceptionHandlers, System.Collections.Generic.IEnumerable<System.Int32> @tokenFixups)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@il, @maxStack, @localSignature, @exceptionHandlers, @tokenFixups};
            var ___result = RMSetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_.Invoke(___genericsType, ___parameters);

            
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


        public virtual void SetImplementationFlags(System.Reflection.MethodImplAttributes @attributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attributes};
            var ___result = RMSetImplementationFlags_MethodImplAttributes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Module GetModule()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetModule.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Module>(___result);
        }


        public virtual System.Reflection.Emit.MethodToken GetToken()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetToken.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.Emit.MethodToken>(___result);
        }


        public virtual void SetSymCustomAttribute(System.String @name, System.Byte[] @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @data};
            var ___result = RMSetSymCustomAttribute_String_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual void fixup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMfixup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResolveUserTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResolveUserTypes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FixupTokens(System.Collections.Generic.Dictionary<System.Int32, System.Int32> @token_map, System.Collections.Generic.Dictionary<System.Int32, System.Reflection.MemberInfo> @member_map)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token_map, @member_map};
            var ___result = RMFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GenerateDebugInfo(System.Diagnostics.SymbolStore.ISymbolWriter @symbolWriter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@symbolWriter};
            var ___result = RMGenerateDebugInfo_ISymbolWriter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 get_next_table_index(System.Object @obj, System.Int32 @table, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @table, @count};
            var ___result = RMget_next_table_index_Object_Int32_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual void RejectIfCreated()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRejectIfCreated.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Exception not_supported()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMnot_supported.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Exception>(___result);
        }


        public virtual System.Exception not_after_created()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMnot_after_created.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Exception>(___result);
        }


        public virtual System.Exception not_created()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMnot_created.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Exception>(___result);
        }


        public virtual System.Object Invoke(System.Object[] @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parameters};
            var ___result = RMInvoke_ObjectArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Reflection.MethodBody GetMethodBody()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMethodBody.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.MethodBody>(___result);
        }


        public virtual System.Type[] GetGenericArguments()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGenericArguments.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type[]>(___result);
        }


        public virtual System.Object Invoke(System.Object @obj, System.Object[] @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @parameters};
            var ___result = RMInvoke_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String FormatNameAndSig(System.Boolean @serialization)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serialization};
            var ___result = RMFormatNameAndSig_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Type[] GetParameterTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetParameterTypes.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type[]>(___result);
        }


        public virtual System.Reflection.ParameterInfo[] GetParametersNoCopy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetParametersNoCopy.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.ParameterInfo[]>(___result);
        }


        public virtual System.Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMHasSameMetadataDefinitionAs_MemberInfo.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Collections.Generic.IList<System.Reflection.CustomAttributeData> GetCustomAttributesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetCustomAttributesData.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.IList<System.Reflection.CustomAttributeData>>(___result);
        }


        public virtual System.Boolean CacheEquals(System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
            var ___result = RMCacheEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasSameMetadataDefinitionAsCore<TOther>(System.Reflection.MemberInfo @other) where TOther : System.Reflection.MemberInfo
        {

            var ___genericsType = new Type[] {typeof(TOther)};
            var ___parameters = new object[]{@other};
            var ___result = RMHasSameMetadataDefinitionAsCore_GTOther_MemberInfo.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
