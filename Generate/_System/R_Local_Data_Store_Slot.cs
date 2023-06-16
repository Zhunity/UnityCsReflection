
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.LocalDataStoreSlot
	/// </summary>
    public partial class RLocalDataStoreSlot : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.LocalDataStoreSlot);
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


		/// <summary>
		/// System.LocalDataStoreMgr m_mgr
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RLocalDataStoreMgr r_Fm_mgr;
		public virtual Hvak.Editor.Refleaction.RSystem.RLocalDataStoreMgr RFm_mgr
		{
			get
			{
				if(r_Fm_mgr == null)
				{
					r_Fm_mgr = new(this, "m_mgr");
				}
				return r_Fm_mgr;
			}
		}

		/// <summary>
		/// System.Int32 m_slot
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_slot;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_slot
		{
			get
			{
				if(r_Fm_slot == null)
				{
					r_Fm_slot = new(this, "m_slot");
				}
				return r_Fm_slot;
			}
		}

		/// <summary>
		/// System.Int64 m_cookie
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Fm_cookie;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFm_cookie
		{
			get
			{
				if(r_Fm_cookie == null)
				{
					r_Fm_cookie = new(this, "m_cookie");
				}
				return r_Fm_cookie;
			}
		}

		/// <summary>
		/// System.LocalDataStoreMgr Manager
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RLocalDataStoreMgr r_PManager;
		public virtual Hvak.Editor.Refleaction.RSystem.RLocalDataStoreMgr RPManager
		{
			get
			{
				if(r_PManager == null)
				{
					r_PManager = new(this, "Manager", -1);
				}
				return r_PManager;
			}
		}

		/// <summary>
		/// Int32 Slot
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PSlot;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPSlot
		{
			get
			{
				if(r_PSlot == null)
				{
					r_PSlot = new(this, "Slot", -1);
				}
				return r_PSlot;
			}
		}

		/// <summary>
		/// Int64 Cookie
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PCookie;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPCookie
		{
			get
			{
				if(r_PCookie == null)
				{
					r_PCookie = new(this, "Cookie", -1);
				}
				return r_PCookie;
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


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
