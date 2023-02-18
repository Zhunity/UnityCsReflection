
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.IStylePainter
	/// </summary>
    public partial class RIStylePainter : RMember //
    {

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
		/// UnityEngine.UIElements.MeshWriteData DrawMesh(Int32, Int32, UnityEngine.Texture, UnityEngine.Material, MeshFlags)
		/// </summary>
		protected RMethod r_MDrawMesh_Int32_Int32_Texture_Material_MeshFlags;
		public virtual RMethod RMDrawMesh_Int32_Int32_Texture_Material_MeshFlags
		{
			get
			{
				if(r_MDrawMesh_Int32_Int32_Texture_Material_MeshFlags == null)
				{
					r_MDrawMesh_Int32_Int32_Texture_Material_MeshFlags = new(this, "DrawMesh", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Texture), typeof(UnityEngine.Material),  ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContext+MeshFlags"));
				}
				return r_MDrawMesh_Int32_Int32_Texture_Material_MeshFlags;
			}
		}

		/// <summary>
		/// Void DrawText(UnityEngine.UIElements.TextElement)
		/// </summary>
		protected RMethod r_MDrawText_TextElement;
		public virtual RMethod RMDrawText_TextElement
		{
			get
			{
				if(r_MDrawText_TextElement == null)
				{
					r_MDrawText_TextElement = new(this, "DrawText", 0, typeof(UnityEngine.UIElements.TextElement));
				}
				return r_MDrawText_TextElement;
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
		/// Void DrawRectangle(RectangleParams)
		/// </summary>
		protected RMethod r_MDrawRectangle_RectangleParams;
		public virtual RMethod RMDrawRectangle_RectangleParams
		{
			get
			{
				if(r_MDrawRectangle_RectangleParams == null)
				{
					r_MDrawRectangle_RectangleParams = new(this, "DrawRectangle", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"));
				}
				return r_MDrawRectangle_RectangleParams;
			}
		}

		/// <summary>
		/// Void DrawBorder(BorderParams)
		/// </summary>
		protected RMethod r_MDrawBorder_BorderParams;
		public virtual RMethod RMDrawBorder_BorderParams
		{
			get
			{
				if(r_MDrawBorder_BorderParams == null)
				{
					r_MDrawBorder_BorderParams = new(this, "DrawBorder", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+BorderParams"));
				}
				return r_MDrawBorder_BorderParams;
			}
		}

		/// <summary>
		/// Void DrawImmediate(System.Action, Boolean)
		/// </summary>
		protected RMethod r_MDrawImmediate_Action_Boolean;
		public virtual RMethod RMDrawImmediate_Action_Boolean
		{
			get
			{
				if(r_MDrawImmediate_Action_Boolean == null)
				{
					r_MDrawImmediate_Action_Boolean = new(this, "DrawImmediate", 0, typeof(System.Action), typeof(System.Boolean));
				}
				return r_MDrawImmediate_Action_Boolean;
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

        public virtual UnityEngine.UIElements.MeshWriteData DrawMesh(System.Int32 @vertexCount, System.Int32 @indexCount, UnityEngine.Texture @texture, UnityEngine.Material @material, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext.RMeshFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @indexCount, @texture, @material, @flags.Value};
            var ___result = RMDrawMesh_Int32_Int32_Texture_Material_MeshFlags.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.MeshWriteData)___result;
        }


        public virtual void DrawText(UnityEngine.UIElements.TextElement @te)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@te};
            var ___result = RMDrawText_TextElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawText(System.String @text, UnityEngine.Vector2 @pos, System.Single @fontSize, UnityEngine.Color @color, UnityEngine.TextCore.Text.FontAsset @font)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @pos, @fontSize, @color, @font};
            var ___result = RMDrawText_String_Vector2_Single_Color_FontAsset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawRectangle(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContextUtils.RRectangleParams @rectParams)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rectParams.Value};
            var ___result = RMDrawRectangle_RectangleParams.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawBorder(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContextUtils.RBorderParams @borderParams)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@borderParams.Value};
            var ___result = RMDrawBorder_BorderParams.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawImmediate(System.Action @callback, System.Boolean @cullingEnabled)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @cullingEnabled};
            var ___result = RMDrawImmediate_Action_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawVectorImage(UnityEngine.UIElements.VectorImage @vectorImage, UnityEngine.Vector2 @pos, UnityEngine.UIElements.Angle @rotationAngle, UnityEngine.Vector2 @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vectorImage, @pos, @rotationAngle, @scale};
            var ___result = RMDrawVectorImage_VectorImage_Vector2_Angle_Vector2.Invoke(___genericsType, ___parameters);

            
        }


    }
}
