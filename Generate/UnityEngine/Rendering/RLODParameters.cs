using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.LODParameters
	/// </summary>
    public partial class RLODParameters : RMember //
    {

		/// <summary>
		/// System.Int32 m_IsOrthographic
		/// </summary>
		protected RField r_m_IsOrthographic;
		public virtual RField Rm_IsOrthographic
		{
			get
			{
				if(r_m_IsOrthographic == null)
				{
					r_m_IsOrthographic = new(this, "m_IsOrthographic");
					r_m_IsOrthographic.SetBelong(this.instance);
				}
				return r_m_IsOrthographic;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_CameraPosition
		/// </summary>
		protected RUnityEngine.RVector3 r_m_CameraPosition;
		public virtual RUnityEngine.RVector3 Rm_CameraPosition
		{
			get
			{
				if(r_m_CameraPosition == null)
				{
					r_m_CameraPosition = new(this, "m_CameraPosition");
					r_m_CameraPosition.SetBelong(this.instance);
				}
				return r_m_CameraPosition;
			}
		}

		/// <summary>
		/// System.Single m_FieldOfView
		/// </summary>
		protected RField r_m_FieldOfView;
		public virtual RField Rm_FieldOfView
		{
			get
			{
				if(r_m_FieldOfView == null)
				{
					r_m_FieldOfView = new(this, "m_FieldOfView");
					r_m_FieldOfView.SetBelong(this.instance);
				}
				return r_m_FieldOfView;
			}
		}

		/// <summary>
		/// System.Single m_OrthoSize
		/// </summary>
		protected RField r_m_OrthoSize;
		public virtual RField Rm_OrthoSize
		{
			get
			{
				if(r_m_OrthoSize == null)
				{
					r_m_OrthoSize = new(this, "m_OrthoSize");
					r_m_OrthoSize.SetBelong(this.instance);
				}
				return r_m_OrthoSize;
			}
		}

		/// <summary>
		/// System.Int32 m_CameraPixelHeight
		/// </summary>
		protected RField r_m_CameraPixelHeight;
		public virtual RField Rm_CameraPixelHeight
		{
			get
			{
				if(r_m_CameraPixelHeight == null)
				{
					r_m_CameraPixelHeight = new(this, "m_CameraPixelHeight");
					r_m_CameraPixelHeight.SetBelong(this.instance);
				}
				return r_m_CameraPixelHeight;
			}
		}

		/// <summary>
		/// Boolean isOrthographic
		/// </summary>
		protected RProperty r_isOrthographic;
		public virtual RProperty RisOrthographic
		{
			get
			{
				if(r_isOrthographic == null)
				{
					r_isOrthographic = new(this, "isOrthographic", -1);
					r_isOrthographic.SetBelong(this.instance);
				}
				return r_isOrthographic;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 cameraPosition
		/// </summary>
		protected RUnityEngine.RVector3 r_cameraPosition;
		public virtual RUnityEngine.RVector3 RcameraPosition
		{
			get
			{
				if(r_cameraPosition == null)
				{
					r_cameraPosition = new(this, "cameraPosition", -1);
					r_cameraPosition.SetBelong(this.instance);
				}
				return r_cameraPosition;
			}
		}

		/// <summary>
		/// Single fieldOfView
		/// </summary>
		protected RProperty r_fieldOfView;
		public virtual RProperty RfieldOfView
		{
			get
			{
				if(r_fieldOfView == null)
				{
					r_fieldOfView = new(this, "fieldOfView", -1);
					r_fieldOfView.SetBelong(this.instance);
				}
				return r_fieldOfView;
			}
		}

		/// <summary>
		/// Single orthoSize
		/// </summary>
		protected RProperty r_orthoSize;
		public virtual RProperty RorthoSize
		{
			get
			{
				if(r_orthoSize == null)
				{
					r_orthoSize = new(this, "orthoSize", -1);
					r_orthoSize.SetBelong(this.instance);
				}
				return r_orthoSize;
			}
		}

		/// <summary>
		/// Int32 cameraPixelHeight
		/// </summary>
		protected RProperty r_cameraPixelHeight;
		public virtual RProperty RcameraPixelHeight
		{
			get
			{
				if(r_cameraPixelHeight == null)
				{
					r_cameraPixelHeight = new(this, "cameraPixelHeight", -1);
					r_cameraPixelHeight.SetBelong(this.instance);
				}
				return r_cameraPixelHeight;
			}
		}

		/// <summary>
		/// Boolean Equals(UnityEngine.Rendering.LODParameters)
		/// </summary>
		protected RMethod r_REquals_LODParameters;
		public virtual RMethod REquals_LODParameters
		{
			get
			{
				if(r_REquals_LODParameters == null)
				{
					r_REquals_LODParameters = new(this, "Equals", 0, typeof(UnityEngine.Rendering.LODParameters));
					r_REquals_LODParameters.SetBelong(this.instance);
				}
				return r_REquals_LODParameters;
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
		/// Boolean op_Equality(UnityEngine.Rendering.LODParameters, UnityEngine.Rendering.LODParameters)
		/// </summary>
		protected static RMethod r_Rop_Equality_LODParameters_LODParameters;
		public static RMethod Rop_Equality_LODParameters_LODParameters
		{
			get
			{
				if(r_Rop_Equality_LODParameters_LODParameters == null)
				{
					r_Rop_Equality_LODParameters_LODParameters = new(typeof(UnityEngine.Rendering.LODParameters), "op_Equality", 0, typeof(UnityEngine.Rendering.LODParameters), typeof(UnityEngine.Rendering.LODParameters));
					r_Rop_Equality_LODParameters_LODParameters.SetBelong(null);
				}
				return r_Rop_Equality_LODParameters_LODParameters;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(UnityEngine.Rendering.LODParameters, UnityEngine.Rendering.LODParameters)
		/// </summary>
		protected static RMethod r_Rop_Inequality_LODParameters_LODParameters;
		public static RMethod Rop_Inequality_LODParameters_LODParameters
		{
			get
			{
				if(r_Rop_Inequality_LODParameters_LODParameters == null)
				{
					r_Rop_Inequality_LODParameters_LODParameters = new(typeof(UnityEngine.Rendering.LODParameters), "op_Inequality", 0, typeof(UnityEngine.Rendering.LODParameters), typeof(UnityEngine.Rendering.LODParameters));
					r_Rop_Inequality_LODParameters_LODParameters.SetBelong(null);
				}
				return r_Rop_Inequality_LODParameters_LODParameters;
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

        public virtual System.Boolean Equals(UnityEngine.Rendering.LODParameters  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_LODParameters.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public static System.Boolean op_Equality(UnityEngine.Rendering.LODParameters  @left, UnityEngine.Rendering.LODParameters  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Equality_LODParameters_LODParameters.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(UnityEngine.Rendering.LODParameters  @left, UnityEngine.Rendering.LODParameters  @right)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @right};
            var ___result = Rop_Inequality_LODParameters_LODParameters.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
