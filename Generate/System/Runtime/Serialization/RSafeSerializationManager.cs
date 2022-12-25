using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RSerialization
{
	/// <summary>
	/// System.Runtime.Serialization.SafeSerializationManager
	/// </summary>
    public partial class RSafeSerializationManager : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Object] m_serializedStates
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIList<RSystem.RObject> r_m_serializedStates;
		public virtual RSystem.RCollections.RGeneric.RIList<RSystem.RObject> Rm_serializedStates
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
		/// System.Runtime.Serialization.SerializationInfo m_savedSerializationInfo
		/// </summary>
		protected RSystem.RRuntime.RSerialization.RSerializationInfo r_m_savedSerializationInfo;
		public virtual RSystem.RRuntime.RSerialization.RSerializationInfo Rm_savedSerializationInfo
		{
			get
			{
				if(r_m_savedSerializationInfo == null)
				{
					r_m_savedSerializationInfo = new(this, "m_savedSerializationInfo");
					r_m_savedSerializationInfo.SetBelong(this.instance);
				}
				return r_m_savedSerializationInfo;
			}
		}

		/// <summary>
		/// System.Object m_realObject
		/// </summary>
		protected RSystem.RObject r_m_realObject;
		public virtual RSystem.RObject Rm_realObject
		{
			get
			{
				if(r_m_realObject == null)
				{
					r_m_realObject = new(this, "m_realObject");
					r_m_realObject.SetBelong(this.instance);
				}
				return r_m_realObject;
			}
		}

		/// <summary>
		/// System.RuntimeType m_realType
		/// </summary>
		protected RSystem.RRuntimeType r_m_realType;
		public virtual RSystem.RRuntimeType Rm_realType
		{
			get
			{
				if(r_m_realType == null)
				{
					r_m_realType = new(this, "m_realType");
					r_m_realType.SetBelong(this.instance);
				}
				return r_m_realType;
			}
		}

		/// <summary>
		/// System.EventHandler`1[System.Runtime.Serialization.SafeSerializationEventArgs] SerializeObjectState
		/// </summary>
		protected RSystem.REventHandler<RSystem.RRuntime.RSerialization.RSafeSerializationEventArgs> r_SerializeObjectState;
		public virtual RSystem.REventHandler<RSystem.RRuntime.RSerialization.RSafeSerializationEventArgs> RSerializeObjectState
		{
			get
			{
				if(r_SerializeObjectState == null)
				{
					r_SerializeObjectState = new(this, "SerializeObjectState");
					r_SerializeObjectState.SetBelong(this.instance);
				}
				return r_SerializeObjectState;
			}
		}

		/// <summary>
		/// System.String RealTypeSerializationName
		/// </summary>
		protected static RField r_RealTypeSerializationName;
		public static RField RealTypeSerializationName
		{
			get
			{
				if(r_RealTypeSerializationName == null)
				{
					r_RealTypeSerializationName = new( ReleactionUtils.GetType("System.Runtime.Serialization.SafeSerializationManager"), "RealTypeSerializationName");
					r_RealTypeSerializationName.SetBelong(null);
				}
				return r_RealTypeSerializationName;
			}
		}

		/// <summary>
		/// Boolean IsActive
		/// </summary>
		protected RProperty r_IsActive;
		public virtual RProperty RIsActive
		{
			get
			{
				if(r_IsActive == null)
				{
					r_IsActive = new(this, "IsActive", -1);
					r_IsActive.SetBelong(this.instance);
				}
				return r_IsActive;
			}
		}

		/// <summary>
		/// Void CompleteSerialization(System.Object, System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RCompleteSerialization_Object_SerializationInfo_StreamingContext;
		public virtual RMethod RCompleteSerialization_Object_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_RCompleteSerialization_Object_SerializationInfo_StreamingContext == null)
				{
					r_RCompleteSerialization_Object_SerializationInfo_StreamingContext = new(this, "CompleteSerialization", 0, typeof(System.Object), typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_RCompleteSerialization_Object_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_RCompleteSerialization_Object_SerializationInfo_StreamingContext;
			}
		}

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

		/// <summary>
		/// Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext = new(this, "System.Runtime.Serialization.ISerializable.GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// System.Object System.Runtime.Serialization.IObjectReference.GetRealObject(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RSystem__0__Runtime__0__Serialization__0__IObjectReference__0__GetRealObject_StreamingContext;
		public virtual RMethod RSystem__0__Runtime__0__Serialization__0__IObjectReference__0__GetRealObject_StreamingContext
		{
			get
			{
				if(r_RSystem__0__Runtime__0__Serialization__0__IObjectReference__0__GetRealObject_StreamingContext == null)
				{
					r_RSystem__0__Runtime__0__Serialization__0__IObjectReference__0__GetRealObject_StreamingContext = new(this, "System.Runtime.Serialization.IObjectReference.GetRealObject", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_RSystem__0__Runtime__0__Serialization__0__IObjectReference__0__GetRealObject_StreamingContext.SetBelong(this.instance);
				}
				return r_RSystem__0__Runtime__0__Serialization__0__IObjectReference__0__GetRealObject_StreamingContext;
			}
		}

		/// <summary>
		/// Void OnDeserialized(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_ROnDeserialized_StreamingContext;
		public virtual RMethod ROnDeserialized_StreamingContext
		{
			get
			{
				if(r_ROnDeserialized_StreamingContext == null)
				{
					r_ROnDeserialized_StreamingContext = new(this, "OnDeserialized", 0, typeof(System.Runtime.Serialization.StreamingContext));
					r_ROnDeserialized_StreamingContext.SetBelong(this.instance);
				}
				return r_ROnDeserialized_StreamingContext;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}


        public RSafeSerializationManager() : base("System.Runtime.Serialization.SafeSerializationManager")
        {
        }

        public RSafeSerializationManager(System.Object instance) : base("System.Runtime.Serialization.SafeSerializationManager")
		{
            SetInstance(instance);
		}

        public RSafeSerializationManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSafeSerializationManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void CompleteSerialization(System.Object  @serializedObject, System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serializedObject, @info, @context};
            var ___result = RCompleteSerialization_Object_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CompleteDeserialization(System.Object  @deserializedObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@deserializedObject};
            var ___result = RCompleteDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RSystem__0__Runtime__0__Serialization__0__ISerializable__0__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object System__0__Runtime__0__Serialization__0__IObjectReference__0__GetRealObject(System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context};
            var ___result = RSystem__0__Runtime__0__Serialization__0__IObjectReference__0__GetRealObject_StreamingContext.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void OnDeserialized(System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context};
            var ___result = ROnDeserialized_StreamingContext.Invoke(___genericsType, ___parameters);

            
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
