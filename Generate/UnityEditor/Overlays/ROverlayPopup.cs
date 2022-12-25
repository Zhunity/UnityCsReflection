using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.ROverlays
{
	/// <summary>
	/// UnityEditor.Overlays.OverlayPopup
	/// </summary>
    public partial class ROverlayPopup : RMember //
    {

		/// <summary>
		/// System.Boolean m_CursorIsOverPopup
		/// </summary>
		protected RField r_m_CursorIsOverPopup;
		public virtual RField Rm_CursorIsOverPopup
		{
			get
			{
				if(r_m_CursorIsOverPopup == null)
				{
					r_m_CursorIsOverPopup = new(this, "m_CursorIsOverPopup");
					r_m_CursorIsOverPopup.SetBelong(this.instance);
				}
				return r_m_CursorIsOverPopup;
			}
		}

		/// <summary>
		/// System.String k_OutsideToolbar
		/// </summary>
		protected static RField r_k_OutsideToolbar;
		public static RField Rk_OutsideToolbar
		{
			get
			{
				if(r_k_OutsideToolbar == null)
				{
					r_k_OutsideToolbar = new( ReleactionUtils.GetType("UnityEditor.Overlays.OverlayPopup"), "k_OutsideToolbar");
					r_k_OutsideToolbar.SetBelong(null);
				}
				return r_k_OutsideToolbar;
			}
		}

		/// <summary>
		/// System.String k_FromHorizontal
		/// </summary>
		protected static RField r_k_FromHorizontal;
		public static RField Rk_FromHorizontal
		{
			get
			{
				if(r_k_FromHorizontal == null)
				{
					r_k_FromHorizontal = new( ReleactionUtils.GetType("UnityEditor.Overlays.OverlayPopup"), "k_FromHorizontal");
					r_k_FromHorizontal.SetBelong(null);
				}
				return r_k_FromHorizontal;
			}
		}

		/// <summary>
		/// System.String k_FromVertical
		/// </summary>
		protected static RField r_k_FromVertical;
		public static RField Rk_FromVertical
		{
			get
			{
				if(r_k_FromVertical == null)
				{
					r_k_FromVertical = new( ReleactionUtils.GetType("UnityEditor.Overlays.OverlayPopup"), "k_FromVertical");
					r_k_FromVertical.SetBelong(null);
				}
				return r_k_FromVertical;
			}
		}

		/// <summary>
		/// System.String k_Clamped
		/// </summary>
		protected static RField r_k_Clamped;
		public static RField Rk_Clamped
		{
			get
			{
				if(r_k_Clamped == null)
				{
					r_k_Clamped = new( ReleactionUtils.GetType("UnityEditor.Overlays.OverlayPopup"), "k_Clamped");
					r_k_Clamped.SetBelong(null);
				}
				return r_k_Clamped;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags m_Flags
		/// </summary>
		protected RField r_m_Flags;
		public virtual RField Rm_Flags
		{
			get
			{
				if(r_m_Flags == null)
				{
					r_m_Flags = new(this, "m_Flags");
					r_m_Flags.SetBelong(this.instance);
				}
				return r_m_Flags;
			}
		}

		/// <summary>
		/// UnityEngine.Rect lastLayout
		/// </summary>
		protected RUnityEngine.RRect r_lastLayout;
		public virtual RUnityEngine.RRect RlastLayout
		{
			get
			{
				if(r_lastLayout == null)
				{
					r_lastLayout = new(this, "lastLayout");
					r_lastLayout.SetBelong(this.instance);
				}
				return r_lastLayout;
			}
		}

		/// <summary>
		/// UnityEngine.Rect lastPseudoPadding
		/// </summary>
		protected RUnityEngine.RRect r_lastPseudoPadding;
		public virtual RUnityEngine.RRect RlastPseudoPadding
		{
			get
			{
				if(r_lastPseudoPadding == null)
				{
					r_lastPseudoPadding = new(this, "lastPseudoPadding");
					r_lastPseudoPadding.SetBelong(this.instance);
				}
				return r_lastPseudoPadding;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainVEData renderChainData
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainVEData r_renderChainData;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainVEData RrenderChainData
		{
			get
			{
				if(r_renderChainData == null)
				{
					r_renderChainData = new(this, "renderChainData");
					r_renderChainData.SetBelong(this.instance);
				}
				return r_renderChainData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PseudoStates triggerPseudoMask
		/// </summary>
		protected RField r_triggerPseudoMask;
		public virtual RField RtriggerPseudoMask
		{
			get
			{
				if(r_triggerPseudoMask == null)
				{
					r_triggerPseudoMask = new(this, "triggerPseudoMask");
					r_triggerPseudoMask.SetBelong(this.instance);
				}
				return r_triggerPseudoMask;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PseudoStates dependencyPseudoMask
		/// </summary>
		protected RField r_dependencyPseudoMask;
		public virtual RField RdependencyPseudoMask
		{
			get
			{
				if(r_dependencyPseudoMask == null)
				{
					r_dependencyPseudoMask = new(this, "dependencyPseudoMask");
					r_dependencyPseudoMask.SetBelong(this.instance);
				}
				return r_dependencyPseudoMask;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedStyle m_Style
		/// </summary>
		protected RUnityEngine.RUIElements.RComputedStyle r_m_Style;
		public virtual RUnityEngine.RUIElements.RComputedStyle Rm_Style
		{
			get
			{
				if(r_m_Style == null)
				{
					r_m_Style = new(this, "m_Style");
					r_m_Style.SetBelong(this.instance);
				}
				return r_m_Style;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleVariableContext variableContext
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleVariableContext r_variableContext;
		public virtual RUnityEngine.RUIElements.RStyleVariableContext RvariableContext
		{
			get
			{
				if(r_variableContext == null)
				{
					r_variableContext = new(this, "variableContext");
					r_variableContext.SetBelong(this.instance);
				}
				return r_variableContext;
			}
		}

		/// <summary>
		/// System.Int32 inheritedStylesHash
		/// </summary>
		protected RField r_inheritedStylesHash;
		public virtual RField RinheritedStylesHash
		{
			get
			{
				if(r_inheritedStylesHash == null)
				{
					r_inheritedStylesHash = new(this, "inheritedStylesHash");
					r_inheritedStylesHash.SetBelong(this.instance);
				}
				return r_inheritedStylesHash;
			}
		}

		/// <summary>
		/// System.UInt32 controlid
		/// </summary>
		protected RField r_controlid;
		public virtual RField Rcontrolid
		{
			get
			{
				if(r_controlid == null)
				{
					r_controlid = new(this, "controlid");
					r_controlid.SetBelong(this.instance);
				}
				return r_controlid;
			}
		}

		/// <summary>
		/// System.Int32 imguiContainerDescendantCount
		/// </summary>
		protected RField r_imguiContainerDescendantCount;
		public virtual RField RimguiContainerDescendantCount
		{
			get
			{
				if(r_imguiContainerDescendantCount == null)
				{
					r_imguiContainerDescendantCount = new(this, "imguiContainerDescendantCount");
					r_imguiContainerDescendantCount.SetBelong(this.instance);
				}
				return r_imguiContainerDescendantCount;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.InlineStyleAccess inlineStyleAccess
		/// </summary>
		protected RUnityEngine.RUIElements.RInlineStyleAccess r_inlineStyleAccess;
		public virtual RUnityEngine.RUIElements.RInlineStyleAccess RinlineStyleAccess
		{
			get
			{
				if(r_inlineStyleAccess == null)
				{
					r_inlineStyleAccess = new(this, "inlineStyleAccess");
					r_inlineStyleAccess.SetBelong(this.instance);
				}
				return r_inlineStyleAccess;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheet] styleSheetList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheet> r_styleSheetList;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheet> RstyleSheetList
		{
			get
			{
				if(r_styleSheetList == null)
				{
					r_styleSheetList = new(this, "styleSheetList");
					r_styleSheetList.SetBelong(this.instance);
				}
				return r_styleSheetList;
			}
		}

		/// <summary>
		/// System.Boolean isIMGUIContainer
		/// </summary>
		protected RField r_isIMGUIContainer;
		public virtual RField RisIMGUIContainer
		{
			get
			{
				if(r_isIMGUIContainer == null)
				{
					r_isIMGUIContainer = new(this, "isIMGUIContainer");
					r_isIMGUIContainer.SetBelong(this.instance);
				}
				return r_isIMGUIContainer;
			}
		}

		/// <summary>
		/// Boolean containsCursor
		/// </summary>
		protected RProperty r_containsCursor;
		public virtual RProperty RcontainsCursor
		{
			get
			{
				if(r_containsCursor == null)
				{
					r_containsCursor = new(this, "containsCursor", -1);
					r_containsCursor.SetBelong(this.instance);
				}
				return r_containsCursor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IResolvedStyle resolvedStyle
		/// </summary>
		protected RUnityEngine.RUIElements.RIResolvedStyle r_resolvedStyle;
		public virtual RUnityEngine.RUIElements.RIResolvedStyle RresolvedStyle
		{
			get
			{
				if(r_resolvedStyle == null)
				{
					r_resolvedStyle = new(this, "resolvedStyle", -1);
					r_resolvedStyle.SetBelong(this.instance);
				}
				return r_resolvedStyle;
			}
		}

		/// <summary>
		/// Boolean hasRunningAnimations
		/// </summary>
		protected RProperty r_hasRunningAnimations;
		public virtual RProperty RhasRunningAnimations
		{
			get
			{
				if(r_hasRunningAnimations == null)
				{
					r_hasRunningAnimations = new(this, "hasRunningAnimations", -1);
					r_hasRunningAnimations.SetBelong(this.instance);
				}
				return r_hasRunningAnimations;
			}
		}

		/// <summary>
		/// Boolean hasCompletedAnimations
		/// </summary>
		protected RProperty r_hasCompletedAnimations;
		public virtual RProperty RhasCompletedAnimations
		{
			get
			{
				if(r_hasCompletedAnimations == null)
				{
					r_hasCompletedAnimations = new(this, "hasCompletedAnimations", -1);
					r_hasCompletedAnimations.SetBelong(this.instance);
				}
				return r_hasCompletedAnimations;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IStylePropertyAnimations styleAnimation
		/// </summary>
		protected RUnityEngine.RUIElements.RIStylePropertyAnimations r_styleAnimation;
		public virtual RUnityEngine.RUIElements.RIStylePropertyAnimations RstyleAnimation
		{
			get
			{
				if(r_styleAnimation == null)
				{
					r_styleAnimation = new(this, "styleAnimation", -1);
					r_styleAnimation.SetBelong(this.instance);
				}
				return r_styleAnimation;
			}
		}

		/// <summary>
		/// Boolean isCompositeRoot
		/// </summary>
		protected RProperty r_isCompositeRoot;
		public virtual RProperty RisCompositeRoot
		{
			get
			{
				if(r_isCompositeRoot == null)
				{
					r_isCompositeRoot = new(this, "isCompositeRoot", -1);
					r_isCompositeRoot.SetBelong(this.instance);
				}
				return r_isCompositeRoot;
			}
		}

		/// <summary>
		/// Boolean isHierarchyDisplayed
		/// </summary>
		protected RProperty r_isHierarchyDisplayed;
		public virtual RProperty RisHierarchyDisplayed
		{
			get
			{
				if(r_isHierarchyDisplayed == null)
				{
					r_isHierarchyDisplayed = new(this, "isHierarchyDisplayed", -1);
					r_isHierarchyDisplayed.SetBelong(this.instance);
				}
				return r_isHierarchyDisplayed;
			}
		}

		/// <summary>
		/// System.String viewDataKey
		/// </summary>
		protected RProperty r_viewDataKey;
		public virtual RProperty RviewDataKey
		{
			get
			{
				if(r_viewDataKey == null)
				{
					r_viewDataKey = new(this, "viewDataKey", -1);
					r_viewDataKey.SetBelong(this.instance);
				}
				return r_viewDataKey;
			}
		}

		/// <summary>
		/// Boolean enableViewDataPersistence
		/// </summary>
		protected RProperty r_enableViewDataPersistence;
		public virtual RProperty RenableViewDataPersistence
		{
			get
			{
				if(r_enableViewDataPersistence == null)
				{
					r_enableViewDataPersistence = new(this, "enableViewDataPersistence", -1);
					r_enableViewDataPersistence.SetBelong(this.instance);
				}
				return r_enableViewDataPersistence;
			}
		}

		/// <summary>
		/// System.Object userData
		/// </summary>
		protected RSystem.RObject r_userData;
		public virtual RSystem.RObject RuserData
		{
			get
			{
				if(r_userData == null)
				{
					r_userData = new(this, "userData", -1);
					r_userData.SetBelong(this.instance);
				}
				return r_userData;
			}
		}

		/// <summary>
		/// Boolean canGrabFocus
		/// </summary>
		protected RProperty r_canGrabFocus;
		public virtual RProperty RcanGrabFocus
		{
			get
			{
				if(r_canGrabFocus == null)
				{
					r_canGrabFocus = new(this, "canGrabFocus", -1);
					r_canGrabFocus.SetBelong(this.instance);
				}
				return r_canGrabFocus;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FocusController focusController
		/// </summary>
		protected RUnityEngine.RUIElements.RFocusController r_focusController;
		public virtual RUnityEngine.RUIElements.RFocusController RfocusController
		{
			get
			{
				if(r_focusController == null)
				{
					r_focusController = new(this, "focusController", -1);
					r_focusController.SetBelong(this.instance);
				}
				return r_focusController;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UsageHints usageHints
		/// </summary>
		protected RProperty r_usageHints;
		public virtual RProperty RusageHints
		{
			get
			{
				if(r_usageHints == null)
				{
					r_usageHints = new(this, "usageHints", -1);
					r_usageHints.SetBelong(this.instance);
				}
				return r_usageHints;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.RenderHints renderHints
		/// </summary>
		protected RProperty r_renderHints;
		public virtual RProperty RrenderHints
		{
			get
			{
				if(r_renderHints == null)
				{
					r_renderHints = new(this, "renderHints", -1);
					r_renderHints.SetBelong(this.instance);
				}
				return r_renderHints;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ITransform transform
		/// </summary>
		protected RUnityEngine.RUIElements.RITransform r_transform;
		public virtual RUnityEngine.RUIElements.RITransform Rtransform
		{
			get
			{
				if(r_transform == null)
				{
					r_transform = new(this, "transform", -1);
					r_transform.SetBelong(this.instance);
				}
				return r_transform;
			}
		}

		/// <summary>
		/// Boolean isLayoutManual
		/// </summary>
		protected RProperty r_isLayoutManual;
		public virtual RProperty RisLayoutManual
		{
			get
			{
				if(r_isLayoutManual == null)
				{
					r_isLayoutManual = new(this, "isLayoutManual", -1);
					r_isLayoutManual.SetBelong(this.instance);
				}
				return r_isLayoutManual;
			}
		}

		/// <summary>
		/// Single scaledPixelsPerPoint
		/// </summary>
		protected RProperty r_scaledPixelsPerPoint;
		public virtual RProperty RscaledPixelsPerPoint
		{
			get
			{
				if(r_scaledPixelsPerPoint == null)
				{
					r_scaledPixelsPerPoint = new(this, "scaledPixelsPerPoint", -1);
					r_scaledPixelsPerPoint.SetBelong(this.instance);
				}
				return r_scaledPixelsPerPoint;
			}
		}

		/// <summary>
		/// UnityEngine.Rect layout
		/// </summary>
		protected RUnityEngine.RRect r_layout;
		public virtual RUnityEngine.RRect Rlayout
		{
			get
			{
				if(r_layout == null)
				{
					r_layout = new(this, "layout", -1);
					r_layout.SetBelong(this.instance);
				}
				return r_layout;
			}
		}

		/// <summary>
		/// UnityEngine.Rect contentRect
		/// </summary>
		protected RUnityEngine.RRect r_contentRect;
		public virtual RUnityEngine.RRect RcontentRect
		{
			get
			{
				if(r_contentRect == null)
				{
					r_contentRect = new(this, "contentRect", -1);
					r_contentRect.SetBelong(this.instance);
				}
				return r_contentRect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect paddingRect
		/// </summary>
		protected RUnityEngine.RRect r_paddingRect;
		public virtual RUnityEngine.RRect RpaddingRect
		{
			get
			{
				if(r_paddingRect == null)
				{
					r_paddingRect = new(this, "paddingRect", -1);
					r_paddingRect.SetBelong(this.instance);
				}
				return r_paddingRect;
			}
		}

		/// <summary>
		/// Boolean isBoundingBoxDirty
		/// </summary>
		protected RProperty r_isBoundingBoxDirty;
		public virtual RProperty RisBoundingBoxDirty
		{
			get
			{
				if(r_isBoundingBoxDirty == null)
				{
					r_isBoundingBoxDirty = new(this, "isBoundingBoxDirty", -1);
					r_isBoundingBoxDirty.SetBelong(this.instance);
				}
				return r_isBoundingBoxDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldBoundingBoxDirty
		/// </summary>
		protected RProperty r_isWorldBoundingBoxDirty;
		public virtual RProperty RisWorldBoundingBoxDirty
		{
			get
			{
				if(r_isWorldBoundingBoxDirty == null)
				{
					r_isWorldBoundingBoxDirty = new(this, "isWorldBoundingBoxDirty", -1);
					r_isWorldBoundingBoxDirty.SetBelong(this.instance);
				}
				return r_isWorldBoundingBoxDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldBoundingBoxOrDependenciesDirty
		/// </summary>
		protected RProperty r_isWorldBoundingBoxOrDependenciesDirty;
		public virtual RProperty RisWorldBoundingBoxOrDependenciesDirty
		{
			get
			{
				if(r_isWorldBoundingBoxOrDependenciesDirty == null)
				{
					r_isWorldBoundingBoxOrDependenciesDirty = new(this, "isWorldBoundingBoxOrDependenciesDirty", -1);
					r_isWorldBoundingBoxOrDependenciesDirty.SetBelong(this.instance);
				}
				return r_isWorldBoundingBoxOrDependenciesDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Rect boundingBox
		/// </summary>
		protected RUnityEngine.RRect r_boundingBox;
		public virtual RUnityEngine.RRect RboundingBox
		{
			get
			{
				if(r_boundingBox == null)
				{
					r_boundingBox = new(this, "boundingBox", -1);
					r_boundingBox.SetBelong(this.instance);
				}
				return r_boundingBox;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldBoundingBox
		/// </summary>
		protected RUnityEngine.RRect r_worldBoundingBox;
		public virtual RUnityEngine.RRect RworldBoundingBox
		{
			get
			{
				if(r_worldBoundingBox == null)
				{
					r_worldBoundingBox = new(this, "worldBoundingBox", -1);
					r_worldBoundingBox.SetBelong(this.instance);
				}
				return r_worldBoundingBox;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldBound
		/// </summary>
		protected RUnityEngine.RRect r_worldBound;
		public virtual RUnityEngine.RRect RworldBound
		{
			get
			{
				if(r_worldBound == null)
				{
					r_worldBound = new(this, "worldBound", -1);
					r_worldBound.SetBelong(this.instance);
				}
				return r_worldBound;
			}
		}

		/// <summary>
		/// UnityEngine.Rect localBound
		/// </summary>
		protected RUnityEngine.RRect r_localBound;
		public virtual RUnityEngine.RRect RlocalBound
		{
			get
			{
				if(r_localBound == null)
				{
					r_localBound = new(this, "localBound", -1);
					r_localBound.SetBelong(this.instance);
				}
				return r_localBound;
			}
		}

		/// <summary>
		/// UnityEngine.Rect rect
		/// </summary>
		protected RUnityEngine.RRect r_rect;
		public virtual RUnityEngine.RRect Rrect
		{
			get
			{
				if(r_rect == null)
				{
					r_rect = new(this, "rect", -1);
					r_rect.SetBelong(this.instance);
				}
				return r_rect;
			}
		}

		/// <summary>
		/// Boolean isWorldTransformDirty
		/// </summary>
		protected RProperty r_isWorldTransformDirty;
		public virtual RProperty RisWorldTransformDirty
		{
			get
			{
				if(r_isWorldTransformDirty == null)
				{
					r_isWorldTransformDirty = new(this, "isWorldTransformDirty", -1);
					r_isWorldTransformDirty.SetBelong(this.instance);
				}
				return r_isWorldTransformDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldTransformInverseDirty
		/// </summary>
		protected RProperty r_isWorldTransformInverseDirty;
		public virtual RProperty RisWorldTransformInverseDirty
		{
			get
			{
				if(r_isWorldTransformInverseDirty == null)
				{
					r_isWorldTransformInverseDirty = new(this, "isWorldTransformInverseDirty", -1);
					r_isWorldTransformInverseDirty.SetBelong(this.instance);
				}
				return r_isWorldTransformInverseDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldTransformInverseOrDependenciesDirty
		/// </summary>
		protected RProperty r_isWorldTransformInverseOrDependenciesDirty;
		public virtual RProperty RisWorldTransformInverseOrDependenciesDirty
		{
			get
			{
				if(r_isWorldTransformInverseOrDependenciesDirty == null)
				{
					r_isWorldTransformInverseOrDependenciesDirty = new(this, "isWorldTransformInverseOrDependenciesDirty", -1);
					r_isWorldTransformInverseOrDependenciesDirty.SetBelong(this.instance);
				}
				return r_isWorldTransformInverseOrDependenciesDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 worldTransform
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_worldTransform;
		public virtual RUnityEngine.RMatrix4x4 RworldTransform
		{
			get
			{
				if(r_worldTransform == null)
				{
					r_worldTransform = new(this, "worldTransform", -1);
					r_worldTransform.SetBelong(this.instance);
				}
				return r_worldTransform;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4& worldTransformRef
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_worldTransformRef;
		public virtual RUnityEngine.RMatrix4x4 RworldTransformRef
		{
			get
			{
				if(r_worldTransformRef == null)
				{
					r_worldTransformRef = new(this, "worldTransformRef", -1);
					r_worldTransformRef.SetBelong(this.instance);
				}
				return r_worldTransformRef;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4& worldTransformInverse
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_worldTransformInverse;
		public virtual RUnityEngine.RMatrix4x4 RworldTransformInverse
		{
			get
			{
				if(r_worldTransformInverse == null)
				{
					r_worldTransformInverse = new(this, "worldTransformInverse", -1);
					r_worldTransformInverse.SetBelong(this.instance);
				}
				return r_worldTransformInverse;
			}
		}

		/// <summary>
		/// Boolean isWorldClipDirty
		/// </summary>
		protected RProperty r_isWorldClipDirty;
		public virtual RProperty RisWorldClipDirty
		{
			get
			{
				if(r_isWorldClipDirty == null)
				{
					r_isWorldClipDirty = new(this, "isWorldClipDirty", -1);
					r_isWorldClipDirty.SetBelong(this.instance);
				}
				return r_isWorldClipDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldClip
		/// </summary>
		protected RUnityEngine.RRect r_worldClip;
		public virtual RUnityEngine.RRect RworldClip
		{
			get
			{
				if(r_worldClip == null)
				{
					r_worldClip = new(this, "worldClip", -1);
					r_worldClip.SetBelong(this.instance);
				}
				return r_worldClip;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldClipMinusGroup
		/// </summary>
		protected RUnityEngine.RRect r_worldClipMinusGroup;
		public virtual RUnityEngine.RRect RworldClipMinusGroup
		{
			get
			{
				if(r_worldClipMinusGroup == null)
				{
					r_worldClipMinusGroup = new(this, "worldClipMinusGroup", -1);
					r_worldClipMinusGroup.SetBelong(this.instance);
				}
				return r_worldClipMinusGroup;
			}
		}

		/// <summary>
		/// Boolean worldClipIsInfinite
		/// </summary>
		protected RProperty r_worldClipIsInfinite;
		public virtual RProperty RworldClipIsInfinite
		{
			get
			{
				if(r_worldClipIsInfinite == null)
				{
					r_worldClipIsInfinite = new(this, "worldClipIsInfinite", -1);
					r_worldClipIsInfinite.SetBelong(this.instance);
				}
				return r_worldClipIsInfinite;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PseudoStates pseudoStates
		/// </summary>
		protected RProperty r_pseudoStates;
		public virtual RProperty RpseudoStates
		{
			get
			{
				if(r_pseudoStates == null)
				{
					r_pseudoStates = new(this, "pseudoStates", -1);
					r_pseudoStates.SetBelong(this.instance);
				}
				return r_pseudoStates;
			}
		}

		/// <summary>
		/// Int32 containedPointerIds
		/// </summary>
		protected RProperty r_containedPointerIds;
		public virtual RProperty RcontainedPointerIds
		{
			get
			{
				if(r_containedPointerIds == null)
				{
					r_containedPointerIds = new(this, "containedPointerIds", -1);
					r_containedPointerIds.SetBelong(this.instance);
				}
				return r_containedPointerIds;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PickingMode pickingMode
		/// </summary>
		protected RProperty r_pickingMode;
		public virtual RProperty RpickingMode
		{
			get
			{
				if(r_pickingMode == null)
				{
					r_pickingMode = new(this, "pickingMode", -1);
					r_pickingMode.SetBelong(this.instance);
				}
				return r_pickingMode;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] classList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RProperty> r_classList;
		public virtual RSystem.RCollections.RGeneric.RList<RProperty> RclassList
		{
			get
			{
				if(r_classList == null)
				{
					r_classList = new(this, "classList", -1);
					r_classList.SetBelong(this.instance);
				}
				return r_classList;
			}
		}

		/// <summary>
		/// System.String fullTypeName
		/// </summary>
		protected RProperty r_fullTypeName;
		public virtual RProperty RfullTypeName
		{
			get
			{
				if(r_fullTypeName == null)
				{
					r_fullTypeName = new(this, "fullTypeName", -1);
					r_fullTypeName.SetBelong(this.instance);
				}
				return r_fullTypeName;
			}
		}

		/// <summary>
		/// System.String typeName
		/// </summary>
		protected RProperty r_typeName;
		public virtual RProperty RtypeName
		{
			get
			{
				if(r_typeName == null)
				{
					r_typeName = new(this, "typeName", -1);
					r_typeName.SetBelong(this.instance);
				}
				return r_typeName;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaNode yogaNode
		/// </summary>
		protected RUnityEngine.RYoga.RYogaNode r_yogaNode;
		public virtual RUnityEngine.RYoga.RYogaNode RyogaNode
		{
			get
			{
				if(r_yogaNode == null)
				{
					r_yogaNode = new(this, "yogaNode", -1);
					r_yogaNode.SetBelong(this.instance);
				}
				return r_yogaNode;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedStyle& computedStyle
		/// </summary>
		protected RUnityEngine.RUIElements.RComputedStyle r_computedStyle;
		public virtual RUnityEngine.RUIElements.RComputedStyle RcomputedStyle
		{
			get
			{
				if(r_computedStyle == null)
				{
					r_computedStyle = new(this, "computedStyle", -1);
					r_computedStyle.SetBelong(this.instance);
				}
				return r_computedStyle;
			}
		}

		/// <summary>
		/// Boolean hasInlineStyle
		/// </summary>
		protected RProperty r_hasInlineStyle;
		public virtual RProperty RhasInlineStyle
		{
			get
			{
				if(r_hasInlineStyle == null)
				{
					r_hasInlineStyle = new(this, "hasInlineStyle", -1);
					r_hasInlineStyle.SetBelong(this.instance);
				}
				return r_hasInlineStyle;
			}
		}

		/// <summary>
		/// Boolean styleInitialized
		/// </summary>
		protected RProperty r_styleInitialized;
		public virtual RProperty RstyleInitialized
		{
			get
			{
				if(r_styleInitialized == null)
				{
					r_styleInitialized = new(this, "styleInitialized", -1);
					r_styleInitialized.SetBelong(this.instance);
				}
				return r_styleInitialized;
			}
		}

		/// <summary>
		/// Single opacity
		/// </summary>
		protected RProperty r_opacity;
		public virtual RProperty Ropacity
		{
			get
			{
				if(r_opacity == null)
				{
					r_opacity = new(this, "opacity", -1);
					r_opacity.SetBelong(this.instance);
				}
				return r_opacity;
			}
		}

		/// <summary>
		/// Boolean enabledInHierarchy
		/// </summary>
		protected RProperty r_enabledInHierarchy;
		public virtual RProperty RenabledInHierarchy
		{
			get
			{
				if(r_enabledInHierarchy == null)
				{
					r_enabledInHierarchy = new(this, "enabledInHierarchy", -1);
					r_enabledInHierarchy.SetBelong(this.instance);
				}
				return r_enabledInHierarchy;
			}
		}

		/// <summary>
		/// Boolean enabledSelf
		/// </summary>
		protected RProperty r_enabledSelf;
		public virtual RProperty RenabledSelf
		{
			get
			{
				if(r_enabledSelf == null)
				{
					r_enabledSelf = new(this, "enabledSelf", -1);
					r_enabledSelf.SetBelong(this.instance);
				}
				return r_enabledSelf;
			}
		}

		/// <summary>
		/// Boolean visible
		/// </summary>
		protected RProperty r_visible;
		public virtual RProperty Rvisible
		{
			get
			{
				if(r_visible == null)
				{
					r_visible = new(this, "visible", -1);
					r_visible.SetBelong(this.instance);
				}
				return r_visible;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.MeshGenerationContext] generateVisualContent
		/// </summary>
		protected RSystem.RAction<RUnityEngine.RUIElements.RMeshGenerationContext> r_generateVisualContent;
		public virtual RSystem.RAction<RUnityEngine.RUIElements.RMeshGenerationContext> RgenerateVisualContent
		{
			get
			{
				if(r_generateVisualContent == null)
				{
					r_generateVisualContent = new(this, "generateVisualContent", -1);
					r_generateVisualContent.SetBelong(this.instance);
				}
				return r_generateVisualContent;
			}
		}

		/// <summary>
		/// Boolean requireMeasureFunction
		/// </summary>
		protected RProperty r_requireMeasureFunction;
		public virtual RProperty RrequireMeasureFunction
		{
			get
			{
				if(r_requireMeasureFunction == null)
				{
					r_requireMeasureFunction = new(this, "requireMeasureFunction", -1);
					r_requireMeasureFunction.SetBelong(this.instance);
				}
				return r_requireMeasureFunction;
			}
		}

		/// <summary>
		/// RenderTargetMode subRenderTargetMode
		/// </summary>
		protected RProperty r_subRenderTargetMode;
		public virtual RProperty RsubRenderTargetMode
		{
			get
			{
				if(r_subRenderTargetMode == null)
				{
					r_subRenderTargetMode = new(this, "subRenderTargetMode", -1);
					r_subRenderTargetMode.SetBelong(this.instance);
				}
				return r_subRenderTargetMode;
			}
		}

		/// <summary>
		/// UnityEngine.Material defaultMaterial
		/// </summary>
		protected RUnityEngine.RMaterial r_defaultMaterial;
		public virtual RUnityEngine.RMaterial RdefaultMaterial
		{
			get
			{
				if(r_defaultMaterial == null)
				{
					r_defaultMaterial = new(this, "defaultMaterial", -1);
					r_defaultMaterial.SetBelong(this.instance);
				}
				return r_defaultMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement nextParentWithEventCallback
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_nextParentWithEventCallback;
		public virtual RUnityEngine.RUIElements.RVisualElement RnextParentWithEventCallback
		{
			get
			{
				if(r_nextParentWithEventCallback == null)
				{
					r_nextParentWithEventCallback = new(this, "nextParentWithEventCallback", -1);
					r_nextParentWithEventCallback.SetBelong(this.instance);
				}
				return r_nextParentWithEventCallback;
			}
		}

		/// <summary>
		/// Int32 eventCallbackCategories
		/// </summary>
		protected RProperty r_eventCallbackCategories;
		public virtual RProperty ReventCallbackCategories
		{
			get
			{
				if(r_eventCallbackCategories == null)
				{
					r_eventCallbackCategories = new(this, "eventCallbackCategories", -1);
					r_eventCallbackCategories.SetBelong(this.instance);
				}
				return r_eventCallbackCategories;
			}
		}

		/// <summary>
		/// Int32 eventCallbackParentCategories
		/// </summary>
		protected RProperty r_eventCallbackParentCategories;
		public virtual RProperty ReventCallbackParentCategories
		{
			get
			{
				if(r_eventCallbackParentCategories == null)
				{
					r_eventCallbackParentCategories = new(this, "eventCallbackParentCategories", -1);
					r_eventCallbackParentCategories.SetBelong(this.instance);
				}
				return r_eventCallbackParentCategories;
			}
		}

		/// <summary>
		/// Boolean isEventCallbackParentCategoriesDirty
		/// </summary>
		protected RProperty r_isEventCallbackParentCategoriesDirty;
		public virtual RProperty RisEventCallbackParentCategoriesDirty
		{
			get
			{
				if(r_isEventCallbackParentCategoriesDirty == null)
				{
					r_isEventCallbackParentCategoriesDirty = new(this, "isEventCallbackParentCategoriesDirty", -1);
					r_isEventCallbackParentCategoriesDirty.SetBelong(this.instance);
				}
				return r_isEventCallbackParentCategoriesDirty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IExperimentalFeatures experimental
		/// </summary>
		protected RUnityEngine.RUIElements.RIExperimentalFeatures r_experimental;
		public virtual RUnityEngine.RUIElements.RIExperimentalFeatures Rexperimental
		{
			get
			{
				if(r_experimental == null)
				{
					r_experimental = new(this, "experimental", -1);
					r_experimental.SetBelong(this.instance);
				}
				return r_experimental;
			}
		}

		/// <summary>
		/// Hierarchy hierarchy
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement.RHierarchy r_hierarchy;
		public virtual RUnityEngine.RUIElements.RVisualElement.RHierarchy Rhierarchy
		{
			get
			{
				if(r_hierarchy == null)
				{
					r_hierarchy = new(this, "hierarchy", -1);
					r_hierarchy.SetBelong(this.instance);
				}
				return r_hierarchy;
			}
		}

		/// <summary>
		/// Boolean isRootVisualContainer
		/// </summary>
		protected RProperty r_isRootVisualContainer;
		public virtual RProperty RisRootVisualContainer
		{
			get
			{
				if(r_isRootVisualContainer == null)
				{
					r_isRootVisualContainer = new(this, "isRootVisualContainer", -1);
					r_isRootVisualContainer.SetBelong(this.instance);
				}
				return r_isRootVisualContainer;
			}
		}

		/// <summary>
		/// Boolean cacheAsBitmap
		/// </summary>
		protected RProperty r_cacheAsBitmap;
		public virtual RProperty RcacheAsBitmap
		{
			get
			{
				if(r_cacheAsBitmap == null)
				{
					r_cacheAsBitmap = new(this, "cacheAsBitmap", -1);
					r_cacheAsBitmap.SetBelong(this.instance);
				}
				return r_cacheAsBitmap;
			}
		}

		/// <summary>
		/// Boolean disableClipping
		/// </summary>
		protected RProperty r_disableClipping;
		public virtual RProperty RdisableClipping
		{
			get
			{
				if(r_disableClipping == null)
				{
					r_disableClipping = new(this, "disableClipping", -1);
					r_disableClipping.SetBelong(this.instance);
				}
				return r_disableClipping;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement parent
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_parent;
		public virtual RUnityEngine.RUIElements.RVisualElement Rparent
		{
			get
			{
				if(r_parent == null)
				{
					r_parent = new(this, "parent", -1);
					r_parent.SetBelong(this.instance);
				}
				return r_parent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseVisualElementPanel elementPanel
		/// </summary>
		protected RUnityEngine.RUIElements.RBaseVisualElementPanel r_elementPanel;
		public virtual RUnityEngine.RUIElements.RBaseVisualElementPanel RelementPanel
		{
			get
			{
				if(r_elementPanel == null)
				{
					r_elementPanel = new(this, "elementPanel", -1);
					r_elementPanel.SetBelong(this.instance);
				}
				return r_elementPanel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IPanel panel
		/// </summary>
		protected RUnityEngine.RUIElements.RIPanel r_panel;
		public virtual RUnityEngine.RUIElements.RIPanel Rpanel
		{
			get
			{
				if(r_panel == null)
				{
					r_panel = new(this, "panel", -1);
					r_panel.SetBelong(this.instance);
				}
				return r_panel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement contentContainer
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_contentContainer;
		public virtual RUnityEngine.RUIElements.RVisualElement RcontentContainer
		{
			get
			{
				if(r_contentContainer == null)
				{
					r_contentContainer = new(this, "contentContainer", -1);
					r_contentContainer.SetBelong(this.instance);
				}
				return r_contentContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset visualTreeAssetSource
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualTreeAsset r_visualTreeAssetSource;
		public virtual RUnityEngine.RUIElements.RVisualTreeAsset RvisualTreeAssetSource
		{
			get
			{
				if(r_visualTreeAssetSource == null)
				{
					r_visualTreeAssetSource = new(this, "visualTreeAssetSource", -1);
					r_visualTreeAssetSource.SetBelong(this.instance);
				}
				return r_visualTreeAssetSource;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement Item [Int32]
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_Item_Int32;
		public virtual RUnityEngine.RUIElements.RVisualElement RItem_Int32
		{
			get
			{
				if(r_Item_Int32 == null)
				{
					r_Item_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_Item_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32;
			}
		}

		/// <summary>
		/// Int32 childCount
		/// </summary>
		protected RProperty r_childCount;
		public virtual RProperty RchildCount
		{
			get
			{
				if(r_childCount == null)
				{
					r_childCount = new(this, "childCount", -1);
					r_childCount.SetBelong(this.instance);
				}
				return r_childCount;
			}
		}

		/// <summary>
		/// Boolean hasDefaultRotationAndScale
		/// </summary>
		protected RProperty r_hasDefaultRotationAndScale;
		public virtual RProperty RhasDefaultRotationAndScale
		{
			get
			{
				if(r_hasDefaultRotationAndScale == null)
				{
					r_hasDefaultRotationAndScale = new(this, "hasDefaultRotationAndScale", -1);
					r_hasDefaultRotationAndScale.SetBelong(this.instance);
				}
				return r_hasDefaultRotationAndScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduler schedule
		/// </summary>
		protected RUnityEngine.RUIElements.RIVisualElementScheduler r_schedule;
		public virtual RUnityEngine.RUIElements.RIVisualElementScheduler Rschedule
		{
			get
			{
				if(r_schedule == null)
				{
					r_schedule = new(this, "schedule", -1);
					r_schedule.SetBelong(this.instance);
				}
				return r_schedule;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IStyle style
		/// </summary>
		protected RUnityEngine.RUIElements.RIStyle r_style;
		public virtual RUnityEngine.RUIElements.RIStyle Rstyle
		{
			get
			{
				if(r_style == null)
				{
					r_style = new(this, "style", -1);
					r_style.SetBelong(this.instance);
				}
				return r_style;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ICustomStyle customStyle
		/// </summary>
		protected RUnityEngine.RUIElements.RICustomStyle r_customStyle;
		public virtual RUnityEngine.RUIElements.RICustomStyle RcustomStyle
		{
			get
			{
				if(r_customStyle == null)
				{
					r_customStyle = new(this, "customStyle", -1);
					r_customStyle.SetBelong(this.instance);
				}
				return r_customStyle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementStyleSheetSet styleSheets
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElementStyleSheetSet r_styleSheets;
		public virtual RUnityEngine.RUIElements.RVisualElementStyleSheetSet RstyleSheets
		{
			get
			{
				if(r_styleSheets == null)
				{
					r_styleSheets = new(this, "styleSheets", -1);
					r_styleSheets.SetBelong(this.instance);
				}
				return r_styleSheets;
			}
		}

		/// <summary>
		/// System.String tooltip
		/// </summary>
		protected RProperty r_tooltip;
		public virtual RProperty Rtooltip
		{
			get
			{
				if(r_tooltip == null)
				{
					r_tooltip = new(this, "tooltip", -1);
					r_tooltip.SetBelong(this.instance);
				}
				return r_tooltip;
			}
		}

		/// <summary>
		/// Boolean focusable
		/// </summary>
		protected RProperty r_focusable;
		public virtual RProperty Rfocusable
		{
			get
			{
				if(r_focusable == null)
				{
					r_focusable = new(this, "focusable", -1);
					r_focusable.SetBelong(this.instance);
				}
				return r_focusable;
			}
		}

		/// <summary>
		/// Int32 tabIndex
		/// </summary>
		protected RProperty r_tabIndex;
		public virtual RProperty RtabIndex
		{
			get
			{
				if(r_tabIndex == null)
				{
					r_tabIndex = new(this, "tabIndex", -1);
					r_tabIndex.SetBelong(this.instance);
				}
				return r_tabIndex;
			}
		}

		/// <summary>
		/// Boolean delegatesFocus
		/// </summary>
		protected RProperty r_delegatesFocus;
		public virtual RProperty RdelegatesFocus
		{
			get
			{
				if(r_delegatesFocus == null)
				{
					r_delegatesFocus = new(this, "delegatesFocus", -1);
					r_delegatesFocus.SetBelong(this.instance);
				}
				return r_delegatesFocus;
			}
		}

		/// <summary>
		/// Boolean excludeFromFocusRing
		/// </summary>
		protected RProperty r_excludeFromFocusRing;
		public virtual RProperty RexcludeFromFocusRing
		{
			get
			{
				if(r_excludeFromFocusRing == null)
				{
					r_excludeFromFocusRing = new(this, "excludeFromFocusRing", -1);
					r_excludeFromFocusRing.SetBelong(this.instance);
				}
				return r_excludeFromFocusRing;
			}
		}

		/// <summary>
		/// Boolean TryConvertLengthUnits(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Length ByRef, UnityEngine.UIElements.Length ByRef, Int32)
		/// </summary>
		protected RMethod r_RTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32;
		public virtual RMethod RTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32
		{
			get
			{
				if(r_RTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32 == null)
				{
					r_RTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32 = new(this, "TryConvertLengthUnits", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Length).MakeByRefType(), typeof(UnityEngine.UIElements.Length).MakeByRefType(), typeof(System.Int32));
					r_RTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32.SetBelong(this.instance);
				}
				return r_RTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32;
			}
		}

		/// <summary>
		/// Boolean TryConvertTransformOriginUnits(UnityEngine.UIElements.TransformOrigin ByRef, UnityEngine.UIElements.TransformOrigin ByRef)
		/// </summary>
		protected RMethod r_RTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin;
		public virtual RMethod RTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin
		{
			get
			{
				if(r_RTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin == null)
				{
					r_RTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin = new(this, "TryConvertTransformOriginUnits", 0, typeof(UnityEngine.UIElements.TransformOrigin).MakeByRefType(), typeof(UnityEngine.UIElements.TransformOrigin).MakeByRefType());
					r_RTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin.SetBelong(this.instance);
				}
				return r_RTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin;
			}
		}

		/// <summary>
		/// Boolean TryConvertTranslateUnits(UnityEngine.UIElements.Translate ByRef, UnityEngine.UIElements.Translate ByRef)
		/// </summary>
		protected RMethod r_RTryConvertTranslateUnits_Ref_Translate_Ref_Translate;
		public virtual RMethod RTryConvertTranslateUnits_Ref_Translate_Ref_Translate
		{
			get
			{
				if(r_RTryConvertTranslateUnits_Ref_Translate_Ref_Translate == null)
				{
					r_RTryConvertTranslateUnits_Ref_Translate_Ref_Translate = new(this, "TryConvertTranslateUnits", 0, typeof(UnityEngine.UIElements.Translate).MakeByRefType(), typeof(UnityEngine.UIElements.Translate).MakeByRefType());
					r_RTryConvertTranslateUnits_Ref_Translate_Ref_Translate.SetBelong(this.instance);
				}
				return r_RTryConvertTranslateUnits_Ref_Translate_Ref_Translate;
			}
		}

		/// <summary>
		/// Boolean TryConvertBackgroundPositionUnits(UnityEngine.UIElements.BackgroundPosition ByRef, UnityEngine.UIElements.BackgroundPosition ByRef)
		/// </summary>
		protected RMethod r_RTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition;
		public virtual RMethod RTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition
		{
			get
			{
				if(r_RTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition == null)
				{
					r_RTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition = new(this, "TryConvertBackgroundPositionUnits", 0, typeof(UnityEngine.UIElements.BackgroundPosition).MakeByRefType(), typeof(UnityEngine.UIElements.BackgroundPosition).MakeByRefType());
					r_RTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition.SetBelong(this.instance);
				}
				return r_RTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition;
			}
		}

		/// <summary>
		/// Boolean TryConvertBackgroundSizeUnits(UnityEngine.UIElements.BackgroundSize ByRef, UnityEngine.UIElements.BackgroundSize ByRef)
		/// </summary>
		protected RMethod r_RTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize;
		public virtual RMethod RTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize
		{
			get
			{
				if(r_RTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize == null)
				{
					r_RTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize = new(this, "TryConvertBackgroundSizeUnits", 0, typeof(UnityEngine.UIElements.BackgroundSize).MakeByRefType(), typeof(UnityEngine.UIElements.BackgroundSize).MakeByRefType());
					r_RTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize.SetBelong(this.instance);
				}
				return r_RTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize;
			}
		}

		/// <summary>
		/// Void MarkRenderHintsClean()
		/// </summary>
		protected RMethod r_RMarkRenderHintsClean;
		public virtual RMethod RMarkRenderHintsClean
		{
			get
			{
				if(r_RMarkRenderHintsClean == null)
				{
					r_RMarkRenderHintsClean = new(this, "MarkRenderHintsClean", 0);
					r_RMarkRenderHintsClean.SetBelong(this.instance);
				}
				return r_RMarkRenderHintsClean;
			}
		}

		/// <summary>
		/// Void UpdateBoundingBox()
		/// </summary>
		protected RMethod r_RUpdateBoundingBox;
		public virtual RMethod RUpdateBoundingBox
		{
			get
			{
				if(r_RUpdateBoundingBox == null)
				{
					r_RUpdateBoundingBox = new(this, "UpdateBoundingBox", 0);
					r_RUpdateBoundingBox.SetBelong(this.instance);
				}
				return r_RUpdateBoundingBox;
			}
		}

		/// <summary>
		/// Void UpdateWorldBoundingBox()
		/// </summary>
		protected RMethod r_RUpdateWorldBoundingBox;
		public virtual RMethod RUpdateWorldBoundingBox
		{
			get
			{
				if(r_RUpdateWorldBoundingBox == null)
				{
					r_RUpdateWorldBoundingBox = new(this, "UpdateWorldBoundingBox", 0);
					r_RUpdateWorldBoundingBox.SetBelong(this.instance);
				}
				return r_RUpdateWorldBoundingBox;
			}
		}

		/// <summary>
		/// Void UpdateWorldTransform()
		/// </summary>
		protected RMethod r_RUpdateWorldTransform;
		public virtual RMethod RUpdateWorldTransform
		{
			get
			{
				if(r_RUpdateWorldTransform == null)
				{
					r_RUpdateWorldTransform = new(this, "UpdateWorldTransform", 0);
					r_RUpdateWorldTransform.SetBelong(this.instance);
				}
				return r_RUpdateWorldTransform;
			}
		}

		/// <summary>
		/// Void UpdateWorldTransformInverse()
		/// </summary>
		protected RMethod r_RUpdateWorldTransformInverse;
		public virtual RMethod RUpdateWorldTransformInverse
		{
			get
			{
				if(r_RUpdateWorldTransformInverse == null)
				{
					r_RUpdateWorldTransformInverse = new(this, "UpdateWorldTransformInverse", 0);
					r_RUpdateWorldTransformInverse.SetBelong(this.instance);
				}
				return r_RUpdateWorldTransformInverse;
			}
		}

		/// <summary>
		/// Void EnsureWorldTransformAndClipUpToDate()
		/// </summary>
		protected RMethod r_REnsureWorldTransformAndClipUpToDate;
		public virtual RMethod REnsureWorldTransformAndClipUpToDate
		{
			get
			{
				if(r_REnsureWorldTransformAndClipUpToDate == null)
				{
					r_REnsureWorldTransformAndClipUpToDate = new(this, "EnsureWorldTransformAndClipUpToDate", 0);
					r_REnsureWorldTransformAndClipUpToDate.SetBelong(this.instance);
				}
				return r_REnsureWorldTransformAndClipUpToDate;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultAction(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RExecuteDefaultAction_EventBase;
		public virtual RMethod RExecuteDefaultAction_EventBase
		{
			get
			{
				if(r_RExecuteDefaultAction_EventBase == null)
				{
					r_RExecuteDefaultAction_EventBase = new(this, "ExecuteDefaultAction", 0, typeof(UnityEngine.UIElements.EventBase));
					r_RExecuteDefaultAction_EventBase.SetBelong(this.instance);
				}
				return r_RExecuteDefaultAction_EventBase;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetTooltipRect()
		/// </summary>
		protected RMethod r_RGetTooltipRect;
		public virtual RMethod RGetTooltipRect
		{
			get
			{
				if(r_RGetTooltipRect == null)
				{
					r_RGetTooltipRect = new(this, "GetTooltipRect", 0);
					r_RGetTooltipRect.SetBelong(this.instance);
				}
				return r_RGetTooltipRect;
			}
		}

		/// <summary>
		/// Void Focus()
		/// </summary>
		protected RMethod r_RFocus;
		public virtual RMethod RFocus
		{
			get
			{
				if(r_RFocus == null)
				{
					r_RFocus = new(this, "Focus", 0);
					r_RFocus.SetBelong(this.instance);
				}
				return r_RFocus;
			}
		}

		/// <summary>
		/// Void SetPanel(UnityEngine.UIElements.BaseVisualElementPanel)
		/// </summary>
		protected RMethod r_RSetPanel_BaseVisualElementPanel;
		public virtual RMethod RSetPanel_BaseVisualElementPanel
		{
			get
			{
				if(r_RSetPanel_BaseVisualElementPanel == null)
				{
					r_RSetPanel_BaseVisualElementPanel = new(this, "SetPanel", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.BaseVisualElementPanel"));
					r_RSetPanel_BaseVisualElementPanel.SetBelong(this.instance);
				}
				return r_RSetPanel_BaseVisualElementPanel;
			}
		}

		/// <summary>
		/// Void SendEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RSendEvent_EventBase;
		public virtual RMethod RSendEvent_EventBase
		{
			get
			{
				if(r_RSendEvent_EventBase == null)
				{
					r_RSendEvent_EventBase = new(this, "SendEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_RSendEvent_EventBase.SetBelong(this.instance);
				}
				return r_RSendEvent_EventBase;
			}
		}

		/// <summary>
		/// Void SendEvent(UnityEngine.UIElements.EventBase, UnityEngine.UIElements.DispatchMode)
		/// </summary>
		protected RMethod r_RSendEvent_EventBase_DispatchMode;
		public virtual RMethod RSendEvent_EventBase_DispatchMode
		{
			get
			{
				if(r_RSendEvent_EventBase_DispatchMode == null)
				{
					r_RSendEvent_EventBase_DispatchMode = new(this, "SendEvent", 0, typeof(UnityEngine.UIElements.EventBase),  ReleactionUtils.GetType("UnityEngine.UIElements.DispatchMode"));
					r_RSendEvent_EventBase_DispatchMode.SetBelong(this.instance);
				}
				return r_RSendEvent_EventBase_DispatchMode;
			}
		}

		/// <summary>
		/// Void IncrementVersion(UnityEngine.UIElements.VersionChangeType)
		/// </summary>
		protected RMethod r_RIncrementVersion_VersionChangeType;
		public virtual RMethod RIncrementVersion_VersionChangeType
		{
			get
			{
				if(r_RIncrementVersion_VersionChangeType == null)
				{
					r_RIncrementVersion_VersionChangeType = new(this, "IncrementVersion", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.VersionChangeType"));
					r_RIncrementVersion_VersionChangeType.SetBelong(this.instance);
				}
				return r_RIncrementVersion_VersionChangeType;
			}
		}

		/// <summary>
		/// Void InvokeHierarchyChanged(UnityEngine.UIElements.HierarchyChangeType)
		/// </summary>
		protected RMethod r_RInvokeHierarchyChanged_HierarchyChangeType;
		public virtual RMethod RInvokeHierarchyChanged_HierarchyChangeType
		{
			get
			{
				if(r_RInvokeHierarchyChanged_HierarchyChangeType == null)
				{
					r_RInvokeHierarchyChanged_HierarchyChangeType = new(this, "InvokeHierarchyChanged", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.HierarchyChangeType"));
					r_RInvokeHierarchyChanged_HierarchyChangeType.SetBelong(this.instance);
				}
				return r_RInvokeHierarchyChanged_HierarchyChangeType;
			}
		}

		/// <summary>
		/// Boolean SetEnabledFromHierarchy(Boolean)
		/// </summary>
		protected RMethod r_RSetEnabledFromHierarchy_Boolean;
		public virtual RMethod RSetEnabledFromHierarchy_Boolean
		{
			get
			{
				if(r_RSetEnabledFromHierarchy_Boolean == null)
				{
					r_RSetEnabledFromHierarchy_Boolean = new(this, "SetEnabledFromHierarchy", 0, typeof(System.Boolean));
					r_RSetEnabledFromHierarchy_Boolean.SetBelong(this.instance);
				}
				return r_RSetEnabledFromHierarchy_Boolean;
			}
		}

		/// <summary>
		/// Void SetEnabled(Boolean)
		/// </summary>
		protected RMethod r_RSetEnabled_Boolean;
		public virtual RMethod RSetEnabled_Boolean
		{
			get
			{
				if(r_RSetEnabled_Boolean == null)
				{
					r_RSetEnabled_Boolean = new(this, "SetEnabled", 0, typeof(System.Boolean));
					r_RSetEnabled_Boolean.SetBelong(this.instance);
				}
				return r_RSetEnabled_Boolean;
			}
		}

		/// <summary>
		/// Void MarkDirtyRepaint()
		/// </summary>
		protected RMethod r_RMarkDirtyRepaint;
		public virtual RMethod RMarkDirtyRepaint
		{
			get
			{
				if(r_RMarkDirtyRepaint == null)
				{
					r_RMarkDirtyRepaint = new(this, "MarkDirtyRepaint", 0);
					r_RMarkDirtyRepaint.SetBelong(this.instance);
				}
				return r_RMarkDirtyRepaint;
			}
		}

		/// <summary>
		/// Void InvokeGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext)
		/// </summary>
		protected RMethod r_RInvokeGenerateVisualContent_MeshGenerationContext;
		public virtual RMethod RInvokeGenerateVisualContent_MeshGenerationContext
		{
			get
			{
				if(r_RInvokeGenerateVisualContent_MeshGenerationContext == null)
				{
					r_RInvokeGenerateVisualContent_MeshGenerationContext = new(this, "InvokeGenerateVisualContent", 0, typeof(UnityEngine.UIElements.MeshGenerationContext));
					r_RInvokeGenerateVisualContent_MeshGenerationContext.SetBelong(this.instance);
				}
				return r_RInvokeGenerateVisualContent_MeshGenerationContext;
			}
		}

		/// <summary>
		/// Void GetFullHierarchicalViewDataKey(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_RGetFullHierarchicalViewDataKey_StringBuilder;
		public virtual RMethod RGetFullHierarchicalViewDataKey_StringBuilder
		{
			get
			{
				if(r_RGetFullHierarchicalViewDataKey_StringBuilder == null)
				{
					r_RGetFullHierarchicalViewDataKey_StringBuilder = new(this, "GetFullHierarchicalViewDataKey", 0, typeof(System.Text.StringBuilder));
					r_RGetFullHierarchicalViewDataKey_StringBuilder.SetBelong(this.instance);
				}
				return r_RGetFullHierarchicalViewDataKey_StringBuilder;
			}
		}

		/// <summary>
		/// System.String GetFullHierarchicalViewDataKey()
		/// </summary>
		protected RMethod r_RGetFullHierarchicalViewDataKey;
		public virtual RMethod RGetFullHierarchicalViewDataKey
		{
			get
			{
				if(r_RGetFullHierarchicalViewDataKey == null)
				{
					r_RGetFullHierarchicalViewDataKey = new(this, "GetFullHierarchicalViewDataKey", 0);
					r_RGetFullHierarchicalViewDataKey.SetBelong(this.instance);
				}
				return r_RGetFullHierarchicalViewDataKey;
			}
		}

		/// <summary>
		/// T GetOrCreateViewData[T](System.Object, System.String)
		/// </summary>
		protected RMethod r_RGetOrCreateViewData_GT_Object_String;
		public virtual RMethod RGetOrCreateViewData_GT_Object_String
		{
			get
			{
				if(r_RGetOrCreateViewData_GT_Object_String == null)
				{
					r_RGetOrCreateViewData_GT_Object_String = new(this, "GetOrCreateViewData", 1, typeof(System.Object), typeof(System.String));
					r_RGetOrCreateViewData_GT_Object_String.SetBelong(this.instance);
				}
				return r_RGetOrCreateViewData_GT_Object_String;
			}
		}

		/// <summary>
		/// T GetOrCreateViewData[T](UnityEngine.ScriptableObject, System.String)
		/// </summary>
		protected RMethod r_RGetOrCreateViewData_GT_ScriptableObject_String;
		public virtual RMethod RGetOrCreateViewData_GT_ScriptableObject_String
		{
			get
			{
				if(r_RGetOrCreateViewData_GT_ScriptableObject_String == null)
				{
					r_RGetOrCreateViewData_GT_ScriptableObject_String = new(this, "GetOrCreateViewData", 1, typeof(UnityEngine.ScriptableObject), typeof(System.String));
					r_RGetOrCreateViewData_GT_ScriptableObject_String.SetBelong(this.instance);
				}
				return r_RGetOrCreateViewData_GT_ScriptableObject_String;
			}
		}

		/// <summary>
		/// Void OverwriteFromViewData(System.Object, System.String)
		/// </summary>
		protected RMethod r_ROverwriteFromViewData_Object_String;
		public virtual RMethod ROverwriteFromViewData_Object_String
		{
			get
			{
				if(r_ROverwriteFromViewData_Object_String == null)
				{
					r_ROverwriteFromViewData_Object_String = new(this, "OverwriteFromViewData", 0, typeof(System.Object), typeof(System.String));
					r_ROverwriteFromViewData_Object_String.SetBelong(this.instance);
				}
				return r_ROverwriteFromViewData_Object_String;
			}
		}

		/// <summary>
		/// Void SaveViewData()
		/// </summary>
		protected RMethod r_RSaveViewData;
		public virtual RMethod RSaveViewData
		{
			get
			{
				if(r_RSaveViewData == null)
				{
					r_RSaveViewData = new(this, "SaveViewData", 0);
					r_RSaveViewData.SetBelong(this.instance);
				}
				return r_RSaveViewData;
			}
		}

		/// <summary>
		/// Boolean IsViewDataPersitenceSupportedOnChildren(Boolean)
		/// </summary>
		protected RMethod r_RIsViewDataPersitenceSupportedOnChildren_Boolean;
		public virtual RMethod RIsViewDataPersitenceSupportedOnChildren_Boolean
		{
			get
			{
				if(r_RIsViewDataPersitenceSupportedOnChildren_Boolean == null)
				{
					r_RIsViewDataPersitenceSupportedOnChildren_Boolean = new(this, "IsViewDataPersitenceSupportedOnChildren", 0, typeof(System.Boolean));
					r_RIsViewDataPersitenceSupportedOnChildren_Boolean.SetBelong(this.instance);
				}
				return r_RIsViewDataPersitenceSupportedOnChildren_Boolean;
			}
		}

		/// <summary>
		/// Void OnViewDataReady(Boolean)
		/// </summary>
		protected RMethod r_ROnViewDataReady_Boolean;
		public virtual RMethod ROnViewDataReady_Boolean
		{
			get
			{
				if(r_ROnViewDataReady_Boolean == null)
				{
					r_ROnViewDataReady_Boolean = new(this, "OnViewDataReady", 0, typeof(System.Boolean));
					r_ROnViewDataReady_Boolean.SetBelong(this.instance);
				}
				return r_ROnViewDataReady_Boolean;
			}
		}

		/// <summary>
		/// Void OnViewDataReady()
		/// </summary>
		protected RMethod r_ROnViewDataReady;
		public virtual RMethod ROnViewDataReady
		{
			get
			{
				if(r_ROnViewDataReady == null)
				{
					r_ROnViewDataReady = new(this, "OnViewDataReady", 0);
					r_ROnViewDataReady.SetBelong(this.instance);
				}
				return r_ROnViewDataReady;
			}
		}

		/// <summary>
		/// Boolean ContainsPoint(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RContainsPoint_Vector2;
		public virtual RMethod RContainsPoint_Vector2
		{
			get
			{
				if(r_RContainsPoint_Vector2 == null)
				{
					r_RContainsPoint_Vector2 = new(this, "ContainsPoint", 0, typeof(UnityEngine.Vector2));
					r_RContainsPoint_Vector2.SetBelong(this.instance);
				}
				return r_RContainsPoint_Vector2;
			}
		}

		/// <summary>
		/// Boolean Overlaps(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_ROverlaps_Rect;
		public virtual RMethod ROverlaps_Rect
		{
			get
			{
				if(r_ROverlaps_Rect == null)
				{
					r_ROverlaps_Rect = new(this, "Overlaps", 0, typeof(UnityEngine.Rect));
					r_ROverlaps_Rect.SetBelong(this.instance);
				}
				return r_ROverlaps_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 DoMeasure(Single, MeasureMode, Single, MeasureMode)
		/// </summary>
		protected RMethod r_RDoMeasure_Single_MeasureMode_Single_MeasureMode;
		public virtual RMethod RDoMeasure_Single_MeasureMode_Single_MeasureMode
		{
			get
			{
				if(r_RDoMeasure_Single_MeasureMode_Single_MeasureMode == null)
				{
					r_RDoMeasure_Single_MeasureMode_Single_MeasureMode = new(this, "DoMeasure", 0, typeof(System.Single),  ReleactionUtils.GetType("UnityEngine.UIElements.VisualElement+MeasureMode"), typeof(System.Single),  ReleactionUtils.GetType("UnityEngine.UIElements.VisualElement+MeasureMode"));
					r_RDoMeasure_Single_MeasureMode_Single_MeasureMode.SetBelong(this.instance);
				}
				return r_RDoMeasure_Single_MeasureMode_Single_MeasureMode;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaSize Measure(UnityEngine.Yoga.YogaNode, Single, UnityEngine.Yoga.YogaMeasureMode, Single, UnityEngine.Yoga.YogaMeasureMode)
		/// </summary>
		protected RMethod r_RMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode;
		public virtual RMethod RMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode
		{
			get
			{
				if(r_RMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode == null)
				{
					r_RMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode = new(this, "Measure", 0,  ReleactionUtils.GetType("UnityEngine.Yoga.YogaNode"), typeof(System.Single),  ReleactionUtils.GetType("UnityEngine.Yoga.YogaMeasureMode"), typeof(System.Single),  ReleactionUtils.GetType("UnityEngine.Yoga.YogaMeasureMode"));
					r_RMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode.SetBelong(this.instance);
				}
				return r_RMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode;
			}
		}

		/// <summary>
		/// Void SetSize(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RSetSize_Vector2;
		public virtual RMethod RSetSize_Vector2
		{
			get
			{
				if(r_RSetSize_Vector2 == null)
				{
					r_RSetSize_Vector2 = new(this, "SetSize", 0, typeof(UnityEngine.Vector2));
					r_RSetSize_Vector2.SetBelong(this.instance);
				}
				return r_RSetSize_Vector2;
			}
		}

		/// <summary>
		/// Void SetInlineRule(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleRule)
		/// </summary>
		protected RMethod r_RSetInlineRule_StyleSheet_StyleRule;
		public virtual RMethod RSetInlineRule_StyleSheet_StyleRule
		{
			get
			{
				if(r_RSetInlineRule_StyleSheet_StyleRule == null)
				{
					r_RSetInlineRule_StyleSheet_StyleRule = new(this, "SetInlineRule", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleRule"));
					r_RSetInlineRule_StyleSheet_StyleRule.SetBelong(this.instance);
				}
				return r_RSetInlineRule_StyleSheet_StyleRule;
			}
		}

		/// <summary>
		/// Void UpdateInlineRule(UnityEngine.UIElements.StyleSheet, UnityEngine.UIElements.StyleRule)
		/// </summary>
		protected RMethod r_RUpdateInlineRule_StyleSheet_StyleRule;
		public virtual RMethod RUpdateInlineRule_StyleSheet_StyleRule
		{
			get
			{
				if(r_RUpdateInlineRule_StyleSheet_StyleRule == null)
				{
					r_RUpdateInlineRule_StyleSheet_StyleRule = new(this, "UpdateInlineRule", 0, typeof(UnityEngine.UIElements.StyleSheet),  ReleactionUtils.GetType("UnityEngine.UIElements.StyleRule"));
					r_RUpdateInlineRule_StyleSheet_StyleRule.SetBelong(this.instance);
				}
				return r_RUpdateInlineRule_StyleSheet_StyleRule;
			}
		}

		/// <summary>
		/// Void SetComputedStyle(UnityEngine.UIElements.ComputedStyle ByRef)
		/// </summary>
		protected RMethod r_RSetComputedStyle_Ref_ComputedStyle;
		public virtual RMethod RSetComputedStyle_Ref_ComputedStyle
		{
			get
			{
				if(r_RSetComputedStyle_Ref_ComputedStyle == null)
				{
					r_RSetComputedStyle_Ref_ComputedStyle = new(this, "SetComputedStyle", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.ComputedStyle").MakeByRefType());
					r_RSetComputedStyle_Ref_ComputedStyle.SetBelong(this.instance);
				}
				return r_RSetComputedStyle_Ref_ComputedStyle;
			}
		}

		/// <summary>
		/// Void ResetPositionProperties()
		/// </summary>
		protected RMethod r_RResetPositionProperties;
		public virtual RMethod RResetPositionProperties
		{
			get
			{
				if(r_RResetPositionProperties == null)
				{
					r_RResetPositionProperties = new(this, "ResetPositionProperties", 0);
					r_RResetPositionProperties.SetBelong(this.instance);
				}
				return r_RResetPositionProperties;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[System.String] GetClasses()
		/// </summary>
		protected RMethod r_RGetClasses;
		public virtual RMethod RGetClasses
		{
			get
			{
				if(r_RGetClasses == null)
				{
					r_RGetClasses = new(this, "GetClasses", 0);
					r_RGetClasses.SetBelong(this.instance);
				}
				return r_RGetClasses;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] GetClassesForIteration()
		/// </summary>
		protected RMethod r_RGetClassesForIteration;
		public virtual RMethod RGetClassesForIteration
		{
			get
			{
				if(r_RGetClassesForIteration == null)
				{
					r_RGetClassesForIteration = new(this, "GetClassesForIteration", 0);
					r_RGetClassesForIteration.SetBelong(this.instance);
				}
				return r_RGetClassesForIteration;
			}
		}

		/// <summary>
		/// Void ClearClassList()
		/// </summary>
		protected RMethod r_RClearClassList;
		public virtual RMethod RClearClassList
		{
			get
			{
				if(r_RClearClassList == null)
				{
					r_RClearClassList = new(this, "ClearClassList", 0);
					r_RClearClassList.SetBelong(this.instance);
				}
				return r_RClearClassList;
			}
		}

		/// <summary>
		/// Void AddToClassList(System.String)
		/// </summary>
		protected RMethod r_RAddToClassList_String;
		public virtual RMethod RAddToClassList_String
		{
			get
			{
				if(r_RAddToClassList_String == null)
				{
					r_RAddToClassList_String = new(this, "AddToClassList", 0, typeof(System.String));
					r_RAddToClassList_String.SetBelong(this.instance);
				}
				return r_RAddToClassList_String;
			}
		}

		/// <summary>
		/// Void RemoveFromClassList(System.String)
		/// </summary>
		protected RMethod r_RRemoveFromClassList_String;
		public virtual RMethod RRemoveFromClassList_String
		{
			get
			{
				if(r_RRemoveFromClassList_String == null)
				{
					r_RRemoveFromClassList_String = new(this, "RemoveFromClassList", 0, typeof(System.String));
					r_RRemoveFromClassList_String.SetBelong(this.instance);
				}
				return r_RRemoveFromClassList_String;
			}
		}

		/// <summary>
		/// Void ToggleInClassList(System.String)
		/// </summary>
		protected RMethod r_RToggleInClassList_String;
		public virtual RMethod RToggleInClassList_String
		{
			get
			{
				if(r_RToggleInClassList_String == null)
				{
					r_RToggleInClassList_String = new(this, "ToggleInClassList", 0, typeof(System.String));
					r_RToggleInClassList_String.SetBelong(this.instance);
				}
				return r_RToggleInClassList_String;
			}
		}

		/// <summary>
		/// Void EnableInClassList(System.String, Boolean)
		/// </summary>
		protected RMethod r_REnableInClassList_String_Boolean;
		public virtual RMethod REnableInClassList_String_Boolean
		{
			get
			{
				if(r_REnableInClassList_String_Boolean == null)
				{
					r_REnableInClassList_String_Boolean = new(this, "EnableInClassList", 0, typeof(System.String), typeof(System.Boolean));
					r_REnableInClassList_String_Boolean.SetBelong(this.instance);
				}
				return r_REnableInClassList_String_Boolean;
			}
		}

		/// <summary>
		/// Boolean ClassListContains(System.String)
		/// </summary>
		protected RMethod r_RClassListContains_String;
		public virtual RMethod RClassListContains_String
		{
			get
			{
				if(r_RClassListContains_String == null)
				{
					r_RClassListContains_String = new(this, "ClassListContains", 0, typeof(System.String));
					r_RClassListContains_String.SetBelong(this.instance);
				}
				return r_RClassListContains_String;
			}
		}

		/// <summary>
		/// System.Object FindAncestorUserData()
		/// </summary>
		protected RMethod r_RFindAncestorUserData;
		public virtual RMethod RFindAncestorUserData
		{
			get
			{
				if(r_RFindAncestorUserData == null)
				{
					r_RFindAncestorUserData = new(this, "FindAncestorUserData", 0);
					r_RFindAncestorUserData.SetBelong(this.instance);
				}
				return r_RFindAncestorUserData;
			}
		}

		/// <summary>
		/// System.Object GetProperty(UnityEngine.PropertyName)
		/// </summary>
		protected RMethod r_RGetProperty_PropertyName;
		public virtual RMethod RGetProperty_PropertyName
		{
			get
			{
				if(r_RGetProperty_PropertyName == null)
				{
					r_RGetProperty_PropertyName = new(this, "GetProperty", 0, typeof(UnityEngine.PropertyName));
					r_RGetProperty_PropertyName.SetBelong(this.instance);
				}
				return r_RGetProperty_PropertyName;
			}
		}

		/// <summary>
		/// Void SetProperty(UnityEngine.PropertyName, System.Object)
		/// </summary>
		protected RMethod r_RSetProperty_PropertyName_Object;
		public virtual RMethod RSetProperty_PropertyName_Object
		{
			get
			{
				if(r_RSetProperty_PropertyName_Object == null)
				{
					r_RSetProperty_PropertyName_Object = new(this, "SetProperty", 0, typeof(UnityEngine.PropertyName), typeof(System.Object));
					r_RSetProperty_PropertyName_Object.SetBelong(this.instance);
				}
				return r_RSetProperty_PropertyName_Object;
			}
		}

		/// <summary>
		/// Boolean HasProperty(UnityEngine.PropertyName)
		/// </summary>
		protected RMethod r_RHasProperty_PropertyName;
		public virtual RMethod RHasProperty_PropertyName
		{
			get
			{
				if(r_RHasProperty_PropertyName == null)
				{
					r_RHasProperty_PropertyName = new(this, "HasProperty", 0, typeof(UnityEngine.PropertyName));
					r_RHasProperty_PropertyName.SetBelong(this.instance);
				}
				return r_RHasProperty_PropertyName;
			}
		}

		/// <summary>
		/// Void ApplyPlayerRenderingToEditorElement()
		/// </summary>
		protected RMethod r_RApplyPlayerRenderingToEditorElement;
		public virtual RMethod RApplyPlayerRenderingToEditorElement
		{
			get
			{
				if(r_RApplyPlayerRenderingToEditorElement == null)
				{
					r_RApplyPlayerRenderingToEditorElement = new(this, "ApplyPlayerRenderingToEditorElement", 0);
					r_RApplyPlayerRenderingToEditorElement.SetBelong(this.instance);
				}
				return r_RApplyPlayerRenderingToEditorElement;
			}
		}

		/// <summary>
		/// Void RegisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate)
		/// </summary>
		protected RMethod r_RRegisterAnimation_IValueAnimationUpdate;
		public virtual RMethod RRegisterAnimation_IValueAnimationUpdate
		{
			get
			{
				if(r_RRegisterAnimation_IValueAnimationUpdate == null)
				{
					r_RRegisterAnimation_IValueAnimationUpdate = new(this, "RegisterAnimation", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.Experimental.IValueAnimationUpdate"));
					r_RRegisterAnimation_IValueAnimationUpdate.SetBelong(this.instance);
				}
				return r_RRegisterAnimation_IValueAnimationUpdate;
			}
		}

		/// <summary>
		/// Void UnregisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate)
		/// </summary>
		protected RMethod r_RUnregisterAnimation_IValueAnimationUpdate;
		public virtual RMethod RUnregisterAnimation_IValueAnimationUpdate
		{
			get
			{
				if(r_RUnregisterAnimation_IValueAnimationUpdate == null)
				{
					r_RUnregisterAnimation_IValueAnimationUpdate = new(this, "UnregisterAnimation", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.Experimental.IValueAnimationUpdate"));
					r_RUnregisterAnimation_IValueAnimationUpdate.SetBelong(this.instance);
				}
				return r_RUnregisterAnimation_IValueAnimationUpdate;
			}
		}

		/// <summary>
		/// Boolean GetCachedNextParentWithEventCallback(UnityEngine.UIElements.VisualElement ByRef)
		/// </summary>
		protected RMethod r_RGetCachedNextParentWithEventCallback_Out_VisualElement;
		public virtual RMethod RGetCachedNextParentWithEventCallback_Out_VisualElement
		{
			get
			{
				if(r_RGetCachedNextParentWithEventCallback_Out_VisualElement == null)
				{
					r_RGetCachedNextParentWithEventCallback_Out_VisualElement = new(this, "GetCachedNextParentWithEventCallback", 0, typeof(UnityEngine.UIElements.VisualElement).MakeByRefType());
					r_RGetCachedNextParentWithEventCallback_Out_VisualElement.SetBelong(this.instance);
				}
				return r_RGetCachedNextParentWithEventCallback_Out_VisualElement;
			}
		}

		/// <summary>
		/// Boolean HasEventCallbacks(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_RHasEventCallbacks_EventCategory;
		public virtual RMethod RHasEventCallbacks_EventCategory
		{
			get
			{
				if(r_RHasEventCallbacks_EventCategory == null)
				{
					r_RHasEventCallbacks_EventCategory = new(this, "HasEventCallbacks", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_RHasEventCallbacks_EventCategory.SetBelong(this.instance);
				}
				return r_RHasEventCallbacks_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasParentEventCallbacks(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_RHasParentEventCallbacks_EventCategory;
		public virtual RMethod RHasParentEventCallbacks_EventCategory
		{
			get
			{
				if(r_RHasParentEventCallbacks_EventCategory == null)
				{
					r_RHasParentEventCallbacks_EventCategory = new(this, "HasParentEventCallbacks", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_RHasParentEventCallbacks_EventCategory.SetBelong(this.instance);
				}
				return r_RHasParentEventCallbacks_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasParentEventCallbacksOrDefaultActions(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_RHasParentEventCallbacksOrDefaultActions_EventCategory;
		public virtual RMethod RHasParentEventCallbacksOrDefaultActions_EventCategory
		{
			get
			{
				if(r_RHasParentEventCallbacksOrDefaultActions_EventCategory == null)
				{
					r_RHasParentEventCallbacksOrDefaultActions_EventCategory = new(this, "HasParentEventCallbacksOrDefaultActions", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_RHasParentEventCallbacksOrDefaultActions_EventCategory.SetBelong(this.instance);
				}
				return r_RHasParentEventCallbacksOrDefaultActions_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasEventCallbacksOrDefaultActions(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_RHasEventCallbacksOrDefaultActions_EventCategory;
		public virtual RMethod RHasEventCallbacksOrDefaultActions_EventCategory
		{
			get
			{
				if(r_RHasEventCallbacksOrDefaultActions_EventCategory == null)
				{
					r_RHasEventCallbacksOrDefaultActions_EventCategory = new(this, "HasEventCallbacksOrDefaultActions", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_RHasEventCallbacksOrDefaultActions_EventCategory.SetBelong(this.instance);
				}
				return r_RHasEventCallbacksOrDefaultActions_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasParentEventCallbacksOrDefaultActionAtTarget(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_RHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory;
		public virtual RMethod RHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory
		{
			get
			{
				if(r_RHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory == null)
				{
					r_RHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory = new(this, "HasParentEventCallbacksOrDefaultActionAtTarget", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_RHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory.SetBelong(this.instance);
				}
				return r_RHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasEventCallbacksOrDefaultActionAtTarget(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_RHasEventCallbacksOrDefaultActionAtTarget_EventCategory;
		public virtual RMethod RHasEventCallbacksOrDefaultActionAtTarget_EventCategory
		{
			get
			{
				if(r_RHasEventCallbacksOrDefaultActionAtTarget_EventCategory == null)
				{
					r_RHasEventCallbacksOrDefaultActionAtTarget_EventCategory = new(this, "HasEventCallbacksOrDefaultActionAtTarget", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_RHasEventCallbacksOrDefaultActionAtTarget_EventCategory.SetBelong(this.instance);
				}
				return r_RHasEventCallbacksOrDefaultActionAtTarget_EventCategory;
			}
		}

		/// <summary>
		/// Boolean HasDefaultAction(UnityEngine.UIElements.EventCategory)
		/// </summary>
		protected RMethod r_RHasDefaultAction_EventCategory;
		public virtual RMethod RHasDefaultAction_EventCategory
		{
			get
			{
				if(r_RHasDefaultAction_EventCategory == null)
				{
					r_RHasDefaultAction_EventCategory = new(this, "HasDefaultAction", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.EventCategory"));
					r_RHasDefaultAction_EventCategory.SetBelong(this.instance);
				}
				return r_RHasDefaultAction_EventCategory;
			}
		}

		/// <summary>
		/// Boolean ShouldClip()
		/// </summary>
		protected RMethod r_RShouldClip;
		public virtual RMethod RShouldClip
		{
			get
			{
				if(r_RShouldClip == null)
				{
					r_RShouldClip = new(this, "ShouldClip", 0);
					r_RShouldClip.SetBelong(this.instance);
				}
				return r_RShouldClip;
			}
		}

		/// <summary>
		/// Void Add(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RAdd_VisualElement;
		public virtual RMethod RAdd_VisualElement
		{
			get
			{
				if(r_RAdd_VisualElement == null)
				{
					r_RAdd_VisualElement = new(this, "Add", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RAdd_VisualElement.SetBelong(this.instance);
				}
				return r_RAdd_VisualElement;
			}
		}

		/// <summary>
		/// Void Insert(Int32, UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RInsert_Int32_VisualElement;
		public virtual RMethod RInsert_Int32_VisualElement
		{
			get
			{
				if(r_RInsert_Int32_VisualElement == null)
				{
					r_RInsert_Int32_VisualElement = new(this, "Insert", 0, typeof(System.Int32), typeof(UnityEngine.UIElements.VisualElement));
					r_RInsert_Int32_VisualElement.SetBelong(this.instance);
				}
				return r_RInsert_Int32_VisualElement;
			}
		}

		/// <summary>
		/// Void Remove(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RRemove_VisualElement;
		public virtual RMethod RRemove_VisualElement
		{
			get
			{
				if(r_RRemove_VisualElement == null)
				{
					r_RRemove_VisualElement = new(this, "Remove", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RRemove_VisualElement.SetBelong(this.instance);
				}
				return r_RRemove_VisualElement;
			}
		}

		/// <summary>
		/// Void RemoveAt(Int32)
		/// </summary>
		protected RMethod r_RRemoveAt_Int32;
		public virtual RMethod RRemoveAt_Int32
		{
			get
			{
				if(r_RRemoveAt_Int32 == null)
				{
					r_RRemoveAt_Int32 = new(this, "RemoveAt", 0, typeof(System.Int32));
					r_RRemoveAt_Int32.SetBelong(this.instance);
				}
				return r_RRemoveAt_Int32;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement ElementAt(Int32)
		/// </summary>
		protected RMethod r_RElementAt_Int32;
		public virtual RMethod RElementAt_Int32
		{
			get
			{
				if(r_RElementAt_Int32 == null)
				{
					r_RElementAt_Int32 = new(this, "ElementAt", 0, typeof(System.Int32));
					r_RElementAt_Int32.SetBelong(this.instance);
				}
				return r_RElementAt_Int32;
			}
		}

		/// <summary>
		/// Int32 IndexOf(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RIndexOf_VisualElement;
		public virtual RMethod RIndexOf_VisualElement
		{
			get
			{
				if(r_RIndexOf_VisualElement == null)
				{
					r_RIndexOf_VisualElement = new(this, "IndexOf", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RIndexOf_VisualElement.SetBelong(this.instance);
				}
				return r_RIndexOf_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement ElementAtTreePath(System.Collections.Generic.List`1[System.Int32])
		/// </summary>
		protected RMethod r_RElementAtTreePath_List_d_Int32_p_;
		public virtual RMethod RElementAtTreePath_List_d_Int32_p_
		{
			get
			{
				if(r_RElementAtTreePath_List_d_Int32_p_ == null)
				{
					r_RElementAtTreePath_List_d_Int32_p_ = new(this, "ElementAtTreePath", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)));
					r_RElementAtTreePath_List_d_Int32_p_.SetBelong(this.instance);
				}
				return r_RElementAtTreePath_List_d_Int32_p_;
			}
		}

		/// <summary>
		/// Boolean FindElementInTree(UnityEngine.UIElements.VisualElement, System.Collections.Generic.List`1[System.Int32])
		/// </summary>
		protected RMethod r_RFindElementInTree_VisualElement_List_d_Int32_p_;
		public virtual RMethod RFindElementInTree_VisualElement_List_d_Int32_p_
		{
			get
			{
				if(r_RFindElementInTree_VisualElement_List_d_Int32_p_ == null)
				{
					r_RFindElementInTree_VisualElement_List_d_Int32_p_ = new(this, "FindElementInTree", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Int32)));
					r_RFindElementInTree_VisualElement_List_d_Int32_p_.SetBelong(this.instance);
				}
				return r_RFindElementInTree_VisualElement_List_d_Int32_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.VisualElement] Children()
		/// </summary>
		protected RMethod r_RChildren;
		public virtual RMethod RChildren
		{
			get
			{
				if(r_RChildren == null)
				{
					r_RChildren = new(this, "Children", 0);
					r_RChildren.SetBelong(this.instance);
				}
				return r_RChildren;
			}
		}

		/// <summary>
		/// Void Sort(System.Comparison`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_RSort_Comparison_d_VisualElement_p_;
		public virtual RMethod RSort_Comparison_d_VisualElement_p_
		{
			get
			{
				if(r_RSort_Comparison_d_VisualElement_p_ == null)
				{
					r_RSort_Comparison_d_VisualElement_p_ = new(this, "Sort", 0, typeof(System.Comparison<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
					r_RSort_Comparison_d_VisualElement_p_.SetBelong(this.instance);
				}
				return r_RSort_Comparison_d_VisualElement_p_;
			}
		}

		/// <summary>
		/// Void BringToFront()
		/// </summary>
		protected RMethod r_RBringToFront;
		public virtual RMethod RBringToFront
		{
			get
			{
				if(r_RBringToFront == null)
				{
					r_RBringToFront = new(this, "BringToFront", 0);
					r_RBringToFront.SetBelong(this.instance);
				}
				return r_RBringToFront;
			}
		}

		/// <summary>
		/// Void SendToBack()
		/// </summary>
		protected RMethod r_RSendToBack;
		public virtual RMethod RSendToBack
		{
			get
			{
				if(r_RSendToBack == null)
				{
					r_RSendToBack = new(this, "SendToBack", 0);
					r_RSendToBack.SetBelong(this.instance);
				}
				return r_RSendToBack;
			}
		}

		/// <summary>
		/// Void PlaceBehind(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RPlaceBehind_VisualElement;
		public virtual RMethod RPlaceBehind_VisualElement
		{
			get
			{
				if(r_RPlaceBehind_VisualElement == null)
				{
					r_RPlaceBehind_VisualElement = new(this, "PlaceBehind", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RPlaceBehind_VisualElement.SetBelong(this.instance);
				}
				return r_RPlaceBehind_VisualElement;
			}
		}

		/// <summary>
		/// Void PlaceInFront(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RPlaceInFront_VisualElement;
		public virtual RMethod RPlaceInFront_VisualElement
		{
			get
			{
				if(r_RPlaceInFront_VisualElement == null)
				{
					r_RPlaceInFront_VisualElement = new(this, "PlaceInFront", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RPlaceInFront_VisualElement.SetBelong(this.instance);
				}
				return r_RPlaceInFront_VisualElement;
			}
		}

		/// <summary>
		/// Void RemoveFromHierarchy()
		/// </summary>
		protected RMethod r_RRemoveFromHierarchy;
		public virtual RMethod RRemoveFromHierarchy
		{
			get
			{
				if(r_RRemoveFromHierarchy == null)
				{
					r_RRemoveFromHierarchy = new(this, "RemoveFromHierarchy", 0);
					r_RRemoveFromHierarchy.SetBelong(this.instance);
				}
				return r_RRemoveFromHierarchy;
			}
		}

		/// <summary>
		/// T GetFirstOfType[T]()
		/// </summary>
		protected RMethod r_RGetFirstOfType_GT;
		public virtual RMethod RGetFirstOfType_GT
		{
			get
			{
				if(r_RGetFirstOfType_GT == null)
				{
					r_RGetFirstOfType_GT = new(this, "GetFirstOfType", 1);
					r_RGetFirstOfType_GT.SetBelong(this.instance);
				}
				return r_RGetFirstOfType_GT;
			}
		}

		/// <summary>
		/// T GetFirstAncestorOfType[T]()
		/// </summary>
		protected RMethod r_RGetFirstAncestorOfType_GT;
		public virtual RMethod RGetFirstAncestorOfType_GT
		{
			get
			{
				if(r_RGetFirstAncestorOfType_GT == null)
				{
					r_RGetFirstAncestorOfType_GT = new(this, "GetFirstAncestorOfType", 1);
					r_RGetFirstAncestorOfType_GT.SetBelong(this.instance);
				}
				return r_RGetFirstAncestorOfType_GT;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetFirstAncestorWhere(System.Predicate`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_RGetFirstAncestorWhere_Predicate_d_VisualElement_p_;
		public virtual RMethod RGetFirstAncestorWhere_Predicate_d_VisualElement_p_
		{
			get
			{
				if(r_RGetFirstAncestorWhere_Predicate_d_VisualElement_p_ == null)
				{
					r_RGetFirstAncestorWhere_Predicate_d_VisualElement_p_ = new(this, "GetFirstAncestorWhere", 0, typeof(System.Predicate<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
					r_RGetFirstAncestorWhere_Predicate_d_VisualElement_p_.SetBelong(this.instance);
				}
				return r_RGetFirstAncestorWhere_Predicate_d_VisualElement_p_;
			}
		}

		/// <summary>
		/// Boolean Contains(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RContains_VisualElement;
		public virtual RMethod RContains_VisualElement
		{
			get
			{
				if(r_RContains_VisualElement == null)
				{
					r_RContains_VisualElement = new(this, "Contains", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RContains_VisualElement.SetBelong(this.instance);
				}
				return r_RContains_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement FindCommonAncestor(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RFindCommonAncestor_VisualElement;
		public virtual RMethod RFindCommonAncestor_VisualElement
		{
			get
			{
				if(r_RFindCommonAncestor_VisualElement == null)
				{
					r_RFindCommonAncestor_VisualElement = new(this, "FindCommonAncestor", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RFindCommonAncestor_VisualElement.SetBelong(this.instance);
				}
				return r_RFindCommonAncestor_VisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetRoot()
		/// </summary>
		protected RMethod r_RGetRoot;
		public virtual RMethod RGetRoot
		{
			get
			{
				if(r_RGetRoot == null)
				{
					r_RGetRoot = new(this, "GetRoot", 0);
					r_RGetRoot.SetBelong(this.instance);
				}
				return r_RGetRoot;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetRootVisualContainer()
		/// </summary>
		protected RMethod r_RGetRootVisualContainer;
		public virtual RMethod RGetRootVisualContainer
		{
			get
			{
				if(r_RGetRootVisualContainer == null)
				{
					r_RGetRootVisualContainer = new(this, "GetRootVisualContainer", 0);
					r_RGetRootVisualContainer.SetBelong(this.instance);
				}
				return r_RGetRootVisualContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetNextElementDepthFirst()
		/// </summary>
		protected RMethod r_RGetNextElementDepthFirst;
		public virtual RMethod RGetNextElementDepthFirst
		{
			get
			{
				if(r_RGetNextElementDepthFirst == null)
				{
					r_RGetNextElementDepthFirst = new(this, "GetNextElementDepthFirst", 0);
					r_RGetNextElementDepthFirst.SetBelong(this.instance);
				}
				return r_RGetNextElementDepthFirst;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement GetPreviousElementDepthFirst()
		/// </summary>
		protected RMethod r_RGetPreviousElementDepthFirst;
		public virtual RMethod RGetPreviousElementDepthFirst
		{
			get
			{
				if(r_RGetPreviousElementDepthFirst == null)
				{
					r_RGetPreviousElementDepthFirst = new(this, "GetPreviousElementDepthFirst", 0);
					r_RGetPreviousElementDepthFirst.SetBelong(this.instance);
				}
				return r_RGetPreviousElementDepthFirst;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement RetargetElement(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RRetargetElement_VisualElement;
		public virtual RMethod RRetargetElement_VisualElement
		{
			get
			{
				if(r_RRetargetElement_VisualElement == null)
				{
					r_RRetargetElement_VisualElement = new(this, "RetargetElement", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RRetargetElement_VisualElement.SetBelong(this.instance);
				}
				return r_RRetargetElement_VisualElement;
			}
		}

		/// <summary>
		/// Void GetPivotedMatrixWithLayout(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_RGetPivotedMatrixWithLayout_Out_Matrix4x4;
		public virtual RMethod RGetPivotedMatrixWithLayout_Out_Matrix4x4
		{
			get
			{
				if(r_RGetPivotedMatrixWithLayout_Out_Matrix4x4 == null)
				{
					r_RGetPivotedMatrixWithLayout_Out_Matrix4x4 = new(this, "GetPivotedMatrixWithLayout", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_RGetPivotedMatrixWithLayout_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_RGetPivotedMatrixWithLayout_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void AddStyleSheetPath(System.String)
		/// </summary>
		protected RMethod r_RAddStyleSheetPath_String;
		public virtual RMethod RAddStyleSheetPath_String
		{
			get
			{
				if(r_RAddStyleSheetPath_String == null)
				{
					r_RAddStyleSheetPath_String = new(this, "AddStyleSheetPath", 0, typeof(System.String));
					r_RAddStyleSheetPath_String.SetBelong(this.instance);
				}
				return r_RAddStyleSheetPath_String;
			}
		}

		/// <summary>
		/// Boolean HasStyleSheetPath(System.String)
		/// </summary>
		protected RMethod r_RHasStyleSheetPath_String;
		public virtual RMethod RHasStyleSheetPath_String
		{
			get
			{
				if(r_RHasStyleSheetPath_String == null)
				{
					r_RHasStyleSheetPath_String = new(this, "HasStyleSheetPath", 0, typeof(System.String));
					r_RHasStyleSheetPath_String.SetBelong(this.instance);
				}
				return r_RHasStyleSheetPath_String;
			}
		}

		/// <summary>
		/// Void RemoveStyleSheetPath(System.String)
		/// </summary>
		protected RMethod r_RRemoveStyleSheetPath_String;
		public virtual RMethod RRemoveStyleSheetPath_String
		{
			get
			{
				if(r_RRemoveStyleSheetPath_String == null)
				{
					r_RRemoveStyleSheetPath_String = new(this, "RemoveStyleSheetPath", 0, typeof(System.String));
					r_RRemoveStyleSheetPath_String.SetBelong(this.instance);
				}
				return r_RRemoveStyleSheetPath_String;
			}
		}

		/// <summary>
		/// Void Blur()
		/// </summary>
		protected RMethod r_RBlur;
		public virtual RMethod RBlur
		{
			get
			{
				if(r_RBlur == null)
				{
					r_RBlur = new(this, "Blur", 0);
					r_RBlur.SetBelong(this.instance);
				}
				return r_RBlur;
			}
		}

		/// <summary>
		/// Void BlurImmediately()
		/// </summary>
		protected RMethod r_RBlurImmediately;
		public virtual RMethod RBlurImmediately
		{
			get
			{
				if(r_RBlurImmediately == null)
				{
					r_RBlurImmediately = new(this, "BlurImmediately", 0);
					r_RBlurImmediately.SetBelong(this.instance);
				}
				return r_RBlurImmediately;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultActionDisabled(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RExecuteDefaultActionDisabled_EventBase;
		public virtual RMethod RExecuteDefaultActionDisabled_EventBase
		{
			get
			{
				if(r_RExecuteDefaultActionDisabled_EventBase == null)
				{
					r_RExecuteDefaultActionDisabled_EventBase = new(this, "ExecuteDefaultActionDisabled", 0, typeof(UnityEngine.UIElements.EventBase));
					r_RExecuteDefaultActionDisabled_EventBase.SetBelong(this.instance);
				}
				return r_RExecuteDefaultActionDisabled_EventBase;
			}
		}

		/// <summary>
		/// Void RegisterCallback[TEventType](UnityEngine.UIElements.EventCallback`1[TEventType], UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_RRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
		public virtual RMethod RRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown
		{
			get
			{
				if(r_RRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown == null)
				{
					r_RRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown = new(this, "RegisterCallback", 1, typeof(UnityEngine.UIElements.EventCallback<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(UnityEngine.UIElements.TrickleDown));
					r_RRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown.SetBelong(this.instance);
				}
				return r_RRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
			}
		}

		/// <summary>
		/// Void RegisterCallback[TEventType,TUserArgsType](UnityEngine.UIElements.EventCallback`2[TEventType,TUserArgsType], TUserArgsType, UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_RRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown;
		public virtual RMethod RRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown
		{
			get
			{
				if(r_RRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown == null)
				{
					r_RRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown = new(this, "RegisterCallback", 2, typeof(UnityEngine.UIElements.EventCallback<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), Type.MakeGenericMethodParameter(1), typeof(UnityEngine.UIElements.TrickleDown));
					r_RRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown.SetBelong(this.instance);
				}
				return r_RRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown;
			}
		}

		/// <summary>
		/// Void RegisterCallback[TEventType](UnityEngine.UIElements.EventCallback`1[TEventType], UnityEngine.UIElements.InvokePolicy, UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_RRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown;
		public virtual RMethod RRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown
		{
			get
			{
				if(r_RRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown == null)
				{
					r_RRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown = new(this, "RegisterCallback", 1, typeof(UnityEngine.UIElements.EventCallback<>).MakeGenericType(Type.MakeGenericMethodParameter(0)),  ReleactionUtils.GetType("UnityEngine.UIElements.InvokePolicy"), typeof(UnityEngine.UIElements.TrickleDown));
					r_RRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown.SetBelong(this.instance);
				}
				return r_RRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown;
			}
		}

		/// <summary>
		/// Void UnregisterCallback[TEventType](UnityEngine.UIElements.EventCallback`1[TEventType], UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_RUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
		public virtual RMethod RUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown
		{
			get
			{
				if(r_RUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown == null)
				{
					r_RUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown = new(this, "UnregisterCallback", 1, typeof(UnityEngine.UIElements.EventCallback<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(UnityEngine.UIElements.TrickleDown));
					r_RUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown.SetBelong(this.instance);
				}
				return r_RUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown;
			}
		}

		/// <summary>
		/// Void UnregisterCallback[TEventType,TUserArgsType](UnityEngine.UIElements.EventCallback`2[TEventType,TUserArgsType], UnityEngine.UIElements.TrickleDown)
		/// </summary>
		protected RMethod r_RUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown;
		public virtual RMethod RUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown
		{
			get
			{
				if(r_RUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown == null)
				{
					r_RUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown = new(this, "UnregisterCallback", 2, typeof(UnityEngine.UIElements.EventCallback<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), typeof(UnityEngine.UIElements.TrickleDown));
					r_RUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown.SetBelong(this.instance);
				}
				return r_RUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown;
			}
		}

		/// <summary>
		/// Boolean TryGetUserArgs[TEventType,TCallbackArgs](UnityEngine.UIElements.EventCallback`2[TEventType,TCallbackArgs], UnityEngine.UIElements.TrickleDown, TCallbackArgs ByRef)
		/// </summary>
		protected RMethod r_RTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs;
		public virtual RMethod RTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs
		{
			get
			{
				if(r_RTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs == null)
				{
					r_RTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs = new(this, "TryGetUserArgs", 2, typeof(UnityEngine.UIElements.EventCallback<, >).MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), typeof(UnityEngine.UIElements.TrickleDown), Type.MakeGenericMethodParameter(1).MakeByRefType());
					r_RTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs.SetBelong(this.instance);
				}
				return r_RTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs;
			}
		}

		/// <summary>
		/// Void HandleEventAtTargetPhase(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RHandleEventAtTargetPhase_EventBase;
		public virtual RMethod RHandleEventAtTargetPhase_EventBase
		{
			get
			{
				if(r_RHandleEventAtTargetPhase_EventBase == null)
				{
					r_RHandleEventAtTargetPhase_EventBase = new(this, "HandleEventAtTargetPhase", 0, typeof(UnityEngine.UIElements.EventBase));
					r_RHandleEventAtTargetPhase_EventBase.SetBelong(this.instance);
				}
				return r_RHandleEventAtTargetPhase_EventBase;
			}
		}

		/// <summary>
		/// Void HandleEventAtTargetAndDefaultPhase(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RHandleEventAtTargetAndDefaultPhase_EventBase;
		public virtual RMethod RHandleEventAtTargetAndDefaultPhase_EventBase
		{
			get
			{
				if(r_RHandleEventAtTargetAndDefaultPhase_EventBase == null)
				{
					r_RHandleEventAtTargetAndDefaultPhase_EventBase = new(this, "HandleEventAtTargetAndDefaultPhase", 0, typeof(UnityEngine.UIElements.EventBase));
					r_RHandleEventAtTargetAndDefaultPhase_EventBase.SetBelong(this.instance);
				}
				return r_RHandleEventAtTargetAndDefaultPhase_EventBase;
			}
		}

		/// <summary>
		/// Void HandleEventAtCurrentTargetAndPhase(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RHandleEventAtCurrentTargetAndPhase_EventBase;
		public virtual RMethod RHandleEventAtCurrentTargetAndPhase_EventBase
		{
			get
			{
				if(r_RHandleEventAtCurrentTargetAndPhase_EventBase == null)
				{
					r_RHandleEventAtCurrentTargetAndPhase_EventBase = new(this, "HandleEventAtCurrentTargetAndPhase", 0, typeof(UnityEngine.UIElements.EventBase));
					r_RHandleEventAtCurrentTargetAndPhase_EventBase.SetBelong(this.instance);
				}
				return r_RHandleEventAtCurrentTargetAndPhase_EventBase;
			}
		}

		/// <summary>
		/// Void HandleEventEditorInternal(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RHandleEventEditorInternal_EventBase;
		public virtual RMethod RHandleEventEditorInternal_EventBase
		{
			get
			{
				if(r_RHandleEventEditorInternal_EventBase == null)
				{
					r_RHandleEventEditorInternal_EventBase = new(this, "HandleEventEditorInternal", 0, typeof(UnityEngine.UIElements.EventBase));
					r_RHandleEventEditorInternal_EventBase.SetBelong(this.instance);
				}
				return r_RHandleEventEditorInternal_EventBase;
			}
		}

		/// <summary>
		/// Void HandleEvent(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RHandleEvent_EventBase;
		public virtual RMethod RHandleEvent_EventBase
		{
			get
			{
				if(r_RHandleEvent_EventBase == null)
				{
					r_RHandleEvent_EventBase = new(this, "HandleEvent", 0, typeof(UnityEngine.UIElements.EventBase));
					r_RHandleEvent_EventBase.SetBelong(this.instance);
				}
				return r_RHandleEvent_EventBase;
			}
		}

		/// <summary>
		/// Boolean HasTrickleDownHandlers()
		/// </summary>
		protected RMethod r_RHasTrickleDownHandlers;
		public virtual RMethod RHasTrickleDownHandlers
		{
			get
			{
				if(r_RHasTrickleDownHandlers == null)
				{
					r_RHasTrickleDownHandlers = new(this, "HasTrickleDownHandlers", 0);
					r_RHasTrickleDownHandlers.SetBelong(this.instance);
				}
				return r_RHasTrickleDownHandlers;
			}
		}

		/// <summary>
		/// Boolean HasBubbleUpHandlers()
		/// </summary>
		protected RMethod r_RHasBubbleUpHandlers;
		public virtual RMethod RHasBubbleUpHandlers
		{
			get
			{
				if(r_RHasBubbleUpHandlers == null)
				{
					r_RHasBubbleUpHandlers = new(this, "HasBubbleUpHandlers", 0);
					r_RHasBubbleUpHandlers.SetBelong(this.instance);
				}
				return r_RHasBubbleUpHandlers;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RExecuteDefaultActionAtTarget_EventBase;
		public virtual RMethod RExecuteDefaultActionAtTarget_EventBase
		{
			get
			{
				if(r_RExecuteDefaultActionAtTarget_EventBase == null)
				{
					r_RExecuteDefaultActionAtTarget_EventBase = new(this, "ExecuteDefaultActionAtTarget", 0, typeof(UnityEngine.UIElements.EventBase));
					r_RExecuteDefaultActionAtTarget_EventBase.SetBelong(this.instance);
				}
				return r_RExecuteDefaultActionAtTarget_EventBase;
			}
		}

		/// <summary>
		/// Void ExecuteDefaultActionDisabledAtTarget(UnityEngine.UIElements.EventBase)
		/// </summary>
		protected RMethod r_RExecuteDefaultActionDisabledAtTarget_EventBase;
		public virtual RMethod RExecuteDefaultActionDisabledAtTarget_EventBase
		{
			get
			{
				if(r_RExecuteDefaultActionDisabledAtTarget_EventBase == null)
				{
					r_RExecuteDefaultActionDisabledAtTarget_EventBase = new(this, "ExecuteDefaultActionDisabledAtTarget", 0, typeof(UnityEngine.UIElements.EventBase));
					r_RExecuteDefaultActionDisabledAtTarget_EventBase.SetBelong(this.instance);
				}
				return r_RExecuteDefaultActionDisabledAtTarget_EventBase;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}


        public ROverlayPopup() : base("UnityEditor.Overlays.OverlayPopup")
        {
        }

        public ROverlayPopup(System.Object instance) : base("UnityEditor.Overlays.OverlayPopup")
		{
            SetInstance(instance);
		}

        public ROverlayPopup(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public ROverlayPopup(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


        public virtual System.Boolean TryConvertTransformOriginUnits(ref UnityEngine.UIElements.TransformOrigin  @from, ref UnityEngine.UIElements.TransformOrigin  @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin.Invoke(___genericsType, ___parameters);
			from = (UnityEngine.UIElements.TransformOrigin)___parameters[0];
			to = (UnityEngine.UIElements.TransformOrigin)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryConvertTranslateUnits(ref UnityEngine.UIElements.Translate  @from, ref UnityEngine.UIElements.Translate  @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RTryConvertTranslateUnits_Ref_Translate_Ref_Translate.Invoke(___genericsType, ___parameters);
			from = (UnityEngine.UIElements.Translate)___parameters[0];
			to = (UnityEngine.UIElements.Translate)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryConvertBackgroundPositionUnits(ref UnityEngine.UIElements.BackgroundPosition  @from, ref UnityEngine.UIElements.BackgroundPosition  @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition.Invoke(___genericsType, ___parameters);
			from = (UnityEngine.UIElements.BackgroundPosition)___parameters[0];
			to = (UnityEngine.UIElements.BackgroundPosition)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryConvertBackgroundSizeUnits(ref UnityEngine.UIElements.BackgroundSize  @from, ref UnityEngine.UIElements.BackgroundSize  @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize.Invoke(___genericsType, ___parameters);
			from = (UnityEngine.UIElements.BackgroundSize)___parameters[0];
			to = (UnityEngine.UIElements.BackgroundSize)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual void MarkRenderHintsClean()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMarkRenderHintsClean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateBoundingBox()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateBoundingBox.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWorldBoundingBox()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateWorldBoundingBox.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWorldTransform()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateWorldTransform.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateWorldTransformInverse()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateWorldTransformInverse.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnsureWorldTransformAndClipUpToDate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REnsureWorldTransformAndClipUpToDate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteDefaultAction(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RExecuteDefaultAction_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect GetTooltipRect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTooltipRect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void Focus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFocus.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SendEvent(UnityEngine.UIElements.EventBase  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RSendEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }





        public virtual System.Boolean SetEnabledFromHierarchy(System.Boolean  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RSetEnabledFromHierarchy_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetEnabled(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetEnabled_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkDirtyRepaint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMarkDirtyRepaint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeGenerateVisualContent(UnityEngine.UIElements.MeshGenerationContext  @mgc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mgc};
            var ___result = RInvokeGenerateVisualContent_MeshGenerationContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetFullHierarchicalViewDataKey(System.Text.StringBuilder  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RGetFullHierarchicalViewDataKey_StringBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetFullHierarchicalViewDataKey()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetFullHierarchicalViewDataKey.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual T GetOrCreateViewData<T>(System.Object  @existing, System.String  @key) where T : class, new()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@existing, @key};
            var ___result = RGetOrCreateViewData_GT_Object_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetOrCreateViewData<T>(UnityEngine.ScriptableObject  @existing, System.String  @key) where T : UnityEngine.ScriptableObject
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@existing, @key};
            var ___result = RGetOrCreateViewData_GT_ScriptableObject_String.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual void OverwriteFromViewData(System.Object  @obj, System.String  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @key};
            var ___result = ROverwriteFromViewData_Object_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SaveViewData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSaveViewData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsViewDataPersitenceSupportedOnChildren(System.Boolean  @existingState)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@existingState};
            var ___result = RIsViewDataPersitenceSupportedOnChildren_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnViewDataReady(System.Boolean  @enablePersistence)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enablePersistence};
            var ___result = ROnViewDataReady_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnViewDataReady()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnViewDataReady.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ContainsPoint(UnityEngine.Vector2  @localPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localPoint};
            var ___result = RContainsPoint_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Overlaps(UnityEngine.Rect  @rectangle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rectangle};
            var ___result = ROverlaps_Rect.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }




        public virtual void SetSize(UnityEngine.Vector2  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size};
            var ___result = RSetSize_Vector2.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void ResetPositionProperties()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetPositionProperties.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Collections.Generic.IEnumerable<System.String> GetClasses()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetClasses.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<System.String>)___result;
        }


        public virtual System.Collections.Generic.List<System.String> GetClassesForIteration()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetClassesForIteration.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<System.String>)___result;
        }


        public virtual void ClearClassList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearClassList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddToClassList(System.String  @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RAddToClassList_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFromClassList(System.String  @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RRemoveFromClassList_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ToggleInClassList(System.String  @className)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className};
            var ___result = RToggleInClassList_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableInClassList(System.String  @className, System.Boolean  @enable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@className, @enable};
            var ___result = REnableInClassList_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ClassListContains(System.String  @cls)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cls};
            var ___result = RClassListContains_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object FindAncestorUserData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFindAncestorUserData.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetProperty(UnityEngine.PropertyName  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RGetProperty_PropertyName.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void SetProperty(UnityEngine.PropertyName  @key, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RSetProperty_PropertyName_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasProperty(UnityEngine.PropertyName  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RHasProperty_PropertyName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ApplyPlayerRenderingToEditorElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RApplyPlayerRenderingToEditorElement.Invoke(___genericsType, ___parameters);

            
        }




        public virtual System.Boolean GetCachedNextParentWithEventCallback(out UnityEngine.UIElements.VisualElement  @nextParent)
        {
			nextParent = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nextParent};
            var ___result = RGetCachedNextParentWithEventCallback_Out_VisualElement.Invoke(___genericsType, ___parameters);
			nextParent = (UnityEngine.UIElements.VisualElement)___parameters[0];

            return (System.Boolean)___result;
        }









        public virtual System.Boolean ShouldClip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShouldClip.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Add(UnityEngine.UIElements.VisualElement  @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RAdd_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Insert(System.Int32  @index, UnityEngine.UIElements.VisualElement  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @element};
            var ___result = RInsert_Int32_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Remove(UnityEngine.UIElements.VisualElement  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RRemove_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RRemoveAt_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.VisualElement ElementAt(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RElementAt_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual System.Int32 IndexOf(UnityEngine.UIElements.VisualElement  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RIndexOf_VisualElement.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement ElementAtTreePath(System.Collections.Generic.List<System.Int32>  @childIndexes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@childIndexes};
            var ___result = RElementAtTreePath_List_d_Int32_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual System.Boolean FindElementInTree(UnityEngine.UIElements.VisualElement  @element, System.Collections.Generic.List<System.Int32>  @outChildIndexes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @outChildIndexes};
            var ___result = RFindElementInTree_VisualElement_List_d_Int32_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement> Children()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RChildren.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement>)___result;
        }


        public virtual void Sort(System.Comparison<UnityEngine.UIElements.VisualElement>  @comp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comp};
            var ___result = RSort_Comparison_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BringToFront()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBringToFront.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendToBack()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendToBack.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlaceBehind(UnityEngine.UIElements.VisualElement  @sibling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sibling};
            var ___result = RPlaceBehind_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlaceInFront(UnityEngine.UIElements.VisualElement  @sibling)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sibling};
            var ___result = RPlaceInFront_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveFromHierarchy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemoveFromHierarchy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T GetFirstOfType<T>() where T : class
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetFirstOfType_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetFirstAncestorOfType<T>() where T : class
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetFirstAncestorOfType_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetFirstAncestorWhere(System.Predicate<UnityEngine.UIElements.VisualElement>  @predicate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@predicate};
            var ___result = RGetFirstAncestorWhere_Predicate_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual System.Boolean Contains(UnityEngine.UIElements.VisualElement  @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RContains_VisualElement.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement FindCommonAncestor(UnityEngine.UIElements.VisualElement  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RFindCommonAncestor_VisualElement.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetRoot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRoot.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetRootVisualContainer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRootVisualContainer.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetNextElementDepthFirst()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNextElementDepthFirst.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement GetPreviousElementDepthFirst()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPreviousElementDepthFirst.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual UnityEngine.UIElements.VisualElement RetargetElement(UnityEngine.UIElements.VisualElement  @retargetAgainst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@retargetAgainst};
            var ___result = RRetargetElement_VisualElement.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.VisualElement)___result;
        }


        public virtual void GetPivotedMatrixWithLayout(out UnityEngine.Matrix4x4  @result)
        {
			result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RGetPivotedMatrixWithLayout_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			result = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void AddStyleSheetPath(System.String  @sheetPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheetPath};
            var ___result = RAddStyleSheetPath_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasStyleSheetPath(System.String  @sheetPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheetPath};
            var ___result = RHasStyleSheetPath_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RemoveStyleSheetPath(System.String  @sheetPath)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheetPath};
            var ___result = RRemoveStyleSheetPath_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blur()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBlur.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BlurImmediately()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBlurImmediately.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteDefaultActionDisabled(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RExecuteDefaultActionDisabled_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType>  @callback, UnityEngine.UIElements.TrickleDown  @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType)};
            var ___parameters = new object[]{@callback, @useTrickleDown};
            var ___result = RRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterCallback<TEventType, TUserArgsType>(UnityEngine.UIElements.EventCallback<TEventType, TUserArgsType>  @callback, TUserArgsType  @userArgs, UnityEngine.UIElements.TrickleDown  @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType), typeof(TUserArgsType)};
            var ___parameters = new object[]{@callback, @userArgs, @useTrickleDown};
            var ___result = RRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void UnregisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType>  @callback, UnityEngine.UIElements.TrickleDown  @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType)};
            var ___parameters = new object[]{@callback, @useTrickleDown};
            var ___result = RUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterCallback<TEventType, TUserArgsType>(UnityEngine.UIElements.EventCallback<TEventType, TUserArgsType>  @callback, UnityEngine.UIElements.TrickleDown  @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {

            var ___genericsType = new Type[] {typeof(TEventType), typeof(TUserArgsType)};
            var ___parameters = new object[]{@callback, @useTrickleDown};
            var ___result = RUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryGetUserArgs<TEventType, TCallbackArgs>(UnityEngine.UIElements.EventCallback<TEventType, TCallbackArgs>  @callback, UnityEngine.UIElements.TrickleDown  @useTrickleDown, out TCallbackArgs  @userData) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
        {
			userData = default;

            var ___genericsType = new Type[] {typeof(TEventType), typeof(TCallbackArgs)};
            var ___parameters = new object[]{@callback, @useTrickleDown, @userData};
            var ___result = RTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs.Invoke(___genericsType, ___parameters);
			userData = (TCallbackArgs)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual void HandleEventAtTargetPhase(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RHandleEventAtTargetPhase_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEventAtTargetAndDefaultPhase(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RHandleEventAtTargetAndDefaultPhase_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEventAtCurrentTargetAndPhase(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RHandleEventAtCurrentTargetAndPhase_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEventEditorInternal(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RHandleEventEditorInternal_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HandleEvent(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RHandleEvent_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean HasTrickleDownHandlers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasTrickleDownHandlers.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean HasBubbleUpHandlers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasBubbleUpHandlers.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ExecuteDefaultActionAtTarget(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RExecuteDefaultActionAtTarget_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ExecuteDefaultActionDisabledAtTarget(UnityEngine.UIElements.EventBase  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RExecuteDefaultActionDisabledAtTarget_EventBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
