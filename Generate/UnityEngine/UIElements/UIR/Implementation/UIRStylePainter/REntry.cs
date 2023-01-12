using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation
{public partial class RUIRStylePainter
{
	
	/// <summary>
	/// UnityEngine.UIElements.UIR.Implementation.UIRStylePainter+Entry
	/// </summary>
    public partial class REntry : RMember //
    {

		/// <summary>
		/// Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex] vertices
		/// </summary>
		protected RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RVertex> r_Fvertices;
		public virtual RUnity.RCollections.RNativeSlice<RUnityEngine.RUIElements.RVertex> RFvertices
		{
			get
			{
				if(r_Fvertices == null)
				{
					r_Fvertices = new(this, "vertices");
					r_Fvertices.SetBelong(this.instance);
				}
				return r_Fvertices;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[System.UInt16] indices
		/// </summary>
		protected RUnity.RCollections.RNativeSlice<RSystem.RUInt16> r_Findices;
		public virtual RUnity.RCollections.RNativeSlice<RSystem.RUInt16> RFindices
		{
			get
			{
				if(r_Findices == null)
				{
					r_Findices = new(this, "indices");
					r_Findices.SetBelong(this.instance);
				}
				return r_Findices;
			}
		}

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected RUnityEngine.RMaterial r_Fmaterial;
		public virtual RUnityEngine.RMaterial RFmaterial
		{
			get
			{
				if(r_Fmaterial == null)
				{
					r_Fmaterial = new(this, "material");
					r_Fmaterial.SetBelong(this.instance);
				}
				return r_Fmaterial;
			}
		}

		/// <summary>
		/// System.Single fontTexSDFScale
		/// </summary>
		protected RSystem.RSingle r_FfontTexSDFScale;
		public virtual RSystem.RSingle RFfontTexSDFScale
		{
			get
			{
				if(r_FfontTexSDFScale == null)
				{
					r_FfontTexSDFScale = new(this, "fontTexSDFScale");
					r_FfontTexSDFScale.SetBelong(this.instance);
				}
				return r_FfontTexSDFScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId texture
		/// </summary>
		protected RUnityEngine.RUIElements.RTextureId r_Ftexture;
		public virtual RUnityEngine.RUIElements.RTextureId RFtexture
		{
			get
			{
				if(r_Ftexture == null)
				{
					r_Ftexture = new(this, "texture");
					r_Ftexture.SetBelong(this.instance);
				}
				return r_Ftexture;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand customCommand
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_FcustomCommand;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainCommand RFcustomCommand
		{
			get
			{
				if(r_FcustomCommand == null)
				{
					r_FcustomCommand = new(this, "customCommand");
					r_FcustomCommand.SetBelong(this.instance);
				}
				return r_FcustomCommand;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc clipRectID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_FclipRectID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RFclipRectID
		{
			get
			{
				if(r_FclipRectID == null)
				{
					r_FclipRectID = new(this, "clipRectID");
					r_FclipRectID.SetBelong(this.instance);
				}
				return r_FclipRectID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.VertexFlags addFlags
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RVertexFlags r_FaddFlags;
		public virtual RUnityEngine.RUIElements.RUIR.RVertexFlags RFaddFlags
		{
			get
			{
				if(r_FaddFlags == null)
				{
					r_FaddFlags = new(this, "addFlags");
					r_FaddFlags.SetBelong(this.instance);
				}
				return r_FaddFlags;
			}
		}

		/// <summary>
		/// System.Boolean uvIsDisplacement
		/// </summary>
		protected RSystem.RBoolean r_FuvIsDisplacement;
		public virtual RSystem.RBoolean RFuvIsDisplacement
		{
			get
			{
				if(r_FuvIsDisplacement == null)
				{
					r_FuvIsDisplacement = new(this, "uvIsDisplacement");
					r_FuvIsDisplacement.SetBelong(this.instance);
				}
				return r_FuvIsDisplacement;
			}
		}

		/// <summary>
		/// System.Boolean isTextEntry
		/// </summary>
		protected RSystem.RBoolean r_FisTextEntry;
		public virtual RSystem.RBoolean RFisTextEntry
		{
			get
			{
				if(r_FisTextEntry == null)
				{
					r_FisTextEntry = new(this, "isTextEntry");
					r_FisTextEntry.SetBelong(this.instance);
				}
				return r_FisTextEntry;
			}
		}

		/// <summary>
		/// System.Boolean isClipRegisterEntry
		/// </summary>
		protected RSystem.RBoolean r_FisClipRegisterEntry;
		public virtual RSystem.RBoolean RFisClipRegisterEntry
		{
			get
			{
				if(r_FisClipRegisterEntry == null)
				{
					r_FisClipRegisterEntry = new(this, "isClipRegisterEntry");
					r_FisClipRegisterEntry.SetBelong(this.instance);
				}
				return r_FisClipRegisterEntry;
			}
		}

		/// <summary>
		/// System.Int32 stencilRef
		/// </summary>
		protected RSystem.RInt32 r_FstencilRef;
		public virtual RSystem.RInt32 RFstencilRef
		{
			get
			{
				if(r_FstencilRef == null)
				{
					r_FstencilRef = new(this, "stencilRef");
					r_FstencilRef.SetBelong(this.instance);
				}
				return r_FstencilRef;
			}
		}

		/// <summary>
		/// System.Int32 maskDepth
		/// </summary>
		protected RSystem.RInt32 r_FmaskDepth;
		public virtual RSystem.RInt32 RFmaskDepth
		{
			get
			{
				if(r_FmaskDepth == null)
				{
					r_FmaskDepth = new(this, "maskDepth");
					r_FmaskDepth.SetBelong(this.instance);
				}
				return r_FmaskDepth;
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


        public REntry() : base("UnityEngine.UIElements.UIR.Implementation.UIRStylePainter+Entry")
        {
        }

        public REntry(System.Object instance) : base("UnityEngine.UIElements.UIR.Implementation.UIRStylePainter+Entry")
		{
            SetInstance(instance);
		}

        public REntry(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REntry(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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