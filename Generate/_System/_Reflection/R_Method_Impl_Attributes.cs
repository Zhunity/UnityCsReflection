
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.MethodImplAttributes
	/// </summary>
    public partial class RMethodImplAttributes : RMember //
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
		/// System.Reflection.MethodImplAttributes CodeTypeMask
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes r_FCodeTypeMask;
		public static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes RFCodeTypeMask
		{
			get
			{
				if(r_FCodeTypeMask == null)
				{
					r_FCodeTypeMask = new(typeof(System.Reflection.MethodImplAttributes), "CodeTypeMask");
					r_FCodeTypeMask.SetBelong(null);
				}
				return r_FCodeTypeMask;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes IL
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes r_FIL;
		public static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes RFIL
		{
			get
			{
				if(r_FIL == null)
				{
					r_FIL = new(typeof(System.Reflection.MethodImplAttributes), "IL");
					r_FIL.SetBelong(null);
				}
				return r_FIL;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes Native
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes r_FNative;
		public static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes RFNative
		{
			get
			{
				if(r_FNative == null)
				{
					r_FNative = new(typeof(System.Reflection.MethodImplAttributes), "Native");
					r_FNative.SetBelong(null);
				}
				return r_FNative;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes OPTIL
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes r_FOPTIL;
		public static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes RFOPTIL
		{
			get
			{
				if(r_FOPTIL == null)
				{
					r_FOPTIL = new(typeof(System.Reflection.MethodImplAttributes), "OPTIL");
					r_FOPTIL.SetBelong(null);
				}
				return r_FOPTIL;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes Runtime
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes r_FRuntime;
		public static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes RFRuntime
		{
			get
			{
				if(r_FRuntime == null)
				{
					r_FRuntime = new(typeof(System.Reflection.MethodImplAttributes), "Runtime");
					r_FRuntime.SetBelong(null);
				}
				return r_FRuntime;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes ManagedMask
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes r_FManagedMask;
		public static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes RFManagedMask
		{
			get
			{
				if(r_FManagedMask == null)
				{
					r_FManagedMask = new(typeof(System.Reflection.MethodImplAttributes), "ManagedMask");
					r_FManagedMask.SetBelong(null);
				}
				return r_FManagedMask;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes Unmanaged
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes r_FUnmanaged;
		public static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes RFUnmanaged
		{
			get
			{
				if(r_FUnmanaged == null)
				{
					r_FUnmanaged = new(typeof(System.Reflection.MethodImplAttributes), "Unmanaged");
					r_FUnmanaged.SetBelong(null);
				}
				return r_FUnmanaged;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes Managed
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes r_FManaged;
		public static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes RFManaged
		{
			get
			{
				if(r_FManaged == null)
				{
					r_FManaged = new(typeof(System.Reflection.MethodImplAttributes), "Managed");
					r_FManaged.SetBelong(null);
				}
				return r_FManaged;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes ForwardRef
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes r_FForwardRef;
		public static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes RFForwardRef
		{
			get
			{
				if(r_FForwardRef == null)
				{
					r_FForwardRef = new(typeof(System.Reflection.MethodImplAttributes), "ForwardRef");
					r_FForwardRef.SetBelong(null);
				}
				return r_FForwardRef;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes PreserveSig
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes r_FPreserveSig;
		public static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes RFPreserveSig
		{
			get
			{
				if(r_FPreserveSig == null)
				{
					r_FPreserveSig = new(typeof(System.Reflection.MethodImplAttributes), "PreserveSig");
					r_FPreserveSig.SetBelong(null);
				}
				return r_FPreserveSig;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes InternalCall
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes r_FInternalCall;
		public static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes RFInternalCall
		{
			get
			{
				if(r_FInternalCall == null)
				{
					r_FInternalCall = new(typeof(System.Reflection.MethodImplAttributes), "InternalCall");
					r_FInternalCall.SetBelong(null);
				}
				return r_FInternalCall;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes Synchronized
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes r_FSynchronized;
		public static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes RFSynchronized
		{
			get
			{
				if(r_FSynchronized == null)
				{
					r_FSynchronized = new(typeof(System.Reflection.MethodImplAttributes), "Synchronized");
					r_FSynchronized.SetBelong(null);
				}
				return r_FSynchronized;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes NoInlining
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes r_FNoInlining;
		public static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes RFNoInlining
		{
			get
			{
				if(r_FNoInlining == null)
				{
					r_FNoInlining = new(typeof(System.Reflection.MethodImplAttributes), "NoInlining");
					r_FNoInlining.SetBelong(null);
				}
				return r_FNoInlining;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes AggressiveInlining
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes r_FAggressiveInlining;
		public static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes RFAggressiveInlining
		{
			get
			{
				if(r_FAggressiveInlining == null)
				{
					r_FAggressiveInlining = new(typeof(System.Reflection.MethodImplAttributes), "AggressiveInlining");
					r_FAggressiveInlining.SetBelong(null);
				}
				return r_FAggressiveInlining;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes NoOptimization
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes r_FNoOptimization;
		public static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes RFNoOptimization
		{
			get
			{
				if(r_FNoOptimization == null)
				{
					r_FNoOptimization = new(typeof(System.Reflection.MethodImplAttributes), "NoOptimization");
					r_FNoOptimization.SetBelong(null);
				}
				return r_FNoOptimization;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes MaxMethodImplVal
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes r_FMaxMethodImplVal;
		public static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes RFMaxMethodImplVal
		{
			get
			{
				if(r_FMaxMethodImplVal == null)
				{
					r_FMaxMethodImplVal = new(typeof(System.Reflection.MethodImplAttributes), "MaxMethodImplVal");
					r_FMaxMethodImplVal.SetBelong(null);
				}
				return r_FMaxMethodImplVal;
			}
		}

		/// <summary>
		/// System.Reflection.MethodImplAttributes SecurityMitigations
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes r_FSecurityMitigations;
		public static SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodImplAttributes RFSecurityMitigations
		{
			get
			{
				if(r_FSecurityMitigations == null)
				{
					r_FSecurityMitigations = new(typeof(System.Reflection.MethodImplAttributes), "SecurityMitigations");
					r_FSecurityMitigations.SetBelong(null);
				}
				return r_FSecurityMitigations;
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


        public RMethodImplAttributes() : base("System.Reflection.MethodImplAttributes")
        {
        }

        public RMethodImplAttributes(System.Object instance) : base("System.Reflection.MethodImplAttributes")
		{
            SetInstance(instance);
		}

        public RMethodImplAttributes(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMethodImplAttributes(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
