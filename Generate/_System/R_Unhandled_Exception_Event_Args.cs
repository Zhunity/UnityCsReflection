
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.UnhandledExceptionEventArgs
	/// </summary>
    public partial class RUnhandledExceptionEventArgs : RMember //
    {

		/// <summary>
		/// System.Object _exception
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_F_exception;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RF_exception
		{
			get
			{
				if(r_F_exception == null)
				{
					r_F_exception = new(this, "_exception");
				}
				return r_F_exception;
			}
		}

		/// <summary>
		/// System.Boolean _isTerminating
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F_isTerminating;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF_isTerminating
		{
			get
			{
				if(r_F_isTerminating == null)
				{
					r_F_isTerminating = new(this, "_isTerminating");
				}
				return r_F_isTerminating;
			}
		}

		/// <summary>
		/// System.Object ExceptionObject
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PExceptionObject;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPExceptionObject
		{
			get
			{
				if(r_PExceptionObject == null)
				{
					r_PExceptionObject = new(this, "ExceptionObject", -1);
				}
				return r_PExceptionObject;
			}
		}

		/// <summary>
		/// Boolean IsTerminating
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsTerminating;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsTerminating
		{
			get
			{
				if(r_PIsTerminating == null)
				{
					r_PIsTerminating = new(this, "IsTerminating", -1);
				}
				return r_PIsTerminating;
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


        public RUnhandledExceptionEventArgs() : base("System.UnhandledExceptionEventArgs")
        {
        }

        public RUnhandledExceptionEventArgs(System.Object instance) : base("System.UnhandledExceptionEventArgs")
		{
            SetInstance(instance);
		}

        public RUnhandledExceptionEventArgs(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUnhandledExceptionEventArgs(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
