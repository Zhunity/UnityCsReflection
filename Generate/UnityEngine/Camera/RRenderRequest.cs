using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{public partial class RCamera
{
	
	/// <summary>
	/// UnityEngine.Camera+RenderRequest
	/// </summary>
    public partial class RRenderRequest : RMember //
    {

		/// <summary>
		/// UnityEngine.Camera+RenderRequestMode m_CameraRenderMode
		/// </summary>
		protected RField r_m_CameraRenderMode;
		public virtual RField Rm_CameraRenderMode
		{
			get
			{
				if(r_m_CameraRenderMode == null)
				{
					r_m_CameraRenderMode = new(this, "m_CameraRenderMode");
					r_m_CameraRenderMode.SetBelong(this.instance);
				}
				return r_m_CameraRenderMode;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture m_ResultRT
		/// </summary>
		protected RUnityEngine.RRenderTexture r_m_ResultRT;
		public virtual RUnityEngine.RRenderTexture Rm_ResultRT
		{
			get
			{
				if(r_m_ResultRT == null)
				{
					r_m_ResultRT = new(this, "m_ResultRT");
					r_m_ResultRT.SetBelong(this.instance);
				}
				return r_m_ResultRT;
			}
		}

		/// <summary>
		/// UnityEngine.Camera+RenderRequestOutputSpace m_OutputSpace
		/// </summary>
		protected RField r_m_OutputSpace;
		public virtual RField Rm_OutputSpace
		{
			get
			{
				if(r_m_OutputSpace == null)
				{
					r_m_OutputSpace = new(this, "m_OutputSpace");
					r_m_OutputSpace.SetBelong(this.instance);
				}
				return r_m_OutputSpace;
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
		/// RenderRequestMode mode
		/// </summary>
		protected RProperty r_mode;
		public virtual RProperty Rmode
		{
			get
			{
				if(r_mode == null)
				{
					r_mode = new(this, "mode", -1);
					r_mode.SetBelong(this.instance);
				}
				return r_mode;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture result
		/// </summary>
		protected RUnityEngine.RRenderTexture r_result;
		public virtual RUnityEngine.RRenderTexture Rresult
		{
			get
			{
				if(r_result == null)
				{
					r_result = new(this, "result", -1);
					r_result.SetBelong(this.instance);
				}
				return r_result;
			}
		}

		/// <summary>
		/// RenderRequestOutputSpace outputSpace
		/// </summary>
		protected RProperty r_outputSpace;
		public virtual RProperty RoutputSpace
		{
			get
			{
				if(r_outputSpace == null)
				{
					r_outputSpace = new(this, "outputSpace", -1);
					r_outputSpace.SetBelong(this.instance);
				}
				return r_outputSpace;
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


        public RRenderRequest() : base("UnityEngine.Camera+RenderRequest")
        {
        }

        public RRenderRequest(System.Object instance) : base("UnityEngine.Camera+RenderRequest")
		{
            SetInstance(instance);
		}

        public RRenderRequest(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRenderRequest(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
}