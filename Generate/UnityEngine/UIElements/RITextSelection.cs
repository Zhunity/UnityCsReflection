using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ITextSelection
	/// </summary>
    public partial class RITextSelection : RMember //
    {

		/// <summary>
		/// Boolean isSelectable
		/// </summary>
		protected RProperty r_isSelectable;
		public virtual RProperty RisSelectable
		{
			get
			{
				if(r_isSelectable == null)
				{
					r_isSelectable = new(this, "isSelectable", -1);
					r_isSelectable.SetBelong(this.instance);
				}
				return r_isSelectable;
			}
		}

		/// <summary>
		/// UnityEngine.Color cursorColor
		/// </summary>
		protected RUnityEngine.RColor r_cursorColor;
		public virtual RUnityEngine.RColor RcursorColor
		{
			get
			{
				if(r_cursorColor == null)
				{
					r_cursorColor = new(this, "cursorColor", -1);
					r_cursorColor.SetBelong(this.instance);
				}
				return r_cursorColor;
			}
		}

		/// <summary>
		/// Int32 cursorIndex
		/// </summary>
		protected RProperty r_cursorIndex;
		public virtual RProperty RcursorIndex
		{
			get
			{
				if(r_cursorIndex == null)
				{
					r_cursorIndex = new(this, "cursorIndex", -1);
					r_cursorIndex.SetBelong(this.instance);
				}
				return r_cursorIndex;
			}
		}

		/// <summary>
		/// Boolean doubleClickSelectsWord
		/// </summary>
		protected RProperty r_doubleClickSelectsWord;
		public virtual RProperty RdoubleClickSelectsWord
		{
			get
			{
				if(r_doubleClickSelectsWord == null)
				{
					r_doubleClickSelectsWord = new(this, "doubleClickSelectsWord", -1);
					r_doubleClickSelectsWord.SetBelong(this.instance);
				}
				return r_doubleClickSelectsWord;
			}
		}

		/// <summary>
		/// Int32 selectIndex
		/// </summary>
		protected RProperty r_selectIndex;
		public virtual RProperty RselectIndex
		{
			get
			{
				if(r_selectIndex == null)
				{
					r_selectIndex = new(this, "selectIndex", -1);
					r_selectIndex.SetBelong(this.instance);
				}
				return r_selectIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Color selectionColor
		/// </summary>
		protected RUnityEngine.RColor r_selectionColor;
		public virtual RUnityEngine.RColor RselectionColor
		{
			get
			{
				if(r_selectionColor == null)
				{
					r_selectionColor = new(this, "selectionColor", -1);
					r_selectionColor.SetBelong(this.instance);
				}
				return r_selectionColor;
			}
		}

		/// <summary>
		/// Boolean tripleClickSelectsLine
		/// </summary>
		protected RProperty r_tripleClickSelectsLine;
		public virtual RProperty RtripleClickSelectsLine
		{
			get
			{
				if(r_tripleClickSelectsLine == null)
				{
					r_tripleClickSelectsLine = new(this, "tripleClickSelectsLine", -1);
					r_tripleClickSelectsLine.SetBelong(this.instance);
				}
				return r_tripleClickSelectsLine;
			}
		}

		/// <summary>
		/// Boolean selectAllOnFocus
		/// </summary>
		protected RProperty r_selectAllOnFocus;
		public virtual RProperty RselectAllOnFocus
		{
			get
			{
				if(r_selectAllOnFocus == null)
				{
					r_selectAllOnFocus = new(this, "selectAllOnFocus", -1);
					r_selectAllOnFocus.SetBelong(this.instance);
				}
				return r_selectAllOnFocus;
			}
		}

		/// <summary>
		/// Boolean selectAllOnMouseUp
		/// </summary>
		protected RProperty r_selectAllOnMouseUp;
		public virtual RProperty RselectAllOnMouseUp
		{
			get
			{
				if(r_selectAllOnMouseUp == null)
				{
					r_selectAllOnMouseUp = new(this, "selectAllOnMouseUp", -1);
					r_selectAllOnMouseUp.SetBelong(this.instance);
				}
				return r_selectAllOnMouseUp;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 cursorPosition
		/// </summary>
		protected RUnityEngine.RVector2 r_cursorPosition;
		public virtual RUnityEngine.RVector2 RcursorPosition
		{
			get
			{
				if(r_cursorPosition == null)
				{
					r_cursorPosition = new(this, "cursorPosition", -1);
					r_cursorPosition.SetBelong(this.instance);
				}
				return r_cursorPosition;
			}
		}

		/// <summary>
		/// Single lineHeightAtCursorPosition
		/// </summary>
		protected RProperty r_lineHeightAtCursorPosition;
		public virtual RProperty RlineHeightAtCursorPosition
		{
			get
			{
				if(r_lineHeightAtCursorPosition == null)
				{
					r_lineHeightAtCursorPosition = new(this, "lineHeightAtCursorPosition", -1);
					r_lineHeightAtCursorPosition.SetBelong(this.instance);
				}
				return r_lineHeightAtCursorPosition;
			}
		}

		/// <summary>
		/// Single cursorWidth
		/// </summary>
		protected RProperty r_cursorWidth;
		public virtual RProperty RcursorWidth
		{
			get
			{
				if(r_cursorWidth == null)
				{
					r_cursorWidth = new(this, "cursorWidth", -1);
					r_cursorWidth.SetBelong(this.instance);
				}
				return r_cursorWidth;
			}
		}

		/// <summary>
		/// Boolean HasSelection()
		/// </summary>
		protected RMethod r_HasSelection;
		public virtual RMethod RHasSelection
		{
			get
			{
				if(r_HasSelection == null)
				{
					r_HasSelection = new(this, "HasSelection", 0);
					r_HasSelection.SetBelong(this.instance);
				}
				return r_HasSelection;
			}
		}

		/// <summary>
		/// Void SelectAll()
		/// </summary>
		protected RMethod r_SelectAll;
		public virtual RMethod RSelectAll
		{
			get
			{
				if(r_SelectAll == null)
				{
					r_SelectAll = new(this, "SelectAll", 0);
					r_SelectAll.SetBelong(this.instance);
				}
				return r_SelectAll;
			}
		}

		/// <summary>
		/// Void SelectNone()
		/// </summary>
		protected RMethod r_SelectNone;
		public virtual RMethod RSelectNone
		{
			get
			{
				if(r_SelectNone == null)
				{
					r_SelectNone = new(this, "SelectNone", 0);
					r_SelectNone.SetBelong(this.instance);
				}
				return r_SelectNone;
			}
		}

		/// <summary>
		/// Void SelectRange(Int32, Int32)
		/// </summary>
		protected RMethod r_SelectRange_Int32_Int32;
		public virtual RMethod RSelectRange_Int32_Int32
		{
			get
			{
				if(r_SelectRange_Int32_Int32 == null)
				{
					r_SelectRange_Int32_Int32 = new(this, "SelectRange", 0, typeof(System.Int32), typeof(System.Int32));
					r_SelectRange_Int32_Int32.SetBelong(this.instance);
				}
				return r_SelectRange_Int32_Int32;
			}
		}

		/// <summary>
		/// Void MoveTextEnd()
		/// </summary>
		protected RMethod r_MoveTextEnd;
		public virtual RMethod RMoveTextEnd
		{
			get
			{
				if(r_MoveTextEnd == null)
				{
					r_MoveTextEnd = new(this, "MoveTextEnd", 0);
					r_MoveTextEnd.SetBelong(this.instance);
				}
				return r_MoveTextEnd;
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
            var ___result = RHasSelection.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SelectAll()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSelectAll.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectNone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSelectNone.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SelectRange(System.Int32  @cursorIndex, System.Int32  @selectionIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cursorIndex, @selectionIndex};
            var ___result = RSelectRange_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveTextEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveTextEnd.Invoke(___genericsType, ___parameters);

            
        }


    }
}
