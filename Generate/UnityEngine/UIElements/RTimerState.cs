using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.TimerState
	/// </summary>
    public partial class RTimerState : RMember //
    {

		/// <summary>
		/// System.Int64 <start>k__BackingField
		/// </summary>
		protected RField r___1__start__2__k__BackingField;
		public virtual RField R__1__start__2__k__BackingField
		{
			get
			{
				if(r___1__start__2__k__BackingField == null)
				{
					r___1__start__2__k__BackingField = new(this, "<start>k__BackingField");
					r___1__start__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__start__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int64 <now>k__BackingField
		/// </summary>
		protected RField r___1__now__2__k__BackingField;
		public virtual RField R__1__now__2__k__BackingField
		{
			get
			{
				if(r___1__now__2__k__BackingField == null)
				{
					r___1__now__2__k__BackingField = new(this, "<now>k__BackingField");
					r___1__now__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__now__2__k__BackingField;
			}
		}

		/// <summary>
		/// Int64 start
		/// </summary>
		protected RProperty r_start;
		public virtual RProperty Rstart
		{
			get
			{
				if(r_start == null)
				{
					r_start = new(this, "start", -1);
					r_start.SetBelong(this.instance);
				}
				return r_start;
			}
		}

		/// <summary>
		/// Int64 now
		/// </summary>
		protected RProperty r_now;
		public virtual RProperty Rnow
		{
			get
			{
				if(r_now == null)
				{
					r_now = new(this, "now", -1);
					r_now.SetBelong(this.instance);
				}
				return r_now;
			}
		}

		/// <summary>
		/// Int64 deltaTime
		/// </summary>
		protected RProperty r_deltaTime;
		public virtual RProperty RdeltaTime
		{
			get
			{
				if(r_deltaTime == null)
				{
					r_deltaTime = new(this, "deltaTime", -1);
					r_deltaTime.SetBelong(this.instance);
				}
				return r_deltaTime;
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
		/// Boolean Equals(UnityEngine.UIElements.TimerState)
		/// </summary>
		protected RMethod r_REquals_TimerState;
		public virtual RMethod REquals_TimerState
		{
			get
			{
				if(r_REquals_TimerState == null)
				{
					r_REquals_TimerState = new(this, "Equals", 0, typeof(UnityEngine.UIElements.TimerState));
					r_REquals_TimerState.SetBelong(this.instance);
				}
				return r_REquals_TimerState;
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
		/// Boolean op_Equality(UnityEngine.UIElements.TimerState, UnityEngine.UIElements.TimerState)
		/// </summary>
		protected static RMethod r_Rop_Equality_TimerState_TimerState;
		public static RMethod Rop_Equality_TimerState_TimerState
		{
			get
			{
				if(r_Rop_Equality_TimerState_TimerState == null)
				{
					r_Rop_Equality_TimerState_TimerState = new(typeof(UnityEngine.UIElements.TimerState), "op_Equality", 0, typeof(UnityEngine.UIElements.TimerState), typeof(UnityEngine.UIElements.TimerState));
					r_Rop_Equality_TimerState_TimerState.SetBelong(null);
				}
				return r_Rop_Equality_TimerState_TimerState;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.TimerState, UnityEngine.UIElements.TimerState)
		/// </summary>
		protected static RMethod r_Rop_Inequality_TimerState_TimerState;
		public static RMethod Rop_Inequality_TimerState_TimerState
		{
			get
			{
				if(r_Rop_Inequality_TimerState_TimerState == null)
				{
					r_Rop_Inequality_TimerState_TimerState = new(typeof(UnityEngine.UIElements.TimerState), "op_Inequality", 0, typeof(UnityEngine.UIElements.TimerState), typeof(UnityEngine.UIElements.TimerState));
					r_Rop_Inequality_TimerState_TimerState.SetBelong(null);
				}
				return r_Rop_Inequality_TimerState_TimerState;
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


        public RTimerState() : base("UnityEngine.UIElements.TimerState")
        {
        }

        public RTimerState(System.Object instance) : base("UnityEngine.UIElements.TimerState")
		{
            SetInstance(instance);
		}

        public RTimerState(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTimerState(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.TimerState  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_TimerState.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.TimerState  @state1, UnityEngine.UIElements.TimerState  @state2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state1, @state2};
            var ___result = Rop_Equality_TimerState_TimerState.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.TimerState  @state1, UnityEngine.UIElements.TimerState  @state2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state1, @state2};
            var ___result = Rop_Inequality_TimerState_TimerState.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
