
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{public partial class RAsyncHTTPClient
{
	
	/// <summary>
	/// UnityEditor.AsyncHTTPClient+State
	/// </summary>
    public partial class RState : RMember //
    {

		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// UnityEditor.AsyncHTTPClient+State INIT
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RState r_FINIT;
		public static Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RState RFINIT
		{
			get
			{
				if(r_FINIT == null)
				{
					r_FINIT = new( ReflectionUtils.GetType("UnityEditor.AsyncHTTPClient+State"), "INIT");
				}
				return r_FINIT;
			}
		}

		/// <summary>
		/// UnityEditor.AsyncHTTPClient+State CONNECTING
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RState r_FCONNECTING;
		public static Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RState RFCONNECTING
		{
			get
			{
				if(r_FCONNECTING == null)
				{
					r_FCONNECTING = new( ReflectionUtils.GetType("UnityEditor.AsyncHTTPClient+State"), "CONNECTING");
				}
				return r_FCONNECTING;
			}
		}

		/// <summary>
		/// UnityEditor.AsyncHTTPClient+State CONNECTED
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RState r_FCONNECTED;
		public static Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RState RFCONNECTED
		{
			get
			{
				if(r_FCONNECTED == null)
				{
					r_FCONNECTED = new( ReflectionUtils.GetType("UnityEditor.AsyncHTTPClient+State"), "CONNECTED");
				}
				return r_FCONNECTED;
			}
		}

		/// <summary>
		/// UnityEditor.AsyncHTTPClient+State UPLOADING
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RState r_FUPLOADING;
		public static Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RState RFUPLOADING
		{
			get
			{
				if(r_FUPLOADING == null)
				{
					r_FUPLOADING = new( ReflectionUtils.GetType("UnityEditor.AsyncHTTPClient+State"), "UPLOADING");
				}
				return r_FUPLOADING;
			}
		}

		/// <summary>
		/// UnityEditor.AsyncHTTPClient+State DOWNLOADING
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RState r_FDOWNLOADING;
		public static Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RState RFDOWNLOADING
		{
			get
			{
				if(r_FDOWNLOADING == null)
				{
					r_FDOWNLOADING = new( ReflectionUtils.GetType("UnityEditor.AsyncHTTPClient+State"), "DOWNLOADING");
				}
				return r_FDOWNLOADING;
			}
		}

		/// <summary>
		/// UnityEditor.AsyncHTTPClient+State CONFIRMING
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RState r_FCONFIRMING;
		public static Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RState RFCONFIRMING
		{
			get
			{
				if(r_FCONFIRMING == null)
				{
					r_FCONFIRMING = new( ReflectionUtils.GetType("UnityEditor.AsyncHTTPClient+State"), "CONFIRMING");
				}
				return r_FCONFIRMING;
			}
		}

		/// <summary>
		/// UnityEditor.AsyncHTTPClient+State DONE_OK
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RState r_FDONE_OK;
		public static Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RState RFDONE_OK
		{
			get
			{
				if(r_FDONE_OK == null)
				{
					r_FDONE_OK = new( ReflectionUtils.GetType("UnityEditor.AsyncHTTPClient+State"), "DONE_OK");
				}
				return r_FDONE_OK;
			}
		}

		/// <summary>
		/// UnityEditor.AsyncHTTPClient+State DONE_FAILED
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RState r_FDONE_FAILED;
		public static Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RState RFDONE_FAILED
		{
			get
			{
				if(r_FDONE_FAILED == null)
				{
					r_FDONE_FAILED = new( ReflectionUtils.GetType("UnityEditor.AsyncHTTPClient+State"), "DONE_FAILED");
				}
				return r_FDONE_FAILED;
			}
		}

		/// <summary>
		/// UnityEditor.AsyncHTTPClient+State ABORTED
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RState r_FABORTED;
		public static Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RState RFABORTED
		{
			get
			{
				if(r_FABORTED == null)
				{
					r_FABORTED = new( ReflectionUtils.GetType("UnityEditor.AsyncHTTPClient+State"), "ABORTED");
				}
				return r_FABORTED;
			}
		}

		/// <summary>
		/// UnityEditor.AsyncHTTPClient+State TIMEOUT
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RState r_FTIMEOUT;
		public static Hvak.Editor.Refleaction.RUnityEditor.RAsyncHTTPClient.RState RFTIMEOUT
		{
			get
			{
				if(r_FTIMEOUT == null)
				{
					r_FTIMEOUT = new( ReflectionUtils.GetType("UnityEditor.AsyncHTTPClient+State"), "TIMEOUT");
				}
				return r_FTIMEOUT;
			}
		}

		/// <summary>
		/// System.Object GetValue()
		/// </summary>
		protected RMethod r_MGetValue;
		public virtual RMethod RMGetValue
		{
			get
			{
				if(r_MGetValue == null)
				{
					r_MGetValue = new(this, "GetValue", 0);
				}
				return r_MGetValue;
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
		/// System.String ToString(System.String, System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_String_IFormatProvider;
		public virtual RMethod RMToString_String_IFormatProvider
		{
			get
			{
				if(r_MToString_String_IFormatProvider == null)
				{
					r_MToString_String_IFormatProvider = new(this, "ToString", 0, typeof(System.String), typeof(System.IFormatProvider));
				}
				return r_MToString_String_IFormatProvider;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_MCompareTo_Object;
		public virtual RMethod RMCompareTo_Object
		{
			get
			{
				if(r_MCompareTo_Object == null)
				{
					r_MCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
				}
				return r_MCompareTo_Object;
			}
		}

		/// <summary>
		/// System.String ToString(System.String)
		/// </summary>
		protected RMethod r_MToString_String;
		public virtual RMethod RMToString_String
		{
			get
			{
				if(r_MToString_String == null)
				{
					r_MToString_String = new(this, "ToString", 0, typeof(System.String));
				}
				return r_MToString_String;
			}
		}

		/// <summary>
		/// System.String ToString(System.IFormatProvider)
		/// </summary>
		protected RMethod r_MToString_IFormatProvider;
		public virtual RMethod RMToString_IFormatProvider
		{
			get
			{
				if(r_MToString_IFormatProvider == null)
				{
					r_MToString_IFormatProvider = new(this, "ToString", 0, typeof(System.IFormatProvider));
				}
				return r_MToString_IFormatProvider;
			}
		}

		/// <summary>
		/// Boolean HasFlag(System.Enum)
		/// </summary>
		protected RMethod r_MHasFlag_Enum;
		public virtual RMethod RMHasFlag_Enum
		{
			get
			{
				if(r_MHasFlag_Enum == null)
				{
					r_MHasFlag_Enum = new(this, "HasFlag", 0, typeof(System.Enum));
				}
				return r_MHasFlag_Enum;
			}
		}

		/// <summary>
		/// System.TypeCode GetTypeCode()
		/// </summary>
		protected RMethod r_MGetTypeCode;
		public virtual RMethod RMGetTypeCode
		{
			get
			{
				if(r_MGetTypeCode == null)
				{
					r_MGetTypeCode = new(this, "GetTypeCode", 0);
				}
				return r_MGetTypeCode;
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


        public RState() : base("UnityEditor.AsyncHTTPClient+State")
        {
        }

        public RState(System.Object instance) : base("UnityEditor.AsyncHTTPClient+State")
		{
            SetInstance(instance);
		}

        public RState(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RState(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return (System.TypeCode)___result;
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
}