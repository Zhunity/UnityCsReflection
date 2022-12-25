using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnity.RProfiling
{
	/// <summary>
	/// Unity.Profiling.ProfilerMarker
	/// </summary>
    public partial class RProfilerMarker : RMember //
    {

		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected RField r_m_Ptr;
		public virtual RField Rm_Ptr
		{
			get
			{
				if(r_m_Ptr == null)
				{
					r_m_Ptr = new(this, "m_Ptr");
					r_m_Ptr.SetBelong(this.instance);
				}
				return r_m_Ptr;
			}
		}

		/// <summary>
		/// IntPtr Handle
		/// </summary>
		protected RProperty r_Handle;
		public virtual RProperty RHandle
		{
			get
			{
				if(r_Handle == null)
				{
					r_Handle = new(this, "Handle", -1);
					r_Handle.SetBelong(this.instance);
				}
				return r_Handle;
			}
		}

		/// <summary>
		/// Void Begin()
		/// </summary>
		protected RMethod r_RBegin;
		public virtual RMethod RBegin
		{
			get
			{
				if(r_RBegin == null)
				{
					r_RBegin = new(this, "Begin", 0);
					r_RBegin.SetBelong(this.instance);
				}
				return r_RBegin;
			}
		}

		/// <summary>
		/// Void Begin(UnityEngine.Object)
		/// </summary>
		protected RMethod r_RBegin_Object;
		public virtual RMethod RBegin_Object
		{
			get
			{
				if(r_RBegin_Object == null)
				{
					r_RBegin_Object = new(this, "Begin", 0, typeof(UnityEngine.Object));
					r_RBegin_Object.SetBelong(this.instance);
				}
				return r_RBegin_Object;
			}
		}

		/// <summary>
		/// Void End()
		/// </summary>
		protected RMethod r_REnd;
		public virtual RMethod REnd
		{
			get
			{
				if(r_REnd == null)
				{
					r_REnd = new(this, "End", 0);
					r_REnd.SetBelong(this.instance);
				}
				return r_REnd;
			}
		}

		/// <summary>
		/// Void GetName(System.String ByRef)
		/// </summary>
		protected RMethod r_RGetName_Ref_String;
		public virtual RMethod RGetName_Ref_String
		{
			get
			{
				if(r_RGetName_Ref_String == null)
				{
					r_RGetName_Ref_String = new(this, "GetName", 0, typeof(System.String).MakeByRefType());
					r_RGetName_Ref_String.SetBelong(this.instance);
				}
				return r_RGetName_Ref_String;
			}
		}

		/// <summary>
		/// AutoScope Auto()
		/// </summary>
		protected RMethod r_RAuto;
		public virtual RMethod RAuto
		{
			get
			{
				if(r_RAuto == null)
				{
					r_RAuto = new(this, "Auto", 0);
					r_RAuto.SetBelong(this.instance);
				}
				return r_RAuto;
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


        public RProfilerMarker() : base("Unity.Profiling.ProfilerMarker")
        {
        }

        public RProfilerMarker(System.Object instance) : base("Unity.Profiling.ProfilerMarker")
		{
            SetInstance(instance);
		}

        public RProfilerMarker(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RProfilerMarker(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Begin()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBegin.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Begin(UnityEngine.Object  @contextUnityObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contextUnityObject};
            var ___result = RBegin_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void End()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetName(ref System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetName_Ref_String.Invoke(___genericsType, ___parameters);
			name = (System.String)___parameters[0];

            
        }


        public virtual System.Object Auto()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAuto.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
