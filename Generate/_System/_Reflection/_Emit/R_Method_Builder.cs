
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.MethodBuilder
	/// </summary>
    public partial class RMethodBuilder : RMember //
    {

		/// <summary>
		/// System.RuntimeMethodHandle mhandle
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntimeMethodHandle r_Fmhandle;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntimeMethodHandle RFmhandle
		{
			get
			{
				if(r_Fmhandle == null)
				{
					r_Fmhandle = new(this, "mhandle");
					r_Fmhandle.SetBelong(this.instance);
				}
				return r_Fmhandle;
			}
		}

		/// <summary>
		/// System.Type rtype
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_Frtype;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RFrtype
		{
			get
			{
				if(r_Frtype == null)
				{
					r_Frtype = new(this, "rtype");
					r_Frtype.SetBelong(this.instance);
				}
				return r_Frtype;
			}
		}

		/// <summary>
		/// System.Type[] parameters
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RType> r_Fparameters;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RType> RFparameters
		{
			get
			{
				if(r_Fparameters == null)
				{
					r_Fparameters = new(this, "parameters");
					r_Fparameters.SetBelong(this.instance);
				}
				return r_Fparameters;
			}
		}

		/// <summary>
		/// System.Reflection.MethodAttributes attrs
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_Fattrs;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFattrs
		{
			get
			{
				if(r_Fattrs == null)
				{
					r_Fattrs = new(this, "attrs");
					r_Fattrs.SetBelong(this.instance);
				}
				return r_Fattrs;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes iattrs
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes r_Fiattrs;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes RFiattrs
		{
			get
			{
				if(r_Fiattrs == null)
				{
					r_Fiattrs = new(this, "iattrs");
					r_Fiattrs.SetBelong(this.instance);
				}
				return r_Fiattrs;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fname;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFname
		{
			get
			{
				if(r_Fname == null)
				{
					r_Fname = new(this, "name");
					r_Fname.SetBelong(this.instance);
				}
				return r_Fname;
			}
		}

		/// <summary>
		/// System.Int32 table_idx
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Ftable_idx;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFtable_idx
		{
			get
			{
				if(r_Ftable_idx == null)
				{
					r_Ftable_idx = new(this, "table_idx");
					r_Ftable_idx.SetBelong(this.instance);
				}
				return r_Ftable_idx;
			}
		}

		/// <summary>
		/// System.Byte[] code
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RByte> r_Fcode;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RByte> RFcode
		{
			get
			{
				if(r_Fcode == null)
				{
					r_Fcode = new(this, "code");
					r_Fcode.SetBelong(this.instance);
				}
				return r_Fcode;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ILGenerator ilgen
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RILGenerator r_Filgen;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RILGenerator RFilgen
		{
			get
			{
				if(r_Filgen == null)
				{
					r_Filgen = new(this, "ilgen");
					r_Filgen.SetBelong(this.instance);
				}
				return r_Filgen;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder type
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RTypeBuilder r_Ftype;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RTypeBuilder RFtype
		{
			get
			{
				if(r_Ftype == null)
				{
					r_Ftype = new(this, "type");
					r_Ftype.SetBelong(this.instance);
				}
				return r_Ftype;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ParameterBuilder[] pinfo
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RParameterBuilder> r_Fpinfo;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RParameterBuilder> RFpinfo
		{
			get
			{
				if(r_Fpinfo == null)
				{
					r_Fpinfo = new(this, "pinfo");
					r_Fpinfo.SetBelong(this.instance);
				}
				return r_Fpinfo;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.CustomAttributeBuilder[] cattrs
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RCustomAttributeBuilder> r_Fcattrs;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RCustomAttributeBuilder> RFcattrs
		{
			get
			{
				if(r_Fcattrs == null)
				{
					r_Fcattrs = new(this, "cattrs");
					r_Fcattrs.SetBelong(this.instance);
				}
				return r_Fcattrs;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo[] override_methods
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodInfo> r_Foverride_methods;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodInfo> RFoverride_methods
		{
			get
			{
				if(r_Foverride_methods == null)
				{
					r_Foverride_methods = new(this, "override_methods");
					r_Foverride_methods.SetBelong(this.instance);
				}
				return r_Foverride_methods;
			}
		}

		/// <summary>
		/// System.String pi_dll
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fpi_dll;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFpi_dll
		{
			get
			{
				if(r_Fpi_dll == null)
				{
					r_Fpi_dll = new(this, "pi_dll");
					r_Fpi_dll.SetBelong(this.instance);
				}
				return r_Fpi_dll;
			}
		}

		/// <summary>
		/// System.String pi_entry
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_Fpi_entry;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RFpi_entry
		{
			get
			{
				if(r_Fpi_entry == null)
				{
					r_Fpi_entry = new(this, "pi_entry");
					r_Fpi_entry.SetBelong(this.instance);
				}
				return r_Fpi_entry;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.CharSet charset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RCharSet r_Fcharset;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RCharSet RFcharset
		{
			get
			{
				if(r_Fcharset == null)
				{
					r_Fcharset = new(this, "charset");
					r_Fcharset.SetBelong(this.instance);
				}
				return r_Fcharset;
			}
		}

		/// <summary>
		/// System.UInt32 extra_flags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RUInt32 r_Fextra_flags;
		public virtual SMFrame.Editor.Refleaction.RSystem.RUInt32 RFextra_flags
		{
			get
			{
				if(r_Fextra_flags == null)
				{
					r_Fextra_flags = new(this, "extra_flags");
					r_Fextra_flags.SetBelong(this.instance);
				}
				return r_Fextra_flags;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.CallingConvention native_cc
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RCallingConvention r_Fnative_cc;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RCallingConvention RFnative_cc
		{
			get
			{
				if(r_Fnative_cc == null)
				{
					r_Fnative_cc = new(this, "native_cc");
					r_Fnative_cc.SetBelong(this.instance);
				}
				return r_Fnative_cc;
			}
		}

		/// <summary>
		/// System.Reflection.CallingConventions call_conv
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RCallingConventions r_Fcall_conv;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RCallingConventions RFcall_conv
		{
			get
			{
				if(r_Fcall_conv == null)
				{
					r_Fcall_conv = new(this, "call_conv");
					r_Fcall_conv.SetBelong(this.instance);
				}
				return r_Fcall_conv;
			}
		}

		/// <summary>
		/// System.Boolean init_locals
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Finit_locals;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFinit_locals
		{
			get
			{
				if(r_Finit_locals == null)
				{
					r_Finit_locals = new(this, "init_locals");
					r_Finit_locals.SetBelong(this.instance);
				}
				return r_Finit_locals;
			}
		}

		/// <summary>
		/// System.IntPtr generic_container
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RIntPtr r_Fgeneric_container;
		public virtual SMFrame.Editor.Refleaction.RSystem.RIntPtr RFgeneric_container
		{
			get
			{
				if(r_Fgeneric_container == null)
				{
					r_Fgeneric_container = new(this, "generic_container");
					r_Fgeneric_container.SetBelong(this.instance);
				}
				return r_Fgeneric_container;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.GenericTypeParameterBuilder[] generic_params
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RGenericTypeParameterBuilder> r_Fgeneric_params;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RGenericTypeParameterBuilder> RFgeneric_params
		{
			get
			{
				if(r_Fgeneric_params == null)
				{
					r_Fgeneric_params = new(this, "generic_params");
					r_Fgeneric_params.SetBelong(this.instance);
				}
				return r_Fgeneric_params;
			}
		}

		/// <summary>
		/// System.Type[] returnModReq
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RType> r_FreturnModReq;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RType> RFreturnModReq
		{
			get
			{
				if(r_FreturnModReq == null)
				{
					r_FreturnModReq = new(this, "returnModReq");
					r_FreturnModReq.SetBelong(this.instance);
				}
				return r_FreturnModReq;
			}
		}

		/// <summary>
		/// System.Type[] returnModOpt
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RType> r_FreturnModOpt;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RType> RFreturnModOpt
		{
			get
			{
				if(r_FreturnModOpt == null)
				{
					r_FreturnModOpt = new(this, "returnModOpt");
					r_FreturnModOpt.SetBelong(this.instance);
				}
				return r_FreturnModOpt;
			}
		}

		/// <summary>
		/// System.Type[][] paramModReq
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RType>> r_FparamModReq;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RType>> RFparamModReq
		{
			get
			{
				if(r_FparamModReq == null)
				{
					r_FparamModReq = new(this, "paramModReq");
					r_FparamModReq.SetBelong(this.instance);
				}
				return r_FparamModReq;
			}
		}

		/// <summary>
		/// System.Type[][] paramModOpt
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RType>> r_FparamModOpt;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RType>> RFparamModOpt
		{
			get
			{
				if(r_FparamModOpt == null)
				{
					r_FparamModOpt = new(this, "paramModOpt");
					r_FparamModOpt.SetBelong(this.instance);
				}
				return r_FparamModOpt;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.RefEmitPermissionSet[] permissions
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RRefEmitPermissionSet> r_Fpermissions;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RRefEmitPermissionSet> RFpermissions
		{
			get
			{
				if(r_Fpermissions == null)
				{
					r_Fpermissions = new(this, "permissions");
					r_Fpermissions.SetBelong(this.instance);
				}
				return r_Fpermissions;
			}
		}

		/// <summary>
		/// Boolean ContainsGenericParameters
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PContainsGenericParameters;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPContainsGenericParameters
		{
			get
			{
				if(r_PContainsGenericParameters == null)
				{
					r_PContainsGenericParameters = new(this, "ContainsGenericParameters", -1);
					r_PContainsGenericParameters.SetBelong(this.instance);
				}
				return r_PContainsGenericParameters;
			}
		}

		/// <summary>
		/// Boolean InitLocals
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PInitLocals;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPInitLocals
		{
			get
			{
				if(r_PInitLocals == null)
				{
					r_PInitLocals = new(this, "InitLocals", -1);
					r_PInitLocals.SetBelong(this.instance);
				}
				return r_PInitLocals;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TypeBuilder TypeBuilder
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RTypeBuilder r_PTypeBuilder;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RTypeBuilder RPTypeBuilder
		{
			get
			{
				if(r_PTypeBuilder == null)
				{
					r_PTypeBuilder = new(this, "TypeBuilder", -1);
					r_PTypeBuilder.SetBelong(this.instance);
				}
				return r_PTypeBuilder;
			}
		}

		/// <summary>
		/// System.RuntimeMethodHandle MethodHandle
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntimeMethodHandle r_PMethodHandle;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntimeMethodHandle RPMethodHandle
		{
			get
			{
				if(r_PMethodHandle == null)
				{
					r_PMethodHandle = new(this, "MethodHandle", -1);
					r_PMethodHandle.SetBelong(this.instance);
				}
				return r_PMethodHandle;
			}
		}

		/// <summary>
		/// System.RuntimeMethodHandle MethodHandleInternal
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntimeMethodHandle r_PMethodHandleInternal;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntimeMethodHandle RPMethodHandleInternal
		{
			get
			{
				if(r_PMethodHandleInternal == null)
				{
					r_PMethodHandleInternal = new(this, "MethodHandleInternal", -1);
					r_PMethodHandleInternal.SetBelong(this.instance);
				}
				return r_PMethodHandleInternal;
			}
		}

		/// <summary>
		/// System.Type ReturnType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_PReturnType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RPReturnType
		{
			get
			{
				if(r_PReturnType == null)
				{
					r_PReturnType = new(this, "ReturnType", -1);
					r_PReturnType.SetBelong(this.instance);
				}
				return r_PReturnType;
			}
		}

		/// <summary>
		/// System.Type ReflectedType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_PReflectedType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RPReflectedType
		{
			get
			{
				if(r_PReflectedType == null)
				{
					r_PReflectedType = new(this, "ReflectedType", -1);
					r_PReflectedType.SetBelong(this.instance);
				}
				return r_PReflectedType;
			}
		}

		/// <summary>
		/// System.Type DeclaringType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RType r_PDeclaringType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RType RPDeclaringType
		{
			get
			{
				if(r_PDeclaringType == null)
				{
					r_PDeclaringType = new(this, "DeclaringType", -1);
					r_PDeclaringType.SetBelong(this.instance);
				}
				return r_PDeclaringType;
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
		/// System.Reflection.MethodAttributes Attributes
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_PAttributes;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RPAttributes
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
		/// System.Reflection.ICustomAttributeProvider ReturnTypeCustomAttributes
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RICustomAttributeProvider r_PReturnTypeCustomAttributes;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RICustomAttributeProvider RPReturnTypeCustomAttributes
		{
			get
			{
				if(r_PReturnTypeCustomAttributes == null)
				{
					r_PReturnTypeCustomAttributes = new(this, "ReturnTypeCustomAttributes", -1);
					r_PReturnTypeCustomAttributes.SetBelong(this.instance);
				}
				return r_PReturnTypeCustomAttributes;
			}
		}

		/// <summary>
		/// System.Reflection.CallingConventions CallingConvention
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RCallingConventions r_PCallingConvention;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RCallingConventions RPCallingConvention
		{
			get
			{
				if(r_PCallingConvention == null)
				{
					r_PCallingConvention = new(this, "CallingConvention", -1);
					r_PCallingConvention.SetBelong(this.instance);
				}
				return r_PCallingConvention;
			}
		}

		/// <summary>
		/// System.String Signature
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PSignature;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPSignature
		{
			get
			{
				if(r_PSignature == null)
				{
					r_PSignature = new(this, "Signature", -1);
					r_PSignature.SetBelong(this.instance);
				}
				return r_PSignature;
			}
		}

		/// <summary>
		/// Boolean BestFitMapping
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PBestFitMapping;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPBestFitMapping
		{
			get
			{
				if(r_PBestFitMapping == null)
				{
					r_PBestFitMapping = new(this, "BestFitMapping", -1);
					r_PBestFitMapping.SetBelong(this.instance);
				}
				return r_PBestFitMapping;
			}
		}

		/// <summary>
		/// Boolean ThrowOnUnmappableChar
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PThrowOnUnmappableChar;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPThrowOnUnmappableChar
		{
			get
			{
				if(r_PThrowOnUnmappableChar == null)
				{
					r_PThrowOnUnmappableChar = new(this, "ThrowOnUnmappableChar", -1);
					r_PThrowOnUnmappableChar.SetBelong(this.instance);
				}
				return r_PThrowOnUnmappableChar;
			}
		}

		/// <summary>
		/// Boolean ExactSpelling
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PExactSpelling;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPExactSpelling
		{
			get
			{
				if(r_PExactSpelling == null)
				{
					r_PExactSpelling = new(this, "ExactSpelling", -1);
					r_PExactSpelling.SetBelong(this.instance);
				}
				return r_PExactSpelling;
			}
		}

		/// <summary>
		/// Boolean SetLastError
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PSetLastError;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPSetLastError
		{
			get
			{
				if(r_PSetLastError == null)
				{
					r_PSetLastError = new(this, "SetLastError", -1);
					r_PSetLastError.SetBelong(this.instance);
				}
				return r_PSetLastError;
			}
		}

		/// <summary>
		/// Boolean IsGenericMethodDefinition
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsGenericMethodDefinition;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsGenericMethodDefinition
		{
			get
			{
				if(r_PIsGenericMethodDefinition == null)
				{
					r_PIsGenericMethodDefinition = new(this, "IsGenericMethodDefinition", -1);
					r_PIsGenericMethodDefinition.SetBelong(this.instance);
				}
				return r_PIsGenericMethodDefinition;
			}
		}

		/// <summary>
		/// Boolean IsGenericMethod
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsGenericMethod;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsGenericMethod
		{
			get
			{
				if(r_PIsGenericMethod == null)
				{
					r_PIsGenericMethod = new(this, "IsGenericMethod", -1);
					r_PIsGenericMethod.SetBelong(this.instance);
				}
				return r_PIsGenericMethod;
			}
		}

		/// <summary>
		/// System.Reflection.Module Module
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RModule r_PModule;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RModule RPModule
		{
			get
			{
				if(r_PModule == null)
				{
					r_PModule = new(this, "Module", -1);
					r_PModule.SetBelong(this.instance);
				}
				return r_PModule;
			}
		}

		/// <summary>
		/// System.Reflection.ParameterInfo ReturnParameter
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RParameterInfo r_PReturnParameter;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RParameterInfo RPReturnParameter
		{
			get
			{
				if(r_PReturnParameter == null)
				{
					r_PReturnParameter = new(this, "ReturnParameter", -1);
					r_PReturnParameter.SetBelong(this.instance);
				}
				return r_PReturnParameter;
			}
		}

		/// <summary>
		/// System.Reflection.MemberTypes MemberType
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RMemberTypes r_PMemberType;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RMemberTypes RPMemberType
		{
			get
			{
				if(r_PMemberType == null)
				{
					r_PMemberType = new(this, "MemberType", -1);
					r_PMemberType.SetBelong(this.instance);
				}
				return r_PMemberType;
			}
		}

		/// <summary>
		/// Int32 GenericParameterCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PGenericParameterCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPGenericParameterCount
		{
			get
			{
				if(r_PGenericParameterCount == null)
				{
					r_PGenericParameterCount = new(this, "GenericParameterCount", -1);
					r_PGenericParameterCount.SetBelong(this.instance);
				}
				return r_PGenericParameterCount;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes MethodImplementationFlags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes r_PMethodImplementationFlags;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes RPMethodImplementationFlags
		{
			get
			{
				if(r_PMethodImplementationFlags == null)
				{
					r_PMethodImplementationFlags = new(this, "MethodImplementationFlags", -1);
					r_PMethodImplementationFlags.SetBelong(this.instance);
				}
				return r_PMethodImplementationFlags;
			}
		}

		/// <summary>
		/// Boolean IsAbstract
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsAbstract;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsAbstract
		{
			get
			{
				if(r_PIsAbstract == null)
				{
					r_PIsAbstract = new(this, "IsAbstract", -1);
					r_PIsAbstract.SetBelong(this.instance);
				}
				return r_PIsAbstract;
			}
		}

		/// <summary>
		/// Boolean IsConstructor
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsConstructor;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsConstructor
		{
			get
			{
				if(r_PIsConstructor == null)
				{
					r_PIsConstructor = new(this, "IsConstructor", -1);
					r_PIsConstructor.SetBelong(this.instance);
				}
				return r_PIsConstructor;
			}
		}

		/// <summary>
		/// Boolean IsFinal
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsFinal;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsFinal
		{
			get
			{
				if(r_PIsFinal == null)
				{
					r_PIsFinal = new(this, "IsFinal", -1);
					r_PIsFinal.SetBelong(this.instance);
				}
				return r_PIsFinal;
			}
		}

		/// <summary>
		/// Boolean IsHideBySig
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsHideBySig;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsHideBySig
		{
			get
			{
				if(r_PIsHideBySig == null)
				{
					r_PIsHideBySig = new(this, "IsHideBySig", -1);
					r_PIsHideBySig.SetBelong(this.instance);
				}
				return r_PIsHideBySig;
			}
		}

		/// <summary>
		/// Boolean IsSpecialName
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsSpecialName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsSpecialName
		{
			get
			{
				if(r_PIsSpecialName == null)
				{
					r_PIsSpecialName = new(this, "IsSpecialName", -1);
					r_PIsSpecialName.SetBelong(this.instance);
				}
				return r_PIsSpecialName;
			}
		}

		/// <summary>
		/// Boolean IsStatic
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsStatic;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsStatic
		{
			get
			{
				if(r_PIsStatic == null)
				{
					r_PIsStatic = new(this, "IsStatic", -1);
					r_PIsStatic.SetBelong(this.instance);
				}
				return r_PIsStatic;
			}
		}

		/// <summary>
		/// Boolean IsVirtual
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsVirtual;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsVirtual
		{
			get
			{
				if(r_PIsVirtual == null)
				{
					r_PIsVirtual = new(this, "IsVirtual", -1);
					r_PIsVirtual.SetBelong(this.instance);
				}
				return r_PIsVirtual;
			}
		}

		/// <summary>
		/// Boolean IsAssembly
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsAssembly;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsAssembly
		{
			get
			{
				if(r_PIsAssembly == null)
				{
					r_PIsAssembly = new(this, "IsAssembly", -1);
					r_PIsAssembly.SetBelong(this.instance);
				}
				return r_PIsAssembly;
			}
		}

		/// <summary>
		/// Boolean IsFamily
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsFamily;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsFamily
		{
			get
			{
				if(r_PIsFamily == null)
				{
					r_PIsFamily = new(this, "IsFamily", -1);
					r_PIsFamily.SetBelong(this.instance);
				}
				return r_PIsFamily;
			}
		}

		/// <summary>
		/// Boolean IsFamilyAndAssembly
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsFamilyAndAssembly;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsFamilyAndAssembly
		{
			get
			{
				if(r_PIsFamilyAndAssembly == null)
				{
					r_PIsFamilyAndAssembly = new(this, "IsFamilyAndAssembly", -1);
					r_PIsFamilyAndAssembly.SetBelong(this.instance);
				}
				return r_PIsFamilyAndAssembly;
			}
		}

		/// <summary>
		/// Boolean IsFamilyOrAssembly
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsFamilyOrAssembly;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsFamilyOrAssembly
		{
			get
			{
				if(r_PIsFamilyOrAssembly == null)
				{
					r_PIsFamilyOrAssembly = new(this, "IsFamilyOrAssembly", -1);
					r_PIsFamilyOrAssembly.SetBelong(this.instance);
				}
				return r_PIsFamilyOrAssembly;
			}
		}

		/// <summary>
		/// Boolean IsPrivate
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsPrivate;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsPrivate
		{
			get
			{
				if(r_PIsPrivate == null)
				{
					r_PIsPrivate = new(this, "IsPrivate", -1);
					r_PIsPrivate.SetBelong(this.instance);
				}
				return r_PIsPrivate;
			}
		}

		/// <summary>
		/// Boolean IsPublic
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsPublic;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsPublic
		{
			get
			{
				if(r_PIsPublic == null)
				{
					r_PIsPublic = new(this, "IsPublic", -1);
					r_PIsPublic.SetBelong(this.instance);
				}
				return r_PIsPublic;
			}
		}

		/// <summary>
		/// Boolean IsConstructedGenericMethod
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsConstructedGenericMethod;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsConstructedGenericMethod
		{
			get
			{
				if(r_PIsConstructedGenericMethod == null)
				{
					r_PIsConstructedGenericMethod = new(this, "IsConstructedGenericMethod", -1);
					r_PIsConstructedGenericMethod.SetBelong(this.instance);
				}
				return r_PIsConstructedGenericMethod;
			}
		}

		/// <summary>
		/// Boolean IsSecurityCritical
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsSecurityCritical;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsSecurityCritical
		{
			get
			{
				if(r_PIsSecurityCritical == null)
				{
					r_PIsSecurityCritical = new(this, "IsSecurityCritical", -1);
					r_PIsSecurityCritical.SetBelong(this.instance);
				}
				return r_PIsSecurityCritical;
			}
		}

		/// <summary>
		/// Boolean IsSecuritySafeCritical
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsSecuritySafeCritical;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsSecuritySafeCritical
		{
			get
			{
				if(r_PIsSecuritySafeCritical == null)
				{
					r_PIsSecuritySafeCritical = new(this, "IsSecuritySafeCritical", -1);
					r_PIsSecuritySafeCritical.SetBelong(this.instance);
				}
				return r_PIsSecuritySafeCritical;
			}
		}

		/// <summary>
		/// Boolean IsSecurityTransparent
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsSecurityTransparent;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsSecurityTransparent
		{
			get
			{
				if(r_PIsSecurityTransparent == null)
				{
					r_PIsSecurityTransparent = new(this, "IsSecurityTransparent", -1);
					r_PIsSecurityTransparent.SetBelong(this.instance);
				}
				return r_PIsSecurityTransparent;
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
		/// Void System.Runtime.InteropServices._MethodBuilder.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._MethodBuilder.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._MethodBuilder.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._MethodBuilder.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._MethodBuilder.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._MethodBuilder.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_MSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._MethodBuilder.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._MethodBuilder.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
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
					r_MGetToken.SetBelong(this.instance);
				}
				return r_MGetToken;
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
					r_MGetBaseDefinition.SetBelong(this.instance);
				}
				return r_MGetBaseDefinition;
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
					r_MGetMethodImplementationFlags.SetBelong(this.instance);
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
					r_MGetParameters.SetBelong(this.instance);
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
					r_MGetParametersInternal.SetBelong(this.instance);
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
					r_MGetParametersCount.SetBelong(this.instance);
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
					r_MGetParameterType_Int32.SetBelong(this.instance);
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
					r_MRuntimeResolve.SetBelong(this.instance);
				}
				return r_MRuntimeResolve;
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
					r_MGetModule.SetBelong(this.instance);
				}
				return r_MGetModule;
			}
		}

		/// <summary>
		/// Void CreateMethodBody(Byte[], Int32)
		/// </summary>
		protected RMethod r_MCreateMethodBody_ByteArray_Int32;
		public virtual RMethod RMCreateMethodBody_ByteArray_Int32
		{
			get
			{
				if(r_MCreateMethodBody_ByteArray_Int32 == null)
				{
					r_MCreateMethodBody_ByteArray_Int32 = new(this, "CreateMethodBody", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_MCreateMethodBody_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_MCreateMethodBody_ByteArray_Int32;
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
					r_MSetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_ = new(this, "SetMethodBody", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Reflection.Emit.ExceptionHandler)), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Int32)));
					r_MSetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_.SetBelong(this.instance);
				}
				return r_MSetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_;
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
					r_MInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo.SetBelong(this.instance);
				}
				return r_MInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo;
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
					r_MGetILGenerator.SetBelong(this.instance);
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
					r_MGetILGenerator_Int32.SetBelong(this.instance);
				}
				return r_MGetILGenerator_Int32;
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
					r_MDefineParameter_Int32_ParameterAttributes_String.SetBelong(this.instance);
				}
				return r_MDefineParameter_Int32_ParameterAttributes_String;
			}
		}

		/// <summary>
		/// Void check_override()
		/// </summary>
		protected RMethod r_Mcheck_override;
		public virtual RMethod RMcheck_override
		{
			get
			{
				if(r_Mcheck_override == null)
				{
					r_Mcheck_override = new(this, "check_override", 0);
					r_Mcheck_override.SetBelong(this.instance);
				}
				return r_Mcheck_override;
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
					r_Mfixup.SetBelong(this.instance);
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
					r_MResolveUserTypes.SetBelong(this.instance);
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
					r_MFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_ = new(this, "FixupTokens", 0, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32), typeof(System.Int32)), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32), typeof(System.Reflection.MemberInfo)));
					r_MFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_.SetBelong(this.instance);
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
					r_MGenerateDebugInfo_ISymbolWriter.SetBelong(this.instance);
				}
				return r_MGenerateDebugInfo_ISymbolWriter;
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
					r_MSetCustomAttribute_CustomAttributeBuilder.SetBelong(this.instance);
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
					r_MSetCustomAttribute_ConstructorInfo_ByteArray.SetBelong(this.instance);
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
					r_MSetImplementationFlags_MethodImplAttributes.SetBelong(this.instance);
				}
				return r_MSetImplementationFlags_MethodImplAttributes;
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
					r_MAddDeclarativeSecurity_SecurityAction_PermissionSet.SetBelong(this.instance);
				}
				return r_MAddDeclarativeSecurity_SecurityAction_PermissionSet;
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
					r_MSetMarshal_UnmanagedMarshal.SetBelong(this.instance);
				}
				return r_MSetMarshal_UnmanagedMarshal;
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
					r_MSetSymCustomAttribute_String_ByteArray.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
				}
				return r_MGetHashCode;
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
					r_Mget_next_table_index_Object_Int32_Int32.SetBelong(this.instance);
				}
				return r_Mget_next_table_index_Object_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ExtendArray[T](T[] ByRef, T)
		/// </summary>
		protected RMethod r_MExtendArray_GT_Ref_TArray_T;
		public virtual RMethod RMExtendArray_GT_Ref_TArray_T
		{
			get
			{
				if(r_MExtendArray_GT_Ref_TArray_T == null)
				{
					r_MExtendArray_GT_Ref_TArray_T = new(this, "ExtendArray", 1, Type.MakeGenericMethodParameter(0).MakeArrayType().MakeByRefType(), Type.MakeGenericMethodParameter(0));
					r_MExtendArray_GT_Ref_TArray_T.SetBelong(this.instance);
				}
				return r_MExtendArray_GT_Ref_TArray_T;
			}
		}

		/// <summary>
		/// Void set_override(System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_Mset_override_MethodInfo;
		public virtual RMethod RMset_override_MethodInfo
		{
			get
			{
				if(r_Mset_override_MethodInfo == null)
				{
					r_Mset_override_MethodInfo = new(this, "set_override", 0, typeof(System.Reflection.MethodInfo));
					r_Mset_override_MethodInfo.SetBelong(this.instance);
				}
				return r_Mset_override_MethodInfo;
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
					r_MRejectIfCreated.SetBelong(this.instance);
				}
				return r_MRejectIfCreated;
			}
		}

		/// <summary>
		/// System.Exception NotSupported()
		/// </summary>
		protected RMethod r_MNotSupported;
		public virtual RMethod RMNotSupported
		{
			get
			{
				if(r_MNotSupported == null)
				{
					r_MNotSupported = new(this, "NotSupported", 0);
					r_MNotSupported.SetBelong(this.instance);
				}
				return r_MNotSupported;
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
					r_MMakeGenericMethod_TypeArray.SetBelong(this.instance);
				}
				return r_MMakeGenericMethod_TypeArray;
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
					r_MGetGenericMethodDefinition.SetBelong(this.instance);
				}
				return r_MGetGenericMethodDefinition;
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
					r_MGetGenericArguments.SetBelong(this.instance);
				}
				return r_MGetGenericArguments;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.GenericTypeParameterBuilder[] DefineGenericParameters(System.String[])
		/// </summary>
		protected RMethod r_MDefineGenericParameters_StringArray;
		public virtual RMethod RMDefineGenericParameters_StringArray
		{
			get
			{
				if(r_MDefineGenericParameters_StringArray == null)
				{
					r_MDefineGenericParameters_StringArray = new(this, "DefineGenericParameters", 0, typeof(System.String).MakeArrayType());
					r_MDefineGenericParameters_StringArray.SetBelong(this.instance);
				}
				return r_MDefineGenericParameters_StringArray;
			}
		}

		/// <summary>
		/// Void SetReturnType(System.Type)
		/// </summary>
		protected RMethod r_MSetReturnType_Type;
		public virtual RMethod RMSetReturnType_Type
		{
			get
			{
				if(r_MSetReturnType_Type == null)
				{
					r_MSetReturnType_Type = new(this, "SetReturnType", 0, typeof(System.Type));
					r_MSetReturnType_Type.SetBelong(this.instance);
				}
				return r_MSetReturnType_Type;
			}
		}

		/// <summary>
		/// Void SetParameters(System.Type[])
		/// </summary>
		protected RMethod r_MSetParameters_TypeArray;
		public virtual RMethod RMSetParameters_TypeArray
		{
			get
			{
				if(r_MSetParameters_TypeArray == null)
				{
					r_MSetParameters_TypeArray = new(this, "SetParameters", 0, typeof(System.Type).MakeArrayType());
					r_MSetParameters_TypeArray.SetBelong(this.instance);
				}
				return r_MSetParameters_TypeArray;
			}
		}

		/// <summary>
		/// Void SetSignature(System.Type, System.Type[], System.Type[], System.Type[], System.Type[][], System.Type[][])
		/// </summary>
		protected RMethod r_MSetSignature_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
		public virtual RMethod RMSetSignature_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray
		{
			get
			{
				if(r_MSetSignature_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray == null)
				{
					r_MSetSignature_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray = new(this, "SetSignature", 0, typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType());
					r_MSetSignature_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.SetBelong(this.instance);
				}
				return r_MSetSignature_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
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
					r_MCreateDelegate_Type.SetBelong(this.instance);
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
					r_MCreateDelegate_Type_Object.SetBelong(this.instance);
				}
				return r_MCreateDelegate_Type_Object;
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
					r_MGetMethodBody.SetBelong(this.instance);
				}
				return r_MGetMethodBody;
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
					r_MInvoke_Object_ObjectArray.SetBelong(this.instance);
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
					r_MFormatNameAndSig_Boolean.SetBelong(this.instance);
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
					r_MGetParameterTypes.SetBelong(this.instance);
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
					r_MGetParametersNoCopy.SetBelong(this.instance);
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
					r_MHasSameMetadataDefinitionAs_MemberInfo.SetBelong(this.instance);
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
					r_MGetCustomAttributesData.SetBelong(this.instance);
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
					r_MCacheEquals_Object.SetBelong(this.instance);
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
					r_MHasSameMetadataDefinitionAsCore_GTOther_MemberInfo.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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


        public RMethodBuilder() : base("System.Reflection.Emit.MethodBuilder")
        {
        }

        public RMethodBuilder(System.Object instance) : base("System.Reflection.Emit.MethodBuilder")
		{
            SetInstance(instance);
		}

        public RMethodBuilder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMethodBuilder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void System__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___MethodBuilder__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___MethodBuilder__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.MethodToken GetToken()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetToken.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.MethodToken)___result;
        }


        public virtual System.Reflection.MethodInfo GetBaseDefinition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetBaseDefinition.Invoke(___genericsType, ___parameters);

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


        public virtual System.Type GetParameterType(System.Int32 @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RMGetParameterType_Int32.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Reflection.MethodBase RuntimeResolve()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRuntimeResolve.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBase)___result;
        }


        public virtual System.Reflection.Module GetModule()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetModule.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Module)___result;
        }


        public virtual void CreateMethodBody(System.Byte[] @il, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@il, @count};
            var ___result = RMCreateMethodBody_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMethodBody(System.Byte[] @il, System.Int32 @maxStack, System.Byte[] @localSignature, System.Collections.Generic.IEnumerable<System.Reflection.Emit.ExceptionHandler> @exceptionHandlers, System.Collections.Generic.IEnumerable<System.Int32> @tokenFixups)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@il, @maxStack, @localSignature, @exceptionHandlers, @tokenFixups};
            var ___result = RMSetMethodBody_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Invoke(System.Object @obj, System.Reflection.BindingFlags @invokeAttr, System.Reflection.Binder @binder, System.Object[] @parameters, System.Globalization.CultureInfo @culture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @invokeAttr, @binder, @parameters, @culture};
            var ___result = RMInvoke_Object_BindingFlags_Binder_ObjectArray_CultureInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual System.Reflection.Emit.ILGenerator GetILGenerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetILGenerator.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.ILGenerator)___result;
        }


        public virtual System.Reflection.Emit.ILGenerator GetILGenerator(System.Int32 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size};
            var ___result = RMGetILGenerator_Int32.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.ILGenerator)___result;
        }


        public virtual System.Reflection.Emit.ParameterBuilder DefineParameter(System.Int32 @position, System.Reflection.ParameterAttributes @attributes, System.String @strParamName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @attributes, @strParamName};
            var ___result = RMDefineParameter_Int32_ParameterAttributes_String.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.ParameterBuilder)___result;
        }


        public virtual void check_override()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMcheck_override.Invoke(___genericsType, ___parameters);

            
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


        public virtual void AddDeclarativeSecurity(System.Security.Permissions.SecurityAction @action, System.Security.PermissionSet @pset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action, @pset};
            var ___result = RMAddDeclarativeSecurity_SecurityAction_PermissionSet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetMarshal(System.Reflection.Emit.UnmanagedMarshal @unmanagedMarshal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unmanagedMarshal};
            var ___result = RMSetMarshal_UnmanagedMarshal.Invoke(___genericsType, ___parameters);

            
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

            return (System.String)___result;
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


        public virtual System.Int32 get_next_table_index(System.Object @obj, System.Int32 @table, System.Int32 @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @table, @count};
            var ___result = RMget_next_table_index_Object_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void ExtendArray<T>(ref T[] @array, T @elem)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@array, @elem};
            var ___result = RMExtendArray_GT_Ref_TArray_T.Invoke(___genericsType, ___parameters);
			@array = (T[])___parameters[0];

            
        }


        public virtual void set_override(System.Reflection.MethodInfo @mdecl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mdecl};
            var ___result = RMset_override_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RejectIfCreated()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRejectIfCreated.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Exception NotSupported()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMNotSupported.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Reflection.MethodInfo MakeGenericMethod(System.Type[] @typeArguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeArguments};
            var ___result = RMMakeGenericMethod_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Reflection.MethodInfo GetGenericMethodDefinition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGenericMethodDefinition.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.Type[] GetGenericArguments()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetGenericArguments.Invoke(___genericsType, ___parameters);

            return (System.Type[])___result;
        }


        public virtual System.Reflection.Emit.GenericTypeParameterBuilder[] DefineGenericParameters(System.String[] @names)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@names};
            var ___result = RMDefineGenericParameters_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.GenericTypeParameterBuilder[])___result;
        }


        public virtual void SetReturnType(System.Type @returnType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@returnType};
            var ___result = RMSetReturnType_Type.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetParameters(System.Type[] @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parameterTypes};
            var ___result = RMSetParameters_TypeArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSignature(System.Type @returnType, System.Type[] @returnTypeRequiredCustomModifiers, System.Type[] @returnTypeOptionalCustomModifiers, System.Type[] @parameterTypes, System.Type[][] @parameterTypeRequiredCustomModifiers, System.Type[][] @parameterTypeOptionalCustomModifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@returnType, @returnTypeRequiredCustomModifiers, @returnTypeOptionalCustomModifiers, @parameterTypes, @parameterTypeRequiredCustomModifiers, @parameterTypeOptionalCustomModifiers};
            var ___result = RMSetSignature_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Reflection.MethodBody GetMethodBody()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMethodBody.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodBody)___result;
        }


        public virtual System.Object Invoke(System.Object @obj, System.Object[] @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @parameters};
            var ___result = RMInvoke_Object_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String FormatNameAndSig(System.Boolean @serialization)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serialization};
            var ___result = RMFormatNameAndSig_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


        public virtual System.Boolean HasSameMetadataDefinitionAs(System.Reflection.MemberInfo @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMHasSameMetadataDefinitionAs_MemberInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
