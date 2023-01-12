using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.VisualElement
	/// </summary>
    public partial class RVisualElement : RMember //
    {

		/// <summary>
		/// System.Int32 <UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount>k__BackingField
		/// </summary>
		protected RSystem.RInt32 r_F__0__UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__runningAnimationCount__1__k__BackingField;
		public virtual RSystem.RInt32 RF__0__UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__runningAnimationCount__1__k__BackingField
		{
			get
			{
				if(r_F__0__UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__runningAnimationCount__1__k__BackingField == null)
				{
					r_F__0__UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__runningAnimationCount__1__k__BackingField = new(this, "<UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount>k__BackingField");
					r_F__0__UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__runningAnimationCount__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__runningAnimationCount__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount>k__BackingField
		/// </summary>
		protected RSystem.RInt32 r_F__0__UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__completedAnimationCount__1__k__BackingField;
		public virtual RSystem.RInt32 RF__0__UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__completedAnimationCount__1__k__BackingField
		{
			get
			{
				if(r_F__0__UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__completedAnimationCount__1__k__BackingField == null)
				{
					r_F__0__UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__completedAnimationCount__1__k__BackingField = new(this, "<UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount>k__BackingField");
					r_F__0__UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__completedAnimationCount__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__completedAnimationCount__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.UInt32 s_NextId
		/// </summary>
		protected static RSystem.RUInt32 r_Fs_NextId;
		public static RSystem.RUInt32 RFs_NextId
		{
			get
			{
				if(r_Fs_NextId == null)
				{
					r_Fs_NextId = new(typeof(UnityEngine.UIElements.VisualElement), "s_NextId");
					r_Fs_NextId.SetBelong(null);
				}
				return r_Fs_NextId;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] s_EmptyClassList
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RList<RSystem.RString> r_Fs_EmptyClassList;
		public static RSystem.RCollections.RGeneric.RList<RSystem.RString> RFs_EmptyClassList
		{
			get
			{
				if(r_Fs_EmptyClassList == null)
				{
					r_Fs_EmptyClassList = new(typeof(UnityEngine.UIElements.VisualElement), "s_EmptyClassList");
					r_Fs_EmptyClassList.SetBelong(null);
				}
				return r_Fs_EmptyClassList;
			}
		}

		/// <summary>
		/// UnityEngine.PropertyName userDataPropertyKey
		/// </summary>
		protected static RUnityEngine.RPropertyName r_FuserDataPropertyKey;
		public static RUnityEngine.RPropertyName RFuserDataPropertyKey
		{
			get
			{
				if(r_FuserDataPropertyKey == null)
				{
					r_FuserDataPropertyKey = new(typeof(UnityEngine.UIElements.VisualElement), "userDataPropertyKey");
					r_FuserDataPropertyKey.SetBelong(null);
				}
				return r_FuserDataPropertyKey;
			}
		}

		/// <summary>
		/// System.String disabledUssClassName
		/// </summary>
		protected static RSystem.RString r_FdisabledUssClassName;
		public static RSystem.RString RFdisabledUssClassName
		{
			get
			{
				if(r_FdisabledUssClassName == null)
				{
					r_FdisabledUssClassName = new(typeof(UnityEngine.UIElements.VisualElement), "disabledUssClassName");
					r_FdisabledUssClassName.SetBelong(null);
				}
				return r_FdisabledUssClassName;
			}
		}

		/// <summary>
		/// System.String m_Name
		/// </summary>
		protected RSystem.RString r_Fm_Name;
		public virtual RSystem.RString RFm_Name
		{
			get
			{
				if(r_Fm_Name == null)
				{
					r_Fm_Name = new(this, "m_Name");
					r_Fm_Name.SetBelong(this.instance);
				}
				return r_Fm_Name;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_ClassList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RString> r_Fm_ClassList;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RString> RFm_ClassList
		{
			get
			{
				if(r_Fm_ClassList == null)
				{
					r_Fm_ClassList = new(this, "m_ClassList");
					r_Fm_ClassList.SetBelong(this.instance);
				}
				return r_Fm_ClassList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Collections.Generic.KeyValuePair`2[UnityEngine.PropertyName,System.Object]] m_PropertyBag
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RCollections.RGeneric.RKeyValuePair<RUnityEngine.RPropertyName, RSystem.RObject>> r_Fm_PropertyBag;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RCollections.RGeneric.RKeyValuePair<RUnityEngine.RPropertyName, RSystem.RObject>> RFm_PropertyBag
		{
			get
			{
				if(r_Fm_PropertyBag == null)
				{
					r_Fm_PropertyBag = new(this, "m_PropertyBag");
					r_Fm_PropertyBag.SetBelong(this.instance);
				}
				return r_Fm_PropertyBag;
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
		/// System.String m_ViewDataKey
		/// </summary>
		protected RSystem.RString r_Fm_ViewDataKey;
		public virtual RSystem.RString RFm_ViewDataKey
		{
			get
			{
				if(r_Fm_ViewDataKey == null)
				{
					r_Fm_ViewDataKey = new(this, "m_ViewDataKey");
					r_Fm_ViewDataKey.SetBelong(this.instance);
				}
				return r_Fm_ViewDataKey;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.RenderHints m_RenderHints
		/// </summary>
		protected RUnityEngine.RUIElements.RRenderHints r_Fm_RenderHints;
		public virtual RUnityEngine.RUIElements.RRenderHints RFm_RenderHints
		{
			get
			{
				if(r_Fm_RenderHints == null)
				{
					r_Fm_RenderHints = new(this, "m_RenderHints");
					r_Fm_RenderHints.SetBelong(this.instance);
				}
				return r_Fm_RenderHints;
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
		/// UnityEngine.Rect m_Layout
		/// </summary>
		protected RUnityEngine.RRect r_Fm_Layout;
		public virtual RUnityEngine.RRect RFm_Layout
		{
			get
			{
				if(r_Fm_Layout == null)
				{
					r_Fm_Layout = new(this, "m_Layout");
					r_Fm_Layout.SetBelong(this.instance);
				}
				return r_Fm_Layout;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_BoundingBox
		/// </summary>
		protected RUnityEngine.RRect r_Fm_BoundingBox;
		public virtual RUnityEngine.RRect RFm_BoundingBox
		{
			get
			{
				if(r_Fm_BoundingBox == null)
				{
					r_Fm_BoundingBox = new(this, "m_BoundingBox");
					r_Fm_BoundingBox.SetBelong(this.instance);
				}
				return r_Fm_BoundingBox;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags worldBoundingBoxDirtyDependencies
		/// </summary>
		protected static RUnityEngine.RUIElements.RVisualElementFlags r_FworldBoundingBoxDirtyDependencies;
		public static RUnityEngine.RUIElements.RVisualElementFlags RFworldBoundingBoxDirtyDependencies
		{
			get
			{
				if(r_FworldBoundingBoxDirtyDependencies == null)
				{
					r_FworldBoundingBoxDirtyDependencies = new(typeof(UnityEngine.UIElements.VisualElement), "worldBoundingBoxDirtyDependencies");
					r_FworldBoundingBoxDirtyDependencies.SetBelong(null);
				}
				return r_FworldBoundingBoxDirtyDependencies;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_WorldBoundingBox
		/// </summary>
		protected RUnityEngine.RRect r_Fm_WorldBoundingBox;
		public virtual RUnityEngine.RRect RFm_WorldBoundingBox
		{
			get
			{
				if(r_Fm_WorldBoundingBox == null)
				{
					r_Fm_WorldBoundingBox = new(this, "m_WorldBoundingBox");
					r_Fm_WorldBoundingBox.SetBelong(this.instance);
				}
				return r_Fm_WorldBoundingBox;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags worldTransformInverseDirtyDependencies
		/// </summary>
		protected static RUnityEngine.RUIElements.RVisualElementFlags r_FworldTransformInverseDirtyDependencies;
		public static RUnityEngine.RUIElements.RVisualElementFlags RFworldTransformInverseDirtyDependencies
		{
			get
			{
				if(r_FworldTransformInverseDirtyDependencies == null)
				{
					r_FworldTransformInverseDirtyDependencies = new(typeof(UnityEngine.UIElements.VisualElement), "worldTransformInverseDirtyDependencies");
					r_FworldTransformInverseDirtyDependencies.SetBelong(null);
				}
				return r_FworldTransformInverseDirtyDependencies;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 m_WorldTransformCache
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_Fm_WorldTransformCache;
		public virtual RUnityEngine.RMatrix4x4 RFm_WorldTransformCache
		{
			get
			{
				if(r_Fm_WorldTransformCache == null)
				{
					r_Fm_WorldTransformCache = new(this, "m_WorldTransformCache");
					r_Fm_WorldTransformCache.SetBelong(this.instance);
				}
				return r_Fm_WorldTransformCache;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 m_WorldTransformInverseCache
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_Fm_WorldTransformInverseCache;
		public virtual RUnityEngine.RMatrix4x4 RFm_WorldTransformInverseCache
		{
			get
			{
				if(r_Fm_WorldTransformInverseCache == null)
				{
					r_Fm_WorldTransformInverseCache = new(this, "m_WorldTransformInverseCache");
					r_Fm_WorldTransformInverseCache.SetBelong(this.instance);
				}
				return r_Fm_WorldTransformInverseCache;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_WorldClip
		/// </summary>
		protected RUnityEngine.RRect r_Fm_WorldClip;
		public virtual RUnityEngine.RRect RFm_WorldClip
		{
			get
			{
				if(r_Fm_WorldClip == null)
				{
					r_Fm_WorldClip = new(this, "m_WorldClip");
					r_Fm_WorldClip.SetBelong(this.instance);
				}
				return r_Fm_WorldClip;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_WorldClipMinusGroup
		/// </summary>
		protected RUnityEngine.RRect r_Fm_WorldClipMinusGroup;
		public virtual RUnityEngine.RRect RFm_WorldClipMinusGroup
		{
			get
			{
				if(r_Fm_WorldClipMinusGroup == null)
				{
					r_Fm_WorldClipMinusGroup = new(this, "m_WorldClipMinusGroup");
					r_Fm_WorldClipMinusGroup.SetBelong(this.instance);
				}
				return r_Fm_WorldClipMinusGroup;
			}
		}

		/// <summary>
		/// System.Boolean m_WorldClipIsInfinite
		/// </summary>
		protected RSystem.RBoolean r_Fm_WorldClipIsInfinite;
		public virtual RSystem.RBoolean RFm_WorldClipIsInfinite
		{
			get
			{
				if(r_Fm_WorldClipIsInfinite == null)
				{
					r_Fm_WorldClipIsInfinite = new(this, "m_WorldClipIsInfinite");
					r_Fm_WorldClipIsInfinite.SetBelong(this.instance);
				}
				return r_Fm_WorldClipIsInfinite;
			}
		}

		/// <summary>
		/// UnityEngine.Rect s_InfiniteRect
		/// </summary>
		protected static RUnityEngine.RRect r_Fs_InfiniteRect;
		public static RUnityEngine.RRect RFs_InfiniteRect
		{
			get
			{
				if(r_Fs_InfiniteRect == null)
				{
					r_Fs_InfiniteRect = new(typeof(UnityEngine.UIElements.VisualElement), "s_InfiniteRect");
					r_Fs_InfiniteRect.SetBelong(null);
				}
				return r_Fs_InfiniteRect;
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
		/// UnityEngine.UIElements.PseudoStates m_PseudoStates
		/// </summary>
		protected RUnityEngine.RUIElements.RPseudoStates r_Fm_PseudoStates;
		public virtual RUnityEngine.RUIElements.RPseudoStates RFm_PseudoStates
		{
			get
			{
				if(r_Fm_PseudoStates == null)
				{
					r_Fm_PseudoStates = new(this, "m_PseudoStates");
					r_Fm_PseudoStates.SetBelong(this.instance);
				}
				return r_Fm_PseudoStates;
			}
		}

		/// <summary>
		/// System.Int32 <containedPointerIds>k__BackingField
		/// </summary>
		protected RSystem.RInt32 r_F__0__containedPointerIds__1__k__BackingField;
		public virtual RSystem.RInt32 RF__0__containedPointerIds__1__k__BackingField
		{
			get
			{
				if(r_F__0__containedPointerIds__1__k__BackingField == null)
				{
					r_F__0__containedPointerIds__1__k__BackingField = new(this, "<containedPointerIds>k__BackingField");
					r_F__0__containedPointerIds__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__containedPointerIds__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PickingMode <pickingMode>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RPickingMode r_F__0__pickingMode__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RPickingMode RF__0__pickingMode__1__k__BackingField
		{
			get
			{
				if(r_F__0__pickingMode__1__k__BackingField == null)
				{
					r_F__0__pickingMode__1__k__BackingField = new(this, "<pickingMode>k__BackingField");
					r_F__0__pickingMode__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__pickingMode__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaNode <yogaNode>k__BackingField
		/// </summary>
		protected RUnityEngine.RYoga.RYogaNode r_F__0__yogaNode__1__k__BackingField;
		public virtual RUnityEngine.RYoga.RYogaNode RF__0__yogaNode__1__k__BackingField
		{
			get
			{
				if(r_F__0__yogaNode__1__k__BackingField == null)
				{
					r_F__0__yogaNode__1__k__BackingField = new(this, "<yogaNode>k__BackingField");
					r_F__0__yogaNode__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__yogaNode__1__k__BackingField;
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
		/// System.Boolean <enabledSelf>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r_F__0__enabledSelf__1__k__BackingField;
		public virtual RSystem.RBoolean RF__0__enabledSelf__1__k__BackingField
		{
			get
			{
				if(r_F__0__enabledSelf__1__k__BackingField == null)
				{
					r_F__0__enabledSelf__1__k__BackingField = new(this, "<enabledSelf>k__BackingField");
					r_F__0__enabledSelf__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__enabledSelf__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.MeshGenerationContext] <generateVisualContent>k__BackingField
		/// </summary>
		protected RSystem.RAction<RUnityEngine.RUIElements.RMeshGenerationContext> r_F__0__generateVisualContent__1__k__BackingField;
		public virtual RSystem.RAction<RUnityEngine.RUIElements.RMeshGenerationContext> RF__0__generateVisualContent__1__k__BackingField
		{
			get
			{
				if(r_F__0__generateVisualContent__1__k__BackingField == null)
				{
					r_F__0__generateVisualContent__1__k__BackingField = new(this, "<generateVisualContent>k__BackingField");
					r_F__0__generateVisualContent__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__generateVisualContent__1__k__BackingField;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_GenerateVisualContentMarker
		/// </summary>
		protected RUnity.RProfiling.RProfilerMarker r_Fk_GenerateVisualContentMarker;
		public virtual RUnity.RProfiling.RProfilerMarker RFk_GenerateVisualContentMarker
		{
			get
			{
				if(r_Fk_GenerateVisualContentMarker == null)
				{
					r_Fk_GenerateVisualContentMarker = new(this, "k_GenerateVisualContentMarker");
					r_Fk_GenerateVisualContentMarker.SetBelong(this.instance);
				}
				return r_Fk_GenerateVisualContentMarker;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement+RenderTargetMode m_SubRenderTargetMode
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement.RRenderTargetMode r_Fm_SubRenderTargetMode;
		public virtual RUnityEngine.RUIElements.RVisualElement.RRenderTargetMode RFm_SubRenderTargetMode
		{
			get
			{
				if(r_Fm_SubRenderTargetMode == null)
				{
					r_Fm_SubRenderTargetMode = new(this, "m_SubRenderTargetMode");
					r_Fm_SubRenderTargetMode.SetBelong(this.instance);
				}
				return r_Fm_SubRenderTargetMode;
			}
		}

		/// <summary>
		/// UnityEngine.Material s_runtimeMaterial
		/// </summary>
		protected static RUnityEngine.RMaterial r_Fs_runtimeMaterial;
		public static RUnityEngine.RMaterial RFs_runtimeMaterial
		{
			get
			{
				if(r_Fs_runtimeMaterial == null)
				{
					r_Fs_runtimeMaterial = new(typeof(UnityEngine.UIElements.VisualElement), "s_runtimeMaterial");
					r_Fs_runtimeMaterial.SetBelong(null);
				}
				return r_Fs_runtimeMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material m_defaultMaterial
		/// </summary>
		protected RUnityEngine.RMaterial r_Fm_defaultMaterial;
		public virtual RUnityEngine.RMaterial RFm_defaultMaterial
		{
			get
			{
				if(r_Fm_defaultMaterial == null)
				{
					r_Fm_defaultMaterial = new(this, "m_defaultMaterial");
					r_Fm_defaultMaterial.SetBelong(this.instance);
				}
				return r_Fm_defaultMaterial;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.Experimental.IValueAnimationUpdate] m_RunningAnimations
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate> r_Fm_RunningAnimations;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate> RFm_RunningAnimations
		{
			get
			{
				if(r_Fm_RunningAnimations == null)
				{
					r_Fm_RunningAnimations = new(this, "m_RunningAnimations");
					r_Fm_RunningAnimations.SetBelong(this.instance);
				}
				return r_Fm_RunningAnimations;
			}
		}

		/// <summary>
		/// System.UInt32 s_NextParentVersion
		/// </summary>
		protected static RSystem.RUInt32 r_Fs_NextParentVersion;
		public static RSystem.RUInt32 RFs_NextParentVersion
		{
			get
			{
				if(r_Fs_NextParentVersion == null)
				{
					r_Fs_NextParentVersion = new(typeof(UnityEngine.UIElements.VisualElement), "s_NextParentVersion");
					r_Fs_NextParentVersion.SetBelong(null);
				}
				return r_Fs_NextParentVersion;
			}
		}

		/// <summary>
		/// System.UInt32 m_NextParentCachedVersion
		/// </summary>
		protected RSystem.RUInt32 r_Fm_NextParentCachedVersion;
		public virtual RSystem.RUInt32 RFm_NextParentCachedVersion
		{
			get
			{
				if(r_Fm_NextParentCachedVersion == null)
				{
					r_Fm_NextParentCachedVersion = new(this, "m_NextParentCachedVersion");
					r_Fm_NextParentCachedVersion.SetBelong(this.instance);
				}
				return r_Fm_NextParentCachedVersion;
			}
		}

		/// <summary>
		/// System.UInt32 m_NextParentRequiredVersion
		/// </summary>
		protected RSystem.RUInt32 r_Fm_NextParentRequiredVersion;
		public virtual RSystem.RUInt32 RFm_NextParentRequiredVersion
		{
			get
			{
				if(r_Fm_NextParentRequiredVersion == null)
				{
					r_Fm_NextParentRequiredVersion = new(this, "m_NextParentRequiredVersion");
					r_Fm_NextParentRequiredVersion.SetBelong(this.instance);
				}
				return r_Fm_NextParentRequiredVersion;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_CachedNextParentWithEventCallback
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_Fm_CachedNextParentWithEventCallback;
		public virtual RUnityEngine.RUIElements.RVisualElement RFm_CachedNextParentWithEventCallback
		{
			get
			{
				if(r_Fm_CachedNextParentWithEventCallback == null)
				{
					r_Fm_CachedNextParentWithEventCallback = new(this, "m_CachedNextParentWithEventCallback");
					r_Fm_CachedNextParentWithEventCallback.SetBelong(this.instance);
				}
				return r_Fm_CachedNextParentWithEventCallback;
			}
		}

		/// <summary>
		/// System.Int32 m_EventCallbackCategories
		/// </summary>
		protected RSystem.RInt32 r_Fm_EventCallbackCategories;
		public virtual RSystem.RInt32 RFm_EventCallbackCategories
		{
			get
			{
				if(r_Fm_EventCallbackCategories == null)
				{
					r_Fm_EventCallbackCategories = new(this, "m_EventCallbackCategories");
					r_Fm_EventCallbackCategories.SetBelong(this.instance);
				}
				return r_Fm_EventCallbackCategories;
			}
		}

		/// <summary>
		/// System.Int32 m_CachedEventCallbackParentCategories
		/// </summary>
		protected RSystem.RInt32 r_Fm_CachedEventCallbackParentCategories;
		public virtual RSystem.RInt32 RFm_CachedEventCallbackParentCategories
		{
			get
			{
				if(r_Fm_CachedEventCallbackParentCategories == null)
				{
					r_Fm_CachedEventCallbackParentCategories = new(this, "m_CachedEventCallbackParentCategories");
					r_Fm_CachedEventCallbackParentCategories.SetBelong(this.instance);
				}
				return r_Fm_CachedEventCallbackParentCategories;
			}
		}

		/// <summary>
		/// System.Int32 m_DefaultActionEventCategories
		/// </summary>
		protected RSystem.RInt32 r_Fm_DefaultActionEventCategories;
		public virtual RSystem.RInt32 RFm_DefaultActionEventCategories
		{
			get
			{
				if(r_Fm_DefaultActionEventCategories == null)
				{
					r_Fm_DefaultActionEventCategories = new(this, "m_DefaultActionEventCategories");
					r_Fm_DefaultActionEventCategories.SetBelong(this.instance);
				}
				return r_Fm_DefaultActionEventCategories;
			}
		}

		/// <summary>
		/// System.Int32 m_DefaultActionAtTargetEventCategories
		/// </summary>
		protected RSystem.RInt32 r_Fm_DefaultActionAtTargetEventCategories;
		public virtual RSystem.RInt32 RFm_DefaultActionAtTargetEventCategories
		{
			get
			{
				if(r_Fm_DefaultActionAtTargetEventCategories == null)
				{
					r_Fm_DefaultActionAtTargetEventCategories = new(this, "m_DefaultActionAtTargetEventCategories");
					r_Fm_DefaultActionAtTargetEventCategories.SetBelong(this.instance);
				}
				return r_Fm_DefaultActionAtTargetEventCategories;
			}
		}

		/// <summary>
		/// System.String k_RootVisualContainerName
		/// </summary>
		protected static RSystem.RString r_Fk_RootVisualContainerName;
		public static RSystem.RString RFk_RootVisualContainerName
		{
			get
			{
				if(r_Fk_RootVisualContainerName == null)
				{
					r_Fk_RootVisualContainerName = new(typeof(UnityEngine.UIElements.VisualElement), "k_RootVisualContainerName");
					r_Fk_RootVisualContainerName.SetBelong(null);
				}
				return r_Fk_RootVisualContainerName;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement+Hierarchy <hierarchy>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement.RHierarchy r_F__0__hierarchy__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RVisualElement.RHierarchy RF__0__hierarchy__1__k__BackingField
		{
			get
			{
				if(r_F__0__hierarchy__1__k__BackingField == null)
				{
					r_F__0__hierarchy__1__k__BackingField = new(this, "<hierarchy>k__BackingField");
					r_F__0__hierarchy__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__hierarchy__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <isRootVisualContainer>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r_F__0__isRootVisualContainer__1__k__BackingField;
		public virtual RSystem.RBoolean RF__0__isRootVisualContainer__1__k__BackingField
		{
			get
			{
				if(r_F__0__isRootVisualContainer__1__k__BackingField == null)
				{
					r_F__0__isRootVisualContainer__1__k__BackingField = new(this, "<isRootVisualContainer>k__BackingField");
					r_F__0__isRootVisualContainer__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__isRootVisualContainer__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <cacheAsBitmap>k__BackingField
		/// </summary>
		protected RSystem.RBoolean r_F__0__cacheAsBitmap__1__k__BackingField;
		public virtual RSystem.RBoolean RF__0__cacheAsBitmap__1__k__BackingField
		{
			get
			{
				if(r_F__0__cacheAsBitmap__1__k__BackingField == null)
				{
					r_F__0__cacheAsBitmap__1__k__BackingField = new(this, "<cacheAsBitmap>k__BackingField");
					r_F__0__cacheAsBitmap__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__cacheAsBitmap__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_PhysicalParent
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_Fm_PhysicalParent;
		public virtual RUnityEngine.RUIElements.RVisualElement RFm_PhysicalParent
		{
			get
			{
				if(r_Fm_PhysicalParent == null)
				{
					r_Fm_PhysicalParent = new(this, "m_PhysicalParent");
					r_Fm_PhysicalParent.SetBelong(this.instance);
				}
				return r_Fm_PhysicalParent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_LogicalParent
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_Fm_LogicalParent;
		public virtual RUnityEngine.RUIElements.RVisualElement RFm_LogicalParent
		{
			get
			{
				if(r_Fm_LogicalParent == null)
				{
					r_Fm_LogicalParent = new(this, "m_LogicalParent");
					r_Fm_LogicalParent.SetBelong(this.instance);
				}
				return r_Fm_LogicalParent;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement] s_EmptyList
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElement> r_Fs_EmptyList;
		public static RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElement> RFs_EmptyList
		{
			get
			{
				if(r_Fs_EmptyList == null)
				{
					r_Fs_EmptyList = new(typeof(UnityEngine.UIElements.VisualElement), "s_EmptyList");
					r_Fs_EmptyList.SetBelong(null);
				}
				return r_Fs_EmptyList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement] m_Children
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElement> r_Fm_Children;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElement> RFm_Children
		{
			get
			{
				if(r_Fm_Children == null)
				{
					r_Fm_Children = new(this, "m_Children");
					r_Fm_Children.SetBelong(this.instance);
				}
				return r_Fm_Children;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseVisualElementPanel <elementPanel>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RBaseVisualElementPanel r_F__0__elementPanel__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RBaseVisualElementPanel RF__0__elementPanel__1__k__BackingField
		{
			get
			{
				if(r_F__0__elementPanel__1__k__BackingField == null)
				{
					r_F__0__elementPanel__1__k__BackingField = new(this, "<elementPanel>k__BackingField");
					r_F__0__elementPanel__1__k__BackingField.SetBelong(this.instance);
				}
				return r_F__0__elementPanel__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset m_VisualTreeAssetSource
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualTreeAsset r_Fm_VisualTreeAssetSource;
		public virtual RUnityEngine.RUIElements.RVisualTreeAsset RFm_VisualTreeAssetSource
		{
			get
			{
				if(r_Fm_VisualTreeAssetSource == null)
				{
					r_Fm_VisualTreeAssetSource = new(this, "m_VisualTreeAssetSource");
					r_Fm_VisualTreeAssetSource.SetBelong(this.instance);
				}
				return r_Fm_VisualTreeAssetSource;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement+CustomStyleAccess s_CustomStyleAccess
		/// </summary>
		protected static RUnityEngine.RUIElements.RVisualElement.RCustomStyleAccess r_Fs_CustomStyleAccess;
		public static RUnityEngine.RUIElements.RVisualElement.RCustomStyleAccess RFs_CustomStyleAccess
		{
			get
			{
				if(r_Fs_CustomStyleAccess == null)
				{
					r_Fs_CustomStyleAccess = new(typeof(UnityEngine.UIElements.VisualElement), "s_CustomStyleAccess");
					r_Fs_CustomStyleAccess.SetBelong(null);
				}
				return r_Fs_CustomStyleAccess;
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
		/// System.Text.RegularExpressions.Regex s_InternalStyleSheetPath
		/// </summary>
		protected static RSystem.RText.RRegularExpressions.RRegex r_Fs_InternalStyleSheetPath;
		public static RSystem.RText.RRegularExpressions.RRegex RFs_InternalStyleSheetPath
		{
			get
			{
				if(r_Fs_InternalStyleSheetPath == null)
				{
					r_Fs_InternalStyleSheetPath = new(typeof(UnityEngine.UIElements.VisualElement), "s_InternalStyleSheetPath");
					r_Fs_InternalStyleSheetPath.SetBelong(null);
				}
				return r_Fs_InternalStyleSheetPath;
			}
		}

		/// <summary>
		/// UnityEngine.PropertyName tooltipPropertyKey
		/// </summary>
		protected static RUnityEngine.RPropertyName r_FtooltipPropertyKey;
		public static RUnityEngine.RPropertyName RFtooltipPropertyKey
		{
			get
			{
				if(r_FtooltipPropertyKey == null)
				{
					r_FtooltipPropertyKey = new(typeof(UnityEngine.UIElements.VisualElement), "tooltipPropertyKey");
					r_FtooltipPropertyKey.SetBelong(null);
				}
				return r_FtooltipPropertyKey;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Type,UnityEngine.UIElements.VisualElement+TypeData] s_TypeData
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RSystem.RType, RUnityEngine.RUIElements.RVisualElement.RTypeData> r_Fs_TypeData;
		public static RSystem.RCollections.RGeneric.RDictionary<RSystem.RType, RUnityEngine.RUIElements.RVisualElement.RTypeData> RFs_TypeData
		{
			get
			{
				if(r_Fs_TypeData == null)
				{
					r_Fs_TypeData = new(typeof(UnityEngine.UIElements.VisualElement), "s_TypeData");
					r_Fs_TypeData.SetBelong(null);
				}
				return r_Fs_TypeData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement+TypeData m_TypeData
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement.RTypeData r_Fm_TypeData;
		public virtual RUnityEngine.RUIElements.RVisualElement.RTypeData RFm_TypeData
		{
			get
			{
				if(r_Fm_TypeData == null)
				{
					r_Fm_TypeData = new(this, "m_TypeData");
					r_Fm_TypeData.SetBelong(this.instance);
				}
				return r_Fm_TypeData;
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
		/// UnityEngine.UIElements.Align UnityEngine.UIElements.IResolvedStyle.alignContent
		/// </summary>
		protected RUnityEngine.RUIElements.RAlign r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignContent;
		public virtual RUnityEngine.RUIElements.RAlign RPUnityEngine__2__UIElements__2__IResolvedStyle__2__alignContent
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignContent == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignContent = new(this, "UnityEngine.UIElements.IResolvedStyle.alignContent", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignContent.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Align UnityEngine.UIElements.IResolvedStyle.alignItems
		/// </summary>
		protected RUnityEngine.RUIElements.RAlign r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignItems;
		public virtual RUnityEngine.RUIElements.RAlign RPUnityEngine__2__UIElements__2__IResolvedStyle__2__alignItems
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignItems == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignItems = new(this, "UnityEngine.UIElements.IResolvedStyle.alignItems", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignItems.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignItems;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Align UnityEngine.UIElements.IResolvedStyle.alignSelf
		/// </summary>
		protected RUnityEngine.RUIElements.RAlign r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignSelf;
		public virtual RUnityEngine.RUIElements.RAlign RPUnityEngine__2__UIElements__2__IResolvedStyle__2__alignSelf
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignSelf == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignSelf = new(this, "UnityEngine.UIElements.IResolvedStyle.alignSelf", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignSelf.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignSelf;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.backgroundColor
		/// </summary>
		protected RUnityEngine.RColor r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundColor;
		public virtual RUnityEngine.RColor RPUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundColor == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundColor = new(this, "UnityEngine.UIElements.IResolvedStyle.backgroundColor", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundColor.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Background UnityEngine.UIElements.IResolvedStyle.backgroundImage
		/// </summary>
		protected RUnityEngine.RUIElements.RBackground r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundImage;
		public virtual RUnityEngine.RUIElements.RBackground RPUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundImage
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundImage == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundImage = new(this, "UnityEngine.UIElements.IResolvedStyle.backgroundImage", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundImage.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundImage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition UnityEngine.UIElements.IResolvedStyle.backgroundPositionX
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundPosition r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundPositionX;
		public virtual RUnityEngine.RUIElements.RBackgroundPosition RPUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundPositionX
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundPositionX == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundPositionX = new(this, "UnityEngine.UIElements.IResolvedStyle.backgroundPositionX", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundPositionX.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundPositionX;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition UnityEngine.UIElements.IResolvedStyle.backgroundPositionY
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundPosition r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundPositionY;
		public virtual RUnityEngine.RUIElements.RBackgroundPosition RPUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundPositionY
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundPositionY == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundPositionY = new(this, "UnityEngine.UIElements.IResolvedStyle.backgroundPositionY", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundPositionY.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundPositionY;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundRepeat UnityEngine.UIElements.IResolvedStyle.backgroundRepeat
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundRepeat r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundRepeat;
		public virtual RUnityEngine.RUIElements.RBackgroundRepeat RPUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundRepeat
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundRepeat == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundRepeat = new(this, "UnityEngine.UIElements.IResolvedStyle.backgroundRepeat", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundRepeat.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundRepeat;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundSize UnityEngine.UIElements.IResolvedStyle.backgroundSize
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundSize r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundSize;
		public virtual RUnityEngine.RUIElements.RBackgroundSize RPUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundSize
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundSize == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundSize = new(this, "UnityEngine.UIElements.IResolvedStyle.backgroundSize", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundSize.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.borderBottomColor
		/// </summary>
		protected RUnityEngine.RColor r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomColor;
		public virtual RUnityEngine.RColor RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomColor == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomColor = new(this, "UnityEngine.UIElements.IResolvedStyle.borderBottomColor", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomColor.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomColor;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderBottomLeftRadius
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomLeftRadius;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomLeftRadius
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomLeftRadius == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomLeftRadius = new(this, "UnityEngine.UIElements.IResolvedStyle.borderBottomLeftRadius", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomLeftRadius.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomLeftRadius;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderBottomRightRadius
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomRightRadius;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomRightRadius
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomRightRadius == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomRightRadius = new(this, "UnityEngine.UIElements.IResolvedStyle.borderBottomRightRadius", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomRightRadius.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomRightRadius;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderBottomWidth
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomWidth;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomWidth
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomWidth == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomWidth = new(this, "UnityEngine.UIElements.IResolvedStyle.borderBottomWidth", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomWidth.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.borderLeftColor
		/// </summary>
		protected RUnityEngine.RColor r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderLeftColor;
		public virtual RUnityEngine.RColor RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderLeftColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderLeftColor == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderLeftColor = new(this, "UnityEngine.UIElements.IResolvedStyle.borderLeftColor", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderLeftColor.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderLeftColor;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderLeftWidth
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderLeftWidth;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderLeftWidth
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderLeftWidth == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderLeftWidth = new(this, "UnityEngine.UIElements.IResolvedStyle.borderLeftWidth", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderLeftWidth.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderLeftWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.borderRightColor
		/// </summary>
		protected RUnityEngine.RColor r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderRightColor;
		public virtual RUnityEngine.RColor RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderRightColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderRightColor == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderRightColor = new(this, "UnityEngine.UIElements.IResolvedStyle.borderRightColor", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderRightColor.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderRightColor;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderRightWidth
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderRightWidth;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderRightWidth
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderRightWidth == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderRightWidth = new(this, "UnityEngine.UIElements.IResolvedStyle.borderRightWidth", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderRightWidth.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderRightWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.borderTopColor
		/// </summary>
		protected RUnityEngine.RColor r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopColor;
		public virtual RUnityEngine.RColor RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopColor == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopColor = new(this, "UnityEngine.UIElements.IResolvedStyle.borderTopColor", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopColor.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopColor;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderTopLeftRadius
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopLeftRadius;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopLeftRadius
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopLeftRadius == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopLeftRadius = new(this, "UnityEngine.UIElements.IResolvedStyle.borderTopLeftRadius", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopLeftRadius.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopLeftRadius;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderTopRightRadius
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopRightRadius;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopRightRadius
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopRightRadius == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopRightRadius = new(this, "UnityEngine.UIElements.IResolvedStyle.borderTopRightRadius", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopRightRadius.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopRightRadius;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderTopWidth
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopWidth;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopWidth
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopWidth == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopWidth = new(this, "UnityEngine.UIElements.IResolvedStyle.borderTopWidth", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopWidth.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopWidth;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.bottom
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__bottom;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__bottom
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__bottom == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__bottom = new(this, "UnityEngine.UIElements.IResolvedStyle.bottom", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__bottom.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__bottom;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.color
		/// </summary>
		protected RUnityEngine.RColor r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__color;
		public virtual RUnityEngine.RColor RPUnityEngine__2__UIElements__2__IResolvedStyle__2__color
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__color == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__color = new(this, "UnityEngine.UIElements.IResolvedStyle.color", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__color.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__color;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DisplayStyle UnityEngine.UIElements.IResolvedStyle.display
		/// </summary>
		protected RUnityEngine.RUIElements.RDisplayStyle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__display;
		public virtual RUnityEngine.RUIElements.RDisplayStyle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__display
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__display == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__display = new(this, "UnityEngine.UIElements.IResolvedStyle.display", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__display.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__display;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.flexBasis
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexBasis;
		public virtual RUnityEngine.RUIElements.RStyleFloat RPUnityEngine__2__UIElements__2__IResolvedStyle__2__flexBasis
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexBasis == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexBasis = new(this, "UnityEngine.UIElements.IResolvedStyle.flexBasis", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexBasis.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexBasis;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FlexDirection UnityEngine.UIElements.IResolvedStyle.flexDirection
		/// </summary>
		protected RUnityEngine.RUIElements.RFlexDirection r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexDirection;
		public virtual RUnityEngine.RUIElements.RFlexDirection RPUnityEngine__2__UIElements__2__IResolvedStyle__2__flexDirection
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexDirection == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexDirection = new(this, "UnityEngine.UIElements.IResolvedStyle.flexDirection", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexDirection.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexDirection;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.flexGrow
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexGrow;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__flexGrow
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexGrow == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexGrow = new(this, "UnityEngine.UIElements.IResolvedStyle.flexGrow", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexGrow.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexGrow;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.flexShrink
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexShrink;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__flexShrink
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexShrink == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexShrink = new(this, "UnityEngine.UIElements.IResolvedStyle.flexShrink", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexShrink.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexShrink;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Wrap UnityEngine.UIElements.IResolvedStyle.flexWrap
		/// </summary>
		protected RUnityEngine.RUIElements.RWrap r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexWrap;
		public virtual RUnityEngine.RUIElements.RWrap RPUnityEngine__2__UIElements__2__IResolvedStyle__2__flexWrap
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexWrap == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexWrap = new(this, "UnityEngine.UIElements.IResolvedStyle.flexWrap", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexWrap.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexWrap;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.fontSize
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__fontSize;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__fontSize
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__fontSize == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__fontSize = new(this, "UnityEngine.UIElements.IResolvedStyle.fontSize", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__fontSize.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__fontSize;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.height
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__height;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__height
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__height == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__height = new(this, "UnityEngine.UIElements.IResolvedStyle.height", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__height.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__height;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Justify UnityEngine.UIElements.IResolvedStyle.justifyContent
		/// </summary>
		protected RUnityEngine.RUIElements.RJustify r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__justifyContent;
		public virtual RUnityEngine.RUIElements.RJustify RPUnityEngine__2__UIElements__2__IResolvedStyle__2__justifyContent
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__justifyContent == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__justifyContent = new(this, "UnityEngine.UIElements.IResolvedStyle.justifyContent", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__justifyContent.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__justifyContent;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.left
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__left;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__left
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__left == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__left = new(this, "UnityEngine.UIElements.IResolvedStyle.left", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__left.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__left;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.letterSpacing
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__letterSpacing;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__letterSpacing
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__letterSpacing == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__letterSpacing = new(this, "UnityEngine.UIElements.IResolvedStyle.letterSpacing", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__letterSpacing.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__letterSpacing;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.marginBottom
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginBottom;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__marginBottom
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginBottom == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginBottom = new(this, "UnityEngine.UIElements.IResolvedStyle.marginBottom", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginBottom.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginBottom;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.marginLeft
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginLeft;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__marginLeft
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginLeft == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginLeft = new(this, "UnityEngine.UIElements.IResolvedStyle.marginLeft", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginLeft.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginLeft;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.marginRight
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginRight;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__marginRight
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginRight == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginRight = new(this, "UnityEngine.UIElements.IResolvedStyle.marginRight", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginRight.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginRight;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.marginTop
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginTop;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__marginTop
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginTop == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginTop = new(this, "UnityEngine.UIElements.IResolvedStyle.marginTop", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginTop.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.maxHeight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__maxHeight;
		public virtual RUnityEngine.RUIElements.RStyleFloat RPUnityEngine__2__UIElements__2__IResolvedStyle__2__maxHeight
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__maxHeight == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__maxHeight = new(this, "UnityEngine.UIElements.IResolvedStyle.maxHeight", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__maxHeight.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__maxHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.maxWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__maxWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RPUnityEngine__2__UIElements__2__IResolvedStyle__2__maxWidth
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__maxWidth == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__maxWidth = new(this, "UnityEngine.UIElements.IResolvedStyle.maxWidth", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__maxWidth.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__maxWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.minHeight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__minHeight;
		public virtual RUnityEngine.RUIElements.RStyleFloat RPUnityEngine__2__UIElements__2__IResolvedStyle__2__minHeight
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__minHeight == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__minHeight = new(this, "UnityEngine.UIElements.IResolvedStyle.minHeight", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__minHeight.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__minHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.minWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__minWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RPUnityEngine__2__UIElements__2__IResolvedStyle__2__minWidth
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__minWidth == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__minWidth = new(this, "UnityEngine.UIElements.IResolvedStyle.minWidth", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__minWidth.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__minWidth;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.opacity
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__opacity;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__opacity
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__opacity == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__opacity = new(this, "UnityEngine.UIElements.IResolvedStyle.opacity", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__opacity.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__opacity;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.paddingBottom
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingBottom;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingBottom
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingBottom == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingBottom = new(this, "UnityEngine.UIElements.IResolvedStyle.paddingBottom", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingBottom.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingBottom;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.paddingLeft
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingLeft;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingLeft
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingLeft == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingLeft = new(this, "UnityEngine.UIElements.IResolvedStyle.paddingLeft", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingLeft.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingLeft;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.paddingRight
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingRight;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingRight
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingRight == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingRight = new(this, "UnityEngine.UIElements.IResolvedStyle.paddingRight", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingRight.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingRight;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.paddingTop
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingTop;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingTop
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingTop == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingTop = new(this, "UnityEngine.UIElements.IResolvedStyle.paddingTop", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingTop.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Position UnityEngine.UIElements.IResolvedStyle.position
		/// </summary>
		protected RUnityEngine.RUIElements.RPosition r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__position;
		public virtual RUnityEngine.RUIElements.RPosition RPUnityEngine__2__UIElements__2__IResolvedStyle__2__position
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__position == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__position = new(this, "UnityEngine.UIElements.IResolvedStyle.position", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__position.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__position;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.right
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__right;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__right
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__right == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__right = new(this, "UnityEngine.UIElements.IResolvedStyle.right", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__right.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__right;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Rotate UnityEngine.UIElements.IResolvedStyle.rotate
		/// </summary>
		protected RUnityEngine.RUIElements.RRotate r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__rotate;
		public virtual RUnityEngine.RUIElements.RRotate RPUnityEngine__2__UIElements__2__IResolvedStyle__2__rotate
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__rotate == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__rotate = new(this, "UnityEngine.UIElements.IResolvedStyle.rotate", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__rotate.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__rotate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Scale UnityEngine.UIElements.IResolvedStyle.scale
		/// </summary>
		protected RUnityEngine.RUIElements.RScale r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__scale;
		public virtual RUnityEngine.RUIElements.RScale RPUnityEngine__2__UIElements__2__IResolvedStyle__2__scale
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__scale == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__scale = new(this, "UnityEngine.UIElements.IResolvedStyle.scale", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__scale.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__scale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextOverflow UnityEngine.UIElements.IResolvedStyle.textOverflow
		/// </summary>
		protected RUnityEngine.RUIElements.RTextOverflow r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__textOverflow;
		public virtual RUnityEngine.RUIElements.RTextOverflow RPUnityEngine__2__UIElements__2__IResolvedStyle__2__textOverflow
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__textOverflow == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__textOverflow = new(this, "UnityEngine.UIElements.IResolvedStyle.textOverflow", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__textOverflow.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__textOverflow;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.top
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__top;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__top
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__top == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__top = new(this, "UnityEngine.UIElements.IResolvedStyle.top", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__top.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__top;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 UnityEngine.UIElements.IResolvedStyle.transformOrigin
		/// </summary>
		protected RUnityEngine.RVector3 r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transformOrigin;
		public virtual RUnityEngine.RVector3 RPUnityEngine__2__UIElements__2__IResolvedStyle__2__transformOrigin
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transformOrigin == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transformOrigin = new(this, "UnityEngine.UIElements.IResolvedStyle.transformOrigin", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transformOrigin.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transformOrigin;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.TimeValue] UnityEngine.UIElements.IResolvedStyle.transitionDelay
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RTimeValue> r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionDelay;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RTimeValue> RPUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionDelay
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionDelay == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionDelay = new(this, "UnityEngine.UIElements.IResolvedStyle.transitionDelay", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionDelay.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionDelay;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.TimeValue] UnityEngine.UIElements.IResolvedStyle.transitionDuration
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RTimeValue> r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionDuration;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RTimeValue> RPUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionDuration
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionDuration == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionDuration = new(this, "UnityEngine.UIElements.IResolvedStyle.transitionDuration", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionDuration.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionDuration;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.StylePropertyName] UnityEngine.UIElements.IResolvedStyle.transitionProperty
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RStylePropertyName> r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionProperty;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RStylePropertyName> RPUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionProperty
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionProperty == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionProperty = new(this, "UnityEngine.UIElements.IResolvedStyle.transitionProperty", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionProperty.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionProperty;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.EasingFunction] UnityEngine.UIElements.IResolvedStyle.transitionTimingFunction
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.REasingFunction> r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionTimingFunction;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.REasingFunction> RPUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionTimingFunction
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionTimingFunction == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionTimingFunction = new(this, "UnityEngine.UIElements.IResolvedStyle.transitionTimingFunction", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionTimingFunction.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionTimingFunction;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 UnityEngine.UIElements.IResolvedStyle.translate
		/// </summary>
		protected RUnityEngine.RVector3 r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__translate;
		public virtual RUnityEngine.RVector3 RPUnityEngine__2__UIElements__2__IResolvedStyle__2__translate
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__translate == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__translate = new(this, "UnityEngine.UIElements.IResolvedStyle.translate", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__translate.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__translate;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.unityBackgroundImageTintColor
		/// </summary>
		protected RUnityEngine.RColor r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityBackgroundImageTintColor;
		public virtual RUnityEngine.RColor RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unityBackgroundImageTintColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityBackgroundImageTintColor == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityBackgroundImageTintColor = new(this, "UnityEngine.UIElements.IResolvedStyle.unityBackgroundImageTintColor", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityBackgroundImageTintColor.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityBackgroundImageTintColor;
			}
		}

		/// <summary>
		/// UnityEngine.Font UnityEngine.UIElements.IResolvedStyle.unityFont
		/// </summary>
		protected RUnityEngine.RFont r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFont;
		public virtual RUnityEngine.RFont RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFont
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFont == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFont = new(this, "UnityEngine.UIElements.IResolvedStyle.unityFont", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFont.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFont;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FontDefinition UnityEngine.UIElements.IResolvedStyle.unityFontDefinition
		/// </summary>
		protected RUnityEngine.RUIElements.RFontDefinition r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFontDefinition;
		public virtual RUnityEngine.RUIElements.RFontDefinition RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFontDefinition
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFontDefinition == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFontDefinition = new(this, "UnityEngine.UIElements.IResolvedStyle.unityFontDefinition", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFontDefinition.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFontDefinition;
			}
		}

		/// <summary>
		/// UnityEngine.FontStyle UnityEngine.UIElements.IResolvedStyle.unityFontStyleAndWeight
		/// </summary>
		protected RUnityEngine.RFontStyle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFontStyleAndWeight;
		public virtual RUnityEngine.RFontStyle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFontStyleAndWeight
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFontStyleAndWeight == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFontStyleAndWeight = new(this, "UnityEngine.UIElements.IResolvedStyle.unityFontStyleAndWeight", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFontStyleAndWeight.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFontStyleAndWeight;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.unityParagraphSpacing
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityParagraphSpacing;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unityParagraphSpacing
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityParagraphSpacing == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityParagraphSpacing = new(this, "UnityEngine.UIElements.IResolvedStyle.unityParagraphSpacing", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityParagraphSpacing.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityParagraphSpacing;
			}
		}

		/// <summary>
		/// Int32 UnityEngine.UIElements.IResolvedStyle.unitySliceBottom
		/// </summary>
		protected RSystem.RInt32 r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceBottom;
		public virtual RSystem.RInt32 RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceBottom
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceBottom == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceBottom = new(this, "UnityEngine.UIElements.IResolvedStyle.unitySliceBottom", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceBottom.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceBottom;
			}
		}

		/// <summary>
		/// Int32 UnityEngine.UIElements.IResolvedStyle.unitySliceLeft
		/// </summary>
		protected RSystem.RInt32 r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceLeft;
		public virtual RSystem.RInt32 RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceLeft
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceLeft == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceLeft = new(this, "UnityEngine.UIElements.IResolvedStyle.unitySliceLeft", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceLeft.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceLeft;
			}
		}

		/// <summary>
		/// Int32 UnityEngine.UIElements.IResolvedStyle.unitySliceRight
		/// </summary>
		protected RSystem.RInt32 r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceRight;
		public virtual RSystem.RInt32 RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceRight
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceRight == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceRight = new(this, "UnityEngine.UIElements.IResolvedStyle.unitySliceRight", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceRight.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceRight;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.unitySliceScale
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceScale;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceScale
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceScale == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceScale = new(this, "UnityEngine.UIElements.IResolvedStyle.unitySliceScale", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceScale.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceScale;
			}
		}

		/// <summary>
		/// Int32 UnityEngine.UIElements.IResolvedStyle.unitySliceTop
		/// </summary>
		protected RSystem.RInt32 r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceTop;
		public virtual RSystem.RInt32 RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceTop
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceTop == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceTop = new(this, "UnityEngine.UIElements.IResolvedStyle.unitySliceTop", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceTop.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceTop;
			}
		}

		/// <summary>
		/// UnityEngine.TextAnchor UnityEngine.UIElements.IResolvedStyle.unityTextAlign
		/// </summary>
		protected RUnityEngine.RTextAnchor r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextAlign;
		public virtual RUnityEngine.RTextAnchor RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextAlign
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextAlign == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextAlign = new(this, "UnityEngine.UIElements.IResolvedStyle.unityTextAlign", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextAlign.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextAlign;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.unityTextOutlineColor
		/// </summary>
		protected RUnityEngine.RColor r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOutlineColor;
		public virtual RUnityEngine.RColor RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOutlineColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOutlineColor == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOutlineColor = new(this, "UnityEngine.UIElements.IResolvedStyle.unityTextOutlineColor", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOutlineColor.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOutlineColor;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.unityTextOutlineWidth
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOutlineWidth;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOutlineWidth
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOutlineWidth == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOutlineWidth = new(this, "UnityEngine.UIElements.IResolvedStyle.unityTextOutlineWidth", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOutlineWidth.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOutlineWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextOverflowPosition UnityEngine.UIElements.IResolvedStyle.unityTextOverflowPosition
		/// </summary>
		protected RUnityEngine.RUIElements.RTextOverflowPosition r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOverflowPosition;
		public virtual RUnityEngine.RUIElements.RTextOverflowPosition RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOverflowPosition
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOverflowPosition == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOverflowPosition = new(this, "UnityEngine.UIElements.IResolvedStyle.unityTextOverflowPosition", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOverflowPosition.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOverflowPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Visibility UnityEngine.UIElements.IResolvedStyle.visibility
		/// </summary>
		protected RUnityEngine.RUIElements.RVisibility r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__visibility;
		public virtual RUnityEngine.RUIElements.RVisibility RPUnityEngine__2__UIElements__2__IResolvedStyle__2__visibility
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__visibility == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__visibility = new(this, "UnityEngine.UIElements.IResolvedStyle.visibility", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__visibility.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__visibility;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.WhiteSpace UnityEngine.UIElements.IResolvedStyle.whiteSpace
		/// </summary>
		protected RUnityEngine.RUIElements.RWhiteSpace r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__whiteSpace;
		public virtual RUnityEngine.RUIElements.RWhiteSpace RPUnityEngine__2__UIElements__2__IResolvedStyle__2__whiteSpace
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__whiteSpace == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__whiteSpace = new(this, "UnityEngine.UIElements.IResolvedStyle.whiteSpace", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__whiteSpace.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__whiteSpace;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.width
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__width;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__width
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__width == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__width = new(this, "UnityEngine.UIElements.IResolvedStyle.width", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__width.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__width;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.wordSpacing
		/// </summary>
		protected RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__wordSpacing;
		public virtual RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__wordSpacing
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__wordSpacing == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__wordSpacing = new(this, "UnityEngine.UIElements.IResolvedStyle.wordSpacing", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__wordSpacing.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__wordSpacing;
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
		/// Int32 UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount
		/// </summary>
		protected RSystem.RInt32 r_PUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__runningAnimationCount;
		public virtual RSystem.RInt32 RPUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__runningAnimationCount
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__runningAnimationCount == null)
				{
					r_PUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__runningAnimationCount = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount", -1);
					r_PUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__runningAnimationCount.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__runningAnimationCount;
			}
		}

		/// <summary>
		/// Int32 UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount
		/// </summary>
		protected RSystem.RInt32 r_PUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__completedAnimationCount;
		public virtual RSystem.RInt32 RPUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__completedAnimationCount
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__completedAnimationCount == null)
				{
					r_PUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__completedAnimationCount = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount", -1);
					r_PUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__completedAnimationCount.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__completedAnimationCount;
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
		/// UnityEngine.Vector3 UnityEngine.UIElements.ITransform.position
		/// </summary>
		protected RUnityEngine.RVector3 r_PUnityEngine__2__UIElements__2__ITransform__2__position;
		public virtual RUnityEngine.RVector3 RPUnityEngine__2__UIElements__2__ITransform__2__position
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITransform__2__position == null)
				{
					r_PUnityEngine__2__UIElements__2__ITransform__2__position = new(this, "UnityEngine.UIElements.ITransform.position", -1);
					r_PUnityEngine__2__UIElements__2__ITransform__2__position.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITransform__2__position;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion UnityEngine.UIElements.ITransform.rotation
		/// </summary>
		protected RUnityEngine.RQuaternion r_PUnityEngine__2__UIElements__2__ITransform__2__rotation;
		public virtual RUnityEngine.RQuaternion RPUnityEngine__2__UIElements__2__ITransform__2__rotation
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITransform__2__rotation == null)
				{
					r_PUnityEngine__2__UIElements__2__ITransform__2__rotation = new(this, "UnityEngine.UIElements.ITransform.rotation", -1);
					r_PUnityEngine__2__UIElements__2__ITransform__2__rotation.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITransform__2__rotation;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 UnityEngine.UIElements.ITransform.scale
		/// </summary>
		protected RUnityEngine.RVector3 r_PUnityEngine__2__UIElements__2__ITransform__2__scale;
		public virtual RUnityEngine.RVector3 RPUnityEngine__2__UIElements__2__ITransform__2__scale
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITransform__2__scale == null)
				{
					r_PUnityEngine__2__UIElements__2__ITransform__2__scale = new(this, "UnityEngine.UIElements.ITransform.scale", -1);
					r_PUnityEngine__2__UIElements__2__ITransform__2__scale.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITransform__2__scale;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 UnityEngine.UIElements.ITransform.matrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_PUnityEngine__2__UIElements__2__ITransform__2__matrix;
		public virtual RUnityEngine.RMatrix4x4 RPUnityEngine__2__UIElements__2__ITransform__2__matrix
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITransform__2__matrix == null)
				{
					r_PUnityEngine__2__UIElements__2__ITransform__2__matrix = new(this, "UnityEngine.UIElements.ITransform.matrix", -1);
					r_PUnityEngine__2__UIElements__2__ITransform__2__matrix.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__ITransform__2__matrix;
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
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.ScaleMode] UnityEngine.UIElements.IResolvedStyle.unityBackgroundScaleMode
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RScaleMode> r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityBackgroundScaleMode;
		public virtual RUnityEngine.RUIElements.RStyleEnum<RUnityEngine.RScaleMode> RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unityBackgroundScaleMode
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityBackgroundScaleMode == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityBackgroundScaleMode = new(this, "UnityEngine.UIElements.IResolvedStyle.unityBackgroundScaleMode", -1);
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityBackgroundScaleMode.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityBackgroundScaleMode;
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
		/// UnityEngine.Rect boundingBoxInParentSpace
		/// </summary>
		protected RUnityEngine.RRect r_PboundingBoxInParentSpace;
		public virtual RUnityEngine.RRect RPboundingBoxInParentSpace
		{
			get
			{
				if(r_PboundingBoxInParentSpace == null)
				{
					r_PboundingBoxInParentSpace = new(this, "boundingBoxInParentSpace", -1);
					r_PboundingBoxInParentSpace.SetBelong(this.instance);
				}
				return r_PboundingBoxInParentSpace;
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
		/// Boolean isParentEnabledInHierarchy
		/// </summary>
		protected RSystem.RBoolean r_PisParentEnabledInHierarchy;
		public virtual RSystem.RBoolean RPisParentEnabledInHierarchy
		{
			get
			{
				if(r_PisParentEnabledInHierarchy == null)
				{
					r_PisParentEnabledInHierarchy = new(this, "isParentEnabledInHierarchy", -1);
					r_PisParentEnabledInHierarchy.SetBelong(this.instance);
				}
				return r_PisParentEnabledInHierarchy;
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
		/// UnityEngine.UIElements.Experimental.ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.animation
		/// </summary>
		protected RUnityEngine.RUIElements.RExperimental.RITransitionAnimations r_PUnityEngine__2__UIElements__2__IExperimentalFeatures__2__animation;
		public virtual RUnityEngine.RUIElements.RExperimental.RITransitionAnimations RPUnityEngine__2__UIElements__2__IExperimentalFeatures__2__animation
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IExperimentalFeatures__2__animation == null)
				{
					r_PUnityEngine__2__UIElements__2__IExperimentalFeatures__2__animation = new(this, "UnityEngine.UIElements.IExperimentalFeatures.animation", -1);
					r_PUnityEngine__2__UIElements__2__IExperimentalFeatures__2__animation.SetBelong(this.instance);
				}
				return r_PUnityEngine__2__UIElements__2__IExperimentalFeatures__2__animation;
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
		/// UnityEngine.Vector3 positionWithLayout
		/// </summary>
		protected RUnityEngine.RVector3 r_PpositionWithLayout;
		public virtual RUnityEngine.RVector3 RPpositionWithLayout
		{
			get
			{
				if(r_PpositionWithLayout == null)
				{
					r_PpositionWithLayout = new(this, "positionWithLayout", -1);
					r_PpositionWithLayout.SetBelong(this.instance);
				}
				return r_PpositionWithLayout;
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
		/// TypeData typeData
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement.RTypeData r_PtypeData;
		public virtual RUnityEngine.RUIElements.RVisualElement.RTypeData RPtypeData
		{
			get
			{
				if(r_PtypeData == null)
				{
					r_PtypeData = new(this, "typeData", -1);
					r_PtypeData.SetBelong(this.instance);
				}
				return r_PtypeData;
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
		/// UnityEngine.UIElements.IStylePropertyAnimationSystem GetStylePropertyAnimationSystem()
		/// </summary>
		protected RMethod r_MGetStylePropertyAnimationSystem;
		public virtual RMethod RMGetStylePropertyAnimationSystem
		{
			get
			{
				if(r_MGetStylePropertyAnimationSystem == null)
				{
					r_MGetStylePropertyAnimationSystem = new(this, "GetStylePropertyAnimationSystem", 0);
					r_MGetStylePropertyAnimationSystem.SetBelong(this.instance);
				}
				return r_MGetStylePropertyAnimationSystem;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, Single, Single, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Single_Single_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Single_Single_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Single_Single_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Single_Single_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(System.Single), typeof(System.Single), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Single_Single_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Single_Single_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, Int32, Int32, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Length, UnityEngine.UIElements.Length, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Length_Length_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Length_Length_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Length_Length_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Length_Length_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Length), typeof(UnityEngine.UIElements.Length), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Length_Length_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Length_Length_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.Color, UnityEngine.Color, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Color_Color_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Color_Color_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Color_Color_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Color_Color_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.Color), typeof(UnityEngine.Color), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Color_Color_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Color_Color_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.StartEnum(UnityEngine.UIElements.StyleSheets.StylePropertyId, Int32, Int32, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__StartEnum_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__StartEnum_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__StartEnum_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__StartEnum_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.StartEnum", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__StartEnum_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__StartEnum_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Background, UnityEngine.UIElements.Background, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Background_Background_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Background_Background_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Background_Background_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Background_Background_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Background), typeof(UnityEngine.UIElements.Background), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Background_Background_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Background_Background_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.FontDefinition, UnityEngine.UIElements.FontDefinition, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.FontDefinition), typeof(UnityEngine.UIElements.FontDefinition), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.Font, UnityEngine.Font, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Font_Font_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Font_Font_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Font_Font_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Font_Font_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.Font), typeof(UnityEngine.Font), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Font_Font_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Font_Font_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.TextShadow, UnityEngine.UIElements.TextShadow, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.TextShadow), typeof(UnityEngine.UIElements.TextShadow), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Scale, UnityEngine.UIElements.Scale, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Scale_Scale_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Scale_Scale_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Scale_Scale_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Scale_Scale_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Scale), typeof(UnityEngine.UIElements.Scale), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Scale_Scale_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Scale_Scale_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Translate, UnityEngine.UIElements.Translate, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Translate_Translate_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Translate_Translate_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Translate_Translate_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Translate_Translate_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Translate), typeof(UnityEngine.UIElements.Translate), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Translate_Translate_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Translate_Translate_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Rotate, UnityEngine.UIElements.Rotate, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Rotate), typeof(UnityEngine.UIElements.Rotate), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.TransformOrigin, UnityEngine.UIElements.TransformOrigin, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.TransformOrigin), typeof(UnityEngine.UIElements.TransformOrigin), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.BackgroundPosition, UnityEngine.UIElements.BackgroundPosition, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.BackgroundPosition), typeof(UnityEngine.UIElements.BackgroundPosition), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.BackgroundRepeat, UnityEngine.UIElements.BackgroundRepeat, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.BackgroundRepeat), typeof(UnityEngine.UIElements.BackgroundRepeat), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.BackgroundSize, UnityEngine.UIElements.BackgroundSize, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.BackgroundSize), typeof(UnityEngine.UIElements.BackgroundSize), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__CancelAnimation_StylePropertyId;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__CancelAnimation_StylePropertyId
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__CancelAnimation_StylePropertyId == null)
				{
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__CancelAnimation_StylePropertyId = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__CancelAnimation_StylePropertyId.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__CancelAnimation_StylePropertyId;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations()
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__CancelAllAnimations;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__CancelAllAnimations
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__CancelAllAnimations == null)
				{
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__CancelAllAnimations = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations", 0);
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__CancelAllAnimations.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__CancelAllAnimations;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.HasRunningAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__HasRunningAnimation_StylePropertyId;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__HasRunningAnimation_StylePropertyId
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__HasRunningAnimation_StylePropertyId == null)
				{
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__HasRunningAnimation_StylePropertyId = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.HasRunningAnimation", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__HasRunningAnimation_StylePropertyId.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__HasRunningAnimation_StylePropertyId;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__UpdateAnimation_StylePropertyId;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__UpdateAnimation_StylePropertyId
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__UpdateAnimation_StylePropertyId == null)
				{
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__UpdateAnimation_StylePropertyId = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__UpdateAnimation_StylePropertyId.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__UpdateAnimation_StylePropertyId;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations(System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.StylePropertyId])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__GetAllAnimations_List_d_StylePropertyId_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__GetAllAnimations_List_d_StylePropertyId_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__GetAllAnimations_List_d_StylePropertyId_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__GetAllAnimations_List_d_StylePropertyId_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations", 0, typeof(System.Collections.Generic.List<>).MakeGenericType( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId")));
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__GetAllAnimations_List_d_StylePropertyId_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__GetAllAnimations_List_d_StylePropertyId_p_;
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
		/// System.Nullable`1[System.Single] GetParentSizeForLengthConversion(UnityEngine.UIElements.StyleSheets.StylePropertyId, Int32)
		/// </summary>
		protected RMethod r_MGetParentSizeForLengthConversion_StylePropertyId_Int32;
		public virtual RMethod RMGetParentSizeForLengthConversion_StylePropertyId_Int32
		{
			get
			{
				if(r_MGetParentSizeForLengthConversion_StylePropertyId_Int32 == null)
				{
					r_MGetParentSizeForLengthConversion_StylePropertyId_Int32 = new(this, "GetParentSizeForLengthConversion", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(System.Int32));
					r_MGetParentSizeForLengthConversion_StylePropertyId_Int32.SetBelong(this.instance);
				}
				return r_MGetParentSizeForLengthConversion_StylePropertyId_Int32;
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
		/// Void UpdateWorldClip()
		/// </summary>
		protected RMethod r_MUpdateWorldClip;
		public virtual RMethod RMUpdateWorldClip
		{
			get
			{
				if(r_MUpdateWorldClip == null)
				{
					r_MUpdateWorldClip = new(this, "UpdateWorldClip", 0);
					r_MUpdateWorldClip.SetBelong(this.instance);
				}
				return r_MUpdateWorldClip;
			}
		}

		/// <summary>
		/// UnityEngine.Rect CombineClipRects(UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MCombineClipRects_Rect_Rect;
		public virtual RMethod RMCombineClipRects_Rect_Rect
		{
			get
			{
				if(r_MCombineClipRects_Rect_Rect == null)
				{
					r_MCombineClipRects_Rect_Rect = new(this, "CombineClipRects", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
					r_MCombineClipRects_Rect_Rect.SetBelong(this.instance);
				}
				return r_MCombineClipRects_Rect_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect SubstractBorderPadding(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MSubstractBorderPadding_Rect;
		public virtual RMethod RMSubstractBorderPadding_Rect
		{
			get
			{
				if(r_MSubstractBorderPadding_Rect == null)
				{
					r_MSubstractBorderPadding_Rect = new(this, "SubstractBorderPadding", 0, typeof(UnityEngine.Rect));
					r_MSubstractBorderPadding_Rect.SetBelong(this.instance);
				}
				return r_MSubstractBorderPadding_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect ComputeAAAlignedBound(UnityEngine.Rect, UnityEngine.Matrix4x4)
		/// </summary>
		protected static RMethod r_MComputeAAAlignedBound_Rect_Matrix4x4;
		public static RMethod RMComputeAAAlignedBound_Rect_Matrix4x4
		{
			get
			{
				if(r_MComputeAAAlignedBound_Rect_Matrix4x4 == null)
				{
					r_MComputeAAAlignedBound_Rect_Matrix4x4 = new(typeof(UnityEngine.UIElements.VisualElement), "ComputeAAAlignedBound", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Matrix4x4));
					r_MComputeAAAlignedBound_Rect_Matrix4x4.SetBelong(null);
				}
				return r_MComputeAAAlignedBound_Rect_Matrix4x4;
			}
		}

		/// <summary>
		/// Void UpdateHoverPseudoState()
		/// </summary>
		protected RMethod r_MUpdateHoverPseudoState;
		public virtual RMethod RMUpdateHoverPseudoState
		{
			get
			{
				if(r_MUpdateHoverPseudoState == null)
				{
					r_MUpdateHoverPseudoState = new(this, "UpdateHoverPseudoState", 0);
					r_MUpdateHoverPseudoState.SetBelong(this.instance);
				}
				return r_MUpdateHoverPseudoState;
			}
		}

		/// <summary>
		/// Boolean IsPartOfCapturedChain(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.IEventHandler ByRef)
		/// </summary>
		protected static RMethod r_MIsPartOfCapturedChain_VisualElement_In_IEventHandler;
		public static RMethod RMIsPartOfCapturedChain_VisualElement_In_IEventHandler
		{
			get
			{
				if(r_MIsPartOfCapturedChain_VisualElement_In_IEventHandler == null)
				{
					r_MIsPartOfCapturedChain_VisualElement_In_IEventHandler = new(typeof(UnityEngine.UIElements.VisualElement), "IsPartOfCapturedChain", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.IEventHandler).MakeByRefType());
					r_MIsPartOfCapturedChain_VisualElement_In_IEventHandler.SetBelong(null);
				}
				return r_MIsPartOfCapturedChain_VisualElement_In_IEventHandler;
			}
		}

		/// <summary>
		/// Void ChangeIMGUIContainerCount(Int32)
		/// </summary>
		protected RMethod r_MChangeIMGUIContainerCount_Int32;
		public virtual RMethod RMChangeIMGUIContainerCount_Int32
		{
			get
			{
				if(r_MChangeIMGUIContainerCount_Int32 == null)
				{
					r_MChangeIMGUIContainerCount_Int32 = new(this, "ChangeIMGUIContainerCount", 0, typeof(System.Int32));
					r_MChangeIMGUIContainerCount_Int32.SetBelong(this.instance);
				}
				return r_MChangeIMGUIContainerCount_Int32;
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
		/// Void SetTooltip(UnityEngine.UIElements.TooltipEvent)
		/// </summary>
		protected RMethod r_MSetTooltip_TooltipEvent;
		public virtual RMethod RMSetTooltip_TooltipEvent
		{
			get
			{
				if(r_MSetTooltip_TooltipEvent == null)
				{
					r_MSetTooltip_TooltipEvent = new(this, "SetTooltip", 0, typeof(UnityEngine.UIElements.TooltipEvent));
					r_MSetTooltip_TooltipEvent.SetBelong(this.instance);
				}
				return r_MSetTooltip_TooltipEvent;
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
		/// Void WillChangePanel(UnityEngine.UIElements.BaseVisualElementPanel)
		/// </summary>
		protected RMethod r_MWillChangePanel_BaseVisualElementPanel;
		public virtual RMethod RMWillChangePanel_BaseVisualElementPanel
		{
			get
			{
				if(r_MWillChangePanel_BaseVisualElementPanel == null)
				{
					r_MWillChangePanel_BaseVisualElementPanel = new(this, "WillChangePanel", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.BaseVisualElementPanel"));
					r_MWillChangePanel_BaseVisualElementPanel.SetBelong(this.instance);
				}
				return r_MWillChangePanel_BaseVisualElementPanel;
			}
		}

		/// <summary>
		/// Void HasChangedPanel(UnityEngine.UIElements.BaseVisualElementPanel)
		/// </summary>
		protected RMethod r_MHasChangedPanel_BaseVisualElementPanel;
		public virtual RMethod RMHasChangedPanel_BaseVisualElementPanel
		{
			get
			{
				if(r_MHasChangedPanel_BaseVisualElementPanel == null)
				{
					r_MHasChangedPanel_BaseVisualElementPanel = new(this, "HasChangedPanel", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.BaseVisualElementPanel"));
					r_MHasChangedPanel_BaseVisualElementPanel.SetBelong(this.instance);
				}
				return r_MHasChangedPanel_BaseVisualElementPanel;
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
		/// Boolean SetEnabledFromHierarchyPrivate(Boolean)
		/// </summary>
		protected RMethod r_MSetEnabledFromHierarchyPrivate_Boolean;
		public virtual RMethod RMSetEnabledFromHierarchyPrivate_Boolean
		{
			get
			{
				if(r_MSetEnabledFromHierarchyPrivate_Boolean == null)
				{
					r_MSetEnabledFromHierarchyPrivate_Boolean = new(this, "SetEnabledFromHierarchyPrivate", 0, typeof(System.Boolean));
					r_MSetEnabledFromHierarchyPrivate_Boolean.SetBelong(this.instance);
				}
				return r_MSetEnabledFromHierarchyPrivate_Boolean;
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
		/// Void PropagateEnabledToChildren(Boolean)
		/// </summary>
		protected RMethod r_MPropagateEnabledToChildren_Boolean;
		public virtual RMethod RMPropagateEnabledToChildren_Boolean
		{
			get
			{
				if(r_MPropagateEnabledToChildren_Boolean == null)
				{
					r_MPropagateEnabledToChildren_Boolean = new(this, "PropagateEnabledToChildren", 0, typeof(System.Boolean));
					r_MPropagateEnabledToChildren_Boolean.SetBelong(this.instance);
				}
				return r_MPropagateEnabledToChildren_Boolean;
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
		/// Void AssignMeasureFunction()
		/// </summary>
		protected RMethod r_MAssignMeasureFunction;
		public virtual RMethod RMAssignMeasureFunction
		{
			get
			{
				if(r_MAssignMeasureFunction == null)
				{
					r_MAssignMeasureFunction = new(this, "AssignMeasureFunction", 0);
					r_MAssignMeasureFunction.SetBelong(this.instance);
				}
				return r_MAssignMeasureFunction;
			}
		}

		/// <summary>
		/// Void RemoveMeasureFunction()
		/// </summary>
		protected RMethod r_MRemoveMeasureFunction;
		public virtual RMethod RMRemoveMeasureFunction
		{
			get
			{
				if(r_MRemoveMeasureFunction == null)
				{
					r_MRemoveMeasureFunction = new(this, "RemoveMeasureFunction", 0);
					r_MRemoveMeasureFunction.SetBelong(this.instance);
				}
				return r_MRemoveMeasureFunction;
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
		/// Void FinalizeLayout()
		/// </summary>
		protected RMethod r_MFinalizeLayout;
		public virtual RMethod RMFinalizeLayout
		{
			get
			{
				if(r_MFinalizeLayout == null)
				{
					r_MFinalizeLayout = new(this, "FinalizeLayout", 0);
					r_MFinalizeLayout.SetBelong(this.instance);
				}
				return r_MFinalizeLayout;
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
		/// Boolean TryGetPropertyInternal(UnityEngine.PropertyName, System.Object ByRef)
		/// </summary>
		protected RMethod r_MTryGetPropertyInternal_PropertyName_Out_Object;
		public virtual RMethod RMTryGetPropertyInternal_PropertyName_Out_Object
		{
			get
			{
				if(r_MTryGetPropertyInternal_PropertyName_Out_Object == null)
				{
					r_MTryGetPropertyInternal_PropertyName_Out_Object = new(this, "TryGetPropertyInternal", 0, typeof(UnityEngine.PropertyName), typeof(System.Object).MakeByRefType());
					r_MTryGetPropertyInternal_PropertyName_Out_Object.SetBelong(this.instance);
				}
				return r_MTryGetPropertyInternal_PropertyName_Out_Object;
			}
		}

		/// <summary>
		/// Void CheckUserKeyArgument(UnityEngine.PropertyName)
		/// </summary>
		protected static RMethod r_MCheckUserKeyArgument_PropertyName;
		public static RMethod RMCheckUserKeyArgument_PropertyName
		{
			get
			{
				if(r_MCheckUserKeyArgument_PropertyName == null)
				{
					r_MCheckUserKeyArgument_PropertyName = new(typeof(UnityEngine.UIElements.VisualElement), "CheckUserKeyArgument", 0, typeof(UnityEngine.PropertyName));
					r_MCheckUserKeyArgument_PropertyName.SetBelong(null);
				}
				return r_MCheckUserKeyArgument_PropertyName;
			}
		}

		/// <summary>
		/// Void SetPropertyInternal(UnityEngine.PropertyName, System.Object)
		/// </summary>
		protected RMethod r_MSetPropertyInternal_PropertyName_Object;
		public virtual RMethod RMSetPropertyInternal_PropertyName_Object
		{
			get
			{
				if(r_MSetPropertyInternal_PropertyName_Object == null)
				{
					r_MSetPropertyInternal_PropertyName_Object = new(this, "SetPropertyInternal", 0, typeof(UnityEngine.PropertyName), typeof(System.Object));
					r_MSetPropertyInternal_PropertyName_Object.SetBelong(this.instance);
				}
				return r_MSetPropertyInternal_PropertyName_Object;
			}
		}

		/// <summary>
		/// Void UpdateCursorStyle(Int64)
		/// </summary>
		protected RMethod r_MUpdateCursorStyle_Int64;
		public virtual RMethod RMUpdateCursorStyle_Int64
		{
			get
			{
				if(r_MUpdateCursorStyle_Int64 == null)
				{
					r_MUpdateCursorStyle_Int64 = new(this, "UpdateCursorStyle", 0, typeof(System.Int64));
					r_MUpdateCursorStyle_Int64.SetBelong(this.instance);
				}
				return r_MUpdateCursorStyle_Int64;
			}
		}

		/// <summary>
		/// UnityEngine.Material getRuntimeMaterial()
		/// </summary>
		protected RMethod r_MgetRuntimeMaterial;
		public virtual RMethod RMgetRuntimeMaterial
		{
			get
			{
				if(r_MgetRuntimeMaterial == null)
				{
					r_MgetRuntimeMaterial = new(this, "getRuntimeMaterial", 0);
					r_MgetRuntimeMaterial.SetBelong(this.instance);
				}
				return r_MgetRuntimeMaterial;
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
		/// UnityEngine.UIElements.VisualElementAnimationSystem GetAnimationSystem()
		/// </summary>
		protected RMethod r_MGetAnimationSystem;
		public virtual RMethod RMGetAnimationSystem
		{
			get
			{
				if(r_MGetAnimationSystem == null)
				{
					r_MGetAnimationSystem = new(this, "GetAnimationSystem", 0);
					r_MGetAnimationSystem.SetBelong(this.instance);
				}
				return r_MGetAnimationSystem;
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
		/// Void UnregisterRunningAnimations()
		/// </summary>
		protected RMethod r_MUnregisterRunningAnimations;
		public virtual RMethod RMUnregisterRunningAnimations
		{
			get
			{
				if(r_MUnregisterRunningAnimations == null)
				{
					r_MUnregisterRunningAnimations = new(this, "UnregisterRunningAnimations", 0);
					r_MUnregisterRunningAnimations.SetBelong(this.instance);
				}
				return r_MUnregisterRunningAnimations;
			}
		}

		/// <summary>
		/// Void RegisterRunningAnimations()
		/// </summary>
		protected RMethod r_MRegisterRunningAnimations;
		public virtual RMethod RMRegisterRunningAnimations
		{
			get
			{
				if(r_MRegisterRunningAnimations == null)
				{
					r_MRegisterRunningAnimations = new(this, "RegisterRunningAnimations", 0);
					r_MRegisterRunningAnimations.SetBelong(this.instance);
				}
				return r_MRegisterRunningAnimations;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[System.Single] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(Single, Single, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,System.Single])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Single_Single_Int32_Action_d_VisualElement_Single_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Single_Single_Int32_Action_d_VisualElement_Single_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Single_Single_Int32_Action_d_VisualElement_Single_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Single_Single_Int32_Action_d_VisualElement_Single_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(System.Single), typeof(System.Single), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(System.Single)));
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Single_Single_Int32_Action_d_VisualElement_Single_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Single_Single_Int32_Action_d_VisualElement_Single_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Rect] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(UnityEngine.Rect, UnityEngine.Rect, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Rect])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Rect_Rect_Int32_Action_d_VisualElement_Rect_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Rect_Rect_Int32_Action_d_VisualElement_Rect_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Rect_Rect_Int32_Action_d_VisualElement_Rect_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Rect_Rect_Int32_Action_d_VisualElement_Rect_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Rect)));
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Rect_Rect_Int32_Action_d_VisualElement_Rect_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Rect_Rect_Int32_Action_d_VisualElement_Rect_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Color] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(UnityEngine.Color, UnityEngine.Color, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Color])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Color_Color_Int32_Action_d_VisualElement_Color_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Color_Color_Int32_Action_d_VisualElement_Color_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Color_Color_Int32_Action_d_VisualElement_Color_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Color_Color_Int32_Action_d_VisualElement_Color_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(UnityEngine.Color), typeof(UnityEngine.Color), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Color)));
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Color_Color_Int32_Action_d_VisualElement_Color_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Color_Color_Int32_Action_d_VisualElement_Color_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Vector3] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(UnityEngine.Vector3, UnityEngine.Vector3, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Vector3_Vector3_Int32_Action_d_VisualElement_Vector3_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Vector3_Vector3_Int32_Action_d_VisualElement_Vector3_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Vector3_Vector3_Int32_Action_d_VisualElement_Vector3_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Vector3_Vector3_Int32_Action_d_VisualElement_Vector3_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector3)));
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Vector3_Vector3_Int32_Action_d_VisualElement_Vector3_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Vector3_Vector3_Int32_Action_d_VisualElement_Vector3_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Vector2] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(UnityEngine.Vector2, UnityEngine.Vector2, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Vector2])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Vector2_Vector2_Int32_Action_d_VisualElement_Vector2_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Vector2_Vector2_Int32_Action_d_VisualElement_Vector2_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Vector2_Vector2_Int32_Action_d_VisualElement_Vector2_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Vector2_Vector2_Int32_Action_d_VisualElement_Vector2_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector2)));
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Vector2_Vector2_Int32_Action_d_VisualElement_Vector2_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Vector2_Vector2_Int32_Action_d_VisualElement_Vector2_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Quaternion] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(UnityEngine.Quaternion, UnityEngine.Quaternion, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Quaternion])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Quaternion_Quaternion_Int32_Action_d_VisualElement_Quaternion_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Quaternion_Quaternion_Int32_Action_d_VisualElement_Quaternion_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Quaternion_Quaternion_Int32_Action_d_VisualElement_Quaternion_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Quaternion_Quaternion_Int32_Action_d_VisualElement_Quaternion_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Quaternion)));
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Quaternion_Quaternion_Int32_Action_d_VisualElement_Quaternion_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Quaternion_Quaternion_Int32_Action_d_VisualElement_Quaternion_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.UIElements.Experimental.StyleValues] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(UnityEngine.UIElements.Experimental.StyleValues, UnityEngine.UIElements.Experimental.StyleValues, Int32)
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_StyleValues_StyleValues_Int32;
		public virtual RMethod RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_StyleValues_StyleValues_Int32
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_StyleValues_StyleValues_Int32 == null)
				{
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_StyleValues_StyleValues_Int32 = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(UnityEngine.UIElements.Experimental.StyleValues), typeof(UnityEngine.UIElements.Experimental.StyleValues), typeof(System.Int32));
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_StyleValues_StyleValues_Int32.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_StyleValues_StyleValues_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[System.Single] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(System.Func`2[UnityEngine.UIElements.VisualElement,System.Single], Single, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,System.Single])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Single_p__Single_Int32_Action_d_VisualElement_Single_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Single_p__Single_Int32_Action_d_VisualElement_Single_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Single_p__Single_Int32_Action_d_VisualElement_Single_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Single_p__Single_Int32_Action_d_VisualElement_Single_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(System.Single)), typeof(System.Single), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(System.Single)));
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Single_p__Single_Int32_Action_d_VisualElement_Single_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Single_p__Single_Int32_Action_d_VisualElement_Single_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Rect] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(System.Func`2[UnityEngine.UIElements.VisualElement,UnityEngine.Rect], UnityEngine.Rect, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Rect])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Rect_p__Rect_Int32_Action_d_VisualElement_Rect_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Rect_p__Rect_Int32_Action_d_VisualElement_Rect_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Rect_p__Rect_Int32_Action_d_VisualElement_Rect_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Rect_p__Rect_Int32_Action_d_VisualElement_Rect_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Rect)), typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Rect)));
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Rect_p__Rect_Int32_Action_d_VisualElement_Rect_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Rect_p__Rect_Int32_Action_d_VisualElement_Rect_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Color] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(System.Func`2[UnityEngine.UIElements.VisualElement,UnityEngine.Color], UnityEngine.Color, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Color])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Color_p__Color_Int32_Action_d_VisualElement_Color_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Color_p__Color_Int32_Action_d_VisualElement_Color_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Color_p__Color_Int32_Action_d_VisualElement_Color_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Color_p__Color_Int32_Action_d_VisualElement_Color_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Color)), typeof(UnityEngine.Color), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Color)));
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Color_p__Color_Int32_Action_d_VisualElement_Color_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Color_p__Color_Int32_Action_d_VisualElement_Color_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Vector3] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(System.Func`2[UnityEngine.UIElements.VisualElement,UnityEngine.Vector3], UnityEngine.Vector3, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Vector3_p__Vector3_Int32_Action_d_VisualElement_Vector3_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Vector3_p__Vector3_Int32_Action_d_VisualElement_Vector3_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Vector3_p__Vector3_Int32_Action_d_VisualElement_Vector3_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Vector3_p__Vector3_Int32_Action_d_VisualElement_Vector3_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector3)), typeof(UnityEngine.Vector3), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector3)));
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Vector3_p__Vector3_Int32_Action_d_VisualElement_Vector3_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Vector3_p__Vector3_Int32_Action_d_VisualElement_Vector3_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Vector2] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(System.Func`2[UnityEngine.UIElements.VisualElement,UnityEngine.Vector2], UnityEngine.Vector2, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Vector2])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Vector2_p__Vector2_Int32_Action_d_VisualElement_Vector2_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Vector2_p__Vector2_Int32_Action_d_VisualElement_Vector2_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Vector2_p__Vector2_Int32_Action_d_VisualElement_Vector2_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Vector2_p__Vector2_Int32_Action_d_VisualElement_Vector2_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector2)), typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector2)));
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Vector2_p__Vector2_Int32_Action_d_VisualElement_Vector2_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Vector2_p__Vector2_Int32_Action_d_VisualElement_Vector2_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Quaternion] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(System.Func`2[UnityEngine.UIElements.VisualElement,UnityEngine.Quaternion], UnityEngine.Quaternion, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Quaternion])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Quaternion_p__Quaternion_Int32_Action_d_VisualElement_Quaternion_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Quaternion_p__Quaternion_Int32_Action_d_VisualElement_Quaternion_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Quaternion_p__Quaternion_Int32_Action_d_VisualElement_Quaternion_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Quaternion_p__Quaternion_Int32_Action_d_VisualElement_Quaternion_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Quaternion)), typeof(UnityEngine.Quaternion), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Quaternion)));
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Quaternion_p__Quaternion_Int32_Action_d_VisualElement_Quaternion_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Quaternion_p__Quaternion_Int32_Action_d_VisualElement_Quaternion_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[T] StartAnimation[T](UnityEngine.UIElements.Experimental.ValueAnimation`1[T], System.Func`2[UnityEngine.UIElements.VisualElement,T], T, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,T])
		/// </summary>
		protected static RMethod r_MStartAnimation_GT_ValueAnimation_d_T_p__Func_d_VisualElement_T_p__T_Int32_Action_d_VisualElement_T_p_;
		public static RMethod RMStartAnimation_GT_ValueAnimation_d_T_p__Func_d_VisualElement_T_p__T_Int32_Action_d_VisualElement_T_p_
		{
			get
			{
				if(r_MStartAnimation_GT_ValueAnimation_d_T_p__Func_d_VisualElement_T_p__T_Int32_Action_d_VisualElement_T_p_ == null)
				{
					r_MStartAnimation_GT_ValueAnimation_d_T_p__Func_d_VisualElement_T_p__T_Int32_Action_d_VisualElement_T_p_ = new(typeof(UnityEngine.UIElements.VisualElement), "StartAnimation", 1, typeof(UnityEngine.UIElements.Experimental.ValueAnimation<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), Type.MakeGenericMethodParameter(0)));
					r_MStartAnimation_GT_ValueAnimation_d_T_p__Func_d_VisualElement_T_p__T_Int32_Action_d_VisualElement_T_p_.SetBelong(null);
				}
				return r_MStartAnimation_GT_ValueAnimation_d_T_p__Func_d_VisualElement_T_p__T_Int32_Action_d_VisualElement_T_p_;
			}
		}

		/// <summary>
		/// Void AssignStyleValues(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.Experimental.StyleValues)
		/// </summary>
		protected static RMethod r_MAssignStyleValues_VisualElement_StyleValues;
		public static RMethod RMAssignStyleValues_VisualElement_StyleValues
		{
			get
			{
				if(r_MAssignStyleValues_VisualElement_StyleValues == null)
				{
					r_MAssignStyleValues_VisualElement_StyleValues = new(typeof(UnityEngine.UIElements.VisualElement), "AssignStyleValues", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.Experimental.StyleValues));
					r_MAssignStyleValues_VisualElement_StyleValues.SetBelong(null);
				}
				return r_MAssignStyleValues_VisualElement_StyleValues;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.StyleValues ReadCurrentValues(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.Experimental.StyleValues)
		/// </summary>
		protected RMethod r_MReadCurrentValues_VisualElement_StyleValues;
		public virtual RMethod RMReadCurrentValues_VisualElement_StyleValues
		{
			get
			{
				if(r_MReadCurrentValues_VisualElement_StyleValues == null)
				{
					r_MReadCurrentValues_VisualElement_StyleValues = new(this, "ReadCurrentValues", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.Experimental.StyleValues));
					r_MReadCurrentValues_VisualElement_StyleValues.SetBelong(this.instance);
				}
				return r_MReadCurrentValues_VisualElement_StyleValues;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.UIElements.Experimental.StyleValues] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(UnityEngine.UIElements.Experimental.StyleValues, Int32)
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_StyleValues_Int32;
		public virtual RMethod RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_StyleValues_Int32
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_StyleValues_Int32 == null)
				{
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_StyleValues_Int32 = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(UnityEngine.UIElements.Experimental.StyleValues), typeof(System.Int32));
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_StyleValues_Int32.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_StyleValues_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.UIElements.Experimental.StyleValues] Start(System.Func`2[UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.Experimental.StyleValues], UnityEngine.UIElements.Experimental.StyleValues, Int32)
		/// </summary>
		protected RMethod r_MStart_Func_d_VisualElement_StyleValues_p__StyleValues_Int32;
		public virtual RMethod RMStart_Func_d_VisualElement_StyleValues_p__StyleValues_Int32
		{
			get
			{
				if(r_MStart_Func_d_VisualElement_StyleValues_p__StyleValues_Int32 == null)
				{
					r_MStart_Func_d_VisualElement_StyleValues_p__StyleValues_Int32 = new(this, "Start", 0, typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.Experimental.StyleValues)), typeof(UnityEngine.UIElements.Experimental.StyleValues), typeof(System.Int32));
					r_MStart_Func_d_VisualElement_StyleValues_p__StyleValues_Int32.SetBelong(this.instance);
				}
				return r_MStart_Func_d_VisualElement_StyleValues_p__StyleValues_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Rect] UnityEngine.UIElements.Experimental.ITransitionAnimations.Layout(UnityEngine.Rect, Int32)
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Layout_Rect_Int32;
		public virtual RMethod RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Layout_Rect_Int32
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Layout_Rect_Int32 == null)
				{
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Layout_Rect_Int32 = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Layout", 0, typeof(UnityEngine.Rect), typeof(System.Int32));
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Layout_Rect_Int32.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Layout_Rect_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Vector2] UnityEngine.UIElements.Experimental.ITransitionAnimations.TopLeft(UnityEngine.Vector2, Int32)
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__TopLeft_Vector2_Int32;
		public virtual RMethod RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__TopLeft_Vector2_Int32
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__TopLeft_Vector2_Int32 == null)
				{
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__TopLeft_Vector2_Int32 = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.TopLeft", 0, typeof(UnityEngine.Vector2), typeof(System.Int32));
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__TopLeft_Vector2_Int32.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__TopLeft_Vector2_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Vector2] UnityEngine.UIElements.Experimental.ITransitionAnimations.Size(UnityEngine.Vector2, Int32)
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Size_Vector2_Int32;
		public virtual RMethod RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Size_Vector2_Int32
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Size_Vector2_Int32 == null)
				{
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Size_Vector2_Int32 = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Size", 0, typeof(UnityEngine.Vector2), typeof(System.Int32));
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Size_Vector2_Int32.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Size_Vector2_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[System.Single] UnityEngine.UIElements.Experimental.ITransitionAnimations.Scale(Single, Int32)
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Scale_Single_Int32;
		public virtual RMethod RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Scale_Single_Int32
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Scale_Single_Int32 == null)
				{
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Scale_Single_Int32 = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Scale", 0, typeof(System.Single), typeof(System.Int32));
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Scale_Single_Int32.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Scale_Single_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Vector3] UnityEngine.UIElements.Experimental.ITransitionAnimations.Position(UnityEngine.Vector3, Int32)
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Position_Vector3_Int32;
		public virtual RMethod RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Position_Vector3_Int32
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Position_Vector3_Int32 == null)
				{
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Position_Vector3_Int32 = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Position", 0, typeof(UnityEngine.Vector3), typeof(System.Int32));
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Position_Vector3_Int32.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Position_Vector3_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Quaternion] UnityEngine.UIElements.Experimental.ITransitionAnimations.Rotation(UnityEngine.Quaternion, Int32)
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Rotation_Quaternion_Int32;
		public virtual RMethod RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Rotation_Quaternion_Int32
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Rotation_Quaternion_Int32 == null)
				{
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Rotation_Quaternion_Int32 = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Rotation", 0, typeof(UnityEngine.Quaternion), typeof(System.Int32));
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Rotation_Quaternion_Int32.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Rotation_Quaternion_Int32;
			}
		}

		/// <summary>
		/// Void DirtyNextParentWithEventCallback()
		/// </summary>
		protected RMethod r_MDirtyNextParentWithEventCallback;
		public virtual RMethod RMDirtyNextParentWithEventCallback
		{
			get
			{
				if(r_MDirtyNextParentWithEventCallback == null)
				{
					r_MDirtyNextParentWithEventCallback = new(this, "DirtyNextParentWithEventCallback", 0);
					r_MDirtyNextParentWithEventCallback.SetBelong(this.instance);
				}
				return r_MDirtyNextParentWithEventCallback;
			}
		}

		/// <summary>
		/// Void SetAsNextParentWithEventCallback()
		/// </summary>
		protected RMethod r_MSetAsNextParentWithEventCallback;
		public virtual RMethod RMSetAsNextParentWithEventCallback
		{
			get
			{
				if(r_MSetAsNextParentWithEventCallback == null)
				{
					r_MSetAsNextParentWithEventCallback = new(this, "SetAsNextParentWithEventCallback", 0);
					r_MSetAsNextParentWithEventCallback.SetBelong(this.instance);
				}
				return r_MSetAsNextParentWithEventCallback;
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
		/// Void UpdateCallbackParentCategories()
		/// </summary>
		protected RMethod r_MUpdateCallbackParentCategories;
		public virtual RMethod RMUpdateCallbackParentCategories
		{
			get
			{
				if(r_MUpdateCallbackParentCategories == null)
				{
					r_MUpdateCallbackParentCategories = new(this, "UpdateCallbackParentCategories", 0);
					r_MUpdateCallbackParentCategories.SetBelong(this.instance);
				}
				return r_MUpdateCallbackParentCategories;
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
		/// Void GatherAllChildren(System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_MGatherAllChildren_List_d_VisualElement_p_;
		public virtual RMethod RMGatherAllChildren_List_d_VisualElement_p_
		{
			get
			{
				if(r_MGatherAllChildren_List_d_VisualElement_p_ == null)
				{
					r_MGatherAllChildren_List_d_VisualElement_p_ = new(this, "GatherAllChildren", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
					r_MGatherAllChildren_List_d_VisualElement_p_.SetBelong(this.instance);
				}
				return r_MGatherAllChildren_List_d_VisualElement_p_;
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
		/// Single Min(Single, Single, Single, Single)
		/// </summary>
		protected static RMethod r_MMin_Single_Single_Single_Single;
		public static RMethod RMMin_Single_Single_Single_Single
		{
			get
			{
				if(r_MMin_Single_Single_Single_Single == null)
				{
					r_MMin_Single_Single_Single_Single = new(typeof(UnityEngine.UIElements.VisualElement), "Min", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_MMin_Single_Single_Single_Single.SetBelong(null);
				}
				return r_MMin_Single_Single_Single_Single;
			}
		}

		/// <summary>
		/// Single Max(Single, Single, Single, Single)
		/// </summary>
		protected static RMethod r_MMax_Single_Single_Single_Single;
		public static RMethod RMMax_Single_Single_Single_Single
		{
			get
			{
				if(r_MMax_Single_Single_Single_Single == null)
				{
					r_MMax_Single_Single_Single_Single = new(typeof(UnityEngine.UIElements.VisualElement), "Max", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_MMax_Single_Single_Single_Single.SetBelong(null);
				}
				return r_MMax_Single_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void TransformAlignedRectToParentSpace(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_MTransformAlignedRectToParentSpace_Ref_Rect;
		public virtual RMethod RMTransformAlignedRectToParentSpace_Ref_Rect
		{
			get
			{
				if(r_MTransformAlignedRectToParentSpace_Ref_Rect == null)
				{
					r_MTransformAlignedRectToParentSpace_Ref_Rect = new(this, "TransformAlignedRectToParentSpace", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_MTransformAlignedRectToParentSpace_Ref_Rect.SetBelong(this.instance);
				}
				return r_MTransformAlignedRectToParentSpace_Ref_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect CalculateConservativeRect(UnityEngine.Matrix4x4 ByRef, UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_MCalculateConservativeRect_Ref_Matrix4x4_Rect;
		public static RMethod RMCalculateConservativeRect_Ref_Matrix4x4_Rect
		{
			get
			{
				if(r_MCalculateConservativeRect_Ref_Matrix4x4_Rect == null)
				{
					r_MCalculateConservativeRect_Ref_Matrix4x4_Rect = new(typeof(UnityEngine.UIElements.VisualElement), "CalculateConservativeRect", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Rect));
					r_MCalculateConservativeRect_Ref_Matrix4x4_Rect.SetBelong(null);
				}
				return r_MCalculateConservativeRect_Ref_Matrix4x4_Rect;
			}
		}

		/// <summary>
		/// Void TransformAlignedRect(UnityEngine.Matrix4x4 ByRef, UnityEngine.Rect ByRef)
		/// </summary>
		protected static RMethod r_MTransformAlignedRect_Ref_Matrix4x4_Ref_Rect;
		public static RMethod RMTransformAlignedRect_Ref_Matrix4x4_Ref_Rect
		{
			get
			{
				if(r_MTransformAlignedRect_Ref_Matrix4x4_Ref_Rect == null)
				{
					r_MTransformAlignedRect_Ref_Matrix4x4_Ref_Rect = new(typeof(UnityEngine.UIElements.VisualElement), "TransformAlignedRect", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Rect).MakeByRefType());
					r_MTransformAlignedRect_Ref_Matrix4x4_Ref_Rect.SetBelong(null);
				}
				return r_MTransformAlignedRect_Ref_Matrix4x4_Ref_Rect;
			}
		}

		/// <summary>
		/// Void OrderMinMaxRect(UnityEngine.Rect ByRef)
		/// </summary>
		protected static RMethod r_MOrderMinMaxRect_Ref_Rect;
		public static RMethod RMOrderMinMaxRect_Ref_Rect
		{
			get
			{
				if(r_MOrderMinMaxRect_Ref_Rect == null)
				{
					r_MOrderMinMaxRect_Ref_Rect = new(typeof(UnityEngine.UIElements.VisualElement), "OrderMinMaxRect", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_MOrderMinMaxRect_Ref_Rect.SetBelong(null);
				}
				return r_MOrderMinMaxRect_Ref_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 MultiplyMatrix44Point2(UnityEngine.Matrix4x4 ByRef, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_MMultiplyMatrix44Point2_Ref_Matrix4x4_Vector2;
		public static RMethod RMMultiplyMatrix44Point2_Ref_Matrix4x4_Vector2
		{
			get
			{
				if(r_MMultiplyMatrix44Point2_Ref_Matrix4x4_Vector2 == null)
				{
					r_MMultiplyMatrix44Point2_Ref_Matrix4x4_Vector2 = new(typeof(UnityEngine.UIElements.VisualElement), "MultiplyMatrix44Point2", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Vector2));
					r_MMultiplyMatrix44Point2_Ref_Matrix4x4_Vector2.SetBelong(null);
				}
				return r_MMultiplyMatrix44Point2_Ref_Matrix4x4_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 MultiplyVector2(UnityEngine.Matrix4x4 ByRef, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_MMultiplyVector2_Ref_Matrix4x4_Vector2;
		public static RMethod RMMultiplyVector2_Ref_Matrix4x4_Vector2
		{
			get
			{
				if(r_MMultiplyVector2_Ref_Matrix4x4_Vector2 == null)
				{
					r_MMultiplyVector2_Ref_Matrix4x4_Vector2 = new(typeof(UnityEngine.UIElements.VisualElement), "MultiplyVector2", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Vector2));
					r_MMultiplyVector2_Ref_Matrix4x4_Vector2.SetBelong(null);
				}
				return r_MMultiplyVector2_Ref_Matrix4x4_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Rect MultiplyMatrix44Rect2(UnityEngine.Matrix4x4 ByRef, UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_MMultiplyMatrix44Rect2_Ref_Matrix4x4_Rect;
		public static RMethod RMMultiplyMatrix44Rect2_Ref_Matrix4x4_Rect
		{
			get
			{
				if(r_MMultiplyMatrix44Rect2_Ref_Matrix4x4_Rect == null)
				{
					r_MMultiplyMatrix44Rect2_Ref_Matrix4x4_Rect = new(typeof(UnityEngine.UIElements.VisualElement), "MultiplyMatrix44Rect2", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Rect));
					r_MMultiplyMatrix44Rect2_Ref_Matrix4x4_Rect.SetBelong(null);
				}
				return r_MMultiplyMatrix44Rect2_Ref_Matrix4x4_Rect;
			}
		}

		/// <summary>
		/// Void MultiplyMatrix34(UnityEngine.Matrix4x4 ByRef, UnityEngine.Matrix4x4 ByRef, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected static RMethod r_MMultiplyMatrix34_Ref_Matrix4x4_Ref_Matrix4x4_Out_Matrix4x4;
		public static RMethod RMMultiplyMatrix34_Ref_Matrix4x4_Ref_Matrix4x4_Out_Matrix4x4
		{
			get
			{
				if(r_MMultiplyMatrix34_Ref_Matrix4x4_Ref_Matrix4x4_Out_Matrix4x4 == null)
				{
					r_MMultiplyMatrix34_Ref_Matrix4x4_Ref_Matrix4x4_Out_Matrix4x4 = new(typeof(UnityEngine.UIElements.VisualElement), "MultiplyMatrix34", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_MMultiplyMatrix34_Ref_Matrix4x4_Ref_Matrix4x4_Out_Matrix4x4.SetBelong(null);
				}
				return r_MMultiplyMatrix34_Ref_Matrix4x4_Ref_Matrix4x4_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void TranslateMatrix34(UnityEngine.Matrix4x4 ByRef, UnityEngine.Vector3, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected static RMethod r_MTranslateMatrix34_Ref_Matrix4x4_Vector3_Out_Matrix4x4;
		public static RMethod RMTranslateMatrix34_Ref_Matrix4x4_Vector3_Out_Matrix4x4
		{
			get
			{
				if(r_MTranslateMatrix34_Ref_Matrix4x4_Vector3_Out_Matrix4x4 == null)
				{
					r_MTranslateMatrix34_Ref_Matrix4x4_Vector3_Out_Matrix4x4 = new(typeof(UnityEngine.UIElements.VisualElement), "TranslateMatrix34", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Vector3), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_MTranslateMatrix34_Ref_Matrix4x4_Vector3_Out_Matrix4x4.SetBelong(null);
				}
				return r_MTranslateMatrix34_Ref_Matrix4x4_Vector3_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void TranslateMatrix34InPlace(UnityEngine.Matrix4x4 ByRef, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_MTranslateMatrix34InPlace_Ref_Matrix4x4_Vector3;
		public static RMethod RMTranslateMatrix34InPlace_Ref_Matrix4x4_Vector3
		{
			get
			{
				if(r_MTranslateMatrix34InPlace_Ref_Matrix4x4_Vector3 == null)
				{
					r_MTranslateMatrix34InPlace_Ref_Matrix4x4_Vector3 = new(typeof(UnityEngine.UIElements.VisualElement), "TranslateMatrix34InPlace", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Vector3));
					r_MTranslateMatrix34InPlace_Ref_Matrix4x4_Vector3.SetBelong(null);
				}
				return r_MTranslateMatrix34InPlace_Ref_Matrix4x4_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(System.Action`1[UnityEngine.UIElements.TimerState])
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IVisualElementScheduler__2__Execute_Action_d_TimerState_p_;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IVisualElementScheduler__2__Execute_Action_d_TimerState_p_
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IVisualElementScheduler__2__Execute_Action_d_TimerState_p_ == null)
				{
					r_MUnityEngine__2__UIElements__2__IVisualElementScheduler__2__Execute_Action_d_TimerState_p_ = new(this, "UnityEngine.UIElements.IVisualElementScheduler.Execute", 0, typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.UIElements.TimerState)));
					r_MUnityEngine__2__UIElements__2__IVisualElementScheduler__2__Execute_Action_d_TimerState_p_.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IVisualElementScheduler__2__Execute_Action_d_TimerState_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(System.Action)
		/// </summary>
		protected RMethod r_MUnityEngine__2__UIElements__2__IVisualElementScheduler__2__Execute_Action;
		public virtual RMethod RMUnityEngine__2__UIElements__2__IVisualElementScheduler__2__Execute_Action
		{
			get
			{
				if(r_MUnityEngine__2__UIElements__2__IVisualElementScheduler__2__Execute_Action == null)
				{
					r_MUnityEngine__2__UIElements__2__IVisualElementScheduler__2__Execute_Action = new(this, "UnityEngine.UIElements.IVisualElementScheduler.Execute", 0, typeof(System.Action));
					r_MUnityEngine__2__UIElements__2__IVisualElementScheduler__2__Execute_Action.SetBelong(this.instance);
				}
				return r_MUnityEngine__2__UIElements__2__IVisualElementScheduler__2__Execute_Action;
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
		/// UnityEngine.UIElements.StyleFloat ResolveLengthValue(UnityEngine.UIElements.Length, Boolean)
		/// </summary>
		protected RMethod r_MResolveLengthValue_Length_Boolean;
		public virtual RMethod RMResolveLengthValue_Length_Boolean
		{
			get
			{
				if(r_MResolveLengthValue_Length_Boolean == null)
				{
					r_MResolveLengthValue_Length_Boolean = new(this, "ResolveLengthValue", 0, typeof(UnityEngine.UIElements.Length), typeof(System.Boolean));
					r_MResolveLengthValue_Length_Boolean.SetBelong(this.instance);
				}
				return r_MResolveLengthValue_Length_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ResolveTranslate()
		/// </summary>
		protected RMethod r_MResolveTranslate;
		public virtual RMethod RMResolveTranslate
		{
			get
			{
				if(r_MResolveTranslate == null)
				{
					r_MResolveTranslate = new(this, "ResolveTranslate", 0);
					r_MResolveTranslate.SetBelong(this.instance);
				}
				return r_MResolveTranslate;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ResolveTransformOrigin()
		/// </summary>
		protected RMethod r_MResolveTransformOrigin;
		public virtual RMethod RMResolveTransformOrigin
		{
			get
			{
				if(r_MResolveTransformOrigin == null)
				{
					r_MResolveTransformOrigin = new(this, "ResolveTransformOrigin", 0);
					r_MResolveTransformOrigin.SetBelong(this.instance);
				}
				return r_MResolveTransformOrigin;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion ResolveRotation()
		/// </summary>
		protected RMethod r_MResolveRotation;
		public virtual RMethod RMResolveRotation
		{
			get
			{
				if(r_MResolveRotation == null)
				{
					r_MResolveRotation = new(this, "ResolveRotation", 0);
					r_MResolveRotation.SetBelong(this.instance);
				}
				return r_MResolveRotation;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ResolveScale()
		/// </summary>
		protected RMethod r_MResolveScale;
		public virtual RMethod RMResolveScale
		{
			get
			{
				if(r_MResolveScale == null)
				{
					r_MResolveScale = new(this, "ResolveScale", 0);
					r_MResolveScale.SetBelong(this.instance);
				}
				return r_MResolveScale;
			}
		}

		/// <summary>
		/// TypeData GetOrCreateTypeData(System.Type)
		/// </summary>
		protected static RMethod r_MGetOrCreateTypeData_Type;
		public static RMethod RMGetOrCreateTypeData_Type
		{
			get
			{
				if(r_MGetOrCreateTypeData_Type == null)
				{
					r_MGetOrCreateTypeData_Type = new(typeof(UnityEngine.UIElements.VisualElement), "GetOrCreateTypeData", 0, typeof(System.Type));
					r_MGetOrCreateTypeData_Type.SetBelong(null);
				}
				return r_MGetOrCreateTypeData_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaSize <AssignMeasureFunction>b__423_0(UnityEngine.Yoga.YogaNode, Single, UnityEngine.Yoga.YogaMeasureMode, Single, UnityEngine.Yoga.YogaMeasureMode)
		/// </summary>
		protected RMethod r_M__0__AssignMeasureFunction__1__b__423_0_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode;
		public virtual RMethod RM__0__AssignMeasureFunction__1__b__423_0_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode
		{
			get
			{
				if(r_M__0__AssignMeasureFunction__1__b__423_0_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode == null)
				{
					r_M__0__AssignMeasureFunction__1__b__423_0_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode = new(this, "<AssignMeasureFunction>b__423_0", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaNode"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Yoga.YogaMeasureMode"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Yoga.YogaMeasureMode"));
					r_M__0__AssignMeasureFunction__1__b__423_0_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode.SetBelong(this.instance);
				}
				return r_M__0__AssignMeasureFunction__1__b__423_0_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode;
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


        public RVisualElement() : base("UnityEngine.UIElements.VisualElement")
        {
        }

        public RVisualElement(System.Object instance) : base("UnityEngine.UIElements.VisualElement")
		{
            SetInstance(instance);
		}

        public RVisualElement(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVisualElement(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual RUnityEngine.RUIElements.RIStylePropertyAnimationSystem GetStylePropertyAnimationSystem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetStylePropertyAnimationSystem.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RIStylePropertyAnimationSystem(___result);
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, System.Single @from, System.Single @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Single_Single_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, System.Int32 @from, System.Int32 @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.Length @from, UnityEngine.UIElements.Length @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Length_Length_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.Color @from, UnityEngine.Color @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Color_Color_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__StartEnum(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, System.Int32 @from, System.Int32 @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__StartEnum_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.Background @from, UnityEngine.UIElements.Background @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Background_Background_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.FontDefinition @from, UnityEngine.UIElements.FontDefinition @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.Font @from, UnityEngine.Font @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Font_Font_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.TextShadow @from, UnityEngine.UIElements.TextShadow @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.Scale @from, UnityEngine.UIElements.Scale @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Scale_Scale_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.Translate @from, UnityEngine.UIElements.Translate @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Translate_Translate_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.Rotate @from, UnityEngine.UIElements.Rotate @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.TransformOrigin @from, UnityEngine.UIElements.TransformOrigin @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.BackgroundPosition @from, UnityEngine.UIElements.BackgroundPosition @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.BackgroundRepeat @from, UnityEngine.UIElements.BackgroundRepeat @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.BackgroundSize @from, UnityEngine.UIElements.BackgroundSize @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__CancelAnimation(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__CancelAnimation_StylePropertyId.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__CancelAllAnimations()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__CancelAllAnimations.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__HasRunningAnimation(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__HasRunningAnimation_StylePropertyId.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__UpdateAnimation(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__UpdateAnimation_StylePropertyId.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__GetAllAnimations(RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId> @outPropertyIds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outPropertyIds.Value};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__GetAllAnimations_List_d_StylePropertyId_p_.Invoke(___genericsType, ___parameters);

            
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


        public virtual RSystem.RNullable<RSystem.RSingle> GetParentSizeForLengthConversion(RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, System.Int32 @subPropertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @subPropertyIndex};
            var ___result = RMGetParentSizeForLengthConversion_StylePropertyId_Int32.Invoke(___genericsType, ___parameters);

            return new RSystem.RNullable<RSystem.RSingle>(___result);
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


        public virtual void UpdateWorldClip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateWorldClip.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect CombineClipRects(UnityEngine.Rect @rect, UnityEngine.Rect @parentRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @parentRect};
            var ___result = RMCombineClipRects_Rect_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual UnityEngine.Rect SubstractBorderPadding(UnityEngine.Rect @worldRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@worldRect};
            var ___result = RMSubstractBorderPadding_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public static UnityEngine.Rect ComputeAAAlignedBound(UnityEngine.Rect @position, UnityEngine.Matrix4x4 @mat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @mat};
            var ___result = RMComputeAAAlignedBound_Rect_Matrix4x4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void UpdateHoverPseudoState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateHoverPseudoState.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsPartOfCapturedChain(UnityEngine.UIElements.VisualElement @self, in UnityEngine.UIElements.IEventHandler @capturingElement)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @capturingElement};
            var ___result = RMIsPartOfCapturedChain_VisualElement_In_IEventHandler.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ChangeIMGUIContainerCount(System.Int32 @delta)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delta};
            var ___result = RMChangeIMGUIContainerCount_Int32.Invoke(___genericsType, ___parameters);

            
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


        public virtual void SetTooltip(UnityEngine.UIElements.TooltipEvent @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RMSetTooltip_TooltipEvent.Invoke(___genericsType, ___parameters);

            
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


        public virtual void WillChangePanel(RUnityEngine.RUIElements.RBaseVisualElementPanel @destinationPanel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destinationPanel.Value};
            var ___result = RMWillChangePanel_BaseVisualElementPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HasChangedPanel(RUnityEngine.RUIElements.RBaseVisualElementPanel @prevPanel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prevPanel.Value};
            var ___result = RMHasChangedPanel_BaseVisualElementPanel.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Boolean SetEnabledFromHierarchyPrivate(System.Boolean @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RMSetEnabledFromHierarchyPrivate_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetEnabled(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMSetEnabled_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PropagateEnabledToChildren(System.Boolean @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RMPropagateEnabledToChildren_Boolean.Invoke(___genericsType, ___parameters);

            
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


        public virtual void AssignMeasureFunction()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAssignMeasureFunction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveMeasureFunction()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRemoveMeasureFunction.Invoke(___genericsType, ___parameters);

            
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


        public virtual void FinalizeLayout()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalizeLayout.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Boolean TryGetPropertyInternal(UnityEngine.PropertyName @key, out System.Object @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RMTryGetPropertyInternal_PropertyName_Out_Object.Invoke(___genericsType, ___parameters);
			@value = (System.Object)___parameters[1];

            return (System.Boolean)___result;
        }


        public static void CheckUserKeyArgument(UnityEngine.PropertyName @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMCheckUserKeyArgument_PropertyName.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPropertyInternal(UnityEngine.PropertyName @key, System.Object @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RMSetPropertyInternal_PropertyName_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateCursorStyle(System.Int64 @eventType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventType};
            var ___result = RMUpdateCursorStyle_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Material getRuntimeMaterial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMgetRuntimeMaterial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Material)___result;
        }


        public virtual void ApplyPlayerRenderingToEditorElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMApplyPlayerRenderingToEditorElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RUnityEngine.RUIElements.RVisualElementAnimationSystem GetAnimationSystem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAnimationSystem.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RVisualElementAnimationSystem(___result);
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


        public virtual void UnregisterRunningAnimations()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUnregisterRunningAnimations.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterRunningAnimations()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMRegisterRunningAnimations.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<System.Single> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(System.Single @from, System.Single @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, System.Single> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Single_Single_Int32_Action_d_VisualElement_Single_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<System.Single>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(UnityEngine.Rect @from, UnityEngine.Rect @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Rect> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Rect_Rect_Int32_Action_d_VisualElement_Rect_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Color> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(UnityEngine.Color @from, UnityEngine.Color @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Color> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Color_Color_Int32_Action_d_VisualElement_Color_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Color>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(UnityEngine.Vector3 @from, UnityEngine.Vector3 @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Vector3> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Vector3_Vector3_Int32_Action_d_VisualElement_Vector3_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(UnityEngine.Vector2 @from, UnityEngine.Vector2 @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Vector2> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Vector2_Vector2_Int32_Action_d_VisualElement_Vector2_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(UnityEngine.Quaternion @from, UnityEngine.Quaternion @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Quaternion> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Quaternion_Quaternion_Int32_Action_d_VisualElement_Quaternion_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(UnityEngine.UIElements.Experimental.StyleValues @from, UnityEngine.UIElements.Experimental.StyleValues @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_StyleValues_StyleValues_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<System.Single> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(System.Func<UnityEngine.UIElements.VisualElement, System.Single> @fromValueGetter, System.Single @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, System.Single> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Single_p__Single_Int32_Action_d_VisualElement_Single_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<System.Single>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.Rect> @fromValueGetter, UnityEngine.Rect @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Rect> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Rect_p__Rect_Int32_Action_d_VisualElement_Rect_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Color> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.Color> @fromValueGetter, UnityEngine.Color @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Color> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Color_p__Color_Int32_Action_d_VisualElement_Color_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Color>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.Vector3> @fromValueGetter, UnityEngine.Vector3 @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Vector3> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Vector3_p__Vector3_Int32_Action_d_VisualElement_Vector3_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.Vector2> @fromValueGetter, UnityEngine.Vector2 @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Vector2> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Vector2_p__Vector2_Int32_Action_d_VisualElement_Vector2_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.Quaternion> @fromValueGetter, UnityEngine.Quaternion @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Quaternion> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Quaternion_p__Quaternion_Int32_Action_d_VisualElement_Quaternion_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion>)___result;
        }


        public static UnityEngine.UIElements.Experimental.ValueAnimation<T> StartAnimation<T>(UnityEngine.UIElements.Experimental.ValueAnimation<T> @anim, System.Func<UnityEngine.UIElements.VisualElement, T> @fromValueGetter, T @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, T> @onValueChanged)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@anim, @fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RMStartAnimation_GT_ValueAnimation_d_T_p__Func_d_VisualElement_T_p__T_Int32_Action_d_VisualElement_T_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<T>)___result;
        }


        public static void AssignStyleValues(UnityEngine.UIElements.VisualElement @ve, UnityEngine.UIElements.Experimental.StyleValues @src)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @src};
            var ___result = RMAssignStyleValues_VisualElement_StyleValues.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.Experimental.StyleValues ReadCurrentValues(UnityEngine.UIElements.VisualElement @ve, UnityEngine.UIElements.Experimental.StyleValues @targetValuesToRead)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @targetValuesToRead};
            var ___result = RMReadCurrentValues_VisualElement_StyleValues.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.StyleValues)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(UnityEngine.UIElements.Experimental.StyleValues @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_StyleValues_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.Experimental.StyleValues> @fromValueGetter, UnityEngine.UIElements.Experimental.StyleValues @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs};
            var ___result = RMStart_Func_d_VisualElement_StyleValues_p__StyleValues_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Layout(UnityEngine.Rect @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Layout_Rect_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__TopLeft(UnityEngine.Vector2 @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__TopLeft_Vector2_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Size(UnityEngine.Vector2 @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Size_Vector2_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<System.Single> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Scale(System.Single @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Scale_Single_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<System.Single>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Position(UnityEngine.Vector3 @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Position_Vector3_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Rotation(UnityEngine.Quaternion @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Rotation_Quaternion_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion>)___result;
        }


        public virtual void DirtyNextParentWithEventCallback()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDirtyNextParentWithEventCallback.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAsNextParentWithEventCallback()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSetAsNextParentWithEventCallback.Invoke(___genericsType, ___parameters);

            
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


        public virtual void UpdateCallbackParentCategories()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateCallbackParentCategories.Invoke(___genericsType, ___parameters);

            
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


        public virtual void GatherAllChildren(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> @elements)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elements};
            var ___result = RMGatherAllChildren_List_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            
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


        public static System.Single Min(System.Single @a, System.Single @b, System.Single @c, System.Single @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @c, @d};
            var ___result = RMMin_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single Max(System.Single @a, System.Single @b, System.Single @c, System.Single @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @c, @d};
            var ___result = RMMax_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void TransformAlignedRectToParentSpace(ref UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect};
            var ___result = RMTransformAlignedRectToParentSpace_Ref_Rect.Invoke(___genericsType, ___parameters);
			@rect = (UnityEngine.Rect)___parameters[0];

            
        }


        public static UnityEngine.Rect CalculateConservativeRect(ref UnityEngine.Matrix4x4 @matrix, UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @rect};
            var ___result = RMCalculateConservativeRect_Ref_Matrix4x4_Rect.Invoke(___genericsType, ___parameters);
			@matrix = (UnityEngine.Matrix4x4)___parameters[0];

            return (UnityEngine.Rect)___result;
        }


        public static void TransformAlignedRect(ref UnityEngine.Matrix4x4 @matrix, ref UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @rect};
            var ___result = RMTransformAlignedRect_Ref_Matrix4x4_Ref_Rect.Invoke(___genericsType, ___parameters);
			@matrix = (UnityEngine.Matrix4x4)___parameters[0];
			@rect = (UnityEngine.Rect)___parameters[1];

            
        }


        public static void OrderMinMaxRect(ref UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect};
            var ___result = RMOrderMinMaxRect_Ref_Rect.Invoke(___genericsType, ___parameters);
			@rect = (UnityEngine.Rect)___parameters[0];

            
        }


        public static UnityEngine.Vector2 MultiplyMatrix44Point2(ref UnityEngine.Matrix4x4 @lhs, UnityEngine.Vector2 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @point};
            var ___result = RMMultiplyMatrix44Point2_Ref_Matrix4x4_Vector2.Invoke(___genericsType, ___parameters);
			@lhs = (UnityEngine.Matrix4x4)___parameters[0];

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 MultiplyVector2(ref UnityEngine.Matrix4x4 @lhs, UnityEngine.Vector2 @vector)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @vector};
            var ___result = RMMultiplyVector2_Ref_Matrix4x4_Vector2.Invoke(___genericsType, ___parameters);
			@lhs = (UnityEngine.Matrix4x4)___parameters[0];

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Rect MultiplyMatrix44Rect2(ref UnityEngine.Matrix4x4 @lhs, UnityEngine.Rect @r)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @r};
            var ___result = RMMultiplyMatrix44Rect2_Ref_Matrix4x4_Rect.Invoke(___genericsType, ___parameters);
			@lhs = (UnityEngine.Matrix4x4)___parameters[0];

            return (UnityEngine.Rect)___result;
        }


        public static void MultiplyMatrix34(ref UnityEngine.Matrix4x4 @lhs, ref UnityEngine.Matrix4x4 @rhs, out UnityEngine.Matrix4x4 @res)
        {
			@res = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs, @res};
            var ___result = RMMultiplyMatrix34_Ref_Matrix4x4_Ref_Matrix4x4_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@lhs = (UnityEngine.Matrix4x4)___parameters[0];
			@rhs = (UnityEngine.Matrix4x4)___parameters[1];
			@res = (UnityEngine.Matrix4x4)___parameters[2];

            
        }


        public static void TranslateMatrix34(ref UnityEngine.Matrix4x4 @lhs, UnityEngine.Vector3 @rhs, out UnityEngine.Matrix4x4 @res)
        {
			@res = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs, @res};
            var ___result = RMTranslateMatrix34_Ref_Matrix4x4_Vector3_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@lhs = (UnityEngine.Matrix4x4)___parameters[0];
			@res = (UnityEngine.Matrix4x4)___parameters[2];

            
        }


        public static void TranslateMatrix34InPlace(ref UnityEngine.Matrix4x4 @lhs, UnityEngine.Vector3 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMTranslateMatrix34InPlace_Ref_Matrix4x4_Vector3.Invoke(___genericsType, ___parameters);
			@lhs = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual UnityEngine.UIElements.IVisualElementScheduledItem UnityEngine__2__UIElements__2__IVisualElementScheduler__2__Execute(System.Action<UnityEngine.UIElements.TimerState> @timerUpdateEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timerUpdateEvent};
            var ___result = RMUnityEngine__2__UIElements__2__IVisualElementScheduler__2__Execute_Action_d_TimerState_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.IVisualElementScheduledItem)___result;
        }


        public virtual UnityEngine.UIElements.IVisualElementScheduledItem UnityEngine__2__UIElements__2__IVisualElementScheduler__2__Execute(System.Action @updateEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updateEvent};
            var ___result = RMUnityEngine__2__UIElements__2__IVisualElementScheduler__2__Execute_Action.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.IVisualElementScheduledItem)___result;
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


        public virtual UnityEngine.UIElements.StyleFloat ResolveLengthValue(UnityEngine.UIElements.Length @length, System.Boolean @isRow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@length, @isRow};
            var ___result = RMResolveLengthValue_Length_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleFloat)___result;
        }


        public virtual UnityEngine.Vector3 ResolveTranslate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResolveTranslate.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 ResolveTransformOrigin()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResolveTransformOrigin.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Quaternion ResolveRotation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResolveRotation.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public virtual UnityEngine.Vector3 ResolveScale()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResolveScale.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static RUnityEngine.RUIElements.RVisualElement.RTypeData GetOrCreateTypeData(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMGetOrCreateTypeData_Type.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RUIElements.RVisualElement.RTypeData(___result);
        }


        public virtual RUnityEngine.RYoga.RYogaSize __0__AssignMeasureFunction__1__b__423_0(RUnityEngine.RYoga.RYogaNode @node, System.Single @f, RUnityEngine.RYoga.RYogaMeasureMode @mode, System.Single @f1, RUnityEngine.RYoga.RYogaMeasureMode @heightMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node.Value, @f, @mode.Value, @f1, @heightMode.Value};
            var ___result = RM__0__AssignMeasureFunction__1__b__423_0_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode.Invoke(___genericsType, ___parameters);

            return new RUnityEngine.RYoga.RYogaSize(___result);
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
