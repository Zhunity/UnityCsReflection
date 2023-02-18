
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RCompilerServices
{public partial class RConfiguredTaskAwaitable
{
	
	/// <summary>
	/// System.Runtime.CompilerServices.ConfiguredTaskAwaitable+ConfiguredTaskAwaiter
	/// </summary>
    public partial class RConfiguredTaskAwaiter : RMember //
    {

		/// <summary>
		/// System.Threading.Tasks.Task m_task
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask r_Fm_task;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RTasks.RTask RFm_task
		{
			get
			{
				if(r_Fm_task == null)
				{
					r_Fm_task = new(this, "m_task");
					r_Fm_task.SetBelong(this.GetValue());
				}
				return r_Fm_task;
			}
		}

		/// <summary>
		/// System.Boolean m_continueOnCapturedContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_continueOnCapturedContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_continueOnCapturedContext
		{
			get
			{
				if(r_Fm_continueOnCapturedContext == null)
				{
					r_Fm_continueOnCapturedContext = new(this, "m_continueOnCapturedContext");
					r_Fm_continueOnCapturedContext.SetBelong(this.GetValue());
				}
				return r_Fm_continueOnCapturedContext;
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
					r_PIsCompleted.SetBelong(this.GetValue());
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
					r_MOnCompleted_Action.SetBelong(this.GetValue());
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
					r_MUnsafeOnCompleted_Action.SetBelong(this.GetValue());
				}
				return r_MUnsafeOnCompleted_Action;
			}
		}

		/// <summary>
		/// Void GetResult()
		/// </summary>
		protected RMethod r_MGetResult;
		public virtual RMethod RMGetResult
		{
			get
			{
				if(r_MGetResult == null)
				{
					r_MGetResult = new(this, "GetResult", 0);
					r_MGetResult.SetBelong(this.GetValue());
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


        public RConfiguredTaskAwaiter() : base("System.Runtime.CompilerServices.ConfiguredTaskAwaitable+ConfiguredTaskAwaiter")
        {
        }

        public RConfiguredTaskAwaiter(System.Object instance) : base("System.Runtime.CompilerServices.ConfiguredTaskAwaitable+ConfiguredTaskAwaiter")
		{
            SetInstance(instance);
		}

        public RConfiguredTaskAwaiter(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RConfiguredTaskAwaiter(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public virtual void GetResult()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetResult.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
}