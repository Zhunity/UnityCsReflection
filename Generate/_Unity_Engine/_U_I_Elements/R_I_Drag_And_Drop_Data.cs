
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IDragAndDropData
	/// </summary>
    public partial class RIDragAndDropData : RMember //
    {

		/// <summary>
		/// System.Object userData
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RObject r_PuserData;
		public virtual SMFrame.Editor.Refleaction.RSystem.RObject RPuserData
		{
			get
			{
				if(r_PuserData == null)
				{
					r_PuserData = new(this, "userData", -1);
					r_PuserData.SetBelong(this.instance);
				}
				return r_PuserData;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IEnumerable`1[UnityEngine.Object] unityObjectReferences
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEngine.RObject> r_PunityObjectReferences;
		public virtual SMFrame.Editor.Refleaction.RSystem.RCollections.RGeneric.RIEnumerable<SMFrame.Editor.Refleaction.RUnityEngine.RObject> RPunityObjectReferences
		{
			get
			{
				if(r_PunityObjectReferences == null)
				{
					r_PunityObjectReferences = new(this, "unityObjectReferences", -1);
					r_PunityObjectReferences.SetBelong(this.instance);
				}
				return r_PunityObjectReferences;
			}
		}

		/// <summary>
		/// System.Object GetGenericData(System.String)
		/// </summary>
		protected RMethod r_MGetGenericData_String;
		public virtual RMethod RMGetGenericData_String
		{
			get
			{
				if(r_MGetGenericData_String == null)
				{
					r_MGetGenericData_String = new(this, "GetGenericData", 0, typeof(System.String));
					r_MGetGenericData_String.SetBelong(this.instance);
				}
				return r_MGetGenericData_String;
			}
		}


        public RIDragAndDropData() : base("UnityEngine.UIElements.IDragAndDropData")
        {
        }

        public RIDragAndDropData(System.Object instance) : base("UnityEngine.UIElements.IDragAndDropData")
		{
            SetInstance(instance);
		}

        public RIDragAndDropData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIDragAndDropData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object GetGenericData(System.String @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@key};
            var ___result = RMGetGenericData_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
