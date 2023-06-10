
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RProfiling
{
	/// <summary>
	/// UnityEngine.Profiling.CustomSampler
	/// </summary>
    public partial class RCustomSampler : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Profiling.CustomSampler);
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


		/// <summary>
		/// UnityEngine.Profiling.CustomSampler s_InvalidCustomSampler
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RProfiling.RCustomSampler r_Fs_InvalidCustomSampler;
		public static Hvak.Editor.Refleaction.RUnityEngine.RProfiling.RCustomSampler RFs_InvalidCustomSampler
		{
			get
			{
				if(r_Fs_InvalidCustomSampler == null)
				{
					r_Fs_InvalidCustomSampler = new(typeof(UnityEngine.Profiling.CustomSampler), "s_InvalidCustomSampler");
				}
				return r_Fs_InvalidCustomSampler;
			}
		}

		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_Fm_Ptr;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RFm_Ptr
		{
			get
			{
				if(r_Fm_Ptr == null)
				{
					r_Fm_Ptr = new(this, "m_Ptr");
				}
				return r_Fm_Ptr;
			}
		}

		/// <summary>
		/// Boolean isValid
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisValid;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisValid
		{
			get
			{
				if(r_PisValid == null)
				{
					r_PisValid = new(this, "isValid", -1);
				}
				return r_PisValid;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RString r_Pname;
		public virtual Hvak.Editor.Refleaction.RSystem.RString RPname
		{
			get
			{
				if(r_Pname == null)
				{
					r_Pname = new(this, "name", -1);
				}
				return r_Pname;
			}
		}

		/// <summary>
		/// UnityEngine.Profiling.CustomSampler Create(System.String, Boolean)
		/// </summary>
		protected static RMethod r_MCreate_String_Boolean;
		public static RMethod RMCreate_String_Boolean
		{
			get
			{
				if(r_MCreate_String_Boolean == null)
				{
					r_MCreate_String_Boolean = new(typeof(UnityEngine.Profiling.CustomSampler), "Create", 0, typeof(System.String), typeof(System.Boolean));
				}
				return r_MCreate_String_Boolean;
			}
		}

		/// <summary>
		/// Void Begin()
		/// </summary>
		protected RMethod r_MBegin;
		public virtual RMethod RMBegin
		{
			get
			{
				if(r_MBegin == null)
				{
					r_MBegin = new(this, "Begin", 0);
				}
				return r_MBegin;
			}
		}

		/// <summary>
		/// Void Begin(UnityEngine.Object)
		/// </summary>
		protected RMethod r_MBegin_Object;
		public virtual RMethod RMBegin_Object
		{
			get
			{
				if(r_MBegin_Object == null)
				{
					r_MBegin_Object = new(this, "Begin", 0, typeof(UnityEngine.Object));
				}
				return r_MBegin_Object;
			}
		}

		/// <summary>
		/// Void End()
		/// </summary>
		protected RMethod r_MEnd;
		public virtual RMethod RMEnd
		{
			get
			{
				if(r_MEnd == null)
				{
					r_MEnd = new(this, "End", 0);
				}
				return r_MEnd;
			}
		}

		/// <summary>
		/// UnityEngine.Profiling.Recorder GetRecorder()
		/// </summary>
		protected RMethod r_MGetRecorder;
		public virtual RMethod RMGetRecorder
		{
			get
			{
				if(r_MGetRecorder == null)
				{
					r_MGetRecorder = new(this, "GetRecorder", 0);
				}
				return r_MGetRecorder;
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


        public static UnityEngine.Profiling.CustomSampler Create(System.String @name, System.Boolean @collectGpuData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @collectGpuData};
            var ___result = RMCreate_String_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Profiling.CustomSampler)___result;
        }


        public virtual void Begin()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMBegin.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Begin(UnityEngine.Object @targetObject)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetObject};
            var ___result = RMBegin_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void End()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMEnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Profiling.Recorder GetRecorder()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetRecorder.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Profiling.Recorder)___result;
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
