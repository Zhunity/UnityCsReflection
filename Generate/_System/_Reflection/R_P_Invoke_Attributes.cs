
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.PInvokeAttributes
	/// </summary>
    public partial class RPInvokeAttributes : RMember //
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
					r_Fvalue__.SetBelong(this.instance);
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// System.Reflection.PInvokeAttributes NoMangle
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes r_FNoMangle;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes RFNoMangle
		{
			get
			{
				if(r_FNoMangle == null)
				{
					r_FNoMangle = new( ReflectionUtils.GetType("System.Reflection.PInvokeAttributes"), "NoMangle");
					r_FNoMangle.SetBelong(null);
				}
				return r_FNoMangle;
			}
		}

		/// <summary>
		/// System.Reflection.PInvokeAttributes CharSetMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes r_FCharSetMask;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes RFCharSetMask
		{
			get
			{
				if(r_FCharSetMask == null)
				{
					r_FCharSetMask = new( ReflectionUtils.GetType("System.Reflection.PInvokeAttributes"), "CharSetMask");
					r_FCharSetMask.SetBelong(null);
				}
				return r_FCharSetMask;
			}
		}

		/// <summary>
		/// System.Reflection.PInvokeAttributes CharSetNotSpec
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes r_FCharSetNotSpec;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes RFCharSetNotSpec
		{
			get
			{
				if(r_FCharSetNotSpec == null)
				{
					r_FCharSetNotSpec = new( ReflectionUtils.GetType("System.Reflection.PInvokeAttributes"), "CharSetNotSpec");
					r_FCharSetNotSpec.SetBelong(null);
				}
				return r_FCharSetNotSpec;
			}
		}

		/// <summary>
		/// System.Reflection.PInvokeAttributes CharSetAnsi
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes r_FCharSetAnsi;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes RFCharSetAnsi
		{
			get
			{
				if(r_FCharSetAnsi == null)
				{
					r_FCharSetAnsi = new( ReflectionUtils.GetType("System.Reflection.PInvokeAttributes"), "CharSetAnsi");
					r_FCharSetAnsi.SetBelong(null);
				}
				return r_FCharSetAnsi;
			}
		}

		/// <summary>
		/// System.Reflection.PInvokeAttributes CharSetUnicode
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes r_FCharSetUnicode;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes RFCharSetUnicode
		{
			get
			{
				if(r_FCharSetUnicode == null)
				{
					r_FCharSetUnicode = new( ReflectionUtils.GetType("System.Reflection.PInvokeAttributes"), "CharSetUnicode");
					r_FCharSetUnicode.SetBelong(null);
				}
				return r_FCharSetUnicode;
			}
		}

		/// <summary>
		/// System.Reflection.PInvokeAttributes CharSetAuto
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes r_FCharSetAuto;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes RFCharSetAuto
		{
			get
			{
				if(r_FCharSetAuto == null)
				{
					r_FCharSetAuto = new( ReflectionUtils.GetType("System.Reflection.PInvokeAttributes"), "CharSetAuto");
					r_FCharSetAuto.SetBelong(null);
				}
				return r_FCharSetAuto;
			}
		}

		/// <summary>
		/// System.Reflection.PInvokeAttributes BestFitUseAssem
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes r_FBestFitUseAssem;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes RFBestFitUseAssem
		{
			get
			{
				if(r_FBestFitUseAssem == null)
				{
					r_FBestFitUseAssem = new( ReflectionUtils.GetType("System.Reflection.PInvokeAttributes"), "BestFitUseAssem");
					r_FBestFitUseAssem.SetBelong(null);
				}
				return r_FBestFitUseAssem;
			}
		}

		/// <summary>
		/// System.Reflection.PInvokeAttributes BestFitEnabled
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes r_FBestFitEnabled;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes RFBestFitEnabled
		{
			get
			{
				if(r_FBestFitEnabled == null)
				{
					r_FBestFitEnabled = new( ReflectionUtils.GetType("System.Reflection.PInvokeAttributes"), "BestFitEnabled");
					r_FBestFitEnabled.SetBelong(null);
				}
				return r_FBestFitEnabled;
			}
		}

		/// <summary>
		/// System.Reflection.PInvokeAttributes BestFitDisabled
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes r_FBestFitDisabled;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes RFBestFitDisabled
		{
			get
			{
				if(r_FBestFitDisabled == null)
				{
					r_FBestFitDisabled = new( ReflectionUtils.GetType("System.Reflection.PInvokeAttributes"), "BestFitDisabled");
					r_FBestFitDisabled.SetBelong(null);
				}
				return r_FBestFitDisabled;
			}
		}

		/// <summary>
		/// System.Reflection.PInvokeAttributes BestFitMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes r_FBestFitMask;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes RFBestFitMask
		{
			get
			{
				if(r_FBestFitMask == null)
				{
					r_FBestFitMask = new( ReflectionUtils.GetType("System.Reflection.PInvokeAttributes"), "BestFitMask");
					r_FBestFitMask.SetBelong(null);
				}
				return r_FBestFitMask;
			}
		}

		/// <summary>
		/// System.Reflection.PInvokeAttributes ThrowOnUnmappableCharUseAssem
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes r_FThrowOnUnmappableCharUseAssem;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes RFThrowOnUnmappableCharUseAssem
		{
			get
			{
				if(r_FThrowOnUnmappableCharUseAssem == null)
				{
					r_FThrowOnUnmappableCharUseAssem = new( ReflectionUtils.GetType("System.Reflection.PInvokeAttributes"), "ThrowOnUnmappableCharUseAssem");
					r_FThrowOnUnmappableCharUseAssem.SetBelong(null);
				}
				return r_FThrowOnUnmappableCharUseAssem;
			}
		}

		/// <summary>
		/// System.Reflection.PInvokeAttributes ThrowOnUnmappableCharEnabled
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes r_FThrowOnUnmappableCharEnabled;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes RFThrowOnUnmappableCharEnabled
		{
			get
			{
				if(r_FThrowOnUnmappableCharEnabled == null)
				{
					r_FThrowOnUnmappableCharEnabled = new( ReflectionUtils.GetType("System.Reflection.PInvokeAttributes"), "ThrowOnUnmappableCharEnabled");
					r_FThrowOnUnmappableCharEnabled.SetBelong(null);
				}
				return r_FThrowOnUnmappableCharEnabled;
			}
		}

		/// <summary>
		/// System.Reflection.PInvokeAttributes ThrowOnUnmappableCharDisabled
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes r_FThrowOnUnmappableCharDisabled;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes RFThrowOnUnmappableCharDisabled
		{
			get
			{
				if(r_FThrowOnUnmappableCharDisabled == null)
				{
					r_FThrowOnUnmappableCharDisabled = new( ReflectionUtils.GetType("System.Reflection.PInvokeAttributes"), "ThrowOnUnmappableCharDisabled");
					r_FThrowOnUnmappableCharDisabled.SetBelong(null);
				}
				return r_FThrowOnUnmappableCharDisabled;
			}
		}

		/// <summary>
		/// System.Reflection.PInvokeAttributes ThrowOnUnmappableCharMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes r_FThrowOnUnmappableCharMask;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes RFThrowOnUnmappableCharMask
		{
			get
			{
				if(r_FThrowOnUnmappableCharMask == null)
				{
					r_FThrowOnUnmappableCharMask = new( ReflectionUtils.GetType("System.Reflection.PInvokeAttributes"), "ThrowOnUnmappableCharMask");
					r_FThrowOnUnmappableCharMask.SetBelong(null);
				}
				return r_FThrowOnUnmappableCharMask;
			}
		}

		/// <summary>
		/// System.Reflection.PInvokeAttributes SupportsLastError
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes r_FSupportsLastError;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes RFSupportsLastError
		{
			get
			{
				if(r_FSupportsLastError == null)
				{
					r_FSupportsLastError = new( ReflectionUtils.GetType("System.Reflection.PInvokeAttributes"), "SupportsLastError");
					r_FSupportsLastError.SetBelong(null);
				}
				return r_FSupportsLastError;
			}
		}

		/// <summary>
		/// System.Reflection.PInvokeAttributes CallConvMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes r_FCallConvMask;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes RFCallConvMask
		{
			get
			{
				if(r_FCallConvMask == null)
				{
					r_FCallConvMask = new( ReflectionUtils.GetType("System.Reflection.PInvokeAttributes"), "CallConvMask");
					r_FCallConvMask.SetBelong(null);
				}
				return r_FCallConvMask;
			}
		}

		/// <summary>
		/// System.Reflection.PInvokeAttributes CallConvWinapi
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes r_FCallConvWinapi;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes RFCallConvWinapi
		{
			get
			{
				if(r_FCallConvWinapi == null)
				{
					r_FCallConvWinapi = new( ReflectionUtils.GetType("System.Reflection.PInvokeAttributes"), "CallConvWinapi");
					r_FCallConvWinapi.SetBelong(null);
				}
				return r_FCallConvWinapi;
			}
		}

		/// <summary>
		/// System.Reflection.PInvokeAttributes CallConvCdecl
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes r_FCallConvCdecl;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes RFCallConvCdecl
		{
			get
			{
				if(r_FCallConvCdecl == null)
				{
					r_FCallConvCdecl = new( ReflectionUtils.GetType("System.Reflection.PInvokeAttributes"), "CallConvCdecl");
					r_FCallConvCdecl.SetBelong(null);
				}
				return r_FCallConvCdecl;
			}
		}

		/// <summary>
		/// System.Reflection.PInvokeAttributes CallConvStdcall
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes r_FCallConvStdcall;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes RFCallConvStdcall
		{
			get
			{
				if(r_FCallConvStdcall == null)
				{
					r_FCallConvStdcall = new( ReflectionUtils.GetType("System.Reflection.PInvokeAttributes"), "CallConvStdcall");
					r_FCallConvStdcall.SetBelong(null);
				}
				return r_FCallConvStdcall;
			}
		}

		/// <summary>
		/// System.Reflection.PInvokeAttributes CallConvThiscall
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes r_FCallConvThiscall;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes RFCallConvThiscall
		{
			get
			{
				if(r_FCallConvThiscall == null)
				{
					r_FCallConvThiscall = new( ReflectionUtils.GetType("System.Reflection.PInvokeAttributes"), "CallConvThiscall");
					r_FCallConvThiscall.SetBelong(null);
				}
				return r_FCallConvThiscall;
			}
		}

		/// <summary>
		/// System.Reflection.PInvokeAttributes CallConvFastcall
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes r_FCallConvFastcall;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes RFCallConvFastcall
		{
			get
			{
				if(r_FCallConvFastcall == null)
				{
					r_FCallConvFastcall = new( ReflectionUtils.GetType("System.Reflection.PInvokeAttributes"), "CallConvFastcall");
					r_FCallConvFastcall.SetBelong(null);
				}
				return r_FCallConvFastcall;
			}
		}

		/// <summary>
		/// System.Reflection.PInvokeAttributes MaxValue
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes r_FMaxValue;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RPInvokeAttributes RFMaxValue
		{
			get
			{
				if(r_FMaxValue == null)
				{
					r_FMaxValue = new( ReflectionUtils.GetType("System.Reflection.PInvokeAttributes"), "MaxValue");
					r_FMaxValue.SetBelong(null);
				}
				return r_FMaxValue;
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


        public RPInvokeAttributes() : base("System.Reflection.PInvokeAttributes")
        {
        }

        public RPInvokeAttributes(System.Object instance) : base("System.Reflection.PInvokeAttributes")
		{
            SetInstance(instance);
		}

        public RPInvokeAttributes(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPInvokeAttributes(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
