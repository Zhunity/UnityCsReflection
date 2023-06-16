
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.REvents
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.Events.PersistentCall
	/// </summary>
    public partial class RPersistentCall : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.Events.PersistentCall");
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


		/// <summary>
		/// UnityEngine.Object m_Target
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RObject r_Fm_Target;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RObject RFm_Target
		{
			get
			{
				if(r_Fm_Target == null)
				{
					r_Fm_Target = new(this, "m_Target");
				}
				return r_Fm_Target;
			}
		}

		/// <summary>
		/// System.String m_TargetAssemblyTypeName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_TargetAssemblyTypeName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_TargetAssemblyTypeName
		{
			get
			{
				if(r_Fm_TargetAssemblyTypeName == null)
				{
					r_Fm_TargetAssemblyTypeName = new(this, "m_TargetAssemblyTypeName");
				}
				return r_Fm_TargetAssemblyTypeName;
			}
		}

		/// <summary>
		/// System.String m_MethodName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_MethodName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_MethodName
		{
			get
			{
				if(r_Fm_MethodName == null)
				{
					r_Fm_MethodName = new(this, "m_MethodName");
				}
				return r_Fm_MethodName;
			}
		}

		/// <summary>
		/// UnityEngine.Events.PersistentListenerMode m_Mode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.REvents.RPersistentListenerMode r_Fm_Mode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.REvents.RPersistentListenerMode RFm_Mode
		{
			get
			{
				if(r_Fm_Mode == null)
				{
					r_Fm_Mode = new(this, "m_Mode");
				}
				return r_Fm_Mode;
			}
		}

		/// <summary>
		/// UnityEngine.Events.ArgumentCache m_Arguments
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.REvents.RArgumentCache r_Fm_Arguments;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.REvents.RArgumentCache RFm_Arguments
		{
			get
			{
				if(r_Fm_Arguments == null)
				{
					r_Fm_Arguments = new(this, "m_Arguments");
				}
				return r_Fm_Arguments;
			}
		}

		/// <summary>
		/// UnityEngine.Events.UnityEventCallState m_CallState
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.REvents.RUnityEventCallState r_Fm_CallState;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.REvents.RUnityEventCallState RFm_CallState
		{
			get
			{
				if(r_Fm_CallState == null)
				{
					r_Fm_CallState = new(this, "m_CallState");
				}
				return r_Fm_CallState;
			}
		}

		/// <summary>
		/// UnityEngine.Object target
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RObject r_Ptarget;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RObject RPtarget
		{
			get
			{
				if(r_Ptarget == null)
				{
					r_Ptarget = new(this, "target", -1);
				}
				return r_Ptarget;
			}
		}

		/// <summary>
		/// System.String targetAssemblyTypeName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PtargetAssemblyTypeName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtargetAssemblyTypeName
		{
			get
			{
				if(r_PtargetAssemblyTypeName == null)
				{
					r_PtargetAssemblyTypeName = new(this, "targetAssemblyTypeName", -1);
				}
				return r_PtargetAssemblyTypeName;
			}
		}

		/// <summary>
		/// System.String methodName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PmethodName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPmethodName
		{
			get
			{
				if(r_PmethodName == null)
				{
					r_PmethodName = new(this, "methodName", -1);
				}
				return r_PmethodName;
			}
		}

		/// <summary>
		/// UnityEngine.Events.PersistentListenerMode mode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.REvents.RPersistentListenerMode r_Pmode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.REvents.RPersistentListenerMode RPmode
		{
			get
			{
				if(r_Pmode == null)
				{
					r_Pmode = new(this, "mode", -1);
				}
				return r_Pmode;
			}
		}

		/// <summary>
		/// UnityEngine.Events.ArgumentCache arguments
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.REvents.RArgumentCache r_Parguments;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.REvents.RArgumentCache RParguments
		{
			get
			{
				if(r_Parguments == null)
				{
					r_Parguments = new(this, "arguments", -1);
				}
				return r_Parguments;
			}
		}

		/// <summary>
		/// UnityEngine.Events.UnityEventCallState callState
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.REvents.RUnityEventCallState r_PcallState;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.REvents.RUnityEventCallState RPcallState
		{
			get
			{
				if(r_PcallState == null)
				{
					r_PcallState = new(this, "callState", -1);
				}
				return r_PcallState;
			}
		}

		/// <summary>
		/// Boolean IsValid()
		/// </summary>
		protected RMethod r_MIsValid;
		public virtual RMethod RMIsValid
		{
			get
			{
				if(r_MIsValid == null)
				{
					r_MIsValid = new(this, "IsValid", 0);
				}
				return r_MIsValid;
			}
		}

		/// <summary>
		/// UnityEngine.Events.BaseInvokableCall GetRuntimeCall(UnityEngine.Events.UnityEventBase)
		/// </summary>
		protected RMethod r_MGetRuntimeCall_UnityEventBase;
		public virtual RMethod RMGetRuntimeCall_UnityEventBase
		{
			get
			{
				if(r_MGetRuntimeCall_UnityEventBase == null)
				{
					r_MGetRuntimeCall_UnityEventBase = new(this, "GetRuntimeCall", 0, typeof(UnityEngine.Events.UnityEventBase));
				}
				return r_MGetRuntimeCall_UnityEventBase;
			}
		}

		/// <summary>
		/// UnityEngine.Events.BaseInvokableCall GetObjectCall(UnityEngine.Object, System.Reflection.MethodInfo, UnityEngine.Events.ArgumentCache)
		/// </summary>
		protected static RMethod r_MGetObjectCall_Object_MethodInfo_ArgumentCache;
		public static RMethod RMGetObjectCall_Object_MethodInfo_ArgumentCache
		{
			get
			{
				if(r_MGetObjectCall_Object_MethodInfo_ArgumentCache == null)
				{
					r_MGetObjectCall_Object_MethodInfo_ArgumentCache = new(Type, "GetObjectCall", 0, typeof(UnityEngine.Object), typeof(System.Reflection.MethodInfo),  ReflectionUtils.GetType("UnityEngine.Events.ArgumentCache"));
				}
				return r_MGetObjectCall_Object_MethodInfo_ArgumentCache;
			}
		}

		/// <summary>
		/// Void RegisterPersistentListener(UnityEngine.Object, System.Type, System.String)
		/// </summary>
		protected RMethod r_MRegisterPersistentListener_Object_Type_String;
		public virtual RMethod RMRegisterPersistentListener_Object_Type_String
		{
			get
			{
				if(r_MRegisterPersistentListener_Object_Type_String == null)
				{
					r_MRegisterPersistentListener_Object_Type_String = new(this, "RegisterPersistentListener", 0, typeof(UnityEngine.Object), typeof(System.Type), typeof(System.String));
				}
				return r_MRegisterPersistentListener_Object_Type_String;
			}
		}

		/// <summary>
		/// Void UnregisterPersistentListener()
		/// </summary>
		protected RMethod r_MUnregisterPersistentListener;
		public virtual RMethod RMUnregisterPersistentListener
		{
			get
			{
				if(r_MUnregisterPersistentListener == null)
				{
					r_MUnregisterPersistentListener = new(this, "UnregisterPersistentListener", 0);
				}
				return r_MUnregisterPersistentListener;
			}
		}

		/// <summary>
		/// Void OnBeforeSerialize()
		/// </summary>
		protected RMethod r_MOnBeforeSerialize;
		public virtual RMethod RMOnBeforeSerialize
		{
			get
			{
				if(r_MOnBeforeSerialize == null)
				{
					r_MOnBeforeSerialize = new(this, "OnBeforeSerialize", 0);
				}
				return r_MOnBeforeSerialize;
			}
		}

		/// <summary>
		/// Void OnAfterDeserialize()
		/// </summary>
		protected RMethod r_MOnAfterDeserialize;
		public virtual RMethod RMOnAfterDeserialize
		{
			get
			{
				if(r_MOnAfterDeserialize == null)
				{
					r_MOnAfterDeserialize = new(this, "OnAfterDeserialize", 0);
				}
				return r_MOnAfterDeserialize;
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
				}
				return r_MToString;
			}
		}


        public virtual System.Boolean IsValid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsValid.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.REvents.RBaseInvokableCall GetRuntimeCall(UnityEngine.Events.UnityEventBase @theEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@theEvent};
            var ___result = RMGetRuntimeCall_UnityEventBase.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.REvents.RBaseInvokableCall>(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.REvents.RBaseInvokableCall GetObjectCall(UnityEngine.Object @target, System.Reflection.MethodInfo @method, Hvak.Editor.Refleaction.RUnityEngine.REvents.RArgumentCache @arguments)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @method, @arguments.Value};
            var ___result = RMGetObjectCall_Object_MethodInfo_ArgumentCache.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.REvents.RBaseInvokableCall>(___result);
        }


        public virtual void RegisterPersistentListener(UnityEngine.Object @ttarget, System.Type @targetType, System.String @mmethodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ttarget, @targetType, @mmethodName};
            var ___result = RMRegisterPersistentListener_Object_Type_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterPersistentListener()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnregisterPersistentListener.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBeforeSerialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnBeforeSerialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAfterDeserialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnAfterDeserialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
