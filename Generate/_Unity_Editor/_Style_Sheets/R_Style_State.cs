
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.StyleSheets.StyleState
	/// </summary>
    public partial class RStyleState : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState");
            }
        }

        public RStyleState() : base("UnityEditor.StyleSheets.StyleState")
        {
        }

        public RStyleState(System.Object instance) : base("UnityEditor.StyleSheets.StyleState")
		{
            SetInstance(instance);
		}

        public RStyleState(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStyleState(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int64 value__
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Fvalue__;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFvalue__
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
		/// UnityEditor.StyleSheets.StyleState none
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Fnone;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFnone
		{
			get
			{
				if(r_Fnone == null)
				{
					r_Fnone = new(Type, "none");
				}
				return r_Fnone;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState all
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Fall;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFall
		{
			get
			{
				if(r_Fall == null)
				{
					r_Fall = new(Type, "all");
				}
				return r_Fall;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState normal
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Fnormal;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFnormal
		{
			get
			{
				if(r_Fnormal == null)
				{
					r_Fnormal = new(Type, "normal");
				}
				return r_Fnormal;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState active
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Factive;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFactive
		{
			get
			{
				if(r_Factive == null)
				{
					r_Factive = new(Type, "active");
				}
				return r_Factive;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState anyLink
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_FanyLink;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFanyLink
		{
			get
			{
				if(r_FanyLink == null)
				{
					r_FanyLink = new(Type, "anyLink");
				}
				return r_FanyLink;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState checked
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Fchecked;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFchecked
		{
			get
			{
				if(r_Fchecked == null)
				{
					r_Fchecked = new(Type, "checked");
				}
				return r_Fchecked;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState default
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Fdefault;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFdefault
		{
			get
			{
				if(r_Fdefault == null)
				{
					r_Fdefault = new(Type, "default");
				}
				return r_Fdefault;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState defined
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Fdefined;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFdefined
		{
			get
			{
				if(r_Fdefined == null)
				{
					r_Fdefined = new(Type, "defined");
				}
				return r_Fdefined;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState disabled
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Fdisabled;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFdisabled
		{
			get
			{
				if(r_Fdisabled == null)
				{
					r_Fdisabled = new(Type, "disabled");
				}
				return r_Fdisabled;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState empty
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Fempty;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFempty
		{
			get
			{
				if(r_Fempty == null)
				{
					r_Fempty = new(Type, "empty");
				}
				return r_Fempty;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState enabled
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Fenabled;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFenabled
		{
			get
			{
				if(r_Fenabled == null)
				{
					r_Fenabled = new(Type, "enabled");
				}
				return r_Fenabled;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState first
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Ffirst;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFfirst
		{
			get
			{
				if(r_Ffirst == null)
				{
					r_Ffirst = new(Type, "first");
				}
				return r_Ffirst;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState firstChild
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_FfirstChild;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFfirstChild
		{
			get
			{
				if(r_FfirstChild == null)
				{
					r_FfirstChild = new(Type, "firstChild");
				}
				return r_FfirstChild;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState firstOfType
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_FfirstOfType;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFfirstOfType
		{
			get
			{
				if(r_FfirstOfType == null)
				{
					r_FfirstOfType = new(Type, "firstOfType");
				}
				return r_FfirstOfType;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState fullscreen
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Ffullscreen;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFfullscreen
		{
			get
			{
				if(r_Ffullscreen == null)
				{
					r_Ffullscreen = new(Type, "fullscreen");
				}
				return r_Ffullscreen;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState focus
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Ffocus;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFfocus
		{
			get
			{
				if(r_Ffocus == null)
				{
					r_Ffocus = new(Type, "focus");
				}
				return r_Ffocus;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState focusVisible
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_FfocusVisible;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFfocusVisible
		{
			get
			{
				if(r_FfocusVisible == null)
				{
					r_FfocusVisible = new(Type, "focusVisible");
				}
				return r_FfocusVisible;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState host
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Fhost;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFhost
		{
			get
			{
				if(r_Fhost == null)
				{
					r_Fhost = new(Type, "host");
				}
				return r_Fhost;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState hover
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Fhover;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFhover
		{
			get
			{
				if(r_Fhover == null)
				{
					r_Fhover = new(Type, "hover");
				}
				return r_Fhover;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState indeterminate
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Findeterminate;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFindeterminate
		{
			get
			{
				if(r_Findeterminate == null)
				{
					r_Findeterminate = new(Type, "indeterminate");
				}
				return r_Findeterminate;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState inRange
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_FinRange;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFinRange
		{
			get
			{
				if(r_FinRange == null)
				{
					r_FinRange = new(Type, "inRange");
				}
				return r_FinRange;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState invalid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Finvalid;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFinvalid
		{
			get
			{
				if(r_Finvalid == null)
				{
					r_Finvalid = new(Type, "invalid");
				}
				return r_Finvalid;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState lastChild
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_FlastChild;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFlastChild
		{
			get
			{
				if(r_FlastChild == null)
				{
					r_FlastChild = new(Type, "lastChild");
				}
				return r_FlastChild;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState lastOfType
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_FlastOfType;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFlastOfType
		{
			get
			{
				if(r_FlastOfType == null)
				{
					r_FlastOfType = new(Type, "lastOfType");
				}
				return r_FlastOfType;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState link
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Flink;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFlink
		{
			get
			{
				if(r_Flink == null)
				{
					r_Flink = new(Type, "link");
				}
				return r_Flink;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState onlyChild
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_FonlyChild;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFonlyChild
		{
			get
			{
				if(r_FonlyChild == null)
				{
					r_FonlyChild = new(Type, "onlyChild");
				}
				return r_FonlyChild;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState onlyOfType
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_FonlyOfType;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFonlyOfType
		{
			get
			{
				if(r_FonlyOfType == null)
				{
					r_FonlyOfType = new(Type, "onlyOfType");
				}
				return r_FonlyOfType;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState optional
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Foptional;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFoptional
		{
			get
			{
				if(r_Foptional == null)
				{
					r_Foptional = new(Type, "optional");
				}
				return r_Foptional;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState outOfRange
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_FoutOfRange;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFoutOfRange
		{
			get
			{
				if(r_FoutOfRange == null)
				{
					r_FoutOfRange = new(Type, "outOfRange");
				}
				return r_FoutOfRange;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState readOnly
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_FreadOnly;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFreadOnly
		{
			get
			{
				if(r_FreadOnly == null)
				{
					r_FreadOnly = new(Type, "readOnly");
				}
				return r_FreadOnly;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState readWrite
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_FreadWrite;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFreadWrite
		{
			get
			{
				if(r_FreadWrite == null)
				{
					r_FreadWrite = new(Type, "readWrite");
				}
				return r_FreadWrite;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState required
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Frequired;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFrequired
		{
			get
			{
				if(r_Frequired == null)
				{
					r_Frequired = new(Type, "required");
				}
				return r_Frequired;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState scope
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Fscope;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFscope
		{
			get
			{
				if(r_Fscope == null)
				{
					r_Fscope = new(Type, "scope");
				}
				return r_Fscope;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState target
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Ftarget;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFtarget
		{
			get
			{
				if(r_Ftarget == null)
				{
					r_Ftarget = new(Type, "target");
				}
				return r_Ftarget;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState valid
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Fvalid;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFvalid
		{
			get
			{
				if(r_Fvalid == null)
				{
					r_Fvalid = new(Type, "valid");
				}
				return r_Fvalid;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState visited
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Fvisited;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFvisited
		{
			get
			{
				if(r_Fvisited == null)
				{
					r_Fvisited = new(Type, "visited");
				}
				return r_Fvisited;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState root
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Froot;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFroot
		{
			get
			{
				if(r_Froot == null)
				{
					r_Froot = new(Type, "root");
				}
				return r_Froot;
			}
		}

		/// <summary>
		/// UnityEditor.StyleSheets.StyleState any
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState r_Fany;
		public static Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets.RStyleState RFany
		{
			get
			{
				if(r_Fany == null)
				{
					r_Fany = new(Type, "any");
				}
				return r_Fany;
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
