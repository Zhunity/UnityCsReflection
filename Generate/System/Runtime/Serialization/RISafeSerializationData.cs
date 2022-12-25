using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RSerialization
{
	/// <summary>
	/// System.Runtime.Serialization.ISafeSerializationData
	/// </summary>
    public partial class RISafeSerializationData : RMember //
    {

		/// <summary>
		/// Void CompleteDeserialization(System.Object)
		/// </summary>
		protected RMethod r_RCompleteDeserialization_Object;
		public virtual RMethod RCompleteDeserialization_Object
		{
			get
			{
				if(r_RCompleteDeserialization_Object == null)
				{
					r_RCompleteDeserialization_Object = new(this, "CompleteDeserialization", 0, typeof(System.Object));
					r_RCompleteDeserialization_Object.SetBelong(this.instance);
				}
				return r_RCompleteDeserialization_Object;
			}
		}


        public RISafeSerializationData() : base("System.Runtime.Serialization.ISafeSerializationData")
        {
        }

        public RISafeSerializationData(System.Object instance) : base("System.Runtime.Serialization.ISafeSerializationData")
		{
            SetInstance(instance);
		}

        public RISafeSerializationData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RISafeSerializationData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void CompleteDeserialization(System.Object  @deserialized)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@deserialized};
            var ___result = RCompleteDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


    }
}
