using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.ExecutionContextSwitcher
	/// </summary>
    public partial class RExecutionContextSwitcher : RMember //
    {

		/// <summary>
		/// System.Threading.ExecutionContext+Reader outerEC
		/// </summary>
		protected RSystem.RThreading.RExecutionContext.RReader r_outerEC;
		public virtual RSystem.RThreading.RExecutionContext.RReader RouterEC
		{
			get
			{
				if(r_outerEC == null)
				{
					r_outerEC = new(this, "outerEC");
					r_outerEC.SetBelong(this.instance);
				}
				return r_outerEC;
			}
		}

		/// <summary>
		/// System.Boolean outerECBelongsToScope
		/// </summary>
		protected RField r_outerECBelongsToScope;
		public virtual RField RouterECBelongsToScope
		{
			get
			{
				if(r_outerECBelongsToScope == null)
				{
					r_outerECBelongsToScope = new(this, "outerECBelongsToScope");
					r_outerECBelongsToScope.SetBelong(this.instance);
				}
				return r_outerECBelongsToScope;
			}
		}

		/// <summary>
		/// System.Object hecsw
		/// </summary>
		protected RSystem.RObject r_hecsw;
		public virtual RSystem.RObject Rhecsw
		{
			get
			{
				if(r_hecsw == null)
				{
					r_hecsw = new(this, "hecsw");
					r_hecsw.SetBelong(this.instance);
				}
				return r_hecsw;
			}
		}

		/// <summary>
		/// System.Threading.Thread thread
		/// </summary>
		protected RSystem.RThreading.RThread r_thread;
		public virtual RSystem.RThreading.RThread Rthread
		{
			get
			{
				if(r_thread == null)
				{
					r_thread = new(this, "thread");
					r_thread.SetBelong(this.instance);
				}
				return r_thread;
			}
		}

		/// <summary>
		/// Boolean UndoNoThrow()
		/// </summary>
		protected RMethod r_RUndoNoThrow;
		public virtual RMethod RUndoNoThrow
		{
			get
			{
				if(r_RUndoNoThrow == null)
				{
					r_RUndoNoThrow = new(this, "UndoNoThrow", 0);
					r_RUndoNoThrow.SetBelong(this.instance);
				}
				return r_RUndoNoThrow;
			}
		}

		/// <summary>
		/// Void Undo()
		/// </summary>
		protected RMethod r_RUndo;
		public virtual RMethod RUndo
		{
			get
			{
				if(r_RUndo == null)
				{
					r_RUndo = new(this, "Undo", 0);
					r_RUndo.SetBelong(this.instance);
				}
				return r_RUndo;
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


        public RExecutionContextSwitcher() : base("System.Threading.ExecutionContextSwitcher")
        {
        }

        public RExecutionContextSwitcher(System.Object instance) : base("System.Threading.ExecutionContextSwitcher")
		{
            SetInstance(instance);
		}

        public RExecutionContextSwitcher(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RExecutionContextSwitcher(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean UndoNoThrow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUndoNoThrow.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Undo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUndo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
