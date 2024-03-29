
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// System.Runtime.Serialization.ISafeSerializationData
	/// </summary>
    public partial class RISafeSerializationData : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.Runtime.Serialization.ISafeSerializationData);
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


		/// <summary>
		/// Void CompleteDeserialization(System.Object)
		/// </summary>
		protected RMethod r_MCompleteDeserialization_Object;
		public virtual RMethod RMCompleteDeserialization_Object
		{
			get
			{
				if(r_MCompleteDeserialization_Object == null)
				{
					r_MCompleteDeserialization_Object = new(this, "CompleteDeserialization", 0, typeof(System.Object));
				}
				return r_MCompleteDeserialization_Object;
			}
		}


        public virtual void CompleteDeserialization(System.Object @deserialized)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@deserialized};
            var ___result = RMCompleteDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


    }
}
