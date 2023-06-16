
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RCompilerServices
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Runtime.CompilerServices.TaskAwaiter`1
	/// </summary>
    public partial class RTaskAwaiter<TResult> : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Runtime.CompilerServices.TaskAwaiter`1").MakeGenericType(ReflectionUtils.GetType(typeof(TResult)));
            }
        }

        public RTaskAwaiter() : base("System.Runtime.CompilerServices.TaskAwaiter`1")
        {
        }

        public RTaskAwaiter(System.Object instance) : base("System.Runtime.CompilerServices.TaskAwaiter`1")
		{
            SetInstance(instance);
		}

        public RTaskAwaiter(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTaskAwaiter(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] m_task
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask<Hvak.Editor.Refleaction.RField> r_Fm_task;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask<Hvak.Editor.Refleaction.RField> RFm_task
		{
			get
			{
				if(r_Fm_task == null)
				{
					r_Fm_task = new(this, "m_task");
				}
				return r_Fm_task;
			}
		}

		/// <summary>
		/// Boolean IsCompleted
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsCompleted;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsCompleted
		{
			get
			{
				if(r_PIsCompleted == null)
				{
					r_PIsCompleted = new(this, "IsCompleted", -1);
				}
				return r_PIsCompleted;
			}
		}

		/// <summary>
		/// Void OnCompleted(System.Action)
		/// </summary>
		protected RMethod r_MOnCompleted_Action;
		public virtual RMethod RMOnCompleted_Action
		{
			get
			{
				if(r_MOnCompleted_Action == null)
				{
					r_MOnCompleted_Action = new(this, "OnCompleted", 0, typeof(System.Action));
				}
				return r_MOnCompleted_Action;
			}
		}

		/// <summary>
		/// Void UnsafeOnCompleted(System.Action)
		/// </summary>
		protected RMethod r_MUnsafeOnCompleted_Action;
		public virtual RMethod RMUnsafeOnCompleted_Action
		{
			get
			{
				if(r_MUnsafeOnCompleted_Action == null)
				{
					r_MUnsafeOnCompleted_Action = new(this, "UnsafeOnCompleted", 0, typeof(System.Action));
				}
				return r_MUnsafeOnCompleted_Action;
			}
		}

		/// <summary>
		/// TResult GetResult()
		/// </summary>
		protected RMethod r_MGetResult;
		public virtual RMethod RMGetResult
		{
			get
			{
				if(r_MGetResult == null)
				{
					r_MGetResult = new(this, "GetResult", 0);
				}
				return r_MGetResult;
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


        public virtual void OnCompleted(System.Action @continuation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuation};
            var ___result = RMOnCompleted_Action.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnsafeOnCompleted(System.Action @continuation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuation};
            var ___result = RMUnsafeOnCompleted_Action.Invoke(___genericsType, ___parameters);

            
        }


        public virtual TResult GetResult()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetResult.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<TResult>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
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


    }
}
