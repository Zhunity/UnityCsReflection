
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.VisualElement
	/// </summary>
    public partial class RVisualElement : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.VisualElement);
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


		/// <summary>
		/// System.Int32 <UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__runningAnimationCount__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__runningAnimationCount__1__k__BackingField
		{
			get
			{
				if(r_F__0__UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__runningAnimationCount__1__k__BackingField == null)
				{
					r_F__0__UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__runningAnimationCount__1__k__BackingField = new(this, "<UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount>k__BackingField");
				}
				return r_F__0__UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__runningAnimationCount__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__completedAnimationCount__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__completedAnimationCount__1__k__BackingField
		{
			get
			{
				if(r_F__0__UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__completedAnimationCount__1__k__BackingField == null)
				{
					r_F__0__UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__completedAnimationCount__1__k__BackingField = new(this, "<UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount>k__BackingField");
				}
				return r_F__0__UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__completedAnimationCount__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.UInt32 s_NextId
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fs_NextId;
		public static Hvak.Editor.Refleaction.RSystem.RUInt32 RFs_NextId
		{
			get
			{
				if(r_Fs_NextId == null)
				{
					r_Fs_NextId = new(Type, "s_NextId");
				}
				return r_Fs_NextId;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] s_EmptyClassList
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_Fs_EmptyClassList;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RFs_EmptyClassList
		{
			get
			{
				if(r_Fs_EmptyClassList == null)
				{
					r_Fs_EmptyClassList = new(Type, "s_EmptyClassList");
				}
				return r_Fs_EmptyClassList;
			}
		}

		/// <summary>
		/// UnityEngine.PropertyName userDataPropertyKey
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RPropertyName r_FuserDataPropertyKey;
		public static Hvak.Editor.Refleaction.RUnityEngine.RPropertyName RFuserDataPropertyKey
		{
			get
			{
				if(r_FuserDataPropertyKey == null)
				{
					r_FuserDataPropertyKey = new(Type, "userDataPropertyKey");
				}
				return r_FuserDataPropertyKey;
			}
		}

		/// <summary>
		/// System.String disabledUssClassName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FdisabledUssClassName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFdisabledUssClassName
		{
			get
			{
				if(r_FdisabledUssClassName == null)
				{
					r_FdisabledUssClassName = new(Type, "disabledUssClassName");
				}
				return r_FdisabledUssClassName;
			}
		}

		/// <summary>
		/// System.String m_Name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_Name;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_Name
		{
			get
			{
				if(r_Fm_Name == null)
				{
					r_Fm_Name = new(this, "m_Name");
				}
				return r_Fm_Name;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_ClassList
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> r_Fm_ClassList;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RString> RFm_ClassList
		{
			get
			{
				if(r_Fm_ClassList == null)
				{
					r_Fm_ClassList = new(this, "m_ClassList");
				}
				return r_Fm_ClassList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Collections.Generic.KeyValuePair`2[UnityEngine.PropertyName,System.Object]] m_PropertyBag
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RKeyValuePair<Hvak.Editor.Refleaction.RUnityEngine.RPropertyName, Hvak.Editor.Refleaction.RSystem.RObject>> r_Fm_PropertyBag;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RKeyValuePair<Hvak.Editor.Refleaction.RUnityEngine.RPropertyName, Hvak.Editor.Refleaction.RSystem.RObject>> RFm_PropertyBag
		{
			get
			{
				if(r_Fm_PropertyBag == null)
				{
					r_Fm_PropertyBag = new(this, "m_PropertyBag");
				}
				return r_Fm_PropertyBag;
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
		/// System.String m_ViewDataKey
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Fm_ViewDataKey;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RFm_ViewDataKey
		{
			get
			{
				if(r_Fm_ViewDataKey == null)
				{
					r_Fm_ViewDataKey = new(this, "m_ViewDataKey");
				}
				return r_Fm_ViewDataKey;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.RenderHints m_RenderHints
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRenderHints r_Fm_RenderHints;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRenderHints RFm_RenderHints
		{
			get
			{
				if(r_Fm_RenderHints == null)
				{
					r_Fm_RenderHints = new(this, "m_RenderHints");
				}
				return r_Fm_RenderHints;
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
		/// UnityEngine.Rect m_Layout
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Fm_Layout;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFm_Layout
		{
			get
			{
				if(r_Fm_Layout == null)
				{
					r_Fm_Layout = new(this, "m_Layout");
				}
				return r_Fm_Layout;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_BoundingBox
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Fm_BoundingBox;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFm_BoundingBox
		{
			get
			{
				if(r_Fm_BoundingBox == null)
				{
					r_Fm_BoundingBox = new(this, "m_BoundingBox");
				}
				return r_Fm_BoundingBox;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags worldBoundingBoxDirtyDependencies
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags r_FworldBoundingBoxDirtyDependencies;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags RFworldBoundingBoxDirtyDependencies
		{
			get
			{
				if(r_FworldBoundingBoxDirtyDependencies == null)
				{
					r_FworldBoundingBoxDirtyDependencies = new(Type, "worldBoundingBoxDirtyDependencies");
				}
				return r_FworldBoundingBoxDirtyDependencies;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_WorldBoundingBox
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Fm_WorldBoundingBox;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFm_WorldBoundingBox
		{
			get
			{
				if(r_Fm_WorldBoundingBox == null)
				{
					r_Fm_WorldBoundingBox = new(this, "m_WorldBoundingBox");
				}
				return r_Fm_WorldBoundingBox;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElementFlags worldTransformInverseDirtyDependencies
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags r_FworldTransformInverseDirtyDependencies;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementFlags RFworldTransformInverseDirtyDependencies
		{
			get
			{
				if(r_FworldTransformInverseDirtyDependencies == null)
				{
					r_FworldTransformInverseDirtyDependencies = new(Type, "worldTransformInverseDirtyDependencies");
				}
				return r_FworldTransformInverseDirtyDependencies;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 m_WorldTransformCache
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_Fm_WorldTransformCache;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 RFm_WorldTransformCache
		{
			get
			{
				if(r_Fm_WorldTransformCache == null)
				{
					r_Fm_WorldTransformCache = new(this, "m_WorldTransformCache");
				}
				return r_Fm_WorldTransformCache;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 m_WorldTransformInverseCache
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_Fm_WorldTransformInverseCache;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 RFm_WorldTransformInverseCache
		{
			get
			{
				if(r_Fm_WorldTransformInverseCache == null)
				{
					r_Fm_WorldTransformInverseCache = new(this, "m_WorldTransformInverseCache");
				}
				return r_Fm_WorldTransformInverseCache;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_WorldClip
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Fm_WorldClip;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFm_WorldClip
		{
			get
			{
				if(r_Fm_WorldClip == null)
				{
					r_Fm_WorldClip = new(this, "m_WorldClip");
				}
				return r_Fm_WorldClip;
			}
		}

		/// <summary>
		/// UnityEngine.Rect m_WorldClipMinusGroup
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_Fm_WorldClipMinusGroup;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RFm_WorldClipMinusGroup
		{
			get
			{
				if(r_Fm_WorldClipMinusGroup == null)
				{
					r_Fm_WorldClipMinusGroup = new(this, "m_WorldClipMinusGroup");
				}
				return r_Fm_WorldClipMinusGroup;
			}
		}

		/// <summary>
		/// System.Boolean m_WorldClipIsInfinite
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_WorldClipIsInfinite;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_WorldClipIsInfinite
		{
			get
			{
				if(r_Fm_WorldClipIsInfinite == null)
				{
					r_Fm_WorldClipIsInfinite = new(this, "m_WorldClipIsInfinite");
				}
				return r_Fm_WorldClipIsInfinite;
			}
		}

		/// <summary>
		/// UnityEngine.Rect s_InfiniteRect
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RRect r_Fs_InfiniteRect;
		public static Hvak.Editor.Refleaction.RUnityEngine.RRect RFs_InfiniteRect
		{
			get
			{
				if(r_Fs_InfiniteRect == null)
				{
					r_Fs_InfiniteRect = new(Type, "s_InfiniteRect");
				}
				return r_Fs_InfiniteRect;
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
		/// UnityEngine.UIElements.PseudoStates m_PseudoStates
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPseudoStates r_Fm_PseudoStates;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPseudoStates RFm_PseudoStates
		{
			get
			{
				if(r_Fm_PseudoStates == null)
				{
					r_Fm_PseudoStates = new(this, "m_PseudoStates");
				}
				return r_Fm_PseudoStates;
			}
		}

		/// <summary>
		/// System.Int32 <containedPointerIds>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__containedPointerIds__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__containedPointerIds__1__k__BackingField
		{
			get
			{
				if(r_F__0__containedPointerIds__1__k__BackingField == null)
				{
					r_F__0__containedPointerIds__1__k__BackingField = new(this, "<containedPointerIds>k__BackingField");
				}
				return r_F__0__containedPointerIds__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.PickingMode <pickingMode>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPickingMode r_F__0__pickingMode__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPickingMode RF__0__pickingMode__1__k__BackingField
		{
			get
			{
				if(r_F__0__pickingMode__1__k__BackingField == null)
				{
					r_F__0__pickingMode__1__k__BackingField = new(this, "<pickingMode>k__BackingField");
				}
				return r_F__0__pickingMode__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaNode <yogaNode>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaNode r_F__0__yogaNode__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaNode RF__0__yogaNode__1__k__BackingField
		{
			get
			{
				if(r_F__0__yogaNode__1__k__BackingField == null)
				{
					r_F__0__yogaNode__1__k__BackingField = new(this, "<yogaNode>k__BackingField");
				}
				return r_F__0__yogaNode__1__k__BackingField;
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
		/// System.Boolean <enabledSelf>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__enabledSelf__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__enabledSelf__1__k__BackingField
		{
			get
			{
				if(r_F__0__enabledSelf__1__k__BackingField == null)
				{
					r_F__0__enabledSelf__1__k__BackingField = new(this, "<enabledSelf>k__BackingField");
				}
				return r_F__0__enabledSelf__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.MeshGenerationContext] <generateVisualContent>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext> r_F__0__generateVisualContent__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext> RF__0__generateVisualContent__1__k__BackingField
		{
			get
			{
				if(r_F__0__generateVisualContent__1__k__BackingField == null)
				{
					r_F__0__generateVisualContent__1__k__BackingField = new(this, "<generateVisualContent>k__BackingField");
				}
				return r_F__0__generateVisualContent__1__k__BackingField;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker k_GenerateVisualContentMarker
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fk_GenerateVisualContentMarker;
		public virtual Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFk_GenerateVisualContentMarker
		{
			get
			{
				if(r_Fk_GenerateVisualContentMarker == null)
				{
					r_Fk_GenerateVisualContentMarker = new(this, "k_GenerateVisualContentMarker");
				}
				return r_Fk_GenerateVisualContentMarker;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement+RenderTargetMode m_SubRenderTargetMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RRenderTargetMode r_Fm_SubRenderTargetMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RRenderTargetMode RFm_SubRenderTargetMode
		{
			get
			{
				if(r_Fm_SubRenderTargetMode == null)
				{
					r_Fm_SubRenderTargetMode = new(this, "m_SubRenderTargetMode");
				}
				return r_Fm_SubRenderTargetMode;
			}
		}

		/// <summary>
		/// UnityEngine.Material s_runtimeMaterial
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RMaterial r_Fs_runtimeMaterial;
		public static Hvak.Editor.Refleaction.RUnityEngine.RMaterial RFs_runtimeMaterial
		{
			get
			{
				if(r_Fs_runtimeMaterial == null)
				{
					r_Fs_runtimeMaterial = new(Type, "s_runtimeMaterial");
				}
				return r_Fs_runtimeMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material m_defaultMaterial
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterial r_Fm_defaultMaterial;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterial RFm_defaultMaterial
		{
			get
			{
				if(r_Fm_defaultMaterial == null)
				{
					r_Fm_defaultMaterial = new(this, "m_defaultMaterial");
				}
				return r_Fm_defaultMaterial;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.Experimental.IValueAnimationUpdate] m_RunningAnimations
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate> r_Fm_RunningAnimations;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate> RFm_RunningAnimations
		{
			get
			{
				if(r_Fm_RunningAnimations == null)
				{
					r_Fm_RunningAnimations = new(this, "m_RunningAnimations");
				}
				return r_Fm_RunningAnimations;
			}
		}

		/// <summary>
		/// System.UInt32 s_NextParentVersion
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fs_NextParentVersion;
		public static Hvak.Editor.Refleaction.RSystem.RUInt32 RFs_NextParentVersion
		{
			get
			{
				if(r_Fs_NextParentVersion == null)
				{
					r_Fs_NextParentVersion = new(Type, "s_NextParentVersion");
				}
				return r_Fs_NextParentVersion;
			}
		}

		/// <summary>
		/// System.UInt32 m_NextParentCachedVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fm_NextParentCachedVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFm_NextParentCachedVersion
		{
			get
			{
				if(r_Fm_NextParentCachedVersion == null)
				{
					r_Fm_NextParentCachedVersion = new(this, "m_NextParentCachedVersion");
				}
				return r_Fm_NextParentCachedVersion;
			}
		}

		/// <summary>
		/// System.UInt32 m_NextParentRequiredVersion
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RUInt32 r_Fm_NextParentRequiredVersion;
		public virtual Hvak.Editor.Refleaction.RSystem.RUInt32 RFm_NextParentRequiredVersion
		{
			get
			{
				if(r_Fm_NextParentRequiredVersion == null)
				{
					r_Fm_NextParentRequiredVersion = new(this, "m_NextParentRequiredVersion");
				}
				return r_Fm_NextParentRequiredVersion;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_CachedNextParentWithEventCallback
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_CachedNextParentWithEventCallback;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_CachedNextParentWithEventCallback
		{
			get
			{
				if(r_Fm_CachedNextParentWithEventCallback == null)
				{
					r_Fm_CachedNextParentWithEventCallback = new(this, "m_CachedNextParentWithEventCallback");
				}
				return r_Fm_CachedNextParentWithEventCallback;
			}
		}

		/// <summary>
		/// System.Int32 m_EventCallbackCategories
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_EventCallbackCategories;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_EventCallbackCategories
		{
			get
			{
				if(r_Fm_EventCallbackCategories == null)
				{
					r_Fm_EventCallbackCategories = new(this, "m_EventCallbackCategories");
				}
				return r_Fm_EventCallbackCategories;
			}
		}

		/// <summary>
		/// System.Int32 m_CachedEventCallbackParentCategories
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_CachedEventCallbackParentCategories;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_CachedEventCallbackParentCategories
		{
			get
			{
				if(r_Fm_CachedEventCallbackParentCategories == null)
				{
					r_Fm_CachedEventCallbackParentCategories = new(this, "m_CachedEventCallbackParentCategories");
				}
				return r_Fm_CachedEventCallbackParentCategories;
			}
		}

		/// <summary>
		/// System.Int32 m_DefaultActionEventCategories
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_DefaultActionEventCategories;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_DefaultActionEventCategories
		{
			get
			{
				if(r_Fm_DefaultActionEventCategories == null)
				{
					r_Fm_DefaultActionEventCategories = new(this, "m_DefaultActionEventCategories");
				}
				return r_Fm_DefaultActionEventCategories;
			}
		}

		/// <summary>
		/// System.Int32 m_DefaultActionAtTargetEventCategories
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_DefaultActionAtTargetEventCategories;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_DefaultActionAtTargetEventCategories
		{
			get
			{
				if(r_Fm_DefaultActionAtTargetEventCategories == null)
				{
					r_Fm_DefaultActionAtTargetEventCategories = new(this, "m_DefaultActionAtTargetEventCategories");
				}
				return r_Fm_DefaultActionAtTargetEventCategories;
			}
		}

		/// <summary>
		/// System.String k_RootVisualContainerName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fk_RootVisualContainerName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFk_RootVisualContainerName
		{
			get
			{
				if(r_Fk_RootVisualContainerName == null)
				{
					r_Fk_RootVisualContainerName = new(Type, "k_RootVisualContainerName");
				}
				return r_Fk_RootVisualContainerName;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement+Hierarchy <hierarchy>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RHierarchy r_F__0__hierarchy__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RHierarchy RF__0__hierarchy__1__k__BackingField
		{
			get
			{
				if(r_F__0__hierarchy__1__k__BackingField == null)
				{
					r_F__0__hierarchy__1__k__BackingField = new(this, "<hierarchy>k__BackingField");
				}
				return r_F__0__hierarchy__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <isRootVisualContainer>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__isRootVisualContainer__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__isRootVisualContainer__1__k__BackingField
		{
			get
			{
				if(r_F__0__isRootVisualContainer__1__k__BackingField == null)
				{
					r_F__0__isRootVisualContainer__1__k__BackingField = new(this, "<isRootVisualContainer>k__BackingField");
				}
				return r_F__0__isRootVisualContainer__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <cacheAsBitmap>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_F__0__cacheAsBitmap__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RF__0__cacheAsBitmap__1__k__BackingField
		{
			get
			{
				if(r_F__0__cacheAsBitmap__1__k__BackingField == null)
				{
					r_F__0__cacheAsBitmap__1__k__BackingField = new(this, "<cacheAsBitmap>k__BackingField");
				}
				return r_F__0__cacheAsBitmap__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_PhysicalParent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_PhysicalParent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_PhysicalParent
		{
			get
			{
				if(r_Fm_PhysicalParent == null)
				{
					r_Fm_PhysicalParent = new(this, "m_PhysicalParent");
				}
				return r_Fm_PhysicalParent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_LogicalParent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_LogicalParent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_LogicalParent
		{
			get
			{
				if(r_Fm_LogicalParent == null)
				{
					r_Fm_LogicalParent = new(this, "m_LogicalParent");
				}
				return r_Fm_LogicalParent;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement] s_EmptyList
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> r_Fs_EmptyList;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> RFs_EmptyList
		{
			get
			{
				if(r_Fs_EmptyList == null)
				{
					r_Fs_EmptyList = new(Type, "s_EmptyList");
				}
				return r_Fs_EmptyList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement] m_Children
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> r_Fm_Children;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement> RFm_Children
		{
			get
			{
				if(r_Fm_Children == null)
				{
					r_Fm_Children = new(this, "m_Children");
				}
				return r_Fm_Children;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseVisualElementPanel <elementPanel>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel r_F__0__elementPanel__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel RF__0__elementPanel__1__k__BackingField
		{
			get
			{
				if(r_F__0__elementPanel__1__k__BackingField == null)
				{
					r_F__0__elementPanel__1__k__BackingField = new(this, "<elementPanel>k__BackingField");
				}
				return r_F__0__elementPanel__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualTreeAsset m_VisualTreeAssetSource
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset r_Fm_VisualTreeAssetSource;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset RFm_VisualTreeAssetSource
		{
			get
			{
				if(r_Fm_VisualTreeAssetSource == null)
				{
					r_Fm_VisualTreeAssetSource = new(this, "m_VisualTreeAssetSource");
				}
				return r_Fm_VisualTreeAssetSource;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement+CustomStyleAccess s_CustomStyleAccess
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RCustomStyleAccess r_Fs_CustomStyleAccess;
		public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RCustomStyleAccess RFs_CustomStyleAccess
		{
			get
			{
				if(r_Fs_CustomStyleAccess == null)
				{
					r_Fs_CustomStyleAccess = new(Type, "s_CustomStyleAccess");
				}
				return r_Fs_CustomStyleAccess;
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
		/// System.Text.RegularExpressions.Regex s_InternalStyleSheetPath
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex r_Fs_InternalStyleSheetPath;
		public static Hvak.Editor.Refleaction.RSystem.RText.RRegularExpressions.RRegex RFs_InternalStyleSheetPath
		{
			get
			{
				if(r_Fs_InternalStyleSheetPath == null)
				{
					r_Fs_InternalStyleSheetPath = new(Type, "s_InternalStyleSheetPath");
				}
				return r_Fs_InternalStyleSheetPath;
			}
		}

		/// <summary>
		/// UnityEngine.PropertyName tooltipPropertyKey
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RPropertyName r_FtooltipPropertyKey;
		public static Hvak.Editor.Refleaction.RUnityEngine.RPropertyName RFtooltipPropertyKey
		{
			get
			{
				if(r_FtooltipPropertyKey == null)
				{
					r_FtooltipPropertyKey = new(Type, "tooltipPropertyKey");
				}
				return r_FtooltipPropertyKey;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Type,UnityEngine.UIElements.VisualElement+TypeData] s_TypeData
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RType, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RTypeData> r_Fs_TypeData;
		public static Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RDictionary<Hvak.Editor.Refleaction.RSystem.RType, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RTypeData> RFs_TypeData
		{
			get
			{
				if(r_Fs_TypeData == null)
				{
					r_Fs_TypeData = new(Type, "s_TypeData");
				}
				return r_Fs_TypeData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement+TypeData m_TypeData
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RTypeData r_Fm_TypeData;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RTypeData RFm_TypeData
		{
			get
			{
				if(r_Fm_TypeData == null)
				{
					r_Fm_TypeData = new(this, "m_TypeData");
				}
				return r_Fm_TypeData;
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
		/// UnityEngine.UIElements.Align UnityEngine.UIElements.IResolvedStyle.alignContent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignContent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign RPUnityEngine__2__UIElements__2__IResolvedStyle__2__alignContent
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignContent == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignContent = new(this, "UnityEngine.UIElements.IResolvedStyle.alignContent", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignContent;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Align UnityEngine.UIElements.IResolvedStyle.alignItems
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignItems;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign RPUnityEngine__2__UIElements__2__IResolvedStyle__2__alignItems
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignItems == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignItems = new(this, "UnityEngine.UIElements.IResolvedStyle.alignItems", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignItems;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Align UnityEngine.UIElements.IResolvedStyle.alignSelf
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignSelf;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAlign RPUnityEngine__2__UIElements__2__IResolvedStyle__2__alignSelf
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignSelf == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignSelf = new(this, "UnityEngine.UIElements.IResolvedStyle.alignSelf", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__alignSelf;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.backgroundColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundColor == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundColor = new(this, "UnityEngine.UIElements.IResolvedStyle.backgroundColor", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Background UnityEngine.UIElements.IResolvedStyle.backgroundImage
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackground r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundImage;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackground RPUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundImage
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundImage == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundImage = new(this, "UnityEngine.UIElements.IResolvedStyle.backgroundImage", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundImage;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition UnityEngine.UIElements.IResolvedStyle.backgroundPositionX
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundPosition r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundPositionX;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundPosition RPUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundPositionX
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundPositionX == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundPositionX = new(this, "UnityEngine.UIElements.IResolvedStyle.backgroundPositionX", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundPositionX;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundPosition UnityEngine.UIElements.IResolvedStyle.backgroundPositionY
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundPosition r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundPositionY;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundPosition RPUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundPositionY
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundPositionY == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundPositionY = new(this, "UnityEngine.UIElements.IResolvedStyle.backgroundPositionY", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundPositionY;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundRepeat UnityEngine.UIElements.IResolvedStyle.backgroundRepeat
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundRepeat r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundRepeat;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundRepeat RPUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundRepeat
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundRepeat == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundRepeat = new(this, "UnityEngine.UIElements.IResolvedStyle.backgroundRepeat", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundRepeat;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BackgroundSize UnityEngine.UIElements.IResolvedStyle.backgroundSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundSize r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundSize;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBackgroundSize RPUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundSize
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundSize == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundSize = new(this, "UnityEngine.UIElements.IResolvedStyle.backgroundSize", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__backgroundSize;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.borderBottomColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomColor == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomColor = new(this, "UnityEngine.UIElements.IResolvedStyle.borderBottomColor", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomColor;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderBottomLeftRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomLeftRadius;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomLeftRadius
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomLeftRadius == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomLeftRadius = new(this, "UnityEngine.UIElements.IResolvedStyle.borderBottomLeftRadius", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomLeftRadius;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderBottomRightRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomRightRadius;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomRightRadius
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomRightRadius == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomRightRadius = new(this, "UnityEngine.UIElements.IResolvedStyle.borderBottomRightRadius", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomRightRadius;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderBottomWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomWidth
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomWidth == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomWidth = new(this, "UnityEngine.UIElements.IResolvedStyle.borderBottomWidth", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderBottomWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.borderLeftColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderLeftColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderLeftColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderLeftColor == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderLeftColor = new(this, "UnityEngine.UIElements.IResolvedStyle.borderLeftColor", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderLeftColor;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderLeftWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderLeftWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderLeftWidth
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderLeftWidth == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderLeftWidth = new(this, "UnityEngine.UIElements.IResolvedStyle.borderLeftWidth", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderLeftWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.borderRightColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderRightColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderRightColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderRightColor == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderRightColor = new(this, "UnityEngine.UIElements.IResolvedStyle.borderRightColor", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderRightColor;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderRightWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderRightWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderRightWidth
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderRightWidth == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderRightWidth = new(this, "UnityEngine.UIElements.IResolvedStyle.borderRightWidth", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderRightWidth;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.borderTopColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopColor == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopColor = new(this, "UnityEngine.UIElements.IResolvedStyle.borderTopColor", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopColor;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderTopLeftRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopLeftRadius;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopLeftRadius
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopLeftRadius == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopLeftRadius = new(this, "UnityEngine.UIElements.IResolvedStyle.borderTopLeftRadius", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopLeftRadius;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderTopRightRadius
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopRightRadius;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopRightRadius
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopRightRadius == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopRightRadius = new(this, "UnityEngine.UIElements.IResolvedStyle.borderTopRightRadius", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopRightRadius;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.borderTopWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopWidth
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopWidth == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopWidth = new(this, "UnityEngine.UIElements.IResolvedStyle.borderTopWidth", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__borderTopWidth;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.bottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__bottom;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__bottom
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__bottom == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__bottom = new(this, "UnityEngine.UIElements.IResolvedStyle.bottom", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__bottom;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.color
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__color;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPUnityEngine__2__UIElements__2__IResolvedStyle__2__color
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__color == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__color = new(this, "UnityEngine.UIElements.IResolvedStyle.color", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__color;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.DisplayStyle UnityEngine.UIElements.IResolvedStyle.display
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDisplayStyle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__display;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RDisplayStyle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__display
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__display == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__display = new(this, "UnityEngine.UIElements.IResolvedStyle.display", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__display;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.flexBasis
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexBasis;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPUnityEngine__2__UIElements__2__IResolvedStyle__2__flexBasis
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexBasis == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexBasis = new(this, "UnityEngine.UIElements.IResolvedStyle.flexBasis", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexBasis;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FlexDirection UnityEngine.UIElements.IResolvedStyle.flexDirection
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFlexDirection r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexDirection;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFlexDirection RPUnityEngine__2__UIElements__2__IResolvedStyle__2__flexDirection
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexDirection == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexDirection = new(this, "UnityEngine.UIElements.IResolvedStyle.flexDirection", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexDirection;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.flexGrow
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexGrow;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__flexGrow
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexGrow == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexGrow = new(this, "UnityEngine.UIElements.IResolvedStyle.flexGrow", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexGrow;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.flexShrink
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexShrink;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__flexShrink
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexShrink == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexShrink = new(this, "UnityEngine.UIElements.IResolvedStyle.flexShrink", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexShrink;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Wrap UnityEngine.UIElements.IResolvedStyle.flexWrap
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RWrap r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexWrap;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RWrap RPUnityEngine__2__UIElements__2__IResolvedStyle__2__flexWrap
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexWrap == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexWrap = new(this, "UnityEngine.UIElements.IResolvedStyle.flexWrap", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__flexWrap;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.fontSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__fontSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__fontSize
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__fontSize == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__fontSize = new(this, "UnityEngine.UIElements.IResolvedStyle.fontSize", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__fontSize;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.height
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__height;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__height
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__height == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__height = new(this, "UnityEngine.UIElements.IResolvedStyle.height", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__height;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Justify UnityEngine.UIElements.IResolvedStyle.justifyContent
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RJustify r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__justifyContent;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RJustify RPUnityEngine__2__UIElements__2__IResolvedStyle__2__justifyContent
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__justifyContent == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__justifyContent = new(this, "UnityEngine.UIElements.IResolvedStyle.justifyContent", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__justifyContent;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.left
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__left;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__left
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__left == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__left = new(this, "UnityEngine.UIElements.IResolvedStyle.left", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__left;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.letterSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__letterSpacing;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__letterSpacing
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__letterSpacing == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__letterSpacing = new(this, "UnityEngine.UIElements.IResolvedStyle.letterSpacing", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__letterSpacing;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.marginBottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginBottom;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__marginBottom
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginBottom == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginBottom = new(this, "UnityEngine.UIElements.IResolvedStyle.marginBottom", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginBottom;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.marginLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginLeft;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__marginLeft
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginLeft == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginLeft = new(this, "UnityEngine.UIElements.IResolvedStyle.marginLeft", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginLeft;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.marginRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginRight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__marginRight
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginRight == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginRight = new(this, "UnityEngine.UIElements.IResolvedStyle.marginRight", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginRight;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.marginTop
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginTop;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__marginTop
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginTop == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginTop = new(this, "UnityEngine.UIElements.IResolvedStyle.marginTop", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__marginTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.maxHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__maxHeight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPUnityEngine__2__UIElements__2__IResolvedStyle__2__maxHeight
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__maxHeight == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__maxHeight = new(this, "UnityEngine.UIElements.IResolvedStyle.maxHeight", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__maxHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.maxWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__maxWidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPUnityEngine__2__UIElements__2__IResolvedStyle__2__maxWidth
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__maxWidth == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__maxWidth = new(this, "UnityEngine.UIElements.IResolvedStyle.maxWidth", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__maxWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.minHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__minHeight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPUnityEngine__2__UIElements__2__IResolvedStyle__2__minHeight
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__minHeight == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__minHeight = new(this, "UnityEngine.UIElements.IResolvedStyle.minHeight", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__minHeight;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.StyleFloat UnityEngine.UIElements.IResolvedStyle.minWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__minWidth;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleFloat RPUnityEngine__2__UIElements__2__IResolvedStyle__2__minWidth
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__minWidth == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__minWidth = new(this, "UnityEngine.UIElements.IResolvedStyle.minWidth", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__minWidth;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.opacity
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__opacity;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__opacity
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__opacity == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__opacity = new(this, "UnityEngine.UIElements.IResolvedStyle.opacity", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__opacity;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.paddingBottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingBottom;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingBottom
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingBottom == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingBottom = new(this, "UnityEngine.UIElements.IResolvedStyle.paddingBottom", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingBottom;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.paddingLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingLeft;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingLeft
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingLeft == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingLeft = new(this, "UnityEngine.UIElements.IResolvedStyle.paddingLeft", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingLeft;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.paddingRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingRight;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingRight
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingRight == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingRight = new(this, "UnityEngine.UIElements.IResolvedStyle.paddingRight", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingRight;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.paddingTop
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingTop;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingTop
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingTop == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingTop = new(this, "UnityEngine.UIElements.IResolvedStyle.paddingTop", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__paddingTop;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Position UnityEngine.UIElements.IResolvedStyle.position
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPosition r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__position;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPosition RPUnityEngine__2__UIElements__2__IResolvedStyle__2__position
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__position == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__position = new(this, "UnityEngine.UIElements.IResolvedStyle.position", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__position;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.right
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__right;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__right
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__right == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__right = new(this, "UnityEngine.UIElements.IResolvedStyle.right", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__right;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Rotate UnityEngine.UIElements.IResolvedStyle.rotate
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRotate r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__rotate;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RRotate RPUnityEngine__2__UIElements__2__IResolvedStyle__2__rotate
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__rotate == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__rotate = new(this, "UnityEngine.UIElements.IResolvedStyle.rotate", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__rotate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Scale UnityEngine.UIElements.IResolvedStyle.scale
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScale r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__scale;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RScale RPUnityEngine__2__UIElements__2__IResolvedStyle__2__scale
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__scale == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__scale = new(this, "UnityEngine.UIElements.IResolvedStyle.scale", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__scale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextOverflow UnityEngine.UIElements.IResolvedStyle.textOverflow
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflow r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__textOverflow;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflow RPUnityEngine__2__UIElements__2__IResolvedStyle__2__textOverflow
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__textOverflow == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__textOverflow = new(this, "UnityEngine.UIElements.IResolvedStyle.textOverflow", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__textOverflow;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.top
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__top;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__top
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__top == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__top = new(this, "UnityEngine.UIElements.IResolvedStyle.top", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__top;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 UnityEngine.UIElements.IResolvedStyle.transformOrigin
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transformOrigin;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPUnityEngine__2__UIElements__2__IResolvedStyle__2__transformOrigin
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transformOrigin == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transformOrigin = new(this, "UnityEngine.UIElements.IResolvedStyle.transformOrigin", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transformOrigin;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.TimeValue] UnityEngine.UIElements.IResolvedStyle.transitionDelay
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionDelay;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> RPUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionDelay
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionDelay == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionDelay = new(this, "UnityEngine.UIElements.IResolvedStyle.transitionDelay", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionDelay;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.TimeValue] UnityEngine.UIElements.IResolvedStyle.transitionDuration
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionDuration;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTimeValue> RPUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionDuration
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionDuration == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionDuration = new(this, "UnityEngine.UIElements.IResolvedStyle.transitionDuration", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionDuration;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.StylePropertyName] UnityEngine.UIElements.IResolvedStyle.transitionProperty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStylePropertyName> r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionProperty;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStylePropertyName> RPUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionProperty
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionProperty == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionProperty = new(this, "UnityEngine.UIElements.IResolvedStyle.transitionProperty", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionProperty;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.UIElements.EasingFunction] UnityEngine.UIElements.IResolvedStyle.transitionTimingFunction
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REasingFunction> r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionTimingFunction;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.REasingFunction> RPUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionTimingFunction
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionTimingFunction == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionTimingFunction = new(this, "UnityEngine.UIElements.IResolvedStyle.transitionTimingFunction", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__transitionTimingFunction;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 UnityEngine.UIElements.IResolvedStyle.translate
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__translate;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPUnityEngine__2__UIElements__2__IResolvedStyle__2__translate
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__translate == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__translate = new(this, "UnityEngine.UIElements.IResolvedStyle.translate", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__translate;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.unityBackgroundImageTintColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityBackgroundImageTintColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unityBackgroundImageTintColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityBackgroundImageTintColor == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityBackgroundImageTintColor = new(this, "UnityEngine.UIElements.IResolvedStyle.unityBackgroundImageTintColor", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityBackgroundImageTintColor;
			}
		}

		/// <summary>
		/// UnityEngine.Font UnityEngine.UIElements.IResolvedStyle.unityFont
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RFont r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFont;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RFont RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFont
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFont == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFont = new(this, "UnityEngine.UIElements.IResolvedStyle.unityFont", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFont;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.FontDefinition UnityEngine.UIElements.IResolvedStyle.unityFontDefinition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFontDefinition r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFontDefinition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RFontDefinition RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFontDefinition
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFontDefinition == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFontDefinition = new(this, "UnityEngine.UIElements.IResolvedStyle.unityFontDefinition", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFontDefinition;
			}
		}

		/// <summary>
		/// UnityEngine.FontStyle UnityEngine.UIElements.IResolvedStyle.unityFontStyleAndWeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RFontStyle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFontStyleAndWeight;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RFontStyle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFontStyleAndWeight
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFontStyleAndWeight == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFontStyleAndWeight = new(this, "UnityEngine.UIElements.IResolvedStyle.unityFontStyleAndWeight", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityFontStyleAndWeight;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.unityParagraphSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityParagraphSpacing;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unityParagraphSpacing
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityParagraphSpacing == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityParagraphSpacing = new(this, "UnityEngine.UIElements.IResolvedStyle.unityParagraphSpacing", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityParagraphSpacing;
			}
		}

		/// <summary>
		/// Int32 UnityEngine.UIElements.IResolvedStyle.unitySliceBottom
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceBottom;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceBottom
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceBottom == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceBottom = new(this, "UnityEngine.UIElements.IResolvedStyle.unitySliceBottom", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceBottom;
			}
		}

		/// <summary>
		/// Int32 UnityEngine.UIElements.IResolvedStyle.unitySliceLeft
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceLeft;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceLeft
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceLeft == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceLeft = new(this, "UnityEngine.UIElements.IResolvedStyle.unitySliceLeft", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceLeft;
			}
		}

		/// <summary>
		/// Int32 UnityEngine.UIElements.IResolvedStyle.unitySliceRight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceRight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceRight
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceRight == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceRight = new(this, "UnityEngine.UIElements.IResolvedStyle.unitySliceRight", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceRight;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.unitySliceScale
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceScale;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceScale
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceScale == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceScale = new(this, "UnityEngine.UIElements.IResolvedStyle.unitySliceScale", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceScale;
			}
		}

		/// <summary>
		/// Int32 UnityEngine.UIElements.IResolvedStyle.unitySliceTop
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceTop;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceTop
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceTop == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceTop = new(this, "UnityEngine.UIElements.IResolvedStyle.unitySliceTop", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unitySliceTop;
			}
		}

		/// <summary>
		/// UnityEngine.TextAnchor UnityEngine.UIElements.IResolvedStyle.unityTextAlign
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextAnchor r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextAlign;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextAnchor RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextAlign
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextAlign == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextAlign = new(this, "UnityEngine.UIElements.IResolvedStyle.unityTextAlign", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextAlign;
			}
		}

		/// <summary>
		/// UnityEngine.Color UnityEngine.UIElements.IResolvedStyle.unityTextOutlineColor
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOutlineColor;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOutlineColor
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOutlineColor == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOutlineColor = new(this, "UnityEngine.UIElements.IResolvedStyle.unityTextOutlineColor", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOutlineColor;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.unityTextOutlineWidth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOutlineWidth;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOutlineWidth
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOutlineWidth == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOutlineWidth = new(this, "UnityEngine.UIElements.IResolvedStyle.unityTextOutlineWidth", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOutlineWidth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextOverflowPosition UnityEngine.UIElements.IResolvedStyle.unityTextOverflowPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflowPosition r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOverflowPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextOverflowPosition RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOverflowPosition
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOverflowPosition == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOverflowPosition = new(this, "UnityEngine.UIElements.IResolvedStyle.unityTextOverflowPosition", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityTextOverflowPosition;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Visibility UnityEngine.UIElements.IResolvedStyle.visibility
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisibility r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__visibility;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisibility RPUnityEngine__2__UIElements__2__IResolvedStyle__2__visibility
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__visibility == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__visibility = new(this, "UnityEngine.UIElements.IResolvedStyle.visibility", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__visibility;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.WhiteSpace UnityEngine.UIElements.IResolvedStyle.whiteSpace
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RWhiteSpace r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__whiteSpace;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RWhiteSpace RPUnityEngine__2__UIElements__2__IResolvedStyle__2__whiteSpace
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__whiteSpace == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__whiteSpace = new(this, "UnityEngine.UIElements.IResolvedStyle.whiteSpace", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__whiteSpace;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.width
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__width;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__width
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__width == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__width = new(this, "UnityEngine.UIElements.IResolvedStyle.width", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__width;
			}
		}

		/// <summary>
		/// Single UnityEngine.UIElements.IResolvedStyle.wordSpacing
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__wordSpacing;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPUnityEngine__2__UIElements__2__IResolvedStyle__2__wordSpacing
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__wordSpacing == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__wordSpacing = new(this, "UnityEngine.UIElements.IResolvedStyle.wordSpacing", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__wordSpacing;
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
		/// Int32 UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__runningAnimationCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__runningAnimationCount
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__runningAnimationCount == null)
				{
					r_PUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__runningAnimationCount = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__runningAnimationCount;
			}
		}

		/// <summary>
		/// Int32 UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__completedAnimationCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__completedAnimationCount
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__completedAnimationCount == null)
				{
					r_PUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__completedAnimationCount = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__completedAnimationCount;
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
		/// UnityEngine.Vector3 UnityEngine.UIElements.ITransform.position
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_PUnityEngine__2__UIElements__2__ITransform__2__position;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPUnityEngine__2__UIElements__2__ITransform__2__position
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITransform__2__position == null)
				{
					r_PUnityEngine__2__UIElements__2__ITransform__2__position = new(this, "UnityEngine.UIElements.ITransform.position", -1);
				}
				return r_PUnityEngine__2__UIElements__2__ITransform__2__position;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion UnityEngine.UIElements.ITransform.rotation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RQuaternion r_PUnityEngine__2__UIElements__2__ITransform__2__rotation;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RQuaternion RPUnityEngine__2__UIElements__2__ITransform__2__rotation
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITransform__2__rotation == null)
				{
					r_PUnityEngine__2__UIElements__2__ITransform__2__rotation = new(this, "UnityEngine.UIElements.ITransform.rotation", -1);
				}
				return r_PUnityEngine__2__UIElements__2__ITransform__2__rotation;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 UnityEngine.UIElements.ITransform.scale
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_PUnityEngine__2__UIElements__2__ITransform__2__scale;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPUnityEngine__2__UIElements__2__ITransform__2__scale
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITransform__2__scale == null)
				{
					r_PUnityEngine__2__UIElements__2__ITransform__2__scale = new(this, "UnityEngine.UIElements.ITransform.scale", -1);
				}
				return r_PUnityEngine__2__UIElements__2__ITransform__2__scale;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 UnityEngine.UIElements.ITransform.matrix
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 r_PUnityEngine__2__UIElements__2__ITransform__2__matrix;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMatrix4x4 RPUnityEngine__2__UIElements__2__ITransform__2__matrix
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__ITransform__2__matrix == null)
				{
					r_PUnityEngine__2__UIElements__2__ITransform__2__matrix = new(this, "UnityEngine.UIElements.ITransform.matrix", -1);
				}
				return r_PUnityEngine__2__UIElements__2__ITransform__2__matrix;
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
		/// UnityEngine.UIElements.StyleEnum`1[UnityEngine.ScaleMode] UnityEngine.UIElements.IResolvedStyle.unityBackgroundScaleMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RScaleMode> r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityBackgroundScaleMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleEnum<Hvak.Editor.Refleaction.RUnityEngine.RScaleMode> RPUnityEngine__2__UIElements__2__IResolvedStyle__2__unityBackgroundScaleMode
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityBackgroundScaleMode == null)
				{
					r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityBackgroundScaleMode = new(this, "UnityEngine.UIElements.IResolvedStyle.unityBackgroundScaleMode", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IResolvedStyle__2__unityBackgroundScaleMode;
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
		/// UnityEngine.Rect boundingBoxInParentSpace
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRect r_PboundingBoxInParentSpace;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRect RPboundingBoxInParentSpace
		{
			get
			{
				if(r_PboundingBoxInParentSpace == null)
				{
					r_PboundingBoxInParentSpace = new(this, "boundingBoxInParentSpace", -1);
				}
				return r_PboundingBoxInParentSpace;
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
		/// Boolean isParentEnabledInHierarchy
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisParentEnabledInHierarchy;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisParentEnabledInHierarchy
		{
			get
			{
				if(r_PisParentEnabledInHierarchy == null)
				{
					r_PisParentEnabledInHierarchy = new(this, "isParentEnabledInHierarchy", -1);
				}
				return r_PisParentEnabledInHierarchy;
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
		/// UnityEngine.UIElements.Experimental.ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.animation
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RITransitionAnimations r_PUnityEngine__2__UIElements__2__IExperimentalFeatures__2__animation;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RITransitionAnimations RPUnityEngine__2__UIElements__2__IExperimentalFeatures__2__animation
		{
			get
			{
				if(r_PUnityEngine__2__UIElements__2__IExperimentalFeatures__2__animation == null)
				{
					r_PUnityEngine__2__UIElements__2__IExperimentalFeatures__2__animation = new(this, "UnityEngine.UIElements.IExperimentalFeatures.animation", -1);
				}
				return r_PUnityEngine__2__UIElements__2__IExperimentalFeatures__2__animation;
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
		/// UnityEngine.Vector3 positionWithLayout
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_PpositionWithLayout;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPpositionWithLayout
		{
			get
			{
				if(r_PpositionWithLayout == null)
				{
					r_PpositionWithLayout = new(this, "positionWithLayout", -1);
				}
				return r_PpositionWithLayout;
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
		/// TypeData typeData
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RTypeData r_PtypeData;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RTypeData RPtypeData
		{
			get
			{
				if(r_PtypeData == null)
				{
					r_PtypeData = new(this, "typeData", -1);
				}
				return r_PtypeData;
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
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Single_Single_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(System.Single), typeof(System.Single), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Length_Length_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Length), typeof(UnityEngine.UIElements.Length), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Color_Color_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.Color), typeof(UnityEngine.Color), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__StartEnum_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.StartEnum", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Background_Background_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Background), typeof(UnityEngine.UIElements.Background), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.FontDefinition), typeof(UnityEngine.UIElements.FontDefinition), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Font_Font_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.Font), typeof(UnityEngine.Font), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.TextShadow), typeof(UnityEngine.UIElements.TextShadow), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Scale_Scale_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Scale), typeof(UnityEngine.UIElements.Scale), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Translate_Translate_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Translate), typeof(UnityEngine.UIElements.Translate), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.Rotate), typeof(UnityEngine.UIElements.Rotate), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.TransformOrigin), typeof(UnityEngine.UIElements.TransformOrigin), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.BackgroundPosition), typeof(UnityEngine.UIElements.BackgroundPosition), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.BackgroundRepeat), typeof(UnityEngine.UIElements.BackgroundRepeat), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_d_Single_Single_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.Start", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId"), typeof(UnityEngine.UIElements.BackgroundSize), typeof(UnityEngine.UIElements.BackgroundSize), typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(System.Single), typeof(System.Single)));
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
					r_MUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__GetAllAnimations_List_d_StylePropertyId_p_ = new(this, "UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType( ReflectionUtils.GetType("UnityEngine.UIElements.StyleSheets.StylePropertyId")));
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
					r_MComputeAAAlignedBound_Rect_Matrix4x4 = new(Type, "ComputeAAAlignedBound", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Matrix4x4));
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
					r_MIsPartOfCapturedChain_VisualElement_In_IEventHandler = new(Type, "IsPartOfCapturedChain", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.IEventHandler).MakeByRefType());
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
					r_MCheckUserKeyArgument_PropertyName = new(Type, "CheckUserKeyArgument", 0, typeof(UnityEngine.PropertyName));
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
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Single_Single_Int32_Action_d_VisualElement_Single_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(System.Single), typeof(System.Single), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(System.Single)));
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
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Rect_Rect_Int32_Action_d_VisualElement_Rect_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.Rect), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Rect)));
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
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Color_Color_Int32_Action_d_VisualElement_Color_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(UnityEngine.Color), typeof(UnityEngine.Color), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Color)));
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
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Vector3_Vector3_Int32_Action_d_VisualElement_Vector3_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector3)));
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
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Vector2_Vector2_Int32_Action_d_VisualElement_Vector2_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector2)));
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
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Quaternion_Quaternion_Int32_Action_d_VisualElement_Quaternion_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0, typeof(UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Quaternion)));
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
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Single_p__Single_Int32_Action_d_VisualElement_Single_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0,  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(System.Single)), typeof(System.Single), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(System.Single)));
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
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Rect_p__Rect_Int32_Action_d_VisualElement_Rect_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0,  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Rect)), typeof(UnityEngine.Rect), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Rect)));
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
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Color_p__Color_Int32_Action_d_VisualElement_Color_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0,  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Color)), typeof(UnityEngine.Color), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Color)));
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
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Vector3_p__Vector3_Int32_Action_d_VisualElement_Vector3_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0,  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector3)), typeof(UnityEngine.Vector3), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector3)));
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
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Vector2_p__Vector2_Int32_Action_d_VisualElement_Vector2_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0,  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector2)), typeof(UnityEngine.Vector2), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Vector2)));
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
					r_MUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Quaternion_p__Quaternion_Int32_Action_d_VisualElement_Quaternion_p_ = new(this, "UnityEngine.UIElements.Experimental.ITransitionAnimations.Start", 0,  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Quaternion)), typeof(UnityEngine.Quaternion), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Quaternion)));
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
					r_MStartAnimation_GT_ValueAnimation_d_T_p__Func_d_VisualElement_T_p__T_Int32_Action_d_VisualElement_T_p_ = new(Type, "StartAnimation", 1,  ReflectionUtils.GetType("UnityEngine.UIElements.Experimental.ValueAnimation`1").MakeGenericType(Type.MakeGenericMethodParameter(0)),  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), Type.MakeGenericMethodParameter(0)), Type.MakeGenericMethodParameter(0), typeof(System.Int32),  ReflectionUtils.GetType("System.Action`2").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), Type.MakeGenericMethodParameter(0)));
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
					r_MAssignStyleValues_VisualElement_StyleValues = new(Type, "AssignStyleValues", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.Experimental.StyleValues));
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
					r_MStart_Func_d_VisualElement_StyleValues_p__StyleValues_Int32 = new(this, "Start", 0,  ReflectionUtils.GetType("System.Func`2").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.UIElements.Experimental.StyleValues)), typeof(UnityEngine.UIElements.Experimental.StyleValues), typeof(System.Int32));
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
		/// Void GatherAllChildren(System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_MGatherAllChildren_List_d_VisualElement_p_;
		public virtual RMethod RMGatherAllChildren_List_d_VisualElement_p_
		{
			get
			{
				if(r_MGatherAllChildren_List_d_VisualElement_p_ == null)
				{
					r_MGatherAllChildren_List_d_VisualElement_p_ = new(this, "GatherAllChildren", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
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
		/// Single Min(Single, Single, Single, Single)
		/// </summary>
		protected static RMethod r_MMin_Single_Single_Single_Single;
		public static RMethod RMMin_Single_Single_Single_Single
		{
			get
			{
				if(r_MMin_Single_Single_Single_Single == null)
				{
					r_MMin_Single_Single_Single_Single = new(Type, "Min", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
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
					r_MMax_Single_Single_Single_Single = new(Type, "Max", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single));
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
					r_MCalculateConservativeRect_Ref_Matrix4x4_Rect = new(Type, "CalculateConservativeRect", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Rect));
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
					r_MTransformAlignedRect_Ref_Matrix4x4_Ref_Rect = new(Type, "TransformAlignedRect", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Rect).MakeByRefType());
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
					r_MOrderMinMaxRect_Ref_Rect = new(Type, "OrderMinMaxRect", 0, typeof(UnityEngine.Rect).MakeByRefType());
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
					r_MMultiplyMatrix44Point2_Ref_Matrix4x4_Vector2 = new(Type, "MultiplyMatrix44Point2", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Vector2));
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
					r_MMultiplyVector2_Ref_Matrix4x4_Vector2 = new(Type, "MultiplyVector2", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Vector2));
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
					r_MMultiplyMatrix44Rect2_Ref_Matrix4x4_Rect = new(Type, "MultiplyMatrix44Rect2", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Rect));
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
					r_MMultiplyMatrix34_Ref_Matrix4x4_Ref_Matrix4x4_Out_Matrix4x4 = new(Type, "MultiplyMatrix34", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Matrix4x4).MakeByRefType());
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
					r_MTranslateMatrix34_Ref_Matrix4x4_Vector3_Out_Matrix4x4 = new(Type, "TranslateMatrix34", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Vector3), typeof(UnityEngine.Matrix4x4).MakeByRefType());
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
					r_MTranslateMatrix34InPlace_Ref_Matrix4x4_Vector3 = new(Type, "TranslateMatrix34InPlace", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType(), typeof(UnityEngine.Vector3));
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
					r_MUnityEngine__2__UIElements__2__IVisualElementScheduler__2__Execute_Action_d_TimerState_p_ = new(this, "UnityEngine.UIElements.IVisualElementScheduler.Execute", 0,  ReflectionUtils.GetType("System.Action`1").MakeGenericType(typeof(UnityEngine.UIElements.TimerState)));
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
					r_MGetOrCreateTypeData_Type = new(Type, "GetOrCreateTypeData", 0, typeof(System.Type));
				}
				return r_MGetOrCreateTypeData_Type;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.YogaSize <AssignMeasureFunction>b__424_0(UnityEngine.Yoga.YogaNode, Single, UnityEngine.Yoga.YogaMeasureMode, Single, UnityEngine.Yoga.YogaMeasureMode)
		/// </summary>
		protected RMethod r_M__0__AssignMeasureFunction__1__b__424_0_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode;
		public virtual RMethod RM__0__AssignMeasureFunction__1__b__424_0_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode
		{
			get
			{
				if(r_M__0__AssignMeasureFunction__1__b__424_0_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode == null)
				{
					r_M__0__AssignMeasureFunction__1__b__424_0_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode = new(this, "<AssignMeasureFunction>b__424_0", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaNode"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Yoga.YogaMeasureMode"), typeof(System.Single),  ReflectionUtils.GetType("UnityEngine.Yoga.YogaMeasureMode"));
				}
				return r_M__0__AssignMeasureFunction__1__b__424_0_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode;
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


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIStylePropertyAnimationSystem GetStylePropertyAnimationSystem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetStylePropertyAnimationSystem.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIStylePropertyAnimationSystem>(___result);
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, System.Single @from, System.Single @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Single_Single_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, System.Int32 @from, System.Int32 @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.Length @from, UnityEngine.UIElements.Length @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Length_Length_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.Color @from, UnityEngine.Color @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Color_Color_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__StartEnum(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, System.Int32 @from, System.Int32 @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__StartEnum_StylePropertyId_Int32_Int32_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.Background @from, UnityEngine.UIElements.Background @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Background_Background_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.FontDefinition @from, UnityEngine.UIElements.FontDefinition @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_FontDefinition_FontDefinition_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.Font @from, UnityEngine.Font @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Font_Font_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.TextShadow @from, UnityEngine.UIElements.TextShadow @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_TextShadow_TextShadow_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.Scale @from, UnityEngine.UIElements.Scale @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Scale_Scale_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.Translate @from, UnityEngine.UIElements.Translate @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Translate_Translate_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.Rotate @from, UnityEngine.UIElements.Rotate @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_Rotate_Rotate_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.TransformOrigin @from, UnityEngine.UIElements.TransformOrigin @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_TransformOrigin_TransformOrigin_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.BackgroundPosition @from, UnityEngine.UIElements.BackgroundPosition @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundPosition_BackgroundPosition_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.BackgroundRepeat @from, UnityEngine.UIElements.BackgroundRepeat @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundRepeat_BackgroundRepeat_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, UnityEngine.UIElements.BackgroundSize @from, UnityEngine.UIElements.BackgroundSize @to, System.Int32 @durationMs, System.Int32 @delayMs, System.Func<System.Single, System.Single> @easingCurve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @from, @to, @durationMs, @delayMs, @easingCurve};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__Start_StylePropertyId_BackgroundSize_BackgroundSize_Int32_Int32_Func_d_Single_Single_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__CancelAnimation(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
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


        public virtual System.Boolean UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__HasRunningAnimation(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__HasRunningAnimation_StylePropertyId.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__UpdateAnimation(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__UpdateAnimation_StylePropertyId.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnityEngine__2__UIElements__2__IStylePropertyAnimations__2__GetAllAnimations(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId> @outPropertyIds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outPropertyIds.Value};
            var ___result = RMUnityEngine__2__UIElements__2__IStylePropertyAnimations__2__GetAllAnimations_List_d_StylePropertyId_p_.Invoke(___genericsType, ___parameters);

            
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


        public virtual Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RSystem.RSingle> GetParentSizeForLengthConversion(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RStyleSheets.RStylePropertyId @id, System.Int32 @subPropertyIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @subPropertyIndex};
            var ___result = RMGetParentSizeForLengthConversion_StylePropertyId_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RSystem.RNullable<Hvak.Editor.Refleaction.RSystem.RSingle>>(___result);
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

            return ReflectionUtils.Convert<UnityEngine.Rect>(___result);
        }


        public virtual UnityEngine.Rect SubstractBorderPadding(UnityEngine.Rect @worldRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@worldRect};
            var ___result = RMSubstractBorderPadding_Rect.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rect>(___result);
        }


        public static UnityEngine.Rect ComputeAAAlignedBound(UnityEngine.Rect @position, UnityEngine.Matrix4x4 @mat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @mat};
            var ___result = RMComputeAAAlignedBound_Rect_Matrix4x4.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rect>(___result);
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

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<UnityEngine.Rect>(___result);
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


        public virtual void SetPanel(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel @p)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p.Value};
            var ___result = RMSetPanel_BaseVisualElementPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WillChangePanel(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel @destinationPanel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destinationPanel.Value};
            var ___result = RMWillChangePanel_BaseVisualElementPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HasChangedPanel(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel @prevPanel)
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


        public virtual System.Boolean SetEnabledFromHierarchyPrivate(System.Boolean @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RMSetEnabledFromHierarchyPrivate_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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


        public virtual void FinalizeLayout()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalizeLayout.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Boolean TryGetPropertyInternal(UnityEngine.PropertyName @key, out System.Object @value)
        {
			@value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key, @value};
            var ___result = RMTryGetPropertyInternal_PropertyName_Out_Object.Invoke(___genericsType, ___parameters);
			@value = ReflectionUtils.Convert<System.Object>(___parameters[1]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<UnityEngine.Material>(___result);
        }


        public virtual void ApplyPlayerRenderingToEditorElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMApplyPlayerRenderingToEditorElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAnimationSystem GetAnimationSystem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetAnimationSystem.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElementAnimationSystem>(___result);
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

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.ValueAnimation<System.Single>>(___result);
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(UnityEngine.Rect @from, UnityEngine.Rect @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Rect> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Rect_Rect_Int32_Action_d_VisualElement_Rect_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect>>(___result);
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Color> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(UnityEngine.Color @from, UnityEngine.Color @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Color> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Color_Color_Int32_Action_d_VisualElement_Color_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Color>>(___result);
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(UnityEngine.Vector3 @from, UnityEngine.Vector3 @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Vector3> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Vector3_Vector3_Int32_Action_d_VisualElement_Vector3_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3>>(___result);
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(UnityEngine.Vector2 @from, UnityEngine.Vector2 @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Vector2> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Vector2_Vector2_Int32_Action_d_VisualElement_Vector2_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2>>(___result);
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(UnityEngine.Quaternion @from, UnityEngine.Quaternion @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Quaternion> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Quaternion_Quaternion_Int32_Action_d_VisualElement_Quaternion_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion>>(___result);
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(UnityEngine.UIElements.Experimental.StyleValues @from, UnityEngine.UIElements.Experimental.StyleValues @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @durationMs};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_StyleValues_StyleValues_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues>>(___result);
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<System.Single> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(System.Func<UnityEngine.UIElements.VisualElement, System.Single> @fromValueGetter, System.Single @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, System.Single> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Single_p__Single_Int32_Action_d_VisualElement_Single_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.ValueAnimation<System.Single>>(___result);
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.Rect> @fromValueGetter, UnityEngine.Rect @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Rect> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Rect_p__Rect_Int32_Action_d_VisualElement_Rect_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect>>(___result);
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Color> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.Color> @fromValueGetter, UnityEngine.Color @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Color> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Color_p__Color_Int32_Action_d_VisualElement_Color_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Color>>(___result);
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.Vector3> @fromValueGetter, UnityEngine.Vector3 @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Vector3> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Vector3_p__Vector3_Int32_Action_d_VisualElement_Vector3_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3>>(___result);
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.Vector2> @fromValueGetter, UnityEngine.Vector2 @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Vector2> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Vector2_p__Vector2_Int32_Action_d_VisualElement_Vector2_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2>>(___result);
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.Quaternion> @fromValueGetter, UnityEngine.Quaternion @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, UnityEngine.Quaternion> @onValueChanged)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_Func_d_VisualElement_Quaternion_p__Quaternion_Int32_Action_d_VisualElement_Quaternion_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion>>(___result);
        }


        public static UnityEngine.UIElements.Experimental.ValueAnimation<T> StartAnimation<T>(UnityEngine.UIElements.Experimental.ValueAnimation<T> @anim, System.Func<UnityEngine.UIElements.VisualElement, T> @fromValueGetter, T @to, System.Int32 @durationMs, System.Action<UnityEngine.UIElements.VisualElement, T> @onValueChanged)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@anim, @fromValueGetter, @to, @durationMs, @onValueChanged};
            var ___result = RMStartAnimation_GT_ValueAnimation_d_T_p__Func_d_VisualElement_T_p__T_Int32_Action_d_VisualElement_T_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.ValueAnimation<T>>(___result);
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

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.StyleValues>(___result);
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start(UnityEngine.UIElements.Experimental.StyleValues @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Start_StyleValues_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues>>(___result);
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> Start(System.Func<UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.Experimental.StyleValues> @fromValueGetter, UnityEngine.UIElements.Experimental.StyleValues @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fromValueGetter, @to, @durationMs};
            var ___result = RMStart_Func_d_VisualElement_StyleValues_p__StyleValues_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues>>(___result);
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Layout(UnityEngine.Rect @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Layout_Rect_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Rect>>(___result);
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__TopLeft(UnityEngine.Vector2 @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__TopLeft_Vector2_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2>>(___result);
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Size(UnityEngine.Vector2 @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Size_Vector2_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector2>>(___result);
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<System.Single> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Scale(System.Single @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Scale_Single_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.ValueAnimation<System.Single>>(___result);
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Position(UnityEngine.Vector3 @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Position_Vector3_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Vector3>>(___result);
        }


        public virtual UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion> UnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Rotation(UnityEngine.Quaternion @to, System.Int32 @durationMs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@to, @durationMs};
            var ___result = RMUnityEngine__2__UIElements__2__Experimental__2__ITransitionAnimations__2__Rotation_Quaternion_Int32.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.Quaternion>>(___result);
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
			@nextParent = ReflectionUtils.Convert<UnityEngine.UIElements.VisualElement>(___parameters[0]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void UpdateCallbackParentCategories()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdateCallbackParentCategories.Invoke(___genericsType, ___parameters);

            
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


        public static System.Single Min(System.Single @a, System.Single @b, System.Single @c, System.Single @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @c, @d};
            var ___result = RMMin_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public static System.Single Max(System.Single @a, System.Single @b, System.Single @c, System.Single @d)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b, @c, @d};
            var ___result = RMMax_Single_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Single>(___result);
        }


        public virtual void TransformAlignedRectToParentSpace(ref UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect};
            var ___result = RMTransformAlignedRectToParentSpace_Ref_Rect.Invoke(___genericsType, ___parameters);
			@rect = ReflectionUtils.Convert<UnityEngine.Rect>(___parameters[0]);

            
        }


        public static UnityEngine.Rect CalculateConservativeRect(ref UnityEngine.Matrix4x4 @matrix, UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @rect};
            var ___result = RMCalculateConservativeRect_Ref_Matrix4x4_Rect.Invoke(___genericsType, ___parameters);
			@matrix = ReflectionUtils.Convert<UnityEngine.Matrix4x4>(___parameters[0]);

            return ReflectionUtils.Convert<UnityEngine.Rect>(___result);
        }


        public static void TransformAlignedRect(ref UnityEngine.Matrix4x4 @matrix, ref UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrix, @rect};
            var ___result = RMTransformAlignedRect_Ref_Matrix4x4_Ref_Rect.Invoke(___genericsType, ___parameters);
			@matrix = ReflectionUtils.Convert<UnityEngine.Matrix4x4>(___parameters[0]);
			@rect = ReflectionUtils.Convert<UnityEngine.Rect>(___parameters[1]);

            
        }


        public static void OrderMinMaxRect(ref UnityEngine.Rect @rect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect};
            var ___result = RMOrderMinMaxRect_Ref_Rect.Invoke(___genericsType, ___parameters);
			@rect = ReflectionUtils.Convert<UnityEngine.Rect>(___parameters[0]);

            
        }


        public static UnityEngine.Vector2 MultiplyMatrix44Point2(ref UnityEngine.Matrix4x4 @lhs, UnityEngine.Vector2 @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @point};
            var ___result = RMMultiplyMatrix44Point2_Ref_Matrix4x4_Vector2.Invoke(___genericsType, ___parameters);
			@lhs = ReflectionUtils.Convert<UnityEngine.Matrix4x4>(___parameters[0]);

            return ReflectionUtils.Convert<UnityEngine.Vector2>(___result);
        }


        public static UnityEngine.Vector2 MultiplyVector2(ref UnityEngine.Matrix4x4 @lhs, UnityEngine.Vector2 @vector)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @vector};
            var ___result = RMMultiplyVector2_Ref_Matrix4x4_Vector2.Invoke(___genericsType, ___parameters);
			@lhs = ReflectionUtils.Convert<UnityEngine.Matrix4x4>(___parameters[0]);

            return ReflectionUtils.Convert<UnityEngine.Vector2>(___result);
        }


        public static UnityEngine.Rect MultiplyMatrix44Rect2(ref UnityEngine.Matrix4x4 @lhs, UnityEngine.Rect @r)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @r};
            var ___result = RMMultiplyMatrix44Rect2_Ref_Matrix4x4_Rect.Invoke(___genericsType, ___parameters);
			@lhs = ReflectionUtils.Convert<UnityEngine.Matrix4x4>(___parameters[0]);

            return ReflectionUtils.Convert<UnityEngine.Rect>(___result);
        }


        public static void MultiplyMatrix34(ref UnityEngine.Matrix4x4 @lhs, ref UnityEngine.Matrix4x4 @rhs, out UnityEngine.Matrix4x4 @res)
        {
			@res = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs, @res};
            var ___result = RMMultiplyMatrix34_Ref_Matrix4x4_Ref_Matrix4x4_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@lhs = ReflectionUtils.Convert<UnityEngine.Matrix4x4>(___parameters[0]);
			@rhs = ReflectionUtils.Convert<UnityEngine.Matrix4x4>(___parameters[1]);
			@res = ReflectionUtils.Convert<UnityEngine.Matrix4x4>(___parameters[2]);

            
        }


        public static void TranslateMatrix34(ref UnityEngine.Matrix4x4 @lhs, UnityEngine.Vector3 @rhs, out UnityEngine.Matrix4x4 @res)
        {
			@res = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs, @res};
            var ___result = RMTranslateMatrix34_Ref_Matrix4x4_Vector3_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			@lhs = ReflectionUtils.Convert<UnityEngine.Matrix4x4>(___parameters[0]);
			@res = ReflectionUtils.Convert<UnityEngine.Matrix4x4>(___parameters[2]);

            
        }


        public static void TranslateMatrix34InPlace(ref UnityEngine.Matrix4x4 @lhs, UnityEngine.Vector3 @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lhs, @rhs};
            var ___result = RMTranslateMatrix34InPlace_Ref_Matrix4x4_Vector3.Invoke(___genericsType, ___parameters);
			@lhs = ReflectionUtils.Convert<UnityEngine.Matrix4x4>(___parameters[0]);

            
        }


        public virtual UnityEngine.UIElements.IVisualElementScheduledItem UnityEngine__2__UIElements__2__IVisualElementScheduler__2__Execute(System.Action<UnityEngine.UIElements.TimerState> @timerUpdateEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timerUpdateEvent};
            var ___result = RMUnityEngine__2__UIElements__2__IVisualElementScheduler__2__Execute_Action_d_TimerState_p_.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.IVisualElementScheduledItem>(___result);
        }


        public virtual UnityEngine.UIElements.IVisualElementScheduledItem UnityEngine__2__UIElements__2__IVisualElementScheduler__2__Execute(System.Action @updateEvent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@updateEvent};
            var ___result = RMUnityEngine__2__UIElements__2__IVisualElementScheduler__2__Execute_Action.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.IVisualElementScheduledItem>(___result);
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


        public virtual UnityEngine.UIElements.StyleFloat ResolveLengthValue(UnityEngine.UIElements.Length @length, System.Boolean @isRow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@length, @isRow};
            var ___result = RMResolveLengthValue_Length_Boolean.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.StyleFloat>(___result);
        }


        public virtual UnityEngine.Vector3 ResolveTranslate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResolveTranslate.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector3>(___result);
        }


        public virtual UnityEngine.Vector3 ResolveTransformOrigin()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResolveTransformOrigin.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector3>(___result);
        }


        public virtual UnityEngine.Quaternion ResolveRotation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResolveRotation.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Quaternion>(___result);
        }


        public virtual UnityEngine.Vector3 ResolveScale()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMResolveScale.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Vector3>(___result);
        }


        public static Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RTypeData GetOrCreateTypeData(System.Type @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RMGetOrCreateTypeData_Type.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement.RTypeData>(___result);
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaSize __0__AssignMeasureFunction__1__b__424_0(Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaNode @node, System.Single @f, Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaMeasureMode @mode, System.Single @f1, Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaMeasureMode @heightMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node.Value, @f, @mode.Value, @f1, @heightMode.Value};
            var ___result = RM__0__AssignMeasureFunction__1__b__424_0_YogaNode_Single_YogaMeasureMode_Single_YogaMeasureMode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaSize>(___result);
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
