
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class REventDispatcher
{
	
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.EventDispatcher+EventRecord
	/// </summary>
    public partial class REventRecord : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.EventDispatcher+EventRecord");
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


		/// <summary>
		/// UnityEngine.UIElements.EventBase m_Event
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase r_Fm_Event;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventBase RFm_Event
		{
			get
			{
				if(r_Fm_Event == null)
				{
					r_Fm_Event = new(this, "m_Event");
				}
				return r_Fm_Event;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IPanel m_Panel
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel r_Fm_Panel;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel RFm_Panel
		{
			get
			{
				if(r_Fm_Panel == null)
				{
					r_Fm_Panel = new(this, "m_Panel");
				}
				return r_Fm_Panel;
			}
		}

		/// <summary>
		/// System.Diagnostics.StackTrace m_StackTrace
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RDiagnostics.RStackTrace r_Fm_StackTrace;
		public virtual Hvak.Editor.Refleaction.RSystem.RDiagnostics.RStackTrace RFm_StackTrace
		{
			get
			{
				if(r_Fm_StackTrace == null)
				{
					r_Fm_StackTrace = new(this, "m_StackTrace");
				}
				return r_Fm_StackTrace;
			}
		}

		/// <summary>
		/// System.String stackTrace
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PstackTrace;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPstackTrace
		{
			get
			{
				if(r_PstackTrace == null)
				{
					r_PstackTrace = new(this, "stackTrace", -1);
				}
				return r_PstackTrace;
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


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
}