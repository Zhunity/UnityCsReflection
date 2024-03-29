
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.PointerDispatchState
	/// </summary>
    public partial class RPointerDispatchState : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.PointerDispatchState");
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


		/// <summary>
		/// UnityEngine.UIElements.IEventHandler[] m_PendingPointerCapture
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIEventHandler> r_Fm_PendingPointerCapture;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIEventHandler> RFm_PendingPointerCapture
		{
			get
			{
				if(r_Fm_PendingPointerCapture == null)
				{
					r_Fm_PendingPointerCapture = new(this, "m_PendingPointerCapture");
				}
				return r_Fm_PendingPointerCapture;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler[] m_PointerCapture
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIEventHandler> r_Fm_PointerCapture;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIEventHandler> RFm_PointerCapture
		{
			get
			{
				if(r_Fm_PointerCapture == null)
				{
					r_Fm_PointerCapture = new(this, "m_PointerCapture");
				}
				return r_Fm_PointerCapture;
			}
		}

		/// <summary>
		/// System.Boolean[] m_ShouldSendCompatibilityMouseEvents
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RBoolean> r_Fm_ShouldSendCompatibilityMouseEvents;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RBoolean> RFm_ShouldSendCompatibilityMouseEvents
		{
			get
			{
				if(r_Fm_ShouldSendCompatibilityMouseEvents == null)
				{
					r_Fm_ShouldSendCompatibilityMouseEvents = new(this, "m_ShouldSendCompatibilityMouseEvents");
				}
				return r_Fm_ShouldSendCompatibilityMouseEvents;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
				}
				return r_MReset;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler GetCapturingElement(Int32)
		/// </summary>
		protected RMethod r_MGetCapturingElement_Int32;
		public virtual RMethod RMGetCapturingElement_Int32
		{
			get
			{
				if(r_MGetCapturingElement_Int32 == null)
				{
					r_MGetCapturingElement_Int32 = new(this, "GetCapturingElement", 0, typeof(System.Int32));
				}
				return r_MGetCapturingElement_Int32;
			}
		}

		/// <summary>
		/// Boolean HasPointerCapture(UnityEngine.UIElements.IEventHandler, Int32)
		/// </summary>
		protected RMethod r_MHasPointerCapture_IEventHandler_Int32;
		public virtual RMethod RMHasPointerCapture_IEventHandler_Int32
		{
			get
			{
				if(r_MHasPointerCapture_IEventHandler_Int32 == null)
				{
					r_MHasPointerCapture_IEventHandler_Int32 = new(this, "HasPointerCapture", 0, typeof(UnityEngine.UIElements.IEventHandler), typeof(System.Int32));
				}
				return r_MHasPointerCapture_IEventHandler_Int32;
			}
		}

		/// <summary>
		/// Void CapturePointer(UnityEngine.UIElements.IEventHandler, Int32)
		/// </summary>
		protected RMethod r_MCapturePointer_IEventHandler_Int32;
		public virtual RMethod RMCapturePointer_IEventHandler_Int32
		{
			get
			{
				if(r_MCapturePointer_IEventHandler_Int32 == null)
				{
					r_MCapturePointer_IEventHandler_Int32 = new(this, "CapturePointer", 0, typeof(UnityEngine.UIElements.IEventHandler), typeof(System.Int32));
				}
				return r_MCapturePointer_IEventHandler_Int32;
			}
		}

		/// <summary>
		/// Void ReleasePointer(Int32)
		/// </summary>
		protected RMethod r_MReleasePointer_Int32;
		public virtual RMethod RMReleasePointer_Int32
		{
			get
			{
				if(r_MReleasePointer_Int32 == null)
				{
					r_MReleasePointer_Int32 = new(this, "ReleasePointer", 0, typeof(System.Int32));
				}
				return r_MReleasePointer_Int32;
			}
		}

		/// <summary>
		/// Void ReleasePointer(UnityEngine.UIElements.IEventHandler, Int32)
		/// </summary>
		protected RMethod r_MReleasePointer_IEventHandler_Int32;
		public virtual RMethod RMReleasePointer_IEventHandler_Int32
		{
			get
			{
				if(r_MReleasePointer_IEventHandler_Int32 == null)
				{
					r_MReleasePointer_IEventHandler_Int32 = new(this, "ReleasePointer", 0, typeof(UnityEngine.UIElements.IEventHandler), typeof(System.Int32));
				}
				return r_MReleasePointer_IEventHandler_Int32;
			}
		}

		/// <summary>
		/// Void ProcessPointerCapture(Int32)
		/// </summary>
		protected RMethod r_MProcessPointerCapture_Int32;
		public virtual RMethod RMProcessPointerCapture_Int32
		{
			get
			{
				if(r_MProcessPointerCapture_Int32 == null)
				{
					r_MProcessPointerCapture_Int32 = new(this, "ProcessPointerCapture", 0, typeof(System.Int32));
				}
				return r_MProcessPointerCapture_Int32;
			}
		}

		/// <summary>
		/// Void ActivateCompatibilityMouseEvents(Int32)
		/// </summary>
		protected RMethod r_MActivateCompatibilityMouseEvents_Int32;
		public virtual RMethod RMActivateCompatibilityMouseEvents_Int32
		{
			get
			{
				if(r_MActivateCompatibilityMouseEvents_Int32 == null)
				{
					r_MActivateCompatibilityMouseEvents_Int32 = new(this, "ActivateCompatibilityMouseEvents", 0, typeof(System.Int32));
				}
				return r_MActivateCompatibilityMouseEvents_Int32;
			}
		}

		/// <summary>
		/// Void PreventCompatibilityMouseEvents(Int32)
		/// </summary>
		protected RMethod r_MPreventCompatibilityMouseEvents_Int32;
		public virtual RMethod RMPreventCompatibilityMouseEvents_Int32
		{
			get
			{
				if(r_MPreventCompatibilityMouseEvents_Int32 == null)
				{
					r_MPreventCompatibilityMouseEvents_Int32 = new(this, "PreventCompatibilityMouseEvents", 0, typeof(System.Int32));
				}
				return r_MPreventCompatibilityMouseEvents_Int32;
			}
		}

		/// <summary>
		/// Boolean ShouldSendCompatibilityMouseEvents(UnityEngine.UIElements.IPointerEvent)
		/// </summary>
		protected RMethod r_MShouldSendCompatibilityMouseEvents_IPointerEvent;
		public virtual RMethod RMShouldSendCompatibilityMouseEvents_IPointerEvent
		{
			get
			{
				if(r_MShouldSendCompatibilityMouseEvents_IPointerEvent == null)
				{
					r_MShouldSendCompatibilityMouseEvents_IPointerEvent = new(this, "ShouldSendCompatibilityMouseEvents", 0, typeof(UnityEngine.UIElements.IPointerEvent));
				}
				return r_MShouldSendCompatibilityMouseEvents_IPointerEvent;
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


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.IEventHandler GetCapturingElement(System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RMGetCapturingElement_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.IEventHandler>(___result);
        }


        public virtual System.Boolean HasPointerCapture(UnityEngine.UIElements.IEventHandler @handler, System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handler, @pointerId};
            var ___result = RMHasPointerCapture_IEventHandler_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void CapturePointer(UnityEngine.UIElements.IEventHandler @handler, System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handler, @pointerId};
            var ___result = RMCapturePointer_IEventHandler_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReleasePointer(System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RMReleasePointer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReleasePointer(UnityEngine.UIElements.IEventHandler @handler, System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handler, @pointerId};
            var ___result = RMReleasePointer_IEventHandler_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessPointerCapture(System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RMProcessPointerCapture_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ActivateCompatibilityMouseEvents(System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RMActivateCompatibilityMouseEvents_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PreventCompatibilityMouseEvents(System.Int32 @pointerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId};
            var ___result = RMPreventCompatibilityMouseEvents_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ShouldSendCompatibilityMouseEvents(UnityEngine.UIElements.IPointerEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMShouldSendCompatibilityMouseEvents_IPointerEvent.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
