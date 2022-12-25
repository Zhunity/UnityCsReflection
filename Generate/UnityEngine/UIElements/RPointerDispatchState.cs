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
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler GetCapturingElement(Int32)
		/// </summary>
		protected RMethod r_RGetCapturingElement_Int32;
		public virtual RMethod RGetCapturingElement_Int32
		{
			get
			{
				if(r_RGetCapturingElement_Int32 == null)
				{
					r_RGetCapturingElement_Int32 = new(this, "GetCapturingElement", 0, typeof(System.Int32));
					r_RGetCapturingElement_Int32.SetBelong(this.instance);
				}
				return r_RGetCapturingElement_Int32;
			}
		}

		/// <summary>
		/// Boolean HasPointerCapture(UnityEngine.UIElements.IEventHandler, Int32)
		/// </summary>
		protected RMethod r_RHasPointerCapture_IEventHandler_Int32;
		public virtual RMethod RHasPointerCapture_IEventHandler_Int32
		{
			get
			{
				if(r_RHasPointerCapture_IEventHandler_Int32 == null)
				{
					r_RHasPointerCapture_IEventHandler_Int32 = new(this, "HasPointerCapture", 0, typeof(UnityEngine.UIElements.IEventHandler), typeof(System.Int32));
					r_RHasPointerCapture_IEventHandler_Int32.SetBelong(this.instance);
				}
				return r_RHasPointerCapture_IEventHandler_Int32;
			}
		}

		/// <summary>
		/// Void CapturePointer(UnityEngine.UIElements.IEventHandler, Int32)
		/// </summary>
		protected RMethod r_RCapturePointer_IEventHandler_Int32;
		public virtual RMethod RCapturePointer_IEventHandler_Int32
		{
			get
			{
				if(r_RCapturePointer_IEventHandler_Int32 == null)
				{
					r_RCapturePointer_IEventHandler_Int32 = new(this, "CapturePointer", 0, typeof(UnityEngine.UIElements.IEventHandler), typeof(System.Int32));
					r_RCapturePointer_IEventHandler_Int32.SetBelong(this.instance);
				}
				return r_RCapturePointer_IEventHandler_Int32;
			}
		}

		/// <summary>
		/// Void ReleasePointer(Int32)
		/// </summary>
		protected RMethod r_RReleasePointer_Int32;
		public virtual RMethod RReleasePointer_Int32
		{
			get
			{
				if(r_RReleasePointer_Int32 == null)
				{
					r_RReleasePointer_Int32 = new(this, "ReleasePointer", 0, typeof(System.Int32));
					r_RReleasePointer_Int32.SetBelong(this.instance);
				}
				return r_RReleasePointer_Int32;
			}
		}

		/// <summary>
		/// Void ReleasePointer(UnityEngine.UIElements.IEventHandler, Int32)
		/// </summary>
		protected RMethod r_RReleasePointer_IEventHandler_Int32;
		public virtual RMethod RReleasePointer_IEventHandler_Int32
		{
			get
			{
				if(r_RReleasePointer_IEventHandler_Int32 == null)
				{
					r_RReleasePointer_IEventHandler_Int32 = new(this, "ReleasePointer", 0, typeof(UnityEngine.UIElements.IEventHandler), typeof(System.Int32));
					r_RReleasePointer_IEventHandler_Int32.SetBelong(this.instance);
				}
				return r_RReleasePointer_IEventHandler_Int32;
			}
		}

		/// <summary>
		/// Void ProcessPointerCapture(Int32)
		/// </summary>
		protected RMethod r_RProcessPointerCapture_Int32;
		public virtual RMethod RProcessPointerCapture_Int32
		{
			get
			{
				if(r_RProcessPointerCapture_Int32 == null)
				{
					r_RProcessPointerCapture_Int32 = new(this, "ProcessPointerCapture", 0, typeof(System.Int32));
					r_RProcessPointerCapture_Int32.SetBelong(this.instance);
				}
				return r_RProcessPointerCapture_Int32;
			}
		}

		/// <summary>
		/// Void ActivateCompatibilityMouseEvents(Int32)
		/// </summary>
		protected RMethod r_RActivateCompatibilityMouseEvents_Int32;
		public virtual RMethod RActivateCompatibilityMouseEvents_Int32
		{
			get
			{
				if(r_RActivateCompatibilityMouseEvents_Int32 == null)
				{
					r_RActivateCompatibilityMouseEvents_Int32 = new(this, "ActivateCompatibilityMouseEvents", 0, typeof(System.Int32));
					r_RActivateCompatibilityMouseEvents_Int32.SetBelong(this.instance);
				}
				return r_RActivateCompatibilityMouseEvents_Int32;
			}
		}

		/// <summary>
		/// Void PreventCompatibilityMouseEvents(Int32)
		/// </summary>
		protected RMethod r_RPreventCompatibilityMouseEvents_Int32;
		public virtual RMethod RPreventCompatibilityMouseEvents_Int32
		{
			get
			{
				if(r_RPreventCompatibilityMouseEvents_Int32 == null)
				{
					r_RPreventCompatibilityMouseEvents_Int32 = new(this, "PreventCompatibilityMouseEvents", 0, typeof(System.Int32));
					r_RPreventCompatibilityMouseEvents_Int32.SetBelong(this.instance);
				}
				return r_RPreventCompatibilityMouseEvents_Int32;
			}
		}

		/// <summary>
		/// Boolean ShouldSendCompatibilityMouseEvents(UnityEngine.UIElements.IPointerEvent)
		/// </summary>
		protected RMethod r_RShouldSendCompatibilityMouseEvents_IPointerEvent;
		public virtual RMethod RShouldSendCompatibilityMouseEvents_IPointerEvent
		{
			get
			{
				if(r_RShouldSendCompatibilityMouseEvents_IPointerEvent == null)
				{
					r_RShouldSendCompatibilityMouseEvents_IPointerEvent = new(this, "ShouldSendCompatibilityMouseEvents", 0, typeof(UnityEngine.UIElements.IPointerEvent));
					r_RShouldSendCompatibilityMouseEvents_IPointerEvent.SetBelong(this.instance);
				}
				return r_RShouldSendCompatibilityMouseEvents_IPointerEvent;
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


        public virtual UnityEngine.UIElements.IEventHandler GetCapturingElement(System.Int32  @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RGetCapturingElement_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.IEventHandler)___result;
        }


        public virtual System.Boolean HasPointerCapture(UnityEngine.UIElements.IEventHandler  @handler, System.Int32  @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handler, @pointerId};
            var ___result = RHasPointerCapture_IEventHandler_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CapturePointer(UnityEngine.UIElements.IEventHandler  @handler, System.Int32  @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handler, @pointerId};
            var ___result = RCapturePointer_IEventHandler_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReleasePointer(System.Int32  @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RReleasePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReleasePointer(UnityEngine.UIElements.IEventHandler  @handler, System.Int32  @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handler, @pointerId};
            var ___result = RReleasePointer_IEventHandler_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessPointerCapture(System.Int32  @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RProcessPointerCapture_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ActivateCompatibilityMouseEvents(System.Int32  @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RActivateCompatibilityMouseEvents_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PreventCompatibilityMouseEvents(System.Int32  @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RPreventCompatibilityMouseEvents_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ShouldSendCompatibilityMouseEvents(UnityEngine.UIElements.IPointerEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RShouldSendCompatibilityMouseEvents_IPointerEvent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
