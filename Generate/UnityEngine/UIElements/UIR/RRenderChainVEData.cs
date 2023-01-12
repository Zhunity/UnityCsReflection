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
		protected RUnityEngine.RUIElements.RVisualElement r_Fprev;
		public virtual RUnityEngine.RUIElements.RVisualElement RFprev
		{
			get
			{
				if(r_Fprev == null)
				{
					r_Fprev = new(this, "prev");
					r_Fprev.SetBelong(this.instance);
				}
				return r_Fprev;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement next
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_Fnext;
		public virtual RUnityEngine.RUIElements.RVisualElement RFnext
		{
			get
			{
				if(r_Fnext == null)
				{
					r_Fnext = new(this, "next");
					r_Fnext.SetBelong(this.instance);
				}
				return r_Fnext;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement groupTransformAncestor
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_FgroupTransformAncestor;
		public virtual RUnityEngine.RUIElements.RVisualElement RFgroupTransformAncestor
		{
			get
			{
				if(r_FgroupTransformAncestor == null)
				{
					r_FgroupTransformAncestor = new(this, "groupTransformAncestor");
					r_FgroupTransformAncestor.SetBelong(this.instance);
				}
				return r_FgroupTransformAncestor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement boneTransformAncestor
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_FboneTransformAncestor;
		public virtual RUnityEngine.RUIElements.RVisualElement RFboneTransformAncestor
		{
			get
			{
				if(r_FboneTransformAncestor == null)
				{
					r_FboneTransformAncestor = new(this, "boneTransformAncestor");
					r_FboneTransformAncestor.SetBelong(this.instance);
				}
				return r_FboneTransformAncestor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement prevDirty
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_FprevDirty;
		public virtual RUnityEngine.RUIElements.RVisualElement RFprevDirty
		{
			get
			{
				if(r_FprevDirty == null)
				{
					r_FprevDirty = new(this, "prevDirty");
					r_FprevDirty.SetBelong(this.instance);
				}
				return r_FprevDirty;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement nextDirty
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_FnextDirty;
		public virtual RUnityEngine.RUIElements.RVisualElement RFnextDirty
		{
			get
			{
				if(r_FnextDirty == null)
				{
					r_FnextDirty = new(this, "nextDirty");
					r_FnextDirty.SetBelong(this.instance);
				}
				return r_FnextDirty;
			}
		}

		/// <summary>
		/// System.Int32 hierarchyDepth
		/// </summary>
		protected RSystem.RInt32 r_FhierarchyDepth;
		public virtual RSystem.RInt32 RFhierarchyDepth
		{
			get
			{
				if(r_FhierarchyDepth == null)
				{
					r_FhierarchyDepth = new(this, "hierarchyDepth");
					r_FhierarchyDepth.SetBelong(this.instance);
				}
				return r_FhierarchyDepth;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderDataDirtyTypes dirtiedValues
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes r_FdirtiedValues;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderDataDirtyTypes RFdirtiedValues
		{
			get
			{
				if(r_FdirtiedValues == null)
				{
					r_FdirtiedValues = new(this, "dirtiedValues");
					r_FdirtiedValues.SetBelong(this.instance);
				}
				return r_FdirtiedValues;
			}
		}

		/// <summary>
		/// System.UInt32 dirtyID
		/// </summary>
		protected RSystem.RUInt32 r_FdirtyID;
		public virtual RSystem.RUInt32 RFdirtyID
		{
			get
			{
				if(r_FdirtyID == null)
				{
					r_FdirtyID = new(this, "dirtyID");
					r_FdirtyID.SetBelong(this.instance);
				}
				return r_FdirtyID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand firstCommand
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_FfirstCommand;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainCommand RFfirstCommand
		{
			get
			{
				if(r_FfirstCommand == null)
				{
					r_FfirstCommand = new(this, "firstCommand");
					r_FfirstCommand.SetBelong(this.instance);
				}
				return r_FfirstCommand;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand lastCommand
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_FlastCommand;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainCommand RFlastCommand
		{
			get
			{
				if(r_FlastCommand == null)
				{
					r_FlastCommand = new(this, "lastCommand");
					r_FlastCommand.SetBelong(this.instance);
				}
				return r_FlastCommand;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand firstClosingCommand
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_FfirstClosingCommand;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainCommand RFfirstClosingCommand
		{
			get
			{
				if(r_FfirstClosingCommand == null)
				{
					r_FfirstClosingCommand = new(this, "firstClosingCommand");
					r_FfirstClosingCommand.SetBelong(this.instance);
				}
				return r_FfirstClosingCommand;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand lastClosingCommand
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_FlastClosingCommand;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainCommand RFlastClosingCommand
		{
			get
			{
				if(r_FlastClosingCommand == null)
				{
					r_FlastClosingCommand = new(this, "lastClosingCommand");
					r_FlastClosingCommand.SetBelong(this.instance);
				}
				return r_FlastClosingCommand;
			}
		}

		/// <summary>
		/// System.Boolean isInChain
		/// </summary>
		protected RSystem.RBoolean r_FisInChain;
		public virtual RSystem.RBoolean RFisInChain
		{
			get
			{
				if(r_FisInChain == null)
				{
					r_FisInChain = new(this, "isInChain");
					r_FisInChain.SetBelong(this.instance);
				}
				return r_FisInChain;
			}
		}

		/// <summary>
		/// System.Boolean isHierarchyHidden
		/// </summary>
		protected RSystem.RBoolean r_FisHierarchyHidden;
		public virtual RSystem.RBoolean RFisHierarchyHidden
		{
			get
			{
				if(r_FisHierarchyHidden == null)
				{
					r_FisHierarchyHidden = new(this, "isHierarchyHidden");
					r_FisHierarchyHidden.SetBelong(this.instance);
				}
				return r_FisHierarchyHidden;
			}
		}

		/// <summary>
		/// System.Boolean localFlipsWinding
		/// </summary>
		protected RSystem.RBoolean r_FlocalFlipsWinding;
		public virtual RSystem.RBoolean RFlocalFlipsWinding
		{
			get
			{
				if(r_FlocalFlipsWinding == null)
				{
					r_FlocalFlipsWinding = new(this, "localFlipsWinding");
					r_FlocalFlipsWinding.SetBelong(this.instance);
				}
				return r_FlocalFlipsWinding;
			}
		}

		/// <summary>
		/// System.Boolean localTransformScaleZero
		/// </summary>
		protected RSystem.RBoolean r_FlocalTransformScaleZero;
		public virtual RSystem.RBoolean RFlocalTransformScaleZero
		{
			get
			{
				if(r_FlocalTransformScaleZero == null)
				{
					r_FlocalTransformScaleZero = new(this, "localTransformScaleZero");
					r_FlocalTransformScaleZero.SetBelong(this.instance);
				}
				return r_FlocalTransformScaleZero;
			}
		}

		/// <summary>
		/// System.Boolean worldFlipsWinding
		/// </summary>
		protected RSystem.RBoolean r_FworldFlipsWinding;
		public virtual RSystem.RBoolean RFworldFlipsWinding
		{
			get
			{
				if(r_FworldFlipsWinding == null)
				{
					r_FworldFlipsWinding = new(this, "worldFlipsWinding");
					r_FworldFlipsWinding.SetBelong(this.instance);
				}
				return r_FworldFlipsWinding;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Implementation.ClipMethod clipMethod
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RImplementation.RClipMethod r_FclipMethod;
		public virtual RUnityEngine.RUIElements.RUIR.RImplementation.RClipMethod RFclipMethod
		{
			get
			{
				if(r_FclipMethod == null)
				{
					r_FclipMethod = new(this, "clipMethod");
					r_FclipMethod.SetBelong(this.instance);
				}
				return r_FclipMethod;
			}
		}

		/// <summary>
		/// System.Int32 childrenStencilRef
		/// </summary>
		protected RSystem.RInt32 r_FchildrenStencilRef;
		public virtual RSystem.RInt32 RFchildrenStencilRef
		{
			get
			{
				if(r_FchildrenStencilRef == null)
				{
					r_FchildrenStencilRef = new(this, "childrenStencilRef");
					r_FchildrenStencilRef.SetBelong(this.instance);
				}
				return r_FchildrenStencilRef;
			}
		}

		/// <summary>
		/// System.Int32 childrenMaskDepth
		/// </summary>
		protected RSystem.RInt32 r_FchildrenMaskDepth;
		public virtual RSystem.RInt32 RFchildrenMaskDepth
		{
			get
			{
				if(r_FchildrenMaskDepth == null)
				{
					r_FchildrenMaskDepth = new(this, "childrenMaskDepth");
					r_FchildrenMaskDepth.SetBelong(this.instance);
				}
				return r_FchildrenMaskDepth;
			}
		}

		/// <summary>
		/// System.Boolean disableNudging
		/// </summary>
		protected RSystem.RBoolean r_FdisableNudging;
		public virtual RSystem.RBoolean RFdisableNudging
		{
			get
			{
				if(r_FdisableNudging == null)
				{
					r_FdisableNudging = new(this, "disableNudging");
					r_FdisableNudging.SetBelong(this.instance);
				}
				return r_FdisableNudging;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.MeshHandle data
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RMeshHandle r_Fdata;
		public virtual RUnityEngine.RUIElements.RUIR.RMeshHandle RFdata
		{
			get
			{
				if(r_Fdata == null)
				{
					r_Fdata = new(this, "data");
					r_Fdata.SetBelong(this.instance);
				}
				return r_Fdata;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.MeshHandle closingData
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RMeshHandle r_FclosingData;
		public virtual RUnityEngine.RUIElements.RUIR.RMeshHandle RFclosingData
		{
			get
			{
				if(r_FclosingData == null)
				{
					r_FclosingData = new(this, "closingData");
					r_FclosingData.SetBelong(this.instance);
				}
				return r_FclosingData;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 verticesSpace
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_FverticesSpace;
		public virtual RUnityEngine.RMatrix4x4 RFverticesSpace
		{
			get
			{
				if(r_FverticesSpace == null)
				{
					r_FverticesSpace = new(this, "verticesSpace");
					r_FverticesSpace.SetBelong(this.instance);
				}
				return r_FverticesSpace;
			}
		}

		/// <summary>
		/// System.Int32 displacementUVStart
		/// </summary>
		protected RSystem.RInt32 r_FdisplacementUVStart;
		public virtual RSystem.RInt32 RFdisplacementUVStart
		{
			get
			{
				if(r_FdisplacementUVStart == null)
				{
					r_FdisplacementUVStart = new(this, "displacementUVStart");
					r_FdisplacementUVStart.SetBelong(this.instance);
				}
				return r_FdisplacementUVStart;
			}
		}

		/// <summary>
		/// System.Int32 displacementUVEnd
		/// </summary>
		protected RSystem.RInt32 r_FdisplacementUVEnd;
		public virtual RSystem.RInt32 RFdisplacementUVEnd
		{
			get
			{
				if(r_FdisplacementUVEnd == null)
				{
					r_FdisplacementUVEnd = new(this, "displacementUVEnd");
					r_FdisplacementUVEnd.SetBelong(this.instance);
				}
				return r_FdisplacementUVEnd;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc transformID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_FtransformID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RFtransformID
		{
			get
			{
				if(r_FtransformID == null)
				{
					r_FtransformID = new(this, "transformID");
					r_FtransformID.SetBelong(this.instance);
				}
				return r_FtransformID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc clipRectID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_FclipRectID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RFclipRectID
		{
			get
			{
				if(r_FclipRectID == null)
				{
					r_FclipRectID = new(this, "clipRectID");
					r_FclipRectID.SetBelong(this.instance);
				}
				return r_FclipRectID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc opacityID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_FopacityID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RFopacityID
		{
			get
			{
				if(r_FopacityID == null)
				{
					r_FopacityID = new(this, "opacityID");
					r_FopacityID.SetBelong(this.instance);
				}
				return r_FopacityID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc textCoreSettingsID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_FtextCoreSettingsID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RFtextCoreSettingsID
		{
			get
			{
				if(r_FtextCoreSettingsID == null)
				{
					r_FtextCoreSettingsID = new(this, "textCoreSettingsID");
					r_FtextCoreSettingsID.SetBelong(this.instance);
				}
				return r_FtextCoreSettingsID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc colorID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_FcolorID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RFcolorID
		{
			get
			{
				if(r_FcolorID == null)
				{
					r_FcolorID = new(this, "colorID");
					r_FcolorID.SetBelong(this.instance);
				}
				return r_FcolorID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc backgroundColorID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_FbackgroundColorID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RFbackgroundColorID
		{
			get
			{
				if(r_FbackgroundColorID == null)
				{
					r_FbackgroundColorID = new(this, "backgroundColorID");
					r_FbackgroundColorID.SetBelong(this.instance);
				}
				return r_FbackgroundColorID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc borderLeftColorID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_FborderLeftColorID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RFborderLeftColorID
		{
			get
			{
				if(r_FborderLeftColorID == null)
				{
					r_FborderLeftColorID = new(this, "borderLeftColorID");
					r_FborderLeftColorID.SetBelong(this.instance);
				}
				return r_FborderLeftColorID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc borderTopColorID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_FborderTopColorID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RFborderTopColorID
		{
			get
			{
				if(r_FborderTopColorID == null)
				{
					r_FborderTopColorID = new(this, "borderTopColorID");
					r_FborderTopColorID.SetBelong(this.instance);
				}
				return r_FborderTopColorID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc borderRightColorID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_FborderRightColorID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RFborderRightColorID
		{
			get
			{
				if(r_FborderRightColorID == null)
				{
					r_FborderRightColorID = new(this, "borderRightColorID");
					r_FborderRightColorID.SetBelong(this.instance);
				}
				return r_FborderRightColorID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc borderBottomColorID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_FborderBottomColorID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RFborderBottomColorID
		{
			get
			{
				if(r_FborderBottomColorID == null)
				{
					r_FborderBottomColorID = new(this, "borderBottomColorID");
					r_FborderBottomColorID.SetBelong(this.instance);
				}
				return r_FborderBottomColorID;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc tintColorID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_FtintColorID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc RFtintColorID
		{
			get
			{
				if(r_FtintColorID == null)
				{
					r_FtintColorID = new(this, "tintColorID");
					r_FtintColorID.SetBelong(this.instance);
				}
				return r_FtintColorID;
			}
		}

		/// <summary>
		/// System.Single compositeOpacity
		/// </summary>
		protected RSystem.RSingle r_FcompositeOpacity;
		public virtual RSystem.RSingle RFcompositeOpacity
		{
			get
			{
				if(r_FcompositeOpacity == null)
				{
					r_FcompositeOpacity = new(this, "compositeOpacity");
					r_FcompositeOpacity.SetBelong(this.instance);
				}
				return r_FcompositeOpacity;
			}
		}

		/// <summary>
		/// UnityEngine.Color backgroundColor
		/// </summary>
		protected RUnityEngine.RColor r_FbackgroundColor;
		public virtual RUnityEngine.RColor RFbackgroundColor
		{
			get
			{
				if(r_FbackgroundColor == null)
				{
					r_FbackgroundColor = new(this, "backgroundColor");
					r_FbackgroundColor.SetBelong(this.instance);
				}
				return r_FbackgroundColor;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BasicNode`1[UnityEngine.UIElements.UIR.TextureEntry] textures
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBasicNode<RUnityEngine.RUIElements.RUIR.RTextureEntry> r_Ftextures;
		public virtual RUnityEngine.RUIElements.RUIR.RBasicNode<RUnityEngine.RUIElements.RUIR.RTextureEntry> RFtextures
		{
			get
			{
				if(r_Ftextures == null)
				{
					r_Ftextures = new(this, "textures");
					r_Ftextures.SetBelong(this.instance);
				}
				return r_Ftextures;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChainCommand lastClosingOrLastCommand
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChainCommand r_PlastClosingOrLastCommand;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChainCommand RPlastClosingOrLastCommand
		{
			get
			{
				if(r_PlastClosingOrLastCommand == null)
				{
					r_PlastClosingOrLastCommand = new(this, "lastClosingOrLastCommand", -1);
					r_PlastClosingOrLastCommand.SetBelong(this.instance);
				}
				return r_PlastClosingOrLastCommand;
			}
		}

		/// <summary>
		/// Boolean AllocatesID(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected static RMethod r_MAllocatesID_BMPAlloc;
		public static RMethod RMAllocatesID_BMPAlloc
		{
			get
			{
				if(r_MAllocatesID_BMPAlloc == null)
				{
					r_MAllocatesID_BMPAlloc = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainVEData"), "AllocatesID", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_MAllocatesID_BMPAlloc.SetBelong(null);
				}
				return r_MAllocatesID_BMPAlloc;
			}
		}

		/// <summary>
		/// Boolean InheritsID(UnityEngine.UIElements.UIR.BMPAlloc)
		/// </summary>
		protected static RMethod r_MInheritsID_BMPAlloc;
		public static RMethod RMInheritsID_BMPAlloc
		{
			get
			{
				if(r_MInheritsID_BMPAlloc == null)
				{
					r_MInheritsID_BMPAlloc = new( ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainVEData"), "InheritsID", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.BMPAlloc"));
					r_MInheritsID_BMPAlloc.SetBelong(null);
				}
				return r_MInheritsID_BMPAlloc;
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
					r_MEquals_Object.SetBelong(this.instance);
				}
				return r_MEquals_Object;
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
					r_MGetHashCode.SetBelong(this.instance);
				}
				return r_MGetHashCode;
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
					r_MToString.SetBelong(this.instance);
				}
				return r_MToString;
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
					r_MFinalize.SetBelong(this.instance);
				}
				return r_MFinalize;
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
					r_MGetType.SetBelong(this.instance);
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
					r_MMemberwiseClone.SetBelong(this.instance);
				}
				return r_MMemberwiseClone;
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

        public static System.Boolean AllocatesID(RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RMAllocatesID_BMPAlloc.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean InheritsID(RUnityEngine.RUIElements.RUIR.RBMPAlloc @alloc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@alloc.Value};
            var ___result = RMInheritsID_BMPAlloc.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
