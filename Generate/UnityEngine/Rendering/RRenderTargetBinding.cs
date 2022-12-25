using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.RenderTargetBinding
	/// </summary>
    public partial class RRenderTargetBinding : RMember //
    {

		/// <summary>
		/// UnityEngine.Rendering.RenderTargetIdentifier[] m_ColorRenderTargets
		/// </summary>
		protected RFieldArray<RUnityEngine.RRendering.RRenderTargetIdentifier> r_m_ColorRenderTargets;
		public virtual RFieldArray<RUnityEngine.RRendering.RRenderTargetIdentifier> Rm_ColorRenderTargets
		{
			get
			{
				if(r_m_ColorRenderTargets == null)
				{
					r_m_ColorRenderTargets = new(this, "m_ColorRenderTargets");
					r_m_ColorRenderTargets.SetBelong(this.instance);
				}
				return r_m_ColorRenderTargets;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderTargetIdentifier m_DepthRenderTarget
		/// </summary>
		protected RUnityEngine.RRendering.RRenderTargetIdentifier r_m_DepthRenderTarget;
		public virtual RUnityEngine.RRendering.RRenderTargetIdentifier Rm_DepthRenderTarget
		{
			get
			{
				if(r_m_DepthRenderTarget == null)
				{
					r_m_DepthRenderTarget = new(this, "m_DepthRenderTarget");
					r_m_DepthRenderTarget.SetBelong(this.instance);
				}
				return r_m_DepthRenderTarget;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferLoadAction[] m_ColorLoadActions
		/// </summary>
		protected RFieldArray<RField> r_m_ColorLoadActions;
		public virtual RFieldArray<RField> Rm_ColorLoadActions
		{
			get
			{
				if(r_m_ColorLoadActions == null)
				{
					r_m_ColorLoadActions = new(this, "m_ColorLoadActions");
					r_m_ColorLoadActions.SetBelong(this.instance);
				}
				return r_m_ColorLoadActions;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferStoreAction[] m_ColorStoreActions
		/// </summary>
		protected RFieldArray<RField> r_m_ColorStoreActions;
		public virtual RFieldArray<RField> Rm_ColorStoreActions
		{
			get
			{
				if(r_m_ColorStoreActions == null)
				{
					r_m_ColorStoreActions = new(this, "m_ColorStoreActions");
					r_m_ColorStoreActions.SetBelong(this.instance);
				}
				return r_m_ColorStoreActions;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferLoadAction m_DepthLoadAction
		/// </summary>
		protected RField r_m_DepthLoadAction;
		public virtual RField Rm_DepthLoadAction
		{
			get
			{
				if(r_m_DepthLoadAction == null)
				{
					r_m_DepthLoadAction = new(this, "m_DepthLoadAction");
					r_m_DepthLoadAction.SetBelong(this.instance);
				}
				return r_m_DepthLoadAction;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferStoreAction m_DepthStoreAction
		/// </summary>
		protected RField r_m_DepthStoreAction;
		public virtual RField Rm_DepthStoreAction
		{
			get
			{
				if(r_m_DepthStoreAction == null)
				{
					r_m_DepthStoreAction = new(this, "m_DepthStoreAction");
					r_m_DepthStoreAction.SetBelong(this.instance);
				}
				return r_m_DepthStoreAction;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderTargetFlags m_Flags
		/// </summary>
		protected RField r_m_Flags;
		public virtual RField Rm_Flags
		{
			get
			{
				if(r_m_Flags == null)
				{
					r_m_Flags = new(this, "m_Flags");
					r_m_Flags.SetBelong(this.instance);
				}
				return r_m_Flags;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderTargetIdentifier[] colorRenderTargets
		/// </summary>
		protected RPropertyArray<RUnityEngine.RRendering.RRenderTargetIdentifier> r_colorRenderTargets;
		public virtual RPropertyArray<RUnityEngine.RRendering.RRenderTargetIdentifier> RcolorRenderTargets
		{
			get
			{
				if(r_colorRenderTargets == null)
				{
					r_colorRenderTargets = new(this, "colorRenderTargets", -1);
					r_colorRenderTargets.SetBelong(this.instance);
				}
				return r_colorRenderTargets;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderTargetIdentifier depthRenderTarget
		/// </summary>
		protected RUnityEngine.RRendering.RRenderTargetIdentifier r_depthRenderTarget;
		public virtual RUnityEngine.RRendering.RRenderTargetIdentifier RdepthRenderTarget
		{
			get
			{
				if(r_depthRenderTarget == null)
				{
					r_depthRenderTarget = new(this, "depthRenderTarget", -1);
					r_depthRenderTarget.SetBelong(this.instance);
				}
				return r_depthRenderTarget;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions
		/// </summary>
		protected RPropertyArray<RProperty> r_colorLoadActions;
		public virtual RPropertyArray<RProperty> RcolorLoadActions
		{
			get
			{
				if(r_colorLoadActions == null)
				{
					r_colorLoadActions = new(this, "colorLoadActions", -1);
					r_colorLoadActions.SetBelong(this.instance);
				}
				return r_colorLoadActions;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions
		/// </summary>
		protected RPropertyArray<RProperty> r_colorStoreActions;
		public virtual RPropertyArray<RProperty> RcolorStoreActions
		{
			get
			{
				if(r_colorStoreActions == null)
				{
					r_colorStoreActions = new(this, "colorStoreActions", -1);
					r_colorStoreActions.SetBelong(this.instance);
				}
				return r_colorStoreActions;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction
		/// </summary>
		protected RProperty r_depthLoadAction;
		public virtual RProperty RdepthLoadAction
		{
			get
			{
				if(r_depthLoadAction == null)
				{
					r_depthLoadAction = new(this, "depthLoadAction", -1);
					r_depthLoadAction.SetBelong(this.instance);
				}
				return r_depthLoadAction;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction
		/// </summary>
		protected RProperty r_depthStoreAction;
		public virtual RProperty RdepthStoreAction
		{
			get
			{
				if(r_depthStoreAction == null)
				{
					r_depthStoreAction = new(this, "depthStoreAction", -1);
					r_depthStoreAction.SetBelong(this.instance);
				}
				return r_depthStoreAction;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderTargetFlags flags
		/// </summary>
		protected RProperty r_flags;
		public virtual RProperty Rflags
		{
			get
			{
				if(r_flags == null)
				{
					r_flags = new(this, "flags", -1);
					r_flags.SetBelong(this.instance);
				}
				return r_flags;
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


        public RRenderTargetBinding() : base("UnityEngine.Rendering.RenderTargetBinding")
        {
        }

        public RRenderTargetBinding(System.Object instance) : base("UnityEngine.Rendering.RenderTargetBinding")
		{
            SetInstance(instance);
		}

        public RRenderTargetBinding(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRenderTargetBinding(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
