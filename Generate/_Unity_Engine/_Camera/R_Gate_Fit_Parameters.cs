
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{public partial class RCamera
{
	
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.Camera+GateFitParameters
	/// </summary>
    public partial class RGateFitParameters : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.Camera+GateFitParameters");
            }
        }

        public RGateFitParameters() : base("UnityEngine.Camera+GateFitParameters")
        {
        }

        public RGateFitParameters(System.Object instance) : base("UnityEngine.Camera+GateFitParameters")
		{
            SetInstance(instance);
		}

        public RGateFitParameters(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGateFitParameters(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.Camera+GateFitMode <mode>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RCamera.RGateFitMode r_F__0__mode__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RCamera.RGateFitMode RF__0__mode__1__k__BackingField
		{
			get
			{
				if(r_F__0__mode__1__k__BackingField == null)
				{
					r_F__0__mode__1__k__BackingField = new(this, "<mode>k__BackingField");
				}
				return r_F__0__mode__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Single <aspect>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_F__0__aspect__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RF__0__aspect__1__k__BackingField
		{
			get
			{
				if(r_F__0__aspect__1__k__BackingField == null)
				{
					r_F__0__aspect__1__k__BackingField = new(this, "<aspect>k__BackingField");
				}
				return r_F__0__aspect__1__k__BackingField;
			}
		}

		/// <summary>
		/// GateFitMode mode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RCamera.RGateFitMode r_Pmode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RCamera.RGateFitMode RPmode
		{
			get
			{
				if(r_Pmode == null)
				{
					r_Pmode = new(this, "mode", -1);
				}
				return r_Pmode;
			}
		}

		/// <summary>
		/// Single aspect
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Paspect;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPaspect
		{
			get
			{
				if(r_Paspect == null)
				{
					r_Paspect = new(this, "aspect", -1);
				}
				return r_Paspect;
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
}