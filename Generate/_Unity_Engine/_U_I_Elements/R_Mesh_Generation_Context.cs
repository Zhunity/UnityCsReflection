
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.MeshGenerationContext
	/// </summary>
    public partial class RMeshGenerationContext : RMember //
    {
        public static Type Type
        {
            get
            {
                return typeof(UnityEngine.UIElements.MeshGenerationContext);
            }
        }

        public RMeshGenerationContext() : base("UnityEngine.UIElements.MeshGenerationContext")
        {
        }

        public RMeshGenerationContext(System.Object instance) : base("UnityEngine.UIElements.MeshGenerationContext")
		{
            SetInstance(instance);
		}

        public RMeshGenerationContext(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMeshGenerationContext(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.UIElements.IStylePainter painter
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIStylePainter r_Fpainter;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RIStylePainter RFpainter
		{
			get
			{
				if(r_Fpainter == null)
				{
					r_Fpainter = new(this, "painter");
				}
				return r_Fpainter;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement visualElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PvisualElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPvisualElement
		{
			get
			{
				if(r_PvisualElement == null)
				{
					r_PvisualElement = new(this, "visualElement", -1);
				}
				return r_PvisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshWriteData Allocate(Int32, Int32, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_MAllocate_Int32_Int32_Texture;
		public virtual RMethod RMAllocate_Int32_Int32_Texture
		{
			get
			{
				if(r_MAllocate_Int32_Int32_Texture == null)
				{
					r_MAllocate_Int32_Int32_Texture = new(this, "Allocate", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Texture));
				}
				return r_MAllocate_Int32_Int32_Texture;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshWriteData Allocate(Int32, Int32, UnityEngine.Texture, UnityEngine.Material, MeshFlags)
		/// </summary>
		protected RMethod r_MAllocate_Int32_Int32_Texture_Material_MeshFlags;
		public virtual RMethod RMAllocate_Int32_Int32_Texture_Material_MeshFlags
		{
			get
			{
				if(r_MAllocate_Int32_Int32_Texture_Material_MeshFlags == null)
				{
					r_MAllocate_Int32_Int32_Texture_Material_MeshFlags = new(this, "Allocate", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Texture), typeof(UnityEngine.Material),  ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContext+MeshFlags"));
				}
				return r_MAllocate_Int32_Int32_Texture_Material_MeshFlags;
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


        public virtual UnityEngine.UIElements.MeshWriteData Allocate(System.Int32 @vertexCount, System.Int32 @indexCount, UnityEngine.Texture @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @indexCount, @texture};
            var ___result = RMAllocate_Int32_Int32_Texture.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.MeshWriteData>(___result);
        }


        public virtual UnityEngine.UIElements.MeshWriteData Allocate(System.Int32 @vertexCount, System.Int32 @indexCount, UnityEngine.Texture @texture, UnityEngine.Material @material, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext.RMeshFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @indexCount, @texture, @material, @flags.Value};
            var ___result = RMAllocate_Int32_Int32_Texture_Material_MeshFlags.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.MeshWriteData>(___result);
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.Int32>(___result);
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<System.String>(___result);
        }


    }
}
