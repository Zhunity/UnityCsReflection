
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.VisualElementAnimationSystem
	/// </summary>
    public partial class RVisualElementAnimationSystem : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.VisualElementAnimationSystem");
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


		/// <summary>
		/// System.Action`1[UnityEngine.UIElements.BaseVisualElementPanel] panelChanged
		/// </summary>
		protected REvent r_EpanelChanged;
		public virtual REvent REpanelChanged
		{
			get
			{
				if(r_EpanelChanged == null)
				{
					r_EpanelChanged = new(this, "panelChanged");
				}
				return r_EpanelChanged;
			}
		}

		/// <summary>
		/// System.Collections.Generic.HashSet`1[UnityEngine.UIElements.Experimental.IValueAnimationUpdate] m_Animations
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate> r_Fm_Animations;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RHashSet<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate> RFm_Animations
		{
			get
			{
				if(r_Fm_Animations == null)
				{
					r_Fm_Animations = new(this, "m_Animations");
				}
				return r_Fm_Animations;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.Experimental.IValueAnimationUpdate] m_IterationList
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate> r_Fm_IterationList;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate> RFm_IterationList
		{
			get
			{
				if(r_Fm_IterationList == null)
				{
					r_Fm_IterationList = new(this, "m_IterationList");
				}
				return r_Fm_IterationList;
			}
		}

		/// <summary>
		/// System.Boolean m_HasNewAnimations
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_HasNewAnimations;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_HasNewAnimations
		{
			get
			{
				if(r_Fm_HasNewAnimations == null)
				{
					r_Fm_HasNewAnimations = new(this, "m_HasNewAnimations");
				}
				return r_Fm_HasNewAnimations;
			}
		}

		/// <summary>
		/// System.Boolean m_IterationListDirty
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Fm_IterationListDirty;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFm_IterationListDirty
		{
			get
			{
				if(r_Fm_IterationListDirty == null)
				{
					r_Fm_IterationListDirty = new(this, "m_IterationListDirty");
				}
				return r_Fm_IterationListDirty;
			}
		}

		/// <summary>
		/// System.String s_Description
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fs_Description;
		public static Hvak.Editor.Refleaction.RSystem.RString RFs_Description
		{
			get
			{
				if(r_Fs_Description == null)
				{
					r_Fs_Description = new( ReflectionUtils.GetType("UnityEngine.UIElements.VisualElementAnimationSystem"), "s_Description");
				}
				return r_Fs_Description;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_ProfilerMarker
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fs_ProfilerMarker;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFs_ProfilerMarker
		{
			get
			{
				if(r_Fs_ProfilerMarker == null)
				{
					r_Fs_ProfilerMarker = new( ReflectionUtils.GetType("UnityEngine.UIElements.VisualElementAnimationSystem"), "s_ProfilerMarker");
				}
				return r_Fs_ProfilerMarker;
			}
		}

		/// <summary>
		/// System.String s_StylePropertyAnimationDescription
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_Fs_StylePropertyAnimationDescription;
		public static Hvak.Editor.Refleaction.RSystem.RString RFs_StylePropertyAnimationDescription
		{
			get
			{
				if(r_Fs_StylePropertyAnimationDescription == null)
				{
					r_Fs_StylePropertyAnimationDescription = new( ReflectionUtils.GetType("UnityEngine.UIElements.VisualElementAnimationSystem"), "s_StylePropertyAnimationDescription");
				}
				return r_Fs_StylePropertyAnimationDescription;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_StylePropertyAnimationProfilerMarker
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fs_StylePropertyAnimationProfilerMarker;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFs_StylePropertyAnimationProfilerMarker
		{
			get
			{
				if(r_Fs_StylePropertyAnimationProfilerMarker == null)
				{
					r_Fs_StylePropertyAnimationProfilerMarker = new( ReflectionUtils.GetType("UnityEngine.UIElements.VisualElementAnimationSystem"), "s_StylePropertyAnimationProfilerMarker");
				}
				return r_Fs_StylePropertyAnimationProfilerMarker;
			}
		}

		/// <summary>
		/// System.Int64 lastUpdate
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_FlastUpdate;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RFlastUpdate
		{
			get
			{
				if(r_FlastUpdate == null)
				{
					r_FlastUpdate = new(this, "lastUpdate");
				}
				return r_FlastUpdate;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker profilerMarker
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_PprofilerMarker;
		public virtual Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RPprofilerMarker
		{
			get
			{
				if(r_PprofilerMarker == null)
				{
					r_PprofilerMarker = new(this, "profilerMarker", -1);
				}
				return r_PprofilerMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker stylePropertyAnimationProfilerMarker
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_PstylePropertyAnimationProfilerMarker;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RPstylePropertyAnimationProfilerMarker
		{
			get
			{
				if(r_PstylePropertyAnimationProfilerMarker == null)
				{
					r_PstylePropertyAnimationProfilerMarker = new( ReflectionUtils.GetType("UnityEngine.UIElements.VisualElementAnimationSystem"), "stylePropertyAnimationProfilerMarker", -1);
				}
				return r_PstylePropertyAnimationProfilerMarker;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.BaseVisualElementPanel panel
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel r_Ppanel;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RBaseVisualElementPanel RPpanel
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
		/// UnityEngine.UIElements.VisualElement visualTree
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PvisualTree;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPvisualTree
		{
			get
			{
				if(r_PvisualTree == null)
				{
					r_PvisualTree = new(this, "visualTree", -1);
				}
				return r_PvisualTree;
			}
		}

		/// <summary>
		/// Int64 CurrentTimeMs()
		/// </summary>
		protected RMethod r_MCurrentTimeMs;
		public virtual RMethod RMCurrentTimeMs
		{
			get
			{
				if(r_MCurrentTimeMs == null)
				{
					r_MCurrentTimeMs = new(this, "CurrentTimeMs", 0);
				}
				return r_MCurrentTimeMs;
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
		/// Void UnregisterAnimations(System.Collections.Generic.List`1[UnityEngine.UIElements.Experimental.IValueAnimationUpdate])
		/// </summary>
		protected RMethod r_MUnregisterAnimations_List_d_IValueAnimationUpdate_p_;
		public virtual RMethod RMUnregisterAnimations_List_d_IValueAnimationUpdate_p_
		{
			get
			{
				if(r_MUnregisterAnimations_List_d_IValueAnimationUpdate_p_ == null)
				{
					r_MUnregisterAnimations_List_d_IValueAnimationUpdate_p_ = new(this, "UnregisterAnimations", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType( ReflectionUtils.GetType("UnityEngine.UIElements.Experimental.IValueAnimationUpdate")));
				}
				return r_MUnregisterAnimations_List_d_IValueAnimationUpdate_p_;
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
		/// Void RegisterAnimations(System.Collections.Generic.List`1[UnityEngine.UIElements.Experimental.IValueAnimationUpdate])
		/// </summary>
		protected RMethod r_MRegisterAnimations_List_d_IValueAnimationUpdate_p_;
		public virtual RMethod RMRegisterAnimations_List_d_IValueAnimationUpdate_p_
		{
			get
			{
				if(r_MRegisterAnimations_List_d_IValueAnimationUpdate_p_ == null)
				{
					r_MRegisterAnimations_List_d_IValueAnimationUpdate_p_ = new(this, "RegisterAnimations", 0,  ReflectionUtils.GetType("System.Collections.Generic.List`1").MakeGenericType( ReflectionUtils.GetType("UnityEngine.UIElements.Experimental.IValueAnimationUpdate")));
				}
				return r_MRegisterAnimations_List_d_IValueAnimationUpdate_p_;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_MUpdate;
		public virtual RMethod RMUpdate
		{
			get
			{
				if(r_MUpdate == null)
				{
					r_MUpdate = new(this, "Update", 0);
				}
				return r_MUpdate;
			}
		}

		/// <summary>
		/// Void OnVersionChanged(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.VersionChangeType)
		/// </summary>
		protected RMethod r_MOnVersionChanged_VisualElement_VersionChangeType;
		public virtual RMethod RMOnVersionChanged_VisualElement_VersionChangeType
		{
			get
			{
				if(r_MOnVersionChanged_VisualElement_VersionChangeType == null)
				{
					r_MOnVersionChanged_VisualElement_VersionChangeType = new(this, "OnVersionChanged", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.VersionChangeType"));
				}
				return r_MOnVersionChanged_VisualElement_VersionChangeType;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
				}
				return r_MDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_MDispose_Boolean;
		public virtual RMethod RMDispose_Boolean
		{
			get
			{
				if(r_MDispose_Boolean == null)
				{
					r_MDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
				}
				return r_MDispose_Boolean;
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


        public virtual System.Int64 CurrentTimeMs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCurrentTimeMs.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual void UnregisterAnimation(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate @anim)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anim.Value};
            var ___result = RMUnregisterAnimation_IValueAnimationUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterAnimations(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate> @anims)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anims.Value};
            var ___result = RMUnregisterAnimations_List_d_IValueAnimationUpdate_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterAnimation(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate @anim)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anim.Value};
            var ___result = RMRegisterAnimation_IValueAnimationUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterAnimations(Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RExperimental.RIValueAnimationUpdate> @anims)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anims.Value};
            var ___result = RMRegisterAnimations_List_d_IValueAnimationUpdate_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnVersionChanged(UnityEngine.UIElements.VisualElement @ve, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVersionChangeType @versionChangeType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve, @versionChangeType.Value};
            var ___result = RMOnVersionChanged_VisualElement_VersionChangeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RMDispose_Boolean.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
