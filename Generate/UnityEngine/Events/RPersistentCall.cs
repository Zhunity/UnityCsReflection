using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.REvents
{
	/// <summary>
	/// UnityEngine.Events.PersistentCall
	/// </summary>
    public partial class RPersistentCall : RMember //
    {

		/// <summary>
		/// UnityEngine.Object m_Target
		/// </summary>
		protected RUnityEngine.RObject r_m_Target;
		public virtual RUnityEngine.RObject Rm_Target
		{
			get
			{
				if(r_m_Target == null)
				{
					r_m_Target = new(this, "m_Target");
					r_m_Target.SetBelong(this.instance);
				}
				return r_m_Target;
			}
		}

		/// <summary>
		/// System.String m_TargetAssemblyTypeName
		/// </summary>
		protected RField r_m_TargetAssemblyTypeName;
		public virtual RField Rm_TargetAssemblyTypeName
		{
			get
			{
				if(r_m_TargetAssemblyTypeName == null)
				{
					r_m_TargetAssemblyTypeName = new(this, "m_TargetAssemblyTypeName");
					r_m_TargetAssemblyTypeName.SetBelong(this.instance);
				}
				return r_m_TargetAssemblyTypeName;
			}
		}

		/// <summary>
		/// System.String m_MethodName
		/// </summary>
		protected RField r_m_MethodName;
		public virtual RField Rm_MethodName
		{
			get
			{
				if(r_m_MethodName == null)
				{
					r_m_MethodName = new(this, "m_MethodName");
					r_m_MethodName.SetBelong(this.instance);
				}
				return r_m_MethodName;
			}
		}

		/// <summary>
		/// UnityEngine.Events.PersistentListenerMode m_Mode
		/// </summary>
		protected RField r_m_Mode;
		public virtual RField Rm_Mode
		{
			get
			{
				if(r_m_Mode == null)
				{
					r_m_Mode = new(this, "m_Mode");
					r_m_Mode.SetBelong(this.instance);
				}
				return r_m_Mode;
			}
		}

		/// <summary>
		/// UnityEngine.Events.ArgumentCache m_Arguments
		/// </summary>
		protected RUnityEngine.REvents.RArgumentCache r_m_Arguments;
		public virtual RUnityEngine.REvents.RArgumentCache Rm_Arguments
		{
			get
			{
				if(r_m_Arguments == null)
				{
					r_m_Arguments = new(this, "m_Arguments");
					r_m_Arguments.SetBelong(this.instance);
				}
				return r_m_Arguments;
			}
		}

		/// <summary>
		/// UnityEngine.Events.UnityEventCallState m_CallState
		/// </summary>
		protected RField r_m_CallState;
		public virtual RField Rm_CallState
		{
			get
			{
				if(r_m_CallState == null)
				{
					r_m_CallState = new(this, "m_CallState");
					r_m_CallState.SetBelong(this.instance);
				}
				return r_m_CallState;
			}
		}

		/// <summary>
		/// UnityEngine.Object target
		/// </summary>
		protected RUnityEngine.RObject r_target;
		public virtual RUnityEngine.RObject Rtarget
		{
			get
			{
				if(r_target == null)
				{
					r_target = new(this, "target", -1);
					r_target.SetBelong(this.instance);
				}
				return r_target;
			}
		}

		/// <summary>
		/// System.String targetAssemblyTypeName
		/// </summary>
		protected RProperty r_targetAssemblyTypeName;
		public virtual RProperty RtargetAssemblyTypeName
		{
			get
			{
				if(r_targetAssemblyTypeName == null)
				{
					r_targetAssemblyTypeName = new(this, "targetAssemblyTypeName", -1);
					r_targetAssemblyTypeName.SetBelong(this.instance);
				}
				return r_targetAssemblyTypeName;
			}
		}

		/// <summary>
		/// System.String methodName
		/// </summary>
		protected RProperty r_methodName;
		public virtual RProperty RmethodName
		{
			get
			{
				if(r_methodName == null)
				{
					r_methodName = new(this, "methodName", -1);
					r_methodName.SetBelong(this.instance);
				}
				return r_methodName;
			}
		}

		/// <summary>
		/// UnityEngine.Events.PersistentListenerMode mode
		/// </summary>
		protected RProperty r_mode;
		public virtual RProperty Rmode
		{
			get
			{
				if(r_mode == null)
				{
					r_mode = new(this, "mode", -1);
					r_mode.SetBelong(this.instance);
				}
				return r_mode;
			}
		}

		/// <summary>
		/// UnityEngine.Events.ArgumentCache arguments
		/// </summary>
		protected RUnityEngine.REvents.RArgumentCache r_arguments;
		public virtual RUnityEngine.REvents.RArgumentCache Rarguments
		{
			get
			{
				if(r_arguments == null)
				{
					r_arguments = new(this, "arguments", -1);
					r_arguments.SetBelong(this.instance);
				}
				return r_arguments;
			}
		}

		/// <summary>
		/// UnityEngine.Events.UnityEventCallState callState
		/// </summary>
		protected RProperty r_callState;
		public virtual RProperty RcallState
		{
			get
			{
				if(r_callState == null)
				{
					r_callState = new(this, "callState", -1);
					r_callState.SetBelong(this.instance);
				}
				return r_callState;
			}
		}

		/// <summary>
		/// Boolean IsValid()
		/// </summary>
		protected RMethod r_RIsValid;
		public virtual RMethod RIsValid
		{
			get
			{
				if(r_RIsValid == null)
				{
					r_RIsValid = new(this, "IsValid", 0);
					r_RIsValid.SetBelong(this.instance);
				}
				return r_RIsValid;
			}
		}

		/// <summary>
		/// UnityEngine.Events.BaseInvokableCall GetRuntimeCall(UnityEngine.Events.UnityEventBase)
		/// </summary>
		protected RMethod r_RGetRuntimeCall_UnityEventBase;
		public virtual RMethod RGetRuntimeCall_UnityEventBase
		{
			get
			{
				if(r_RGetRuntimeCall_UnityEventBase == null)
				{
					r_RGetRuntimeCall_UnityEventBase = new(this, "GetRuntimeCall", 0, typeof(UnityEngine.Events.UnityEventBase));
					r_RGetRuntimeCall_UnityEventBase.SetBelong(this.instance);
				}
				return r_RGetRuntimeCall_UnityEventBase;
			}
		}

		/// <summary>
		/// UnityEngine.Events.BaseInvokableCall GetObjectCall(UnityEngine.Object, System.Reflection.MethodInfo, UnityEngine.Events.ArgumentCache)
		/// </summary>
		protected static RMethod r_RGetObjectCall_Object_MethodInfo_ArgumentCache;
		public static RMethod RGetObjectCall_Object_MethodInfo_ArgumentCache
		{
			get
			{
				if(r_RGetObjectCall_Object_MethodInfo_ArgumentCache == null)
				{
					r_RGetObjectCall_Object_MethodInfo_ArgumentCache = new( ReleactionUtils.GetType("UnityEngine.Events.PersistentCall"), "GetObjectCall", 0, typeof(UnityEngine.Object), typeof(System.Reflection.MethodInfo),  ReleactionUtils.GetType("UnityEngine.Events.ArgumentCache"));
					r_RGetObjectCall_Object_MethodInfo_ArgumentCache.SetBelong(null);
				}
				return r_RGetObjectCall_Object_MethodInfo_ArgumentCache;
			}
		}

		/// <summary>
		/// Void RegisterPersistentListener(UnityEngine.Object, System.Type, System.String)
		/// </summary>
		protected RMethod r_RRegisterPersistentListener_Object_Type_String;
		public virtual RMethod RRegisterPersistentListener_Object_Type_String
		{
			get
			{
				if(r_RRegisterPersistentListener_Object_Type_String == null)
				{
					r_RRegisterPersistentListener_Object_Type_String = new(this, "RegisterPersistentListener", 0, typeof(UnityEngine.Object), typeof(System.Type), typeof(System.String));
					r_RRegisterPersistentListener_Object_Type_String.SetBelong(this.instance);
				}
				return r_RRegisterPersistentListener_Object_Type_String;
			}
		}

		/// <summary>
		/// Void UnregisterPersistentListener()
		/// </summary>
		protected RMethod r_RUnregisterPersistentListener;
		public virtual RMethod RUnregisterPersistentListener
		{
			get
			{
				if(r_RUnregisterPersistentListener == null)
				{
					r_RUnregisterPersistentListener = new(this, "UnregisterPersistentListener", 0);
					r_RUnregisterPersistentListener.SetBelong(this.instance);
				}
				return r_RUnregisterPersistentListener;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_ROnBeforeSerialize;
		public virtual RMethod ROnBeforeSerialize
		{
			get
			{
				if(r_ROnBeforeSerialize == null)
				{
					r_ROnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
					r_ROnBeforeSerialize.SetBelong(this.instance);
				}
				return r_ROnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_ROnAfterDeserialize;
		public virtual RMethod ROnAfterDeserialize
		{
			get
			{
				if(r_ROnAfterDeserialize == null)
				{
					r_ROnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
					r_ROnAfterDeserialize.SetBelong(this.instance);
				}
				return r_ROnAfterDeserialize;
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


        public RPersistentCall() : base("UnityEngine.Events.PersistentCall")
        {
        }

        public RPersistentCall(System.Object instance) : base("UnityEngine.Events.PersistentCall")
		{
            SetInstance(instance);
		}

        public RPersistentCall(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPersistentCall(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean IsValid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsValid.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object GetRuntimeCall(UnityEngine.Events.UnityEventBase  @theEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@theEvent};
            var ___result = RGetRuntimeCall_UnityEventBase.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual void RegisterPersistentListener(UnityEngine.Object  @ttarget, System.Type  @targetType, System.String  @mmethodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ttarget, @targetType, @mmethodName};
            var ___result = RRegisterPersistentListener_Object_Type_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterPersistentListener()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnregisterPersistentListener.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
