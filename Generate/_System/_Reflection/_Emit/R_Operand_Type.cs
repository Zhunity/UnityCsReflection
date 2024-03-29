
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Reflection.Emit.OperandType
	/// </summary>
    public partial class ROperandType : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Reflection.Emit.OperandType);
            }
        }

        public ROperandType() : base("System.Reflection.Emit.OperandType")
        {
        }

        public ROperandType(System.Object instance) : base("System.Reflection.Emit.OperandType")
		{
            SetInstance(instance);
		}

        public ROperandType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public ROperandType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// System.Reflection.Emit.OperandType InlineBrTarget
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType r_FInlineBrTarget;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType RFInlineBrTarget
		{
			get
			{
				if(r_FInlineBrTarget == null)
				{
					r_FInlineBrTarget = new(Type, "InlineBrTarget");
				}
				return r_FInlineBrTarget;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.OperandType InlineField
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType r_FInlineField;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType RFInlineField
		{
			get
			{
				if(r_FInlineField == null)
				{
					r_FInlineField = new(Type, "InlineField");
				}
				return r_FInlineField;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.OperandType InlineI
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType r_FInlineI;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType RFInlineI
		{
			get
			{
				if(r_FInlineI == null)
				{
					r_FInlineI = new(Type, "InlineI");
				}
				return r_FInlineI;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.OperandType InlineI8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType r_FInlineI8;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType RFInlineI8
		{
			get
			{
				if(r_FInlineI8 == null)
				{
					r_FInlineI8 = new(Type, "InlineI8");
				}
				return r_FInlineI8;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.OperandType InlineMethod
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType r_FInlineMethod;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType RFInlineMethod
		{
			get
			{
				if(r_FInlineMethod == null)
				{
					r_FInlineMethod = new(Type, "InlineMethod");
				}
				return r_FInlineMethod;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.OperandType InlineNone
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType r_FInlineNone;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType RFInlineNone
		{
			get
			{
				if(r_FInlineNone == null)
				{
					r_FInlineNone = new(Type, "InlineNone");
				}
				return r_FInlineNone;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.OperandType InlinePhi
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType r_FInlinePhi;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType RFInlinePhi
		{
			get
			{
				if(r_FInlinePhi == null)
				{
					r_FInlinePhi = new(Type, "InlinePhi");
				}
				return r_FInlinePhi;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.OperandType InlineR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType r_FInlineR;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType RFInlineR
		{
			get
			{
				if(r_FInlineR == null)
				{
					r_FInlineR = new(Type, "InlineR");
				}
				return r_FInlineR;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.OperandType InlineSig
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType r_FInlineSig;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType RFInlineSig
		{
			get
			{
				if(r_FInlineSig == null)
				{
					r_FInlineSig = new(Type, "InlineSig");
				}
				return r_FInlineSig;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.OperandType InlineString
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType r_FInlineString;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType RFInlineString
		{
			get
			{
				if(r_FInlineString == null)
				{
					r_FInlineString = new(Type, "InlineString");
				}
				return r_FInlineString;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.OperandType InlineSwitch
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType r_FInlineSwitch;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType RFInlineSwitch
		{
			get
			{
				if(r_FInlineSwitch == null)
				{
					r_FInlineSwitch = new(Type, "InlineSwitch");
				}
				return r_FInlineSwitch;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.OperandType InlineTok
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType r_FInlineTok;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType RFInlineTok
		{
			get
			{
				if(r_FInlineTok == null)
				{
					r_FInlineTok = new(Type, "InlineTok");
				}
				return r_FInlineTok;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.OperandType InlineType
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType r_FInlineType;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType RFInlineType
		{
			get
			{
				if(r_FInlineType == null)
				{
					r_FInlineType = new(Type, "InlineType");
				}
				return r_FInlineType;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.OperandType InlineVar
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType r_FInlineVar;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType RFInlineVar
		{
			get
			{
				if(r_FInlineVar == null)
				{
					r_FInlineVar = new(Type, "InlineVar");
				}
				return r_FInlineVar;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.OperandType ShortInlineBrTarget
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType r_FShortInlineBrTarget;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType RFShortInlineBrTarget
		{
			get
			{
				if(r_FShortInlineBrTarget == null)
				{
					r_FShortInlineBrTarget = new(Type, "ShortInlineBrTarget");
				}
				return r_FShortInlineBrTarget;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.OperandType ShortInlineI
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType r_FShortInlineI;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType RFShortInlineI
		{
			get
			{
				if(r_FShortInlineI == null)
				{
					r_FShortInlineI = new(Type, "ShortInlineI");
				}
				return r_FShortInlineI;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.OperandType ShortInlineR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType r_FShortInlineR;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType RFShortInlineR
		{
			get
			{
				if(r_FShortInlineR == null)
				{
					r_FShortInlineR = new(Type, "ShortInlineR");
				}
				return r_FShortInlineR;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.OperandType ShortInlineVar
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType r_FShortInlineVar;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType RFShortInlineVar
		{
			get
			{
				if(r_FShortInlineVar == null)
				{
					r_FShortInlineVar = new(Type, "ShortInlineVar");
				}
				return r_FShortInlineVar;
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
