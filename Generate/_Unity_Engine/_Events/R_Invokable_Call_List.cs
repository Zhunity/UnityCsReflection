
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.REvents
{
	/// <summary>
	/// UnityEngine.Events.InvokableCallList
	/// </summary>
    public partial class RInvokableCallList : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Events.BaseInvokableCall] m_PersistentCalls
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.REvents.RBaseInvokableCall> r_Fm_PersistentCalls;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.REvents.RBaseInvokableCall> RFm_PersistentCalls
		{
			get
			{
				if(r_Fm_PersistentCalls == null)
				{
					r_Fm_PersistentCalls = new(this, "m_PersistentCalls");
				}
				return r_Fm_PersistentCalls;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Events.BaseInvokableCall] m_RuntimeCalls
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.REvents.RBaseInvokableCall> r_Fm_RuntimeCalls;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.REvents.RBaseInvokableCall> RFm_RuntimeCalls
		{
			get
			{
				if(r_Fm_RuntimeCalls == null)
				{
					r_Fm_RuntimeCalls = new(this, "m_RuntimeCalls");
				}
				return r_Fm_RuntimeCalls;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Events.BaseInvokableCall] m_ExecutingCalls
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.REvents.RBaseInvokableCall> r_Fm_ExecutingCalls;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.REvents.RBaseInvokableCall> RFm_ExecutingCalls
		{
			get
			{
				if(r_Fm_ExecutingCalls == null)
				{
					r_Fm_ExecutingCalls = new(this, "m_ExecutingCalls");
				}
				return r_Fm_ExecutingCalls;
			}
		}

		/// <summary>
		/// System.Boolean m_NeedsUpdate
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_NeedsUpdate;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_NeedsUpdate
		{
			get
			{
				if(r_Fm_NeedsUpdate == null)
				{
					r_Fm_NeedsUpdate = new(this, "m_NeedsUpdate");
				}
				return r_Fm_NeedsUpdate;
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
		/// Void AddPersistentInvokableCall(UnityEngine.Events.BaseInvokableCall)
		/// </summary>
		protected RMethod r_MAddPersistentInvokableCall_BaseInvokableCall;
		public virtual RMethod RMAddPersistentInvokableCall_BaseInvokableCall
		{
			get
			{
				if(r_MAddPersistentInvokableCall_BaseInvokableCall == null)
				{
					r_MAddPersistentInvokableCall_BaseInvokableCall = new(this, "AddPersistentInvokableCall", 0,  ReflectionUtils.GetType("UnityEngine.Events.BaseInvokableCall"));
				}
				return r_MAddPersistentInvokableCall_BaseInvokableCall;
			}
		}

		/// <summary>
		/// Void AddListener(UnityEngine.Events.BaseInvokableCall)
		/// </summary>
		protected RMethod r_MAddListener_BaseInvokableCall;
		public virtual RMethod RMAddListener_BaseInvokableCall
		{
			get
			{
				if(r_MAddListener_BaseInvokableCall == null)
				{
					r_MAddListener_BaseInvokableCall = new(this, "AddListener", 0,  ReflectionUtils.GetType("UnityEngine.Events.BaseInvokableCall"));
				}
				return r_MAddListener_BaseInvokableCall;
			}
		}

		/// <summary>
		/// Void RemoveListener(System.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_MRemoveListener_Object_MethodInfo;
		public virtual RMethod RMRemoveListener_Object_MethodInfo
		{
			get
			{
				if(r_MRemoveListener_Object_MethodInfo == null)
				{
					r_MRemoveListener_Object_MethodInfo = new(this, "RemoveListener", 0, typeof(System.Object), typeof(System.Reflection.MethodInfo));
				}
				return r_MRemoveListener_Object_MethodInfo;
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
		/// Void ClearPersistent()
		/// </summary>
		protected RMethod r_MClearPersistent;
		public virtual RMethod RMClearPersistent
		{
			get
			{
				if(r_MClearPersistent == null)
				{
					r_MClearPersistent = new(this, "ClearPersistent", 0);
				}
				return r_MClearPersistent;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Events.BaseInvokableCall] PrepareInvoke()
		/// </summary>
		protected RMethod r_MPrepareInvoke;
		public virtual RMethod RMPrepareInvoke
		{
			get
			{
				if(r_MPrepareInvoke == null)
				{
					r_MPrepareInvoke = new(this, "PrepareInvoke", 0);
				}
				return r_MPrepareInvoke;
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


        public RInvokableCallList() : base("UnityEngine.Events.InvokableCallList")
        {
        }

        public RInvokableCallList(System.Object instance) : base("UnityEngine.Events.InvokableCallList")
		{
            SetInstance(instance);
		}

        public RInvokableCallList(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RInvokableCallList(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AddPersistentInvokableCall(Hvak.Editor.Refleaction.RUnityEngine.REvents.RBaseInvokableCall @call)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call.Value};
            var ___result = RMAddPersistentInvokableCall_BaseInvokableCall.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddListener(Hvak.Editor.Refleaction.RUnityEngine.REvents.RBaseInvokableCall @call)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@call.Value};
            var ___result = RMAddListener_BaseInvokableCall.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveListener(System.Object @targetObj, System.Reflection.MethodInfo @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObj, @method};
            var ___result = RMRemoveListener_Object_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearPersistent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearPersistent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.REvents.RBaseInvokableCall> PrepareInvoke()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPrepareInvoke.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.REvents.RBaseInvokableCall>(___result);
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
