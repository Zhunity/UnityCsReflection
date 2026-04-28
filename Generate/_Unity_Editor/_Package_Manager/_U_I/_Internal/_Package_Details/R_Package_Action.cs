
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{public partial class RPackageDetails
{
	
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction
	/// </summary>
    public partial class RPackageAction : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction");
            }
        }

        public RPackageAction() : base("UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction")
        {
        }

        public RPackageAction(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction")
		{
            SetInstance(instance);
		}

        public RPackageAction(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPackageAction(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


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
		/// UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction None
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction r_FNone;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction RFNone
		{
			get
			{
				if(r_FNone == null)
				{
					r_FNone = new(Type, "None");
				}
				return r_FNone;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction Add
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction r_FAdd;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction RFAdd
		{
			get
			{
				if(r_FAdd == null)
				{
					r_FAdd = new(Type, "Add");
				}
				return r_FAdd;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction Remove
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction r_FRemove;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction RFRemove
		{
			get
			{
				if(r_FRemove == null)
				{
					r_FRemove = new(Type, "Remove");
				}
				return r_FRemove;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction Update
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction r_FUpdate;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction RFUpdate
		{
			get
			{
				if(r_FUpdate == null)
				{
					r_FUpdate = new(Type, "Update");
				}
				return r_FUpdate;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction Enable
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction r_FEnable;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction RFEnable
		{
			get
			{
				if(r_FEnable == null)
				{
					r_FEnable = new(Type, "Enable");
				}
				return r_FEnable;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction Disable
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction r_FDisable;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction RFDisable
		{
			get
			{
				if(r_FDisable == null)
				{
					r_FDisable = new(Type, "Disable");
				}
				return r_FDisable;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction Download
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction r_FDownload;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction RFDownload
		{
			get
			{
				if(r_FDownload == null)
				{
					r_FDownload = new(Type, "Download");
				}
				return r_FDownload;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction Upgrade
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction r_FUpgrade;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction RFUpgrade
		{
			get
			{
				if(r_FUpgrade == null)
				{
					r_FUpgrade = new(Type, "Upgrade");
				}
				return r_FUpgrade;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction Pause
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction r_FPause;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction RFPause
		{
			get
			{
				if(r_FPause == null)
				{
					r_FPause = new(Type, "Pause");
				}
				return r_FPause;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction Resume
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction r_FResume;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction RFResume
		{
			get
			{
				if(r_FResume == null)
				{
					r_FResume = new(Type, "Resume");
				}
				return r_FResume;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction Cancel
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction r_FCancel;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction RFCancel
		{
			get
			{
				if(r_FCancel == null)
				{
					r_FCancel = new(Type, "Cancel");
				}
				return r_FCancel;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction Import
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction r_FImport;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction RFImport
		{
			get
			{
				if(r_FImport == null)
				{
					r_FImport = new(Type, "Import");
				}
				return r_FImport;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction Reset
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction r_FReset;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction RFReset
		{
			get
			{
				if(r_FReset == null)
				{
					r_FReset = new(Type, "Reset");
				}
				return r_FReset;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction GitUpdate
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction r_FGitUpdate;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction RFGitUpdate
		{
			get
			{
				if(r_FGitUpdate == null)
				{
					r_FGitUpdate = new(Type, "GitUpdate");
				}
				return r_FGitUpdate;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction ReDownload
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction r_FReDownload;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction RFReDownload
		{
			get
			{
				if(r_FReDownload == null)
				{
					r_FReDownload = new(Type, "ReDownload");
				}
				return r_FReDownload;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.PackageDetails+PackageAction Downgrade
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction r_FDowngrade;
		public static Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RPackageDetails.RPackageAction RFDowngrade
		{
			get
			{
				if(r_FDowngrade == null)
				{
					r_FDowngrade = new(Type, "Downgrade");
				}
				return r_FDowngrade;
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


        public virtual System.Object GetValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetValue.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.String @format, System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @provider};
            var ___result = RMToString_String_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Int32 CompareTo(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMCompareTo_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString(System.String @format)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format};
            var ___result = RMToString_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.String ToString(System.IFormatProvider @provider)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@provider};
            var ___result = RMToString_IFormatProvider.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Boolean HasFlag(System.Enum @flag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@flag};
            var ___result = RMHasFlag_Enum.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.TypeCode GetTypeCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTypeCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.TypeCode>(___result);
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

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
}