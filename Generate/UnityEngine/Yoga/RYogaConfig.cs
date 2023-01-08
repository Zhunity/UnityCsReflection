using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RYoga
{
	/// <summary>
	/// UnityEngine.Yoga.YogaConfig
	/// </summary>
    public partial class RYogaConfig : RMember //
    {

		/// <summary>
		/// UnityEngine.Yoga.YogaConfig Default
		/// </summary>
		protected static RUnityEngine.RYoga.RYogaConfig r_Default;
		public static RUnityEngine.RYoga.RYogaConfig RDefault
		{
			get
			{
				if(r_Default == null)
				{
					r_Default = new( ReleactionUtils.GetType("UnityEngine.Yoga.YogaConfig"), "Default");
					r_Default.SetBelong(null);
				}
				return r_Default;
			}
		}

		/// <summary>
		/// System.IntPtr _ygConfig
		/// </summary>
		protected RField r__ygConfig;
		public virtual RField R_ygConfig
		{
			get
			{
				if(r__ygConfig == null)
				{
					r__ygConfig = new(this, "_ygConfig");
					r__ygConfig.SetBelong(this.instance);
				}
				return r__ygConfig;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.Logger _logger
		/// </summary>
		protected RUnityEngine.RYoga.RLogger r__logger;
		public virtual RUnityEngine.RYoga.RLogger R_logger
		{
			get
			{
				if(r__logger == null)
				{
					r__logger = new(this, "_logger");
					r__logger.SetBelong(this.instance);
				}
				return r__logger;
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
		/// UnityEngine.Yoga.Logger Logger
		/// </summary>
		protected RUnityEngine.RYoga.RLogger r_Logger;
		public virtual RUnityEngine.RYoga.RLogger RLogger
		{
			get
			{
				if(r_Logger == null)
				{
					r_Logger = new(this, "Logger", -1);
					r_Logger.SetBelong(this.instance);
				}
				return r_Logger;
			}
		}

		/// <summary>
		/// Boolean UseWebDefaults
		/// </summary>
		protected RProperty r_UseWebDefaults;
		public virtual RProperty RUseWebDefaults
		{
			get
			{
				if(r_UseWebDefaults == null)
				{
					r_UseWebDefaults = new(this, "UseWebDefaults", -1);
					r_UseWebDefaults.SetBelong(this.instance);
				}
				return r_UseWebDefaults;
			}
		}

		/// <summary>
		/// Single PointScaleFactor
		/// </summary>
		protected RProperty r_PointScaleFactor;
		public virtual RProperty RPointScaleFactor
		{
			get
			{
				if(r_PointScaleFactor == null)
				{
					r_PointScaleFactor = new(this, "PointScaleFactor", -1);
					r_PointScaleFactor.SetBelong(this.instance);
				}
				return r_PointScaleFactor;
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
		/// Void SetExperimentalFeatureEnabled(UnityEngine.Yoga.YogaExperimentalFeature, Boolean)
		/// </summary>
		protected RMethod r_SetExperimentalFeatureEnabled_YogaExperimentalFeature_Boolean;
		public virtual RMethod RSetExperimentalFeatureEnabled_YogaExperimentalFeature_Boolean
		{
			get
			{
				if(r_SetExperimentalFeatureEnabled_YogaExperimentalFeature_Boolean == null)
				{
					r_SetExperimentalFeatureEnabled_YogaExperimentalFeature_Boolean = new(this, "SetExperimentalFeatureEnabled", 0,  ReleactionUtils.GetType("UnityEngine.Yoga.YogaExperimentalFeature"), typeof(System.Boolean));
					r_SetExperimentalFeatureEnabled_YogaExperimentalFeature_Boolean.SetBelong(this.instance);
				}
				return r_SetExperimentalFeatureEnabled_YogaExperimentalFeature_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsExperimentalFeatureEnabled(UnityEngine.Yoga.YogaExperimentalFeature)
		/// </summary>
		protected RMethod r_IsExperimentalFeatureEnabled_YogaExperimentalFeature;
		public virtual RMethod RIsExperimentalFeatureEnabled_YogaExperimentalFeature
		{
			get
			{
				if(r_IsExperimentalFeatureEnabled_YogaExperimentalFeature == null)
				{
					r_IsExperimentalFeatureEnabled_YogaExperimentalFeature = new(this, "IsExperimentalFeatureEnabled", 0,  ReleactionUtils.GetType("UnityEngine.Yoga.YogaExperimentalFeature"));
					r_IsExperimentalFeatureEnabled_YogaExperimentalFeature.SetBelong(this.instance);
				}
				return r_IsExperimentalFeatureEnabled_YogaExperimentalFeature;
			}
		}

		/// <summary>
		/// Int32 GetInstanceCount()
		/// </summary>
		protected static RMethod r_GetInstanceCount;
		public static RMethod RGetInstanceCount
		{
			get
			{
				if(r_GetInstanceCount == null)
				{
					r_GetInstanceCount = new( ReleactionUtils.GetType("UnityEngine.Yoga.YogaConfig"), "GetInstanceCount", 0);
					r_GetInstanceCount.SetBelong(null);
				}
				return r_GetInstanceCount;
			}
		}

		/// <summary>
		/// Void SetDefaultLogger(UnityEngine.Yoga.Logger)
		/// </summary>
		protected static RMethod r_SetDefaultLogger_Logger;
		public static RMethod RSetDefaultLogger_Logger
		{
			get
			{
				if(r_SetDefaultLogger_Logger == null)
				{
					r_SetDefaultLogger_Logger = new( ReleactionUtils.GetType("UnityEngine.Yoga.YogaConfig"), "SetDefaultLogger", 0,  ReleactionUtils.GetType("UnityEngine.Yoga.Logger"));
					r_SetDefaultLogger_Logger.SetBelong(null);
				}
				return r_SetDefaultLogger_Logger;
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


        public RYogaConfig() : base("UnityEngine.Yoga.YogaConfig")
        {
        }

        public RYogaConfig(System.Object instance) : base("UnityEngine.Yoga.YogaConfig")
		{
            SetInstance(instance);
		}

        public RYogaConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RYogaConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }




        public static System.Int32 GetInstanceCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
