
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{public partial class RRenderChain
{
	
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.UIR.RenderChain+RenderNodeData
	/// </summary>
    public partial class RRenderNodeData : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChain+RenderNodeData");
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


		/// <summary>
		/// UnityEngine.Material standardMaterial
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterial r_FstandardMaterial;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterial RFstandardMaterial
		{
			get
			{
				if(r_FstandardMaterial == null)
				{
					r_FstandardMaterial = new(this, "standardMaterial");
				}
				return r_FstandardMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material initialMaterial
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterial r_FinitialMaterial;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterial RFinitialMaterial
		{
			get
			{
				if(r_FinitialMaterial == null)
				{
					r_FinitialMaterial = new(this, "initialMaterial");
				}
				return r_FinitialMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.MaterialPropertyBlock matPropBlock
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterialPropertyBlock r_FmatPropBlock;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterialPropertyBlock RFmatPropBlock
		{
			get
			{
				if(r_FmatPropBlock == null)
				{
					r_FmatPropBlock = new(this, "matPropBlock");
				}
				return r_FmatPropBlock;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand firstCommand
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_FfirstCommand;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand RFfirstCommand
		{
			get
			{
				if(r_FfirstCommand == null)
				{
					r_FfirstCommand = new(this, "firstCommand");
				}
				return r_FfirstCommand;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.UIRenderDevice device
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RUIRenderDevice r_Fdevice;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RUIRenderDevice RFdevice
		{
			get
			{
				if(r_Fdevice == null)
				{
					r_Fdevice = new(this, "device");
				}
				return r_Fdevice;
			}
		}

		/// <summary>
		/// UnityEngine.Texture vectorAtlas
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture r_FvectorAtlas;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture RFvectorAtlas
		{
			get
			{
				if(r_FvectorAtlas == null)
				{
					r_FvectorAtlas = new(this, "vectorAtlas");
				}
				return r_FvectorAtlas;
			}
		}

		/// <summary>
		/// UnityEngine.Texture shaderInfoAtlas
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTexture r_FshaderInfoAtlas;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTexture RFshaderInfoAtlas
		{
			get
			{
				if(r_FshaderInfoAtlas == null)
				{
					r_FshaderInfoAtlas = new(this, "shaderInfoAtlas");
				}
				return r_FshaderInfoAtlas;
			}
		}

		/// <summary>
		/// System.Single dpiScale
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FdpiScale;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFdpiScale
		{
			get
			{
				if(r_FdpiScale == null)
				{
					r_FdpiScale = new(this, "dpiScale");
				}
				return r_FdpiScale;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[UnityEngine.UIElements.UIR.Transform3x4] transformConstants
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTransform3x4> r_FtransformConstants;
		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTransform3x4> RFtransformConstants
		{
			get
			{
				if(r_FtransformConstants == null)
				{
					r_FtransformConstants = new(this, "transformConstants");
				}
				return r_FtransformConstants;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[UnityEngine.Vector4] clipRectConstants
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RUnityEngine.RVector4> r_FclipRectConstants;
		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RUnityEngine.RVector4> RFclipRectConstants
		{
			get
			{
				if(r_FclipRectConstants == null)
				{
					r_FclipRectConstants = new(this, "clipRectConstants");
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