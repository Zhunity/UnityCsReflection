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
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
			}
		}

		/// <summary>
		/// Void Freeze(System.Runtime.Remoting.Contexts.Context)
		/// </summary>
		protected RMethod r_RFreeze_Context;
		public virtual RMethod RFreeze_Context
		{
			get
			{
				if(r_RFreeze_Context == null)
				{
					r_RFreeze_Context = new(this, "Freeze", 0, typeof(System.Runtime.Remoting.Contexts.Context));
					r_RFreeze_Context.SetBelong(this.instance);
				}
				return r_RFreeze_Context;
			}
		}

		/// <summary>
		/// Boolean IsNewContextOK(System.Runtime.Remoting.Contexts.Context)
		/// </summary>
		protected RMethod r_RIsNewContextOK_Context;
		public virtual RMethod RIsNewContextOK_Context
		{
			get
			{
				if(r_RIsNewContextOK_Context == null)
				{
					r_RIsNewContextOK_Context = new(this, "IsNewContextOK", 0, typeof(System.Runtime.Remoting.Contexts.Context));
					r_RIsNewContextOK_Context.SetBelong(this.instance);
				}
				return r_RIsNewContextOK_Context;
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

        public virtual void Freeze(System.Runtime.Remoting.Contexts.Context  @newContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newContext};
            var ___result = RFreeze_Context.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsNewContextOK(System.Runtime.Remoting.Contexts.Context  @newCtx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newCtx};
            var ___result = RIsNewContextOK_Context.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


    }
}
