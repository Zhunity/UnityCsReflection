using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.WeakReference
	/// </summary>
    public partial class RWeakReference : RMember //
    {

		/// <summary>
		/// System.Boolean isLongReference
		/// </summary>
		protected RSystem.RBoolean r_isLongReference;
		public virtual RSystem.RBoolean RisLongReference
		{
			get
			{
				if(r_isLongReference == null)
				{
					r_isLongReference = new(this, "isLongReference");
					r_isLongReference.SetBelong(this.instance);
				}
				return r_isLongReference;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.GCHandle gcHandle
		/// </summary>
		protected RSystem.RRuntime.RInteropServices.RGCHandle r_gcHandle;
		public virtual RSystem.RRuntime.RInteropServices.RGCHandle RgcHandle
		{
			get
			{
				if(r_gcHandle == null)
				{
					r_gcHandle = new(this, "gcHandle");
					r_gcHandle.SetBelong(this.instance);
				}
				return r_gcHandle;
			}
		}

		/// <summary>
		/// Boolean IsAlive
		/// </summary>
		protected RSystem.RBoolean r_IsAlive;
		public virtual RSystem.RBoolean RIsAlive
		{
			get
			{
				if(r_IsAlive == null)
				{
					r_IsAlive = new(this, "IsAlive", -1);
					r_IsAlive.SetBelong(this.instance);
				}
				return r_IsAlive;
			}
		}

		/// <summary>
		/// System.Object Target
		/// </summary>
		protected RSystem.RObject r_Target;
		public virtual RSystem.RObject RTarget
		{
			get
			{
				if(r_Target == null)
				{
					r_Target = new(this, "Target", -1);
					r_Target.SetBelong(this.instance);
				}
				return r_Target;
			}
		}

		/// <summary>
		/// Boolean TrackResurrection
		/// </summary>
		protected RSystem.RBoolean r_TrackResurrection;
		public virtual RSystem.RBoolean RTrackResurrection
		{
			get
			{
				if(r_TrackResurrection == null)
				{
					r_TrackResurrection = new(this, "TrackResurrection", -1);
					r_TrackResurrection.SetBelong(this.instance);
				}
				return r_TrackResurrection;
			}
		}

		/// <summary>
		/// Void AllocateHandle(System.Object)
		/// </summary>
		protected RMethod r_AllocateHandle_Object;
		public virtual RMethod RAllocateHandle_Object
		{
			get
			{
				if(r_AllocateHandle_Object == null)
				{
					r_AllocateHandle_Object = new(this, "AllocateHandle", 0, typeof(System.Object));
					r_AllocateHandle_Object.SetBelong(this.instance);
				}
				return r_AllocateHandle_Object;
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
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_GetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_GetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_GetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_GetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_GetObjectData_SerializationInfo_StreamingContext;
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


        public RWeakReference() : base("System.WeakReference")
        {
        }

        public RWeakReference(System.Object instance) : base("System.WeakReference")
		{
            SetInstance(instance);
		}

        public RWeakReference(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RWeakReference(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AllocateHandle(System.Object @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RAllocateHandle_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
