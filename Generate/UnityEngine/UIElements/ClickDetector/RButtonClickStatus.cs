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
		protected RUnityEngine.RUIElements.RVisualElement r_m_Target;
		public virtual RUnityEngine.RUIElements.RVisualElement Rm_Target
		{
			get
			{
				if(r_m_Target == null)
				{
					r_m_Target = new(this, "m_Target");
					r_m_Target.SetBelong(this.instance);
				}
				return r_m_Target;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_PointerDownPosition
		/// </summary>
		protected RUnityEngine.RVector3 r_m_PointerDownPosition;
		public virtual RUnityEngine.RVector3 Rm_PointerDownPosition
		{
			get
			{
				if(r_m_PointerDownPosition == null)
				{
					r_m_PointerDownPosition = new(this, "m_PointerDownPosition");
					r_m_PointerDownPosition.SetBelong(this.instance);
				}
				return r_m_PointerDownPosition;
			}
		}

		/// <summary>
		/// System.Int64 m_LastPointerDownTime
		/// </summary>
		protected RField r_m_LastPointerDownTime;
		public virtual RField Rm_LastPointerDownTime
		{
			get
			{
				if(r_m_LastPointerDownTime == null)
				{
					r_m_LastPointerDownTime = new(this, "m_LastPointerDownTime");
					r_m_LastPointerDownTime.SetBelong(this.instance);
				}
				return r_m_LastPointerDownTime;
			}
		}

		/// <summary>
		/// System.Int32 m_ClickCount
		/// </summary>
		protected RField r_m_ClickCount;
		public virtual RField Rm_ClickCount
		{
			get
			{
				if(r_m_ClickCount == null)
				{
					r_m_ClickCount = new(this, "m_ClickCount");
					r_m_ClickCount.SetBelong(this.instance);
				}
				return r_m_ClickCount;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
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
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
}