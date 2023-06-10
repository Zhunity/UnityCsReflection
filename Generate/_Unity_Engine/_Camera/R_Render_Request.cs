
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine
{public partial class RCamera
{
	
	/// <summary>
	/// UnityEngine.Camera+RenderRequest
	/// </summary>
    public partial class RRenderRequest : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.Camera+RenderRequest");
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


		/// <summary>
		/// UnityEngine.Camera+RenderRequestMode m_CameraRenderMode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode r_Fm_CameraRenderMode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode RFm_CameraRenderMode
		{
			get
			{
				if(r_Fm_CameraRenderMode == null)
				{
					r_Fm_CameraRenderMode = new(this, "m_CameraRenderMode");
				}
				return r_Fm_CameraRenderMode;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture m_ResultRT
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture r_Fm_ResultRT;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture RFm_ResultRT
		{
			get
			{
				if(r_Fm_ResultRT == null)
				{
					r_Fm_ResultRT = new(this, "m_ResultRT");
				}
				return r_Fm_ResultRT;
			}
		}

		/// <summary>
		/// UnityEngine.Camera+RenderRequestOutputSpace m_OutputSpace
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestOutputSpace r_Fm_OutputSpace;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestOutputSpace RFm_OutputSpace
		{
			get
			{
				if(r_Fm_OutputSpace == null)
				{
					r_Fm_OutputSpace = new(this, "m_OutputSpace");
				}
				return r_Fm_OutputSpace;
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
		/// RenderRequestMode mode
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode r_Pmode;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestMode RPmode
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
		/// UnityEngine.RenderTexture result
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture r_Presult;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRenderTexture RPresult
		{
			get
			{
				if(r_Presult == null)
				{
					r_Presult = new(this, "result", -1);
				}
				return r_Presult;
			}
		}

		/// <summary>
		/// RenderRequestOutputSpace outputSpace
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestOutputSpace r_PoutputSpace;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RCamera.RRenderRequestOutputSpace RPoutputSpace
		{
			get
			{
				if(r_PoutputSpace == null)
				{
					r_PoutputSpace = new(this, "outputSpace", -1);
				}
				return r_PoutputSpace;
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

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
}