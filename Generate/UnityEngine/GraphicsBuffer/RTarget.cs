using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{public partial class RGraphicsBuffer
{
	
	/// <summary>
	/// UnityEngine.GraphicsBuffer+Target
	/// </summary>
    public partial class RTarget : RMember //
    {

		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected RSystem.RInt32 r_Fvalue__;
		public virtual RSystem.RInt32 RFvalue__
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
		/// UnityEngine.GraphicsBuffer+Target Vertex
		/// </summary>
		protected static RUnityEngine.RGraphicsBuffer.RTarget r_FVertex;
		public static RUnityEngine.RGraphicsBuffer.RTarget RFVertex
		{
			get
			{
				if(r_FVertex == null)
				{
					r_FVertex = new( ReflectionUtils.GetType("UnityEngine.GraphicsBuffer+Target"), "Vertex");
					r_FVertex.SetBelong(null);
				}
				return r_FVertex;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer+Target Index
		/// </summary>
		protected static RUnityEngine.RGraphicsBuffer.RTarget r_FIndex;
		public static RUnityEngine.RGraphicsBuffer.RTarget RFIndex
		{
			get
			{
				if(r_FIndex == null)
				{
					r_FIndex = new( ReflectionUtils.GetType("UnityEngine.GraphicsBuffer+Target"), "Index");
					r_FIndex.SetBelong(null);
				}
				return r_FIndex;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer+Target CopySource
		/// </summary>
		protected static RUnityEngine.RGraphicsBuffer.RTarget r_FCopySource;
		public static RUnityEngine.RGraphicsBuffer.RTarget RFCopySource
		{
			get
			{
				if(r_FCopySource == null)
				{
					r_FCopySource = new( ReflectionUtils.GetType("UnityEngine.GraphicsBuffer+Target"), "CopySource");
					r_FCopySource.SetBelong(null);
				}
				return r_FCopySource;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer+Target CopyDestination
		/// </summary>
		protected static RUnityEngine.RGraphicsBuffer.RTarget r_FCopyDestination;
		public static RUnityEngine.RGraphicsBuffer.RTarget RFCopyDestination
		{
			get
			{
				if(r_FCopyDestination == null)
				{
					r_FCopyDestination = new( ReflectionUtils.GetType("UnityEngine.GraphicsBuffer+Target"), "CopyDestination");
					r_FCopyDestination.SetBelong(null);
				}
				return r_FCopyDestination;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer+Target Structured
		/// </summary>
		protected static RUnityEngine.RGraphicsBuffer.RTarget r_FStructured;
		public static RUnityEngine.RGraphicsBuffer.RTarget RFStructured
		{
			get
			{
				if(r_FStructured == null)
				{
					r_FStructured = new( ReflectionUtils.GetType("UnityEngine.GraphicsBuffer+Target"), "Structured");
					r_FStructured.SetBelong(null);
				}
				return r_FStructured;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer+Target Raw
		/// </summary>
		protected static RUnityEngine.RGraphicsBuffer.RTarget r_FRaw;
		public static RUnityEngine.RGraphicsBuffer.RTarget RFRaw
		{
			get
			{
				if(r_FRaw == null)
				{
					r_FRaw = new( ReflectionUtils.GetType("UnityEngine.GraphicsBuffer+Target"), "Raw");
					r_FRaw.SetBelong(null);
				}
				return r_FRaw;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer+Target Append
		/// </summary>
		protected static RUnityEngine.RGraphicsBuffer.RTarget r_FAppend;
		public static RUnityEngine.RGraphicsBuffer.RTarget RFAppend
		{
			get
			{
				if(r_FAppend == null)
				{
					r_FAppend = new( ReflectionUtils.GetType("UnityEngine.GraphicsBuffer+Target"), "Append");
					r_FAppend.SetBelong(null);
				}
				return r_FAppend;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer+Target Counter
		/// </summary>
		protected static RUnityEngine.RGraphicsBuffer.RTarget r_FCounter;
		public static RUnityEngine.RGraphicsBuffer.RTarget RFCounter
		{
			get
			{
				if(r_FCounter == null)
				{
					r_FCounter = new( ReflectionUtils.GetType("UnityEngine.GraphicsBuffer+Target"), "Counter");
					r_FCounter.SetBelong(null);
				}
				return r_FCounter;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer+Target IndirectArguments
		/// </summary>
		protected static RUnityEngine.RGraphicsBuffer.RTarget r_FIndirectArguments;
		public static RUnityEngine.RGraphicsBuffer.RTarget RFIndirectArguments
		{
			get
			{
				if(r_FIndirectArguments == null)
				{
					r_FIndirectArguments = new( ReflectionUtils.GetType("UnityEngine.GraphicsBuffer+Target"), "IndirectArguments");
					r_FIndirectArguments.SetBelong(null);
				}
				return r_FIndirectArguments;
			}
		}

		/// <summary>
		/// UnityEngine.GraphicsBuffer+Target Constant
		/// </summary>
		protected static RUnityEngine.RGraphicsBuffer.RTarget r_FConstant;
		public static RUnityEngine.RGraphicsBuffer.RTarget RFConstant
		{
			get
			{
				if(r_FConstant == null)
				{
					r_FConstant = new( ReflectionUtils.GetType("UnityEngine.GraphicsBuffer+Target"), "Constant");
					r_FConstant.SetBelong(null);
				}
				return r_FConstant;
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


        public RTarget() : base("UnityEngine.GraphicsBuffer+Target")
        {
        }

        public RTarget(System.Object instance) : base("UnityEngine.GraphicsBuffer+Target")
		{
            SetInstance(instance);
		}

        public RTarget(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTarget(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
}