using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.EventDebuggerCallTrace
	/// </summary>
    public partial class REventDebuggerCallTrace : RMember //
    {

		/// <summary>
		/// System.Int32 <callbackHashCode>k__BackingField
		/// </summary>
		protected RField r___1__callbackHashCode__2__k__BackingField;
		public virtual RField R__1__callbackHashCode__2__k__BackingField
		{
			get
			{
				if(r___1__callbackHashCode__2__k__BackingField == null)
				{
					r___1__callbackHashCode__2__k__BackingField = new(this, "<callbackHashCode>k__BackingField");
					r___1__callbackHashCode__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__callbackHashCode__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.String <callbackName>k__BackingField
		/// </summary>
		protected RField r___1__callbackName__2__k__BackingField;
		public virtual RField R__1__callbackName__2__k__BackingField
		{
			get
			{
				if(r___1__callbackName__2__k__BackingField == null)
				{
					r___1__callbackName__2__k__BackingField = new(this, "<callbackName>k__BackingField");
					r___1__callbackName__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__callbackName__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <propagationHasStopped>k__BackingField
		/// </summary>
		protected RField r___1__propagationHasStopped__2__k__BackingField;
		public virtual RField R__1__propagationHasStopped__2__k__BackingField
		{
			get
			{
				if(r___1__propagationHasStopped__2__k__BackingField == null)
				{
					r___1__propagationHasStopped__2__k__BackingField = new(this, "<propagationHasStopped>k__BackingField");
					r___1__propagationHasStopped__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__propagationHasStopped__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <immediatePropagationHasStopped>k__BackingField
		/// </summary>
		protected RField r___1__immediatePropagationHasStopped__2__k__BackingField;
		public virtual RField R__1__immediatePropagationHasStopped__2__k__BackingField
		{
			get
			{
				if(r___1__immediatePropagationHasStopped__2__k__BackingField == null)
				{
					r___1__immediatePropagationHasStopped__2__k__BackingField = new(this, "<immediatePropagationHasStopped>k__BackingField");
					r___1__immediatePropagationHasStopped__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__immediatePropagationHasStopped__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <defaultHasBeenPrevented>k__BackingField
		/// </summary>
		protected RField r___1__defaultHasBeenPrevented__2__k__BackingField;
		public virtual RField R__1__defaultHasBeenPrevented__2__k__BackingField
		{
			get
			{
				if(r___1__defaultHasBeenPrevented__2__k__BackingField == null)
				{
					r___1__defaultHasBeenPrevented__2__k__BackingField = new(this, "<defaultHasBeenPrevented>k__BackingField");
					r___1__defaultHasBeenPrevented__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__defaultHasBeenPrevented__2__k__BackingField;
			}
		}

		/// <summary>
		/// Int32 callbackHashCode
		/// </summary>
		protected RProperty r_callbackHashCode;
		public virtual RProperty RcallbackHashCode
		{
			get
			{
				if(r_callbackHashCode == null)
				{
					r_callbackHashCode = new(this, "callbackHashCode", -1);
					r_callbackHashCode.SetBelong(this.instance);
				}
				return r_callbackHashCode;
			}
		}

		/// <summary>
		/// System.String callbackName
		/// </summary>
		protected RProperty r_callbackName;
		public virtual RProperty RcallbackName
		{
			get
			{
				if(r_callbackName == null)
				{
					r_callbackName = new(this, "callbackName", -1);
					r_callbackName.SetBelong(this.instance);
				}
				return r_callbackName;
			}
		}

		/// <summary>
		/// Boolean propagationHasStopped
		/// </summary>
		protected RProperty r_propagationHasStopped;
		public virtual RProperty RpropagationHasStopped
		{
			get
			{
				if(r_propagationHasStopped == null)
				{
					r_propagationHasStopped = new(this, "propagationHasStopped", -1);
					r_propagationHasStopped.SetBelong(this.instance);
				}
				return r_propagationHasStopped;
			}
		}

		/// <summary>
		/// Boolean immediatePropagationHasStopped
		/// </summary>
		protected RProperty r_immediatePropagationHasStopped;
		public virtual RProperty RimmediatePropagationHasStopped
		{
			get
			{
				if(r_immediatePropagationHasStopped == null)
				{
					r_immediatePropagationHasStopped = new(this, "immediatePropagationHasStopped", -1);
					r_immediatePropagationHasStopped.SetBelong(this.instance);
				}
				return r_immediatePropagationHasStopped;
			}
		}

		/// <summary>
		/// Boolean defaultHasBeenPrevented
		/// </summary>
		protected RProperty r_defaultHasBeenPrevented;
		public virtual RProperty RdefaultHasBeenPrevented
		{
			get
			{
				if(r_defaultHasBeenPrevented == null)
				{
					r_defaultHasBeenPrevented = new(this, "defaultHasBeenPrevented", -1);
					r_defaultHasBeenPrevented.SetBelong(this.instance);
				}
				return r_defaultHasBeenPrevented;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventDebuggerEventRecord eventBase
		/// </summary>
		protected RUnityEngine.RUIElements.REventDebuggerEventRecord r_eventBase;
		public virtual RUnityEngine.RUIElements.REventDebuggerEventRecord ReventBase
		{
			get
			{
				if(r_eventBase == null)
				{
					r_eventBase = new(this, "eventBase", -1);
					r_eventBase.SetBelong(this.instance);
				}
				return r_eventBase;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler focusedElement
		/// </summary>
		protected RUnityEngine.RUIElements.RIEventHandler r_focusedElement;
		public virtual RUnityEngine.RUIElements.RIEventHandler RfocusedElement
		{
			get
			{
				if(r_focusedElement == null)
				{
					r_focusedElement = new(this, "focusedElement", -1);
					r_focusedElement.SetBelong(this.instance);
				}
				return r_focusedElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler mouseCapture
		/// </summary>
		protected RUnityEngine.RUIElements.RIEventHandler r_mouseCapture;
		public virtual RUnityEngine.RUIElements.RIEventHandler RmouseCapture
		{
			get
			{
				if(r_mouseCapture == null)
				{
					r_mouseCapture = new(this, "mouseCapture", -1);
					r_mouseCapture.SetBelong(this.instance);
				}
				return r_mouseCapture;
			}
		}

		/// <summary>
		/// Int64 duration
		/// </summary>
		protected RProperty r_duration;
		public virtual RProperty Rduration
		{
			get
			{
				if(r_duration == null)
				{
					r_duration = new(this, "duration", -1);
					r_duration.SetBelong(this.instance);
				}
				return r_duration;
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


        public REventDebuggerCallTrace() : base("UnityEngine.UIElements.EventDebuggerCallTrace")
        {
        }

        public REventDebuggerCallTrace(System.Object instance) : base("UnityEngine.UIElements.EventDebuggerCallTrace")
		{
            SetInstance(instance);
		}

        public REventDebuggerCallTrace(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REventDebuggerCallTrace(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
