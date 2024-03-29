
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.Rendering.LODParameters
	/// </summary>
    public partial class RLODParameters : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Rendering.LODParameters);
            }
        }

        public RLODParameters() : base("UnityEngine.Rendering.LODParameters")
        {
        }

        public RLODParameters(System.Object instance) : base("UnityEngine.Rendering.LODParameters")
		{
            SetInstance(instance);
		}

        public RLODParameters(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLODParameters(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// System.Int32 m_IsOrthographic
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_IsOrthographic;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_IsOrthographic
		{
			get
			{
				if(r_Fm_IsOrthographic == null)
				{
					r_Fm_IsOrthographic = new(this, "m_IsOrthographic");
				}
				return r_Fm_IsOrthographic;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_CameraPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_Fm_CameraPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RFm_CameraPosition
		{
			get
			{
				if(r_Fm_CameraPosition == null)
				{
					r_Fm_CameraPosition = new(this, "m_CameraPosition");
				}
				return r_Fm_CameraPosition;
			}
		}

		/// <summary>
		/// System.Single m_FieldOfView
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_FieldOfView;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_FieldOfView
		{
			get
			{
				if(r_Fm_FieldOfView == null)
				{
					r_Fm_FieldOfView = new(this, "m_FieldOfView");
				}
				return r_Fm_FieldOfView;
			}
		}

		/// <summary>
		/// System.Single m_OrthoSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_Fm_OrthoSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFm_OrthoSize
		{
			get
			{
				if(r_Fm_OrthoSize == null)
				{
					r_Fm_OrthoSize = new(this, "m_OrthoSize");
				}
				return r_Fm_OrthoSize;
			}
		}

		/// <summary>
		/// System.Int32 m_CameraPixelHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_CameraPixelHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_CameraPixelHeight
		{
			get
			{
				if(r_Fm_CameraPixelHeight == null)
				{
					r_Fm_CameraPixelHeight = new(this, "m_CameraPixelHeight");
				}
				return r_Fm_CameraPixelHeight;
			}
		}

		/// <summary>
		/// Boolean isOrthographic
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PisOrthographic;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPisOrthographic
		{
			get
			{
				if(r_PisOrthographic == null)
				{
					r_PisOrthographic = new(this, "isOrthographic", -1);
				}
				return r_PisOrthographic;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 cameraPosition
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RVector3 r_PcameraPosition;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RVector3 RPcameraPosition
		{
			get
			{
				if(r_PcameraPosition == null)
				{
					r_PcameraPosition = new(this, "cameraPosition", -1);
				}
				return r_PcameraPosition;
			}
		}

		/// <summary>
		/// Single fieldOfView
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PfieldOfView;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPfieldOfView
		{
			get
			{
				if(r_PfieldOfView == null)
				{
					r_PfieldOfView = new(this, "fieldOfView", -1);
				}
				return r_PfieldOfView;
			}
		}

		/// <summary>
		/// Single orthoSize
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_PorthoSize;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RPorthoSize
		{
			get
			{
				if(r_PorthoSize == null)
				{
					r_PorthoSize = new(this, "orthoSize", -1);
				}
				return r_PorthoSize;
			}
		}

		/// <summary>
		/// Int32 cameraPixelHeight
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PcameraPixelHeight;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPcameraPixelHeight
		{
			get
			{
				if(r_PcameraPixelHeight == null)
				{
					r_PcameraPixelHeight = new(this, "cameraPixelHeight", -1);
				}
				return r_PcameraPixelHeight;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.Rendering.LODParameters)
		/// </summary>
		protected RMethod r_MEquals_LODParameters;
		public virtual RMethod RMEquals_LODParameters
		{
			get
			{
				if(r_MEquals_LODParameters == null)
				{
					r_MEquals_LODParameters = new(this, "Equals", 0, typeof(UnityEngine.Rendering.LODParameters));
				}
				return r_MEquals_LODParameters;
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
		/// Boolean op_Equality(UnityEngine.Rendering.LODParameters, UnityEngine.Rendering.LODParameters)
		/// </summary>
		protected static RMethod r_Mop_Equality_LODParameters_LODParameters;
		public static RMethod RMop_Equality_LODParameters_LODParameters
		{
			get
			{
				if(r_Mop_Equality_LODParameters_LODParameters == null)
				{
					r_Mop_Equality_LODParameters_LODParameters = new(Type, "op_Equality", 0, typeof(UnityEngine.Rendering.LODParameters), typeof(UnityEngine.Rendering.LODParameters));
				}
				return r_Mop_Equality_LODParameters_LODParameters;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rendering.LODParameters, UnityEngine.Rendering.LODParameters)
		/// </summary>
		protected static RMethod r_Mop_Inequality_LODParameters_LODParameters;
		public static RMethod RMop_Inequality_LODParameters_LODParameters
		{
			get
			{
				if(r_Mop_Inequality_LODParameters_LODParameters == null)
				{
					r_Mop_Inequality_LODParameters_LODParameters = new(Type, "op_Inequality", 0, typeof(UnityEngine.Rendering.LODParameters), typeof(UnityEngine.Rendering.LODParameters));
				}
				return r_Mop_Inequality_LODParameters_LODParameters;
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


        public virtual System.Boolean Equals(UnityEngine.Rendering.LODParameters @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RMEquals_LODParameters.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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


        public static System.Boolean op_Equality(UnityEngine.Rendering.LODParameters @left, UnityEngine.Rendering.LODParameters @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Equality_LODParameters_LODParameters.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public static System.Boolean op_Inequality(UnityEngine.Rendering.LODParameters @left, UnityEngine.Rendering.LODParameters @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = RMop_Inequality_LODParameters_LODParameters.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
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
