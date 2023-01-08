using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IStylePainter
	/// </summary>
    public partial class RIStylePainter : RMember //
    {

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
		/// UnityEngine.UIElements.MeshWriteData DrawMesh(Int32, Int32, UnityEngine.Texture, UnityEngine.Material, MeshFlags)
		/// </summary>
		protected RMethod r_DrawMesh_Int32_Int32_Texture_Material_MeshFlags;
		public virtual RMethod RDrawMesh_Int32_Int32_Texture_Material_MeshFlags
		{
			get
			{
				if(r_DrawMesh_Int32_Int32_Texture_Material_MeshFlags == null)
				{
					r_DrawMesh_Int32_Int32_Texture_Material_MeshFlags = new(this, "DrawMesh", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Texture), typeof(UnityEngine.Material),  ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContext+MeshFlags"));
					r_DrawMesh_Int32_Int32_Texture_Material_MeshFlags.SetBelong(this.instance);
				}
				return r_DrawMesh_Int32_Int32_Texture_Material_MeshFlags;
			}
		}

		/// <summary>
		/// Void DrawText(UnityEngine.UIElements.TextElement)
		/// </summary>
		protected RMethod r_DrawText_TextElement;
		public virtual RMethod RDrawText_TextElement
		{
			get
			{
				if(r_DrawText_TextElement == null)
				{
					r_DrawText_TextElement = new(this, "DrawText", 0, typeof(UnityEngine.UIElements.TextElement));
					r_DrawText_TextElement.SetBelong(this.instance);
				}
				return r_DrawText_TextElement;
			}
		}

		/// <summary>
		/// Void DrawText(System.String, UnityEngine.Vector2, Single, UnityEngine.Color, UnityEngine.TextCore.Text.FontAsset)
		/// </summary>
		protected RMethod r_DrawText_String_Vector2_Single_Color_FontAsset;
		public virtual RMethod RDrawText_String_Vector2_Single_Color_FontAsset
		{
			get
			{
				if(r_DrawText_String_Vector2_Single_Color_FontAsset == null)
				{
					r_DrawText_String_Vector2_Single_Color_FontAsset = new(this, "DrawText", 0, typeof(System.String), typeof(UnityEngine.Vector2), typeof(System.Single), typeof(UnityEngine.Color), typeof(UnityEngine.TextCore.Text.FontAsset));
					r_DrawText_String_Vector2_Single_Color_FontAsset.SetBelong(this.instance);
				}
				return r_DrawText_String_Vector2_Single_Color_FontAsset;
			}
		}

		/// <summary>
		/// Void DrawRectangle(RectangleParams)
		/// </summary>
		protected RMethod r_DrawRectangle_RectangleParams;
		public virtual RMethod RDrawRectangle_RectangleParams
		{
			get
			{
				if(r_DrawRectangle_RectangleParams == null)
				{
					r_DrawRectangle_RectangleParams = new(this, "DrawRectangle", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"));
					r_DrawRectangle_RectangleParams.SetBelong(this.instance);
				}
				return r_DrawRectangle_RectangleParams;
			}
		}

		/// <summary>
		/// Void DrawBorder(BorderParams)
		/// </summary>
		protected RMethod r_DrawBorder_BorderParams;
		public virtual RMethod RDrawBorder_BorderParams
		{
			get
			{
				if(r_DrawBorder_BorderParams == null)
				{
					r_DrawBorder_BorderParams = new(this, "DrawBorder", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+BorderParams"));
					r_DrawBorder_BorderParams.SetBelong(this.instance);
				}
				return r_DrawBorder_BorderParams;
			}
		}

		/// <summary>
		/// Void DrawImmediate(System.Action, Boolean)
		/// </summary>
		protected RMethod r_DrawImmediate_Action_Boolean;
		public virtual RMethod RDrawImmediate_Action_Boolean
		{
			get
			{
				if(r_DrawImmediate_Action_Boolean == null)
				{
					r_DrawImmediate_Action_Boolean = new(this, "DrawImmediate", 0, typeof(System.Action), typeof(System.Boolean));
					r_DrawImmediate_Action_Boolean.SetBelong(this.instance);
				}
				return r_DrawImmediate_Action_Boolean;
			}
		}

		/// <summary>
		/// Void DrawVectorImage(UnityEngine.UIElements.VectorImage, UnityEngine.Vector2, UnityEngine.UIElements.Angle, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_DrawVectorImage_VectorImage_Vector2_Angle_Vector2;
		public virtual RMethod RDrawVectorImage_VectorImage_Vector2_Angle_Vector2
		{
			get
			{
				if(r_DrawVectorImage_VectorImage_Vector2_Angle_Vector2 == null)
				{
					r_DrawVectorImage_VectorImage_Vector2_Angle_Vector2 = new(this, "DrawVectorImage", 0, typeof(UnityEngine.UIElements.VectorImage), typeof(UnityEngine.Vector2), typeof(UnityEngine.UIElements.Angle), typeof(UnityEngine.Vector2));
					r_DrawVectorImage_VectorImage_Vector2_Angle_Vector2.SetBelong(this.instance);
				}
				return r_DrawVectorImage_VectorImage_Vector2_Angle_Vector2;
			}
		}


        public RIStylePainter() : base("UnityEngine.UIElements.IStylePainter")
        {
        }

        public RIStylePainter(System.Object instance) : base("UnityEngine.UIElements.IStylePainter")
		{
            SetInstance(instance);
		}

        public RIStylePainter(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIStylePainter(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual UnityEngine.UIElements.MeshWriteData DrawMesh(System.Int32 @vertexCount, System.Int32 @indexCount, UnityEngine.Texture @texture, UnityEngine.Material @material, RType @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @indexCount, @texture, @material, @flags.Value};
            var ___result = RDrawMesh_Int32_Int32_Texture_Material_MeshFlags.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.MeshWriteData)___result;
        }


        public virtual void DrawText(UnityEngine.UIElements.TextElement @te)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@te};
            var ___result = RDrawText_TextElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawText(System.String @text, UnityEngine.Vector2 @pos, System.Single @fontSize, UnityEngine.Color @color, UnityEngine.TextCore.Text.FontAsset @font)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @pos, @fontSize, @color, @font};
            var ___result = RDrawText_String_Vector2_Single_Color_FontAsset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawRectangle(RUnityEngine.RUIElements.RMeshGenerationContextUtils.RRectangleParams @rectParams)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rectParams.Value};
            var ___result = RDrawRectangle_RectangleParams.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawBorder(RUnityEngine.RUIElements.RMeshGenerationContextUtils.RBorderParams @borderParams)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@borderParams.Value};
            var ___result = RDrawBorder_BorderParams.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawImmediate(System.Action @callback, System.Boolean @cullingEnabled)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @cullingEnabled};
            var ___result = RDrawImmediate_Action_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawVectorImage(UnityEngine.UIElements.VectorImage @vectorImage, UnityEngine.Vector2 @pos, UnityEngine.UIElements.Angle @rotationAngle, UnityEngine.Vector2 @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vectorImage, @pos, @rotationAngle, @scale};
            var ___result = RDrawVectorImage_VectorImage_Vector2_Angle_Vector2.Invoke(___genericsType, ___parameters);

            
        }


    }
}
