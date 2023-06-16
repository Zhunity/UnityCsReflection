
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// System.Reflection.FieldAttributes
	/// </summary>
    public partial class RFieldAttributes : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Reflection.FieldAttributes);
            }
        }

        public RFieldAttributes() : base("System.Reflection.FieldAttributes")
        {
        }

        public RFieldAttributes(System.Object instance) : base("System.Reflection.FieldAttributes")
		{
            SetInstance(instance);
		}

        public RFieldAttributes(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFieldAttributes(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// System.Reflection.FieldAttributes FieldAccessMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes r_FFieldAccessMask;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes RFFieldAccessMask
		{
			get
			{
				if(r_FFieldAccessMask == null)
				{
					r_FFieldAccessMask = new(Type, "FieldAccessMask");
				}
				return r_FFieldAccessMask;
			}
		}

		/// <summary>
		/// System.Reflection.FieldAttributes PrivateScope
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes r_FPrivateScope;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes RFPrivateScope
		{
			get
			{
				if(r_FPrivateScope == null)
				{
					r_FPrivateScope = new(Type, "PrivateScope");
				}
				return r_FPrivateScope;
			}
		}

		/// <summary>
		/// System.Reflection.FieldAttributes Private
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes r_FPrivate;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes RFPrivate
		{
			get
			{
				if(r_FPrivate == null)
				{
					r_FPrivate = new(Type, "Private");
				}
				return r_FPrivate;
			}
		}

		/// <summary>
		/// System.Reflection.FieldAttributes FamANDAssem
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes r_FFamANDAssem;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes RFFamANDAssem
		{
			get
			{
				if(r_FFamANDAssem == null)
				{
					r_FFamANDAssem = new(Type, "FamANDAssem");
				}
				return r_FFamANDAssem;
			}
		}

		/// <summary>
		/// System.Reflection.FieldAttributes Assembly
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes r_FAssembly;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes RFAssembly
		{
			get
			{
				if(r_FAssembly == null)
				{
					r_FAssembly = new(Type, "Assembly");
				}
				return r_FAssembly;
			}
		}

		/// <summary>
		/// System.Reflection.FieldAttributes Family
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes r_FFamily;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes RFFamily
		{
			get
			{
				if(r_FFamily == null)
				{
					r_FFamily = new(Type, "Family");
				}
				return r_FFamily;
			}
		}

		/// <summary>
		/// System.Reflection.FieldAttributes FamORAssem
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes r_FFamORAssem;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes RFFamORAssem
		{
			get
			{
				if(r_FFamORAssem == null)
				{
					r_FFamORAssem = new(Type, "FamORAssem");
				}
				return r_FFamORAssem;
			}
		}

		/// <summary>
		/// System.Reflection.FieldAttributes Public
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes r_FPublic;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes RFPublic
		{
			get
			{
				if(r_FPublic == null)
				{
					r_FPublic = new(Type, "Public");
				}
				return r_FPublic;
			}
		}

		/// <summary>
		/// System.Reflection.FieldAttributes Static
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes r_FStatic;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes RFStatic
		{
			get
			{
				if(r_FStatic == null)
				{
					r_FStatic = new(Type, "Static");
				}
				return r_FStatic;
			}
		}

		/// <summary>
		/// System.Reflection.FieldAttributes InitOnly
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes r_FInitOnly;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes RFInitOnly
		{
			get
			{
				if(r_FInitOnly == null)
				{
					r_FInitOnly = new(Type, "InitOnly");
				}
				return r_FInitOnly;
			}
		}

		/// <summary>
		/// System.Reflection.FieldAttributes Literal
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes r_FLiteral;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes RFLiteral
		{
			get
			{
				if(r_FLiteral == null)
				{
					r_FLiteral = new(Type, "Literal");
				}
				return r_FLiteral;
			}
		}

		/// <summary>
		/// System.Reflection.FieldAttributes NotSerialized
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes r_FNotSerialized;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes RFNotSerialized
		{
			get
			{
				if(r_FNotSerialized == null)
				{
					r_FNotSerialized = new(Type, "NotSerialized");
				}
				return r_FNotSerialized;
			}
		}

		/// <summary>
		/// System.Reflection.FieldAttributes SpecialName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes r_FSpecialName;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes RFSpecialName
		{
			get
			{
				if(r_FSpecialName == null)
				{
					r_FSpecialName = new(Type, "SpecialName");
				}
				return r_FSpecialName;
			}
		}

		/// <summary>
		/// System.Reflection.FieldAttributes PinvokeImpl
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes r_FPinvokeImpl;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes RFPinvokeImpl
		{
			get
			{
				if(r_FPinvokeImpl == null)
				{
					r_FPinvokeImpl = new(Type, "PinvokeImpl");
				}
				return r_FPinvokeImpl;
			}
		}

		/// <summary>
		/// System.Reflection.FieldAttributes RTSpecialName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes r_FRTSpecialName;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes RFRTSpecialName
		{
			get
			{
				if(r_FRTSpecialName == null)
				{
					r_FRTSpecialName = new(Type, "RTSpecialName");
				}
				return r_FRTSpecialName;
			}
		}

		/// <summary>
		/// System.Reflection.FieldAttributes HasFieldMarshal
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes r_FHasFieldMarshal;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes RFHasFieldMarshal
		{
			get
			{
				if(r_FHasFieldMarshal == null)
				{
					r_FHasFieldMarshal = new(Type, "HasFieldMarshal");
				}
				return r_FHasFieldMarshal;
			}
		}

		/// <summary>
		/// System.Reflection.FieldAttributes HasDefault
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes r_FHasDefault;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes RFHasDefault
		{
			get
			{
				if(r_FHasDefault == null)
				{
					r_FHasDefault = new(Type, "HasDefault");
				}
				return r_FHasDefault;
			}
		}

		/// <summary>
		/// System.Reflection.FieldAttributes HasFieldRVA
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes r_FHasFieldRVA;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes RFHasFieldRVA
		{
			get
			{
				if(r_FHasFieldRVA == null)
				{
					r_FHasFieldRVA = new(Type, "HasFieldRVA");
				}
				return r_FHasFieldRVA;
			}
		}

		/// <summary>
		/// System.Reflection.FieldAttributes ReservedMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes r_FReservedMask;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RFieldAttributes RFReservedMask
		{
			get
			{
				if(r_FReservedMask == null)
				{
					r_FReservedMask = new(Type, "ReservedMask");
				}
				return r_FReservedMask;
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
