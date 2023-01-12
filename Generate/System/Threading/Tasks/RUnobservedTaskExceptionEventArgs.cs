using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading.RTasks
{
	/// <summary>
	/// System.Threading.Tasks.UnobservedTaskExceptionEventArgs
	/// </summary>
    public partial class RUnobservedTaskExceptionEventArgs : RMember //
    {

		/// <summary>
		/// System.AggregateException m_exception
		/// </summary>
		protected RSystem.RAggregateException r_Fm_exception;
		public virtual RSystem.RAggregateException RFm_exception
		{
			get
			{
				if(r_Fm_exception == null)
				{
					r_Fm_exception = new(this, "m_exception");
					r_Fm_exception.SetBelong(this.instance);
				}
				return r_Fm_exception;
			}
		}

		/// <summary>
		/// System.Boolean m_observed
		/// </summary>
		protected RSystem.RBoolean r_Fm_observed;
		public virtual RSystem.RBoolean RFm_observed
		{
			get
			{
				if(r_Fm_observed == null)
				{
					r_Fm_observed = new(this, "m_observed");
					r_Fm_observed.SetBelong(this.instance);
				}
				return r_Fm_observed;
			}
		}

		/// <summary>
		/// Boolean Observed
		/// </summary>
		protected RSystem.RBoolean r_PObserved;
		public virtual RSystem.RBoolean RPObserved
		{
			get
			{
				if(r_PObserved == null)
				{
					r_PObserved = new(this, "Observed", -1);
					r_PObserved.SetBelong(this.instance);
				}
				return r_PObserved;
			}
		}

		/// <summary>
		/// System.AggregateException Exception
		/// </summary>
		protected RSystem.RAggregateException r_PException;
		public virtual RSystem.RAggregateException RPException
		{
			get
			{
				if(r_PException == null)
				{
					r_PException = new(this, "Exception", -1);
					r_PException.SetBelong(this.instance);
				}
				return r_PException;
			}
		}

		/// <summary>
		/// Void SetObserved()
		/// </summary>
		protected RMethod r_MSetObserved;
		public virtual RMethod RMSetObserved
		{
			get
			{
				if(r_MSetObserved == null)
				{
					r_MSetObserved = new(this, "SetObserved", 0);
					r_MSetObserved.SetBelong(this.instance);
				}
				return r_MSetObserved;
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


        public RUnobservedTaskExceptionEventArgs() : base("System.Threading.Tasks.UnobservedTaskExceptionEventArgs")
        {
        }

        public RUnobservedTaskExceptionEventArgs(System.Object instance) : base("System.Threading.Tasks.UnobservedTaskExceptionEventArgs")
		{
            SetInstance(instance);
		}

        public RUnobservedTaskExceptionEventArgs(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUnobservedTaskExceptionEventArgs(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetObserved()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetObserved.Invoke(___genericsType, ___parameters);

            
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
