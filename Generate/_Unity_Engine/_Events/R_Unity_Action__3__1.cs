
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.REvents
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.Events.UnityAction`1
	/// </summary>
    public partial class RUnityAction<T0> : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.Events.UnityAction`1").MakeGenericType(ReflectionUtils.GetType(typeof(T0)));
            }
        }

        public RUnityAction() : base("UnityEngine.Events.UnityAction`1")
        {
        }

        public RUnityAction(System.Object instance) : base("UnityEngine.Events.UnityAction`1")
		{
            SetInstance(instance);
		}

        public RUnityAction(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUnityAction(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// Boolean HasSingleTarget
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PHasSingleTarget;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPHasSingleTarget
		{
			get
			{
				if(r_PHasSingleTarget == null)
				{
					r_PHasSingleTarget = new(this, "HasSingleTarget", -1);
				}
				return r_PHasSingleTarget;
			}
		}

		/// <summary>
		/// System.Reflection.MethodInfo Method
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo r_PMethod;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.RMethodInfo RPMethod
		{
			get
			{
				if(r_PMethod == null)
				{
					r_PMethod = new(this, "Method", -1);
				}
				return r_PMethod;
			}
		}

		/// <summary>
		/// System.Object Target
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PTarget;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPTarget
		{
			get
			{
				if(r_PTarget == null)
				{
					r_PTarget = new(this, "Target", -1);
				}
				return r_PTarget;
			}
		}

		/// <summary>
		/// Void Invoke(T0)
		/// </summary>
		protected RMethod r_MInvoke_T0;
		public virtual RMethod RMInvoke_T0
		{
			get
			{
				if(r_MInvoke_T0 == null)
				{
					r_MInvoke_T0 = new(this, "Invoke", 0, Type.MakeGenericMethodParameter(0));
				}
				return r_MInvoke_T0;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginInvoke(T0, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_MBeginInvoke_T0_AsyncCallback_Object;
		public virtual RMethod RMBeginInvoke_T0_AsyncCallback_Object
		{
			get
			{
				if(r_MBeginInvoke_T0_AsyncCallback_Object == null)
				{
					r_MBeginInvoke_T0_AsyncCallback_Object = new(this, "BeginInvoke", 0, Type.MakeGenericMethodParameter(0), typeof(System.AsyncCallback), typeof(System.Object));
				}
				return r_MBeginInvoke_T0_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Void EndInvoke(System.IAsyncResult)
		/// </summary>
		protected RMethod r_MEndInvoke_IAsyncResult;
		public virtual RMethod RMEndInvoke_IAsyncResult
		{
			get
			{
				if(r_MEndInvoke_IAsyncResult == null)
				{
					r_MEndInvoke_IAsyncResult = new(this, "EndInvoke", 0, typeof(System.IAsyncResult));
				}
				return r_MEndInvoke_IAsyncResult;
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
				}
				return r_MGetObjectData_SerializationInfo_StreamingContext;
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
				}
				return r_MDynamicInvokeImpl_ObjectArray;
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
				}
				return r_MGetMethodImpl;
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
				}
				return r_MGetInvocationList;
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
				}
				return r_MCombineImpl_Delegate;
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
				}
				return r_MRemoveImpl_Delegate;
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
				}
				return r_MGetNativeFunctionPointer;
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
				}
				return r_MDynamicInvoke_ObjectArray;
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
				}
				return r_MClone;
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
				}
				return r_MIsTransparentProxy;
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


        public virtual void Invoke(T0 @arg0)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arg0};
            var ___result = RMInvoke_T0.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IAsyncResult BeginInvoke(T0 @arg0, System.AsyncCallback @callback, System.Object @object)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@arg0, @callback, @object};
            var ___result = RMBeginInvoke_T0_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IAsyncResult>(___result);
        }


        public virtual void EndInvoke(System.IAsyncResult @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RMEndInvoke_IAsyncResult.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object DynamicInvokeImpl(System.Object[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RMDynamicInvokeImpl_ObjectArray.Invoke(___genericsType, ___parameters);

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


        public virtual System.Reflection.MethodInfo GetMethodImpl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetMethodImpl.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Reflection.MethodInfo>(___result);
        }


        public virtual System.Delegate[] GetInvocationList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInvocationList.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Delegate[]>(___result);
        }


        public virtual System.Delegate CombineImpl(System.Delegate @follow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@follow};
            var ___result = RMCombineImpl_Delegate.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Delegate>(___result);
        }


        public virtual System.Delegate RemoveImpl(System.Delegate @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMRemoveImpl_Delegate.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Delegate>(___result);
        }


        public virtual System.IntPtr GetNativeFunctionPointer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNativeFunctionPointer.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.IntPtr>(___result);
        }


        public virtual System.Object DynamicInvoke(System.Object[] @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args};
            var ___result = RMDynamicInvoke_ObjectArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Boolean IsTransparentProxy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsTransparentProxy.Invoke(___genericsType, ___parameters);

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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
