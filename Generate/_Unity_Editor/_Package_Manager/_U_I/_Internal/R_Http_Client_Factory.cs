
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.HttpClientFactory
	/// </summary>
    public partial class RHttpClientFactory : RMember //
    {

		/// <summary>
		/// UnityEditor.IAsyncHTTPClient GetASyncHTTPClient(System.String)
		/// </summary>
		protected RMethod r_MGetASyncHTTPClient_String;
		public virtual RMethod RMGetASyncHTTPClient_String
		{
			get
			{
				if(r_MGetASyncHTTPClient_String == null)
				{
					r_MGetASyncHTTPClient_String = new(this, "GetASyncHTTPClient", 0, typeof(System.String));
					r_MGetASyncHTTPClient_String.SetBelong(this.instance);
				}
				return r_MGetASyncHTTPClient_String;
			}
		}

		/// <summary>
		/// UnityEditor.IAsyncHTTPClient PostASyncHTTPClient(System.String, System.String)
		/// </summary>
		protected RMethod r_MPostASyncHTTPClient_String_String;
		public virtual RMethod RMPostASyncHTTPClient_String_String
		{
			get
			{
				if(r_MPostASyncHTTPClient_String_String == null)
				{
					r_MPostASyncHTTPClient_String_String = new(this, "PostASyncHTTPClient", 0, typeof(System.String), typeof(System.String));
					r_MPostASyncHTTPClient_String_String.SetBelong(this.instance);
				}
				return r_MPostASyncHTTPClient_String_String;
			}
		}

		/// <summary>
		/// Void AbortByTag(System.String)
		/// </summary>
		protected RMethod r_MAbortByTag_String;
		public virtual RMethod RMAbortByTag_String
		{
			get
			{
				if(r_MAbortByTag_String == null)
				{
					r_MAbortByTag_String = new(this, "AbortByTag", 0, typeof(System.String));
					r_MAbortByTag_String.SetBelong(this.instance);
				}
				return r_MAbortByTag_String;
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


        public RHttpClientFactory() : base("UnityEditor.PackageManager.UI.Internal.HttpClientFactory")
        {
        }

        public RHttpClientFactory(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.HttpClientFactory")
		{
            SetInstance(instance);
		}

        public RHttpClientFactory(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RHttpClientFactory(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual Hvak.Editor.Refleaction.RUnityEditor.RIAsyncHTTPClient GetASyncHTTPClient(System.String @url)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url};
            var ___result = RMGetASyncHTTPClient_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RIAsyncHTTPClient(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEditor.RIAsyncHTTPClient PostASyncHTTPClient(System.String @url, System.String @postData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url, @postData};
            var ___result = RMPostASyncHTTPClient_String_String.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEditor.RIAsyncHTTPClient(___result);
        }


        public virtual void AbortByTag(System.String @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RMAbortByTag_String.Invoke(___genericsType, ___parameters);

            
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
