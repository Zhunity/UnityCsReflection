
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ITextSelection
	/// </summary>
    public partial class RITextSelection : RMember //
    {

		/// <summary>
		/// Boolean isSelectable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisSelectable;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisSelectable
		{
			get
			{
				if(r_PisSelectable == null)
				{
					r_PisSelectable = new(this, "isSelectable", -1);
					r_PisSelectable.SetBelong(this.instance);
				}
				return r_PisSelectable;
			}
		}

		/// <summary>
		/// UnityEngine.Color cursorColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PcursorColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPcursorColor
		{
			get
			{
				if(r_PcursorColor == null)
				{
					r_PcursorColor = new(this, "cursorColor", -1);
					r_PcursorColor.SetBelong(this.instance);
				}
				return r_PcursorColor;
			}
		}

		/// <summary>
		/// Int32 cursorIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PcursorIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPcursorIndex
		{
			get
			{
				if(r_PcursorIndex == null)
				{
					r_PcursorIndex = new(this, "cursorIndex", -1);
					r_PcursorIndex.SetBelong(this.instance);
				}
				return r_PcursorIndex;
			}
		}

		/// <summary>
		/// Boolean doubleClickSelectsWord
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PdoubleClickSelectsWord;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdoubleClickSelectsWord
		{
			get
			{
				if(r_PdoubleClickSelectsWord == null)
				{
					r_PdoubleClickSelectsWord = new(this, "doubleClickSelectsWord", -1);
					r_PdoubleClickSelectsWord.SetBelong(this.instance);
				}
				return r_PdoubleClickSelectsWord;
			}
		}

		/// <summary>
		/// Int32 selectIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PselectIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPselectIndex
		{
			get
			{
				if(r_PselectIndex == null)
				{
					r_PselectIndex = new(this, "selectIndex", -1);
					r_PselectIndex.SetBelong(this.instance);
				}
				return r_PselectIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Color selectionColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PselectionColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPselectionColor
		{
			get
			{
				if(r_PselectionColor == null)
				{
					r_PselectionColor = new(this, "selectionColor", -1);
					r_PselectionColor.SetBelong(this.instance);
				}
				return r_PselectionColor;
			}
		}

		/// <summary>
		/// Boolean tripleClickSelectsLine
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PtripleClickSelectsLine;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPtripleClickSelectsLine
		{
			get
			{
				if(r_PtripleClickSelectsLine == null)
				{
					r_PtripleClickSelectsLine = new(this, "tripleClickSelectsLine", -1);
					r_PtripleClickSelectsLine.SetBelong(this.instance);
				}
				return r_PtripleClickSelectsLine;
			}
		}

		/// <summary>
		/// Boolean selectAllOnFocus
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PselectAllOnFocus;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPselectAllOnFocus
		{
			get
			{
				if(r_PselectAllOnFocus == null)
				{
					r_PselectAllOnFocus = new(this, "selectAllOnFocus", -1);
					r_PselectAllOnFocus.SetBelong(this.instance);
				}
				return r_PselectAllOnFocus;
			}
		}

		/// <summary>
		/// Boolean selectAllOnMouseUp
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PselectAllOnMouseUp;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPselectAllOnMouseUp
		{
			get
			{
				if(r_PselectAllOnMouseUp == null)
				{
					r_PselectAllOnMouseUp = new(this, "selectAllOnMouseUp", -1);
					r_PselectAllOnMouseUp.SetBelong(this.instance);
				}
				return r_PselectAllOnMouseUp;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 cursorPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector2 r_PcursorPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector2 RPcursorPosition
		{
			get
			{
				if(r_PcursorPosition == null)
				{
					r_PcursorPosition = new(this, "cursorPosition", -1);
					r_PcursorPosition.SetBelong(this.instance);
				}
				return r_PcursorPosition;
			}
		}

		/// <summary>
		/// Single lineHeightAtCursorPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PlineHeightAtCursorPosition;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPlineHeightAtCursorPosition
		{
			get
			{
				if(r_PlineHeightAtCursorPosition == null)
				{
					r_PlineHeightAtCursorPosition = new(this, "lineHeightAtCursorPosition", -1);
					r_PlineHeightAtCursorPosition.SetBelong(this.instance);
				}
				return r_PlineHeightAtCursorPosition;
			}
		}

		/// <summary>
		/// Single cursorWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PcursorWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPcursorWidth
		{
			get
			{
				if(r_PcursorWidth == null)
				{
					r_PcursorWidth = new(this, "cursorWidth", -1);
					r_PcursorWidth.SetBelong(this.instance);
				}
				return r_PcursorWidth;
			}
		}

		/// <summary>
		/// Boolean HasSelection()
		/// </summary>
		protected RMethod r_MHasSelection;
		public virtual RMethod RMHasSelection
		{
			get
			{
				if(r_MHasSelection == null)
				{
					r_MHasSelection = new(this, "HasSelection", 0);
					r_MHasSelection.SetBelong(this.instance);
				}
				return r_MHasSelection;
			}
		}

		/// <summary>
		/// Void SelectAll()
		/// </summary>
		protected RMethod r_MSelectAll;
		public virtual RMethod RMSelectAll
		{
			get
			{
				if(r_MSelectAll == null)
				{
					r_MSelectAll = new(this, "SelectAll", 0);
					r_MSelectAll.SetBelong(this.instance);
				}
				return r_MSelectAll;
			}
		}

		/// <summary>
		/// Void SelectNone()
		/// </summary>
		protected RMethod r_MSelectNone;
		public virtual RMethod RMSelectNone
		{
			get
			{
				if(r_MSelectNone == null)
				{
					r_MSelectNone = new(this, "SelectNone", 0);
					r_MSelectNone.SetBelong(this.instance);
				}
				return r_MSelectNone;
			}
		}

		/// <summary>
		/// Void SelectRange(Int32, Int32)
		/// </summary>
		protected RMethod r_MSelectRange_Int32_Int32;
		public virtual RMethod RMSelectRange_Int32_Int32
		{
			get
			{
				if(r_MSelectRange_Int32_Int32 == null)
				{
					r_MSelectRange_Int32_Int32 = new(this, "SelectRange", 0, typeof(System.Int32), typeof(System.Int32));
					r_MSelectRange_Int32_Int32.SetBelong(this.instance);
				}
				return r_MSelectRange_Int32_Int32;
			}
		}

		/// <summary>
		/// Void MoveTextEnd()
		/// </summary>
		protected RMethod r_MMoveTextEnd;
		public virtual RMethod RMMoveTextEnd
		{
			get
			{
				if(r_MMoveTextEnd == null)
				{
					r_MMoveTextEnd = new(this, "MoveTextEnd", 0);
					r_MMoveTextEnd.SetBelong(this.instance);
				}
				return r_MMoveTextEnd;
			}
		}


        public RITextSelection() : base("UnityEngine.UIElements.ITextSelection")
        {
        }

        public RITextSelection(System.Object instance) : base("UnityEngine.UIElements.ITextSelection")
		{
            SetInstance(instance);
		}

        public RITextSelection(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RITextSelection(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean HasSelection()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasSelection.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SelectAll()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSelectAll.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectNone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSelectNone.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectRange(System.Int32 @cursorIndex, System.Int32 @selectionIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cursorIndex, @selectionIndex};
            var ___result = RMSelectRange_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveTextEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMoveTextEnd.Invoke(___genericsType, ___parameters);

            
        }


    }
}
