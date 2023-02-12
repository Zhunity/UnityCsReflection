
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.TypeNameFormatFlags
	/// </summary>
    public partial class RTypeNameFormatFlags : RMember //
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
		/// System.TypeNameFormatFlags FormatBasic
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTypeNameFormatFlags r_FFormatBasic;
		public static SMFrame.Editor.Refleaction.RSystem.RTypeNameFormatFlags RFFormatBasic
		{
			get
			{
				if(r_FFormatBasic == null)
				{
					r_FFormatBasic = new( ReflectionUtils.GetType("System.TypeNameFormatFlags"), "FormatBasic");
					r_FFormatBasic.SetBelong(null);
				}
				return r_FFormatBasic;
			}
		}

		/// <summary>
		/// System.TypeNameFormatFlags FormatNamespace
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTypeNameFormatFlags r_FFormatNamespace;
		public static SMFrame.Editor.Refleaction.RSystem.RTypeNameFormatFlags RFFormatNamespace
		{
			get
			{
				if(r_FFormatNamespace == null)
				{
					r_FFormatNamespace = new( ReflectionUtils.GetType("System.TypeNameFormatFlags"), "FormatNamespace");
					r_FFormatNamespace.SetBelong(null);
				}
				return r_FFormatNamespace;
			}
		}

		/// <summary>
		/// System.TypeNameFormatFlags FormatFullInst
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTypeNameFormatFlags r_FFormatFullInst;
		public static SMFrame.Editor.Refleaction.RSystem.RTypeNameFormatFlags RFFormatFullInst
		{
			get
			{
				if(r_FFormatFullInst == null)
				{
					r_FFormatFullInst = new( ReflectionUtils.GetType("System.TypeNameFormatFlags"), "FormatFullInst");
					r_FFormatFullInst.SetBelong(null);
				}
				return r_FFormatFullInst;
			}
		}

		/// <summary>
		/// System.TypeNameFormatFlags FormatAssembly
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTypeNameFormatFlags r_FFormatAssembly;
		public static SMFrame.Editor.Refleaction.RSystem.RTypeNameFormatFlags RFFormatAssembly
		{
			get
			{
				if(r_FFormatAssembly == null)
				{
					r_FFormatAssembly = new( ReflectionUtils.GetType("System.TypeNameFormatFlags"), "FormatAssembly");
					r_FFormatAssembly.SetBelong(null);
				}
				return r_FFormatAssembly;
			}
		}

		/// <summary>
		/// System.TypeNameFormatFlags FormatSignature
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTypeNameFormatFlags r_FFormatSignature;
		public static SMFrame.Editor.Refleaction.RSystem.RTypeNameFormatFlags RFFormatSignature
		{
			get
			{
				if(r_FFormatSignature == null)
				{
					r_FFormatSignature = new( ReflectionUtils.GetType("System.TypeNameFormatFlags"), "FormatSignature");
					r_FFormatSignature.SetBelong(null);
				}
				return r_FFormatSignature;
			}
		}

		/// <summary>
		/// System.TypeNameFormatFlags FormatNoVersion
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTypeNameFormatFlags r_FFormatNoVersion;
		public static SMFrame.Editor.Refleaction.RSystem.RTypeNameFormatFlags RFFormatNoVersion
		{
			get
			{
				if(r_FFormatNoVersion == null)
				{
					r_FFormatNoVersion = new( ReflectionUtils.GetType("System.TypeNameFormatFlags"), "FormatNoVersion");
					r_FFormatNoVersion.SetBelong(null);
				}
				return r_FFormatNoVersion;
			}
		}

		/// <summary>
		/// System.TypeNameFormatFlags FormatAngleBrackets
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTypeNameFormatFlags r_FFormatAngleBrackets;
		public static SMFrame.Editor.Refleaction.RSystem.RTypeNameFormatFlags RFFormatAngleBrackets
		{
			get
			{
				if(r_FFormatAngleBrackets == null)
				{
					r_FFormatAngleBrackets = new( ReflectionUtils.GetType("System.TypeNameFormatFlags"), "FormatAngleBrackets");
					r_FFormatAngleBrackets.SetBelong(null);
				}
				return r_FFormatAngleBrackets;
			}
		}

		/// <summary>
		/// System.TypeNameFormatFlags FormatStubInfo
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTypeNameFormatFlags r_FFormatStubInfo;
		public static SMFrame.Editor.Refleaction.RSystem.RTypeNameFormatFlags RFFormatStubInfo
		{
			get
			{
				if(r_FFormatStubInfo == null)
				{
					r_FFormatStubInfo = new( ReflectionUtils.GetType("System.TypeNameFormatFlags"), "FormatStubInfo");
					r_FFormatStubInfo.SetBelong(null);
				}
				return r_FFormatStubInfo;
			}
		}

		/// <summary>
		/// System.TypeNameFormatFlags FormatGenericParam
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTypeNameFormatFlags r_FFormatGenericParam;
		public static SMFrame.Editor.Refleaction.RSystem.RTypeNameFormatFlags RFFormatGenericParam
		{
			get
			{
				if(r_FFormatGenericParam == null)
				{
					r_FFormatGenericParam = new( ReflectionUtils.GetType("System.TypeNameFormatFlags"), "FormatGenericParam");
					r_FFormatGenericParam.SetBelong(null);
				}
				return r_FFormatGenericParam;
			}
		}

		/// <summary>
		/// System.TypeNameFormatFlags FormatSerialization
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RTypeNameFormatFlags r_FFormatSerialization;
		public static SMFrame.Editor.Refleaction.RSystem.RTypeNameFormatFlags RFFormatSerialization
		{
			get
			{
				if(r_FFormatSerialization == null)
				{
					r_FFormatSerialization = new( ReflectionUtils.GetType("System.TypeNameFormatFlags"), "FormatSerialization");
					r_FFormatSerialization.SetBelong(null);
				}
				return r_FFormatSerialization;
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


        public RTypeNameFormatFlags() : base("System.TypeNameFormatFlags")
        {
        }

        public RTypeNameFormatFlags(System.Object instance) : base("System.TypeNameFormatFlags")
		{
            SetInstance(instance);
		}

        public RTypeNameFormatFlags(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTypeNameFormatFlags(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
