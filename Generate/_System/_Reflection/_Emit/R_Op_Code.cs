
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Reflection.Emit.OpCode
	/// </summary>
    public partial class ROpCode : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Reflection.Emit.OpCode);
            }
        }

        public ROpCode() : base("System.Reflection.Emit.OpCode")
        {
        }

        public ROpCode(System.Object instance) : base("System.Reflection.Emit.OpCode")
		{
            SetInstance(instance);
		}

        public ROpCode(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public ROpCode(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Byte op1
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_Fop1;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RFop1
		{
			get
			{
				if(r_Fop1 == null)
				{
					r_Fop1 = new(this, "op1");
				}
				return r_Fop1;
			}
		}

		/// <summary>
		/// System.Byte op2
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_Fop2;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RFop2
		{
			get
			{
				if(r_Fop2 == null)
				{
					r_Fop2 = new(this, "op2");
				}
				return r_Fop2;
			}
		}

		/// <summary>
		/// System.Byte push
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_Fpush;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RFpush
		{
			get
			{
				if(r_Fpush == null)
				{
					r_Fpush = new(this, "push");
				}
				return r_Fpush;
			}
		}

		/// <summary>
		/// System.Byte pop
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_Fpop;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RFpop
		{
			get
			{
				if(r_Fpop == null)
				{
					r_Fpop = new(this, "pop");
				}
				return r_Fpop;
			}
		}

		/// <summary>
		/// System.Byte size
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_Fsize;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RFsize
		{
			get
			{
				if(r_Fsize == null)
				{
					r_Fsize = new(this, "size");
				}
				return r_Fsize;
			}
		}

		/// <summary>
		/// System.Byte type
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_Ftype;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RFtype
		{
			get
			{
				if(r_Ftype == null)
				{
					r_Ftype = new(this, "type");
				}
				return r_Ftype;
			}
		}

		/// <summary>
		/// System.Byte args
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_Fargs;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RFargs
		{
			get
			{
				if(r_Fargs == null)
				{
					r_Fargs = new(this, "args");
				}
				return r_Fargs;
			}
		}

		/// <summary>
		/// System.Byte flow
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RByte r_Fflow;
		public virtual Hvak.Editor.Refleaction.RSystem.RByte RFflow
		{
			get
			{
				if(r_Fflow == null)
				{
					r_Fflow = new(this, "flow");
				}
				return r_Fflow;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// Int32 Size
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPSize
		{
			get
			{
				if(r_PSize == null)
				{
					r_PSize = new(this, "Size", -1);
				}
				return r_PSize;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.OpCodeType OpCodeType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROpCodeType r_POpCodeType;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROpCodeType RPOpCodeType
		{
			get
			{
				if(r_POpCodeType == null)
				{
					r_POpCodeType = new(this, "OpCodeType", -1);
				}
				return r_POpCodeType;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.OperandType OperandType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType r_POperandType;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.REmit.ROperandType RPOperandType
		{
			get
			{
				if(r_POperandType == null)
				{
					r_POperandType = new(this, "OperandType", -1);
				}
				return r_POperandType;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FlowControl FlowControl
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFlowControl r_PFlowControl;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RFlowControl RPFlowControl
		{
			get
			{
				if(r_PFlowControl == null)
				{
					r_PFlowControl = new(this, "FlowControl", -1);
				}
				return r_PFlowControl;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.StackBehaviour StackBehaviourPop
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RStackBehaviour r_PStackBehaviourPop;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RStackBehaviour RPStackBehaviourPop
		{
			get
			{
				if(r_PStackBehaviourPop == null)
				{
					r_PStackBehaviourPop = new(this, "StackBehaviourPop", -1);
				}
				return r_PStackBehaviourPop;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.StackBehaviour StackBehaviourPush
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RStackBehaviour r_PStackBehaviourPush;
		public virtual Hvak.Editor.Refleaction.RSystem.RReflection.REmit.RStackBehaviour RPStackBehaviourPush
		{
			get
			{
				if(r_PStackBehaviourPush == null)
				{
					r_PStackBehaviourPush = new(this, "StackBehaviourPush", -1);
				}
				return r_PStackBehaviourPush;
			}
		}

		/// <summary>
		/// Int16 Value
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt16 r_PValue;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt16 RPValue
		{
			get
			{
				if(r_PValue == null)
				{
					r_PValue = new(this, "Value", -1);
				}
				return r_PValue;
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
		/// Boolean Equals(System.Reflection.Emit.OpCode)
		/// </summary>
		protected RMethod r_MEquals_OpCode;
		public virtual RMethod RMEquals_OpCode
		{
			get
			{
				if(r_MEquals_OpCode == null)
				{
					r_MEquals_OpCode = new(this, "Equals", 0, typeof(System.Reflection.Emit.OpCode));
				}
				return r_MEquals_OpCode;
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
		/// Boolean op_Equality(System.Reflection.Emit.OpCode, System.Reflection.Emit.OpCode)
		/// </summary>
		protected static RMethod r_Mop_Equality_OpCode_OpCode;
		public static RMethod RMop_Equality_OpCode_OpCode
		{
			get
			{
				if(r_Mop_Equality_OpCode_OpCode == null)
				{
					r_Mop_Equality_OpCode_OpCode = new(Type, "op_Equality", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.Emit.OpCode));
				}
				return r_Mop_Equality_OpCode_OpCode;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.Emit.OpCode, System.Reflection.Emit.OpCode)
		/// </summary>
		protected static RMethod r_Mop_Inequality_OpCode_OpCode;
		public static RMethod RMop_Inequality_OpCode_OpCode
		{
			get
			{
				if(r_Mop_Inequality_OpCode_OpCode == null)
				{
					r_Mop_Inequality_OpCode_OpCode = new(Type, "op_Inequality", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.Emit.OpCode));
				}
				return r_Mop_Inequality_OpCode_OpCode;
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


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Reflection.Emit.OpCode @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_OpCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public static System.Boolean op_Equality(System.Reflection.Emit.OpCode @a, System.Reflection.Emit.OpCode @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Equality_OpCode_OpCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(System.Reflection.Emit.OpCode @a, System.Reflection.Emit.OpCode @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Inequality_OpCode_OpCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
