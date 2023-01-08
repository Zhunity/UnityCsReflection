using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.AsyncFlowControl
	/// </summary>
    public partial class RAsyncFlowControl : RMember //
    {

		/// <summary>
		/// System.Boolean useEC
		/// </summary>
		protected RField r_useEC;
		public virtual RField RuseEC
		{
			get
			{
				if(r_useEC == null)
				{
					r_useEC = new(this, "useEC");
					r_useEC.SetBelong(this.instance);
				}
				return r_useEC;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext _ec
		/// </summary>
		protected RSystem.RThreading.RExecutionContext r__ec;
		public virtual RSystem.RThreading.RExecutionContext R_ec
		{
			get
			{
				if(r__ec == null)
				{
					r__ec = new(this, "_ec");
					r__ec.SetBelong(this.instance);
				}
				return r__ec;
			}
		}

		/// <summary>
		/// System.Threading.Thread _thread
		/// </summary>
		protected RSystem.RThreading.RThread r__thread;
		public virtual RSystem.RThreading.RThread R_thread
		{
			get
			{
				if(r__thread == null)
				{
					r__thread = new(this, "_thread");
					r__thread.SetBelong(this.instance);
				}
				return r__thread;
			}
		}

		/// <summary>
		/// Void Setup()
		/// </summary>
		protected RMethod r_Setup;
		public virtual RMethod RSetup
		{
			get
			{
				if(r_Setup == null)
				{
					r_Setup = new(this, "Setup", 0);
					r_Setup.SetBelong(this.instance);
				}
				return r_Setup;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_Dispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_Dispose == null)
				{
					r_Dispose = new(this, "Dispose", 0);
					r_Dispose.SetBelong(this.instance);
				}
				return r_Dispose;
			}
		}

		/// <summary>
		/// Void Undo()
		/// </summary>
		protected RMethod r_Undo;
		public virtual RMethod RUndo
		{
			get
			{
				if(r_Undo == null)
				{
					r_Undo = new(this, "Undo", 0);
					r_Undo.SetBelong(this.instance);
				}
				return r_Undo;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Threading.AsyncFlowControl)
		/// </summary>
		protected RMethod r_Equals_AsyncFlowControl;
		public virtual RMethod REquals_AsyncFlowControl
		{
			get
			{
				if(r_Equals_AsyncFlowControl == null)
				{
					r_Equals_AsyncFlowControl = new(this, "Equals", 0, typeof(System.Threading.AsyncFlowControl));
					r_Equals_AsyncFlowControl.SetBelong(this.instance);
				}
				return r_Equals_AsyncFlowControl;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Threading.AsyncFlowControl, System.Threading.AsyncFlowControl)
		/// </summary>
		protected static RMethod r_op_Equality_AsyncFlowControl_AsyncFlowControl;
		public static RMethod Rop_Equality_AsyncFlowControl_AsyncFlowControl
		{
			get
			{
				if(r_op_Equality_AsyncFlowControl_AsyncFlowControl == null)
				{
					r_op_Equality_AsyncFlowControl_AsyncFlowControl = new(typeof(System.Threading.AsyncFlowControl), "op_Equality", 0, typeof(System.Threading.AsyncFlowControl), typeof(System.Threading.AsyncFlowControl));
					r_op_Equality_AsyncFlowControl_AsyncFlowControl.SetBelong(null);
				}
				return r_op_Equality_AsyncFlowControl_AsyncFlowControl;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Threading.AsyncFlowControl, System.Threading.AsyncFlowControl)
		/// </summary>
		protected static RMethod r_op_Inequality_AsyncFlowControl_AsyncFlowControl;
		public static RMethod Rop_Inequality_AsyncFlowControl_AsyncFlowControl
		{
			get
			{
				if(r_op_Inequality_AsyncFlowControl_AsyncFlowControl == null)
				{
					r_op_Inequality_AsyncFlowControl_AsyncFlowControl = new(typeof(System.Threading.AsyncFlowControl), "op_Inequality", 0, typeof(System.Threading.AsyncFlowControl), typeof(System.Threading.AsyncFlowControl));
					r_op_Inequality_AsyncFlowControl_AsyncFlowControl.SetBelong(null);
				}
				return r_op_Inequality_AsyncFlowControl_AsyncFlowControl;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
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

        public virtual void Setup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Undo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUndo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Threading.AsyncFlowControl  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_AsyncFlowControl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Threading.AsyncFlowControl  @a, System.Threading.AsyncFlowControl  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Equality_AsyncFlowControl_AsyncFlowControl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Threading.AsyncFlowControl  @a, System.Threading.AsyncFlowControl  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Inequality_AsyncFlowControl_AsyncFlowControl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
