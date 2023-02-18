
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel
{
	/// <summary>
	/// Unity.Profiling.LowLevel.ProfilerMarkerDataType
	/// </summary>
    public partial class RProfilerMarkerDataType : RMember //
    {

		/// <summary>
		/// System.Byte value__
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_Fvalue__;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
					r_Fvalue__.SetBelong(this.GetValue());
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.ProfilerMarkerDataType InstanceId
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType r_FInstanceId;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType RFInstanceId
		{
			get
			{
				if(r_FInstanceId == null)
				{
					r_FInstanceId = new(typeof(Unity.Profiling.LowLevel.ProfilerMarkerDataType), "InstanceId");
					r_FInstanceId.SetBelong(null);
				}
				return r_FInstanceId;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.ProfilerMarkerDataType Int32
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType r_FInt32;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType RFInt32
		{
			get
			{
				if(r_FInt32 == null)
				{
					r_FInt32 = new(typeof(Unity.Profiling.LowLevel.ProfilerMarkerDataType), "Int32");
					r_FInt32.SetBelong(null);
				}
				return r_FInt32;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.ProfilerMarkerDataType UInt32
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType r_FUInt32;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType RFUInt32
		{
			get
			{
				if(r_FUInt32 == null)
				{
					r_FUInt32 = new(typeof(Unity.Profiling.LowLevel.ProfilerMarkerDataType), "UInt32");
					r_FUInt32.SetBelong(null);
				}
				return r_FUInt32;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.ProfilerMarkerDataType Int64
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType r_FInt64;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType RFInt64
		{
			get
			{
				if(r_FInt64 == null)
				{
					r_FInt64 = new(typeof(Unity.Profiling.LowLevel.ProfilerMarkerDataType), "Int64");
					r_FInt64.SetBelong(null);
				}
				return r_FInt64;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.ProfilerMarkerDataType UInt64
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType r_FUInt64;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType RFUInt64
		{
			get
			{
				if(r_FUInt64 == null)
				{
					r_FUInt64 = new(typeof(Unity.Profiling.LowLevel.ProfilerMarkerDataType), "UInt64");
					r_FUInt64.SetBelong(null);
				}
				return r_FUInt64;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.ProfilerMarkerDataType Float
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType r_FFloat;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType RFFloat
		{
			get
			{
				if(r_FFloat == null)
				{
					r_FFloat = new(typeof(Unity.Profiling.LowLevel.ProfilerMarkerDataType), "Float");
					r_FFloat.SetBelong(null);
				}
				return r_FFloat;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.ProfilerMarkerDataType Double
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType r_FDouble;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType RFDouble
		{
			get
			{
				if(r_FDouble == null)
				{
					r_FDouble = new(typeof(Unity.Profiling.LowLevel.ProfilerMarkerDataType), "Double");
					r_FDouble.SetBelong(null);
				}
				return r_FDouble;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.ProfilerMarkerDataType String16
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType r_FString16;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType RFString16
		{
			get
			{
				if(r_FString16 == null)
				{
					r_FString16 = new(typeof(Unity.Profiling.LowLevel.ProfilerMarkerDataType), "String16");
					r_FString16.SetBelong(null);
				}
				return r_FString16;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.ProfilerMarkerDataType Blob8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType r_FBlob8;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType RFBlob8
		{
			get
			{
				if(r_FBlob8 == null)
				{
					r_FBlob8 = new(typeof(Unity.Profiling.LowLevel.ProfilerMarkerDataType), "Blob8");
					r_FBlob8.SetBelong(null);
				}
				return r_FBlob8;
			}
		}

		/// <summary>
		/// Unity.Profiling.LowLevel.ProfilerMarkerDataType GfxResourceId
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType r_FGfxResourceId;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RLowLevel.RProfilerMarkerDataType RFGfxResourceId
		{
			get
			{
				if(r_FGfxResourceId == null)
				{
					r_FGfxResourceId = new(typeof(Unity.Profiling.LowLevel.ProfilerMarkerDataType), "GfxResourceId");
					r_FGfxResourceId.SetBelong(null);
				}
				return r_FGfxResourceId;
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
					r_MGetValue.SetBelong(this.GetValue());
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
					r_MToString_String_IFormatProvider.SetBelong(this.GetValue());
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
					r_MCompareTo_Object.SetBelong(this.GetValue());
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
					r_MToString_String.SetBelong(this.GetValue());
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
					r_MToString_IFormatProvider.SetBelong(this.GetValue());
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
					r_MHasFlag_Enum.SetBelong(this.GetValue());
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
					r_MGetTypeCode.SetBelong(this.GetValue());
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


        public RProfilerMarkerDataType() : base("Unity.Profiling.LowLevel.ProfilerMarkerDataType")
        {
        }

        public RProfilerMarkerDataType(System.Object instance) : base("Unity.Profiling.LowLevel.ProfilerMarkerDataType")
		{
            SetInstance(instance);
		}

        public RProfilerMarkerDataType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RProfilerMarkerDataType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
