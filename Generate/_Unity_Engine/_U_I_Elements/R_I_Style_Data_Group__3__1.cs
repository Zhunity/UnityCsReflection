
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IStyleDataGroup`1
	/// </summary>
    public partial class RIStyleDataGroup<T> : RMember //
    {

		/// <summary>
		/// T Copy()
		/// </summary>
		protected RMethod r_MCopy;
		public virtual RMethod RMCopy
		{
			get
			{
				if(r_MCopy == null)
				{
					r_MCopy = new(this, "Copy", 0);
					r_MCopy.SetBelong(this.instance);
				}
				return r_MCopy;
			}
		}

		/// <summary>
		/// Void CopyFrom(T ByRef)
		/// </summary>
		protected RMethod r_MCopyFrom_Ref_T;
		public virtual RMethod RMCopyFrom_Ref_T
		{
			get
			{
				if(r_MCopyFrom_Ref_T == null)
				{
					r_MCopyFrom_Ref_T = new(this, "CopyFrom", 0, Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_MCopyFrom_Ref_T.SetBelong(this.instance);
				}
				return r_MCopyFrom_Ref_T;
			}
		}


        public RIStyleDataGroup() : base("UnityEngine.UIElements.IStyleDataGroup`1")
        {
        }

        public RIStyleDataGroup(System.Object instance) : base("UnityEngine.UIElements.IStyleDataGroup`1")
		{
            SetInstance(instance);
		}

        public RIStyleDataGroup(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIStyleDataGroup(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual T Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual void CopyFrom(ref T @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMCopyFrom_Ref_T.Invoke(___genericsType, ___parameters);
			@other = (T)___parameters[0];

            
        }


    }
}
