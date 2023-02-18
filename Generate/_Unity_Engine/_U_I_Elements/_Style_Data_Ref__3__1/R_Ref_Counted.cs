
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{public partial class RStyleDataRef<T>
{
	
	/// <summary>
	/// UnityEngine.UIElements.StyleDataRef`1+RefCounted
	/// </summary>
    public partial class RRefCounted : RMember //
    {

		/// <summary>
		/// System.UInt32 m_NextId
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fm_NextId;
		public static Hvak.Editor.Refleaction.RSystem.RUInt32 RFm_NextId
		{
			get
			{
				if(r_Fm_NextId == null)
				{
					r_Fm_NextId = new( ReflectionUtils.GetType("UnityEngine.UIElements.StyleDataRef`1+RefCounted"), "m_NextId");
					r_Fm_NextId.SetBelong(null);
				}
				return r_Fm_NextId;
			}
		}

		/// <summary>
		/// System.Int32 m_RefCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_RefCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_RefCount
		{
			get
			{
				if(r_Fm_RefCount == null)
				{
					r_Fm_RefCount = new(this, "m_RefCount");
					r_Fm_RefCount.SetBelong(this.GetValue());
				}
				return r_Fm_RefCount;
			}
		}

		/// <summary>
		/// System.UInt32 m_Id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fm_Id;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFm_Id
		{
			get
			{
				if(r_Fm_Id == null)
				{
					r_Fm_Id = new(this, "m_Id");
					r_Fm_Id.SetBelong(this.GetValue());
				}
				return r_Fm_Id;
			}
		}

		/// <summary>
		/// T value
		/// </summary>
		protected Hvak.Editor.Refleaction.RField r_Fvalue;
		public virtual Hvak.Editor.Refleaction.RField RFvalue
		{
			get
			{
				if(r_Fvalue == null)
				{
					r_Fvalue = new(this, "value");
					r_Fvalue.SetBelong(this.GetValue());
				}
				return r_Fvalue;
			}
		}

		/// <summary>
		/// Int32 refCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PrefCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPrefCount
		{
			get
			{
				if(r_PrefCount == null)
				{
					r_PrefCount = new(this, "refCount", -1);
					r_PrefCount.SetBelong(this.GetValue());
				}
				return r_PrefCount;
			}
		}

		/// <summary>
		/// UInt32 id
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Pid;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RPid
		{
			get
			{
				if(r_Pid == null)
				{
					r_Pid = new(this, "id", -1);
					r_Pid.SetBelong(this.GetValue());
				}
				return r_Pid;
			}
		}

		/// <summary>
		/// Void Acquire()
		/// </summary>
		protected RMethod r_MAcquire;
		public virtual RMethod RMAcquire
		{
			get
			{
				if(r_MAcquire == null)
				{
					r_MAcquire = new(this, "Acquire", 0);
					r_MAcquire.SetBelong(this.GetValue());
				}
				return r_MAcquire;
			}
		}

		/// <summary>
		/// Void Release()
		/// </summary>
		protected RMethod r_MRelease;
		public virtual RMethod RMRelease
		{
			get
			{
				if(r_MRelease == null)
				{
					r_MRelease = new(this, "Release", 0);
					r_MRelease.SetBelong(this.GetValue());
				}
				return r_MRelease;
			}
		}

		/// <summary>
		/// RefCounted Copy()
		/// </summary>
		protected RMethod r_MCopy;
		public virtual RMethod RMCopy
		{
			get
			{
				if(r_MCopy == null)
				{
					r_MCopy = new(this, "Copy", 0);
					r_MCopy.SetBelong(this.GetValue());
				}
				return r_MCopy;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
			}
		}


        public RRefCounted() : base("UnityEngine.UIElements.StyleDataRef`1+RefCounted")
        {
        }

        public RRefCounted(System.Object instance) : base("UnityEngine.UIElements.StyleDataRef`1+RefCounted")
		{
            SetInstance(instance);
		}

        public RRefCounted(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRefCounted(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Acquire()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAcquire.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRelease.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RType>.RRefCounted Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCopy.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleDataRef<Hvak.Editor.Refleaction.RType>.RRefCounted(___result);
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
}