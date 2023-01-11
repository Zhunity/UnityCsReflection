using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.EventDebuggerTrace
	/// </summary>
    public partial class REventDebuggerTrace : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.EventDebuggerEventRecord <eventBase>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.REventDebuggerEventRecord r___0__eventBase__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.REventDebuggerEventRecord R__0__eventBase__1__k__BackingField
		{
			get
			{
				if(r___0__eventBase__1__k__BackingField == null)
				{
					r___0__eventBase__1__k__BackingField = new(this, "<eventBase>k__BackingField");
					r___0__eventBase__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__eventBase__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler <focusedElement>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RIEventHandler r___0__focusedElement__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RIEventHandler R__0__focusedElement__1__k__BackingField
		{
			get
			{
				if(r___0__focusedElement__1__k__BackingField == null)
				{
					r___0__focusedElement__1__k__BackingField = new(this, "<focusedElement>k__BackingField");
					r___0__focusedElement__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__focusedElement__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler <mouseCapture>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RIEventHandler r___0__mouseCapture__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RIEventHandler R__0__mouseCapture__1__k__BackingField
		{
			get
			{
				if(r___0__mouseCapture__1__k__BackingField == null)
				{
					r___0__mouseCapture__1__k__BackingField = new(this, "<mouseCapture>k__BackingField");
					r___0__mouseCapture__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__mouseCapture__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int64 <duration>k__BackingField
		/// </summary>
		protected RSystem.RInt64 r___0__duration__1__k__BackingField;
		public virtual RSystem.RInt64 R__0__duration__1__k__BackingField
		{
			get
			{
				if(r___0__duration__1__k__BackingField == null)
				{
					r___0__duration__1__k__BackingField = new(this, "<duration>k__BackingField");
					r___0__duration__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__duration__1__k__BackingField;
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
		protected RSystem.RInt64 r_duration;
		public virtual RSystem.RInt64 Rduration
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


        public REventDebuggerTrace() : base("UnityEngine.UIElements.EventDebuggerTrace")
        {
        }

        public REventDebuggerTrace(System.Object instance) : base("UnityEngine.UIElements.EventDebuggerTrace")
		{
            SetInstance(instance);
		}

        public REventDebuggerTrace(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REventDebuggerTrace(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
