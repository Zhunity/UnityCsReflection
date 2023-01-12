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
		protected RUnityEngine.RUIElements.REventDebuggerEventRecord r_F__0__eventBase__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.REventDebuggerEventRecord RF__0__eventBase__1__k__BackingField
		{
			get
			{
				if(r_F__0__eventBase__1__k__BackingField == null)
				{
					r_F__0__eventBase__1__k__BackingField = new(this, "<eventBase>k__BackingField");
					r_F__0__eventBase__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__eventBase__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler <focusedElement>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RIEventHandler r_F__0__focusedElement__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RIEventHandler RF__0__focusedElement__1__k__BackingField
		{
			get
			{
				if(r_F__0__focusedElement__1__k__BackingField == null)
				{
					r_F__0__focusedElement__1__k__BackingField = new(this, "<focusedElement>k__BackingField");
					r_F__0__focusedElement__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__focusedElement__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler <mouseCapture>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RIEventHandler r_F__0__mouseCapture__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RIEventHandler RF__0__mouseCapture__1__k__BackingField
		{
			get
			{
				if(r_F__0__mouseCapture__1__k__BackingField == null)
				{
					r_F__0__mouseCapture__1__k__BackingField = new(this, "<mouseCapture>k__BackingField");
					r_F__0__mouseCapture__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__mouseCapture__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int64 <duration>k__BackingField
		/// </summary>
		protected RSystem.RInt64 r_F__0__duration__1__k__BackingField;
		public virtual RSystem.RInt64 RF__0__duration__1__k__BackingField
		{
			get
			{
				if(r_F__0__duration__1__k__BackingField == null)
				{
					r_F__0__duration__1__k__BackingField = new(this, "<duration>k__BackingField");
					r_F__0__duration__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__duration__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventDebuggerEventRecord eventBase
		/// </summary>
		protected RUnityEngine.RUIElements.REventDebuggerEventRecord r_PeventBase;
		public virtual RUnityEngine.RUIElements.REventDebuggerEventRecord RPeventBase
		{
			get
			{
				if(r_PeventBase == null)
				{
					r_PeventBase = new(this, "eventBase", -1);
					r_PeventBase.SetBelong(this.instance);
				}
				return r_PeventBase;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler focusedElement
		/// </summary>
		protected RUnityEngine.RUIElements.RIEventHandler r_PfocusedElement;
		public virtual RUnityEngine.RUIElements.RIEventHandler RPfocusedElement
		{
			get
			{
				if(r_PfocusedElement == null)
				{
					r_PfocusedElement = new(this, "focusedElement", -1);
					r_PfocusedElement.SetBelong(this.instance);
				}
				return r_PfocusedElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IEventHandler mouseCapture
		/// </summary>
		protected RUnityEngine.RUIElements.RIEventHandler r_PmouseCapture;
		public virtual RUnityEngine.RUIElements.RIEventHandler RPmouseCapture
		{
			get
			{
				if(r_PmouseCapture == null)
				{
					r_PmouseCapture = new(this, "mouseCapture", -1);
					r_PmouseCapture.SetBelong(this.instance);
				}
				return r_PmouseCapture;
			}
		}

		/// <summary>
		/// Int64 duration
		/// </summary>
		protected RSystem.RInt64 r_Pduration;
		public virtual RSystem.RInt64 RPduration
		{
			get
			{
				if(r_Pduration == null)
				{
					r_Pduration = new(this, "duration", -1);
					r_Pduration.SetBelong(this.instance);
				}
				return r_Pduration;
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
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
