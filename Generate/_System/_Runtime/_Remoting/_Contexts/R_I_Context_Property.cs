
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting.RContexts
{
	/// <summary>
	/// System.Runtime.Remoting.Contexts.IContextProperty
	/// </summary>
    public partial class RIContextProperty : RMember //
    {

		/// <summary>
		/// System.String Name
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PName;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPName
		{
			get
			{
				if(r_PName == null)
				{
					r_PName = new(this, "Name", -1);
					r_PName.SetBelong(this.instance);
				}
				return r_PName;
			}
		}

		/// <summary>
		/// Void Freeze(System.Runtime.Remoting.Contexts.Context)
		/// </summary>
		protected RMethod r_MFreeze_Context;
		public virtual RMethod RMFreeze_Context
		{
			get
			{
				if(r_MFreeze_Context == null)
				{
					r_MFreeze_Context = new(this, "Freeze", 0, typeof(System.Runtime.Remoting.Contexts.Context));
					r_MFreeze_Context.SetBelong(this.instance);
				}
				return r_MFreeze_Context;
			}
		}

		/// <summary>
		/// Boolean IsNewContextOK(System.Runtime.Remoting.Contexts.Context)
		/// </summary>
		protected RMethod r_MIsNewContextOK_Context;
		public virtual RMethod RMIsNewContextOK_Context
		{
			get
			{
				if(r_MIsNewContextOK_Context == null)
				{
					r_MIsNewContextOK_Context = new(this, "IsNewContextOK", 0, typeof(System.Runtime.Remoting.Contexts.Context));
					r_MIsNewContextOK_Context.SetBelong(this.instance);
				}
				return r_MIsNewContextOK_Context;
			}
		}


        public RIContextProperty() : base("System.Runtime.Remoting.Contexts.IContextProperty")
        {
        }

        public RIContextProperty(System.Object instance) : base("System.Runtime.Remoting.Contexts.IContextProperty")
		{
            SetInstance(instance);
		}

        public RIContextProperty(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIContextProperty(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Freeze(System.Runtime.Remoting.Contexts.Context @newContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newContext};
            var ___result = RMFreeze_Context.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsNewContextOK(System.Runtime.Remoting.Contexts.Context @newCtx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newCtx};
            var ___result = RMIsNewContextOK_Context.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


    }
}