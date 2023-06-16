
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEditor
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEditor.IDataModeController
	/// </summary>
    public partial class RIDataModeController : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEditor.IDataModeController);
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
				}
				return r_EdataModeChanged;
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
				}
				return r_PdataMode;
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
					r_MUpdateSupportedDataModes_IList_d_DataMode_p__DataMode = new(this, "UpdateSupportedDataModes", 0,  ReflectionUtils.GetType("System.Collections.Generic.IList`1").MakeGenericType(typeof(UnityEditor.DataMode)), typeof(UnityEditor.DataMode));
				}
				return r_MUpdateSupportedDataModes_IList_d_DataMode_p__DataMode;
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
				}
				return r_MTryChangeDataMode_DataMode;
			}
		}


        public virtual void UpdateSupportedDataModes(System.Collections.Generic.IList<UnityEditor.DataMode> @supportedDataMode, UnityEditor.DataMode @preferredDataMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@supportedDataMode, @preferredDataMode};
            var ___result = RMUpdateSupportedDataModes_IList_d_DataMode_p__DataMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryChangeDataMode(UnityEditor.DataMode @newDataMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newDataMode};
            var ___result = RMTryChangeDataMode_DataMode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


    }
}
