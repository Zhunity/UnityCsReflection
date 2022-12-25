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
		protected RField r_vertices;
		public virtual RField Rvertices
		{
			get
			{
				if(r_vertices == null)
				{
					r_vertices = new(this, "vertices");
					r_vertices.SetBelong(this.instance);
				}
				return r_vertices;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[System.UInt16] indices
		/// </summary>
		protected RField r_indices;
		public virtual RField Rindices
		{
			get
			{
				if(r_indices == null)
				{
					r_indices = new(this, "indices");
					r_indices.SetBelong(this.instance);
				}
				return r_indices;
			}
		}

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected RUnityEngine.RMaterial r_material;
		public virtual RUnityEngine.RMaterial Rmaterial
		{
			get
			{
				if(r_material == null)
				{
					r_material = new(this, "material");
					r_material.SetBelong(this.instance);
				}
				return r_material;
			}
		}

		/// <summary>
		/// System.Single fontTexSDFScale
		/// </summary>
		protected RField r_fontTexSDFScale;
		public virtual RField RfontTexSDFScale
		{
			get
			{
				if(r_fontTexSDFScale == null)
				{
					r_fontTexSDFScale = new(this, "fontTexSDFScale");
					r_fontTexSDFScale.SetBelong(this.instance);
				}
				return r_fontTexSDFScale;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId texture
		/// </summary>
		protected RUnityEngine.RUIElements.RTextureId r_texture;
		public virtual RUnityEngine.RUIElements.RTextureId Rtexture
		{
			get
			{
				if(r_texture == null)
				{
					r_texture = new(this, "texture");
					r_texture.SetBelong(this.instance);
				}
				return r_texture;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand customCommand
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_customCommand;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainCommand RcustomCommand
		{
			get
			{
				if(r_customCommand == null)
				{
					r_customCommand = new(this, "customCommand");
					r_customCommand.SetBelong(this.instance);
				}
				return r_customCommand;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc clipRectID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_clipRectID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RclipRectID
		{
			get
			{
				if(r_clipRectID == null)
				{
					r_clipRectID = new(this, "clipRectID");
					r_clipRectID.SetBelong(this.instance);
				}
				return r_clipRectID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.VertexFlags addFlags
		/// </summary>
		protected RField r_addFlags;
		public virtual RField RaddFlags
		{
			get
			{
				if(r_addFlags == null)
				{
					r_addFlags = new(this, "addFlags");
					r_addFlags.SetBelong(this.instance);
				}
				return r_addFlags;
			}
		}

		/// <summary>
		/// System.Boolean uvIsDisplacement
		/// </summary>
		protected RField r_uvIsDisplacement;
		public virtual RField RuvIsDisplacement
		{
			get
			{
				if(r_uvIsDisplacement == null)
				{
					r_uvIsDisplacement = new(this, "uvIsDisplacement");
					r_uvIsDisplacement.SetBelong(this.instance);
				}
				return r_uvIsDisplacement;
			}
		}

		/// <summary>
		/// System.Boolean isTextEntry
		/// </summary>
		protected RField r_isTextEntry;
		public virtual RField RisTextEntry
		{
			get
			{
				if(r_isTextEntry == null)
				{
					r_isTextEntry = new(this, "isTextEntry");
					r_isTextEntry.SetBelong(this.instance);
				}
				return r_isTextEntry;
			}
		}

		/// <summary>
		/// System.Boolean isClipRegisterEntry
		/// </summary>
		protected RField r_isClipRegisterEntry;
		public virtual RField RisClipRegisterEntry
		{
			get
			{
				if(r_isClipRegisterEntry == null)
				{
					r_isClipRegisterEntry = new(this, "isClipRegisterEntry");
					r_isClipRegisterEntry.SetBelong(this.instance);
				}
				return r_isClipRegisterEntry;
			}
		}

		/// <summary>
		/// System.Int32 stencilRef
		/// </summary>
		protected RField r_stencilRef;
		public virtual RField RstencilRef
		{
			get
			{
				if(r_stencilRef == null)
				{
					r_stencilRef = new(this, "stencilRef");
					r_stencilRef.SetBelong(this.instance);
				}
				return r_stencilRef;
			}
		}

		/// <summary>
		/// System.Int32 maskDepth
		/// </summary>
		protected RField r_maskDepth;
		public virtual RField RmaskDepth
		{
			get
			{
				if(r_maskDepth == null)
				{
					r_maskDepth = new(this, "maskDepth");
					r_maskDepth.SetBelong(this.instance);
				}
				return r_maskDepth;
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