
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
{
	/// <summary>
	/// UnityEditor.PackageManager.UI.Internal.IOperation
	/// </summary>
    public partial class RIOperation : RMember //
    {

		/// <summary>
		/// System.Action`2[UnityEditor.PackageManager.UI.Internal.IOperation,UnityEditor.PackageManager.UI.Internal.UIError] onOperationError
		/// </summary>
		protected REvent r_EonOperationError;
		public virtual REvent REonOperationError
		{
			get
			{
				if(r_EonOperationError == null)
				{
					r_EonOperationError = new(this, "onOperationError");
					r_EonOperationError.SetBelong(this.instance);
				}
				return r_EonOperationError;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onOperationSuccess
		/// </summary>
		protected REvent r_EonOperationSuccess;
		public virtual REvent REonOperationSuccess
		{
			get
			{
				if(r_EonOperationSuccess == null)
				{
					r_EonOperationSuccess = new(this, "onOperationSuccess");
					r_EonOperationSuccess.SetBelong(this.instance);
				}
				return r_EonOperationSuccess;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onOperationFinalized
		/// </summary>
		protected REvent r_EonOperationFinalized;
		public virtual REvent REonOperationFinalized
		{
			get
			{
				if(r_EonOperationFinalized == null)
				{
					r_EonOperationFinalized = new(this, "onOperationFinalized");
					r_EonOperationFinalized.SetBelong(this.instance);
				}
				return r_EonOperationFinalized;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.PackageManager.UI.Internal.IOperation] onOperationProgress
		/// </summary>
		protected REvent r_EonOperationProgress;
		public virtual REvent REonOperationProgress
		{
			get
			{
				if(r_EonOperationProgress == null)
				{
					r_EonOperationProgress = new(this, "onOperationProgress");
					r_EonOperationProgress.SetBelong(this.instance);
				}
				return r_EonOperationProgress;
			}
		}

		/// <summary>
		/// System.String packageUniqueId
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PpackageUniqueId;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPpackageUniqueId
		{
			get
			{
				if(r_PpackageUniqueId == null)
				{
					r_PpackageUniqueId = new(this, "packageUniqueId", -1);
					r_PpackageUniqueId.SetBelong(this.instance);
				}
				return r_PpackageUniqueId;
			}
		}

		/// <summary>
		/// System.String versionUniqueId
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RString r_PversionUniqueId;
		public virtual SMFrame.Editor.Refleaction.RSystem.RString RPversionUniqueId
		{
			get
			{
				if(r_PversionUniqueId == null)
				{
					r_PversionUniqueId = new(this, "versionUniqueId", -1);
					r_PversionUniqueId.SetBelong(this.instance);
				}
				return r_PversionUniqueId;
			}
		}

		/// <summary>
		/// Int64 timestamp
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_Ptimestamp;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RPtimestamp
		{
			get
			{
				if(r_Ptimestamp == null)
				{
					r_Ptimestamp = new(this, "timestamp", -1);
					r_Ptimestamp.SetBelong(this.instance);
				}
				return r_Ptimestamp;
			}
		}

		/// <summary>
		/// Int64 lastSuccessTimestamp
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RInt64 r_PlastSuccessTimestamp;
		public virtual SMFrame.Editor.Refleaction.RSystem.RInt64 RPlastSuccessTimestamp
		{
			get
			{
				if(r_PlastSuccessTimestamp == null)
				{
					r_PlastSuccessTimestamp = new(this, "lastSuccessTimestamp", -1);
					r_PlastSuccessTimestamp.SetBelong(this.instance);
				}
				return r_PlastSuccessTimestamp;
			}
		}

		/// <summary>
		/// Boolean isOfflineMode
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisOfflineMode;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisOfflineMode
		{
			get
			{
				if(r_PisOfflineMode == null)
				{
					r_PisOfflineMode = new(this, "isOfflineMode", -1);
					r_PisOfflineMode.SetBelong(this.instance);
				}
				return r_PisOfflineMode;
			}
		}

		/// <summary>
		/// Boolean isInProgress
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisInProgress;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisInProgress
		{
			get
			{
				if(r_PisInProgress == null)
				{
					r_PisInProgress = new(this, "isInProgress", -1);
					r_PisInProgress.SetBelong(this.instance);
				}
				return r_PisInProgress;
			}
		}

		/// <summary>
		/// Boolean isInPause
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisInPause;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisInPause
		{
			get
			{
				if(r_PisInPause == null)
				{
					r_PisInPause = new(this, "isInPause", -1);
					r_PisInPause.SetBelong(this.instance);
				}
				return r_PisInPause;
			}
		}

		/// <summary>
		/// Boolean isProgressVisible
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisProgressVisible;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisProgressVisible
		{
			get
			{
				if(r_PisProgressVisible == null)
				{
					r_PisProgressVisible = new(this, "isProgressVisible", -1);
					r_PisProgressVisible.SetBelong(this.instance);
				}
				return r_PisProgressVisible;
			}
		}

		/// <summary>
		/// Boolean isProgressTrackable
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PisProgressTrackable;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPisProgressTrackable
		{
			get
			{
				if(r_PisProgressTrackable == null)
				{
					r_PisProgressTrackable = new(this, "isProgressTrackable", -1);
					r_PisProgressTrackable.SetBelong(this.instance);
				}
				return r_PisProgressTrackable;
			}
		}

		/// <summary>
		/// Single progressPercentage
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RSingle r_PprogressPercentage;
		public virtual SMFrame.Editor.Refleaction.RSystem.RSingle RPprogressPercentage
		{
			get
			{
				if(r_PprogressPercentage == null)
				{
					r_PprogressPercentage = new(this, "progressPercentage", -1);
					r_PprogressPercentage.SetBelong(this.instance);
				}
				return r_PprogressPercentage;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.RefreshOptions refreshOptions
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions r_PrefreshOptions;
		public virtual SMFrame.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions RPrefreshOptions
		{
			get
			{
				if(r_PrefreshOptions == null)
				{
					r_PrefreshOptions = new(this, "refreshOptions", -1);
					r_PrefreshOptions.SetBelong(this.instance);
				}
				return r_PrefreshOptions;
			}
		}


        public RIOperation() : base("UnityEditor.PackageManager.UI.Internal.IOperation")
        {
        }

        public RIOperation(System.Object instance) : base("UnityEditor.PackageManager.UI.Internal.IOperation")
		{
            SetInstance(instance);
		}

        public RIOperation(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIOperation(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
