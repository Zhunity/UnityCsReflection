using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.MeshGenerationContext
	/// </summary>
    public partial class RMeshGenerationContext : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.Painter2D m_Painter2D
		/// </summary>
		protected RUnityEngine.RUIElements.RPainter2D r_m_Painter2D;
		public virtual RUnityEngine.RUIElements.RPainter2D Rm_Painter2D
		{
			get
			{
				if(r_m_Painter2D == null)
				{
					r_m_Painter2D = new(this, "m_Painter2D");
					r_m_Painter2D.SetBelong(this.instance);
				}
				return r_m_Painter2D;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_AllocateMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_AllocateMarker;
		public static RUnity.RProfiling.RProfilerMarker Rs_AllocateMarker
		{
			get
			{
				if(r_s_AllocateMarker == null)
				{
					r_s_AllocateMarker = new(typeof(UnityEngine.UIElements.MeshGenerationContext), "s_AllocateMarker");
					r_s_AllocateMarker.SetBelong(null);
				}
				return r_s_AllocateMarker;
			}
		}

		/// <summary>
		/// Unity.Profiling.ProfilerMarker s_DrawVectorImageMarker
		/// </summary>
		protected static RUnity.RProfiling.RProfilerMarker r_s_DrawVectorImageMarker;
		public static RUnity.RProfiling.RProfilerMarker Rs_DrawVectorImageMarker
		{
			get
			{
				if(r_s_DrawVectorImageMarker == null)
				{
					r_s_DrawVectorImageMarker = new(typeof(UnityEngine.UIElements.MeshGenerationContext), "s_DrawVectorImageMarker");
					r_s_DrawVectorImageMarker.SetBelong(null);
				}
				return r_s_DrawVectorImageMarker;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.IStylePainter painter
		/// </summary>
		protected RUnityEngine.RUIElements.RIStylePainter r_painter;
		public virtual RUnityEngine.RUIElements.RIStylePainter Rpainter
		{
			get
			{
				if(r_painter == null)
				{
					r_painter = new(this, "painter");
					r_painter.SetBelong(this.instance);
				}
				return r_painter;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement visualElement
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_visualElement;
		public virtual RUnityEngine.RUIElements.RVisualElement RvisualElement
		{
			get
			{
				if(r_visualElement == null)
				{
					r_visualElement = new(this, "visualElement", -1);
					r_visualElement.SetBelong(this.instance);
				}
				return r_visualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.Painter2D painter2D
		/// </summary>
		protected RUnityEngine.RUIElements.RPainter2D r_painter2D;
		public virtual RUnityEngine.RUIElements.RPainter2D Rpainter2D
		{
			get
			{
				if(r_painter2D == null)
				{
					r_painter2D = new(this, "painter2D", -1);
					r_painter2D.SetBelong(this.instance);
				}
				return r_painter2D;
			}
		}

		/// <summary>
		/// Boolean hasPainter2D
		/// </summary>
		protected RProperty r_hasPainter2D;
		public virtual RProperty RhasPainter2D
		{
			get
			{
				if(r_hasPainter2D == null)
				{
					r_hasPainter2D = new(this, "hasPainter2D", -1);
					r_hasPainter2D.SetBelong(this.instance);
				}
				return r_hasPainter2D;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshWriteData Allocate(Int32, Int32, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_RAllocate_Int32_Int32_Texture;
		public virtual RMethod RAllocate_Int32_Int32_Texture
		{
			get
			{
				if(r_RAllocate_Int32_Int32_Texture == null)
				{
					r_RAllocate_Int32_Int32_Texture = new(this, "Allocate", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Texture));
					r_RAllocate_Int32_Int32_Texture.SetBelong(this.instance);
				}
				return r_RAllocate_Int32_Int32_Texture;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshWriteData Allocate(Int32, Int32, UnityEngine.Texture, UnityEngine.Material, MeshFlags)
		/// </summary>
		protected RMethod r_RAllocate_Int32_Int32_Texture_Material_MeshFlags;
		public virtual RMethod RAllocate_Int32_Int32_Texture_Material_MeshFlags
		{
			get
			{
				if(r_RAllocate_Int32_Int32_Texture_Material_MeshFlags == null)
				{
					r_RAllocate_Int32_Int32_Texture_Material_MeshFlags = new(this, "Allocate", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Texture), typeof(UnityEngine.Material),  ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContext+MeshFlags"));
					r_RAllocate_Int32_Int32_Texture_Material_MeshFlags.SetBelong(this.instance);
				}
				return r_RAllocate_Int32_Int32_Texture_Material_MeshFlags;
			}
		}

		/// <summary>
		/// Void DrawVectorImage(UnityEngine.UIElements.VectorImage, UnityEngine.Vector2, UnityEngine.UIElements.Angle, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RDrawVectorImage_VectorImage_Vector2_Angle_Vector2;
		public virtual RMethod RDrawVectorImage_VectorImage_Vector2_Angle_Vector2
		{
			get
			{
				if(r_RDrawVectorImage_VectorImage_Vector2_Angle_Vector2 == null)
				{
					r_RDrawVectorImage_VectorImage_Vector2_Angle_Vector2 = new(this, "DrawVectorImage", 0, typeof(UnityEngine.UIElements.VectorImage), typeof(UnityEngine.Vector2), typeof(UnityEngine.UIElements.Angle), typeof(UnityEngine.Vector2));
					r_RDrawVectorImage_VectorImage_Vector2_Angle_Vector2.SetBelong(this.instance);
				}
				return r_RDrawVectorImage_VectorImage_Vector2_Angle_Vector2;
			}
		}

		/// <summary>
		/// Void DrawText(System.String, UnityEngine.Vector2, Single, UnityEngine.Color, UnityEngine.TextCore.Text.FontAsset)
		/// </summary>
		protected RMethod r_RDrawText_String_Vector2_Single_Color_FontAsset;
		public virtual RMethod RDrawText_String_Vector2_Single_Color_FontAsset
		{
			get
			{
				if(r_RDrawText_String_Vector2_Single_Color_FontAsset == null)
				{
					r_RDrawText_String_Vector2_Single_Color_FontAsset = new(this, "DrawText", 0, typeof(System.String), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Color), typeof(UnityEngine.TextCore.Text.FontAsset));
					r_RDrawText_String_Vector2_Single_Color_FontAsset.SetBelong(this.instance);
				}
				return r_RDrawText_String_Vector2_Single_Color_FontAsset;
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

        public virtual UnityEngine.UIElements.MeshWriteData Allocate(System.Int32  @vertexCount, System.Int32  @indexCount, UnityEngine.Texture  @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @indexCount, @texture};
            var ___result = RAllocate_Int32_Int32_Texture.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.MeshWriteData)___result;
        }



        public virtual void DrawVectorImage(UnityEngine.UIElements.VectorImage  @vectorImage, UnityEngine.Vector2  @offset, UnityEngine.UIElements.Angle  @rotationAngle, UnityEngine.Vector2  @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vectorImage, @offset, @rotationAngle, @scale};
            var ___result = RDrawVectorImage_VectorImage_Vector2_Angle_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawText(System.String  @text, UnityEngine.Vector2  @pos, System.Single  @fontSize, UnityEngine.Color  @color, UnityEngine.TextCore.Text.FontAsset  @font)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @pos, @fontSize, @color, @font};
            var ___result = RDrawText_String_Vector2_Single_Color_FontAsset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
