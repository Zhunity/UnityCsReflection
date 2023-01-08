using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RCompilerServices
{public partial class RConfiguredValueTaskAwaitable
{
	
	/// <summary>
	/// System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable+ConfiguredValueTaskAwaiter
	/// </summary>
    public partial class RConfiguredValueTaskAwaiter : RMember //
    {

		/// <summary>
		/// System.Threading.Tasks.ValueTask _value
		/// </summary>
		protected RSystem.RThreading.RTasks.RValueTask r__value;
		public virtual RSystem.RThreading.RTasks.RValueTask R_value
		{
			get
			{
				if(r__value == null)
				{
					r__value = new(this, "_value");
					r__value.SetBelong(this.instance);
				}
				return r__value;
			}
		}

		/// <summary>
		/// Boolean IsCompleted
		/// </summary>
		protected RProperty r_IsCompleted;
		public virtual RProperty RIsCompleted
		{
			get
			{
				if(r_IsCompleted == null)
				{
					r_IsCompleted = new(this, "IsCompleted", -1);
					r_IsCompleted.SetBelong(this.instance);
				}
				return r_IsCompleted;
			}
		}

		/// <summary>
		/// Void GetResult()
		/// </summary>
		protected RMethod r_GetResult;
		public virtual RMethod RGetResult
		{
			get
			{
				if(r_GetResult == null)
				{
					r_GetResult = new(this, "GetResult", 0);
					r_GetResult.SetBelong(this.instance);
				}
				return r_GetResult;
			}
		}

		/// <summary>
		/// Void OnCompleted(System.Action)
		/// </summary>
		protected RMethod r_OnCompleted_Action;
		public virtual RMethod ROnCompleted_Action
		{
			get
			{
				if(r_OnCompleted_Action == null)
				{
					r_OnCompleted_Action = new(this, "OnCompleted", 0, typeof(System.Action));
					r_OnCompleted_Action.SetBelong(this.instance);
				}
				return r_OnCompleted_Action;
			}
		}

		/// <summary>
		/// Void UnsafeOnCompleted(System.Action)
		/// </summary>
		protected RMethod r_UnsafeOnCompleted_Action;
		public virtual RMethod RUnsafeOnCompleted_Action
		{
			get
			{
				if(r_UnsafeOnCompleted_Action == null)
				{
					r_UnsafeOnCompleted_Action = new(this, "UnsafeOnCompleted", 0, typeof(System.Action));
					r_UnsafeOnCompleted_Action.SetBelong(this.instance);
				}
				return r_UnsafeOnCompleted_Action;
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


        public RConfiguredValueTaskAwaiter() : base("System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable+ConfiguredValueTaskAwaiter")
        {
        }

        public RConfiguredValueTaskAwaiter(System.Object instance) : base("System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable+ConfiguredValueTaskAwaiter")
		{
            SetInstance(instance);
		}

        public RConfiguredValueTaskAwaiter(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RConfiguredValueTaskAwaiter(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void GetResult()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetResult.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnCompleted(System.Action  @continuation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuation};
            var ___result = ROnCompleted_Action.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnsafeOnCompleted(System.Action  @continuation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuation};
            var ___result = RUnsafeOnCompleted_Action.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


    }
}
}