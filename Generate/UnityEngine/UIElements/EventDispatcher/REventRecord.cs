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

        public virtual System.Boolean Equals(System.Object @obj)
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