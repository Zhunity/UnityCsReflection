using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RReflection.REmit
{
	/// <summary>
	/// System.Reflection.Emit.ILGenerator
	/// </summary>
    public partial class RILGenerator : RMember //
    {

		/// <summary>
		/// System.Byte[] code
		/// </summary>
		protected RFieldArray<RSystem.RByte> r_code;
		public virtual RFieldArray<RSystem.RByte> Rcode
		{
			get
			{
				if(r_code == null)
				{
					r_code = new(this, "code");
					r_code.SetBelong(this.instance);
				}
				return r_code;
			}
		}

		/// <summary>
		/// System.Int32 code_len
		/// </summary>
		protected RSystem.RInt32 r_code_len;
		public virtual RSystem.RInt32 Rcode_len
		{
			get
			{
				if(r_code_len == null)
				{
					r_code_len = new(this, "code_len");
					r_code_len.SetBelong(this.instance);
				}
				return r_code_len;
			}
		}

		/// <summary>
		/// System.Int32 max_stack
		/// </summary>
		protected RSystem.RInt32 r_max_stack;
		public virtual RSystem.RInt32 Rmax_stack
		{
			get
			{
				if(r_max_stack == null)
				{
					r_max_stack = new(this, "max_stack");
					r_max_stack.SetBelong(this.instance);
				}
				return r_max_stack;
			}
		}

		/// <summary>
		/// System.Int32 cur_stack
		/// </summary>
		protected RSystem.RInt32 r_cur_stack;
		public virtual RSystem.RInt32 Rcur_stack
		{
			get
			{
				if(r_cur_stack == null)
				{
					r_cur_stack = new(this, "cur_stack");
					r_cur_stack.SetBelong(this.instance);
				}
				return r_cur_stack;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.LocalBuilder[] locals
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RLocalBuilder> r_locals;
		public virtual RFieldArray<RSystem.RReflection.REmit.RLocalBuilder> Rlocals
		{
			get
			{
				if(r_locals == null)
				{
					r_locals = new(this, "locals");
					r_locals.SetBelong(this.instance);
				}
				return r_locals;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ILExceptionInfo[] ex_handlers
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RILExceptionInfo> r_ex_handlers;
		public virtual RFieldArray<RSystem.RReflection.REmit.RILExceptionInfo> Rex_handlers
		{
			get
			{
				if(r_ex_handlers == null)
				{
					r_ex_handlers = new(this, "ex_handlers");
					r_ex_handlers.SetBelong(this.instance);
				}
				return r_ex_handlers;
			}
		}

		/// <summary>
		/// System.Int32 num_token_fixups
		/// </summary>
		protected RSystem.RInt32 r_num_token_fixups;
		public virtual RSystem.RInt32 Rnum_token_fixups
		{
			get
			{
				if(r_num_token_fixups == null)
				{
					r_num_token_fixups = new(this, "num_token_fixups");
					r_num_token_fixups.SetBelong(this.instance);
				}
				return r_num_token_fixups;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ILTokenInfo[] token_fixups
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RILTokenInfo> r_token_fixups;
		public virtual RFieldArray<RSystem.RReflection.REmit.RILTokenInfo> Rtoken_fixups
		{
			get
			{
				if(r_token_fixups == null)
				{
					r_token_fixups = new(this, "token_fixups");
					r_token_fixups.SetBelong(this.instance);
				}
				return r_token_fixups;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ILGenerator+LabelData[] labels
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RILGenerator.RLabelData> r_labels;
		public virtual RFieldArray<RSystem.RReflection.REmit.RILGenerator.RLabelData> Rlabels
		{
			get
			{
				if(r_labels == null)
				{
					r_labels = new(this, "labels");
					r_labels.SetBelong(this.instance);
				}
				return r_labels;
			}
		}

		/// <summary>
		/// System.Int32 num_labels
		/// </summary>
		protected RSystem.RInt32 r_num_labels;
		public virtual RSystem.RInt32 Rnum_labels
		{
			get
			{
				if(r_num_labels == null)
				{
					r_num_labels = new(this, "num_labels");
					r_num_labels.SetBelong(this.instance);
				}
				return r_num_labels;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ILGenerator+LabelFixup[] fixups
		/// </summary>
		protected RFieldArray<RSystem.RReflection.REmit.RILGenerator.RLabelFixup> r_fixups;
		public virtual RFieldArray<RSystem.RReflection.REmit.RILGenerator.RLabelFixup> Rfixups
		{
			get
			{
				if(r_fixups == null)
				{
					r_fixups = new(this, "fixups");
					r_fixups.SetBelong(this.instance);
				}
				return r_fixups;
			}
		}

		/// <summary>
		/// System.Int32 num_fixups
		/// </summary>
		protected RSystem.RInt32 r_num_fixups;
		public virtual RSystem.RInt32 Rnum_fixups
		{
			get
			{
				if(r_num_fixups == null)
				{
					r_num_fixups = new(this, "num_fixups");
					r_num_fixups.SetBelong(this.instance);
				}
				return r_num_fixups;
			}
		}

		/// <summary>
		/// System.Reflection.Module module
		/// </summary>
		protected RSystem.RReflection.RModule r_module;
		public virtual RSystem.RReflection.RModule Rmodule
		{
			get
			{
				if(r_module == null)
				{
					r_module = new(this, "module");
					r_module.SetBelong(this.instance);
				}
				return r_module;
			}
		}

		/// <summary>
		/// System.Int32 cur_block
		/// </summary>
		protected RSystem.RInt32 r_cur_block;
		public virtual RSystem.RInt32 Rcur_block
		{
			get
			{
				if(r_cur_block == null)
				{
					r_cur_block = new(this, "cur_block");
					r_cur_block.SetBelong(this.instance);
				}
				return r_cur_block;
			}
		}

		/// <summary>
		/// System.Collections.Stack open_blocks
		/// </summary>
		protected RSystem.RCollections.RStack r_open_blocks;
		public virtual RSystem.RCollections.RStack Ropen_blocks
		{
			get
			{
				if(r_open_blocks == null)
				{
					r_open_blocks = new(this, "open_blocks");
					r_open_blocks.SetBelong(this.instance);
				}
				return r_open_blocks;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TokenGenerator token_gen
		/// </summary>
		protected RSystem.RReflection.REmit.RTokenGenerator r_token_gen;
		public virtual RSystem.RReflection.REmit.RTokenGenerator Rtoken_gen
		{
			get
			{
				if(r_token_gen == null)
				{
					r_token_gen = new(this, "token_gen");
					r_token_gen.SetBelong(this.instance);
				}
				return r_token_gen;
			}
		}

		/// <summary>
		/// System.Int32 defaultFixupSize
		/// </summary>
		protected static RSystem.RInt32 r_defaultFixupSize;
		public static RSystem.RInt32 RdefaultFixupSize
		{
			get
			{
				if(r_defaultFixupSize == null)
				{
					r_defaultFixupSize = new(typeof(System.Reflection.Emit.ILGenerator), "defaultFixupSize");
					r_defaultFixupSize.SetBelong(null);
				}
				return r_defaultFixupSize;
			}
		}

		/// <summary>
		/// System.Int32 defaultLabelsSize
		/// </summary>
		protected static RSystem.RInt32 r_defaultLabelsSize;
		public static RSystem.RInt32 RdefaultLabelsSize
		{
			get
			{
				if(r_defaultLabelsSize == null)
				{
					r_defaultLabelsSize = new(typeof(System.Reflection.Emit.ILGenerator), "defaultLabelsSize");
					r_defaultLabelsSize.SetBelong(null);
				}
				return r_defaultLabelsSize;
			}
		}

		/// <summary>
		/// System.Int32 defaultExceptionStackSize
		/// </summary>
		protected static RSystem.RInt32 r_defaultExceptionStackSize;
		public static RSystem.RInt32 RdefaultExceptionStackSize
		{
			get
			{
				if(r_defaultExceptionStackSize == null)
				{
					r_defaultExceptionStackSize = new(typeof(System.Reflection.Emit.ILGenerator), "defaultExceptionStackSize");
					r_defaultExceptionStackSize.SetBelong(null);
				}
				return r_defaultExceptionStackSize;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList sequencePointLists
		/// </summary>
		protected RSystem.RCollections.RArrayList r_sequencePointLists;
		public virtual RSystem.RCollections.RArrayList RsequencePointLists
		{
			get
			{
				if(r_sequencePointLists == null)
				{
					r_sequencePointLists = new(this, "sequencePointLists");
					r_sequencePointLists.SetBelong(this.instance);
				}
				return r_sequencePointLists;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SequencePointList currentSequence
		/// </summary>
		protected RSystem.RReflection.REmit.RSequencePointList r_currentSequence;
		public virtual RSystem.RReflection.REmit.RSequencePointList RcurrentSequence
		{
			get
			{
				if(r_currentSequence == null)
				{
					r_currentSequence = new(this, "currentSequence");
					r_currentSequence.SetBelong(this.instance);
				}
				return r_currentSequence;
			}
		}

		/// <summary>
		/// Boolean HasDebugInfo
		/// </summary>
		protected RSystem.RBoolean r_HasDebugInfo;
		public virtual RSystem.RBoolean RHasDebugInfo
		{
			get
			{
				if(r_HasDebugInfo == null)
				{
					r_HasDebugInfo = new(this, "HasDebugInfo", -1);
					r_HasDebugInfo.SetBelong(this.instance);
				}
				return r_HasDebugInfo;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TokenGenerator TokenGenerator
		/// </summary>
		protected RSystem.RReflection.REmit.RTokenGenerator r_TokenGenerator;
		public virtual RSystem.RReflection.REmit.RTokenGenerator RTokenGenerator
		{
			get
			{
				if(r_TokenGenerator == null)
				{
					r_TokenGenerator = new(this, "TokenGenerator", -1);
					r_TokenGenerator.SetBelong(this.instance);
				}
				return r_TokenGenerator;
			}
		}

		/// <summary>
		/// Int32 ILOffset
		/// </summary>
		protected RSystem.RInt32 r_ILOffset;
		public virtual RSystem.RInt32 RILOffset
		{
			get
			{
				if(r_ILOffset == null)
				{
					r_ILOffset = new(this, "ILOffset", -1);
					r_ILOffset.SetBelong(this.instance);
				}
				return r_ILOffset;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ILGenerator.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___ILGenerator__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___ILGenerator__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___ILGenerator__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ILGenerator.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___ILGenerator__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___ILGenerator__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ILGenerator.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ILGenerator.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ILGenerator.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_System__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._ILGenerator.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_System__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ILGenerator.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_System__2__Runtime__2__InteropServices__2___ILGenerator__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_System__2__Runtime__2__InteropServices__2___ILGenerator__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_System__2__Runtime__2__InteropServices__2___ILGenerator__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._ILGenerator.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_System__2__Runtime__2__InteropServices__2___ILGenerator__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_System__2__Runtime__2__InteropServices__2___ILGenerator__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Void add_token_fixup(System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_add_token_fixup_MemberInfo;
		public virtual RMethod Radd_token_fixup_MemberInfo
		{
			get
			{
				if(r_add_token_fixup_MemberInfo == null)
				{
					r_add_token_fixup_MemberInfo = new(this, "add_token_fixup", 0, typeof(System.Reflection.MemberInfo));
					r_add_token_fixup_MemberInfo.SetBelong(this.instance);
				}
				return r_add_token_fixup_MemberInfo;
			}
		}

		/// <summary>
		/// Void make_room(Int32)
		/// </summary>
		protected RMethod r_make_room_Int32;
		public virtual RMethod Rmake_room_Int32
		{
			get
			{
				if(r_make_room_Int32 == null)
				{
					r_make_room_Int32 = new(this, "make_room", 0, typeof(System.Int32));
					r_make_room_Int32.SetBelong(this.instance);
				}
				return r_make_room_Int32;
			}
		}

		/// <summary>
		/// Void emit_int(Int32)
		/// </summary>
		protected RMethod r_emit_int_Int32;
		public virtual RMethod Remit_int_Int32
		{
			get
			{
				if(r_emit_int_Int32 == null)
				{
					r_emit_int_Int32 = new(this, "emit_int", 0, typeof(System.Int32));
					r_emit_int_Int32.SetBelong(this.instance);
				}
				return r_emit_int_Int32;
			}
		}

		/// <summary>
		/// Void ll_emit(System.Reflection.Emit.OpCode)
		/// </summary>
		protected RMethod r_ll_emit_OpCode;
		public virtual RMethod Rll_emit_OpCode
		{
			get
			{
				if(r_ll_emit_OpCode == null)
				{
					r_ll_emit_OpCode = new(this, "ll_emit", 0, typeof(System.Reflection.Emit.OpCode));
					r_ll_emit_OpCode.SetBelong(this.instance);
				}
				return r_ll_emit_OpCode;
			}
		}

		/// <summary>
		/// Int32 target_len(System.Reflection.Emit.OpCode)
		/// </summary>
		protected static RMethod r_target_len_OpCode;
		public static RMethod Rtarget_len_OpCode
		{
			get
			{
				if(r_target_len_OpCode == null)
				{
					r_target_len_OpCode = new(typeof(System.Reflection.Emit.ILGenerator), "target_len", 0, typeof(System.Reflection.Emit.OpCode));
					r_target_len_OpCode.SetBelong(null);
				}
				return r_target_len_OpCode;
			}
		}

		/// <summary>
		/// Void InternalEndClause()
		/// </summary>
		protected RMethod r_InternalEndClause;
		public virtual RMethod RInternalEndClause
		{
			get
			{
				if(r_InternalEndClause == null)
				{
					r_InternalEndClause = new(this, "InternalEndClause", 0);
					r_InternalEndClause.SetBelong(this.instance);
				}
				return r_InternalEndClause;
			}
		}

		/// <summary>
		/// Void BeginCatchBlock(System.Type)
		/// </summary>
		protected RMethod r_BeginCatchBlock_Type;
		public virtual RMethod RBeginCatchBlock_Type
		{
			get
			{
				if(r_BeginCatchBlock_Type == null)
				{
					r_BeginCatchBlock_Type = new(this, "BeginCatchBlock", 0, typeof(System.Type));
					r_BeginCatchBlock_Type.SetBelong(this.instance);
				}
				return r_BeginCatchBlock_Type;
			}
		}

		/// <summary>
		/// Void BeginExceptFilterBlock()
		/// </summary>
		protected RMethod r_BeginExceptFilterBlock;
		public virtual RMethod RBeginExceptFilterBlock
		{
			get
			{
				if(r_BeginExceptFilterBlock == null)
				{
					r_BeginExceptFilterBlock = new(this, "BeginExceptFilterBlock", 0);
					r_BeginExceptFilterBlock.SetBelong(this.instance);
				}
				return r_BeginExceptFilterBlock;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.Label BeginExceptionBlock()
		/// </summary>
		protected RMethod r_BeginExceptionBlock;
		public virtual RMethod RBeginExceptionBlock
		{
			get
			{
				if(r_BeginExceptionBlock == null)
				{
					r_BeginExceptionBlock = new(this, "BeginExceptionBlock", 0);
					r_BeginExceptionBlock.SetBelong(this.instance);
				}
				return r_BeginExceptionBlock;
			}
		}

		/// <summary>
		/// Void BeginFaultBlock()
		/// </summary>
		protected RMethod r_BeginFaultBlock;
		public virtual RMethod RBeginFaultBlock
		{
			get
			{
				if(r_BeginFaultBlock == null)
				{
					r_BeginFaultBlock = new(this, "BeginFaultBlock", 0);
					r_BeginFaultBlock.SetBelong(this.instance);
				}
				return r_BeginFaultBlock;
			}
		}

		/// <summary>
		/// Void BeginFinallyBlock()
		/// </summary>
		protected RMethod r_BeginFinallyBlock;
		public virtual RMethod RBeginFinallyBlock
		{
			get
			{
				if(r_BeginFinallyBlock == null)
				{
					r_BeginFinallyBlock = new(this, "BeginFinallyBlock", 0);
					r_BeginFinallyBlock.SetBelong(this.instance);
				}
				return r_BeginFinallyBlock;
			}
		}

		/// <summary>
		/// Void BeginScope()
		/// </summary>
		protected RMethod r_BeginScope;
		public virtual RMethod RBeginScope
		{
			get
			{
				if(r_BeginScope == null)
				{
					r_BeginScope = new(this, "BeginScope", 0);
					r_BeginScope.SetBelong(this.instance);
				}
				return r_BeginScope;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.LocalBuilder DeclareLocal(System.Type)
		/// </summary>
		protected RMethod r_DeclareLocal_Type;
		public virtual RMethod RDeclareLocal_Type
		{
			get
			{
				if(r_DeclareLocal_Type == null)
				{
					r_DeclareLocal_Type = new(this, "DeclareLocal", 0, typeof(System.Type));
					r_DeclareLocal_Type.SetBelong(this.instance);
				}
				return r_DeclareLocal_Type;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.LocalBuilder DeclareLocal(System.Type, Boolean)
		/// </summary>
		protected RMethod r_DeclareLocal_Type_Boolean;
		public virtual RMethod RDeclareLocal_Type_Boolean
		{
			get
			{
				if(r_DeclareLocal_Type_Boolean == null)
				{
					r_DeclareLocal_Type_Boolean = new(this, "DeclareLocal", 0, typeof(System.Type), typeof(System.Boolean));
					r_DeclareLocal_Type_Boolean.SetBelong(this.instance);
				}
				return r_DeclareLocal_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.Label DefineLabel()
		/// </summary>
		protected RMethod r_DefineLabel;
		public virtual RMethod RDefineLabel
		{
			get
			{
				if(r_DefineLabel == null)
				{
					r_DefineLabel = new(this, "DefineLabel", 0);
					r_DefineLabel.SetBelong(this.instance);
				}
				return r_DefineLabel;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode)
		/// </summary>
		protected RMethod r_Emit_OpCode;
		public virtual RMethod REmit_OpCode
		{
			get
			{
				if(r_Emit_OpCode == null)
				{
					r_Emit_OpCode = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode));
					r_Emit_OpCode.SetBelong(this.instance);
				}
				return r_Emit_OpCode;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, Byte)
		/// </summary>
		protected RMethod r_Emit_OpCode_Byte;
		public virtual RMethod REmit_OpCode_Byte
		{
			get
			{
				if(r_Emit_OpCode_Byte == null)
				{
					r_Emit_OpCode_Byte = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Byte));
					r_Emit_OpCode_Byte.SetBelong(this.instance);
				}
				return r_Emit_OpCode_Byte;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, System.Reflection.ConstructorInfo)
		/// </summary>
		protected RMethod r_Emit_OpCode_ConstructorInfo;
		public virtual RMethod REmit_OpCode_ConstructorInfo
		{
			get
			{
				if(r_Emit_OpCode_ConstructorInfo == null)
				{
					r_Emit_OpCode_ConstructorInfo = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.ConstructorInfo));
					r_Emit_OpCode_ConstructorInfo.SetBelong(this.instance);
				}
				return r_Emit_OpCode_ConstructorInfo;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, Double)
		/// </summary>
		protected RMethod r_Emit_OpCode_Double;
		public virtual RMethod REmit_OpCode_Double
		{
			get
			{
				if(r_Emit_OpCode_Double == null)
				{
					r_Emit_OpCode_Double = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Double));
					r_Emit_OpCode_Double.SetBelong(this.instance);
				}
				return r_Emit_OpCode_Double;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, System.Reflection.FieldInfo)
		/// </summary>
		protected RMethod r_Emit_OpCode_FieldInfo;
		public virtual RMethod REmit_OpCode_FieldInfo
		{
			get
			{
				if(r_Emit_OpCode_FieldInfo == null)
				{
					r_Emit_OpCode_FieldInfo = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.FieldInfo));
					r_Emit_OpCode_FieldInfo.SetBelong(this.instance);
				}
				return r_Emit_OpCode_FieldInfo;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, Int16)
		/// </summary>
		protected RMethod r_Emit_OpCode_Int16;
		public virtual RMethod REmit_OpCode_Int16
		{
			get
			{
				if(r_Emit_OpCode_Int16 == null)
				{
					r_Emit_OpCode_Int16 = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Int16));
					r_Emit_OpCode_Int16.SetBelong(this.instance);
				}
				return r_Emit_OpCode_Int16;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, Int32)
		/// </summary>
		protected RMethod r_Emit_OpCode_Int32;
		public virtual RMethod REmit_OpCode_Int32
		{
			get
			{
				if(r_Emit_OpCode_Int32 == null)
				{
					r_Emit_OpCode_Int32 = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Int32));
					r_Emit_OpCode_Int32.SetBelong(this.instance);
				}
				return r_Emit_OpCode_Int32;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, Int64)
		/// </summary>
		protected RMethod r_Emit_OpCode_Int64;
		public virtual RMethod REmit_OpCode_Int64
		{
			get
			{
				if(r_Emit_OpCode_Int64 == null)
				{
					r_Emit_OpCode_Int64 = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Int64));
					r_Emit_OpCode_Int64.SetBelong(this.instance);
				}
				return r_Emit_OpCode_Int64;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, System.Reflection.Emit.Label)
		/// </summary>
		protected RMethod r_Emit_OpCode_Label;
		public virtual RMethod REmit_OpCode_Label
		{
			get
			{
				if(r_Emit_OpCode_Label == null)
				{
					r_Emit_OpCode_Label = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.Emit.Label));
					r_Emit_OpCode_Label.SetBelong(this.instance);
				}
				return r_Emit_OpCode_Label;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, System.Reflection.Emit.Label[])
		/// </summary>
		protected RMethod r_Emit_OpCode_LabelArray;
		public virtual RMethod REmit_OpCode_LabelArray
		{
			get
			{
				if(r_Emit_OpCode_LabelArray == null)
				{
					r_Emit_OpCode_LabelArray = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.Emit.Label).MakeArrayType());
					r_Emit_OpCode_LabelArray.SetBelong(this.instance);
				}
				return r_Emit_OpCode_LabelArray;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, System.Reflection.Emit.LocalBuilder)
		/// </summary>
		protected RMethod r_Emit_OpCode_LocalBuilder;
		public virtual RMethod REmit_OpCode_LocalBuilder
		{
			get
			{
				if(r_Emit_OpCode_LocalBuilder == null)
				{
					r_Emit_OpCode_LocalBuilder = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.Emit.LocalBuilder));
					r_Emit_OpCode_LocalBuilder.SetBelong(this.instance);
				}
				return r_Emit_OpCode_LocalBuilder;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_Emit_OpCode_MethodInfo;
		public virtual RMethod REmit_OpCode_MethodInfo
		{
			get
			{
				if(r_Emit_OpCode_MethodInfo == null)
				{
					r_Emit_OpCode_MethodInfo = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.MethodInfo));
					r_Emit_OpCode_MethodInfo.SetBelong(this.instance);
				}
				return r_Emit_OpCode_MethodInfo;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, System.Reflection.MethodInfo, Int32)
		/// </summary>
		protected RMethod r_Emit_OpCode_MethodInfo_Int32;
		public virtual RMethod REmit_OpCode_MethodInfo_Int32
		{
			get
			{
				if(r_Emit_OpCode_MethodInfo_Int32 == null)
				{
					r_Emit_OpCode_MethodInfo_Int32 = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.MethodInfo), typeof(System.Int32));
					r_Emit_OpCode_MethodInfo_Int32.SetBelong(this.instance);
				}
				return r_Emit_OpCode_MethodInfo_Int32;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, SByte)
		/// </summary>
		protected RMethod r_Emit_OpCode_SByte;
		public virtual RMethod REmit_OpCode_SByte
		{
			get
			{
				if(r_Emit_OpCode_SByte == null)
				{
					r_Emit_OpCode_SByte = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.SByte));
					r_Emit_OpCode_SByte.SetBelong(this.instance);
				}
				return r_Emit_OpCode_SByte;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, System.Reflection.Emit.SignatureHelper)
		/// </summary>
		protected RMethod r_Emit_OpCode_SignatureHelper;
		public virtual RMethod REmit_OpCode_SignatureHelper
		{
			get
			{
				if(r_Emit_OpCode_SignatureHelper == null)
				{
					r_Emit_OpCode_SignatureHelper = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.Emit.SignatureHelper));
					r_Emit_OpCode_SignatureHelper.SetBelong(this.instance);
				}
				return r_Emit_OpCode_SignatureHelper;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, Single)
		/// </summary>
		protected RMethod r_Emit_OpCode_Single;
		public virtual RMethod REmit_OpCode_Single
		{
			get
			{
				if(r_Emit_OpCode_Single == null)
				{
					r_Emit_OpCode_Single = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Single));
					r_Emit_OpCode_Single.SetBelong(this.instance);
				}
				return r_Emit_OpCode_Single;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, System.String)
		/// </summary>
		protected RMethod r_Emit_OpCode_String;
		public virtual RMethod REmit_OpCode_String
		{
			get
			{
				if(r_Emit_OpCode_String == null)
				{
					r_Emit_OpCode_String = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.String));
					r_Emit_OpCode_String.SetBelong(this.instance);
				}
				return r_Emit_OpCode_String;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, System.Type)
		/// </summary>
		protected RMethod r_Emit_OpCode_Type;
		public virtual RMethod REmit_OpCode_Type
		{
			get
			{
				if(r_Emit_OpCode_Type == null)
				{
					r_Emit_OpCode_Type = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Type));
					r_Emit_OpCode_Type.SetBelong(this.instance);
				}
				return r_Emit_OpCode_Type;
			}
		}

		/// <summary>
		/// Void EmitCall(System.Reflection.Emit.OpCode, System.Reflection.MethodInfo, System.Type[])
		/// </summary>
		protected RMethod r_EmitCall_OpCode_MethodInfo_TypeArray;
		public virtual RMethod REmitCall_OpCode_MethodInfo_TypeArray
		{
			get
			{
				if(r_EmitCall_OpCode_MethodInfo_TypeArray == null)
				{
					r_EmitCall_OpCode_MethodInfo_TypeArray = new(this, "EmitCall", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.MethodInfo), typeof(System.Type).MakeArrayType());
					r_EmitCall_OpCode_MethodInfo_TypeArray.SetBelong(this.instance);
				}
				return r_EmitCall_OpCode_MethodInfo_TypeArray;
			}
		}

		/// <summary>
		/// Void EmitCalli(System.Reflection.Emit.OpCode, System.Runtime.InteropServices.CallingConvention, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_EmitCalli_OpCode_CallingConvention_Type_TypeArray;
		public virtual RMethod REmitCalli_OpCode_CallingConvention_Type_TypeArray
		{
			get
			{
				if(r_EmitCalli_OpCode_CallingConvention_Type_TypeArray == null)
				{
					r_EmitCalli_OpCode_CallingConvention_Type_TypeArray = new(this, "EmitCalli", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Runtime.InteropServices.CallingConvention), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_EmitCalli_OpCode_CallingConvention_Type_TypeArray.SetBelong(this.instance);
				}
				return r_EmitCalli_OpCode_CallingConvention_Type_TypeArray;
			}
		}

		/// <summary>
		/// Void EmitCalli(System.Reflection.Emit.OpCode, System.Reflection.CallingConventions, System.Type, System.Type[], System.Type[])
		/// </summary>
		protected RMethod r_EmitCalli_OpCode_CallingConventions_Type_TypeArray_TypeArray;
		public virtual RMethod REmitCalli_OpCode_CallingConventions_Type_TypeArray_TypeArray
		{
			get
			{
				if(r_EmitCalli_OpCode_CallingConventions_Type_TypeArray_TypeArray == null)
				{
					r_EmitCalli_OpCode_CallingConventions_Type_TypeArray_TypeArray = new(this, "EmitCalli", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_EmitCalli_OpCode_CallingConventions_Type_TypeArray_TypeArray.SetBelong(this.instance);
				}
				return r_EmitCalli_OpCode_CallingConventions_Type_TypeArray_TypeArray;
			}
		}

		/// <summary>
		/// Void EmitWriteLine(System.Reflection.FieldInfo)
		/// </summary>
		protected RMethod r_EmitWriteLine_FieldInfo;
		public virtual RMethod REmitWriteLine_FieldInfo
		{
			get
			{
				if(r_EmitWriteLine_FieldInfo == null)
				{
					r_EmitWriteLine_FieldInfo = new(this, "EmitWriteLine", 0, typeof(System.Reflection.FieldInfo));
					r_EmitWriteLine_FieldInfo.SetBelong(this.instance);
				}
				return r_EmitWriteLine_FieldInfo;
			}
		}

		/// <summary>
		/// Void EmitWriteLine(System.Reflection.Emit.LocalBuilder)
		/// </summary>
		protected RMethod r_EmitWriteLine_LocalBuilder;
		public virtual RMethod REmitWriteLine_LocalBuilder
		{
			get
			{
				if(r_EmitWriteLine_LocalBuilder == null)
				{
					r_EmitWriteLine_LocalBuilder = new(this, "EmitWriteLine", 0, typeof(System.Reflection.Emit.LocalBuilder));
					r_EmitWriteLine_LocalBuilder.SetBelong(this.instance);
				}
				return r_EmitWriteLine_LocalBuilder;
			}
		}

		/// <summary>
		/// Void EmitWriteLine(System.String)
		/// </summary>
		protected RMethod r_EmitWriteLine_String;
		public virtual RMethod REmitWriteLine_String
		{
			get
			{
				if(r_EmitWriteLine_String == null)
				{
					r_EmitWriteLine_String = new(this, "EmitWriteLine", 0, typeof(System.String));
					r_EmitWriteLine_String.SetBelong(this.instance);
				}
				return r_EmitWriteLine_String;
			}
		}

		/// <summary>
		/// Void EndExceptionBlock()
		/// </summary>
		protected RMethod r_EndExceptionBlock;
		public virtual RMethod REndExceptionBlock
		{
			get
			{
				if(r_EndExceptionBlock == null)
				{
					r_EndExceptionBlock = new(this, "EndExceptionBlock", 0);
					r_EndExceptionBlock.SetBelong(this.instance);
				}
				return r_EndExceptionBlock;
			}
		}

		/// <summary>
		/// Void EndScope()
		/// </summary>
		protected RMethod r_EndScope;
		public virtual RMethod REndScope
		{
			get
			{
				if(r_EndScope == null)
				{
					r_EndScope = new(this, "EndScope", 0);
					r_EndScope.SetBelong(this.instance);
				}
				return r_EndScope;
			}
		}

		/// <summary>
		/// Void MarkLabel(System.Reflection.Emit.Label)
		/// </summary>
		protected RMethod r_MarkLabel_Label;
		public virtual RMethod RMarkLabel_Label
		{
			get
			{
				if(r_MarkLabel_Label == null)
				{
					r_MarkLabel_Label = new(this, "MarkLabel", 0, typeof(System.Reflection.Emit.Label));
					r_MarkLabel_Label.SetBelong(this.instance);
				}
				return r_MarkLabel_Label;
			}
		}

		/// <summary>
		/// Void MarkSequencePoint(System.Diagnostics.SymbolStore.ISymbolDocumentWriter, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MarkSequencePoint_ISymbolDocumentWriter_Int32_Int32_Int32_Int32;
		public virtual RMethod RMarkSequencePoint_ISymbolDocumentWriter_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MarkSequencePoint_ISymbolDocumentWriter_Int32_Int32_Int32_Int32 == null)
				{
					r_MarkSequencePoint_ISymbolDocumentWriter_Int32_Int32_Int32_Int32 = new(this, "MarkSequencePoint", 0, typeof(System.Diagnostics.SymbolStore.ISymbolDocumentWriter), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MarkSequencePoint_ISymbolDocumentWriter_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_MarkSequencePoint_ISymbolDocumentWriter_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GenerateDebugInfo(System.Diagnostics.SymbolStore.ISymbolWriter)
		/// </summary>
		protected RMethod r_GenerateDebugInfo_ISymbolWriter;
		public virtual RMethod RGenerateDebugInfo_ISymbolWriter
		{
			get
			{
				if(r_GenerateDebugInfo_ISymbolWriter == null)
				{
					r_GenerateDebugInfo_ISymbolWriter = new(this, "GenerateDebugInfo", 0, typeof(System.Diagnostics.SymbolStore.ISymbolWriter));
					r_GenerateDebugInfo_ISymbolWriter.SetBelong(this.instance);
				}
				return r_GenerateDebugInfo_ISymbolWriter;
			}
		}

		/// <summary>
		/// Void ThrowException(System.Type)
		/// </summary>
		protected RMethod r_ThrowException_Type;
		public virtual RMethod RThrowException_Type
		{
			get
			{
				if(r_ThrowException_Type == null)
				{
					r_ThrowException_Type = new(this, "ThrowException", 0, typeof(System.Type));
					r_ThrowException_Type.SetBelong(this.instance);
				}
				return r_ThrowException_Type;
			}
		}

		/// <summary>
		/// Void UsingNamespace(System.String)
		/// </summary>
		protected RMethod r_UsingNamespace_String;
		public virtual RMethod RUsingNamespace_String
		{
			get
			{
				if(r_UsingNamespace_String == null)
				{
					r_UsingNamespace_String = new(this, "UsingNamespace", 0, typeof(System.String));
					r_UsingNamespace_String.SetBelong(this.instance);
				}
				return r_UsingNamespace_String;
			}
		}

		/// <summary>
		/// Void label_fixup(System.Reflection.MethodBase)
		/// </summary>
		protected RMethod r_label_fixup_MethodBase;
		public virtual RMethod Rlabel_fixup_MethodBase
		{
			get
			{
				if(r_label_fixup_MethodBase == null)
				{
					r_label_fixup_MethodBase = new(this, "label_fixup", 0, typeof(System.Reflection.MethodBase));
					r_label_fixup_MethodBase.SetBelong(this.instance);
				}
				return r_label_fixup_MethodBase;
			}
		}

		/// <summary>
		/// Void FixupTokens(System.Collections.Generic.Dictionary`2[System.Int32,System.Int32], System.Collections.Generic.Dictionary`2[System.Int32,System.Reflection.MemberInfo])
		/// </summary>
		protected RMethod r_FixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_;
		public virtual RMethod RFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_
		{
			get
			{
				if(r_FixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_ == null)
				{
					r_FixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_ = new(this, "FixupTokens", 0, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32), typeof(System.Int32)), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32), typeof(System.Reflection.MemberInfo)));
					r_FixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_.SetBelong(this.instance);
				}
				return r_FixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_;
			}
		}

		/// <summary>
		/// Void SetExceptionHandlers(System.Reflection.Emit.ILExceptionInfo[])
		/// </summary>
		protected RMethod r_SetExceptionHandlers_ILExceptionInfoArray;
		public virtual RMethod RSetExceptionHandlers_ILExceptionInfoArray
		{
			get
			{
				if(r_SetExceptionHandlers_ILExceptionInfoArray == null)
				{
					r_SetExceptionHandlers_ILExceptionInfoArray = new(this, "SetExceptionHandlers", 0,  ReflectionUtils.GetType("System.Reflection.Emit.ILExceptionInfo").MakeArrayType());
					r_SetExceptionHandlers_ILExceptionInfoArray.SetBelong(this.instance);
				}
				return r_SetExceptionHandlers_ILExceptionInfoArray;
			}
		}

		/// <summary>
		/// Void SetTokenFixups(System.Reflection.Emit.ILTokenInfo[])
		/// </summary>
		protected RMethod r_SetTokenFixups_ILTokenInfoArray;
		public virtual RMethod RSetTokenFixups_ILTokenInfoArray
		{
			get
			{
				if(r_SetTokenFixups_ILTokenInfoArray == null)
				{
					r_SetTokenFixups_ILTokenInfoArray = new(this, "SetTokenFixups", 0,  ReflectionUtils.GetType("System.Reflection.Emit.ILTokenInfo").MakeArrayType());
					r_SetTokenFixups_ILTokenInfoArray.SetBelong(this.instance);
				}
				return r_SetTokenFixups_ILTokenInfoArray;
			}
		}

		/// <summary>
		/// Void SetCode(Byte[], Int32)
		/// </summary>
		protected RMethod r_SetCode_ByteArray_Int32;
		public virtual RMethod RSetCode_ByteArray_Int32
		{
			get
			{
				if(r_SetCode_ByteArray_Int32 == null)
				{
					r_SetCode_ByteArray_Int32 = new(this, "SetCode", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_SetCode_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_SetCode_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Void SetCode(Byte*, Int32, Int32)
		/// </summary>
		protected RMethod r_SetCode_BytePointer_Int32_Int32;
		public virtual RMethod RSetCode_BytePointer_Int32_Int32
		{
			get
			{
				if(r_SetCode_BytePointer_Int32_Int32 == null)
				{
					r_SetCode_BytePointer_Int32_Int32 = new(this, "SetCode", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Int32));
					r_SetCode_BytePointer_Int32_Int32.SetBelong(this.instance);
				}
				return r_SetCode_BytePointer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Init(Byte[], Int32, Byte[], System.Collections.Generic.IEnumerable`1[System.Reflection.Emit.ExceptionHandler], System.Collections.Generic.IEnumerable`1[System.Int32])
		/// </summary>
		protected RMethod r_Init_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_;
		public virtual RMethod RInit_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_
		{
			get
			{
				if(r_Init_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_ == null)
				{
					r_Init_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_ = new(this, "Init", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Reflection.Emit.ExceptionHandler)), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Int32)));
					r_Init_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_.SetBelong(this.instance);
				}
				return r_Init_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_;
			}
		}

		/// <summary>
		/// Int32 Mono_GetCurrentOffset(System.Reflection.Emit.ILGenerator)
		/// </summary>
		protected static RMethod r_Mono_GetCurrentOffset_ILGenerator;
		public static RMethod RMono_GetCurrentOffset_ILGenerator
		{
			get
			{
				if(r_Mono_GetCurrentOffset_ILGenerator == null)
				{
					r_Mono_GetCurrentOffset_ILGenerator = new(typeof(System.Reflection.Emit.ILGenerator), "Mono_GetCurrentOffset", 0, typeof(System.Reflection.Emit.ILGenerator));
					r_Mono_GetCurrentOffset_ILGenerator.SetBelong(null);
				}
				return r_Mono_GetCurrentOffset_ILGenerator;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}


        public RILGenerator() : base("System.Reflection.Emit.ILGenerator")
        {
        }

        public RILGenerator(System.Object instance) : base("System.Reflection.Emit.ILGenerator")
		{
            SetInstance(instance);
		}

        public RILGenerator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RILGenerator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void System__2__Runtime__2__InteropServices__2___ILGenerator__2__GetIDsOfNames(in System.Guid @riid, System.IntPtr @rgszNames, System.UInt32 @cNames, System.UInt32 @lcid, System.IntPtr @rgDispId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@riid, @rgszNames, @cNames, @lcid, @rgDispId};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ILGenerator__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void add_token_fixup(System.Reflection.MemberInfo @mi)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mi};
            var ___result = Radd_token_fixup_MemberInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void make_room(System.Int32 @nbytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nbytes};
            var ___result = Rmake_room_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void emit_int(System.Int32 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val};
            var ___result = Remit_int_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ll_emit(System.Reflection.Emit.OpCode @opcode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode};
            var ___result = Rll_emit_OpCode.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 target_len(System.Reflection.Emit.OpCode @opcode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode};
            var ___result = Rtarget_len_OpCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void InternalEndClause()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalEndClause.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginCatchBlock(System.Type @exceptionType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exceptionType};
            var ___result = RBeginCatchBlock_Type.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginExceptFilterBlock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBeginExceptFilterBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.Label BeginExceptionBlock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBeginExceptionBlock.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.Label)___result;
        }


        public virtual void BeginFaultBlock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBeginFaultBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginFinallyBlock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBeginFinallyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginScope()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBeginScope.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.LocalBuilder DeclareLocal(System.Type @localType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localType};
            var ___result = RDeclareLocal_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.LocalBuilder)___result;
        }


        public virtual System.Reflection.Emit.LocalBuilder DeclareLocal(System.Type @localType, System.Boolean @pinned)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localType, @pinned};
            var ___result = RDeclareLocal_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.LocalBuilder)___result;
        }


        public virtual System.Reflection.Emit.Label DefineLabel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDefineLabel.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.Label)___result;
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode};
            var ___result = REmit_OpCode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Byte @arg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @arg};
            var ___result = REmit_OpCode_Byte.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Reflection.ConstructorInfo @con)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @con};
            var ___result = REmit_OpCode_ConstructorInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Double @arg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @arg};
            var ___result = REmit_OpCode_Double.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Reflection.FieldInfo @field)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @field};
            var ___result = REmit_OpCode_FieldInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Int16 @arg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @arg};
            var ___result = REmit_OpCode_Int16.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Int32 @arg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @arg};
            var ___result = REmit_OpCode_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Int64 @arg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @arg};
            var ___result = REmit_OpCode_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Reflection.Emit.Label @label)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @label};
            var ___result = REmit_OpCode_Label.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Reflection.Emit.Label[] @labels)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @labels};
            var ___result = REmit_OpCode_LabelArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Reflection.Emit.LocalBuilder @local)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @local};
            var ___result = REmit_OpCode_LocalBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Reflection.MethodInfo @meth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @meth};
            var ___result = REmit_OpCode_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Reflection.MethodInfo @method, System.Int32 @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @method, @token};
            var ___result = REmit_OpCode_MethodInfo_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.SByte @arg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @arg};
            var ___result = REmit_OpCode_SByte.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Reflection.Emit.SignatureHelper @signature)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @signature};
            var ___result = REmit_OpCode_SignatureHelper.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Single @arg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @arg};
            var ___result = REmit_OpCode_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @str};
            var ___result = REmit_OpCode_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Type @cls)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @cls};
            var ___result = REmit_OpCode_Type.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EmitCall(System.Reflection.Emit.OpCode @opcode, System.Reflection.MethodInfo @methodInfo, System.Type[] @optionalParameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @methodInfo, @optionalParameterTypes};
            var ___result = REmitCall_OpCode_MethodInfo_TypeArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EmitCalli(System.Reflection.Emit.OpCode @opcode, System.Runtime.InteropServices.CallingConvention @unmanagedCallConv, System.Type @returnType, System.Type[] @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @unmanagedCallConv, @returnType, @parameterTypes};
            var ___result = REmitCalli_OpCode_CallingConvention_Type_TypeArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EmitCalli(System.Reflection.Emit.OpCode @opcode, System.Reflection.CallingConventions @callingConvention, System.Type @returnType, System.Type[] @parameterTypes, System.Type[] @optionalParameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @callingConvention, @returnType, @parameterTypes, @optionalParameterTypes};
            var ___result = REmitCalli_OpCode_CallingConventions_Type_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EmitWriteLine(System.Reflection.FieldInfo @fld)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fld};
            var ___result = REmitWriteLine_FieldInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EmitWriteLine(System.Reflection.Emit.LocalBuilder @localBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localBuilder};
            var ___result = REmitWriteLine_LocalBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EmitWriteLine(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = REmitWriteLine_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndExceptionBlock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REndExceptionBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndScope()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REndScope.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkLabel(System.Reflection.Emit.Label @loc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@loc};
            var ___result = RMarkLabel_Label.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkSequencePoint(System.Diagnostics.SymbolStore.ISymbolDocumentWriter @document, System.Int32 @startLine, System.Int32 @startColumn, System.Int32 @endLine, System.Int32 @endColumn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@document, @startLine, @startColumn, @endLine, @endColumn};
            var ___result = RMarkSequencePoint_ISymbolDocumentWriter_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GenerateDebugInfo(System.Diagnostics.SymbolStore.ISymbolWriter @symbolWriter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@symbolWriter};
            var ___result = RGenerateDebugInfo_ISymbolWriter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowException(System.Type @excType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@excType};
            var ___result = RThrowException_Type.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UsingNamespace(System.String @usingNamespace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@usingNamespace};
            var ___result = RUsingNamespace_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void label_fixup(System.Reflection.MethodBase @mb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mb};
            var ___result = Rlabel_fixup_MethodBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FixupTokens(System.Collections.Generic.Dictionary<System.Int32, System.Int32> @token_map, System.Collections.Generic.Dictionary<System.Int32, System.Reflection.MemberInfo> @member_map)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token_map, @member_map};
            var ___result = RFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetExceptionHandlers(RTypeArray<RSystem.RReflection.REmit.RILExceptionInfo> @exHandlers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exHandlers.Value};
            var ___result = RSetExceptionHandlers_ILExceptionInfoArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTokenFixups(RTypeArray<RSystem.RReflection.REmit.RILTokenInfo> @tokenFixups)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenFixups.Value};
            var ___result = RSetTokenFixups_ILTokenInfoArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCode(System.Byte[] @code, System.Int32 @max_stack)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@code, @max_stack};
            var ___result = RSetCode_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe virtual void SetCode(System.Byte* @code, System.Int32 @code_size, System.Int32 @max_stack)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@code, typeof(System.Byte)), @code_size, @max_stack};
            var ___result = RSetCode_BytePointer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Init(System.Byte[] @il, System.Int32 @maxStack, System.Byte[] @localSignature, System.Collections.Generic.IEnumerable<System.Reflection.Emit.ExceptionHandler> @exceptionHandlers, System.Collections.Generic.IEnumerable<System.Int32> @tokenFixups)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@il, @maxStack, @localSignature, @exceptionHandlers, @tokenFixups};
            var ___result = RInit_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 Mono_GetCurrentOffset(System.Reflection.Emit.ILGenerator @ig)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ig};
            var ___result = RMono_GetCurrentOffset_ILGenerator.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
