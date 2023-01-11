using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RTextCore.RLowLevel
{
	/// <summary>
	/// UnityEngine.TextCore.LowLevel.GlyphAnchorPoint
	/// </summary>
    public partial class RGlyphAnchorPoint : RMember //
    {

		/// <summary>
		/// System.Single m_XCoordinate
		/// </summary>
		protected RSystem.RSingle r_m_XCoordinate;
		public virtual RSystem.RSingle Rm_XCoordinate
		{
			get
			{
				if(r_m_XCoordinate == null)
				{
					r_m_XCoordinate = new(this, "m_XCoordinate");
					r_m_XCoordinate.SetBelong(this.instance);
				}
				return r_m_XCoordinate;
			}
		}

		/// <summary>
		/// System.Single m_YCoordinate
		/// </summary>
		protected RSystem.RSingle r_m_YCoordinate;
		public virtual RSystem.RSingle Rm_YCoordinate
		{
			get
			{
				if(r_m_YCoordinate == null)
				{
					r_m_YCoordinate = new(this, "m_YCoordinate");
					r_m_YCoordinate.SetBelong(this.instance);
				}
				return r_m_YCoordinate;
			}
		}

		/// <summary>
		/// Single xCoordinate
		/// </summary>
		protected RSystem.RSingle r_xCoordinate;
		public virtual RSystem.RSingle RxCoordinate
		{
			get
			{
				if(r_xCoordinate == null)
				{
					r_xCoordinate = new(this, "xCoordinate", -1);
					r_xCoordinate.SetBelong(this.instance);
				}
				return r_xCoordinate;
			}
		}

		/// <summary>
		/// Single yCoordinate
		/// </summary>
		protected RSystem.RSingle r_yCoordinate;
		public virtual RSystem.RSingle RyCoordinate
		{
			get
			{
				if(r_yCoordinate == null)
				{
					r_yCoordinate = new(this, "yCoordinate", -1);
					r_yCoordinate.SetBelong(this.instance);
				}
				return r_yCoordinate;
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


        public RGlyphAnchorPoint() : base("UnityEngine.TextCore.LowLevel.GlyphAnchorPoint")
        {
        }

        public RGlyphAnchorPoint(System.Object instance) : base("UnityEngine.TextCore.LowLevel.GlyphAnchorPoint")
		{
            SetInstance(instance);
		}

        public RGlyphAnchorPoint(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGlyphAnchorPoint(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
