
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RStyleSheets
{
	/// <summary>
	/// UnityEditor.StyleSheets.StyleState
	/// </summary>
    public partial class RStyleState : RMember //
    {

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
					r_Fvalue__.SetBelong(this.instance);
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
					r_Fnone = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "none");
					r_Fnone.SetBelong(null);
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
					r_Fall = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "all");
					r_Fall.SetBelong(null);
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
					r_Fnormal = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "normal");
					r_Fnormal.SetBelong(null);
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
					r_Factive = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "active");
					r_Factive.SetBelong(null);
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
					r_FanyLink = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "anyLink");
					r_FanyLink.SetBelong(null);
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
					r_Fchecked = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "checked");
					r_Fchecked.SetBelong(null);
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
					r_Fdefault = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "default");
					r_Fdefault.SetBelong(null);
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
					r_Fdefined = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "defined");
					r_Fdefined.SetBelong(null);
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
					r_Fdisabled = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "disabled");
					r_Fdisabled.SetBelong(null);
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
					r_Fempty = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "empty");
					r_Fempty.SetBelong(null);
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
					r_Fenabled = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "enabled");
					r_Fenabled.SetBelong(null);
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
					r_Ffirst = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "first");
					r_Ffirst.SetBelong(null);
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
					r_FfirstChild = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "firstChild");
					r_FfirstChild.SetBelong(null);
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
					r_FfirstOfType = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "firstOfType");
					r_FfirstOfType.SetBelong(null);
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
					r_Ffullscreen = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "fullscreen");
					r_Ffullscreen.SetBelong(null);
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
					r_Ffocus = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "focus");
					r_Ffocus.SetBelong(null);
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
					r_FfocusVisible = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "focusVisible");
					r_FfocusVisible.SetBelong(null);
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
					r_Fhost = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "host");
					r_Fhost.SetBelong(null);
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
					r_Fhover = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "hover");
					r_Fhover.SetBelong(null);
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
					r_Findeterminate = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "indeterminate");
					r_Findeterminate.SetBelong(null);
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
					r_FinRange = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "inRange");
					r_FinRange.SetBelong(null);
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
					r_Finvalid = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "invalid");
					r_Finvalid.SetBelong(null);
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
					r_FlastChild = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "lastChild");
					r_FlastChild.SetBelong(null);
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
					r_FlastOfType = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "lastOfType");
					r_FlastOfType.SetBelong(null);
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
					r_Flink = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "link");
					r_Flink.SetBelong(null);
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
					r_FonlyChild = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "onlyChild");
					r_FonlyChild.SetBelong(null);
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
					r_FonlyOfType = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "onlyOfType");
					r_FonlyOfType.SetBelong(null);
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
					r_Foptional = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "optional");
					r_Foptional.SetBelong(null);
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
					r_FoutOfRange = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "outOfRange");
					r_FoutOfRange.SetBelong(null);
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
					r_FreadOnly = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "readOnly");
					r_FreadOnly.SetBelong(null);
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
					r_FreadWrite = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "readWrite");
					r_FreadWrite.SetBelong(null);
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
					r_Frequired = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "required");
					r_Frequired.SetBelong(null);
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
					r_Fscope = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "scope");
					r_Fscope.SetBelong(null);
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
					r_Ftarget = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "target");
					r_Ftarget.SetBelong(null);
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
					r_Fvalid = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "valid");
					r_Fvalid.SetBelong(null);
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
					r_Fvisited = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "visited");
					r_Fvisited.SetBelong(null);
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
					r_Froot = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "root");
					r_Froot.SetBelong(null);
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
					r_Fany = new( ReflectionUtils.GetType("UnityEditor.StyleSheets.StyleState"), "any");
					r_Fany.SetBelong(null);
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
