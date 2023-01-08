using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.Implementation.UIRStylePainter
	/// </summary>
    public partial class RUIRStylePainter : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChain m_Owner
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RRenderChain r_m_Owner;
		public virtual RUnityEngine.RUIElements.RUIR.RRenderChain Rm_Owner
		{
			get
			{
				if(r_m_Owner == null)
				{
					r_m_Owner = new(this, "m_Owner");
					r_m_Owner.SetBelong(this.instance);
				}
				return r_m_Owner;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.UIR.Implementation.UIRStylePainter+Entry] m_Entries
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.REntry> r_m_Entries;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.REntry> Rm_Entries
		{
			get
			{
				if(r_m_Entries == null)
				{
					r_m_Entries = new(this, "m_Entries");
					r_m_Entries.SetBelong(this.instance);
				}
				return r_m_Entries;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.AtlasBase m_Atlas
		/// </summary>
		protected RUnityEngine.RUIElements.RAtlasBase r_m_Atlas;
		public virtual RUnityEngine.RUIElements.RAtlasBase Rm_Atlas
		{
			get
			{
				if(r_m_Atlas == null)
				{
					r_m_Atlas = new(this, "m_Atlas");
					r_m_Atlas.SetBelong(this.instance);
				}
				return r_m_Atlas;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.VectorImageManager m_VectorImageManager
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RVectorImageManager r_m_VectorImageManager;
		public virtual RUnityEngine.RUIElements.RUIR.RVectorImageManager Rm_VectorImageManager
		{
			get
			{
				if(r_m_VectorImageManager == null)
				{
					r_m_VectorImageManager = new(this, "m_VectorImageManager");
					r_m_VectorImageManager.SetBelong(this.instance);
				}
				return r_m_VectorImageManager;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Implementation.UIRStylePainter+Entry m_CurrentEntry
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.REntry r_m_CurrentEntry;
		public virtual RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.REntry Rm_CurrentEntry
		{
			get
			{
				if(r_m_CurrentEntry == null)
				{
					r_m_CurrentEntry = new(this, "m_CurrentEntry");
					r_m_CurrentEntry.SetBelong(this.instance);
				}
				return r_m_CurrentEntry;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Implementation.UIRStylePainter+ClosingInfo m_ClosingInfo
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.RClosingInfo r_m_ClosingInfo;
		public virtual RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.RClosingInfo Rm_ClosingInfo
		{
			get
			{
				if(r_m_ClosingInfo == null)
				{
					r_m_ClosingInfo = new(this, "m_ClosingInfo");
					r_m_ClosingInfo.SetBelong(this.instance);
				}
				return r_m_ClosingInfo;
			}
		}

		/// <summary>
		/// System.Int32 m_MaskDepth
		/// </summary>
		protected RField r_m_MaskDepth;
		public virtual RField Rm_MaskDepth
		{
			get
			{
				if(r_m_MaskDepth == null)
				{
					r_m_MaskDepth = new(this, "m_MaskDepth");
					r_m_MaskDepth.SetBelong(this.instance);
				}
				return r_m_MaskDepth;
			}
		}

		/// <summary>
		/// System.Int32 m_StencilRef
		/// </summary>
		protected RField r_m_StencilRef;
		public virtual RField Rm_StencilRef
		{
			get
			{
				if(r_m_StencilRef == null)
				{
					r_m_StencilRef = new(this, "m_StencilRef");
					r_m_StencilRef.SetBelong(this.instance);
				}
				return r_m_StencilRef;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc m_ClipRectID
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RBMPAlloc r_m_ClipRectID;
		public virtual RUnityEngine.RUIElements.RUIR.RBMPAlloc Rm_ClipRectID
		{
			get
			{
				if(r_m_ClipRectID == null)
				{
					r_m_ClipRectID = new(this, "m_ClipRectID");
					r_m_ClipRectID.SetBelong(this.instance);
				}
				return r_m_ClipRectID;
			}
		}

		/// <summary>
		/// System.Int32 m_SVGBackgroundEntryIndex
		/// </summary>
		protected RField r_m_SVGBackgroundEntryIndex;
		public virtual RField Rm_SVGBackgroundEntryIndex
		{
			get
			{
				if(r_m_SVGBackgroundEntryIndex == null)
				{
					r_m_SVGBackgroundEntryIndex = new(this, "m_SVGBackgroundEntryIndex");
					r_m_SVGBackgroundEntryIndex.SetBelong(this.instance);
				}
				return r_m_SVGBackgroundEntryIndex;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.TempAllocator`1[UnityEngine.UIElements.Vertex] m_VertsPool
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RTempAllocator<RUnityEngine.RUIElements.RVertex> r_m_VertsPool;
		public virtual RUnityEngine.RUIElements.RUIR.RTempAllocator<RUnityEngine.RUIElements.RVertex> Rm_VertsPool
		{
			get
			{
				if(r_m_VertsPool == null)
				{
					r_m_VertsPool = new(this, "m_VertsPool");
					r_m_VertsPool.SetBelong(this.instance);
				}
				return r_m_VertsPool;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.TempAllocator`1[System.UInt16] m_IndicesPool
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RTempAllocator<RField> r_m_IndicesPool;
		public virtual RUnityEngine.RUIElements.RUIR.RTempAllocator<RField> Rm_IndicesPool
		{
			get
			{
				if(r_m_IndicesPool == null)
				{
					r_m_IndicesPool = new(this, "m_IndicesPool");
					r_m_IndicesPool.SetBelong(this.instance);
				}
				return r_m_IndicesPool;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.MeshWriteData] m_MeshWriteDataPool
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RMeshWriteData> r_m_MeshWriteDataPool;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RMeshWriteData> Rm_MeshWriteDataPool
		{
			get
			{
				if(r_m_MeshWriteDataPool == null)
				{
					r_m_MeshWriteDataPool = new(this, "m_MeshWriteDataPool");
					r_m_MeshWriteDataPool.SetBelong(this.instance);
				}
				return r_m_MeshWriteDataPool;
			}
		}

		/// <summary>
		/// System.Int32 m_NextMeshWriteDataPoolItem
		/// </summary>
		protected RField r_m_NextMeshWriteDataPoolItem;
		public virtual RField Rm_NextMeshWriteDataPoolItem
		{
			get
			{
				if(r_m_NextMeshWriteDataPoolItem == null)
				{
					r_m_NextMeshWriteDataPoolItem = new(this, "m_NextMeshWriteDataPoolItem");
					r_m_NextMeshWriteDataPoolItem.SetBelong(this.instance);
				}
				return r_m_NextMeshWriteDataPoolItem;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.UIR.Implementation.UIRStylePainter+RepeatRectUV][] m_RepeatRectUVList
		/// </summary>
		protected RFieldArray<RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.RRepeatRectUV>> r_m_RepeatRectUVList;
		public virtual RFieldArray<RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.RRepeatRectUV>> Rm_RepeatRectUVList
		{
			get
			{
				if(r_m_RepeatRectUVList == null)
				{
					r_m_RepeatRectUVList = new(this, "m_RepeatRectUVList");
					r_m_RepeatRectUVList.SetBelong(this.instance);
				}
				return r_m_RepeatRectUVList;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.MeshBuilder+AllocMeshData+Allocator m_AllocRawVertsIndicesDelegate
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RMeshBuilder.RAllocMeshData.RAllocator r_m_AllocRawVertsIndicesDelegate;
		public virtual RUnityEngine.RUIElements.RUIR.RMeshBuilder.RAllocMeshData.RAllocator Rm_AllocRawVertsIndicesDelegate
		{
			get
			{
				if(r_m_AllocRawVertsIndicesDelegate == null)
				{
					r_m_AllocRawVertsIndicesDelegate = new(this, "m_AllocRawVertsIndicesDelegate");
					r_m_AllocRawVertsIndicesDelegate.SetBelong(this.instance);
				}
				return r_m_AllocRawVertsIndicesDelegate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.MeshBuilder+AllocMeshData+Allocator m_AllocThroughDrawMeshDelegate
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RMeshBuilder.RAllocMeshData.RAllocator r_m_AllocThroughDrawMeshDelegate;
		public virtual RUnityEngine.RUIElements.RUIR.RMeshBuilder.RAllocMeshData.RAllocator Rm_AllocThroughDrawMeshDelegate
		{
			get
			{
				if(r_m_AllocThroughDrawMeshDelegate == null)
				{
					r_m_AllocThroughDrawMeshDelegate = new(this, "m_AllocThroughDrawMeshDelegate");
					r_m_AllocThroughDrawMeshDelegate.SetBelong(this.instance);
				}
				return r_m_AllocThroughDrawMeshDelegate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshGenerationContext <meshGenerationContext>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RMeshGenerationContext r___0__meshGenerationContext__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RMeshGenerationContext R__0__meshGenerationContext__1__k__BackingField
		{
			get
			{
				if(r___0__meshGenerationContext__1__k__BackingField == null)
				{
					r___0__meshGenerationContext__1__k__BackingField = new(this, "<meshGenerationContext>k__BackingField");
					r___0__meshGenerationContext__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__meshGenerationContext__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement <currentElement>k__BackingField
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r___0__currentElement__1__k__BackingField;
		public virtual RUnityEngine.RUIElements.RVisualElement R__0__currentElement__1__k__BackingField
		{
			get
			{
				if(r___0__currentElement__1__k__BackingField == null)
				{
					r___0__currentElement__1__k__BackingField = new(this, "<currentElement>k__BackingField");
					r___0__currentElement__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__currentElement__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <totalVertices>k__BackingField
		/// </summary>
		protected RField r___0__totalVertices__1__k__BackingField;
		public virtual RField R__0__totalVertices__1__k__BackingField
		{
			get
			{
				if(r___0__totalVertices__1__k__BackingField == null)
				{
					r___0__totalVertices__1__k__BackingField = new(this, "<totalVertices>k__BackingField");
					r___0__totalVertices__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__totalVertices__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <totalIndices>k__BackingField
		/// </summary>
		protected RField r___0__totalIndices__1__k__BackingField;
		public virtual RField R__0__totalIndices__1__k__BackingField
		{
			get
			{
				if(r___0__totalIndices__1__k__BackingField == null)
				{
					r___0__totalIndices__1__k__BackingField = new(this, "<totalIndices>k__BackingField");
					r___0__totalIndices__1__k__BackingField.SetBelong(this.instance);
				}
				return r___0__totalIndices__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextInfo m_TextInfo
		/// </summary>
		protected RUnityEngine.RTextCore.RText.RTextInfo r_m_TextInfo;
		public virtual RUnityEngine.RTextCore.RText.RTextInfo Rm_TextInfo
		{
			get
			{
				if(r_m_TextInfo == null)
				{
					r_m_TextInfo = new(this, "m_TextInfo");
					r_m_TextInfo.SetBelong(this.instance);
				}
				return r_m_TextInfo;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshGenerationContext meshGenerationContext
		/// </summary>
		protected RUnityEngine.RUIElements.RMeshGenerationContext r_meshGenerationContext;
		public virtual RUnityEngine.RUIElements.RMeshGenerationContext RmeshGenerationContext
		{
			get
			{
				if(r_meshGenerationContext == null)
				{
					r_meshGenerationContext = new(this, "meshGenerationContext", -1);
					r_meshGenerationContext.SetBelong(this.instance);
				}
				return r_meshGenerationContext;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement currentElement
		/// </summary>
		protected RUnityEngine.RUIElements.RVisualElement r_currentElement;
		public virtual RUnityEngine.RUIElements.RVisualElement RcurrentElement
		{
			get
			{
				if(r_currentElement == null)
				{
					r_currentElement = new(this, "currentElement", -1);
					r_currentElement.SetBelong(this.instance);
				}
				return r_currentElement;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.UIR.Implementation.UIRStylePainter+Entry] entries
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.REntry> r_entries;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.REntry> Rentries
		{
			get
			{
				if(r_entries == null)
				{
					r_entries = new(this, "entries", -1);
					r_entries.SetBelong(this.instance);
				}
				return r_entries;
			}
		}

		/// <summary>
		/// ClosingInfo closingInfo
		/// </summary>
		protected RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.RClosingInfo r_closingInfo;
		public virtual RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.RClosingInfo RclosingInfo
		{
			get
			{
				if(r_closingInfo == null)
				{
					r_closingInfo = new(this, "closingInfo", -1);
					r_closingInfo.SetBelong(this.instance);
				}
				return r_closingInfo;
			}
		}

		/// <summary>
		/// Int32 totalVertices
		/// </summary>
		protected RProperty r_totalVertices;
		public virtual RProperty RtotalVertices
		{
			get
			{
				if(r_totalVertices == null)
				{
					r_totalVertices = new(this, "totalVertices", -1);
					r_totalVertices.SetBelong(this.instance);
				}
				return r_totalVertices;
			}
		}

		/// <summary>
		/// Int32 totalIndices
		/// </summary>
		protected RProperty r_totalIndices;
		public virtual RProperty RtotalIndices
		{
			get
			{
				if(r_totalIndices == null)
				{
					r_totalIndices = new(this, "totalIndices", -1);
					r_totalIndices.SetBelong(this.instance);
				}
				return r_totalIndices;
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
		/// UnityEngine.UIElements.MeshWriteData GetPooledMeshWriteData()
		/// </summary>
		protected RMethod r_GetPooledMeshWriteData;
		public virtual RMethod RGetPooledMeshWriteData
		{
			get
			{
				if(r_GetPooledMeshWriteData == null)
				{
					r_GetPooledMeshWriteData = new(this, "GetPooledMeshWriteData", 0);
					r_GetPooledMeshWriteData.SetBelong(this.instance);
				}
				return r_GetPooledMeshWriteData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshWriteData AllocRawVertsIndices(UInt32, UInt32, AllocMeshData ByRef)
		/// </summary>
		protected RMethod r_AllocRawVertsIndices_UInt32_UInt32_Ref_AllocMeshData;
		public virtual RMethod RAllocRawVertsIndices_UInt32_UInt32_Ref_AllocMeshData
		{
			get
			{
				if(r_AllocRawVertsIndices_UInt32_UInt32_Ref_AllocMeshData == null)
				{
					r_AllocRawVertsIndices_UInt32_UInt32_Ref_AllocMeshData = new(this, "AllocRawVertsIndices", 0, typeof(System.UInt32), typeof(System.UInt32),  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.MeshBuilder+AllocMeshData").MakeByRefType());
					r_AllocRawVertsIndices_UInt32_UInt32_Ref_AllocMeshData.SetBelong(this.instance);
				}
				return r_AllocRawVertsIndices_UInt32_UInt32_Ref_AllocMeshData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshWriteData AllocThroughDrawMesh(UInt32, UInt32, AllocMeshData ByRef)
		/// </summary>
		protected RMethod r_AllocThroughDrawMesh_UInt32_UInt32_Ref_AllocMeshData;
		public virtual RMethod RAllocThroughDrawMesh_UInt32_UInt32_Ref_AllocMeshData
		{
			get
			{
				if(r_AllocThroughDrawMesh_UInt32_UInt32_Ref_AllocMeshData == null)
				{
					r_AllocThroughDrawMesh_UInt32_UInt32_Ref_AllocMeshData = new(this, "AllocThroughDrawMesh", 0, typeof(System.UInt32), typeof(System.UInt32),  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.MeshBuilder+AllocMeshData").MakeByRefType());
					r_AllocThroughDrawMesh_UInt32_UInt32_Ref_AllocMeshData.SetBelong(this.instance);
				}
				return r_AllocThroughDrawMesh_UInt32_UInt32_Ref_AllocMeshData;
			}
		}

		/// <summary>
		/// Void Begin(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_Begin_VisualElement;
		public virtual RMethod RBegin_VisualElement
		{
			get
			{
				if(r_Begin_VisualElement == null)
				{
					r_Begin_VisualElement = new(this, "Begin", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_Begin_VisualElement.SetBelong(this.instance);
				}
				return r_Begin_VisualElement;
			}
		}

		/// <summary>
		/// Void LandClipUnregisterMeshDrawCommand(UnityEngine.UIElements.UIR.RenderChainCommand)
		/// </summary>
		protected RMethod r_LandClipUnregisterMeshDrawCommand_RenderChainCommand;
		public virtual RMethod RLandClipUnregisterMeshDrawCommand_RenderChainCommand
		{
			get
			{
				if(r_LandClipUnregisterMeshDrawCommand_RenderChainCommand == null)
				{
					r_LandClipUnregisterMeshDrawCommand_RenderChainCommand = new(this, "LandClipUnregisterMeshDrawCommand", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"));
					r_LandClipUnregisterMeshDrawCommand_RenderChainCommand.SetBelong(this.instance);
				}
				return r_LandClipUnregisterMeshDrawCommand_RenderChainCommand;
			}
		}

		/// <summary>
		/// Void LandClipRegisterMesh(Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex], Unity.Collections.NativeSlice`1[System.UInt16], Int32)
		/// </summary>
		protected RMethod r_LandClipRegisterMesh_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Int32;
		public virtual RMethod RLandClipRegisterMesh_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Int32
		{
			get
			{
				if(r_LandClipRegisterMesh_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Int32 == null)
				{
					r_LandClipRegisterMesh_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Int32 = new(this, "LandClipRegisterMesh", 0, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(UnityEngine.UIElements.Vertex)), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(System.UInt16)), typeof(System.Int32));
					r_LandClipRegisterMesh_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Int32.SetBelong(this.instance);
				}
				return r_LandClipRegisterMesh_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshWriteData AddGradientsEntry(Int32, Int32, UnityEngine.UIElements.TextureId, UnityEngine.Material, MeshFlags)
		/// </summary>
		protected RMethod r_AddGradientsEntry_Int32_Int32_TextureId_Material_MeshFlags;
		public virtual RMethod RAddGradientsEntry_Int32_Int32_TextureId_Material_MeshFlags
		{
			get
			{
				if(r_AddGradientsEntry_Int32_Int32_TextureId_Material_MeshFlags == null)
				{
					r_AddGradientsEntry_Int32_Int32_TextureId_Material_MeshFlags = new(this, "AddGradientsEntry", 0, typeof(System.Int32), typeof(System.Int32),  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"), typeof(UnityEngine.Material),  ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContext+MeshFlags"));
					r_AddGradientsEntry_Int32_Int32_TextureId_Material_MeshFlags.SetBelong(this.instance);
				}
				return r_AddGradientsEntry_Int32_Int32_TextureId_Material_MeshFlags;
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
					r_DrawMesh_Int32_Int32_Texture_Material_MeshFlags = new(this, "DrawMesh", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Texture), typeof(UnityEngine.Material),  ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContext+MeshFlags"));
					r_DrawMesh_Int32_Int32_Texture_Material_MeshFlags.SetBelong(this.instance);
				}
				return r_DrawMesh_Int32_Int32_Texture_Material_MeshFlags;
			}
		}

		/// <summary>
		/// Void TryAtlasTexture(UnityEngine.Texture, MeshFlags, UnityEngine.Rect ByRef, Boolean ByRef, UnityEngine.UIElements.TextureId ByRef, UnityEngine.UIElements.UIR.VertexFlags ByRef)
		/// </summary>
		protected RMethod r_TryAtlasTexture_Texture_MeshFlags_Out_Rect_Out_Boolean_Out_TextureId_Out_VertexFlags;
		public virtual RMethod RTryAtlasTexture_Texture_MeshFlags_Out_Rect_Out_Boolean_Out_TextureId_Out_VertexFlags
		{
			get
			{
				if(r_TryAtlasTexture_Texture_MeshFlags_Out_Rect_Out_Boolean_Out_TextureId_Out_VertexFlags == null)
				{
					r_TryAtlasTexture_Texture_MeshFlags_Out_Rect_Out_Boolean_Out_TextureId_Out_VertexFlags = new(this, "TryAtlasTexture", 0, typeof(UnityEngine.Texture),  ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContext+MeshFlags"), typeof(UnityEngine.Rect).MakeByRefType(), typeof(System.Boolean).MakeByRefType(),  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId").MakeByRefType(),  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.VertexFlags").MakeByRefType());
					r_TryAtlasTexture_Texture_MeshFlags_Out_Rect_Out_Boolean_Out_TextureId_Out_VertexFlags.SetBelong(this.instance);
				}
				return r_TryAtlasTexture_Texture_MeshFlags_Out_Rect_Out_Boolean_Out_TextureId_Out_VertexFlags;
			}
		}

		/// <summary>
		/// Void BuildEntryFromNativeMesh(UnityEngine.UIElements.MeshWriteDataInterface, UnityEngine.Texture, UnityEngine.UIElements.TextureId, Boolean, UnityEngine.Material, MeshFlags, UnityEngine.Rect, UnityEngine.UIElements.UIR.VertexFlags)
		/// </summary>
		protected RMethod r_BuildEntryFromNativeMesh_MeshWriteDataInterface_Texture_TextureId_Boolean_Material_MeshFlags_Rect_VertexFlags;
		public virtual RMethod RBuildEntryFromNativeMesh_MeshWriteDataInterface_Texture_TextureId_Boolean_Material_MeshFlags_Rect_VertexFlags
		{
			get
			{
				if(r_BuildEntryFromNativeMesh_MeshWriteDataInterface_Texture_TextureId_Boolean_Material_MeshFlags_Rect_VertexFlags == null)
				{
					r_BuildEntryFromNativeMesh_MeshWriteDataInterface_Texture_TextureId_Boolean_Material_MeshFlags_Rect_VertexFlags = new(this, "BuildEntryFromNativeMesh", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.MeshWriteDataInterface"), typeof(UnityEngine.Texture),  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"), typeof(System.Boolean), typeof(UnityEngine.Material),  ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContext+MeshFlags"), typeof(UnityEngine.Rect),  ReleactionUtils.GetType("UnityEngine.UIElements.UIR.VertexFlags"));
					r_BuildEntryFromNativeMesh_MeshWriteDataInterface_Texture_TextureId_Boolean_Material_MeshFlags_Rect_VertexFlags.SetBelong(this.instance);
				}
				return r_BuildEntryFromNativeMesh_MeshWriteDataInterface_Texture_TextureId_Boolean_Material_MeshFlags_Rect_VertexFlags;
			}
		}

		/// <summary>
		/// Void BuildGradientEntryFromNativeMesh(UnityEngine.UIElements.MeshWriteDataInterface, UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_BuildGradientEntryFromNativeMesh_MeshWriteDataInterface_TextureId;
		public virtual RMethod RBuildGradientEntryFromNativeMesh_MeshWriteDataInterface_TextureId
		{
			get
			{
				if(r_BuildGradientEntryFromNativeMesh_MeshWriteDataInterface_TextureId == null)
				{
					r_BuildGradientEntryFromNativeMesh_MeshWriteDataInterface_TextureId = new(this, "BuildGradientEntryFromNativeMesh", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.MeshWriteDataInterface"),  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_BuildGradientEntryFromNativeMesh_MeshWriteDataInterface_TextureId.SetBelong(this.instance);
				}
				return r_BuildGradientEntryFromNativeMesh_MeshWriteDataInterface_TextureId;
			}
		}

		/// <summary>
		/// Void BuildRawEntryFromNativeMesh(UnityEngine.UIElements.MeshWriteDataInterface)
		/// </summary>
		protected RMethod r_BuildRawEntryFromNativeMesh_MeshWriteDataInterface;
		public virtual RMethod RBuildRawEntryFromNativeMesh_MeshWriteDataInterface
		{
			get
			{
				if(r_BuildRawEntryFromNativeMesh_MeshWriteDataInterface == null)
				{
					r_BuildRawEntryFromNativeMesh_MeshWriteDataInterface = new(this, "BuildRawEntryFromNativeMesh", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.MeshWriteDataInterface"));
					r_BuildRawEntryFromNativeMesh_MeshWriteDataInterface.SetBelong(this.instance);
				}
				return r_BuildRawEntryFromNativeMesh_MeshWriteDataInterface;
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
		/// Void DrawTextInfo(UnityEngine.TextCore.Text.TextInfo, UnityEngine.Vector2, Boolean)
		/// </summary>
		protected RMethod r_DrawTextInfo_TextInfo_Vector2_Boolean;
		public virtual RMethod RDrawTextInfo_TextInfo_Vector2_Boolean
		{
			get
			{
				if(r_DrawTextInfo_TextInfo_Vector2_Boolean == null)
				{
					r_DrawTextInfo_TextInfo_Vector2_Boolean = new(this, "DrawTextInfo", 0,  ReleactionUtils.GetType("UnityEngine.TextCore.Text.TextInfo"), typeof(UnityEngine.Vector2), typeof(System.Boolean));
					r_DrawTextInfo_TextInfo_Vector2_Boolean.SetBelong(this.instance);
				}
				return r_DrawTextInfo_TextInfo_Vector2_Boolean;
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
					r_DrawRectangle_RectangleParams = new(this, "DrawRectangle", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"));
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
					r_DrawBorder_BorderParams = new(this, "DrawBorder", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+BorderParams"));
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

		/// <summary>
		/// Void DrawVisualElementBackground()
		/// </summary>
		protected RMethod r_DrawVisualElementBackground;
		public virtual RMethod RDrawVisualElementBackground
		{
			get
			{
				if(r_DrawVisualElementBackground == null)
				{
					r_DrawVisualElementBackground = new(this, "DrawVisualElementBackground", 0);
					r_DrawVisualElementBackground.SetBelong(this.instance);
				}
				return r_DrawVisualElementBackground;
			}
		}

		/// <summary>
		/// Void DrawRectangleRepeat(RectangleParams, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_DrawRectangleRepeat_RectangleParams_Rect;
		public virtual RMethod RDrawRectangleRepeat_RectangleParams_Rect
		{
			get
			{
				if(r_DrawRectangleRepeat_RectangleParams_Rect == null)
				{
					r_DrawRectangleRepeat_RectangleParams_Rect = new(this, "DrawRectangleRepeat", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), typeof(UnityEngine.Rect));
					r_DrawRectangleRepeat_RectangleParams_Rect.SetBelong(this.instance);
				}
				return r_DrawRectangleRepeat_RectangleParams_Rect;
			}
		}

		/// <summary>
		/// Void StampRectangleWithSubRect(RectangleParams, UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_StampRectangleWithSubRect_RectangleParams_Rect_Rect;
		public virtual RMethod RStampRectangleWithSubRect_RectangleParams_Rect_Rect
		{
			get
			{
				if(r_StampRectangleWithSubRect_RectangleParams_Rect_Rect == null)
				{
					r_StampRectangleWithSubRect_RectangleParams_Rect_Rect = new(this, "StampRectangleWithSubRect", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
					r_StampRectangleWithSubRect_RectangleParams_Rect_Rect.SetBelong(this.instance);
				}
				return r_StampRectangleWithSubRect_RectangleParams_Rect_Rect;
			}
		}

		/// <summary>
		/// Void DrawVisualElementBorder()
		/// </summary>
		protected RMethod r_DrawVisualElementBorder;
		public virtual RMethod RDrawVisualElementBorder
		{
			get
			{
				if(r_DrawVisualElementBorder == null)
				{
					r_DrawVisualElementBorder = new(this, "DrawVisualElementBorder", 0);
					r_DrawVisualElementBorder.SetBelong(this.instance);
				}
				return r_DrawVisualElementBorder;
			}
		}

		/// <summary>
		/// Void ApplyVisualElementClipping()
		/// </summary>
		protected RMethod r_ApplyVisualElementClipping;
		public virtual RMethod RApplyVisualElementClipping
		{
			get
			{
				if(r_ApplyVisualElementClipping == null)
				{
					r_ApplyVisualElementClipping = new(this, "ApplyVisualElementClipping", 0);
					r_ApplyVisualElementClipping.SetBelong(this.instance);
				}
				return r_ApplyVisualElementClipping;
			}
		}

		/// <summary>
		/// UInt16[] AdjustSpriteWinding(UnityEngine.Vector2[], UInt16[])
		/// </summary>
		protected RMethod r_AdjustSpriteWinding_Vector2Array_UInt16Array;
		public virtual RMethod RAdjustSpriteWinding_Vector2Array_UInt16Array
		{
			get
			{
				if(r_AdjustSpriteWinding_Vector2Array_UInt16Array == null)
				{
					r_AdjustSpriteWinding_Vector2Array_UInt16Array = new(this, "AdjustSpriteWinding", 0, typeof(UnityEngine.Vector2).MakeArrayType(), typeof(System.UInt16).MakeArrayType());
					r_AdjustSpriteWinding_Vector2Array_UInt16Array.SetBelong(this.instance);
				}
				return r_AdjustSpriteWinding_Vector2Array_UInt16Array;
			}
		}

		/// <summary>
		/// Void DrawSprite(RectangleParams)
		/// </summary>
		protected RMethod r_DrawSprite_RectangleParams;
		public virtual RMethod RDrawSprite_RectangleParams
		{
			get
			{
				if(r_DrawSprite_RectangleParams == null)
				{
					r_DrawSprite_RectangleParams = new(this, "DrawSprite", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"));
					r_DrawSprite_RectangleParams.SetBelong(this.instance);
				}
				return r_DrawSprite_RectangleParams;
			}
		}

		/// <summary>
		/// Void RegisterVectorImageGradient(UnityEngine.UIElements.VectorImage, Int32 ByRef, UnityEngine.UIElements.TextureId ByRef)
		/// </summary>
		protected RMethod r_RegisterVectorImageGradient_VectorImage_Out_Int32_Out_TextureId;
		public virtual RMethod RRegisterVectorImageGradient_VectorImage_Out_Int32_Out_TextureId
		{
			get
			{
				if(r_RegisterVectorImageGradient_VectorImage_Out_Int32_Out_TextureId == null)
				{
					r_RegisterVectorImageGradient_VectorImage_Out_Int32_Out_TextureId = new(this, "RegisterVectorImageGradient", 0, typeof(UnityEngine.UIElements.VectorImage), typeof(System.Int32).MakeByRefType(),  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId").MakeByRefType());
					r_RegisterVectorImageGradient_VectorImage_Out_Int32_Out_TextureId.SetBelong(this.instance);
				}
				return r_RegisterVectorImageGradient_VectorImage_Out_Int32_Out_TextureId;
			}
		}

		/// <summary>
		/// Void DrawVectorImage(RectangleParams)
		/// </summary>
		protected RMethod r_DrawVectorImage_RectangleParams;
		public virtual RMethod RDrawVectorImage_RectangleParams
		{
			get
			{
				if(r_DrawVectorImage_RectangleParams == null)
				{
					r_DrawVectorImage_RectangleParams = new(this, "DrawVectorImage", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"));
					r_DrawVectorImage_RectangleParams.SetBelong(this.instance);
				}
				return r_DrawVectorImage_RectangleParams;
			}
		}

		/// <summary>
		/// Void MakeVectorGraphics(RectangleParams, Boolean, UnityEngine.UIElements.TextureId, Int32, Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_MakeVectorGraphics_RectangleParams_Boolean_TextureId_Int32_Out_Int32_Out_Int32;
		public virtual RMethod RMakeVectorGraphics_RectangleParams_Boolean_TextureId_Int32_Out_Int32_Out_Int32
		{
			get
			{
				if(r_MakeVectorGraphics_RectangleParams_Boolean_TextureId_Int32_Out_Int32_Out_Int32 == null)
				{
					r_MakeVectorGraphics_RectangleParams_Boolean_TextureId_Int32_Out_Int32_Out_Int32 = new(this, "MakeVectorGraphics", 0,  ReleactionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), typeof(System.Boolean),  ReleactionUtils.GetType("UnityEngine.UIElements.TextureId"), typeof(System.Int32), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_MakeVectorGraphics_RectangleParams_Boolean_TextureId_Int32_Out_Int32_Out_Int32.SetBelong(this.instance);
				}
				return r_MakeVectorGraphics_RectangleParams_Boolean_TextureId_Int32_Out_Int32_Out_Int32;
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
		/// Void ValidateMeshWriteData()
		/// </summary>
		protected RMethod r_ValidateMeshWriteData;
		public virtual RMethod RValidateMeshWriteData
		{
			get
			{
				if(r_ValidateMeshWriteData == null)
				{
					r_ValidateMeshWriteData = new(this, "ValidateMeshWriteData", 0);
					r_ValidateMeshWriteData.SetBelong(this.instance);
				}
				return r_ValidateMeshWriteData;
			}
		}

		/// <summary>
		/// Void GenerateStencilClipEntryForRoundedRectBackground()
		/// </summary>
		protected RMethod r_GenerateStencilClipEntryForRoundedRectBackground;
		public virtual RMethod RGenerateStencilClipEntryForRoundedRectBackground
		{
			get
			{
				if(r_GenerateStencilClipEntryForRoundedRectBackground == null)
				{
					r_GenerateStencilClipEntryForRoundedRectBackground = new(this, "GenerateStencilClipEntryForRoundedRectBackground", 0);
					r_GenerateStencilClipEntryForRoundedRectBackground.SetBelong(this.instance);
				}
				return r_GenerateStencilClipEntryForRoundedRectBackground;
			}
		}

		/// <summary>
		/// Void GenerateStencilClipEntryForSVGBackground()
		/// </summary>
		protected RMethod r_GenerateStencilClipEntryForSVGBackground;
		public virtual RMethod RGenerateStencilClipEntryForSVGBackground
		{
			get
			{
				if(r_GenerateStencilClipEntryForSVGBackground == null)
				{
					r_GenerateStencilClipEntryForSVGBackground = new(this, "GenerateStencilClipEntryForSVGBackground", 0);
					r_GenerateStencilClipEntryForSVGBackground.SetBelong(this.instance);
				}
				return r_GenerateStencilClipEntryForSVGBackground;
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


        public RUIRStylePainter() : base("UnityEngine.UIElements.UIR.Implementation.UIRStylePainter")
        {
        }

        public RUIRStylePainter(System.Object instance) : base("UnityEngine.UIElements.UIR.Implementation.UIRStylePainter")
		{
            SetInstance(instance);
		}

        public RUIRStylePainter(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUIRStylePainter(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual UnityEngine.UIElements.MeshWriteData GetPooledMeshWriteData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPooledMeshWriteData.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.MeshWriteData)___result;
        }




        public virtual void Begin(UnityEngine.UIElements.VisualElement  @ve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve};
            var ___result = RBegin_VisualElement.Invoke(___genericsType, ___parameters);

            
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


        public virtual void DrawVectorImage(UnityEngine.UIElements.VectorImage  @vectorImage, UnityEngine.Vector2  @offset, UnityEngine.UIElements.Angle  @rotationAngle, UnityEngine.Vector2  @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vectorImage, @offset, @rotationAngle, @scale};
            var ___result = RDrawVectorImage_VectorImage_Vector2_Angle_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawVisualElementBackground()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDrawVisualElementBackground.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void DrawVisualElementBorder()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDrawVisualElementBorder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyVisualElementClipping()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RApplyVisualElementClipping.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.UInt16[] AdjustSpriteWinding(UnityEngine.Vector2[]  @vertices, System.UInt16[]  @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertices, @indices};
            var ___result = RAdjustSpriteWinding_Vector2Array_UInt16Array.Invoke(___genericsType, ___parameters);

            return (System.UInt16[])___result;
        }






        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ValidateMeshWriteData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RValidateMeshWriteData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GenerateStencilClipEntryForRoundedRectBackground()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGenerateStencilClipEntryForRoundedRectBackground.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GenerateStencilClipEntryForSVGBackground()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGenerateStencilClipEntryForSVGBackground.Invoke(___genericsType, ___parameters);

            
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
