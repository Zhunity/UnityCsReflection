
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ILiveReloadSystem
	/// </summary>
    public partial class RILiveReloadSystem : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.ILiveReloadSystem");
            }
        }

        public RILiveReloadSystem() : base("UnityEngine.UIElements.ILiveReloadSystem")
        {
        }

        public RILiveReloadSystem(System.Object instance) : base("UnityEngine.UIElements.ILiveReloadSystem")
		{
            SetInstance(instance);
		}

        public RILiveReloadSystem(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RILiveReloadSystem(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// Boolean enable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Penable;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPenable
		{
			get
			{
				if(r_Penable == null)
				{
					r_Penable = new(this, "enable", -1);
				}
				return r_Penable;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.LiveReloadTrackers enabledTrackers
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLiveReloadTrackers r_PenabledTrackers;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RLiveReloadTrackers RPenabledTrackers
		{
			get
			{
				if(r_PenabledTrackers == null)
				{
					r_PenabledTrackers = new(this, "enabledTrackers", -1);
				}
				return r_PenabledTrackers;
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
		/// Void RegisterVisualTreeAssetTracker(UnityEngine.UIElements.ILiveReloadAssetTracker`1[UnityEngine.UIElements.VisualTreeAsset], UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MRegisterVisualTreeAssetTracker_ILiveReloadAssetTracker_d_VisualTreeAsset_p__VisualElement;
		public virtual RMethod RMRegisterVisualTreeAssetTracker_ILiveReloadAssetTracker_d_VisualTreeAsset_p__VisualElement
		{
			get
			{
				if(r_MRegisterVisualTreeAssetTracker_ILiveReloadAssetTracker_d_VisualTreeAsset_p__VisualElement == null)
				{
					r_MRegisterVisualTreeAssetTracker_ILiveReloadAssetTracker_d_VisualTreeAsset_p__VisualElement = new(this, "RegisterVisualTreeAssetTracker", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.ILiveReloadAssetTracker`1").MakeGenericType(typeof(UnityEngine.UIElements.VisualTreeAsset)), typeof(UnityEngine.UIElements.VisualElement));
				}
				return r_MRegisterVisualTreeAssetTracker_ILiveReloadAssetTracker_d_VisualTreeAsset_p__VisualElement;
			}
		}

		/// <summary>
		/// Void UnregisterVisualTreeAssetTracker(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MUnregisterVisualTreeAssetTracker_VisualElement;
		public virtual RMethod RMUnregisterVisualTreeAssetTracker_VisualElement
		{
			get
			{
				if(r_MUnregisterVisualTreeAssetTracker_VisualElement == null)
				{
					r_MUnregisterVisualTreeAssetTracker_VisualElement = new(this, "UnregisterVisualTreeAssetTracker", 0, typeof(UnityEngine.UIElements.VisualElement));
				}
				return r_MUnregisterVisualTreeAssetTracker_VisualElement;
			}
		}

		/// <summary>
		/// Void StartTracking(System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_MStartTracking_List_d_VisualElement_p_;
		public virtual RMethod RMStartTracking_List_d_VisualElement_p_
		{
			get
			{
				if(r_MStartTracking_List_d_VisualElement_p_ == null)
				{
					r_MStartTracking_List_d_VisualElement_p_ = new(this, "StartTracking", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
				}
				return r_MStartTracking_List_d_VisualElement_p_;
			}
		}

		/// <summary>
		/// Void StopTracking(System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_MStopTracking_List_d_VisualElement_p_;
		public virtual RMethod RMStopTracking_List_d_VisualElement_p_
		{
			get
			{
				if(r_MStopTracking_List_d_VisualElement_p_ == null)
				{
					r_MStopTracking_List_d_VisualElement_p_ = new(this, "StopTracking", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
				}
				return r_MStopTracking_List_d_VisualElement_p_;
			}
		}

		/// <summary>
		/// Void StartStyleSheetAssetTracking(UnityEngine.UIElements.StyleSheet)
		/// </summary>
		protected RMethod r_MStartStyleSheetAssetTracking_StyleSheet;
		public virtual RMethod RMStartStyleSheetAssetTracking_StyleSheet
		{
			get
			{
				if(r_MStartStyleSheetAssetTracking_StyleSheet == null)
				{
					r_MStartStyleSheetAssetTracking_StyleSheet = new(this, "StartStyleSheetAssetTracking", 0, typeof(UnityEngine.UIElements.StyleSheet));
				}
				return r_MStartStyleSheetAssetTracking_StyleSheet;
			}
		}

		/// <summary>
		/// Void StopStyleSheetAssetTracking(UnityEngine.UIElements.StyleSheet)
		/// </summary>
		protected RMethod r_MStopStyleSheetAssetTracking_StyleSheet;
		public virtual RMethod RMStopStyleSheetAssetTracking_StyleSheet
		{
			get
			{
				if(r_MStopStyleSheetAssetTracking_StyleSheet == null)
				{
					r_MStopStyleSheetAssetTracking_StyleSheet = new(this, "StopStyleSheetAssetTracking", 0, typeof(UnityEngine.UIElements.StyleSheet));
				}
				return r_MStopStyleSheetAssetTracking_StyleSheet;
			}
		}

		/// <summary>
		/// Void OnStyleSheetAssetsImported(System.Collections.Generic.HashSet`1[UnityEngine.UIElements.StyleSheet], System.Collections.Generic.HashSet`1[System.String])
		/// </summary>
		protected RMethod r_MOnStyleSheetAssetsImported_HashSet_d_StyleSheet_p__HashSet_d_String_p_;
		public virtual RMethod RMOnStyleSheetAssetsImported_HashSet_d_StyleSheet_p__HashSet_d_String_p_
		{
			get
			{
				if(r_MOnStyleSheetAssetsImported_HashSet_d_StyleSheet_p__HashSet_d_String_p_ == null)
				{
					r_MOnStyleSheetAssetsImported_HashSet_d_StyleSheet_p__HashSet_d_String_p_ = new(this, "OnStyleSheetAssetsImported", 0, typeof(System.Collections.Generic.HashSet<>).MakeGenericType(typeof(UnityEngine.UIElements.StyleSheet)), typeof(System.Collections.Generic.HashSet<>).MakeGenericType(typeof(System.String)));
				}
				return r_MOnStyleSheetAssetsImported_HashSet_d_StyleSheet_p__HashSet_d_String_p_;
			}
		}

		/// <summary>
		/// Void OnVisualTreeAssetsImported(System.Collections.Generic.HashSet`1[UnityEngine.UIElements.VisualTreeAsset], System.Collections.Generic.HashSet`1[System.String])
		/// </summary>
		protected RMethod r_MOnVisualTreeAssetsImported_HashSet_d_VisualTreeAsset_p__HashSet_d_String_p_;
		public virtual RMethod RMOnVisualTreeAssetsImported_HashSet_d_VisualTreeAsset_p__HashSet_d_String_p_
		{
			get
			{
				if(r_MOnVisualTreeAssetsImported_HashSet_d_VisualTreeAsset_p__HashSet_d_String_p_ == null)
				{
					r_MOnVisualTreeAssetsImported_HashSet_d_VisualTreeAsset_p__HashSet_d_String_p_ = new(this, "OnVisualTreeAssetsImported", 0, typeof(System.Collections.Generic.HashSet<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualTreeAsset)), typeof(System.Collections.Generic.HashSet<>).MakeGenericType(typeof(System.String)));
				}
				return r_MOnVisualTreeAssetsImported_HashSet_d_VisualTreeAsset_p__HashSet_d_String_p_;
			}
		}

		/// <summary>
		/// Void RegisterTextElement(UnityEngine.UIElements.TextElement)
		/// </summary>
		protected RMethod r_MRegisterTextElement_TextElement;
		public virtual RMethod RMRegisterTextElement_TextElement
		{
			get
			{
				if(r_MRegisterTextElement_TextElement == null)
				{
					r_MRegisterTextElement_TextElement = new(this, "RegisterTextElement", 0, typeof(UnityEngine.UIElements.TextElement));
				}
				return r_MRegisterTextElement_TextElement;
			}
		}

		/// <summary>
		/// Void UnregisterTextElement(UnityEngine.UIElements.TextElement)
		/// </summary>
		protected RMethod r_MUnregisterTextElement_TextElement;
		public virtual RMethod RMUnregisterTextElement_TextElement
		{
			get
			{
				if(r_MUnregisterTextElement_TextElement == null)
				{
					r_MUnregisterTextElement_TextElement = new(this, "UnregisterTextElement", 0, typeof(UnityEngine.UIElements.TextElement));
				}
				return r_MUnregisterTextElement_TextElement;
			}
		}


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterVisualTreeAssetTracker(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RILiveReloadAssetTracker<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualTreeAsset> @tracker, UnityEngine.UIElements.VisualElement @owner)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tracker.Value, @owner};
            var ___result = RMRegisterVisualTreeAssetTracker_ILiveReloadAssetTracker_d_VisualTreeAsset_p__VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterVisualTreeAssetTracker(UnityEngine.UIElements.VisualElement @owner)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@owner};
            var ___result = RMUnregisterVisualTreeAssetTracker_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StartTracking(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> @elements)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elements};
            var ___result = RMStartTracking_List_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopTracking(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> @elements)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elements};
            var ___result = RMStopTracking_List_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StartStyleSheetAssetTracking(UnityEngine.UIElements.StyleSheet @styleSheet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@styleSheet};
            var ___result = RMStartStyleSheetAssetTracking_StyleSheet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopStyleSheetAssetTracking(UnityEngine.UIElements.StyleSheet @styleSheet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@styleSheet};
            var ___result = RMStopStyleSheetAssetTracking_StyleSheet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnStyleSheetAssetsImported(System.Collections.Generic.HashSet<UnityEngine.UIElements.StyleSheet> @changedAssets, System.Collections.Generic.HashSet<System.String> @deletedAssets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@changedAssets, @deletedAssets};
            var ___result = RMOnStyleSheetAssetsImported_HashSet_d_StyleSheet_p__HashSet_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnVisualTreeAssetsImported(System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualTreeAsset> @changedAssets, System.Collections.Generic.HashSet<System.String> @deletedAssets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@changedAssets, @deletedAssets};
            var ___result = RMOnVisualTreeAssetsImported_HashSet_d_VisualTreeAsset_p__HashSet_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterTextElement(UnityEngine.UIElements.TextElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RMRegisterTextElement_TextElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterTextElement(UnityEngine.UIElements.TextElement @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RMUnregisterTextElement_TextElement.Invoke(___genericsType, ___parameters);

            
        }


    }
}
