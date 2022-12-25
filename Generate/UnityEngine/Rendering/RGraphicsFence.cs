using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.GraphicsFence
	/// </summary>
    public partial class RGraphicsFence : RMember //
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
		/// System.Int32 m_Version
		/// </summary>
		protected RField r_m_Version;
		public virtual RField Rm_Version
		{
			get
			{
				if(r_m_Version == null)
				{
					r_m_Version = new(this, "m_Version");
					r_m_Version.SetBelong(this.instance);
				}
				return r_m_Version;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.GraphicsFenceType m_FenceType
		/// </summary>
		protected RField r_m_FenceType;
		public virtual RField Rm_FenceType
		{
			get
			{
				if(r_m_FenceType == null)
				{
					r_m_FenceType = new(this, "m_FenceType");
					r_m_FenceType.SetBelong(this.instance);
				}
				return r_m_FenceType;
			}
		}

		/// <summary>
		/// Boolean passed
		/// </summary>
		protected RProperty r_passed;
		public virtual RProperty Rpassed
		{
			get
			{
				if(r_passed == null)
				{
					r_passed = new(this, "passed", -1);
					r_passed.SetBelong(this.instance);
				}
				return r_passed;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.SynchronisationStageFlags TranslateSynchronizationStageToFlags(UnityEngine.Rendering.SynchronisationStage)
		/// </summary>
		protected static RMethod r_RTranslateSynchronizationStageToFlags_SynchronisationStage;
		public static RMethod RTranslateSynchronizationStageToFlags_SynchronisationStage
		{
			get
			{
				if(r_RTranslateSynchronizationStageToFlags_SynchronisationStage == null)
				{
					r_RTranslateSynchronizationStageToFlags_SynchronisationStage = new(typeof(UnityEngine.Rendering.GraphicsFence), "TranslateSynchronizationStageToFlags", 0, typeof(UnityEngine.Rendering.SynchronisationStage));
					r_RTranslateSynchronizationStageToFlags_SynchronisationStage.SetBelong(null);
				}
				return r_RTranslateSynchronizationStageToFlags_SynchronisationStage;
			}
		}

		/// <summary>
		/// Boolean HasFencePassed_Internal(IntPtr)
		/// </summary>
		protected static RMethod r_RHasFencePassed_Internal_IntPtr;
		public static RMethod RHasFencePassed_Internal_IntPtr
		{
			get
			{
				if(r_RHasFencePassed_Internal_IntPtr == null)
				{
					r_RHasFencePassed_Internal_IntPtr = new(typeof(UnityEngine.Rendering.GraphicsFence), "HasFencePassed_Internal", 0, typeof(System.IntPtr));
					r_RHasFencePassed_Internal_IntPtr.SetBelong(null);
				}
				return r_RHasFencePassed_Internal_IntPtr;
			}
		}

		/// <summary>
		/// Void InitPostAllocation()
		/// </summary>
		protected RMethod r_RInitPostAllocation;
		public virtual RMethod RInitPostAllocation
		{
			get
			{
				if(r_RInitPostAllocation == null)
				{
					r_RInitPostAllocation = new(this, "InitPostAllocation", 0);
					r_RInitPostAllocation.SetBelong(this.instance);
				}
				return r_RInitPostAllocation;
			}
		}

		/// <summary>
		/// Boolean IsFencePending()
		/// </summary>
		protected RMethod r_RIsFencePending;
		public virtual RMethod RIsFencePending
		{
			get
			{
				if(r_RIsFencePending == null)
				{
					r_RIsFencePending = new(this, "IsFencePending", 0);
					r_RIsFencePending.SetBelong(this.instance);
				}
				return r_RIsFencePending;
			}
		}

		/// <summary>
		/// Void Validate()
		/// </summary>
		protected RMethod r_RValidate;
		public virtual RMethod RValidate
		{
			get
			{
				if(r_RValidate == null)
				{
					r_RValidate = new(this, "Validate", 0);
					r_RValidate.SetBelong(this.instance);
				}
				return r_RValidate;
			}
		}

		/// <summary>
		/// Int32 GetPlatformNotSupportedVersion()
		/// </summary>
		protected RMethod r_RGetPlatformNotSupportedVersion;
		public virtual RMethod RGetPlatformNotSupportedVersion
		{
			get
			{
				if(r_RGetPlatformNotSupportedVersion == null)
				{
					r_RGetPlatformNotSupportedVersion = new(this, "GetPlatformNotSupportedVersion", 0);
					r_RGetPlatformNotSupportedVersion.SetBelong(this.instance);
				}
				return r_RGetPlatformNotSupportedVersion;
			}
		}

		/// <summary>
		/// Int32 GetVersionNumber(IntPtr)
		/// </summary>
		protected static RMethod r_RGetVersionNumber_IntPtr;
		public static RMethod RGetVersionNumber_IntPtr
		{
			get
			{
				if(r_RGetVersionNumber_IntPtr == null)
				{
					r_RGetVersionNumber_IntPtr = new(typeof(UnityEngine.Rendering.GraphicsFence), "GetVersionNumber", 0, typeof(System.IntPtr));
					r_RGetVersionNumber_IntPtr.SetBelong(null);
				}
				return r_RGetVersionNumber_IntPtr;
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

        public static UnityEngine.Rendering.SynchronisationStageFlags TranslateSynchronizationStageToFlags(UnityEngine.Rendering.SynchronisationStage  @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RTranslateSynchronizationStageToFlags_SynchronisationStage.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.SynchronisationStageFlags)___result;
        }


        public static System.Boolean HasFencePassed_Internal(System.IntPtr  @fencePtr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fencePtr};
            var ___result = RHasFencePassed_Internal_IntPtr.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void InitPostAllocation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitPostAllocation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsFencePending()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsFencePending.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Validate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RValidate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetPlatformNotSupportedVersion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPlatformNotSupportedVersion.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 GetVersionNumber(System.IntPtr  @fencePtr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fencePtr};
            var ___result = RGetVersionNumber_IntPtr.Invoke(___genericsType, ___parameters);

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
