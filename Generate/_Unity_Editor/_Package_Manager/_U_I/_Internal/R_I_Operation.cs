
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal
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
				}
				return r_EonOperationProgress;
			}
		}

		/// <summary>
		/// System.String packageUniqueId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PpackageUniqueId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPpackageUniqueId
		{
			get
			{
				if(r_PpackageUniqueId == null)
				{
					r_PpackageUniqueId = new(this, "packageUniqueId", -1);
				}
				return r_PpackageUniqueId;
			}
		}

		/// <summary>
		/// System.String versionUniqueId
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_PversionUniqueId;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPversionUniqueId
		{
			get
			{
				if(r_PversionUniqueId == null)
				{
					r_PversionUniqueId = new(this, "versionUniqueId", -1);
				}
				return r_PversionUniqueId;
			}
		}

		/// <summary>
		/// Int64 timestamp
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_Ptimestamp;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPtimestamp
		{
			get
			{
				if(r_Ptimestamp == null)
				{
					r_Ptimestamp = new(this, "timestamp", -1);
				}
				return r_Ptimestamp;
			}
		}

		/// <summary>
		/// Int64 lastSuccessTimestamp
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt64 r_PlastSuccessTimestamp;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt64 RPlastSuccessTimestamp
		{
			get
			{
				if(r_PlastSuccessTimestamp == null)
				{
					r_PlastSuccessTimestamp = new(this, "lastSuccessTimestamp", -1);
				}
				return r_PlastSuccessTimestamp;
			}
		}

		/// <summary>
		/// Boolean isOfflineMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisOfflineMode;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisOfflineMode
		{
			get
			{
				if(r_PisOfflineMode == null)
				{
					r_PisOfflineMode = new(this, "isOfflineMode", -1);
				}
				return r_PisOfflineMode;
			}
		}

		/// <summary>
		/// Boolean isInProgress
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisInProgress;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisInProgress
		{
			get
			{
				if(r_PisInProgress == null)
				{
					r_PisInProgress = new(this, "isInProgress", -1);
				}
				return r_PisInProgress;
			}
		}

		/// <summary>
		/// Boolean isInPause
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisInPause;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisInPause
		{
			get
			{
				if(r_PisInPause == null)
				{
					r_PisInPause = new(this, "isInPause", -1);
				}
				return r_PisInPause;
			}
		}

		/// <summary>
		/// Boolean isProgressVisible
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisProgressVisible;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisProgressVisible
		{
			get
			{
				if(r_PisProgressVisible == null)
				{
					r_PisProgressVisible = new(this, "isProgressVisible", -1);
				}
				return r_PisProgressVisible;
			}
		}

		/// <summary>
		/// Boolean isProgressTrackable
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisProgressTrackable;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisProgressTrackable
		{
			get
			{
				if(r_PisProgressTrackable == null)
				{
					r_PisProgressTrackable = new(this, "isProgressTrackable", -1);
				}
				return r_PisProgressTrackable;
			}
		}

		/// <summary>
		/// Single progressPercentage
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PprogressPercentage;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPprogressPercentage
		{
			get
			{
				if(r_PprogressPercentage == null)
				{
					r_PprogressPercentage = new(this, "progressPercentage", -1);
				}
				return r_PprogressPercentage;
			}
		}

		/// <summary>
		/// UnityEditor.PackageManager.UI.Internal.RefreshOptions refreshOptions
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions r_PrefreshOptions;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RPackageManager.RUI.RInternal.RRefreshOptions RPrefreshOptions
		{
			get
			{
				if(r_PrefreshOptions == null)
				{
					r_PrefreshOptions = new(this, "refreshOptions", -1);
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
