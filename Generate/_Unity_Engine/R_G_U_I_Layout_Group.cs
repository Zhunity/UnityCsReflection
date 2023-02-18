
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.GUILayoutGroup
	/// </summary>
    public partial class RGUILayoutGroup : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.GUILayoutEntry] entries
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutEntry> r_Fentries;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutEntry> RFentries
		{
			get
			{
				if(r_Fentries == null)
				{
					r_Fentries = new(this, "entries");
				}
				return r_Fentries;
			}
		}

		/// <summary>
		/// System.Boolean isVertical
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisVertical;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisVertical
		{
			get
			{
				if(r_FisVertical == null)
				{
					r_FisVertical = new(this, "isVertical");
				}
				return r_FisVertical;
			}
		}

		/// <summary>
		/// System.Boolean resetCoords
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FresetCoords;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFresetCoords
		{
			get
			{
				if(r_FresetCoords == null)
				{
					r_FresetCoords = new(this, "resetCoords");
				}
				return r_FresetCoords;
			}
		}

		/// <summary>
		/// System.Single spacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fspacing;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFspacing
		{
			get
			{
				if(r_Fspacing == null)
				{
					r_Fspacing = new(this, "spacing");
				}
				return r_Fspacing;
			}
		}

		/// <summary>
		/// System.Boolean sameSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FsameSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFsameSize
		{
			get
			{
				if(r_FsameSize == null)
				{
					r_FsameSize = new(this, "sameSize");
				}
				return r_FsameSize;
			}
		}

		/// <summary>
		/// System.Boolean isWindow
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisWindow;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisWindow
		{
			get
			{
				if(r_FisWindow == null)
				{
					r_FisWindow = new(this, "isWindow");
				}
				return r_FisWindow;
			}
		}

		/// <summary>
		/// System.Int32 windowID
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FwindowID;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFwindowID
		{
			get
			{
				if(r_FwindowID == null)
				{
					r_FwindowID = new(this, "windowID");
				}
				return r_FwindowID;
			}
		}

		/// <summary>
		/// System.Int32 m_Cursor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Cursor;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Cursor
		{
			get
			{
				if(r_Fm_Cursor == null)
				{
					r_Fm_Cursor = new(this, "m_Cursor");
				}
				return r_Fm_Cursor;
			}
		}

		/// <summary>
		/// System.Int32 m_StretchableCountX
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_StretchableCountX;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_StretchableCountX
		{
			get
			{
				if(r_Fm_StretchableCountX == null)
				{
					r_Fm_StretchableCountX = new(this, "m_StretchableCountX");
				}
				return r_Fm_StretchableCountX;
			}
		}

		/// <summary>
		/// System.Int32 m_StretchableCountY
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_StretchableCountY;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_StretchableCountY
		{
			get
			{
				if(r_Fm_StretchableCountY == null)
				{
					r_Fm_StretchableCountY = new(this, "m_StretchableCountY");
				}
				return r_Fm_StretchableCountY;
			}
		}

		/// <summary>
		/// System.Boolean m_UserSpecifiedWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_UserSpecifiedWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_UserSpecifiedWidth
		{
			get
			{
				if(r_Fm_UserSpecifiedWidth == null)
				{
					r_Fm_UserSpecifiedWidth = new(this, "m_UserSpecifiedWidth");
				}
				return r_Fm_UserSpecifiedWidth;
			}
		}

		/// <summary>
		/// System.Boolean m_UserSpecifiedHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_UserSpecifiedHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_UserSpecifiedHeight
		{
			get
			{
				if(r_Fm_UserSpecifiedHeight == null)
				{
					r_Fm_UserSpecifiedHeight = new(this, "m_UserSpecifiedHeight");
				}
				return r_Fm_UserSpecifiedHeight;
			}
		}

		/// <summary>
		/// System.Single m_ChildMinWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_ChildMinWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_ChildMinWidth
		{
			get
			{
				if(r_Fm_ChildMinWidth == null)
				{
					r_Fm_ChildMinWidth = new(this, "m_ChildMinWidth");
				}
				return r_Fm_ChildMinWidth;
			}
		}

		/// <summary>
		/// System.Single m_ChildMaxWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_ChildMaxWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_ChildMaxWidth
		{
			get
			{
				if(r_Fm_ChildMaxWidth == null)
				{
					r_Fm_ChildMaxWidth = new(this, "m_ChildMaxWidth");
				}
				return r_Fm_ChildMaxWidth;
			}
		}

		/// <summary>
		/// System.Single m_ChildMinHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_ChildMinHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_ChildMinHeight
		{
			get
			{
				if(r_Fm_ChildMinHeight == null)
				{
					r_Fm_ChildMinHeight = new(this, "m_ChildMinHeight");
				}
				return r_Fm_ChildMinHeight;
			}
		}

		/// <summary>
		/// System.Single m_ChildMaxHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_ChildMaxHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_ChildMaxHeight
		{
			get
			{
				if(r_Fm_ChildMaxHeight == null)
				{
					r_Fm_ChildMaxHeight = new(this, "m_ChildMaxHeight");
				}
				return r_Fm_ChildMaxHeight;
			}
		}

		/// <summary>
		/// System.Int32 m_MarginLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_MarginLeft;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_MarginLeft
		{
			get
			{
				if(r_Fm_MarginLeft == null)
				{
					r_Fm_MarginLeft = new(this, "m_MarginLeft");
				}
				return r_Fm_MarginLeft;
			}
		}

		/// <summary>
		/// System.Int32 m_MarginRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_MarginRight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_MarginRight
		{
			get
			{
				if(r_Fm_MarginRight == null)
				{
					r_Fm_MarginRight = new(this, "m_MarginRight");
				}
				return r_Fm_MarginRight;
			}
		}

		/// <summary>
		/// System.Int32 m_MarginTop
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_MarginTop;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_MarginTop
		{
			get
			{
				if(r_Fm_MarginTop == null)
				{
					r_Fm_MarginTop = new(this, "m_MarginTop");
				}
				return r_Fm_MarginTop;
			}
		}

		/// <summary>
		/// System.Int32 m_MarginBottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_MarginBottom;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_MarginBottom
		{
			get
			{
				if(r_Fm_MarginBottom == null)
				{
					r_Fm_MarginBottom = new(this, "m_MarginBottom");
				}
				return r_Fm_MarginBottom;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutEntry none
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutEntry r_Fnone;
		public static Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutEntry RFnone
		{
			get
			{
				if(r_Fnone == null)
				{
					r_Fnone = new( ReflectionUtils.GetType("UnityEngine.GUILayoutGroup"), "none");
				}
				return r_Fnone;
			}
		}

		/// <summary>
		/// System.Single minWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FminWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFminWidth
		{
			get
			{
				if(r_FminWidth == null)
				{
					r_FminWidth = new(this, "minWidth");
				}
				return r_FminWidth;
			}
		}

		/// <summary>
		/// System.Single maxWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FmaxWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFmaxWidth
		{
			get
			{
				if(r_FmaxWidth == null)
				{
					r_FmaxWidth = new(this, "maxWidth");
				}
				return r_FmaxWidth;
			}
		}

		/// <summary>
		/// System.Single minHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FminHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFminHeight
		{
			get
			{
				if(r_FminHeight == null)
				{
					r_FminHeight = new(this, "minHeight");
				}
				return r_FminHeight;
			}
		}

		/// <summary>
		/// System.Single maxHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FmaxHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFmaxHeight
		{
			get
			{
				if(r_FmaxHeight == null)
				{
					r_FmaxHeight = new(this, "maxHeight");
				}
				return r_FmaxHeight;
			}
		}

		/// <summary>
		/// UnityEngine.Rect rect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Frect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFrect
		{
			get
			{
				if(r_Frect == null)
				{
					r_Frect = new(this, "rect");
				}
				return r_Frect;
			}
		}

		/// <summary>
		/// System.Int32 stretchWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FstretchWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFstretchWidth
		{
			get
			{
				if(r_FstretchWidth == null)
				{
					r_FstretchWidth = new(this, "stretchWidth");
				}
				return r_FstretchWidth;
			}
		}

		/// <summary>
		/// System.Int32 stretchHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FstretchHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFstretchHeight
		{
			get
			{
				if(r_FstretchHeight == null)
				{
					r_FstretchHeight = new(this, "stretchHeight");
				}
				return r_FstretchHeight;
			}
		}

		/// <summary>
		/// System.Boolean consideredForMargin
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FconsideredForMargin;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFconsideredForMargin
		{
			get
			{
				if(r_FconsideredForMargin == null)
				{
					r_FconsideredForMargin = new(this, "consideredForMargin");
				}
				return r_FconsideredForMargin;
			}
		}

		/// <summary>
		/// Int32 marginLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PmarginLeft;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPmarginLeft
		{
			get
			{
				if(r_PmarginLeft == null)
				{
					r_PmarginLeft = new(this, "marginLeft", -1);
				}
				return r_PmarginLeft;
			}
		}

		/// <summary>
		/// Int32 marginRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PmarginRight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPmarginRight
		{
			get
			{
				if(r_PmarginRight == null)
				{
					r_PmarginRight = new(this, "marginRight", -1);
				}
				return r_PmarginRight;
			}
		}

		/// <summary>
		/// Int32 marginTop
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PmarginTop;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPmarginTop
		{
			get
			{
				if(r_PmarginTop == null)
				{
					r_PmarginTop = new(this, "marginTop", -1);
				}
				return r_PmarginTop;
			}
		}

		/// <summary>
		/// Int32 marginBottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PmarginBottom;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPmarginBottom
		{
			get
			{
				if(r_PmarginBottom == null)
				{
					r_PmarginBottom = new(this, "marginBottom", -1);
				}
				return r_PmarginBottom;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle style
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RGUIStyle r_Pstyle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUIStyle RPstyle
		{
			get
			{
				if(r_Pstyle == null)
				{
					r_Pstyle = new(this, "style", -1);
				}
				return r_Pstyle;
			}
		}

		/// <summary>
		/// Int32 marginHorizontal
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PmarginHorizontal;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPmarginHorizontal
		{
			get
			{
				if(r_PmarginHorizontal == null)
				{
					r_PmarginHorizontal = new(this, "marginHorizontal", -1);
				}
				return r_PmarginHorizontal;
			}
		}

		/// <summary>
		/// Int32 marginVertical
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PmarginVertical;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPmarginVertical
		{
			get
			{
				if(r_PmarginVertical == null)
				{
					r_PmarginVertical = new(this, "marginVertical", -1);
				}
				return r_PmarginVertical;
			}
		}

		/// <summary>
		/// Void ApplyOptions(UnityEngine.GUILayoutOption[])
		/// </summary>
		protected RMethod r_MApplyOptions_GUILayoutOptionArray;
		public virtual RMethod RMApplyOptions_GUILayoutOptionArray
		{
			get
			{
				if(r_MApplyOptions_GUILayoutOptionArray == null)
				{
					r_MApplyOptions_GUILayoutOptionArray = new(this, "ApplyOptions", 0, typeof(UnityEngine.GUILayoutOption).MakeArrayType());
				}
				return r_MApplyOptions_GUILayoutOptionArray;
			}
		}

		/// <summary>
		/// Void ApplyStyleSettings(UnityEngine.GUIStyle)
		/// </summary>
		protected RMethod r_MApplyStyleSettings_GUIStyle;
		public virtual RMethod RMApplyStyleSettings_GUIStyle
		{
			get
			{
				if(r_MApplyStyleSettings_GUIStyle == null)
				{
					r_MApplyStyleSettings_GUIStyle = new(this, "ApplyStyleSettings", 0, typeof(UnityEngine.GUIStyle));
				}
				return r_MApplyStyleSettings_GUIStyle;
			}
		}

		/// <summary>
		/// Void ResetCursor()
		/// </summary>
		protected RMethod r_MResetCursor;
		public virtual RMethod RMResetCursor
		{
			get
			{
				if(r_MResetCursor == null)
				{
					r_MResetCursor = new(this, "ResetCursor", 0);
				}
				return r_MResetCursor;
			}
		}

		/// <summary>
		/// UnityEngine.Rect PeekNext()
		/// </summary>
		protected RMethod r_MPeekNext;
		public virtual RMethod RMPeekNext
		{
			get
			{
				if(r_MPeekNext == null)
				{
					r_MPeekNext = new(this, "PeekNext", 0);
				}
				return r_MPeekNext;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutEntry GetNext()
		/// </summary>
		protected RMethod r_MGetNext;
		public virtual RMethod RMGetNext
		{
			get
			{
				if(r_MGetNext == null)
				{
					r_MGetNext = new(this, "GetNext", 0);
				}
				return r_MGetNext;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetLast()
		/// </summary>
		protected RMethod r_MGetLast;
		public virtual RMethod RMGetLast
		{
			get
			{
				if(r_MGetLast == null)
				{
					r_MGetLast = new(this, "GetLast", 0);
				}
				return r_MGetLast;
			}
		}

		/// <summary>
		/// Void Add(UnityEngine.GUILayoutEntry)
		/// </summary>
		protected RMethod r_MAdd_GUILayoutEntry;
		public virtual RMethod RMAdd_GUILayoutEntry
		{
			get
			{
				if(r_MAdd_GUILayoutEntry == null)
				{
					r_MAdd_GUILayoutEntry = new(this, "Add", 0,  ReflectionUtils.GetType("UnityEngine.GUILayoutEntry"));
				}
				return r_MAdd_GUILayoutEntry;
			}
		}

		/// <summary>
		/// Void CalcWidth()
		/// </summary>
		protected RMethod r_MCalcWidth;
		public virtual RMethod RMCalcWidth
		{
			get
			{
				if(r_MCalcWidth == null)
				{
					r_MCalcWidth = new(this, "CalcWidth", 0);
				}
				return r_MCalcWidth;
			}
		}

		/// <summary>
		/// Void SetHorizontal(Single, Single)
		/// </summary>
		protected RMethod r_MSetHorizontal_Single_Single;
		public virtual RMethod RMSetHorizontal_Single_Single
		{
			get
			{
				if(r_MSetHorizontal_Single_Single == null)
				{
					r_MSetHorizontal_Single_Single = new(this, "SetHorizontal", 0, typeof(System.Single), typeof(System.Single));
				}
				return r_MSetHorizontal_Single_Single;
			}
		}

		/// <summary>
		/// Void CalcHeight()
		/// </summary>
		protected RMethod r_MCalcHeight;
		public virtual RMethod RMCalcHeight
		{
			get
			{
				if(r_MCalcHeight == null)
				{
					r_MCalcHeight = new(this, "CalcHeight", 0);
				}
				return r_MCalcHeight;
			}
		}

		/// <summary>
		/// Void SetVertical(Single, Single)
		/// </summary>
		protected RMethod r_MSetVertical_Single_Single;
		public virtual RMethod RMSetVertical_Single_Single
		{
			get
			{
				if(r_MSetVertical_Single_Single == null)
				{
					r_MSetVertical_Single_Single = new(this, "SetVertical", 0, typeof(System.Single), typeof(System.Single));
				}
				return r_MSetVertical_Single_Single;
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


        public RGUILayoutGroup() : base("UnityEngine.GUILayoutGroup")
        {
        }

        public RGUILayoutGroup(System.Object instance) : base("UnityEngine.GUILayoutGroup")
		{
            SetInstance(instance);
		}

        public RGUILayoutGroup(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGUILayoutGroup(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void ApplyOptions(UnityEngine.GUILayoutOption[] @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@options};
            var ___result = RMApplyOptions_GUILayoutOptionArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyStyleSettings(UnityEngine.GUIStyle @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@style};
            var ___result = RMApplyStyleSettings_GUIStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetCursor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetCursor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect PeekNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPeekNext.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutEntry GetNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNext.Invoke(___genericsType, ___parameters);

            return new Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutEntry(___result);
        }


        public virtual UnityEngine.Rect GetLast()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLast.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void Add(Hvak.Editor.Refleaction.RUnityEngine.RGUILayoutEntry @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e.Value};
            var ___result = RMAdd_GUILayoutEntry.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CalcWidth()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCalcWidth.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetHorizontal(System.Single @x, System.Single @width)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @width};
            var ___result = RMSetHorizontal_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CalcHeight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCalcHeight.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVertical(System.Single @y, System.Single @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@y, @height};
            var ___result = RMSetVertical_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
