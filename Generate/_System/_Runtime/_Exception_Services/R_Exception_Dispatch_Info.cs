
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RExceptionServices
{
	/// <summary>
	/// System.Runtime.ExceptionServices.ExceptionDispatchInfo
	/// </summary>
    public partial class RExceptionDispatchInfo : RMember //
    {

		/// <summary>
		/// System.Exception m_Exception
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RException r_Fm_Exception;
		public virtual Hvak.Editor.Refleaction.RSystem.RException RFm_Exception
		{
			get
			{
				if(r_Fm_Exception == null)
				{
					r_Fm_Exception = new(this, "m_Exception");
					r_Fm_Exception.SetBelong(this.GetValue());
				}
				return r_Fm_Exception;
			}
		}

		/// <summary>
		/// System.Object m_stackTrace
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_Fm_stackTrace;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFm_stackTrace
		{
			get
			{
				if(r_Fm_stackTrace == null)
				{
					r_Fm_stackTrace = new(this, "m_stackTrace");
					r_Fm_stackTrace.SetBelong(this.GetValue());
				}
				return r_Fm_stackTrace;
			}
		}

		/// <summary>
		/// System.Object BinaryStackTraceArray
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PBinaryStackTraceArray;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPBinaryStackTraceArray
		{
			get
			{
				if(r_PBinaryStackTraceArray == null)
				{
					r_PBinaryStackTraceArray = new(this, "BinaryStackTraceArray", -1);
					r_PBinaryStackTraceArray.SetBelong(this.GetValue());
				}
				return r_PBinaryStackTraceArray;
			}
		}

		/// <summary>
		/// System.Exception SourceException
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RException r_PSourceException;
		public virtual Hvak.Editor.Refleaction.RSystem.RException RPSourceException
		{
			get
			{
				if(r_PSourceException == null)
				{
					r_PSourceException = new(this, "SourceException", -1);
					r_PSourceException.SetBelong(this.GetValue());
				}
				return r_PSourceException;
			}
		}

		/// <summary>
		/// System.Runtime.ExceptionServices.ExceptionDispatchInfo Capture(System.Exception)
		/// </summary>
		protected static RMethod r_MCapture_Exception;
		public static RMethod RMCapture_Exception
		{
			get
			{
				if(r_MCapture_Exception == null)
				{
					r_MCapture_Exception = new(typeof(System.Runtime.ExceptionServices.ExceptionDispatchInfo), "Capture", 0, typeof(System.Exception));
					r_MCapture_Exception.SetBelong(null);
				}
				return r_MCapture_Exception;
			}
		}

		/// <summary>
		/// Void Throw()
		/// </summary>
		protected RMethod r_MThrow;
		public virtual RMethod RMThrow
		{
			get
			{
				if(r_MThrow == null)
				{
					r_MThrow = new(this, "Throw", 0);
					r_MThrow.SetBelong(this.GetValue());
				}
				return r_MThrow;
			}
		}

		/// <summary>
		/// Void Throw(System.Exception)
		/// </summary>
		protected static RMethod r_MThrow_Exception;
		public static RMethod RMThrow_Exception
		{
			get
			{
				if(r_MThrow_Exception == null)
				{
					r_MThrow_Exception = new(typeof(System.Runtime.ExceptionServices.ExceptionDispatchInfo), "Throw", 0, typeof(System.Exception));
					r_MThrow_Exception.SetBelong(null);
				}
				return r_MThrow_Exception;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
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

        public static System.Runtime.ExceptionServices.ExceptionDispatchInfo Capture(System.Exception @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source};
            var ___result = RMCapture_Exception.Invoke(___genericsType, ___parameters);

            return (System.Runtime.ExceptionServices.ExceptionDispatchInfo)___result;
        }


        public virtual void Throw()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMThrow.Invoke(___genericsType, ___parameters);

            
        }


        public static void Throw(System.Exception @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source};
            var ___result = RMThrow_Exception.Invoke(___genericsType, ___parameters);

            
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
