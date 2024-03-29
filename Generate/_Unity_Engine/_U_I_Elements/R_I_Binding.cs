
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.IBinding
	/// </summary>
    public partial class RIBinding : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.IBinding);
            }
        }

        public RIBinding() : base("UnityEngine.UIElements.IBinding")
        {
        }

        public RIBinding(System.Object instance) : base("UnityEngine.UIElements.IBinding")
		{
            SetInstance(instance);
		}

        public RIBinding(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIBinding(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// Void PreUpdate()
		/// </summary>
		protected RMethod r_MPreUpdate;
		public virtual RMethod RMPreUpdate
		{
			get
			{
				if(r_MPreUpdate == null)
				{
					r_MPreUpdate = new(this, "PreUpdate", 0);
				}
				return r_MPreUpdate;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_MUpdate;
		public virtual RMethod RMUpdate
		{
			get
			{
				if(r_MUpdate == null)
				{
					r_MUpdate = new(this, "Update", 0);
				}
				return r_MUpdate;
			}
		}

		/// <summary>
		/// Void Release()
		/// </summary>
		protected RMethod r_MRelease;
		public virtual RMethod RMRelease
		{
			get
			{
				if(r_MRelease == null)
				{
					r_MRelease = new(this, "Release", 0);
				}
				return r_MRelease;
			}
		}


        public virtual void PreUpdate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPreUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRelease.Invoke(___genericsType, ___parameters);

            
        }


    }
}
