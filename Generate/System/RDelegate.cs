using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.Delegate
	/// </summary>
    public partial class RDelegate : RMember //
    {

		/// <summary>
		/// System.IntPtr method_ptr
		/// </summary>
		protected RField r_method_ptr;
		public virtual RField Rmethod_ptr
		{
			get
			{
				if(r_method_ptr == null)
				{
					r_method_ptr = new(this, "method_ptr");
					r_method_ptr.SetBelong(this.instance);
				}
				return r_method_ptr;
			}
		}

		/// <summary>
		/// System.IntPtr invoke_impl
		/// </summary>
		protected RField r_invoke_impl;
		public virtual RField Rinvoke_impl
		{
			get
			{
				if(r_invoke_impl == null)
				{
					r_invoke_impl = new(this, "invoke_impl");
					r_invoke_impl.SetBelong(this.instance);
				}
				return r_invoke_impl;
			}
		}

		/// <summary>
		/// System.Object m_target
		/// </summary>
		protected RSystem.RObject r_m_target;
		public virtual RSystem.RObject Rm_target
		{
			get
			{
				if(r_m_target == null)
				{
					r_m_target = new(this, "m_target");
					r_m_target.SetBelong(this.instance);
				}
				return r_m_target;
			}
		}

		/// <summary>
		/// System.IntPtr method
		/// </summary>
		protected RField r_method;
		public virtual RField Rmethod
		{
			get
			{
				if(r_method == null)
				{
					r_method = new(this, "method");
					r_method.SetBelong(this.instance);
				}
				return r_method;
			}
		}

		/// <summary>
		/// System.IntPtr delegate_trampoline
		/// </summary>
		protected RField r_delegate_trampoline;
		public virtual RField Rdelegate_trampoline
		{
			get
			{
				if(r_delegate_trampoline == null)
				{
					r_delegate_trampoline = new(this, "delegate_trampoline");
					r_delegate_trampoline.SetBelong(this.instance);
				}
				return r_delegate_trampoline;
			}
		}

		/// <summary>
		/// System.IntPtr extra_arg
		/// </summary>
		protected RField r_extra_arg;
		public virtual RField Rextra_arg
		{
			get
			{
				if(r_extra_arg == null)
				{
					r_extra_arg = new(this, "extra_arg");
					r_extra_arg.SetBelong(this.instance);
				}
				return r_extra_arg;
			}
		}

		/// <summary>
		/// System.IntPtr method_code
		/// </summary>
		protected RField r_method_code;
		public virtual RField Rmethod_code
		{
			get
			{
				if(r_method_code == null)
				{
					r_method_code = new(this, "method_code");
					r_method_code.SetBelong(this.instance);
				}
				return r_method_code;
			}
		}

		/// <summary>
		/// System.IntPtr interp_method
		/// </summary>
		protected RField r_interp_method;
		public virtual RField Rinterp_method
		{
			get
			{
				if(r_interp_method == null)
				{
					r_interp_method = new(this, "interp_method");
					r_interp_method.SetBelong(this.instance);
				}
				return r_interp_method;
			}
		}

		/// <summary>
		/// System.IntPtr interp_invoke_impl
		/// </summary>
		protected RField r_interp_invoke_impl;
		public virtual RField Rinterp_invoke_impl
		{
			get
			{
				if(r_interp_invoke_impl == null)
				{
					r_interp_invoke_impl = new(this, "interp_invoke_impl");
					r_interp_invoke_impl.SetBelong(this.instance);
				}
				return r_interp_invoke_impl;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo method_info
		/// </summary>
		protected RSystem.RReflection.RMethodInfo r_method_info;
		public virtual RSystem.RReflection.RMethodInfo Rmethod_info
		{
			get
			{
				if(r_method_info == null)
				{
					r_method_info = new(this, "method_info");
					r_method_info.SetBelong(this.instance);
				}
				return r_method_info;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo original_method_info
		/// </summary>
		protected RSystem.RReflection.RMethodInfo r_original_method_info;
		public virtual RSystem.RReflection.RMethodInfo Roriginal_method_info
		{
			get
			{
				if(r_original_method_info == null)
				{
					r_original_method_info = new(this, "original_method_info");
					r_original_method_info.SetBelong(this.instance);
				}
				return r_original_method_info;
			}
		}

		/// <summary>
		/// System.DelegateData data
		/// </summary>
		protected RSystem.RDelegateData r_data;
		public virtual RSystem.RDelegateData Rdata
		{
			get
			{
				if(r_data == null)
				{
					r_data = new(this, "data");
					r_data.SetBelong(this.instance);
				}
				return r_data;
			}
		}

		/// <summary>
		/// System.Boolean method_is_virtual
		/// </summary>
		protected RField r_method_is_virtual;
		public virtual RField Rmethod_is_virtual
		{
			get
			{
				if(r_method_is_virtual == null)
				{
					r_method_is_virtual = new(this, "method_is_virtual");
					r_method_is_virtual.SetBelong(this.instance);
				}
				return r_method_is_virtual;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo Method
		/// </summary>
		protected RSystem.RReflection.RMethodInfo r_Method;
		public virtual RSystem.RReflection.RMethodInfo RMethod
		{
			get
			{
				if(r_Method == null)
				{
					r_Method = new(this, "Method", -1);
					r_Method.SetBelong(this.instance);
				}
				return r_Method;
			}
		}

		/// <summary>
		/// System.Object Target
		/// </summary>
		protected RSystem.RObject r_Target;
		public virtual RSystem.RObject RTarget
		{
			get
			{
				if(r_Target == null)
				{
					r_Target = new(this, "Target", -1);
					r_Target.SetBelong(this.instance);
				}
				return r_Target;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetVirtualMethod_internal()
		/// </summary>
		protected RMethod r_GetVirtualMethod_internal;
		public virtual RMethod RGetVirtualMethod_internal
		{
			get
			{
				if(r_GetVirtualMethod_internal == null)
				{
					r_GetVirtualMethod_internal = new(this, "GetVirtualMethod_internal", 0);
					r_GetVirtualMethod_internal.SetBelong(this.instance);
				}
				return r_GetVirtualMethod_internal;
			}
		}

		/// <summary>
		/// IntPtr GetNativeFunctionPointer()
		/// </summary>
		protected RMethod r_GetNativeFunctionPointer;
		public virtual RMethod RGetNativeFunctionPointer
		{
			get
			{
				if(r_GetNativeFunctionPointer == null)
				{
					r_GetNativeFunctionPointer = new(this, "GetNativeFunctionPointer", 0);
					r_GetNativeFunctionPointer.SetBelong(this.instance);
				}
				return r_GetNativeFunctionPointer;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate_internal(System.Type, System.Object, System.Reflection.MethodInfo, Boolean)
		/// </summary>
		protected static RMethod r_CreateDelegate_internal_Type_Object_MethodInfo_Boolean;
		public static RMethod RCreateDelegate_internal_Type_Object_MethodInfo_Boolean
		{
			get
			{
				if(r_CreateDelegate_internal_Type_Object_MethodInfo_Boolean == null)
				{
					r_CreateDelegate_internal_Type_Object_MethodInfo_Boolean = new(typeof(System.Delegate), "CreateDelegate_internal", 0, typeof(System.Type), typeof(System.Object), typeof(System.Reflection.MethodInfo), typeof(System.Boolean));
					r_CreateDelegate_internal_Type_Object_MethodInfo_Boolean.SetBelong(null);
				}
				return r_CreateDelegate_internal_Type_Object_MethodInfo_Boolean;
			}
		}

		/// <summary>
		/// Boolean arg_type_match(System.Type, System.Type)
		/// </summary>
		protected static RMethod r_arg_type_match_Type_Type;
		public static RMethod Rarg_type_match_Type_Type
		{
			get
			{
				if(r_arg_type_match_Type_Type == null)
				{
					r_arg_type_match_Type_Type = new(typeof(System.Delegate), "arg_type_match", 0, typeof(System.Type), typeof(System.Type));
					r_arg_type_match_Type_Type.SetBelong(null);
				}
				return r_arg_type_match_Type_Type;
			}
		}

		/// <summary>
		/// Boolean arg_type_match_this(System.Type, System.Type, Boolean)
		/// </summary>
		protected static RMethod r_arg_type_match_this_Type_Type_Boolean;
		public static RMethod Rarg_type_match_this_Type_Type_Boolean
		{
			get
			{
				if(r_arg_type_match_this_Type_Type_Boolean == null)
				{
					r_arg_type_match_this_Type_Type_Boolean = new(typeof(System.Delegate), "arg_type_match_this", 0, typeof(System.Type), typeof(System.Type), typeof(System.Boolean));
					r_arg_type_match_this_Type_Type_Boolean.SetBelong(null);
				}
				return r_arg_type_match_this_Type_Type_Boolean;
			}
		}

		/// <summary>
		/// Boolean return_type_match(System.Type, System.Type)
		/// </summary>
		protected static RMethod r_return_type_match_Type_Type;
		public static RMethod Rreturn_type_match_Type_Type
		{
			get
			{
				if(r_return_type_match_Type_Type == null)
				{
					r_return_type_match_Type_Type = new(typeof(System.Delegate), "return_type_match", 0, typeof(System.Type), typeof(System.Type));
					r_return_type_match_Type_Type.SetBelong(null);
				}
				return r_return_type_match_Type_Type;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Object, System.Reflection.MethodInfo, Boolean)
		/// </summary>
		protected static RMethod r_CreateDelegate_Type_Object_MethodInfo_Boolean;
		public static RMethod RCreateDelegate_Type_Object_MethodInfo_Boolean
		{
			get
			{
				if(r_CreateDelegate_Type_Object_MethodInfo_Boolean == null)
				{
					r_CreateDelegate_Type_Object_MethodInfo_Boolean = new(typeof(System.Delegate), "CreateDelegate", 0, typeof(System.Type), typeof(System.Object), typeof(System.Reflection.MethodInfo), typeof(System.Boolean));
					r_CreateDelegate_Type_Object_MethodInfo_Boolean.SetBelong(null);
				}
				return r_CreateDelegate_Type_Object_MethodInfo_Boolean;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Object, System.Reflection.MethodInfo, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_CreateDelegate_Type_Object_MethodInfo_Boolean_Boolean;
		public static RMethod RCreateDelegate_Type_Object_MethodInfo_Boolean_Boolean
		{
			get
			{
				if(r_CreateDelegate_Type_Object_MethodInfo_Boolean_Boolean == null)
				{
					r_CreateDelegate_Type_Object_MethodInfo_Boolean_Boolean = new(typeof(System.Delegate), "CreateDelegate", 0, typeof(System.Type), typeof(System.Object), typeof(System.Reflection.MethodInfo), typeof(System.Boolean), typeof(System.Boolean));
					r_CreateDelegate_Type_Object_MethodInfo_Boolean_Boolean.SetBelong(null);
				}
				return r_CreateDelegate_Type_Object_MethodInfo_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected static RMethod r_CreateDelegate_Type_Object_MethodInfo;
		public static RMethod RCreateDelegate_Type_Object_MethodInfo
		{
			get
			{
				if(r_CreateDelegate_Type_Object_MethodInfo == null)
				{
					r_CreateDelegate_Type_Object_MethodInfo = new(typeof(System.Delegate), "CreateDelegate", 0, typeof(System.Type), typeof(System.Object), typeof(System.Reflection.MethodInfo));
					r_CreateDelegate_Type_Object_MethodInfo.SetBelong(null);
				}
				return r_CreateDelegate_Type_Object_MethodInfo;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Reflection.MethodInfo, Boolean)
		/// </summary>
		protected static RMethod r_CreateDelegate_Type_MethodInfo_Boolean;
		public static RMethod RCreateDelegate_Type_MethodInfo_Boolean
		{
			get
			{
				if(r_CreateDelegate_Type_MethodInfo_Boolean == null)
				{
					r_CreateDelegate_Type_MethodInfo_Boolean = new(typeof(System.Delegate), "CreateDelegate", 0, typeof(System.Type), typeof(System.Reflection.MethodInfo), typeof(System.Boolean));
					r_CreateDelegate_Type_MethodInfo_Boolean.SetBelong(null);
				}
				return r_CreateDelegate_Type_MethodInfo_Boolean;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Reflection.MethodInfo)
		/// </summary>
		protected static RMethod r_CreateDelegate_Type_MethodInfo;
		public static RMethod RCreateDelegate_Type_MethodInfo
		{
			get
			{
				if(r_CreateDelegate_Type_MethodInfo == null)
				{
					r_CreateDelegate_Type_MethodInfo = new(typeof(System.Delegate), "CreateDelegate", 0, typeof(System.Type), typeof(System.Reflection.MethodInfo));
					r_CreateDelegate_Type_MethodInfo.SetBelong(null);
				}
				return r_CreateDelegate_Type_MethodInfo;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Object, System.String)
		/// </summary>
		protected static RMethod r_CreateDelegate_Type_Object_String;
		public static RMethod RCreateDelegate_Type_Object_String
		{
			get
			{
				if(r_CreateDelegate_Type_Object_String == null)
				{
					r_CreateDelegate_Type_Object_String = new(typeof(System.Delegate), "CreateDelegate", 0, typeof(System.Type), typeof(System.Object), typeof(System.String));
					r_CreateDelegate_Type_Object_String.SetBelong(null);
				}
				return r_CreateDelegate_Type_Object_String;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetCandidateMethod(System.Type, System.Type, System.String, System.Reflection.BindingFlags, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_GetCandidateMethod_Type_Type_String_BindingFlags_Boolean_Boolean;
		public static RMethod RGetCandidateMethod_Type_Type_String_BindingFlags_Boolean_Boolean
		{
			get
			{
				if(r_GetCandidateMethod_Type_Type_String_BindingFlags_Boolean_Boolean == null)
				{
					r_GetCandidateMethod_Type_Type_String_BindingFlags_Boolean_Boolean = new(typeof(System.Delegate), "GetCandidateMethod", 0, typeof(System.Type), typeof(System.Type), typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Boolean), typeof(System.Boolean));
					r_GetCandidateMethod_Type_Type_String_BindingFlags_Boolean_Boolean.SetBelong(null);
				}
				return r_GetCandidateMethod_Type_Type_String_BindingFlags_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Type, System.String, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_CreateDelegate_Type_Type_String_Boolean_Boolean;
		public static RMethod RCreateDelegate_Type_Type_String_Boolean_Boolean
		{
			get
			{
				if(r_CreateDelegate_Type_Type_String_Boolean_Boolean == null)
				{
					r_CreateDelegate_Type_Type_String_Boolean_Boolean = new(typeof(System.Delegate), "CreateDelegate", 0, typeof(System.Type), typeof(System.Type), typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
					r_CreateDelegate_Type_Type_String_Boolean_Boolean.SetBelong(null);
				}
				return r_CreateDelegate_Type_Type_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Type, System.String)
		/// </summary>
		protected static RMethod r_CreateDelegate_Type_Type_String;
		public static RMethod RCreateDelegate_Type_Type_String
		{
			get
			{
				if(r_CreateDelegate_Type_Type_String == null)
				{
					r_CreateDelegate_Type_Type_String = new(typeof(System.Delegate), "CreateDelegate", 0, typeof(System.Type), typeof(System.Type), typeof(System.String));
					r_CreateDelegate_Type_Type_String.SetBelong(null);
				}
				return r_CreateDelegate_Type_Type_String;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Type, System.String, Boolean)
		/// </summary>
		protected static RMethod r_CreateDelegate_Type_Type_String_Boolean;
		public static RMethod RCreateDelegate_Type_Type_String_Boolean
		{
			get
			{
				if(r_CreateDelegate_Type_Type_String_Boolean == null)
				{
					r_CreateDelegate_Type_Type_String_Boolean = new(typeof(System.Delegate), "CreateDelegate", 0, typeof(System.Type), typeof(System.Type), typeof(System.String), typeof(System.Boolean));
					r_CreateDelegate_Type_Type_String_Boolean.SetBelong(null);
				}
				return r_CreateDelegate_Type_Type_String_Boolean;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Object, System.String, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_CreateDelegate_Type_Object_String_Boolean_Boolean;
		public static RMethod RCreateDelegate_Type_Object_String_Boolean_Boolean
		{
			get
			{
				if(r_CreateDelegate_Type_Object_String_Boolean_Boolean == null)
				{
					r_CreateDelegate_Type_Object_String_Boolean_Boolean = new(typeof(System.Delegate), "CreateDelegate", 0, typeof(System.Type), typeof(System.Object), typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
					r_CreateDelegate_Type_Object_String_Boolean_Boolean.SetBelong(null);
				}
				return r_CreateDelegate_Type_Object_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Object, System.String, Boolean)
		/// </summary>
		protected static RMethod r_CreateDelegate_Type_Object_String_Boolean;
		public static RMethod RCreateDelegate_Type_Object_String_Boolean
		{
			get
			{
				if(r_CreateDelegate_Type_Object_String_Boolean == null)
				{
					r_CreateDelegate_Type_Object_String_Boolean = new(typeof(System.Delegate), "CreateDelegate", 0, typeof(System.Type), typeof(System.Object), typeof(System.String), typeof(System.Boolean));
					r_CreateDelegate_Type_Object_String_Boolean.SetBelong(null);
				}
				return r_CreateDelegate_Type_Object_String_Boolean;
			}
		}

		/// <summary>
		/// System.Object DynamicInvoke(System.Object[])
		/// </summary>
		protected RMethod r_DynamicInvoke_ObjectArray;
		public virtual RMethod RDynamicInvoke_ObjectArray
		{
			get
			{
				if(r_DynamicInvoke_ObjectArray == null)
				{
					r_DynamicInvoke_ObjectArray = new(this, "DynamicInvoke", 0, typeof(System.Object).MakeArrayType());
					r_DynamicInvoke_ObjectArray.SetBelong(this.instance);
				}
				return r_DynamicInvoke_ObjectArray;
			}
		}

		/// <summary>
		/// Void InitializeDelegateData()
		/// </summary>
		protected RMethod r_InitializeDelegateData;
		public virtual RMethod RInitializeDelegateData
		{
			get
			{
				if(r_InitializeDelegateData == null)
				{
					r_InitializeDelegateData = new(this, "InitializeDelegateData", 0);
					r_InitializeDelegateData.SetBelong(this.instance);
				}
				return r_InitializeDelegateData;
			}
		}

		/// <summary>
		/// System.Object DynamicInvokeImpl(System.Object[])
		/// </summary>
		protected RMethod r_DynamicInvokeImpl_ObjectArray;
		public virtual RMethod RDynamicInvokeImpl_ObjectArray
		{
			get
			{
				if(r_DynamicInvokeImpl_ObjectArray == null)
				{
					r_DynamicInvokeImpl_ObjectArray = new(this, "DynamicInvokeImpl", 0, typeof(System.Object).MakeArrayType());
					r_DynamicInvokeImpl_ObjectArray.SetBelong(this.instance);
				}
				return r_DynamicInvokeImpl_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_Clone;
		public virtual RMethod RClone
		{
			get
			{
				if(r_Clone == null)
				{
					r_Clone = new(this, "Clone", 0);
					r_Clone.SetBelong(this.instance);
				}
				return r_Clone;
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
		/// System.Reflection.MethodInfo GetMethodImpl()
		/// </summary>
		protected RMethod r_GetMethodImpl;
		public virtual RMethod RGetMethodImpl
		{
			get
			{
				if(r_GetMethodImpl == null)
				{
					r_GetMethodImpl = new(this, "GetMethodImpl", 0);
					r_GetMethodImpl.SetBelong(this.instance);
				}
				return r_GetMethodImpl;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_GetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// System.Delegate[] GetInvocationList()
		/// </summary>
		protected RMethod r_GetInvocationList;
		public virtual RMethod RGetInvocationList
		{
			get
			{
				if(r_GetInvocationList == null)
				{
					r_GetInvocationList = new(this, "GetInvocationList", 0);
					r_GetInvocationList.SetBelong(this.instance);
				}
				return r_GetInvocationList;
			}
		}

		/// <summary>
		/// System.Delegate Combine(System.Delegate, System.Delegate)
		/// </summary>
		protected static RMethod r_Combine_Delegate_Delegate;
		public static RMethod RCombine_Delegate_Delegate
		{
			get
			{
				if(r_Combine_Delegate_Delegate == null)
				{
					r_Combine_Delegate_Delegate = new(typeof(System.Delegate), "Combine", 0, typeof(System.Delegate), typeof(System.Delegate));
					r_Combine_Delegate_Delegate.SetBelong(null);
				}
				return r_Combine_Delegate_Delegate;
			}
		}

		/// <summary>
		/// System.Delegate Combine(System.Delegate[])
		/// </summary>
		protected static RMethod r_Combine_DelegateArray;
		public static RMethod RCombine_DelegateArray
		{
			get
			{
				if(r_Combine_DelegateArray == null)
				{
					r_Combine_DelegateArray = new(typeof(System.Delegate), "Combine", 0, typeof(System.Delegate).MakeArrayType());
					r_Combine_DelegateArray.SetBelong(null);
				}
				return r_Combine_DelegateArray;
			}
		}

		/// <summary>
		/// System.Delegate CombineImpl(System.Delegate)
		/// </summary>
		protected RMethod r_CombineImpl_Delegate;
		public virtual RMethod RCombineImpl_Delegate
		{
			get
			{
				if(r_CombineImpl_Delegate == null)
				{
					r_CombineImpl_Delegate = new(this, "CombineImpl", 0, typeof(System.Delegate));
					r_CombineImpl_Delegate.SetBelong(this.instance);
				}
				return r_CombineImpl_Delegate;
			}
		}

		/// <summary>
		/// System.Delegate Remove(System.Delegate, System.Delegate)
		/// </summary>
		protected static RMethod r_Remove_Delegate_Delegate;
		public static RMethod RRemove_Delegate_Delegate
		{
			get
			{
				if(r_Remove_Delegate_Delegate == null)
				{
					r_Remove_Delegate_Delegate = new(typeof(System.Delegate), "Remove", 0, typeof(System.Delegate), typeof(System.Delegate));
					r_Remove_Delegate_Delegate.SetBelong(null);
				}
				return r_Remove_Delegate_Delegate;
			}
		}

		/// <summary>
		/// System.Delegate RemoveImpl(System.Delegate)
		/// </summary>
		protected RMethod r_RemoveImpl_Delegate;
		public virtual RMethod RRemoveImpl_Delegate
		{
			get
			{
				if(r_RemoveImpl_Delegate == null)
				{
					r_RemoveImpl_Delegate = new(this, "RemoveImpl", 0, typeof(System.Delegate));
					r_RemoveImpl_Delegate.SetBelong(this.instance);
				}
				return r_RemoveImpl_Delegate;
			}
		}

		/// <summary>
		/// System.Delegate RemoveAll(System.Delegate, System.Delegate)
		/// </summary>
		protected static RMethod r_RemoveAll_Delegate_Delegate;
		public static RMethod RRemoveAll_Delegate_Delegate
		{
			get
			{
				if(r_RemoveAll_Delegate_Delegate == null)
				{
					r_RemoveAll_Delegate_Delegate = new(typeof(System.Delegate), "RemoveAll", 0, typeof(System.Delegate), typeof(System.Delegate));
					r_RemoveAll_Delegate_Delegate.SetBelong(null);
				}
				return r_RemoveAll_Delegate_Delegate;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Delegate, System.Delegate)
		/// </summary>
		protected static RMethod r_op_Equality_Delegate_Delegate;
		public static RMethod Rop_Equality_Delegate_Delegate
		{
			get
			{
				if(r_op_Equality_Delegate_Delegate == null)
				{
					r_op_Equality_Delegate_Delegate = new(typeof(System.Delegate), "op_Equality", 0, typeof(System.Delegate), typeof(System.Delegate));
					r_op_Equality_Delegate_Delegate.SetBelong(null);
				}
				return r_op_Equality_Delegate_Delegate;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Delegate, System.Delegate)
		/// </summary>
		protected static RMethod r_op_Inequality_Delegate_Delegate;
		public static RMethod Rop_Inequality_Delegate_Delegate
		{
			get
			{
				if(r_op_Inequality_Delegate_Delegate == null)
				{
					r_op_Inequality_Delegate_Delegate = new(typeof(System.Delegate), "op_Inequality", 0, typeof(System.Delegate), typeof(System.Delegate));
					r_op_Inequality_Delegate_Delegate.SetBelong(null);
				}
				return r_op_Inequality_Delegate_Delegate;
			}
		}

		/// <summary>
		/// Boolean IsTransparentProxy()
		/// </summary>
		protected RMethod r_IsTransparentProxy;
		public virtual RMethod RIsTransparentProxy
		{
			get
			{
				if(r_IsTransparentProxy == null)
				{
					r_IsTransparentProxy = new(this, "IsTransparentProxy", 0);
					r_IsTransparentProxy.SetBelong(this.instance);
				}
				return r_IsTransparentProxy;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegateNoSecurityCheck(System.RuntimeType, System.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected static RMethod r_CreateDelegateNoSecurityCheck_RuntimeType_Object_MethodInfo;
		public static RMethod RCreateDelegateNoSecurityCheck_RuntimeType_Object_MethodInfo
		{
			get
			{
				if(r_CreateDelegateNoSecurityCheck_RuntimeType_Object_MethodInfo == null)
				{
					r_CreateDelegateNoSecurityCheck_RuntimeType_Object_MethodInfo = new(typeof(System.Delegate), "CreateDelegateNoSecurityCheck", 0,  ReflectionUtils.GetType("System.RuntimeType"), typeof(System.Object), typeof(System.Reflection.MethodInfo));
					r_CreateDelegateNoSecurityCheck_RuntimeType_Object_MethodInfo.SetBelong(null);
				}
				return r_CreateDelegateNoSecurityCheck_RuntimeType_Object_MethodInfo;
			}
		}

		/// <summary>
		/// System.MulticastDelegate AllocDelegateLike_internal(System.Delegate)
		/// </summary>
		protected static RMethod r_AllocDelegateLike_internal_Delegate;
		public static RMethod RAllocDelegateLike_internal_Delegate
		{
			get
			{
				if(r_AllocDelegateLike_internal_Delegate == null)
				{
					r_AllocDelegateLike_internal_Delegate = new(typeof(System.Delegate), "AllocDelegateLike_internal", 0, typeof(System.Delegate));
					r_AllocDelegateLike_internal_Delegate.SetBelong(null);
				}
				return r_AllocDelegateLike_internal_Delegate;
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


        public RDelegate() : base("System.Delegate")
        {
        }

        public RDelegate(System.Object instance) : base("System.Delegate")
		{
            SetInstance(instance);
		}

        public RDelegate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDelegate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Reflection.MethodInfo GetVirtualMethod_internal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetVirtualMethod_internal.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.IntPtr GetNativeFunctionPointer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNativeFunctionPointer.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static System.Delegate CreateDelegate_internal(System.Type  @type, System.Object  @target, System.Reflection.MethodInfo  @info, System.Boolean  @throwOnBindFailure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @target, @info, @throwOnBindFailure};
            var ___result = RCreateDelegate_internal_Type_Object_MethodInfo_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Boolean arg_type_match(System.Type  @delArgType, System.Type  @argType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delArgType, @argType};
            var ___result = Rarg_type_match_Type_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean arg_type_match_this(System.Type  @delArgType, System.Type  @argType, System.Boolean  @boxedThis)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delArgType, @argType, @boxedThis};
            var ___result = Rarg_type_match_this_Type_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean return_type_match(System.Type  @delReturnType, System.Type  @returnType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delReturnType, @returnType};
            var ___result = Rreturn_type_match_Type_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Delegate CreateDelegate(System.Type  @type, System.Object  @firstArgument, System.Reflection.MethodInfo  @method, System.Boolean  @throwOnBindFailure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @firstArgument, @method, @throwOnBindFailure};
            var ___result = RCreateDelegate_Type_Object_MethodInfo_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate CreateDelegate(System.Type  @type, System.Object  @firstArgument, System.Reflection.MethodInfo  @method, System.Boolean  @throwOnBindFailure, System.Boolean  @allowClosed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @firstArgument, @method, @throwOnBindFailure, @allowClosed};
            var ___result = RCreateDelegate_Type_Object_MethodInfo_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate CreateDelegate(System.Type  @type, System.Object  @firstArgument, System.Reflection.MethodInfo  @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @firstArgument, @method};
            var ___result = RCreateDelegate_Type_Object_MethodInfo.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate CreateDelegate(System.Type  @type, System.Reflection.MethodInfo  @method, System.Boolean  @throwOnBindFailure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @method, @throwOnBindFailure};
            var ___result = RCreateDelegate_Type_MethodInfo_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate CreateDelegate(System.Type  @type, System.Reflection.MethodInfo  @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @method};
            var ___result = RCreateDelegate_Type_MethodInfo.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate CreateDelegate(System.Type  @type, System.Object  @target, System.String  @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @target, @method};
            var ___result = RCreateDelegate_Type_Object_String.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Reflection.MethodInfo GetCandidateMethod(System.Type  @type, System.Type  @target, System.String  @method, System.Reflection.BindingFlags  @bflags, System.Boolean  @ignoreCase, System.Boolean  @throwOnBindFailure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @target, @method, @bflags, @ignoreCase, @throwOnBindFailure};
            var ___result = RGetCandidateMethod_Type_Type_String_BindingFlags_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public static System.Delegate CreateDelegate(System.Type  @type, System.Type  @target, System.String  @method, System.Boolean  @ignoreCase, System.Boolean  @throwOnBindFailure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @target, @method, @ignoreCase, @throwOnBindFailure};
            var ___result = RCreateDelegate_Type_Type_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate CreateDelegate(System.Type  @type, System.Type  @target, System.String  @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @target, @method};
            var ___result = RCreateDelegate_Type_Type_String.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate CreateDelegate(System.Type  @type, System.Type  @target, System.String  @method, System.Boolean  @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @target, @method, @ignoreCase};
            var ___result = RCreateDelegate_Type_Type_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate CreateDelegate(System.Type  @type, System.Object  @target, System.String  @method, System.Boolean  @ignoreCase, System.Boolean  @throwOnBindFailure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @target, @method, @ignoreCase, @throwOnBindFailure};
            var ___result = RCreateDelegate_Type_Object_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate CreateDelegate(System.Type  @type, System.Object  @target, System.String  @method, System.Boolean  @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @target, @method, @ignoreCase};
            var ___result = RCreateDelegate_Type_Object_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public virtual System.Object DynamicInvoke(System.Object[]  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RDynamicInvoke_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void InitializeDelegateData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitializeDelegateData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object DynamicInvokeImpl(System.Object[]  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RDynamicInvokeImpl_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual System.Reflection.MethodInfo GetMethodImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMethodImpl.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Delegate[] GetInvocationList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInvocationList.Invoke(___genericsType, ___parameters);

            return (System.Delegate[])___result;
        }


        public static System.Delegate Combine(System.Delegate  @a, System.Delegate  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RCombine_Delegate_Delegate.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate Combine(System.Delegate[]  @delegates)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delegates};
            var ___result = RCombine_DelegateArray.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public virtual System.Delegate CombineImpl(System.Delegate  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RCombineImpl_Delegate.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate Remove(System.Delegate  @source, System.Delegate  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value};
            var ___result = RRemove_Delegate_Delegate.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public virtual System.Delegate RemoveImpl(System.Delegate  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RRemoveImpl_Delegate.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate RemoveAll(System.Delegate  @source, System.Delegate  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value};
            var ___result = RRemoveAll_Delegate_Delegate.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Boolean op_Equality(System.Delegate  @d1, System.Delegate  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = Rop_Equality_Delegate_Delegate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Delegate  @d1, System.Delegate  @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = Rop_Inequality_Delegate_Delegate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsTransparentProxy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsTransparentProxy.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public static System.MulticastDelegate AllocDelegateLike_internal(System.Delegate  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RAllocDelegateLike_internal_Delegate.Invoke(___genericsType, ___parameters);

            return (System.MulticastDelegate)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
