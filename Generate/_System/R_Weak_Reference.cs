
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
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_FisLongReference;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFisLongReference
		{
			get
			{
				if(r_FisLongReference == null)
				{
					r_FisLongReference = new(this, "isLongReference");
					r_FisLongReference.SetBelong(this.instance);
				}
				return r_FisLongReference;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.GCHandle gcHandle
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RGCHandle r_FgcHandle;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RGCHandle RFgcHandle
		{
			get
			{
				if(r_FgcHandle == null)
				{
					r_FgcHandle = new(this, "gcHandle");
					r_FgcHandle.SetBelong(this.instance);
				}
				return r_FgcHandle;
			}
		}

		/// <summary>
		/// Boolean IsAlive
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PIsAlive;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPIsAlive
		{
			get
			{
				if(r_PIsAlive == null)
				{
					r_PIsAlive = new(this, "IsAlive", -1);
					r_PIsAlive.SetBelong(this.instance);
				}
				return r_PIsAlive;
			}
		}

		/// <summary>
		/// System.Object Target
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RObject r_PTarget;
		public virtual SMFrame.Editor.Refleaction.RSystem.RObject RPTarget
		{
			get
			{
				if(r_PTarget == null)
				{
					r_PTarget = new(this, "Target", -1);
					r_PTarget.SetBelong(this.instance);
				}
				return r_PTarget;
			}
		}

		/// <summary>
		/// Boolean TrackResurrection
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_PTrackResurrection;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RPTrackResurrection
		{
			get
			{
				if(r_PTrackResurrection == null)
				{
					r_PTrackResurrection = new(this, "TrackResurrection", -1);
					r_PTrackResurrection.SetBelong(this.instance);
				}
				return r_PTrackResurrection;
			}
		}

		/// <summary>
		/// Void AllocateHandle(System.Object)
		/// </summary>
		protected RMethod r_MAllocateHandle_Object;
		public virtual RMethod RMAllocateHandle_Object
		{
			get
			{
				if(r_MAllocateHandle_Object == null)
				{
					r_MAllocateHandle_Object = new(this, "AllocateHandle", 0, typeof(System.Object));
					r_MAllocateHandle_Object.SetBelong(this.instance);
				}
				return r_MAllocateHandle_Object;
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
					r_MFinalize.SetBelong(this.instance);
				}
				return r_MFinalize;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_MGetObjectData_SerializationInfo_StreamingContext;
		public virtual RMethod RMGetObjectData_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_MGetObjectData_SerializationInfo_StreamingContext == null)
				{
					r_MGetObjectData_SerializationInfo_StreamingContext = new(this, "GetObjectData", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_MGetObjectData_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_MGetObjectData_SerializationInfo_StreamingContext;
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
					r_MEquals_Object.SetBelong(this.instance);
				}
				return r_MEquals_Object;
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
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
            var ___result = RMAllocateHandle_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
