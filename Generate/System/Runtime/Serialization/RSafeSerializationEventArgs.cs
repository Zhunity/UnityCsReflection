using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RSerialization
{
	/// <summary>
	/// System.Runtime.Serialization.SafeSerializationEventArgs
	/// </summary>
    public partial class RSafeSerializationEventArgs : RMember //
    {

		/// <summary>
		/// System.Runtime.Serialization.StreamingContext m_streamingContext
		/// </summary>
		protected RSystem.RRuntime.RSerialization.RStreamingContext r_m_streamingContext;
		public virtual RSystem.RRuntime.RSerialization.RStreamingContext Rm_streamingContext
		{
			get
			{
				if(r_m_streamingContext == null)
				{
					r_m_streamingContext = new(this, "m_streamingContext");
					r_m_streamingContext.SetBelong(this.instance);
				}
				return r_m_streamingContext;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Object] m_serializedStates
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RObject> r_m_serializedStates;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RObject> Rm_serializedStates
		{
			get
			{
				if(r_m_serializedStates == null)
				{
					r_m_serializedStates = new(this, "m_serializedStates");
					r_m_serializedStates.SetBelong(this.instance);
				}
				return r_m_serializedStates;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Object] SerializedStates
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIList<RSystem.RObject> r_SerializedStates;
		public virtual RSystem.RCollections.RGeneric.RIList<RSystem.RObject> RSerializedStates
		{
			get
			{
				if(r_SerializedStates == null)
				{
					r_SerializedStates = new(this, "SerializedStates", -1);
					r_SerializedStates.SetBelong(this.instance);
				}
				return r_SerializedStates;
			}
		}

		/// <summary>
		/// System.Runtime.Serialization.StreamingContext StreamingContext
		/// </summary>
		protected RSystem.RRuntime.RSerialization.RStreamingContext r_StreamingContext;
		public virtual RSystem.RRuntime.RSerialization.RStreamingContext RStreamingContext
		{
			get
			{
				if(r_StreamingContext == null)
				{
					r_StreamingContext = new(this, "StreamingContext", -1);
					r_StreamingContext.SetBelong(this.instance);
				}
				return r_StreamingContext;
			}
		}

		/// <summary>
		/// Void AddSerializedState(System.Runtime.Serialization.ISafeSerializationData)
		/// </summary>
		protected RMethod r_AddSerializedState_ISafeSerializationData;
		public virtual RMethod RAddSerializedState_ISafeSerializationData
		{
			get
			{
				if(r_AddSerializedState_ISafeSerializationData == null)
				{
					r_AddSerializedState_ISafeSerializationData = new(this, "AddSerializedState", 0, typeof(System.Runtime.Serialization.ISafeSerializationData));
					r_AddSerializedState_ISafeSerializationData.SetBelong(this.instance);
				}
				return r_AddSerializedState_ISafeSerializationData;
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


        public RSafeSerializationEventArgs() : base("System.Runtime.Serialization.SafeSerializationEventArgs")
        {
        }

        public RSafeSerializationEventArgs(System.Object instance) : base("System.Runtime.Serialization.SafeSerializationEventArgs")
		{
            SetInstance(instance);
		}

        public RSafeSerializationEventArgs(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSafeSerializationEventArgs(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AddSerializedState(System.Runtime.Serialization.ISafeSerializationData  @serializedState)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serializedState};
            var ___result = RAddSerializedState_ISafeSerializationData.Invoke(___genericsType, ___parameters);

            
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
