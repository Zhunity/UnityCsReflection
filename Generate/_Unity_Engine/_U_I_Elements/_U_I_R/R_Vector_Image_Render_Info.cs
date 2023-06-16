
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.UIR.VectorImageRenderInfo
	/// </summary>
    public partial class RVectorImageRenderInfo : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.VectorImageRenderInfo");
            }
        }

        public RVectorImageRenderInfo() : base("UnityEngine.UIElements.UIR.VectorImageRenderInfo")
        {
        }

        public RVectorImageRenderInfo(System.Object instance) : base("UnityEngine.UIElements.UIR.VectorImageRenderInfo")
		{
            SetInstance(instance);
		}

        public RVectorImageRenderInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RVectorImageRenderInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 useCount
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FuseCount;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFuseCount
		{
			get
			{
				if(r_FuseCount == null)
				{
					r_FuseCount = new(this, "useCount");
				}
				return r_FuseCount;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.GradientRemap firstGradientRemap
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RGradientRemap r_FfirstGradientRemap;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RGradientRemap RFfirstGradientRemap
		{
			get
			{
				if(r_FfirstGradientRemap == null)
				{
					r_FfirstGradientRemap = new(this, "firstGradientRemap");
				}
				return r_FfirstGradientRemap;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Alloc gradientSettingsAlloc
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RAlloc r_FgradientSettingsAlloc;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RAlloc RFgradientSettingsAlloc
		{
			get
			{
				if(r_FgradientSettingsAlloc == null)
				{
					r_FgradientSettingsAlloc = new(this, "gradientSettingsAlloc");
				}
				return r_FgradientSettingsAlloc;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.VectorImageRenderInfo poolNext
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVectorImageRenderInfo r_FpoolNext;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVectorImageRenderInfo RFpoolNext
		{
			get
			{
				if(r_FpoolNext == null)
				{
					r_FpoolNext = new(this, "poolNext");
				}
				return r_FpoolNext;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
				}
				return r_MReset;
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


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
