
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.ExecutionContextSwitcher
	/// </summary>
    public partial class RExecutionContextSwitcher : RMember //
    {

		/// <summary>
		/// System.Threading.ExecutionContext+Reader outerEC
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext.RReader r_FouterEC;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RExecutionContext.RReader RFouterEC
		{
			get
			{
				if(r_FouterEC == null)
				{
					r_FouterEC = new(this, "outerEC");
				}
				return r_FouterEC;
			}
		}

		/// <summary>
		/// System.Boolean outerECBelongsToScope
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FouterECBelongsToScope;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFouterECBelongsToScope
		{
			get
			{
				if(r_FouterECBelongsToScope == null)
				{
					r_FouterECBelongsToScope = new(this, "outerECBelongsToScope");
				}
				return r_FouterECBelongsToScope;
			}
		}

		/// <summary>
		/// System.Object hecsw
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_Fhecsw;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFhecsw
		{
			get
			{
				if(r_Fhecsw == null)
				{
					r_Fhecsw = new(this, "hecsw");
				}
				return r_Fhecsw;
			}
		}

		/// <summary>
		/// System.Threading.Thread thread
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RThreading.RThread r_Fthread;
		public virtual Hvak.Editor.Refleaction.RSystem.RThreading.RThread RFthread
		{
			get
			{
				if(r_Fthread == null)
				{
					r_Fthread = new(this, "thread");
				}
				return r_Fthread;
			}
		}

		/// <summary>
		/// Boolean UndoNoThrow()
		/// </summary>
		protected RMethod r_MUndoNoThrow;
		public virtual RMethod RMUndoNoThrow
		{
			get
			{
				if(r_MUndoNoThrow == null)
				{
					r_MUndoNoThrow = new(this, "UndoNoThrow", 0);
				}
				return r_MUndoNoThrow;
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
            var ___result = RMUndoNoThrow.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Undo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUndo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
