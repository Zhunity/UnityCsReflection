
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RCompilerServices
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Runtime.CompilerServices.ConfiguredTaskAwaitable
	/// </summary>
    public partial class RConfiguredTaskAwaitable : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Runtime.CompilerServices.ConfiguredTaskAwaitable);
            }
        }

        public RConfiguredTaskAwaitable() : base("System.Runtime.CompilerServices.ConfiguredTaskAwaitable")
        {
        }

        public RConfiguredTaskAwaitable(System.Object instance) : base("System.Runtime.CompilerServices.ConfiguredTaskAwaitable")
		{
            SetInstance(instance);
		}

        public RConfiguredTaskAwaitable(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RConfiguredTaskAwaitable(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Runtime.CompilerServices.ConfiguredTaskAwaitable+ConfiguredTaskAwaiter m_configuredTaskAwaiter
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RCompilerServices.RConfiguredTaskAwaitable.RConfiguredTaskAwaiter r_Fm_configuredTaskAwaiter;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RCompilerServices.RConfiguredTaskAwaitable.RConfiguredTaskAwaiter RFm_configuredTaskAwaiter
		{
			get
			{
				if(r_Fm_configuredTaskAwaiter == null)
				{
					r_Fm_configuredTaskAwaiter = new(this, "m_configuredTaskAwaiter");
				}
				return r_Fm_configuredTaskAwaiter;
			}
		}

		/// <summary>
		/// ConfiguredTaskAwaiter GetAwaiter()
		/// </summary>
		protected RMethod r_MGetAwaiter;
		public virtual RMethod RMGetAwaiter
		{
			get
			{
				if(r_MGetAwaiter == null)
				{
					r_MGetAwaiter = new(this, "GetAwaiter", 0);
				}
				return r_MGetAwaiter;
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


        public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RCompilerServices.RConfiguredTaskAwaitable.RConfiguredTaskAwaiter GetAwaiter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAwaiter.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RRuntime.RCompilerServices.RConfiguredTaskAwaitable.RConfiguredTaskAwaiter>(___result);
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
