using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.DataModeController
	/// </summary>
    public partial class RDataModeController : RMember //
    {

		/// <summary>
		/// UnityEditor.DataMode[] k_DefaultModes
		/// </summary>
		protected static RFieldArray<RField> r_k_DefaultModes;
		public static RFieldArray<RField> Rk_DefaultModes
		{
			get
			{
				if(r_k_DefaultModes == null)
				{
					r_k_DefaultModes = new( ReflectionUtils.GetType("UnityEditor.DataModeController"), "k_DefaultModes");
					r_k_DefaultModes.SetBelong(null);
				}
				return r_k_DefaultModes;
			}
		}

		/// <summary>
		/// System.Action`1[UnityEditor.DataModeChangeEventArgs] dataModeChanged
		/// </summary>
		protected RSystem.RAction<RUnityEditor.RDataModeChangeEventArgs> r_dataModeChanged;
		public virtual RSystem.RAction<RUnityEditor.RDataModeChangeEventArgs> RdataModeChanged
		{
			get
			{
				if(r_dataModeChanged == null)
				{
					r_dataModeChanged = new(this, "dataModeChanged");
					r_dataModeChanged.SetBelong(this.instance);
				}
				return r_dataModeChanged;
			}
		}

		/// <summary>
		/// UnityEditor.DataMode m_DataMode
		/// </summary>
		protected RField r_m_DataMode;
		public virtual RField Rm_DataMode
		{
			get
			{
				if(r_m_DataMode == null)
				{
					r_m_DataMode = new(this, "m_DataMode");
					r_m_DataMode.SetBelong(this.instance);
				}
				return r_m_DataMode;
			}
		}

		/// <summary>
		/// UnityEditor.DataMode m_PreferredDataMode
		/// </summary>
		protected RField r_m_PreferredDataMode;
		public virtual RField Rm_PreferredDataMode
		{
			get
			{
				if(r_m_PreferredDataMode == null)
				{
					r_m_PreferredDataMode = new(this, "m_PreferredDataMode");
					r_m_PreferredDataMode.SetBelong(this.instance);
				}
				return r_m_PreferredDataMode;
			}
		}

		/// <summary>
		/// UnityEditor.DataMode[] m_SupportedDataModes
		/// </summary>
		protected RFieldArray<RField> r_m_SupportedDataModes;
		public virtual RFieldArray<RField> Rm_SupportedDataModes
		{
			get
			{
				if(r_m_SupportedDataModes == null)
				{
					r_m_SupportedDataModes = new(this, "m_SupportedDataModes");
					r_m_SupportedDataModes.SetBelong(this.instance);
				}
				return r_m_SupportedDataModes;
			}
		}

		/// <summary>
		/// System.Boolean isAutomatic
		/// </summary>
		protected RField r_isAutomatic;
		public virtual RField RisAutomatic
		{
			get
			{
				if(r_isAutomatic == null)
				{
					r_isAutomatic = new(this, "isAutomatic");
					r_isAutomatic.SetBelong(this.instance);
				}
				return r_isAutomatic;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEditor.DataMode] m_DataModeSanitizationCache
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_DataModeSanitizationCache;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_DataModeSanitizationCache
		{
			get
			{
				if(r_m_DataModeSanitizationCache == null)
				{
					r_m_DataModeSanitizationCache = new(this, "m_DataModeSanitizationCache");
					r_m_DataModeSanitizationCache.SetBelong(this.instance);
				}
				return r_m_DataModeSanitizationCache;
			}
		}

		/// <summary>
		/// UnityEditor.DataMode dataMode
		/// </summary>
		protected RProperty r_dataMode;
		public virtual RProperty RdataMode
		{
			get
			{
				if(r_dataMode == null)
				{
					r_dataMode = new(this, "dataMode", -1);
					r_dataMode.SetBelong(this.instance);
				}
				return r_dataMode;
			}
		}

		/// <summary>
		/// UnityEditor.DataMode preferredDataMode
		/// </summary>
		protected RProperty r_preferredDataMode;
		public virtual RProperty RpreferredDataMode
		{
			get
			{
				if(r_preferredDataMode == null)
				{
					r_preferredDataMode = new(this, "preferredDataMode", -1);
					r_preferredDataMode.SetBelong(this.instance);
				}
				return r_preferredDataMode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[UnityEditor.DataMode] supportedDataModes
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIList<RProperty> r_supportedDataModes;
		public virtual RSystem.RCollections.RGeneric.RIList<RProperty> RsupportedDataModes
		{
			get
			{
				if(r_supportedDataModes == null)
				{
					r_supportedDataModes = new(this, "supportedDataModes", -1);
					r_supportedDataModes.SetBelong(this.instance);
				}
				return r_supportedDataModes;
			}
		}

		/// <summary>
		/// Void UpdateSupportedDataModes(System.Collections.Generic.IList`1[UnityEditor.DataMode], UnityEditor.DataMode)
		/// </summary>
		protected RMethod r_UpdateSupportedDataModes_IList_d_DataMode_p__DataMode;
		public virtual RMethod RUpdateSupportedDataModes_IList_d_DataMode_p__DataMode
		{
			get
			{
				if(r_UpdateSupportedDataModes_IList_d_DataMode_p__DataMode == null)
				{
					r_UpdateSupportedDataModes_IList_d_DataMode_p__DataMode = new(this, "UpdateSupportedDataModes", 0, typeof(System.Collections.Generic.IList<>).MakeGenericType(typeof(UnityEditor.DataMode)), typeof(UnityEditor.DataMode));
					r_UpdateSupportedDataModes_IList_d_DataMode_p__DataMode.SetBelong(this.instance);
				}
				return r_UpdateSupportedDataModes_IList_d_DataMode_p__DataMode;
			}
		}

		/// <summary>
		/// Void SanitizeSupportedDataModesList(System.Collections.Generic.IReadOnlyList`1[UnityEditor.DataMode], System.Collections.Generic.List`1[UnityEditor.DataMode])
		/// </summary>
		protected static RMethod r_SanitizeSupportedDataModesList_IReadOnlyList_d_DataMode_p__List_d_DataMode_p_;
		public static RMethod RSanitizeSupportedDataModesList_IReadOnlyList_d_DataMode_p__List_d_DataMode_p_
		{
			get
			{
				if(r_SanitizeSupportedDataModesList_IReadOnlyList_d_DataMode_p__List_d_DataMode_p_ == null)
				{
					r_SanitizeSupportedDataModesList_IReadOnlyList_d_DataMode_p__List_d_DataMode_p_ = new( ReflectionUtils.GetType("UnityEditor.DataModeController"), "SanitizeSupportedDataModesList", 0, typeof(System.Collections.Generic.IReadOnlyList<>).MakeGenericType(typeof(UnityEditor.DataMode)), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEditor.DataMode)));
					r_SanitizeSupportedDataModesList_IReadOnlyList_d_DataMode_p__List_d_DataMode_p_.SetBelong(null);
				}
				return r_SanitizeSupportedDataModesList_IReadOnlyList_d_DataMode_p__List_d_DataMode_p_;
			}
		}

		/// <summary>
		/// Boolean ShouldDrawDataModesSwitch()
		/// </summary>
		protected RMethod r_ShouldDrawDataModesSwitch;
		public virtual RMethod RShouldDrawDataModesSwitch
		{
			get
			{
				if(r_ShouldDrawDataModesSwitch == null)
				{
					r_ShouldDrawDataModesSwitch = new(this, "ShouldDrawDataModesSwitch", 0);
					r_ShouldDrawDataModesSwitch.SetBelong(this.instance);
				}
				return r_ShouldDrawDataModesSwitch;
			}
		}

		/// <summary>
		/// Boolean TryChangeDataMode(UnityEditor.DataMode)
		/// </summary>
		protected RMethod r_TryChangeDataMode_DataMode;
		public virtual RMethod RTryChangeDataMode_DataMode
		{
			get
			{
				if(r_TryChangeDataMode_DataMode == null)
				{
					r_TryChangeDataMode_DataMode = new(this, "TryChangeDataMode", 0, typeof(UnityEditor.DataMode));
					r_TryChangeDataMode_DataMode.SetBelong(this.instance);
				}
				return r_TryChangeDataMode_DataMode;
			}
		}

		/// <summary>
		/// Void SwitchToAutomatic()
		/// </summary>
		protected RMethod r_SwitchToAutomatic;
		public virtual RMethod RSwitchToAutomatic
		{
			get
			{
				if(r_SwitchToAutomatic == null)
				{
					r_SwitchToAutomatic = new(this, "SwitchToAutomatic", 0);
					r_SwitchToAutomatic.SetBelong(this.instance);
				}
				return r_SwitchToAutomatic;
			}
		}

		/// <summary>
		/// Void SwitchToStickyDataMode(UnityEditor.DataMode)
		/// </summary>
		protected RMethod r_SwitchToStickyDataMode_DataMode;
		public virtual RMethod RSwitchToStickyDataMode_DataMode
		{
			get
			{
				if(r_SwitchToStickyDataMode_DataMode == null)
				{
					r_SwitchToStickyDataMode_DataMode = new(this, "SwitchToStickyDataMode", 0, typeof(UnityEditor.DataMode));
					r_SwitchToStickyDataMode_DataMode.SetBelong(this.instance);
				}
				return r_SwitchToStickyDataMode_DataMode;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
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

        public virtual void UpdateSupportedDataModes(System.Collections.Generic.IList<UnityEditor.DataMode>  @supported, UnityEditor.DataMode  @preferred)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@supported, @preferred};
            var ___result = RUpdateSupportedDataModes_IList_d_DataMode_p__DataMode.Invoke(___genericsType, ___parameters);

            
        }


        public static void SanitizeSupportedDataModesList(System.Collections.Generic.IReadOnlyList<UnityEditor.DataMode>  @originalList, System.Collections.Generic.List<UnityEditor.DataMode>  @sanitizedList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@originalList, @sanitizedList};
            var ___result = RSanitizeSupportedDataModesList_IReadOnlyList_d_DataMode_p__List_d_DataMode_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ShouldDrawDataModesSwitch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShouldDrawDataModesSwitch.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryChangeDataMode(UnityEditor.DataMode  @newDataMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newDataMode};
            var ___result = RTryChangeDataMode_DataMode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SwitchToAutomatic()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSwitchToAutomatic.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SwitchToStickyDataMode(UnityEditor.DataMode  @stickyDataMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stickyDataMode};
            var ___result = RSwitchToStickyDataMode_DataMode.Invoke(___genericsType, ___parameters);

            
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
