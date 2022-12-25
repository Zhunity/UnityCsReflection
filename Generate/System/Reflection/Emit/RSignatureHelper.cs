using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.SignatureHelper
	/// </summary>
    public partial class RSignatureHelper : RMember //
    {

		/// <summary>
		/// System.Reflection.Emit.ModuleBuilder module
		/// </summary>
		protected RSystem.RReflection.REmit.RModuleBuilder r_module;
		public virtual RSystem.RReflection.REmit.RModuleBuilder Rmodule
		{
			get
			{
				if(r_module == null)
				{
					r_module = new(this, "module");
					r_module.SetBelong(this.instance);
				}
				return r_module;
			}
		}

		/// <summary>
		/// System.Type[] arguments
		/// </summary>
		protected RFieldArray<RSystem.RType> r_arguments;
		public virtual RFieldArray<RSystem.RType> Rarguments
		{
			get
			{
				if(r_arguments == null)
				{
					r_arguments = new(this, "arguments");
					r_arguments.SetBelong(this.instance);
				}
				return r_arguments;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper+SignatureHelperType type
		/// </summary>
		protected RField r_type;
		public virtual RField Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type");
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// System.Type returnType
		/// </summary>
		protected RSystem.RType r_returnType;
		public virtual RSystem.RType RreturnType
		{
			get
			{
				if(r_returnType == null)
				{
					r_returnType = new(this, "returnType");
					r_returnType.SetBelong(this.instance);
				}
				return r_returnType;
			}
		}

		/// <summary>
		/// System.Reflection.CallingConventions callConv
		/// </summary>
		protected RField r_callConv;
		public virtual RField RcallConv
		{
			get
			{
				if(r_callConv == null)
				{
					r_callConv = new(this, "callConv");
					r_callConv.SetBelong(this.instance);
				}
				return r_callConv;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.CallingConvention unmanagedCallConv
		/// </summary>
		protected RField r_unmanagedCallConv;
		public virtual RField RunmanagedCallConv
		{
			get
			{
				if(r_unmanagedCallConv == null)
				{
					r_unmanagedCallConv = new(this, "unmanagedCallConv");
					r_unmanagedCallConv.SetBelong(this.instance);
				}
				return r_unmanagedCallConv;
			}
		}

		/// <summary>
		/// System.Type[][] modreqs
		/// </summary>
		protected RFieldArray<RFieldArray<RSystem.RType>> r_modreqs;
		public virtual RFieldArray<RFieldArray<RSystem.RType>> Rmodreqs
		{
			get
			{
				if(r_modreqs == null)
				{
					r_modreqs = new(this, "modreqs");
					r_modreqs.SetBelong(this.instance);
				}
				return r_modreqs;
			}
		}

		/// <summary>
		/// System.Type[][] modopts
		/// </summary>
		protected RFieldArray<RFieldArray<RSystem.RType>> r_modopts;
		public virtual RFieldArray<RFieldArray<RSystem.RType>> Rmodopts
		{
			get
			{
				if(r_modopts == null)
				{
					r_modopts = new(this, "modopts");
					r_modopts.SetBelong(this.instance);
				}
				return r_modopts;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper GetFieldSigHelper(System.Reflection.Module)
		/// </summary>
		protected static RMethod r_RGetFieldSigHelper_Module;
		public static RMethod RGetFieldSigHelper_Module
		{
			get
			{
				if(r_RGetFieldSigHelper_Module == null)
				{
					r_RGetFieldSigHelper_Module = new(typeof(System.Reflection.Emit.SignatureHelper), "GetFieldSigHelper", 0, typeof(System.Reflection.Module));
					r_RGetFieldSigHelper_Module.SetBelong(null);
				}
				return r_RGetFieldSigHelper_Module;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper GetLocalVarSigHelper(System.Reflection.Module)
		/// </summary>
		protected static RMethod r_RGetLocalVarSigHelper_Module;
		public static RMethod RGetLocalVarSigHelper_Module
		{
			get
			{
				if(r_RGetLocalVarSigHelper_Module == null)
				{
					r_RGetLocalVarSigHelper_Module = new(typeof(System.Reflection.Emit.SignatureHelper), "GetLocalVarSigHelper", 0, typeof(System.Reflection.Module));
					r_RGetLocalVarSigHelper_Module.SetBelong(null);
				}
				return r_RGetLocalVarSigHelper_Module;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper GetLocalVarSigHelper()
		/// </summary>
		protected static RMethod r_RGetLocalVarSigHelper;
		public static RMethod RGetLocalVarSigHelper
		{
			get
			{
				if(r_RGetLocalVarSigHelper == null)
				{
					r_RGetLocalVarSigHelper = new(typeof(System.Reflection.Emit.SignatureHelper), "GetLocalVarSigHelper", 0);
					r_RGetLocalVarSigHelper.SetBelong(null);
				}
				return r_RGetLocalVarSigHelper;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.CallingConventions, System.Type)
		/// </summary>
		protected static RMethod r_RGetMethodSigHelper_CallingConventions_Type;
		public static RMethod RGetMethodSigHelper_CallingConventions_Type
		{
			get
			{
				if(r_RGetMethodSigHelper_CallingConventions_Type == null)
				{
					r_RGetMethodSigHelper_CallingConventions_Type = new(typeof(System.Reflection.Emit.SignatureHelper), "GetMethodSigHelper", 0, typeof(System.Reflection.CallingConventions), typeof(System.Type));
					r_RGetMethodSigHelper_CallingConventions_Type.SetBelong(null);
				}
				return r_RGetMethodSigHelper_CallingConventions_Type;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Runtime.InteropServices.CallingConvention, System.Type)
		/// </summary>
		protected static RMethod r_RGetMethodSigHelper_CallingConvention_Type;
		public static RMethod RGetMethodSigHelper_CallingConvention_Type
		{
			get
			{
				if(r_RGetMethodSigHelper_CallingConvention_Type == null)
				{
					r_RGetMethodSigHelper_CallingConvention_Type = new(typeof(System.Reflection.Emit.SignatureHelper), "GetMethodSigHelper", 0, typeof(System.Runtime.InteropServices.CallingConvention), typeof(System.Type));
					r_RGetMethodSigHelper_CallingConvention_Type.SetBelong(null);
				}
				return r_RGetMethodSigHelper_CallingConvention_Type;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module, System.Reflection.CallingConventions, System.Type)
		/// </summary>
		protected static RMethod r_RGetMethodSigHelper_Module_CallingConventions_Type;
		public static RMethod RGetMethodSigHelper_Module_CallingConventions_Type
		{
			get
			{
				if(r_RGetMethodSigHelper_Module_CallingConventions_Type == null)
				{
					r_RGetMethodSigHelper_Module_CallingConventions_Type = new(typeof(System.Reflection.Emit.SignatureHelper), "GetMethodSigHelper", 0, typeof(System.Reflection.Module), typeof(System.Reflection.CallingConventions), typeof(System.Type));
					r_RGetMethodSigHelper_Module_CallingConventions_Type.SetBelong(null);
				}
				return r_RGetMethodSigHelper_Module_CallingConventions_Type;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module, System.Runtime.InteropServices.CallingConvention, System.Type)
		/// </summary>
		protected static RMethod r_RGetMethodSigHelper_Module_CallingConvention_Type;
		public static RMethod RGetMethodSigHelper_Module_CallingConvention_Type
		{
			get
			{
				if(r_RGetMethodSigHelper_Module_CallingConvention_Type == null)
				{
					r_RGetMethodSigHelper_Module_CallingConvention_Type = new(typeof(System.Reflection.Emit.SignatureHelper), "GetMethodSigHelper", 0, typeof(System.Reflection.Module), typeof(System.Runtime.InteropServices.CallingConvention), typeof(System.Type));
					r_RGetMethodSigHelper_Module_CallingConvention_Type.SetBelong(null);
				}
				return r_RGetMethodSigHelper_Module_CallingConvention_Type;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module, System.Type, System.Type[])
		/// </summary>
		protected static RMethod r_RGetMethodSigHelper_Module_Type_TypeArray;
		public static RMethod RGetMethodSigHelper_Module_Type_TypeArray
		{
			get
			{
				if(r_RGetMethodSigHelper_Module_Type_TypeArray == null)
				{
					r_RGetMethodSigHelper_Module_Type_TypeArray = new(typeof(System.Reflection.Emit.SignatureHelper), "GetMethodSigHelper", 0, typeof(System.Reflection.Module), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_RGetMethodSigHelper_Module_Type_TypeArray.SetBelong(null);
				}
				return r_RGetMethodSigHelper_Module_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper GetPropertySigHelper(System.Reflection.Module, System.Type, System.Type[])
		/// </summary>
		protected static RMethod r_RGetPropertySigHelper_Module_Type_TypeArray;
		public static RMethod RGetPropertySigHelper_Module_Type_TypeArray
		{
			get
			{
				if(r_RGetPropertySigHelper_Module_Type_TypeArray == null)
				{
					r_RGetPropertySigHelper_Module_Type_TypeArray = new(typeof(System.Reflection.Emit.SignatureHelper), "GetPropertySigHelper", 0, typeof(System.Reflection.Module), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_RGetPropertySigHelper_Module_Type_TypeArray.SetBelong(null);
				}
				return r_RGetPropertySigHelper_Module_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper GetPropertySigHelper(System.Reflection.Module, System.Type, System.Type[], System.Type[], System.Type[], System.Type[][], System.Type[][])
		/// </summary>
		protected static RMethod r_RGetPropertySigHelper_Module_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
		public static RMethod RGetPropertySigHelper_Module_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray
		{
			get
			{
				if(r_RGetPropertySigHelper_Module_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray == null)
				{
					r_RGetPropertySigHelper_Module_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray = new(typeof(System.Reflection.Emit.SignatureHelper), "GetPropertySigHelper", 0, typeof(System.Reflection.Module), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType());
					r_RGetPropertySigHelper_Module_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.SetBelong(null);
				}
				return r_RGetPropertySigHelper_Module_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper GetPropertySigHelper(System.Reflection.Module, System.Reflection.CallingConventions, System.Type, System.Type[], System.Type[], System.Type[], System.Type[][], System.Type[][])
		/// </summary>
		protected static RMethod r_RGetPropertySigHelper_Module_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
		public static RMethod RGetPropertySigHelper_Module_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray
		{
			get
			{
				if(r_RGetPropertySigHelper_Module_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray == null)
				{
					r_RGetPropertySigHelper_Module_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray = new(typeof(System.Reflection.Emit.SignatureHelper), "GetPropertySigHelper", 0, typeof(System.Reflection.Module), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType());
					r_RGetPropertySigHelper_Module_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.SetBelong(null);
				}
				return r_RGetPropertySigHelper_Module_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
			}
		}

		/// <summary>
		/// Int32 AppendArray(System.Type[] ByRef, System.Type)
		/// </summary>
		protected static RMethod r_RAppendArray_Ref_TypeArray_Type;
		public static RMethod RAppendArray_Ref_TypeArray_Type
		{
			get
			{
				if(r_RAppendArray_Ref_TypeArray_Type == null)
				{
					r_RAppendArray_Ref_TypeArray_Type = new(typeof(System.Reflection.Emit.SignatureHelper), "AppendArray", 0, typeof(System.Type).MakeArrayType().MakeByRefType(), typeof(System.Type));
					r_RAppendArray_Ref_TypeArray_Type.SetBelong(null);
				}
				return r_RAppendArray_Ref_TypeArray_Type;
			}
		}

		/// <summary>
		/// Void AppendArrayAt(System.Type[][] ByRef, System.Type[], Int32)
		/// </summary>
		protected static RMethod r_RAppendArrayAt_Ref_TypeArrayArray_TypeArray_Int32;
		public static RMethod RAppendArrayAt_Ref_TypeArrayArray_TypeArray_Int32
		{
			get
			{
				if(r_RAppendArrayAt_Ref_TypeArrayArray_TypeArray_Int32 == null)
				{
					r_RAppendArrayAt_Ref_TypeArrayArray_TypeArray_Int32 = new(typeof(System.Reflection.Emit.SignatureHelper), "AppendArrayAt", 0, typeof(System.Type).MakeArrayType().MakeArrayType().MakeByRefType(), typeof(System.Type).MakeArrayType(), typeof(System.Int32));
					r_RAppendArrayAt_Ref_TypeArrayArray_TypeArray_Int32.SetBelong(null);
				}
				return r_RAppendArrayAt_Ref_TypeArrayArray_TypeArray_Int32;
			}
		}

		/// <summary>
		/// Void ValidateParameterModifiers(System.String, System.Type[])
		/// </summary>
		protected static RMethod r_RValidateParameterModifiers_String_TypeArray;
		public static RMethod RValidateParameterModifiers_String_TypeArray
		{
			get
			{
				if(r_RValidateParameterModifiers_String_TypeArray == null)
				{
					r_RValidateParameterModifiers_String_TypeArray = new(typeof(System.Reflection.Emit.SignatureHelper), "ValidateParameterModifiers", 0, typeof(System.String), typeof(System.Type).MakeArrayType());
					r_RValidateParameterModifiers_String_TypeArray.SetBelong(null);
				}
				return r_RValidateParameterModifiers_String_TypeArray;
			}
		}

		/// <summary>
		/// Void ValidateCustomModifier(Int32, System.Type[][], System.String)
		/// </summary>
		protected static RMethod r_RValidateCustomModifier_Int32_TypeArrayArray_String;
		public static RMethod RValidateCustomModifier_Int32_TypeArrayArray_String
		{
			get
			{
				if(r_RValidateCustomModifier_Int32_TypeArrayArray_String == null)
				{
					r_RValidateCustomModifier_Int32_TypeArrayArray_String = new(typeof(System.Reflection.Emit.SignatureHelper), "ValidateCustomModifier", 0, typeof(System.Int32), typeof(System.Type).MakeArrayType().MakeArrayType(), typeof(System.String));
					r_RValidateCustomModifier_Int32_TypeArrayArray_String.SetBelong(null);
				}
				return r_RValidateCustomModifier_Int32_TypeArrayArray_String;
			}
		}

		/// <summary>
		/// System.Exception MissingFeature()
		/// </summary>
		protected static RMethod r_RMissingFeature;
		public static RMethod RMissingFeature
		{
			get
			{
				if(r_RMissingFeature == null)
				{
					r_RMissingFeature = new(typeof(System.Reflection.Emit.SignatureHelper), "MissingFeature", 0);
					r_RMissingFeature.SetBelong(null);
				}
				return r_RMissingFeature;
			}
		}

		/// <summary>
		/// Void AddArguments(System.Type[], System.Type[][], System.Type[][])
		/// </summary>
		protected RMethod r_RAddArguments_TypeArray_TypeArrayArray_TypeArrayArray;
		public virtual RMethod RAddArguments_TypeArray_TypeArrayArray_TypeArrayArray
		{
			get
			{
				if(r_RAddArguments_TypeArray_TypeArrayArray_TypeArrayArray == null)
				{
					r_RAddArguments_TypeArray_TypeArrayArray_TypeArrayArray = new(this, "AddArguments", 0, typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType());
					r_RAddArguments_TypeArray_TypeArrayArray_TypeArrayArray.SetBelong(this.instance);
				}
				return r_RAddArguments_TypeArray_TypeArrayArray_TypeArrayArray;
			}
		}

		/// <summary>
		/// Void AddArgument(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RAddArgument_Type_Boolean;
		public virtual RMethod RAddArgument_Type_Boolean
		{
			get
			{
				if(r_RAddArgument_Type_Boolean == null)
				{
					r_RAddArgument_Type_Boolean = new(this, "AddArgument", 0, typeof(System.Type), typeof(System.Boolean));
					r_RAddArgument_Type_Boolean.SetBelong(this.instance);
				}
				return r_RAddArgument_Type_Boolean;
			}
		}

		/// <summary>
		/// Void AddArgument(System.Type, System.Type[], System.Type[])
		/// </summary>
		protected RMethod r_RAddArgument_Type_TypeArray_TypeArray;
		public virtual RMethod RAddArgument_Type_TypeArray_TypeArray
		{
			get
			{
				if(r_RAddArgument_Type_TypeArray_TypeArray == null)
				{
					r_RAddArgument_Type_TypeArray_TypeArray = new(this, "AddArgument", 0, typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_RAddArgument_Type_TypeArray_TypeArray.SetBelong(this.instance);
				}
				return r_RAddArgument_Type_TypeArray_TypeArray;
			}
		}

		/// <summary>
		/// Void AddArgument(System.Type)
		/// </summary>
		protected RMethod r_RAddArgument_Type;
		public virtual RMethod RAddArgument_Type
		{
			get
			{
				if(r_RAddArgument_Type == null)
				{
					r_RAddArgument_Type = new(this, "AddArgument", 0, typeof(System.Type));
					r_RAddArgument_Type.SetBelong(this.instance);
				}
				return r_RAddArgument_Type;
			}
		}

		/// <summary>
		/// Void AddSentinel()
		/// </summary>
		protected RMethod r_RAddSentinel;
		public virtual RMethod RAddSentinel
		{
			get
			{
				if(r_RAddSentinel == null)
				{
					r_RAddSentinel = new(this, "AddSentinel", 0);
					r_RAddSentinel.SetBelong(this.instance);
				}
				return r_RAddSentinel;
			}
		}

		/// <summary>
		/// Boolean CompareOK(System.Type[][], System.Type[][])
		/// </summary>
		protected static RMethod r_RCompareOK_TypeArrayArray_TypeArrayArray;
		public static RMethod RCompareOK_TypeArrayArray_TypeArrayArray
		{
			get
			{
				if(r_RCompareOK_TypeArrayArray_TypeArrayArray == null)
				{
					r_RCompareOK_TypeArrayArray_TypeArrayArray = new(typeof(System.Reflection.Emit.SignatureHelper), "CompareOK", 0, typeof(System.Type).MakeArrayType().MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType());
					r_RCompareOK_TypeArrayArray_TypeArrayArray.SetBelong(null);
				}
				return r_RCompareOK_TypeArrayArray_TypeArrayArray;
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
		/// Byte[] get_signature_local()
		/// </summary>
		protected RMethod r_Rget_signature_local;
		public virtual RMethod Rget_signature_local
		{
			get
			{
				if(r_Rget_signature_local == null)
				{
					r_Rget_signature_local = new(this, "get_signature_local", 0);
					r_Rget_signature_local.SetBelong(this.instance);
				}
				return r_Rget_signature_local;
			}
		}

		/// <summary>
		/// Byte[] get_signature_field()
		/// </summary>
		protected RMethod r_Rget_signature_field;
		public virtual RMethod Rget_signature_field
		{
			get
			{
				if(r_Rget_signature_field == null)
				{
					r_Rget_signature_field = new(this, "get_signature_field", 0);
					r_Rget_signature_field.SetBelong(this.instance);
				}
				return r_Rget_signature_field;
			}
		}

		/// <summary>
		/// Byte[] GetSignature()
		/// </summary>
		protected RMethod r_RGetSignature;
		public virtual RMethod RGetSignature
		{
			get
			{
				if(r_RGetSignature == null)
				{
					r_RGetSignature = new(this, "GetSignature", 0);
					r_RGetSignature.SetBelong(this.instance);
				}
				return r_RGetSignature;
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
		/// System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module, System.Reflection.CallingConventions, System.Runtime.InteropServices.CallingConvention, System.Type, System.Type[])
		/// </summary>
		protected static RMethod r_RGetMethodSigHelper_Module_CallingConventions_CallingConvention_Type_TypeArray;
		public static RMethod RGetMethodSigHelper_Module_CallingConventions_CallingConvention_Type_TypeArray
		{
			get
			{
				if(r_RGetMethodSigHelper_Module_CallingConventions_CallingConvention_Type_TypeArray == null)
				{
					r_RGetMethodSigHelper_Module_CallingConventions_CallingConvention_Type_TypeArray = new(typeof(System.Reflection.Emit.SignatureHelper), "GetMethodSigHelper", 0, typeof(System.Reflection.Module), typeof(System.Reflection.CallingConventions), typeof(System.Runtime.InteropServices.CallingConvention), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_RGetMethodSigHelper_Module_CallingConventions_CallingConvention_Type_TypeArray.SetBelong(null);
				}
				return r_RGetMethodSigHelper_Module_CallingConventions_CallingConvention_Type_TypeArray;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._SignatureHelper.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._SignatureHelper.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._SignatureHelper.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._SignatureHelper.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._SignatureHelper.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._SignatureHelper.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._SignatureHelper.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._SignatureHelper.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
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


        public RSignatureHelper() : base("System.Reflection.Emit.SignatureHelper")
        {
        }

        public RSignatureHelper(System.Object instance) : base("System.Reflection.Emit.SignatureHelper")
		{
            SetInstance(instance);
		}

        public RSignatureHelper(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSignatureHelper(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Reflection.Emit.SignatureHelper GetFieldSigHelper(System.Reflection.Module  @mod)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mod};
            var ___result = RGetFieldSigHelper_Module.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public static System.Reflection.Emit.SignatureHelper GetLocalVarSigHelper(System.Reflection.Module  @mod)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mod};
            var ___result = RGetLocalVarSigHelper_Module.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public static System.Reflection.Emit.SignatureHelper GetLocalVarSigHelper()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLocalVarSigHelper.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.CallingConventions  @callingConvention, System.Type  @returnType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callingConvention, @returnType};
            var ___result = RGetMethodSigHelper_CallingConventions_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Runtime.InteropServices.CallingConvention  @unmanagedCallingConvention, System.Type  @returnType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unmanagedCallingConvention, @returnType};
            var ___result = RGetMethodSigHelper_CallingConvention_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module  @mod, System.Reflection.CallingConventions  @callingConvention, System.Type  @returnType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mod, @callingConvention, @returnType};
            var ___result = RGetMethodSigHelper_Module_CallingConventions_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module  @mod, System.Runtime.InteropServices.CallingConvention  @unmanagedCallConv, System.Type  @returnType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mod, @unmanagedCallConv, @returnType};
            var ___result = RGetMethodSigHelper_Module_CallingConvention_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module  @mod, System.Type  @returnType, System.Type[]  @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mod, @returnType, @parameterTypes};
            var ___result = RGetMethodSigHelper_Module_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public static System.Reflection.Emit.SignatureHelper GetPropertySigHelper(System.Reflection.Module  @mod, System.Type  @returnType, System.Type[]  @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mod, @returnType, @parameterTypes};
            var ___result = RGetPropertySigHelper_Module_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public static System.Reflection.Emit.SignatureHelper GetPropertySigHelper(System.Reflection.Module  @mod, System.Type  @returnType, System.Type[]  @requiredReturnTypeCustomModifiers, System.Type[]  @optionalReturnTypeCustomModifiers, System.Type[]  @parameterTypes, System.Type[][]  @requiredParameterTypeCustomModifiers, System.Type[][]  @optionalParameterTypeCustomModifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mod, @returnType, @requiredReturnTypeCustomModifiers, @optionalReturnTypeCustomModifiers, @parameterTypes, @requiredParameterTypeCustomModifiers, @optionalParameterTypeCustomModifiers};
            var ___result = RGetPropertySigHelper_Module_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public static System.Reflection.Emit.SignatureHelper GetPropertySigHelper(System.Reflection.Module  @mod, System.Reflection.CallingConventions  @callingConvention, System.Type  @returnType, System.Type[]  @requiredReturnTypeCustomModifiers, System.Type[]  @optionalReturnTypeCustomModifiers, System.Type[]  @parameterTypes, System.Type[][]  @requiredParameterTypeCustomModifiers, System.Type[][]  @optionalParameterTypeCustomModifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mod, @callingConvention, @returnType, @requiredReturnTypeCustomModifiers, @optionalReturnTypeCustomModifiers, @parameterTypes, @requiredParameterTypeCustomModifiers, @optionalParameterTypeCustomModifiers};
            var ___result = RGetPropertySigHelper_Module_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public static System.Int32 AppendArray(ref System.Type[]  @array, System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @t};
            var ___result = RAppendArray_Ref_TypeArray_Type.Invoke(___genericsType, ___parameters);
			array = (System.Type[])___parameters[0];

            return (System.Int32)___result;
        }


        public static void AppendArrayAt(ref System.Type[][]  @array, System.Type[]  @t, System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @t, @pos};
            var ___result = RAppendArrayAt_Ref_TypeArrayArray_TypeArray_Int32.Invoke(___genericsType, ___parameters);
			array = (System.Type[][])___parameters[0];

            
        }


        public static void ValidateParameterModifiers(System.String  @name, System.Type[]  @parameter_modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @parameter_modifiers};
            var ___result = RValidateParameterModifiers_String_TypeArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void ValidateCustomModifier(System.Int32  @n, System.Type[][]  @custom_modifiers, System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@n, @custom_modifiers, @name};
            var ___result = RValidateCustomModifier_Int32_TypeArrayArray_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Exception MissingFeature()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMissingFeature.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual void AddArguments(System.Type[]  @arguments, System.Type[][]  @requiredCustomModifiers, System.Type[][]  @optionalCustomModifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arguments, @requiredCustomModifiers, @optionalCustomModifiers};
            var ___result = RAddArguments_TypeArray_TypeArrayArray_TypeArrayArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddArgument(System.Type  @argument, System.Boolean  @pinned)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@argument, @pinned};
            var ___result = RAddArgument_Type_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddArgument(System.Type  @argument, System.Type[]  @requiredCustomModifiers, System.Type[]  @optionalCustomModifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@argument, @requiredCustomModifiers, @optionalCustomModifiers};
            var ___result = RAddArgument_Type_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddArgument(System.Type  @clsArgument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clsArgument};
            var ___result = RAddArgument_Type.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddSentinel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAddSentinel.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean CompareOK(System.Type[][]  @one, System.Type[][]  @two)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@one, @two};
            var ___result = RCompareOK_TypeArrayArray_TypeArrayArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
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


        public virtual System.Byte[] get_signature_local()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rget_signature_local.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] get_signature_field()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rget_signature_field.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] GetSignature()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSignature.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module  @mod, System.Reflection.CallingConventions  @callingConvention, System.Runtime.InteropServices.CallingConvention  @unmanagedCallingConvention, System.Type  @returnType, System.Type[]  @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mod, @callingConvention, @unmanagedCallingConvention, @returnType, @parameters};
            var ___result = RGetMethodSigHelper_Module_CallingConventions_CallingConvention_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public virtual void System__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetIDsOfNames(in System.Guid  @riid, System.IntPtr  @rgszNames, System.UInt32  @cNames, System.UInt32  @lcid, System.IntPtr  @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetTypeInfo(System.UInt32  @iTInfo, System.UInt32  @lcid, System.IntPtr  @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetTypeInfoCount(out System.UInt32  @pcTInfo)
        {
			pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__0__Runtime__0__InteropServices__0___SignatureHelper__0__Invoke(System.UInt32  @dispIdMember, in System.Guid  @riid, System.UInt32  @lcid, System.Int16  @wFlags, System.IntPtr  @pDispParams, System.IntPtr  @pVarResult, System.IntPtr  @pExcepInfo, System.IntPtr  @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RSystem__0__Runtime__0__InteropServices__0___SignatureHelper__0__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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
