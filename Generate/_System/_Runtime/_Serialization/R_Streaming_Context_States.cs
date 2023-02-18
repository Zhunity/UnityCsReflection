
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization
{
	/// <summary>
	/// System.Runtime.Serialization.StreamingContextStates
	/// </summary>
    public partial class RStreamingContextStates : RMember //
    {

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
		/// System.Runtime.Serialization.StreamingContextStates CrossProcess
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RStreamingContextStates r_FCrossProcess;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RStreamingContextStates RFCrossProcess
		{
			get
			{
				if(r_FCrossProcess == null)
				{
					r_FCrossProcess = new(typeof(System.Runtime.Serialization.StreamingContextStates), "CrossProcess");
				}
				return r_FCrossProcess;
			}
		}

		/// <summary>
		/// System.Runtime.Serialization.StreamingContextStates CrossMachine
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RStreamingContextStates r_FCrossMachine;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RStreamingContextStates RFCrossMachine
		{
			get
			{
				if(r_FCrossMachine == null)
				{
					r_FCrossMachine = new(typeof(System.Runtime.Serialization.StreamingContextStates), "CrossMachine");
				}
				return r_FCrossMachine;
			}
		}

		/// <summary>
		/// System.Runtime.Serialization.StreamingContextStates File
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RStreamingContextStates r_FFile;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RStreamingContextStates RFFile
		{
			get
			{
				if(r_FFile == null)
				{
					r_FFile = new(typeof(System.Runtime.Serialization.StreamingContextStates), "File");
				}
				return r_FFile;
			}
		}

		/// <summary>
		/// System.Runtime.Serialization.StreamingContextStates Persistence
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RStreamingContextStates r_FPersistence;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RStreamingContextStates RFPersistence
		{
			get
			{
				if(r_FPersistence == null)
				{
					r_FPersistence = new(typeof(System.Runtime.Serialization.StreamingContextStates), "Persistence");
				}
				return r_FPersistence;
			}
		}

		/// <summary>
		/// System.Runtime.Serialization.StreamingContextStates Remoting
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RStreamingContextStates r_FRemoting;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RStreamingContextStates RFRemoting
		{
			get
			{
				if(r_FRemoting == null)
				{
					r_FRemoting = new(typeof(System.Runtime.Serialization.StreamingContextStates), "Remoting");
				}
				return r_FRemoting;
			}
		}

		/// <summary>
		/// System.Runtime.Serialization.StreamingContextStates Other
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RStreamingContextStates r_FOther;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RStreamingContextStates RFOther
		{
			get
			{
				if(r_FOther == null)
				{
					r_FOther = new(typeof(System.Runtime.Serialization.StreamingContextStates), "Other");
				}
				return r_FOther;
			}
		}

		/// <summary>
		/// System.Runtime.Serialization.StreamingContextStates Clone
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RStreamingContextStates r_FClone;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RStreamingContextStates RFClone
		{
			get
			{
				if(r_FClone == null)
				{
					r_FClone = new(typeof(System.Runtime.Serialization.StreamingContextStates), "Clone");
				}
				return r_FClone;
			}
		}

		/// <summary>
		/// System.Runtime.Serialization.StreamingContextStates CrossAppDomain
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RStreamingContextStates r_FCrossAppDomain;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RStreamingContextStates RFCrossAppDomain
		{
			get
			{
				if(r_FCrossAppDomain == null)
				{
					r_FCrossAppDomain = new(typeof(System.Runtime.Serialization.StreamingContextStates), "CrossAppDomain");
				}
				return r_FCrossAppDomain;
			}
		}

		/// <summary>
		/// System.Runtime.Serialization.StreamingContextStates All
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RStreamingContextStates r_FAll;
		public static Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RStreamingContextStates RFAll
		{
			get
			{
				if(r_FAll == null)
				{
					r_FAll = new(typeof(System.Runtime.Serialization.StreamingContextStates), "All");
				}
				return r_FAll;
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


        public RStreamingContextStates() : base("System.Runtime.Serialization.StreamingContextStates")
        {
        }

        public RStreamingContextStates(System.Object instance) : base("System.Runtime.Serialization.StreamingContextStates")
		{
            SetInstance(instance);
		}

        public RStreamingContextStates(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStreamingContextStates(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
