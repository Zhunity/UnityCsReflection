using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{public partial class RGenericMenu
{
	
	/// <summary>
	/// UnityEditor.GenericMenu+MenuFunction
	/// </summary>
    public partial class RMenuFunction : RMember //
    {

		/// <summary>
		/// Boolean HasSingleTarget
		/// </summary>
		protected RProperty r_HasSingleTarget;
		public virtual RProperty RHasSingleTarget
		{
			get
			{
				if(r_HasSingleTarget == null)
				{
					r_HasSingleTarget = new(this, "HasSingleTarget", -1);
					r_HasSingleTarget.SetBelong(this.instance);
				}
				return r_HasSingleTarget;
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
		/// Void Invoke()
		/// </summary>
		protected RMethod r_Invoke;
		public virtual RMethod RInvoke
		{
			get
			{
				if(r_Invoke == null)
				{
					r_Invoke = new(this, "Invoke", 0);
					r_Invoke.SetBelong(this.instance);
				}
				return r_Invoke;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginInvoke(System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_BeginInvoke_AsyncCallback_Object;
		public virtual RMethod RBeginInvoke_AsyncCallback_Object
		{
			get
			{
				if(r_BeginInvoke_AsyncCallback_Object == null)
				{
					r_BeginInvoke_AsyncCallback_Object = new(this, "BeginInvoke", 0, typeof(System.AsyncCallback), typeof(System.Object));
					r_BeginInvoke_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_BeginInvoke_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Void EndInvoke(System.IAsyncResult)
		/// </summary>
		protected RMethod r_EndInvoke_IAsyncResult;
		public virtual RMethod REndInvoke_IAsyncResult
		{
			get
			{
				if(r_EndInvoke_IAsyncResult == null)
				{
					r_EndInvoke_IAsyncResult = new(this, "EndInvoke", 0, typeof(System.IAsyncResult));
					r_EndInvoke_IAsyncResult.SetBelong(this.instance);
				}
				return r_EndInvoke_IAsyncResult;
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


        public RMenuFunction() : base("UnityEditor.GenericMenu+MenuFunction")
        {
        }

        public RMenuFunction(System.Object instance) : base("UnityEditor.GenericMenu+MenuFunction")
		{
            SetInstance(instance);
		}

        public RMenuFunction(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMenuFunction(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Invoke()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInvoke.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback @callback, System.Object @object)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @object};
            var ___result = RBeginInvoke_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual void EndInvoke(System.IAsyncResult @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = REndInvoke_IAsyncResult.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object DynamicInvokeImpl(System.Object[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RDynamicInvokeImpl_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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


        public virtual System.Delegate[] GetInvocationList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInvocationList.Invoke(___genericsType, ___parameters);

            return (System.Delegate[])___result;
        }


        public virtual System.Delegate CombineImpl(System.Delegate @follow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@follow};
            var ___result = RCombineImpl_Delegate.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public virtual System.Delegate RemoveImpl(System.Delegate @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RRemoveImpl_Delegate.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public virtual System.IntPtr GetNativeFunctionPointer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNativeFunctionPointer.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual System.Object DynamicInvoke(System.Object[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RDynamicInvoke_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean IsTransparentProxy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsTransparentProxy.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
}