
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.DataModeController
	/// </summary>
    public partial class RDataModeController : RMember //
    {

		/// <summary>
		/// System.Action`1[UnityEditor.DataModeChangeEventArgs] dataModeChanged
		/// </summary>
		protected REvent r_EdataModeChanged;
		public virtual REvent REdataModeChanged
		{
			get
			{
				if(r_EdataModeChanged == null)
				{
					r_EdataModeChanged = new(this, "dataModeChanged");
					r_EdataModeChanged.SetBelong(this.GetValue());
				}
				return r_EdataModeChanged;
			}
		}

		/// <summary>
		/// UnityEditor.DataMode[] k_DefaultModes
		/// </summary>
		protected static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RDataMode> r_Fk_DefaultModes;
		public static Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RDataMode> RFk_DefaultModes
		{
			get
			{
				if(r_Fk_DefaultModes == null)
				{
					r_Fk_DefaultModes = new( ReflectionUtils.GetType("UnityEditor.DataModeController"), "k_DefaultModes");
					r_Fk_DefaultModes.SetBelong(null);
				}
				return r_Fk_DefaultModes;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.DataModeChangeEventArgs] dataModeChanged
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RDataModeChangeEventArgs> r_FdataModeChanged;
		public virtual Hvak.Editor.Refleaction.RSystem.RAction<Hvak.Editor.Refleaction.RUnityEditor.RDataModeChangeEventArgs> RFdataModeChanged
		{
			get
			{
				if(r_FdataModeChanged == null)
				{
					r_FdataModeChanged = new(this, "dataModeChanged");
					r_FdataModeChanged.SetBelong(this.GetValue());
				}
				return r_FdataModeChanged;
			}
		}

		/// <summary>
		/// UnityEditor.DataMode m_DataMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RDataMode r_Fm_DataMode;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RDataMode RFm_DataMode
		{
			get
			{
				if(r_Fm_DataMode == null)
				{
					r_Fm_DataMode = new(this, "m_DataMode");
					r_Fm_DataMode.SetBelong(this.GetValue());
				}
				return r_Fm_DataMode;
			}
		}

		/// <summary>
		/// UnityEditor.DataMode m_PreferredDataMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RDataMode r_Fm_PreferredDataMode;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RDataMode RFm_PreferredDataMode
		{
			get
			{
				if(r_Fm_PreferredDataMode == null)
				{
					r_Fm_PreferredDataMode = new(this, "m_PreferredDataMode");
					r_Fm_PreferredDataMode.SetBelong(this.GetValue());
				}
				return r_Fm_PreferredDataMode;
			}
		}

		/// <summary>
		/// UnityEditor.DataMode[] m_SupportedDataModes
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RDataMode> r_Fm_SupportedDataModes;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEditor.RDataMode> RFm_SupportedDataModes
		{
			get
			{
				if(r_Fm_SupportedDataModes == null)
				{
					r_Fm_SupportedDataModes = new(this, "m_SupportedDataModes");
					r_Fm_SupportedDataModes.SetBelong(this.GetValue());
				}
				return r_Fm_SupportedDataModes;
			}
		}

		/// <summary>
		/// System.Boolean isAutomatic
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisAutomatic;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisAutomatic
		{
			get
			{
				if(r_FisAutomatic == null)
				{
					r_FisAutomatic = new(this, "isAutomatic");
					r_FisAutomatic.SetBelong(this.GetValue());
				}
				return r_FisAutomatic;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.DataMode] m_DataModeSanitizationCache
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RDataMode> r_Fm_DataModeSanitizationCache;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEditor.RDataMode> RFm_DataModeSanitizationCache
		{
			get
			{
				if(r_Fm_DataModeSanitizationCache == null)
				{
					r_Fm_DataModeSanitizationCache = new(this, "m_DataModeSanitizationCache");
					r_Fm_DataModeSanitizationCache.SetBelong(this.GetValue());
				}
				return r_Fm_DataModeSanitizationCache;
			}
		}

		/// <summary>
		/// UnityEditor.DataMode dataMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RDataMode r_PdataMode;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RDataMode RPdataMode
		{
			get
			{
				if(r_PdataMode == null)
				{
					r_PdataMode = new(this, "dataMode", -1);
					r_PdataMode.SetBelong(this.GetValue());
				}
				return r_PdataMode;
			}
		}

		/// <summary>
		/// UnityEditor.DataMode preferredDataMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEditor.RDataMode r_PpreferredDataMode;
		public virtual Hvak.Editor.Refleaction.RUnityEditor.RDataMode RPpreferredDataMode
		{
			get
			{
				if(r_PpreferredDataMode == null)
				{
					r_PpreferredDataMode = new(this, "preferredDataMode", -1);
					r_PpreferredDataMode.SetBelong(this.GetValue());
				}
				return r_PpreferredDataMode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[UnityEditor.DataMode] supportedDataModes
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<Hvak.Editor.Refleaction.RUnityEditor.RDataMode> r_PsupportedDataModes;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<Hvak.Editor.Refleaction.RUnityEditor.RDataMode> RPsupportedDataModes
		{
			get
			{
				if(r_PsupportedDataModes == null)
				{
					r_PsupportedDataModes = new(this, "supportedDataModes", -1);
					r_PsupportedDataModes.SetBelong(this.GetValue());
				}
				return r_PsupportedDataModes;
			}
		}

		/// <summary>
		/// Void UpdateSupportedDataModes(System.Collections.Generic.IList`1[UnityEditor.DataMode], UnityEditor.DataMode)
		/// </summary>
		protected RMethod r_MUpdateSupportedDataModes_IList_d_DataMode_p__DataMode;
		public virtual RMethod RMUpdateSupportedDataModes_IList_d_DataMode_p__DataMode
		{
			get
			{
				if(r_MUpdateSupportedDataModes_IList_d_DataMode_p__DataMode == null)
				{
					r_MUpdateSupportedDataModes_IList_d_DataMode_p__DataMode = new(this, "UpdateSupportedDataModes", 0, typeof(System.Collections.Generic.IList<>).MakeGenericType(typeof(UnityEditor.DataMode)), typeof(UnityEditor.DataMode));
					r_MUpdateSupportedDataModes_IList_d_DataMode_p__DataMode.SetBelong(this.GetValue());
				}
				return r_MUpdateSupportedDataModes_IList_d_DataMode_p__DataMode;
			}
		}

		/// <summary>
		/// Void SanitizeSupportedDataModesList(System.Collections.Generic.IReadOnlyList`1[UnityEditor.DataMode], System.Collections.Generic.List`1[UnityEditor.DataMode])
		/// </summary>
		protected static RMethod r_MSanitizeSupportedDataModesList_IReadOnlyList_d_DataMode_p__List_d_DataMode_p_;
		public static RMethod RMSanitizeSupportedDataModesList_IReadOnlyList_d_DataMode_p__List_d_DataMode_p_
		{
			get
			{
				if(r_MSanitizeSupportedDataModesList_IReadOnlyList_d_DataMode_p__List_d_DataMode_p_ == null)
				{
					r_MSanitizeSupportedDataModesList_IReadOnlyList_d_DataMode_p__List_d_DataMode_p_ = new( ReflectionUtils.GetType("UnityEditor.DataModeController"), "SanitizeSupportedDataModesList", 0, typeof(System.Collections.Generic.IReadOnlyList<>).MakeGenericType(typeof(UnityEditor.DataMode)), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEditor.DataMode)));
					r_MSanitizeSupportedDataModesList_IReadOnlyList_d_DataMode_p__List_d_DataMode_p_.SetBelong(null);
				}
				return r_MSanitizeSupportedDataModesList_IReadOnlyList_d_DataMode_p__List_d_DataMode_p_;
			}
		}

		/// <summary>
		/// Boolean ShouldDrawDataModesSwitch()
		/// </summary>
		protected RMethod r_MShouldDrawDataModesSwitch;
		public virtual RMethod RMShouldDrawDataModesSwitch
		{
			get
			{
				if(r_MShouldDrawDataModesSwitch == null)
				{
					r_MShouldDrawDataModesSwitch = new(this, "ShouldDrawDataModesSwitch", 0);
					r_MShouldDrawDataModesSwitch.SetBelong(this.GetValue());
				}
				return r_MShouldDrawDataModesSwitch;
			}
		}

		/// <summary>
		/// Boolean TryChangeDataMode(UnityEditor.DataMode)
		/// </summary>
		protected RMethod r_MTryChangeDataMode_DataMode;
		public virtual RMethod RMTryChangeDataMode_DataMode
		{
			get
			{
				if(r_MTryChangeDataMode_DataMode == null)
				{
					r_MTryChangeDataMode_DataMode = new(this, "TryChangeDataMode", 0, typeof(UnityEditor.DataMode));
					r_MTryChangeDataMode_DataMode.SetBelong(this.GetValue());
				}
				return r_MTryChangeDataMode_DataMode;
			}
		}

		/// <summary>
		/// Void SwitchToAutomatic()
		/// </summary>
		protected RMethod r_MSwitchToAutomatic;
		public virtual RMethod RMSwitchToAutomatic
		{
			get
			{
				if(r_MSwitchToAutomatic == null)
				{
					r_MSwitchToAutomatic = new(this, "SwitchToAutomatic", 0);
					r_MSwitchToAutomatic.SetBelong(this.GetValue());
				}
				return r_MSwitchToAutomatic;
			}
		}

		/// <summary>
		/// Void SwitchToStickyDataMode(UnityEditor.DataMode)
		/// </summary>
		protected RMethod r_MSwitchToStickyDataMode_DataMode;
		public virtual RMethod RMSwitchToStickyDataMode_DataMode
		{
			get
			{
				if(r_MSwitchToStickyDataMode_DataMode == null)
				{
					r_MSwitchToStickyDataMode_DataMode = new(this, "SwitchToStickyDataMode", 0, typeof(UnityEditor.DataMode));
					r_MSwitchToStickyDataMode_DataMode.SetBelong(this.GetValue());
				}
				return r_MSwitchToStickyDataMode_DataMode;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
			}
		}


        public RDataModeController() : base("UnityEditor.DataModeController")
        {
        }

        public RDataModeController(System.Object instance) : base("UnityEditor.DataModeController")
		{
            SetInstance(instance);
		}

        public RDataModeController(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDataModeController(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void UpdateSupportedDataModes(System.Collections.Generic.IList<UnityEditor.DataMode> @supported, UnityEditor.DataMode @preferred)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@supported, @preferred};
            var ___result = RMUpdateSupportedDataModes_IList_d_DataMode_p__DataMode.Invoke(___genericsType, ___parameters);

            
        }


        public static void SanitizeSupportedDataModesList(System.Collections.Generic.IReadOnlyList<UnityEditor.DataMode> @originalList, System.Collections.Generic.List<UnityEditor.DataMode> @sanitizedList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@originalList, @sanitizedList};
            var ___result = RMSanitizeSupportedDataModesList_IReadOnlyList_d_DataMode_p__List_d_DataMode_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ShouldDrawDataModesSwitch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMShouldDrawDataModesSwitch.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryChangeDataMode(UnityEditor.DataMode @newDataMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newDataMode};
            var ___result = RMTryChangeDataMode_DataMode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SwitchToAutomatic()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMSwitchToAutomatic.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SwitchToStickyDataMode(UnityEditor.DataMode @stickyDataMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stickyDataMode};
            var ___result = RMSwitchToStickyDataMode_DataMode.Invoke(___genericsType, ___parameters);

            
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
