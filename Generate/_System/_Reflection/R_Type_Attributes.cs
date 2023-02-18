
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.TypeAttributes
	/// </summary>
    public partial class RTypeAttributes : RMember //
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
		/// System.Reflection.TypeAttributes VisibilityMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FVisibilityMask;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFVisibilityMask
		{
			get
			{
				if(r_FVisibilityMask == null)
				{
					r_FVisibilityMask = new(typeof(System.Reflection.TypeAttributes), "VisibilityMask");
				}
				return r_FVisibilityMask;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes NotPublic
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FNotPublic;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFNotPublic
		{
			get
			{
				if(r_FNotPublic == null)
				{
					r_FNotPublic = new(typeof(System.Reflection.TypeAttributes), "NotPublic");
				}
				return r_FNotPublic;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes Public
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FPublic;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFPublic
		{
			get
			{
				if(r_FPublic == null)
				{
					r_FPublic = new(typeof(System.Reflection.TypeAttributes), "Public");
				}
				return r_FPublic;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes NestedPublic
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FNestedPublic;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFNestedPublic
		{
			get
			{
				if(r_FNestedPublic == null)
				{
					r_FNestedPublic = new(typeof(System.Reflection.TypeAttributes), "NestedPublic");
				}
				return r_FNestedPublic;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes NestedPrivate
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FNestedPrivate;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFNestedPrivate
		{
			get
			{
				if(r_FNestedPrivate == null)
				{
					r_FNestedPrivate = new(typeof(System.Reflection.TypeAttributes), "NestedPrivate");
				}
				return r_FNestedPrivate;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes NestedFamily
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FNestedFamily;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFNestedFamily
		{
			get
			{
				if(r_FNestedFamily == null)
				{
					r_FNestedFamily = new(typeof(System.Reflection.TypeAttributes), "NestedFamily");
				}
				return r_FNestedFamily;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes NestedAssembly
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FNestedAssembly;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFNestedAssembly
		{
			get
			{
				if(r_FNestedAssembly == null)
				{
					r_FNestedAssembly = new(typeof(System.Reflection.TypeAttributes), "NestedAssembly");
				}
				return r_FNestedAssembly;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes NestedFamANDAssem
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FNestedFamANDAssem;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFNestedFamANDAssem
		{
			get
			{
				if(r_FNestedFamANDAssem == null)
				{
					r_FNestedFamANDAssem = new(typeof(System.Reflection.TypeAttributes), "NestedFamANDAssem");
				}
				return r_FNestedFamANDAssem;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes NestedFamORAssem
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FNestedFamORAssem;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFNestedFamORAssem
		{
			get
			{
				if(r_FNestedFamORAssem == null)
				{
					r_FNestedFamORAssem = new(typeof(System.Reflection.TypeAttributes), "NestedFamORAssem");
				}
				return r_FNestedFamORAssem;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes LayoutMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FLayoutMask;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFLayoutMask
		{
			get
			{
				if(r_FLayoutMask == null)
				{
					r_FLayoutMask = new(typeof(System.Reflection.TypeAttributes), "LayoutMask");
				}
				return r_FLayoutMask;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes AutoLayout
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FAutoLayout;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFAutoLayout
		{
			get
			{
				if(r_FAutoLayout == null)
				{
					r_FAutoLayout = new(typeof(System.Reflection.TypeAttributes), "AutoLayout");
				}
				return r_FAutoLayout;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes SequentialLayout
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FSequentialLayout;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFSequentialLayout
		{
			get
			{
				if(r_FSequentialLayout == null)
				{
					r_FSequentialLayout = new(typeof(System.Reflection.TypeAttributes), "SequentialLayout");
				}
				return r_FSequentialLayout;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes ExplicitLayout
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FExplicitLayout;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFExplicitLayout
		{
			get
			{
				if(r_FExplicitLayout == null)
				{
					r_FExplicitLayout = new(typeof(System.Reflection.TypeAttributes), "ExplicitLayout");
				}
				return r_FExplicitLayout;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes ClassSemanticsMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FClassSemanticsMask;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFClassSemanticsMask
		{
			get
			{
				if(r_FClassSemanticsMask == null)
				{
					r_FClassSemanticsMask = new(typeof(System.Reflection.TypeAttributes), "ClassSemanticsMask");
				}
				return r_FClassSemanticsMask;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes Class
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FClass;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFClass
		{
			get
			{
				if(r_FClass == null)
				{
					r_FClass = new(typeof(System.Reflection.TypeAttributes), "Class");
				}
				return r_FClass;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes Interface
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FInterface;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFInterface
		{
			get
			{
				if(r_FInterface == null)
				{
					r_FInterface = new(typeof(System.Reflection.TypeAttributes), "Interface");
				}
				return r_FInterface;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes Abstract
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FAbstract;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFAbstract
		{
			get
			{
				if(r_FAbstract == null)
				{
					r_FAbstract = new(typeof(System.Reflection.TypeAttributes), "Abstract");
				}
				return r_FAbstract;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes Sealed
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FSealed;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFSealed
		{
			get
			{
				if(r_FSealed == null)
				{
					r_FSealed = new(typeof(System.Reflection.TypeAttributes), "Sealed");
				}
				return r_FSealed;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes SpecialName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FSpecialName;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFSpecialName
		{
			get
			{
				if(r_FSpecialName == null)
				{
					r_FSpecialName = new(typeof(System.Reflection.TypeAttributes), "SpecialName");
				}
				return r_FSpecialName;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes Import
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FImport;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFImport
		{
			get
			{
				if(r_FImport == null)
				{
					r_FImport = new(typeof(System.Reflection.TypeAttributes), "Import");
				}
				return r_FImport;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes Serializable
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FSerializable;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFSerializable
		{
			get
			{
				if(r_FSerializable == null)
				{
					r_FSerializable = new(typeof(System.Reflection.TypeAttributes), "Serializable");
				}
				return r_FSerializable;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes WindowsRuntime
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FWindowsRuntime;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFWindowsRuntime
		{
			get
			{
				if(r_FWindowsRuntime == null)
				{
					r_FWindowsRuntime = new(typeof(System.Reflection.TypeAttributes), "WindowsRuntime");
				}
				return r_FWindowsRuntime;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes StringFormatMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FStringFormatMask;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFStringFormatMask
		{
			get
			{
				if(r_FStringFormatMask == null)
				{
					r_FStringFormatMask = new(typeof(System.Reflection.TypeAttributes), "StringFormatMask");
				}
				return r_FStringFormatMask;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes AnsiClass
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FAnsiClass;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFAnsiClass
		{
			get
			{
				if(r_FAnsiClass == null)
				{
					r_FAnsiClass = new(typeof(System.Reflection.TypeAttributes), "AnsiClass");
				}
				return r_FAnsiClass;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes UnicodeClass
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FUnicodeClass;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFUnicodeClass
		{
			get
			{
				if(r_FUnicodeClass == null)
				{
					r_FUnicodeClass = new(typeof(System.Reflection.TypeAttributes), "UnicodeClass");
				}
				return r_FUnicodeClass;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes AutoClass
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FAutoClass;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFAutoClass
		{
			get
			{
				if(r_FAutoClass == null)
				{
					r_FAutoClass = new(typeof(System.Reflection.TypeAttributes), "AutoClass");
				}
				return r_FAutoClass;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes CustomFormatClass
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FCustomFormatClass;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFCustomFormatClass
		{
			get
			{
				if(r_FCustomFormatClass == null)
				{
					r_FCustomFormatClass = new(typeof(System.Reflection.TypeAttributes), "CustomFormatClass");
				}
				return r_FCustomFormatClass;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes CustomFormatMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FCustomFormatMask;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFCustomFormatMask
		{
			get
			{
				if(r_FCustomFormatMask == null)
				{
					r_FCustomFormatMask = new(typeof(System.Reflection.TypeAttributes), "CustomFormatMask");
				}
				return r_FCustomFormatMask;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes BeforeFieldInit
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FBeforeFieldInit;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFBeforeFieldInit
		{
			get
			{
				if(r_FBeforeFieldInit == null)
				{
					r_FBeforeFieldInit = new(typeof(System.Reflection.TypeAttributes), "BeforeFieldInit");
				}
				return r_FBeforeFieldInit;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes RTSpecialName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FRTSpecialName;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFRTSpecialName
		{
			get
			{
				if(r_FRTSpecialName == null)
				{
					r_FRTSpecialName = new(typeof(System.Reflection.TypeAttributes), "RTSpecialName");
				}
				return r_FRTSpecialName;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes HasSecurity
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FHasSecurity;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFHasSecurity
		{
			get
			{
				if(r_FHasSecurity == null)
				{
					r_FHasSecurity = new(typeof(System.Reflection.TypeAttributes), "HasSecurity");
				}
				return r_FHasSecurity;
			}
		}

		/// <summary>
		/// System.Reflection.TypeAttributes ReservedMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes r_FReservedMask;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RTypeAttributes RFReservedMask
		{
			get
			{
				if(r_FReservedMask == null)
				{
					r_FReservedMask = new(typeof(System.Reflection.TypeAttributes), "ReservedMask");
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


        public RTypeAttributes() : base("System.Reflection.TypeAttributes")
        {
        }

        public RTypeAttributes(System.Object instance) : base("System.Reflection.TypeAttributes")
		{
            SetInstance(instance);
		}

        public RTypeAttributes(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTypeAttributes(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
