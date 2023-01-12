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
		/// System.EventHandler`1[System.Runtime.Serialization.SafeSerializationEventArgs] SerializeObjectState
		/// </summary>
		protected REvent r_ESerializeObjectState;
		public virtual REvent RESerializeObjectState
		{
			get
			{
				if(r_ESerializeObjectState == null)
				{
					r_ESerializeObjectState = new(this, "SerializeObjectState");
					r_ESerializeObjectState.SetBelong(this.instance);
				}
				return r_ESerializeObjectState;
			}
		}

		/// <summary>
		/// System.Object s_EDILock
		/// </summary>
		protected static RSystem.RObject r_Fs_EDILock;
		public static RSystem.RObject RFs_EDILock
		{
			get
			{
				if(r_Fs_EDILock == null)
				{
					r_Fs_EDILock = new(typeof(System.Exception), "s_EDILock");
					r_Fs_EDILock.SetBelong(null);
				}
				return r_Fs_EDILock;
			}
		}

		/// <summary>
		/// System.String _className
		/// </summary>
		protected RSystem.RString r_F_className;
		public virtual RSystem.RString RF_className
		{
			get
			{
				if(r_F_className == null)
				{
					r_F_className = new(this, "_className");
					r_F_className.SetBelong(this.instance);
				}
				return r_F_className;
			}
		}

		/// <summary>
		/// System.String _message
		/// </summary>
		protected RSystem.RString r_F_message;
		public virtual RSystem.RString RF_message
		{
			get
			{
				if(r_F_message == null)
				{
					r_F_message = new(this, "_message");
					r_F_message.SetBelong(this.instance);
				}
				return r_F_message;
			}
		}

		/// <summary>
		/// System.Collections.IDictionary _data
		/// </summary>
		protected RSystem.RCollections.RIDictionary r_F_data;
		public virtual RSystem.RCollections.RIDictionary RF_data
		{
			get
			{
				if(r_F_data == null)
				{
					r_F_data = new(this, "_data");
					r_F_data.SetBelong(this.instance);
				}
				return r_F_data;
			}
		}

		/// <summary>
		/// System.Exception _innerException
		/// </summary>
		protected RSystem.RException r_F_innerException;
		public virtual RSystem.RException RF_innerException
		{
			get
			{
				if(r_F_innerException == null)
				{
					r_F_innerException = new(this, "_innerException");
					r_F_innerException.SetBelong(this.instance);
				}
				return r_F_innerException;
			}
		}

		/// <summary>
		/// System.String _helpURL
		/// </summary>
		protected RSystem.RString r_F_helpURL;
		public virtual RSystem.RString RF_helpURL
		{
			get
			{
				if(r_F_helpURL == null)
				{
					r_F_helpURL = new(this, "_helpURL");
					r_F_helpURL.SetBelong(this.instance);
				}
				return r_F_helpURL;
			}
		}

		/// <summary>
		/// System.Object _stackTrace
		/// </summary>
		protected RSystem.RObject r_F_stackTrace;
		public virtual RSystem.RObject RF_stackTrace
		{
			get
			{
				if(r_F_stackTrace == null)
				{
					r_F_stackTrace = new(this, "_stackTrace");
					r_F_stackTrace.SetBelong(this.instance);
				}
				return r_F_stackTrace;
			}
		}

		/// <summary>
		/// System.String _stackTraceString
		/// </summary>
		protected RSystem.RString r_F_stackTraceString;
		public virtual RSystem.RString RF_stackTraceString
		{
			get
			{
				if(r_F_stackTraceString == null)
				{
					r_F_stackTraceString = new(this, "_stackTraceString");
					r_F_stackTraceString.SetBelong(this.instance);
				}
				return r_F_stackTraceString;
			}
		}

		/// <summary>
		/// System.String _remoteStackTraceString
		/// </summary>
		protected RSystem.RString r_F_remoteStackTraceString;
		public virtual RSystem.RString RF_remoteStackTraceString
		{
			get
			{
				if(r_F_remoteStackTraceString == null)
				{
					r_F_remoteStackTraceString = new(this, "_remoteStackTraceString");
					r_F_remoteStackTraceString.SetBelong(this.instance);
				}
				return r_F_remoteStackTraceString;
			}
		}

		/// <summary>
		/// System.Int32 _remoteStackIndex
		/// </summary>
		protected RSystem.RInt32 r_F_remoteStackIndex;
		public virtual RSystem.RInt32 RF_remoteStackIndex
		{
			get
			{
				if(r_F_remoteStackIndex == null)
				{
					r_F_remoteStackIndex = new(this, "_remoteStackIndex");
					r_F_remoteStackIndex.SetBelong(this.instance);
				}
				return r_F_remoteStackIndex;
			}
		}

		/// <summary>
		/// System.Object _dynamicMethods
		/// </summary>
		protected RSystem.RObject r_F_dynamicMethods;
		public virtual RSystem.RObject RF_dynamicMethods
		{
			get
			{
				if(r_F_dynamicMethods == null)
				{
					r_F_dynamicMethods = new(this, "_dynamicMethods");
					r_F_dynamicMethods.SetBelong(this.instance);
				}
				return r_F_dynamicMethods;
			}
		}

		/// <summary>
		/// System.Int32 _HResult
		/// </summary>
		protected RSystem.RInt32 r_F_HResult;
		public virtual RSystem.RInt32 RF_HResult
		{
			get
			{
				if(r_F_HResult == null)
				{
					r_F_HResult = new(this, "_HResult");
					r_F_HResult.SetBelong(this.instance);
				}
				return r_F_HResult;
			}
		}

		/// <summary>
		/// System.String _source
		/// </summary>
		protected RSystem.RString r_F_source;
		public virtual RSystem.RString RF_source
		{
			get
			{
				if(r_F_source == null)
				{
					r_F_source = new(this, "_source");
					r_F_source.SetBelong(this.instance);
				}
				return r_F_source;
			}
		}

		/// <summary>
		/// System.Runtime.Serialization.SafeSerializationManager _safeSerializationManager
		/// </summary>
		protected RSystem.RRuntime.RSerialization.RSafeSerializationManager r_F_safeSerializationManager;
		public virtual RSystem.RRuntime.RSerialization.RSafeSerializationManager RF_safeSerializationManager
		{
			get
			{
				if(r_F_safeSerializationManager == null)
				{
					r_F_safeSerializationManager = new(this, "_safeSerializationManager");
					r_F_safeSerializationManager.SetBelong(this.instance);
				}
				return r_F_safeSerializationManager;
			}
		}

		/// <summary>
		/// System.Diagnostics.StackTrace[] captured_traces
		/// </summary>
		protected RFieldArray<RSystem.RDiagnostics.RStackTrace> r_Fcaptured_traces;
		public virtual RFieldArray<RSystem.RDiagnostics.RStackTrace> RFcaptured_traces
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
		/// System.IntPtr[] native_trace_ips
		/// </summary>
		protected RFieldArray<RSystem.RIntPtr> r_Fnative_trace_ips;
		public virtual RFieldArray<RSystem.RIntPtr> RFnative_trace_ips
		{
			get
			{
				if(r_Fnative_trace_ips == null)
				{
					r_Fnative_trace_ips = new(this, "native_trace_ips");
					r_Fnative_trace_ips.SetBelong(this.instance);
				}
				return r_Fnative_trace_ips;
			}
		}

		/// <summary>
		/// System.Int32 caught_in_unmanaged
		/// </summary>
		protected RSystem.RInt32 r_Fcaught_in_unmanaged;
		public virtual RSystem.RInt32 RFcaught_in_unmanaged
		{
			get
			{
				if(r_Fcaught_in_unmanaged == null)
				{
					r_Fcaught_in_unmanaged = new(this, "caught_in_unmanaged");
					r_Fcaught_in_unmanaged.SetBelong(this.instance);
				}
				return r_Fcaught_in_unmanaged;
			}
		}

		/// <summary>
		/// System.Int32 _COMPlusExceptionCode
		/// </summary>
		protected static RSystem.RInt32 r_F_COMPlusExceptionCode;
		public static RSystem.RInt32 RF_COMPlusExceptionCode
		{
			get
			{
				if(r_F_COMPlusExceptionCode == null)
				{
					r_F_COMPlusExceptionCode = new(typeof(System.Exception), "_COMPlusExceptionCode");
					r_F_COMPlusExceptionCode.SetBelong(null);
				}
				return r_F_COMPlusExceptionCode;
			}
		}

		/// <summary>
		/// System.String Message
		/// </summary>
		protected RSystem.RString r_PMessage;
		public virtual RSystem.RString RPMessage
		{
			get
			{
				if(r_PMessage == null)
				{
					r_PMessage = new(this, "Message", -1);
					r_PMessage.SetBelong(this.instance);
				}
				return r_PMessage;
			}
		}

		/// <summary>
		/// System.Collections.IDictionary Data
		/// </summary>
		protected RSystem.RCollections.RIDictionary r_PData;
		public virtual RSystem.RCollections.RIDictionary RPData
		{
			get
			{
				if(r_PData == null)
				{
					r_PData = new(this, "Data", -1);
					r_PData.SetBelong(this.instance);
				}
				return r_PData;
			}
		}

		/// <summary>
		/// System.Exception InnerException
		/// </summary>
		protected RSystem.RException r_PInnerException;
		public virtual RSystem.RException RPInnerException
		{
			get
			{
				if(r_PInnerException == null)
				{
					r_PInnerException = new(this, "InnerException", -1);
					r_PInnerException.SetBelong(this.instance);
				}
				return r_PInnerException;
			}
		}

		/// <summary>
		/// System.Reflection.MethodBase TargetSite
		/// </summary>
		protected RSystem.RReflection.RMethodBase r_PTargetSite;
		public virtual RSystem.RReflection.RMethodBase RPTargetSite
		{
			get
			{
				if(r_PTargetSite == null)
				{
					r_PTargetSite = new(this, "TargetSite", -1);
					r_PTargetSite.SetBelong(this.instance);
				}
				return r_PTargetSite;
			}
		}

		/// <summary>
		/// System.String StackTrace
		/// </summary>
		protected RSystem.RString r_PStackTrace;
		public virtual RSystem.RString RPStackTrace
		{
			get
			{
				if(r_PStackTrace == null)
				{
					r_PStackTrace = new(this, "StackTrace", -1);
					r_PStackTrace.SetBelong(this.instance);
				}
				return r_PStackTrace;
			}
		}

		/// <summary>
		/// System.String HelpLink
		/// </summary>
		protected RSystem.RString r_PHelpLink;
		public virtual RSystem.RString RPHelpLink
		{
			get
			{
				if(r_PHelpLink == null)
				{
					r_PHelpLink = new(this, "HelpLink", -1);
					r_PHelpLink.SetBelong(this.instance);
				}
				return r_PHelpLink;
			}
		}

		/// <summary>
		/// System.String Source
		/// </summary>
		protected RSystem.RString r_PSource;
		public virtual RSystem.RString RPSource
		{
			get
			{
				if(r_PSource == null)
				{
					r_PSource = new(this, "Source", -1);
					r_PSource.SetBelong(this.instance);
				}
				return r_PSource;
			}
		}

		/// <summary>
		/// System.String RemoteStackTrace
		/// </summary>
		protected RSystem.RString r_PRemoteStackTrace;
		public virtual RSystem.RString RPRemoteStackTrace
		{
			get
			{
				if(r_PRemoteStackTrace == null)
				{
					r_PRemoteStackTrace = new(this, "RemoteStackTrace", -1);
					r_PRemoteStackTrace.SetBelong(this.instance);
				}
				return r_PRemoteStackTrace;
			}
		}

		/// <summary>
		/// Int32 HResult
		/// </summary>
		protected RSystem.RInt32 r_PHResult;
		public virtual RSystem.RInt32 RPHResult
		{
			get
			{
				if(r_PHResult == null)
				{
					r_PHResult = new(this, "HResult", -1);
					r_PHResult.SetBelong(this.instance);
				}
				return r_PHResult;
			}
		}

		/// <summary>
		/// Boolean IsTransient
		/// </summary>
		protected RSystem.RBoolean r_PIsTransient;
		public virtual RSystem.RBoolean RPIsTransient
		{
			get
			{
				if(r_PIsTransient == null)
				{
					r_PIsTransient = new(this, "IsTransient", -1);
					r_PIsTransient.SetBelong(this.instance);
				}
				return r_PIsTransient;
			}
		}

		/// <summary>
		/// Void Init()
		/// </summary>
		protected RMethod r_MInit;
		public virtual RMethod RMInit
		{
			get
			{
				if(r_MInit == null)
				{
					r_MInit = new(this, "Init", 0);
					r_MInit.SetBelong(this.instance);
				}
				return r_MInit;
			}
		}

		/// <summary>
		/// Boolean IsImmutableAgileException(System.Exception)
		/// </summary>
		protected static RMethod r_MIsImmutableAgileException_Exception;
		public static RMethod RMIsImmutableAgileException_Exception
		{
			get
			{
				if(r_MIsImmutableAgileException_Exception == null)
				{
					r_MIsImmutableAgileException_Exception = new(typeof(System.Exception), "IsImmutableAgileException", 0, typeof(System.Exception));
					r_MIsImmutableAgileException_Exception.SetBelong(null);
				}
				return r_MIsImmutableAgileException_Exception;
			}
		}

		/// <summary>
		/// Void AddExceptionDataForRestrictedErrorInfo(System.String, System.String, System.String, System.Object, Boolean)
		/// </summary>
		protected RMethod r_MAddExceptionDataForRestrictedErrorInfo_String_String_String_Object_Boolean;
		public virtual RMethod RMAddExceptionDataForRestrictedErrorInfo_String_String_String_Object_Boolean
		{
			get
			{
				if(r_MAddExceptionDataForRestrictedErrorInfo_String_String_String_Object_Boolean == null)
				{
					r_MAddExceptionDataForRestrictedErrorInfo_String_String_String_Object_Boolean = new(this, "AddExceptionDataForRestrictedErrorInfo", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Object), typeof(System.Boolean));
					r_MAddExceptionDataForRestrictedErrorInfo_String_String_String_Object_Boolean.SetBelong(this.instance);
				}
				return r_MAddExceptionDataForRestrictedErrorInfo_String_String_String_Object_Boolean;
			}
		}

		/// <summary>
		/// Boolean TryGetRestrictedLanguageErrorObject(System.Object ByRef)
		/// </summary>
		protected RMethod r_MTryGetRestrictedLanguageErrorObject_Out_Object;
		public virtual RMethod RMTryGetRestrictedLanguageErrorObject_Out_Object
		{
			get
			{
				if(r_MTryGetRestrictedLanguageErrorObject_Out_Object == null)
				{
					r_MTryGetRestrictedLanguageErrorObject_Out_Object = new(this, "TryGetRestrictedLanguageErrorObject", 0, typeof(System.Object).MakeByRefType());
					r_MTryGetRestrictedLanguageErrorObject_Out_Object.SetBelong(this.instance);
				}
				return r_MTryGetRestrictedLanguageErrorObject_Out_Object;
			}
		}

		/// <summary>
		/// System.String GetClassName()
		/// </summary>
		protected RMethod r_MGetClassName;
		public virtual RMethod RMGetClassName
		{
			get
			{
				if(r_MGetClassName == null)
				{
					r_MGetClassName = new(this, "GetClassName", 0);
					r_MGetClassName.SetBelong(this.instance);
				}
				return r_MGetClassName;
			}
		}

		/// <summary>
		/// System.Exception GetBaseException()
		/// </summary>
		protected RMethod r_MGetBaseException;
		public virtual RMethod RMGetBaseException
		{
			get
			{
				if(r_MGetBaseException == null)
				{
					r_MGetBaseException = new(this, "GetBaseException", 0);
					r_MGetBaseException.SetBelong(this.instance);
				}
				return r_MGetBaseException;
			}
		}

		/// <summary>
		/// System.String GetStackTrace(Boolean)
		/// </summary>
		protected RMethod r_MGetStackTrace_Boolean;
		public virtual RMethod RMGetStackTrace_Boolean
		{
			get
			{
				if(r_MGetStackTrace_Boolean == null)
				{
					r_MGetStackTrace_Boolean = new(this, "GetStackTrace", 0, typeof(System.Boolean));
					r_MGetStackTrace_Boolean.SetBelong(this.instance);
				}
				return r_MGetStackTrace_Boolean;
			}
		}

		/// <summary>
		/// Void SetErrorCode(Int32)
		/// </summary>
		protected RMethod r_MSetErrorCode_Int32;
		public virtual RMethod RMSetErrorCode_Int32
		{
			get
			{
				if(r_MSetErrorCode_Int32 == null)
				{
					r_MSetErrorCode_Int32 = new(this, "SetErrorCode", 0, typeof(System.Int32));
					r_MSetErrorCode_Int32.SetBelong(this.instance);
				}
				return r_MSetErrorCode_Int32;
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
		/// System.String ToString(Boolean, Boolean)
		/// </summary>
		protected RMethod r_MToString_Boolean_Boolean;
		public virtual RMethod RMToString_Boolean_Boolean
		{
			get
			{
				if(r_MToString_Boolean_Boolean == null)
				{
					r_MToString_Boolean_Boolean = new(this, "ToString", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_MToString_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MToString_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MGetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RMGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_MGetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_MGetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_MGetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_MGetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// System.Exception PrepForRemoting()
		/// </summary>
		protected RMethod r_MPrepForRemoting;
		public virtual RMethod RMPrepForRemoting
		{
			get
			{
				if(r_MPrepForRemoting == null)
				{
					r_MPrepForRemoting = new(this, "PrepForRemoting", 0);
					r_MPrepForRemoting.SetBelong(this.instance);
				}
				return r_MPrepForRemoting;
			}
		}

		/// <summary>
		/// Void OnDeserialized(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MOnDeserialized_StreamingContext;
		public virtual RMethod RMOnDeserialized_StreamingContext
		{
			get
			{
				if(r_MOnDeserialized_StreamingContext == null)
				{
					r_MOnDeserialized_StreamingContext = new(this, "OnDeserialized", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_MOnDeserialized_StreamingContext.SetBelong(this.instance);
				}
				return r_MOnDeserialized_StreamingContext;
			}
		}

		/// <summary>
		/// Void InternalPreserveStackTrace()
		/// </summary>
		protected RMethod r_MInternalPreserveStackTrace;
		public virtual RMethod RMInternalPreserveStackTrace
		{
			get
			{
				if(r_MInternalPreserveStackTrace == null)
				{
					r_MInternalPreserveStackTrace = new(this, "InternalPreserveStackTrace", 0);
					r_MInternalPreserveStackTrace.SetBelong(this.instance);
				}
				return r_MInternalPreserveStackTrace;
			}
		}

		/// <summary>
		/// System.String StripFileInfo(System.String, Boolean)
		/// </summary>
		protected RMethod r_MStripFileInfo_String_Boolean;
		public virtual RMethod RMStripFileInfo_String_Boolean
		{
			get
			{
				if(r_MStripFileInfo_String_Boolean == null)
				{
					r_MStripFileInfo_String_Boolean = new(this, "StripFileInfo", 0, typeof(System.String), typeof(System.Boolean));
					r_MStripFileInfo_String_Boolean.SetBelong(this.instance);
				}
				return r_MStripFileInfo_String_Boolean;
			}
		}

		/// <summary>
		/// Void RestoreExceptionDispatchInfo(System.Runtime.ExceptionServices.ExceptionDispatchInfo)
		/// </summary>
		protected RMethod r_MRestoreExceptionDispatchInfo_ExceptionDispatchInfo;
		public virtual RMethod RMRestoreExceptionDispatchInfo_ExceptionDispatchInfo
		{
			get
			{
				if(r_MRestoreExceptionDispatchInfo_ExceptionDispatchInfo == null)
				{
					r_MRestoreExceptionDispatchInfo_ExceptionDispatchInfo = new(this, "RestoreExceptionDispatchInfo", 0, typeof(System.Runtime.ExceptionServices.ExceptionDispatchInfo));
					r_MRestoreExceptionDispatchInfo_ExceptionDispatchInfo.SetBelong(this.instance);
				}
				return r_MRestoreExceptionDispatchInfo_ExceptionDispatchInfo;
			}
		}

		/// <summary>
		/// System.String InternalToString()
		/// </summary>
		protected RMethod r_MInternalToString;
		public virtual RMethod RMInternalToString
		{
			get
			{
				if(r_MInternalToString == null)
				{
					r_MInternalToString = new(this, "InternalToString", 0);
					r_MInternalToString.SetBelong(this.instance);
				}
				return r_MInternalToString;
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
		/// Boolean nIsTransient(Int32)
		/// </summary>
		protected static RMethod r_MnIsTransient_Int32;
		public static RMethod RMnIsTransient_Int32
		{
			get
			{
				if(r_MnIsTransient_Int32 == null)
				{
					r_MnIsTransient_Int32 = new(typeof(System.Exception), "nIsTransient", 0, typeof(System.Int32));
					r_MnIsTransient_Int32.SetBelong(null);
				}
				return r_MnIsTransient_Int32;
			}
		}

		/// <summary>
		/// System.String GetMessageFromNativeResources(ExceptionMessageKind)
		/// </summary>
		protected static RMethod r_MGetMessageFromNativeResources_ExceptionMessageKind;
		public static RMethod RMGetMessageFromNativeResources_ExceptionMessageKind
		{
			get
			{
				if(r_MGetMessageFromNativeResources_ExceptionMessageKind == null)
				{
					r_MGetMessageFromNativeResources_ExceptionMessageKind = new(typeof(System.Exception), "GetMessageFromNativeResources", 0,  ReflectionUtils.GetType("System.Exception+ExceptionMessageKind"));
					r_MGetMessageFromNativeResources_ExceptionMessageKind.SetBelong(null);
				}
				return r_MGetMessageFromNativeResources_ExceptionMessageKind;
			}
		}

		/// <summary>
		/// Void SetMessage(System.String)
		/// </summary>
		protected RMethod r_MSetMessage_String;
		public virtual RMethod RMSetMessage_String
		{
			get
			{
				if(r_MSetMessage_String == null)
				{
					r_MSetMessage_String = new(this, "SetMessage", 0, typeof(System.String));
					r_MSetMessage_String.SetBelong(this.instance);
				}
				return r_MSetMessage_String;
			}
		}

		/// <summary>
		/// Void SetStackTrace(System.String)
		/// </summary>
		protected RMethod r_MSetStackTrace_String;
		public virtual RMethod RMSetStackTrace_String
		{
			get
			{
				if(r_MSetStackTrace_String == null)
				{
					r_MSetStackTrace_String = new(this, "SetStackTrace", 0, typeof(System.String));
					r_MSetStackTrace_String.SetBelong(this.instance);
				}
				return r_MSetStackTrace_String;
			}
		}

		/// <summary>
		/// System.Exception FixRemotingException()
		/// </summary>
		protected RMethod r_MFixRemotingException;
		public virtual RMethod RMFixRemotingException
		{
			get
			{
				if(r_MFixRemotingException == null)
				{
					r_MFixRemotingException = new(this, "FixRemotingException", 0);
					r_MFixRemotingException.SetBelong(this.instance);
				}
				return r_MFixRemotingException;
			}
		}

		/// <summary>
		/// Void ReportUnhandledException(System.Exception)
		/// </summary>
		protected static RMethod r_MReportUnhandledException_Exception;
		public static RMethod RMReportUnhandledException_Exception
		{
			get
			{
				if(r_MReportUnhandledException_Exception == null)
				{
					r_MReportUnhandledException_Exception = new(typeof(System.Exception), "ReportUnhandledException", 0, typeof(System.Exception));
					r_MReportUnhandledException_Exception.SetBelong(null);
				}
				return r_MReportUnhandledException_Exception;
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
            var ___result = RMInit.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsImmutableAgileException(System.Exception @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMIsImmutableAgileException_Exception.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void AddExceptionDataForRestrictedErrorInfo(System.String @restrictedError, System.String @restrictedErrorReference, System.String @restrictedCapabilitySid, System.Object @restrictedErrorObject, System.Boolean @hasrestrictedLanguageErrorObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@restrictedError, @restrictedErrorReference, @restrictedCapabilitySid, @restrictedErrorObject, @hasrestrictedLanguageErrorObject};
            var ___result = RMAddExceptionDataForRestrictedErrorInfo_String_String_String_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryGetRestrictedLanguageErrorObject(out System.Object @restrictedErrorObject)
        {
			@restrictedErrorObject = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@restrictedErrorObject};
            var ___result = RMTryGetRestrictedLanguageErrorObject_Out_Object.Invoke(___genericsType, ___parameters);
			@restrictedErrorObject = (System.Object)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual System.String GetClassName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetClassName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Exception GetBaseException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetBaseException.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.String GetStackTrace(System.Boolean @needFileInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@needFileInfo};
            var ___result = RMGetStackTrace_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void SetErrorCode(System.Int32 @hr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hr};
            var ___result = RMSetErrorCode_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.Boolean @needFileLineInfo, System.Boolean @needMessage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@needFileLineInfo, @needMessage};
            var ___result = RMToString_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Exception PrepForRemoting()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPrepForRemoting.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual void OnDeserialized(System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context};
            var ___result = RMOnDeserialized_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalPreserveStackTrace()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalPreserveStackTrace.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String StripFileInfo(System.String @stackTrace, System.Boolean @isRemoteStackTrace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stackTrace, @isRemoteStackTrace};
            var ___result = RMStripFileInfo_String_Boolean.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void RestoreExceptionDispatchInfo(System.Runtime.ExceptionServices.ExceptionDispatchInfo @exceptionDispatchInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exceptionDispatchInfo};
            var ___result = RMRestoreExceptionDispatchInfo_ExceptionDispatchInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String InternalToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public static System.Boolean nIsTransient(System.Int32 @hr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hr};
            var ___result = RMnIsTransient_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String GetMessageFromNativeResources(RSystem.RException.RExceptionMessageKind @kind)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@kind.Value};
            var ___result = RMGetMessageFromNativeResources_ExceptionMessageKind.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void SetMessage(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RMSetMessage_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetStackTrace(System.String @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RMSetStackTrace_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Exception FixRemotingException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFixRemotingException.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public static void ReportUnhandledException(System.Exception @exception)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exception};
            var ___result = RMReportUnhandledException_Exception.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
