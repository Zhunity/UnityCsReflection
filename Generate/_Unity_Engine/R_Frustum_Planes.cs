
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.FrustumPlanes
	/// </summary>
    public partial class RFrustumPlanes : RMember //
    {

		/// <summary>
		/// System.Single left
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fleft;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFleft
		{
			get
			{
				if(r_Fleft == null)
				{
					r_Fleft = new(this, "left");
				}
				return r_Fleft;
			}
		}

		/// <summary>
		/// System.Single right
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fright;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFright
		{
			get
			{
				if(r_Fright == null)
				{
					r_Fright = new(this, "right");
				}
				return r_Fright;
			}
		}

		/// <summary>
		/// System.Single bottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fbottom;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFbottom
		{
			get
			{
				if(r_Fbottom == null)
				{
					r_Fbottom = new(this, "bottom");
				}
				return r_Fbottom;
			}
		}

		/// <summary>
		/// System.Single top
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Ftop;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFtop
		{
			get
			{
				if(r_Ftop == null)
				{
					r_Ftop = new(this, "top");
				}
				return r_Ftop;
			}
		}

		/// <summary>
		/// System.Single zNear
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FzNear;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFzNear
		{
			get
			{
				if(r_FzNear == null)
				{
					r_FzNear = new(this, "zNear");
				}
				return r_FzNear;
			}
		}

		/// <summary>
		/// System.Single zFar
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FzFar;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFzFar
		{
			get
			{
				if(r_FzFar == null)
				{
					r_FzFar = new(this, "zFar");
				}
				return r_FzFar;
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
				}
				return r_MMemberwiseClone;
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
