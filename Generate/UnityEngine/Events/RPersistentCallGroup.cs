using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.REvents
{
	/// <summary>
	/// UnityEngine.Events.PersistentCallGroup
	/// </summary>
    public partial class RPersistentCallGroup : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Events.PersistentCall] m_Calls
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.REvents.RPersistentCall> r_m_Calls;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.REvents.RPersistentCall> Rm_Calls
		{
			get
			{
				if(r_m_Calls == null)
				{
					r_m_Calls = new(this, "m_Calls");
					r_m_Calls.SetBelong(this.instance);
				}
				return r_m_Calls;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected RProperty r_Count;
		public virtual RProperty RCount
		{
			get
			{
				if(r_Count == null)
				{
					r_Count = new(this, "Count", -1);
					r_Count.SetBelong(this.instance);
				}
				return r_Count;
			}
		}

		/// <summary>
		/// UnityEngine.Events.PersistentCall GetListener(Int32)
		/// </summary>
		protected RMethod r_RGetListener_Int32;
		public virtual RMethod RGetListener_Int32
		{
			get
			{
				if(r_RGetListener_Int32 == null)
				{
					r_RGetListener_Int32 = new(this, "GetListener", 0, typeof(System.Int32));
					r_RGetListener_Int32.SetBelong(this.instance);
				}
				return r_RGetListener_Int32;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.Events.PersistentCall] GetListeners()
		/// </summary>
		protected RMethod r_RGetListeners;
		public virtual RMethod RGetListeners
		{
			get
			{
				if(r_RGetListeners == null)
				{
					r_RGetListeners = new(this, "GetListeners", 0);
					r_RGetListeners.SetBelong(this.instance);
				}
				return r_RGetListeners;
			}
		}

		/// <summary>
		/// Void AddListener()
		/// </summary>
		protected RMethod r_RAddListener;
		public virtual RMethod RAddListener
		{
			get
			{
				if(r_RAddListener == null)
				{
					r_RAddListener = new(this, "AddListener", 0);
					r_RAddListener.SetBelong(this.instance);
				}
				return r_RAddListener;
			}
		}

		/// <summary>
		/// Void AddListener(UnityEngine.Events.PersistentCall)
		/// </summary>
		protected RMethod r_RAddListener_PersistentCall;
		public virtual RMethod RAddListener_PersistentCall
		{
			get
			{
				if(r_RAddListener_PersistentCall == null)
				{
					r_RAddListener_PersistentCall = new(this, "AddListener", 0,  ReleactionUtils.GetType("UnityEngine.Events.PersistentCall"));
					r_RAddListener_PersistentCall.SetBelong(this.instance);
				}
				return r_RAddListener_PersistentCall;
			}
		}

		/// <summary>
		/// Void RemoveListener(Int32)
		/// </summary>
		protected RMethod r_RRemoveListener_Int32;
		public virtual RMethod RRemoveListener_Int32
		{
			get
			{
				if(r_RRemoveListener_Int32 == null)
				{
					r_RRemoveListener_Int32 = new(this, "RemoveListener", 0, typeof(System.Int32));
					r_RRemoveListener_Int32.SetBelong(this.instance);
				}
				return r_RRemoveListener_Int32;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
			}
		}

		/// <summary>
		/// Void RegisterEventPersistentListener(Int32, UnityEngine.Object, System.Type, System.String)
		/// </summary>
		protected RMethod r_RRegisterEventPersistentListener_Int32_Object_Type_String;
		public virtual RMethod RRegisterEventPersistentListener_Int32_Object_Type_String
		{
			get
			{
				if(r_RRegisterEventPersistentListener_Int32_Object_Type_String == null)
				{
					r_RRegisterEventPersistentListener_Int32_Object_Type_String = new(this, "RegisterEventPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Object), typeof(System.Type), typeof(System.String));
					r_RRegisterEventPersistentListener_Int32_Object_Type_String.SetBelong(this.instance);
				}
				return r_RRegisterEventPersistentListener_Int32_Object_Type_String;
			}
		}

		/// <summary>
		/// Void RegisterVoidPersistentListener(Int32, UnityEngine.Object, System.Type, System.String)
		/// </summary>
		protected RMethod r_RRegisterVoidPersistentListener_Int32_Object_Type_String;
		public virtual RMethod RRegisterVoidPersistentListener_Int32_Object_Type_String
		{
			get
			{
				if(r_RRegisterVoidPersistentListener_Int32_Object_Type_String == null)
				{
					r_RRegisterVoidPersistentListener_Int32_Object_Type_String = new(this, "RegisterVoidPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Object), typeof(System.Type), typeof(System.String));
					r_RRegisterVoidPersistentListener_Int32_Object_Type_String.SetBelong(this.instance);
				}
				return r_RRegisterVoidPersistentListener_Int32_Object_Type_String;
			}
		}

		/// <summary>
		/// Void RegisterObjectPersistentListener(Int32, UnityEngine.Object, System.Type, UnityEngine.Object, System.String)
		/// </summary>
		protected RMethod r_RRegisterObjectPersistentListener_Int32_Object_Type_Object_String;
		public virtual RMethod RRegisterObjectPersistentListener_Int32_Object_Type_Object_String
		{
			get
			{
				if(r_RRegisterObjectPersistentListener_Int32_Object_Type_Object_String == null)
				{
					r_RRegisterObjectPersistentListener_Int32_Object_Type_Object_String = new(this, "RegisterObjectPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Object), typeof(System.Type), typeof(UnityEngine.Object), typeof(System.String));
					r_RRegisterObjectPersistentListener_Int32_Object_Type_Object_String.SetBelong(this.instance);
				}
				return r_RRegisterObjectPersistentListener_Int32_Object_Type_Object_String;
			}
		}

		/// <summary>
		/// Void RegisterIntPersistentListener(Int32, UnityEngine.Object, System.Type, Int32, System.String)
		/// </summary>
		protected RMethod r_RRegisterIntPersistentListener_Int32_Object_Type_Int32_String;
		public virtual RMethod RRegisterIntPersistentListener_Int32_Object_Type_Int32_String
		{
			get
			{
				if(r_RRegisterIntPersistentListener_Int32_Object_Type_Int32_String == null)
				{
					r_RRegisterIntPersistentListener_Int32_Object_Type_Int32_String = new(this, "RegisterIntPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Object), typeof(System.Type), typeof(System.Int32), typeof(System.String));
					r_RRegisterIntPersistentListener_Int32_Object_Type_Int32_String.SetBelong(this.instance);
				}
				return r_RRegisterIntPersistentListener_Int32_Object_Type_Int32_String;
			}
		}

		/// <summary>
		/// Void RegisterFloatPersistentListener(Int32, UnityEngine.Object, System.Type, Single, System.String)
		/// </summary>
		protected RMethod r_RRegisterFloatPersistentListener_Int32_Object_Type_Single_String;
		public virtual RMethod RRegisterFloatPersistentListener_Int32_Object_Type_Single_String
		{
			get
			{
				if(r_RRegisterFloatPersistentListener_Int32_Object_Type_Single_String == null)
				{
					r_RRegisterFloatPersistentListener_Int32_Object_Type_Single_String = new(this, "RegisterFloatPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Object), typeof(System.Type), typeof(System.Single), typeof(System.String));
					r_RRegisterFloatPersistentListener_Int32_Object_Type_Single_String.SetBelong(this.instance);
				}
				return r_RRegisterFloatPersistentListener_Int32_Object_Type_Single_String;
			}
		}

		/// <summary>
		/// Void RegisterStringPersistentListener(Int32, UnityEngine.Object, System.Type, System.String, System.String)
		/// </summary>
		protected RMethod r_RRegisterStringPersistentListener_Int32_Object_Type_String_String;
		public virtual RMethod RRegisterStringPersistentListener_Int32_Object_Type_String_String
		{
			get
			{
				if(r_RRegisterStringPersistentListener_Int32_Object_Type_String_String == null)
				{
					r_RRegisterStringPersistentListener_Int32_Object_Type_String_String = new(this, "RegisterStringPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Object), typeof(System.Type), typeof(System.String), typeof(System.String));
					r_RRegisterStringPersistentListener_Int32_Object_Type_String_String.SetBelong(this.instance);
				}
				return r_RRegisterStringPersistentListener_Int32_Object_Type_String_String;
			}
		}

		/// <summary>
		/// Void RegisterBoolPersistentListener(Int32, UnityEngine.Object, System.Type, Boolean, System.String)
		/// </summary>
		protected RMethod r_RRegisterBoolPersistentListener_Int32_Object_Type_Boolean_String;
		public virtual RMethod RRegisterBoolPersistentListener_Int32_Object_Type_Boolean_String
		{
			get
			{
				if(r_RRegisterBoolPersistentListener_Int32_Object_Type_Boolean_String == null)
				{
					r_RRegisterBoolPersistentListener_Int32_Object_Type_Boolean_String = new(this, "RegisterBoolPersistentListener", 0, typeof(System.Int32), typeof(UnityEngine.Object), typeof(System.Type), typeof(System.Boolean), typeof(System.String));
					r_RRegisterBoolPersistentListener_Int32_Object_Type_Boolean_String.SetBelong(this.instance);
				}
				return r_RRegisterBoolPersistentListener_Int32_Object_Type_Boolean_String;
			}
		}

		/// <summary>
		/// Void UnregisterPersistentListener(Int32)
		/// </summary>
		protected RMethod r_RUnregisterPersistentListener_Int32;
		public virtual RMethod RUnregisterPersistentListener_Int32
		{
			get
			{
				if(r_RUnregisterPersistentListener_Int32 == null)
				{
					r_RUnregisterPersistentListener_Int32 = new(this, "UnregisterPersistentListener", 0, typeof(System.Int32));
					r_RUnregisterPersistentListener_Int32.SetBelong(this.instance);
				}
				return r_RUnregisterPersistentListener_Int32;
			}
		}

		/// <summary>
		/// Void RemoveListeners(UnityEngine.Object, System.String)
		/// </summary>
		protected RMethod r_RRemoveListeners_Object_String;
		public virtual RMethod RRemoveListeners_Object_String
		{
			get
			{
				if(r_RRemoveListeners_Object_String == null)
				{
					r_RRemoveListeners_Object_String = new(this, "RemoveListeners", 0, typeof(UnityEngine.Object), typeof(System.String));
					r_RRemoveListeners_Object_String.SetBelong(this.instance);
				}
				return r_RRemoveListeners_Object_String;
			}
		}

		/// <summary>
		/// Void Initialize(UnityEngine.Events.InvokableCallList, UnityEngine.Events.UnityEventBase)
		/// </summary>
		protected RMethod r_RInitialize_InvokableCallList_UnityEventBase;
		public virtual RMethod RInitialize_InvokableCallList_UnityEventBase
		{
			get
			{
				if(r_RInitialize_InvokableCallList_UnityEventBase == null)
				{
					r_RInitialize_InvokableCallList_UnityEventBase = new(this, "Initialize", 0,  ReleactionUtils.GetType("UnityEngine.Events.InvokableCallList"), typeof(UnityEngine.Events.UnityEventBase));
					r_RInitialize_InvokableCallList_UnityEventBase.SetBelong(this.instance);
				}
				return r_RInitialize_InvokableCallList_UnityEventBase;
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

        public virtual System.Object GetListener(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetListener_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetListeners()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetListeners.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void AddListener()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAddListener.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void RemoveListener(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RRemoveListener_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterEventPersistentListener(System.Int32  @index, UnityEngine.Object  @targetObj, System.Type  @targetObjType, System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @targetObj, @targetObjType, @methodName};
            var ___result = RRegisterEventPersistentListener_Int32_Object_Type_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterVoidPersistentListener(System.Int32  @index, UnityEngine.Object  @targetObj, System.Type  @targetObjType, System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @targetObj, @targetObjType, @methodName};
            var ___result = RRegisterVoidPersistentListener_Int32_Object_Type_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterObjectPersistentListener(System.Int32  @index, UnityEngine.Object  @targetObj, System.Type  @targetObjType, UnityEngine.Object  @argument, System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @targetObj, @targetObjType, @argument, @methodName};
            var ___result = RRegisterObjectPersistentListener_Int32_Object_Type_Object_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterIntPersistentListener(System.Int32  @index, UnityEngine.Object  @targetObj, System.Type  @targetObjType, System.Int32  @argument, System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @targetObj, @targetObjType, @argument, @methodName};
            var ___result = RRegisterIntPersistentListener_Int32_Object_Type_Int32_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterFloatPersistentListener(System.Int32  @index, UnityEngine.Object  @targetObj, System.Type  @targetObjType, System.Single  @argument, System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @targetObj, @targetObjType, @argument, @methodName};
            var ___result = RRegisterFloatPersistentListener_Int32_Object_Type_Single_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterStringPersistentListener(System.Int32  @index, UnityEngine.Object  @targetObj, System.Type  @targetObjType, System.String  @argument, System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @targetObj, @targetObjType, @argument, @methodName};
            var ___result = RRegisterStringPersistentListener_Int32_Object_Type_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterBoolPersistentListener(System.Int32  @index, UnityEngine.Object  @targetObj, System.Type  @targetObjType, System.Boolean  @argument, System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @targetObj, @targetObjType, @argument, @methodName};
            var ___result = RRegisterBoolPersistentListener_Int32_Object_Type_Boolean_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterPersistentListener(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RUnregisterPersistentListener_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveListeners(UnityEngine.Object  @target, System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target, @methodName};
            var ___result = RRemoveListeners_Object_String.Invoke(___genericsType, ___parameters);

            
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
