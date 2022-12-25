using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RRemoting
{
	/// <summary>
	/// System.Runtime.Remoting.IRemotingTypeInfo
	/// </summary>
    public partial class RIRemotingTypeInfo : RMember //
    {

		/// <summary>
		/// System.String TypeName
		/// </summary>
		protected RProperty r_TypeName;
		public virtual RProperty RTypeName
		{
			get
			{
				if(r_TypeName == null)
				{
					r_TypeName = new(this, "TypeName", -1);
					r_TypeName.SetBelong(this.instance);
				}
				return r_TypeName;
			}
		}

		/// <summary>
		/// Boolean CanCastTo(System.Type, System.Object)
		/// </summary>
		protected RMethod r_RCanCastTo_Type_Object;
		public virtual RMethod RCanCastTo_Type_Object
		{
			get
			{
				if(r_RCanCastTo_Type_Object == null)
				{
					r_RCanCastTo_Type_Object = new(this, "CanCastTo", 0, typeof(System.Type), typeof(System.Object));
					r_RCanCastTo_Type_Object.SetBelong(this.instance);
				}
				return r_RCanCastTo_Type_Object;
			}
		}


        public RIRemotingTypeInfo() : base("System.Runtime.Remoting.IRemotingTypeInfo")
        {
        }

        public RIRemotingTypeInfo(System.Object instance) : base("System.Runtime.Remoting.IRemotingTypeInfo")
		{
            SetInstance(instance);
		}

        public RIRemotingTypeInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIRemotingTypeInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean CanCastTo(System.Type  @fromType, System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromType, @o};
            var ___result = RCanCastTo_Type_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


    }
}
