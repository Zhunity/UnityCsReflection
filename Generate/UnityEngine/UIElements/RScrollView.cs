using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ScrollView
	/// </summary>
    public partial class RScrollView : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.ScrollerVisibility m_HorizontalScrollerVisibility
		/// </summary>
		protected RUnityEngine.RUIElements.RScrollerVisibility r_Fm_HorizontalScrollerVisibility;
		public virtual RUnityEngine.RUIElements.RScrollerVisibility RFm_HorizontalScrollerVisibility
		{
			get
			{
				if(r_Fm_HorizontalScrollerVisibility == null)
				{
					r_Fm_HorizontalScrollerVisibility = new(this, "m_HorizontalScrollerVisibility");
					r_Fm_HorizontalScrollerVisibility.SetBelong(this.instance);
				}
				return r_Fm_HorizontalScrollerVisibility;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ScrollerVisibility m_VerticalScrollerVisibility
		/// </summary>
		protected RUnityEngine.RUIElements.RScrollerVisibility r_Fm_VerticalScrollerVisibility;
		public virtual RUnityEngine.RUIElements.RScrollerVisibility RFm_VerticalScrollerVisibility
		{
			get
			{
				if(r_Fm_VerticalScrollerVisibility == null)
				{
					r_Fm_VerticalScrollerVisibility = new(this, "m_VerticalScrollerVisibility");
					r_Fm_VerticalScrollerVisibility.SetBelong(this.instance);
				}
				return r_Fm_VerticalScrollerVisibility;
			}
		}

		/// <summary>
		/// System.Single k_SizeThreshold
		/// </summary>
		protected static RSystem.RSingle r_Fk_SizeThreshold;
		public static RSystem.RSingle RFk_SizeThreshold
		{
			get
			{
				if(r_Fk_SizeThreshold == null)
				{
					r_Fk_SizeThreshold = new(typeof(UnityEngine.UIElements.ScrollView), "k_SizeThreshold");
					r_Fk_SizeThreshold.SetBelong(null);
				}
				return r_Fk_SizeThreshold;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_AttachedRootVisualContainer
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_Fm_AttachedRootVisualContainer;
		public virtual RUnityEngine.RUIElements.RVisualElement RFm_AttachedRootVisualContainer
		{
			get
			{
				if(r_Fm_AttachedRootVisualContainer == null)
				{
					r_Fm_AttachedRootVisualContainer = new(this, "m_AttachedRootVisualContainer");
					r_Fm_AttachedRootVisualContainer.SetBelong(this.instance);
				}
				return r_Fm_AttachedRootVisualContainer;
			}
		}

		/// <summary>
		/// System.Single m_SingleLineHeight
		/// </summary>
		protected RSystem.RSingle r_Fm_SingleLineHeight;
		public virtual RSystem.RSingle RFm_SingleLineHeight
		{
			get
			{
				if(r_Fm_SingleLineHeight == null)
				{
					r_Fm_SingleLineHeight = new(this, "m_SingleLineHeight");
					r_Fm_SingleLineHeight.SetBelong(this.instance);
				}
				return r_Fm_SingleLineHeight;
			}
		}

		/// <summary>
		/// System.String k_SingleLineHeightPropertyName
		/// </summary>
		protected static RSystem.RString r_Fk_SingleLineHeightPropertyName;
		public static RSystem.RString RFk_SingleLineHeightPropertyName
		{
			get
			{
				if(r_Fk_SingleLineHeightPropertyName == null)
				{
					r_Fk_SingleLineHeightPropertyName = new(typeof(UnityEngine.UIElements.ScrollView), "k_SingleLineHeightPropertyName");
					r_Fk_SingleLineHeightPropertyName.SetBelong(null);
				}
				return r_Fk_SingleLineHeightPropertyName;
			}
		}

		/// <summary>
		/// System.Single k_ScrollPageOverlapFactor
		/// </summary>
		protected static RSystem.RSingle r_Fk_ScrollPageOverlapFactor;
		public static RSystem.RSingle RFk_ScrollPageOverlapFactor
		{
			get
			{
				if(r_Fk_ScrollPageOverlapFactor == null)
				{
					r_Fk_ScrollPageOverlapFactor = new(typeof(UnityEngine.UIElements.ScrollView), "k_ScrollPageOverlapFactor");
					r_Fk_ScrollPageOverlapFactor.SetBelong(null);
				}
				return r_Fk_ScrollPageOverlapFactor;
			}
		}

		/// <summary>
		/// System.Single k_UnsetPageSizeValue
		/// </summary>
		protected static RSystem.RSingle r_Fk_UnsetPageSizeValue;
		public static RSystem.RSingle RFk_UnsetPageSizeValue
		{
			get
			{
				if(r_Fk_UnsetPageSizeValue == null)
				{
					r_Fk_UnsetPageSizeValue = new(typeof(UnityEngine.UIElements.ScrollView), "k_UnsetPageSizeValue");
					r_Fk_UnsetPageSizeValue.SetBelong(null);
				}
				return r_Fk_UnsetPageSizeValue;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduledItem m_UpdateScrollersScheduledItem
		/// </summary>
		protected RUnityEngine.RUIElements.RIVisualElementScheduledItem r_Fm_UpdateScrollersScheduledItem;
		public virtual RUnityEngine.RUIElements.RIVisualElementScheduledItem RFm_UpdateScrollersScheduledItem
		{
			get
			{
				if(r_Fm_UpdateScrollersScheduledItem == null)
				{
					r_Fm_UpdateScrollersScheduledItem = new(this, "m_UpdateScrollersScheduledItem");
					r_Fm_UpdateScrollersScheduledItem.SetBelong(this.instance);
				}
				return r_Fm_UpdateScrollersScheduledItem;
			}
		}

		/// <summary>
		/// System.Action`1[System.Boolean] OnUpdateScrollers
		/// </summary>
		protected RSystem.RAction<RSystem.RBoolean> r_FOnUpdateScrollers;
		public virtual RSystem.RAction<RSystem.RBoolean> RFOnUpdateScrollers
		{
			get
			{
				if(r_FOnUpdateScrollers == null)
				{
					r_FOnUpdateScrollers = new(this, "OnUpdateScrollers");
					r_FOnUpdateScrollers.SetBelong(this.instance);
				}
				return r_FOnUpdateScrollers;
			}
		}

		/// <summary>
		/// System.Single m_HorizontalPageSize
		/// </summary>
		protected RSystem.RSingle r_Fm_HorizontalPageSize;
		public virtual RSystem.RSingle RFm_HorizontalPageSize
		{
			get
			{
				if(r_Fm_HorizontalPageSize == null)
				{
					r_Fm_HorizontalPageSize = new(this, "m_HorizontalPageSize");
					r_Fm_HorizontalPageSize.SetBelong(this.instance);
				}
				return r_Fm_HorizontalPageSize;
			}
		}

		/// <summary>
		/// System.Single m_VerticalPageSize
		/// </summary>
		protected RSystem.RSingle r_Fm_VerticalPageSize;
		public virtual RSystem.RSingle RFm_VerticalPageSize
		{
			get
			{
				if(r_Fm_VerticalPageSize == null)
				{
					r_Fm_VerticalPageSize = new(this, "m_VerticalPageSize");
					r_Fm_VerticalPageSize.SetBelong(this.instance);
				}
				return r_Fm_VerticalPageSize;
			}
		}

		/// <summary>
		/// System.Single k_DefaultScrollDecelerationRate
		/// </summary>
		protected static RSystem.RSingle r_Fk_DefaultScrollDecelerationRate;
		public static RSystem.RSingle RFk_DefaultScrollDecelerationRate
		{
			get
			{
				if(r_Fk_DefaultScrollDecelerationRate == null)
				{
					r_Fk_DefaultScrollDecelerationRate = new(typeof(UnityEngine.UIElements.ScrollView), "k_DefaultScrollDecelerationRate");
					r_Fk_DefaultScrollDecelerationRate.SetBelong(null);
				}
				return r_Fk_DefaultScrollDecelerationRate;
			}
		}

		/// <summary>
		/// System.Single m_ScrollDecelerationRate
		/// </summary>
		protected RSystem.RSingle r_Fm_ScrollDecelerationRate;
		public virtual RSystem.RSingle RFm_ScrollDecelerationRate
		{
			get
			{
				if(r_Fm_ScrollDecelerationRate == null)
				{
					r_Fm_ScrollDecelerationRate = new(this, "m_ScrollDecelerationRate");
					r_Fm_ScrollDecelerationRate.SetBelong(this.instance);
				}
				return r_Fm_ScrollDecelerationRate;
			}
		}

		/// <summary>
		/// System.Single k_DefaultElasticity
		/// </summary>
		protected static RSystem.RSingle r_Fk_DefaultElasticity;
		public static RSystem.RSingle RFk_DefaultElasticity
		{
			get
			{
				if(r_Fk_DefaultElasticity == null)
				{
					r_Fk_DefaultElasticity = new(typeof(UnityEngine.UIElements.ScrollView), "k_DefaultElasticity");
					r_Fk_DefaultElasticity.SetBelong(null);
				}
				return r_Fk_DefaultElasticity;
			}
		}

		/// <summary>
		/// System.Single m_Elasticity
		/// </summary>
		protected RSystem.RSingle r_Fm_Elasticity;
		public virtual RSystem.RSingle RFm_Elasticity
		{
			get
			{
				if(r_Fm_Elasticity == null)
				{
					r_Fm_Elasticity = new(this, "m_Elasticity");
					r_Fm_Elasticity.SetBelong(this.instance);
				}
				return r_Fm_Elasticity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ScrollView+TouchScrollBehavior m_TouchScrollBehavior
		/// </summary>
		protected RUnityEngine.RUIElements.RScrollView.RTouchScrollBehavior r_Fm_TouchScrollBehavior;
		public virtual RUnityEngine.RUIElements.RScrollView.RTouchScrollBehavior RFm_TouchScrollBehavior
		{
			get
			{
				if(r_Fm_TouchScrollBehavior == null)
				{
					r_Fm_TouchScrollBehavior = new(this, "m_TouchScrollBehavior");
					r_Fm_TouchScrollBehavior.SetBelong(this.instance);
				}
				return r_Fm_TouchScrollBehavior;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ScrollView+NestedInteractionKind m_NestedInteractionKind
		/// </summary>
		protected RUnityEngine.RUIElements.RScrollView.RNestedInteractionKind r_Fm_NestedInteractionKind;
		public virtual RUnityEngine.RUIElements.RScrollView.RNestedInteractionKind RFm_NestedInteractionKind
		{
			get
			{
				if(r_Fm_NestedInteractionKind == null)
				{
					r_Fm_NestedInteractionKind = new(this, "m_NestedInteractionKind");
					r_Fm_NestedInteractionKind.SetBelong(this.instance);
				}
				return r_Fm_NestedInteractionKind;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement <contentViewport>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_F__0__contentViewport__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RVisualElement RF__0__contentViewport__1__k__BackingField
		{
			get
			{
				if(r_F__0__contentViewport__1__k__BackingField == null)
				{
					r_F__0__contentViewport__1__k__BackingField = new(this, "<contentViewport>k__BackingField");
					r_F__0__contentViewport__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__contentViewport__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Scroller <horizontalScroller>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RScroller r_F__0__horizontalScroller__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RScroller RF__0__horizontalScroller__1__k__BackingField
		{
			get
			{
				if(r_F__0__horizontalScroller__1__k__BackingField == null)
				{
					r_F__0__horizontalScroller__1__k__BackingField = new(this, "<horizontalScroller>k__BackingField");
					r_F__0__horizontalScroller__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__horizontalScroller__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Scroller <verticalScroller>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RScroller r_F__0__verticalScroller__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RScroller RF__0__verticalScroller__1__k__BackingField
		{
			get
			{
				if(r_F__0__verticalScroller__1__k__BackingField == null)
				{
					r_F__0__verticalScroller__1__k__BackingField = new(this, "<verticalScroller>k__BackingField");
					r_F__0__verticalScroller__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__verticalScroller__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_ContentContainer
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_Fm_ContentContainer;
		public virtual RUnityEngine.RUIElements.RVisualElement RFm_ContentContainer
		{
			get
			{
				if(r_Fm_ContentContainer == null)
				{
					r_Fm_ContentContainer = new(this, "m_ContentContainer");
					r_Fm_ContentContainer.SetBelong(this.instance);
				}
				return r_Fm_ContentContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_ContentAndVerticalScrollContainer
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_Fm_ContentAndVerticalScrollContainer;
		public virtual RUnityEngine.RUIElements.RVisualElement RFm_ContentAndVerticalScrollContainer
		{
			get
			{
				if(r_Fm_ContentAndVerticalScrollContainer == null)
				{
					r_Fm_ContentAndVerticalScrollContainer = new(this, "m_ContentAndVerticalScrollContainer");
					r_Fm_ContentAndVerticalScrollContainer.SetBelong(this.instance);
				}
				return r_Fm_ContentAndVerticalScrollContainer;
			}
		}

		/// <summary>
		/// System.String ussClassName
		/// </summary>
		protected static RSystem.RString r_FussClassName;
		public static RSystem.RString RFussClassName
		{
			get
			{
				if(r_FussClassName == null)
				{
					r_FussClassName = new(typeof(UnityEngine.UIElements.ScrollView), "ussClassName");
					r_FussClassName.SetBelong(null);
				}
				return r_FussClassName;
			}
		}

		/// <summary>
		/// System.String viewportUssClassName
		/// </summary>
		protected static RSystem.RString r_FviewportUssClassName;
		public static RSystem.RString RFviewportUssClassName
		{
			get
			{
				if(r_FviewportUssClassName == null)
				{
					r_FviewportUssClassName = new(typeof(UnityEngine.UIElements.ScrollView), "viewportUssClassName");
					r_FviewportUssClassName.SetBelong(null);
				}
				return r_FviewportUssClassName;
			}
		}

		/// <summary>
		/// System.String horizontalVariantViewportUssClassName
		/// </summary>
		protected static RSystem.RString r_FhorizontalVariantViewportUssClassName;
		public static RSystem.RString RFhorizontalVariantViewportUssClassName
		{
			get
			{
				if(r_FhorizontalVariantViewportUssClassName == null)
				{
					r_FhorizontalVariantViewportUssClassName = new(typeof(UnityEngine.UIElements.ScrollView), "horizontalVariantViewportUssClassName");
					r_FhorizontalVariantViewportUssClassName.SetBelong(null);
				}
				return r_FhorizontalVariantViewportUssClassName;
			}
		}

		/// <summary>
		/// System.String verticalVariantViewportUssClassName
		/// </summary>
		protected static RSystem.RString r_FverticalVariantViewportUssClassName;
		public static RSystem.RString RFverticalVariantViewportUssClassName
		{
			get
			{
				if(r_FverticalVariantViewportUssClassName == null)
				{
					r_FverticalVariantViewportUssClassName = new(typeof(UnityEngine.UIElements.ScrollView), "verticalVariantViewportUssClassName");
					r_FverticalVariantViewportUssClassName.SetBelong(null);
				}
				return r_FverticalVariantViewportUssClassName;
			}
		}

		/// <summary>
		/// System.String verticalHorizontalVariantViewportUssClassName
		/// </summary>
		protected static RSystem.RString r_FverticalHorizontalVariantViewportUssClassName;
		public static RSystem.RString RFverticalHorizontalVariantViewportUssClassName
		{
			get
			{
				if(r_FverticalHorizontalVariantViewportUssClassName == null)
				{
					r_FverticalHorizontalVariantViewportUssClassName = new(typeof(UnityEngine.UIElements.ScrollView), "verticalHorizontalVariantViewportUssClassName");
					r_FverticalHorizontalVariantViewportUssClassName.SetBelong(null);
				}
				return r_FverticalHorizontalVariantViewportUssClassName;
			}
		}

		/// <summary>
		/// System.String contentAndVerticalScrollUssClassName
		/// </summary>
		protected static RSystem.RString r_FcontentAndVerticalScrollUssClassName;
		public static RSystem.RString RFcontentAndVerticalScrollUssClassName
		{
			get
			{
				if(r_FcontentAndVerticalScrollUssClassName == null)
				{
					r_FcontentAndVerticalScrollUssClassName = new(typeof(UnityEngine.UIElements.ScrollView), "contentAndVerticalScrollUssClassName");
					r_FcontentAndVerticalScrollUssClassName.SetBelong(null);
				}
				return r_FcontentAndVerticalScrollUssClassName;
			}
		}

		/// <summary>
		/// System.String contentUssClassName
		/// </summary>
		protected static RSystem.RString r_FcontentUssClassName;
		public static RSystem.RString RFcontentUssClassName
		{
			get
			{
				if(r_FcontentUssClassName == null)
				{
					r_FcontentUssClassName = new(typeof(UnityEngine.UIElements.ScrollView), "contentUssClassName");
					r_FcontentUssClassName.SetBelong(null);
				}
				return r_FcontentUssClassName;
			}
		}

		/// <summary>
		/// System.String horizontalVariantContentUssClassName
		/// </summary>
		protected static RSystem.RString r_FhorizontalVariantContentUssClassName;
		public static RSystem.RString RFhorizontalVariantContentUssClassName
		{
			get
			{
				if(r_FhorizontalVariantContentUssClassName == null)
				{
					r_FhorizontalVariantContentUssClassName = new(typeof(UnityEngine.UIElements.ScrollView), "horizontalVariantContentUssClassName");
					r_FhorizontalVariantContentUssClassName.SetBelong(null);
				}
				return r_FhorizontalVariantContentUssClassName;
			}
		}

		/// <summary>
		/// System.String verticalVariantContentUssClassName
		/// </summary>
		protected static RSystem.RString r_FverticalVariantContentUssClassName;
		public static RSystem.RString RFverticalVariantContentUssClassName
		{
			get
			{
				if(r_FverticalVariantContentUssClassName == null)
				{
					r_FverticalVariantContentUssClassName = new(typeof(UnityEngine.UIElements.ScrollView), "verticalVariantContentUssClassName");
					r_FverticalVariantContentUssClassName.SetBelong(null);
				}
				return r_FverticalVariantContentUssClassName;
			}
		}

		/// <summary>
		/// System.String verticalHorizontalVariantContentUssClassName
		/// </summary>
		protected static RSystem.RString r_FverticalHorizontalVariantContentUssClassName;
		public static RSystem.RString RFverticalHorizontalVariantContentUssClassName
		{
			get
			{
				if(r_FverticalHorizontalVariantContentUssClassName == null)
				{
					r_FverticalHorizontalVariantContentUssClassName = new(typeof(UnityEngine.UIElements.ScrollView), "verticalHorizontalVariantContentUssClassName");
					r_FverticalHorizontalVariantContentUssClassName.SetBelong(null);
				}
				return r_FverticalHorizontalVariantContentUssClassName;
			}
		}

		/// <summary>
		/// System.String hScrollerUssClassName
		/// </summary>
		protected static RSystem.RString r_FhScrollerUssClassName;
		public static RSystem.RString RFhScrollerUssClassName
		{
			get
			{
				if(r_FhScrollerUssClassName == null)
				{
					r_FhScrollerUssClassName = new(typeof(UnityEngine.UIElements.ScrollView), "hScrollerUssClassName");
					r_FhScrollerUssClassName.SetBelong(null);
				}
				return r_FhScrollerUssClassName;
			}
		}

		/// <summary>
		/// System.String vScrollerUssClassName
		/// </summary>
		protected static RSystem.RString r_FvScrollerUssClassName;
		public static RSystem.RString RFvScrollerUssClassName
		{
			get
			{
				if(r_FvScrollerUssClassName == null)
				{
					r_FvScrollerUssClassName = new(typeof(UnityEngine.UIElements.ScrollView), "vScrollerUssClassName");
					r_FvScrollerUssClassName.SetBelong(null);
				}
				return r_FvScrollerUssClassName;
			}
		}

		/// <summary>
		/// System.String horizontalVariantUssClassName
		/// </summary>
		protected static RSystem.RString r_FhorizontalVariantUssClassName;
		public static RSystem.RString RFhorizontalVariantUssClassName
		{
			get
			{
				if(r_FhorizontalVariantUssClassName == null)
				{
					r_FhorizontalVariantUssClassName = new(typeof(UnityEngine.UIElements.ScrollView), "horizontalVariantUssClassName");
					r_FhorizontalVariantUssClassName.SetBelong(null);
				}
				return r_FhorizontalVariantUssClassName;
			}
		}

		/// <summary>
		/// System.String verticalVariantUssClassName
		/// </summary>
		protected static RSystem.RString r_FverticalVariantUssClassName;
		public static RSystem.RString RFverticalVariantUssClassName
		{
			get
			{
				if(r_FverticalVariantUssClassName == null)
				{
					r_FverticalVariantUssClassName = new(typeof(UnityEngine.UIElements.ScrollView), "verticalVariantUssClassName");
					r_FverticalVariantUssClassName.SetBelong(null);
				}
				return r_FverticalVariantUssClassName;
			}
		}

		/// <summary>
		/// System.String verticalHorizontalVariantUssClassName
		/// </summary>
		protected static RSystem.RString r_FverticalHorizontalVariantUssClassName;
		public static RSystem.RString RFverticalHorizontalVariantUssClassName
		{
			get
			{
				if(r_FverticalHorizontalVariantUssClassName == null)
				{
					r_FverticalHorizontalVariantUssClassName = new(typeof(UnityEngine.UIElements.ScrollView), "verticalHorizontalVariantUssClassName");
					r_FverticalHorizontalVariantUssClassName.SetBelong(null);
				}
				return r_FverticalHorizontalVariantUssClassName;
			}
		}

		/// <summary>
		/// System.String scrollVariantUssClassName
		/// </summary>
		protected static RSystem.RString r_FscrollVariantUssClassName;
		public static RSystem.RString RFscrollVariantUssClassName
		{
			get
			{
				if(r_FscrollVariantUssClassName == null)
				{
					r_FscrollVariantUssClassName = new(typeof(UnityEngine.UIElements.ScrollView), "scrollVariantUssClassName");
					r_FscrollVariantUssClassName.SetBelong(null);
				}
				return r_FscrollVariantUssClassName;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ScrollViewMode m_Mode
		/// </summary>
		protected RUnityEngine.RUIElements.RScrollViewMode r_Fm_Mode;
		public virtual RUnityEngine.RUIElements.RScrollViewMode RFm_Mode
		{
			get
			{
				if(r_Fm_Mode == null)
				{
					r_Fm_Mode = new(this, "m_Mode");
					r_Fm_Mode.SetBelong(this.instance);
				}
				return r_Fm_Mode;
			}
		}

		/// <summary>
		/// System.Int32 m_ScrollingPointerId
		/// </summary>
		protected RSystem.RInt32 r_Fm_ScrollingPointerId;
		public virtual RSystem.RInt32 RFm_ScrollingPointerId
		{
			get
			{
				if(r_Fm_ScrollingPointerId == null)
				{
					r_Fm_ScrollingPointerId = new(this, "m_ScrollingPointerId");
					r_Fm_ScrollingPointerId.SetBelong(this.instance);
				}
				return r_Fm_ScrollingPointerId;
			}
		}

		/// <summary>
		/// System.Single k_VelocityLerpTimeFactor
		/// </summary>
		protected static RSystem.RSingle r_Fk_VelocityLerpTimeFactor;
		public static RSystem.RSingle RFk_VelocityLerpTimeFactor
		{
			get
			{
				if(r_Fk_VelocityLerpTimeFactor == null)
				{
					r_Fk_VelocityLerpTimeFactor = new(typeof(UnityEngine.UIElements.ScrollView), "k_VelocityLerpTimeFactor");
					r_Fk_VelocityLerpTimeFactor.SetBelong(null);
				}
				return r_Fk_VelocityLerpTimeFactor;
			}
		}

		/// <summary>
		/// System.Single ScrollThresholdSquared
		/// </summary>
		protected static RSystem.RSingle r_FScrollThresholdSquared;
		public static RSystem.RSingle RFScrollThresholdSquared
		{
			get
			{
				if(r_FScrollThresholdSquared == null)
				{
					r_FScrollThresholdSquared = new(typeof(UnityEngine.UIElements.ScrollView), "ScrollThresholdSquared");
					r_FScrollThresholdSquared.SetBelong(null);
				}
				return r_FScrollThresholdSquared;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_StartPosition
		/// </summary>
		protected RUnityEngine.RVector2 r_Fm_StartPosition;
		public virtual RUnityEngine.RVector2 RFm_StartPosition
		{
			get
			{
				if(r_Fm_StartPosition == null)
				{
					r_Fm_StartPosition = new(this, "m_StartPosition");
					r_Fm_StartPosition.SetBelong(this.instance);
				}
				return r_Fm_StartPosition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_PointerStartPosition
		/// </summary>
		protected RUnityEngine.RVector2 r_Fm_PointerStartPosition;
		public virtual RUnityEngine.RVector2 RFm_PointerStartPosition
		{
			get
			{
				if(r_Fm_PointerStartPosition == null)
				{
					r_Fm_PointerStartPosition = new(this, "m_PointerStartPosition");
					r_Fm_PointerStartPosition.SetBelong(this.instance);
				}
				return r_Fm_PointerStartPosition;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_Velocity
		/// </summary>
		protected RUnityEngine.RVector2 r_Fm_Velocity;
		public virtual RUnityEngine.RVector2 RFm_Velocity
		{
			get
			{
				if(r_Fm_Velocity == null)
				{
					r_Fm_Velocity = new(this, "m_Velocity");
					r_Fm_Velocity.SetBelong(this.instance);
				}
				return r_Fm_Velocity;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_SpringBackVelocity
		/// </summary>
		protected RUnityEngine.RVector2 r_Fm_SpringBackVelocity;
		public virtual RUnityEngine.RVector2 RFm_SpringBackVelocity
		{
			get
			{
				if(r_Fm_SpringBackVelocity == null)
				{
					r_Fm_SpringBackVelocity = new(this, "m_SpringBackVelocity");
					r_Fm_SpringBackVelocity.SetBelong(this.instance);
				}
				return r_Fm_SpringBackVelocity;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_LowBounds
		/// </summary>
		protected RUnityEngine.RVector2 r_Fm_LowBounds;
		public virtual RUnityEngine.RVector2 RFm_LowBounds
		{
			get
			{
				if(r_Fm_LowBounds == null)
				{
					r_Fm_LowBounds = new(this, "m_LowBounds");
					r_Fm_LowBounds.SetBelong(this.instance);
				}
				return r_Fm_LowBounds;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_HighBounds
		/// </summary>
		protected RUnityEngine.RVector2 r_Fm_HighBounds;
		public virtual RUnityEngine.RVector2 RFm_HighBounds
		{
			get
			{
				if(r_Fm_HighBounds == null)
				{
					r_Fm_HighBounds = new(this, "m_HighBounds");
					r_Fm_HighBounds.SetBelong(this.instance);
				}
				return r_Fm_HighBounds;
			}
		}

		/// <summary>
		/// System.Single m_LastVelocityLerpTime
		/// </summary>
		protected RSystem.RSingle r_Fm_LastVelocityLerpTime;
		public virtual RSystem.RSingle RFm_LastVelocityLerpTime
		{
			get
			{
				if(r_Fm_LastVelocityLerpTime == null)
				{
					r_Fm_LastVelocityLerpTime = new(this, "m_LastVelocityLerpTime");
					r_Fm_LastVelocityLerpTime.SetBelong(this.instance);
				}
				return r_Fm_LastVelocityLerpTime;
			}
		}

		/// <summary>
		/// System.Boolean m_StartedMoving
		/// </summary>
		protected RSystem.RBoolean r_Fm_StartedMoving;
		public virtual RSystem.RBoolean RFm_StartedMoving
		{
			get
			{
				if(r_Fm_StartedMoving == null)
				{
					r_Fm_StartedMoving = new(this, "m_StartedMoving");
					r_Fm_StartedMoving.SetBelong(this.instance);
				}
				return r_Fm_StartedMoving;
			}
		}

		/// <summary>
		/// System.Boolean m_TouchStoppedVelocity
		/// </summary>
		protected RSystem.RBoolean r_Fm_TouchStoppedVelocity;
		public virtual RSystem.RBoolean RFm_TouchStoppedVelocity
		{
			get
			{
				if(r_Fm_TouchStoppedVelocity == null)
				{
					r_Fm_TouchStoppedVelocity = new(this, "m_TouchStoppedVelocity");
					r_Fm_TouchStoppedVelocity.SetBelong(this.instance);
				}
				return r_Fm_TouchStoppedVelocity;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_CapturedTarget
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_Fm_CapturedTarget;
		public virtual RUnityEngine.RUIElements.RVisualElement RFm_CapturedTarget
		{
			get
			{
				if(r_Fm_CapturedTarget == null)
				{
					r_Fm_CapturedTarget = new(this, "m_CapturedTarget");
					r_Fm_CapturedTarget.SetBelong(this.instance);
				}
				return r_Fm_CapturedTarget;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCallback`1[UnityEngine.UIElements.PointerMoveEvent] m_CapturedTargetPointerMoveCallback
		/// </summary>
		protected RUnityEngine.RUIElements.REventCallback<RUnityEngine.RUIElements.RPointerMoveEvent> r_Fm_CapturedTargetPointerMoveCallback;
		public virtual RUnityEngine.RUIElements.REventCallback<RUnityEngine.RUIElements.RPointerMoveEvent> RFm_CapturedTargetPointerMoveCallback
		{
			get
			{
				if(r_Fm_CapturedTargetPointerMoveCallback == null)
				{
					r_Fm_CapturedTargetPointerMoveCallback = new(this, "m_CapturedTargetPointerMoveCallback");
					r_Fm_CapturedTargetPointerMoveCallback.SetBelong(this.instance);
				}
				return r_Fm_CapturedTargetPointerMoveCallback;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.EventCallback`1[UnityEngine.UIElements.PointerUpEvent] m_CapturedTargetPointerUpCallback
		/// </summary>
		protected RUnityEngine.RUIElements.REventCallback<RUnityEngine.RUIElements.RPointerUpEvent> r_Fm_CapturedTargetPointerUpCallback;
		public virtual RUnityEngine.RUIElements.REventCallback<RUnityEngine.RUIElements.RPointerUpEvent> RFm_CapturedTargetPointerUpCallback
		{
			get
			{
				if(r_Fm_CapturedTargetPointerUpCallback == null)
				{
					r_Fm_CapturedTargetPointerUpCallback = new(this, "m_CapturedTargetPointerUpCallback");
					r_Fm_CapturedTargetPointerUpCallback.SetBelong(this.instance);
				}
				return r_Fm_CapturedTargetPointerUpCallback;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduledItem m_PostPointerUpAnimation
		/// </summary>
		protected RUnityEngine.RUIElements.RIVisualElementScheduledItem r_Fm_PostPointerUpAnimation;
		public virtual RUnityEngine.RUIElements.RIVisualElementScheduledItem RFm_PostPointerUpAnimation
		{
			get
			{
				if(r_Fm_PostPointerUpAnimation == null)
				{
					r_Fm_PostPointerUpAnimation = new(this, "m_PostPointerUpAnimation");
					r_Fm_PostPointerUpAnimation.SetBelong(this.instance);
				}
				return r_Fm_PostPointerUpAnimation;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags m_Flags
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElementFlags r_Fm_Flags;
		public virtual RUnityEngine.RUIElements.RVisualElementFlags RFm_Flags
		{
			get
			{
				if(r_Fm_Flags == null)
				{
					r_Fm_Flags = new(this, "m_Flags");
					r_Fm_Flags.SetBelong(this.instance);
				}
				return r_Fm_Flags;
			}
		}

		/// <summary>
		/// UnityEngine.Rect lastLayout
		/// </summary>
		protected RUnityEngine.RRect r_FlastLayout;
		public virtual RUnityEngine.RRect RFlastLayout
		{
			get
			{
				if(r_FlastLayout == null)
				{
					r_FlastLayout = new(this, "lastLayout");
					r_FlastLayout.SetBelong(this.instance);
				}
				return r_FlastLayout;
			}
		}

		/// <summary>
		/// UnityEngine.Rect lastPseudoPadding
		/// </summary>
		protected RUnityEngine.RRect r_FlastPseudoPadding;
		public virtual RUnityEngine.RRect RFlastPseudoPadding
		{
			get
			{
				if(r_FlastPseudoPadding == null)
				{
					r_FlastPseudoPadding = new(this, "lastPseudoPadding");
					r_FlastPseudoPadding.SetBelong(this.instance);
				}
				return r_FlastPseudoPadding;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainVEData renderChainData
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainVEData r_FrenderChainData;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainVEData RFrenderChainData
		{
			get
			{
				if(r_FrenderChainData == null)
				{
					r_FrenderChainData = new(this, "renderChainData");
					r_FrenderChainData.SetBelong(this.instance);
				}
				return r_FrenderChainData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PseudoStates triggerPseudoMask
		/// </summary>
		protected RUnityEngine.RUIElements.RPseudoStates r_FtriggerPseudoMask;
		public virtual RUnityEngine.RUIElements.RPseudoStates RFtriggerPseudoMask
		{
			get
			{
				if(r_FtriggerPseudoMask == null)
				{
					r_FtriggerPseudoMask = new(this, "triggerPseudoMask");
					r_FtriggerPseudoMask.SetBelong(this.instance);
				}
				return r_FtriggerPseudoMask;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PseudoStates dependencyPseudoMask
		/// </summary>
		protected RUnityEngine.RUIElements.RPseudoStates r_FdependencyPseudoMask;
		public virtual RUnityEngine.RUIElements.RPseudoStates RFdependencyPseudoMask
		{
			get
			{
				if(r_FdependencyPseudoMask == null)
				{
					r_FdependencyPseudoMask = new(this, "dependencyPseudoMask");
					r_FdependencyPseudoMask.SetBelong(this.instance);
				}
				return r_FdependencyPseudoMask;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedStyle m_Style
		/// </summary>
		protected RUnityEngine.RUIElements.RComputedStyle r_Fm_Style;
		public virtual RUnityEngine.RUIElements.RComputedStyle RFm_Style
		{
			get
			{
				if(r_Fm_Style == null)
				{
					r_Fm_Style = new(this, "m_Style");
					r_Fm_Style.SetBelong(this.instance);
				}
				return r_Fm_Style;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleVariableContext variableContext
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleVariableContext r_FvariableContext;
		public virtual RUnityEngine.RUIElements.RStyleVariableContext RFvariableContext
		{
			get
			{
				if(r_FvariableContext == null)
				{
					r_FvariableContext = new(this, "variableContext");
					r_FvariableContext.SetBelong(this.instance);
				}
				return r_FvariableContext;
			}
		}

		/// <summary>
		/// System.Int32 inheritedStylesHash
		/// </summary>
		protected RSystem.RInt32 r_FinheritedStylesHash;
		public virtual RSystem.RInt32 RFinheritedStylesHash
		{
			get
			{
				if(r_FinheritedStylesHash == null)
				{
					r_FinheritedStylesHash = new(this, "inheritedStylesHash");
					r_FinheritedStylesHash.SetBelong(this.instance);
				}
				return r_FinheritedStylesHash;
			}
		}

		/// <summary>
		/// System.UInt32 controlid
		/// </summary>
		protected RSystem.RUInt32 r_Fcontrolid;
		public virtual RSystem.RUInt32 RFcontrolid
		{
			get
			{
				if(r_Fcontrolid == null)
				{
					r_Fcontrolid = new(this, "controlid");
					r_Fcontrolid.SetBelong(this.instance);
				}
				return r_Fcontrolid;
			}
		}

		/// <summary>
		/// System.Int32 imguiContainerDescendantCount
		/// </summary>
		protected RSystem.RInt32 r_FimguiContainerDescendantCount;
		public virtual RSystem.RInt32 RFimguiContainerDescendantCount
		{
			get
			{
				if(r_FimguiContainerDescendantCount == null)
				{
					r_FimguiContainerDescendantCount = new(this, "imguiContainerDescendantCount");
					r_FimguiContainerDescendantCount.SetBelong(this.instance);
				}
				return r_FimguiContainerDescendantCount;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.InlineStyleAccess inlineStyleAccess
		/// </summary>
		protected RUnityEngine.RUIElements.RInlineStyleAccess r_FinlineStyleAccess;
		public virtual RUnityEngine.RUIElements.RInlineStyleAccess RFinlineStyleAccess
		{
			get
			{
				if(r_FinlineStyleAccess == null)
				{
					r_FinlineStyleAccess = new(this, "inlineStyleAccess");
					r_FinlineStyleAccess.SetBelong(this.instance);
				}
				return r_FinlineStyleAccess;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheet] styleSheetList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheet> r_FstyleSheetList;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheet> RFstyleSheetList
		{
			get
			{
				if(r_FstyleSheetList == null)
				{
					r_FstyleSheetList = new(this, "styleSheetList");
					r_FstyleSheetList.SetBelong(this.instance);
				}
				return r_FstyleSheetList;
			}
		}

		/// <summary>
		/// System.Boolean isIMGUIContainer
		/// </summary>
		protected RSystem.RBoolean r_FisIMGUIContainer;
		public virtual RSystem.RBoolean RFisIMGUIContainer
		{
			get
			{
				if(r_FisIMGUIContainer == null)
				{
					r_FisIMGUIContainer = new(this, "isIMGUIContainer");
					r_FisIMGUIContainer.SetBelong(this.instance);
				}
				return r_FisIMGUIContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ScrollerVisibility horizontalScrollerVisibility
		/// </summary>
		protected RUnityEngine.RUIElements.RScrollerVisibility r_PhorizontalScrollerVisibility;
		public virtual RUnityEngine.RUIElements.RScrollerVisibility RPhorizontalScrollerVisibility
		{
			get
			{
				if(r_PhorizontalScrollerVisibility == null)
				{
					r_PhorizontalScrollerVisibility = new(this, "horizontalScrollerVisibility", -1);
					r_PhorizontalScrollerVisibility.SetBelong(this.instance);
				}
				return r_PhorizontalScrollerVisibility;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ScrollerVisibility verticalScrollerVisibility
		/// </summary>
		protected RUnityEngine.RUIElements.RScrollerVisibility r_PverticalScrollerVisibility;
		public virtual RUnityEngine.RUIElements.RScrollerVisibility RPverticalScrollerVisibility
		{
			get
			{
				if(r_PverticalScrollerVisibility == null)
				{
					r_PverticalScrollerVisibility = new(this, "verticalScrollerVisibility", -1);
					r_PverticalScrollerVisibility.SetBelong(this.instance);
				}
				return r_PverticalScrollerVisibility;
			}
		}

		/// <summary>
		/// Boolean showHorizontal
		/// </summary>
		protected RSystem.RBoolean r_PshowHorizontal;
		public virtual RSystem.RBoolean RPshowHorizontal
		{
			get
			{
				if(r_PshowHorizontal == null)
				{
					r_PshowHorizontal = new(this, "showHorizontal", -1);
					r_PshowHorizontal.SetBelong(this.instance);
				}
				return r_PshowHorizontal;
			}
		}

		/// <summary>
		/// Boolean showVertical
		/// </summary>
		protected RSystem.RBoolean r_PshowVertical;
		public virtual RSystem.RBoolean RPshowVertical
		{
			get
			{
				if(r_PshowVertical == null)
				{
					r_PshowVertical = new(this, "showVertical", -1);
					r_PshowVertical.SetBelong(this.instance);
				}
				return r_PshowVertical;
			}
		}

		/// <summary>
		/// Boolean needsHorizontal
		/// </summary>
		protected RSystem.RBoolean r_PneedsHorizontal;
		public virtual RSystem.RBoolean RPneedsHorizontal
		{
			get
			{
				if(r_PneedsHorizontal == null)
				{
					r_PneedsHorizontal = new(this, "needsHorizontal", -1);
					r_PneedsHorizontal.SetBelong(this.instance);
				}
				return r_PneedsHorizontal;
			}
		}

		/// <summary>
		/// Boolean needsVertical
		/// </summary>
		protected RSystem.RBoolean r_PneedsVertical;
		public virtual RSystem.RBoolean RPneedsVertical
		{
			get
			{
				if(r_PneedsVertical == null)
				{
					r_PneedsVertical = new(this, "needsVertical", -1);
					r_PneedsVertical.SetBelong(this.instance);
				}
				return r_PneedsVertical;
			}
		}

		/// <summary>
		/// Boolean isVerticalScrollDisplayed
		/// </summary>
		protected RSystem.RBoolean r_PisVerticalScrollDisplayed;
		public virtual RSystem.RBoolean RPisVerticalScrollDisplayed
		{
			get
			{
				if(r_PisVerticalScrollDisplayed == null)
				{
					r_PisVerticalScrollDisplayed = new(this, "isVerticalScrollDisplayed", -1);
					r_PisVerticalScrollDisplayed.SetBelong(this.instance);
				}
				return r_PisVerticalScrollDisplayed;
			}
		}

		/// <summary>
		/// Boolean isHorizontalScrollDisplayed
		/// </summary>
		protected RSystem.RBoolean r_PisHorizontalScrollDisplayed;
		public virtual RSystem.RBoolean RPisHorizontalScrollDisplayed
		{
			get
			{
				if(r_PisHorizontalScrollDisplayed == null)
				{
					r_PisHorizontalScrollDisplayed = new(this, "isHorizontalScrollDisplayed", -1);
					r_PisHorizontalScrollDisplayed.SetBelong(this.instance);
				}
				return r_PisHorizontalScrollDisplayed;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 scrollOffset
		/// </summary>
		protected RUnityEngine.RVector2 r_PscrollOffset;
		public virtual RUnityEngine.RVector2 RPscrollOffset
		{
			get
			{
				if(r_PscrollOffset == null)
				{
					r_PscrollOffset = new(this, "scrollOffset", -1);
					r_PscrollOffset.SetBelong(this.instance);
				}
				return r_PscrollOffset;
			}
		}

		/// <summary>
		/// Single horizontalPageSize
		/// </summary>
		protected RSystem.RSingle r_PhorizontalPageSize;
		public virtual RSystem.RSingle RPhorizontalPageSize
		{
			get
			{
				if(r_PhorizontalPageSize == null)
				{
					r_PhorizontalPageSize = new(this, "horizontalPageSize", -1);
					r_PhorizontalPageSize.SetBelong(this.instance);
				}
				return r_PhorizontalPageSize;
			}
		}

		/// <summary>
		/// Single verticalPageSize
		/// </summary>
		protected RSystem.RSingle r_PverticalPageSize;
		public virtual RSystem.RSingle RPverticalPageSize
		{
			get
			{
				if(r_PverticalPageSize == null)
				{
					r_PverticalPageSize = new(this, "verticalPageSize", -1);
					r_PverticalPageSize.SetBelong(this.instance);
				}
				return r_PverticalPageSize;
			}
		}

		/// <summary>
		/// Single scrollableWidth
		/// </summary>
		protected RSystem.RSingle r_PscrollableWidth;
		public virtual RSystem.RSingle RPscrollableWidth
		{
			get
			{
				if(r_PscrollableWidth == null)
				{
					r_PscrollableWidth = new(this, "scrollableWidth", -1);
					r_PscrollableWidth.SetBelong(this.instance);
				}
				return r_PscrollableWidth;
			}
		}

		/// <summary>
		/// Single scrollableHeight
		/// </summary>
		protected RSystem.RSingle r_PscrollableHeight;
		public virtual RSystem.RSingle RPscrollableHeight
		{
			get
			{
				if(r_PscrollableHeight == null)
				{
					r_PscrollableHeight = new(this, "scrollableHeight", -1);
					r_PscrollableHeight.SetBelong(this.instance);
				}
				return r_PscrollableHeight;
			}
		}

		/// <summary>
		/// Boolean hasInertia
		/// </summary>
		protected RSystem.RBoolean r_PhasInertia;
		public virtual RSystem.RBoolean RPhasInertia
		{
			get
			{
				if(r_PhasInertia == null)
				{
					r_PhasInertia = new(this, "hasInertia", -1);
					r_PhasInertia.SetBelong(this.instance);
				}
				return r_PhasInertia;
			}
		}

		/// <summary>
		/// Single scrollDecelerationRate
		/// </summary>
		protected RSystem.RSingle r_PscrollDecelerationRate;
		public virtual RSystem.RSingle RPscrollDecelerationRate
		{
			get
			{
				if(r_PscrollDecelerationRate == null)
				{
					r_PscrollDecelerationRate = new(this, "scrollDecelerationRate", -1);
					r_PscrollDecelerationRate.SetBelong(this.instance);
				}
				return r_PscrollDecelerationRate;
			}
		}

		/// <summary>
		/// Single elasticity
		/// </summary>
		protected RSystem.RSingle r_Pelasticity;
		public virtual RSystem.RSingle RPelasticity
		{
			get
			{
				if(r_Pelasticity == null)
				{
					r_Pelasticity = new(this, "elasticity", -1);
					r_Pelasticity.SetBelong(this.instance);
				}
				return r_Pelasticity;
			}
		}

		/// <summary>
		/// TouchScrollBehavior touchScrollBehavior
		/// </summary>
		protected RUnityEngine.RUIElements.RScrollView.RTouchScrollBehavior r_PtouchScrollBehavior;
		public virtual RUnityEngine.RUIElements.RScrollView.RTouchScrollBehavior RPtouchScrollBehavior
		{
			get
			{
				if(r_PtouchScrollBehavior == null)
				{
					r_PtouchScrollBehavior = new(this, "touchScrollBehavior", -1);
					r_PtouchScrollBehavior.SetBelong(this.instance);
				}
				return r_PtouchScrollBehavior;
			}
		}

		/// <summary>
		/// NestedInteractionKind nestedInteractionKind
		/// </summary>
		protected RUnityEngine.RUIElements.RScrollView.RNestedInteractionKind r_PnestedInteractionKind;
		public virtual RUnityEngine.RUIElements.RScrollView.RNestedInteractionKind RPnestedInteractionKind
		{
			get
			{
				if(r_PnestedInteractionKind == null)
				{
					r_PnestedInteractionKind = new(this, "nestedInteractionKind", -1);
					r_PnestedInteractionKind.SetBelong(this.instance);
				}
				return r_PnestedInteractionKind;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement contentViewport
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_PcontentViewport;
		public virtual RUnityEngine.RUIElements.RVisualElement RPcontentViewport
		{
			get
			{
				if(r_PcontentViewport == null)
				{
					r_PcontentViewport = new(this, "contentViewport", -1);
					r_PcontentViewport.SetBelong(this.instance);
				}
				return r_PcontentViewport;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Scroller horizontalScroller
		/// </summary>
		protected RUnityEngine.RUIElements.RScroller r_PhorizontalScroller;
		public virtual RUnityEngine.RUIElements.RScroller RPhorizontalScroller
		{
			get
			{
				if(r_PhorizontalScroller == null)
				{
					r_PhorizontalScroller = new(this, "horizontalScroller", -1);
					r_PhorizontalScroller.SetBelong(this.instance);
				}
				return r_PhorizontalScroller;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Scroller verticalScroller
		/// </summary>
		protected RUnityEngine.RUIElements.RScroller r_PverticalScroller;
		public virtual RUnityEngine.RUIElements.RScroller RPverticalScroller
		{
			get
			{
				if(r_PverticalScroller == null)
				{
					r_PverticalScroller = new(this, "verticalScroller", -1);
					r_PverticalScroller.SetBelong(this.instance);
				}
				return r_PverticalScroller;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement contentContainer
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_PcontentContainer;
		public virtual RUnityEngine.RUIElements.RVisualElement RPcontentContainer
		{
			get
			{
				if(r_PcontentContainer == null)
				{
					r_PcontentContainer = new(this, "contentContainer", -1);
					r_PcontentContainer.SetBelong(this.instance);
				}
				return r_PcontentContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ScrollViewMode mode
		/// </summary>
		protected RUnityEngine.RUIElements.RScrollViewMode r_Pmode;
		public virtual RUnityEngine.RUIElements.RScrollViewMode RPmode
		{
			get
			{
				if(r_Pmode == null)
				{
					r_Pmode = new(this, "mode", -1);
					r_Pmode.SetBelong(this.instance);
				}
				return r_Pmode;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IResolvedStyle resolvedStyle
		/// </summary>
		protected RUnityEngine.RUIElements.RIResolvedStyle r_PresolvedStyle;
		public virtual RUnityEngine.RUIElements.RIResolvedStyle RPresolvedStyle
		{
			get
			{
				if(r_PresolvedStyle == null)
				{
					r_PresolvedStyle = new(this, "resolvedStyle", -1);
					r_PresolvedStyle.SetBelong(this.instance);
				}
				return r_PresolvedStyle;
			}
		}

		/// <summary>
		/// Boolean hasRunningAnimations
		/// </summary>
		protected RSystem.RBoolean r_PhasRunningAnimations;
		public virtual RSystem.RBoolean RPhasRunningAnimations
		{
			get
			{
				if(r_PhasRunningAnimations == null)
				{
					r_PhasRunningAnimations = new(this, "hasRunningAnimations", -1);
					r_PhasRunningAnimations.SetBelong(this.instance);
				}
				return r_PhasRunningAnimations;
			}
		}

		/// <summary>
		/// Boolean hasCompletedAnimations
		/// </summary>
		protected RSystem.RBoolean r_PhasCompletedAnimations;
		public virtual RSystem.RBoolean RPhasCompletedAnimations
		{
			get
			{
				if(r_PhasCompletedAnimations == null)
				{
					r_PhasCompletedAnimations = new(this, "hasCompletedAnimations", -1);
					r_PhasCompletedAnimations.SetBelong(this.instance);
				}
				return r_PhasCompletedAnimations;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IStylePropertyAnimations styleAnimation
		/// </summary>
		protected RUnityEngine.RUIElements.RIStylePropertyAnimations r_PstyleAnimation;
		public virtual RUnityEngine.RUIElements.RIStylePropertyAnimations RPstyleAnimation
		{
			get
			{
				if(r_PstyleAnimation == null)
				{
					r_PstyleAnimation = new(this, "styleAnimation", -1);
					r_PstyleAnimation.SetBelong(this.instance);
				}
				return r_PstyleAnimation;
			}
		}

		/// <summary>
		/// Boolean isCompositeRoot
		/// </summary>
		protected RSystem.RBoolean r_PisCompositeRoot;
		public virtual RSystem.RBoolean RPisCompositeRoot
		{
			get
			{
				if(r_PisCompositeRoot == null)
				{
					r_PisCompositeRoot = new(this, "isCompositeRoot", -1);
					r_PisCompositeRoot.SetBelong(this.instance);
				}
				return r_PisCompositeRoot;
			}
		}

		/// <summary>
		/// Boolean isHierarchyDisplayed
		/// </summary>
		protected RSystem.RBoolean r_PisHierarchyDisplayed;
		public virtual RSystem.RBoolean RPisHierarchyDisplayed
		{
			get
			{
				if(r_PisHierarchyDisplayed == null)
				{
					r_PisHierarchyDisplayed = new(this, "isHierarchyDisplayed", -1);
					r_PisHierarchyDisplayed.SetBelong(this.instance);
				}
				return r_PisHierarchyDisplayed;
			}
		}

		/// <summary>
		/// System.String viewDataKey
		/// </summary>
		protected RSystem.RString r_PviewDataKey;
		public virtual RSystem.RString RPviewDataKey
		{
			get
			{
				if(r_PviewDataKey == null)
				{
					r_PviewDataKey = new(this, "viewDataKey", -1);
					r_PviewDataKey.SetBelong(this.instance);
				}
				return r_PviewDataKey;
			}
		}

		/// <summary>
		/// Boolean enableViewDataPersistence
		/// </summary>
		protected RSystem.RBoolean r_PenableViewDataPersistence;
		public virtual RSystem.RBoolean RPenableViewDataPersistence
		{
			get
			{
				if(r_PenableViewDataPersistence == null)
				{
					r_PenableViewDataPersistence = new(this, "enableViewDataPersistence", -1);
					r_PenableViewDataPersistence.SetBelong(this.instance);
				}
				return r_PenableViewDataPersistence;
			}
		}

		/// <summary>
		/// System.Object userData
		/// </summary>
		protected RSystem.RObject r_PuserData;
		public virtual RSystem.RObject RPuserData
		{
			get
			{
				if(r_PuserData == null)
				{
					r_PuserData = new(this, "userData", -1);
					r_PuserData.SetBelong(this.instance);
				}
				return r_PuserData;
			}
		}

		/// <summary>
		/// Boolean canGrabFocus
		/// </summary>
		protected RSystem.RBoolean r_PcanGrabFocus;
		public virtual RSystem.RBoolean RPcanGrabFocus
		{
			get
			{
				if(r_PcanGrabFocus == null)
				{
					r_PcanGrabFocus = new(this, "canGrabFocus", -1);
					r_PcanGrabFocus.SetBelong(this.instance);
				}
				return r_PcanGrabFocus;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FocusController focusController
		/// </summary>
		protected RUnityEngine.RUIElements.RFocusController r_PfocusController;
		public virtual RUnityEngine.RUIElements.RFocusController RPfocusController
		{
			get
			{
				if(r_PfocusController == null)
				{
					r_PfocusController = new(this, "focusController", -1);
					r_PfocusController.SetBelong(this.instance);
				}
				return r_PfocusController;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UsageHints usageHints
		/// </summary>
		protected RUnityEngine.RUIElements.RUsageHints r_PusageHints;
		public virtual RUnityEngine.RUIElements.RUsageHints RPusageHints
		{
			get
			{
				if(r_PusageHints == null)
				{
					r_PusageHints = new(this, "usageHints", -1);
					r_PusageHints.SetBelong(this.instance);
				}
				return r_PusageHints;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.RenderHints renderHints
		/// </summary>
		protected RUnityEngine.RUIElements.RRenderHints r_PrenderHints;
		public virtual RUnityEngine.RUIElements.RRenderHints RPrenderHints
		{
			get
			{
				if(r_PrenderHints == null)
				{
					r_PrenderHints = new(this, "renderHints", -1);
					r_PrenderHints.SetBelong(this.instance);
				}
				return r_PrenderHints;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ITransform transform
		/// </summary>
		protected RUnityEngine.RUIElements.RITransform r_Ptransform;
		public virtual RUnityEngine.RUIElements.RITransform RPtransform
		{
			get
			{
				if(r_Ptransform == null)
				{
					r_Ptransform = new(this, "transform", -1);
					r_Ptransform.SetBelong(this.instance);
				}
				return r_Ptransform;
			}
		}

		/// <summary>
		/// Boolean isLayoutManual
		/// </summary>
		protected RSystem.RBoolean r_PisLayoutManual;
		public virtual RSystem.RBoolean RPisLayoutManual
		{
			get
			{
				if(r_PisLayoutManual == null)
				{
					r_PisLayoutManual = new(this, "isLayoutManual", -1);
					r_PisLayoutManual.SetBelong(this.instance);
				}
				return r_PisLayoutManual;
			}
		}

		/// <summary>
		/// Single scaledPixelsPerPoint
		/// </summary>
		protected RSystem.RSingle r_PscaledPixelsPerPoint;
		public virtual RSystem.RSingle RPscaledPixelsPerPoint
		{
			get
			{
				if(r_PscaledPixelsPerPoint == null)
				{
					r_PscaledPixelsPerPoint = new(this, "scaledPixelsPerPoint", -1);
					r_PscaledPixelsPerPoint.SetBelong(this.instance);
				}
				return r_PscaledPixelsPerPoint;
			}
		}

		/// <summary>
		/// UnityEngine.Rect layout
		/// </summary>
		protected RUnityEngine.RRect r_Playout;
		public virtual RUnityEngine.RRect RPlayout
		{
			get
			{
				if(r_Playout == null)
				{
					r_Playout = new(this, "layout", -1);
					r_Playout.SetBelong(this.instance);
				}
				return r_Playout;
			}
		}

		/// <summary>
		/// UnityEngine.Rect contentRect
		/// </summary>
		protected RUnityEngine.RRect r_PcontentRect;
		public virtual RUnityEngine.RRect RPcontentRect
		{
			get
			{
				if(r_PcontentRect == null)
				{
					r_PcontentRect = new(this, "contentRect", -1);
					r_PcontentRect.SetBelong(this.instance);
				}
				return r_PcontentRect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect paddingRect
		/// </summary>
		protected RUnityEngine.RRect r_PpaddingRect;
		public virtual RUnityEngine.RRect RPpaddingRect
		{
			get
			{
				if(r_PpaddingRect == null)
				{
					r_PpaddingRect = new(this, "paddingRect", -1);
					r_PpaddingRect.SetBelong(this.instance);
				}
				return r_PpaddingRect;
			}
		}

		/// <summary>
		/// Boolean isBoundingBoxDirty
		/// </summary>
		protected RSystem.RBoolean r_PisBoundingBoxDirty;
		public virtual RSystem.RBoolean RPisBoundingBoxDirty
		{
			get
			{
				if(r_PisBoundingBoxDirty == null)
				{
					r_PisBoundingBoxDirty = new(this, "isBoundingBoxDirty", -1);
					r_PisBoundingBoxDirty.SetBelong(this.instance);
				}
				return r_PisBoundingBoxDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldBoundingBoxDirty
		/// </summary>
		protected RSystem.RBoolean r_PisWorldBoundingBoxDirty;
		public virtual RSystem.RBoolean RPisWorldBoundingBoxDirty
		{
			get
			{
				if(r_PisWorldBoundingBoxDirty == null)
				{
					r_PisWorldBoundingBoxDirty = new(this, "isWorldBoundingBoxDirty", -1);
					r_PisWorldBoundingBoxDirty.SetBelong(this.instance);
				}
				return r_PisWorldBoundingBoxDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldBoundingBoxOrDependenciesDirty
		/// </summary>
		protected RSystem.RBoolean r_PisWorldBoundingBoxOrDependenciesDirty;
		public virtual RSystem.RBoolean RPisWorldBoundingBoxOrDependenciesDirty
		{
			get
			{
				if(r_PisWorldBoundingBoxOrDependenciesDirty == null)
				{
					r_PisWorldBoundingBoxOrDependenciesDirty = new(this, "isWorldBoundingBoxOrDependenciesDirty", -1);
					r_PisWorldBoundingBoxOrDependenciesDirty.SetBelong(this.instance);
				}
				return r_PisWorldBoundingBoxOrDependenciesDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Rect boundingBox
		/// </summary>
		protected RUnityEngine.RRect r_PboundingBox;
		public virtual RUnityEngine.RRect RPboundingBox
		{
			get
			{
				if(r_PboundingBox == null)
				{
					r_PboundingBox = new(this, "boundingBox", -1);
					r_PboundingBox.SetBelong(this.instance);
				}
				return r_PboundingBox;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldBoundingBox
		/// </summary>
		protected RUnityEngine.RRect r_PworldBoundingBox;
		public virtual RUnityEngine.RRect RPworldBoundingBox
		{
			get
			{
				if(r_PworldBoundingBox == null)
				{
					r_PworldBoundingBox = new(this, "worldBoundingBox", -1);
					r_PworldBoundingBox.SetBelong(this.instance);
				}
				return r_PworldBoundingBox;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldBound
		/// </summary>
		protected RUnityEngine.RRect r_PworldBound;
		public virtual RUnityEngine.RRect RPworldBound
		{
			get
			{
				if(r_PworldBound == null)
				{
					r_PworldBound = new(this, "worldBound", -1);
					r_PworldBound.SetBelong(this.instance);
				}
				return r_PworldBound;
			}
		}

		/// <summary>
		/// UnityEngine.Rect localBound
		/// </summary>
		protected RUnityEngine.RRect r_PlocalBound;
		public virtual RUnityEngine.RRect RPlocalBound
		{
			get
			{
				if(r_PlocalBound == null)
				{
					r_PlocalBound = new(this, "localBound", -1);
					r_PlocalBound.SetBelong(this.instance);
				}
				return r_PlocalBound;
			}
		}

		/// <summary>
		/// UnityEngine.Rect rect
		/// </summary>
		protected RUnityEngine.RRect r_Prect;
		public virtual RUnityEngine.RRect RPrect
		{
			get
			{
				if(r_Prect == null)
				{
					r_Prect = new(this, "rect", -1);
					r_Prect.SetBelong(this.instance);
				}
				return r_Prect;
			}
		}

		/// <summary>
		/// Boolean isWorldTransformDirty
		/// </summary>
		protected RSystem.RBoolean r_PisWorldTransformDirty;
		public virtual RSystem.RBoolean RPisWorldTransformDirty
		{
			get
			{
				if(r_PisWorldTransformDirty == null)
				{
					r_PisWorldTransformDirty = new(this, "isWorldTransformDirty", -1);
					r_PisWorldTransformDirty.SetBelong(this.instance);
				}
				return r_PisWorldTransformDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldTransformInverseDirty
		/// </summary>
		protected RSystem.RBoolean r_PisWorldTransformInverseDirty;
		public virtual RSystem.RBoolean RPisWorldTransformInverseDirty
		{
			get
			{
				if(r_PisWorldTransformInverseDirty == null)
				{
					r_PisWorldTransformInverseDirty = new(this, "isWorldTransformInverseDirty", -1);
					r_PisWorldTransformInverseDirty.SetBelong(this.instance);
				}
				return r_PisWorldTransformInverseDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldTransformInverseOrDependenciesDirty
		/// </summary>
		protected RSystem.RBoolean r_PisWorldTransformInverseOrDependenciesDirty;
		public virtual RSystem.RBoolean RPisWorldTransformInverseOrDependenciesDirty
		{
			get
			{
				if(r_PisWorldTransformInverseOrDependenciesDirty == null)
				{
					r_PisWorldTransformInverseOrDependenciesDirty = new(this, "isWorldTransformInverseOrDependenciesDirty", -1);
					r_PisWorldTransformInverseOrDependenciesDirty.SetBelong(this.instance);
				}
				return r_PisWorldTransformInverseOrDependenciesDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 worldTransform
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_PworldTransform;
		public virtual RUnityEngine.RMatrix4x4 RPworldTransform
		{
			get
			{
				if(r_PworldTransform == null)
				{
					r_PworldTransform = new(this, "worldTransform", -1);
					r_PworldTransform.SetBelong(this.instance);
				}
				return r_PworldTransform;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4& worldTransformRef
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_PworldTransformRef;
		public virtual RUnityEngine.RMatrix4x4 RPworldTransformRef
		{
			get
			{
				if(r_PworldTransformRef == null)
				{
					r_PworldTransformRef = new(this, "worldTransformRef", -1);
					r_PworldTransformRef.SetBelong(this.instance);
				}
				return r_PworldTransformRef;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4& worldTransformInverse
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_PworldTransformInverse;
		public virtual RUnityEngine.RMatrix4x4 RPworldTransformInverse
		{
			get
			{
				if(r_PworldTransformInverse == null)
				{
					r_PworldTransformInverse = new(this, "worldTransformInverse", -1);
					r_PworldTransformInverse.SetBelong(this.instance);
				}
				return r_PworldTransformInverse;
			}
		}

		/// <summary>
		/// Boolean isWorldClipDirty
		/// </summary>
		protected RSystem.RBoolean r_PisWorldClipDirty;
		public virtual RSystem.RBoolean RPisWorldClipDirty
		{
			get
			{
				if(r_PisWorldClipDirty == null)
				{
					r_PisWorldClipDirty = new(this, "isWorldClipDirty", -1);
					r_PisWorldClipDirty.SetBelong(this.instance);
				}
				return r_PisWorldClipDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldClip
		/// </summary>
		protected RUnityEngine.RRect r_PworldClip;
		public virtual RUnityEngine.RRect RPworldClip
		{
			get
			{
				if(r_PworldClip == null)
				{
					r_PworldClip = new(this, "worldClip", -1);
					r_PworldClip.SetBelong(this.instance);
				}
				return r_PworldClip;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldClipMinusGroup
		/// </summary>
		protected RUnityEngine.RRect r_PworldClipMinusGroup;
		public virtual RUnityEngine.RRect RPworldClipMinusGroup
		{
			get
			{
				if(r_PworldClipMinusGroup == null)
				{
					r_PworldClipMinusGroup = new(this, "worldClipMinusGroup", -1);
					r_PworldClipMinusGroup.SetBelong(this.instance);
				}
				return r_PworldClipMinusGroup;
			}
		}

		/// <summary>
		/// Boolean worldClipIsInfinite
		/// </summary>
		protected RSystem.RBoolean r_PworldClipIsInfinite;
		public virtual RSystem.RBoolean RPworldClipIsInfinite
		{
			get
			{
				if(r_PworldClipIsInfinite == null)
				{
					r_PworldClipIsInfinite = new(this, "worldClipIsInfinite", -1);
					r_PworldClipIsInfinite.SetBelong(this.instance);
				}
				return r_PworldClipIsInfinite;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PseudoStates pseudoStates
		/// </summary>
		protected RUnityEngine.RUIElements.RPseudoStates r_PpseudoStates;
		public virtual RUnityEngine.RUIElements.RPseudoStates RPpseudoStates
		{
			get
			{
				if(r_PpseudoStates == null)
				{
					r_PpseudoStates = new(this, "pseudoStates", -1);
					r_PpseudoStates.SetBelong(this.instance);
				}
				return r_PpseudoStates;
			}
		}

		/// <summary>
		/// Int32 containedPointerIds
		/// </summary>
		protected RSystem.RInt32 r_PcontainedPointerIds;
		public virtual RSystem.RInt32 RPcontainedPointerIds
		{
			get
			{
				if(r_PcontainedPointerIds == null)
				{
					r_PcontainedPointerIds = new(this, "containedPointerIds", -1);
					r_PcontainedPointerIds.SetBelong(this.instance);
				}
				return r_PcontainedPointerIds;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PickingMode pickingMode
		/// </summary>
		protected RUnityEngine.RUIElements.RPickingMode r_PpickingMode;
		public virtual RUnityEngine.RUIElements.RPickingMode RPpickingMode
		{
			get
			{
				if(r_PpickingMode == null)
				{
					r_PpickingMode = new(this, "pickingMode", -1);
					r_PpickingMode.SetBelong(this.instance);
				}
				return r_PpickingMode;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RSystem.RString r_Pname;
		public virtual RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
					r_Pname.SetBelong(this.instance);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] classList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RString> r_PclassList;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RString> RPclassList
		{
			get
			{
				if(r_PclassList == null)
				{
					r_PclassList = new(this, "classList", -1);
					r_PclassList.SetBelong(this.instance);
				}
				return r_PclassList;
			}
		}

		/// <summary>
		/// System.String fullTypeName
		/// </summary>
		protected RSystem.RString r_PfullTypeName;
		public virtual RSystem.RString RPfullTypeName
		{
			get
			{
				if(r_PfullTypeName == null)
				{
					r_PfullTypeName = new(this, "fullTypeName", -1);
					r_PfullTypeName.SetBelong(this.instance);
				}
				return r_PfullTypeName;
			}
		}

		/// <summary>
		/// System.String typeName
		/// </summary>
		protected RSystem.RString r_PtypeName;
		public virtual RSystem.RString RPtypeName
		{
			get
			{
				if(r_PtypeName == null)
				{
					r_PtypeName = new(this, "typeName", -1);
					r_PtypeName.SetBelong(this.instance);
				}
				return r_PtypeName;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaNode yogaNode
		/// </summary>
		protected RUnityEngine.RYoga.RYogaNode r_PyogaNode;
		public virtual RUnityEngine.RYoga.RYogaNode RPyogaNode
		{
			get
			{
				if(r_PyogaNode == null)
				{
					r_PyogaNode = new(this, "yogaNode", -1);
					r_PyogaNode.SetBelong(this.instance);
				}
				return r_PyogaNode;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedStyle& computedStyle
		/// </summary>
		protected RUnityEngine.RUIElements.RComputedStyle r_PcomputedStyle;
		public virtual RUnityEngine.RUIElements.RComputedStyle RPcomputedStyle
		{
			get
			{
				if(r_PcomputedStyle == null)
				{
					r_PcomputedStyle = new(this, "computedStyle", -1);
					r_PcomputedStyle.SetBelong(this.instance);
				}
				return r_PcomputedStyle;
			}
		}

		/// <summary>
		/// Boolean hasInlineStyle
		/// </summary>
		protected RSystem.RBoolean r_PhasInlineStyle;
		public virtual RSystem.RBoolean RPhasInlineStyle
		{
			get
			{
				if(r_PhasInlineStyle == null)
				{
					r_PhasInlineStyle = new(this, "hasInlineStyle", -1);
					r_PhasInlineStyle.SetBelong(this.instance);
				}
				return r_PhasInlineStyle;
			}
		}

		/// <summary>
		/// Boolean styleInitialized
		/// </summary>
		protected RSystem.RBoolean r_PstyleInitialized;
		public virtual RSystem.RBoolean RPstyleInitialized
		{
			get
			{
				if(r_PstyleInitialized == null)
				{
					r_PstyleInitialized = new(this, "styleInitialized", -1);
					r_PstyleInitialized.SetBelong(this.instance);
				}
				return r_PstyleInitialized;
			}
		}

		/// <summary>
		/// Single opacity
		/// </summary>
		protected RSystem.RSingle r_Popacity;
		public virtual RSystem.RSingle RPopacity
		{
			get
			{
				if(r_Popacity == null)
				{
					r_Popacity = new(this, "opacity", -1);
					r_Popacity.SetBelong(this.instance);
				}
				return r_Popacity;
			}
		}

		/// <summary>
		/// Boolean enabledInHierarchy
		/// </summary>
		protected RSystem.RBoolean r_PenabledInHierarchy;
		public virtual RSystem.RBoolean RPenabledInHierarchy
		{
			get
			{
				if(r_PenabledInHierarchy == null)
				{
					r_PenabledInHierarchy = new(this, "enabledInHierarchy", -1);
					r_PenabledInHierarchy.SetBelong(this.instance);
				}
				return r_PenabledInHierarchy;
			}
		}

		/// <summary>
		/// Boolean enabledSelf
		/// </summary>
		protected RSystem.RBoolean r_PenabledSelf;
		public virtual RSystem.RBoolean RPenabledSelf
		{
			get
			{
				if(r_PenabledSelf == null)
				{
					r_PenabledSelf = new(this, "enabledSelf", -1);
					r_PenabledSelf.SetBelong(this.instance);
				}
				return r_PenabledSelf;
			}
		}

		/// <summary>
		/// Boolean visible
		/// </summary>
		protected RSystem.RBoolean r_Pvisible;
		public virtual RSystem.RBoolean RPvisible
		{
			get
			{
				if(r_Pvisible == null)
				{
					r_Pvisible = new(this, "visible", -1);
					r_Pvisible.SetBelong(this.instance);
				}
				return r_Pvisible;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.MeshGenerationContext] generateVisualContent
		/// </summary>
		protected RSystem.RAction<RUnityEngine.RUIElements.RMeshGenerationContext> r_PgenerateVisualContent;
		public virtual RSystem.RAction<RUnityEngine.RUIElements.RMeshGenerationContext> RPgenerateVisualContent
		{
			get
			{
				if(r_PgenerateVisualContent == null)
				{
					r_PgenerateVisualContent = new(this, "generateVisualContent", -1);
					r_PgenerateVisualContent.SetBelong(this.instance);
				}
				return r_PgenerateVisualContent;
			}
		}

		/// <summary>
		/// Boolean requireMeasureFunction
		/// </summary>
		protected RSystem.RBoolean r_PrequireMeasureFunction;
		public virtual RSystem.RBoolean RPrequireMeasureFunction
		{
			get
			{
				if(r_PrequireMeasureFunction == null)
				{
					r_PrequireMeasureFunction = new(this, "requireMeasureFunction", -1);
					r_PrequireMeasureFunction.SetBelong(this.instance);
				}
				return r_PrequireMeasureFunction;
			}
		}

		/// <summary>
		/// RenderTargetMode subRenderTargetMode
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement.RRenderTargetMode r_PsubRenderTargetMode;
		public virtual RUnityEngine.RUIElements.RVisualElement.RRenderTargetMode RPsubRenderTargetMode
		{
			get
			{
				if(r_PsubRenderTargetMode == null)
				{
					r_PsubRenderTargetMode = new(this, "subRenderTargetMode", -1);
					r_PsubRenderTargetMode.SetBelong(this.instance);
				}
				return r_PsubRenderTargetMode;
			}
		}

		/// <summary>
		/// UnityEngine.Material defaultMaterial
		/// </summary>
		protected RUnityEngine.RMaterial r_PdefaultMaterial;
		public virtual RUnityEngine.RMaterial RPdefaultMaterial
		{
			get
			{
				if(r_PdefaultMaterial == null)
				{
					r_PdefaultMaterial = new(this, "defaultMaterial", -1);
					r_PdefaultMaterial.SetBelong(this.instance);
				}
				return r_PdefaultMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement nextParentWithEventCallback
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_PnextParentWithEventCallback;
		public virtual RUnityEngine.RUIElements.RVisualElement RPnextParentWithEventCallback
		{
			get
			{
				if(r_PnextParentWithEventCallback == null)
				{
					r_PnextParentWithEventCallback = new(this, "nextParentWithEventCallback", -1);
					r_PnextParentWithEventCallback.SetBelong(this.instance);
				}
				return r_PnextParentWithEventCallback;
			}
		}

		/// <summary>
		/// Int32 eventCallbackCategories
		/// </summary>
		protected RSystem.RInt32 r_PeventCallbackCategories;
		public virtual RSystem.RInt32 RPeventCallbackCategories
		{
			get
			{
				if(r_PeventCallbackCategories == null)
				{
					r_PeventCallbackCategories = new(this, "eventCallbackCategories", -1);
					r_PeventCallbackCategories.SetBelong(this.instance);
				}
				return r_PeventCallbackCategories;
			}
		}

		/// <summary>
		/// Int32 eventCallbackParentCategories
		/// </summary>
		protected RSystem.RInt32 r_PeventCallbackParentCategories;
		public virtual RSystem.RInt32 RPeventCallbackParentCategories
		{
			get
			{
				if(r_PeventCallbackParentCategories == null)
				{
					r_PeventCallbackParentCategories = new(this, "eventCallbackParentCategories", -1);
					r_PeventCallbackParentCategories.SetBelong(this.instance);
				}
				return r_PeventCallbackParentCategories;
			}
		}

		/// <summary>
		/// Boolean isEventCallbackParentCategoriesDirty
		/// </summary>
		protected RSystem.RBoolean r_PisEventCallbackParentCategoriesDirty;
		public virtual RSystem.RBoolean RPisEventCallbackParentCategoriesDirty
		{
			get
			{
				if(r_PisEventCallbackParentCategoriesDirty == null)
				{
					r_PisEventCallbackParentCategoriesDirty = new(this, "isEventCallbackParentCategoriesDirty", -1);
					r_PisEventCallbackParentCategoriesDirty.SetBelong(this.instance);
				}
				return r_PisEventCallbackParentCategoriesDirty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IExperimentalFeatures experimental
		/// </summary>
		protected RUnityEngine.RUIElements.RIExperimentalFeatures r_Pexperimental;
		public virtual RUnityEngine.RUIElements.RIExperimentalFeatures RPexperimental
		{
			get
			{
				if(r_Pexperimental == null)
				{
					r_Pexperimental = new(this, "experimental", -1);
					r_Pexperimental.SetBelong(this.instance);
				}
				return r_Pexperimental;
			}
		}

		/// <summary>
		/// Hierarchy hierarchy
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement.RHierarchy r_Phierarchy;
		public virtual RUnityEngine.RUIElements.RVisualElement.RHierarchy RPhierarchy
		{
			get
			{
				if(r_Phierarchy == null)
				{
					r_Phierarchy = new(this, "hierarchy", -1);
					r_Phierarchy.SetBelong(this.instance);
				}
				return r_Phierarchy;
			}
		}

		/// <summary>
		/// Boolean isRootVisualContainer
		/// </summary>
		protected RSystem.RBoolean r_PisRootVisualContainer;
		public virtual RSystem.RBoolean RPisRootVisualContainer
		{
			get
			{
				if(r_PisRootVisualContainer == null)
				{
					r_PisRootVisualContainer = new(this, "isRootVisualContainer", -1);
					r_PisRootVisualContainer.SetBelong(this.instance);
				}
				return r_PisRootVisualContainer;
			}
		}

		/// <summary>
		/// Boolean cacheAsBitmap
		/// </summary>
		protected RSystem.RBoolean r_PcacheAsBitmap;
		public virtual RSystem.RBoolean RPcacheAsBitmap
		{
			get
			{
				if(r_PcacheAsBitmap == null)
				{
					r_PcacheAsBitmap = new(this, "cacheAsBitmap", -1);
					r_PcacheAsBitmap.SetBelong(this.instance);
				}
				return r_PcacheAsBitmap;
			}
		}

		/// <summary>
		/// Boolean disableClipping
		/// </summary>
		protected RSystem.RBoolean r_PdisableClipping;
		public virtual RSystem.RBoolean RPdisableClipping
		{
			get
			{
				if(r_PdisableClipping == null)
				{
					r_PdisableClipping = new(this, "disableClipping", -1);
					r_PdisableClipping.SetBelong(this.instance);
				}
				return r_PdisableClipping;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement parent
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_Pparent;
		public virtual RUnityEngine.RUIElements.RVisualElement RPparent
		{
			get
			{
				if(r_Pparent == null)
				{
					r_Pparent = new(this, "parent", -1);
					r_Pparent.SetBelong(this.instance);
				}
				return r_Pparent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseVisualElementPanel elementPanel
		/// </summary>
		protected RUnityEngine.RUIElements.RBaseVisualElementPanel r_PelementPanel;
		public virtual RUnityEngine.RUIElements.RBaseVisualElementPanel RPelementPanel
		{
			get
			{
				if(r_PelementPanel == null)
				{
					r_PelementPanel = new(this, "elementPanel", -1);
					r_PelementPanel.SetBelong(this.instance);
				}
				return r_PelementPanel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IPanel panel
		/// </summary>
		protected RUnityEngine.RUIElements.RIPanel r_Ppanel;
		public virtual RUnityEngine.RUIElements.RIPanel RPpanel
		{
			get
			{
				if(r_Ppanel == null)
				{
					r_Ppanel = new(this, "panel", -1);
					r_Ppanel.SetBelong(this.instance);
				}
				return r_Ppanel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset visualTreeAssetSource
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualTreeAsset r_PvisualTreeAssetSource;
		public virtual RUnityEngine.RUIElements.RVisualTreeAsset RPvisualTreeAssetSource
		{
			get
			{
				if(r_PvisualTreeAssetSource == null)
				{
					r_PvisualTreeAssetSource = new(this, "visualTreeAssetSource", -1);
					r_PvisualTreeAssetSource.SetBelong(this.instance);
				}
				return r_PvisualTreeAssetSource;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement Item [Int32]
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_PItem_Int32;
		public virtual RUnityEngine.RUIElements.RVisualElement RPItem_Int32
		{
			get
			{
				if(r_PItem_Int32 == null)
				{
					r_PItem_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_PItem_Int32.SetBelong(this.instance);
				}
				return r_PItem_Int32;
			}
		}

		/// <summary>
		/// Int32 childCount
		/// </summary>
		protected RSystem.RInt32 r_PchildCount;
		public virtual RSystem.RInt32 RPchildCount
		{
			get
			{
				if(r_PchildCount == null)
				{
					r_PchildCount = new(this, "childCount", -1);
					r_PchildCount.SetBelong(this.instance);
				}
				return r_PchildCount;
			}
		}

		/// <summary>
		/// Boolean hasDefaultRotationAndScale
		/// </summary>
		protected RSystem.RBoolean r_PhasDefaultRotationAndScale;
		public virtual RSystem.RBoolean RPhasDefaultRotationAndScale
		{
			get
			{
				if(r_PhasDefaultRotationAndScale == null)
				{
					r_PhasDefaultRotationAndScale = new(this, "hasDefaultRotationAndScale", -1);
					r_PhasDefaultRotationAndScale.SetBelong(this.instance);
				}
				return r_PhasDefaultRotationAndScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduler schedule
		/// </summary>
		protected RUnityEngine.RUIElements.RIVisualElementScheduler r_Pschedule;
		public virtual RUnityEngine.RUIElements.RIVisualElementScheduler RPschedule
		{
			get
			{
				if(r_Pschedule == null)
				{
					r_Pschedule = new(this, "schedule", -1);
					r_Pschedule.SetBelong(this.instance);
				}
				return r_Pschedule;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IStyle style
		/// </summary>
		protected RUnityEngine.RUIElements.RIStyle r_Pstyle;
		public virtual RUnityEngine.RUIElements.RIStyle RPstyle
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
		/// UnityEngine.UIElements.ICustomStyle customStyle
		/// </summary>
		protected RUnityEngine.RUIElements.RICustomStyle r_PcustomStyle;
		public virtual RUnityEngine.RUIElements.RICustomStyle RPcustomStyle
		{
			get
			{
				if(r_PcustomStyle == null)
				{
					r_PcustomStyle = new(this, "customStyle", -1);
					r_PcustomStyle.SetBelong(this.instance);
				}
				return r_PcustomStyle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementStyleSheetSet styleSheets
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElementStyleSheetSet r_PstyleSheets;
		public virtual RUnityEngine.RUIElements.RVisualElementStyleSheetSet RPstyleSheets
		{
			get
			{
				if(r_PstyleSheets == null)
				{
					r_PstyleSheets = new(this, "styleSheets", -1);
					r_PstyleSheets.SetBelong(this.instance);
				}
				return r_PstyleSheets;
			}
		}

		/// <summary>
		/// System.String tooltip
		/// </summary>
		protected RSystem.RString r_Ptooltip;
		public virtual RSystem.RString RPtooltip
		{
			get
			{
				if(r_Ptooltip == null)
				{
					r_Ptooltip = new(this, "tooltip", -1);
					r_Ptooltip.SetBelong(this.instance);
				}
				return r_Ptooltip;
			}
		}

		/// <summary>
		/// Boolean focusable
		/// </summary>
		protected RSystem.RBoolean r_Pfocusable;
		public virtual RSystem.RBoolean RPfocusable
		{
			get
			{
				if(r_Pfocusable == null)
				{
					r_Pfocusable = new(this, "focusable", -1);
					r_Pfocusable.SetBelong(this.instance);
				}
				return r_Pfocusable;
			}
		}

		/// <summary>
		/// Int32 tabIndex
		/// </summary>
		protected RSystem.RInt32 r_PtabIndex;
		public virtual RSystem.RInt32 RPtabIndex
		{
			get
			{
				if(r_PtabIndex == null)
				{
					r_PtabIndex = new(this, "tabIndex", -1);
					r_PtabIndex.SetBelong(this.instance);
				}
				return r_PtabIndex;
			}
		}

		/// <summary>
		/// Boolean delegatesFocus
		/// </summary>
		protected RSystem.RBoolean r_PdelegatesFocus;
		public virtual RSystem.RBoolean RPdelegatesFocus
		{
			get
			{
				if(r_PdelegatesFocus == null)
				{
					r_PdelegatesFocus = new(this, "delegatesFocus", -1);
					r_PdelegatesFocus.SetBelong(this.instance);
				}
				return r_PdelegatesFocus;
			}
		}

		/// <summary>
		/// Boolean excludeFromFocusRing
		/// </summary>
		protected RSystem.RBoolean r_PexcludeFromFocusRing;
		public virtual RSystem.RBoolean RPexcludeFromFocusRing
		{
			get
			{
				if(r_PexcludeFromFocusRing == null)
				{
					r_PexcludeFromFocusRing = new(this, "excludeFromFocusRing", -1);
					r_PexcludeFromFocusRing.SetBelong(this.instance);
				}
				return r_PexcludeFromFocusRing;
			}
		}

		/// <summary>
		/// Void OnHorizontalScrollDragElementChanged(UnityEngine.UIElements.GeometryChangedEvent)
		/// </summary>
		protected RMethod r_MOnHorizontalScrollDragElementChanged_GeometryChangedEvent;
		public virtual RMethod RMOnHorizontalScrollDragElementChanged_GeometryChangedEvent
		{
			get
			{
				if(r_MOnHorizontalScrollDragElementChanged_GeometryChangedEvent == null)
				{
					r_MOnHorizontalScrollDragElementChanged_GeometryChangedEvent = new(this, "OnHorizontalScrollDragElementChanged", 0, typeof(UnityEngine.UIElements.GeometryChangedEvent));
					r_MOnHorizontalScrollDragElementChanged_GeometryChangedEvent.SetBelong(this.instance);
				}
				return r_MOnHorizontalScrollDragElementChanged_GeometryChangedEvent;
			}
		}

		/// <summary>
		/// Void OnVerticalScrollDragElementChanged(UnityEngine.UIElements.GeometryChangedEvent)
		/// </summary>
		protected RMethod r_MOnVerticalScrollDragElementChanged_GeometryChangedEvent;
		public virtual RMethod RMOnVerticalScrollDragElementChanged_GeometryChangedEvent
		{
			get
			{
				if(r_MOnVerticalScrollDragElementChanged_GeometryChangedEvent == null)
				{
					r_MOnVerticalScrollDragElementChanged_GeometryChangedEvent = new(this, "OnVerticalScrollDragElementChanged", 0, typeof(UnityEngine.UIElements.GeometryChangedEvent));
					r_MOnVerticalScrollDragElementChanged_GeometryChangedEvent.SetBelong(this.instance);
				}
				return r_MOnVerticalScrollDragElementChanged_GeometryChangedEvent;
			}
		}

		/// <summary>
		/// Void UpdateHorizontalSliderPageSize()
		/// </summary>
		protected RMethod r_MUpdateHorizontalSliderPageSize;
		public virtual RMethod RMUpdateHorizontalSliderPageSize
		{
			get
			{
				if(r_MUpdateHorizontalSliderPageSize == null)
				{
					r_MUpdateHorizontalSliderPageSize = new(this, "UpdateHorizontalSliderPageSize", 0);
					r_MUpdateHorizontalSliderPageSize.SetBelong(this.instance);
				}
				return r_MUpdateHorizontalSliderPageSize;
			}
		}

		/// <summary>
		/// Void UpdateVerticalSliderPageSize()
		/// </summary>
		protected RMethod r_MUpdateVerticalSliderPageSize;
		public virtual RMethod RMUpdateVerticalSliderPageSize
		{
			get
			{
				if(r_MUpdateVerticalSliderPageSize == null)
				{
					r_MUpdateVerticalSliderPageSize = new(this, "UpdateVerticalSliderPageSize", 0);
					r_MUpdateVerticalSliderPageSize.SetBelong(this.instance);
				}
				return r_MUpdateVerticalSliderPageSize;
			}
		}

		/// <summary>
		/// Void UpdateContentViewTransform()
		/// </summary>
		protected RMethod r_MUpdateContentViewTransform;
		public virtual RMethod RMUpdateContentViewTransform
		{
			get
			{
				if(r_MUpdateContentViewTransform == null)
				{
					r_MUpdateContentViewTransform = new(this, "UpdateContentViewTransform", 0);
					r_MUpdateContentViewTransform.SetBelong(this.instance);
				}
				return r_MUpdateContentViewTransform;
			}
		}

		/// <summary>
		/// Void ScrollTo(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MScrollTo_VisualElement;
		public virtual RMethod RMScrollTo_VisualElement
		{
			get
			{
				if(r_MScrollTo_VisualElement == null)
				{
					r_MScrollTo_VisualElement = new(this, "ScrollTo", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MScrollTo_VisualElement.SetBelong(this.instance);
				}
				return r_MScrollTo_VisualElement;
			}
		}

		/// <summary>
		/// Single GetXDeltaOffset(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MGetXDeltaOffset_VisualElement;
		public virtual RMethod RMGetXDeltaOffset_VisualElement
		{
			get
			{
				if(r_MGetXDeltaOffset_VisualElement == null)
				{
					r_MGetXDeltaOffset_VisualElement = new(this, "GetXDeltaOffset", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MGetXDeltaOffset_VisualElement.SetBelong(this.instance);
				}
				return r_MGetXDeltaOffset_VisualElement;
			}
		}

		/// <summary>
		/// Single GetYDeltaOffset(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MGetYDeltaOffset_VisualElement;
		public virtual RMethod RMGetYDeltaOffset_VisualElement
		{
			get
			{
				if(r_MGetYDeltaOffset_VisualElement == null)
				{
					r_MGetYDeltaOffset_VisualElement = new(this, "GetYDeltaOffset", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MGetYDeltaOffset_VisualElement.SetBelong(this.instance);
				}
				return r_MGetYDeltaOffset_VisualElement;
			}
		}

		/// <summary>
		/// Single GetDeltaDistance(Single, Single, Single, Single)
		/// </summary>
		protected RMethod r_MGetDeltaDistance_Single_Single_Single_Single;
		public virtual RMethod RMGetDeltaDistance_Single_Single_Single_Single
		{
			get
			{
				if(r_MGetDeltaDistance_Single_Single_Single_Single == null)
				{
					r_MGetDeltaDistance_Single_Single_Single_Single = new(this, "GetDeltaDistance", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_MGetDeltaDistance_Single_Single_Single_Single.SetBelong(this.instance);
				}
				return r_MGetDeltaDistance_Single_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void SetScrollViewMode(UnityEngine.UIElements.ScrollViewMode)
		/// </summary>
		protected RMethod r_MSetScrollViewMode_ScrollViewMode;
		public virtual RMethod RMSetScrollViewMode_ScrollViewMode
		{
			get
			{
				if(r_MSetScrollViewMode_ScrollViewMode == null)
				{
					r_MSetScrollViewMode_ScrollViewMode = new(this, "SetScrollViewMode", 0, typeof(UnityEngine.UIElements.ScrollViewMode));
					r_MSetScrollViewMode_ScrollViewMode.SetBelong(this.instance);
				}
				return r_MSetScrollViewMode_ScrollViewMode;
			}
		}

		/// <summary>
		/// Void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent)
		/// </summary>
		protected RMethod r_MOnAttachToPanel_AttachToPanelEvent;
		public virtual RMethod RMOnAttachToPanel_AttachToPanelEvent
		{
			get
			{
				if(r_MOnAttachToPanel_AttachToPanelEvent == null)
				{
					r_MOnAttachToPanel_AttachToPanelEvent = new(this, "OnAttachToPanel", 0, typeof(UnityEngine.UIElements.AttachToPanelEvent));
					r_MOnAttachToPanel_AttachToPanelEvent.SetBelong(this.instance);
				}
				return r_MOnAttachToPanel_AttachToPanelEvent;
			}
		}

		/// <summary>
		/// Void OnDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent)
		/// </summary>
		protected RMethod r_MOnDetachFromPanel_DetachFromPanelEvent;
		public virtual RMethod RMOnDetachFromPanel_DetachFromPanelEvent
		{
			get
			{
				if(r_MOnDetachFromPanel_DetachFromPanelEvent == null)
				{
					r_MOnDetachFromPanel_DetachFromPanelEvent = new(this, "OnDetachFromPanel", 0, typeof(UnityEngine.UIElements.DetachFromPanelEvent));
					r_MOnDetachFromPanel_DetachFromPanelEvent.SetBelong(this.instance);
				}
				return r_MOnDetachFromPanel_DetachFromPanelEvent;
			}
		}

		/// <summary>
		/// Void OnPointerCapture(UnityEngine.UIElements.PointerCaptureEvent)
		/// </summary>
		protected RMethod r_MOnPointerCapture_PointerCaptureEvent;
		public virtual RMethod RMOnPointerCapture_PointerCaptureEvent
		{
			get
			{
				if(r_MOnPointerCapture_PointerCaptureEvent == null)
				{
					r_MOnPointerCapture_PointerCaptureEvent = new(this, "OnPointerCapture", 0, typeof(UnityEngine.UIElements.PointerCaptureEvent));
					r_MOnPointerCapture_PointerCaptureEvent.SetBelong(this.instance);
				}
				return r_MOnPointerCapture_PointerCaptureEvent;
			}
		}

		/// <summary>
		/// Void OnPointerCaptureOut(UnityEngine.UIElements.PointerCaptureOutEvent)
		/// </summary>
		protected RMethod r_MOnPointerCaptureOut_PointerCaptureOutEvent;
		public virtual RMethod RMOnPointerCaptureOut_PointerCaptureOutEvent
		{
			get
			{
				if(r_MOnPointerCaptureOut_PointerCaptureOutEvent == null)
				{
					r_MOnPointerCaptureOut_PointerCaptureOutEvent = new(this, "OnPointerCaptureOut", 0, typeof(UnityEngine.UIElements.PointerCaptureOutEvent));
					r_MOnPointerCaptureOut_PointerCaptureOutEvent.SetBelong(this.instance);
				}
				return r_MOnPointerCaptureOut_PointerCaptureOutEvent;
			}
		}

		/// <summary>
		/// Void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent)
		/// </summary>
		protected RMethod r_MOnGeometryChanged_GeometryChangedEvent;
		public virtual RMethod RMOnGeometryChanged_GeometryChangedEvent
		{
			get
			{
				if(r_MOnGeometryChanged_GeometryChangedEvent == null)
				{
					r_MOnGeometryChanged_GeometryChangedEvent = new(this, "OnGeometryChanged", 0, typeof(UnityEngine.UIElements.GeometryChangedEvent));
					r_MOnGeometryChanged_GeometryChangedEvent.SetBelong(this.instance);
				}
				return r_MOnGeometryChanged_GeometryChangedEvent;
			}
		}

		/// <summary>
		/// Single ComputeElasticOffset(Single, Single, Single, Single, Single, Single)
		/// </summary>
		protected static RMethod r_MComputeElasticOffset_Single_Single_Single_Single_Single_Single;
		public static RMethod RMComputeElasticOffset_Single_Single_Single_Single_Single_Single
		{
			get
			{
				if(r_MComputeElasticOffset_Single_Single_Single_Single_Single_Single == null)
				{
					r_MComputeElasticOffset_Single_Single_Single_Single_Single_Single = new(typeof(UnityEngine.UIElements.ScrollView), "ComputeElasticOffset", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_MComputeElasticOffset_Single_Single_Single_Single_Single_Single.SetBelong(null);
				}
				return r_MComputeElasticOffset_Single_Single_Single_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void ComputeInitialSpringBackVelocity()
		/// </summary>
		protected RMethod r_MComputeInitialSpringBackVelocity;
		public virtual RMethod RMComputeInitialSpringBackVelocity
		{
			get
			{
				if(r_MComputeInitialSpringBackVelocity == null)
				{
					r_MComputeInitialSpringBackVelocity = new(this, "ComputeInitialSpringBackVelocity", 0);
					r_MComputeInitialSpringBackVelocity.SetBelong(this.instance);
				}
				return r_MComputeInitialSpringBackVelocity;
			}
		}

		/// <summary>
		/// Void SpringBack()
		/// </summary>
		protected RMethod r_MSpringBack;
		public virtual RMethod RMSpringBack
		{
			get
			{
				if(r_MSpringBack == null)
				{
					r_MSpringBack = new(this, "SpringBack", 0);
					r_MSpringBack.SetBelong(this.instance);
				}
				return r_MSpringBack;
			}
		}

		/// <summary>
		/// Void ApplyScrollInertia()
		/// </summary>
		protected RMethod r_MApplyScrollInertia;
		public virtual RMethod RMApplyScrollInertia
		{
			get
			{
				if(r_MApplyScrollInertia == null)
				{
					r_MApplyScrollInertia = new(this, "ApplyScrollInertia", 0);
					r_MApplyScrollInertia.SetBelong(this.instance);
				}
				return r_MApplyScrollInertia;
			}
		}

		/// <summary>
		/// Void PostPointerUpAnimation()
		/// </summary>
		protected RMethod r_MPostPointerUpAnimation;
		public virtual RMethod RMPostPointerUpAnimation
		{
			get
			{
				if(r_MPostPointerUpAnimation == null)
				{
					r_MPostPointerUpAnimation = new(this, "PostPointerUpAnimation", 0);
					r_MPostPointerUpAnimation.SetBelong(this.instance);
				}
				return r_MPostPointerUpAnimation;
			}
		}

		/// <summary>
		/// Void OnPointerDown(UnityEngine.UIElements.PointerDownEvent)
		/// </summary>
		protected RMethod r_MOnPointerDown_PointerDownEvent;
		public virtual RMethod RMOnPointerDown_PointerDownEvent
		{
			get
			{
				if(r_MOnPointerDown_PointerDownEvent == null)
				{
					r_MOnPointerDown_PointerDownEvent = new(this, "OnPointerDown", 0, typeof(UnityEngine.UIElements.PointerDownEvent));
					r_MOnPointerDown_PointerDownEvent.SetBelong(this.instance);
				}
				return r_MOnPointerDown_PointerDownEvent;
			}
		}

		/// <summary>
		/// Void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent)
		/// </summary>
		protected RMethod r_MOnPointerMove_PointerMoveEvent;
		public virtual RMethod RMOnPointerMove_PointerMoveEvent
		{
			get
			{
				if(r_MOnPointerMove_PointerMoveEvent == null)
				{
					r_MOnPointerMove_PointerMoveEvent = new(this, "OnPointerMove", 0, typeof(UnityEngine.UIElements.PointerMoveEvent));
					r_MOnPointerMove_PointerMoveEvent.SetBelong(this.instance);
				}
				return r_MOnPointerMove_PointerMoveEvent;
			}
		}

		/// <summary>
		/// Void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent)
		/// </summary>
		protected RMethod r_MOnPointerCancel_PointerCancelEvent;
		public virtual RMethod RMOnPointerCancel_PointerCancelEvent
		{
			get
			{
				if(r_MOnPointerCancel_PointerCancelEvent == null)
				{
					r_MOnPointerCancel_PointerCancelEvent = new(this, "OnPointerCancel", 0, typeof(UnityEngine.UIElements.PointerCancelEvent));
					r_MOnPointerCancel_PointerCancelEvent.SetBelong(this.instance);
				}
				return r_MOnPointerCancel_PointerCancelEvent;
			}
		}

		/// <summary>
		/// Void OnPointerUp(UnityEngine.UIElements.PointerUpEvent)
		/// </summary>
		protected RMethod r_MOnPointerUp_PointerUpEvent;
		public virtual RMethod RMOnPointerUp_PointerUpEvent
		{
			get
			{
				if(r_MOnPointerUp_PointerUpEvent == null)
				{
					r_MOnPointerUp_PointerUpEvent = new(this, "OnPointerUp", 0, typeof(UnityEngine.UIElements.PointerUpEvent));
					r_MOnPointerUp_PointerUpEvent.SetBelong(this.instance);
				}
				return r_MOnPointerUp_PointerUpEvent;
			}
		}

		/// <summary>
		/// Void InitTouchScrolling(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MInitTouchScrolling_Vector2;
		public virtual RMethod RMInitTouchScrolling_Vector2
		{
			get
			{
				if(r_MInitTouchScrolling_Vector2 == null)
				{
					r_MInitTouchScrolling_Vector2 = new(this, "InitTouchScrolling", 0, typeof(UnityEngine.Vector2));
					r_MInitTouchScrolling_Vector2.SetBelong(this.instance);
				}
				return r_MInitTouchScrolling_Vector2;
			}
		}

		/// <summary>
		/// TouchScrollingResult ComputeTouchScrolling(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MComputeTouchScrolling_Vector2;
		public virtual RMethod RMComputeTouchScrolling_Vector2
		{
			get
			{
				if(r_MComputeTouchScrolling_Vector2 == null)
				{
					r_MComputeTouchScrolling_Vector2 = new(this, "ComputeTouchScrolling", 0, typeof(UnityEngine.Vector2));
					r_MComputeTouchScrolling_Vector2.SetBelong(this.instance);
				}
				return r_MComputeTouchScrolling_Vector2;
			}
		}

		/// <summary>
		/// Boolean ApplyTouchScrolling(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MApplyTouchScrolling_Vector2;
		public virtual RMethod RMApplyTouchScrolling_Vector2
		{
			get
			{
				if(r_MApplyTouchScrolling_Vector2 == null)
				{
					r_MApplyTouchScrolling_Vector2 = new(this, "ApplyTouchScrolling", 0, typeof(UnityEngine.Vector2));
					r_MApplyTouchScrolling_Vector2.SetBelong(this.instance);
				}
				return r_MApplyTouchScrolling_Vector2;
			}
		}

		/// <summary>
		/// Boolean ReleaseScrolling(Int32, UnityEngine.UIElements.IEventHandler)
		/// </summary>
		protected RMethod r_MReleaseScrolling_Int32_IEventHandler;
		public virtual RMethod RMReleaseScrolling_Int32_IEventHandler
		{
			get
			{
				if(r_MReleaseScrolling_Int32_IEventHandler == null)
				{
					r_MReleaseScrolling_Int32_IEventHandler = new(this, "ReleaseScrolling", 0, typeof(System.Int32), typeof(UnityEngine.UIElements.IEventHandler));
					r_MReleaseScrolling_Int32_IEventHandler.SetBelong(this.instance);
				}
				return r_MReleaseScrolling_Int32_IEventHandler;
			}
		}

		/// <summary>
		/// Void ExecuteElasticSpringAnimation()
		/// </summary>
		protected RMethod r_MExecuteElasticSpringAnimation;
		public virtual RMethod RMExecuteElasticSpringAnimation
		{
			get
			{
				if(r_MExecuteElasticSpringAnimation == null)
				{
					r_MExecuteElasticSpringAnimation = new(this, "ExecuteElasticSpringAnimation", 0);
					r_MExecuteElasticSpringAnimation.SetBelong(this.instance);
				}
				return r_MExecuteElasticSpringAnimation;
			}
		}

		/// <summary>
		/// Void AdjustScrollers()
		/// </summary>
		protected RMethod r_MAdjustScrollers;
		public virtual RMethod RMAdjustScrollers
		{
			get
			{
				if(r_MAdjustScrollers == null)
				{
					r_MAdjustScrollers = new(this, "AdjustScrollers", 0);
					r_MAdjustScrollers.SetBelong(this.instance);
				}
				return r_MAdjustScrollers;
			}
		}

		/// <summary>
		/// Void DelayUpdateScrollers()
		/// </summary>
		protected RMethod r_MDelayUpdateScrollers;
		public virtual RMethod RMDelayUpdateScrollers
		{
			get
			{
				if(r_MDelayUpdateScrollers == null)
				{
					r_MDelayUpdateScrollers = new(this, "DelayUpdateScrollers", 0);
					r_MDelayUpdateScrollers.SetBelong(this.instance);
				}
				return r_MDelayUpdateScrollers;
			}
		}

		/// <summary>
		/// Void UpdateScrollers()
		/// </summary>
		protected RMethod r_MUpdateScrollers;
		public virtual RMethod RMUpdateScrollers
		{
			get
			{
				if(r_MUpdateScrollers == null)
				{
					r_MUpdateScrollers = new(this, "UpdateScrollers", 0);
					r_MUpdateScrollers.SetBelong(this.instance);
				}
				return r_MUpdateScrollers;
			}
		}

		/// <summary>
		/// Void UpdateViewportContentMargins(Boolean, Boolean)
		/// </summary>
		protected RMethod r_MUpdateViewportContentMargins_Boolean_Boolean;
		public virtual RMethod RMUpdateViewportContentMargins_Boolean_Boolean
		{
			get
			{
				if(r_MUpdateViewportContentMargins_Boolean_Boolean == null)
				{
					r_MUpdateViewportContentMargins_Boolean_Boolean = new(this, "UpdateViewportContentMargins", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_MUpdateViewportContentMargins_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MUpdateViewportContentMargins_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void UpdateScrollers(Boolean, Boolean)
		/// </summary>
		protected RMethod r_MUpdateScrollers_Boolean_Boolean;
		public virtual RMethod RMUpdateScrollers_Boolean_Boolean
		{
			get
			{
				if(r_MUpdateScrollers_Boolean_Boolean == null)
				{
					r_MUpdateScrollers_Boolean_Boolean = new(this, "UpdateScrollers", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_MUpdateScrollers_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_MUpdateScrollers_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void OnScrollersGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent)
		/// </summary>
		protected RMethod r_MOnScrollersGeometryChanged_GeometryChangedEvent;
		public virtual RMethod RMOnScrollersGeometryChanged_GeometryChangedEvent
		{
			get
			{
				if(r_MOnScrollersGeometryChanged_GeometryChangedEvent == null)
				{
					r_MOnScrollersGeometryChanged_GeometryChangedEvent = new(this, "OnScrollersGeometryChanged", 0, typeof(UnityEngine.UIElements.GeometryChangedEvent));
					r_MOnScrollersGeometryChanged_GeometryChangedEvent.SetBelong(this.instance);
				}
				return r_MOnScrollersGeometryChanged_GeometryChangedEvent;
			}
		}

		/// <summary>
		/// Void OnScrollWheel(UnityEngine.UIElements.WheelEvent)
		/// </summary>
		protected RMethod r_MOnScrollWheel_WheelEvent;
		public virtual RMethod RMOnScrollWheel_WheelEvent
		{
			get
			{
				if(r_MOnScrollWheel_WheelEvent == null)
				{
					r_MOnScrollWheel_WheelEvent = new(this, "OnScrollWheel", 0, typeof(UnityEngine.UIElements.WheelEvent));
					r_MOnScrollWheel_WheelEvent.SetBelong(this.instance);
				}
				return r_MOnScrollWheel_WheelEvent;
			}
		}

		/// <summary>
		/// Void OnRootCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent)
		/// </summary>
		protected RMethod r_MOnRootCustomStyleResolved_CustomStyleResolvedEvent;
		public virtual RMethod RMOnRootCustomStyleResolved_CustomStyleResolvedEvent
		{
			get
			{
				if(r_MOnRootCustomStyleResolved_CustomStyleResolvedEvent == null)
				{
					r_MOnRootCustomStyleResolved_CustomStyleResolvedEvent = new(this, "OnRootCustomStyleResolved", 0, typeof(UnityEngine.UIElements.CustomStyleResolvedEvent));
					r_MOnRootCustomStyleResolved_CustomStyleResolvedEvent.SetBelong(this.instance);
				}
				return r_MOnRootCustomStyleResolved_CustomStyleResolvedEvent;
			}
		}

		/// <summary>
		/// Void ReadSingleLineHeight()
		/// </summary>
		protected RMethod r_MReadSingleLineHeight;
		public virtual RMethod RMReadSingleLineHeight
		{
			get
			{
				if(r_MReadSingleLineHeight == null)
				{
					r_MReadSingleLineHeight = new(this, "ReadSingleLineHeight", 0);
					r_MReadSingleLineHeight.SetBelong(this.instance);
				}
				return r_MReadSingleLineHeight;
			}
		}

		/// <summary>
		/// Void <.ctor>b__111_0(Single)
		/// </summary>
		protected RMethod r_M__0____2__ctor__1__b__111_0_Single;
		public virtual RMethod RM__0____2__ctor__1__b__111_0_Single
		{
			get
			{
				if(r_M__0____2__ctor__1__b__111_0_Single == null)
				{
					r_M__0____2__ctor__1__b__111_0_Single = new(this, "<.ctor>b__111_0", 0, typeof(System.Single));
					r_M__0____2__ctor__1__b__111_0_Single.SetBelong(this.instance);
				}
				return r_M__0____2__ctor__1__b__111_0_Single;
			}
		}

		/// <summary>
		/// Void <.ctor>b__111_1(Single)
		/// </summary>
		protected RMethod r_M__0____2__ctor__1__b__111_1_Single;
		public virtual RMethod RM__0____2__ctor__1__b__111_1_Single
		{
			get
			{
				if(r_M__0____2__ctor__1__b__111_1_Single == null)
				{
					r_M__0____2__ctor__1__b__111_1_Single = new(this, "<.ctor>b__111_1", 0, typeof(System.Single));
					r_M__0____2__ctor__1__b__111_1_Single.SetBelong(this.instance);
				}
				return r_M__0____2__ctor__1__b__111_1_Single;
			}
		}

		/// <summary>
		/// Boolean TryConvertLengthUnits(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Length ByRef, UnityEngine.UIElements.Length ByRef, Int32)
		/// </summary>
		protected RMethod r_MTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32;
		public virtual RMethod RMTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32
		{
			get
			{
				if(r_MTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32 == null)
				{
					r_MTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32 = new(this, "TryConvertLengthUnits", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Length).MakeByRefType(), typeof(UnityEngine.UIElements.Length).MakeByRefType(), typeof(System.Int32));
					r_MTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32.SetBelong(this.instance);
				}
				return r_MTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32;
			}
		}

		/// <summary>
		/// Boolean TryConvertTransformOriginUnits(UnityEngine.UIElements.TransformOrigin ByRef, UnityEngine.UIElements.TransformOrigin ByRef)
		/// </summary>
		protected RMethod r_MTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin;
		public virtual RMethod RMTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin
		{
			get
			{
				if(r_MTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin == null)
				{
					r_MTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin = new(this, "TryConvertTransformOriginUnits", 0, typeof(UnityEngine.UIElements.TransformOrigin).MakeByRefType(), typeof(UnityEngine.UIElements.TransformOrigin).MakeByRefType());
					r_MTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin.SetBelong(this.instance);
				}
				return r_MTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin;
			}
		}

		/// <summary>
		/// Boolean TryConvertTranslateUnits(UnityEngine.UIElements.Translate ByRef, UnityEngine.UIElements.Translate ByRef)
		/// </summary>
		protected RMethod r_MTryConvertTranslateUnits_Ref_Translate_Ref_Translate;
		public virtual RMethod RMTryConvertTranslateUnits_Ref_Translate_Ref_Translate
		{
			get
			{
				if(r_MTryConvertTranslateUnits_Ref_Translate_Ref_Translate == null)
				{
					r_MTryConvertTranslateUnits_Ref_Translate_Ref_Translate = new(this, "TryConvertTranslateUnits", 0, typeof(UnityEngine.UIElements.Translate).MakeByRefType(), typeof(UnityEngine.UIElements.Translate).MakeByRefType());
					r_MTryConvertTranslateUnits_Ref_Translate_Ref_Translate.SetBelong(this.instance);
				}
				return r_MTryConvertTranslateUnits_Ref_Translate_Ref_Translate;
			}
		}

		/// <summary>
		/// Boolean TryConvertBackgroundPositionUnits(UnityEngine.UIElements.BackgroundPosition ByRef, UnityEngine.UIElements.BackgroundPosition ByRef)
		/// </summary>
		protected RMethod r_MTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition;
		public virtual RMethod RMTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition
		{
			get
			{
				if(r_MTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition == null)
				{
					r_MTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition = new(this, "TryConvertBackgroundPositionUnits", 0, typeof(UnityEngine.UIElements.BackgroundPosition).MakeByRefType(), typeof(UnityEngine.UIElements.BackgroundPosition).MakeByRefType());
					r_MTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition.SetBelong(this.instance);
				}
				return r_MTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition;
			}
		}

		/// <summary>
		/// Boolean TryConvertBackgroundSizeUnits(UnityEngine.UIElements.BackgroundSize ByRef, UnityEngine.UIElements.BackgroundSize ByRef)
		/// </summary>
		protected RMethod r_MTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize;
		public virtual RMethod RMTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize
		{
			get
			{
				if(r_MTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize == null)
				{
					r_MTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize = new(this, "TryConvertBackgroundSizeUnits", 0, typeof(UnityEngine.UIElements.BackgroundSize).MakeByRefType(), typeof(UnityEngine.UIElements.BackgroundSize).MakeByRefType());
					r_MTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize.SetBelong(this.instance);
				}
				return r_MTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize;
			}
		}

		/// <summary>
		/// Void MarkRenderHintsClean()
		/// </summary>
		protected RMethod r_MMarkRenderHintsClean;
		public virtual RMethod RMMarkRenderHintsClean
		{
			get
			{
				if(r_MMarkRenderHintsClean == null)
				{
					r_MMarkRenderHintsClean = new(this, "MarkRenderHintsClean", 0);
					r_MMarkRenderHintsClean.SetBelong(this.instance);
				}
				return r_MMarkRenderHintsClean;
			}
		}

		/// <summary>
		/// Void UpdateBoundingBox()
		/// </summary>
		protected RMethod r_MUpdateBoundingBox;
		public virtual RMethod RMUpdateBoundingBox
		{
			get
			{
				if(r_MUpdateBoundingBox == null)
				{
					r_MUpdateBoundingBox = new(this, "UpdateBoundingBox", 0);
					r_MUpdateBoundingBox.SetBelong(this.instance);
				}
				return r_MUpdateBoundingBox;
			}
		}

		/// <summary>
		/// Void UpdateWorldBoundingBox()
		/// </summary>
		protected RMethod r_MUpdateWorldBoundingBox;
		public virtual RMethod RMUpdateWorldBoundingBox
		{
			get
			{
				if(r_MUpdateWorldBoundingBox == null)
				{
					r_MUpdateWorldBoundingBox = new(this, "UpdateWorldBoundingBox", 0);
					r_MUpdateWorldBoundingBox.SetBelong(this.instance);
				}
				return r_MUpdateWorldBoundingBox;
			}
		}

		/// <summary>
		/// Void UpdateWorldTransform()
		/// </summary>
		protected RMethod r_MUpdateWorldTransform;
		public virtual RMethod RMUpdateWorldTransform
		{
			get
			{
				if(r_MUpdateWorldTransform == null)
				{
					r_MUpdateWorldTransform = new(this, "UpdateWorldTransform", 0);
					r_MUpdateWorldTransform.SetBelong(this.instance);
				}
				return r_MUpdateWorldTransform;
			}
		}

		/// <summary>
		/// Void UpdateWorldTransformInverse()
		/// </summary>
		protected RMethod r_MUpdateWorldTransformInverse;
		public virtual RMethod RMUpdateWorldTransformInverse
		{
			get
			{
				if(r_MUpdateWorldTransformInverse == null)
				{
					r_MUpdateWorldTransformInverse = new(this, "UpdateWorldTransformInverse", 0);
					r_MUpdateWorldTransformInverse.SetBelong(this.instance);
				}
				return r_MUpdateWorldTransformInverse;
			}
		}

		/// <summary>
		/// Void EnsureWorldTransformAndClipUpToDate()
		/// </summary>
		protected RMethod r_MEnsureWorldTransformAndClipUpToDate;
		public virtual RMethod RMEnsureWorldTransformAndClipUpToDate
		{
			get
			{
				if(r_MEnsureWorldTransformAndClipUpToDate == null)
				{
					r_MEnsureWorldTransformAndClipUpToDate = new(this, "EnsureWorldTransformAndClipUpToDate", 0);
					r_MEnsureWorldTransformAndClipUpToDate.SetBelong(this.instance);
				}
				return r_MEnsureWorldTransformAndClipUpToDate;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MExecuteDefaultAction_EventBase;
		public virtual RMethod RMExecuteDefaultAction_EventBase
		{
			get
			{
				if(r_MExecuteDefaultAction_EventBase == null)
				{
					r_MExecuteDefaultAction_EventBase = new(this, "ExecuteDefaultAction", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MExecuteDefaultAction_EventBase.SetBelong(this.instance);
				}
				return r_MExecuteDefaultAction_EventBase;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetTooltipRect()
		/// </summary>
		protected RMethod r_MGetTooltipRect;
		public virtual RMethod RMGetTooltipRect
		{
			get
			{
				if(r_MGetTooltipRect == null)
				{
					r_MGetTooltipRect = new(this, "GetTooltipRect", 0);
					r_MGetTooltipRect.SetBelong(this.instance);
				}
				return r_MGetTooltipRect;
			}
		}

		/// <summary>
		/// Void Focus()
		/// </summary>
		protected RMethod r_MFocus;
		public virtual RMethod RMFocus
		{
			get
			{
				if(r_MFocus == null)
				{
					r_MFocus = new(this, "Focus", 0);
					r_MFocus.SetBelong(this.instance);
				}
				return r_MFocus;
			}
		}

		/// <summary>
		/// Void SetPanel(UnityEngine.UIElements.BaseVisualElementPanel)
		/// </summary>
		protected RMethod r_MSetPanel_BaseVisualElementPanel;
		public virtual RMethod RMSetPanel_BaseVisualElementPanel
		{
			get
			{
				if(r_MSetPanel_BaseVisualElementPanel == null)
				{
					r_MSetPanel_BaseVisualElementPanel = new(this, "SetPanel", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.BaseVisualElementPanel"));
					r_MSetPanel_BaseVisualElementPanel.SetBelong(this.instance);
				}
				return r_MSetPanel_BaseVisualElementPanel;
			}
		}

		/// <summary>
		/// Void SendEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MSendEvent_EventBase;
		public virtual RMethod RMSendEvent_EventBase
		{
			get
			{
				if(r_MSendEvent_EventBase == null)
				{
					r_MSendEvent_EventBase = new(this, "SendEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MSendEvent_EventBase.SetBelong(this.instance);
				}
				return r_MSendEvent_EventBase;
			}
		}

		/// <summary>
		/// Void SendEvent(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_MSendEvent_EventBase_DispatchMode;
		public virtual RMethod RMSendEvent_EventBase_DispatchMode
		{
			get
			{
				if(r_MSendEvent_EventBase_DispatchMode == null)
				{
					r_MSendEvent_EventBase_DispatchMode = new(this, "SendEvent", 0, typeof(UnityEngine.UIElements.EventBase),  ReflectionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
					r_MSendEvent_EventBase_DispatchMode.SetBelong(this.instance);
				}
				return r_MSendEvent_EventBase_DispatchMode;
			}
		}

		/// <summary>
		/// Void IncrementVersion(UnityEngine.UIElements.VersionChangeType)
		/// </summary>
		protected RMethod r_MIncrementVersion_VersionChangeType;
		public virtual RMethod RMIncrementVersion_VersionChangeType
		{
			get
			{
				if(r_MIncrementVersion_VersionChangeType == null)
				{
					r_MIncrementVersion_VersionChangeType = new(this, "IncrementVersion", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.VersionChangeType"));
					r_MIncrementVersion_VersionChangeType.SetBelong(this.instance);
				}
				return r_MIncrementVersion_VersionChangeType;
			}
		}

		/// <summary>
		/// Void InvokeHierarchyChanged(UnityEngine.UIElements.HierarchyChangeType)
		/// </summary>
		protected RMethod r_MInvokeHierarchyChanged_HierarchyChangeType;
		public virtual RMethod RMInvokeHierarchyChanged_HierarchyChangeType
		{
			get
			{
				if(r_MInvokeHierarchyChanged_HierarchyChangeType == null)
				{
					r_MInvokeHierarchyChanged_HierarchyChangeType = new(this, "InvokeHierarchyChanged", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.HierarchyChangeType"));
					r_MInvokeHierarchyChanged_HierarchyChangeType.SetBelong(this.instance);
				}
				return r_MInvokeHierarchyChanged_HierarchyChangeType;
			}
		}

		/// <summary>
		/// Boolean SetEnabledFromHierarchy(Boolean)
		/// </summary>
		protected RMethod r_MSetEnabledFromHierarchy_Boolean;
		public virtual RMethod RMSetEnabledFromHierarchy_Boolean
		{
			get
			{
				if(r_MSetEnabledFromHierarchy_Boolean == null)
				{
					r_MSetEnabledFromHierarchy_Boolean = new(this, "SetEnabledFromHierarchy", 0, typeof(System.Boolean));
					r_MSetEnabledFromHierarchy_Boolean.SetBelong(this.instance);
				}
				return r_MSetEnabledFromHierarchy_Boolean;
			}
		}

		/// <summary>
		/// Void SetEnabled(Boolean)
		/// </summary>
		protected RMethod r_MSetEnabled_Boolean;
		public virtual RMethod RMSetEnabled_Boolean
		{
			get
			{
				if(r_MSetEnabled_Boolean == null)
				{
					r_MSetEnabled_Boolean = new(this, "SetEnabled", 0, typeof(System.Boolean));
					r_MSetEnabled_Boolean.SetBelong(this.instance);
				}
				return r_MSetEnabled_Boolean;
			}
		}

		/// <summary>
		/// Void MarkDirtyRepaint()
		/// </summary>
		protected RMethod r_MMarkDirtyRepaint;
		public virtual RMethod RMMarkDirtyRepaint
		{
			get
			{
				if(r_MMarkDirtyRepaint == null)
				{
					r_MMarkDirtyRepaint = new(this, "MarkDirtyRepaint", 0);
					r_MMarkDirtyRepaint.SetBelong(this.instance);
				}
				return r_MMarkDirtyRepaint;
			}
		}

		/// <summary>
		/// Void InvokeGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext)
		/// </summary>
		protected RMethod r_MInvokeGenerateVisualContent_MeshGenerationContext;
		public virtual RMethod RMInvokeGenerateVisualContent_MeshGenerationContext
		{
			get
			{
				if(r_MInvokeGenerateVisualContent_MeshGenerationContext == null)
				{
					r_MInvokeGenerateVisualContent_MeshGenerationContext = new(this, "InvokeGenerateVisualContent", 0, typeof(UnityEngine.UIElements.MeshGenerationContext));
					r_MInvokeGenerateVisualContent_MeshGenerationContext.SetBelong(this.instance);
				}
				return r_MInvokeGenerateVisualContent_MeshGenerationContext;
			}
		}

		/// <summary>
		/// Void GetFullHierarchicalViewDataKey(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_MGetFullHierarchicalViewDataKey_StringBuilder;
		public virtual RMethod RMGetFullHierarchicalViewDataKey_StringBuilder
		{
			get
			{
				if(r_MGetFullHierarchicalViewDataKey_StringBuilder == null)
				{
					r_MGetFullHierarchicalViewDataKey_StringBuilder = new(this, "GetFullHierarchicalViewDataKey", 0, typeof(System.Text.StringBuilder));
					r_MGetFullHierarchicalViewDataKey_StringBuilder.SetBelong(this.instance);
				}
				return r_MGetFullHierarchicalViewDataKey_StringBuilder;
			}
		}

		/// <summary>
		/// System.String GetFullHierarchicalViewDataKey()
		/// </summary>
		protected RMethod r_MGetFullHierarchicalViewDataKey;
		public virtual RMethod RMGetFullHierarchicalViewDataKey
		{
			get
			{
				if(r_MGetFullHierarchicalViewDataKey == null)
				{
					r_MGetFullHierarchicalViewDataKey = new(this, "GetFullHierarchicalViewDataKey", 0);
					r_MGetFullHierarchicalViewDataKey.SetBelong(this.instance);
				}
				return r_MGetFullHierarchicalViewDataKey;
			}
		}

		/// <summary>
		/// T GetOrCreateViewData[T](System.Object, System.String)
		/// </summary>
		protected RMethod r_MGetOrCreateViewData_GT_Object_String;
		public virtual RMethod RMGetOrCreateViewData_GT_Object_String
		{
			get
			{
				if(r_MGetOrCreateViewData_GT_Object_String == null)
				{
					r_MGetOrCreateViewData_GT_Object_String = new(this, "GetOrCreateViewData", 1, typeof(System.Object), typeof(System.String));
					r_MGetOrCreateViewData_GT_Object_String.SetBelong(this.instance);
				}
				return r_MGetOrCreateViewData_GT_Object_String;
			}
		}

		/// <summary>
		/// T GetOrCreateViewData[T](UnityEngine.ScriptableObject, System.String)
		/// </summary>
		protected RMethod r_MGetOrCreateViewData_GT_ScriptableObject_String;
		public virtual RMethod RMGetOrCreateViewData_GT_ScriptableObject_String
		{
			get
			{
				if(r_MGetOrCreateViewData_GT_ScriptableObject_String == null)
				{
					r_MGetOrCreateViewData_GT_ScriptableObject_String = new(this, "GetOrCreateViewData", 1, typeof(UnityEngine.ScriptableObject), typeof(System.String));
					r_MGetOrCreateViewData_GT_ScriptableObject_String.SetBelong(this.instance);
				}
				return r_MGetOrCreateViewData_GT_ScriptableObject_String;
			}
		}

		/// <summary>
		/// Void OverwriteFromViewData(System.Object, System.String)
		/// </summary>
		protected RMethod r_MOverwriteFromViewData_Object_String;
		public virtual RMethod RMOverwriteFromViewData_Object_String
		{
			get
			{
				if(r_MOverwriteFromViewData_Object_String == null)
				{
					r_MOverwriteFromViewData_Object_String = new(this, "OverwriteFromViewData", 0, typeof(System.Object), typeof(System.String));
					r_MOverwriteFromViewData_Object_String.SetBelong(this.instance);
				}
				return r_MOverwriteFromViewData_Object_String;
			}
		}

		/// <summary>
		/// Void SaveViewData()
		/// </summary>
		protected RMethod r_MSaveViewData;
		public virtual RMethod RMSaveViewData
		{
			get
			{
				if(r_MSaveViewData == null)
				{
					r_MSaveViewData = new(this, "SaveViewData", 0);
					r_MSaveViewData.SetBelong(this.instance);
				}
				return r_MSaveViewData;
			}
		}

		/// <summary>
		/// Boolean IsViewDataPersitenceSupportedOnChildren(Boolean)
		/// </summary>
		protected RMethod r_MIsViewDataPersitenceSupportedOnChildren_Boolean;
		public virtual RMethod RMIsViewDataPersitenceSupportedOnChildren_Boolean
		{
			get
			{
				if(r_MIsViewDataPersitenceSupportedOnChildren_Boolean == null)
				{
					r_MIsViewDataPersitenceSupportedOnChildren_Boolean = new(this, "IsViewDataPersitenceSupportedOnChildren", 0, typeof(System.Boolean));
					r_MIsViewDataPersitenceSupportedOnChildren_Boolean.SetBelong(this.instance);
				}
				return r_MIsViewDataPersitenceSupportedOnChildren_Boolean;
			}
		}

		/// <summary>
		/// Void OnViewDataReady(Boolean)
		/// </summary>
		protected RMethod r_MOnViewDataReady_Boolean;
		public virtual RMethod RMOnViewDataReady_Boolean
		{
			get
			{
				if(r_MOnViewDataReady_Boolean == null)
				{
					r_MOnViewDataReady_Boolean = new(this, "OnViewDataReady", 0, typeof(System.Boolean));
					r_MOnViewDataReady_Boolean.SetBelong(this.instance);
				}
				return r_MOnViewDataReady_Boolean;
			}
		}

		/// <summary>
		/// Void OnViewDataReady()
		/// </summary>
		protected RMethod r_MOnViewDataReady;
		public virtual RMethod RMOnViewDataReady
		{
			get
			{
				if(r_MOnViewDataReady == null)
				{
					r_MOnViewDataReady = new(this, "OnViewDataReady", 0);
					r_MOnViewDataReady.SetBelong(this.instance);
				}
				return r_MOnViewDataReady;
			}
		}

		/// <summary>
		/// Boolean ContainsPoint(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MContainsPoint_Vector2;
		public virtual RMethod RMContainsPoint_Vector2
		{
			get
			{
				if(r_MContainsPoint_Vector2 == null)
				{
					r_MContainsPoint_Vector2 = new(this, "ContainsPoint", 0, typeof(UnityEngine.Vector2));
					r_MContainsPoint_Vector2.SetBelong(this.instance);
				}
				return r_MContainsPoint_Vector2;
			}
		}

		/// <summary>
		/// Boolean Overlaps(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MOverlaps_Rect;
		public virtual RMethod RMOverlaps_Rect
		{
			get
			{
				if(r_MOverlaps_Rect == null)
				{
					r_MOverlaps_Rect = new(this, "Overlaps", 0, typeof(UnityEngine.Rect));
					r_MOverlaps_Rect.SetBelong(this.instance);
				}
				return r_MOverlaps_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 DoMeasure(Single, MeasureMode, Single, MeasureMode)
		/// </summary>
		protected RMethod r_MDoMeasure_Single_MeasureMode_Single_MeasureMode;
		public virtual RMethod RMDoMeasure_Single_MeasureMode_Single_MeasureMode
		{
			get
			{
				if(r_MDoMeasure_Single_MeasureMode_Single_MeasureMode == null)
				{
					r_MDoMeasure_Single_MeasureMode_Single_MeasureMode = new(this, "DoMeasure", 0, typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+MeasureMode"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElement+MeasureMode"));
					r_MDoMeasure_Single_MeasureMode_Single_MeasureMode.SetBelong(this.instance);
				}
				return r_MDoMeasure_Single_MeasureMode_Single_MeasureMode;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaSize Measure(UnityEngine.Yoga.YogaNode, Single, UnityEngine.Yoga.YogaMeasureMode, Single, UnityEngine.Yoga.YogaMeasureMode)
		/// </summary>
		protected RMethod r_MMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode;
		public virtual RMethod RMMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode
		{
			get
			{
				if(r_MMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode == null)
				{
					r_MMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode = new(this, "Measure", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaNode"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Yoga.YogaMeasureMode"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Yoga.YogaMeasureMode"));
					r_MMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode.SetBelong(this.instance);
				}
				return r_MMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode;
			}
		}

		/// <summary>
		/// Void SetSize(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MSetSize_Vector2;
		public virtual RMethod RMSetSize_Vector2
		{
			get
			{
				if(r_MSetSize_Vector2 == null)
				{
					r_MSetSize_Vector2 = new(this, "SetSize", 0, typeof(UnityEngine.Vector2));
					r_MSetSize_Vector2.SetBelong(this.instance);
				}
				return r_MSetSize_Vector2;
			}
		}

		/// <summary>
		/// Void SetInlineRule(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleRule)
		/// </summary>
		protected RMethod r_MSetInlineRule_StyleSheet_StyleRule;
		public virtual RMethod RMSetInlineRule_StyleSheet_StyleRule
		{
			get
			{
				if(r_MSetInlineRule_StyleSheet_StyleRule == null)
				{
					r_MSetInlineRule_StyleSheet_StyleRule = new(this, "SetInlineRule", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleRule"));
					r_MSetInlineRule_StyleSheet_StyleRule.SetBelong(this.instance);
				}
				return r_MSetInlineRule_StyleSheet_StyleRule;
			}
		}

		/// <summary>
		/// Void UpdateInlineRule(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleRule)
		/// </summary>
		protected RMethod r_MUpdateInlineRule_StyleSheet_StyleRule;
		public virtual RMethod RMUpdateInlineRule_StyleSheet_StyleRule
		{
			get
			{
				if(r_MUpdateInlineRule_StyleSheet_StyleRule == null)
				{
					r_MUpdateInlineRule_StyleSheet_StyleRule = new(this, "UpdateInlineRule", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReflectionUtils.GetType("UnityEngine.UIElements.StyleRule"));
					r_MUpdateInlineRule_StyleSheet_StyleRule.SetBelong(this.instance);
				}
				return r_MUpdateInlineRule_StyleSheet_StyleRule;
			}
		}

		/// <summary>
		/// Void SetComputedStyle(UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_MSetComputedStyle_Ref_ComputedStyle;
		public virtual RMethod RMSetComputedStyle_Ref_ComputedStyle
		{
			get
			{
				if(r_MSetComputedStyle_Ref_ComputedStyle == null)
				{
					r_MSetComputedStyle_Ref_ComputedStyle = new(this, "SetComputedStyle", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_MSetComputedStyle_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_MSetComputedStyle_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Void ResetPositionProperties()
		/// </summary>
		protected RMethod r_MResetPositionProperties;
		public virtual RMethod RMResetPositionProperties
		{
			get
			{
				if(r_MResetPositionProperties == null)
				{
					r_MResetPositionProperties = new(this, "ResetPositionProperties", 0);
					r_MResetPositionProperties.SetBelong(this.instance);
				}
				return r_MResetPositionProperties;
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
		/// System.Collections.Generic.IEnumerable`1[System.String] GetClasses()
		/// </summary>
		protected RMethod r_MGetClasses;
		public virtual RMethod RMGetClasses
		{
			get
			{
				if(r_MGetClasses == null)
				{
					r_MGetClasses = new(this, "GetClasses", 0);
					r_MGetClasses.SetBelong(this.instance);
				}
				return r_MGetClasses;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] GetClassesForIteration()
		/// </summary>
		protected RMethod r_MGetClassesForIteration;
		public virtual RMethod RMGetClassesForIteration
		{
			get
			{
				if(r_MGetClassesForIteration == null)
				{
					r_MGetClassesForIteration = new(this, "GetClassesForIteration", 0);
					r_MGetClassesForIteration.SetBelong(this.instance);
				}
				return r_MGetClassesForIteration;
			}
		}

		/// <summary>
		/// Void ClearClassList()
		/// </summary>
		protected RMethod r_MClearClassList;
		public virtual RMethod RMClearClassList
		{
			get
			{
				if(r_MClearClassList == null)
				{
					r_MClearClassList = new(this, "ClearClassList", 0);
					r_MClearClassList.SetBelong(this.instance);
				}
				return r_MClearClassList;
			}
		}

		/// <summary>
		/// Void AddToClassList(System.String)
		/// </summary>
		protected RMethod r_MAddToClassList_String;
		public virtual RMethod RMAddToClassList_String
		{
			get
			{
				if(r_MAddToClassList_String == null)
				{
					r_MAddToClassList_String = new(this, "AddToClassList", 0, typeof(System.String));
					r_MAddToClassList_String.SetBelong(this.instance);
				}
				return r_MAddToClassList_String;
			}
		}

		/// <summary>
		/// Void RemoveFromClassList(System.String)
		/// </summary>
		protected RMethod r_MRemoveFromClassList_String;
		public virtual RMethod RMRemoveFromClassList_String
		{
			get
			{
				if(r_MRemoveFromClassList_String == null)
				{
					r_MRemoveFromClassList_String = new(this, "RemoveFromClassList", 0, typeof(System.String));
					r_MRemoveFromClassList_String.SetBelong(this.instance);
				}
				return r_MRemoveFromClassList_String;
			}
		}

		/// <summary>
		/// Void ToggleInClassList(System.String)
		/// </summary>
		protected RMethod r_MToggleInClassList_String;
		public virtual RMethod RMToggleInClassList_String
		{
			get
			{
				if(r_MToggleInClassList_String == null)
				{
					r_MToggleInClassList_String = new(this, "ToggleInClassList", 0, typeof(System.String));
					r_MToggleInClassList_String.SetBelong(this.instance);
				}
				return r_MToggleInClassList_String;
			}
		}

		/// <summary>
		/// Void EnableInClassList(System.String, Boolean)
		/// </summary>
		protected RMethod r_MEnableInClassList_String_Boolean;
		public virtual RMethod RMEnableInClassList_String_Boolean
		{
			get
			{
				if(r_MEnableInClassList_String_Boolean == null)
				{
					r_MEnableInClassList_String_Boolean = new(this, "EnableInClassList", 0, typeof(System.String), typeof(System.Boolean));
					r_MEnableInClassList_String_Boolean.SetBelong(this.instance);
				}
				return r_MEnableInClassList_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean ClassListContains(System.String)
		/// </summary>
		protected RMethod r_MClassListContains_String;
		public virtual RMethod RMClassListContains_String
		{
			get
			{
				if(r_MClassListContains_String == null)
				{
					r_MClassListContains_String = new(this, "ClassListContains", 0, typeof(System.String));
					r_MClassListContains_String.SetBelong(this.instance);
				}
				return r_MClassListContains_String;
			}
		}

		/// <summary>
		/// System.Object FindAncestorUserData()
		/// </summary>
		protected RMethod r_MFindAncestorUserData;
		public virtual RMethod RMFindAncestorUserData
		{
			get
			{
				if(r_MFindAncestorUserData == null)
				{
					r_MFindAncestorUserData = new(this, "FindAncestorUserData", 0);
					r_MFindAncestorUserData.SetBelong(this.instance);
				}
				return r_MFindAncestorUserData;
			}
		}

		/// <summary>
		/// System.Object GetProperty(UnityEngine.PropertyName)
		/// </summary>
		protected RMethod r_MGetProperty_PropertyName;
		public virtual RMethod RMGetProperty_PropertyName
		{
			get
			{
				if(r_MGetProperty_PropertyName == null)
				{
					r_MGetProperty_PropertyName = new(this, "GetProperty", 0, typeof(UnityEngine.PropertyName));
					r_MGetProperty_PropertyName.SetBelong(this.instance);
				}
				return r_MGetProperty_PropertyName;
			}
		}

		/// <summary>
		/// Void SetProperty(UnityEngine.PropertyName, System.Object)
		/// </summary>
		protected RMethod r_MSetProperty_PropertyName_Object;
		public virtual RMethod RMSetProperty_PropertyName_Object
		{
			get
			{
				if(r_MSetProperty_PropertyName_Object == null)
				{
					r_MSetProperty_PropertyName_Object = new(this, "SetProperty", 0, typeof(UnityEngine.PropertyName), typeof(System.Object));
					r_MSetProperty_PropertyName_Object.SetBelong(this.instance);
				}
				return r_MSetProperty_PropertyName_Object;
			}
		}

		/// <summary>
		/// Boolean HasProperty(UnityEngine.PropertyName)
		/// </summary>
		protected RMethod r_MHasProperty_PropertyName;
		public virtual RMethod RMHasProperty_PropertyName
		{
			get
			{
				if(r_MHasProperty_PropertyName == null)
				{
					r_MHasProperty_PropertyName = new(this, "HasProperty", 0, typeof(UnityEngine.PropertyName));
					r_MHasProperty_PropertyName.SetBelong(this.instance);
				}
				return r_MHasProperty_PropertyName;
			}
		}

		/// <summary>
		/// Void ApplyPlayerRenderingToEditorElement()
		/// </summary>
		protected RMethod r_MApplyPlayerRenderingToEditorElement;
		public virtual RMethod RMApplyPlayerRenderingToEditorElement
		{
			get
			{
				if(r_MApplyPlayerRenderingToEditorElement == null)
				{
					r_MApplyPlayerRenderingToEditorElement = new(this, "ApplyPlayerRenderingToEditorElement", 0);
					r_MApplyPlayerRenderingToEditorElement.SetBelong(this.instance);
				}
				return r_MApplyPlayerRenderingToEditorElement;
			}
		}

		/// <summary>
		/// Void RegisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate)
		/// </summary>
		protected RMethod r_MRegisterAnimation_IValueAnimationUpdate;
		public virtual RMethod RMRegisterAnimation_IValueAnimationUpdate
		{
			get
			{
				if(r_MRegisterAnimation_IValueAnimationUpdate == null)
				{
					r_MRegisterAnimation_IValueAnimationUpdate = new(this, "RegisterAnimation", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.Experimental.IValueAnimationUpdate"));
					r_MRegisterAnimation_IValueAnimationUpdate.SetBelong(this.instance);
				}
				return r_MRegisterAnimation_IValueAnimationUpdate;
			}
		}

		/// <summary>
		/// Void UnregisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate)
		/// </summary>
		protected RMethod r_MUnregisterAnimation_IValueAnimationUpdate;
		public virtual RMethod RMUnregisterAnimation_IValueAnimationUpdate
		{
			get
			{
				if(r_MUnregisterAnimation_IValueAnimationUpdate == null)
				{
					r_MUnregisterAnimation_IValueAnimationUpdate = new(this, "UnregisterAnimation", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.Experimental.IValueAnimationUpdate"));
					r_MUnregisterAnimation_IValueAnimationUpdate.SetBelong(this.instance);
				}
				return r_MUnregisterAnimation_IValueAnimationUpdate;
			}
		}

		/// <summary>
		/// Boolean GetCachedNextParentWithEventCallback(UnityEngine.UIElements.VisualElement ByRef)
		/// </summary>
		protected RMethod r_MGetCachedNextParentWithEventCallback_Out_VisualElement;
		public virtual RMethod RMGetCachedNextParentWithEventCallback_Out_VisualElement
		{
			get
			{
				if(r_MGetCachedNextParentWithEventCallback_Out_VisualElement == null)
				{
					r_MGetCachedNextParentWithEventCallback_Out_VisualElement = new(this, "GetCachedNextParentWithEventCallback", 0, typeof(UnityEngine.UIElements.VisualElement).MakeByRefType());
					r_MGetCachedNextParentWithEventCallback_Out_VisualElement.SetBelong(this.instance);
				}
				return r_MGetCachedNextParentWithEventCallback_Out_VisualElement;
			}
		}

		/// <summary>
		/// Boolean HasEventCallbacks(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_MHasEventCallbacks_EventCategory;
		public virtual RMethod RMHasEventCallbacks_EventCategory
		{
			get
			{
				if(r_MHasEventCallbacks_EventCategory == null)
				{
					r_MHasEventCallbacks_EventCategory = new(this, "HasEventCallbacks", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_MHasEventCallbacks_EventCategory.SetBelong(this.instance);
				}
				return r_MHasEventCallbacks_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasParentEventCallbacks(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_MHasParentEventCallbacks_EventCategory;
		public virtual RMethod RMHasParentEventCallbacks_EventCategory
		{
			get
			{
				if(r_MHasParentEventCallbacks_EventCategory == null)
				{
					r_MHasParentEventCallbacks_EventCategory = new(this, "HasParentEventCallbacks", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_MHasParentEventCallbacks_EventCategory.SetBelong(this.instance);
				}
				return r_MHasParentEventCallbacks_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasParentEventCallbacksOrDefaultActions(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_MHasParentEventCallbacksOrDefaultActions_EventCategory;
		public virtual RMethod RMHasParentEventCallbacksOrDefaultActions_EventCategory
		{
			get
			{
				if(r_MHasParentEventCallbacksOrDefaultActions_EventCategory == null)
				{
					r_MHasParentEventCallbacksOrDefaultActions_EventCategory = new(this, "HasParentEventCallbacksOrDefaultActions", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_MHasParentEventCallbacksOrDefaultActions_EventCategory.SetBelong(this.instance);
				}
				return r_MHasParentEventCallbacksOrDefaultActions_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasEventCallbacksOrDefaultActions(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_MHasEventCallbacksOrDefaultActions_EventCategory;
		public virtual RMethod RMHasEventCallbacksOrDefaultActions_EventCategory
		{
			get
			{
				if(r_MHasEventCallbacksOrDefaultActions_EventCategory == null)
				{
					r_MHasEventCallbacksOrDefaultActions_EventCategory = new(this, "HasEventCallbacksOrDefaultActions", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_MHasEventCallbacksOrDefaultActions_EventCategory.SetBelong(this.instance);
				}
				return r_MHasEventCallbacksOrDefaultActions_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasParentEventCallbacksOrDefaultActionAtTarget(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_MHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory;
		public virtual RMethod RMHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory
		{
			get
			{
				if(r_MHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory == null)
				{
					r_MHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory = new(this, "HasParentEventCallbacksOrDefaultActionAtTarget", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_MHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory.SetBelong(this.instance);
				}
				return r_MHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasEventCallbacksOrDefaultActionAtTarget(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_MHasEventCallbacksOrDefaultActionAtTarget_EventCategory;
		public virtual RMethod RMHasEventCallbacksOrDefaultActionAtTarget_EventCategory
		{
			get
			{
				if(r_MHasEventCallbacksOrDefaultActionAtTarget_EventCategory == null)
				{
					r_MHasEventCallbacksOrDefaultActionAtTarget_EventCategory = new(this, "HasEventCallbacksOrDefaultActionAtTarget", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_MHasEventCallbacksOrDefaultActionAtTarget_EventCategory.SetBelong(this.instance);
				}
				return r_MHasEventCallbacksOrDefaultActionAtTarget_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasDefaultAction(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_MHasDefaultAction_EventCategory;
		public virtual RMethod RMHasDefaultAction_EventCategory
		{
			get
			{
				if(r_MHasDefaultAction_EventCategory == null)
				{
					r_MHasDefaultAction_EventCategory = new(this, "HasDefaultAction", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_MHasDefaultAction_EventCategory.SetBelong(this.instance);
				}
				return r_MHasDefaultAction_EventCategory;
			}
		}

		/// <summary>
		/// Boolean ShouldClip()
		/// </summary>
		protected RMethod r_MShouldClip;
		public virtual RMethod RMShouldClip
		{
			get
			{
				if(r_MShouldClip == null)
				{
					r_MShouldClip = new(this, "ShouldClip", 0);
					r_MShouldClip.SetBelong(this.instance);
				}
				return r_MShouldClip;
			}
		}

		/// <summary>
		/// Void Add(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MAdd_VisualElement;
		public virtual RMethod RMAdd_VisualElement
		{
			get
			{
				if(r_MAdd_VisualElement == null)
				{
					r_MAdd_VisualElement = new(this, "Add", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MAdd_VisualElement.SetBelong(this.instance);
				}
				return r_MAdd_VisualElement;
			}
		}

		/// <summary>
		/// Void Insert(Int32, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MInsert_Int32_VisualElement;
		public virtual RMethod RMInsert_Int32_VisualElement
		{
			get
			{
				if(r_MInsert_Int32_VisualElement == null)
				{
					r_MInsert_Int32_VisualElement = new(this, "Insert", 0, typeof(System.Int32), typeof(UnityEngine.UIElements.VisualElement));
					r_MInsert_Int32_VisualElement.SetBelong(this.instance);
				}
				return r_MInsert_Int32_VisualElement;
			}
		}

		/// <summary>
		/// Void Remove(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MRemove_VisualElement;
		public virtual RMethod RMRemove_VisualElement
		{
			get
			{
				if(r_MRemove_VisualElement == null)
				{
					r_MRemove_VisualElement = new(this, "Remove", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MRemove_VisualElement.SetBelong(this.instance);
				}
				return r_MRemove_VisualElement;
			}
		}

		/// <summary>
		/// Void RemoveAt(Int32)
		/// </summary>
		protected RMethod r_MRemoveAt_Int32;
		public virtual RMethod RMRemoveAt_Int32
		{
			get
			{
				if(r_MRemoveAt_Int32 == null)
				{
					r_MRemoveAt_Int32 = new(this, "RemoveAt", 0, typeof(System.Int32));
					r_MRemoveAt_Int32.SetBelong(this.instance);
				}
				return r_MRemoveAt_Int32;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_MClear;
		public virtual RMethod RMClear
		{
			get
			{
				if(r_MClear == null)
				{
					r_MClear = new(this, "Clear", 0);
					r_MClear.SetBelong(this.instance);
				}
				return r_MClear;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement ElementAt(Int32)
		/// </summary>
		protected RMethod r_MElementAt_Int32;
		public virtual RMethod RMElementAt_Int32
		{
			get
			{
				if(r_MElementAt_Int32 == null)
				{
					r_MElementAt_Int32 = new(this, "ElementAt", 0, typeof(System.Int32));
					r_MElementAt_Int32.SetBelong(this.instance);
				}
				return r_MElementAt_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MIndexOf_VisualElement;
		public virtual RMethod RMIndexOf_VisualElement
		{
			get
			{
				if(r_MIndexOf_VisualElement == null)
				{
					r_MIndexOf_VisualElement = new(this, "IndexOf", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MIndexOf_VisualElement.SetBelong(this.instance);
				}
				return r_MIndexOf_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement ElementAtTreePath(System.Collections.Generic.List`1[System.Int32])
		/// </summary>
		protected RMethod r_MElementAtTreePath_List_d_Int32_p_;
		public virtual RMethod RMElementAtTreePath_List_d_Int32_p_
		{
			get
			{
				if(r_MElementAtTreePath_List_d_Int32_p_ == null)
				{
					r_MElementAtTreePath_List_d_Int32_p_ = new(this, "ElementAtTreePath", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)));
					r_MElementAtTreePath_List_d_Int32_p_.SetBelong(this.instance);
				}
				return r_MElementAtTreePath_List_d_Int32_p_;
			}
		}

		/// <summary>
		/// Boolean FindElementInTree(UnityEngine.UIElements.VisualElement, System.Collections.Generic.List`1[System.Int32])
		/// </summary>
		protected RMethod r_MFindElementInTree_VisualElement_List_d_Int32_p_;
		public virtual RMethod RMFindElementInTree_VisualElement_List_d_Int32_p_
		{
			get
			{
				if(r_MFindElementInTree_VisualElement_List_d_Int32_p_ == null)
				{
					r_MFindElementInTree_VisualElement_List_d_Int32_p_ = new(this, "FindElementInTree", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)));
					r_MFindElementInTree_VisualElement_List_d_Int32_p_.SetBelong(this.instance);
				}
				return r_MFindElementInTree_VisualElement_List_d_Int32_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.VisualElement] Children()
		/// </summary>
		protected RMethod r_MChildren;
		public virtual RMethod RMChildren
		{
			get
			{
				if(r_MChildren == null)
				{
					r_MChildren = new(this, "Children", 0);
					r_MChildren.SetBelong(this.instance);
				}
				return r_MChildren;
			}
		}

		/// <summary>
		/// Void Sort(System.Comparison`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_MSort_Comparison_d_VisualElement_p_;
		public virtual RMethod RMSort_Comparison_d_VisualElement_p_
		{
			get
			{
				if(r_MSort_Comparison_d_VisualElement_p_ == null)
				{
					r_MSort_Comparison_d_VisualElement_p_ = new(this, "Sort", 0, typeof(System.Comparison<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
					r_MSort_Comparison_d_VisualElement_p_.SetBelong(this.instance);
				}
				return r_MSort_Comparison_d_VisualElement_p_;
			}
		}

		/// <summary>
		/// Void BringToFront()
		/// </summary>
		protected RMethod r_MBringToFront;
		public virtual RMethod RMBringToFront
		{
			get
			{
				if(r_MBringToFront == null)
				{
					r_MBringToFront = new(this, "BringToFront", 0);
					r_MBringToFront.SetBelong(this.instance);
				}
				return r_MBringToFront;
			}
		}

		/// <summary>
		/// Void SendToBack()
		/// </summary>
		protected RMethod r_MSendToBack;
		public virtual RMethod RMSendToBack
		{
			get
			{
				if(r_MSendToBack == null)
				{
					r_MSendToBack = new(this, "SendToBack", 0);
					r_MSendToBack.SetBelong(this.instance);
				}
				return r_MSendToBack;
			}
		}

		/// <summary>
		/// Void PlaceBehind(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MPlaceBehind_VisualElement;
		public virtual RMethod RMPlaceBehind_VisualElement
		{
			get
			{
				if(r_MPlaceBehind_VisualElement == null)
				{
					r_MPlaceBehind_VisualElement = new(this, "PlaceBehind", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MPlaceBehind_VisualElement.SetBelong(this.instance);
				}
				return r_MPlaceBehind_VisualElement;
			}
		}

		/// <summary>
		/// Void PlaceInFront(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MPlaceInFront_VisualElement;
		public virtual RMethod RMPlaceInFront_VisualElement
		{
			get
			{
				if(r_MPlaceInFront_VisualElement == null)
				{
					r_MPlaceInFront_VisualElement = new(this, "PlaceInFront", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MPlaceInFront_VisualElement.SetBelong(this.instance);
				}
				return r_MPlaceInFront_VisualElement;
			}
		}

		/// <summary>
		/// Void RemoveFromHierarchy()
		/// </summary>
		protected RMethod r_MRemoveFromHierarchy;
		public virtual RMethod RMRemoveFromHierarchy
		{
			get
			{
				if(r_MRemoveFromHierarchy == null)
				{
					r_MRemoveFromHierarchy = new(this, "RemoveFromHierarchy", 0);
					r_MRemoveFromHierarchy.SetBelong(this.instance);
				}
				return r_MRemoveFromHierarchy;
			}
		}

		/// <summary>
		/// T GetFirstOfType[T]()
		/// </summary>
		protected RMethod r_MGetFirstOfType_GT;
		public virtual RMethod RMGetFirstOfType_GT
		{
			get
			{
				if(r_MGetFirstOfType_GT == null)
				{
					r_MGetFirstOfType_GT = new(this, "GetFirstOfType", 1);
					r_MGetFirstOfType_GT.SetBelong(this.instance);
				}
				return r_MGetFirstOfType_GT;
			}
		}

		/// <summary>
		/// T GetFirstAncestorOfType[T]()
		/// </summary>
		protected RMethod r_MGetFirstAncestorOfType_GT;
		public virtual RMethod RMGetFirstAncestorOfType_GT
		{
			get
			{
				if(r_MGetFirstAncestorOfType_GT == null)
				{
					r_MGetFirstAncestorOfType_GT = new(this, "GetFirstAncestorOfType", 1);
					r_MGetFirstAncestorOfType_GT.SetBelong(this.instance);
				}
				return r_MGetFirstAncestorOfType_GT;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetFirstAncestorWhere(System.Predicate`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_MGetFirstAncestorWhere_Predicate_d_VisualElement_p_;
		public virtual RMethod RMGetFirstAncestorWhere_Predicate_d_VisualElement_p_
		{
			get
			{
				if(r_MGetFirstAncestorWhere_Predicate_d_VisualElement_p_ == null)
				{
					r_MGetFirstAncestorWhere_Predicate_d_VisualElement_p_ = new(this, "GetFirstAncestorWhere", 0, typeof(System.Predicate<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
					r_MGetFirstAncestorWhere_Predicate_d_VisualElement_p_.SetBelong(this.instance);
				}
				return r_MGetFirstAncestorWhere_Predicate_d_VisualElement_p_;
			}
		}

		/// <summary>
		/// Boolean Contains(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MContains_VisualElement;
		public virtual RMethod RMContains_VisualElement
		{
			get
			{
				if(r_MContains_VisualElement == null)
				{
					r_MContains_VisualElement = new(this, "Contains", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MContains_VisualElement.SetBelong(this.instance);
				}
				return r_MContains_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement FindCommonAncestor(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MFindCommonAncestor_VisualElement;
		public virtual RMethod RMFindCommonAncestor_VisualElement
		{
			get
			{
				if(r_MFindCommonAncestor_VisualElement == null)
				{
					r_MFindCommonAncestor_VisualElement = new(this, "FindCommonAncestor", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MFindCommonAncestor_VisualElement.SetBelong(this.instance);
				}
				return r_MFindCommonAncestor_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetRoot()
		/// </summary>
		protected RMethod r_MGetRoot;
		public virtual RMethod RMGetRoot
		{
			get
			{
				if(r_MGetRoot == null)
				{
					r_MGetRoot = new(this, "GetRoot", 0);
					r_MGetRoot.SetBelong(this.instance);
				}
				return r_MGetRoot;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetRootVisualContainer()
		/// </summary>
		protected RMethod r_MGetRootVisualContainer;
		public virtual RMethod RMGetRootVisualContainer
		{
			get
			{
				if(r_MGetRootVisualContainer == null)
				{
					r_MGetRootVisualContainer = new(this, "GetRootVisualContainer", 0);
					r_MGetRootVisualContainer.SetBelong(this.instance);
				}
				return r_MGetRootVisualContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetNextElementDepthFirst()
		/// </summary>
		protected RMethod r_MGetNextElementDepthFirst;
		public virtual RMethod RMGetNextElementDepthFirst
		{
			get
			{
				if(r_MGetNextElementDepthFirst == null)
				{
					r_MGetNextElementDepthFirst = new(this, "GetNextElementDepthFirst", 0);
					r_MGetNextElementDepthFirst.SetBelong(this.instance);
				}
				return r_MGetNextElementDepthFirst;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetPreviousElementDepthFirst()
		/// </summary>
		protected RMethod r_MGetPreviousElementDepthFirst;
		public virtual RMethod RMGetPreviousElementDepthFirst
		{
			get
			{
				if(r_MGetPreviousElementDepthFirst == null)
				{
					r_MGetPreviousElementDepthFirst = new(this, "GetPreviousElementDepthFirst", 0);
					r_MGetPreviousElementDepthFirst.SetBelong(this.instance);
				}
				return r_MGetPreviousElementDepthFirst;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement RetargetElement(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MRetargetElement_VisualElement;
		public virtual RMethod RMRetargetElement_VisualElement
		{
			get
			{
				if(r_MRetargetElement_VisualElement == null)
				{
					r_MRetargetElement_VisualElement = new(this, "RetargetElement", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MRetargetElement_VisualElement.SetBelong(this.instance);
				}
				return r_MRetargetElement_VisualElement;
			}
		}

		/// <summary>
		/// Void GetPivotedMatrixWithLayout(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_MGetPivotedMatrixWithLayout_Out_Matrix4x4;
		public virtual RMethod RMGetPivotedMatrixWithLayout_Out_Matrix4x4
		{
			get
			{
				if(r_MGetPivotedMatrixWithLayout_Out_Matrix4x4 == null)
				{
					r_MGetPivotedMatrixWithLayout_Out_Matrix4x4 = new(this, "GetPivotedMatrixWithLayout", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_MGetPivotedMatrixWithLayout_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_MGetPivotedMatrixWithLayout_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void AddStyleSheetPath(System.String)
		/// </summary>
		protected RMethod r_MAddStyleSheetPath_String;
		public virtual RMethod RMAddStyleSheetPath_String
		{
			get
			{
				if(r_MAddStyleSheetPath_String == null)
				{
					r_MAddStyleSheetPath_String = new(this, "AddStyleSheetPath", 0, typeof(System.String));
					r_MAddStyleSheetPath_String.SetBelong(this.instance);
				}
				return r_MAddStyleSheetPath_String;
			}
		}

		/// <summary>
		/// Boolean HasStyleSheetPath(System.String)
		/// </summary>
		protected RMethod r_MHasStyleSheetPath_String;
		public virtual RMethod RMHasStyleSheetPath_String
		{
			get
			{
				if(r_MHasStyleSheetPath_String == null)
				{
					r_MHasStyleSheetPath_String = new(this, "HasStyleSheetPath", 0, typeof(System.String));
					r_MHasStyleSheetPath_String.SetBelong(this.instance);
				}
				return r_MHasStyleSheetPath_String;
			}
		}

		/// <summary>
		/// Void RemoveStyleSheetPath(System.String)
		/// </summary>
		protected RMethod r_MRemoveStyleSheetPath_String;
		public virtual RMethod RMRemoveStyleSheetPath_String
		{
			get
			{
				if(r_MRemoveStyleSheetPath_String == null)
				{
					r_MRemoveStyleSheetPath_String = new(this, "RemoveStyleSheetPath", 0, typeof(System.String));
					r_MRemoveStyleSheetPath_String.SetBelong(this.instance);
				}
				return r_MRemoveStyleSheetPath_String;
			}
		}

		/// <summary>
		/// Void Blur()
		/// </summary>
		protected RMethod r_MBlur;
		public virtual RMethod RMBlur
		{
			get
			{
				if(r_MBlur == null)
				{
					r_MBlur = new(this, "Blur", 0);
					r_MBlur.SetBelong(this.instance);
				}
				return r_MBlur;
			}
		}

		/// <summary>
		/// Void BlurImmediately()
		/// </summary>
		protected RMethod r_MBlurImmediately;
		public virtual RMethod RMBlurImmediately
		{
			get
			{
				if(r_MBlurImmediately == null)
				{
					r_MBlurImmediately = new(this, "BlurImmediately", 0);
					r_MBlurImmediately.SetBelong(this.instance);
				}
				return r_MBlurImmediately;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultActionDisabled(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MExecuteDefaultActionDisabled_EventBase;
		public virtual RMethod RMExecuteDefaultActionDisabled_EventBase
		{
			get
			{
				if(r_MExecuteDefaultActionDisabled_EventBase == null)
				{
					r_MExecuteDefaultActionDisabled_EventBase = new(this, "ExecuteDefaultActionDisabled", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MExecuteDefaultActionDisabled_EventBase.SetBelong(this.instance);
				}
				return r_MExecuteDefaultActionDisabled_EventBase;
			}
		}

		/// <summary>
		/// Void RegisterCallback[TEventType](UnityEngine.UIElements.EventCallback`1[TEventType], UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
		public virtual RMethod RMRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown
		{
			get
			{
				if(r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown == null)
				{
					r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown = new(this, "RegisterCallback", 1, typeof(UnityEngine.UIElements.EventCallback<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(UnityEngine.UIElements.TrickleDown));
					r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown.SetBelong(this.instance);
				}
				return r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
			}
		}

		/// <summary>
		/// Void RegisterCallback[TEventType,TUserArgsType](UnityEngine.UIElements.EventCallback`2[TEventType,TUserArgsType], TUserArgsType, UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_MRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown;
		public virtual RMethod RMRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown
		{
			get
			{
				if(r_MRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown == null)
				{
					r_MRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown = new(this, "RegisterCallback", 2, typeof(UnityEngine.UIElements.EventCallback<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), Type.MakeGenericMethodParameter(1), typeof(UnityEngine.UIElements.TrickleDown));
					r_MRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown.SetBelong(this.instance);
				}
				return r_MRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown;
			}
		}

		/// <summary>
		/// Void RegisterCallback[TEventType](UnityEngine.UIElements.EventCallback`1[TEventType], UnityEngine.UIElements.InvokePolicy, UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown;
		public virtual RMethod RMRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown
		{
			get
			{
				if(r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown == null)
				{
					r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown = new(this, "RegisterCallback", 1, typeof(UnityEngine.UIElements.EventCallback<>).MakeGenericType(Type.MakeGenericMethodParameter(0)),  ReflectionUtils.GetType("UnityEngine.UIElements.InvokePolicy"), typeof(UnityEngine.UIElements.TrickleDown));
					r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown.SetBelong(this.instance);
				}
				return r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown;
			}
		}

		/// <summary>
		/// Void UnregisterCallback[TEventType](UnityEngine.UIElements.EventCallback`1[TEventType], UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_MUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
		public virtual RMethod RMUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown
		{
			get
			{
				if(r_MUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown == null)
				{
					r_MUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown = new(this, "UnregisterCallback", 1, typeof(UnityEngine.UIElements.EventCallback<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(UnityEngine.UIElements.TrickleDown));
					r_MUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown.SetBelong(this.instance);
				}
				return r_MUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
			}
		}

		/// <summary>
		/// Void UnregisterCallback[TEventType,TUserArgsType](UnityEngine.UIElements.EventCallback`2[TEventType,TUserArgsType], UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_MUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown;
		public virtual RMethod RMUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown
		{
			get
			{
				if(r_MUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown == null)
				{
					r_MUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown = new(this, "UnregisterCallback", 2, typeof(UnityEngine.UIElements.EventCallback<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), typeof(UnityEngine.UIElements.TrickleDown));
					r_MUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown.SetBelong(this.instance);
				}
				return r_MUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown;
			}
		}

		/// <summary>
		/// Boolean TryGetUserArgs[TEventType,TCallbackArgs](UnityEngine.UIElements.EventCallback`2[TEventType,TCallbackArgs], UnityEngine.UIElements.TrickleDown, TCallbackArgs ByRef)
		/// </summary>
		protected RMethod r_MTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs;
		public virtual RMethod RMTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs
		{
			get
			{
				if(r_MTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs == null)
				{
					r_MTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs = new(this, "TryGetUserArgs", 2, typeof(UnityEngine.UIElements.EventCallback<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), typeof(UnityEngine.UIElements.TrickleDown), Type.MakeGenericMethodParameter(1).MakeByRefType());
					r_MTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs.SetBelong(this.instance);
				}
				return r_MTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs;
			}
		}

		/// <summary>
		/// Void HandleEventAtTargetPhase(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MHandleEventAtTargetPhase_EventBase;
		public virtual RMethod RMHandleEventAtTargetPhase_EventBase
		{
			get
			{
				if(r_MHandleEventAtTargetPhase_EventBase == null)
				{
					r_MHandleEventAtTargetPhase_EventBase = new(this, "HandleEventAtTargetPhase", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MHandleEventAtTargetPhase_EventBase.SetBelong(this.instance);
				}
				return r_MHandleEventAtTargetPhase_EventBase;
			}
		}

		/// <summary>
		/// Void HandleEventAtTargetAndDefaultPhase(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MHandleEventAtTargetAndDefaultPhase_EventBase;
		public virtual RMethod RMHandleEventAtTargetAndDefaultPhase_EventBase
		{
			get
			{
				if(r_MHandleEventAtTargetAndDefaultPhase_EventBase == null)
				{
					r_MHandleEventAtTargetAndDefaultPhase_EventBase = new(this, "HandleEventAtTargetAndDefaultPhase", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MHandleEventAtTargetAndDefaultPhase_EventBase.SetBelong(this.instance);
				}
				return r_MHandleEventAtTargetAndDefaultPhase_EventBase;
			}
		}

		/// <summary>
		/// Void HandleEventAtCurrentTargetAndPhase(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MHandleEventAtCurrentTargetAndPhase_EventBase;
		public virtual RMethod RMHandleEventAtCurrentTargetAndPhase_EventBase
		{
			get
			{
				if(r_MHandleEventAtCurrentTargetAndPhase_EventBase == null)
				{
					r_MHandleEventAtCurrentTargetAndPhase_EventBase = new(this, "HandleEventAtCurrentTargetAndPhase", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MHandleEventAtCurrentTargetAndPhase_EventBase.SetBelong(this.instance);
				}
				return r_MHandleEventAtCurrentTargetAndPhase_EventBase;
			}
		}

		/// <summary>
		/// Void HandleEventEditorInternal(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MHandleEventEditorInternal_EventBase;
		public virtual RMethod RMHandleEventEditorInternal_EventBase
		{
			get
			{
				if(r_MHandleEventEditorInternal_EventBase == null)
				{
					r_MHandleEventEditorInternal_EventBase = new(this, "HandleEventEditorInternal", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MHandleEventEditorInternal_EventBase.SetBelong(this.instance);
				}
				return r_MHandleEventEditorInternal_EventBase;
			}
		}

		/// <summary>
		/// Void HandleEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MHandleEvent_EventBase;
		public virtual RMethod RMHandleEvent_EventBase
		{
			get
			{
				if(r_MHandleEvent_EventBase == null)
				{
					r_MHandleEvent_EventBase = new(this, "HandleEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MHandleEvent_EventBase.SetBelong(this.instance);
				}
				return r_MHandleEvent_EventBase;
			}
		}

		/// <summary>
		/// Boolean HasTrickleDownHandlers()
		/// </summary>
		protected RMethod r_MHasTrickleDownHandlers;
		public virtual RMethod RMHasTrickleDownHandlers
		{
			get
			{
				if(r_MHasTrickleDownHandlers == null)
				{
					r_MHasTrickleDownHandlers = new(this, "HasTrickleDownHandlers", 0);
					r_MHasTrickleDownHandlers.SetBelong(this.instance);
				}
				return r_MHasTrickleDownHandlers;
			}
		}

		/// <summary>
		/// Boolean HasBubbleUpHandlers()
		/// </summary>
		protected RMethod r_MHasBubbleUpHandlers;
		public virtual RMethod RMHasBubbleUpHandlers
		{
			get
			{
				if(r_MHasBubbleUpHandlers == null)
				{
					r_MHasBubbleUpHandlers = new(this, "HasBubbleUpHandlers", 0);
					r_MHasBubbleUpHandlers.SetBelong(this.instance);
				}
				return r_MHasBubbleUpHandlers;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MExecuteDefaultActionAtTarget_EventBase;
		public virtual RMethod RMExecuteDefaultActionAtTarget_EventBase
		{
			get
			{
				if(r_MExecuteDefaultActionAtTarget_EventBase == null)
				{
					r_MExecuteDefaultActionAtTarget_EventBase = new(this, "ExecuteDefaultActionAtTarget", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MExecuteDefaultActionAtTarget_EventBase.SetBelong(this.instance);
				}
				return r_MExecuteDefaultActionAtTarget_EventBase;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultActionDisabledAtTarget(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_MExecuteDefaultActionDisabledAtTarget_EventBase;
		public virtual RMethod RMExecuteDefaultActionDisabledAtTarget_EventBase
		{
			get
			{
				if(r_MExecuteDefaultActionDisabledAtTarget_EventBase == null)
				{
					r_MExecuteDefaultActionDisabledAtTarget_EventBase = new(this, "ExecuteDefaultActionDisabledAtTarget", 0, typeof(UnityEngine.UIElements.EventBase));
					r_MExecuteDefaultActionDisabledAtTarget_EventBase.SetBelong(this.instance);
				}
				return r_MExecuteDefaultActionDisabledAtTarget_EventBase;
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


        public RScrollView() : base("UnityEngine.UIElements.ScrollView")
        {
        }

        public RScrollView(System.Object instance) : base("UnityEngine.UIElements.ScrollView")
		{
            SetInstance(instance);
		}

        public RScrollView(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RScrollView(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnHorizontalScrollDragElementChanged(UnityEngine.UIElements.GeometryChangedEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnHorizontalScrollDragElementChanged_GeometryChangedEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnVerticalScrollDragElementChanged(UnityEngine.UIElements.GeometryChangedEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnVerticalScrollDragElementChanged_GeometryChangedEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateHorizontalSliderPageSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateHorizontalSliderPageSize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateVerticalSliderPageSize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateVerticalSliderPageSize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateContentViewTransform()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateContentViewTransform.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ScrollTo(UnityEngine.UIElements.VisualElement @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RMScrollTo_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single GetXDeltaOffset(UnityEngine.UIElements.VisualElement @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RMGetXDeltaOffset_VisualElement.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single GetYDeltaOffset(UnityEngine.UIElements.VisualElement @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RMGetYDeltaOffset_VisualElement.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single GetDeltaDistance(System.Single @viewMin, System.Single @viewMax, System.Single @childBoundaryMin, System.Single @childBoundaryMax)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@viewMin, @viewMax, @childBoundaryMin, @childBoundaryMax};
            var ___result = RMGetDeltaDistance_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void SetScrollViewMode(UnityEngine.UIElements.ScrollViewMode @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mode};
            var ___result = RMSetScrollViewMode_ScrollViewMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAttachToPanel(UnityEngine.UIElements.AttachToPanelEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnAttachToPanel_AttachToPanelEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDetachFromPanel(UnityEngine.UIElements.DetachFromPanelEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnDetachFromPanel_DetachFromPanelEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPointerCapture(UnityEngine.UIElements.PointerCaptureEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnPointerCapture_PointerCaptureEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPointerCaptureOut(UnityEngine.UIElements.PointerCaptureOutEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnPointerCaptureOut_PointerCaptureOutEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnGeometryChanged_GeometryChangedEvent.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Single ComputeElasticOffset(System.Single @deltaPointer, System.Single @initialScrollOffset, System.Single @lowLimit, System.Single @hardLowLimit, System.Single @highLimit, System.Single @hardHighLimit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@deltaPointer, @initialScrollOffset, @lowLimit, @hardLowLimit, @highLimit, @hardHighLimit};
            var ___result = RMComputeElasticOffset_Single_Single_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void ComputeInitialSpringBackVelocity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMComputeInitialSpringBackVelocity.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SpringBack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSpringBack.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyScrollInertia()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMApplyScrollInertia.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PostPointerUpAnimation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMPostPointerUpAnimation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPointerDown(UnityEngine.UIElements.PointerDownEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnPointerDown_PointerDownEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPointerMove(UnityEngine.UIElements.PointerMoveEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnPointerMove_PointerMoveEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPointerCancel(UnityEngine.UIElements.PointerCancelEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnPointerCancel_PointerCancelEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPointerUp(UnityEngine.UIElements.PointerUpEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnPointerUp_PointerUpEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitTouchScrolling(UnityEngine.Vector2 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RMInitTouchScrolling_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RUnityEngine.RUIElements.RScrollView.RTouchScrollingResult ComputeTouchScrolling(UnityEngine.Vector2 @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RMComputeTouchScrolling_Vector2.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RScrollView.RTouchScrollingResult(___result);
        }


        public virtual System.Boolean ApplyTouchScrolling(UnityEngine.Vector2 @newScrollOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newScrollOffset};
            var ___result = RMApplyTouchScrolling_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ReleaseScrolling(System.Int32 @pointerId, UnityEngine.UIElements.IEventHandler @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pointerId, @target};
            var ___result = RMReleaseScrolling_Int32_IEventHandler.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ExecuteElasticSpringAnimation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMExecuteElasticSpringAnimation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AdjustScrollers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAdjustScrollers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DelayUpdateScrollers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDelayUpdateScrollers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateScrollers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateScrollers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateViewportContentMargins(System.Boolean @displayHorizontal, System.Boolean @displayVertical)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayHorizontal, @displayVertical};
            var ___result = RMUpdateViewportContentMargins_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateScrollers(System.Boolean @displayHorizontal, System.Boolean @displayVertical)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@displayHorizontal, @displayVertical};
            var ___result = RMUpdateScrollers_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnScrollersGeometryChanged(UnityEngine.UIElements.GeometryChangedEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnScrollersGeometryChanged_GeometryChangedEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnScrollWheel(UnityEngine.UIElements.WheelEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnScrollWheel_WheelEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnRootCustomStyleResolved(UnityEngine.UIElements.CustomStyleResolvedEvent @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMOnRootCustomStyleResolved_CustomStyleResolvedEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadSingleLineHeight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReadSingleLineHeight.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0____2__ctor__1__b__111_0(System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RM__0____2__ctor__1__b__111_0_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0____2__ctor__1__b__111_1(System.Single @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RM__0____2__ctor__1__b__111_1_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryConvertLengthUnits(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, ref UnityEngine.UIElements.Length @from, ref UnityEngine.UIElements.Length @to, System.Int32 @subPropertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @subPropertyIndex};
            var ___result = RMTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32.Invoke(___genericsType, ___parameters);
			@from = (UnityEngine.UIElements.Length)___parameters[1];
			@to = (UnityEngine.UIElements.Length)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryConvertTransformOriginUnits(ref UnityEngine.UIElements.TransformOrigin @from, ref UnityEngine.UIElements.TransformOrigin @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RMTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin.Invoke(___genericsType, ___parameters);
			@from = (UnityEngine.UIElements.TransformOrigin)___parameters[0];
			@to = (UnityEngine.UIElements.TransformOrigin)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryConvertTranslateUnits(ref UnityEngine.UIElements.Translate @from, ref UnityEngine.UIElements.Translate @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RMTryConvertTranslateUnits_Ref_Translate_Ref_Translate.Invoke(___genericsType, ___parameters);
			@from = (UnityEngine.UIElements.Translate)___parameters[0];
			@to = (UnityEngine.UIElements.Translate)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryConvertBackgroundPositionUnits(ref UnityEngine.UIElements.BackgroundPosition @from, ref UnityEngine.UIElements.BackgroundPosition @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RMTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition.Invoke(___genericsType, ___parameters);
			@from = (UnityEngine.UIElements.BackgroundPosition)___parameters[0];
			@to = (UnityEngine.UIElements.BackgroundPosition)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryConvertBackgroundSizeUnits(ref UnityEngine.UIElements.BackgroundSize @from, ref UnityEngine.UIElements.BackgroundSize @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RMTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize.Invoke(___genericsType, ___parameters);
			@from = (UnityEngine.UIElements.BackgroundSize)___parameters[0];
			@to = (UnityEngine.UIElements.BackgroundSize)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual void MarkRenderHintsClean()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkRenderHintsClean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateBoundingBox()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateBoundingBox.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWorldBoundingBox()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateWorldBoundingBox.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWorldTransform()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateWorldTransform.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWorldTransformInverse()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateWorldTransformInverse.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnsureWorldTransformAndClipUpToDate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEnsureWorldTransformAndClipUpToDate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteDefaultAction(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMExecuteDefaultAction_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect GetTooltipRect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTooltipRect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void Focus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPanel(RUnityEngine.RUIElements.RBaseVisualElementPanel @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p.Value};
            var ___result = RMSetPanel_BaseVisualElementPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendEvent(UnityEngine.UIElements.EventBase @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMSendEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendEvent(UnityEngine.UIElements.EventBase @e, RUnityEngine.RUIElements.RDispatchMode @dispatchMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @dispatchMode.Value};
            var ___result = RMSendEvent_EventBase_DispatchMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IncrementVersion(RUnityEngine.RUIElements.RVersionChangeType @changeType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@changeType.Value};
            var ___result = RMIncrementVersion_VersionChangeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeHierarchyChanged(RUnityEngine.RUIElements.RHierarchyChangeType @changeType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@changeType.Value};
            var ___result = RMInvokeHierarchyChanged_HierarchyChangeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetEnabledFromHierarchy(System.Boolean @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RMSetEnabledFromHierarchy_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetEnabled(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetEnabled_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkDirtyRepaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkDirtyRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext @mgc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mgc};
            var ___result = RMInvokeGenerateVisualContent_MeshGenerationContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetFullHierarchicalViewDataKey(System.Text.StringBuilder @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMGetFullHierarchicalViewDataKey_StringBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetFullHierarchicalViewDataKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetFullHierarchicalViewDataKey.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual T GetOrCreateViewData<T>(System.Object @existing, System.String @key) where T : class, new()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@existing, @key};
            var ___result = RMGetOrCreateViewData_GT_Object_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetOrCreateViewData<T>(UnityEngine.ScriptableObject @existing, System.String @key) where T : UnityEngine.ScriptableObject
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@existing, @key};
            var ___result = RMGetOrCreateViewData_GT_ScriptableObject_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual void OverwriteFromViewData(System.Object @obj, System.String @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @key};
            var ___result = RMOverwriteFromViewData_Object_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SaveViewData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSaveViewData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsViewDataPersitenceSupportedOnChildren(System.Boolean @existingState)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@existingState};
            var ___result = RMIsViewDataPersitenceSupportedOnChildren_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnViewDataReady(System.Boolean @enablePersistence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enablePersistence};
            var ___result = RMOnViewDataReady_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnViewDataReady()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnViewDataReady.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ContainsPoint(UnityEngine.Vector2 @localPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localPoint};
            var ___result = RMContainsPoint_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Overlaps(UnityEngine.Rect @rectangle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rectangle};
            var ___result = RMOverlaps_Rect.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Vector2 DoMeasure(System.Single @desiredWidth, RUnityEngine.RUIElements.RVisualElement.RMeasureMode @widthMode, System.Single @desiredHeight, RUnityEngine.RUIElements.RVisualElement.RMeasureMode @heightMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desiredWidth, @widthMode.Value, @desiredHeight, @heightMode.Value};
            var ___result = RMDoMeasure_Single_MeasureMode_Single_MeasureMode.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual RUnityEngine.RYoga.RYogaSize Measure(RUnityEngine.RYoga.RYogaNode @node, System.Single @width, RUnityEngine.RYoga.RYogaMeasureMode @widthMode, System.Single @height, RUnityEngine.RYoga.RYogaMeasureMode @heightMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node.Value, @width, @widthMode.Value, @height, @heightMode.Value};
            var ___result = RMMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RYoga.RYogaSize(___result);
        }


        public virtual void SetSize(UnityEngine.Vector2 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size};
            var ___result = RMSetSize_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInlineRule(UnityEngine.UIElements.StyleSheet @sheet, RUnityEngine.RUIElements.RStyleRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheet, @rule.Value};
            var ___result = RMSetInlineRule_StyleSheet_StyleRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInlineRule(UnityEngine.UIElements.StyleSheet @sheet, RUnityEngine.RUIElements.RStyleRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheet, @rule.Value};
            var ___result = RMUpdateInlineRule_StyleSheet_StyleRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputedStyle(ref RUnityEngine.RUIElements.RComputedStyle @newStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newStyle.Value};
            var ___result = RMSetComputedStyle_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@newStyle = new RUnityEngine.RUIElements.RComputedStyle(___parameters[0]);

            
        }


        public virtual void ResetPositionProperties()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResetPositionProperties.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Collections.Generic.IEnumerable<System.String> GetClasses()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetClasses.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<System.String>)___result;
        }


        public virtual System.Collections.Generic.List<System.String> GetClassesForIteration()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetClassesForIteration.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<System.String>)___result;
        }


        public virtual void ClearClassList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearClassList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddToClassList(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RMAddToClassList_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFromClassList(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RMRemoveFromClassList_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ToggleInClassList(System.String @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RMToggleInClassList_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableInClassList(System.String @className, System.Boolean @enable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className, @enable};
            var ___result = RMEnableInClassList_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ClassListContains(System.String @cls)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cls};
            var ___result = RMClassListContains_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object FindAncestorUserData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFindAncestorUserData.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetProperty(UnityEngine.PropertyName @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMGetProperty_PropertyName.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetProperty(UnityEngine.PropertyName @key, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RMSetProperty_PropertyName_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasProperty(UnityEngine.PropertyName @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMHasProperty_PropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ApplyPlayerRenderingToEditorElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMApplyPlayerRenderingToEditorElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterAnimation(RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate @anim)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anim.Value};
            var ___result = RMRegisterAnimation_IValueAnimationUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterAnimation(RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate @anim)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anim.Value};
            var ___result = RMUnregisterAnimation_IValueAnimationUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean GetCachedNextParentWithEventCallback(out UnityEngine.UIElements.VisualElement @nextParent)
        {
			@nextParent = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nextParent};
            var ___result = RMGetCachedNextParentWithEventCallback_Out_VisualElement.Invoke(___genericsType, ___parameters);
			@nextParent = (UnityEngine.UIElements.VisualElement)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasEventCallbacks(RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasEventCallbacks_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasParentEventCallbacks(RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasParentEventCallbacks_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasParentEventCallbacksOrDefaultActions(RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasParentEventCallbacksOrDefaultActions_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasEventCallbacksOrDefaultActions(RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasEventCallbacksOrDefaultActions_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasParentEventCallbacksOrDefaultActionAtTarget(RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasEventCallbacksOrDefaultActionAtTarget(RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasEventCallbacksOrDefaultActionAtTarget_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasDefaultAction(RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasDefaultAction_EventCategory.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ShouldClip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShouldClip.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Add(UnityEngine.UIElements.VisualElement @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RMAdd_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Insert(System.Int32 @index, UnityEngine.UIElements.VisualElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @element};
            var ___result = RMInsert_Int32_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Remove(UnityEngine.UIElements.VisualElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RMRemove_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMRemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement ElementAt(System.Int32 @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RMElementAt_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual System.Int32 IndexOf(UnityEngine.UIElements.VisualElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RMIndexOf_VisualElement.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement ElementAtTreePath(System.Collections.Generic.List<System.Int32> @childIndexes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@childIndexes};
            var ___result = RMElementAtTreePath_List_d_Int32_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual System.Boolean FindElementInTree(UnityEngine.UIElements.VisualElement @element, System.Collections.Generic.List<System.Int32> @outChildIndexes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @outChildIndexes};
            var ___result = RMFindElementInTree_VisualElement_List_d_Int32_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement> Children()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMChildren.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement>)___result;
        }


        public virtual void Sort(System.Comparison<UnityEngine.UIElements.VisualElement> @comp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comp};
            var ___result = RMSort_Comparison_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BringToFront()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBringToFront.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendToBack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSendToBack.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlaceBehind(UnityEngine.UIElements.VisualElement @sibling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sibling};
            var ___result = RMPlaceBehind_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlaceInFront(UnityEngine.UIElements.VisualElement @sibling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sibling};
            var ___result = RMPlaceInFront_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFromHierarchy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRemoveFromHierarchy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T GetFirstOfType<T>() where T : class
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetFirstOfType_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetFirstAncestorOfType<T>() where T : class
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetFirstAncestorOfType_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetFirstAncestorWhere(System.Predicate<UnityEngine.UIElements.VisualElement> @predicate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@predicate};
            var ___result = RMGetFirstAncestorWhere_Predicate_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual System.Boolean Contains(UnityEngine.UIElements.VisualElement @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RMContains_VisualElement.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement FindCommonAncestor(UnityEngine.UIElements.VisualElement @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMFindCommonAncestor_VisualElement.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetRoot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRoot.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetRootVisualContainer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRootVisualContainer.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetNextElementDepthFirst()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNextElementDepthFirst.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetPreviousElementDepthFirst()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPreviousElementDepthFirst.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement RetargetElement(UnityEngine.UIElements.VisualElement @retargetAgainst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@retargetAgainst};
            var ___result = RMRetargetElement_VisualElement.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual void GetPivotedMatrixWithLayout(out UnityEngine.Matrix4x4 @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RMGetPivotedMatrixWithLayout_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@result = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void AddStyleSheetPath(System.String @sheetPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheetPath};
            var ___result = RMAddStyleSheetPath_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasStyleSheetPath(System.String @sheetPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheetPath};
            var ___result = RMHasStyleSheetPath_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RemoveStyleSheetPath(System.String @sheetPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheetPath};
            var ___result = RMRemoveStyleSheetPath_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blur()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBlur.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BlurImmediately()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBlurImmediately.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteDefaultActionDisabled(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMExecuteDefaultActionDisabled_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> @callback, UnityEngine.UIElements.TrickleDown @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType)};
            var ___parameters = new object[]{@callback, @useTrickleDown};
            var ___result = RMRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterCallback<TEventType, TUserArgsType>(UnityEngine.UIElements.EventCallback<TEventType, TUserArgsType> @callback, TUserArgsType @userArgs, UnityEngine.UIElements.TrickleDown @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType), typeof(TUserArgsType)};
            var ___parameters = new object[]{@callback, @userArgs, @useTrickleDown};
            var ___result = RMRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> @callback, RUnityEngine.RUIElements.RInvokePolicy @invokePolicy, UnityEngine.UIElements.TrickleDown @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType)};
            var ___parameters = new object[]{@callback, @invokePolicy.Value, @useTrickleDown};
            var ___result = RMRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> @callback, UnityEngine.UIElements.TrickleDown @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType)};
            var ___parameters = new object[]{@callback, @useTrickleDown};
            var ___result = RMUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterCallback<TEventType, TUserArgsType>(UnityEngine.UIElements.EventCallback<TEventType, TUserArgsType> @callback, UnityEngine.UIElements.TrickleDown @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType), typeof(TUserArgsType)};
            var ___parameters = new object[]{@callback, @useTrickleDown};
            var ___result = RMUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryGetUserArgs<TEventType, TCallbackArgs>(UnityEngine.UIElements.EventCallback<TEventType, TCallbackArgs> @callback, UnityEngine.UIElements.TrickleDown @useTrickleDown, out TCallbackArgs @userData) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {
			@userData = default;

            var ___genericsType = new Type[] {typeof(TEventType), typeof(TCallbackArgs)};
            var ___parameters = new object[]{@callback, @useTrickleDown, @userData};
            var ___result = RMTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs.Invoke(___genericsType, ___parameters);
			@userData = (TCallbackArgs)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual void HandleEventAtTargetPhase(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMHandleEventAtTargetPhase_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEventAtTargetAndDefaultPhase(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMHandleEventAtTargetAndDefaultPhase_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEventAtCurrentTargetAndPhase(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMHandleEventAtCurrentTargetAndPhase_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEventEditorInternal(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMHandleEventEditorInternal_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEvent(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMHandleEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasTrickleDownHandlers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasTrickleDownHandlers.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasBubbleUpHandlers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasBubbleUpHandlers.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMExecuteDefaultActionAtTarget_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteDefaultActionDisabledAtTarget(UnityEngine.UIElements.EventBase @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RMExecuteDefaultActionDisabledAtTarget_EventBase.Invoke(___genericsType, ___parameters);

            
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
