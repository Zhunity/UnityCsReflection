
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.KeyCode
	/// </summary>
    public partial class RKeyCode : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.KeyCode);
            }
        }

        public RKeyCode() : base("UnityEngine.KeyCode")
        {
        }

        public RKeyCode(System.Object instance) : base("UnityEngine.KeyCode")
		{
            SetInstance(instance);
		}

        public RKeyCode(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RKeyCode(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
		/// UnityEngine.KeyCode None
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FNone;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFNone
		{
			get
			{
				if(r_FNone == null)
				{
					r_FNone = new(typeof(UnityEngine.KeyCode), "None");
				}
				return r_FNone;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Backspace
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FBackspace;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFBackspace
		{
			get
			{
				if(r_FBackspace == null)
				{
					r_FBackspace = new(typeof(UnityEngine.KeyCode), "Backspace");
				}
				return r_FBackspace;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Delete
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FDelete;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFDelete
		{
			get
			{
				if(r_FDelete == null)
				{
					r_FDelete = new(typeof(UnityEngine.KeyCode), "Delete");
				}
				return r_FDelete;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Tab
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FTab;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFTab
		{
			get
			{
				if(r_FTab == null)
				{
					r_FTab = new(typeof(UnityEngine.KeyCode), "Tab");
				}
				return r_FTab;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Clear
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FClear;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFClear
		{
			get
			{
				if(r_FClear == null)
				{
					r_FClear = new(typeof(UnityEngine.KeyCode), "Clear");
				}
				return r_FClear;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Return
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FReturn;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFReturn
		{
			get
			{
				if(r_FReturn == null)
				{
					r_FReturn = new(typeof(UnityEngine.KeyCode), "Return");
				}
				return r_FReturn;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Pause
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FPause;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFPause
		{
			get
			{
				if(r_FPause == null)
				{
					r_FPause = new(typeof(UnityEngine.KeyCode), "Pause");
				}
				return r_FPause;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Escape
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FEscape;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFEscape
		{
			get
			{
				if(r_FEscape == null)
				{
					r_FEscape = new(typeof(UnityEngine.KeyCode), "Escape");
				}
				return r_FEscape;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Space
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FSpace;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFSpace
		{
			get
			{
				if(r_FSpace == null)
				{
					r_FSpace = new(typeof(UnityEngine.KeyCode), "Space");
				}
				return r_FSpace;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Keypad0
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FKeypad0;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFKeypad0
		{
			get
			{
				if(r_FKeypad0 == null)
				{
					r_FKeypad0 = new(typeof(UnityEngine.KeyCode), "Keypad0");
				}
				return r_FKeypad0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Keypad1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FKeypad1;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFKeypad1
		{
			get
			{
				if(r_FKeypad1 == null)
				{
					r_FKeypad1 = new(typeof(UnityEngine.KeyCode), "Keypad1");
				}
				return r_FKeypad1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Keypad2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FKeypad2;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFKeypad2
		{
			get
			{
				if(r_FKeypad2 == null)
				{
					r_FKeypad2 = new(typeof(UnityEngine.KeyCode), "Keypad2");
				}
				return r_FKeypad2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Keypad3
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FKeypad3;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFKeypad3
		{
			get
			{
				if(r_FKeypad3 == null)
				{
					r_FKeypad3 = new(typeof(UnityEngine.KeyCode), "Keypad3");
				}
				return r_FKeypad3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Keypad4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FKeypad4;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFKeypad4
		{
			get
			{
				if(r_FKeypad4 == null)
				{
					r_FKeypad4 = new(typeof(UnityEngine.KeyCode), "Keypad4");
				}
				return r_FKeypad4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Keypad5
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FKeypad5;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFKeypad5
		{
			get
			{
				if(r_FKeypad5 == null)
				{
					r_FKeypad5 = new(typeof(UnityEngine.KeyCode), "Keypad5");
				}
				return r_FKeypad5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Keypad6
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FKeypad6;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFKeypad6
		{
			get
			{
				if(r_FKeypad6 == null)
				{
					r_FKeypad6 = new(typeof(UnityEngine.KeyCode), "Keypad6");
				}
				return r_FKeypad6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Keypad7
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FKeypad7;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFKeypad7
		{
			get
			{
				if(r_FKeypad7 == null)
				{
					r_FKeypad7 = new(typeof(UnityEngine.KeyCode), "Keypad7");
				}
				return r_FKeypad7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Keypad8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FKeypad8;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFKeypad8
		{
			get
			{
				if(r_FKeypad8 == null)
				{
					r_FKeypad8 = new(typeof(UnityEngine.KeyCode), "Keypad8");
				}
				return r_FKeypad8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Keypad9
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FKeypad9;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFKeypad9
		{
			get
			{
				if(r_FKeypad9 == null)
				{
					r_FKeypad9 = new(typeof(UnityEngine.KeyCode), "Keypad9");
				}
				return r_FKeypad9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode KeypadPeriod
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FKeypadPeriod;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFKeypadPeriod
		{
			get
			{
				if(r_FKeypadPeriod == null)
				{
					r_FKeypadPeriod = new(typeof(UnityEngine.KeyCode), "KeypadPeriod");
				}
				return r_FKeypadPeriod;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode KeypadDivide
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FKeypadDivide;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFKeypadDivide
		{
			get
			{
				if(r_FKeypadDivide == null)
				{
					r_FKeypadDivide = new(typeof(UnityEngine.KeyCode), "KeypadDivide");
				}
				return r_FKeypadDivide;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode KeypadMultiply
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FKeypadMultiply;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFKeypadMultiply
		{
			get
			{
				if(r_FKeypadMultiply == null)
				{
					r_FKeypadMultiply = new(typeof(UnityEngine.KeyCode), "KeypadMultiply");
				}
				return r_FKeypadMultiply;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode KeypadMinus
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FKeypadMinus;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFKeypadMinus
		{
			get
			{
				if(r_FKeypadMinus == null)
				{
					r_FKeypadMinus = new(typeof(UnityEngine.KeyCode), "KeypadMinus");
				}
				return r_FKeypadMinus;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode KeypadPlus
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FKeypadPlus;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFKeypadPlus
		{
			get
			{
				if(r_FKeypadPlus == null)
				{
					r_FKeypadPlus = new(typeof(UnityEngine.KeyCode), "KeypadPlus");
				}
				return r_FKeypadPlus;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode KeypadEnter
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FKeypadEnter;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFKeypadEnter
		{
			get
			{
				if(r_FKeypadEnter == null)
				{
					r_FKeypadEnter = new(typeof(UnityEngine.KeyCode), "KeypadEnter");
				}
				return r_FKeypadEnter;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode KeypadEquals
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FKeypadEquals;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFKeypadEquals
		{
			get
			{
				if(r_FKeypadEquals == null)
				{
					r_FKeypadEquals = new(typeof(UnityEngine.KeyCode), "KeypadEquals");
				}
				return r_FKeypadEquals;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode UpArrow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FUpArrow;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFUpArrow
		{
			get
			{
				if(r_FUpArrow == null)
				{
					r_FUpArrow = new(typeof(UnityEngine.KeyCode), "UpArrow");
				}
				return r_FUpArrow;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode DownArrow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FDownArrow;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFDownArrow
		{
			get
			{
				if(r_FDownArrow == null)
				{
					r_FDownArrow = new(typeof(UnityEngine.KeyCode), "DownArrow");
				}
				return r_FDownArrow;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode RightArrow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FRightArrow;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFRightArrow
		{
			get
			{
				if(r_FRightArrow == null)
				{
					r_FRightArrow = new(typeof(UnityEngine.KeyCode), "RightArrow");
				}
				return r_FRightArrow;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode LeftArrow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FLeftArrow;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFLeftArrow
		{
			get
			{
				if(r_FLeftArrow == null)
				{
					r_FLeftArrow = new(typeof(UnityEngine.KeyCode), "LeftArrow");
				}
				return r_FLeftArrow;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Insert
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FInsert;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFInsert
		{
			get
			{
				if(r_FInsert == null)
				{
					r_FInsert = new(typeof(UnityEngine.KeyCode), "Insert");
				}
				return r_FInsert;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Home
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FHome;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFHome
		{
			get
			{
				if(r_FHome == null)
				{
					r_FHome = new(typeof(UnityEngine.KeyCode), "Home");
				}
				return r_FHome;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode End
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FEnd;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFEnd
		{
			get
			{
				if(r_FEnd == null)
				{
					r_FEnd = new(typeof(UnityEngine.KeyCode), "End");
				}
				return r_FEnd;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode PageUp
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FPageUp;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFPageUp
		{
			get
			{
				if(r_FPageUp == null)
				{
					r_FPageUp = new(typeof(UnityEngine.KeyCode), "PageUp");
				}
				return r_FPageUp;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode PageDown
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FPageDown;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFPageDown
		{
			get
			{
				if(r_FPageDown == null)
				{
					r_FPageDown = new(typeof(UnityEngine.KeyCode), "PageDown");
				}
				return r_FPageDown;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FF1;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFF1
		{
			get
			{
				if(r_FF1 == null)
				{
					r_FF1 = new(typeof(UnityEngine.KeyCode), "F1");
				}
				return r_FF1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FF2;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFF2
		{
			get
			{
				if(r_FF2 == null)
				{
					r_FF2 = new(typeof(UnityEngine.KeyCode), "F2");
				}
				return r_FF2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F3
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FF3;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFF3
		{
			get
			{
				if(r_FF3 == null)
				{
					r_FF3 = new(typeof(UnityEngine.KeyCode), "F3");
				}
				return r_FF3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FF4;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFF4
		{
			get
			{
				if(r_FF4 == null)
				{
					r_FF4 = new(typeof(UnityEngine.KeyCode), "F4");
				}
				return r_FF4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F5
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FF5;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFF5
		{
			get
			{
				if(r_FF5 == null)
				{
					r_FF5 = new(typeof(UnityEngine.KeyCode), "F5");
				}
				return r_FF5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F6
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FF6;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFF6
		{
			get
			{
				if(r_FF6 == null)
				{
					r_FF6 = new(typeof(UnityEngine.KeyCode), "F6");
				}
				return r_FF6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F7
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FF7;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFF7
		{
			get
			{
				if(r_FF7 == null)
				{
					r_FF7 = new(typeof(UnityEngine.KeyCode), "F7");
				}
				return r_FF7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FF8;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFF8
		{
			get
			{
				if(r_FF8 == null)
				{
					r_FF8 = new(typeof(UnityEngine.KeyCode), "F8");
				}
				return r_FF8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F9
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FF9;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFF9
		{
			get
			{
				if(r_FF9 == null)
				{
					r_FF9 = new(typeof(UnityEngine.KeyCode), "F9");
				}
				return r_FF9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F10
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FF10;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFF10
		{
			get
			{
				if(r_FF10 == null)
				{
					r_FF10 = new(typeof(UnityEngine.KeyCode), "F10");
				}
				return r_FF10;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F11
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FF11;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFF11
		{
			get
			{
				if(r_FF11 == null)
				{
					r_FF11 = new(typeof(UnityEngine.KeyCode), "F11");
				}
				return r_FF11;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F12
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FF12;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFF12
		{
			get
			{
				if(r_FF12 == null)
				{
					r_FF12 = new(typeof(UnityEngine.KeyCode), "F12");
				}
				return r_FF12;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F13
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FF13;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFF13
		{
			get
			{
				if(r_FF13 == null)
				{
					r_FF13 = new(typeof(UnityEngine.KeyCode), "F13");
				}
				return r_FF13;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F14
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FF14;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFF14
		{
			get
			{
				if(r_FF14 == null)
				{
					r_FF14 = new(typeof(UnityEngine.KeyCode), "F14");
				}
				return r_FF14;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F15
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FF15;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFF15
		{
			get
			{
				if(r_FF15 == null)
				{
					r_FF15 = new(typeof(UnityEngine.KeyCode), "F15");
				}
				return r_FF15;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Alpha0
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FAlpha0;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFAlpha0
		{
			get
			{
				if(r_FAlpha0 == null)
				{
					r_FAlpha0 = new(typeof(UnityEngine.KeyCode), "Alpha0");
				}
				return r_FAlpha0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Alpha1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FAlpha1;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFAlpha1
		{
			get
			{
				if(r_FAlpha1 == null)
				{
					r_FAlpha1 = new(typeof(UnityEngine.KeyCode), "Alpha1");
				}
				return r_FAlpha1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Alpha2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FAlpha2;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFAlpha2
		{
			get
			{
				if(r_FAlpha2 == null)
				{
					r_FAlpha2 = new(typeof(UnityEngine.KeyCode), "Alpha2");
				}
				return r_FAlpha2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Alpha3
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FAlpha3;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFAlpha3
		{
			get
			{
				if(r_FAlpha3 == null)
				{
					r_FAlpha3 = new(typeof(UnityEngine.KeyCode), "Alpha3");
				}
				return r_FAlpha3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Alpha4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FAlpha4;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFAlpha4
		{
			get
			{
				if(r_FAlpha4 == null)
				{
					r_FAlpha4 = new(typeof(UnityEngine.KeyCode), "Alpha4");
				}
				return r_FAlpha4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Alpha5
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FAlpha5;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFAlpha5
		{
			get
			{
				if(r_FAlpha5 == null)
				{
					r_FAlpha5 = new(typeof(UnityEngine.KeyCode), "Alpha5");
				}
				return r_FAlpha5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Alpha6
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FAlpha6;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFAlpha6
		{
			get
			{
				if(r_FAlpha6 == null)
				{
					r_FAlpha6 = new(typeof(UnityEngine.KeyCode), "Alpha6");
				}
				return r_FAlpha6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Alpha7
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FAlpha7;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFAlpha7
		{
			get
			{
				if(r_FAlpha7 == null)
				{
					r_FAlpha7 = new(typeof(UnityEngine.KeyCode), "Alpha7");
				}
				return r_FAlpha7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Alpha8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FAlpha8;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFAlpha8
		{
			get
			{
				if(r_FAlpha8 == null)
				{
					r_FAlpha8 = new(typeof(UnityEngine.KeyCode), "Alpha8");
				}
				return r_FAlpha8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Alpha9
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FAlpha9;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFAlpha9
		{
			get
			{
				if(r_FAlpha9 == null)
				{
					r_FAlpha9 = new(typeof(UnityEngine.KeyCode), "Alpha9");
				}
				return r_FAlpha9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Exclaim
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FExclaim;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFExclaim
		{
			get
			{
				if(r_FExclaim == null)
				{
					r_FExclaim = new(typeof(UnityEngine.KeyCode), "Exclaim");
				}
				return r_FExclaim;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode DoubleQuote
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FDoubleQuote;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFDoubleQuote
		{
			get
			{
				if(r_FDoubleQuote == null)
				{
					r_FDoubleQuote = new(typeof(UnityEngine.KeyCode), "DoubleQuote");
				}
				return r_FDoubleQuote;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Hash
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FHash;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFHash
		{
			get
			{
				if(r_FHash == null)
				{
					r_FHash = new(typeof(UnityEngine.KeyCode), "Hash");
				}
				return r_FHash;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Dollar
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FDollar;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFDollar
		{
			get
			{
				if(r_FDollar == null)
				{
					r_FDollar = new(typeof(UnityEngine.KeyCode), "Dollar");
				}
				return r_FDollar;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Percent
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FPercent;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFPercent
		{
			get
			{
				if(r_FPercent == null)
				{
					r_FPercent = new(typeof(UnityEngine.KeyCode), "Percent");
				}
				return r_FPercent;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Ampersand
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FAmpersand;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFAmpersand
		{
			get
			{
				if(r_FAmpersand == null)
				{
					r_FAmpersand = new(typeof(UnityEngine.KeyCode), "Ampersand");
				}
				return r_FAmpersand;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Quote
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FQuote;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFQuote
		{
			get
			{
				if(r_FQuote == null)
				{
					r_FQuote = new(typeof(UnityEngine.KeyCode), "Quote");
				}
				return r_FQuote;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode LeftParen
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FLeftParen;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFLeftParen
		{
			get
			{
				if(r_FLeftParen == null)
				{
					r_FLeftParen = new(typeof(UnityEngine.KeyCode), "LeftParen");
				}
				return r_FLeftParen;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode RightParen
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FRightParen;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFRightParen
		{
			get
			{
				if(r_FRightParen == null)
				{
					r_FRightParen = new(typeof(UnityEngine.KeyCode), "RightParen");
				}
				return r_FRightParen;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Asterisk
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FAsterisk;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFAsterisk
		{
			get
			{
				if(r_FAsterisk == null)
				{
					r_FAsterisk = new(typeof(UnityEngine.KeyCode), "Asterisk");
				}
				return r_FAsterisk;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Plus
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FPlus;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFPlus
		{
			get
			{
				if(r_FPlus == null)
				{
					r_FPlus = new(typeof(UnityEngine.KeyCode), "Plus");
				}
				return r_FPlus;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Comma
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FComma;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFComma
		{
			get
			{
				if(r_FComma == null)
				{
					r_FComma = new(typeof(UnityEngine.KeyCode), "Comma");
				}
				return r_FComma;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Minus
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FMinus;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFMinus
		{
			get
			{
				if(r_FMinus == null)
				{
					r_FMinus = new(typeof(UnityEngine.KeyCode), "Minus");
				}
				return r_FMinus;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Period
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FPeriod;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFPeriod
		{
			get
			{
				if(r_FPeriod == null)
				{
					r_FPeriod = new(typeof(UnityEngine.KeyCode), "Period");
				}
				return r_FPeriod;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Slash
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FSlash;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFSlash
		{
			get
			{
				if(r_FSlash == null)
				{
					r_FSlash = new(typeof(UnityEngine.KeyCode), "Slash");
				}
				return r_FSlash;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Colon
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FColon;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFColon
		{
			get
			{
				if(r_FColon == null)
				{
					r_FColon = new(typeof(UnityEngine.KeyCode), "Colon");
				}
				return r_FColon;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Semicolon
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FSemicolon;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFSemicolon
		{
			get
			{
				if(r_FSemicolon == null)
				{
					r_FSemicolon = new(typeof(UnityEngine.KeyCode), "Semicolon");
				}
				return r_FSemicolon;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Less
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FLess;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFLess
		{
			get
			{
				if(r_FLess == null)
				{
					r_FLess = new(typeof(UnityEngine.KeyCode), "Less");
				}
				return r_FLess;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Equals
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FEquals;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFEquals
		{
			get
			{
				if(r_FEquals == null)
				{
					r_FEquals = new(typeof(UnityEngine.KeyCode), "Equals");
				}
				return r_FEquals;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Greater
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FGreater;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFGreater
		{
			get
			{
				if(r_FGreater == null)
				{
					r_FGreater = new(typeof(UnityEngine.KeyCode), "Greater");
				}
				return r_FGreater;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Question
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FQuestion;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFQuestion
		{
			get
			{
				if(r_FQuestion == null)
				{
					r_FQuestion = new(typeof(UnityEngine.KeyCode), "Question");
				}
				return r_FQuestion;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode At
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FAt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFAt
		{
			get
			{
				if(r_FAt == null)
				{
					r_FAt = new(typeof(UnityEngine.KeyCode), "At");
				}
				return r_FAt;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode LeftBracket
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FLeftBracket;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFLeftBracket
		{
			get
			{
				if(r_FLeftBracket == null)
				{
					r_FLeftBracket = new(typeof(UnityEngine.KeyCode), "LeftBracket");
				}
				return r_FLeftBracket;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Backslash
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FBackslash;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFBackslash
		{
			get
			{
				if(r_FBackslash == null)
				{
					r_FBackslash = new(typeof(UnityEngine.KeyCode), "Backslash");
				}
				return r_FBackslash;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode RightBracket
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FRightBracket;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFRightBracket
		{
			get
			{
				if(r_FRightBracket == null)
				{
					r_FRightBracket = new(typeof(UnityEngine.KeyCode), "RightBracket");
				}
				return r_FRightBracket;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Caret
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FCaret;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFCaret
		{
			get
			{
				if(r_FCaret == null)
				{
					r_FCaret = new(typeof(UnityEngine.KeyCode), "Caret");
				}
				return r_FCaret;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Underscore
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FUnderscore;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFUnderscore
		{
			get
			{
				if(r_FUnderscore == null)
				{
					r_FUnderscore = new(typeof(UnityEngine.KeyCode), "Underscore");
				}
				return r_FUnderscore;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode BackQuote
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FBackQuote;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFBackQuote
		{
			get
			{
				if(r_FBackQuote == null)
				{
					r_FBackQuote = new(typeof(UnityEngine.KeyCode), "BackQuote");
				}
				return r_FBackQuote;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode A
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FA;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFA
		{
			get
			{
				if(r_FA == null)
				{
					r_FA = new(typeof(UnityEngine.KeyCode), "A");
				}
				return r_FA;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode B
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FB;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFB
		{
			get
			{
				if(r_FB == null)
				{
					r_FB = new(typeof(UnityEngine.KeyCode), "B");
				}
				return r_FB;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode C
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FC;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFC
		{
			get
			{
				if(r_FC == null)
				{
					r_FC = new(typeof(UnityEngine.KeyCode), "C");
				}
				return r_FC;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode D
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FD;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFD
		{
			get
			{
				if(r_FD == null)
				{
					r_FD = new(typeof(UnityEngine.KeyCode), "D");
				}
				return r_FD;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode E
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FE;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFE
		{
			get
			{
				if(r_FE == null)
				{
					r_FE = new(typeof(UnityEngine.KeyCode), "E");
				}
				return r_FE;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode F
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FF;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFF
		{
			get
			{
				if(r_FF == null)
				{
					r_FF = new(typeof(UnityEngine.KeyCode), "F");
				}
				return r_FF;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode G
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FG;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFG
		{
			get
			{
				if(r_FG == null)
				{
					r_FG = new(typeof(UnityEngine.KeyCode), "G");
				}
				return r_FG;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode H
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FH;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFH
		{
			get
			{
				if(r_FH == null)
				{
					r_FH = new(typeof(UnityEngine.KeyCode), "H");
				}
				return r_FH;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode I
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FI;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFI
		{
			get
			{
				if(r_FI == null)
				{
					r_FI = new(typeof(UnityEngine.KeyCode), "I");
				}
				return r_FI;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode J
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJ;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJ
		{
			get
			{
				if(r_FJ == null)
				{
					r_FJ = new(typeof(UnityEngine.KeyCode), "J");
				}
				return r_FJ;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode K
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FK;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFK
		{
			get
			{
				if(r_FK == null)
				{
					r_FK = new(typeof(UnityEngine.KeyCode), "K");
				}
				return r_FK;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode L
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FL;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFL
		{
			get
			{
				if(r_FL == null)
				{
					r_FL = new(typeof(UnityEngine.KeyCode), "L");
				}
				return r_FL;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode M
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FM;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFM
		{
			get
			{
				if(r_FM == null)
				{
					r_FM = new(typeof(UnityEngine.KeyCode), "M");
				}
				return r_FM;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode N
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FN;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFN
		{
			get
			{
				if(r_FN == null)
				{
					r_FN = new(typeof(UnityEngine.KeyCode), "N");
				}
				return r_FN;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode O
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FO;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFO
		{
			get
			{
				if(r_FO == null)
				{
					r_FO = new(typeof(UnityEngine.KeyCode), "O");
				}
				return r_FO;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode P
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FP;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFP
		{
			get
			{
				if(r_FP == null)
				{
					r_FP = new(typeof(UnityEngine.KeyCode), "P");
				}
				return r_FP;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Q
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FQ;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFQ
		{
			get
			{
				if(r_FQ == null)
				{
					r_FQ = new(typeof(UnityEngine.KeyCode), "Q");
				}
				return r_FQ;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode R
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FR;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFR
		{
			get
			{
				if(r_FR == null)
				{
					r_FR = new(typeof(UnityEngine.KeyCode), "R");
				}
				return r_FR;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode S
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FS;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFS
		{
			get
			{
				if(r_FS == null)
				{
					r_FS = new(typeof(UnityEngine.KeyCode), "S");
				}
				return r_FS;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode T
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FT;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFT
		{
			get
			{
				if(r_FT == null)
				{
					r_FT = new(typeof(UnityEngine.KeyCode), "T");
				}
				return r_FT;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode U
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FU;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFU
		{
			get
			{
				if(r_FU == null)
				{
					r_FU = new(typeof(UnityEngine.KeyCode), "U");
				}
				return r_FU;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode V
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FV;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFV
		{
			get
			{
				if(r_FV == null)
				{
					r_FV = new(typeof(UnityEngine.KeyCode), "V");
				}
				return r_FV;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode W
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FW;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFW
		{
			get
			{
				if(r_FW == null)
				{
					r_FW = new(typeof(UnityEngine.KeyCode), "W");
				}
				return r_FW;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode X
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FX;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFX
		{
			get
			{
				if(r_FX == null)
				{
					r_FX = new(typeof(UnityEngine.KeyCode), "X");
				}
				return r_FX;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Y
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FY;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFY
		{
			get
			{
				if(r_FY == null)
				{
					r_FY = new(typeof(UnityEngine.KeyCode), "Y");
				}
				return r_FY;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Z
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FZ;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFZ
		{
			get
			{
				if(r_FZ == null)
				{
					r_FZ = new(typeof(UnityEngine.KeyCode), "Z");
				}
				return r_FZ;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode LeftCurlyBracket
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FLeftCurlyBracket;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFLeftCurlyBracket
		{
			get
			{
				if(r_FLeftCurlyBracket == null)
				{
					r_FLeftCurlyBracket = new(typeof(UnityEngine.KeyCode), "LeftCurlyBracket");
				}
				return r_FLeftCurlyBracket;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Pipe
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FPipe;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFPipe
		{
			get
			{
				if(r_FPipe == null)
				{
					r_FPipe = new(typeof(UnityEngine.KeyCode), "Pipe");
				}
				return r_FPipe;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode RightCurlyBracket
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FRightCurlyBracket;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFRightCurlyBracket
		{
			get
			{
				if(r_FRightCurlyBracket == null)
				{
					r_FRightCurlyBracket = new(typeof(UnityEngine.KeyCode), "RightCurlyBracket");
				}
				return r_FRightCurlyBracket;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Tilde
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FTilde;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFTilde
		{
			get
			{
				if(r_FTilde == null)
				{
					r_FTilde = new(typeof(UnityEngine.KeyCode), "Tilde");
				}
				return r_FTilde;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Numlock
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FNumlock;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFNumlock
		{
			get
			{
				if(r_FNumlock == null)
				{
					r_FNumlock = new(typeof(UnityEngine.KeyCode), "Numlock");
				}
				return r_FNumlock;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode CapsLock
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FCapsLock;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFCapsLock
		{
			get
			{
				if(r_FCapsLock == null)
				{
					r_FCapsLock = new(typeof(UnityEngine.KeyCode), "CapsLock");
				}
				return r_FCapsLock;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode ScrollLock
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FScrollLock;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFScrollLock
		{
			get
			{
				if(r_FScrollLock == null)
				{
					r_FScrollLock = new(typeof(UnityEngine.KeyCode), "ScrollLock");
				}
				return r_FScrollLock;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode RightShift
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FRightShift;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFRightShift
		{
			get
			{
				if(r_FRightShift == null)
				{
					r_FRightShift = new(typeof(UnityEngine.KeyCode), "RightShift");
				}
				return r_FRightShift;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode LeftShift
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FLeftShift;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFLeftShift
		{
			get
			{
				if(r_FLeftShift == null)
				{
					r_FLeftShift = new(typeof(UnityEngine.KeyCode), "LeftShift");
				}
				return r_FLeftShift;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode RightControl
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FRightControl;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFRightControl
		{
			get
			{
				if(r_FRightControl == null)
				{
					r_FRightControl = new(typeof(UnityEngine.KeyCode), "RightControl");
				}
				return r_FRightControl;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode LeftControl
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FLeftControl;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFLeftControl
		{
			get
			{
				if(r_FLeftControl == null)
				{
					r_FLeftControl = new(typeof(UnityEngine.KeyCode), "LeftControl");
				}
				return r_FLeftControl;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode RightAlt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FRightAlt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFRightAlt
		{
			get
			{
				if(r_FRightAlt == null)
				{
					r_FRightAlt = new(typeof(UnityEngine.KeyCode), "RightAlt");
				}
				return r_FRightAlt;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode LeftAlt
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FLeftAlt;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFLeftAlt
		{
			get
			{
				if(r_FLeftAlt == null)
				{
					r_FLeftAlt = new(typeof(UnityEngine.KeyCode), "LeftAlt");
				}
				return r_FLeftAlt;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode LeftMeta
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FLeftMeta;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFLeftMeta
		{
			get
			{
				if(r_FLeftMeta == null)
				{
					r_FLeftMeta = new(typeof(UnityEngine.KeyCode), "LeftMeta");
				}
				return r_FLeftMeta;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode LeftCommand
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FLeftCommand;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFLeftCommand
		{
			get
			{
				if(r_FLeftCommand == null)
				{
					r_FLeftCommand = new(typeof(UnityEngine.KeyCode), "LeftCommand");
				}
				return r_FLeftCommand;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode LeftApple
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FLeftApple;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFLeftApple
		{
			get
			{
				if(r_FLeftApple == null)
				{
					r_FLeftApple = new(typeof(UnityEngine.KeyCode), "LeftApple");
				}
				return r_FLeftApple;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode LeftWindows
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FLeftWindows;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFLeftWindows
		{
			get
			{
				if(r_FLeftWindows == null)
				{
					r_FLeftWindows = new(typeof(UnityEngine.KeyCode), "LeftWindows");
				}
				return r_FLeftWindows;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode RightMeta
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FRightMeta;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFRightMeta
		{
			get
			{
				if(r_FRightMeta == null)
				{
					r_FRightMeta = new(typeof(UnityEngine.KeyCode), "RightMeta");
				}
				return r_FRightMeta;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode RightCommand
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FRightCommand;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFRightCommand
		{
			get
			{
				if(r_FRightCommand == null)
				{
					r_FRightCommand = new(typeof(UnityEngine.KeyCode), "RightCommand");
				}
				return r_FRightCommand;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode RightApple
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FRightApple;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFRightApple
		{
			get
			{
				if(r_FRightApple == null)
				{
					r_FRightApple = new(typeof(UnityEngine.KeyCode), "RightApple");
				}
				return r_FRightApple;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode RightWindows
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FRightWindows;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFRightWindows
		{
			get
			{
				if(r_FRightWindows == null)
				{
					r_FRightWindows = new(typeof(UnityEngine.KeyCode), "RightWindows");
				}
				return r_FRightWindows;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode AltGr
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FAltGr;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFAltGr
		{
			get
			{
				if(r_FAltGr == null)
				{
					r_FAltGr = new(typeof(UnityEngine.KeyCode), "AltGr");
				}
				return r_FAltGr;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Help
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FHelp;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFHelp
		{
			get
			{
				if(r_FHelp == null)
				{
					r_FHelp = new(typeof(UnityEngine.KeyCode), "Help");
				}
				return r_FHelp;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Print
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FPrint;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFPrint
		{
			get
			{
				if(r_FPrint == null)
				{
					r_FPrint = new(typeof(UnityEngine.KeyCode), "Print");
				}
				return r_FPrint;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode SysReq
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FSysReq;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFSysReq
		{
			get
			{
				if(r_FSysReq == null)
				{
					r_FSysReq = new(typeof(UnityEngine.KeyCode), "SysReq");
				}
				return r_FSysReq;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Break
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FBreak;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFBreak
		{
			get
			{
				if(r_FBreak == null)
				{
					r_FBreak = new(typeof(UnityEngine.KeyCode), "Break");
				}
				return r_FBreak;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Menu
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FMenu;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFMenu
		{
			get
			{
				if(r_FMenu == null)
				{
					r_FMenu = new(typeof(UnityEngine.KeyCode), "Menu");
				}
				return r_FMenu;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Mouse0
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FMouse0;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFMouse0
		{
			get
			{
				if(r_FMouse0 == null)
				{
					r_FMouse0 = new(typeof(UnityEngine.KeyCode), "Mouse0");
				}
				return r_FMouse0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Mouse1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FMouse1;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFMouse1
		{
			get
			{
				if(r_FMouse1 == null)
				{
					r_FMouse1 = new(typeof(UnityEngine.KeyCode), "Mouse1");
				}
				return r_FMouse1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Mouse2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FMouse2;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFMouse2
		{
			get
			{
				if(r_FMouse2 == null)
				{
					r_FMouse2 = new(typeof(UnityEngine.KeyCode), "Mouse2");
				}
				return r_FMouse2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Mouse3
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FMouse3;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFMouse3
		{
			get
			{
				if(r_FMouse3 == null)
				{
					r_FMouse3 = new(typeof(UnityEngine.KeyCode), "Mouse3");
				}
				return r_FMouse3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Mouse4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FMouse4;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFMouse4
		{
			get
			{
				if(r_FMouse4 == null)
				{
					r_FMouse4 = new(typeof(UnityEngine.KeyCode), "Mouse4");
				}
				return r_FMouse4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Mouse5
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FMouse5;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFMouse5
		{
			get
			{
				if(r_FMouse5 == null)
				{
					r_FMouse5 = new(typeof(UnityEngine.KeyCode), "Mouse5");
				}
				return r_FMouse5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Mouse6
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FMouse6;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFMouse6
		{
			get
			{
				if(r_FMouse6 == null)
				{
					r_FMouse6 = new(typeof(UnityEngine.KeyCode), "Mouse6");
				}
				return r_FMouse6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton0
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystickButton0;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystickButton0
		{
			get
			{
				if(r_FJoystickButton0 == null)
				{
					r_FJoystickButton0 = new(typeof(UnityEngine.KeyCode), "JoystickButton0");
				}
				return r_FJoystickButton0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystickButton1;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystickButton1
		{
			get
			{
				if(r_FJoystickButton1 == null)
				{
					r_FJoystickButton1 = new(typeof(UnityEngine.KeyCode), "JoystickButton1");
				}
				return r_FJoystickButton1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystickButton2;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystickButton2
		{
			get
			{
				if(r_FJoystickButton2 == null)
				{
					r_FJoystickButton2 = new(typeof(UnityEngine.KeyCode), "JoystickButton2");
				}
				return r_FJoystickButton2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton3
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystickButton3;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystickButton3
		{
			get
			{
				if(r_FJoystickButton3 == null)
				{
					r_FJoystickButton3 = new(typeof(UnityEngine.KeyCode), "JoystickButton3");
				}
				return r_FJoystickButton3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystickButton4;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystickButton4
		{
			get
			{
				if(r_FJoystickButton4 == null)
				{
					r_FJoystickButton4 = new(typeof(UnityEngine.KeyCode), "JoystickButton4");
				}
				return r_FJoystickButton4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton5
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystickButton5;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystickButton5
		{
			get
			{
				if(r_FJoystickButton5 == null)
				{
					r_FJoystickButton5 = new(typeof(UnityEngine.KeyCode), "JoystickButton5");
				}
				return r_FJoystickButton5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton6
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystickButton6;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystickButton6
		{
			get
			{
				if(r_FJoystickButton6 == null)
				{
					r_FJoystickButton6 = new(typeof(UnityEngine.KeyCode), "JoystickButton6");
				}
				return r_FJoystickButton6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton7
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystickButton7;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystickButton7
		{
			get
			{
				if(r_FJoystickButton7 == null)
				{
					r_FJoystickButton7 = new(typeof(UnityEngine.KeyCode), "JoystickButton7");
				}
				return r_FJoystickButton7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystickButton8;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystickButton8
		{
			get
			{
				if(r_FJoystickButton8 == null)
				{
					r_FJoystickButton8 = new(typeof(UnityEngine.KeyCode), "JoystickButton8");
				}
				return r_FJoystickButton8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton9
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystickButton9;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystickButton9
		{
			get
			{
				if(r_FJoystickButton9 == null)
				{
					r_FJoystickButton9 = new(typeof(UnityEngine.KeyCode), "JoystickButton9");
				}
				return r_FJoystickButton9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton10
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystickButton10;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystickButton10
		{
			get
			{
				if(r_FJoystickButton10 == null)
				{
					r_FJoystickButton10 = new(typeof(UnityEngine.KeyCode), "JoystickButton10");
				}
				return r_FJoystickButton10;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton11
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystickButton11;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystickButton11
		{
			get
			{
				if(r_FJoystickButton11 == null)
				{
					r_FJoystickButton11 = new(typeof(UnityEngine.KeyCode), "JoystickButton11");
				}
				return r_FJoystickButton11;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton12
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystickButton12;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystickButton12
		{
			get
			{
				if(r_FJoystickButton12 == null)
				{
					r_FJoystickButton12 = new(typeof(UnityEngine.KeyCode), "JoystickButton12");
				}
				return r_FJoystickButton12;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton13
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystickButton13;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystickButton13
		{
			get
			{
				if(r_FJoystickButton13 == null)
				{
					r_FJoystickButton13 = new(typeof(UnityEngine.KeyCode), "JoystickButton13");
				}
				return r_FJoystickButton13;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton14
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystickButton14;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystickButton14
		{
			get
			{
				if(r_FJoystickButton14 == null)
				{
					r_FJoystickButton14 = new(typeof(UnityEngine.KeyCode), "JoystickButton14");
				}
				return r_FJoystickButton14;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton15
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystickButton15;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystickButton15
		{
			get
			{
				if(r_FJoystickButton15 == null)
				{
					r_FJoystickButton15 = new(typeof(UnityEngine.KeyCode), "JoystickButton15");
				}
				return r_FJoystickButton15;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton16
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystickButton16;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystickButton16
		{
			get
			{
				if(r_FJoystickButton16 == null)
				{
					r_FJoystickButton16 = new(typeof(UnityEngine.KeyCode), "JoystickButton16");
				}
				return r_FJoystickButton16;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton17
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystickButton17;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystickButton17
		{
			get
			{
				if(r_FJoystickButton17 == null)
				{
					r_FJoystickButton17 = new(typeof(UnityEngine.KeyCode), "JoystickButton17");
				}
				return r_FJoystickButton17;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton18
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystickButton18;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystickButton18
		{
			get
			{
				if(r_FJoystickButton18 == null)
				{
					r_FJoystickButton18 = new(typeof(UnityEngine.KeyCode), "JoystickButton18");
				}
				return r_FJoystickButton18;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode JoystickButton19
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystickButton19;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystickButton19
		{
			get
			{
				if(r_FJoystickButton19 == null)
				{
					r_FJoystickButton19 = new(typeof(UnityEngine.KeyCode), "JoystickButton19");
				}
				return r_FJoystickButton19;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button0
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick1Button0;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick1Button0
		{
			get
			{
				if(r_FJoystick1Button0 == null)
				{
					r_FJoystick1Button0 = new(typeof(UnityEngine.KeyCode), "Joystick1Button0");
				}
				return r_FJoystick1Button0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick1Button1;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick1Button1
		{
			get
			{
				if(r_FJoystick1Button1 == null)
				{
					r_FJoystick1Button1 = new(typeof(UnityEngine.KeyCode), "Joystick1Button1");
				}
				return r_FJoystick1Button1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick1Button2;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick1Button2
		{
			get
			{
				if(r_FJoystick1Button2 == null)
				{
					r_FJoystick1Button2 = new(typeof(UnityEngine.KeyCode), "Joystick1Button2");
				}
				return r_FJoystick1Button2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button3
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick1Button3;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick1Button3
		{
			get
			{
				if(r_FJoystick1Button3 == null)
				{
					r_FJoystick1Button3 = new(typeof(UnityEngine.KeyCode), "Joystick1Button3");
				}
				return r_FJoystick1Button3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick1Button4;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick1Button4
		{
			get
			{
				if(r_FJoystick1Button4 == null)
				{
					r_FJoystick1Button4 = new(typeof(UnityEngine.KeyCode), "Joystick1Button4");
				}
				return r_FJoystick1Button4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button5
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick1Button5;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick1Button5
		{
			get
			{
				if(r_FJoystick1Button5 == null)
				{
					r_FJoystick1Button5 = new(typeof(UnityEngine.KeyCode), "Joystick1Button5");
				}
				return r_FJoystick1Button5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button6
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick1Button6;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick1Button6
		{
			get
			{
				if(r_FJoystick1Button6 == null)
				{
					r_FJoystick1Button6 = new(typeof(UnityEngine.KeyCode), "Joystick1Button6");
				}
				return r_FJoystick1Button6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button7
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick1Button7;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick1Button7
		{
			get
			{
				if(r_FJoystick1Button7 == null)
				{
					r_FJoystick1Button7 = new(typeof(UnityEngine.KeyCode), "Joystick1Button7");
				}
				return r_FJoystick1Button7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick1Button8;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick1Button8
		{
			get
			{
				if(r_FJoystick1Button8 == null)
				{
					r_FJoystick1Button8 = new(typeof(UnityEngine.KeyCode), "Joystick1Button8");
				}
				return r_FJoystick1Button8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button9
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick1Button9;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick1Button9
		{
			get
			{
				if(r_FJoystick1Button9 == null)
				{
					r_FJoystick1Button9 = new(typeof(UnityEngine.KeyCode), "Joystick1Button9");
				}
				return r_FJoystick1Button9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button10
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick1Button10;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick1Button10
		{
			get
			{
				if(r_FJoystick1Button10 == null)
				{
					r_FJoystick1Button10 = new(typeof(UnityEngine.KeyCode), "Joystick1Button10");
				}
				return r_FJoystick1Button10;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button11
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick1Button11;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick1Button11
		{
			get
			{
				if(r_FJoystick1Button11 == null)
				{
					r_FJoystick1Button11 = new(typeof(UnityEngine.KeyCode), "Joystick1Button11");
				}
				return r_FJoystick1Button11;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button12
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick1Button12;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick1Button12
		{
			get
			{
				if(r_FJoystick1Button12 == null)
				{
					r_FJoystick1Button12 = new(typeof(UnityEngine.KeyCode), "Joystick1Button12");
				}
				return r_FJoystick1Button12;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button13
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick1Button13;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick1Button13
		{
			get
			{
				if(r_FJoystick1Button13 == null)
				{
					r_FJoystick1Button13 = new(typeof(UnityEngine.KeyCode), "Joystick1Button13");
				}
				return r_FJoystick1Button13;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button14
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick1Button14;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick1Button14
		{
			get
			{
				if(r_FJoystick1Button14 == null)
				{
					r_FJoystick1Button14 = new(typeof(UnityEngine.KeyCode), "Joystick1Button14");
				}
				return r_FJoystick1Button14;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button15
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick1Button15;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick1Button15
		{
			get
			{
				if(r_FJoystick1Button15 == null)
				{
					r_FJoystick1Button15 = new(typeof(UnityEngine.KeyCode), "Joystick1Button15");
				}
				return r_FJoystick1Button15;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button16
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick1Button16;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick1Button16
		{
			get
			{
				if(r_FJoystick1Button16 == null)
				{
					r_FJoystick1Button16 = new(typeof(UnityEngine.KeyCode), "Joystick1Button16");
				}
				return r_FJoystick1Button16;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button17
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick1Button17;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick1Button17
		{
			get
			{
				if(r_FJoystick1Button17 == null)
				{
					r_FJoystick1Button17 = new(typeof(UnityEngine.KeyCode), "Joystick1Button17");
				}
				return r_FJoystick1Button17;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button18
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick1Button18;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick1Button18
		{
			get
			{
				if(r_FJoystick1Button18 == null)
				{
					r_FJoystick1Button18 = new(typeof(UnityEngine.KeyCode), "Joystick1Button18");
				}
				return r_FJoystick1Button18;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick1Button19
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick1Button19;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick1Button19
		{
			get
			{
				if(r_FJoystick1Button19 == null)
				{
					r_FJoystick1Button19 = new(typeof(UnityEngine.KeyCode), "Joystick1Button19");
				}
				return r_FJoystick1Button19;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button0
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick2Button0;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick2Button0
		{
			get
			{
				if(r_FJoystick2Button0 == null)
				{
					r_FJoystick2Button0 = new(typeof(UnityEngine.KeyCode), "Joystick2Button0");
				}
				return r_FJoystick2Button0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick2Button1;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick2Button1
		{
			get
			{
				if(r_FJoystick2Button1 == null)
				{
					r_FJoystick2Button1 = new(typeof(UnityEngine.KeyCode), "Joystick2Button1");
				}
				return r_FJoystick2Button1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick2Button2;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick2Button2
		{
			get
			{
				if(r_FJoystick2Button2 == null)
				{
					r_FJoystick2Button2 = new(typeof(UnityEngine.KeyCode), "Joystick2Button2");
				}
				return r_FJoystick2Button2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button3
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick2Button3;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick2Button3
		{
			get
			{
				if(r_FJoystick2Button3 == null)
				{
					r_FJoystick2Button3 = new(typeof(UnityEngine.KeyCode), "Joystick2Button3");
				}
				return r_FJoystick2Button3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick2Button4;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick2Button4
		{
			get
			{
				if(r_FJoystick2Button4 == null)
				{
					r_FJoystick2Button4 = new(typeof(UnityEngine.KeyCode), "Joystick2Button4");
				}
				return r_FJoystick2Button4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button5
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick2Button5;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick2Button5
		{
			get
			{
				if(r_FJoystick2Button5 == null)
				{
					r_FJoystick2Button5 = new(typeof(UnityEngine.KeyCode), "Joystick2Button5");
				}
				return r_FJoystick2Button5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button6
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick2Button6;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick2Button6
		{
			get
			{
				if(r_FJoystick2Button6 == null)
				{
					r_FJoystick2Button6 = new(typeof(UnityEngine.KeyCode), "Joystick2Button6");
				}
				return r_FJoystick2Button6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button7
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick2Button7;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick2Button7
		{
			get
			{
				if(r_FJoystick2Button7 == null)
				{
					r_FJoystick2Button7 = new(typeof(UnityEngine.KeyCode), "Joystick2Button7");
				}
				return r_FJoystick2Button7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick2Button8;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick2Button8
		{
			get
			{
				if(r_FJoystick2Button8 == null)
				{
					r_FJoystick2Button8 = new(typeof(UnityEngine.KeyCode), "Joystick2Button8");
				}
				return r_FJoystick2Button8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button9
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick2Button9;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick2Button9
		{
			get
			{
				if(r_FJoystick2Button9 == null)
				{
					r_FJoystick2Button9 = new(typeof(UnityEngine.KeyCode), "Joystick2Button9");
				}
				return r_FJoystick2Button9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button10
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick2Button10;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick2Button10
		{
			get
			{
				if(r_FJoystick2Button10 == null)
				{
					r_FJoystick2Button10 = new(typeof(UnityEngine.KeyCode), "Joystick2Button10");
				}
				return r_FJoystick2Button10;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button11
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick2Button11;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick2Button11
		{
			get
			{
				if(r_FJoystick2Button11 == null)
				{
					r_FJoystick2Button11 = new(typeof(UnityEngine.KeyCode), "Joystick2Button11");
				}
				return r_FJoystick2Button11;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button12
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick2Button12;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick2Button12
		{
			get
			{
				if(r_FJoystick2Button12 == null)
				{
					r_FJoystick2Button12 = new(typeof(UnityEngine.KeyCode), "Joystick2Button12");
				}
				return r_FJoystick2Button12;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button13
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick2Button13;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick2Button13
		{
			get
			{
				if(r_FJoystick2Button13 == null)
				{
					r_FJoystick2Button13 = new(typeof(UnityEngine.KeyCode), "Joystick2Button13");
				}
				return r_FJoystick2Button13;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button14
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick2Button14;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick2Button14
		{
			get
			{
				if(r_FJoystick2Button14 == null)
				{
					r_FJoystick2Button14 = new(typeof(UnityEngine.KeyCode), "Joystick2Button14");
				}
				return r_FJoystick2Button14;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button15
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick2Button15;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick2Button15
		{
			get
			{
				if(r_FJoystick2Button15 == null)
				{
					r_FJoystick2Button15 = new(typeof(UnityEngine.KeyCode), "Joystick2Button15");
				}
				return r_FJoystick2Button15;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button16
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick2Button16;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick2Button16
		{
			get
			{
				if(r_FJoystick2Button16 == null)
				{
					r_FJoystick2Button16 = new(typeof(UnityEngine.KeyCode), "Joystick2Button16");
				}
				return r_FJoystick2Button16;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button17
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick2Button17;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick2Button17
		{
			get
			{
				if(r_FJoystick2Button17 == null)
				{
					r_FJoystick2Button17 = new(typeof(UnityEngine.KeyCode), "Joystick2Button17");
				}
				return r_FJoystick2Button17;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button18
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick2Button18;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick2Button18
		{
			get
			{
				if(r_FJoystick2Button18 == null)
				{
					r_FJoystick2Button18 = new(typeof(UnityEngine.KeyCode), "Joystick2Button18");
				}
				return r_FJoystick2Button18;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick2Button19
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick2Button19;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick2Button19
		{
			get
			{
				if(r_FJoystick2Button19 == null)
				{
					r_FJoystick2Button19 = new(typeof(UnityEngine.KeyCode), "Joystick2Button19");
				}
				return r_FJoystick2Button19;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button0
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick3Button0;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick3Button0
		{
			get
			{
				if(r_FJoystick3Button0 == null)
				{
					r_FJoystick3Button0 = new(typeof(UnityEngine.KeyCode), "Joystick3Button0");
				}
				return r_FJoystick3Button0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick3Button1;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick3Button1
		{
			get
			{
				if(r_FJoystick3Button1 == null)
				{
					r_FJoystick3Button1 = new(typeof(UnityEngine.KeyCode), "Joystick3Button1");
				}
				return r_FJoystick3Button1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick3Button2;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick3Button2
		{
			get
			{
				if(r_FJoystick3Button2 == null)
				{
					r_FJoystick3Button2 = new(typeof(UnityEngine.KeyCode), "Joystick3Button2");
				}
				return r_FJoystick3Button2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button3
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick3Button3;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick3Button3
		{
			get
			{
				if(r_FJoystick3Button3 == null)
				{
					r_FJoystick3Button3 = new(typeof(UnityEngine.KeyCode), "Joystick3Button3");
				}
				return r_FJoystick3Button3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick3Button4;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick3Button4
		{
			get
			{
				if(r_FJoystick3Button4 == null)
				{
					r_FJoystick3Button4 = new(typeof(UnityEngine.KeyCode), "Joystick3Button4");
				}
				return r_FJoystick3Button4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button5
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick3Button5;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick3Button5
		{
			get
			{
				if(r_FJoystick3Button5 == null)
				{
					r_FJoystick3Button5 = new(typeof(UnityEngine.KeyCode), "Joystick3Button5");
				}
				return r_FJoystick3Button5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button6
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick3Button6;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick3Button6
		{
			get
			{
				if(r_FJoystick3Button6 == null)
				{
					r_FJoystick3Button6 = new(typeof(UnityEngine.KeyCode), "Joystick3Button6");
				}
				return r_FJoystick3Button6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button7
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick3Button7;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick3Button7
		{
			get
			{
				if(r_FJoystick3Button7 == null)
				{
					r_FJoystick3Button7 = new(typeof(UnityEngine.KeyCode), "Joystick3Button7");
				}
				return r_FJoystick3Button7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick3Button8;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick3Button8
		{
			get
			{
				if(r_FJoystick3Button8 == null)
				{
					r_FJoystick3Button8 = new(typeof(UnityEngine.KeyCode), "Joystick3Button8");
				}
				return r_FJoystick3Button8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button9
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick3Button9;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick3Button9
		{
			get
			{
				if(r_FJoystick3Button9 == null)
				{
					r_FJoystick3Button9 = new(typeof(UnityEngine.KeyCode), "Joystick3Button9");
				}
				return r_FJoystick3Button9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button10
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick3Button10;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick3Button10
		{
			get
			{
				if(r_FJoystick3Button10 == null)
				{
					r_FJoystick3Button10 = new(typeof(UnityEngine.KeyCode), "Joystick3Button10");
				}
				return r_FJoystick3Button10;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button11
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick3Button11;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick3Button11
		{
			get
			{
				if(r_FJoystick3Button11 == null)
				{
					r_FJoystick3Button11 = new(typeof(UnityEngine.KeyCode), "Joystick3Button11");
				}
				return r_FJoystick3Button11;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button12
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick3Button12;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick3Button12
		{
			get
			{
				if(r_FJoystick3Button12 == null)
				{
					r_FJoystick3Button12 = new(typeof(UnityEngine.KeyCode), "Joystick3Button12");
				}
				return r_FJoystick3Button12;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button13
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick3Button13;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick3Button13
		{
			get
			{
				if(r_FJoystick3Button13 == null)
				{
					r_FJoystick3Button13 = new(typeof(UnityEngine.KeyCode), "Joystick3Button13");
				}
				return r_FJoystick3Button13;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button14
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick3Button14;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick3Button14
		{
			get
			{
				if(r_FJoystick3Button14 == null)
				{
					r_FJoystick3Button14 = new(typeof(UnityEngine.KeyCode), "Joystick3Button14");
				}
				return r_FJoystick3Button14;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button15
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick3Button15;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick3Button15
		{
			get
			{
				if(r_FJoystick3Button15 == null)
				{
					r_FJoystick3Button15 = new(typeof(UnityEngine.KeyCode), "Joystick3Button15");
				}
				return r_FJoystick3Button15;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button16
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick3Button16;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick3Button16
		{
			get
			{
				if(r_FJoystick3Button16 == null)
				{
					r_FJoystick3Button16 = new(typeof(UnityEngine.KeyCode), "Joystick3Button16");
				}
				return r_FJoystick3Button16;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button17
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick3Button17;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick3Button17
		{
			get
			{
				if(r_FJoystick3Button17 == null)
				{
					r_FJoystick3Button17 = new(typeof(UnityEngine.KeyCode), "Joystick3Button17");
				}
				return r_FJoystick3Button17;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button18
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick3Button18;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick3Button18
		{
			get
			{
				if(r_FJoystick3Button18 == null)
				{
					r_FJoystick3Button18 = new(typeof(UnityEngine.KeyCode), "Joystick3Button18");
				}
				return r_FJoystick3Button18;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick3Button19
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick3Button19;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick3Button19
		{
			get
			{
				if(r_FJoystick3Button19 == null)
				{
					r_FJoystick3Button19 = new(typeof(UnityEngine.KeyCode), "Joystick3Button19");
				}
				return r_FJoystick3Button19;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button0
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick4Button0;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick4Button0
		{
			get
			{
				if(r_FJoystick4Button0 == null)
				{
					r_FJoystick4Button0 = new(typeof(UnityEngine.KeyCode), "Joystick4Button0");
				}
				return r_FJoystick4Button0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick4Button1;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick4Button1
		{
			get
			{
				if(r_FJoystick4Button1 == null)
				{
					r_FJoystick4Button1 = new(typeof(UnityEngine.KeyCode), "Joystick4Button1");
				}
				return r_FJoystick4Button1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick4Button2;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick4Button2
		{
			get
			{
				if(r_FJoystick4Button2 == null)
				{
					r_FJoystick4Button2 = new(typeof(UnityEngine.KeyCode), "Joystick4Button2");
				}
				return r_FJoystick4Button2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button3
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick4Button3;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick4Button3
		{
			get
			{
				if(r_FJoystick4Button3 == null)
				{
					r_FJoystick4Button3 = new(typeof(UnityEngine.KeyCode), "Joystick4Button3");
				}
				return r_FJoystick4Button3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick4Button4;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick4Button4
		{
			get
			{
				if(r_FJoystick4Button4 == null)
				{
					r_FJoystick4Button4 = new(typeof(UnityEngine.KeyCode), "Joystick4Button4");
				}
				return r_FJoystick4Button4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button5
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick4Button5;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick4Button5
		{
			get
			{
				if(r_FJoystick4Button5 == null)
				{
					r_FJoystick4Button5 = new(typeof(UnityEngine.KeyCode), "Joystick4Button5");
				}
				return r_FJoystick4Button5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button6
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick4Button6;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick4Button6
		{
			get
			{
				if(r_FJoystick4Button6 == null)
				{
					r_FJoystick4Button6 = new(typeof(UnityEngine.KeyCode), "Joystick4Button6");
				}
				return r_FJoystick4Button6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button7
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick4Button7;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick4Button7
		{
			get
			{
				if(r_FJoystick4Button7 == null)
				{
					r_FJoystick4Button7 = new(typeof(UnityEngine.KeyCode), "Joystick4Button7");
				}
				return r_FJoystick4Button7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick4Button8;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick4Button8
		{
			get
			{
				if(r_FJoystick4Button8 == null)
				{
					r_FJoystick4Button8 = new(typeof(UnityEngine.KeyCode), "Joystick4Button8");
				}
				return r_FJoystick4Button8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button9
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick4Button9;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick4Button9
		{
			get
			{
				if(r_FJoystick4Button9 == null)
				{
					r_FJoystick4Button9 = new(typeof(UnityEngine.KeyCode), "Joystick4Button9");
				}
				return r_FJoystick4Button9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button10
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick4Button10;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick4Button10
		{
			get
			{
				if(r_FJoystick4Button10 == null)
				{
					r_FJoystick4Button10 = new(typeof(UnityEngine.KeyCode), "Joystick4Button10");
				}
				return r_FJoystick4Button10;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button11
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick4Button11;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick4Button11
		{
			get
			{
				if(r_FJoystick4Button11 == null)
				{
					r_FJoystick4Button11 = new(typeof(UnityEngine.KeyCode), "Joystick4Button11");
				}
				return r_FJoystick4Button11;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button12
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick4Button12;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick4Button12
		{
			get
			{
				if(r_FJoystick4Button12 == null)
				{
					r_FJoystick4Button12 = new(typeof(UnityEngine.KeyCode), "Joystick4Button12");
				}
				return r_FJoystick4Button12;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button13
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick4Button13;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick4Button13
		{
			get
			{
				if(r_FJoystick4Button13 == null)
				{
					r_FJoystick4Button13 = new(typeof(UnityEngine.KeyCode), "Joystick4Button13");
				}
				return r_FJoystick4Button13;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button14
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick4Button14;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick4Button14
		{
			get
			{
				if(r_FJoystick4Button14 == null)
				{
					r_FJoystick4Button14 = new(typeof(UnityEngine.KeyCode), "Joystick4Button14");
				}
				return r_FJoystick4Button14;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button15
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick4Button15;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick4Button15
		{
			get
			{
				if(r_FJoystick4Button15 == null)
				{
					r_FJoystick4Button15 = new(typeof(UnityEngine.KeyCode), "Joystick4Button15");
				}
				return r_FJoystick4Button15;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button16
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick4Button16;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick4Button16
		{
			get
			{
				if(r_FJoystick4Button16 == null)
				{
					r_FJoystick4Button16 = new(typeof(UnityEngine.KeyCode), "Joystick4Button16");
				}
				return r_FJoystick4Button16;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button17
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick4Button17;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick4Button17
		{
			get
			{
				if(r_FJoystick4Button17 == null)
				{
					r_FJoystick4Button17 = new(typeof(UnityEngine.KeyCode), "Joystick4Button17");
				}
				return r_FJoystick4Button17;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button18
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick4Button18;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick4Button18
		{
			get
			{
				if(r_FJoystick4Button18 == null)
				{
					r_FJoystick4Button18 = new(typeof(UnityEngine.KeyCode), "Joystick4Button18");
				}
				return r_FJoystick4Button18;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick4Button19
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick4Button19;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick4Button19
		{
			get
			{
				if(r_FJoystick4Button19 == null)
				{
					r_FJoystick4Button19 = new(typeof(UnityEngine.KeyCode), "Joystick4Button19");
				}
				return r_FJoystick4Button19;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button0
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick5Button0;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick5Button0
		{
			get
			{
				if(r_FJoystick5Button0 == null)
				{
					r_FJoystick5Button0 = new(typeof(UnityEngine.KeyCode), "Joystick5Button0");
				}
				return r_FJoystick5Button0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick5Button1;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick5Button1
		{
			get
			{
				if(r_FJoystick5Button1 == null)
				{
					r_FJoystick5Button1 = new(typeof(UnityEngine.KeyCode), "Joystick5Button1");
				}
				return r_FJoystick5Button1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick5Button2;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick5Button2
		{
			get
			{
				if(r_FJoystick5Button2 == null)
				{
					r_FJoystick5Button2 = new(typeof(UnityEngine.KeyCode), "Joystick5Button2");
				}
				return r_FJoystick5Button2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button3
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick5Button3;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick5Button3
		{
			get
			{
				if(r_FJoystick5Button3 == null)
				{
					r_FJoystick5Button3 = new(typeof(UnityEngine.KeyCode), "Joystick5Button3");
				}
				return r_FJoystick5Button3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick5Button4;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick5Button4
		{
			get
			{
				if(r_FJoystick5Button4 == null)
				{
					r_FJoystick5Button4 = new(typeof(UnityEngine.KeyCode), "Joystick5Button4");
				}
				return r_FJoystick5Button4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button5
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick5Button5;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick5Button5
		{
			get
			{
				if(r_FJoystick5Button5 == null)
				{
					r_FJoystick5Button5 = new(typeof(UnityEngine.KeyCode), "Joystick5Button5");
				}
				return r_FJoystick5Button5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button6
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick5Button6;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick5Button6
		{
			get
			{
				if(r_FJoystick5Button6 == null)
				{
					r_FJoystick5Button6 = new(typeof(UnityEngine.KeyCode), "Joystick5Button6");
				}
				return r_FJoystick5Button6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button7
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick5Button7;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick5Button7
		{
			get
			{
				if(r_FJoystick5Button7 == null)
				{
					r_FJoystick5Button7 = new(typeof(UnityEngine.KeyCode), "Joystick5Button7");
				}
				return r_FJoystick5Button7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick5Button8;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick5Button8
		{
			get
			{
				if(r_FJoystick5Button8 == null)
				{
					r_FJoystick5Button8 = new(typeof(UnityEngine.KeyCode), "Joystick5Button8");
				}
				return r_FJoystick5Button8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button9
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick5Button9;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick5Button9
		{
			get
			{
				if(r_FJoystick5Button9 == null)
				{
					r_FJoystick5Button9 = new(typeof(UnityEngine.KeyCode), "Joystick5Button9");
				}
				return r_FJoystick5Button9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button10
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick5Button10;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick5Button10
		{
			get
			{
				if(r_FJoystick5Button10 == null)
				{
					r_FJoystick5Button10 = new(typeof(UnityEngine.KeyCode), "Joystick5Button10");
				}
				return r_FJoystick5Button10;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button11
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick5Button11;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick5Button11
		{
			get
			{
				if(r_FJoystick5Button11 == null)
				{
					r_FJoystick5Button11 = new(typeof(UnityEngine.KeyCode), "Joystick5Button11");
				}
				return r_FJoystick5Button11;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button12
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick5Button12;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick5Button12
		{
			get
			{
				if(r_FJoystick5Button12 == null)
				{
					r_FJoystick5Button12 = new(typeof(UnityEngine.KeyCode), "Joystick5Button12");
				}
				return r_FJoystick5Button12;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button13
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick5Button13;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick5Button13
		{
			get
			{
				if(r_FJoystick5Button13 == null)
				{
					r_FJoystick5Button13 = new(typeof(UnityEngine.KeyCode), "Joystick5Button13");
				}
				return r_FJoystick5Button13;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button14
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick5Button14;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick5Button14
		{
			get
			{
				if(r_FJoystick5Button14 == null)
				{
					r_FJoystick5Button14 = new(typeof(UnityEngine.KeyCode), "Joystick5Button14");
				}
				return r_FJoystick5Button14;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button15
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick5Button15;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick5Button15
		{
			get
			{
				if(r_FJoystick5Button15 == null)
				{
					r_FJoystick5Button15 = new(typeof(UnityEngine.KeyCode), "Joystick5Button15");
				}
				return r_FJoystick5Button15;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button16
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick5Button16;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick5Button16
		{
			get
			{
				if(r_FJoystick5Button16 == null)
				{
					r_FJoystick5Button16 = new(typeof(UnityEngine.KeyCode), "Joystick5Button16");
				}
				return r_FJoystick5Button16;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button17
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick5Button17;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick5Button17
		{
			get
			{
				if(r_FJoystick5Button17 == null)
				{
					r_FJoystick5Button17 = new(typeof(UnityEngine.KeyCode), "Joystick5Button17");
				}
				return r_FJoystick5Button17;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button18
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick5Button18;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick5Button18
		{
			get
			{
				if(r_FJoystick5Button18 == null)
				{
					r_FJoystick5Button18 = new(typeof(UnityEngine.KeyCode), "Joystick5Button18");
				}
				return r_FJoystick5Button18;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick5Button19
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick5Button19;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick5Button19
		{
			get
			{
				if(r_FJoystick5Button19 == null)
				{
					r_FJoystick5Button19 = new(typeof(UnityEngine.KeyCode), "Joystick5Button19");
				}
				return r_FJoystick5Button19;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button0
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick6Button0;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick6Button0
		{
			get
			{
				if(r_FJoystick6Button0 == null)
				{
					r_FJoystick6Button0 = new(typeof(UnityEngine.KeyCode), "Joystick6Button0");
				}
				return r_FJoystick6Button0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick6Button1;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick6Button1
		{
			get
			{
				if(r_FJoystick6Button1 == null)
				{
					r_FJoystick6Button1 = new(typeof(UnityEngine.KeyCode), "Joystick6Button1");
				}
				return r_FJoystick6Button1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick6Button2;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick6Button2
		{
			get
			{
				if(r_FJoystick6Button2 == null)
				{
					r_FJoystick6Button2 = new(typeof(UnityEngine.KeyCode), "Joystick6Button2");
				}
				return r_FJoystick6Button2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button3
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick6Button3;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick6Button3
		{
			get
			{
				if(r_FJoystick6Button3 == null)
				{
					r_FJoystick6Button3 = new(typeof(UnityEngine.KeyCode), "Joystick6Button3");
				}
				return r_FJoystick6Button3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick6Button4;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick6Button4
		{
			get
			{
				if(r_FJoystick6Button4 == null)
				{
					r_FJoystick6Button4 = new(typeof(UnityEngine.KeyCode), "Joystick6Button4");
				}
				return r_FJoystick6Button4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button5
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick6Button5;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick6Button5
		{
			get
			{
				if(r_FJoystick6Button5 == null)
				{
					r_FJoystick6Button5 = new(typeof(UnityEngine.KeyCode), "Joystick6Button5");
				}
				return r_FJoystick6Button5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button6
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick6Button6;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick6Button6
		{
			get
			{
				if(r_FJoystick6Button6 == null)
				{
					r_FJoystick6Button6 = new(typeof(UnityEngine.KeyCode), "Joystick6Button6");
				}
				return r_FJoystick6Button6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button7
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick6Button7;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick6Button7
		{
			get
			{
				if(r_FJoystick6Button7 == null)
				{
					r_FJoystick6Button7 = new(typeof(UnityEngine.KeyCode), "Joystick6Button7");
				}
				return r_FJoystick6Button7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick6Button8;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick6Button8
		{
			get
			{
				if(r_FJoystick6Button8 == null)
				{
					r_FJoystick6Button8 = new(typeof(UnityEngine.KeyCode), "Joystick6Button8");
				}
				return r_FJoystick6Button8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button9
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick6Button9;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick6Button9
		{
			get
			{
				if(r_FJoystick6Button9 == null)
				{
					r_FJoystick6Button9 = new(typeof(UnityEngine.KeyCode), "Joystick6Button9");
				}
				return r_FJoystick6Button9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button10
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick6Button10;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick6Button10
		{
			get
			{
				if(r_FJoystick6Button10 == null)
				{
					r_FJoystick6Button10 = new(typeof(UnityEngine.KeyCode), "Joystick6Button10");
				}
				return r_FJoystick6Button10;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button11
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick6Button11;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick6Button11
		{
			get
			{
				if(r_FJoystick6Button11 == null)
				{
					r_FJoystick6Button11 = new(typeof(UnityEngine.KeyCode), "Joystick6Button11");
				}
				return r_FJoystick6Button11;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button12
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick6Button12;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick6Button12
		{
			get
			{
				if(r_FJoystick6Button12 == null)
				{
					r_FJoystick6Button12 = new(typeof(UnityEngine.KeyCode), "Joystick6Button12");
				}
				return r_FJoystick6Button12;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button13
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick6Button13;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick6Button13
		{
			get
			{
				if(r_FJoystick6Button13 == null)
				{
					r_FJoystick6Button13 = new(typeof(UnityEngine.KeyCode), "Joystick6Button13");
				}
				return r_FJoystick6Button13;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button14
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick6Button14;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick6Button14
		{
			get
			{
				if(r_FJoystick6Button14 == null)
				{
					r_FJoystick6Button14 = new(typeof(UnityEngine.KeyCode), "Joystick6Button14");
				}
				return r_FJoystick6Button14;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button15
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick6Button15;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick6Button15
		{
			get
			{
				if(r_FJoystick6Button15 == null)
				{
					r_FJoystick6Button15 = new(typeof(UnityEngine.KeyCode), "Joystick6Button15");
				}
				return r_FJoystick6Button15;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button16
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick6Button16;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick6Button16
		{
			get
			{
				if(r_FJoystick6Button16 == null)
				{
					r_FJoystick6Button16 = new(typeof(UnityEngine.KeyCode), "Joystick6Button16");
				}
				return r_FJoystick6Button16;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button17
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick6Button17;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick6Button17
		{
			get
			{
				if(r_FJoystick6Button17 == null)
				{
					r_FJoystick6Button17 = new(typeof(UnityEngine.KeyCode), "Joystick6Button17");
				}
				return r_FJoystick6Button17;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button18
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick6Button18;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick6Button18
		{
			get
			{
				if(r_FJoystick6Button18 == null)
				{
					r_FJoystick6Button18 = new(typeof(UnityEngine.KeyCode), "Joystick6Button18");
				}
				return r_FJoystick6Button18;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick6Button19
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick6Button19;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick6Button19
		{
			get
			{
				if(r_FJoystick6Button19 == null)
				{
					r_FJoystick6Button19 = new(typeof(UnityEngine.KeyCode), "Joystick6Button19");
				}
				return r_FJoystick6Button19;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button0
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick7Button0;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick7Button0
		{
			get
			{
				if(r_FJoystick7Button0 == null)
				{
					r_FJoystick7Button0 = new(typeof(UnityEngine.KeyCode), "Joystick7Button0");
				}
				return r_FJoystick7Button0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick7Button1;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick7Button1
		{
			get
			{
				if(r_FJoystick7Button1 == null)
				{
					r_FJoystick7Button1 = new(typeof(UnityEngine.KeyCode), "Joystick7Button1");
				}
				return r_FJoystick7Button1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick7Button2;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick7Button2
		{
			get
			{
				if(r_FJoystick7Button2 == null)
				{
					r_FJoystick7Button2 = new(typeof(UnityEngine.KeyCode), "Joystick7Button2");
				}
				return r_FJoystick7Button2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button3
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick7Button3;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick7Button3
		{
			get
			{
				if(r_FJoystick7Button3 == null)
				{
					r_FJoystick7Button3 = new(typeof(UnityEngine.KeyCode), "Joystick7Button3");
				}
				return r_FJoystick7Button3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick7Button4;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick7Button4
		{
			get
			{
				if(r_FJoystick7Button4 == null)
				{
					r_FJoystick7Button4 = new(typeof(UnityEngine.KeyCode), "Joystick7Button4");
				}
				return r_FJoystick7Button4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button5
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick7Button5;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick7Button5
		{
			get
			{
				if(r_FJoystick7Button5 == null)
				{
					r_FJoystick7Button5 = new(typeof(UnityEngine.KeyCode), "Joystick7Button5");
				}
				return r_FJoystick7Button5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button6
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick7Button6;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick7Button6
		{
			get
			{
				if(r_FJoystick7Button6 == null)
				{
					r_FJoystick7Button6 = new(typeof(UnityEngine.KeyCode), "Joystick7Button6");
				}
				return r_FJoystick7Button6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button7
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick7Button7;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick7Button7
		{
			get
			{
				if(r_FJoystick7Button7 == null)
				{
					r_FJoystick7Button7 = new(typeof(UnityEngine.KeyCode), "Joystick7Button7");
				}
				return r_FJoystick7Button7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick7Button8;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick7Button8
		{
			get
			{
				if(r_FJoystick7Button8 == null)
				{
					r_FJoystick7Button8 = new(typeof(UnityEngine.KeyCode), "Joystick7Button8");
				}
				return r_FJoystick7Button8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button9
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick7Button9;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick7Button9
		{
			get
			{
				if(r_FJoystick7Button9 == null)
				{
					r_FJoystick7Button9 = new(typeof(UnityEngine.KeyCode), "Joystick7Button9");
				}
				return r_FJoystick7Button9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button10
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick7Button10;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick7Button10
		{
			get
			{
				if(r_FJoystick7Button10 == null)
				{
					r_FJoystick7Button10 = new(typeof(UnityEngine.KeyCode), "Joystick7Button10");
				}
				return r_FJoystick7Button10;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button11
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick7Button11;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick7Button11
		{
			get
			{
				if(r_FJoystick7Button11 == null)
				{
					r_FJoystick7Button11 = new(typeof(UnityEngine.KeyCode), "Joystick7Button11");
				}
				return r_FJoystick7Button11;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button12
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick7Button12;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick7Button12
		{
			get
			{
				if(r_FJoystick7Button12 == null)
				{
					r_FJoystick7Button12 = new(typeof(UnityEngine.KeyCode), "Joystick7Button12");
				}
				return r_FJoystick7Button12;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button13
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick7Button13;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick7Button13
		{
			get
			{
				if(r_FJoystick7Button13 == null)
				{
					r_FJoystick7Button13 = new(typeof(UnityEngine.KeyCode), "Joystick7Button13");
				}
				return r_FJoystick7Button13;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button14
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick7Button14;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick7Button14
		{
			get
			{
				if(r_FJoystick7Button14 == null)
				{
					r_FJoystick7Button14 = new(typeof(UnityEngine.KeyCode), "Joystick7Button14");
				}
				return r_FJoystick7Button14;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button15
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick7Button15;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick7Button15
		{
			get
			{
				if(r_FJoystick7Button15 == null)
				{
					r_FJoystick7Button15 = new(typeof(UnityEngine.KeyCode), "Joystick7Button15");
				}
				return r_FJoystick7Button15;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button16
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick7Button16;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick7Button16
		{
			get
			{
				if(r_FJoystick7Button16 == null)
				{
					r_FJoystick7Button16 = new(typeof(UnityEngine.KeyCode), "Joystick7Button16");
				}
				return r_FJoystick7Button16;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button17
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick7Button17;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick7Button17
		{
			get
			{
				if(r_FJoystick7Button17 == null)
				{
					r_FJoystick7Button17 = new(typeof(UnityEngine.KeyCode), "Joystick7Button17");
				}
				return r_FJoystick7Button17;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button18
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick7Button18;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick7Button18
		{
			get
			{
				if(r_FJoystick7Button18 == null)
				{
					r_FJoystick7Button18 = new(typeof(UnityEngine.KeyCode), "Joystick7Button18");
				}
				return r_FJoystick7Button18;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick7Button19
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick7Button19;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick7Button19
		{
			get
			{
				if(r_FJoystick7Button19 == null)
				{
					r_FJoystick7Button19 = new(typeof(UnityEngine.KeyCode), "Joystick7Button19");
				}
				return r_FJoystick7Button19;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button0
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick8Button0;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick8Button0
		{
			get
			{
				if(r_FJoystick8Button0 == null)
				{
					r_FJoystick8Button0 = new(typeof(UnityEngine.KeyCode), "Joystick8Button0");
				}
				return r_FJoystick8Button0;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button1
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick8Button1;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick8Button1
		{
			get
			{
				if(r_FJoystick8Button1 == null)
				{
					r_FJoystick8Button1 = new(typeof(UnityEngine.KeyCode), "Joystick8Button1");
				}
				return r_FJoystick8Button1;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button2
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick8Button2;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick8Button2
		{
			get
			{
				if(r_FJoystick8Button2 == null)
				{
					r_FJoystick8Button2 = new(typeof(UnityEngine.KeyCode), "Joystick8Button2");
				}
				return r_FJoystick8Button2;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button3
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick8Button3;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick8Button3
		{
			get
			{
				if(r_FJoystick8Button3 == null)
				{
					r_FJoystick8Button3 = new(typeof(UnityEngine.KeyCode), "Joystick8Button3");
				}
				return r_FJoystick8Button3;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button4
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick8Button4;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick8Button4
		{
			get
			{
				if(r_FJoystick8Button4 == null)
				{
					r_FJoystick8Button4 = new(typeof(UnityEngine.KeyCode), "Joystick8Button4");
				}
				return r_FJoystick8Button4;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button5
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick8Button5;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick8Button5
		{
			get
			{
				if(r_FJoystick8Button5 == null)
				{
					r_FJoystick8Button5 = new(typeof(UnityEngine.KeyCode), "Joystick8Button5");
				}
				return r_FJoystick8Button5;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button6
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick8Button6;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick8Button6
		{
			get
			{
				if(r_FJoystick8Button6 == null)
				{
					r_FJoystick8Button6 = new(typeof(UnityEngine.KeyCode), "Joystick8Button6");
				}
				return r_FJoystick8Button6;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button7
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick8Button7;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick8Button7
		{
			get
			{
				if(r_FJoystick8Button7 == null)
				{
					r_FJoystick8Button7 = new(typeof(UnityEngine.KeyCode), "Joystick8Button7");
				}
				return r_FJoystick8Button7;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button8
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick8Button8;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick8Button8
		{
			get
			{
				if(r_FJoystick8Button8 == null)
				{
					r_FJoystick8Button8 = new(typeof(UnityEngine.KeyCode), "Joystick8Button8");
				}
				return r_FJoystick8Button8;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button9
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick8Button9;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick8Button9
		{
			get
			{
				if(r_FJoystick8Button9 == null)
				{
					r_FJoystick8Button9 = new(typeof(UnityEngine.KeyCode), "Joystick8Button9");
				}
				return r_FJoystick8Button9;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button10
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick8Button10;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick8Button10
		{
			get
			{
				if(r_FJoystick8Button10 == null)
				{
					r_FJoystick8Button10 = new(typeof(UnityEngine.KeyCode), "Joystick8Button10");
				}
				return r_FJoystick8Button10;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button11
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick8Button11;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick8Button11
		{
			get
			{
				if(r_FJoystick8Button11 == null)
				{
					r_FJoystick8Button11 = new(typeof(UnityEngine.KeyCode), "Joystick8Button11");
				}
				return r_FJoystick8Button11;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button12
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick8Button12;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick8Button12
		{
			get
			{
				if(r_FJoystick8Button12 == null)
				{
					r_FJoystick8Button12 = new(typeof(UnityEngine.KeyCode), "Joystick8Button12");
				}
				return r_FJoystick8Button12;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button13
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick8Button13;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick8Button13
		{
			get
			{
				if(r_FJoystick8Button13 == null)
				{
					r_FJoystick8Button13 = new(typeof(UnityEngine.KeyCode), "Joystick8Button13");
				}
				return r_FJoystick8Button13;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button14
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick8Button14;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick8Button14
		{
			get
			{
				if(r_FJoystick8Button14 == null)
				{
					r_FJoystick8Button14 = new(typeof(UnityEngine.KeyCode), "Joystick8Button14");
				}
				return r_FJoystick8Button14;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button15
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick8Button15;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick8Button15
		{
			get
			{
				if(r_FJoystick8Button15 == null)
				{
					r_FJoystick8Button15 = new(typeof(UnityEngine.KeyCode), "Joystick8Button15");
				}
				return r_FJoystick8Button15;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button16
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick8Button16;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick8Button16
		{
			get
			{
				if(r_FJoystick8Button16 == null)
				{
					r_FJoystick8Button16 = new(typeof(UnityEngine.KeyCode), "Joystick8Button16");
				}
				return r_FJoystick8Button16;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button17
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick8Button17;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick8Button17
		{
			get
			{
				if(r_FJoystick8Button17 == null)
				{
					r_FJoystick8Button17 = new(typeof(UnityEngine.KeyCode), "Joystick8Button17");
				}
				return r_FJoystick8Button17;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button18
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick8Button18;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick8Button18
		{
			get
			{
				if(r_FJoystick8Button18 == null)
				{
					r_FJoystick8Button18 = new(typeof(UnityEngine.KeyCode), "Joystick8Button18");
				}
				return r_FJoystick8Button18;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode Joystick8Button19
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode r_FJoystick8Button19;
		public static Hvak.Editor.Refleaction.RUnityEngine.RKeyCode RFJoystick8Button19
		{
			get
			{
				if(r_FJoystick8Button19 == null)
				{
					r_FJoystick8Button19 = new(typeof(UnityEngine.KeyCode), "Joystick8Button19");
				}
				return r_FJoystick8Button19;
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
