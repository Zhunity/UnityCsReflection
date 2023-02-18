
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RRemoting.RMessaging
{
	/// <summary>
	/// System.Runtime.Remoting.Messaging.CallContextSecurityData
	/// </summary>
    public partial class RCallContextSecurityData : RMember //
    {

		/// <summary>
		/// System.Security.Principal.IPrincipal _principal
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIPrincipal r_F_principal;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIPrincipal RF_principal
		{
			get
			{
				if(r_F_principal == null)
				{
					r_F_principal = new(this, "_principal");
				}
				return r_F_principal;
			}
		}

		/// <summary>
		/// System.Security.Principal.IPrincipal Principal
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIPrincipal r_PPrincipal;
		public virtual Hvak.Editor.Refleaction.RSystem.RSecurity.RPrincipal.RIPrincipal RPPrincipal
		{
			get
			{
				if(r_PPrincipal == null)
				{
					r_PPrincipal = new(this, "Principal", -1);
				}
				return r_PPrincipal;
			}
		}

		/// <summary>
		/// Boolean HasInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PHasInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPHasInfo
		{
			get
			{
				if(r_PHasInfo == null)
				{
					r_PHasInfo = new(this, "HasInfo", -1);
				}
				return r_PHasInfo;
			}
		}

		/// <summary>
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_MClone;
		public virtual RMethod RMClone
		{
			get
			{
				if(r_MClone == null)
				{
					r_MClone = new(this, "Clone", 0);
				}
				return r_MClone;
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


        public RCallContextSecurityData() : base("System.Runtime.Remoting.Messaging.CallContextSecurityData")
        {
        }

        public RCallContextSecurityData(System.Object instance) : base("System.Runtime.Remoting.Messaging.CallContextSecurityData")
		{
            SetInstance(instance);
		}

        public RCallContextSecurityData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCallContextSecurityData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
