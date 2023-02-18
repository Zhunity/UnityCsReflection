
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager
{
	/// <summary>
	/// UnityEditor.PackageManager.Error
	/// </summary>
    public partial class RError : RMember //
    {

		/// <summary>
		/// UnityEditor.PackageManager.NativeErrorCode m_ErrorCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RNativeErrorCode r_Fm_ErrorCode;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RNativeErrorCode RFm_ErrorCode
		{
			get
			{
				if(r_Fm_ErrorCode == null)
				{
					r_Fm_ErrorCode = new(this, "m_ErrorCode");
					r_Fm_ErrorCode.SetBelong(this.GetValue());
				}
				return r_Fm_ErrorCode;
			}
		}

		/// <summary>
		/// System.String m_Message
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Message;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Message
		{
			get
			{
				if(r_Fm_Message == null)
				{
					r_Fm_Message = new(this, "m_Message");
					r_Fm_Message.SetBelong(this.GetValue());
				}
				return r_Fm_Message;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.ErrorCode errorCode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RErrorCode r_PerrorCode;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RErrorCode RPerrorCode
		{
			get
			{
				if(r_PerrorCode == null)
				{
					r_PerrorCode = new(this, "errorCode", -1);
					r_PerrorCode.SetBelong(this.GetValue());
				}
				return r_PerrorCode;
			}
		}

		/// <summary>
		/// System.String message
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pmessage;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPmessage
		{
			get
			{
				if(r_Pmessage == null)
				{
					r_Pmessage = new(this, "message", -1);
					r_Pmessage.SetBelong(this.GetValue());
				}
				return r_Pmessage;
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


        public RError() : base("UnityEditor.PackageManager.Error")
        {
        }

        public RError(System.Object instance) : base("UnityEditor.PackageManager.Error")
		{
            SetInstance(instance);
		}

        public RError(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RError(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
