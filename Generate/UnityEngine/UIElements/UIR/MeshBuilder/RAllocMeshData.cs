using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{public partial class RMeshBuilder
{
	
	/// <summary>
	/// UnityEngine.UIElements.UIR.MeshBuilder+AllocMeshData
	/// </summary>
    public partial class RAllocMeshData : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.UIR.MeshBuilder+AllocMeshData+Allocator alloc
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RMeshBuilder.RAllocMeshData.RAllocator r_alloc;
		public virtual RUnityEngine.RUIElements.RUIR.RMeshBuilder.RAllocMeshData.RAllocator Ralloc
		{
			get
			{
				if(r_alloc == null)
				{
					r_alloc = new(this, "alloc");
					r_alloc.SetBelong(this.instance);
				}
				return r_alloc;
			}
		}

		/// <summary>
		/// UnityEngine.Texture texture
		/// </summary>
		protected RUnityEngine.RTexture r_texture;
		public virtual RUnityEngine.RTexture Rtexture
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
		/// UnityEngine.UIElements.TextureId svgTexture
		/// </summary>
		protected RUnityEngine.RUIElements.RTextureId r_svgTexture;
		public virtual RUnityEngine.RUIElements.RTextureId RsvgTexture
		{
			get
			{
				if(r_svgTexture == null)
				{
					r_svgTexture = new(this, "svgTexture");
					r_svgTexture.SetBelong(this.instance);
				}
				return r_svgTexture;
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
		/// UnityEngine.UIElements.MeshGenerationContext+MeshFlags flags
		/// </summary>
		protected RField r_flags;
		public virtual RField Rflags
		{
			get
			{
				if(r_flags == null)
				{
					r_flags = new(this, "flags");
					r_flags.SetBelong(this.instance);
				}
				return r_flags;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc colorAlloc
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_colorAlloc;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RcolorAlloc
		{
			get
			{
				if(r_colorAlloc == null)
				{
					r_colorAlloc = new(this, "colorAlloc");
					r_colorAlloc.SetBelong(this.instance);
				}
				return r_colorAlloc;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshWriteData Allocate(UInt32, UInt32)
		/// </summary>
		protected RMethod r_RAllocate_UInt32_UInt32;
		public virtual RMethod RAllocate_UInt32_UInt32
		{
			get
			{
				if(r_RAllocate_UInt32_UInt32 == null)
				{
					r_RAllocate_UInt32_UInt32 = new(this, "Allocate", 0, typeof(System.UInt32), typeof(System.UInt32));
					r_RAllocate_UInt32_UInt32.SetBelong(this.instance);
				}
				return r_RAllocate_UInt32_UInt32;
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


        public RAllocMeshData() : base("UnityEngine.UIElements.UIR.MeshBuilder+AllocMeshData")
        {
        }

        public RAllocMeshData(System.Object instance) : base("UnityEngine.UIElements.UIR.MeshBuilder+AllocMeshData")
		{
            SetInstance(instance);
		}

        public RAllocMeshData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAllocMeshData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual UnityEngine.UIElements.MeshWriteData Allocate(System.UInt32  @vertexCount, System.UInt32  @indexCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @indexCount};
            var ___result = RAllocate_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.MeshWriteData)___result;
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