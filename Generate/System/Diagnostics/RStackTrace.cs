using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RDiagnostics
{
	/// <summary>
	/// System.Diagnostics.StackTrace
	/// </summary>
    public partial class RStackTrace : RMember //
    {

		/// <summary>
		/// System.Int32 METHODS_TO_SKIP
		/// </summary>
		protected static RField r_METHODS_TO_SKIP;
		public static RField RMETHODS_TO_SKIP
		{
			get
			{
				if(r_METHODS_TO_SKIP == null)
				{
					r_METHODS_TO_SKIP = new(typeof(System.Diagnostics.StackTrace), "METHODS_TO_SKIP");
					r_METHODS_TO_SKIP.SetBelong(null);
				}
				return r_METHODS_TO_SKIP;
			}
		}

		/// <summary>
		/// System.String prefix
		/// </summary>
		protected static RField r_prefix;
		public static RField Rprefix
		{
			get
			{
				if(r_prefix == null)
				{
					r_prefix = new(typeof(System.Diagnostics.StackTrace), "prefix");
					r_prefix.SetBelong(null);
				}
				return r_prefix;
			}
		}

		/// <summary>
		/// System.Diagnostics.StackFrame[] frames
		/// </summary>
		protected RFieldArray<RSystem.RDiagnostics.RStackFrame> r_frames;
		public virtual RFieldArray<RSystem.RDiagnostics.RStackFrame> Rframes
		{
			get
			{
				if(r_frames == null)
				{
					r_frames = new(this, "frames");
					r_frames.SetBelong(this.instance);
				}
				return r_frames;
			}
		}

		/// <summary>
		/// System.Diagnostics.StackTrace[] captured_traces
		/// </summary>
		protected RFieldArray<RSystem.RDiagnostics.RStackTrace> r_captured_traces;
		public virtual RFieldArray<RSystem.RDiagnostics.RStackTrace> Rcaptured_traces
		{
			get
			{
				if(r_captured_traces == null)
				{
					r_captured_traces = new(this, "captured_traces");
					r_captured_traces.SetBelong(this.instance);
				}
				return r_captured_traces;
			}
		}

		/// <summary>
		/// System.Boolean debug_info
		/// </summary>
		protected RField r_debug_info;
		public virtual RField Rdebug_info
		{
			get
			{
				if(r_debug_info == null)
				{
					r_debug_info = new(this, "debug_info");
					r_debug_info.SetBelong(this.instance);
				}
				return r_debug_info;
			}
		}

		/// <summary>
		/// System.Boolean isAotidSet
		/// </summary>
		protected static RField r_isAotidSet;
		public static RField RisAotidSet
		{
			get
			{
				if(r_isAotidSet == null)
				{
					r_isAotidSet = new(typeof(System.Diagnostics.StackTrace), "isAotidSet");
					r_isAotidSet.SetBelong(null);
				}
				return r_isAotidSet;
			}
		}

		/// <summary>
		/// System.String aotid
		/// </summary>
		protected static RField r_aotid;
		public static RField Raotid
		{
			get
			{
				if(r_aotid == null)
				{
					r_aotid = new(typeof(System.Diagnostics.StackTrace), "aotid");
					r_aotid.SetBelong(null);
				}
				return r_aotid;
			}
		}

		/// <summary>
		/// Int32 FrameCount
		/// </summary>
		protected RProperty r_FrameCount;
		public virtual RProperty RFrameCount
		{
			get
			{
				if(r_FrameCount == null)
				{
					r_FrameCount = new(this, "FrameCount", -1);
					r_FrameCount.SetBelong(this.instance);
				}
				return r_FrameCount;
			}
		}

		/// <summary>
		/// Void init_frames(Int32, Boolean)
		/// </summary>
		protected RMethod r_Rinit_frames_Int32_Boolean;
		public virtual RMethod Rinit_frames_Int32_Boolean
		{
			get
			{
				if(r_Rinit_frames_Int32_Boolean == null)
				{
					r_Rinit_frames_Int32_Boolean = new(this, "init_frames", 0, typeof(System.Int32), typeof(System.Boolean));
					r_Rinit_frames_Int32_Boolean.SetBelong(this.instance);
				}
				return r_Rinit_frames_Int32_Boolean;
			}
		}

		/// <summary>
		/// System.Diagnostics.StackFrame[] get_trace(System.Exception, Int32, Boolean)
		/// </summary>
		protected static RMethod r_Rget_trace_Exception_Int32_Boolean;
		public static RMethod Rget_trace_Exception_Int32_Boolean
		{
			get
			{
				if(r_Rget_trace_Exception_Int32_Boolean == null)
				{
					r_Rget_trace_Exception_Int32_Boolean = new(typeof(System.Diagnostics.StackTrace), "get_trace", 0, typeof(System.Exception), typeof(System.Int32), typeof(System.Boolean));
					r_Rget_trace_Exception_Int32_Boolean.SetBelong(null);
				}
				return r_Rget_trace_Exception_Int32_Boolean;
			}
		}

		/// <summary>
		/// System.Diagnostics.StackFrame GetFrame(Int32)
		/// </summary>
		protected RMethod r_RGetFrame_Int32;
		public virtual RMethod RGetFrame_Int32
		{
			get
			{
				if(r_RGetFrame_Int32 == null)
				{
					r_RGetFrame_Int32 = new(this, "GetFrame", 0, typeof(System.Int32));
					r_RGetFrame_Int32.SetBelong(this.instance);
				}
				return r_RGetFrame_Int32;
			}
		}

		/// <summary>
		/// System.Diagnostics.StackFrame[] GetFrames()
		/// </summary>
		protected RMethod r_RGetFrames;
		public virtual RMethod RGetFrames
		{
			get
			{
				if(r_RGetFrames == null)
				{
					r_RGetFrames = new(this, "GetFrames", 0);
					r_RGetFrames.SetBelong(this.instance);
				}
				return r_RGetFrames;
			}
		}

		/// <summary>
		/// System.String GetAotId()
		/// </summary>
		protected static RMethod r_RGetAotId;
		public static RMethod RGetAotId
		{
			get
			{
				if(r_RGetAotId == null)
				{
					r_RGetAotId = new(typeof(System.Diagnostics.StackTrace), "GetAotId", 0);
					r_RGetAotId.SetBelong(null);
				}
				return r_RGetAotId;
			}
		}

		/// <summary>
		/// Boolean AddFrames(System.Text.StringBuilder, Boolean, Boolean ByRef)
		/// </summary>
		protected RMethod r_RAddFrames_StringBuilder_Boolean_Out_Boolean;
		public virtual RMethod RAddFrames_StringBuilder_Boolean_Out_Boolean
		{
			get
			{
				if(r_RAddFrames_StringBuilder_Boolean_Out_Boolean == null)
				{
					r_RAddFrames_StringBuilder_Boolean_Out_Boolean = new(this, "AddFrames", 0, typeof(System.Text.StringBuilder), typeof(System.Boolean), typeof(System.Boolean).MakeByRefType());
					r_RAddFrames_StringBuilder_Boolean_Out_Boolean.SetBelong(this.instance);
				}
				return r_RAddFrames_StringBuilder_Boolean_Out_Boolean;
			}
		}

		/// <summary>
		/// Void GetFullNameForStackTrace(System.Text.StringBuilder, System.Reflection.MethodBase, Boolean, Boolean ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_RGetFullNameForStackTrace_StringBuilder_MethodBase_Boolean_Out_Boolean_Out_Boolean;
		public virtual RMethod RGetFullNameForStackTrace_StringBuilder_MethodBase_Boolean_Out_Boolean_Out_Boolean
		{
			get
			{
				if(r_RGetFullNameForStackTrace_StringBuilder_MethodBase_Boolean_Out_Boolean_Out_Boolean == null)
				{
					r_RGetFullNameForStackTrace_StringBuilder_MethodBase_Boolean_Out_Boolean_Out_Boolean = new(this, "GetFullNameForStackTrace", 0, typeof(System.Text.StringBuilder), typeof(System.Reflection.MethodBase), typeof(System.Boolean), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_RGetFullNameForStackTrace_StringBuilder_MethodBase_Boolean_Out_Boolean_Out_Boolean.SetBelong(this.instance);
				}
				return r_RGetFullNameForStackTrace_StringBuilder_MethodBase_Boolean_Out_Boolean_Out_Boolean;
			}
		}

		/// <summary>
		/// Void ConvertAsyncStateMachineMethod(System.Reflection.MethodBase ByRef, System.Type ByRef)
		/// </summary>
		protected static RMethod r_RConvertAsyncStateMachineMethod_Ref_MethodBase_Ref_Type;
		public static RMethod RConvertAsyncStateMachineMethod_Ref_MethodBase_Ref_Type
		{
			get
			{
				if(r_RConvertAsyncStateMachineMethod_Ref_MethodBase_Ref_Type == null)
				{
					r_RConvertAsyncStateMachineMethod_Ref_MethodBase_Ref_Type = new(typeof(System.Diagnostics.StackTrace), "ConvertAsyncStateMachineMethod", 0, typeof(System.Reflection.MethodBase).MakeByRefType(), typeof(System.Type).MakeByRefType());
					r_RConvertAsyncStateMachineMethod_Ref_MethodBase_Ref_Type.SetBelong(null);
				}
				return r_RConvertAsyncStateMachineMethod_Ref_MethodBase_Ref_Type;
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
		/// System.String ToString(TraceFormat)
		/// </summary>
		protected RMethod r_RToString_TraceFormat;
		public virtual RMethod RToString_TraceFormat
		{
			get
			{
				if(r_RToString_TraceFormat == null)
				{
					r_RToString_TraceFormat = new(this, "ToString", 0,  ReleactionUtils.GetType("System.Diagnostics.StackTrace+TraceFormat"));
					r_RToString_TraceFormat.SetBelong(this.instance);
				}
				return r_RToString_TraceFormat;
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


        public RStackTrace() : base("System.Diagnostics.StackTrace")
        {
        }

        public RStackTrace(System.Object instance) : base("System.Diagnostics.StackTrace")
		{
            SetInstance(instance);
		}

        public RStackTrace(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStackTrace(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void init_frames(System.Int32  @skipFrames, System.Boolean  @fNeedFileInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@skipFrames, @fNeedFileInfo};
            var ___result = Rinit_frames_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Diagnostics.StackFrame[] get_trace(System.Exception  @e, System.Int32  @skipFrames, System.Boolean  @fNeedFileInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @skipFrames, @fNeedFileInfo};
            var ___result = Rget_trace_Exception_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Diagnostics.StackFrame[])___result;
        }


        public virtual System.Diagnostics.StackFrame GetFrame(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetFrame_Int32.Invoke(___genericsType, ___parameters);

            return (System.Diagnostics.StackFrame)___result;
        }


        public virtual System.Diagnostics.StackFrame[] GetFrames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetFrames.Invoke(___genericsType, ___parameters);

            return (System.Diagnostics.StackFrame[])___result;
        }


        public static System.String GetAotId()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAotId.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean AddFrames(System.Text.StringBuilder  @sb, System.Boolean  @separator, out System.Boolean  @isAsync)
        {
			isAsync = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sb, @separator, @isAsync};
            var ___result = RAddFrames_StringBuilder_Boolean_Out_Boolean.Invoke(___genericsType, ___parameters);
			isAsync = (System.Boolean)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual void GetFullNameForStackTrace(System.Text.StringBuilder  @sb, System.Reflection.MethodBase  @mi, System.Boolean  @needsNewLine, out System.Boolean  @skipped, out System.Boolean  @isAsync)
        {
			skipped = default;
			isAsync = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sb, @mi, @needsNewLine, @skipped, @isAsync};
            var ___result = RGetFullNameForStackTrace_StringBuilder_MethodBase_Boolean_Out_Boolean_Out_Boolean.Invoke(___genericsType, ___parameters);
			skipped = (System.Boolean)___parameters[3];
			isAsync = (System.Boolean)___parameters[4];

            
        }


        public static void ConvertAsyncStateMachineMethod(ref System.Reflection.MethodBase  @method, ref System.Type  @declaringType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method, @declaringType};
            var ___result = RConvertAsyncStateMachineMethod_Ref_MethodBase_Ref_Type.Invoke(___genericsType, ___parameters);
			method = (System.Reflection.MethodBase)___parameters[0];
			declaringType = (System.Type)___parameters[1];

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }



        public virtual System.Boolean Equals(System.Object  @obj)
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


    }
}
