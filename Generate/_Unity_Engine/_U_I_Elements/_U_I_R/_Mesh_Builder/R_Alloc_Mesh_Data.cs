
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
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RMeshBuilder.RAllocMeshData.RAllocator r_Falloc;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RMeshBuilder.RAllocMeshData.RAllocator RFalloc
		{
			get
			{
				if(r_Falloc == null)
				{
					r_Falloc = new(this, "alloc");
					r_Falloc.SetBelong(this.instance);
				}
				return r_Falloc;
			}
		}

		/// <summary>
		/// UnityEngine.Texture texture
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RTexture r_Ftexture;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RTexture RFtexture
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
		/// UnityEngine.UIElements.TextureId svgTexture
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId r_FsvgTexture;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId RFsvgTexture
		{
			get
			{
				if(r_FsvgTexture == null)
				{
					r_FsvgTexture = new(this, "svgTexture");
					r_FsvgTexture.SetBelong(this.instance);
				}
				return r_FsvgTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Material material
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RMaterial r_Fmaterial;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RMaterial RFmaterial
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
		/// UnityEngine.UIElements.MeshGenerationContext+MeshFlags flags
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext.RMeshFlags r_Fflags;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext.RMeshFlags RFflags
		{
			get
			{
				if(r_Fflags == null)
				{
					r_Fflags = new(this, "flags");
					r_Fflags.SetBelong(this.instance);
				}
				return r_Fflags;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc colorAlloc
		/// </summary>
		protected SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc r_FcolorAlloc;
		public virtual SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc RFcolorAlloc
		{
			get
			{
				if(r_FcolorAlloc == null)
				{
					r_FcolorAlloc = new(this, "colorAlloc");
					r_FcolorAlloc.SetBelong(this.instance);
				}
				return r_FcolorAlloc;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshWriteData Allocate(UInt32, UInt32)
		/// </summary>
		protected RMethod r_MAllocate_UInt32_UInt32;
		public virtual RMethod RMAllocate_UInt32_UInt32
		{
			get
			{
				if(r_MAllocate_UInt32_UInt32 == null)
				{
					r_MAllocate_UInt32_UInt32 = new(this, "Allocate", 0, typeof(System.UInt32), typeof(System.UInt32));
					r_MAllocate_UInt32_UInt32.SetBelong(this.instance);
				}
				return r_MAllocate_UInt32_UInt32;
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

        public virtual UnityEngine.UIElements.MeshWriteData Allocate(System.UInt32 @vertexCount, System.UInt32 @indexCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @indexCount};
            var ___result = RMAllocate_UInt32_UInt32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.MeshWriteData)___result;
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