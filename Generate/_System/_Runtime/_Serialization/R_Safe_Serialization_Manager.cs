
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization
{
	/// <summary>
	/// System.Runtime.Serialization.SafeSerializationManager
	/// </summary>
    public partial class RSafeSerializationManager : RMember //
    {

		/// <summary>
		/// System.EventHandler`1[System.Runtime.Serialization.SafeSerializationEventArgs] SerializeObjectState
		/// </summary>
		protected REvent r_ESerializeObjectState;
		public virtual REvent RESerializeObjectState
		{
			get
			{
				if(r_ESerializeObjectState == null)
				{
					r_ESerializeObjectState = new(this, "SerializeObjectState");
				}
				return r_ESerializeObjectState;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.Object] m_serializedStates
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<Hvak.Editor.Refleaction.RSystem.RObject> r_Fm_serializedStates;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RIList<Hvak.Editor.Refleaction.RSystem.RObject> RFm_serializedStates
		{
			get
			{
				if(r_Fm_serializedStates == null)
				{
					r_Fm_serializedStates = new(this, "m_serializedStates");
				}
				return r_Fm_serializedStates;
			}
		}

		/// <summary>
		/// System.Runtime.Serialization.SerializationInfo m_savedSerializationInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RSerializationInfo r_Fm_savedSerializationInfo;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RSerializationInfo RFm_savedSerializationInfo
		{
			get
			{
				if(r_Fm_savedSerializationInfo == null)
				{
					r_Fm_savedSerializationInfo = new(this, "m_savedSerializationInfo");
				}
				return r_Fm_savedSerializationInfo;
			}
		}

		/// <summary>
		/// System.Object m_realObject
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_Fm_realObject;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RFm_realObject
		{
			get
			{
				if(r_Fm_realObject == null)
				{
					r_Fm_realObject = new(this, "m_realObject");
				}
				return r_Fm_realObject;
			}
		}

		/// <summary>
		/// System.RuntimeType m_realType
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntimeType r_Fm_realType;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntimeType RFm_realType
		{
			get
			{
				if(r_Fm_realType == null)
				{
					r_Fm_realType = new(this, "m_realType");
				}
				return r_Fm_realType;
			}
		}

		/// <summary>
		/// System.EventHandler`1[System.Runtime.Serialization.SafeSerializationEventArgs] SerializeObjectState
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.REventHandler<Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RSafeSerializationEventArgs> r_FSerializeObjectState;
		public virtual Hvak.Editor.Refleaction.RSystem.REventHandler<Hvak.Editor.Refleaction.RSystem.RRuntime.RSerialization.RSafeSerializationEventArgs> RFSerializeObjectState
		{
			get
			{
				if(r_FSerializeObjectState == null)
				{
					r_FSerializeObjectState = new(this, "SerializeObjectState");
				}
				return r_FSerializeObjectState;
			}
		}

		/// <summary>
		/// System.String RealTypeSerializationName
		/// </summary>
		protected static Hvak.Editor.Refleaction.RSystem.RString r_FRealTypeSerializationName;
		public static Hvak.Editor.Refleaction.RSystem.RString RFRealTypeSerializationName
		{
			get
			{
				if(r_FRealTypeSerializationName == null)
				{
					r_FRealTypeSerializationName = new( ReflectionUtils.GetType("System.Runtime.Serialization.SafeSerializationManager"), "RealTypeSerializationName");
				}
				return r_FRealTypeSerializationName;
			}
		}

		/// <summary>
		/// Boolean IsActive
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsActive;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsActive
		{
			get
			{
				if(r_PIsActive == null)
				{
					r_PIsActive = new(this, "IsActive", -1);
				}
				return r_PIsActive;
			}
		}

		/// <summary>
		/// Void CompleteSerialization(System.Object, System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MCompleteSerialization_Object_SerializationInfo_StreamingContext;
		public virtual RMethod RMCompleteSerialization_Object_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_MCompleteSerialization_Object_SerializationInfo_StreamingContext == null)
				{
					r_MCompleteSerialization_Object_SerializationInfo_StreamingContext = new(this, "CompleteSerialization", 0, typeof(System.Object), typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
				}
				return r_MCompleteSerialization_Object_SerializationInfo_StreamingContext;
			}
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

		/// <summary>
		/// Void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RMSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext = new(this, "System.Runtime.Serialization.ISerializable.GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
				}
				return r_MSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// System.Object System.Runtime.Serialization.IObjectReference.GetRealObject(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MSystem__2__Runtime__2__Serialization__2__IObjectReference__2__GetRealObject_StreamingContext;
		public virtual RMethod RMSystem__2__Runtime__2__Serialization__2__IObjectReference__2__GetRealObject_StreamingContext
		{
			get
			{
				if(r_MSystem__2__Runtime__2__Serialization__2__IObjectReference__2__GetRealObject_StreamingContext == null)
				{
					r_MSystem__2__Runtime__2__Serialization__2__IObjectReference__2__GetRealObject_StreamingContext = new(this, "System.Runtime.Serialization.IObjectReference.GetRealObject", 0, typeof(System.Runtime.Serialization.StreamingContext));
				}
				return r_MSystem__2__Runtime__2__Serialization__2__IObjectReference__2__GetRealObject_StreamingContext;
			}
		}

		/// <summary>
		/// Void OnDeserialized(System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MOnDeserialized_StreamingContext;
		public virtual RMethod RMOnDeserialized_StreamingContext
		{
			get
			{
				if(r_MOnDeserialized_StreamingContext == null)
				{
					r_MOnDeserialized_StreamingContext = new(this, "OnDeserialized", 0, typeof(System.Runtime.Serialization.StreamingContext));
				}
				return r_MOnDeserialized_StreamingContext;
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
				}
				return r_MToString;
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

        public virtual void CompleteSerialization(System.Object @serializedObject, System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serializedObject, @info, @context};
            var ___result = RMCompleteSerialization_Object_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CompleteDeserialization(System.Object @deserializedObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@deserializedObject};
            var ___result = RMCompleteDeserialization_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMSystem__2__Runtime__2__Serialization__2__ISerializable__2__GetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object System__2__Runtime__2__Serialization__2__IObjectReference__2__GetRealObject(System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context};
            var ___result = RMSystem__2__Runtime__2__Serialization__2__IObjectReference__2__GetRealObject_StreamingContext.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void OnDeserialized(System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context};
            var ___result = RMOnDeserialized_StreamingContext.Invoke(___genericsType, ___parameters);

            
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
