using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RContexts
{
	/// <summary>
	/// System.Runtime.Remoting.Contexts.CrossContextDelegate
	/// </summary>
    public partial class RCrossContextDelegate : RMember //
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
		protected RMethod r_RInvoke;
		public virtual RMethod RInvoke
		{
			get
			{
				if(r_RInvoke == null)
				{
					r_RInvoke = new(this, "Invoke", 0);
					r_RInvoke.SetBelong(this.instance);
				}
				return r_RInvoke;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginInvoke(System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginInvoke_AsyncCallback_Object;
		public virtual RMethod RBeginInvoke_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginInvoke_AsyncCallback_Object == null)
				{
					r_RBeginInvoke_AsyncCallback_Object = new(this, "BeginInvoke", 0, typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginInvoke_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginInvoke_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Void EndInvoke(System.IAsyncResult)
		/// </summary>
		protected RMethod r_REndInvoke_IAsyncResult;
		public virtual RMethod REndInvoke_IAsyncResult
		{
			get
			{
				if(r_REndInvoke_IAsyncResult == null)
				{
					r_REndInvoke_IAsyncResult = new(this, "EndInvoke", 0, typeof(System.IAsyncResult));
					r_REndInvoke_IAsyncResult.SetBelong(this.instance);
				}
				return r_REndInvoke_IAsyncResult;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RGetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_RGetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_RGetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_RGetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_RGetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// System.Object DynamicInvokeImpl(System.Object[])
		/// </summary>
		protected RMethod r_RDynamicInvokeImpl_ObjectArray;
		public virtual RMethod RDynamicInvokeImpl_ObjectArray
		{
			get
			{
				if(r_RDynamicInvokeImpl_ObjectArray == null)
				{
					r_RDynamicInvokeImpl_ObjectArray = new(this, "DynamicInvokeImpl", 0, typeof(System.Object).MakeArrayType());
					r_RDynamicInvokeImpl_ObjectArray.SetBelong(this.instance);
				}
				return r_RDynamicInvokeImpl_ObjectArray;
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
		/// System.Reflection.MethodInfo GetMethodImpl()
		/// </summary>
		protected RMethod r_RGetMethodImpl;
		public virtual RMethod RGetMethodImpl
		{
			get
			{
				if(r_RGetMethodImpl == null)
				{
					r_RGetMethodImpl = new(this, "GetMethodImpl", 0);
					r_RGetMethodImpl.SetBelong(this.instance);
				}
				return r_RGetMethodImpl;
			}
		}

		/// <summary>
		/// System.Delegate[] GetInvocationList()
		/// </summary>
		protected RMethod r_RGetInvocationList;
		public virtual RMethod RGetInvocationList
		{
			get
			{
				if(r_RGetInvocationList == null)
				{
					r_RGetInvocationList = new(this, "GetInvocationList", 0);
					r_RGetInvocationList.SetBelong(this.instance);
				}
				return r_RGetInvocationList;
			}
		}

		/// <summary>
		/// System.Delegate CombineImpl(System.Delegate)
		/// </summary>
		protected RMethod r_RCombineImpl_Delegate;
		public virtual RMethod RCombineImpl_Delegate
		{
			get
			{
				if(r_RCombineImpl_Delegate == null)
				{
					r_RCombineImpl_Delegate = new(this, "CombineImpl", 0, typeof(System.Delegate));
					r_RCombineImpl_Delegate.SetBelong(this.instance);
				}
				return r_RCombineImpl_Delegate;
			}
		}

		/// <summary>
		/// System.Delegate RemoveImpl(System.Delegate)
		/// </summary>
		protected RMethod r_RRemoveImpl_Delegate;
		public virtual RMethod RRemoveImpl_Delegate
		{
			get
			{
				if(r_RRemoveImpl_Delegate == null)
				{
					r_RRemoveImpl_Delegate = new(this, "RemoveImpl", 0, typeof(System.Delegate));
					r_RRemoveImpl_Delegate.SetBelong(this.instance);
				}
				return r_RRemoveImpl_Delegate;
			}
		}

		/// <summary>
		/// IntPtr GetNativeFunctionPointer()
		/// </summary>
		protected RMethod r_RGetNativeFunctionPointer;
		public virtual RMethod RGetNativeFunctionPointer
		{
			get
			{
				if(r_RGetNativeFunctionPointer == null)
				{
					r_RGetNativeFunctionPointer = new(this, "GetNativeFunctionPointer", 0);
					r_RGetNativeFunctionPointer.SetBelong(this.instance);
				}
				return r_RGetNativeFunctionPointer;
			}
		}

		/// <summary>
		/// System.Object DynamicInvoke(System.Object[])
		/// </summary>
		protected RMethod r_RDynamicInvoke_ObjectArray;
		public virtual RMethod RDynamicInvoke_ObjectArray
		{
			get
			{
				if(r_RDynamicInvoke_ObjectArray == null)
				{
					r_RDynamicInvoke_ObjectArray = new(this, "DynamicInvoke", 0, typeof(System.Object).MakeArrayType());
					r_RDynamicInvoke_ObjectArray.SetBelong(this.instance);
				}
				return r_RDynamicInvoke_ObjectArray;
			}
		}

		/// <summary>
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_RClone;
		public virtual RMethod RClone
		{
			get
			{
				if(r_RClone == null)
				{
					r_RClone = new(this, "Clone", 0);
					r_RClone.SetBelong(this.instance);
				}
				return r_RClone;
			}
		}

		/// <summary>
		/// Boolean IsTransparentProxy()
		/// </summary>
		protected RMethod r_RIsTransparentProxy;
		public virtual RMethod RIsTransparentProxy
		{
			get
			{
				if(r_RIsTransparentProxy == null)
				{
					r_RIsTransparentProxy = new(this, "IsTransparentProxy", 0);
					r_RIsTransparentProxy.SetBelong(this.instance);
				}
				return r_RIsTransparentProxy;
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


        public RCrossContextDelegate() : base("System.Runtime.Remoting.Contexts.CrossContextDelegate")
        {
        }

        public RCrossContextDelegate(System.Object instance) : base("System.Runtime.Remoting.Contexts.CrossContextDelegate")
		{
            SetInstance(instance);
		}

        public RCrossContextDelegate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCrossContextDelegate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Invoke()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInvoke.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback  @callback, System.Object  @object)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @object};
            var ___result = RBeginInvoke_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual void EndInvoke(System.IAsyncResult  @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = REndInvoke_IAsyncResult.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object DynamicInvokeImpl(System.Object[]  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RDynamicInvokeImpl_ObjectArray.Invoke(___genericsType, ___parameters);

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


        public virtual System.Delegate[] GetInvocationList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInvocationList.Invoke(___genericsType, ___parameters);

            return (System.Delegate[])___result;
        }


        public virtual System.Delegate CombineImpl(System.Delegate  @follow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@follow};
            var ___result = RCombineImpl_Delegate.Invoke(___genericsType, ___parameters);

            return (System.Delegate)___result;
        }


        public virtual System.Delegate RemoveImpl(System.Delegate  @value)
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


        public virtual System.Object DynamicInvoke(System.Object[]  @args)
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
