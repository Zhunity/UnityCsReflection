
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RHosting
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Runtime.Hosting.ApplicationActivator
	/// </summary>
    public partial class RApplicationActivator : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Runtime.Hosting.ApplicationActivator);
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


		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateInstance(System.ActivationContext)
		/// </summary>
		protected RMethod r_MCreateInstance_ActivationContext;
		public virtual RMethod RMCreateInstance_ActivationContext
		{
			get
			{
				if(r_MCreateInstance_ActivationContext == null)
				{
					r_MCreateInstance_ActivationContext = new(this, "CreateInstance", 0, typeof(System.ActivationContext));
				}
				return r_MCreateInstance_ActivationContext;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateInstance(System.ActivationContext, System.String[])
		/// </summary>
		protected RMethod r_MCreateInstance_ActivationContext_StringArray;
		public virtual RMethod RMCreateInstance_ActivationContext_StringArray
		{
			get
			{
				if(r_MCreateInstance_ActivationContext_StringArray == null)
				{
					r_MCreateInstance_ActivationContext_StringArray = new(this, "CreateInstance", 0, typeof(System.ActivationContext), typeof(System.String).MakeArrayType());
				}
				return r_MCreateInstance_ActivationContext_StringArray;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjectHandle CreateInstanceHelper(System.AppDomainSetup)
		/// </summary>
		protected static RMethod r_MCreateInstanceHelper_AppDomainSetup;
		public static RMethod RMCreateInstanceHelper_AppDomainSetup
		{
			get
			{
				if(r_MCreateInstanceHelper_AppDomainSetup == null)
				{
					r_MCreateInstanceHelper_AppDomainSetup = new(Type, "CreateInstanceHelper", 0, typeof(System.AppDomainSetup));
				}
				return r_MCreateInstanceHelper_AppDomainSetup;
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


        public virtual System.Runtime.Remoting.ObjectHandle CreateInstance(System.ActivationContext @activationContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@activationContext};
            var ___result = RMCreateInstance_ActivationContext.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.ObjectHandle>(___result);
        }


        public virtual System.Runtime.Remoting.ObjectHandle CreateInstance(System.ActivationContext @activationContext, System.String[] @activationCustomData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@activationContext, @activationCustomData};
            var ___result = RMCreateInstance_ActivationContext_StringArray.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.ObjectHandle>(___result);
        }


        public static System.Runtime.Remoting.ObjectHandle CreateInstanceHelper(System.AppDomainSetup @adSetup)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@adSetup};
            var ___result = RMCreateInstanceHelper_AppDomainSetup.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Runtime.Remoting.ObjectHandle>(___result);
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
