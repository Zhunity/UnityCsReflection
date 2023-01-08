using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.PointerDispatchState
	/// </summary>
    public partial class RPointerDispatchState : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler[] m_PendingPointerCapture
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RIEventHandler> r_m_PendingPointerCapture;
		public virtual RFieldArray<RUnityEngine.RUIElements.RIEventHandler> Rm_PendingPointerCapture
		{
			get
			{
				if(r_m_PendingPointerCapture == null)
				{
					r_m_PendingPointerCapture = new(this, "m_PendingPointerCapture");
					r_m_PendingPointerCapture.SetBelong(this.instance);
				}
				return r_m_PendingPointerCapture;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler[] m_PointerCapture
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RIEventHandler> r_m_PointerCapture;
		public virtual RFieldArray<RUnityEngine.RUIElements.RIEventHandler> Rm_PointerCapture
		{
			get
			{
				if(r_m_PointerCapture == null)
				{
					r_m_PointerCapture = new(this, "m_PointerCapture");
					r_m_PointerCapture.SetBelong(this.instance);
				}
				return r_m_PointerCapture;
			}
		}

		/// <summary>
		/// System.Boolean[] m_ShouldSendCompatibilityMouseEvents
		/// </summary>
		protected RFieldArray<RField> r_m_ShouldSendCompatibilityMouseEvents;
		public virtual RFieldArray<RField> Rm_ShouldSendCompatibilityMouseEvents
		{
			get
			{
				if(r_m_ShouldSendCompatibilityMouseEvents == null)
				{
					r_m_ShouldSendCompatibilityMouseEvents = new(this, "m_ShouldSendCompatibilityMouseEvents");
					r_m_ShouldSendCompatibilityMouseEvents.SetBelong(this.instance);
				}
				return r_m_ShouldSendCompatibilityMouseEvents;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_Reset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_Reset == null)
				{
					r_Reset = new(this, "Reset", 0);
					r_Reset.SetBelong(this.instance);
				}
				return r_Reset;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler GetCapturingElement(Int32)
		/// </summary>
		protected RMethod r_GetCapturingElement_Int32;
		public virtual RMethod RGetCapturingElement_Int32
		{
			get
			{
				if(r_GetCapturingElement_Int32 == null)
				{
					r_GetCapturingElement_Int32 = new(this, "GetCapturingElement", 0, typeof(System.Int32));
					r_GetCapturingElement_Int32.SetBelong(this.instance);
				}
				return r_GetCapturingElement_Int32;
			}
		}

		/// <summary>
		/// Boolean HasPointerCapture(UnityEngine.UIElements.IEventHandler, Int32)
		/// </summary>
		protected RMethod r_HasPointerCapture_IEventHandler_Int32;
		public virtual RMethod RHasPointerCapture_IEventHandler_Int32
		{
			get
			{
				if(r_HasPointerCapture_IEventHandler_Int32 == null)
				{
					r_HasPointerCapture_IEventHandler_Int32 = new(this, "HasPointerCapture", 0, typeof(UnityEngine.UIElements.IEventHandler), typeof(System.Int32));
					r_HasPointerCapture_IEventHandler_Int32.SetBelong(this.instance);
				}
				return r_HasPointerCapture_IEventHandler_Int32;
			}
		}

		/// <summary>
		/// Void CapturePointer(UnityEngine.UIElements.IEventHandler, Int32)
		/// </summary>
		protected RMethod r_CapturePointer_IEventHandler_Int32;
		public virtual RMethod RCapturePointer_IEventHandler_Int32
		{
			get
			{
				if(r_CapturePointer_IEventHandler_Int32 == null)
				{
					r_CapturePointer_IEventHandler_Int32 = new(this, "CapturePointer", 0, typeof(UnityEngine.UIElements.IEventHandler), typeof(System.Int32));
					r_CapturePointer_IEventHandler_Int32.SetBelong(this.instance);
				}
				return r_CapturePointer_IEventHandler_Int32;
			}
		}

		/// <summary>
		/// Void ReleasePointer(Int32)
		/// </summary>
		protected RMethod r_ReleasePointer_Int32;
		public virtual RMethod RReleasePointer_Int32
		{
			get
			{
				if(r_ReleasePointer_Int32 == null)
				{
					r_ReleasePointer_Int32 = new(this, "ReleasePointer", 0, typeof(System.Int32));
					r_ReleasePointer_Int32.SetBelong(this.instance);
				}
				return r_ReleasePointer_Int32;
			}
		}

		/// <summary>
		/// Void ReleasePointer(UnityEngine.UIElements.IEventHandler, Int32)
		/// </summary>
		protected RMethod r_ReleasePointer_IEventHandler_Int32;
		public virtual RMethod RReleasePointer_IEventHandler_Int32
		{
			get
			{
				if(r_ReleasePointer_IEventHandler_Int32 == null)
				{
					r_ReleasePointer_IEventHandler_Int32 = new(this, "ReleasePointer", 0, typeof(UnityEngine.UIElements.IEventHandler), typeof(System.Int32));
					r_ReleasePointer_IEventHandler_Int32.SetBelong(this.instance);
				}
				return r_ReleasePointer_IEventHandler_Int32;
			}
		}

		/// <summary>
		/// Void ProcessPointerCapture(Int32)
		/// </summary>
		protected RMethod r_ProcessPointerCapture_Int32;
		public virtual RMethod RProcessPointerCapture_Int32
		{
			get
			{
				if(r_ProcessPointerCapture_Int32 == null)
				{
					r_ProcessPointerCapture_Int32 = new(this, "ProcessPointerCapture", 0, typeof(System.Int32));
					r_ProcessPointerCapture_Int32.SetBelong(this.instance);
				}
				return r_ProcessPointerCapture_Int32;
			}
		}

		/// <summary>
		/// Void ActivateCompatibilityMouseEvents(Int32)
		/// </summary>
		protected RMethod r_ActivateCompatibilityMouseEvents_Int32;
		public virtual RMethod RActivateCompatibilityMouseEvents_Int32
		{
			get
			{
				if(r_ActivateCompatibilityMouseEvents_Int32 == null)
				{
					r_ActivateCompatibilityMouseEvents_Int32 = new(this, "ActivateCompatibilityMouseEvents", 0, typeof(System.Int32));
					r_ActivateCompatibilityMouseEvents_Int32.SetBelong(this.instance);
				}
				return r_ActivateCompatibilityMouseEvents_Int32;
			}
		}

		/// <summary>
		/// Void PreventCompatibilityMouseEvents(Int32)
		/// </summary>
		protected RMethod r_PreventCompatibilityMouseEvents_Int32;
		public virtual RMethod RPreventCompatibilityMouseEvents_Int32
		{
			get
			{
				if(r_PreventCompatibilityMouseEvents_Int32 == null)
				{
					r_PreventCompatibilityMouseEvents_Int32 = new(this, "PreventCompatibilityMouseEvents", 0, typeof(System.Int32));
					r_PreventCompatibilityMouseEvents_Int32.SetBelong(this.instance);
				}
				return r_PreventCompatibilityMouseEvents_Int32;
			}
		}

		/// <summary>
		/// Boolean ShouldSendCompatibilityMouseEvents(UnityEngine.UIElements.IPointerEvent)
		/// </summary>
		protected RMethod r_ShouldSendCompatibilityMouseEvents_IPointerEvent;
		public virtual RMethod RShouldSendCompatibilityMouseEvents_IPointerEvent
		{
			get
			{
				if(r_ShouldSendCompatibilityMouseEvents_IPointerEvent == null)
				{
					r_ShouldSendCompatibilityMouseEvents_IPointerEvent = new(this, "ShouldSendCompatibilityMouseEvents", 0, typeof(UnityEngine.UIElements.IPointerEvent));
					r_ShouldSendCompatibilityMouseEvents_IPointerEvent.SetBelong(this.instance);
				}
				return r_ShouldSendCompatibilityMouseEvents_IPointerEvent;
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


        public RPointerDispatchState() : base("UnityEngine.UIElements.PointerDispatchState")
        {
        }

        public RPointerDispatchState(System.Object instance) : base("UnityEngine.UIElements.PointerDispatchState")
		{
            SetInstance(instance);
		}

        public RPointerDispatchState(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPointerDispatchState(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.IEventHandler GetCapturingElement(System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RGetCapturingElement_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.IEventHandler)___result;
        }


        public virtual System.Boolean HasPointerCapture(UnityEngine.UIElements.IEventHandler @handler, System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handler, @pointerId};
            var ___result = RHasPointerCapture_IEventHandler_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CapturePointer(UnityEngine.UIElements.IEventHandler @handler, System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handler, @pointerId};
            var ___result = RCapturePointer_IEventHandler_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReleasePointer(System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RReleasePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReleasePointer(UnityEngine.UIElements.IEventHandler @handler, System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handler, @pointerId};
            var ___result = RReleasePointer_IEventHandler_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessPointerCapture(System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RProcessPointerCapture_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ActivateCompatibilityMouseEvents(System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RActivateCompatibilityMouseEvents_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PreventCompatibilityMouseEvents(System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RPreventCompatibilityMouseEvents_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ShouldSendCompatibilityMouseEvents(UnityEngine.UIElements.IPointerEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RShouldSendCompatibilityMouseEvents_IPointerEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
