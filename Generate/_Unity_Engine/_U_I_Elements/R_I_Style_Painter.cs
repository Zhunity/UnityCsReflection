
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.IStylePainter
	/// </summary>
    public partial class RIStylePainter : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.IStylePainter");
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
		/// Void DrawText(TextParams, UnityEngine.UIElements.ITextHandle, Single)
		/// </summary>
		protected RMethod r_MDrawText_TextParams_ITextHandle_Single;
		public virtual RMethod RMDrawText_TextParams_ITextHandle_Single
		{
			get
			{
				if(r_MDrawText_TextParams_ITextHandle_Single == null)
				{
					r_MDrawText_TextParams_ITextHandle_Single = new(this, "DrawText", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+TextParams"),  ReflectionUtils.GetType("UnityEngine.UIElements.ITextHandle"), typeof(System.Single));
				}
				return r_MDrawText_TextParams_ITextHandle_Single;
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


        public virtual UnityEngine.UIElements.MeshWriteData DrawMesh(System.Int32 @vertexCount, System.Int32 @indexCount, UnityEngine.Texture @texture, UnityEngine.Material @material, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext.RMeshFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @indexCount, @texture, @material, @flags.Value};
            var ___result = RMDrawMesh_Int32_Int32_Texture_Material_MeshFlags.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<UnityEngine.UIElements.MeshWriteData>(___result);
        }


        public virtual void DrawText(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContextUtils.RTextParams @textParams, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RITextHandle @handle, System.Single @pixelsPerPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textParams.Value, @handle.Value, @pixelsPerPoint};
            var ___result = RMDrawText_TextParams_ITextHandle_Single.Invoke(___genericsType, ___parameters);

            
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


    }
}
