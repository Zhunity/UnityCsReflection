using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RExceptionServices
{
	/// <summary>
	/// System.Runtime.ExceptionServices.ExceptionDispatchInfo
	/// </summary>
    public partial class RExceptionDispatchInfo : RMember //
    {

		/// <summary>
		/// System.Exception m_Exception
		/// </summary>
		protected RSystem.RException r_m_Exception;
		public virtual RSystem.RException Rm_Exception
		{
			get
			{
				if(r_m_Exception == null)
				{
					r_m_Exception = new(this, "m_Exception");
					r_m_Exception.SetBelong(this.instance);
				}
				return r_m_Exception;
			}
		}

		/// <summary>
		/// System.Object m_stackTrace
		/// </summary>
		protected RSystem.RObject r_m_stackTrace;
		public virtual RSystem.RObject Rm_stackTrace
		{
			get
			{
				if(r_m_stackTrace == null)
				{
					r_m_stackTrace = new(this, "m_stackTrace");
					r_m_stackTrace.SetBelong(this.instance);
				}
				return r_m_stackTrace;
			}
		}

		/// <summary>
		/// System.Object BinaryStackTraceArray
		/// </summary>
		protected RSystem.RObject r_BinaryStackTraceArray;
		public virtual RSystem.RObject RBinaryStackTraceArray
		{
			get
			{
				if(r_BinaryStackTraceArray == null)
				{
					r_BinaryStackTraceArray = new(this, "BinaryStackTraceArray", -1);
					r_BinaryStackTraceArray.SetBelong(this.instance);
				}
				return r_BinaryStackTraceArray;
			}
		}

		/// <summary>
		/// System.Exception SourceException
		/// </summary>
		protected RSystem.RException r_SourceException;
		public virtual RSystem.RException RSourceException
		{
			get
			{
				if(r_SourceException == null)
				{
					r_SourceException = new(this, "SourceException", -1);
					r_SourceException.SetBelong(this.instance);
				}
				return r_SourceException;
			}
		}

		/// <summary>
		/// System.Runtime.ExceptionServices.ExceptionDispatchInfo Capture(System.Exception)
		/// </summary>
		protected static RMethod r_RCapture_Exception;
		public static RMethod RCapture_Exception
		{
			get
			{
				if(r_RCapture_Exception == null)
				{
					r_RCapture_Exception = new(typeof(System.Runtime.ExceptionServices.ExceptionDispatchInfo), "Capture", 0, typeof(System.Exception));
					r_RCapture_Exception.SetBelong(null);
				}
				return r_RCapture_Exception;
			}
		}

		/// <summary>
		/// Void Throw()
		/// </summary>
		protected RMethod r_RThrow;
		public virtual RMethod RThrow
		{
			get
			{
				if(r_RThrow == null)
				{
					r_RThrow = new(this, "Throw", 0);
					r_RThrow.SetBelong(this.instance);
				}
				return r_RThrow;
			}
		}

		/// <summary>
		/// Void Throw(System.Exception)
		/// </summary>
		protected static RMethod r_RThrow_Exception;
		public static RMethod RThrow_Exception
		{
			get
			{
				if(r_RThrow_Exception == null)
				{
					r_RThrow_Exception = new(typeof(System.Runtime.ExceptionServices.ExceptionDispatchInfo), "Throw", 0, typeof(System.Exception));
					r_RThrow_Exception.SetBelong(null);
				}
				return r_RThrow_Exception;
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


        public RExceptionDispatchInfo() : base("System.Runtime.ExceptionServices.ExceptionDispatchInfo")
        {
        }

        public RExceptionDispatchInfo(System.Object instance) : base("System.Runtime.ExceptionServices.ExceptionDispatchInfo")
		{
            SetInstance(instance);
		}

        public RExceptionDispatchInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RExceptionDispatchInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Runtime.ExceptionServices.ExceptionDispatchInfo Capture(System.Exception  @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source};
            var ___result = RCapture_Exception.Invoke(___genericsType, ___parameters);

            return (System.Runtime.ExceptionServices.ExceptionDispatchInfo)___result;
        }


        public virtual void Throw()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrow.Invoke(___genericsType, ___parameters);

            
        }


        public static void Throw(System.Exception  @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source};
            var ___result = RThrow_Exception.Invoke(___genericsType, ___parameters);

            
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
