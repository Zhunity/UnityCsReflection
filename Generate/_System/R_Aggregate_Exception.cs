
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.AggregateException
	/// </summary>
    public partial class RAggregateException : RMember //
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
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[System.Exception] m_innerExceptions
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<SMFrame.Editor.Refleaction.RSystem.RException> r_Fm_innerExceptions;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<SMFrame.Editor.Refleaction.RSystem.RException> RFm_innerExceptions
		{
			get
			{
				if(r_Fm_innerExceptions == null)
				{
					r_Fm_innerExceptions = new(this, "m_innerExceptions");
					r_Fm_innerExceptions.SetBelong(this.instance);
				}
				return r_Fm_innerExceptions;
			}
		}

		/// <summary>
		/// System.String _message
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_F_message;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RF_message
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
		/// System.Int32 _HResult
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_F_HResult;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RF_HResult
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
		/// System.Collections.ObjectModel.ReadOnlyCollection`1[System.Exception] InnerExceptions
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<SMFrame.Editor.Refleaction.RSystem.RException> r_PInnerExceptions;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RObjectModel.RReadOnlyCollection<SMFrame.Editor.Refleaction.RSystem.RException> RPInnerExceptions
		{
			get
			{
				if(r_PInnerExceptions == null)
				{
					r_PInnerExceptions = new(this, "InnerExceptions", -1);
					r_PInnerExceptions.SetBelong(this.instance);
				}
				return r_PInnerExceptions;
			}
		}

		/// <summary>
		/// System.String Message
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PMessage;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPMessage
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
		/// Int32 InnerExceptionCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PInnerExceptionCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPInnerExceptionCount
		{
			get
			{
				if(r_PInnerExceptionCount == null)
				{
					r_PInnerExceptionCount = new(this, "InnerExceptionCount", -1);
					r_PInnerExceptionCount.SetBelong(this.instance);
				}
				return r_PInnerExceptionCount;
			}
		}

		/// <summary>
		/// System.Collections.IDictionary Data
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RIDictionary r_PData;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RIDictionary RPData
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
		protected SMFrame.Editor.Refleaction.RSystem.RException r_PInnerException;
		public virtual SMFrame.Editor.Refleaction.RSystem.RException RPInnerException
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
		protected SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodBase r_PTargetSite;
		public virtual SMFrame.Editor.Refleaction.RSystem.RReflection.RMethodBase RPTargetSite
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
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PStackTrace;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPStackTrace
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
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PHelpLink;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPHelpLink
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
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PSource;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPSource
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
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PRemoteStackTrace;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPRemoteStackTrace
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
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_PHResult;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RPHResult
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
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsTransient;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsTransient
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
		/// Void Handle(System.Func`2[System.Exception,System.Boolean])
		/// </summary>
		protected RMethod r_MHandle_Func_d_Exception_Boolean_p_;
		public virtual RMethod RMHandle_Func_d_Exception_Boolean_p_
		{
			get
			{
				if(r_MHandle_Func_d_Exception_Boolean_p_ == null)
				{
					r_MHandle_Func_d_Exception_Boolean_p_ = new(this, "Handle", 0, typeof(System.Func<, >).MakeGenericType(typeof(System.Exception), typeof(System.Boolean)));
					r_MHandle_Func_d_Exception_Boolean_p_.SetBelong(this.instance);
				}
				return r_MHandle_Func_d_Exception_Boolean_p_;
			}
		}

		/// <summary>
		/// System.AggregateException Flatten()
		/// </summary>
		protected RMethod r_MFlatten;
		public virtual RMethod RMFlatten
		{
			get
			{
				if(r_MFlatten == null)
				{
					r_MFlatten = new(this, "Flatten", 0);
					r_MFlatten.SetBelong(this.instance);
				}
				return r_MFlatten;
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


        public RAggregateException() : base("System.AggregateException")
        {
        }

        public RAggregateException(System.Object instance) : base("System.AggregateException")
		{
            SetInstance(instance);
		}

        public RAggregateException(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAggregateException(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Exception GetBaseException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetBaseException.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual void Handle(System.Func<System.Exception, System.Boolean> @predicate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@predicate};
            var ___result = RMHandle_Func_d_Exception_Boolean_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.AggregateException Flatten()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFlatten.Invoke(___genericsType, ___parameters);

            return (System.AggregateException)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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


        public virtual void SetErrorCode(System.Int32 @hr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hr};
            var ___result = RMSetErrorCode_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Exception PrepForRemoting()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPrepForRemoting.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual void InternalPreserveStackTrace()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInternalPreserveStackTrace.Invoke(___genericsType, ___parameters);

            
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