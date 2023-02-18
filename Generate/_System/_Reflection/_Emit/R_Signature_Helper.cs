
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.SignatureHelper
	/// </summary>
    public partial class RSignatureHelper : RMember //
    {

		/// <summary>
		/// System.Reflection.Emit.ModuleBuilder module
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RModuleBuilder r_Fmodule;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RModuleBuilder RFmodule
		{
			get
			{
				if(r_Fmodule == null)
				{
					r_Fmodule = new(this, "module");
					r_Fmodule.SetBelong(this.GetValue());
				}
				return r_Fmodule;
			}
		}

		/// <summary>
		/// System.Type[] arguments
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType> r_Farguments;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType> RFarguments
		{
			get
			{
				if(r_Farguments == null)
				{
					r_Farguments = new(this, "arguments");
					r_Farguments.SetBelong(this.GetValue());
				}
				return r_Farguments;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper+SignatureHelperType type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RSignatureHelper.RSignatureHelperType r_Ftype;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RSignatureHelper.RSignatureHelperType RFtype
		{
			get
			{
				if(r_Ftype == null)
				{
					r_Ftype = new(this, "type");
					r_Ftype.SetBelong(this.GetValue());
				}
				return r_Ftype;
			}
		}

		/// <summary>
		/// System.Type returnType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RType r_FreturnType;
		public virtual Hvak.Editor.Refleaction.RSystem.RType RFreturnType
		{
			get
			{
				if(r_FreturnType == null)
				{
					r_FreturnType = new(this, "returnType");
					r_FreturnType.SetBelong(this.GetValue());
				}
				return r_FreturnType;
			}
		}

		/// <summary>
		/// System.Reflection.CallingConventions callConv
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RCallingConventions r_FcallConv;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RCallingConventions RFcallConv
		{
			get
			{
				if(r_FcallConv == null)
				{
					r_FcallConv = new(this, "callConv");
					r_FcallConv.SetBelong(this.GetValue());
				}
				return r_FcallConv;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.CallingConvention unmanagedCallConv
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RCallingConvention r_FunmanagedCallConv;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RCallingConvention RFunmanagedCallConv
		{
			get
			{
				if(r_FunmanagedCallConv == null)
				{
					r_FunmanagedCallConv = new(this, "unmanagedCallConv");
					r_FunmanagedCallConv.SetBelong(this.GetValue());
				}
				return r_FunmanagedCallConv;
			}
		}

		/// <summary>
		/// System.Type[][] modreqs
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType>> r_Fmodreqs;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType>> RFmodreqs
		{
			get
			{
				if(r_Fmodreqs == null)
				{
					r_Fmodreqs = new(this, "modreqs");
					r_Fmodreqs.SetBelong(this.GetValue());
				}
				return r_Fmodreqs;
			}
		}

		/// <summary>
		/// System.Type[][] modopts
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType>> r_Fmodopts;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RType>> RFmodopts
		{
			get
			{
				if(r_Fmodopts == null)
				{
					r_Fmodopts = new(this, "modopts");
					r_Fmodopts.SetBelong(this.GetValue());
				}
				return r_Fmodopts;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper GetFieldSigHelper(System.Reflection.Module)
		/// </summary>
		protected static RMethod r_MGetFieldSigHelper_Module;
		public static RMethod RMGetFieldSigHelper_Module
		{
			get
			{
				if(r_MGetFieldSigHelper_Module == null)
				{
					r_MGetFieldSigHelper_Module = new(typeof(System.Reflection.Emit.SignatureHelper), "GetFieldSigHelper", 0, typeof(System.Reflection.Module));
					r_MGetFieldSigHelper_Module.SetBelong(null);
				}
				return r_MGetFieldSigHelper_Module;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper GetLocalVarSigHelper(System.Reflection.Module)
		/// </summary>
		protected static RMethod r_MGetLocalVarSigHelper_Module;
		public static RMethod RMGetLocalVarSigHelper_Module
		{
			get
			{
				if(r_MGetLocalVarSigHelper_Module == null)
				{
					r_MGetLocalVarSigHelper_Module = new(typeof(System.Reflection.Emit.SignatureHelper), "GetLocalVarSigHelper", 0, typeof(System.Reflection.Module));
					r_MGetLocalVarSigHelper_Module.SetBelong(null);
				}
				return r_MGetLocalVarSigHelper_Module;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper GetLocalVarSigHelper()
		/// </summary>
		protected static RMethod r_MGetLocalVarSigHelper;
		public static RMethod RMGetLocalVarSigHelper
		{
			get
			{
				if(r_MGetLocalVarSigHelper == null)
				{
					r_MGetLocalVarSigHelper = new(typeof(System.Reflection.Emit.SignatureHelper), "GetLocalVarSigHelper", 0);
					r_MGetLocalVarSigHelper.SetBelong(null);
				}
				return r_MGetLocalVarSigHelper;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.CallingConventions, System.Type)
		/// </summary>
		protected static RMethod r_MGetMethodSigHelper_CallingConventions_Type;
		public static RMethod RMGetMethodSigHelper_CallingConventions_Type
		{
			get
			{
				if(r_MGetMethodSigHelper_CallingConventions_Type == null)
				{
					r_MGetMethodSigHelper_CallingConventions_Type = new(typeof(System.Reflection.Emit.SignatureHelper), "GetMethodSigHelper", 0, typeof(System.Reflection.CallingConventions), typeof(System.Type));
					r_MGetMethodSigHelper_CallingConventions_Type.SetBelong(null);
				}
				return r_MGetMethodSigHelper_CallingConventions_Type;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Runtime.InteropServices.CallingConvention, System.Type)
		/// </summary>
		protected static RMethod r_MGetMethodSigHelper_CallingConvention_Type;
		public static RMethod RMGetMethodSigHelper_CallingConvention_Type
		{
			get
			{
				if(r_MGetMethodSigHelper_CallingConvention_Type == null)
				{
					r_MGetMethodSigHelper_CallingConvention_Type = new(typeof(System.Reflection.Emit.SignatureHelper), "GetMethodSigHelper", 0, typeof(System.Runtime.InteropServices.CallingConvention), typeof(System.Type));
					r_MGetMethodSigHelper_CallingConvention_Type.SetBelong(null);
				}
				return r_MGetMethodSigHelper_CallingConvention_Type;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module, System.Reflection.CallingConventions, System.Type)
		/// </summary>
		protected static RMethod r_MGetMethodSigHelper_Module_CallingConventions_Type;
		public static RMethod RMGetMethodSigHelper_Module_CallingConventions_Type
		{
			get
			{
				if(r_MGetMethodSigHelper_Module_CallingConventions_Type == null)
				{
					r_MGetMethodSigHelper_Module_CallingConventions_Type = new(typeof(System.Reflection.Emit.SignatureHelper), "GetMethodSigHelper", 0, typeof(System.Reflection.Module), typeof(System.Reflection.CallingConventions), typeof(System.Type));
					r_MGetMethodSigHelper_Module_CallingConventions_Type.SetBelong(null);
				}
				return r_MGetMethodSigHelper_Module_CallingConventions_Type;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module, System.Runtime.InteropServices.CallingConvention, System.Type)
		/// </summary>
		protected static RMethod r_MGetMethodSigHelper_Module_CallingConvention_Type;
		public static RMethod RMGetMethodSigHelper_Module_CallingConvention_Type
		{
			get
			{
				if(r_MGetMethodSigHelper_Module_CallingConvention_Type == null)
				{
					r_MGetMethodSigHelper_Module_CallingConvention_Type = new(typeof(System.Reflection.Emit.SignatureHelper), "GetMethodSigHelper", 0, typeof(System.Reflection.Module), typeof(System.Runtime.InteropServices.CallingConvention), typeof(System.Type));
					r_MGetMethodSigHelper_Module_CallingConvention_Type.SetBelong(null);
				}
				return r_MGetMethodSigHelper_Module_CallingConvention_Type;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module, System.Type, System.Type[])
		/// </summary>
		protected static RMethod r_MGetMethodSigHelper_Module_Type_TypeArray;
		public static RMethod RMGetMethodSigHelper_Module_Type_TypeArray
		{
			get
			{
				if(r_MGetMethodSigHelper_Module_Type_TypeArray == null)
				{
					r_MGetMethodSigHelper_Module_Type_TypeArray = new(typeof(System.Reflection.Emit.SignatureHelper), "GetMethodSigHelper", 0, typeof(System.Reflection.Module), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_MGetMethodSigHelper_Module_Type_TypeArray.SetBelong(null);
				}
				return r_MGetMethodSigHelper_Module_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper GetPropertySigHelper(System.Reflection.Module, System.Type, System.Type[])
		/// </summary>
		protected static RMethod r_MGetPropertySigHelper_Module_Type_TypeArray;
		public static RMethod RMGetPropertySigHelper_Module_Type_TypeArray
		{
			get
			{
				if(r_MGetPropertySigHelper_Module_Type_TypeArray == null)
				{
					r_MGetPropertySigHelper_Module_Type_TypeArray = new(typeof(System.Reflection.Emit.SignatureHelper), "GetPropertySigHelper", 0, typeof(System.Reflection.Module), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_MGetPropertySigHelper_Module_Type_TypeArray.SetBelong(null);
				}
				return r_MGetPropertySigHelper_Module_Type_TypeArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper GetPropertySigHelper(System.Reflection.Module, System.Type, System.Type[], System.Type[], System.Type[], System.Type[][], System.Type[][])
		/// </summary>
		protected static RMethod r_MGetPropertySigHelper_Module_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
		public static RMethod RMGetPropertySigHelper_Module_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray
		{
			get
			{
				if(r_MGetPropertySigHelper_Module_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray == null)
				{
					r_MGetPropertySigHelper_Module_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray = new(typeof(System.Reflection.Emit.SignatureHelper), "GetPropertySigHelper", 0, typeof(System.Reflection.Module), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType());
					r_MGetPropertySigHelper_Module_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.SetBelong(null);
				}
				return r_MGetPropertySigHelper_Module_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SignatureHelper GetPropertySigHelper(System.Reflection.Module, System.Reflection.CallingConventions, System.Type, System.Type[], System.Type[], System.Type[], System.Type[][], System.Type[][])
		/// </summary>
		protected static RMethod r_MGetPropertySigHelper_Module_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
		public static RMethod RMGetPropertySigHelper_Module_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray
		{
			get
			{
				if(r_MGetPropertySigHelper_Module_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray == null)
				{
					r_MGetPropertySigHelper_Module_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray = new(typeof(System.Reflection.Emit.SignatureHelper), "GetPropertySigHelper", 0, typeof(System.Reflection.Module), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType());
					r_MGetPropertySigHelper_Module_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.SetBelong(null);
				}
				return r_MGetPropertySigHelper_Module_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray;
			}
		}

		/// <summary>
		/// Int32 AppendArray(System.Type[] ByRef, System.Type)
		/// </summary>
		protected static RMethod r_MAppendArray_Ref_TypeArray_Type;
		public static RMethod RMAppendArray_Ref_TypeArray_Type
		{
			get
			{
				if(r_MAppendArray_Ref_TypeArray_Type == null)
				{
					r_MAppendArray_Ref_TypeArray_Type = new(typeof(System.Reflection.Emit.SignatureHelper), "AppendArray", 0, typeof(System.Type).MakeArrayType().MakeByRefType(), typeof(System.Type));
					r_MAppendArray_Ref_TypeArray_Type.SetBelong(null);
				}
				return r_MAppendArray_Ref_TypeArray_Type;
			}
		}

		/// <summary>
		/// Void AppendArrayAt(System.Type[][] ByRef, System.Type[], Int32)
		/// </summary>
		protected static RMethod r_MAppendArrayAt_Ref_TypeArrayArray_TypeArray_Int32;
		public static RMethod RMAppendArrayAt_Ref_TypeArrayArray_TypeArray_Int32
		{
			get
			{
				if(r_MAppendArrayAt_Ref_TypeArrayArray_TypeArray_Int32 == null)
				{
					r_MAppendArrayAt_Ref_TypeArrayArray_TypeArray_Int32 = new(typeof(System.Reflection.Emit.SignatureHelper), "AppendArrayAt", 0, typeof(System.Type).MakeArrayType().MakeArrayType().MakeByRefType(), typeof(System.Type).MakeArrayType(), typeof(System.Int32));
					r_MAppendArrayAt_Ref_TypeArrayArray_TypeArray_Int32.SetBelong(null);
				}
				return r_MAppendArrayAt_Ref_TypeArrayArray_TypeArray_Int32;
			}
		}

		/// <summary>
		/// Void ValidateParameterModifiers(System.String, System.Type[])
		/// </summary>
		protected static RMethod r_MValidateParameterModifiers_String_TypeArray;
		public static RMethod RMValidateParameterModifiers_String_TypeArray
		{
			get
			{
				if(r_MValidateParameterModifiers_String_TypeArray == null)
				{
					r_MValidateParameterModifiers_String_TypeArray = new(typeof(System.Reflection.Emit.SignatureHelper), "ValidateParameterModifiers", 0, typeof(System.String), typeof(System.Type).MakeArrayType());
					r_MValidateParameterModifiers_String_TypeArray.SetBelong(null);
				}
				return r_MValidateParameterModifiers_String_TypeArray;
			}
		}

		/// <summary>
		/// Void ValidateCustomModifier(Int32, System.Type[][], System.String)
		/// </summary>
		protected static RMethod r_MValidateCustomModifier_Int32_TypeArrayArray_String;
		public static RMethod RMValidateCustomModifier_Int32_TypeArrayArray_String
		{
			get
			{
				if(r_MValidateCustomModifier_Int32_TypeArrayArray_String == null)
				{
					r_MValidateCustomModifier_Int32_TypeArrayArray_String = new(typeof(System.Reflection.Emit.SignatureHelper), "ValidateCustomModifier", 0, typeof(System.Int32), typeof(System.Type).MakeArrayType().MakeArrayType(), typeof(System.String));
					r_MValidateCustomModifier_Int32_TypeArrayArray_String.SetBelong(null);
				}
				return r_MValidateCustomModifier_Int32_TypeArrayArray_String;
			}
		}

		/// <summary>
		/// System.Exception MissingFeature()
		/// </summary>
		protected static RMethod r_MMissingFeature;
		public static RMethod RMMissingFeature
		{
			get
			{
				if(r_MMissingFeature == null)
				{
					r_MMissingFeature = new(typeof(System.Reflection.Emit.SignatureHelper), "MissingFeature", 0);
					r_MMissingFeature.SetBelong(null);
				}
				return r_MMissingFeature;
			}
		}

		/// <summary>
		/// Void AddArguments(System.Type[], System.Type[][], System.Type[][])
		/// </summary>
		protected RMethod r_MAddArguments_TypeArray_TypeArrayArray_TypeArrayArray;
		public virtual RMethod RMAddArguments_TypeArray_TypeArrayArray_TypeArrayArray
		{
			get
			{
				if(r_MAddArguments_TypeArray_TypeArrayArray_TypeArrayArray == null)
				{
					r_MAddArguments_TypeArray_TypeArrayArray_TypeArrayArray = new(this, "AddArguments", 0, typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType());
					r_MAddArguments_TypeArray_TypeArrayArray_TypeArrayArray.SetBelong(this.GetValue());
				}
				return r_MAddArguments_TypeArray_TypeArrayArray_TypeArrayArray;
			}
		}

		/// <summary>
		/// Void AddArgument(System.Type, Boolean)
		/// </summary>
		protected RMethod r_MAddArgument_Type_Boolean;
		public virtual RMethod RMAddArgument_Type_Boolean
		{
			get
			{
				if(r_MAddArgument_Type_Boolean == null)
				{
					r_MAddArgument_Type_Boolean = new(this, "AddArgument", 0, typeof(System.Type), typeof(System.Boolean));
					r_MAddArgument_Type_Boolean.SetBelong(this.GetValue());
				}
				return r_MAddArgument_Type_Boolean;
			}
		}

		/// <summary>
		/// Void AddArgument(System.Type, System.Type[], System.Type[])
		/// </summary>
		protected RMethod r_MAddArgument_Type_TypeArray_TypeArray;
		public virtual RMethod RMAddArgument_Type_TypeArray_TypeArray
		{
			get
			{
				if(r_MAddArgument_Type_TypeArray_TypeArray == null)
				{
					r_MAddArgument_Type_TypeArray_TypeArray = new(this, "AddArgument", 0, typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_MAddArgument_Type_TypeArray_TypeArray.SetBelong(this.GetValue());
				}
				return r_MAddArgument_Type_TypeArray_TypeArray;
			}
		}

		/// <summary>
		/// Void AddArgument(System.Type)
		/// </summary>
		protected RMethod r_MAddArgument_Type;
		public virtual RMethod RMAddArgument_Type
		{
			get
			{
				if(r_MAddArgument_Type == null)
				{
					r_MAddArgument_Type = new(this, "AddArgument", 0, typeof(System.Type));
					r_MAddArgument_Type.SetBelong(this.GetValue());
				}
				return r_MAddArgument_Type;
			}
		}

		/// <summary>
		/// Void AddSentinel()
		/// </summary>
		protected RMethod r_MAddSentinel;
		public virtual RMethod RMAddSentinel
		{
			get
			{
				if(r_MAddSentinel == null)
				{
					r_MAddSentinel = new(this, "AddSentinel", 0);
					r_MAddSentinel.SetBelong(this.GetValue());
				}
				return r_MAddSentinel;
			}
		}

		/// <summary>
		/// Boolean CompareOK(System.Type[][], System.Type[][])
		/// </summary>
		protected static RMethod r_MCompareOK_TypeArrayArray_TypeArrayArray;
		public static RMethod RMCompareOK_TypeArrayArray_TypeArrayArray
		{
			get
			{
				if(r_MCompareOK_TypeArrayArray_TypeArrayArray == null)
				{
					r_MCompareOK_TypeArrayArray_TypeArrayArray = new(typeof(System.Reflection.Emit.SignatureHelper), "CompareOK", 0, typeof(System.Type).MakeArrayType().MakeArrayType(), typeof(System.Type).MakeArrayType().MakeArrayType());
					r_MCompareOK_TypeArrayArray_TypeArrayArray.SetBelong(null);
				}
				return r_MCompareOK_TypeArrayArray_TypeArrayArray;
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
		/// Byte[] get_signature_local()
		/// </summary>
		protected RMethod r_Mget_signature_local;
		public virtual RMethod RMget_signature_local
		{
			get
			{
				if(r_Mget_signature_local == null)
				{
					r_Mget_signature_local = new(this, "get_signature_local", 0);
					r_Mget_signature_local.SetBelong(this.GetValue());
				}
				return r_Mget_signature_local;
			}
		}

		/// <summary>
		/// Byte[] get_signature_field()
		/// </summary>
		protected RMethod r_Mget_signature_field;
		public virtual RMethod RMget_signature_field
		{
			get
			{
				if(r_Mget_signature_field == null)
				{
					r_Mget_signature_field = new(this, "get_signature_field", 0);
					r_Mget_signature_field.SetBelong(this.GetValue());
				}
				return r_Mget_signature_field;
			}
		}

		/// <summary>
		/// Byte[] GetSignature()
		/// </summary>
		protected RMethod r_MGetSignature;
		public virtual RMethod RMGetSignature
		{
			get
			{
				if(r_MGetSignature == null)
				{
					r_MGetSignature = new(this, "GetSignature", 0);
					r_MGetSignature.SetBelong(this.GetValue());
				}
				return r_MGetSignature;
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
		/// System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module, System.Reflection.CallingConventions, System.Runtime.InteropServices.CallingConvention, System.Type, System.Type[])
		/// </summary>
		protected static RMethod r_MGetMethodSigHelper_Module_CallingConventions_CallingConvention_Type_TypeArray;
		public static RMethod RMGetMethodSigHelper_Module_CallingConventions_CallingConvention_Type_TypeArray
		{
			get
			{
				if(r_MGetMethodSigHelper_Module_CallingConventions_CallingConvention_Type_TypeArray == null)
				{
					r_MGetMethodSigHelper_Module_CallingConventions_CallingConvention_Type_TypeArray = new(typeof(System.Reflection.Emit.SignatureHelper), "GetMethodSigHelper", 0, typeof(System.Reflection.Module), typeof(System.Reflection.CallingConventions), typeof(System.Runtime.InteropServices.CallingConvention), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_MGetMethodSigHelper_Module_CallingConventions_CallingConvention_Type_TypeArray.SetBelong(null);
				}
				return r_MGetMethodSigHelper_Module_CallingConventions_CallingConvention_Type_TypeArray;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._SignatureHelper.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._SignatureHelper.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.GetValue());
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._SignatureHelper.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._SignatureHelper.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.GetValue());
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._SignatureHelper.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._SignatureHelper.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_MSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetTypeInfoCount_Out_UInt32.SetBelong(this.GetValue());
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._SignatureHelper.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._SignatureHelper.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.GetValue());
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
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

        public static System.Reflection.Emit.SignatureHelper GetFieldSigHelper(System.Reflection.Module @mod)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mod};
            var ___result = RMGetFieldSigHelper_Module.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public static System.Reflection.Emit.SignatureHelper GetLocalVarSigHelper(System.Reflection.Module @mod)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mod};
            var ___result = RMGetLocalVarSigHelper_Module.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public static System.Reflection.Emit.SignatureHelper GetLocalVarSigHelper()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLocalVarSigHelper.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.CallingConventions @callingConvention, System.Type @returnType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callingConvention, @returnType};
            var ___result = RMGetMethodSigHelper_CallingConventions_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Runtime.InteropServices.CallingConvention @unmanagedCallingConvention, System.Type @returnType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@unmanagedCallingConvention, @returnType};
            var ___result = RMGetMethodSigHelper_CallingConvention_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module @mod, System.Reflection.CallingConventions @callingConvention, System.Type @returnType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mod, @callingConvention, @returnType};
            var ___result = RMGetMethodSigHelper_Module_CallingConventions_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module @mod, System.Runtime.InteropServices.CallingConvention @unmanagedCallConv, System.Type @returnType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mod, @unmanagedCallConv, @returnType};
            var ___result = RMGetMethodSigHelper_Module_CallingConvention_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module @mod, System.Type @returnType, System.Type[] @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mod, @returnType, @parameterTypes};
            var ___result = RMGetMethodSigHelper_Module_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public static System.Reflection.Emit.SignatureHelper GetPropertySigHelper(System.Reflection.Module @mod, System.Type @returnType, System.Type[] @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mod, @returnType, @parameterTypes};
            var ___result = RMGetPropertySigHelper_Module_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public static System.Reflection.Emit.SignatureHelper GetPropertySigHelper(System.Reflection.Module @mod, System.Type @returnType, System.Type[] @requiredReturnTypeCustomModifiers, System.Type[] @optionalReturnTypeCustomModifiers, System.Type[] @parameterTypes, System.Type[][] @requiredParameterTypeCustomModifiers, System.Type[][] @optionalParameterTypeCustomModifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mod, @returnType, @requiredReturnTypeCustomModifiers, @optionalReturnTypeCustomModifiers, @parameterTypes, @requiredParameterTypeCustomModifiers, @optionalParameterTypeCustomModifiers};
            var ___result = RMGetPropertySigHelper_Module_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public static System.Reflection.Emit.SignatureHelper GetPropertySigHelper(System.Reflection.Module @mod, System.Reflection.CallingConventions @callingConvention, System.Type @returnType, System.Type[] @requiredReturnTypeCustomModifiers, System.Type[] @optionalReturnTypeCustomModifiers, System.Type[] @parameterTypes, System.Type[][] @requiredParameterTypeCustomModifiers, System.Type[][] @optionalParameterTypeCustomModifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mod, @callingConvention, @returnType, @requiredReturnTypeCustomModifiers, @optionalReturnTypeCustomModifiers, @parameterTypes, @requiredParameterTypeCustomModifiers, @optionalParameterTypeCustomModifiers};
            var ___result = RMGetPropertySigHelper_Module_CallingConventions_Type_TypeArray_TypeArray_TypeArray_TypeArrayArray_TypeArrayArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public static System.Int32 AppendArray(ref System.Type[] @array, System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @t};
            var ___result = RMAppendArray_Ref_TypeArray_Type.Invoke(___genericsType, ___parameters);
			@array = (System.Type[])___parameters[0];

            return (System.Int32)___result;
        }


        public static void AppendArrayAt(ref System.Type[][] @array, System.Type[] @t, System.Int32 @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @t, @pos};
            var ___result = RMAppendArrayAt_Ref_TypeArrayArray_TypeArray_Int32.Invoke(___genericsType, ___parameters);
			@array = (System.Type[][])___parameters[0];

            
        }


        public static void ValidateParameterModifiers(System.String @name, System.Type[] @parameter_modifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @parameter_modifiers};
            var ___result = RMValidateParameterModifiers_String_TypeArray.Invoke(___genericsType, ___parameters);

            
        }


        public static void ValidateCustomModifier(System.Int32 @n, System.Type[][] @custom_modifiers, System.String @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@n, @custom_modifiers, @name};
            var ___result = RMValidateCustomModifier_Int32_TypeArrayArray_String.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Exception MissingFeature()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMissingFeature.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual void AddArguments(System.Type[] @arguments, System.Type[][] @requiredCustomModifiers, System.Type[][] @optionalCustomModifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arguments, @requiredCustomModifiers, @optionalCustomModifiers};
            var ___result = RMAddArguments_TypeArray_TypeArrayArray_TypeArrayArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddArgument(System.Type @argument, System.Boolean @pinned)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@argument, @pinned};
            var ___result = RMAddArgument_Type_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddArgument(System.Type @argument, System.Type[] @requiredCustomModifiers, System.Type[] @optionalCustomModifiers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@argument, @requiredCustomModifiers, @optionalCustomModifiers};
            var ___result = RMAddArgument_Type_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddArgument(System.Type @clsArgument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clsArgument};
            var ___result = RMAddArgument_Type.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddSentinel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddSentinel.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean CompareOK(System.Type[][] @one, System.Type[][] @two)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@one, @two};
            var ___result = RMCompareOK_TypeArrayArray_TypeArrayArray.Invoke(___genericsType, ___parameters);

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


        public virtual System.Byte[] get_signature_local()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMget_signature_local.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] get_signature_field()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMget_signature_field.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] GetSignature()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetSignature.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Reflection.Emit.SignatureHelper GetMethodSigHelper(System.Reflection.Module @mod, System.Reflection.CallingConventions @callingConvention, System.Runtime.InteropServices.CallingConvention @unmanagedCallingConvention, System.Type @returnType, System.Type[] @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mod, @callingConvention, @unmanagedCallingConvention, @returnType, @parameters};
            var ___result = RMGetMethodSigHelper_Module_CallingConventions_CallingConvention_Type_TypeArray.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.SignatureHelper)___result;
        }


        public virtual void System__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___SignatureHelper__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___SignatureHelper__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
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
