using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IVisualElementScheduledItem
	/// </summary>
    public partial class RIVisualElementScheduledItem : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.VisualElement element
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_Pelement;
		public virtual RUnityEngine.RUIElements.RVisualElement RPelement
		{
			get
			{
				if(r_Pelement == null)
				{
					r_Pelement = new(this, "element", -1);
					r_Pelement.SetBelong(this.instance);
				}
				return r_Pelement;
			}
		}

		/// <summary>
		/// Boolean isActive
		/// </summary>
		protected RSystem.RBoolean r_PisActive;
		public virtual RSystem.RBoolean RPisActive
		{
			get
			{
				if(r_PisActive == null)
				{
					r_PisActive = new(this, "isActive", -1);
					r_PisActive.SetBelong(this.instance);
				}
				return r_PisActive;
			}
		}

		/// <summary>
		/// Void Resume()
		/// </summary>
		protected RMethod r_MResume;
		public virtual RMethod RMResume
		{
			get
			{
				if(r_MResume == null)
				{
					r_MResume = new(this, "Resume", 0);
					r_MResume.SetBelong(this.instance);
				}
				return r_MResume;
			}
		}

		/// <summary>
		/// Void Pause()
		/// </summary>
		protected RMethod r_MPause;
		public virtual RMethod RMPause
		{
			get
			{
				if(r_MPause == null)
				{
					r_MPause = new(this, "Pause", 0);
					r_MPause.SetBelong(this.instance);
				}
				return r_MPause;
			}
		}

		/// <summary>
		/// Void ExecuteLater(Int64)
		/// </summary>
		protected RMethod r_MExecuteLater_Int64;
		public virtual RMethod RMExecuteLater_Int64
		{
			get
			{
				if(r_MExecuteLater_Int64 == null)
				{
					r_MExecuteLater_Int64 = new(this, "ExecuteLater", 0, typeof(System.Int64));
					r_MExecuteLater_Int64.SetBelong(this.instance);
				}
				return r_MExecuteLater_Int64;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduledItem StartingIn(Int64)
		/// </summary>
		protected RMethod r_MStartingIn_Int64;
		public virtual RMethod RMStartingIn_Int64
		{
			get
			{
				if(r_MStartingIn_Int64 == null)
				{
					r_MStartingIn_Int64 = new(this, "StartingIn", 0, typeof(System.Int64));
					r_MStartingIn_Int64.SetBelong(this.instance);
				}
				return r_MStartingIn_Int64;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduledItem Every(Int64)
		/// </summary>
		protected RMethod r_MEvery_Int64;
		public virtual RMethod RMEvery_Int64
		{
			get
			{
				if(r_MEvery_Int64 == null)
				{
					r_MEvery_Int64 = new(this, "Every", 0, typeof(System.Int64));
					r_MEvery_Int64.SetBelong(this.instance);
				}
				return r_MEvery_Int64;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduledItem Until(System.Func`1[System.Boolean])
		/// </summary>
		protected RMethod r_MUntil_Func_d_Boolean_p_;
		public virtual RMethod RMUntil_Func_d_Boolean_p_
		{
			get
			{
				if(r_MUntil_Func_d_Boolean_p_ == null)
				{
					r_MUntil_Func_d_Boolean_p_ = new(this, "Until", 0, typeof(System.Func<>).MakeGenericType(typeof(System.Boolean)));
					r_MUntil_Func_d_Boolean_p_.SetBelong(this.instance);
				}
				return r_MUntil_Func_d_Boolean_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduledItem ForDuration(Int64)
		/// </summary>
		protected RMethod r_MForDuration_Int64;
		public virtual RMethod RMForDuration_Int64
		{
			get
			{
				if(r_MForDuration_Int64 == null)
				{
					r_MForDuration_Int64 = new(this, "ForDuration", 0, typeof(System.Int64));
					r_MForDuration_Int64.SetBelong(this.instance);
				}
				return r_MForDuration_Int64;
			}
		}


        public RIVisualElementScheduledItem() : base("UnityEngine.UIElements.IVisualElementScheduledItem")
        {
        }

        public RIVisualElementScheduledItem(System.Object instance) : base("UnityEngine.UIElements.IVisualElementScheduledItem")
		{
            SetInstance(instance);
		}

        public RIVisualElementScheduledItem(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIVisualElementScheduledItem(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Resume()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResume.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Pause()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPause.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteLater(System.Int64 @delayMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delayMs};
            var ___result = RMExecuteLater_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.IVisualElementScheduledItem StartingIn(System.Int64 @delayMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delayMs};
            var ___result = RMStartingIn_Int64.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.IVisualElementScheduledItem)___result;
        }


        public virtual UnityEngine.UIElements.IVisualElementScheduledItem Every(System.Int64 @intervalMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@intervalMs};
            var ___result = RMEvery_Int64.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.IVisualElementScheduledItem)___result;
        }


        public virtual UnityEngine.UIElements.IVisualElementScheduledItem Until(System.Func<System.Boolean> @stopCondition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stopCondition};
            var ___result = RMUntil_Func_d_Boolean_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.IVisualElementScheduledItem)___result;
        }


        public virtual UnityEngine.UIElements.IVisualElementScheduledItem ForDuration(System.Int64 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@durationMs};
            var ___result = RMForDuration_Int64.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.IVisualElementScheduledItem)___result;
        }


    }
}
