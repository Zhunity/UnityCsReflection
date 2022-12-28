using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ILiveReloadSystem
	/// </summary>
    public partial class RILiveReloadSystem : RMember //
    {

		/// <summary>
		/// Boolean enable
		/// </summary>
		protected RProperty r_enable;
		public virtual RProperty Renable
		{
			get
			{
				if(r_enable == null)
				{
					r_enable = new(this, "enable", -1);
					r_enable.SetBelong(this.instance);
				}
				return r_enable;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.LiveReloadTrackers enabledTrackers
		/// </summary>
		protected RProperty r_enabledTrackers;
		public virtual RProperty RenabledTrackers
		{
			get
			{
				if(r_enabledTrackers == null)
				{
					r_enabledTrackers = new(this, "enabledTrackers", -1);
					r_enabledTrackers.SetBelong(this.instance);
				}
				return r_enabledTrackers;
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
		/// Void RegisterVisualTreeAssetTracker(UnityEngine.UIElements.ILiveReloadAssetTracker`1[UnityEngine.UIElements.VisualTreeAsset], UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RRegisterVisualTreeAssetTracker_ILiveReloadAssetTracker_d_VisualTreeAsset_p__VisualElement;
		public virtual RMethod RRegisterVisualTreeAssetTracker_ILiveReloadAssetTracker_d_VisualTreeAsset_p__VisualElement
		{
			get
			{
				if(r_RRegisterVisualTreeAssetTracker_ILiveReloadAssetTracker_d_VisualTreeAsset_p__VisualElement == null)
				{
					r_RRegisterVisualTreeAssetTracker_ILiveReloadAssetTracker_d_VisualTreeAsset_p__VisualElement = new(this, "RegisterVisualTreeAssetTracker", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.ILiveReloadAssetTracker`1").MakeGenericType(typeof(UnityEngine.UIElements.VisualTreeAsset)), typeof(UnityEngine.UIElements.VisualElement));
					r_RRegisterVisualTreeAssetTracker_ILiveReloadAssetTracker_d_VisualTreeAsset_p__VisualElement.SetBelong(this.instance);
				}
				return r_RRegisterVisualTreeAssetTracker_ILiveReloadAssetTracker_d_VisualTreeAsset_p__VisualElement;
			}
		}

		/// <summary>
		/// Void UnregisterVisualTreeAssetTracker(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_RUnregisterVisualTreeAssetTracker_VisualElement;
		public virtual RMethod RUnregisterVisualTreeAssetTracker_VisualElement
		{
			get
			{
				if(r_RUnregisterVisualTreeAssetTracker_VisualElement == null)
				{
					r_RUnregisterVisualTreeAssetTracker_VisualElement = new(this, "UnregisterVisualTreeAssetTracker", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_RUnregisterVisualTreeAssetTracker_VisualElement.SetBelong(this.instance);
				}
				return r_RUnregisterVisualTreeAssetTracker_VisualElement;
			}
		}

		/// <summary>
		/// Void StartTracking(System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_RStartTracking_List_d_VisualElement_p_;
		public virtual RMethod RStartTracking_List_d_VisualElement_p_
		{
			get
			{
				if(r_RStartTracking_List_d_VisualElement_p_ == null)
				{
					r_RStartTracking_List_d_VisualElement_p_ = new(this, "StartTracking", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
					r_RStartTracking_List_d_VisualElement_p_.SetBelong(this.instance);
				}
				return r_RStartTracking_List_d_VisualElement_p_;
			}
		}

		/// <summary>
		/// Void StopTracking(System.Collections.Generic.List`1[UnityEngine.UIElements.VisualElement])
		/// </summary>
		protected RMethod r_RStopTracking_List_d_VisualElement_p_;
		public virtual RMethod RStopTracking_List_d_VisualElement_p_
		{
			get
			{
				if(r_RStopTracking_List_d_VisualElement_p_ == null)
				{
					r_RStopTracking_List_d_VisualElement_p_ = new(this, "StopTracking", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualElement)));
					r_RStopTracking_List_d_VisualElement_p_.SetBelong(this.instance);
				}
				return r_RStopTracking_List_d_VisualElement_p_;
			}
		}

		/// <summary>
		/// Void StartStyleSheetAssetTracking(UnityEngine.UIElements.StyleSheet)
		/// </summary>
		protected RMethod r_RStartStyleSheetAssetTracking_StyleSheet;
		public virtual RMethod RStartStyleSheetAssetTracking_StyleSheet
		{
			get
			{
				if(r_RStartStyleSheetAssetTracking_StyleSheet == null)
				{
					r_RStartStyleSheetAssetTracking_StyleSheet = new(this, "StartStyleSheetAssetTracking", 0, typeof(UnityEngine.UIElements.StyleSheet));
					r_RStartStyleSheetAssetTracking_StyleSheet.SetBelong(this.instance);
				}
				return r_RStartStyleSheetAssetTracking_StyleSheet;
			}
		}

		/// <summary>
		/// Void StopStyleSheetAssetTracking(UnityEngine.UIElements.StyleSheet)
		/// </summary>
		protected RMethod r_RStopStyleSheetAssetTracking_StyleSheet;
		public virtual RMethod RStopStyleSheetAssetTracking_StyleSheet
		{
			get
			{
				if(r_RStopStyleSheetAssetTracking_StyleSheet == null)
				{
					r_RStopStyleSheetAssetTracking_StyleSheet = new(this, "StopStyleSheetAssetTracking", 0, typeof(UnityEngine.UIElements.StyleSheet));
					r_RStopStyleSheetAssetTracking_StyleSheet.SetBelong(this.instance);
				}
				return r_RStopStyleSheetAssetTracking_StyleSheet;
			}
		}

		/// <summary>
		/// Void OnStyleSheetAssetsImported(System.Collections.Generic.HashSet`1[UnityEngine.UIElements.StyleSheet], System.Collections.Generic.HashSet`1[System.String])
		/// </summary>
		protected RMethod r_ROnStyleSheetAssetsImported_HashSet_d_StyleSheet_p__HashSet_d_String_p_;
		public virtual RMethod ROnStyleSheetAssetsImported_HashSet_d_StyleSheet_p__HashSet_d_String_p_
		{
			get
			{
				if(r_ROnStyleSheetAssetsImported_HashSet_d_StyleSheet_p__HashSet_d_String_p_ == null)
				{
					r_ROnStyleSheetAssetsImported_HashSet_d_StyleSheet_p__HashSet_d_String_p_ = new(this, "OnStyleSheetAssetsImported", 0, typeof(System.Collections.Generic.HashSet<>).MakeGenericType(typeof(UnityEngine.UIElements.StyleSheet)), typeof(System.Collections.Generic.HashSet<>).MakeGenericType(typeof(System.String)));
					r_ROnStyleSheetAssetsImported_HashSet_d_StyleSheet_p__HashSet_d_String_p_.SetBelong(this.instance);
				}
				return r_ROnStyleSheetAssetsImported_HashSet_d_StyleSheet_p__HashSet_d_String_p_;
			}
		}

		/// <summary>
		/// Void OnVisualTreeAssetsImported(System.Collections.Generic.HashSet`1[UnityEngine.UIElements.VisualTreeAsset], System.Collections.Generic.HashSet`1[System.String])
		/// </summary>
		protected RMethod r_ROnVisualTreeAssetsImported_HashSet_d_VisualTreeAsset_p__HashSet_d_String_p_;
		public virtual RMethod ROnVisualTreeAssetsImported_HashSet_d_VisualTreeAsset_p__HashSet_d_String_p_
		{
			get
			{
				if(r_ROnVisualTreeAssetsImported_HashSet_d_VisualTreeAsset_p__HashSet_d_String_p_ == null)
				{
					r_ROnVisualTreeAssetsImported_HashSet_d_VisualTreeAsset_p__HashSet_d_String_p_ = new(this, "OnVisualTreeAssetsImported", 0, typeof(System.Collections.Generic.HashSet<>).MakeGenericType(typeof(UnityEngine.UIElements.VisualTreeAsset)), typeof(System.Collections.Generic.HashSet<>).MakeGenericType(typeof(System.String)));
					r_ROnVisualTreeAssetsImported_HashSet_d_VisualTreeAsset_p__HashSet_d_String_p_.SetBelong(this.instance);
				}
				return r_ROnVisualTreeAssetsImported_HashSet_d_VisualTreeAsset_p__HashSet_d_String_p_;
			}
		}

		/// <summary>
		/// Void RegisterTextElement(UnityEngine.UIElements.TextElement)
		/// </summary>
		protected RMethod r_RRegisterTextElement_TextElement;
		public virtual RMethod RRegisterTextElement_TextElement
		{
			get
			{
				if(r_RRegisterTextElement_TextElement == null)
				{
					r_RRegisterTextElement_TextElement = new(this, "RegisterTextElement", 0, typeof(UnityEngine.UIElements.TextElement));
					r_RRegisterTextElement_TextElement.SetBelong(this.instance);
				}
				return r_RRegisterTextElement_TextElement;
			}
		}

		/// <summary>
		/// Void UnregisterTextElement(UnityEngine.UIElements.TextElement)
		/// </summary>
		protected RMethod r_RUnregisterTextElement_TextElement;
		public virtual RMethod RUnregisterTextElement_TextElement
		{
			get
			{
				if(r_RUnregisterTextElement_TextElement == null)
				{
					r_RUnregisterTextElement_TextElement = new(this, "UnregisterTextElement", 0, typeof(UnityEngine.UIElements.TextElement));
					r_RUnregisterTextElement_TextElement.SetBelong(this.instance);
				}
				return r_RUnregisterTextElement_TextElement;
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

        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void UnregisterVisualTreeAssetTracker(UnityEngine.UIElements.VisualElement  @owner)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@owner};
            var ___result = RUnregisterVisualTreeAssetTracker_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StartTracking(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>  @elements)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elements};
            var ___result = RStartTracking_List_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopTracking(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>  @elements)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elements};
            var ___result = RStopTracking_List_d_VisualElement_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StartStyleSheetAssetTracking(UnityEngine.UIElements.StyleSheet  @styleSheet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@styleSheet};
            var ___result = RStartStyleSheetAssetTracking_StyleSheet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopStyleSheetAssetTracking(UnityEngine.UIElements.StyleSheet  @styleSheet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@styleSheet};
            var ___result = RStopStyleSheetAssetTracking_StyleSheet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnStyleSheetAssetsImported(System.Collections.Generic.HashSet<UnityEngine.UIElements.StyleSheet>  @changedAssets, System.Collections.Generic.HashSet<System.String>  @deletedAssets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@changedAssets, @deletedAssets};
            var ___result = ROnStyleSheetAssetsImported_HashSet_d_StyleSheet_p__HashSet_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnVisualTreeAssetsImported(System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualTreeAsset>  @changedAssets, System.Collections.Generic.HashSet<System.String>  @deletedAssets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@changedAssets, @deletedAssets};
            var ___result = ROnVisualTreeAssetsImported_HashSet_d_VisualTreeAsset_p__HashSet_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterTextElement(UnityEngine.UIElements.TextElement  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RRegisterTextElement_TextElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnregisterTextElement(UnityEngine.UIElements.TextElement  @element)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@element};
            var ___result = RUnregisterTextElement_TextElement.Invoke(___genericsType, ___parameters);

            
        }


    }
}