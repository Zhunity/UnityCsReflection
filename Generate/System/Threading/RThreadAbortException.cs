using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.ThreadAbortException
	/// </summary>
    public partial class RThreadAbortException : RMember //
    {

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
		/// System.Object ExceptionState
		/// </summary>
		protected RSystem.RObject r_ExceptionState;
		public virtual RSystem.RObject RExceptionState
		{
			get
			{
				if(r_ExceptionState == null)
				{
					r_ExceptionState = new(this, "ExceptionState", -1);
					r_ExceptionState.SetBelong(this.instance);
				}
				return r_ExceptionState;
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
		public virtual RProperty RemoteStackTrace
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
		/// Void AddExceptionDataForRestrictedErrorInfo(System.String, System.String, System.String, System.Object, Boolean)
		/// </summary>
		protected RMethod r_RAddExceptionDataForRestrictedErrorInfo_String_String_String_Object_Boolean;
		public virtual RMethod RAddExceptionDataForRestrictedErrorInfo_String_String_String_Object_Boolean
		{
			get
			{
				if(r_RAddExceptionDataForRestrictedErrorInfo_String_String_String_Object_Boolean == null)
				{
					r_RAddExceptionDataForRestrictedErrorInfo_String_String_String_Object_Boolean = new(this, "AddExceptionDataForRestrictedErrorInfo", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Object), typeof(System.Boolean));
					r_RAddExceptionDataForRestrictedErrorInfo_String_String_String_Object_Boolean.SetBelong(this.instance);
				}
				return r_RAddExceptionDataForRestrictedErrorInfo_String_String_String_Object_Boolean;
			}
		}

		/// <summary>
		/// Boolean TryGetRestrictedLanguageErrorObject(System.Object ByRef)
		/// </summary>
		protected RMethod r_RTryGetRestrictedLanguageErrorObject_Out_Object;
		public virtual RMethod RTryGetRestrictedLanguageErrorObject_Out_Object
		{
			get
			{
				if(r_RTryGetRestrictedLanguageErrorObject_Out_Object == null)
				{
					r_RTryGetRestrictedLanguageErrorObject_Out_Object = new(this, "TryGetRestrictedLanguageErrorObject", 0, typeof(System.Object).MakeByRefType());
					r_RTryGetRestrictedLanguageErrorObject_Out_Object.SetBelong(this.instance);
				}
				return r_RTryGetRestrictedLanguageErrorObject_Out_Object;
			}
		}

		/// <summary>
		/// System.Exception GetBaseException()
		/// </summary>
		protected RMethod r_RGetBaseException;
		public virtual RMethod RGetBaseException
		{
			get
			{
				if(r_RGetBaseException == null)
				{
					r_RGetBaseException = new(this, "GetBaseException", 0);
					r_RGetBaseException.SetBelong(this.instance);
				}
				return r_RGetBaseException;
			}
		}

		/// <summary>
		/// Void SetErrorCode(Int32)
		/// </summary>
		protected RMethod r_RSetErrorCode_Int32;
		public virtual RMethod RSetErrorCode_Int32
		{
			get
			{
				if(r_RSetErrorCode_Int32 == null)
				{
					r_RSetErrorCode_Int32 = new(this, "SetErrorCode", 0, typeof(System.Int32));
					r_RSetErrorCode_Int32.SetBelong(this.instance);
				}
				return r_RSetErrorCode_Int32;
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
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RGetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_RGetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_RGetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_RGetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_RGetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// System.Exception PrepForRemoting()
		/// </summary>
		protected RMethod r_RPrepForRemoting;
		public virtual RMethod RPrepForRemoting
		{
			get
			{
				if(r_RPrepForRemoting == null)
				{
					r_RPrepForRemoting = new(this, "PrepForRemoting", 0);
					r_RPrepForRemoting.SetBelong(this.instance);
				}
				return r_RPrepForRemoting;
			}
		}

		/// <summary>
		/// Void InternalPreserveStackTrace()
		/// </summary>
		protected RMethod r_RInternalPreserveStackTrace;
		public virtual RMethod RInternalPreserveStackTrace
		{
			get
			{
				if(r_RInternalPreserveStackTrace == null)
				{
					r_RInternalPreserveStackTrace = new(this, "InternalPreserveStackTrace", 0);
					r_RInternalPreserveStackTrace.SetBelong(this.instance);
				}
				return r_RInternalPreserveStackTrace;
			}
		}

		/// <summary>
		/// Void RestoreExceptionDispatchInfo(System.Runtime.ExceptionServices.ExceptionDispatchInfo)
		/// </summary>
		protected RMethod r_RRestoreExceptionDispatchInfo_ExceptionDispatchInfo;
		public virtual RMethod RRestoreExceptionDispatchInfo_ExceptionDispatchInfo
		{
			get
			{
				if(r_RRestoreExceptionDispatchInfo_ExceptionDispatchInfo == null)
				{
					r_RRestoreExceptionDispatchInfo_ExceptionDispatchInfo = new(this, "RestoreExceptionDispatchInfo", 0, typeof(System.Runtime.ExceptionServices.ExceptionDispatchInfo));
					r_RRestoreExceptionDispatchInfo_ExceptionDispatchInfo.SetBelong(this.instance);
				}
				return r_RRestoreExceptionDispatchInfo_ExceptionDispatchInfo;
			}
		}

		/// <summary>
		/// System.String InternalToString()
		/// </summary>
		protected RMethod r_RInternalToString;
		public virtual RMethod RInternalToString
		{
			get
			{
				if(r_RInternalToString == null)
				{
					r_RInternalToString = new(this, "InternalToString", 0);
					r_RInternalToString.SetBelong(this.instance);
				}
				return r_RInternalToString;
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
		/// Void SetMessage(System.String)
		/// </summary>
		protected RMethod r_RSetMessage_String;
		public virtual RMethod RSetMessage_String
		{
			get
			{
				if(r_RSetMessage_String == null)
				{
					r_RSetMessage_String = new(this, "SetMessage", 0, typeof(System.String));
					r_RSetMessage_String.SetBelong(this.instance);
				}
				return r_RSetMessage_String;
			}
		}

		/// <summary>
		/// Void SetStackTrace(System.String)
		/// </summary>
		protected RMethod r_RSetStackTrace_String;
		public virtual RMethod RSetStackTrace_String
		{
			get
			{
				if(r_RSetStackTrace_String == null)
				{
					r_RSetStackTrace_String = new(this, "SetStackTrace", 0, typeof(System.String));
					r_RSetStackTrace_String.SetBelong(this.instance);
				}
				return r_RSetStackTrace_String;
			}
		}

		/// <summary>
		/// System.Exception FixRemotingException()
		/// </summary>
		protected RMethod r_RFixRemotingException;
		public virtual RMethod RFixRemotingException
		{
			get
			{
				if(r_RFixRemotingException == null)
				{
					r_RFixRemotingException = new(this, "FixRemotingException", 0);
					r_RFixRemotingException.SetBelong(this.instance);
				}
				return r_RFixRemotingException;
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


        public RThreadAbortException() : base("System.Threading.ThreadAbortException")
        {
        }

        public RThreadAbortException(System.Object instance) : base("System.Threading.ThreadAbortException")
		{
            SetInstance(instance);
		}

        public RThreadAbortException(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RThreadAbortException(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public virtual System.Exception GetBaseException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBaseException.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
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


        public virtual void InternalPreserveStackTrace()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalPreserveStackTrace.Invoke(___genericsType, ___parameters);

            
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
