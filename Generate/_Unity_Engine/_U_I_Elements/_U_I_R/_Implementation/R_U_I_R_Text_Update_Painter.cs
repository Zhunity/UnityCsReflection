
using Hvak.Editor.Refleaction;
using System;
using System.Reflection;

namespace Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RImplementation
{
	/// <summary>
    /// https://github.com/Zhunity/CsReflectionFramework/tree/main
	/// UnityEngine.UIElements.UIR.Implementation.UIRTextUpdatePainter
	/// </summary>
    public partial class RUIRTextUpdatePainter : RMember //
    {
        public static Type Type
        {
            get
            {
                return  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.Implementation.UIRTextUpdatePainter");
            }
        }

        public RUIRTextUpdatePainter() : base("UnityEngine.UIElements.UIR.Implementation.UIRTextUpdatePainter")
        {
        }

        public RUIRTextUpdatePainter(System.Object instance) : base("UnityEngine.UIElements.UIR.Implementation.UIRTextUpdatePainter")
		{
            SetInstance(instance);
		}

        public RUIRTextUpdatePainter(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUIRTextUpdatePainter(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


		/// <summary>
		/// UnityEngine.UIElements.VisualElement m_CurrentElement
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement r_Fm_CurrentElement;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVisualElement RFm_CurrentElement
		{
			get
			{
				if(r_Fm_CurrentElement == null)
				{
					r_Fm_CurrentElement = new(this, "m_CurrentElement");
				}
				return r_Fm_CurrentElement;
			}
		}

		/// <summary>
		/// System.Int32 m_TextEntryIndex
		/// </summary>
		protected Hvak.Editor.Refleaction.RSystem.RInt32 r_Fm_TextEntryIndex;
		public virtual Hvak.Editor.Refleaction.RSystem.RInt32 RFm_TextEntryIndex
		{
			get
			{
				if(r_Fm_TextEntryIndex == null)
				{
					r_Fm_TextEntryIndex = new(this, "m_TextEntryIndex");
				}
				return r_Fm_TextEntryIndex;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[UnityEngine.UIElements.Vertex] m_DudVerts
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> r_Fm_DudVerts;
		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> RFm_DudVerts
		{
			get
			{
				if(r_Fm_DudVerts == null)
				{
					r_Fm_DudVerts = new(this, "m_DudVerts");
				}
				return r_Fm_DudVerts;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeArray`1[System.UInt16] m_DudIndices
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RSystem.RUInt16> r_Fm_DudIndices;
		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeArray<Hvak.Editor.Refleaction.RSystem.RUInt16> RFm_DudIndices
		{
			get
			{
				if(r_Fm_DudIndices == null)
				{
					r_Fm_DudIndices = new(this, "m_DudIndices");
				}
				return r_Fm_DudIndices;
			}
		}

		/// <summary>
		/// Unity.Collections.NativeSlice`1[UnityEngine.UIElements.Vertex] m_MeshDataVerts
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> r_Fm_MeshDataVerts;
		public virtual Hvak.Editor.Refleaction.RUnity.RCollections.RNativeSlice<Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RVertex> RFm_MeshDataVerts
		{
			get
			{
				if(r_Fm_MeshDataVerts == null)
				{
					r_Fm_MeshDataVerts = new(this, "m_MeshDataVerts");
				}
				return r_Fm_MeshDataVerts;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 m_XFormClipPages
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor32 r_Fm_XFormClipPages;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor32 RFm_XFormClipPages
		{
			get
			{
				if(r_Fm_XFormClipPages == null)
				{
					r_Fm_XFormClipPages = new(this, "m_XFormClipPages");
				}
				return r_Fm_XFormClipPages;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 m_IDs
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor32 r_Fm_IDs;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor32 RFm_IDs
		{
			get
			{
				if(r_Fm_IDs == null)
				{
					r_Fm_IDs = new(this, "m_IDs");
				}
				return r_Fm_IDs;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 m_Flags
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor32 r_Fm_Flags;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor32 RFm_Flags
		{
			get
			{
				if(r_Fm_Flags == null)
				{
					r_Fm_Flags = new(this, "m_Flags");
				}
				return r_Fm_Flags;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 m_OpacityColorPages
		/// </summary>
		protected Hvak.Editor.Refleaction.RUnityEngine.RColor32 r_Fm_OpacityColorPages;
		public virtual Hvak.Editor.Refleaction.RUnityEngine.RColor32 RFm_OpacityColorPages
		{
			get
			{
				if(r_Fm_OpacityColorPages == null)
				{
					r_Fm_OpacityColorPages = new(this, "m_OpacityColorPages");
				}
				return r_Fm_OpacityColorPages;
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
				}
				return r_F__0__meshGenerationContext__1__k__BackingField;
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
				}
				return r_PmeshGenerationContext;
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
				}
				return r_PvisualElement;
			}
		}

		/// <summary>
		/// Void Begin(UnityEngine.UIElements.VisualElement, UnityEngine.UIElements.UIR.UIRenderDevice)
		/// </summary>
		protected RMethod r_MBegin_VisualElement_UIRenderDevice;
		public virtual RMethod RMBegin_VisualElement_UIRenderDevice
		{
			get
			{
				if(r_MBegin_VisualElement_UIRenderDevice == null)
				{
					r_MBegin_VisualElement_UIRenderDevice = new(this, "Begin", 0, typeof(UnityEngine.UIElements.VisualElement),  ReflectionUtils.GetType("UnityEngine.UIElements.UIR.UIRenderDevice"));
				}
				return r_MBegin_VisualElement_UIRenderDevice;
			}
		}

		/// <summary>
		/// Void End()
		/// </summary>
		protected RMethod r_MEnd;
		public virtual RMethod RMEnd
		{
			get
			{
				if(r_MEnd == null)
				{
					r_MEnd = new(this, "End", 0);
				}
				return r_MEnd;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_MDispose;
		public virtual RMethod RMDispose
		{
			get
			{
				if(r_MDispose == null)
				{
					r_MDispose = new(this, "Dispose", 0);
				}
				return r_MDispose;
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


		public virtual void Begin(UnityEngine.UIElements.VisualElement @ve, Hvak.Editor.Refleaction.RUnityEngine.RUIElements.RUIR.RUIRenderDevice @device)
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{@ve, @device.Value};
			var ___result = RMBegin_VisualElement_UIRenderDevice.Invoke(___genericsType, ___parameters);
		}


		public virtual void End()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMEnd.Invoke(___genericsType, ___parameters);
		}


		public virtual void Dispose()
		{
			var ___genericsType = new Type[] {};
			var ___parameters = new object[]{};
			var ___result = RMDispose.Invoke(___genericsType, ___parameters);
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
