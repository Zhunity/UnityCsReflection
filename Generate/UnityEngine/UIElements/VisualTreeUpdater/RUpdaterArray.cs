using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class RVisualTreeUpdater
{
	
	/// <summary>
	/// UnityEngine.UIElements.VisualTreeUpdater+UpdaterArray
	/// </summary>
    public partial class RUpdaterArray : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.IVisualTreeUpdater[] m_VisualTreeUpdaters
		/// </summary>
		protected RFieldArray<RUnityEngine.RUIElements.RIVisualTreeUpdater> r_m_VisualTreeUpdaters;
		public virtual RFieldArray<RUnityEngine.RUIElements.RIVisualTreeUpdater> Rm_VisualTreeUpdaters
		{
			get
			{
				if(r_m_VisualTreeUpdaters == null)
				{
					r_m_VisualTreeUpdaters = new(this, "m_VisualTreeUpdaters");
					r_m_VisualTreeUpdaters.SetBelong(this.instance);
				}
				return r_m_VisualTreeUpdaters;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualTreeUpdater Item [UnityEngine.UIElements.VisualTreeUpdatePhase]
		/// </summary>
		protected RUnityEngine.RUIElements.RIVisualTreeUpdater r_Item_VisualTreeUpdatePhase;
		public virtual RUnityEngine.RUIElements.RIVisualTreeUpdater RItem_VisualTreeUpdatePhase
		{
			get
			{
				if(r_Item_VisualTreeUpdatePhase == null)
				{
					r_Item_VisualTreeUpdatePhase = new(this, "Item", -1,  ReleactionUtils.GetType("UnityEngine.UIElements.VisualTreeUpdatePhase"));
					r_Item_VisualTreeUpdatePhase.SetBelong(this.instance);
				}
				return r_Item_VisualTreeUpdatePhase;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualTreeUpdater Item [Int32]
		/// </summary>
		protected RUnityEngine.RUIElements.RIVisualTreeUpdater r_Item_Int32;
		public virtual RUnityEngine.RUIElements.RIVisualTreeUpdater RItem_Int32
		{
			get
			{
				if(r_Item_Int32 == null)
				{
					r_Item_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_Item_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32;
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


        public RUpdaterArray() : base("UnityEngine.UIElements.VisualTreeUpdater+UpdaterArray")
        {
        }

        public RUpdaterArray(System.Object instance) : base("UnityEngine.UIElements.VisualTreeUpdater+UpdaterArray")
		{
            SetInstance(instance);
		}

        public RUpdaterArray(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUpdaterArray(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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