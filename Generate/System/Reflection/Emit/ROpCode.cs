using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.OpCode
	/// </summary>
    public partial class ROpCode : RMember //
    {

		/// <summary>
		/// System.Byte op1
		/// </summary>
		protected RField r_op1;
		public virtual RField Rop1
		{
			get
			{
				if(r_op1 == null)
				{
					r_op1 = new(this, "op1");
					r_op1.SetBelong(this.instance);
				}
				return r_op1;
			}
		}

		/// <summary>
		/// System.Byte op2
		/// </summary>
		protected RField r_op2;
		public virtual RField Rop2
		{
			get
			{
				if(r_op2 == null)
				{
					r_op2 = new(this, "op2");
					r_op2.SetBelong(this.instance);
				}
				return r_op2;
			}
		}

		/// <summary>
		/// System.Byte push
		/// </summary>
		protected RField r_push;
		public virtual RField Rpush
		{
			get
			{
				if(r_push == null)
				{
					r_push = new(this, "push");
					r_push.SetBelong(this.instance);
				}
				return r_push;
			}
		}

		/// <summary>
		/// System.Byte pop
		/// </summary>
		protected RField r_pop;
		public virtual RField Rpop
		{
			get
			{
				if(r_pop == null)
				{
					r_pop = new(this, "pop");
					r_pop.SetBelong(this.instance);
				}
				return r_pop;
			}
		}

		/// <summary>
		/// System.Byte size
		/// </summary>
		protected RField r_size;
		public virtual RField Rsize
		{
			get
			{
				if(r_size == null)
				{
					r_size = new(this, "size");
					r_size.SetBelong(this.instance);
				}
				return r_size;
			}
		}

		/// <summary>
		/// System.Byte type
		/// </summary>
		protected RField r_type;
		public virtual RField Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type");
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// System.Byte args
		/// </summary>
		protected RField r_args;
		public virtual RField Rargs
		{
			get
			{
				if(r_args == null)
				{
					r_args = new(this, "args");
					r_args.SetBelong(this.instance);
				}
				return r_args;
			}
		}

		/// <summary>
		/// System.Byte flow
		/// </summary>
		protected RField r_flow;
		public virtual RField Rflow
		{
			get
			{
				if(r_flow == null)
				{
					r_flow = new(this, "flow");
					r_flow.SetBelong(this.instance);
				}
				return r_flow;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
			}
		}

		/// <summary>
		/// Int32 Size
		/// </summary>
		protected RProperty r_Size;
		public virtual RProperty RSize
		{
			get
			{
				if(r_Size == null)
				{
					r_Size = new(this, "Size", -1);
					r_Size.SetBelong(this.instance);
				}
				return r_Size;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.OpCodeType OpCodeType
		/// </summary>
		protected RProperty r_OpCodeType;
		public virtual RProperty ROpCodeType
		{
			get
			{
				if(r_OpCodeType == null)
				{
					r_OpCodeType = new(this, "OpCodeType", -1);
					r_OpCodeType.SetBelong(this.instance);
				}
				return r_OpCodeType;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.OperandType OperandType
		/// </summary>
		protected RProperty r_OperandType;
		public virtual RProperty ROperandType
		{
			get
			{
				if(r_OperandType == null)
				{
					r_OperandType = new(this, "OperandType", -1);
					r_OperandType.SetBelong(this.instance);
				}
				return r_OperandType;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.FlowControl FlowControl
		/// </summary>
		protected RProperty r_FlowControl;
		public virtual RProperty RFlowControl
		{
			get
			{
				if(r_FlowControl == null)
				{
					r_FlowControl = new(this, "FlowControl", -1);
					r_FlowControl.SetBelong(this.instance);
				}
				return r_FlowControl;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.StackBehaviour StackBehaviourPop
		/// </summary>
		protected RProperty r_StackBehaviourPop;
		public virtual RProperty RStackBehaviourPop
		{
			get
			{
				if(r_StackBehaviourPop == null)
				{
					r_StackBehaviourPop = new(this, "StackBehaviourPop", -1);
					r_StackBehaviourPop.SetBelong(this.instance);
				}
				return r_StackBehaviourPop;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.StackBehaviour StackBehaviourPush
		/// </summary>
		protected RProperty r_StackBehaviourPush;
		public virtual RProperty RStackBehaviourPush
		{
			get
			{
				if(r_StackBehaviourPush == null)
				{
					r_StackBehaviourPush = new(this, "StackBehaviourPush", -1);
					r_StackBehaviourPush.SetBelong(this.instance);
				}
				return r_StackBehaviourPush;
			}
		}

		/// <summary>
		/// Int16 Value
		/// </summary>
		protected RProperty r_Value;
		public virtual RProperty RValue
		{
			get
			{
				if(r_Value == null)
				{
					r_Value = new(this, "Value", -1);
					r_Value.SetBelong(this.instance);
				}
				return r_Value;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Reflection.Emit.OpCode)
		/// </summary>
		protected RMethod r_REquals_OpCode;
		public virtual RMethod REquals_OpCode
		{
			get
			{
				if(r_REquals_OpCode == null)
				{
					r_REquals_OpCode = new(this, "Equals", 0, typeof(System.Reflection.Emit.OpCode));
					r_REquals_OpCode.SetBelong(this.instance);
				}
				return r_REquals_OpCode;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Reflection.Emit.OpCode, System.Reflection.Emit.OpCode)
		/// </summary>
		protected static RMethod r_Rop_Equality_OpCode_OpCode;
		public static RMethod Rop_Equality_OpCode_OpCode
		{
			get
			{
				if(r_Rop_Equality_OpCode_OpCode == null)
				{
					r_Rop_Equality_OpCode_OpCode = new(typeof(System.Reflection.Emit.OpCode), "op_Equality", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.Emit.OpCode));
					r_Rop_Equality_OpCode_OpCode.SetBelong(null);
				}
				return r_Rop_Equality_OpCode_OpCode;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Reflection.Emit.OpCode, System.Reflection.Emit.OpCode)
		/// </summary>
		protected static RMethod r_Rop_Inequality_OpCode_OpCode;
		public static RMethod Rop_Inequality_OpCode_OpCode
		{
			get
			{
				if(r_Rop_Inequality_OpCode_OpCode == null)
				{
					r_Rop_Inequality_OpCode_OpCode = new(typeof(System.Reflection.Emit.OpCode), "op_Inequality", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.Emit.OpCode));
					r_Rop_Inequality_OpCode_OpCode.SetBelong(null);
				}
				return r_Rop_Inequality_OpCode_OpCode;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
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

        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Reflection.Emit.OpCode  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_OpCode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Boolean op_Equality(System.Reflection.Emit.OpCode  @a, System.Reflection.Emit.OpCode  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Equality_OpCode_OpCode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Reflection.Emit.OpCode  @a, System.Reflection.Emit.OpCode  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Inequality_OpCode_OpCode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
