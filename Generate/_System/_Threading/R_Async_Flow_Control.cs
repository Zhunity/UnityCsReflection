
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.AsyncFlowControl
	/// </summary>
    public partial class RAsyncFlowControl : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Threading.AsyncFlowControl);
            }
        }

        public RAsyncFlowControl() : base("System.Threading.AsyncFlowControl")
        {
        }

        public RAsyncFlowControl(System.Object instance) : base("System.Threading.AsyncFlowControl")
		{
            SetInstance(instance);
		}

        public RAsyncFlowControl(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAsyncFlowControl(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Boolean useEC
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FuseEC;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFuseEC
		{
			get
			{
				if(r_FuseEC == null)
				{
					r_FuseEC = new(this, "useEC");
				}
				return r_FuseEC;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext _ec
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext r_F_ec;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext RF_ec
		{
			get
			{
				if(r_F_ec == null)
				{
					r_F_ec = new(this, "_ec");
				}
				return r_F_ec;
			}
		}

		/// <summary>
		/// System.Threading.Thread _thread
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RThread r_F_thread;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RThread RF_thread
		{
			get
			{
				if(r_F_thread == null)
				{
					r_F_thread = new(this, "_thread");
				}
				return r_F_thread;
			}
		}

		/// <summary>
		/// Void Setup()
		/// </summary>
		protected RMethod r_MSetup;
		public virtual RMethod RMSetup
		{
			get
			{
				if(r_MSetup == null)
				{
					r_MSetup = new(this, "Setup", 0);
				}
				return r_MSetup;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void Undo()
		/// </summary>
		protected RMethod r_MUndo;
		public virtual RMethod RMUndo
		{
			get
			{
				if(r_MUndo == null)
				{
					r_MUndo = new(this, "Undo", 0);
				}
				return r_MUndo;
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
		/// Boolean Equals(System.Threading.AsyncFlowControl)
		/// </summary>
		protected RMethod r_MEquals_AsyncFlowControl;
		public virtual RMethod RMEquals_AsyncFlowControl
		{
			get
			{
				if(r_MEquals_AsyncFlowControl == null)
				{
					r_MEquals_AsyncFlowControl = new(this, "Equals", 0, typeof(System.Threading.AsyncFlowControl));
				}
				return r_MEquals_AsyncFlowControl;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Threading.AsyncFlowControl, System.Threading.AsyncFlowControl)
		/// </summary>
		protected static RMethod r_Mop_Equality_AsyncFlowControl_AsyncFlowControl;
		public static RMethod RMop_Equality_AsyncFlowControl_AsyncFlowControl
		{
			get
			{
				if(r_Mop_Equality_AsyncFlowControl_AsyncFlowControl == null)
				{
					r_Mop_Equality_AsyncFlowControl_AsyncFlowControl = new(typeof(System.Threading.AsyncFlowControl), "op_Equality", 0, typeof(System.Threading.AsyncFlowControl), typeof(System.Threading.AsyncFlowControl));
				}
				return r_Mop_Equality_AsyncFlowControl_AsyncFlowControl;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Threading.AsyncFlowControl, System.Threading.AsyncFlowControl)
		/// </summary>
		protected static RMethod r_Mop_Inequality_AsyncFlowControl_AsyncFlowControl;
		public static RMethod RMop_Inequality_AsyncFlowControl_AsyncFlowControl
		{
			get
			{
				if(r_Mop_Inequality_AsyncFlowControl_AsyncFlowControl == null)
				{
					r_Mop_Inequality_AsyncFlowControl_AsyncFlowControl = new(typeof(System.Threading.AsyncFlowControl), "op_Inequality", 0, typeof(System.Threading.AsyncFlowControl), typeof(System.Threading.AsyncFlowControl));
				}
				return r_Mop_Inequality_AsyncFlowControl_AsyncFlowControl;
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


        public virtual void Setup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Undo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUndo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Threading.AsyncFlowControl @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_AsyncFlowControl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Threading.AsyncFlowControl @a, System.Threading.AsyncFlowControl @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Equality_AsyncFlowControl_AsyncFlowControl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Threading.AsyncFlowControl @a, System.Threading.AsyncFlowControl @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RMop_Inequality_AsyncFlowControl_AsyncFlowControl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
