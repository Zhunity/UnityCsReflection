using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.GUILayoutGroup
	/// </summary>
    public partial class RGUILayoutGroup : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.GUILayoutEntry] entries
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RGUILayoutEntry> r_Fentries;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RGUILayoutEntry> RFentries
		{
			get
			{
				if(r_Fentries == null)
				{
					r_Fentries = new(this, "entries");
					r_Fentries.SetBelong(this.instance);
				}
				return r_Fentries;
			}
		}

		/// <summary>
		/// System.Boolean isVertical
		/// </summary>
		protected RSystem.RBoolean r_FisVertical;
		public virtual RSystem.RBoolean RFisVertical
		{
			get
			{
				if(r_FisVertical == null)
				{
					r_FisVertical = new(this, "isVertical");
					r_FisVertical.SetBelong(this.instance);
				}
				return r_FisVertical;
			}
		}

		/// <summary>
		/// System.Boolean resetCoords
		/// </summary>
		protected RSystem.RBoolean r_FresetCoords;
		public virtual RSystem.RBoolean RFresetCoords
		{
			get
			{
				if(r_FresetCoords == null)
				{
					r_FresetCoords = new(this, "resetCoords");
					r_FresetCoords.SetBelong(this.instance);
				}
				return r_FresetCoords;
			}
		}

		/// <summary>
		/// System.Single spacing
		/// </summary>
		protected RSystem.RSingle r_Fspacing;
		public virtual RSystem.RSingle RFspacing
		{
			get
			{
				if(r_Fspacing == null)
				{
					r_Fspacing = new(this, "spacing");
					r_Fspacing.SetBelong(this.instance);
				}
				return r_Fspacing;
			}
		}

		/// <summary>
		/// System.Boolean sameSize
		/// </summary>
		protected RSystem.RBoolean r_FsameSize;
		public virtual RSystem.RBoolean RFsameSize
		{
			get
			{
				if(r_FsameSize == null)
				{
					r_FsameSize = new(this, "sameSize");
					r_FsameSize.SetBelong(this.instance);
				}
				return r_FsameSize;
			}
		}

		/// <summary>
		/// System.Boolean isWindow
		/// </summary>
		protected RSystem.RBoolean r_FisWindow;
		public virtual RSystem.RBoolean RFisWindow
		{
			get
			{
				if(r_FisWindow == null)
				{
					r_FisWindow = new(this, "isWindow");
					r_FisWindow.SetBelong(this.instance);
				}
				return r_FisWindow;
			}
		}

		/// <summary>
		/// System.Int32 windowID
		/// </summary>
		protected RSystem.RInt32 r_FwindowID;
		public virtual RSystem.RInt32 RFwindowID
		{
			get
			{
				if(r_FwindowID == null)
				{
					r_FwindowID = new(this, "windowID");
					r_FwindowID.SetBelong(this.instance);
				}
				return r_FwindowID;
			}
		}

		/// <summary>
		/// System.Int32 m_Cursor
		/// </summary>
		protected RSystem.RInt32 r_Fm_Cursor;
		public virtual RSystem.RInt32 RFm_Cursor
		{
			get
			{
				if(r_Fm_Cursor == null)
				{
					r_Fm_Cursor = new(this, "m_Cursor");
					r_Fm_Cursor.SetBelong(this.instance);
				}
				return r_Fm_Cursor;
			}
		}

		/// <summary>
		/// System.Int32 m_StretchableCountX
		/// </summary>
		protected RSystem.RInt32 r_Fm_StretchableCountX;
		public virtual RSystem.RInt32 RFm_StretchableCountX
		{
			get
			{
				if(r_Fm_StretchableCountX == null)
				{
					r_Fm_StretchableCountX = new(this, "m_StretchableCountX");
					r_Fm_StretchableCountX.SetBelong(this.instance);
				}
				return r_Fm_StretchableCountX;
			}
		}

		/// <summary>
		/// System.Int32 m_StretchableCountY
		/// </summary>
		protected RSystem.RInt32 r_Fm_StretchableCountY;
		public virtual RSystem.RInt32 RFm_StretchableCountY
		{
			get
			{
				if(r_Fm_StretchableCountY == null)
				{
					r_Fm_StretchableCountY = new(this, "m_StretchableCountY");
					r_Fm_StretchableCountY.SetBelong(this.instance);
				}
				return r_Fm_StretchableCountY;
			}
		}

		/// <summary>
		/// System.Boolean m_UserSpecifiedWidth
		/// </summary>
		protected RSystem.RBoolean r_Fm_UserSpecifiedWidth;
		public virtual RSystem.RBoolean RFm_UserSpecifiedWidth
		{
			get
			{
				if(r_Fm_UserSpecifiedWidth == null)
				{
					r_Fm_UserSpecifiedWidth = new(this, "m_UserSpecifiedWidth");
					r_Fm_UserSpecifiedWidth.SetBelong(this.instance);
				}
				return r_Fm_UserSpecifiedWidth;
			}
		}

		/// <summary>
		/// System.Boolean m_UserSpecifiedHeight
		/// </summary>
		protected RSystem.RBoolean r_Fm_UserSpecifiedHeight;
		public virtual RSystem.RBoolean RFm_UserSpecifiedHeight
		{
			get
			{
				if(r_Fm_UserSpecifiedHeight == null)
				{
					r_Fm_UserSpecifiedHeight = new(this, "m_UserSpecifiedHeight");
					r_Fm_UserSpecifiedHeight.SetBelong(this.instance);
				}
				return r_Fm_UserSpecifiedHeight;
			}
		}

		/// <summary>
		/// System.Single m_ChildMinWidth
		/// </summary>
		protected RSystem.RSingle r_Fm_ChildMinWidth;
		public virtual RSystem.RSingle RFm_ChildMinWidth
		{
			get
			{
				if(r_Fm_ChildMinWidth == null)
				{
					r_Fm_ChildMinWidth = new(this, "m_ChildMinWidth");
					r_Fm_ChildMinWidth.SetBelong(this.instance);
				}
				return r_Fm_ChildMinWidth;
			}
		}

		/// <summary>
		/// System.Single m_ChildMaxWidth
		/// </summary>
		protected RSystem.RSingle r_Fm_ChildMaxWidth;
		public virtual RSystem.RSingle RFm_ChildMaxWidth
		{
			get
			{
				if(r_Fm_ChildMaxWidth == null)
				{
					r_Fm_ChildMaxWidth = new(this, "m_ChildMaxWidth");
					r_Fm_ChildMaxWidth.SetBelong(this.instance);
				}
				return r_Fm_ChildMaxWidth;
			}
		}

		/// <summary>
		/// System.Single m_ChildMinHeight
		/// </summary>
		protected RSystem.RSingle r_Fm_ChildMinHeight;
		public virtual RSystem.RSingle RFm_ChildMinHeight
		{
			get
			{
				if(r_Fm_ChildMinHeight == null)
				{
					r_Fm_ChildMinHeight = new(this, "m_ChildMinHeight");
					r_Fm_ChildMinHeight.SetBelong(this.instance);
				}
				return r_Fm_ChildMinHeight;
			}
		}

		/// <summary>
		/// System.Single m_ChildMaxHeight
		/// </summary>
		protected RSystem.RSingle r_Fm_ChildMaxHeight;
		public virtual RSystem.RSingle RFm_ChildMaxHeight
		{
			get
			{
				if(r_Fm_ChildMaxHeight == null)
				{
					r_Fm_ChildMaxHeight = new(this, "m_ChildMaxHeight");
					r_Fm_ChildMaxHeight.SetBelong(this.instance);
				}
				return r_Fm_ChildMaxHeight;
			}
		}

		/// <summary>
		/// System.Int32 m_MarginLeft
		/// </summary>
		protected RSystem.RInt32 r_Fm_MarginLeft;
		public virtual RSystem.RInt32 RFm_MarginLeft
		{
			get
			{
				if(r_Fm_MarginLeft == null)
				{
					r_Fm_MarginLeft = new(this, "m_MarginLeft");
					r_Fm_MarginLeft.SetBelong(this.instance);
				}
				return r_Fm_MarginLeft;
			}
		}

		/// <summary>
		/// System.Int32 m_MarginRight
		/// </summary>
		protected RSystem.RInt32 r_Fm_MarginRight;
		public virtual RSystem.RInt32 RFm_MarginRight
		{
			get
			{
				if(r_Fm_MarginRight == null)
				{
					r_Fm_MarginRight = new(this, "m_MarginRight");
					r_Fm_MarginRight.SetBelong(this.instance);
				}
				return r_Fm_MarginRight;
			}
		}

		/// <summary>
		/// System.Int32 m_MarginTop
		/// </summary>
		protected RSystem.RInt32 r_Fm_MarginTop;
		public virtual RSystem.RInt32 RFm_MarginTop
		{
			get
			{
				if(r_Fm_MarginTop == null)
				{
					r_Fm_MarginTop = new(this, "m_MarginTop");
					r_Fm_MarginTop.SetBelong(this.instance);
				}
				return r_Fm_MarginTop;
			}
		}

		/// <summary>
		/// System.Int32 m_MarginBottom
		/// </summary>
		protected RSystem.RInt32 r_Fm_MarginBottom;
		public virtual RSystem.RInt32 RFm_MarginBottom
		{
			get
			{
				if(r_Fm_MarginBottom == null)
				{
					r_Fm_MarginBottom = new(this, "m_MarginBottom");
					r_Fm_MarginBottom.SetBelong(this.instance);
				}
				return r_Fm_MarginBottom;
			}
		}

		/// <summary>
		/// UnityEngine.GUILayoutEntry none
		/// </summary>
		protected static RUnityEngine.RGUILayoutEntry r_Fnone;
		public static RUnityEngine.RGUILayoutEntry RFnone
		{
			get
			{
				if(r_Fnone == null)
				{
					r_Fnone = new( ReflectionUtils.GetType("UnityEngine.GUILayoutGroup"), "none");
					r_Fnone.SetBelong(null);
				}
				return r_Fnone;
			}
		}

		/// <summary>
		/// System.Single minWidth
		/// </summary>
		protected RSystem.RSingle r_FminWidth;
		public virtual RSystem.RSingle RFminWidth
		{
			get
			{
				if(r_FminWidth == null)
				{
					r_FminWidth = new(this, "minWidth");
					r_FminWidth.SetBelong(this.instance);
				}
				return r_FminWidth;
			}
		}

		/// <summary>
		/// System.Single maxWidth
		/// </summary>
		protected RSystem.RSingle r_FmaxWidth;
		public virtual RSystem.RSingle RFmaxWidth
		{
			get
			{
				if(r_FmaxWidth == null)
				{
					r_FmaxWidth = new(this, "maxWidth");
					r_FmaxWidth.SetBelong(this.instance);
				}
				return r_FmaxWidth;
			}
		}

		/// <summary>
		/// System.Single minHeight
		/// </summary>
		protected RSystem.RSingle r_FminHeight;
		public virtual RSystem.RSingle RFminHeight
		{
			get
			{
				if(r_FminHeight == null)
				{
					r_FminHeight = new(this, "minHeight");
					r_FminHeight.SetBelong(this.instance);
				}
				return r_FminHeight;
			}
		}

		/// <summary>
		/// System.Single maxHeight
		/// </summary>
		protected RSystem.RSingle r_FmaxHeight;
		public virtual RSystem.RSingle RFmaxHeight
		{
			get
			{
				if(r_FmaxHeight == null)
				{
					r_FmaxHeight = new(this, "maxHeight");
					r_FmaxHeight.SetBelong(this.instance);
				}
				return r_FmaxHeight;
			}
		}

		/// <summary>
		/// UnityEngine.Rect rect
		/// </summary>
		protected RUnityEngine.RRect r_Frect;
		public virtual RUnityEngine.RRect RFrect
		{
			get
			{
				if(r_Frect == null)
				{
					r_Frect = new(this, "rect");
					r_Frect.SetBelong(this.instance);
				}
				return r_Frect;
			}
		}

		/// <summary>
		/// System.Int32 stretchWidth
		/// </summary>
		protected RSystem.RInt32 r_FstretchWidth;
		public virtual RSystem.RInt32 RFstretchWidth
		{
			get
			{
				if(r_FstretchWidth == null)
				{
					r_FstretchWidth = new(this, "stretchWidth");
					r_FstretchWidth.SetBelong(this.instance);
				}
				return r_FstretchWidth;
			}
		}

		/// <summary>
		/// System.Int32 stretchHeight
		/// </summary>
		protected RSystem.RInt32 r_FstretchHeight;
		public virtual RSystem.RInt32 RFstretchHeight
		{
			get
			{
				if(r_FstretchHeight == null)
				{
					r_FstretchHeight = new(this, "stretchHeight");
					r_FstretchHeight.SetBelong(this.instance);
				}
				return r_FstretchHeight;
			}
		}

		/// <summary>
		/// System.Boolean consideredForMargin
		/// </summary>
		protected RSystem.RBoolean r_FconsideredForMargin;
		public virtual RSystem.RBoolean RFconsideredForMargin
		{
			get
			{
				if(r_FconsideredForMargin == null)
				{
					r_FconsideredForMargin = new(this, "consideredForMargin");
					r_FconsideredForMargin.SetBelong(this.instance);
				}
				return r_FconsideredForMargin;
			}
		}

		/// <summary>
		/// Int32 marginLeft
		/// </summary>
		protected RSystem.RInt32 r_PmarginLeft;
		public virtual RSystem.RInt32 RPmarginLeft
		{
			get
			{
				if(r_PmarginLeft == null)
				{
					r_PmarginLeft = new(this, "marginLeft", -1);
					r_PmarginLeft.SetBelong(this.instance);
				}
				return r_PmarginLeft;
			}
		}

		/// <summary>
		/// Int32 marginRight
		/// </summary>
		protected RSystem.RInt32 r_PmarginRight;
		public virtual RSystem.RInt32 RPmarginRight
		{
			get
			{
				if(r_PmarginRight == null)
				{
					r_PmarginRight = new(this, "marginRight", -1);
					r_PmarginRight.SetBelong(this.instance);
				}
				return r_PmarginRight;
			}
		}

		/// <summary>
		/// Int32 marginTop
		/// </summary>
		protected RSystem.RInt32 r_PmarginTop;
		public virtual RSystem.RInt32 RPmarginTop
		{
			get
			{
				if(r_PmarginTop == null)
				{
					r_PmarginTop = new(this, "marginTop", -1);
					r_PmarginTop.SetBelong(this.instance);
				}
				return r_PmarginTop;
			}
		}

		/// <summary>
		/// Int32 marginBottom
		/// </summary>
		protected RSystem.RInt32 r_PmarginBottom;
		public virtual RSystem.RInt32 RPmarginBottom
		{
			get
			{
				if(r_PmarginBottom == null)
				{
					r_PmarginBottom = new(this, "marginBottom", -1);
					r_PmarginBottom.SetBelong(this.instance);
				}
				return r_PmarginBottom;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle style
		/// </summary>
		protected RUnityEngine.RGUIStyle r_Pstyle;
		public virtual RUnityEngine.RGUIStyle RPstyle
		{
			get
			{
				if(r_Pstyle == null)
				{
					r_Pstyle = new(this, "style", -1);
					r_Pstyle.SetBelong(this.instance);
				}
				return r_Pstyle;
			}
		}

		/// <summary>
		/// Int32 marginHorizontal
		/// </summary>
		protected RSystem.RInt32 r_PmarginHorizontal;
		public virtual RSystem.RInt32 RPmarginHorizontal
		{
			get
			{
				if(r_PmarginHorizontal == null)
				{
					r_PmarginHorizontal = new(this, "marginHorizontal", -1);
					r_PmarginHorizontal.SetBelong(this.instance);
				}
				return r_PmarginHorizontal;
			}
		}

		/// <summary>
		/// Int32 marginVertical
		/// </summary>
		protected RSystem.RInt32 r_PmarginVertical;
		public virtual RSystem.RInt32 RPmarginVertical
		{
			get
			{
				if(r_PmarginVertical == null)
				{
					r_PmarginVertical = new(this, "marginVertical", -1);
					r_PmarginVertical.SetBelong(this.instance);
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
					r_MApplyOptions_GUILayoutOptionArray.SetBelong(this.instance);
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
					r_MApplyStyleSettings_GUIStyle.SetBelong(this.instance);
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
					r_MResetCursor.SetBelong(this.instance);
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
					r_MPeekNext.SetBelong(this.instance);
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
					r_MGetNext.SetBelong(this.instance);
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
					r_MGetLast.SetBelong(this.instance);
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
					r_MAdd_GUILayoutEntry.SetBelong(this.instance);
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
					r_MCalcWidth.SetBelong(this.instance);
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
					r_MSetHorizontal_Single_Single.SetBelong(this.instance);
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
					r_MCalcHeight.SetBelong(this.instance);
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
					r_MSetVertical_Single_Single.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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


        public virtual RUnityEngine.RGUILayoutEntry GetNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNext.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RGUILayoutEntry(___result);
        }


        public virtual UnityEngine.Rect GetLast()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetLast.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void Add(RUnityEngine.RGUILayoutEntry @e)
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
