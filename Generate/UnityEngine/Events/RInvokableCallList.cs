using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.REvents
{
	/// <summary>
	/// UnityEngine.Events.InvokableCallList
	/// </summary>
    public partial class RInvokableCallList : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Events.BaseInvokableCall] m_PersistentCalls
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.REvents.RBaseInvokableCall> r_m_PersistentCalls;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.REvents.RBaseInvokableCall> Rm_PersistentCalls
		{
			get
			{
				if(r_m_PersistentCalls == null)
				{
					r_m_PersistentCalls = new(this, "m_PersistentCalls");
					r_m_PersistentCalls.SetBelong(this.instance);
				}
				return r_m_PersistentCalls;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Events.BaseInvokableCall] m_RuntimeCalls
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.REvents.RBaseInvokableCall> r_m_RuntimeCalls;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.REvents.RBaseInvokableCall> Rm_RuntimeCalls
		{
			get
			{
				if(r_m_RuntimeCalls == null)
				{
					r_m_RuntimeCalls = new(this, "m_RuntimeCalls");
					r_m_RuntimeCalls.SetBelong(this.instance);
				}
				return r_m_RuntimeCalls;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Events.BaseInvokableCall] m_ExecutingCalls
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.REvents.RBaseInvokableCall> r_m_ExecutingCalls;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.REvents.RBaseInvokableCall> Rm_ExecutingCalls
		{
			get
			{
				if(r_m_ExecutingCalls == null)
				{
					r_m_ExecutingCalls = new(this, "m_ExecutingCalls");
					r_m_ExecutingCalls.SetBelong(this.instance);
				}
				return r_m_ExecutingCalls;
			}
		}

		/// <summary>
		/// System.Boolean m_NeedsUpdate
		/// </summary>
		protected RField r_m_NeedsUpdate;
		public virtual RField Rm_NeedsUpdate
		{
			get
			{
				if(r_m_NeedsUpdate == null)
				{
					r_m_NeedsUpdate = new(this, "m_NeedsUpdate");
					r_m_NeedsUpdate.SetBelong(this.instance);
				}
				return r_m_NeedsUpdate;
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
		/// Void AddPersistentInvokableCall(UnityEngine.Events.BaseInvokableCall)
		/// </summary>
		protected RMethod r_RAddPersistentInvokableCall_BaseInvokableCall;
		public virtual RMethod RAddPersistentInvokableCall_BaseInvokableCall
		{
			get
			{
				if(r_RAddPersistentInvokableCall_BaseInvokableCall == null)
				{
					r_RAddPersistentInvokableCall_BaseInvokableCall = new(this, "AddPersistentInvokableCall", 0,  ReleactionUtils.GetType("UnityEngine.Events.BaseInvokableCall"));
					r_RAddPersistentInvokableCall_BaseInvokableCall.SetBelong(this.instance);
				}
				return r_RAddPersistentInvokableCall_BaseInvokableCall;
			}
		}

		/// <summary>
		/// Void AddListener(UnityEngine.Events.BaseInvokableCall)
		/// </summary>
		protected RMethod r_RAddListener_BaseInvokableCall;
		public virtual RMethod RAddListener_BaseInvokableCall
		{
			get
			{
				if(r_RAddListener_BaseInvokableCall == null)
				{
					r_RAddListener_BaseInvokableCall = new(this, "AddListener", 0,  ReleactionUtils.GetType("UnityEngine.Events.BaseInvokableCall"));
					r_RAddListener_BaseInvokableCall.SetBelong(this.instance);
				}
				return r_RAddListener_BaseInvokableCall;
			}
		}

		/// <summary>
		/// Void RemoveListener(System.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_RRemoveListener_Object_MethodInfo;
		public virtual RMethod RRemoveListener_Object_MethodInfo
		{
			get
			{
				if(r_RRemoveListener_Object_MethodInfo == null)
				{
					r_RRemoveListener_Object_MethodInfo = new(this, "RemoveListener", 0, typeof(System.Object), typeof(System.Reflection.MethodInfo));
					r_RRemoveListener_Object_MethodInfo.SetBelong(this.instance);
				}
				return r_RRemoveListener_Object_MethodInfo;
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
		/// Void ClearPersistent()
		/// </summary>
		protected RMethod r_RClearPersistent;
		public virtual RMethod RClearPersistent
		{
			get
			{
				if(r_RClearPersistent == null)
				{
					r_RClearPersistent = new(this, "ClearPersistent", 0);
					r_RClearPersistent.SetBelong(this.instance);
				}
				return r_RClearPersistent;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Events.BaseInvokableCall] PrepareInvoke()
		/// </summary>
		protected RMethod r_RPrepareInvoke;
		public virtual RMethod RPrepareInvoke
		{
			get
			{
				if(r_RPrepareInvoke == null)
				{
					r_RPrepareInvoke = new(this, "PrepareInvoke", 0);
					r_RPrepareInvoke.SetBelong(this.instance);
				}
				return r_RPrepareInvoke;
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



        public virtual void RemoveListener(System.Object  @targetObj, System.Reflection.MethodInfo  @method)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObj, @method};
            var ___result = RRemoveListener_Object_MethodInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearPersistent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearPersistent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object PrepareInvoke()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPrepareInvoke.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
