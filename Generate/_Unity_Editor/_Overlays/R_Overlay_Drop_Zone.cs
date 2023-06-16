
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.ROverlays
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEditor.Overlays.OverlayDropZone
	/// </summary>
    public partial class ROverlayDropZone : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEditor.Overlays.OverlayDropZone");
            }
        }

        public ROverlayDropZone() : base("UnityEditor.Overlays.OverlayDropZone")
        {
        }

        public ROverlayDropZone(System.Object instance) : base("UnityEditor.Overlays.OverlayDropZone")
		{
            SetInstance(instance);
		}

        public ROverlayDropZone(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public ROverlayDropZone(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEditor.Overlays.Overlay m_TargetOverlay
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlay r_Fm_TargetOverlay;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlay RFm_TargetOverlay
		{
			get
			{
				if(r_Fm_TargetOverlay == null)
				{
					r_Fm_TargetOverlay = new(this, "m_TargetOverlay");
				}
				return r_Fm_TargetOverlay;
			}
		}

		/// <summary>
		/// UnityEditor.Overlays.OverlayDropZone+Placement m_Placement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayDropZone.RPlacement r_Fm_Placement;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayDropZone.RPlacement RFm_Placement
		{
			get
			{
				if(r_Fm_Placement == null)
				{
					r_Fm_Placement = new(this, "m_Placement");
				}
				return r_Fm_Placement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags m_Flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags r_Fm_Flags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags RFm_Flags
		{
			get
			{
				if(r_Fm_Flags == null)
				{
					r_Fm_Flags = new(this, "m_Flags");
				}
				return r_Fm_Flags;
			}
		}

		/// <summary>
		/// UnityEngine.Rect lastLayout
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_FlastLayout;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFlastLayout
		{
			get
			{
				if(r_FlastLayout == null)
				{
					r_FlastLayout = new(this, "lastLayout");
				}
				return r_FlastLayout;
			}
		}

		/// <summary>
		/// UnityEngine.Rect lastPseudoPadding
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_FlastPseudoPadding;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFlastPseudoPadding
		{
			get
			{
				if(r_FlastPseudoPadding == null)
				{
					r_FlastPseudoPadding = new(this, "lastPseudoPadding");
				}
				return r_FlastPseudoPadding;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainVEData renderChainData
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainVEData r_FrenderChainData;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainVEData RFrenderChainData
		{
			get
			{
				if(r_FrenderChainData == null)
				{
					r_FrenderChainData = new(this, "renderChainData");
				}
				return r_FrenderChainData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PseudoStates triggerPseudoMask
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPseudoStates r_FtriggerPseudoMask;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPseudoStates RFtriggerPseudoMask
		{
			get
			{
				if(r_FtriggerPseudoMask == null)
				{
					r_FtriggerPseudoMask = new(this, "triggerPseudoMask");
				}
				return r_FtriggerPseudoMask;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PseudoStates dependencyPseudoMask
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPseudoStates r_FdependencyPseudoMask;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPseudoStates RFdependencyPseudoMask
		{
			get
			{
				if(r_FdependencyPseudoMask == null)
				{
					r_FdependencyPseudoMask = new(this, "dependencyPseudoMask");
				}
				return r_FdependencyPseudoMask;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedStyle m_Style
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle r_Fm_Style;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle RFm_Style
		{
			get
			{
				if(r_Fm_Style == null)
				{
					r_Fm_Style = new(this, "m_Style");
				}
				return r_Fm_Style;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleVariableContext variableContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariableContext r_FvariableContext;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleVariableContext RFvariableContext
		{
			get
			{
				if(r_FvariableContext == null)
				{
					r_FvariableContext = new(this, "variableContext");
				}
				return r_FvariableContext;
			}
		}

		/// <summary>
		/// System.Int32 inheritedStylesHash
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FinheritedStylesHash;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFinheritedStylesHash
		{
			get
			{
				if(r_FinheritedStylesHash == null)
				{
					r_FinheritedStylesHash = new(this, "inheritedStylesHash");
				}
				return r_FinheritedStylesHash;
			}
		}

		/// <summary>
		/// System.UInt32 controlid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fcontrolid;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFcontrolid
		{
			get
			{
				if(r_Fcontrolid == null)
				{
					r_Fcontrolid = new(this, "controlid");
				}
				return r_Fcontrolid;
			}
		}

		/// <summary>
		/// System.Int32 imguiContainerDescendantCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FimguiContainerDescendantCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFimguiContainerDescendantCount
		{
			get
			{
				if(r_FimguiContainerDescendantCount == null)
				{
					r_FimguiContainerDescendantCount = new(this, "imguiContainerDescendantCount");
				}
				return r_FimguiContainerDescendantCount;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.InlineStyleAccess inlineStyleAccess
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInlineStyleAccess r_FinlineStyleAccess;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInlineStyleAccess RFinlineStyleAccess
		{
			get
			{
				if(r_FinlineStyleAccess == null)
				{
					r_FinlineStyleAccess = new(this, "inlineStyleAccess");
				}
				return r_FinlineStyleAccess;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheet] styleSheetList
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet> r_FstyleSheetList;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheet> RFstyleSheetList
		{
			get
			{
				if(r_FstyleSheetList == null)
				{
					r_FstyleSheetList = new(this, "styleSheetList");
				}
				return r_FstyleSheetList;
			}
		}

		/// <summary>
		/// System.Boolean isIMGUIContainer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisIMGUIContainer;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisIMGUIContainer
		{
			get
			{
				if(r_FisIMGUIContainer == null)
				{
					r_FisIMGUIContainer = new(this, "isIMGUIContainer");
				}
				return r_FisIMGUIContainer;
			}
		}

		/// <summary>
		/// VisualMode visualMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayDropZoneBase.RVisualMode r_PvisualMode;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayDropZoneBase.RVisualMode RPvisualMode
		{
			get
			{
				if(r_PvisualMode == null)
				{
					r_PvisualMode = new(this, "visualMode", -1);
				}
				return r_PvisualMode;
			}
		}

		/// <summary>
		/// Int32 priority
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Ppriority;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPpriority
		{
			get
			{
				if(r_Ppriority == null)
				{
					r_Ppriority = new(this, "priority", -1);
				}
				return r_Ppriority;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IResolvedStyle resolvedStyle
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIResolvedStyle r_PresolvedStyle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIResolvedStyle RPresolvedStyle
		{
			get
			{
				if(r_PresolvedStyle == null)
				{
					r_PresolvedStyle = new(this, "resolvedStyle", -1);
				}
				return r_PresolvedStyle;
			}
		}

		/// <summary>
		/// Boolean hasRunningAnimations
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasRunningAnimations;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasRunningAnimations
		{
			get
			{
				if(r_PhasRunningAnimations == null)
				{
					r_PhasRunningAnimations = new(this, "hasRunningAnimations", -1);
				}
				return r_PhasRunningAnimations;
			}
		}

		/// <summary>
		/// Boolean hasCompletedAnimations
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasCompletedAnimations;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasCompletedAnimations
		{
			get
			{
				if(r_PhasCompletedAnimations == null)
				{
					r_PhasCompletedAnimations = new(this, "hasCompletedAnimations", -1);
				}
				return r_PhasCompletedAnimations;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IStylePropertyAnimations styleAnimation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIStylePropertyAnimations r_PstyleAnimation;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIStylePropertyAnimations RPstyleAnimation
		{
			get
			{
				if(r_PstyleAnimation == null)
				{
					r_PstyleAnimation = new(this, "styleAnimation", -1);
				}
				return r_PstyleAnimation;
			}
		}

		/// <summary>
		/// Boolean isCompositeRoot
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisCompositeRoot;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisCompositeRoot
		{
			get
			{
				if(r_PisCompositeRoot == null)
				{
					r_PisCompositeRoot = new(this, "isCompositeRoot", -1);
				}
				return r_PisCompositeRoot;
			}
		}

		/// <summary>
		/// Boolean isHierarchyDisplayed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisHierarchyDisplayed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisHierarchyDisplayed
		{
			get
			{
				if(r_PisHierarchyDisplayed == null)
				{
					r_PisHierarchyDisplayed = new(this, "isHierarchyDisplayed", -1);
				}
				return r_PisHierarchyDisplayed;
			}
		}

		/// <summary>
		/// System.String viewDataKey
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PviewDataKey;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPviewDataKey
		{
			get
			{
				if(r_PviewDataKey == null)
				{
					r_PviewDataKey = new(this, "viewDataKey", -1);
				}
				return r_PviewDataKey;
			}
		}

		/// <summary>
		/// Boolean enableViewDataPersistence
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PenableViewDataPersistence;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPenableViewDataPersistence
		{
			get
			{
				if(r_PenableViewDataPersistence == null)
				{
					r_PenableViewDataPersistence = new(this, "enableViewDataPersistence", -1);
				}
				return r_PenableViewDataPersistence;
			}
		}

		/// <summary>
		/// System.Object userData
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PuserData;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPuserData
		{
			get
			{
				if(r_PuserData == null)
				{
					r_PuserData = new(this, "userData", -1);
				}
				return r_PuserData;
			}
		}

		/// <summary>
		/// Boolean canGrabFocus
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PcanGrabFocus;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPcanGrabFocus
		{
			get
			{
				if(r_PcanGrabFocus == null)
				{
					r_PcanGrabFocus = new(this, "canGrabFocus", -1);
				}
				return r_PcanGrabFocus;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FocusController focusController
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusController r_PfocusController;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFocusController RPfocusController
		{
			get
			{
				if(r_PfocusController == null)
				{
					r_PfocusController = new(this, "focusController", -1);
				}
				return r_PfocusController;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UsageHints usageHints
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUsageHints r_PusageHints;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUsageHints RPusageHints
		{
			get
			{
				if(r_PusageHints == null)
				{
					r_PusageHints = new(this, "usageHints", -1);
				}
				return r_PusageHints;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.RenderHints renderHints
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRenderHints r_PrenderHints;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRenderHints RPrenderHints
		{
			get
			{
				if(r_PrenderHints == null)
				{
					r_PrenderHints = new(this, "renderHints", -1);
				}
				return r_PrenderHints;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ITransform transform
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RITransform r_Ptransform;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RITransform RPtransform
		{
			get
			{
				if(r_Ptransform == null)
				{
					r_Ptransform = new(this, "transform", -1);
				}
				return r_Ptransform;
			}
		}

		/// <summary>
		/// Boolean isLayoutManual
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisLayoutManual;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisLayoutManual
		{
			get
			{
				if(r_PisLayoutManual == null)
				{
					r_PisLayoutManual = new(this, "isLayoutManual", -1);
				}
				return r_PisLayoutManual;
			}
		}

		/// <summary>
		/// Single scaledPixelsPerPoint
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PscaledPixelsPerPoint;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPscaledPixelsPerPoint
		{
			get
			{
				if(r_PscaledPixelsPerPoint == null)
				{
					r_PscaledPixelsPerPoint = new(this, "scaledPixelsPerPoint", -1);
				}
				return r_PscaledPixelsPerPoint;
			}
		}

		/// <summary>
		/// UnityEngine.Rect layout
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Playout;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPlayout
		{
			get
			{
				if(r_Playout == null)
				{
					r_Playout = new(this, "layout", -1);
				}
				return r_Playout;
			}
		}

		/// <summary>
		/// UnityEngine.Rect contentRect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PcontentRect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPcontentRect
		{
			get
			{
				if(r_PcontentRect == null)
				{
					r_PcontentRect = new(this, "contentRect", -1);
				}
				return r_PcontentRect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect paddingRect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PpaddingRect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPpaddingRect
		{
			get
			{
				if(r_PpaddingRect == null)
				{
					r_PpaddingRect = new(this, "paddingRect", -1);
				}
				return r_PpaddingRect;
			}
		}

		/// <summary>
		/// Boolean isBoundingBoxDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisBoundingBoxDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisBoundingBoxDirty
		{
			get
			{
				if(r_PisBoundingBoxDirty == null)
				{
					r_PisBoundingBoxDirty = new(this, "isBoundingBoxDirty", -1);
				}
				return r_PisBoundingBoxDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldBoundingBoxDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisWorldBoundingBoxDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisWorldBoundingBoxDirty
		{
			get
			{
				if(r_PisWorldBoundingBoxDirty == null)
				{
					r_PisWorldBoundingBoxDirty = new(this, "isWorldBoundingBoxDirty", -1);
				}
				return r_PisWorldBoundingBoxDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldBoundingBoxOrDependenciesDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisWorldBoundingBoxOrDependenciesDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisWorldBoundingBoxOrDependenciesDirty
		{
			get
			{
				if(r_PisWorldBoundingBoxOrDependenciesDirty == null)
				{
					r_PisWorldBoundingBoxOrDependenciesDirty = new(this, "isWorldBoundingBoxOrDependenciesDirty", -1);
				}
				return r_PisWorldBoundingBoxOrDependenciesDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Rect boundingBox
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PboundingBox;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPboundingBox
		{
			get
			{
				if(r_PboundingBox == null)
				{
					r_PboundingBox = new(this, "boundingBox", -1);
				}
				return r_PboundingBox;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldBoundingBox
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PworldBoundingBox;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPworldBoundingBox
		{
			get
			{
				if(r_PworldBoundingBox == null)
				{
					r_PworldBoundingBox = new(this, "worldBoundingBox", -1);
				}
				return r_PworldBoundingBox;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldBound
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PworldBound;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPworldBound
		{
			get
			{
				if(r_PworldBound == null)
				{
					r_PworldBound = new(this, "worldBound", -1);
				}
				return r_PworldBound;
			}
		}

		/// <summary>
		/// UnityEngine.Rect localBound
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PlocalBound;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPlocalBound
		{
			get
			{
				if(r_PlocalBound == null)
				{
					r_PlocalBound = new(this, "localBound", -1);
				}
				return r_PlocalBound;
			}
		}

		/// <summary>
		/// UnityEngine.Rect rect
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Prect;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPrect
		{
			get
			{
				if(r_Prect == null)
				{
					r_Prect = new(this, "rect", -1);
				}
				return r_Prect;
			}
		}

		/// <summary>
		/// Boolean isWorldTransformDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisWorldTransformDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisWorldTransformDirty
		{
			get
			{
				if(r_PisWorldTransformDirty == null)
				{
					r_PisWorldTransformDirty = new(this, "isWorldTransformDirty", -1);
				}
				return r_PisWorldTransformDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldTransformInverseDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisWorldTransformInverseDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisWorldTransformInverseDirty
		{
			get
			{
				if(r_PisWorldTransformInverseDirty == null)
				{
					r_PisWorldTransformInverseDirty = new(this, "isWorldTransformInverseDirty", -1);
				}
				return r_PisWorldTransformInverseDirty;
			}
		}

		/// <summary>
		/// Boolean isWorldTransformInverseOrDependenciesDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisWorldTransformInverseOrDependenciesDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisWorldTransformInverseOrDependenciesDirty
		{
			get
			{
				if(r_PisWorldTransformInverseOrDependenciesDirty == null)
				{
					r_PisWorldTransformInverseOrDependenciesDirty = new(this, "isWorldTransformInverseOrDependenciesDirty", -1);
				}
				return r_PisWorldTransformInverseOrDependenciesDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 worldTransform
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_PworldTransform;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 RPworldTransform
		{
			get
			{
				if(r_PworldTransform == null)
				{
					r_PworldTransform = new(this, "worldTransform", -1);
				}
				return r_PworldTransform;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4& worldTransformRef
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_PworldTransformRef;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 RPworldTransformRef
		{
			get
			{
				if(r_PworldTransformRef == null)
				{
					r_PworldTransformRef = new(this, "worldTransformRef", -1);
				}
				return r_PworldTransformRef;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4& worldTransformInverse
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_PworldTransformInverse;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 RPworldTransformInverse
		{
			get
			{
				if(r_PworldTransformInverse == null)
				{
					r_PworldTransformInverse = new(this, "worldTransformInverse", -1);
				}
				return r_PworldTransformInverse;
			}
		}

		/// <summary>
		/// Boolean isWorldClipDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisWorldClipDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisWorldClipDirty
		{
			get
			{
				if(r_PisWorldClipDirty == null)
				{
					r_PisWorldClipDirty = new(this, "isWorldClipDirty", -1);
				}
				return r_PisWorldClipDirty;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldClip
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PworldClip;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPworldClip
		{
			get
			{
				if(r_PworldClip == null)
				{
					r_PworldClip = new(this, "worldClip", -1);
				}
				return r_PworldClip;
			}
		}

		/// <summary>
		/// UnityEngine.Rect worldClipMinusGroup
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PworldClipMinusGroup;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPworldClipMinusGroup
		{
			get
			{
				if(r_PworldClipMinusGroup == null)
				{
					r_PworldClipMinusGroup = new(this, "worldClipMinusGroup", -1);
				}
				return r_PworldClipMinusGroup;
			}
		}

		/// <summary>
		/// Boolean worldClipIsInfinite
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PworldClipIsInfinite;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPworldClipIsInfinite
		{
			get
			{
				if(r_PworldClipIsInfinite == null)
				{
					r_PworldClipIsInfinite = new(this, "worldClipIsInfinite", -1);
				}
				return r_PworldClipIsInfinite;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PseudoStates pseudoStates
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPseudoStates r_PpseudoStates;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPseudoStates RPpseudoStates
		{
			get
			{
				if(r_PpseudoStates == null)
				{
					r_PpseudoStates = new(this, "pseudoStates", -1);
				}
				return r_PpseudoStates;
			}
		}

		/// <summary>
		/// Int32 containedPointerIds
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PcontainedPointerIds;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPcontainedPointerIds
		{
			get
			{
				if(r_PcontainedPointerIds == null)
				{
					r_PcontainedPointerIds = new(this, "containedPointerIds", -1);
				}
				return r_PcontainedPointerIds;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PickingMode pickingMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPickingMode r_PpickingMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPickingMode RPpickingMode
		{
			get
			{
				if(r_PpickingMode == null)
				{
					r_PpickingMode = new(this, "pickingMode", -1);
				}
				return r_PpickingMode;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] classList
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_PclassList;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RPclassList
		{
			get
			{
				if(r_PclassList == null)
				{
					r_PclassList = new(this, "classList", -1);
				}
				return r_PclassList;
			}
		}

		/// <summary>
		/// System.String fullTypeName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PfullTypeName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPfullTypeName
		{
			get
			{
				if(r_PfullTypeName == null)
				{
					r_PfullTypeName = new(this, "fullTypeName", -1);
				}
				return r_PfullTypeName;
			}
		}

		/// <summary>
		/// System.String typeName
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PtypeName;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtypeName
		{
			get
			{
				if(r_PtypeName == null)
				{
					r_PtypeName = new(this, "typeName", -1);
				}
				return r_PtypeName;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaNode yogaNode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaNode r_PyogaNode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaNode RPyogaNode
		{
			get
			{
				if(r_PyogaNode == null)
				{
					r_PyogaNode = new(this, "yogaNode", -1);
				}
				return r_PyogaNode;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.ComputedStyle& computedStyle
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle r_PcomputedStyle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle RPcomputedStyle
		{
			get
			{
				if(r_PcomputedStyle == null)
				{
					r_PcomputedStyle = new(this, "computedStyle", -1);
				}
				return r_PcomputedStyle;
			}
		}

		/// <summary>
		/// Boolean hasInlineStyle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasInlineStyle;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasInlineStyle
		{
			get
			{
				if(r_PhasInlineStyle == null)
				{
					r_PhasInlineStyle = new(this, "hasInlineStyle", -1);
				}
				return r_PhasInlineStyle;
			}
		}

		/// <summary>
		/// Boolean styleInitialized
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PstyleInitialized;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPstyleInitialized
		{
			get
			{
				if(r_PstyleInitialized == null)
				{
					r_PstyleInitialized = new(this, "styleInitialized", -1);
				}
				return r_PstyleInitialized;
			}
		}

		/// <summary>
		/// Single opacity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Popacity;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPopacity
		{
			get
			{
				if(r_Popacity == null)
				{
					r_Popacity = new(this, "opacity", -1);
				}
				return r_Popacity;
			}
		}

		/// <summary>
		/// Boolean enabledInHierarchy
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PenabledInHierarchy;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPenabledInHierarchy
		{
			get
			{
				if(r_PenabledInHierarchy == null)
				{
					r_PenabledInHierarchy = new(this, "enabledInHierarchy", -1);
				}
				return r_PenabledInHierarchy;
			}
		}

		/// <summary>
		/// Boolean enabledSelf
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PenabledSelf;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPenabledSelf
		{
			get
			{
				if(r_PenabledSelf == null)
				{
					r_PenabledSelf = new(this, "enabledSelf", -1);
				}
				return r_PenabledSelf;
			}
		}

		/// <summary>
		/// Boolean visible
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pvisible;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPvisible
		{
			get
			{
				if(r_Pvisible == null)
				{
					r_Pvisible = new(this, "visible", -1);
				}
				return r_Pvisible;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.MeshGenerationContext] generateVisualContent
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext> r_PgenerateVisualContent;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext> RPgenerateVisualContent
		{
			get
			{
				if(r_PgenerateVisualContent == null)
				{
					r_PgenerateVisualContent = new(this, "generateVisualContent", -1);
				}
				return r_PgenerateVisualContent;
			}
		}

		/// <summary>
		/// Boolean requireMeasureFunction
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PrequireMeasureFunction;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPrequireMeasureFunction
		{
			get
			{
				if(r_PrequireMeasureFunction == null)
				{
					r_PrequireMeasureFunction = new(this, "requireMeasureFunction", -1);
				}
				return r_PrequireMeasureFunction;
			}
		}

		/// <summary>
		/// RenderTargetMode subRenderTargetMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RRenderTargetMode r_PsubRenderTargetMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RRenderTargetMode RPsubRenderTargetMode
		{
			get
			{
				if(r_PsubRenderTargetMode == null)
				{
					r_PsubRenderTargetMode = new(this, "subRenderTargetMode", -1);
				}
				return r_PsubRenderTargetMode;
			}
		}

		/// <summary>
		/// UnityEngine.Material defaultMaterial
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterial r_PdefaultMaterial;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterial RPdefaultMaterial
		{
			get
			{
				if(r_PdefaultMaterial == null)
				{
					r_PdefaultMaterial = new(this, "defaultMaterial", -1);
				}
				return r_PdefaultMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement nextParentWithEventCallback
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PnextParentWithEventCallback;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPnextParentWithEventCallback
		{
			get
			{
				if(r_PnextParentWithEventCallback == null)
				{
					r_PnextParentWithEventCallback = new(this, "nextParentWithEventCallback", -1);
				}
				return r_PnextParentWithEventCallback;
			}
		}

		/// <summary>
		/// Int32 eventCallbackCategories
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PeventCallbackCategories;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPeventCallbackCategories
		{
			get
			{
				if(r_PeventCallbackCategories == null)
				{
					r_PeventCallbackCategories = new(this, "eventCallbackCategories", -1);
				}
				return r_PeventCallbackCategories;
			}
		}

		/// <summary>
		/// Int32 eventCallbackParentCategories
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PeventCallbackParentCategories;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPeventCallbackParentCategories
		{
			get
			{
				if(r_PeventCallbackParentCategories == null)
				{
					r_PeventCallbackParentCategories = new(this, "eventCallbackParentCategories", -1);
				}
				return r_PeventCallbackParentCategories;
			}
		}

		/// <summary>
		/// Boolean isEventCallbackParentCategoriesDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisEventCallbackParentCategoriesDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisEventCallbackParentCategoriesDirty
		{
			get
			{
				if(r_PisEventCallbackParentCategoriesDirty == null)
				{
					r_PisEventCallbackParentCategoriesDirty = new(this, "isEventCallbackParentCategoriesDirty", -1);
				}
				return r_PisEventCallbackParentCategoriesDirty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IExperimentalFeatures experimental
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIExperimentalFeatures r_Pexperimental;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIExperimentalFeatures RPexperimental
		{
			get
			{
				if(r_Pexperimental == null)
				{
					r_Pexperimental = new(this, "experimental", -1);
				}
				return r_Pexperimental;
			}
		}

		/// <summary>
		/// Hierarchy hierarchy
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RHierarchy r_Phierarchy;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RHierarchy RPhierarchy
		{
			get
			{
				if(r_Phierarchy == null)
				{
					r_Phierarchy = new(this, "hierarchy", -1);
				}
				return r_Phierarchy;
			}
		}

		/// <summary>
		/// Boolean isRootVisualContainer
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisRootVisualContainer;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisRootVisualContainer
		{
			get
			{
				if(r_PisRootVisualContainer == null)
				{
					r_PisRootVisualContainer = new(this, "isRootVisualContainer", -1);
				}
				return r_PisRootVisualContainer;
			}
		}

		/// <summary>
		/// Boolean cacheAsBitmap
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PcacheAsBitmap;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPcacheAsBitmap
		{
			get
			{
				if(r_PcacheAsBitmap == null)
				{
					r_PcacheAsBitmap = new(this, "cacheAsBitmap", -1);
				}
				return r_PcacheAsBitmap;
			}
		}

		/// <summary>
		/// Boolean disableClipping
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PdisableClipping;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdisableClipping
		{
			get
			{
				if(r_PdisableClipping == null)
				{
					r_PdisableClipping = new(this, "disableClipping", -1);
				}
				return r_PdisableClipping;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement parent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Pparent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPparent
		{
			get
			{
				if(r_Pparent == null)
				{
					r_Pparent = new(this, "parent", -1);
				}
				return r_Pparent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseVisualElementPanel elementPanel
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel r_PelementPanel;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel RPelementPanel
		{
			get
			{
				if(r_PelementPanel == null)
				{
					r_PelementPanel = new(this, "elementPanel", -1);
				}
				return r_PelementPanel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IPanel panel
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel r_Ppanel;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIPanel RPpanel
		{
			get
			{
				if(r_Ppanel == null)
				{
					r_Ppanel = new(this, "panel", -1);
				}
				return r_Ppanel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement contentContainer
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PcontentContainer;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPcontentContainer
		{
			get
			{
				if(r_PcontentContainer == null)
				{
					r_PcontentContainer = new(this, "contentContainer", -1);
				}
				return r_PcontentContainer;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset visualTreeAssetSource
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset r_PvisualTreeAssetSource;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset RPvisualTreeAssetSource
		{
			get
			{
				if(r_PvisualTreeAssetSource == null)
				{
					r_PvisualTreeAssetSource = new(this, "visualTreeAssetSource", -1);
				}
				return r_PvisualTreeAssetSource;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement Item [Int32]
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PItem_Int32;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPItem_Int32
		{
			get
			{
				if(r_PItem_Int32 == null)
				{
					r_PItem_Int32 = new(this, "Item", -1, typeof(System.Int32));
				}
				return r_PItem_Int32;
			}
		}

		/// <summary>
		/// Int32 childCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PchildCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPchildCount
		{
			get
			{
				if(r_PchildCount == null)
				{
					r_PchildCount = new(this, "childCount", -1);
				}
				return r_PchildCount;
			}
		}

		/// <summary>
		/// Boolean hasDefaultRotationAndScale
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasDefaultRotationAndScale;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasDefaultRotationAndScale
		{
			get
			{
				if(r_PhasDefaultRotationAndScale == null)
				{
					r_PhasDefaultRotationAndScale = new(this, "hasDefaultRotationAndScale", -1);
				}
				return r_PhasDefaultRotationAndScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduler schedule
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualElementScheduler r_Pschedule;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIVisualElementScheduler RPschedule
		{
			get
			{
				if(r_Pschedule == null)
				{
					r_Pschedule = new(this, "schedule", -1);
				}
				return r_Pschedule;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IStyle style
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIStyle r_Pstyle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIStyle RPstyle
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
		/// UnityEngine.UIElements.ICustomStyle customStyle
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RICustomStyle r_PcustomStyle;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RICustomStyle RPcustomStyle
		{
			get
			{
				if(r_PcustomStyle == null)
				{
					r_PcustomStyle = new(this, "customStyle", -1);
				}
				return r_PcustomStyle;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementStyleSheetSet styleSheets
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementStyleSheetSet r_PstyleSheets;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementStyleSheetSet RPstyleSheets
		{
			get
			{
				if(r_PstyleSheets == null)
				{
					r_PstyleSheets = new(this, "styleSheets", -1);
				}
				return r_PstyleSheets;
			}
		}

		/// <summary>
		/// System.String tooltip
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Ptooltip;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPtooltip
		{
			get
			{
				if(r_Ptooltip == null)
				{
					r_Ptooltip = new(this, "tooltip", -1);
				}
				return r_Ptooltip;
			}
		}

		/// <summary>
		/// Boolean focusable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Pfocusable;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPfocusable
		{
			get
			{
				if(r_Pfocusable == null)
				{
					r_Pfocusable = new(this, "focusable", -1);
				}
				return r_Pfocusable;
			}
		}

		/// <summary>
		/// Int32 tabIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PtabIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPtabIndex
		{
			get
			{
				if(r_PtabIndex == null)
				{
					r_PtabIndex = new(this, "tabIndex", -1);
				}
				return r_PtabIndex;
			}
		}

		/// <summary>
		/// Boolean delegatesFocus
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PdelegatesFocus;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPdelegatesFocus
		{
			get
			{
				if(r_PdelegatesFocus == null)
				{
					r_PdelegatesFocus = new(this, "delegatesFocus", -1);
				}
				return r_PdelegatesFocus;
			}
		}

		/// <summary>
		/// Boolean excludeFromFocusRing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PexcludeFromFocusRing;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPexcludeFromFocusRing
		{
			get
			{
				if(r_PexcludeFromFocusRing == null)
				{
					r_PexcludeFromFocusRing = new(this, "excludeFromFocusRing", -1);
				}
				return r_PexcludeFromFocusRing;
			}
		}

		/// <summary>
		/// Void OnDropZoneActivated(UnityEditor.Overlays.Overlay)
		/// </summary>
		protected RMethod r_MOnDropZoneActivated_Overlay;
		public virtual RMethod RMOnDropZoneActivated_Overlay
		{
			get
			{
				if(r_MOnDropZoneActivated_Overlay == null)
				{
					r_MOnDropZoneActivated_Overlay = new(this, "OnDropZoneActivated", 0, typeof(UnityEditor.Overlays.Overlay));
				}
				return r_MOnDropZoneActivated_Overlay;
			}
		}

		/// <summary>
		/// Boolean CanAcceptTarget(UnityEditor.Overlays.Overlay)
		/// </summary>
		protected RMethod r_MCanAcceptTarget_Overlay;
		public virtual RMethod RMCanAcceptTarget_Overlay
		{
			get
			{
				if(r_MCanAcceptTarget_Overlay == null)
				{
					r_MCanAcceptTarget_Overlay = new(this, "CanAcceptTarget", 0, typeof(UnityEditor.Overlays.Overlay));
				}
				return r_MCanAcceptTarget_Overlay;
			}
		}

		/// <summary>
		/// Void DropOverlay(UnityEditor.Overlays.Overlay)
		/// </summary>
		protected RMethod r_MDropOverlay_Overlay;
		public virtual RMethod RMDropOverlay_Overlay
		{
			get
			{
				if(r_MDropOverlay_Overlay == null)
				{
					r_MDropOverlay_Overlay = new(this, "DropOverlay", 0, typeof(UnityEditor.Overlays.Overlay));
				}
				return r_MDropOverlay_Overlay;
			}
		}

		/// <summary>
		/// Void PopulateDestMarkerClassList(System.Collections.Generic.IList`1[System.String])
		/// </summary>
		protected RMethod r_MPopulateDestMarkerClassList_IList_d_String_p_;
		public virtual RMethod RMPopulateDestMarkerClassList_IList_d_String_p_
		{
			get
			{
				if(r_MPopulateDestMarkerClassList_IList_d_String_p_ == null)
				{
					r_MPopulateDestMarkerClassList_IList_d_String_p_ = new(this, "PopulateDestMarkerClassList", 0,  ReflectionUtils.GetType("System.Collections.Generic.IList`1").MakeGenericType(typeof(System.String)));
				}
				return r_MPopulateDestMarkerClassList_IList_d_String_p_;
			}
		}

		/// <summary>
		/// Void SetVisualMode(VisualMode)
		/// </summary>
		protected RMethod r_MSetVisualMode_VisualMode;
		public virtual RMethod RMSetVisualMode_VisualMode
		{
			get
			{
				if(r_MSetVisualMode_VisualMode == null)
				{
					r_MSetVisualMode_VisualMode = new(this, "SetVisualMode", 0,  ReflectionUtils.GetType("UnityEditor.Overlays.OverlayDropZoneBase+VisualMode"));
				}
				return r_MSetVisualMode_VisualMode;
			}
		}

		/// <summary>
		/// UnityEngine.Rect GetTargetWorldBounds()
		/// </summary>
		protected RMethod r_MGetTargetWorldBounds;
		public virtual RMethod RMGetTargetWorldBounds
		{
			get
			{
				if(r_MGetTargetWorldBounds == null)
				{
					r_MGetTargetWorldBounds = new(this, "GetTargetWorldBounds", 0);
				}
				return r_MGetTargetWorldBounds;
			}
		}

		/// <summary>
		/// Void GetContainerStylingForDestMarker(UnityEditor.Overlays.OverlayContainer, System.Collections.Generic.IList`1[System.String] ByRef)
		/// </summary>
		protected RMethod r_MGetContainerStylingForDestMarker_OverlayContainer_Ref_IList_d_String_p_;
		public virtual RMethod RMGetContainerStylingForDestMarker_OverlayContainer_Ref_IList_d_String_p_
		{
			get
			{
				if(r_MGetContainerStylingForDestMarker_OverlayContainer_Ref_IList_d_String_p_ == null)
				{
					r_MGetContainerStylingForDestMarker_OverlayContainer_Ref_IList_d_String_p_ = new(this, "GetContainerStylingForDestMarker", 0,  ReflectionUtils.GetType("UnityEditor.Overlays.OverlayContainer"),  ReflectionUtils.GetType("System.Collections.Generic.IList`1").MakeGenericType(typeof(System.String)).MakeByRefType());
				}
				return r_MGetContainerStylingForDestMarker_OverlayContainer_Ref_IList_d_String_p_;
			}
		}

		/// <summary>
		/// Void OnDropZoneDeactivated(UnityEditor.Overlays.Overlay)
		/// </summary>
		protected RMethod r_MOnDropZoneDeactivated_Overlay;
		public virtual RMethod RMOnDropZoneDeactivated_Overlay
		{
			get
			{
				if(r_MOnDropZoneDeactivated_Overlay == null)
				{
					r_MOnDropZoneDeactivated_Overlay = new(this, "OnDropZoneDeactivated", 0, typeof(UnityEditor.Overlays.Overlay));
				}
				return r_MOnDropZoneDeactivated_Overlay;
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
				}
				return r_MMarkRenderHintsClean;
			}
		}

		/// <summary>
		/// Void ClearManualLayout()
		/// </summary>
		protected RMethod r_MClearManualLayout;
		public virtual RMethod RMClearManualLayout
		{
			get
			{
				if(r_MClearManualLayout == null)
				{
					r_MClearManualLayout = new(this, "ClearManualLayout", 0);
				}
				return r_MClearManualLayout;
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
					r_MElementAtTreePath_List_d_Int32_p_ = new(this, "ElementAtTreePath", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Int32)));
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
					r_MFindElementInTree_VisualElement_List_d_Int32_p_ = new(this, "FindElementInTree", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(System.Int32)));
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
					r_MSort_Comparison_d_VisualElement_p_ = new(this, "Sort", 0,  ReflectionUtils.GetType("System.Comparison`1").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
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
					r_MGetFirstAncestorWhere_Predicate_d_VisualElement_p_ = new(this, "GetFirstAncestorWhere", 0,  ReflectionUtils.GetType("System.Predicate`1").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
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
					r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown = new(this, "RegisterCallback", 1,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCallback`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(UnityEngine.UIElements.TrickleDown));
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
					r_MRegisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TUserArgsType_TrickleDown = new(this, "RegisterCallback", 2,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCallback`2").MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), Type.MakeGenericMethodParameter(1), typeof(UnityEngine.UIElements.TrickleDown));
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
					r_MRegisterCallback_GTEventType_EventCallback_d_TEventType_p__InvokePolicy_TrickleDown = new(this, "RegisterCallback", 1,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCallback`1").MakeGenericType(Type.MakeGenericMethodParameter(0)),  ReflectionUtils.GetType("UnityEngine.UIElements.InvokePolicy"), typeof(UnityEngine.UIElements.TrickleDown));
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
					r_MUnregisterCallback_GTEventType_EventCallback_d_TEventType_p__TrickleDown = new(this, "UnregisterCallback", 1,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCallback`1").MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(UnityEngine.UIElements.TrickleDown));
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
					r_MUnregisterCallback_GTEventType_GTUserArgsType_EventCallback_d_TEventType_TUserArgsType_p__TrickleDown = new(this, "UnregisterCallback", 2,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCallback`2").MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), typeof(UnityEngine.UIElements.TrickleDown));
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
					r_MTryGetUserArgs_GTEventType_GTCallbackArgs_EventCallback_d_TEventType_TCallbackArgs_p__TrickleDown_Out_TCallbackArgs = new(this, "TryGetUserArgs", 2,  ReflectionUtils.GetType("UnityEngine.UIElements.EventCallback`2").MakeGenericType(Type.MakeGenericMethodParameter(0), Type.MakeGenericMethodParameter(1)), typeof(UnityEngine.UIElements.TrickleDown), Type.MakeGenericMethodParameter(1).MakeByRefType());
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


        public virtual void OnDropZoneActivated(UnityEditor.Overlays.Overlay @draggedOverlay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@draggedOverlay};
            var ___result = RMOnDropZoneActivated_Overlay.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CanAcceptTarget(UnityEditor.Overlays.Overlay @overlay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@overlay};
            var ___result = RMCanAcceptTarget_Overlay.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void DropOverlay(UnityEditor.Overlays.Overlay @overlay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@overlay};
            var ___result = RMDropOverlay_Overlay.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PopulateDestMarkerClassList(System.Collections.Generic.IList<System.String> @classes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@classes};
            var ___result = RMPopulateDestMarkerClassList_IList_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVisualMode(Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayDropZoneBase.RVisualMode @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mode.Value};
            var ___result = RMSetVisualMode_VisualMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect GetTargetWorldBounds()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetTargetWorldBounds.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rect>(___result);
        }


        public virtual void GetContainerStylingForDestMarker(Hvak.Editor.Refleaction.RUnityEditor.ROverlays.ROverlayContainer @container, ref System.Collections.Generic.IList<System.String> @classes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@container.Value, @classes};
            var ___result = RMGetContainerStylingForDestMarker_OverlayContainer_Ref_IList_d_String_p_.Invoke(___genericsType, ___parameters);
			@classes = ReflectionUtils.Convert<System.Collections.Generic.IList<System.String>>(___parameters[1]);

            
        }


        public virtual void OnDropZoneDeactivated(UnityEditor.Overlays.Overlay @draggedOverlay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@draggedOverlay};
            var ___result = RMOnDropZoneDeactivated_Overlay.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryConvertLengthUnits(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, ref UnityEngine.UIElements.Length @from, ref UnityEngine.UIElements.Length @to, System.Int32 @subPropertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @subPropertyIndex};
            var ___result = RMTryConvertLengthUnits_StylePropertyId_Ref_Length_Ref_Length_Int32.Invoke(___genericsType, ___parameters);
			@from = ReflectionUtils.Convert<UnityEngine.UIElements.Length>(___parameters[1]);
			@to = ReflectionUtils.Convert<UnityEngine.UIElements.Length>(___parameters[2]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean TryConvertTransformOriginUnits(ref UnityEngine.UIElements.TransformOrigin @from, ref UnityEngine.UIElements.TransformOrigin @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RMTryConvertTransformOriginUnits_Ref_TransformOrigin_Ref_TransformOrigin.Invoke(___genericsType, ___parameters);
			@from = ReflectionUtils.Convert<UnityEngine.UIElements.TransformOrigin>(___parameters[0]);
			@to = ReflectionUtils.Convert<UnityEngine.UIElements.TransformOrigin>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean TryConvertTranslateUnits(ref UnityEngine.UIElements.Translate @from, ref UnityEngine.UIElements.Translate @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RMTryConvertTranslateUnits_Ref_Translate_Ref_Translate.Invoke(___genericsType, ___parameters);
			@from = ReflectionUtils.Convert<UnityEngine.UIElements.Translate>(___parameters[0]);
			@to = ReflectionUtils.Convert<UnityEngine.UIElements.Translate>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean TryConvertBackgroundPositionUnits(ref UnityEngine.UIElements.BackgroundPosition @from, ref UnityEngine.UIElements.BackgroundPosition @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RMTryConvertBackgroundPositionUnits_Ref_BackgroundPosition_Ref_BackgroundPosition.Invoke(___genericsType, ___parameters);
			@from = ReflectionUtils.Convert<UnityEngine.UIElements.BackgroundPosition>(___parameters[0]);
			@to = ReflectionUtils.Convert<UnityEngine.UIElements.BackgroundPosition>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean TryConvertBackgroundSizeUnits(ref UnityEngine.UIElements.BackgroundSize @from, ref UnityEngine.UIElements.BackgroundSize @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RMTryConvertBackgroundSizeUnits_Ref_BackgroundSize_Ref_BackgroundSize.Invoke(___genericsType, ___parameters);
			@from = ReflectionUtils.Convert<UnityEngine.UIElements.BackgroundSize>(___parameters[0]);
			@to = ReflectionUtils.Convert<UnityEngine.UIElements.BackgroundSize>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void MarkRenderHintsClean()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMarkRenderHintsClean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearManualLayout()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMClearManualLayout.Invoke(___genericsType, ___parameters);

            
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

            return ReflectionUtils.Convert<UnityEngine.Rect>(___result);
        }


        public virtual void Focus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPanel(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel @p)
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


        public virtual void SendEvent(UnityEngine.UIElements.EventBase @e, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDispatchMode @dispatchMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @dispatchMode.Value};
            var ___result = RMSendEvent_EventBase_DispatchMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void IncrementVersion(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType @changeType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@changeType.Value};
            var ___result = RMIncrementVersion_VersionChangeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeHierarchyChanged(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RHierarchyChangeType @changeType)
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual T GetOrCreateViewData<T>(System.Object @existing, System.String @key) where T : class, new()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@existing, @key};
            var ___result = RMGetOrCreateViewData_GT_Object_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual T GetOrCreateViewData<T>(UnityEngine.ScriptableObject @existing, System.String @key) where T : UnityEngine.ScriptableObject
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@existing, @key};
            var ___result = RMGetOrCreateViewData_GT_ScriptableObject_String.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean Overlaps(UnityEngine.Rect @rectangle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rectangle};
            var ___result = RMOverlaps_Rect.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual UnityEngine.Vector2 DoMeasure(System.Single @desiredWidth, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RMeasureMode @widthMode, System.Single @desiredHeight, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RMeasureMode @heightMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@desiredWidth, @widthMode.Value, @desiredHeight, @heightMode.Value};
            var ___result = RMDoMeasure_Single_MeasureMode_Single_MeasureMode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector2>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaSize Measure(Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaNode @node, System.Single @width, Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaMeasureMode @widthMode, System.Single @height, Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaMeasureMode @heightMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node.Value, @width, @widthMode.Value, @height, @heightMode.Value};
            var ___result = RMMeasure_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaSize>(___result);
        }


        public virtual void SetSize(UnityEngine.Vector2 @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size};
            var ___result = RMSetSize_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetInlineRule(UnityEngine.UIElements.StyleSheet @sheet, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheet, @rule.Value};
            var ___result = RMSetInlineRule_StyleSheet_StyleRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInlineRule(UnityEngine.UIElements.StyleSheet @sheet, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleRule @rule)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sheet, @rule.Value};
            var ___result = RMUpdateInlineRule_StyleSheet_StyleRule.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetComputedStyle(ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle @newStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newStyle.Value};
            var ___result = RMSetComputedStyle_Ref_ComputedStyle.Invoke(___genericsType, ___parameters);
			@newStyle = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RComputedStyle>(___parameters[0]);

            
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

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual System.Collections.Generic.IEnumerable<System.String> GetClasses()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetClasses.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.IEnumerable<System.String>>(___result);
        }


        public virtual System.Collections.Generic.List<System.String> GetClassesForIteration()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetClassesForIteration.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.List<System.String>>(___result);
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Object FindAncestorUserData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFindAncestorUserData.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


        public virtual System.Object GetProperty(UnityEngine.PropertyName @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMGetProperty_PropertyName.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void ApplyPlayerRenderingToEditorElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMApplyPlayerRenderingToEditorElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterAnimation(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate @anim)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anim.Value};
            var ___result = RMRegisterAnimation_IValueAnimationUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterAnimation(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate @anim)
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
			@nextParent = ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___parameters[0]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasEventCallbacks(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasEventCallbacks_EventCategory.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasParentEventCallbacks(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasParentEventCallbacks_EventCategory.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasParentEventCallbacksOrDefaultActions(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasParentEventCallbacksOrDefaultActions_EventCategory.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasEventCallbacksOrDefaultActions(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasEventCallbacksOrDefaultActions_EventCategory.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasParentEventCallbacksOrDefaultActionAtTarget(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasParentEventCallbacksOrDefaultActionAtTarget_EventCategory.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasEventCallbacksOrDefaultActionAtTarget(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasEventCallbacksOrDefaultActionAtTarget_EventCategory.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasDefaultAction(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REventCategory @eventCategory)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventCategory.Value};
            var ___result = RMHasDefaultAction_EventCategory.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean ShouldClip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShouldClip.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual System.Int32 IndexOf(UnityEngine.UIElements.VisualElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RMIndexOf_VisualElement.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual UnityEngine.UIElements.VisualElement ElementAtTreePath(System.Collections.Generic.List<System.Int32> @childIndexes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@childIndexes};
            var ___result = RMElementAtTreePath_List_d_Int32_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual System.Boolean FindElementInTree(UnityEngine.UIElements.VisualElement @element, System.Collections.Generic.List<System.Int32> @outChildIndexes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element, @outChildIndexes};
            var ___result = RMFindElementInTree_VisualElement_List_d_Int32_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement> Children()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMChildren.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement>>(___result);
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

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual T GetFirstAncestorOfType<T>() where T : class
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RMGetFirstAncestorOfType_GT.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<T>(___result);
        }


        public virtual UnityEngine.UIElements.VisualElement GetFirstAncestorWhere(System.Predicate<UnityEngine.UIElements.VisualElement> @predicate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@predicate};
            var ___result = RMGetFirstAncestorWhere_Predicate_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual System.Boolean Contains(UnityEngine.UIElements.VisualElement @child)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@child};
            var ___result = RMContains_VisualElement.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual UnityEngine.UIElements.VisualElement FindCommonAncestor(UnityEngine.UIElements.VisualElement @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMFindCommonAncestor_VisualElement.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual UnityEngine.UIElements.VisualElement GetRoot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRoot.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual UnityEngine.UIElements.VisualElement GetRootVisualContainer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRootVisualContainer.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual UnityEngine.UIElements.VisualElement GetNextElementDepthFirst()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetNextElementDepthFirst.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual UnityEngine.UIElements.VisualElement GetPreviousElementDepthFirst()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPreviousElementDepthFirst.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual UnityEngine.UIElements.VisualElement RetargetElement(UnityEngine.UIElements.VisualElement @retargetAgainst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@retargetAgainst};
            var ___result = RMRetargetElement_VisualElement.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___result);
        }


        public virtual void GetPivotedMatrixWithLayout(out UnityEngine.Matrix4x4 @result)
        {
			@result = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RMGetPivotedMatrixWithLayout_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@result = ReflectionUtils.Convert<UnityEngine.Matrix4x4>(___parameters[0]);

            
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
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


        public virtual void RegisterCallback<TEventType>(UnityEngine.UIElements.EventCallback<TEventType> @callback, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RInvokePolicy @invokePolicy, UnityEngine.UIElements.TrickleDown @useTrickleDown) where TEventType : UnityEngine.UIElements.EventBase<TEventType>, new()
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
			@userData = ReflectionUtils.Convert<TCallbackArgs>(___parameters[2]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean HasBubbleUpHandlers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMHasBubbleUpHandlers.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
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
