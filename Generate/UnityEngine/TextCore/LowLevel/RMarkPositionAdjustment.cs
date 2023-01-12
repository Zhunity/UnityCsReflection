using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel
{
	/// <summary>
	/// UnityEngine.TextCore.LowLevel.MarkPositionAdjustment
	/// </summary>
    public partial class RMarkPositionAdjustment : RMember //
    {

		/// <summary>
		/// System.Single m_XPositionAdjustment
		/// </summary>
		protected RSystem.RSingle r_Fm_XPositionAdjustment;
		public virtual RSystem.RSingle RFm_XPositionAdjustment
		{
			get
			{
				if(r_Fm_XPositionAdjustment == null)
				{
					r_Fm_XPositionAdjustment = new(this, "m_XPositionAdjustment");
					r_Fm_XPositionAdjustment.SetBelong(this.instance);
				}
				return r_Fm_XPositionAdjustment;
			}
		}

		/// <summary>
		/// System.Single m_YPositionAdjustment
		/// </summary>
		protected RSystem.RSingle r_Fm_YPositionAdjustment;
		public virtual RSystem.RSingle RFm_YPositionAdjustment
		{
			get
			{
				if(r_Fm_YPositionAdjustment == null)
				{
					r_Fm_YPositionAdjustment = new(this, "m_YPositionAdjustment");
					r_Fm_YPositionAdjustment.SetBelong(this.instance);
				}
				return r_Fm_YPositionAdjustment;
			}
		}

		/// <summary>
		/// Single xPositionAdjustment
		/// </summary>
		protected RSystem.RSingle r_PxPositionAdjustment;
		public virtual RSystem.RSingle RPxPositionAdjustment
		{
			get
			{
				if(r_PxPositionAdjustment == null)
				{
					r_PxPositionAdjustment = new(this, "xPositionAdjustment", -1);
					r_PxPositionAdjustment.SetBelong(this.instance);
				}
				return r_PxPositionAdjustment;
			}
		}

		/// <summary>
		/// Single yPositionAdjustment
		/// </summary>
		protected RSystem.RSingle r_PyPositionAdjustment;
		public virtual RSystem.RSingle RPyPositionAdjustment
		{
			get
			{
				if(r_PyPositionAdjustment == null)
				{
					r_PyPositionAdjustment = new(this, "yPositionAdjustment", -1);
					r_PyPositionAdjustment.SetBelong(this.instance);
				}
				return r_PyPositionAdjustment;
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


        public RMarkPositionAdjustment() : base("UnityEngine.TextCore.LowLevel.MarkPositionAdjustment")
        {
        }

        public RMarkPositionAdjustment(System.Object instance) : base("UnityEngine.TextCore.LowLevel.MarkPositionAdjustment")
		{
            SetInstance(instance);
		}

        public RMarkPositionAdjustment(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMarkPositionAdjustment(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
