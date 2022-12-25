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
		protected static RMethod r_RCreate_String_Boolean;
		public static RMethod RCreate_String_Boolean
		{
			get
			{
				if(r_RCreate_String_Boolean == null)
				{
					r_RCreate_String_Boolean = new(typeof(UnityEngine.Profiling.CustomSampler), "Create", 0, typeof(System.String), typeof(System.Boolean));
					r_RCreate_String_Boolean.SetBelong(null);
				}
				return r_RCreate_String_Boolean;
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
		/// UnityEngine.Profiling.Recorder GetRecorder()
		/// </summary>
		protected RMethod r_RGetRecorder;
		public virtual RMethod RGetRecorder
		{
			get
			{
				if(r_RGetRecorder == null)
				{
					r_RGetRecorder = new(this, "GetRecorder", 0);
					r_RGetRecorder.SetBelong(this.instance);
				}
				return r_RGetRecorder;
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

        public static UnityEngine.Profiling.CustomSampler Create(System.String  @name, System.Boolean  @collectGpuData)
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


        public virtual void Begin(UnityEngine.Object  @targetObject)
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
