
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting
{
	/// <summary>
	/// System.Runtime.Remoting.IRemotingTypeInfo
	/// </summary>
    public partial class RIRemotingTypeInfo : RMember //
    {

		/// <summary>
		/// System.String TypeName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PTypeName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPTypeName
		{
			get
			{
				if(r_PTypeName == null)
				{
					r_PTypeName = new(this, "TypeName", -1);
					r_PTypeName.SetBelong(this.GetValue());
				}
				return r_PTypeName;
			}
		}

		/// <summary>
		/// Boolean CanCastTo(System.Type, System.Object)
		/// </summary>
		protected RMethod r_MCanCastTo_Type_Object;
		public virtual RMethod RMCanCastTo_Type_Object
		{
			get
			{
				if(r_MCanCastTo_Type_Object == null)
				{
					r_MCanCastTo_Type_Object = new(this, "CanCastTo", 0, typeof(System.Type), typeof(System.Object));
					r_MCanCastTo_Type_Object.SetBelong(this.GetValue());
				}
				return r_MCanCastTo_Type_Object;
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

        public virtual System.Boolean CanCastTo(System.Type @fromType, System.Object @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromType, @o};
            var ___result = RMCanCastTo_Type_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


    }
}
