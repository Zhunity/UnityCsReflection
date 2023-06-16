
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{public partial class RAssetStoreOAuth
{
	
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+TokenInfo
	/// </summary>
    public partial class RTokenInfo : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+TokenInfo");
            }
        }

        public RTokenInfo() : base("UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+TokenInfo")
        {
        }

        public RTokenInfo(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.AssetStoreOAuth+TokenInfo")
		{
            SetInstance(instance);
		}

        public RTokenInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTokenInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.String sub
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fsub;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFsub
		{
			get
			{
				if(r_Fsub == null)
				{
					r_Fsub = new(this, "sub");
				}
				return r_Fsub;
			}
		}

		/// <summary>
		/// System.String scopes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fscopes;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFscopes
		{
			get
			{
				if(r_Fscopes == null)
				{
					r_Fscopes = new(this, "scopes");
				}
				return r_Fscopes;
			}
		}

		/// <summary>
		/// System.String clientId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FclientId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFclientId
		{
			get
			{
				if(r_FclientId == null)
				{
					r_FclientId = new(this, "clientId");
				}
				return r_FclientId;
			}
		}

		/// <summary>
		/// System.String ipAddress
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FipAddress;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFipAddress
		{
			get
			{
				if(r_FipAddress == null)
				{
					r_FipAddress = new(this, "ipAddress");
				}
				return r_FipAddress;
			}
		}

		/// <summary>
		/// System.String accessToken
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_FaccessToken;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFaccessToken
		{
			get
			{
				if(r_FaccessToken == null)
				{
					r_FaccessToken = new(this, "accessToken");
				}
				return r_FaccessToken;
			}
		}

		/// <summary>
		/// System.String expiresIn
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PexpiresIn;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPexpiresIn
		{
			get
			{
				if(r_PexpiresIn == null)
				{
					r_PexpiresIn = new(this, "expiresIn", -1);
				}
				return r_PexpiresIn;
			}
		}

		/// <summary>
		/// Boolean IsValid(Int64)
		/// </summary>
		protected RMethod r_MIsValid_Int64;
		public virtual RMethod RMIsValid_Int64
		{
			get
			{
				if(r_MIsValid_Int64 == null)
				{
					r_MIsValid_Int64 = new(this, "IsValid", 0, typeof(System.Int64));
				}
				return r_MIsValid_Int64;
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


        public virtual System.Boolean IsValid(System.Int64 @bufferTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bufferTime};
            var ___result = RMIsValid_Int64.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
}