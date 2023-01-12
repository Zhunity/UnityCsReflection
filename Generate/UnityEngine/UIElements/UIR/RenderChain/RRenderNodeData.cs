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
		protected RUnityEngine.RMaterial r_FstandardMaterial;
		public virtual RUnityEngine.RMaterial RFstandardMaterial
		{
			get
			{
				if(r_FstandardMaterial == null)
				{
					r_FstandardMaterial = new(this, "standardMaterial");
					r_FstandardMaterial.SetBelong(this.instance);
				}
				return r_FstandardMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material initialMaterial
		/// </summary>
		protected RUnityEngine.RMaterial r_FinitialMaterial;
		public virtual RUnityEngine.RMaterial RFinitialMaterial
		{
			get
			{
				if(r_FinitialMaterial == null)
				{
					r_FinitialMaterial = new(this, "initialMaterial");
					r_FinitialMaterial.SetBelong(this.instance);
				}
				return r_FinitialMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.MaterialPropertyBlock matPropBlock
		/// </summary>
		protected RUnityEngine.RMaterialPropertyBlock r_FmatPropBlock;
		public virtual RUnityEngine.RMaterialPropertyBlock RFmatPropBlock
		{
			get
			{
				if(r_FmatPropBlock == null)
				{
					r_FmatPropBlock = new(this, "matPropBlock");
					r_FmatPropBlock.SetBelong(this.instance);
				}
				return r_FmatPropBlock;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand firstCommand
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_FfirstCommand;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainCommand RFfirstCommand
		{
			get
			{
				if(r_FfirstCommand == null)
				{
					r_FfirstCommand = new(this, "firstCommand");
					r_FfirstCommand.SetBelong(this.instance);
				}
				return r_FfirstCommand;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.UIRenderDevice device
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RUIRenderDevice r_Fdevice;
		public virtual RUnityEngine.RUIElements.RUIR.RUIRenderDevice RFdevice
		{
			get
			{
				if(r_Fdevice == null)
				{
					r_Fdevice = new(this, "device");
					r_Fdevice.SetBelong(this.instance);
				}
				return r_Fdevice;
			}
		}

		/// <summary>
		/// UnityEngine.Texture vectorAtlas
		/// </summary>
		protected RUnityEngine.RTexture r_FvectorAtlas;
		public virtual RUnityEngine.RTexture RFvectorAtlas
		{
			get
			{
				if(r_FvectorAtlas == null)
				{
					r_FvectorAtlas = new(this, "vectorAtlas");
					r_FvectorAtlas.SetBelong(this.instance);
				}
				return r_FvectorAtlas;
			}
		}

		/// <summary>
		/// UnityEngine.Texture shaderInfoAtlas
		/// </summary>
		protected RUnityEngine.RTexture r_FshaderInfoAtlas;
		public virtual RUnityEngine.RTexture RFshaderInfoAtlas
		{
			get
			{
				if(r_FshaderInfoAtlas == null)
				{
					r_FshaderInfoAtlas = new(this, "shaderInfoAtlas");
					r_FshaderInfoAtlas.SetBelong(this.instance);
				}
				return r_FshaderInfoAtlas;
			}
		}

		/// <summary>
		/// System.Single dpiScale
		/// </summary>
		protected RSystem.RSingle r_FdpiScale;
		public virtual RSystem.RSingle RFdpiScale
		{
			get
			{
				if(r_FdpiScale == null)
				{
					r_FdpiScale = new(this, "dpiScale");
					r_FdpiScale.SetBelong(this.instance);
				}
				return r_FdpiScale;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[UnityEngine.UIElements.UIR.Transform3x4] transformConstants
		/// </summary>
		protected RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RUIR.RTransform3x4> r_FtransformConstants;
		public virtual RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RUIR.RTransform3x4> RFtransformConstants
		{
			get
			{
				if(r_FtransformConstants == null)
				{
					r_FtransformConstants = new(this, "transformConstants");
					r_FtransformConstants.SetBelong(this.instance);
				}
				return r_FtransformConstants;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[UnityEngine.Vector4] clipRectConstants
		/// </summary>
		protected RUnity.RCollections.RNativeSlice<RUnityEngine.RVector4> r_FclipRectConstants;
		public virtual RUnity.RCollections.RNativeSlice<RUnityEngine.RVector4> RFclipRectConstants
		{
			get
			{
				if(r_FclipRectConstants == null)
				{
					r_FclipRectConstants = new(this, "clipRectConstants");
					r_FclipRectConstants.SetBelong(this.instance);
				}
				return r_FclipRectConstants;
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
					r_MEquals_Object.SetBelong(this.instance);
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
					r_MGetHashCode.SetBelong(this.instance);
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
					r_MToString.SetBelong(this.instance);
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
					r_MFinalize.SetBelong(this.instance);
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
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