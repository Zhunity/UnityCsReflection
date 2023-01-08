using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.LocalDataStoreSlot
	/// </summary>
    public partial class RLocalDataStoreSlot : RMember //
    {

		/// <summary>
		/// System.LocalDataStoreMgr m_mgr
		/// </summary>
		protected RSystem.RLocalDataStoreMgr r_m_mgr;
		public virtual RSystem.RLocalDataStoreMgr Rm_mgr
		{
			get
			{
				if(r_m_mgr == null)
				{
					r_m_mgr = new(this, "m_mgr");
					r_m_mgr.SetBelong(this.instance);
				}
				return r_m_mgr;
			}
		}

		/// <summary>
		/// System.Int32 m_slot
		/// </summary>
		protected RField r_m_slot;
		public virtual RField Rm_slot
		{
			get
			{
				if(r_m_slot == null)
				{
					r_m_slot = new(this, "m_slot");
					r_m_slot.SetBelong(this.instance);
				}
				return r_m_slot;
			}
		}

		/// <summary>
		/// System.Int64 m_cookie
		/// </summary>
		protected RField r_m_cookie;
		public virtual RField Rm_cookie
		{
			get
			{
				if(r_m_cookie == null)
				{
					r_m_cookie = new(this, "m_cookie");
					r_m_cookie.SetBelong(this.instance);
				}
				return r_m_cookie;
			}
		}

		/// <summary>
		/// System.LocalDataStoreMgr Manager
		/// </summary>
		protected RSystem.RLocalDataStoreMgr r_Manager;
		public virtual RSystem.RLocalDataStoreMgr RManager
		{
			get
			{
				if(r_Manager == null)
				{
					r_Manager = new(this, "Manager", -1);
					r_Manager.SetBelong(this.instance);
				}
				return r_Manager;
			}
		}

		/// <summary>
		/// Int32 Slot
		/// </summary>
		protected RProperty r_Slot;
		public virtual RProperty RSlot
		{
			get
			{
				if(r_Slot == null)
				{
					r_Slot = new(this, "Slot", -1);
					r_Slot.SetBelong(this.instance);
				}
				return r_Slot;
			}
		}

		/// <summary>
		/// Int64 Cookie
		/// </summary>
		protected RProperty r_Cookie;
		public virtual RProperty RCookie
		{
			get
			{
				if(r_Cookie == null)
				{
					r_Cookie = new(this, "Cookie", -1);
					r_Cookie.SetBelong(this.instance);
				}
				return r_Cookie;
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


        public RLocalDataStoreSlot() : base("System.LocalDataStoreSlot")
        {
        }

        public RLocalDataStoreSlot(System.Object instance) : base("System.LocalDataStoreSlot")
		{
            SetInstance(instance);
		}

        public RLocalDataStoreSlot(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLocalDataStoreSlot(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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
