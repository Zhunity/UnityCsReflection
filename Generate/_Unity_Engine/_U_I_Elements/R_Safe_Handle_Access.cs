
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.SafeHandleAccess
	/// </summary>
    public partial class RSafeHandleAccess : RMember //
    {

		/// <summary>
		/// System.IntPtr m_Handle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fm_Handle;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFm_Handle
		{
			get
			{
				if(r_Fm_Handle == null)
				{
					r_Fm_Handle = new(this, "m_Handle");
					r_Fm_Handle.SetBelong(this.instance);
				}
				return r_Fm_Handle;
			}
		}

		/// <summary>
		/// Boolean IsNull()
		/// </summary>
		protected RMethod r_MIsNull;
		public virtual RMethod RMIsNull
		{
			get
			{
				if(r_MIsNull == null)
				{
					r_MIsNull = new(this, "IsNull", 0);
					r_MIsNull.SetBelong(this.instance);
				}
				return r_MIsNull;
			}
		}

		/// <summary>
		/// IntPtr op_Implicit(UnityEngine.UIElements.SafeHandleAccess)
		/// </summary>
		protected static RMethod r_Mop_Implicit_SafeHandleAccess;
		public static RMethod RMop_Implicit_SafeHandleAccess
		{
			get
			{
				if(r_Mop_Implicit_SafeHandleAccess == null)
				{
					r_Mop_Implicit_SafeHandleAccess = new( ReflectionUtils.GetType("UnityEngine.UIElements.SafeHandleAccess"), "op_Implicit", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.SafeHandleAccess"));
					r_Mop_Implicit_SafeHandleAccess.SetBelong(null);
				}
				return r_Mop_Implicit_SafeHandleAccess;
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


        public RSafeHandleAccess() : base("UnityEngine.UIElements.SafeHandleAccess")
        {
        }

        public RSafeHandleAccess(System.Object instance) : base("UnityEngine.UIElements.SafeHandleAccess")
		{
            SetInstance(instance);
		}

        public RSafeHandleAccess(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSafeHandleAccess(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean IsNull()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsNull.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.IntPtr op_Implicit(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RSafeHandleAccess @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a.Value};
            var ___result = RMop_Implicit_SafeHandleAccess.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
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
