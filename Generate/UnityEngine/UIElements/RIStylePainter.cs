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
		protected RMethod r_RDrawMesh_Int32_Int32_Texture_Material_MeshFlags;
		public virtual RMethod RDrawMesh_Int32_Int32_Texture_Material_MeshFlags
		{
			get
			{
				if(r_RDrawMesh_Int32_Int32_Texture_Material_MeshFlags == null)
				{
					r_RDrawMesh_Int32_Int32_Texture_Material_MeshFlags = new(this, "DrawMesh", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Texture), typeof(UnityEngine.Material),  ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContext+MeshFlags"));
					r_RDrawMesh_Int32_Int32_Texture_Material_MeshFlags.SetBelong(this.instance);
				}
				return r_RDrawMesh_Int32_Int32_Texture_Material_MeshFlags;
			}
		}

		/// <summary>
		/// Void DrawText(UnityEngine.UIElements.TextElement)
		/// </summary>
		protected RMethod r_RDrawText_TextElement;
		public virtual RMethod RDrawText_TextElement
		{
			get
			{
				if(r_RDrawText_TextElement == null)
				{
					r_RDrawText_TextElement = new(this, "DrawText", 0, typeof(UnityEngine.UIElements.TextElement));
					r_RDrawText_TextElement.SetBelong(this.instance);
				}
				return r_RDrawText_TextElement;
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
		/// Void DrawRectangle(RectangleParams)
		/// </summary>
		protected RMethod r_RDrawRectangle_RectangleParams;
		public virtual RMethod RDrawRectangle_RectangleParams
		{
			get
			{
				if(r_RDrawRectangle_RectangleParams == null)
				{
					r_RDrawRectangle_RectangleParams = new(this, "DrawRectangle", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"));
					r_RDrawRectangle_RectangleParams.SetBelong(this.instance);
				}
				return r_RDrawRectangle_RectangleParams;
			}
		}

		/// <summary>
		/// Void DrawBorder(BorderParams)
		/// </summary>
		protected RMethod r_RDrawBorder_BorderParams;
		public virtual RMethod RDrawBorder_BorderParams
		{
			get
			{
				if(r_RDrawBorder_BorderParams == null)
				{
					r_RDrawBorder_BorderParams = new(this, "DrawBorder", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+BorderParams"));
					r_RDrawBorder_BorderParams.SetBelong(this.instance);
				}
				return r_RDrawBorder_BorderParams;
			}
		}

		/// <summary>
		/// Void DrawImmediate(System.Action, Boolean)
		/// </summary>
		protected RMethod r_RDrawImmediate_Action_Boolean;
		public virtual RMethod RDrawImmediate_Action_Boolean
		{
			get
			{
				if(r_RDrawImmediate_Action_Boolean == null)
				{
					r_RDrawImmediate_Action_Boolean = new(this, "DrawImmediate", 0, typeof(System.Action), typeof(System.Boolean));
					r_RDrawImmediate_Action_Boolean.SetBelong(this.instance);
				}
				return r_RDrawImmediate_Action_Boolean;
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


        public virtual void DrawText(UnityEngine.UIElements.TextElement  @te)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@te};
            var ___result = RDrawText_TextElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawText(System.String  @text, UnityEngine.Vector2  @pos, System.Single  @fontSize, UnityEngine.Color  @color, UnityEngine.TextCore.Text.FontAsset  @font)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @pos, @fontSize, @color, @font};
            var ___result = RDrawText_String_Vector2_Single_Color_FontAsset.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void DrawImmediate(System.Action  @callback, System.Boolean  @cullingEnabled)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @cullingEnabled};
            var ___result = RDrawImmediate_Action_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawVectorImage(UnityEngine.UIElements.VectorImage  @vectorImage, UnityEngine.Vector2  @pos, UnityEngine.UIElements.Angle  @rotationAngle, UnityEngine.Vector2  @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vectorImage, @pos, @rotationAngle, @scale};
            var ___result = RDrawVectorImage_VectorImage_Vector2_Angle_Vector2.Invoke(___genericsType, ___parameters);

            
        }


    }
}