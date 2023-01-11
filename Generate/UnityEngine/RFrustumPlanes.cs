using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.FrustumPlanes
	/// </summary>
    public partial class RFrustumPlanes : RMember //
    {

		/// <summary>
		/// System.Single left
		/// </summary>
		protected RSystem.RSingle r_left;
		public virtual RSystem.RSingle Rleft
		{
			get
			{
				if(r_left == null)
				{
					r_left = new(this, "left");
					r_left.SetBelong(this.instance);
				}
				return r_left;
			}
		}

		/// <summary>
		/// System.Single right
		/// </summary>
		protected RSystem.RSingle r_right;
		public virtual RSystem.RSingle Rright
		{
			get
			{
				if(r_right == null)
				{
					r_right = new(this, "right");
					r_right.SetBelong(this.instance);
				}
				return r_right;
			}
		}

		/// <summary>
		/// System.Single bottom
		/// </summary>
		protected RSystem.RSingle r_bottom;
		public virtual RSystem.RSingle Rbottom
		{
			get
			{
				if(r_bottom == null)
				{
					r_bottom = new(this, "bottom");
					r_bottom.SetBelong(this.instance);
				}
				return r_bottom;
			}
		}

		/// <summary>
		/// System.Single top
		/// </summary>
		protected RSystem.RSingle r_top;
		public virtual RSystem.RSingle Rtop
		{
			get
			{
				if(r_top == null)
				{
					r_top = new(this, "top");
					r_top.SetBelong(this.instance);
				}
				return r_top;
			}
		}

		/// <summary>
		/// System.Single zNear
		/// </summary>
		protected RSystem.RSingle r_zNear;
		public virtual RSystem.RSingle RzNear
		{
			get
			{
				if(r_zNear == null)
				{
					r_zNear = new(this, "zNear");
					r_zNear.SetBelong(this.instance);
				}
				return r_zNear;
			}
		}

		/// <summary>
		/// System.Single zFar
		/// </summary>
		protected RSystem.RSingle r_zFar;
		public virtual RSystem.RSingle RzFar
		{
			get
			{
				if(r_zFar == null)
				{
					r_zFar = new(this, "zFar");
					r_zFar.SetBelong(this.instance);
				}
				return r_zFar;
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


        public RFrustumPlanes() : base("UnityEngine.FrustumPlanes")
        {
        }

        public RFrustumPlanes(System.Object instance) : base("UnityEngine.FrustumPlanes")
		{
            SetInstance(instance);
		}

        public RFrustumPlanes(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFrustumPlanes(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
