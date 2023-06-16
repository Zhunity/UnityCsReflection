
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Threading.ThreadState
	/// </summary>
    public partial class RThreadState : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Threading.ThreadState);
            }
        }

        public RThreadState() : base("System.Threading.ThreadState")
        {
        }

        public RThreadState(System.Object instance) : base("System.Threading.ThreadState")
		{
            SetInstance(instance);
		}

        public RThreadState(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RThreadState(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// System.Threading.ThreadState Running
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState r_FRunning;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState RFRunning
		{
			get
			{
				if(r_FRunning == null)
				{
					r_FRunning = new(Type, "Running");
				}
				return r_FRunning;
			}
		}

		/// <summary>
		/// System.Threading.ThreadState StopRequested
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState r_FStopRequested;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState RFStopRequested
		{
			get
			{
				if(r_FStopRequested == null)
				{
					r_FStopRequested = new(Type, "StopRequested");
				}
				return r_FStopRequested;
			}
		}

		/// <summary>
		/// System.Threading.ThreadState SuspendRequested
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState r_FSuspendRequested;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState RFSuspendRequested
		{
			get
			{
				if(r_FSuspendRequested == null)
				{
					r_FSuspendRequested = new(Type, "SuspendRequested");
				}
				return r_FSuspendRequested;
			}
		}

		/// <summary>
		/// System.Threading.ThreadState Background
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState r_FBackground;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState RFBackground
		{
			get
			{
				if(r_FBackground == null)
				{
					r_FBackground = new(Type, "Background");
				}
				return r_FBackground;
			}
		}

		/// <summary>
		/// System.Threading.ThreadState Unstarted
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState r_FUnstarted;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState RFUnstarted
		{
			get
			{
				if(r_FUnstarted == null)
				{
					r_FUnstarted = new(Type, "Unstarted");
				}
				return r_FUnstarted;
			}
		}

		/// <summary>
		/// System.Threading.ThreadState Stopped
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState r_FStopped;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState RFStopped
		{
			get
			{
				if(r_FStopped == null)
				{
					r_FStopped = new(Type, "Stopped");
				}
				return r_FStopped;
			}
		}

		/// <summary>
		/// System.Threading.ThreadState WaitSleepJoin
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState r_FWaitSleepJoin;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState RFWaitSleepJoin
		{
			get
			{
				if(r_FWaitSleepJoin == null)
				{
					r_FWaitSleepJoin = new(Type, "WaitSleepJoin");
				}
				return r_FWaitSleepJoin;
			}
		}

		/// <summary>
		/// System.Threading.ThreadState Suspended
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState r_FSuspended;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState RFSuspended
		{
			get
			{
				if(r_FSuspended == null)
				{
					r_FSuspended = new(Type, "Suspended");
				}
				return r_FSuspended;
			}
		}

		/// <summary>
		/// System.Threading.ThreadState AbortRequested
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState r_FAbortRequested;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState RFAbortRequested
		{
			get
			{
				if(r_FAbortRequested == null)
				{
					r_FAbortRequested = new(Type, "AbortRequested");
				}
				return r_FAbortRequested;
			}
		}

		/// <summary>
		/// System.Threading.ThreadState Aborted
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState r_FAborted;
		public static Hvak.Editor.Refleaction.RSystem.RThreading.RThreadState RFAborted
		{
			get
			{
				if(r_FAborted == null)
				{
					r_FAborted = new(Type, "Aborted");
				}
				return r_FAborted;
			}
		}

		/// <summary>
		/// System.Object GetValue()
		/// </summary>
		protected RMethod r_MGetValue;
		public virtual RMethod RMGetValue
		{
			get
			{
				if(r_MGetValue == null)
				{
					r_MGetValue = new(this, "GetValue", 0);
				}
				return r_MGetValue;
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
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_String_IFormatProvider;
		public virtual RMethod RMToString_String_IFormatProvider
		{
			get
			{
				if(r_MToString_String_IFormatProvider == null)
				{
					r_MToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
				}
				return r_MToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_MToString_String;
		public virtual RMethod RMToString_String
		{
			get
			{
				if(r_MToString_String == null)
				{
					r_MToString_String = new(this, "ToString", 0, typeof(System.String));
				}
				return r_MToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_IFormatProvider;
		public virtual RMethod RMToString_IFormatProvider
		{
			get
			{
				if(r_MToString_IFormatProvider == null)
				{
					r_MToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
				}
				return r_MToString_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean HasFlag(System.Enum)
		/// </summary>
		protected RMethod r_MHasFlag_Enum;
		public virtual RMethod RMHasFlag_Enum
		{
			get
			{
				if(r_MHasFlag_Enum == null)
				{
					r_MHasFlag_Enum = new(this, "HasFlag", 0, typeof(System.Enum));
				}
				return r_MHasFlag_Enum;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_MGetTypeCode;
		public virtual RMethod RMGetTypeCode
		{
			get
			{
				if(r_MGetTypeCode == null)
				{
					r_MGetTypeCode = new(this, "GetTypeCode", 0);
				}
				return r_MGetTypeCode;
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


        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.TypeCode>(___result);
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
