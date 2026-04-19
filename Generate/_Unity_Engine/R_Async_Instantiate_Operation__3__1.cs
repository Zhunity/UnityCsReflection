
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.AsyncInstantiateOperation`1
	/// </summary>
    public partial class RAsyncInstantiateOperation<T> : RMember // where T : UnityEngine.Object
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.AsyncInstantiateOperation`1").MakeGenericType(ReflectionUtils.GetType(typeof(T)));
            }
        }

        public RAsyncInstantiateOperation() : base("UnityEngine.AsyncInstantiateOperation`1")
        {
        }

        public RAsyncInstantiateOperation(System.Object instance) : base("UnityEngine.AsyncInstantiateOperation`1")
		{
            SetInstance(instance);
		}

        public RAsyncInstantiateOperation(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAsyncInstantiateOperation(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// UnityEngine.AsyncInstantiateOperation m_op
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RAsyncInstantiateOperation r_Fm_op;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RAsyncInstantiateOperation RFm_op
		{
			get
			{
				if(r_Fm_op == null)
				{
					r_Fm_op = new(this, "m_op");
				}
				return r_Fm_op;
			}
		}

		/// <summary>
		/// Boolean keepWaiting
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PkeepWaiting;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPkeepWaiting
		{
			get
			{
				if(r_PkeepWaiting == null)
				{
					r_PkeepWaiting = new(this, "keepWaiting", -1);
				}
				return r_PkeepWaiting;
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
		/// T[] Result
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RProperty> r_PResult;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RProperty> RPResult
		{
			get
			{
				if(r_PResult == null)
				{
					r_PResult = new(this, "Result", -1);
				}
				return r_PResult;
			}
		}

		/// <summary>
		/// System.Object Current
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PCurrent;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPCurrent
		{
			get
			{
				if(r_PCurrent == null)
				{
					r_PCurrent = new(this, "Current", -1);
				}
				return r_PCurrent;
			}
		}

		/// <summary>
		/// UnityEngine.AsyncInstantiateOperation GetOperation()
		/// </summary>
		protected RMethod r_MGetOperation;
		public virtual RMethod RMGetOperation
		{
			get
			{
				if(r_MGetOperation == null)
				{
					r_MGetOperation = new(this, "GetOperation", 0);
				}
				return r_MGetOperation;
			}
		}

		/// <summary>
		/// UnityEngine.AsyncInstantiateOperation op_Implicit(UnityEngine.AsyncInstantiateOperation`1[T])
		/// </summary>
		protected static RMethod r_Mop_Implicit_AsyncInstantiateOperation_d_T_p_;
		public static RMethod RMop_Implicit_AsyncInstantiateOperation_d_T_p_
		{
			get
			{
				if(r_Mop_Implicit_AsyncInstantiateOperation_d_T_p_ == null)
				{
					r_Mop_Implicit_AsyncInstantiateOperation_d_T_p_ = new(Type, "op_Implicit", 0,  ReflectionUtils.GetType("UnityEngine.AsyncInstantiateOperation`1"));
				}
				return r_Mop_Implicit_AsyncInstantiateOperation_d_T_p_;
			}
		}

		/// <summary>
		/// Boolean IsWaitingForSceneActivation()
		/// </summary>
		protected RMethod r_MIsWaitingForSceneActivation;
		public virtual RMethod RMIsWaitingForSceneActivation
		{
			get
			{
				if(r_MIsWaitingForSceneActivation == null)
				{
					r_MIsWaitingForSceneActivation = new(this, "IsWaitingForSceneActivation", 0);
				}
				return r_MIsWaitingForSceneActivation;
			}
		}

		/// <summary>
		/// Void WaitForCompletion()
		/// </summary>
		protected RMethod r_MWaitForCompletion;
		public virtual RMethod RMWaitForCompletion
		{
			get
			{
				if(r_MWaitForCompletion == null)
				{
					r_MWaitForCompletion = new(this, "WaitForCompletion", 0);
				}
				return r_MWaitForCompletion;
			}
		}

		/// <summary>
		/// Void Cancel()
		/// </summary>
		protected RMethod r_MCancel;
		public virtual RMethod RMCancel
		{
			get
			{
				if(r_MCancel == null)
				{
					r_MCancel = new(this, "Cancel", 0);
				}
				return r_MCancel;
			}
		}

		/// <summary>
		/// Boolean MoveNext()
		/// </summary>
		protected RMethod r_MMoveNext;
		public virtual RMethod RMMoveNext
		{
			get
			{
				if(r_MMoveNext == null)
				{
					r_MMoveNext = new(this, "MoveNext", 0);
				}
				return r_MMoveNext;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
				}
				return r_MReset;
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


        public virtual UnityEngine.AsyncInstantiateOperation GetOperation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetOperation.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.AsyncInstantiateOperation>(___result);
        }


        // public static UnityEngine.AsyncInstantiateOperation op_Implicit(UnityEngine.AsyncInstantiateOperation<T> @generic)
        // {
        //
        //     var ___genericsType = new Type[] {};
        //     var ___parameters = new object[]{@generic};
        //     var ___result = RMop_Implicit_AsyncInstantiateOperation_d_T_p_.Invoke(___genericsType, ___parameters);
        //
        //     return ReflectionUtils.Convert<UnityEngine.AsyncInstantiateOperation>(___result);
        // }


        public virtual System.Boolean IsWaitingForSceneActivation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsWaitingForSceneActivation.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void WaitForCompletion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMWaitForCompletion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Cancel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCancel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean MoveNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveNext.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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
