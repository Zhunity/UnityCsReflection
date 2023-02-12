
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks
{
	/// <summary>
	/// System.Threading.Tasks.TaskContinuationOptions
	/// </summary>
    public partial class RTaskContinuationOptions : RMember //
    {

		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
					r_Fvalue__.SetBelong(this.instance);
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskContinuationOptions None
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions r_FNone;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions RFNone
		{
			get
			{
				if(r_FNone == null)
				{
					r_FNone = new(typeof(System.Threading.Tasks.TaskContinuationOptions), "None");
					r_FNone.SetBelong(null);
				}
				return r_FNone;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskContinuationOptions PreferFairness
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions r_FPreferFairness;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions RFPreferFairness
		{
			get
			{
				if(r_FPreferFairness == null)
				{
					r_FPreferFairness = new(typeof(System.Threading.Tasks.TaskContinuationOptions), "PreferFairness");
					r_FPreferFairness.SetBelong(null);
				}
				return r_FPreferFairness;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskContinuationOptions LongRunning
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions r_FLongRunning;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions RFLongRunning
		{
			get
			{
				if(r_FLongRunning == null)
				{
					r_FLongRunning = new(typeof(System.Threading.Tasks.TaskContinuationOptions), "LongRunning");
					r_FLongRunning.SetBelong(null);
				}
				return r_FLongRunning;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskContinuationOptions AttachedToParent
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions r_FAttachedToParent;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions RFAttachedToParent
		{
			get
			{
				if(r_FAttachedToParent == null)
				{
					r_FAttachedToParent = new(typeof(System.Threading.Tasks.TaskContinuationOptions), "AttachedToParent");
					r_FAttachedToParent.SetBelong(null);
				}
				return r_FAttachedToParent;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskContinuationOptions DenyChildAttach
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions r_FDenyChildAttach;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions RFDenyChildAttach
		{
			get
			{
				if(r_FDenyChildAttach == null)
				{
					r_FDenyChildAttach = new(typeof(System.Threading.Tasks.TaskContinuationOptions), "DenyChildAttach");
					r_FDenyChildAttach.SetBelong(null);
				}
				return r_FDenyChildAttach;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskContinuationOptions HideScheduler
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions r_FHideScheduler;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions RFHideScheduler
		{
			get
			{
				if(r_FHideScheduler == null)
				{
					r_FHideScheduler = new(typeof(System.Threading.Tasks.TaskContinuationOptions), "HideScheduler");
					r_FHideScheduler.SetBelong(null);
				}
				return r_FHideScheduler;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskContinuationOptions LazyCancellation
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions r_FLazyCancellation;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions RFLazyCancellation
		{
			get
			{
				if(r_FLazyCancellation == null)
				{
					r_FLazyCancellation = new(typeof(System.Threading.Tasks.TaskContinuationOptions), "LazyCancellation");
					r_FLazyCancellation.SetBelong(null);
				}
				return r_FLazyCancellation;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskContinuationOptions RunContinuationsAsynchronously
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions r_FRunContinuationsAsynchronously;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions RFRunContinuationsAsynchronously
		{
			get
			{
				if(r_FRunContinuationsAsynchronously == null)
				{
					r_FRunContinuationsAsynchronously = new(typeof(System.Threading.Tasks.TaskContinuationOptions), "RunContinuationsAsynchronously");
					r_FRunContinuationsAsynchronously.SetBelong(null);
				}
				return r_FRunContinuationsAsynchronously;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskContinuationOptions NotOnRanToCompletion
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions r_FNotOnRanToCompletion;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions RFNotOnRanToCompletion
		{
			get
			{
				if(r_FNotOnRanToCompletion == null)
				{
					r_FNotOnRanToCompletion = new(typeof(System.Threading.Tasks.TaskContinuationOptions), "NotOnRanToCompletion");
					r_FNotOnRanToCompletion.SetBelong(null);
				}
				return r_FNotOnRanToCompletion;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskContinuationOptions NotOnFaulted
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions r_FNotOnFaulted;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions RFNotOnFaulted
		{
			get
			{
				if(r_FNotOnFaulted == null)
				{
					r_FNotOnFaulted = new(typeof(System.Threading.Tasks.TaskContinuationOptions), "NotOnFaulted");
					r_FNotOnFaulted.SetBelong(null);
				}
				return r_FNotOnFaulted;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskContinuationOptions NotOnCanceled
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions r_FNotOnCanceled;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions RFNotOnCanceled
		{
			get
			{
				if(r_FNotOnCanceled == null)
				{
					r_FNotOnCanceled = new(typeof(System.Threading.Tasks.TaskContinuationOptions), "NotOnCanceled");
					r_FNotOnCanceled.SetBelong(null);
				}
				return r_FNotOnCanceled;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskContinuationOptions OnlyOnRanToCompletion
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions r_FOnlyOnRanToCompletion;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions RFOnlyOnRanToCompletion
		{
			get
			{
				if(r_FOnlyOnRanToCompletion == null)
				{
					r_FOnlyOnRanToCompletion = new(typeof(System.Threading.Tasks.TaskContinuationOptions), "OnlyOnRanToCompletion");
					r_FOnlyOnRanToCompletion.SetBelong(null);
				}
				return r_FOnlyOnRanToCompletion;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskContinuationOptions OnlyOnFaulted
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions r_FOnlyOnFaulted;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions RFOnlyOnFaulted
		{
			get
			{
				if(r_FOnlyOnFaulted == null)
				{
					r_FOnlyOnFaulted = new(typeof(System.Threading.Tasks.TaskContinuationOptions), "OnlyOnFaulted");
					r_FOnlyOnFaulted.SetBelong(null);
				}
				return r_FOnlyOnFaulted;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskContinuationOptions OnlyOnCanceled
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions r_FOnlyOnCanceled;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions RFOnlyOnCanceled
		{
			get
			{
				if(r_FOnlyOnCanceled == null)
				{
					r_FOnlyOnCanceled = new(typeof(System.Threading.Tasks.TaskContinuationOptions), "OnlyOnCanceled");
					r_FOnlyOnCanceled.SetBelong(null);
				}
				return r_FOnlyOnCanceled;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.TaskContinuationOptions ExecuteSynchronously
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions r_FExecuteSynchronously;
		public static SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks.RTaskContinuationOptions RFExecuteSynchronously
		{
			get
			{
				if(r_FExecuteSynchronously == null)
				{
					r_FExecuteSynchronously = new(typeof(System.Threading.Tasks.TaskContinuationOptions), "ExecuteSynchronously");
					r_FExecuteSynchronously.SetBelong(null);
				}
				return r_FExecuteSynchronously;
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
					r_MGetValue.SetBelong(this.instance);
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
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
					r_MToString_String_IFormatProvider.SetBelong(this.instance);
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
					r_MCompareTo_Object.SetBelong(this.instance);
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
					r_MToString_String.SetBelong(this.instance);
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
					r_MToString_IFormatProvider.SetBelong(this.instance);
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
					r_MHasFlag_Enum.SetBelong(this.instance);
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
					r_MGetTypeCode.SetBelong(this.instance);
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


        public RTaskContinuationOptions() : base("System.Threading.Tasks.TaskContinuationOptions")
        {
        }

        public RTaskContinuationOptions(System.Object instance) : base("System.Threading.Tasks.TaskContinuationOptions")
		{
            SetInstance(instance);
		}

        public RTaskContinuationOptions(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTaskContinuationOptions(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
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