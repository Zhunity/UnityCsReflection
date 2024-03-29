
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Reflection.MethodAttributes
	/// </summary>
    public partial class RMethodAttributes : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Reflection.MethodAttributes);
            }
        }

        public RMethodAttributes() : base("System.Reflection.MethodAttributes")
        {
        }

        public RMethodAttributes(System.Object instance) : base("System.Reflection.MethodAttributes")
		{
            SetInstance(instance);
		}

        public RMethodAttributes(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMethodAttributes(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// System.Reflection.MethodAttributes MemberAccessMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FMemberAccessMask;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFMemberAccessMask
		{
			get
			{
				if(r_FMemberAccessMask == null)
				{
					r_FMemberAccessMask = new(Type, "MemberAccessMask");
				}
				return r_FMemberAccessMask;
			}
		}

		/// <summary>
		/// System.Reflection.MethodAttributes PrivateScope
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FPrivateScope;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFPrivateScope
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
		/// System.Reflection.MethodAttributes Private
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FPrivate;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFPrivate
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
		/// System.Reflection.MethodAttributes FamANDAssem
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FFamANDAssem;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFFamANDAssem
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
		/// System.Reflection.MethodAttributes Assembly
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FAssembly;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFAssembly
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
		/// System.Reflection.MethodAttributes Family
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FFamily;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFFamily
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
		/// System.Reflection.MethodAttributes FamORAssem
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FFamORAssem;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFFamORAssem
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
		/// System.Reflection.MethodAttributes Public
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FPublic;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFPublic
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
		/// System.Reflection.MethodAttributes Static
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FStatic;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFStatic
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
		/// System.Reflection.MethodAttributes Final
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FFinal;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFFinal
		{
			get
			{
				if(r_FFinal == null)
				{
					r_FFinal = new(Type, "Final");
				}
				return r_FFinal;
			}
		}

		/// <summary>
		/// System.Reflection.MethodAttributes Virtual
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FVirtual;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFVirtual
		{
			get
			{
				if(r_FVirtual == null)
				{
					r_FVirtual = new(Type, "Virtual");
				}
				return r_FVirtual;
			}
		}

		/// <summary>
		/// System.Reflection.MethodAttributes HideBySig
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FHideBySig;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFHideBySig
		{
			get
			{
				if(r_FHideBySig == null)
				{
					r_FHideBySig = new(Type, "HideBySig");
				}
				return r_FHideBySig;
			}
		}

		/// <summary>
		/// System.Reflection.MethodAttributes CheckAccessOnOverride
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FCheckAccessOnOverride;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFCheckAccessOnOverride
		{
			get
			{
				if(r_FCheckAccessOnOverride == null)
				{
					r_FCheckAccessOnOverride = new(Type, "CheckAccessOnOverride");
				}
				return r_FCheckAccessOnOverride;
			}
		}

		/// <summary>
		/// System.Reflection.MethodAttributes VtableLayoutMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FVtableLayoutMask;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFVtableLayoutMask
		{
			get
			{
				if(r_FVtableLayoutMask == null)
				{
					r_FVtableLayoutMask = new(Type, "VtableLayoutMask");
				}
				return r_FVtableLayoutMask;
			}
		}

		/// <summary>
		/// System.Reflection.MethodAttributes ReuseSlot
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FReuseSlot;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFReuseSlot
		{
			get
			{
				if(r_FReuseSlot == null)
				{
					r_FReuseSlot = new(Type, "ReuseSlot");
				}
				return r_FReuseSlot;
			}
		}

		/// <summary>
		/// System.Reflection.MethodAttributes NewSlot
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FNewSlot;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFNewSlot
		{
			get
			{
				if(r_FNewSlot == null)
				{
					r_FNewSlot = new(Type, "NewSlot");
				}
				return r_FNewSlot;
			}
		}

		/// <summary>
		/// System.Reflection.MethodAttributes Abstract
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FAbstract;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFAbstract
		{
			get
			{
				if(r_FAbstract == null)
				{
					r_FAbstract = new(Type, "Abstract");
				}
				return r_FAbstract;
			}
		}

		/// <summary>
		/// System.Reflection.MethodAttributes SpecialName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FSpecialName;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFSpecialName
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
		/// System.Reflection.MethodAttributes PinvokeImpl
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FPinvokeImpl;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFPinvokeImpl
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
		/// System.Reflection.MethodAttributes UnmanagedExport
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FUnmanagedExport;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFUnmanagedExport
		{
			get
			{
				if(r_FUnmanagedExport == null)
				{
					r_FUnmanagedExport = new(Type, "UnmanagedExport");
				}
				return r_FUnmanagedExport;
			}
		}

		/// <summary>
		/// System.Reflection.MethodAttributes RTSpecialName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FRTSpecialName;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFRTSpecialName
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
		/// System.Reflection.MethodAttributes HasSecurity
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FHasSecurity;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFHasSecurity
		{
			get
			{
				if(r_FHasSecurity == null)
				{
					r_FHasSecurity = new(Type, "HasSecurity");
				}
				return r_FHasSecurity;
			}
		}

		/// <summary>
		/// System.Reflection.MethodAttributes RequireSecObject
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FRequireSecObject;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFRequireSecObject
		{
			get
			{
				if(r_FRequireSecObject == null)
				{
					r_FRequireSecObject = new(Type, "RequireSecObject");
				}
				return r_FRequireSecObject;
			}
		}

		/// <summary>
		/// System.Reflection.MethodAttributes ReservedMask
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes r_FReservedMask;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RMethodAttributes RFReservedMask
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
