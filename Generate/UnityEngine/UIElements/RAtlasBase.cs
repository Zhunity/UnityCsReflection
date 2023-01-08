using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements
{
	/// <summary>
	/// UnityEngine.UIElements.AtlasBase
	/// </summary>
    public partial class RAtlasBase : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.TextureRegistry textureRegistry
		/// </summary>
		protected RUnityEngine.RUIElements.RTextureRegistry r_textureRegistry;
		public virtual RUnityEngine.RUIElements.RTextureRegistry RtextureRegistry
		{
			get
			{
				if(r_textureRegistry == null)
				{
					r_textureRegistry = new(this, "textureRegistry");
					r_textureRegistry.SetBelong(this.instance);
				}
				return r_textureRegistry;
			}
		}

		/// <summary>
		/// Boolean TryGetAtlas(UnityEngine.UIElements.VisualElement, UnityEngine.Texture2D, UnityEngine.UIElements.TextureId ByRef, UnityEngine.RectInt ByRef)
		/// </summary>
		protected RMethod r_TryGetAtlas_VisualElement_Texture2D_Out_TextureId_Out_RectInt;
		public virtual RMethod RTryGetAtlas_VisualElement_Texture2D_Out_TextureId_Out_RectInt
		{
			get
			{
				if(r_TryGetAtlas_VisualElement_Texture2D_Out_TextureId_Out_RectInt == null)
				{
					r_TryGetAtlas_VisualElement_Texture2D_Out_TextureId_Out_RectInt = new(this, "TryGetAtlas", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Texture2D),  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId").MakeByRefType(), typeof(UnityEngine.RectInt).MakeByRefType());
					r_TryGetAtlas_VisualElement_Texture2D_Out_TextureId_Out_RectInt.SetBelong(this.instance);
				}
				return r_TryGetAtlas_VisualElement_Texture2D_Out_TextureId_Out_RectInt;
			}
		}

		/// <summary>
		/// Void ReturnAtlas(UnityEngine.UIElements.VisualElement, UnityEngine.Texture2D, UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_ReturnAtlas_VisualElement_Texture2D_TextureId;
		public virtual RMethod RReturnAtlas_VisualElement_Texture2D_TextureId
		{
			get
			{
				if(r_ReturnAtlas_VisualElement_Texture2D_TextureId == null)
				{
					r_ReturnAtlas_VisualElement_Texture2D_TextureId = new(this, "ReturnAtlas", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Texture2D),  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_ReturnAtlas_VisualElement_Texture2D_TextureId.SetBelong(this.instance);
				}
				return r_ReturnAtlas_VisualElement_Texture2D_TextureId;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_Reset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_Reset == null)
				{
					r_Reset = new(this, "Reset", 0);
					r_Reset.SetBelong(this.instance);
				}
				return r_Reset;
			}
		}

		/// <summary>
		/// Void OnAssignedToPanel(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_OnAssignedToPanel_IPanel;
		public virtual RMethod ROnAssignedToPanel_IPanel
		{
			get
			{
				if(r_OnAssignedToPanel_IPanel == null)
				{
					r_OnAssignedToPanel_IPanel = new(this, "OnAssignedToPanel", 0, typeof(UnityEngine.UIElements.IPanel));
					r_OnAssignedToPanel_IPanel.SetBelong(this.instance);
				}
				return r_OnAssignedToPanel_IPanel;
			}
		}

		/// <summary>
		/// Void OnRemovedFromPanel(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_OnRemovedFromPanel_IPanel;
		public virtual RMethod ROnRemovedFromPanel_IPanel
		{
			get
			{
				if(r_OnRemovedFromPanel_IPanel == null)
				{
					r_OnRemovedFromPanel_IPanel = new(this, "OnRemovedFromPanel", 0, typeof(UnityEngine.UIElements.IPanel));
					r_OnRemovedFromPanel_IPanel.SetBelong(this.instance);
				}
				return r_OnRemovedFromPanel_IPanel;
			}
		}

		/// <summary>
		/// Void OnUpdateDynamicTextures(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_OnUpdateDynamicTextures_IPanel;
		public virtual RMethod ROnUpdateDynamicTextures_IPanel
		{
			get
			{
				if(r_OnUpdateDynamicTextures_IPanel == null)
				{
					r_OnUpdateDynamicTextures_IPanel = new(this, "OnUpdateDynamicTextures", 0, typeof(UnityEngine.UIElements.IPanel));
					r_OnUpdateDynamicTextures_IPanel.SetBelong(this.instance);
				}
				return r_OnUpdateDynamicTextures_IPanel;
			}
		}

		/// <summary>
		/// Void InvokeAssignedToPanel(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_InvokeAssignedToPanel_IPanel;
		public virtual RMethod RInvokeAssignedToPanel_IPanel
		{
			get
			{
				if(r_InvokeAssignedToPanel_IPanel == null)
				{
					r_InvokeAssignedToPanel_IPanel = new(this, "InvokeAssignedToPanel", 0, typeof(UnityEngine.UIElements.IPanel));
					r_InvokeAssignedToPanel_IPanel.SetBelong(this.instance);
				}
				return r_InvokeAssignedToPanel_IPanel;
			}
		}

		/// <summary>
		/// Void InvokeRemovedFromPanel(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_InvokeRemovedFromPanel_IPanel;
		public virtual RMethod RInvokeRemovedFromPanel_IPanel
		{
			get
			{
				if(r_InvokeRemovedFromPanel_IPanel == null)
				{
					r_InvokeRemovedFromPanel_IPanel = new(this, "InvokeRemovedFromPanel", 0, typeof(UnityEngine.UIElements.IPanel));
					r_InvokeRemovedFromPanel_IPanel.SetBelong(this.instance);
				}
				return r_InvokeRemovedFromPanel_IPanel;
			}
		}

		/// <summary>
		/// Void InvokeUpdateDynamicTextures(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_InvokeUpdateDynamicTextures_IPanel;
		public virtual RMethod RInvokeUpdateDynamicTextures_IPanel
		{
			get
			{
				if(r_InvokeUpdateDynamicTextures_IPanel == null)
				{
					r_InvokeUpdateDynamicTextures_IPanel = new(this, "InvokeUpdateDynamicTextures", 0, typeof(UnityEngine.UIElements.IPanel));
					r_InvokeUpdateDynamicTextures_IPanel.SetBelong(this.instance);
				}
				return r_InvokeUpdateDynamicTextures_IPanel;
			}
		}

		/// <summary>
		/// Void RepaintTexturedElements(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected static RMethod r_RepaintTexturedElements_IPanel;
		public static RMethod RRepaintTexturedElements_IPanel
		{
			get
			{
				if(r_RepaintTexturedElements_IPanel == null)
				{
					r_RepaintTexturedElements_IPanel = new( ReflectionUtils.GetType("UnityEngine.UIElements.AtlasBase"), "RepaintTexturedElements", 0, typeof(UnityEngine.UIElements.IPanel));
					r_RepaintTexturedElements_IPanel.SetBelong(null);
				}
				return r_RepaintTexturedElements_IPanel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId AllocateDynamicTexture()
		/// </summary>
		protected RMethod r_AllocateDynamicTexture;
		public virtual RMethod RAllocateDynamicTexture
		{
			get
			{
				if(r_AllocateDynamicTexture == null)
				{
					r_AllocateDynamicTexture = new(this, "AllocateDynamicTexture", 0);
					r_AllocateDynamicTexture.SetBelong(this.instance);
				}
				return r_AllocateDynamicTexture;
			}
		}

		/// <summary>
		/// Void FreeDynamicTexture(UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_FreeDynamicTexture_TextureId;
		public virtual RMethod RFreeDynamicTexture_TextureId
		{
			get
			{
				if(r_FreeDynamicTexture_TextureId == null)
				{
					r_FreeDynamicTexture_TextureId = new(this, "FreeDynamicTexture", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_FreeDynamicTexture_TextureId.SetBelong(this.instance);
				}
				return r_FreeDynamicTexture_TextureId;
			}
		}

		/// <summary>
		/// Void SetDynamicTexture(UnityEngine.UIElements.TextureId, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_SetDynamicTexture_TextureId_Texture;
		public virtual RMethod RSetDynamicTexture_TextureId_Texture
		{
			get
			{
				if(r_SetDynamicTexture_TextureId_Texture == null)
				{
					r_SetDynamicTexture_TextureId_Texture = new(this, "SetDynamicTexture", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"), typeof(UnityEngine.Texture));
					r_SetDynamicTexture_TextureId_Texture.SetBelong(this.instance);
				}
				return r_SetDynamicTexture_TextureId_Texture;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_Equals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_Equals_Object == null)
				{
					r_Equals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_Equals_Object.SetBelong(this.instance);
				}
				return r_Equals_Object;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_Finalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_Finalize == null)
				{
					r_Finalize = new(this, "Finalize", 0);
					r_Finalize.SetBelong(this.instance);
				}
				return r_Finalize;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_GetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_GetHashCode == null)
				{
					r_GetHashCode = new(this, "GetHashCode", 0);
					r_GetHashCode.SetBelong(this.instance);
				}
				return r_GetHashCode;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_GetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_GetType == null)
				{
					r_GetType = new(this, "GetType", 0);
					r_GetType.SetBelong(this.instance);
				}
				return r_GetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_MemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_MemberwiseClone == null)
				{
					r_MemberwiseClone = new(this, "MemberwiseClone", 0);
					r_MemberwiseClone.SetBelong(this.instance);
				}
				return r_MemberwiseClone;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_ToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_ToString == null)
				{
					r_ToString = new(this, "ToString", 0);
					r_ToString.SetBelong(this.instance);
				}
				return r_ToString;
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

        public virtual System.Boolean TryGetAtlas(UnityEngine.UIElements.VisualElement  @ctx, UnityEngine.Texture2D  @src, out RUnityEngine.RUIElements.RTextureId  @atlas, out UnityEngine.RectInt  @atlasRect)
        {
			atlas = default;
			atlasRect = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx, @src, @atlas.Value, @atlasRect};
            var ___result = RTryGetAtlas_VisualElement_Texture2D_Out_TextureId_Out_RectInt.Invoke(___genericsType, ___parameters);
			atlasRect = (UnityEngine.RectInt)___parameters[3];

            return (System.Boolean)___result;
        }


        public virtual void ReturnAtlas(UnityEngine.UIElements.VisualElement  @ctx, UnityEngine.Texture2D  @src, RUnityEngine.RUIElements.RTextureId  @atlas)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ctx, @src, @atlas.Value};
            var ___result = RReturnAtlas_VisualElement_Texture2D_TextureId.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAssignedToPanel(UnityEngine.UIElements.IPanel  @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = ROnAssignedToPanel_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnRemovedFromPanel(UnityEngine.UIElements.IPanel  @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = ROnRemovedFromPanel_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUpdateDynamicTextures(UnityEngine.UIElements.IPanel  @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = ROnUpdateDynamicTextures_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeAssignedToPanel(UnityEngine.UIElements.IPanel  @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RInvokeAssignedToPanel_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeRemovedFromPanel(UnityEngine.UIElements.IPanel  @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RInvokeRemovedFromPanel_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeUpdateDynamicTextures(UnityEngine.UIElements.IPanel  @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RInvokeUpdateDynamicTextures_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public static void RepaintTexturedElements(UnityEngine.UIElements.IPanel  @panel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@panel};
            var ___result = RRepaintTexturedElements_IPanel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object AllocateDynamicTexture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAllocateDynamicTexture.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void FreeDynamicTexture(RUnityEngine.RUIElements.RTextureId  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value};
            var ___result = RFreeDynamicTexture_TextureId.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDynamicTexture(RUnityEngine.RUIElements.RTextureId  @id, UnityEngine.Texture  @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id.Value, @texture};
            var ___result = RSetDynamicTexture_TextureId_Texture.Invoke(___genericsType, ___parameters);

            
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
