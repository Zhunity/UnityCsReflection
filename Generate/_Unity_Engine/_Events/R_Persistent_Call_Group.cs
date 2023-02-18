
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.REvents
{
	/// <summary>
	/// UnityEngine.Events.PersistentCallGroup
	/// </summary>
    public partial class RPersistentCallGroup : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Events.PersistentCall] m_Calls
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.REvents.RPersistentCall> r_Fm_Calls;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.REvents.RPersistentCall> RFm_Calls
		{
			get
			{
				if(r_Fm_Calls == null)
				{
					r_Fm_Calls = new(this, "m_Calls");
				}
				return r_Fm_Calls;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPCount
		{
			get
			{
				if(r_PCount == null)
				{
					r_PCount = new(this, "Count", -1);
				}
				return r_PCount;
			}
		}

		/// <summary>
		/// UnityEngine.Events.PersistentCall GetListener(Int32)
		/// </summary>
		protected RMethod r_MGetListener_Int32;
		public virtual RMethod RMGetListener_Int32
		{
			get
			{
				if(r_MGetListener_Int32 == null)
				{
					r_MGetListener_Int32 = new(this, "GetListener", 0, typeof(System.Int32));
				}
				return r_MGetListener_Int32;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.Events.PersistentCall] GetListeners()
		/// </summary>
		protected RMethod r_MGetListeners;
		public virtual RMethod RMGetListeners
		{
			get
			{
				if(r_MGetListeners == null)
				{
					r_MGetListeners = new(this, "GetListeners", 0);
				}
				return r_MGetListeners;
			}
		}

		/// <summary>
		/// Void AddListener()
		/// </summary>
		protected RMethod r_MAddListener;
		public virtual RMethod RMAddListener
		{
			get
			{
				if(r_MAddListener == null)
				{
					r_MAddListener = new(this, "AddListener", 0);
				}
				return r_MAddListener;
			}
		}

		/// <summary>
		/// Void AddListener(UnityEngine.Events.PersistentCall)
		/// </summary>
		protected RMethod r_MAddListener_PersistentCall;
		public virtual RMethod RMAddListener_PersistentCall
		{
			get
			{
				if(r_MAddListener_PersistentCall == null)
				{
					r_MAddListener_PersistentCall = new(this, "AddListener", 0,  ReflectionUtils.GetType("UnityEngine.Events.PersistentCall"));
				}
				return r_MAddListener_PersistentCall;
			}
		}

		/// <summary>
		/// Void RemoveListener(Int32)
		/// </summary>
		protected RMethod r_MRemoveListener_Int32;
		public virtual RMethod RMRemoveListener_Int32
		{
			get
			{
				if(r_MRemoveListener_Int32 == null)
				{
					r_MRemoveListener_Int32 = new(this, "RemoveListener", 0, typeof(System.Int32));
				}
				return r_MRemoveListener_Int32;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_MClear;
		public virtual RMethod RMClear
		{
			get
			{
				if(r_MClear == null)
				{
					r_MClear = new(this, "Clear", 0);
				}
				return r_MClear;
			}
		}

		/// <summary>
		/// Void RegisterEventPersistentListener(Int32, UnityEngine.Object, System.Type, System.String)
		/// </summary>
		protected RMethod r_MRegisterEventPersistentListener_Int32_Object_Type_String;
		public virtual RMethod RMRegisterEventPersistentListener_Int32_Object_Type_String
		{
			get
			{
				if(r_MRegisterEventPersistentListener_Int32_Object_Type_String == null)
				{
					r_MRegisterEventPersistentListener_Int32_Object_Type_String = new(this, "RegisterEventPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Object), typeof(System.Type), typeof(System.String));
				}
				return r_MRegisterEventPersistentListener_Int32_Object_Type_String;
			}
		}

		/// <summary>
		/// Void RegisterVoidPersistentListener(Int32, UnityEngine.Object, System.Type, System.String)
		/// </summary>
		protected RMethod r_MRegisterVoidPersistentListener_Int32_Object_Type_String;
		public virtual RMethod RMRegisterVoidPersistentListener_Int32_Object_Type_String
		{
			get
			{
				if(r_MRegisterVoidPersistentListener_Int32_Object_Type_String == null)
				{
					r_MRegisterVoidPersistentListener_Int32_Object_Type_String = new(this, "RegisterVoidPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Object), typeof(System.Type), typeof(System.String));
				}
				return r_MRegisterVoidPersistentListener_Int32_Object_Type_String;
			}
		}

		/// <summary>
		/// Void RegisterObjectPersistentListener(Int32, UnityEngine.Object, System.Type, UnityEngine.Object, System.String)
		/// </summary>
		protected RMethod r_MRegisterObjectPersistentListener_Int32_Object_Type_Object_String;
		public virtual RMethod RMRegisterObjectPersistentListener_Int32_Object_Type_Object_String
		{
			get
			{
				if(r_MRegisterObjectPersistentListener_Int32_Object_Type_Object_String == null)
				{
					r_MRegisterObjectPersistentListener_Int32_Object_Type_Object_String = new(this, "RegisterObjectPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Object), typeof(System.Type), typeof(UnityEngine.Object), typeof(System.String));
				}
				return r_MRegisterObjectPersistentListener_Int32_Object_Type_Object_String;
			}
		}

		/// <summary>
		/// Void RegisterIntPersistentListener(Int32, UnityEngine.Object, System.Type, Int32, System.String)
		/// </summary>
		protected RMethod r_MRegisterIntPersistentListener_Int32_Object_Type_Int32_String;
		public virtual RMethod RMRegisterIntPersistentListener_Int32_Object_Type_Int32_String
		{
			get
			{
				if(r_MRegisterIntPersistentListener_Int32_Object_Type_Int32_String == null)
				{
					r_MRegisterIntPersistentListener_Int32_Object_Type_Int32_String = new(this, "RegisterIntPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Object), typeof(System.Type), typeof(System.Int32), typeof(System.String));
				}
				return r_MRegisterIntPersistentListener_Int32_Object_Type_Int32_String;
			}
		}

		/// <summary>
		/// Void RegisterFloatPersistentListener(Int32, UnityEngine.Object, System.Type, Single, System.String)
		/// </summary>
		protected RMethod r_MRegisterFloatPersistentListener_Int32_Object_Type_Single_String;
		public virtual RMethod RMRegisterFloatPersistentListener_Int32_Object_Type_Single_String
		{
			get
			{
				if(r_MRegisterFloatPersistentListener_Int32_Object_Type_Single_String == null)
				{
					r_MRegisterFloatPersistentListener_Int32_Object_Type_Single_String = new(this, "RegisterFloatPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Object), typeof(System.Type), typeof(System.Single), typeof(System.String));
				}
				return r_MRegisterFloatPersistentListener_Int32_Object_Type_Single_String;
			}
		}

		/// <summary>
		/// Void RegisterStringPersistentListener(Int32, UnityEngine.Object, System.Type, System.String, System.String)
		/// </summary>
		protected RMethod r_MRegisterStringPersistentListener_Int32_Object_Type_String_String;
		public virtual RMethod RMRegisterStringPersistentListener_Int32_Object_Type_String_String
		{
			get
			{
				if(r_MRegisterStringPersistentListener_Int32_Object_Type_String_String == null)
				{
					r_MRegisterStringPersistentListener_Int32_Object_Type_String_String = new(this, "RegisterStringPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Object), typeof(System.Type), typeof(System.String), typeof(System.String));
				}
				return r_MRegisterStringPersistentListener_Int32_Object_Type_String_String;
			}
		}

		/// <summary>
		/// Void RegisterBoolPersistentListener(Int32, UnityEngine.Object, System.Type, Boolean, System.String)
		/// </summary>
		protected RMethod r_MRegisterBoolPersistentListener_Int32_Object_Type_Boolean_String;
		public virtual RMethod RMRegisterBoolPersistentListener_Int32_Object_Type_Boolean_String
		{
			get
			{
				if(r_MRegisterBoolPersistentListener_Int32_Object_Type_Boolean_String == null)
				{
					r_MRegisterBoolPersistentListener_Int32_Object_Type_Boolean_String = new(this, "RegisterBoolPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Object), typeof(System.Type), typeof(System.Boolean), typeof(System.String));
				}
				return r_MRegisterBoolPersistentListener_Int32_Object_Type_Boolean_String;
			}
		}

		/// <summary>
		/// Void UnregisterPersistentListener(Int32)
		/// </summary>
		protected RMethod r_MUnregisterPersistentListener_Int32;
		public virtual RMethod RMUnregisterPersistentListener_Int32
		{
			get
			{
				if(r_MUnregisterPersistentListener_Int32 == null)
				{
					r_MUnregisterPersistentListener_Int32 = new(this, "UnregisterPersistentListener", 0, typeof(System.Int32));
				}
				return r_MUnregisterPersistentListener_Int32;
			}
		}

		/// <summary>
		/// Void RemoveListeners(UnityEngine.Object, System.String)
		/// </summary>
		protected RMethod r_MRemoveListeners_Object_String;
		public virtual RMethod RMRemoveListeners_Object_String
		{
			get
			{
				if(r_MRemoveListeners_Object_String == null)
				{
					r_MRemoveListeners_Object_String = new(this, "RemoveListeners", 0, typeof(UnityEngine.Object), typeof(System.String));
				}
				return r_MRemoveListeners_Object_String;
			}
		}

		/// <summary>
		/// Void Initialize(UnityEngine.Events.InvokableCallList, UnityEngine.Events.UnityEventBase)
		/// </summary>
		protected RMethod r_MInitialize_InvokableCallList_UnityEventBase;
		public virtual RMethod RMInitialize_InvokableCallList_UnityEventBase
		{
			get
			{
				if(r_MInitialize_InvokableCallList_UnityEventBase == null)
				{
					r_MInitialize_InvokableCallList_UnityEventBase = new(this, "Initialize", 0,  ReflectionUtils.GetType("UnityEngine.Events.InvokableCallList"), typeof(UnityEngine.Events.UnityEventBase));
				}
				return r_MInitialize_InvokableCallList_UnityEventBase;
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


        public RPersistentCallGroup() : base("UnityEngine.Events.PersistentCallGroup")
        {
        }

        public RPersistentCallGroup(System.Object instance) : base("UnityEngine.Events.PersistentCallGroup")
		{
            SetInstance(instance);
		}

        public RPersistentCallGroup(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPersistentCallGroup(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual Hvak.Editor.Refleaction.RUnityEngine.REvents.RPersistentCall GetListener(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMGetListener_Int32.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.REvents.RPersistentCall(___result);
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.REvents.RPersistentCall> GetListeners()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetListeners.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.REvents.RPersistentCall>(___result);
        }


        public virtual void AddListener()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAddListener.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddListener(Hvak.Editor.Refleaction.RUnityEngine.REvents.RPersistentCall @call)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call.Value};
            var ___result = RMAddListener_PersistentCall.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveListener(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMRemoveListener_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterEventPersistentListener(System.Int32 @index, UnityEngine.Object @targetObj, System.Type @targetObjType, System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @targetObj, @targetObjType, @methodName};
            var ___result = RMRegisterEventPersistentListener_Int32_Object_Type_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterVoidPersistentListener(System.Int32 @index, UnityEngine.Object @targetObj, System.Type @targetObjType, System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @targetObj, @targetObjType, @methodName};
            var ___result = RMRegisterVoidPersistentListener_Int32_Object_Type_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterObjectPersistentListener(System.Int32 @index, UnityEngine.Object @targetObj, System.Type @targetObjType, UnityEngine.Object @argument, System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @targetObj, @targetObjType, @argument, @methodName};
            var ___result = RMRegisterObjectPersistentListener_Int32_Object_Type_Object_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterIntPersistentListener(System.Int32 @index, UnityEngine.Object @targetObj, System.Type @targetObjType, System.Int32 @argument, System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @targetObj, @targetObjType, @argument, @methodName};
            var ___result = RMRegisterIntPersistentListener_Int32_Object_Type_Int32_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterFloatPersistentListener(System.Int32 @index, UnityEngine.Object @targetObj, System.Type @targetObjType, System.Single @argument, System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @targetObj, @targetObjType, @argument, @methodName};
            var ___result = RMRegisterFloatPersistentListener_Int32_Object_Type_Single_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterStringPersistentListener(System.Int32 @index, UnityEngine.Object @targetObj, System.Type @targetObjType, System.String @argument, System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @targetObj, @targetObjType, @argument, @methodName};
            var ___result = RMRegisterStringPersistentListener_Int32_Object_Type_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterBoolPersistentListener(System.Int32 @index, UnityEngine.Object @targetObj, System.Type @targetObjType, System.Boolean @argument, System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @targetObj, @targetObjType, @argument, @methodName};
            var ___result = RMRegisterBoolPersistentListener_Int32_Object_Type_Boolean_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterPersistentListener(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMUnregisterPersistentListener_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveListeners(UnityEngine.Object @target, System.String @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @methodName};
            var ___result = RMRemoveListeners_Object_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initialize(Hvak.Editor.Refleaction.RUnityEngine.REvents.RInvokableCallList @invokableList, UnityEngine.Events.UnityEventBase @unityEventBase)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@invokableList.Value, @unityEventBase};
            var ___result = RMInitialize_InvokableCallList_UnityEventBase.Invoke(___genericsType, ___parameters);

            
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
