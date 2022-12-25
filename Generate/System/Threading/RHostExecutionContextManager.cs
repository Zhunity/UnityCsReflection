using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.HostExecutionContextManager
	/// </summary>
    public partial class RHostExecutionContextManager : RMember //
    {

		/// <summary>
		/// System.Threading.HostExecutionContext Capture()
		/// </summary>
		protected RMethod r_RCapture;
		public virtual RMethod RCapture
		{
			get
			{
				if(r_RCapture == null)
				{
					r_RCapture = new(this, "Capture", 0);
					r_RCapture.SetBelong(this.instance);
				}
				return r_RCapture;
			}
		}

		/// <summary>
		/// Void Revert(System.Object)
		/// </summary>
		protected RMethod r_RRevert_Object;
		public virtual RMethod RRevert_Object
		{
			get
			{
				if(r_RRevert_Object == null)
				{
					r_RRevert_Object = new(this, "Revert", 0, typeof(System.Object));
					r_RRevert_Object.SetBelong(this.instance);
				}
				return r_RRevert_Object;
			}
		}

		/// <summary>
		/// System.Object SetHostExecutionContext(System.Threading.HostExecutionContext)
		/// </summary>
		protected RMethod r_RSetHostExecutionContext_HostExecutionContext;
		public virtual RMethod RSetHostExecutionContext_HostExecutionContext
		{
			get
			{
				if(r_RSetHostExecutionContext_HostExecutionContext == null)
				{
					r_RSetHostExecutionContext_HostExecutionContext = new(this, "SetHostExecutionContext", 0, typeof(System.Threading.HostExecutionContext));
					r_RSetHostExecutionContext_HostExecutionContext.SetBelong(this.instance);
				}
				return r_RSetHostExecutionContext_HostExecutionContext;
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


        public RHostExecutionContextManager() : base("System.Threading.HostExecutionContextManager")
        {
        }

        public RHostExecutionContextManager(System.Object instance) : base("System.Threading.HostExecutionContextManager")
		{
            SetInstance(instance);
		}

        public RHostExecutionContextManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RHostExecutionContextManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Threading.HostExecutionContext Capture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCapture.Invoke(___genericsType, ___parameters);

            return (System.Threading.HostExecutionContext)___result;
        }


        public virtual void Revert(System.Object  @previousState)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@previousState};
            var ___result = RRevert_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object SetHostExecutionContext(System.Threading.HostExecutionContext  @hostExecutionContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hostExecutionContext};
            var ___result = RSetHostExecutionContext_HostExecutionContext.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
