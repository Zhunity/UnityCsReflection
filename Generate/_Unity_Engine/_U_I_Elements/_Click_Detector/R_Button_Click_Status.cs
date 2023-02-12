
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class RClickDetector
{
	
	/// <summary>
	/// UnityEngine.UIElements.ClickDetector+ButtonClickStatus
	/// </summary>
    public partial class RButtonClickStatus : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_Target
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_Target;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_Target
		{
			get
			{
				if(r_Fm_Target == null)
				{
					r_Fm_Target = new(this, "m_Target");
					r_Fm_Target.SetBelong(this.instance);
				}
				return r_Fm_Target;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_PointerDownPosition
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RVector3 r_Fm_PointerDownPosition;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RVector3 RFm_PointerDownPosition
		{
			get
			{
				if(r_Fm_PointerDownPosition == null)
				{
					r_Fm_PointerDownPosition = new(this, "m_PointerDownPosition");
					r_Fm_PointerDownPosition.SetBelong(this.instance);
				}
				return r_Fm_PointerDownPosition;
			}
		}

		/// <summary>
		/// System.Int64 m_LastPointerDownTime
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_Fm_LastPointerDownTime;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RFm_LastPointerDownTime
		{
			get
			{
				if(r_Fm_LastPointerDownTime == null)
				{
					r_Fm_LastPointerDownTime = new(this, "m_LastPointerDownTime");
					r_Fm_LastPointerDownTime.SetBelong(this.instance);
				}
				return r_Fm_LastPointerDownTime;
			}
		}

		/// <summary>
		/// System.Int32 m_ClickCount
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fm_ClickCount;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFm_ClickCount
		{
			get
			{
				if(r_Fm_ClickCount == null)
				{
					r_Fm_ClickCount = new(this, "m_ClickCount");
					r_Fm_ClickCount.SetBelong(this.instance);
				}
				return r_Fm_ClickCount;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
					r_MReset.SetBelong(this.instance);
				}
				return r_MReset;
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
					r_MEquals_Object.SetBelong(this.instance);
				}
				return r_MEquals_Object;
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
					r_MFinalize.SetBelong(this.instance);
				}
				return r_MFinalize;
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
					r_MGetHashCode.SetBelong(this.instance);
				}
				return r_MGetHashCode;
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
			}
		}


        public RButtonClickStatus() : base("UnityEngine.UIElements.ClickDetector+ButtonClickStatus")
        {
        }

        public RButtonClickStatus(System.Object instance) : base("UnityEngine.UIElements.ClickDetector+ButtonClickStatus")
		{
            SetInstance(instance);
		}

        public RButtonClickStatus(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RButtonClickStatus(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
}