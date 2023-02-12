
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
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RByte> r_Fcode;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RByte> RFcode
		{
			get
			{
				if(r_Fcode == null)
				{
					r_Fcode = new(this, "code");
					r_Fcode.SetBelong(this.instance);
				}
				return r_Fcode;
			}
		}

		/// <summary>
		/// System.Int32 code_len
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fcode_len;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFcode_len
		{
			get
			{
				if(r_Fcode_len == null)
				{
					r_Fcode_len = new(this, "code_len");
					r_Fcode_len.SetBelong(this.instance);
				}
				return r_Fcode_len;
			}
		}

		/// <summary>
		/// System.Int32 max_stack
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fmax_stack;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFmax_stack
		{
			get
			{
				if(r_Fmax_stack == null)
				{
					r_Fmax_stack = new(this, "max_stack");
					r_Fmax_stack.SetBelong(this.instance);
				}
				return r_Fmax_stack;
			}
		}

		/// <summary>
		/// System.Int32 cur_stack
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fcur_stack;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFcur_stack
		{
			get
			{
				if(r_Fcur_stack == null)
				{
					r_Fcur_stack = new(this, "cur_stack");
					r_Fcur_stack.SetBelong(this.instance);
				}
				return r_Fcur_stack;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.LocalBuilder[] locals
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RLocalBuilder> r_Flocals;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RLocalBuilder> RFlocals
		{
			get
			{
				if(r_Flocals == null)
				{
					r_Flocals = new(this, "locals");
					r_Flocals.SetBelong(this.instance);
				}
				return r_Flocals;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ILExceptionInfo[] ex_handlers
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RILExceptionInfo> r_Fex_handlers;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RILExceptionInfo> RFex_handlers
		{
			get
			{
				if(r_Fex_handlers == null)
				{
					r_Fex_handlers = new(this, "ex_handlers");
					r_Fex_handlers.SetBelong(this.instance);
				}
				return r_Fex_handlers;
			}
		}

		/// <summary>
		/// System.Int32 num_token_fixups
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fnum_token_fixups;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFnum_token_fixups
		{
			get
			{
				if(r_Fnum_token_fixups == null)
				{
					r_Fnum_token_fixups = new(this, "num_token_fixups");
					r_Fnum_token_fixups.SetBelong(this.instance);
				}
				return r_Fnum_token_fixups;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ILTokenInfo[] token_fixups
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RILTokenInfo> r_Ftoken_fixups;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RILTokenInfo> RFtoken_fixups
		{
			get
			{
				if(r_Ftoken_fixups == null)
				{
					r_Ftoken_fixups = new(this, "token_fixups");
					r_Ftoken_fixups.SetBelong(this.instance);
				}
				return r_Ftoken_fixups;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ILGenerator+LabelData[] labels
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RILGenerator.RLabelData> r_Flabels;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RILGenerator.RLabelData> RFlabels
		{
			get
			{
				if(r_Flabels == null)
				{
					r_Flabels = new(this, "labels");
					r_Flabels.SetBelong(this.instance);
				}
				return r_Flabels;
			}
		}

		/// <summary>
		/// System.Int32 num_labels
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fnum_labels;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFnum_labels
		{
			get
			{
				if(r_Fnum_labels == null)
				{
					r_Fnum_labels = new(this, "num_labels");
					r_Fnum_labels.SetBelong(this.instance);
				}
				return r_Fnum_labels;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.ILGenerator+LabelFixup[] fixups
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RILGenerator.RLabelFixup> r_Ffixups;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RILGenerator.RLabelFixup> RFfixups
		{
			get
			{
				if(r_Ffixups == null)
				{
					r_Ffixups = new(this, "fixups");
					r_Ffixups.SetBelong(this.instance);
				}
				return r_Ffixups;
			}
		}

		/// <summary>
		/// System.Int32 num_fixups
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fnum_fixups;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFnum_fixups
		{
			get
			{
				if(r_Fnum_fixups == null)
				{
					r_Fnum_fixups = new(this, "num_fixups");
					r_Fnum_fixups.SetBelong(this.instance);
				}
				return r_Fnum_fixups;
			}
		}

		/// <summary>
		/// System.Reflection.Module module
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RModule r_Fmodule;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RModule RFmodule
		{
			get
			{
				if(r_Fmodule == null)
				{
					r_Fmodule = new(this, "module");
					r_Fmodule.SetBelong(this.instance);
				}
				return r_Fmodule;
			}
		}

		/// <summary>
		/// System.Int32 cur_block
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fcur_block;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFcur_block
		{
			get
			{
				if(r_Fcur_block == null)
				{
					r_Fcur_block = new(this, "cur_block");
					r_Fcur_block.SetBelong(this.instance);
				}
				return r_Fcur_block;
			}
		}

		/// <summary>
		/// System.Collections.Stack open_blocks
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RStack r_Fopen_blocks;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RStack RFopen_blocks
		{
			get
			{
				if(r_Fopen_blocks == null)
				{
					r_Fopen_blocks = new(this, "open_blocks");
					r_Fopen_blocks.SetBelong(this.instance);
				}
				return r_Fopen_blocks;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TokenGenerator token_gen
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RTokenGenerator r_Ftoken_gen;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RTokenGenerator RFtoken_gen
		{
			get
			{
				if(r_Ftoken_gen == null)
				{
					r_Ftoken_gen = new(this, "token_gen");
					r_Ftoken_gen.SetBelong(this.instance);
				}
				return r_Ftoken_gen;
			}
		}

		/// <summary>
		/// System.Int32 defaultFixupSize
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RInt32 r_FdefaultFixupSize;
		public static SMFrame.Editor.Refleaction.RSystem.RInt32 RFdefaultFixupSize
		{
			get
			{
				if(r_FdefaultFixupSize == null)
				{
					r_FdefaultFixupSize = new(typeof(System.Reflection.Emit.ILGenerator), "defaultFixupSize");
					r_FdefaultFixupSize.SetBelong(null);
				}
				return r_FdefaultFixupSize;
			}
		}

		/// <summary>
		/// System.Int32 defaultLabelsSize
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RInt32 r_FdefaultLabelsSize;
		public static SMFrame.Editor.Refleaction.RSystem.RInt32 RFdefaultLabelsSize
		{
			get
			{
				if(r_FdefaultLabelsSize == null)
				{
					r_FdefaultLabelsSize = new(typeof(System.Reflection.Emit.ILGenerator), "defaultLabelsSize");
					r_FdefaultLabelsSize.SetBelong(null);
				}
				return r_FdefaultLabelsSize;
			}
		}

		/// <summary>
		/// System.Int32 defaultExceptionStackSize
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RInt32 r_FdefaultExceptionStackSize;
		public static SMFrame.Editor.Refleaction.RSystem.RInt32 RFdefaultExceptionStackSize
		{
			get
			{
				if(r_FdefaultExceptionStackSize == null)
				{
					r_FdefaultExceptionStackSize = new(typeof(System.Reflection.Emit.ILGenerator), "defaultExceptionStackSize");
					r_FdefaultExceptionStackSize.SetBelong(null);
				}
				return r_FdefaultExceptionStackSize;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList sequencePointLists
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RArrayList r_FsequencePointLists;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RArrayList RFsequencePointLists
		{
			get
			{
				if(r_FsequencePointLists == null)
				{
					r_FsequencePointLists = new(this, "sequencePointLists");
					r_FsequencePointLists.SetBelong(this.instance);
				}
				return r_FsequencePointLists;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.SequencePointList currentSequence
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RSequencePointList r_FcurrentSequence;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RSequencePointList RFcurrentSequence
		{
			get
			{
				if(r_FcurrentSequence == null)
				{
					r_FcurrentSequence = new(this, "currentSequence");
					r_FcurrentSequence.SetBelong(this.instance);
				}
				return r_FcurrentSequence;
			}
		}

		/// <summary>
		/// Boolean HasDebugInfo
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PHasDebugInfo;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPHasDebugInfo
		{
			get
			{
				if(r_PHasDebugInfo == null)
				{
					r_PHasDebugInfo = new(this, "HasDebugInfo", -1);
					r_PHasDebugInfo.SetBelong(this.instance);
				}
				return r_PHasDebugInfo;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.TokenGenerator TokenGenerator
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RTokenGenerator r_PTokenGenerator;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RTokenGenerator RPTokenGenerator
		{
			get
			{
				if(r_PTokenGenerator == null)
				{
					r_PTokenGenerator = new(this, "TokenGenerator", -1);
					r_PTokenGenerator.SetBelong(this.instance);
				}
				return r_PTokenGenerator;
			}
		}

		/// <summary>
		/// Int32 ILOffset
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PILOffset;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPILOffset
		{
			get
			{
				if(r_PILOffset == null)
				{
					r_PILOffset = new(this, "ILOffset", -1);
					r_PILOffset.SetBelong(this.instance);
				}
				return r_PILOffset;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ILGenerator.GetIDsOfNames(System.Guid ByRef, IntPtr, UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ILGenerator.GetIDsOfNames", 0, typeof(System.Guid).MakeByRefType(), typeof(System.IntPtr), typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ILGenerator.GetTypeInfo(UInt32, UInt32, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfo_UInt32_UInt32_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfo_UInt32_UInt32_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfo_UInt32_UInt32_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfo_UInt32_UInt32_IntPtr = new(this, "System.Runtime.InteropServices._ILGenerator.GetTypeInfo", 0, typeof(System.UInt32), typeof(System.UInt32), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfo_UInt32_UInt32_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfo_UInt32_UInt32_IntPtr;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ILGenerator.GetTypeInfoCount(UInt32 ByRef)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfoCount_Out_UInt32;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfoCount_Out_UInt32
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfoCount_Out_UInt32 == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfoCount_Out_UInt32 = new(this, "System.Runtime.InteropServices._ILGenerator.GetTypeInfoCount", 0, typeof(System.UInt32).MakeByRefType());
					r_MSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfoCount_Out_UInt32.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfoCount_Out_UInt32;
			}
		}

		/// <summary>
		/// Void System.Runtime.InteropServices._ILGenerator.Invoke(UInt32, System.Guid ByRef, UInt32, Int16, IntPtr, IntPtr, IntPtr, IntPtr)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
		public virtual RMethod RMSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr
		{
			get
			{
				if(r_MSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr == null)
				{
					r_MSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr = new(this, "System.Runtime.InteropServices._ILGenerator.Invoke", 0, typeof(System.UInt32), typeof(System.Guid).MakeByRefType(), typeof(System.UInt32), typeof(System.Int16), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr), typeof(System.IntPtr));
					r_MSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.SetBelong(this.instance);
				}
				return r_MSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr;
			}
		}

		/// <summary>
		/// Void add_token_fixup(System.Reflection.MemberInfo)
		/// </summary>
		protected RMethod r_Madd_token_fixup_MemberInfo;
		public virtual RMethod RMadd_token_fixup_MemberInfo
		{
			get
			{
				if(r_Madd_token_fixup_MemberInfo == null)
				{
					r_Madd_token_fixup_MemberInfo = new(this, "add_token_fixup", 0, typeof(System.Reflection.MemberInfo));
					r_Madd_token_fixup_MemberInfo.SetBelong(this.instance);
				}
				return r_Madd_token_fixup_MemberInfo;
			}
		}

		/// <summary>
		/// Void make_room(Int32)
		/// </summary>
		protected RMethod r_Mmake_room_Int32;
		public virtual RMethod RMmake_room_Int32
		{
			get
			{
				if(r_Mmake_room_Int32 == null)
				{
					r_Mmake_room_Int32 = new(this, "make_room", 0, typeof(System.Int32));
					r_Mmake_room_Int32.SetBelong(this.instance);
				}
				return r_Mmake_room_Int32;
			}
		}

		/// <summary>
		/// Void emit_int(Int32)
		/// </summary>
		protected RMethod r_Memit_int_Int32;
		public virtual RMethod RMemit_int_Int32
		{
			get
			{
				if(r_Memit_int_Int32 == null)
				{
					r_Memit_int_Int32 = new(this, "emit_int", 0, typeof(System.Int32));
					r_Memit_int_Int32.SetBelong(this.instance);
				}
				return r_Memit_int_Int32;
			}
		}

		/// <summary>
		/// Void ll_emit(System.Reflection.Emit.OpCode)
		/// </summary>
		protected RMethod r_Mll_emit_OpCode;
		public virtual RMethod RMll_emit_OpCode
		{
			get
			{
				if(r_Mll_emit_OpCode == null)
				{
					r_Mll_emit_OpCode = new(this, "ll_emit", 0, typeof(System.Reflection.Emit.OpCode));
					r_Mll_emit_OpCode.SetBelong(this.instance);
				}
				return r_Mll_emit_OpCode;
			}
		}

		/// <summary>
		/// Int32 target_len(System.Reflection.Emit.OpCode)
		/// </summary>
		protected static RMethod r_Mtarget_len_OpCode;
		public static RMethod RMtarget_len_OpCode
		{
			get
			{
				if(r_Mtarget_len_OpCode == null)
				{
					r_Mtarget_len_OpCode = new(typeof(System.Reflection.Emit.ILGenerator), "target_len", 0, typeof(System.Reflection.Emit.OpCode));
					r_Mtarget_len_OpCode.SetBelong(null);
				}
				return r_Mtarget_len_OpCode;
			}
		}

		/// <summary>
		/// Void InternalEndClause()
		/// </summary>
		protected RMethod r_MInternalEndClause;
		public virtual RMethod RMInternalEndClause
		{
			get
			{
				if(r_MInternalEndClause == null)
				{
					r_MInternalEndClause = new(this, "InternalEndClause", 0);
					r_MInternalEndClause.SetBelong(this.instance);
				}
				return r_MInternalEndClause;
			}
		}

		/// <summary>
		/// Void BeginCatchBlock(System.Type)
		/// </summary>
		protected RMethod r_MBeginCatchBlock_Type;
		public virtual RMethod RMBeginCatchBlock_Type
		{
			get
			{
				if(r_MBeginCatchBlock_Type == null)
				{
					r_MBeginCatchBlock_Type = new(this, "BeginCatchBlock", 0, typeof(System.Type));
					r_MBeginCatchBlock_Type.SetBelong(this.instance);
				}
				return r_MBeginCatchBlock_Type;
			}
		}

		/// <summary>
		/// Void BeginExceptFilterBlock()
		/// </summary>
		protected RMethod r_MBeginExceptFilterBlock;
		public virtual RMethod RMBeginExceptFilterBlock
		{
			get
			{
				if(r_MBeginExceptFilterBlock == null)
				{
					r_MBeginExceptFilterBlock = new(this, "BeginExceptFilterBlock", 0);
					r_MBeginExceptFilterBlock.SetBelong(this.instance);
				}
				return r_MBeginExceptFilterBlock;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.Label BeginExceptionBlock()
		/// </summary>
		protected RMethod r_MBeginExceptionBlock;
		public virtual RMethod RMBeginExceptionBlock
		{
			get
			{
				if(r_MBeginExceptionBlock == null)
				{
					r_MBeginExceptionBlock = new(this, "BeginExceptionBlock", 0);
					r_MBeginExceptionBlock.SetBelong(this.instance);
				}
				return r_MBeginExceptionBlock;
			}
		}

		/// <summary>
		/// Void BeginFaultBlock()
		/// </summary>
		protected RMethod r_MBeginFaultBlock;
		public virtual RMethod RMBeginFaultBlock
		{
			get
			{
				if(r_MBeginFaultBlock == null)
				{
					r_MBeginFaultBlock = new(this, "BeginFaultBlock", 0);
					r_MBeginFaultBlock.SetBelong(this.instance);
				}
				return r_MBeginFaultBlock;
			}
		}

		/// <summary>
		/// Void BeginFinallyBlock()
		/// </summary>
		protected RMethod r_MBeginFinallyBlock;
		public virtual RMethod RMBeginFinallyBlock
		{
			get
			{
				if(r_MBeginFinallyBlock == null)
				{
					r_MBeginFinallyBlock = new(this, "BeginFinallyBlock", 0);
					r_MBeginFinallyBlock.SetBelong(this.instance);
				}
				return r_MBeginFinallyBlock;
			}
		}

		/// <summary>
		/// Void BeginScope()
		/// </summary>
		protected RMethod r_MBeginScope;
		public virtual RMethod RMBeginScope
		{
			get
			{
				if(r_MBeginScope == null)
				{
					r_MBeginScope = new(this, "BeginScope", 0);
					r_MBeginScope.SetBelong(this.instance);
				}
				return r_MBeginScope;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.LocalBuilder DeclareLocal(System.Type)
		/// </summary>
		protected RMethod r_MDeclareLocal_Type;
		public virtual RMethod RMDeclareLocal_Type
		{
			get
			{
				if(r_MDeclareLocal_Type == null)
				{
					r_MDeclareLocal_Type = new(this, "DeclareLocal", 0, typeof(System.Type));
					r_MDeclareLocal_Type.SetBelong(this.instance);
				}
				return r_MDeclareLocal_Type;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.LocalBuilder DeclareLocal(System.Type, Boolean)
		/// </summary>
		protected RMethod r_MDeclareLocal_Type_Boolean;
		public virtual RMethod RMDeclareLocal_Type_Boolean
		{
			get
			{
				if(r_MDeclareLocal_Type_Boolean == null)
				{
					r_MDeclareLocal_Type_Boolean = new(this, "DeclareLocal", 0, typeof(System.Type), typeof(System.Boolean));
					r_MDeclareLocal_Type_Boolean.SetBelong(this.instance);
				}
				return r_MDeclareLocal_Type_Boolean;
			}
		}

		/// <summary>
		/// System.Reflection.Emit.Label DefineLabel()
		/// </summary>
		protected RMethod r_MDefineLabel;
		public virtual RMethod RMDefineLabel
		{
			get
			{
				if(r_MDefineLabel == null)
				{
					r_MDefineLabel = new(this, "DefineLabel", 0);
					r_MDefineLabel.SetBelong(this.instance);
				}
				return r_MDefineLabel;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode)
		/// </summary>
		protected RMethod r_MEmit_OpCode;
		public virtual RMethod RMEmit_OpCode
		{
			get
			{
				if(r_MEmit_OpCode == null)
				{
					r_MEmit_OpCode = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode));
					r_MEmit_OpCode.SetBelong(this.instance);
				}
				return r_MEmit_OpCode;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, Byte)
		/// </summary>
		protected RMethod r_MEmit_OpCode_Byte;
		public virtual RMethod RMEmit_OpCode_Byte
		{
			get
			{
				if(r_MEmit_OpCode_Byte == null)
				{
					r_MEmit_OpCode_Byte = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Byte));
					r_MEmit_OpCode_Byte.SetBelong(this.instance);
				}
				return r_MEmit_OpCode_Byte;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, System.Reflection.ConstructorInfo)
		/// </summary>
		protected RMethod r_MEmit_OpCode_ConstructorInfo;
		public virtual RMethod RMEmit_OpCode_ConstructorInfo
		{
			get
			{
				if(r_MEmit_OpCode_ConstructorInfo == null)
				{
					r_MEmit_OpCode_ConstructorInfo = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.ConstructorInfo));
					r_MEmit_OpCode_ConstructorInfo.SetBelong(this.instance);
				}
				return r_MEmit_OpCode_ConstructorInfo;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, Double)
		/// </summary>
		protected RMethod r_MEmit_OpCode_Double;
		public virtual RMethod RMEmit_OpCode_Double
		{
			get
			{
				if(r_MEmit_OpCode_Double == null)
				{
					r_MEmit_OpCode_Double = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Double));
					r_MEmit_OpCode_Double.SetBelong(this.instance);
				}
				return r_MEmit_OpCode_Double;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, System.Reflection.FieldInfo)
		/// </summary>
		protected RMethod r_MEmit_OpCode_FieldInfo;
		public virtual RMethod RMEmit_OpCode_FieldInfo
		{
			get
			{
				if(r_MEmit_OpCode_FieldInfo == null)
				{
					r_MEmit_OpCode_FieldInfo = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.FieldInfo));
					r_MEmit_OpCode_FieldInfo.SetBelong(this.instance);
				}
				return r_MEmit_OpCode_FieldInfo;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, Int16)
		/// </summary>
		protected RMethod r_MEmit_OpCode_Int16;
		public virtual RMethod RMEmit_OpCode_Int16
		{
			get
			{
				if(r_MEmit_OpCode_Int16 == null)
				{
					r_MEmit_OpCode_Int16 = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Int16));
					r_MEmit_OpCode_Int16.SetBelong(this.instance);
				}
				return r_MEmit_OpCode_Int16;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, Int32)
		/// </summary>
		protected RMethod r_MEmit_OpCode_Int32;
		public virtual RMethod RMEmit_OpCode_Int32
		{
			get
			{
				if(r_MEmit_OpCode_Int32 == null)
				{
					r_MEmit_OpCode_Int32 = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Int32));
					r_MEmit_OpCode_Int32.SetBelong(this.instance);
				}
				return r_MEmit_OpCode_Int32;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, Int64)
		/// </summary>
		protected RMethod r_MEmit_OpCode_Int64;
		public virtual RMethod RMEmit_OpCode_Int64
		{
			get
			{
				if(r_MEmit_OpCode_Int64 == null)
				{
					r_MEmit_OpCode_Int64 = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Int64));
					r_MEmit_OpCode_Int64.SetBelong(this.instance);
				}
				return r_MEmit_OpCode_Int64;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, System.Reflection.Emit.Label)
		/// </summary>
		protected RMethod r_MEmit_OpCode_Label;
		public virtual RMethod RMEmit_OpCode_Label
		{
			get
			{
				if(r_MEmit_OpCode_Label == null)
				{
					r_MEmit_OpCode_Label = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.Emit.Label));
					r_MEmit_OpCode_Label.SetBelong(this.instance);
				}
				return r_MEmit_OpCode_Label;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, System.Reflection.Emit.Label[])
		/// </summary>
		protected RMethod r_MEmit_OpCode_LabelArray;
		public virtual RMethod RMEmit_OpCode_LabelArray
		{
			get
			{
				if(r_MEmit_OpCode_LabelArray == null)
				{
					r_MEmit_OpCode_LabelArray = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.Emit.Label).MakeArrayType());
					r_MEmit_OpCode_LabelArray.SetBelong(this.instance);
				}
				return r_MEmit_OpCode_LabelArray;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, System.Reflection.Emit.LocalBuilder)
		/// </summary>
		protected RMethod r_MEmit_OpCode_LocalBuilder;
		public virtual RMethod RMEmit_OpCode_LocalBuilder
		{
			get
			{
				if(r_MEmit_OpCode_LocalBuilder == null)
				{
					r_MEmit_OpCode_LocalBuilder = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.Emit.LocalBuilder));
					r_MEmit_OpCode_LocalBuilder.SetBelong(this.instance);
				}
				return r_MEmit_OpCode_LocalBuilder;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_MEmit_OpCode_MethodInfo;
		public virtual RMethod RMEmit_OpCode_MethodInfo
		{
			get
			{
				if(r_MEmit_OpCode_MethodInfo == null)
				{
					r_MEmit_OpCode_MethodInfo = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.MethodInfo));
					r_MEmit_OpCode_MethodInfo.SetBelong(this.instance);
				}
				return r_MEmit_OpCode_MethodInfo;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, System.Reflection.MethodInfo, Int32)
		/// </summary>
		protected RMethod r_MEmit_OpCode_MethodInfo_Int32;
		public virtual RMethod RMEmit_OpCode_MethodInfo_Int32
		{
			get
			{
				if(r_MEmit_OpCode_MethodInfo_Int32 == null)
				{
					r_MEmit_OpCode_MethodInfo_Int32 = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.MethodInfo), typeof(System.Int32));
					r_MEmit_OpCode_MethodInfo_Int32.SetBelong(this.instance);
				}
				return r_MEmit_OpCode_MethodInfo_Int32;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, SByte)
		/// </summary>
		protected RMethod r_MEmit_OpCode_SByte;
		public virtual RMethod RMEmit_OpCode_SByte
		{
			get
			{
				if(r_MEmit_OpCode_SByte == null)
				{
					r_MEmit_OpCode_SByte = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.SByte));
					r_MEmit_OpCode_SByte.SetBelong(this.instance);
				}
				return r_MEmit_OpCode_SByte;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, System.Reflection.Emit.SignatureHelper)
		/// </summary>
		protected RMethod r_MEmit_OpCode_SignatureHelper;
		public virtual RMethod RMEmit_OpCode_SignatureHelper
		{
			get
			{
				if(r_MEmit_OpCode_SignatureHelper == null)
				{
					r_MEmit_OpCode_SignatureHelper = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.Emit.SignatureHelper));
					r_MEmit_OpCode_SignatureHelper.SetBelong(this.instance);
				}
				return r_MEmit_OpCode_SignatureHelper;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, Single)
		/// </summary>
		protected RMethod r_MEmit_OpCode_Single;
		public virtual RMethod RMEmit_OpCode_Single
		{
			get
			{
				if(r_MEmit_OpCode_Single == null)
				{
					r_MEmit_OpCode_Single = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Single));
					r_MEmit_OpCode_Single.SetBelong(this.instance);
				}
				return r_MEmit_OpCode_Single;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, System.String)
		/// </summary>
		protected RMethod r_MEmit_OpCode_String;
		public virtual RMethod RMEmit_OpCode_String
		{
			get
			{
				if(r_MEmit_OpCode_String == null)
				{
					r_MEmit_OpCode_String = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.String));
					r_MEmit_OpCode_String.SetBelong(this.instance);
				}
				return r_MEmit_OpCode_String;
			}
		}

		/// <summary>
		/// Void Emit(System.Reflection.Emit.OpCode, System.Type)
		/// </summary>
		protected RMethod r_MEmit_OpCode_Type;
		public virtual RMethod RMEmit_OpCode_Type
		{
			get
			{
				if(r_MEmit_OpCode_Type == null)
				{
					r_MEmit_OpCode_Type = new(this, "Emit", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Type));
					r_MEmit_OpCode_Type.SetBelong(this.instance);
				}
				return r_MEmit_OpCode_Type;
			}
		}

		/// <summary>
		/// Void EmitCall(System.Reflection.Emit.OpCode, System.Reflection.MethodInfo, System.Type[])
		/// </summary>
		protected RMethod r_MEmitCall_OpCode_MethodInfo_TypeArray;
		public virtual RMethod RMEmitCall_OpCode_MethodInfo_TypeArray
		{
			get
			{
				if(r_MEmitCall_OpCode_MethodInfo_TypeArray == null)
				{
					r_MEmitCall_OpCode_MethodInfo_TypeArray = new(this, "EmitCall", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.MethodInfo), typeof(System.Type).MakeArrayType());
					r_MEmitCall_OpCode_MethodInfo_TypeArray.SetBelong(this.instance);
				}
				return r_MEmitCall_OpCode_MethodInfo_TypeArray;
			}
		}

		/// <summary>
		/// Void EmitCalli(System.Reflection.Emit.OpCode, System.Runtime.InteropServices.CallingConvention, System.Type, System.Type[])
		/// </summary>
		protected RMethod r_MEmitCalli_OpCode_CallingConvention_Type_TypeArray;
		public virtual RMethod RMEmitCalli_OpCode_CallingConvention_Type_TypeArray
		{
			get
			{
				if(r_MEmitCalli_OpCode_CallingConvention_Type_TypeArray == null)
				{
					r_MEmitCalli_OpCode_CallingConvention_Type_TypeArray = new(this, "EmitCalli", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Runtime.InteropServices.CallingConvention), typeof(System.Type), typeof(System.Type).MakeArrayType());
					r_MEmitCalli_OpCode_CallingConvention_Type_TypeArray.SetBelong(this.instance);
				}
				return r_MEmitCalli_OpCode_CallingConvention_Type_TypeArray;
			}
		}

		/// <summary>
		/// Void EmitCalli(System.Reflection.Emit.OpCode, System.Reflection.CallingConventions, System.Type, System.Type[], System.Type[])
		/// </summary>
		protected RMethod r_MEmitCalli_OpCode_CallingConventions_Type_TypeArray_TypeArray;
		public virtual RMethod RMEmitCalli_OpCode_CallingConventions_Type_TypeArray_TypeArray
		{
			get
			{
				if(r_MEmitCalli_OpCode_CallingConventions_Type_TypeArray_TypeArray == null)
				{
					r_MEmitCalli_OpCode_CallingConventions_Type_TypeArray_TypeArray = new(this, "EmitCalli", 0, typeof(System.Reflection.Emit.OpCode), typeof(System.Reflection.CallingConventions), typeof(System.Type), typeof(System.Type).MakeArrayType(), typeof(System.Type).MakeArrayType());
					r_MEmitCalli_OpCode_CallingConventions_Type_TypeArray_TypeArray.SetBelong(this.instance);
				}
				return r_MEmitCalli_OpCode_CallingConventions_Type_TypeArray_TypeArray;
			}
		}

		/// <summary>
		/// Void EmitWriteLine(System.Reflection.FieldInfo)
		/// </summary>
		protected RMethod r_MEmitWriteLine_FieldInfo;
		public virtual RMethod RMEmitWriteLine_FieldInfo
		{
			get
			{
				if(r_MEmitWriteLine_FieldInfo == null)
				{
					r_MEmitWriteLine_FieldInfo = new(this, "EmitWriteLine", 0, typeof(System.Reflection.FieldInfo));
					r_MEmitWriteLine_FieldInfo.SetBelong(this.instance);
				}
				return r_MEmitWriteLine_FieldInfo;
			}
		}

		/// <summary>
		/// Void EmitWriteLine(System.Reflection.Emit.LocalBuilder)
		/// </summary>
		protected RMethod r_MEmitWriteLine_LocalBuilder;
		public virtual RMethod RMEmitWriteLine_LocalBuilder
		{
			get
			{
				if(r_MEmitWriteLine_LocalBuilder == null)
				{
					r_MEmitWriteLine_LocalBuilder = new(this, "EmitWriteLine", 0, typeof(System.Reflection.Emit.LocalBuilder));
					r_MEmitWriteLine_LocalBuilder.SetBelong(this.instance);
				}
				return r_MEmitWriteLine_LocalBuilder;
			}
		}

		/// <summary>
		/// Void EmitWriteLine(System.String)
		/// </summary>
		protected RMethod r_MEmitWriteLine_String;
		public virtual RMethod RMEmitWriteLine_String
		{
			get
			{
				if(r_MEmitWriteLine_String == null)
				{
					r_MEmitWriteLine_String = new(this, "EmitWriteLine", 0, typeof(System.String));
					r_MEmitWriteLine_String.SetBelong(this.instance);
				}
				return r_MEmitWriteLine_String;
			}
		}

		/// <summary>
		/// Void EndExceptionBlock()
		/// </summary>
		protected RMethod r_MEndExceptionBlock;
		public virtual RMethod RMEndExceptionBlock
		{
			get
			{
				if(r_MEndExceptionBlock == null)
				{
					r_MEndExceptionBlock = new(this, "EndExceptionBlock", 0);
					r_MEndExceptionBlock.SetBelong(this.instance);
				}
				return r_MEndExceptionBlock;
			}
		}

		/// <summary>
		/// Void EndScope()
		/// </summary>
		protected RMethod r_MEndScope;
		public virtual RMethod RMEndScope
		{
			get
			{
				if(r_MEndScope == null)
				{
					r_MEndScope = new(this, "EndScope", 0);
					r_MEndScope.SetBelong(this.instance);
				}
				return r_MEndScope;
			}
		}

		/// <summary>
		/// Void MarkLabel(System.Reflection.Emit.Label)
		/// </summary>
		protected RMethod r_MMarkLabel_Label;
		public virtual RMethod RMMarkLabel_Label
		{
			get
			{
				if(r_MMarkLabel_Label == null)
				{
					r_MMarkLabel_Label = new(this, "MarkLabel", 0, typeof(System.Reflection.Emit.Label));
					r_MMarkLabel_Label.SetBelong(this.instance);
				}
				return r_MMarkLabel_Label;
			}
		}

		/// <summary>
		/// Void MarkSequencePoint(System.Diagnostics.SymbolStore.ISymbolDocumentWriter, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MMarkSequencePoint_ISymbolDocumentWriter_Int32_Int32_Int32_Int32;
		public virtual RMethod RMMarkSequencePoint_ISymbolDocumentWriter_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MMarkSequencePoint_ISymbolDocumentWriter_Int32_Int32_Int32_Int32 == null)
				{
					r_MMarkSequencePoint_ISymbolDocumentWriter_Int32_Int32_Int32_Int32 = new(this, "MarkSequencePoint", 0, typeof(System.Diagnostics.SymbolStore.ISymbolDocumentWriter), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MMarkSequencePoint_ISymbolDocumentWriter_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_MMarkSequencePoint_ISymbolDocumentWriter_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GenerateDebugInfo(System.Diagnostics.SymbolStore.ISymbolWriter)
		/// </summary>
		protected RMethod r_MGenerateDebugInfo_ISymbolWriter;
		public virtual RMethod RMGenerateDebugInfo_ISymbolWriter
		{
			get
			{
				if(r_MGenerateDebugInfo_ISymbolWriter == null)
				{
					r_MGenerateDebugInfo_ISymbolWriter = new(this, "GenerateDebugInfo", 0, typeof(System.Diagnostics.SymbolStore.ISymbolWriter));
					r_MGenerateDebugInfo_ISymbolWriter.SetBelong(this.instance);
				}
				return r_MGenerateDebugInfo_ISymbolWriter;
			}
		}

		/// <summary>
		/// Void ThrowException(System.Type)
		/// </summary>
		protected RMethod r_MThrowException_Type;
		public virtual RMethod RMThrowException_Type
		{
			get
			{
				if(r_MThrowException_Type == null)
				{
					r_MThrowException_Type = new(this, "ThrowException", 0, typeof(System.Type));
					r_MThrowException_Type.SetBelong(this.instance);
				}
				return r_MThrowException_Type;
			}
		}

		/// <summary>
		/// Void UsingNamespace(System.String)
		/// </summary>
		protected RMethod r_MUsingNamespace_String;
		public virtual RMethod RMUsingNamespace_String
		{
			get
			{
				if(r_MUsingNamespace_String == null)
				{
					r_MUsingNamespace_String = new(this, "UsingNamespace", 0, typeof(System.String));
					r_MUsingNamespace_String.SetBelong(this.instance);
				}
				return r_MUsingNamespace_String;
			}
		}

		/// <summary>
		/// Void label_fixup(System.Reflection.MethodBase)
		/// </summary>
		protected RMethod r_Mlabel_fixup_MethodBase;
		public virtual RMethod RMlabel_fixup_MethodBase
		{
			get
			{
				if(r_Mlabel_fixup_MethodBase == null)
				{
					r_Mlabel_fixup_MethodBase = new(this, "label_fixup", 0, typeof(System.Reflection.MethodBase));
					r_Mlabel_fixup_MethodBase.SetBelong(this.instance);
				}
				return r_Mlabel_fixup_MethodBase;
			}
		}

		/// <summary>
		/// Void FixupTokens(System.Collections.Generic.Dictionary`2[System.Int32,System.Int32], System.Collections.Generic.Dictionary`2[System.Int32,System.Reflection.MemberInfo])
		/// </summary>
		protected RMethod r_MFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_;
		public virtual RMethod RMFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_
		{
			get
			{
				if(r_MFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_ == null)
				{
					r_MFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_ = new(this, "FixupTokens", 0, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32), typeof(System.Int32)), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32), typeof(System.Reflection.MemberInfo)));
					r_MFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_.SetBelong(this.instance);
				}
				return r_MFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_;
			}
		}

		/// <summary>
		/// Void SetExceptionHandlers(System.Reflection.Emit.ILExceptionInfo[])
		/// </summary>
		protected RMethod r_MSetExceptionHandlers_ILExceptionInfoArray;
		public virtual RMethod RMSetExceptionHandlers_ILExceptionInfoArray
		{
			get
			{
				if(r_MSetExceptionHandlers_ILExceptionInfoArray == null)
				{
					r_MSetExceptionHandlers_ILExceptionInfoArray = new(this, "SetExceptionHandlers", 0,  ReflectionUtils.GetType("System.Reflection.Emit.ILExceptionInfo").MakeArrayType());
					r_MSetExceptionHandlers_ILExceptionInfoArray.SetBelong(this.instance);
				}
				return r_MSetExceptionHandlers_ILExceptionInfoArray;
			}
		}

		/// <summary>
		/// Void SetTokenFixups(System.Reflection.Emit.ILTokenInfo[])
		/// </summary>
		protected RMethod r_MSetTokenFixups_ILTokenInfoArray;
		public virtual RMethod RMSetTokenFixups_ILTokenInfoArray
		{
			get
			{
				if(r_MSetTokenFixups_ILTokenInfoArray == null)
				{
					r_MSetTokenFixups_ILTokenInfoArray = new(this, "SetTokenFixups", 0,  ReflectionUtils.GetType("System.Reflection.Emit.ILTokenInfo").MakeArrayType());
					r_MSetTokenFixups_ILTokenInfoArray.SetBelong(this.instance);
				}
				return r_MSetTokenFixups_ILTokenInfoArray;
			}
		}

		/// <summary>
		/// Void SetCode(Byte[], Int32)
		/// </summary>
		protected RMethod r_MSetCode_ByteArray_Int32;
		public virtual RMethod RMSetCode_ByteArray_Int32
		{
			get
			{
				if(r_MSetCode_ByteArray_Int32 == null)
				{
					r_MSetCode_ByteArray_Int32 = new(this, "SetCode", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_MSetCode_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_MSetCode_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Void SetCode(Byte*, Int32, Int32)
		/// </summary>
		protected RMethod r_MSetCode_BytePointer_Int32_Int32;
		public virtual RMethod RMSetCode_BytePointer_Int32_Int32
		{
			get
			{
				if(r_MSetCode_BytePointer_Int32_Int32 == null)
				{
					r_MSetCode_BytePointer_Int32_Int32 = new(this, "SetCode", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Int32));
					r_MSetCode_BytePointer_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSetCode_BytePointer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Init(Byte[], Int32, Byte[], System.Collections.Generic.IEnumerable`1[System.Reflection.Emit.ExceptionHandler], System.Collections.Generic.IEnumerable`1[System.Int32])
		/// </summary>
		protected RMethod r_MInit_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_;
		public virtual RMethod RMInit_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_
		{
			get
			{
				if(r_MInit_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_ == null)
				{
					r_MInit_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_ = new(this, "Init", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Reflection.Emit.ExceptionHandler)), typeof(System.Collections.Generic.IEnumerable<>).MakeGenericType(typeof(System.Int32)));
					r_MInit_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_.SetBelong(this.instance);
				}
				return r_MInit_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_;
			}
		}

		/// <summary>
		/// Int32 Mono_GetCurrentOffset(System.Reflection.Emit.ILGenerator)
		/// </summary>
		protected static RMethod r_MMono_GetCurrentOffset_ILGenerator;
		public static RMethod RMMono_GetCurrentOffset_ILGenerator
		{
			get
			{
				if(r_MMono_GetCurrentOffset_ILGenerator == null)
				{
					r_MMono_GetCurrentOffset_ILGenerator = new(typeof(System.Reflection.Emit.ILGenerator), "Mono_GetCurrentOffset", 0, typeof(System.Reflection.Emit.ILGenerator));
					r_MMono_GetCurrentOffset_ILGenerator.SetBelong(null);
				}
				return r_MMono_GetCurrentOffset_ILGenerator;
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
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetIDsOfNames_In_Guid_IntPtr_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfo(System.UInt32 @iTInfo, System.UInt32 @lcid, System.IntPtr @ppTInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iTInfo, @lcid, @ppTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfo_UInt32_UInt32_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfoCount(out System.UInt32 @pcTInfo)
        {
			@pcTInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pcTInfo};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__GetTypeInfoCount_Out_UInt32.Invoke(___genericsType, ___parameters);
			@pcTInfo = (System.UInt32)___parameters[0];

            
        }


        public virtual void System__2__Runtime__2__InteropServices__2___ILGenerator__2__Invoke(System.UInt32 @dispIdMember, in System.Guid @riid, System.UInt32 @lcid, System.Int16 @wFlags, System.IntPtr @pDispParams, System.IntPtr @pVarResult, System.IntPtr @pExcepInfo, System.IntPtr @puArgErr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dispIdMember, @riid, @lcid, @wFlags, @pDispParams, @pVarResult, @pExcepInfo, @puArgErr};
            var ___result = RMSystem__2__Runtime__2__InteropServices__2___ILGenerator__2__Invoke_UInt32_In_Guid_UInt32_Int16_IntPtr_IntPtr_IntPtr_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void add_token_fixup(System.Reflection.MemberInfo @mi)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mi};
            var ___result = RMadd_token_fixup_MemberInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void make_room(System.Int32 @nbytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nbytes};
            var ___result = RMmake_room_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void emit_int(System.Int32 @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val};
            var ___result = RMemit_int_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ll_emit(System.Reflection.Emit.OpCode @opcode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode};
            var ___result = RMll_emit_OpCode.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 target_len(System.Reflection.Emit.OpCode @opcode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode};
            var ___result = RMtarget_len_OpCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void InternalEndClause()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalEndClause.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginCatchBlock(System.Type @exceptionType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exceptionType};
            var ___result = RMBeginCatchBlock_Type.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginExceptFilterBlock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBeginExceptFilterBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.Label BeginExceptionBlock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBeginExceptionBlock.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.Label)___result;
        }


        public virtual void BeginFaultBlock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBeginFaultBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginFinallyBlock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBeginFinallyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeginScope()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBeginScope.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.Emit.LocalBuilder DeclareLocal(System.Type @localType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localType};
            var ___result = RMDeclareLocal_Type.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.LocalBuilder)___result;
        }


        public virtual System.Reflection.Emit.LocalBuilder DeclareLocal(System.Type @localType, System.Boolean @pinned)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localType, @pinned};
            var ___result = RMDeclareLocal_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.LocalBuilder)___result;
        }


        public virtual System.Reflection.Emit.Label DefineLabel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDefineLabel.Invoke(___genericsType, ___parameters);

            return (System.Reflection.Emit.Label)___result;
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode};
            var ___result = RMEmit_OpCode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Byte @arg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @arg};
            var ___result = RMEmit_OpCode_Byte.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Reflection.ConstructorInfo @con)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @con};
            var ___result = RMEmit_OpCode_ConstructorInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Double @arg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @arg};
            var ___result = RMEmit_OpCode_Double.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Reflection.FieldInfo @field)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @field};
            var ___result = RMEmit_OpCode_FieldInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Int16 @arg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @arg};
            var ___result = RMEmit_OpCode_Int16.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Int32 @arg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @arg};
            var ___result = RMEmit_OpCode_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Int64 @arg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @arg};
            var ___result = RMEmit_OpCode_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Reflection.Emit.Label @label)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @label};
            var ___result = RMEmit_OpCode_Label.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Reflection.Emit.Label[] @labels)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @labels};
            var ___result = RMEmit_OpCode_LabelArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Reflection.Emit.LocalBuilder @local)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @local};
            var ___result = RMEmit_OpCode_LocalBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Reflection.MethodInfo @meth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @meth};
            var ___result = RMEmit_OpCode_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Reflection.MethodInfo @method, System.Int32 @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @method, @token};
            var ___result = RMEmit_OpCode_MethodInfo_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.SByte @arg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @arg};
            var ___result = RMEmit_OpCode_SByte.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Reflection.Emit.SignatureHelper @signature)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @signature};
            var ___result = RMEmit_OpCode_SignatureHelper.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Single @arg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @arg};
            var ___result = RMEmit_OpCode_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.String @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @str};
            var ___result = RMEmit_OpCode_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Emit(System.Reflection.Emit.OpCode @opcode, System.Type @cls)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @cls};
            var ___result = RMEmit_OpCode_Type.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EmitCall(System.Reflection.Emit.OpCode @opcode, System.Reflection.MethodInfo @methodInfo, System.Type[] @optionalParameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @methodInfo, @optionalParameterTypes};
            var ___result = RMEmitCall_OpCode_MethodInfo_TypeArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EmitCalli(System.Reflection.Emit.OpCode @opcode, System.Runtime.InteropServices.CallingConvention @unmanagedCallConv, System.Type @returnType, System.Type[] @parameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @unmanagedCallConv, @returnType, @parameterTypes};
            var ___result = RMEmitCalli_OpCode_CallingConvention_Type_TypeArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EmitCalli(System.Reflection.Emit.OpCode @opcode, System.Reflection.CallingConventions @callingConvention, System.Type @returnType, System.Type[] @parameterTypes, System.Type[] @optionalParameterTypes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@opcode, @callingConvention, @returnType, @parameterTypes, @optionalParameterTypes};
            var ___result = RMEmitCalli_OpCode_CallingConventions_Type_TypeArray_TypeArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EmitWriteLine(System.Reflection.FieldInfo @fld)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fld};
            var ___result = RMEmitWriteLine_FieldInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EmitWriteLine(System.Reflection.Emit.LocalBuilder @localBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localBuilder};
            var ___result = RMEmitWriteLine_LocalBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EmitWriteLine(System.String @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMEmitWriteLine_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndExceptionBlock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEndExceptionBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndScope()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEndScope.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkLabel(System.Reflection.Emit.Label @loc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@loc};
            var ___result = RMMarkLabel_Label.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkSequencePoint(System.Diagnostics.SymbolStore.ISymbolDocumentWriter @document, System.Int32 @startLine, System.Int32 @startColumn, System.Int32 @endLine, System.Int32 @endColumn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@document, @startLine, @startColumn, @endLine, @endColumn};
            var ___result = RMMarkSequencePoint_ISymbolDocumentWriter_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GenerateDebugInfo(System.Diagnostics.SymbolStore.ISymbolWriter @symbolWriter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@symbolWriter};
            var ___result = RMGenerateDebugInfo_ISymbolWriter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowException(System.Type @excType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@excType};
            var ___result = RMThrowException_Type.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UsingNamespace(System.String @usingNamespace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@usingNamespace};
            var ___result = RMUsingNamespace_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void label_fixup(System.Reflection.MethodBase @mb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mb};
            var ___result = RMlabel_fixup_MethodBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FixupTokens(System.Collections.Generic.Dictionary<System.Int32, System.Int32> @token_map, System.Collections.Generic.Dictionary<System.Int32, System.Reflection.MemberInfo> @member_map)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token_map, @member_map};
            var ___result = RMFixupTokens_Dictionary_d_Int32_Int32_p__Dictionary_d_Int32_MemberInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetExceptionHandlers(SMFrame.Editor.Refleaction.RTypeArray<SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RILExceptionInfo> @exHandlers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exHandlers.Value};
            var ___result = RMSetExceptionHandlers_ILExceptionInfoArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTokenFixups(SMFrame.Editor.Refleaction.RTypeArray<SMFrame.Editor.Refleaction.RSystem.RReflection.REmit.RILTokenInfo> @tokenFixups)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tokenFixups.Value};
            var ___result = RMSetTokenFixups_ILTokenInfoArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCode(System.Byte[] @code, System.Int32 @max_stack)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@code, @max_stack};
            var ___result = RMSetCode_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public unsafe virtual void SetCode(System.Byte* @code, System.Int32 @code_size, System.Int32 @max_stack)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{Pointer.Box(@code, typeof(System.Byte)), @code_size, @max_stack};
            var ___result = RMSetCode_BytePointer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Init(System.Byte[] @il, System.Int32 @maxStack, System.Byte[] @localSignature, System.Collections.Generic.IEnumerable<System.Reflection.Emit.ExceptionHandler> @exceptionHandlers, System.Collections.Generic.IEnumerable<System.Int32> @tokenFixups)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@il, @maxStack, @localSignature, @exceptionHandlers, @tokenFixups};
            var ___result = RMInit_ByteArray_Int32_ByteArray_IEnumerable_d_ExceptionHandler_p__IEnumerable_d_Int32_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Int32 Mono_GetCurrentOffset(System.Reflection.Emit.ILGenerator @ig)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ig};
            var ___result = RMMono_GetCurrentOffset_ILGenerator.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
