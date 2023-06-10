
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.WeakReference
	/// </summary>
    public partial class RWeakReference : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(System.WeakReference);
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


		/// <summary>
		/// System.Boolean isLongReference
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisLongReference;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisLongReference
		{
			get
			{
				if(r_FisLongReference == null)
				{
					r_FisLongReference = new(this, "isLongReference");
				}
				return r_FisLongReference;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.GCHandle gcHandle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RGCHandle r_FgcHandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RGCHandle RFgcHandle
		{
			get
			{
				if(r_FgcHandle == null)
				{
					r_FgcHandle = new(this, "gcHandle");
				}
				return r_FgcHandle;
			}
		}

		/// <summary>
		/// Boolean IsAlive
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PIsAlive;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPIsAlive
		{
			get
			{
				if(r_PIsAlive == null)
				{
					r_PIsAlive = new(this, "IsAlive", -1);
				}
				return r_PIsAlive;
			}
		}

		/// <summary>
		/// System.Object Target
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RObject r_PTarget;
		public virtual Hvak.Editor.Refleaction.RSystem.RObject RPTarget
		{
			get
			{
				if(r_PTarget == null)
				{
					r_PTarget = new(this, "Target", -1);
				}
				return r_PTarget;
			}
		}

		/// <summary>
		/// Boolean TrackResurrection
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PTrackResurrection;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPTrackResurrection
		{
			get
			{
				if(r_PTrackResurrection == null)
				{
					r_PTrackResurrection = new(this, "TrackResurrection", -1);
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
