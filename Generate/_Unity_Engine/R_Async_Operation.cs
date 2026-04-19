
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.AsyncOperation
	/// </summary>
    public partial class RAsyncOperation : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.AsyncOperation);
            }
        }

        public RAsyncOperation() : base("UnityEngine.AsyncOperation")
        {
        }

        public RAsyncOperation(System.Object instance) : base("UnityEngine.AsyncOperation")
		{
            SetInstance(instance);
		}

        public RAsyncOperation(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAsyncOperation(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Action`1[UnityEngine.AsyncOperation] completed
		/// </summary>
		protected REvent r_Ecompleted;
		public virtual REvent REcompleted
		{
			get
			{
				if(r_Ecompleted == null)
				{
					r_Ecompleted = new(this, "completed");
				}
				return r_Ecompleted;
			}
		}

		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fm_Ptr;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFm_Ptr
		{
			get
			{
				if(r_Fm_Ptr == null)
				{
					r_Fm_Ptr = new(this, "m_Ptr");
				}
				return r_Fm_Ptr;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.AsyncOperation] m_completeCallback
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RAsyncOperation> r_Fm_completeCallback;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RAsyncOperation> RFm_completeCallback
		{
			get
			{
				if(r_Fm_completeCallback == null)
				{
					r_Fm_completeCallback = new(this, "m_completeCallback");
				}
				return r_Fm_completeCallback;
			}
		}

		/// <summary>
		/// Boolean isDone
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisDone;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisDone
		{
			get
			{
				if(r_PisDone == null)
				{
					r_PisDone = new(this, "isDone", -1);
				}
				return r_PisDone;
			}
		}

		/// <summary>
		/// Single progress
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Pprogress;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPprogress
		{
			get
			{
				if(r_Pprogress == null)
				{
					r_Pprogress = new(this, "progress", -1);
				}
				return r_Pprogress;
			}
		}

		/// <summary>
		/// Int32 priority
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Ppriority;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPpriority
		{
			get
			{
				if(r_Ppriority == null)
				{
					r_Ppriority = new(this, "priority", -1);
				}
				return r_Ppriority;
			}
		}

		/// <summary>
		/// Boolean allowSceneActivation
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PallowSceneActivation;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPallowSceneActivation
		{
			get
			{
				if(r_PallowSceneActivation == null)
				{
					r_PallowSceneActivation = new(this, "allowSceneActivation", -1);
				}
				return r_PallowSceneActivation;
			}
		}

		/// <summary>
		/// Void InternalDestroy(IntPtr)
		/// </summary>
		protected static RMethod r_MInternalDestroy_IntPtr;
		public static RMethod RMInternalDestroy_IntPtr
		{
			get
			{
				if(r_MInternalDestroy_IntPtr == null)
				{
					r_MInternalDestroy_IntPtr = new(Type, "InternalDestroy", 0, typeof(System.IntPtr));
				}
				return r_MInternalDestroy_IntPtr;
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
		/// Void InvokeCompletionEvent()
		/// </summary>
		protected RMethod r_MInvokeCompletionEvent;
		public virtual RMethod RMInvokeCompletionEvent
		{
			get
			{
				if(r_MInvokeCompletionEvent == null)
				{
					r_MInvokeCompletionEvent = new(this, "InvokeCompletionEvent", 0);
				}
				return r_MInvokeCompletionEvent;
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


        public static void InternalDestroy(System.IntPtr @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ptr};
            var ___result = RMInternalDestroy_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeCompletionEvent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInvokeCompletionEvent.Invoke(___genericsType, ___parameters);

            
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
