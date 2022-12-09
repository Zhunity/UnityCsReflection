using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
    public partial class RFrustumPlanes : RMember
    {

		/// <summary>
		/// System.Single left
		/// </summary>
		protected RField r_left;
		public virtual RField left
		{
			get
			{
				if(r_left == null)
				{
					r_left = new RField(this, "left");
					r_left.SetBelong(this.instance);
				}
				return r_left;
			}
		}

		/// <summary>
		/// System.Single right
		/// </summary>
		protected RField r_right;
		public virtual RField right
		{
			get
			{
				if(r_right == null)
				{
					r_right = new RField(this, "right");
					r_right.SetBelong(this.instance);
				}
				return r_right;
			}
		}

		/// <summary>
		/// System.Single bottom
		/// </summary>
		protected RField r_bottom;
		public virtual RField bottom
		{
			get
			{
				if(r_bottom == null)
				{
					r_bottom = new RField(this, "bottom");
					r_bottom.SetBelong(this.instance);
				}
				return r_bottom;
			}
		}

		/// <summary>
		/// System.Single top
		/// </summary>
		protected RField r_top;
		public virtual RField top
		{
			get
			{
				if(r_top == null)
				{
					r_top = new RField(this, "top");
					r_top.SetBelong(this.instance);
				}
				return r_top;
			}
		}

		/// <summary>
		/// System.Single zNear
		/// </summary>
		protected RField r_zNear;
		public virtual RField zNear
		{
			get
			{
				if(r_zNear == null)
				{
					r_zNear = new RField(this, "zNear");
					r_zNear.SetBelong(this.instance);
				}
				return r_zNear;
			}
		}

		/// <summary>
		/// System.Single zFar
		/// </summary>
		protected RField r_zFar;
		public virtual RField zFar
		{
			get
			{
				if(r_zFar == null)
				{
					r_zFar = new RField(this, "zFar");
					r_zFar.SetBelong(this.instance);
				}
				return r_zFar;
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
					r_REquals_Object = new RMethod(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
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
					r_RGetHashCode = new RMethod(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
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
					r_RToString = new RMethod(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
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
					r_RFinalize = new RMethod(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
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
					r_RGetType = new RMethod(this, "GetType", 0);
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
					r_RMemberwiseClone = new RMethod(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
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

        public virtual System.Boolean Equals(System.Object  @obj)
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
