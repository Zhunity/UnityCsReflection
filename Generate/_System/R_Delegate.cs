
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
		protected SMFrame.Editor.Refleaction.RSystem.RIntPtr r_Fmethod_ptr;
		public virtual SMFrame.Editor.Refleaction.RSystem.RIntPtr RFmethod_ptr
		{
			get
			{
				if(r_Fmethod_ptr == null)
				{
					r_Fmethod_ptr = new(this, "method_ptr");
					r_Fmethod_ptr.SetBelong(this.instance);
				}
				return r_Fmethod_ptr;
			}
		}

		/// <summary>
		/// System.IntPtr invoke_impl
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RIntPtr r_Finvoke_impl;
		public virtual SMFrame.Editor.Refleaction.RSystem.RIntPtr RFinvoke_impl
		{
			get
			{
				if(r_Finvoke_impl == null)
				{
					r_Finvoke_impl = new(this, "invoke_impl");
					r_Finvoke_impl.SetBelong(this.instance);
				}
				return r_Finvoke_impl;
			}
		}

		/// <summary>
		/// System.Object m_target
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RObject r_Fm_target;
		public virtual SMFrame.Editor.Refleaction.RSystem.RObject RFm_target
		{
			get
			{
				if(r_Fm_target == null)
				{
					r_Fm_target = new(this, "m_target");
					r_Fm_target.SetBelong(this.instance);
				}
				return r_Fm_target;
			}
		}

		/// <summary>
		/// System.IntPtr method
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RIntPtr r_Fmethod;
		public virtual SMFrame.Editor.Refleaction.RSystem.RIntPtr RFmethod
		{
			get
			{
				if(r_Fmethod == null)
				{
					r_Fmethod = new(this, "method");
					r_Fmethod.SetBelong(this.instance);
				}
				return r_Fmethod;
			}
		}

		/// <summary>
		/// System.IntPtr delegate_trampoline
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RIntPtr r_Fdelegate_trampoline;
		public virtual SMFrame.Editor.Refleaction.RSystem.RIntPtr RFdelegate_trampoline
		{
			get
			{
				if(r_Fdelegate_trampoline == null)
				{
					r_Fdelegate_trampoline = new(this, "delegate_trampoline");
					r_Fdelegate_trampoline.SetBelong(this.instance);
				}
				return r_Fdelegate_trampoline;
			}
		}

		/// <summary>
		/// System.IntPtr extra_arg
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RIntPtr r_Fextra_arg;
		public virtual SMFrame.Editor.Refleaction.RSystem.RIntPtr RFextra_arg
		{
			get
			{
				if(r_Fextra_arg == null)
				{
					r_Fextra_arg = new(this, "extra_arg");
					r_Fextra_arg.SetBelong(this.instance);
				}
				return r_Fextra_arg;
			}
		}

		/// <summary>
		/// System.IntPtr method_code
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RIntPtr r_Fmethod_code;
		public virtual SMFrame.Editor.Refleaction.RSystem.RIntPtr RFmethod_code
		{
			get
			{
				if(r_Fmethod_code == null)
				{
					r_Fmethod_code = new(this, "method_code");
					r_Fmethod_code.SetBelong(this.instance);
				}
				return r_Fmethod_code;
			}
		}

		/// <summary>
		/// System.IntPtr interp_method
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RIntPtr r_Finterp_method;
		public virtual SMFrame.Editor.Refleaction.RSystem.RIntPtr RFinterp_method
		{
			get
			{
				if(r_Finterp_method == null)
				{
					r_Finterp_method = new(this, "interp_method");
					r_Finterp_method.SetBelong(this.instance);
				}
				return r_Finterp_method;
			}
		}

		/// <summary>
		/// System.IntPtr interp_invoke_impl
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RIntPtr r_Finterp_invoke_impl;
		public virtual SMFrame.Editor.Refleaction.RSystem.RIntPtr RFinterp_invoke_impl
		{
			get
			{
				if(r_Finterp_invoke_impl == null)
				{
					r_Finterp_invoke_impl = new(this, "interp_invoke_impl");
					r_Finterp_invoke_impl.SetBelong(this.instance);
				}
				return r_Finterp_invoke_impl;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo method_info
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodInfo r_Fmethod_info;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodInfo RFmethod_info
		{
			get
			{
				if(r_Fmethod_info == null)
				{
					r_Fmethod_info = new(this, "method_info");
					r_Fmethod_info.SetBelong(this.instance);
				}
				return r_Fmethod_info;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo original_method_info
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodInfo r_Foriginal_method_info;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodInfo RForiginal_method_info
		{
			get
			{
				if(r_Foriginal_method_info == null)
				{
					r_Foriginal_method_info = new(this, "original_method_info");
					r_Foriginal_method_info.SetBelong(this.instance);
				}
				return r_Foriginal_method_info;
			}
		}

		/// <summary>
		/// System.DelegateData data
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RDelegateData r_Fdata;
		public virtual SMFrame.Editor.Refleaction.RSystem.RDelegateData RFdata
		{
			get
			{
				if(r_Fdata == null)
				{
					r_Fdata = new(this, "data");
					r_Fdata.SetBelong(this.instance);
				}
				return r_Fdata;
			}
		}

		/// <summary>
		/// System.Boolean method_is_virtual
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fmethod_is_virtual;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFmethod_is_virtual
		{
			get
			{
				if(r_Fmethod_is_virtual == null)
				{
					r_Fmethod_is_virtual = new(this, "method_is_virtual");
					r_Fmethod_is_virtual.SetBelong(this.instance);
				}
				return r_Fmethod_is_virtual;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo Method
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodInfo r_PMethod;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodInfo RPMethod
		{
			get
			{
				if(r_PMethod == null)
				{
					r_PMethod = new(this, "Method", -1);
					r_PMethod.SetBelong(this.instance);
				}
				return r_PMethod;
			}
		}

		/// <summary>
		/// System.Object Target
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RObject r_PTarget;
		public virtual SMFrame.Editor.Refleaction.RSystem.RObject RPTarget
		{
			get
			{
				if(r_PTarget == null)
				{
					r_PTarget = new(this, "Target", -1);
					r_PTarget.SetBelong(this.instance);
				}
				return r_PTarget;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetVirtualMethod_internal()
		/// </summary>
		protected RMethod r_MGetVirtualMethod_internal;
		public virtual RMethod RMGetVirtualMethod_internal
		{
			get
			{
				if(r_MGetVirtualMethod_internal == null)
				{
					r_MGetVirtualMethod_internal = new(this, "GetVirtualMethod_internal", 0);
					r_MGetVirtualMethod_internal.SetBelong(this.instance);
				}
				return r_MGetVirtualMethod_internal;
			}
		}

		/// <summary>
		/// IntPtr GetNativeFunctionPointer()
		/// </summary>
		protected RMethod r_MGetNativeFunctionPointer;
		public virtual RMethod RMGetNativeFunctionPointer
		{
			get
			{
				if(r_MGetNativeFunctionPointer == null)
				{
					r_MGetNativeFunctionPointer = new(this, "GetNativeFunctionPointer", 0);
					r_MGetNativeFunctionPointer.SetBelong(this.instance);
				}
				return r_MGetNativeFunctionPointer;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate_internal(System.Type, System.Object, System.Reflection.MethodInfo, Boolean)
		/// </summary>
		protected static RMethod r_MCreateDelegate_internal_Type_Object_MethodInfo_Boolean;
		public static RMethod RMCreateDelegate_internal_Type_Object_MethodInfo_Boolean
		{
			get
			{
				if(r_MCreateDelegate_internal_Type_Object_MethodInfo_Boolean == null)
				{
					r_MCreateDelegate_internal_Type_Object_MethodInfo_Boolean = new(typeof(System.Delegate), "CreateDelegate_internal", 0, typeof(System.Type), typeof(System.Object), typeof(System.Reflection.MethodInfo), typeof(System.Boolean));
					r_MCreateDelegate_internal_Type_Object_MethodInfo_Boolean.SetBelong(null);
				}
				return r_MCreateDelegate_internal_Type_Object_MethodInfo_Boolean;
			}
		}

		/// <summary>
		/// Boolean arg_type_match(System.Type, System.Type)
		/// </summary>
		protected static RMethod r_Marg_type_match_Type_Type;
		public static RMethod RMarg_type_match_Type_Type
		{
			get
			{
				if(r_Marg_type_match_Type_Type == null)
				{
					r_Marg_type_match_Type_Type = new(typeof(System.Delegate), "arg_type_match", 0, typeof(System.Type), typeof(System.Type));
					r_Marg_type_match_Type_Type.SetBelong(null);
				}
				return r_Marg_type_match_Type_Type;
			}
		}

		/// <summary>
		/// Boolean arg_type_match_this(System.Type, System.Type, Boolean)
		/// </summary>
		protected static RMethod r_Marg_type_match_this_Type_Type_Boolean;
		public static RMethod RMarg_type_match_this_Type_Type_Boolean
		{
			get
			{
				if(r_Marg_type_match_this_Type_Type_Boolean == null)
				{
					r_Marg_type_match_this_Type_Type_Boolean = new(typeof(System.Delegate), "arg_type_match_this", 0, typeof(System.Type), typeof(System.Type), typeof(System.Boolean));
					r_Marg_type_match_this_Type_Type_Boolean.SetBelong(null);
				}
				return r_Marg_type_match_this_Type_Type_Boolean;
			}
		}

		/// <summary>
		/// Boolean return_type_match(System.Type, System.Type)
		/// </summary>
		protected static RMethod r_Mreturn_type_match_Type_Type;
		public static RMethod RMreturn_type_match_Type_Type
		{
			get
			{
				if(r_Mreturn_type_match_Type_Type == null)
				{
					r_Mreturn_type_match_Type_Type = new(typeof(System.Delegate), "return_type_match", 0, typeof(System.Type), typeof(System.Type));
					r_Mreturn_type_match_Type_Type.SetBelong(null);
				}
				return r_Mreturn_type_match_Type_Type;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Object, System.Reflection.MethodInfo, Boolean)
		/// </summary>
		protected static RMethod r_MCreateDelegate_Type_Object_MethodInfo_Boolean;
		public static RMethod RMCreateDelegate_Type_Object_MethodInfo_Boolean
		{
			get
			{
				if(r_MCreateDelegate_Type_Object_MethodInfo_Boolean == null)
				{
					r_MCreateDelegate_Type_Object_MethodInfo_Boolean = new(typeof(System.Delegate), "CreateDelegate", 0, typeof(System.Type), typeof(System.Object), typeof(System.Reflection.MethodInfo), typeof(System.Boolean));
					r_MCreateDelegate_Type_Object_MethodInfo_Boolean.SetBelong(null);
				}
				return r_MCreateDelegate_Type_Object_MethodInfo_Boolean;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Object, System.Reflection.MethodInfo, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_MCreateDelegate_Type_Object_MethodInfo_Boolean_Boolean;
		public static RMethod RMCreateDelegate_Type_Object_MethodInfo_Boolean_Boolean
		{
			get
			{
				if(r_MCreateDelegate_Type_Object_MethodInfo_Boolean_Boolean == null)
				{
					r_MCreateDelegate_Type_Object_MethodInfo_Boolean_Boolean = new(typeof(System.Delegate), "CreateDelegate", 0, typeof(System.Type), typeof(System.Object), typeof(System.Reflection.MethodInfo), typeof(System.Boolean), typeof(System.Boolean));
					r_MCreateDelegate_Type_Object_MethodInfo_Boolean_Boolean.SetBelong(null);
				}
				return r_MCreateDelegate_Type_Object_MethodInfo_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected static RMethod r_MCreateDelegate_Type_Object_MethodInfo;
		public static RMethod RMCreateDelegate_Type_Object_MethodInfo
		{
			get
			{
				if(r_MCreateDelegate_Type_Object_MethodInfo == null)
				{
					r_MCreateDelegate_Type_Object_MethodInfo = new(typeof(System.Delegate), "CreateDelegate", 0, typeof(System.Type), typeof(System.Object), typeof(System.Reflection.MethodInfo));
					r_MCreateDelegate_Type_Object_MethodInfo.SetBelong(null);
				}
				return r_MCreateDelegate_Type_Object_MethodInfo;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Reflection.MethodInfo, Boolean)
		/// </summary>
		protected static RMethod r_MCreateDelegate_Type_MethodInfo_Boolean;
		public static RMethod RMCreateDelegate_Type_MethodInfo_Boolean
		{
			get
			{
				if(r_MCreateDelegate_Type_MethodInfo_Boolean == null)
				{
					r_MCreateDelegate_Type_MethodInfo_Boolean = new(typeof(System.Delegate), "CreateDelegate", 0, typeof(System.Type), typeof(System.Reflection.MethodInfo), typeof(System.Boolean));
					r_MCreateDelegate_Type_MethodInfo_Boolean.SetBelong(null);
				}
				return r_MCreateDelegate_Type_MethodInfo_Boolean;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Reflection.MethodInfo)
		/// </summary>
		protected static RMethod r_MCreateDelegate_Type_MethodInfo;
		public static RMethod RMCreateDelegate_Type_MethodInfo
		{
			get
			{
				if(r_MCreateDelegate_Type_MethodInfo == null)
				{
					r_MCreateDelegate_Type_MethodInfo = new(typeof(System.Delegate), "CreateDelegate", 0, typeof(System.Type), typeof(System.Reflection.MethodInfo));
					r_MCreateDelegate_Type_MethodInfo.SetBelong(null);
				}
				return r_MCreateDelegate_Type_MethodInfo;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Object, System.String)
		/// </summary>
		protected static RMethod r_MCreateDelegate_Type_Object_String;
		public static RMethod RMCreateDelegate_Type_Object_String
		{
			get
			{
				if(r_MCreateDelegate_Type_Object_String == null)
				{
					r_MCreateDelegate_Type_Object_String = new(typeof(System.Delegate), "CreateDelegate", 0, typeof(System.Type), typeof(System.Object), typeof(System.String));
					r_MCreateDelegate_Type_Object_String.SetBelong(null);
				}
				return r_MCreateDelegate_Type_Object_String;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo GetCandidateMethod(System.Type, System.Type, System.String, System.Reflection.BindingFlags, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_MGetCandidateMethod_Type_Type_String_BindingFlags_Boolean_Boolean;
		public static RMethod RMGetCandidateMethod_Type_Type_String_BindingFlags_Boolean_Boolean
		{
			get
			{
				if(r_MGetCandidateMethod_Type_Type_String_BindingFlags_Boolean_Boolean == null)
				{
					r_MGetCandidateMethod_Type_Type_String_BindingFlags_Boolean_Boolean = new(typeof(System.Delegate), "GetCandidateMethod", 0, typeof(System.Type), typeof(System.Type), typeof(System.String), typeof(System.Reflection.BindingFlags), typeof(System.Boolean), typeof(System.Boolean));
					r_MGetCandidateMethod_Type_Type_String_BindingFlags_Boolean_Boolean.SetBelong(null);
				}
				return r_MGetCandidateMethod_Type_Type_String_BindingFlags_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Type, System.String, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_MCreateDelegate_Type_Type_String_Boolean_Boolean;
		public static RMethod RMCreateDelegate_Type_Type_String_Boolean_Boolean
		{
			get
			{
				if(r_MCreateDelegate_Type_Type_String_Boolean_Boolean == null)
				{
					r_MCreateDelegate_Type_Type_String_Boolean_Boolean = new(typeof(System.Delegate), "CreateDelegate", 0, typeof(System.Type), typeof(System.Type), typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
					r_MCreateDelegate_Type_Type_String_Boolean_Boolean.SetBelong(null);
				}
				return r_MCreateDelegate_Type_Type_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Type, System.String)
		/// </summary>
		protected static RMethod r_MCreateDelegate_Type_Type_String;
		public static RMethod RMCreateDelegate_Type_Type_String
		{
			get
			{
				if(r_MCreateDelegate_Type_Type_String == null)
				{
					r_MCreateDelegate_Type_Type_String = new(typeof(System.Delegate), "CreateDelegate", 0, typeof(System.Type), typeof(System.Type), typeof(System.String));
					r_MCreateDelegate_Type_Type_String.SetBelong(null);
				}
				return r_MCreateDelegate_Type_Type_String;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Type, System.String, Boolean)
		/// </summary>
		protected static RMethod r_MCreateDelegate_Type_Type_String_Boolean;
		public static RMethod RMCreateDelegate_Type_Type_String_Boolean
		{
			get
			{
				if(r_MCreateDelegate_Type_Type_String_Boolean == null)
				{
					r_MCreateDelegate_Type_Type_String_Boolean = new(typeof(System.Delegate), "CreateDelegate", 0, typeof(System.Type), typeof(System.Type), typeof(System.String), typeof(System.Boolean));
					r_MCreateDelegate_Type_Type_String_Boolean.SetBelong(null);
				}
				return r_MCreateDelegate_Type_Type_String_Boolean;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Object, System.String, Boolean, Boolean)
		/// </summary>
		protected static RMethod r_MCreateDelegate_Type_Object_String_Boolean_Boolean;
		public static RMethod RMCreateDelegate_Type_Object_String_Boolean_Boolean
		{
			get
			{
				if(r_MCreateDelegate_Type_Object_String_Boolean_Boolean == null)
				{
					r_MCreateDelegate_Type_Object_String_Boolean_Boolean = new(typeof(System.Delegate), "CreateDelegate", 0, typeof(System.Type), typeof(System.Object), typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
					r_MCreateDelegate_Type_Object_String_Boolean_Boolean.SetBelong(null);
				}
				return r_MCreateDelegate_Type_Object_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegate(System.Type, System.Object, System.String, Boolean)
		/// </summary>
		protected static RMethod r_MCreateDelegate_Type_Object_String_Boolean;
		public static RMethod RMCreateDelegate_Type_Object_String_Boolean
		{
			get
			{
				if(r_MCreateDelegate_Type_Object_String_Boolean == null)
				{
					r_MCreateDelegate_Type_Object_String_Boolean = new(typeof(System.Delegate), "CreateDelegate", 0, typeof(System.Type), typeof(System.Object), typeof(System.String), typeof(System.Boolean));
					r_MCreateDelegate_Type_Object_String_Boolean.SetBelong(null);
				}
				return r_MCreateDelegate_Type_Object_String_Boolean;
			}
		}

		/// <summary>
		/// System.Object DynamicInvoke(System.Object[])
		/// </summary>
		protected RMethod r_MDynamicInvoke_ObjectArray;
		public virtual RMethod RMDynamicInvoke_ObjectArray
		{
			get
			{
				if(r_MDynamicInvoke_ObjectArray == null)
				{
					r_MDynamicInvoke_ObjectArray = new(this, "DynamicInvoke", 0, typeof(System.Object).MakeArrayType());
					r_MDynamicInvoke_ObjectArray.SetBelong(this.instance);
				}
				return r_MDynamicInvoke_ObjectArray;
			}
		}

		/// <summary>
		/// Void InitializeDelegateData()
		/// </summary>
		protected RMethod r_MInitializeDelegateData;
		public virtual RMethod RMInitializeDelegateData
		{
			get
			{
				if(r_MInitializeDelegateData == null)
				{
					r_MInitializeDelegateData = new(this, "InitializeDelegateData", 0);
					r_MInitializeDelegateData.SetBelong(this.instance);
				}
				return r_MInitializeDelegateData;
			}
		}

		/// <summary>
		/// System.Object DynamicInvokeImpl(System.Object[])
		/// </summary>
		protected RMethod r_MDynamicInvokeImpl_ObjectArray;
		public virtual RMethod RMDynamicInvokeImpl_ObjectArray
		{
			get
			{
				if(r_MDynamicInvokeImpl_ObjectArray == null)
				{
					r_MDynamicInvokeImpl_ObjectArray = new(this, "DynamicInvokeImpl", 0, typeof(System.Object).MakeArrayType());
					r_MDynamicInvokeImpl_ObjectArray.SetBelong(this.instance);
				}
				return r_MDynamicInvokeImpl_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_MClone;
		public virtual RMethod RMClone
		{
			get
			{
				if(r_MClone == null)
				{
					r_MClone = new(this, "Clone", 0);
					r_MClone.SetBelong(this.instance);
				}
				return r_MClone;
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
		/// System.Reflection.MethodInfo GetMethodImpl()
		/// </summary>
		protected RMethod r_MGetMethodImpl;
		public virtual RMethod RMGetMethodImpl
		{
			get
			{
				if(r_MGetMethodImpl == null)
				{
					r_MGetMethodImpl = new(this, "GetMethodImpl", 0);
					r_MGetMethodImpl.SetBelong(this.instance);
				}
				return r_MGetMethodImpl;
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
					r_MGetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_MGetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// System.Delegate[] GetInvocationList()
		/// </summary>
		protected RMethod r_MGetInvocationList;
		public virtual RMethod RMGetInvocationList
		{
			get
			{
				if(r_MGetInvocationList == null)
				{
					r_MGetInvocationList = new(this, "GetInvocationList", 0);
					r_MGetInvocationList.SetBelong(this.instance);
				}
				return r_MGetInvocationList;
			}
		}

		/// <summary>
		/// System.Delegate Combine(System.Delegate, System.Delegate)
		/// </summary>
		protected static RMethod r_MCombine_Delegate_Delegate;
		public static RMethod RMCombine_Delegate_Delegate
		{
			get
			{
				if(r_MCombine_Delegate_Delegate == null)
				{
					r_MCombine_Delegate_Delegate = new(typeof(System.Delegate), "Combine", 0, typeof(System.Delegate), typeof(System.Delegate));
					r_MCombine_Delegate_Delegate.SetBelong(null);
				}
				return r_MCombine_Delegate_Delegate;
			}
		}

		/// <summary>
		/// System.Delegate Combine(System.Delegate[])
		/// </summary>
		protected static RMethod r_MCombine_DelegateArray;
		public static RMethod RMCombine_DelegateArray
		{
			get
			{
				if(r_MCombine_DelegateArray == null)
				{
					r_MCombine_DelegateArray = new(typeof(System.Delegate), "Combine", 0, typeof(System.Delegate).MakeArrayType());
					r_MCombine_DelegateArray.SetBelong(null);
				}
				return r_MCombine_DelegateArray;
			}
		}

		/// <summary>
		/// System.Delegate CombineImpl(System.Delegate)
		/// </summary>
		protected RMethod r_MCombineImpl_Delegate;
		public virtual RMethod RMCombineImpl_Delegate
		{
			get
			{
				if(r_MCombineImpl_Delegate == null)
				{
					r_MCombineImpl_Delegate = new(this, "CombineImpl", 0, typeof(System.Delegate));
					r_MCombineImpl_Delegate.SetBelong(this.instance);
				}
				return r_MCombineImpl_Delegate;
			}
		}

		/// <summary>
		/// System.Delegate Remove(System.Delegate, System.Delegate)
		/// </summary>
		protected static RMethod r_MRemove_Delegate_Delegate;
		public static RMethod RMRemove_Delegate_Delegate
		{
			get
			{
				if(r_MRemove_Delegate_Delegate == null)
				{
					r_MRemove_Delegate_Delegate = new(typeof(System.Delegate), "Remove", 0, typeof(System.Delegate), typeof(System.Delegate));
					r_MRemove_Delegate_Delegate.SetBelong(null);
				}
				return r_MRemove_Delegate_Delegate;
			}
		}

		/// <summary>
		/// System.Delegate RemoveImpl(System.Delegate)
		/// </summary>
		protected RMethod r_MRemoveImpl_Delegate;
		public virtual RMethod RMRemoveImpl_Delegate
		{
			get
			{
				if(r_MRemoveImpl_Delegate == null)
				{
					r_MRemoveImpl_Delegate = new(this, "RemoveImpl", 0, typeof(System.Delegate));
					r_MRemoveImpl_Delegate.SetBelong(this.instance);
				}
				return r_MRemoveImpl_Delegate;
			}
		}

		/// <summary>
		/// System.Delegate RemoveAll(System.Delegate, System.Delegate)
		/// </summary>
		protected static RMethod r_MRemoveAll_Delegate_Delegate;
		public static RMethod RMRemoveAll_Delegate_Delegate
		{
			get
			{
				if(r_MRemoveAll_Delegate_Delegate == null)
				{
					r_MRemoveAll_Delegate_Delegate = new(typeof(System.Delegate), "RemoveAll", 0, typeof(System.Delegate), typeof(System.Delegate));
					r_MRemoveAll_Delegate_Delegate.SetBelong(null);
				}
				return r_MRemoveAll_Delegate_Delegate;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Delegate, System.Delegate)
		/// </summary>
		protected static RMethod r_Mop_Equality_Delegate_Delegate;
		public static RMethod RMop_Equality_Delegate_Delegate
		{
			get
			{
				if(r_Mop_Equality_Delegate_Delegate == null)
				{
					r_Mop_Equality_Delegate_Delegate = new(typeof(System.Delegate), "op_Equality", 0, typeof(System.Delegate), typeof(System.Delegate));
					r_Mop_Equality_Delegate_Delegate.SetBelong(null);
				}
				return r_Mop_Equality_Delegate_Delegate;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Delegate, System.Delegate)
		/// </summary>
		protected static RMethod r_Mop_Inequality_Delegate_Delegate;
		public static RMethod RMop_Inequality_Delegate_Delegate
		{
			get
			{
				if(r_Mop_Inequality_Delegate_Delegate == null)
				{
					r_Mop_Inequality_Delegate_Delegate = new(typeof(System.Delegate), "op_Inequality", 0, typeof(System.Delegate), typeof(System.Delegate));
					r_Mop_Inequality_Delegate_Delegate.SetBelong(null);
				}
				return r_Mop_Inequality_Delegate_Delegate;
			}
		}

		/// <summary>
		/// Boolean IsTransparentProxy()
		/// </summary>
		protected RMethod r_MIsTransparentProxy;
		public virtual RMethod RMIsTransparentProxy
		{
			get
			{
				if(r_MIsTransparentProxy == null)
				{
					r_MIsTransparentProxy = new(this, "IsTransparentProxy", 0);
					r_MIsTransparentProxy.SetBelong(this.instance);
				}
				return r_MIsTransparentProxy;
			}
		}

		/// <summary>
		/// System.Delegate CreateDelegateNoSecurityCheck(System.RuntimeType, System.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected static RMethod r_MCreateDelegateNoSecurityCheck_RuntimeType_Object_MethodInfo;
		public static RMethod RMCreateDelegateNoSecurityCheck_RuntimeType_Object_MethodInfo
		{
			get
			{
				if(r_MCreateDelegateNoSecurityCheck_RuntimeType_Object_MethodInfo == null)
				{
					r_MCreateDelegateNoSecurityCheck_RuntimeType_Object_MethodInfo = new(typeof(System.Delegate), "CreateDelegateNoSecurityCheck", 0,  ReflectionUtils.GetType("System.RuntimeType"), typeof(System.Object), typeof(System.Reflection.MethodInfo));
					r_MCreateDelegateNoSecurityCheck_RuntimeType_Object_MethodInfo.SetBelong(null);
				}
				return r_MCreateDelegateNoSecurityCheck_RuntimeType_Object_MethodInfo;
			}
		}

		/// <summary>
		/// System.MulticastDelegate AllocDelegateLike_internal(System.Delegate)
		/// </summary>
		protected static RMethod r_MAllocDelegateLike_internal_Delegate;
		public static RMethod RMAllocDelegateLike_internal_Delegate
		{
			get
			{
				if(r_MAllocDelegateLike_internal_Delegate == null)
				{
					r_MAllocDelegateLike_internal_Delegate = new(typeof(System.Delegate), "AllocDelegateLike_internal", 0, typeof(System.Delegate));
					r_MAllocDelegateLike_internal_Delegate.SetBelong(null);
				}
				return r_MAllocDelegateLike_internal_Delegate;
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
            var ___result = RMGetVirtualMethod_internal.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual System.IntPtr GetNativeFunctionPointer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNativeFunctionPointer.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public static System.Delegate CreateDelegate_internal(System.Type @type, System.Object @target, System.Reflection.MethodInfo @info, System.Boolean @throwOnBindFailure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @target, @info, @throwOnBindFailure};
            var ___result = RMCreateDelegate_internal_Type_Object_MethodInfo_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Boolean arg_type_match(System.Type @delArgType, System.Type @argType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delArgType, @argType};
            var ___result = RMarg_type_match_Type_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean arg_type_match_this(System.Type @delArgType, System.Type @argType, System.Boolean @boxedThis)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delArgType, @argType, @boxedThis};
            var ___result = RMarg_type_match_this_Type_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean return_type_match(System.Type @delReturnType, System.Type @returnType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delReturnType, @returnType};
            var ___result = RMreturn_type_match_Type_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Delegate CreateDelegate(System.Type @type, System.Object @firstArgument, System.Reflection.MethodInfo @method, System.Boolean @throwOnBindFailure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @firstArgument, @method, @throwOnBindFailure};
            var ___result = RMCreateDelegate_Type_Object_MethodInfo_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate CreateDelegate(System.Type @type, System.Object @firstArgument, System.Reflection.MethodInfo @method, System.Boolean @throwOnBindFailure, System.Boolean @allowClosed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @firstArgument, @method, @throwOnBindFailure, @allowClosed};
            var ___result = RMCreateDelegate_Type_Object_MethodInfo_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate CreateDelegate(System.Type @type, System.Object @firstArgument, System.Reflection.MethodInfo @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @firstArgument, @method};
            var ___result = RMCreateDelegate_Type_Object_MethodInfo.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate CreateDelegate(System.Type @type, System.Reflection.MethodInfo @method, System.Boolean @throwOnBindFailure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @method, @throwOnBindFailure};
            var ___result = RMCreateDelegate_Type_MethodInfo_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate CreateDelegate(System.Type @type, System.Reflection.MethodInfo @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @method};
            var ___result = RMCreateDelegate_Type_MethodInfo.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate CreateDelegate(System.Type @type, System.Object @target, System.String @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @target, @method};
            var ___result = RMCreateDelegate_Type_Object_String.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Reflection.MethodInfo GetCandidateMethod(System.Type @type, System.Type @target, System.String @method, System.Reflection.BindingFlags @bflags, System.Boolean @ignoreCase, System.Boolean @throwOnBindFailure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @target, @method, @bflags, @ignoreCase, @throwOnBindFailure};
            var ___result = RMGetCandidateMethod_Type_Type_String_BindingFlags_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public static System.Delegate CreateDelegate(System.Type @type, System.Type @target, System.String @method, System.Boolean @ignoreCase, System.Boolean @throwOnBindFailure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @target, @method, @ignoreCase, @throwOnBindFailure};
            var ___result = RMCreateDelegate_Type_Type_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate CreateDelegate(System.Type @type, System.Type @target, System.String @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @target, @method};
            var ___result = RMCreateDelegate_Type_Type_String.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate CreateDelegate(System.Type @type, System.Type @target, System.String @method, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @target, @method, @ignoreCase};
            var ___result = RMCreateDelegate_Type_Type_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate CreateDelegate(System.Type @type, System.Object @target, System.String @method, System.Boolean @ignoreCase, System.Boolean @throwOnBindFailure)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @target, @method, @ignoreCase, @throwOnBindFailure};
            var ___result = RMCreateDelegate_Type_Object_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate CreateDelegate(System.Type @type, System.Object @target, System.String @method, System.Boolean @ignoreCase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @target, @method, @ignoreCase};
            var ___result = RMCreateDelegate_Type_Object_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public virtual System.Object DynamicInvoke(System.Object[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RMDynamicInvoke_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void InitializeDelegateData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitializeDelegateData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object DynamicInvokeImpl(System.Object[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RMDynamicInvokeImpl_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual System.Reflection.MethodInfo GetMethodImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMethodImpl.Invoke(___genericsType, ___parameters);

            return (System.Reflection.MethodInfo)___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Delegate[] GetInvocationList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInvocationList.Invoke(___genericsType, ___parameters);

            return (System.Delegate[])___result;
        }


        public static System.Delegate Combine(System.Delegate @a, System.Delegate @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMCombine_Delegate_Delegate.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate Combine(System.Delegate[] @delegates)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delegates};
            var ___result = RMCombine_DelegateArray.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public virtual System.Delegate CombineImpl(System.Delegate @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMCombineImpl_Delegate.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate Remove(System.Delegate @source, System.Delegate @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value};
            var ___result = RMRemove_Delegate_Delegate.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public virtual System.Delegate RemoveImpl(System.Delegate @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMRemoveImpl_Delegate.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Delegate RemoveAll(System.Delegate @source, System.Delegate @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @value};
            var ___result = RMRemoveAll_Delegate_Delegate.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.Boolean op_Equality(System.Delegate @d1, System.Delegate @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMop_Equality_Delegate_Delegate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Delegate @d1, System.Delegate @d2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d1, @d2};
            var ___result = RMop_Inequality_Delegate_Delegate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsTransparentProxy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsTransparentProxy.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Delegate CreateDelegateNoSecurityCheck(SMFrame.Editor.Refleaction.RSystem.RRuntimeType @type, System.Object @firstArgument, System.Reflection.MethodInfo @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type.Value, @firstArgument, @method};
            var ___result = RMCreateDelegateNoSecurityCheck_RuntimeType_Object_MethodInfo.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public static System.MulticastDelegate AllocDelegateLike_internal(System.Delegate @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@d};
            var ___result = RMAllocDelegateLike_internal_Delegate.Invoke(___genericsType, ___parameters);

            return (System.MulticastDelegate)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
