
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
		protected static SMFrame.Editor.Refleaction.RSystem.RInt32 r_FMETHODS_TO_SKIP;
		public static SMFrame.Editor.Refleaction.RSystem.RInt32 RFMETHODS_TO_SKIP
		{
			get
			{
				if(r_FMETHODS_TO_SKIP == null)
				{
					r_FMETHODS_TO_SKIP = new(typeof(System.Diagnostics.StackTrace), "METHODS_TO_SKIP");
					r_FMETHODS_TO_SKIP.SetBelong(null);
				}
				return r_FMETHODS_TO_SKIP;
			}
		}

		/// <summary>
		/// System.String prefix
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RString r_Fprefix;
		public static SMFrame.Editor.Refleaction.RSystem.RString RFprefix
		{
			get
			{
				if(r_Fprefix == null)
				{
					r_Fprefix = new(typeof(System.Diagnostics.StackTrace), "prefix");
					r_Fprefix.SetBelong(null);
				}
				return r_Fprefix;
			}
		}

		/// <summary>
		/// System.Diagnostics.StackFrame[] frames
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RDiagnostics.RStackFrame> r_Fframes;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RDiagnostics.RStackFrame> RFframes
		{
			get
			{
				if(r_Fframes == null)
				{
					r_Fframes = new(this, "frames");
					r_Fframes.SetBelong(this.instance);
				}
				return r_Fframes;
			}
		}

		/// <summary>
		/// System.Diagnostics.StackTrace[] captured_traces
		/// </summary>
		protected SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RDiagnostics.RStackTrace> r_Fcaptured_traces;
		public virtual SMFrame.Editor.Refleaction.RFieldArray<SMFrame.Editor.Refleaction.RSystem.RDiagnostics.RStackTrace> RFcaptured_traces
		{
			get
			{
				if(r_Fcaptured_traces == null)
				{
					r_Fcaptured_traces = new(this, "captured_traces");
					r_Fcaptured_traces.SetBelong(this.instance);
				}
				return r_Fcaptured_traces;
			}
		}

		/// <summary>
		/// System.Boolean debug_info
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_Fdebug_info;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFdebug_info
		{
			get
			{
				if(r_Fdebug_info == null)
				{
					r_Fdebug_info = new(this, "debug_info");
					r_Fdebug_info.SetBelong(this.instance);
				}
				return r_Fdebug_info;
			}
		}

		/// <summary>
		/// System.Boolean isAotidSet
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RBoolean r_FisAotidSet;
		public static SMFrame.Editor.Refleaction.RSystem.RBoolean RFisAotidSet
		{
			get
			{
				if(r_FisAotidSet == null)
				{
					r_FisAotidSet = new(typeof(System.Diagnostics.StackTrace), "isAotidSet");
					r_FisAotidSet.SetBelong(null);
				}
				return r_FisAotidSet;
			}
		}

		/// <summary>
		/// System.String aotid
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RSystem.RString r_Faotid;
		public static SMFrame.Editor.Refleaction.RSystem.RString RFaotid
		{
			get
			{
				if(r_Faotid == null)
				{
					r_Faotid = new(typeof(System.Diagnostics.StackTrace), "aotid");
					r_Faotid.SetBelong(null);
				}
				return r_Faotid;
			}
		}

		/// <summary>
		/// Int32 FrameCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PFrameCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPFrameCount
		{
			get
			{
				if(r_PFrameCount == null)
				{
					r_PFrameCount = new(this, "FrameCount", -1);
					r_PFrameCount.SetBelong(this.instance);
				}
				return r_PFrameCount;
			}
		}

		/// <summary>
		/// Void init_frames(Int32, Boolean)
		/// </summary>
		protected RMethod r_Minit_frames_Int32_Boolean;
		public virtual RMethod RMinit_frames_Int32_Boolean
		{
			get
			{
				if(r_Minit_frames_Int32_Boolean == null)
				{
					r_Minit_frames_Int32_Boolean = new(this, "init_frames", 0, typeof(System.Int32), typeof(System.Boolean));
					r_Minit_frames_Int32_Boolean.SetBelong(this.instance);
				}
				return r_Minit_frames_Int32_Boolean;
			}
		}

		/// <summary>
		/// System.Diagnostics.StackFrame[] get_trace(System.Exception, Int32, Boolean)
		/// </summary>
		protected static RMethod r_Mget_trace_Exception_Int32_Boolean;
		public static RMethod RMget_trace_Exception_Int32_Boolean
		{
			get
			{
				if(r_Mget_trace_Exception_Int32_Boolean == null)
				{
					r_Mget_trace_Exception_Int32_Boolean = new(typeof(System.Diagnostics.StackTrace), "get_trace", 0, typeof(System.Exception), typeof(System.Int32), typeof(System.Boolean));
					r_Mget_trace_Exception_Int32_Boolean.SetBelong(null);
				}
				return r_Mget_trace_Exception_Int32_Boolean;
			}
		}

		/// <summary>
		/// System.Diagnostics.StackFrame GetFrame(Int32)
		/// </summary>
		protected RMethod r_MGetFrame_Int32;
		public virtual RMethod RMGetFrame_Int32
		{
			get
			{
				if(r_MGetFrame_Int32 == null)
				{
					r_MGetFrame_Int32 = new(this, "GetFrame", 0, typeof(System.Int32));
					r_MGetFrame_Int32.SetBelong(this.instance);
				}
				return r_MGetFrame_Int32;
			}
		}

		/// <summary>
		/// System.Diagnostics.StackFrame[] GetFrames()
		/// </summary>
		protected RMethod r_MGetFrames;
		public virtual RMethod RMGetFrames
		{
			get
			{
				if(r_MGetFrames == null)
				{
					r_MGetFrames = new(this, "GetFrames", 0);
					r_MGetFrames.SetBelong(this.instance);
				}
				return r_MGetFrames;
			}
		}

		/// <summary>
		/// System.String GetAotId()
		/// </summary>
		protected static RMethod r_MGetAotId;
		public static RMethod RMGetAotId
		{
			get
			{
				if(r_MGetAotId == null)
				{
					r_MGetAotId = new(typeof(System.Diagnostics.StackTrace), "GetAotId", 0);
					r_MGetAotId.SetBelong(null);
				}
				return r_MGetAotId;
			}
		}

		/// <summary>
		/// Boolean AddFrames(System.Text.StringBuilder, Boolean, Boolean ByRef)
		/// </summary>
		protected RMethod r_MAddFrames_StringBuilder_Boolean_Out_Boolean;
		public virtual RMethod RMAddFrames_StringBuilder_Boolean_Out_Boolean
		{
			get
			{
				if(r_MAddFrames_StringBuilder_Boolean_Out_Boolean == null)
				{
					r_MAddFrames_StringBuilder_Boolean_Out_Boolean = new(this, "AddFrames", 0, typeof(System.Text.StringBuilder), typeof(System.Boolean), typeof(System.Boolean).MakeByRefType());
					r_MAddFrames_StringBuilder_Boolean_Out_Boolean.SetBelong(this.instance);
				}
				return r_MAddFrames_StringBuilder_Boolean_Out_Boolean;
			}
		}

		/// <summary>
		/// Void GetFullNameForStackTrace(System.Text.StringBuilder, System.Reflection.MethodBase, Boolean, Boolean ByRef, Boolean ByRef)
		/// </summary>
		protected RMethod r_MGetFullNameForStackTrace_StringBuilder_MethodBase_Boolean_Out_Boolean_Out_Boolean;
		public virtual RMethod RMGetFullNameForStackTrace_StringBuilder_MethodBase_Boolean_Out_Boolean_Out_Boolean
		{
			get
			{
				if(r_MGetFullNameForStackTrace_StringBuilder_MethodBase_Boolean_Out_Boolean_Out_Boolean == null)
				{
					r_MGetFullNameForStackTrace_StringBuilder_MethodBase_Boolean_Out_Boolean_Out_Boolean = new(this, "GetFullNameForStackTrace", 0, typeof(System.Text.StringBuilder), typeof(System.Reflection.MethodBase), typeof(System.Boolean), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType());
					r_MGetFullNameForStackTrace_StringBuilder_MethodBase_Boolean_Out_Boolean_Out_Boolean.SetBelong(this.instance);
				}
				return r_MGetFullNameForStackTrace_StringBuilder_MethodBase_Boolean_Out_Boolean_Out_Boolean;
			}
		}

		/// <summary>
		/// Void ConvertAsyncStateMachineMethod(System.Reflection.MethodBase ByRef, System.Type ByRef)
		/// </summary>
		protected static RMethod r_MConvertAsyncStateMachineMethod_Ref_MethodBase_Ref_Type;
		public static RMethod RMConvertAsyncStateMachineMethod_Ref_MethodBase_Ref_Type
		{
			get
			{
				if(r_MConvertAsyncStateMachineMethod_Ref_MethodBase_Ref_Type == null)
				{
					r_MConvertAsyncStateMachineMethod_Ref_MethodBase_Ref_Type = new(typeof(System.Diagnostics.StackTrace), "ConvertAsyncStateMachineMethod", 0, typeof(System.Reflection.MethodBase).MakeByRefType(), typeof(System.Type).MakeByRefType());
					r_MConvertAsyncStateMachineMethod_Ref_MethodBase_Ref_Type.SetBelong(null);
				}
				return r_MConvertAsyncStateMachineMethod_Ref_MethodBase_Ref_Type;
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
		/// System.String ToString(TraceFormat)
		/// </summary>
		protected RMethod r_MToString_TraceFormat;
		public virtual RMethod RMToString_TraceFormat
		{
			get
			{
				if(r_MToString_TraceFormat == null)
				{
					r_MToString_TraceFormat = new(this, "ToString", 0,  ReflectionUtils.GetType("System.Diagnostics.StackTrace+TraceFormat"));
					r_MToString_TraceFormat.SetBelong(this.instance);
				}
				return r_MToString_TraceFormat;
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

        public virtual void init_frames(System.Int32 @skipFrames, System.Boolean @fNeedFileInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@skipFrames, @fNeedFileInfo};
            var ___result = RMinit_frames_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Diagnostics.StackFrame[] get_trace(System.Exception @e, System.Int32 @skipFrames, System.Boolean @fNeedFileInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @skipFrames, @fNeedFileInfo};
            var ___result = RMget_trace_Exception_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Diagnostics.StackFrame[])___result;
        }


        public virtual System.Diagnostics.StackFrame GetFrame(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetFrame_Int32.Invoke(___genericsType, ___parameters);

            return (System.Diagnostics.StackFrame)___result;
        }


        public virtual System.Diagnostics.StackFrame[] GetFrames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetFrames.Invoke(___genericsType, ___parameters);

            return (System.Diagnostics.StackFrame[])___result;
        }


        public static System.String GetAotId()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAotId.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean AddFrames(System.Text.StringBuilder @sb, System.Boolean @separator, out System.Boolean @isAsync)
        {
			@isAsync = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sb, @separator, @isAsync};
            var ___result = RMAddFrames_StringBuilder_Boolean_Out_Boolean.Invoke(___genericsType, ___parameters);
			@isAsync = (System.Boolean)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual void GetFullNameForStackTrace(System.Text.StringBuilder @sb, System.Reflection.MethodBase @mi, System.Boolean @needsNewLine, out System.Boolean @skipped, out System.Boolean @isAsync)
        {
			@skipped = default;
			@isAsync = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sb, @mi, @needsNewLine, @skipped, @isAsync};
            var ___result = RMGetFullNameForStackTrace_StringBuilder_MethodBase_Boolean_Out_Boolean_Out_Boolean.Invoke(___genericsType, ___parameters);
			@skipped = (System.Boolean)___parameters[3];
			@isAsync = (System.Boolean)___parameters[4];

            
        }


        public static void ConvertAsyncStateMachineMethod(ref System.Reflection.MethodBase @method, ref System.Type @declaringType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@method, @declaringType};
            var ___result = RMConvertAsyncStateMachineMethod_Ref_MethodBase_Ref_Type.Invoke(___genericsType, ___parameters);
			@method = (System.Reflection.MethodBase)___parameters[0];
			@declaringType = (System.Type)___parameters[1];

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(SMFrame.Editor.Refleaction.RSystem.RDiagnostics.RStackTrace.RTraceFormat @traceFormat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@traceFormat.Value};
            var ___result = RMToString_TraceFormat.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


    }
}
