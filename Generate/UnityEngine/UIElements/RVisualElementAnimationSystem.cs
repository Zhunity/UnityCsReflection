using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.VisualElementAnimationSystem
	/// </summary>
    public partial class RVisualElementAnimationSystem : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.HashSet`1[UnityEngine.UIElements.Experimental.IValueAnimationUpdate] m_Animations
		/// </summary>
		protected RSystem.RCollections.RGeneric.RHashSet<RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate> r_m_Animations;
		public virtual RSystem.RCollections.RGeneric.RHashSet<RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate> Rm_Animations
		{
			get
			{
				if(r_m_Animations == null)
				{
					r_m_Animations = new(this, "m_Animations");
					r_m_Animations.SetBelong(this.instance);
				}
				return r_m_Animations;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.Experimental.IValueAnimationUpdate] m_IterationList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate> r_m_IterationList;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate> Rm_IterationList
		{
			get
			{
				if(r_m_IterationList == null)
				{
					r_m_IterationList = new(this, "m_IterationList");
					r_m_IterationList.SetBelong(this.instance);
				}
				return r_m_IterationList;
			}
		}

		/// <summary>
		/// System.Boolean m_HasNewAnimations
		/// </summary>
		protected RField r_m_HasNewAnimations;
		public virtual RField Rm_HasNewAnimations
		{
			get
			{
				if(r_m_HasNewAnimations == null)
				{
					r_m_HasNewAnimations = new(this, "m_HasNewAnimations");
					r_m_HasNewAnimations.SetBelong(this.instance);
				}
				return r_m_HasNewAnimations;
			}
		}

		/// <summary>
		/// System.Boolean m_IterationListDirty
		/// </summary>
		protected RField r_m_IterationListDirty;
		public virtual RField Rm_IterationListDirty
		{
			get
			{
				if(r_m_IterationListDirty == null)
				{
					r_m_IterationListDirty = new(this, "m_IterationListDirty");
					r_m_IterationListDirty.SetBelong(this.instance);
				}
				return r_m_IterationListDirty;
			}
		}

		/// <summary>
		/// System.String s_Description
		/// </summary>
		protected static RField r_s_Description;
		public static RField Rs_Description
		{
			get
			{
				if(r_s_Description == null)
				{
					r_s_Description = new( ReleactionUtils.GetType("UnityEngine.UIElements.VisualElementAnimationSystem"), "s_Description");
					r_s_Description.SetBelong(null);
				}
				return r_s_Description;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_ProfilerMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_ProfilerMarker;
		public static RUnity.RProfiling.RProfilerMarker Rs_ProfilerMarker
		{
			get
			{
				if(r_s_ProfilerMarker == null)
				{
					r_s_ProfilerMarker = new( ReleactionUtils.GetType("UnityEngine.UIElements.VisualElementAnimationSystem"), "s_ProfilerMarker");
					r_s_ProfilerMarker.SetBelong(null);
				}
				return r_s_ProfilerMarker;
			}
		}

		/// <summary>
		/// System.String s_StylePropertyAnimationDescription
		/// </summary>
		protected static RField r_s_StylePropertyAnimationDescription;
		public static RField Rs_StylePropertyAnimationDescription
		{
			get
			{
				if(r_s_StylePropertyAnimationDescription == null)
				{
					r_s_StylePropertyAnimationDescription = new( ReleactionUtils.GetType("UnityEngine.UIElements.VisualElementAnimationSystem"), "s_StylePropertyAnimationDescription");
					r_s_StylePropertyAnimationDescription.SetBelong(null);
				}
				return r_s_StylePropertyAnimationDescription;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_StylePropertyAnimationProfilerMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_StylePropertyAnimationProfilerMarker;
		public static RUnity.RProfiling.RProfilerMarker Rs_StylePropertyAnimationProfilerMarker
		{
			get
			{
				if(r_s_StylePropertyAnimationProfilerMarker == null)
				{
					r_s_StylePropertyAnimationProfilerMarker = new( ReleactionUtils.GetType("UnityEngine.UIElements.VisualElementAnimationSystem"), "s_StylePropertyAnimationProfilerMarker");
					r_s_StylePropertyAnimationProfilerMarker.SetBelong(null);
				}
				return r_s_StylePropertyAnimationProfilerMarker;
			}
		}

		/// <summary>
		/// System.Int64 lastUpdate
		/// </summary>
		protected RField r_lastUpdate;
		public virtual RField RlastUpdate
		{
			get
			{
				if(r_lastUpdate == null)
				{
					r_lastUpdate = new(this, "lastUpdate");
					r_lastUpdate.SetBelong(this.instance);
				}
				return r_lastUpdate;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker profilerMarker
		/// </summary>
		protected RUnity.RProfiling.RProfilerMarker r_profilerMarker;
		public virtual RUnity.RProfiling.RProfilerMarker RprofilerMarker
		{
			get
			{
				if(r_profilerMarker == null)
				{
					r_profilerMarker = new(this, "profilerMarker", -1);
					r_profilerMarker.SetBelong(this.instance);
				}
				return r_profilerMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker stylePropertyAnimationProfilerMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_stylePropertyAnimationProfilerMarker;
		public static RUnity.RProfiling.RProfilerMarker RstylePropertyAnimationProfilerMarker
		{
			get
			{
				if(r_stylePropertyAnimationProfilerMarker == null)
				{
					r_stylePropertyAnimationProfilerMarker = new( ReleactionUtils.GetType("UnityEngine.UIElements.VisualElementAnimationSystem"), "stylePropertyAnimationProfilerMarker", -1);
					r_stylePropertyAnimationProfilerMarker.SetBelong(null);
				}
				return r_stylePropertyAnimationProfilerMarker;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseVisualElementPanel panel
		/// </summary>
		protected RUnityEngine.RUIElements.RBaseVisualElementPanel r_panel;
		public virtual RUnityEngine.RUIElements.RBaseVisualElementPanel Rpanel
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
		/// UnityEngine.UIElements.VisualElement visualTree
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_visualTree;
		public virtual RUnityEngine.RUIElements.RVisualElement RvisualTree
		{
			get
			{
				if(r_visualTree == null)
				{
					r_visualTree = new(this, "visualTree", -1);
					r_visualTree.SetBelong(this.instance);
				}
				return r_visualTree;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.BaseVisualElementPanel] panelChanged
		/// </summary>
		protected REvent r_panelChanged;
		public virtual REvent RpanelChanged
		{
			get
			{
				if(r_panelChanged == null)
				{
					r_panelChanged = new(this, "panelChanged");
					r_panelChanged.SetBelong(this.instance);
				}
				return r_panelChanged;
			}
		}

		/// <summary>
		/// Int64 CurrentTimeMs()
		/// </summary>
		protected RMethod r_RCurrentTimeMs;
		public virtual RMethod RCurrentTimeMs
		{
			get
			{
				if(r_RCurrentTimeMs == null)
				{
					r_RCurrentTimeMs = new(this, "CurrentTimeMs", 0);
					r_RCurrentTimeMs.SetBelong(this.instance);
				}
				return r_RCurrentTimeMs;
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
		/// Void UnregisterAnimations(System.Collections.Generic.List`1[UnityEngine.UIElements.Experimental.IValueAnimationUpdate])
		/// </summary>
		protected RMethod r_RUnregisterAnimations_List_d_IValueAnimationUpdate_p_;
		public virtual RMethod RUnregisterAnimations_List_d_IValueAnimationUpdate_p_
		{
			get
			{
				if(r_RUnregisterAnimations_List_d_IValueAnimationUpdate_p_ == null)
				{
					r_RUnregisterAnimations_List_d_IValueAnimationUpdate_p_ = new(this, "UnregisterAnimations", 0, typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("UnityEngine.UIElements.Experimental.IValueAnimationUpdate")));
					r_RUnregisterAnimations_List_d_IValueAnimationUpdate_p_.SetBelong(this.instance);
				}
				return r_RUnregisterAnimations_List_d_IValueAnimationUpdate_p_;
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
		/// Void RegisterAnimations(System.Collections.Generic.List`1[UnityEngine.UIElements.Experimental.IValueAnimationUpdate])
		/// </summary>
		protected RMethod r_RRegisterAnimations_List_d_IValueAnimationUpdate_p_;
		public virtual RMethod RRegisterAnimations_List_d_IValueAnimationUpdate_p_
		{
			get
			{
				if(r_RRegisterAnimations_List_d_IValueAnimationUpdate_p_ == null)
				{
					r_RRegisterAnimations_List_d_IValueAnimationUpdate_p_ = new(this, "RegisterAnimations", 0, typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("UnityEngine.UIElements.Experimental.IValueAnimationUpdate")));
					r_RRegisterAnimations_List_d_IValueAnimationUpdate_p_.SetBelong(this.instance);
				}
				return r_RRegisterAnimations_List_d_IValueAnimationUpdate_p_;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_RUpdate;
		public virtual RMethod RUpdate
		{
			get
			{
				if(r_RUpdate == null)
				{
					r_RUpdate = new(this, "Update", 0);
					r_RUpdate.SetBelong(this.instance);
				}
				return r_RUpdate;
			}
		}

		/// <summary>
		/// Void OnVersionChanged(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VersionChangeType)
		/// </summary>
		protected RMethod r_ROnVersionChanged_VisualElement_VersionChangeType;
		public virtual RMethod ROnVersionChanged_VisualElement_VersionChangeType
		{
			get
			{
				if(r_ROnVersionChanged_VisualElement_VersionChangeType == null)
				{
					r_ROnVersionChanged_VisualElement_VersionChangeType = new(this, "OnVersionChanged", 0, typeof(UnityEngine.UIElements.VisualElement),  ReleactionUtils.GetType("UnityEngine.UIElements.VersionChangeType"));
					r_ROnVersionChanged_VisualElement_VersionChangeType.SetBelong(this.instance);
				}
				return r_ROnVersionChanged_VisualElement_VersionChangeType;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_RDispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_RDispose_Boolean == null)
				{
					r_RDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_RDispose_Boolean.SetBelong(this.instance);
				}
				return r_RDispose_Boolean;
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


        public RVisualElementAnimationSystem() : base("UnityEngine.UIElements.VisualElementAnimationSystem")
        {
        }

        public RVisualElementAnimationSystem(System.Object instance) : base("UnityEngine.UIElements.VisualElementAnimationSystem")
		{
            SetInstance(instance);
		}

        public RVisualElementAnimationSystem(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVisualElementAnimationSystem(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int64 CurrentTimeMs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCurrentTimeMs.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }






        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
