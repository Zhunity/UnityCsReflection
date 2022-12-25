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
		protected RMethod r_RTryGetAtlas_VisualElement_Texture2D_Out_TextureId_Out_RectInt;
		public virtual RMethod RTryGetAtlas_VisualElement_Texture2D_Out_TextureId_Out_RectInt
		{
			get
			{
				if(r_RTryGetAtlas_VisualElement_Texture2D_Out_TextureId_Out_RectInt == null)
				{
					r_RTryGetAtlas_VisualElement_Texture2D_Out_TextureId_Out_RectInt = new(this, "TryGetAtlas", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Texture2D),  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId").MakeByRefType(), typeof(UnityEngine.RectInt).MakeByRefType());
					r_RTryGetAtlas_VisualElement_Texture2D_Out_TextureId_Out_RectInt.SetBelong(this.instance);
				}
				return r_RTryGetAtlas_VisualElement_Texture2D_Out_TextureId_Out_RectInt;
			}
		}

		/// <summary>
		/// Void ReturnAtlas(UnityEngine.UIElements.VisualElement, UnityEngine.Texture2D, UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_RReturnAtlas_VisualElement_Texture2D_TextureId;
		public virtual RMethod RReturnAtlas_VisualElement_Texture2D_TextureId
		{
			get
			{
				if(r_RReturnAtlas_VisualElement_Texture2D_TextureId == null)
				{
					r_RReturnAtlas_VisualElement_Texture2D_TextureId = new(this, "ReturnAtlas", 0, typeof(UnityEngine.UIElements.VisualElement), typeof(UnityEngine.Texture2D),  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_RReturnAtlas_VisualElement_Texture2D_TextureId.SetBelong(this.instance);
				}
				return r_RReturnAtlas_VisualElement_Texture2D_TextureId;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
			}
		}

		/// <summary>
		/// Void OnAssignedToPanel(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_ROnAssignedToPanel_IPanel;
		public virtual RMethod ROnAssignedToPanel_IPanel
		{
			get
			{
				if(r_ROnAssignedToPanel_IPanel == null)
				{
					r_ROnAssignedToPanel_IPanel = new(this, "OnAssignedToPanel", 0, typeof(UnityEngine.UIElements.IPanel));
					r_ROnAssignedToPanel_IPanel.SetBelong(this.instance);
				}
				return r_ROnAssignedToPanel_IPanel;
			}
		}

		/// <summary>
		/// Void OnRemovedFromPanel(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_ROnRemovedFromPanel_IPanel;
		public virtual RMethod ROnRemovedFromPanel_IPanel
		{
			get
			{
				if(r_ROnRemovedFromPanel_IPanel == null)
				{
					r_ROnRemovedFromPanel_IPanel = new(this, "OnRemovedFromPanel", 0, typeof(UnityEngine.UIElements.IPanel));
					r_ROnRemovedFromPanel_IPanel.SetBelong(this.instance);
				}
				return r_ROnRemovedFromPanel_IPanel;
			}
		}

		/// <summary>
		/// Void OnUpdateDynamicTextures(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_ROnUpdateDynamicTextures_IPanel;
		public virtual RMethod ROnUpdateDynamicTextures_IPanel
		{
			get
			{
				if(r_ROnUpdateDynamicTextures_IPanel == null)
				{
					r_ROnUpdateDynamicTextures_IPanel = new(this, "OnUpdateDynamicTextures", 0, typeof(UnityEngine.UIElements.IPanel));
					r_ROnUpdateDynamicTextures_IPanel.SetBelong(this.instance);
				}
				return r_ROnUpdateDynamicTextures_IPanel;
			}
		}

		/// <summary>
		/// Void InvokeAssignedToPanel(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_RInvokeAssignedToPanel_IPanel;
		public virtual RMethod RInvokeAssignedToPanel_IPanel
		{
			get
			{
				if(r_RInvokeAssignedToPanel_IPanel == null)
				{
					r_RInvokeAssignedToPanel_IPanel = new(this, "InvokeAssignedToPanel", 0, typeof(UnityEngine.UIElements.IPanel));
					r_RInvokeAssignedToPanel_IPanel.SetBelong(this.instance);
				}
				return r_RInvokeAssignedToPanel_IPanel;
			}
		}

		/// <summary>
		/// Void InvokeRemovedFromPanel(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_RInvokeRemovedFromPanel_IPanel;
		public virtual RMethod RInvokeRemovedFromPanel_IPanel
		{
			get
			{
				if(r_RInvokeRemovedFromPanel_IPanel == null)
				{
					r_RInvokeRemovedFromPanel_IPanel = new(this, "InvokeRemovedFromPanel", 0, typeof(UnityEngine.UIElements.IPanel));
					r_RInvokeRemovedFromPanel_IPanel.SetBelong(this.instance);
				}
				return r_RInvokeRemovedFromPanel_IPanel;
			}
		}

		/// <summary>
		/// Void InvokeUpdateDynamicTextures(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected RMethod r_RInvokeUpdateDynamicTextures_IPanel;
		public virtual RMethod RInvokeUpdateDynamicTextures_IPanel
		{
			get
			{
				if(r_RInvokeUpdateDynamicTextures_IPanel == null)
				{
					r_RInvokeUpdateDynamicTextures_IPanel = new(this, "InvokeUpdateDynamicTextures", 0, typeof(UnityEngine.UIElements.IPanel));
					r_RInvokeUpdateDynamicTextures_IPanel.SetBelong(this.instance);
				}
				return r_RInvokeUpdateDynamicTextures_IPanel;
			}
		}

		/// <summary>
		/// Void RepaintTexturedElements(UnityEngine.UIElements.IPanel)
		/// </summary>
		protected static RMethod r_RRepaintTexturedElements_IPanel;
		public static RMethod RRepaintTexturedElements_IPanel
		{
			get
			{
				if(r_RRepaintTexturedElements_IPanel == null)
				{
					r_RRepaintTexturedElements_IPanel = new( ReleactionUtils.GetType("UnityEngine.UIElements.AtlasBase"), "RepaintTexturedElements", 0, typeof(UnityEngine.UIElements.IPanel));
					r_RRepaintTexturedElements_IPanel.SetBelong(null);
				}
				return r_RRepaintTexturedElements_IPanel;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.TextureId AllocateDynamicTexture()
		/// </summary>
		protected RMethod r_RAllocateDynamicTexture;
		public virtual RMethod RAllocateDynamicTexture
		{
			get
			{
				if(r_RAllocateDynamicTexture == null)
				{
					r_RAllocateDynamicTexture = new(this, "AllocateDynamicTexture", 0);
					r_RAllocateDynamicTexture.SetBelong(this.instance);
				}
				return r_RAllocateDynamicTexture;
			}
		}

		/// <summary>
		/// Void FreeDynamicTexture(UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_RFreeDynamicTexture_TextureId;
		public virtual RMethod RFreeDynamicTexture_TextureId
		{
			get
			{
				if(r_RFreeDynamicTexture_TextureId == null)
				{
					r_RFreeDynamicTexture_TextureId = new(this, "FreeDynamicTexture", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_RFreeDynamicTexture_TextureId.SetBelong(this.instance);
				}
				return r_RFreeDynamicTexture_TextureId;
			}
		}

		/// <summary>
		/// Void SetDynamicTexture(UnityEngine.UIElements.TextureId, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_RSetDynamicTexture_TextureId_Texture;
		public virtual RMethod RSetDynamicTexture_TextureId_Texture
		{
			get
			{
				if(r_RSetDynamicTexture_TextureId_Texture == null)
				{
					r_RSetDynamicTexture_TextureId_Texture = new(this, "SetDynamicTexture", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"), typeof(UnityEngine.Texture));
					r_RSetDynamicTexture_TextureId_Texture.SetBelong(this.instance);
				}
				return r_RSetDynamicTexture_TextureId_Texture;
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
