using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RHosting
{
	/// <summary>
	/// System.Runtime.Hosting.ApplicationActivator
	/// </summary>
    public partial class RApplicationActivator : RMember //
    {

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateInstance(System.ActivationContext)
		/// </summary>
		protected RMethod r_RCreateInstance_ActivationContext;
		public virtual RMethod RCreateInstance_ActivationContext
		{
			get
			{
				if(r_RCreateInstance_ActivationContext == null)
				{
					r_RCreateInstance_ActivationContext = new(this, "CreateInstance", 0, typeof(System.ActivationContext));
					r_RCreateInstance_ActivationContext.SetBelong(this.instance);
				}
				return r_RCreateInstance_ActivationContext;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateInstance(System.ActivationContext, System.String[])
		/// </summary>
		protected RMethod r_RCreateInstance_ActivationContext_StringArray;
		public virtual RMethod RCreateInstance_ActivationContext_StringArray
		{
			get
			{
				if(r_RCreateInstance_ActivationContext_StringArray == null)
				{
					r_RCreateInstance_ActivationContext_StringArray = new(this, "CreateInstance", 0, typeof(System.ActivationContext), typeof(System.String).MakeArrayType());
					r_RCreateInstance_ActivationContext_StringArray.SetBelong(this.instance);
				}
				return r_RCreateInstance_ActivationContext_StringArray;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateInstanceHelper(System.AppDomainSetup)
		/// </summary>
		protected static RMethod r_RCreateInstanceHelper_AppDomainSetup;
		public static RMethod RCreateInstanceHelper_AppDomainSetup
		{
			get
			{
				if(r_RCreateInstanceHelper_AppDomainSetup == null)
				{
					r_RCreateInstanceHelper_AppDomainSetup = new(typeof(System.Runtime.Hosting.ApplicationActivator), "CreateInstanceHelper", 0, typeof(System.AppDomainSetup));
					r_RCreateInstanceHelper_AppDomainSetup.SetBelong(null);
				}
				return r_RCreateInstanceHelper_AppDomainSetup;
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


        public RApplicationActivator() : base("System.Runtime.Hosting.ApplicationActivator")
        {
        }

        public RApplicationActivator(System.Object instance) : base("System.Runtime.Hosting.ApplicationActivator")
		{
            SetInstance(instance);
		}

        public RApplicationActivator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RApplicationActivator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Runtime.Remoting.ObjectHandle CreateInstance(System.ActivationContext  @activationContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@activationContext};
            var ___result = RCreateInstance_ActivationContext.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjectHandle)___result;
        }


        public virtual System.Runtime.Remoting.ObjectHandle CreateInstance(System.ActivationContext  @activationContext, System.String[]  @activationCustomData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@activationContext, @activationCustomData};
            var ___result = RCreateInstance_ActivationContext_StringArray.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjectHandle)___result;
        }


        public static System.Runtime.Remoting.ObjectHandle CreateInstanceHelper(System.AppDomainSetup  @adSetup)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@adSetup};
            var ___result = RCreateInstanceHelper_AppDomainSetup.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjectHandle)___result;
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
