
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation
{public partial class RUIRStylePainter
{
	
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
	/// UnityEngine.UIElements.UIR.Implementation.UIRStylePainter+Entry
	/// </summary>
    public partial class REntry : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.Implementation.UIRStylePainter+Entry");
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


		/// <summary>
		/// Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex] vertices
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> r_Fvertices;
		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> RFvertices
		{
			get
			{
				if(r_Fvertices == null)
				{
					r_Fvertices = new(this, "vertices");
				}
				return r_Fvertices;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[System.UInt16] indices
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RSystem.RUInt16> r_Findices;
		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RSystem.RUInt16> RFindices
		{
			get
			{
				if(r_Findices == null)
				{
					r_Findices = new(this, "indices");
				}
				return r_Findices;
			}
		}

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RMaterial r_Fmaterial;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RMaterial RFmaterial
		{
			get
			{
				if(r_Fmaterial == null)
				{
					r_Fmaterial = new(this, "material");
				}
				return r_Fmaterial;
			}
		}

		/// <summary>
		/// System.Single fontTexSDFScale
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RSingle r_FfontTexSDFScale;
		public virtual Hvak.Editor.Refleaction.RSystem.RSingle RFfontTexSDFScale
		{
			get
			{
				if(r_FfontTexSDFScale == null)
				{
					r_FfontTexSDFScale = new(this, "fontTexSDFScale");
				}
				return r_FfontTexSDFScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId texture
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId r_Ftexture;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId RFtexture
		{
			get
			{
				if(r_Ftexture == null)
				{
					r_Ftexture = new(this, "texture");
				}
				return r_Ftexture;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand customCommand
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_FcustomCommand;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand RFcustomCommand
		{
			get
			{
				if(r_FcustomCommand == null)
				{
					r_FcustomCommand = new(this, "customCommand");
				}
				return r_FcustomCommand;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc clipRectID
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc r_FclipRectID;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc RFclipRectID
		{
			get
			{
				if(r_FclipRectID == null)
				{
					r_FclipRectID = new(this, "clipRectID");
				}
				return r_FclipRectID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.VertexFlags addFlags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVertexFlags r_FaddFlags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVertexFlags RFaddFlags
		{
			get
			{
				if(r_FaddFlags == null)
				{
					r_FaddFlags = new(this, "addFlags");
				}
				return r_FaddFlags;
			}
		}

		/// <summary>
		/// System.Boolean uvIsDisplacement
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FuvIsDisplacement;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFuvIsDisplacement
		{
			get
			{
				if(r_FuvIsDisplacement == null)
				{
					r_FuvIsDisplacement = new(this, "uvIsDisplacement");
				}
				return r_FuvIsDisplacement;
			}
		}

		/// <summary>
		/// System.Boolean isTextEntry
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisTextEntry;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisTextEntry
		{
			get
			{
				if(r_FisTextEntry == null)
				{
					r_FisTextEntry = new(this, "isTextEntry");
				}
				return r_FisTextEntry;
			}
		}

		/// <summary>
		/// System.Boolean isClipRegisterEntry
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_FisClipRegisterEntry;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RFisClipRegisterEntry
		{
			get
			{
				if(r_FisClipRegisterEntry == null)
				{
					r_FisClipRegisterEntry = new(this, "isClipRegisterEntry");
				}
				return r_FisClipRegisterEntry;
			}
		}

		/// <summary>
		/// System.Int32 stencilRef
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FstencilRef;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFstencilRef
		{
			get
			{
				if(r_FstencilRef == null)
				{
					r_FstencilRef = new(this, "stencilRef");
				}
				return r_FstencilRef;
			}
		}

		/// <summary>
		/// System.Int32 maskDepth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_FmaskDepth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFmaskDepth
		{
			get
			{
				if(r_FmaskDepth == null)
				{
					r_FmaskDepth = new(this, "maskDepth");
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