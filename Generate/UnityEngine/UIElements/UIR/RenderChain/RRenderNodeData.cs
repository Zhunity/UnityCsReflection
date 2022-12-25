using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{public partial class RRenderChain
{
	
	/// <summary>
	/// UnityEngine.UIElements.UIR.RenderChain+RenderNodeData
	/// </summary>
    public partial class RRenderNodeData : RMember //
    {

		/// <summary>
		/// UnityEngine.Material standardMaterial
		/// </summary>
		protected RUnityEngine.RMaterial r_standardMaterial;
		public virtual RUnityEngine.RMaterial RstandardMaterial
		{
			get
			{
				if(r_standardMaterial == null)
				{
					r_standardMaterial = new(this, "standardMaterial");
					r_standardMaterial.SetBelong(this.instance);
				}
				return r_standardMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material initialMaterial
		/// </summary>
		protected RUnityEngine.RMaterial r_initialMaterial;
		public virtual RUnityEngine.RMaterial RinitialMaterial
		{
			get
			{
				if(r_initialMaterial == null)
				{
					r_initialMaterial = new(this, "initialMaterial");
					r_initialMaterial.SetBelong(this.instance);
				}
				return r_initialMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.MaterialPropertyBlock matPropBlock
		/// </summary>
		protected RUnityEngine.RMaterialPropertyBlock r_matPropBlock;
		public virtual RUnityEngine.RMaterialPropertyBlock RmatPropBlock
		{
			get
			{
				if(r_matPropBlock == null)
				{
					r_matPropBlock = new(this, "matPropBlock");
					r_matPropBlock.SetBelong(this.instance);
				}
				return r_matPropBlock;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand firstCommand
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_firstCommand;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainCommand RfirstCommand
		{
			get
			{
				if(r_firstCommand == null)
				{
					r_firstCommand = new(this, "firstCommand");
					r_firstCommand.SetBelong(this.instance);
				}
				return r_firstCommand;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.UIRenderDevice device
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RUIRenderDevice r_device;
		public virtual RUnityEngine.RUIElements.RUIR.RUIRenderDevice Rdevice
		{
			get
			{
				if(r_device == null)
				{
					r_device = new(this, "device");
					r_device.SetBelong(this.instance);
				}
				return r_device;
			}
		}

		/// <summary>
		/// UnityEngine.Texture vectorAtlas
		/// </summary>
		protected RUnityEngine.RTexture r_vectorAtlas;
		public virtual RUnityEngine.RTexture RvectorAtlas
		{
			get
			{
				if(r_vectorAtlas == null)
				{
					r_vectorAtlas = new(this, "vectorAtlas");
					r_vectorAtlas.SetBelong(this.instance);
				}
				return r_vectorAtlas;
			}
		}

		/// <summary>
		/// UnityEngine.Texture shaderInfoAtlas
		/// </summary>
		protected RUnityEngine.RTexture r_shaderInfoAtlas;
		public virtual RUnityEngine.RTexture RshaderInfoAtlas
		{
			get
			{
				if(r_shaderInfoAtlas == null)
				{
					r_shaderInfoAtlas = new(this, "shaderInfoAtlas");
					r_shaderInfoAtlas.SetBelong(this.instance);
				}
				return r_shaderInfoAtlas;
			}
		}

		/// <summary>
		/// System.Single dpiScale
		/// </summary>
		protected RField r_dpiScale;
		public virtual RField RdpiScale
		{
			get
			{
				if(r_dpiScale == null)
				{
					r_dpiScale = new(this, "dpiScale");
					r_dpiScale.SetBelong(this.instance);
				}
				return r_dpiScale;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[UnityEngine.UIElements.UIR.Transform3x4] transformConstants
		/// </summary>
		protected RField r_transformConstants;
		public virtual RField RtransformConstants
		{
			get
			{
				if(r_transformConstants == null)
				{
					r_transformConstants = new(this, "transformConstants");
					r_transformConstants.SetBelong(this.instance);
				}
				return r_transformConstants;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[UnityEngine.Vector4] clipRectConstants
		/// </summary>
		protected RField r_clipRectConstants;
		public virtual RField RclipRectConstants
		{
			get
			{
				if(r_clipRectConstants == null)
				{
					r_clipRectConstants = new(this, "clipRectConstants");
					r_clipRectConstants.SetBelong(this.instance);
				}
				return r_clipRectConstants;
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


        public RRenderNodeData() : base("UnityEngine.UIElements.UIR.RenderChain+RenderNodeData")
        {
        }

        public RRenderNodeData(System.Object instance) : base("UnityEngine.UIElements.UIR.RenderChain+RenderNodeData")
		{
            SetInstance(instance);
		}

        public RRenderNodeData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRenderNodeData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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