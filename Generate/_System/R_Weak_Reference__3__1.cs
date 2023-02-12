
using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.WeakReference`1
	/// </summary>
    public partial class RWeakReference<T> : RMember // where T : class
    {

		/// <summary>
		/// System.Runtime.InteropServices.GCHandle handle
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RGCHandle r_Fhandle;
		public virtual SMFrame.Editor.Refleaction.RSystem.RRuntime.RInteropServices.RGCHandle RFhandle
		{
			get
			{
				if(r_Fhandle == null)
				{
					r_Fhandle = new(this, "handle");
					r_Fhandle.SetBelong(this.instance);
				}
				return r_Fhandle;
			}
		}

		/// <summary>
		/// System.Boolean trackResurrection
		/// </summary>
		protected SMFrame.Editor.Refleaction.RSystem.RBoolean r_FtrackResurrection;
		public virtual SMFrame.Editor.Refleaction.RSystem.RBoolean RFtrackResurrection
		{
			get
			{
				if(r_FtrackResurrection == null)
				{
					r_FtrackResurrection = new(this, "trackResurrection");
					r_FtrackResurrection.SetBelong(this.instance);
				}
				return r_FtrackResurrection;
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
		/// Void SetTarget(T)
		/// </summary>
		protected RMethod r_MSetTarget_T;
		public virtual RMethod RMSetTarget_T
		{
			get
			{
				if(r_MSetTarget_T == null)
				{
					r_MSetTarget_T = new(this, "SetTarget", 0, Type.MakeGenericMethodParameter(0));
					r_MSetTarget_T.SetBelong(this.instance);
				}
				return r_MSetTarget_T;
			}
		}

		/// <summary>
		/// Boolean TryGetTarget(T ByRef)
		/// </summary>
		protected RMethod r_MTryGetTarget_Out_T;
		public virtual RMethod RMTryGetTarget_Out_T
		{
			get
			{
				if(r_MTryGetTarget_Out_T == null)
				{
					r_MTryGetTarget_Out_T = new(this, "TryGetTarget", 0, Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_MTryGetTarget_Out_T.SetBelong(this.instance);
				}
				return r_MTryGetTarget_Out_T;
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


        public RWeakReference() : base("System.WeakReference`1")
        {
        }

        public RWeakReference(System.Object instance) : base("System.WeakReference`1")
		{
            SetInstance(instance);
		}

        public RWeakReference(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RWeakReference(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo @info, System.Runtime.Serialization.StreamingContext @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RMGetObjectData_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetTarget(T @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMSetTarget_T.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TryGetTarget(out T @target)
        {
			@target = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RMTryGetTarget_Out_T.Invoke(___genericsType, ___parameters);
			@target = (T)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
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
