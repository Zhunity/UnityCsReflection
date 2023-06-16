
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/UnityCsReflection
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
		/// UnityEngine.UIElements.Painter2D m_Painter2D
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPainter2D r_Fm_Painter2D;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPainter2D RFm_Painter2D
		{
			get
			{
				if(r_Fm_Painter2D == null)
				{
					r_Fm_Painter2D = new(this, "m_Painter2D");
				}
				return r_Fm_Painter2D;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_AllocateMarker
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fs_AllocateMarker;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFs_AllocateMarker
		{
			get
			{
				if(r_Fs_AllocateMarker == null)
				{
					r_Fs_AllocateMarker = new(Type, "s_AllocateMarker");
				}
				return r_Fs_AllocateMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_DrawVectorImageMarker
		/// </summary>
		protected static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker r_Fs_DrawVectorImageMarker;
		public static Hvak.Editor.Refleaction.RUnity.RProfiling.RProfilerMarker RFs_DrawVectorImageMarker
		{
			get
			{
				if(r_Fs_DrawVectorImageMarker == null)
				{
					r_Fs_DrawVectorImageMarker = new(Type, "s_DrawVectorImageMarker");
				}
				return r_Fs_DrawVectorImageMarker;
			}
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
		/// UnityEngine.UIElements.Painter2D painter2D
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPainter2D r_Ppainter2D;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RPainter2D RPpainter2D
		{
			get
			{
				if(r_Ppainter2D == null)
				{
					r_Ppainter2D = new(this, "painter2D", -1);
				}
				return r_Ppainter2D;
			}
		}

		/// <summary>
		/// Boolean hasPainter2D
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RBoolean r_PhasPainter2D;
		public virtual Hvak.Editor.Refleaction.RSystem.RBoolean RPhasPainter2D
		{
			get
			{
				if(r_PhasPainter2D == null)
				{
					r_PhasPainter2D = new(this, "hasPainter2D", -1);
				}
				return r_PhasPainter2D;
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
		/// Void DrawVectorImage(UnityEngine.UIElements.VectorImage, UnityEngine.Vector2, UnityEngine.UIElements.Angle, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_MDrawVectorImage_VectorImage_Vector2_Angle_Vector2;
		public virtual RMethod RMDrawVectorImage_VectorImage_Vector2_Angle_Vector2
		{
			get
			{
				if(r_MDrawVectorImage_VectorImage_Vector2_Angle_Vector2 == null)
				{
					r_MDrawVectorImage_VectorImage_Vector2_Angle_Vector2 = new(this, "DrawVectorImage", 0, typeof(UnityEngine.UIElements.VectorImage), typeof(UnityEngine.Vector2), typeof(UnityEngine.UIElements.Angle), typeof(UnityEngine.Vector2));
				}
				return r_MDrawVectorImage_VectorImage_Vector2_Angle_Vector2;
			}
		}

		/// <summary>
		/// Void DrawText(System.String, UnityEngine.Vector2, Single, UnityEngine.Color, UnityEngine.TextCore.Text.FontAsset)
		/// </summary>
		protected RMethod r_MDrawText_String_Vector2_Single_Color_FontAsset;
		public virtual RMethod RMDrawText_String_Vector2_Single_Color_FontAsset
		{
			get
			{
				if(r_MDrawText_String_Vector2_Single_Color_FontAsset == null)
				{
					r_MDrawText_String_Vector2_Single_Color_FontAsset = new(this, "DrawText", 0, typeof(System.String), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Color), typeof(UnityEngine.TextCore.Text.FontAsset));
				}
				return r_MDrawText_String_Vector2_Single_Color_FontAsset;
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


        public virtual void DrawVectorImage(UnityEngine.UIElements.VectorImage @vectorImage, UnityEngine.Vector2 @offset, UnityEngine.UIElements.Angle @rotationAngle, UnityEngine.Vector2 @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vectorImage, @offset, @rotationAngle, @scale};
            var ___result = RMDrawVectorImage_VectorImage_Vector2_Angle_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawText(System.String @text, UnityEngine.Vector2 @pos, System.Single @fontSize, UnityEngine.Color @color, UnityEngine.TextCore.Text.FontAsset @font)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @pos, @fontSize, @color, @font};
            var ___result = RMDrawText_String_Vector2_Single_Color_FontAsset.Invoke(___genericsType, ___parameters);

            
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
