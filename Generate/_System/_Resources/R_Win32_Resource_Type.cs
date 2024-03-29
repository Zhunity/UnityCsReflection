
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RResources
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Resources.Win32ResourceType
	/// </summary>
    public partial class RWin32ResourceType : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("System.Resources.Win32ResourceType");
            }
        }

        public RWin32ResourceType() : base("System.Resources.Win32ResourceType")
        {
        }

        public RWin32ResourceType(System.Object instance) : base("System.Resources.Win32ResourceType")
		{
            SetInstance(instance);
		}

        public RWin32ResourceType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RWin32ResourceType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// System.Resources.Win32ResourceType RT_CURSOR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_FRT_CURSOR;
		public static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RFRT_CURSOR
		{
			get
			{
				if(r_FRT_CURSOR == null)
				{
					r_FRT_CURSOR = new(Type, "RT_CURSOR");
				}
				return r_FRT_CURSOR;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType RT_FONT
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_FRT_FONT;
		public static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RFRT_FONT
		{
			get
			{
				if(r_FRT_FONT == null)
				{
					r_FRT_FONT = new(Type, "RT_FONT");
				}
				return r_FRT_FONT;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType RT_BITMAP
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_FRT_BITMAP;
		public static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RFRT_BITMAP
		{
			get
			{
				if(r_FRT_BITMAP == null)
				{
					r_FRT_BITMAP = new(Type, "RT_BITMAP");
				}
				return r_FRT_BITMAP;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType RT_ICON
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_FRT_ICON;
		public static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RFRT_ICON
		{
			get
			{
				if(r_FRT_ICON == null)
				{
					r_FRT_ICON = new(Type, "RT_ICON");
				}
				return r_FRT_ICON;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType RT_MENU
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_FRT_MENU;
		public static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RFRT_MENU
		{
			get
			{
				if(r_FRT_MENU == null)
				{
					r_FRT_MENU = new(Type, "RT_MENU");
				}
				return r_FRT_MENU;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType RT_DIALOG
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_FRT_DIALOG;
		public static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RFRT_DIALOG
		{
			get
			{
				if(r_FRT_DIALOG == null)
				{
					r_FRT_DIALOG = new(Type, "RT_DIALOG");
				}
				return r_FRT_DIALOG;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType RT_STRING
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_FRT_STRING;
		public static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RFRT_STRING
		{
			get
			{
				if(r_FRT_STRING == null)
				{
					r_FRT_STRING = new(Type, "RT_STRING");
				}
				return r_FRT_STRING;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType RT_FONTDIR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_FRT_FONTDIR;
		public static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RFRT_FONTDIR
		{
			get
			{
				if(r_FRT_FONTDIR == null)
				{
					r_FRT_FONTDIR = new(Type, "RT_FONTDIR");
				}
				return r_FRT_FONTDIR;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType RT_ACCELERATOR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_FRT_ACCELERATOR;
		public static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RFRT_ACCELERATOR
		{
			get
			{
				if(r_FRT_ACCELERATOR == null)
				{
					r_FRT_ACCELERATOR = new(Type, "RT_ACCELERATOR");
				}
				return r_FRT_ACCELERATOR;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType RT_RCDATA
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_FRT_RCDATA;
		public static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RFRT_RCDATA
		{
			get
			{
				if(r_FRT_RCDATA == null)
				{
					r_FRT_RCDATA = new(Type, "RT_RCDATA");
				}
				return r_FRT_RCDATA;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType RT_MESSAGETABLE
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_FRT_MESSAGETABLE;
		public static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RFRT_MESSAGETABLE
		{
			get
			{
				if(r_FRT_MESSAGETABLE == null)
				{
					r_FRT_MESSAGETABLE = new(Type, "RT_MESSAGETABLE");
				}
				return r_FRT_MESSAGETABLE;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType RT_GROUP_CURSOR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_FRT_GROUP_CURSOR;
		public static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RFRT_GROUP_CURSOR
		{
			get
			{
				if(r_FRT_GROUP_CURSOR == null)
				{
					r_FRT_GROUP_CURSOR = new(Type, "RT_GROUP_CURSOR");
				}
				return r_FRT_GROUP_CURSOR;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType RT_GROUP_ICON
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_FRT_GROUP_ICON;
		public static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RFRT_GROUP_ICON
		{
			get
			{
				if(r_FRT_GROUP_ICON == null)
				{
					r_FRT_GROUP_ICON = new(Type, "RT_GROUP_ICON");
				}
				return r_FRT_GROUP_ICON;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType RT_VERSION
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_FRT_VERSION;
		public static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RFRT_VERSION
		{
			get
			{
				if(r_FRT_VERSION == null)
				{
					r_FRT_VERSION = new(Type, "RT_VERSION");
				}
				return r_FRT_VERSION;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType RT_DLGINCLUDE
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_FRT_DLGINCLUDE;
		public static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RFRT_DLGINCLUDE
		{
			get
			{
				if(r_FRT_DLGINCLUDE == null)
				{
					r_FRT_DLGINCLUDE = new(Type, "RT_DLGINCLUDE");
				}
				return r_FRT_DLGINCLUDE;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType RT_PLUGPLAY
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_FRT_PLUGPLAY;
		public static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RFRT_PLUGPLAY
		{
			get
			{
				if(r_FRT_PLUGPLAY == null)
				{
					r_FRT_PLUGPLAY = new(Type, "RT_PLUGPLAY");
				}
				return r_FRT_PLUGPLAY;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType RT_VXD
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_FRT_VXD;
		public static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RFRT_VXD
		{
			get
			{
				if(r_FRT_VXD == null)
				{
					r_FRT_VXD = new(Type, "RT_VXD");
				}
				return r_FRT_VXD;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType RT_ANICURSOR
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_FRT_ANICURSOR;
		public static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RFRT_ANICURSOR
		{
			get
			{
				if(r_FRT_ANICURSOR == null)
				{
					r_FRT_ANICURSOR = new(Type, "RT_ANICURSOR");
				}
				return r_FRT_ANICURSOR;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType RT_ANIICON
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_FRT_ANIICON;
		public static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RFRT_ANIICON
		{
			get
			{
				if(r_FRT_ANIICON == null)
				{
					r_FRT_ANIICON = new(Type, "RT_ANIICON");
				}
				return r_FRT_ANIICON;
			}
		}

		/// <summary>
		/// System.Resources.Win32ResourceType RT_HTML
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType r_FRT_HTML;
		public static Hvak.Editor.Refleaction.RSystem.RResources.RWin32ResourceType RFRT_HTML
		{
			get
			{
				if(r_FRT_HTML == null)
				{
					r_FRT_HTML = new(Type, "RT_HTML");
				}
				return r_FRT_HTML;
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
