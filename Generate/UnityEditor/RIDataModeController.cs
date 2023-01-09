using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEditor
{
	/// <summary>
	/// UnityEditor.IDataModeController
	/// </summary>
    public partial class RIDataModeController : RMember //
    {

		/// <summary>
		/// System.Action`1[UnityEditor.DataModeChangeEventArgs] dataModeChanged
		/// </summary>
		protected REvent r_dataModeChanged;
		public virtual REvent RdataModeChanged
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


        public RIDataModeController() : base("UnityEditor.IDataModeController")
        {
        }

        public RIDataModeController(System.Object instance) : base("UnityEditor.IDataModeController")
		{
            SetInstance(instance);
		}

        public RIDataModeController(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIDataModeController(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void UpdateSupportedDataModes(System.Collections.Generic.IList<UnityEditor.DataMode> @supportedDataMode, UnityEditor.DataMode @preferredDataMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@supportedDataMode, @preferredDataMode};
            var ___result = RUpdateSupportedDataModes_IList_d_DataMode_p__DataMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryChangeDataMode(UnityEditor.DataMode @newDataMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newDataMode};
            var ___result = RTryChangeDataMode_DataMode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


    }
}
