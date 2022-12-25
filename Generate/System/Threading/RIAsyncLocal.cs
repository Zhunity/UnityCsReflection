using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RThreading
{
	/// <summary>
	/// System.Threading.IAsyncLocal
	/// </summary>
    public partial class RIAsyncLocal : RMember //
    {

		/// <summary>
		/// Void OnValueChanged(System.Object, System.Object, Boolean)
		/// </summary>
		protected RMethod r_ROnValueChanged_Object_Object_Boolean;
		public virtual RMethod ROnValueChanged_Object_Object_Boolean
		{
			get
			{
				if(r_ROnValueChanged_Object_Object_Boolean == null)
				{
					r_ROnValueChanged_Object_Object_Boolean = new(this, "OnValueChanged", 0, typeof(System.Object), typeof(System.Object), typeof(System.Boolean));
					r_ROnValueChanged_Object_Object_Boolean.SetBelong(this.instance);
				}
				return r_ROnValueChanged_Object_Object_Boolean;
			}
		}


        public RIAsyncLocal() : base("System.Threading.IAsyncLocal")
        {
        }

        public RIAsyncLocal(System.Object instance) : base("System.Threading.IAsyncLocal")
		{
            SetInstance(instance);
		}

        public RIAsyncLocal(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIAsyncLocal(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnValueChanged(System.Object  @previousValue, System.Object  @currentValue, System.Boolean  @contextChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@previousValue, @currentValue, @contextChanged};
            var ___result = ROnValueChanged_Object_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }


    }
}
