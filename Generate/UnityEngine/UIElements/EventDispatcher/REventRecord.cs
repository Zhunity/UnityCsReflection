using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class REventDispatcher
{
	
	/// <summary>
	/// UnityEngine.UIElements.EventDispatcher+EventRecord
	/// </summary>
    public partial class REventRecord : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.EventBase m_Event
		/// </summary>
		protected RUnityEngine.RUIElements.REventBase r_m_Event;
		public virtual RUnityEngine.RUIElements.REventBase Rm_Event
		{
			get
			{
				if(r_m_Event == null)
				{
					r_m_Event = new(this, "m_Event");
					r_m_Event.SetBelong(this.instance);
				}
				return r_m_Event;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IPanel m_Panel
		/// </summary>
		protected RUnityEngine.RUIElements.RIPanel r_m_Panel;
		public virtual RUnityEngine.RUIElements.RIPanel Rm_Panel
		{
			get
			{
				if(r_m_Panel == null)
				{
					r_m_Panel = new(this, "m_Panel");
					r_m_Panel.SetBelong(this.instance);
				}
				return r_m_Panel;
			}
		}

		/// <summary>
		/// System.Diagnostics.StackTrace m_StackTrace
		/// </summary>
		protected RSystem.RDiagnostics.RStackTrace r_m_StackTrace;
		public virtual RSystem.RDiagnostics.RStackTrace Rm_StackTrace
		{
			get
			{
				if(r_m_StackTrace == null)
				{
					r_m_StackTrace = new(this, "m_StackTrace");
					r_m_StackTrace.SetBelong(this.instance);
				}
				return r_m_StackTrace;
			}
		}

		/// <summary>
		/// System.String stackTrace
		/// </summary>
		protected RProperty r_stackTrace;
		public virtual RProperty RstackTrace
		{
			get
			{
				if(r_stackTrace == null)
				{
					r_stackTrace = new(this, "stackTrace", -1);
					r_stackTrace.SetBelong(this.instance);
				}
				return r_stackTrace;
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


        public REventRecord() : base("UnityEngine.UIElements.EventDispatcher+EventRecord")
        {
        }

        public REventRecord(System.Object instance) : base("UnityEngine.UIElements.EventDispatcher+EventRecord")
		{
            SetInstance(instance);
		}

        public REventRecord(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REventRecord(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
}