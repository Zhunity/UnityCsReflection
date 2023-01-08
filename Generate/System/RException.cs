using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.Exception
	/// </summary>
    public partial class RException : RMember //
    {

		/// <summary>
		/// System.Object s_EDILock
		/// </summary>
		protected static RSystem.RObject r_s_EDILock;
		public static RSystem.RObject Rs_EDILock
		{
			get
			{
				if(r_s_EDILock == null)
				{
					r_s_EDILock = new(typeof(System.Exception), "s_EDILock");
					r_s_EDILock.SetBelong(null);
				}
				return r_s_EDILock;
			}
		}

		/// <summary>
		/// System.String _className
		/// </summary>
		protected RField r__className;
		public virtual RField R_className
		{
			get
			{
				if(r__className == null)
				{
					r__className = new(this, "_className");
					r__className.SetBelong(this.instance);
				}
				return r__className;
			}
		}

		/// <summary>
		/// System.String _message
		/// </summary>
		protected RField r__message;
		public virtual RField R_message
		{
			get
			{
				if(r__message == null)
				{
					r__message = new(this, "_message");
					r__message.SetBelong(this.instance);
				}
				return r__message;
			}
		}

		/// <summary>
		/// System.Collections.IDictionary _data
		/// </summary>
		protected RSystem.RCollections.RIDictionary r__data;
		public virtual RSystem.RCollections.RIDictionary R_data
		{
			get
			{
				if(r__data == null)
				{
					r__data = new(this, "_data");
					r__data.SetBelong(this.instance);
				}
				return r__data;
			}
		}

		/// <summary>
		/// System.Exception _innerException
		/// </summary>
		protected RSystem.RException r__innerException;
		public virtual RSystem.RException R_innerException
		{
			get
			{
				if(r__innerException == null)
				{
					r__innerException = new(this, "_innerException");
					r__innerException.SetBelong(this.instance);
				}
				return r__innerException;
			}
		}

		/// <summary>
		/// System.String _helpURL
		/// </summary>
		protected RField r__helpURL;
		public virtual RField R_helpURL
		{
			get
			{
				if(r__helpURL == null)
				{
					r__helpURL = new(this, "_helpURL");
					r__helpURL.SetBelong(this.instance);
				}
				return r__helpURL;
			}
		}

		/// <summary>
		/// System.Object _stackTrace
		/// </summary>
		protected RSystem.RObject r__stackTrace;
		public virtual RSystem.RObject R_stackTrace
		{
			get
			{
				if(r__stackTrace == null)
				{
					r__stackTrace = new(this, "_stackTrace");
					r__stackTrace.SetBelong(this.instance);
				}
				return r__stackTrace;
			}
		}

		/// <summary>
		/// System.String _stackTraceString
		/// </summary>
		protected RField r__stackTraceString;
		public virtual RField R_stackTraceString
		{
			get
			{
				if(r__stackTraceString == null)
				{
					r__stackTraceString = new(this, "_stackTraceString");
					r__stackTraceString.SetBelong(this.instance);
				}
				return r__stackTraceString;
			}
		}

		/// <summary>
		/// System.String _remoteStackTraceString
		/// </summary>
		protected RField r__remoteStackTraceString;
		public virtual RField R_remoteStackTraceString
		{
			get
			{
				if(r__remoteStackTraceString == null)
				{
					r__remoteStackTraceString = new(this, "_remoteStackTraceString");
					r__remoteStackTraceString.SetBelong(this.instance);
				}
				return r__remoteStackTraceString;
			}
		}

		/// <summary>
		/// System.Int32 _remoteStackIndex
		/// </summary>
		protected RField r__remoteStackIndex;
		public virtual RField R_remoteStackIndex
		{
			get
			{
				if(r__remoteStackIndex == null)
				{
					r__remoteStackIndex = new(this, "_remoteStackIndex");
					r__remoteStackIndex.SetBelong(this.instance);
				}
				return r__remoteStackIndex;
			}
		}

		/// <summary>
		/// System.Object _dynamicMethods
		/// </summary>
		protected RSystem.RObject r__dynamicMethods;
		public virtual RSystem.RObject R_dynamicMethods
		{
			get
			{
				if(r__dynamicMethods == null)
				{
					r__dynamicMethods = new(this, "_dynamicMethods");
					r__dynamicMethods.SetBelong(this.instance);
				}
				return r__dynamicMethods;
			}
		}

		/// <summary>
		/// System.Int32 _HResult
		/// </summary>
		protected RField r__HResult;
		public virtual RField R_HResult
		{
			get
			{
				if(r__HResult == null)
				{
					r__HResult = new(this, "_HResult");
					r__HResult.SetBelong(this.instance);
				}
				return r__HResult;
			}
		}

		/// <summary>
		/// System.String _source
		/// </summary>
		protected RField r__source;
		public virtual RField R_source
		{
			get
			{
				if(r__source == null)
				{
					r__source = new(this, "_source");
					r__source.SetBelong(this.instance);
				}
				return r__source;
			}
		}

		/// <summary>
		/// System.Runtime.Serialization.SafeSerializationManager _safeSerializationManager
		/// </summary>
		protected RSystem.RRuntime.RSerialization.RSafeSerializationManager r__safeSerializationManager;
		public virtual RSystem.RRuntime.RSerialization.RSafeSerializationManager R_safeSerializationManager
		{
			get
			{
				if(r__safeSerializationManager == null)
				{
					r__safeSerializationManager = new(this, "_safeSerializationManager");
					r__safeSerializationManager.SetBelong(this.instance);
				}
				return r__safeSerializationManager;
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
		/// System.IntPtr[] native_trace_ips
		/// </summary>
		protected RFieldArray<RField> r_native_trace_ips;
		public virtual RFieldArray<RField> Rnative_trace_ips
		{
			get
			{
				if(r_native_trace_ips == null)
				{
					r_native_trace_ips = new(this, "native_trace_ips");
					r_native_trace_ips.SetBelong(this.instance);
				}
				return r_native_trace_ips;
			}
		}

		/// <summary>
		/// System.Int32 caught_in_unmanaged
		/// </summary>
		protected RField r_caught_in_unmanaged;
		public virtual RField Rcaught_in_unmanaged
		{
			get
			{
				if(r_caught_in_unmanaged == null)
				{
					r_caught_in_unmanaged = new(this, "caught_in_unmanaged");
					r_caught_in_unmanaged.SetBelong(this.instance);
				}
				return r_caught_in_unmanaged;
			}
		}

		/// <summary>
		/// System.Int32 _COMPlusExceptionCode
		/// </summary>
		protected static RField r__COMPlusExceptionCode;
		public static RField R_COMPlusExceptionCode
		{
			get
			{
				if(r__COMPlusExceptionCode == null)
				{
					r__COMPlusExceptionCode = new(typeof(System.Exception), "_COMPlusExceptionCode");
					r__COMPlusExceptionCode.SetBelong(null);
				}
				return r__COMPlusExceptionCode;
			}
		}

		/// <summary>
		/// System.String Message
		/// </summary>
		protected RProperty r_Message;
		public virtual RProperty RMessage
		{
			get
			{
				if(r_Message == null)
				{
					r_Message = new(this, "Message", -1);
					r_Message.SetBelong(this.instance);
				}
				return r_Message;
			}
		}

		/// <summary>
		/// System.Collections.IDictionary Data
		/// </summary>
		protected RSystem.RCollections.RIDictionary r_Data;
		public virtual RSystem.RCollections.RIDictionary RData
		{
			get
			{
				if(r_Data == null)
				{
					r_Data = new(this, "Data", -1);
					r_Data.SetBelong(this.instance);
				}
				return r_Data;
			}
		}

		/// <summary>
		/// System.Exception InnerException
		/// </summary>
		protected RSystem.RException r_InnerException;
		public virtual RSystem.RException RInnerException
		{
			get
			{
				if(r_InnerException == null)
				{
					r_InnerException = new(this, "InnerException", -1);
					r_InnerException.SetBelong(this.instance);
				}
				return r_InnerException;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase TargetSite
		/// </summary>
		protected RSystem.RReflection.RMethodBase r_TargetSite;
		public virtual RSystem.RReflection.RMethodBase RTargetSite
		{
			get
			{
				if(r_TargetSite == null)
				{
					r_TargetSite = new(this, "TargetSite", -1);
					r_TargetSite.SetBelong(this.instance);
				}
				return r_TargetSite;
			}
		}

		/// <summary>
		/// System.String StackTrace
		/// </summary>
		protected RProperty r_StackTrace;
		public virtual RProperty RStackTrace
		{
			get
			{
				if(r_StackTrace == null)
				{
					r_StackTrace = new(this, "StackTrace", -1);
					r_StackTrace.SetBelong(this.instance);
				}
				return r_StackTrace;
			}
		}

		/// <summary>
		/// System.String HelpLink
		/// </summary>
		protected RProperty r_HelpLink;
		public virtual RProperty RHelpLink
		{
			get
			{
				if(r_HelpLink == null)
				{
					r_HelpLink = new(this, "HelpLink", -1);
					r_HelpLink.SetBelong(this.instance);
				}
				return r_HelpLink;
			}
		}

		/// <summary>
		/// System.String Source
		/// </summary>
		protected RProperty r_Source;
		public virtual RProperty RSource
		{
			get
			{
				if(r_Source == null)
				{
					r_Source = new(this, "Source", -1);
					r_Source.SetBelong(this.instance);
				}
				return r_Source;
			}
		}

		/// <summary>
		/// System.String RemoteStackTrace
		/// </summary>
		protected RProperty r_RemoteStackTrace;
		public virtual RProperty RRemoteStackTrace
		{
			get
			{
				if(r_RemoteStackTrace == null)
				{
					r_RemoteStackTrace = new(this, "RemoteStackTrace", -1);
					r_RemoteStackTrace.SetBelong(this.instance);
				}
				return r_RemoteStackTrace;
			}
		}

		/// <summary>
		/// Int32 HResult
		/// </summary>
		protected RProperty r_HResult;
		public virtual RProperty RHResult
		{
			get
			{
				if(r_HResult == null)
				{
					r_HResult = new(this, "HResult", -1);
					r_HResult.SetBelong(this.instance);
				}
				return r_HResult;
			}
		}

		/// <summary>
		/// Boolean IsTransient
		/// </summary>
		protected RProperty r_IsTransient;
		public virtual RProperty RIsTransient
		{
			get
			{
				if(r_IsTransient == null)
				{
					r_IsTransient = new(this, "IsTransient", -1);
					r_IsTransient.SetBelong(this.instance);
				}
				return r_IsTransient;
			}
		}

		/// <summary>
		/// System.EventHandler`1[System.Runtime.Serialization.SafeSerializationEventArgs] SerializeObjectState
		/// </summary>
		protected REvent r_SerializeObjectState;
		public virtual REvent RSerializeObjectState
		{
			get
			{
				if(r_SerializeObjectState == null)
				{
					r_SerializeObjectState = new(this, "SerializeObjectState");
					r_SerializeObjectState.SetBelong(this.instance);
				}
				return r_SerializeObjectState;
			}
		}

		/// <summary>
		/// Void Init()
		/// </summary>
		protected RMethod r_Init;
		public virtual RMethod RInit
		{
			get
			{
				if(r_Init == null)
				{
					r_Init = new(this, "Init", 0);
					r_Init.SetBelong(this.instance);
				}
				return r_Init;
			}
		}

		/// <summary>
		/// Boolean IsImmutableAgileException(System.Exception)
		/// </summary>
		protected static RMethod r_IsImmutableAgileException_Exception;
		public static RMethod RIsImmutableAgileException_Exception
		{
			get
			{
				if(r_IsImmutableAgileException_Exception == null)
				{
					r_IsImmutableAgileException_Exception = new(typeof(System.Exception), "IsImmutableAgileException", 0, typeof(System.Exception));
					r_IsImmutableAgileException_Exception.SetBelong(null);
				}
				return r_IsImmutableAgileException_Exception;
			}
		}

		/// <summary>
		/// Void AddExceptionDataForRestrictedErrorInfo(System.String, System.String, System.String, System.Object, Boolean)
		/// </summary>
		protected RMethod r_AddExceptionDataForRestrictedErrorInfo_String_String_String_Object_Boolean;
		public virtual RMethod RAddExceptionDataForRestrictedErrorInfo_String_String_String_Object_Boolean
		{
			get
			{
				if(r_AddExceptionDataForRestrictedErrorInfo_String_String_String_Object_Boolean == null)
				{
					r_AddExceptionDataForRestrictedErrorInfo_String_String_String_Object_Boolean = new(this, "AddExceptionDataForRestrictedErrorInfo", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Object), typeof(System.Boolean));
					r_AddExceptionDataForRestrictedErrorInfo_String_String_String_Object_Boolean.SetBelong(this.instance);
				}
				return r_AddExceptionDataForRestrictedErrorInfo_String_String_String_Object_Boolean;
			}
		}

		/// <summary>
		/// Boolean TryGetRestrictedLanguageErrorObject(System.Object ByRef)
		/// </summary>
		protected RMethod r_TryGetRestrictedLanguageErrorObject_Out_Object;
		public virtual RMethod RTryGetRestrictedLanguageErrorObject_Out_Object
		{
			get
			{
				if(r_TryGetRestrictedLanguageErrorObject_Out_Object == null)
				{
					r_TryGetRestrictedLanguageErrorObject_Out_Object = new(this, "TryGetRestrictedLanguageErrorObject", 0, typeof(System.Object).MakeByRefType());
					r_TryGetRestrictedLanguageErrorObject_Out_Object.SetBelong(this.instance);
				}
				return r_TryGetRestrictedLanguageErrorObject_Out_Object;
			}
		}

		/// <summary>
		/// System.String GetClassName()
		/// </summary>
		protected RMethod r_GetClassName;
		public virtual RMethod RGetClassName
		{
			get
			{
				if(r_GetClassName == null)
				{
					r_GetClassName = new(this, "GetClassName", 0);
					r_GetClassName.SetBelong(this.instance);
				}
				return r_GetClassName;
			}
		}

		/// <summary>
		/// System.Exception GetBaseException()
		/// </summary>
		protected RMethod r_GetBaseException;
		public virtual RMethod RGetBaseException
		{
			get
			{
				if(r_GetBaseException == null)
				{
					r_GetBaseException = new(this, "GetBaseException", 0);
					r_GetBaseException.SetBelong(this.instance);
				}
				return r_GetBaseException;
			}
		}

		/// <summary>
		/// System.String GetStackTrace(Boolean)
		/// </summary>
		protected RMethod r_GetStackTrace_Boolean;
		public virtual RMethod RGetStackTrace_Boolean
		{
			get
			{
				if(r_GetStackTrace_Boolean == null)
				{
					r_GetStackTrace_Boolean = new(this, "GetStackTrace", 0, typeof(System.Boolean));
					r_GetStackTrace_Boolean.SetBelong(this.instance);
				}
				return r_GetStackTrace_Boolean;
			}
		}

		/// <summary>
		/// Void SetErrorCode(Int32)
		/// </summary>
		protected RMethod r_SetErrorCode_Int32;
		public virtual RMethod RSetErrorCode_Int32
		{
			get
			{
				if(r_SetErrorCode_Int32 == null)
				{
					r_SetErrorCode_Int32 = new(this, "SetErrorCode", 0, typeof(System.Int32));
					r_SetErrorCode_Int32.SetBelong(this.instance);
				}
				return r_SetErrorCode_Int32;
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

		/// <summary>
		/// System.String ToString(Boolean, Boolean)
		/// </summary>
		protected RMethod r_ToString_Boolean_Boolean;
		public virtual RMethod RToString_Boolean_Boolean
		{
			get
			{
				if(r_ToString_Boolean_Boolean == null)
				{
					r_ToString_Boolean_Boolean = new(this, "ToString", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_ToString_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_ToString_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_GetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// System.Exception PrepForRemoting()
		/// </summary>
		protected RMethod r_PrepForRemoting;
		public virtual RMethod RPrepForRemoting
		{
			get
			{
				if(r_PrepForRemoting == null)
				{
					r_PrepForRemoting = new(this, "PrepForRemoting", 0);
					r_PrepForRemoting.SetBelong(this.instance);
				}
				return r_PrepForRemoting;
			}
		}

		/// <summary>
		/// Void OnDeserialized(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_OnDeserialized_StreamingContext;
		public virtual RMethod ROnDeserialized_StreamingContext
		{
			get
			{
				if(r_OnDeserialized_StreamingContext == null)
				{
					r_OnDeserialized_StreamingContext = new(this, "OnDeserialized", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_OnDeserialized_StreamingContext.SetBelong(this.instance);
				}
				return r_OnDeserialized_StreamingContext;
			}
		}

		/// <summary>
		/// Void InternalPreserveStackTrace()
		/// </summary>
		protected RMethod r_InternalPreserveStackTrace;
		public virtual RMethod RInternalPreserveStackTrace
		{
			get
			{
				if(r_InternalPreserveStackTrace == null)
				{
					r_InternalPreserveStackTrace = new(this, "InternalPreserveStackTrace", 0);
					r_InternalPreserveStackTrace.SetBelong(this.instance);
				}
				return r_InternalPreserveStackTrace;
			}
		}

		/// <summary>
		/// System.String StripFileInfo(System.String, Boolean)
		/// </summary>
		protected RMethod r_StripFileInfo_String_Boolean;
		public virtual RMethod RStripFileInfo_String_Boolean
		{
			get
			{
				if(r_StripFileInfo_String_Boolean == null)
				{
					r_StripFileInfo_String_Boolean = new(this, "StripFileInfo", 0, typeof(System.String), typeof(System.Boolean));
					r_StripFileInfo_String_Boolean.SetBelong(this.instance);
				}
				return r_StripFileInfo_String_Boolean;
			}
		}

		/// <summary>
		/// Void RestoreExceptionDispatchInfo(System.Runtime.ExceptionServices.ExceptionDispatchInfo)
		/// </summary>
		protected RMethod r_RestoreExceptionDispatchInfo_ExceptionDispatchInfo;
		public virtual RMethod RRestoreExceptionDispatchInfo_ExceptionDispatchInfo
		{
			get
			{
				if(r_RestoreExceptionDispatchInfo_ExceptionDispatchInfo == null)
				{
					r_RestoreExceptionDispatchInfo_ExceptionDispatchInfo = new(this, "RestoreExceptionDispatchInfo", 0, typeof(System.Runtime.ExceptionServices.ExceptionDispatchInfo));
					r_RestoreExceptionDispatchInfo_ExceptionDispatchInfo.SetBelong(this.instance);
				}
				return r_RestoreExceptionDispatchInfo_ExceptionDispatchInfo;
			}
		}

		/// <summary>
		/// System.String InternalToString()
		/// </summary>
		protected RMethod r_InternalToString;
		public virtual RMethod RInternalToString
		{
			get
			{
				if(r_InternalToString == null)
				{
					r_InternalToString = new(this, "InternalToString", 0);
					r_InternalToString.SetBelong(this.instance);
				}
				return r_InternalToString;
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
		/// Boolean nIsTransient(Int32)
		/// </summary>
		protected static RMethod r_nIsTransient_Int32;
		public static RMethod RnIsTransient_Int32
		{
			get
			{
				if(r_nIsTransient_Int32 == null)
				{
					r_nIsTransient_Int32 = new(typeof(System.Exception), "nIsTransient", 0, typeof(System.Int32));
					r_nIsTransient_Int32.SetBelong(null);
				}
				return r_nIsTransient_Int32;
			}
		}

		/// <summary>
		/// System.String GetMessageFromNativeResources(ExceptionMessageKind)
		/// </summary>
		protected static RMethod r_GetMessageFromNativeResources_ExceptionMessageKind;
		public static RMethod RGetMessageFromNativeResources_ExceptionMessageKind
		{
			get
			{
				if(r_GetMessageFromNativeResources_ExceptionMessageKind == null)
				{
					r_GetMessageFromNativeResources_ExceptionMessageKind = new(typeof(System.Exception), "GetMessageFromNativeResources", 0,  ReflectionUtils.GetType("System.Exception+ExceptionMessageKind"));
					r_GetMessageFromNativeResources_ExceptionMessageKind.SetBelong(null);
				}
				return r_GetMessageFromNativeResources_ExceptionMessageKind;
			}
		}

		/// <summary>
		/// Void SetMessage(System.String)
		/// </summary>
		protected RMethod r_SetMessage_String;
		public virtual RMethod RSetMessage_String
		{
			get
			{
				if(r_SetMessage_String == null)
				{
					r_SetMessage_String = new(this, "SetMessage", 0, typeof(System.String));
					r_SetMessage_String.SetBelong(this.instance);
				}
				return r_SetMessage_String;
			}
		}

		/// <summary>
		/// Void SetStackTrace(System.String)
		/// </summary>
		protected RMethod r_SetStackTrace_String;
		public virtual RMethod RSetStackTrace_String
		{
			get
			{
				if(r_SetStackTrace_String == null)
				{
					r_SetStackTrace_String = new(this, "SetStackTrace", 0, typeof(System.String));
					r_SetStackTrace_String.SetBelong(this.instance);
				}
				return r_SetStackTrace_String;
			}
		}

		/// <summary>
		/// System.Exception FixRemotingException()
		/// </summary>
		protected RMethod r_FixRemotingException;
		public virtual RMethod RFixRemotingException
		{
			get
			{
				if(r_FixRemotingException == null)
				{
					r_FixRemotingException = new(this, "FixRemotingException", 0);
					r_FixRemotingException.SetBelong(this.instance);
				}
				return r_FixRemotingException;
			}
		}

		/// <summary>
		/// Void ReportUnhandledException(System.Exception)
		/// </summary>
		protected static RMethod r_ReportUnhandledException_Exception;
		public static RMethod RReportUnhandledException_Exception
		{
			get
			{
				if(r_ReportUnhandledException_Exception == null)
				{
					r_ReportUnhandledException_Exception = new(typeof(System.Exception), "ReportUnhandledException", 0, typeof(System.Exception));
					r_ReportUnhandledException_Exception.SetBelong(null);
				}
				return r_ReportUnhandledException_Exception;
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


        public RException() : base("System.Exception")
        {
        }

        public RException(System.Object instance) : base("System.Exception")
		{
            SetInstance(instance);
		}

        public RException(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RException(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Init()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInit.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsImmutableAgileException(System.Exception  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RIsImmutableAgileException_Exception.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void AddExceptionDataForRestrictedErrorInfo(System.String  @restrictedError, System.String  @restrictedErrorReference, System.String  @restrictedCapabilitySid, System.Object  @restrictedErrorObject, System.Boolean  @hasrestrictedLanguageErrorObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@restrictedError, @restrictedErrorReference, @restrictedCapabilitySid, @restrictedErrorObject, @hasrestrictedLanguageErrorObject};
            var ___result = RAddExceptionDataForRestrictedErrorInfo_String_String_String_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryGetRestrictedLanguageErrorObject(out System.Object  @restrictedErrorObject)
        {
			restrictedErrorObject = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@restrictedErrorObject};
            var ___result = RTryGetRestrictedLanguageErrorObject_Out_Object.Invoke(___genericsType, ___parameters);
			restrictedErrorObject = (System.Object)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual System.String GetClassName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetClassName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Exception GetBaseException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBaseException.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.String GetStackTrace(System.Boolean  @needFileInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@needFileInfo};
            var ___result = RGetStackTrace_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void SetErrorCode(System.Int32  @hr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hr};
            var ___result = RSetErrorCode_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.Boolean  @needFileLineInfo, System.Boolean  @needMessage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@needFileLineInfo, @needMessage};
            var ___result = RToString_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Exception PrepForRemoting()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPrepForRemoting.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual void OnDeserialized(System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context};
            var ___result = ROnDeserialized_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalPreserveStackTrace()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalPreserveStackTrace.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String StripFileInfo(System.String  @stackTrace, System.Boolean  @isRemoteStackTrace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stackTrace, @isRemoteStackTrace};
            var ___result = RStripFileInfo_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void RestoreExceptionDispatchInfo(System.Runtime.ExceptionServices.ExceptionDispatchInfo  @exceptionDispatchInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exceptionDispatchInfo};
            var ___result = RRestoreExceptionDispatchInfo_ExceptionDispatchInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String InternalToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Boolean nIsTransient(System.Int32  @hr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hr};
            var ___result = RnIsTransient_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual void SetMessage(System.String  @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RSetMessage_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetStackTrace(System.String  @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RSetStackTrace_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Exception FixRemotingException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFixRemotingException.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public static void ReportUnhandledException(System.Exception  @exception)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exception};
            var ___result = RReportUnhandledException_Exception.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
