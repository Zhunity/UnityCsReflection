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
		protected RField r___1__UnityEngine__0__UIElements__0__IStylePropertyAnimations__0__runningAnimationCount__2__k__BackingField;
		public virtual RField R__1__UnityEngine__0__UIElements__0__IStylePropertyAnimations__0__runningAnimationCount__2__k__BackingField
		{
			get
			{
				if(r___1__UnityEngine__0__UIElements__0__IStylePropertyAnimations__0__runningAnimationCount__2__k__BackingField == null)
				{
					r___1__UnityEngine__0__UIElements__0__IStylePropertyAnimations__0__runningAnimationCount__2__k__BackingField = new(this, "<UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount>k__BackingField");
					r___1__UnityEngine__0__UIElements__0__IStylePropertyAnimations__0__runningAnimationCount__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__UnityEngine__0__UIElements__0__IStylePropertyAnimations__0__runningAnimationCount__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount>k__BackingField
		/// </summary>
		protected RField r___1__UnityEngine__0__UIElements__0__IStylePropertyAnimations__0__completedAnimationCount__2__k__BackingField;
		public virtual RField R__1__UnityEngine__0__UIElements__0__IStylePropertyAnimations__0__completedAnimationCount__2__k__BackingField
		{
			get
			{
				if(r___1__UnityEngine__0__UIElements__0__IStylePropertyAnimations__0__completedAnimationCount__2__k__BackingField == null)
				{
					r___1__UnityEngine__0__UIElements__0__IStylePropertyAnimations__0__completedAnimationCount__2__k__BackingField = new(this, "<UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount>k__BackingField");
					r___1__UnityEngine__0__UIElements__0__IStylePropertyAnimations__0__completedAnimationCount__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__UnityEngine__0__UIElements__0__IStylePropertyAnimations__0__completedAnimationCount__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.UInt32 s_NextId
		/// </summary>
		protected static RField r_s_NextId;
		public static RField Rs_NextId
		{
			get
			{
				if(r_s_NextId == null)
				{
					r_s_NextId = new(typeof(UnityEngine.UIElements.VisualElement), "s_NextId");
					r_s_NextId.SetBelong(null);
				}
				return r_s_NextId;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] s_EmptyClassList
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RList<RField> r_s_EmptyClassList;
		public static RSystem.RCollections.RGeneric.RList<RField> Rs_EmptyClassList
		{
			get
			{
				if(r_s_EmptyClassList == null)
				{
					r_s_EmptyClassList = new(typeof(UnityEngine.UIElements.VisualElement), "s_EmptyClassList");
					r_s_EmptyClassList.SetBelong(null);
				}
				return r_s_EmptyClassList;
			}
		}

		/// <summary>
		/// UnityEngine.PropertyName userDataPropertyKey
		/// </summary>
		protected static RUnityEngine.RPropertyName r_userDataPropertyKey;
		public static RUnityEngine.RPropertyName RuserDataPropertyKey
		{
			get
			{
				if(r_userDataPropertyKey == null)
				{
					r_userDataPropertyKey = new(typeof(UnityEngine.UIElements.VisualElement), "userDataPropertyKey");
					r_userDataPropertyKey.SetBelong(null);
				}
				return r_userDataPropertyKey;
			}
		}

		/// <summary>
		/// System.String disabledUssClassName
		/// </summary>
		protected static RField r_disabledUssClassName;
		public static RField RdisabledUssClassName
		{
			get
			{
				if(r_disabledUssClassName == null)
				{
					r_disabledUssClassName = new(typeof(UnityEngine.UIElements.VisualElement), "disabledUssClassName");
					r_disabledUssClassName.SetBelong(null);
				}
				return r_disabledUssClassName;
			}
		}

		/// <summary>
		/// System.String m_Name
		/// </summary>
		protected RField r_m_Name;
		public virtual RField Rm_Name
		{
			get
			{
				if(r_m_Name == null)
				{
					r_m_Name = new(this, "m_Name");
					r_m_Name.SetBelong(this.instance);
				}
				return r_m_Name;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_ClassList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_ClassList;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_ClassList
		{
			get
			{
				if(r_m_ClassList == null)
				{
					r_m_ClassList = new(this, "m_ClassList");
					r_m_ClassList.SetBelong(this.instance);
				}
				return r_m_ClassList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Collections.Generic.KeyValuePair`2[UnityEngine.PropertyName,System.Object]] m_PropertyBag
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RCollections.RGeneric.RKeyValuePair<RUnityEngine.RPropertyName, RSystem.RObject>> r_m_PropertyBag;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RCollections.RGeneric.RKeyValuePair<RUnityEngine.RPropertyName, RSystem.RObject>> Rm_PropertyBag
		{
			get
			{
				if(r_m_PropertyBag == null)
				{
					r_m_PropertyBag = new(this, "m_PropertyBag");
					r_m_PropertyBag.SetBelong(this.instance);
				}
				return r_m_PropertyBag;
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
		/// System.String m_ViewDataKey
		/// </summary>
		protected RField r_m_ViewDataKey;
		public virtual RField Rm_ViewDataKey
		{
			get
			{
				if(r_m_ViewDataKey == null)
				{
					r_m_ViewDataKey = new(this, "m_ViewDataKey");
					r_m_ViewDataKey.SetBelong(this.instance);
				}
				return r_m_ViewDataKey;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.RenderHints m_RenderHints
		/// </summary>
		protected RField r_m_RenderHints;
		public virtual RField Rm_RenderHints
		{
			get
			{
				if(r_m_RenderHints == null)
				{
					r_m_RenderHints = new(this, "m_RenderHints");
					r_m_RenderHints.SetBelong(this.instance);
				}
				return r_m_RenderHints;
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
		/// UnityEngine.Rect m_Layout
		/// </summary>
		protected RUnityEngine.RRect r_m_Layout;
		public virtual RUnityEngine.RRect Rm_Layout
		{
			get
			{
				if(r_m_Layout == null)
				{
					r_m_Layout = new(this, "m_Layout");
					r_m_Layout.SetBelong(this.instance);
				}
				return r_m_Layout;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_BoundingBox
		/// </summary>
		protected RUnityEngine.RRect r_m_BoundingBox;
		public virtual RUnityEngine.RRect Rm_BoundingBox
		{
			get
			{
				if(r_m_BoundingBox == null)
				{
					r_m_BoundingBox = new(this, "m_BoundingBox");
					r_m_BoundingBox.SetBelong(this.instance);
				}
				return r_m_BoundingBox;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags worldBoundingBoxDirtyDependencies
		/// </summary>
		protected static RField r_worldBoundingBoxDirtyDependencies;
		public static RField RworldBoundingBoxDirtyDependencies
		{
			get
			{
				if(r_worldBoundingBoxDirtyDependencies == null)
				{
					r_worldBoundingBoxDirtyDependencies = new(typeof(UnityEngine.UIElements.VisualElement), "worldBoundingBoxDirtyDependencies");
					r_worldBoundingBoxDirtyDependencies.SetBelong(null);
				}
				return r_worldBoundingBoxDirtyDependencies;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_WorldBoundingBox
		/// </summary>
		protected RUnityEngine.RRect r_m_WorldBoundingBox;
		public virtual RUnityEngine.RRect Rm_WorldBoundingBox
		{
			get
			{
				if(r_m_WorldBoundingBox == null)
				{
					r_m_WorldBoundingBox = new(this, "m_WorldBoundingBox");
					r_m_WorldBoundingBox.SetBelong(this.instance);
				}
				return r_m_WorldBoundingBox;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags worldTransformInverseDirtyDependencies
		/// </summary>
		protected static RField r_worldTransformInverseDirtyDependencies;
		public static RField RworldTransformInverseDirtyDependencies
		{
			get
			{
				if(r_worldTransformInverseDirtyDependencies == null)
				{
					r_worldTransformInverseDirtyDependencies = new(typeof(UnityEngine.UIElements.VisualElement), "worldTransformInverseDirtyDependencies");
					r_worldTransformInverseDirtyDependencies.SetBelong(null);
				}
				return r_worldTransformInverseDirtyDependencies;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 m_WorldTransformCache
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_m_WorldTransformCache;
		public virtual RUnityEngine.RMatrix4x4 Rm_WorldTransformCache
		{
			get
			{
				if(r_m_WorldTransformCache == null)
				{
					r_m_WorldTransformCache = new(this, "m_WorldTransformCache");
					r_m_WorldTransformCache.SetBelong(this.instance);
				}
				return r_m_WorldTransformCache;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 m_WorldTransformInverseCache
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_m_WorldTransformInverseCache;
		public virtual RUnityEngine.RMatrix4x4 Rm_WorldTransformInverseCache
		{
			get
			{
				if(r_m_WorldTransformInverseCache == null)
				{
					r_m_WorldTransformInverseCache = new(this, "m_WorldTransformInverseCache");
					r_m_WorldTransformInverseCache.SetBelong(this.instance);
				}
				return r_m_WorldTransformInverseCache;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_WorldClip
		/// </summary>
		protected RUnityEngine.RRect r_m_WorldClip;
		public virtual RUnityEngine.RRect Rm_WorldClip
		{
			get
			{
				if(r_m_WorldClip == null)
				{
					r_m_WorldClip = new(this, "m_WorldClip");
					r_m_WorldClip.SetBelong(this.instance);
				}
				return r_m_WorldClip;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_WorldClipMinusGroup
		/// </summary>
		protected RUnityEngine.RRect r_m_WorldClipMinusGroup;
		public virtual RUnityEngine.RRect Rm_WorldClipMinusGroup
		{
			get
			{
				if(r_m_WorldClipMinusGroup == null)
				{
					r_m_WorldClipMinusGroup = new(this, "m_WorldClipMinusGroup");
					r_m_WorldClipMinusGroup.SetBelong(this.instance);
				}
				return r_m_WorldClipMinusGroup;
			}
		}

		/// <summary>
		/// System.Boolean m_WorldClipIsInfinite
		/// </summary>
		protected RField r_m_WorldClipIsInfinite;
		public virtual RField Rm_WorldClipIsInfinite
		{
			get
			{
				if(r_m_WorldClipIsInfinite == null)
				{
					r_m_WorldClipIsInfinite = new(this, "m_WorldClipIsInfinite");
					r_m_WorldClipIsInfinite.SetBelong(this.instance);
				}
				return r_m_WorldClipIsInfinite;
			}
		}

		/// <summary>
		/// UnityEngine.Rect s_InfiniteRect
		/// </summary>
		protected static RUnityEngine.RRect r_s_InfiniteRect;
		public static RUnityEngine.RRect Rs_InfiniteRect
		{
			get
			{
				if(r_s_InfiniteRect == null)
				{
					r_s_InfiniteRect = new(typeof(UnityEngine.UIElements.VisualElement), "s_InfiniteRect");
					r_s_InfiniteRect.SetBelong(null);
				}
				return r_s_InfiniteRect;
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
		/// UnityEngine.UIElements.PseudoStates m_PseudoStates
		/// </summary>
		protected RField r_m_PseudoStates;
		public virtual RField Rm_PseudoStates
		{
			get
			{
				if(r_m_PseudoStates == null)
				{
					r_m_PseudoStates = new(this, "m_PseudoStates");
					r_m_PseudoStates.SetBelong(this.instance);
				}
				return r_m_PseudoStates;
			}
		}

		/// <summary>
		/// System.Int32 <containedPointerIds>k__BackingField
		/// </summary>
		protected RField r___1__containedPointerIds__2__k__BackingField;
		public virtual RField R__1__containedPointerIds__2__k__BackingField
		{
			get
			{
				if(r___1__containedPointerIds__2__k__BackingField == null)
				{
					r___1__containedPointerIds__2__k__BackingField = new(this, "<containedPointerIds>k__BackingField");
					r___1__containedPointerIds__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__containedPointerIds__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PickingMode <pickingMode>k__BackingField
		/// </summary>
		protected RField r___1__pickingMode__2__k__BackingField;
		public virtual RField R__1__pickingMode__2__k__BackingField
		{
			get
			{
				if(r___1__pickingMode__2__k__BackingField == null)
				{
					r___1__pickingMode__2__k__BackingField = new(this, "<pickingMode>k__BackingField");
					r___1__pickingMode__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__pickingMode__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaNode <yogaNode>k__BackingField
		/// </summary>
		protected RUnityEngine.RYoga.RYogaNode r___1__yogaNode__2__k__BackingField;
		public virtual RUnityEngine.RYoga.RYogaNode R__1__yogaNode__2__k__BackingField
		{
			get
			{
				if(r___1__yogaNode__2__k__BackingField == null)
				{
					r___1__yogaNode__2__k__BackingField = new(this, "<yogaNode>k__BackingField");
					r___1__yogaNode__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__yogaNode__2__k__BackingField;
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
		/// System.Boolean <enabledSelf>k__BackingField
		/// </summary>
		protected RField r___1__enabledSelf__2__k__BackingField;
		public virtual RField R__1__enabledSelf__2__k__BackingField
		{
			get
			{
				if(r___1__enabledSelf__2__k__BackingField == null)
				{
					r___1__enabledSelf__2__k__BackingField = new(this, "<enabledSelf>k__BackingField");
					r___1__enabledSelf__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__enabledSelf__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.MeshGenerationContext] <generateVisualContent>k__BackingField
		/// </summary>
		protected RSystem.RAction<RUnityEngine.RUIElements.RMeshGenerationContext> r___1__generateVisualContent__2__k__BackingField;
		public virtual RSystem.RAction<RUnityEngine.RUIElements.RMeshGenerationContext> R__1__generateVisualContent__2__k__BackingField
		{
			get
			{
				if(r___1__generateVisualContent__2__k__BackingField == null)
				{
					r___1__generateVisualContent__2__k__BackingField = new(this, "<generateVisualContent>k__BackingField");
					r___1__generateVisualContent__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__generateVisualContent__2__k__BackingField;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_GenerateVisualContentMarker
		/// </summary>
		protected RUnity.RProfiling.RProfilerMarker r_k_GenerateVisualContentMarker;
		public virtual RUnity.RProfiling.RProfilerMarker Rk_GenerateVisualContentMarker
		{
			get
			{
				if(r_k_GenerateVisualContentMarker == null)
				{
					r_k_GenerateVisualContentMarker = new(this, "k_GenerateVisualContentMarker");
					r_k_GenerateVisualContentMarker.SetBelong(this.instance);
				}
				return r_k_GenerateVisualContentMarker;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement+RenderTargetMode m_SubRenderTargetMode
		/// </summary>
		protected RField r_m_SubRenderTargetMode;
		public virtual RField Rm_SubRenderTargetMode
		{
			get
			{
				if(r_m_SubRenderTargetMode == null)
				{
					r_m_SubRenderTargetMode = new(this, "m_SubRenderTargetMode");
					r_m_SubRenderTargetMode.SetBelong(this.instance);
				}
				return r_m_SubRenderTargetMode;
			}
		}

		/// <summary>
		/// UnityEngine.Material s_runtimeMaterial
		/// </summary>
		protected static RUnityEngine.RMaterial r_s_runtimeMaterial;
		public static RUnityEngine.RMaterial Rs_runtimeMaterial
		{
			get
			{
				if(r_s_runtimeMaterial == null)
				{
					r_s_runtimeMaterial = new(typeof(UnityEngine.UIElements.VisualElement), "s_runtimeMaterial");
					r_s_runtimeMaterial.SetBelong(null);
				}
				return r_s_runtimeMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material m_defaultMaterial
		/// </summary>
		protected RUnityEngine.RMaterial r_m_defaultMaterial;
		public virtual RUnityEngine.RMaterial Rm_defaultMaterial
		{
			get
			{
				if(r_m_defaultMaterial == null)
				{
					r_m_defaultMaterial = new(this, "m_defaultMaterial");
					r_m_defaultMaterial.SetBelong(this.instance);
				}
				return r_m_defaultMaterial;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.Experimental.IValueAnimationUpdate] m_RunningAnimations
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate> r_m_RunningAnimations;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate> Rm_RunningAnimations
		{
			get
			{
				if(r_m_RunningAnimations == null)
				{
					r_m_RunningAnimations = new(this, "m_RunningAnimations");
					r_m_RunningAnimations.SetBelong(this.instance);
				}
				return r_m_RunningAnimations;
			}
		}

		/// <summary>
		/// System.UInt32 s_NextParentVersion
		/// </summary>
		protected static RField r_s_NextParentVersion;
		public static RField Rs_NextParentVersion
		{
			get
			{
				if(r_s_NextParentVersion == null)
				{
					r_s_NextParentVersion = new(typeof(UnityEngine.UIElements.VisualElement), "s_NextParentVersion");
					r_s_NextParentVersion.SetBelong(null);
				}
				return r_s_NextParentVersion;
			}
		}

		/// <summary>
		/// System.UInt32 m_NextParentCachedVersion
		/// </summary>
		protected RField r_m_NextParentCachedVersion;
		public virtual RField Rm_NextParentCachedVersion
		{
			get
			{
				if(r_m_NextParentCachedVersion == null)
				{
					r_m_NextParentCachedVersion = new(this, "m_NextParentCachedVersion");
					r_m_NextParentCachedVersion.SetBelong(this.instance);
				}
				return r_m_NextParentCachedVersion;
			}
		}

		/// <summary>
		/// System.UInt32 m_NextParentRequiredVersion
		/// </summary>
		protected RField r_m_NextParentRequiredVersion;
		public virtual RField Rm_NextParentRequiredVersion
		{
			get
			{
				if(r_m_NextParentRequiredVersion == null)
				{
					r_m_NextParentRequiredVersion = new(this, "m_NextParentRequiredVersion");
					r_m_NextParentRequiredVersion.SetBelong(this.instance);
				}
				return r_m_NextParentRequiredVersion;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_CachedNextParentWithEventCallback
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_m_CachedNextParentWithEventCallback;
		public virtual RUnityEngine.RUIElements.RVisualElement Rm_CachedNextParentWithEventCallback
		{
			get
			{
				if(r_m_CachedNextParentWithEventCallback == null)
				{
					r_m_CachedNextParentWithEventCallback = new(this, "m_CachedNextParentWithEventCallback");
					r_m_CachedNextParentWithEventCallback.SetBelong(this.instance);
				}
				return r_m_CachedNextParentWithEventCallback;
			}
		}

		/// <summary>
		/// System.Int32 m_EventCallbackCategories
		/// </summary>
		protected RField r_m_EventCallbackCategories;
		public virtual RField Rm_EventCallbackCategories
		{
			get
			{
				if(r_m_EventCallbackCategories == null)
				{
					r_m_EventCallbackCategories = new(this, "m_EventCallbackCategories");
					r_m_EventCallbackCategories.SetBelong(this.instance);
				}
				return r_m_EventCallbackCategories;
			}
		}

		/// <summary>
		/// System.Int32 m_CachedEventCallbackParentCategories
		/// </summary>
		protected RField r_m_CachedEventCallbackParentCategories;
		public virtual RField Rm_CachedEventCallbackParentCategories
		{
			get
			{
				if(r_m_CachedEventCallbackParentCategories == null)
				{
					r_m_CachedEventCallbackParentCategories = new(this, "m_CachedEventCallbackParentCategories");
					r_m_CachedEventCallbackParentCategories.SetBelong(this.instance);
				}
				return r_m_CachedEventCallbackParentCategories;
			}
		}

		/// <summary>
		/// System.Int32 m_DefaultActionEventCategories
		/// </summary>
		protected RField r_m_DefaultActionEventCategories;
		public virtual RField Rm_DefaultActionEventCategories
		{
			get
			{
				if(r_m_DefaultActionEventCategories == null)
				{
					r_m_DefaultActionEventCategories = new(this, "m_DefaultActionEventCategories");
					r_m_DefaultActionEventCategories.SetBelong(this.instance);
				}
				return r_m_DefaultActionEventCategories;
			}
		}

		/// <summary>
		/// System.Int32 m_DefaultActionAtTargetEventCategories
		/// </summary>
		protected RField r_m_DefaultActionAtTargetEventCategories;
		public virtual RField Rm_DefaultActionAtTargetEventCategories
		{
			get
			{
				if(r_m_DefaultActionAtTargetEventCategories == null)
				{
					r_m_DefaultActionAtTargetEventCategories = new(this, "m_DefaultActionAtTargetEventCategories");
					r_m_DefaultActionAtTargetEventCategories.SetBelong(this.instance);
				}
				return r_m_DefaultActionAtTargetEventCategories;
			}
		}

		/// <summary>
		/// System.String k_RootVisualContainerName
		/// </summary>
		protected static RField r_k_RootVisualContainerName;
		public static RField Rk_RootVisualContainerName
		{
			get
			{
				if(r_k_RootVisualContainerName == null)
				{
					r_k_RootVisualContainerName = new(typeof(UnityEngine.UIElements.VisualElement), "k_RootVisualContainerName");
					r_k_RootVisualContainerName.SetBelong(null);
				}
				return r_k_RootVisualContainerName;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement+Hierarchy <hierarchy>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement.RHierarchy r___1__hierarchy__2__k__BackingField;
		public virtual RUnityEngine.RUIElements.RVisualElement.RHierarchy R__1__hierarchy__2__k__BackingField
		{
			get
			{
				if(r___1__hierarchy__2__k__BackingField == null)
				{
					r___1__hierarchy__2__k__BackingField = new(this, "<hierarchy>k__BackingField");
					r___1__hierarchy__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__hierarchy__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <isRootVisualContainer>k__BackingField
		/// </summary>
		protected RField r___1__isRootVisualContainer__2__k__BackingField;
		public virtual RField R__1__isRootVisualContainer__2__k__BackingField
		{
			get
			{
				if(r___1__isRootVisualContainer__2__k__BackingField == null)
				{
					r___1__isRootVisualContainer__2__k__BackingField = new(this, "<isRootVisualContainer>k__BackingField");
					r___1__isRootVisualContainer__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__isRootVisualContainer__2__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <cacheAsBitmap>k__BackingField
		/// </summary>
		protected RField r___1__cacheAsBitmap__2__k__BackingField;
		public virtual RField R__1__cacheAsBitmap__2__k__BackingField
		{
			get
			{
				if(r___1__cacheAsBitmap__2__k__BackingField == null)
				{
					r___1__cacheAsBitmap__2__k__BackingField = new(this, "<cacheAsBitmap>k__BackingField");
					r___1__cacheAsBitmap__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__cacheAsBitmap__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_PhysicalParent
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_m_PhysicalParent;
		public virtual RUnityEngine.RUIElements.RVisualElement Rm_PhysicalParent
		{
			get
			{
				if(r_m_PhysicalParent == null)
				{
					r_m_PhysicalParent = new(this, "m_PhysicalParent");
					r_m_PhysicalParent.SetBelong(this.instance);
				}
				return r_m_PhysicalParent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_LogicalParent
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_m_LogicalParent;
		public virtual RUnityEngine.RUIElements.RVisualElement Rm_LogicalParent
		{
			get
			{
				if(r_m_LogicalParent == null)
				{
					r_m_LogicalParent = new(this, "m_LogicalParent");
					r_m_LogicalParent.SetBelong(this.instance);
				}
				return r_m_LogicalParent;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement] s_EmptyList
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElement> r_s_EmptyList;
		public static RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElement> Rs_EmptyList
		{
			get
			{
				if(r_s_EmptyList == null)
				{
					r_s_EmptyList = new(typeof(UnityEngine.UIElements.VisualElement), "s_EmptyList");
					r_s_EmptyList.SetBelong(null);
				}
				return r_s_EmptyList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement] m_Children
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElement> r_m_Children;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RVisualElement> Rm_Children
		{
			get
			{
				if(r_m_Children == null)
				{
					r_m_Children = new(this, "m_Children");
					r_m_Children.SetBelong(this.instance);
				}
				return r_m_Children;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseVisualElementPanel <elementPanel>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RBaseVisualElementPanel r___1__elementPanel__2__k__BackingField;
		public virtual RUnityEngine.RUIElements.RBaseVisualElementPanel R__1__elementPanel__2__k__BackingField
		{
			get
			{
				if(r___1__elementPanel__2__k__BackingField == null)
				{
					r___1__elementPanel__2__k__BackingField = new(this, "<elementPanel>k__BackingField");
					r___1__elementPanel__2__k__BackingField.SetBelong(this.instance);
				}
				return r___1__elementPanel__2__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset m_VisualTreeAssetSource
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualTreeAsset r_m_VisualTreeAssetSource;
		public virtual RUnityEngine.RUIElements.RVisualTreeAsset Rm_VisualTreeAssetSource
		{
			get
			{
				if(r_m_VisualTreeAssetSource == null)
				{
					r_m_VisualTreeAssetSource = new(this, "m_VisualTreeAssetSource");
					r_m_VisualTreeAssetSource.SetBelong(this.instance);
				}
				return r_m_VisualTreeAssetSource;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement+CustomStyleAccess s_CustomStyleAccess
		/// </summary>
		protected static RUnityEngine.RUIElements.RVisualElement.RCustomStyleAccess r_s_CustomStyleAccess;
		public static RUnityEngine.RUIElements.RVisualElement.RCustomStyleAccess Rs_CustomStyleAccess
		{
			get
			{
				if(r_s_CustomStyleAccess == null)
				{
					r_s_CustomStyleAccess = new(typeof(UnityEngine.UIElements.VisualElement), "s_CustomStyleAccess");
					r_s_CustomStyleAccess.SetBelong(null);
				}
				return r_s_CustomStyleAccess;
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
		/// System.Text.RegularExpressions.Regex s_InternalStyleSheetPath
		/// </summary>
		protected static RSystem.RText.RRegularExpressions.RRegex r_s_InternalStyleSheetPath;
		public static RSystem.RText.RRegularExpressions.RRegex Rs_InternalStyleSheetPath
		{
			get
			{
				if(r_s_InternalStyleSheetPath == null)
				{
					r_s_InternalStyleSheetPath = new(typeof(UnityEngine.UIElements.VisualElement), "s_InternalStyleSheetPath");
					r_s_InternalStyleSheetPath.SetBelong(null);
				}
				return r_s_InternalStyleSheetPath;
			}
		}

		/// <summary>
		/// UnityEngine.PropertyName tooltipPropertyKey
		/// </summary>
		protected static RUnityEngine.RPropertyName r_tooltipPropertyKey;
		public static RUnityEngine.RPropertyName RtooltipPropertyKey
		{
			get
			{
				if(r_tooltipPropertyKey == null)
				{
					r_tooltipPropertyKey = new(typeof(UnityEngine.UIElements.VisualElement), "tooltipPropertyKey");
					r_tooltipPropertyKey.SetBelong(null);
				}
				return r_tooltipPropertyKey;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Type,UnityEngine.UIElements.VisualElement+TypeData] s_TypeData
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RSystem.RType, RUnityEngine.RUIElements.RVisualElement.RTypeData> r_s_TypeData;
		public static RSystem.RCollections.RGeneric.RDictionary<RSystem.RType, RUnityEngine.RUIElements.RVisualElement.RTypeData> Rs_TypeData
		{
			get
			{
				if(r_s_TypeData == null)
				{
					r_s_TypeData = new(typeof(UnityEngine.UIElements.VisualElement), "s_TypeData");
					r_s_TypeData.SetBelong(null);
				}
				return r_s_TypeData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement+TypeData m_TypeData
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement.RTypeData r_m_TypeData;
		public virtual RUnityEngine.RUIElements.RVisualElement.RTypeData Rm_TypeData
		{
			get
			{
				if(r_m_TypeData == null)
				{
					r_m_TypeData = new(this, "m_TypeData");
					r_m_TypeData.SetBelong(this.instance);
				}
				return r_m_TypeData;
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
		/// UnityEngine.UIElements.Align UnityEngine.UIElements.IResolvedStyle.alignContent
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_alignContent;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_alignContent
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_alignContent == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_alignContent = new(this, "UnityEngine.UIElements.IResolvedStyle.alignContent", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_alignContent.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_alignContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Align UnityEngine.UIElements.IResolvedStyle.alignItems
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_alignItems;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_alignItems
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_alignItems == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_alignItems = new(this, "UnityEngine.UIElements.IResolvedStyle.alignItems", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_alignItems.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_alignItems;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Align UnityEngine.UIElements.IResolvedStyle.alignSelf
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_alignSelf;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_alignSelf
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_alignSelf == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_alignSelf = new(this, "UnityEngine.UIElements.IResolvedStyle.alignSelf", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_alignSelf.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_alignSelf;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.backgroundColor
		/// </summary>
		protected RUnityEngine.RColor r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundColor;
		public virtual RUnityEngine.RColor RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundColor
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundColor == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundColor = new(this, "UnityEngine.UIElements.IResolvedStyle.backgroundColor", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundColor.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Background UnityEngine.UIElements.IResolvedStyle.backgroundImage
		/// </summary>
		protected RUnityEngine.RUIElements.RBackground r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundImage;
		public virtual RUnityEngine.RUIElements.RBackground RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundImage
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundImage == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundImage = new(this, "UnityEngine.UIElements.IResolvedStyle.backgroundImage", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundImage.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundImage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition UnityEngine.UIElements.IResolvedStyle.backgroundPositionX
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundPosition r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundPositionX;
		public virtual RUnityEngine.RUIElements.RBackgroundPosition RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundPositionX
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundPositionX == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundPositionX = new(this, "UnityEngine.UIElements.IResolvedStyle.backgroundPositionX", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundPositionX.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundPositionX;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition UnityEngine.UIElements.IResolvedStyle.backgroundPositionY
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundPosition r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundPositionY;
		public virtual RUnityEngine.RUIElements.RBackgroundPosition RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundPositionY
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundPositionY == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundPositionY = new(this, "UnityEngine.UIElements.IResolvedStyle.backgroundPositionY", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundPositionY.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundPositionY;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundRepeat UnityEngine.UIElements.IResolvedStyle.backgroundRepeat
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundRepeat r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundRepeat;
		public virtual RUnityEngine.RUIElements.RBackgroundRepeat RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundRepeat
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundRepeat == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundRepeat = new(this, "UnityEngine.UIElements.IResolvedStyle.backgroundRepeat", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundRepeat.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundRepeat;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundSize UnityEngine.UIElements.IResolvedStyle.backgroundSize
		/// </summary>
		protected RUnityEngine.RUIElements.RBackgroundSize r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundSize;
		public virtual RUnityEngine.RUIElements.RBackgroundSize RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundSize
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundSize == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundSize = new(this, "UnityEngine.UIElements.IResolvedStyle.backgroundSize", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundSize.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_backgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.borderBottomColor
		/// </summary>
		protected RUnityEngine.RColor r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomColor;
		public virtual RUnityEngine.RColor RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomColor
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomColor == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomColor = new(this, "UnityEngine.UIElements.IResolvedStyle.borderBottomColor", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomColor.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomColor;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderBottomLeftRadius
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomLeftRadius;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomLeftRadius
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomLeftRadius == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomLeftRadius = new(this, "UnityEngine.UIElements.IResolvedStyle.borderBottomLeftRadius", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomLeftRadius.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomLeftRadius;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderBottomRightRadius
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomRightRadius;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomRightRadius
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomRightRadius == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomRightRadius = new(this, "UnityEngine.UIElements.IResolvedStyle.borderBottomRightRadius", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomRightRadius.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomRightRadius;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderBottomWidth
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomWidth;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomWidth
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomWidth == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomWidth = new(this, "UnityEngine.UIElements.IResolvedStyle.borderBottomWidth", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomWidth.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderBottomWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.borderLeftColor
		/// </summary>
		protected RUnityEngine.RColor r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderLeftColor;
		public virtual RUnityEngine.RColor RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderLeftColor
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderLeftColor == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderLeftColor = new(this, "UnityEngine.UIElements.IResolvedStyle.borderLeftColor", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderLeftColor.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderLeftColor;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderLeftWidth
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderLeftWidth;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderLeftWidth
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderLeftWidth == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderLeftWidth = new(this, "UnityEngine.UIElements.IResolvedStyle.borderLeftWidth", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderLeftWidth.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderLeftWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.borderRightColor
		/// </summary>
		protected RUnityEngine.RColor r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderRightColor;
		public virtual RUnityEngine.RColor RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderRightColor
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderRightColor == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderRightColor = new(this, "UnityEngine.UIElements.IResolvedStyle.borderRightColor", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderRightColor.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderRightColor;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderRightWidth
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderRightWidth;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderRightWidth
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderRightWidth == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderRightWidth = new(this, "UnityEngine.UIElements.IResolvedStyle.borderRightWidth", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderRightWidth.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderRightWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.borderTopColor
		/// </summary>
		protected RUnityEngine.RColor r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopColor;
		public virtual RUnityEngine.RColor RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopColor
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopColor == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopColor = new(this, "UnityEngine.UIElements.IResolvedStyle.borderTopColor", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopColor.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopColor;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderTopLeftRadius
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopLeftRadius;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopLeftRadius
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopLeftRadius == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopLeftRadius = new(this, "UnityEngine.UIElements.IResolvedStyle.borderTopLeftRadius", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopLeftRadius.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopLeftRadius;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderTopRightRadius
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopRightRadius;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopRightRadius
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopRightRadius == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopRightRadius = new(this, "UnityEngine.UIElements.IResolvedStyle.borderTopRightRadius", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopRightRadius.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopRightRadius;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderTopWidth
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopWidth;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopWidth
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopWidth == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopWidth = new(this, "UnityEngine.UIElements.IResolvedStyle.borderTopWidth", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopWidth.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_borderTopWidth;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.bottom
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_bottom;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_bottom
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_bottom == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_bottom = new(this, "UnityEngine.UIElements.IResolvedStyle.bottom", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_bottom.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_bottom;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.color
		/// </summary>
		protected RUnityEngine.RColor r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_color;
		public virtual RUnityEngine.RColor RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_color
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_color == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_color = new(this, "UnityEngine.UIElements.IResolvedStyle.color", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_color.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_color;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DisplayStyle UnityEngine.UIElements.IResolvedStyle.display
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_display;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_display
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_display == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_display = new(this, "UnityEngine.UIElements.IResolvedStyle.display", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_display.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_display;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.flexBasis
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexBasis;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexBasis
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexBasis == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexBasis = new(this, "UnityEngine.UIElements.IResolvedStyle.flexBasis", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexBasis.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexBasis;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FlexDirection UnityEngine.UIElements.IResolvedStyle.flexDirection
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexDirection;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexDirection
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexDirection == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexDirection = new(this, "UnityEngine.UIElements.IResolvedStyle.flexDirection", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexDirection.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexDirection;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.flexGrow
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexGrow;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexGrow
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexGrow == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexGrow = new(this, "UnityEngine.UIElements.IResolvedStyle.flexGrow", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexGrow.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexGrow;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.flexShrink
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexShrink;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexShrink
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexShrink == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexShrink = new(this, "UnityEngine.UIElements.IResolvedStyle.flexShrink", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexShrink.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexShrink;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Wrap UnityEngine.UIElements.IResolvedStyle.flexWrap
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexWrap;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexWrap
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexWrap == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexWrap = new(this, "UnityEngine.UIElements.IResolvedStyle.flexWrap", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexWrap.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_flexWrap;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.fontSize
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_fontSize;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_fontSize
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_fontSize == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_fontSize = new(this, "UnityEngine.UIElements.IResolvedStyle.fontSize", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_fontSize.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_fontSize;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.height
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_height;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_height
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_height == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_height = new(this, "UnityEngine.UIElements.IResolvedStyle.height", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_height.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_height;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Justify UnityEngine.UIElements.IResolvedStyle.justifyContent
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_justifyContent;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_justifyContent
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_justifyContent == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_justifyContent = new(this, "UnityEngine.UIElements.IResolvedStyle.justifyContent", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_justifyContent.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_justifyContent;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.left
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_left;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_left
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_left == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_left = new(this, "UnityEngine.UIElements.IResolvedStyle.left", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_left.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_left;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.letterSpacing
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_letterSpacing;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_letterSpacing
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_letterSpacing == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_letterSpacing = new(this, "UnityEngine.UIElements.IResolvedStyle.letterSpacing", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_letterSpacing.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_letterSpacing;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.marginBottom
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginBottom;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginBottom
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginBottom == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginBottom = new(this, "UnityEngine.UIElements.IResolvedStyle.marginBottom", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginBottom.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginBottom;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.marginLeft
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginLeft;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginLeft
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginLeft == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginLeft = new(this, "UnityEngine.UIElements.IResolvedStyle.marginLeft", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginLeft.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginLeft;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.marginRight
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginRight;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginRight
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginRight == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginRight = new(this, "UnityEngine.UIElements.IResolvedStyle.marginRight", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginRight.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginRight;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.marginTop
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginTop;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginTop
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginTop == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginTop = new(this, "UnityEngine.UIElements.IResolvedStyle.marginTop", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginTop.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_marginTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.maxHeight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_maxHeight;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_maxHeight
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_maxHeight == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_maxHeight = new(this, "UnityEngine.UIElements.IResolvedStyle.maxHeight", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_maxHeight.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_maxHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.maxWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_maxWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_maxWidth
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_maxWidth == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_maxWidth = new(this, "UnityEngine.UIElements.IResolvedStyle.maxWidth", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_maxWidth.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_maxWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.minHeight
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_minHeight;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_minHeight
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_minHeight == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_minHeight = new(this, "UnityEngine.UIElements.IResolvedStyle.minHeight", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_minHeight.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_minHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.minWidth
		/// </summary>
		protected RUnityEngine.RUIElements.RStyleFloat r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_minWidth;
		public virtual RUnityEngine.RUIElements.RStyleFloat RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_minWidth
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_minWidth == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_minWidth = new(this, "UnityEngine.UIElements.IResolvedStyle.minWidth", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_minWidth.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_minWidth;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.opacity
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_opacity;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_opacity
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_opacity == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_opacity = new(this, "UnityEngine.UIElements.IResolvedStyle.opacity", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_opacity.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_opacity;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.paddingBottom
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingBottom;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingBottom
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingBottom == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingBottom = new(this, "UnityEngine.UIElements.IResolvedStyle.paddingBottom", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingBottom.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingBottom;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.paddingLeft
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingLeft;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingLeft
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingLeft == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingLeft = new(this, "UnityEngine.UIElements.IResolvedStyle.paddingLeft", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingLeft.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingLeft;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.paddingRight
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingRight;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingRight
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingRight == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingRight = new(this, "UnityEngine.UIElements.IResolvedStyle.paddingRight", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingRight.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingRight;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.paddingTop
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingTop;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingTop
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingTop == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingTop = new(this, "UnityEngine.UIElements.IResolvedStyle.paddingTop", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingTop.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_paddingTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Position UnityEngine.UIElements.IResolvedStyle.position
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_position;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_position
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_position == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_position = new(this, "UnityEngine.UIElements.IResolvedStyle.position", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_position.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_position;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.right
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_right;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_right
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_right == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_right = new(this, "UnityEngine.UIElements.IResolvedStyle.right", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_right.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_right;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Rotate UnityEngine.UIElements.IResolvedStyle.rotate
		/// </summary>
		protected RUnityEngine.RUIElements.RRotate r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_rotate;
		public virtual RUnityEngine.RUIElements.RRotate RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_rotate
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_rotate == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_rotate = new(this, "UnityEngine.UIElements.IResolvedStyle.rotate", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_rotate.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_rotate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Scale UnityEngine.UIElements.IResolvedStyle.scale
		/// </summary>
		protected RUnityEngine.RUIElements.RScale r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_scale;
		public virtual RUnityEngine.RUIElements.RScale RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_scale
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_scale == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_scale = new(this, "UnityEngine.UIElements.IResolvedStyle.scale", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_scale.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_scale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextOverflow UnityEngine.UIElements.IResolvedStyle.textOverflow
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_textOverflow;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_textOverflow
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_textOverflow == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_textOverflow = new(this, "UnityEngine.UIElements.IResolvedStyle.textOverflow", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_textOverflow.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_textOverflow;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.top
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_top;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_top
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_top == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_top = new(this, "UnityEngine.UIElements.IResolvedStyle.top", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_top.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_top;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 UnityEngine.UIElements.IResolvedStyle.transformOrigin
		/// </summary>
		protected RUnityEngine.RVector3 r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transformOrigin;
		public virtual RUnityEngine.RVector3 RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transformOrigin
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transformOrigin == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transformOrigin = new(this, "UnityEngine.UIElements.IResolvedStyle.transformOrigin", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transformOrigin.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transformOrigin;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.TimeValue] UnityEngine.UIElements.IResolvedStyle.transitionDelay
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RTimeValue> r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionDelay;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RTimeValue> RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionDelay
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionDelay == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionDelay = new(this, "UnityEngine.UIElements.IResolvedStyle.transitionDelay", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionDelay.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionDelay;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.TimeValue] UnityEngine.UIElements.IResolvedStyle.transitionDuration
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RTimeValue> r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionDuration;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RTimeValue> RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionDuration
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionDuration == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionDuration = new(this, "UnityEngine.UIElements.IResolvedStyle.transitionDuration", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionDuration.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionDuration;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.StylePropertyName] UnityEngine.UIElements.IResolvedStyle.transitionProperty
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RStylePropertyName> r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionProperty;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.RStylePropertyName> RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionProperty
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionProperty == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionProperty = new(this, "UnityEngine.UIElements.IResolvedStyle.transitionProperty", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionProperty.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionProperty;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.EasingFunction] UnityEngine.UIElements.IResolvedStyle.transitionTimingFunction
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.REasingFunction> r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionTimingFunction;
		public virtual RSystem.RCollections.RGeneric.RIEnumerable<RUnityEngine.RUIElements.REasingFunction> RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionTimingFunction
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionTimingFunction == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionTimingFunction = new(this, "UnityEngine.UIElements.IResolvedStyle.transitionTimingFunction", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionTimingFunction.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_transitionTimingFunction;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 UnityEngine.UIElements.IResolvedStyle.translate
		/// </summary>
		protected RUnityEngine.RVector3 r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_translate;
		public virtual RUnityEngine.RVector3 RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_translate
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_translate == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_translate = new(this, "UnityEngine.UIElements.IResolvedStyle.translate", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_translate.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_translate;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.unityBackgroundImageTintColor
		/// </summary>
		protected RUnityEngine.RColor r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityBackgroundImageTintColor;
		public virtual RUnityEngine.RColor RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityBackgroundImageTintColor
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityBackgroundImageTintColor == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityBackgroundImageTintColor = new(this, "UnityEngine.UIElements.IResolvedStyle.unityBackgroundImageTintColor", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityBackgroundImageTintColor.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityBackgroundImageTintColor;
			}
		}

		/// <summary>
		/// UnityEngine.Font UnityEngine.UIElements.IResolvedStyle.unityFont
		/// </summary>
		protected RUnityEngine.RFont r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityFont;
		public virtual RUnityEngine.RFont RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityFont
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityFont == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityFont = new(this, "UnityEngine.UIElements.IResolvedStyle.unityFont", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityFont.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityFont;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FontDefinition UnityEngine.UIElements.IResolvedStyle.unityFontDefinition
		/// </summary>
		protected RUnityEngine.RUIElements.RFontDefinition r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityFontDefinition;
		public virtual RUnityEngine.RUIElements.RFontDefinition RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityFontDefinition
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityFontDefinition == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityFontDefinition = new(this, "UnityEngine.UIElements.IResolvedStyle.unityFontDefinition", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityFontDefinition.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityFontDefinition;
			}
		}

		/// <summary>
		/// UnityEngine.FontStyle UnityEngine.UIElements.IResolvedStyle.unityFontStyleAndWeight
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityFontStyleAndWeight;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityFontStyleAndWeight
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityFontStyleAndWeight == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityFontStyleAndWeight = new(this, "UnityEngine.UIElements.IResolvedStyle.unityFontStyleAndWeight", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityFontStyleAndWeight.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityFontStyleAndWeight;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.unityParagraphSpacing
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityParagraphSpacing;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityParagraphSpacing
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityParagraphSpacing == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityParagraphSpacing = new(this, "UnityEngine.UIElements.IResolvedStyle.unityParagraphSpacing", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityParagraphSpacing.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityParagraphSpacing;
			}
		}

		/// <summary>
		/// Int32 UnityEngine.UIElements.IResolvedStyle.unitySliceBottom
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceBottom;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceBottom
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceBottom == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceBottom = new(this, "UnityEngine.UIElements.IResolvedStyle.unitySliceBottom", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceBottom.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceBottom;
			}
		}

		/// <summary>
		/// Int32 UnityEngine.UIElements.IResolvedStyle.unitySliceLeft
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceLeft;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceLeft
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceLeft == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceLeft = new(this, "UnityEngine.UIElements.IResolvedStyle.unitySliceLeft", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceLeft.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceLeft;
			}
		}

		/// <summary>
		/// Int32 UnityEngine.UIElements.IResolvedStyle.unitySliceRight
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceRight;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceRight
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceRight == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceRight = new(this, "UnityEngine.UIElements.IResolvedStyle.unitySliceRight", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceRight.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceRight;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.unitySliceScale
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceScale;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceScale
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceScale == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceScale = new(this, "UnityEngine.UIElements.IResolvedStyle.unitySliceScale", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceScale.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceScale;
			}
		}

		/// <summary>
		/// Int32 UnityEngine.UIElements.IResolvedStyle.unitySliceTop
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceTop;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceTop
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceTop == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceTop = new(this, "UnityEngine.UIElements.IResolvedStyle.unitySliceTop", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceTop.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unitySliceTop;
			}
		}

		/// <summary>
		/// UnityEngine.TextAnchor UnityEngine.UIElements.IResolvedStyle.unityTextAlign
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextAlign;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextAlign
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextAlign == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextAlign = new(this, "UnityEngine.UIElements.IResolvedStyle.unityTextAlign", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextAlign.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextAlign;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.unityTextOutlineColor
		/// </summary>
		protected RUnityEngine.RColor r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextOutlineColor;
		public virtual RUnityEngine.RColor RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextOutlineColor
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextOutlineColor == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextOutlineColor = new(this, "UnityEngine.UIElements.IResolvedStyle.unityTextOutlineColor", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextOutlineColor.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextOutlineColor;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.unityTextOutlineWidth
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextOutlineWidth;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextOutlineWidth
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextOutlineWidth == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextOutlineWidth = new(this, "UnityEngine.UIElements.IResolvedStyle.unityTextOutlineWidth", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextOutlineWidth.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextOutlineWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextOverflowPosition UnityEngine.UIElements.IResolvedStyle.unityTextOverflowPosition
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextOverflowPosition;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextOverflowPosition
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextOverflowPosition == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextOverflowPosition = new(this, "UnityEngine.UIElements.IResolvedStyle.unityTextOverflowPosition", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextOverflowPosition.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityTextOverflowPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Visibility UnityEngine.UIElements.IResolvedStyle.visibility
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_visibility;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_visibility
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_visibility == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_visibility = new(this, "UnityEngine.UIElements.IResolvedStyle.visibility", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_visibility.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_visibility;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.WhiteSpace UnityEngine.UIElements.IResolvedStyle.whiteSpace
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_whiteSpace;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_whiteSpace
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_whiteSpace == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_whiteSpace = new(this, "UnityEngine.UIElements.IResolvedStyle.whiteSpace", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_whiteSpace.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_whiteSpace;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.width
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_width;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_width
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_width == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_width = new(this, "UnityEngine.UIElements.IResolvedStyle.width", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_width.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_width;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.wordSpacing
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_wordSpacing;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_wordSpacing
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_wordSpacing == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_wordSpacing = new(this, "UnityEngine.UIElements.IResolvedStyle.wordSpacing", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_wordSpacing.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_wordSpacing;
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
		/// Int32 UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__get_runningAnimationCount;
		public virtual RProperty RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__get_runningAnimationCount
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__get_runningAnimationCount == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__get_runningAnimationCount = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount", -1);
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__get_runningAnimationCount.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__get_runningAnimationCount;
			}
		}

		/// <summary>
		/// Int32 UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__get_completedAnimationCount;
		public virtual RProperty RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__get_completedAnimationCount
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__get_completedAnimationCount == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__get_completedAnimationCount = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount", -1);
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__get_completedAnimationCount.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__get_completedAnimationCount;
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
		/// UnityEngine.Vector3 UnityEngine.UIElements.ITransform.position
		/// </summary>
		protected RUnityEngine.RVector3 r_RUnityEngine__0__UIElements__0__ITransform__0__get_position;
		public virtual RUnityEngine.RVector3 RUnityEngine__0__UIElements__0__ITransform__0__get_position
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__ITransform__0__get_position == null)
				{
					r_RUnityEngine__0__UIElements__0__ITransform__0__get_position = new(this, "UnityEngine.UIElements.ITransform.position", -1);
					r_RUnityEngine__0__UIElements__0__ITransform__0__get_position.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__ITransform__0__get_position;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion UnityEngine.UIElements.ITransform.rotation
		/// </summary>
		protected RUnityEngine.RQuaternion r_RUnityEngine__0__UIElements__0__ITransform__0__get_rotation;
		public virtual RUnityEngine.RQuaternion RUnityEngine__0__UIElements__0__ITransform__0__get_rotation
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__ITransform__0__get_rotation == null)
				{
					r_RUnityEngine__0__UIElements__0__ITransform__0__get_rotation = new(this, "UnityEngine.UIElements.ITransform.rotation", -1);
					r_RUnityEngine__0__UIElements__0__ITransform__0__get_rotation.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__ITransform__0__get_rotation;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 UnityEngine.UIElements.ITransform.scale
		/// </summary>
		protected RUnityEngine.RVector3 r_RUnityEngine__0__UIElements__0__ITransform__0__get_scale;
		public virtual RUnityEngine.RVector3 RUnityEngine__0__UIElements__0__ITransform__0__get_scale
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__ITransform__0__get_scale == null)
				{
					r_RUnityEngine__0__UIElements__0__ITransform__0__get_scale = new(this, "UnityEngine.UIElements.ITransform.scale", -1);
					r_RUnityEngine__0__UIElements__0__ITransform__0__get_scale.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__ITransform__0__get_scale;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 UnityEngine.UIElements.ITransform.matrix
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_RUnityEngine__0__UIElements__0__ITransform__0__get_matrix;
		public virtual RUnityEngine.RMatrix4x4 RUnityEngine__0__UIElements__0__ITransform__0__get_matrix
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__ITransform__0__get_matrix == null)
				{
					r_RUnityEngine__0__UIElements__0__ITransform__0__get_matrix = new(this, "UnityEngine.UIElements.ITransform.matrix", -1);
					r_RUnityEngine__0__UIElements__0__ITransform__0__get_matrix.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__ITransform__0__get_matrix;
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
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.ScaleMode] UnityEngine.UIElements.IResolvedStyle.unityBackgroundScaleMode
		/// </summary>
		protected RProperty r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityBackgroundScaleMode;
		public virtual RProperty RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityBackgroundScaleMode
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityBackgroundScaleMode == null)
				{
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityBackgroundScaleMode = new(this, "UnityEngine.UIElements.IResolvedStyle.unityBackgroundScaleMode", -1);
					r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityBackgroundScaleMode.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IResolvedStyle__0__get_unityBackgroundScaleMode;
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
		/// UnityEngine.Rect boundingBoxInParentSpace
		/// </summary>
		protected RUnityEngine.RRect r_boundingBoxInParentSpace;
		public virtual RUnityEngine.RRect RboundingBoxInParentSpace
		{
			get
			{
				if(r_boundingBoxInParentSpace == null)
				{
					r_boundingBoxInParentSpace = new(this, "boundingBoxInParentSpace", -1);
					r_boundingBoxInParentSpace.SetBelong(this.instance);
				}
				return r_boundingBoxInParentSpace;
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
		/// Boolean isParentEnabledInHierarchy
		/// </summary>
		protected RProperty r_isParentEnabledInHierarchy;
		public virtual RProperty RisParentEnabledInHierarchy
		{
			get
			{
				if(r_isParentEnabledInHierarchy == null)
				{
					r_isParentEnabledInHierarchy = new(this, "isParentEnabledInHierarchy", -1);
					r_isParentEnabledInHierarchy.SetBelong(this.instance);
				}
				return r_isParentEnabledInHierarchy;
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
		/// UnityEngine.UIElements.Experimental.ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.animation
		/// </summary>
		protected RUnityEngine.RUIElements.RExperimental.RITransitionAnimations r_RUnityEngine__0__UIElements__0__IExperimentalFeatures__0__get_animation;
		public virtual RUnityEngine.RUIElements.RExperimental.RITransitionAnimations RUnityEngine__0__UIElements__0__IExperimentalFeatures__0__get_animation
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IExperimentalFeatures__0__get_animation == null)
				{
					r_RUnityEngine__0__UIElements__0__IExperimentalFeatures__0__get_animation = new(this, "UnityEngine.UIElements.IExperimentalFeatures.animation", -1);
					r_RUnityEngine__0__UIElements__0__IExperimentalFeatures__0__get_animation.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IExperimentalFeatures__0__get_animation;
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
		/// UnityEngine.Vector3 positionWithLayout
		/// </summary>
		protected RUnityEngine.RVector3 r_positionWithLayout;
		public virtual RUnityEngine.RVector3 RpositionWithLayout
		{
			get
			{
				if(r_positionWithLayout == null)
				{
					r_positionWithLayout = new(this, "positionWithLayout", -1);
					r_positionWithLayout.SetBelong(this.instance);
				}
				return r_positionWithLayout;
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
		/// TypeData typeData
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement.RTypeData r_typeData;
		public virtual RUnityEngine.RUIElements.RVisualElement.RTypeData RtypeData
		{
			get
			{
				if(r_typeData == null)
				{
					r_typeData = new(this, "typeData", -1);
					r_typeData.SetBelong(this.instance);
				}
				return r_typeData;
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
		/// UnityEngine.UIElements.IStylePropertyAnimationSystem GetStylePropertyAnimationSystem()
		/// </summary>
		protected RMethod r_RGetStylePropertyAnimationSystem;
		public virtual RMethod RGetStylePropertyAnimationSystem
		{
			get
			{
				if(r_RGetStylePropertyAnimationSystem == null)
				{
					r_RGetStylePropertyAnimationSystem = new(this, "GetStylePropertyAnimationSystem", 0);
					r_RGetStylePropertyAnimationSystem.SetBelong(this.instance);
				}
				return r_RGetStylePropertyAnimationSystem;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, Single, Single, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Single_Single_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Single_Single_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Single_Single_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Single_Single_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(System.Single), typeof(System.Single), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Single_Single_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Single_Single_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, Int32, Int32, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Length, UnityEngine.UIElements.Length, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Length_Length_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Length_Length_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Length_Length_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Length_Length_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Length), typeof(UnityEngine.UIElements.Length), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Length_Length_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Length_Length_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.Color, UnityEngine.Color, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Color_Color_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Color_Color_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Color_Color_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Color_Color_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.Color), typeof(UnityEngine.Color), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Color_Color_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Color_Color_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.StartEnum(UnityEngine.UIElements.StyleSheets.StylePropertyId, Int32, Int32, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__StartEnum_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__StartEnum_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__StartEnum_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__StartEnum_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.StartEnum", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__StartEnum_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__StartEnum_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Background, UnityEngine.UIElements.Background, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Background_Background_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Background_Background_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Background_Background_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Background_Background_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Background), typeof(UnityEngine.UIElements.Background), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Background_Background_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Background_Background_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.FontDefinition, UnityEngine.UIElements.FontDefinition, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.FontDefinition), typeof(UnityEngine.UIElements.FontDefinition), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.Font, UnityEngine.Font, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Font_Font_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Font_Font_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Font_Font_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Font_Font_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.Font), typeof(UnityEngine.Font), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Font_Font_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Font_Font_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.TextShadow, UnityEngine.UIElements.TextShadow, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.TextShadow), typeof(UnityEngine.UIElements.TextShadow), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Scale, UnityEngine.UIElements.Scale, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Scale_Scale_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Scale_Scale_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Scale_Scale_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Scale_Scale_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Scale), typeof(UnityEngine.UIElements.Scale), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Scale_Scale_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Scale_Scale_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Translate, UnityEngine.UIElements.Translate, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Translate_Translate_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Translate_Translate_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Translate_Translate_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Translate_Translate_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Translate), typeof(UnityEngine.UIElements.Translate), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Translate_Translate_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Translate_Translate_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.Rotate, UnityEngine.UIElements.Rotate, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Rotate), typeof(UnityEngine.UIElements.Rotate), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.TransformOrigin, UnityEngine.UIElements.TransformOrigin, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.TransformOrigin), typeof(UnityEngine.UIElements.TransformOrigin), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.BackgroundPosition, UnityEngine.UIElements.BackgroundPosition, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.BackgroundPosition), typeof(UnityEngine.UIElements.BackgroundPosition), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.BackgroundRepeat, UnityEngine.UIElements.BackgroundRepeat, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.BackgroundRepeat), typeof(UnityEngine.UIElements.BackgroundRepeat), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.Start(UnityEngine.UIElements.StyleSheets.StylePropertyId, UnityEngine.UIElements.BackgroundSize, UnityEngine.UIElements.BackgroundSize, Int32, Int32, System.Func`2[System.Single,System.Single])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_d_Single_Single_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_d_Single_Single_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_d_Single_Single_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.BackgroundSize), typeof(UnityEngine.UIElements.BackgroundSize), typeof(System.Int32), typeof(System.Int32), typeof(System.Func<, >).MakeGenericType(typeof(System.Single), typeof(System.Single)));
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_d_Single_Single_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__Start_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_d_Single_Single_p_;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__CancelAnimation_StylePropertyId;
		public virtual RMethod RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__CancelAnimation_StylePropertyId
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__CancelAnimation_StylePropertyId == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__CancelAnimation_StylePropertyId = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__CancelAnimation_StylePropertyId.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__CancelAnimation_StylePropertyId;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations()
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__CancelAllAnimations;
		public virtual RMethod RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__CancelAllAnimations
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__CancelAllAnimations == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__CancelAllAnimations = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations", 0);
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__CancelAllAnimations.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__CancelAllAnimations;
			}
		}

		/// <summary>
		/// Boolean UnityEngine.UIElements.IStylePropertyAnimations.HasRunningAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__HasRunningAnimation_StylePropertyId;
		public virtual RMethod RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__HasRunningAnimation_StylePropertyId
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__HasRunningAnimation_StylePropertyId == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__HasRunningAnimation_StylePropertyId = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.HasRunningAnimation", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__HasRunningAnimation_StylePropertyId.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__HasRunningAnimation_StylePropertyId;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation(UnityEngine.UIElements.StyleSheets.StylePropertyId)
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__UpdateAnimation_StylePropertyId;
		public virtual RMethod RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__UpdateAnimation_StylePropertyId
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__UpdateAnimation_StylePropertyId == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__UpdateAnimation_StylePropertyId = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"));
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__UpdateAnimation_StylePropertyId.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__UpdateAnimation_StylePropertyId;
			}
		}

		/// <summary>
		/// Void UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations(System.Collections.Generic.List`1[UnityEngine.UIElements.StyleSheets.StylePropertyId])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__GetAllAnimations_List_d_StylePropertyId_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__GetAllAnimations_List_d_StylePropertyId_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__GetAllAnimations_List_d_StylePropertyId_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__GetAllAnimations_List_d_StylePropertyId_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations", 0, typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId")));
					r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__GetAllAnimations_List_d_StylePropertyId_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__GetAllAnimations_List_d_StylePropertyId_p_;
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
		/// System.Nullable`1[System.Single] GetParentSizeForLengthConversion(UnityEngine.UIElements.StyleSheets.StylePropertyId, Int32)
		/// </summary>
		protected RMethod r_RGetParentSizeForLengthConversion_StylePropertyId_Int32;
		public virtual RMethod RGetParentSizeForLengthConversion_StylePropertyId_Int32
		{
			get
			{
				if(r_RGetParentSizeForLengthConversion_StylePropertyId_Int32 == null)
				{
					r_RGetParentSizeForLengthConversion_StylePropertyId_Int32 = new(this, "GetParentSizeForLengthConversion", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(System.Int32));
					r_RGetParentSizeForLengthConversion_StylePropertyId_Int32.SetBelong(this.instance);
				}
				return r_RGetParentSizeForLengthConversion_StylePropertyId_Int32;
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
		/// Void UpdateWorldClip()
		/// </summary>
		protected RMethod r_RUpdateWorldClip;
		public virtual RMethod RUpdateWorldClip
		{
			get
			{
				if(r_RUpdateWorldClip == null)
				{
					r_RUpdateWorldClip = new(this, "UpdateWorldClip", 0);
					r_RUpdateWorldClip.SetBelong(this.instance);
				}
				return r_RUpdateWorldClip;
			}
		}

		/// <summary>
		/// UnityEngine.Rect CombineClipRects(UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RCombineClipRects_Rect_Rect;
		public virtual RMethod RCombineClipRects_Rect_Rect
		{
			get
			{
				if(r_RCombineClipRects_Rect_Rect == null)
				{
					r_RCombineClipRects_Rect_Rect = new(this, "CombineClipRects", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
					r_RCombineClipRects_Rect_Rect.SetBelong(this.instance);
				}
				return r_RCombineClipRects_Rect_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect SubstractBorderPadding(UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RSubstractBorderPadding_Rect;
		public virtual RMethod RSubstractBorderPadding_Rect
		{
			get
			{
				if(r_RSubstractBorderPadding_Rect == null)
				{
					r_RSubstractBorderPadding_Rect = new(this, "SubstractBorderPadding", 0, typeof(UnityEngine.Rect));
					r_RSubstractBorderPadding_Rect.SetBelong(this.instance);
				}
				return r_RSubstractBorderPadding_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect ComputeAAAlignedBound(UnityEngine.Rect, UnityEngine.Matrix4x4)
		/// </summary>
		protected static RMethod r_RComputeAAAlignedBound_Rect_Matrix4x4;
		public static RMethod RComputeAAAlignedBound_Rect_Matrix4x4
		{
			get
			{
				if(r_RComputeAAAlignedBound_Rect_Matrix4x4 == null)
				{
					r_RComputeAAAlignedBound_Rect_Matrix4x4 = new(typeof(UnityEngine.UIElements.VisualElement), "ComputeAAAlignedBound", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Matrix4x4));
					r_RComputeAAAlignedBound_Rect_Matrix4x4.SetBelong(null);
				}
				return r_RComputeAAAlignedBound_Rect_Matrix4x4;
			}
		}

		/// <summary>
		/// Void UpdateHoverPseudoState()
		/// </summary>
		protected RMethod r_RUpdateHoverPseudoState;
		public virtual RMethod RUpdateHoverPseudoState
		{
			get
			{
				if(r_RUpdateHoverPseudoState == null)
				{
					r_RUpdateHoverPseudoState = new(this, "UpdateHoverPseudoState", 0);
					r_RUpdateHoverPseudoState.SetBelong(this.instance);
				}
				return r_RUpdateHoverPseudoState;
			}
		}

		/// <summary>
		/// Boolean IsPartOfCapturedChain(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.IEventHandler ByRef)
		/// </summary>
		protected static RMethod r_RIsPartOfCapturedChain_VisualElement_In_IEventHandler;
		public static RMethod RIsPartOfCapturedChain_VisualElement_In_IEventHandler
		{
			get
			{
				if(r_RIsPartOfCapturedChain_VisualElement_In_IEventHandler == null)
				{
					r_RIsPartOfCapturedChain_VisualElement_In_IEventHandler = new(typeof(UnityEngine.UIElements.VisualElement), "IsPartOfCapturedChain", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.IEventHandler).MakeByRefType());
					r_RIsPartOfCapturedChain_VisualElement_In_IEventHandler.SetBelong(null);
				}
				return r_RIsPartOfCapturedChain_VisualElement_In_IEventHandler;
			}
		}

		/// <summary>
		/// Void ChangeIMGUIContainerCount(Int32)
		/// </summary>
		protected RMethod r_RChangeIMGUIContainerCount_Int32;
		public virtual RMethod RChangeIMGUIContainerCount_Int32
		{
			get
			{
				if(r_RChangeIMGUIContainerCount_Int32 == null)
				{
					r_RChangeIMGUIContainerCount_Int32 = new(this, "ChangeIMGUIContainerCount", 0, typeof(System.Int32));
					r_RChangeIMGUIContainerCount_Int32.SetBelong(this.instance);
				}
				return r_RChangeIMGUIContainerCount_Int32;
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
		/// Void SetTooltip(UnityEngine.UIElements.TooltipEvent)
		/// </summary>
		protected RMethod r_RSetTooltip_TooltipEvent;
		public virtual RMethod RSetTooltip_TooltipEvent
		{
			get
			{
				if(r_RSetTooltip_TooltipEvent == null)
				{
					r_RSetTooltip_TooltipEvent = new(this, "SetTooltip", 0, typeof(UnityEngine.UIElements.TooltipEvent));
					r_RSetTooltip_TooltipEvent.SetBelong(this.instance);
				}
				return r_RSetTooltip_TooltipEvent;
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
		/// Void WillChangePanel(UnityEngine.UIElements.BaseVisualElementPanel)
		/// </summary>
		protected RMethod r_RWillChangePanel_BaseVisualElementPanel;
		public virtual RMethod RWillChangePanel_BaseVisualElementPanel
		{
			get
			{
				if(r_RWillChangePanel_BaseVisualElementPanel == null)
				{
					r_RWillChangePanel_BaseVisualElementPanel = new(this, "WillChangePanel", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.BaseVisualElementPanel"));
					r_RWillChangePanel_BaseVisualElementPanel.SetBelong(this.instance);
				}
				return r_RWillChangePanel_BaseVisualElementPanel;
			}
		}

		/// <summary>
		/// Void HasChangedPanel(UnityEngine.UIElements.BaseVisualElementPanel)
		/// </summary>
		protected RMethod r_RHasChangedPanel_BaseVisualElementPanel;
		public virtual RMethod RHasChangedPanel_BaseVisualElementPanel
		{
			get
			{
				if(r_RHasChangedPanel_BaseVisualElementPanel == null)
				{
					r_RHasChangedPanel_BaseVisualElementPanel = new(this, "HasChangedPanel", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.BaseVisualElementPanel"));
					r_RHasChangedPanel_BaseVisualElementPanel.SetBelong(this.instance);
				}
				return r_RHasChangedPanel_BaseVisualElementPanel;
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
		/// Boolean SetEnabledFromHierarchyPrivate(Boolean)
		/// </summary>
		protected RMethod r_RSetEnabledFromHierarchyPrivate_Boolean;
		public virtual RMethod RSetEnabledFromHierarchyPrivate_Boolean
		{
			get
			{
				if(r_RSetEnabledFromHierarchyPrivate_Boolean == null)
				{
					r_RSetEnabledFromHierarchyPrivate_Boolean = new(this, "SetEnabledFromHierarchyPrivate", 0, typeof(System.Boolean));
					r_RSetEnabledFromHierarchyPrivate_Boolean.SetBelong(this.instance);
				}
				return r_RSetEnabledFromHierarchyPrivate_Boolean;
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
		/// Void PropagateEnabledToChildren(Boolean)
		/// </summary>
		protected RMethod r_RPropagateEnabledToChildren_Boolean;
		public virtual RMethod RPropagateEnabledToChildren_Boolean
		{
			get
			{
				if(r_RPropagateEnabledToChildren_Boolean == null)
				{
					r_RPropagateEnabledToChildren_Boolean = new(this, "PropagateEnabledToChildren", 0, typeof(System.Boolean));
					r_RPropagateEnabledToChildren_Boolean.SetBelong(this.instance);
				}
				return r_RPropagateEnabledToChildren_Boolean;
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
		/// Void AssignMeasureFunction()
		/// </summary>
		protected RMethod r_RAssignMeasureFunction;
		public virtual RMethod RAssignMeasureFunction
		{
			get
			{
				if(r_RAssignMeasureFunction == null)
				{
					r_RAssignMeasureFunction = new(this, "AssignMeasureFunction", 0);
					r_RAssignMeasureFunction.SetBelong(this.instance);
				}
				return r_RAssignMeasureFunction;
			}
		}

		/// <summary>
		/// Void RemoveMeasureFunction()
		/// </summary>
		protected RMethod r_RRemoveMeasureFunction;
		public virtual RMethod RRemoveMeasureFunction
		{
			get
			{
				if(r_RRemoveMeasureFunction == null)
				{
					r_RRemoveMeasureFunction = new(this, "RemoveMeasureFunction", 0);
					r_RRemoveMeasureFunction.SetBelong(this.instance);
				}
				return r_RRemoveMeasureFunction;
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
		/// Void FinalizeLayout()
		/// </summary>
		protected RMethod r_RFinalizeLayout;
		public virtual RMethod RFinalizeLayout
		{
			get
			{
				if(r_RFinalizeLayout == null)
				{
					r_RFinalizeLayout = new(this, "FinalizeLayout", 0);
					r_RFinalizeLayout.SetBelong(this.instance);
				}
				return r_RFinalizeLayout;
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
		/// Boolean TryGetPropertyInternal(UnityEngine.PropertyName, System.Object ByRef)
		/// </summary>
		protected RMethod r_RTryGetPropertyInternal_PropertyName_Out_Object;
		public virtual RMethod RTryGetPropertyInternal_PropertyName_Out_Object
		{
			get
			{
				if(r_RTryGetPropertyInternal_PropertyName_Out_Object == null)
				{
					r_RTryGetPropertyInternal_PropertyName_Out_Object = new(this, "TryGetPropertyInternal", 0, typeof(UnityEngine.PropertyName), typeof(System.Object).MakeByRefType());
					r_RTryGetPropertyInternal_PropertyName_Out_Object.SetBelong(this.instance);
				}
				return r_RTryGetPropertyInternal_PropertyName_Out_Object;
			}
		}

		/// <summary>
		/// Void CheckUserKeyArgument(UnityEngine.PropertyName)
		/// </summary>
		protected static RMethod r_RCheckUserKeyArgument_PropertyName;
		public static RMethod RCheckUserKeyArgument_PropertyName
		{
			get
			{
				if(r_RCheckUserKeyArgument_PropertyName == null)
				{
					r_RCheckUserKeyArgument_PropertyName = new(typeof(UnityEngine.UIElements.VisualElement), "CheckUserKeyArgument", 0, typeof(UnityEngine.PropertyName));
					r_RCheckUserKeyArgument_PropertyName.SetBelong(null);
				}
				return r_RCheckUserKeyArgument_PropertyName;
			}
		}

		/// <summary>
		/// Void SetPropertyInternal(UnityEngine.PropertyName, System.Object)
		/// </summary>
		protected RMethod r_RSetPropertyInternal_PropertyName_Object;
		public virtual RMethod RSetPropertyInternal_PropertyName_Object
		{
			get
			{
				if(r_RSetPropertyInternal_PropertyName_Object == null)
				{
					r_RSetPropertyInternal_PropertyName_Object = new(this, "SetPropertyInternal", 0, typeof(UnityEngine.PropertyName), typeof(System.Object));
					r_RSetPropertyInternal_PropertyName_Object.SetBelong(this.instance);
				}
				return r_RSetPropertyInternal_PropertyName_Object;
			}
		}

		/// <summary>
		/// Void UpdateCursorStyle(Int64)
		/// </summary>
		protected RMethod r_RUpdateCursorStyle_Int64;
		public virtual RMethod RUpdateCursorStyle_Int64
		{
			get
			{
				if(r_RUpdateCursorStyle_Int64 == null)
				{
					r_RUpdateCursorStyle_Int64 = new(this, "UpdateCursorStyle", 0, typeof(System.Int64));
					r_RUpdateCursorStyle_Int64.SetBelong(this.instance);
				}
				return r_RUpdateCursorStyle_Int64;
			}
		}

		/// <summary>
		/// UnityEngine.Material getRuntimeMaterial()
		/// </summary>
		protected RMethod r_RgetRuntimeMaterial;
		public virtual RMethod RgetRuntimeMaterial
		{
			get
			{
				if(r_RgetRuntimeMaterial == null)
				{
					r_RgetRuntimeMaterial = new(this, "getRuntimeMaterial", 0);
					r_RgetRuntimeMaterial.SetBelong(this.instance);
				}
				return r_RgetRuntimeMaterial;
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
		/// UnityEngine.UIElements.VisualElementAnimationSystem GetAnimationSystem()
		/// </summary>
		protected RMethod r_RGetAnimationSystem;
		public virtual RMethod RGetAnimationSystem
		{
			get
			{
				if(r_RGetAnimationSystem == null)
				{
					r_RGetAnimationSystem = new(this, "GetAnimationSystem", 0);
					r_RGetAnimationSystem.SetBelong(this.instance);
				}
				return r_RGetAnimationSystem;
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
		/// Void UnregisterRunningAnimations()
		/// </summary>
		protected RMethod r_RUnregisterRunningAnimations;
		public virtual RMethod RUnregisterRunningAnimations
		{
			get
			{
				if(r_RUnregisterRunningAnimations == null)
				{
					r_RUnregisterRunningAnimations = new(this, "UnregisterRunningAnimations", 0);
					r_RUnregisterRunningAnimations.SetBelong(this.instance);
				}
				return r_RUnregisterRunningAnimations;
			}
		}

		/// <summary>
		/// Void RegisterRunningAnimations()
		/// </summary>
		protected RMethod r_RRegisterRunningAnimations;
		public virtual RMethod RRegisterRunningAnimations
		{
			get
			{
				if(r_RRegisterRunningAnimations == null)
				{
					r_RRegisterRunningAnimations = new(this, "RegisterRunningAnimations", 0);
					r_RRegisterRunningAnimations.SetBelong(this.instance);
				}
				return r_RRegisterRunningAnimations;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[System.Single] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(Single, Single, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,System.Single])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Single_Single_Int32_Action_d_VisualElement_Single_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Single_Single_Int32_Action_d_VisualElement_Single_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Single_Single_Int32_Action_d_VisualElement_Single_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Single_Single_Int32_Action_d_VisualElement_Single_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(System.Single), typeof(System.Single), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(System.Single)));
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Single_Single_Int32_Action_d_VisualElement_Single_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Single_Single_Int32_Action_d_VisualElement_Single_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Rect] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(UnityEngine.Rect, UnityEngine.Rect, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Rect])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Rect_Rect_Int32_Action_d_VisualElement_Rect_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Rect_Rect_Int32_Action_d_VisualElement_Rect_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Rect_Rect_Int32_Action_d_VisualElement_Rect_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Rect_Rect_Int32_Action_d_VisualElement_Rect_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Rect)));
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Rect_Rect_Int32_Action_d_VisualElement_Rect_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Rect_Rect_Int32_Action_d_VisualElement_Rect_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Color] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(UnityEngine.Color, UnityEngine.Color, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Color])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Color_Color_Int32_Action_d_VisualElement_Color_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Color_Color_Int32_Action_d_VisualElement_Color_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Color_Color_Int32_Action_d_VisualElement_Color_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Color_Color_Int32_Action_d_VisualElement_Color_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(UnityEngine.Color), typeof(UnityEngine.Color), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Color)));
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Color_Color_Int32_Action_d_VisualElement_Color_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Color_Color_Int32_Action_d_VisualElement_Color_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Vector3] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(UnityEngine.Vector3, UnityEngine.Vector3, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Vector3_Vector3_Int32_Action_d_VisualElement_Vector3_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Vector3_Vector3_Int32_Action_d_VisualElement_Vector3_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Vector3_Vector3_Int32_Action_d_VisualElement_Vector3_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Vector3_Vector3_Int32_Action_d_VisualElement_Vector3_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector3)));
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Vector3_Vector3_Int32_Action_d_VisualElement_Vector3_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Vector3_Vector3_Int32_Action_d_VisualElement_Vector3_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Vector2] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(UnityEngine.Vector2, UnityEngine.Vector2, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Vector2])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Vector2_Vector2_Int32_Action_d_VisualElement_Vector2_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Vector2_Vector2_Int32_Action_d_VisualElement_Vector2_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Vector2_Vector2_Int32_Action_d_VisualElement_Vector2_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Vector2_Vector2_Int32_Action_d_VisualElement_Vector2_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector2)));
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Vector2_Vector2_Int32_Action_d_VisualElement_Vector2_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Vector2_Vector2_Int32_Action_d_VisualElement_Vector2_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Quaternion] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(UnityEngine.Quaternion, UnityEngine.Quaternion, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Quaternion])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Quaternion_Quaternion_Int32_Action_d_VisualElement_Quaternion_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Quaternion_Quaternion_Int32_Action_d_VisualElement_Quaternion_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Quaternion_Quaternion_Int32_Action_d_VisualElement_Quaternion_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Quaternion_Quaternion_Int32_Action_d_VisualElement_Quaternion_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Quaternion)));
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Quaternion_Quaternion_Int32_Action_d_VisualElement_Quaternion_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Quaternion_Quaternion_Int32_Action_d_VisualElement_Quaternion_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.UIElements.Experimental.StyleValues] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(UnityEngine.UIElements.Experimental.StyleValues, UnityEngine.UIElements.Experimental.StyleValues, Int32)
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_StyleValues_StyleValues_Int32;
		public virtual RMethod RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_StyleValues_StyleValues_Int32
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_StyleValues_StyleValues_Int32 == null)
				{
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_StyleValues_StyleValues_Int32 = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(UnityEngine.UIElements.Experimental.StyleValues), typeof(UnityEngine.UIElements.Experimental.StyleValues), typeof(System.Int32));
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_StyleValues_StyleValues_Int32.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_StyleValues_StyleValues_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[System.Single] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(System.Func`2[UnityEngine.UIElements.VisualElement,System.Single], Single, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,System.Single])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Single_p__Single_Int32_Action_d_VisualElement_Single_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Single_p__Single_Int32_Action_d_VisualElement_Single_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Single_p__Single_Int32_Action_d_VisualElement_Single_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Single_p__Single_Int32_Action_d_VisualElement_Single_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(System.Single)), typeof(System.Single), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(System.Single)));
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Single_p__Single_Int32_Action_d_VisualElement_Single_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Single_p__Single_Int32_Action_d_VisualElement_Single_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Rect] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(System.Func`2[UnityEngine.UIElements.VisualElement,UnityEngine.Rect], UnityEngine.Rect, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Rect])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Rect_p__Rect_Int32_Action_d_VisualElement_Rect_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Rect_p__Rect_Int32_Action_d_VisualElement_Rect_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Rect_p__Rect_Int32_Action_d_VisualElement_Rect_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Rect_p__Rect_Int32_Action_d_VisualElement_Rect_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Rect)), typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Rect)));
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Rect_p__Rect_Int32_Action_d_VisualElement_Rect_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Rect_p__Rect_Int32_Action_d_VisualElement_Rect_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Color] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(System.Func`2[UnityEngine.UIElements.VisualElement,UnityEngine.Color], UnityEngine.Color, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Color])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Color_p__Color_Int32_Action_d_VisualElement_Color_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Color_p__Color_Int32_Action_d_VisualElement_Color_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Color_p__Color_Int32_Action_d_VisualElement_Color_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Color_p__Color_Int32_Action_d_VisualElement_Color_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Color)), typeof(UnityEngine.Color), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Color)));
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Color_p__Color_Int32_Action_d_VisualElement_Color_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Color_p__Color_Int32_Action_d_VisualElement_Color_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Vector3] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(System.Func`2[UnityEngine.UIElements.VisualElement,UnityEngine.Vector3], UnityEngine.Vector3, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Vector3])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Vector3_p__Vector3_Int32_Action_d_VisualElement_Vector3_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Vector3_p__Vector3_Int32_Action_d_VisualElement_Vector3_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Vector3_p__Vector3_Int32_Action_d_VisualElement_Vector3_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Vector3_p__Vector3_Int32_Action_d_VisualElement_Vector3_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector3)), typeof(UnityEngine.Vector3), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector3)));
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Vector3_p__Vector3_Int32_Action_d_VisualElement_Vector3_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Vector3_p__Vector3_Int32_Action_d_VisualElement_Vector3_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Vector2] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(System.Func`2[UnityEngine.UIElements.VisualElement,UnityEngine.Vector2], UnityEngine.Vector2, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Vector2])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Vector2_p__Vector2_Int32_Action_d_VisualElement_Vector2_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Vector2_p__Vector2_Int32_Action_d_VisualElement_Vector2_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Vector2_p__Vector2_Int32_Action_d_VisualElement_Vector2_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Vector2_p__Vector2_Int32_Action_d_VisualElement_Vector2_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector2)), typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector2)));
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Vector2_p__Vector2_Int32_Action_d_VisualElement_Vector2_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Vector2_p__Vector2_Int32_Action_d_VisualElement_Vector2_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Quaternion] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(System.Func`2[UnityEngine.UIElements.VisualElement,UnityEngine.Quaternion], UnityEngine.Quaternion, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,UnityEngine.Quaternion])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Quaternion_p__Quaternion_Int32_Action_d_VisualElement_Quaternion_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Quaternion_p__Quaternion_Int32_Action_d_VisualElement_Quaternion_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Quaternion_p__Quaternion_Int32_Action_d_VisualElement_Quaternion_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Quaternion_p__Quaternion_Int32_Action_d_VisualElement_Quaternion_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Quaternion)), typeof(UnityEngine.Quaternion), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Quaternion)));
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Quaternion_p__Quaternion_Int32_Action_d_VisualElement_Quaternion_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Quaternion_p__Quaternion_Int32_Action_d_VisualElement_Quaternion_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[T] StartAnimation[T](UnityEngine.UIElements.Experimental.ValueAnimation`1[T], System.Func`2[UnityEngine.UIElements.VisualElement,T], T, Int32, System.Action`2[UnityEngine.UIElements.VisualElement,T])
		/// </summary>
		protected static RMethod r_RStartAnimation_GT_ValueAnimation_d_T_p__Func_d_VisualElement_T_p__T_Int32_Action_d_VisualElement_T_p_;
		public static RMethod RStartAnimation_GT_ValueAnimation_d_T_p__Func_d_VisualElement_T_p__T_Int32_Action_d_VisualElement_T_p_
		{
			get
			{
				if(r_RStartAnimation_GT_ValueAnimation_d_T_p__Func_d_VisualElement_T_p__T_Int32_Action_d_VisualElement_T_p_ == null)
				{
					r_RStartAnimation_GT_ValueAnimation_d_T_p__Func_d_VisualElement_T_p__T_Int32_Action_d_VisualElement_T_p_ = new(typeof(UnityEngine.UIElements.VisualElement), "StartAnimation", 1, typeof(UnityEngine.UIElements.Experimental.ValueAnimation<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0), typeof(System.Int32), typeof(System.Action<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), Type.MakeGenericMethodParameter(0)));
					r_RStartAnimation_GT_ValueAnimation_d_T_p__Func_d_VisualElement_T_p__T_Int32_Action_d_VisualElement_T_p_.SetBelong(null);
				}
				return r_RStartAnimation_GT_ValueAnimation_d_T_p__Func_d_VisualElement_T_p__T_Int32_Action_d_VisualElement_T_p_;
			}
		}

		/// <summary>
		/// Void AssignStyleValues(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.Experimental.StyleValues)
		/// </summary>
		protected static RMethod r_RAssignStyleValues_VisualElement_StyleValues;
		public static RMethod RAssignStyleValues_VisualElement_StyleValues
		{
			get
			{
				if(r_RAssignStyleValues_VisualElement_StyleValues == null)
				{
					r_RAssignStyleValues_VisualElement_StyleValues = new(typeof(UnityEngine.UIElements.VisualElement), "AssignStyleValues", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.Experimental.StyleValues));
					r_RAssignStyleValues_VisualElement_StyleValues.SetBelong(null);
				}
				return r_RAssignStyleValues_VisualElement_StyleValues;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.StyleValues ReadCurrentValues(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.Experimental.StyleValues)
		/// </summary>
		protected RMethod r_RReadCurrentValues_VisualElement_StyleValues;
		public virtual RMethod RReadCurrentValues_VisualElement_StyleValues
		{
			get
			{
				if(r_RReadCurrentValues_VisualElement_StyleValues == null)
				{
					r_RReadCurrentValues_VisualElement_StyleValues = new(this, "ReadCurrentValues", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.Experimental.StyleValues));
					r_RReadCurrentValues_VisualElement_StyleValues.SetBelong(this.instance);
				}
				return r_RReadCurrentValues_VisualElement_StyleValues;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.UIElements.Experimental.StyleValues] UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(UnityEngine.UIElements.Experimental.StyleValues, Int32)
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_StyleValues_Int32;
		public virtual RMethod RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_StyleValues_Int32
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_StyleValues_Int32 == null)
				{
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_StyleValues_Int32 = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(UnityEngine.UIElements.Experimental.StyleValues), typeof(System.Int32));
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_StyleValues_Int32.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_StyleValues_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.UIElements.Experimental.StyleValues] Start(System.Func`2[UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.Experimental.StyleValues], UnityEngine.UIElements.Experimental.StyleValues, Int32)
		/// </summary>
		protected RMethod r_RStart_Func_d_VisualElement_StyleValues_p__StyleValues_Int32;
		public virtual RMethod RStart_Func_d_VisualElement_StyleValues_p__StyleValues_Int32
		{
			get
			{
				if(r_RStart_Func_d_VisualElement_StyleValues_p__StyleValues_Int32 == null)
				{
					r_RStart_Func_d_VisualElement_StyleValues_p__StyleValues_Int32 = new(this, "Start", 0, typeof(System.Func<, >).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.Experimental.StyleValues)), typeof(UnityEngine.UIElements.Experimental.StyleValues), typeof(System.Int32));
					r_RStart_Func_d_VisualElement_StyleValues_p__StyleValues_Int32.SetBelong(this.instance);
				}
				return r_RStart_Func_d_VisualElement_StyleValues_p__StyleValues_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Rect] UnityEngine.UIElements.Experimental.ITransitionAnimations.Layout(UnityEngine.Rect, Int32)
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Layout_Rect_Int32;
		public virtual RMethod RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Layout_Rect_Int32
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Layout_Rect_Int32 == null)
				{
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Layout_Rect_Int32 = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Layout", 0, typeof(UnityEngine.Rect), typeof(System.Int32));
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Layout_Rect_Int32.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Layout_Rect_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Vector2] UnityEngine.UIElements.Experimental.ITransitionAnimations.TopLeft(UnityEngine.Vector2, Int32)
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__TopLeft_Vector2_Int32;
		public virtual RMethod RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__TopLeft_Vector2_Int32
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__TopLeft_Vector2_Int32 == null)
				{
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__TopLeft_Vector2_Int32 = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.TopLeft", 0, typeof(UnityEngine.Vector2), typeof(System.Int32));
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__TopLeft_Vector2_Int32.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__TopLeft_Vector2_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Vector2] UnityEngine.UIElements.Experimental.ITransitionAnimations.Size(UnityEngine.Vector2, Int32)
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Size_Vector2_Int32;
		public virtual RMethod RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Size_Vector2_Int32
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Size_Vector2_Int32 == null)
				{
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Size_Vector2_Int32 = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Size", 0, typeof(UnityEngine.Vector2), typeof(System.Int32));
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Size_Vector2_Int32.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Size_Vector2_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[System.Single] UnityEngine.UIElements.Experimental.ITransitionAnimations.Scale(Single, Int32)
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Scale_Single_Int32;
		public virtual RMethod RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Scale_Single_Int32
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Scale_Single_Int32 == null)
				{
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Scale_Single_Int32 = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Scale", 0, typeof(System.Single), typeof(System.Int32));
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Scale_Single_Int32.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Scale_Single_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Vector3] UnityEngine.UIElements.Experimental.ITransitionAnimations.Position(UnityEngine.Vector3, Int32)
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Position_Vector3_Int32;
		public virtual RMethod RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Position_Vector3_Int32
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Position_Vector3_Int32 == null)
				{
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Position_Vector3_Int32 = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Position", 0, typeof(UnityEngine.Vector3), typeof(System.Int32));
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Position_Vector3_Int32.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Position_Vector3_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Experimental.ValueAnimation`1[UnityEngine.Quaternion] UnityEngine.UIElements.Experimental.ITransitionAnimations.Rotation(UnityEngine.Quaternion, Int32)
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Rotation_Quaternion_Int32;
		public virtual RMethod RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Rotation_Quaternion_Int32
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Rotation_Quaternion_Int32 == null)
				{
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Rotation_Quaternion_Int32 = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Rotation", 0, typeof(UnityEngine.Quaternion), typeof(System.Int32));
					r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Rotation_Quaternion_Int32.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Rotation_Quaternion_Int32;
			}
		}

		/// <summary>
		/// Void DirtyNextParentWithEventCallback()
		/// </summary>
		protected RMethod r_RDirtyNextParentWithEventCallback;
		public virtual RMethod RDirtyNextParentWithEventCallback
		{
			get
			{
				if(r_RDirtyNextParentWithEventCallback == null)
				{
					r_RDirtyNextParentWithEventCallback = new(this, "DirtyNextParentWithEventCallback", 0);
					r_RDirtyNextParentWithEventCallback.SetBelong(this.instance);
				}
				return r_RDirtyNextParentWithEventCallback;
			}
		}

		/// <summary>
		/// Void SetAsNextParentWithEventCallback()
		/// </summary>
		protected RMethod r_RSetAsNextParentWithEventCallback;
		public virtual RMethod RSetAsNextParentWithEventCallback
		{
			get
			{
				if(r_RSetAsNextParentWithEventCallback == null)
				{
					r_RSetAsNextParentWithEventCallback = new(this, "SetAsNextParentWithEventCallback", 0);
					r_RSetAsNextParentWithEventCallback.SetBelong(this.instance);
				}
				return r_RSetAsNextParentWithEventCallback;
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
		/// Void UpdateCallbackParentCategories()
		/// </summary>
		protected RMethod r_RUpdateCallbackParentCategories;
		public virtual RMethod RUpdateCallbackParentCategories
		{
			get
			{
				if(r_RUpdateCallbackParentCategories == null)
				{
					r_RUpdateCallbackParentCategories = new(this, "UpdateCallbackParentCategories", 0);
					r_RUpdateCallbackParentCategories.SetBelong(this.instance);
				}
				return r_RUpdateCallbackParentCategories;
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
		/// Void GatherAllChildren(System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_RGatherAllChildren_List_d_VisualElement_p_;
		public virtual RMethod RGatherAllChildren_List_d_VisualElement_p_
		{
			get
			{
				if(r_RGatherAllChildren_List_d_VisualElement_p_ == null)
				{
					r_RGatherAllChildren_List_d_VisualElement_p_ = new(this, "GatherAllChildren", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
					r_RGatherAllChildren_List_d_VisualElement_p_.SetBelong(this.instance);
				}
				return r_RGatherAllChildren_List_d_VisualElement_p_;
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
		/// Single Min(Single, Single, Single, Single)
		/// </summary>
		protected static RMethod r_RMin_Single_Single_Single_Single;
		public static RMethod RMin_Single_Single_Single_Single
		{
			get
			{
				if(r_RMin_Single_Single_Single_Single == null)
				{
					r_RMin_Single_Single_Single_Single = new(typeof(UnityEngine.UIElements.VisualElement), "Min", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RMin_Single_Single_Single_Single.SetBelong(null);
				}
				return r_RMin_Single_Single_Single_Single;
			}
		}

		/// <summary>
		/// Single Max(Single, Single, Single, Single)
		/// </summary>
		protected static RMethod r_RMax_Single_Single_Single_Single;
		public static RMethod RMax_Single_Single_Single_Single
		{
			get
			{
				if(r_RMax_Single_Single_Single_Single == null)
				{
					r_RMax_Single_Single_Single_Single = new(typeof(UnityEngine.UIElements.VisualElement), "Max", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RMax_Single_Single_Single_Single.SetBelong(null);
				}
				return r_RMax_Single_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void TransformAlignedRectToParentSpace(UnityEngine.Rect ByRef)
		/// </summary>
		protected RMethod r_RTransformAlignedRectToParentSpace_Ref_Rect;
		public virtual RMethod RTransformAlignedRectToParentSpace_Ref_Rect
		{
			get
			{
				if(r_RTransformAlignedRectToParentSpace_Ref_Rect == null)
				{
					r_RTransformAlignedRectToParentSpace_Ref_Rect = new(this, "TransformAlignedRectToParentSpace", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_RTransformAlignedRectToParentSpace_Ref_Rect.SetBelong(this.instance);
				}
				return r_RTransformAlignedRectToParentSpace_Ref_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect CalculateConservativeRect(UnityEngine.Matrix4x4 ByRef, UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_RCalculateConservativeRect_Ref_Matrix4x4_Rect;
		public static RMethod RCalculateConservativeRect_Ref_Matrix4x4_Rect
		{
			get
			{
				if(r_RCalculateConservativeRect_Ref_Matrix4x4_Rect == null)
				{
					r_RCalculateConservativeRect_Ref_Matrix4x4_Rect = new(typeof(UnityEngine.UIElements.VisualElement), "CalculateConservativeRect", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Rect));
					r_RCalculateConservativeRect_Ref_Matrix4x4_Rect.SetBelong(null);
				}
				return r_RCalculateConservativeRect_Ref_Matrix4x4_Rect;
			}
		}

		/// <summary>
		/// Void TransformAlignedRect(UnityEngine.Matrix4x4 ByRef, UnityEngine.Rect ByRef)
		/// </summary>
		protected static RMethod r_RTransformAlignedRect_Ref_Matrix4x4_Ref_Rect;
		public static RMethod RTransformAlignedRect_Ref_Matrix4x4_Ref_Rect
		{
			get
			{
				if(r_RTransformAlignedRect_Ref_Matrix4x4_Ref_Rect == null)
				{
					r_RTransformAlignedRect_Ref_Matrix4x4_Ref_Rect = new(typeof(UnityEngine.UIElements.VisualElement), "TransformAlignedRect", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Rect).MakeByRefType());
					r_RTransformAlignedRect_Ref_Matrix4x4_Ref_Rect.SetBelong(null);
				}
				return r_RTransformAlignedRect_Ref_Matrix4x4_Ref_Rect;
			}
		}

		/// <summary>
		/// Void OrderMinMaxRect(UnityEngine.Rect ByRef)
		/// </summary>
		protected static RMethod r_ROrderMinMaxRect_Ref_Rect;
		public static RMethod ROrderMinMaxRect_Ref_Rect
		{
			get
			{
				if(r_ROrderMinMaxRect_Ref_Rect == null)
				{
					r_ROrderMinMaxRect_Ref_Rect = new(typeof(UnityEngine.UIElements.VisualElement), "OrderMinMaxRect", 0, typeof(UnityEngine.Rect).MakeByRefType());
					r_ROrderMinMaxRect_Ref_Rect.SetBelong(null);
				}
				return r_ROrderMinMaxRect_Ref_Rect;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 MultiplyMatrix44Point2(UnityEngine.Matrix4x4 ByRef, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_RMultiplyMatrix44Point2_Ref_Matrix4x4_Vector2;
		public static RMethod RMultiplyMatrix44Point2_Ref_Matrix4x4_Vector2
		{
			get
			{
				if(r_RMultiplyMatrix44Point2_Ref_Matrix4x4_Vector2 == null)
				{
					r_RMultiplyMatrix44Point2_Ref_Matrix4x4_Vector2 = new(typeof(UnityEngine.UIElements.VisualElement), "MultiplyMatrix44Point2", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Vector2));
					r_RMultiplyMatrix44Point2_Ref_Matrix4x4_Vector2.SetBelong(null);
				}
				return r_RMultiplyMatrix44Point2_Ref_Matrix4x4_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 MultiplyVector2(UnityEngine.Matrix4x4 ByRef, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_RMultiplyVector2_Ref_Matrix4x4_Vector2;
		public static RMethod RMultiplyVector2_Ref_Matrix4x4_Vector2
		{
			get
			{
				if(r_RMultiplyVector2_Ref_Matrix4x4_Vector2 == null)
				{
					r_RMultiplyVector2_Ref_Matrix4x4_Vector2 = new(typeof(UnityEngine.UIElements.VisualElement), "MultiplyVector2", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Vector2));
					r_RMultiplyVector2_Ref_Matrix4x4_Vector2.SetBelong(null);
				}
				return r_RMultiplyVector2_Ref_Matrix4x4_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Rect MultiplyMatrix44Rect2(UnityEngine.Matrix4x4 ByRef, UnityEngine.Rect)
		/// </summary>
		protected static RMethod r_RMultiplyMatrix44Rect2_Ref_Matrix4x4_Rect;
		public static RMethod RMultiplyMatrix44Rect2_Ref_Matrix4x4_Rect
		{
			get
			{
				if(r_RMultiplyMatrix44Rect2_Ref_Matrix4x4_Rect == null)
				{
					r_RMultiplyMatrix44Rect2_Ref_Matrix4x4_Rect = new(typeof(UnityEngine.UIElements.VisualElement), "MultiplyMatrix44Rect2", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Rect));
					r_RMultiplyMatrix44Rect2_Ref_Matrix4x4_Rect.SetBelong(null);
				}
				return r_RMultiplyMatrix44Rect2_Ref_Matrix4x4_Rect;
			}
		}

		/// <summary>
		/// Void MultiplyMatrix34(UnityEngine.Matrix4x4 ByRef, UnityEngine.Matrix4x4 ByRef, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected static RMethod r_RMultiplyMatrix34_Ref_Matrix4x4_Ref_Matrix4x4_Out_Matrix4x4;
		public static RMethod RMultiplyMatrix34_Ref_Matrix4x4_Ref_Matrix4x4_Out_Matrix4x4
		{
			get
			{
				if(r_RMultiplyMatrix34_Ref_Matrix4x4_Ref_Matrix4x4_Out_Matrix4x4 == null)
				{
					r_RMultiplyMatrix34_Ref_Matrix4x4_Ref_Matrix4x4_Out_Matrix4x4 = new(typeof(UnityEngine.UIElements.VisualElement), "MultiplyMatrix34", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_RMultiplyMatrix34_Ref_Matrix4x4_Ref_Matrix4x4_Out_Matrix4x4.SetBelong(null);
				}
				return r_RMultiplyMatrix34_Ref_Matrix4x4_Ref_Matrix4x4_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void TranslateMatrix34(UnityEngine.Matrix4x4 ByRef, UnityEngine.Vector3, UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected static RMethod r_RTranslateMatrix34_Ref_Matrix4x4_Vector3_Out_Matrix4x4;
		public static RMethod RTranslateMatrix34_Ref_Matrix4x4_Vector3_Out_Matrix4x4
		{
			get
			{
				if(r_RTranslateMatrix34_Ref_Matrix4x4_Vector3_Out_Matrix4x4 == null)
				{
					r_RTranslateMatrix34_Ref_Matrix4x4_Vector3_Out_Matrix4x4 = new(typeof(UnityEngine.UIElements.VisualElement), "TranslateMatrix34", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Vector3), typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_RTranslateMatrix34_Ref_Matrix4x4_Vector3_Out_Matrix4x4.SetBelong(null);
				}
				return r_RTranslateMatrix34_Ref_Matrix4x4_Vector3_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void TranslateMatrix34InPlace(UnityEngine.Matrix4x4 ByRef, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RTranslateMatrix34InPlace_Ref_Matrix4x4_Vector3;
		public static RMethod RTranslateMatrix34InPlace_Ref_Matrix4x4_Vector3
		{
			get
			{
				if(r_RTranslateMatrix34InPlace_Ref_Matrix4x4_Vector3 == null)
				{
					r_RTranslateMatrix34InPlace_Ref_Matrix4x4_Vector3 = new(typeof(UnityEngine.UIElements.VisualElement), "TranslateMatrix34InPlace", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Vector3));
					r_RTranslateMatrix34InPlace_Ref_Matrix4x4_Vector3.SetBelong(null);
				}
				return r_RTranslateMatrix34InPlace_Ref_Matrix4x4_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(System.Action`1[UnityEngine.UIElements.TimerState])
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IVisualElementScheduler__0__Execute_Action_d_TimerState_p_;
		public virtual RMethod RUnityEngine__0__UIElements__0__IVisualElementScheduler__0__Execute_Action_d_TimerState_p_
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IVisualElementScheduler__0__Execute_Action_d_TimerState_p_ == null)
				{
					r_RUnityEngine__0__UIElements__0__IVisualElementScheduler__0__Execute_Action_d_TimerState_p_ = new(this, "UnityEngine.UIElements.IVisualElementScheduler.Execute", 0, typeof(System.Action<>).MakeGenericType(typeof(UnityEngine.UIElements.TimerState)));
					r_RUnityEngine__0__UIElements__0__IVisualElementScheduler__0__Execute_Action_d_TimerState_p_.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IVisualElementScheduler__0__Execute_Action_d_TimerState_p_;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(System.Action)
		/// </summary>
		protected RMethod r_RUnityEngine__0__UIElements__0__IVisualElementScheduler__0__Execute_Action;
		public virtual RMethod RUnityEngine__0__UIElements__0__IVisualElementScheduler__0__Execute_Action
		{
			get
			{
				if(r_RUnityEngine__0__UIElements__0__IVisualElementScheduler__0__Execute_Action == null)
				{
					r_RUnityEngine__0__UIElements__0__IVisualElementScheduler__0__Execute_Action = new(this, "UnityEngine.UIElements.IVisualElementScheduler.Execute", 0, typeof(System.Action));
					r_RUnityEngine__0__UIElements__0__IVisualElementScheduler__0__Execute_Action.SetBelong(this.instance);
				}
				return r_RUnityEngine__0__UIElements__0__IVisualElementScheduler__0__Execute_Action;
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
		/// UnityEngine.UIElements.StyleFloat ResolveLengthValue(UnityEngine.UIElements.Length, Boolean)
		/// </summary>
		protected RMethod r_RResolveLengthValue_Length_Boolean;
		public virtual RMethod RResolveLengthValue_Length_Boolean
		{
			get
			{
				if(r_RResolveLengthValue_Length_Boolean == null)
				{
					r_RResolveLengthValue_Length_Boolean = new(this, "ResolveLengthValue", 0, typeof(UnityEngine.UIElements.Length), typeof(System.Boolean));
					r_RResolveLengthValue_Length_Boolean.SetBelong(this.instance);
				}
				return r_RResolveLengthValue_Length_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ResolveTranslate()
		/// </summary>
		protected RMethod r_RResolveTranslate;
		public virtual RMethod RResolveTranslate
		{
			get
			{
				if(r_RResolveTranslate == null)
				{
					r_RResolveTranslate = new(this, "ResolveTranslate", 0);
					r_RResolveTranslate.SetBelong(this.instance);
				}
				return r_RResolveTranslate;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ResolveTransformOrigin()
		/// </summary>
		protected RMethod r_RResolveTransformOrigin;
		public virtual RMethod RResolveTransformOrigin
		{
			get
			{
				if(r_RResolveTransformOrigin == null)
				{
					r_RResolveTransformOrigin = new(this, "ResolveTransformOrigin", 0);
					r_RResolveTransformOrigin.SetBelong(this.instance);
				}
				return r_RResolveTransformOrigin;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion ResolveRotation()
		/// </summary>
		protected RMethod r_RResolveRotation;
		public virtual RMethod RResolveRotation
		{
			get
			{
				if(r_RResolveRotation == null)
				{
					r_RResolveRotation = new(this, "ResolveRotation", 0);
					r_RResolveRotation.SetBelong(this.instance);
				}
				return r_RResolveRotation;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ResolveScale()
		/// </summary>
		protected RMethod r_RResolveScale;
		public virtual RMethod RResolveScale
		{
			get
			{
				if(r_RResolveScale == null)
				{
					r_RResolveScale = new(this, "ResolveScale", 0);
					r_RResolveScale.SetBelong(this.instance);
				}
				return r_RResolveScale;
			}
		}

		/// <summary>
		/// TypeData GetOrCreateTypeData(System.Type)
		/// </summary>
		protected static RMethod r_RGetOrCreateTypeData_Type;
		public static RMethod RGetOrCreateTypeData_Type
		{
			get
			{
				if(r_RGetOrCreateTypeData_Type == null)
				{
					r_RGetOrCreateTypeData_Type = new(typeof(UnityEngine.UIElements.VisualElement), "GetOrCreateTypeData", 0, typeof(System.Type));
					r_RGetOrCreateTypeData_Type.SetBelong(null);
				}
				return r_RGetOrCreateTypeData_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaSize <AssignMeasureFunction>b__423_0(UnityEngine.Yoga.YogaNode, Single, UnityEngine.Yoga.YogaMeasureMode, Single, UnityEngine.Yoga.YogaMeasureMode)
		/// </summary>
		protected RMethod r_R__1__AssignMeasureFunction__2__b__423_0_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode;
		public virtual RMethod R__1__AssignMeasureFunction__2__b__423_0_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode
		{
			get
			{
				if(r_R__1__AssignMeasureFunction__2__b__423_0_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode == null)
				{
					r_R__1__AssignMeasureFunction__2__b__423_0_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode = new(this, "<AssignMeasureFunction>b__423_0", 0,  ReleactionUtils.GetType("UnityEngine.Yoga.YogaNode"), typeof(System.Single),  ReleactionUtils.GetType("UnityEngine.Yoga.YogaMeasureMode"), typeof(System.Single),  ReleactionUtils.GetType("UnityEngine.Yoga.YogaMeasureMode"));
					r_R__1__AssignMeasureFunction__2__b__423_0_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode.SetBelong(this.instance);
				}
				return r_R__1__AssignMeasureFunction__2__b__423_0_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode;
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

        public virtual System.Object GetStylePropertyAnimationSystem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetStylePropertyAnimationSystem.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



















        public virtual void UnityEngine__0__UIElements__0__IStylePropertyAnimations__0__CancelAllAnimations()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnityEngine__0__UIElements__0__IStylePropertyAnimations__0__CancelAllAnimations.Invoke(___genericsType, ___parameters);

            
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


        public virtual void UpdateWorldClip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateWorldClip.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rect CombineClipRects(UnityEngine.Rect  @rect, UnityEngine.Rect  @parentRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @parentRect};
            var ___result = RCombineClipRects_Rect_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual UnityEngine.Rect SubstractBorderPadding(UnityEngine.Rect  @worldRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@worldRect};
            var ___result = RSubstractBorderPadding_Rect.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public static UnityEngine.Rect ComputeAAAlignedBound(UnityEngine.Rect  @position, UnityEngine.Matrix4x4  @mat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @mat};
            var ___result = RComputeAAAlignedBound_Rect_Matrix4x4.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rect)___result;
        }


        public virtual void UpdateHoverPseudoState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateHoverPseudoState.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean IsPartOfCapturedChain(UnityEngine.UIElements.VisualElement  @self, in UnityEngine.UIElements.IEventHandler  @capturingElement)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self, @capturingElement};
            var ___result = RIsPartOfCapturedChain_VisualElement_In_IEventHandler.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ChangeIMGUIContainerCount(System.Int32  @delta)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delta};
            var ___result = RChangeIMGUIContainerCount_Int32.Invoke(___genericsType, ___parameters);

            
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


        public virtual void SetTooltip(UnityEngine.UIElements.TooltipEvent  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RSetTooltip_TooltipEvent.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Boolean SetEnabledFromHierarchyPrivate(System.Boolean  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RSetEnabledFromHierarchyPrivate_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetEnabled(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetEnabled_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PropagateEnabledToChildren(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RPropagateEnabledToChildren_Boolean.Invoke(___genericsType, ___parameters);

            
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


        public virtual void AssignMeasureFunction()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAssignMeasureFunction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveMeasureFunction()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemoveMeasureFunction.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void SetSize(UnityEngine.Vector2  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size};
            var ___result = RSetSize_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FinalizeLayout()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalizeLayout.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Boolean TryGetPropertyInternal(UnityEngine.PropertyName  @key, out System.Object  @value)
        {
			value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RTryGetPropertyInternal_PropertyName_Out_Object.Invoke(___genericsType, ___parameters);
			value = (System.Object)___parameters[1];

            return (System.Boolean)___result;
        }


        public static void CheckUserKeyArgument(UnityEngine.PropertyName  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RCheckUserKeyArgument_PropertyName.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPropertyInternal(UnityEngine.PropertyName  @key, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RSetPropertyInternal_PropertyName_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateCursorStyle(System.Int64  @eventType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventType};
            var ___result = RUpdateCursorStyle_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Material getRuntimeMaterial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RgetRuntimeMaterial.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Material)___result;
        }


        public virtual void ApplyPlayerRenderingToEditorElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RApplyPlayerRenderingToEditorElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetAnimationSystem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAnimationSystem.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }




        public virtual void UnregisterRunningAnimations()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnregisterRunningAnimations.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterRunningAnimations()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRegisterRunningAnimations.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<System.Single> UnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start(System.Single  @from, System.Single  @to, System.Int32  @durationMs, System.Action<UnityEngine.UIElements.VisualElement, System.Single>  @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Single_Single_Int32_Action_d_VisualElement_Single_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<System.Single>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect> UnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start(UnityEngine.Rect  @from, UnityEngine.Rect  @to, System.Int32  @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Rect>  @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Rect_Rect_Int32_Action_d_VisualElement_Rect_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Color> UnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start(UnityEngine.Color  @from, UnityEngine.Color  @to, System.Int32  @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Color>  @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Color_Color_Int32_Action_d_VisualElement_Color_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Color>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3> UnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start(UnityEngine.Vector3  @from, UnityEngine.Vector3  @to, System.Int32  @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Vector3>  @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Vector3_Vector3_Int32_Action_d_VisualElement_Vector3_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2> UnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start(UnityEngine.Vector2  @from, UnityEngine.Vector2  @to, System.Int32  @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Vector2>  @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Vector2_Vector2_Int32_Action_d_VisualElement_Vector2_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion> UnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start(UnityEngine.Quaternion  @from, UnityEngine.Quaternion  @to, System.Int32  @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Quaternion>  @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Quaternion_Quaternion_Int32_Action_d_VisualElement_Quaternion_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> UnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start(UnityEngine.UIElements.Experimental.StyleValues  @from, UnityEngine.UIElements.Experimental.StyleValues  @to, System.Int32  @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs};
            var ___result = RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_StyleValues_StyleValues_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<System.Single> UnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start(System.Func<UnityEngine.UIElements.VisualElement, System.Single>  @fromValueGetter, System.Single  @to, System.Int32  @durationMs, System.Action<UnityEngine.UIElements.VisualElement, System.Single>  @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Single_p__Single_Int32_Action_d_VisualElement_Single_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<System.Single>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect> UnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.Rect>  @fromValueGetter, UnityEngine.Rect  @to, System.Int32  @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Rect>  @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Rect_p__Rect_Int32_Action_d_VisualElement_Rect_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Color> UnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.Color>  @fromValueGetter, UnityEngine.Color  @to, System.Int32  @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Color>  @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Color_p__Color_Int32_Action_d_VisualElement_Color_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Color>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3> UnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.Vector3>  @fromValueGetter, UnityEngine.Vector3  @to, System.Int32  @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Vector3>  @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Vector3_p__Vector3_Int32_Action_d_VisualElement_Vector3_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2> UnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.Vector2>  @fromValueGetter, UnityEngine.Vector2  @to, System.Int32  @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Vector2>  @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Vector2_p__Vector2_Int32_Action_d_VisualElement_Vector2_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion> UnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.Quaternion>  @fromValueGetter, UnityEngine.Quaternion  @to, System.Int32  @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Quaternion>  @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_Func_d_VisualElement_Quaternion_p__Quaternion_Int32_Action_d_VisualElement_Quaternion_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion>)___result;
        }


        public static UnityEngine.UIElements.Experimental.ValueAnimation<T> StartAnimation<T>(UnityEngine.UIElements.Experimental.ValueAnimation<T>  @anim, System.Func<UnityEngine.UIElements.VisualElement, T>  @fromValueGetter, T  @to, System.Int32  @durationMs, System.Action<UnityEngine.UIElements.VisualElement, T>  @onValueChanged)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@anim, @fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RStartAnimation_GT_ValueAnimation_d_T_p__Func_d_VisualElement_T_p__T_Int32_Action_d_VisualElement_T_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<T>)___result;
        }


        public static void AssignStyleValues(UnityEngine.UIElements.VisualElement  @ve, UnityEngine.UIElements.Experimental.StyleValues  @src)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @src};
            var ___result = RAssignStyleValues_VisualElement_StyleValues.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.Experimental.StyleValues ReadCurrentValues(UnityEngine.UIElements.VisualElement  @ve, UnityEngine.UIElements.Experimental.StyleValues  @targetValuesToRead)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @targetValuesToRead};
            var ___result = RReadCurrentValues_VisualElement_StyleValues.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.StyleValues)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> UnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start(UnityEngine.UIElements.Experimental.StyleValues  @to, System.Int32  @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Start_StyleValues_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.Experimental.StyleValues>  @fromValueGetter, UnityEngine.UIElements.Experimental.StyleValues  @to, System.Int32  @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs};
            var ___result = RStart_Func_d_VisualElement_StyleValues_p__StyleValues_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect> UnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Layout(UnityEngine.Rect  @to, System.Int32  @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Layout_Rect_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2> UnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__TopLeft(UnityEngine.Vector2  @to, System.Int32  @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__TopLeft_Vector2_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2> UnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Size(UnityEngine.Vector2  @to, System.Int32  @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Size_Vector2_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<System.Single> UnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Scale(System.Single  @to, System.Int32  @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Scale_Single_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<System.Single>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3> UnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Position(UnityEngine.Vector3  @to, System.Int32  @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Position_Vector3_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3>)___result;
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion> UnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Rotation(UnityEngine.Quaternion  @to, System.Int32  @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RUnityEngine__0__UIElements__0__Experimental__0__ITransitionAnimations__0__Rotation_Quaternion_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion>)___result;
        }


        public virtual void DirtyNextParentWithEventCallback()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDirtyNextParentWithEventCallback.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAsNextParentWithEventCallback()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetAsNextParentWithEventCallback.Invoke(___genericsType, ___parameters);

            
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


        public virtual void UpdateCallbackParentCategories()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateCallbackParentCategories.Invoke(___genericsType, ___parameters);

            
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


        public virtual void GatherAllChildren(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>  @elements)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elements};
            var ___result = RGatherAllChildren_List_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            
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


        public static System.Single Min(System.Single  @a, System.Single  @b, System.Single  @c, System.Single  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @c, @d};
            var ___result = RMin_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single Max(System.Single  @a, System.Single  @b, System.Single  @c, System.Single  @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @c, @d};
            var ___result = RMax_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void TransformAlignedRectToParentSpace(ref UnityEngine.Rect  @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect};
            var ___result = RTransformAlignedRectToParentSpace_Ref_Rect.Invoke(___genericsType, ___parameters);
			rect = (UnityEngine.Rect)___parameters[0];

            
        }


        public static UnityEngine.Rect CalculateConservativeRect(ref UnityEngine.Matrix4x4  @matrix, UnityEngine.Rect  @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @rect};
            var ___result = RCalculateConservativeRect_Ref_Matrix4x4_Rect.Invoke(___genericsType, ___parameters);
			matrix = (UnityEngine.Matrix4x4)___parameters[0];

            return (UnityEngine.Rect)___result;
        }


        public static void TransformAlignedRect(ref UnityEngine.Matrix4x4  @matrix, ref UnityEngine.Rect  @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @rect};
            var ___result = RTransformAlignedRect_Ref_Matrix4x4_Ref_Rect.Invoke(___genericsType, ___parameters);
			matrix = (UnityEngine.Matrix4x4)___parameters[0];
			rect = (UnityEngine.Rect)___parameters[1];

            
        }


        public static void OrderMinMaxRect(ref UnityEngine.Rect  @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect};
            var ___result = ROrderMinMaxRect_Ref_Rect.Invoke(___genericsType, ___parameters);
			rect = (UnityEngine.Rect)___parameters[0];

            
        }


        public static UnityEngine.Vector2 MultiplyMatrix44Point2(ref UnityEngine.Matrix4x4  @lhs, UnityEngine.Vector2  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @point};
            var ___result = RMultiplyMatrix44Point2_Ref_Matrix4x4_Vector2.Invoke(___genericsType, ___parameters);
			lhs = (UnityEngine.Matrix4x4)___parameters[0];

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 MultiplyVector2(ref UnityEngine.Matrix4x4  @lhs, UnityEngine.Vector2  @vector)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @vector};
            var ___result = RMultiplyVector2_Ref_Matrix4x4_Vector2.Invoke(___genericsType, ___parameters);
			lhs = (UnityEngine.Matrix4x4)___parameters[0];

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Rect MultiplyMatrix44Rect2(ref UnityEngine.Matrix4x4  @lhs, UnityEngine.Rect  @r)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @r};
            var ___result = RMultiplyMatrix44Rect2_Ref_Matrix4x4_Rect.Invoke(___genericsType, ___parameters);
			lhs = (UnityEngine.Matrix4x4)___parameters[0];

            return (UnityEngine.Rect)___result;
        }


        public static void MultiplyMatrix34(ref UnityEngine.Matrix4x4  @lhs, ref UnityEngine.Matrix4x4  @rhs, out UnityEngine.Matrix4x4  @res)
        {
			res = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs, @res};
            var ___result = RMultiplyMatrix34_Ref_Matrix4x4_Ref_Matrix4x4_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			lhs = (UnityEngine.Matrix4x4)___parameters[0];
			rhs = (UnityEngine.Matrix4x4)___parameters[1];
			res = (UnityEngine.Matrix4x4)___parameters[2];

            
        }


        public static void TranslateMatrix34(ref UnityEngine.Matrix4x4  @lhs, UnityEngine.Vector3  @rhs, out UnityEngine.Matrix4x4  @res)
        {
			res = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs, @res};
            var ___result = RTranslateMatrix34_Ref_Matrix4x4_Vector3_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			lhs = (UnityEngine.Matrix4x4)___parameters[0];
			res = (UnityEngine.Matrix4x4)___parameters[2];

            
        }


        public static void TranslateMatrix34InPlace(ref UnityEngine.Matrix4x4  @lhs, UnityEngine.Vector3  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RTranslateMatrix34InPlace_Ref_Matrix4x4_Vector3.Invoke(___genericsType, ___parameters);
			lhs = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual UnityEngine.UIElements.IVisualElementScheduledItem UnityEngine__0__UIElements__0__IVisualElementScheduler__0__Execute(System.Action<UnityEngine.UIElements.TimerState>  @timerUpdateEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timerUpdateEvent};
            var ___result = RUnityEngine__0__UIElements__0__IVisualElementScheduler__0__Execute_Action_d_TimerState_p_.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.IVisualElementScheduledItem)___result;
        }


        public virtual UnityEngine.UIElements.IVisualElementScheduledItem UnityEngine__0__UIElements__0__IVisualElementScheduler__0__Execute(System.Action  @updateEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updateEvent};
            var ___result = RUnityEngine__0__UIElements__0__IVisualElementScheduler__0__Execute_Action.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.IVisualElementScheduledItem)___result;
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


        public virtual UnityEngine.UIElements.StyleFloat ResolveLengthValue(UnityEngine.UIElements.Length  @length, System.Boolean  @isRow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@length, @isRow};
            var ___result = RResolveLengthValue_Length_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.StyleFloat)___result;
        }


        public virtual UnityEngine.Vector3 ResolveTranslate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResolveTranslate.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 ResolveTransformOrigin()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResolveTransformOrigin.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Quaternion ResolveRotation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResolveRotation.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Quaternion)___result;
        }


        public virtual UnityEngine.Vector3 ResolveScale()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResolveScale.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static System.Object GetOrCreateTypeData(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetOrCreateTypeData_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
