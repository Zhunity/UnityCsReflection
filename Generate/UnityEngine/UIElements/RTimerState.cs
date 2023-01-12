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
		protected RSystem.RInt64 r_F__0__start__1__k__BackingField;
		public virtual RSystem.RInt64 RF__0__start__1__k__BackingField
		{
			get
			{
				if(r_F__0__start__1__k__BackingField == null)
				{
					r_F__0__start__1__k__BackingField = new(this, "<start>k__BackingField");
					r_F__0__start__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__start__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int64 <now>k__BackingField
		/// </summary>
		protected RSystem.RInt64 r_F__0__now__1__k__BackingField;
		public virtual RSystem.RInt64 RF__0__now__1__k__BackingField
		{
			get
			{
				if(r_F__0__now__1__k__BackingField == null)
				{
					r_F__0__now__1__k__BackingField = new(this, "<now>k__BackingField");
					r_F__0__now__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__now__1__k__BackingField;
			}
		}

		/// <summary>
		/// Int64 start
		/// </summary>
		protected RSystem.RInt64 r_Pstart;
		public virtual RSystem.RInt64 RPstart
		{
			get
			{
				if(r_Pstart == null)
				{
					r_Pstart = new(this, "start", -1);
					r_Pstart.SetBelong(this.instance);
				}
				return r_Pstart;
			}
		}

		/// <summary>
		/// Int64 now
		/// </summary>
		protected RSystem.RInt64 r_Pnow;
		public virtual RSystem.RInt64 RPnow
		{
			get
			{
				if(r_Pnow == null)
				{
					r_Pnow = new(this, "now", -1);
					r_Pnow.SetBelong(this.instance);
				}
				return r_Pnow;
			}
		}

		/// <summary>
		/// Int64 deltaTime
		/// </summary>
		protected RSystem.RInt64 r_PdeltaTime;
		public virtual RSystem.RInt64 RPdeltaTime
		{
			get
			{
				if(r_PdeltaTime == null)
				{
					r_PdeltaTime = new(this, "deltaTime", -1);
					r_PdeltaTime.SetBelong(this.instance);
				}
				return r_PdeltaTime;
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
		/// Boolean Equals(UnityEngine.UIElements.TimerState)
		/// </summary>
		protected RMethod r_MEquals_TimerState;
		public virtual RMethod RMEquals_TimerState
		{
			get
			{
				if(r_MEquals_TimerState == null)
				{
					r_MEquals_TimerState = new(this, "Equals", 0, typeof(UnityEngine.UIElements.TimerState));
					r_MEquals_TimerState.SetBelong(this.instance);
				}
				return r_MEquals_TimerState;
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
		/// Boolean op_Equality(UnityEngine.UIElements.TimerState, UnityEngine.UIElements.TimerState)
		/// </summary>
		protected static RMethod r_Mop_Equality_TimerState_TimerState;
		public static RMethod RMop_Equality_TimerState_TimerState
		{
			get
			{
				if(r_Mop_Equality_TimerState_TimerState == null)
				{
					r_Mop_Equality_TimerState_TimerState = new(typeof(UnityEngine.UIElements.TimerState), "op_Equality", 0, typeof(UnityEngine.UIElements.TimerState), typeof(UnityEngine.UIElements.TimerState));
					r_Mop_Equality_TimerState_TimerState.SetBelong(null);
				}
				return r_Mop_Equality_TimerState_TimerState;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.UIElements.TimerState, UnityEngine.UIElements.TimerState)
		/// </summary>
		protected static RMethod r_Mop_Inequality_TimerState_TimerState;
		public static RMethod RMop_Inequality_TimerState_TimerState
		{
			get
			{
				if(r_Mop_Inequality_TimerState_TimerState == null)
				{
					r_Mop_Inequality_TimerState_TimerState = new(typeof(UnityEngine.UIElements.TimerState), "op_Inequality", 0, typeof(UnityEngine.UIElements.TimerState), typeof(UnityEngine.UIElements.TimerState));
					r_Mop_Inequality_TimerState_TimerState.SetBelong(null);
				}
				return r_Mop_Inequality_TimerState_TimerState;
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

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.UIElements.TimerState @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_TimerState.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean op_Equality(UnityEngine.UIElements.TimerState @state1, UnityEngine.UIElements.TimerState @state2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state1, @state2};
            var ___result = RMop_Equality_TimerState_TimerState.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.UIElements.TimerState @state1, UnityEngine.UIElements.TimerState @state2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state1, @state2};
            var ___result = RMop_Inequality_TimerState_TimerState.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
