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
		protected RUnityEngine.RUIElements.RVisualElement r_element;
		public virtual RUnityEngine.RUIElements.RVisualElement Relement
		{
			get
			{
				if(r_element == null)
				{
					r_element = new(this, "element", -1);
					r_element.SetBelong(this.instance);
				}
				return r_element;
			}
		}

		/// <summary>
		/// Boolean isActive
		/// </summary>
		protected RSystem.RBoolean r_isActive;
		public virtual RSystem.RBoolean RisActive
		{
			get
			{
				if(r_isActive == null)
				{
					r_isActive = new(this, "isActive", -1);
					r_isActive.SetBelong(this.instance);
				}
				return r_isActive;
			}
		}

		/// <summary>
		/// Void Resume()
		/// </summary>
		protected RMethod r_Resume;
		public virtual RMethod RResume
		{
			get
			{
				if(r_Resume == null)
				{
					r_Resume = new(this, "Resume", 0);
					r_Resume.SetBelong(this.instance);
				}
				return r_Resume;
			}
		}

		/// <summary>
		/// Void Pause()
		/// </summary>
		protected RMethod r_Pause;
		public virtual RMethod RPause
		{
			get
			{
				if(r_Pause == null)
				{
					r_Pause = new(this, "Pause", 0);
					r_Pause.SetBelong(this.instance);
				}
				return r_Pause;
			}
		}

		/// <summary>
		/// Void ExecuteLater(Int64)
		/// </summary>
		protected RMethod r_ExecuteLater_Int64;
		public virtual RMethod RExecuteLater_Int64
		{
			get
			{
				if(r_ExecuteLater_Int64 == null)
				{
					r_ExecuteLater_Int64 = new(this, "ExecuteLater", 0, typeof(System.Int64));
					r_ExecuteLater_Int64.SetBelong(this.instance);
				}
				return r_ExecuteLater_Int64;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduledItem StartingIn(Int64)
		/// </summary>
		protected RMethod r_StartingIn_Int64;
		public virtual RMethod RStartingIn_Int64
		{
			get
			{
				if(r_StartingIn_Int64 == null)
				{
					r_StartingIn_Int64 = new(this, "StartingIn", 0, typeof(System.Int64));
					r_StartingIn_Int64.SetBelong(this.instance);
				}
				return r_StartingIn_Int64;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduledItem Every(Int64)
		/// </summary>
		protected RMethod r_Every_Int64;
		public virtual RMethod REvery_Int64
		{
			get
			{
				if(r_Every_Int64 == null)
				{
					r_Every_Int64 = new(this, "Every", 0, typeof(System.Int64));
					r_Every_Int64.SetBelong(this.instance);
				}
				return r_Every_Int64;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduledItem Until(System.Func`1[System.Boolean])
		/// </summary>
		protected RMethod r_Until_Func_d_Boolean_p_;
		public virtual RMethod RUntil_Func_d_Boolean_p_
		{
			get
			{
				if(r_Until_Func_d_Boolean_p_ == null)
				{
					r_Until_Func_d_Boolean_p_ = new(this, "Until", 0, typeof(System.Func<>).MakeGenericType(typeof(System.Boolean)));
					r_Until_Func_d_Boolean_p_.SetBelong(this.instance);
				}
				return r_Until_Func_d_Boolean_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduledItem ForDuration(Int64)
		/// </summary>
		protected RMethod r_ForDuration_Int64;
		public virtual RMethod RForDuration_Int64
		{
			get
			{
				if(r_ForDuration_Int64 == null)
				{
					r_ForDuration_Int64 = new(this, "ForDuration", 0, typeof(System.Int64));
					r_ForDuration_Int64.SetBelong(this.instance);
				}
				return r_ForDuration_Int64;
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
            var ___result = RResume.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Pause()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPause.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteLater(System.Int64 @delayMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delayMs};
            var ___result = RExecuteLater_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.IVisualElementScheduledItem StartingIn(System.Int64 @delayMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delayMs};
            var ___result = RStartingIn_Int64.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.IVisualElementScheduledItem)___result;
        }


        public virtual UnityEngine.UIElements.IVisualElementScheduledItem Every(System.Int64 @intervalMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@intervalMs};
            var ___result = REvery_Int64.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.IVisualElementScheduledItem)___result;
        }


        public virtual UnityEngine.UIElements.IVisualElementScheduledItem Until(System.Func<System.Boolean> @stopCondition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stopCondition};
            var ___result = RUntil_Func_d_Boolean_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.IVisualElementScheduledItem)___result;
        }


        public virtual UnityEngine.UIElements.IVisualElementScheduledItem ForDuration(System.Int64 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@durationMs};
            var ___result = RForDuration_Int64.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.IVisualElementScheduledItem)___result;
        }


    }
}
