
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization
{
	/// <summary>
	/// System.Runtime.Serialization.StreamingContext
	/// </summary>
    public partial class RStreamingContext : RMember //
    {

		/// <summary>
		/// System.Object m_additionalContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_Fm_additionalContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFm_additionalContext
		{
			get
			{
				if(r_Fm_additionalContext == null)
				{
					r_Fm_additionalContext = new(this, "m_additionalContext");
				}
				return r_Fm_additionalContext;
			}
		}

		/// <summary>
		/// System.Runtime.Serialization.StreamingContextStates m_state
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RStreamingContextStates r_Fm_state;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RStreamingContextStates RFm_state
		{
			get
			{
				if(r_Fm_state == null)
				{
					r_Fm_state = new(this, "m_state");
				}
				return r_Fm_state;
			}
		}

		/// <summary>
		/// System.Object Context
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PContext;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPContext
		{
			get
			{
				if(r_PContext == null)
				{
					r_PContext = new(this, "Context", -1);
				}
				return r_PContext;
			}
		}

		/// <summary>
		/// System.Runtime.Serialization.StreamingContextStates State
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RStreamingContextStates r_PState;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RStreamingContextStates RPState
		{
			get
			{
				if(r_PState == null)
				{
					r_PState = new(this, "State", -1);
				}
				return r_PState;
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


        public RStreamingContext() : base("System.Runtime.Serialization.StreamingContext")
        {
        }

        public RStreamingContext(System.Object instance) : base("System.Runtime.Serialization.StreamingContext")
		{
            SetInstance(instance);
		}

        public RStreamingContext(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStreamingContext(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
