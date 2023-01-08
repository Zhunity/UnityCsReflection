using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RProfiling
{
	/// <summary>
	/// UnityEngine.Profiling.CustomSampler
	/// </summary>
    public partial class RCustomSampler : RMember //
    {

		/// <summary>
		/// UnityEngine.Profiling.CustomSampler s_InvalidCustomSampler
		/// </summary>
		protected static RUnityEngine.RProfiling.RCustomSampler r_s_InvalidCustomSampler;
		public static RUnityEngine.RProfiling.RCustomSampler Rs_InvalidCustomSampler
		{
			get
			{
				if(r_s_InvalidCustomSampler == null)
				{
					r_s_InvalidCustomSampler = new(typeof(UnityEngine.Profiling.CustomSampler), "s_InvalidCustomSampler");
					r_s_InvalidCustomSampler.SetBelong(null);
				}
				return r_s_InvalidCustomSampler;
			}
		}

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
		/// Boolean isValid
		/// </summary>
		protected RProperty r_isValid;
		public virtual RProperty RisValid
		{
			get
			{
				if(r_isValid == null)
				{
					r_isValid = new(this, "isValid", -1);
					r_isValid.SetBelong(this.instance);
				}
				return r_isValid;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UnityEngine.Profiling.CustomSampler Create(System.String, Boolean)
		/// </summary>
		protected static RMethod r_Create_String_Boolean;
		public static RMethod RCreate_String_Boolean
		{
			get
			{
				if(r_Create_String_Boolean == null)
				{
					r_Create_String_Boolean = new(typeof(UnityEngine.Profiling.CustomSampler), "Create", 0, typeof(System.String), typeof(System.Boolean));
					r_Create_String_Boolean.SetBelong(null);
				}
				return r_Create_String_Boolean;
			}
		}

		/// <summary>
		/// Void Begin()
		/// </summary>
		protected RMethod r_Begin;
		public virtual RMethod RBegin
		{
			get
			{
				if(r_Begin == null)
				{
					r_Begin = new(this, "Begin", 0);
					r_Begin.SetBelong(this.instance);
				}
				return r_Begin;
			}
		}

		/// <summary>
		/// Void Begin(UnityEngine.Object)
		/// </summary>
		protected RMethod r_Begin_Object;
		public virtual RMethod RBegin_Object
		{
			get
			{
				if(r_Begin_Object == null)
				{
					r_Begin_Object = new(this, "Begin", 0, typeof(UnityEngine.Object));
					r_Begin_Object.SetBelong(this.instance);
				}
				return r_Begin_Object;
			}
		}

		/// <summary>
		/// Void End()
		/// </summary>
		protected RMethod r_End;
		public virtual RMethod REnd
		{
			get
			{
				if(r_End == null)
				{
					r_End = new(this, "End", 0);
					r_End.SetBelong(this.instance);
				}
				return r_End;
			}
		}

		/// <summary>
		/// UnityEngine.Profiling.Recorder GetRecorder()
		/// </summary>
		protected RMethod r_GetRecorder;
		public virtual RMethod RGetRecorder
		{
			get
			{
				if(r_GetRecorder == null)
				{
					r_GetRecorder = new(this, "GetRecorder", 0);
					r_GetRecorder.SetBelong(this.instance);
				}
				return r_GetRecorder;
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


        public RCustomSampler() : base("UnityEngine.Profiling.CustomSampler")
        {
        }

        public RCustomSampler(System.Object instance) : base("UnityEngine.Profiling.CustomSampler")
		{
            SetInstance(instance);
		}

        public RCustomSampler(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCustomSampler(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.Profiling.CustomSampler Create(System.String @name, System.Boolean @collectGpuData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @collectGpuData};
            var ___result = RCreate_String_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Profiling.CustomSampler)___result;
        }


        public virtual void Begin()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBegin.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Begin(UnityEngine.Object @targetObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObject};
            var ___result = RBegin_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void End()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Profiling.Recorder GetRecorder()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRecorder.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Profiling.Recorder)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
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
