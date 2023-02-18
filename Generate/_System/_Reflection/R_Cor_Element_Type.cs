
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection
{
	/// <summary>
	/// System.Reflection.CorElementType
	/// </summary>
    public partial class RCorElementType : RMember //
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
		/// System.Reflection.CorElementType End
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FEnd;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFEnd
		{
			get
			{
				if(r_FEnd == null)
				{
					r_FEnd = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "End");
					r_FEnd.SetBelong(null);
				}
				return r_FEnd;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType Void
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FVoid;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFVoid
		{
			get
			{
				if(r_FVoid == null)
				{
					r_FVoid = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "Void");
					r_FVoid.SetBelong(null);
				}
				return r_FVoid;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType Boolean
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FBoolean;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFBoolean
		{
			get
			{
				if(r_FBoolean == null)
				{
					r_FBoolean = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "Boolean");
					r_FBoolean.SetBelong(null);
				}
				return r_FBoolean;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType Char
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FChar;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFChar
		{
			get
			{
				if(r_FChar == null)
				{
					r_FChar = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "Char");
					r_FChar.SetBelong(null);
				}
				return r_FChar;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType I1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FI1;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFI1
		{
			get
			{
				if(r_FI1 == null)
				{
					r_FI1 = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "I1");
					r_FI1.SetBelong(null);
				}
				return r_FI1;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType U1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FU1;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFU1
		{
			get
			{
				if(r_FU1 == null)
				{
					r_FU1 = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "U1");
					r_FU1.SetBelong(null);
				}
				return r_FU1;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType I2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FI2;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFI2
		{
			get
			{
				if(r_FI2 == null)
				{
					r_FI2 = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "I2");
					r_FI2.SetBelong(null);
				}
				return r_FI2;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType U2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FU2;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFU2
		{
			get
			{
				if(r_FU2 == null)
				{
					r_FU2 = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "U2");
					r_FU2.SetBelong(null);
				}
				return r_FU2;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType I4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FI4;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFI4
		{
			get
			{
				if(r_FI4 == null)
				{
					r_FI4 = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "I4");
					r_FI4.SetBelong(null);
				}
				return r_FI4;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType U4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FU4;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFU4
		{
			get
			{
				if(r_FU4 == null)
				{
					r_FU4 = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "U4");
					r_FU4.SetBelong(null);
				}
				return r_FU4;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType I8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FI8;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFI8
		{
			get
			{
				if(r_FI8 == null)
				{
					r_FI8 = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "I8");
					r_FI8.SetBelong(null);
				}
				return r_FI8;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType U8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FU8;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFU8
		{
			get
			{
				if(r_FU8 == null)
				{
					r_FU8 = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "U8");
					r_FU8.SetBelong(null);
				}
				return r_FU8;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType R4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FR4;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFR4
		{
			get
			{
				if(r_FR4 == null)
				{
					r_FR4 = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "R4");
					r_FR4.SetBelong(null);
				}
				return r_FR4;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType R8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FR8;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFR8
		{
			get
			{
				if(r_FR8 == null)
				{
					r_FR8 = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "R8");
					r_FR8.SetBelong(null);
				}
				return r_FR8;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType String
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FString;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFString
		{
			get
			{
				if(r_FString == null)
				{
					r_FString = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "String");
					r_FString.SetBelong(null);
				}
				return r_FString;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType Ptr
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FPtr;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFPtr
		{
			get
			{
				if(r_FPtr == null)
				{
					r_FPtr = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "Ptr");
					r_FPtr.SetBelong(null);
				}
				return r_FPtr;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ByRef
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FByRef;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFByRef
		{
			get
			{
				if(r_FByRef == null)
				{
					r_FByRef = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ByRef");
					r_FByRef.SetBelong(null);
				}
				return r_FByRef;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ValueType
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FValueType;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFValueType
		{
			get
			{
				if(r_FValueType == null)
				{
					r_FValueType = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ValueType");
					r_FValueType.SetBelong(null);
				}
				return r_FValueType;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType Class
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FClass;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFClass
		{
			get
			{
				if(r_FClass == null)
				{
					r_FClass = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "Class");
					r_FClass.SetBelong(null);
				}
				return r_FClass;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType Var
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FVar;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFVar
		{
			get
			{
				if(r_FVar == null)
				{
					r_FVar = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "Var");
					r_FVar.SetBelong(null);
				}
				return r_FVar;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType Array
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FArray;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFArray
		{
			get
			{
				if(r_FArray == null)
				{
					r_FArray = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "Array");
					r_FArray.SetBelong(null);
				}
				return r_FArray;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType GenericInst
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FGenericInst;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFGenericInst
		{
			get
			{
				if(r_FGenericInst == null)
				{
					r_FGenericInst = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "GenericInst");
					r_FGenericInst.SetBelong(null);
				}
				return r_FGenericInst;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType TypedByRef
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FTypedByRef;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFTypedByRef
		{
			get
			{
				if(r_FTypedByRef == null)
				{
					r_FTypedByRef = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "TypedByRef");
					r_FTypedByRef.SetBelong(null);
				}
				return r_FTypedByRef;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType I
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FI;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFI
		{
			get
			{
				if(r_FI == null)
				{
					r_FI = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "I");
					r_FI.SetBelong(null);
				}
				return r_FI;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType U
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FU;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFU
		{
			get
			{
				if(r_FU == null)
				{
					r_FU = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "U");
					r_FU.SetBelong(null);
				}
				return r_FU;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType FnPtr
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FFnPtr;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFFnPtr
		{
			get
			{
				if(r_FFnPtr == null)
				{
					r_FFnPtr = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "FnPtr");
					r_FFnPtr.SetBelong(null);
				}
				return r_FFnPtr;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType Object
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FObject;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFObject
		{
			get
			{
				if(r_FObject == null)
				{
					r_FObject = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "Object");
					r_FObject.SetBelong(null);
				}
				return r_FObject;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType SzArray
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FSzArray;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFSzArray
		{
			get
			{
				if(r_FSzArray == null)
				{
					r_FSzArray = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "SzArray");
					r_FSzArray.SetBelong(null);
				}
				return r_FSzArray;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType MVar
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FMVar;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFMVar
		{
			get
			{
				if(r_FMVar == null)
				{
					r_FMVar = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "MVar");
					r_FMVar.SetBelong(null);
				}
				return r_FMVar;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType CModReqd
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FCModReqd;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFCModReqd
		{
			get
			{
				if(r_FCModReqd == null)
				{
					r_FCModReqd = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "CModReqd");
					r_FCModReqd.SetBelong(null);
				}
				return r_FCModReqd;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType CModOpt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FCModOpt;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFCModOpt
		{
			get
			{
				if(r_FCModOpt == null)
				{
					r_FCModOpt = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "CModOpt");
					r_FCModOpt.SetBelong(null);
				}
				return r_FCModOpt;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType Internal
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FInternal;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFInternal
		{
			get
			{
				if(r_FInternal == null)
				{
					r_FInternal = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "Internal");
					r_FInternal.SetBelong(null);
				}
				return r_FInternal;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType Max
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FMax;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFMax
		{
			get
			{
				if(r_FMax == null)
				{
					r_FMax = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "Max");
					r_FMax.SetBelong(null);
				}
				return r_FMax;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType Modifier
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FModifier;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFModifier
		{
			get
			{
				if(r_FModifier == null)
				{
					r_FModifier = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "Modifier");
					r_FModifier.SetBelong(null);
				}
				return r_FModifier;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType Sentinel
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FSentinel;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFSentinel
		{
			get
			{
				if(r_FSentinel == null)
				{
					r_FSentinel = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "Sentinel");
					r_FSentinel.SetBelong(null);
				}
				return r_FSentinel;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType Pinned
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FPinned;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFPinned
		{
			get
			{
				if(r_FPinned == null)
				{
					r_FPinned = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "Pinned");
					r_FPinned.SetBelong(null);
				}
				return r_FPinned;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_END
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_END;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_END
		{
			get
			{
				if(r_FELEMENT_TYPE_END == null)
				{
					r_FELEMENT_TYPE_END = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_END");
					r_FELEMENT_TYPE_END.SetBelong(null);
				}
				return r_FELEMENT_TYPE_END;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_VOID
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_VOID;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_VOID
		{
			get
			{
				if(r_FELEMENT_TYPE_VOID == null)
				{
					r_FELEMENT_TYPE_VOID = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_VOID");
					r_FELEMENT_TYPE_VOID.SetBelong(null);
				}
				return r_FELEMENT_TYPE_VOID;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_BOOLEAN
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_BOOLEAN;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_BOOLEAN
		{
			get
			{
				if(r_FELEMENT_TYPE_BOOLEAN == null)
				{
					r_FELEMENT_TYPE_BOOLEAN = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_BOOLEAN");
					r_FELEMENT_TYPE_BOOLEAN.SetBelong(null);
				}
				return r_FELEMENT_TYPE_BOOLEAN;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_CHAR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_CHAR;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_CHAR
		{
			get
			{
				if(r_FELEMENT_TYPE_CHAR == null)
				{
					r_FELEMENT_TYPE_CHAR = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_CHAR");
					r_FELEMENT_TYPE_CHAR.SetBelong(null);
				}
				return r_FELEMENT_TYPE_CHAR;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_I1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_I1;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_I1
		{
			get
			{
				if(r_FELEMENT_TYPE_I1 == null)
				{
					r_FELEMENT_TYPE_I1 = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_I1");
					r_FELEMENT_TYPE_I1.SetBelong(null);
				}
				return r_FELEMENT_TYPE_I1;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_U1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_U1;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_U1
		{
			get
			{
				if(r_FELEMENT_TYPE_U1 == null)
				{
					r_FELEMENT_TYPE_U1 = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_U1");
					r_FELEMENT_TYPE_U1.SetBelong(null);
				}
				return r_FELEMENT_TYPE_U1;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_I2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_I2;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_I2
		{
			get
			{
				if(r_FELEMENT_TYPE_I2 == null)
				{
					r_FELEMENT_TYPE_I2 = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_I2");
					r_FELEMENT_TYPE_I2.SetBelong(null);
				}
				return r_FELEMENT_TYPE_I2;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_U2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_U2;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_U2
		{
			get
			{
				if(r_FELEMENT_TYPE_U2 == null)
				{
					r_FELEMENT_TYPE_U2 = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_U2");
					r_FELEMENT_TYPE_U2.SetBelong(null);
				}
				return r_FELEMENT_TYPE_U2;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_I4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_I4;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_I4
		{
			get
			{
				if(r_FELEMENT_TYPE_I4 == null)
				{
					r_FELEMENT_TYPE_I4 = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_I4");
					r_FELEMENT_TYPE_I4.SetBelong(null);
				}
				return r_FELEMENT_TYPE_I4;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_U4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_U4;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_U4
		{
			get
			{
				if(r_FELEMENT_TYPE_U4 == null)
				{
					r_FELEMENT_TYPE_U4 = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_U4");
					r_FELEMENT_TYPE_U4.SetBelong(null);
				}
				return r_FELEMENT_TYPE_U4;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_I8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_I8;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_I8
		{
			get
			{
				if(r_FELEMENT_TYPE_I8 == null)
				{
					r_FELEMENT_TYPE_I8 = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_I8");
					r_FELEMENT_TYPE_I8.SetBelong(null);
				}
				return r_FELEMENT_TYPE_I8;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_U8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_U8;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_U8
		{
			get
			{
				if(r_FELEMENT_TYPE_U8 == null)
				{
					r_FELEMENT_TYPE_U8 = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_U8");
					r_FELEMENT_TYPE_U8.SetBelong(null);
				}
				return r_FELEMENT_TYPE_U8;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_R4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_R4;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_R4
		{
			get
			{
				if(r_FELEMENT_TYPE_R4 == null)
				{
					r_FELEMENT_TYPE_R4 = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_R4");
					r_FELEMENT_TYPE_R4.SetBelong(null);
				}
				return r_FELEMENT_TYPE_R4;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_R8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_R8;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_R8
		{
			get
			{
				if(r_FELEMENT_TYPE_R8 == null)
				{
					r_FELEMENT_TYPE_R8 = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_R8");
					r_FELEMENT_TYPE_R8.SetBelong(null);
				}
				return r_FELEMENT_TYPE_R8;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_STRING
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_STRING;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_STRING
		{
			get
			{
				if(r_FELEMENT_TYPE_STRING == null)
				{
					r_FELEMENT_TYPE_STRING = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_STRING");
					r_FELEMENT_TYPE_STRING.SetBelong(null);
				}
				return r_FELEMENT_TYPE_STRING;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_PTR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_PTR;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_PTR
		{
			get
			{
				if(r_FELEMENT_TYPE_PTR == null)
				{
					r_FELEMENT_TYPE_PTR = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_PTR");
					r_FELEMENT_TYPE_PTR.SetBelong(null);
				}
				return r_FELEMENT_TYPE_PTR;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_BYREF
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_BYREF;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_BYREF
		{
			get
			{
				if(r_FELEMENT_TYPE_BYREF == null)
				{
					r_FELEMENT_TYPE_BYREF = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_BYREF");
					r_FELEMENT_TYPE_BYREF.SetBelong(null);
				}
				return r_FELEMENT_TYPE_BYREF;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_VALUETYPE
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_VALUETYPE;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_VALUETYPE
		{
			get
			{
				if(r_FELEMENT_TYPE_VALUETYPE == null)
				{
					r_FELEMENT_TYPE_VALUETYPE = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_VALUETYPE");
					r_FELEMENT_TYPE_VALUETYPE.SetBelong(null);
				}
				return r_FELEMENT_TYPE_VALUETYPE;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_CLASS
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_CLASS;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_CLASS
		{
			get
			{
				if(r_FELEMENT_TYPE_CLASS == null)
				{
					r_FELEMENT_TYPE_CLASS = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_CLASS");
					r_FELEMENT_TYPE_CLASS.SetBelong(null);
				}
				return r_FELEMENT_TYPE_CLASS;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_VAR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_VAR;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_VAR
		{
			get
			{
				if(r_FELEMENT_TYPE_VAR == null)
				{
					r_FELEMENT_TYPE_VAR = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_VAR");
					r_FELEMENT_TYPE_VAR.SetBelong(null);
				}
				return r_FELEMENT_TYPE_VAR;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_ARRAY
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_ARRAY;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_ARRAY
		{
			get
			{
				if(r_FELEMENT_TYPE_ARRAY == null)
				{
					r_FELEMENT_TYPE_ARRAY = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_ARRAY");
					r_FELEMENT_TYPE_ARRAY.SetBelong(null);
				}
				return r_FELEMENT_TYPE_ARRAY;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_GENERICINST
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_GENERICINST;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_GENERICINST
		{
			get
			{
				if(r_FELEMENT_TYPE_GENERICINST == null)
				{
					r_FELEMENT_TYPE_GENERICINST = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_GENERICINST");
					r_FELEMENT_TYPE_GENERICINST.SetBelong(null);
				}
				return r_FELEMENT_TYPE_GENERICINST;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_TYPEDBYREF
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_TYPEDBYREF;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_TYPEDBYREF
		{
			get
			{
				if(r_FELEMENT_TYPE_TYPEDBYREF == null)
				{
					r_FELEMENT_TYPE_TYPEDBYREF = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_TYPEDBYREF");
					r_FELEMENT_TYPE_TYPEDBYREF.SetBelong(null);
				}
				return r_FELEMENT_TYPE_TYPEDBYREF;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_I
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_I;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_I
		{
			get
			{
				if(r_FELEMENT_TYPE_I == null)
				{
					r_FELEMENT_TYPE_I = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_I");
					r_FELEMENT_TYPE_I.SetBelong(null);
				}
				return r_FELEMENT_TYPE_I;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_U
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_U;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_U
		{
			get
			{
				if(r_FELEMENT_TYPE_U == null)
				{
					r_FELEMENT_TYPE_U = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_U");
					r_FELEMENT_TYPE_U.SetBelong(null);
				}
				return r_FELEMENT_TYPE_U;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_FNPTR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_FNPTR;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_FNPTR
		{
			get
			{
				if(r_FELEMENT_TYPE_FNPTR == null)
				{
					r_FELEMENT_TYPE_FNPTR = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_FNPTR");
					r_FELEMENT_TYPE_FNPTR.SetBelong(null);
				}
				return r_FELEMENT_TYPE_FNPTR;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_OBJECT
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_OBJECT;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_OBJECT
		{
			get
			{
				if(r_FELEMENT_TYPE_OBJECT == null)
				{
					r_FELEMENT_TYPE_OBJECT = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_OBJECT");
					r_FELEMENT_TYPE_OBJECT.SetBelong(null);
				}
				return r_FELEMENT_TYPE_OBJECT;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_SZARRAY
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_SZARRAY;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_SZARRAY
		{
			get
			{
				if(r_FELEMENT_TYPE_SZARRAY == null)
				{
					r_FELEMENT_TYPE_SZARRAY = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_SZARRAY");
					r_FELEMENT_TYPE_SZARRAY.SetBelong(null);
				}
				return r_FELEMENT_TYPE_SZARRAY;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_MVAR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_MVAR;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_MVAR
		{
			get
			{
				if(r_FELEMENT_TYPE_MVAR == null)
				{
					r_FELEMENT_TYPE_MVAR = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_MVAR");
					r_FELEMENT_TYPE_MVAR.SetBelong(null);
				}
				return r_FELEMENT_TYPE_MVAR;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_CMOD_REQD
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_CMOD_REQD;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_CMOD_REQD
		{
			get
			{
				if(r_FELEMENT_TYPE_CMOD_REQD == null)
				{
					r_FELEMENT_TYPE_CMOD_REQD = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_CMOD_REQD");
					r_FELEMENT_TYPE_CMOD_REQD.SetBelong(null);
				}
				return r_FELEMENT_TYPE_CMOD_REQD;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_CMOD_OPT
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_CMOD_OPT;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_CMOD_OPT
		{
			get
			{
				if(r_FELEMENT_TYPE_CMOD_OPT == null)
				{
					r_FELEMENT_TYPE_CMOD_OPT = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_CMOD_OPT");
					r_FELEMENT_TYPE_CMOD_OPT.SetBelong(null);
				}
				return r_FELEMENT_TYPE_CMOD_OPT;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_INTERNAL
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_INTERNAL;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_INTERNAL
		{
			get
			{
				if(r_FELEMENT_TYPE_INTERNAL == null)
				{
					r_FELEMENT_TYPE_INTERNAL = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_INTERNAL");
					r_FELEMENT_TYPE_INTERNAL.SetBelong(null);
				}
				return r_FELEMENT_TYPE_INTERNAL;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_MAX
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_MAX;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_MAX
		{
			get
			{
				if(r_FELEMENT_TYPE_MAX == null)
				{
					r_FELEMENT_TYPE_MAX = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_MAX");
					r_FELEMENT_TYPE_MAX.SetBelong(null);
				}
				return r_FELEMENT_TYPE_MAX;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_MODIFIER
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_MODIFIER;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_MODIFIER
		{
			get
			{
				if(r_FELEMENT_TYPE_MODIFIER == null)
				{
					r_FELEMENT_TYPE_MODIFIER = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_MODIFIER");
					r_FELEMENT_TYPE_MODIFIER.SetBelong(null);
				}
				return r_FELEMENT_TYPE_MODIFIER;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_SENTINEL
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_SENTINEL;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_SENTINEL
		{
			get
			{
				if(r_FELEMENT_TYPE_SENTINEL == null)
				{
					r_FELEMENT_TYPE_SENTINEL = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_SENTINEL");
					r_FELEMENT_TYPE_SENTINEL.SetBelong(null);
				}
				return r_FELEMENT_TYPE_SENTINEL;
			}
		}

		/// <summary>
		/// System.Reflection.CorElementType ELEMENT_TYPE_PINNED
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType r_FELEMENT_TYPE_PINNED;
		public static Hvak.Editor.Refleaction.RSystem.RReflection.RCorElementType RFELEMENT_TYPE_PINNED
		{
			get
			{
				if(r_FELEMENT_TYPE_PINNED == null)
				{
					r_FELEMENT_TYPE_PINNED = new( ReflectionUtils.GetType("System.Reflection.CorElementType"), "ELEMENT_TYPE_PINNED");
					r_FELEMENT_TYPE_PINNED.SetBelong(null);
				}
				return r_FELEMENT_TYPE_PINNED;
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


        public RCorElementType() : base("System.Reflection.CorElementType")
        {
        }

        public RCorElementType(System.Object instance) : base("System.Reflection.CorElementType")
		{
            SetInstance(instance);
		}

        public RCorElementType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCorElementType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
