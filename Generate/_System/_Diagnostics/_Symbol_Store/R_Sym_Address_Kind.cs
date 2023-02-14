
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore
{
	/// <summary>
	/// System.Diagnostics.SymbolStore.SymAddressKind
	/// </summary>
    public partial class RSymAddressKind : RMember //
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
		/// System.Diagnostics.SymbolStore.SymAddressKind ILOffset
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RSymAddressKind r_FILOffset;
		public static Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RSymAddressKind RFILOffset
		{
			get
			{
				if(r_FILOffset == null)
				{
					r_FILOffset = new(typeof(System.Diagnostics.SymbolStore.SymAddressKind), "ILOffset");
					r_FILOffset.SetBelong(null);
				}
				return r_FILOffset;
			}
		}

		/// <summary>
		/// System.Diagnostics.SymbolStore.SymAddressKind NativeRVA
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RSymAddressKind r_FNativeRVA;
		public static Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RSymAddressKind RFNativeRVA
		{
			get
			{
				if(r_FNativeRVA == null)
				{
					r_FNativeRVA = new(typeof(System.Diagnostics.SymbolStore.SymAddressKind), "NativeRVA");
					r_FNativeRVA.SetBelong(null);
				}
				return r_FNativeRVA;
			}
		}

		/// <summary>
		/// System.Diagnostics.SymbolStore.SymAddressKind NativeRegister
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RSymAddressKind r_FNativeRegister;
		public static Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RSymAddressKind RFNativeRegister
		{
			get
			{
				if(r_FNativeRegister == null)
				{
					r_FNativeRegister = new(typeof(System.Diagnostics.SymbolStore.SymAddressKind), "NativeRegister");
					r_FNativeRegister.SetBelong(null);
				}
				return r_FNativeRegister;
			}
		}

		/// <summary>
		/// System.Diagnostics.SymbolStore.SymAddressKind NativeRegisterRelative
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RSymAddressKind r_FNativeRegisterRelative;
		public static Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RSymAddressKind RFNativeRegisterRelative
		{
			get
			{
				if(r_FNativeRegisterRelative == null)
				{
					r_FNativeRegisterRelative = new(typeof(System.Diagnostics.SymbolStore.SymAddressKind), "NativeRegisterRelative");
					r_FNativeRegisterRelative.SetBelong(null);
				}
				return r_FNativeRegisterRelative;
			}
		}

		/// <summary>
		/// System.Diagnostics.SymbolStore.SymAddressKind NativeOffset
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RSymAddressKind r_FNativeOffset;
		public static Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RSymAddressKind RFNativeOffset
		{
			get
			{
				if(r_FNativeOffset == null)
				{
					r_FNativeOffset = new(typeof(System.Diagnostics.SymbolStore.SymAddressKind), "NativeOffset");
					r_FNativeOffset.SetBelong(null);
				}
				return r_FNativeOffset;
			}
		}

		/// <summary>
		/// System.Diagnostics.SymbolStore.SymAddressKind NativeRegisterRegister
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RSymAddressKind r_FNativeRegisterRegister;
		public static Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RSymAddressKind RFNativeRegisterRegister
		{
			get
			{
				if(r_FNativeRegisterRegister == null)
				{
					r_FNativeRegisterRegister = new(typeof(System.Diagnostics.SymbolStore.SymAddressKind), "NativeRegisterRegister");
					r_FNativeRegisterRegister.SetBelong(null);
				}
				return r_FNativeRegisterRegister;
			}
		}

		/// <summary>
		/// System.Diagnostics.SymbolStore.SymAddressKind NativeRegisterStack
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RSymAddressKind r_FNativeRegisterStack;
		public static Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RSymAddressKind RFNativeRegisterStack
		{
			get
			{
				if(r_FNativeRegisterStack == null)
				{
					r_FNativeRegisterStack = new(typeof(System.Diagnostics.SymbolStore.SymAddressKind), "NativeRegisterStack");
					r_FNativeRegisterStack.SetBelong(null);
				}
				return r_FNativeRegisterStack;
			}
		}

		/// <summary>
		/// System.Diagnostics.SymbolStore.SymAddressKind NativeStackRegister
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RSymAddressKind r_FNativeStackRegister;
		public static Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RSymAddressKind RFNativeStackRegister
		{
			get
			{
				if(r_FNativeStackRegister == null)
				{
					r_FNativeStackRegister = new(typeof(System.Diagnostics.SymbolStore.SymAddressKind), "NativeStackRegister");
					r_FNativeStackRegister.SetBelong(null);
				}
				return r_FNativeStackRegister;
			}
		}

		/// <summary>
		/// System.Diagnostics.SymbolStore.SymAddressKind BitField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RSymAddressKind r_FBitField;
		public static Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RSymAddressKind RFBitField
		{
			get
			{
				if(r_FBitField == null)
				{
					r_FBitField = new(typeof(System.Diagnostics.SymbolStore.SymAddressKind), "BitField");
					r_FBitField.SetBelong(null);
				}
				return r_FBitField;
			}
		}

		/// <summary>
		/// System.Diagnostics.SymbolStore.SymAddressKind NativeSectionOffset
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RSymAddressKind r_FNativeSectionOffset;
		public static Hvak.Editor.Refleaction.RSystem.RDiagnostics.RSymbolStore.RSymAddressKind RFNativeSectionOffset
		{
			get
			{
				if(r_FNativeSectionOffset == null)
				{
					r_FNativeSectionOffset = new(typeof(System.Diagnostics.SymbolStore.SymAddressKind), "NativeSectionOffset");
					r_FNativeSectionOffset.SetBelong(null);
				}
				return r_FNativeSectionOffset;
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


        public RSymAddressKind() : base("System.Diagnostics.SymbolStore.SymAddressKind")
        {
        }

        public RSymAddressKind(System.Object instance) : base("System.Diagnostics.SymbolStore.SymAddressKind")
		{
            SetInstance(instance);
		}

        public RSymAddressKind(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSymAddressKind(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
