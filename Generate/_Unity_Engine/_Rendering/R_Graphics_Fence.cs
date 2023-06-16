
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.Rendering.GraphicsFence
	/// </summary>
    public partial class RGraphicsFence : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Rendering.GraphicsFence);
            }
        }

        public RGraphicsFence() : base("UnityEngine.Rendering.GraphicsFence")
        {
        }

        public RGraphicsFence(System.Object instance) : base("UnityEngine.Rendering.GraphicsFence")
		{
            SetInstance(instance);
		}

        public RGraphicsFence(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGraphicsFence(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
		/// System.Int32 m_Version
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_Version;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_Version
		{
			get
			{
				if(r_Fm_Version == null)
				{
					r_Fm_Version = new(this, "m_Version");
				}
				return r_Fm_Version;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.GraphicsFenceType m_FenceType
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RGraphicsFenceType r_Fm_FenceType;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RGraphicsFenceType RFm_FenceType
		{
			get
			{
				if(r_Fm_FenceType == null)
				{
					r_Fm_FenceType = new(this, "m_FenceType");
				}
				return r_Fm_FenceType;
			}
		}

		/// <summary>
		/// Boolean passed
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_Ppassed;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPpassed
		{
			get
			{
				if(r_Ppassed == null)
				{
					r_Ppassed = new(this, "passed", -1);
				}
				return r_Ppassed;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.SynchronisationStageFlags TranslateSynchronizationStageToFlags(UnityEngine.Rendering.SynchronisationStage)
		/// </summary>
		protected static RMethod r_MTranslateSynchronizationStageToFlags_SynchronisationStage;
		public static RMethod RMTranslateSynchronizationStageToFlags_SynchronisationStage
		{
			get
			{
				if(r_MTranslateSynchronizationStageToFlags_SynchronisationStage == null)
				{
					r_MTranslateSynchronizationStageToFlags_SynchronisationStage = new(Type, "TranslateSynchronizationStageToFlags", 0, typeof(UnityEngine.Rendering.SynchronisationStage));
				}
				return r_MTranslateSynchronizationStageToFlags_SynchronisationStage;
			}
		}

		/// <summary>
		/// Boolean HasFencePassed_Internal(IntPtr)
		/// </summary>
		protected static RMethod r_MHasFencePassed_Internal_IntPtr;
		public static RMethod RMHasFencePassed_Internal_IntPtr
		{
			get
			{
				if(r_MHasFencePassed_Internal_IntPtr == null)
				{
					r_MHasFencePassed_Internal_IntPtr = new(Type, "HasFencePassed_Internal", 0, typeof(System.IntPtr));
				}
				return r_MHasFencePassed_Internal_IntPtr;
			}
		}

		/// <summary>
		/// Void InitPostAllocation()
		/// </summary>
		protected RMethod r_MInitPostAllocation;
		public virtual RMethod RMInitPostAllocation
		{
			get
			{
				if(r_MInitPostAllocation == null)
				{
					r_MInitPostAllocation = new(this, "InitPostAllocation", 0);
				}
				return r_MInitPostAllocation;
			}
		}

		/// <summary>
		/// Boolean IsFencePending()
		/// </summary>
		protected RMethod r_MIsFencePending;
		public virtual RMethod RMIsFencePending
		{
			get
			{
				if(r_MIsFencePending == null)
				{
					r_MIsFencePending = new(this, "IsFencePending", 0);
				}
				return r_MIsFencePending;
			}
		}

		/// <summary>
		/// Void Validate()
		/// </summary>
		protected RMethod r_MValidate;
		public virtual RMethod RMValidate
		{
			get
			{
				if(r_MValidate == null)
				{
					r_MValidate = new(this, "Validate", 0);
				}
				return r_MValidate;
			}
		}

		/// <summary>
		/// Int32 GetPlatformNotSupportedVersion()
		/// </summary>
		protected RMethod r_MGetPlatformNotSupportedVersion;
		public virtual RMethod RMGetPlatformNotSupportedVersion
		{
			get
			{
				if(r_MGetPlatformNotSupportedVersion == null)
				{
					r_MGetPlatformNotSupportedVersion = new(this, "GetPlatformNotSupportedVersion", 0);
				}
				return r_MGetPlatformNotSupportedVersion;
			}
		}

		/// <summary>
		/// Int32 GetVersionNumber(IntPtr)
		/// </summary>
		protected static RMethod r_MGetVersionNumber_IntPtr;
		public static RMethod RMGetVersionNumber_IntPtr
		{
			get
			{
				if(r_MGetVersionNumber_IntPtr == null)
				{
					r_MGetVersionNumber_IntPtr = new(Type, "GetVersionNumber", 0, typeof(System.IntPtr));
				}
				return r_MGetVersionNumber_IntPtr;
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


        public static UnityEngine.Rendering.SynchronisationStageFlags TranslateSynchronizationStageToFlags(UnityEngine.Rendering.SynchronisationStage @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RMTranslateSynchronizationStageToFlags_SynchronisationStage.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.Rendering.SynchronisationStageFlags>(___result);
        }


        public static System.Boolean HasFencePassed_Internal(System.IntPtr @fencePtr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fencePtr};
            var ___result = RMHasFencePassed_Internal_IntPtr.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void InitPostAllocation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMInitPostAllocation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsFencePending()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMIsFencePending.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Validate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMValidate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetPlatformNotSupportedVersion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetPlatformNotSupportedVersion.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public static System.Int32 GetVersionNumber(System.IntPtr @fencePtr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fencePtr};
            var ___result = RMGetVersionNumber_IntPtr.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Type>(___result);
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Object>(___result);
        }


    }
}
