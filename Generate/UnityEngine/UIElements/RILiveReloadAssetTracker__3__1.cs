using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.ILiveReloadAssetTracker`1
	/// </summary>
    public partial class RILiveReloadAssetTracker<T> : RMember // where T : UnityEngine.ScriptableObject
    {

		/// <summary>
		/// Int32 StartTrackingAsset(T)
		/// </summary>
		protected RMethod r_MStartTrackingAsset_T;
		public virtual RMethod RMStartTrackingAsset_T
		{
			get
			{
				if(r_MStartTrackingAsset_T == null)
				{
					r_MStartTrackingAsset_T = new(this, "StartTrackingAsset", 0, Type.MakeGenericMethodParameter(0));
					r_MStartTrackingAsset_T.SetBelong(this.instance);
				}
				return r_MStartTrackingAsset_T;
			}
		}

		/// <summary>
		/// Void StopTrackingAsset(T)
		/// </summary>
		protected RMethod r_MStopTrackingAsset_T;
		public virtual RMethod RMStopTrackingAsset_T
		{
			get
			{
				if(r_MStopTrackingAsset_T == null)
				{
					r_MStopTrackingAsset_T = new(this, "StopTrackingAsset", 0, Type.MakeGenericMethodParameter(0));
					r_MStopTrackingAsset_T.SetBelong(this.instance);
				}
				return r_MStopTrackingAsset_T;
			}
		}

		/// <summary>
		/// Boolean IsTrackingAsset(T)
		/// </summary>
		protected RMethod r_MIsTrackingAsset_T;
		public virtual RMethod RMIsTrackingAsset_T
		{
			get
			{
				if(r_MIsTrackingAsset_T == null)
				{
					r_MIsTrackingAsset_T = new(this, "IsTrackingAsset", 0, Type.MakeGenericMethodParameter(0));
					r_MIsTrackingAsset_T.SetBelong(this.instance);
				}
				return r_MIsTrackingAsset_T;
			}
		}

		/// <summary>
		/// Boolean IsTrackingAssets()
		/// </summary>
		protected RMethod r_MIsTrackingAssets;
		public virtual RMethod RMIsTrackingAssets
		{
			get
			{
				if(r_MIsTrackingAssets == null)
				{
					r_MIsTrackingAssets = new(this, "IsTrackingAssets", 0);
					r_MIsTrackingAssets.SetBelong(this.instance);
				}
				return r_MIsTrackingAssets;
			}
		}

		/// <summary>
		/// Boolean CheckTrackedAssetsDirty()
		/// </summary>
		protected RMethod r_MCheckTrackedAssetsDirty;
		public virtual RMethod RMCheckTrackedAssetsDirty
		{
			get
			{
				if(r_MCheckTrackedAssetsDirty == null)
				{
					r_MCheckTrackedAssetsDirty = new(this, "CheckTrackedAssetsDirty", 0);
					r_MCheckTrackedAssetsDirty.SetBelong(this.instance);
				}
				return r_MCheckTrackedAssetsDirty;
			}
		}

		/// <summary>
		/// Void UpdateAssetTrackerCounts(T, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_MUpdateAssetTrackerCounts_T_Int32_Int32_Int32_Int32;
		public virtual RMethod RMUpdateAssetTrackerCounts_T_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_MUpdateAssetTrackerCounts_T_Int32_Int32_Int32_Int32 == null)
				{
					r_MUpdateAssetTrackerCounts_T_Int32_Int32_Int32_Int32 = new(this, "UpdateAssetTrackerCounts", 0, Type.MakeGenericMethodParameter(0), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_MUpdateAssetTrackerCounts_T_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_MUpdateAssetTrackerCounts_T_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean OnAssetsImported(System.Collections.Generic.HashSet`1[T], System.Collections.Generic.HashSet`1[System.String])
		/// </summary>
		protected RMethod r_MOnAssetsImported_HashSet_d_T_p__HashSet_d_String_p_;
		public virtual RMethod RMOnAssetsImported_HashSet_d_T_p__HashSet_d_String_p_
		{
			get
			{
				if(r_MOnAssetsImported_HashSet_d_T_p__HashSet_d_String_p_ == null)
				{
					r_MOnAssetsImported_HashSet_d_T_p__HashSet_d_String_p_ = new(this, "OnAssetsImported", 0, typeof(System.Collections.Generic.HashSet<>).MakeGenericType(Type.MakeGenericMethodParameter(0)), typeof(System.Collections.Generic.HashSet<>).MakeGenericType(typeof(System.String)));
					r_MOnAssetsImported_HashSet_d_T_p__HashSet_d_String_p_.SetBelong(this.instance);
				}
				return r_MOnAssetsImported_HashSet_d_T_p__HashSet_d_String_p_;
			}
		}

		/// <summary>
		/// Void OnTrackedAssetChanged()
		/// </summary>
		protected RMethod r_MOnTrackedAssetChanged;
		public virtual RMethod RMOnTrackedAssetChanged
		{
			get
			{
				if(r_MOnTrackedAssetChanged == null)
				{
					r_MOnTrackedAssetChanged = new(this, "OnTrackedAssetChanged", 0);
					r_MOnTrackedAssetChanged.SetBelong(this.instance);
				}
				return r_MOnTrackedAssetChanged;
			}
		}


        public RILiveReloadAssetTracker() : base("UnityEngine.UIElements.ILiveReloadAssetTracker`1")
        {
        }

        public RILiveReloadAssetTracker(System.Object instance) : base("UnityEngine.UIElements.ILiveReloadAssetTracker`1")
		{
            SetInstance(instance);
		}

        public RILiveReloadAssetTracker(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RILiveReloadAssetTracker(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 StartTrackingAsset(T @asset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asset};
            var ___result = RMStartTrackingAsset_T.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void StopTrackingAsset(T @asset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asset};
            var ___result = RMStopTrackingAsset_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsTrackingAsset(T @asset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asset};
            var ___result = RMIsTrackingAsset_T.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsTrackingAssets()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsTrackingAssets.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CheckTrackedAssetsDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMCheckTrackedAssetsDirty.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void UpdateAssetTrackerCounts(T @asset, System.Int32 @newDirtyCount, System.Int32 @newElementCount, System.Int32 @newInlinePropertiesCount, System.Int32 @newAttributePropertiesDirtyCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asset, @newDirtyCount, @newElementCount, @newInlinePropertiesCount, @newAttributePropertiesDirtyCount};
            var ___result = RMUpdateAssetTrackerCounts_T_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean OnAssetsImported(System.Collections.Generic.HashSet<T> @changedAssets, System.Collections.Generic.HashSet<System.String> @deletedAssets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@changedAssets, @deletedAssets};
            var ___result = RMOnAssetsImported_HashSet_d_T_p__HashSet_d_String_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnTrackedAssetChanged()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMOnTrackedAssetChanged.Invoke(___genericsType, ___parameters);

            
        }


    }
}
