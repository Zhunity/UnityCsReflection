
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RRendering
{
	/// <summary>
	/// UnityEngine.Rendering.RenderTargetBinding
	/// </summary>
    public partial class RRenderTargetBinding : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.Rendering.RenderTargetBinding);
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


		/// <summary>
		/// UnityEngine.Rendering.RenderTargetIdentifier[] m_ColorRenderTargets
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderTargetIdentifier> r_Fm_ColorRenderTargets;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderTargetIdentifier> RFm_ColorRenderTargets
		{
			get
			{
				if(r_Fm_ColorRenderTargets == null)
				{
					r_Fm_ColorRenderTargets = new(this, "m_ColorRenderTargets");
				}
				return r_Fm_ColorRenderTargets;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderTargetIdentifier m_DepthRenderTarget
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderTargetIdentifier r_Fm_DepthRenderTarget;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderTargetIdentifier RFm_DepthRenderTarget
		{
			get
			{
				if(r_Fm_DepthRenderTarget == null)
				{
					r_Fm_DepthRenderTarget = new(this, "m_DepthRenderTarget");
				}
				return r_Fm_DepthRenderTarget;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferLoadAction[] m_ColorLoadActions
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderBufferLoadAction> r_Fm_ColorLoadActions;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderBufferLoadAction> RFm_ColorLoadActions
		{
			get
			{
				if(r_Fm_ColorLoadActions == null)
				{
					r_Fm_ColorLoadActions = new(this, "m_ColorLoadActions");
				}
				return r_Fm_ColorLoadActions;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferStoreAction[] m_ColorStoreActions
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderBufferStoreAction> r_Fm_ColorStoreActions;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderBufferStoreAction> RFm_ColorStoreActions
		{
			get
			{
				if(r_Fm_ColorStoreActions == null)
				{
					r_Fm_ColorStoreActions = new(this, "m_ColorStoreActions");
				}
				return r_Fm_ColorStoreActions;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferLoadAction m_DepthLoadAction
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderBufferLoadAction r_Fm_DepthLoadAction;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderBufferLoadAction RFm_DepthLoadAction
		{
			get
			{
				if(r_Fm_DepthLoadAction == null)
				{
					r_Fm_DepthLoadAction = new(this, "m_DepthLoadAction");
				}
				return r_Fm_DepthLoadAction;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferStoreAction m_DepthStoreAction
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderBufferStoreAction r_Fm_DepthStoreAction;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderBufferStoreAction RFm_DepthStoreAction
		{
			get
			{
				if(r_Fm_DepthStoreAction == null)
				{
					r_Fm_DepthStoreAction = new(this, "m_DepthStoreAction");
				}
				return r_Fm_DepthStoreAction;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderTargetFlags m_Flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderTargetFlags r_Fm_Flags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderTargetFlags RFm_Flags
		{
			get
			{
				if(r_Fm_Flags == null)
				{
					r_Fm_Flags = new(this, "m_Flags");
				}
				return r_Fm_Flags;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderTargetIdentifier[] colorRenderTargets
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderTargetIdentifier> r_PcolorRenderTargets;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderTargetIdentifier> RPcolorRenderTargets
		{
			get
			{
				if(r_PcolorRenderTargets == null)
				{
					r_PcolorRenderTargets = new(this, "colorRenderTargets", -1);
				}
				return r_PcolorRenderTargets;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderTargetIdentifier depthRenderTarget
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderTargetIdentifier r_PdepthRenderTarget;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderTargetIdentifier RPdepthRenderTarget
		{
			get
			{
				if(r_PdepthRenderTarget == null)
				{
					r_PdepthRenderTarget = new(this, "depthRenderTarget", -1);
				}
				return r_PdepthRenderTarget;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderBufferLoadAction> r_PcolorLoadActions;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderBufferLoadAction> RPcolorLoadActions
		{
			get
			{
				if(r_PcolorLoadActions == null)
				{
					r_PcolorLoadActions = new(this, "colorLoadActions", -1);
				}
				return r_PcolorLoadActions;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions
		/// </summary>
		protected Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderBufferStoreAction> r_PcolorStoreActions;
		public virtual Hvak.Editor.Refleaction.RPropertyArray<Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderBufferStoreAction> RPcolorStoreActions
		{
			get
			{
				if(r_PcolorStoreActions == null)
				{
					r_PcolorStoreActions = new(this, "colorStoreActions", -1);
				}
				return r_PcolorStoreActions;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderBufferLoadAction r_PdepthLoadAction;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderBufferLoadAction RPdepthLoadAction
		{
			get
			{
				if(r_PdepthLoadAction == null)
				{
					r_PdepthLoadAction = new(this, "depthLoadAction", -1);
				}
				return r_PdepthLoadAction;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderBufferStoreAction r_PdepthStoreAction;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderBufferStoreAction RPdepthStoreAction
		{
			get
			{
				if(r_PdepthStoreAction == null)
				{
					r_PdepthStoreAction = new(this, "depthStoreAction", -1);
				}
				return r_PdepthStoreAction;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.RenderTargetFlags flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderTargetFlags r_Pflags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RRendering.RRenderTargetFlags RPflags
		{
			get
			{
				if(r_Pflags == null)
				{
					r_Pflags = new(this, "flags", -1);
				}
				return r_Pflags;
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
