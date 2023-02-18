
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RYoga
{
	/// <summary>
	/// UnityEngine.Yoga.YogaConfig
	/// </summary>
    public partial class RYogaConfig : RMember //
    {

		/// <summary>
		/// UnityEngine.Yoga.YogaConfig Default
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaConfig r_FDefault;
		public static Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaConfig RFDefault
		{
			get
			{
				if(r_FDefault == null)
				{
					r_FDefault = new( ReflectionUtils.GetType("UnityEngine.Yoga.YogaConfig"), "Default");
					r_FDefault.SetBelong(null);
				}
				return r_FDefault;
			}
		}

		/// <summary>
		/// System.IntPtr _ygConfig
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_F_ygConfig;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RF_ygConfig
		{
			get
			{
				if(r_F_ygConfig == null)
				{
					r_F_ygConfig = new(this, "_ygConfig");
					r_F_ygConfig.SetBelong(this.GetValue());
				}
				return r_F_ygConfig;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.Logger _logger
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RYoga.RLogger r_F_logger;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RYoga.RLogger RF_logger
		{
			get
			{
				if(r_F_logger == null)
				{
					r_F_logger = new(this, "_logger");
					r_F_logger.SetBelong(this.GetValue());
				}
				return r_F_logger;
			}
		}

		/// <summary>
		/// IntPtr Handle
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RIntPtr r_PHandle;
		public virtual Hvak.Editor.Refleaction.RSystem.RIntPtr RPHandle
		{
			get
			{
				if(r_PHandle == null)
				{
					r_PHandle = new(this, "Handle", -1);
					r_PHandle.SetBelong(this.GetValue());
				}
				return r_PHandle;
			}
		}

		/// <summary>
		/// UnityEngine.Yoga.Logger Logger
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RYoga.RLogger r_PLogger;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RYoga.RLogger RPLogger
		{
			get
			{
				if(r_PLogger == null)
				{
					r_PLogger = new(this, "Logger", -1);
					r_PLogger.SetBelong(this.GetValue());
				}
				return r_PLogger;
			}
		}

		/// <summary>
		/// Boolean UseWebDefaults
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PUseWebDefaults;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPUseWebDefaults
		{
			get
			{
				if(r_PUseWebDefaults == null)
				{
					r_PUseWebDefaults = new(this, "UseWebDefaults", -1);
					r_PUseWebDefaults.SetBelong(this.GetValue());
				}
				return r_PUseWebDefaults;
			}
		}

		/// <summary>
		/// Single PointScaleFactor
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PPointScaleFactor;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPPointScaleFactor
		{
			get
			{
				if(r_PPointScaleFactor == null)
				{
					r_PPointScaleFactor = new(this, "PointScaleFactor", -1);
					r_PPointScaleFactor.SetBelong(this.GetValue());
				}
				return r_PPointScaleFactor;
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
					r_MFinalize.SetBelong(this.GetValue());
				}
				return r_MFinalize;
			}
		}

		/// <summary>
		/// Void SetExperimentalFeatureEnabled(UnityEngine.Yoga.YogaExperimentalFeature, Boolean)
		/// </summary>
		protected RMethod r_MSetExperimentalFeatureEnabled_YogaExperimentalFeature_Boolean;
		public virtual RMethod RMSetExperimentalFeatureEnabled_YogaExperimentalFeature_Boolean
		{
			get
			{
				if(r_MSetExperimentalFeatureEnabled_YogaExperimentalFeature_Boolean == null)
				{
					r_MSetExperimentalFeatureEnabled_YogaExperimentalFeature_Boolean = new(this, "SetExperimentalFeatureEnabled", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaExperimentalFeature"), typeof(System.Boolean));
					r_MSetExperimentalFeatureEnabled_YogaExperimentalFeature_Boolean.SetBelong(this.GetValue());
				}
				return r_MSetExperimentalFeatureEnabled_YogaExperimentalFeature_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsExperimentalFeatureEnabled(UnityEngine.Yoga.YogaExperimentalFeature)
		/// </summary>
		protected RMethod r_MIsExperimentalFeatureEnabled_YogaExperimentalFeature;
		public virtual RMethod RMIsExperimentalFeatureEnabled_YogaExperimentalFeature
		{
			get
			{
				if(r_MIsExperimentalFeatureEnabled_YogaExperimentalFeature == null)
				{
					r_MIsExperimentalFeatureEnabled_YogaExperimentalFeature = new(this, "IsExperimentalFeatureEnabled", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.YogaExperimentalFeature"));
					r_MIsExperimentalFeatureEnabled_YogaExperimentalFeature.SetBelong(this.GetValue());
				}
				return r_MIsExperimentalFeatureEnabled_YogaExperimentalFeature;
			}
		}

		/// <summary>
		/// Int32 GetInstanceCount()
		/// </summary>
		protected static RMethod r_MGetInstanceCount;
		public static RMethod RMGetInstanceCount
		{
			get
			{
				if(r_MGetInstanceCount == null)
				{
					r_MGetInstanceCount = new( ReflectionUtils.GetType("UnityEngine.Yoga.YogaConfig"), "GetInstanceCount", 0);
					r_MGetInstanceCount.SetBelong(null);
				}
				return r_MGetInstanceCount;
			}
		}

		/// <summary>
		/// Void SetDefaultLogger(UnityEngine.Yoga.Logger)
		/// </summary>
		protected static RMethod r_MSetDefaultLogger_Logger;
		public static RMethod RMSetDefaultLogger_Logger
		{
			get
			{
				if(r_MSetDefaultLogger_Logger == null)
				{
					r_MSetDefaultLogger_Logger = new( ReflectionUtils.GetType("UnityEngine.Yoga.YogaConfig"), "SetDefaultLogger", 0,  ReflectionUtils.GetType("UnityEngine.Yoga.Logger"));
					r_MSetDefaultLogger_Logger.SetBelong(null);
				}
				return r_MSetDefaultLogger_Logger;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
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
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetExperimentalFeatureEnabled(Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaExperimentalFeature @feature, System.Boolean @enabled)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@feature.Value, @enabled};
            var ___result = RMSetExperimentalFeatureEnabled_YogaExperimentalFeature_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsExperimentalFeatureEnabled(Hvak.Editor.Refleaction.RUnityEngine.RYoga.RYogaExperimentalFeature @feature)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@feature.Value};
            var ___result = RMIsExperimentalFeatureEnabled_YogaExperimentalFeature.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 GetInstanceCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetInstanceCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void SetDefaultLogger(Hvak.Editor.Refleaction.RUnityEngine.RYoga.RLogger @logger)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@logger.Value};
            var ___result = RMSetDefaultLogger_Logger.Invoke(___genericsType, ___parameters);

            
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
