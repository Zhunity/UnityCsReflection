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
		protected RMethod r_AddPersistentInvokableCall_BaseInvokableCall;
		public virtual RMethod RAddPersistentInvokableCall_BaseInvokableCall
		{
			get
			{
				if(r_AddPersistentInvokableCall_BaseInvokableCall == null)
				{
					r_AddPersistentInvokableCall_BaseInvokableCall = new(this, "AddPersistentInvokableCall", 0,  ReleactionUtils.GetType("UnityEngine.Events.BaseInvokableCall"));
					r_AddPersistentInvokableCall_BaseInvokableCall.SetBelong(this.instance);
				}
				return r_AddPersistentInvokableCall_BaseInvokableCall;
			}
		}

		/// <summary>
		/// Void AddListener(UnityEngine.Events.BaseInvokableCall)
		/// </summary>
		protected RMethod r_AddListener_BaseInvokableCall;
		public virtual RMethod RAddListener_BaseInvokableCall
		{
			get
			{
				if(r_AddListener_BaseInvokableCall == null)
				{
					r_AddListener_BaseInvokableCall = new(this, "AddListener", 0,  ReleactionUtils.GetType("UnityEngine.Events.BaseInvokableCall"));
					r_AddListener_BaseInvokableCall.SetBelong(this.instance);
				}
				return r_AddListener_BaseInvokableCall;
			}
		}

		/// <summary>
		/// Void RemoveListener(System.Object, System.Reflection.MethodInfo)
		/// </summary>
		protected RMethod r_RemoveListener_Object_MethodInfo;
		public virtual RMethod RRemoveListener_Object_MethodInfo
		{
			get
			{
				if(r_RemoveListener_Object_MethodInfo == null)
				{
					r_RemoveListener_Object_MethodInfo = new(this, "RemoveListener", 0, typeof(System.Object), typeof(System.Reflection.MethodInfo));
					r_RemoveListener_Object_MethodInfo.SetBelong(this.instance);
				}
				return r_RemoveListener_Object_MethodInfo;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_Clear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_Clear == null)
				{
					r_Clear = new(this, "Clear", 0);
					r_Clear.SetBelong(this.instance);
				}
				return r_Clear;
			}
		}

		/// <summary>
		/// Void ClearPersistent()
		/// </summary>
		protected RMethod r_ClearPersistent;
		public virtual RMethod RClearPersistent
		{
			get
			{
				if(r_ClearPersistent == null)
				{
					r_ClearPersistent = new(this, "ClearPersistent", 0);
					r_ClearPersistent.SetBelong(this.instance);
				}
				return r_ClearPersistent;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Events.BaseInvokableCall] PrepareInvoke()
		/// </summary>
		protected RMethod r_PrepareInvoke;
		public virtual RMethod RPrepareInvoke
		{
			get
			{
				if(r_PrepareInvoke == null)
				{
					r_PrepareInvoke = new(this, "PrepareInvoke", 0);
					r_PrepareInvoke.SetBelong(this.instance);
				}
				return r_PrepareInvoke;
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
