
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation
{
	/// <summary>
	/// UnityEngine.UIElements.UIR.Implementation.UIRStylePainter
	/// </summary>
    public partial class RUIRStylePainter : RMember //
    {

		/// <summary>
		/// UnityEngine.UIElements.UIR.RenderChain m_Owner
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChain r_Fm_Owner;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChain RFm_Owner
		{
			get
			{
				if(r_Fm_Owner == null)
				{
					r_Fm_Owner = new(this, "m_Owner");
					r_Fm_Owner.SetBelong(this.GetValue());
				}
				return r_Fm_Owner;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.UIR.Implementation.UIRStylePainter+Entry] m_Entries
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.REntry> r_Fm_Entries;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.REntry> RFm_Entries
		{
			get
			{
				if(r_Fm_Entries == null)
				{
					r_Fm_Entries = new(this, "m_Entries");
					r_Fm_Entries.SetBelong(this.GetValue());
				}
				return r_Fm_Entries;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.AtlasBase m_Atlas
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAtlasBase r_Fm_Atlas;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RAtlasBase RFm_Atlas
		{
			get
			{
				if(r_Fm_Atlas == null)
				{
					r_Fm_Atlas = new(this, "m_Atlas");
					r_Fm_Atlas.SetBelong(this.GetValue());
				}
				return r_Fm_Atlas;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.VectorImageManager m_VectorImageManager
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVectorImageManager r_Fm_VectorImageManager;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVectorImageManager RFm_VectorImageManager
		{
			get
			{
				if(r_Fm_VectorImageManager == null)
				{
					r_Fm_VectorImageManager = new(this, "m_VectorImageManager");
					r_Fm_VectorImageManager.SetBelong(this.GetValue());
				}
				return r_Fm_VectorImageManager;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Implementation.UIRStylePainter+Entry m_CurrentEntry
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.REntry r_Fm_CurrentEntry;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.REntry RFm_CurrentEntry
		{
			get
			{
				if(r_Fm_CurrentEntry == null)
				{
					r_Fm_CurrentEntry = new(this, "m_CurrentEntry");
					r_Fm_CurrentEntry.SetBelong(this.GetValue());
				}
				return r_Fm_CurrentEntry;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.Implementation.UIRStylePainter+ClosingInfo m_ClosingInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.RClosingInfo r_Fm_ClosingInfo;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.RClosingInfo RFm_ClosingInfo
		{
			get
			{
				if(r_Fm_ClosingInfo == null)
				{
					r_Fm_ClosingInfo = new(this, "m_ClosingInfo");
					r_Fm_ClosingInfo.SetBelong(this.GetValue());
				}
				return r_Fm_ClosingInfo;
			}
		}

		/// <summary>
		/// System.Int32 m_MaskDepth
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_MaskDepth;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_MaskDepth
		{
			get
			{
				if(r_Fm_MaskDepth == null)
				{
					r_Fm_MaskDepth = new(this, "m_MaskDepth");
					r_Fm_MaskDepth.SetBelong(this.GetValue());
				}
				return r_Fm_MaskDepth;
			}
		}

		/// <summary>
		/// System.Int32 m_StencilRef
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_StencilRef;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_StencilRef
		{
			get
			{
				if(r_Fm_StencilRef == null)
				{
					r_Fm_StencilRef = new(this, "m_StencilRef");
					r_Fm_StencilRef.SetBelong(this.GetValue());
				}
				return r_Fm_StencilRef;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.BMPAlloc m_ClipRectID
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc r_Fm_ClipRectID;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RBMPAlloc RFm_ClipRectID
		{
			get
			{
				if(r_Fm_ClipRectID == null)
				{
					r_Fm_ClipRectID = new(this, "m_ClipRectID");
					r_Fm_ClipRectID.SetBelong(this.GetValue());
				}
				return r_Fm_ClipRectID;
			}
		}

		/// <summary>
		/// System.Int32 m_SVGBackgroundEntryIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_SVGBackgroundEntryIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_SVGBackgroundEntryIndex
		{
			get
			{
				if(r_Fm_SVGBackgroundEntryIndex == null)
				{
					r_Fm_SVGBackgroundEntryIndex = new(this, "m_SVGBackgroundEntryIndex");
					r_Fm_SVGBackgroundEntryIndex.SetBelong(this.GetValue());
				}
				return r_Fm_SVGBackgroundEntryIndex;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.TempAllocator`1[UnityEngine.UIElements.Vertex] m_VertsPool
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTempAllocator<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> r_Fm_VertsPool;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTempAllocator<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> RFm_VertsPool
		{
			get
			{
				if(r_Fm_VertsPool == null)
				{
					r_Fm_VertsPool = new(this, "m_VertsPool");
					r_Fm_VertsPool.SetBelong(this.GetValue());
				}
				return r_Fm_VertsPool;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.TempAllocator`1[System.UInt16] m_IndicesPool
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTempAllocator<Hvak.Editor.Refleaction.RSystem.RUInt16> r_Fm_IndicesPool;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RTempAllocator<Hvak.Editor.Refleaction.RSystem.RUInt16> RFm_IndicesPool
		{
			get
			{
				if(r_Fm_IndicesPool == null)
				{
					r_Fm_IndicesPool = new(this, "m_IndicesPool");
					r_Fm_IndicesPool.SetBelong(this.GetValue());
				}
				return r_Fm_IndicesPool;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.MeshWriteData] m_MeshWriteDataPool
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshWriteData> r_Fm_MeshWriteDataPool;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshWriteData> RFm_MeshWriteDataPool
		{
			get
			{
				if(r_Fm_MeshWriteDataPool == null)
				{
					r_Fm_MeshWriteDataPool = new(this, "m_MeshWriteDataPool");
					r_Fm_MeshWriteDataPool.SetBelong(this.GetValue());
				}
				return r_Fm_MeshWriteDataPool;
			}
		}

		/// <summary>
		/// System.Int32 m_NextMeshWriteDataPoolItem
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_NextMeshWriteDataPoolItem;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_NextMeshWriteDataPoolItem
		{
			get
			{
				if(r_Fm_NextMeshWriteDataPoolItem == null)
				{
					r_Fm_NextMeshWriteDataPoolItem = new(this, "m_NextMeshWriteDataPoolItem");
					r_Fm_NextMeshWriteDataPoolItem.SetBelong(this.GetValue());
				}
				return r_Fm_NextMeshWriteDataPoolItem;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.UIR.Implementation.UIRStylePainter+RepeatRectUV][] m_RepeatRectUVList
		/// </summary>
		protected Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.RRepeatRectUV>> r_Fm_RepeatRectUVList;
		public virtual Hvak.Editor.Refleaction.RFieldArray<Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.RRepeatRectUV>> RFm_RepeatRectUVList
		{
			get
			{
				if(r_Fm_RepeatRectUVList == null)
				{
					r_Fm_RepeatRectUVList = new(this, "m_RepeatRectUVList");
					r_Fm_RepeatRectUVList.SetBelong(this.GetValue());
				}
				return r_Fm_RepeatRectUVList;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.MeshBuilder+AllocMeshData+Allocator m_AllocRawVertsIndicesDelegate
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RMeshBuilder.RAllocMeshData.RAllocator r_Fm_AllocRawVertsIndicesDelegate;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RMeshBuilder.RAllocMeshData.RAllocator RFm_AllocRawVertsIndicesDelegate
		{
			get
			{
				if(r_Fm_AllocRawVertsIndicesDelegate == null)
				{
					r_Fm_AllocRawVertsIndicesDelegate = new(this, "m_AllocRawVertsIndicesDelegate");
					r_Fm_AllocRawVertsIndicesDelegate.SetBelong(this.GetValue());
				}
				return r_Fm_AllocRawVertsIndicesDelegate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.UIR.MeshBuilder+AllocMeshData+Allocator m_AllocThroughDrawMeshDelegate
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RMeshBuilder.RAllocMeshData.RAllocator r_Fm_AllocThroughDrawMeshDelegate;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RMeshBuilder.RAllocMeshData.RAllocator RFm_AllocThroughDrawMeshDelegate
		{
			get
			{
				if(r_Fm_AllocThroughDrawMeshDelegate == null)
				{
					r_Fm_AllocThroughDrawMeshDelegate = new(this, "m_AllocThroughDrawMeshDelegate");
					r_Fm_AllocThroughDrawMeshDelegate.SetBelong(this.GetValue());
				}
				return r_Fm_AllocThroughDrawMeshDelegate;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshGenerationContext <meshGenerationContext>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext r_F__0__meshGenerationContext__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext RF__0__meshGenerationContext__1__k__BackingField
		{
			get
			{
				if(r_F__0__meshGenerationContext__1__k__BackingField == null)
				{
					r_F__0__meshGenerationContext__1__k__BackingField = new(this, "<meshGenerationContext>k__BackingField");
					r_F__0__meshGenerationContext__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__meshGenerationContext__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement <currentElement>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_F__0__currentElement__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RF__0__currentElement__1__k__BackingField
		{
			get
			{
				if(r_F__0__currentElement__1__k__BackingField == null)
				{
					r_F__0__currentElement__1__k__BackingField = new(this, "<currentElement>k__BackingField");
					r_F__0__currentElement__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__currentElement__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <totalVertices>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__totalVertices__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__totalVertices__1__k__BackingField
		{
			get
			{
				if(r_F__0__totalVertices__1__k__BackingField == null)
				{
					r_F__0__totalVertices__1__k__BackingField = new(this, "<totalVertices>k__BackingField");
					r_F__0__totalVertices__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__totalVertices__1__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <totalIndices>k__BackingField
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_F__0__totalIndices__1__k__BackingField;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RF__0__totalIndices__1__k__BackingField
		{
			get
			{
				if(r_F__0__totalIndices__1__k__BackingField == null)
				{
					r_F__0__totalIndices__1__k__BackingField = new(this, "<totalIndices>k__BackingField");
					r_F__0__totalIndices__1__k__BackingField.SetBelong(this.GetValue());
				}
				return r_F__0__totalIndices__1__k__BackingField;
			}
		}

		/// <summary>
		/// UnityEngine.TextCore.Text.TextInfo m_TextInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo r_Fm_TextInfo;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo RFm_TextInfo
		{
			get
			{
				if(r_Fm_TextInfo == null)
				{
					r_Fm_TextInfo = new(this, "m_TextInfo");
					r_Fm_TextInfo.SetBelong(this.GetValue());
				}
				return r_Fm_TextInfo;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshGenerationContext meshGenerationContext
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext r_PmeshGenerationContext;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext RPmeshGenerationContext
		{
			get
			{
				if(r_PmeshGenerationContext == null)
				{
					r_PmeshGenerationContext = new(this, "meshGenerationContext", -1);
					r_PmeshGenerationContext.SetBelong(this.GetValue());
				}
				return r_PmeshGenerationContext;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.VisualElement currentElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_PcurrentElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RPcurrentElement
		{
			get
			{
				if(r_PcurrentElement == null)
				{
					r_PcurrentElement = new(this, "currentElement", -1);
					r_PcurrentElement.SetBelong(this.GetValue());
				}
				return r_PcurrentElement;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.UIElements.UIR.Implementation.UIRStylePainter+Entry] entries
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.REntry> r_Pentries;
		public virtual Hvak.Editor.Refleaction.RSystem.RCollections.RGeneric.RList<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.REntry> RPentries
		{
			get
			{
				if(r_Pentries == null)
				{
					r_Pentries = new(this, "entries", -1);
					r_Pentries.SetBelong(this.GetValue());
				}
				return r_Pentries;
			}
		}

		/// <summary>
		/// ClosingInfo closingInfo
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.RClosingInfo r_PclosingInfo;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation.RUIRStylePainter.RClosingInfo RPclosingInfo
		{
			get
			{
				if(r_PclosingInfo == null)
				{
					r_PclosingInfo = new(this, "closingInfo", -1);
					r_PclosingInfo.SetBelong(this.GetValue());
				}
				return r_PclosingInfo;
			}
		}

		/// <summary>
		/// Int32 totalVertices
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PtotalVertices;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPtotalVertices
		{
			get
			{
				if(r_PtotalVertices == null)
				{
					r_PtotalVertices = new(this, "totalVertices", -1);
					r_PtotalVertices.SetBelong(this.GetValue());
				}
				return r_PtotalVertices;
			}
		}

		/// <summary>
		/// Int32 totalIndices
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_PtotalIndices;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RPtotalIndices
		{
			get
			{
				if(r_PtotalIndices == null)
				{
					r_PtotalIndices = new(this, "totalIndices", -1);
					r_PtotalIndices.SetBelong(this.GetValue());
				}
				return r_PtotalIndices;
			}
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
					r_PvisualElement.SetBelong(this.GetValue());
				}
				return r_PvisualElement;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshWriteData GetPooledMeshWriteData()
		/// </summary>
		protected RMethod r_MGetPooledMeshWriteData;
		public virtual RMethod RMGetPooledMeshWriteData
		{
			get
			{
				if(r_MGetPooledMeshWriteData == null)
				{
					r_MGetPooledMeshWriteData = new(this, "GetPooledMeshWriteData", 0);
					r_MGetPooledMeshWriteData.SetBelong(this.GetValue());
				}
				return r_MGetPooledMeshWriteData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshWriteData AllocRawVertsIndices(UInt32, UInt32, AllocMeshData ByRef)
		/// </summary>
		protected RMethod r_MAllocRawVertsIndices_UInt32_UInt32_Ref_AllocMeshData;
		public virtual RMethod RMAllocRawVertsIndices_UInt32_UInt32_Ref_AllocMeshData
		{
			get
			{
				if(r_MAllocRawVertsIndices_UInt32_UInt32_Ref_AllocMeshData == null)
				{
					r_MAllocRawVertsIndices_UInt32_UInt32_Ref_AllocMeshData = new(this, "AllocRawVertsIndices", 0, typeof(System.UInt32), typeof(System.UInt32),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.MeshBuilder+AllocMeshData").MakeByRefType());
					r_MAllocRawVertsIndices_UInt32_UInt32_Ref_AllocMeshData.SetBelong(this.GetValue());
				}
				return r_MAllocRawVertsIndices_UInt32_UInt32_Ref_AllocMeshData;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshWriteData AllocThroughDrawMesh(UInt32, UInt32, AllocMeshData ByRef)
		/// </summary>
		protected RMethod r_MAllocThroughDrawMesh_UInt32_UInt32_Ref_AllocMeshData;
		public virtual RMethod RMAllocThroughDrawMesh_UInt32_UInt32_Ref_AllocMeshData
		{
			get
			{
				if(r_MAllocThroughDrawMesh_UInt32_UInt32_Ref_AllocMeshData == null)
				{
					r_MAllocThroughDrawMesh_UInt32_UInt32_Ref_AllocMeshData = new(this, "AllocThroughDrawMesh", 0, typeof(System.UInt32), typeof(System.UInt32),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.MeshBuilder+AllocMeshData").MakeByRefType());
					r_MAllocThroughDrawMesh_UInt32_UInt32_Ref_AllocMeshData.SetBelong(this.GetValue());
				}
				return r_MAllocThroughDrawMesh_UInt32_UInt32_Ref_AllocMeshData;
			}
		}

		/// <summary>
		/// Void Begin(UnityEngine.UIElements.VisualElement)
		/// </summary>
		protected RMethod r_MBegin_VisualElement;
		public virtual RMethod RMBegin_VisualElement
		{
			get
			{
				if(r_MBegin_VisualElement == null)
				{
					r_MBegin_VisualElement = new(this, "Begin", 0, typeof(UnityEngine.UIElements.VisualElement));
					r_MBegin_VisualElement.SetBelong(this.GetValue());
				}
				return r_MBegin_VisualElement;
			}
		}

		/// <summary>
		/// Void LandClipUnregisterMeshDrawCommand(UnityEngine.UIElements.UIR.RenderChainCommand)
		/// </summary>
		protected RMethod r_MLandClipUnregisterMeshDrawCommand_RenderChainCommand;
		public virtual RMethod RMLandClipUnregisterMeshDrawCommand_RenderChainCommand
		{
			get
			{
				if(r_MLandClipUnregisterMeshDrawCommand_RenderChainCommand == null)
				{
					r_MLandClipUnregisterMeshDrawCommand_RenderChainCommand = new(this, "LandClipUnregisterMeshDrawCommand", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.RenderChainCommand"));
					r_MLandClipUnregisterMeshDrawCommand_RenderChainCommand.SetBelong(this.GetValue());
				}
				return r_MLandClipUnregisterMeshDrawCommand_RenderChainCommand;
			}
		}

		/// <summary>
		/// Void LandClipRegisterMesh(Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex], Unity.Collections.NativeSlice`1[System.UInt16], Int32)
		/// </summary>
		protected RMethod r_MLandClipRegisterMesh_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Int32;
		public virtual RMethod RMLandClipRegisterMesh_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Int32
		{
			get
			{
				if(r_MLandClipRegisterMesh_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Int32 == null)
				{
					r_MLandClipRegisterMesh_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Int32 = new(this, "LandClipRegisterMesh", 0, typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(UnityEngine.UIElements.Vertex)), typeof(Unity.Collections.NativeSlice<>).MakeGenericType(typeof(System.UInt16)), typeof(System.Int32));
					r_MLandClipRegisterMesh_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Int32.SetBelong(this.GetValue());
				}
				return r_MLandClipRegisterMesh_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Int32;
			}
		}

		/// <summary>
		/// UnityEngine.UIElements.MeshWriteData AddGradientsEntry(Int32, Int32, UnityEngine.UIElements.TextureId, UnityEngine.Material, MeshFlags)
		/// </summary>
		protected RMethod r_MAddGradientsEntry_Int32_Int32_TextureId_Material_MeshFlags;
		public virtual RMethod RMAddGradientsEntry_Int32_Int32_TextureId_Material_MeshFlags
		{
			get
			{
				if(r_MAddGradientsEntry_Int32_Int32_TextureId_Material_MeshFlags == null)
				{
					r_MAddGradientsEntry_Int32_Int32_TextureId_Material_MeshFlags = new(this, "AddGradientsEntry", 0, typeof(System.Int32), typeof(System.Int32),  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"), typeof(UnityEngine.Material),  ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContext+MeshFlags"));
					r_MAddGradientsEntry_Int32_Int32_TextureId_Material_MeshFlags.SetBelong(this.GetValue());
				}
				return r_MAddGradientsEntry_Int32_Int32_TextureId_Material_MeshFlags;
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
					r_MDrawMesh_Int32_Int32_Texture_Material_MeshFlags.SetBelong(this.GetValue());
				}
				return r_MDrawMesh_Int32_Int32_Texture_Material_MeshFlags;
			}
		}

		/// <summary>
		/// Void TryAtlasTexture(UnityEngine.Texture, MeshFlags, UnityEngine.Rect ByRef, Boolean ByRef, UnityEngine.UIElements.TextureId ByRef, UnityEngine.UIElements.UIR.VertexFlags ByRef)
		/// </summary>
		protected RMethod r_MTryAtlasTexture_Texture_MeshFlags_Out_Rect_Out_Boolean_Out_TextureId_Out_VertexFlags;
		public virtual RMethod RMTryAtlasTexture_Texture_MeshFlags_Out_Rect_Out_Boolean_Out_TextureId_Out_VertexFlags
		{
			get
			{
				if(r_MTryAtlasTexture_Texture_MeshFlags_Out_Rect_Out_Boolean_Out_TextureId_Out_VertexFlags == null)
				{
					r_MTryAtlasTexture_Texture_MeshFlags_Out_Rect_Out_Boolean_Out_TextureId_Out_VertexFlags = new(this, "TryAtlasTexture", 0, typeof(UnityEngine.Texture),  ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContext+MeshFlags"), typeof(UnityEngine.Rect).MakeByRefType(), typeof(System.Boolean).MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId").MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.VertexFlags").MakeByRefType());
					r_MTryAtlasTexture_Texture_MeshFlags_Out_Rect_Out_Boolean_Out_TextureId_Out_VertexFlags.SetBelong(this.GetValue());
				}
				return r_MTryAtlasTexture_Texture_MeshFlags_Out_Rect_Out_Boolean_Out_TextureId_Out_VertexFlags;
			}
		}

		/// <summary>
		/// Void BuildEntryFromNativeMesh(UnityEngine.UIElements.MeshWriteDataInterface, UnityEngine.Texture, UnityEngine.UIElements.TextureId, Boolean, UnityEngine.Material, MeshFlags, UnityEngine.Rect, UnityEngine.UIElements.UIR.VertexFlags)
		/// </summary>
		protected RMethod r_MBuildEntryFromNativeMesh_MeshWriteDataInterface_Texture_TextureId_Boolean_Material_MeshFlags_Rect_VertexFlags;
		public virtual RMethod RMBuildEntryFromNativeMesh_MeshWriteDataInterface_Texture_TextureId_Boolean_Material_MeshFlags_Rect_VertexFlags
		{
			get
			{
				if(r_MBuildEntryFromNativeMesh_MeshWriteDataInterface_Texture_TextureId_Boolean_Material_MeshFlags_Rect_VertexFlags == null)
				{
					r_MBuildEntryFromNativeMesh_MeshWriteDataInterface_Texture_TextureId_Boolean_Material_MeshFlags_Rect_VertexFlags = new(this, "BuildEntryFromNativeMesh", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.MeshWriteDataInterface"), typeof(UnityEngine.Texture),  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"), typeof(System.Boolean), typeof(UnityEngine.Material),  ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContext+MeshFlags"), typeof(UnityEngine.Rect),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.VertexFlags"));
					r_MBuildEntryFromNativeMesh_MeshWriteDataInterface_Texture_TextureId_Boolean_Material_MeshFlags_Rect_VertexFlags.SetBelong(this.GetValue());
				}
				return r_MBuildEntryFromNativeMesh_MeshWriteDataInterface_Texture_TextureId_Boolean_Material_MeshFlags_Rect_VertexFlags;
			}
		}

		/// <summary>
		/// Void BuildGradientEntryFromNativeMesh(UnityEngine.UIElements.MeshWriteDataInterface, UnityEngine.UIElements.TextureId)
		/// </summary>
		protected RMethod r_MBuildGradientEntryFromNativeMesh_MeshWriteDataInterface_TextureId;
		public virtual RMethod RMBuildGradientEntryFromNativeMesh_MeshWriteDataInterface_TextureId
		{
			get
			{
				if(r_MBuildGradientEntryFromNativeMesh_MeshWriteDataInterface_TextureId == null)
				{
					r_MBuildGradientEntryFromNativeMesh_MeshWriteDataInterface_TextureId = new(this, "BuildGradientEntryFromNativeMesh", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.MeshWriteDataInterface"),  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"));
					r_MBuildGradientEntryFromNativeMesh_MeshWriteDataInterface_TextureId.SetBelong(this.GetValue());
				}
				return r_MBuildGradientEntryFromNativeMesh_MeshWriteDataInterface_TextureId;
			}
		}

		/// <summary>
		/// Void BuildRawEntryFromNativeMesh(UnityEngine.UIElements.MeshWriteDataInterface)
		/// </summary>
		protected RMethod r_MBuildRawEntryFromNativeMesh_MeshWriteDataInterface;
		public virtual RMethod RMBuildRawEntryFromNativeMesh_MeshWriteDataInterface
		{
			get
			{
				if(r_MBuildRawEntryFromNativeMesh_MeshWriteDataInterface == null)
				{
					r_MBuildRawEntryFromNativeMesh_MeshWriteDataInterface = new(this, "BuildRawEntryFromNativeMesh", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.MeshWriteDataInterface"));
					r_MBuildRawEntryFromNativeMesh_MeshWriteDataInterface.SetBelong(this.GetValue());
				}
				return r_MBuildRawEntryFromNativeMesh_MeshWriteDataInterface;
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
					r_MDrawText_TextElement.SetBelong(this.GetValue());
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
					r_MDrawText_String_Vector2_Single_Color_FontAsset.SetBelong(this.GetValue());
				}
				return r_MDrawText_String_Vector2_Single_Color_FontAsset;
			}
		}

		/// <summary>
		/// Void DrawTextInfo(UnityEngine.TextCore.Text.TextInfo, UnityEngine.Vector2, Boolean)
		/// </summary>
		protected RMethod r_MDrawTextInfo_TextInfo_Vector2_Boolean;
		public virtual RMethod RMDrawTextInfo_TextInfo_Vector2_Boolean
		{
			get
			{
				if(r_MDrawTextInfo_TextInfo_Vector2_Boolean == null)
				{
					r_MDrawTextInfo_TextInfo_Vector2_Boolean = new(this, "DrawTextInfo", 0,  ReflectionUtils.GetType("UnityEngine.TextCore.Text.TextInfo"), typeof(UnityEngine.Vector2), typeof(System.Boolean));
					r_MDrawTextInfo_TextInfo_Vector2_Boolean.SetBelong(this.GetValue());
				}
				return r_MDrawTextInfo_TextInfo_Vector2_Boolean;
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
					r_MDrawRectangle_RectangleParams.SetBelong(this.GetValue());
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
					r_MDrawBorder_BorderParams.SetBelong(this.GetValue());
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
					r_MDrawImmediate_Action_Boolean.SetBelong(this.GetValue());
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
					r_MDrawVectorImage_VectorImage_Vector2_Angle_Vector2.SetBelong(this.GetValue());
				}
				return r_MDrawVectorImage_VectorImage_Vector2_Angle_Vector2;
			}
		}

		/// <summary>
		/// Void DrawVisualElementBackground()
		/// </summary>
		protected RMethod r_MDrawVisualElementBackground;
		public virtual RMethod RMDrawVisualElementBackground
		{
			get
			{
				if(r_MDrawVisualElementBackground == null)
				{
					r_MDrawVisualElementBackground = new(this, "DrawVisualElementBackground", 0);
					r_MDrawVisualElementBackground.SetBelong(this.GetValue());
				}
				return r_MDrawVisualElementBackground;
			}
		}

		/// <summary>
		/// Void DrawRectangleRepeat(RectangleParams, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MDrawRectangleRepeat_RectangleParams_Rect;
		public virtual RMethod RMDrawRectangleRepeat_RectangleParams_Rect
		{
			get
			{
				if(r_MDrawRectangleRepeat_RectangleParams_Rect == null)
				{
					r_MDrawRectangleRepeat_RectangleParams_Rect = new(this, "DrawRectangleRepeat", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), typeof(UnityEngine.Rect));
					r_MDrawRectangleRepeat_RectangleParams_Rect.SetBelong(this.GetValue());
				}
				return r_MDrawRectangleRepeat_RectangleParams_Rect;
			}
		}

		/// <summary>
		/// Void StampRectangleWithSubRect(RectangleParams, UnityEngine.Rect, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_MStampRectangleWithSubRect_RectangleParams_Rect_Rect;
		public virtual RMethod RMStampRectangleWithSubRect_RectangleParams_Rect_Rect
		{
			get
			{
				if(r_MStampRectangleWithSubRect_RectangleParams_Rect_Rect == null)
				{
					r_MStampRectangleWithSubRect_RectangleParams_Rect_Rect = new(this, "StampRectangleWithSubRect", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), typeof(UnityEngine.Rect), typeof(UnityEngine.Rect));
					r_MStampRectangleWithSubRect_RectangleParams_Rect_Rect.SetBelong(this.GetValue());
				}
				return r_MStampRectangleWithSubRect_RectangleParams_Rect_Rect;
			}
		}

		/// <summary>
		/// Void DrawVisualElementBorder()
		/// </summary>
		protected RMethod r_MDrawVisualElementBorder;
		public virtual RMethod RMDrawVisualElementBorder
		{
			get
			{
				if(r_MDrawVisualElementBorder == null)
				{
					r_MDrawVisualElementBorder = new(this, "DrawVisualElementBorder", 0);
					r_MDrawVisualElementBorder.SetBelong(this.GetValue());
				}
				return r_MDrawVisualElementBorder;
			}
		}

		/// <summary>
		/// Void ApplyVisualElementClipping()
		/// </summary>
		protected RMethod r_MApplyVisualElementClipping;
		public virtual RMethod RMApplyVisualElementClipping
		{
			get
			{
				if(r_MApplyVisualElementClipping == null)
				{
					r_MApplyVisualElementClipping = new(this, "ApplyVisualElementClipping", 0);
					r_MApplyVisualElementClipping.SetBelong(this.GetValue());
				}
				return r_MApplyVisualElementClipping;
			}
		}

		/// <summary>
		/// UInt16[] AdjustSpriteWinding(UnityEngine.Vector2[], UInt16[])
		/// </summary>
		protected RMethod r_MAdjustSpriteWinding_Vector2Array_UInt16Array;
		public virtual RMethod RMAdjustSpriteWinding_Vector2Array_UInt16Array
		{
			get
			{
				if(r_MAdjustSpriteWinding_Vector2Array_UInt16Array == null)
				{
					r_MAdjustSpriteWinding_Vector2Array_UInt16Array = new(this, "AdjustSpriteWinding", 0, typeof(UnityEngine.Vector2).MakeArrayType(), typeof(System.UInt16).MakeArrayType());
					r_MAdjustSpriteWinding_Vector2Array_UInt16Array.SetBelong(this.GetValue());
				}
				return r_MAdjustSpriteWinding_Vector2Array_UInt16Array;
			}
		}

		/// <summary>
		/// Void DrawSprite(RectangleParams)
		/// </summary>
		protected RMethod r_MDrawSprite_RectangleParams;
		public virtual RMethod RMDrawSprite_RectangleParams
		{
			get
			{
				if(r_MDrawSprite_RectangleParams == null)
				{
					r_MDrawSprite_RectangleParams = new(this, "DrawSprite", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"));
					r_MDrawSprite_RectangleParams.SetBelong(this.GetValue());
				}
				return r_MDrawSprite_RectangleParams;
			}
		}

		/// <summary>
		/// Void RegisterVectorImageGradient(UnityEngine.UIElements.VectorImage, Int32 ByRef, UnityEngine.UIElements.TextureId ByRef)
		/// </summary>
		protected RMethod r_MRegisterVectorImageGradient_VectorImage_Out_Int32_Out_TextureId;
		public virtual RMethod RMRegisterVectorImageGradient_VectorImage_Out_Int32_Out_TextureId
		{
			get
			{
				if(r_MRegisterVectorImageGradient_VectorImage_Out_Int32_Out_TextureId == null)
				{
					r_MRegisterVectorImageGradient_VectorImage_Out_Int32_Out_TextureId = new(this, "RegisterVectorImageGradient", 0, typeof(UnityEngine.UIElements.VectorImage), typeof(System.Int32).MakeByRefType(),  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId").MakeByRefType());
					r_MRegisterVectorImageGradient_VectorImage_Out_Int32_Out_TextureId.SetBelong(this.GetValue());
				}
				return r_MRegisterVectorImageGradient_VectorImage_Out_Int32_Out_TextureId;
			}
		}

		/// <summary>
		/// Void DrawVectorImage(RectangleParams)
		/// </summary>
		protected RMethod r_MDrawVectorImage_RectangleParams;
		public virtual RMethod RMDrawVectorImage_RectangleParams
		{
			get
			{
				if(r_MDrawVectorImage_RectangleParams == null)
				{
					r_MDrawVectorImage_RectangleParams = new(this, "DrawVectorImage", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"));
					r_MDrawVectorImage_RectangleParams.SetBelong(this.GetValue());
				}
				return r_MDrawVectorImage_RectangleParams;
			}
		}

		/// <summary>
		/// Void MakeVectorGraphics(RectangleParams, Boolean, UnityEngine.UIElements.TextureId, Int32, Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_MMakeVectorGraphics_RectangleParams_Boolean_TextureId_Int32_Out_Int32_Out_Int32;
		public virtual RMethod RMMakeVectorGraphics_RectangleParams_Boolean_TextureId_Int32_Out_Int32_Out_Int32
		{
			get
			{
				if(r_MMakeVectorGraphics_RectangleParams_Boolean_TextureId_Int32_Out_Int32_Out_Int32 == null)
				{
					r_MMakeVectorGraphics_RectangleParams_Boolean_TextureId_Int32_Out_Int32_Out_Int32 = new(this, "MakeVectorGraphics", 0,  ReflectionUtils.GetType("UnityEngine.UIElements.MeshGenerationContextUtils+RectangleParams"), typeof(System.Boolean),  ReflectionUtils.GetType("UnityEngine.UIElements.TextureId"), typeof(System.Int32), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_MMakeVectorGraphics_RectangleParams_Boolean_TextureId_Int32_Out_Int32_Out_Int32.SetBelong(this.GetValue());
				}
				return r_MMakeVectorGraphics_RectangleParams_Boolean_TextureId_Int32_Out_Int32_Out_Int32;
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
					r_MReset.SetBelong(this.GetValue());
				}
				return r_MReset;
			}
		}

		/// <summary>
		/// Void ValidateMeshWriteData()
		/// </summary>
		protected RMethod r_MValidateMeshWriteData;
		public virtual RMethod RMValidateMeshWriteData
		{
			get
			{
				if(r_MValidateMeshWriteData == null)
				{
					r_MValidateMeshWriteData = new(this, "ValidateMeshWriteData", 0);
					r_MValidateMeshWriteData.SetBelong(this.GetValue());
				}
				return r_MValidateMeshWriteData;
			}
		}

		/// <summary>
		/// Void GenerateStencilClipEntryForRoundedRectBackground()
		/// </summary>
		protected RMethod r_MGenerateStencilClipEntryForRoundedRectBackground;
		public virtual RMethod RMGenerateStencilClipEntryForRoundedRectBackground
		{
			get
			{
				if(r_MGenerateStencilClipEntryForRoundedRectBackground == null)
				{
					r_MGenerateStencilClipEntryForRoundedRectBackground = new(this, "GenerateStencilClipEntryForRoundedRectBackground", 0);
					r_MGenerateStencilClipEntryForRoundedRectBackground.SetBelong(this.GetValue());
				}
				return r_MGenerateStencilClipEntryForRoundedRectBackground;
			}
		}

		/// <summary>
		/// Void GenerateStencilClipEntryForSVGBackground()
		/// </summary>
		protected RMethod r_MGenerateStencilClipEntryForSVGBackground;
		public virtual RMethod RMGenerateStencilClipEntryForSVGBackground
		{
			get
			{
				if(r_MGenerateStencilClipEntryForSVGBackground == null)
				{
					r_MGenerateStencilClipEntryForSVGBackground = new(this, "GenerateStencilClipEntryForSVGBackground", 0);
					r_MGenerateStencilClipEntryForSVGBackground.SetBelong(this.GetValue());
				}
				return r_MGenerateStencilClipEntryForSVGBackground;
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
					r_MEquals_Object.SetBelong(this.GetValue());
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
					r_MFinalize.SetBelong(this.GetValue());
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
					r_MGetHashCode.SetBelong(this.GetValue());
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
					r_MGetType.SetBelong(this.GetValue());
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
					r_MMemberwiseClone.SetBelong(this.GetValue());
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
					r_MToString.SetBelong(this.GetValue());
				}
				return r_MToString;
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
            var ___result = RMGetPooledMeshWriteData.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.MeshWriteData)___result;
        }


        public virtual UnityEngine.UIElements.MeshWriteData AllocRawVertsIndices(System.UInt32 @vertexCount, System.UInt32 @indexCount, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RMeshBuilder.RAllocMeshData @allocatorData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @indexCount, @allocatorData.Value};
            var ___result = RMAllocRawVertsIndices_UInt32_UInt32_Ref_AllocMeshData.Invoke(___genericsType, ___parameters);
			@allocatorData = new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RMeshBuilder.RAllocMeshData(___parameters[2]);

            return (UnityEngine.UIElements.MeshWriteData)___result;
        }


        public virtual UnityEngine.UIElements.MeshWriteData AllocThroughDrawMesh(System.UInt32 @vertexCount, System.UInt32 @indexCount, ref Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RMeshBuilder.RAllocMeshData @allocatorData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @indexCount, @allocatorData.Value};
            var ___result = RMAllocThroughDrawMesh_UInt32_UInt32_Ref_AllocMeshData.Invoke(___genericsType, ___parameters);
			@allocatorData = new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RMeshBuilder.RAllocMeshData(___parameters[2]);

            return (UnityEngine.UIElements.MeshWriteData)___result;
        }


        public virtual void Begin(UnityEngine.UIElements.VisualElement @ve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ve};
            var ___result = RMBegin_VisualElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LandClipUnregisterMeshDrawCommand(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RRenderChainCommand @cmd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cmd.Value};
            var ___result = RMLandClipUnregisterMeshDrawCommand_RenderChainCommand.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LandClipRegisterMesh(Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> @vertices, Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RSystem.RUInt16> @indices, System.Int32 @indexOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertices.Value, @indices.Value, @indexOffset};
            var ___result = RMLandClipRegisterMesh_NativeSlice_d_Vertex_p__NativeSlice_d_UInt16_p__Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.UIElements.MeshWriteData AddGradientsEntry(System.Int32 @vertexCount, System.Int32 @indexCount, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @texture, UnityEngine.Material @material, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext.RMeshFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @indexCount, @texture.Value, @material, @flags.Value};
            var ___result = RMAddGradientsEntry_Int32_Int32_TextureId_Material_MeshFlags.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.MeshWriteData)___result;
        }


        public virtual UnityEngine.UIElements.MeshWriteData DrawMesh(System.Int32 @vertexCount, System.Int32 @indexCount, UnityEngine.Texture @texture, UnityEngine.Material @material, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext.RMeshFlags @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexCount, @indexCount, @texture, @material, @flags.Value};
            var ___result = RMDrawMesh_Int32_Int32_Texture_Material_MeshFlags.Invoke(___genericsType, ___parameters);

            return (UnityEngine.UIElements.MeshWriteData)___result;
        }


        public virtual void TryAtlasTexture(UnityEngine.Texture @texture, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext.RMeshFlags @flags, out UnityEngine.Rect @outUVRegion, out System.Boolean @outIsAtlas, out Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @outTextureId, out Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVertexFlags @outAddFlags)
        {
			@outUVRegion = default;
			@outIsAtlas = default;
			@outTextureId = default;
			@outAddFlags = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @flags.Value, @outUVRegion, @outIsAtlas, @outTextureId.Value, @outAddFlags.Value};
            var ___result = RMTryAtlasTexture_Texture_MeshFlags_Out_Rect_Out_Boolean_Out_TextureId_Out_VertexFlags.Invoke(___genericsType, ___parameters);
			@outUVRegion = (UnityEngine.Rect)___parameters[2];
			@outIsAtlas = (System.Boolean)___parameters[3];
			@outTextureId = new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId(___parameters[4]);
			@outAddFlags = new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVertexFlags(___parameters[5]);

            
        }


        public virtual void BuildEntryFromNativeMesh(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshWriteDataInterface @meshData, UnityEngine.Texture @texture, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @textureId, System.Boolean @isAtlas, UnityEngine.Material @material, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContext.RMeshFlags @flags, UnityEngine.Rect @uvRegion, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RVertexFlags @addFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@meshData.Value, @texture, @textureId.Value, @isAtlas, @material, @flags.Value, @uvRegion, @addFlags.Value};
            var ___result = RMBuildEntryFromNativeMesh_MeshWriteDataInterface_Texture_TextureId_Boolean_Material_MeshFlags_Rect_VertexFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BuildGradientEntryFromNativeMesh(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshWriteDataInterface @meshData, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @svgTextureId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@meshData.Value, @svgTextureId.Value};
            var ___result = RMBuildGradientEntryFromNativeMesh_MeshWriteDataInterface_TextureId.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BuildRawEntryFromNativeMesh(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshWriteDataInterface @meshData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@meshData.Value};
            var ___result = RMBuildRawEntryFromNativeMesh_MeshWriteDataInterface.Invoke(___genericsType, ___parameters);

            
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


        public virtual void DrawTextInfo(Hvak.Editor.Refleaction.RUnityEngine.RTextCore.RText.RTextInfo @textInfo, UnityEngine.Vector2 @offset, System.Boolean @useHints)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textInfo.Value, @offset, @useHints};
            var ___result = RMDrawTextInfo_TextInfo_Vector2_Boolean.Invoke(___genericsType, ___parameters);

            
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


        public virtual void DrawVectorImage(UnityEngine.UIElements.VectorImage @vectorImage, UnityEngine.Vector2 @offset, UnityEngine.UIElements.Angle @rotationAngle, UnityEngine.Vector2 @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vectorImage, @offset, @rotationAngle, @scale};
            var ___result = RMDrawVectorImage_VectorImage_Vector2_Angle_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawVisualElementBackground()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDrawVisualElementBackground.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawRectangleRepeat(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContextUtils.RRectangleParams @rectParams, UnityEngine.Rect @totalRect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rectParams.Value, @totalRect};
            var ___result = RMDrawRectangleRepeat_RectangleParams_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StampRectangleWithSubRect(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContextUtils.RRectangleParams @rectParams, UnityEngine.Rect @targetRect, UnityEngine.Rect @targetUV)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rectParams.Value, @targetRect, @targetUV};
            var ___result = RMStampRectangleWithSubRect_RectangleParams_Rect_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawVisualElementBorder()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMDrawVisualElementBorder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyVisualElementClipping()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMApplyVisualElementClipping.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.UInt16[] AdjustSpriteWinding(UnityEngine.Vector2[] @vertices, System.UInt16[] @indices)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertices, @indices};
            var ___result = RMAdjustSpriteWinding_Vector2Array_UInt16Array.Invoke(___genericsType, ___parameters);

            return (System.UInt16[])___result;
        }


        public virtual void DrawSprite(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContextUtils.RRectangleParams @rectParams)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rectParams.Value};
            var ___result = RMDrawSprite_RectangleParams.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RegisterVectorImageGradient(UnityEngine.UIElements.VectorImage @vi, out System.Int32 @settingIndexOffset, out Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @texture)
        {
			@settingIndexOffset = default;
			@texture = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vi, @settingIndexOffset, @texture.Value};
            var ___result = RMRegisterVectorImageGradient_VectorImage_Out_Int32_Out_TextureId.Invoke(___genericsType, ___parameters);
			@settingIndexOffset = (System.Int32)___parameters[1];
			@texture = new Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId(___parameters[2]);

            
        }


        public virtual void DrawVectorImage(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContextUtils.RRectangleParams @rectParams)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rectParams.Value};
            var ___result = RMDrawVectorImage_RectangleParams.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MakeVectorGraphics(Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RMeshGenerationContextUtils.RRectangleParams @rectParams, System.Boolean @isUsingGradients, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RTextureId @svgTexture, System.Int32 @settingIndexOffset, out System.Int32 @finalVertexCount, out System.Int32 @finalIndexCount)
        {
			@finalVertexCount = default;
			@finalIndexCount = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rectParams.Value, @isUsingGradients, @svgTexture.Value, @settingIndexOffset, @finalVertexCount, @finalIndexCount};
            var ___result = RMMakeVectorGraphics_RectangleParams_Boolean_TextureId_Int32_Out_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			@finalVertexCount = (System.Int32)___parameters[4];
			@finalIndexCount = (System.Int32)___parameters[5];

            
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ValidateMeshWriteData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMValidateMeshWriteData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GenerateStencilClipEntryForRoundedRectBackground()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGenerateStencilClipEntryForRoundedRectBackground.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GenerateStencilClipEntryForSVGBackground()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMGenerateStencilClipEntryForSVGBackground.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RMEquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
