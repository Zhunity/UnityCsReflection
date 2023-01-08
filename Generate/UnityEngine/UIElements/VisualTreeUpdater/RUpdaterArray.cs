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
					r_Item_VisualTreeUpdatePhase = new(this, "Item", -1,  ReflectionUtils.GetType("UnityEngine.UIElements.VisualTreeUpdatePhase"));
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
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
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

        public virtual System.Boolean Equals(System.Object @obj)
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