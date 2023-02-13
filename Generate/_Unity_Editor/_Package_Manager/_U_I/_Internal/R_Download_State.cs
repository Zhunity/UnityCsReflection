
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.DownloadState
	/// </summary>
    public partial class RDownloadState : RMember //
    {

		/// <summary>
		/// System.Int32 value__
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt32 r_Fvalue__;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt32 RFvalue__
		{
			get
			{
				if(r_Fvalue__ == null)
				{
					r_Fvalue__ = new(this, "value__");
					r_Fvalue__.SetBelong(this.instance);
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.DownloadState None
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState r_FNone;
		public static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState RFNone
		{
			get
			{
				if(r_FNone == null)
				{
					r_FNone = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.DownloadState"), "None");
					r_FNone.SetBelong(null);
				}
				return r_FNone;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.DownloadState Connecting
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState r_FConnecting;
		public static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState RFConnecting
		{
			get
			{
				if(r_FConnecting == null)
				{
					r_FConnecting = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.DownloadState"), "Connecting");
					r_FConnecting.SetBelong(null);
				}
				return r_FConnecting;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.DownloadState DownloadRequested
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState r_FDownloadRequested;
		public static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState RFDownloadRequested
		{
			get
			{
				if(r_FDownloadRequested == null)
				{
					r_FDownloadRequested = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.DownloadState"), "DownloadRequested");
					r_FDownloadRequested.SetBelong(null);
				}
				return r_FDownloadRequested;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.DownloadState Downloading
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState r_FDownloading;
		public static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState RFDownloading
		{
			get
			{
				if(r_FDownloading == null)
				{
					r_FDownloading = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.DownloadState"), "Downloading");
					r_FDownloading.SetBelong(null);
				}
				return r_FDownloading;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.DownloadState Pausing
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState r_FPausing;
		public static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState RFPausing
		{
			get
			{
				if(r_FPausing == null)
				{
					r_FPausing = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.DownloadState"), "Pausing");
					r_FPausing.SetBelong(null);
				}
				return r_FPausing;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.DownloadState Paused
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState r_FPaused;
		public static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState RFPaused
		{
			get
			{
				if(r_FPaused == null)
				{
					r_FPaused = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.DownloadState"), "Paused");
					r_FPaused.SetBelong(null);
				}
				return r_FPaused;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.DownloadState ResumeRequested
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState r_FResumeRequested;
		public static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState RFResumeRequested
		{
			get
			{
				if(r_FResumeRequested == null)
				{
					r_FResumeRequested = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.DownloadState"), "ResumeRequested");
					r_FResumeRequested.SetBelong(null);
				}
				return r_FResumeRequested;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.DownloadState Completed
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState r_FCompleted;
		public static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState RFCompleted
		{
			get
			{
				if(r_FCompleted == null)
				{
					r_FCompleted = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.DownloadState"), "Completed");
					r_FCompleted.SetBelong(null);
				}
				return r_FCompleted;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.DownloadState Decrypting
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState r_FDecrypting;
		public static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState RFDecrypting
		{
			get
			{
				if(r_FDecrypting == null)
				{
					r_FDecrypting = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.DownloadState"), "Decrypting");
					r_FDecrypting.SetBelong(null);
				}
				return r_FDecrypting;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.DownloadState Aborted
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState r_FAborted;
		public static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState RFAborted
		{
			get
			{
				if(r_FAborted == null)
				{
					r_FAborted = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.DownloadState"), "Aborted");
					r_FAborted.SetBelong(null);
				}
				return r_FAborted;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.DownloadState AbortRequsted
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState r_FAbortRequsted;
		public static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState RFAbortRequsted
		{
			get
			{
				if(r_FAbortRequsted == null)
				{
					r_FAbortRequsted = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.DownloadState"), "AbortRequsted");
					r_FAbortRequsted.SetBelong(null);
				}
				return r_FAbortRequsted;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.DownloadState Error
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState r_FError;
		public static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState RFError
		{
			get
			{
				if(r_FError == null)
				{
					r_FError = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.DownloadState"), "Error");
					r_FError.SetBelong(null);
				}
				return r_FError;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.DownloadState InProgress
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState r_FInProgress;
		public static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState RFInProgress
		{
			get
			{
				if(r_FInProgress == null)
				{
					r_FInProgress = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.DownloadState"), "InProgress");
					r_FInProgress.SetBelong(null);
				}
				return r_FInProgress;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.DownloadState InPause
		/// </summary>
		protected static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState r_FInPause;
		public static SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RDownloadState RFInPause
		{
			get
			{
				if(r_FInPause == null)
				{
					r_FInPause = new( ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.DownloadState"), "InPause");
					r_FInPause.SetBelong(null);
				}
				return r_FInPause;
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
					r_MGetValue.SetBelong(this.instance);
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
					r_MToString_String_IFormatProvider.SetBelong(this.instance);
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
					r_MCompareTo_Object.SetBelong(this.instance);
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
					r_MToString_String.SetBelong(this.instance);
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
					r_MToString_IFormatProvider.SetBelong(this.instance);
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
					r_MHasFlag_Enum.SetBelong(this.instance);
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
					r_MGetTypeCode.SetBelong(this.instance);
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


        public RDownloadState() : base("UnityEditor.PackageManager.UI.Internal.DownloadState")
        {
        }

        public RDownloadState(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.DownloadState")
		{
            SetInstance(instance);
		}

        public RDownloadState(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDownloadState(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
