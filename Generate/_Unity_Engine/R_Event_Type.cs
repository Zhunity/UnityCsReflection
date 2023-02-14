
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.EventType
	/// </summary>
    public partial class REventType : RMember //
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
					r_Fvalue__.SetBelong(this.instance);
				}
				return r_Fvalue__;
			}
		}

		/// <summary>
		/// UnityEngine.EventType MouseDown
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FMouseDown;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFMouseDown
		{
			get
			{
				if(r_FMouseDown == null)
				{
					r_FMouseDown = new(typeof(UnityEngine.EventType), "MouseDown");
					r_FMouseDown.SetBelong(null);
				}
				return r_FMouseDown;
			}
		}

		/// <summary>
		/// UnityEngine.EventType MouseUp
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FMouseUp;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFMouseUp
		{
			get
			{
				if(r_FMouseUp == null)
				{
					r_FMouseUp = new(typeof(UnityEngine.EventType), "MouseUp");
					r_FMouseUp.SetBelong(null);
				}
				return r_FMouseUp;
			}
		}

		/// <summary>
		/// UnityEngine.EventType MouseMove
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FMouseMove;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFMouseMove
		{
			get
			{
				if(r_FMouseMove == null)
				{
					r_FMouseMove = new(typeof(UnityEngine.EventType), "MouseMove");
					r_FMouseMove.SetBelong(null);
				}
				return r_FMouseMove;
			}
		}

		/// <summary>
		/// UnityEngine.EventType MouseDrag
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FMouseDrag;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFMouseDrag
		{
			get
			{
				if(r_FMouseDrag == null)
				{
					r_FMouseDrag = new(typeof(UnityEngine.EventType), "MouseDrag");
					r_FMouseDrag.SetBelong(null);
				}
				return r_FMouseDrag;
			}
		}

		/// <summary>
		/// UnityEngine.EventType KeyDown
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FKeyDown;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFKeyDown
		{
			get
			{
				if(r_FKeyDown == null)
				{
					r_FKeyDown = new(typeof(UnityEngine.EventType), "KeyDown");
					r_FKeyDown.SetBelong(null);
				}
				return r_FKeyDown;
			}
		}

		/// <summary>
		/// UnityEngine.EventType KeyUp
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FKeyUp;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFKeyUp
		{
			get
			{
				if(r_FKeyUp == null)
				{
					r_FKeyUp = new(typeof(UnityEngine.EventType), "KeyUp");
					r_FKeyUp.SetBelong(null);
				}
				return r_FKeyUp;
			}
		}

		/// <summary>
		/// UnityEngine.EventType ScrollWheel
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FScrollWheel;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFScrollWheel
		{
			get
			{
				if(r_FScrollWheel == null)
				{
					r_FScrollWheel = new(typeof(UnityEngine.EventType), "ScrollWheel");
					r_FScrollWheel.SetBelong(null);
				}
				return r_FScrollWheel;
			}
		}

		/// <summary>
		/// UnityEngine.EventType Repaint
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FRepaint;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFRepaint
		{
			get
			{
				if(r_FRepaint == null)
				{
					r_FRepaint = new(typeof(UnityEngine.EventType), "Repaint");
					r_FRepaint.SetBelong(null);
				}
				return r_FRepaint;
			}
		}

		/// <summary>
		/// UnityEngine.EventType Layout
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FLayout;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFLayout
		{
			get
			{
				if(r_FLayout == null)
				{
					r_FLayout = new(typeof(UnityEngine.EventType), "Layout");
					r_FLayout.SetBelong(null);
				}
				return r_FLayout;
			}
		}

		/// <summary>
		/// UnityEngine.EventType DragUpdated
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FDragUpdated;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFDragUpdated
		{
			get
			{
				if(r_FDragUpdated == null)
				{
					r_FDragUpdated = new(typeof(UnityEngine.EventType), "DragUpdated");
					r_FDragUpdated.SetBelong(null);
				}
				return r_FDragUpdated;
			}
		}

		/// <summary>
		/// UnityEngine.EventType DragPerform
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FDragPerform;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFDragPerform
		{
			get
			{
				if(r_FDragPerform == null)
				{
					r_FDragPerform = new(typeof(UnityEngine.EventType), "DragPerform");
					r_FDragPerform.SetBelong(null);
				}
				return r_FDragPerform;
			}
		}

		/// <summary>
		/// UnityEngine.EventType DragExited
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FDragExited;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFDragExited
		{
			get
			{
				if(r_FDragExited == null)
				{
					r_FDragExited = new(typeof(UnityEngine.EventType), "DragExited");
					r_FDragExited.SetBelong(null);
				}
				return r_FDragExited;
			}
		}

		/// <summary>
		/// UnityEngine.EventType Ignore
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FIgnore;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFIgnore
		{
			get
			{
				if(r_FIgnore == null)
				{
					r_FIgnore = new(typeof(UnityEngine.EventType), "Ignore");
					r_FIgnore.SetBelong(null);
				}
				return r_FIgnore;
			}
		}

		/// <summary>
		/// UnityEngine.EventType Used
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FUsed;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFUsed
		{
			get
			{
				if(r_FUsed == null)
				{
					r_FUsed = new(typeof(UnityEngine.EventType), "Used");
					r_FUsed.SetBelong(null);
				}
				return r_FUsed;
			}
		}

		/// <summary>
		/// UnityEngine.EventType ValidateCommand
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FValidateCommand;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFValidateCommand
		{
			get
			{
				if(r_FValidateCommand == null)
				{
					r_FValidateCommand = new(typeof(UnityEngine.EventType), "ValidateCommand");
					r_FValidateCommand.SetBelong(null);
				}
				return r_FValidateCommand;
			}
		}

		/// <summary>
		/// UnityEngine.EventType ExecuteCommand
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FExecuteCommand;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFExecuteCommand
		{
			get
			{
				if(r_FExecuteCommand == null)
				{
					r_FExecuteCommand = new(typeof(UnityEngine.EventType), "ExecuteCommand");
					r_FExecuteCommand.SetBelong(null);
				}
				return r_FExecuteCommand;
			}
		}

		/// <summary>
		/// UnityEngine.EventType ContextClick
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FContextClick;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFContextClick
		{
			get
			{
				if(r_FContextClick == null)
				{
					r_FContextClick = new(typeof(UnityEngine.EventType), "ContextClick");
					r_FContextClick.SetBelong(null);
				}
				return r_FContextClick;
			}
		}

		/// <summary>
		/// UnityEngine.EventType MouseEnterWindow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FMouseEnterWindow;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFMouseEnterWindow
		{
			get
			{
				if(r_FMouseEnterWindow == null)
				{
					r_FMouseEnterWindow = new(typeof(UnityEngine.EventType), "MouseEnterWindow");
					r_FMouseEnterWindow.SetBelong(null);
				}
				return r_FMouseEnterWindow;
			}
		}

		/// <summary>
		/// UnityEngine.EventType MouseLeaveWindow
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FMouseLeaveWindow;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFMouseLeaveWindow
		{
			get
			{
				if(r_FMouseLeaveWindow == null)
				{
					r_FMouseLeaveWindow = new(typeof(UnityEngine.EventType), "MouseLeaveWindow");
					r_FMouseLeaveWindow.SetBelong(null);
				}
				return r_FMouseLeaveWindow;
			}
		}

		/// <summary>
		/// UnityEngine.EventType TouchDown
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FTouchDown;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFTouchDown
		{
			get
			{
				if(r_FTouchDown == null)
				{
					r_FTouchDown = new(typeof(UnityEngine.EventType), "TouchDown");
					r_FTouchDown.SetBelong(null);
				}
				return r_FTouchDown;
			}
		}

		/// <summary>
		/// UnityEngine.EventType TouchUp
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FTouchUp;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFTouchUp
		{
			get
			{
				if(r_FTouchUp == null)
				{
					r_FTouchUp = new(typeof(UnityEngine.EventType), "TouchUp");
					r_FTouchUp.SetBelong(null);
				}
				return r_FTouchUp;
			}
		}

		/// <summary>
		/// UnityEngine.EventType TouchMove
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FTouchMove;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFTouchMove
		{
			get
			{
				if(r_FTouchMove == null)
				{
					r_FTouchMove = new(typeof(UnityEngine.EventType), "TouchMove");
					r_FTouchMove.SetBelong(null);
				}
				return r_FTouchMove;
			}
		}

		/// <summary>
		/// UnityEngine.EventType TouchEnter
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FTouchEnter;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFTouchEnter
		{
			get
			{
				if(r_FTouchEnter == null)
				{
					r_FTouchEnter = new(typeof(UnityEngine.EventType), "TouchEnter");
					r_FTouchEnter.SetBelong(null);
				}
				return r_FTouchEnter;
			}
		}

		/// <summary>
		/// UnityEngine.EventType TouchLeave
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FTouchLeave;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFTouchLeave
		{
			get
			{
				if(r_FTouchLeave == null)
				{
					r_FTouchLeave = new(typeof(UnityEngine.EventType), "TouchLeave");
					r_FTouchLeave.SetBelong(null);
				}
				return r_FTouchLeave;
			}
		}

		/// <summary>
		/// UnityEngine.EventType TouchStationary
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FTouchStationary;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFTouchStationary
		{
			get
			{
				if(r_FTouchStationary == null)
				{
					r_FTouchStationary = new(typeof(UnityEngine.EventType), "TouchStationary");
					r_FTouchStationary.SetBelong(null);
				}
				return r_FTouchStationary;
			}
		}

		/// <summary>
		/// UnityEngine.EventType mouseDown
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FmouseDown;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFmouseDown
		{
			get
			{
				if(r_FmouseDown == null)
				{
					r_FmouseDown = new(typeof(UnityEngine.EventType), "mouseDown");
					r_FmouseDown.SetBelong(null);
				}
				return r_FmouseDown;
			}
		}

		/// <summary>
		/// UnityEngine.EventType mouseUp
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FmouseUp;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFmouseUp
		{
			get
			{
				if(r_FmouseUp == null)
				{
					r_FmouseUp = new(typeof(UnityEngine.EventType), "mouseUp");
					r_FmouseUp.SetBelong(null);
				}
				return r_FmouseUp;
			}
		}

		/// <summary>
		/// UnityEngine.EventType mouseMove
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FmouseMove;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFmouseMove
		{
			get
			{
				if(r_FmouseMove == null)
				{
					r_FmouseMove = new(typeof(UnityEngine.EventType), "mouseMove");
					r_FmouseMove.SetBelong(null);
				}
				return r_FmouseMove;
			}
		}

		/// <summary>
		/// UnityEngine.EventType mouseDrag
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FmouseDrag;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFmouseDrag
		{
			get
			{
				if(r_FmouseDrag == null)
				{
					r_FmouseDrag = new(typeof(UnityEngine.EventType), "mouseDrag");
					r_FmouseDrag.SetBelong(null);
				}
				return r_FmouseDrag;
			}
		}

		/// <summary>
		/// UnityEngine.EventType keyDown
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FkeyDown;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFkeyDown
		{
			get
			{
				if(r_FkeyDown == null)
				{
					r_FkeyDown = new(typeof(UnityEngine.EventType), "keyDown");
					r_FkeyDown.SetBelong(null);
				}
				return r_FkeyDown;
			}
		}

		/// <summary>
		/// UnityEngine.EventType keyUp
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FkeyUp;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFkeyUp
		{
			get
			{
				if(r_FkeyUp == null)
				{
					r_FkeyUp = new(typeof(UnityEngine.EventType), "keyUp");
					r_FkeyUp.SetBelong(null);
				}
				return r_FkeyUp;
			}
		}

		/// <summary>
		/// UnityEngine.EventType scrollWheel
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FscrollWheel;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFscrollWheel
		{
			get
			{
				if(r_FscrollWheel == null)
				{
					r_FscrollWheel = new(typeof(UnityEngine.EventType), "scrollWheel");
					r_FscrollWheel.SetBelong(null);
				}
				return r_FscrollWheel;
			}
		}

		/// <summary>
		/// UnityEngine.EventType repaint
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_Frepaint;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFrepaint
		{
			get
			{
				if(r_Frepaint == null)
				{
					r_Frepaint = new(typeof(UnityEngine.EventType), "repaint");
					r_Frepaint.SetBelong(null);
				}
				return r_Frepaint;
			}
		}

		/// <summary>
		/// UnityEngine.EventType layout
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_Flayout;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFlayout
		{
			get
			{
				if(r_Flayout == null)
				{
					r_Flayout = new(typeof(UnityEngine.EventType), "layout");
					r_Flayout.SetBelong(null);
				}
				return r_Flayout;
			}
		}

		/// <summary>
		/// UnityEngine.EventType dragUpdated
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FdragUpdated;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFdragUpdated
		{
			get
			{
				if(r_FdragUpdated == null)
				{
					r_FdragUpdated = new(typeof(UnityEngine.EventType), "dragUpdated");
					r_FdragUpdated.SetBelong(null);
				}
				return r_FdragUpdated;
			}
		}

		/// <summary>
		/// UnityEngine.EventType dragPerform
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_FdragPerform;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFdragPerform
		{
			get
			{
				if(r_FdragPerform == null)
				{
					r_FdragPerform = new(typeof(UnityEngine.EventType), "dragPerform");
					r_FdragPerform.SetBelong(null);
				}
				return r_FdragPerform;
			}
		}

		/// <summary>
		/// UnityEngine.EventType ignore
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_Fignore;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFignore
		{
			get
			{
				if(r_Fignore == null)
				{
					r_Fignore = new(typeof(UnityEngine.EventType), "ignore");
					r_Fignore.SetBelong(null);
				}
				return r_Fignore;
			}
		}

		/// <summary>
		/// UnityEngine.EventType used
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.REventType r_Fused;
		public static Hvak.Editor.Refleaction.RUnityEngine.REventType RFused
		{
			get
			{
				if(r_Fused == null)
				{
					r_Fused = new(typeof(UnityEngine.EventType), "used");
					r_Fused.SetBelong(null);
				}
				return r_Fused;
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


        public REventType() : base("UnityEngine.EventType")
        {
        }

        public REventType(System.Object instance) : base("UnityEngine.EventType")
		{
            SetInstance(instance);
		}

        public REventType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REventType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
