
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.AtlasBase
	/// </summary>
    public partial class RAtlasBase : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.AtlasBase");
            }
        }

        public RAtlasBase() : base("UnityEngine.UIElements.AtlasBase")
        {
        }

        public RAtlasBase(System.Object instance) : base("UnityEngine.UIElements.AtlasBase")
		{
            SetInstance(instance);
		}

        public RAtlasBase(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAtlasBase(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.UIElements.TextureRegistry textureRegistry
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureRegistry r_FtextureRegistry;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureRegistry RFtextureRegistry
		{
			get
			{
				if(r_FtextureRegistry == null)
				{
					r_FtextureRegistry = new(this, "textureRegistry");
				}
				return r_FtextureRegistry;
			}
		}

		/// <summary>
		/// Boolean TryGetAtlas(UnityEngine.UIElements.VisualElement, UnityEngine.Texture2D, UnityEngine.UIElements.TextureId ByRef, UnityEngine.RectInt ByRef)
		/// </summary>
		protected RMethod r_MTryGetAtlas_VisualElement_Texture2D_Out_TextureId_Out_RectInt;
		public virtual RMethod RMTryGetAtlas_VisualElement_Texture2D_Out_TextureId_Out_RectInt
		{
			get
			{
				if(r_MTryGetAtlas_VisualElement_Texture2D_Out_TextureId_Out_RectInt == null)
				{
					r_MTryGetAtlas_VisualElement_Texture2D_Out_TextureId_Out_RectInt = new(this, "TryGetAtlas", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Texture2D),  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId").MakeByRefType(), typeof(UnityEngine.RectInt).MakeByRefType());
				}
				return r_MTryGetAtlas_VisualElement_Texture2D_Out_TextureId_Out_RectInt;
			}
		}

		/// <summary>
		/// Void ReturnAtlas(UnityEngine.UIElements.VisualElement, UnityEngine.Texture2D, UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_MReturnAtlas_VisualElement_Texture2D_TextureId;
		public virtual RMethod RMReturnAtlas_VisualElement_Texture2D_TextureId
		{
			get
			{
				if(r_MReturnAtlas_VisualElement_Texture2D_TextureId == null)
				{
					r_MReturnAtlas_VisualElement_Texture2D_TextureId = new(this, "ReturnAtlas", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Texture2D),  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"));
				}
				return r_MReturnAtlas_VisualElement_Texture2D_TextureId;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_MReset;
		public virtual RMethod RMReset
		{
			get
			{
				if(r_MReset == null)
				{
					r_MReset = new(this, "Reset", 0);
				}
				return r_MReset;
			}
		}

		/// <summary>
		/// Void OnAssignedToPanel(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_MOnAssignedToPanel_IPanel;
		public virtual RMethod RMOnAssignedToPanel_IPanel
		{
			get
			{
				if(r_MOnAssignedToPanel_IPanel == null)
				{
					r_MOnAssignedToPanel_IPanel = new(this, "OnAssignedToPanel", 0, typeof(UnityEngine.UIElements.IPanel));
				}
				return r_MOnAssignedToPanel_IPanel;
			}
		}

		/// <summary>
		/// Void OnRemovedFromPanel(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_MOnRemovedFromPanel_IPanel;
		public virtual RMethod RMOnRemovedFromPanel_IPanel
		{
			get
			{
				if(r_MOnRemovedFromPanel_IPanel == null)
				{
					r_MOnRemovedFromPanel_IPanel = new(this, "OnRemovedFromPanel", 0, typeof(UnityEngine.UIElements.IPanel));
				}
				return r_MOnRemovedFromPanel_IPanel;
			}
		}

		/// <summary>
		/// Void OnUpdateDynamicTextures(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_MOnUpdateDynamicTextures_IPanel;
		public virtual RMethod RMOnUpdateDynamicTextures_IPanel
		{
			get
			{
				if(r_MOnUpdateDynamicTextures_IPanel == null)
				{
					r_MOnUpdateDynamicTextures_IPanel = new(this, "OnUpdateDynamicTextures", 0, typeof(UnityEngine.UIElements.IPanel));
				}
				return r_MOnUpdateDynamicTextures_IPanel;
			}
		}

		/// <summary>
		/// Void InvokeAssignedToPanel(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_MInvokeAssignedToPanel_IPanel;
		public virtual RMethod RMInvokeAssignedToPanel_IPanel
		{
			get
			{
				if(r_MInvokeAssignedToPanel_IPanel == null)
				{
					r_MInvokeAssignedToPanel_IPanel = new(this, "InvokeAssignedToPanel", 0, typeof(UnityEngine.UIElements.IPanel));
				}
				return r_MInvokeAssignedToPanel_IPanel;
			}
		}

		/// <summary>
		/// Void InvokeRemovedFromPanel(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_MInvokeRemovedFromPanel_IPanel;
		public virtual RMethod RMInvokeRemovedFromPanel_IPanel
		{
			get
			{
				if(r_MInvokeRemovedFromPanel_IPanel == null)
				{
					r_MInvokeRemovedFromPanel_IPanel = new(this, "InvokeRemovedFromPanel", 0, typeof(UnityEngine.UIElements.IPanel));
				}
				return r_MInvokeRemovedFromPanel_IPanel;
			}
		}

		/// <summary>
		/// Void InvokeUpdateDynamicTextures(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_MInvokeUpdateDynamicTextures_IPanel;
		public virtual RMethod RMInvokeUpdateDynamicTextures_IPanel
		{
			get
			{
				if(r_MInvokeUpdateDynamicTextures_IPanel == null)
				{
					r_MInvokeUpdateDynamicTextures_IPanel = new(this, "InvokeUpdateDynamicTextures", 0, typeof(UnityEngine.UIElements.IPanel));
				}
				return r_MInvokeUpdateDynamicTextures_IPanel;
			}
		}

		/// <summary>
		/// Void RepaintTexturedElements(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected static RMethod r_MRepaintTexturedElements_IPanel;
		public static RMethod RMRepaintTexturedElements_IPanel
		{
			get
			{
				if(r_MRepaintTexturedElements_IPanel == null)
				{
					r_MRepaintTexturedElements_IPanel = new(Type, "RepaintTexturedElements", 0, typeof(UnityEngine.UIElements.IPanel));
				}
				return r_MRepaintTexturedElements_IPanel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId AllocateDynamicTexture()
		/// </summary>
		protected RMethod r_MAllocateDynamicTexture;
		public virtual RMethod RMAllocateDynamicTexture
		{
			get
			{
				if(r_MAllocateDynamicTexture == null)
				{
					r_MAllocateDynamicTexture = new(this, "AllocateDynamicTexture", 0);
				}
				return r_MAllocateDynamicTexture;
			}
		}

		/// <summary>
		/// Void FreeDynamicTexture(UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_MFreeDynamicTexture_TextureId;
		public virtual RMethod RMFreeDynamicTexture_TextureId
		{
			get
			{
				if(r_MFreeDynamicTexture_TextureId == null)
				{
					r_MFreeDynamicTexture_TextureId = new(this, "FreeDynamicTexture", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"));
				}
				return r_MFreeDynamicTexture_TextureId;
			}
		}

		/// <summary>
		/// Void SetDynamicTexture(UnityEngine.UIElements.TextureId, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_MSetDynamicTexture_TextureId_Texture;
		public virtual RMethod RMSetDynamicTexture_TextureId_Texture
		{
			get
			{
				if(r_MSetDynamicTexture_TextureId_Texture == null)
				{
					r_MSetDynamicTexture_TextureId_Texture = new(this, "SetDynamicTexture", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"), typeof(UnityEngine.Texture));
				}
				return r_MSetDynamicTexture_TextureId_Texture;
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


        public virtual System.Boolean TryGetAtlas(UnityEngine.UIElements.VisualElement @ctx, UnityEngine.Texture2D @src, out Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @atlas, out UnityEngine.RectInt @atlasRect)
        {
			@atlas = default;
			@atlasRect = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx, @src, @atlas.Value, @atlasRect};
            var ___result = RMTryGetAtlas_VisualElement_Texture2D_Out_TextureId_Out_RectInt.Invoke(___genericsType, ___parameters);
			@atlas = ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId>(___parameters[2]);
			@atlasRect = ReflectionUtils.Convert<UnityEngine.RectInt>(___parameters[3]);

            return ReflectionUtils.Convert<System.Boolean>(___result);
        }


        public virtual void ReturnAtlas(UnityEngine.UIElements.VisualElement @ctx, UnityEngine.Texture2D @src, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @atlas)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx, @src, @atlas.Value};
            var ___result = RMReturnAtlas_VisualElement_Texture2D_TextureId.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAssignedToPanel(UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RMOnAssignedToPanel_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnRemovedFromPanel(UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RMOnRemovedFromPanel_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUpdateDynamicTextures(UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RMOnUpdateDynamicTextures_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeAssignedToPanel(UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RMInvokeAssignedToPanel_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeRemovedFromPanel(UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RMInvokeRemovedFromPanel_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeUpdateDynamicTextures(UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RMInvokeUpdateDynamicTextures_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public static void RepaintTexturedElements(UnityEngine.UIElements.IPanel @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RMRepaintTexturedElements_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId AllocateDynamicTexture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMAllocateDynamicTexture.Invoke(___genericsType, ___parameters);

            return ReflectionUtils.Convert<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId>(___result);
        }


        public virtual void FreeDynamicTexture(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RMFreeDynamicTexture_TextureId.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDynamicTexture(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @id, UnityEngine.Texture @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @texture};
            var ___result = RMSetDynamicTexture_TextureId_Texture.Invoke(___genericsType, ___parameters);

            
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
