using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.RenderChainVEData
	/// </summary>
    public partial class RRenderChainVEData : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.VisualElement prev
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_prev;
		public virtual RUnityEngine.RUIElements.RVisualElement Rprev
		{
			get
			{
				if(r_prev == null)
				{
					r_prev = new(this, "prev");
					r_prev.SetBelong(this.instance);
				}
				return r_prev;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement next
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_next;
		public virtual RUnityEngine.RUIElements.RVisualElement Rnext
		{
			get
			{
				if(r_next == null)
				{
					r_next = new(this, "next");
					r_next.SetBelong(this.instance);
				}
				return r_next;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement groupTransformAncestor
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_groupTransformAncestor;
		public virtual RUnityEngine.RUIElements.RVisualElement RgroupTransformAncestor
		{
			get
			{
				if(r_groupTransformAncestor == null)
				{
					r_groupTransformAncestor = new(this, "groupTransformAncestor");
					r_groupTransformAncestor.SetBelong(this.instance);
				}
				return r_groupTransformAncestor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement boneTransformAncestor
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_boneTransformAncestor;
		public virtual RUnityEngine.RUIElements.RVisualElement RboneTransformAncestor
		{
			get
			{
				if(r_boneTransformAncestor == null)
				{
					r_boneTransformAncestor = new(this, "boneTransformAncestor");
					r_boneTransformAncestor.SetBelong(this.instance);
				}
				return r_boneTransformAncestor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement prevDirty
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_prevDirty;
		public virtual RUnityEngine.RUIElements.RVisualElement RprevDirty
		{
			get
			{
				if(r_prevDirty == null)
				{
					r_prevDirty = new(this, "prevDirty");
					r_prevDirty.SetBelong(this.instance);
				}
				return r_prevDirty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement nextDirty
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_nextDirty;
		public virtual RUnityEngine.RUIElements.RVisualElement RnextDirty
		{
			get
			{
				if(r_nextDirty == null)
				{
					r_nextDirty = new(this, "nextDirty");
					r_nextDirty.SetBelong(this.instance);
				}
				return r_nextDirty;
			}
		}

		/// <summary>
		/// System.Int32 hierarchyDepth
		/// </summary>
		protected RField r_hierarchyDepth;
		public virtual RField RhierarchyDepth
		{
			get
			{
				if(r_hierarchyDepth == null)
				{
					r_hierarchyDepth = new(this, "hierarchyDepth");
					r_hierarchyDepth.SetBelong(this.instance);
				}
				return r_hierarchyDepth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderDataDirtyTypes dirtiedValues
		/// </summary>
		protected RField r_dirtiedValues;
		public virtual RField RdirtiedValues
		{
			get
			{
				if(r_dirtiedValues == null)
				{
					r_dirtiedValues = new(this, "dirtiedValues");
					r_dirtiedValues.SetBelong(this.instance);
				}
				return r_dirtiedValues;
			}
		}

		/// <summary>
		/// System.UInt32 dirtyID
		/// </summary>
		protected RField r_dirtyID;
		public virtual RField RdirtyID
		{
			get
			{
				if(r_dirtyID == null)
				{
					r_dirtyID = new(this, "dirtyID");
					r_dirtyID.SetBelong(this.instance);
				}
				return r_dirtyID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand firstCommand
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_firstCommand;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainCommand RfirstCommand
		{
			get
			{
				if(r_firstCommand == null)
				{
					r_firstCommand = new(this, "firstCommand");
					r_firstCommand.SetBelong(this.instance);
				}
				return r_firstCommand;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand lastCommand
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_lastCommand;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainCommand RlastCommand
		{
			get
			{
				if(r_lastCommand == null)
				{
					r_lastCommand = new(this, "lastCommand");
					r_lastCommand.SetBelong(this.instance);
				}
				return r_lastCommand;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand firstClosingCommand
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_firstClosingCommand;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainCommand RfirstClosingCommand
		{
			get
			{
				if(r_firstClosingCommand == null)
				{
					r_firstClosingCommand = new(this, "firstClosingCommand");
					r_firstClosingCommand.SetBelong(this.instance);
				}
				return r_firstClosingCommand;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand lastClosingCommand
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_lastClosingCommand;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainCommand RlastClosingCommand
		{
			get
			{
				if(r_lastClosingCommand == null)
				{
					r_lastClosingCommand = new(this, "lastClosingCommand");
					r_lastClosingCommand.SetBelong(this.instance);
				}
				return r_lastClosingCommand;
			}
		}

		/// <summary>
		/// System.Boolean isInChain
		/// </summary>
		protected RField r_isInChain;
		public virtual RField RisInChain
		{
			get
			{
				if(r_isInChain == null)
				{
					r_isInChain = new(this, "isInChain");
					r_isInChain.SetBelong(this.instance);
				}
				return r_isInChain;
			}
		}

		/// <summary>
		/// System.Boolean isHierarchyHidden
		/// </summary>
		protected RField r_isHierarchyHidden;
		public virtual RField RisHierarchyHidden
		{
			get
			{
				if(r_isHierarchyHidden == null)
				{
					r_isHierarchyHidden = new(this, "isHierarchyHidden");
					r_isHierarchyHidden.SetBelong(this.instance);
				}
				return r_isHierarchyHidden;
			}
		}

		/// <summary>
		/// System.Boolean localFlipsWinding
		/// </summary>
		protected RField r_localFlipsWinding;
		public virtual RField RlocalFlipsWinding
		{
			get
			{
				if(r_localFlipsWinding == null)
				{
					r_localFlipsWinding = new(this, "localFlipsWinding");
					r_localFlipsWinding.SetBelong(this.instance);
				}
				return r_localFlipsWinding;
			}
		}

		/// <summary>
		/// System.Boolean localTransformScaleZero
		/// </summary>
		protected RField r_localTransformScaleZero;
		public virtual RField RlocalTransformScaleZero
		{
			get
			{
				if(r_localTransformScaleZero == null)
				{
					r_localTransformScaleZero = new(this, "localTransformScaleZero");
					r_localTransformScaleZero.SetBelong(this.instance);
				}
				return r_localTransformScaleZero;
			}
		}

		/// <summary>
		/// System.Boolean worldFlipsWinding
		/// </summary>
		protected RField r_worldFlipsWinding;
		public virtual RField RworldFlipsWinding
		{
			get
			{
				if(r_worldFlipsWinding == null)
				{
					r_worldFlipsWinding = new(this, "worldFlipsWinding");
					r_worldFlipsWinding.SetBelong(this.instance);
				}
				return r_worldFlipsWinding;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Implementation.ClipMethod clipMethod
		/// </summary>
		protected RField r_clipMethod;
		public virtual RField RclipMethod
		{
			get
			{
				if(r_clipMethod == null)
				{
					r_clipMethod = new(this, "clipMethod");
					r_clipMethod.SetBelong(this.instance);
				}
				return r_clipMethod;
			}
		}

		/// <summary>
		/// System.Int32 childrenStencilRef
		/// </summary>
		protected RField r_childrenStencilRef;
		public virtual RField RchildrenStencilRef
		{
			get
			{
				if(r_childrenStencilRef == null)
				{
					r_childrenStencilRef = new(this, "childrenStencilRef");
					r_childrenStencilRef.SetBelong(this.instance);
				}
				return r_childrenStencilRef;
			}
		}

		/// <summary>
		/// System.Int32 childrenMaskDepth
		/// </summary>
		protected RField r_childrenMaskDepth;
		public virtual RField RchildrenMaskDepth
		{
			get
			{
				if(r_childrenMaskDepth == null)
				{
					r_childrenMaskDepth = new(this, "childrenMaskDepth");
					r_childrenMaskDepth.SetBelong(this.instance);
				}
				return r_childrenMaskDepth;
			}
		}

		/// <summary>
		/// System.Boolean disableNudging
		/// </summary>
		protected RField r_disableNudging;
		public virtual RField RdisableNudging
		{
			get
			{
				if(r_disableNudging == null)
				{
					r_disableNudging = new(this, "disableNudging");
					r_disableNudging.SetBelong(this.instance);
				}
				return r_disableNudging;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.MeshHandle data
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RMeshHandle r_data;
		public virtual RUnityEngine.RUIElements.RUIR.RMeshHandle Rdata
		{
			get
			{
				if(r_data == null)
				{
					r_data = new(this, "data");
					r_data.SetBelong(this.instance);
				}
				return r_data;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.MeshHandle closingData
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RMeshHandle r_closingData;
		public virtual RUnityEngine.RUIElements.RUIR.RMeshHandle RclosingData
		{
			get
			{
				if(r_closingData == null)
				{
					r_closingData = new(this, "closingData");
					r_closingData.SetBelong(this.instance);
				}
				return r_closingData;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 verticesSpace
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_verticesSpace;
		public virtual RUnityEngine.RMatrix4x4 RverticesSpace
		{
			get
			{
				if(r_verticesSpace == null)
				{
					r_verticesSpace = new(this, "verticesSpace");
					r_verticesSpace.SetBelong(this.instance);
				}
				return r_verticesSpace;
			}
		}

		/// <summary>
		/// System.Int32 displacementUVStart
		/// </summary>
		protected RField r_displacementUVStart;
		public virtual RField RdisplacementUVStart
		{
			get
			{
				if(r_displacementUVStart == null)
				{
					r_displacementUVStart = new(this, "displacementUVStart");
					r_displacementUVStart.SetBelong(this.instance);
				}
				return r_displacementUVStart;
			}
		}

		/// <summary>
		/// System.Int32 displacementUVEnd
		/// </summary>
		protected RField r_displacementUVEnd;
		public virtual RField RdisplacementUVEnd
		{
			get
			{
				if(r_displacementUVEnd == null)
				{
					r_displacementUVEnd = new(this, "displacementUVEnd");
					r_displacementUVEnd.SetBelong(this.instance);
				}
				return r_displacementUVEnd;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc transformID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_transformID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RtransformID
		{
			get
			{
				if(r_transformID == null)
				{
					r_transformID = new(this, "transformID");
					r_transformID.SetBelong(this.instance);
				}
				return r_transformID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc clipRectID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_clipRectID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RclipRectID
		{
			get
			{
				if(r_clipRectID == null)
				{
					r_clipRectID = new(this, "clipRectID");
					r_clipRectID.SetBelong(this.instance);
				}
				return r_clipRectID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc opacityID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_opacityID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RopacityID
		{
			get
			{
				if(r_opacityID == null)
				{
					r_opacityID = new(this, "opacityID");
					r_opacityID.SetBelong(this.instance);
				}
				return r_opacityID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc textCoreSettingsID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_textCoreSettingsID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RtextCoreSettingsID
		{
			get
			{
				if(r_textCoreSettingsID == null)
				{
					r_textCoreSettingsID = new(this, "textCoreSettingsID");
					r_textCoreSettingsID.SetBelong(this.instance);
				}
				return r_textCoreSettingsID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc colorID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_colorID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RcolorID
		{
			get
			{
				if(r_colorID == null)
				{
					r_colorID = new(this, "colorID");
					r_colorID.SetBelong(this.instance);
				}
				return r_colorID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc backgroundColorID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_backgroundColorID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RbackgroundColorID
		{
			get
			{
				if(r_backgroundColorID == null)
				{
					r_backgroundColorID = new(this, "backgroundColorID");
					r_backgroundColorID.SetBelong(this.instance);
				}
				return r_backgroundColorID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc borderLeftColorID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_borderLeftColorID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RborderLeftColorID
		{
			get
			{
				if(r_borderLeftColorID == null)
				{
					r_borderLeftColorID = new(this, "borderLeftColorID");
					r_borderLeftColorID.SetBelong(this.instance);
				}
				return r_borderLeftColorID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc borderTopColorID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_borderTopColorID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RborderTopColorID
		{
			get
			{
				if(r_borderTopColorID == null)
				{
					r_borderTopColorID = new(this, "borderTopColorID");
					r_borderTopColorID.SetBelong(this.instance);
				}
				return r_borderTopColorID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc borderRightColorID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_borderRightColorID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RborderRightColorID
		{
			get
			{
				if(r_borderRightColorID == null)
				{
					r_borderRightColorID = new(this, "borderRightColorID");
					r_borderRightColorID.SetBelong(this.instance);
				}
				return r_borderRightColorID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc borderBottomColorID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_borderBottomColorID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RborderBottomColorID
		{
			get
			{
				if(r_borderBottomColorID == null)
				{
					r_borderBottomColorID = new(this, "borderBottomColorID");
					r_borderBottomColorID.SetBelong(this.instance);
				}
				return r_borderBottomColorID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc tintColorID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_tintColorID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RtintColorID
		{
			get
			{
				if(r_tintColorID == null)
				{
					r_tintColorID = new(this, "tintColorID");
					r_tintColorID.SetBelong(this.instance);
				}
				return r_tintColorID;
			}
		}

		/// <summary>
		/// System.Single compositeOpacity
		/// </summary>
		protected RField r_compositeOpacity;
		public virtual RField RcompositeOpacity
		{
			get
			{
				if(r_compositeOpacity == null)
				{
					r_compositeOpacity = new(this, "compositeOpacity");
					r_compositeOpacity.SetBelong(this.instance);
				}
				return r_compositeOpacity;
			}
		}

		/// <summary>
		/// UnityEngine.Color backgroundColor
		/// </summary>
		protected RUnityEngine.RColor r_backgroundColor;
		public virtual RUnityEngine.RColor RbackgroundColor
		{
			get
			{
				if(r_backgroundColor == null)
				{
					r_backgroundColor = new(this, "backgroundColor");
					r_backgroundColor.SetBelong(this.instance);
				}
				return r_backgroundColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BasicNode`1[UnityEngine.UIElements.UIR.TextureEntry] textures
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBasicNode<RUnityEngine.RUIElements.RUIR.RTextureEntry> r_textures;
		public virtual RUnityEngine.RUIElements.RUIR.RBasicNode<RUnityEngine.RUIElements.RUIR.RTextureEntry> Rtextures
		{
			get
			{
				if(r_textures == null)
				{
					r_textures = new(this, "textures");
					r_textures.SetBelong(this.instance);
				}
				return r_textures;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand lastClosingOrLastCommand
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_lastClosingOrLastCommand;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainCommand RlastClosingOrLastCommand
		{
			get
			{
				if(r_lastClosingOrLastCommand == null)
				{
					r_lastClosingOrLastCommand = new(this, "lastClosingOrLastCommand", -1);
					r_lastClosingOrLastCommand.SetBelong(this.instance);
				}
				return r_lastClosingOrLastCommand;
			}
		}

		/// <summary>
		/// Boolean AllocatesID(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected static RMethod r_AllocatesID_BMPAlloc;
		public static RMethod RAllocatesID_BMPAlloc
		{
			get
			{
				if(r_AllocatesID_BMPAlloc == null)
				{
					r_AllocatesID_BMPAlloc = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainVEData"), "AllocatesID", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_AllocatesID_BMPAlloc.SetBelong(null);
				}
				return r_AllocatesID_BMPAlloc;
			}
		}

		/// <summary>
		/// Boolean InheritsID(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected static RMethod r_InheritsID_BMPAlloc;
		public static RMethod RInheritsID_BMPAlloc
		{
			get
			{
				if(r_InheritsID_BMPAlloc == null)
				{
					r_InheritsID_BMPAlloc = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainVEData"), "InheritsID", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_InheritsID_BMPAlloc.SetBelong(null);
				}
				return r_InheritsID_BMPAlloc;
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


        public RRenderChainVEData() : base("UnityEngine.UIElements.UIR.RenderChainVEData")
        {
        }

        public RRenderChainVEData(System.Object instance) : base("UnityEngine.UIElements.UIR.RenderChainVEData")
		{
            SetInstance(instance);
		}

        public RRenderChainVEData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRenderChainVEData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean AllocatesID(RUnityEngine.RUIElements.RUIR.RBMPAlloc  @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RAllocatesID_BMPAlloc.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean InheritsID(RUnityEngine.RUIElements.RUIR.RBMPAlloc  @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RInheritsID_BMPAlloc.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
